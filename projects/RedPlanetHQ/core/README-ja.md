<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE ロゴ" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# あなた専用のAI OS。

**あなたのOSを起動。** あなたの作業を見守り、重要なことを記憶し、ツールやエージェントを横断して行動します。オープンソース、自分でホスト、永遠にあなたのもの。

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Website" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Docs" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="License: AGPL 3.0" />
    </a>
</p>
</div>

---

## 動作デモ

COREが2つのコーディングタスクをエンドツーエンドで処理する様子をご覧ください。

[![CORE デモ](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## COREとは

COREはAIネイティブワークのためのオープンソースのオペレーティングレイヤーです。

やるべきことをスクラッチパッドに記述すれば、COREがタスクを拾い、メモリや接続アプリからコンテキストを読み込み、計画を立案し、ゲートウェイ経由で適切なエージェントを実行し、ブロッカーを処理し、判断が必要な場合は人間に戻します。

繰り返し指示するチャットボットではありません。記憶し、調整し、実行し、エスカレーションするレイヤーです。

### アーキテクチャ

| | |
|---|---|
| **監視** | MCP経由のAI会話のコンテキスト、50以上の接続アプリ、およびMac上で明示的に許可したアプリからの情報を監視します。 |
| **記憶** | あなたが何を言ったかだけでなく、何を、いつ、なぜ決定したかをすべてのツールと会話にわたって追跡するナレッジグラフです。 |
| **実行** | 接続されたアプリで直接アクションを実行し、長時間の作業はゲートウェイ経由でコーディングおよびブラウザエージェントに委任します。 |
| **ポリシー** | 承認フロー、エスカレーションルール、計画、監査ログにより、自律性を保ちながら説明責任を確保します。 |

COREは安全に実行できる内容を判断し、機密性の高い操作は事前に確認し、レビュー可能な履歴を残します。

---

## COREの実際の活用例

### コーディングタスクを委任し、PRで確認。

COREに必要な作業を伝えます。リポジトリ、アプリ、メモリからコンテキストを収集し、計画を作成、Claude CodeやCodexセッションを実行、可能な範囲でブロッカーを処理し、PRを作成します。完了後にあなたがレビューします。

`[ ] イシュー #312 のチェックアウトフローの競合状態を修正する`

### 寝ている間にバックログを処理。

決まった時間にバックログからタスクを定期的に実行するよう設定します。オフラインの間にCOREが作業を進めます。順調なタスクは翌朝のレビュー待ちに、詰まったセッションは的確な質問で戻ってきます。

`[ ] 今夜のバックログを23時から処理する`

### アラートが割り込みになる前に調査。

Sentryやログ、他のアラートソースを監視する定期タスクを設定します。何かが発生した時、COREが調査し、関連トレースや過去事例を収集、対応またはエスカレーションを判断します。

Sentryのアラートが午前2時に発生。COREが調査し、修正案を提示、Slackであなたにレビューを通知します。

### あなたの仕事を把握した朝の要約を受け取る。

毎朝、メール、GitHub、Linear、Slackから情報を取得する定期タスクを設定します。COREが注目すべき内容を要約し、不要なものはスキップ、フォローアップは自動でタスク化します。

### どこにいても委任可能。

Slack、WhatsApp、Telegram、メール、Webからタスクを作成できます。ゲートウェイはDockerやRailwayで稼働し、ノートPCを閉じていてもCOREが作業を受け取ります。

---

## COREの内部構成

| | |
|---|---|
| **メモリ** | すべてのツールや会話であなたの好み、決定、目標、指示を記録し、すべてのタスクがコンテキストを読み込んだ状態で始まります。 |
| **タスク** | 一回限りまたは定期的な作業単位。仕様、COREの計画、ライブ状態、専用チャットスレッド付き。各タスクはコーディングやブラウザセッションを生成できます。 |
| **スクラッチパッド** | タスク、アイデア、進行中の作業のためのデイリーページ。[ ] をどこでも入力すれば、COREが3分以内に拾い上げます。 |
| **コネクター** | 1つのMCPエンドポイントで50以上のアプリに対応、さらにWebhookトリガーで自動化を積極的にサポート。GitHub、Linear、Jira、Slack、Gmail、Calendar、Sentry、Granola、Todoistなど。 |
| **スキル** | 100以上の再利用可能な指示をコンテキストに応じて自動的に適用。組み込みスキルの利用や独自作成も可能で、反復ワークフローに役立ちます。 |
| **ゲートウェイ** | Claude Code、Codex、ブラウザーエージェント、ローカルコマンドをあなたのマシンまたはDocker/Railway上で実行。ラップトップを閉じてもCOREは動作します。 |
| **モデル非依存** | 好みのプロバイダーを利用可能：Anthropic、OpenAI、あるいはオープンウェイトモデル。フルスタックを自己ホストして隔離運用も可能。 |

---

## COREが「できないこと」

| | |
|---|---|
| **RAGラッパーではありません。** | メモリは単なる埋め込みチャンクではありません。知識グラフとして、何を・いつ・なぜ決定したかを追跡します。 |
| **ワークフロービルダーではありません。** | ドラッグ＆ドロップのDAGはありません。必要なことを書くだけ。COREがワークフローを組み立て、判断が必要な時に尋ねます。 |
| **Devinのようなものではありません。** | COREが計画を提案し、あなたが承認。COREがブロック解除を要求し、あなたが決定。COREがPRを持ち帰り、あなたがレビュー。エージェントが自動でマージしません。 |
| **クローズドなクラウドアシスタントではありません。** | COREはオープンソースでセルフホスト可能、モデル非依存、インフラ中心に設計されています。 |

---

## クイックスタート

オープンソースかつセルフホスト型。あなたのデータは自分のインフラ内にとどまります。

**COREをインストールして起動：**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```
セットアップウィザードは、インストールディレクトリ、AIプロバイダー、APIキー、チャットモデルを尋ねます。シークレットを生成し、スタックを起動し、`http://localhost:3033` を開きます。

Dockerが起動していれば、ほとんどのローカルインストールは数分で完了します。

**または Railway でデプロイする:**

[![Railway でデプロイ](https://railway.app/button.svg)](https://railway.com/deploy/core)

**ゲートウェイを接続**して、COREがあなたのブラウザを操作したり、コーディングエージェントを実行したり、ローカルフォルダへアクセスできるようにします:


```bash
corebrain login
corebrain gateway setup
```

**要件:** Docker 20.10以上、Docker Compose 2.20以上、4 vCPU / 8GB RAM

[完全なセルフホスティングガイド](https://docs.getcore.me/self-hosting/setup)

> Macアプリをご希望ですか？ [getcore.me](https://www.getcore.me/) でウェイトリストにご参加ください。

---

## ベンチマーク

COREは[LoCoMoベンチマーク](https://github.com/RedPlanetHQ/core-benchmark)において、シングルホップ、マルチホップ、オープンドメイン、および時間的推論全体で**88.24%**の平均精度を達成しています。

---

## 私たちの信念

- チャットはインターフェースであり、OSではありません。
- 記憶のない知能は雑学にすぎません。
- あなたのAIは現在のタブだけでなく、あらゆるツールであなたを理解すべきです。
- 作業は、あなたがハブになることなく、意図から行動へと進むべきです。
- 責任のない自動化は混乱を招きます。

---

## ドキュメント

- [**メモリ**](https://docs.getcore.me/memory/overview) - 時系列ナレッジグラフ、事実分類、インテント駆動型検索
- [**スクラッチパッド**](https://docs.getcore.me/concepts/scratchpad) - タスクやアイデアが始まる日常の場
- [**タスク**](https://docs.getcore.me/concepts/tasks) - 計画、状態、定期作業、タスク範囲のコンテキスト
- [**ツールキット**](https://docs.getcore.me/concepts/toolkit) - MCP経由で50以上のアプリ、1000以上のアクション
- [**COREエージェント**](https://docs.getcore.me/concepts/meta-agent) - トリガー、メモリ、ツール、実行
- [**ゲートウェイ**](https://docs.getcore.me/access-core/overview) - WhatsApp、Slack、Telegram、メール、Web、APIアクセス
- [**スキル**](https://docs.getcore.me/skills/overview) - 再利用可能な手順による繰り返し可能なワークフロー
- [**セルフホスティング**](https://docs.getcore.me/self-hosting/setup) - 完全なデプロイメントガイド
- [**変更履歴**](https://docs.getcore.me/opensource/changelog) - リリース内容

---

## セキュリティ

- CASA Tier 2 認証済み
- 転送時は TLS 1.3
- 保存時は AES-256
- あなたのデータはモデルのトレーニングに使用されません
- 完全な分離のためにセルフホスト可能
- [セキュリティポリシー](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- 脆弱性連絡先: harshith@poozle.dev

---

## コミュニティ

私たちはCOREを公開で開発しています。

パーソナルOSを構築する上で最も難しい課題は、実際に使う人々と共に解決するのが最適であるため、ロードマップやアーキテクチャの決定をオープンに共有しています。リポジトリにスターを付けたり、セルフホストしたり、作成したものをシェアしたり、不具合や不足している点についてIssueを開いてください。

- [Discord](https://discord.gg/YGUZcvDjUa) - 質問、アイデア、成果発表
- [貢献ドキュメント](https://docs.getcore.me/opensource/contributing) - COREへの貢献方法
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - ここから始めよう

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**あなた自身のパーソナルAI OSをセルフホストしよう。**

[リポジトリにスターを付ける](https://github.com/RedPlanetHQ/core) · [ドキュメントを読む](https://docs.getcore.me) · [Discordに参加する](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---