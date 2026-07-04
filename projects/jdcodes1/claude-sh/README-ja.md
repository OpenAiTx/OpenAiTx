# claude.sh

Claudeコードをbashスクリプトに書き直しました。約1,500行。npmパッケージは一切使用していません。

## なぜ

元のClaudeコードは約380,000行のTypeScriptで、266のnpm依存関係があります。これはcurlとjqだけでbashで同じコア機能を実現しています。

## 特徴

- **リアルタイムストリーミング** FIFOパイプ経由 — Claudeが生成するテキストがリアルタイムで表示されます
- **6つのツール**: Bash, Read, Edit, Write, Glob, Grep
- **ツールチェーン** — 1ターンあたり最大25回のツール呼び出し
- **権限プロンプト** — 安全でないコマンド実行前に確認（`y/n/a`）
- **CLAUDE.md読み込み** — ディレクトリ階層を遡ってCLAUDE.mdファイルからプロジェクト指示を読み込み
- **Git対応コンテキスト** — システムプロンプトにブランチ、ステータス、最新コミットを表示
- **セッション保存/再開** — 終了時に自動保存、`--resume <id>`で再開可能
- **バックオフ付きリトライ** — 429/529レート制限時に指数関数的リトライ
- **コスト追跡** — ターンごとおよびセッション合計
- **スピナー** — オリジナルのスピナーワード（Clauding, Flibbertigibbetingなど）
- **スラッシュコマンド** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **パイプモード** — `echo "explain this" | ./claude.sh`

## インストール

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## 依存関係

- `curl`
- `jq`
- オプション: より良い検索のための `rg` (ripgrep)
- オプション: 編集ツール用の `python3`

実行時バージョンは `.tool-versions` に固定されています。[mise](https://mise.jdx.dev/) でインストールしてください：

```bash
mise install
```

## 使い方

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### 環境変数

| 変数 | デフォルト | 説明 |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (必須) | あなたのAnthropic APIキー |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | 使用するモデル |
| `CLAUDE_MAX_TOKENS` | `8192` | 最大出力トークン数 |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | APIのベースURL |
| `CLAUDE_SH_PERMISSIONS` | `ask` | 許可モード：`ask`、`allow`、または`deny` |

### コマンド

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### セッションを再開する

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## アーキテクチャ

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## 仕組み

1. ユーザー入力を読み取る
2. `jq` を使ってJSONリクエストを構築（メッセージ、ツール、システムプロンプト）
3. `curl` を通じてFIFOパイプでレスポンスをストリーミング
4. SSEイベントを1行ずつ解析し、テキストの差分をリアルタイムで表示
5. tool_use ブロックが到着したらツールを実行
6. ツールの結果をメッセージとしてフィードバック
7. Claudeがツール呼び出しを停止するまでループ

## 比較

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| コード行数 | 約1,500行 | 約380,000行 |
| 依存関係 | curl, jq | 266 npmパッケージ |
| バイナリサイズ | 0（スクリプト） | 約200MB node_modules |
| 起動時間 | 即時 | 約500ms |

### テスト

テストは [bats](https://github.com/bats-core/bats-core)（Bash Automated Testing System）を使用：

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-04

---