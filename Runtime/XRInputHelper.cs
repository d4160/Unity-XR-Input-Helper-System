namespace d4160.Systems.XRInput
{
    using UnityEngine;
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
            var value = GetTriggerButton(device);

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
        public static bool GetTriggerButtonDown(InputDevice device, float threstholdValue, ref bool stateDown)
        {
            var value = GetTrigger(device);

            if (value >= threstholdValue && !stateDown)
            {
                stateDown = true;
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
            var value = GetTriggerButton(device);

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
        public static bool GetTriggerButtonUp(InputDevice device, float threstholdValue, ref bool stateDown)
        {
            var value = GetTrigger(device);

            if (value <= threstholdValue && stateDown)
            {
                stateDown = false;
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
            var value = GetGripButton(device);

            if (value && !_previousGripButton)
            {
                _previousGripButton = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns true if the grip value is greater than thresthold value
        /// Needs a bool state value for up and down
        /// </summary>
        /// <param name="device"></param>
        /// <param name="threstholdValue"></param>
        /// <returns></returns>
        public static bool GetGripButtonDown(InputDevice device, float threstholdValue, ref bool downState)
        {
            var value = GetGrip(device);

            if (value >= threstholdValue && !downState)
            {
                downState = true;
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
            var value = GetGripButton(device);

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
        public static bool GetGripButtonUp(InputDevice device, float threstholdValue, ref bool downState)
        {
            var value = GetGrip(device);

            if (value <= threstholdValue && downState)
            {
                downState = false;
                return true;
            }

            return false;
        }

        public static bool GetMenuButtonDown(InputDevice device)
        {
            var value = GetMenuButton(device);

            if (value && !_previousMenuButton)
            {
                _previousMenuButton = true;
                return true;
            }

            return false;
        }

        public static bool GetMenuButtonUp(InputDevice device)
        {
            var value = GetMenuButton(device);

            if (!value && _previousGripButton)
            {
                _previousGripButton = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryButtonDown(InputDevice device)
        {
            var value = GetPrimaryButton(device);

            if (value && !_previousPrimaryButton)
            {
                _previousPrimaryButton = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryButtonUp(InputDevice device)
        {
            var value = GetPrimaryButton(device);

            if (!value && _previousPrimaryButton)
            {
                _previousPrimaryButton = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryTouchDown(InputDevice device)
        {
            var value = GetPrimaryTouch(device);

            if (value && !_previousPrimaryTouch)
            {
                _previousPrimaryTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimaryTouchUp(InputDevice device)
        {
            var value = GetPrimaryTouch(device);

            if (!value && _previousPrimaryTouch)
            {
                _previousPrimaryTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisClickDown(InputDevice device)
        {
            var value = GetPrimary2DAxisClick(device);

            if (value && !_previousPrimary2DAxisClick)
            {
                _previousPrimary2DAxisClick = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisClickUp(InputDevice device)
        {
            var value = GetPrimary2DAxisClick(device);

            if (!value && _previousPrimary2DAxisClick)
            {
                _previousPrimary2DAxisClick = false;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisTouchDown(InputDevice device)
        {
            var value = GetPrimary2DAxisTouch(device);

            if (value && !_previousPrimary2DAxisTouch)
            {
                _previousPrimary2DAxisTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetPrimary2DAxisTouchUp(InputDevice device)
        {
            var value = GetPrimary2DAxisTouch(device);

            if (!value && _previousPrimary2DAxisTouch)
            {
                _previousPrimary2DAxisTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryButtonDown(InputDevice device)
        {
            var value = GetSecondaryButton(device);

            if (value && !_previousSecondaryButton)
            {
                _previousSecondaryButton = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryButtonUp(InputDevice device)
        {
            var value = GetSecondaryButton(device);

            if (!value && _previousSecondaryButton)
            {
                _previousSecondaryButton = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryTouchDown(InputDevice device)
        {
            var value = GetSecondaryTouch(device);

            if (value && !_previousSecondaryTouch)
            {
                _previousSecondaryTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondaryTouchUp(InputDevice device)
        {
            var value = GetSecondaryTouch(device);

            if (!value && _previousSecondaryTouch)
            {
                _previousSecondaryTouch = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisClickDown(InputDevice device)
        {
            var value = GetSecondary2DAxisClick(device);

            if (value && !_previousSecondary2DAxisClick)
            {
                _previousSecondary2DAxisClick = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisClickUp(InputDevice device)
        {
            var value = GetSecondary2DAxisClick(device);

            if (!value && _previousSecondary2DAxisClick)
            {
                _previousSecondary2DAxisClick = false;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisTouchDown(InputDevice device)
        {
            var value = GetSecondary2DAxisTouch(device);

            if (value && !_previousSecondary2DAxisTouch)
            {
                _previousSecondary2DAxisTouch = true;
                return true;
            }

            return false;
        }

        public static bool GetSecondary2DAxisTouchUp(InputDevice device)
        {
            var value = GetSecondary2DAxisTouch(device);

            if (!value && _previousSecondary2DAxisTouch)
            {
                _previousSecondary2DAxisTouch = false;
                return true;
            }

            return false;
        }

        #region return Vector3 and Quaternion Methods
        public static Vector3 GetDeviceVelocity(InputDevice device)
        {
            Vector3 value;

            bool available = device.TryGetFeatureValue(CommonUsages.deviceVelocity, out value);

            if (available) return value;
            else return default;
        }

        public static Vector3 GetDeviceAngularVelocity(InputDevice device)
        {
            Vector3 value;

            bool available = device.TryGetFeatureValue(CommonUsages.deviceAngularVelocity, out value);

            if (available) return value;
            else return default;
        }

        public static Vector3 GetDeviceAcceleration(InputDevice device)
        {
            Vector3 value;

            bool available = device.TryGetFeatureValue(CommonUsages.deviceAcceleration, out value);

            if (available) return value;
            else return default;
        }

        public static Vector3 GetDeviceAngularAcceleration(InputDevice device)
        {
            Vector3 value;

            bool available = device.TryGetFeatureValue(CommonUsages.deviceAngularAcceleration, out value);

            if (available) return value;
            else return default;
        }

        public static Vector3 GetDevicePosition(InputDevice device)
        {
            Vector3 value;

            bool available = device.TryGetFeatureValue(CommonUsages.devicePosition, out value);

            if (available) return value;
            else return default;
        }

        public static Quaternion GetDeviceRotation(InputDevice device)
        {
            Quaternion value;

            bool available = device.TryGetFeatureValue(CommonUsages.deviceRotation, out value);

            if (available) return value;
            else return default;
        }
        #endregion

        #region return bool Methods
        public static bool GetTriggerButton(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.triggerButton, out value) && value;
        }

        public static bool GetGripButton(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.gripButton, out value) && value;
        }

        public static bool GetMenuButton(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.menuButton, out value) && value;
        }

        public static bool GetPrimaryButton(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.primaryButton, out value) && value;
        }

        public static bool GetPrimaryTouch(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.primaryTouch, out value) && value;
        }

        public static bool GetPrimary2DAxisClick(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out value) && value;
        }

        public static bool GetPrimary2DAxisTouch(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.primary2DAxisTouch, out value) && value;
        }

        public static bool GetSecondaryButton(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.secondaryButton, out value) && value;
        }

        public static bool GetSecondaryTouch(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.secondaryTouch, out value) && value;
        }

        public static bool GetSecondary2DAxisClick(InputDevice device)
        {
#if UNITY_2019_3_OR_NEWER
            bool value;
            return device.TryGetFeatureValue(CommonUsages.secondary2DAxisClick, out value) && value;
#else
            return false;
#endif
        }

        public static bool GetSecondary2DAxisTouch(InputDevice device)
        {
#if UNITY_2019_3_OR_NEWER
            bool value;
            return device.TryGetFeatureValue(CommonUsages.secondary2DAxisTouch, out value) && value;
#else
            return false;
#endif
        }

        public static bool IsTracked(InputDevice device)
        {
            bool value;

            return device.TryGetFeatureValue(CommonUsages.isTracked, out value) && value;
        }
        #endregion

        #region Vector2 return Methods
        public static Vector2 GetPrimary2DAxis(InputDevice device)
        {
            Vector2 value;

            var available = device.TryGetFeatureValue(CommonUsages.primary2DAxis, out value);

            return available ? value : default;
        }

        public static Vector2 GetSecondary2DAxis(InputDevice device)
        {
            Vector2 value;

            var available = device.TryGetFeatureValue(CommonUsages.secondary2DAxis, out value);

            return available ? value : default;
        }
        #endregion

        #region float return Methods
        public static float GetTrigger(InputDevice device)
        {
            float value;
            var available = device.TryGetFeatureValue(CommonUsages.trigger, out value);

            if (available)
                return value;
            else
                return -1;
        }

        public static float GetGrip(InputDevice device)
        {
            float value;
            var available = device.TryGetFeatureValue(CommonUsages.grip, out value);

            if (available)
                return value;
            else
                return -1;
        }

        public static float GetBatteryLevel(InputDevice device)
        {
            float value;
            var available = device.TryGetFeatureValue(CommonUsages.batteryLevel, out value);

            if (available)
                return value;
            else
                return -1;
        }
        #endregion

        #region TrackingState
        public static InputTrackingState GetTrackingState(InputDevice device)
        {
            InputTrackingState value;

            var available = device.TryGetFeatureValue(CommonUsages.trackingState, out value);

            return available ? value : default;
        }
        #endregion

        #region Haptics
        public static void SendHapticImpulse(InputDevice device, float amplitude = 0.5f, float duration = 1.0f, uint channel = 0)
        {
            HapticCapabilities capabilities;
            if (device.TryGetHapticCapabilities(out capabilities))
            {
                if (capabilities.supportsImpulse)
                {
                    device.SendHapticImpulse(channel, amplitude, duration);
                }
            }
        }
        #endregion
    }
}