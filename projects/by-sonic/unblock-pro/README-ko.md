# UnblockPro — Discord 및 YouTube 차단 우회


<p align="center">
  <strong>macOS 및 Windows용 자동 DPI 우회</strong><br>
  한 번의 클릭으로 Discord, YouTube 및 기타 서비스 차단 해제
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Downloads"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="License"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Platform">
</p>

---

## 다운로드

| 플랫폼 | 파일 | 설명 |
|-----------|------|----------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | M 프로세서 탑재 Mac용 |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Intel 탑재 Mac용 |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | 설치 프로그램 |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | 포터블 버전 (설치 불필요) |

> [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) 페이지로 이동해 귀하의 OS에 맞는 버전을 다운로드하세요

---

## 이게 뭔가요?

**UnblockPro**는 VPN 없이 Discord, YouTube 및 기타 서비스를 사용할 수 있게 해주는 DPI 차단 우회 데스크탑 애플리케이션입니다. macOS 및 Windows에서 작동합니다.

### 주요 기능

- **원클릭** — ‘연결’ 버튼만 누르면 바로 작동
- **자동 전략 선택** — 애플리케이션이 귀하의 ISP에 맞는 우회 방법을 자동으로 탐색
- **연결 확인** — 실제 요청을 통해 전략을 검증, 추측이 아님
- **macOS + Windows** — 두 플랫폼 모두 완벽 지원
- **자동 실행** — 시스템과 함께 시작됩니다
- **자동 연결** — 시작 시 자동으로 연결됩니다
- **시스템 트레이** — 백그라운드에서 작동하며 방해하지 않습니다
- **안전한 정리** — 종료 시 프록시 설정이 자동으로 초기화됩니다

---

## 작동 원리

UnblockPro는 Deep Packet Inspection(DPI) 우회를 위해 [zapret](https://github.com/bol-van/zapret) 기술을 사용합니다:

| 플랫폼 | 방법 |
|--------|-------|
| **macOS** | `tpws` — 패킷 변조가 포함된 SOCKS5 프록시. 애플리케이션이 시스템 프록시를 자동으로 설정합니다 |
| **Windows** | `winws` — WinDivert를 통한 드라이버 수준 패킷 가로채기. 프록시 설정이 필요 없습니다 |

애플리케이션은 여러 전략(split+disorder, split-tls, methodeol, oob 등)을 순차적으로 테스트하여 귀하의 제공업체에 작동하는 방법을 찾습니다.

---

## 설치

### macOS

1. [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)에서 `UnblockPro-*-mac.zip` 파일을 다운로드하세요
2. ZIP을 풀고 `UnblockPro.app`을 '응용 프로그램' 폴더로 드래그하세요
3. **터미널을 열고** 다음 명령어를 실행하세요:

```bash
xattr -cr /Applications/UnblockPro.app
```
4. 앱을 실행하고 "연결"을 클릭하세요

> **이 명령어가 필요한 이유는?** macOS는 유료 Apple Developer 서명($99/년)이 없는 앱을 차단합니다. `xattr -cr` 명령은 격리 플래그를 제거하는데, 이는 안전하며 프로젝트 코드가 완전히 공개되어 있습니다. Intel 및 Apple Silicon (M1/M2/M3)에서 작동합니다.

### Windows

1. [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)에서 설치 프로그램 또는 포터블 버전을 다운로드하세요
2. 관리자 권한으로 실행하세요
3. "연결"을 클릭하세요

> **중요:** Windows에서는 WinDivert 작동을 위해 관리자 권한이 필요합니다

---

## 스크린샷

<p align="center">
  <em>메인 화면 — 연결 상태, 한 번의 클릭으로 제어</em>
</p>

---

## FAQ

<details>
<summary><strong>이것이 VPN인가요?</strong></summary>
아니요. UnblockPro는 트래픽을 암호화하거나 원격 서버를 통해 라우팅하지 않습니다. 로컬에서 네트워크 패킷을 수정하여 ISP의 DPI 시스템이 Discord/YouTube 요청을 인식하고 차단하지 못하게 합니다.
</details>

<details>
<summary><strong>안전한가요?</strong></summary>
네. 이 앱은 오픈 소스이며 데이터를 수집하지 않고, 트래픽을 제3자 서버로 전송하지 않습니다. 모든 코드는 감사할 수 있도록 공개되어 있습니다.
</details>

<details>
<summary><strong>앱이 크래시되면 어떻게 하나요?</strong></summary>
프록시 설정은 정상 종료, 비정상 종료 또는 강제 종료 시 자동으로 초기화됩니다. 다음 실행 시에도 설정이 신뢰성을 위해 초기화됩니다.
</details>


<details>
<summary><strong>Discord/YouTube가 여전히 작동하지 않음</strong></summary>
다시 연결을 시도해 보세요 — 앱이 다른 전략을 시도할 것입니다. 어떤 것도 도움이 되지 않으면, 아마도 귀하의 제공업체가 고급 DPI를 사용 중일 수 있습니다 — 이슈를 생성하세요.
</details>

<details>
<summary><strong>macOS: «파일이 열리지 않았습니다» / Gatekeeper</strong></summary>

터미널을 열고 다음을 실행하세요:
```bash
xattr -cr /Applications/UnblockPro.app
```
이후 애플리케이션이 정상적으로 실행됩니다. 이 작업은 한 번만 하면 됩니다.

`.zip` 파일을 다운로드하여 다른 폴더에 압축을 푼 경우, `/Applications/UnblockPro.app` 대신 `.app` 경로를 지정하세요.
</details>

---

## 개발

```bash
# Клонировать репозиторий
git clone https://github.com/by-sonic/unblock-pro.git
cd unblock-pro

# Установить зависимости
npm install

# Запустить в режиме разработки
npm start

# Собрать для текущей ОС
npm run build

# Собрать для macOS
npm run build:mac

# Собрать для Windows
npm run build:win
```

---

## 스택

- **Electron** — 크로스플랫폼 프레임워크
- **zapret** — DPI 우회 엔진 ([bol-van/zapret](https://github.com/bol-van/zapret))
- **electron-builder** — 빌드 및 배포
- **GitHub Actions** — 릴리즈 시 자동 빌드

---

## 라이선스

[MIT](LICENSE) — 자유 사용, 수정 및 배포.

---

<p align="center">
  <strong>by sonic</strong><br>
  <sub>프로젝트가 도움이 되었다면 ⭐️를 눌러주세요</sub>
</p>

---

### 주요 키워드 / Keywords

> discord 차단해제, youtube 차단해제, discord 차단 우회, youtube 차단 우회, dpi 우회, 안티차단, discord 차단 해제, discord 러시아, youtube 러시아, zapret gui, dpi 우회, discord unblock russia, youtube unblock russia, anti dpi, bypass discord block, unblock discord, unblock youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---