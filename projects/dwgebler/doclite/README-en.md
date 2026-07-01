# DocLite

A powerful PHP NoSQL document store built on top of SQLite.

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## About

DocLite is a NoSQL document store for PHP built on SQLite. It uses the PHP PDO SQLite library to automatically manage documents organised into named collections, stored as JSON. DocLite takes advantage of the SQLite JSON1 extension to store, parse, index, and query JSON documents — giving you the power of a fully transactional, ACID-compliant NoSQL solution contained entirely within the local filesystem.

DocLite lends itself to a variety of use cases: rapid prototyping, small-to-medium websites and applications, a fast local cache for remote API data, a robust replacement for flat-file stores, and a database for microservices or local web apps. Broadly, it suits the [same use cases as SQLite itself](https://www.sqlite.org/whentouse.html), but where a NoSQL document model is preferred.

## Install

```bash
composer require dwgebler/doclite
```

Requires PHP 8.1+ and the `pdo_sqlite` extension.

Upgrading from 1.x? See [UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md).

## Quick start

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

## Documentation

- [Getting started](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — installation, requirements, your first database
- [Collections & documents](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — CRUD, transactions, schemas, custom class mapping
- [Queries](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — query builder, joins, pagination, aggregation, indexing
- [Full-text search](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — FTS5-powered search
- [Advanced](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — import/export, journal modes, JSONB, PSR-16 cache adapter, logging
- [Symfony integration](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — wiring DocLite into a Symfony app

## License

MIT. See [LICENSE](LICENSE).

## Reporting bugs

Please raise an issue on [GitHub](https://github.com/dwgebler/doclite/issues).

## Reporting vulnerabilities

See [SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---