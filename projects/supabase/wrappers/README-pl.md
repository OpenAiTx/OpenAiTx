# Wrappers

`Wrappers` to framework deweloperski dla Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), napisany w języku Rust. Jego celem jest ułatwienie tworzenia FDW dla Postgresa przy zachowaniu nowoczesnych możliwości języka Rust, takich jak wysoka wydajność, silne typowanie i bezpieczeństwo.

`Wrappers` to również kolekcja FDW stworzonych przez [Supabase](https://www.supabase.com). Obecnie obsługujemy następujące FDW, a kolejne są w trakcie rozwoju:

| FDW | Opis | Odczyt | Modyfikacja |
| ----------------------------------------------- | ----------------------------------------------------------------------------- | ---- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Demo FDW pokazujące jak stworzyć podstawowy FDW. | | |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw) | FDW dla Google [BigQuery](https://cloud.google.com/bigquery) | ✅ | ✅ |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW dla [ClickHouse](https://clickhouse.com/) | ✅ | ✅ |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw) | FDW dla API [Stripe](https://stripe.com/) | ✅ | ✅ |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw) | FDW dla Google [Firebase](https://firebase.google.com/) | ✅ | ❌ |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw) | FDW dla API [Airtable](https://airtable.com/) | ✅ | ❌ |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw) | FDW dla [AWS S3](https://aws.amazon.com/s3/) | ✅ | ❌ |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw) | FDW dla [Logflare](https://logflare.app/) | ✅ | ❌ |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw) | FDW dla [Auth0](https://auth0.com/) | ✅ | ❌ |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw) | FDW dla [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅ | ❌ |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw) | FDW dla [Redis](https://redis.io/) | ✅ | ❌ |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw) | FDW dla [AWS Cognito](https://aws.amazon.com/cognito/) | ✅ | ❌ |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw) | Wasm FDW dla [Notion](https://www.notion.so/) | ✅ | ❌ |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw) | Wasm FDW dla [Snowflake](https://www.snowflake.com/) | ✅ | ✅ |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw) | Wasm FDW dla [Paddle](https://www.paddle.com/) | ✅ | ✅ |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw) | Wasm FDW dla [Calendly](https://www.calendly.com/) | ✅ | ❌ |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw) | Wasm FDW dla [Cal.com](https://www.cal.com/) | ✅ | ❌ |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw) | Wasm FDW dla [Clerk](https://www.clerk.com/) | ✅ | ❌ |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw) | Wasm FDW dla [Cloudflare D1](https://developers.cloudflare.com/d1/) | ✅ | ✅ |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw) | Wasm FDW dla [Orb](https://www.withorb.com/) | ✅ | ❌ |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw) | Wasm FDW dla [HubSpot](https://www.hubspot.com/) | ✅ | ❌ |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw) | Wasm FDW dla [Slack](https://www.slack.com/) | ✅ | ❌ |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw) | FDW dla [Apache Iceberg](https://iceberg.apache.org/) | ✅ | ❌ |

### Ostrzeżenie

Przywracanie logicznej kopii zapasowej bazy danych z widokiem zmaterializowanym korzystającym z tabeli zdalnej może się nie powieść. Z tego powodu albo nie używaj tabel zdalnych w widokach zmaterializowanych, albo używaj ich w bazach danych z włączonymi kopiiami zapasowymi fizycznymi.

## Funkcjonalności

- Minimalny interfejs i łatwa implementacja.
- Obsługa bogatych typów danych.
- Wsparcie dla backendów synchronicznych i asynchronicznych, takich jak RDBMS, RESTful API, pliki płaskie itd.
- Zbudowany na [pgrx](https://github.com/tcdi/pgrx), oferuje wyższy poziom interfejsów bez ukrywania niższych C API.
- Obsługa pushdown dla `WHERE`, `ORDER BY`, `LIMIT`.

## Dokumentacja

- [Dokumentacja użytkowania](https://fdw.dev/)
- [Dokumentacja deweloperska (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Instalacja

`Wrappers` to rozszerzenie pgrx, możesz postępować zgodnie z [instrukcją instalacji pgrx](https://github.com/tcdi/pgrx#system-requirements), aby zainstalować Wrappers.

Podstawowo, po zainstalowaniu `pgrx` uruchom poniższe polecenie, aby zainstalować FDW, np.:

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Tworzenie FDW

Odwiedź [Wrappers Docs](https://fdw.dev/) po więcej szczegółów.

## Licencja

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---