# GroceryApp 스타터

간편한 쇼핑 경험을 위한 간소화된 그로서리 앱 템플릿입니다. 🛒✨

유용하다고 생각되면 저장소에 별표 ⭐를 남겨주세요.

## 디자인

**아래 이미지를 클릭하면 Figma 디자인을 볼 수 있습니다:**

[![Design Preview](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨요구사항

1. **개발 환경:**
   - Flutter SDK가 설치된 모든 IDE (예: VSCode, Android Studio, IntelliJ 등)

2. **지식 기반:**
   - Dart와 Flutter의 기초~중급 지식
   - MVVM 아키텍처에 대한 이해
   - API 처리에 대한 친숙도
   - GetX를 이용한 상태 관리의 기본
  
## 테스트
* 안드로이드 기기용 사전 출시 버전을 여기에서 다운로드할 수 있습니다: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## 설치 방법
* `lib\constants\AppConstants`에서 제품 엔드포인트, 자격 증명 및 매개변수를 먼저 구성하세요.
* **또는**, 아래 제공된 무료 엔드포인트(공유 날짜 기준)를 사용하여 성공적으로 테스트할 수 있습니다.
```dart
class AppConstants {
  // "YOUR_API_PREFIX"를 본인의 API 기본 URL로 교체하세요.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //IF_EXIST

  // 테스트용으로, 출시 버전의 무료 API 기본 URL 사용
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // 프로젝트 소유자 전체 이름
  static const String projectOwnerName = "FULL_NAME";
}
```

## 공지사항
* 자체 API 엔드포인트를 사용하려면, API 문서에 따라 MVVM 아키텍처 가이드라인에 맞게 논리 계층을 커스터마이즈하세요.
* 사전 출시 버전의 일부 이미지는 저작권 문제로 삭제되었습니다.

## 기여 안내

이 저장소를 포크한 후,
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls)를 통해 기여해 주세요.

크고 작은 모든 기여, 주요 기능 추가, 버그 수정 등은 환영하며,
꼼꼼하게 검토될 예정입니다.


## 시작하기
이 프로젝트는 Flutter 애플리케이션의 시작점입니다.

Flutter 프로젝트가 처음이라면 아래 자료가 도움이 될 수 있습니다:

- [Lab: 첫 번째 Flutter 앱 작성하기](https://flutter.io/docs/get-started/codelab)
- [Cookbook: 유용한 Flutter 샘플](https://flutter.io/docs/cookbook)

## 방문자 수

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---