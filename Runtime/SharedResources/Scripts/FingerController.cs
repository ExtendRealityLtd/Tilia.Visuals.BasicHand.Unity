namespace Tilia.Visuals.BasicHand
{
    using System.Collections;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Process;

    /// <summary>
    /// Controls the finger armature.
    /// </summary>
    public class FingerController : MonoBehaviour, IProcessable
    {
        /// <summary>
        /// The input type to use to control the finger.
        /// </summary>
        public enum InputType
        {
            /// <summary>
            /// No input.
            /// </summary>
            None,
            /// <summary>
            /// The <see cref="FloatData"/>.
            /// </summary>
            Float,
            /// <summary>
            /// The <see cref="BoolData"/>.
            /// </summary>
            Boolean,
            /// <summary>
            /// The <see cref="OverrideValue"/>.
            /// </summary>
            Override
        }

        #region Input Settings
        [Header("Input Settings")]
        [Tooltip("The source of the input for the finger.")]
        [SerializeField]
        private InputType inputSource = InputType.None;
        /// <summary>
        /// The source of the input for the finger.
        /// </summary>
        public InputType InputSource
        {
            get
            {
                return inputSource;
            }
            set
            {
                inputSource = value;
            }
        }
        [Tooltip("The FloatAction that contains the finger curl data.")]
        [SerializeField]
        private FloatAction floatData;
        /// <summary>
        /// The <see cref="FloatAction"/> that contains the finger curl data.
        /// </summary>
        public FloatAction FloatData
        {
            get
            {
                return floatData;
            }
            set
            {
                floatData = value;
            }
        }
        [Tooltip("The BooleanAction that contains the finger curl data.")]
        [SerializeField]
        private BooleanAction boolData;
        /// <summary>
        /// The <see cref="BooleanAction"/> that contains the finger curl data.
        /// </summary>
        public BooleanAction BoolData
        {
            get
            {
                return boolData;
            }
            set
            {
                boolData = value;
            }
        }
        [Tooltip("The value to force to be used for the finger curl data.")]
        [SerializeField]
        [Range(0f, 1f)]
        private float overrideValue;
        /// <summary>
        /// The value to force to be used for the finger curl data.
        /// </summary>
        public float OverrideValue
        {
            get
            {
                return overrideValue;
            }
            set
            {
                overrideValue = value;
            }
        }
        #endregion

        #region Custom Settings
        [Header("Custom Settings")]
        [Tooltip("The animation layer that the finger mask is on.")]
        [SerializeField]
        private int animationLayer;
        /// <summary>
        /// The animation layer that the finger mask is on.
        /// </summary>
        public int AnimationLayer
        {
            get
            {
                return animationLayer;
            }
            set
            {
                animationLayer = value;
            }
        }
        [Tooltip("The minimum and maximum limits of the given FloatData.")]
        [SerializeField]
        private FloatRange floatLimits = new FloatRange(0f, 1f);
        /// <summary>
        /// The minimum and maximum limits of the given <see cref="FloatData"/>.
        /// </summary>
        public FloatRange FloatLimits
        {
            get
            {
                return floatLimits;
            }
            set
            {
                floatLimits = value;
            }
        }
        [Tooltip("The speed in which to transition the finger to the boolean destination value.")]
        [SerializeField]
        private float transitionSpeed = 0.3f;
        /// <summary>
        /// The speed in which to transition the finger to the boolean destination value.
        /// </summary>
        public float TransitionSpeed
        {
            get
            {
                return transitionSpeed;
            }
            set
            {
                transitionSpeed = value;
            }
        }
        [Tooltip("The distance the current curl value has to be away from the input curl value for it to transition to that state.")]
        [SerializeField]
        private float forceTransitionThreshold = 0.9f;
        /// <summary>
        /// The distance the current curl value has to be away from the input curl value for it to transition to that state.
        /// </summary>
        public float ForceTransitionThreshold
        {
            get
            {
                return forceTransitionThreshold;
            }
            set
            {
                forceTransitionThreshold = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The Animator to control the finger motion.")]
        [SerializeField]
        [Restricted]
        private Animator animationController;
        /// <summary>
        /// The <see cref="Animator"/> to control the finger motion.
        /// </summary>
        public Animator AnimationController
        {
            get
            {
                return animationController;
            }
            protected set
            {
                animationController = value;
            }
        }
        #endregion

        /// <summary>
        /// The normalized value of the <see cref="FloatData"/> based on the given <see cref="FloatLimits"/>.
        /// </summary>
        public virtual float NormalizedFloatData => FloatData != null ? Mathf.InverseLerp(FloatLimits.minimum, FloatLimits.maximum, FloatData.Value) : 0f;

        /// <summary>
        /// The current curl value of the finger state.
        /// </summary>
        public virtual float CurrentCurlValue { get; set; }

        /// <summary>
        /// Clears <see cref="InputSource"/>.
        /// </summary>
        public virtual void ClearSourceInput()
        {
            if (!this.IsValidState())
            {
                return;
            }

            InputSource = InputType.None;
        }

        /// <summary>
        /// Clears <see cref="FloatData"/>.
        /// </summary>
        public virtual void ClearFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FloatData = default;
        }

        /// <summary>
        /// Clears <see cref="FloatLimits"/>.
        /// </summary>
        public virtual void ClearFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FloatLimits = default;
        }

        /// <summary>
        /// Clears <see cref="BoolData"/>.
        /// </summary>
        public virtual void ClearBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            BoolData = default;
        }

        /// <summary>
        /// Sets <see cref="InputSource"/>.
        /// </summary>
        /// <param name="inputTypeIndex">The index of the <see cref="InputType"/>.</param>
        public virtual void SetSourceInput(int inputTypeIndex)
        {
            if (!this.IsValidState())
            {
                return;
            }

            InputSource = EnumExtensions.GetByIndex<InputType>(inputTypeIndex);
        }

        /// <summary>
        /// Sets the minimum value in <see cref="FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            FloatLimits = new FloatRange(value, FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetThumbFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            FloatLimits = new FloatRange(FloatLimits.minimum, value);
        }

        /// <summary>
        /// The coroutines for the finger transition.
        /// </summary>
        protected Coroutine transitionRoutine;

        /// <inheritdoc />
        public void Process()
        {
            ProcessFingerCurl();
        }
        protected virtual void OnDisable()
        {
            CancelTransition();
        }

        /// <summary>
        /// Cancels an existing transition routine.
        /// </summary>
        protected virtual void CancelTransition()
        {
            if (transitionRoutine != null)
            {
                StopCoroutine(transitionRoutine);
            }
        }

        /// <summary>
        /// Processes the curl of the finger.
        /// </summary>
        protected virtual void ProcessFingerCurl()
        {
            float targetValue = 0f;
            switch (InputSource)
            {
                case InputType.Override:
                    targetValue = OverrideValue;
                    break;
                case InputType.Float:
                    targetValue = FloatData != null ? NormalizedFloatData : 0f;
                    break;
                case InputType.Boolean:
                    targetValue = BoolData != null ? BoolData.Value ? 1f : 0f : 0f;
                    break;
            }

            DetermineCurlMotion(targetValue);
        }

        /// <summary>
        /// Determines the way in which the curl motion will be processed.
        /// </summary>
        /// <param name="targetValue">The target value for the finger curl.</param>
        protected virtual void DetermineCurlMotion(float targetValue)
        {
            if (Mathf.Abs(CurrentCurlValue - targetValue) > ForceTransitionThreshold)
            {
                StartTransition(targetValue);
            }
            else
            {
                SetFingerCurlPosition(targetValue);
            }
        }

        /// <summary>
        /// Starts a transition on the finger.
        /// </summary>
        /// <param name="targetValue">The value to transition to.</param>
        protected virtual void StartTransition(float targetValue)
        {
            CancelTransition();
            transitionRoutine = StartCoroutine(TransitionFingerCurlPosition(targetValue));
        }

        /// <summary>
        /// Transitions the finger into the new position over the given finger transition speed.
        /// </summary>
        /// <param name="targetValue">The target position to transition to.</param>
        /// <returns>An enumerator to control the coroutine.</returns>
        protected virtual IEnumerator TransitionFingerCurlPosition(float targetValue)
        {
            float elapsedTime = 0f;
            float startPosition = CurrentCurlValue;

            float actualTime = TransitionSpeed * GetDirectionOffset(CurrentCurlValue, targetValue);

            while (elapsedTime < actualTime)
            {
                elapsedTime += Time.deltaTime;
                float newValue = Mathf.Lerp(startPosition, targetValue, (elapsedTime / actualTime));
                SetFingerCurlPosition(newValue);
                yield return null;
            }
            SetFingerCurlPosition(targetValue);
            transitionRoutine = null;
        }

        /// <summary>
        /// Sets the finger curl position to the given value.
        /// </summary>
        /// <param name="targetValue">The target position to use.</param>
        protected virtual void SetFingerCurlPosition(float targetValue)
        {
            CurrentCurlValue = targetValue;
            AnimationController.SetLayerWeight(AnimationLayer, targetValue);
        }

        /// <summary>
        /// Gets the offset of the direction the finger is travelling.
        /// </summary>
        /// <param name="currentValue">The current finger position.</param>
        /// <param name="targetValue">The target finger position.</param>
        /// <returns>The normalized value of how far the finger is away from the given target.</returns>
        protected virtual float GetDirectionOffset(float currentValue, float targetValue)
        {
            float answer = 1f;
            if (currentValue <= targetValue)
            {
                answer = Mathf.InverseLerp(1f, 0f, currentValue);
            }
            else if (currentValue > targetValue)
            {
                answer = Mathf.InverseLerp(0f, 1f, currentValue);
            }

            return answer;
        }
    }
}