namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.XR;

    public class InputDevicesEventsHandler : MonoBehaviour
    {
        public UnityEvent deviceConnected;
        public UnityEvent deviceDisconnected;
        public UnityEvent deviceConfigChanged;

        private void OnEnable()
        {
            InputDevices.deviceConnected += InputDevices_deviceConnected;
            InputDevices.deviceDisconnected += InputDevices_deviceDisconnected;
            InputDevices.deviceConfigChanged += InputDevices_deviceConfigChanged;
        }

        private void OnDisable()
        {
            InputDevices.deviceConnected -= InputDevices_deviceConnected;
            InputDevices.deviceDisconnected -= InputDevices_deviceDisconnected;
            InputDevices.deviceConfigChanged -= InputDevices_deviceConfigChanged;
        }

        private void InputDevices_deviceConnected(InputDevice device)
        {
            deviceConnected?.Invoke(device);
        }

        private void InputDevices_deviceDisconnected(InputDevice nodeState)
        {
            deviceDisconnected?.Invoke(nodeState);
        }

        private void InputDevices_deviceConfigChanged(InputDevice nodeState)
        {
            deviceConfigChanged?.Invoke(nodeState);
        }

        [System.Serializable]
        public class UnityEvent : UnityEvent<InputDevice>
        {
        }
    }
}