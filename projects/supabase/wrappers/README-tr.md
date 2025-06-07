# Wrappers

`Wrappers`, Rust ile yazılmış bir Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)) geliştirme çatısıdır. Amacı, Postgres FDW geliştirmeyi kolaylaştırmak ve Rust dilinin modern yeteneklerini (yüksek performans, güçlü tipler ve güvenlik gibi) korumaktır.

`Wrappers`, aynı zamanda [Supabase](https://www.supabase.com) tarafından oluşturulan FDW'lerin bir koleksiyonudur. Şu anda aşağıdaki FDW'leri destekliyoruz ve daha fazlası geliştirilmektedir:

| FDW                                                                                              | Açıklama                                                                             | Okuma | Değiştirme |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ----- | ---------- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | Temel bir FDW'nin nasıl geliştirileceğini gösteren bir demo FDW.                      |       |            |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Google [BigQuery](https://cloud.google.com/bigquery) için bir FDW                     | ✅    | ✅         |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | [ClickHouse](https://clickhouse.com/) için bir FDW                                   | ✅    | ✅         |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | [Stripe](https://stripe.com/) API için bir FDW                                       | ✅    | ✅         |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Google [Firebase](https://firebase.google.com/) için bir FDW                         | ✅    | ❌         |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | [Airtable](https://airtable.com/) API için bir FDW                                   | ✅    | ❌         |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | [AWS S3](https://aws.amazon.com/s3/) için bir FDW                                    | ✅    | ❌         |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | [Logflare](https://logflare.app/) için bir FDW                                       | ✅    | ❌         |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | [Auth0](https://auth0.com/) için bir FDW                                             | ✅    | ❌         |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) için bir FDW     | ✅    | ❌         |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | [Redis](https://redis.io/) için bir FDW                                              | ✅    | ❌         |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | [AWS Cognito](https://aws.amazon.com/cognito/) için bir FDW                          | ✅    | ❌         |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | [Notion](https://www.notion.so/) için bir Wasm FDW                                   | ✅    | ❌         |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | [Snowflake](https://www.snowflake.com/) için bir Wasm FDW                            | ✅    | ✅         |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | [Paddle](https://www.paddle.com/) için bir Wasm FDW                                  | ✅    | ✅         |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | [Calendly](https://www.calendly.com/) için bir Wasm FDW                              | ✅    | ❌         |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | [Cal.com](https://www.cal.com/) için bir Wasm FDW                                    | ✅    | ❌         |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | [Clerk](https://www.clerk.com/) için bir Wasm FDW                                    | ✅    | ❌         |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | [Cloudflare D1](https://developers.cloudflare.com/d1/) için bir Wasm FDW             | ✅    | ✅         |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | [Orb](https://www.withorb.com/) için bir Wasm FDW                                    | ✅    | ❌         |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | [HubSpot](https://www.hubspot.com/) için bir Wasm FDW                                | ✅    | ❌         |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | [Slack](https://www.slack.com/) için bir Wasm FDW                                    | ✅    | ❌         |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| [Apache Iceberg](https://iceberg.apache.org/) için bir FDW                           | ✅    | ❌         |

### Uyarı

Bir yabancı tablo kullanan bir materyalize görünümü içeren veritabanının mantıksal yedeğini geri yüklemek başarısız olabilir. Bu nedenle, ya materyalize görünümlerde yabancı tablolar kullanmayın ya da fiziksel yedeklemeleri etkin olan veritabanlarında kullanın.

## Özellikler

- Minimum arayüz ve kolay uygulanabilirlik.
- Zengin veri tipleri desteği.
- RDBMS, RESTful API'ler, düz dosyalar vb. gibi hem senkron hem de asenkron arka uç desteği.
- [pgrx](https://github.com/tcdi/pgrx) üzerine inşa edilmiştir, alt seviye C API'lerini gizlemeden üst seviye arayüzler sunar.
- `WHERE`, `ORDER BY`, `LIMIT` pushdown desteklenir.

## Dokümantasyon

- [Kullanım Dokümanları](https://fdw.dev/)
- [Geliştirici Dokümanları (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## Kurulum

`Wrappers`, bir pgrx eklentisidir, Wrappers'ı kurmak için [pgrx kurulum adımlarını](https://github.com/tcdi/pgrx#system-requirements) takip edebilirsiniz.

Temelde, `pgrx` yüklendikten sonra aşağıdaki komutu çalıştırarak FDW'yi kurabilirsiniz. Örneğin,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## FDW Geliştirme

Daha fazla detay için [Wrappers Dokümanları](https://fdw.dev/) adresini ziyaret edin.

## Lisans

[Apache Lisansı Sürüm 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---