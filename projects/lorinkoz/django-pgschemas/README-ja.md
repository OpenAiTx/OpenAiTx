# django-pgschemas

[![Build status](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![Documentation status](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![Code coverage](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![PyPi version](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![Downloads](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

このパッケージは、Postgresのスキーマを使用して、単一のDjangoプロジェクト内でのデータのマルチテナンシーをサポートします。これは[django-tenants](https://github.com/django-tenants/django-tenants)のフォークであり、いくつかの概念的な変更があります：

- 静的テナントと動的テナントがあります。静的テナントは独自のアプリやurlconfを持つことができます。
- テナントは以下の方法でルーティングできます：
  - 共有サブドメイン上のサブドメインまたはサブフォルダを使用したURL
  - セッション
  - ヘッダー
- publicスキーマはメインサイトのデータ保存には使用せず、すべてのテナント間で共有される真の共有データのために使用されるべきです。search_pathによるテーブルの「オーバーライド」は推奨されません。
- 管理コマンドはワイルドカードを使って複数のスキーマで実行可能であり、順次またはマルチスレッドを使った並列で実行できます。

## ドキュメント

https://django-pgschemas.readthedocs.io/

## コントリビュート

このプロジェクトへの貢献方法の詳細は[CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file)を参照してください。

## クレジット

- Tom Turnerによる[django-tenants](https://github.com/django-tenants/django-tenants)。
- Bernardo Piresによる[django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas)。
- Denish Patelによる[pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-29

---