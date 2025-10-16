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
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE ロゴ" />
  </a>

### CORE: AIアプリのためのあなた専用のメモリレイヤー

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki バッジ" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>ドキュメント</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 研究ハイライト

COREメモリはLocomoデータセットの全推論タスクで平均**88.24%**の精度を達成し、他のメモリプロバイダーを大きく上回りました。詳細は[ブログ](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/)をご覧ください。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) シングルホップ質問は1つのセッションに基づいて回答されます；(2) マルチホップ質問は複数の異なるセッションから情報を統合して回答します；(3) オープンドメイン知識質問は話者が提供した情報と外部知識（常識や世界の事実など）を統合して回答できます；(4) 時間推論質問は会話内の時系列データ手がかりを捉えることで時間推論によって回答されます；

## 概要

**問題点** 

開発者はAIツールに文脈を何度も説明するのに時間を浪費しています。Claudeでトークン上限に達すると、最初からやり直してすべて失います。ChatGPT/ClaudeからCursorへ切り替えたら、また文脈を説明し直さなければなりません。会話、決定、洞察はセッション間で消えてしまいます。新しいAIツールを使うたびに、コンテキスト切り替えのコストが増大します。

**解決策** - **CORE**（**Contextual Observation & Recall Engine**）

COREはすべてのAIツール向けのオープンソース統合型・永続型メモリレイヤーです。あなたの文脈はCursorからClaude、ChatGPT、Claude Codeへと引き継がれます。一つのナレッジグラフが「誰が、いつ、何を、なぜ」話したかを記憶します。一度接続すれば、どこでも記憶。文脈管理はやめて、構築を始めましょう。

## 🚀 COREセルフホスティング
COREを自分のインフラで稼働させたいですか？セルフホスティングなら、データと運用を完全にコントロールできます。

**前提条件**:

- Docker（20.10.0以上）およびDocker Compose（2.20.0以上）がインストール済み
- OpenAI APIキー

> **オープンソースモデルに関する注意:** OllamaやGPTモデルなどOSSオプションをテストしましたが、事実抽出とグラフ品質は基準に達しませんでした。現在も選択肢を積極的に探しています。

### セットアップ

1. リポジトリをクローンします:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. `core/.env`で環境変数を設定します。
```
OPENAI_API_KEY=your_openai_api_key
```
3. サービスを開始します
```
docker-compose up -d
```

デプロイが完了したら、AIプロバイダー（OpenAI、Anthropic）の設定を行い、メモリーグラフの構築を開始できます。

👉 [完全なセルフホスティングガイドを表示](https://docs.heysol.ai/self-hosting/docker)

注意: OllamaやGPT OSSなどのオープンソースモデルを試しましたが、事実生成の精度が低かったため、現在も改善方法を模索しています。改善でき次第、OSSモデルもサポート予定です。

## 🚀 CORE Cloud
**5分で統合メモリーグラフを構築：**

インフラ管理をしたくない場合は、CORE Cloudで即座に個人用メモリーシステムを構築可能—セットアップ不要、サーバー不要、ただ使えるメモリー。

1. [core.heysol.ai](https://core.heysol.ai)で**サインアップ**し、アカウントを作成
2. **メモリーグラフを可視化**し、COREが事実間の接続を自動で形成する様子を確認
3. **テスト実施**—会話セクションで「私について知っていることは？」と質問
4. ツールと連携：
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) — 文脈を活用したコーディング
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) — メモリー搭載のターミナルコーディング
   - [ブラウザー拡張機能追加](https://docs.heysol.ai/providers/browser-extension) — メモリーを任意のウェブサイトで活用
   - [Linear](https://docs.heysol.ai/integrations/linear)、[Github](https://docs.heysol.ai/integrations/github) — プロジェクト文脈を自動追加

## 🧩 主な機能

### 🧠 **統合・ポータブルメモリー**: 
**Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWSのKiro、VS Code、Roo Code**でMCPを介してメモリーの追加と呼び出しが可能

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **時系列＋具体化ナレッジグラフ**: 

すべての事実の背景ストーリーを記憶—誰が、いつ、なぜ発言したかを豊かな関係性と完全な来歴で追跡し、単なる平面的な保存ではない

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **ブラウザー拡張機能**: 

ChatGPT、Grok、Gemini、Twitter、YouTube、ブログ記事、任意のウェブページの会話とコンテンツを直接COREメモリーへ保存可能。

**拡張機能の使い方**
1. [Chrome ウェブストア](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc)から拡張機能をダウンロードします。
2. [COREダッシュボード](https://core.heysol.ai)にログインします
   - 設定（左下）へ移動
   - APIキー → 新しいキーを生成 → 名前は「extension」にする。
3. 拡張機能を開き、APIキーを貼り付けて保存します。

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **メモリ付きチャット**: 
「私の執筆の好みは？」などの質問をして、接続された知識から即座に洞察を得ることができます

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **アプリからの自動同期**:

Linear、Slack、Notion、GitHubなど接続されたアプリから関連するコンテキストをCOREメモリに自動で取り込みます

📖 **[統合一覧を見る](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - サポートされているサービスとその機能の完全リスト

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCPインテグレーションハブ**: 

Linear、Slack、GitHub、Notionを一度COREに接続すれば、Claude、Cursor、または任意のMCPクライアントで全てのツールを単一URLで利用可能


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## COREがメモリを作成する方法

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

COREの取り込みパイプラインは、進化するコンテキストを捉えるために設計された4つのフェーズで構成されています:

1. **正規化**: 新しい情報を最近のコンテキストにリンクし、長いドキュメントをクロスリファレンスを維持しつつ一貫したチャンクに分割し、用語を標準化します。これにより、COREが知識を抽出する時点では、雑多なテキストではなく、クリーンで文脈化された入力を扱います。
2. **抽出**: 正規化されたテキストから意味を引き出し、エンティティ（人物、ツール、プロジェクト、概念）を特定し、文脈・出典・時刻を付与したステートメントに変換し、関係性をマッピングします。例えば「We wrote CORE in Next.js」は、エンティティ（CORE, Next.js）、ステートメント（COREはNext.jsで開発された）、関係（開発された）となります。
3. **解決**: 矛盾を検出し、嗜好の変化を追跡し、複数の視点を出典付きで保持することで、最新のスナップショットだけでなく全体の記憶の軌跡を反映します。
4. **グラフ統合**: エンティティ、ステートメント、エピソードを時系列のナレッジグラフに接続し、事実をその文脈や履歴にリンクさせ、孤立したデータをエージェントが実際に活用できる生きた知識のウェブに変換します。

結果: フラットなデータベースではなく、COREはあなたと共に成長・変化する記憶を提供します。文脈、進化、所有権を保持し、エージェントが実際に利用できるようになります。


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## COREによる記憶からのリコール方法

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

あなたがCOREに質問すると、単にテキストを検索するだけでなく、全ナレッジグラフを掘り下げて最も有用な答えを見つけます。

1. **検索**: COREは複数の角度から記憶を検索します――キーワード検索による完全一致、セマンティック検索で異なる表現でも関連するアイデアを探し、グラフトラバーサルで繋がった概念間のリンクを辿ります。
2. **再ランク**: 検索結果は最も関連性が高く多様なものが目立つように並び替えられ、単なる一致だけでなく深い関連も見つけやすくします。
3. **フィルタリング**: COREは時刻、信頼性、関係の強さなどに基づくスマートなフィルターを適用し、最も意味のある知識だけが表面化します。
4. **出力**: 明確な事実（ステートメント）と、その出典となるエピソード（元の文脈）の両方が返されるので、リコールは常に文脈・時刻・ストーリーに根ざします。

結果: COREは単なる事実を呼び出すだけでなく、適切な文脈・時刻・ストーリーとともに呼び出すため、エージェントがあなたの記憶通りに応答できます。

## ドキュメント

COREを最大限に活用するためにドキュメントをご覧ください

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [セルフホスティング](https://docs.heysol.ai/self-hosting/overview)
- [Core MCPとClaudeの接続](https://docs.heysol.ai/providers/claude)
- [Core MCPとCursorの接続](https://docs.heysol.ai/providers/cursor)
- [Core MCPとClaude Codeの接続](https://docs.heysol.ai/providers/claude-code)
- [Core MCPとCodexの接続](https://docs.heysol.ai/providers/codex) 

- [基本概念](https://docs.heysol.ai/overview)
- [APIリファレンス](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 セキュリティ

COREはセキュリティを重視しています。業界標準のセキュリティ対策を実装し、あなたのデータを保護します。
- **データ暗号化**：転送中のデータ（TLS 1.3）および保存時のデータ（AES-256）をすべて暗号化
- **認証**：OAuth 2.0とマジックリンク認証
- **アクセス制御**：ワークスペース単位の分離とロールベースの権限管理
- **脆弱性報告**：セキュリティ問題は harshith@poozle.dev までご報告ください

詳細なセキュリティ情報は、[セキュリティポリシー](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)をご覧ください。

## 🧑‍💻 サポート

ご質問やご意見がありますか？私たちがサポートします:

- Discord: [core-support チャンネルに参加](https://discord.gg/YGUZcvDjUa)
- ドキュメント: [docs.heysol.ai](https://docs.heysol.ai)
- メール: manik@poozle.dev

## 利用ガイドライン

**保存するもの:**

- 会話履歴
- ユーザー設定
- タスクのコンテキスト
- 参考資料

**保存しないもの:**

- 機微情報（PII）
- 認証情報
- システムログ
- 一時データ

## 👥 コントリビューター

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>
















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---