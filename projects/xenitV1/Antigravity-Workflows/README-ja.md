# アンチグラビティワークフロー - AIエージェントスキルシステム

> アンチグラビティIDE向けの包括的なAIエージェントスキルシステム。ルール、ワークフロー、スキルを自動起動で含みます。
> **注意:** アンチグラビティはエージェントとスキル機能に基づいて再編成されました。マエストロスキルとエージェント構造が完全に統合されています。
> 参考: [Claude Code Maestro](https://github.com/xenitV1/claude-code-maestro)

---

## 🚀 インストール

### Windows (PowerShell)

```powershell
# 1. Create directories
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\antigravity"
New-Item -ItemType Directory -Force -Path "$HOME\.gemini\global_workflows"
New-Item -ItemType Directory -Force -Path "$HOME\.agent"

# 2. GEMINI.md -> ~/.gemini/
Copy-Item ".\GEMINI.md" "$HOME\.gemini\GEMINI.md"

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
Copy-Item ".\global_workflows\*" "$HOME\.gemini\global_workflows\"

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
Copy-Item -Recurse ".\skills" "$HOME\.gemini\antigravity\"

# 5. Agents -> ~/.agent/
Copy-Item ".\.agent\*" "$HOME\.agent\" -Recurse
```

### macOS/Linux（Bash）

```bash
# 1. Create directories
mkdir -p ~/.gemini/antigravity
mkdir -p ~/.gemini/global_workflows
mkdir -p ~/.agent

# 2. GEMINI.md -> ~/.gemini/
cp GEMINI.md ~/.gemini/GEMINI.md

# 3. Global Workflows (Commands) -> ~/.gemini/global_workflows/
cp -r global_workflows/* ~/.gemini/global_workflows/

# 4. Antigravity System (Skills) -> ~/.gemini/antigravity/
cp -r skills ~/.gemini/antigravity/

# 5. Agents -> ~/.agent/
cp -r .agent/* ~/.agent/
```

---

## 📁 Post-Installation Structure

```
~/.gemini/                              # Global Config
├── GEMINI.md                           # Maestro Configuration
├── global_workflows/                   # Slash Commands (/)
│   ├── brainstorm.md                   # /brainstorm
│   ├── create.md                       # /create
│   └── ...
└── antigravity/                        # Core System
    └── skills/                         # Skill Library
        ├── ultrathink.md
        ├── architecture.md
        └── ...

~/.agent/                               # Agents
└── agents/                             # 16 Specialized Agents
    ├── orchestrator.md
    ├── backend-specialist.md
    └── ...
```

---

## 🤖 利用可能なエージェント（16）

| エージェント | ドメインとフォーカス |
|-------|----------------|
| `orchestrator` | マルチエージェントの調整と統合 |
| `project-planner` | 発見、アーキテクチャ、タスク計画 |
| `backend-specialist` | バックエンドアーキテクト（API + データベース + サーバー） |
| `database-architect` | データベーススキーマ、SQL最適化 |
| `frontend-specialist` | フロントエンド＆グロース（UI/UX + SEO） |
| `mobile-developer` | モバイルスペシャリスト（クロスプラットフォーム） |
| `game-developer` | ゲームロジック＆アセット＆パフォーマンス |
| `security-auditor` | サイバーセキュリティ監査 |
| `debugger` | 根本原因分析＆バグ修正 |
| `devops-engineer` | CI/CD、インフラ、デプロイメント |
| `documentation-writer` | 技術ドキュメント作成 |
| `explorer-agent` | 発見、ファイルリスト、分析 |
| `penetration-tester` | 攻撃的セキュリティ |
| `performance-optimizer` | 速度、重要指標 |
| `seo-specialist` | SEO、GEO、分析 |
| `test-engineer` | テスト戦略、E2E、ユニットテスト |

---

## ⚡ スラッシュコマンド（10）

| コマンド | 説明 |
|---------|-------------|
| `/brainstorm` | 構造化されたブレインストーミング |
| `/create` | 新規アプリケーション作成 |
| `/debug` | デバッグとトラブルシューティング |
| `/deploy` | 本番環境へのデプロイ |
| `/enhance` | 機能の追加/更新 |
| `/orchestrate` | マルチエージェントの調整 |
| `/plan` | タスク計画 |
| `/preview` | プレビューサーバー管理 |
| `/status` | プロジェクトステータス表示 |
| `/test` | テスト生成と実行 |

---

## 📚 スキル（35カテゴリ）

スキルは `~/.gemini/antigravity/skills/` に整理されており、以下をカバーしています：
- **開発:** `clean-code`、`react-patterns`、`python-patterns`
- **アーキテクチャ:** `architecture`、`api-patterns`、`database-design`
- **品質:** `testing-patterns`、`code-review-checklist`、`tdd-workflow`
- **セキュリティ:** `vulnerability-scanner`、`red-team-tactics`
- **パフォーマンス:** `performance-profiling`、`tailwind-patterns`
- **SEO/GEO:** `seo-fundamentals`、`geo-fundamentals`
- **DevOps:** `deployment-procedures`、`server-management`

_完全なリストは `ARCHITECTURE.md` を参照してください。_

---

## 🎯 主な特徴

- ✅ **16の専門エージェント** による異なる開発領域の対応
- ✅ **35のスキルカテゴリ** でフルスタック開発を網羅
- ✅ **10のスラッシュコマンド** による効率的なワークフロー
- ✅ **Maestro v4.1 標準** を統合
- ✅ **動的ユーザーパス**（`~/.agent/`、`~/.gemini/antigravity/`）
- ✅ **クリーンコードの遵守** を全体で強制

---

## 📖 ドキュメント

- **[ARCHITECTURE.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/ARCHITECTURE.md)** - システム全体構造
- **[GEMINI.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/GEMINI.md)** - Maestroの設定とルール
- **[CHANGELOG.md](https://raw.githubusercontent.com/xenitV1/Antigravity-Workflows/main/CHANGELOG.md)** - バージョン履歴

---

## 📄 ライセンス

MITライセンス

---

**開発者:** [@xenit-v0](https://x.com/xenit_v0)
**バージョン:** 0.2.2 (Antigravity IDE ネイティブサポート)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---