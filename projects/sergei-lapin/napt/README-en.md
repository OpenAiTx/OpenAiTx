# ⚠️ This repository is archived. Consider migrating your annotation processing setup to KSP. ⚠️

# NAPT

[![Plugin](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## What is it?

An alternative to KAPT that skips stub generation and hence runs up to 50% faster

## Usage

*JDK 9+ is required to run this particular set of tools*

Once applied, you can't reference generated code in Kotlin code anymore, so you'd have to write Java `bridge` classes in
order to reference Java generated code in Kotlin sources.

For example, assume we have the following Kotlin Dagger 2 Component:

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```

then, in order to reference the generated component from Kotlin code we have to write a Java `bridge` that would look like
this:

``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```

That's it, now you can easily reference this `bridge` from your Kotlin code wherever you'd like to

## Sample

You can see an example of usage in [sample](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle)

## Download

- javac plugin is distributed through Maven Central
- Gradle plugin is distributed through Gradle Plugin Portal

#### Add plugin

Remove your old

``` Gradle
plugins {
    kotlin("kapt")
}
```
and replace it with


``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```

then you can replace all of your

``` Gradle
dependencies {
    kapt("some dependency")
}
```
with


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```

That's it. Enjoy the speed-up of your annotation processing by ~50%.

#### Conflicting NaptTrigger classes

By default, the Gradle plugin will generate NaptTrigger with a module-named package so the FQ names won't clash, but, just in
case, the prefix of the NaptTrigger package can be specified like this:

``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```
Assume we're in module named `sample`, will result in the following `NaptTrigger.java`:


``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### Disabling NaptTrigger generation

Generation of `NaptTrigger.java` can be disabled (e.g., when you already have Java sources in your module) by setting
the corresponding property to `false`:

``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```

#### Supplying custom JVM arguments to Java compiler

In order for napt to work, Java compilation runs in a forked process with arguments defined
by `com.slapin.napt.JvmArgsStrongEncapsulation`. These arguments can be extended by setting the corresponding property
in the `napt` extension.

``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```

#### Generating NaptTrigger within additional source sets

Sometimes you might need to trigger annotation processing in additional source sets (e.g. `test`).
In such cases you can use corresponding property from `napt` extension:

``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---