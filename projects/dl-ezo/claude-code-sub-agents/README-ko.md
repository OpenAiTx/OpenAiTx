# Claude Code 종합 에이전트 모음

**언어**: [영어](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README.md) | [日本語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README_JA.md)

요구 사항 분석부터 운영 배포 및 지속적인 유지보수까지, 소프트웨어 개발 자동화를 위한 Claude Code의 전문 하위 에이전트 완전 모음입니다.

## 🎯 개요

이 저장소에는 최소한의 인간 개입으로 완전한 소프트웨어 개발 수명주기를 처리하도록 설계된 Claude Code 하위 에이전트의 종합 세트가 포함되어 있습니다. 에이전트는 현대 소프트웨어 개발의 모든 측면을 다루는 여섯 가지 카테고리로 구성되어 있습니다.

## 📦 에이전트 카테고리

### 1. 요구사항 및 분석
**목적**: 비즈니스 요구를 상세한 기술 명세로 전환

- **requirements-analyst** - 사용자 요구를 분석하고 상세한 기능 명세 작성
- **user-story-generator** - 포괄적인 사용자 스토리 및 수용 기준 생성  
- **business-process-analyst** - 비즈니스 프로세스를 분석하고 기술 요구사항으로 변환
- **requirements-validator** - 요구사항의 완전성과 일관성 검증

### 2. 설계 및 아키텍처
**목적**: 견고하고 확장 가능한 시스템 설계 수립

- **system-architect** - 포괄적인 시스템 아키텍처 및 기술 스택 설계
- **data-architect** - 데이터 모델, 스키마, 통합 전략 설계
- **interface-designer** - 사용자 인터페이스 및 API 명세 설계
- **security-architect** - 보안 프레임워크 및 데이터 보호 전략 설계
- **design-reviewer** - 시스템 설계 품질 검토 및 검증

### 3. 구현 및 개발
**목적**: 코드 개발 및 품질 보증 전반 처리

- **code-reviewer** - 포괄적인 코드 품질 평가 수행
- **test-suite-generator** - 광범위한 테스트 커버리지 생성
- **code-refactoring-specialist** - 안전하게 코드 구조 개선 및 기술 부채 감소
- **security-analyzer** - 취약점 및 보안 문제 식별
- **performance-optimizer** - 코드 성능 분석 및 최적화
- **api-designer** - 적절한 명세를 갖춘 깔끔한 RESTful API 설계
- **documentation-generator** - 기술 문서 및 코드 주석 생성
- **dependency-manager** - 패키지 의존성 관리 및 충돌 해결
- **database-schema-designer** - 효율적인 데이터베이스 스키마 및 마이그레이션 설계
- **git-manager** - Git 작업, 커밋 구성 및 저장소 유지 관리
- **cicd-builder** - CI/CD 파이프라인 생성 및 구성

### 4. 프로젝트 관리
**목적**: 전체 개발 프로세스 조정 및 관리

- **project-planner** - 포괄적인 프로젝트 계획 및 일정 수립
- **risk-manager** - 프로젝트 위험 식별 및 완화 전략 수립
- **progress-tracker** - 프로젝트 진행 상황 모니터링 및 장애 요소 식별
- **qa-coordinator** - 품질 기준 설정 및 테스트 조정
- **stakeholder-communicator** - 이해관계자 소통 및 보고 관리

### 5. 배포 및 운영
**목적**: 운영 배포 및 지속적인 운영 처리

- **project-orchestrator** - 엔드투엔드 프로젝트 실행의 마스터 코디네이터
- **deployment-ops-manager** - 운영 배포 및 운영 모니터링 처리
- **uat-coordinator** - 비즈니스 이해관계자와 사용자 수용 테스트 조정
- **training-change-manager** - 교육 자료 작성 및 시스템 도입 관리
- **project-template-manager** - 프로젝트 템플릿 관리 및 일반 프로젝트 패턴 신속 설정

### 6. 메타 관리
**목적**: Claude Code 자체의 최대 효율성 최적화

- **context-manager** - 세션 컨텍스트 모니터링 및 연속성 정보 관리
- **session-continuity-manager** - Claude Code 세션 간 원활한 전환 보장
- **memory-manager** - Claude Code 메모리 사용 및 프로젝트 문서 최적화
- **workflow-optimizer** - 개발 워크플로우 및 에이전트 사용 분석 및 최적화
- **resource-monitor** - 자원 사용 모니터링 및 최적화 전략 제안
- **agent-creator** - 프로젝트 필요에 따라 새로운 전문 에이전트 동적 생성

## 🚀 주요 기능

### 완전 자동화
- **엔드투엔드 개발**: 요구사항부터 운영 배포까지
- **지능형 조율**: 에이전트가 자동으로 작업을 조정 및 순서 지정
- **동적 전문화**: 고유 프로젝트 요구에 맞는 신규 에이전트 생성
- **세션 연속성**: 긴 개발 세션 간 컨텍스트 유지

### 전문 품질
- **업계 모범 사례**: 각 에이전트는 확립된 방법론 준수
- **포괄적 테스트**: 자동 테스트 생성 및 품질 보증
- **보안 우선**: 내장된 보안 분석 및 규정 준수 점검
- **운영 준비 완료**: 완전한 배포 및 운영 지원

### 확장 가능한 아키텍처
- **모듈식 설계**: 개별 에이전트 또는 전체 워크플로우 사용 가능
- **컨텍스트 보존**: 긴 프로젝트를 위한 효율적 메모리 관리
- **자원 최적화**: Claude Code 사용 모니터링 및 최적화
- **템플릿 기반**: 검증된 패턴으로 신속한 프로젝트 설정

## 💡 사용 사례

### 완전한 프로젝트 자동화
```
User: "Create a library management system for our company"
Result: Fully functional web application with database, API, frontend, tests, documentation, and deployment
```
### 전문 개발 작업

```
User: "Review this authentication code for security issues"
Agent: security-analyzer performs comprehensive security audit
```

### 장기 프로젝트 관리
```
User: "Manage the development of a multi-tenant SaaS platform"
Agent: project-orchestrator coordinates all phases with appropriate specialists
```

## 📋 설치

1. **에이전트 정의를 복제하거나 복사**하여 프로젝트의 `.claude/agents/` 디렉터리에 넣으세요:
   ```bash
   mkdir -p .claude/agents
   # Copy the agent definition files to this directory
   ```

2. **설치 확인**:
   ```bash
   ls .claude/agents/
   # Should show all agent files (.md format)
   ```

3. **클로드 코드에서 에이전트 사용 시작하기**:
   ```
   Use the project-orchestrator agent to build a complete web application
   ```

## 🎮 사용 예제

### 새 웹 애플리케이션 시작하기
```
"I want to build a task management web application with user authentication, real-time updates, and mobile responsiveness. Handle everything from requirements to deployment."
```

**프로젝트-오케스트레이터**는 다음을 수행합니다:
1. **요구사항-분석가**를 사용하여 상세 요구사항 수집
2. 설계를 위해 **시스템-아키텍트** 및 **데이터-아키텍트** 조정
3. 개발 에이전트와 함께 구현 관리
4. 테스트, 배포 및 문서화 처리
5. 최종 사용자를 위한 교육 자료 제공

### 코드 품질 검토
```
"Review my e-commerce checkout process for security vulnerabilities, performance issues, and code quality."
```
다수의 에이전트가 협력합니다:  
- **security-analyzer**는 취약점을 점검합니다  
- **performance-optimizer**는 병목 현상을 식별합니다  
- **code-reviewer**는 최선의 관행을 보장합니다  

### 장기 프로젝트 관리

```
"Manage the development of our new customer portal over the next 6 months with regular stakeholder updates."
```
시스템은 다음을 제공합니다:  
- 자동화된 프로젝트 계획 및 위험 관리  
- 정기적인 진행 상황 추적 및 보고  
- 품질 게이트 및 테스트 조정  
- 이해관계자 커뮤니케이션 관리  

## 🔧 에이전트 워크플로우 패턴  

### 순차 패턴  
요구사항 → 설계 → 구현 → 테스트 → 배포  

### 병렬 패턴  
여러 개발 에이전트가 서로 다른 구성 요소를 동시에 작업  

### 적응 패턴  
**agent-creator**가 고유 요구사항에 맞는 전문 에이전트 생성  

### 연속 패턴  
메타 관리 에이전트가 지속적인 최적화 및 모니터링 제공  

## 📝 에이전트 정의 형식  

각 에이전트는 Claude Code의 표준 형식을 따릅니다:

```markdown
---
name: agent-name
description: Detailed description with examples and usage patterns
---

Comprehensive system prompt defining the agent's expertise, responsibilities, and methodologies.
```
## 🔄 에이전트 상호작용

### 마스터 코디네이터
- **project-orchestrator**는 전체 프로젝트 흐름을 관리합니다
- 적절한 에이전트를 자동으로 선택하고 순서를 지정합니다
- 에이전트 간 통신 및 의존성 관리를 처리합니다

### 전문 팀
- **요구사항 팀**: 프로젝트 요구사항 수집 및 검증  
- **설계 팀**: 기술 아키텍처 및 명세 작성  
- **개발 팀**: 코드 구현, 테스트 및 최적화  
- **운영 팀**: 프로덕션 시스템 배포 및 유지관리  
- **메타 팀**: Claude Code 사용 및 연속성 최적화

## 📚 문서화

각 에이전트는 다음을 포함합니다:
- **상세 설명**과 사용 예시  
- **구체적 사용 사례** 및 트리거 조건  
- **예상 출력** 및 산출물  
- **다른 에이전트와의 통합 패턴**

## 🎯 완전 자동화 예시

### 입력

```
"Create a library management system for our company"
```
### 자동화된 프로세스
1. **요구사항 분석**: 이해관계자 요구 → 기술 사양
2. **시스템 설계**: 아키텍처 → 데이터베이스 설계 → API 설계 → UI 설계
3. **구현**: 백엔드 → 프론트엔드 → 테스트 → 문서화
4. **품질 보증**: 코드 리뷰 → 보안 분석 → 성능 최적화
5. **배포**: 프로덕션 설정 → CI/CD 파이프라인 → 모니터링
6. **인수인계**: 사용자 교육 → 문서화 → 지원 절차

### 산출물
- 완전한 기능의 웹 애플리케이션
- 높은 커버리지를 가진 완전한 테스트 스위트
- 모니터링이 포함된 프로덕션 배포
- 사용자 문서 및 교육 자료
- 지속적인 유지보수 절차

## 🤝 기여하기

기여를 환영합니다! 다음을 준수해 주세요:

1. 정해진 에이전트 정의 형식을 따를 것
2. 포괄적인 예제와 문서 포함
3. 실제 프로젝트로 철저히 테스트할 것
4. 기존 워크플로우와 잘 통합되도록 할 것
5. 에이전트 기능에 대한 명확한 문서 제출

## 📄 라이선스

MIT 라이선스 - 자유롭게 사용, 수정 및 배포 가능하며 모든 목적에 사용할 수 있습니다.

## 🙏 감사의 말

[Claude Code](https://claude.ai/code)와 원활히 작동하도록 설계되었으며 하위 에이전트 개발을 위한 모든 패턴과 모범 사례를 따릅니다.

## 📞 지원

문제, 질문 또는 제안 사항이 있으면:
- 이 저장소에 이슈를 열어 주세요
- Claude Code 문서 https://docs.anthropic.com/en/docs/claude-code 를 확인하세요
- 에이전트 예제 및 사용 패턴을 검토하세요

---

*지능형 자동화로 개발 프로세스를 혁신하세요. 단일 요구사항부터 프로덕션 시스템까지 - 에이전트가 복잡성을 처리하는 동안 비전에 집중하세요.*

## 🚀 빠른 시작

1. **에이전트들을** 프로젝트의 `.claude/agents/` 디렉터리에 복사하세요
2. **프로젝트에서 Claude Code를** 시작하세요
3. **말하기**: "프로젝트 오케스트레이터를 사용하여 [프로젝트 설명]을(를) 빌드해 주세요"
4. **지켜보기**: 시스템이 요구사항부터 배포까지 모든 것을 처리합니다

**끝!** 에이전트들이 자동으로 조율하여 완전한 프로덕션 준비 솔루션을 제공합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---