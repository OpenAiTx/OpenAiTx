<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - CSVファイル用高性能SQLクエリエンジン

 [![クロスビルドとテスト（zigビルドシステム使用）](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

C言語で書かれた軽量かつ高速なSQLクエリプロセッサで、データベースを必要とせずCSVファイル上で直接SQLクエリを実行できます。詳細なドキュメントは/docディレクトリを参照してください。

 ![cqの実行例](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## ドキュメント

- はじめに: `doc/GettingStarted.md`
- インストール: `doc/Installation.md`
- コマンドラインインターフェース: `doc/CLI.md`
- **TUI (ターミナルユーザーインターフェース)**: `doc/TUI.md`
- アーキテクチャ: `doc/Architecture.md`
- テスト: `doc/Testing.md`
- ロードマップ: `doc/Roadmap.md`
- 貢献方法: `doc/Contributing.md`

## クイックスタート

ビルド: `make`

### コマンドライン

サンプルクエリの実行:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### ターミナル UI

インタラクティブTUIの起動:
`./build/cqtui data/`

機能:
- CSVファイルをテーブルとして閲覧・オープン
- 対話的にSQLクエリを実行
- 複数テーブル用のマルチタブインターフェース
- キーボード操作によるナビゲーション
- 外部依存なし

## サンプルSQLファイル

リポジトリには assets/ 配下にサンプルSQL（example_between.sql、example_aggregation.sql など）が含まれています。詳細は assets/ を参照してください。

## データと機能の概要

- データ型、日付フォーマット、CSV形式などの詳細は /doc フォルダ内の各セクションを参照してください。

## ライセンス

MITライセンス。詳細はLICENSEファイルをご参照ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---