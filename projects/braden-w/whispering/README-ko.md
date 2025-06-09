<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">OpenAI의 Whisper 모델이 구동하는 원활한 음성 받아쓰기</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## 소개

Whispering은 글로벌 음성 인식 및 텍스트 변환 기능을 제공하는 오픈소스 받아쓰기 애플리케이션입니다. 키보드 단축키, 자동 복사 및 붙여넣기 등 받아쓰기를 최대한 원활하게 해주는 다양한 옵션을 제공합니다.

내부적으로는 OpenAI의 Whisper 모델을 사용하여 내장된 받아쓰기보다 훨씬 더 높은 정확도를 자랑합니다.

> **중요 안내**: Whispering은 주로 받아쓰기(음성 텍스트 변환) 도구로 설계되었으며, 녹음 도구가 아닙니다. 신뢰성이 중요한 장시간 녹음의 경우, 네이티브 녹음 API를 사용하는 휴대폰이나 기기의 전용 녹음 앱을 사용하는 것이 좋습니다. 이를 통해 최적의 음질과 녹음 안정성을 보장할 수 있습니다.

## 데모

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## 주요 기능

1. **글로벌 받아쓰기**: 글로벌 키보드 단축키 또는 두 번의 클릭만으로 Whisper의 음성 인식 및 텍스트 변환 기능을 어디서나 사용할 수 있습니다.
2. **크로스 플랫폼 경험**:
   - 데스크톱 앱: 모든 애플리케이션에서 글로벌 받아쓰기가 가능합니다.
   - 브라우저 확장 프로그램: 웹 앱과 통신하여 브라우저 내에서 글로벌 받아쓰기를 제공합니다.
3. **챗봇 연동**: 브라우저 확장은 ChatGPT 및 Claude 웹사이트에 녹음 버튼을 추가하여, 채팅 인터페이스에서 직접 음성 입력 및 받아쓰기를 할 수 있습니다.
4. **받아쓰기 관리**: Whispering 앱 내에서 받아쓴 내용을 검토하고 편집하여 정확성과 명확성을 확보할 수 있습니다.
5. **자동 클립보드 연동**: 받아쓰기가 완료되면 텍스트가 자동으로 클립보드에 복사됩니다. 자동 붙여넣기 옵션도 제공합니다.

## 내 데이터는 어떻게 저장되나요?

Whispering은 녹음 파일과 텍스트 받아쓰기 등 가능한 모든 데이터를 사용자의 기기 내에 로컬로 저장합니다. 이 방식은 최대한의 프라이버시와 데이터 보안을 보장합니다. 데이터 처리 방식은 다음과 같습니다:

1. **로컬 저장소**: 음성 녹음과 받아쓰기 텍스트는 IndexedDB에 저장되며, 이는 블롭(Blob) 저장소로 사용되어 모든 텍스트와 받아쓰기 데이터를 보관합니다.

2. **받아쓰기 서비스**: 외부로 전송되는 데이터는 받아쓰기 서비스로 전송되는 녹음 파일뿐입니다(선택 시). 선택 가능한 옵션은 다음과 같습니다:
   - OpenAI 또는 Groq 등 외부 서비스
   - 모든 작업을 기기 내에서 처리하는 `faster-whisper-server`와 같은 로컬 받아쓰기 서비스

3. **설정 가능**: 설정에서 받아쓰기 서비스를 변경하여 최대한 로컬 기반으로 동작하도록 할 수 있습니다.


## 설치 방법

### 웹 앱

최신 버전의 `apps/app` 폴더가 Vercel에 호스팅되어 있는 [whispering.bradenwong.com](https://whispering.bradenwong.com/)을 방문하세요.

### 크롬 확장 프로그램

크롬 웹스토어에서 [여기](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo)에서 크롬 확장 프로그램을 설치하세요.

### 데스크톱 앱

Whispering 데스크톱 앱을 다운로드 및 설치하려면, 운영체제별 안내를 따라주세요:

#### Windows

1. [최신 릴리즈 페이지](https://github.com/braden-w/whispering/releases)에서 `.msi`로 끝나는 설치 패키지를 다운로드합니다.
2. 다운로드한 `.msi` 파일을 실행하여 설치를 시작합니다.
3. 보안 경고가 뜨는 경우, `추가 정보(More Info)` -> `그래도 실행(Run Anyway)`을 클릭하여 설치를 계속합니다.
4. 안내에 따라 설치를 완료하세요.

#### macOS

macOS에서는 다음 단계를 따라 Whispering을 설치하세요:

1. **설치 패키지 다운로드**:
   - [최신 릴리즈 페이지](https://github.com/braden-w/whispering/releases)를 방문합니다.
   - 알맞은 패키지를 선택합니다:
     - Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Intel: `Whispering_x.x.x_x64.dmg`

2. **애플리케이션 설치**:
   - 다운로드한 `.dmg` 파일을 엽니다.
   - Whispering 앱을 Applications 폴더로 드래그합니다.

3. **Whispering 실행**:
   - Applications 폴더에서 Whispering을 엽니다.
   - "확인되지 않은 개발자" 경고가 뜨면:
     - `취소(Cancel)`를 클릭
     - Finder에서 앱을 우클릭한 뒤 `열기(Open)`를 선택

4. **문제 해결** (Apple Silicon만 해당):
   `"Whispering"이 손상되어 열 수 없습니다`라는 오류가 발생할 경우:
   - 터미널을 엽니다
   - 다음 명령어를 실행합니다:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - 다시 애플리케이션을 실행해 보세요

이 과정을 완료하면 macOS에서 Whispering을 사용할 수 있습니다.

#### Linux

Linux에서는 여러 가지 설치 옵션이 제공됩니다. 환경에 맞는 방법을 선택하세요:

1. **AppImage**:

   - [최신 릴리즈 페이지](https://github.com/braden-w/whispering/releases)에서 `.AppImage` 파일을 다운로드합니다.
   - 파일을 실행 가능하게 만듭니다:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - AppImage를 실행합니다:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB 패키지 (Debian/Ubuntu)**:
   - [최신 릴리즈 페이지](https://github.com/braden-w/whispering/releases)에서 `.deb` 파일을 다운로드합니다.
   - `dpkg`로 패키지를 설치합니다:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - 의존성 문제 해결:
     ```bash
     sudo apt-get install -f
     ```

설치가 완료되면 앱을 바로 사용할 수 있습니다.

## 사용법

### 크롬 확장 프로그램

크롬 확장 프로그램을 설치하면, 크롬 확장 도구 모음에 Whispering 아이콘이 나타납니다. 이 아이콘을 클릭하여 확장을 열고, 마이크 버튼을 클릭해 음성을 녹음한 뒤, 정지 버튼(네모)을 클릭하세요. 받아쓰기 결과가 아래 텍스트 박스에 표시됩니다.

ChatGPT나 Claude 기능을 사용하려면 해당 웹페이지로 이동하세요. 채팅 인터페이스에 새 녹음 버튼이 나타납니다. 이 버튼을 클릭하여 녹음을 시작/종료할 수 있으며, 받아쓰기된 텍스트가 자동으로 채팅 입력란에 삽입됩니다.

단축키 기능을 사용하려면 <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> 또는 <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (나중에 크롬 확장 프로그램 단축키에서 설정 가능)을 누르면 어떤 웹사이트에서든 바로 녹음이 시작됩니다. 받아쓰기 결과는 자동으로 클립보드에 복사되고, 현재 입력란에 붙여넣기 됩니다.

크롬 확장 프로그램은 [whispering.bradenwong.com](https://whispering.bradenwong.com)과 통신하며, 해당 탭이 없으면 백그라운드에서 자동으로 생성하려 시도합니다. 대부분의 버그는 이 통신이 실패할 때 발생하며, 간혹 탭이 절전 모드로 전환되는 경우 등이 있습니다.

### 웹 앱

웹 앱은 [whispering.bradenwong.com](https://whispering.bradenwong.com)에서 접근할 수 있습니다. 마이크 버튼을 클릭해 음성을 녹음한 뒤, 정지 버튼을 클릭하세요. 받아쓰기 결과가 텍스트 박스에 표시됩니다.

### 데스크톱 앱

Whispering 데스크톱 앱을 설치한 후, <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (설정에서 변경 가능) 단축키로 언제 어디서나 녹음을 시작할 수 있습니다. 받아쓰기 결과는 자동으로 클립보드에 복사되고 붙여넣기 되며, 이 두 기능 모두 설정에서 켜고 끌 수 있습니다.

## 빌드에 사용된 기술

#### 웹 및 데스크톱

Whispering 앱은 다음 기술과 라이브러리를 사용하여 개발되었습니다:

- [Svelte 5](https://svelte.dev): UI 반응성 라이브러리.
- [SvelteKit](https://kit.svelte.dev/docs): 라우팅 및 정적 사이트 생성, 웹사이트 및 Tauri 앱용 프론트엔드 제작에 사용.
- [Tauri](https://tauri.studio/en/docs/intro/): 데스크톱 앱 프레임워크.
- [Effect-TS](https://github.com/Effect-TS/effect): 함수형 프로그래밍을 도입하고, 오류가 함수 시그니처 반환 타입에 포함되는 매우 타입 안전한 함수 작성에 사용.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Svelte 애플리케이션용 단순하고 커스터마이즈 가능한 토스트 라이브러리. Effect-TS의 오류를 `renderAsToast` 함수로 캡처 및 표시.
- [TanStack Table](https://tanstack.com/table): 모든 데이터 테이블을 지원.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): 브라우저에서 대용량 구조화 데이터를 저장하기 위한 저수준 API. Tanstack Table과 동기화됨.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): 주요 UI 컴포넌트 라이브러리.
- [TailwindCSS](https://tailwindcss.com/docs): 빠르게 커스텀 UI를 구축할 수 있는 유틸리티 기반 CSS 프레임워크.
- [Turborepo](https://turborepo.org/): 모노레포 관리. `apps/app`과 `apps/extension`이 동일한 코드베이스를 공유하여 코드 중복을 크게 줄이고, 단일 소스 유지.
- [Rust](https://www.rust-lang.org): 데스크톱 앱 기능 확장(예: 자동 붙여넣기용 `enigo` 크레이트 사용).
- [Vercel](https://vercel.com/): 취미 프로젝트에 적합하며 Turborepo 연동이 잘 되는 호스팅 서비스.
- [Zapsplat.com](https://www.zapsplat.com/): 로열티 프리 사운드 이펙트 라이브러리.

#### 확장 프로그램

Whispering 크롬 확장 프로그램은 다음을 사용해 구축되었습니다:

- [Plasmo](https://docs.plasmo.com/): 크롬 확장 프로그램 구축 프레임워크. [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow)를 사용하여 Whispering 웹사이트와 통신.
- [Effect-TS](https://github.com/Effect-TS/effect): 함수형 프로그래밍 도입 및 타입 안전 함수 작성.
- [React](https://reactjs.org): 크롬 확장용 UI 반응성 라이브러리(Plasmo는 아쉽게도 Svelte 5 미지원).
- [ShadCN](https://github.com/shadcn): 크롬 확장용 UI 컴포넌트 라이브러리.
- [TailwindCSS](https://tailwindcss.com/docs): 사용자 정의 인터페이스를 빠르게 구축할 수 있는 유틸리티 중심 CSS 프레임워크입니다.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): 크롬 확장 프로그램 API입니다.
- [Zapsplat.com](https://www.zapsplat.com/): 로열티 프리 효과음 라이브러리입니다.

## Whispering을 로컬 개발 모드에서 실행하기

로컬 컴퓨터에 프로젝트를 설정하려면 다음 단계를 따르세요:

1. 저장소를 클론합니다: `git clone https://github.com/braden-w/whispering.git`
2. 프로젝트 디렉터리로 이동합니다: `cd whispering`
3. 필요한 의존성을 설치합니다: `pnpm i`

Whispering 데스크톱 앱과 웹사이트를 개발 모드로 실행하려면:

4. 앱 디렉터리로 이동합니다: `cd apps/app`
5. 개발 서버를 실행합니다: `pnpm tauri dev`

데스크톱 앱이 자동으로 열리며 로컬 개발을 시작할 수 있습니다. 웹 앱을 개발하려면 브라우저에서 `http://localhost:5173`으로 접속하세요.

Whispering 크롬 확장 프로그램을 개발 모드로 실행하려면:

4. 확장 프로그램 디렉터리로 이동합니다: `cd apps/extension`
5. 개발 서버를 실행합니다: `pnpm dev --target=chrome-mv3`

크롬 확장 프로그램을 개발하려면, 크롬에서 `chrome://extensions`로 이동해 개발자 모드를 활성화하고, `apps/extension/build/{platform}-{manifest-version}-dev` 폴더를 압축 해제된 확장 프로그램으로 로드하세요.

## 실행 파일 직접 빌드하기

설치 프로그램의 신뢰성에 대해 우려가 있거나 더 많은 제어를 원한다면, 언제든지 직접 실행 파일을 빌드할 수 있습니다. 이 과정은 더 많은 설정이 필요하지만, 기대하는 코드를 직접 실행할 수 있어 오픈소스 소프트웨어의 장점을 누릴 수 있습니다!

### 크롬

1. 확장 프로그램 디렉터리로 이동합니다: `cd apps/extension`
2. 필요한 의존성을 설치합니다: `pnpm i`
3. Plasmo 빌드 실행: `pnpm plasmo build --target=chrome-mv3`
4. 결과물은 `apps/extension/build/chrome-mv3-prod`에서 확인할 수 있으며, 크롬에 압축 해제된 확장 프로그램으로 로드할 수 있습니다.
5. 또는, 크롬 웹스토어 배포용으로 빌드하려면: `pnpm plasmo build --target=chrome-mv3 --release`

### 파이어폭스

1. 확장 프로그램 디렉터리로 이동합니다: `cd apps/extension`
2. 필요한 의존성을 설치합니다: `pnpm i`
3. Plasmo 빌드 실행: `pnpm plasmo build --target=firefox-mv3`
4. 결과물은 `apps/extension/build/firefox-mv3-prod`에서 확인할 수 있으며, 크롬에 압축 해제된 확장 프로그램으로 로드할 수 있습니다.
5. 또는, 크롬 웹스토어 배포용으로 빌드하려면: `pnpm plasmo build --target=firefox-mv3 --release`

### 데스크톱

1. 앱 디렉터리로 이동합니다: `cd apps/app`
2. 필요한 의존성을 설치합니다: `pnpm i`
3. Tauri 빌드 실행: `pnpm tauri build`
4. 실행 파일은 `apps/app/target/release` 디렉터리에서 찾을 수 있습니다.

## 기여하기

커뮤니티의 기여를 환영합니다! Whispering에 기여하고 싶으시다면, 아래의 단계를 따라주세요:

1. 저장소를 포크합니다.
2. 새로운 기능 또는 버그 수정을 위한 브랜치를 생성합니다: `git checkout -b feature/your-feature-name` 또는 `git checkout -b fix/your-bugfix-name`
3. 변경사항을 작성하고, 설명이 포함된 메시지로 커밋합니다.
4. 포크된 저장소에 브랜치를 푸시합니다: `git push origin your-branch-name`
5. 포크된 저장소에서 원본 저장소로 풀 리퀘스트를 생성합니다.

코드가 기존 규칙을 따르고, 충분히 문서화되어 있는지 확인해 주세요.

## 라이선스

Whispering은 [MIT 라이선스](https://opensource.org/licenses/MIT) 하에 배포됩니다.

## 후원자

이 프로젝트는 다음의 멋진 사람들과 단체의 지원을 받고 있습니다:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## 지원 및 피드백

문제가 발생하거나 개선 제안이 있다면 [GitHub 이슈 탭](https://github.com/braden-w/whispering/issues)에 이슈를 남기거나 [whispering@bradenwong.com](mailto:whispering@bradenwong.com)으로 연락해 주세요. 여러분의 피드백을 정말로 소중하게 생각합니다!

Whispering을 이용해 주셔서 감사합니다. 즐거운 글쓰기 되세요!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---