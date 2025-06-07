# Wrappers

`Wrappers` ist ein Entwicklungsframework für Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), geschrieben in Rust. Das Ziel ist es, die Entwicklung von Postgres FDWs zu erleichtern und gleichzeitig die modernen Fähigkeiten der Programmiersprache Rust wie hohe Performance, starke Typisierung und Sicherheit zu bewahren.

`Wrappers` ist außerdem eine Sammlung von FDWs, die von [Supabase](https://www.supabase.com) entwickelt wurden. Zurzeit unterstützen wir die folgenden FDWs, weitere sind in Entwicklung:

| FDW                                             | Beschreibung                                                                  | Lesen | Ändern |
| ----------------------------------------------- | ----------------------------------------------------------------------------- | ----- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Ein Demo-FDW, das zeigt, wie man einen einfachen FDW entwickelt.               |       |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Ein FDW für Google [BigQuery](https://cloud.google.com/bigquery)               | ✅    | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | Ein FDW für [ClickHouse](https://clickhouse.com/)                              | ✅    | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | Ein FDW für die [Stripe](https://stripe.com/) API                              | ✅    | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Ein FDW für Google [Firebase](https://firebase.google.com/)                    | ✅    | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | Ein FDW für die [Airtable](https://airtable.com/) API                          | ✅    | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | Ein FDW für [AWS S3](https://aws.amazon.com/s3/)                               | ✅    | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | Ein FDW für [Logflare](https://logflare.app/)                                  | ✅    | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | Ein FDW für [Auth0](https://auth0.com/)                                        | ✅    | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | Ein FDW für [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅   | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | Ein FDW für [Redis](https://redis.io/)                                         | ✅    | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | Ein FDW für [AWS Cognito](https://aws.amazon.com/cognito/)                     | ✅    | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Ein Wasm-FDW für [Notion](https://www.notion.so/)                              | ✅    | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Ein Wasm-FDW für [Snowflake](https://www.snowflake.com/)                       | ✅    | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Ein Wasm-FDW für [Paddle](https://www.paddle.com/)                             | ✅    | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Ein Wasm-FDW für [Calendly](https://www.calendly.com/)                         | ✅    | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Ein Wasm-FDW für [Cal.com](https://www.cal.com/)                               | ✅    | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Ein Wasm-FDW für [Clerk](https://www.clerk.com/)                               | ✅    | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Ein Wasm-FDW für [Cloudflare D1](https://developers.cloudflare.com/d1/)        | ✅    | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Ein Wasm-FDW für [Orb](https://www.withorb.com/)                               | ✅    | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Ein Wasm-FDW für [HubSpot](https://www.hubspot.com/)                           | ✅    | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Ein Wasm-FDW für [Slack](https://www.slack.com/)                               | ✅    | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| Ein FDW für [Apache Iceberg](https://iceberg.apache.org/)                      | ✅    | ❌     |

### Warnung

Das Wiederherstellen eines logischen Backups einer Datenbank mit einer materialisierten Ansicht, die eine Fremdtabelle verwendet, kann fehlschlagen. Aus diesem Grund sollten entweder keine Fremdtabellen in materialisierten Ansichten verwendet werden oder sie sollten in Datenbanken mit aktivierten physischen Backups genutzt werden.

## Funktionen

- Minimales Interface und einfach zu implementieren.
- Unterstützung für viele Datentypen.
- Unterstützung für synchrone und asynchrone Backends, wie RDBMS, RESTful APIs, Flat Files usw.
- Basierend auf [pgrx](https://github.com/tcdi/pgrx), bietet höherwertige Interfaces, ohne die Low-Level-C-APIs zu verstecken.
- `WHERE`, `ORDER BY`, `LIMIT` Pushdown werden unterstützt.

## Dokumentation

- [Usage Docs](https://fdw.dev/)
- [Entwicklerdokumentation (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Installation

`Wrappers` ist eine pgrx-Erweiterung. Du kannst den [pgrx Installationsschritten](https://github.com/tcdi/pgrx#system-requirements) folgen, um Wrappers zu installieren.

Im Prinzip führe nach der Installation von `pgrx` folgenden Befehl aus, um das FDW zu installieren. Zum Beispiel:

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Entwicklung eines FDW

Für weitere Details besuche die [Wrappers-Dokumentation](https://fdw.dev/).

## Lizenz

[Apache Lizenz Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---