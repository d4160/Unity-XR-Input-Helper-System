namespace d4160.Systems.XRInput
{
    using UnityEngine.XR;

    public static class XRInputHelper
    {
        private static bool _previousTriggerButton, _previousGripButton,
                            _previousMenuButton, _previousPrimaryButton,
                            _previousPrimaryTouch, _previousPrimary2DAxisClick,
                            _previousPrimary2DAxisTouch, _previousSecondaryButton,
                            _previousSecondaryTouch, _previousSecondary2DAxisClick,
                            _previousSecondary2DAxisTouch;
        private static bool _previousTriggerLaunched = false, _previousGripLaunched = false;
        private static bool _previousUserPresentState = false;

        public static bool BecomeUserPresentState()
        {
            var value = XRDeviceHelper.UserPresent;
            if (value && !_previousUserPresentState)
            {
                _previousUserPresentState = value;
                return true;
            }

            return false;
        }

        public static bool BecomeUserNotPresentState()
        {
            var value = XRDeviceHelper.UserPresent;
            if (!value && _previousUserPresentState)
            {
                _previousUserPresentState = value;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the user touches the TriggerButton
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static bool GetTriggerButtonDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetTriggerButton(device);

            if (value && !_previousTriggerButton)
            {
                _previousTriggerButton = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the trigger value is greater than threstholdValue
        /// </summary>
        /// <param name="device"></param>
        /// <param name="threstholdValue"></param>
        /// <returns></returns>
        public static bool GetTriggerButtonDown(InputDevice device, float threstholdValue)
        {
            var value = XRInputDevicesUsage.GetTrigger(device);

            if (value >= threstholdValue && !_previousTriggerLaunched)
            {
                _previousTriggerLaunched = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the user release the TriggerButton
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static bool GetTriggerButtonUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetTriggerButton(device);

            if (!value && _previousTriggerButton)
            {
                _previousTriggerButton = false;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the trigger value is lower than threstholdValue
        /// </summary>
        /// <param name="device"></param>
        /// <param name="threstholdValue"></param>
        /// <returns></returns>
        public static bool GetTriggerButtonUp(InputDevice device, float threstholdValue)
        {
            var value = XRInputDevicesUsage.GetTrigger(device);

            if (value <= threstholdValue && _previousTriggerLaunched)
            {
                _previousTriggerLaunched = false;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the user touches the GripButton
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static bool GetGripButtonDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetGripButton(device);

            if (value && !_previousGripButton)
            {
                _previousGripButton = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the grip value is greater than threstholdValue
        /// </summary>
        /// <param name="device"></param>
        /// <param name="threstholdValue"></param>
        /// <returns></returns>
        public static bool GetGripButtonDown(InputDevice device, float threstholdValue)
        {
            var value = XRInputDevicesUsage.GetGrip(device);

            if (value >= threstholdValue && !_previousGripLaunched)
            {
                _previousGripLaunched = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the user release the GripButton
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static bool GetGripButtonUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetGripButton(device);

            if (!value && _previousGripButton)
            {
                _previousGripButton = false;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the trigger value is lower than threstholdValue
        /// </summary>
        /// <param name="device"></param>
        /// <param name="threstholdValue"></param>
        /// <returns></returns>
        public static bool GetGripButtonUp(InputDevice device, float threstholdValue)
        {
            var value = XRInputDevicesUsage.GetGrip(device);

            if (value <= threstholdValue && _previousGripLaunched)
            {
                _previousGripLaunched = false;
                return true;
            }

            return false;
        }

        public static bool GetMenuButtonDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetMenuButton(device);

            if (value && !_previousMenuButton)
            {
                _previousMenuButton = true;
                return true;
            }

            return false;
        }

        public static bool GetMenuButtonUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetMenuButton(device);

            if (!value && _previousGripButton)
            {
                _previousGripButton = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryButtonDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimaryButton(device);

            if (value && !_previousPrimaryButton)
            {
                _previousPrimaryButton = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryButtonUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimaryButton(device);

            if (!value && _previousPrimaryButton)
            {
                _previousPrimaryButton = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryTouchDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimaryTouch(device);

            if (value && !_previousPrimaryTouch)
            {
                _previousPrimaryTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryTouchUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimaryTouch(device);

            if (!value && _previousPrimaryTouch)
            {
                _previousPrimaryTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisClickDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimary2DAxisClick(device);

            if (value && !_previousPrimary2DAxisClick)
            {
                _previousPrimary2DAxisClick = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisClickUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimary2DAxisClick(device);

            if (!value && _previousPrimary2DAxisClick)
            {
                _previousPrimary2DAxisClick = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisTouchDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimary2DAxisTouch(device);

            if (value && !_previousPrimary2DAxisTouch)
            {
                _previousPrimary2DAxisTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisTouchUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetPrimary2DAxisTouch(device);

            if (!value && _previousPrimary2DAxisTouch)
            {
                _previousPrimary2DAxisTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryButtonDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondaryButton(device);

            if (value && !_previousSecondaryButton)
            {
                _previousSecondaryButton = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryButtonUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondaryButton(device);

            if (!value && _previousSecondaryButton)
            {
                _previousSecondaryButton = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryTouchDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondaryTouch(device);

            if (value && !_previousSecondaryTouch)
            {
                _previousSecondaryTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryTouchUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondaryTouch(device);

            if (!value && _previousSecondaryTouch)
            {
                _previousSecondaryTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisClickDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondary2DAxisClick(device);

            if (value && !_previousSecondary2DAxisClick)
            {
                _previousSecondary2DAxisClick = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisClickUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondary2DAxisClick(device);

            if (!value && _previousSecondary2DAxisClick)
            {
                _previousSecondary2DAxisClick = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisTouchDown(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondary2DAxisTouch(device);

            if (value && !_previousSecondary2DAxisTouch)
            {
                _previousSecondary2DAxisTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisTouchUp(InputDevice device)
        {
            var value = XRInputDevicesUsage.GetSecondary2DAxisTouch(device);

            if (!value && _previousSecondary2DAxisTouch)
            {
                _previousSecondary2DAxisTouch = false;
                return true;
            }

            return false;
        }
    }
}