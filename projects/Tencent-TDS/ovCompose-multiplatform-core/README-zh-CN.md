<p align="center">
    <img alt="ovCompose Logo" src="https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/img/ovCompose.svg" />
</p>

### English
ovCompose (online-video-compose) 是腾讯大前端领域Oteam中，腾讯视频团队基于 Compose Multiplatform 生态推出的跨平台开发框架，旨在弥补Jetbrains Compose Multiplatform不支持鸿蒙平台的遗憾与解决iOS平台混排受限的问题，便于业务构建全跨端App。

Learn more about [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_en.md)

### 中文
ovCompose（online-video-compose）是腾讯大前端领域Oteam中，腾讯视频团队基于 Compose Multiplatform 生态推出的跨平台开发框架，旨在弥补Jetbrains Compose Multiplatform不支持鸿蒙平台的遗憾与解决iOS平台混排受限的问题，便于业务构建全跨端App。

详情请见 [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_zh.md)

---
# Android Jetpack

[![Revved up by Gradle Enterprise](https://img.shields.io/badge/Revved%20up%20by-Gradle%20Enterprise-06A0CE?logo=Gradle&labelColor=02303A)](https://ge.androidx.dev)

Jetpack 是一套库、工具和指南，帮助开发者更轻松地编写高质量应用。这些组件帮助你遵循最佳实践，免去编写样板代码的烦恼，并简化复杂任务，让你专注于关心的代码。

Jetpack 包含 `androidx.*` 包库，独立于平台API。这意味着它提供向后兼容性，且更新频率高于Android平台，确保你始终能使用到最新最强大的Jetpack组件版本。

我们的官方AAR和JAR二进制文件通过 [Google Maven](https://maven.google.com) 分发。

你可以从[Android Jetpack主页](https://developer.android.com/jetpack)了解更多使用信息。

# 贡献指南

通过GitHub贡献，请参阅[GitHub贡献指南](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/CONTRIBUTING.md)。

注意：目前通过GitHub的贡献流程处于实验阶段——当前仅接受以下项目的贡献：
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

## 代码审查礼仪
贡献Jetpack时，请遵循[代码审查礼仪](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/code-review.md)。

## 接受的贡献类型
* Bug修复——需在[Android问题追踪器](https://issuetracker.google.com/issues/new?component=192731&template=842428)中有对应的bug报告
* 每个Bug修复都应附带测试
* 修正拼写错误
* 更新文档
* 为当前未覆盖的领域添加新测试
* 如果AndroidX团队成员批准了功能请求bug，可以为现有库添加新功能。

我们**当前不**接受新模块。

## 代码检出

请查看[入门文档](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/docs/onboarding.md)，了解设置及开发流程！

### 持续集成
[我们的持续集成系统](https://ci.android.com/builds/branches/aosp-androidx-main/grid?)会在新变更合并时构建所有进行中的（可能不稳定的）库。你可以手动下载这些AAR和JAR进行试验。

## 在提交修改前设置密码和贡献者协议
上传首个贡献前，你需要设置密码并同意贡献者协议：

生成HTTPS密码：
https://android-review.googlesource.com/new-password

同意Google贡献者许可协议：
https://android-review.googlesource.com/settings/new-agreement

## 获取审核
* 运行repo upload后，打开[r.android.com](http://r.android.com)
* 登录账号（若无账号请先注册）
* 添加合适的审核人（使用git log查找对你修改文件贡献最多的人，或查看项目目录下的OWNERS文件）

## 处理二进制依赖
AndroidX使用git存储所有二进制Gradle依赖，存放于检出代码的`prebuilts/androidx/internal`和`prebuilts/androidx/external`目录。这些依赖也可以从`google()`或`mavenCentral()`获取。我们保存这些依赖副本以保证构建隔离。你可以使用我们的importMaven工具[引入新依赖](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/development/importMaven/README.md)。



## 发布

在 `gradle.properties` 中配置远程maven。

```
maven.remote.url=https:xxx
maven.remote.username=xxx
maven.remote.password=xxx
```
将构件发布到远程或本地 Maven，详情请参见 [MULTIPLATFORM.md](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/MULTIPLATFORM.md)。
```
./gradlew :mpp:publishComposeJb -Pcompose.platforms=android,ohosArm64,uikit
./gradlew :mpp:publishComposeJbToMavenLocal -Pcompose.platforms=android,ohosArm64,uikit
```
<translate-content>
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---