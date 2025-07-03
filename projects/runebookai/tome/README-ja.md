# Tome - 魔法のAIスペルブック

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>誰もがLLMとMCPの力を手にできる魔法のデスクトップアプリ</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 Tomeデスクトップアプリをダウンロード: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tomeは、**誰でも**LLMとMCPの魔法を活用できるデスクトップアプリです。Tomeをダウンロードし、ローカルまたはリモートのLLMを接続し、数千のMCPサーバーと連携して、自分だけの魔法のAIスペルブックを作成できます。

🫥 完全にローカル、完全にプライベートにしたいですか？OllamaとQwen3を使い、ローカルMCPサーバーのみで、自分だけのポケットユニバースで魔法をかけましょう。⚡ 最新のリモートMCPサーバーと最先端のクラウドモデルを使いたいですか？それも可能です。すべてはあなた次第！

🏗️ これはテクニカルプレビュー版ですので、細部が粗い部分があるかもしれません。[Discordに参加](https://discord.gg/9CH6us29YA)して、ヒントやコツ、不具合などを共有してください。このリポジトリにスターを付けて、最新情報や新機能をチェックしましょう！

## 🪄 主な特徴

- 🧙 **初心者に優しいシンプルな体験**
  - Tomeをダウンロードしてインストールし、お好みのLLMを接続するだけ
  - JSON、Docker、python、nodeなどの面倒な設定は不要
- 🤖 **AIモデル対応**
  - **リモート**: Google Gemini、OpenAI、OpenAI API互換エンドポイント
  - **ローカル**: Ollama、LM Studio、Cortex、OpenAI API互換エンドポイント
- 🔮 **強化されたMCPサポート**
  - MCPサーバーのインストール、削除、オン/オフの切り替え用UI
  - npm、uvx、node、pythonのMCPサーバーを標準サポート
- 🏪 **[Smithery.ai](https://smithery.ai) レジストリとの統合**
  - ワンクリックで数千のMCPサーバーをインストール可能
- ✏️ **コンテキストウィンドウと温度のカスタマイズ**
- 🧰 **ツールコールと推論モデルのネイティブサポート**
  - ツールコールと思考メッセージを明確に区別するUI強化

## デモ

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# はじめに

## 必要条件

- MacOS または Windows（Linuxは近日対応予定！）
- お好みのLLMプロバイダー: [Ollama](https://ollama.com/) または [Gemini APIキー](https://aistudio.google.com/app/apikey)（どちらも簡単＆無料）
- [Tomeの最新リリースをダウンロード](https://github.com/runebookai/tome/releases)

## クイックスタート

1. [Tome](https://github.com/runebookai/tome/releases)をインストール
2. お好みのLLMプロバイダーを接続します。OpenAI、Ollama、Geminiはプリセット済みですが、LM Studioなどのプロバイダーも http://localhost:1234/v1 のようなURLで追加可能です
3. TomeのMCPタブを開き、最初の[MCPサーバー](https://github.com/modelcontextprotocol/servers)をインストールします（Fetchが簡単でおすすめ、`uvx mcp-server-fetch` をサーバーフィールドに貼り付けるだけでOK）
4. MCP対応モデルとチャット！Hacker Newsのトップ記事を取得するよう依頼してみましょう

# ビジョン

私たちはローカルLLMとMCPをすべての人が使えるようにしたいと考えています。エンジニア、いじり好き、趣味人、その他どんな方でも、LLMで創造的になれるツールを作っています。

## コア原則

- **Tomeはローカルファースト:** データの行き先はあなたが管理します。
- **Tomeは誰のためにも:** プログラミング言語やパッケージマネージャ、json設定ファイルの管理は不要です。

## 今後の予定

Tomeリリース以来、素晴らしいフィードバックをたくさんいただいていますが、今後の大きな計画もあります。LLMをチャットボックスから解放したいと考えており、そのための多くの新機能を準備中です。

- スケジュールタスク: パソコンの前にいなくてもLLMが役立つことをしてくれるように
- ネイティブ統合: MCPサーバーはツールや情報へのアクセスに最適ですが、より強力な統合機能を追加し、独自の方法でLLMとやりとりできるようにしたい
- アプリビルダー: 長期的には、最高の体験はチャットインターフェース以外にあると信じています。強力なアプリケーションやワークフローを作成できるツールの追加を計画しています。
- ??? 皆さんのご要望もぜひお聞かせください！下記リンクからコミュニティに参加し、ご意見をお寄せください。

# コミュニティ

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---