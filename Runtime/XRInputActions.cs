namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.XR;

    [System.Serializable]
    public struct XRInputAction_Boolean
    {
        public XRInputUsages_Boolean usage;
        [Tooltip("Only for Trigger and Grip")]
        public float _pressThreshold; //= .85f;
        [Tooltip("Only for Trigger and Grip")]
        public float _releaseThreshold;// = .25f;

        private InputDevice _inputDevice;
        private bool _triggerState, _gripState;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public bool GetStateDown()
        {
            switch (usage)
            {
                case XRInputUsages_Boolean.TriggerButton:
                    return XRInputHelper.GetTriggerButtonDown(_inputDevice, _pressThreshold, ref _triggerState);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputHelper.GetGripButtonDown(_inputDevice, _pressThreshold, ref _gripState);
                case XRInputUsages_Boolean.MenuButton:
                    return XRInputHelper.GetMenuButtonDown(_inputDevice);
                case XRInputUsages_Boolean.PrimaryButton:
                    return XRInputHelper.GetPrimaryButtonDown(_inputDevice);
                case XRInputUsages_Boolean.PrimaryTouch:
                    return XRInputHelper.GetPrimaryTouchDown(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisClick:
                    return XRInputHelper.GetPrimary2DAxisClickDown(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisTouch:
                    return XRInputHelper.GetPrimary2DAxisTouchDown(_inputDevice);
                case XRInputUsages_Boolean.SecondaryButton:
                    return XRInputHelper.GetSecondaryButtonDown(_inputDevice);
                case XRInputUsages_Boolean.SecondaryTouch:
                    return XRInputHelper.GetSecondaryTouchDown(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisClick:
                    return XRInputHelper.GetSecondary2DAxisClickDown(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisTouch:
                    return XRInputHelper.GetSecondary2DAxisTouchDown(_inputDevice);
                default:
                    return XRInputHelper.GetMenuButtonDown(_inputDevice);
            }
        }

        public bool GetStateUp()
        {
            switch (usage)
            {
                case XRInputUsages_Boolean.TriggerButton:
                    return XRInputHelper.GetTriggerButtonUp(_inputDevice, _pressThreshold, ref _triggerState);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputHelper.GetGripButtonUp(_inputDevice, _pressThreshold, ref _gripState);
                case XRInputUsages_Boolean.MenuButton:
                    return XRInputHelper.GetMenuButtonUp(_inputDevice);
                case XRInputUsages_Boolean.PrimaryButton:
                    return XRInputHelper.GetPrimaryButtonUp(_inputDevice);
                case XRInputUsages_Boolean.PrimaryTouch:
                    return XRInputHelper.GetPrimaryTouchUp(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisClick:
                    return XRInputHelper.GetPrimary2DAxisClickUp(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisTouch:
                    return XRInputHelper.GetPrimary2DAxisTouchUp(_inputDevice);
                case XRInputUsages_Boolean.SecondaryButton:
                    return XRInputHelper.GetSecondaryButtonUp(_inputDevice);
                case XRInputUsages_Boolean.SecondaryTouch:
                    return XRInputHelper.GetSecondaryTouchUp(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisClick:
                    return XRInputHelper.GetSecondary2DAxisClickUp(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisTouch:
                    return XRInputHelper.GetSecondary2DAxisTouchUp(_inputDevice);
                default:
                    return XRInputHelper.GetMenuButtonUp(_inputDevice);
            }
        }

        public bool GetState()
        {
            switch (usage)
            {
                case XRInputUsages_Boolean.TriggerButton:
                    return XRInputHelper.GetTriggerButton(_inputDevice);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputHelper.GetGripButton(_inputDevice);
                case XRInputUsages_Boolean.MenuButton:
                    return XRInputHelper.GetMenuButton(_inputDevice);
                case XRInputUsages_Boolean.PrimaryButton:
                    return XRInputHelper.GetPrimaryButton(_inputDevice);
                case XRInputUsages_Boolean.PrimaryTouch:
                    return XRInputHelper.GetPrimaryTouch(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisClick:
                    return XRInputHelper.GetPrimary2DAxisClick(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisTouch:
                    return XRInputHelper.GetPrimary2DAxisTouch(_inputDevice);
                case XRInputUsages_Boolean.SecondaryButton:
                    return XRInputHelper.GetSecondaryButton(_inputDevice);
                case XRInputUsages_Boolean.SecondaryTouch:
                    return XRInputHelper.GetSecondaryTouch(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisClick:
                    return XRInputHelper.GetSecondary2DAxisClick(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisTouch:
                    return XRInputHelper.GetSecondary2DAxisTouch(_inputDevice);
                default:
                    return XRInputHelper.GetMenuButton(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Single
    {
        public XRInputUsages_Float usage;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public float GetAxis()
        {
            switch (usage)
            {
                case XRInputUsages_Float.Grip:
                    return XRInputHelper.GetGrip(_inputDevice);
                case XRInputUsages_Float.Trigger:
                    return XRInputHelper.GetTrigger(_inputDevice);
                case XRInputUsages_Float.BatteryLevel:
                    return XRInputHelper.GetBatteryLevel(_inputDevice);
                default:
                    return XRInputHelper.GetGrip(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Vector2
    {
        public XRInputUsages_Vector2 usage;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public Vector2 Get2DAxis()
        {
            switch (usage)
            {
                case XRInputUsages_Vector2.Primary2DAxis:
                    return XRInputHelper.GetPrimary2DAxis(_inputDevice);
                case XRInputUsages_Vector2.Secondary2DAxis:
                    return XRInputHelper.GetSecondary2DAxis(_inputDevice);
                default:
                    return XRInputHelper.GetPrimary2DAxis(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Haptics
    {
        public XRInputUsages_Haptics usage;
        public float amplitude; // .5f
        public float duration; // 1f

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public void Execute()
        {
            XRInputHelper.SendHapticImpulse(_inputDevice, amplitude, duration);
        }
    }

    [System.Serializable]
    public struct XRInputAction_Pose
    {
        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public XRInputAction_Pose(InputDevice inputDevice)
        {
            _inputDevice = inputDevice;
        }

        public Vector3 GetVelocity()
        {
            return XRInputHelper.GetDeviceVelocity(_inputDevice);
        }

        public Vector3 GetAngularVelocity()
        {
            return XRInputHelper.GetDeviceAngularVelocity(_inputDevice);
        }

        public Vector3 GetAcceleration()
        {
            return XRInputHelper.GetDeviceAcceleration(_inputDevice);
        }

        public Vector3 GetAngularAcceleration()
        {
            return XRInputHelper.GetDeviceAngularAcceleration(_inputDevice);
        }

        public Vector3 GetPosition()
        {
            return XRInputHelper.GetDevicePosition(_inputDevice);
        }

        public Quaternion GetRotation()
        {
            return XRInputHelper.GetDeviceRotation(_inputDevice);
        }
    }
}