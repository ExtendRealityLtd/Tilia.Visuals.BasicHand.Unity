# Class FingerController

Controls the finger armature.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [transitionRoutine]
* [Properties]
  * [AnimationController]
  * [AnimationLayer]
  * [BoolData]
  * [CurlLimits]
  * [CurrentCurlValue]
  * [FloatData]
  * [FloatLimits]
  * [ForceTransitionThreshold]
  * [InputSource]
  * [NormalizedFloatData]
  * [OverrideValue]
  * [TransitionSpeed]
* [Methods]
  * [CancelTransition()]
  * [ClearBoolData()]
  * [ClearFloatData()]
  * [ClearFloatLimits()]
  * [ClearSourceInput()]
  * [DetermineCurlMotion(Single)]
  * [GetDirectionOffset(Single, Single)]
  * [OnDisable()]
  * [Process()]
  * [ProcessFingerCurl()]
  * [SetCurlLimitsMaximum(Single)]
  * [SetCurlLimitsMinimum(Single)]
  * [SetFingerCurlPosition(Single)]
  * [SetFloatLimitsMaximum(Single)]
  * [SetFloatLimitsMinimum(Single)]
  * [SetSourceInput(Int32)]
  * [StartTransition(Single)]
  * [TransitionFingerCurlPosition(Single)]
* [Implements]

## Details

##### Inheritance

* System.Object
* FingerController

##### Implements

IProcessable

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class FingerController : MonoBehaviour, IProcessable
```

### Fields

#### transitionRoutine

The coroutines for the finger transition.

##### Declaration

```
protected Coroutine transitionRoutine
```

### Properties

#### AnimationController

The Animator to control the finger motion.

##### Declaration

```
public Animator AnimationController { get; protected set; }
```

#### AnimationLayer

The animation layer that the finger mask is on.

##### Declaration

```
public int AnimationLayer { get; set; }
```

#### BoolData

The BooleanAction that contains the finger curl data.

##### Declaration

```
public BooleanAction BoolData { get; set; }
```

#### CurlLimits

The minimum and maximum limits that the finger curl can extend or retract to.

##### Declaration

```
public FloatRange CurlLimits { get; set; }
```

#### CurrentCurlValue

The current curl value of the finger state.

##### Declaration

```
public virtual float CurrentCurlValue { get; set; }
```

#### FloatData

The FloatAction that contains the finger curl data.

##### Declaration

```
public FloatAction FloatData { get; set; }
```

#### FloatLimits

The minimum and maximum limits of the given [FloatData].

##### Declaration

```
public FloatRange FloatLimits { get; set; }
```

#### ForceTransitionThreshold

The distance the current curl value has to be away from the input curl value for it to transition to that state.

##### Declaration

```
public float ForceTransitionThreshold { get; set; }
```

#### InputSource

The source of the input for the finger.

##### Declaration

```
public FingerController.InputType InputSource { get; set; }
```

#### NormalizedFloatData

The normalized value of the [FloatData] based on the given [FloatLimits].

##### Declaration

```
public virtual float NormalizedFloatData { get; }
```

#### OverrideValue

The value to force to be used for the finger curl data.

##### Declaration

```
public float OverrideValue { get; set; }
```

#### TransitionSpeed

The speed in which to transition the finger to the boolean destination value.

##### Declaration

```
public float TransitionSpeed { get; set; }
```

### Methods

#### CancelTransition()

Cancels an existing transition routine.

##### Declaration

```
protected virtual void CancelTransition()
```

#### ClearBoolData()

Clears [BoolData].

##### Declaration

```
public virtual void ClearBoolData()
```

#### ClearFloatData()

Clears [FloatData].

##### Declaration

```
public virtual void ClearFloatData()
```

#### ClearFloatLimits()

Clears [FloatLimits].

##### Declaration

```
public virtual void ClearFloatLimits()
```

#### ClearSourceInput()

Clears [InputSource].

##### Declaration

```
public virtual void ClearSourceInput()
```

#### DetermineCurlMotion(Single)

Determines the way in which the curl motion will be processed.

##### Declaration

```
protected virtual void DetermineCurlMotion(float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | targetValue | The target value for the finger curl. |

#### GetDirectionOffset(Single, Single)

Gets the offset of the direction the finger is travelling.

##### Declaration

```
protected virtual float GetDirectionOffset(float currentValue, float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | currentValue | The current finger position. |
| System.Single | targetValue | The target finger position. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The normalized value of how far the finger is away from the given target. |

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### Process()

##### Declaration

```
public void Process()
```

#### ProcessFingerCurl()

Processes the curl of the finger.

##### Declaration

```
protected virtual void ProcessFingerCurl()
```

#### SetCurlLimitsMaximum(Single)

Sets the maximum value in [CurlLimits].

##### Declaration

```
public virtual void SetCurlLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetCurlLimitsMinimum(Single)

Sets the minimum value in [CurlLimits].

##### Declaration

```
public virtual void SetCurlLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetFingerCurlPosition(Single)

Sets the finger curl position to the given value.

##### Declaration

```
protected virtual void SetFingerCurlPosition(float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | targetValue | The target position to use. |

#### SetFloatLimitsMaximum(Single)

Sets the maximum value in [FloatLimits].

##### Declaration

```
public virtual void SetFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetFloatLimitsMinimum(Single)

Sets the minimum value in [FloatLimits].

##### Declaration

```
public virtual void SetFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetSourceInput(Int32)

Sets [InputSource].

##### Declaration

```
public virtual void SetSourceInput(int inputTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | inputTypeIndex | The index of the [FingerController.InputType]. |

#### StartTransition(Single)

Starts a transition on the finger.

##### Declaration

```
protected virtual void StartTransition(float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | targetValue | The value to transition to. |

#### TransitionFingerCurlPosition(Single)

Transitions the finger into the new position over the given finger transition speed.

##### Declaration

```
protected virtual IEnumerator TransitionFingerCurlPosition(float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | targetValue | The target position to transition to. |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | An enumerator to control the coroutine. |

### Implements

IProcessable

[Tilia.Visuals.BasicHand]: README.md
[FloatData]: FingerController.md#FloatData
[FloatData]: FingerController.md#FloatData
[FloatLimits]: FingerController.md#FloatLimits
[BoolData]: FingerController.md#BoolData
[FloatData]: FingerController.md#FloatData
[FloatLimits]: FingerController.md#FloatLimits
[InputSource]: FingerController.md#InputSource
[CurlLimits]: FingerController.md#CurlLimits
[CurlLimits]: FingerController.md#CurlLimits
[FloatLimits]: FingerController.md#FloatLimits
[FloatLimits]: FingerController.md#FloatLimits
[InputSource]: FingerController.md#InputSource
[FingerController.InputType]: FingerController.InputType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[transitionRoutine]: #transitionRoutine
[Properties]: #Properties
[AnimationController]: #AnimationController
[AnimationLayer]: #AnimationLayer
[BoolData]: #BoolData
[CurlLimits]: #CurlLimits
[CurrentCurlValue]: #CurrentCurlValue
[FloatData]: #FloatData
[FloatLimits]: #FloatLimits
[ForceTransitionThreshold]: #ForceTransitionThreshold
[InputSource]: #InputSource
[NormalizedFloatData]: #NormalizedFloatData
[OverrideValue]: #OverrideValue
[TransitionSpeed]: #TransitionSpeed
[Methods]: #Methods
[CancelTransition()]: #CancelTransition
[ClearBoolData()]: #ClearBoolData
[ClearFloatData()]: #ClearFloatData
[ClearFloatLimits()]: #ClearFloatLimits
[ClearSourceInput()]: #ClearSourceInput
[DetermineCurlMotion(Single)]: #DetermineCurlMotionSingle
[GetDirectionOffset(Single, Single)]: #GetDirectionOffsetSingle-Single
[OnDisable()]: #OnDisable
[Process()]: #Process
[ProcessFingerCurl()]: #ProcessFingerCurl
[SetCurlLimitsMaximum(Single)]: #SetCurlLimitsMaximumSingle
[SetCurlLimitsMinimum(Single)]: #SetCurlLimitsMinimumSingle
[SetFingerCurlPosition(Single)]: #SetFingerCurlPositionSingle
[SetFloatLimitsMaximum(Single)]: #SetFloatLimitsMaximumSingle
[SetFloatLimitsMinimum(Single)]: #SetFloatLimitsMinimumSingle
[SetSourceInput(Int32)]: #SetSourceInputInt32
[StartTransition(Single)]: #StartTransitionSingle
[TransitionFingerCurlPosition(Single)]: #TransitionFingerCurlPositionSingle
[Implements]: #Implements
