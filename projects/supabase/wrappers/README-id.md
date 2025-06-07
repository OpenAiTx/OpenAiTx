# Wrappers

`Wrappers` adalah kerangka kerja pengembangan untuk Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)), yang ditulis dalam Rust. Tujuannya adalah untuk mempermudah pengembangan Postgres FDW sambil mempertahankan kemampuan modern bahasa Rust, seperti performa tinggi, tipe data yang kuat, dan keamanan.

`Wrappers` juga merupakan kumpulan FDW yang dibuat oleh [Supabase](https://www.supabase.com). Saat ini kami mendukung FDW berikut, dan masih banyak yang sedang dalam pengembangan:

| FDW                                             | Deskripsi                                                                     | Baca | Modifikasi |
| ----------------------------------------------- | ----------------------------------------------------------------------------- | ---- | ---------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | FDW demo untuk menunjukkan cara mengembangkan FDW dasar.                      |      |            |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | FDW untuk Google [BigQuery](https://cloud.google.com/bigquery)                | ✅   | ✅         |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW untuk [ClickHouse](https://clickhouse.com/)                               | ✅   | ✅         |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | FDW untuk API [Stripe](https://stripe.com/)                                   | ✅   | ✅         |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | FDW untuk Google [Firebase](https://firebase.google.com/)                     | ✅   | ❌         |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | FDW untuk API [Airtable](https://airtable.com/)                               | ✅   | ❌         |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | FDW untuk [AWS S3](https://aws.amazon.com/s3/)                                | ✅   | ❌         |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | FDW untuk [Logflare](https://logflare.app/)                                   | ✅   | ❌         |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | FDW untuk [Auth0](https://auth0.com/)                                         | ✅   | ❌         |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | FDW untuk [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) | ✅   | ❌         |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | FDW untuk [Redis](https://redis.io/)                                          | ✅   | ❌         |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | FDW untuk [AWS Cognito](https://aws.amazon.com/cognito/)                      | ✅   | ❌         |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Wasm FDW untuk [Notion](https://www.notion.so/)                               | ✅   | ❌         |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Wasm FDW untuk [Snowflake](https://www.snowflake.com/)                        | ✅   | ✅         |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Wasm FDW untuk [Paddle](https://www.paddle.com/)                              | ✅   | ✅         |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Wasm FDW untuk [Calendly](https://www.calendly.com/)                          | ✅   | ❌         |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Wasm FDW untuk [Cal.com](https://www.cal.com/)                                | ✅   | ❌         |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Wasm FDW untuk [Clerk](https://www.clerk.com/)                                | ✅   | ❌         |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Wasm FDW untuk [Cloudflare D1](https://developers.cloudflare.com/d1/)         | ✅   | ✅         |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Wasm FDW untuk [Orb](https://www.withorb.com/)                                | ✅   | ❌         |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Wasm FDW untuk [HubSpot](https://www.hubspot.com/)                            | ✅   | ❌         |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Wasm FDW untuk [Slack](https://www.slack.com/)                                | ✅   | ❌         |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| FDW untuk [Apache Iceberg](https://iceberg.apache.org/)                       | ✅   | ❌         |

### Peringatan

Restorasi backup logis dari database dengan materialized view yang menggunakan foreign table dapat gagal. Untuk alasan ini, jangan gunakan foreign table di materialized view atau gunakan hanya di database dengan backup fisik yang diaktifkan.

## Fitur

- Antarmuka minimal dan mudah diimplementasikan.
- Dukungan untuk tipe data yang kaya.
- Mendukung backend sinkron dan asinkron, seperti RDBMS, RESTful API, file datar, dan lain-lain.
- Dibangun di atas [pgrx](https://github.com/tcdi/pgrx), menyediakan antarmuka tingkat tinggi tanpa menyembunyikan API C tingkat rendah.
- Mendukung pushdown untuk `WHERE`, `ORDER BY`, dan `LIMIT`.

## Dokumentasi

- [Dokumentasi Penggunaan](https://fdw.dev/)
- [Dokumentasi Pengembang (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Instalasi

`Wrappers` adalah ekstensi pgrx, Anda dapat mengikuti [langkah instalasi pgrx](https://github.com/tcdi/pgrx#system-requirements) untuk menginstal Wrappers.

Pada dasarnya, jalankan perintah di bawah ini untuk menginstal FDW setelah `pgrx` terpasang. Sebagai contoh,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## Mengembangkan FDW

Kunjungi [Dokumentasi Wrappers](https://fdw.dev/) untuk detail lebih lanjut.

## Lisensi

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---