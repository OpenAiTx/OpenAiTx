# 🦞 멋진 OpenClaw 에이전트

[![Awesome](https://awesome.re/badge.svg)](https://awesome.re)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)
[![Stars](https://img.shields.io/github/stars/mergisi/awesome-openclaw-agents?style=social)](https://github.com/mergisi/awesome-openclaw-agents)
[![Agents](https://img.shields.io/badge/agents-187-blueviolet)](agents/)

> OpenClaw 생태계를 위한 **187개의 프로덕션 준비된 AI 에이전트 템플릿**을 엄선하여 모았습니다. 모든 템플릿은 복사-붙여넣기 가능한 `SOUL.md` 파일입니다.

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:4F46E5,100:7C3AED&height=180&section=header&text=%F0%9F%A6%9E%20187%20OpenClaw%20Agent%20Templates&fontSize=36&fontColor=ffffff&fontAlignY=35" width="100%"/>
</p>

<div align="center">

### 설정 없이 바로 시작하세요. 60초 내에 배포 완료.

**[187개 템플릿 모두 보기 →](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=browse)** · **[60초 내 배포하기 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=deploy)**

템플릿 선택, 설정 맞춤, 완전한 배포 패키지 획득. 터미널 불필요.

</div>

<div align="center">

📬 **매주 에이전트 템플릿과 팁을 받아보세요** — 매주 화요일 새로운 템플릿, 배포 가이드, 커뮤니티 하이라이트 제공.

**[뉴스레터 구독하기 →](https://docs.google.com/forms/d/e/1FAIpQLSeIqBjV1LXnR2qQqGSGa-48rAveAmpSKVqlzLqDK2d4D4aVWg/viewform)**

</div>

---

## 목차

- [에이전트 템플릿](#agent-templates) (24개 카테고리, 총 187개 에이전트)
  - [생산성](#productivity) · [개발](#development) · [마케팅 및 콘텐츠](#marketing--content) · [비즈니스](#business) · [개인](#personal)
  - [데브옵스](#devops) · [금융](#finance) · [교육](#education) · [헬스케어](#healthcare) · [법률](#legal) · [인사](#hr) · [크리에이티브](#creative) · [보안](#security)
  - [전자상거래](#e-commerce) · [데이터](#data) · [SaaS](#saas) · [부동산](#real-estate) · [프리랜서](#freelance) · [Moltbook](#-moltbook-new)
  - [공급망](#supply-chain) · [준수](#compliance) · [음성](#voice) · [고객 성공](#customer-success) · [자동화](#automation)
- [사용 사례](#use-cases) (132개의 실제 사례)
- [빠른 시작](#quickstart)
- [왜 OpenClaw인가?](#why-openclaw) (프레임워크 대비, 경량, 엔터프라이즈)
- [CrewClaw로 빠른 배포](#quick-deploy-with-crewclaw)
- [MCP 서버](#mcp-servers)
- [통합](#integrations)
- [도구](#tools)
- [보안](#security)
- [튜토리얼 & 가이드](#tutorials--guides)
- [에이전트 제출](#submit-your-agent)
- [커뮤니티](#community)

---

## 에이전트 템플릿

즉시 사용 가능한 AI 에이전트용 SOUL.md 템플릿입니다. SOUL.md를 복사하고, `openclaw agents add`로 등록한 후 게이트웨이를 시작하세요.

```bash
# Quick start with any template
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
npm install && cp ../agents/productivity/orion/SOUL.md ./SOUL.md
node bot.js
```
> 모든 100개 에이전트는 기계 판독이 가능한 JSON으로도 제공됩니다: [`agents.json`](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json)

> **설정 건너뛰기?** [CrewClaw](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=skip_setup)는 어떤 역할이든 전체 배포 패키지(Dockerfile + docker-compose + 봇 + README)를 생성합니다.

### 📋 생산성

적은 노력으로 더 많은 일을 완수하기.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🎯 오리온](agents/productivity/orion/) | 작업 조정, 프로젝트 관리 | 일일 우선순위, 마감일 추적, 팀 정렬이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/orion/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=project-manager) |
| [📊 펄스](agents/productivity/metrics/) | 분석 대시보드 (Mixpanel, Stripe, GA4) | 자동 일간/주간 지표 보고서가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/metrics/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧍 스탠드업](agents/productivity/daily-standup/) | 일일 스탠드업 수집, 팀 요약 | 회의 없이 비동기 스탠드업이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/daily-standup/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=project-manager) |
| [📧 인박스](agents/productivity/inbox-zero/) | 이메일 분류, 응답 초안 작성, 일일 요약 | 받은 편지함이 과부하되어 우선순위 지정이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/inbox-zero/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 회의록](agents/productivity/meeting-notes/) | 회의 요약, 실행 항목 추적 | 자동 회의록 및 후속 조치가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/meeting-notes/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🍅 집중 타이머](agents/productivity/focus-timer/) | 포모도로, 집중 작업 세션 관리 | 책임감 있는 구조화된 집중 시간이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/focus-timer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ 습관 추적기](agents/productivity/habit-tracker/) | 일일 습관, 연속성, 책임감 | 일일 체크인과 연속 추적이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/habit-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 💻 개발

한 번의 커밋으로 미래를 구축합니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🔎 렌즈](agents/development/code-reviewer/) | PR 리뷰, 보안 스캔, 코드 품질 | 병합 전에 자동 코드 리뷰가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/code-reviewer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=code-reviewer) |
| [📖 스크라이브](agents/development/docs-writer/) | README, API 문서, 코드 문서화 | 문서가 코드베이스에 뒤처졌을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/docs-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=technical-writer) |
| [🐛 트레이스](agents/development/bug-hunter/) | 오류 분석, 근본 원인 조사 | 더 빠른 디버깅과 사고 대응이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/bug-hunter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 프로브](agents/development/api-tester/) | API 테스트, 상태 점검, 성능 | 지속적인 API 모니터링과 알림이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/api-tester/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 로그](agents/development/changelog/) | 자동 변경 로그, git에서 릴리스 노트 생성 | 커밋에서 릴리스 노트를 생성하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/changelog/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔗 의존성 스캐너](agents/development/dependency-scanner/) | CVE 스캔, 라이선스 체크, 공급망 | 자동 의존성 보안 감사가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/dependency-scanner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔀 PR 병합기](agents/development/pr-merger/) | 자동 병합, 충돌 감지 | 검사 통과 후 PR을 자동으로 병합하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/pr-merger/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗄️ 마이그레이션 도우미](agents/development/migration-helper/) | 데이터베이스 마이그레이션, 스키마 차이, 롤백 | 데이터베이스 변경을 계획하고 안전망이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/migration-helper/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 테스트 작성기](agents/development/test-writer/) | 단위 테스트 생성, 커버리지 분석 | 테스트 커버리지가 낮아 따라잡아야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/test-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗂️ 스키마 디자이너](agents/development/schema-designer/) | 자연어로 DB 스키마, ERD 출력 | 요구 사항에서 데이터베이스 스키마 설계가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/schema-designer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |

> **60초 만에 소프트웨어 엔지니어 에이전트를 원하시나요?** [CrewClaw로 배포 →](https://crewclaw.com/create-agent?role=software-engineer)

### 📣 마케팅 및 콘텐츠


자동으로 잠재 고객을 늘리세요.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [✍️ 에코](agents/marketing/echo/) | 블로그 게시물, 소셜 카피, 이메일 | 채널 전반에 걸쳐 일관된 콘텐츠 출력이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/echo/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 버즈](agents/marketing/social-media/) | 트위터, 링크드인, 스레드 관리 | 참여 추적이 포함된 예약된 소셜 게시물이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/social-media/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [🔍 랭크](agents/marketing/seo-writer/) | SEO 콘텐츠, GSC 기반 키워드 리서치 | 실제 검색 데이터를 기반으로 SEO 최적화된 콘텐츠가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/seo-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=seo-specialist) |
| [📬 다이제스트](agents/marketing/newsletter/) | 뉴스레터 큐레이션, 이메일 작성 | 수작업 없이 주간 뉴스레터가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/newsletter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🔭 스카우트](agents/marketing/competitor-watch/) | 경쟁사 모니터링, 가격 정보 | 경쟁사의 일일 활동을 추적해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/competitor-watch/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔎 레딧 스카우트](agents/marketing/reddit-scout/) | 서브레딧 모니터링, 답글 기회 | 관련 레딧 스레드를 찾아 참여하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/reddit-scout/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎵 틱톡 재활용기](agents/marketing/tiktok-repurposer/) | 블로그를 비디오 스크립트로 변환 | 장문의 콘텐츠를 짧은 영상으로 재활용하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/tiktok-repurposer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📨 콜드 아웃리치](agents/marketing/cold-outreach/) | 리드 조사, 개인화된 콜드 이메일 | 로봇처럼 들리지 않는 확장 가능한 아웃리치가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/cold-outreach/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [📊 A/B 테스트 분석기](agents/marketing/ab-test-analyzer/) | 실험 분석, 통계적 유의성 | 실험을 진행 중이고 명확한 결과가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ab-test-analyzer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 인플루언서 찾기](agents/marketing/influencer-finder/) | 인플루언서 리서치, 아웃리치, 캠페인 | 관련 인플루언서를 찾아 연락하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/influencer-finder/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [👁️ 브랜드 모니터](agents/marketing/brand-monitor/) | 브랜드 언급 모니터링, 감성 알림 | 브랜드가 언급될 때마다 알려줘야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/brand-monitor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📧 이메일 시퀀스](agents/marketing/email-sequence/) | 다단계 드립 캠페인, 제목 작성 | 자동화된 이메일 육성 시퀀스가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/email-sequence/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [♻️ 콘텐츠 재활용기](agents/marketing/content-repurposer/) | 블로그를 트윗, 게시물, 쇼츠 스크립트로 | 하나의 콘텐츠를 모든 플랫폼에서 활용하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/content-repurposer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📖 책 작가](agents/marketing/book-writer/) | 전체 책 제작 파이프라인, 6단계 | 개요부터 원고까지 책을 쓰고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/book-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📰 뉴스 큐레이터](agents/marketing/news-curator/) | 출처 스캔, AI 큐레이션, 발행 | 50개 이상의 출처에서 자동화된 뉴스 다이제스트가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/news-curator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎥 UGC 비디오](agents/marketing/ugc-video/) | AI 인플루언서 스타일 영상 콘텐츠 | UGC 스타일의 비디오 스크립트와 제작 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ugc-video/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 다계정 소셜](agents/marketing/multi-account-social/) | 10개 이상 계정 관리, 예약 | 여러 브랜드 계정을 플랫폼 전반에서 관리할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/multi-account-social/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=social-media-manager) |

> **콘텐츠 작가나 SEO 에이전트가 필요하신가요?** [CrewClaw로 배포하기 →](https://crewclaw.com/create-agent?role=content-writer)

### 💼 비즈니스

과도한 부담 없이 운영을 관리하세요.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [📊 레이더](agents/business/radar/) | 데이터 분석, 인사이트 생성 | 일일 비즈니스 지표와 트렌드 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/radar/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎧 컴퍼스](agents/business/customer-support/) | 티켓 분류, 응답 초안, 에스컬레이션 | 지원 요청이 팀 성장보다 빠를 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/customer-support/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |
| [💼 파이프라인](agents/business/sales-assistant/) | 리드 점수 매기기, 아웃리치, 파이프라인 보고서 | 자동화된 리드 자격 확인과 후속 조치가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sales-assistant/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [💰 원장](agents/business/invoice-tracker/) | 결제 모니터링, 송장 추적, MRR | 실시간 수익 및 결제 추적이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/invoice-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔮 센티넬](agents/business/churn-predictor/) | 이탈 위험 점수, 유지 조치 | 위험 고객을 떠나기 전에 잡고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/churn-predictor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 개인 CRM](agents/business/personal-crm/) | 연락처 추적, 후속 알림 | 관계 및 후속 조치를 놓치고 있을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/personal-crm/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💬 WhatsApp 비즈니스](agents/business/whatsapp-business/) | 다채널 지원, 리드 자격 확인 | 고객이 WhatsApp으로 연락하고 빠른 응답이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/whatsapp-business/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📅 미팅 스케줄러](agents/business/meeting-scheduler/) | 스마트 일정 관리, 시간대 처리 | 시간대 간 미팅 일정 관리에 시간이 많이 들 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/meeting-scheduler/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💲 경쟁사 가격](agents/business/competitor-pricing/) | 가격 추적, 변경 알림 | 경쟁사 가격 변동을 일일 단위로 모니터링해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/competitor-pricing/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📞 SDR 아웃바운드](agents/business/sdr-outbound/) | 리드 조사, 개인화된 아웃리치 | 자동화된 아웃바운드 영업 개발이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sdr-outbound/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎯 거래 예측기](agents/business/deal-forecaster/) | 파이프라인 신호, 성사 확률 | 데이터 기반 거래 성사 예측이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/deal-forecaster/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🗣️ 이의 제기 처리기](agents/business/objection-handler/) | 실시간 반박, 대화 스크립트 | 영업 담당자가 즉각적인 이의 제기 응답이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/objection-handler/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |

### 🧘 개인

일상 생활을 위한 AI 비서.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [📅 아틀라스](agents/personal/daily-planner/) | 일정 최적화, 아침/저녁 리뷰 | 책임감을 갖춘 체계적인 일상 루틴을 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/daily-planner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📚 스크롤](agents/personal/reading-digest/) | 기사 요약, 주간 독서 요약 | 읽을거리가 밀려 있고 정리된 요약이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/reading-digest/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💪 아이언](agents/personal/fitness-coach/) | 운동, 영양, 진행 보고서 | 모든 것을 추적하는 개인 트레이너가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/fitness-coach/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏠 홈 자동화](agents/personal/home-automation/) | 텔레그램을 통한 스마트 홈 제어 | 채팅으로 스마트 홈을 제어하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/home-automation/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [👨‍👩‍👧‍👦 가족 코디네이터](agents/personal/family-coordinator/) | 공유 캘린더, 식사, 집안일 교대 | 가족을 위한 공유 조직자 및 계획자가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/family-coordinator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ 여행 플래너](agents/personal/travel-planner/) | 여행 일정, 항공편, 호텔, 예산 | 스마트 추천과 함께 여행 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/travel-planner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📓 저널 프롬프터](agents/personal/journal-prompter/) | 일일 프롬프트, 기분 추적, 목표 | 반성을 위한 가이드형 일일 저널링을 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/journal-prompter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🚀 데브옵스

24시간 인프라를 유지합니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🚨 사고 대응자](agents/devops/incident-responder/) | 경고 분류, 사고 조정 | 자동화된 사고 대응과 에스컬레이션이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/incident-responder/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🚀 배포 관리자](agents/devops/deploy-guardian/) | CI/CD 모니터링, 배포 상태 | 배포 알림 및 롤백 경고가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/deploy-guardian/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🖥️ 인프라 모니터](agents/devops/infra-monitor/) | 서버 상태, 디스크, CPU, 메모리 | 사전 대응형 서버 모니터링과 알림이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/infra-monitor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📜 로그 분석기](agents/devops/log-analyzer/) | 로그 파싱, 패턴 탐지, 이상 징후 | 로그가 넘쳐 자동 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/log-analyzer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💸 비용 최적화기](agents/devops/cost-optimizer/) | 클라우드 비용 모니터링, 절감 제안 | 클라우드 요금이 증가해 가시성이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/cost-optimizer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔧 자가 치유 서버](agents/devops/self-healing-server/) | 컨테이너 자동 재시작, 디스크 정리 | 새벽 3시에 스스로 문제를 해결하는 서버가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/self-healing-server/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🍓 라즈베리 파이 에이전트](agents/devops/raspberry-pi/) | 경량 에지 에이전트, 저메모리 최적화 | 라즈베리 파이나 에지 디바이스에 에이전트를 배포할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/raspberry-pi/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 런북 작성기](agents/devops/runbook-writer/) | 시스템 아키텍처 기반 운영 런북 | 사고 대응 문서화된 절차가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/runbook-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📊 SLA 모니터](agents/devops/sla-monitor/) | SLA 준수 추적, 저하 알림 | 서비스별 가동 시간 약속을 추적해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/sla-monitor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📐 용량 계획자](agents/devops/capacity-planner/) | 인프라 용량 예측 | 수요에 따른 인프라 확장 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/capacity-planner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |

### 💰 금융

숫자를 이해하기 쉽게 만듭니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🧾 지출 추적기](agents/finance/expense-tracker/) | 지출 분류, 예산 알림 | 자동 지출 추적 및 예산 모니터링이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/expense-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧮 인보이스 관리자](agents/finance/invoice-manager/) | 인보이스 생성, 추적, 후속 조치 | 인보이스가 누락되고 결제가 지연될 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/invoice-manager/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 수익 분석가](agents/finance/revenue-analyst/) | MRR 분석, 이탈, 수익 예측 | 자동 수익 보고서 및 예측이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/revenue-analyst/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🏦 세금 준비자](agents/finance/tax-preparer/) | 영수증 정리, 공제 계산 | 세금 시즌이 다가오고 정리가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/tax-preparer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📉 트레이딩 봇](agents/finance/trading-bot/) | 포트폴리오 추적, 심리, 가격 알림 | 자동 시장 모니터링 및 가격 알림이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/trading-bot/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔍 사기 탐지기](agents/finance/fraud-detector/) | 거래 이상 감지, 사기 알림 | 거래에 대한 실시간 사기 모니터링이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/fraud-detector/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 재무 예측가](agents/finance/financial-forecaster/) | 과거 데이터 기반 수익/지출 예측 | 데이터 기반 재무 전망이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/financial-forecaster/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⚖️ 포트폴리오 리밸런서](agents/finance/portfolio-rebalancer/) | 할당 변동 분석, 리밸런싱 거래 | 투자 포트폴리오를 주기적으로 리밸런싱할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/portfolio-rebalancer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💳 미지급 계정](agents/finance/accounts-payable/) | 인보이스 매칭, 승인 라우팅, 결제 | AP 워크플로우 자동화 및 빠른 처리가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/accounts-payable/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 카피 트레이더](agents/finance/copy-trader/) | 상위 실적자 거래 복제, 위험 통제 | 예측 시장에서 자동 거래 복제가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/copy-trader/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🎓 교육

더 똑똑하게 배우기, 더 힘들게 하지 않기.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🎓 튜터](agents/education/tutor/) | 개념 설명, 연습 문제 | 24시간 이용 가능한 인내심 있는 튜터가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/tutor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [❓ 퀴즈 제작기](agents/education/quiz-maker/) | 퀴즈 생성, 점수 추적 | 학습 자료로 자동 퀴즈 생성이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/quiz-maker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📖 학습 플래너](agents/education/study-planner/) | 학습 일정, 알림 | 일일 알림이 포함된 체계적인 학습 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/study-planner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 연구 조수](agents/education/research-assistant/) | 논문 검색, 요약, 인용 | 연구 중 논문 찾기에 도움이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/research-assistant/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌍 언어 튜터](agents/education/language-tutor/) | 언어 학습, 회화 연습 | 휴대폰으로 매일 언어 연습을 하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/language-tutor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📐 교육 과정 설계자](agents/education/curriculum-designer/) | 강의 개요, 학습 목표 | 체계적인 강의 설계 및 평가 루브릭이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/curriculum-designer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 에세이 채점자](agents/education/essay-grader/) | 에세이 피드백, 루브릭 기반 채점 | 대규모 일관된 에세이 평가가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/essay-grader/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🃏 플래시카드 생성기](agents/education/flashcard-generator/) | 노트 기반 간격 반복 카드 | 효율적인 학습을 위한 자동 플래시카드가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/flashcard-generator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🏥 헬스케어

가장 중요한 것을 돌보기.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🧘 웰니스 코치](agents/healthcare/wellness-coach/) | 일일 체크인, 정신 건강, 습관 | 매일 웰니스 알림 및 기분 추적이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/wellness-coach/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🥗 식단 플래너](agents/healthcare/meal-planner/) | 식단 계획, 영양 추적 | 목표에 따른 주간 식단 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/meal-planner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏋️ 운동 추적기](agents/healthcare/workout-tracker/) | 운동 계획, 진행 상황 추적 | 진행 상황에 맞춘 운동 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/workout-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🩺 증상 분류](agents/healthcare/symptom-triage/) | 체계적 증상 평가, 긴급도 | 환자 초기 증상 평가 및 안내가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/symptom-triage/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📋 임상 노트](agents/healthcare/clinical-notes/) | SOAP 형식 임상 문서화 | 임상 만남 시 체계적인 노트 전사가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/clinical-notes/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [💊 약물 확인기](agents/healthcare/medication-checker/) | 약물 상호작용, 복용 알림 | 약물 안전성 및 상호작용 확인이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/medication-checker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📝 환자 접수](agents/healthcare/patient-intake/) | 접수 양식, 보험 확인 | 환자 등록 자동화 및 신속 처리가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/patient-intake/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=fitness-coach) |

### ⚖️ 법률

세부 사항을 탐색합니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [📜 계약 검토자](agents/legal/contract-reviewer/) | 계약 검토, 위험 조항 탐지 | 계약을 검토할 때 두 번째 눈이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/contract-reviewer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ 컴플라이언스 검사기](agents/legal/compliance-checker/) | 규정 준수 모니터링, 마감일 추적 | 규제 요건을 철저히 준수해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/compliance-checker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 정책 작성자](agents/legal/policy-writer/) | 내부 정책, 서비스 약관 | 회사 정책을 작성하거나 업데이트해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/policy-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 특허 분석가](agents/legal/patent-analyzer/) | 특허 청구항, 선행 기술, 침해 위험 | 특허 환경 분석 및 위험 평가가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/patent-analyzer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 법률 브리핑 작성자](agents/legal/legal-brief-writer/) | 브리핑, 동의서, 각서 작성 | 사건 사실에서 법률 문서가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/legal-brief-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔒 NDA 생성기](agents/legal/nda-generator/) | 맞춤형 NDA, 비밀 유지 계약서 | 빠르고 맞춤형 NDA 생성이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/nda-generator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 👥 인사

효과적인 팀 구축.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🤝 채용 담당자](agents/hr/recruiter/) | 이력서 검토, 인터뷰 일정 조율 | 채용 시 후보자 선별을 빠르게 해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/recruiter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎒 온보딩](agents/hr/onboarding/) | 신입 사원 설정, 오리엔테이션 가이드 | 신입 사원이 안내받는 온보딩 경험이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/onboarding/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📊 성과 리뷰어](agents/hr/performance-reviewer/) | 피드백 수집, 리뷰 요약 | 평가 시즌에 구조화된 피드백이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/performance-reviewer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 이력서 검토자](agents/hr/resume-screener/) | 이력서 점수 매기기, 후보자 순위 매기기 | 대량 지원자 선별 시 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/resume-screener/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🚪 퇴사 인터뷰](agents/hr/exit-interview/) | 구조화된 퇴사 인터뷰, 유지 인사이트 | 직원 퇴사의 이유를 파악해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/exit-interview/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎁 복리후생 상담사](agents/hr/benefits-advisor/) | 복리후생 Q&A, 정책 안내 | 직원들이 복리후생 및 정책 관련 질문이 있을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/benefits-advisor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💰 보상 벤치마커](agents/hr/compensation-benchmarker/) | 급여 데이터, 시장 가격 분석 | 데이터 기반 보상 권고가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/compensation-benchmarker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎨 크리에이티브

아름답고 매력적으로 만듭니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🎨 브랜드 디자이너](agents/creative/brand-designer/) | 브랜드 가이드라인, 색상 팔레트 | 브랜드 아이덴티티를 구축하거나 리프레시할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/brand-designer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 영상 대본 작성자](agents/creative/video-scripter/) | 영상 대본, 개요, 촬영 목록 | 영상 콘텐츠가 필요하지만 대본 작성이 싫을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/video-scripter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎙️ 팟캐스트 프로듀서](agents/creative/podcast-producer/) | 에피소드 계획, 쇼 노트 | 팟캐스트를 운영하며 기획 도움 필요 시 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/podcast-producer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🧑‍💻 UX 연구원](agents/creative/ux-researcher/) | 사용자 설문, 피드백 분석 | 연구원 고용 없이 사용자 인사이트가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ux-researcher/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [✏️ 카피라이터](agents/creative/copywriter/) | 광고 문구, 랜딩 페이지, 이메일 시퀀스 | 빠른 전환 중심 카피가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/copywriter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🖼️ 썸네일 디자이너](agents/creative/thumbnail-designer/) | 유튜브/소셜 썸네일 컨셉 | 시선을 사로잡는 썸네일 아이디어가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/thumbnail-designer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📢 광고 카피라이터](agents/creative/ad-copywriter/) | 구글, 메타, 링크드인 광고 변형 | 플랫폼별 A/B 테스트 광고 문구가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ad-copywriter/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 스토리보드 작가](agents/creative/storyboard-writer/) | 비주얼 스토리보드, 촬영 목록 | 비디오 콘텐츠의 사전 제작 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/storyboard-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |

### 🔒 보안

당신이 만든 것을 보호합니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|----------|-----------|-----------|---------|------|
| [🛡️ 취약점 스캐너](agents/security/vuln-scanner/) | 취약점 스캔, 수정 우선순위 지정 | 스택의 지속적인 보안 스캔이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/vuln-scanner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔐 접근 감사관](agents/security/access-auditor/) | 권한 검토, 과도한 접근 표시 | 누가 무엇에 접근하는지 감사를 해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/access-auditor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [👁️ 위협 모니터](agents/security/threat-monitor/) | 위협 피드 모니터링, 관련 알림 | 스택을 대상으로 한 위협에 대한 조기 경고가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/threat-monitor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📓 사고 기록자](agents/security/incident-logger/) | 보안 사고 문서화 | 구조화된 사고 추적 및 사후 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/incident-logger/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔒 보안 강화기](agents/security/security-hardener/) | SOUL.md 감사, 게이트웨이 강화 | 에이전트와 게이트웨이 구성을 강화하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/security-hardener/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🎣 피싱 탐지기](agents/security/phishing-detector/) | 이메일 피싱 분석, URL 스캔 | 팀에서 자동 피싱 탐지가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/phishing-detector/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |

### 🛒 전자상거래

더 많이 팔고, 더 적게 관리하세요.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|----------|-----------|-----------|---------|------|
| [🏷️ 상품 등록자](agents/ecommerce/product-lister/) | 등록 최적화, SEO 제목 | 마켓플레이스 전반에서 최적화된 상품 등록이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/product-lister/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [⭐ 리뷰 응답자](agents/ecommerce/review-responder/) | 고객 리뷰 자동 응답 | 고객 리뷰에 신속하고 일관된 응답이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/review-responder/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📦 재고 추적기](agents/ecommerce/inventory-tracker/) | 재고 모니터링, 재주문 알림 | 재고 부족과 과잉 재고를 방지해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/inventory-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💲 가격 최적화기](agents/ecommerce/pricing-optimizer/) | 동적 가격 책정, 경쟁 추적 | 시장 상황에 맞게 가격을 조정하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/pricing-optimizer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🛒 장바구니 포기 복구](agents/ecommerce/abandoned-cart/) | 장바구니 복구, 재구매 유도 시퀀스 | 판매 손실이 장바구니 포기 때문에 발생할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/abandoned-cart/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🔍 드롭쉬핑 연구원](agents/ecommerce/dropshipping-researcher/) | 24시간 제품 연구, 공급업체 분석 | 드롭쉬핑을 위한 지속적인 제품 발굴이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/dropshipping-researcher/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |

> **Shopify나 Amazon 스토어를 운영 중이신가요?** [전자상거래 에이전트 배포 →](https://crewclaw.com/create-agent?role=customer-support)

### 📊 데이터

원시 데이터를 의사결정으로 전환합니다.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|----------|-----------|-----------|---------|------|
| [🔄 ETL 파이프라인](agents/data/etl-pipeline/) | 파이프라인 모니터링, 실패 알림, 재시도 | 데이터 파이프라인의 자동 모니터링이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/etl-pipeline/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧹 데이터 클리너](agents/data/data-cleaner/) | 품질 검사, 중복 제거, 정규화 | 데이터가 엉켜있고 자동 정리가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/data-cleaner/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 보고서 생성기](agents/data/report-generator/) | 여러 출처의 자동 보고서 | 이해관계자가 수동 작업 없이 정기 보고서를 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/report-generator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🗃️ SQL 어시스턴트](agents/data/sql-assistant/) | SQL 지원, 쿼리 최적화, 스키마 탐색 | 복잡한 쿼리에 대해 SQL 공동 조수가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/sql-assistant/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 대시보드 빌더](agents/data/dashboard-builder/) | 지표 대시보드, 유지보수 | 자동화된 대시보드 생성 및 업데이트가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/dashboard-builder/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🚨 이상 탐지기](agents/data/anomaly-detector/) | 지표 이상 탐지, 통계 경고 | 비정상 데이터 패턴에 대한 자동 경고가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/anomaly-detector/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 설문 분석기](agents/data/survey-analyzer/) | 감정, 주제, NPS 세부 분석 | 구조화된 설문 데이터 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/survey-analyzer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |

> **데이터 분석가 에이전트가 필요하신가요?** [CrewClaw로 배포하기 →](https://crewclaw.com/create-agent?role=data-analyst)

### ☁️ SaaS

제품 성장과 사용자 유지.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|---------|-----------|-----------|---------|------|
| [🚀 온보딩 플로우](agents/saas/onboarding-flow/) | 사용자 온보딩, 활성화 추적 | 신규 사용자가 아하 모먼트에 도달하지 못할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/onboarding-flow/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=project-manager) |
| [💡 기능 요청](agents/saas/feature-request/) | 요청 수집, 우선순위 지정, 투표 | 기능 요청이 여러 채널에 분산되어 있을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/feature-request/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=project-manager) |
| [🔮 이탈 방지](agents/saas/churn-prevention/) | 사전 이탈 방지, 건강 점수 | 사용자가 이탈하는데 이유를 모를 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/churn-prevention/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 사용 분석](agents/saas/usage-analytics/) | 제품 사용, 기능 채택 추적 | 사용자가 제품을 어떻게 사용하는지 이해해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/usage-analytics/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📝 릴리스 노트](agents/saas/release-notes/) | Git 및 PR에서 자동 릴리스 노트 생성 | 릴리스 노트 작성이 귀찮고 아무도 하고 싶지 않을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/release-notes/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=technical-writer) |

### 🏡 부동산

딜 찾기, 빠른 거래 성사.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|---------|-----------|-----------|---------|------|
| [🏡 리스팅 스카우트](agents/real-estate/listing-scout/) | 부동산 모니터링, 가격 하락 알림 | 새 리스팅과 가격 하락에 즉시 알림이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/listing-scout/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 시장 분석기](agents/real-estate/market-analyzer/) | 시장 분석, 비교 보고서 | 자동화된 시장 비교 및 트렌드 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/market-analyzer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎯 리드 평가기](agents/real-estate/lead-qualifier/) | 리드 점수화, 후속 시퀀스 | 리드가 너무 빨리 들어와 평가가 어려울 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/lead-qualifier/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎬 부동산 영상](agents/real-estate/property-video/) | 리스팅 영상, 가상 투어, 스테이징 | 대규모 부동산 영상 콘텐츠가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/property-video/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🏢 상업용 부동산](agents/real-estate/commercial-re/) | 상업용 부동산 분석, 수익률, 거래 추적 | 상업용 부동산 투자 분석이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/commercial-re/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🧑‍💻 프리랜서

더 똑똑하게 일하고, 더 많이 청구하세요.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|---------|-----------|-----------|---------|------|
| [📝 제안서 작성기](agents/freelance/proposal-writer/) | 제안서 생성, 요율 계산 | 제안서 작성에 너무 많은 시간을 쓰고 있을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/proposal-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=content-writer) |
| [⏱️ 시간 추적기](agents/freelance/time-tracker/) | 시간 추적, 청구서 발행, 활용도 | 비효율적인 시간 추적으로 청구 가능한 시간이 줄어들 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/time-tracker/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤝 클라이언트 매니저](agents/freelance/client-manager/) | 클라이언트 CRM, 계약 추적 | 여러 클라이언트와 마감일을 동시에 관리할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/client-manager/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=project-manager) |

> **프리랜서인가요?** [개인 비서 에이전트 배포 →](https://crewclaw.com/create-agent?role=personal-assistant)

### 🤖 Moltbook `NEW`

AI 에이전트 소셜 네트워킹 — 에이전트 간 소셜 레이어에서 에이전트의 존재감.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🤖 커뮤니티 매니저](agents/moltbook/community-manager/) | 업데이트 게시, 참여, 카르마 구축 | 에이전트가 Moltbook에서 소셜 존재감을 유지하길 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/community-manager/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [🔭 스카우트](agents/moltbook/scout/) | 피드 스캔, 키워드 모니터링, 요약 | Moltbook에서 관련 토론과 기회를 모니터링하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/scout/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [📈 성장 에이전트](agents/moltbook/growth-agent/) | 팔로워 증가, 서브몰트 관리, 전략 | Moltbook에서 에이전트의 영향력과 팔로워 기반을 키우고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/growth-agent/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?integrations=moltbook) |

> **NEW: Moltbook 통합!** 이제 에이전트가 AI 에이전트 소셜 네트워크에서 게시, 참여, 성장할 수 있습니다. [Moltbook으로 배포 →](https://crewclaw.com/create-agent?integrations=moltbook)

### 📦 공급망 `NEW`

물류 및 공급업체 운영 최적화.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🚚 경로 최적화기](agents/supply-chain/route-optimizer/) | 배송 경로, 교통, 용량 | 최적화된 배송 계획이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/route-optimizer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 재고 예측기](agents/supply-chain/inventory-forecaster/) | 수요 예측, 재주문 시점 | 스마트 예측으로 재고 부족을 방지해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/inventory-forecaster/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⭐ 공급업체 평가자](agents/supply-chain/vendor-evaluator/) | 공급업체 점수화, 품질 추적 | 데이터 기반 공급업체 선정 및 순위 매김이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/vendor-evaluator/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=data-analyst) |

### ✅ 컴플라이언스 `NEW`

규제에 앞서 나가기.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🔒 GDPR 감사관](agents/compliance/gdpr-auditor/) | GDPR 격차 분석, 개선 계획 | 데이터 프라이버시 준수를 위해 시스템 감사를 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/gdpr-auditor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 SOC2 준비자](agents/compliance/soc2-preparer/) | 증거 수집, 감사 준비 | SOC 2 인증을 준비할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/soc2-preparer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤖 AI 정책 작성자](agents/compliance/ai-policy-writer/) | AI 거버넌스, EU AI 법안 준수 | 조직의 AI 사용 정책이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/ai-policy-writer/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [⚠️ 위험 평가자](agents/compliance/risk-assessor/) | 위험 평가, 완화 계획 | 체계적인 비즈니스 위험 평가가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/risk-assessor/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎙️ 음성 `NEW`

AI 기반 음성 및 전화 에이전트.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [📞 전화 접수원](agents/voice/phone-receptionist/) | 전화 응대, 라우팅, 예약 | 직원 없이 24시간 전화 대응이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/phone-receptionist/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📝 음성메일 전사기](agents/voice/voicemail-transcriber/) | 전사, 작업 항목 추출 | 음성메일을 빠르게 처리하고 라우팅해야 할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/voicemail-transcriber/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎤 인터뷰 봇](agents/voice/interview-bot/) | 선별 인터뷰, 평가 기준 | 대규모로 구조화된 후보자 선별이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/interview-bot/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🤝 고객 성공 `NEW`

고객 만족 유지 및 성장.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [📊 NPS 후속조치](agents/customer-success/nps-followup/) | 비판자 회복, 개인화된 연락 | NPS 비판자에게 즉각적인 대응이 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/nps-followup/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |
| [🎯 온보딩 가이드](agents/customer-success/onboarding-guide/) | 제품 설정, 상황별 팁 | 신규 사용자의 제품 온보딩 안내가 필요할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/onboarding-guide/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=customer-support) |

### 🔄 자동화 `NEW`

설정 후 잊으세요. 당신이 자는 동안 일하는 에이전트들.

| 에이전트 | 전문 분야 | 사용 시기 | SOUL.md | 배포 |
|-------|-----------|-------------|---------|--------|
| [🤝 협상 에이전트](agents/automation/negotiation-agent/) | 청구서 협상, 계약 체결 | AI가 청구서 및 계약을 협상하길 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/negotiation-agent/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 구직 지원자](agents/automation/job-applicant/) | 대량 지원, 이력서 맞춤화 | 500개 이상의 일자리에 지원하고 싶을 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/job-applicant/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [☀️ 아침 브리핑](agents/automation/morning-briefing/) | 이메일, 일정, 뉴스 일일 요약 | 오전 7시에 개인화된 일일 브리핑을 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/morning-briefing/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ 항공편 스크래퍼](agents/automation/flight-scraper/) | 항공권 거래, 가격 하락 알림 | 가장 저렴한 항공편을 자동으로 찾길 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/flight-scraper/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌙 야간 코더](agents/automation/overnight-coder/) | 자율 코딩, 아침까지 PR 완성 | 자는 동안 코드를 작성하길 원할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/overnight-coder/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💬 디스코드 비즈니스](agents/automation/discord-business/) | 디스코드를 통한 전체 비즈니스 운영 | 디스코드로 비즈니스를 운영할 때 | [보기](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/discord-business/SOUL.md) | [배포 →](https://crewclaw.com/create-agent?role=personal-assistant) |

---

## 사용 사례

**132개의 검증된 실제 사용 사례** — 사람들이 실제로 OpenClaw 에이전트로 만드는 것들.

개발자 워크플로우와 DevOps 자동화부터 스마트 홈 제어, 암호화폐 거래, 로보틱스, 그리고 스스로 코드를 수정하는 에이전트까지.

**[전체 132개 사용 사례 보기 →](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/USE-CASES.md)**

주요 카테고리: 개인 생산성 (14) · 비즈니스 운영 (11) · 개발자 워크플로우 (10) · 콘텐츠 제작 (10) · 생태계 도구 (10)

---

## 빠른 시작

구성 없이 5분 이내에 작동하는 에이전트를 실행하세요:

```bash
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
cp .env.example .env          # add your API key + Telegram token
cp ../agents/marketing/echo/SOUL.md ./SOUL.md
npm install && node bot.js    # your agent is live on Telegram
```
전체 [빠른 시작 가이드](quickstart/)를 Docker 지원과 함께 확인하세요.

또는 설정을 완전히 건너뛰기: **[CrewClaw로 배포하기 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=quickstart)** — 모든 역할에 대한 완전한 배포 패키지(Dockerfile + docker-compose + 봇 + README)를 받으세요.

---

## 왜 OpenClaw인가?

OpenClaw가 다른 AI 에이전트 프레임워크와 비교되는 점:

### AI 에이전트 프레임워크와의 비교

| 기능 | OpenClaw | AutoGPT | CrewAI | LangChain | MetaGPT |
|---------|----------|---------|--------|-----------|---------|
| 설정 우선 (SOUL.md) | ✅ | ❌ | ❌ | ❌ | ❌ |
| 코드 불필요 | ✅ | ❌ | ❌ | ❌ | ❌ |
| Telegram/Slack/Discord 내장 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 다중 에이전트 오케스트레이션 | ✅ | ❌ | ✅ | ✅ | ✅ |
| MCP (모델 컨텍스트 프로토콜) | ✅ | ❌ | ❌ | ❌ | ❌ |
| 자체 호스팅 / 로컬 | ✅ | ✅ | ✅ | ✅ | ✅ |
| 하트비트 모니터링 | ✅ | ❌ | ❌ | ❌ | ❌ |
| Ollama(무료)와 작동 | ✅ | ✅ | ✅ | ✅ | ❌ |
| 프로덕션 준비 템플릿 | **187** | 0 | 5 | 0 | 3 |
| 원클릭 배포 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 에이전트 간 통신 | ✅ | ❌ | ✅ | ✅ | ✅ |
| 설정 시간 | 약 5분 | 약 30분 | 약 20분 | 약 45분 | 약 30분 |

### 경량 대안과의 비교

| 기능 | OpenClaw | ZeroClaw | PicoClaw | NanoClaw | memU |
|---------|----------|----------|----------|----------|------|
| 언어 | Node.js | Rust | Go | Python | Python |
| 바이너리 크기 | 약 150MB | 약 5MB | 약 8MB | 약 4K LOC | 약 50MB |
| 최소 RAM | 512MB | 32MB | 64MB | 128MB | 256MB |
| 다중 에이전트 | ✅ AGENTS.md | ❌ | ❌ | ❌ | ❌ |
| 스킬/플러그인 | ✅ 13K+ | ❌ | ❌ | ❌ | ❌ |
| 메시징 채널 | ✅ 25+ | 3 | 2 | 1 | 5 |
| 장기 기억 | 기본 | ❌ | ❌ | ❌ | ✅ 지식 그래프 |
| MCP 지원 | ✅ | ❌ | ❌ | ❌ | ❌ |

| 생산 템플릿 | **187** | 0 | 0 | 0 | 0 |
| 최적 대상 | 전체 에이전트 팀 | 엣지/IoT | 단일 목적 봇 | 최소 구성 | 개인 비서 |

### 호스팅/엔터프라이즈 솔루션 대비

| 기능 | OpenClaw | Claude Code Channels | NemoClaw (NVIDIA) | OpenFang |
|---------|----------|---------------------|-------------------|----------|
| 오픈 소스 | ✅ MIT | ❌ 독점 | ✅ Apache 2.0 | ✅ MIT |
| 자체 호스팅 | ✅ | ❌ 클라우드 전용 | ✅ | ✅ |
| 설정 | 구성 파일 | API 키 | 도커 + 구성 | 러스트 바이너리 |
| 다중 에이전트 | ✅ | ❌ | ✅ OpenClaw 통해 | ✅ 7 "손" |
| 보안 모델 | 사용자 관리 | Anthropic 관리 | 커널 샌드박스 | 프로세스 격리 |
| 메시징 | ✅ 25+ 채널 | 텔레그램, 디스코드 | OpenClaw 통해 | 3 채널 |
| 비용 | 무료 + API 요금 | Claude 구독 | 무료 + API 요금 | 무료 + API 요금 |
| 최적 대상 | 완전 제어 | 비기술 사용자 | 엔터프라이즈 보안 | 에이전트 OS 고급 사용자 |

**요약:** OpenClaw는 구성 우선입니다. SOUL.md를 작성하고 명령어를 실행하면 에이전트가 즉시 작동합니다. Python, 체인, 그래프 불필요. 경량 대안은 작은 크기를 위해 기능을 희생합니다. 엔터프라이즈 솔루션은 보안 계층을 추가합니다.

---

## CrewClaw로 빠른 배포

템플릿을 선택하고 맞춤화한 후 [CrewClaw](https://crewclaw.com/create-agent)로 완전한 배포 패키지를 받으세요:

```
Your CrewClaw package includes:
├── agents/your-agent/SOUL.md    # Agent configuration
├── Dockerfile                    # Container setup
├── docker-compose.yml            # One-command deploy
├── bot.js                        # Telegram bot (grammy)
├── .env.example                  # API keys template
├── package.json                  # Dependencies
└── README.md                     # Setup instructions
```
위의 187개 템플릿 중에서 선택하거나, 맞춤형 에이전트를 처음부터 생성하세요.

**[에이전트 생성하기 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta)**

---

## MCP 서버

에이전트 기능 확장을 위한 모델 컨텍스트 프로토콜 서버.

### 공식

| 서버 | 설명 | 설치 |
|--------|-------------|---------|
| [@anthropic/mcp-server-fetch](https://github.com/anthropics/mcp-server-fetch) | 웹 페칭 및 브라우징 | `npx -y @anthropic/mcp-server-fetch` |
| [@anthropic/mcp-server-filesystem](https://github.com/anthropics/mcp-server-filesystem) | 파일 시스템 접근 | `npx -y @anthropic/mcp-server-filesystem` |

### 커뮤니티

| 서버 | 설명 |
|--------|-------------|
| mcp-notion | 노션 통합 |
| mcp-google-calendar | 구글 캘린더 접근 |
| mcp-github | 깃허브 작업 |
| mcp-slack | 슬랙 메시징 |
| mcp-postgres | PostgreSQL 쿼리 |
| mcp-stripe | 스트라이프 결제 |
| mcp-shopify | 쇼피파이 스토어 관리 |
| mcp-twitter | 트위터/X 게시 |
| mcp-discord | 디스코드 봇 통합 |
| mcp-linear | 리니어 이슈 추적 |

---

## 통합

에이전트를 외부 서비스에 연결하세요.

### 메시징

- **텔레그램** - 텔레그램을 통한 에이전트 채팅 (OpenClaw 내장)
- **슬랙** - 슬랙 워크스페이스 연결 (OpenClaw 내장)
- **디스코드** - 디스코드 서버 봇 (OpenClaw 내장)
- **이메일** - 이메일 채널 (OpenClaw 내장)

### 자동화

- **n8n** - n8n 통합 노드
- **GitHub Actions** - CI/CD 통합
- **Cron / pm2 / systemd** - 항상 켜진 에이전트 스케줄링

---

## 도구

OpenClaw 작업을 위한 유틸리티와 도우미.

| 도구 | 설명 |
|------|-------------|
| [openclaw CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) | 공식 CLI - 완전한 명령어 참조 |
| [agents.json](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json) | 187개 에이전트 템플릿의 기계 판독 인덱스 |
| agent-validator | SOUL.md 문법 검증 |
| mcp-tester | MCP 서버 연결 테스트 |

---

## 보안

OpenClaw 에이전트는 사용자의 하드웨어에서 실행되며 파일과 서비스에 접근합니다. 다음 모범 사례를 따르세요:

| 위험 | 완화 방법 |
|------|------------|
| 노출된 게이트웨이 | `localhost`에만 바인딩하세요. 원격 접근 시 SSH 터널링을 사용하세요. 포트 18789를 인터넷에 절대 노출하지 마세요. |
| API 키 유출 | 키를 `.env` 파일에 저장하세요. `.env`를 `.gitignore`에 추가하세요. 키를 정기적으로 교체하세요. |
| 악성 스킬 | ClawHub 인증 발행자의 스킬만 설치하세요. 설치 전에 SKILL.md를 검토하세요. |
| 프롬프트 인젝션 | SOUL.md에 엄격한 `## Rules`를 설정하세요. 파일 시스템 접근을 제한하세요. 신뢰할 수 없는 입력에 대한 셸 명령을 비활성화하세요. |
| 무인 에이전트 | HEARTBEAT.md에 범위 제한을 사용하세요. 예산 한도를 설정하세요. 모든 작업에 대해 로깅을 활성화하세요. |

**최근 보안 자료:**

- [OpenClaw 보안 가이드](https://crewclaw.com/blog/openclaw-security-guide) - 설정 강화 방법  
- [OpenClaw 보안 위험 2026](https://crewclaw.com/blog/openclaw-security-risks-2026) - 알려진 취약점 및 수정 사항  
- [NemoClaw (NVIDIA GTC 2026)](https://crewclaw.com/blog/nvidia-gtc-2026-openclaw-nemoclaw) - 엔터프라이즈 보안 래퍼  
- [공식 보안 문서](https://docs.openclaw.ai/gateway/security) - 게이트웨이 보안 설정  

---

## 튜토리얼 및 가이드  

에이전트를 빌드하고 배포하는 방법을 배웁니다.  

### 시작하기  

- [OpenClaw 사용법: 초보자 가이드](https://crewclaw.com/blog/how-to-use-openclaw-guide) - 5분 만에 설치부터 첫 에이전트까지  
- [OpenClaw란?](https://crewclaw.com/blog/what-is-openclaw-ai-agent-framework) - 프레임워크 완전 가이드  
- [첫 에이전트 만들기](https://crewclaw.com/blog/how-to-create-ai-agent-openclaw) - 코드 없이 가능  
- [OpenClaw 설치 가이드 2026](https://crewclaw.com/blog/openclaw-setup-guide-2026) - 설치, 설정, 실행  
- [시스템 요구사항](https://crewclaw.com/blog/openclaw-system-requirements-2026) - 하드웨어, GPU, VPS, Docker 사양  
- [OpenClaw에 최적 모델](https://crewclaw.com/blog/best-models-for-openclaw-2026) - 비용, 속도, 도구 호출 기준 10개 LLM 비교  
- [SOUL.md 템플릿](https://crewclaw.com/blog/soul-md-examples-templates) - 바로 쓸 수 있는 10가지 예제  

### 다중 에이전트 및 오케스트레이션  

- [다중 에이전트 설정 가이드](https://crewclaw.com/blog/openclaw-multi-agent-setup-guide) - 여러 에이전트 동시에 실행  
- [에이전트 간 통신](https://crewclaw.com/blog/openclaw-agent-to-agent-communication) - 에이전트 협업 방법  
- [AI 팀 만들기](https://crewclaw.com/blog/build-ai-team-workflows) - 자율적으로 실행되는 워크플로우  

### 활용 사례  

- [OpenClaw로 할 수 있는 것들](https://crewclaw.com/blog/what-can-openclaw-do) - 설정 포함 12가지 실제 사례  
- [비즈니스를 위한 OpenClaw](https://crewclaw.com/blog/openclaw-for-business-use-cases) - 8개 분야 25가지 활용 사례  
- [콘텐츠 제작 가이드](https://crewclaw.com/blog/openclaw-content-creation-guide) - 블로그, 소셜 미디어, 비디오 자동화  
- [리드 생성 가이드](https://crewclaw.com/blog/openclaw-lead-generation-guide) - Reddit, Twitter, 영업 파이프라인  
- [이메일 자동화](https://crewclaw.com/blog/openclaw-email-automation-guide) - 받은편지함 분류, 자동 응답, 후속 조치  
- [홈 어시스턴트 연동](https://crewclaw.com/blog/openclaw-home-assistant-integration) - 스마트 홈 제어  

### 통합 및 자동화  

- [Slack 및 Telegram 연동](https://crewclaw.com/blog/openclaw-slack-telegram-integration) - 메시징 채널 연결  

- [Ollama로 실행하기](https://crewclaw.com/blog/openclaw-ollama-local-agents) - 무료 로컬 AI 에이전트  
- [자동화 가이드](https://crewclaw.com/blog/openclaw-automation-guide) - 24/7 워크플로우 구축  
- [CLI 명령어 참조](https://crewclaw.com/blog/openclaw-cli-commands-reference) - 완전한 치트 시트  
- [Google Workspace 통합](https://crewclaw.com/blog/openclaw-google-workspace-integration) - Gmail, Docs, Drive, Calendar  

### 비교

- [OpenClaw vs CrewAI](https://crewclaw.com/blog/openclaw-vs-crewai) - 어느 쪽이 더 나은가?  
- [OpenClaw vs AutoGen](https://crewclaw.com/blog/openclaw-vs-autogen) - 마이크로소프트의 멀티 에이전트 프레임워크  
- [OpenClaw vs LangChain](https://crewclaw.com/blog/openclaw-vs-langchain) - 프레임워크 비교  
- [OpenClaw vs AutoGPT](https://crewclaw.com/blog/openclaw-vs-autogpt) - 주요 차이점  
- [OpenClaw vs ZeroClaw](https://crewclaw.com/blog/openclaw-vs-zeroclaw) - Rust 경량 대안  
- [OpenClaw vs OpenFang](https://crewclaw.com/blog/openclaw-vs-openfang) - 7 Hands를 가진 에이전트 OS  
- [OpenClaw vs memU](https://crewclaw.com/blog/openclaw-vs-memu) - 장기 기억 AI  
- [PicoClaw vs OpenClaw](https://crewclaw.com/blog/picoclaw-vs-openclaw) - 초미니멀 대안  
- [OpenClaw GitHub 저장소 가이드](https://crewclaw.com/blog/openclaw-ai-agent-github-guide) - 25만 스타 저장소 해설  

---

## 에이전트 제출하기

맞춤형 에이전트를 만들었나요? 여기와 [crewclaw.com/agents](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=submit) 에 등록하세요.  

각 에이전트는 단순한 프롬프트가 아닌 완전한 운영 체제입니다:

```
agents/[category]/[your-agent]/
├── SOUL.md          ← Identity & personality (required)
├── README.md        ← Description & use cases (required)
├── AGENTS.md        ← Operating rules (optional)
├── HEARTBEAT.md     ← Wake-up checklist (optional)
└── WORKING.md       ← Starting task (optional)
```
**PR을 통한 제출 (권장):**

1. 이 저장소를 포크하세요  
2. SOUL.md + README.md(최소) 포함한 에이전트 폴더를 추가하세요  
3. `agents.json`에 항목을 추가하세요  
4. 풀 리퀘스트를 오픈하세요  

**이슈를 통한 제출 (설정 불필요):**  

[에이전트 제출하기 →](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md) — 파일을 붙여넣으면 저희가 추가해 드립니다.  

전체 가이드: [CONTRIBUTING.md](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/CONTRIBUTING.md)  

---  

## 커뮤니티  

에이전트를 요청하고 싶으신가요? [Agent Request](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-request.md) 템플릿을 사용하세요.  

---  

## 관련 프로젝트  

- [🦞 CrewClaw](https://crewclaw.com) - 설정 없이 AI 에이전트 배포. 도커 및 터미널 불필요.  
- [OpenClaw](https://github.com/openclaw) - 공식 OpenClaw 저장소  
- [Anthropic MCP](https://github.com/anthropics/mcp) - 모델 컨텍스트 프로토콜  

---  

## 별(star) 히스토리  

[![Star History Chart](https://api.star-history.com/svg?repos=mergisi/awesome-openclaw-agents&type=Date)](https://star-history.com/#mergisi/awesome-openclaw-agents&Date)  

---  

## 라이선스  

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)


법이 허용하는 한도 내에서, 기여자들은 이 작업에 대한 모든 저작권 및 관련 권리를 포기하였습니다.

---

<p align="center">
  OpenClaw 커뮤니티가 🦞 와 함께 제작함
  <br/>
  <a href="https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta">CrewClaw로 에이전트를 배포하세요 →</a> · <a href="https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md">당신의 에이전트를 제출하세요 →</a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---