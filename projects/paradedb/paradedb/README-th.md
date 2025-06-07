<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres สำหรับการค้นหาและวิเคราะห์ข้อมูล</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">เว็บไซต์</a> &bull;
  <a href="https://docs.paradedb.com">เอกสาร</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">ชุมชน</a> &bull;
  <a href="https://paradedb.com/blog/">บล็อก</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">บันทึกการเปลี่ยนแปลง</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) คือทางเลือกใหม่สำหรับ Elasticsearch ที่สร้างขึ้นบน Postgres ออกแบบมาสำหรับงานแบบเรียลไทม์และการอัปเดตข้อมูลจำนวนมาก

## แผนงาน

- [x] การค้นหา
  - [x] การค้นหาข้อความแบบเต็มด้วย BM25 ด้วย [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] การค้นหาเวกเตอร์หนาแน่นและเวกเตอร์เบาบางด้วย [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] การค้นหาแบบกระจาย
- [ ] การวิเคราะห์ข้อมูล
  - [x] การค้นหาแบบ Faceted บนข้อมูล Postgres ด้วย [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] วิธีการเข้าถึงตาราง Postgres แบบ column-oriented

สำหรับแผนงานโดยละเอียด ดูได้ที่ [ParadeDB Roadmap for 2025](https://github.com/orgs/paradedb/discussions/2041)

## เริ่มต้นใช้งาน

ในการเริ่มต้น โปรดเยี่ยมชม [เอกสารของเรา](https://docs.paradedb.com)

## การปรับใช้งาน ParadeDB

ParadeDB และส่วนขยายสามารถปรับใช้ได้ 2 วิธี:

- Docker image ที่ใช้พื้นฐานจาก [Postgres](https://hub.docker.com/_/postgres) ([ดูคำแนะนำการปรับใช้](https://docs.paradedb.com/deploy/aws))
- Kubernetes Helm chart ที่ใช้พื้นฐานจาก [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([ดูคำแนะนำการปรับใช้](https://docs.paradedb.com/deploy/helm))

สำหรับข้อมูลเพิ่มเติม รวมถึงฟีเจอร์ระดับองค์กรและการสนับสนุน โปรด [ติดต่อเราทางอีเมล](mailto:sales@paradedb.com)

### ส่วนขยาย

คุณสามารถค้นหาไฟล์ไบนารีที่สร้างไว้ล่วงหน้าสำหรับ ParadeDB Postgres extensions บน Debian 11, 12, Ubuntu 22.04 และ 24.04, Red Hat Enterprise Linux 8 และ 9, และ macOS 14 (Sonoma) และ 15 (Sequoia) สำหรับ Postgres 14+ ใน [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest)

ParadeDB รองรับทุกเวอร์ชันที่ PostgreSQL Global Development Group สนับสนุน ซึ่งรวมถึง PostgreSQL 14+ และคุณสามารถคอมไพล์ส่วนขยายสำหรับ Postgres เวอร์ชันอื่นโดยทำตามคำแนะนำใน README ของแต่ละส่วนขยาย

### Docker Image

เพื่อเริ่มต้นใช้งาน ParadeDB อย่างรวดเร็ว เพียงดึงและรัน Docker image เวอร์ชันล่าสุด:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

คำสั่งนี้จะเริ่มต้น ParadeDB ด้วยผู้ใช้เริ่มต้น `postgres` และรหัสผ่าน `password` คุณสามารถเชื่อมต่อกับฐานข้อมูลโดยใช้ `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

หากต้องการติดตั้ง ParadeDB ในเครื่องหรือในองค์กร แนะนำให้ใช้ไฟล์ `docker-compose.yml` ของเรา หรือคุณสามารถกำหนด environment variables ในคำสั่ง `docker run` โดยแทนที่ <> ด้วยค่าที่ต้องการ:

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

คำสั่งนี้จะเริ่มต้น ParadeDB ด้วยผู้ใช้ที่ไม่ใช่ root `<user>` และรหัสผ่าน `<password>` ตัวเลือก `-v` ทำให้ข้อมูล ParadeDB ของคุณถูกเก็บถาวรไว้ใน Docker volume ชื่อ `paradedb_data`

จากนั้นคุณสามารถเชื่อมต่อกับฐานข้อมูลโดยใช้ `psql`:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB ยังพร้อมให้ใช้งานบน Kubernetes ผ่าน Helm chart ของเรา คุณสามารถค้นหา Helm chart ได้ใน [GitHub repository ParadeDB Helm Chart](https://github.com/paradedb/charts) หรือดาวน์โหลดได้โดยตรงจาก [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb)

### ParadeDB Cloud

ขณะนี้ ParadeDB ยังไม่มีบริการแบบ managed cloud หากคุณสนใจ ParadeDB Cloud กรุณาแจ้งให้เราทราบโดยเข้าร่วม [waitlist](https://form.typeform.com/to/jHkLmIzx) ของเรา

## การสนับสนุน

หากคุณต้องการฟีเจอร์เพิ่มเติมหรือพบข้อผิดพลาด โปรดเปิด
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose)

หากต้องการขอความช่วยเหลือจากชุมชน คุณสามารถ:

- โพสต์คำถามใน [ParadeDB Slack Community](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- ขอความช่วยเหลือใน [GitHub Discussions](https://github.com/paradedb/paradedb/discussions)

หากคุณต้องการการสนับสนุนเชิงพาณิชย์ โปรด [ติดต่อทีมงาน ParadeDB](mailto:sales@paradedb.com)

## การมีส่วนร่วม

เรายินดีต้อนรับการมีส่วนร่วมจากชุมชน ไม่ว่าจะเล็กหรือใหญ่ และพร้อมให้คำแนะนำคุณตลอดทาง หากต้องการเริ่มต้นมีส่วนร่วม โปรดดู [first timer issues](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
หรือติดต่อเราทาง [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) เมื่อคุณได้มีส่วนร่วมแล้ว แจ้งเราใน Slack แล้วเราจะส่งของที่ระลึก ParadeDB ให้คุณ!

ดูข้อมูลเพิ่มเติมเกี่ยวกับวิธีการมีส่วนร่วมได้ที่
[คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md)

โปรเจกต์นี้ออกภายใต้ [Contributor Code of Conduct](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md)
โดยการมีส่วนร่วมในโปรเจกต์นี้ ถือว่าคุณยอมรับข้อตกลงนี้

ขอบคุณที่ช่วยกันทำให้ ParadeDB ดียิ่งขึ้นสำหรับทุกคน :heart:

## ใบอนุญาต

ParadeDB ใช้ใบอนุญาต [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) และมีเวอร์ชันเชิงพาณิชย์ด้วย หากต้องการใบอนุญาตเชิงพาณิชย์ กรุณาติดต่อเราที่ [sales@paradedb.com](mailto:sales@paradedb.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---