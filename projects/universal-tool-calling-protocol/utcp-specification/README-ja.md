<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Universal Tool Calling Protocol (UTCP) 仕様書

このリポジトリには Universal Tool Calling Protocol (UTCP) の公式仕様書が含まれています。UTCPは、さまざまな通信プロトコル間でツールを定義し操作するための、現代的で柔軟かつスケーラブルな標準規格です。

## UTCPとは何か？

UTCPは、AIシステムや他のクライアントが異なるプロバイダーのツールを、基盤となるプロトコル（HTTP、WebSocket、CLIなど）に関係なく発見し呼び出すための標準化された方法を提供します。この仕様書では以下を定義しています：

- ツール発見メカニズム
- ツール呼び出しフォーマット
- プロバイダー設定
- 認証方式
- レスポンス処理

## 仕様書への貢献

UTCP仕様書への貢献を歓迎します！貢献の方法は以下の通りです：

1. **リポジトリをフォークする**: 仕様書リポジトリの自分用フォークを作成
2. **変更を加える**: 必要に応じてドキュメントを更新または追加
3. **プルリクエストを送る**: 変更内容をレビューのためにPRとして提出
4. **議論に参加する**: 提案された変更についての議論に参加

貢献時は以下のガイドラインを守ってください：

- 変更がUTCPの全体的なビジョンや目標に沿っていることを確認
- 既存のドキュメント構造とフォーマットを遵守
- 新機能や概念の追加時には例を含める
- ドキュメント全体の整合性を保つため関連するセクションを更新

## ドキュメントをローカルでビルドする

### 前提条件

ドキュメントサイトをローカルでビルドしプレビューするには以下が必要です：

- Ruby バージョン 2.5.0 以上
- RubyGems
- Bundler

### セットアップ

1. リポジトリをクローンする：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---