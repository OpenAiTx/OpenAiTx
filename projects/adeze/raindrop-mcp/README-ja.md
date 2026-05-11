# Raindrop.io MCP サーバー

[![smithery badge](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm version](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude Desktop MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

シンプルな MCP サーバーで Raindrop.io を AI アシスタントに接続します。自然言語でブックマークの整理、検索、管理に使用できます。

## できること

- コレクションとブックマークの作成、更新、削除
- タグ、ドメイン、タイプ、日付などでブックマークを検索
- タグの管理（一覧表示、名前変更、統合、削除）
- ブックマークからハイライトを読み取る
- コレクション内のブックマークを一括編集
- 壊れたリンクと重複の監査、ゴミ箱の管理

## ツール

- **diagnostics** - サーバー診断情報とライブラリの健康状態メトリクス
- **collection_list** - すべてのコレクションをフラットリストで表示
- **get_collection_tree** - 完全なパンくずリスト付きの階層的なコレクション表示
- **collection_manage** - コレクションの作成、更新、削除
- **bookmark_search** - フィルター、タグ、ページネーションを使った高度な検索
- **bookmark_manage** - ブックマークの作成、更新、削除
- **get_raindrop** - ID で単一のブックマークを取得
- **list_raindrops** - ページネーション付きでコレクションのブックマークを一覧表示
- **get_suggestions** - URL またはブックマークの AI 支援による整理アドバイス（タグ/コレクション）
- **suggest_tags** - AI 支援の分析でブックマークメタデータから関連タグを提案
- **bulk_edit_raindrops** - 特定のコレクション内のブックマークを一括更新、移動、削除
- **tag_manage** - タグの名前変更、統合、削除
- **highlight_manage** - ハイライトの作成、更新、削除
- **library_audit** - 壊れたリンク、重複、タグなしアイテムのライブラリスキャン
- **empty_trash** - ゴミ箱を完全に空にする（確認が必要）
- **cleanup_collections** - 空のコレクションを削除（確認が必要）
- **remove_duplicates** - 安全な確認フローで重複ブックマークを検出・削除

## インストール

### クイックスタート（一行コマンド）
| ツール               | ワンライナーコマンド                                                 |
| :----------------- | :----------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp`  |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`             |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp` |
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                                |

> **注意**: `npx`経由でMCPサーバーを追加するツールでは、シェルまたはツールの環境設定に`RAINDROP_ACCESS_TOKEN`環境変数を設定している必要があります。

### Vercel Skills (npx skills)

このプロジェクトは[ Vercel Skills](https://github.com/vercel/skills)システムと互換性があります。必要なマニフェストはすべて揃っています：

- `manifest.json`: サーバー定義用の標準MCPマニフェスト。
- `SKILL.md`: エージェント発見用の標準化されたスキル説明。
- `mcp.json`: MCPクライアントおよびレジストリ用のルート設定。

このサーバーをローカルのスキルディレクトリに追加するには：


```bash
npx skills add adeze/raindrop-mcp --global
```
[Vercel Skills Registry](https://github.com/vercel/skills/tree/main/registry) にこれを貢献するには、このリポジトリのURLをレジストリに追加するプルリクエストを提出してください。

### Claude Desktop (MCPB)

GitHubのリリースから最新のraindrop-mcp.mcpbをダウンロードして、Claude Desktopに追加します：

- リリース: https://github.com/adeze/raindrop-mcp/releases

Claude Desktopでバンドルを追加し、この環境変数を設定します：

- RAINDROP_ACCESS_TOKEN（Raindrop.ioの統合設定から取得）

### NPX (CLI)

APIトークンを環境変数として設定し、次を実行します：


```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### 手動MCP設定（mcp.json）

これをMCPクライアントの設定に追加してください：

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```
## 要件

- Raindrop.io アカウント
- Raindrop.io API アクセストークン: https://app.raindrop.io/settings/integrations

## サポート

- 問題報告: https://github.com/adeze/raindrop-mcp/issues

## リリース

このリポジトリは `semantic-release` を唯一のサポートされているリリースフローとして使用しています。

### 公開の仕組み

- リリースは `master` へのプッシュから `.github/workflows/ci.yml` を通じて実行されます。
- `semantic-release` は Conventional Commit メッセージを解析し、次のバージョンを計算し、`CHANGELOG.md` を更新し、GitHubでタグ付け/リリースし、npmに公開します。
- リリース準備中に `.releaserc.json` は `manifest.json`、`mcp.json`、および `gemini-extension.json` を同期し、その後 `raindrop-mcp.mcpb` をビルドしてGitHub Releaseにバンドルを含めます。

### プレリリースのドライラン

- 公開リリースを行う前に **Run workflow** で `.github/workflows/release-dry-run.yml` を実行してください。
- これにより、セマンティックバージョン計算、レジストリ認証、およびリリースパイプラインの動作が公開せずに検証されます。

### 必須のシークレット

- `GITHUB_TOKEN` はリリース自動化のためにGitHub Actionsから提供されます。

### npm 信頼された公開

- npm公開はGitHub ActionsのOIDC信頼された公開を通じて設定されています。
- 標準のCIリリースパスでは `NPM_TOKEN` は必要ありません。

### マージ前のローカル検証


```bash
bun run lint
bun run type-check
bun run test
bun run build
```
### コミットメッセージ例

- `fix: 空のタグマージペイロードを処理`
- `feat: コレクションパスフィルターを追加`
- `feat!: 廃止された検索パラメータを削除`

通常のリリースではバージョンの手動更新、リリースタグのプッシュ、npmの手動公開コマンドは実行しないでください。

## 📋 最近の強化 (v2.4.x)

### スマートな組織化と階層構造

- **AI提案**: 新しい`get_suggestions`ツールがRaindropのAPIとMCPサンプリングを使い組織化のアドバイスを提供します。
- **コレクションツリー**: `get_collection_tree`ツールが完全なパンくずリスト付きの階層ビューを提供します。
- **一括移動**: 効率的なライブラリ整理のために`bulk_edit_raindrops`に`move`操作を追加しました。
- **ページネーション対応**: 大規模ライブラリ向けに`list_raindrops`と`bookmark_search`をページネーション対応で標準化しました。

### 安全性と品質

- **確認ロジック**: 破壊的ツール（`empty_trash`、`cleanup_collections`）は明示的な確認を必要とするようになりました。
- **命名の標準化**: すべてのツールで一貫したスネークケース命名規則を使用しています。
- **CI/CDパイプライン**: GitHub Actionsを強化し、自動リンティング、型チェック、クロストランスポートテストを実装しました。
- **コード品質**: 保守可能な開発のためにESLintとPrettierの設定を確立しました。

## 📋 以前の強化 (v2.3.3)

### 高度なクリーンアップとライブラリアudit

## 📋 以前の強化 (v2.3.2)

### MCPリソースリンクの実装

- 最新のMCP SDKベストプラクティスに従ったモダンな`resource`コンテンツ
- 効率的なデータアクセス: ツールは完全なペイロードの代わりに軽量リンクを返します
- パフォーマンス向上: クライアントは必要な時のみ完全なブックマーク／コレクションデータを取得します
- 動的リソースシステム(`mcp://raindrop/{id}`)とのシームレスな統合

### SDK & APIの更新


- このリポジトリでサポートされている最新のMCP SDKに更新
- 改良された説明付きの最新ツール登録
- APIエンドポイントとパスパラメータの修正
- すべてのコアツールが完全に動作

### ツールの最適化

- ブックマーク／コレクションリストに対するリソース効率の良いレスポンス
- `mcp://collection/{id}` および `mcp://raindrop/{id}` を介した動的リソースアクセス
- より軽量なリストペイロードによるクライアントUXの改善
- 公式SDKパターンに準拠した完全なMCP対応

### サービスレイヤーの改善

- 共通ヘルパーを抽出してコードを削減
- 一貫したエラーハンドリングとレスポンス処理
- ジェネリックハンドラによる型安全性の向上
- エンドポイント構築の集中管理

### テストの改善

- MCPツール実行のエンドツーエンドカバレッジ強化
- 実際のクライアントフロー向け統合テスト拡充

### MCP 2.0準備（バルク操作）

- MCP 2.0のバルク操作ワークフローおよびツールの基盤構築

### OAuth（近日公開）

- 手動トークン不要のOAuthベース認証フローでセットアップを簡素化

### 注意

直近のビルドで影響を受けた方にはお詫び申し上げます。ご辛抱とご報告に感謝します。

## ライセンス

本プロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---