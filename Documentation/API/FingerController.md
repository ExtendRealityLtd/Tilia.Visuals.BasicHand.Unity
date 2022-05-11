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
* [Methods]
  * [CancelTransition()]
  * [DetermineCurlMotion(Single)]
  * [GetDirectionOffset(Single, Single)]
  * [OnDisable()]
  * [Process()]
  * [ProcessFingerCurl()]
  * [SetFingerCurlPosition(Single)]
  * [StartTransition(Single)]
  * [TransitionFingerCurlPosition(Single)]
* [Implements]

## Details

##### Inheritance

* System.Object
* [Finger]
* FingerController

##### Implements

IProcessable

##### Inherited Members

[Finger.InputSource]

[Finger.FloatData]

[Finger.BoolData]

[Finger.OverrideValue]

[Finger.AnimationLayer]

[Finger.FloatLimits]

[Finger.CurlLimits]

[Finger.TransitionSpeed]

[Finger.ForceTransitionThreshold]

[Finger.NormalizedFloatData]

[Finger.CurrentCurlValue]

[Finger.ClearSourceInput()]

[Finger.ClearFloatData()]

[Finger.ClearFloatLimits()]

[Finger.ClearBoolData()]

[Finger.SetSourceInput(Int32)]

[Finger.SetFloatLimitsMinimum(Single)]

[Finger.SetFloatLimitsMaximum(Single)]

[Finger.SetCurlLimitsMinimum(Single)]

[Finger.SetCurlLimitsMaximum(Single)]

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class FingerController : Finger, IProcessable
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

### Methods

#### CancelTransition()

Cancels an existing transition routine.

##### Declaration

```
protected virtual void CancelTransition()
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

[Finger]: Finger.md
[Finger.InputSource]: Finger.md#Tilia_Visuals_BasicHand_Finger_InputSource
[Finger.FloatData]: Finger.md#Tilia_Visuals_BasicHand_Finger_FloatData
[Finger.BoolData]: Finger.md#Tilia_Visuals_BasicHand_Finger_BoolData
[Finger.OverrideValue]: Finger.md#Tilia_Visuals_BasicHand_Finger_OverrideValue
[Finger.AnimationLayer]: Finger.md#Tilia_Visuals_BasicHand_Finger_AnimationLayer
[Finger.FloatLimits]: Finger.md#Tilia_Visuals_BasicHand_Finger_FloatLimits
[Finger.CurlLimits]: Finger.md#Tilia_Visuals_BasicHand_Finger_CurlLimits
[Finger.TransitionSpeed]: Finger.md#Tilia_Visuals_BasicHand_Finger_TransitionSpeed
[Finger.ForceTransitionThreshold]: Finger.md#Tilia_Visuals_BasicHand_Finger_ForceTransitionThreshold
[Finger.NormalizedFloatData]: Finger.md#Tilia_Visuals_BasicHand_Finger_NormalizedFloatData
[Finger.CurrentCurlValue]: Finger.md#Tilia_Visuals_BasicHand_Finger_CurrentCurlValue
[Finger.ClearSourceInput()]: Finger.md#Tilia_Visuals_BasicHand_Finger_ClearSourceInput
[Finger.ClearFloatData()]: Finger.md#Tilia_Visuals_BasicHand_Finger_ClearFloatData
[Finger.ClearFloatLimits()]: Finger.md#Tilia_Visuals_BasicHand_Finger_ClearFloatLimits
[Finger.ClearBoolData()]: Finger.md#Tilia_Visuals_BasicHand_Finger_ClearBoolData
[Finger.SetSourceInput(Int32)]: Finger.md#Tilia_Visuals_BasicHand_Finger_SetSourceInput_System_Int32_
[Finger.SetFloatLimitsMinimum(Single)]: Finger.md#Tilia_Visuals_BasicHand_Finger_SetFloatLimitsMinimum_System_Single_
[Finger.SetFloatLimitsMaximum(Single)]: Finger.md#Tilia_Visuals_BasicHand_Finger_SetFloatLimitsMaximum_System_Single_
[Finger.SetCurlLimitsMinimum(Single)]: Finger.md#Tilia_Visuals_BasicHand_Finger_SetCurlLimitsMinimum_System_Single_
[Finger.SetCurlLimitsMaximum(Single)]: Finger.md#Tilia_Visuals_BasicHand_Finger_SetCurlLimitsMaximum_System_Single_
[Tilia.Visuals.BasicHand]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[transitionRoutine]: #transitionRoutine
[Properties]: #Properties
[AnimationController]: #AnimationController
[Methods]: #Methods
[CancelTransition()]: #CancelTransition
[DetermineCurlMotion(Single)]: #DetermineCurlMotionSingle
[GetDirectionOffset(Single, Single)]: #GetDirectionOffsetSingle-Single
[OnDisable()]: #OnDisable
[Process()]: #Process
[ProcessFingerCurl()]: #ProcessFingerCurl
[SetFingerCurlPosition(Single)]: #SetFingerCurlPositionSingle
[StartTransition(Single)]: #StartTransitionSingle
[TransitionFingerCurlPosition(Single)]: #TransitionFingerCurlPositionSingle
[Implements]: #Implements
