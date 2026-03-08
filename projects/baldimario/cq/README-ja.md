# cq - CSVファイル向け高性能SQLクエリエンジン

 [![クロスビルドとテスト（zigビルドシステム使用）](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

C言語で書かれた軽量かつ高速なSQLクエリプロセッサで、データベースを必要とせずにCSVファイル上で直接SQLクエリを実行できます。完全なドキュメントは /doc ディレクトリを参照してください。

 ![cqの動作画面](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## ドキュメント

- はじめに: `doc/GettingStarted.md`
- インストール: `doc/Installation.md`
- コマンドラインインターフェース: `doc/CLI.md`
- **TUI（ターミナルユーザーインターフェース）**: `doc/TUI.md`
- アーキテクチャ: `doc/Architecture.md`
- テスト: `doc/Testing.md`
- ロードマップ: `doc/Roadmap.md`
- 貢献方法: `doc/Contributing.md`

## クイックスタート

ビルド: `make`

### コマンドライン

サンプルクエリを実行:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### ターミナルUI

インタラクティブなTUIを起動:
`./build/cqtui data/`

特徴:
- CSVファイルをテーブルとして閲覧・オープン
- SQLクエリを対話的に実行
- 複数テーブル用のマルチタブインターフェース
- キーボード操作によるナビゲーション
- 外部依存なし

## サンプルSQLファイル

リポジトリには assets/ 内にサンプルSQL（example_between.sql、example_aggregation.sql など）が含まれています。詳細は assets/ を参照してください。

## データと機能の概要

- データ型、日付形式、CSV形式などの詳細は /doc フォルダを参照してください。

## ライセンス

MITライセンス。詳細は LICENSE ファイルを参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---