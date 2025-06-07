# Wrappers

`Wrappers` é um framework de desenvolvimento para Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), escrito em Rust. Seu objetivo é facilitar o desenvolvimento de FDWs para Postgres, mantendo as capacidades modernas da linguagem Rust, como alta performance, tipos fortes e segurança.

`Wrappers` também é uma coleção de FDWs desenvolvidos pela [Supabase](https://www.supabase.com). Atualmente, oferecemos suporte aos seguintes FDWs, com mais em desenvolvimento:

| FDW                                                                                               | Descrição                                                                           | Leitura | Modificação |
| ------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ------- | ----------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Um FDW de demonstração para mostrar como desenvolver um FDW básico.                 |         |             |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Um FDW para o Google [BigQuery](https://cloud.google.com/bigquery)                  | ✅      | ✅          |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | Um FDW para [ClickHouse](https://clickhouse.com/)                                   | ✅      | ✅          |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | Um FDW para a API do [Stripe](https://stripe.com/)                                  | ✅      | ✅          |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Um FDW para o Google [Firebase](https://firebase.google.com/)                       | ✅      | ❌          |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | Um FDW para a API do [Airtable](https://airtable.com/)                              | ✅      | ❌          |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | Um FDW para o [AWS S3](https://aws.amazon.com/s3/)                                  | ✅      | ❌          |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | Um FDW para o [Logflare](https://logflare.app/)                                     | ✅      | ❌          |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | Um FDW para o [Auth0](https://auth0.com/)                                           | ✅      | ❌          |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | Um FDW para o [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)   | ✅      | ❌          |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | Um FDW para o [Redis](https://redis.io/)                                            | ✅      | ❌          |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | Um FDW para o [AWS Cognito](https://aws.amazon.com/cognito/)                        | ✅      | ❌          |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Um FDW Wasm para o [Notion](https://www.notion.so/)                                 | ✅      | ❌          |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Um FDW Wasm para o [Snowflake](https://www.snowflake.com/)                          | ✅      | ✅          |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Um FDW Wasm para o [Paddle](https://www.paddle.com/)                                | ✅      | ✅          |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Um FDW Wasm para o [Calendly](https://www.calendly.com/)                            | ✅      | ❌          |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Um FDW Wasm para o [Cal.com](https://www.cal.com/)                                  | ✅      | ❌          |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Um FDW Wasm para o [Clerk](https://www.clerk.com/)                                  | ✅      | ❌          |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Um FDW Wasm para o [Cloudflare D1](https://developers.cloudflare.com/d1/)           | ✅      | ✅          |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Um FDW Wasm para o [Orb](https://www.withorb.com/)                                  | ✅      | ❌          |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Um FDW Wasm para o [HubSpot](https://www.hubspot.com/)                              | ✅      | ❌          |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Um FDW Wasm para o [Slack](https://www.slack.com/)                                  | ✅      | ❌          |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| Um FDW para o [Apache Iceberg](https://iceberg.apache.org/)                         | ✅      | ❌          |

### Aviso

A restauração de um backup lógico de um banco de dados com uma visualização materializada utilizando uma foreign table pode falhar. Por este motivo, não utilize foreign tables em visualizações materializadas ou utilize-as apenas em bancos de dados com backups físicos ativados.

## Funcionalidades

- Interface mínima e fácil de implementar.
- Suporte a tipos de dados ricos.
- Suporte a backends síncronos e assíncronos, como RDBMS, APIs RESTful, arquivos planos, etc.
- Construído sobre [pgrx](https://github.com/tcdi/pgrx), fornecendo interfaces de alto nível sem esconder as APIs em C de baixo nível.
- Suporte a pushdown de `WHERE`, `ORDER BY`, `LIMIT`.

## Documentação

- [Documentação de Uso](https://fdw.dev/)
- [Documentação do Desenvolvedor (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Instalação

`Wrappers` é uma extensão pgrx. Você pode seguir os [passos de instalação do pgrx](https://github.com/tcdi/pgrx#system-requirements) para instalar o Wrappers.

Basicamente, execute o comando abaixo para instalar o FDW após a instalação do `pgrx`. Por exemplo,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Desenvolvendo um FDW

Consulte a [Documentação do Wrappers](https://fdw.dev/) para mais detalhes.

## Licença

[Licença Apache Versão 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---