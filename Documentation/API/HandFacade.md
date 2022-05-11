# Class HandFacade

The public facade for the hand.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ColliderContainer]
  * [IndexFinger]
  * [MiddleFinger]
  * [PinkyFinger]
  * [RingFinger]
  * [Thumb]

## Details

##### Inheritance

* System.Object
* HandFacade

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandFacade : MonoBehaviour
```

### Properties

#### ColliderContainer

The GameObject containing the hand colliders.

##### Declaration

```
public GameObject ColliderContainer { get; protected set; }
```

#### IndexFinger

The [Finger] for the Index Finger.

##### Declaration

```
public Finger IndexFinger { get; set; }
```

#### MiddleFinger

The [Finger] for the Middle Finger.

##### Declaration

```
public Finger MiddleFinger { get; set; }
```

#### PinkyFinger

The [Finger] for the Pinky Finger.

##### Declaration

```
public Finger PinkyFinger { get; set; }
```

#### RingFinger

The [Finger] for the Ring Finger.

##### Declaration

```
public Finger RingFinger { get; set; }
```

#### Thumb

The [Finger] for the Thumb.

##### Declaration

```
public Finger Thumb { get; set; }
```

[Tilia.Visuals.BasicHand]: README.md
[Finger]: Finger.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ColliderContainer]: #ColliderContainer
[IndexFinger]: #IndexFinger
[MiddleFinger]: #MiddleFinger
[PinkyFinger]: #PinkyFinger
[RingFinger]: #RingFinger
[Thumb]: #Thumb
