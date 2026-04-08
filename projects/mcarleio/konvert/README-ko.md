# Konvert

[![Maven Central][maven-image]][maven-url]
[![License][license-image]](LICENSE)
[![Code Coverage][codecov-image]][codecov-url]

이것은 [Kotlin Symbol Processing (KSP)](https://github.com/google/ksp)를 사용하는 Kotlin 매핑 코드 생성기인 Konvert입니다.
Kotlin과 그 기능을 위해 특별히 설계되었으며, Konvert는 다양한 사용 사례를 지원합니다.

주요 기능:
* 🧩 **다양한 클래스 종류** 지원 → `data`, `enum`, `value`, 일반 POJO
* 🔄 기본적으로 **널 안전성(Null-safe)**
* ⚙️ **스마트 변환** (`Int` → `String`, `Instant` → `Date`, …)
   * 🔧 `@Konverter`로 **재사용 가능한 변환기** 정의
   * 🔌 궁극적인 제어를 위한 **SPI 확장**
* 🔗 **컬렉션 및 맵** — 요소 매핑 포함
* 🛠️ **세밀한** 속성 매핑 커스터마이징
* ☕ 100% **Java 상호 운용성**
* ✨ **깔끔하고 관용적인 Kotlin** 코드 생성
   * ⏱️ **컴파일 타임**에 생성
   * 🚫 **리플렉션 없음**, **런타임 오버헤드 없음**
* 📦 **Gradle** 및 **Maven**과 원활하게 작동

> ℹ️ 이 README는 기본 개요를 제공하며, 자세한 내용은 [문서](https://mcarleio.github.io/konvert)를 참조하세요.

## 사용법

Konvert를 사용하는 세 가지 방법이 있습니다:

1. `@KonvertTo` 사용:
   ```kotlin
   @KonvertTo(PersonDto::class)
   data class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)
   ```
   이는 다음과 같은 확장 함수를 생성합니다
   ```kotlin
   fun Person.toPersonDto(): PersonDto =
      PersonDto(firstName = firstName, lastName = lastName)
   ```

2. `@KonvertFrom` 사용하기 (특히 소스 클래스의 코드를 변경할 수 없을 때 유용)
   ```kotlin
   class Person(val firstName: String, val lastName: String) {
      @KonvertFrom(PersonDto::class)
      companion object
   }
   class PersonDto(val firstName: String, val lastName: String)
   ```
   이것은 다음과 같은 확장 함수를 생성합니다
   ```kotlin
   fun Person.Companion.fromPersonDto(personDto: PersonDto): Person =
      Person(firstName = personDto.firstName, lastName = personDto.lastName)
   ```

3. `@Konverter` 사용:
   ```kotlin
   class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)

   @Konverter
   interface PersonMapper {
      fun toDto(person: Person): PersonDto
   }
   ```
   이것은 다음 객체를 생성합니다
   ```kotlin
   object PersonMapperImpl: PersonMapper {
      override fun toDto(person: Person): PersonDto
         = PersonDto(firstName = person.firstName, lastName = person.lastName)
   }
   ```
간단한 예제 프로젝트는 [example 디렉터리](example)를 참조하세요.

### 타입 매핑

`Instant`에서 `Date`로와 같은 간단한 타입 매핑의 경우, Konvert에 이미 제공된 타입 변환기가 있습니다:

```kotlin
@KonvertTo(PersonDto::class)
class Person(val name: String, val birthday: Instant)
class PersonDto(val name: String, val birthday: Date)
```
이것은 다음 확장 함수를 생성합니다


```kotlin
fun Person.toPersonDto(): PersonDto = PersonDto(
   name = name,
   birthday = birthday.let { java.util.Date.from(it) }
)
```
[문서](https://mcarleio.github.io/konvert/typeconverter/)에서 제공되는 타입 변환기 목록을 확인하세요.

🛈: 또한 [TypeConverter](https://raw.githubusercontent.com/mcarleio/konvert/main/converter-api/src/main/kotlin/io/mcarle/konvert/converter/api/TypeConverter.kt)를 구현하여
자체 타입 변환기 라이브러리를 만들고 [SPI](https://en.wikipedia.org/wiki/Service_provider_interface)를 사용해 등록할 수 있습니다.

### 미세 조정

대부분의 경우, 소스와 대상 클래스는 동일한 속성 이름과 타입을 가지지 않을 수 있습니다.
특정 매핑을 구성하고 생성된 확장 함수 이름을 다음과 같이 변경할 수 있습니다:



```kotlin
@KonvertTo(
   PersonDto::class,
   mappings = [
      Mapping(source = "firstName", target = "givenName"),
      Mapping(source = "lastName", target = "familyName")
   ],
   mapFunctionName = "asDto"
)
class Person(val firstName: String, val lastName: String)
class PersonDto(val givenName: String, val familyName: String)
```

이것은 다음과 같은 확장 함수를 생성합니다

```kotlin
fun Person.asDto(): PersonDto = PersonDto(
   givenName = firstName,
   familyName = lastName
)
```

추가 기능을 위해서는
[문서](https://mcarleio.github.io/konvert/)
[어노테이션](annotations/src/main/kotlin/io/mcarle/konvert/api)의 KDocs,
[예제 프로젝트](example/src/main/kotlin/io/mcarle/konvert/example)
또는 [테스트](processor/src/test/kotlin/io/mcarle/konvert/processor)를 참고하세요.

## Gradle 설정

Gradle에서 Konvert를 사용하려면 다음 단계를 수행해야 합니다:

1. 어노테이션을 사용하기 위해 `konvert-api`를 의존성에 추가하세요:
   ```kotlin
   dependencies {
      implementation("io.mcarle:konvert-api:$konvertVersion")
   }
   ```
2. KSP 플러그인 추가:

   ```kotlin
   plugins {
       id("com.google.devtools.ksp").version("2.3.5")
   }
   ```

3. `konvert`를 `ksp` 의존성으로 추가합니다:
   ```kotlin
   dependencies {
      ksp("io.mcarle:konvert:$konvertVersion")
   }
   ```

## Maven 설정

Konvert를 Maven과 함께 사용하려면 다음 단계를 수행해야 합니다:

1. 어노테이션을 사용하기 위해 `konvert-api`를 의존성으로 추가합니다:
   ```xml
   <dependency>
       <groupId>io.mcarle</groupId>
       <artifactId>konvert-api</artifactId>
       <version>${konvert.version}</version>
   </dependency>
   ```

2. `konvert`를 의존성으로 사용하여 [ksp-maven-plugin](https://github.com/mcarleio/ksp-maven-plugin)을 사용하세요:
   ```xml
   <plugin>
       <groupId>io.mcarle</groupId>
       <artifactId>ksp-maven-plugin</artifactId>
       <version>2.3.5-1</version>
       <executions>
           <execution>
               <goals>
                   <goal>ksp</goal>
               </goals>
           </execution>
       </executions>
       <dependencies>
           <dependency>
               <groupId>io.mcarle</groupId>
               <artifactId>konvert</artifactId>
               <version>${konvert.version}</version>
           </dependency>
       </dependencies>
   </plugin>
   ```
## 추가 정보

* Konvert는 주로 JDK >=17에서 컴파일 및 테스트됩니다. JDK 17 이하 버전에서도 작동할 수 있지만 보장되지 않습니다.
* Konvert는 Java(및 아마도 다른 JVM 언어)로 작성된 클래스와 클래스 간 변환이 가능합니다.

### 대안

Konvert 대신 사용할 수 있는 몇 가지 대안이 있습니다:

* [Mappie](https://github.com/Mr-Mappie/mappie)

  Mappie는 KSP를 사용하지 않고 Kotlin 자체의 컴파일러 플러그인입니다.
  매핑을 **정의**할 때 문자열 참조가 아닌 리플렉션을 사용하지만,
  컴파일 시 리플렉션 코드를 관용적인 Kotlin 코드로 **대체**합니다.

* [MapStruct](https://mapstruct.org/)

  MapStruct는 주석 프로세싱을 사용하는 잘 알려진 Java 매핑 라이브러리입니다 ([kapt](https://kotlinlang.org/docs/kapt.html) 참고).
  Kotlin 프로젝트에서 사용할 수 있지만 Kotlin 특화 기능은 지원하지 않습니다.

* [kMapper](https://github.com/s0nicyouth/kmapper)

  kMapper도 KSP 프로세서이지만 Kotlin 데이터 클래스 간 매핑만 지원하는 것으로 보입니다.

* [ShapeShift️](https://github.com/krud-dev/shapeshift)

  ShapeShift는 런타임에 리플렉션을 사용하여 클래스 간 매핑을 수행합니다.

* **직접 코딩하기** (AI 지원과 함께)

  때로는 매핑 코드를 수동으로 작성하는 것이 더 빠르고 쉽고 유연할 수 있습니다.
  요즘 AI 도구의 도움으로 이 반복 작업을 어느 정도 자동화할 수 있습니다.


## 빌드

### Gradle

프로젝트를 빌드하려면, 다음 명령을 실행하세요

> gradle build

#### 모든 테스트 실행

기본적으로 사용 가능한 테스트 중 일부만 실행되며, 이는 Konvert의 대부분 기능을 검증합니다.  
모든 테스트를 실행하려면 `runAllTests` 속성을 추가하세요. 예를 들어:

> gradle test -PrunAllTests

### 문서

Jekyll 사이트를 로컬에서 제공하려면 `docs` 폴더 내에서 다음 명령을 실행하세요:

> docker run --rm -it -v "$PWD":/site -p 4000:4000 bretfisher/jekyll-serve

### CI

GitHub Actions는 다음 작업에 사용됩니다:

* [빌드 및 테스트](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/build.yml)
* Maven 저장소에 [릴리스 및 배포](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/release.yml)
* [문서 생성](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/pages.yml) 및 GitHub Pages에 배포

## 변경 로그

[변경 로그](https://raw.githubusercontent.com/mcarleio/konvert/main/CHANGELOG.md)에는 모든 주요 변경 사항이 포함되어 있습니다.

## 라이선스

    저작권 2023 Marcel Carlé

    Apache License, Version 2.0 ("라이선스")에 따라 허가됨
    이 파일을 라이선스 조건에 따르지 않고 사용할 수 없습니다.
    라이선스 사본은 다음에서 확인할 수 있습니다.

    http://www.apache.org/licenses/LICENSE-2.0

    관련 법률에 의해 요구되거나 서면 동의가 없는 한, 
    라이선스에 따라 배포되는 소프트웨어는 "있는 그대로" 제공됩니다.

    명시적이거나 묵시적인 어떠한 보증이나 조건 없이 제공됩니다.
    권한 및 제한 사항에 대해서는 라이선스를 참조하십시오.

[maven-image]: https://img.shields.io/maven-central/v/io.mcarle/konvert.svg

[maven-url]: https://central.sonatype.com/artifact/io.mcarle/konvert/

[license-image]: https://img.shields.io/github/license/mcarleio/konvert.svg

[codecov-image]: https://img.shields.io/codecov/c/github/mcarleio/konvert.svg

[codecov-url]: https://codecov.io/gh/mcarleio/konvert



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---