#if UNITY_EDITOR && UNITY_INPUT_SYSTEM_PROJECT_WIDE_ACTIONS
using CmdEvents = UnityEngine.InputSystem.Editor.InputActionsEditorConstants.CommandEvents;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.UIElements;

namespace UnityEngine.InputSystem.Editor
{
    /// <summary>
    /// A list view to display the action maps of the currently opened input actions asset.
    /// </summary>
    internal class ActionMapsView : ViewBase<ActionMapsView.ViewState>
    {
        public ActionMapsView(VisualElement root, StateContainer stateContainer)
            : base(stateContainer)
        {
            m_Root = root;

            m_ListView = m_Root?.Q<ListView>("action-maps-list-view");
            m_ListView.selectionType = UIElements.SelectionType.Single;

            m_ListViewSelectionChangeFilter = new CollectionViewSelectionChangeFilter(m_ListView);
            m_ListViewSelectionChangeFilter.selectedIndicesChanged += (selectedIndices) =>
            {
                Dispatch(Commands.SelectActionMap((string)m_ListView.selectedItem));
            };

            m_ListView.bindItem = (element, i) =>
            {
                var treeViewItem = (InputActionMapsTreeViewItem)element;
                treeViewItem.label.text = (string)m_ListView.itemsSource[i];
                treeViewItem.EditTextFinishedCallback = newName => ChangeActionMapName(i, newName);
                treeViewItem.EditTextFinished += treeViewItem.EditTextFinishedCallback;
                treeViewItem.DeleteCallback = _ => DeleteActionMap(i);
                treeViewItem.DuplicateCallback = _ => DuplicateActionMap(i);
                treeViewItem.OnDeleteItem += treeViewItem.DeleteCallback;
                treeViewItem.OnDuplicateItem += treeViewItem.DuplicateCallback;

                ContextMenu.GetContextMenuForActionMapItem(treeViewItem);
            };
            m_ListView.makeItem = () => new InputActionMapsTreeViewItem();
            m_ListView.unbindItem = (element, i) =>
            {
                var treeViewElement = (InputActionMapsTreeViewItem)element;
                treeViewElement.Reset();
                treeViewElement.OnDeleteItem -= treeViewElement.DeleteCallback;
                treeViewElement.OnDuplicateItem -= treeViewElement.DuplicateCallback;
                treeViewElement.EditTextFinished -= treeViewElement.EditTextFinishedCallback;
            };

            m_ListView.itemsChosen += objects =>
            {
                var item = m_ListView.GetRootElementForIndex(m_ListView.selectedIndex).Q<InputActionMapsTreeViewItem>();
                item.FocusOnRenameTextField();
            };

            m_ListView.RegisterCallback<ExecuteCommandEvent>(OnExecuteCommand);
            m_ListView.RegisterCallback<ValidateCommandEvent>(OnValidateCommand);

            CreateSelector(s => new ViewStateCollection<string>(Selectors.GetActionMapNames(s)),
                (actionMapNames, state) => new ViewState(Selectors.GetSelectedActionMap(state), actionMapNames));

            addActionMapButton.clicked += AddActionMap;
        }

        private Button addActionMapButton => m_Root?.Q<Button>("add-new-action-map-button");

        public override void RedrawUI(ViewState viewState)
        {
            m_ListView.itemsSource = viewState.actionMapNames?.ToList() ?? new List<string>();
            if (viewState.selectedActionMap.HasValue)
            {
                var indexOf = viewState.actionMapNames.IndexOf(viewState.selectedActionMap.Value.name);
                m_ListView.SetSelection(indexOf);
            }
            m_ListView.Rebuild();
            RenameNewActionMaps();
        }

        public override void DestroyView()
        {
            addActionMapButton.clicked -= AddActionMap;
        }

        private void RenameNewActionMaps()
        {
            if (!m_EnterRenamingMode)
                return;
            m_ListView.ScrollToItem(m_ListView.selectedIndex);
            var element = m_ListView.GetRootElementForIndex(m_ListView.selectedIndex);
            ((InputActionMapsTreeViewItem)element).FocusOnRenameTextField();
            m_EnterRenamingMode = false;
        }

        private void DeleteActionMap(int index)
        {
            Dispatch(Commands.DeleteActionMap(index));
        }

        private void DuplicateActionMap(int index)
        {
            Dispatch(Commands.DuplicateActionMap(index));
        }

        private void ChangeActionMapName(int index, string newName)
        {
            Dispatch(Commands.ChangeActionMapName(index, newName));
        }

        private void AddActionMap()
        {
            Dispatch(Commands.AddActionMap());
            m_EnterRenamingMode = true;
        }

        private void OnExecuteCommand(ExecuteCommandEvent evt)
        {
            switch (evt.commandName)
            {
                case CmdEvents.Rename:
                    ((InputActionMapsTreeViewItem)m_ListView.GetRootElementForIndex(m_ListView.selectedIndex))?.FocusOnRenameTextField();
                    break;
                case CmdEvents.Delete:
                case CmdEvents.SoftDelete:
                    ((InputActionMapsTreeViewItem)m_ListView.GetRootElementForIndex(m_ListView.selectedIndex))?.DeleteItem();
                    break;
                case CmdEvents.Duplicate:
                    ((InputActionMapsTreeViewItem)m_ListView.GetRootElementForIndex(m_ListView.selectedIndex))?.DuplicateItem();
                    break;
                default:
                    return; // Skip StopPropagation if we didn't execute anything
            }
            evt.StopPropagation();
        }

        private void OnValidateCommand(ValidateCommandEvent evt)
        {
            // Mark commands as supported for Execute by stopping propagation of the event
            switch (evt.commandName)
            {
                case CmdEvents.Rename:
                case CmdEvents.Delete:
                case CmdEvents.SoftDelete:
                case CmdEvents.Duplicate:
                    evt.StopPropagation();
                    break;
            }
        }

        private readonly CollectionViewSelectionChangeFilter m_ListViewSelectionChangeFilter;
        private bool m_EnterRenamingMode;
        private readonly VisualElement m_Root;
        private ListView m_ListView;

        internal class ViewState
        {
            public SerializedInputActionMap? selectedActionMap;
            public IEnumerable<string> actionMapNames;

            public ViewState(SerializedInputActionMap? selectedActionMap, IEnumerable<string> actionMapNames)
            {
                this.selectedActionMap = selectedActionMap;
                this.actionMapNames = actionMapNames;
            }
        }
    }
}

#endif
