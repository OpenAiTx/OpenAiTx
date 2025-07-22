<translate-content># pods4k

[![Maven Central][maven-central-badge]][maven-central-url]
[![Licence][license-badge]][license-url]
![Top language][top-language-badge]
![Build Status][build-status-badge]
[![Stargazers][stars-badge]][stars-url]

## 面向性能的 Kotlin 数据结构

一组面向性能的数据结构，提供乍看之下似乎不可能实现的性能和效率。

如果您觉得这个库有用，请考虑在
[GitHub](https://github.com/daniel-rusu/pods4k)上给它
一个[![GitHub stars](https://img.shields.io/github/stars/daniel-rusu/pods4k?label=Star)](https://github.com/daniel-rusu/pods4k)的星标并分享给他人。

## 安装

[![最新版本][latest-version-shield]][maven-central-url] 可在 Maven Central 获取：

**Gradle:**


```kotlin
repositories {
    mavenCentral()
}
dependencies {
    implementation("com.danrusu.pods4k:pods4k:<latest_version>")
}
```
<translate-content>
**Maven：**
</translate-content>
```xml

<dependency>
    <groupId>com.danrusu.pods4k</groupId>
    <artifactId>pods4k</artifactId>
    <version>latest_version</version>
</dependency>
```
或者，您可以[选择和挑选](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/publishing/bom/README.md)该库的单个组件。

## 不可变数组

[不可变数组](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md)提供了一种更安全、更快速且更高效的列表替代方案，同时
保持了熟悉的语法。

#### 主要优点

* ![快速][fast-shield] 对大多数操作而言，[比列表快2到8倍](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/BENCHMARKS.md)。
* ![高效][efficient-shield] 在许多常见场景中，[内存减少超过4倍](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md#-efficiency)。
* ![不可变][immutable-shield] 不能被修改，即使使用强制转换。
* ![类型安全][type-safe-shield] 在编译时防止意外的变异尝试。
* ![高效构建器][efficient-builders-shield] 比可变列表更高效地收集元素。

#### 直观的类似列表语法



```kotlin
val people = immutableArrayOf(dan, jill, bobby)

// Iterate naturally
for (person in people) {
    sendMarketingEmailTo(person)
}
// All the usual operations
val employedPeople = people.filter { it.isEmployed() }
val salaries = employedPeople.map { it.salary }
```
参见 [不可变数组](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md) 了解更多细节，以及与普通数组、只读列表和不可变列表的详细比较。

## 最低要求

* Kotlin 1.9.25
    * 该库兼容 K2，因为它被用于其他使用 Kotlin 2.1 等版本的项目。
* JDK 11
    * 自动化测试在 JDK LTS 版本 11、17 和 21 上运行。

## Java 兼容性

某些数据结构使用的技术仅受 Kotlin 编译器支持。虽然它们可以在混合的 Java 和 Kotlin 代码库中使用，以在 Java 定义的集合中存储这些数据结构之一，但通过类名引用这些数据结构仅在 Kotlin 文件中受支持。


[maven-central-badge]: https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fdaniel-rusu%2Fpods4k%2Frefs%2Fheads%2Fmain%2Flatest_version.json&query=version&style=for-the-badge&label=maven-central&color=orange

[license-badge]: https://img.shields.io/github/license/daniel-rusu/pods4k?style=for-the-badge

[top-language-badge]: https://img.shields.io/github/languages/top/daniel-rusu/pods4k?style=for-the-badge

[build-status-badge]: https://img.shields.io/github/actions/workflow/status/daniel-rusu/pods4k/ci.yml?style=for-the-badge&label=CI

[stars-badge]: https://img.shields.io/github/stars/daniel-rusu/pods4k?style=for-the-badge


[fast-shield]: https://img.shields.io/badge/Blazing_Fast-blue

[efficient-shield]: https://img.shields.io/badge/Memory_Efficient-blue

[immutable-shield]: https://img.shields.io/badge/True_Immutability-blue

[type-safe-shield]: https://img.shields.io/badge/Type_Safety-blue

[efficient-builders-shield]: https://img.shields.io/badge/Efficient_Builders-blue

[github-stars-shield]: https://img.shields.io/github/stars/daniel-rusu/pods4k?label=Star

[latest-version-shield]: https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fdaniel-rusu%2Fpods4k%2Frefs%2Fheads%2Fmain%2Flatest_version.json&query=version&label=Latest%20Version&color=orange


[stars-url]: https://github.com/daniel-rusu/pods4k/stargazers

[maven-central-url]: https://central.sonatype.com/artifact/com.danrusu.pods4k/pods4k

[license-url]: https://github.com/daniel-rusu/pods4k/blob/main/LICENSE





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---