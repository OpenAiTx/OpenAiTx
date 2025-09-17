# 옵시디언 프로젝트 브라우저
[옵시디언](https://obsidian.md)용 플러그인으로, 새 탭 창을 각 폴더 내 파일을 상태별로 정리한 카드 레이아웃으로 대체합니다. 내장 검색 필드로 뷰를 필터링할 수 있으며(입력만 시작하세요!), 노트 내 눈에 띄는 메뉴에서 파일에 상태를 지정할 수 있습니다.

<img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/readme_hero-shot.png" alt="프로젝트 브라우저 플러그인 스크린샷">

## 📓 개발 일지
정기적인 개발 일지를 기록합니다. [구독하고 함께 따라가세요](https://www.youtube.com/@designdebtclub), 개발 중인 기능들을 확인할 수 있습니다.

<p align="center">
    <a href="https://youtube.com/playlist?list=PLAiv7XV4xFx3_JUHGUp_vrqturMTsoBUZ&si=7-XnA3NEq6OBNzhW" target="_blank">
        <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/devdiary-screenshot.jpg" width="60%" alt="개발 일지 영상 스크린샷"><br/>
        개발 일지 보기 클릭
    </a>
</p>

<p align="center">
  <a href="https://twitter.com/daledesilva" target="_blank_">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/twitter-btn.svg" height="40px" alt="트위터의 Dale de Silva">
  </a>
  <a href="https://indieweb.social/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/mastodon-btn.svg" height="40px" alt="마스토돈의 Dale de Silva">
  </a>
  <a href="https://www.threads.net/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/threads-btn.svg" height="40px" alt="Threads의 Dale de Silva">
  </a>
  <a href="https://bsky.app/profile/daledesilva.bsky.social" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/bluesky-btn.svg" height="40px" alt="Bluesky의 Dale de Silva">
  </a>
</p>

## 🗺️ 대략적인 로드맵
2023년 3월부터 이 플러그인을 개발해왔으며, 현재도 꾸준히 개발 중이고 매일 직접 사용하고 있습니다.<br/>
아래는 현재 개발 계획의 주요 기능들과 예상 구현 시기입니다.

<details>
<summary>과거</summary>

- ✅ 파일을 카드로 표시.
- ✅ 폴더 탐색.
- ✅ 상태별 정리.
- ✅ 간편한 노트 상태 메뉴.
- ✅ 백/포워드 내비게이션 및 기억 기능.
- ✅ 라이트/다크 모드 지원.
- ✅ 상태 커스터마이징 가능.
- ✅ 우클릭 액션 지원.
- ✅ 개별 폴더 숨기기.
- ✅ 시작 폴더 커스터마이징.
</details>

<details open>
<summary>현재 기능 집중 사항</summary>

- [ ] 폴더를 프로젝트로 사용.
- [ ] 다중 페이지 프로젝트 지원.
- [ ] 노트 재정렬.
- [ ] 노트 우선순위 지정.
</details>

## ⚠️ 주의 사항
>대부분의 Obsidian 플러그인과 마찬가지로, 이 플러그인은 커뮤니티에 무료로 제공되는 '있는 그대로'의 선물입니다. 최고의 품질을 위해 노력하고 있으며(피드백 환영), 때때로 일부 기능이 제대로 작동하지 않을 수 있습니다. 안전을 위해 **항상 파일을 백업해 주세요**.

## 🪳 버그 신고
문제가 있거나 기능 요청이 있으신가요? 주저하지 마시고 [GitHub Issues](https://github.com/daledesilva/obsidian_project-browser/issues) 페이지에서 의견을 남겨 주세요. 다만 동일한 이슈가 이미 게시되었는지 확인하고, 있으면 해당 게시물에 댓글을 남겨 주세요.

## 💾 설치 방법
이 플러그인은 Obsidian 내 플러그인 디렉터리에서 찾을 수 있습니다.
<details>
<summary>플러그인 설치 도움말 보기</summary>

1. Obsidian 볼트를 열고 **설정**으로 이동합니다.

2. 사이드바에서 **커뮤니티 플러그인**을 클릭합니다.

3. 아직 활성화하지 않았다면, 커뮤니티 플러그인을 켜야 합니다.

4. 'Dale de Silva'를 검색하고 **Project Browser**를 설치합니다.
</details>

테스트 중인 새 버전의 플러그인을 설치하고 싶다면, 대신 BRAT을 통해 설치할 수 있습니다.
BRAT은 베타 버전을 설치할 수 있는 또 다른 커뮤니티 플러그인입니다. 새 기능은 먼저 베타 버전으로 출시되며, 정식 버전에 반영되기까지 며칠에서 한 달까지 걸릴 수 있습니다.
<details>
<summary>베타 버전 설치 지침 보기</summary>

1. 오브시디언 볼트를 열고 **설정**으로 이동합니다.
2. 사이드바에서 **커뮤니티 플러그인**을 클릭합니다.
3. 커뮤니티 플러그인을 켜고 **찾아보기**를 클릭합니다.
4. **BRAT**를 검색하여 설치합니다.
5. 아래로 스크롤하여 BRAT를 **활성화**합니다.
6. 사이드 패널의 BRAT 메뉴에서 **베타 플러그인 추가**를 선택합니다.
7. 제시된 지침을 따릅니다.
8. URL이 요청되면 다음을 사용하세요: `https://github.com/daledesilva/obsidian_project-browser/`

</details>
<details>
<summary>베타 버전 업데이트 지침 보기</summary>

- BRAT는 기본적으로 시작 시 베타 플러그인을 업데이트하도록 설정되어 있으나, 때때로 시간이 걸릴 수 있습니다.
- 업데이트를 강제로 실행하려면 BRAT의 오브시디언 명령 `단일 플러그인 선택하여 업데이트`를 실행하고 Project Browser를 선택하세요.
</details>

## ❤️ 지원
이 플러그인이 시간을 절약해주거나 도움이 되었다면, 플러그인 및 이와 같은 무료 커뮤니티 자료 개발을 지원해 주시길 부탁드립니다.

<p>
  <a href="https://twitter.com/daledesilva" target="_blank_">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/twitter-btn.svg" height="40px" alt="트위터에서 Dale de Silva">
  </a>
  <a href="https://indieweb.social/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/mastodon-btn.svg" height="40px" alt="마스토돈에서 Dale de Silva">
  </a>
  <a href="https://www.threads.net/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/threads-btn.svg" height="40px" alt="Threads에서 Dale de Silva">
  </a>
  <a href="https://bsky.app/profile/daledesilva.bsky.social" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/bluesky-btn.svg" height="40px" alt="블루스카이에서 Dale de Silva">
  </a>
  <a href="https://ko-fi.com/N4N3JLUCW" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/support-btn.svg" height="40px" alt="Ko-fi에서 저를 지원하세요">
  </a>
</p>

## 🤖 My other work
You can find links to my other projects on [designdebt.club](https://designdebt.club), where I blog about design and development, as well as release other plugins like this one. You can also find my writing at at [falterinresolute.com](https://falterinresolute.com) where I combine philosophy and animation.

<p>
  <a href="https://designdebt.club" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/design-debt-club-btn.svg" height="50px" alt="Design Debt Club">
  </a>
  <a href="https://falterinresolute.com" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/falter-in-resolute-btn.svg" height="50px" alt="Falter In Resolute Blog">
  </a>
</p>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-17

---