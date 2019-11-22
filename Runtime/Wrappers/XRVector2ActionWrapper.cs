namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;

    public class XRVector2ActionWrapper : MonoBehaviour
    {
        public HandType handType; 
        public XRInputAction_Vector2 action;
        public Vector2Event on2DAxis;

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
            on2DAxis?.Invoke(action.Get2DAxis());
        }
    }

    [System.Serializable]
    public class Vector2Event : UnityEvent<Vector2>
    {
    }
}