namespace d4160.Systems.XRInput
{
    using UnityEngine.XR;

    public static class XRDeviceHelper
    {
        public static bool UserPresent => XRDevice.userPresence == UserPresenceState.Present;

        public static bool UserNotPresent => XRDevice.userPresence == UserPresenceState.NotPresent;

        public static bool UserPresenceUnknown => XRDevice.userPresence == UserPresenceState.Unknown;

        public static bool UserPresenceUnsupported => XRDevice.userPresence == UserPresenceState.Unsupported;
    }
}