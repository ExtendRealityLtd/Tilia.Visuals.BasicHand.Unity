namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;

    /// <summary>
    /// The public facade for the hand.
    /// </summary>
    public class HandFacade : MonoBehaviour
    {
        #region Finger Settings
        [Header("Finger Settings")]
        [Tooltip("The FingerController for the Thumb.")]
        [SerializeField]
        private FingerController thumb;
        /// <summary>
        /// The <see cref="FingerController"/> for the Thumb.
        /// </summary>
        public FingerController Thumb
        {
            get
            {
                return thumb;
            }
            set
            {
                thumb = value;
            }
        }
        [Tooltip("The FingerController for the Index Finger.")]
        [SerializeField]
        private FingerController indexFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Index Finger.
        /// </summary>
        public FingerController IndexFinger
        {
            get
            {
                return indexFinger;
            }
            set
            {
                indexFinger = value;
            }
        }
        [Tooltip("The FingerController for the Middle Finger.")]
        [SerializeField]
        private FingerController middleFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Middle Finger.
        /// </summary>
        public FingerController MiddleFinger
        {
            get
            {
                return middleFinger;
            }
            set
            {
                middleFinger = value;
            }
        }
        [Tooltip("The FingerController for the Ring Finger.")]
        [SerializeField]
        private FingerController ringFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Ring Finger.
        /// </summary>
        public FingerController RingFinger
        {
            get
            {
                return ringFinger;
            }
            set
            {
                ringFinger = value;
            }
        }
        [Tooltip("The FingerController for the Pinky Finger.")]
        [SerializeField]
        private FingerController pinkyFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Pinky Finger.
        /// </summary>
        public FingerController PinkyFinger
        {
            get
            {
                return pinkyFinger;
            }
            set
            {
                pinkyFinger = value;
            }
        }
        #endregion
    }
}