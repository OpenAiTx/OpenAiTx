
# pods4k

[![Maven Central][maven-central-badge]][maven-central-url]
[![Licence][license-badge]][license-url]
![Top language][top-language-badge]
![Build Status][build-status-badge]
[![Stargazers][stars-badge]][stars-url]

## Kotlin을 위한 성능 지향 데이터 구조

처음 보기에는 불가능해 보일 수 있는 성능과 효율성을 제공하는 성능 지향 데이터 구조 모음입니다.

이 라이브러리가 유용하다고 생각되면, 
[![GitHub stars](https://img.shields.io/github/stars/daniel-rusu/pods4k?label=Star)](https://github.com/daniel-rusu/pods4k)
[GitHub](https://github.com/daniel-rusu/pods4k)에서 별점을 주고 다른 사람들과 공유해 주세요.

## 설치

[![Latest Version][latest-version-shield]][maven-central-url] Maven Central에서 사용 가능:

**Gradle:**


```kotlin
repositories {
    mavenCentral()
}
dependencies {
    implementation("com.danrusu.pods4k:pods4k:<latest_version>")
}
```
**Maven:**


```xml

<dependency>
    <groupId>com.danrusu.pods4k</groupId>
    <artifactId>pods4k</artifactId>
    <version>latest_version</version>
</dependency>
```
또는 이 라이브러리의 개별 구성 요소를 [선택하여 사용할 수 있습니다](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/publishing/bom/README.md).

## 불변 배열

[불변 배열](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md)은
익숙한 문법을 유지하면서 리스트보다 더 안전하고 빠르며 효율적인 대안을 제공합니다.

#### 주요 이점

* ![빠름][fast-shield] 대부분의 작업에서 [리스트보다 2배에서 8배 빠름](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/BENCHMARKS.md).
* ![효율적][efficient-shield] 많은 일반적인 시나리오에서 [4배 이상의 메모리 절감](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md#-efficiency).
* ![불변][immutable-shield] 캐스팅을 통해서도 수정할 수 없습니다.
* ![타입 안전][type-safe-shield] 컴파일 시 의도치 않은 변경 시도를 방지합니다.
* ![효율적 빌더][efficient-builders-shield] 가변 리스트보다 더 효율적으로 요소를 모읍니다.

#### 직관적인 리스트와 같은 문법



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
다음 세부 사항과 일반 배열, 읽기 전용 리스트 및 불변 리스트와의 자세한 비교는 [Immutable Arrays](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md)를 참조하세요.

## 최소 요구 사항

* Kotlin 1.9.25
    * 이 라이브러리는 Kotlin 2.1 등을 사용하는 다른 프로젝트에서 사용되므로 K2와 호환됩니다.
* JDK 11
    * 자동화된 테스트는 JDK LTS 릴리스 11, 17, 21에서 실행됩니다.

## Java 호환성

일부 데이터 구조는 Kotlin 컴파일러에서만 지원되는 기술을 사용합니다. 이러한 데이터 구조 중 하나를 Java에서 정의된 컬렉션에 저장하기 위해 Java와 Kotlin 혼합 코드베이스에서 사용할 수는 있지만, 이 데이터 구조들을 클래스 이름으로 참조하는 것은 Kotlin 파일 내에서만 지원됩니다.


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