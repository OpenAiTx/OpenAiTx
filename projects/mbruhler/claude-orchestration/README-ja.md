# 🎭 Claude Code用オーケストレーションプラグイン

> _Claude CodeのN8Nのように_

### プロジェクトが気に入ったら、ぜひ⭐をお願いします！<br/>

## **マルチエージェントワークフローオーケストレーション。** 自然言語や宣言的構文を使ってAIエージェントを連鎖させ、複雑なタスクを自動化します。

[![Claude Code](https://img.shields.io/badge/Claude%20Code-Compatible-blue)](https://claude.com/claude-code)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

---

## インストール

### 1. プラグインマーケットプレイスを追加

まず、あなたのClaude Codeにオーケストレーションマーケットプレイスを追加します：

```bash
/plugin marketplace add mbruhler/claude-orchestration
```

### 2. プラグインのインストール

```bash
/plugin install orchestration@mbruhler
```

またはインタラクティブメニューを使用してください：

```bash
/plugin
```

次に **「プラグインを参照」** を選択 → **orchestration** を見つける → **インストール**

### 3. インストールの確認

プラグインがインストールされていることを確認してください：

```bash
/help
```

`/orchestration:menu`、`/orchestration:init`などのオーケストレーションコマンドが表示されるはずです。

---

## クイックスタート

### 0. カスタムエージェントのインポート（任意）
```
/orchestration:init
```

カスタムエージェントを `~/.claude/agents/` からオーケストレーションプラグインにインポートします。

**例：**
```
/orchestration:init
→ Select agents to import
→ Agents become available as expert-code-implementer, etc. and the plugin can create workflows using them
```

### 1. 自然言語
```
"Create a workflow that fetches 10 Reddit posts about startups,
analyzes competition, and shows a ratings table"
```

プラグイン：
- ✅ 必要な一時スクリプト（Python/Node.js）を作成します
- ✅ クリック可能な質問を通じて案内します
- ✅ 最適化されたワークフローを生成および実行します
- ✅ フォーマットされた結果を返します

### 2. 直接構文
```flow
# Parallel bug investigation
[
  Explore:"Find related code":code ||
  general-purpose:"Check recent changes":changes ||
  general-purpose:"Search similar issues":similar
] ->
general-purpose:"Identify root cause from {code}, {changes}, {similar}":analysis ->
@review:"Approve fix?" ->
general-purpose:"Implement fix and run tests":fix ->
general-purpose:"Commit changes with detailed message"
```

### 3. テンプレート
```
"Use the TDD implementation template"
```

---

## コア機能

### フロー制御
```flow
# Sequential
step1 -> step2 -> step3

# Parallel
[task1 || task2 || task3]

# Conditional
test -> (if passed)~> deploy
     -> (if failed)~> rollback
```

### 自動温度スクリプト
以下のためにPython/Node.jsスクリプトを自動生成します：
- 🌐 ウェブスクレイピング（BeautifulSoup、Selenium）
- 📡 API（Reddit、Twitter、GitHub）
- 📊 データ処理（pandas、NumPy）
- 🗄️ データベースクエリ

### 手動チェックポイント
```flow
build:"Compile app" ->
@review:"Check output. Continue?" ->
deploy:"Deploy to production"
```

### ビジュアルプログレス
```
╔════════════════════════════════════╗
║  TDD Implementation                ║
╠════════════════════════════════════╣
║    [Write Test] ●                  ║
║         │                          ║
║    [Implement] ○                   ║
║         │                          ║
║    [@Review] ○                     ║
╠════════════════════════════════════╣
║ Status: Writing test...            ║
╚════════════════════════════════════╝
```

---

## 構文リファレンス

| 構文 | 意味 | 例 |
|--------|---------|---------|
| `->` | 逐次 | `step1 -> step2` |
| `||` | 並列 | `[step1 \|\| step2]` |
| `~>` | 条件付き | `(if passed)~> next` |
| `@label` | チェックポイント | `@review-code` |
| `:var` | 出力のキャプチャ | `analyze:"task":result` |
| `{var}` | 変数の使用 | `"Process {result}"` |
| `$agent` | 一時エージェント | `$scanner:"Scan"` |

---

## 組み込みエージェント

- **Explore** - 高速なコードベースの探索と検索
- **Plan** - タスクの計画と分解
- **general-purpose** - 複雑な多段階タスクに対応する多用途エージェント

---

## 例

### Reddit スタートアップアナライザー
```flow
general-purpose:"Create Python PRAW script to fetch 10 r/startups posts.
                 Return JSON with title, url, description":posts ->

[
  general-purpose:"Research competition for post {posts[0]}":a1 ||
  general-purpose:"Research competition for post {posts[1]}":a2 ||
  # ... parallel analyses
] ->

general-purpose:"Rate ideas (1-10) on competition, market, feasibility.
                 Create markdown table":ratings ->

@review:"Review {ratings}. Ban any?" ->

general-purpose:"Generate top 3 opportunities summary"
```

### TDD 実装
```flow
# RED: Write failing test
general-purpose:"Write failing test for the feature":test ->
general-purpose:"Run test suite - verify it fails":red_result ->
@review-coverage:"Test coverage sufficient?" ->

# GREEN: Minimal implementation
general-purpose:"Write minimal code to pass the test":impl ->
general-purpose:"Run test suite - verify it passes":green_result ->
@review:"Code quality OK?" ->

# REFACTOR: Clean up
general-purpose:"Refactor code and add documentation":refactored ->
general-purpose:"Final test run and commit"
```

### バグ調査
```flow
# Parallel investigation
[
  Explore:"Find error pattern in codebase":code ||
  general-purpose:"Analyze error logs":logs ||
  general-purpose:"Check recent commits":commits ||
  general-purpose:"Search for similar bugs":known
] ->

# Diagnosis
general-purpose:"Identify root cause from {code}, {logs}, {commits}, {known}":cause ->
@review:"Diagnosis correct?" ->

# Fix with testing
general-purpose:"Write regression test for the bug":test ->
general-purpose:"Implement fix":fix ->

# Verification
[
  general-purpose:"Run regression test" ||
  general-purpose:"Run full test suite" ||
  general-purpose:"Perform smoke test"
] ->

@review:"Approve deployment?" ->
general-purpose:"Commit with detailed bug fix message"
```

---

## Project Structure

```
orchestration/
├── skills/              # Auto-activating skills
│   ├── creating-workflows/
│   ├── executing-workflows/
│   ├── managing-agents/
│   ├── managing-temp-scripts/
│   ├── designing-syntax/
│   ├── debugging-workflows/
│   └── using-templates/
├── agents/              # Permanent agents
├── temp-agents/         # Ephemeral (auto-cleaned)
├── temp-scripts/        # Generated scripts
├── examples/            # Templates (.flow)
└── docs/                # Documentation
```

---

## 上級

### 単独実行
```bash
# Headless (no checkpoints)
claude -p "Execute @examples/tdd-implementation.flow"

# With parameters
claude -p "/orchestration:run $(cat workflow.flow)" \
  --output-format json
```

### エージェント昇進
```
Workflow complete!

Temp agents: security-scanner, api-wrapper

Save as permanent?
[Save all] [Save security-scanner] [Delete all]
```

### テンプレートパラメーター
```yaml
---
name: api-integration
parameters:
  - API_URL: "https://api.example.com"
  - NUM_ITEMS: 10
---

workflow: |
  general-purpose:"Fetch {{NUM_ITEMS}} from {{API_URL}}":data ->
  general-purpose:"Format results":output
```

---

## トラブルシューティング

**ワークフローが停止する**
→ チェックポイントがユーザーの応答を必要としているか、ヘッドレス用に削除してください

**一時スクリプトが失敗する**
→ `temp-scripts/` に生成されたファイルを確認してください
→ API認証情報と依存関係を検証してください

**エージェントが見つからない**
→ 組み込み: 正確な名前（Explore、general-purpose）
→ プラグイン: `orchestration:` プレフィックスを使用
→ 一時: `$` プレフィックスを使用

## スター履歴

[![スター履歴チャート](https://api.star-history.com/svg?repos=mbruhler/claude-orchestration&type=date&legend=top-left)](https://www.star-history.com/#mbruhler/claude-orchestration&type=date&legend=top-left)

---

## サポート

- 📖 [ドキュメント](docs/)
- 💬 [ディスカッション](https://github.com/anthropics/orchestration/discussions)
- 🐛 [イシュー](https://github.com/anthropics/orchestration/issues)

---

**MITライセンス** | Claude Codeコミュニティのために作成


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-04

---