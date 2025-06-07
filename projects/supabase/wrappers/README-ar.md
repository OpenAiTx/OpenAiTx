# Wrappers

`Wrappers` هو إطار تطوير لـ Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers))، مكتوب بلغة Rust. هدفه تسهيل تطوير FDW لـ Postgres مع الحفاظ على ميزات لغة Rust الحديثة، مثل الأداء العالي، الأنواع القوية، والأمان.

`Wrappers` هو أيضًا مجموعة من FDWs تم تطويرها بواسطة [Supabase](https://www.supabase.com). نحن ندعم حاليًا الـ FDWs التالية، مع وجود المزيد قيد التطوير:

| FDW                                             | الوصف                                                                          | قراءة | تعديل |
| ----------------------------------------------- | ----------------------------------------------------------------------------- | ---- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | FDW تجريبي لشرح كيفية تطوير FDW أساسي.                                |      |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | FDW لـ Google [BigQuery](https://cloud.google.com/bigquery)                | ✅   | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW لـ [ClickHouse](https://clickhouse.com/)                               | ✅   | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | FDW لـ واجهة برمجة تطبيقات [Stripe](https://stripe.com/)                   | ✅   | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | FDW لـ Google [Firebase](https://firebase.google.com/)                     | ✅   | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | FDW لـ واجهة برمجة تطبيقات [Airtable](https://airtable.com/)               | ✅   | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | FDW لـ [AWS S3](https://aws.amazon.com/s3/)                                | ✅   | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | FDW لـ [Logflare](https://logflare.app/)                                   | ✅   | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | FDW لـ [Auth0](https://auth0.com/)                                         | ✅   | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | FDW لـ [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅   | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | FDW لـ [Redis](https://redis.io/)                                          | ✅   | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | FDW لـ [AWS Cognito](https://aws.amazon.com/cognito/)                      | ✅   | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Wasm FDW لـ [Notion](https://www.notion.so/)                               | ✅   | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Wasm FDW لـ [Snowflake](https://www.snowflake.com/)                        | ✅   | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Wasm FDW لـ [Paddle](https://www.paddle.com/)                              | ✅   | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Wasm FDW لـ [Calendly](https://www.calendly.com/)                          | ✅   | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Wasm FDW لـ [Cal.com](https://www.cal.com/)                                | ✅   | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Wasm FDW لـ [Clerk](https://www.clerk.com/)                                | ✅   | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Wasm FDW لـ [Cloudflare D1](https://developers.cloudflare.com/d1/)         | ✅   | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Wasm FDW لـ [Orb](https://www.withorb.com/)                                | ✅   | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Wasm FDW لـ [HubSpot](https://www.hubspot.com/)                            | ✅   | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Wasm FDW لـ [Slack](https://www.slack.com/)                                | ✅   | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| FDW لـ [Apache Iceberg](https://iceberg.apache.org/)                       | ✅   | ❌     |

### تحذير

قد يفشل استرجاع نسخة احتياطية منطقية لقاعدة بيانات تحتوي على view مادي يستخدم جدول أجنبي. لهذا السبب، لا تستخدم الجداول الأجنبية في views المادية أو استخدمها فقط في قواعد بيانات مفعّل بها النسخ الاحتياطي الفيزيائي.

## الميزات

- واجهة بسيطة وسهلة التنفيذ.
- دعم لأنواع بيانات غنية.
- دعم لكل من الخلفيات المتزامنة وغير المتزامنة، مثل RDBMS، RESTful APIs، ملفات مسطحة وغيرها.
- مبني على [pgrx](https://github.com/tcdi/pgrx)، ويوفر واجهات عالية المستوى دون إخفاء واجهات C منخفضة المستوى.
- دعم ترحيل شروط `WHERE`، و `ORDER BY`، و `LIMIT`.

## التوثيق

- [وثائق الاستخدام](https://fdw.dev/)
- [وثائق المطورين (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## التثبيت

`Wrappers` هو إضافة pgrx، يمكنك اتباع [خطوات تثبيت pgrx](https://github.com/tcdi/pgrx#system-requirements) لتثبيت Wrappers.

ببساطة، شغل الأمر التالي لتثبيت FDW بعد تثبيت `pgrx`. على سبيل المثال:

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## تطوير FDW

قم بزيارة [وثائق Wrappers](https://fdw.dev/) لمزيد من التفاصيل.

## الرخصة

[رخصة أباتشي الإصدار 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---