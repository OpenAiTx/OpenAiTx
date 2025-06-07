# Wrappers

`Wrappers` 是一个用于 Postgres 外部数据包装器（Foreign Data Wrappers，简称 [FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)）的开发框架，使用 Rust 编写。其目标是简化 Postgres FDW 的开发，同时保留 Rust 语言的现代特性，如高性能、强类型和安全性。

`Wrappers` 也是 [Supabase](https://www.supabase.com) 构建的一系列 FDW 的集合。目前我们支持以下 FDW，并有更多正在开发中：

| FDW                                                                                                    | 描述                                                                               | 读取 | 修改 |
| ------------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------- | ---- | ---- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | 一个演示如何开发基本 FDW 的示例 FDW。                                               |      |      |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Google [BigQuery](https://cloud.google.com/bigquery) 的 FDW                        | ✅   | ✅   |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | [ClickHouse](https://clickhouse.com/) 的 FDW                                       | ✅   | ✅   |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | [Stripe](https://stripe.com/) API 的 FDW                                           | ✅   | ✅   |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Google [Firebase](https://firebase.google.com/) 的 FDW                             | ✅   | ❌   |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | [Airtable](https://airtable.com/) API 的 FDW                                       | ✅   | ❌   |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | [AWS S3](https://aws.amazon.com/s3/) 的 FDW                                        | ✅   | ❌   |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | [Logflare](https://logflare.app/) 的 FDW                                           | ✅   | ❌   |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | [Auth0](https://auth0.com/) 的 FDW                                                 | ✅   | ❌   |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) 的 FDW         | ✅   | ❌   |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | [Redis](https://redis.io/) 的 FDW                                                  | ✅   | ❌   |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | [AWS Cognito](https://aws.amazon.com/cognito/) 的 FDW                              | ✅   | ❌   |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | [Notion](https://www.notion.so/) 的 Wasm FDW                                       | ✅   | ❌   |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | [Snowflake](https://www.snowflake.com/) 的 Wasm FDW                                | ✅   | ✅   |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | [Paddle](https://www.paddle.com/) 的 Wasm FDW                                      | ✅   | ✅   |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | [Calendly](https://www.calendly.com/) 的 Wasm FDW                                  | ✅   | ❌   |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | [Cal.com](https://www.cal.com/) 的 Wasm FDW                                        | ✅   | ❌   |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | [Clerk](https://www.clerk.com/) 的 Wasm FDW                                        | ✅   | ❌   |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | [Cloudflare D1](https://developers.cloudflare.com/d1/) 的 Wasm FDW                 | ✅   | ✅   |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | [Orb](https://www.withorb.com/) 的 Wasm FDW                                        | ✅   | ❌   |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | [HubSpot](https://www.hubspot.com/) 的 Wasm FDW                                    | ✅   | ❌   |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | [Slack](https://www.slack.com/) 的 Wasm FDW                                        | ✅   | ❌   |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| [Apache Iceberg](https://iceberg.apache.org/) 的 FDW                               | ✅   | ❌   |

### 警告

使用包含外部表的物化视图还原数据库的逻辑备份可能会失败。因此，请勿在物化视图中使用外部表，或者仅在启用了物理备份的数据库中使用。

## 特性

- 最小接口，易于实现。
- 支持丰富的数据类型。
- 同时支持同步和异步后端，例如 RDBMS、RESTful API、平面文件等。
- 构建于 [pgrx](https://github.com/tcdi/pgrx) 之上，提供更高级别的接口，同时不隐藏底层 C API。
- 支持 `WHERE`、`ORDER BY`、`LIMIT` 下推。

## 文档

- [使用文档](https://fdw.dev/)
- [开发者文档（docs.rs）](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## 安装

`Wrappers` 是一个 pgrx 扩展，你可以按照 [pgrx 安装步骤](https://github.com/tcdi/pgrx#system-requirements) 安装 Wrappers。

基本上，在安装好 `pgrx` 后，运行以下命令安装 FDW。例如：

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## 开发 FDW

访问 [Wrappers 文档](https://fdw.dev/) 获取更多信息。

## 许可协议

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---