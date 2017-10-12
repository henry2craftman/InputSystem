using System;
using UnityEngine;
using UnityEngine.Events;

namespace ISX
{
    using ActionListener = UnityAction<InputAction, InputControl>;

    // A named input signal that can flexibly decide which input data to tap.
    // Unlike controls, actions signal value *changes* rather than the values themselves.
    // They sit on top of controls (and each single action may reference several controls
    // collectively) and monitor the system for change.
    //
    // NOTE: Unlike InputControls, InputActions are not passive! They will actively perform
    //       processing each frame they are active whereas InputControls just sit there as
    //       long as no one is asking them directly for a value.
    //
    // NOTE: Processors on controls are *NOT* taken into account by actions. A state is
    //       considered changed if its underlying memory changes not if the final processed
    //       value changes.
    [Serializable]
    public class InputAction : ISerializationCallbackReceiver
    {
        public enum Phase
        {
            Disabled,
            Waiting,
            Started,
            Performed,
            Cancelled
        }

        public string name => m_Name;

        public Phase phase => m_CurrentPhase;

        public InputActionSet actionSet
        {
            get
            {
                if (m_ActionSet == m_PrivateActionSet)
                    return null; // Don't let lose actions expose their internal action set.
                return m_ActionSet;
            }
        }

        public InputBinding binding => new InputBinding
        {
            action = name,
            sources = m_Binding
        };

        public ReadOnlyArray<InputControl> controls
        {
            get
            {
                if (m_ActionSet == null)
                    CreatePrivateActionSet();
                if (m_ActionSet.m_Controls == null)
                    m_ActionSet.ResolveSources();
                return m_Controls;
            }
        }

        ////REVIEW: this would technically allow a GetValue<TValue>() method
        public InputControl lastSource => m_LastSource;

        public bool enabled => m_Enabled;

        public event ActionListener started
        {
            add
            {
                if (m_OnStarted == null)
                    m_OnStarted = new ActionEvent();
                m_OnStarted.AddListener(value);
            }
            remove
            {
                if (m_OnStarted != null)
                    m_OnStarted.RemoveListener(value);
            }
        }

        public event ActionListener cancelled
        {
            add
            {
                if (m_OnCancelled == null)
                    m_OnCancelled = new ActionEvent();
                m_OnCancelled.AddListener(value);
            }
            remove
            {
                if (m_OnCancelled != null)
                    m_OnCancelled.RemoveListener(value);
            }
        }

        // Listeners that are called when the action has been fully performed.
        // Passes along the control that triggered the state change and the action
        // object iself as well.
        public event ActionListener performed
        {
            add
            {
                if (m_OnPerformed == null)
                    m_OnPerformed = new ActionEvent();
                m_OnPerformed.AddListener(value);
            }
            remove
            {
                if (m_OnPerformed != null)
                    m_OnPerformed.RemoveListener(value);
            }
        }

        ////REVIEW: single modifier?
        // Construct a disabled action targeting the given sources.
        public InputAction(string name = null, string binding = null, string modifiers = null)
        {
            m_Name = name;
            m_Binding = binding;
            m_CurrentPhase = Phase.Disabled;
        }

        public void Enable()
        {
            if (m_Enabled)
                return;

            var controls = this.controls;
            var manager = InputSystem.s_Manager;

            // Let set know we're changing state.
            m_ActionSet.TellAboutActionChangingEnabledStatus(this, true);

            // Hook up state monitors for all our controls.
            for (var i = 0; i < controls.Count; ++i)
                manager.AddStateChangeMonitor(controls[i], this);

            // Done.
            m_Enabled = true;
            m_CurrentPhase = Phase.Waiting;
        }

        public void Disable()
        {
            throw new NotImplementedException();
        }

        // The action set that owns us.
        internal InputActionSet m_ActionSet;

        [SerializeField] private string m_Name;
        [SerializeField] internal string m_Binding;

        // For actions that are kept outside of any action set, we still a set to hold
        // our data. We create a hidden set private to the action. Unlike the case where
        // the action is part of a public set of actions, we need to serialize the set
        // as *part* of the action.
        // NOTE: If this is set, it will be the same as m_ActionSet.
        [SerializeField] internal InputActionSet m_PrivateActionSet;

        [SerializeField] private ActionEvent m_OnStarted;
        [SerializeField] private ActionEvent m_OnCancelled;
        [SerializeField] private ActionEvent m_OnPerformed;

        // State we keep for enabling/disabling. This is volatile and not put on disk.
        internal bool m_Enabled;
        private Phase m_CurrentPhase;
        private InputControl m_LastSource;
        internal ReadOnlyArray<InputControl> m_Controls;

        private void CreatePrivateActionSet()
        {
            m_PrivateActionSet = new InputActionSet();
            m_PrivateActionSet.AddAction(this);
        }

        private void GoToPhase(Phase newPhase, InputControl triggerControl)
        {
            m_CurrentPhase = newPhase;
            switch (newPhase)
            {
                case Phase.Started:
                    m_OnStarted?.Invoke(this, triggerControl);
                    m_LastSource = triggerControl;
                    break;

                case Phase.Performed:
                    m_OnPerformed?.Invoke(this, triggerControl);
                    m_LastSource = triggerControl;
                    break;

                case Phase.Cancelled:
                    m_OnCancelled?.Invoke(this, triggerControl);
                    m_LastSource = triggerControl;
                    break;
            }
        }

        private class ActionEvent : UnityEvent<InputAction, InputControl>
        {
        }

        // Called from InputManager when one of our state change monitors
        // has fired.
        internal void NotifyControlValueChanged(InputControl control, double time)
        {
            ////TODO: we probably should be able to specify the various trigger values
            ////      on a per control basis; maybe that's best left to modifiers, though

            ////TODO: this is where modifiers should be able to hijack phase progression
            ////      the path below should be the fallback path when there aren't any modifiers

            ////REVIEW: how should we handle update types here? always trigger in first that detects change?

            var isAtDefault = control.CheckStateIsAllZeroes();

            switch (phase)
            {
                case Phase.Waiting:
                    if (!isAtDefault)
                    {
                        GoToPhase(Phase.Performed, control);
                        m_CurrentPhase = Phase.Waiting;
                    }
                    break;
            }
        }

        void ISerializationCallbackReceiver.OnBeforeSerialize()
        {
        }

        void ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            // To not create a cycle during serialization, m_PrivateActionSet will
            // remove us from serialization so add ourselves back.
            if (m_PrivateActionSet != null)
            {
                m_PrivateActionSet.m_Actions = new InputAction[1];
                m_PrivateActionSet.m_Actions[0] = this;
            }
        }
    }
}
