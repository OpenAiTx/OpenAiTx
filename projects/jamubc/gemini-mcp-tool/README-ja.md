## 新機能：Geminiで読み込み、Claudeで編集＋差分表示

<div align="center">
  <img width="400" alt="screenshot 2025-07-13 at 07 09 45"
       src="https://github.com/user-attachments/assets/5fccba53-71ce-4546-8aed-b1095c5a1ca8" />
</div>

---

> **注意：**  
> - 既にGemini CLIに他のMCPツールがインストールされている場合、それらがgemini-mcp-toolと干渉し、直接stdoutに書き込むMCPがあると競合や予期しないコンソール出力が発生する可能性があります。  
> - Geminiに自身を呼び出すように指示することでプロンプトをネストできます（例：`ask gemini to ask gemini`）。ただし、リクエストがクオータを超えた場合、自動的にフォールバックしません。  
> - より高速で低コストのflashモデルを使用するには、`flash`を付加してください（例：`... using flash ...`）。

> 🚀 **体験を共有しよう！** [どうだったか教えてください](https://github.com/jamubc/gemini-mcp-tool/discussions/2) コミュニティの成長にご協力ください！

> 📚 [Wikiドキュメント](https://github.com/jamubc/gemini-mcp-tool/wiki) には追加のガイドや例が掲載されています。  
>  
> 貢献フレームワークは現在テスト中です。Geminiを使ってgemini-mcp-toolの拡張を作成し、ツール作成の自動化やTUIベースのツールジェネレーターを提供することを目指しています。

# Gemini MCPツール

<div align="center">

[![GitHub Release](https://img.shields.io/github/v/release/jamubc/gemini-mcp-tool?logo=github&label=GitHub)](https://github.com/jamubc/gemini-mcp-tool/releases)
[![npm version](https://img.shields.io/npm/v/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![npm downloads](https://img.shields.io/npm/dt/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Open Source](https://img.shields.io/badge/Open%20Source-❤️-red.svg)](https://github.com/jamubc/gemini-mcp-tool)

</div>

<a href="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool/badge" alt="Gemini Tool MCP server" />
</a>

> 📚 **[完全なドキュメントを見る](https://jamubc.github.io/gemini-mcp-tool/)** - 検索、例、FAQ、トラブルシューティング、ベストプラクティス

これはシンプルなモデルコンテキストプロトコル（MCP）サーバーで、AIアシスタントが[Gemini CLI](https://github.com/google-gemini/gemini-cli)と対話できるようにします。特に大きなファイルやコードベースの分析において、`@`構文を使って方向付けし、Geminiの大規模なトークンウィンドウを活用できます。

## TLDR: [![Claude](https://img.shields.io/badge/Claude-D97757?logo=claude&logoColor=fff)](#) + [![Google Gemini](https://img.shields.io/badge/Google%20Gemini-886FBF?logo=googlegemini&logoColor=fff)](#)

**目標**：Geminiの強力な分析機能をClaude Code内で直接利用し、トークンを節約しつつ大きなファイルを解析する。

### 1行セットアップ



```bash
claude mcp add gemini-cli -- npx -y gemini-mcp-tool
```
### インストールの確認

Claude Code内で`/mcp`と入力し、gemini-cli MCPが有効か確認します。

---

### 代替方法：Claude Desktopからのインポート

すでにClaude Desktopで設定済みの場合：

1. Claude Desktopの設定に以下を追加してください：

```json
"gemini-cli": {
  "command": "npx",
  "args": ["-y", "gemini-mcp-tool"]
}
```
2. Claudeコードへのインポート：

```bash
claude mcp add-from-claude-desktop
```
## 前提条件

このツールを使用する前に、以下を確認してください：

1. **[Node.js](https://nodejs.org/)**（v16.0.0以上）
2. **[Google Gemini CLI](https://github.com/google-gemini/gemini-cli)** がインストールされ設定されていること

## インストールオプション

### オプション1：NPX（推奨）
インストール不要 - `npx` を使って直接ツールを実行します。

### オプション2：グローバルインストール

```bash
npm install -g gemini-mcp-tool
```
## 設定

MCPクライアントにMCPサーバーを登録します：

### NPX使用の場合（推奨）

この設定をClaude Desktopの設定ファイルに追加してください：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "npx",
      "args": ["-y", "gemini-mcp-tool"]
    }
  }
}
```
### グローバルインストールの場合

グローバルにインストールした場合は、代わりにこの設定を使用してください：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "gemini-mcp"
    }
  }
}
```
**設定ファイルの場所:**

- **Claude Desktop**:
  - **macOS**: `~/Library/Application Support/Claude/claude_desktop_config.json`
  - **Windows**: `%APPDATA%\Claude\claude_desktop_config.json`
  - **Linux**: `~/.config/claude/claude_desktop_config.json`

設定を更新した後は、ターミナルセッションを再起動してください。

## 利用可能なコマンド

- **自然言語**: "use gemini to explain index.html", "understand the massive project using gemini", "ask gemini to search for latest news"
- **Claude Code**: `/gemini-cli` と入力すると、コマンドがClaude Codeのインターフェースに表示されます。

## 使用例

### ファイル参照付き（@構文を使用）

- `ask gemini to analyze @src/main.js and explain what it does`
- `use gemini to summarize @. the current directory`
- `analyze @package.json and tell me about dependencies`

### 一般的な質問（ファイルなし）

- `ask gemini to search for the latest tech news`
- `use gemini to explain div centering`
- `ask gemini about best practices for React development related to @file_im_confused_about`

### Gemini CLIのサンドボックスモード使用 (-s)

サンドボックスモードは、コード変更の安全なテスト、スクリプトの実行、または潜在的にリスクのある操作を隔離された環境で行うことを可能にします。

- `use gemini sandbox to create and run a Python script that processes data`
- `ask gemini to safely test @script.py and explain what it does`
- `use gemini sandbox to install numpy and create a data visualization`
- `test this code safely: Create a script that makes HTTP requests to an API`

### ツール（AI用）

これらのツールはAIアシスタントによって使用されることを想定しています。

- **`ask-gemini`**: Google Geminiに視点を求めます。一般的な質問やファイルの複雑な解析に使用可能。
  - **`prompt`**（必須）: 解析リクエスト。`@`構文を使ってファイルやディレクトリ参照を含めることができます（例: `@src/main.js explain this code`）または一般的な質問（例: `Please use a web search to find the latest news stories`）。
  - **`model`**（任意）: 使用するGeminiモデル。デフォルトは`gemini-2.5-flash`。
  - **`sandbox`**（任意）: 安全なコード実行のためにサンドボックスモードを有効にする場合は`true`に設定。
- **`sandbox-test`**: Geminiのサンドボックス環境でコードやコマンドを安全に実行します。常にサンドボックスモードで動作。
  - **`prompt`**（必須）: コードテストリクエスト（例: `Create and run a Python script that...` または `@script.py Run this safely`）。
  - **`model`**（任意）: 使用するGeminiモデル。
- **`Ping`**: メッセージをそのまま返す簡単なテストツール。
- **`Help`**: Gemini CLIのヘルプテキストを表示。

### スラッシュコマンド（ユーザー用）

これらのコマンドはClaude Codeのインターフェースで直接使用できます（他クライアントでの互換性は未検証）。

- **/analyze**: Geminiを使ってファイルやディレクトリを解析、または一般的な質問をします。
  - **`prompt`**（必須）: 解析プロンプト。`@`構文でファイルを指定可能（例: `/analyze prompt:@src/ summarize this directory`）または一般的な質問（例: `/analyze prompt:Please use a web search to find the latest news stories`）。
- **/sandbox**: Geminiのサンドボックス環境でコードやスクリプトを安全にテストします。
  - **`prompt`**（必須）: コードテストリクエスト（例: `/sandbox prompt:Create and run a Python script that processes CSV data` または `/sandbox prompt:@script.py Test this script safely`）。
- **/help**: Gemini CLIのヘルプ情報を表示。
- **/ping**: サーバーへの接続テスト。
  - **`message`**（任意）: 返答するメッセージ。

## 貢献

貢献は歓迎します！プルリクエストの提出、問題報告、プロジェクトへの貢献方法については[Contributing Guidelines](https://raw.githubusercontent.com/jamubc/gemini-mcp-tool/main/CONTRIBUTING.md)をご覧ください。

## ライセンス

本プロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご参照ください。

**免責事項:** これは非公式のサードパーティ製ツールであり、Googleとは提携、支持、スポンサー関係にありません。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---