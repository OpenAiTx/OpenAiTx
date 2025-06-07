<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>検索と分析のためのPostgres</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">ウェブサイト</a> &bull;
  <a href="https://docs.paradedb.com">ドキュメント</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">コミュニティ</a> &bull;
  <a href="https://paradedb.com/blog/">ブログ</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">変更履歴</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) は、Postgres上に構築された最新のElasticsearch代替ソリューションです。リアルタイムかつ更新頻度の高いワークロード向けに設計されています。

## ロードマップ

- [x] 検索
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) によるBM25による全文検索
  - [x] [pgvector](https://github.com/pgvector/pgvector#pgvector) による高密度・疎ベクトル検索
  - [ ] 分散検索
- [ ] 分析
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview) によるPostgresデータのファセット検索
  - [ ] カラム指向のPostgresテーブルアクセスメソッド

詳細なロードマップについては、[2025年のParadeDBロードマップ](https://github.com/orgs/paradedb/discussions/2041)をご覧ください。

## はじめに

はじめに、[ドキュメント](https://docs.paradedb.com)をご覧ください。

## ParadeDBのデプロイ

ParadeDBおよびその拡張機能は、以下の2つの方法のいずれかでデプロイできます。

- [Postgres](https://hub.docker.com/_/postgres) をベースとしたDockerイメージ（[デプロイ手順を見る](https://docs.paradedb.com/deploy/aws)）
- [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) をベースとしたKubernetes Helmチャート（[デプロイ手順を見る](https://docs.paradedb.com/deploy/helm)）

エンタープライズ機能やサポートなど、詳細については[メールでお問い合わせください](mailto:sales@paradedb.com)。

### 拡張機能

ParadeDB Postgres拡張機能の事前ビルドバイナリは、Debian 11・12、Ubuntu 22.04・24.04、Red Hat Enterprise Linux 8・9、macOS 14（Sonoma）および15（Sequoia）のPostgres 14+向けに[GitHubリリース](https://github.com/paradedb/paradedb/releases/latest)で入手できます。

ParadeDBはPostgreSQL Global Development Groupがサポートするすべてのバージョン（PostgreSQL 14+を含む）をサポートしており、各拡張機能のREADMEの手順に従って他のバージョンのPostgres向けにもビルドできます。

### Dockerイメージ

ParadeDBインスタンスをすぐに起動するには、最新のDockerイメージをpullして実行してください。

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

これにより、デフォルトユーザー `postgres` とパスワード `password` でParadeDBインスタンスが起動します。その後、`psql` を使ってデータベースに接続できます。

```bash
docker exec -it paradedb psql -U postgres
```

ParadeDBをローカルまたはオンプレミスでインストールする場合は、`docker-compose.yml` ファイルの利用を推奨します。あるいは、`docker run` コマンドに適切な環境変数を渡し、<>をご希望の値に置き換えてください。

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

これにより、非rootユーザー `<user>` とパスワード `<password>` でParadeDBインスタンスが起動します。`-v` フラグにより、ParadeDBのデータが `paradedb_data` というDockerボリュームに永続化され、再起動後も保持されます。

次に、`psql` を使用してデータベースに接続できます。

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helmチャート

ParadeDBはHelmチャート経由でKubernetesにも対応しています。Helmチャートは[ParadeDB Helm Chart GitHubリポジトリ](https://github.com/paradedb/charts)で入手できるほか、[Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb)から直接ダウンロードできます。

### ParadeDB Cloud

現時点で、ParadeDBのマネージドクラウドサービスは提供していません。ParadeDB Cloudサービスにご興味がある場合は、[ウェイトリスト](https://form.typeform.com/to/jHkLmIzx)にご登録ください。

## サポート

機能が不足している場合やバグを発見した場合は、
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose) を作成してください。

コミュニティサポートを得るには、以下の方法があります。

- [ParadeDB Slackコミュニティ](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) で質問する
- [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) でヘルプを求める

商用サポートが必要な場合は、[ParadeDBチームにご連絡ください](mailto:sales@paradedb.com)。

## コントリビューション

コミュニティからの大小さまざまな貢献を歓迎しており、その過程でサポートいたします。貢献を始めるには、[first timer issues](https://github.com/paradedb/paradedb/labels/good%20first%20issue) をご覧いただくか、[ParadeDBコミュニティSlack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) にメッセージを送ってください。貢献していただいた際には、Slackでお知らせいただければParadeDBグッズをお送りします！

貢献方法の詳細については、[コントリビューションガイド](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md) をご覧ください。

本プロジェクトは [コントリビューター行動規範](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md) のもとで公開されています。
本プロジェクトに参加することで、その規範に従うことに同意したものとみなされます。

ParadeDBをより良いものにするためにご協力いただき、ありがとうございます :heart:。

## ライセンス

ParadeDBは[GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) および商用ソフトウェアとしてライセンスされています。商用ライセンスについては [sales@paradedb.com](mailto:sales@paradedb.com) までご連絡ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---