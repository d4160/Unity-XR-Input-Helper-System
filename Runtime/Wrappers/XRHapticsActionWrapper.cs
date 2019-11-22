namespace d4160.Systems.XRInput
{
    using UnityEngine;

    public class XRHapticsActionWrapper : MonoBehaviour
    {
        public HandType handType; 
        public XRInputAction_Haptics action;

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

        public void Execute()
        {
            action.Execute();
        }
    }
}