
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code を bash スクリプトとして書き直しました。約1,500行。npm パッケージはゼロ。

## なぜ

元の Claude Code は約380,000行の TypeScript で、266個の npm 依存があります。これは同じコアの役割を bash で `curl` と `jq` のみを使って実現しています。

## 機能

- **リアルタイムストリーミング**（FIFOパイプ経由）— Claudeが生成するテキストが即時に表示
- **6つのツール**: Bash、Read、Edit、Write、Glob、Grep
- **ツールの連鎖** — 1ターンにつき最大25回のツール呼び出し
- **権限確認プロンプト** — 安全でないコマンド実行前に確認（`y/n/a`）
- **CLAUDE.md読込** — ディレクトリツリー上のCLAUDE.mdファイルからプロジェクト指示を読込
- **Git対応コンテキスト** — システムプロンプトにブランチ、ステータス、最近のコミットを表示
- **セッション保存／再開** — 終了時に自動保存、`--resume <id>`で再開
- **バックオフ付きリトライ** — 429/529レート制限時に指数的リトライ
- **コスト追跡** — ターンごと、セッションごとの合計
- **スピナー** — オリジナルのスピナーバーブ（Clauding, Flibbertigibbeting等）搭載
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---