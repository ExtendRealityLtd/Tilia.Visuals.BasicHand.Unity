# Class LinkedFingerPoser

Poses the linked Finger.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedFingerData]
* [Properties]
  * [ApplyPoseValues]
  * [Target]
* [Methods]
  * [ApplyPose()]
  * [Awake()]
  * [ClearTarget()]
  * [CopyData(Finger, Finger, Boolean)]
  * [RemovePose()]

## Details

##### Inheritance

* System.Object
* [Finger]
* LinkedFingerPoser

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
public class LinkedFingerPoser : Finger
```

### Fields

#### cachedFingerData

The cache of data from the linked [Target].

##### Declaration

```
protected LinkedFingerPoser.FingerDataCache cachedFingerData
```

### Properties

#### ApplyPoseValues

The property values on the [Target] to apply when posing.

##### Declaration

```
public LinkedFingerPoser.PoseValues ApplyPoseValues { get; set; }
```

#### Target

The [Finger] to change with the set poses.

##### Declaration

```
public Finger Target { get; set; }
```

### Methods

#### ApplyPose()

Applies the set finger pose to the linked [Target].

##### Declaration

```
public virtual void ApplyPose()
```

#### Awake()

##### Declaration

```
protected virtual void Awake()
```

#### ClearTarget()

Clears [Target].

##### Declaration

```
public virtual void ClearTarget()
```

#### CopyData(Finger, Finger, Boolean)

Copies property data from the source to the target.

##### Declaration

```
protected virtual void CopyData(Finger source, Finger target, bool ignoreUsePoseValues = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Finger] | source | The source to copy the data from. |
| [Finger] | target | The target to copy the data to. |
| System.Boolean | ignoreUsePoseValues | Whether to ignore the [ApplyPoseValues] restrictions and set every property. |

#### RemovePose()

Removes the applied pose and resets the linked [Target] back to the [cachedFingerData].

##### Declaration

```
public virtual void RemovePose()
```

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
[Target]: LinkedFingerPoser.md#Target
[LinkedFingerPoser.FingerDataCache]: LinkedFingerPoser.FingerDataCache.md
[Target]: LinkedFingerPoser.md#Target
[LinkedFingerPoser.PoseValues]: LinkedFingerPoser.PoseValues.md
[Target]: LinkedFingerPoser.md#Target
[Target]: LinkedFingerPoser.md#Target
[Finger]: Finger.md
[ApplyPoseValues]: LinkedFingerPoser.md#ApplyPoseValues
[Target]: LinkedFingerPoser.md#Target
[cachedFingerData]: LinkedFingerPoser.md#cachedFingerData
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedFingerData]: #cachedFingerData
[Properties]: #Properties
[ApplyPoseValues]: #ApplyPoseValues
[Target]: #Target
[Methods]: #Methods
[ApplyPose()]: #ApplyPose
[Awake()]: #Awake
[ClearTarget()]: #ClearTarget
[CopyData(Finger, Finger, Boolean)]: #CopyDataFinger-Finger-Boolean
[RemovePose()]: #RemovePose
