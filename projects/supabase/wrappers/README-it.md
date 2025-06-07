# Wrappers

`Wrappers` è un framework di sviluppo per Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), scritto in Rust. Il suo obiettivo è rendere più semplice lo sviluppo di FDW per Postgres mantenendo le capacità moderne del linguaggio Rust, come alte prestazioni, tipizzazione forte e sicurezza.

`Wrappers` è anche una raccolta di FDW realizzati da [Supabase](https://www.supabase.com). Attualmente supportiamo i seguenti FDW, con altri in fase di sviluppo:

| FDW                                                                                                             | Descrizione                                                                                         | Lettura | Modifica |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | ------- | -------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw)         | Un FDW dimostrativo per mostrare come sviluppare un FDW di base.                                    |         |          |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)             | Un FDW per Google [BigQuery](https://cloud.google.com/bigquery)                                     | ✅      | ✅       |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw)         | Un FDW per [ClickHouse](https://clickhouse.com/)                                                    | ✅      | ✅       |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)                 | Un FDW per le API di [Stripe](https://stripe.com/)                                                  | ✅      | ✅       |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)             | Un FDW per Google [Firebase](https://firebase.google.com/)                                          | ✅      | ❌       |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)             | Un FDW per le API di [Airtable](https://airtable.com/)                                              | ✅      | ❌       |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                         | Un FDW per [AWS S3](https://aws.amazon.com/s3/)                                                     | ✅      | ❌       |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)             | Un FDW per [Logflare](https://logflare.app/)                                                        | ✅      | ❌       |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)                   | Un FDW per [Auth0](https://auth0.com/)                                                              | ✅      | ❌       |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)              | Un FDW per [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)                      | ✅      | ❌       |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)                   | Un FDW per [Redis](https://redis.io/)                                                               | ✅      | ❌       |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)           | Un FDW per [AWS Cognito](https://aws.amazon.com/cognito/)                                           | ✅      | ❌       |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)                | Un FDW Wasm per [Notion](https://www.notion.so/)                                                    | ✅      | ❌       |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)          | Un FDW Wasm per [Snowflake](https://www.snowflake.com/)                                             | ✅      | ✅       |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)                | Un FDW Wasm per [Paddle](https://www.paddle.com/)                                                   | ✅      | ✅       |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)            | Un FDW Wasm per [Calendly](https://www.calendly.com/)                                               | ✅      | ❌       |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)                  | Un FDW Wasm per [Cal.com](https://www.cal.com/)                                                     | ✅      | ❌       |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)                  | Un FDW Wasm per [Clerk](https://www.clerk.com/)                                                     | ✅      | ❌       |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)           | Un FDW Wasm per [Cloudflare D1](https://developers.cloudflare.com/d1/)                              | ✅      | ✅       |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)                      | Un FDW Wasm per [Orb](https://www.withorb.com/)                                                     | ✅      | ❌       |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)              | Un FDW Wasm per [HubSpot](https://www.hubspot.com/)                                                 | ✅      | ❌       |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)                  | Un FDW Wasm per [Slack](https://www.slack.com/)                                                     | ✅      | ❌       |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)        | Un FDW per [Apache Iceberg](https://iceberg.apache.org/)                                            | ✅      | ❌       |

### Attenzione

Il ripristino di un backup logico di un database con una vista materializzata che utilizza una foreign table può fallire. Per questo motivo, evitare di utilizzare foreign table in viste materializzate oppure utilizzarle in database con backup fisici abilitati.

## Caratteristiche

- Interfaccia minima e facile da implementare.
- Supporto per tipi di dati ricchi.
- Supporto sia per backend sincroni che asincroni, come RDBMS, API RESTful, file flat, ecc.
- Costruito sopra [pgrx](https://github.com/tcdi/pgrx), fornisce interfacce di livello superiore senza nascondere le API C di basso livello.
- Supporta il pushdown di `WHERE`, `ORDER BY`, `LIMIT`.

## Documentazione

- [Documentazione d'Uso](https://fdw.dev/)
- [Documentazione Sviluppatore (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Installazione

`Wrappers` è un'estensione pgrx. Puoi seguire i [passaggi di installazione di pgrx](https://github.com/tcdi/pgrx#system-requirements) per installare Wrappers.

Fondamentalmente, esegui il seguente comando per installare il FDW dopo aver installato `pgrx`. Ad esempio,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Sviluppare un FDW

Visita la [Documentazione Wrappers](https://fdw.dev/) per maggiori dettagli.

## Licenza

[Licenza Apache Versione 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---