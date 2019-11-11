namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.XR;

    public enum XRInputUsages_Boolean
    {
        TriggerButton,
        GripButton,
        MenuButton,
        PrimaryButton,
        PrimaryTouch,
        Primary2DAxisClick,
        Primary2DAxisTouch,
        SecondaryButton,
        SecondaryTouch,
        Secondary2DAxisClick,
        Secondary2DAxisTouch
    }

    public enum XRInputUsages_Float
    {
        Trigger,
        Grip,
        BatteryLevel
    }

    public enum XRInputUsages_Vector2
    {
        Primary2DAxis,
        Secondary2DAxis
    }

    public enum XRInputUsages_Haptics
    {
        HapticImpulse
    }

    public static class XRInputDevicesUsage
    {
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