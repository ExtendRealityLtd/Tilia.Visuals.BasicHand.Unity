# Class Finger

The concept of a avatar finger.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
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
  * [ClearBoolData()]
  * [ClearFloatData()]
  * [ClearFloatLimits()]
  * [ClearSourceInput()]
  * [SetCurlLimitsMaximum(Single)]
  * [SetCurlLimitsMinimum(Single)]
  * [SetFloatLimitsMaximum(Single)]
  * [SetFloatLimitsMinimum(Single)]
  * [SetSourceInput(Int32)]

## Details

##### Inheritance

* System.Object
* Finger
* [FingerController]
* [LinkedFingerPoser]
* [LinkedFingerPoser.FingerDataCache]

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public abstract class Finger : MonoBehaviour
```

### Properties

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
public Finger.InputType InputSource { get; set; }
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

The speed in which to transition the finger to the destination value.

##### Declaration

```
public float TransitionSpeed { get; set; }
```

### Methods

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
| System.Int32 | inputTypeIndex | The index of the [Finger.InputType]. |

[FingerController]: FingerController.md
[LinkedFingerPoser]: LinkedFingerPoser.md
[LinkedFingerPoser.FingerDataCache]: LinkedFingerPoser.FingerDataCache.md
[Tilia.Visuals.BasicHand]: README.md
[FloatData]: Finger.md#FloatData
[FloatData]: Finger.md#FloatData
[FloatLimits]: Finger.md#FloatLimits
[BoolData]: Finger.md#BoolData
[FloatData]: Finger.md#FloatData
[FloatLimits]: Finger.md#FloatLimits
[InputSource]: Finger.md#InputSource
[CurlLimits]: Finger.md#CurlLimits
[CurlLimits]: Finger.md#CurlLimits
[FloatLimits]: Finger.md#FloatLimits
[FloatLimits]: Finger.md#FloatLimits
[InputSource]: Finger.md#InputSource
[Finger.InputType]: Finger.InputType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
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
[ClearBoolData()]: #ClearBoolData
[ClearFloatData()]: #ClearFloatData
[ClearFloatLimits()]: #ClearFloatLimits
[ClearSourceInput()]: #ClearSourceInput
[SetCurlLimitsMaximum(Single)]: #SetCurlLimitsMaximumSingle
[SetCurlLimitsMinimum(Single)]: #SetCurlLimitsMinimumSingle
[SetFloatLimitsMaximum(Single)]: #SetFloatLimitsMaximumSingle
[SetFloatLimitsMinimum(Single)]: #SetFloatLimitsMinimumSingle
[SetSourceInput(Int32)]: #SetSourceInputInt32
