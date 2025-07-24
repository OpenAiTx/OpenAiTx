<img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/resources/social_preview.png" width="100%" />

![](https://github.com/vodemn/m3_lightmeter/actions/workflows/pr_check.yml/badge.svg)
![](https://github.com/vodemn/m3_lightmeter/actions/workflows/create_release.yml/badge.svg)

# 목차

- [목차](#table-of-contents)
- [배경 이야기](#backstory)
- [스크린샷](#screenshots)
- [개발](#development)
- [지원](#support)
- [iOS 제한사항](#ios-limitations)

# 배경 이야기

얼마 전 저는 [Material Lightmeter](https://play.google.com/store/apps/details?id=com.vodemn.lightmeter&hl=en&gl=US) 앱 개발을 시작했습니다. 불행히도 이 앱의 마지막 업데이트는 이 저장소가 만들어지기 거의 1년 전이었습니다. 그래서 구글 플레이에서 "이 앱은 훌륭하지만 더 이상 업데이트되지 않는다"는 긍정적인 리뷰를 읽고 나서, 업데이트를 하고 이 앱을 오픈 소스로 만들기로 결정했습니다. 언젠가 누군가가 이 프로젝트에 기여할지도 모르니까요.

하지만 기존 저장소에 경험 부족으로 인해 민감한 데이터가 포함되어 있었기에, 새 저장소를 만들어야 했습니다. 새 저장소를 만든다면, 앱을 처음부터 다시 작성하는 것이 낫지 않을까 싶었습니다.

그리하여 지체 없이 Material You (일명 M3)에서 영감을 받은 저의 새로운 Lightmeter 앱을 소개합니다.

# 스크린샷

<p float="center">
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_metering-reflected.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_equipment-profiles.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_settings.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/light_timer.png" width="18.8%" />
  <img src="https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/screenshots/generated/ios/iphone65inch/dark_metering-reflected.png" width="18.8%" />
</p>

# 개발

### 1. Flutter 설치

이 앱을 빌드하려면 Flutter 3.24.5 안정 버전을 설치해야 합니다. [설치 방법](https://docs.flutter.dev/get-started/install).

### 2. 프로젝트 설정

#### git에서 무시된 파일 복원:

macOS에서는 다음 스크립트를 실행하면 됩니다:

```console
sh scripts/setup_fork.sh
```


또는 스크립트의 내용을 사용하여 파일을 수동으로 생성할 수 있습니다.

#### 의존성 가져오기

> VSCode를 사용하는 경우, 다음과 같이 작업 공간을 열 수 있습니다: _파일 -> 파일에서 작업 공간 열기 -> m3_lightmeter.code-workspace_. 그렇지 않으면 iap 폴더에서 `flutter pub get` 명령을 실행해야 합니다.

그런 다음 다음 명령을 실행하여 모든 필요한 의존성을 가져오고 번역 파일을 생성할 수 있습니다:


```console
flutter pub get
flutter pub run intl_utils:generate
```
### 3. 빌드

- Android용 [Build .apk](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_apk.yml) 워크플로우를 확인하세요  
- iOS용 [Build .ipa](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/.github/workflows/build_ipa.yml) 워크플로우를 확인하세요  

# 지원

버그를 보고하거나 새로운 기능을 제안하려면 새 [이슈](https://github.com/vodemn/m3_lightmeter/issues)를 열어주세요. 프로젝트에 기여하고 싶다면 자유롭게 Pull Request를 열 수 있지만, 이 [스타일 가이드](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/doc/style_guide.md)를 따라야 합니다.  

기타 질문이 있으시면 [이메일](https://raw.githubusercontent.com/vodemn/m3_lightmeter/main/mailto:contact.vodemn@gmail.com?subject="Lightmeter")로 연락해 주세요.  

# iOS 제한사항

Android 버전 앱에 있는 기능 중 iOS에 없는 목록입니다.  

## 입사광 측광

Apple은 주변광 센서에서 Lux 스트림을 읽는 API를 제공하지 않습니다. Lux는 전면 카메라 이미지 스트림을 기반으로 계산할 수 있지만, 이는 반사광입니다. 따라서 iOS에서는 입사광 측광을 구현할 방법이 없습니다.  

## 볼륨 버튼 동작

이것은 [구현할 수](https://stackoverflow.com/questions/70161271/ios-override-hardware-volume-buttons-same-as-zello) 있지만 앱이 [2.5.9](https://developer.apple.com/app-store/review/guidelines/#software-requirements) 때문에 거부될 것입니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---