namespace d4160.Systems.XRInput
{
  using UnityEngine;
  using UnityEngine.XR;

    [System.Serializable]
    public struct XRInputAction_Boolean
    {
        public XRInputUsages_Boolean usage;
        [Tooltip("Only for Trigger and Grip")]
        public float pressThreshold; //= .85f;
        [Tooltip("Only for Trigger and Grip")]
        public float releaseThreshold;// = .25f;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public XRInputAction_Boolean(InputDevice device, float pressThreshold = .85f, float releaseThreshold = .25f)
        {
            _inputDevice = device;

            usage = default;
            this.pressThreshold = pressThreshold;
            this.releaseThreshold = releaseThreshold;
        }

        public bool GetStateDown()
        {
            switch (usage)
            {
                case XRInputUsages_Boolean.TriggerButton:
                    return XRInputHelper.GetTriggerButtonDown(_inputDevice, pressThreshold);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputHelper.GetGripButtonDown(_inputDevice, pressThreshold);
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
                    return XRInputHelper.GetTriggerButtonUp(_inputDevice, pressThreshold);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputHelper.GetGripButtonUp(_inputDevice, pressThreshold);
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
                    return XRInputDevicesUsage.GetTriggerButton(_inputDevice);
                case XRInputUsages_Boolean.GripButton:
                    return XRInputDevicesUsage.GetGripButton(_inputDevice);
                case XRInputUsages_Boolean.MenuButton:
                    return XRInputDevicesUsage.GetMenuButton(_inputDevice);
                case XRInputUsages_Boolean.PrimaryButton:
                    return XRInputDevicesUsage.GetPrimaryButton(_inputDevice);
                case XRInputUsages_Boolean.PrimaryTouch:
                    return XRInputDevicesUsage.GetPrimaryTouch(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisClick:
                    return XRInputDevicesUsage.GetPrimary2DAxisClick(_inputDevice);
                case XRInputUsages_Boolean.Primary2DAxisTouch:
                    return XRInputDevicesUsage.GetPrimary2DAxisTouch(_inputDevice);
                case XRInputUsages_Boolean.SecondaryButton:
                    return XRInputDevicesUsage.GetSecondaryButton(_inputDevice);
                case XRInputUsages_Boolean.SecondaryTouch:
                    return XRInputDevicesUsage.GetSecondaryTouch(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisClick:
                    return XRInputDevicesUsage.GetSecondary2DAxisClick(_inputDevice);
                case XRInputUsages_Boolean.Secondary2DAxisTouch:
                    return XRInputDevicesUsage.GetSecondary2DAxisTouch(_inputDevice);
                default:
                    return XRInputDevicesUsage.GetMenuButton(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Single
    {
        public XRInputUsages_Float usage;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public XRInputAction_Single(InputDevice device)
        {
            _inputDevice = device;

            usage = default;
        }

        public float GetAxis()
        {
            switch (usage)
            {
                case XRInputUsages_Float.Grip:
                    return XRInputDevicesUsage.GetGrip(_inputDevice);
                case XRInputUsages_Float.Trigger:
                    return XRInputDevicesUsage.GetTrigger(_inputDevice);
                case XRInputUsages_Float.BatteryLevel:
                    return XRInputDevicesUsage.GetBatteryLevel(_inputDevice);
                default:
                    return XRInputDevicesUsage.GetGrip(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Vector2
    {
        public XRInputUsages_Vector2 usage;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public XRInputAction_Vector2(InputDevice device)
        {
            _inputDevice = device;

            usage = default;
        }

        public Vector2 GetState()
        {
            switch (usage)
            {
                case XRInputUsages_Vector2.Primary2DAxis:
                    return XRInputDevicesUsage.GetPrimary2DAxis(_inputDevice);
                case XRInputUsages_Vector2.Secondary2DAxis:
                    return XRInputDevicesUsage.GetSecondary2DAxis(_inputDevice);
                default:
                    return XRInputDevicesUsage.GetPrimary2DAxis(_inputDevice);
            }
        }
    }

    [System.Serializable]
    public struct XRInputAction_Haptics
    {
        public XRInputUsages_Haptics usage;
        public float amplitude;
        public float duration;

        private InputDevice _inputDevice;

        public InputDevice InputDevice { get => _inputDevice; set => _inputDevice = value; }

        public XRInputAction_Haptics(InputDevice device, float amplitude = .5f, float duration = 1.0f)
        {
            _inputDevice = device;

            usage = default;
            this.amplitude = amplitude;
            this.duration = duration;
        }

        public void Execute()
        {
            XRInputDevicesUsage.SendHapticImpulse(_inputDevice, amplitude, duration);
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
            return XRInputDevicesUsage.GetDeviceVelocity(_inputDevice);
        }

        public Vector3 GetAngularVelocity()
        {
            return XRInputDevicesUsage.GetDeviceAngularVelocity(_inputDevice);
        }

        public Vector3 GetAcceleration()
        {
            return XRInputDevicesUsage.GetDeviceAcceleration(_inputDevice);
        }

        public Vector3 GetAngularAcceleration()
        {
            return XRInputDevicesUsage.GetDeviceAngularAcceleration(_inputDevice);
        }

        public Vector3 GetPosition()
        {
            return XRInputDevicesUsage.GetDevicePosition(_inputDevice);
        }

        public Quaternion GetRotation()
        {
            return XRInputDevicesUsage.GetDeviceRotation(_inputDevice);
        }
    }
}