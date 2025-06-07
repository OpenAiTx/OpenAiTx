<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) adalah alternatif Firebase sumber terbuka. Kami membangun fitur-fitur Firebase dengan menggunakan alat sumber terbuka kelas perusahaan.

- [x] Database Postgres yang dihosting. [Dokumentasi](https://supabase.com/docs/guides/database)
- [x] Otentikasi dan Otorisasi. [Dokumentasi](https://supabase.com/docs/guides/auth)
- [x] API yang dihasilkan secara otomatis.
  - [x] REST. [Dokumentasi](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Dokumentasi](https://supabase.com/docs/guides/graphql)
  - [x] Langganan Realtime. [Dokumentasi](https://supabase.com/docs/guides/realtime)
- [x] Fungsi.
  - [x] Fungsi Database. [Dokumentasi](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Functions [Dokumentasi](https://supabase.com/docs/guides/functions)
- [x] Penyimpanan Berkas. [Dokumentasi](https://supabase.com/docs/guides/storage)
- [x] Toolkit AI + Vektor/Embeddings. [Dokumentasi](https://supabase.com/docs/guides/ai)
- [x] Dashboard

![Supabase Dashboard](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Pantau "rilis" repositori ini untuk mendapatkan pemberitahuan pembaruan utama.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Pantau repositori ini"/></kbd>

## Dokumentasi

Untuk dokumentasi lengkap, kunjungi [supabase.com/docs](https://supabase.com/docs)

Untuk melihat cara Kontribusi, kunjungi [Memulai](./DEVELOPERS.md)

## Komunitas & Dukungan

- [Forum Komunitas](https://github.com/supabase/supabase/discussions). Terbaik untuk: bantuan membangun, diskusi tentang praktik terbaik database.
- [Isu GitHub](https://github.com/supabase/supabase/issues). Terbaik untuk: bug dan kesalahan yang Anda temui saat menggunakan Supabase.
- [Dukungan Email](https://supabase.com/docs/support#business-support). Terbaik untuk: masalah dengan database atau infrastruktur Anda.
- [Discord](https://discord.supabase.com). Terbaik untuk: membagikan aplikasi Anda dan berinteraksi dengan komunitas.

## Cara Kerja

Supabase adalah kombinasi dari alat sumber terbuka. Kami membangun fitur Firebase menggunakan produk sumber terbuka kelas perusahaan. Jika alat dan komunitasnya sudah ada, dengan lisensi terbuka seperti MIT, Apache 2, atau setara, kami akan menggunakan dan mendukung alat tersebut. Jika alatnya belum ada, kami membangunnya sendiri dan membuka sumbernya. Supabase bukanlah peta satu-ke-satu dari Firebase. Tujuan kami adalah memberikan pengalaman pengembangan seperti Firebase menggunakan alat sumber terbuka.

**Arsitektur**

Supabase adalah [platform yang dihosting](https://supabase.com/dashboard). Anda dapat mendaftar dan mulai menggunakan Supabase tanpa menginstal apa pun.
Anda juga dapat [self-host](https://supabase.com/docs/guides/hosting/overview) dan [mengembangkan secara lokal](https://supabase.com/docs/guides/local-development).

![Architecture](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) adalah sistem database objek-relasional dengan lebih dari 30 tahun pengembangan aktif yang telah memberinya reputasi kuat dalam hal keandalan, kekayaan fitur, dan kinerja.
- [Realtime](https://github.com/supabase/realtime) adalah server Elixir yang memungkinkan Anda mendengarkan insert, update, dan delete PostgreSQL menggunakan websockets. Realtime memantau fungsi replikasi bawaan Postgres untuk perubahan database, mengubah perubahan menjadi JSON, lalu menyiarkan JSON melalui websockets ke klien yang berwenang.
- [PostgREST](http://postgrest.org/) adalah web server yang mengubah database PostgreSQL Anda langsung menjadi API RESTful.
- [GoTrue](https://github.com/supabase/gotrue) adalah API otentikasi berbasis JWT yang menyederhanakan pendaftaran pengguna, login, dan manajemen sesi di aplikasi Anda.
- [Storage](https://github.com/supabase/storage-api) adalah API RESTful untuk mengelola file di S3, dengan Postgres yang mengelola izin.
- [pg_graphql](http://github.com/supabase/pg_graphql/) adalah ekstensi PostgreSQL yang menyediakan API GraphQL.
- [postgres-meta](https://github.com/supabase/postgres-meta) adalah API RESTful untuk mengelola Postgres Anda, memungkinkan Anda mengambil tabel, menambah peran, menjalankan query, dan lain-lain.
- [Kong](https://github.com/Kong/kong) adalah gateway API cloud-native.

#### Library Klien

Pendekatan kami untuk library klien adalah modular. Setiap sub-library merupakan implementasi mandiri untuk satu sistem eksternal. Ini adalah salah satu cara kami mendukung alat yang sudah ada.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Bahasa</th>
    <th>Klien</th>
    <th colspan="5">Klien-Fitur (terbundel dalam klien Supabase)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Fungsi</th>
  </tr>
  <!-- TEMPLATE FOR NEW ROW -->
  <!-- START ROW
  <tr>
    <td>lang</td>
    <td><a href="https://github.com/supabase-community/supabase-lang" target="_blank" rel="noopener noreferrer">supabase-lang</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-lang" target="_blank" rel="noopener noreferrer">postgrest-lang</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-lang" target="_blank" rel="noopener noreferrer">gotrue-lang</a></td>
    <td><a href="https://github.com/supabase-community/realtime-lang" target="_blank" rel="noopener noreferrer">realtime-lang</a></td>
    <td><a href="https://github.com/supabase-community/storage-lang" target="_blank" rel="noopener noreferrer">storage-lang</a></td>
  </tr>
  END ROW -->
  <!-- /notranslate -->
  <th colspan="7">⚡️ Resmi ⚡️</th>
  <!-- notranslate -->
  <tr>
    <td>JavaScript (TypeScript)</td>
    <td><a href="https://github.com/supabase/supabase-js" target="_blank" rel="noopener noreferrer">supabase-js</a></td>
    <td><a href="https://github.com/supabase/postgrest-js" target="_blank" rel="noopener noreferrer">postgrest-js</a></td>
    <td><a href="https://github.com/supabase/gotrue-js" target="_blank" rel="noopener noreferrer">gotrue-js</a></td>
    <td><a href="https://github.com/supabase/realtime-js" target="_blank" rel="noopener noreferrer">realtime-js</a></td>
    <td><a href="https://github.com/supabase/storage-js" target="_blank" rel="noopener noreferrer">storage-js</a></td>
    <td><a href="https://github.com/supabase/functions-js" target="_blank" rel="noopener noreferrer">functions-js</a></td>
  </tr>
    <tr>
    <td>Flutter</td>
    <td><a href="https://github.com/supabase/supabase-flutter" target="_blank" rel="noopener noreferrer">supabase-flutter</a></td>
    <td><a href="https://github.com/supabase/postgrest-dart" target="_blank" rel="noopener noreferrer">postgrest-dart</a></td>
    <td><a href="https://github.com/supabase/gotrue-dart" target="_blank" rel="noopener noreferrer">gotrue-dart</a></td>
    <td><a href="https://github.com/supabase/realtime-dart" target="_blank" rel="noopener noreferrer">realtime-dart</a></td>
    <td><a href="https://github.com/supabase/storage-dart" target="_blank" rel="noopener noreferrer">storage-dart</a></td>
    <td><a href="https://github.com/supabase/functions-dart" target="_blank" rel="noopener noreferrer">functions-dart</a></td>
  </tr>
  <tr>
    <td>Swift</td>
    <td><a href="https://github.com/supabase/supabase-swift" target="_blank" rel="noopener noreferrer">supabase-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/PostgREST" target="_blank" rel="noopener noreferrer">postgrest-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Auth" target="_blank" rel="noopener noreferrer">auth-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Realtime" target="_blank" rel="noopener noreferrer">realtime-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Storage" target="_blank" rel="noopener noreferrer">storage-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Functions" target="_blank" rel="noopener noreferrer">functions-swift</a></td>
  </tr>
  <tr>
    <td>Python</td>
    <td><a href="https://github.com/supabase/supabase-py" target="_blank" rel="noopener noreferrer">supabase-py</a></td>
    <td><a href="https://github.com/supabase/postgrest-py" target="_blank" rel="noopener noreferrer">postgrest-py</a></td>
    <td><a href="https://github.com/supabase/gotrue-py" target="_blank" rel="noopener noreferrer">gotrue-py</a></td>
    <td><a href="https://github.com/supabase/realtime-py" target="_blank" rel="noopener noreferrer">realtime-py</a></td>
    <td><a href="https://github.com/supabase/storage-py" target="_blank" rel="noopener noreferrer">storage-py</a></td>
    <td><a href="https://github.com/supabase/functions-py" target="_blank" rel="noopener noreferrer">functions-py</a></td>
  </tr>
  <!-- /notranslate -->
  <th colspan="7">💚 Komunitas 💚</th>
  <!-- notranslate -->
  <tr>
    <td>C#</td>
    <td><a href="https://github.com/supabase-community/supabase-csharp" target="_blank" rel="noopener noreferrer">supabase-csharp</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-csharp" target="_blank" rel="noopener noreferrer">postgrest-csharp</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-csharp" target="_blank" rel="noopener noreferrer">gotrue-csharp</a></td>
    <td><a href="https://github.com/supabase-community/realtime-csharp" target="_blank" rel="noopener noreferrer">realtime-csharp</a></td>
    <td><a href="https://github.com/supabase-community/storage-csharp" target="_blank" rel="noopener noreferrer">storage-csharp</a></td>
    <td><a href="https://github.com/supabase-community/functions-csharp" target="_blank" rel="noopener noreferrer">functions-csharp</a></td>
  </tr>
  <tr>
    <td>Go</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-go" target="_blank" rel="noopener noreferrer">postgrest-go</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-go" target="_blank" rel="noopener noreferrer">gotrue-go</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-go" target="_blank" rel="noopener noreferrer">storage-go</a></td>
    <td><a href="https://github.com/supabase-community/functions-go" target="_blank" rel="noopener noreferrer">functions-go</a></td>
  </tr>
  <tr>
    <td>Java</td>
    <td>-</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/gotrue-java" target="_blank" rel="noopener noreferrer">gotrue-java</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-java" target="_blank" rel="noopener noreferrer">storage-java</a></td>
    <td>-</td>
  </tr>
  <tr>
    <td>Kotlin</td>
    <td><a href="https://github.com/supabase-community/supabase-kt" target="_blank" rel="noopener noreferrer">supabase-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Postgrest" target="_blank" rel="noopener noreferrer">postgrest-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Auth" target="_blank" rel="noopener noreferrer">auth-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Realtime" target="_blank" rel="noopener noreferrer">realtime-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Storage" target="_blank" rel="noopener noreferrer">storage-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Functions" target="_blank" rel="noopener noreferrer">functions-kt</a></td>
  </tr>
  <tr>
    <td>Ruby</td>
    <td><a href="https://github.com/supabase-community/supabase-rb" target="_blank" rel="noopener noreferrer">supabase-rb</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-rb" target="_blank" rel="noopener noreferrer">postgrest-rb</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Rust</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-rs" target="_blank" rel="noopener noreferrer">postgrest-rs</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Godot Engine (GDScript)</td>
    <td><a href="https://github.com/supabase-community/godot-engine.supabase" target="_blank" rel="noopener noreferrer">supabase-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-gdscript" target="_blank" rel="noopener noreferrer">postgrest-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-gdscript" target="_blank" rel="noopener noreferrer">gotrue-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/realtime-gdscript" target="_blank" rel="noopener noreferrer">realtime-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/storage-gdscript" target="_blank" rel="noopener noreferrer">storage-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/functions-gdscript" target="_blank" rel="noopener noreferrer">functions-gdscript</a></td>
  </tr>
  <!-- /notranslate -->
</table>

<!--- Hapus daftar ini jika Anda menerjemahkan ke bahasa lain, sulit untuk diperbarui di banyak berkas-->
<!--- Hanya pertahankan tautan ke daftar file terjemahan-->

## Badge

![Dibuat dengan Supabase](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Dibuat dengan Supabase](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Dibuat dengan Supabase"
  />
</a>
```

![Dibuat dengan Supabase (dark)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Dibuat dengan Supabase](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Dibuat dengan Supabase"
  />
</a>
```

## Terjemahan

- [Daftar terjemahan](/i18n/languages.md) <!--- Hanya pertahankan ini -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---