# Wrappers

`Wrappers` — это фреймворк для разработки Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), написанный на Rust. Его цель — упростить разработку Postgres FDW, сохраняя современные возможности языка Rust, такие как высокая производительность, строгая типизация и безопасность.

`Wrappers` также представляет собой коллекцию FDW, созданных [Supabase](https://www.supabase.com). В настоящее время поддерживаются следующие FDW, и ведётся разработка новых:

| FDW                                              | Описание                                                                     | Чтение | Изменение |
| ------------------------------------------------ | ---------------------------------------------------------------------------- | ------ | --------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Демонстрационный FDW, показывающий, как создать базовый FDW.                |        |           |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | FDW для Google [BigQuery](https://cloud.google.com/bigquery)                 | ✅     | ✅         |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW для [ClickHouse](https://clickhouse.com/)                                | ✅     | ✅         |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | FDW для API [Stripe](https://stripe.com/)                                    | ✅     | ✅         |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | FDW для Google [Firebase](https://firebase.google.com/)                      | ✅     | ❌         |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | FDW для API [Airtable](https://airtable.com/)                                | ✅     | ❌         |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | FDW для [AWS S3](https://aws.amazon.com/s3/)                                 | ✅     | ❌         |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | FDW для [Logflare](https://logflare.app/)                                    | ✅     | ❌         |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | FDW для [Auth0](https://auth0.com/)                                          | ✅     | ❌         |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | FDW для [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)  | ✅     | ❌         |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | FDW для [Redis](https://redis.io/)                                           | ✅     | ❌         |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | FDW для [AWS Cognito](https://aws.amazon.com/cognito/)                       | ✅     | ❌         |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Wasm FDW для [Notion](https://www.notion.so/)                                | ✅     | ❌         |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Wasm FDW для [Snowflake](https://www.snowflake.com/)                         | ✅     | ✅         |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Wasm FDW для [Paddle](https://www.paddle.com/)                               | ✅     | ✅         |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Wasm FDW для [Calendly](https://www.calendly.com/)                           | ✅     | ❌         |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Wasm FDW для [Cal.com](https://www.cal.com/)                                 | ✅     | ❌         |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Wasm FDW для [Clerk](https://www.clerk.com/)                                 | ✅     | ❌         |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Wasm FDW для [Cloudflare D1](https://developers.cloudflare.com/d1/)          | ✅     | ✅         |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Wasm FDW для [Orb](https://www.withorb.com/)                                 | ✅     | ❌         |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Wasm FDW для [HubSpot](https://www.hubspot.com/)                             | ✅     | ❌         |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Wasm FDW для [Slack](https://www.slack.com/)                                 | ✅     | ❌         |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| FDW для [Apache Iceberg](https://iceberg.apache.org/)                        | ✅     | ❌         |

### Внимание

Восстановление логического бэкапа базы данных с материализованным представлением, использующим внешнюю таблицу, может завершиться неудачей. По этой причине либо не используйте внешние таблицы в материализованных представлениях, либо используйте их только в базах данных с включёнными физическими бэкапами.

## Возможности

- Минимальный интерфейс и простота реализации.
- Поддержка богатых типов данных.
- Поддержка синхронных и асинхронных источников данных, таких как СУБД, RESTful API, плоские файлы и др.
- Построен на основе [pgrx](https://github.com/tcdi/pgrx), предоставляя более высокоуровневый интерфейс без сокрытия низкоуровневых C API.
- Поддерживается pushdown для `WHERE`, `ORDER BY`, `LIMIT`.

## Документация

- [Документация по использованию](https://fdw.dev/)
- [Документация для разработчиков (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Установка

`Wrappers` — это расширение pgrx, вы можете следовать [инструкциям по установке pgrx](https://github.com/tcdi/pgrx#system-requirements) для установки Wrappers.

В основном, выполните следующую команду для установки FDW после установки `pgrx`. Например,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Разработка FDW

Посетите [документацию Wrappers](https://fdw.dev/) для получения подробной информации.

## Лицензия

[Лицензия Apache Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---