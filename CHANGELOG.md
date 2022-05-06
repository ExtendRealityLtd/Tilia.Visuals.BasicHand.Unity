# Changelog

## [2.1.0](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/compare/v2.0.0...v2.1.0) (2022-05-06)

#### Features

* **FingerController:** provide threshold to determine lerp transition ([eee676e](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/commit/eee676eaa11183ae6a27ed8859586ad350cca707))
  > Previously the lerped transition would only happen for the boolean or override value and the float value would never lerp. This has now been customised further so it is possible to lerp a float value if the current curl value and the given target curl value exceed the transition threshold.

## [2.0.0](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/compare/v1.0.0...v2.0.0) (2022-05-06)

#### :warning: BREAKING CHANGES :warning:

* **structure:** This commit reworks how the hand controlling is done. Instead of a global hand controller that has multiple embedded finger controllers, now it has a single Finger Controller MonoBehaviour that is independent per finger and then a HandFacade that provides a simple way of accessing the FingerController collection.

This means there doesn't need to be a bunch of repetitive methods for setting and clearing the FingerController properties as the FingerController can now be directly accessed. It also breaks down the logic into the smallest chunk its actually doing, which is simply controlling the finger. ([b4d9dd9](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/commit/b4d9dd90d406b2c0cc54d2a841518075a3385f2c))

#### Features

* **structure:** use individual finger controller components ([b4d9dd9](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/commit/b4d9dd90d406b2c0cc54d2a841518075a3385f2c))

## 1.0.0 (2022-05-06)

#### Features

* **structure:** create initial prefabs and documentation ([7914ac8](https://github.com/ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity/commit/7914ac855fa72ff7488fdde3a2bbd8ef380c8b70))
  > The initial prefabs and relevant documentation for the Basic Hand has been added to the repo.
