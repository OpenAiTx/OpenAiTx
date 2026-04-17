# CreamLinux

CreamLinux는 Steam 게임의 DLC ID 관리를 간소화하는 Linux용 GUI 애플리케이션입니다. 네이티브 Linux 게임용 CreamAPI와 Proton을 통해 실행되는 Windows 게임용 SmokeAPI를 설치하고 구성할 수 있는 사용자 친화적인 인터페이스를 제공합니다.

## 데모 보기:

[![데모 보기](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/./src/assets/screenshot1.png)](https://www.youtube.com/watch?v=neUDotrqnDM)

## 베타 상태

⚠️ **중요**: CreamLinux는 현재 베타 단계입니다. 이는 다음을 의미합니다:

- 일부 기능이 미완성이거나 변경될 수 있음
- 버그나 예상치 못한 동작이 발생할 수 있음
- 애플리케이션이 활발히 개발 중임
- 여러분의 피드백과 버그 보고가 매우 중요함

핵심 기능은 작동 중이지만, 이는 초기 릴리스임을 유의하시기 바랍니다. 안정성 향상, 기능 추가, 사용자 경험 개선을 위해 지속적으로 작업하고 있습니다. 문제를 발견하면 [GitHub 이슈 페이지](https://github.com/Novattz/creamlinux-installer/issues)에 보고해 주세요.

## 기능

- **자동 탐지**: 시스템에 설치된 Steam 게임을 자동으로 찾음
- **네이티브 지원**: 네이티브 Linux 게임용 CreamLinux 설치
- **Proton 지원**: Proton을 통해 실행되는 Windows 게임용 SmokeAPI 설치
- **DLC 관리**: 활성화할 DLC를 쉽게 선택 가능
- **모던 UI**: 깔끔하고 반응형이며 사용하기 쉬운 인터페이스

## 설치

### AppImage (권장)

1. [릴리스](https://github.com/Novattz/creamlinux-installer/releases) 페이지에서 최신 `creamlinux.AppImage`를 다운로드하세요
2. 실행 가능하도록 만드세요:
   ```bash
   chmod +x creamlinux.AppImage
   ```
3. 실행하세요:

   ```bash
   ./creamlinux.AppImage
   ```
   Nvidia 사용자는 이 명령어를 사용하세요:


   ```
   WEBKIT_DISABLE_DMABUF_RENDERER=1 ./creamlinux.AppImage
   ```
### 소스에서 빌드하기

#### 필수 조건

- Rust 1.77.2 이상
- Node.js 18 이상
- webkit2gtk-4.1 (데비안의 경우 libwebkit2gtk-4.1)
- npm 또는 yarn

#### 단계

1. 저장소를 클론합니다:


   ```bash
   git clone https://github.com/Novattz/creamlinux-installer.git
   cd creamlinux-installer
   ```
2. 종속성 설치:


   ```bash
   npm install # or yarn
   ```

3. 애플리케이션 빌드:

   ```bash
   NO_STRIP=true npm run tauri build
   ```
4. 컴파일된 바이너리는 `src-tauri/target/release/creamlinux`에서 사용할 수 있습니다.

### 데스크탑 통합

AppImage 버전을 사용하는 경우, 데스크탑 환경에 통합할 수 있습니다:

1. 데스크탑 엔트리 파일을 만듭니다:


   ```bash
   mkdir -p ~/.local/share/applications
   ```
2. `~/.local/share/applications/creamlinux.desktop` 파일을 다음 내용으로 생성하세요 (AppImage 경로를 조정하세요):


   ```
   [Desktop Entry]
   Name=Creamlinux
   Exec=/absolute/path/to/CreamLinux.AppImage
   Icon=/absolute/path/to/creamlinux-icon.png
   Type=Application
   Categories=Game;Utility;
   Comment=DLC Manager for Steam games on Linux
   ```
3. 데스크탑 데이터베이스를 업데이트하여 creamlinux가 앱 실행기에 나타나도록 합니다:


```bash
update-desktop-database ~/.local/share/applications
```
## 문제 해결

### 일반적인 문제

- **게임이 로드되지 않음**: Steam에서 실행 옵션이 올바르게 설정되었는지 확인하세요
- **DLC가 나타나지 않음**: 게임 목록을 새로고침하고 재설치해 보세요
- **Steam을 찾을 수 없음**: Steam이 설치되어 있고 최소 한 번 실행했는지 확인하세요

### 디버그 로그

로그는 다음 위치에 저장됩니다: `~/.cache/creamlinux/creamlinux.log`

## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/LICENSE.md) 파일을 참조하세요.

## 크레딧

- [Creamlinux](https://github.com/anticitizn/creamlinux) - 네이티브 지원
- [SmokeAPI](https://github.com/acidicoala/SmokeAPI) - Proton 지원
- [Tauri](https://tauri.app/) - 데스크톱 애플리케이션 개발 프레임워크
- [React](https://reactjs.org/) - UI 라이브러리



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---