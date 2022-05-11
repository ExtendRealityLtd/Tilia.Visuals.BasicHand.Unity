namespace Tilia.Visuals.BasicHand
{
    using System;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// Applies a predefined pose to the given <see cref="Target"/>.
    /// </summary>
    public class HandPoserFacade : MonoBehaviour
    {
        /// <summary>
        /// The property values to set when posing.
        /// </summary>
        [Flags]
        public enum PoseValues
        {
            /// <summary>
            /// The collider state of the linked hand.
            /// </summary>
            ColliderState = 1 << 0,
            /// <summary>
            /// The local position of the linked hand.
            /// </summary>
            PositionOverride = 1 << 1,
            /// <summary>
            /// The local euler rotation of the linked hand.
            /// </summary>
            RotationOverride = 1 << 2,
            /// <summary>
            /// The local scale of the linked hand.
            /// </summary>
            ScaleOverride = 1 << 3
        }

        #region Target Settings
        [Header("Target Settings")]
        [Tooltip("The HandFacade to pose.")]
        [SerializeField]
        private HandFacade target;
        /// <summary>
        /// The <see cref="HandFacade"/> to pose.
        /// </summary>
        public HandFacade Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetChange();
                }
            }
        }
        #endregion

        #region Hand Pose Settings
        [Header("Hand Pose Settings")]
        [Tooltip("The property values on the Target to apply when posing.")]
        [SerializeField]
        [UnityFlags]
        private PoseValues applyPoseValues = (PoseValues)(0);
        /// <summary>
        /// The property values on the <see cref="Target"/> to apply when posing.
        /// </summary>
        public PoseValues ApplyPoseValues
        {
            get
            {
                return applyPoseValues;
            }
            set
            {
                applyPoseValues = value;
            }
        }
        [Tooltip("Determines the activation state of the colliders on the Target.")]
        [SerializeField]
        private bool colliderState;
        /// <summary>
        /// Determines the activation state of the colliders on the <see cref="Target"/>.
        /// </summary>
        public bool ColliderState
        {
            get
            {
                return colliderState;
            }
            set
            {
                colliderState = value;
            }
        }
        [Tooltip("Apply a local position override on the Target.")]
        [SerializeField]
        private Vector3 positionOverride;
        /// <summary>
        /// Apply a local position override on the <see cref="Target"/>.
        /// </summary>
        public Vector3 PositionOverride
        {
            get
            {
                return positionOverride;
            }
            set
            {
                positionOverride = value;
            }
        }
        [Tooltip("Apply a local euler rotation override on the Target.")]
        [SerializeField]
        private Vector3 rotationOverride;
        /// <summary>
        /// Apply a local euler rotation override on the <see cref="Target"/>.
        /// </summary>
        public Vector3 RotationOverride
        {
            get
            {
                return rotationOverride;
            }
            set
            {
                rotationOverride = value;
            }
        }
        [Tooltip("Apply a local scale override on the Target.")]
        [SerializeField]
        private Vector3 scaleOverride = Vector3.one;
        /// <summary>
        /// Apply a local scale override on the <see cref="Target"/>.
        /// </summary>
        public Vector3 ScaleOverride
        {
            get
            {
                return scaleOverride;
            }
            set
            {
                scaleOverride = value;
            }
        }
        #endregion

        #region Finger Settings
        [Header("Finger Settings")]
        [Tooltip("The Thumb to pose.")]
        [SerializeField]
        [Restricted]
        private LinkedFingerPoser thumbPose;
        /// <summary>
        /// The Thumb to pose.
        /// </summary>
        public LinkedFingerPoser ThumbPose
        {
            get
            {
                return thumbPose;
            }
            protected set
            {
                thumbPose = value;
            }
        }
        [Tooltip("The Index Finger to pose.")]
        [SerializeField]
        [Restricted]
        private LinkedFingerPoser indexFingerPose;
        /// <summary>
        /// The Index Finger to pose.
        /// </summary>
        public LinkedFingerPoser IndexFingerPose
        {
            get
            {
                return indexFingerPose;
            }
            protected set
            {
                indexFingerPose = value;
            }
        }
        [Tooltip("The Middle Finger to pose.")]
        [SerializeField]
        [Restricted]
        private LinkedFingerPoser middleFingerPose;
        /// <summary>
        /// The Middle Finger to pose.
        /// </summary>
        public LinkedFingerPoser MiddleFingerPose
        {
            get
            {
                return middleFingerPose;
            }
            protected set
            {
                middleFingerPose = value;
            }
        }
        [Tooltip("The Ring Finger to pose.")]
        [SerializeField]
        [Restricted]
        private LinkedFingerPoser ringFingerPose;
        /// <summary>
        /// The Ring Finger to pose.
        /// </summary>
        public LinkedFingerPoser RingFingerPose
        {
            get
            {
                return ringFingerPose;
            }
            protected set
            {
                ringFingerPose = value;
            }
        }
        [Tooltip("The Pinky Finger to pose.")]
        [SerializeField]
        [Restricted]
        private LinkedFingerPoser pinkyFingerPose;
        /// <summary>
        /// The Pinky Finger to pose.
        /// </summary>
        public LinkedFingerPoser PinkyFingerPose
        {
            get
            {
                return pinkyFingerPose;
            }
            protected set
            {
                pinkyFingerPose = value;
            }
        }
        #endregion

        /// <summary>
        /// The cached collider state of the <see cref="Target"/>.
        /// </summary>
        protected bool cachedColliderState;
        /// <summary>
        /// The cached <see cref="Transform.localPosition"/> of the <see cref="Target"/>.
        /// </summary>
        protected Vector3 cachedPosition;
        /// <summary>
        /// The cached <see cref="Transform.localRotation"/> of the <see cref="Target"/>.
        /// </summary>
        protected Quaternion cachedRotation;
        /// <summary>
        /// The cached <see cref="Transform.localScale"/> of the <see cref="Target"/>.
        /// </summary>
        protected Vector3 cachedScale;

        /// <summary>
        /// Clears <see cref="Target"/>.
        /// </summary>
        public virtual void ClearTarget()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Target = default;
        }

        /// <summary>
        /// Applies the set pose.
        /// </summary>
        public virtual void ApplyPose()
        {
            if (!this.IsValidState() || Target == null)
            {
                return;
            }

            CacheData();

            ApplyData();
            ThumbPose.ApplyPose();
            IndexFingerPose.ApplyPose();
            MiddleFingerPose.ApplyPose();
            RingFingerPose.ApplyPose();
            PinkyFingerPose.ApplyPose();
        }

        /// <summary>
        /// Removes the applied pose.
        /// </summary>
        public virtual void RemovePose()
        {
            if (!this.IsValidState() || Target == null)
            {
                return;
            }

            ThumbPose.RemovePose();
            IndexFingerPose.RemovePose();
            MiddleFingerPose.RemovePose();
            RingFingerPose.RemovePose();
            PinkyFingerPose.RemovePose();
            RestoreFromCache();
        }

        protected virtual void OnEnable()
        {
            OnAfterTargetChange();
        }

        /// <summary>
        /// Applies the valid pose data values to the <see cref="Target"/>.
        /// </summary>
        protected virtual void ApplyData()
        {
            {
                if (Target == null)
                {
                    return;
                }

                if ((ApplyPoseValues & PoseValues.ColliderState) != 0)
                {
                    Target.ColliderContainer.SetActive(ColliderState);
                }
                if ((ApplyPoseValues & PoseValues.PositionOverride) != 0)
                {
                    Target.transform.localPosition = PositionOverride;
                }
                if ((ApplyPoseValues & PoseValues.RotationOverride) != 0)
                {
                    Target.transform.localEulerAngles = RotationOverride;
                }
                if ((ApplyPoseValues & PoseValues.ScaleOverride) != 0)
                {
                    Target.transform.localScale = ScaleOverride;
                }
            }
        }

        /// <summary>
        /// Caches the <see cref="Target"/> data.
        /// </summary>
        protected virtual void CacheData()
        {
            if (Target == null)
            {
                return;
            }

            cachedColliderState = Target.ColliderContainer.activeSelf;
            cachedPosition = Target.transform.localPosition;
            cachedRotation = Target.transform.localRotation;
            cachedScale = Target.transform.localScale;
        }

        /// <summary>
        /// Restores the <see cref="Target"/> data from the cache.
        /// </summary>
        protected virtual void RestoreFromCache()
        {
            if (Target == null)
            {
                return;
            }

            Target.ColliderContainer.SetActive(cachedColliderState);
            Target.transform.localPosition = cachedPosition;
            Target.transform.localRotation = cachedRotation;
            Target.transform.localScale = cachedScale;
        }

        /// <summary>
        /// Called after <see cref="Target"/>.
        /// </summary>
        protected virtual void OnAfterTargetChange()
        {
            ThumbPose.Target = Target != null ? Target.Thumb : null;
            IndexFingerPose.Target = Target != null ? Target.IndexFinger : null;
            MiddleFingerPose.Target = Target != null ? Target.MiddleFinger : null;
            RingFingerPose.Target = Target != null ? Target.RingFinger : null;
            PinkyFingerPose.Target = Target != null ? Target.PinkyFinger : null;
        }
    }
}