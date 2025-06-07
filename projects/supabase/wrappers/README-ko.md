# Wrappers

`Wrappers`는 Rust로 작성된 Postgres Foreign Data Wrappers([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)) 개발 프레임워크입니다. 이 프레임워크의 목표는 Postgres FDW 개발을 더 쉽게 하면서도 Rust 언어의 현대적인 기능(고성능, 강력한 타입, 안전성 등)을 유지하는 것입니다.

`Wrappers`는 또한 [Supabase](https://www.supabase.com)에서 개발한 FDW 모음입니다. 현재 아래 FDW들을 지원하며, 더 많은 FDW가 개발 중입니다:

| FDW                                                                                                      | 설명                                                                                 | 읽기 | 수정  |
| -------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------ | ---- | ----- |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw)   | 기본 FDW 개발 방법을 보여주는 데모 FDW                                                |      |       |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)       | Google [BigQuery](https://cloud.google.com/bigquery)을 위한 FDW                       | ✅   | ✅    |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw)   | [ClickHouse](https://clickhouse.com/)를 위한 FDW                                     | ✅   | ✅    |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)           | [Stripe](https://stripe.com/) API를 위한 FDW                                         | ✅   | ✅    |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)       | Google [Firebase](https://firebase.google.com/)를 위한 FDW                           | ✅   | ❌    |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)       | [Airtable](https://airtable.com/) API를 위한 FDW                                     | ✅   | ❌    |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                   | [AWS S3](https://aws.amazon.com/s3/)를 위한 FDW                                      | ✅   | ❌    |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)       | [Logflare](https://logflare.app/)를 위한 FDW                                         | ✅   | ❌    |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)             | [Auth0](https://auth0.com/)를 위한 FDW                                               | ✅   | ❌    |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)        | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)를 위한 FDW        | ✅   | ❌    |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)             | [Redis](https://redis.io/)를 위한 FDW                                                | ✅   | ❌    |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)     | [AWS Cognito](https://aws.amazon.com/cognito/)를 위한 FDW                            | ✅   | ❌    |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)          | [Notion](https://www.notion.so/)을 위한 Wasm FDW                                     | ✅   | ❌    |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)    | [Snowflake](https://www.snowflake.com/)을 위한 Wasm FDW                              | ✅   | ✅    |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)          | [Paddle](https://www.paddle.com/)을 위한 Wasm FDW                                    | ✅   | ✅    |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)      | [Calendly](https://www.calendly.com/)를 위한 Wasm FDW                                | ✅   | ❌    |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)            | [Cal.com](https://www.cal.com/)을 위한 Wasm FDW                                      | ✅   | ❌    |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)            | [Clerk](https://www.clerk.com/)을 위한 Wasm FDW                                      | ✅   | ❌    |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)     | [Cloudflare D1](https://developers.cloudflare.com/d1/)을 위한 Wasm FDW               | ✅   | ✅    |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)                | [Orb](https://www.withorb.com/)를 위한 Wasm FDW                                      | ✅   | ❌    |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)        | [HubSpot](https://www.hubspot.com/)을 위한 Wasm FDW                                  | ✅   | ❌    |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)            | [Slack](https://www.slack.com/)을 위한 Wasm FDW                                      | ✅   | ❌    |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)  | [Apache Iceberg](https://iceberg.apache.org/)를 위한 FDW                             | ✅   | ❌    |

### 경고

Foreign table이 포함된 물리화 뷰가 있는 데이터베이스의 논리 백업을 복원할 때 실패할 수 있습니다. 이로 인해, 물리화 뷰에서 foreign table을 사용하지 않거나, 물리 백업이 활성화된 데이터베이스에서만 사용하는 것을 권장합니다.

## 특징

- 최소한의 인터페이스와 손쉬운 구현.
- 풍부한 데이터 타입 지원.
- RDBMS, RESTful API, 플랫 파일 등 동기 및 비동기 백엔드 모두 지원.
- [pgrx](https://github.com/tcdi/pgrx) 기반으로, 저수준 C API를 숨기지 않으면서 더 높은 수준의 인터페이스 제공.
- `WHERE`, `ORDER BY`, `LIMIT` 푸시다운 지원.

## 문서

- [사용법 문서](https://fdw.dev/)
- [개발자 문서 (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## 설치

`Wrappers`는 pgrx 확장입니다. [pgrx 설치 방법](https://github.com/tcdi/pgrx#system-requirements)에 따라 Wrappers를 설치할 수 있습니다.

기본적으로, 아래 명령어로 FDW를 설치할 수 있습니다 (`pgrx` 설치 후). 예시:

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## FDW 개발

자세한 내용은 [Wrappers 문서](https://fdw.dev/)를 참고하세요.

## 라이선스

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---