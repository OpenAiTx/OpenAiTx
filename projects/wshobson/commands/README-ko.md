# Claude Code 슬래시 명령어

지능형 자동화를 통해 개발 속도를 높이는 [Claude Code](https://docs.anthropic.com/en/docs/claude-code)용 프로덕션 준비된 슬래시 명령어입니다.

**52개의 명령어**로 구성되어 있습니다:
- **🤖 워크플로우**: 복잡한 작업을 위한 다중 서브에이전트 오케스트레이션
- **🔧 도구**: 특정 작업을 위한 단일 목적 유틸리티

### 🤝 Claude Code 서브에이전트 필요

이 명령어들은 오케스트레이션 기능을 위해 [Claude Code 서브에이전트](https://github.com/wshobson/agents)와 함께 작동합니다.

## 설치

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```
## 사용 가능한 명령어

- **🤖 워크플로우** - 복잡한 작업을 위한 여러 하위 에이전트 조율
- **🔧 도구** - 특정 작업을 위한 단일 목적 명령어

## 사용법


```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code는 상황에 맞는 관련 명령을 자동으로 제안합니다.

## 🤖 워크플로우

복잡한 작업을 위한 다중 하위 에이전트 오케스트레이션:

### 기능 개발
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 백엔드, 프런트엔드, 테스트 및 배포 하위 에이전트가 완전한 기능을 구축합니다
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 여러 리뷰 하위 에이전트가 포괄적인 코드 분석을 제공합니다
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 문제를 분석하고 적절한 전문 하위 에이전트에 위임합니다

### 개발 프로세스
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 브랜칭 전략과 PR 템플릿을 통한 효과적인 Git 워크플로우 구현
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 프롬프트 최적화를 통해 하위 에이전트 성능 향상
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 전문 하위 에이전트를 사용하여 레거시 코드베이스 현대화
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 데이터 및 ML 엔지니어링 하위 에이전트와 함께 ML 파이프라인 생성
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 협업 하위 에이전트를 통한 크로스 플랫폼 앱 구축
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, 모니터링, 배포 워크플로우 자동화

### 하위 에이전트 오케스트레이션 워크플로우
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 백엔드, 프런트엔드, 모바일 하위 에이전트를 포함한 다중 플랫폼 기능
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 전문 하위 에이전트와 함께하는 보안 우선 구현
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 데이터 과학 하위 에이전트를 활용한 ML 기반 기능
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 성능 하위 에이전트와 함께하는 엔드 투 엔드 최적화
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 운영 하위 에이전트를 통한 프로덕션 사고 해결

## 🔧 도구 (단일 목적 명령)

### AI 및 머신러닝
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 프로덕션 준비된 AI 어시스턴트 및 챗봇 구축
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML 코드베이스를 위한 전문 리뷰
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 최신 패턴을 사용한 LangChain/LangGraph 에이전트 생성
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps를 통한 엔드 투 엔드 ML 파이프라인 생성
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - 성능 및 품질을 위한 AI 프롬프트 최적화

### 아키텍처 및 코드 품질
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 복잡한 코드에 대한 상세한 설명 생성
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 언어, 프레임워크 또는 버전 간 코드 마이그레이션
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 유지보수성과 성능을 위한 코드 리팩토링
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 기술 부채 분석 및 우선순위 지정

### 데이터 및 데이터베이스
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 확장 가능한 데이터 파이프라인 아키텍처 설계
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 포괄적인 데이터 검증 시스템 구현
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 고급 데이터베이스 마이그레이션 전략

### 데브옵스 및 인프라
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 배포 구성 및 체크리스트 생성
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 고급 컨테이너 최적화 전략
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 프로덕션 등급 쿠버네티스 배포
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 포괄적인 모니터링 및 관찰성 설정
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 서비스 수준 목표(SLO) 구현
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 개발 및 운영 워크플로우 자동화

### 개발 및 테스트
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 개발 및 테스트를 위한 현실적인 API 목 생성
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 완전 구현 스택을 갖춘 프로덕션 준비 API 엔드포인트 생성
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 프레임워크 감지를 통한 포괄적 테스트 스위트 생성

### 보안 및 컴플라이언스
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 포괄적인 접근성 테스트 및 수정
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 규제 준수 보장 (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 자동화된 수정 기능을 갖춘 포괄적 보안 스캔

### 디버깅 및 분석
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 고급 디버깅 및 추적 전략
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 심층 오류 패턴 분석 및 해결 전략
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 프로덕션 오류 추적 및 진단
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 잘 구조화된 GitHub/GitLab 이슈 생성

### 종속성 및 구성
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 애플리케이션 구성 검증 및 관리
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 보안 및 라이선스 종속성 감사
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 프로젝트 종속성 안전 업그레이드

### 문서화 및 협업
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 포괄적인 문서 생성
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 효과적인 Git 워크플로우 구현
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 품질 검사를 통한 풀 리퀘스트 향상

### 비용 최적화
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 클라우드 및 인프라 비용 최적화

### 온보딩 및 설정
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 신규 팀원을 위한 개발 환경 설정

### 하위 에이전트 도구
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 전문 하위 에이전트와 다각도 코드 리뷰
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 디버거 및 성능 하위 에이전트와 심층 디버깅
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 여러 하위 에이전트와 전체 스택 최적화
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - context-manager 하위 에이전트를 사용한 프로젝트 컨텍스트 저장
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 연속성을 위한 저장된 컨텍스트 복원

## 기능

- 프로덕션 준비 구현
- 프레임워크 자동 감지
- 보안 모범 사례
- 내장 모니터링 및 테스트

- 명령어가 원활하게 함께 작동합니다

## 명령어 수

**총: 52개의 프로덕션 준비 완료 슬래시 명령어** 로 구성됨:

### 🤖 워크플로우 (14개 명령어)

- 기능 개발 및 검토 (3개 명령어) 
- 개발 프로세스 자동화 (6개 명령어)
- 서브에이전트 오케스트레이션 워크플로우 (5개 명령어)

### 🔧 도구 (38개 명령어)

- AI 및 머신러닝 (5개 명령어)
- 아키텍처 및 코드 품질 (4개 명령어)
- 데이터 및 데이터베이스 (3개 명령어)
- 데브옵스 및 인프라 (6개 명령어)
- 개발 및 테스트 (3개 명령어)
- 보안 및 규정 준수 (3개 명령어)
- 디버깅 및 분석 (4개 명령어)
- 의존성 및 구성 (3개 명령어)
- 문서화 및 협업 (1개 명령어)
- 온보딩 및 설정 (1개 명령어)
- 서브에이전트 전용 도구 (5개 명령어)

## 사용 예시

### 🤖 워크플로우 예시

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 도구 예제 (단일 목적 명령)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```
## 향상된 명령어

### 보안 및 DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

자동 복구가 포함된 종합 보안 스캐닝.

- **다중 도구 스캐닝**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **자동 수정**: 일반 취약점 자동 복구
- **CI/CD 통합**: GitHub Actions/GitLab CI 보안 게이트
- **컨테이너 스캐닝**: 이미지 취약점 분석
- **비밀 탐지**: GitLeaks 및 TruffleHog 통합

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

고급 컨테이너 최적화 전략.

- **스마트 최적화**: 분석 및 개선 제안
- **멀티 스테이지 빌드**: 프레임워크별 최적화 Dockerfile
- **최신 도구**: BuildKit, Bun, UV로 빠른 빌드
- **보안 강화**: Distroless 이미지, 비루트 사용자
- **크로스 명령 통합**: /api-scaffold 출력과 연동

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

프로덕션급 Kubernetes 배포.

- **고급 패턴**: Pod 보안 표준, 네트워크 정책, OPA
- **GitOps 준비**: FluxCD 및 ArgoCD 구성
- **관측성**: Prometheus ServiceMonitors, OpenTelemetry
- **자동 확장**: HPA, VPA 및 클러스터 오토스케일러 구성
- **서비스 메시**: Istio/Linkerd 통합

### 프론트엔드 및 데이터

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

고급 데이터베이스 마이그레이션 전략.

- **다중 데이터베이스**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **제로 다운타임**: 블루-그린 배포, 롤링 마이그레이션
- **이벤트 소싱**: Kafka/Kinesis 통합 CDC 지원
- **크로스 플랫폼**: 폴리글롯 지속성 처리
- **모니터링**: 마이그레이션 상태 점검 및 롤백

## 워크플로우 및 도구 결합

완전한 개발 주기를 위한 워크플로우와 도구 결합에서 진정한 힘이 나옵니다:

### 예시: 새로운 기능 빌드하기


```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```
### 예제: 레거시 코드 현대화


```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## 명령 조정 패턴

명령은 개별적으로 사용하거나 강력한 패턴으로 결합할 수 있습니다:

### 순차 실행
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### 병렬 분석
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 반복적 정제
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### 교차 도메인 통합
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## 워크플로우와 도구 사용 시기

### 🔀 워크플로우 & 서브에이전트 도구
- **문제 해결**: 문제를 분석하고 적응적으로 수정
- **다양한 관점**: 전문 서브에이전트 조정
- **복잡한 작업**: 여러 도메인에 걸친 다단계 프로세스
- **알려지지 않은 해결책**: 서브에이전트가 접근 방식 결정

### 🛠️ 전문 도구
- **인프라 설정**: 환경 구성
- **코드 생성**: 특정 구현 생성
- **분석**: 수정 없이 보고서 생성
- **도메인 작업**: 고도로 전문화된 작업

**예시:**
- "사용자 인증 시스템 구현" → `/feature-development`
- "스택 전반 성능 문제 수정" → `/smart-fix`
- "레거시 모놀리식 현대화" → `/legacy-modernize`

### 🔧 도구 사용 시:
- **특정 전문 지식 필요** - 하나의 도메인에 명확하고 집중된 작업
- **정밀한 제어 필요** - 구체적인 구현 세부사항을 직접 지시
- **수동 워크플로우 일부** - 기존 프로세스에 통합
- **깊은 전문화 요구** - 전문가 수준 구현 필요
- **기존 작업 기반** - 이전 결과물 향상 또는 수정

**예시:**
- "쿠버네티스 매니페스트 생성" → `/k8s-manifest`
- "보안 취약점 스캔" → `/security-scan`
- "API 문서 생성" → `/doc-generate`

## 명령어 형식

슬래시 명령어는 간단한 마크다운 파일로 구성되며:
- 파일 이름이 명령어 이름이 됨 (예: `api-scaffold.md` → `/api-scaffold`)
- 파일 내용은 호출 시 실행되는 프롬프트/지침
- 사용자 입력에는 `$ARGUMENTS` 자리 표시자 사용

## 모범 사례

### 명령어 선택
- **Claude Code 자동 제안 활용** - 컨텍스트 분석 후 최적 명령어 선택
- **복잡한 작업에는 워크플로우 사용** - 서브에이전트가 다중 도메인 구현 조정
- **집중 작업에는 도구 사용** - 특정 명령어로 목표 개선 적용

### 효과적인 사용법
- **포괄적 컨텍스트 제공** - 기술 스택, 제약 조건, 요구사항 포함
- **명령어 체인 전략적 구성** - 워크플로우 → 도구 → 수정
- **이전 출력물 기반 구축** - 명령어들이 상호 연동되도록 설계됨

## 기여 방법

1. `workflows/` 또는 `tools/`에 `.md` 파일 생성
2. 소문자-하이픈 이름 사용
3. 사용자 입력용 `$ARGUMENTS` 포함

## 문제 해결

**명령어를 찾을 수 없음**: `~/.claude/commands/`에 파일 존재 여부 확인

**워크플로우 느림**: 정상 - 여러 서브에이전트 조정 중

**일반적인 출력**: 기술 스택 관련 구체적 컨텍스트 추가

**통합 문제**: 파일 경로 및 명령어 순서 확인

## 성능 팁

**명령어 선택:**
- **워크플로우**: 복잡 기능 위한 다중 서브에이전트 조정
- **도구**: 특정 작업 위한 단일 목적 운영
- **간단한 편집**: 메인 에이전트 유지

**최적화:**
- 알려진 문제는 도구로 시작
- 상세 요구사항 사전 제공
- 이전 명령 결과 기반 구축
- 워크플로우 완료 후 수정 진행

### 새 워크플로우 추가:
- 서브에이전트 조정 및 위임 로직에 집중
- 사용할 전문 서브에이전트 및 순서 명시
- 서브에이전트 간 조정 패턴 정의

### 새 도구 추가:
- 완전하고 프로덕션 수준 구현 포함
- 명확한 섹션과 실행 가능한 출력 구조화
- 예시, 모범 사례, 통합 포인트 포함

## 더 알아보기

- [Claude Code 문서](https://docs.anthropic.com/en/docs/claude-code)
- [슬래시 명령어 문서](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [서브에이전트 문서](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 서브에이전트 모음](https://github.com/wshobson/agents) - 이 명령어들이 사용하는 전문 서브에이전트



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---