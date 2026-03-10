# claude-swift-engineering

[![License](https://img.shields.io/badge/license-MIT-green)](#) [![Platform](https://img.shields.io/badge/platform-iOS%2026%2B%20%7C%20macOS-blue)](#)

> モダンな Swift/SwiftUI 開発のための Claude Code プラグインマーケットプレイス

モダンな Swift 6.2、TCA（The Composable Architecture）、および SwiftUI を使用してプロフェッショナルな iOS/macOS 機能を構築するための専門的な AI ツールキットです。このプラグインは、計画、実装、テスト、および展開を調整する超専門化エージェントを提供します。

## Swift Engineering Plugin

**swift-engineering プラグイン** は、プロフェッショナルな Swift 開発のための本番対応ツールキットです：

- **12 の超専門化エージェント** — 計画（Opus）、実装（Inherit）、ユーティリティ（Haiku）による明確な引き継ぎ
- **TCA サポート** — The Composable Architecture のアーキテクチャ設計からテストまでのフルワークフロー
- **モダン Swift 6.2** — 厳密な並行処理、async/await、アクター、Sendable を備えた iOS 26+ 対応
- **コード品質** — 統合されたコードレビュー、アクセシビリティ準拠、およびパフォーマンスチェック
- **知識スキル** — アーキテクチャパターン、フレームワーク、デザイン、開発ツールを網羅した18の専門知識ベース

## クイックスタート

### インストール

Claude Code にプラグインを追加してください：

```bash
# Add marketplace source
/plugin marketplace add https://github.com/johnrogers/claude-swift-engineering

# Install swift-engineering plugin
/plugin install swift-engineering
```

### フック（オプション）

スキル/エージェント評価フックを有効にして、より良いワークフローディシプリンを実現します：

```bash
# 1. Symlink hooks-scripts to ~/.claude
ln -s /path/to/claude-swift-engineering/plugins/swift-engineering/hooks-scripts ~/.claude/hooks-scripts

# 2. Add to ~/.claude/settings.json
{
  "hooks": {
    "UserPromptSubmit": [
      {
        "hooks": [
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/skill-forced-eval-hook.sh"
          },
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/agent-forced-eval-hook.sh"
          }
        ]
      }
    ]
  }
}
```
完全なフックのドキュメントについては、[plugins/swift-engineering/hooks-scripts/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/hooks-scripts/README.md) を参照してください。

エージェントの使用方法および利用可能なワークフローについての完全なドキュメントは、[plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) を参照してください。

## 含まれる内容

### 12の専門エージェント

| 種類 | エージェント | 責任範囲 |
|------|--------------|------------|
| **プランニング** | @swift-ui-design, @swift-architect, @tca-architect | アーキテクチャの決定（Opus、読み取り専用） |
| **実装** | @tca-engineer, @swift-engineer, @swiftui-specialist, @swift-test-creator, @documentation-generator, @swift-code-reviewer, @swift-modernizer | コード作成とレビュー（継承） |
| **ユーティリティ** | @swift-documenter, @search | APIドキュメントとコード検索（Haiku） |

### 18の知識スキル

アーキテクチャパターン（TCA、SwiftUI、モダンスウィフト、高度なジェスチャー）、フレームワーク（SQLite、GRDB、StoreKit、ネットワーキング）、プラットフォーム設計（iOS 26、HIG、ローカリゼーション、ハプティクス）、および開発ツール（テスト、スタイル、診断）。各スキルは最新パターンとベストプラクティスに関する深い指導を提供します。

## コントリビューター向け

### リポジトリ構成


```
claude-swift-engineering/
├── .claude-plugin/
│   └── marketplace.json                    # Marketplace configuration
├── .github/workflows/                      # CI/CD pipelines
├── plugins/
│   └── swift-engineering/                  # Main plugin
│       ├── agents/                         # 12 specialized agents
│       ├── skills/                         # 18 comprehensive skills
│       ├── hooks-scripts/                  # Hooks system
│       ├── scripts/                        # Helper utilities
│       ├── rules/                          # Development rules
│       └── README.md                       # Plugin documentation
└── worktrees/                              # Git worktrees for features
```

### 開発ワークフロー

#### バージョンの更新

変更を加える際は、プラグインのバージョンをインクリメントしてください：

```bash
bash plugins/swift-engineering/scripts/bump-plugin-version.sh <new-version>
```
この更新は、plugin.json、marketplace.json、およびその他のメタデータファイル全体のバージョン番号を更新します。

#### エージェントまたはスキルの追加

1. 既存のパターンに従って新しいエージェントまたはスキルファイルを作成します（`agents/` または `skills/` の例を参照）
2. 新しいツール機能を定義する場合は `plugin.json` を更新します
3. 設定を検証するためにスモークテストを実行します
4. 両方のREADMEファイル（ルートとプラグイン）を更新します
5. ワークフローとの統合をテストします

### コードの構成

- **エージェント**（`agents/`） — 各エージェントはメタデータと指示を含む `.md` ファイルを持ちます
- **スキル**（`skills/`） — エージェントが参照する知識リソースをトピック別に整理
- **フック**（`hooks-scripts/`） — ワークフローを強制する実行可能フック
- **スクリプト**（`scripts/`） — 自動化用のユーティリティシェルスクリプト
- **ルール**（`rules/`） — 開発慣行および意思決定フレームワーク
- **ドキュメンテーション**（`docs/`） — スモークテストと検証スイート

## アーキテクチャと設計原則

このプラグインは以下の主要な原則を実装しています：

- **ウルトラ専門化** — 各エージェントは明確な責任を持ち、引き継ぎを定義
- **モデルの階層化** — Opusはアーキテクチャ用（最良の推論）、Inheritは実装用（コスト効率）、Haikuはユーティリティ用（高速）
- **ローカルファースト** — デフォルトはSQLiteとUserDefaults、SwiftDataやCore Dataは使用しない
- **モダンSwiftのみ** — Swift 6.2で厳格な並行処理、非推奨APIなし
- **読み取り専用の計画** — 計画エージェントはコードを変更できず、明確な分離を保証
- **計画ファイルの調整** — エージェントは `docs/plans/<feature>.md` を介して状態を共有

アーキテクチャの詳細、ワークフローダイアグラム、引き継ぎモデルについては [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) を参照してください。

## ライセンス

MITライセンス — 詳細は [LICENSE](LICENSE) ファイルを参照してください。

## クレジット

**著者：** John Rogers

**リポジトリ:** claude-swift-engineering  
**Swift バージョン:** 6.2+  
**iOS デプロイメントターゲット:** 26.0+  

---  

詳細なドキュメント、エージェント仕様、および使用例については、[plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---