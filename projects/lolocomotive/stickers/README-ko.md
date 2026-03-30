# 스티커

광고 없는 WhatsApp용 간단한 안드로이드 스티커 제작기입니다.

[![](https://upload.wikimedia.org/wikipedia/commons/7/78/Google_Play_Store_badge_EN.svg)](https://play.google.com/store/apps/details?id=de.loicezt.stickers)

또는 최신 [GitHub 릴리스](https://github.com/lolocomotive/stickers/releases)에서 다운로드하세요

## 기능

- 빠른 모드: 이미지를 앱에 공유하면 자동으로 WhatsApp에 추가됩니다
- 편집기
    - 원하는 대로 스티커를 자르세요
    - 다양한 크기, 글꼴, 색상의 텍스트 추가
    - 다양한 색상과 브러시 크기로 그림 그리기, 실행 취소/다시 실행 지원
    - 모든 요소는 자체 레이어를 가지므로 텍스트 위와 아래에 그림을 그릴 수 있습니다
- 가져오기/내보내기
    - `.zip`으로 내보내어 팩을 공유하거나 백업
    - 다양한 형식에서 가져오기 (자체 `.zip` 형식, `.wastickers`, `.stickify`, 대부분은 그림과 간단한 매니페스트가 포함된 ZIP 파일이라 더 추가하기 어렵지 않음)
- 여러 팩과 메타데이터(저자, 제목, 트레이 아이콘 등)를 생성, 편집, 삭제 가능

## 스크린샷

| 홈                               | 팩 보기                          | 편집기                              |
|-----------------------------------|-----------------------------------|---------------------------------------|
| ![home.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/home.png) | ![pack.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/pack.png) | ![editor.png](https://raw.githubusercontent.com/lolocomotive/stickers/main/screenshots/editor.png) |

## 빌드

`flutter run` 명령어는 잘 작동하지만, 앱의 릴리스 버전을 빌드하려면,
다음 중 하나를 해야 합니다:

<details>
<summary>자신만의 서명 키 사용하기</summary>

`android/` 폴더에 `key.properties` 파일을 생성하고 다음과 같이 작성하세요


```properties
storeFile=path/to/keystore.jks
keyAlias=your key alias
storePassword=your store password
keyPassword=your key password
```

More details: https://docs.flutter.dev/deployment/android#sign-the-app

</details>

or

<details>
<summary>디버그 서명 구성 사용</summary>

In `android/app/build.gradle` around line 29

```
buildTypes {
  release {
    signingConfig signingConfigs.release
  }
}
```

`signingConfigs.release`를 `signingConfigs.debug`로 교체하고 제거하세요

```
def keystoreProperties = new Properties()
def keystorePropertiesFile = rootProject.file("key.properties")
if (keystorePropertiesFile.exists()) {
    keystorePropertiesFile.withReader('UTF-8') { reader ->
        keystoreProperties.load(reader)
    }
}
```

and

```
signingConfigs {
    create("release") {
        keyAlias = keystoreProperties["keyAlias"]
        keyPassword = keystoreProperties["keyPassword"]
        storeFile = new File(keystoreProperties["storeFile"])
        storePassword = keystoreProperties["storePassword"]
    }
}
```
그리고 작동해야 합니다, 테스트 용도로만 사용하세요.
</details>

그리고 그 다음에는 그냥 해야 합니다


```
flutter build apk
```

## 기여하기

모든 기여(풀 리퀘스트, 기능 요청 및 버그 보고)를 환영합니다!
내 줄 너비가 80이 아닌 120으로 설정되어 있으니 전체 파일을 재포맷하기 전에 주의하세요.
vscode를 사용 중이라면 `.vscode/settings.json`에 다음을 입력하세요.

```json
{
  "dart.lineLength": 120,
  "[dart]": {
    "editor.rulers": [
      120
    ]
  }
}
```
또한 코드가 아직 잘 문서화되어 있지 않으니 읽으시는 분들께 미리 양해를 구합니다.

## TODO

앞으로 작업할 계획인 몇 가지 기능들

- [ ] 홈 화면에서 여러 팩을 한 번에 선택하기
- [ ] 텍스트에 배경을 추가하는 옵션 추가
- [ ] 스티커에 이미지 레이어 추가
- [ ] 기존 스티커로 시작하기
- [ ] GIF에서 애니메이션 스티커 만들기
- [ ] 비디오 자르기 및 회전

## iOS 지원

저는 애플 기기를 보유하고 있지 않아 iOS용 빌드나 iOS 앱 테스트가 불가능합니다. 이 앱은 플러터 앱이므로 어느 정도 작동할 것입니다.
iOS 지원을 추가하고 싶으시다면 환영합니다! 참고할 사항은 다음과 같습니다:

- `image_editor`는 iOS에서 WEBP를 지원하도록 수정해야 합니다 (현재는 Android에서만 WEBP 지원이 추가되어 있습니다)
- `whatsapp_stickers_plus` 패키지는 작동하지 않을 수 있습니다 (Android에서 작동하지 않았습니다).
- iOS 앱처럼 보이게 하려면 많은 위젯을 `.adaptive` 버전으로 교체해야 합니다






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---