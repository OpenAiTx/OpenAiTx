# エンタープライズ承認エンジン

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](ES/README.md)

グループごとの閾値（N人中X人）によるポリシーベースの承認ワークフロー、グループ間のORロジック、および自動セマンティックバージョニングタグ作成を備えたエンタープライズ向けGitHubアクション。

## 機能

- **柔軟な承認ロジック**：グループ内でのAND（全員承認）および閾値（N人中X人）の両方をサポート
- **グループ間のORロジック**：複数の承認経路 - いずれかのグループが要件を満たせば承認
- **混合承認者**：同じグループ内で個人ユーザーとGitHubチームを組み合わせ可能
- **段階的なデプロイパイプライン**：単一の課題で複数環境（dev → qa → stage → prod）を追跡
- **パイプラインの可視化**：デプロイ進行状況を示す色分けされたMermaidフローチャート図
- **サブ課題による承認**：各ステージ専用の承認サブ課題を作成し、承認時にクローズ
- **強化されたコメントUX**：承認コメントへの絵文字リアクション、コマンド参照付きクイックアクションセクション
- **課題クローズ保護**：権限のないユーザーによる承認課題のクローズを防止（自動再オープン）
- **ハイブリッド承認モード**：ワークフローまたはステージごとにコメントベースとサブ課題承認を混在
- **PRおよびコミット追跡**：デプロイ課題にPRとコミットを自動リストアップしてリリース管理
- **セマンティックバージョンタグ作成**：承認時に自動でgitタグを作成
- **ポリシーベース設定**：YAMLで再利用可能な承認ポリシーを定義
- **課題ベースのワークフロー**：GitHub課題を通じた透明な監査証跡
- **Jira統合**：コミットから課題キーを抽出し承認課題に表示、Fix Versionsを更新
- **デプロイ追跡**：デプロイダッシュボードで可視化するためGitHubデプロイメントを作成
- **外部設定**：承認ポリシーを共有リポジトリで集中管理
- **レート制限処理**：GitHub APIのレート制限に対し指数的バックオフで自動リトライ
- **GitHub Enterprise Server対応**：GHES環境を完全サポート
- **外部依存なし**：純粋なGitHub Actionsで外部サービス不要

📋 **動作例はこちら：** [承認課題の例](https://github.com/jamengual/enterprise-approval-engine/issues/7)

## 目次

- [クイックスタート](#quick-start)
- [アクションリファレンス](#action-reference)
  - [アクション](#actions)
  - [入力](#inputs)
  - [出力](#outputs)
- [設定リファレンス](#configuration-reference)
  - [ポリシー](#policies)
  - [ワークフロー](#workflows)
  - [タグ付け](#tagging-configuration)
  - [カスタムテンプレート](#custom-issue-templates)
  - [デフォルト](#defaults)
  - [セマンティックバージョニング](#semver)
- [完全な設定リファレンス](#complete-configuration-reference)
- [機能の詳細](#feature-details)
  - [承認キーワード](#approval-keywords)
  - [チームサポート](#team-support)
  - [段階的デプロイパイプライン](#progressive-deployment-pipelines)
  - [リリース候補戦略](#release-candidate-strategies)
  - [Jira統合](#jira-integration)
  - [デプロイ追跡](#deployment-tracking)
  - [外部設定リポジトリ](#external-config-repository)
  - [承認のブロック](#blocking-approvals)
  - [タグ削除](#tag-deletion-on-issue-close)
- [完全な例](#complete-examples)
- [スキーマ検証](#schema-validation)
- [GitHub Enterprise Server](#github-enterprise-server)

## クイックスタート

### 1. 設定の作成

リポジトリ内に `.github/approvals.yml` を作成してください:

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

### 2. リクエスト承認ワークフロー

`.github/workflows/request-approval.yml` を作成します：

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

### 3. 承認コメントの処理

`.github/workflows/handle-approval.yml` を作成します:

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

## アクションリファレンス

### アクション

このアクションは、`action` 入力を通じて4つの動作モードをサポートします：

| アクション | 説明 | 使用タイミング |
|--------|-------------|-------------|
| `request` | 新しい承認リクエストのイシューを作成する | デプロイ／リリースワークフロー開始時 |
| `process-comment` | 承認・拒否コメントを処理する | `issue_comment` イベント時 |
| `check` | 現在の承認状態をチェックする | 承認完了をポーリングするため |
| `close-issue` | イシューのクローズイベントを処理する | `issues: [closed]` イベント時 |

### 入力

#### コア入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `action` | 実行するアクション：`request`, `check`, `process-comment`, `close-issue` | はい | - |
| `workflow` | 設定からのワークフロー名（`request` アクション用） | `request` の場合 | - |
| `version` | タグ作成用のセマンティックバージョン（例：`1.2.3` または `v1.2.3`） | いいえ | - |
| `issue_number` | イシュー番号（`check`, `process-comment`, `close-issue` 用） | check/process/close の場合 | - |
| `token` | API操作用GitHubトークン | はい | - |

#### 設定入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `config_path` | approvals.yml設定ファイルのパス | いいえ | `.github/approvals.yml` |
| `config_repo` | 共有設定用の外部リポジトリ（例：`org/.github`） | いいえ | - |

#### ポーリング入力（`check`アクション用）

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `wait` | すぐに戻らず承認完了まで待つ（ポーリング） | いいえ | `false` |
| `timeout` | 待機タイムアウト（例：`24h`、`1h30m`、`30m`） | いいえ | `72h` |

#### チームサポート入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `app_id` | チームメンバーシップチェック用のGitHubアプリID | いいえ | - |
| `app_private_key` | チームメンバーシップチェック用のGitHubアプリ秘密鍵 | いいえ | - |

#### Jira統合入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `jira_base_url` | Jira CloudのベースURL（例：`https://yourcompany.atlassian.net`） | いいえ | - |
| `jira_user_email` | API認証用のJiraユーザーのメールアドレス | いいえ | - |
| `jira_api_token` | 認証用のJira APIトークン | いいえ | - |
| `jira_update_fix_version` | 承認時にFix VersionでJira課題を更新するか | いいえ | `true` |
| `include_jira_issues` | 承認リクエスト本文にJira課題を含めるか | いいえ | `true` |

#### デプロイトラッキング入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `create_deployment` | トラッキング用にGitHubデプロイメントを作成するか | いいえ | `true` |
| `deployment_environment` | 対象環境（例：`production`、`staging`） | いいえ | `production` |
| `deployment_environment_url` | デプロイ済み環境のURL | いいえ | - |

#### その他の入力

| 入力 | 説明 | 必須 | デフォルト |
|-------|-------------|----------|---------|
| `issue_action` | `close-issue`用のIssueイベントアクション（`closed`、`reopened`） | いいえ | - |
| `previous_tag` | コミット比較対象の前のタグ（指定がない場合は自動検出） | いいえ | - |

### 出力

#### コア出力

| 出力 | 説明 | 利用可能対象 |
|--------|-------------|---------------|
| `status` | 承認ステータス：`pending`、`approved`、`denied`、`timeout`、`tag_deleted`、`skipped` | すべてのアクション |
| `issue_number` | 作成またはチェックされた課題番号 | すべてのアクション |
| `issue_url` | 承認課題のURL | すべてのアクション |

#### 承認アウトプット

| 出力 | 説明 | 利用可能なアクション |
|--------|-------------|---------------|
| `approvers` | 承認したユーザーのカンマ区切りリスト | `process-comment`、`check` |
| `denier` | リクエストを拒否したユーザー | `process-comment`、`check` |
| `satisfied_group` | 承認条件を満たしたグループ名 | `process-comment`、`check` |
| `tag` | 作成されたタグ名 | `process-comment`（承認時） |
| `tag_deleted` | 削除されたタグ | `close-issue` |

#### Jira アウトプット

| 出力 | 説明 | 利用可能なアクション |
|--------|-------------|---------------|
| `jira_issues` | 本リリースに含まれるJira課題キーのカンマ区切りリスト | `request` |
| `jira_issues_json` | Jira課題の詳細（キー、概要、タイプ、ステータス）を含むJSON配列 | `request` |

#### デプロイメントアウトプット

| 出力 | 説明 | 利用可能なアクション |
|--------|-------------|---------------|
| `deployment_id` | ステータス更新用のGitHubデプロイメントID | `request` |
| `deployment_url` | GitHub上のデプロイメントURL | `request` |

#### リリースノートアウトプット

| 出力 | 説明 | 利用可能なアクション |
|--------|-------------|---------------|
| `release_notes` | コミットとJira課題から自動生成されたリリースノート | `request` |
| `commits_count` | 本リリースのコミット数 | `request` |

---

## 設定リファレンス

### ポリシー

ポリシーは再利用可能な承認者グループを定義します。フォーマットは2つあります：

#### シンプルフォーマット

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

#### 高度なフォーマット（ソースごとのしきい値）

「プラットフォームから2つかつセキュリティから1つ」のような複雑な要件の場合：

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

**ソースタイプ：**

- `team: slug` - GitHubチーム（Appトークンが必要）
- `user: username` - 単一ユーザー（暗黙的にrequire_all）
- `users: [a, b, c]` - ユーザーのリスト

**ポリシーレベルのロジック：**

- `logic: and` - すべてのソースを満たす必要がある（デフォルト）
- `logic: or` - いずれかのソースを満たせば十分

#### インラインロジック（AND/ORの混合）

複雑な式の場合、各ソースに`logic:`を使用して次のソースとの接続方法を指定：

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

**演算子の優先順位:** AND は OR よりも結合力が強い（標準的なブール論理）。

式 `A and B or C and D` は `(A AND B) OR (C AND D)` と評価されます。

### ワークフロー

ワークフローは承認要件とアクションを定義します：

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

### タギング設定

ワークフローごとにタグの作成方法を制御します:

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
**タグ付けオプション:**

| オプション | 説明 |
|--------|-------------|
| `enabled` | タグ作成を有効にする |
| `start_version` | 開始バージョンと形式（例："v1.0.0" または "1.0.0"） |
| `prefix` | バージョン接頭辞（未設定の場合は `start_version` から推測） |
| `auto_increment` | 自動インクリメント：`major`、`minor`、`patch`、または手動の場合は省略 |
| `env_prefix` | 環境接頭辞（例："dev-" は "dev-v1.0.0" を作成） |

### カスタム課題テンプレート

Goテンプレートを使用して課題本文を完全にカスタマイズできます。インラインテンプレートには `body`、ファイルから読み込む場合は `body_file` を使用します。

**利用可能なテンプレート変数:**

| 変数 | 説明 |
|----------|-------------|
| `{{.Title}}` | 課題タイトル |
| `{{.Description}}` | ワークフローディスクリプション |
| `{{.Version}}` | セマンティックバージョン |
| `{{.Requestor}}` | リクエストしたGitHubユーザー名 |
| `{{.Environment}}` | 環境名 |
| `{{.RunURL}}` | ワークフロー実行へのリンク |
| `{{.RepoURL}}` | リポジトリURL |
| `{{.CommitSHA}}` | 完全なコミットSHA |
| `{{.CommitURL}}` | コミットへのリンク |
| `{{.Branch}}` | ブランチ名 |
| `{{.GroupsTable}}` | 事前レンダリング済み承認状態テーブル |
| `{{.Timestamp}}` | リクエストタイムスタンプ |
| `{{.PreviousVersion}}` | 以前のバージョン／タグ |
| `{{.CommitsCount}}` | このリリースのコミット数 |
| `{{.HasJiraIssues}}` | ブール値 - Jira課題の有無 |
| `{{.JiraIssues}}` | Jira課題データの配列 |
| `{{.JiraIssuesTable}}` | 事前レンダリング済みJira課題テーブル |
| `{{.PipelineTable}}` | 事前レンダリング済みデプロイパイプラインテーブル |
| `{{.PipelineMermaid}}` | 事前レンダリング済みMermaidフローチャート図 |
| `{{.Vars.key}}` | カスタム変数 |


**テンプレート関数:**

| 関数 | 例 | 説明 |
|----------|---------|-------------|
| `slice` | `{{slice .CommitSHA 0 7}}` | サブストリング（短縮SHA） |
| `title` | `{{.Environment \| title}}` | タイトルケース |
| `upper` | `{{.Version \| upper}}` | 大文字変換 |
| `lower` | `{{.Version \| lower}}` | 小文字変換 |
| `join` | `{{join .Groups ","}}` | 配列を結合 |
| `contains` | `{{if contains .Branch "feature"}}` | 部分文字列の確認 |
| `replace` | `{{replace .Version "v" ""}}` | 文字列の置換 |
| `default` | `{{default "N/A" .Environment}}` | デフォルト値 |

**カスタムテンプレートファイルの例** (`.github/templates/deploy.md`):

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

### デフォルト

すべてのワークフローに適用されるグローバルデフォルト：

```yaml
defaults:
  timeout: 72h                    # Default approval timeout
  allow_self_approval: false      # Whether requestors can approve their own requests
  issue_labels:                   # Labels added to all approval issues
    - approval-required
```

### セムバー

バージョン管理の設定:

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

## 完全な設定リファレンス

このセクションでは、`approvals.yml`で利用可能な**すべての設定オプション**を文書化します。

### トップレベルの構造

```yaml
version: 1                    # Required: config version (always 1)
defaults: { ... }             # Optional: global defaults
policies: { ... }             # Required: reusable approval policies
workflows: { ... }            # Required: approval workflows
semver: { ... }               # Optional: version handling settings
```
### `defaults` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `timeout` | duration | `72h` | `wait: true` のブロッキング `check` アクションのタイムアウト。時間単位を使用（例: 1週間は `168h`）。イベント駆動型ワークフローでは不要。 |
| `allow_self_approval` | bool | `false` | リクエスターが自身のリクエストを承認できるかどうか |
| `issue_labels` | string[] | `[]` | すべての承認イシューに追加されるラベル |

### `policies.<name>` オプション（シンプル形式）

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `approvers` | string[] | - | ユーザー名または `team:slug` 参照のリスト |
| `min_approvals` | int | 0 | 必要な承認数（0 = `require_all` を使用） |
| `require_all` | bool | `false` | true の場合、すべての承認者が承認する必要がある |

### `policies.<name>` オプション（高度な形式）

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `from` | source[] | - | 個別の閾値を持つ承認者ソースのリスト |
| `logic` | string | `"and"` | ソースを結合する方法: `"and"` または `"or"` |

**承認者ソースオプション（`from[]`）:**

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `team` | string | - | チームスラッグ（例: `"platform"` または `"org/platform"`） |
| `user` | string | - | 単一のユーザー名 |
| `users` | string[] | - | ユーザー名のリスト |
| `min_approvals` | int | 1 | このソースから必要な承認数 |
| `require_all` | bool | `false` | このソースの全員が承認する必要がある |
| `logic` | string | - | 次のソースへの論理: `"and"` または `"or"` |

### `workflows.<name>` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `description` | string | - | 人間が読める説明 |

| `trigger` | map | - | トリガー条件（フィルタリング用） |
| `require` | requirement[] | - | **必須:** 承認要件（アイテム間はORロジック） |
| `issue` | object | - | イシュー作成設定 |
| `on_approved` | object | - | 承認時のアクション |
| `on_denied` | object | - | 否認時のアクション |
| `on_closed` | object | - | イシューが手動でクローズされた時のアクション |
| `pipeline` | object | - | 段階的デプロイパイプライン設定 |

### `workflows.<name>.require[]` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `policy` | string | - | 定義済みポリシーの参照 |
| `approvers` | string[] | - | インライン承認者（ポリシーの代替） |
| `min_approvals` | int | - | ポリシーのmin_approvalsを上書き |
| `require_all` | bool | - | ポリシーのrequire_allを上書き |

### `workflows.<name>.issue` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `title` | string | `"Approval Required: {workflow}"` | イシュータイトル（`{{version}}`、`{{environment}}`、`{{workflow}}`対応） |
| `body` | string | - | カスタムイシューボディテンプレート（Goテンプレート構文） |
| `body_file` | string | - | テンプレートファイルパス（`.github/`からの相対パス） |
| `labels` | string[] | `[]` | このワークフロー用の追加ラベル |
| `assignees_from_policy` | bool | `false` | ポリシーから個別ユーザーを自動アサイン（最大10人） |

### `workflows.<name>.on_approved` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `create_tag` | bool | `false` | gitタグを作成（入力バージョンを使用） |
| `close_issue` | bool | `false` | 承認後にイシューをクローズ |
| `comment` | string | - | 投稿するコメント（`{{version}}`、`{{satisfied_group}}`対応） |
| `tagging` | object | - | 詳細なタグ付け設定 |

### `workflows.<name>.on_approved.tagging` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | タグ作成を有効にする |
| `start_version` | string | `"0.0.0"` | 初期バージョン（例：`"v1.0.0"` または `"1.0.0"`） |
| `prefix` | string | (推測) | バージョン接頭辞（`start_version`から推測） |
| `auto_increment` | string | - | 自動インクリメント：`"major"`、`"minor"`、`"patch"`、または手動の場合は省略 |
| `env_prefix` | string | - | 環境接頭辞（例：`"dev-"` で `"dev-v1.0.0"` を作成） |

### `workflows.<name>.on_denied` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `close_issue` | bool | `false` | 拒否後にIssueをクローズする |
| `comment` | string | - | 投稿するコメント（`{{denier}}`をサポート） |

### `workflows.<name>.on_closed` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `delete_tag` | bool | `false` | Issueクローズ時に関連タグを削除する |
| `comment` | string | - | 投稿するコメント（`{{tag}}`、`{{version}}`をサポート） |

### `workflows.<name>.pipeline` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `stages` | stage[] | - | **必須:** デプロイステージの順序付きリスト |
| `track_prs` | bool | `false` | Issue本文にマージされたPRを含める |
| `track_commits` | bool | `false` | Issue本文にコミットを含める |
| `compare_from_tag` | string | - | 比較開始タグパターン（例：`"v*"`） |
| `show_mermaid_diagram` | bool | `true` | パイプラインステージのMermaidフローチャートを表示 |
| `release_strategy` | object | - | リリース候補選択戦略 |

### `workflows.<name>.pipeline.stages[]` オプション

| Key | Type | Default | 説明 |
|-----|------|---------|-------------|
| `name` | string | - | **必須:** ステージ名（例：`"dev"`、`"prod"`） |
| `environment` | string | - | GitHub環境名 |
| `policy` | string | - | このステージの承認ポリシー |
| `approvers` | string[] | - | インライン承認者（ポリシーの代替） |
| `on_approved` | string | - | ステージ承認時に投稿するコメント |
| `create_tag` | bool | `false` | このステージでgitタグを作成する |
| `is_final` | bool | `false` | このステージの後にイシューをクローズする |
| `auto_approve` | bool | `false` | 人間の介入なしに自動承認する |

### `workflows.<name>.pipeline.release_strategy` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `type` | string | `"tag"` | 戦略: `"tag"`, `"branch"`, `"label"`, `"milestone"` |
| `branch` | object | - | ブランチ戦略の設定 |
| `label` | object | - | ラベル戦略の設定 |
| `milestone` | object | - | マイルストーン戦略の設定 |
| `auto_create` | object | - | 次のリリース成果物を自動作成 |

### `release_strategy.branch` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"release/{{version}}"` | ブランチ命名パターン |
| `base_branch` | string | `"main"` | 比較対象のブランチ |
| `delete_after_release` | bool | `false` | 本番デプロイ後にブランチを削除 |

### `release_strategy.label` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"release:{{version}}"` | ラベル命名パターン |
| `pending_label` | string | - | リリース割り当て待ちのPR用ラベル |
| `remove_after_release` | bool | `false` | 本番デプロイ後にラベルを削除 |

### `release_strategy.milestone` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `pattern` | string | `"v{{version}}"` | マイルストーン命名パターン |
| `close_after_release` | bool | `false` | 本番デプロイ後にマイルストーンをクローズ |

### `release_strategy.auto_create` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | 最終ステージ完了時に自動作成を有効化 |
| `next_version` | string | `"patch"` | バージョン増分: `"patch"`、`"minor"`、`"major"` |
| `create_issue` | bool | `false` | 次のリリース用の新規承認イシューを作成 |
| `comment` | string | - | 次のリリースについて投稿するコメント |

### `semver` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `prefix` | string | `"v"` | タグのプレフィックス |
| `strategy` | string | `"input"` | バージョン戦略: `"input"`、`"auto"` |
| `validate` | bool | `false` | semver形式を検証 |
| `allow_prerelease` | bool | `false` | プレリリースバージョンを許可（例: `v1.0.0-beta.1`） |
| `auto` | object | - | ラベルベースの自動インクリメント設定 |

### `semver.auto` オプション

| Key | Type | Default | Description |
|-----|------|---------|-------------|
| `major_labels` | string[] | `[]` | メジャーバンプをトリガーするPRラベル |
| `minor_labels` | string[] | `[]` | マイナーバンプをトリガーするPRラベル |
| `patch_labels` | string[] | `[]` | パッチバンプをトリガーするPRラベル |

---

## 機能詳細

### 承認キーワード

ユーザーはイシューにコメントすることでリクエストを承認または拒否できます:

**承認キーワード:** `approve`、`approved`、`lgtm`、`yes`、`/approve`

**拒否キーワード:** `deny`、`denied`、`reject`、`rejected`、`no`、`/deny`

### チームサポート

GitHubのチームベースの承認者を使用するには、昇格された権限が必要です。標準の`GITHUB_TOKEN`ではチームメンバーの一覧を取得できません。GitHub Appトークンを使用してください:

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

**必要なGitHubアプリの権限：**

- `Organization > Members: Read` - チームメンバーを一覧表示するため

### プログレッシブデプロイメントパイプライン

単一の承認イシューで複数の環境へのデプロイを追跡します。各ステージが承認されると、イシューが進捗を表示するように更新され、自動的に次のステージに進みます。

#### パイプライン設定

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

#### パイプラインワークフローの例

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

#### 仕組み

1. **課題作成**：トリガーが発動すると、すべてのステージを示す視覚的なMermaid図と進捗表を含む単一の課題を作成します：

```markdown
## 🚀 デプロイメントパイプライン: v1.2.0

### パイプラインフロー

​```mermaid
flowchart LR
    DEV(⏳ DEV)
    QA(⬜ QA)
    STAGE(⬜ STAGE)
    PROD(⬜ PROD)
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

Mermaidダイアグラムは、色分けされたノードで一目で状況を把握できます：
- 🟢 **緑** - 完了したステージ
- 🟡 **黄** - 承認待ちの現在のステージ
- ⚪ **灰色** - 保留中のステージ
- 🔵 **シアン** - 自動承認ステージ

Mermaidダイアグラムを無効にするには、パイプライン設定で`show_mermaid_diagram: false`を設定します。

2. **ステージの進行**：コメントに`approve`と記入すると次のステージへ進みます。ダイアグラムと表は自動的に更新されます：

```markdown
| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ✅ Deployed | @developer1 | Dec 9 10:30 |
| QA | ✅ Deployed | @qa-lead | Dec 9 14:15 |
| STAGE | ⏳ Awaiting | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** STAGE
```

3. **PRおよびコミット追跡**: リリースマネージャーは何がデプロイされているかを正確に把握できます:

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
4. **完了**: 最終段階が承認されると:
   - タグが作成される（`create_tag: true`の場合）
   - 完了コメントが投稿される
   - イシューが自動的にクローズされる

#### パイプラインステージオプション

| オプション | 説明 |
|------------|------|
| `name` | ステージ名（テーブルに表示） |
| `environment` | GitHub環境名 |
| `policy` | このステージの承認ポリシー |
| `approvers` | インライン承認者（ポリシーの代替） |
| `on_approved` | ステージ承認時に投稿するメッセージ |
| `create_tag` | このステージでgitタグを作成 |
| `is_final` | このステージ後にイシューをクローズ |
| `auto_approve` | 人間の介入なしで自動的にこのステージを承認 |
| `approval_mode` | このステージのワークフロー承認モードを上書き |

#### 承認モード

承認者が承認リクエストとどのようにやり取りするかを選択:

| モード | 説明 |
|--------|------|
| `comments` | （デフォルト）承認者がイシューに`/approve`または`approve`とコメントする |
| `sub_issues` | 各ステージごとにサブイシューを作成 - クローズで承認 |
| `hybrid` | ステージごとにモードを混在させる - 各ステージの`approval_mode`を使用 |

**サブイシュー承認の例:**


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
サブ課題がある場合、親課題には承認されたサブ課題の表が表示されます：


```markdown
### 📋 Approval Sub-Issues

| Stage | Sub-Issue | Status | Assignees |
|-------|-----------|--------|----------|
| DEV | #124 | ⏳ Awaiting | @alice, @bob |
| PROD | #125 | ⏳ Awaiting | @sre1, @sre2 |
```

**ハイブリッドモード（ステージごとのオーバーライド）：**

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

#### 強化されたコメントUX

このアクションには強化されたコメントベースの承認UXが含まれています：

- **絵文字リアクション**：承認コメントに自動リアクション
  - 👍 承認済み
  - 👎 拒否済み
  - 👀 確認済み（処理中）

- **クイックアクションセクション**：Issue本文にコマンド参照表を含む：

```markdown
### ⚡ Quick Actions

| Action | Command | Description |
|--------|---------|-------------|
| ✅ Approve | `/approve` | Approve the **DEV** stage |
| ❌ Deny | `/deny [reason]` | Deny with optional reason |
| 📊 Status | `/status` | Show current approval status |
```

**`comment_settings`を通じて設定：**

```yaml
workflows:
  deploy:
    comment_settings:
      react_to_comments: true     # Add emoji reactions (default: true)
      show_quick_actions: true    # Show Quick Actions section (default: true)
```

#### 低環境向けの自動承認

`auto_approve: true` を、手動の承認なしで自動的に承認されるべきパイプラインステージに使用します。これは、`dev` や `integration` のような低環境で、プロダクションの承認ゲートを維持しつつパイプラインの速度を上げたい場合に最適です。

**自動承認の例：**

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
**仕組み：**

1. パイプラインの問題が作成されると、すべての初期の `auto_approve: true` ステージが自動的に完了します
2. ステージが手動で承認されると、その後に続く連続した `auto_approve: true` ステージも自動的に完了します
3. 自動承認されたステージはパイプライン表で🤖アイコンが表示されます
4. 承認者はステージ履歴に `[auto]` として記録されます

**ユースケース：**

- **開発環境**：承認を待たずに即時デプロイ
- **統合テスト**：テスト環境を通じてCI/CDパイプラインを自動的に進行
- **カナリアデプロイメント**：カナリアステージを自動承認し、完全展開には承認を要求

#### パイプライン設定オプション

| オプション | デフォルト | 説明 |
|------------|------------|------|
| `track_prs` | `false` | マージされたPRを問題本文に含める |
| `track_commits` | `false` | 最後のタグ以降のコミットを含める |
| `compare_from_tag` | - | 比較元のカスタムタグパターン |
| `show_mermaid_diagram` | `true` | パイプラインステージのMermaidフローチャートを表示 |

**注意：** PRトラッキングにはワークフロー内での `pull-requests: read` 権限が必要です。

### リリース候補戦略

エンタープライズ環境では、mainにマージされたPRが必ずしも即リリース候補になるとは限りません。承認エンジンは、どのPRがリリースに属するかを選択するための3つの戦略をサポートしています。

#### 戦略タイプ

| 戦略 | 説明 | ユースケース |
|------|-------|--------------|
| `tag` | 2つのgitタグ間のPR（デフォルト） | シンプルなリリース、トランクベース開発 |
| `branch` | リリースブランチにマージされたPR | GitFlow、リリースブランチ |
| `label` | 特定のリリースラベルが付いたPR | 柔軟な選択、一括リリース |
| `milestone` | GitHubマイルストーンに割り当てられたPR | ロードマップに沿ったリリース |

#### 設定


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

#### ブランチ戦略

GitFlowスタイルの開発にはリリースブランチを使用します：

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

**仕組み:**
1. リリースブランチを作成します: `release/v1.2.0`
2. ブランチにマージされたPRはリリース候補です
3. そのバージョンの承認を依頼します
4. 承認用のIssueにリリースブランチ内のすべてのPRが表示されます
5. 本番適用後、ブランチは削除されます（任意）次のブランチを作成します

#### ラベル戦略

柔軟なPR選択のためにラベルを使用します:

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

**動作の仕組み:**
1. main にマージされたPRに `pending-release` ラベルが付く
2. リリースマネージャーが選択したPRに `release:v1.2.0` を適用する
3. v1.2.0 の承認をリクエストする
4. 承認用のIssueにはそのラベルが付いたPRのみが表示される
5. 本番リリース後、ラベルは削除され、次のリリースラベルが作成される

#### マイルストーン戦略

ロードマップに沿ったリリースにはマイルストーンを使用する:

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

**仕組み:**
1. マイルストーンを作成: "リリース 1.2.0"
2. 開発中にPRをマイルストーンに割り当てる
3. v1.2.0の承認を依頼する
4. 承認用のIssueにマイルストーン内のすべてのPRが表示される
5. 本番後、マイルストーンを閉じて次のマイルストーンを作成する

#### 完了時の自動作成

最終段階（本番）が承認されると、次のリリースの準備を自動的に行う:

```yaml
auto_create:
  enabled: true
  next_version: patch      # Calculate next: patch, minor, or major
  create_issue: true       # Create new approval issue immediately
  comment: |               # Custom message (optional)
    🚀 **Next release prepared:** {{version}}
```
これにより作成されます：
- **ブランチ戦略:** mainから新しいリリースブランチ
- **ラベル戦略:** 新しいリリースラベル
- **マイルストーン戦略:** 新しいマイルストーン

#### クリーンアップオプション

各戦略には、最終段階（prod）が承認されたときに実行されるオプションのクリーンアップアクションがあります。**すべてのクリーンアップオプションはデフォルトで`false`です** - クリーンアップはオプトイン方式です：

| 戦略 | クリーンアップオプション | 説明 |
|----------|----------------|-------------|
| ブランチ | `delete_after_release` | リリースブランチを削除 |
| ラベル | `remove_after_release` | PRからリリースラベルを削除 |
| マイルストーン | `close_after_release` | マイルストーンをクローズ |


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

#### ホットフィックスのデプロイ

通常のリリースワークフローをバイパスする必要がある緊急ホットフィックスの場合は、別のワークフローを作成してください：

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

**トリガーホットフィックス vs 通常リリース:**

```bash
# Regular release - goes through all stages
gh workflow run request-approval.yml -f workflow_name=deploy -f version=v1.3.0

# Hotfix - goes straight to prod
gh workflow run request-approval.yml -f workflow_name=hotfix -f version=v1.2.1
```

**ホットフィックスパターン:**

| シナリオ | 戦略 | クリーンアップ | 自動作成 |
|----------|----------|---------|-------------|
| 緊急修正 | `tag` | なし | 無効 |
| パッチリリース | `milestone` | `close_after_release: false` | 無効 |
| 複数ホットフィックス | `branch` | `delete_after_release: false` | 無効 |

#### リリース戦略の利点

| 戦略 | 長所 | 短所 |
|----------|------|------|
| **Tag** | シンプルで追加ワークフロー不要 | マージ済みPRすべてが含まれる |
| **Branch** | リリース範囲が明確で隔離可能 | ブランチ管理の負荷あり |
| **Label** | 柔軟な選択が可能で変更容易 | 手動でのラベリングが必要 |
| **Milestone** | ロードマップの可視化、計画連携 | マイルストーンの規律が必要 |

**推奨事項:**

- 継続的デプロイのシンプルなプロジェクトには **tag** を使用
- リリースの隔離が必要な規制環境には **branch** を使用
- 柔軟な範囲でのバッチリリースには **label** を使用
- 明確なリリース計画があるロードマップ駆動の開発には **milestone** を使用

### Jira連携

コミットやブランチ名から自動でJira課題を抽出します。アクションは2つのモードをサポートします:

#### リンクのみモード（認証不要）

`jira_base_url` を指定するだけで課題キーを抽出し、クリック可能なリンクとして表示します:

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    jira_base_url: https://yourcompany.atlassian.net  # That's it!
```

これはコミットメッセージやブランチ名から課題キー（例：`PROJ-123`）を抽出し、承認課題にリンクとして表示します：

```markdown
### Jira Issues
- [PROJ-123](https://yourcompany.atlassian.net/browse/PROJ-123)
- [PROJ-456](https://yourcompany.atlassian.net/browse/PROJ-456)
```

#### フルモード（APIアクセスあり）

認証情報を追加して、課題の詳細を取得し、修正バージョンを更新します：

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

これは詳細な問題情報を表示します：

```markdown
### Jira Issues in this Release

| Key | Summary | Type | Status |
|-----|---------|------|--------|
| [PROJ-123](https://...) | Fix login bug | Bug | Done |
| [PROJ-456](https://...) | Add dark mode | Feature | In Progress |
```

**モードの比較：**

| モード | 認証必要 | 機能 |
|--------|-----------|-------|
| リンクのみ | いいえ | クリック可能なリンクとしてキーを発行 |
| フル | はい | リンク＋概要、ステータス、タイプの絵文字、Fix Versionの更新 |

**Jiraの出力：**

```yaml
- name: Use Jira Outputs
  run: |
    echo "Issues: ${{ steps.approval.outputs.jira_issues }}"
    # Output: PROJ-123,PROJ-456

    echo "Details: ${{ steps.approval.outputs.jira_issues_json }}"
    # Output: [{"key":"PROJ-123","summary":"Fix login bug",...}]
```

### デプロイメントトラッキング

GitHubのデプロイメントダッシュボードでの可視性のためにGitHubデプロイメントを作成します。これはワークフロ―YAMLの`environment:`キーとは独立して動作します。

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

**デプロイメントが表示される場所：**

- リポジトリの**Deployments**タブ
- リポジトリページの環境ステータスバッジ
- GitHub for Jira連携（設定されている場合）
- CI/CDツール向けのGitHub API

**注意：** これはGitHubのネイティブなEnvironment Protection Rulesとは別のGitHub Deployments APIを通じてデプロイメントを作成します。両方を併用することも、独立して使用することも可能です。

### 外部設定リポジトリ

承認設定を共有リポジトリに保存し、ポリシー管理を集中化します：

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    token: ${{ secrets.GITHUB_TOKEN }}
    config_repo: myorg/.github  # Shared config repo
```

**設定解決順序：**

1. 外部リポジトリ内の `{repo-name}_approvals.yml`（例：`myapp_approvals.yml`）
2. 外部リポジトリ内の `approvals.yml`（共有デフォルト）
3. 現在のリポジトリ内の `.github/approvals.yml`（ローカルフォールバック）

**組織構造の例：**

```text
myorg/.github/
├── myapp_approvals.yml      # App-specific config
├── backend_approvals.yml    # Backend repos config
└── approvals.yml            # Default for all repos
```

### 承認のブロック

進行前に承認を待つ必要があるワークフローの場合:

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

**注意:** ブロッキングワークフローはランナーをアクティブに保つため、GitHub Actionsの実行時間を消費します。コストを重視する場合は、イベント駆動型アプローチ（別の`process-comment`ワークフロー）を使用してください。

### イシュークローズ時のタグ削除

承認イシューが手動でクローズされたときにタグを削除することができます。

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

**クローズイベントの処理:**

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

### チームサポートによるコメントの処理

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

### マルチ環境プロモーション

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

### 後続ジョブでの出力の使用

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

または CI で検証します:

```yaml
- name: Validate Config
  run: |
    npm install -g ajv-cli
    ajv validate -s schema.json -d .github/approvals.yml
```

---

## GitHub Enterprise Server

このアクションはGitHub Enterprise Serverを完全にサポートしています。`GITHUB_SERVER_URL`および`GITHUB_API_URL`環境変数を使用してGHES環境を自動的に検出します。

追加の設定は不要で、アクションは自動的に正しいAPIエンドポイントを使用します。

**レート制限：**

このアクションにはレート制限エラーに対する指数的バックオフを用いた自動リトライ機能が含まれています。設定内容：

- 初期遅延：1秒
- 最大遅延：60秒
- 最大リトライ回数：5回
- ジッター：雷鳴効果防止のため0〜500msのランダム加算

---

## ライセンス

MITライセンス


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---