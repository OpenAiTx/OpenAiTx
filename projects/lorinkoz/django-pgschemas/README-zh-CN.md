# django-pgschemas

[![构建状态](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![文档状态](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![代码覆盖率](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![PyPi 版本](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![下载量](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

该包使用 Postgres 模式在单个 Django 项目中支持数据多租户。它是 [django-tenants](https://github.com/django-tenants/django-tenants) 的一个分支，具有一些概念上的变化：

- 有静态租户和动态租户。静态租户可以拥有自己的应用和 urlconf。
- 租户可以通过以下方式路由：
  - 使用子域名或共享子域名上的子文件夹的 URL
  - 会话
  - 请求头
- 公共模式不应用于存储主站点数据，而是真正跨所有租户共享的数据。不鼓励通过搜索路径进行表的“覆盖”。
- 管理命令可以通过通配符在多个模式上运行，支持顺序执行或使用多线程并行执行。

## 文档

https://django-pgschemas.readthedocs.io/

## 贡献

有关如何为此项目贡献的详细信息，请参见 [CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file)。

## 致谢

- Tom Turner，感谢其开发的 [django-tenants](https://github.com/django-tenants/django-tenants)。
- Bernardo Pires，感谢其开发的 [django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas)。
- Denish Patel，感谢其开发的 [pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-29

---