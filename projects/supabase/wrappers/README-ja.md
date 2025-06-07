# Wrappers

`Wrappers`は、Rustで記述されたPostgres Foreign Data Wrapper（[FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)）の開発フレームワークです。高性能、強い型、安全性などRust言語のモダンな機能を維持しつつ、Postgres FDW開発をより簡単にすることを目的としています。

`Wrappers`はまた、[Supabase](https://www.supabase.com)によって構築されたFDWのコレクションでもあります。現在、以下のFDWをサポートしており、さらに多くが開発中です。

| FDW                                                                                                                | 説明                                                                                  | 読み取り | 変更   |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------- | -------- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw)             | 基本的なFDW開発方法を示すデモFDW                                                      |          |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)                 | Google [BigQuery](https://cloud.google.com/bigquery)用FDW                             | ✅       | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw)             | [ClickHouse](https://clickhouse.com/)用FDW                                            | ✅       | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)                     | [Stripe](https://stripe.com/) API用FDW                                                | ✅       | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)                 | Google [Firebase](https://firebase.google.com/)用FDW                                  | ✅       | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)                 | [Airtable](https://airtable.com/) API用FDW                                            | ✅       | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                             | [AWS S3](https://aws.amazon.com/s3/)用FDW                                             | ✅       | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)                 | [Logflare](https://logflare.app/)用FDW                                                | ✅       | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)                       | [Auth0](https://auth0.com/)用FDW                                                      | ✅       | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)                  | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)用FDW              | ✅       | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)                       | [Redis](https://redis.io/)用FDW                                                       | ✅       | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)               | [AWS Cognito](https://aws.amazon.com/cognito/)用FDW                                   | ✅       | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)                    | [Notion](https://www.notion.so/)用Wasm FDW                                            | ✅       | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)              | [Snowflake](https://www.snowflake.com/)用Wasm FDW                                     | ✅       | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)                    | [Paddle](https://www.paddle.com/)用Wasm FDW                                           | ✅       | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)                | [Calendly](https://www.calendly.com/)用Wasm FDW                                       | ✅       | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)                      | [Cal.com](https://www.cal.com/)用Wasm FDW                                             | ✅       | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)                      | [Clerk](https://www.clerk.com/)用Wasm FDW                                             | ✅       | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)               | [Cloudflare D1](https://developers.cloudflare.com/d1/)用Wasm FDW                      | ✅       | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)                          | [Orb](https://www.withorb.com/)用Wasm FDW                                             | ✅       | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)                  | [HubSpot](https://www.hubspot.com/)用Wasm FDW                                         | ✅       | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)                      | [Slack](https://www.slack.com/)用Wasm FDW                                             | ✅       | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)            | [Apache Iceberg](https://iceberg.apache.org/)用FDW                                    | ✅       | ❌     |

### 警告

外部テーブルを利用したマテリアライズドビューを含むデータベースの論理バックアップをリストアする際、失敗する可能性があります。このため、マテリアライズドビューでは外部テーブルを使用しないか、物理バックアップを有効にしたデータベースでのみ使用してください。

## 特徴

- 最小限のインターフェースで実装が容易
- 豊富なデータ型のサポート
- RDBMS、RESTful API、フラットファイルなど、同期・非同期バックエンドの両方をサポート
- [pgrx](https://github.com/tcdi/pgrx)の上に構築され、低レベルC APIを隠さず高レベルなインターフェースを提供
- `WHERE`、`ORDER BY`、`LIMIT`のプッシュダウン対応

## ドキュメント

- [利用方法ドキュメント](https://fdw.dev/)
- [開発者ドキュメント (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## インストール

`Wrappers`はpgrx拡張機能です。[pgrxのインストール手順](https://github.com/tcdi/pgrx#system-requirements)に従ってWrappersをインストールしてください。

基本的には、`pgrx`インストール後、以下のコマンドでFDWをインストールします。例：

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## FDWの開発

詳細については[Wrappersドキュメント](https://fdw.dev/)をご参照ください。

## ライセンス

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---