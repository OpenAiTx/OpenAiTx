# AIアシスタント向け強化PubChem MCPサーバー

🧪 高度で堅牢かつプライバシー重視のMCPサーバーで、AIアシスタントがPubChemから化合物情報を賢く検索・取得できます。

このPubChem MCPサーバーは、AnythingLLMのようなAIアシスタントとPubChemの膨大な化学データベースをつなぐ強力な橋渡し役です。Model Context Protocol（MCP）を活用し、AIモデルが化合物をスマートかつ堅牢に検索し、詳細な特性をプログラム的に取得できるようにします。

---

## ✨ コア機能

単なるPubChemラッパーではありません。このサーバーは根本から再構築され、高度な堅牢性と知能性を備えています：

-   **🧠 スマートフォールバック検索**：一般名（例：「ビタミンD」）での検索が失敗した場合、自動的にPubChem Substanceデータベースでより深い検索を行い、正しい化合物を見つけます。これにより曖昧なクエリの成功率が飛躍的に向上します。
-   **🛡️ 堅牢なエラー処理とリトライ**：APIエラーに対しても優雅に対応できる設計です。PubChemから「サーバービジー」エラーが返ってきた場合、自動的に待機してリクエストを再試行し、負荷が高い状況でもクエリの成功を保証します。
-   **🔒 オプションのTorプロキシサポート**：プライバシーを完全にコントロール可能です。シンプルな`config.ini`ファイルで全リクエストをTorネットワーク（SOCKS5またはHTTPプロキシ経由）にルーティングでき、IPアドレスの露出を防ぎます。サーバーはデフォルトで安全設計されており、プロキシ接続に失敗してもIPを**絶対に**漏らしません。
-   **🔎 単一・複数化合物検索**：1件または複数の化合物を1つのプロンプトでシームレスに処理します。
-   **🧪 詳細な特性取得**：IUPAC名、分子式、分子量、そして特に**単一同位体質量**といった重要な化学特性にアクセス可能です。

---

---

### 🚀 インストール不要：Smithery.aiでライブ体験

MCPサーバーが初めての方やローカル環境を用意せずにこのツールの機能を試したい方のために、Smithery.aiでホストされたライブ版をご用意しています。ブラウザ上で直接エージェントとチャット可能です。

[**<-- Smithery.aiのライブPubChemエージェントを試す -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**始め方：**

1.  上記リンクをクリックしてサーバーページにアクセス。
2.  **GitHub**または**Google**アカウントでサインイン。
3.  **「Explore capabilities」**ボタンをクリックし、チャットインターフェイスを開いてテスト開始！

> **✅ 最良の結果を得るための推奨モデル**
>
> 特に長い小数点数の精度を求める場合は、高性能モデルの使用を強く推奨します。以下のモデルはテスト済みで、このツールと非常に相性が良いです：
>
> *   **AnthropicのClaude 3 Sonnet**
> *   **OpenAIのGPT-4 Turbo**（またはGPT-4oなどの新バージョン）
>
> 両モデルとも、ツールから返された小数点以下の数値の完全な精度を正しく処理し、丸めを行わなかったことを確認しました。

---

## 🚀 クイックスタートとインストール

このサーバーは、ローカル環境（デスクトップまたはAnythingLLM Docker環境内）で実行することを想定しています。

### 1. 依存関係

このプロジェクトは、いくつかのPythonライブラリに依存しています。環境にインストールされていることを確認してください。

以下の内容で `requirements.txt` ファイルを作成してください。
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

`uv`または`pip`を使用してインストールします：
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(注：`PySocks`はTorのSOCKS5プロキシ機能を使用する場合にのみ必要です。)*

### 2. 設定

サーバーは`config.ini`ファイルで設定され、最初に実行した際に**自動的に作成されます**。このファイルは`pubchem_server.py`スクリプトと同じディレクトリに生成されます。

**デフォルトの`config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. AnythingLLMとの統合

公式ドキュメントに従って、これをカスタムMCPサーバーとして追加してください。重要なのは、`command`をPython実行ファイルと`pubchem_server.py`スクリプトに指定することです。

**AnythingLLMデスクトップ用の例（`plugins/anythingllm_mcp_servers.json`）：**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 AnythingLLMを用いた実装例

エージェントとどのように対話するかの例をいくつか示します。これらのテストは、AnythingLLM Desktopを使用し、OpenRouter経由でさまざまな大規模言語モデルに接続して実施されました。

テストから得られた重要な発見は、選択するモデルの重要性です。このタスクには**小型またはローカルモデルの使用を強くお勧めしません**。小型モデルは、ツールから返されるデータを正しく解析できないことが多く、幻覚値、不正確なフォーマット、そして最も重要なことに**小数点数の丸め**などのエラーを引き起こし、この高精度ツールの目的を損ないます。

結果の整合性を確保するために、MCPから返される生データを常に検証することをお勧めします。その方法は次のセクションで学べます：[3.2 ログでのMCP出力の検証方法](#32-how-to-verify-mcp-outputs-in-the-logs)。

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

一方、いくつかのモデルは優れたパフォーマンスを示しました。特に**Googleの`Gemini 2.5 Flash lite`**は、長い小数点数の扱いにおいて卓越した精度を示し、最終的なMarkdownテーブルの正しいフォーマットを実現しました。

Google gemini 2.5 flash liteはプロンプトなしおよびプロンプトありで、完璧な小数点を保持します（例では温度パラメータを0.6に設定しています）。

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

この特定のタスクにおいて、私の個人的なお気に入りは一貫した精度と信頼性のために**`Gemini 2.5 Flash lite`**です。

### 3.2 ログでのMCP出力の検証方法

エージェントが正しいデータを受け取り、LLMが誤りを犯していないことを確認する最良の方法は、MCPサーバーによって生成されるデバッグログファイルを確認することです。

このサーバーは、プロジェクトディレクトリ内のサブフォルダに自動的にログファイルを作成するよう設定されています。場所は以下の通りです：

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

`mcp_debug.log`の中には、ツールがモデルが処理する*前に*LLMに返す正確なJSONデータが含まれています。このJSONを手動で検査して、特に`monoisotopic_mass`のようなプロパティの長い小数点数値を確認し、LLMが最終回答で丸め誤差や幻覚を導入していないことを検証できます。

---

## 📊 使用方法

統合後、あなたのAIアシスタントは化学情報に関する質問があった際に自動的にこのツールを使用します。主に公開されているツールは`search_compounds_by_name`です。

### 使用例プロンプト

このプロンプトは、異なる名前タイプの化合物のリストを処理し、複数のプロパティを取得するツールの能力を示しています。

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
エージェントは `search_compounds_by_name` ツールを呼び出し、各化合物をインテリジェントに検索し、そのデータを取得してLLMにフォーマットのために返します。

---

## 🛠 MCPツールの公開

### `search_compounds_by_name`

名前で複数の化合物を1つずつ検索し、最大の信頼性を確保するためにポーズとリトライを組み合わせたスマートなフォールバック戦略を使用します。

**パラメータ:**
-   `names` (List[str]): 化合物名のリスト。例: `["Aspirin", "Ibuprofen"]`

**戻り値:** 各化合物の情報が含まれる辞書、または特定の化合物の検索が失敗した理由を詳細に記述したエラーメッセージを含む辞書のリスト。

---

## 🙏 謝辞

このプロジェクトは、**JackKuo666** によって作成されたオリジナルの [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) を大いに参考にし、その基盤の上に構築されました。

このリポジトリは直接のフォークではありませんが、オリジナルプロジェクトが重要な出発点でした。本バージョンは、極めて堅牢な設計、インテリジェントな検索戦略、そしてオプションのTor統合によるユーザープライバシーの強化に重点を置いてオリジナルのコンセプトを拡張しています🧅。

オリジナル作者の素晴らしい仕事とコミュニティへの共有に深く感謝します。

---

## ⚠️ 免責事項

このツールは研究および教育目的での利用を意図しています。PubChemの利用規約を尊重し、責任を持ってご使用ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---