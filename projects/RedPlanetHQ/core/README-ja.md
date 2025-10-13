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
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="COREロゴ" />
  </a>

### CORE: Claude、Cursor、ChatGPTおよび全AIツールのための統合メモリレイヤー

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWikiバッジ" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>ドキュメント</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 研究ハイライト

COREメモリは、Locomoデータセットのすべての推論タスクにおいて平均正答率**88.24%**を達成し、他のメモリプロバイダーを大きく上回りました。詳細はこの[ブログ](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/)をご覧ください。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) シングルホップ質問は1回のセッションに基づいて回答します。(2) マルチホップ質問は複数の異なるセッションから情報を統合して回答します。(3) オープンドメイン知識質問は、話者が提供した情報と常識や世界の事実など外部知識を組み合わせて回答できます。(4) 時間推論質問は、会話内の時間関連データ手がかりを捉えて時間推論を行うことで回答できます。

## 概要

**課題**

開発者はAIツールに何度もコンテキストを説明し直すため、時間を浪費しています。Claudeでトークン制限に達すると、すべてを失って最初からやり直すことになります。ChatGPTやClaudeからCursorに切り替えると、またコンテキストを説明し直さなければなりません。会話、決定、洞察はセッション間で消えてしまいます。新しいAIツールを使うたびに、コンテキスト切り替えのコストが増大します。

**解決策** - **CORE**（**Contextual Observation & Recall Engine**）

COREは、すべてのAIツール向けのオープンソース統合型・永続的メモリレイヤーです。あなたのコンテキストはCursorからClaude、ChatGPT、Claude Codeへと引き継がれます。1つの知識グラフが「誰が、いつ、何を、なぜ言ったか」を記憶します。一度接続すれば、どこでも記憶します。コンテキストの管理をやめて、構築を始めましょう。

## 🚀 はじめ方
**5分で統合メモリグラフを構築できます：**

1. [core.heysol.ai](https://core.heysol.ai)で**サインアップ**し、アカウントを作成します
2. **最初のメモリを追加** - 自分についてのコンテキストを共有しましょう

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **メモリグラフを可視化**し、COREが事実間の接続を自動形成する様子を確認します
5. **試してみる** - 会話セクションで「私について何を知っていますか？」と聞いてみましょう
6. ツールに接続する：
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - コンテキスト付きコーディング
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - メモリ付きターミナルコーディング
   - [ブラウザ拡張機能追加](https://docs.heysol.ai/providers/browser-extension) - メモリをあらゆるウェブサイトに持ち込む
   - [Linear](https://docs.heysol.ai/integrations/linear)、[Github](https://docs.heysol.ai/integrations/github) - プロジェクトのコンテキストを自動で追加

## 🧩 主な特徴

### 🧠 **統合・ポータブルメモリ**:
**Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWSのKiro、VS Code、Roo Code**全体でMCPを介してメモリの追加・呼び出しが可能

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **時間的＋具象化知識グラフ**:

すべての事実の背後にあるストーリーを記憶―誰が、いつ、なぜ発言したかを豊かな関係性と完全な出自情報で追跡し、単なるフラットな保存ではなく管理

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **ブラウザー拡張機能**:

ChatGPT、Grok、Gemini、Twitter、YouTube、ブログ記事、あらゆるウェブページから会話やコンテンツを直接COREメモリに保存できます。

**拡張機能の使い方**
1. [Chromeウェブストア](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc)から拡張機能をダウンロードします。
2. [COREダッシュボード](https://core.heysol.ai)にログイン
   - 設定（左下）に移動
   - APIキー → 新しいキーを生成 → 「extension」と名前をつける
3. 拡張機能を開き、APIキーを貼り付けて保存

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **メモリとチャット**:
「私の執筆の好みは何？」などの質問を、接続された知識から瞬時にインサイトを得て回答

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **アプリからの自動同期**:

Linear、Slack、Notion、GitHubなど接続されたアプリから、関連するコンテキストをCOREメモリに自動で取り込み

📖 **[すべての統合を見る](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - サポートされているサービスとその機能の完全なリスト

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP統合ハブ**: 

Linear、Slack、GitHub、Notionを一度COREに接続すると、ClaudeやCursor、または任意のMCPクライアントで、すべてのツールを単一URLで利用可能


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## COREが記憶を作成する方法

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

COREのインジェストパイプラインは、進化するコンテキストを捉えるために設計された4つのフェーズで構成されています：

1. **正規化**: 新しい情報を最近のコンテキストにリンクし、長いドキュメントを一貫したチャンクに分割しつつ相互参照を保持し、用語を標準化することで、COREが知識を抽出する時点で乱雑なテキストではなく、クリーンでコンテキスト化された入力を扱えるようにします。
2. **抽出**: 正規化されたテキストから意味を引き出し、エンティティ（人物、ツール、プロジェクト、概念）を特定し、それらをコンテキスト・情報源・時間とともにステートメントに変換し、関係性をマッピングします。例：「We wrote CORE in Next.js」は、エンティティ（Core、Next.js）、ステートメント（COREはNext.jsで開発された）、関係（開発に使用された）となります。
3. **解決**: 矛盾を検出し、好みの変化を追跡し、複数の視点を情報源付きで保持することで、最新のスナップショットだけでなく、全体の旅を反映した記憶を残します。
4. **グラフ統合**: エンティティ、ステートメント、エピソードを時間的知識グラフに接続し、事実をそのコンテキストと履歴にリンクすることで、孤立したデータをエージェントが実際に活用できる生きた知識のウェブへと変換します。

結果：フラットなデータベースではなく、COREはあなたと共に成長・変化する記憶を提供し、コンテキスト・進化・所有権を保持することで、エージェントが実際に活用できるようになります。


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## COREが記憶から呼び出す方法

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

COREに質問すると、単にテキストを検索するのではなく、知識グラフ全体を掘り下げて最も有用な答えを探します。

1. **検索**: COREは複数の角度から同時に記憶を検索します ― キーワード検索で正確な一致を、意味検索で言い回しが違っても関連するアイデアを、グラフ探索でつながった概念間のリンクを追跡します。
2. **再ランク**: 取得された結果は、最も関連性が高く多様なものを強調するように並べ替えられ、単純な一致だけでなく深い関連も見逃しません。
3. **フィルタリング**: COREは時間・信頼性・関係強度に基づいたスマートなフィルタを適用し、最も意味のある知識だけが表面化します。
4. **出力**: あなたは事実（明確な記述）とエピソード（それが元々あったコンテキストの情報）の両方を受け取ります。したがって、リコールは常にコンテキスト、時間、ストーリーに根ざしています。

結果：COREは単に事実を呼び出すだけでなく、それを正しいコンテキスト、時間、ストーリーで呼び出すため、エージェントはあなたが覚えている方法で応答できます。

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

COREはセキュリティを重視しています。業界標準のセキュリティ対策を実施し、あなたのデータを保護します：

- **データ暗号化**: すべての転送中データ（TLS 1.3）および保存データ（AES-256）
- **認証**: OAuth 2.0およびマジックリンク認証
- **アクセス制御**: ワークスペースベースの分離とロールベースの権限
- **脆弱性報告**: セキュリティ問題は harshith@tegon.ai までご報告ください

詳細なセキュリティ情報については、[セキュリティポリシー](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)をご覧ください。

## 🧑‍💻 サポート

ご質問やご意見がありますか？私たちがサポートします：

- Discord: [core-supportチャンネルに参加](https://discord.gg/YGUZcvDjUa)
- ドキュメント: [docs.heysol.ai](https://docs.heysol.ai)
- メール: manik@poozle.dev

## 利用ガイドライン

**保存:**

- 会話履歴
- ユーザーの設定
- タスクのコンテキスト
- 参考資料

**保存しないもの:**

- 機微なデータ（PII）
- 認証情報
- システムログ
- 一時データ

## 👥 貢献者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>











---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---