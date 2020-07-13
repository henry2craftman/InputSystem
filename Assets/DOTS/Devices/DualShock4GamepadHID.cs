//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by DOTS Input Device Code Generator
//     version 1.1.0
//     from DualShock4GamepadHID Layout
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Input;

#pragma warning disable CS0169

namespace Unity.Input
{
    public struct DualShock4GamepadHIDEvent : IInputData
    {
        public enum Id : uint
        {
            LeftStickX = 8,
            LeftStickY = 16,
            RightStickX = 24,
            RightStickY = 32,
            DpadRight = 40,
            DpadDown = 40,
            DpadUp = 40,
            DpadLeft = 40,
            ButtonWest = 44,
            ButtonSouth = 45,
            ButtonEast = 46,
            ButtonNorth = 47,
            LeftShoulder = 48,
            RightShoulder = 49,
            LeftTriggerButton = 50,
            RightTriggerButton = 51,
            Select = 52,
            Start = 53,
            LeftStickPress = 54,
            RightStickPress = 55,
            SystemButton = 56,
            TouchpadButton = 57,
            LeftTrigger = 64,
            RightTrigger = 72,
        }

        private byte Padding0;
        public byte LeftStickX;
        public byte LeftStickY;
        public byte RightStickX;
        public byte RightStickY;
        private short Padding1;
        private byte Padding2;
        public byte LeftTrigger;
        public byte RightTrigger;
        private short Padding3;

        public unsafe bool ButtonWest
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[5] & ((1 << 4) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[5] |= (1 << 4) & 0xFF;
                else
                    ((byte*)thisPtr)[5] &= ~(1 << 4) & 0xFF;
            }
        }

        public unsafe bool ButtonSouth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[5] & ((1 << 5) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[5] |= (1 << 5) & 0xFF;
                else
                    ((byte*)thisPtr)[5] &= ~(1 << 5) & 0xFF;
            }
        }

        public unsafe bool ButtonEast
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[5] & ((1 << 6) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[5] |= (1 << 6) & 0xFF;
                else
                    ((byte*)thisPtr)[5] &= ~(1 << 6) & 0xFF;
            }
        }

        public unsafe bool ButtonNorth
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[5] & ((1 << 7) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[5] |= (1 << 7) & 0xFF;
                else
                    ((byte*)thisPtr)[5] &= ~(1 << 7) & 0xFF;
            }
        }

        public unsafe bool LeftShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 0) & 0xFF;
            }
        }

        public unsafe bool RightShoulder
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 1) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 1) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 1) & 0xFF;
            }
        }

        public unsafe bool LeftTriggerButton
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 2) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 2) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 2) & 0xFF;
            }
        }

        public unsafe bool RightTriggerButton
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 3) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 3) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 3) & 0xFF;
            }
        }

        public unsafe bool Select
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 4) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 4) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 4) & 0xFF;
            }
        }

        public unsafe bool Start
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 5) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 5) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 5) & 0xFF;
            }
        }

        public unsafe bool LeftStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 6) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 6) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 6) & 0xFF;
            }
        }

        public unsafe bool RightStickPress
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[6] & ((1 << 7) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[6] |= (1 << 7) & 0xFF;
                else
                    ((byte*)thisPtr)[6] &= ~(1 << 7) & 0xFF;
            }
        }

        public unsafe bool SystemButton
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[7] & ((1 << 0) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[7] |= (1 << 0) & 0xFF;
                else
                    ((byte*)thisPtr)[7] &= ~(1 << 0) & 0xFF;
            }
        }

        public unsafe bool TouchpadButton
        {
            get
            {
                fixed(void* thisPtr = &this)
                return (((byte*)thisPtr)[7] & ((1 << 1) & 0xFF)) != 0;
            }
            set
            {
                fixed(void* thisPtr = &this)
                if (value)
                    ((byte*)thisPtr)[7] |= (1 << 1) & 0xFF;
                else
                    ((byte*)thisPtr)[7] &= ~(1 << 1) & 0xFF;
            }
        }

        public uint Format => 1026329534;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent);
                var transforms = new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent);


                // DualShock4GamepadHIDEvent -> DualShock4GamepadHIDInput
                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftStickX
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftStickY
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightStickX
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightStickY
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.ButtonWest
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.ButtonSouth
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.ButtonEast
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.ButtonNorth
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftShoulder
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightShoulder
                };
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftTriggerButton,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftTriggerButton
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightTriggerButton,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightTriggerButton
                };
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.Select
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.Start
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftStickPress
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightStickPress
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.SystemButton,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.SystemButton
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.TouchpadButton,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.TouchpadButton
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.LeftTrigger,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.LeftTrigger
                };
                transforms[19] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.RightTrigger,
                    OutputId = (uint)DualShock4GamepadHIDInput.Id.RightTrigger
                };
                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1026329534,
                    OutputFormat = 1548550680,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 20
                };

                // DualShock4GamepadHIDEvent -> DualShockGamepadInput
                transforms[20] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)DualShockGamepadInput.Id.LeftStickX
                };
                transforms[21] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)DualShockGamepadInput.Id.LeftStickY
                };
                transforms[22] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)DualShockGamepadInput.Id.RightStickX
                };
                transforms[23] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)DualShockGamepadInput.Id.RightStickY
                };
                transforms[24] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)DualShockGamepadInput.Id.ButtonWest
                };
                transforms[25] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)DualShockGamepadInput.Id.ButtonSouth
                };
                transforms[26] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)DualShockGamepadInput.Id.ButtonEast
                };
                transforms[27] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)DualShockGamepadInput.Id.ButtonNorth
                };
                transforms[28] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)DualShockGamepadInput.Id.LeftShoulder
                };
                transforms[29] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)DualShockGamepadInput.Id.RightShoulder
                };
                transforms[30] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)DualShockGamepadInput.Id.Select
                };
                transforms[31] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)DualShockGamepadInput.Id.Start
                };
                transforms[32] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)DualShockGamepadInput.Id.LeftStickPress
                };
                transforms[33] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)DualShockGamepadInput.Id.RightStickPress
                };
                transforms[34] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.TouchpadButton,
                    OutputId = (uint)DualShockGamepadInput.Id.TouchpadButton
                };
                transforms[35] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.LeftTrigger,
                    OutputId = (uint)DualShockGamepadInput.Id.LeftTrigger
                };
                transforms[36] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.RightTrigger,
                    OutputId = (uint)DualShockGamepadInput.Id.RightTrigger
                };
                structMappings[1] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1026329534,
                    OutputFormat = 1290703193,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShockGamepadInput>(),
                    TransformStartIndex = 20,
                    TransformCount = 17
                };

                // DualShock4GamepadHIDEvent -> GamepadInput
                transforms[37] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)GamepadInput.Id.LeftStickX
                };
                transforms[38] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)GamepadInput.Id.LeftStickY
                };
                transforms[39] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)GamepadInput.Id.RightStickX
                };
                transforms[40] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)GamepadInput.Id.RightStickY
                };
                transforms[41] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonWest,
                    OutputId = (uint)GamepadInput.Id.ButtonWest
                };
                transforms[42] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonSouth,
                    OutputId = (uint)GamepadInput.Id.ButtonSouth
                };
                transforms[43] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonEast,
                    OutputId = (uint)GamepadInput.Id.ButtonEast
                };
                transforms[44] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.ButtonNorth,
                    OutputId = (uint)GamepadInput.Id.ButtonNorth
                };
                transforms[45] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftShoulder,
                    OutputId = (uint)GamepadInput.Id.LeftShoulder
                };
                transforms[46] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightShoulder,
                    OutputId = (uint)GamepadInput.Id.RightShoulder
                };
                transforms[47] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Select,
                    OutputId = (uint)GamepadInput.Id.Select
                };
                transforms[48] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.Start,
                    OutputId = (uint)GamepadInput.Id.Start
                };
                transforms[49] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.LeftStickPress,
                    OutputId = (uint)GamepadInput.Id.LeftStickPress
                };
                transforms[50] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.BitToButton),
                    InputId1 = (uint)Id.RightStickPress,
                    OutputId = (uint)GamepadInput.Id.RightStickPress
                };
                transforms[51] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.LeftTrigger,
                    OutputId = (uint)GamepadInput.Id.LeftTrigger
                };
                transforms[52] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.ByteToButton),
                    InputId1 = (uint)Id.RightTrigger,
                    OutputId = (uint)GamepadInput.Id.RightTrigger
                };
                structMappings[2] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1026329534,
                    OutputFormat = 623278190,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDEvent>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<GamepadInput>(),
                    TransformStartIndex = 37,
                    TransformCount = 16
                };

                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 3;
        private const int kTransformCount = 53;
    }

    public struct DualShock4GamepadHIDInput : IComponentData, IInputData
    {
        public Float2Input LeftStick;
        public Float2Input RightStick;
        public Float2Input Dpad;
        public HalfAxisInput LeftTrigger;
        public HalfAxisInput RightTrigger;
        public HalfAxisInput LeftStickUp;
        public AxisInput LeftStickX;
        public AxisInput LeftStickY;
        public HalfAxisInput LeftStickDown;
        public HalfAxisInput LeftStickLeft;
        public HalfAxisInput LeftStickRight;
        public HalfAxisInput RightStickUp;
        public AxisInput RightStickX;
        public AxisInput RightStickY;
        public HalfAxisInput RightStickDown;
        public HalfAxisInput RightStickLeft;
        public HalfAxisInput RightStickRight;
        public FloatInput DpadX;
        public FloatInput DpadY;
        public HalfAxisInput DpadUp;
        public HalfAxisInput DpadDown;
        public HalfAxisInput DpadLeft;
        public HalfAxisInput DpadRight;
        public ButtonInput ButtonWest;
        public ButtonInput ButtonSouth;
        public ButtonInput ButtonEast;
        public ButtonInput ButtonNorth;
        public ButtonInput LeftShoulder;
        public ButtonInput RightShoulder;
        public ButtonInput LeftTriggerButton;
        public ButtonInput RightTriggerButton;
        public ButtonInput Select;
        public ButtonInput Start;
        public ButtonInput LeftStickPress;
        public ButtonInput RightStickPress;
        public ButtonInput SystemButton;
        public ButtonInput TouchpadButton;
        public ButtonInput ButtonLeftTrigger;
        public ButtonInput ButtonRightTrigger;
        public ButtonInput ButtonLeftStickUp;
        public ButtonInput ButtonLeftStickDown;
        public ButtonInput ButtonLeftStickLeft;
        public ButtonInput ButtonLeftStickRight;
        public ButtonInput ButtonRightStickUp;
        public ButtonInput ButtonRightStickDown;
        public ButtonInput ButtonRightStickLeft;
        public ButtonInput ButtonRightStickRight;
        public ButtonInput ButtonDpadUp;
        public ButtonInput ButtonDpadDown;
        public ButtonInput ButtonDpadLeft;
        public ButtonInput ButtonDpadRight;

        public enum Id : uint
        {
            LeftStick = 0,
            RightStick = 64,
            Dpad = 128,
            LeftTrigger = 192,
            RightTrigger = 224,
            LeftStickUp = 256,
            LeftStickX = 288,
            LeftStickY = 320,
            LeftStickDown = 352,
            LeftStickLeft = 384,
            LeftStickRight = 416,
            RightStickUp = 448,
            RightStickX = 480,
            RightStickY = 512,
            RightStickDown = 544,
            RightStickLeft = 576,
            RightStickRight = 608,
            DpadX = 640,
            DpadY = 672,
            DpadUp = 704,
            DpadDown = 736,
            DpadLeft = 768,
            DpadRight = 800,
            ButtonWest = 832,
            ButtonSouth = 840,
            ButtonEast = 848,
            ButtonNorth = 856,
            LeftShoulder = 864,
            RightShoulder = 872,
            LeftTriggerButton = 880,
            RightTriggerButton = 888,
            Select = 896,
            Start = 904,
            LeftStickPress = 912,
            RightStickPress = 920,
            SystemButton = 928,
            TouchpadButton = 936,
            ButtonLeftTrigger = 944,
            ButtonRightTrigger = 952,
            ButtonLeftStickUp = 960,
            ButtonLeftStickDown = 968,
            ButtonLeftStickLeft = 976,
            ButtonLeftStickRight = 984,
            ButtonRightStickUp = 992,
            ButtonRightStickDown = 1000,
            ButtonRightStickLeft = 1008,
            ButtonRightStickRight = 1016,
            ButtonDpadUp = 1024,
            ButtonDpadDown = 1032,
            ButtonDpadLeft = 1040,
            ButtonDpadRight = 1048,
        }
        public uint Format => 1548550680;

        public DOTSInput.InputPipeline InputPipelineParts
        {
            get
            {
                var structMappings = kStructMappingCount > 0 ? new NativeArray<DOTSInput.InputStructMapping>(kStructMappingCount, Allocator.Persistent) : default;
                var transforms = kTransformCount > 0 ? new NativeArray<DOTSInput.InputTransform>(kTransformCount, Allocator.Persistent) : default;

                transforms[0] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.LeftStickX,
                    InputId2 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStick
                };
                transforms[1] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.RightStickX,
                    InputId2 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStick
                };
                transforms[2] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Combination.TwoAxesToOneFloat2),
                    InputId1 = (uint)Id.DpadX,
                    InputId2 = (uint)Id.DpadY,
                    OutputId = (uint)Id.Dpad
                };
                transforms[3] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickUp
                };
                transforms[4] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickUp,
                    OutputId = (uint)Id.ButtonLeftStickUp
                };
                transforms[5] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickY,
                    OutputId = (uint)Id.LeftStickDown
                };
                transforms[6] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickDown,
                    OutputId = (uint)Id.ButtonLeftStickDown
                };
                transforms[7] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickLeft
                };
                transforms[8] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickLeft,
                    OutputId = (uint)Id.ButtonLeftStickLeft
                };
                transforms[9] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.LeftStickX,
                    OutputId = (uint)Id.LeftStickRight
                };
                transforms[10] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.LeftStickRight,
                    OutputId = (uint)Id.ButtonLeftStickRight
                };
                transforms[11] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickUp
                };
                transforms[12] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickUp,
                    OutputId = (uint)Id.ButtonRightStickUp
                };
                transforms[13] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickY,
                    OutputId = (uint)Id.RightStickDown
                };
                transforms[14] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickDown,
                    OutputId = (uint)Id.ButtonRightStickDown
                };
                transforms[15] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.NegativeAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickLeft
                };
                transforms[16] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickLeft,
                    OutputId = (uint)Id.ButtonRightStickLeft
                };
                transforms[17] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.PositiveAxisToHalfAxis),
                    InputId1 = (uint)Id.RightStickX,
                    OutputId = (uint)Id.RightStickRight
                };
                transforms[18] = new DOTSInput.InputTransform
                {
                    Operation = DOTSInput.ToTransformOperation(DOTSInput.Conversion.HalfAxisToButton),
                    InputId1 = (uint)Id.RightStickRight,
                    OutputId = (uint)Id.ButtonRightStickRight
                };

                structMappings[0] = new DOTSInput.InputStructMapping
                {
                    InputFormat = 1548550680,
                    OutputFormat = 1548550680,
                    InputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDInput>(),
                    OutputSizeInBytes = (uint)UnsafeUtility.SizeOf<DualShock4GamepadHIDInput>(),
                    TransformStartIndex = 0,
                    TransformCount = 19
                };
                return new DOTSInput.InputPipeline
                {
                    StructMappings = structMappings,
                    Transforms = transforms,
                };
            }
        }

        private const int kStructMappingCount = 1;
        private const int kTransformCount = 19;
    }
}