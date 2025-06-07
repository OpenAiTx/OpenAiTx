# Wrappers

`Wrappers` is een ontwikkelframework voor Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), geschreven in Rust. Het doel is om de ontwikkeling van Postgres FDW eenvoudiger te maken, terwijl de moderne mogelijkheden van de Rust-taal behouden blijven, zoals hoge prestaties, sterke types en veiligheid.

`Wrappers` is ook een verzameling FDW’s gebouwd door [Supabase](https://www.supabase.com). We ondersteunen momenteel de volgende FDW’s, met meer in ontwikkeling:

| FDW                                                                                             | Beschrijving                                                                          | Lezen | Wijzigen |
| ------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------- | ------ | -------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Een demo-FDW om te laten zien hoe een basis-FDW ontwikkeld kan worden.                |        |          |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Een FDW voor Google [BigQuery](https://cloud.google.com/bigquery)                     | ✅     | ✅       |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | Een FDW voor [ClickHouse](https://clickhouse.com/)                                    | ✅     | ✅       |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | Een FDW voor [Stripe](https://stripe.com/) API                                        | ✅     | ✅       |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Een FDW voor Google [Firebase](https://firebase.google.com/)                          | ✅     | ❌       |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | Een FDW voor [Airtable](https://airtable.com/) API                                    | ✅     | ❌       |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | Een FDW voor [AWS S3](https://aws.amazon.com/s3/)                                     | ✅     | ❌       |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | Een FDW voor [Logflare](https://logflare.app/)                                        | ✅     | ❌       |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | Een FDW voor [Auth0](https://auth0.com/)                                              | ✅     | ❌       |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | Een FDW voor [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)      | ✅     | ❌       |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | Een FDW voor [Redis](https://redis.io/)                                               | ✅     | ❌       |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | Een FDW voor [AWS Cognito](https://aws.amazon.com/cognito/)                           | ✅     | ❌       |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Een Wasm FDW voor [Notion](https://www.notion.so/)                                    | ✅     | ❌       |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Een Wasm FDW voor [Snowflake](https://www.snowflake.com/)                             | ✅     | ✅       |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Een Wasm FDW voor [Paddle](https://www.paddle.com/)                                   | ✅     | ✅       |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Een Wasm FDW voor [Calendly](https://www.calendly.com/)                               | ✅     | ❌       |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Een Wasm FDW voor [Cal.com](https://www.cal.com/)                                     | ✅     | ❌       |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Een Wasm FDW voor [Clerk](https://www.clerk.com/)                                     | ✅     | ❌       |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Een Wasm FDW voor [Cloudflare D1](https://developers.cloudflare.com/d1/)              | ✅     | ✅       |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Een Wasm FDW voor [Orb](https://www.withorb.com/)                                     | ✅     | ❌       |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Een Wasm FDW voor [HubSpot](https://www.hubspot.com/)                                 | ✅     | ❌       |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Een Wasm FDW voor [Slack](https://www.slack.com/)                                     | ✅     | ❌       |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| Een FDW voor [Apache Iceberg](https://iceberg.apache.org/)                            | ✅     | ❌       |

### Waarschuwing

Het herstellen van een logische backup van een database met een gematerialiseerde view die gebruikmaakt van een foreign table kan mislukken. Gebruik om deze reden geen foreign tables in gematerialiseerde views, of gebruik ze alleen in databases met fysieke back-ups ingeschakeld.

## Functionaliteiten

- Minimale interface en eenvoudig te implementeren.
- Ondersteuning voor rijke datatypes.
- Ondersteuning voor zowel synchrone als asynchrone backends, zoals RDBMS, RESTful API’s, flat files, enzovoort.
- Gebouwd bovenop [pgrx](https://github.com/tcdi/pgrx), met hogere interfaces zonder lagere C-API’s te verbergen.
- `WHERE`, `ORDER BY`, `LIMIT` pushdown worden ondersteund.

## Documentatie

- [Gebruikersdocumentatie](https://fdw.dev/)
- [Ontwikkelaarsdocumentatie (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Installatie

`Wrappers` is een pgrx-extensie. Volg de [pgrx installatie-instructies](https://github.com/tcdi/pgrx#system-requirements) om Wrappers te installeren.

Voer daarna onderstaand commando uit om de FDW te installeren, nadat `pgrx` is geïnstalleerd. Bijvoorbeeld:

```bash
cargo pgrx install --pg-config [pad_naar_pg_config] --features stripe_fdw
```

## Ontwikkelen van een FDW

Bezoek de [Wrappers Docs](https://fdw.dev/) voor meer details.

## Licentie

[Apache License Versie 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---