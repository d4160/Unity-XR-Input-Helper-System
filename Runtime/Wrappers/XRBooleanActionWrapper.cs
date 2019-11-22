namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;

    public class XRBooleanActionWrapper : MonoBehaviour
    {
        public HandType handType; 
        public XRInputAction_Boolean action;
        public UnityEvent onStateDown;
        public UnityEvent onStateUp;

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
            if (action.GetStateDown())
            {
                onStateDown?.Invoke();
            }
            else if (action.GetStateUp())
            {
                onStateUp?.Invoke();
            }
        }
    }
}