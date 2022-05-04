# Class HandController

Controls the hand avatar.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [transitionRoutines]
* [Properties]
  * [AnimationController]
  * [IndexFinger]
  * [MiddleFinger]
  * [PinkyFinger]
  * [RingFinger]
  * [Thumb]
* [Methods]
  * [Awake()]
  * [CancelTransition(Int32)]
  * [ClearIndexFingerBoolData()]
  * [ClearIndexFingerFloatData()]
  * [ClearIndexFingerFloatLimits()]
  * [ClearMiddleFingerBoolData()]
  * [ClearMiddleFingerFloatData()]
  * [ClearMiddleFingerFloatLimits()]
  * [ClearPinkyFingerBoolData()]
  * [ClearPinkyFingerFloatData()]
  * [ClearPinkyFingerFloatLimits()]
  * [ClearRingFingerBoolData()]
  * [ClearRingFingerFloatData()]
  * [ClearRingFingerFloatLimits()]
  * [ClearThumbBoolData()]
  * [ClearThumbFloatData()]
  * [ClearThumbFloatLimits()]
  * [GetDirectionOffset(Single, Single)]
  * [OnDisable()]
  * [Process()]
  * [ProcessFinger(HandController.FingerController)]
  * [SetFingerPosition(HandController.FingerController, Single)]
  * [SetIndexFingerBoolData(BooleanAction)]
  * [SetIndexFingerFloatData(FloatAction)]
  * [SetIndexFingerFloatLimits(FloatRange)]
  * [SetIndexFingerFloatLimitsMaximum(Single)]
  * [SetIndexFingerFloatLimitsMinimum(Single)]
  * [SetIndexFingerInputSource(Int32)]
  * [SetIndexFingerOverrideValue(Single)]
  * [SetIndexFingerTransitionSpeed(Single)]
  * [SetMiddleFingerBoolData(BooleanAction)]
  * [SetMiddleFingerFloatData(FloatAction)]
  * [SetMiddleFingerFloatLimits(FloatRange)]
  * [SetMiddleFingerFloatLimitsMaximum(Single)]
  * [SetMiddleFingerFloatLimitsMinimum(Single)]
  * [SetMiddleFingerInputSource(Int32)]
  * [SetMiddleFingerOverrideValue(Single)]
  * [SetMiddleFingerTransitionSpeed(Single)]
  * [SetPinkyFingerBoolData(BooleanAction)]
  * [SetPinkyFingerFloatData(FloatAction)]
  * [SetPinkyFingerFloatLimits(FloatRange)]
  * [SetPinkyFingerFloatLimitsMaximum(Single)]
  * [SetPinkyFingerFloatLimitsMinimum(Single)]
  * [SetPinkyFingerInputSource(Int32)]
  * [SetPinkyFingerOverrideValue(Single)]
  * [SetPinkyFingerTransitionSpeed(Single)]
  * [SetRingFingerBoolData(BooleanAction)]
  * [SetRingFingerFloatData(FloatAction)]
  * [SetRingFingerFloatLimits(FloatRange)]
  * [SetRingFingerFloatLimitsMaximum(Single)]
  * [SetRingFingerFloatLimitsMinimum(Single)]
  * [SetRingFingerInputSource(Int32)]
  * [SetRingFingerOverrideValue(Single)]
  * [SetRingFingerTransitionSpeed(Single)]
  * [SetThumbBoolData(BooleanAction)]
  * [SetThumbFloatData(FloatAction)]
  * [SetThumbFloatLimits(FloatRange)]
  * [SetThumbFloatLimitsMaximum(Single)]
  * [SetThumbFloatLimitsMinimum(Single)]
  * [SetThumbInputSource(Int32)]
  * [SetThumbOverrideValue(Single)]
  * [SetThumbTransitionSpeed(Single)]
  * [StartTransition(HandController.FingerController, Single)]
  * [TransitionFingerPosition(HandController.FingerController, Single)]
* [Implements]

## Details

##### Inheritance

* System.Object
* HandController

##### Implements

IProcessable

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandController : MonoBehaviour, IProcessable
```

### Fields

#### transitionRoutines

The coroutines for the finger transitions.

##### Declaration

```
protected Coroutine[] transitionRoutines
```

### Properties

#### AnimationController

The Animator to control the finger motion.

##### Declaration

```
public Animator AnimationController { get; protected set; }
```

#### IndexFinger

The [HandController.FingerController] for the Index finger of the hand.

##### Declaration

```
public HandController.FingerController IndexFinger { get; set; }
```

#### MiddleFinger

The [HandController.FingerController] for the Middle finger of the hand.

##### Declaration

```
public HandController.FingerController MiddleFinger { get; set; }
```

#### PinkyFinger

The [HandController.FingerController] for the Pinky finger of the hand.

##### Declaration

```
public HandController.FingerController PinkyFinger { get; set; }
```

#### RingFinger

The [HandController.FingerController] for the Ring finger of the hand.

##### Declaration

```
public HandController.FingerController RingFinger { get; set; }
```

#### Thumb

The [HandController.FingerController] for the Thumb of the hand.

##### Declaration

```
public HandController.FingerController Thumb { get; set; }
```

### Methods

#### Awake()

##### Declaration

```
protected virtual void Awake()
```

#### CancelTransition(Int32)

Cancels an existing transition routine.

##### Declaration

```
protected virtual void CancelTransition(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index to cancel. |

#### ClearIndexFingerBoolData()

Clears IndexFinger.BoolData.

##### Declaration

```
public virtual void ClearIndexFingerBoolData()
```

#### ClearIndexFingerFloatData()

Clears IndexFinger.FloatData.

##### Declaration

```
public virtual void ClearIndexFingerFloatData()
```

#### ClearIndexFingerFloatLimits()

Clears IndexFinger.FloatLimits.

##### Declaration

```
public virtual void ClearIndexFingerFloatLimits()
```

#### ClearMiddleFingerBoolData()

Clears MiddleFinger.BoolData.

##### Declaration

```
public virtual void ClearMiddleFingerBoolData()
```

#### ClearMiddleFingerFloatData()

Clears MiddleFinger.FloatData.

##### Declaration

```
public virtual void ClearMiddleFingerFloatData()
```

#### ClearMiddleFingerFloatLimits()

Clears MiddleFinger.FloatLimits.

##### Declaration

```
public virtual void ClearMiddleFingerFloatLimits()
```

#### ClearPinkyFingerBoolData()

Clears PinkyFinger.BoolData.

##### Declaration

```
public virtual void ClearPinkyFingerBoolData()
```

#### ClearPinkyFingerFloatData()

Clears PinkyFinger.FloatData.

##### Declaration

```
public virtual void ClearPinkyFingerFloatData()
```

#### ClearPinkyFingerFloatLimits()

Clears PinkyFinger.FloatLimits.

##### Declaration

```
public virtual void ClearPinkyFingerFloatLimits()
```

#### ClearRingFingerBoolData()

Clears RingFinger.BoolData.

##### Declaration

```
public virtual void ClearRingFingerBoolData()
```

#### ClearRingFingerFloatData()

Clears RingFinger.FloatData.

##### Declaration

```
public virtual void ClearRingFingerFloatData()
```

#### ClearRingFingerFloatLimits()

Clears RingFinger.FloatLimits.

##### Declaration

```
public virtual void ClearRingFingerFloatLimits()
```

#### ClearThumbBoolData()

Clears Thumb.BoolData.

##### Declaration

```
public virtual void ClearThumbBoolData()
```

#### ClearThumbFloatData()

Clears Thumb.FloatData.

##### Declaration

```
public virtual void ClearThumbFloatData()
```

#### ClearThumbFloatLimits()

Clears Thumb.FloatLimits.

##### Declaration

```
public virtual void ClearThumbFloatLimits()
```

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

#### ProcessFinger(HandController.FingerController)

Processes the control of the given finger.

##### Declaration

```
protected virtual void ProcessFinger(HandController.FingerController finger)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [HandController.FingerController] | finger | The finger to control. |

#### SetFingerPosition(HandController.FingerController, Single)

Sets the finger position to the given value.

##### Declaration

```
protected virtual void SetFingerPosition(HandController.FingerController finger, float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [HandController.FingerController] | finger | The finger to set. |
| System.Single | targetValue | The target position to use. |

#### SetIndexFingerBoolData(BooleanAction)

Sets the IndexFinger.BoolData.

##### Declaration

```
public virtual void SetIndexFingerBoolData(BooleanAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | value | The action to set to. |

#### SetIndexFingerFloatData(FloatAction)

Sets the IndexFinger.FloatData.

##### Declaration

```
public virtual void SetIndexFingerFloatData(FloatAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | value | The action to set to. |

#### SetIndexFingerFloatLimits(FloatRange)

Sets the IndexFinger.FloatLimits.

##### Declaration

```
public virtual void SetIndexFingerFloatLimits(FloatRange value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | value | The range to set to. |

#### SetIndexFingerFloatLimitsMaximum(Single)

Sets the maximum value in IndexFinger.FloatLimits.

##### Declaration

```
public virtual void SetIndexFingerFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetIndexFingerFloatLimitsMinimum(Single)

Sets the minimum value in IndexFinger.FloatLimits.

##### Declaration

```
public virtual void SetIndexFingerFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetIndexFingerInputSource(Int32)

Sets the IndexFinger.InputSource.

##### Declaration

```
public virtual void SetIndexFingerInputSource(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value | The source index to set to. |

#### SetIndexFingerOverrideValue(Single)

Sets the IndexFinger.OverrideValue.

##### Declaration

```
public virtual void SetIndexFingerOverrideValue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The override value to set to. |

#### SetIndexFingerTransitionSpeed(Single)

Sets the IndexFinger.TransitionSpeed.

##### Declaration

```
public virtual void SetIndexFingerTransitionSpeed(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The speed value to set to. |

#### SetMiddleFingerBoolData(BooleanAction)

Sets the MiddleFinger.BoolData.

##### Declaration

```
public virtual void SetMiddleFingerBoolData(BooleanAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | value | The action to set to. |

#### SetMiddleFingerFloatData(FloatAction)

Sets the MiddleFinger.FloatData.

##### Declaration

```
public virtual void SetMiddleFingerFloatData(FloatAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | value | The action to set to. |

#### SetMiddleFingerFloatLimits(FloatRange)

Sets the MiddleFinger.FloatLimits.

##### Declaration

```
public virtual void SetMiddleFingerFloatLimits(FloatRange value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | value | The range to set to. |

#### SetMiddleFingerFloatLimitsMaximum(Single)

Sets the maximum value in MiddleFinger.FloatLimits.

##### Declaration

```
public virtual void SetMiddleFingerFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetMiddleFingerFloatLimitsMinimum(Single)

Sets the minimum value in MiddleFinger.FloatLimits.

##### Declaration

```
public virtual void SetMiddleFingerFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetMiddleFingerInputSource(Int32)

Sets the MiddleFinger.InputSource.

##### Declaration

```
public virtual void SetMiddleFingerInputSource(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value | The source index to set to. |

#### SetMiddleFingerOverrideValue(Single)

Sets the MiddleFinger.OverrideValue.

##### Declaration

```
public virtual void SetMiddleFingerOverrideValue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The override value to set to. |

#### SetMiddleFingerTransitionSpeed(Single)

Sets the MiddleFinger.TransitionSpeed.

##### Declaration

```
public virtual void SetMiddleFingerTransitionSpeed(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The speed value to set to. |

#### SetPinkyFingerBoolData(BooleanAction)

Sets the PinkyFinger.BoolData.

##### Declaration

```
public virtual void SetPinkyFingerBoolData(BooleanAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | value | The action to set to. |

#### SetPinkyFingerFloatData(FloatAction)

Sets the PinkyFinger.FloatData.

##### Declaration

```
public virtual void SetPinkyFingerFloatData(FloatAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | value | The action to set to. |

#### SetPinkyFingerFloatLimits(FloatRange)

Sets the PinkyFinger.FloatLimits.

##### Declaration

```
public virtual void SetPinkyFingerFloatLimits(FloatRange value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | value | The range to set to. |

#### SetPinkyFingerFloatLimitsMaximum(Single)

Sets the maximum value in PinkyFinger.FloatLimits.

##### Declaration

```
public virtual void SetPinkyFingerFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetPinkyFingerFloatLimitsMinimum(Single)

Sets the minimum value in PinkyFinger.FloatLimits.

##### Declaration

```
public virtual void SetPinkyFingerFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetPinkyFingerInputSource(Int32)

Sets the PinkyFinger.InputSource.

##### Declaration

```
public virtual void SetPinkyFingerInputSource(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value | The source index to set to. |

#### SetPinkyFingerOverrideValue(Single)

Sets the PinkyFinger.OverrideValue.

##### Declaration

```
public virtual void SetPinkyFingerOverrideValue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The override value to set to. |

#### SetPinkyFingerTransitionSpeed(Single)

Sets the PinkyFinger.TransitionSpeed.

##### Declaration

```
public virtual void SetPinkyFingerTransitionSpeed(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The speed value to set to. |

#### SetRingFingerBoolData(BooleanAction)

Sets the RingFinger.BoolData.

##### Declaration

```
public virtual void SetRingFingerBoolData(BooleanAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | value | The action to set to. |

#### SetRingFingerFloatData(FloatAction)

Sets the RingFinger.FloatData.

##### Declaration

```
public virtual void SetRingFingerFloatData(FloatAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | value | The action to set to. |

#### SetRingFingerFloatLimits(FloatRange)

Sets the RingFinger.FloatLimits.

##### Declaration

```
public virtual void SetRingFingerFloatLimits(FloatRange value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | value | The range to set to. |

#### SetRingFingerFloatLimitsMaximum(Single)

Sets the maximum value in RingFinger.FloatLimits.

##### Declaration

```
public virtual void SetRingFingerFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetRingFingerFloatLimitsMinimum(Single)

Sets the minimum value in RingFinger.FloatLimits.

##### Declaration

```
public virtual void SetRingFingerFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetRingFingerInputSource(Int32)

Sets the RingFinger.InputSource.

##### Declaration

```
public virtual void SetRingFingerInputSource(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value | The source index to set to. |

#### SetRingFingerOverrideValue(Single)

Sets the RingFinger.OverrideValue.

##### Declaration

```
public virtual void SetRingFingerOverrideValue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The override value to set to. |

#### SetRingFingerTransitionSpeed(Single)

Sets the RingFinger.TransitionSpeed.

##### Declaration

```
public virtual void SetRingFingerTransitionSpeed(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The speed value to set to. |

#### SetThumbBoolData(BooleanAction)

Sets the Thumb.BoolData.

##### Declaration

```
public virtual void SetThumbBoolData(BooleanAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| BooleanAction | value | The action to set to. |

#### SetThumbFloatData(FloatAction)

Sets the Thumb.FloatData.

##### Declaration

```
public virtual void SetThumbFloatData(FloatAction value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatAction | value | The action to set to. |

#### SetThumbFloatLimits(FloatRange)

Sets the Thumb.FloatLimits.

##### Declaration

```
public virtual void SetThumbFloatLimits(FloatRange value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| FloatRange | value | The range to set to. |

#### SetThumbFloatLimitsMaximum(Single)

Sets the maximum value in Thumb.FloatLimits.

##### Declaration

```
public virtual void SetThumbFloatLimitsMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set maximum to. |

#### SetThumbFloatLimitsMinimum(Single)

Sets the minimum value in Thumb.FloatLimits.

##### Declaration

```
public virtual void SetThumbFloatLimitsMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The value to set minimum to. |

#### SetThumbInputSource(Int32)

Sets the Thumb.InputSource.

##### Declaration

```
public virtual void SetThumbInputSource(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value | The source index to set to. |

#### SetThumbOverrideValue(Single)

Sets the Thumb.OverrideValue.

##### Declaration

```
public virtual void SetThumbOverrideValue(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The override value to set to. |

#### SetThumbTransitionSpeed(Single)

Sets the Thumb.TransitionSpeed.

##### Declaration

```
public virtual void SetThumbTransitionSpeed(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The speed value to set to. |

#### StartTransition(HandController.FingerController, Single)

Starts a transition on a finger.

##### Declaration

```
protected virtual void StartTransition(HandController.FingerController finger, float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [HandController.FingerController] | finger | The finger to transition. |
| System.Single | targetValue | The value to transition to. |

#### TransitionFingerPosition(HandController.FingerController, Single)

Transitions a finger into the new position over the given finger transition speed.

##### Declaration

```
protected virtual IEnumerator TransitionFingerPosition(HandController.FingerController finger, float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [HandController.FingerController] | finger | The finger to transition. |
| System.Single | targetValue | The target position to transition to. |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | An enumerator to control the coroutine. |

### Implements

IProcessable

[Tilia.Visuals.BasicHand]: README.md
[HandController.FingerController]: HandController.FingerController.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[transitionRoutines]: #transitionRoutines
[Properties]: #Properties
[AnimationController]: #AnimationController
[IndexFinger]: #IndexFinger
[MiddleFinger]: #MiddleFinger
[PinkyFinger]: #PinkyFinger
[RingFinger]: #RingFinger
[Thumb]: #Thumb
[Methods]: #Methods
[Awake()]: #Awake
[CancelTransition(Int32)]: #CancelTransitionInt32
[ClearIndexFingerBoolData()]: #ClearIndexFingerBoolData
[ClearIndexFingerFloatData()]: #ClearIndexFingerFloatData
[ClearIndexFingerFloatLimits()]: #ClearIndexFingerFloatLimits
[ClearMiddleFingerBoolData()]: #ClearMiddleFingerBoolData
[ClearMiddleFingerFloatData()]: #ClearMiddleFingerFloatData
[ClearMiddleFingerFloatLimits()]: #ClearMiddleFingerFloatLimits
[ClearPinkyFingerBoolData()]: #ClearPinkyFingerBoolData
[ClearPinkyFingerFloatData()]: #ClearPinkyFingerFloatData
[ClearPinkyFingerFloatLimits()]: #ClearPinkyFingerFloatLimits
[ClearRingFingerBoolData()]: #ClearRingFingerBoolData
[ClearRingFingerFloatData()]: #ClearRingFingerFloatData
[ClearRingFingerFloatLimits()]: #ClearRingFingerFloatLimits
[ClearThumbBoolData()]: #ClearThumbBoolData
[ClearThumbFloatData()]: #ClearThumbFloatData
[ClearThumbFloatLimits()]: #ClearThumbFloatLimits
[GetDirectionOffset(Single, Single)]: #GetDirectionOffsetSingle-Single
[OnDisable()]: #OnDisable
[Process()]: #Process
[ProcessFinger(HandController.FingerController)]: #ProcessFingerHandController.FingerController
[SetFingerPosition(HandController.FingerController, Single)]: #SetFingerPositionHandController.FingerController-Single
[SetIndexFingerBoolData(BooleanAction)]: #SetIndexFingerBoolDataBooleanAction
[SetIndexFingerFloatData(FloatAction)]: #SetIndexFingerFloatDataFloatAction
[SetIndexFingerFloatLimits(FloatRange)]: #SetIndexFingerFloatLimitsFloatRange
[SetIndexFingerFloatLimitsMaximum(Single)]: #SetIndexFingerFloatLimitsMaximumSingle
[SetIndexFingerFloatLimitsMinimum(Single)]: #SetIndexFingerFloatLimitsMinimumSingle
[SetIndexFingerInputSource(Int32)]: #SetIndexFingerInputSourceInt32
[SetIndexFingerOverrideValue(Single)]: #SetIndexFingerOverrideValueSingle
[SetIndexFingerTransitionSpeed(Single)]: #SetIndexFingerTransitionSpeedSingle
[SetMiddleFingerBoolData(BooleanAction)]: #SetMiddleFingerBoolDataBooleanAction
[SetMiddleFingerFloatData(FloatAction)]: #SetMiddleFingerFloatDataFloatAction
[SetMiddleFingerFloatLimits(FloatRange)]: #SetMiddleFingerFloatLimitsFloatRange
[SetMiddleFingerFloatLimitsMaximum(Single)]: #SetMiddleFingerFloatLimitsMaximumSingle
[SetMiddleFingerFloatLimitsMinimum(Single)]: #SetMiddleFingerFloatLimitsMinimumSingle
[SetMiddleFingerInputSource(Int32)]: #SetMiddleFingerInputSourceInt32
[SetMiddleFingerOverrideValue(Single)]: #SetMiddleFingerOverrideValueSingle
[SetMiddleFingerTransitionSpeed(Single)]: #SetMiddleFingerTransitionSpeedSingle
[SetPinkyFingerBoolData(BooleanAction)]: #SetPinkyFingerBoolDataBooleanAction
[SetPinkyFingerFloatData(FloatAction)]: #SetPinkyFingerFloatDataFloatAction
[SetPinkyFingerFloatLimits(FloatRange)]: #SetPinkyFingerFloatLimitsFloatRange
[SetPinkyFingerFloatLimitsMaximum(Single)]: #SetPinkyFingerFloatLimitsMaximumSingle
[SetPinkyFingerFloatLimitsMinimum(Single)]: #SetPinkyFingerFloatLimitsMinimumSingle
[SetPinkyFingerInputSource(Int32)]: #SetPinkyFingerInputSourceInt32
[SetPinkyFingerOverrideValue(Single)]: #SetPinkyFingerOverrideValueSingle
[SetPinkyFingerTransitionSpeed(Single)]: #SetPinkyFingerTransitionSpeedSingle
[SetRingFingerBoolData(BooleanAction)]: #SetRingFingerBoolDataBooleanAction
[SetRingFingerFloatData(FloatAction)]: #SetRingFingerFloatDataFloatAction
[SetRingFingerFloatLimits(FloatRange)]: #SetRingFingerFloatLimitsFloatRange
[SetRingFingerFloatLimitsMaximum(Single)]: #SetRingFingerFloatLimitsMaximumSingle
[SetRingFingerFloatLimitsMinimum(Single)]: #SetRingFingerFloatLimitsMinimumSingle
[SetRingFingerInputSource(Int32)]: #SetRingFingerInputSourceInt32
[SetRingFingerOverrideValue(Single)]: #SetRingFingerOverrideValueSingle
[SetRingFingerTransitionSpeed(Single)]: #SetRingFingerTransitionSpeedSingle
[SetThumbBoolData(BooleanAction)]: #SetThumbBoolDataBooleanAction
[SetThumbFloatData(FloatAction)]: #SetThumbFloatDataFloatAction
[SetThumbFloatLimits(FloatRange)]: #SetThumbFloatLimitsFloatRange
[SetThumbFloatLimitsMaximum(Single)]: #SetThumbFloatLimitsMaximumSingle
[SetThumbFloatLimitsMinimum(Single)]: #SetThumbFloatLimitsMinimumSingle
[SetThumbInputSource(Int32)]: #SetThumbInputSourceInt32
[SetThumbOverrideValue(Single)]: #SetThumbOverrideValueSingle
[SetThumbTransitionSpeed(Single)]: #SetThumbTransitionSpeedSingle
[StartTransition(HandController.FingerController, Single)]: #StartTransitionHandController.FingerController-Single
[TransitionFingerPosition(HandController.FingerController, Single)]: #TransitionFingerPositionHandController.FingerController-Single
[Implements]: #Implements
