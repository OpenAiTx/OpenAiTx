
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# Claude Code スラッシュコマンド

[Claude Code](https://docs.anthropic.com/en/docs/claude-code) 用の本番対応スラッシュコマンドで、インテリジェントな自動化によって開発を加速します。

**52種類のコマンド**は次のように分類されています:
- **🤖 ワークフロー**: 複雑なタスクのためのマルチサブエージェントのオーケストレーション
- **🔧 ツール**: 特定の操作のための単一用途ユーティリティ

### 🤝 Claude Code サブエージェントが必要です

これらのコマンドはオーケストレーション機能のために [Claude Code サブエージェント](https://github.com/wshobson/agents) と連携して動作します。

## インストール

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 利用可能なコマンド

- **🤖 ワークフロー** - 複数のサブエージェントを組み合わせて複雑な作業を実行
- **🔧 ツール** - 特定の操作を行う単一用途のコマンド

## 使用方法

コマンドは `tools/` および `workflows/` ディレクトリに整理されています。ディレクトリのプレフィックスを付けて使用してください。

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**注意:** プレフィックスなしでコマンドを使用したい場合は、ディレクトリをフラット化できます。
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Codeは、コンテキストに基づいて関連するコマンドを自動的に提案します。

## 🤖 ワークフロー

複雑なタスクのためのマルチサブエージェントオーケストレーション：

### 機能開発
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - バックエンド、フロントエンド、テスト、デプロイメントサブエージェントによる完全な機能開発
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 複数のレビューサブエージェントによる包括的なコード解析
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 問題を分析し、適切な専門サブエージェントに委任

### 開発プロセス
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - ブランチ戦略とPRテンプレートによる効果的なGitワークフローの実装
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - プロンプト最適化によるサブエージェントの性能向上
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 専門サブエージェントによるレガシーコードベースの近代化
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - データおよびMLエンジニアリングサブエージェントによるMLパイプライン構築
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 協調型サブエージェントによるクロスプラットフォームアプリ開発
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD、監視、デプロイメントワークフローの自動化

### サブエージェントオーケストレーションワークフロー
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - バックエンド、フロントエンド、モバイルサブエージェントによるマルチプラットフォーム機能
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 専門サブエージェントによるセキュリティ重視の実装
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - データサイエンスサブエージェントによるML機能開発
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - パフォーマンスサブエージェントによるエンドツーエンド最適化
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - オペレーションサブエージェントによる本番インシデント対応

## 🔧 ツール（単一目的コマンド）

### AI & 機械学習
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 本番対応のAIアシスタントやチャットボットの構築
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/MLコードベース向けの専門レビュー
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 最新パターンでLangChain/LangGraphエージェントを作成
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOpsによるエンドツーエンドMLパイプライン構築
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - パフォーマンスと品質のためのAIプロンプト最適化

### アーキテクチャ & コード品質
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 複雑なコードの詳細な説明を生成
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 言語、フレームワーク、バージョン間のコード移行
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 保守性とパフォーマンスのためのコードリファクタリング

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 技術的負債を分析し優先順位を付ける

### データ & データベース
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - スケーラブルなデータパイプラインアーキテクチャの設計
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 包括的なデータバリデーションシステムの実装
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 高度なデータベース移行戦略

### DevOps & インフラストラクチャ
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - デプロイ構成とチェックリストの生成
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 高度なコンテナ最適化戦略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 本番レベルのKubernetesデプロイ
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 包括的な監視および可観測性のセットアップ
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - サービスレベル目標（SLO）の実装
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 開発および運用ワークフローの自動化

### 開発 & テスト
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 開発・テスト用のリアルなAPIモックの作成
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 本番対応APIエンドポイントと実装スタックの生成
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - フレームワーク検出付きの包括的なテストスイートの作成

### セキュリティ & コンプライアンス
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 包括的なアクセシビリティテストと修正
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 規制遵守（GDPR、HIPAA、SOC2）の確保
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 包括的なセキュリティスキャンと自動修復

### デバッグ & 分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 高度なデバッグおよびトレース戦略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - エラーパターンの深い分析と解決戦略
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 本番エラーのトレースと診断
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 構造化されたGitHub/GitLabイシューの作成

### 依存関係 & 設定
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - アプリケーション設定の検証と管理
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - セキュリティとライセンスのための依存関係監査
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - プロジェクト依存関係の安全なアップグレード

### ドキュメント & コラボレーション
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 包括的なドキュメントの生成
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 効果的なGitワークフローの実装
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 品質チェックによるプルリクエストの強化

### コスト最適化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - クラウドおよびインフラコストの最適化

### オンボーディングとセットアップ
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 新しいチームメンバーのための開発環境のセットアップ

### サブエージェントツール
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 専門サブエージェントによる多角的コードレビュー
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - デバッガーおよびパフォーマンスサブエージェントによる高度なデバッグ
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 複数サブエージェントによるフルスタック最適化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - コンテキストマネージャーサブエージェントによるプロジェクトコンテキストの保存
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 継続性のために保存したコンテキストの復元

## 特徴

- 本番対応実装
- フレームワーク自動検出
- セキュリティのベストプラクティス
- 組み込みの監視とテスト
- コマンド同士のシームレスな連携

## コマンド数

**合計: 52 本番対応スラッシュコマンド** が以下に分類されています:

### 🤖 ワークフロー（14コマンド）

- 機能開発とレビュー（3コマンド） 
- 開発プロセス自動化（6コマンド）
- サブエージェント指揮型ワークフロー（5コマンド）

### 🔧 ツール（38コマンド）

- AI & 機械学習（5コマンド）
- アーキテクチャ & コード品質（4コマンド）
- データ & データベース（3コマンド）
- DevOps & インフラ（6コマンド）
- 開発 & テスト（3コマンド）
- セキュリティ & コンプライアンス（3コマンド）
- デバッグと解析（4コマンド）
- 依存関係と構成（3コマンド）
- ドキュメントとコラボレーション（1コマンド）
- オンボーディングとセットアップ（1コマンド）
- サブエージェント専用ツール（5コマンド）

## 使用例

### 🤖 ワークフロー例

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

### 🔧 ツール例（単一目的コマンド）

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

## 強化コマンド

### セキュリティ & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

自動修復付きの包括的なセキュリティスキャン。

- **マルチツールスキャン**: Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自動修復**: 一般的な脆弱性の自動修正
- **CI/CD統合**: GitHub Actions/GitLab CI用セキュリティゲート
- **コンテナスキャン**: イメージの脆弱性分析
- **シークレット検出**: GitLeaksとTruffleHogの統合

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

高度なコンテナ最適化戦略。

- **スマート最適化**: 分析して改善案を提案
- **マルチステージビルド**: フレームワーク別最適化Dockerfile
- **最新ツール**: BuildKit、Bun、UVによる高速ビルド
- **セキュリティ強化**: Distrolessイメージ、非rootユーザー
- **クロスコマンド統合**: /api-scaffoldの出力と連携

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

本番対応のKubernetesデプロイ。

- **高度なパターン**: Podセキュリティ基準、ネットワークポリシー、OPA
- **GitOps対応**: FluxCDとArgoCDの設定
- **可観測性**: Prometheus ServiceMonitors、OpenTelemetry
- **自動スケーリング**: HPA、VPA、クラスターオートスケーラー設定
- **サービスメッシュ**: Istio/Linkerd連携

### フロントエンド & データ

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

高度なデータベース移行戦略。

- **マルチデータベース**: PostgreSQL、MySQL、MongoDB、DynamoDB
- **ゼロダウンタイム**: ブルーグリーンデプロイメント、ローリングマイグレーション
- **イベントソーシング**: Kafka/KinesisによるCDC統合
- **クロスプラットフォーム**: ポリグロット永続性の対応
- **モニタリング**: マイグレーションのヘルスチェックとロールバック

## ワークフローとツールの組み合わせ

真の強みは、ワークフローとツールを組み合わせて開発サイクル全体を実現することです。

### 例: 新機能の構築

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

### 例：レガシーコードのモダナイゼーション

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

## コマンドオーケストレーションパターン

コマンドは個別に使用することも、強力なパターンで組み合わせることもできます：

### 順次実行
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### 並列解析
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 反復的な改良
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### クロスドメイン統合
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## ワークフローとツールの使い分け

### 🔀 ワークフロー & サブエージェントツール
- **問題解決**：状況に応じて課題を分析・修正
- **多角的視点**：専門サブエージェントの連携
- **複雑なタスク**：複数分野にまたがる多段階プロセス
- **解決策が不明**：サブエージェントにアプローチを決定させる

### 🛠️ 専門ツール
- **インフラ構築**：環境の設定
- **コード生成**：具体的な実装の作成
- **分析**：修正なしのレポート生成
- **ドメインタスク**：高度に専門化された操作

**例:**
- 「ユーザー認証システムを実装」→ `/workflows:feature-development`
- 「スタック全体のパフォーマンス問題を修正」→ `/workflows:smart-fix`
- 「レガシーモノリスを近代化」→ `/workflows:legacy-modernize`

### 🔧 ツールを使う場面:
- **特定分野の専門性が必要** - 一分野で明確かつ集中的なタスク
- **詳細な制御が求められる** - 実装の細部まで指示したい場合
- **手作業のワークフローの一部** - 既存プロセスへの統合
- **高度な専門化が必要** - エキスパートレベルの実装が必要な場合
- **既存成果物を基盤に作業** - 以前のアウトプットの強化や改良

**例:**
- 「Kubernetesマニフェストを作成」→ `/tools:k8s-manifest`
- 「セキュリティ脆弱性をスキャン」→ `/tools:security-scan`
- 「APIドキュメントを生成」→ `/tools:doc-generate`

## コマンド形式

スラッシュコマンドはシンプルなMarkdownファイルで構成されます:
- ファイル名がコマンド名となる（例: `tools/api-scaffold.md` → `/tools:api-scaffold`）
- ファイル内容が実行時のプロンプト・指示となる
- ユーザー入力は `$ARGUMENTS` プレースホルダーを使用

## ベストプラクティス

### コマンド選択
- **Claude Codeによる自動提案** - コンテキストを分析し最適なコマンドを選択
- **複雑なタスクにはワークフローを使用** - サブエージェントが複数分野の実装を調整
- **特化したタスクにはツールを使用** - 特定コマンドでターゲットを絞った改善を実施

### 効果的な利用方法
- **包括的なコンテキストを提供** - 技術スタック、制約、要件を含める
- **コマンドを戦略的に連携** - ワークフロー → ツール → 改良
- **前回の出力を活用** - コマンドは連携して動作するよう設計

## 貢献方法

1. `workflows/` または `tools/` に `.md` ファイルを作成
2. 小文字+ハイフンの名前を使用
3. ユーザー入力用に `$ARGUMENTS` を含める

## トラブルシューティング

**コマンドが見つからない場合**: 
- ファイルが `~/.claude/commands/tools/` または `~/.claude/commands/workflows/` にあるか確認
- 正しいプレフィックスを使用: `/tools:command-name` または `/workflows:command-name`
- またはディレクトリをフラット化したい場合: `cp tools/*.md . && cp workflows/*.md .`

**ワークフローが遅い**: 通常です - 複数サブエージェントを調整しています

**一般的な出力**: 技術スタックについてより具体的なコンテキストを追加してください

**統合の問題**: ファイルパスとコマンド順序を確認

## パフォーマンス向上のヒント

**コマンド選択:**
- **ワークフロー**: 複数サブエージェントによる複雑な機能の調整
- **ツール**: 特定作業向けの単機能オペレーション
- **簡単な編集**: メインエージェントのみで作業

**最適化:**
- 既知の問題にはツールから始める
- 詳細な要件を最初に提示
- 前回のコマンド出力を基盤に構築する
- 修正を加える前にワークフローを完了させる

### 新しいワークフローの追加:
- サブエージェントのオーケストレーションと委任ロジックに注力する
- 使用する専門サブエージェントとその順序を指定する
- サブエージェント間の調整パターンを定義する

### 新しいツールの追加:
- 完全で本番環境対応の実装を含める
- コンテンツを明確なセクションと実行可能な出力で構成する
- 例、ベストプラクティス、統合ポイントを含める

## 詳細情報

- [Claude Code ドキュメント](https://docs.anthropic.com/en/docs/claude-code)
- [スラッシュコマンド ドキュメント](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [サブエージェント ドキュメント](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code サブエージェント コレクション](https://github.com/wshobson/agents) - これらのコマンドで使用される専門サブエージェント


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---