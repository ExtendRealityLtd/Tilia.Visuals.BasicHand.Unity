namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface for the hands poser.
    /// </summary>
    public class HandsPoserFacade : MonoBehaviour
    {
        #region Container Settings
        [Header("Container Settings")]
        [Tooltip("The left hand avatar container.")]
        [SerializeField]
        private GameObject leftHandContainer;
        /// <summary>
        /// The left hand avatar container.
        /// </summary>
        public GameObject LeftHandContainer
        {
            get
            {
                return leftHandContainer;
            }
            set
            {
                leftHandContainer = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterLeftHandContainerChange();
                }
            }
        }
        [Tooltip("The right hand avatar container.")]
        [SerializeField]
        private GameObject rightHandContainer;
        /// <summary>
        /// The right hand avatar container.
        /// </summary>
        public GameObject RightHandContainer
        {
            get
            {
                return rightHandContainer;
            }
            set
            {
                rightHandContainer = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterRightHandContainerChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked configuration.")]
        [SerializeField]
        [Restricted]
        private HandsPoserConfigurator configuration;
        /// <summary>
        /// The linked configuration.
        /// </summary>
        public HandsPoserConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="LeftHandContainer"/>.
        /// </summary>
        public virtual void ClearLeftHandContainer()
        {
            if (!this.IsValidState())
            {
                return;
            }

            LeftHandContainer = default;
        }

        /// <summary>
        /// Clears <see cref="RightHandContainer"/>.
        /// </summary>
        public virtual void ClearRightHandContainer()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RightHandContainer = default;
        }

        /// <summary>
        /// Applies the pose to the appropriate hand based on the given source.
        /// </summary>
        /// <param name="source">The source the hand pose is for.</param>
        public virtual void ApplyPose(Component source)
        {
            if (!this.IsValidState() || source == null)
            {
                return;
            }

            Configuration.ActivatePoseMatcher.Match(source.gameObject);
        }

        /// <summary>
        /// Removes the pose from the appropriate hand based on the given source.
        /// </summary>
        /// <param name="source">The source the hand pose is on.</param>
        public virtual void RemovePose(Component source)
        {
            if (!this.IsValidState() || source == null)
            {
                return;
            }

            Configuration.DeactivatePoseMatcher.Match(source.gameObject);
        }

        /// <summary>
        /// Called after <see cref="LeftHandContainer"/> has been changed.
        /// </summary>
        protected virtual void OnAfterLeftHandContainerChange()
        {
            Configuration.ConfigureLeftHandRule();
        }

        /// <summary>
        /// Called after <see cref="RightHandContainer"/> has been changed.
        /// </summary>
        protected virtual void OnAfterRightHandContainerChange()
        {
            Configuration.ConfigureRightHandRule();
        }
    }
}