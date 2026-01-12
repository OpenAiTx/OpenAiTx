# ⚠️ 本仓库已归档。请考虑将您的注解处理设置迁移到 KSP。⚠️

# NAPT

[![插件](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![许可证](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## 它是什么？

KAPT 的替代方案，跳过存根生成，因此运行速度快最多可达 50%

## 使用方法

*运行这套工具需要 JDK 9 及以上版本*

一旦应用，您将无法在 Kotlin 代码中引用生成的代码，因此您需要编写 Java `桥接` 类
以便在 Kotlin 源码中引用 Java 生成的代码。

例如，假设我们有以下 Kotlin Dagger 2 组件：

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```

然后，为了从 Kotlin 代码中引用生成的组件，我们必须编写如下所示的 Java `桥接`：  
这样：

``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```
就是这样，现在你可以在你的 Kotlin 代码中随时轻松引用这个 `bridge`

## 示例

你可以在 [sample](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle) 中看到一个使用示例

## 下载

- javac 插件通过 Maven Central 分发
- Gradle 插件通过 Gradle Plugin Portal 分发

#### 添加插件

移除你旧的


``` Gradle
plugins {
    kotlin("kapt")
}
```
并将其替换为


``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```

然后你可以替换所有你的

``` Gradle
dependencies {
    kapt("some dependency")
}
```
与


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```
就是这样。享受注解处理速度提升约50%的快感。

#### 冲突的 NaptTrigger 类

默认情况下，Gradle 插件会生成带有模块名包的 NaptTrigger，因此完全限定名不会冲突，但以防万一，NaptTrigger 包的前缀可以这样指定：



``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```
假设我们在名为 `sample` 的模块中，将生成以下 `NaptTrigger.java`：


``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### 禁用 NaptTrigger 生成

可以通过将相应属性设置为 `false` 来禁用 `NaptTrigger.java` 的生成（例如，当模块中已经有了 Java 源代码时）：


``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```

#### 向 Java 编译器提供自定义 JVM 参数

为了使 napt 正常工作，Java 编译在带有由 `com.slapin.napt.JvmArgsStrongEncapsulation` 定义的参数的分叉进程中运行。  
这些参数可以通过在 `napt` 扩展中设置相应属性来扩展。


``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```
#### 在额外的源集内生成 NaptTrigger

有时您可能需要在额外的源集中触发注解处理（例如 `test`）。
在这种情况下，您可以使用 `napt` 扩展中的相应属性：


``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---