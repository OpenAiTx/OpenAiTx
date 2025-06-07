<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres untuk Pencarian dan Analitik</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Situs Web</a> &bull;
  <a href="https://docs.paradedb.com">Dokumentasi</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Komunitas</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Perubahan</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) adalah alternatif modern untuk Elasticsearch yang dibangun di atas Postgres. Dibuat untuk beban kerja real-time dan update yang intensif.

## Roadmap

- [x] Pencarian
  - [x] Pencarian full-text dengan BM25 menggunakan [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Pencarian vektor padat dan jarang menggunakan [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Pencarian terdistribusi
- [ ] Analitik
  - [x] Pencarian berfasis pada data Postgres menggunakan [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Metode akses tabel Postgres berorientasi kolom

Untuk roadmap secara detail, lihat [Roadmap ParadeDB untuk 2025](https://github.com/orgs/paradedb/discussions/2041).

## Mulai

Untuk memulai, silakan kunjungi [dokumentasi kami](https://docs.paradedb.com).

## Deploy ParadeDB

ParadeDB dan ekstensi-ekstensinya dapat di-deploy dengan dua cara:

- Image Docker berbasis [Postgres](https://hub.docker.com/_/postgres) ([lihat petunjuk deployment](https://docs.paradedb.com/deploy/aws))
- Helm chart Kubernetes berbasis [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([lihat petunjuk deployment](https://docs.paradedb.com/deploy/helm))

Untuk informasi lebih lanjut, termasuk fitur enterprise dan dukungan, silakan [hubungi kami melalui email](mailto:sales@paradedb.com).

### Ekstensi

Anda dapat menemukan binary siap pakai untuk ekstensi ParadeDB Postgres pada Debian 11, 12, Ubuntu 22.04 dan 24.04, Red Hat Enterprise Linux 8 dan 9, serta macOS 14 (Sonoma) dan 15 (Sequoia) untuk Postgres 14+ di [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB mendukung semua versi yang didukung oleh PostgreSQL Global Development Group, yang mencakup PostgreSQL 14+. Anda juga dapat meng-compile ekstensi untuk versi Postgres lain dengan mengikuti petunjuk pada README ekstensi terkait.

### Image Docker

Untuk menjalankan instance ParadeDB dengan cepat, cukup tarik dan jalankan image Docker terbaru:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Perintah ini akan menjalankan instance ParadeDB dengan user default `postgres` dan password `password`. Anda kemudian dapat terhubung ke database menggunakan `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Untuk instalasi ParadeDB secara lokal atau di on-premise, kami merekomendasikan menggunakan file `docker-compose.yml` kami. Alternatifnya, Anda bisa menambahkan variabel lingkungan yang sesuai pada perintah `docker run`, ganti <> dengan nilai yang diinginkan:

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

Perintah ini akan menjalankan instance ParadeDB dengan user non-root `<user>` dan password `<password>`. Flag `-v` memungkinkan data ParadeDB Anda tetap tersimpan di volume Docker bernama `paradedb_data` meskipun terjadi restart.

Anda dapat terhubung ke database menggunakan `psql`:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB juga tersedia untuk Kubernetes melalui Helm chart kami. Anda dapat menemukan Helm chart kami di [Repository ParadeDB Helm Chart di GitHub](https://github.com/paradedb/charts) atau mengunduhnya langsung dari [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Saat ini, ParadeDB belum tersedia sebagai layanan cloud terkelola. Jika Anda tertarik dengan layanan ParadeDB Cloud, silakan daftar di [daftar tunggu](https://form.typeform.com/to/jHkLmIzx) kami.

## Dukungan

Jika Anda membutuhkan fitur tertentu atau menemukan bug, silakan buka
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Untuk mendapatkan dukungan komunitas, Anda dapat:

- Mengajukan pertanyaan di [Komunitas Slack ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Meminta bantuan di [GitHub Discussions kami](https://github.com/paradedb/paradedb/discussions)

Jika Anda membutuhkan dukungan komersial, silakan [hubungi tim ParadeDB](mailto:sales@paradedb.com).

## Kontribusi

Kami menyambut kontribusi dari komunitas, besar maupun kecil, dan siap membimbing Anda. Untuk mulai berkontribusi, cek [isu pemula](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
atau kirim pesan di [Komunitas Slack ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Setelah Anda berkontribusi, hubungi kami di Slack dan kami akan mengirimkan merchandise ParadeDB!

Untuk informasi lebih lanjut tentang kontribusi, silakan lihat
[Panduan Kontribusi](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Proyek ini dirilis dengan [Kode Etik Kontributor](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Dengan berpartisipasi dalam proyek ini, Anda setuju untuk mengikuti ketentuannya.

Terima kasih telah membantu kami membuat ParadeDB lebih baik untuk semua :heart:.

## Lisensi

ParadeDB dilisensikan di bawah [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) dan juga tersedia sebagai perangkat lunak komersial. Untuk lisensi komersial, silakan hubungi kami di [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---