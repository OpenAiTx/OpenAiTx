<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>پستگرس برای جستجو و تحلیل</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">وبسایت</a> &bull;
  <a href="https://docs.paradedb.com">مستندات</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">انجمن</a> &bull;
  <a href="https://paradedb.com/blog/">وبلاگ</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">تغییرات نسخه‌ها</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) جایگزینی مدرن برای Elasticsearch است که بر پایه پستگرس ساخته شده است. مناسب برای بارهای کاری بلادرنگ و به‌روزرسانی‌های سنگین.

## نقشه راه

- [x] جستجو
  - [x] جستجوی متن کامل با BM25 با [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] جستجوی برداری متراکم و پراکنده با [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] جستجوی توزیع‌شده
- [ ] تحلیل
  - [x] جستجوی فاست روی داده‌های پستگرس با [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] روش دسترسی جدول ستونی در پستگرس

برای نقشه راه کامل، به [نقشه راه ParadeDB برای 2025](https://github.com/orgs/paradedb/discussions/2041) مراجعه کنید.

## شروع به کار

برای شروع، لطفاً به [مستندات](https://docs.paradedb.com) ما مراجعه کنید.

## استقرار ParadeDB

ParadeDB و افزونه‌های آن را می‌توانید به دو روش مستقر کنید:

- ایمیج داکر مبتنی بر [پستگرس](https://hub.docker.com/_/postgres) ([راهنمای استقرار](https://docs.paradedb.com/deploy/aws))
- چارت Helm در Kubernetes مبتنی بر [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([راهنمای استقرار](https://docs.paradedb.com/deploy/helm))

برای اطلاعات بیشتر، از جمله ویژگی‌های سازمانی و پشتیبانی، لطفاً [از طریق ایمیل با ما تماس بگیرید](mailto:sales@paradedb.com).

### افزونه‌ها

شما می‌توانید فایل‌های باینری آماده برای افزونه‌های پستگرس ParadeDB را برای Debian 11، 12، Ubuntu 22.04 و 24.04، Red Hat Enterprise Linux 8 و 9، و macOS 14 (Sonoma) و 15 (Sequoia) برای پستگرس 14+ در [انتشارات GitHub](https://github.com/paradedb/paradedb/releases/latest) بیابید.

ParadeDB از تمام نسخه‌هایی که توسط گروه توسعه جهانی PostgreSQL پشتیبانی می‌شوند (PostgreSQL 14+)، پشتیبانی می‌کند و می‌توانید افزونه‌ها را برای نسخه‌های دیگر پستگرس طبق راهنمای README هر افزونه کامپایل کنید.

### ایمیج داکر

برای راه‌اندازی سریع یک نمونه ParadeDB، کافی است آخرین ایمیج داکر را دریافت و اجرا کنید:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

این دستور یک نمونه ParadeDB با کاربر پیش‌فرض `postgres` و رمز عبور `password` اجرا می‌کند. سپس می‌توانید با استفاده از `psql` به پایگاه داده متصل شوید:

```bash
docker exec -it paradedb psql -U postgres
```

برای نصب ParadeDB به صورت محلی یا در محل، توصیه می‌کنیم از فایل `docker-compose.yml` ما استفاده کنید. همچنین می‌توانید متغیرهای محیطی مناسب را به دستور `docker run` بدهید و مقادیر دلخواه خود را جایگزین <> کنید:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<user> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

این دستور یک نمونه ParadeDB با کاربر غیرریشه `<user>` و رمز عبور `<password>` راه‌اندازی می‌کند. گزینه `-v` باعث می‌شود داده‌های ParadeDB شما در یک حجم داکر به نام `paradedb_data` بین راه‌اندازی‌های مجدد حفظ شوند.

سپس می‌توانید با استفاده از `psql` به پایگاه داده متصل شوید:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### چارت Helm

ParadeDB همچنین از طریق چارت Helm برای Kubernetes در دسترس است. شما می‌توانید چارت Helm ما را در [مخزن GitHub چارت ParadeDB](https://github.com/paradedb/charts) پیدا کنید یا مستقیماً از [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) دانلود کنید.

### ParadeDB Cloud

در حال حاضر، ParadeDB به عنوان یک سرویس ابری مدیریت‌شده ارائه نمی‌شود. اگر به سرویس ابری ParadeDB علاقه‌مند هستید، لطفاً با پیوستن به [لیست انتظار](https://form.typeform.com/to/jHkLmIzx) به ما اطلاع دهید.

## پشتیبانی

اگر قابلیتی کم است یا باگ پیدا کرده‌اید، لطفاً یک
[Issue در GitHub](https://github.com/paradedb/paradedb/issues/new/choose) باز کنید.

برای دریافت پشتیبانی از انجمن، می‌توانید:

- پرسش خود را در [انجمن Slack ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) مطرح کنید
- درخواست کمک در [بحث‌های GitHub ما](https://github.com/paradedb/paradedb/discussions) ارسال کنید

در صورت نیاز به پشتیبانی تجاری، لطفاً [با تیم ParadeDB تماس بگیرید](mailto:sales@paradedb.com).

## مشارکت

ما از مشارکت‌های جامعه، چه کوچک و چه بزرگ، استقبال می‌کنیم و در این مسیر راهنمای شما خواهیم بود. برای شروع مشارکت، به [issueهای مناسب برای شروع](https://github.com/paradedb/paradedb/labels/good%20first%20issue) مراجعه کنید یا در [Slack انجمن ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) به ما پیام دهید. پس از مشارکت، به ما در Slack اطلاع دهید تا مقداری هدایای ParadeDB برای شما ارسال کنیم!

برای اطلاعات بیشتر درباره نحوه مشارکت، لطفاً به
[راهنمای مشارکت](/CONTRIBUTING.md) مراجعه کنید.

این پروژه با [قوانین رفتاری مشارکت‌کنندگان](/CODE_OF_CONDUCT.md) منتشر شده است.
با شرکت در این پروژه، شما با این قوانین موافقت می‌کنید.

سپاسگزاریم که به بهتر شدن ParadeDB برای همه کمک می‌کنید :heart:.

## مجوز

ParadeDB تحت [مجوز عمومی Affero GNU نسخه ۳.۰](LICENSE) و همچنین به عنوان نرم‌افزار تجاری ارائه می‌شود. برای دریافت مجوز تجاری، لطفاً با ما در [sales@paradedb.com](mailto:sales@paradedb.com) تماس بگیرید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---