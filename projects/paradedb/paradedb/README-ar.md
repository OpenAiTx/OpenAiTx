<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>بوستجرس للبحث والتحليلات</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">الموقع الإلكتروني</a> &bull;
  <a href="https://docs.paradedb.com">التوثيق</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">المجتمع</a> &bull;
  <a href="https://paradedb.com/blog/">المدونة</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">سجل التغييرات</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) هو بديل حديث لـ Elasticsearch مبني على بوستجرس. مصمم للأحمال الثقيلة التي تتطلب تحديثات في الوقت الحقيقي.

## خارطة الطريق

- [x] البحث
  - [x] بحث نصي كامل مع BM25 باستخدام [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] بحث المتجهات الكثيفة والمتفرقة باستخدام [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] البحث الموزع
- [ ] التحليلات
  - [x] بحث مع تصنيف النتائج على بيانات بوستجرس باستخدام [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] طريقة وصول للجداول العمودية في بوستجرس

لرؤية خارطة الطريق الكاملة، راجع [خارطة طريق ParadeDB لعام 2025](https://github.com/orgs/paradedb/discussions/2041).

## ابدأ الآن

لبدء الاستخدام، يرجى زيارة [التوثيق](https://docs.paradedb.com).

## نشر ParadeDB

يمكن نشر ParadeDB وامتداداته بإحدى الطريقتين:

- صورة Docker مبنية على [Postgres](https://hub.docker.com/_/postgres) ([راجع تعليمات النشر](https://docs.paradedb.com/deploy/aws))
- مخطط Helm لـ Kubernetes مبني على [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([راجع تعليمات النشر](https://docs.paradedb.com/deploy/helm))

لمزيد من المعلومات، بما في ذلك الميزات المؤسسية والدعم، يرجى [الاتصال بنا عبر البريد الإلكتروني](mailto:sales@paradedb.com).

### الامتدادات

يمكنك العثور على ملفات ثنائية جاهزة لامتدادات ParadeDB Postgres لأنظمة Debian 11 و12 وUbuntu 22.04 و24.04 وRed Hat Enterprise Linux 8 و9 وmacOS 14 (Sonoma) و15 (Sequoia) لـ Postgres 14+ في [إصدارات GitHub](https://github.com/paradedb/paradedb/releases/latest).

يدعم ParadeDB جميع الإصدارات المدعومة من مجموعة تطوير PostgreSQL العالمية، بما في ذلك PostgreSQL 14+، ويمكنك تجميع الامتدادات لإصدارات أخرى من بوستجرس باتباع التعليمات في ملف README الخاص بكل امتداد.

### صورة Docker

لتشغيل نسخة ParadeDB بسرعة، قم بسحب وتشغيل أحدث صورة Docker:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

سيؤدي هذا إلى تشغيل نسخة ParadeDB مع المستخدم الافتراضي `postgres` وكلمة المرور `password`. يمكنك بعد ذلك الاتصال بقاعدة البيانات باستخدام `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

لتثبيت ParadeDB محليًا أو في بيئة داخلية، نوصي باستخدام ملف `docker-compose.yml` الخاص بنا. بدلاً من ذلك، يمكنك تمرير متغيرات البيئة المناسبة إلى أمر `docker run`، مع استبدال <> بالقيم المرغوبة:

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

سيؤدي هذا إلى تشغيل نسخة ParadeDB مع مستخدم غير جذر `<user>` وكلمة مرور `<password>`. يُمكنك من خلال الخيار `-v` الحفاظ على بيانات ParadeDB عبر إعادة التشغيل في وحدة تخزين Docker باسم `paradedb_data`.

يمكنك بعد ذلك الاتصال بقاعدة البيانات باستخدام `psql`:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### مخطط Helm

يتوفر ParadeDB أيضًا لـ Kubernetes عبر مخطط Helm. يمكنك العثور على مخطط Helm في [مستودع ParadeDB Helm Chart على GitHub](https://github.com/paradedb/charts) أو تحميله مباشرة من [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB السحابي

حاليًا، لا يتوفر ParadeDB كخدمة سحابية مُدارة. إذا كنت مهتمًا بخدمة ParadeDB Cloud، يرجى إعلامنا بالانضمام إلى [قائمة الانتظار](https://form.typeform.com/to/jHkLmIzx).

## الدعم

إذا كنت تفتقد ميزة أو وجدت خطأ، يرجى فتح
[قضية على GitHub](https://github.com/paradedb/paradedb/issues/new/choose).

للحصول على دعم من المجتمع، يمكنك:

- طرح سؤال في [مجتمع ParadeDB على Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- طلب المساعدة عبر [مناقشات GitHub](https://github.com/paradedb/paradedb/discussions)

إذا كنت بحاجة إلى دعم تجاري، يرجى [الاتصال بفريق ParadeDB](mailto:sales@paradedb.com).

## المساهمة

نرحب بمساهمات المجتمع، سواء كانت صغيرة أو كبيرة، ونحن هنا لمساعدتك في كل خطوة. للبدء في المساهمة، تحقق من [قضايا المبتدئين](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
أو تواصل معنا عبر [مجتمع ParadeDB على Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). بعد مساهمتك، راسلنا على Slack وسنرسل لك هدية ParadeDB!

لمزيد من المعلومات حول كيفية المساهمة، يرجى مراجعة
[دليل المساهمة](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

تم إصدار هذا المشروع مع [مدونة سلوك المساهمين](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
بمشاركتك في هذا المشروع، فإنك توافق على الالتزام بشروطها.

شكرًا لمساعدتك في جعل ParadeDB أفضل للجميع :heart:.

## الرخصة

ParadeDB مرخص بموجب [رخصة جنو أفيرو العمومية العامة الإصدار 3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) وأيضًا كبرنامج تجاري. للحصول على ترخيص تجاري، يرجى التواصل معنا عبر [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---