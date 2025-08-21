# mcp-chat

MCPサーバーとエージェントのテストおよび評価のためのオープンソース汎用MCPクライアント

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## クイックスタート

環境変数またはプロジェクトルートの.envファイルに`ANTHROPIC_API_KEY`が設定されていることを確認してください。APIキーは[Anthropicコンソールのキー設定ページ](https://console.anthropic.com/settings/keys)でサインアップして取得できます。

CLIからファイルシステムMCPサーバーと対話型チャットプロンプトを起動する簡単な使用例：

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

これにより、サーバーと対話し、LLMとチャットするためのチャットプロンプトが開きます。

## 設定

Macの場合、claude_desktop_config.jsonを指定することもできます：

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```
または（Windows）：


```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

ウェブモードでは、新しいチャットを開始したり、モデルにメッセージを送信したり、UIを介して動的にmcpサーバーを設定したりできます - コマンドラインで指定する必要はありません。さらに、Web UI経由で作成されたチャットは、CLI経由で作成されたチャットと同様に~/.mcpchats/chatsに保存されます。

## 特徴

- [x] 対話モードでCLI経由で実行、または`-p`でプロンプトを直接渡す
- [x] Webインターフェースを介してモデルとチャットするWebモード`--web`
- [x] 本番環境または開発中に任意のMCPサーバー（JS、Python、Docker）に接続
- [x] `-m`でモデルを選択
- [x] `--system`でシステムプロンプトをカスタマイズ
- [x] 設定とともにチャット履歴を`~/.mcpchat/chats`に保存（Webチャットも含む）
- [x] コマンドを`~/.mcpchat/history`に保存・復元
- [x] チャット内でツール呼び出しの出力と引数を直接表示し、mcpサーバーのデバッグを支援

## CLIの使い方

`-p`フラグを使ってCLI経由でプロンプトを実行：

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

これは、kubernetes mcp-serverでプロンプトを実行し、stdoutで応答を受け取った後に終了します。

`-m` フラグを使ってCLI経由でチャットするモデルを選択してください：

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```
モデル `claude-3.5` を使用してチャットします。現在はAnthropicモデルのみがサポートされていることに注意してください。

カスタムシステムプロンプト：

`--system` フラグを使用してシステムプロンプトを指定できます：


```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## 環境変数

Mcp-chatは環境変数をmcpサーバーに渡すことをサポートしています。ただし、これはmcp仕様で標準化されておらず、他のクライアントは動的な環境変数の値を使用しない場合があります。標準的なstdio mcpクライアントについては[こちら](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666)を参照してください。

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## mcp-serversの開発者向け

ローカルでビルドしたpythonまたはnodeのmcp-serverを渡して、mcp-chatでテストすることができます：

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## 開発

依存関係をインストールし、CLIを実行します：

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
mcp-serverに接続しながらmcp-chatを開発するには、ビルドしてサーバーフラグ付きでCLIを実行します：


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

テスト：

```shell
bun run test
```

構築:

```shell
bun run build
```

公開：

```shell
bun run publish
```

Dockerの公開:

```shell
bun run dockerbuild
```

### プロジェクト構造

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## 新しいリリースの公開

[releases](https://github.com/Flux159/mcp-chat/releases) ページに移動し、「Draft New Release」をクリックし、「Choose a tag」をクリックして、「v{major}.{minor}.{patch}」のsemver形式で新しいバージョン番号を入力して新しいタグを作成します。次に、リリースタイトルに「Release v{major}.{minor}.{patch}」と記述し、必要に応じて説明や変更履歴を書いて「Publish Release」をクリックします。

これにより新しいタグが作成され、cd.ymlワークフローを通じて新しいリリースビルドがトリガーされます。成功すると、新しいリリースがnpmに公開されます。package.jsonのバージョンを手動で更新する必要はなく、ワークフローが自動的にpackage.jsonのバージョン番号を更新し、mainブランチにコミットをプッシュします。

## ライセンス

[MIT License](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---