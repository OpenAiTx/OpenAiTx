# 엔터프라이즈 승인 엔진

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](ES/README.md)

엔터프라이즈급 GitHub 액션으로, 그룹별 임계값(X of N), 그룹 간 OR 논리, 자동 semver 태그 생성이 가능한 정책 기반 승인 워크플로우를 제공합니다.

## 특징

- **유연한 승인 논리**: 그룹 내에서 AND(모두 승인해야 함) 및 임계값(X of N) 논리를 지원
- **그룹 간 OR 논리**: 다중 승인 경로 - 하나의 그룹이 요구사항을 충족하면 요청 승인
- **혼합 승인자**: 동일 그룹 내 개인 사용자와 GitHub 팀을 결합 가능
- **점진적 배포 파이프라인**: 단일 이슈로 여러 환경(dev → qa → stage → prod) 추적
- **파이프라인 시각화**: 배포 진행 상황을 보여주는 색상 코드 머메이드 플로우차트 다이어그램
- **하위 이슈 승인**: 각 단계별 전용 승인 하위 이슈 생성 - 닫으면 승인
- **향상된 댓글 UX**: 승인 댓글에 이모지 반응, 명령어 참조가 포함된 빠른 작업 섹션
- **이슈 닫기 보호**: 승인 이슈를 비인가 사용자가 닫는 것을 방지(자동 재오픈)
- **하이브리드 승인 모드**: 워크플로우나 단계별로 댓글 기반과 하위 이슈 승인을 혼합
- **PR 및 커밋 추적**: 배포 이슈에 PR 및 커밋 자동 목록화로 릴리스 관리 지원
- **Semver 태그 생성**: 승인 시 git 태그 자동 생성
- **정책 기반 구성**: YAML로 재사용 가능한 승인 정책 정의
- **이슈 기반 워크플로우**: GitHub 이슈를 통한 투명한 감사 추적
- **Jira 통합**: 커밋에서 이슈 키 추출, 승인 이슈에 표시, Fix Versions 업데이트
- **배포 추적**: 배포 대시보드에 가시성을 위한 GitHub 배포 생성
- **외부 구성**: 공유 저장소에 승인 정책 중앙 집중화
- **속도 제한 처리**: GitHub API 속도 제한에 대한 지수 백오프 자동 재시도
- **GitHub 엔터프라이즈 서버**: GHES 환경 완전 지원
- **외부 종속성 없음**: 순수 GitHub Actions, 외부 서비스 불필요

📋 **실제 사용 예:** [승인 이슈 예제](https://github.com/jamengual/enterprise-approval-engine/issues/7)

## 목차

- [빠른 시작](#quick-start)
- [액션 참조](#action-reference)
  - [액션](#actions)
  - [입력값](#inputs)
  - [출력값](#outputs)
- [구성 참조](#configuration-reference)
  - [정책](#policies)
  - [워크플로우](#workflows)
  - [태깅](#tagging-configuration)
  - [커스텀 템플릿](#custom-issue-templates)
  - [기본값](#defaults)
  - [Semver](#semver)
- [완전한 구성 참조](#complete-configuration-reference)
- [기능 세부사항](#feature-details)
  - [승인 키워드](#approval-keywords)
  - [팀 지원](#team-support)
  - [점진적 배포 파이프라인](#progressive-deployment-pipelines)
  - [릴리스 후보 전략](#release-candidate-strategies)
  - [지라 통합](#jira-integration)
  - [배포 추적](#deployment-tracking)
  - [외부 구성 저장소](#external-config-repository)
  - [차단 승인](#blocking-approvals)
  - [이슈 종료 시 태그 삭제](#tag-deletion-on-issue-close)
- [완전한 예제](#complete-examples)
- [스키마 검증](#schema-validation)
- [GitHub 엔터프라이즈 서버](#github-enterprise-server)

## 빠른 시작

### 1. 구성 생성

레포지토리에 `.github/approvals.yml` 파일을 생성하세요:

```yaml
version: 1

policies:
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  platform-team:
    approvers: [team:platform-engineers]
    require_all: true

workflows:
  production-deploy:
    require:
      # OR logic: either path satisfies approval
      - policy: dev-team        # 2 of 3 developers
      - policy: platform-team   # ALL platform engineers
    on_approved:
      create_tag: true
      close_issue: true
```

### 2. 요청 승인 워크플로우

`.github/workflows/request-approval.yml` 파일을 생성하세요:

```yaml
name: Request Deployment Approval

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy (e.g., v1.2.3)'
        required: true
        type: string

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "Issue: ${{ steps.approval.outputs.issue_url }}"
          echo "Status: ${{ steps.approval.outputs.status }}"
```

### 3. 승인 코멘트 처리

`.github/workflows/handle-approval.yml` 생성:

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

jobs:
  process:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        run: |
          echo "Approved by: ${{ steps.process.outputs.approvers }}"
          echo "Tag created: ${{ steps.process.outputs.tag }}"
```

---

## 작업 참조

### 작업들

작업은 `action` 입력을 통해 네 가지 동작 모드를 지원합니다:

| 작업 | 설명 | 사용 시점 |
|--------|-------------|-------------|
| `request` | 새로운 승인 요청 이슈 생성 | 배포/릴리스 워크플로 시작 시 |
| `process-comment` | 승인/거부 댓글 처리 | `issue_comment` 이벤트 발생 시 |
| `check` | 현재 승인 상태 확인 | 승인 완료를 폴링할 때 |
| `close-issue` | 이슈 종료 이벤트 처리 | `issues: [closed]` 이벤트 시 |

### 입력 값

#### 핵심 입력 값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `action` | 수행할 작업: `request`, `check`, `process-comment`, `close-issue` | 예 | - |
| `workflow` | 설정에서 워크플로 이름 (`request` 작업용) | `request` 작업 시 | - |
| `version` | 태그 생성용 세멘틱 버전 (예: `1.2.3` 또는 `v1.2.3`) | 아니요 | - |
| `issue_number` | 이슈 번호 (`check`, `process-comment`, `close-issue` 작업용) | `check`/`process`/`close` 작업 시 | - |
| `token` | API 작업용 GitHub 토큰 | 예 | - |

#### 구성 입력 값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `config_path` | approvals.yml 구성 파일 경로 | 아니요 | `.github/approvals.yml` |
| `config_repo` | 공유 구성을 위한 외부 리포지토리 (예: `org/.github`) | 아니요 | - |

#### 폴링 입력 값 (`check` 작업용)

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `wait` | 즉시 반환하지 않고 승인 대기(폴링) 여부 | 아니요 | `false` |
| `timeout` | 대기 시간 제한 (예: `24h`, `1h30m`, `30m`) | 아니요 | `72h` |

#### 팀 지원 입력값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `app_id` | 팀 멤버십 확인용 GitHub 앱 ID | 아니요 | - |
| `app_private_key` | 팀 멤버십 확인용 GitHub 앱 개인 키 | 아니요 | - |

#### Jira 통합 입력값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `jira_base_url` | Jira 클라우드 기본 URL (예: `https://yourcompany.atlassian.net`) | 아니요 | - |
| `jira_user_email` | API 인증용 Jira 사용자 이메일 | 아니요 | - |
| `jira_api_token` | 인증용 Jira API 토큰 | 아니요 | - |
| `jira_update_fix_version` | 승인 시 Jira 이슈에 Fix Version 업데이트 | 아니요 | `true` |
| `include_jira_issues` | 승인 요청 본문에 Jira 이슈 포함 | 아니요 | `true` |

#### 배포 추적 입력값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `create_deployment` | 추적을 위한 GitHub 배포 생성 | 아니요 | `true` |
| `deployment_environment` | 대상 환경 (예: `production`, `staging`) | 아니요 | `production` |
| `deployment_environment_url` | 배포된 환경의 URL | 아니요 | - |

#### 기타 입력값

| 입력 | 설명 | 필수 | 기본값 |
|-------|-------------|----------|---------|
| `issue_action` | `close-issue`용 이슈 이벤트 액션 (`closed`, `reopened`) | 아니요 | - |
| `previous_tag` | 커밋 비교용 이전 태그 (지정하지 않으면 자동 감지) | 아니요 | - |

### 출력값

#### 핵심 출력값

| 출력 | 설명 | 사용 가능 대상 |
|--------|-------------|---------------|
| `status` | 승인 상태: `pending`, `approved`, `denied`, `timeout`, `tag_deleted`, `skipped` | 모든 작업 |
| `issue_number` | 생성되거나 확인된 이슈 번호 | 모든 작업 |
| `issue_url` | 승인 이슈의 URL | 모든 작업 |

#### 승인 출력값

| 출력값 | 설명 | 사용 가능 작업 |
|--------|-------------|---------------|
| `approvers` | 승인한 사용자들의 쉼표로 구분된 목록 | `process-comment`, `check` |
| `denier` | 요청을 거부한 사용자 | `process-comment`, `check` |
| `satisfied_group` | 승인을 만족시킨 그룹 이름 | `process-comment`, `check` |
| `tag` | 생성된 태그 이름 | `process-comment` (승인 시) |
| `tag_deleted` | 삭제된 태그 | `close-issue` |

#### Jira 출력값

| 출력값 | 설명 | 사용 가능 작업 |
|--------|-------------|---------------|
| `jira_issues` | 이번 릴리스의 Jira 이슈 키 쉼표로 구분된 목록 | `request` |
| `jira_issues_json` | Jira 이슈 세부정보(JSON 배열, 키, 요약, 유형, 상태) | `request` |

#### 배포 출력값

| 출력값 | 설명 | 사용 가능 작업 |
|--------|-------------|---------------|
| `deployment_id` | 상태 업데이트용 GitHub 배포 ID | `request` |
| `deployment_url` | GitHub 내 배포 URL | `request` |

#### 릴리스 노트 출력값

| 출력값 | 설명 | 사용 가능 작업 |
|--------|-------------|---------------|
| `release_notes` | 커밋 및 Jira 이슈로부터 자동 생성된 릴리스 노트 | `request` |
| `commits_count` | 이번 릴리스의 커밋 수 | `request` |

---

## 구성 참조

### 정책들
정책은 재사용 가능한 승인자 그룹을 정의합니다. 두 가지 형식이 있습니다:

#### 간단한 형식


```yaml
policies:
  # Threshold-based: X of N must approve
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  # All must approve (AND logic)
  security:
    approvers: [team:security, security-lead]
    require_all: true

  # Mixed teams and individuals
  production:
    approvers:
      - team:sre
      - tech-lead
      - product-owner
    min_approvals: 2
```

#### 고급 형식 (소스별 임계값)

"플랫폼에서 2개 AND 보안에서 1개"와 같은 복잡한 요구사항의 경우:

```yaml
policies:
  # Complex AND gate
  production-gate:
    from:
      - team: platform-engineers
        min_approvals: 2        # 2 of the platform team
      - team: security
        min_approvals: 1        # 1 of the security team
      - user: alice             # alice must also approve
    logic: and                  # ALL sources must be satisfied

  # Flexible OR gate
  flexible-review:
    from:
      - team: security
        require_all: true       # All security team
      - team: platform
        min_approvals: 2        # OR 2 platform members
    logic: or                   # ANY source is enough

  # Executive approval: any one exec
  exec-approval:
    from:
      - user: ceo
      - user: cto
      - user: vp-engineering
    logic: or

  # User list with threshold
  leads:
    from:
      - users: [tech-lead, product-lead, design-lead]
        min_approvals: 2
```

**출처 유형:**

- `team: slug` - GitHub 팀 (앱 토큰 필요)
- `user: username` - 단일 사용자 (암묵적 require_all)
- `users: [a, b, c]` - 사용자 목록

**정책 수준 논리:**

- `logic: and` - 모든 출처가 충족되어야 함 (기본값)
- `logic: or` - 어느 하나의 출처가 충족되면 충분

#### 인라인 논리 (AND/OR 혼합)

복잡한 표현식의 경우, 각 출처에 `logic:`을 사용하여 다음과 어떻게 연결되는지 지정:

```yaml
policies:
  # (2 security AND 2 platform) OR alice
  complex-gate:
    from:
      - team: security
        min_approvals: 2
        logic: and              # AND with next source
      - team: platform
        min_approvals: 2
        logic: or               # OR with next source
      - user: alice            # alice alone can satisfy

  # (security AND platform) OR (alice AND bob) OR manager
  multi-path:
    from:
      - team: security
        min_approvals: 1
        logic: and
      - team: platform
        min_approvals: 1
        logic: or               # End first AND group
      - user: alice
        logic: and
      - user: bob
        logic: or               # End second AND group
      - user: manager          # Third path
```

**연산자 우선순위:** AND는 OR보다 결합력이 더 강합니다 (표준 불 대수 논리).

식 `A and B or C and D`는 `(A AND B) OR (C AND D)`로 평가됩니다.

### 워크플로우

워크플로우는 승인 요구 사항과 작업을 정의합니다:

```yaml
workflows:
  my-workflow:
    description: "Optional description"

    # Trigger conditions (for filtering)
    trigger:
      environment: production

    # Approval requirements (OR logic between items)
    require:
      - policy: dev-team
      - policy: security
      # Or inline approvers:
      - approvers: [alice, bob]
        require_all: true

    # Issue configuration
    issue:
      title: "Approval: {{version}}"
      body: |                          # Inline custom template (optional)
        ## My Custom Approval Issue
        Version: {{.Version}}
        Requested by: @{{.Requestor}}
        {{.GroupsTable}}
      body_file: "templates/my-template.md"  # Or load from file
      labels: [production, deploy]
      assignees_from_policy: true

    # Actions on approval
    on_approved:
      create_tag: true
      tag_prefix: "v"  # Creates v1.2.3
      close_issue: true
      comment: "Approved! Tag {{version}} created."

    # Actions on denial
    on_denied:
      close_issue: true
      comment: "Denied by {{denier}}."

    # Actions when issue is manually closed
    on_closed:
      delete_tag: true   # Delete the tag if issue is closed
      comment: "Deployment cancelled. Tag {{tag}} deleted."
```

### 태깅 구성

워크플로우별로 태그가 생성되는 방식을 제어합니다:

```yaml
workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        start_version: "0.1.0"      # No 'v' prefix, start at 0.1.0
        auto_increment: patch        # Auto-bump: 0.1.0 -> 0.1.1 -> 0.1.2
        env_prefix: "dev-"           # Creates: dev-0.1.0, dev-0.1.1

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # 'v' prefix (inferred from start_version)
        auto_increment: minor        # v1.0.0 -> v1.1.0 -> v1.2.0
        env_prefix: "staging-"       # Creates: staging-v1.0.0

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # Manual version required (no auto_increment)
```

**태깅 옵션:**

| 옵션 | 설명 |
|--------|-------------|
| `enabled` | 태그 생성 활성화 |
| `start_version` | 시작 버전 및 형식 (예: "v1.0.0" 또는 "1.0.0") |
| `prefix` | 버전 접두사 (`start_version`에서 추론, 설정하지 않으면) |
| `auto_increment` | 자동 증가: `major`, `minor`, `patch` 또는 수동 생략 |
| `env_prefix` | 환경 접두사 (예: "dev-"는 "dev-v1.0.0" 생성) |

### 맞춤 이슈 템플릿

Go 템플릿을 사용하여 이슈 본문을 완전히 사용자 정의할 수 있습니다. 인라인 템플릿은 `body`를, 파일에서 불러오려면 `body_file`을 사용하세요.

**사용 가능한 템플릿 변수:**

| 변수 | 설명 |
|----------|-------------|
| `{{.Title}}` | 이슈 제목 |
| `{{.Description}}` | 워크플로우 설명 |
| `{{.Version}}` | 세멘틱 버전 |
| `{{.Requestor}}` | 요청한 GitHub 사용자명 |
| `{{.Environment}}` | 환경 이름 |
| `{{.RunURL}}` | 워크플로우 실행 링크 |
| `{{.RepoURL}}` | 저장소 URL |
| `{{.CommitSHA}}` | 전체 커밋 SHA |
| `{{.CommitURL}}` | 커밋 링크 |
| `{{.Branch}}` | 브랜치 이름 |
| `{{.GroupsTable}}` | 사전 렌더링된 승인 상태 표 |
| `{{.Timestamp}}` | 요청 타임스탬프 |
| `{{.PreviousVersion}}` | 이전 버전/태그 |
| `{{.CommitsCount}}` | 이번 릴리스의 커밋 수 |
| `{{.HasJiraIssues}}` | 불리언 - Jira 이슈 존재 여부 |
| `{{.JiraIssues}}` | Jira 이슈 데이터 배열 |
| `{{.JiraIssuesTable}}` | 사전 렌더링된 Jira 이슈 표 |
| `{{.PipelineTable}}` | 사전 렌더링된 배포 파이프라인 표 |
| `{{.PipelineMermaid}}` | 사전 렌더링된 Mermaid 플로우차트 다이어그램 |
| `{{.Vars.key}}` | 사용자 정의 변수 |

**템플릿 함수:**

| 함수 | 예제 | 설명 |
|----------|---------|-------------|
| `slice` | `{{slice .CommitSHA 0 7}}` | 부분 문자열 (짧은 SHA) |
| `title` | `{{.Environment \| title}}` | 제목 대문자 |
| `upper` | `{{.Version \| upper}}` | 대문자 |
| `lower` | `{{.Version \| lower}}` | 소문자 |
| `join` | `{{join .Groups ","}}` | 배열 연결 |
| `contains` | `{{if contains .Branch "feature"}}` | 부분 문자열 확인 |
| `replace` | `{{replace .Version "v" ""}}` | 문자열 치환 |
| `default` | `{{default "N/A" .Environment}}` | 기본값 |

**예제 사용자 정의 템플릿 파일** (`.github/templates/deploy.md`):

```markdown
## {{.Title}}

### Release Information

- **Version:** `{{.Version}}`
- **Requested by:** @{{.Requestor}}
{{- if .CommitSHA}}
- **Commit:** [{{slice .CommitSHA 0 7}}](https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/{{.CommitURL}})
{{- end}}
{{- if .CommitsCount}}
- **Changes:** {{.CommitsCount}} commits since {{.PreviousVersion}}
{{- end}}

{{if .HasJiraIssues}}
### Jira Issues

{{.JiraIssuesTable}}
{{end}}

### Approval Status

{{.GroupsTable}}

---

**Approve:** Comment `approve` | **Deny:** Comment `deny`
```

### 기본값

모든 워크플로에 적용되는 전역 기본값:

```yaml
defaults:
  timeout: 72h                    # Default approval timeout
  allow_self_approval: false      # Whether requestors can approve their own requests
  issue_labels:                   # Labels added to all approval issues
    - approval-required
```

### Semver

버전 처리 구성:

```yaml
semver:
  prefix: "v"              # Tag prefix (v1.2.3)
  strategy: input          # Use version from input
  validate: true           # Validate semver format
  allow_prerelease: true   # Allow prerelease versions (e.g., v1.0.0-beta.1)
  auto:                    # Label-based auto-increment (when strategy: auto)
    major_labels: [breaking, major]
    minor_labels: [feature, minor]
    patch_labels: [fix, patch, bug]
```

---

## 전체 구성 참조

이 섹션에서는 `approvals.yml`에서 사용할 수 있는 **모든 구성 옵션**을 문서화합니다.

### 최상위 구조

```yaml
version: 1                    # Required: config version (always 1)
defaults: { ... }             # Optional: global defaults
policies: { ... }             # Required: reusable approval policies
workflows: { ... }            # Required: approval workflows
semver: { ... }               # Optional: version handling settings
```
### `defaults` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `timeout` | duration | `72h` | `wait: true`인 `check` 작업의 차단 타임아웃. 시간 단위 사용 (예: 1주일은 `168h`). 이벤트 기반 워크플로우에는 필요 없음. |
| `allow_self_approval` | bool | `false` | 요청자가 자신의 요청을 승인할 수 있는지 여부 |
| `issue_labels` | string[] | `[]` | 모든 승인 이슈에 추가되는 라벨 |

### `policies.<name>` 옵션 (간단한 형식)

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `approvers` | string[] | - | 사용자명 또는 `team:slug` 참조 목록 |
| `min_approvals` | int | 0 | 필요한 승인 수 (0 = `require_all` 사용) |
| `require_all` | bool | `false` | 참이면, 모든 승인자가 승인해야 함 |

### `policies.<name>` 옵션 (고급 형식)

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `from` | source[] | - | 개별 임계값이 있는 승인자 소스 목록 |
| `logic` | string | `"and"` | 소스 결합 방식: `"and"` 또는 `"or"` |

**승인자 소스 옵션 (`from[]`):**

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `team` | string | - | 팀 슬러그 (예: `"platform"` 또는 `"org/platform"`) |
| `user` | string | - | 단일 사용자명 |
| `users` | string[] | - | 사용자명 목록 |
| `min_approvals` | int | 1 | 이 소스에서 필요한 승인 수 |
| `require_all` | bool | `false` | 이 소스의 모든 사용자가 승인해야 함 |
| `logic` | string | - | 다음 소스로 가는 논리: `"and"` 또는 `"or"` |

### `workflows.<name>` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `description` | string | - | 사람이 읽을 수 있는 설명 |

| `trigger` | map | - | 트리거 조건 (필터링용) |
| `require` | requirement[] | - | **필수:** 승인 요구사항 (항목 간 OR 논리) |
| `issue` | object | - | 이슈 생성 설정 |
| `on_approved` | object | - | 승인 시 동작 |
| `on_denied` | object | - | 거부 시 동작 |
| `on_closed` | object | - | 수동으로 이슈가 닫힐 때 동작 |
| `pipeline` | object | - | 점진적 배포 파이프라인 구성 |

### `workflows.<name>.require[]` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `policy` | string | - | 정의된 정책 참조 |
| `approvers` | string[] | - | 인라인 승인자 (정책 대체) |
| `min_approvals` | int | - | 정책의 min_approvals 재정의 |
| `require_all` | bool | - | 정책의 require_all 재정의 |

### `workflows.<name>.issue` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `title` | string | `"Approval Required: {workflow}"` | 이슈 제목 (`{{version}}`, `{{environment}}`, `{{workflow}}` 지원) |
| `body` | string | - | 커스텀 이슈 본문 템플릿 (Go 템플릿 문법) |
| `body_file` | string | - | 템플릿 파일 경로 (`.github/` 상대 경로) |
| `labels` | string[] | `[]` | 해당 워크플로우에 추가할 라벨 |
| `assignees_from_policy` | bool | `false` | 정책에서 개별 사용자 자동 할당 (최대 10명) |

### `workflows.<name>.on_approved` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `create_tag` | bool | `false` | git 태그 생성 (입력된 버전 사용) |
| `close_issue` | bool | `false` | 승인 후 이슈 닫기 |
| `comment` | string | - | 게시할 코멘트 (`{{version}}`, `{{satisfied_group}}` 지원) |
| `tagging` | object | - | 고급 태깅 구성 |

### `workflows.<name>.on_approved.tagging` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | 태그 생성 활성화 |
| `start_version` | string | `"0.0.0"` | 초기 버전 (예: `"v1.0.0"` 또는 `"1.0.0"`) |
| `prefix` | string | (추론됨) | 버전 접두사 (`start_version`에서 추론) |
| `auto_increment` | string | - | 자동 증가: `"major"`, `"minor"`, `"patch"` 또는 수동 생략 |
| `env_prefix` | string | - | 환경 접두사 (예: `"dev-"`는 `"dev-v1.0.0"` 생성) |

### `workflows.<name>.on_denied` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `close_issue` | bool | `false` | 거부 후 이슈 닫기 |
| `comment` | string | - | 게시할 댓글 (`{{denier}}` 지원) |

### `workflows.<name>.on_closed` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `delete_tag` | bool | `false` | 이슈가 닫힐 때 관련 태그 삭제 |
| `comment` | string | - | 게시할 댓글 (`{{tag}}`, `{{version}}` 지원) |

### `workflows.<name>.pipeline` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `stages` | stage[] | - | **필수:** 배포 단계의 순서 있는 목록 |
| `track_prs` | bool | `false` | 병합된 PR을 이슈 본문에 포함 |
| `track_commits` | bool | `false` | 커밋을 이슈 본문에 포함 |
| `compare_from_tag` | string | - | 비교할 태그 패턴 (예: `"v*"`) |
| `show_mermaid_diagram` | bool | `true` | 파이프라인 단계의 Mermaid 시각 흐름도 표시 |
| `release_strategy` | object | - | 릴리스 후보 선택 전략 |

### `workflows.<name>.pipeline.stages[]` 옵션

| 키 | 타입 | 기본값 | 설명 |
|-----|------|---------|-------------|
| `name` | string | - | **필수:** 단계 이름 (예: `"dev"`, `"prod"`) |
| `environment` | string | - | GitHub 환경 이름 |
| `policy` | string | - | 이 단계의 승인 정책 |
| `approvers` | string[] | - | 인라인 승인자 (정책 대안) |
| `on_approved` | string | - | 단계 승인 시 게시할 댓글 |
| `create_tag` | bool | `false` | 이 단계에서 git 태그 생성 |
| `is_final` | bool | `false` | 이 단계 후 이슈 종료 |
| `auto_approve` | bool | `false` | 사람 개입 없이 자동 승인 |

### `workflows.<name>.pipeline.release_strategy` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `type` | string | `"tag"` | 전략: `"tag"`, `"branch"`, `"label"`, `"milestone"` |
| `branch` | object | - | 브랜치 전략 설정 |
| `label` | object | - | 라벨 전략 설정 |
| `milestone` | object | - | 마일스톤 전략 설정 |
| `auto_create` | object | - | 다음 릴리스 아티팩트 자동 생성 |

### `release_strategy.branch` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"release/{{version}}"` | 브랜치 명명 패턴 |
| `base_branch` | string | `"main"` | 비교 대상 브랜치 |
| `delete_after_release` | bool | `false` | 프로덕션 배포 후 브랜치 삭제 |

### `release_strategy.label` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"release:{{version}}"` | 라벨 명명 패턴 |
| `pending_label` | string | - | 릴리스 할당 대기 PR용 라벨 |
| `remove_after_release` | bool | `false` | 프로덕션 배포 후 라벨 제거 |

### `release_strategy.milestone` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"v{{version}}"` | 마일스톤 명명 패턴 |
| `close_after_release` | bool | `false` | 프로덕션 배포 후 마일스톤 종료 |

### `release_strategy.auto_create` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | 최종 단계 완료 시 자동 생성 활성화 |
| `next_version` | string | `"patch"` | 버전 증가: `"patch"`, `"minor"`, `"major"` |
| `create_issue` | bool | `false` | 다음 릴리스를 위한 새 승인 이슈 생성 |
| `comment` | string | - | 다음 릴리스에 대한 댓글 작성 |

### `semver` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `prefix` | string | `"v"` | 태그 접두사 |
| `strategy` | string | `"input"` | 버전 전략: `"input"`, `"auto"` |
| `validate` | bool | `false` | semver 형식 검증 |
| `allow_prerelease` | bool | `false` | 프리릴리스 버전 허용 (예: `v1.0.0-beta.1`) |
| `auto` | object | - | 라벨 기반 자동 증가 설정 |

### `semver.auto` 옵션

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `major_labels` | string[] | `[]` | 메이저 버전 증가를 트리거하는 PR 라벨 |
| `minor_labels` | string[] | `[]` | 마이너 버전 증가를 트리거하는 PR 라벨 |
| `patch_labels` | string[] | `[]` | 패치 버전 증가를 트리거하는 PR 라벨 |

---

## 기능 세부사항

### 승인 키워드

사용자는 이슈에 댓글을 달아 요청을 승인하거나 거부할 수 있습니다:

**승인 키워드:** `approve`, `approved`, `lgtm`, `yes`, `/approve`

**거부 키워드:** `deny`, `denied`, `reject`, `rejected`, `no`, `/deny`

### 팀 지원

GitHub 팀 기반 승인자를 사용하려면 권한 상승이 필요합니다. 기본 `GITHUB_TOKEN`은 팀 멤버 목록을 가져올 수 없습니다. GitHub 앱 토큰을 사용하세요:

```yaml
jobs:
  process:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      # Use the app token for team membership checks
      - uses: jamengual/enterprise-approval-engine@v1
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
```

**필수 GitHub 앱 권한:**

- `Organization > Members: Read` - 팀 구성원 목록 조회를 위해

### 점진적 배포 파이프라인

단일 승인 이슈로 여러 환경에 걸친 배포를 추적합니다. 각 단계가 승인되면 이슈가 진행 상황을 표시하도록 업데이트되고 자동으로 다음 단계로 진행합니다.

#### 파이프라인 구성

```yaml
# .github/approvals.yml or external config
version: 1

policies:
  developers:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  tech-leads:
    approvers: [lead1, lead2]
    min_approvals: 1

  production-approvers:
    approvers: [sre1, sre2, security-lead]
    require_all: true

workflows:
  deploy:
    description: "Deploy through all environments (dev → qa → stage → prod)"
    require:
      - policy: developers  # Initial approval to start pipeline
    pipeline:
      track_prs: true       # Include PRs in the issue body
      track_commits: true   # Include commits in the issue body
      stages:
        - name: dev
          environment: development
          policy: developers
          on_approved: "✅ **DEV** deployment approved! Proceeding to QA..."
        - name: qa
          environment: qa
          policy: qa-team
          on_approved: "✅ **QA** deployment approved! Proceeding to STAGING..."
        - name: stage
          environment: staging
          policy: tech-leads
          on_approved: "✅ **STAGING** deployment approved! Ready for PRODUCTION..."
        - name: prod
          environment: production
          policy: production-approvers
          on_approved: "🚀 **PRODUCTION** deployment complete!"
          create_tag: true   # Create tag when PROD is approved
          is_final: true     # Close issue after this stage
    on_approved:
      close_issue: true
      comment: |
        🎉 **Deployment Complete!**

        Version `{{version}}` has been deployed to all environments.
```

#### 파이프라인 워크플로우 예시

```yaml
# .github/workflows/request-pipeline.yml
name: Request Pipeline Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string

permissions:
  contents: write
  issues: write
  pull-requests: read  # Required for PR tracking

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit/PR comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "## Pipeline Deployment Started" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
```

#### 작동 방식

1. **이슈 생성**: 트리거되면, 모든 단계를 시각적인 Mermaid 다이어그램과 진행 표로 보여주는 단일 이슈를 생성합니다:

```markdown
## 🚀 배포 파이프라인: v1.2.0

### 파이프라인 흐름

​```mermaid
flowchart LR
    DEV(⏳ 개발)
    QA(⬜ QA)
    STAGE(⬜ 스테이지)
    PROD(⬜ 운영)
    DEV --> QA --> STAGE --> PROD

    classDef completed fill:#28a745,stroke:#1e7e34,color:#fff
    classDef current fill:#ffc107,stroke:#d39e00,color:#000
    classDef pending fill:#6c757d,stroke:#545b62,color:#fff
    class DEV current
    class QA,STAGE,PROD pending
​```

### Deployment Progress

| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ⏳ Awaiting | - | - |
| QA | ⬜ Pending | - | - |
| STAGE | ⬜ Pending | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** DEV
```
머메이드 다이어그램은 색상으로 구분된 노드를 통해 한눈에 상태를 보여줍니다:
- 🟢 **초록색** - 완료된 단계
- 🟡 **노란색** - 승인 대기 중인 현재 단계
- ⚪ **회색** - 대기 중인 단계
- 🔵 **청록색** - 자동 승인 단계

머메이드 다이어그램을 비활성화하려면 파이프라인 설정에서 `show_mermaid_diagram: false`로 설정하세요.

2. **단계 진행**: 다음 단계로 진행하려면 `approve` 댓글을 남기세요. 다이어그램과 표가 자동으로 업데이트됩니다:


```markdown
| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ✅ Deployed | @developer1 | Dec 9 10:30 |
| QA | ✅ Deployed | @qa-lead | Dec 9 14:15 |
| STAGE | ⏳ Awaiting | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** STAGE
```

3. **PR 및 커밋 추적**: 릴리스 관리자는 배포되는 내용을 정확히 확인할 수 있습니다:

```markdown
### Pull Requests in this Release

| PR | Title | Author |
|----|-------|--------|
| [#42](https://...) | Add user authentication | @alice |
| [#45](https://...) | Fix payment processing bug | @bob |

### Commits

- [`abc1234`](https://...) feat: add OAuth2 support
- [`def5678`](https://...) fix: handle null payments
```
4. **완료**: 최종 단계가 승인되면:
   - 태그가 생성됩니다 (`create_tag: true`인 경우)
   - 완료 댓글이 게시됩니다
   - 이슈가 자동으로 종료됩니다

#### 파이프라인 단계 옵션

| 옵션 | 설명 |
|--------|-------------|
| `name` | 단계 이름 (표에 표시됨) |
| `environment` | GitHub 환경 이름 |
| `policy` | 이 단계의 승인 정책 |
| `approvers` | 인라인 승인자 (정책의 대안) |
| `on_approved` | 단계가 승인될 때 게시할 메시지 |
| `create_tag` | 이 단계에서 git 태그 생성 |
| `is_final` | 이 단계 후 이슈 종료 |
| `auto_approve` | 사람 개입 없이 이 단계를 자동 승인 |
| `approval_mode` | 이 단계의 워크플로우 승인 모드 재정의 |

#### 승인 모드

승인자가 승인 요청과 상호작용하는 방식을 선택하세요:

| 모드 | 설명 |
|------|-------------|
| `comments` | (기본) 승인자가 이슈에 `/approve` 또는 `approve` 댓글 작성 |
| `sub_issues` | 각 단계별 하위 이슈 생성 - 종료 시 승인 |
| `hybrid` | 단계별로 모드 혼합 - 각 단계에서 `approval_mode` 사용 |

**하위 이슈 승인 예시:**


```yaml
workflows:
  deploy:
    approval_mode: sub_issues
    sub_issue_settings:
      title_template: "⏳ Approve: {{stage}} for {{version}}"  # Changes to ✅ when approved
      labels: [approval-stage]
      protection:
        only_assignee_can_close: true   # Prevents unauthorized approvals
        prevent_parent_close: true       # Parent can't close until all approved
    pipeline:
      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
```

하위 이슈가 있는 경우, 상위 이슈는 승인 하위 이슈의 표를 표시합니다:

```markdown
### 📋 Approval Sub-Issues

| Stage | Sub-Issue | Status | Assignees |
|-------|-----------|--------|----------|
| DEV | #124 | ⏳ Awaiting | @alice, @bob |
| PROD | #125 | ⏳ Awaiting | @sre1, @sre2 |
```

**하이브리드 모드 (단계별 오버라이드):**

```yaml
workflows:
  deploy:
    approval_mode: comments  # Default for this workflow
    pipeline:
      stages:
        - name: dev
          policy: developers
          # Uses comments (workflow default)
        - name: prod
          policy: production-approvers
          approval_mode: sub_issues  # Override for production only
```
#### 향상된 댓글 UX

이 작업에는 향상된 댓글 기반 승인 UX가 포함되어 있습니다:

- **이모지 반응**: 승인 댓글에 자동 반응
  - 👍 승인됨
  - 👎 거부됨
  - 👀 확인됨 (처리 중)

- **빠른 작업 섹션**: 이슈 본문에 명령어 참조 표 포함:


```markdown
### ⚡ Quick Actions

| Action | Command | Description |
|--------|---------|-------------|
| ✅ Approve | `/approve` | Approve the **DEV** stage |
| ❌ Deny | `/deny [reason]` | Deny with optional reason |
| 📊 Status | `/status` | Show current approval status |
```

**`comment_settings`을 통해 구성:**

```yaml
workflows:
  deploy:
    comment_settings:
      react_to_comments: true     # Add emoji reactions (default: true)
      show_quick_actions: true    # Show Quick Actions section (default: true)
```

#### 하위 환경에 대한 자동 승인

사람의 개입 없이 자동으로 승인되어야 하는 파이프라인 단계에 `auto_approve: true`를 사용하세요. 이는 `dev` 또는 `integration`과 같은 하위 환경에서 파이프라인 속도를 높이면서도 프로덕션에 대한 승인 문턱을 유지하는 데 이상적입니다.

**자동 승인 예시:**

```yaml
workflows:
  deploy:
    description: "Deploy through environments"
    pipeline:
      stages:
        - name: dev
          environment: development
          auto_approve: true              # Automatically approved
          on_approved: "🤖 DEV auto-deployed"
        - name: integration
          environment: integration
          auto_approve: true              # Automatically approved
          on_approved: "🤖 INTEGRATION auto-deployed"
        - name: staging
          environment: staging
          policy: qa-team                 # Requires manual approval
          on_approved: "✅ STAGING approved"
        - name: production
          environment: production
          policy: production-approvers    # Requires manual approval
          create_tag: true
          is_final: true
```
**작동 원리:**

1. 파이프라인 이슈가 생성되면, 모든 초기 `auto_approve: true` 단계가 자동으로 완료됩니다  
2. 단계가 수동으로 승인되면, 그 다음에 이어지는 모든 `auto_approve: true` 단계도 자동으로 완료됩니다  
3. 자동 승인된 단계는 파이프라인 테이블에 🤖 표시가 나타납니다  
4. 승인은 단계 기록에 `[auto]`로 기록됩니다  

**사용 사례:**

- **개발 환경**: 승인 대기 없이 즉시 배포  
- **통합 테스트**: CI/CD 파이프라인이 테스트 환경을 자동으로 진행하도록 설정  
- **카나리 배포**: 카나리 단계는 자동 승인, 전체 롤아웃은 수동 승인 필요  

#### 파이프라인 구성 옵션

| 옵션 | 기본값 | 설명 |
|--------|---------|-------------|
| `track_prs` | `false` | 병합된 PR을 이슈 본문에 포함 |
| `track_commits` | `false` | 마지막 태그 이후 커밋 포함 |
| `compare_from_tag` | - | 비교할 사용자 지정 태그 패턴 |
| `show_mermaid_diagram` | `true` | 파이프라인 단계의 Mermaid 시각적 흐름도 표시 |

**참고:** PR 추적을 위해서는 워크플로우에서 `pull-requests: read` 권한이 필요합니다.  

### 릴리스 후보 전략

기업 환경에서 메인으로 병합된 PR이 항상 즉시 릴리스 후보가 되는 것은 아닙니다. 승인 엔진은 릴리스에 포함될 PR을 선택하기 위해 세 가지 전략을 지원합니다:  

#### 전략 유형

| 전략 | 설명 | 사용 사례 |
|----------|-------------|----------|
| `tag` | 두 git 태그 사이의 PR (기본값) | 간단한 릴리스, 트렁크 기반 개발 |
| `branch` | 릴리스 브랜치에 병합된 PR | GitFlow, 릴리스 브랜치 |
| `label` | 특정 릴리스 레이블이 붙은 PR | 유연한 선택, 배치 릴리스 |
| `milestone` | GitHub 마일스톤에 할당된 PR | 로드맵에 맞춘 릴리스 |

#### 구성


```yaml
# .github/approvals.yml
workflows:
  deploy:
    description: "Production deployment pipeline"
    pipeline:
      track_prs: true
      track_commits: true

      # Configure release selection strategy
      release_strategy:
        type: milestone  # or: tag, branch, label

        # Milestone strategy settings
        milestone:
          pattern: "v{{version}}"        # e.g., "v1.2.0"
          close_after_release: true       # Close milestone on prod completion

        # Auto-create next release artifact on completion
        auto_create:
          enabled: true
          next_version: patch             # or: minor, major
          create_issue: true              # Create new approval issue

      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
          is_final: true
```
#### 브랜치 전략

GitFlow 스타일 개발을 위해 릴리스 브랜치를 사용하세요:


```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"  # Creates release/v1.2.0
    base_branch: main               # Compare against main
    delete_after_release: true      # Cleanup after prod deploy

  auto_create:
    enabled: true
    next_version: minor
```

**작동 방식:**
1. 릴리즈 브랜치 생성: `release/v1.2.0`
2. 브랜치에 병합된 PR은 릴리즈 후보
3. 해당 버전에 대한 승인 요청
4. 승인 이슈에 릴리즈 브랜치의 모든 PR 표시
5. 프로덕션 후 브랜치 삭제(선택 사항) 및 다음 브랜치 생성

#### 라벨 전략

유연한 PR 선택을 위해 라벨 사용:

```yaml
release_strategy:
  type: label
  label:
    pattern: "release:{{version}}"      # e.g., "release:v1.2.0"
    pending_label: "pending-release"    # Applied to merged PRs awaiting release
    remove_after_release: true          # Remove label after prod deploy

  auto_create:
    enabled: true
    next_version: patch
```

**작동 방식:**
1. main에 병합된 PR에 `pending-release` 라벨이 붙음
2. 릴리스 관리자가 선택된 PR에 `release:v1.2.0` 라벨을 적용함
3. v1.2.0 승인을 요청함
4. 승인 이슈에는 해당 라벨이 붙은 PR만 표시됨
5. 운영 배포 후 라벨이 제거되고 다음 릴리스 라벨이 생성됨

#### 마일스톤 전략

로드맵에 맞춘 릴리스를 위해 마일스톤을 사용하세요:

```yaml
release_strategy:
  type: milestone
  milestone:
    pattern: "Release {{version}}"       # e.g., "Release 1.2.0"
    close_after_release: true            # Close milestone on completion

  auto_create:
    enabled: true
    next_version: minor
    create_issue: true                   # Auto-create next approval issue
```

**작동 방식:**
1. 마일스톤 생성: "Release 1.2.0"
2. 개발 중에 PR을 마일스톤에 할당
3. v1.2.0 승인 요청
4. 승인 이슈에 마일스톤 내 모든 PR 표시
5. 프로덕션 후 마일스톤 종료 및 다음 마일스톤 생성

#### 완료 시 자동 생성

최종 단계(프로덕션)가 승인되면 다음 릴리스를 자동으로 준비:

```yaml
auto_create:
  enabled: true
  next_version: patch      # Calculate next: patch, minor, or major
  create_issue: true       # Create new approval issue immediately
  comment: |               # Custom message (optional)
    🚀 **Next release prepared:** {{version}}
```
이것은 다음을 생성합니다:
- **브랜치 전략:** 메인에서 새 릴리스 브랜치 생성
- **레이블 전략:** 새 릴리스 레이블
- **마일스톤 전략:** 새 마일스톤

#### 정리 옵션

각 전략에는 최종 단계(프로덕션)가 승인될 때 실행되는 선택적 정리 작업이 있습니다. **모든 정리 옵션은 기본값이 `false`입니다** - 정리는 선택 사항입니다:

| 전략 | 정리 옵션 | 설명 |
|----------|----------------|-------------|
| 브랜치 | `delete_after_release` | 릴리스 브랜치 삭제 |
| 레이블 | `remove_after_release` | PR에서 릴리스 레이블 제거 |
| 마일스톤 | `close_after_release` | 마일스톤 닫기 |


```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"
    delete_after_release: false   # Keep branch for reference (default)

  type: milestone
  milestone:
    pattern: "v{{version}}"
    close_after_release: true     # Close milestone when done
```
#### 긴급 수정 배포

정상 릴리스 워크플로를 우회해야 하는 긴급 수정의 경우, 별도의 워크플로를 만듭니다:


```yaml
# .github/approvals.yml
workflows:
  # Standard releases - full pipeline with milestone tracking
  deploy:
    description: "Standard release pipeline (dev → qa → stage → prod)"
    pipeline:
      release_strategy:
        type: milestone
        milestone:
          pattern: "v{{version}}"
          close_after_release: true
        auto_create:
          enabled: true
          next_version: minor
      stages:
        - name: dev
          policy: developers
        - name: qa
          policy: qa-team
        - name: stage
          policy: tech-leads
        - name: prod
          policy: production-approvers
          is_final: true

  # Hotfixes - skip stages, direct to prod
  hotfix:
    description: "Emergency hotfix - direct to production"
    pipeline:
      release_strategy:
        type: tag              # Simple tag-based, no cleanup needed
        # No auto_create - hotfixes are one-off
      stages:
        - name: prod
          policy: production-approvers
          create_tag: true
          is_final: true
    on_approved:
      close_issue: true
      comment: "🚨 Hotfix {{version}} deployed to production"
```

**핫픽스 트리거 vs 정규 릴리스:**

```bash
# Regular release - goes through all stages
gh workflow run request-approval.yml -f workflow_name=deploy -f version=v1.3.0

# Hotfix - goes straight to prod
gh workflow run request-approval.yml -f workflow_name=hotfix -f version=v1.2.1
```
**핫픽스 패턴:**

| 시나리오 | 전략 | 정리 | 자동 생성 |
|----------|----------|---------|-------------|
| 긴급 수정 | `tag` | 없음 | 비활성화 |
| 패치 릴리스 | `milestone` | `close_after_release: false` | 비활성화 |
| 다중 핫픽스 | `branch` | `delete_after_release: false` | 비활성화 |

#### 릴리스 전략 장점

| 전략 | 장점 | 단점 |
|----------|------|------|
| **Tag** | 간단하며 추가 워크플로우 없음 | 모든 병합된 PR 포함 |
| **Branch** | 명확한 릴리스 범위, 격리 | 브랜치 관리 오버헤드 |
| **Label** | 유연한 선택, 변경 용이 | 수동 라벨링 필요 |
| **Milestone** | 로드맵 가시성, 계획 통합 | 마일스톤 규율 필요 |

**권장 사항:**

- 연속 배포가 필요한 단순 프로젝트에는 **tag** 사용
- 릴리스 격리가 필요한 규제 환경에는 **branch** 사용
- 유연한 범위의 일괄 릴리스에는 **label** 사용
- 명확한 릴리스 계획이 있는 로드맵 기반 개발에는 **milestone** 사용

### Jira 통합

커밋 및 브랜치 이름에서 Jira 이슈를 자동으로 추출합니다. 이 액션은 두 가지 모드를 지원합니다:

#### 링크 전용 모드 (인증 불필요)

`jira_base_url`만 제공하면 이슈 키를 추출하여 클릭 가능한 링크로 표시합니다:


```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    jira_base_url: https://yourcompany.atlassian.net  # That's it!
```

이것은 커밋 메시지와 브랜치 이름에서 이슈 키(예: `PROJ-123`)를 추출하여 승인 이슈에 링크로 표시합니다:

```markdown
### Jira Issues
- [PROJ-123](https://yourcompany.atlassian.net/browse/PROJ-123)
- [PROJ-456](https://yourcompany.atlassian.net/browse/PROJ-456)
```

#### 전체 모드 (API 접근 포함)

이슈 세부정보를 가져오고 수정 버전을 업데이트하기 위해 자격 증명을 추가하세요:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Jira configuration
    jira_base_url: https://yourcompany.atlassian.net
    jira_user_email: ${{ secrets.JIRA_EMAIL }}
    jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
    jira_update_fix_version: 'true'
```
이것은 자세한 이슈 정보를 표시합니다:


```markdown
### Jira Issues in this Release

| Key | Summary | Type | Status |
|-----|---------|------|--------|
| [PROJ-123](https://...) | Fix login bug | Bug | Done |
| [PROJ-456](https://...) | Add dark mode | Feature | In Progress |
```

**모드 비교:**

| 모드 | 인증 필요 | 기능 |
|------|-----------|------|
| 링크 전용 | 아니요 | 클릭 가능한 링크로 이슈 키 제공 |
| 전체 | 예 | 링크 + 요약, 상태, 유형 이모지, Fix Version 업데이트 |

**Jira 출력:**

```yaml
- name: Use Jira Outputs
  run: |
    echo "Issues: ${{ steps.approval.outputs.jira_issues }}"
    # Output: PROJ-123,PROJ-456

    echo "Details: ${{ steps.approval.outputs.jira_issues_json }}"
    # Output: [{"key":"PROJ-123","summary":"Fix login bug",...}]
```

### 배포 추적

GitHub의 배포 대시보드에서 가시성을 위해 GitHub 배포를 생성합니다. 이것은 워크플로우 YAML의 `environment:` 키와는 독립적으로 작동합니다.

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  id: approval
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Deployment tracking
    create_deployment: 'true'
    deployment_environment: production
    deployment_environment_url: https://myapp.example.com

- name: Update Deployment Status
  if: steps.approval.outputs.status == 'approved'
  run: |
    # Use the deployment_id to update status after actual deployment
    echo "Deployment ID: ${{ steps.approval.outputs.deployment_id }}"
```

**배포가 표시되는 위치:**

- 저장소의 **배포(Deployments)** 탭
- 저장소 페이지의 환경 상태 배지
- GitHub for Jira 통합(구성된 경우)
- CI/CD 도구용 GitHub API

**참고:** 이는 GitHub의 기본 환경 보호 규칙과 별개인 GitHub 배포 API를 통해 배포를 생성합니다. 두 가지를 함께 또는 독립적으로 사용할 수 있습니다.

### 외부 구성 저장소

중앙 집중식 정책 관리를 위해 승인가 구성을 공유 저장소에 저장:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    token: ${{ secrets.GITHUB_TOKEN }}
    config_repo: myorg/.github  # Shared config repo
```

**구성 해석 순서:**

1. 외부 저장소의 `{repo-name}_approvals.yml` (예: `myapp_approvals.yml`)
2. 외부 저장소의 `approvals.yml` (공유 기본값)
3. 현재 저장소의 `.github/approvals.yml` (로컬 대체)

**예시 조직 구조:**

```text
myorg/.github/
├── myapp_approvals.yml      # App-specific config
├── backend_approvals.yml    # Backend repos config
└── approvals.yml            # Default for all repos
```

### 승인 차단

승인 대기 후 진행해야 하는 워크플로우의 경우:

```yaml
name: Deploy with Blocking Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true
        type: string

jobs:
  request-approval:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.request.outputs.issue_number }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

  wait-for-approval:
    needs: request-approval
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ needs.request-approval.outputs.issue_number }}
          wait: 'true'           # Poll until approved/denied
          timeout: '4h'          # Max wait time
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: [request-approval, wait-for-approval]
    if: needs.wait-for-approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.wait-for-approval.outputs.tag }}"
```

**참고:** 차단 워크플로우는 러너를 활성 상태로 유지하여 GitHub Actions 사용 시간을 소모합니다. 비용에 민감한 시나리오에서는 이벤트 기반 접근 방식(별도의 `process-comment` 워크플로우)을 사용하세요.

### 이슈 종료 시 태그 삭제

승인 이슈가 수동으로 종료될 때 선택적으로 태그를 삭제합니다:

```yaml
workflows:
  dev-deploy:
    on_closed:
      delete_tag: true   # Delete tag when issue is closed
      comment: "Cancelled. Tag {{tag}} deleted."

  production-deploy:
    on_closed:
      delete_tag: false  # NEVER delete production tags
```

**닫기 이벤트 처리:**

```yaml
# .github/workflows/handle-close.yml
name: Handle Issue Close

on:
  issues:
    types: [closed]

jobs:
  handle:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: close
        with:
          action: close-issue
          issue_number: ${{ github.event.issue.number }}
          issue_action: ${{ github.event.action }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Report
        run: |
          echo "Status: ${{ steps.close.outputs.status }}"
          echo "Deleted tag: ${{ steps.close.outputs.tag_deleted }}"
```

---

## Complete Examples

### Full-Featured Request Workflow

```yaml
name: Request Production Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string
      environment:
        description: 'Target environment'
        required: true
        type: choice
        options: [staging, production]

permissions:
  contents: write
  issues: write
  deployments: write

jobs:
  request:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.approval.outputs.issue_number }}
      issue_url: ${{ steps.approval.outputs.issue_url }}
      deployment_id: ${{ steps.approval.outputs.deployment_id }}
      jira_issues: ${{ steps.approval.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: ${{ inputs.environment }}-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          # Jira integration
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
          # Deployment tracking
          create_deployment: 'true'
          deployment_environment: ${{ inputs.environment }}
          deployment_environment_url: https://${{ inputs.environment }}.myapp.com

      - name: Summary
        run: |
          echo "## Approval Request Created" >> $GITHUB_STEP_SUMMARY
          echo "" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Jira Issues:** ${{ steps.approval.outputs.jira_issues }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Commits:** ${{ steps.approval.outputs.commits_count }}" >> $GITHUB_STEP_SUMMARY
```

### 팀 지원과 함께 프로세스 의견 처리

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

permissions:
  contents: write
  issues: write

jobs:
  process:
    if: |
      github.event.issue.pull_request == null &&
      contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token for team membership checks
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
          # Jira integration to update Fix Version on approval
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        uses: actions/github-script@v7
        with:
          script: |
            await github.rest.actions.createWorkflowDispatch({
              owner: context.repo.owner,
              repo: context.repo.repo,
              workflow_id: 'deploy.yml',
              ref: 'main',
              inputs: { version: '${{ steps.process.outputs.tag }}' }
            });
```

### 다중 환경 프로모션

```yaml
# .github/approvals.yml
version: 1

policies:
  dev-team:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  prod-team:
    approvers: [team:sre, tech-lead]
    min_approvals: 2

workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: patch
        env_prefix: "dev-"
      close_issue: true

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: minor
        env_prefix: "staging-"
      close_issue: true

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      create_tag: true
      close_issue: true
    on_closed:
      delete_tag: false  # Never delete production tags
```

### 후속 작업에서 출력물 사용하기

```yaml
name: Deploy with Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true

jobs:
  approval:
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
      approvers: ${{ steps.check.outputs.approvers }}
      jira_issues: ${{ steps.request.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4

      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          jira_base_url: https://mycompany.atlassian.net

      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ steps.request.outputs.issue_number }}
          wait: 'true'
          timeout: '2h'
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: approval
    if: needs.approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    environment: production
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.approval.outputs.tag }}"
          echo "Approved by: ${{ needs.approval.outputs.approvers }}"
          echo "Jira Issues: ${{ needs.approval.outputs.jira_issues }}"

  notify:
    needs: [approval, deploy]
    if: always()
    runs-on: ubuntu-latest
    steps:
      - name: Notify Slack
        run: |
          if [ "${{ needs.approval.outputs.status }}" == "approved" ]; then
            echo "Deployment of ${{ needs.approval.outputs.tag }} completed!"
          else
            echo "Deployment was ${{ needs.approval.outputs.status }}"
          fi
```

---

## Schema Validation

Validate your configuration using the JSON schema:

```yaml
# .github/approvals.yml
# yaml-language-server: $schema=https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/schema.json

version: 1

policies:
  # ... your config
```

또는 CI에서 검증:

```yaml
- name: Validate Config
  run: |
    npm install -g ajv-cli
    ajv validate -s schema.json -d .github/approvals.yml
```

---

## GitHub Enterprise Server

이 액션은 GitHub Enterprise Server를 완벽하게 지원합니다. `GITHUB_SERVER_URL` 및 `GITHUB_API_URL` 환경 변수를 사용하여 GHES 환경을 자동으로 감지합니다.

추가 구성 없이도 액션이 자동으로 올바른 API 엔드포인트를 사용합니다.

**속도 제한:**

이 액션은 속도 제한 오류에 대해 지수 백오프를 사용하는 자동 재시도를 포함합니다. 구성:

- 초기 지연: 1초
- 최대 지연: 60초
- 최대 재시도 횟수: 5회
- 지터: 무작위 0-500ms를 추가하여 동시 폭주 방지

---

## 라이선스

MIT 라이선스


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---