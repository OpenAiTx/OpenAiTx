<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>用於搜尋與分析的 Postgres</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">網站</a> &bull;
  <a href="https://docs.paradedb.com">文件</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">社群</a> &bull;
  <a href="https://paradedb.com/blog/">部落格</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">更新日誌</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) 是一款現代化的 Elasticsearch 替代方案，建構於 Postgres 之上。專為即時、頻繁更新的工作負載設計。

## 發展藍圖（Roadmap）

- [x] 搜尋
  - [x] 使用 [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) 的 BM25 全文搜尋
  - [x] 使用 [pgvector](https://github.com/pgvector/pgvector#pgvector) 進行密集與稀疏向量搜尋
  - [ ] 分散式搜尋
- [ ] 分析
  - [x] 以 [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) 在 Postgres 資料上進行 Faceted 搜尋
  - [ ] 面向欄位的 Postgres 資料表存取方法

如需詳細發展藍圖，請參閱 [ParadeDB 2025 發展藍圖](https://github.com/orgs/paradedb/discussions/2041)。

## 快速開始

請參閱我們的[文件](https://docs.paradedb.com)以開始使用。

## ParadeDB 部署方式

ParadeDB 及其擴充套件可透過下列兩種方式部署：

- 基於 [Postgres](https://hub.docker.com/_/postgres) 的 Docker 映像檔（[參閱部署說明](https://docs.paradedb.com/deploy/aws)）
- 基於 [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) 的 Kubernetes Helm chart（[參閱部署說明](https://docs.paradedb.com/deploy/helm)）

如需更多資訊（包含企業功能與支援），請[來信聯絡我們](mailto:sales@paradedb.com)。

### 擴充套件

您可以在 [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest) 下載 ParadeDB Postgres 擴充套件的預建二進位檔，支援 Debian 11、12，Ubuntu 22.04 與 24.04，Red Hat Enterprise Linux 8 與 9，以及 macOS 14（Sonoma）與 15（Sequoia），適用於 Postgres 14 以上版本。

ParadeDB 支援由 PostgreSQL 全球開發團隊維護的所有版本（14 以上），並可依各擴充套件說明檔中的指示，自行編譯適用於其他 Postgres 版本的擴充套件。

### Docker 映像檔

若要快速啟動 ParadeDB 實例，只需拉取並執行最新的 Docker 映像檔：

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

此指令將以預設使用者 `postgres` 與密碼 `password` 啟動 ParadeDB 實例。接著可使用 `psql` 連接資料庫：

```bash
docker exec -it paradedb psql -U postgres
```

建議本地或內部部署 ParadeDB 時，使用我們的 `docker-compose.yml` 檔案。或者，您也可以在 `docker run` 指令中傳入相應的環境變數，將 <> 替換為您的設定值：

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

此指令將以非 root 使用者 `<user>` 與密碼 `<password>` 啟動 ParadeDB 實例。`-v` 旗標會將您的 ParadeDB 資料持久化於名為 `paradedb_data` 的 Docker 卷中，確保重啟後資料不會遺失。

接著可使用 `psql` 連接資料庫：

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB 也可透過我們的 Helm chart 部署於 Kubernetes。您可於 [ParadeDB Helm Chart GitHub 倉庫](https://github.com/paradedb/charts) 或直接從 [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) 下載。

### ParadeDB 雲端服務

目前 ParadeDB 尚未提供託管式雲端服務。若您有興趣使用 ParadeDB 雲端服務，歡迎加入我們的[等候名單](https://form.typeform.com/to/jHkLmIzx)。

## 支援

如需新功能或發現錯誤，請提交
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose)。

如需社群支援，您可以：

- 在 [ParadeDB Slack 社群](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) 提問
- 於 [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) 請求協助

如需商業技術支援，請[聯絡 ParadeDB 團隊](mailto:sales@paradedb.com)。

## 貢獻指南

我們歡迎各種社群貢獻，無論大小，並會協助您加入開發行列。想開始貢獻，請參閱我們的 [新手議題](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
或在 [ParadeDB 社群 Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) 聯繫我們。貢獻後，請在 Slack 通知我們，我們會寄送 ParadeDB 周邊贈品！

如需貢獻方式的詳細資訊，請參閱我們的
[貢獻指南](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md)。

本專案遵循 [貢獻者行為準則](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md)。
參與本專案即表示您同意遵守其條款。

感謝您協助讓 ParadeDB 變得更好 :heart:。

## 授權

ParadeDB 採用 [GNU Affero 通用公共授權條款 v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) 及商業授權。如需商業授權，請聯絡 [sales@paradedb.com](mailto:sales@paradedb.com)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---