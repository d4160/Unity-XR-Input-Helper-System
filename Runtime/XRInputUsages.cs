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

    public enum HandType
    {
        Left,
        Right
    }
}