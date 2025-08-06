# Claude Code スラッシュコマンド

インテリジェントな自動化によって開発を加速する、[Claude Code](https://docs.anthropic.com/en/docs/claude-code)向けの本番対応スラッシュコマンド。

**52個のコマンド**が以下のように整理されています：
- **🤖 ワークフロー**：複雑なタスクのためのマルチサブエージェントオーケストレーション
- **🔧 ツール**：特定の操作に特化したユーティリティ

### 🤝 Claude Code サブエージェントが必要

これらのコマンドは、オーケストレーション機能のために[Claude Code サブエージェント](https://github.com/wshobson/agents)と連携します。

## インストール

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 利用可能なコマンド

- **🤖 ワークフロー** - 複雑なタスクのために複数のサブエージェントを調整
- **🔧 ツール** - 特定の操作のための単一目的コマンド

## 使用方法

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Codeは、コンテキストに基づいて関連するコマンドを自動的に提案します。

## 🤖 ワークフロー

複雑なタスクのためのマルチサブエージェントオーケストレーション：

### 機能開発
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - バックエンド、フロントエンド、テスト、デプロイメントのサブエージェントが完全な機能を構築
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 複数のレビューサブエージェントが包括的なコード分析を提供
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 問題を分析し、適切な専門サブエージェントに委任

### 開発プロセス
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - ブランチ戦略とPRテンプレートを用いた効果的なGitワークフローを実装
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - プロンプト最適化を通じてサブエージェントの性能向上
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 専門サブエージェントを使ってレガシーコードベースをモダナイズ
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - データおよびMLエンジニアリングのサブエージェントと共にMLパイプラインを作成
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 調整されたサブエージェントでクロスプラットフォームアプリを構築
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD、監視、デプロイメントワークフローを自動化

### サブエージェント主導ワークフロー
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - バックエンド、フロントエンド、モバイルのサブエージェントによるマルチプラットフォーム機能
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 専門サブエージェントでのセキュリティファースト実装
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - データサイエンスサブエージェントによるML駆動機能
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - パフォーマンスサブエージェントによるエンドツーエンドの最適化
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 運用サブエージェントによる本番インシデント対応

## 🔧 ツール（単機能コマンド）

### AI & 機械学習
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 本番対応のAIアシスタントとチャットボットを構築
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/MLコードベースに特化したレビュー
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - モダンパターンでLangChain/LangGraphエージェントを作成
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOpsでエンドツーエンドのMLパイプラインを作成
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - パフォーマンスと品質のためにAIプロンプトを最適化

### アーキテクチャ & コード品質
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 複雑なコードの詳細な説明を生成
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 言語、フレームワーク、バージョン間のコード移行
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 保守性とパフォーマンスのためにコードをリファクタリング
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 技術的負債を分析し優先順位を設定

### データ & データベース
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - スケーラブルなデータパイプラインアーキテクチャを設計
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 包括的なデータ検証システムを実装
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 高度なデータベース移行戦略

### DevOps & インフラストラクチャ
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - デプロイメント設定とチェックリストを生成
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 高度なコンテナ最適化戦略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 本番グレードのKubernetesデプロイメント
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 包括的な監視と可観測性を設定
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - サービスレベル目標（SLO）を実装
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 開発および運用ワークフローを自動化

### 開発 & テスト
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 開発とテストのためのリアルなAPIモックを作成
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 完全な実装スタックで本番対応APIエンドポイントを生成
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - フレームワーク検出による包括的なテストスイートを作成

### セキュリティ & コンプライアンス
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 包括的なアクセシビリティテストと修正
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 規制遵守（GDPR、HIPAA、SOC2）を確保
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 自動修復機能付きの包括的なセキュリティスキャン

### デバッグ & 分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 高度なデバッグおよびトレース戦略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 深いエラーパターン分析と解決策
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 本番エラーのトレースと診断
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 体系的なGitHub/GitLabイシューを作成

### 依存関係 & 設定
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - アプリケーション設定の検証と管理
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - セキュリティとライセンスのために依存関係を監査
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - プロジェクト依存関係を安全にアップグレード

### ドキュメント & コラボレーション
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 包括的なドキュメントを生成
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 効果的なGitワークフローを実装
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 品質チェックでプルリクエストを強化

### コスト最適化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - クラウドおよびインフラコストを最適化

### オンボーディング & セットアップ
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 新規チームメンバーの開発環境をセットアップ

### サブエージェントツール
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 専門サブエージェントによる多角的コードレビュー
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - デバッガーおよびパフォーマンスサブエージェントによる深いデバッグ
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 複数サブエージェントによるフルスタック最適化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - context-managerサブエージェントを使ってプロジェクトコンテキストを保存
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 継続性のために保存したコンテキストを復元

## 特徴

- 本番対応の実装
- フレームワーク自動検出
- セキュリティのベストプラクティス
- 組み込みの監視とテスト

- コマンドがシームレスに連携

## コマンド数

**合計：52の本番対応スラッシュコマンド** が以下に分類されます：

### 🤖 ワークフロー（14コマンド）

- 機能開発＆レビュー（3コマンド） 
- 開発プロセスの自動化（6コマンド）
- サブエージェント主導のワークフロー（5コマンド）

### 🔧 ツール（38コマンド）

- AI＆機械学習（5コマンド）
- アーキテクチャ＆コード品質（4コマンド）
- データ＆データベース（3コマンド）
- DevOps＆インフラ（6コマンド）
- 開発＆テスト（3コマンド）
- セキュリティ＆コンプライアンス（3コマンド）
- デバッグ＆解析（4コマンド）
- 依存関係＆設定（3コマンド）
- ドキュメント＆コラボレーション（1コマンド）
- オンボーディング＆セットアップ（1コマンド）
- サブエージェント専用ツール（5コマンド）

## 使用例

### 🤖 ワークフロー例

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

### 🔧 ツール例（単一目的コマンド）

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
## 強化されたコマンド

### セキュリティ＆DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

包括的なセキュリティスキャンと自動修復。

- **マルチツールスキャン**: Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自動修正**: 一般的な脆弱性の自動修復
- **CI/CD統合**: GitHub Actions/GitLab CIのセキュリティゲート
- **コンテナスキャン**: イメージの脆弱性分析
- **シークレット検出**: GitLeaksとTruffleHogの統合

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

高度なコンテナ最適化戦略。

- **スマート最適化**: 分析と改善提案
- **マルチステージビルド**: フレームワーク別最適化Dockerfile
- **最新ツール**: BuildKit、Bun、UVによる高速ビルド
- **セキュリティ強化**: Distrolessイメージ、非rootユーザー
- **コマンド間連携**: /api-scaffold出力と連携

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

本番対応のKubernetesデプロイ。

- **高度なパターン**: Podセキュリティ標準、ネットワークポリシー、OPA
- **GitOps対応**: FluxCDおよびArgoCD設定
- **可観測性**: Prometheus ServiceMonitors、OpenTelemetry
- **自動スケーリング**: HPA、VPA、クラスタオートスケーラー設定
- **サービスメッシュ**: Istio/Linkerd統合

### フロントエンド＆データ

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

高度なデータベースマイグレーション戦略。

- **マルチデータベース**: PostgreSQL、MySQL、MongoDB、DynamoDB
- **ゼロダウンタイム**: ブルーグリーンデプロイ、ローリングマイグレーション
- **イベントソーシング**: Kafka/KinesisによるCDC連携
- **クロスプラットフォーム**: ポリグロット永続化対応
- **監視**: マイグレーションのヘルスチェックとロールバック

## ワークフローとツールの組み合わせ

真の力はワークフローとツールを組み合わせて完全な開発サイクルを実現することにあります：

### 例: 新機能の構築


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

### 例：レガシーコードのモダナイゼーション

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

## コマンドオーケストレーションパターン

コマンドは個別に使用することも、強力なパターンで組み合わせることもできます：

### 順次実行
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### 並列解析
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 反復的な改良
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### クロスドメイン統合
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## ワークフローとツールの使い分け

### 🔀 ワークフロー＆サブエージェントツール
- **問題解決**：適応的に問題を分析し修正する
- **複数視点**：専門サブエージェントを調整する
- **複雑なタスク**：複数ドメインにまたがる多段階プロセス
- **未知の解決策**：サブエージェントにアプローチを決定させる

### 🛠️ 専門ツール
- **インフラ構築**：環境の設定
- **コード生成**：特定の実装を作成
- **分析**：修正なしでレポートを生成
- **ドメイン作業**：高度に専門的な操作

**例：**
- 「ユーザー認証システムを実装」 → `/feature-development`
- 「スタック全体のパフォーマンス問題を修正」 → `/smart-fix`
- 「レガシーモノリスをモダナイズ」 → `/legacy-modernize`

### 🔧 ツールを使う場合：
- **特定の専門知識が必要** - １つのドメインに明確で集中したタスク
- **正確な制御が欲しい** - 実装の詳細を指示したい場合
- **手動ワークフローの一部** - 既存プロセスへの統合
- **深い専門性が必要** - 専門家レベルの実装が求められる
- **既存作業の拡張** - 以前の成果物を強化・改良する

**例：**
- 「Kubernetesマニフェストを作成」 → `/k8s-manifest`
- 「セキュリティ脆弱性をスキャン」 → `/security-scan`
- 「APIドキュメントを生成」 → `/doc-generate`

## コマンド形式

スラッシュコマンドはシンプルなマークダウンファイルで：
- ファイル名がコマンド名になる（例：`api-scaffold.md` → `/api-scaffold`）
- ファイル内容が呼び出し時に実行されるプロンプト／指示
- ユーザー入力には `$ARGUMENTS` プレースホルダを使用

## ベストプラクティス

### コマンド選択
- **Claude Codeに自動提案させる** - コンテキストを分析し最適コマンドを選択
- **複雑なタスクはワークフローを使う** - サブエージェントが多ドメイン実装を調整
- **集中的なタスクはツールを使う** - 特定の改善に特化したコマンドを適用

### 効果的な使い方
- **包括的なコンテキストを提供** - 技術スタック、制約、要件を含める
- **コマンドを戦略的に連鎖させる** - ワークフロー → ツール → 改良
- **以前の成果物を活用** - コマンドは連携して動作する設計

## 貢献方法

1. `workflows/` または `tools/` に `.md` ファイルを作成
2. 小文字ハイフン区切りの名前を使う
3. ユーザー入力用に `$ARGUMENTS` を含める

## トラブルシューティング

**コマンドが見つからない**：`~/.claude/commands/` にファイルがあるか確認

**ワークフローが遅い**：複数サブエージェントを調整しているため通常

**出力が一般的すぎる**：技術スタックなど具体的なコンテキストを追加

**統合問題**：ファイルパスやコマンドの順序を検証

## パフォーマンス向上のコツ

**コマンド選択：**
- **ワークフロー**：複雑機能の複数サブエージェント調整
- **ツール**：特定タスクの単一目的操作
- **簡単な編集**：メインエージェントで対応

**最適化：**
- 既知問題はツールから開始
- 詳細な要件を最初に提供
- 以前のコマンド結果を活用
- ワークフローが完了するまで修正を控える

### 新しいワークフロー追加時：
- サブエージェントの調整と委任ロジックに注力
- どの専門サブエージェントをどの順で使うか指定
- サブエージェント間の調整パターンを定義

### 新しいツール追加時：
- 完全で本番対応の実装を含める
- 明確なセクションと実行可能な出力で構成
- 例、ベストプラクティス、統合ポイントを含める

## 詳しく知る

- [Claude Code ドキュメント](https://docs.anthropic.com/en/docs/claude-code)
- [スラッシュコマンド ドキュメント](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [サブエージェント ドキュメント](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code サブエージェントコレクション](https://github.com/wshobson/agents) - これらのコマンドで使われる専門サブエージェント



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---