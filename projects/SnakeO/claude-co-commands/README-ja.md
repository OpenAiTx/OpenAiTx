# Claude Co-Commands プラグイン

Claude Code 用の3つのコラボレーションコマンドで、[Codex MCPサーバー](https://github.com/openai/codex)を利用して並列プランの生成、プランの検証、アイデアのブレインストーミングを行います。

## コマンド

| コマンド | 説明 | 使用タイミング |
|---------|-------------|-------------|
| `/co-brainstorm` | Codexにアイデアをぶつける | 迅速な代替案、批評、視点が欲しいとき |
| `/co-plan` | Codexを使って並列プランを生成 | 計画アプローチのセカンドオピニオンが欲しいとき |
| `/co-validate` | スタッフエンジニアによるプランレビューを取得 | プランを確定する前に重要なフィードバックが欲しいとき |

## 前提条件

- [Node.js](https://nodejs.org/) (`npx`用)
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code)

## インストール

### オプション1: プラグインマーケットプレイス（推奨）

```bash
# Add the marketplace
/plugin marketplace add SnakeO/claude-co-commands

# Install the plugin
/plugin install co-commands@snakeo-co-commands
```

### オプション 2: Git クローン

```bash
git clone https://github.com/SnakeO/claude-co-commands.git
# Copy skill folders to ~/.claude/skills/
cp -r claude-co-commands/plugins/co-commands/skills/* ~/.claude/skills/
```

### オプション3: 手動コピー

`plugins/co-commands/skills/` の内容を `~/.claude/skills/` にコピーします。

## MCPサーバー設定（必須）

これらのコマンドはCodex MCPサーバーが必要です。

### オプションA: CLI（推奨）

```bash
claude mcp add validate-plans-and-brainstorm-ideas -- npx -y @openai/codex mcp-server
```

### オプションB：手動

これを `~/.claude.json` の `mcpServers` オブジェクトに追加します:

```json
"validate-plans-and-brainstorm-ideas": {
  "command": "npx",
  "args": ["-y", "@openai/codex", "mcp-server"]
}
```
もし既に `mcpServers` にエントリがある場合は、これを追加のキーとしてマージしてください。既存のサーバーを上書きしないでください。

### 確認

1. Claude Codeを再起動します（`~/.claude.json` を手動で編集した場合）。
2. `claude mcp list` を実行して、サーバーが登録されていることを確認します。
3. `/co-brainstorm test idea` でテストし、MCP呼び出しがトリガーされることを確認します。

## コマンド詳細

### `/co-brainstorm`

Codexと対話型のブレインストーミングセッションを開始します。トピックや質問を引数として渡してください。


```
/co-brainstorm how should we structure the authentication system
```

Supports follow-up conversation to dig deeper into ideas.

### `/co-plan`

Generates an alternative plan in the background while you continue your own planning. Pass your task description as the argument.

```
/co-plan add user authentication with OAuth2 support
```

Codexの計画と自分の計画を比較して、見落としたアプローチ、より簡単な代替案、または見逃したエッジケースを見つけます。

### `/co-validate`

あなたの計画をスタッフエンジニア風のレビューのためにCodexに送信します。計画ファイルのパスを渡してください。

```
/co-validate .claude/plans/my-plan.md
```
重要な問題、簡素化の機会、および代替アプローチを返します。双方向の議論をサポートします。

## トラブルシューティング

| 問題 | 解決策 |
|---------|----------|
| `npx: command not found` | npm/npxを含む[Node.js](https://nodejs.org/)をインストールしてください |
| セッションでMCPツールが見つからない | `~/.claude.json`内のサーバー名が正確に`validate-plans-and-brainstorm-ideas`であることを確認してください |
| `~/.claude.json`のJSON解析エラー | JSONを検証してください（カンマと中括弧を確認） |
| インストール後にコマンドが表示されない | Claude Codeを再起動し、スキルフォルダが存在することを確認してください |

## ライセンス

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---