# ResChiper

<h1 align="center">
  <img src="https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/reschiper-banner.png" alt="failed to load artifacts/logo.png"/>
  <p align="center" style="font-size: 0.3em">AAB 资源混淆工具</p>
</h1>

[![License](https://img.shields.io/badge/license-Apache_2.0-maroon)](LICENSE)
![Android Gradle Plugin](https://img.shields.io/badge/Dependency-AGP/8.8.0-4CAF50)
[![BundleTool](https://img.shields.io/badge/Dependency-Bundletool/1.17.2-red)](https://github.com/google/bundletool)
![JDK Version](https://img.shields.io/badge/JDK-17-blue)
![Gradle Version](https://img.shields.io/badge/Gradle_Wrapper-8.8-darkgreen)
[![ResChiper Version](https://img.shields.io/badge/release-0.1.0--rc6-%23C6782A.svg?style=flat)](https://github.com/goldfish07/ResChiper/releases/tag/0.1.0-rc6)

## 目录

- [介绍](#introduction)
- [快速开始](#getting-started)
    - [要求](#requirements)
    - [安装](#installation)
    - [使用](#usage)
- [配置选项](#configuration-options)
- [示例](#example)
- [白名单](#whitelist)
- [输出](#output)
- [致谢](#acknowledgments)
- [许可证](#license)

## 介绍

ResChiper 是一款用于混淆 Android AAB 资源的工具。
它可以保护您的资源免受未经授权的访问，并减少您的应用 AAB 大小。

## 快速开始

按照以下步骤将 AAB 资源混淆工具集成到您的 Android 项目中：

## 要求

在开始使用 ResChiper 之前，请确保您的应用满足以下要求：
- **Java 开发工具包（JDK）**：ResChiper 需要 JDK 17，确保您的应用配置了 JDK 17。  
- **Android Gradle 插件（AGP）**：版本 8.0 或更高版本。

## 安装

#### 1. 添加 ResChiper Gradle 插件

在您项目根目录下的 `build.gradle` 文件中，添加 ResChiper Gradle 插件到 `buildscript` 部分：


```gradle
buildscript {
  dependencies {
    classpath "io.github.goldfish07.reschiper:plugin:<latest_version>"
  }
  
  repositories {
    mavenCentral()
    google()
   }
}
```

#### 2. 应用插件

在你的应用级 `build.gradle` 文件中，应用 ResChiper 插件：

```gradle
apply plugin: "io.github.goldfish07.reschiper"
```

#### 3. 配置插件

在你的 `app/build.gradle` 文件中，通过指定所需的设置来配置 ResChiper 插件。以下是一个示例
配置：

```gradle
resChiper {
    enableObfuscation = true //by default res obfuscate is enabled
    obfuscationMode = "default" //["dir", "file", "default"]
    obfuscatedBundleName = "reschiper-app.aab" // Obfuscated file name, must end with '.aab'
    //mappingFile = file("path/to/your/mapping.txt").toPath() // Mapping file used for incremental obfuscation
    whiteList = [
                  //Whitelist rule (directory name to exclude)
                  "res/raw", // raw dir will not be obfuscated
                  "res/xml", // xml dir will not be obfuscated

                  //Whitelist rule (file name to exclude)
                  "res/raw/*", // all files inside raw directory will not be obfuscated
                  "res/raw/success_tick.json", // success_tick.json file will not be obfuscated
                  "res/xml/*", // all files inside xml directory will not be obfuscated

                  // White list rules (resource name to exclude)
                  "*.R.raw.*",
                  "*.R.xml.*",

                  // for google-services
                  "*.R.string.google_api_key",
                  "*.R.string.google_app_id",
                  "*.R.string.default_web_client_id",
                  "*.R.string.gcm_defaultSenderId",
                  "*.R.string.ga_trackingId",
                  "*.R.string.firebase_database_url",
                  "*.R.string.google_crash_reporting_api_key",
                  "*.R.string.google_storage_bucket",
                  "*.R.integer.google_play_services_version",
                  
                  //firebase
                  "*.R.string.project_id",
                  //firebase crashlytics
                  "*.R.string.com.google.firebase.crashlytics.mapping_file_id",
                  "*.R.bool.com.crashlytics.useFirebaseAppId",
                  "*.R.string.com.crashlytics.useFirebaseAppId",
                  "*.R.string.google_app_id",
                  "*.R.bool.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.string.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.bool.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.ApiEndpoint",
                  "*.R.string.com.crashlytics.android.build_id",
                  "*.R.bool.com.crashlytics.RequireBuildId",
                  "*.R.string.com.crashlytics.RequireBuildId",
                  "*.R.bool.com.crashlytics.CollectCustomLogs",
                  "*.R.string.com.crashlytics.CollectCustomLogs",
                  "*.R.bool.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.CollectCustomKeys"
    ]
    mergeDuplicateResources = true // allow the merge of duplicate resources
    enableFileFiltering = true
    enableFilterStrings = true
    fileFilterList = [ // file filter rules
                         "META-INF/*",
//                       "*/armeabi-v7a/*",
//                       "*/arm64-v8a/*",
//                       "*/x86/*",
//                       "*/x86_64/*"
    ]
    unusedStringFile = "path/to/your/unused_strings.txt" // strings will be filtered in this file
    localeWhiteList = ["en", "in", "fr"] //keep en,en-xx,in,in-xx,fr,fr-xx and remove others locale.
}
```

## 使用方法

要混淆您的资源并生成混淆的 AAB，请在项目根目录下运行以下 Gradle 命令。:


```cmd
./gradle clean :app:resChiperDebug --stacktrace
```
此命令将在项目根目录执行混淆过程，混淆后的 AAB 将生成在  
`app/build/outputs/bundle/debug` 目录中。

## 配置选项

ResChiper 扩展提供了各种资源混淆的配置选项，包括启用/禁用混淆、指定映射文件、资源白名单等。

- `enableObfuscation`：启用或禁用资源混淆。<br>
- `obfuscationMode`：设置为 `obfuscationMode = "dir"` 仅混淆目录，设置为 `obfuscationMode = "file"` 仅混淆文件，设置为 `obfuscationMode = "default"` 混淆目录和文件。<br>
- `enableFilterStrings`：按行输入未使用的文件拆分以支持移除字符串。<br>
- `enableFileFiltering`：支持过滤 bundle 包中的文件，目前仅支持过滤 `META-INFO/` 和 `lib/` 路径。<br>
- `obfuscatedBundleName`：混淆后 AAB 文件的名称。<br>
- `mergeDuplicateResources`：消除重复资源文件，减小包体积。<br>
- `mappingFile`：ProGuard 映射文件路径（仅在使用 mapping.txt 进行混淆时设置）。<br>
- `whiteList`：排除混淆的资源名称集合。<br>
- `fileFilterList`：过滤文件模式列表。<br>
- `unusedStringFile`：包含未使用字符串的文件路径。<br>
- `localeWhiteList`：包含在 AAB 中的本地化语言集合。

## 示例

你可以在[这里](https://github.com/goldfish07/ResChiper/wiki/Example-Configuration-Options)查看一些配置示例。

## 白名单

构建过程中不进行混淆的资源。<br>  
你可以在[这里](https://github.com/goldfish07/ResChiper/wiki/WhiteList)找到 whiteList 配置。

## 输出

运行混淆过程后，你可以获得以下输出文件：

- **aab：** 这是混淆后的 bundle 包，包含混淆资源的 Android 应用包（AAB）。  
- **resources-mapping.txt：** 该文件包含资源混淆映射，可用作未来混淆过程的输入，实现增量混淆。这在你想保持






  不同构建之间的一致性。
- **-duplicated.txt：** 此日志文件提供有关合并资源的信息。它帮助您识别和跟踪混淆过程中合并的任何重复资源。

运行 ResChiper 工具后，将生成这些输出文件，您可以在项目构建输出的相关目录中找到它们。

## 致谢

ResChiper 灵感来源于以下项目和工具：

* [AabResGuard](https://github.com/bytedance/AabResGuard/)
* [AndResGuard](https://github.com/shwenzhang/AndResGuard/)
* [BundleTool](https://github.com/google/bundletool)

## 许可证

[![Apache License v2.0 logo](https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/apache-licence-logo.png)](https://www.apache.org/licenses/LICENSE-2.0.txt)

    版权所有 (C) 2023 goldfish07 (Ayush Bisht) <ayushbisht5663@gmail.com>
    本文件是 ResChiper 的一部分。

    ResChiper 是自由软件：您可以在 Apache 软件基金会发布的 Apache 许可证版本 2.0 条款下重新分发和/或修改它，
    许可证版本为 2.0 或（由您选择）任何更高版本。

    根据 Apache 许可证版本 2.0（“许可证”）授权；
    除非符合许可证要求，否则您不得使用此文件。
    您可以从以下地址获取许可证副本：

        http://www.apache.org/licenses/LICENSE-2.0

    除非适用法律要求或书面同意，否则根据许可证分发的软件按“原样”提供，
    不附带任何明示或暗示的保证或条件。
    有关权限和限制的具体条款，请参阅许可证。







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---