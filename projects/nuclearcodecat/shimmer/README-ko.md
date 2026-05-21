# shimmer - 사이드베리 지원 매력적인 파이어폭스 유저크롬 (v2.37)
![STAR BUTTON](https://github.com/user-attachments/assets/227bfd9e-ce3a-4d76-b8b7-24ad55dc128a)[![ISSUE](https://github.com/user-attachments/assets/648d41c3-4812-47fd-9696-38d76a2a0a5a)](https://github.com/nuclearcodecat/shimmer/issues)[![MONEY BUTTON](https://github.com/user-attachments/assets/18d7f816-f784-46b2-97b1-89173f68e227)](https://ko-fi.com/nuclearcodecat)

변경 내역은 [changelog](https://raw.githubusercontent.com/nuclearcodecat/shimmer/main/CHANGELOG.md)에서 확인하세요

### 안녕하세요, 이 프로젝트는 대부분 완성되었다고 생각합니다. 새로운 기능을 계획하지 않는 이유는 이 작업을 더 하고 싶지 않고 현재 집중 중인 큰 프로젝트들이 있기 때문입니다. shimmer는 멋지게 보이고 여기서 마무리할 예정입니다. 요청은 언제든 환영하지만 추가할지는 약속하지 않습니다. 좋은 말씀과 별들에 감사드립니다 :333

## 시연
<!--
![sidebarcollapse](https://github.com/user-attachments/assets/be8cb062-19f6-40b5-b26d-6a4fe8ceff7b)
-->
![out](https://github.com/user-attachments/assets/41ca27e6-701b-4049-8e38-76bcb300cd85)


| 사이드베리 사용                                                                                    | 기본 탭                                                                                                  |
|---------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| ![y](https://github.com/user-attachments/assets/6c8ce4d2-a9a8-478c-b427-77417f6a27a5) | ![x](https://github.com/user-attachments/assets/7b523c33-bec6-482a-9f01-3e478e75902e) |
<!-- | ![lightsidebery](https://github.com/user-attachments/assets/dd26f273-438e-42be-b77a-5d0df96b70bf) | ![greennative](https://github.com/user-attachments/assets/a60e6432-c919-4766-8353-609f1296315d)              | -->



| 메뉴                                                                                       | 팝오버 URL바                                                                             |
|---------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| ![ctxmenu](https://github.com/user-attachments/assets/7da9bdff-d247-4680-ad20-70d12c886272) | ![urlbar](https://github.com/user-attachments/assets/8b328ecf-0297-4e8c-8cb6-8826040c7916) |

### 사이드바 접기
시연에서 보이는 것처럼

### 컴팩트 파인드바
![findbar](https://github.com/user-attachments/assets/198c5ec8-6e59-46fb-8624-0baa90506c86)

### 삶의 질 향상 기능들
![longtab](https://github.com/user-attachments/assets/6ab029f9-1b67-4545-a898-bd680bd40000)

### 컴팩트하고 macOS 스타일의 창 제어 버튼
![winctr](https://github.com/user-attachments/assets/934849bd-19ba-4617-8bfe-f5b41508a872)

## 기능
 - 사이드바 접기
 - 팝오버 URL 바 (데모 애니메이션 이미지 참조)
 - 사용자 정의 테마와 호환
 - 둥근 브라우저/사이드바 모서리
 - 최소화된 컨텍스트 메뉴
 - 미묘하고 방해되지 않는 전환 효과
 - 최소화된 찾기 표시줄
 - 사이드바를 오른쪽으로 이동하는 설정 가능
 - 사용자 정의를 위한 구성 속성
 - 파이어폭스 나이트리와 호환
 - 네이티브 수직 탭과 반쯤 호환
 - 떠다니는 상태판

## 설치
 - 깃허브에서 코드 복제 또는 다운로드(초록색 "code" 버튼) 후 압축 해제
 - 원하면 모질라 애드온에서 사이드베리 다운로드
 - 사이드베리 설정 열기, 맨 아래(도움말 섹션)로 스크롤
 - "애드온 데이터 가져오기" 클릭
 - 다운로드한 압축 파일에서 "sidebery.json" 선택
 - 토글을 기본값으로 유지하고 "가져오기" 클릭
 - about:config 열기
 - `toolkit.legacyUserProfileCustomizations.stylesheets`를 true로 전환
 - `svg.context-properties.content.enabled`를 true로 전환
 - `sidebar.revamp`를 false로 전환
 - about:profiles 열기, 프로필 찾기 및 루트 폴더 열기
 - 없으면 `chrome` 폴더 생성
 - `userChrome.css`, `userContent.css` 파일과 `assets` 폴더를 `chrome` 디렉토리로 이동
 - 파이어폭스 재실행
 - 완료! :3
 - 최신 버전을 다운로드하려면 가끔씩 이 깃허브 페이지를 꼭 방문하세요, 이 README의 "업데이트" 섹션 참조
 - 사용자 정의 옵션은 이 README의 "사용자 정의" 섹션 참조

## 업데이트
 가끔씩 이 깃허브 페이지를 확인하여 새 버전이 있는지 확인하세요. 설치 버전은 새 탭 설정 메뉴(새 탭 오른쪽 아래) 닫기 버튼 옆에 표시됩니다.
### 업데이트 방법:
 설치 지침을 따라 파일 탐색기에서 파일 교체를 허용하세요(사이드베리 스타일 업데이트를 기억하세요)

## 사용자 정의
 `userChrome.css` 상단에는 사용자 정의 가능한 CSS 변수들이 있습니다. 탭 크기 옵션, 둥근 모서리, 특정 항목 간 간격 등이 포함되어 있습니다. 이 변수 아래에는 오른쪽 클릭 컨텍스트 메뉴에서 제외할 항목들도 있습니다. 원하는 옵션을 주석 처리하거나 해제하여 활성화 또는 비활성화할 수 있습니다.
 
 또한 수정할 수 있는 몇 가지 맞춤 `about:config` 불리언 값도 구현했습니다.
 - `shimmer.disable-collapsing-sidebar` – 사이드바 축소 비활성화를 위해 true로 전환 (안타깝게도 일부 사이드베리 스타일을 주석 처리해야 하며, 사이드베리 설정 내 스타일 편집기에 표시되어 있음)
 - `shimmer.remove-winctr-buttons` – 창 제어 버튼을 제거하려면 true로 전환
 - `shimmer.remove-firefox-view-button` – 파이어폭스 뷰 버튼을 제거하려면 true로 전환
 - `shimmer.disable-popover-transition` – urlbar의 팝오버 전환을 제거하려면 true로 전환
 - `shimmer.disable-urlbar-background-transition` – 팝오버 애니메이션 중 발생하는 urlbar 배경의 미묘한 전환을 제거하려면 true로 전환
 - `shimmer.disable-popover-urlbar` – urlbar의 팝오버 효과를 제거하려면 true로 전환
 - `shimmer.native-vertical-tabs` – 사이드베리 대신 파이어폭스 세로 탭을 사용하려면 true로 전환. *가로* 탭을 사용할 경우 true로 전환하지 마십시오, 탭이 사라집니다
 - `shimmer.show-sidebar-header` – 사이드바 헤더를 표시하려면 true로 전환
 - `shimmer.show-sidebar-header-close-button` - 헤더를 활성화해도 닫기 버튼은 자동으로 숨겨집니다. 이 버튼을 다시 표시하려면 true로 전환
 - `shimmer.sidebar-right-side` – 사이드베리를 오른쪽에 사용하려면 true로 전환. 먼저 파이어폭스에서 사이드바 헤더를 사용해 사이드바를 이동해야 하며, config에서 다시 활성화해야 합니다
 - `shimmer.reverse-winctr-buttons-side` – 창 제어 버튼을 왼쪽으로 이동하려면 true로 전환
 - `shimmer.taller-tabs` – 탭을 기본 파이어폭스 탭만큼 높게 만들려면 true로 전환
 - `shimmer.shorter-navbar` – 네비게이션 바를 수정 전 파이어폭스와 같은 높이로 만들려면 true로 전환 (파이어폭스 재시작 필요할 수 있음)
 - `shimmer.disable-compact-winctr-buttons` – 콤팩트 창 제어 버튼을 기본으로 되돌리려면 true로 전환
 - `shimmer.dont-expand-selected-tab` – 많은 탭이 열려 있을 때 활성 탭이 확장되는 효과를 비활성화하려면 true로 전환
 - `shimmer.enable-theme-aware-wallpapers` – 파이어폭스가 사용자 선택 배경화면을 표시하도록 하려면 true로 전환. 배경화면을 변경하려면 chrome 디렉터리를 열고, *walls* 디렉터리 내 *light* 및 *dark* 파일을 원하는 이미지로 교체한 후 `makewalls.sh`를 실행하십시오. 이 스크립트는 bash 스크립트입니다. 배경화면이 작동하지 않을 경우 크기를 줄여보십시오. 큰 파일은 작동하지 않으며 안전한 한계는 < 1MiB입니다.

## 유지 관리
 새 버전의 파이어폭스에서 발생한 문제를 하루 만에 항상 수정할 시간이 없다는 점을 기억해 주십시오. 풀 리퀘스트를 만들고 싶다면 언제든지 환영합니다. 문제가 발견되면 github의 "issues" 탭에 보고해 주십시오.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---