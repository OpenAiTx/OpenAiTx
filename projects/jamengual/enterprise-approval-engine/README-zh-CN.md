# 企业审批引擎

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](ES/README.md)

企业级 GitHub Action，支持基于策略的审批工作流，具备每组阈值（N 中 X）、组间或逻辑，以及自动语义版本标签创建功能。

## 功能特性

- **灵活的审批逻辑**：支持组内的与（全部必须审批）和阈值（N 中 X）逻辑
- **组间或逻辑**：多审批路径——任意一组满足要求即可批准请求
- **混合审批人**：同一组内可组合个人用户和 GitHub 团队
- **渐进式部署流水线**：单一议题跨多个环境跟踪（开发 → 测试 → 预发布 → 生产）
- **流水线可视化**：色彩编码的 Mermaid 流程图展示部署进度
- **子议题审批**：为每个阶段创建专用审批子议题——关闭即为批准
- **增强的评论用户体验**：审批评论支持表情反应，快速操作区含命令参考
- **议题关闭保护**：防止未授权用户关闭审批议题（自动重新打开）
- **混合审批模式**：按工作流或阶段混合基于评论和子议题的审批
- **PR 和提交跟踪**：自动在部署议题列出 PR 和提交以便发布管理
- **语义版本标签创建**：审批通过后自动创建 git 标签
- **基于策略的配置**：以 YAML 定义可复用的审批策略
- **基于议题的工作流**：通过 GitHub 议题实现透明审计轨迹
- **Jira 集成**：从提交中提取议题键，显示在审批议题，更新修复版本
- **部署跟踪**：创建 GitHub 部署以便部署仪表盘可视化
- **外部配置**：将审批策略集中存放于共享仓库
- **速率限制处理**：针对 GitHub API 速率限制自动指数退避重试
- **GitHub 企业服务器支持**：完全支持 GHES 环境
- **无外部依赖**：纯 GitHub Actions，无需外部服务

📋 **演示示例：** [审批示例议题](https://github.com/jamengual/enterprise-approval-engine/issues/7)

## 目录

- [快速开始](#quick-start)
- [Action 参考](#action-reference)
  - [操作](#actions)
  - [输入](#inputs)
  - [输出](#outputs)
- [配置参考](#configuration-reference)
  - [策略](#policies)
  - [工作流](#workflows)
  - [标签配置](#tagging-configuration)
  - [自定义模板](#custom-issue-templates)
  - [默认值](#defaults)
  - [语义化版本](#semver)
- [完整配置参考](#complete-configuration-reference)
- [功能详情](#feature-details)
  - [审批关键字](#approval-keywords)
  - [团队支持](#team-support)
  - [渐进式部署流水线](#progressive-deployment-pipelines)
  - [候选版本策略](#release-candidate-strategies)
  - [Jira 集成](#jira-integration)
  - [部署跟踪](#deployment-tracking)
  - [外部配置仓库](#external-config-repository)
  - [阻塞审批](#blocking-approvals)
  - [关闭 Issue 时删除标签](#tag-deletion-on-issue-close)
- [完整示例](#complete-examples)
- [模式验证](#schema-validation)
- [GitHub 企业服务器](#github-enterprise-server)

## 快速开始

### 1. 创建配置

在你的仓库中创建 `.github/approvals.yml` 文件：

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

### 2. 请求审批工作流

创建 `.github/workflows/request-approval.yml`：

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

### 3. 处理审批意见

创建 `.github/workflows/handle-approval.yml`：

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

## 操作参考

### 操作

该操作通过 `action` 输入支持四种操作模式：

| 操作 | 描述 | 何时使用 |
|--------|-------------|-------------|
| `request` | 创建一个新的审批请求 issue | 在启动部署/发布工作流时 |
| `process-comment` | 处理审批/拒绝评论 | 在 `issue_comment` 事件时 |
| `check` | 检查当前审批状态 | 用于轮询审批完成情况 |
| `close-issue` | 处理 issue 关闭事件 | 在 `issues: [closed]` 事件时 |

### 输入

#### 核心输入

| 输入 | 描述 | 必填 | 默认值 |
|-------|-------------|----------|---------|
| `action` | 要执行的操作：`request`，`check`，`process-comment`，`close-issue` | 是 | - |
| `workflow` | 配置中的工作流名称（用于 `request` 操作） | `request` 时必填 | - |
| `version` | 用于标签创建的语义版本号（例如，`1.2.3` 或 `v1.2.3`） | 否 | - |
| `issue_number` | issue 编号（用于 `check`、`process-comment`、`close-issue`） | `check`/`process`/`close` 时必填 | - |
| `token` | 用于 API 操作的 GitHub 令牌 | 是 | - |

#### 配置输入

| 输入 | 描述 | 必填 | 默认值 |
|-------|-------------|----------|---------|
| `config_path` | approvals.yml 配置文件路径 | 否 | `.github/approvals.yml` |
| `config_repo` | 用于共享配置的外部仓库（例如，`org/.github`） | 否 | - |

#### 轮询输入（用于 `check` 操作）

| 输入 | 描述 | 必填 | 默认值 |
|-------|-------------|----------|---------|
| `wait` | 等待审批完成（轮询）而非立即返回 | 否 | `false` |
| `timeout` | 等待超时时间（例如，`24h`，`1h30m`，`30m`） | 否 | `72h` |

#### 团队支持输入

| 输入 | 描述 | 是否必需 | 默认值 |
|-------|-------------|----------|---------|
| `app_id` | 用于团队成员检查的 GitHub 应用 ID | 否 | - |
| `app_private_key` | 用于团队成员检查的 GitHub 应用私钥 | 否 | - |

#### Jira 集成输入

| 输入 | 描述 | 是否必需 | 默认值 |
|-------|-------------|----------|---------|
| `jira_base_url` | Jira Cloud 基础 URL（例如，`https://yourcompany.atlassian.net`） | 否 | - |
| `jira_user_email` | 用于 API 认证的 Jira 用户邮箱 | 否 | - |
| `jira_api_token` | 用于认证的 Jira API 令牌 | 否 | - |
| `jira_update_fix_version` | 审批时更新 Jira 问题的修复版本 | 否 | `true` |
| `include_jira_issues` | 在审批请求正文中包含 Jira 问题 | 否 | `true` |

#### 部署跟踪输入

| 输入 | 描述 | 是否必需 | 默认值 |
|-------|-------------|----------|---------|
| `create_deployment` | 创建 GitHub 部署以进行跟踪 | 否 | `true` |
| `deployment_environment` | 目标环境（例如，`production`，`staging`） | 否 | `production` |
| `deployment_environment_url` | 部署环境的 URL | 否 | - |

#### 其他输入

| 输入 | 描述 | 是否必需 | 默认值 |
|-------|-------------|----------|---------|
| `issue_action` | 用于 `close-issue` 的问题事件动作（`closed`，`reopened`） | 否 | - |
| `previous_tag` | 用于比较提交的先前标签（未指定时自动检测） | 否 | - |

### 输出

#### 核心输出

| 输出 | 描述 | 适用范围 |
|--------|-------------|---------------|
| `status` | 审批状态：`pending`（待处理）、`approved`（已批准）、`denied`（已拒绝）、`timeout`（超时）、`tag_deleted`（标签已删除）、`skipped`（已跳过） | 所有操作 |
| `issue_number` | 创建或检查的问题编号 | 所有操作 |
| `issue_url` | 审批问题的 URL | 所有操作 |

#### 审批输出

| 输出 | 描述 | 适用范围 |
|--------|-------------|---------------|
| `approvers` | 已批准用户的逗号分隔列表 | `process-comment`、`check` |
| `denier` | 拒绝请求的用户 | `process-comment`、`check` |
| `satisfied_group` | 满足审批条件的组名 | `process-comment`、`check` |
| `tag` | 创建的标签名称 | `process-comment`（审批通过时） |
| `tag_deleted` | 被删除的标签 | `close-issue` |

#### Jira 输出

| 输出 | 描述 | 适用范围 |
|--------|-------------|---------------|
| `jira_issues` | 此版本中的 Jira 问题键逗号分隔列表 | `request` |
| `jira_issues_json` | Jira 问题详情的 JSON 数组（键、摘要、类型、状态） | `request` |

#### 部署输出

| 输出 | 描述 | 适用范围 |
|--------|-------------|---------------|
| `deployment_id` | 用于状态更新的 GitHub 部署 ID | `request` |
| `deployment_url` | GitHub 中部署的 URL | `request` |

#### 发布说明输出

| 输出 | 描述 | 适用范围 |
|--------|-------------|---------------|
| `release_notes` | 根据提交和 Jira 问题自动生成的发布说明 | `request` |
| `commits_count` | 此版本中的提交数量 | `request` |

---

## 配置参考

### 策略

策略定义了可重用的审批人组。共有两种格式：

#### 简单格式

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

#### 高级格式（每源阈值）

对于复杂的需求，如“2个平台且1个安全”：

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

**源类型：**

- `team: slug` - GitHub 团队（需要应用令牌）
- `user: username` - 单个用户（隐式 require_all）
- `users: [a, b, c]` - 用户列表

**策略级逻辑：**

- `logic: and` - 必须满足所有源（默认）
- `logic: or` - 满足任一源即可

#### 内联逻辑（混合 AND/OR）

对于复杂表达式，在每个源上使用 `logic:` 指定其与下一个的连接方式：

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

**运算符优先级：** AND 的绑定优先级高于 OR（标准布尔逻辑）。

表达式 `A and B or C and D` 被解析为 `(A AND B) OR (C AND D)`。

### 工作流

工作流定义审批要求和操作：

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

### 标签配置

控制每个工作流中标签的创建方式：

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

**标签选项：**

| 选项 | 描述 |
|--------|-------------|
| `enabled` | 启用标签创建 |
| `start_version` | 起始版本和格式（例如，“v1.0.0”或“1.0.0”） |
| `prefix` | 版本前缀（如果未设置，则从`start_version`推断） |
| `auto_increment` | 自动递增：`major`、`minor`、`patch`，或省略以手动操作 |
| `env_prefix` | 环境前缀（例如，“dev-”创建“dev-v1.0.0”） |

### 自定义问题模板

您可以使用 Go 模板完全自定义问题正文。使用 `body` 进行内联模板，或使用 `body_file` 从文件加载。

**可用模板变量：**

| 变量 | 描述 |
|----------|-------------|
| `{{.Title}}` | 问题标题 |
| `{{.Description}}` | 工作流描述 |
| `{{.Version}}` | Semver 版本 |
| `{{.Requestor}}` | 发起请求的 GitHub 用户名 |
| `{{.Environment}}` | 环境名称 |
| `{{.RunURL}}` | 工作流运行链接 |
| `{{.RepoURL}}` | 仓库 URL |
| `{{.CommitSHA}}` | 完整提交 SHA |
| `{{.CommitURL}}` | 提交链接 |
| `{{.Branch}}` | 分支名称 |
| `{{.GroupsTable}}` | 预渲染的审批状态表 |
| `{{.Timestamp}}` | 请求时间戳 |
| `{{.PreviousVersion}}` | 上一个版本/标签 |
| `{{.CommitsCount}}` | 此次发布的提交数量 |
| `{{.HasJiraIssues}}` | 布尔值 - 是否存在 Jira 问题 |
| `{{.JiraIssues}}` | Jira 问题数据数组 |
| `{{.JiraIssuesTable}}` | 预渲染的 Jira 问题表 |
| `{{.PipelineTable}}` | 预渲染的部署流水线表 |
| `{{.PipelineMermaid}}` | 预渲染的 Mermaid 流程图 |
| `{{.Vars.key}}` | 自定义变量 |

**模板函数：**

| 函数 | 示例 | 描述 |
|----------|---------|-------------|
| `slice` | `{{slice .CommitSHA 0 7}}` | 子字符串（短SHA） |
| `title` | `{{.Environment \| title}}` | 标题大小写 |
| `upper` | `{{.Version \| upper}}` | 大写 |
| `lower` | `{{.Version \| lower}}` | 小写 |
| `join` | `{{join .Groups ","}}` | 连接数组 |
| `contains` | `{{if contains .Branch "feature"}}` | 检查子字符串 |
| `replace` | `{{replace .Version "v" ""}}` | 替换字符串 |
| `default` | `{{default "N/A" .Environment}}` | 默认值 |

**示例自定义模板文件** (`.github/templates/deploy.md`):

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

### 默认值

适用于所有工作流的全局默认值：

```yaml
defaults:
  timeout: 72h                    # Default approval timeout
  allow_self_approval: false      # Whether requestors can approve their own requests
  issue_labels:                   # Labels added to all approval issues
    - approval-required
```

### 语义化版本控制

配置版本处理：

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

## 完整配置参考

本节记录了 `approvals.yml` 中**所有配置选项**。

### 顶层结构

```yaml
version: 1                    # Required: config version (always 1)
defaults: { ... }             # Optional: global defaults
policies: { ... }             # Required: reusable approval policies
workflows: { ... }            # Required: approval workflows
semver: { ... }               # Optional: version handling settings
```

### `defaults` 选项

| Key | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `timeout` | duration | `72h` | 阻塞 `check` 操作且 `wait: true` 的超时时间。使用小时（例如，`168h` 表示 1 周）。事件驱动工作流不需要。 |
| `allow_self_approval` | bool | `false` | 请求者是否可以批准自己的请求 |
| `issue_labels` | string[] | `[]` | 添加到所有审批问题的标签 |

### `policies.<name>` 选项（简单格式）

| Key | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `approvers` | string[] | - | 用户名列表或 `team:slug` 引用 |
| `min_approvals` | int | 0 | 所需的审批数量（0 = 使用 `require_all`） |
| `require_all` | bool | `false` | 若为 true，则所有审批者必须批准 |

### `policies.<name>` 选项（高级格式）

| Key | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `from` | source[] | - | 带有单独阈值的审批者来源列表 |
| `logic` | string | `"and"` | 如何组合来源：`"and"` 或 `"or"` |

**审批者来源选项（`from[]`）：**

| Key | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `team` | string | - | 团队简称（例如，`"platform"` 或 `"org/platform"`） |
| `user` | string | - | 单个用户名 |
| `users` | string[] | - | 用户名列表 |
| `min_approvals` | int | 1 | 该来源所需的审批数 |
| `require_all` | bool | `false` | 该来源的所有人必须批准 |
| `logic` | string | - | 到下一个来源的逻辑：`"and"` 或 `"or"` |

### `workflows.<name>` 选项

| Key | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `description` | string | - | 人类可读的描述 |
| `trigger` | map | - | 触发条件（用于过滤） |
| `require` | requirement[] | - | **必需：** 审批要求（项之间为 OR 逻辑） |
| `issue` | object | - | 问题创建设置 |
| `on_approved` | object | - | 审批通过时的操作 |
| `on_denied` | object | - | 审批拒绝时的操作 |
| `on_closed` | object | - | 手动关闭问题时的操作 |
| `pipeline` | object | - | 渐进式部署流水线配置 |

### `workflows.<name>.require[]` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `policy` | string | - | 引用已定义的策略 |
| `approvers` | string[] | - | 内联审批人（策略的替代方案） |
| `min_approvals` | int | - | 覆盖策略的最小审批数 |
| `require_all` | bool | - | 覆盖策略的全部通过要求 |

### `workflows.<name>.issue` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `title` | string | `"Approval Required: {workflow}"` | 问题标题（支持 `{{version}}`、`{{environment}}`、`{{workflow}}`） |
| `body` | string | - | 自定义问题正文模板（Go 模板语法） |
| `body_file` | string | - | 模板文件路径（相对于 `.github/`） |
| `labels` | string[] | `[]` | 此工作流的额外标签 |
| `assignees_from_policy` | bool | `false` | 自动分配策略中的个人用户（最多 10 个） |

### `workflows.<name>.on_approved` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `create_tag` | bool | `false` | 创建 git 标签（使用输入版本） |
| `close_issue` | bool | `false` | 审批后关闭问题 |
| `comment` | string | - | 发布评论（支持 `{{version}}`、`{{satisfied_group}}`） |
| `tagging` | object | - | 高级标签配置 |

### `workflows.<name>.on_approved.tagging` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | 启用标签创建 |
| `start_version` | string | `"0.0.0"` | 初始版本（例如，`"v1.0.0"` 或 `"1.0.0"`） |
| `prefix` | string | （推断） | 版本前缀（根据 `start_version` 推断） |
| `auto_increment` | string | - | 自动递增：`"major"`、`"minor"`、`"patch"`，或省略以手动方式 |
| `env_prefix` | string | - | 环境前缀（例如，`"dev-"` 创建 `"dev-v1.0.0"`） |

### `workflows.<name>.on_denied` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `close_issue` | bool | `false` | 拒绝后关闭 issue |
| `comment` | string | - | 要发布的评论（支持 `{{denier}}`） |

### `workflows.<name>.on_closed` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `delete_tag` | bool | `false` | 关闭 issue 时删除关联标签 |
| `comment` | string | - | 要发布的评论（支持 `{{tag}}`、`{{version}}`） |

### `workflows.<name>.pipeline` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `stages` | stage[] | - | **必需：** 有序的部署阶段列表 |
| `track_prs` | bool | `false` | 在 issue 内容中包含合并的 PR |
| `track_commits` | bool | `false` | 在 issue 内容中包含提交 |
| `compare_from_tag` | string | - | 用于比较的标签模式（例如，`"v*"`） |
| `show_mermaid_diagram` | bool | `true` | 显示管道阶段的 Mermaid 流程图 |
| `release_strategy` | object | - | 发布候选选择策略 |

### `workflows.<name>.pipeline.stages[]` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `name` | string | - | **必需：** 阶段名称（例如，`"dev"`、`"prod"`） |
| `environment` | string | - | GitHub 环境名称 |
| `policy` | string | - | 本阶段的审批策略 |
| `approvers` | string[] | - | 内联审批人（作为策略的替代） |
| `on_approved` | string | - | 阶段被批准时发布的评论 |
| `create_tag` | bool | `false` | 在此阶段创建 git 标签 |
| `is_final` | bool | `false` | 此阶段后关闭问题 |
| `auto_approve` | bool | `false` | 自动批准，无需人工干预 |

### `workflows.<name>.pipeline.release_strategy` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `type` | string | `"tag"` | 策略: `"tag"`，`"branch"`，`"label"`，`"milestone"` |
| `branch` | object | - | 分支策略设置 |
| `label` | object | - | 标签策略设置 |
| `milestone` | object | - | 里程碑策略设置 |
| `auto_create` | object | - | 自动创建下一个发布产物 |

### `release_strategy.branch` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `pattern` | string | `"release/{{version}}"` | 分支命名模式 |
| `base_branch` | string | `"main"` | 比较基准分支 |
| `delete_after_release` | bool | `false` | 生产部署后删除分支 |

### `release_strategy.label` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `pattern` | string | `"release:{{version}}"` | 标签命名模式 |
| `pending_label` | string | - | 等待发布分配的 PR 标签 |
| `remove_after_release` | bool | `false` | 生产部署后移除标签 |

### `release_strategy.milestone` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `pattern` | string | `"v{{version}}"` | 里程碑命名模式 |
| `close_after_release` | bool | `false` | 生产部署后关闭里程碑 |

### `release_strategy.auto_create` 选项

| 键 | 类型 | 默认值 | 描述 |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | 启用在最终阶段完成时自动创建 |
| `next_version` | string | `"patch"` | 版本递增: `"patch"`，`"minor"`，`"major"` |
| `create_issue` | bool | `false` | 为下次发布创建新的审批问题 |
| `comment` | string | - | 关于下次发布的评论 |

### `semver` 选项

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `prefix` | string | `"v"` | 标签前缀 |
| `strategy` | string | `"input"` | 版本策略: `"input"`，`"auto"` |
| `validate` | bool | `false` | 验证 semver 格式 |
| `allow_prerelease` | bool | `false` | 允许预发布版本（例如，`v1.0.0-beta.1`） |
| `auto` | object | - | 基于标签的自动递增设置 |

### `semver.auto` 选项

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `major_labels` | string[] | `[]` | 触发主版本递增的 PR 标签 |
| `minor_labels` | string[] | `[]` | 触发次版本递增的 PR 标签 |
| `patch_labels` | string[] | `[]` | 触发补丁版本递增的 PR 标签 |

---

## 功能详情

### 审批关键词

用户可以通过在问题中评论来批准或拒绝请求：

**批准关键词：** `approve`，`approved`，`lgtm`，`yes`，`/approve`

**拒绝关键词：** `deny`，`denied`，`reject`，`rejected`，`no`，`/deny`

### 团队支持

要使用基于 GitHub 团队的审批者，您需要提升权限。标准的 `GITHUB_TOKEN` 无法列出团队成员。请使用 GitHub 应用令牌：

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

**所需的 GitHub 应用权限：**

- `Organization > Members: Read` - 用于列出团队成员

### 渐进式部署流水线

通过单个审批问题跟踪多个环境的部署。每个阶段获得批准后，问题会更新以显示进度，并自动推进到下一个阶段。

#### 流水线配置

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

#### 流水线工作流程示例

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

#### 工作原理

1. **问题创建**：触发时，创建一个显示所有阶段的单个问题，包含可视化的 Mermaid 图表和进度表：

```markdown
## 🚀 部署流水线：v1.2.0

### 流水线流程

​```mermaid
flowchart LR
    DEV(⏳ 开发)
    QA(⬜ 测试)
    STAGE(⬜ 预发布)
    PROD(⬜ 生产)
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

Mermaid 图表提供了带有颜色编码节点的一目了然视图：
- 🟢 **绿色** - 已完成阶段
- 🟡 **黄色** - 等待批准的当前阶段
- ⚪ **灰色** - 待处理阶段
- 🔵 **青色** - 自动批准阶段

要禁用 Mermaid 图表，请在流水线配置中设置 `show_mermaid_diagram: false`。

2. **阶段进展**：评论 `approve` 以进入下一阶段。图表和表格会自动更新：

```markdown
| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ✅ Deployed | @developer1 | Dec 9 10:30 |
| QA | ✅ Deployed | @qa-lead | Dec 9 14:15 |
| STAGE | ⏳ Awaiting | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** STAGE
```
3. **PR 和提交跟踪**：发布管理员可以准确看到正在部署的内容：


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
4. **完成**：当最终阶段被批准时：
   - 创建标签（如果 `create_tag: true`）
   - 发布完成评论
   - 自动关闭问题

#### 流水线阶段选项

| 选项 | 说明 |
|--------|-------------|
| `name` | 阶段名称（在表格中显示） |
| `environment` | GitHub 环境名称 |
| `policy` | 本阶段的审批策略 |
| `approvers` | 内联审批人（策略的替代方案） |
| `on_approved` | 阶段批准时发布的消息 |
| `create_tag` | 在此阶段创建 git 标签 |
| `is_final` | 在此阶段后关闭问题 |
| `auto_approve` | 自动批准此阶段，无需人工干预 |
| `approval_mode` | 覆盖本阶段的工作流审批模式 |

#### 审批模式

选择审批人如何与审批请求交互：

| 模式 | 说明 |
|------|-------------|
| `comments` | （默认）审批人在问题中评论 `/approve` 或 `approve` |
| `sub_issues` | 为每个阶段创建子问题 - 关闭子问题即表示批准 |
| `hybrid` | 各阶段混合使用模式 - 在每个阶段使用 `approval_mode` |

**子问题审批示例：**


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

对于子问题，父问题显示一个审批子问题的表格：

```markdown
### 📋 Approval Sub-Issues

| Stage | Sub-Issue | Status | Assignees |
|-------|-----------|--------|----------|
| DEV | #124 | ⏳ Awaiting | @alice, @bob |
| PROD | #125 | ⏳ Awaiting | @sre1, @sre2 |
```

**混合模式（每阶段覆盖）：**

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

#### 增强的评论用户体验

该操作包括增强的基于评论的审批用户体验：

- **表情符号反应**：审批评论上的自动反应
  - 👍 通过
  - 👎 拒绝
  - 👀 已查看（处理中）

- **快速操作部分**：问题正文包含命令参考表：

```markdown
### ⚡ Quick Actions

| Action | Command | Description |
|--------|---------|-------------|
| ✅ Approve | `/approve` | Approve the **DEV** stage |
| ❌ Deny | `/deny [reason]` | Deny with optional reason |
| 📊 Status | `/status` | Show current approval status |
```

**通过 `comment_settings` 配置：**

```yaml
workflows:
  deploy:
    comment_settings:
      react_to_comments: true     # Add emoji reactions (default: true)
      show_quick_actions: true    # Show Quick Actions section (default: true)
```

#### 对低级环境自动批准

在应自动批准且无需人工干预的流水线阶段使用 `auto_approve: true`。这非常适用于诸如 `dev` 或 `integration` 等低级环境，既能加快流水线速度，又能保持对生产环境的审批门控。

**包含自动批准的示例：**

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

**工作原理：**

1. 当创建管道问题时，所有初始的 `auto_approve: true` 阶段会自动完成
2. 当某个阶段被手动批准后，紧接其后的所有连续 `auto_approve: true` 阶段也会自动完成
3. 自动批准的阶段在管道表中显示 🤖 指示标志
4. 批准者在阶段历史中记录为 `[auto]`

**使用场景：**

- **开发环境**：立即部署，无需等待批准
- **集成测试**：让 CI/CD 管道自动推进通过测试环境
- **金丝雀部署**：自动批准金丝雀阶段，完整发布需批准

#### 管道配置选项

| 选项 | 默认值 | 描述 |
|--------|---------|-------------|
| `track_prs` | `false` | 在问题正文中包含已合并的 PR |
| `track_commits` | `false` | 包含自上一个标签以来的提交 |
| `compare_from_tag` | - | 自定义比较的标签模式 |
| `show_mermaid_diagram` | `true` | 显示管道阶段的 Mermaid 可视化流程图 |

**注意：** PR 跟踪需要工作流中拥有 `pull-requests: read` 权限。

### 发布候选策略

在企业环境中，合并到主分支的 PR 并不总是立即成为发布候选。审批引擎支持三种策略来选择哪些 PR 属于发布：

#### 策略类型

| 策略 | 描述 | 使用场景 |
|----------|-------------|----------|
| `tag` | 两个 git 标签之间的 PR（默认） | 简单发布，基于主干的开发 |
| `branch` | 合并到发布分支的 PR | GitFlow，发布分支 |
| `label` | 带有特定发布标签的 PR | 灵活选择，批量发布 |
| `milestone` | 指定到 GitHub 里程碑的 PR | 与路线图对齐的发布 |

#### 配置

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

#### 分支策略

使用发布分支进行 GitFlow 风格的开发：

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

**工作原理：**
1. 创建发布分支：`release/v1.2.0`
2. 合并到该分支的 PR 是发布候选版本
3. 请求该版本的审批
4. 审批问题显示发布分支中的所有 PR
5. 生产环境发布后，分支被删除（可选）并创建下一个分支

#### 标签策略

使用标签进行灵活的 PR 选择：

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

**工作原理：**
1. 合并到主分支的PR会被打上`pending-release`标签
2. 发布经理对选定的PR应用`release:v1.2.0`标签
3. 请求v1.2.0的审批
4. 审批问题仅显示带有该标签的PR
5. 生产发布后，标签被移除并创建下一个发布标签

#### 里程碑策略

使用里程碑进行与路线图对齐的发布：

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

**工作原理：**
1. 创建里程碑：“版本 1.2.0”
2. 在开发过程中将 PR 分配到该里程碑
3. 请求 v1.2.0 的批准
4. 批准问题显示里程碑中的所有 PR
5. 生产完成后关闭里程碑并创建下一个里程碑

#### 完成时自动创建

当最终阶段（生产）获得批准时，自动为下一个版本做准备：

```yaml
auto_create:
  enabled: true
  next_version: patch      # Calculate next: patch, minor, or major
  create_issue: true       # Create new approval issue immediately
  comment: |               # Custom message (optional)
    🚀 **Next release prepared:** {{version}}
```

这将创建：
- **分支策略：** 从主分支创建新的发布分支
- **标签策略：** 新的发布标签
- **里程碑策略：** 新的里程碑

#### 清理选项

每种策略都有在最终阶段（生产）批准时运行的可选清理操作。**所有清理选项默认为 `false`** - 清理为自愿启用：

| 策略 | 清理选项 | 描述 |
|----------|----------------|-------------|
| 分支 | `delete_after_release` | 删除发布分支 |
| 标签 | `remove_after_release` | 从 PR 中移除发布标签 |
| 里程碑 | `close_after_release` | 关闭里程碑 |

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

#### 热修复部署

对于需要绕过正常发布流程的紧急热修复，创建一个单独的工作流程：

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

**触发热修复与常规发布：**

```bash
# Regular release - goes through all stages
gh workflow run request-approval.yml -f workflow_name=deploy -f version=v1.3.0

# Hotfix - goes straight to prod
gh workflow run request-approval.yml -f workflow_name=hotfix -f version=v1.2.1
```

**热修复模式：**

| 场景 | 策略 | 清理 | 自动创建 |
|----------|----------|---------|-------------|
| 紧急修复 | `tag` | 无 | 禁用 |
| 补丁发布 | `milestone` | `close_after_release: false` | 禁用 |
| 多个热修复 | `branch` | `delete_after_release: false` | 禁用 |

#### 发布策略优势

| 策略 | 优点 | 缺点 |
|----------|------|------|
| **标签** | 简单，无需额外工作流程 | 包含所有合并的PR |
| **分支** | 发布范围清晰，隔离性好 | 分支管理开销大 |
| **标签（Label）** | 灵活选择，易于更改 | 需要手动标记 |
| **里程碑** | 路线图可见，规划集成 | 需要严格管理里程碑 |

**建议：**

- 对于持续部署的简单项目，使用 **标签**  
- 对于需要发布隔离的受控环境，使用 **分支**  
- 对于范围灵活的批量发布，使用 **标签（Label）**  
- 对于有明确发布规划的路线图驱动开发，使用 **里程碑**  

### Jira 集成

自动从提交和分支名称中提取 Jira 任务。该操作支持两种模式：

#### 仅链接模式（无需认证）

只需提供 `jira_base_url`，即可提取任务关键字并显示为可点击链接：

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    jira_base_url: https://yourcompany.atlassian.net  # That's it!
```

这会从提交信息和分支名称中提取问题关键字（例如，`PROJ-123`），并将它们作为链接显示在审批问题中：

```markdown
### Jira Issues
- [PROJ-123](https://yourcompany.atlassian.net/browse/PROJ-123)
- [PROJ-456](https://yourcompany.atlassian.net/browse/PROJ-456)
```

#### 全模式（含API访问）

添加凭据以获取问题详情并更新修复版本：

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
这显示了丰富的问题信息：


```markdown
### Jira Issues in this Release

| Key | Summary | Type | Status |
|-----|---------|------|--------|
| [PROJ-123](https://...) | Fix login bug | Bug | Done |
| [PROJ-456](https://...) | Add dark mode | Feature | In Progress |
```

**模式比较：**

| 模式 | 需要认证 | 功能 |
|------|----------|------|
| 仅链接 | 否 | 将密钥作为可点击链接发布 |
| 完整 | 是 | 链接 + 摘要、状态、类型表情、修复版本更新 |

**Jira 输出：**

```yaml
- name: Use Jira Outputs
  run: |
    echo "Issues: ${{ steps.approval.outputs.jira_issues }}"
    # Output: PROJ-123,PROJ-456

    echo "Details: ${{ steps.approval.outputs.jira_issues_json }}"
    # Output: [{"key":"PROJ-123","summary":"Fix login bug",...}]
```

### 部署跟踪

在 GitHub 部署仪表板中创建 GitHub 部署以实现可见性。此功能独立于工作流 YAML 中的 `environment:` 键。

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

**部署出现的位置：**

- 仓库的 **Deployments** 选项卡
- 仓库页面上的环境状态徽章
- 配置后可用的 GitHub for Jira 集成
- 用于 CI/CD 工具的 GitHub API

**注意：** 这通过 GitHub Deployments API 创建部署，该 API 与 GitHub 原生的环境保护规则是分开的。您可以同时使用两者，也可以独立使用。

### 外部配置仓库

将审批配置存储在共享仓库中以实现集中策略管理：

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    token: ${{ secrets.GITHUB_TOKEN }}
    config_repo: myorg/.github  # Shared config repo
```

**配置解析顺序：**

1. 外部仓库中的 `{repo-name}_approvals.yml`（例如，`myapp_approvals.yml`）
2. 外部仓库中的 `approvals.yml`（共享默认）
3. 当前仓库中的 `.github/approvals.yml`（本地后备）

**示例组织结构：**

```text
myorg/.github/
├── myapp_approvals.yml      # App-specific config
├── backend_approvals.yml    # Backend repos config
└── approvals.yml            # Default for all repos
```

### 阻塞审批

对于需要等待审批后才能继续的工作流程：

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

**注意：** 阻塞工作流会保持运行器处于活动状态，从而消耗 GitHub Actions 分钟。对于成本敏感的场景，请使用事件驱动的方法（分离的 `process-comment` 工作流）。

### 关闭问题时删除标签

可选地在审批问题被手动关闭时删除标签：

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

**处理关闭事件：**

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

### 与团队支持共同处理评论

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

### 多环境推广

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

### 在后续作业中使用输出

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

或者在持续集成中验证：

```yaml
- name: Validate Config
  run: |
    npm install -g ajv-cli
    ajv validate -s schema.json -d .github/approvals.yml
```

---

## GitHub 企业服务器

该操作完全支持 GitHub 企业服务器。它使用 `GITHUB_SERVER_URL` 和 `GITHUB_API_URL` 环境变量自动检测 GHES 环境。

无需额外配置 - 操作将自动使用正确的 API 端点。

**速率限制：**

该操作包括针对速率限制错误的自动重试和指数退避。配置如下：

- 初始延迟：1秒
- 最大延迟：60秒
- 最大重试次数：5次
- 抖动：随机添加 0-500 毫秒以防止羊群效应

---

## 许可

MIT 许可


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---