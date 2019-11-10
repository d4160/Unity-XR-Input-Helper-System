namespace d4160.Systems.XRInput
{
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.XR;

    public class InputTrackingEventsHandler : MonoBehaviour
    {
        public UnityEvent nodeAdded;
        public UnityEvent nodeRemoved;
        public UnityEvent trackingAcquired;
        public UnityEvent trackingLost;

        private void OnEnable()
        {
            InputTracking.nodeAdded += InputTracking_nodeAdded;
            InputTracking.nodeRemoved += InputTracking_nodeRemoved;
            InputTracking.trackingAcquired += InputTracking_trackingAcquired;
            InputTracking.trackingLost += InputTracking_trackingLost;
        }

        private void OnDisable()
        {
            InputTracking.nodeAdded -= InputTracking_nodeAdded;
            InputTracking.nodeRemoved -= InputTracking_nodeRemoved;
            InputTracking.trackingAcquired -= InputTracking_trackingAcquired;
            InputTracking.trackingLost -= InputTracking_trackingLost;
        }

        private void InputTracking_nodeAdded(XRNodeState nodeState)
        {
            nodeAdded?.Invoke(nodeState);
        }

        private void InputTracking_nodeRemoved(XRNodeState nodeState)
        {
            nodeRemoved?.Invoke(nodeState);
        }

        private void InputTracking_trackingAcquired(XRNodeState nodeState)
        {
            trackingAcquired?.Invoke(nodeState);
        }

        private void InputTracking_trackingLost(XRNodeState nodeState)
        {
            trackingLost?.Invoke(nodeState);
        }

        [System.Serializable]
        public class UnityEvent : UnityEvent<XRNodeState>
        {
        }
    }
}