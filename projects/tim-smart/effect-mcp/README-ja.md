
# effect mcp サーバー

[![MCPサーバーをインストール](https://cursor.com/deeplink/mcp-install-dark.svg)](https://cursor.com/install-mcp?name=effect%20docs&config=eyJjb21tYW5kIjoibnB4IC15IGVmZmVjdC1tY3AifQ%3D%3D)

このMCPサーバーはEffectのドキュメントにアクセスするためのツールとリソースを追加します。

## 使い方

以下のコマンドでdockerを使って実行できます:


```bash
docker run --rm -i timsmart/effect-mcp
```
npxを使用することもできます:


```bash
npx -y effect-mcp
```
## Claude Code 統合

Claude Code でこの MCP サーバーを使用するには、次のコマンドを実行してください:


```bash
claude mcp add-json effect-docs '{
  "command": "npx",
  "args": [
    "-y",
    "effect-mcp"
  ],
  "env": {}
}' -s user
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---