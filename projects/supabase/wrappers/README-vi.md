# Wrappers

`Wrappers` là một framework phát triển cho Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), được viết bằng Rust. Mục tiêu của nó là giúp việc phát triển Postgres FDW trở nên dễ dàng hơn trong khi vẫn giữ được các khả năng hiện đại của ngôn ngữ Rust, như hiệu năng cao, kiểu dữ liệu mạnh và an toàn.

`Wrappers` cũng là một tập hợp các FDW được xây dựng bởi [Supabase](https://www.supabase.com). Hiện tại chúng tôi hỗ trợ các FDW sau, với nhiều FDW khác đang được phát triển:

| FDW                                             | Mô tả                                                                            | Đọc | Sửa đổi |
| ----------------------------------------------- | --------------------------------------------------------------------------------- | ---- | ------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | FDW demo để minh họa cách phát triển một FDW cơ bản.                              |      |         |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | FDW cho Google [BigQuery](https://cloud.google.com/bigquery)                      | ✅   | ✅      |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW cho [ClickHouse](https://clickhouse.com/)                                     | ✅   | ✅      |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | FDW cho API [Stripe](https://stripe.com/)                                         | ✅   | ✅      |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | FDW cho Google [Firebase](https://firebase.google.com/)                           | ✅   | ❌      |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | FDW cho API [Airtable](https://airtable.com/)                                     | ✅   | ❌      |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | FDW cho [AWS S3](https://aws.amazon.com/s3/)                                      | ✅   | ❌      |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | FDW cho [Logflare](https://logflare.app/)                                         | ✅   | ❌      |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | FDW cho [Auth0](https://auth0.com/)                                               | ✅   | ❌      |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | FDW cho [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)       | ✅   | ❌      |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | FDW cho [Redis](https://redis.io/)                                                | ✅   | ❌      |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | FDW cho [AWS Cognito](https://aws.amazon.com/cognito/)                            | ✅   | ❌      |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Wasm FDW cho [Notion](https://www.notion.so/)                                     | ✅   | ❌      |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Wasm FDW cho [Snowflake](https://www.snowflake.com/)                              | ✅   | ✅      |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Wasm FDW cho [Paddle](https://www.paddle.com/)                                    | ✅   | ✅      |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Wasm FDW cho [Calendly](https://www.calendly.com/)                                | ✅   | ❌      |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Wasm FDW cho [Cal.com](https://www.cal.com/)                                      | ✅   | ❌      |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Wasm FDW cho [Clerk](https://www.clerk.com/)                                      | ✅   | ❌      |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Wasm FDW cho [Cloudflare D1](https://developers.cloudflare.com/d1/)               | ✅   | ✅      |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Wasm FDW cho [Orb](https://www.withorb.com/)                                      | ✅   | ❌      |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Wasm FDW cho [HubSpot](https://www.hubspot.com/)                                  | ✅   | ❌      |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Wasm FDW cho [Slack](https://www.slack.com/)                                      | ✅   | ❌      |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| FDW cho [Apache Iceberg](https://iceberg.apache.org/)                             | ✅   | ❌      |

### Cảnh báo

Việc khôi phục bản sao lưu logic của cơ sở dữ liệu chứa materialized view sử dụng foreign table có thể thất bại. Vì vậy, không nên sử dụng foreign table trong materialized view hoặc chỉ sử dụng trên các cơ sở dữ liệu đã bật sao lưu vật lý.

## Tính năng

- Giao diện tối thiểu và dễ dàng triển khai.
- Hỗ trợ các kiểu dữ liệu phong phú.
- Hỗ trợ cả backend đồng bộ và bất đồng bộ, như RDBMS, RESTful API, flat file, v.v.
- Xây dựng dựa trên [pgrx](https://github.com/tcdi/pgrx), cung cấp giao diện cấp cao hơn mà không ẩn các API C cấp thấp.
- Hỗ trợ pushdown `WHERE`, `ORDER BY`, `LIMIT`.

## Tài liệu

- [Hướng dẫn sử dụng](https://fdw.dev/)
- [Tài liệu cho nhà phát triển (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Cài đặt

`Wrappers` là một extension của pgrx, bạn có thể theo [các bước cài đặt pgrx](https://github.com/tcdi/pgrx#system-requirements) để cài đặt Wrappers.

Cơ bản, chạy lệnh bên dưới để cài đặt FDW sau khi đã cài đặt `pgrx`. Ví dụ,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Phát triển FDW

Truy cập [Tài liệu Wrappers](https://fdw.dev/) để biết thêm chi tiết.

## Giấy phép

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---