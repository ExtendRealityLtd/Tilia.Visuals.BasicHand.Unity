namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Rule;

    /// <summary>
    /// The internal setup for the hands poser.
    /// </summary>
    public class HandsPoserConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The linked facade.")]
        [SerializeField]
        [Restricted]
        private HandsPoserFacade facade;
        /// <summary>
        /// The linked configuration.
        /// </summary>
        public HandsPoserFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The RulesMatcher for activating the pose.")]
        [SerializeField]
        [Restricted]
        private RulesMatcher activatePoseMatcher;
        /// <summary>
        /// The <see cref="RulesMatcher"/> for activating the pose.
        /// </summary>
        public RulesMatcher ActivatePoseMatcher
        {
            get
            {
                return activatePoseMatcher;
            }
            protected set
            {
                activatePoseMatcher = value;
            }
        }
        [Tooltip("The RulesMatcher for deactivating the pose.")]
        [SerializeField]
        [Restricted]
        private RulesMatcher deactivatePoseMatcher;
        /// <summary>
        /// The <see cref="RulesMatcher"/> for deactivating the pose.
        /// </summary>
        public RulesMatcher DeactivatePoseMatcher
        {
            get
            {
                return deactivatePoseMatcher;
            }
            protected set
            {
                deactivatePoseMatcher = value;
            }
        }
        [Tooltip("The Rule to determine the left hand.")]
        [SerializeField]
        [Restricted]
        private ListContainsRule leftHandRule;
        /// <summary>
        /// The Rule to determine the left hand.
        /// </summary>
        public ListContainsRule LeftHandRule
        {
            get
            {
                return leftHandRule;
            }
            protected set
            {
                leftHandRule = value;
            }
        }
        [Tooltip("The Rule to determine the right hand.")]
        [SerializeField]
        [Restricted]
        private ListContainsRule rightHandRule;
        /// <summary>
        /// The Rule to determine the right hand.
        /// </summary>
        public ListContainsRule RightHandRule
        {
            get
            {
                return rightHandRule;
            }
            protected set
            {
                rightHandRule = value;
            }
        }
        [Tooltip("The hand poser for the left hand.")]
        [SerializeField]
        [Restricted]
        private HandPoserFacade leftHandPoser;
        /// <summary>
        /// The hand poser for the left hand.
        /// </summary>
        public HandPoserFacade LeftHandPoser
        {
            get
            {
                return leftHandPoser;
            }
            protected set
            {
                leftHandPoser = value;
            }
        }
        [Tooltip("The hand poser for the right hand.")]
        [SerializeField]
        [Restricted]
        private HandPoserFacade rightHandPoser;
        /// <summary>
        /// The hand poser for the right hand.
        /// </summary>
        public HandPoserFacade RightHandPoser
        {
            get
            {
                return rightHandPoser;
            }
            protected set
            {
                rightHandPoser = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the left hand rule.
        /// </summary>
        public virtual void ConfigureLeftHandRule()
        {
            if (LeftHandRule == null)
            {
                return;
            }

            LeftHandRule.Objects.Clear();
            LeftHandRule.Objects.Add(Facade.LeftHandContainer);
        }

        /// <summary>
        /// Configures the right hand rule.
        /// </summary>
        public virtual void ConfigureRightHandRule()
        {
            if (RightHandRule == null)
            {
                return;
            }

            RightHandRule.Objects.Clear();
            RightHandRule.Objects.Add(Facade.RightHandContainer);
        }

        protected virtual void OnEnable()
        {
            ConfigureLeftHandRule();
            ConfigureRightHandRule();
        }
    }
}