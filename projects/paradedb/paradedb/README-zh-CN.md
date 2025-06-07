<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>用于搜索和分析的 Postgres</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">官网</a> &bull;
  <a href="https://docs.paradedb.com">文档</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">社区</a> &bull;
  <a href="https://paradedb.com/blog/">博客</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">更新日志</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) 是一个基于 Postgres 构建的现代化 Elasticsearch 替代方案。专为实时、高频更新的工作负载而打造。

## 路线图

- [x] 搜索
  - [x] 基于 [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) 的 BM25 全文搜索
  - [x] 基于 [pgvector](https://github.com/pgvector/pgvector#pgvector) 的稠密和稀疏向量搜索
  - [ ] 分布式搜索
- [ ] 分析
  - [x] 基于 [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) 的 Postgres 数据分面搜索
  - [ ] 面向列的 Postgres 表访问方法

完整路线图请参见 [ParadeDB 2025 年路线图](https://github.com/orgs/paradedb/discussions/2041)。

## 快速开始

请访问我们的[文档](https://docs.paradedb.com)以快速入门。

## 部署 ParadeDB

ParadeDB 及其扩展可以通过以下两种方式部署：

- 基于 [Postgres](https://hub.docker.com/_/postgres) 的 Docker 镜像（[查看部署说明](https://docs.paradedb.com/deploy/aws)）
- 基于 [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) 的 Kubernetes Helm chart（[查看部署说明](https://docs.paradedb.com/deploy/helm)）

如需更多信息，包括企业功能和支持，请[通过电子邮件联系我们](mailto:sales@paradedb.com)。

### 扩展

你可以在 [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest) 页面找到 ParadeDB Postgres 扩展在 Debian 11、12，Ubuntu 22.04 和 24.04，Red Hat Enterprise Linux 8 和 9，以及 macOS 14（Sonoma）和 15（Sequoia）上的 Postgres 14+ 预编译二进制文件。

ParadeDB 支持 PostgreSQL 全球开发组支持的所有版本（包括 PostgreSQL 14+），你也可以按照各自扩展的 README 指南为其他 Postgres 版本编译扩展。

### Docker 镜像

要快速启动并运行 ParadeDB 实例，只需拉取并运行最新的 Docker 镜像：

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

这将以默认用户 `postgres` 和密码 `password` 启动一个 ParadeDB 实例。你可以使用 `psql` 连接数据库：

```bash
docker exec -it paradedb psql -U postgres
```

如需本地或本地部署 ParadeDB，建议使用我们的 `docker-compose.yml` 文件。或者，你也可以在 `docker run` 命令中传递相应环境变量，将 <> 替换为你期望的值：

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<user> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

这将以非 root 用户 `<user>` 和密码 `<password>` 启动 ParadeDB 实例。`-v` 参数可确保你的 ParadeDB 数据在 Docker 卷 `paradedb_data` 中持久化保存，重启后数据不会丢失。

你可以使用如下命令通过 `psql` 连接数据库：

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB 也可以通过我们的 Helm chart 在 Kubernetes 上部署。你可以在 [ParadeDB Helm Chart GitHub 仓库](https://github.com/paradedb/charts) 找到我们的 Helm chart，或直接从 [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) 下载。

### ParadeDB 云服务

目前 ParadeDB 尚未提供托管的云服务。如果你对 ParadeDB 云服务感兴趣，请通过加入我们的[候补名单](https://form.typeform.com/to/jHkLmIzx)告知我们。

## 支持

如果你发现缺少某项功能或遇到错误，请提交
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose)。

如需社区支持，你可以：

- 在 [ParadeDB Slack 社区](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) 中提问
- 在我们的 [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) 请求帮助

如需商业支持，请[联系 ParadeDB 团队](mailto:sales@paradedb.com)。

## 贡献

我们欢迎各种社区贡献，无论大小，并愿意为你的贡献之路提供指导。要开始贡献，请查看我们的[新手问题](https://github.com/paradedb/paradedb/labels/good%20first%20issue)，或在 [ParadeDB 社区 Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) 与我们联系。贡献后请在 Slack 上告知我们，我们会送你一些 ParadeDB 周边！

关于如何贡献的更多信息，请参阅我们的
[贡献指南](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md)。

本项目发布时附带了[贡献者行为准则](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md)。
参与本项目即表示你同意遵守其条款。

感谢你帮助我们让 ParadeDB 变得更好 :heart:。

## 许可证

ParadeDB 采用 [GNU Affero 通用公共许可证 v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) 以及商业授权发布。如需商业授权，请通过 [sales@paradedb.com](mailto:sales@paradedb.com) 与我们联系。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---