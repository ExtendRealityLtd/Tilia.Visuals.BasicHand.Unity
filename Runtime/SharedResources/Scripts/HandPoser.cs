namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;
    using Zinnia.Extension;

    /// <summary>
    /// Poses the hand using pre-defined settings.
    /// </summary>
    public class HandPoser : MonoBehaviour
    {
        [Tooltip("The hand to pose.")]
        [SerializeField]
        private HandFacade hand;
        /// <summary>
        /// The hand to pose.
        /// </summary>
        public HandFacade Hand
        {
            get
            {
                return hand;
            }
            set
            {
                hand = value;
            }
        }
        [Tooltip("The curl value for the Thumb.")]
        [SerializeField]
        private float thumbValue;
        /// <summary>
        /// The curl value for the Thumb.
        /// </summary>
        public float ThumbValue
        {
            get
            {
                return thumbValue;
            }
            set
            {
                thumbValue = value;
            }
        }
        [Tooltip("The curl value for the Index Finger.")]
        [SerializeField]
        private float indexFingerValue;
        /// <summary>
        /// The curl value for the Index Finger.
        /// </summary>
        public float IndexFingerValue
        {
            get
            {
                return indexFingerValue;
            }
            set
            {
                indexFingerValue = value;
            }
        }
        [Tooltip("The curl value for the Middle Finger.")]
        [SerializeField]
        private float middleFingerValue;
        /// <summary>
        /// The curl value for the Middle Finger.
        /// </summary>
        public float MiddleFingerValue
        {
            get
            {
                return middleFingerValue;
            }
            set
            {
                middleFingerValue = value;
            }
        }
        [Tooltip("The curl value for the Ring Finger.")]
        [SerializeField]
        private float ringFingerValue;
        /// <summary>
        /// The curl value for the Ring Finger.
        /// </summary>
        public float RingFingerValue
        {
            get
            {
                return ringFingerValue;
            }
            set
            {
                ringFingerValue = value;
            }
        }
        [Tooltip("The curl value for the Pinky Finger.")]
        [SerializeField]
        private float pinkyFingerValue;
        /// <summary>
        /// The curl value for the Pinky Finger.
        /// </summary>
        public float PinkyFingerValue
        {
            get
            {
                return pinkyFingerValue;
            }
            set
            {
                pinkyFingerValue = value;
            }
        }

        /// <summary>
        /// The cached existing input sources.
        /// </summary>
        protected FingerController.InputType[] cachedInputSources = new FingerController.InputType[5];
        /// <summary>
        /// The cached existing current finger values.
        /// </summary>
        protected float[] cachedCurrentValues = new float[5];
        /// <summary>
        /// The cached existing current override values.
        /// </summary>
        protected float[] cachedOverrideValues = new float[5];

        /// <summary>
        /// Clears <see cref="Hand"/>.
        /// </summary>
        public virtual void ClearHand()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Hand = default;
        }

        /// <summary>
        /// Activates the pose.
        /// </summary>
        public virtual void ActivatePose()
        {
            if (!this.IsValidState() || hand == null)
            {
                return;
            }

            CacheInputSources();
            CacheCurrentValues();
            CacheOverrideValues();

            SetOverrideValues(ThumbValue, IndexFingerValue, MiddleFingerValue, RingFingerValue, PinkyFingerValue);
            SetInputSources(FingerController.InputType.Override, FingerController.InputType.Override, FingerController.InputType.Override, FingerController.InputType.Override, FingerController.InputType.Override);
        }

        /// <summary>
        /// Deactivates the pose and restores the previous hand state.
        /// </summary>
        /// <param name="restorePreviousHandValues">Whether to restore the previous hand values.</param>
        public virtual void DeactivatePose(bool restorePreviousHandValues)
        {
            RestoreInputSources();
            RestoreOverrideValues();
            if (restorePreviousHandValues)
            {
                RestoreCurrentValues();
            }
        }

        /// <summary>
        /// Sets the input sources on the hand.
        /// </summary>
        /// <param name="thumb">The thumb property.</param>
        /// <param name="index">The index finger property.</param>
        /// <param name="middle">The middle finger property.</param>
        /// <param name="ring">The ring finger property.</param>
        /// <param name="pinky">The pinky finger property.</param>
        protected virtual void SetInputSources(FingerController.InputType thumb, FingerController.InputType index, FingerController.InputType middle, FingerController.InputType ring, FingerController.InputType pinky)
        {
            hand.Thumb.InputSource = thumb;
            hand.IndexFinger.InputSource = index;
            hand.MiddleFinger.InputSource = middle;
            hand.RingFinger.InputSource = ring;
            hand.PinkyFinger.InputSource = pinky;
        }

        /// <summary>
        /// Sets the current values on the hand.
        /// </summary>
        /// <param name="thumb">The thumb property.</param>
        /// <param name="index">The index finger property.</param>
        /// <param name="middle">The middle finger property.</param>
        /// <param name="ring">The ring finger property.</param>
        /// <param name="pinky">The pinky finger property.</param>
        protected virtual void SetCurrentValues(float thumb, float index, float middle, float ring, float pinky)
        {
            hand.Thumb.CurrentCurlValue = thumb;
            hand.IndexFinger.CurrentCurlValue = index;
            hand.MiddleFinger.CurrentCurlValue = middle;
            hand.RingFinger.CurrentCurlValue = ring;
            hand.PinkyFinger.CurrentCurlValue = pinky;
        }

        /// <summary>
        /// Sets the override values on the hand.
        /// </summary>
        /// <param name="thumb">The thumb property.</param>
        /// <param name="index">The index finger property.</param>
        /// <param name="middle">The middle finger property.</param>
        /// <param name="ring">The ring finger property.</param>
        /// <param name="pinky">The pinky finger property.</param>
        protected virtual void SetOverrideValues(float thumb, float index, float middle, float ring, float pinky)
        {
            hand.Thumb.OverrideValue = thumb;
            hand.IndexFinger.OverrideValue = index;
            hand.MiddleFinger.OverrideValue = middle;
            hand.RingFinger.OverrideValue = ring;
            hand.PinkyFinger.OverrideValue = pinky;
        }

        /// <summary>
        /// Caches the existing hand input sources.
        /// </summary>
        protected virtual void CacheInputSources()
        {
            cachedInputSources[0] = hand.Thumb.InputSource;
            cachedInputSources[1] = hand.IndexFinger.InputSource;
            cachedInputSources[2] = hand.MiddleFinger.InputSource;
            cachedInputSources[3] = hand.RingFinger.InputSource;
            cachedInputSources[4] = hand.PinkyFinger.InputSource;
        }

        /// <summary>
        /// Caches the existing hand current values.
        /// </summary>
        protected virtual void CacheCurrentValues()
        {
            cachedCurrentValues[0] = hand.Thumb.CurrentCurlValue;
            cachedCurrentValues[1] = hand.IndexFinger.CurrentCurlValue;
            cachedCurrentValues[2] = hand.MiddleFinger.CurrentCurlValue;
            cachedCurrentValues[3] = hand.RingFinger.CurrentCurlValue;
            cachedCurrentValues[4] = hand.PinkyFinger.CurrentCurlValue;
        }

        /// <summary>
        /// Caches the existing hand override values.
        /// </summary>
        protected virtual void CacheOverrideValues()
        {
            cachedOverrideValues[0] = hand.Thumb.OverrideValue;
            cachedOverrideValues[1] = hand.IndexFinger.OverrideValue;
            cachedOverrideValues[2] = hand.MiddleFinger.OverrideValue;
            cachedOverrideValues[3] = hand.RingFinger.OverrideValue;
            cachedOverrideValues[4] = hand.PinkyFinger.OverrideValue;
        }

        /// <summary>
        /// Restores the cached hand input sources.
        /// </summary>
        protected virtual void RestoreInputSources()
        {
            SetInputSources(cachedInputSources[0], cachedInputSources[1], cachedInputSources[2], cachedInputSources[3], cachedInputSources[4]);
        }

        /// <summary>
        /// Restores the cached hand current values.
        /// </summary>
        protected virtual void RestoreCurrentValues()
        {
            SetCurrentValues(cachedCurrentValues[0], cachedCurrentValues[1], cachedCurrentValues[2], cachedCurrentValues[3], cachedCurrentValues[4]);
        }

        /// <summary>
        /// Restores the cached hand override values.
        /// </summary>
        protected virtual void RestoreOverrideValues()
        {
            SetOverrideValues(cachedOverrideValues[0], cachedOverrideValues[1], cachedOverrideValues[2], cachedOverrideValues[3], cachedOverrideValues[4]);
        }
    }
}