# Wrappers

`Wrappers` is a development framework for Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), written in Rust. Its goal is to make Postgres FDW development easier while retaining the modern features of the Rust language, such as high performance, strong typing, and safety.

`Wrappers` is also a collection of FDWs developed by [Supabase](https://www.supabase.com). We currently support the following FDWs, with more under development:

| FDW | Description | Read | Modify |
| --- | ----------- | ---- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | A demo FDW to show how to develop a basic FDW. | | |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw) | A FDW for Google [BigQuery](https://cloud.google.com/bigquery) | ✅ | ✅ |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | A FDW for [ClickHouse](https://clickhouse.com/) | ✅ | ✅ |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw) | A FDW for [Stripe](https://stripe.com/) API | ✅ | ✅ |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw) | A FDW for Google [Firebase](https://firebase.google.com/) | ✅ | ❌ |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw) | A FDW for [Airtable](https://airtable.com/) API | ✅ | ❌ |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw) | A FDW for [AWS S3](https://aws.amazon.com/s3/) | ✅ | ❌ |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw) | A FDW for [Logflare](https://logflare.app/) | ✅ | ❌ |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw) | A FDW for [Auth0](https://auth0.com/) | ✅ | ❌ |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw) | A FDW for [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅ | ❌ |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw) | A FDW for [Redis](https://redis.io/) | ✅ | ❌ |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw) | A FDW for [AWS Cognito](https://aws.amazon.com/cognito/) | ✅ | ❌ |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw) | A Wasm FDW for [Notion](https://www.notion.so/) | ✅ | ❌ |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw) | A Wasm FDW for [Snowflake](https://www.snowflake.com/) | ✅ | ✅ |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw) | A Wasm FDW for [Paddle](https://www.paddle.com/) | ✅ | ✅ |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw) | A Wasm FDW for [Calendly](https://www.calendly.com/) | ✅ | ❌ |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw) | A Wasm FDW for [Cal.com](https://www.cal.com/) | ✅ | ❌ |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw) | A Wasm FDW for [Clerk](https://www.clerk.com/) | ✅ | ❌ |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw) | A Wasm FDW for [Cloudflare D1](https://developers.cloudflare.com/d1/) | ✅ | ✅ |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw) | A Wasm FDW for [Orb](https://www.withorb.com/) | ✅ | ❌ |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw) | A Wasm FDW for [HubSpot](https://www.hubspot.com/) | ✅ | ❌ |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw) | A Wasm FDW for [Slack](https://www.slack.com/) | ✅ | ❌ |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw) | A FDW for [Apache Iceberg](https://iceberg.apache.org/) | ✅ | ❌ |

### Warning

Restoring a logical backup of a database with a materialized view using a foreign table can fail. For this reason, either do not use foreign tables in materialized views or use them in databases with physical backups enabled.

## Features

- Minimal interface and easy to implement.
- Support for rich data types.
- Support for both sync and async backends, such as RDBMS, RESTful APIs, flat files, etc.
- Built on top of [pgrx](https://github.com/tcdi/pgrx), providing higher-level interfaces without hiding lower-level C APIs.
- `WHERE`, `ORDER BY`, and `LIMIT` pushdown are supported.

## Documentation

- [Usage Docs](https://fdw.dev/)
- [Developer Docs (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Installation

`Wrappers` is a pgrx extension. You can follow the [pgrx installation steps](https://github.com/tcdi/pgrx#system-requirements) to install Wrappers.

Basically, run the following command to install an FDW after `pgrx` is installed. For example,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Developing a FDW

Visit [Wrappers Docs](https://fdw.dev/) for more details.

## License

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---