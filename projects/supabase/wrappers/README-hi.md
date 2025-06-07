# Wrappers

`Wrappers` पोस्टग्रेस फॉरेन डेटा रैपर ([FDW](https://wiki.postgresql.org/wiki/Foreign_data_wrappers)) के लिए एक डेवलपमेंट फ्रेमवर्क है, जो Rust में लिखा गया है। इसका उद्देश्य पोस्टग्रेस FDW डेवलपमेंट को आसान बनाना है, साथ ही Rust भाषा की आधुनिक क्षमताओं जैसे उच्च प्रदर्शन, मजबूत टाइप और सुरक्षा को बनाए रखना है।

`Wrappers` [Supabase](https://www.supabase.com) द्वारा निर्मित FDW का एक संग्रह भी है। हम वर्तमान में निम्नलिखित FDW का समर्थन करते हैं, और अधिक विकासाधीन हैं:

| FDW                                                                                         | विवरण                                                                                   | पढ़ें | संशोधित करें |
| ------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------- | ----- | ------------ |
| [HelloWorld](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/helloworld_fdw) | एक डेमो FDW जो दिखाता है कि एक बेसिक FDW कैसे विकसित करें।                             |       |              |
| [BigQuery](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/bigquery_fdw)     | Google [BigQuery](https://cloud.google.com/bigquery) के लिए FDW                        | ✅    | ✅           |
| [Clickhouse](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/clickhouse_fdw) | [ClickHouse](https://clickhouse.com/) के लिए FDW                                       | ✅    | ✅           |
| [Stripe](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/stripe_fdw)         | [Stripe](https://stripe.com/) API के लिए FDW                                           | ✅    | ✅           |
| [Firebase](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/firebase_fdw)     | Google [Firebase](https://firebase.google.com/) के लिए FDW                             | ✅    | ❌           |
| [Airtable](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/airtable_fdw)     | [Airtable](https://airtable.com/) API के लिए FDW                                       | ✅    | ❌           |
| [S3](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/s3_fdw)                 | [AWS S3](https://aws.amazon.com/s3/) के लिए FDW                                        | ✅    | ❌           |
| [Logflare](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/logflare_fdw)     | [Logflare](https://logflare.app/) के लिए FDW                                           | ✅    | ❌           |
| [Auth0](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/auth0_fdw)           | [Auth0](https://auth0.com/) के लिए FDW                                                 | ✅    | ❌           |
| [SQL Server](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/mssql_fdw)      | [Microsoft SQL Server](https://www.microsoft.com/en-au/sql-server/) के लिए FDW         | ✅    | ❌           |
| [Redis](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/redis_fdw)           | [Redis](https://redis.io/) के लिए FDW                                                  | ✅    | ❌           |
| [AWS Cognito](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/cognito_fdw)   | [AWS Cognito](https://aws.amazon.com/cognito/) के लिए FDW                              | ✅    | ❌           |
| [Notion](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/notion_fdw)        | [Notion](https://www.notion.so/) के लिए Wasm FDW                                       | ✅    | ❌           |
| [Snowflake](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/snowflake_fdw)  | [Snowflake](https://www.snowflake.com/) के लिए Wasm FDW                                | ✅    | ✅           |
| [Paddle](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/paddle_fdw)        | [Paddle](https://www.paddle.com/) के लिए Wasm FDW                                      | ✅    | ✅           |
| [Calendly](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/calendly_fdw)    | [Calendly](https://www.calendly.com/) के लिए Wasm FDW                                  | ✅    | ❌           |
| [Cal.com](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cal_fdw)          | [Cal.com](https://www.cal.com/) के लिए Wasm FDW                                        | ✅    | ❌           |
| [Clerk](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/clerk_fdw)          | [Clerk](https://www.clerk.com/) के लिए Wasm FDW                                        | ✅    | ❌           |
| [Cloudflare D1](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/cfd1_fdw)   | [Cloudflare D1](https://developers.cloudflare.com/d1/) के लिए Wasm FDW                 | ✅    | ✅           |
| [Orb](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/orb_fdw)              | [Orb](https://www.withorb.com/) के लिए Wasm FDW                                        | ✅    | ❌           |
| [HubSpot](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/hubspot_fdw)      | [HubSpot](https://www.hubspot.com/) के लिए Wasm FDW                                    | ✅    | ❌           |
| [Slack](https://raw.githubusercontent.com/supabase/wrappers/main/wasm-wrappers/fdw/slack_fdw)          | [Slack](https://www.slack.com/) के लिए Wasm FDW                                        | ✅    | ❌           |
| [Apache Iceberg](https://raw.githubusercontent.com/supabase/wrappers/main/wrappers/src/fdw/iceberg_fdw)| [Apache Iceberg](https://iceberg.apache.org/) के लिए FDW                               | ✅    | ❌           |

### चेतावनी

विदेशी तालिका का उपयोग करने वाले मैटेरियलाइज़्ड व्यू के साथ डेटाबेस का लॉजिकल बैकअप पुनर्स्थापित करना विफल हो सकता है। इस कारण से, या तो मैटेरियलाइज़्ड व्यू में विदेशी तालिकाओं का उपयोग न करें या उन्हें केवल उन डेटाबेस में उपयोग करें जहाँ भौतिक बैकअप सक्षम हैं।

## विशेषताएँ

- न्यूनतम इंटरफ़ेस और आसान कार्यान्वयन।
- समृद्ध डेटा प्रकारों के लिए समर्थन।
- सिंक और असिंक दोनों बैकएंड का समर्थन, जैसे RDBMS, RESTful API, फ्लैट फाइल आदि।
- [pgrx](https://github.com/tcdi/pgrx) के ऊपर निर्मित, उच्च स्तरीय इंटरफेस प्रदान करता है, बिना निम्न-स्तरीय C API को छुपाए।
- `WHERE`, `ORDER BY`, `LIMIT` पुशडाउन का समर्थन।

## प्रलेखन

- [उपयोग दस्तावेज़](https://fdw.dev/)
- [डेवलपर दस्तावेज़ (docs.rs)](https://docs.rs/supabase-wrappers/latest/supabase_wrappers/)

## स्थापना

`Wrappers` एक pgrx एक्सटेंशन है, आप [pgrx स्थापना चरण](https://github.com/tcdi/pgrx#system-requirements) का पालन करके Wrappers स्थापित कर सकते हैं।

मूलतः, नीचे दिया गया कमांड चलाएँ FDW स्थापित करने के लिए, जब `pgrx` स्थापित हो जाए। उदाहरण के लिए,

```bash
cargo pgrx install --pg-config [path_to_pg_config] --features stripe_fdw
```

## FDW विकसित करना

अधिक जानकारी के लिए [Wrappers Docs](https://fdw.dev/) देखें।

## लाइसेंस

[Apache License Version 2.0](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)

[![crates.io badge](https://img.shields.io/crates/v/supabase-wrappers.svg)](https://crates.io/crates/supabase-wrappers)
[![docs.rs badge](https://docs.rs/supabase-wrappers/badge.svg)](https://docs.rs/supabase-wrappers)
[![Test Status](https://img.shields.io/github/actions/workflow/status/supabase/wrappers/test_wrappers.yml?branch=main&label=test)](https://github.com/supabase/wrappers/actions/workflows/test_wrappers.yml)
[![MIT/Apache-2 licensed](https://img.shields.io/crates/l/supabase-wrappers.svg)](https://raw.githubusercontent.com/supabase/wrappers/main/LICENSE)
[![Contributors](https://img.shields.io/github/contributors/supabase/wrappers)](https://github.com/supabase/wrappers/graphs/contributors)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---