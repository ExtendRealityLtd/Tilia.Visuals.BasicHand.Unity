namespace Tilia.Visuals.BasicHand
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// The concept of a avatar finger.
    /// </summary>
    public abstract class Finger : MonoBehaviour
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
        [Tooltip("The minimum and maximum limits that the finger curl can extend or retract to.")]
        [SerializeField]
        private FloatRange curlLimits = new FloatRange(0f, 1f);
        /// <summary>
        /// The minimum and maximum limits that the finger curl can extend or retract to.
        /// </summary>
        public FloatRange CurlLimits
        {
            get
            {
                return curlLimits;
            }
            set
            {
                curlLimits = value;
            }
        }
        [Tooltip("The speed in which to transition the finger to the destination value.")]
        [SerializeField]
        private float transitionSpeed = 0.3f;
        /// <summary>
        /// The speed in which to transition the finger to the destination value.
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
        public virtual void SetFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            FloatLimits = new FloatRange(FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the minimum value in <see cref="CurlLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetCurlLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            CurlLimits = new FloatRange(value, CurlLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="CurlLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetCurlLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            CurlLimits = new FloatRange(CurlLimits.minimum, value);
        }
    }
}