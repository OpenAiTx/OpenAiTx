# ユニバーサルツールコーリングプロトコル（UTCP）仕様

このリポジトリには、ユニバーサルツールコーリングプロトコル（UTCP）の公式仕様書が含まれています。UTCPは、さまざまな通信プロトコル間でツールを定義・操作するための、最新かつ柔軟で拡張性のある標準規格です。

## UTCPとは？

UTCPは、AIシステムやその他のクライアントが、基盤となるプロトコル（HTTP、WebSocket、CLIなど）に依存せずに、異なるプロバイダからツールを発見・呼び出すための標準化された方法を提供します。本仕様書では以下を定義しています：

- ツール発見メカニズム
- ツール呼び出しフォーマット
- プロバイダ設定
- 認証方式
- レスポンス処理

## 仕様への貢献

UTCP仕様への貢献を歓迎します！貢献方法は以下の通りです：

1. **リポジトリをフォークする**：仕様リポジトリの自分用フォークを作成します
2. **変更を加える**：必要に応じてドキュメントを更新または追加します
3. **プルリクエストを提出**：変更内容でPRを作成し、レビューを依頼します
4. **議論に参加する**：提案された変更についての会話に参加します

貢献にあたっては、以下のガイドラインに従ってください：

- 変更内容がUTCPの全体ビジョンと目標に沿っていることを確認してください
- 既存のドキュメント構造とフォーマットを守ってください
- 新しい機能や概念を追加する際は例を含めてください
- ドキュメント全体の一貫性を保つため、関連セクションも更新してください

## ドキュメントのローカルビルド

### 前提条件

ドキュメントサイトをローカルでビルド・プレビューするには、以下が必要です：

- Ruby バージョン2.5.0以上
- RubyGems
- Bundler

### セットアップ

1. リポジトリをクローンします：
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---