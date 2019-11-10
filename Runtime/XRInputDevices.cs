namespace d4160.Systems.XRInput
{
    using UnityEngine.XR;
    using System.Collections.Generic;

    public static class XRInputDevices
    {
        public static List<InputDevice> GetAllInputDevices()
        {
            var inputDevices = new List<InputDevice>();
            InputDevices.GetDevices(inputDevices);

            return inputDevices;
        }

        #region GetDevicesWithCharacteristics Methods
        public static List<InputDevice> GetControllers()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Controller, devices);

            return devices;
        }

        public static List<InputDevice> GetCameras()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Camera, devices);

            return devices;
        }

        public static List<InputDevice> GetEyeTrackings()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.EyeTracking, devices);

            return devices;
        }

        public static List<InputDevice> GetHandTrackings()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HandTracking, devices);

            return devices;
        }

        public static List<InputDevice> GetHeadMounteds()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HeadMounted, devices);

            return devices;
        }

        public static List<InputDevice> GetHeldInHands()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.HeldInHand, devices);

            return devices;
        }

        public static List<InputDevice> GetLefts()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Left, devices);

            return devices;
        }

        public static List<InputDevice> GetRights()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Right, devices);

            return devices;
        }

        public static List<InputDevice> GetSimulated6DOFs()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.Simulated6DOF, devices);

            return devices;
        }

        public static List<InputDevice> GetTrackedDevices()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.TrackedDevice, devices);

            return devices;
        }

        public static List<InputDevice> GetTrackingReferences()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesWithCharacteristics(InputDeviceCharacteristics.TrackingReference, devices);

            return devices;
        }
        #endregion

        #region GetDevicesAtXRNode Methods
        public static List<InputDevice> GetLeftHands()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);

            return devices;
        }

        public static List<InputDevice> GetRightHands()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.RightHand, devices);

            return devices;
        }

        public static List<InputDevice> GetCenterEyes()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.CenterEye, devices);

            return devices;
        }

        public static List<InputDevice> GetGameControllers()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.GameController, devices);

            return devices;
        }

        public static List<InputDevice> GetHardwareTrackers()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.HardwareTracker, devices);

            return devices;
        }

        public static List<InputDevice> GetHeads()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.Head, devices);

            return devices;
        }

        public static List<InputDevice> GetLeftEyes()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.LeftEye, devices);

            return devices;
        }

        public static List<InputDevice> GetRightEyes()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.RightEye, devices);

            return devices;
        }

        public static List<InputDevice> GetTrackingReferences2()
        {
            var devices = new List<InputDevice>();
            InputDevices.GetDevicesAtXRNode(XRNode.TrackingReference, devices);

            return devices;
        }
        #endregion

        #region GetDeviceAtXRNode Methods
        public static InputDevice GetLeftHand()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        }

        public static InputDevice GetRightHand()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        }

        public static InputDevice GetCenterEye()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.CenterEye);
        }

        public static InputDevice GetGameController()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.GameController);
        }

        public static InputDevice GetHardwareTracker()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.HardwareTracker);
        }

        public static InputDevice GetHead()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.Head);
        }

        public static InputDevice GetLeftEye()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.LeftEye);
        }

        public static InputDevice GetRightEye()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.RightEye);
        }

        public static InputDevice GetTrackingReference()
        {
            return InputDevices.GetDeviceAtXRNode(XRNode.TrackingReference);
        }
        #endregion
    }
}