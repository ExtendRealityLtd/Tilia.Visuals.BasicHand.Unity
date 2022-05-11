# Class HandsPoserConfigurator

The internal setup for the hands poser.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ActivatePoseMatcher]
  * [DeactivatePoseMatcher]
  * [Facade]
  * [LeftHandPoser]
  * [LeftHandRule]
  * [RightHandPoser]
  * [RightHandRule]
* [Methods]
  * [ConfigureLeftHandRule()]
  * [ConfigureRightHandRule()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* HandsPoserConfigurator

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
public class HandsPoserConfigurator : MonoBehaviour
```

### Properties

#### ActivatePoseMatcher

The RulesMatcher for activating the pose.

##### Declaration

```
public RulesMatcher ActivatePoseMatcher { get; protected set; }
```

#### DeactivatePoseMatcher

The RulesMatcher for deactivating the pose.

##### Declaration

```
public RulesMatcher DeactivatePoseMatcher { get; protected set; }
```

#### Facade

The linked configuration.

##### Declaration

```
public HandsPoserFacade Facade { get; protected set; }
```

#### LeftHandPoser

The hand poser for the left hand.

##### Declaration

```
public HandPoserFacade LeftHandPoser { get; protected set; }
```

#### LeftHandRule

The Rule to determine the left hand.

##### Declaration

```
public ListContainsRule LeftHandRule { get; protected set; }
```

#### RightHandPoser

The hand poser for the right hand.

##### Declaration

```
public HandPoserFacade RightHandPoser { get; protected set; }
```

#### RightHandRule

The Rule to determine the right hand.

##### Declaration

```
public ListContainsRule RightHandRule { get; protected set; }
```

### Methods

#### ConfigureLeftHandRule()

Configures the left hand rule.

##### Declaration

```
public virtual void ConfigureLeftHandRule()
```

#### ConfigureRightHandRule()

Configures the right hand rule.

##### Declaration

```
public virtual void ConfigureRightHandRule()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Visuals.BasicHand]: README.md
[HandsPoserFacade]: HandsPoserFacade.md
[HandPoserFacade]: HandPoserFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ActivatePoseMatcher]: #ActivatePoseMatcher
[DeactivatePoseMatcher]: #DeactivatePoseMatcher
[Facade]: #Facade
[LeftHandPoser]: #LeftHandPoser
[LeftHandRule]: #LeftHandRule
[RightHandPoser]: #RightHandPoser
[RightHandRule]: #RightHandRule
[Methods]: #Methods
[ConfigureLeftHandRule()]: #ConfigureLeftHandRule
[ConfigureRightHandRule()]: #ConfigureRightHandRule
[OnEnable()]: #OnEnable
