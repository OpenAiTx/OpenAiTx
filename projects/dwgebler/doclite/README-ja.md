# DocLite

SQLiteの上に構築された強力なPHP NoSQLドキュメントストア。

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## 概要

DocLiteはSQLiteを基盤としたPHP用のNoSQLドキュメントストアです。PHPのPDO SQLiteライブラリを使用して、名前付きコレクションに整理されたドキュメントを自動的に管理し、JSONとして保存します。DocLiteはSQLiteのJSON1拡張機能を活用して、JSONドキュメントを保存、解析、インデックス作成、クエリ実行し、完全にトランザクション対応でACID準拠のNoSQLソリューションをローカルファイルシステム内に提供します。

DocLiteは様々な用途に適しています：迅速なプロトタイピング、中小規模のウェブサイトやアプリケーション、リモートAPIデータの高速ローカルキャッシュ、フラットファイルストアの堅牢な代替、マイクロサービスやローカルウェブアプリのデータベース。広く言えば、[SQLite自体と同様の用途](https://www.sqlite.org/whentouse.html)に適していますが、NoSQLドキュメントモデルが好まれる場合に最適です。

## インストール

```bash
composer require dwgebler/doclite
```

PHP 8.1以上および`pdo_sqlite`拡張が必要です。

1.xからのアップグレードですか？[UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md)を参照してください。

## クイックスタート

```php
use Gebler\Doclite\FileDatabase;

$db = new FileDatabase('./data');
$users = $db->collection('users');

$alice = $users->get();
$alice->setValue('name', 'Alice');
$alice->setValue('email', 'alice@example.com');
$alice->save();

$found = $users->findOneBy(['email' => 'alice@example.com']);
echo $found->getValue('name'); // Alice
```

## ドキュメント

- [はじめに](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — インストール、要件、最初のデータベース
- [コレクションとドキュメント](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — CRUD、トランザクション、スキーマ、カスタムクラスマッピング
- [クエリ](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — クエリビルダー、結合、ページネーション、集約、インデックス作成
- [全文検索](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — FTS5による検索
- [高度な機能](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — インポート/エクスポート、ジャーナルモード、JSONB、PSR-16キャッシュアダプター、ログ記録
- [Symfony統合](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — SymfonyアプリへのDocLiteの組み込み

## ライセンス

MIT。詳細は[LICENSE](LICENSE)を参照。

## バグ報告

[GitHub](https://github.com/dwgebler/doclite/issues)でIssueを作成してください。

## 脆弱性報告

[SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md)を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---