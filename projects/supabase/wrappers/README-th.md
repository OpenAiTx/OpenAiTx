# Wrappers

`Wrappers` คือเฟรมเวิร์กสำหรับการพัฒนา Postgres Foreign Data Wrappers ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)) ที่เขียนด้วยภาษา Rust โดยมีเป้าหมายเพื่อให้งานพัฒนา Postgres FDW ง่ายขึ้น ในขณะที่ยังคงความสามารถสมัยใหม่ของภาษา Rust เช่น ประสิทธิภาพสูง ระบบประเภทข้อมูลที่แข็งแกร่ง และความปลอดภัย

`Wrappers` ยังเป็นชุดรวมของ FDW ที่สร้างโดย [Supabase](https://www.supabase.com) ขณะนี้เรารองรับ FDW ต่อไปนี้ และกำลังพัฒนาเพิ่มเติม:

| FDW                                                                                     | คำอธิบาย                                                                                 | อ่าน | แก้ไข |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | ---- | ------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | FDW ตัวอย่างสำหรับสาธิตวิธีพัฒนา FDW เบื้องต้น                                           |      |        |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | FDW สำหรับ Google [BigQuery](https://cloud.google.com/bigquery)                          | ✅   | ✅     |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | FDW สำหรับ [ClickHouse](https://clickhouse.com/)                                         | ✅   | ✅     |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | FDW สำหรับ API ของ [Stripe](https://stripe.com/)                                         | ✅   | ✅     |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | FDW สำหรับ Google [Firebase](https://firebase.google.com/)                               | ✅   | ❌     |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | FDW สำหรับ API ของ [Airtable](https://airtable.com/)                                     | ✅   | ❌     |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | FDW สำหรับ [AWS S3](https://aws.amazon.com/s3/)                                          | ✅   | ❌     |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | FDW สำหรับ [Logflare](https://logflare.app/)                                             | ✅   | ❌     |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | FDW สำหรับ [Auth0](https://auth0.com/)                                                   | ✅   | ❌     |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | FDW สำหรับ [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/)           | ✅   | ❌     |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | FDW สำหรับ [Redis](https://redis.io/)                                                    | ✅   | ❌     |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | FDW สำหรับ [AWS Cognito](https://aws.amazon.com/cognito/)                                | ✅   | ❌     |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | Wasm FDW สำหรับ [Notion](https://www.notion.so/)                                         | ✅   | ❌     |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | Wasm FDW สำหรับ [Snowflake](https://www.snowflake.com/)                                  | ✅   | ✅     |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | Wasm FDW สำหรับ [Paddle](https://www.paddle.com/)                                        | ✅   | ✅     |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | Wasm FDW สำหรับ [Calendly](https://www.calendly.com/)                                    | ✅   | ❌     |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | Wasm FDW สำหรับ [Cal.com](https://www.cal.com/)                                          | ✅   | ❌     |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | Wasm FDW สำหรับ [Clerk](https://www.clerk.com/)                                          | ✅   | ❌     |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | Wasm FDW สำหรับ [Cloudflare D1](https://developers.cloudflare.com/d1/)                   | ✅   | ✅     |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | Wasm FDW สำหรับ [Orb](https://www.withorb.com/)                                          | ✅   | ❌     |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | Wasm FDW สำหรับ [HubSpot](https://www.hubspot.com/)                                      | ✅   | ❌     |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | Wasm FDW สำหรับ [Slack](https://www.slack.com/)                                          | ✅   | ❌     |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| FDW สำหรับ [Apache Iceberg](https://iceberg.apache.org/)                                 | ✅   | ❌     |

### คำเตือน

การกู้คืนข้อมูลฐานข้อมูลแบบ logical backup ที่มี materialized view โดยใช้ foreign table อาจล้มเหลว ด้วยเหตุผลนี้ ไม่ควรใช้ foreign table ใน materialized view หรือควรใช้เฉพาะในฐานข้อมูลที่เปิดใช้งานการสำรองข้อมูลแบบ physical เท่านั้น

## คุณสมบัติ

- อินเทอร์เฟซน้อยและง่ายต่อการนำไปใช้
- รองรับชนิดข้อมูลที่หลากหลาย
- รองรับทั้ง backend แบบ synchronous และ asynchronous เช่น RDBMS, RESTful API, ไฟล์ flat file ฯลฯ
- สร้างบน [pgrx](https://github.com/tcdi/pgrx) มอบอินเทอร์เฟซระดับสูงโดยไม่ซ่อน API ระดับล่างของภาษา C
- รองรับ `WHERE`, `ORDER BY`, `LIMIT` pushdown

## เอกสารประกอบ

- [คู่มือการใช้งาน](https://fdw.dev/)
- [คู่มือสำหรับนักพัฒนา (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## การติดตั้ง

`Wrappers` เป็นส่วนขยายของ pgrx คุณสามารถทำตาม [ขั้นตอนการติดตั้ง pgrx](https://github.com/tcdi/pgrx#system-requirements) เพื่อทำการติดตั้ง Wrappers

โดยพื้นฐาน ให้รันคำสั่งด้านล่างเพื่อทำการติดตั้ง FDW หลังติดตั้ง `pgrx` ตัวอย่างเช่น

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## การพัฒนา FDW

เยี่ยมชม [Wrappers Docs](https://fdw.dev/) สำหรับรายละเอียดเพิ่มเติม

## สัญญาอนุญาต

[สัญญาอนุญาต Apache Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---