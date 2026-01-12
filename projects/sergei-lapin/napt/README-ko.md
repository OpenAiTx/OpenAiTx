# ⚠️ 이 저장소는 보관 처리되었습니다. 주석 처리 설정을 KSP로 마이그레이션하는 것을 고려하세요. ⚠️

# NAPT

[![Plugin](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## 이것이 무엇인가?

스텁 생성 단계를 건너뛰어 최대 50% 더 빠르게 실행되는 KAPT의 대안

## 사용법

*이 특정 도구 세트를 실행하려면 JDK 9 이상이 필요합니다*

적용 후에는 Kotlin 코드에서 생성된 코드를 더 이상 참조할 수 없으므로,
Kotlin 소스에서 Java 생성 코드를 참조하려면 Java `bridge` 클래스를 작성해야 합니다.

예를 들어, 다음과 같은 Kotlin Dagger 2 컴포넌트가 있다고 가정합니다:

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```
그런 다음, 생성된 컴포넌트를 Kotlin 코드에서 참조하기 위해서는 다음과 같이 생긴 Java `bridge`를 작성해야 합니다:



``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```
이제 원하시는 곳 어디에서든 Kotlin 코드에서 이 `bridge`를 쉽게 참조할 수 있습니다.

## 예제

[샘플](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle)에서 사용 예제를 확인할 수 있습니다.

## 다운로드

- javac 플러그인은 Maven Central을 통해 배포됩니다.
- Gradle 플러그인은 Gradle Plugin Portal을 통해 배포됩니다.

#### 플러그인 추가

기존의 것을 제거하세요.


``` Gradle
plugins {
    kotlin("kapt")
}
```
그리고 그것을 교체합니다


``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```
그런 다음 모든 것을 교체할 수 있습니다


``` Gradle
dependencies {
    kapt("some dependency")
}
```
와 함께


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```

그게 다입니다. 주석 처리 속도가 약 50% 빨라진 것을 즐기세요.

#### 충돌하는 NaptTrigger 클래스들

기본적으로 Gradle 플러그인은 모듈 이름을 따르는 패키지로 NaptTrigger를 생성하므로 FQ 이름이 충돌하지 않지만, 만약을 위해 NaptTrigger 패키지의 접두사를 다음과 같이 지정할 수 있습니다:


``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```

`sample`이라는 모듈에 있다고 가정하면, 다음과 같은 `NaptTrigger.java`가 생성됩니다:

``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### NaptTrigger 생성 비활성화

`NaptTrigger.java` 생성은 (예: 모듈에 이미 자바 소스가 있는 경우) 해당 속성을 `false`로 설정하여 비활성화할 수 있습니다:


``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```

#### Java 컴파일러에 사용자 지정 JVM 인수 공급

napt가 작동하려면 Java 컴파일은 `com.slapin.napt.JvmArgsStrongEncapsulation`에 정의된 인수와 함께 분기된 프로세스에서 실행됩니다.  
이 인수는 `napt` 확장에 해당 속성을 설정하여 확장할 수 있습니다.


``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```

#### 추가 소스 세트 내에서 NaptTrigger 생성하기

때때로 추가 소스 세트(예: `test`)에서 애노테이션 처리를 트리거해야 할 때가 있습니다.  
이런 경우 `napt` 확장에 있는 해당 속성을 사용할 수 있습니다:  

``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---