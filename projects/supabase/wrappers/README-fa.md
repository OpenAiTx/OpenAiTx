# Wrappers

`Wrappers` یک چارچوب توسعه برای Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)) است که با زبان Rust نوشته شده است. هدف این پروژه، آسان‌تر کردن توسعه FDW برای Postgres است در حالی که قابلیت‌های مدرن زبان Rust، مانند عملکرد بالا، نوع‌دهی قوی و ایمنی را حفظ می‌کند.

`Wrappers` همچنین مجموعه‌ای از FDWهایی است که توسط [Supabase](https://www.supabase.com) ساخته شده‌اند. در حال حاضر از FDWهای زیر پشتیبانی می‌شود و موارد بیشتری نیز در دست توسعه است:

| FDW                                                                                               | توضیحات                                                                                   | خواندن | ویرایش |
| ------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ------ | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | یک FDW نمایشی برای نشان دادن نحوه توسعه یک FDW پایه.                                     |        |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | یک FDW برای [BigQuery](https://cloud.google.com/bigquery) گوگل                           | ✅     | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | یک FDW برای [ClickHouse](https://clickhouse.com/)                                        | ✅     | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | یک FDW برای API [Stripe](https://stripe.com/)                                            | ✅     | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | یک FDW برای [Firebase](https://firebase.google.com/) گوگل                                | ✅     | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | یک FDW برای API [Airtable](https://airtable.com/)                                        | ✅     | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | یک FDW برای [AWS S3](https://aws.amazon.com/s3/)                                         | ✅     | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | یک FDW برای [Logflare](https://logflare.app/)                                            | ✅     | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | یک FDW برای [Auth0](https://auth0.com/)                                                  | ✅     | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | یک FDW برای [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)          | ✅     | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | یک FDW برای [Redis](https://redis.io/)                                                   | ✅     | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | یک FDW برای [AWS Cognito](https://aws.amazon.com/cognito/)                               | ✅     | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | یک FDW Wasm برای [Notion](https://www.notion.so/)                                        | ✅     | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | یک FDW Wasm برای [Snowflake](https://www.snowflake.com/)                                 | ✅     | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | یک FDW Wasm برای [Paddle](https://www.paddle.com/)                                       | ✅     | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | یک FDW Wasm برای [Calendly](https://www.calendly.com/)                                   | ✅     | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | یک FDW Wasm برای [Cal.com](https://www.cal.com/)                                         | ✅     | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | یک FDW Wasm برای [Clerk](https://www.clerk.com/)                                         | ✅     | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | یک FDW Wasm برای [Cloudflare D1](https://developers.cloudflare.com/d1/)                  | ✅     | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | یک FDW Wasm برای [Orb](https://www.withorb.com/)                                         | ✅     | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | یک FDW Wasm برای [HubSpot](https://www.hubspot.com/)                                     | ✅     | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | یک FDW Wasm برای [Slack](https://www.slack.com/)                                         | ✅     | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| یک FDW برای [Apache Iceberg](https://iceberg.apache.org/)                                | ✅     | ❌     |

### هشدار

بازیابی یک نسخه پشتیبان منطقی از پایگاه داده که دارای یک نمای مادی‌شده (materialized view) با استفاده از جدول خارجی است، ممکن است با خطا مواجه شود. به همین دلیل، یا از جداول خارجی در نماهای مادی‌شده استفاده نکنید یا آن‌ها را فقط در پایگاه داده‌هایی که پشتیبان‌گیری فیزیکی فعال دارند به کار ببرید.

## امکانات

- حداقل رابط کاربری و پیاده‌سازی آسان.
- پشتیبانی از انواع داده‌های غنی.
- پشتیبانی از هر دو backend همزمان (sync) و غیرهمزمان (async)، مانند RDBMS، APIهای RESTful، فایل‌های تخت و غیره.
- ساخته شده بر پایه [pgrx](https://github.com/tcdi/pgrx)، ارائه رابط‌های سطح بالاتر، بدون پنهان کردن APIهای سطح پایین C.
- پشتیبانی از pushdown برای `WHERE`، `ORDER BY`، و `LIMIT`.

## مستندات

- [مستندات استفاده](https://fdw.dev/)
- [مستندات توسعه‌دهنده (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## نصب

`Wrappers` یک افزونه pgrx است، می‌توانید برای نصب Wrappers مراحل [نصب pgrx](https://github.com/tcdi/pgrx#system-requirements) را دنبال کنید.

در اصل، پس از نصب `pgrx`، دستور زیر را برای نصب FDW اجرا کنید. برای مثال:

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## توسعه یک FDW

برای اطلاعات بیشتر به [مستندات Wrappers](https://fdw.dev/) مراجعه کنید.

## مجوز

[مجوز آپاچی نسخه ۲.۰](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---