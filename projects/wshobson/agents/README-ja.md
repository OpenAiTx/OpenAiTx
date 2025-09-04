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

[Claude Code](https://docs.anthropic.com/en/docs/claude-code)用の専門的なAIサブエージェントを網羅したコレクションで、分野別の専門知識により開発ワークフローを強化します。

## 概要

このリポジトリには、Claude Codeの機能を拡張する76種類の専門サブエージェントが含まれています。各サブエージェントは特定分野のエキスパートであり、コンテキストに基づいて自動的に呼び出されるか、必要に応じて明示的に呼び出すことができます。すべてのエージェントは、タスクの複雑さに応じたClaudeモデルで構成され、最適なパフォーマンスとコスト効率を実現します。

## 利用可能なサブエージェント

### 開発とアーキテクチャ
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - RESTful API、マイクロサービスの境界、データベーススキーマを設計
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Reactコンポーネントの構築、レスポンシブレイアウトの実装、クライアントサイドの状態管理を担当
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - インターフェースデザイン、ワイヤーフレーム、デザインシステムの作成
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - 厳密なスクリーンショット分析により、UI変更が目的を達成したかを検証
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - React NativeまたはFlutterアプリの開発とネイティブ統合
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - GraphQLスキーマ、リゾルバ、フェデレーションの設計
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - アーキテクチャの一貫性やパターンに関するコード変更のレビュー

### 言語スペシャリスト
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - 高度な機能と最適化を備えたイディオマティックなPythonコードの作成
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - メタプログラミング、Railsパターン、gem開発、テストフレームワークを活用したイディオマティックなRubyコードの作成
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - ゴルーチン、チャネル、インターフェースを用いたイディオマティックなGoコードの作成
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - 所有権パターン、ライフタイム、トレイト実装を用いたイディオマティックなRustの作成
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - 適切なメモリ管理とシステムコールを備えた効率的なCコードの作成
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - モダンな機能、RAII、スマートポインタ、STLアルゴリズムを用いたイディオマティックなC++コードの作成
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - ES6+、非同期パターン、Node.js APIを駆使したモダンJavaScriptの習得
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - 高度な型、ジェネリクス、厳格な型安全性を備えたTypeScriptの習得
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - モダンな機能とパフォーマンス最適化を備えたイディオマティックなPHPコードの作成
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - ストリーム、並行処理、JVM最適化を駆使したモダンJavaの習得
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - OTPパターン、関数型プログラミング、Phoenixフレームワークを活用したイディオマティックなElixirコードの作成
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - 高度な機能と.NET最適化を備えたモダンC#コードの作成
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - 関数型プログラミング、分散システム、ビッグデータ処理を駆使したエンタープライズグレードのScala開発
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Dart、ウィジェット、プラットフォーム統合を活用したFlutter開発の習得
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - 最適化されたスクリプトとパフォーマンスチューニングによるUnityゲームの構築
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Bukkit、Spigot、Paper APIによるMinecraftサーバープラグイン開発の習得
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Swift/SwiftUIでのネイティブiOSアプリケーション開発
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - 複雑なSQLクエリの記述、実行プランの最適化、正規化スキーマの設計

### インフラストラクチャと運用
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - 本番問題のデバッグ、ログ分析、デプロイ失敗の修正
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - CI/CDパイプライン、Dockerコンテナ、クラウドデプロイの構成
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - AWS/Azure/GCPインフラの設計とクラウドコストの最適化
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - AWS/Azure/GCPとOpenStackオンプレミス環境を跨ぐハイブリッドクラウドインフラの設計
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - Kubernetesを中核としたクラウドネイティブインフラの設計と、AWS/Azure/GCPおよびハイブリッド環境でのGitOps原則の導入
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - SQLクエリの最適化、効率的なインデックス設計、データベース移行の対応
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - データベース運用、バックアップ、レプリケーション、監視の管理
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - 高度なTerraformモジュールの作成、ステートファイル管理、IaCベストプラクティスの実装
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - 本番インシデントを迅速かつ正確に対応
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - ネットワーク接続のデバッグ、ロードバランサーの設定、トラフィックパターンの解析
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - 開発者体験スペシャリスト、ツール・セットアップ・ワークフローの改善

### 品質 & セキュリティ
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - 高度な設定セキュリティと本番信頼性に重点を置いた専門的なコードレビュー
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - コードの脆弱性をレビューし、OWASP準拠を保証
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - ユニット・統合・E2Eテストを含む包括的なテストスイートを作成
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - アプリケーションのプロファイリング、ボトルネックの最適化、キャッシュ戦略の実装
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - エラー、テスト失敗、予期せぬ挙動のデバッグ専門家
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ログやコードベースからエラーパターン、スタックトレース、異常を検索
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - 高度な検索技術と統合を用いたウェブリサーチ専門家

### データ & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - SQLクエリ、BigQuery操作、データインサイトの解析専門家
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - ETLパイプライン、データウェアハウス、ストリーミングアーキテクチャの構築
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - LLMアプリケーション、RAGシステム、プロンプトパイプラインの構築
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - MLパイプライン、モデル提供、特徴量エンジニアリングの実装
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - MLパイプライン、実験トラッキング、モデルレジストリの構築
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - LLMやAIシステム向けのプロンプト最適化

### 専門分野
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - OpenAPI/Swagger仕様作成と開発者向けドキュメント作成
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Stripe、PayPal、各種決済プロセッサの統合
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - 金融モデル構築、トレーディング戦略のバックテスト、マーケットデータ分析
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - ポートフォリオリスク、Rマルチプル、ポジション制限の監視
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - レガシーコードベースのリファクタリングと段階的モダナイゼーションの実装
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - 複数エージェントや長期タスク間でのコンテキスト管理

### ドキュメント
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - 既存コードベースから包括的な技術ドキュメントを作成
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - フローチャート、シーケンス、ERD、アーキテクチャ用のMermaidダイアグラム作成
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - 技術リファレンス・APIドキュメントの網羅的作成
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - コードからステップバイステップのチュートリアルと教育コンテンツを作成

### ビジネス & マーケティング
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - メトリクス解析、レポート作成、KPIトラッキング
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - ブログ記事、SNSコンテンツ、メールニュースレター作成
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** - 採用、オンボーディング/オフボーディング、PTO・休暇、パフォーマンス、コンプライアンス方針、従業員関係のパートナー
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - コールドメール、フォローアップ、提案テンプレートの作成
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - サポートチケット、FAQ対応、顧客メールの処理
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - プライバシーポリシー、利用規約、免責事項、法的通知の作成

### SEO & コンテンツ最適化
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - 提供されたコンテンツの品質、E-E-A-Tシグナル、SEOベストプラクティスを分析
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - 最適化されたメタタイトル、説明文、URL案を作成
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - キーワードの使用分析、密度計算、意味的バリエーションを提案
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - コンテンツ構造、ヘッダ階層、スキーママークアップを最適化
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - 強調スニペットやSERP機能向けにコンテンツをフォーマット
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - 古くなった要素を特定し、コンテンツの更新を提案
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - 複数ページのキーワード重複や競合を分析
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - コンテンツのE-E-A-Tシグナルや信頼指標を分析
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - キーワードやブリーフに基づいたSEO最適化コンテンツの執筆
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - コンテンツアウトライン、トピッククラスター、カレンダーを作成

## モデル割り当て

全76サブエージェントは、タスクの複雑さに基づき特定のClaudeモデルで構成されています：

### 🚀 Haiku（高速・コスト効率重視） - 15エージェント
**モデル:** `haiku`
- `data-scientist` - SQLクエリとデータ分析
- `api-documenter` - OpenAPI/Swaggerドキュメント作成
- `reference-builder` - 詳細な技術リファレンスとAPI文書
- `business-analyst` - 指標・KPIトラッキング
- `content-marketer` - ブログ投稿とSNSコンテンツ
- `customer-support` - サポートチケットとFAQ
- `sales-automator` - コールドメールや提案書作成
- `search-specialist` - ウェブリサーチと情報収集
- `legal-advisor` - プライバシーポリシーやコンプライアンス文書
- `seo-meta-optimizer` - メタタイトル・説明文の最適化
- `seo-keyword-strategist` - キーワード密度・意味解析
- `seo-structure-architect` - コンテンツ構造・スキーママークアップ
- `seo-snippet-hunter` - 強調スニペットフォーマット
- `seo-content-refresher` - コンテンツの鮮度更新
- `seo-cannibalization-detector` - キーワード重複検出
- `seo-content-planner` - コンテンツカレンダー・アウトライン

### ⚡ Sonnet（バランス型パフォーマンス） - 45エージェント
**モデル:** `sonnet`

**開発 & 言語:**
- `python-pro` - 高度な機能を備えたPython開発
- `ruby-pro` - メタプログラミング、Railsパターン、gem開発を含むRuby開発
- `javascript-pro` - 最新のJavaScriptとNode.js
- `typescript-pro` - 型システムを活用した高度なTypeScript
- `golang-pro` - Goの並行処理とイディオマティックなパターン
- `rust-pro` - Rustのメモリ安全性とシステムプログラミング
- `c-pro` - C言語によるプログラミングと組み込みシステム
- `cpp-pro` - STLとテンプレートを活用した最新C++
- `php-pro` - 高度な機能を備えた最新PHP
- `java-pro` - ストリームと並行処理を活用した最新Java
- `elixir-pro` - OTPパターンとPhoenixを使ったElixir
- `csharp-pro` - .NETフレームワークとパターンによる最新C#
- `scala-pro` - Apache Pekko、Akka、Spark、ZIO/Cats Effectを用いたエンタープライズScala
- `flutter-expert` - 状態管理とアニメーションを含むFlutter開発
- `unity-developer` - Unityによるゲーム開発と最適化
- `minecraft-bukkit-pro` - Bukkit/Spigot/PaperによるMinecraftプラグイン開発
- `ios-developer` - Swift/SwiftUIによるネイティブiOS開発
- `frontend-developer` - ReactコンポーネントとUI
- `ui-ux-designer` - インターフェース設計とワイヤーフレーム
- `ui-visual-validator` - スクリーンショット解析による厳格なUIバリデーション
- `backend-architect` - API設計とマイクロサービス
- `mobile-developer` - React Native/Flutterアプリ
- `sql-pro` - 複雑なSQL最適化
- `graphql-architect` - GraphQLスキーマとリゾルバ

**インフラ & 運用:**
- `devops-troubleshooter` - 本番環境のデバッグ
- `deployment-engineer` - CI/CDパイプライン
- `database-optimizer` - クエリ最適化
- `database-admin` - データベース運用
- `terraform-specialist` - Infrastructure as Code
- `network-engineer` - ネットワーク構成
- `dx-optimizer` - 開発者体験の最適化
- `data-engineer` - ETLパイプライン

**品質 & サポート:**
- `test-automator` - テストスイート作成
- `code-reviewer` - コード品質分析
- `debugger` - エラー調査
- `error-detective` - ログ解析
- `ml-engineer` - 機械学習モデルのデプロイ
- `legacy-modernizer` - フレームワークの移行
- `payment-integration` - 決済処理
- `mermaid-expert` - Mermaid図とビジュアルドキュメント
- `flutter-expert` - Flutter開発
- `seo-content-auditor` - コンテンツ品質とE-E-A-T分析
- `seo-authority-builder` - 権威シグナルの最適化
- `seo-content-writer` - SEO最適化コンテンツ作成

### 🧠 Opus（最大能力）- 15エージェント
**モデル:** `opus`
- `ai-engineer` - LLMアプリケーションとRAGシステム
- `security-auditor` - 脆弱性分析
- `performance-engineer` - アプリケーション最適化
- `incident-responder` - 本番インシデント対応
- `mlops-engineer` - 機械学習インフラ
- `architect-reviewer` - アーキテクチャ整合性
- `cloud-architect` - クラウドインフラ設計
- `prompt-engineer` - LLMプロンプト最適化
- `context-manager` - マルチエージェント協調
- `quant-analyst` - 金融モデリング
- `risk-manager` - ポートフォリオリスク管理
- `docs-architect` - コードベースから包括的な技術ドキュメント作成
- `tutorial-engineer` - ステップバイステップのチュートリアルと教育コンテンツ

## インストール

これらのサブエージェントは `~/.claude/agents/` ディレクトリに配置することで自動的に利用可能になります。

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
- **mlops-engineer**: MLインフラストラクチャ、実験トラッキング、モデルレジストリ、パイプライン自動化

### 🧪 品質保証
- **code-reviewer**: コード品質、構成のセキュリティ、運用信頼性
- **test-automator**: テスト戦略、テストスイート作成
- **debugger**: バグ調査、エラー解決
- **error-detective**: ログ解析、エラーパターン認識、根本原因分析
- **search-specialist**: ディープウェブ調査、競合分析、ファクトチェック

### 📚 ドキュメント
- **api-documenter**: OpenAPI/Swagger仕様、APIドキュメント
- **docs-architect**: 包括的な技術ドキュメント、アーキテクチャガイド、システムマニュアル
- **reference-builder**: 網羅的なAPIリファレンス、設定ガイド、パラメータドキュメント
- **tutorial-engineer**: ステップバイステップチュートリアル、学習パス、教育コンテンツ

### 💼 ビジネス＆戦略
- **business-analyst**: KPI、収益モデル、成長予測、投資家指標
- **risk-manager**: ポートフォリオリスク、ヘッジ戦略、Rマルチプル、ポジションサイズ管理
- **content-marketer**: SEOコンテンツ、ブログ投稿、SNS、メールキャンペーン
- **sales-automator**: コールドメール、フォローアップ、提案書、リード育成
- **customer-support**: サポートチケット、FAQ、ヘルプドキュメント、トラブルシューティング
- **legal-advisor** - プライバシーポリシー、利用規約、免責事項、法的通知の作成

## ベストプラクティス

### 🎯 タスクの委任
1. **Claude Codeに自動委任させる** - メインエージェントが文脈を分析し最適なエージェントを選択
2. **要件を具体的に伝える** - 制約、技術スタック、品質要件を含める
3. **エージェントの専門性を信頼する** - 各エージェントは自分の分野に最適化されている

### 🔄 マルチエージェントワークフロー
4. **高レベルなリクエストから始める** - エージェントに複雑なマルチステップタスクを調整させる
5. **エージェント間で文脈を提供する** - 必要な背景情報をエージェントに共有
6. **統合ポイントをレビューする** - 異なるエージェントの成果物がどう連携するか確認

### 🎛️ 明示的なコントロール
7. **特定のニーズには明示的に呼び出す** - 特定の専門家の視点が欲しい場合
8. **複数エージェントを戦略的に組み合わせる** - 異なる専門家が互いの成果を検証できる
9. **特定のレビュー方法を依頼する** - 「security-auditorにbackend-architectのAPI設計をレビューしてもらう」

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---