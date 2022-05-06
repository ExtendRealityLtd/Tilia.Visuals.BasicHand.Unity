# Class HandPoser

Poses the hand using pre-defined settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedCurrentValues]
  * [cachedInputSources]
  * [cachedOverrideValues]
* [Properties]
  * [Hand]
  * [IndexFingerValue]
  * [MiddleFingerValue]
  * [PinkyFingerValue]
  * [RingFingerValue]
  * [ThumbValue]
* [Methods]
  * [ActivatePose()]
  * [CacheCurrentValues()]
  * [CacheInputSources()]
  * [CacheOverrideValues()]
  * [ClearHand()]
  * [DeactivatePose(Boolean)]
  * [RestoreCurrentValues()]
  * [RestoreInputSources()]
  * [RestoreOverrideValues()]
  * [SetCurrentValues(Single, Single, Single, Single, Single)]
  * [SetInputSources(FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType)]
  * [SetOverrideValues(Single, Single, Single, Single, Single)]

## Details

##### Inheritance

* System.Object
* HandPoser

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandPoser : MonoBehaviour
```

### Fields

#### cachedCurrentValues

The cached existing current finger values.

##### Declaration

```
protected float[] cachedCurrentValues
```

#### cachedInputSources

The cached existing input sources.

##### Declaration

```
protected FingerController.InputType[] cachedInputSources
```

#### cachedOverrideValues

The cached existing current override values.

##### Declaration

```
protected float[] cachedOverrideValues
```

### Properties

#### Hand

The hand to pose.

##### Declaration

```
public HandFacade Hand { get; set; }
```

#### IndexFingerValue

The curl value for the Index Finger.

##### Declaration

```
public float IndexFingerValue { get; set; }
```

#### MiddleFingerValue

The curl value for the Middle Finger.

##### Declaration

```
public float MiddleFingerValue { get; set; }
```

#### PinkyFingerValue

The curl value for the Pinky Finger.

##### Declaration

```
public float PinkyFingerValue { get; set; }
```

#### RingFingerValue

The curl value for the Ring Finger.

##### Declaration

```
public float RingFingerValue { get; set; }
```

#### ThumbValue

The curl value for the Thumb.

##### Declaration

```
public float ThumbValue { get; set; }
```

### Methods

#### ActivatePose()

Activates the pose.

##### Declaration

```
public virtual void ActivatePose()
```

#### CacheCurrentValues()

Caches the existing hand current values.

##### Declaration

```
protected virtual void CacheCurrentValues()
```

#### CacheInputSources()

Caches the existing hand input sources.

##### Declaration

```
protected virtual void CacheInputSources()
```

#### CacheOverrideValues()

Caches the existing hand override values.

##### Declaration

```
protected virtual void CacheOverrideValues()
```

#### ClearHand()

Clears [Hand].

##### Declaration

```
public virtual void ClearHand()
```

#### DeactivatePose(Boolean)

Deactivates the pose and restores the previous hand state.

##### Declaration

```
public virtual void DeactivatePose(bool restorePreviousHandValues)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | restorePreviousHandValues | Whether to restore the previous hand values. |

#### RestoreCurrentValues()

Restores the cached hand current values.

##### Declaration

```
protected virtual void RestoreCurrentValues()
```

#### RestoreInputSources()

Restores the cached hand input sources.

##### Declaration

```
protected virtual void RestoreInputSources()
```

#### RestoreOverrideValues()

Restores the cached hand override values.

##### Declaration

```
protected virtual void RestoreOverrideValues()
```

#### SetCurrentValues(Single, Single, Single, Single, Single)

Sets the current values on the hand.

##### Declaration

```
protected virtual void SetCurrentValues(float thumb, float index, float middle, float ring, float pinky)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | thumb | The thumb property. |
| System.Single | index | The index finger property. |
| System.Single | middle | The middle finger property. |
| System.Single | ring | The ring finger property. |
| System.Single | pinky | The pinky finger property. |

#### SetInputSources(FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType)

Sets the input sources on the hand.

##### Declaration

```
protected virtual void SetInputSources(FingerController.InputType thumb, FingerController.InputType index, FingerController.InputType middle, FingerController.InputType ring, FingerController.InputType pinky)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [FingerController.InputType] | thumb | The thumb property. |
| [FingerController.InputType] | index | The index finger property. |
| [FingerController.InputType] | middle | The middle finger property. |
| [FingerController.InputType] | ring | The ring finger property. |
| [FingerController.InputType] | pinky | The pinky finger property. |

#### SetOverrideValues(Single, Single, Single, Single, Single)

Sets the override values on the hand.

##### Declaration

```
protected virtual void SetOverrideValues(float thumb, float index, float middle, float ring, float pinky)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | thumb | The thumb property. |
| System.Single | index | The index finger property. |
| System.Single | middle | The middle finger property. |
| System.Single | ring | The ring finger property. |
| System.Single | pinky | The pinky finger property. |

[Tilia.Visuals.BasicHand]: README.md
[HandFacade]: HandFacade.md
[Hand]: HandPoser.md#Hand
[FingerController.InputType]: FingerController.InputType.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedCurrentValues]: #cachedCurrentValues
[cachedInputSources]: #cachedInputSources
[cachedOverrideValues]: #cachedOverrideValues
[Properties]: #Properties
[Hand]: #Hand
[IndexFingerValue]: #IndexFingerValue
[MiddleFingerValue]: #MiddleFingerValue
[PinkyFingerValue]: #PinkyFingerValue
[RingFingerValue]: #RingFingerValue
[ThumbValue]: #ThumbValue
[Methods]: #Methods
[ActivatePose()]: #ActivatePose
[CacheCurrentValues()]: #CacheCurrentValues
[CacheInputSources()]: #CacheInputSources
[CacheOverrideValues()]: #CacheOverrideValues
[ClearHand()]: #ClearHand
[DeactivatePose(Boolean)]: #DeactivatePoseBoolean
[RestoreCurrentValues()]: #RestoreCurrentValues
[RestoreInputSources()]: #RestoreInputSources
[RestoreOverrideValues()]: #RestoreOverrideValues
[SetCurrentValues(Single, Single, Single, Single, Single)]: #SetCurrentValuesSingle-Single-Single-Single-Single
[SetInputSources(FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType, FingerController.InputType)]: #SetInputSourcesFingerController.InputType-FingerController.InputType-FingerController.InputType-FingerController.InputType-FingerController.InputType
[SetOverrideValues(Single, Single, Single, Single, Single)]: #SetOverrideValuesSingle-Single-Single-Single-Single
