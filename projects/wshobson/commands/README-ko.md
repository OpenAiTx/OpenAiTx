
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code 슬래시 명령어

지능형 자동화를 통해 개발을 가속화하는 [Claude Code](https://docs.anthropic.com/en/docs/claude-code)를 위한 프로덕션용 슬래시 명령어입니다.

**52개의 명령어**는 다음과 같이 구성됩니다:
- **🤖 워크플로우**: 복잡한 작업을 위한 다중 서브에이전트 오케스트레이션
- **🔧 도구**: 특정 작업을 위한 단일 목적 유틸리티

### 🤝 Claude 코드 서브에이전트 필요

이 명령어들은 오케스트레이션 기능을 위해 [Claude 코드 서브에이전트](https://github.com/wshobson/agents)와 함께 작동합니다.

## 설치

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 사용 가능한 명령어

- **🤖 워크플로우** - 복잡한 작업을 위해 여러 하위 에이전트를 오케스트레이션
- **🔧 도구** - 특정 작업을 위한 단일 목적 명령어

## 사용법

명령어는 `tools/`와 `workflows/` 디렉토리로 구성됩니다. 디렉토리 접두사와 함께 사용하세요:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**참고:** 접두어 없이 명령어를 사용하려면 디렉토리를 평탄화할 수 있습니다.
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code는 컨텍스트에 따라 관련 명령어를 자동으로 제안합니다.

## 🤖 워크플로우

복잡한 작업을 위한 다중 서브에이전트 오케스트레이션:

### 기능 개발
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 백엔드, 프론트엔드, 테스트, 배포 서브에이전트가 완전한 기능을 구축
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 여러 리뷰 서브에이전트가 포괄적인 코드 분석 제공
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 문제를 분석하고 적합한 전문 서브에이전트에게 위임

### 개발 프로세스
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 브랜칭 전략과 PR 템플릿을 활용한 효과적인 Git 워크플로우 구현
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 프롬프트 최적화를 통해 서브에이전트 성능 향상
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 전문 서브에이전트를 사용하여 레거시 코드베이스 현대화
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 데이터 및 ML 엔지니어링 서브에이전트로 ML 파이프라인 구축
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 협력 서브에이전트로 크로스 플랫폼 앱 제작
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, 모니터링, 배포 워크플로우 자동화

### 서브에이전트 오케스트레이션 워크플로우
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 백엔드, 프론트엔드, 모바일 서브에이전트가 협업하는 멀티 플랫폼 기능
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 전문 서브에이전트가 보안 중심으로 구현
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 데이터 사이언스 서브에이전트가 포함된 ML 기반 기능
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 성능 서브에이전트를 통한 엔드 투 엔드 최적화
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 운영 서브에이전트로 프로덕션 장애 대응

## 🔧 도구 (단일 목적 명령어)

### AI & 머신러닝
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 실무용 AI 어시스턴트 및 챗봇 구축
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML 코드베이스를 위한 전문 리뷰
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 최신 패턴을 활용하여 LangChain/LangGraph 에이전트 생성
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps 기반의 엔드 투 엔드 ML 파이프라인 구축
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - AI 프롬프트의 성능 및 품질 최적화

### 아키텍처 & 코드 품질
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 복잡한 코드에 대한 상세 설명 생성
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 언어, 프레임워크, 버전 간 코드 마이그레이션
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 유지보수성과 성능을 위한 코드 리팩터링
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 기술 부채 분석 및 우선순위 지정

### 데이터 & 데이터베이스
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 확장 가능한 데이터 파이프라인 아키텍처 설계
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 포괄적인 데이터 검증 시스템 구현
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 고급 데이터베이스 마이그레이션 전략

### 데브옵스 & 인프라
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 배포 구성 및 체크리스트 생성
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 고급 컨테이너 최적화 전략
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 프로덕션 수준의 쿠버네티스 배포
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 포괄적인 모니터링 및 관측성 구축
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 서비스 수준 목표(SLO) 구현
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 개발 및 운영 워크플로우 자동화

### 개발 & 테스트
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 개발 및 테스트를 위한 현실적인 API 목 생성
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 완전한 구현 스택을 갖춘 프로덕션 준비 API 엔드포인트 생성
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 프레임워크 감지를 통한 포괄적 테스트 스위트 생성

### 보안 & 컴플라이언스
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 포괄적 접근성 테스트 및 수정
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 규제 준수 보장(GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 자동화된 수정 기능을 갖춘 포괄적 보안 스캔

### 디버깅 & 분석
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 고급 디버깅 및 추적 전략
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 심층 오류 패턴 분석 및 해결 전략
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 프로덕션 오류 추적 및 진단
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 구조화된 GitHub/GitLab 이슈 생성

### 의존성 & 구성
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 애플리케이션 구성 검증 및 관리
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 보안 및 라이선스 관점의 의존성 감사
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 프로젝트 의존성 안전하게 업그레이드

### 문서화 & 협업
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 포괄적인 문서 자동 생성
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 효과적인 Git 워크플로우 구현
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 품질 검사를 통한 풀 리퀘스트 개선

### 비용 최적화
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 클라우드 및 인프라 비용 최적화

### 온보딩 및 셋업
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 신규 팀원을 위한 개발 환경 셋업

### 서브에이전트 도구
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 특화된 서브에이전트로 다각도 코드 리뷰
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 디버거 및 성능 서브에이전트를 활용한 심층 디버깅
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 다수 서브에이전트를 통한 풀스택 최적화
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - 컨텍스트 관리 서브에이전트로 프로젝트 컨텍스트 저장
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 연속성을 위한 저장된 컨텍스트 복원

## 기능

- 프로덕션 환경 적용 가능 구현
- 프레임워크 자동 감지
- 보안 베스트 프랙티스
- 내장 모니터링 및 테스트 기능
- 명령어 간 원활한 연동

## 명령어 수

**총: 52개의 프로덕션 환경용 슬래시 명령어**가 다음으로 구성됨:

### 🤖 워크플로우 (14개 명령어)

- 기능 개발 및 리뷰 (3개 명령어) 
- 개발 프로세스 자동화 (6개 명령어)
- 서브에이전트 기반 워크플로우 (5개 명령어)

### 🔧 도구 (38개 명령어)

- AI 및 머신러닝 (5개 명령어)
- 아키텍처 및 코드 품질 (4개 명령어)
- 데이터 및 데이터베이스 (3개 명령어)
- 데브옵스 및 인프라 (6개 명령어)
- 개발 및 테스트 (3개 명령어)
- 보안 및 컴플라이언스 (3개 명령어)
- 디버깅 및 분석 (4개 명령어)
- 종속성 및 구성 (3개 명령어)
- 문서화 및 협업 (1개 명령어)
- 온보딩 및 설정 (1개 명령어)
- 서브에이전트 전용 도구 (5개 명령어)

## 사용 예시

### 🤖 워크플로우 예시

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 도구 예제 (단일 목적 명령)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## 고급 명령어

### 보안 & 데브옵스

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

자동화된 수정 기능을 포함한 종합 보안 스캔.

- **다중 도구 스캔**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **자동 수정**: 일반적인 취약점 자동 해결
- **CI/CD 통합**: GitHub Actions/GitLab CI용 보안 게이트
- **컨테이너 스캔**: 이미지 취약점 분석
- **비밀 탐지**: GitLeaks 및 TruffleHog 통합

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

고급 컨테이너 최적화 전략.

- **스마트 최적화**: 분석 및 개선 사항 제안
- **멀티스테이지 빌드**: 프레임워크별 최적화된 Dockerfile
- **최신 도구**: 더 빠른 빌드를 위한 BuildKit, Bun, UV
- **보안 강화**: Distroless 이미지, 비루트 사용자
- **교차 명령 통합**: /api-scaffold 출력과 연동

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

프로덕션 등급 Kubernetes 배포.

- **고급 패턴**: 파드 보안 표준, 네트워크 정책, OPA
- **GitOps 지원**: FluxCD 및 ArgoCD 구성
- **관측성**: Prometheus ServiceMonitors, OpenTelemetry
- **자동 스케일링**: HPA, VPA 및 클러스터 오토스케일러 설정
- **서비스 메시**: Istio/Linkerd 통합

### 프론트엔드 & 데이터

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

고급 데이터베이스 마이그레이션 전략.

- **다중 데이터베이스**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **무중단**: 블루-그린 배포, 롤링 마이그레이션
- **이벤트 소싱**: CDC를 위한 Kafka/Kinesis 통합
- **크로스 플랫폼**: 폴리글롯 퍼시스턴스 처리
- **모니터링**: 마이그레이션 상태 점검 및 롤백

## 워크플로우와 도구의 결합

진정한 강점은 전체 개발 주기를 위해 워크플로우와 도구를 결합하는 데 있습니다:

### 예시: 새로운 기능 개발

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```
### 예제: 레거시 코드 현대화


```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## 명령 조정 패턴

명령은 개별적으로 사용하거나 강력한 패턴으로 결합할 수 있습니다:

### 순차 실행
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### 병렬 분석
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 반복적 정제
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### 교차 도메인 통합
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## 워크플로우와 툴을 사용할 때

### 🔀 워크플로우 & 서브에이전트 툴
- **문제 해결**: 적응적으로 문제를 분석하고 해결
- **다중 관점**: 전문 서브에이전트 협력
- **복잡한 작업**: 여러 분야에 걸친 다단계 프로세스
- **해결책 미확정**: 서브에이전트가 접근 방식 결정

### 🛠️ 전문화된 툴
- **인프라 설정**: 환경 구성
- **코드 생성**: 구체적 구현 작성
- **분석**: 수정 없이 보고서 생성
- **도메인 작업**: 고도로 특화된 작업

**예시:**
- "사용자 인증 시스템 구현" → `/workflows:feature-development`
- "스택 전체 성능 문제 수정" → `/workflows:smart-fix`
- "레거시 모놀리스를 현대화" → `/workflows:legacy-modernize`

### 🔧 툴을 사용할 때:
- **특정 전문성 필요** - 한 분야에 명확하고 집중된 작업
- **정확한 제어 원함** - 구체적 구현 세부사항 직접 지정
- **수동 워크플로우 일부** - 기존 프로세스에 통합
- **깊은 전문화 요구** - 전문가 수준 구현 필요
- **기존 작업 기반** - 이전 출력물 개선 또는 정제

**예시:**
- "쿠버네티스 매니페스트 생성" → `/tools:k8s-manifest`
- "보안 취약점 스캔" → `/tools:security-scan`
- "API 문서 생성" → `/tools:doc-generate`

## 명령어 형식

슬래시 명령어는 간단한 마크다운 파일로:
- 파일명이 명령어 이름이 됨 (예: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- 파일 내용은 호출 시 실행되는 프롬프트/지침
- 사용자 입력은 `$ARGUMENTS` 플레이스홀더 사용

## 모범 사례

### 명령 선택
- **Claude Code가 자동으로 제안하도록 하기** - 컨텍스트를 분석하여 최적의 명령 선택
- **복잡한 작업에 워크플로우 사용** - 서브에이전트들이 다중 도메인 구현을 조정
- **집중 작업에 도구 사용** - 특정 명령을 적용하여 타겟 개선 수행

### 효과적인 사용법
- **포괄적 컨텍스트 제공** - 기술 스택, 제약 조건, 요구사항 포함
- **명령을 전략적으로 연결** - 워크플로우 → 도구 → 세부 개선
- **이전 출력물을 기반으로 구축** - 명령들이 함께 작동하도록 설계됨

## 기여하기

1. `workflows/` 또는 `tools/`에 `.md` 파일 생성
2. 소문자-하이픈-이름 사용
3. 사용자 입력을 위한 `$ARGUMENTS` 포함

## 문제 해결

**명령을 찾을 수 없음**: 
- 파일이 `~/.claude/commands/tools/` 또는 `~/.claude/commands/workflows/`에 있는지 확인
- 올바른 접두어 사용: `/tools:command-name` 또는 `/workflows:command-name`
- 또는 접두어 없이 디렉터리 평탄화: `cp tools/*.md . && cp workflows/*.md .`

**워크플로우가 느림**: 정상 - 여러 서브에이전트 조정 때문

**일반 출력**: 기술 스택에 대해 더 구체적인 컨텍스트 추가

**통합 문제**: 파일 경로와 명령 순서 확인

## 성능 팁

**명령 선택:**
- **워크플로우**: 복잡한 기능을 위한 다중 서브에이전트 조정
- **도구**: 특정 작업을 위한 단일 목적의 연산
- **간단한 편집**: 메인 에이전트만 사용

**최적화:**
- 알려진 문제에는 도구부터 시작
- 요구사항을 상세히 미리 제공
- 이전 명령 출력에 기반하여 작업을 진행하세요
- 수정 전에 워크플로우가 완료되도록 하세요

### 새로운 워크플로우 추가:
- 서브에이전트 오케스트레이션 및 위임 로직에 집중하세요
- 어떤 특화된 서브에이전트를 어떤 순서로 사용할지 명확히 지정하세요
- 서브에이전트 간의 협업 패턴을 정의하세요

### 새로운 도구 추가:
- 완전하고 실제 환경에서 사용할 수 있는 구현을 포함하세요
- 명확한 섹션과 실행 가능한 결과물로 내용을 구성하세요
- 예시, 모범 사례, 통합 포인트를 포함하세요

## 더 알아보기

- [Claude Code 문서](https://docs.anthropic.com/en/docs/claude-code)
- [슬래시 명령어 문서](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [서브에이전트 문서](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 서브에이전트 컬렉션](https://github.com/wshobson/agents) - 이 명령어에서 사용되는 특화 서브에이전트


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---