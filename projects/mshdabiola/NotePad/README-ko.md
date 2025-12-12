[![Contributors](https://img.shields.io/github/contributors/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/graphs/contributors)
[![Forks](https://img.shields.io/github/forks/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/metworks/members)
[![Stargazers](https://img.shields.io/github/stars/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/stargazers)
[![Issues](https://img.shields.io/github/issues/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/Wladefant/mshdabiola/Play_NotePad/issues)
[![License](https://img.shields.io/github/license/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/master/LICENSE)

# NotePad

[<img src="/images/ic_launcher-playstore.png" align="left"
width="200" hspace="10" vspace="10">](/images/ic_launcher-playstore.png)

Notepad는 생각, 아이디어 및 작업을 쉽게 캡처하고 정리할 수 있는 다용도 노트 작성 앱입니다. 다양한 기능을 통해 Play Notepad는 노트를 효율적으로 관리하고 정리하는 데 도움을 줍니다.

Play NotePad는 구글 플레이 스토어에서 이용할 수 있습니다:

<p align="left">
<a href="https://play.google.com/store/apps/details?id=com.mshdabiola.playnotepad">
    <img alt="Get it on Google Play"
        height="70"
        src="https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png" />
</a>

<a href="https://f-droid.org/packages/com.mshdabiola.playnotepad.foss/">
    <img alt="Get it on F-Droid"
        height="70"
        src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png" />
</a>

<a href="https://github.com/mshdabiola/NotePad/releases">
    <img alt="Get it on GitHub"
        height="70"
        src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/github_image.png" />
</a>  



<a href="https://github.com/mshdabiola/Play_NotePad">데모 보기</a>
·


<a href="https://github.com/mshdabiola/Play_NotePad/issues">버그 신고</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">기능 요청</a>
  </p>

## 프로젝트 소개

[<img src="/images/screenshot1.png" align="left"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot1.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png)

주요 기능:

- 레이지 모드: 게시물 자동 스크롤로 엄지손가락을 움직이지 않고도 멋진 게시물을 즐길 수 있습니다.
- 텍스트 노트를 쉽게 생성하고 편집할 수 있습니다.
- 사진을 찍거나 카메라 롤에서 선택하여 노트에 첨부할 수 있습니다.
- 자유롭게 스케치와 다이어그램을 그려 노트에 주석을 달 수 있습니다.
- 오디오 노트를 녹음하고 나중에 재생할 수 있습니다.
- 중요한 노트를 목록 상단에 고정하여 쉽게 접근할 수 있습니다.
- 체크리스트를 만들어 할 일을 체크박스로 관리할 수 있습니다.
- 라벨을 붙여 노트를 체계적으로 정리할 수 있습니다.
- 노트를 복제하여 쉽게 참고할 수 있습니다.
- 이메일이나 메시지를 통해 노트를 다른 사람과 공유할 수 있습니다.
- 노트에 알림을 설정하여 중요한 작업이나 이벤트를 잊지 않을 수 있습니다.
- 더 이상 필요 없는 노트를 삭제할 수 있습니다.
- 오래된 노트나 완료된 작업을 보관하여 노트를 정리할 수 있습니다.
- 노트에 색상을 추가하여 시각적으로 더 매력적으로 만들 수 있습니다.
- 노트 배경에 이미지를 추가하여 더 개인화된 모습을 만들 수 있습니다.
- 노트를 목록 또는 열 형식으로 보면서 쉽게 읽고 편집할 수 있습니다.
- 키워드, 라벨, 타입별로 노트를 검색할 수 있습니다.
- 오프라인 상태에서도 앱을 사용하고 언제든지 노트에 접근할 수 있습니다.

## 사용 기술

## 3개의 주요 모듈을 갖춘 클린 아키텍처

[//]: # (<img src="/images/AndroidTemplate-CleanArchitecture.jpeg" alt="ArchiTecture logo"/>)

- 선언적 UI ([Jetpack Compose](https://developer.android.com/jetpack/compose) 사용)
    - Compose Navigation (
      [Hilt 지원](https://developer.android.com/jetpack/compose/libraries#hilt-navigation)
      및 Assisted Inject 예제 포함)
- 데이터 (데이터베이스, API 및 환경설정 코드용)
- 도메인 (비즈니스 로직 및 모델용)
- AndroidApp (MVVM을 활용한 UI 로직용)
- 이 버전은 [모듈화](https://developer.android.com/topic/modularization)를 도입
- 버전 관리 (
  [버전 카탈로그](https://docs.gradle.org/current/userguide/platforms.html) 사용)
- 공통 빌드 로직 (
  [컨벤션 플러그인](https://docs.gradle.org/current/samples/sample_convention_plugins.html) 사용)
- 의존성 주입 ([Hilt](http://google.github.io/hilt/) 사용)
- 반응형 프로그래밍 (
  [Kotlin Flows](https://kotlinlang.org/docs/reference/coroutines/flow.html) 사용)
- 구성 변경 시 ViewModel 공유를 위한 Android 아키텍처 컴포넌트
- [스플래시 스크린](https://developer.android.com/develop/ui/views/launch/splash-screen) 지원
- Google Material 3 [Material Design](https://material.io/blog/android-material-theme-color) 라이브러리

- 엣지 투 엣지 구성

[//]: # (## 테스트)

[//]: # (- [Mockk]&#40;https://mockk.io/&#41; 라이브러리)

[//]: # (- 단위 테스트)

[//]: # (- 애플리케이션 테스트)

[//]: # (    - 테스트 작업 방법 예시)

[//]: # (- Activity 테스트 ([Compose Testing](https://developer.android.com/jetpack/compose/testing) 사용))

[//]: # (    - 테스트 내 코루틴 스코프 작업 방법 예시)


## 기여

1. 기여는 오픈 소스 커뮤니티를 배우고, 영감을 얻고, 창작하는 놀라운 장소로 만드는 원동력입니다. 여러분의 모든 기여는 **진심으로 감사드립니다**.

2. 버그를 수정하거나 문서를 개선하거나 소식을 전파하는 등 어떤 형태든 Gatsby 커뮤니티의 일원이 되어 주시면 환영합니다!

3. 기여에 관심을 가져 주셔서 감사합니다! 이 프로젝트에 기여할 수 있는 다양한 방법이 있습니다. 여기서 시작하세요 (Contributing.md 링크)

### 피드백

프로젝트에 별점을 주는 것도 잊지 마세요! 다시 한 번 감사드립니다!

앱에 관한 토론이나 일반적인 질문은 [Github Discussions](https://github.com/mshdabiola/Play_NotePad/discussions)를 이용하세요. 여기서 기능 요청도 제출할 수 있습니다 (기능 요청 제출 방법을 먼저 읽어 주세요!) 또는 개발자라면 이 프로젝트를 포크하여 풀 리퀘스트를 생성할 수 있습니다.

1. 프로젝트를 포크하세요  
2. 기능 브랜치를 생성하세요 (`git checkout -b feature/AmazingFeature`)  
3. 변경 사항을 커밋하세요 (`git commit -m 'Add some AmazingFeature'`)  
4. 브랜치에 푸시하세요 (`git push origin feature/AmazingFeature`)  
5. 풀 리퀘스트를 오픈하세요  

다음은 도움을 줄 수 있는 다른 방법들입니다:

* [버그 신고](https://github.com/mshdabiola/Play_NotePad/issues)

* [앱 번역](https://poeditor.com/join/project/rdWI3SpnSW)

## 개발

## 라이선스

Play Notepad는 GNU 일반 공중 사용 허가서(GPL-3.0) 하에 라이선스가 부여되어 있습니다. 라이선스 전문은 `LICENSE` 파일에서 확인할 수 있습니다.

## 연락처







mshdabiola - [@Mshdabiola](https://twitter.com/mshdabiola) - mshdabiola@gmail.com

## 감사의 말



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---