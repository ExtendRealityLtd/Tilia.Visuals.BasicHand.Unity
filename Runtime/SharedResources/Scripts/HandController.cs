namespace Tilia.Visuals.BasicHand
{
    using System;
    using System.Collections;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Process;

    /// <summary>
    /// Controls the hand avatar.
    /// </summary>
    public class HandController : MonoBehaviour, IProcessable
    {
        /// <summary>
        /// Controls the finger armature.
        /// </summary>
        [Serializable]
        public class FingerController
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
            private float transitionSpeed = 0.1f;
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
            #endregion

            /// <summary>
            /// The normalized value of the <see cref="FloatData"/> based on the given <see cref="FloatLimits"/>.
            /// </summary>
            public virtual float NormalizedFloatData => FloatData != null ? Mathf.InverseLerp(FloatLimits.minimum, FloatLimits.maximum, FloatData.Value) : 0f;
            /// <summary>
            /// A numerical identifier for the finger.
            /// </summary>
            public virtual int FingerIdentifier { get; set; }
            /// <summary>
            /// The current curl value of the finger state.
            /// </summary>
            public virtual float CurrentCurlValue { get; set; }

            /// <summary>
            /// Clears <see cref="InputSource"/>.
            /// </summary>
            public virtual void ClearSourceInput()
            {
                InputSource = InputType.None;
            }

            /// <summary>
            /// Clears <see cref="FloatData"/>.
            /// </summary>
            public virtual void ClearFloatData()
            {
                FloatData = default;
            }

            /// <summary>
            /// Clears <see cref="FloatLimits"/>.
            /// </summary>
            public virtual void ClearFloatLimits()
            {
                FloatLimits = default;
            }

            /// <summary>
            /// Clears <see cref="BoolData"/>.
            /// </summary>
            public virtual void ClearBoolData()
            {
                BoolData = default;
            }

            public virtual void ClearAllData()
            {
                InputSource = InputType.None;
                FloatData = default;
                FloatLimits = default;
                BoolData = default;
                TransitionSpeed = default;
                OverrideValue = default;
            }

            /// <summary>
            /// Sets <see cref="InputSource"/>.
            /// </summary>
            /// <param name="inputTypeIndex">The index of the <see cref="InputType"/>.</param>
            public virtual void SetSourceInput(int inputTypeIndex)
            {
                InputSource = EnumExtensions.GetByIndex<InputType>(inputTypeIndex);
            }
        }

        #region Finger Settings
        [Header("Finger Settings")]
        [Tooltip("The FingerController for the Thumb of the hand.")]
        [SerializeField]
        private FingerController thumb;
        /// <summary>
        /// The <see cref="FingerController"/> for the Thumb of the hand.
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
        [Tooltip("The FingerController for the Index finger of the hand.")]
        [SerializeField]
        private FingerController indexFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Index finger of the hand.
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
        [Tooltip("The FingerController for the Middle finger of the hand.")]
        [SerializeField]
        private FingerController middleFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Middle finger of the hand.
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
        [Tooltip("The FingerController for the Ring finger of the hand.")]
        [SerializeField]
        private FingerController ringFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Ring finger of the hand.
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
        [Tooltip("The FingerController for the Pinky finger of the hand.")]
        [SerializeField]
        private FingerController pinkyFinger;
        /// <summary>
        /// The <see cref="FingerController"/> for the Pinky finger of the hand.
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
        /// The coroutines for the finger transitions.
        /// </summary>
        protected Coroutine[] transitionRoutines = new Coroutine[5];

        #region Thumb Methods
        /// <summary>
        /// Clears <see cref="Thumb.FloatData"/>.
        /// </summary>
        public virtual void ClearThumbFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.ClearFloatData();
        }

        /// <summary>
        /// Clears <see cref="Thumb.BoolData"/>.
        /// </summary>
        public virtual void ClearThumbBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.ClearBoolData();
        }

        /// <summary>
        /// Clears <see cref="Thumb.FloatLimits"/>.
        /// </summary>
        public virtual void ClearThumbFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.ClearFloatLimits();
        }

        /// <summary>
        /// Sets the <see cref="Thumb.InputSource"/>.
        /// </summary>
        /// <param name="value">The source index to set to.</param>
        public virtual void SetThumbInputSource(int value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.SetSourceInput(value);
        }

        /// <summary>
        /// Sets the <see cref="Thumb.FloatData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetThumbFloatData(FloatAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.FloatData = value;
        }

        /// <summary>
        /// Sets the <see cref="Thumb.BoolData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetThumbBoolData(BooleanAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.BoolData = value;
        }

        /// <summary>
        /// Sets the <see cref="Thumb.OverrideValue"/>.
        /// </summary>
        /// <param name="value">The override value to set to.</param>
        public virtual void SetThumbOverrideValue(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.OverrideValue = value;
        }

        /// <summary>
        /// Sets the <see cref="Thumb.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The range to set to.</param>
        public virtual void SetThumbFloatLimits(FloatRange value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.FloatLimits = value;
        }

        /// <summary>
        /// Sets the minimum value in <see cref="Thumb.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetThumbFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.FloatLimits = new FloatRange(value, Thumb.FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="Thumb.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetThumbFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.FloatLimits = new FloatRange(Thumb.FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the <see cref="Thumb.TransitionSpeed"/>.
        /// </summary>
        /// <param name="value">The speed value to set to.</param>
        public virtual void SetThumbTransitionSpeed(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Thumb.TransitionSpeed = value;
        }
        #endregion

        #region IndexFinger Methods
        /// <summary>
        /// Clears <see cref="IndexFinger.FloatData"/>.
        /// </summary>
        public virtual void ClearIndexFingerFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.ClearFloatData();
        }

        /// <summary>
        /// Clears <see cref="IndexFinger.BoolData"/>.
        /// </summary>
        public virtual void ClearIndexFingerBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.ClearBoolData();
        }

        /// <summary>
        /// Clears <see cref="IndexFinger.FloatLimits"/>.
        /// </summary>
        public virtual void ClearIndexFingerFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.ClearFloatLimits();
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.InputSource"/>.
        /// </summary>
        /// <param name="value">The source index to set to.</param>
        public virtual void SetIndexFingerInputSource(int value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.SetSourceInput(value);
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.FloatData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetIndexFingerFloatData(FloatAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.FloatData = value;
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.BoolData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetIndexFingerBoolData(BooleanAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.BoolData = value;
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.OverrideValue"/>.
        /// </summary>
        /// <param name="value">The override value to set to.</param>
        public virtual void SetIndexFingerOverrideValue(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.OverrideValue = value;
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The range to set to.</param>
        public virtual void SetIndexFingerFloatLimits(FloatRange value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.FloatLimits = value;
        }

        /// <summary>
        /// Sets the minimum value in <see cref="IndexFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetIndexFingerFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.FloatLimits = new FloatRange(value, IndexFinger.FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="IndexFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetIndexFingerFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.FloatLimits = new FloatRange(IndexFinger.FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the <see cref="IndexFinger.TransitionSpeed"/>.
        /// </summary>
        /// <param name="value">The speed value to set to.</param>
        public virtual void SetIndexFingerTransitionSpeed(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            IndexFinger.TransitionSpeed = value;
        }
        #endregion

        #region MiddleFinger Methods
        /// <summary>
        /// Clears <see cref="MiddleFinger.FloatData"/>.
        /// </summary>
        public virtual void ClearMiddleFingerFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.ClearFloatData();
        }

        /// <summary>
        /// Clears <see cref="MiddleFinger.BoolData"/>.
        /// </summary>
        public virtual void ClearMiddleFingerBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.ClearBoolData();
        }

        /// <summary>
        /// Clears <see cref="MiddleFinger.FloatLimits"/>.
        /// </summary>
        public virtual void ClearMiddleFingerFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.ClearFloatLimits();
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.InputSource"/>.
        /// </summary>
        /// <param name="value">The source index to set to.</param>
        public virtual void SetMiddleFingerInputSource(int value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.SetSourceInput(value);
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.FloatData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetMiddleFingerFloatData(FloatAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.FloatData = value;
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.BoolData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetMiddleFingerBoolData(BooleanAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.BoolData = value;
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.OverrideValue"/>.
        /// </summary>
        /// <param name="value">The override value to set to.</param>
        public virtual void SetMiddleFingerOverrideValue(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.OverrideValue = value;
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The range to set to.</param>
        public virtual void SetMiddleFingerFloatLimits(FloatRange value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.FloatLimits = value;
        }

        /// <summary>
        /// Sets the minimum value in <see cref="MiddleFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetMiddleFingerFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.FloatLimits = new FloatRange(value, MiddleFinger.FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="MiddleFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetMiddleFingerFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.FloatLimits = new FloatRange(MiddleFinger.FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the <see cref="MiddleFinger.TransitionSpeed"/>.
        /// </summary>
        /// <param name="value">The speed value to set to.</param>
        public virtual void SetMiddleFingerTransitionSpeed(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            MiddleFinger.TransitionSpeed = value;
        }
        #endregion

        #region RingFinger Methods
        /// <summary>
        /// Clears <see cref="RingFinger.FloatData"/>.
        /// </summary>
        public virtual void ClearRingFingerFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.ClearFloatData();
        }

        /// <summary>
        /// Clears <see cref="RingFinger.BoolData"/>.
        /// </summary>
        public virtual void ClearRingFingerBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.ClearBoolData();
        }

        /// <summary>
        /// Clears <see cref="RingFinger.FloatLimits"/>.
        /// </summary>
        public virtual void ClearRingFingerFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.ClearFloatLimits();
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.InputSource"/>.
        /// </summary>
        /// <param name="value">The source index to set to.</param>
        public virtual void SetRingFingerInputSource(int value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.SetSourceInput(value);
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.FloatData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetRingFingerFloatData(FloatAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.FloatData = value;
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.BoolData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetRingFingerBoolData(BooleanAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.BoolData = value;
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.OverrideValue"/>.
        /// </summary>
        /// <param name="value">The override value to set to.</param>
        public virtual void SetRingFingerOverrideValue(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.OverrideValue = value;
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The range to set to.</param>
        public virtual void SetRingFingerFloatLimits(FloatRange value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.FloatLimits = value;
        }

        /// <summary>
        /// Sets the minimum value in <see cref="RingFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetRingFingerFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.FloatLimits = new FloatRange(value, RingFinger.FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="RingFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetRingFingerFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.FloatLimits = new FloatRange(RingFinger.FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the <see cref="RingFinger.TransitionSpeed"/>.
        /// </summary>
        /// <param name="value">The speed value to set to.</param>
        public virtual void SetRingFingerTransitionSpeed(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            RingFinger.TransitionSpeed = value;
        }
        #endregion

        #region PinkyFinger Methods
        /// <summary>
        /// Clears <see cref="PinkyFinger.FloatData"/>.
        /// </summary>
        public virtual void ClearPinkyFingerFloatData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.ClearFloatData();
        }

        /// <summary>
        /// Clears <see cref="PinkyFinger.BoolData"/>.
        /// </summary>
        public virtual void ClearPinkyFingerBoolData()
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.ClearBoolData();
        }

        /// <summary>
        /// Clears <see cref="PinkyFinger.FloatLimits"/>.
        /// </summary>
        public virtual void ClearPinkyFingerFloatLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.ClearFloatLimits();
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.InputSource"/>.
        /// </summary>
        /// <param name="value">The source index to set to.</param>
        public virtual void SetPinkyFingerInputSource(int value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.SetSourceInput(value);
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.FloatData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetPinkyFingerFloatData(FloatAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.FloatData = value;
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.BoolData"/>.
        /// </summary>
        /// <param name="value">The action to set to.</param>
        public virtual void SetPinkyFingerBoolData(BooleanAction value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.BoolData = value;
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.OverrideValue"/>.
        /// </summary>
        /// <param name="value">The override value to set to.</param>
        public virtual void SetPinkyFingerOverrideValue(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.OverrideValue = value;
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The range to set to.</param>
        public virtual void SetPinkyFingerFloatLimits(FloatRange value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.FloatLimits = value;
        }

        /// <summary>
        /// Sets the minimum value in <see cref="PinkyFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set minimum to.</param>
        public virtual void SetPinkyFingerFloatLimitsMinimum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.FloatLimits = new FloatRange(value, PinkyFinger.FloatLimits.maximum);
        }

        /// <summary>
        /// Sets the maximum value in <see cref="PinkyFinger.FloatLimits"/>.
        /// </summary>
        /// <param name="value">The value to set maximum to.</param>
        public virtual void SetPinkyFingerFloatLimitsMaximum(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.FloatLimits = new FloatRange(PinkyFinger.FloatLimits.minimum, value);
        }

        /// <summary>
        /// Sets the <see cref="PinkyFinger.TransitionSpeed"/>.
        /// </summary>
        /// <param name="value">The speed value to set to.</param>
        public virtual void SetPinkyFingerTransitionSpeed(float value)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PinkyFinger.TransitionSpeed = value;
        }
        #endregion

        /// <inheritdoc />
        public void Process()
        {
            ProcessFinger(Thumb);
            ProcessFinger(IndexFinger);
            ProcessFinger(MiddleFinger);
            ProcessFinger(RingFinger);
            ProcessFinger(PinkyFinger);
        }

        protected virtual void Awake()
        {
            Thumb.FingerIdentifier = 0;
            IndexFinger.FingerIdentifier = 1;
            MiddleFinger.FingerIdentifier = 2;
            RingFinger.FingerIdentifier = 3;
            PinkyFinger.FingerIdentifier = 4;
        }

        protected virtual void OnDisable()
        {
            for (int cancelIndex = 0; cancelIndex < transitionRoutines.Length; cancelIndex++)
            {
                CancelTransition(cancelIndex);
            }
        }

        /// <summary>
        /// Processes the control of the given finger.
        /// </summary>
        /// <param name="finger">The finger to control.</param>
        protected virtual void ProcessFinger(FingerController finger)
        {
            switch (finger.InputSource)
            {
                case FingerController.InputType.Override:
                    StartTransition(finger, finger.OverrideValue);
                    break;
                case FingerController.InputType.Float:
                    if (finger.FloatData != null)
                    {
                        SetFingerPosition(finger, finger.NormalizedFloatData);
                    }
                    break;
                case FingerController.InputType.Boolean:
                    if (finger.BoolData != null)
                    {
                        StartTransition(finger, finger.BoolData.Value ? 1f : 0f);
                    }
                    break;
            }
        }

        /// <summary>
        /// Cancels an existing transition routine.
        /// </summary>
        /// <param name="index">The index to cancel.</param>
        protected virtual void CancelTransition(int index)
        {
            if (transitionRoutines[index] != null)
            {
                StopCoroutine(transitionRoutines[index]);
            }
        }

        /// <summary>
        /// Starts a transition on a finger.
        /// </summary>
        /// <param name="finger">The finger to transition.</param>
        /// <param name="targetValue">The value to transition to.</param>
        protected virtual void StartTransition(FingerController finger, float targetValue)
        {
            CancelTransition(finger.FingerIdentifier);
            transitionRoutines[finger.FingerIdentifier] = StartCoroutine(TransitionFingerPosition(finger, targetValue));
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

        /// <summary>
        /// Transitions a finger into the new position over the given finger transition speed.
        /// </summary>
        /// <param name="finger">The finger to transition.</param>
        /// <param name="targetValue">The target position to transition to.</param>
        /// <returns>An enumerator to control the coroutine.</returns>
        protected virtual IEnumerator TransitionFingerPosition(FingerController finger, float targetValue)
        {
            float elapsedTime = 0f;
            float startPosition = finger.CurrentCurlValue;

            float actualTime = finger.TransitionSpeed * GetDirectionOffset(finger.CurrentCurlValue, targetValue);

            while (elapsedTime < actualTime)
            {
                elapsedTime += Time.deltaTime;
                float newValue = Mathf.Lerp(startPosition, targetValue, (elapsedTime / actualTime));
                SetFingerPosition(finger, newValue);
                yield return null;
            }
            SetFingerPosition(finger, targetValue);
            transitionRoutines[finger.FingerIdentifier] = null;
        }

        /// <summary>
        /// Sets the finger position to the given value.
        /// </summary>
        /// <param name="finger">The finger to set.</param>
        /// <param name="targetValue">The target position to use.</param>
        protected virtual void SetFingerPosition(FingerController finger, float targetValue)
        {
            int animationLayer = finger.FingerIdentifier + 1;
            finger.CurrentCurlValue = targetValue;
            AnimationController.SetLayerWeight(animationLayer, targetValue);
        }
    }
}