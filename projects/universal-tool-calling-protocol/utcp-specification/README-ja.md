<translate-content># ユニバーサルツール呼び出しプロトコル（UTCP）仕様書

このリポジトリは、ユニバーサルツール呼び出しプロトコル（UTCP）の公式仕様ドキュメントを含んでいます。UTCPは、さまざまな通信プロトコルにわたってツールを定義し、対話するための最新で柔軟かつスケーラブルな標準です。

## UTCPとは何か？

UTCPは、AIシステムやその他のクライアントが、基盤となるプロトコル（HTTP、WebSocket、CLIなど）に関係なく、異なるプロバイダーのツールを発見し呼び出すための標準化された方法を提供します。この仕様では以下を定義しています：

- ツール発見メカニズム
- ツール呼び出しフォーマット
- プロバイダー設定
- 認証方法
- レスポンス処理

## 仕様への貢献

UTCP仕様への貢献を歓迎します！貢献方法は以下の通りです：

1. **リポジトリをフォークする**：仕様リポジトリを自分のフォークとして作成
2. **変更を行う**：必要に応じてドキュメントを更新または追加
3. **プルリクエストを提出する**：変更内容をレビュー用にPRとして開く
4. **ディスカッションに参加する**：提案された変更について議論に参加

貢献の際は、以下のガイドラインに従ってください：

- 変更がUTCPの全体的なビジョンと目標に沿っていることを確認
- 既存のドキュメント構造とフォーマットを遵守
- 新機能や概念を追加する際は例を含める
- ドキュメント全体の一貫性を保つため関連セクションを更新

## ローカルでのドキュメントビルド

### 前提条件

ドキュメントサイトをローカルでビルドおよびプレビューするには、以下が必要です：

- Ruby バージョン2.5.0以上
- RubyGems
- Bundler

### セットアップ

1. リポジトリをクローンする：</translate-content>
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. 依存関係をインストールします:

   ```bash
   bundle install
   ```
### ドキュメンテーションサイトの起動

サイトをローカルでビルドして提供するには：


```bash
bundle exec jekyll serve
```
This will start a local web server at `http://localhost:4000` where you can preview the documentation.

## Documentation Structure

The UTCP documentation is organized as follows:

- `index.md`: ホームページとUTCPの紹介
- `docs/`
  - `introduction.md`: 詳細な紹介とコアコンセプト
  - `for-tool-providers.md`: ツールプロバイダー実装ガイド
  - `for-tool-callers.md`: ツールコーラー実装ガイド
  - `providers/`: 各プロバイダータイプのドキュメント
    - `http.md`: HTTPプロバイダー
    - `websocket.md`: WebSocketプロバイダー
    - `cli.md`: CLIプロバイダー
    - `sse.md`: サーバー送信イベントプロバイダー
    - その他
  - `implementation.md`: 実装ガイドラインとベストプラクティス

## Working with the Specification

### Modifying the Documentation

The documentation is written in Markdown format with Jekyll front matter. When making changes:

1. Markdownが既存のスタイルに従っていることを確認する
2. PRを提出する前にローカルで変更をプレビューする
3. 例を最新の仕様に合わせて更新する
4. 新しいページを追加した場合は`_config.yml`のナビゲーション項目を更新する

### File Organization

When adding new documentation:

- プロバイダー固有のドキュメントは`docs/providers/`に配置する
- 一貫したフロントマターと適切なナビゲーション順序を使用する
- GitHub Pagesでの検索性向上のためタグを含める

## Version Control

The UTCP specification follows semantic versioning:

- メジャーバージョン（1.0、2.0）：プロトコルの破壊的変更
- マイナーバージョン（1.1、1.2）：後方互換性のある新機能追加
- パッチバージョン（1.0.1、1.0.2）：後方互換性のあるバグ修正および明確化

## License

This specification is distributed under the Mozilla Public License 2.0 (MPL-2.0).

## Additional Resources

- [UTCP GitHub Organization](https://github.com/universal-tool-calling-protocol)
- [UTCP Website](https://utcp.io)
- [Reference Implementations](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Community Discussions](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---