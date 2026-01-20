[![Maven Central](https://img.shields.io/maven-central/v/dev.kotbase/couchbase-lite)](
https://central.sonatype.com/namespace/dev.kotbase)
[![Kotlin](https://img.shields.io/badge/kotlin-2.2.20-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![GitHub License](https://img.shields.io/github/license/jeffdgr8/kotbase)](LICENSE)
[![Couchbase Community](https://img.shields.io/badge/couchbase-community-ea2328?logo=couchbase&logoColor=ea2328)](
https://www.couchbase.com/developers/community/)
[![Slack Channel](https://img.shields.io/badge/chat-%23couchbase-4a154b.svg?logo=slack)](
https://kotlinlang.slack.com/messages/couchbase/)

# Kotbase

**Kot**lin 多平台 Couch**base** Lite 库

## 介绍

Kotbase 将 [Kotlin 多平台](https://www.jetbrains.com/kotlin-multiplatform/) 与嵌入式 NoSQL JSON 文档数据库 [Couchbase Lite](
https://www.couchbase.com/products/lite/) 配对使用。Couchbase Lite 可以用作独立的客户端数据库，或与 [Couchbase Server](https://www.couchbase.com/products/server/) 和 [Sync
Gateway](https://www.couchbase.com/products/sync-gateway/) 或 [Capella 应用服务](
https://www.couchbase.com/products/capella/app-services/) 配合，实现云端到边缘的数据同步。功能包括：

* [SQL++](https://www.couchbase.com/products/n1ql/)、键/值、全文搜索和向量搜索查询
* 可观察的查询、文档、数据库和复制器
* 二进制文档附件（Blob）
* 点对点及云到边缘的数据同步

Kotbase 为 Android 和 JVM（[通过 Java SDK](
https://github.com/couchbase/couchbase-lite-java-ce-root)）、原生 iOS 和 macOS（[通过 Objective-C SDK](
https://github.com/couchbase/couchbase-lite-ios)）提供完整的企业版和社区版 API 支持，并对原生 Linux 和 Windows（[通过 C SDK](
https://github.com/couchbase/couchbase-lite-C)）提供实验性支持。

## 安装

在共享模块的 **build.gradle.kts** 的 **commonMain** 源集依赖中添加社区版或企业版依赖：



```kotlin
kotlin {
    sourceSets {
        commonMain.dependencies {
            // Community Edition
            implementation("dev.kotbase:couchbase-lite:3.2.4-1.2.0")
            // or Enterprise Edition
            implementation("dev.kotbase:couchbase-lite-ee:3.2.4-1.2.0")
        }
    }
}
```

> **注意**
> Couchbase Lite 社区版是免费且开源的。企业版在开发和测试阶段免费使用，
> 但生产环境使用需要从 [Couchbase](https://www.couchbase.com/pricing/#couchbase-mobile) 获取许可证。
> [参见社区版与企业版对比。](https://www.couchbase.com/products/editions/mobile/)

Kotbase 已发布到 Maven Central。Couchbase Lite 企业版依赖项还需要
Couchbase Maven 仓库。

```kotlin
repositories {
    mavenCentral()
    maven("https://mobile.maven.couchbase.com/maven2/dev/")
}
```
### 原生平台

原生平台目标还应链接到 Couchbase Lite 依赖的原生二进制文件。详情请参见 [支持的平台](https://kotbase.dev/current/platforms/)。

### Linux

针对运行在 Linux 上的 JVM 或原生 Linux，均需要特定版本的 libicu 依赖。（如果出现类似
`libLiteCore.so: libicuuc.so.71: cannot open shared object file: No such file or directory` 的错误，表示所需版本未找到。）  
如果您的发行版包管理器中没有该版本，可以从 [GitHub](https://github.com/unicode-org/icu/releases) 下载。

## 文档

Kotbase 文档可在 [kotbase.dev](https://kotbase.dev/) 查阅，包括 [入门示例](https://kotbase.dev/current/getting-started/)、[使用指南](https://kotbase.dev/current/databases/) 和 [API 参考](https://kotbase.dev/api/)。

## 与 Java SDK 的差异

Kotbase 的 API 与 Couchbase Lite 的 [Java](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/java/quickstart.html) 和 [Android KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/android/quickstart.html) SDK 保持一致。迁移现有 Kotlin 代码通常只需将导入包从 `com.couchbase.lite` 改为 `kotbase`，但有些例外：

* Java 回调函数接口被实现为 Kotlin 函数类型。
* `File`、`URL` 和 `URI` API 使用字符串表示。
* `Date` API 使用 Kotlin 的 `Instant`。
* `InputStream` API 使用 [kotlinx-io 的 `Source`](https://kotlinlang.org/api/kotlinx-io/kotlinx-io-core/kotlinx.io/-source/)。
* `Executor` API 使用 Kotlin 的 `CoroutineContext`。
* 证书 API 以原始 `ByteArray` 或平台特定代码形式提供。
* 无需显式调用 `CouchbaseLite.init()`。JVM 和 Android 平台代码中仍可用自定义参数调用初始化函数。
* 已努力检测并抛出 Kotlin 异常以处理常见错误，但在苹果平台上仍可能泄漏 `NSError`。  
  [请报告](https://github.com/jeffdgr8/kotbase/issues/new) 任何需要处理的情况。
* 一些已弃用的 API 被省略。
* 虽然 Java SDK 不支持操作符重载，因此不可用，但 [`Fragment` 下标 API](









  https://kotbase.dev/current/kotlin-extensions/#fragment-subscripts) 在 Kotbase 中可用，类似于 [Swift](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-swift/Classes/Fragment.html)、[Objective-C](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-objc/Protocols/CBLFragment.html) 和 [.NET](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-net/api/Couchbase.Lite.IFragment.html)。
* Android KTX SDK 的配置工厂 API 已被弃用，建议直接使用构造函数，
  它们本身支持 Kotlin 命名参数。

## 扩展库

Kotbase 在 Couchbase Lite 官方 API 之上包含了一些方便的扩展，作为附加的库构件。

### Kotbase KTX

[KTX 扩展](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-ktx/README.md) 包含了优秀的 [MOLO17 的 Kotlin 扩展](https://github.com/MOLO17/couchbase-lite-kotlin)，
以及用于组合查询、映射查询结果、创建文档和观察变更 `Flow` 的其他便利函数。

#### 安装


```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-ktx:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-ktx:3.2.4-1.2.0")
```

### Kotbase Kermit

[Kotbase Kermit](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-kermit/README.md) 是一个 Couchbase Lite 自定义日志记录器，日志记录到 [Kermit](https://kermit.touchlab.co/)。Kermit 可以将日志输出到多个日志目标，包括控制台。

#### 安装


```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-kermit:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-kermit:3.2.4-1.2.0")
```

### Kotbase 分页

[paging 扩展](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-paging/README.md) 基于 Google 的 [AndroidX Paging](
https://developer.android.com/topic/libraries/architecture/paging/v3-overview) 构建。Kotbase 分页提供了一个
[`PagingSource`](https://developer.android.com/reference/kotlin/androidx/paging/PagingSource)，它基于用户提供的数据库查询执行
limit/offset 分页查询。

#### 安装

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-paging:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-paging:3.2.4-1.2.0")
```

## 路线图

* [x] 文档网站 ([kotbase.dev](https://kotbase.dev/))
* [x] `NSInputStream` 互操作 ~~(Okio [#1123](https://github.com/square/okio/pull/1123))~~ (kotlinx-io [#174](
  https://github.com/Kotlin/kotlinx-io/pull/174))
* [x] Linux ARM64 支持
* [x] 公开发布
* [ ] 示例应用
    * [x] [入门指南](examples/getting-started)
    * [x] [入门指南 Compose 多平台](examples/getting-started-compose)
    * [x] [Kotbase 笔记](examples/kotbase-notes)
    * [ ] Kotbase 笔记的 SwiftUI
* [x] Couchbase Lite [3.1 API](https://docs.couchbase.com/couchbase-lite/3.1/cbl-whatsnew.html) - 范围和集合
* [x] 版本化文档
* [x] Couchbase Lite [3.2 API](https://docs.couchbase.com/couchbase-lite/3.2/cbl-whatsnew.html) - [向量搜索](
  https://www.couchbase.com/products/vector-search/)
* [ ] Couchbase Lite [3.3 API](https://docs.couchbase.com/couchbase-lite/3.3/cbl-whatsnew.html) - 多点复制器
* [ ] Couchbase Lite [4.0 API](https://docs.couchbase.com/couchbase-lite/4.0/cbl-whatsnew.html) - 版本向量
* [ ] Linux 和 MinGW 平台上的 URLEndpointListener
* [ ] 通过 [Swift 导出](https://youtrack.jetbrains.com/issue/KT-64572)、`@ObjCName` 和/或 `@ShouldRefineInSwift` 改善 Swift API 与 Couchbase Lite 的一致性
* [ ] 异步协程 API

## 开发

* 在 Linux 上构建项目时，请确保安装 libicu 依赖。
* 在 Windows 上检出 git 仓库时，启用 [开发者模式](
  https://learn.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development) 并使用 `git config --global core.symlinks true` 启用 git 中的符号链接。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---