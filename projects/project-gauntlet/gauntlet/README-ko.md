# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

웹 우선 크로스 플랫폼 애플리케이션 런처, React 기반 플러그인 지원

> [!WARNING]
> 런처는 한 명의 개발자가 여가 시간에 개발 중입니다.
> 변경 사항은 느릴 수 있지만 꾸준히 진행됩니다.
>
> [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md)에 문서화될 수 있는 호환성 깨짐(breaking changes)이 있을 수 있습니다.

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## 데모

약간 구버전 데모

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## 주요 기능

- 플러그인 우선 구조
  - 플러그인은 TypeScript로 작성
  - 광범위한 플러그인 API 
      - UI 뷰 생성
      - 일회성(one-shot) 명령 실행
      - 일회성 명령 목록을 동적으로 제공
      - 메인 검색창 아래에 값에 따라 빠른 "인라인" 콘텐츠 직접 렌더링
      - 클립보드에서 내용 가져오기 및 추가
  - 플러그인은 Git 저장소의 별도 브랜치로 배포되므로 플러그인 배포에 중앙 서버가 필요하지 않음
  - 플러그인 ID는 Git 저장소 URL만 사용
  - [React](https://github.com/facebook/react) 기반 플러그인 UI
    - 커스텀 React Reconciler로 구현(Electron 미사용)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno를 통해 JavaScript 플러그인 코드를 샌드박스 처리하여 보안성 향상
    - 플러그인은 필요한 권한을 명시적으로 지정해야 함
    - 플러그인 도구 실행에는 Node.js 사용, 그러나 플러그인 개발자는 항상 Deno에서 동작하는 코드를 작성
- 처음부터 크로스 플랫폼을 염두에 두고 설계
- 커스텀 글로벌 단축키로 명령 및 뷰 실행/오픈 가능
- 명령 또는 뷰에 커스텀 검색 별칭 할당 가능
- 커스텀 테마 지원
- 내장 기능은 번들 플러그인으로 제공
  - 애플리케이션: 시스템에 설치된 애플리케이션을 검색 결과에 표시
    - 플러그인은 창과 해당 애플리케이션을 추적하여, 이미 열려있는 애플리케이션을 실행하면 기본적으로 이전에 생성된 창을 불러옴
      - 현재 모든 시스템이 지원되는 것은 아님. [기능 지원](https://gauntlet.sh/docs/feature-support) 참고
  - 계산기: 메인 검색창 아래에 수학 연산 결과 표시
    - 환율을 이용한 통화 변환 포함
    - [Numbat](https://github.com/sharkdp/numbat) 기반
- Frecency 기반 검색 결과 정렬
   - Frecency란 자주(frequency)와 최근(recency)의 합성어
   - 자주 사용할수록 결과 리스트 상위에 위치, 하지만 과거에만 많이 쓴 항목은 최근에 많이 쓴 항목보다 낮게 배치
   - 결과는 각 단어의 부분 문자열로 매칭

##### OS 지원

##### 공식 지원
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### 최선의 지원
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland는 아직 미지원, [#40](https://github.com/project-gauntlet/gauntlet/issues/40) 참고
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## 시작하기

### Gauntlet 설치

[설치 안내](https://gauntlet.sh/docs/installation) 참고

### 글로벌 단축키

메인 창은 글로벌 단축키 또는 CLI 명령어로 열 수 있습니다:
- 글로벌 단축키 (설정에서 변경 가능)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - 글로벌 단축키가 지원되지 않을 수 있음, [기능 지원](https://gauntlet.sh/docs/feature-support) 참고
    - 대신 CLI 명령어 사용 및 윈도우 매니저별 방식으로 실행 권장
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- CLI 명령어
  - `gauntlet open`

### 플러그인 설치

플러그인은 설정 UI에서 설치할 수 있습니다. 플러그인 Git 저장소 URL을 입력해 설치, 예: `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### 플러그인 직접 만들기

[플러그인 개발 시작하기](https://gauntlet.sh/docs/plugin-development/getting-started) 참고

## 테마 적용

[테마 적용](https://gauntlet.sh/docs/theming) 참고

## Gauntlet 빌드

필요한 도구:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (프로젝트 자체에서 직접 사용하지 않지만, 종속성 때문에 필요)
- Linux의 경우: `libxkbcommon-dev` (배포판에 따라 패키지 이름이 다를 수 있음)

### 개발 환경

개발 빌드는 아래와 같이 실행:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
개발 모드(“release” 기능 미포함)에서는 상태나 캐시 저장에 프로젝트 디렉터리 내부 디렉터리만 사용하여, 전역 설치 환경에 영향을 주지 않음

### 패키징 전 빌드

패키징되지 않은 릴리즈 바이너리 빌드는 다음과 같이 실행:
```bash
npm ci
npm run build
cargo build --release --features release
```

### 패키지 빌드
운영체제별 패키지 빌드는 다음 중 하나를 실행:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

단, 새 버전 릴리즈는 GitHub Actions를 통해 진행해야 함

## 기여하기

Gauntlet 개발에 참여하고 싶다면 코드 기여 외에도 다양한 방식이 있습니다:
- 버그 또는 UI/UX 문제 제보
- 플러그인 제작

간단한 문제라면 이슈 또는 PR을 자유롭게 올려 직접 해결해도 됩니다. 
더 큰 변경이 필요할 경우, 먼저 Discord(README 상단 초대 링크)에서 제작자와 상의해 주세요.

모든 기여를 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---