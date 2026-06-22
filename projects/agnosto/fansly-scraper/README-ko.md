# Fansly 스크레이퍼

> [!IMPORTANT]
> **프로젝트 상태 업데이트**
>
> 최근 건강 문제로 인해 이 프로젝트는 제 인생에서 매우 후순위로 밀려났습니다. 당분간 업데이트와 지원이 매우 제한적일 것입니다. 이해해 주셔서 감사합니다.
>
> 더 활발하게 유지 관리되며 완전한 웹 UI, 실시간 대시보드 및 VOD 플레이어, 자동 백그라운드 모니터링 및 아카이빙 기능을 원하신다면, **[Accerso](https://accesro.one)**를 확인해 보세요.

> [!WARNING]
> **‼️ 윈도우 디펜더 오탐지** (정확히 왜, 어디서 발생했는지 전혀 알 수 없음)
>
> 이 프로그램의 윈도우 실행 파일은 윈도우 디펜더 및 다른 백신에서 자주 **`Trojan:Script/Wacatac.B!ml`**로 탐지됩니다. 이는 **오탐지**입니다.
>
> **왜 이런 일이 발생할까요?**
> 탐지 이름의 `!ml`은 사람이 아닌 머신러닝 모델에 의해 탐지되었음을 의미합니다. 이 프로그램은 서명되지 않은 오픈 소스 스크레이퍼 도구이고 많은 인터넷 요청을 하므로 자동 시스템이 이를 의심스럽다고 잘못 판단합니다. 이는 Go 및 Rust 기반 커맨드라인 도구에서 흔히 발생하는 문제입니다.
>
> **권장 해결책 - Go를 통해 설치 (백신 문제를 우회할 수 있음):**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **할 수 있는 일:**
> 1.  **프로그램을 신뢰하세요:** 윈도우 디펜더를 일시적으로 비활성화하여 프로그램을 다운로드하고 실행한 후 예외로 추가할 수 있습니다.
> 2.  **소스에서 빌드하세요:** Go가 설치되어 있다면 직접 빌드할 수 있습니다. 로컬에서 컴파일하거나 go로 설치하면 탐지되지 않습니다.
>
> 코드는 완전히 오픈 소스이므로 검토할 수 있습니다. 사용해도 안전하지만 백신 경고가 걱정될 수 있다는 점은 이해합니다.

Fansly 크리에이터의 콘텐츠를 다운로드하고 모니터링하는 간단한 올인원 도구입니다.

> **⚠️ 현재 개발 중** - 일부 기능은 완벽하게 작동하지 않을 수 있습니다. 아래 [알려진 문제](#known-issues)를 참고하세요.


## 요구 사항

- **선택 사항이지만 강력히 권장됨**: 라이브 스트림 녹화 및 고화질 비디오 저장을 위한 [ffmpeg](https://ffmpeg.org/). 윈도우에서 시스템 경로에 설치하려면 [이 가이드](https://phoenixnap.com/kb/ffmpeg-windows)를 따르세요.
- **선택 사항**: 더 나은 컨택트 시트를 위한 [mt](https://github.com/mutschler/mt)

## 빠른 시작

### 1. 다운로드
- **쉬운 방법**: [다운로드 페이지](https://agnosto.github.io/projects/fansly-scraper/) 방문 (시스템 자동 감지)
- **수동 방법**: [GitHub 릴리스](https://github.com/agnosto/fansly-scraper/releases)에서 받기
- **Go로 설치**:
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. 프로그램 실행하기
```bash
./fansly-scraper
```

첫 실행 시, 설치 마법사가 모든 설정을 도와줍니다. 자동 로그인을 사용하려면 'a'를 누르세요: Fansly가 열리고 DevTools 콘솔에 붙여넣을 한 줄 스니펫이 제공됩니다. 토큰과 사용자 에이전트가 자동으로 캡처되어 설정 파일에 저장됩니다.

## 기본 사용법

### 대화형 모드 (초보자에게 권장)
```bash
./fansly-scraper
```

메인 메뉴에서 할 수 있는 작업:
- 설정 마법사 실행 (저장 위치 선택, 자동 로그인)
- 구성 재설정 (기본값 복원, 마법사 다시 실행)

### 명령줄 모드
```bash
# Download all content from a creator
./fansly-scraper -u {creator-name}

# Download specific content types
./fansly-scraper -u {creator-name} -d [all|timeline|messages|stories]

# Monitor for live streams
./fansly-scraper -m {creator-name}

# Start/stop monitoring
./fansly-scraper monitor [start|stop]
```

**참고**: 실시간 모니터링은 터미널 세션을 활성 상태로 유지해야 합니다. 백그라운드에서 모니터링을 실행하려면 Linux/WSL에서 [tmux](https://github.com/tmux/tmux/wiki) 또는 [zellij](https://github.com/zellij-org/zellij)와 같은 터미널 멀티플렉서를 사용하는 것을 고려하세요. v0.6.3부터는 기존 모니터 프로세스를 재시작하지 않고 별도의 터미널 인스턴스에서 `-m creator`를 실행하여 추가 크리에이터를 모니터링할 수 있습니다.

### 프로그램 업데이트
```bash
./fansly-scraper update
```
## 프로젝트 로드맵 및 고급 설정

우리의 개발 진행 상황은 **[프로젝트 로드맵](https://github.com/users/agnosto/projects/1)**에서 공개적으로 추적됩니다. 우리가 현재 작업 중인 내용, 미래 계획, 그리고 토론에 참여할 수 있습니다.

- **설정 가이드**: **[공식 위키](https://github.com/agnosto/fansly-scraper/wiki)** 참조
- **소스에서 빌드하기**:

  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```
## 기여하기

기여는 언제나 환영하며 매우 감사드립니다! 버그 보고, 기능 제안 또는 풀 리퀘스트 제출 등 어떤 형태든 여러분의 도움이 소중합니다.

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

시작하기 전에 [기여 지침](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md)을 꼭 읽어주세요.  
[이슈 탭](https://github.com/agnosto/fansly-scraper/issues)에서 관심 있는 작업이 있는지 확인해 보세요.

## 알려진 문제

- **재다운로드**: v0.8.3부터 파일 명명 규칙이 변경되어 미디어가 재다운로드될 수 있습니다.  
- **채팅 녹화**: 재연결 시 가끔 메시지가 누락될 수 있습니다.  
- **MacOS 사용자**: [시스템 설정](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049)에서 알림 허용이 필요할 수 있습니다.  
- **라이브 상태**: TUI에서 `r` 키를 눌러 라이브 상태를 새로고침하세요.  
- **중복 파일**: Fansly API 구조로 인해 같은 이미지가 두 번 나타날 수 있습니다.  
- **라이브스트림 파일명 날짜 형식**: 스트림이 중단되고 재녹화 시도 시, 날짜 형식이 구체적이지 않으면 (예: 타임스탬프 없음) 두 VOD가 같은 이름이 되어 저장에 실패할 수 있습니다. 현재는 다음 형식 중 하나를 사용하세요: `2006-01-02_15:04:05` 또는 `20060102_150405`

## 프로젝트 지원하기

이 도구가 도움이 되었다면 깃허브 후원을 고려해 주세요:

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

또는 암호화폐를 통한 일회성 기부도 가능합니다:

<table>
  <tr>
    <td align="center"><strong>비트코인 (BTC)</strong></td>
    <td align="center"><strong>솔라나 (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Bitcoin QR Code" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">

      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="솔라나 QR 코드" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **면책 조항**: 이 도구는 Fansly 또는 Select Media LLC와 관련이 없습니다. 사용은 전적으로 사용자 책임입니다. 이 스크립트 개발자는 최종 사용자의 행동이나 최종 사용자의 계정에 발생할 수 있는 결과에 대해 책임지지 않습니다. 사용은 전적으로 사용자 책임입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---