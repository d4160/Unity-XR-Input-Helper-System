namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;

    public class XRSingleActionWrapper : MonoBehaviour
    {
        public HandType handType; 
        public XRInputAction_Single action;
        public FloatEvent onAxis;

        void Start()
        {
            switch(handType)
            {
                case HandType.Left:
                    action.InputDevice = XRDeviceHelper.GetLeftHand();
                break;
                case HandType.Right:
                    action.InputDevice = XRDeviceHelper.GetRightHand();
                break;
            }
        }

        void Update()
        {
            onAxis?.Invoke(action.GetAxis());
        }
    }

    [System.Serializable]
    public class FloatEvent : UnityEvent<float>
    {
    }
}