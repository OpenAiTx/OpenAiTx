# Wrappers

`Wrappers` 是一個用於開發 Postgres Foreign Data Wrappers（[FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)）的開發框架，使用 Rust 語言編寫。它的目標是讓 Postgres FDW 的開發更加容易，同時保有 Rust 語言的現代能力，例如高效能、強型別和安全性。

`Wrappers` 也是一套由 [Supabase](https://www.supabase.com) 所開發的 FDW 集合。目前我們支援以下 FDW，且有更多正在開發中：

| FDW                                             | 描述                                                                            | 讀取 | 修改   |
| ----------------------------------------------- | ------------------------------------------------------------------------------- | ---- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | 展示如何開發基本 FDW 的範例 FDW。                                               |      |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Google [BigQuery](https://cloud.google.com/bigquery) 的 FDW                      | ✅   | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | [ClickHouse](https://clickhouse.com/) 的 FDW                                    | ✅   | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | [Stripe](https://stripe.com/) API 的 FDW                                        | ✅   | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Google [Firebase](https://firebase.google.com/) 的 FDW                          | ✅   | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | [Airtable](https://airtable.com/) API 的 FDW                                    | ✅   | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | [AWS S3](https://aws.amazon.com/s3/) 的 FDW                                     | ✅   | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | [Logflare](https://logflare.app/) 的 FDW                                        | ✅   | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | [Auth0](https://auth0.com/) 的 FDW                                              | ✅   | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) 的 FDW      | ✅   | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | [Redis](https://redis.io/) 的 FDW                                               | ✅   | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | [AWS Cognito](https://aws.amazon.com/cognito/) 的 FDW                           | ✅   | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | [Notion](https://www.notion.so/) 的 Wasm FDW                                    | ✅   | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | [Snowflake](https://www.snowflake.com/) 的 Wasm FDW                             | ✅   | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | [Paddle](https://www.paddle.com/) 的 Wasm FDW                                   | ✅   | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | [Calendly](https://www.calendly.com/) 的 Wasm FDW                               | ✅   | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | [Cal.com](https://www.cal.com/) 的 Wasm FDW                                     | ✅   | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | [Clerk](https://www.clerk.com/) 的 Wasm FDW                                     | ✅   | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | [Cloudflare D1](https://developers.cloudflare.com/d1/) 的 Wasm FDW              | ✅   | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | [Orb](https://www.withorb.com/) 的 Wasm FDW                                     | ✅   | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | [HubSpot](https://www.hubspot.com/) 的 Wasm FDW                                 | ✅   | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | [Slack](https://www.slack.com/) 的 Wasm FDW                                     | ✅   | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| [Apache Iceberg](https://iceberg.apache.org/) 的 FDW                            | ✅   | ❌     |

### 警告

使用包含外部表的物化檢視表還原資料庫邏輯備份時可能會失敗。因此，請勿在物化檢視表中使用外部表，或僅在啟用實體備份的資料庫中使用。

## 特色

- 極簡介面，易於實作。
- 支援豐富的資料型別。
- 同時支援同步與非同步後端，如 RDBMS、RESTful API、扁平檔案等。
- 建立於 [pgrx](https://github.com/tcdi/pgrx) 之上，提供更高階介面，同時不隱藏底層 C API。
- 支援 `WHERE`、`ORDER BY`、`LIMIT` 下推。

## 文件

- [使用文件](https://fdw.dev/)
- [開發者文件 (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## 安裝

`Wrappers` 是一個 pgrx 擴充套件，你可以依照 [pgrx 安裝步驟](https://github.com/tcdi/pgrx#system-requirements) 安裝 Wrappers。

基本上，在安裝好 `pgrx` 後，執行以下指令即可安裝 FDW。例如：

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## FDW 開發

請參考 [Wrappers 文件](https://fdw.dev/) 以獲得更多詳細資訊。

## 授權

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---