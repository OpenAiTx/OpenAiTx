# Wrappers

`Wrappers` est un framework de développement pour les Foreign Data Wrappers (FDW) de Postgres ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), écrit en Rust. Son objectif est de faciliter le développement de FDW pour Postgres tout en conservant les capacités modernes du langage Rust, telles que la haute performance, la robustesse des types et la sécurité.

`Wrappers` est également une collection de FDW développés par [Supabase](https://www.supabase.com). Nous prenons actuellement en charge les FDW suivants, d'autres étant en cours de développement :

| FDW                                                                                              | Description                                                                              | Lecture | Modification |
| ------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------- | ------- | ------------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Un FDW de démonstration pour montrer comment développer un FDW basique.                 |         |              |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Un FDW pour Google [BigQuery](https://cloud.google.com/bigquery)                        | ✅      | ✅           |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | Un FDW pour [ClickHouse](https://clickhouse.com/)                                       | ✅      | ✅           |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | Un FDW pour l’API [Stripe](https://stripe.com/)                                         | ✅      | ✅           |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Un FDW pour Google [Firebase](https://firebase.google.com/)                             | ✅      | ❌           |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | Un FDW pour l’API [Airtable](https://airtable.com/)                                     | ✅      | ❌           |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | Un FDW pour [AWS S3](https://aws.amazon.com/s3/)                                        | ✅      | ❌           |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | Un FDW pour [Logflare](https://logflare.app/)                                           | ✅      | ❌           |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | Un FDW pour [Auth0](https://auth0.com/)                                                 | ✅      | ❌           |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | Un FDW pour [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)         | ✅      | ❌           |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | Un FDW pour [Redis](https://redis.io/)                                                  | ✅      | ❌           |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | Un FDW pour [AWS Cognito](https://aws.amazon.com/cognito/)                              | ✅      | ❌           |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Un FDW Wasm pour [Notion](https://www.notion.so/)                                       | ✅      | ❌           |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Un FDW Wasm pour [Snowflake](https://www.snowflake.com/)                                | ✅      | ✅           |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Un FDW Wasm pour [Paddle](https://www.paddle.com/)                                      | ✅      | ✅           |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Un FDW Wasm pour [Calendly](https://www.calendly.com/)                                  | ✅      | ❌           |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Un FDW Wasm pour [Cal.com](https://www.cal.com/)                                        | ✅      | ❌           |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Un FDW Wasm pour [Clerk](https://www.clerk.com/)                                        | ✅      | ❌           |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Un FDW Wasm pour [Cloudflare D1](https://developers.cloudflare.com/d1/)                 | ✅      | ✅           |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Un FDW Wasm pour [Orb](https://www.withorb.com/)                                        | ✅      | ❌           |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Un FDW Wasm pour [HubSpot](https://www.hubspot.com/)                                    | ✅      | ❌           |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Un FDW Wasm pour [Slack](https://www.slack.com/)                                        | ✅      | ❌           |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| Un FDW pour [Apache Iceberg](https://iceberg.apache.org/)                               | ✅      | ❌           |

### Avertissement

La restauration d’une sauvegarde logique d’une base de données contenant une vue matérialisée utilisant une table étrangère peut échouer. Pour cette raison, n’utilisez pas de tables étrangères dans les vues matérialisées ou utilisez-les uniquement dans des bases de données pour lesquelles les sauvegardes physiques sont activées.

## Fonctionnalités

- Interface minimale et facile à implémenter.
- Prise en charge de types de données riches.
- Prise en charge des backends synchrones et asynchrones, tels que les SGBDR, APIs RESTful, fichiers plats, etc.
- Construit sur [pgrx](https://github.com/tcdi/pgrx), offrant des interfaces de haut niveau sans masquer les API C de bas niveau.
- `WHERE`, `ORDER BY`, `LIMIT` sont pris en charge en pushdown.

## Documentation

- [Documentation d’utilisation](https://fdw.dev/)
- [Documentation développeur (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Installation

`Wrappers` est une extension pgrx. Vous pouvez suivre les [étapes d’installation de pgrx](https://github.com/tcdi/pgrx#system-requirements) pour installer Wrappers.

En résumé, exécutez la commande suivante pour installer un FDW après avoir installé `pgrx`. Par exemple :

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Développer un FDW

Consultez la [documentation Wrappers](https://fdw.dev/) pour plus de détails.

## Licence

[Licence Apache Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributeurs](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---