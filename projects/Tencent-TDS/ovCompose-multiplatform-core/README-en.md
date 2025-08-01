﻿<p align="center">
    <img alt="ovCompose Logo" src="https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/img/ovCompose.svg" />
</p>

### English
ovCompose (online-video-compose) is a cross-platform development framework launched by the Tencent Video team within Oteam, the leading frontend group at Tencent. It is based on the Compose Multiplatform ecosystem and aims to address the limitations of Jetbrains Compose Multiplatform, specifically its lack of support for the HarmonyOS platform and the constraints on mixed layout rendering on iOS. ovCompose makes it easier for businesses to build fully cross-platform apps.

Learn more about [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_en.md)

### 中文
ovCompose（online-video-compose）是腾讯大前端领域Oteam中，腾讯视频团队基于 Compose Multiplatform 生态推出的跨平台开发框架，旨在弥补Jetbrains Compose Multiplatform不支持鸿蒙平台的遗憾与解决iOS平台混排受限的问题，便于业务构建全跨端App。

详情请见 [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_zh.md)

---
# Android Jetpack

[![Revved up by Gradle Enterprise](https://img.shields.io/badge/Revved%20up%20by-Gradle%20Enterprise-06A0CE?logo=Gradle&labelColor=02303A)](https://ge.androidx.dev)

Jetpack is a suite of libraries, tools, and guidance to help developers write high-quality apps easier. These components help you follow best practices, free you from writing boilerplate code, and simplify complex tasks, so you can focus on the code you care about.

Jetpack comprises the `androidx.*` package libraries, unbundled from the platform APIs. This means that it offers backward compatibility and is updated more frequently than the Android platform, making sure you always have access to the latest and greatest versions of the Jetpack components.

Our official AARs and JARs binaries are distributed through [Google Maven](https://maven.google.com).

You can learn more about using it from [Android Jetpack landing page](https://developer.android.com/jetpack).

# Contribution Guide

For contributions via GitHub, see the [GitHub Contribution Guide](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/CONTRIBUTING.md).

Note: The contributions workflow via GitHub is currently experimental - only contributions to the following projects are being accepted at this time:
* [Activity](activity)
* [AppCompat](appcompat)
* [Biometric](biometric)
* [Collection](collection)
* [Compose Compiler](compose/compiler)
* [Compose Runtime](compose/runtime)
* [Core](core)
* [DataStore](datastore)
* [Fragment](fragment)
* [Lifecycle](lifecycle)
* [Navigation](navigation)
* [Paging](paging)
* [Room](room)
* [WorkManager](work)

## Code Review Etiquette
When contributing to Jetpack, follow the [code review etiquette](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/code-review.md).

## Accepted Types of Contributions
* Bug fixes - needs a corresponding bug report in the [Android Issue Tracker](https://issuetracker.google.com/issues/new?component=192731&template=842428)
* Each bug fix is expected to come with tests
* Fixing spelling errors
* Updating documentation
* Adding new tests to the area that is not currently covered by tests
* New features to existing libraries if the feature request bug has been approved by an AndroidX team member.

We **are not** currently accepting new modules.

## Checking Out the Code

Head over to the [onboarding docs](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/docs/onboarding.md) to learn more about getting set up and the
development workflow!

### Continuous integration
[Our continuous integration system](https://ci.android.com/builds/branches/aosp-androidx-main/grid?) builds all in progress (and potentially unstable) libraries as new changes are merged. You can manually download these AARs and JARs for your experimentation.

## Password and Contributor Agreement before making a change
Before uploading your first contribution, you will need setup a password and agree to the contribution agreement:

Generate a HTTPS password:
https://android-review.googlesource.com/new-password

Agree to the Google Contributor Licenses Agreement:
https://android-review.googlesource.com/settings/new-agreement

## Getting reviewed
* After you run repo upload, open [r.android.com](http://r.android.com)
* Sign in into your account (or create one if you do not have one yet)
* Add an appropriate reviewer (use git log to find who did most modifications on the file you are fixing or check the OWNERS file in the project's directory)

## Handling binary dependencies
AndroidX uses git to store all the binary Gradle dependencies. They are stored in `prebuilts/androidx/internal` and `prebuilts/androidx/external` directories in your checkout. All the dependencies in these directories are also available from `google()`, or `mavenCentral()`. We store copies of these dependencies to have hermetic builds. You can pull in [a new dependency using our importMaven tool](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/development/importMaven/README.md).



## Publish

Configure your remote maven in `gradle.properties`.
```
maven.remote.url=https:xxx
maven.remote.username=xxx
maven.remote.password=xxx
```
Publish artifacts to remote or local maven, see [MULTIPLATFORM.md](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/MULTIPLATFORM.md) for more details.
```
./gradlew :mpp:publishComposeJb -Pcompose.platforms=android,ohosArm64,uikit
./gradlew :mpp:publishComposeJbToMavenLocal -Pcompose.platforms=android,ohosArm64,uikit
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---