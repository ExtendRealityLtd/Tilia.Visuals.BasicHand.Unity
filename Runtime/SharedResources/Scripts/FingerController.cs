namespace Tilia.Visuals.BasicHand
{
    using System.Collections;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Process;

    /// <summary>
    /// Controls the finger armature.
    /// </summary>
    public class FingerController : Finger, IProcessable
    {
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

            DetermineCurlMotion(Mathf.Clamp(targetValue, CurlLimits.minimum, CurlLimits.maximum));
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