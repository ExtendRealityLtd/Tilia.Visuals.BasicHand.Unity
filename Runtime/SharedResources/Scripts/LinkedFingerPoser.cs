namespace Tilia.Visuals.BasicHand
{
    using System;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// Poses the linked Finger.
    /// </summary>
    public class LinkedFingerPoser : Finger
    {
        /// <summary>
        /// A temporary class to hold the linked finger data for restoration.
        /// </summary>
        protected class FingerDataCache : Finger { }

        /// <summary>
        /// The property values to set when posing.
        /// </summary>
        [Flags]
        public enum PoseValues
        {
            /// <summary>
            /// The source of the input for the finger.
            /// </summary>
            InputSource = 1 << 0,
            /// <summary>
            /// The float for the finger curl data.
            /// </summary>
            FloatData = 1 << 1,
            /// <summary>
            /// The boolean for the finger curl data.
            /// </summary>
            BoolData = 1 << 2,
            /// <summary>
            /// The value to force to be used for the finger curl data.
            /// </summary>
            OverrideValue = 1 << 3,
            /// <summary>
            /// The minimum and maximum limits of the given float data.
            /// </summary>
            FloatLimits = 1 << 4,
            /// <summary>
            /// The minimum and maximum limits that the finger curl can extend or retract to.
            /// </summary>
            CurlLimits = 1 << 5,
            /// <summary>
            /// The speed in which to transition the finger to the destination value.
            /// </summary>
            TransitionSpeed = 1 << 6,
            /// <summary>
            /// The distance the current curl value has to be away from the input curl value for it to transition to that state.
            /// </summary>
            ForceTransitionThreshold = 1 << 7
        }

        #region Finger Pose Settings
        [Header("Finger Pose Settings")]
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
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The Finger to change with the set poses.")]
        [SerializeField]
        [Restricted]
        private Finger target;
        /// <summary>
        /// The <see cref="Finger"/> to change with the set poses.
        /// </summary>
        public Finger Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
            }
        }
        #endregion

        /// <summary>
        /// The cache of data from the linked <see cref="Target"/>.
        /// </summary>
        protected FingerDataCache cachedFingerData;

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
        /// Applies the set finger pose to the linked <see cref="Target"/>.
        /// </summary>
        public virtual void ApplyPose()
        {
            if (!this.IsValidState())
            {
                return;
            }

            CopyData(Target, cachedFingerData, true);
            CopyData(this, Target);
        }

        /// <summary>
        /// Removes the applied pose and resets the linked <see cref="Target"/> back to the <see cref="cachedFingerData"/>.
        /// </summary>
        public virtual void RemovePose()
        {
            if (!this.IsValidState())
            {
                return;
            }

            CopyData(cachedFingerData, Target, true);
        }

        protected virtual void Awake()
        {
            cachedFingerData = gameObject.AddComponent<FingerDataCache>();
        }

        /// <summary>
        /// Copies property data from the source to the target.
        /// </summary>
        /// <param name="source">The source to copy the data from.</param>
        /// <param name="target">The target to copy the data to.</param>
        /// <param name="ignoreUsePoseValues">Whether to ignore the <see cref="ApplyPoseValues"/> restrictions and set every property.</param>
        protected virtual void CopyData(Finger source, Finger target, bool ignoreUsePoseValues = false)
        {
            if (source == null || target == null)
            {
                return;
            }

            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.InputSource) != 0)
            {
                target.InputSource = source.InputSource;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.FloatData) != 0)
            {
                target.FloatData = source.FloatData;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.BoolData) != 0)
            {
                target.BoolData = source.BoolData;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.OverrideValue) != 0)
            {
                target.OverrideValue = source.OverrideValue;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.FloatLimits) != 0)
            {
                target.FloatLimits = source.FloatLimits;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.CurlLimits) != 0)
            {
                target.CurlLimits = source.CurlLimits;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.TransitionSpeed) != 0)
            {
                target.TransitionSpeed = source.TransitionSpeed;
            }
            if (ignoreUsePoseValues || (ApplyPoseValues & PoseValues.ForceTransitionThreshold) != 0)
            {
                target.ForceTransitionThreshold = source.ForceTransitionThreshold;
            }
        }
    }
}