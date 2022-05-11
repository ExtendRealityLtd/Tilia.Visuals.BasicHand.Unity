## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]

## Details

# Enum LinkedFingerPoser.PoseValues

The property values to set when posing.

##### Namespace

* [Tilia.Visuals.BasicHand]

##### Syntax

```
[Flags]
public enum PoseValues
```

### Fields

| Name | Description |
| --- | --- |
| BoolData | The boolean for the finger curl data. |
| CurlLimits | The minimum and maximum limits that the finger curl can extend or retract to. |
| FloatData | The float for the finger curl data. |
| FloatLimits | The minimum and maximum limits of the given float data. |
| ForceTransitionThreshold | The distance the current curl value has to be away from the input curl value for it to transition to that state. |
| InputSource | The source of the input for the finger. |
| OverrideValue | The value to force to be used for the finger curl data. |
| TransitionSpeed | The speed in which to transition the finger to the destination value. |

[Tilia.Visuals.BasicHand]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
