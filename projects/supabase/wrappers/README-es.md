# Wrappers

`Wrappers` es un framework de desarrollo para Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), escrito en Rust. Su objetivo es facilitar el desarrollo de FDW para Postgres, manteniendo las capacidades modernas del lenguaje Rust, como alto rendimiento, tipos fuertes y seguridad.

`Wrappers` también es una colección de FDWs construidos por [Supabase](https://www.supabase.com). Actualmente soportamos los siguientes FDWs, con más en desarrollo:

| FDW                                             | Descripción                                                                   | Lectura | Modificar |
| ----------------------------------------------- | ----------------------------------------------------------------------------- | ------- | --------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Un FDW de demostración para mostrar cómo desarrollar un FDW básico.            |         |           |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Un FDW para Google [BigQuery](https://cloud.google.com/bigquery)               | ✅      | ✅        |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | Un FDW para [ClickHouse](https://clickhouse.com/)                              | ✅      | ✅        |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | Un FDW para la API de [Stripe](https://stripe.com/)                            | ✅      | ✅        |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Un FDW para Google [Firebase](https://firebase.google.com/)                    | ✅      | ❌        |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | Un FDW para la API de [Airtable](https://airtable.com/)                        | ✅      | ❌        |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | Un FDW para [AWS S3](https://aws.amazon.com/s3/)                               | ✅      | ❌        |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | Un FDW para [Logflare](https://logflare.app/)                                  | ✅      | ❌        |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | Un FDW para [Auth0](https://auth0.com/)                                        | ✅      | ❌        |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | Un FDW para [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅      | ❌        |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | Un FDW para [Redis](https://redis.io/)                                         | ✅      | ❌        |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | Un FDW para [AWS Cognito](https://aws.amazon.com/cognito/)                     | ✅      | ❌        |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Un FDW Wasm para [Notion](https://www.notion.so/)                              | ✅      | ❌        |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Un FDW Wasm para [Snowflake](https://www.snowflake.com/)                       | ✅      | ✅        |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Un FDW Wasm para [Paddle](https://www.paddle.com/)                             | ✅      | ✅        |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Un FDW Wasm para [Calendly](https://www.calendly.com/)                         | ✅      | ❌        |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Un FDW Wasm para [Cal.com](https://www.cal.com/)                               | ✅      | ❌        |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Un FDW Wasm para [Clerk](https://www.clerk.com/)                               | ✅      | ❌        |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Un FDW Wasm para [Cloudflare D1](https://developers.cloudflare.com/d1/)        | ✅      | ✅        |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Un FDW Wasm para [Orb](https://www.withorb.com/)                               | ✅      | ❌        |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Un FDW Wasm para [HubSpot](https://www.hubspot.com/)                           | ✅      | ❌        |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Un FDW Wasm para [Slack](https://www.slack.com/)                               | ✅      | ❌        |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| Un FDW para [Apache Iceberg](https://iceberg.apache.org/)                      | ✅      | ❌        |

### Advertencia

Restaurar una copia de seguridad lógica de una base de datos que use una vista materializada con una tabla foránea puede fallar. Por esta razón, no utilice tablas foráneas en vistas materializadas o utilícelas solo en bases de datos con copias de seguridad físicas habilitadas.

## Características

- Interfaz mínima y fácil de implementar.
- Soporte para tipos de datos enriquecidos.
- Soporte tanto para backends síncronos como asíncronos, como RDBMS, APIs RESTful, archivos planos, etc.
- Construido sobre [pgrx](https://github.com/tcdi/pgrx), proporcionando interfaces de alto nivel, sin ocultar las APIs en C de bajo nivel.
- Se soporta pushdown de `WHERE`, `ORDER BY`, `LIMIT`.

## Documentación

- [Documentación de uso](https://fdw.dev/)
- [Documentación para desarrolladores (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Instalación

`Wrappers` es una extensión pgrx, puedes seguir los [pasos de instalación de pgrx](https://github.com/tcdi/pgrx#system-requirements) para instalar Wrappers.

Básicamente, ejecuta el siguiente comando para instalar el FDW después de instalar `pgrx`. Por ejemplo,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Desarrollo de un FDW

Visita [Wrappers Docs](https://fdw.dev/) para más detalles.

## Licencia

[Licencia Apache Versión 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---