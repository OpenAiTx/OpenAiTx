# 🦞 素晴らしい OpenClaw エージェント

[![Awesome](https://awesome.re/badge.svg)](https://awesome.re)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)
[![Stars](https://img.shields.io/github/stars/mergisi/awesome-openclaw-agents?style=social)](https://github.com/mergisi/awesome-openclaw-agents)
[![Agents](https://img.shields.io/badge/agents-187-blueviolet)](agents/)

> OpenClaw エコシステムのための**187の本番対応可能なAIエージェントテンプレート**を厳選したコレクションです。すべてのテンプレートはコピペ可能な `SOUL.md` ファイルです。

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:4F46E5,100:7C3AED&height=180&section=header&text=%F0%9F%A6%9E%20187%20OpenClaw%20Agent%20Templates&fontSize=36&fontColor=ffffff&fontAlignY=35" width="100%"/>
</p>

<div align="center">

### セットアップ不要。60秒でデプロイ。

**[187のテンプレートをすべて見る →](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=browse)** · **[60秒でデプロイ →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=deploy)**

テンプレートを選択。設定をカスタマイズ。完全なデプロイパッケージを入手。ターミナルは不要。

</div>

<div align="center">

📬 **毎週のエージェントテンプレートとヒントを受け取る** — 新しいテンプレート、デプロイガイド、コミュニティハイライトを毎週火曜日に配信。

**[ニュースレターを購読する →](https://docs.google.com/forms/d/e/1FAIpQLSeIqBjV1LXnR2qQqGSGa-48rAveAmpSKVqlzLqDK2d4D4aVWg/viewform)**

</div>

---

## 目次

- [エージェントテンプレート](#agent-templates)（24カテゴリにわたる187エージェント）
  - [生産性](#productivity) · [開発](#development) · [マーケティング・コンテンツ](#marketing--content) · [ビジネス](#business) · [パーソナル](#personal)
  - [DevOps](#devops) · [ファイナンス](#finance) · [教育](#education) · [ヘルスケア](#healthcare) · [法務](#legal) · [人事](#hr) · [クリエイティブ](#creative) · [セキュリティ](#security)
  - [Eコマース](#e-commerce) · [データ](#data) · [SaaS](#saas) · [不動産](#real-estate) · [フリーランス](#freelance) · [Moltbook](#-moltbook-new)
  - [サプライチェーン](#supply-chain) · [コンプライアンス](#compliance) · [ボイス](#voice) · [カスタマーサクセス](#customer-success) · [オートメーション](#automation)
- [ユースケース](#use-cases) (132の実際の例)
- [クイックスタート](#quickstart)
- [なぜOpenClawか？](#why-openclaw) (フレームワークとの比較、軽量、エンタープライズ)
- [CrewClawでのクイックデプロイ](#quick-deploy-with-crewclaw)
- [MCPサーバー](#mcp-servers)
- [統合](#integrations)
- [ツール](#tools)
- [セキュリティ](#security)
- [チュートリアル＆ガイド](#tutorials--guides)
- [エージェントを提出する](#submit-your-agent)
- [コミュニティ](#community)

---

## エージェントテンプレート

すぐに使えるAIエージェント用のSOUL.mdテンプレート。SOUL.mdをコピーし、`openclaw agents add`で登録し、ゲートウェイを開始します。

```bash
# Quick start with any template
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
npm install && cp ../agents/productivity/orion/SOUL.md ./SOUL.md
node bot.js
```
> 100のエージェントはすべて機械可読なJSONでも利用可能です：[`agents.json`](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json)

> **セットアップをスキップしますか？** [CrewClaw](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=skip_setup) は任意の役割のフルデプロイパッケージ（Dockerfile + docker-compose + bot + README）を生成します。

### 📋 生産性

より少ない労力でより多くを達成。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | デプロイ |
|-------|-----------|-------------|---------|--------|
| [🎯 Orion](agents/productivity/orion/) | タスク調整、プロジェクト管理 | 日々の優先順位、締め切り管理、チームの整合が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/orion/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=project-manager) |
| [📊 Pulse](agents/productivity/metrics/) | 分析ダッシュボード（Mixpanel、Stripe、GA4） | 自動化された日次/週次のメトリクスレポートが欲しい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/metrics/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧍 Standup](agents/productivity/daily-standup/) | 毎日のスタンドアップ収集、チーム要約 | ミーティングなしで非同期スタンドアップが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/daily-standup/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=project-manager) |
| [📧 Inbox](agents/productivity/inbox-zero/) | メールの仕分け、返信ドラフト、日次ダイジェスト | 受信箱が溢れて優先順位付けが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/inbox-zero/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Minutes](agents/productivity/meeting-notes/) | 会議の要約、アクションアイテム追跡 | 自動化された会議メモとフォローアップが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/meeting-notes/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🍅 Focus Timer](agents/productivity/focus-timer/) | ポモドーロ、集中作業セッション管理 | 責任を持った構造化された集中時間が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/focus-timer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Habit Tracker](agents/productivity/habit-tracker/) | 日々の習慣、連続記録、責任追跡 | 毎日のチェックインと連続記録の追跡が欲しい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/habit-tracker/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 💻 開発

未来を一度に一つのコミットで構築。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | デプロイ |
|-------|-----------|-------------|---------|--------|
| [🔎 Lens](agents/development/code-reviewer/) | PRレビュー、セキュリティスキャン、コード品質 | マージ前に自動コードレビューが欲しい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/code-reviewer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=code-reviewer) |
| [📖 Scribe](agents/development/docs-writer/) | README、APIドキュメント、コード文書化 | ドキュメントがコードベースに追いついていない時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/docs-writer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=technical-writer) |
| [🐛 Trace](agents/development/bug-hunter/) | エラー解析、根本原因調査 | 迅速なデバッグとインシデント対応が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/bug-hunter/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Probe](agents/development/api-tester/) | APIテスト、ヘルスチェック、パフォーマンス | 継続的なAPI監視とアラートが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/api-tester/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Log](agents/development/changelog/) | 自動チャンジログ、gitからのリリースノート | コミットからリリースノートを生成したい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/changelog/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔗 Dependency Scanner](agents/development/dependency-scanner/) | CVEスキャン、ライセンスチェック、サプライチェーン | 自動依存関係セキュリティ監査が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/dependency-scanner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔀 PR Merger](agents/development/pr-merger/) | 自動マージ、コンフリクト検出 | チェック通過後にPRを自動マージしたい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/pr-merger/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗄️ Migration Helper](agents/development/migration-helper/) | データベースマイグレーション、スキーマ差分、ロールバック | データベース変更を計画して安全策が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/migration-helper/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Test Writer](agents/development/test-writer/) | ユニットテスト生成、カバレッジ分析 | テストカバレッジが低く追いつく必要がある時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/test-writer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗂️ Schema Designer](agents/development/schema-designer/) | 自然言語からのDBスキーマ、ERD出力 | 要件からデータベーススキーマを設計したい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/schema-designer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |

> **60秒で動くソフトウェアエンジニアエージェントが欲しいですか？** [CrewClawでデプロイ →](https://crewclaw.com/create-agent?role=software-engineer)

### 📣 マーケティング＆コンテンツ


オートパイロットでオーディエンスを増やす。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 配備 |
|-------|-----------|-------------|---------|--------|
| [✍️ Echo](agents/marketing/echo/) | ブログ投稿、ソーシャルコピー、メール | 複数チャネルで安定したコンテンツ出力が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/echo/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Buzz](agents/marketing/social-media/) | Twitter、LinkedIn、スレッド管理 | 予約投稿とエンゲージメント追跡がしたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/social-media/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [🔍 Rank](agents/marketing/seo-writer/) | SEOコンテンツ、GSCからのキーワード調査 | 実際の検索データに基づくSEO最適化コンテンツが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/seo-writer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=seo-specialist) |
| [📬 Digest](agents/marketing/newsletter/) | ニュースレターのキュレーション、メール作成 | 手間をかけず週刊ニュースレターを送りたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/newsletter/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🔭 Scout](agents/marketing/competitor-watch/) | 競合監視、価格情報 | 競合の動向を毎日追跡したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/competitor-watch/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔎 Reddit Scout](agents/marketing/reddit-scout/) | サブレディット監視、返信機会探索 | 関連するRedditスレッドを見つけて関わりたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/reddit-scout/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎵 TikTok Repurposer](agents/marketing/tiktok-repurposer/) | ブログから動画スクリプトへの変換 | 長文コンテンツを短い動画に再利用したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/tiktok-repurposer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📨 Cold Outreach](agents/marketing/cold-outreach/) | リード調査、パーソナライズ冷メール | ロボットっぽくなくスケーラブルなアウトリーチが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/cold-outreach/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [📊 A/B Test Analyzer](agents/marketing/ab-test-analyzer/) | 実験分析、統計的有意性 | 実験を行い明確な結果が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ab-test-analyzer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Influencer Finder](agents/marketing/influencer-finder/) | インフルエンサー調査、アウトリーチ、キャンペーン | 関連インフルエンサーを見つけて接触したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/influencer-finder/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [👁️ Brand Monitor](agents/marketing/brand-monitor/) | ブランド言及監視、感情アラート | ブランドが言及されるたびに知りたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/brand-monitor/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📧 Email Sequence](agents/marketing/email-sequence/) | 多段階ドリップキャンペーン、件名作成 | 自動化されたメール育成シーケンスが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/email-sequence/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [♻️ Content Repurposer](agents/marketing/content-repurposer/) | ブログからツイート、投稿、ショート動画スクリプトへ | 1つのコンテンツを全プラットフォームで使いたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/content-repurposer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📖 Book Writer](agents/marketing/book-writer/) | 書籍制作全工程、6フェーズ | アウトラインから原稿まで本を書きたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/book-writer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📰 News Curator](agents/marketing/news-curator/) | ソーススキャン、AIキュレーション、公開 | 50以上のソースから自動ニュースダイジェストが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/news-curator/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎥 UGC Video](agents/marketing/ugc-video/) | AIインフルエンサー風動画コンテンツ | UGCスタイルの動画スクリプトと制作計画が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ugc-video/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Multi-Account Social](agents/marketing/multi-account-social/) | 10以上のアカウント管理、予約投稿 | 複数ブランドアカウントをプラットフォーム横断で管理するとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/multi-account-social/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=social-media-manager) |

> **コンテンツライターやSEOエージェントが必要ですか？** [CrewClawで配備 →](https://crewclaw.com/create-agent?role=content-writer)

### 💼 ビジネス

負担なく運営を行う。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 配備 |
|-------|-----------|-------------|---------|--------|
| [📊 Radar](agents/business/radar/) | データ分析、インサイト生成 | 毎日のビジネスメトリクスとトレンド分析が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/radar/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎧 Compass](agents/business/customer-support/) | チケット仕分け、返信文作成、エスカレーション | サポート件数がチームの対応力を超えているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/customer-support/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=customer-support) |
| [💼 Pipeline](agents/business/sales-assistant/) | リードスコアリング、アウトリーチ、パイプライン報告 | 自動化されたリード評価とフォローアップが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sales-assistant/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [💰 Ledger](agents/business/invoice-tracker/) | 支払い監視、請求書追跡、MRR | リアルタイム収益と支払い追跡を行いたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/invoice-tracker/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔮 Sentinel](agents/business/churn-predictor/) | 解約リスクスコアリング、維持施策 | 離脱しそうな顧客を事前にキャッチしたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/churn-predictor/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Personal CRM](agents/business/personal-crm/) | 連絡先管理、フォローアップリマインダー | 人間関係やフォローを見失いがちなとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/personal-crm/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💬 WhatsApp Business](agents/business/whatsapp-business/) | マルチチャネルサポート、リード評価 | 顧客がWhatsAppで連絡し迅速な返信が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/whatsapp-business/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📅 Meeting Scheduler](agents/business/meeting-scheduler/) | スマートスケジューリング、タイムゾーン処理 | 複数タイムゾーンでのミーティング調整が手間なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/meeting-scheduler/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💲 Competitor Pricing](agents/business/competitor-pricing/) | 価格追跡、変更アラート | 競合の価格変動を毎日監視したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/competitor-pricing/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📞 SDR Outbound](agents/business/sdr-outbound/) | リード調査、パーソナライズアウトリーチ | 自動化されたアウトバウンド営業開発が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sdr-outbound/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎯 Deal Forecaster](agents/business/deal-forecaster/) | パイプラインシグナル、成約確率 | データ駆動型の商談成約予測が欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/deal-forecaster/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🗣️ Objection Handler](agents/business/objection-handler/) | リアルタイム反論、トークトラック | 営業担当者が即時の反論回答を必要とするとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/objection-handler/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=sales-representative) |

### 🧘 パーソナル

日常生活のためのAIアシスタント。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | デプロイ |
|-------|-----------|-------------|---------|--------|
| [📅 Atlas](agents/personal/daily-planner/) | スケジュール最適化、朝晩の振り返り | 責任を持った構造化された日課を望むとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/daily-planner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📚 Scroll](agents/personal/reading-digest/) | 記事要約、週刊読書ダイジェスト | 読書の積み残しがありキュレーションされた要約が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/reading-digest/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💪 Iron](agents/personal/fitness-coach/) | ワークアウト、栄養、進捗報告 | 全てをトラッキングするパーソナルトレーナーが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/fitness-coach/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏠 Home Automation](agents/personal/home-automation/) | Telegramによるスマートホーム制御 | チャットを通じてスマートホームを操作したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/home-automation/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [👨‍👩‍👧‍👦 Family Coordinator](agents/personal/family-coordinator/) | 共有カレンダー、食事、家事ローテーション | 家族が共有のオーガナイザーやプランナーを必要とするとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/family-coordinator/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ Travel Planner](agents/personal/travel-planner/) | 旅程、フライト、ホテル、予算 | スマートな推薦付きの旅行計画が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/travel-planner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📓 Journal Prompter](agents/personal/journal-prompter/) | 毎日のプロンプト、気分トラッキング、目標設定 | 振り返りのためにガイド付きの日記をつけたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/journal-prompter/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🚀 DevOps

インフラを24時間365日稼働させる。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | デプロイ |
|-------|-----------|-------------|---------|--------|
| [🚨 Incident Responder](agents/devops/incident-responder/) | アラートトリアージ、インシデント調整 | 自動インシデント対応とエスカレーションが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/incident-responder/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🚀 Deploy Guardian](agents/devops/deploy-guardian/) | CI/CD監視、デプロイ状況 | デプロイ通知とロールバックアラートが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/deploy-guardian/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🖥️ Infra Monitor](agents/devops/infra-monitor/) | サーバー健康状態、ディスク、CPU、メモリ | 先手を打ったサーバー監視とアラートが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/infra-monitor/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📜 Log Analyzer](agents/devops/log-analyzer/) | ログ解析、パターン検出、異常検知 | ログの海に溺れて自動解析が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/log-analyzer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💸 Cost Optimizer](agents/devops/cost-optimizer/) | クラウド支出監視、節約提案 | クラウドの請求額が増加し可視化が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/cost-optimizer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔧 Self-Healing Server](agents/devops/self-healing-server/) | コンテナ自動再起動、ディスククリーンアップ | 午前3時に自動修復するサーバーが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/self-healing-server/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🍓 Raspberry Pi Agent](agents/devops/raspberry-pi/) | 軽量エッジエージェント、低RAM最適化 | Raspberry Piやエッジデバイスでエージェントを展開するとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/raspberry-pi/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Runbook Writer](agents/devops/runbook-writer/) | システム構成から運用手順書作成 | インシデント対応の文書化された手順が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/runbook-writer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📊 SLA Monitor](agents/devops/sla-monitor/) | SLA遵守追跡、劣化アラート | サービスの稼働率約束を追跡する必要があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/sla-monitor/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📐 Capacity Planner](agents/devops/capacity-planner/) | インフラ容量予測 | 需要に先立ってインフラのスケール計画が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/capacity-planner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |

### 💰 ファイナンス

数字の意味を理解する。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | デプロイ |
|-------|-----------|-------------|---------|--------|
| [🧾 経費トラッカー](agents/finance/expense-tracker/) | 経費分類、予算アラート | 自動経費追跡と予算管理が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/expense-tracker/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧮 請求書マネージャー](agents/finance/invoice-manager/) | 請求書作成、追跡、フォローアップ | 請求書が紛失し支払いが遅れているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/invoice-manager/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 収益アナリスト](agents/finance/revenue-analyst/) | MRR分析、解約、収益予測 | 自動収益レポートと予測が欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/revenue-analyst/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🏦 税務準備者](agents/finance/tax-preparer/) | 領収書整理、控除計算 | 確定申告の季節が近づき整理が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/tax-preparer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📉 トレーディングボット](agents/finance/trading-bot/) | ポートフォリオ追跡、センチメント、価格アラート | 自動市場監視と価格アラートが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/trading-bot/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔍 不正検出器](agents/finance/fraud-detector/) | 取引異常検知、不正アラート | 取引のリアルタイム不正監視が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/fraud-detector/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 財務予測者](agents/finance/financial-forecaster/) | 過去データからの収益・支出予測 | データ駆動の財務予測が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/financial-forecaster/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⚖️ ポートフォリオリバランサー](agents/finance/portfolio-rebalancer/) | 配分ドリフト分析、リバランス取引 | 投資ポートフォリオの定期的なリバランスが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/portfolio-rebalancer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💳 買掛金管理](agents/finance/accounts-payable/) | 請求書照合、承認ルーティング、支払い | APワークフローの自動化と迅速化が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/accounts-payable/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 コピー・トレーダー](agents/finance/copy-trader/) | トップパフォーマーの取引コピー、リスク管理 | 予測市場での自動トレード複製が欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/copy-trader/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🎓 教育

より賢く学ぶ。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🎓 チューター](agents/education/tutor/) | 概念説明、練習問題 | 24時間いつでも忍耐強いチューターが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/tutor/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [❓ クイズメーカー](agents/education/quiz-maker/) | クイズ生成、スコア追跡 | 学習資料から自動クイズを作成したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/quiz-maker/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📖 スタディプランナー](agents/education/study-planner/) | 学習スケジュール、リマインダー | 日々のリマインダー付き構造化学習計画が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/study-planner/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 研究アシスタント](agents/education/research-assistant/) | 論文検索、要約、引用 | 研究中で論文検索の支援が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/research-assistant/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌍 言語チューター](agents/education/language-tutor/) | 言語学習、会話練習 | 毎日スマホで言語練習をしたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/language-tutor/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📐 カリキュラムデザイナー](agents/education/curriculum-designer/) | コース概要、学習目標 | 構造化されたコース設計と評価基準が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/curriculum-designer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 エッセイグレーダー](agents/education/essay-grader/) | エッセイフィードバック、ルーブリック評価 | 大量のエッセイ評価で一貫性が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/essay-grader/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🃏 フラッシュカードジェネレーター](agents/education/flashcard-generator/) | ノートからの間隔反復カード | 効率的な学習のため自動フラッシュカードが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/flashcard-generator/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🏥 ヘルスケア

最も大切なことをケアする。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🧘 ウェルネスコーチ](agents/healthcare/wellness-coach/) | 毎日のチェックイン、メンタルヘルス、習慣 | 毎日のウェルネスリマインダーと気分追跡が欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/wellness-coach/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🥗 食事プランナー](agents/healthcare/meal-planner/) | 食事プラン、栄養追跡 | 目標に基づいた週単位の食事プランが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/meal-planner/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏋️ ワークアウトトラッカー](agents/healthcare/workout-tracker/) | ワークアウトプラン、進捗追跡 | 進捗に適応するワークアウトプランが欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/workout-tracker/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🩺 症状トリアージ](agents/healthcare/symptom-triage/) | 構造化された症状評価、緊急度判定 | 患者の初期症状評価と案内が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/symptom-triage/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📋 臨床ノート](agents/healthcare/clinical-notes/) | SOAP形式の臨床文書作成 | 診療記録の構造化ノート転記が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/clinical-notes/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [💊 薬剤チェッカー](agents/healthcare/medication-checker/) | 薬物相互作用、投与量アラート | 薬の安全性と相互作用を確認する必要があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/medication-checker/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📝 患者受付](agents/healthcare/patient-intake/) | 受付フォーム、保険確認 | 患者登録の自動化と迅速化が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/patient-intake/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=fitness-coach) |

### ⚖️ 法務

細則をナビゲート。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 配備 |
|-------|-----------|-------------|---------|--------|
| [📜 契約レビューアー](agents/legal/contract-reviewer/) | 契約レビュー、リスク条項検出 | 契約をレビューしてセカンドオピニオンが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/contract-reviewer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ コンプライアンスチェッカー](agents/legal/compliance-checker/) | コンプライアンス監視、期限管理 | 規制要件を常に把握しておく必要があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/compliance-checker/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 ポリシーライター](agents/legal/policy-writer/) | 社内ポリシー、利用規約 | 会社のポリシーを作成または更新する必要があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/policy-writer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 特許アナライザー](agents/legal/patent-analyzer/) | 特許クレーム、先行技術、侵害リスク | 特許の状況分析とリスク評価が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/patent-analyzer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 法的ブリーフライター](agents/legal/legal-brief-writer/) | ブリーフ、動議、メモ作成 | 事案の事実から法的文書を作成する必要があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/legal-brief-writer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔒 NDAジェネレーター](agents/legal/nda-generator/) | カスタマイズされたNDA、機密保持契約 | 迅速かつカスタマイズされたNDA生成が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/nda-generator/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 👥 人事

機能するチームを構築。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 配備 |
|-------|-----------|-------------|---------|--------|
| [🤝 リクルーター](agents/hr/recruiter/) | 履歴書審査、面接スケジューリング | 採用時に候補者のスクリーニングを迅速化したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/recruiter/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎒 オンボーディング](agents/hr/onboarding/) | 新入社員のセットアップ、オリエンテーションガイド | 新入社員にガイド付きオンボーディングを提供したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/onboarding/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📊 パフォーマンスレビュアー](agents/hr/performance-reviewer/) | フィードバック収集、レビュー要約 | 評価期間中に構造化されたフィードバックが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/performance-reviewer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 履歴書スクリーナー](agents/hr/resume-screener/) | 履歴書スコアリング、候補者ランキング | 大量の応募者をスクリーニングするとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/resume-screener/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🚪 退職面談](agents/hr/exit-interview/) | 構造化された退職面談、離職理由の洞察 | 従業員がなぜ退職するのか理解したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/exit-interview/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎁 福利厚生アドバイザー](agents/hr/benefits-advisor/) | 福利厚生Q&A、ポリシー案内 | 従業員が福利厚生やポリシーに関する質問があるとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/benefits-advisor/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💰 報酬ベンチマーカー](agents/hr/compensation-benchmarker/) | 給与データ、市場価格分析 | データに基づく報酬提案が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/compensation-benchmarker/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎨 クリエイティブ

美しく魅力的に。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 配備 |
|-------|-----------|-------------|---------|--------|
| [🎨 ブランドデザイナー](agents/creative/brand-designer/) | ブランドガイドライン、カラーパレット | ブランドアイデンティティを構築または刷新するとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/brand-designer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 ビデオスクリプター](agents/creative/video-scripter/) | ビデオスクリプト、アウトライン、ショットリスト | ビデオコンテンツが必要だがスクリプト作成が苦手なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/video-scripter/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎙️ ポッドキャストプロデューサー](agents/creative/podcast-producer/) | エピソード計画、ショーノート | ポッドキャスト運営に計画の手助けが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/podcast-producer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🧑‍💻 UXリサーチャー](agents/creative/ux-researcher/) | ユーザー調査、フィードバック分析 | 研究者を雇わずにユーザーインサイトが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ux-researcher/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [✏️ コピーライター](agents/creative/copywriter/) | 広告コピー、ランディングページ、メールシーケンス | コンバージョン重視のコピーを迅速に作成したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/copywriter/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🖼️ サムネイルデザイナー](agents/creative/thumbnail-designer/) | YouTube/ソーシャル用サムネイルコンセプト | スクロールを止めるサムネイルアイデアが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/thumbnail-designer/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📢 広告コピーライター](agents/creative/ad-copywriter/) | Google、Meta、LinkedIn広告のバリアント | 複数プラットフォームでA/Bテスト用広告コピーが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ad-copywriter/SOUL.md) | [配備 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 ストーリーボードライター](agents/creative/storyboard-writer/) | ビジュアルストーリーボード、ショットリスト | ビデオコンテンツの事前制作計画が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/storyboard-writer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=content-writer) |

### 🔒 セキュリティ

構築したものを守る。

| エージェント | 専門分野 | 使うタイミング | SOUL.md | デプロイ |
|-------------|-----------|----------------|---------|----------|
| [🛡️ 脆弱性スキャナー](agents/security/vuln-scanner/) | 脆弱性スキャン、修正優先度付け | スタックの継続的なセキュリティスキャンが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/vuln-scanner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔐 アクセス監査官](agents/security/access-auditor/) | 権限レビュー、過剰アクセスの検出 | 誰が何にアクセスできるか監査したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/access-auditor/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [👁️ 脅威モニター](agents/security/threat-monitor/) | 脅威フィード監視、関連アラート | スタックを狙う脅威の早期警告が欲しいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/threat-monitor/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📓 インシデントロガー](agents/security/incident-logger/) | セキュリティインシデントの記録 | 構造化されたインシデント追跡や事後解析が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/incident-logger/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔒 セキュリティ強化ツール](agents/security/security-hardener/) | SOUL.mdの監査、ゲートウェイ強化 | エージェントとゲートウェイの設定を強化したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/security-hardener/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🎣 フィッシング検出器](agents/security/phishing-detector/) | メールのフィッシング解析、URLスキャン | チームに自動フィッシング検出が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/phishing-detector/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=software-engineer) |

### 🛒 Eコマース

売上アップ、管理は簡単に。

| エージェント | 専門分野 | 使うタイミング | SOUL.md | デプロイ |
|-------------|-----------|----------------|---------|----------|
| [🏷️ 商品リスター](agents/ecommerce/product-lister/) | リスティング最適化、SEOタイトル | マーケットプレイス全体で最適化された商品リストが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/product-lister/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=content-writer) |
| [⭐ レビュー応答者](agents/ecommerce/review-responder/) | 顧客レビューへの自動応答 | 顧客レビューに迅速かつ一貫した対応が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/review-responder/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=customer-support) |
| [📦 在庫トラッカー](agents/ecommerce/inventory-tracker/) | 在庫監視、再注文アラート | 在庫切れや過剰在庫を防ぎたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/inventory-tracker/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💲 価格最適化ツール](agents/ecommerce/pricing-optimizer/) | 動的価格設定、競合追跡 | 市場条件に応じて価格を調整したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/pricing-optimizer/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🛒 放棄カート](agents/ecommerce/abandoned-cart/) | カート回復、顧客再獲得シーケンス | 放棄されたカートによる売上損失を防ぎたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/abandoned-cart/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🔍 ドロップシッピングリサーチャー](agents/ecommerce/dropshipping-researcher/) | 24時間商品調査、サプライヤー分析 | ドロップシッピングのための継続的な商品発掘が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/dropshipping-researcher/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |

> **ShopifyやAmazonストアを運営していますか？** [Eコマースエージェントをデプロイ →](https://crewclaw.com/create-agent?role=customer-support)

### 📊 データ

生データを意思決定に変える。

| エージェント | 専門分野 | 使うタイミング | SOUL.md | デプロイ |
|-------------|-----------|----------------|---------|----------|
| [🔄 ETLパイプライン](agents/data/etl-pipeline/) | パイプライン監視、障害アラート、再試行 | データパイプラインの自動監視が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/etl-pipeline/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧹 データクリーナー](agents/data/data-cleaner/) | 品質チェック、重複排除、正規化 | データが散らかっていて自動でクリーンアップしたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/data-cleaner/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 レポートジェネレーター](agents/data/report-generator/) | 複数ソースからの自動レポート作成 | 関係者が手作業なしで定期的なレポートを必要とするとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/report-generator/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🗃️ SQLアシスタント](agents/data/sql-assistant/) | SQL支援、クエリ最適化、スキーマ探索 | 複雑なクエリにSQLの共同作業者が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/sql-assistant/SOUL.md) | [デプロイ →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 ダッシュボードビルダー](agents/data/dashboard-builder/) | メトリクスダッシュボード、メンテナンス | 自動ダッシュボード作成と更新が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/dashboard-builder/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🚨 異常検知器](agents/data/anomaly-detector/) | メトリクス異常検出、統計アラート | 異常なデータパターンに自動でアラートを出したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/anomaly-detector/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 アンケート解析ツール](agents/data/survey-analyzer/) | センチメント、テーマ、NPS内訳 | アンケートデータを構造化して分析したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/survey-analyzer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |

> **データアナリストエージェントが必要ですか？** [CrewClawで展開 →](https://crewclaw.com/create-agent?role=data-analyst)

### ☁️ SaaS

製品を成長させ、ユーザーを維持します。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🚀 オンボーディングフロー](agents/saas/onboarding-flow/) | ユーザーオンボーディング、アクティベーショントラッキング | 新規ユーザーがアハ体験に到達しないとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/onboarding-flow/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=project-manager) |
| [💡 フィーチャーリクエスト](agents/saas/feature-request/) | リクエスト収集、優先順位付け、投票 | フィーチャーリクエストが複数チャネルに散在しているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/feature-request/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=project-manager) |
| [🔮 離脱防止](agents/saas/churn-prevention/) | 積極的な離脱防止、ヘルススコアリング | ユーザーが離脱して原因がわからないとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/churn-prevention/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 利用解析](agents/saas/usage-analytics/) | 製品利用、機能採用状況のトラッキング | ユーザーの製品利用状況を理解したいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/usage-analytics/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📝 リリースノート](agents/saas/release-notes/) | GitとPRから自動でリリースノート作成 | リリースノート作成が面倒で誰もやりたがらないとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/release-notes/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=technical-writer) |

### 🏡 不動産

ディールを見つけ、より早くクロージング。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🏡 リスティングスカウト](agents/real-estate/listing-scout/) | 物件監視、価格下落アラート | 新しいリスティングや価格下落を即時に知りたいとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/listing-scout/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 市場解析ツール](agents/real-estate/market-analyzer/) | 市場分析、類似物件レポート | 自動で市場比較とトレンド分析が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/market-analyzer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎯 リードクオリファイア](agents/real-estate/lead-qualifier/) | リードスコアリング、フォローアップシーケンス | リードが多すぎて資格判定が追いつかないとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/lead-qualifier/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎬 物件動画作成](agents/real-estate/property-video/) | リスティング動画、バーチャルツアー、ステージング | 大量の物件動画コンテンツが必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/property-video/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🏢 商業不動産](agents/real-estate/commercial-re/) | CRE分析、キャップレート、取引追跡 | 商業用不動産投資の分析が必要なとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/commercial-re/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🧑‍💻 フリーランス

賢く働き、より多く請求する。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [📝 提案書作成](agents/freelance/proposal-writer/) | 提案書生成、料金計算 | 提案書作成に時間をかけすぎているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/proposal-writer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=content-writer) |
| [⏱️ タイムトラッカー](agents/freelance/time-tracker/) | 時間管理、請求書作成、稼働率 | 請求可能な時間を見逃しているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/time-tracker/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤝 クライアント管理](agents/freelance/client-manager/) | クライアントCRM、契約管理 | 複数のクライアントと締め切りを管理しているとき | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/client-manager/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=project-manager) |

> **フリーランサーですか？** [パーソナルアシスタントエージェントを展開 →](https://crewclaw.com/create-agent?role=personal-assistant)

### 🤖 Moltbook `NEW`

AIエージェントのソーシャルネットワーキング — エージェント間ソーシャルレイヤーでのあなたのエージェントの存在感。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🤖 コミュニティマネージャー](agents/moltbook/community-manager/) | 投稿更新、交流、カルマ構築 | エージェントにMoltbook上で社会的存在感を維持させたい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/community-manager/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [🔭 スカウト](agents/moltbook/scout/) | フィードスキャン、キーワード監視、ダイジェスト | Moltbookで関連する議論や機会を監視したい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/scout/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [📈 グロースエージェント](agents/moltbook/growth-agent/) | フォロワー増加、サブモルト管理、戦略 | Moltbook上でエージェントの影響力とフォロワー基盤を拡大したい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/growth-agent/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?integrations=moltbook) |

> **新機能：Moltbook連携！** あなたのエージェントがAIエージェントソーシャルネットワーク上で投稿、交流、成長できます。 [Moltbookで展開 →](https://crewclaw.com/create-agent?integrations=moltbook)

### 📦 サプライチェーン `NEW`

物流とサプライヤー運用の最適化。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🚚 ルートオプティマイザー](agents/supply-chain/route-optimizer/) | 配送ルート、交通、容量 | 最適な配送計画が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/route-optimizer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 在庫予測者](agents/supply-chain/inventory-forecaster/) | 需要予測、発注点 | スマートな予測で在庫切れを防ぎたい時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/inventory-forecaster/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⭐ ベンダー評価者](agents/supply-chain/vendor-evaluator/) | サプライヤースコアリング、品質追跡 | データ駆動型のサプライヤー選定とランキングが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/vendor-evaluator/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=data-analyst) |

### ✅ コンプライアンス `NEW`

規制を先取り。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🔒 GDPR監査人](agents/compliance/gdpr-auditor/) | GDPRギャップ分析、是正計画 | データプライバシーコンプライアンスのためにシステム監査が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/gdpr-auditor/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 SOC2準備者](agents/compliance/soc2-preparer/) | 証拠収集、監査準備 | SOC 2認証の準備をしている時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/soc2-preparer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤖 AIポリシーライター](agents/compliance/ai-policy-writer/) | AIガバナンス、EU AI法対応 | 組織のAI利用ポリシーが必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/ai-policy-writer/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [⚠️ リスクアセッサー](agents/compliance/risk-assessor/) | リスク評価、軽減計画 | 構造化されたビジネスリスク評価が必要な時 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/risk-assessor/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎙️ ボイス `NEW`

AI搭載の音声および電話エージェント。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [📞 電話受付係](agents/voice/phone-receptionist/) | 電話対応、ルーティング、予約管理 | スタッフなしで24時間365日の電話対応が必要な場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/phone-receptionist/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📝 ボイスメール文字起こし](agents/voice/voicemail-transcriber/) | 転記、アクションアイテム抽出 | ボイスメールの迅速な処理とルーティングが必要な場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/voicemail-transcriber/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎤 面接ボット](agents/voice/interview-bot/) | スクリーニング面接、評価ルーブリック | 大規模に構造化された候補者スクリーニングが必要な場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/interview-bot/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🤝 カスタマーサクセス `NEW`

顧客満足を維持し、成長させる。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [📊 NPSフォローアップ](agents/customer-success/nps-followup/) | 不満顧客の回復、パーソナライズされたアプローチ | NPSの不満顧客に即時対応が必要な場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/nps-followup/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=customer-support) |
| [🎯 オンボーディングガイド](agents/customer-success/onboarding-guide/) | 製品セットアップ、コンテキストに応じたヒント | 新規ユーザーにガイド付きの製品オンボーディングが必要な場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/onboarding-guide/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=customer-support) |

### 🔄 自動化 `NEW`

設定して忘れるだけ。あなたが眠っている間も働くエージェント。

| エージェント | 専門分野 | 使用タイミング | SOUL.md | 展開 |
|-------|-----------|-------------|---------|--------|
| [🤝 交渉エージェント](agents/automation/negotiation-agent/) | 請求交渉、契約締結 | 請求書や契約の交渉をAIに任せたい場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/negotiation-agent/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 求人応募者](agents/automation/job-applicant/) | 大量応募、履歴書カスタマイズ | 眠っている間に500件以上の求人に応募したい場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/job-applicant/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [☀️ 朝のブリーフィング](agents/automation/morning-briefing/) | メール、カレンダー、ニュースの毎日まとめ | 午前7時にパーソナライズされた日次ブリーフィングが欲しい場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/morning-briefing/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ フライトスクレイパー](agents/automation/flight-scraper/) | フライトディール、価格下落アラート | 最安のフライトを自動で見つけたい場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/flight-scraper/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌙 夜間コーダー](agents/automation/overnight-coder/) | 自律コーディング、翌朝までにPR作成 | 眠っている間にコードを書いてほしい場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/overnight-coder/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💬 Discordビジネス](agents/automation/discord-business/) | Discord経由の完全なビジネス運営 | Discordでビジネスを運営している場合 | [表示](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/discord-business/SOUL.md) | [展開 →](https://crewclaw.com/create-agent?role=personal-assistant) |

---

## 利用事例

**132件の実証済み実例** — 実際にOpenClawエージェントで構築されているもの。

開発者のワークフローやDevOps自動化からスマートホーム制御、暗号通貨取引、ロボティクス、そして自らのコードを修正するエージェントまで。

**[全132件の利用事例を見る →](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/USE-CASES.md)**

主なカテゴリ：パーソナル生産性（14）・ビジネス運営（11）・開発者ワークフロー（10）・コンテンツ作成（10）・エコシステムツール（10）

---

## クイックスタート

設定なしで5分以内に動作するエージェントを起動しましょう：

```bash
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
cp .env.example .env          # add your API key + Telegram token
cp ../agents/marketing/echo/SOUL.md ./SOUL.md
npm install && node bot.js    # your agent is live on Telegram
```

Dockerサポート付きの完全な[クイックスタートガイド](quickstart/)をご覧ください。

またはセットアップを完全にスキップ：**[CrewClawでデプロイ →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=quickstart)** — 任意のロールに対応したフルデプロイパッケージ（Dockerfile + docker-compose + ボット + README）を入手。

---

## なぜOpenClawか？

OpenClawが他のAIエージェントフレームワークと比較してどう違うか：

### AIエージェントフレームワークとの比較

| 特徴 | OpenClaw | AutoGPT | CrewAI | LangChain | MetaGPT |
|---------|----------|---------|--------|-----------|---------|
| Config-first (SOUL.md) | ✅ | ❌ | ❌ | ❌ | ❌ |
| コード不要 | ✅ | ❌ | ❌ | ❌ | ❌ |
| Telegram/Slack/Discord内蔵 | ✅ | ❌ | ❌ | ❌ | ❌ |
| マルチエージェントオーケストレーション | ✅ | ❌ | ✅ | ✅ | ✅ |
| MCP (Model Context Protocol) | ✅ | ❌ | ❌ | ❌ | ❌ |
| セルフホスト / ローカル | ✅ | ✅ | ✅ | ✅ | ✅ |
| ハートビート監視 | ✅ | ❌ | ❌ | ❌ | ❌ |
| Ollama(無料)対応 | ✅ | ✅ | ✅ | ✅ | ❌ |
| 本番対応テンプレート数 | **187** | 0 | 5 | 0 | 3 |
| ワンコマンドデプロイ | ✅ | ❌ | ❌ | ❌ | ❌ |
| エージェント間通信 | ✅ | ❌ | ✅ | ✅ | ✅ |
| セットアップ時間 | 約5分 | 約30分 | 約20分 | 約45分 | 約30分 |

### 軽量代替品との比較

| 特徴 | OpenClaw | ZeroClaw | PicoClaw | NanoClaw | memU |
|---------|----------|----------|----------|----------|------|
| 言語 | Node.js | Rust | Go | Python | Python |
| バイナリサイズ | 約150MB | 約5MB | 約8MB | 約4K行 | 約50MB |
| 最小メモリ | 512MB | 32MB | 64MB | 128MB | 256MB |
| マルチエージェント | ✅ AGENTS.md | ❌ | ❌ | ❌ | ❌ |
| スキル/プラグイン数 | ✅ 13K+ | ❌ | ❌ | ❌ | ❌ |
| メッセージングチャネル数 | ✅ 25+ | 3 | 2 | 1 | 5 |
| 長期記憶 | 基本 | ❌ | ❌ | ❌ | ✅ ナレッジグラフ |
| MCP対応 | ✅ | ❌ | ❌ | ❌ | ❌ |
| Production templates | **187** | 0 | 0 | 0 | 0 |
| Best for | フルエージェントチーム | エッジ/IoT | 単一目的ボット | 最小限のセットアップ | パーソナルアシスタント |

### vs ホステッド/エンタープライズソリューション

| Feature | OpenClaw | Claude Code Channels | NemoClaw (NVIDIA) | OpenFang |
|---------|----------|---------------------|-------------------|----------|
| オープンソース | ✅ MIT | ❌ 独自 | ✅ Apache 2.0 | ✅ MIT |
| セルフホスト | ✅ | ❌ クラウドのみ | ✅ | ✅ |
| セットアップ | 設定ファイル | APIキー | Docker + 設定 | Rustバイナリ |
| マルチエージェント | ✅ | ❌ | ✅ OpenClaw経由 | ✅ 7 "Hands" |
| セキュリティモデル | ユーザー管理 | Anthropic管理 | カーネルサンドボックス | プロセス分離 |
| メッセージング | ✅ 25+ チャンネル | Telegram, Discord | OpenClaw経由 | 3チャンネル |
| コスト | 無料 + API料金 | Claudeサブスクリプション | 無料 + API料金 | 無料 + API料金 |
| ベスト用途 | 完全制御 | 非技術ユーザー | エンタープライズセキュリティ | Agent OSパワーユーザー |

**TL;DR:** OpenClawは設定優先です。SOUL.mdを書き、コマンドを実行すればエージェントが稼働します。Python不要、チェーン不要、グラフ不要。軽量な代替は機能を削って小さなフットプリントを実現。エンタープライズソリューションはセキュリティ層を追加します。

---

## CrewClawでのクイックデプロイ

テンプレートを選び、カスタマイズし、[CrewClaw](https://crewclaw.com/create-agent)で完全なデプロイパッケージを入手しましょう：

```
Your CrewClaw package includes:
├── agents/your-agent/SOUL.md    # Agent configuration
├── Dockerfile                    # Container setup
├── docker-compose.yml            # One-command deploy
├── bot.js                        # Telegram bot (grammy)
├── .env.example                  # API keys template
├── package.json                  # Dependencies
└── README.md                     # Setup instructions
```
上記の187のテンプレートの中から任意のものを選ぶか、カスタムエージェントを一から作成してください。

**[エージェントを作成する →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta)**

---

## MCPサーバー

エージェントの機能を拡張するためのモデルコンテキストプロトコルサーバー。

### 公式

| サーバー | 説明 | インストール |
|--------|-------------|---------|
| [@anthropic/mcp-server-fetch](https://github.com/anthropics/mcp-server-fetch) | ウェブの取得とブラウジング | `npx -y @anthropic/mcp-server-fetch` |
| [@anthropic/mcp-server-filesystem](https://github.com/anthropics/mcp-server-filesystem) | ファイルシステムへのアクセス | `npx -y @anthropic/mcp-server-filesystem` |

### コミュニティ

| サーバー | 説明 |
|--------|-------------|
| mcp-notion | Notion連携 |
| mcp-google-calendar | Googleカレンダーアクセス |
| mcp-github | GitHub操作 |
| mcp-slack | Slackメッセージング |
| mcp-postgres | PostgreSQLクエリ |
| mcp-stripe | Stripe決済 |
| mcp-shopify | Shopifyストア管理 |
| mcp-twitter | Twitter/X投稿 |
| mcp-discord | Discordボット連携 |
| mcp-linear | Linear課題管理 |

---

## インテグレーション

エージェントを外部サービスに接続。

### メッセージング

- **Telegram** - Telegram経由でエージェントとチャット（OpenClawに組み込み済み）
- **Slack** - Slackワークスペース接続（OpenClawに組み込み済み）
- **Discord** - Discordサーバーボット（OpenClawに組み込み済み）
- **Email** - メールチャネル（OpenClawに組み込み済み）

### 自動化

- **n8n** - n8n統合ノード
- **GitHub Actions** - CI/CD統合
- **Cron / pm2 / systemd** - 常時稼働エージェントスケジューリング

---

## ツール

OpenClawで作業するためのユーティリティとヘルパー。

| ツール | 説明 |
|--------|-------|
| [openclaw CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) | 公式CLI - 完全なコマンドリファレンス |
| [agents.json](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json) | 全187エージェントテンプレートの機械判読可能な索引 |
| agent-validator | SOUL.md構文の検証 |
| mcp-tester | MCPサーバー接続のテスト |

---

## セキュリティ

OpenClawエージェントはあなたのハードウェア上でファイルやサービスにアクセスして動作します。以下のベストプラクティスを守ってください：

| リスク | 対策 |
|--------|-------|
| ゲートウェイの露出 | `localhost`にのみバインド。リモートアクセスにはSSHトンネルを使用。ポート18789をインターネットに公開しない。 |
| APIキー漏洩 | `.env`ファイルにキーを保存。`.env`を`.gitignore`に追加。定期的にキーをローテーション。 |
| 悪意のあるスキル | ClawHub認証済みパブリッシャーのスキルのみインストール。インストール前にSKILL.mdを確認。 |
| プロンプトインジェクション | SOUL.mdの`## Rules`を厳格に設定。ファイルシステムアクセスを制限。信頼できない入力にはシェルコマンドを無効化。 |
| 無人エージェント | HEARTBEAT.mdをスコープ制限付きで使用。予算上限を設定。すべての操作のログを有効化。 |

**最近のセキュリティリソース：**

- [OpenClaw セキュリティガイド](https://crewclaw.com/blog/openclaw-security-guide) - セットアップの強化方法  
- [OpenClaw セキュリティリスク 2026](https://crewclaw.com/blog/openclaw-security-risks-2026) - 既知の脆弱性と修正  
- [NemoClaw (NVIDIA GTC 2026)](https://crewclaw.com/blog/nvidia-gtc-2026-openclaw-nemoclaw) - エンタープライズ向けセキュリティラッパー  
- [公式セキュリティドキュメント](https://docs.openclaw.ai/gateway/security) - ゲートウェイのセキュリティ設定  

---

## チュートリアル & ガイド

エージェントの構築と展開方法を学びましょう。

### はじめに

- [OpenClaw の使い方：初心者ガイド](https://crewclaw.com/blog/how-to-use-openclaw-guide) - インストールから最初のエージェントまで5分  
- [OpenClaw とは？](https://crewclaw.com/blog/what-is-openclaw-ai-agent-framework) - フレームワークの完全ガイド  
- [最初のエージェントを作成](https://crewclaw.com/blog/how-to-create-ai-agent-openclaw) - コード不要  
- [OpenClaw セットアップガイド 2026](https://crewclaw.com/blog/openclaw-setup-guide-2026) - インストール、設定、実行  
- [システム要件](https://crewclaw.com/blog/openclaw-system-requirements-2026) - ハードウェア、GPU、VPS、Docker の仕様  
- [OpenClaw に最適なモデル](https://crewclaw.com/blog/best-models-for-openclaw-2026) - コスト、速度、ツール呼び出しで比較した10のLLM  
- [SOUL.md テンプレート](https://crewclaw.com/blog/soul-md-examples-templates) - 使える例が10種類  

### マルチエージェント & オーケストレーション

- [マルチエージェントセットアップガイド](https://crewclaw.com/blog/openclaw-multi-agent-setup-guide) - 複数のエージェントを同時に実行  
- [エージェント間通信](https://crewclaw.com/blog/openclaw-agent-to-agent-communication) - エージェント同士の協力方法  
- [AIチームの構築](https://crewclaw.com/blog/build-ai-team-workflows) - 自律的に動くワークフロー  

### ユースケース

- [OpenClaw で何ができる？](https://crewclaw.com/blog/what-can-openclaw-do) - 設定付きの12の実例  
- [ビジネス向け OpenClaw](https://crewclaw.com/blog/openclaw-for-business-use-cases) - 8カテゴリにわたる25のユースケース  
- [コンテンツ作成ガイド](https://crewclaw.com/blog/openclaw-content-creation-guide) - ブログ、ソーシャルメディア、動画自動化  
- [リードジェネレーションガイド](https://crewclaw.com/blog/openclaw-lead-generation-guide) - Reddit、Twitter、営業パイプライン  
- [メール自動化](https://crewclaw.com/blog/openclaw-email-automation-guide) - 受信トリアージ、自動返信、フォローアップ  
- [Home Assistant 連携](https://crewclaw.com/blog/openclaw-home-assistant-integration) - スマートホーム制御  

### 連携 & 自動化

- [Slack & Telegram 連携](https://crewclaw.com/blog/openclaw-slack-telegram-integration) - メッセージングチャネルへの接続

- [Ollamaで実行](https://crewclaw.com/blog/openclaw-ollama-local-agents) - 無料のローカルAIエージェント
- [自動化ガイド](https://crewclaw.com/blog/openclaw-automation-guide) - 24時間365日のワークフロー構築
- [CLIコマンドリファレンス](https://crewclaw.com/blog/openclaw-cli-commands-reference) - 完全チートシート
- [Google Workspace連携](https://crewclaw.com/blog/openclaw-google-workspace-integration) - Gmail、Docs、Drive、Calendar

### 比較

- [OpenClaw vs CrewAI](https://crewclaw.com/blog/openclaw-vs-crewai) - どちらが優れているか？
- [OpenClaw vs AutoGen](https://crewclaw.com/blog/openclaw-vs-autogen) - Microsoftのマルチエージェントフレームワーク
- [OpenClaw vs LangChain](https://crewclaw.com/blog/openclaw-vs-langchain) - フレームワーク比較
- [OpenClaw vs AutoGPT](https://crewclaw.com/blog/openclaw-vs-autogpt) - 主要な違い
- [OpenClaw vs ZeroClaw](https://crewclaw.com/blog/openclaw-vs-zeroclaw) - Rust製の軽量代替
- [OpenClaw vs OpenFang](https://crewclaw.com/blog/openclaw-vs-openfang) - 7 Hands搭載のエージェントOS
- [OpenClaw vs memU](https://crewclaw.com/blog/openclaw-vs-memu) - 長期記憶AI
- [PicoClaw vs OpenClaw](https://crewclaw.com/blog/picoclaw-vs-openclaw) - 超ミニマル代替
- [OpenClaw GitHubリポジトリガイド](https://crewclaw.com/blog/openclaw-ai-agent-github-guide) - 25万スターリポジトリの解説

---

## エージェントを投稿する

カスタムエージェントを作成しましたか？ここや[crewclaw.com/agents](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=submit)で掲載しましょう。

各エージェントは単なるプロンプトではなく、完全なオペレーティングシステムです：

```
agents/[category]/[your-agent]/
├── SOUL.md          ← Identity & personality (required)
├── README.md        ← Description & use cases (required)
├── AGENTS.md        ← Operating rules (optional)
├── HEARTBEAT.md     ← Wake-up checklist (optional)
└── WORKING.md       ← Starting task (optional)
```
**PR経由（推奨）：**

1. このリポジトリをフォークする  
2. SOUL.md + README.md（最低限）を含むエージェントフォルダを追加する  
3. `agents.json`にエントリを追加する  
4. プルリクエストを開く  

**Issue経由（セットアップ不要）：**

[エージェントを提出する →](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md) — ファイルを貼り付けてください。こちらで追加します。  

完全ガイド：[CONTRIBUTING.md](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/CONTRIBUTING.md)  

---

## コミュニティ

エージェントをリクエストしたいですか？[Agent Request](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-request.md)テンプレートを使用してください。  

---

## 関連プロジェクト

- [🦞 CrewClaw](https://crewclaw.com) - 設定不要でAIエージェントをデプロイ。Docker不要、ターミナル不要。  
- [OpenClaw](https://github.com/openclaw) - 公式OpenClawリポジトリ  
- [Anthropic MCP](https://github.com/anthropics/mcp) - モデルコンテキストプロトコル  

---

## スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=mergisi/awesome-openclaw-agents&type=Date)](https://star-history.com/#mergisi/awesome-openclaw-agents&Date)  

---

## ライセンス

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)


法の許す限りにおいて、寄稿者は本作品に関するすべての著作権および関連する権利を放棄しています。

---

<p align="center">
  OpenClawコミュニティによる🦞製作
  <br/>
  <a href="https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta">CrewClawでエージェントをデプロイ →</a> · <a href="https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md">あなたのエージェントを提出 →</a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---