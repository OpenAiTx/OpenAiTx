<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# Claude Code サブエージェントコレクション

[Claude Code](https://docs.anthropic.com/en/docs/claude-code)向けの専門AIサブエージェントを網羅的に収集し、領域特化の専門知識で開発ワークフローを強化します。

## 概要

このリポジトリには、Claude Codeの機能を拡張するための61個の専門サブエージェントが含まれています。各サブエージェントは特定分野のエキスパートであり、文脈に応じて自動的に呼び出されるか、必要に応じて明示的に呼び出すことができます。すべてのエージェントは、タスクの複雑さに応じて最適な性能とコスト効率を実現するために、特定のClaudeモデルで構成されています。

## 利用可能なサブエージェント

### 開発とアーキテクチャ
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - RESTful API、マイクロサービス境界、データベーススキーマの設計
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Reactコンポーネントの構築、レスポンシブレイアウトの実装、クライアントサイドの状態管理
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - インターフェースデザイン、ワイヤーフレーム、デザインシステムの作成
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - React NativeまたはFlutterアプリの開発とネイティブ統合
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - GraphQLスキーマ、リゾルバ、フェデレーションの設計
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - アーキテクチャの一貫性とパターンのためのコード変更レビュー

### 言語スペシャリスト
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - 高度な機能と最適化を備えた慣用的なPythonコードの記述
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - メタプログラミング、Railsパターン、gem開発、テストフレームワークを含む慣用的なRubyコードの記述
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - ゴルーチン、チャネル、インターフェースを使った慣用的なGoコードの記述
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - 所有権パターン、ライフタイム、トレイト実装を用いた慣用的なRustコード
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - 適切なメモリ管理とシステムコールによる効率的なCコードの記述
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - 最新機能、RAII、スマートポインタ、STLアルゴリズムを用いた慣用的なC++コード
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - ES6+、非同期パターン、Node.js APIを駆使した最新JavaScriptの習得
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - 高度な型、ジェネリクス、厳密な型安全性を備えたTypeScriptの習得
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - 最新機能とパフォーマンス最適化を用いた慣用的なPHPコードの記述
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - ストリーム、並行処理、JVM最適化による最新Javaの習得
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - OTPパターン、関数型プログラミング、Phoenixフレームワークによる慣用的なElixirコード
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - 高度な機能と.NET最適化による最新C#コードの記述
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - 関数型プログラミング、分散システム、ビッグデータ処理によるエンタープライズ向けScala開発の習得
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Dart、ウィジェット、プラットフォーム統合によるFlutter開発の習得
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - 最適化されたスクリプトとパフォーマンスチューニングによるUnityゲームの構築
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Bukkit、Spigot、Paper APIによるMinecraftサーバープラグイン開発の習得
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Swift/SwiftUIによるネイティブiOSアプリケーションの開発
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - 複雑なSQLクエリの記述、実行計画の最適化、正規化スキーマの設計

### インフラと運用
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - 本番環境の問題のデバッグ、ログ解析、デプロイ失敗の修正
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - CI/CDパイプライン、Dockerコンテナ、クラウドデプロイの構成
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - AWS/Azure/GCPインフラの設計とクラウドコストの最適化
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - SQLクエリの最適化、効率的なインデックス設計、データベース移行の対応
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - データベース運用、バックアップ、レプリケーション、監視の管理
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - 高度なTerraformモジュールの記述、ステートファイル管理、IaCのベストプラクティス実装
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - 本番インシデントを迅速かつ正確に対応
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - ネットワーク接続のデバッグ、ロードバランサの構成、トラフィックパターンの分析
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - ツール、セットアップ、ワークフローの改善を行う開発者体験スペシャリスト

### 品質とセキュリティ
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - 深い構成セキュリティと本番信頼性に重点を置いた専門的なコードレビュー
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - 脆弱性のためのコードレビューとOWASP準拠の確認
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - 単体・統合・e2eテストによる包括的なテストスイート作成
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - アプリケーションのプロファイリング、ボトルネック最適化、キャッシュ戦略の実装
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - エラー、テスト失敗、予期せぬ挙動のデバッグスペシャリスト
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ログやコードベースからエラーパターン、スタックトレース、異常を検索
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - 高度な検索技術と統合でウェブリサーチの専門家

### データ & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - SQLクエリ、BigQuery操作、データインサイトの専門家
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - ETLパイプライン、データウェアハウス、ストリーミングアーキテクチャの構築
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - LLMアプリ、RAGシステム、プロンプトパイプラインの構築
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - MLパイプライン、モデルサービング、特徴量エンジニアリングの実装
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - MLパイプライン、実験管理、モデルレジストリの構築
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - LLMやAIシステム用プロンプトの最適化

### 専門分野
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - OpenAPI/Swagger仕様の作成と開発者ドキュメントの執筆
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Stripe、PayPalなど決済プロセッサの統合
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - 金融モデルの構築、トレード戦略のバックテスト、市場データの分析
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - ポートフォリオリスク、Rマルチプル、ポジション制限の監視
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - レガシーコードのリファクタリングと段階的なモダナイズ
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - 複数エージェントや長時間タスク間のコンテキスト管理

### ドキュメンテーション
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - 既存コードベースから包括的な技術ドキュメントを作成
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - フローチャート、シーケンス、ERD、アーキテクチャ用のMermaid図作成
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - 網羅的な技術リファレンス・APIドキュメントの作成
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - コードからステップバイステップのチュートリアル・教育コンテンツ作成

### ビジネス & マーケティング
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - 指標の分析、レポート作成、KPIの追跡
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - ブログ記事、SNSコンテンツ、メールニュースレター執筆
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - コールドメール、フォローアップ、提案テンプレートの作成
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - サポートチケット、FAQ対応、顧客メールの処理
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - プライバシーポリシー、利用規約、免責事項、法的通知の作成

## モデル割り当て

全59のサブエージェントは、タスクの複雑さに応じて特定のClaudeモデルで構成されています。

### 🚀 Haiku（高速・コスト効率重視） - 9エージェント
**モデル:** `haiku`
- `data-scientist` - SQLクエリとデータ分析
- `api-documenter` - OpenAPI/Swaggerドキュメント
- `reference-builder` - 詳細な技術リファレンスとAPIドキュメント
- `business-analyst` - 指標とKPIの追跡
- `content-marketer` - ブログ投稿とソーシャルメディア
- `customer-support` - サポートチケットとFAQ
- `sales-automator` - コールドメールと提案書
- `search-specialist` - ウェブリサーチと情報収集
- `legal-advisor` - プライバシーポリシーおよびコンプライアンス文書

### ⚡ Sonnet（バランス型パフォーマンス） - 37エージェント
**モデル:** `sonnet`

**開発＆言語:**
- `python-pro` - 高度な機能を備えたPython開発
- `ruby-pro` - メタプログラミング、Railsパターン、gem開発を含むRuby開発
- `javascript-pro` - 最新のJavaScriptおよびNode.js
- `typescript-pro` - 型システムを活用した高度なTypeScript
- `golang-pro` - Goの並行処理およびイディオマティックパターン
- `rust-pro` - Rustのメモリ安全性とシステムプログラミング
- `c-pro` - Cプログラミングと組み込みシステム
- `cpp-pro` - STLやテンプレートを活用した最新C++
- `php-pro` - 高度な機能を持つ最新PHP
- `java-pro` - ストリームと並行処理を備えた最新Java
- `elixir-pro` - OTPパターンやPhoenixを用いたElixir
- `csharp-pro` - .NETフレームワークやパターンを活用した最新C#
- `scala-pro` - Apache Pekko、Akka、Spark、ZIO/Cats Effectを備えたエンタープライズScala
- `flutter-expert` - 状態管理やアニメーションを含むFlutter開発
- `unity-developer` - Unityゲーム開発と最適化
- `minecraft-bukkit-pro` - Bukkit/Spigot/PaperによるMinecraftプラグイン開発
- `ios-developer` - Swift/SwiftUIによるネイティブiOS開発
- `frontend-developer` - ReactコンポーネントとUI
- `ui-ux-designer` - インターフェース設計とワイヤーフレーム
- `backend-architect` - API設計とマイクロサービス
- `mobile-developer` - React Native/Flutterアプリ
- `sql-pro` - 複雑なSQL最適化
- `graphql-architect` - GraphQL スキーマとリゾルバー

**インフラストラクチャ & 運用:**
- `devops-troubleshooter` - 本番デバッグ
- `deployment-engineer` - CI/CD パイプライン
- `database-optimizer` - クエリ最適化
- `database-admin` - データベース運用
- `terraform-specialist` - Infrastructure as Code
- `network-engineer` - ネットワーク構成
- `dx-optimizer` - 開発者体験
- `data-engineer` - ETL パイプライン

**品質 & サポート:**
- `test-automator` - テストスイート作成
- `code-reviewer` - コード品質分析
- `debugger` - エラー調査
- `error-detective` - ログ分析
- `ml-engineer` - ML モデルデプロイ
- `legacy-modernizer` - フレームワーク移行
- `payment-integration` - 決済処理
- `mermaid-expert` - Mermaid ダイアグラムとビジュアルドキュメント
- `flutter-expert` - Flutter 開発

### 🧠 Opus（最大能力） - 13 エージェント
**モデル:** `opus`
- `ai-engineer` - LLM アプリケーションと RAG システム
- `security-auditor` - 脆弱性分析
- `performance-engineer` - アプリケーション最適化
- `incident-responder` - 本番インシデント対応
- `mlops-engineer` - ML インフラストラクチャ
- `architect-reviewer` - アーキテクチャ一貫性
- `cloud-architect` - クラウドインフラ設計
- `prompt-engineer` - LLM プロンプト最適化
- `context-manager` - マルチエージェント協調
- `quant-analyst` - 金融モデリング
- `risk-manager` - ポートフォリオリスク管理
- `docs-architect` - コードベースからの包括的技術ドキュメント
- `tutorial-engineer` - ステップバイステップのチュートリアルと教育コンテンツ

## インストール
これらのサブエージェントは、`~/.claude/agents/` ディレクトリに配置すると自動的に利用可能になります。


```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## 使用方法

### 自動呼び出し
Claude Codeは、タスクのコンテキストとサブエージェントの説明に基づいて、適切なサブエージェントに自動的に委任します。

### 明示的な呼び出し
リクエスト内でサブエージェントの名前を明記してください：
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## 使用例

### 単一エージェントタスク
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

### マルチエージェントワークフロー

これらのサブエージェントはシームレスに連携し、より複雑なオーケストレーションには、これらのサブエージェントを高度なワークフローで活用する52の事前構築済みスラッシュコマンドを提供する**[Claude Code Commands](https://github.com/wshobson/commands)**コレクションを使用できます。

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

### スラッシュコマンドを用いた高度なワークフロー

より高度なマルチサブエージェントのオーケストレーションには、付属の[Commandsリポジトリ](https://github.com/wshobson/commands)を使用してください：

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

## サブエージェント形式

各サブエージェントはこの構造に従います：
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```
### モデル構成

Claude Code v1.0.64以降、サブエージェントは使用するClaudeモデルを指定できます。これにより、タスクの複雑さに応じたコスト効率の良いタスク委譲が可能になります：

- **低複雑度（Haiku）**：基本的なデータ分析、ドキュメント生成、標準的な応答などの簡単なタスク
- **中複雑度（Sonnet）**：開発作業、コードレビュー、テスト、一般的なエンジニアリング作業  
- **高複雑度（Opus）**：セキュリティ監査、アーキテクチャレビュー、インシデント対応、AI/MLエンジニアリングなどの重要なタスク

利用可能なモデル（Claude Code v1.0.64時点の簡略名称）：
- `haiku` - 簡単なタスクに対して高速かつコスト効率が良い
- `sonnet` - ほとんどの開発作業に対してバランスの取れた性能
- `opus` - 複雑な分析や重要タスクに最も適したモデル

モデルが指定されていない場合、サブエージェントはシステムのデフォルトモデルを使用します。

## エージェントオーケストレーションパターン

Claude Codeはこれらの一般的なパターンを使って自動的にエージェントを調整します：

### 逐次ワークフロー

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

### 条件分岐
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### レビューと検証
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```

## どのエージェントをいつ使うべきか

### 🏗️ 計画・アーキテクチャ
- **backend-architect**: API設計、データベーススキーマ、システムアーキテクチャ
- **frontend-developer**: UI/UX計画、コンポーネントアーキテクチャ
- **ui-ux-designer**: インターフェース設計、ワイヤーフレーム、デザインシステム、ユーザーリサーチ
- **cloud-architect**: インフラ設計、スケーラビリティ計画

### 🔧 実装・開発  
- **python-pro**: Python特有の開発タスク
- **ruby-pro**: Rubyメタプログラミング、Railsアプリケーション、gem開発、RSpec/Minitestテスト
- **golang-pro**: Go特有の開発タスク
- **rust-pro**: Rust開発、メモリ安全性、システムプログラミング
- **c-pro**: Cプログラミング、組み込みシステム、パフォーマンス重視コード
- **javascript-pro**: 最新JavaScript、非同期パターン、Node.js/ブラウザーコード
- **typescript-pro**: 高度なTypeScript、ジェネリクス、型推論、エンタープライズパターン
- **java-pro**: 最新Java開発、ストリーム、並行処理、Spring Boot
- **elixir-pro**: Elixir開発、OTPパターン、Phoenixフレームワーク、関数型プログラミング
- **csharp-pro**: 最新C#開発、.NETフレームワーク、エンタープライズパターン
- **scala-pro**: エンタープライズScala、関数型プログラミング、Apache Pekko/Akkaアクター、Apache Spark、ZIO/Cats Effect、リアクティブアーキテクチャ
- **flutter-expert**: Flutter開発、Dart、状態管理、アニメーション、クロスプラットフォーム展開
- **unity-developer**: Unityゲーム開発、C#スクリプト、パフォーマンス最適化
- **minecraft-bukkit-pro**: Minecraftプラグイン開発、イベントシステム、サーバー側機能
- **ios-developer**: Swift/SwiftUIによるネイティブiOS開発
- **sql-pro**: データベースクエリ、スキーマ設計、クエリ最適化
- **mobile-developer**: React Native/Flutter開発

### 🛠️ 運用・保守
- **devops-troubleshooter**: 本番環境の問題、デプロイ障害
- **incident-responder**: 緊急障害への即時対応
- **database-optimizer**: クエリパフォーマンス、インデックス戦略
- **database-admin**: バックアップ戦略、レプリケーション、ユーザー管理、災害復旧
- **terraform-specialist**: インフラ構成管理、Terraformモジュール、ステート管理
- **network-engineer**: ネットワーク接続、ロードバランサー、SSL/TLS、DNSデバッグ

### 📊 分析・最適化
- **performance-engineer**: アプリケーションのボトルネック、最適化
- **security-auditor**: 脆弱性スキャン、コンプライアンスチェック
- **data-scientist**: データ分析、インサイト、レポーティング
- **mlops-engineer**: MLインフラ、実験トラッキング、モデルレジストリ、パイプライン自動化

### 🧪 品質保証
- **code-reviewer**: コード品質、構成のセキュリティ、運用信頼性
- **test-automator**: テスト戦略、テストスイート作成
- **debugger**: バグ調査、エラー解決
- **error-detective**: ログ分析、エラーパターン認識、根本原因分析
- **search-specialist**: ディープウェブリサーチ、競合分析、事実確認

### 📚 ドキュメント
- **api-documenter**: OpenAPI/Swagger仕様、APIドキュメント
- **docs-architect**: 包括的な技術文書、アーキテクチャガイド、システムマニュアル
- **reference-builder**: 網羅的なAPIリファレンス、構成ガイド、パラメータ文書
- **tutorial-engineer**: ステップバイステップのチュートリアル、学習パス、教育コンテンツ

### 💼 ビジネス＆戦略
- **business-analyst**: KPI、収益モデル、成長予測、投資家向け指標
- **risk-manager**: ポートフォリオリスク、ヘッジ戦略、Rマルチプル、ポジションサイジング
- **content-marketer**: SEOコンテンツ、ブログ投稿、ソーシャルメディア、メールキャンペーン
- **sales-automator**: コールドメール、フォローアップ、提案書、リード育成
- **customer-support**: サポートチケット、FAQ、ヘルプドキュメント、トラブルシューティング
- **legal-advisor** - プライバシーポリシー、利用規約、免責事項、法的通知の作成

## ベストプラクティス

### 🎯 タスクの委任
1. **Claude Codeに自動委任させる** - メインエージェントがコンテキストを分析し最適なエージェントを選択
2. **要件を具体的に伝える** - 制約、技術スタック、品質要件を含める
3. **エージェントの専門性を信頼する** - 各エージェントはその分野に最適化されている

### 🔄 マルチエージェントワークフロー
4. **高レベルのリクエストから始める** - エージェントが複雑なマルチステップタスクを調整
5. **エージェント間のコンテキストを提供** - 必要な背景情報を持たせる
6. **統合ポイントをレビュー** - 異なるエージェントの成果物がどう連携するか確認

### 🎛️ 明示的な制御
7. **特定のニーズには明示的な呼び出しを使う** - 特定の専門家の視点が必要なとき
8. **複数エージェントを戦略的に組み合わせる** - 異なる専門家が互いの成果を検証できる
9. **特定のレビュー手順を要求する** - 「security-auditorにbackend-architectのAPI設計をレビューさせる」

### 📈 最適化
10. **エージェントの有効性を監視する** - ユースケースに最適なエージェントを学習する
11. **複雑なタスクを反復する** - エージェントのフィードバックを活用して要件を洗練する
12. **エージェントの強みを活用する** - タスクの複雑さをエージェントの能力に合わせる

## 貢献方法

新しいサブエージェントを追加するには:
1. 上記のフォーマットに従った新しい `.md` ファイルを作成する
2. 小文字・ハイフン区切りの名前を使用する
3. サブエージェントを使用すべき場面を明確に記述する
4. システムプロンプトに具体的な指示を含める

## トラブルシューティング

### よくある問題

**エージェントが自動的に呼び出されない:**
- リクエストがドメインを明確に示しているか確認する（例:「パフォーマンス問題」→ performance-engineer）
- タスクの種類を具体的にする（例:「コードレビュー」→ code-reviewer）

**予期しないエージェントの選択:**
- 技術スタックや要件についてより多くの情報を提供する
- 特定のエージェントが必要な場合は明示的に呼び出す

**複数のエージェントが矛盾した助言を出す:**
- これは正常です - 専門家によって優先事項が異なる場合があります
- 明確化を依頼する：「security-auditor と performance-engineer の推奨事項を調整してください」

**エージェントが文脈を把握していないように見える:**
- リクエストに背景情報を記載する
- 過去の会話や確立されたパターンを参照する

### サポートを受ける

エージェントが期待通りに動作しない場合:
1. 各エージェントの個別ファイルで説明を確認する
2. より具体的な言語でリクエストを試す
3. 明示的な呼び出しで特定のエージェントをテストする
4. プロジェクトや目標についてより多くの情報を提供する

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細については[LICENSE](LICENSE)ファイルを参照してください。

## 詳しく学ぶ

- [Claude Code ドキュメント](https://docs.anthropic.com/en/docs/claude-code)
- [Subagents ドキュメント](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---