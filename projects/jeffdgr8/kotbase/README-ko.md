[![Maven Central](https://img.shields.io/maven-central/v/dev.kotbase/couchbase-lite)](
https://central.sonatype.com/namespace/dev.kotbase)
[![Kotlin](https://img.shields.io/badge/kotlin-2.2.20-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![GitHub License](https://img.shields.io/github/license/jeffdgr8/kotbase)](LICENSE)
[![Couchbase Community](https://img.shields.io/badge/couchbase-community-ea2328?logo=couchbase&logoColor=ea2328)](
https://www.couchbase.com/developers/community/)
[![Slack Channel](https://img.shields.io/badge/chat-%23couchbase-4a154b.svg?logo=slack)](
https://kotlinlang.slack.com/messages/couchbase/)

# Kotbase

**Kot**lin 멀티플랫폼 라이브러리로 Couch**base** Lite 지원

## 소개

Kotbase는 [Kotlin Multiplatform](https://www.jetbrains.com/kotlin-multiplatform/)과 임베디드 NoSQL JSON 문서 데이터베이스인 [Couchbase Lite](
https://www.couchbase.com/products/lite/)를 결합합니다. Couchbase Lite는 독립 실행형 클라이언트 데이터베이스로 사용하거나 [Couchbase Server](https://www.couchbase.com/products/server/) 및 [Sync
Gateway](https://www.couchbase.com/products/sync-gateway/) 또는 [Capella App Services](
https://www.couchbase.com/products/capella/app-services/)와 함께 클라우드에서 엣지로 데이터 동기화를 위해 사용할 수 있습니다. 주요 기능은 다음과 같습니다:

* [SQL++](https://www.couchbase.com/products/n1ql/), 키/값, 전문 검색, 벡터 검색 쿼리
* 관찰 가능한 쿼리, 문서, 데이터베이스 및 복제기
* 이진 문서 첨부파일(블롭)
* 피어 투 피어 및 클라우드-엣지 데이터 동기화

Kotbase는 Android 및 JVM([Java SDK를 통해](
https://github.com/couchbase/couchbase-lite-java-ce-root)), 네이티브 iOS 및 macOS([Objective-C SDK를 통해](
https://github.com/couchbase/couchbase-lite-ios)), 그리고 실험적 네이티브 Linux 및 Windows 지원([C SDK를 통해](
https://github.com/couchbase/couchbase-lite-C))에 대해 완전한 엔터프라이즈 및 커뮤니티 에디션 API 지원을 제공합니다.

## 설치

공유 모듈의 **build.gradle.kts** 파일 내 **commonMain** 소스셋 의존성에 커뮤니티 또는 엔터프라이즈 에디션 의존성을 추가하세요:



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
> **참고**
> Couchbase Lite 커뮤니티 에디션은 무료이며 오픈 소스입니다. 엔터프라이즈 에디션은 개발 및 테스트 용도로는 무료이지만,
> 프로덕션 사용을 위해서는 [Couchbase의 라이선스](https://www.couchbase.com/pricing/#couchbase-mobile)가 필요합니다.
> [커뮤니티 에디션과 엔터프라이즈 에디션 비교 보기.](https://www.couchbase.com/products/editions/mobile/)

Kotbase는 Maven Central에 게시되어 있습니다. Couchbase Lite 엔터프라이즈 에디션 의존성은 추가로
Couchbase Maven 저장소가 필요합니다.


```kotlin
repositories {
    mavenCentral()
    maven("https://mobile.maven.couchbase.com/maven2/dev/")
}
```
### 네이티브 플랫폼

네이티브 플랫폼 대상은 Couchbase Lite 종속성 네이티브 바이너리도 추가로 링크해야 합니다. 자세한 내용은 [지원 플랫폼](https://kotbase.dev/current/platforms/)을 참조하세요.

### 리눅스

리눅스에서 실행되는 JVM 또는 네이티브 리눅스를 대상으로 할 때는 libicu 종속성의 특정 버전이 필요합니다. (예상 버전을 나타내는 `libLiteCore.so: libicuuc.so.71: cannot open shared object file: No such file or directory`와 같은 오류가 표시될 수 있습니다.) 필요한 버전이 배포판의 패키지 관리자에서 제공되지 않는 경우 [GitHub](https://github.com/unicode-org/icu/releases)에서 다운로드할 수 있습니다.

## 문서

Kotbase 문서는 [kotbase.dev](https://kotbase.dev/)에서 확인할 수 있으며, [시작하기 예제](https://kotbase.dev/current/getting-started/), [사용 가이드](https://kotbase.dev/current/databases/), 및 [API 참조](https://kotbase.dev/api/)가 포함되어 있습니다.

## Java SDK와의 차이점

Kotbase의 API는 Couchbase Lite [Java](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/java/quickstart.html) 및 [Android KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/android/quickstart.html) SDK와 일치합니다. 기존 Kotlin 코드를 마이그레이션하는 것은 `com.couchbase.lite`에서 `kotbase`로 import 패키지를 변경하는 것만큼 간단할 수 있으나 일부 예외가 있습니다:

* Java 콜백 함수형 인터페이스는 Kotlin 함수 타입으로 구현됩니다.
* `File`, `URL`, 및 `URI` API는 문자열로 표현됩니다.
* `Date` API는 Kotlin의 `Instant`를 사용합니다.
* `InputStream` API는 [kotlinx-io의 `Source`](  
  https://kotlinlang.org/api/kotlinx-io/kotlinx-io-core/kotlinx.io/-source/)를 사용합니다.
* `Executor` API는 Kotlin의 `CoroutineContext`를 사용합니다.
* 인증서 API는 원시 `ByteArray` 또는 플랫폼별 코드로 제공됩니다.
* `CouchbaseLite.init()`을 명시적으로 호출할 필요가 없습니다. JVM 및 Android 플랫폼 코드에서 사용자 지정 매개변수를 사용하여 초기화 함수를 호출할 수 있습니다.
* 일반적인 오류 조건에 대해 Kotlin 예외를 감지하고 발생시키기 위한 노력이 이루어졌지만, Apple 플랫폼에서는 여전히 `NSError`가 누출될 수 있습니다. 해결이 필요할 수 있는 경우 [보고해 주세요](https://github.com/jeffdgr8/kotbase/issues/new).
* 일부 사용 중단된 API는 생략되었습니다.
* Java SDK에서는 사용할 수 없는, Java가 연산자 오버로딩을 지원하지 않기 때문에, [`Fragment` 하위스크립트 API](











  https://kotbase.dev/current/kotlin-extensions/#fragment-subscripts) 는 Swift(https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-swift/Classes/Fragment.html), Objective-C(https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-objc/Protocols/CBLFragment.html), 및 .NET(https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-net/api/Couchbase.Lite.IFragment.html)와 유사하게 Kotbase에서 사용할 수 있습니다.
* Android KTX SDK의 구성 팩토리 API는 Kotlin 명명 인수를 자체적으로 지원하는 생성자를 직접 사용하는 방식으로 대체되어 더 이상 사용되지 않습니다.

## 확장 라이브러리

Kotbase는 Couchbase Lite의 공식 API 위에 편리한 확장 기능을 추가 라이브러리 아티팩트로 포함하고 있습니다.

### Kotbase KTX

[KTX 확장](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-ktx/README.md)에는 훌륭한 [MOLO17의 Kotlin 확장](https://github.com/MOLO17/couchbase-lite-kotlin)과
쿼리 작성, 쿼리 결과 매핑, 문서 생성, 변경 `Flow` 관찰을 위한 기타 편의 함수가 포함되어 있습니다.

#### 설치



```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-ktx:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-ktx:3.2.4-1.2.0")
```

### Kotbase Kermit

[Kotbase Kermit](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-kermit/README.md)는 [Kermit](https://kermit.touchlab.co/)에 로그를 기록하는 Couchbase Lite 커스텀 로거입니다. Kermit은 로그를 콘솔을 포함한 여러 로그 출력으로 보낼 수 있습니다.

#### 설치


```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-kermit:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-kermit:3.2.4-1.2.0")
```

### Kotbase 페이징

[paging 확장 기능](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-paging/README.md)은 Google의 [AndroidX Paging](
https://developer.android.com/topic/libraries/architecture/paging/v3-overview)을 기반으로 구축되었습니다. Kotbase Paging은 사용자 제공 데이터베이스 쿼리를 기반으로
limit/offset 페이징 쿼리를 수행하는
[`PagingSource`](https://developer.android.com/reference/kotlin/androidx/paging/PagingSource)를 제공합니다.

#### 설치

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-paging:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-paging:3.2.4-1.2.0")
```
## 로드맵

* [x] 문서 웹사이트 ([kotbase.dev](https://kotbase.dev/))
* [x] `NSInputStream` 상호 운용성 ~~(Okio [#1123](https://github.com/square/okio/pull/1123))~~ (kotlinx-io [#174](
  https://github.com/Kotlin/kotlinx-io/pull/174))
* [x] Linux ARM64 지원
* [x] 공개 릴리스
* [ ] 샘플 앱
    * [x] [시작하기](examples/getting-started)
    * [x] [시작하기 Compose Multiplatform](examples/getting-started-compose)
    * [x] [Kotbase 노트](examples/kotbase-notes)
    * [ ] Kotbase 노트용 SwiftUI
* [x] Couchbase Lite [3.1 API](https://docs.couchbase.com/couchbase-lite/3.1/cbl-whatsnew.html) - 스코프 및 컬렉션
* [x] 버전별 문서
* [x] Couchbase Lite [3.2 API](https://docs.couchbase.com/couchbase-lite/3.2/cbl-whatsnew.html) - [벡터 검색](
  https://www.couchbase.com/products/vector-search/)
* [ ] Couchbase Lite [3.3 API](https://docs.couchbase.com/couchbase-lite/3.3/cbl-whatsnew.html) - 멀티피어 복제기
* [ ] Couchbase Lite [4.0 API](https://docs.couchbase.com/couchbase-lite/4.0/cbl-whatsnew.html) - 버전 벡터
* [ ] Linux 및 MinGW 플랫폼에서 URLEndpointListener
* [ ] [Swift export](https://youtrack.jetbrains.com/issue/KT-64572), `@ObjCName`, 및/또는 `@ShouldRefineInSwift`를 사용하여 Swift API와 Couchbase Lite 간 정렬 개선
* [ ] 비동기 코루틴 API

## 개발

* Linux에서 프로젝트를 빌드할 때는 libicu 의존성을 반드시 설치하세요.
* Windows에서 git 저장소를 체크아웃할 때는 [개발자 모드](
  https://learn.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development)를 활성화하고 git에서 심볼릭 링크를 `git config --global core.symlinks true`로 활성화하세요.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---