<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE 로고" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# 당신만의 개인 AI OS.

**당신의 OS를 실행하세요.** 당신의 작업을 지켜봅니다. 중요한 것을 기억합니다. 도구와 에이전트 전반에 걸쳐 행동합니다. 오픈소스, 셀프 호스팅, 영원히 당신의 것입니다.

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Website" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Docs" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="License: AGPL 3.0" />
    </a>
</p>
</div>

---

## 작동하는 모습 보기

CORE가 두 가지 코딩 작업을 처음부터 끝까지 처리하는 모습을 확인하세요:

[![CORE Demo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## CORE란 무엇인가

CORE는 AI-기반 업무를 위한 오픈소스 운영 레이어입니다.

해야 할 일을 메모장에 작성하면, CORE가 작업을 인식하고 메모리 및 연결된 앱에서 컨텍스트를 불러오며, 계획을 초안 작성하고, 게이트웨이를 통해 적합한 에이전트를 실행하며, 가능한 장애물을 처리하고, 인간의 판단이 필요할 때 다시 돌아옵니다.

계속해서 프롬프트를 입력하는 챗봇이 아닙니다. 기억하고, 조정하고, 실행하며, 필요시 상위 보고하는 레이어입니다.

### 아키텍처

| | |
|---|---|
| **감시** | MCP를 통한 AI 대화의 컨텍스트, 50개 이상의 연결된 앱, 그리고 Mac에서는 명시적으로 접근 권한을 부여한 모든 앱에서 컨텍스트를 수집합니다. |
| **기억** | 당신이 무엇을 말했는지뿐만 아니라, 무엇을 언제 왜 결정했는지까지 모든 도구와 대화 전반에 걸쳐 추적하는 지식 그래프입니다. |
| **실행** | 연결된 앱에서 직접 작업을 수행하고, 더 긴 작업은 게이트웨이를 통해 코딩 및 브라우저 에이전트에게 위임합니다. |
| **정책** | 승인 흐름, 에스컬레이션 규칙, 계획, 감사 로그로 자율성이 책임감 있게 유지됩니다. |

CORE는 안전하게 할 수 있는 일을 결정하고, 민감한 행동 전에 묻고, 검토 가능한 기록을 남깁니다.

---

## CORE의 실제 활용

### 코딩 작업 위임 후 PR로 돌아오기

CORE에게 해야 할 일을 알려주세요. 리포, 앱, 메모리에서 컨텍스트를 수집하고, 계획을 초안하며, Claude Code나 Codex 세션을 실행하고, 해결 가능한 문제를 처리하며, PR로 결과를 가져옵니다. 완료되면 리뷰하세요.

`[ ] 이슈 #312의 체크아웃 흐름에서 경쟁 조건 수정`

### 자는 동안 백로그 정리하기

정해진 시간에 백로그에서 가져오는 반복 작업을 설정하세요. CORE가 오프라인일 때 작업을 처리합니다. 순조롭게 진행된 작업은 아침에 리뷰 대기, 막힌 세션은 멈춘 탭이 아닌 간결한 질문으로 돌아옵니다.

`[ ] 오늘 밤 백로그를 11pm부터 처리하기`

### 알림이 방해되기 전에 조사하기

Sentry, 로그, 기타 알림 소스를 감시하는 반복 작업을 설정하세요. 알림이 발생하면 CORE가 조사하고 관련 추적과 이전 인시던트를 수집하여 처리 또는 에스컬레이션을 결정합니다.

Sentry 알림이 2am에 발생. CORE가 조사하고, 수정안을 제안하며, Slack에서 리뷰를 요청합니다.

### 내 일에 맞춘 아침 브리핑 받기

매일 아침 이메일, GitHub, Linear, Slack에서 정보를 가져오는 반복 작업을 설정하세요. CORE가 주목할 내용을 요약하고, 불필요한 것은 건너뛰며, 후속 작업을 자동으로 태스크로 전환합니다.

### 어디서든 위임하기

Slack, WhatsApp, Telegram, 이메일, 웹에서 태스크를 생성하세요. 게이트웨이는 Docker나 Railway에서 계속 실행되므로, 노트북이 닫혀 있어도 CORE가 작업을 가져올 수 있습니다.

---

## CORE 구성 요소

| | |
|---|---|
| **Memory** | 모든 도구와 대화에서 당신의 선호, 결정, 목표, 지시사항을 추적하여 모든 작업이 항상 컨텍스트를 갖고 시작됩니다. |
| **Tasks** | 단일 또는 반복 작업 단위에 사양, CORE의 계획, 실시간 상태, 전용 채팅 스레드가 포함됩니다. 각 작업은 코딩 또는 브라우저 세션을 생성할 수 있습니다. |
| **Scratchpad** | 작업, 아이디어, 진행 중인 작업을 위한 일일 페이지. 어디든지 `[ ]`를 입력하면 CORE가 3분 이내에 이를 감지합니다. |
| **Connectors** | 하나의 MCP 엔드포인트를 통해 50개 이상의 앱과 연결, 그리고 웹훅 트리거로 능동적인 자동화를 제공합니다. GitHub, Linear, Jira, Slack, Gmail, Calendar, Sentry, Granola, Todoist 등 지원. |
| **Skills** | 100개 이상의 재사용 가능한 지침이 컨텍스트에 따라 자동으로 적용됩니다. 내장된 스킬을 사용하거나 반복 작업을 위해 직접 작성할 수 있습니다. |
| **Gateway** | Claude Code, Codex, 브라우저 에이전트, 로컬 명령을 로컬 PC 또는 Docker / Railway에서 실행하여 CORE가 노트북이 닫혀도 계속 작동합니다. |
| **Model agnostic** | Anthropic, OpenAI, 또는 오픈 웨이트 모델 등 원하는 공급자를 사용할 수 있습니다. 전체 스택을 직접 호스팅하여 격리 환경을 구축할 수 있습니다. |

---

## CORE가 아닌 것

| | |
|---|---|
| **RAG 래퍼가 아닙니다.** | 메모리는 단순히 임베딩된 조각이 아닙니다. 결정한 내용, 시점, 이유를 추적하는 지식 그래프입니다. |
| **워크플로우 빌더가 아닙니다.** | 드래그 앤 드롭 DAG는 없습니다. 필요한 일을 직접 작성하세요. CORE가 워크플로우를 파악하고 판단이 필요할 때 질문합니다. |
| **Devin이 아닙니다.** | CORE가 계획을 제안하면 당신이 승인합니다. CORE가 해제 요청을 하면 당신이 결정합니다. CORE가 PR을 가져오면 당신이 리뷰합니다. 에이전트가 혼자 머지하지 않습니다. |
| **폐쇄형 클라우드 어시스턴트가 아닙니다.** | CORE는 오픈 소스, 자체 호스팅, 모델 독립적이며 당신의 인프라를 중심으로 설계되었습니다. |

---

## 빠른 시작

오픈 소스 및 자체 호스팅. 데이터는 당신의 인프라에 남아 있습니다.

**CORE 설치 및 시작:**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```
설치 마법사는 설치 디렉토리, AI 공급자, API 키, 채팅 모델을 묻습니다. 비밀 정보를 생성하고, 스택을 시작하며, `http://localhost:3033`을 엽니다.

대부분의 로컬 설치는 Docker가 실행 중일 때 몇 분 정도 걸립니다.

**또는 Railway에 배포하세요:**

[![Railway에 배포](https://railway.app/button.svg)](https://railway.com/deploy/core)

**게이트웨이를 연결하세요**. 그러면 CORE가 브라우저를 제어하고, 코딩 에이전트를 실행하며, 로컬 폴더에 접근할 수 있습니다.


```bash
corebrain login
corebrain gateway setup
```

**요구사항:** Docker 20.10+, Docker Compose 2.20+, 4 vCPU / 8GB RAM

[전체 셀프 호스팅 가이드](https://docs.getcore.me/self-hosting/setup)

> Mac 앱을 원하시나요? [getcore.me](https://www.getcore.me/)에서 대기자 명단에 등록하세요.

---

## 벤치마크

CORE는 단일-홉, 다중-홉, 오픈-도메인, 시간적 추론을 포함하는 [LoCoMo 벤치마크](https://github.com/RedPlanetHQ/core-benchmark)에서 **88.24%** 평균 정확도를 달성합니다.

---

## 우리의 신념

- 채팅은 인터페이스입니다. 운영체제가 아닙니다.
- 기억 없는 지능은 잡학입니다.
- 당신의 AI는 현재 탭만이 아니라 모든 도구에서 당신을 알아야 합니다.
- 작업은 당신이 접착제가 되지 않고도 의도에서 행동으로 옮겨져야 합니다.
- 책임 없는 자동화는 혼란입니다.

---

## 문서

- [**메모리**](https://docs.getcore.me/memory/overview) - 시간 지식 그래프, 사실 분류, 의도 기반 검색
- [**스크래치패드**](https://docs.getcore.me/concepts/scratchpad) - 작업과 아이디어가 시작되는 일상 표면
- [**작업**](https://docs.getcore.me/concepts/tasks) - 계획, 상태, 반복 작업, 작업별 컨텍스트
- [**툴킷**](https://docs.getcore.me/concepts/toolkit) - MCP를 통한 50+ 앱에서 1000+ 액션
- [**CORE 에이전트**](https://docs.getcore.me/concepts/meta-agent) - 트리거, 메모리, 도구, 실행
- [**게이트웨이**](https://docs.getcore.me/access-core/overview) - WhatsApp, Slack, Telegram, 이메일, 웹, API 접근
- [**스킬**](https://docs.getcore.me/skills/overview) - 반복 가능한 워크플로우를 위한 재사용 가능한 지침
- [**셀프 호스팅**](https://docs.getcore.me/self-hosting/setup) - 전체 배포 가이드
- [**변경 로그**](https://docs.getcore.me/opensource/changelog) - 출시된 내용

---

## 보안

- CASA 2단계 인증 완료
- 전송 중 TLS 1.3
- 저장 시 AES-256
- 귀하의 데이터는 모델 학습에 절대 사용되지 않습니다
- 완전한 격리를 위해 자체 호스팅
- [보안 정책](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- 취약점 신고: harshith@poozle.dev

---

## 커뮤니티

우리는 CORE를 공개적으로 개발하고 있습니다.

개인 OS를 구축하는 데 가장 어려운 문제들은 실제 사용자들과 함께 해결하는 것이 최선이므로, 로드맵과 아키텍처 결정 사항을 공개적으로 공유합니다. 저장소에 스타를 남기고, 자체 호스팅하며, 제작한 것을 공유하고, 고장 나거나 누락된 부분에 대해 이슈를 열어주세요.

- [Discord](https://discord.gg/YGUZcvDjUa) - 질문, 아이디어, 발표
- [기여 문서](https://docs.getcore.me/opensource/contributing) - CORE에 기여하는 방법
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - 여기서 시작하세요

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**개인 AI OS를 직접 호스팅하세요.**

[저장소에 스타 남기기](https://github.com/RedPlanetHQ/core) · [문서 읽기](https://docs.getcore.me) · [Discord 참여](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---