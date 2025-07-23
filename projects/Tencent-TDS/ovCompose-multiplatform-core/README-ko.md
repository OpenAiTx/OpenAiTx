<p align="center">
    <img alt="ovCompose Logo" src="https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/img/ovCompose.svg" />
</p>

### 영어
ovCompose (online-video-compose)는 텐센트의 선도적인 프론트엔드 그룹인 Oteam 내 텐센트 비디오 팀이 출시한 크로스플랫폼 개발 프레임워크입니다. 이는 Compose Multiplatform 생태계를 기반으로 하며, Jetbrains Compose Multiplatform의 한계, 특히 HarmonyOS 플랫폼 미지원과 iOS에서의 혼합 레이아웃 렌더링 제한 문제를 해결하는 데 목적이 있습니다. ovCompose는 기업이 완전한 크로스플랫폼 앱을 쉽게 구축할 수 있도록 돕습니다.

[ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_en.md)에 대해 자세히 알아보세요.

### 中文
ovCompose（online-video-compose）是腾讯大前端领域Oteam中，腾讯视频团队基于 Compose Multiplatform 生态推出的跨平台开发框架，旨在弥补Jetbrains Compose Multiplatform不支持鸿蒙平台的遗憾与解决iOS平台混排受限的问题，便于业务构建全跨端App。

详情请见 [ovCompose](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/README_ovCompose_zh.md)

---
# Android Jetpack

[![Revved up by Gradle Enterprise](https://img.shields.io/badge/Revved%20up%20by-Gradle%20Enterprise-06A0CE?logo=Gradle&labelColor=02303A)](https://ge.androidx.dev)

Jetpack은 개발자가 고품질 앱을 더 쉽게 작성할 수 있도록 돕는 라이브러리, 도구 및 가이드 모음입니다. 이 컴포넌트들은 모범 사례를 따르도록 돕고, 반복적인 코딩을 줄이며, 복잡한 작업을 단순화하여 개발자가 중요한 코드에 집중할 수 있게 합니다.

Jetpack은 플랫폼 API에서 분리된 `androidx.*` 패키지 라이브러리로 구성되어 있습니다. 즉, 이전 버전 호환성을 제공하며 Android 플랫폼보다 더 자주 업데이트되어 최신 Jetpack 컴포넌트를 항상 사용할 수 있습니다.

공식 AAR 및 JAR 바이너리는 [Google Maven](https://maven.google.com)을 통해 배포됩니다.

자세한 사용법은 [Android Jetpack 랜딩 페이지](https://developer.android.com/jetpack)에서 확인할 수 있습니다.

# 기여 가이드

GitHub를 통한 기여는 [GitHub 기여 가이드](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/CONTRIBUTING.md)를 참조하세요.

참고: 현재 GitHub를 통한 기여 워크플로우는 실험 단계이며, 다음 프로젝트에 한해 기여를 받고 있습니다:
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

## 코드 리뷰 예절
Jetpack에 기여할 때는 [코드 리뷰 예절](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/code-review.md)을 준수하세요.

## 허용되는 기여 유형
* 버그 수정 - 해당 버그는 [Android 이슈 트래커](https://issuetracker.google.com/issues/new?component=192731&template=842428)에 보고되어야 합니다.
* 각 버그 수정에는 테스트가 포함되어야 합니다.
* 맞춤법 오류 수정
* 문서 업데이트
* 현재 테스트가 없는 영역에 대한 신규 테스트 추가
* AndroidX 팀 멤버가 승인한 기능 요청 버그에 따른 기존 라이브러리의 신규 기능 추가

현재 신규 모듈은 받지 않습니다.

## 코드 체크아웃

[온보딩 문서](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/docs/onboarding.md)에서 설정 및 개발 워크플로우에 대해 자세히 알아보세요!

### 지속적 통합
[우리의 지속적 통합 시스템](https://ci.android.com/builds/branches/aosp-androidx-main/grid?)은 진행 중인(및 잠재적으로 불안정한) 라이브러리들을 새 변경 사항이 병합될 때마다 빌드합니다. 실험용으로 이 AAR 및 JAR을 수동으로 다운로드할 수 있습니다.

## 변경 전 비밀번호 및 기여자 동의
첫 기여를 업로드하기 전, 비밀번호 설정 및 기여자 동의가 필요합니다:

HTTPS 비밀번호 생성:
https://android-review.googlesource.com/new-password

Google 기여자 라이선스 동의:
https://android-review.googlesource.com/settings/new-agreement

## 리뷰 받기
* repo upload를 실행한 후 [r.android.com](http://r.android.com)을 엽니다.
* 계정에 로그인(없으면 생성)합니다.
* 적절한 리뷰어를 추가합니다(수정한 파일에 가장 많이 기여한 사람을 git log로 찾거나 프로젝트 디렉토리 내 OWNERS 파일을 확인).

## 바이너리 종속성 처리
AndroidX는 모든 바이너리 Gradle 종속성을 git으로 저장합니다. 이들은 체크아웃 시 `prebuilts/androidx/internal` 및 `prebuilts/androidx/external` 디렉토리에 있습니다. 이 종속성들은 `google()`, `mavenCentral()`에서도 사용 가능합니다. 빌드의 독립성을 위해 복사본을 저장합니다. [importMaven 도구](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/development/importMaven/README.md)를 사용해 새 종속성을 추가할 수 있습니다.

## 배포

`gradle.properties`에서 원격 maven을 설정하세요.



```
maven.remote.url=https:xxx
maven.remote.username=xxx
maven.remote.password=xxx
```
원격 또는 로컬 메이븐에 아티팩트를 게시하려면 자세한 내용은 [MULTIPLATFORM.md](https://raw.githubusercontent.com/Tencent-TDS/ovCompose-multiplatform-core/ov/compose-1.6.1/MULTIPLATFORM.md)를 참조하세요.
```
./gradlew :mpp:publishComposeJb -Pcompose.platforms=android,ohosArm64,uikit
./gradlew :mpp:publishComposeJbToMavenLocal -Pcompose.platforms=android,ohosArm64,uikit
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---