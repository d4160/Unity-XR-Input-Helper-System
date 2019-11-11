namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.XR;

    public class InputDevicesEventsHandler : MonoBehaviour
    {
        public UnityEvent deviceConnected;
        public UnityEvent deviceDisconnected;
#if UNITY_2019_3_OR_NEWER
        public UnityEvent deviceConfigChanged;
#endif

        private void OnEnable()
        {
            InputDevices.deviceConnected += InputDevices_deviceConnected;
            InputDevices.deviceDisconnected += InputDevices_deviceDisconnected;
#if UNITY_2019_3_OR_NEWER
            InputDevices.deviceConfigChanged += InputDevices_deviceConfigChanged;
#endif
        }

        private void OnDisable()
        {
            InputDevices.deviceConnected -= InputDevices_deviceConnected;
            InputDevices.deviceDisconnected -= InputDevices_deviceDisconnected;
#if UNITY_2019_3_OR_NEWER
            InputDevices.deviceConfigChanged -= InputDevices_deviceConfigChanged;
#endif
        }

        private void InputDevices_deviceConnected(InputDevice device)
        {
            deviceConnected?.Invoke(device);
        }

        private void InputDevices_deviceDisconnected(InputDevice nodeState)
        {
            deviceDisconnected?.Invoke(nodeState);
        }

#if UNITY_2019_3_OR_NEWER
        private void InputDevices_deviceConfigChanged(InputDevice nodeState)
        {
            deviceConfigChanged?.Invoke(nodeState);
        }
#endif

        [System.Serializable]
        public class UnityEvent : UnityEvent<InputDevice>
        {
        }
    }
}