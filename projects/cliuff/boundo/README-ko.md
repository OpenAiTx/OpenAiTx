<p align="center">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot1.png" width="270" alt="스크린샷 1">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot2.png" width="270" alt="스크린샷 2">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot3.png" width="270" alt="스크린샷 3">
</p>

# Boundo 메타앱: 정보 및 관리자

Boundo 메타앱은 당신의 앱과 그 이상의 것을 다룹니다.  
휴대폰에 있는 앱 정보를 확인하고, 카테고리로 정리하세요.  
안드로이드 애호가를 위해 설계된 메타앱은 **안드로이드**와 **Wear OS**에서 사용 가능합니다.

### 1. 개발
**1.1 요구사항**
- Android Studio `Meerkat` (AGP `8.9`)
- Java `17`, Kotlin `2.1.21`, Gradle `8.13`

**1.2 자동 서명 구성**
- `doconfig` 디렉토리에 있는 `custom.properties.template` 파일을 **복사**하고,  
  이름을 `custom.properties`로 **변경**한 후 필요한 **수정**을 합니다.

**1.3 범용 APK 빌드 (앱 API 기능 포함, 릴리즈 변형)**
- 1.2절에 명시된 대로 서명 구성
- [BundleTool Releases](https://github.com/google/bundletool/releases)에서 BundleTool 바이너리 다운로드 후,  
  이 프로젝트의 `doconfig/bundletool.jar`로 저장
- 커맨드라인에서 Gradle 작업 실행 `gradlew :app:genUniversalApks`
- 이 프로젝트 내 `app/build/outputs/app-universal-release.apks` 확인

**1.4 FOSS 버전 빌드 (기능 제한)**
- 1.2절에 명시된 대로 서명 구성
- [BundleTool Releases](https://github.com/google/bundletool/releases)에서 BundleTool 바이너리 다운로드 후,  
  이 프로젝트의 `doconfig/bundletool.jar`로 저장
- 커맨드라인에서 Gradle 작업 실행 `gradlew :app:genFossApks`
- 이 프로젝트 내 `app/build/outputs/app-universal-foss.apks` 확인

### 2. 다운로드
[<img alt='Google Play에서 받기' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' height='100'/>](https://raw.githubusercontent.com/cliuff/boundo/main/
https://play.google.com/store/apps/details?id=com.madness.collision&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---