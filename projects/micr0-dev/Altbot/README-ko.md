<div align="center">
  <img src="https://raw.githubusercontent.com/micr0-dev/Altbot/main/assets/micr0-alty-banner.png" alt="밝은 배경에 작은 보라색 로봇 아이콘이 반복되는 패턴으로 레트로 기술 배경화면 효과를 연출한 장식 배너">

# Altbot アクセシビリティロボット

_페디버스를 한 이미지씩 더 포용적으로 만드는_

[![Latest Release](https://img.shields.io/github/v/release/micr0-dev/Altbot)](https://github.com/micr0-dev/Altbot/releases)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)
[![License: AGPLv3](https://img.shields.io/badge/License-AGPLv3-blue.svg)](https://www.gnu.org/licenses/agpl-3.0)
[![Go Version](https://img.shields.io/github/go-mod/go-version/micr0-dev/Altbot)](https://go.dev/)
![Status](https://img.shields.io/badge/status-active-success)
![Environment](https://img.shields.io/badge/environment-friendly-green)

</div>

## 소개

Altbot은 이미지, 비디오, 오디오에 대한 대체 텍스트 설명을 생성하여 페디버스를 향상시키는 오픈 소스 접근성 봇입니다. 이는 시각 장애가 있는 사용자가 콘텐츠를 더 쉽게 이용할 수 있도록 돕습니다.

## 개인정보 보호 및 GDPR 준수

**Altbot 2.0은 이제 모든 처리를 100% 로컬에서 수행하며 데이터는 전혀 저장하지 않습니다!** [![Mastodon Follow](https://img.shields.io/mastodon/follow/113183205946060973?domain=fuzzies.wtf&style=social)](https://fuzzies.wtf/@altbot)

GDPR 준수를 위해 Altbot은 사용자 요청을 처리하기 전에 명시적이고 사전 동의를 요구합니다. 처음 상호작용할 때 데이터 수집 관행에 대한 정보와 [개인정보 보호정책](https://raw.githubusercontent.com/micr0-dev/Altbot/main/PRIVACY.md) 링크가 포함된 동의 요청을 받게 됩니다.

- **수집하는 정보:** 요청 시각, 처리 시간, 언어 선호도, 미디어 유형
- **수집하지 않는 정보:** 이미지, 개인 정보, 게시물 내용
- **동의 철회 방법:** 봇 계정을 차단하기만 하면 됩니다

게시물 내용은 절대 저장되거나 공유되지 않습니다. 기존 대체 텍스트가 없는 이미지에만 처리하며 모든 처리는 로컬 서버에서 비공개로 이루어집니다.

## 면책 조항

대체 텍스트는 대형 언어 모델(LLM)을 사용해 생성됩니다. 정확성을 위해 노력하지만 결과가 사실과 다를 수 있으므로 항상 대체 텍스트를 다시 확인하시기 바랍니다.

## 작동 방식

Altbot은 마스토돈에서 멘션과 팔로우를 감지합니다. 멘션이나 팔로우하는 사용자의 새 게시물을 감지하면 대체 텍스트가 없는 이미지를 확인합니다. 이미지가 발견되면 대형 언어 모델(LLM)을 사용해 설명 대체 텍스트를 생성하고 생성된 텍스트로 답글을 작성합니다.

### 기능

- **멘션 기반 대체 텍스트 생성:** 이미지, 비디오 또는 오디오가 포함된 게시물에 답글로 @Altbot을 멘션하면 Altbot이 대체 텍스트 설명을 생성합니다.
- **팔로워 자동 대체 텍스트:** @Altbot을 팔로우하면 사용자의 게시물을 모니터링합니다. 이미지, 비디오 또는 오디오에 대체 텍스트가 없으면 Altbot이 자동으로 생성합니다.
- **로컬 LLM 지원:** Ollama를 통해 로컬 LLM을 사용하여 대체 텍스트 설명을 생성할 수 있습니다.
- **GDPR 준수:** 요청 처리 전에 사용자의 명시적 동의를 요구하는 명확한 데이터 사용 정보를 포함한 동의 시스템을 제공합니다.
- **동의 요청:** 비원본 게시자가 멘션할 경우, 대체 텍스트를 생성하기 전에 원본 게시자의 동의를 요청합니다.
- **설정 가능:** TOML 파일을 사용하여 봇을 쉽게 구성할 수 있습니다.

## 설정

### 표준

1. 저장소를 클론합니다:

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. 설치 마법사 실행:

   ```sh
   go run .
   ```
   설정 마법사는 다음을 포함하여 봇에 필요한 필수 값 구성을 안내합니다:

   - Mastodon 서버 URL, 클라이언트 비밀키, 액세스 토큰 및 봇 사용자 이름.
   - 관리 알림을 위한 관리자 연락처 핸들.
   - 메트릭 및 대체 텍스트 알림과 같은 선택적 기능 활성화.

   또는 예제 구성 파일을 복사하여 수동으로 편집하세요:


   ```sh
   cp example.config.toml config.toml
   ```

3. 봇 실행:
   ```sh
   go run .
   ```

### 도커

1. 저장소를 클론합니다:

   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```
2. 설치 마법사를 실행합니다:


   ```sh
   docker run -it -v ./:/data --rm ghcr.io/micr0-dev/altbot:latest
   ```

   설정 마법사는 봇에 필요한 필수 값을 구성하는 과정을 안내합니다:

   - Mastodon 서버 URL, 클라이언트 비밀, 액세스 토큰 및 봇 사용자 이름.
   - 관리 알림을 위한 관리자 연락처 핸들.
   - 메트릭 및 대체 텍스트 알림과 같은 선택적 기능 활성화.

   또는 예제 구성 파일을 복사하여 수동으로 편집할 수 있습니다:

   ```sh
   cp example.config.toml config.toml
   ```

3. 봇 실행:
   ```sh
   docker compose up -d
   ```
## 개발 환경 설정

### 필수 조건

- **Go 1.24 이상**: [go.dev](https://go.dev/dl/)에서 설치하세요
- **LLM 제공자** (다음 중 하나):
  - **Gemini API**: [Google AI Studio](https://aistudio.google.com/app/apikey)에서 API 키를 받으세요
  - **Ollama**: [ollama.ai](https://ollama.ai/)에서 설치하고 비전 모델을 불러오세요 (예: `ollama pull llava-phi3`)
  - **Transformers**: Python과 transformers 라이브러리, 호환 가능한 GPU 필요

### 시작하기

1. 저장소를 클론하세요:


   ```sh
   git clone https://github.com/micr0-dev/Altbot.git
   cd Altbot
   ```

2. 종속 항목 설치:

   ```sh
   go mod download
   ```
3. 구성 파일 복사 및 구성:


   ```sh
   cp example.config.toml config.toml
   # Edit config.toml with your LLM API and model of choice
   ```

4. 봇 실행:
   ```sh
   go run .
   ```

### 개발 모드

`--dev` 플래그를 사용하여 봇을 개발 모드로 실행합니다. 이는 마스토돈에 게시하지 않고 테스트할 수 있는 대화형 명령줄 인터페이스를 제공합니다:

```sh
go run . --dev
```
**참고:** 개발자 모드에서는 Mastodon 인증을 건너뛰지만, 이미지/비디오/오디오 처리를 테스트하려면 `config.toml`에 유효한 LLM API(Gemini, Ollama 등)를 구성해야 합니다.

#### 개발자 모드 명령어

| 명령어           | 설명                                               |
| -------------- | -------------------------------------------------- |
| `/image <url>` | 이미지 URL을 처리하고 대체 텍스트 생성                  |
| `/video <url>` | 비디오 URL을 처리하고 대체 텍스트 생성                  |
| `/audio <url>` | 오디오 URL을 처리하고 대체 텍스트 생성                  |
| `/lang [code]` | 응답 언어 설정/보기 (예: en, de, ja)                   |
| `/follow`      | 팔로우 이벤트 시뮬레이션                               |
| `/status`      | 현재 개발자 모드 상태 표시                             |
| `/help`        | 사용 가능한 명령어 표시                               |
| `/quit`        | 개발자 모드 종료                                     |

URL을 직접 붙여넣어 이미지로 처리할 수도 있습니다.

**예시 세션:**


```
[dev] > /lang de
Language set to: de

[dev] > https://example.com/image.jpg
Processing image: https://example.com/image.jpg
Please wait...

=== Generated Alt-Text ===
Ein Foto von...
```

### 빌딩

```sh
go build -o altbot .
```
## 기여하기

기여를 환영합니다! 개선 사항이 있으면 이슈를 열거나 풀 리퀘스트를 제출해 주세요.

## 지원 / 커뮤니티

질문이 있으신가요? 대화하고 싶으신가요? [chat.micr0.dev](https://chat.micr0.dev)에서 저희와 함께하세요.

채널: 프로젝트 토론은 #dev, 지원은 #help

IRC: irc.micr0.dev (포트 6667/6697)

## 감사 인사

### 특별 감사

이 여정 내내 저를 격려해 준 **Henrik Schönemann** ([@Schoeneh](https://github.com/Schoeneh))께 깊은 감사를 드립니다. 비판을 다루고 이를 건설적인 피드백으로 전환하는 데 그의 도움이 매우 귀중했습니다. 그의 지원과 안내 없이는 오늘의 제가 없었을 것입니다.

### 코피 후원자

모든 [Ko-fi](https://ko-fi.com/) 후원자분들께 진심으로 감사드립니다! 여러분의 관대한 기부가 Altbot을 운영하고 지속적으로 개선하는 데 큰 도움이 됩니다. 여러분의 지원은 저에게 큰 의미이며, 페디버스를 모두에게 더 접근하기 쉬운 공간으로 만드는 데 기여합니다.

## 라이선스

이 프로젝트는 [GNU AFFERO GENERAL PUBLIC LICENSE Version 3 (AGPLv3).](https://www.gnu.org/licenses/agpl-3.0.en.html) 아래에 라이선스가 부여되어 있습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

모두를 위한 더 포괄적인 페디버스를 만드는 데 함께하세요!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-28

---