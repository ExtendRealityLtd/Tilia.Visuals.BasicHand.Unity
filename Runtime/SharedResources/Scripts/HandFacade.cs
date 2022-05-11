namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// The public facade for the hand.
    /// </summary>
    public class HandFacade : MonoBehaviour
    {
        #region Finger Settings
        [Header("Finger Settings")]
        [Tooltip("The Finger for the Thumb.")]
        [SerializeField]
        private Finger thumb;
        /// <summary>
        /// The <see cref="Finger"/> for the Thumb.
        /// </summary>
        public Finger Thumb
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
        [Tooltip("The Finger for the Index Finger.")]
        [SerializeField]
        private Finger indexFinger;
        /// <summary>
        /// The <see cref="Finger"/> for the Index Finger.
        /// </summary>
        public Finger IndexFinger
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
        [Tooltip("The Finger for the Middle Finger.")]
        [SerializeField]
        private Finger middleFinger;
        /// <summary>
        /// The <see cref="Finger"/> for the Middle Finger.
        /// </summary>
        public Finger MiddleFinger
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
        [Tooltip("The Finger for the Ring Finger.")]
        [SerializeField]
        private Finger ringFinger;
        /// <summary>
        /// The <see cref="Finger"/> for the Ring Finger.
        /// </summary>
        public Finger RingFinger
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
        [Tooltip("The Finger for the Pinky Finger.")]
        [SerializeField]
        private Finger pinkyFinger;
        /// <summary>
        /// The <see cref="Finger"/> for the Pinky Finger.
        /// </summary>
        public Finger PinkyFinger
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
        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The GameObject containing the hand colliders.")]
        [SerializeField]
        [Restricted]
        private GameObject colliderContainer;
        /// <summary>
        /// The <see cref="GameObject"/> containing the hand colliders.
        /// </summary>
        public GameObject ColliderContainer
        {
            get
            {
                return colliderContainer;
            }
            protected set
            {
                colliderContainer = value;
            }
        }
        #endregion
    }
}