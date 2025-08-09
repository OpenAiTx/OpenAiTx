<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code 서브에이전트 모음

[Claude Code](https://docs.anthropic.com/en/docs/claude-code)를 위한 전문화된 AI 서브에이전트의 포괄적인 모음으로, 도메인별 전문 지식을 통해 개발 워크플로우를 강화합니다.

## 개요

이 저장소에는 Claude Code의 기능을 확장하는 58개의 전문화된 서브에이전트가 포함되어 있습니다. 각 서브에이전트는 특정 도메인의 전문가로, 상황에 따라 자동으로 호출되거나 필요에 따라 명시적으로 호출됩니다. 모든 에이전트는 최적의 성능과 비용 효율성을 위해 작업 복잡도에 따라 특정 Claude 모델로 구성되어 있습니다.

## 사용 가능한 서브에이전트

### 개발 및 아키텍처
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - RESTful API, 마이크로서비스 경계, 데이터베이스 스키마 설계
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - React 컴포넌트 구축, 반응형 레이아웃 구현, 클라이언트 상태 관리 처리
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - 인터페이스 디자인, 와이어프레임, 디자인 시스템 제작
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - React Native 또는 Flutter 앱 개발 및 네이티브 연동
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - GraphQL 스키마, 리졸버, 페더레이션 설계
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - 아키텍처 일관성 및 패턴을 위한 코드 변경 검토

### 언어 전문가
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - 고급 기능과 최적화를 활용한 파이썬 코드 작성
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - 고루틴, 채널, 인터페이스 활용한 Go 코드 작성
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - 소유권 패턴, 라이프타임, 트레이트 구현을 활용한 Rust 작성
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - 효율적인 C 코드 작성 및 메모리 관리, 시스템 호출
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - 현대적 기능, RAII, 스마트 포인터, STL 알고리즘 활용 C++ 작성
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - 최신 자바스크립트(ES6+), 비동기 패턴, Node.js API 마스터
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - 고급 타입, 제네릭, 엄격한 타입 안전성 활용 TypeScript 마스터
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - 최신 기능 및 성능 최적화된 PHP 코드 작성
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - 스트림, 동시성, JVM 최적화 활용 현대 자바 마스터
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - OTP 패턴, 함수형 프로그래밍, Phoenix 프레임워크 활용 Elixir 작성
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - 고급 기능 및 .NET 최적화 활용 현대 C# 코드 작성
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - 함수형 프로그래밍, 분산 시스템, 빅데이터 처리 활용 엔터프라이즈급 Scala 개발
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - 최적화된 스크립트와 성능 튜닝을 통한 Unity 게임 구축
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Bukkit, Spigot, Paper API 활용 마인크래프트 서버 플러그인 개발 마스터
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Swift/SwiftUI로 네이티브 iOS 애플리케이션 개발
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - 복잡한 SQL 쿼리 작성, 실행 계획 최적화, 정규화된 스키마 설계

### 인프라 및 운영
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - 프로덕션 이슈 디버깅, 로그 분석, 배포 실패 해결
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - CI/CD 파이프라인, 도커 컨테이너, 클라우드 배포 구성
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - AWS/Azure/GCP 인프라 설계 및 클라우드 비용 최적화
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - SQL 쿼리 최적화, 효율적 인덱스 설계, 데이터베이스 마이그레이션 처리
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - 데이터베이스 운영, 백업, 복제, 모니터링 관리
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - 고급 Terraform 모듈 작성, 상태 파일 관리, IaC 모범 사례 구현
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - 긴급성과 정확성을 갖춘 프로덕션 인시던트 처리
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - 네트워크 연결 디버깅, 로드 밸런서 구성, 트래픽 패턴 분석
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - 개발자 경험 전문, 툴링, 셋업, 워크플로우 개선

### 품질 및 보안
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - 구성 보안 및 프로덕션 신뢰성에 집중한 전문 코드 리뷰
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - 취약점 코드를 검토하고 OWASP 준수를 보장
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - 단위, 통합, e2e 테스트를 포함한 종합 테스트 스위트 생성
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - 애플리케이션 프로파일링, 병목현상 최적화, 캐싱 전략 구현
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - 오류, 테스트 실패, 예기치 않은 동작의 디버깅 전문가
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - 로그 및 코드베이스에서 오류 패턴, 스택 트레이스, 이상 탐색
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - 고급 검색 기법 및 종합을 활용한 웹 리서치 전문가

### 데이터 & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - SQL 쿼리, BigQuery 작업, 데이터 인사이트 분석 전문가
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - ETL 파이프라인, 데이터 웨어하우스, 스트리밍 아키텍처 구축
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - LLM 애플리케이션, RAG 시스템, 프롬프트 파이프라인 구축
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - ML 파이프라인, 모델 서빙, 피처 엔지니어링 구현
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - ML 파이프라인, 실험 추적, 모델 레지스트리 구축
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - LLM 및 AI 시스템을 위한 프롬프트 최적화

### 특수 도메인
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - OpenAPI/Swagger 명세서 생성 및 개발자 문서 작성
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Stripe, PayPal 등 결제 프로세서 통합
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - 금융 모델 구축, 트레이딩 전략 백테스트, 시장 데이터 분석
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - 포트폴리오 리스크, R-배수, 포지션 제한 모니터링
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - 레거시 코드베이스 리팩토링 및 점진적 현대화 구현
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - 여러 에이전트와 장기 작업의 컨텍스트 관리

### 문서화
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - 기존 코드베이스로부터 종합 기술 문서 작성
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - 플로우차트, 시퀀스, ERD, 아키텍처의 Mermaid 다이어그램 생성
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - 포괄적 기술 레퍼런스 및 API 문서 작성
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - 코드 기반 단계별 튜토리얼 및 교육 자료 생성

### 비즈니스 & 마케팅
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - 지표 분석, 보고서 작성, KPI 추적
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - 블로그, SNS 콘텐츠, 이메일 뉴스레터 작성
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - 콜드 이메일, 후속 메일, 제안서 템플릿 초안 작성
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - 지원 티켓 처리, FAQ 답변, 고객 이메일 응대
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - 개인정보 보호정책, 서비스 약관, 면책조항, 법적 고지 작성

## 모델 할당

모든 58개 서브에이전트는 작업 복잡도에 따라 특정 Claude 모델로 설정되어 있습니다:

### 🚀 Haiku (빠르고 비용 효율적) - 9 에이전트
**모델:** `haiku`
- `data-scientist` - SQL 쿼리 및 데이터 분석
- `api-documenter` - OpenAPI/Swagger 문서화
- `reference-builder` - 포괄적인 기술 참조 및 API 문서
- `business-analyst` - 지표 및 KPI 추적
- `content-marketer` - 블로그 게시물 및 소셜 미디어
- `customer-support` - 지원 티켓 및 FAQ
- `sales-automator` - 콜드 이메일 및 제안서
- `search-specialist` - 웹 리서치 및 정보 수집
- `legal-advisor` - 개인정보 보호 정책 및 컴플라이언스 문서

### ⚡ Sonnet (균형 잡힌 성능) - 36 에이전트
**모델:** `sonnet`

**개발 및 언어:**
- `python-pro` - 고급 기능의 파이썬 개발
- `javascript-pro` - 최신 자바스크립트 및 Node.js
- `typescript-pro` - 타입 시스템을 활용한 고급 타입스크립트
- `golang-pro` - Go 동시성 및 관용적 패턴
- `rust-pro` - 러스트 메모리 안전성 및 시스템 프로그래밍
- `c-pro` - C 프로그래밍 및 임베디드 시스템
- `cpp-pro` - STL 및 템플릿을 활용한 최신 C++
- `php-pro` - 고급 기능의 최신 PHP
- `java-pro` - 스트림 및 동시성의 최신 자바
- `elixir-pro` - OTP 패턴 및 Phoenix를 활용한 엘릭서
- `csharp-pro` - .NET 프레임워크와 패턴의 최신 C#
- `scala-pro` - Apache Pekko, Akka, Spark, ZIO/Cats Effect를 활용한 엔터프라이즈 스칼라
- `unity-developer` - 유니티 게임 개발 및 최적화
- `minecraft-bukkit-pro` - Bukkit/Spigot/Paper를 활용한 마인크래프트 플러그인 개발
- `ios-developer` - Swift/SwiftUI를 활용한 네이티브 iOS 개발
- `frontend-developer` - React 컴포넌트 및 UI
- `ui-ux-designer` - 인터페이스 디자인 및 와이어프레임
- `backend-architect` - API 설계 및 마이크로서비스
- `mobile-developer` - React Native/Flutter 앱
- `sql-pro` - 복잡한 SQL 최적화
- `graphql-architect` - GraphQL 스키마 및 리졸버

**인프라 및 운영:**
- `devops-troubleshooter` - 프로덕션 디버깅
- `deployment-engineer` - CI/CD 파이프라인
- `database-optimizer` - 쿼리 최적화
- `database-admin` - 데이터베이스 운영
- `terraform-specialist` - 코드로서의 인프라스트럭처
- `network-engineer` - 네트워크 구성
- `dx-optimizer` - 개발자 경험
- `data-engineer` - ETL 파이프라인

**품질 & 지원:**
- `test-automator` - 테스트 스위트 생성
- `code-reviewer` - 코드 품질 분석
- `debugger` - 오류 조사
- `error-detective` - 로그 분석
- `ml-engineer` - ML 모델 배포
- `legacy-modernizer` - 프레임워크 마이그레이션
- `payment-integration` - 결제 처리
- `mermaid-expert` - Mermaid 다이어그램 및 시각적 문서화

### 🧠 Opus (최대 역량) - 13 에이전트
**모델:** `opus`
- `ai-engineer` - LLM 애플리케이션 및 RAG 시스템
- `security-auditor` - 취약점 분석
- `performance-engineer` - 애플리케이션 최적화
- `incident-responder` - 프로덕션 인시던트 처리
- `mlops-engineer` - ML 인프라스트럭처
- `architect-reviewer` - 아키텍처 일관성
- `cloud-architect` - 클라우드 인프라 설계
- `prompt-engineer` - LLM 프롬프트 최적화
- `context-manager` - 다중 에이전트 협업
- `quant-analyst` - 금융 모델링
- `risk-manager` - 포트폴리오 위험 관리
- `docs-architect` - 코드베이스 기반의 종합 기술 문서화
- `tutorial-engineer` - 단계별 튜토리얼 및 교육 콘텐츠

## 설치

이 서브에이전트들은 `~/.claude/agents/` 디렉토리에 배치하면 자동으로 사용 가능합니다.

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## 사용법

### 자동 호출
Claude Code는 작업 맥락과 하위 에이전트의 설명에 따라 적절한 하위 에이전트에 자동으로 위임합니다.

### 명시적 호출
요청 시 하위 에이전트 이름을 명시하세요:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## 사용 예시

### 단일 에이전트 작업
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```
### 다중 에이전트 워크플로우

이 하위 에이전트들은 원활하게 함께 작동하며, 더 복잡한 오케스트레이션의 경우, 이러한 하위 에이전트를 활용하는 52개의 사전 구축된 슬래시 명령어를 제공하는 **[Claude 코드 명령어](https://github.com/wshobson/commands)** 컬렉션을 사용할 수 있습니다.


```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### 슬래시 명령어를 이용한 고급 워크플로우

더 정교한 다중 서브에이전트 오케스트레이션을 위해 동반 [명령어 저장소](https://github.com/wshobson/commands)를 사용하세요:

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## 서브에이전트 형식

각 서브에이전트는 다음 구조를 따릅니다:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```
### 모델 구성

Claude Code v1.0.64부터 서브에이전트는 사용할 Claude 모델을 지정할 수 있습니다. 이를 통해 복잡도에 따른 비용 효율적인 작업 위임이 가능합니다:

- **낮은 복잡도 (Haiku)**: 기본 데이터 분석, 문서 생성, 표준 응답과 같은 간단한 작업
- **중간 복잡도 (Sonnet)**: 개발 작업, 코드 리뷰, 테스트 및 일반 엔지니어링 업무  
- **높은 복잡도 (Opus)**: 보안 감사, 아키텍처 검토, 사고 대응 및 AI/ML 엔지니어링과 같은 중요 작업

사용 가능한 모델 (Claude Code v1.0.64 기준 단순화 명칭):
- `haiku` - 간단한 작업에 빠르고 비용 효율적임
- `sonnet` - 대부분 개발 작업에 균형 잡힌 성능 제공
- `opus` - 복잡한 분석 및 중요 작업에 가장 적합

모델이 지정되지 않으면 서브에이전트는 시스템의 기본 모델을 사용합니다.

## 에이전트 오케스트레이션 패턴

Claude Code는 다음과 같은 일반적인 패턴을 사용하여 에이전트를 자동으로 조정합니다:

### 순차적 작업 흐름

```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### 조건 분기
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### 검토 및 검증
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```
## 어떤 에이전트를 언제 사용해야 하는가

### 🏗️ 기획 & 아키텍처
- **backend-architect**: API 설계, 데이터베이스 스키마, 시스템 아키텍처
- **frontend-developer**: UI/UX 기획, 컴포넌트 아키텍처
- **ui-ux-designer**: 인터페이스 디자인, 와이어프레임, 디자인 시스템, 사용자 조사
- **cloud-architect**: 인프라 설계, 확장성 계획

### 🔧 구현 & 개발  
- **python-pro**: 파이썬 관련 개발 작업
- **golang-pro**: Go 관련 개발 작업
- **rust-pro**: Rust 개발, 메모리 안전성, 시스템 프로그래밍
- **c-pro**: C 프로그래밍, 임베디드 시스템, 성능 중심 코드
- **javascript-pro**: 최신 자바스크립트, 비동기 패턴, Node.js/브라우저 코드
- **typescript-pro**: 고급 타입스크립트, 제네릭, 타입 추론, 엔터프라이즈 패턴
- **java-pro**: 최신 자바 개발, 스트림, 동시성, Spring Boot
- **elixir-pro**: 엘릭서 개발, OTP 패턴, Phoenix 프레임워크, 함수형 프로그래밍
- **csharp-pro**: 최신 C# 개발, .NET 프레임워크, 엔터프라이즈 패턴
- **scala-pro**: 엔터프라이즈 스칼라 및 함수형 프로그래밍, Apache Pekko/Akka 액터, Apache Spark, ZIO/Cats Effect, 반응형 아키텍처
- **unity-developer**: 유니티 게임 개발, C# 스크립팅, 성능 최적화
- **minecraft-bukkit-pro**: 마인크래프트 플러그인 개발, 이벤트 시스템, 서버 측 기능
- **ios-developer**: Swift/SwiftUI를 이용한 네이티브 iOS 개발
- **sql-pro**: 데이터베이스 쿼리, 스키마 설계, 쿼리 최적화
- **mobile-developer**: React Native/Flutter 개발

### 🛠️ 운영 & 유지보수
- **devops-troubleshooter**: 운영 이슈, 배포 문제
- **incident-responder**: 즉각적인 대응이 필요한 심각한 장애
- **database-optimizer**: 쿼리 성능, 인덱싱 전략
- **database-admin**: 백업 전략, 복제, 사용자 관리, 재해 복구
- **terraform-specialist**: 코드로 인프라 관리, Terraform 모듈, 상태 관리
- **network-engineer**: 네트워크 연결, 로드 밸런서, SSL/TLS, DNS 디버깅

### 📊 분석 & 최적화
- **performance-engineer**: 애플리케이션 병목, 최적화
- **security-auditor**: 취약점 스캔, 컴플라이언스 점검
- **data-scientist**: 데이터 분석, 인사이트, 리포팅
- **mlops-engineer**: ML 인프라, 실험 추적, 모델 레지스트리, 파이프라인 자동화


### 🧪 품질 보증
- **code-reviewer**: 코드 품질, 구성 보안, 운영 신뢰성
- **test-automator**: 테스트 전략, 테스트 스위트 생성
- **debugger**: 버그 조사, 오류 해결
- **error-detective**: 로그 분석, 오류 패턴 인식, 근본 원인 분석
- **search-specialist**: 심층 웹 리서치, 경쟁 분석, 사실 확인

### 📚 문서화
- **api-documenter**: OpenAPI/Swagger 명세, API 문서
- **docs-architect**: 종합 기술 문서, 아키텍처 가이드, 시스템 매뉴얼
- **reference-builder**: 포괄적인 API 레퍼런스, 구성 가이드, 파라미터 문서
- **tutorial-engineer**: 단계별 튜토리얼, 학습 경로, 교육 콘텐츠

### 💼 비즈니스 & 전략
- **business-analyst**: KPI, 수익 모델, 성장 전망, 투자자 지표
- **risk-manager**: 포트폴리오 위험, 헤지 전략, R-멀티플, 포지션 크기 조정
- **content-marketer**: SEO 콘텐츠, 블로그 게시물, 소셜 미디어, 이메일 캠페인
- **sales-automator**: 콜드 이메일, 팔로업, 제안서, 리드 육성
- **customer-support**: 지원 티켓, FAQ, 도움말 문서, 문제 해결
- **legal-advisor** - 개인정보 처리방침, 서비스 약관, 면책 조항, 법적 고지 초안 작성

## 모범 사례

### 🎯 작업 위임
1. **Claude Code가 자동으로 위임하도록 하세요** - 메인 에이전트가 상황을 분석하고 최적의 에이전트를 선택
2. **요구사항을 구체적으로 명시하세요** - 제약 조건, 기술 스택, 품질 기준 포함
3. **에이전트 전문성을 신뢰하세요** - 각 에이전트는 해당 분야에 최적화됨

### 🔄 다중 에이전트 워크플로우
4. **상위 레벨 요청부터 시작하세요** - 에이전트가 복잡한 다단계 작업을 조정하도록
5. **에이전트 간 맥락을 제공하세요** - 에이전트가 필요한 배경 정보를 갖추도록 보장
6. **통합 지점을 검토하세요** - 다양한 에이전트의 결과가 어떻게 함께 작동하는지 확인

### 🎛️ 명시적 제어
7. **특정 요구에 명시적 호출 사용** - 특정 전문가의 관점이 필요할 때
8. **여러 에이전트를 전략적으로 결합** - 다양한 전문가가 서로의 작업을 검증
9. **특정 검토 패턴 요청** - "security-auditor가 backend-architect의 API 설계를 검토하게 하세요"

### 📈 최적화
10. **에이전트 효과성을 모니터링** - 어떤 에이전트가 귀하의 사용 사례에 가장 적합한지 파악
11. **복잡한 작업 반복 개선** - 에이전트 피드백을 활용하여 요구사항을 다듬으세요  
12. **에이전트의 강점 활용** - 작업의 복잡도를 에이전트의 역량에 맞추세요  

## 기여하기  

새로운 서브에이전트를 추가하려면:  
1. 위의 형식을 따라 새로운 `.md` 파일을 생성하세요  
2. 소문자와 하이픈으로 이름을 작성하세요  
3. 서브에이전트가 언제 사용되어야 하는지 명확하게 설명하세요  
4. 시스템 프롬프트에 구체적인 지침을 포함하세요  

## 문제 해결  

### 일반적인 문제  

**에이전트가 자동으로 호출되지 않을 때:**  
- 요청에 도메인을 명확히 표시하세요 (예: "성능 문제" → performance-engineer)  
- 작업 유형을 구체적으로 명시하세요 (예: "코드 리뷰" → code-reviewer)  

**예상치 못한 에이전트 선택:**  
- 기술 스택과 요구사항에 대한 더 많은 정보를 제공하세요  
- 특정 에이전트가 필요하다면 명시적으로 호출하세요  

**여러 에이전트가 상충된 조언을 제공할 때:**  
- 이는 정상입니다 - 각 전문가는 우선순위가 다를 수 있습니다  
- 명확히 요청하세요: "security-auditor와 performance-engineer의 권고를 조정해 주세요"  

**에이전트가 맥락을 이해하지 못하는 것 같을 때:**  
- 요청에 배경 정보를 포함하세요  
- 이전 대화나 이미 확립된 패턴을 참조하세요  

### 도움 받기  

에이전트가 예상대로 작동하지 않는 경우:  
1. 각 개별 파일의 에이전트 설명을 확인하세요  
2. 요청에 더 구체적인 언어를 사용해보세요  
3. 특정 에이전트를 테스트하기 위해 명시적으로 호출하세요  
4. 프로젝트와 목표에 대한 더 많은 맥락을 제공하세요  

## 라이선스

이 프로젝트는 MIT 라이선스 하에 제공됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 자세히 알아보기

- [Claude 코드 문서](https://docs.anthropic.com/en/docs/claude-code)
- [Subagents 문서](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude 코드 GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---