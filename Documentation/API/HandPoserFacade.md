# Class HandPoserFacade

Applies a predefined pose to the given [Target].

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedColliderState]
  * [cachedPosition]
  * [cachedRotation]
  * [cachedScale]
* [Properties]
  * [ApplyPoseValues]
  * [ColliderState]
  * [IndexFingerPose]
  * [MiddleFingerPose]
  * [PinkyFingerPose]
  * [PositionOverride]
  * [RingFingerPose]
  * [RotationOverride]
  * [ScaleOverride]
  * [Target]
  * [ThumbPose]
* [Methods]
  * [ApplyData()]
  * [ApplyPose()]
  * [CacheData()]
  * [ClearTarget()]
  * [OnAfterTargetChange()]
  * [OnEnable()]
  * [RemovePose()]
  * [RestoreFromCache()]

## Details

##### Inheritance

* System.Object
* HandPoserFacade

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandPoserFacade : MonoBehaviour
```

### Fields

#### cachedColliderState

The cached collider state of the [Target].

##### Declaration

```
protected bool cachedColliderState
```

#### cachedPosition

The cached Transform.localPosition of the [Target].

##### Declaration

```
protected Vector3 cachedPosition
```

#### cachedRotation

The cached Transform.localRotation of the [Target].

##### Declaration

```
protected Quaternion cachedRotation
```

#### cachedScale

The cached Transform.localScale of the [Target].

##### Declaration

```
protected Vector3 cachedScale
```

### Properties

#### ApplyPoseValues

The property values on the [Target] to apply when posing.

##### Declaration

```
public HandPoserFacade.PoseValues ApplyPoseValues { get; set; }
```

#### ColliderState

Determines the activation state of the colliders on the [Target].

##### Declaration

```
public bool ColliderState { get; set; }
```

#### IndexFingerPose

The Index Finger to pose.

##### Declaration

```
public LinkedFingerPoser IndexFingerPose { get; protected set; }
```

#### MiddleFingerPose

The Middle Finger to pose.

##### Declaration

```
public LinkedFingerPoser MiddleFingerPose { get; protected set; }
```

#### PinkyFingerPose

The Pinky Finger to pose.

##### Declaration

```
public LinkedFingerPoser PinkyFingerPose { get; protected set; }
```

#### PositionOverride

Apply a local position override on the [Target].

##### Declaration

```
public Vector3 PositionOverride { get; set; }
```

#### RingFingerPose

The Ring Finger to pose.

##### Declaration

```
public LinkedFingerPoser RingFingerPose { get; protected set; }
```

#### RotationOverride

Apply a local euler rotation override on the [Target].

##### Declaration

```
public Vector3 RotationOverride { get; set; }
```

#### ScaleOverride

Apply a local scale override on the [Target].

##### Declaration

```
public Vector3 ScaleOverride { get; set; }
```

#### Target

The [HandFacade] to pose.

##### Declaration

```
public HandFacade Target { get; set; }
```

#### ThumbPose

The Thumb to pose.

##### Declaration

```
public LinkedFingerPoser ThumbPose { get; protected set; }
```

### Methods

#### ApplyData()

Applies the valid pose data values to the [Target].

##### Declaration

```
protected virtual void ApplyData()
```

#### ApplyPose()

Applies the set pose.

##### Declaration

```
public virtual void ApplyPose()
```

#### CacheData()

Caches the [Target] data.

##### Declaration

```
protected virtual void CacheData()
```

#### ClearTarget()

Clears [Target].

##### Declaration

```
public virtual void ClearTarget()
```

#### OnAfterTargetChange()

Called after [Target].

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### RemovePose()

Removes the applied pose.

##### Declaration

```
public virtual void RemovePose()
```

#### RestoreFromCache()

Restores the [Target] data from the cache.

##### Declaration

```
protected virtual void RestoreFromCache()
```

[Target]: HandPoserFacade.md#Target
[Tilia.Visuals.BasicHand]: README.md
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[HandPoserFacade.PoseValues]: HandPoserFacade.PoseValues.md
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[HandFacade]: HandFacade.md
[LinkedFingerPoser]: LinkedFingerPoser.md
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Target]: HandPoserFacade.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedColliderState]: #cachedColliderState
[cachedPosition]: #cachedPosition
[cachedRotation]: #cachedRotation
[cachedScale]: #cachedScale
[Properties]: #Properties
[ApplyPoseValues]: #ApplyPoseValues
[ColliderState]: #ColliderState
[IndexFingerPose]: #IndexFingerPose
[MiddleFingerPose]: #MiddleFingerPose
[PinkyFingerPose]: #PinkyFingerPose
[PositionOverride]: #PositionOverride
[RingFingerPose]: #RingFingerPose
[RotationOverride]: #RotationOverride
[ScaleOverride]: #ScaleOverride
[Target]: #Target
[ThumbPose]: #ThumbPose
[Methods]: #Methods
[ApplyData()]: #ApplyData
[ApplyPose()]: #ApplyPose
[CacheData()]: #CacheData
[ClearTarget()]: #ClearTarget
[OnAfterTargetChange()]: #OnAfterTargetChange
[OnEnable()]: #OnEnable
[RemovePose()]: #RemovePose
[RestoreFromCache()]: #RestoreFromCache
