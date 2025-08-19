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
    <a href="https://docs.heysol.ai/core/overview"><b>ドキュメント</b></a> ・
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 概要

**問題**

開発者は、AIツールに文脈を何度も説明することに時間を浪費しています。Claudeでトークン制限に達した場合は、やり直しで全て失われます。ChatGPTやClaudeからCursorに切り替えても、また文脈を説明し直す必要があります。会話、決定、洞察はセッション間で消えてしまいます。

**解決策** - **CORE** （**Contextual Observation & Recall Engine**）

COREは、全てのAIツール向けのオープンソース統合・永続メモリレイヤーです。あなたの文脈はCursorからClaude、ChatGPT、Claude Codeまで一貫して引き継がれます。知識グラフが、誰が何を、いつ、なぜ言ったかを記憶します。一度接続すれば、どこでも記憶。文脈管理をやめて、開発を始めましょう。

## 🚀 はじめ方
**5分で統合メモリグラフを構築:**

1. [core.heysol.ai](https://core.heysol.ai)で**サインアップ**し、アカウントを作成します
2. **最初のメモリを追加** - 自分についての文脈を共有します

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **メモリグラフを可視化**し、COREが事実間の接続を自動で構築する様子を確認します
5. **テスト** - 会話セクションで「私について何を知っていますか？」と聞いてみてください
6. ツールと連携する:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - 文脈を活用したコーディング
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude) & [Gemini CLI](https://docs.heysol.ai/providers/cursor) - メモリを使ったターミナルコーディング
   - [ブラウザ拡張機能追加](https://docs.heysol.ai/providers/cursor) - どのウェブサイトでもメモリを利用
   - [Linear](https://docs.heysol.ai/providers/claude)、[Slack](https://docs.heysol.ai/providers/cursor)、[Github](https://docs.heysol.ai/providers/cursor) - プロジェクト文脈を自動追加

## 🧩 主要な特徴

### 🧠 **統合・ポータブルメモリ**:
**Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWSのKiro、VS Code、Roo Code**でMCPを通じてメモリの追加・呼び出しが可能

### 🕸️ **時系列 + 再構成型ナレッジグラフ**:

すべての事実の裏にある物語を記憶—誰が何を、いつ、なぜ言ったかを豊かな関係と完全な出自情報で追跡。単なるフラットな保存ではありません

https://github.com/user-attachments/assets/d18e3caa-72ea-4596-bbf7-cc9e32bd772f

### 🌐 **ブラウザー拡張機能**:

ChatGPT、Grok、Gemini、Twitter、YouTube、ブログ記事、あらゆるウェブページから直接COREメモリに会話を保存


https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **メモリとのチャット**:
「私の執筆の好みは何ですか？」のような質問も、接続された知識から即座にインサイトを取得

https://github.com/user-attachments/assets/6be5aca5-1d2f-419e-9deb-acb897a05c20

### ⚡ **アプリからの自動同期**:

Linear、Slack、Notion、GitHubなど、接続されたアプリから関連するコンテキストを自動的にCOREメモリに保存

https://github.com/user-attachments/assets/a797f182-406d-49e8-80a8-20932169931d

### 🔗 **MCP統合ハブ**:

Linear、Slack、GitHub、NotionをCOREに一度接続すれば、Claude、Cursor、その他のMCPクライアントで全てのツールが利用可能


https://github.com/user-attachments/assets/be2d69a7-6c6c-43ad-91b7-6db66712821d



## ドキュメント

COREを最大限に活用するためにドキュメントを参照してください

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [セルフホスティング](https://docs.heysol.ai/self-hosting/overview)
- [Core MCPをClaudeと接続する](https://docs.heysol.ai/providers/claude)
- [Core MCPをCursorと接続する](https://docs.heysol.ai/providers/cursor)

- [基本概念](https://docs.heysol.ai/overview)
- [APIリファレンス](https://docs.heysol.ai/local-setup)

## 🧑‍💻 サポート

ご質問やご意見がございますか？サポートいたします：

- Discord: [core-supportチャンネルに参加する](https://discord.gg/YGUZcvDjUa)
- ドキュメント: [docs.heysol.ai](https://docs.heysol.ai)
- メール: manik@poozle.dev

## 利用ガイドライン

**保存するもの:**

- 会話履歴
- ユーザー設定
- タスクコンテキスト
- 参考資料

**保存しないもの:**

- 機密データ（PII）
- 認証情報
- システムログ
- 一時データ

## 👥 コントリビューター

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---