# DocLite

一个强大的 PHP NoSQL 文档存储，构建于 SQLite 之上。

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## 关于

DocLite 是一个基于 SQLite 的 PHP NoSQL 文档存储。它使用 PHP PDO SQLite 库自动管理组织成命名集合的文档，并以 JSON 格式存储。DocLite 利用 SQLite JSON1 扩展来存储、解析、索引和查询 JSON 文档 —— 为您提供一个完全事务性、ACID 合规的 NoSQL 解决方案，完全包含在本地文件系统中。

DocLite 适用于多种用例：快速原型开发、中小型网站和应用、远程 API 数据的快速本地缓存、平面文件存储的强大替代方案，以及微服务或本地 Web 应用的数据库。总体来说，它适合[与 SQLite 本身相同的用例](https://www.sqlite.org/whentouse.html)，但更偏好 NoSQL 文档模型。

## 安装

```bash
composer require dwgebler/doclite
```
需要 PHP 8.1+ 及 `pdo_sqlite` 扩展。

从 1.x 升级？请参阅 [UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md)。

## 快速开始


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

## 文档

- [快速开始](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — 安装，需求，第一个数据库
- [集合与文档](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — 增删改查，事务，模式，自定义类映射
- [查询](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — 查询构建器，连接，分页，聚合，索引
- [全文搜索](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — 基于 FTS5 的搜索
- [高级](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — 导入/导出，日志模式，JSONB，PSR-16 缓存适配器，日志记录
- [Symfony 集成](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — 将 DocLite 接入 Symfony 应用

## 许可证

MIT。参见 [LICENSE](LICENSE)。

## 报告错误

请在 [GitHub](https://github.com/dwgebler/doclite/issues) 提交问题。

## 报告漏洞

参见 [SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---