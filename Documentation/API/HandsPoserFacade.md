# Class HandsPoserFacade

The public interface for the hands poser.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [LeftHandContainer]
  * [RightHandContainer]
* [Methods]
  * [ApplyPose(Component)]
  * [ClearLeftHandContainer()]
  * [ClearRightHandContainer()]
  * [OnAfterLeftHandContainerChange()]
  * [OnAfterRightHandContainerChange()]
  * [RemovePose(Component)]

## Details

##### Inheritance

* System.Object
* HandsPoserFacade

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandsPoserFacade : MonoBehaviour
```

### Properties

#### Configuration

The linked configuration.

##### Declaration

```
public HandsPoserConfigurator Configuration { get; protected set; }
```

#### LeftHandContainer

The left hand avatar container.

##### Declaration

```
public GameObject LeftHandContainer { get; set; }
```

#### RightHandContainer

The right hand avatar container.

##### Declaration

```
public GameObject RightHandContainer { get; set; }
```

### Methods

#### ApplyPose(Component)

Applies the pose to the appropriate hand based on the given source.

##### Declaration

```
public virtual void ApplyPose(Component source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Component | source | The source the hand pose is for. |

#### ClearLeftHandContainer()

Clears [LeftHandContainer].

##### Declaration

```
public virtual void ClearLeftHandContainer()
```

#### ClearRightHandContainer()

Clears [RightHandContainer].

##### Declaration

```
public virtual void ClearRightHandContainer()
```

#### OnAfterLeftHandContainerChange()

Called after [LeftHandContainer] has been changed.

##### Declaration

```
protected virtual void OnAfterLeftHandContainerChange()
```

#### OnAfterRightHandContainerChange()

Called after [RightHandContainer] has been changed.

##### Declaration

```
protected virtual void OnAfterRightHandContainerChange()
```

#### RemovePose(Component)

Removes the pose from the appropriate hand based on the given source.

##### Declaration

```
public virtual void RemovePose(Component source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Component | source | The source the hand pose is on. |

[Tilia.Visuals.BasicHand]: README.md
[HandsPoserConfigurator]: HandsPoserConfigurator.md
[LeftHandContainer]: HandsPoserFacade.md#LeftHandContainer
[RightHandContainer]: HandsPoserFacade.md#RightHandContainer
[LeftHandContainer]: HandsPoserFacade.md#LeftHandContainer
[RightHandContainer]: HandsPoserFacade.md#RightHandContainer
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[LeftHandContainer]: #LeftHandContainer
[RightHandContainer]: #RightHandContainer
[Methods]: #Methods
[ApplyPose(Component)]: #ApplyPoseComponent
[ClearLeftHandContainer()]: #ClearLeftHandContainer
[ClearRightHandContainer()]: #ClearRightHandContainer
[OnAfterLeftHandContainerChange()]: #OnAfterLeftHandContainerChange
[OnAfterRightHandContainerChange()]: #OnAfterRightHandContainerChange
[RemovePose(Component)]: #RemovePoseComponent
