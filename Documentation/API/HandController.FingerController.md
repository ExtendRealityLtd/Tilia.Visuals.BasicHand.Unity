# Class HandController.FingerController

Controls the finger armature.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [BoolData]
  * [CurrentCurlValue]
  * [FingerIdentifier]
  * [FloatData]
  * [FloatLimits]
  * [InputSource]
  * [NormalizedFloatData]
  * [OverrideValue]
  * [TransitionSpeed]
* [Methods]
  * [ClearAllData()]
  * [ClearBoolData()]
  * [ClearFloatData()]
  * [ClearFloatLimits()]
  * [ClearSourceInput()]
  * [SetSourceInput(Int32)]

## Details

##### Inheritance

* System.Object
* HandController.FingerController

##### Inherited Members

System.Object.ToString()

System.Object.Equals(System.Object)

System.Object.Equals(System.Object, System.Object)

System.Object.ReferenceEquals(System.Object, System.Object)

System.Object.GetHashCode()

System.Object.GetType()

System.Object.MemberwiseClone()

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
[Serializable]
public class FingerController
```

### Properties

#### BoolData

The BooleanAction that contains the finger curl data.

##### Declaration

```
public BooleanAction BoolData { get; set; }
```

#### CurrentCurlValue

The current curl value of the finger state.

##### Declaration

```
public virtual float CurrentCurlValue { get; set; }
```

#### FingerIdentifier

A numerical identifier for the finger.

##### Declaration

```
public virtual int FingerIdentifier { get; set; }
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

#### InputSource

The source of the input for the finger.

##### Declaration

```
public HandController.FingerController.InputType InputSource { get; set; }
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

#### ClearAllData()

##### Declaration

```
public virtual void ClearAllData()
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

#### SetSourceInput(Int32)

Sets [InputSource].

##### Declaration

```
public virtual void SetSourceInput(int inputTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | inputTypeIndex | The index of the [HandController.FingerController.InputType]. |

[Tilia.Visuals.BasicHand]: README.md
[FloatData]: HandController.FingerController.md#FloatData
[FloatData]: HandController.FingerController.md#FloatData
[FloatLimits]: HandController.FingerController.md#FloatLimits
[BoolData]: HandController.FingerController.md#BoolData
[FloatData]: HandController.FingerController.md#FloatData
[FloatLimits]: HandController.FingerController.md#FloatLimits
[InputSource]: HandController.FingerController.md#InputSource
[InputSource]: HandController.FingerController.md#InputSource
[HandController.FingerController.InputType]: HandController.FingerController.InputType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[BoolData]: #BoolData
[CurrentCurlValue]: #CurrentCurlValue
[FingerIdentifier]: #FingerIdentifier
[FloatData]: #FloatData
[FloatLimits]: #FloatLimits
[InputSource]: #InputSource
[NormalizedFloatData]: #NormalizedFloatData
[OverrideValue]: #OverrideValue
[TransitionSpeed]: #TransitionSpeed
[Methods]: #Methods
[ClearAllData()]: #ClearAllData
[ClearBoolData()]: #ClearBoolData
[ClearFloatData()]: #ClearFloatData
[ClearFloatLimits()]: #ClearFloatLimits
[ClearSourceInput()]: #ClearSourceInput
[SetSourceInput(Int32)]: #SetSourceInputInt32
