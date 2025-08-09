*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**Bantu [terjemahkan](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md) panduan ini!**

# The System Design Primer

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## Motivasi

> Pelajari cara merancang sistem skala besar.
>
> Persiapkan diri untuk wawancara desain sistem.

### Pelajari cara merancang sistem skala besar

Mempelajari cara merancang sistem yang dapat diskalakan akan membantu Anda menjadi engineer yang lebih baik.

Desain sistem adalah topik yang luas.  Ada **sangat banyak sumber daya yang tersebar di seluruh web** mengenai prinsip-prinsip desain sistem.

Repo ini adalah **kumpulan sumber daya yang terorganisir** untuk membantu Anda belajar membangun sistem berskala besar.

### Belajar dari komunitas open source

Ini adalah proyek open source yang terus diperbarui.

[Kontribusi](#contributing) sangat diterima!

### Persiapan untuk wawancara desain sistem

Selain wawancara coding, desain sistem adalah **komponen yang wajib** dalam **proses wawancara teknis** di banyak perusahaan teknologi.

**Latih pertanyaan umum wawancara desain sistem** dan **bandingkan** hasil Anda dengan **solusi contoh**: diskusi, kode, dan diagram.

Topik tambahan untuk persiapan wawancara:

* [Panduan belajar](#study-guide)
* [Cara mendekati pertanyaan wawancara desain sistem](#how-to-approach-a-system-design-interview-question)
* [Pertanyaan wawancara desain sistem, **dengan solusi**](#system-design-interview-questions-with-solutions)
* [Pertanyaan wawancara desain berorientasi objek, **dengan solusi**](#object-oriented-design-interview-questions-with-solutions)
* [Pertanyaan wawancara desain sistem tambahan](#additional-system-design-interview-questions)

## Kartu flash Anki

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

Deck [kartu flash Anki](https://apps.ankiweb.net/) yang disediakan menggunakan pengulangan berspasi untuk membantu Anda mengingat konsep desain sistem utama.

* [Deck desain sistem](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [Deck latihan desain sistem](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [Deck latihan desain berorientasi objek](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

Sangat cocok digunakan saat bepergian.

### Sumber Coding: Tantangan Coding Interaktif

Mencari sumber daya untuk membantu Anda mempersiapkan [**Wawancara Coding**](https://github.com/donnemartin/interactive-coding-challenges)?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

Lihat repo saudara [**Tantangan Coding Interaktif**](https://github.com/donnemartin/interactive-coding-challenges), yang juga memiliki deck Anki tambahan:

* [Deck coding](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## Kontribusi

> Belajar dari komunitas.

Jangan ragu untuk mengirimkan pull request untuk membantu:

* Memperbaiki kesalahan
* Meningkatkan bagian
* Tambahkan bagian baru
* [Terjemahkan](https://github.com/donnemartin/system-design-primer/issues/28)

Konten yang membutuhkan pemolesan ditempatkan [dalam pengembangan](#under-development).

Tinjau [Pedoman Kontribusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md).

## Indeks topik desain sistem

> Ringkasan berbagai topik desain sistem, termasuk kelebihan dan kekurangan.  **Semua adalah pertukaran**.
>
> Setiap bagian berisi tautan ke sumber daya yang lebih mendalam.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [Topik desain sistem: mulai di sini](#system-design-topics-start-here)
    * [Langkah 1: Tinjau video kuliah skalabilitas](#step-1-review-the-scalability-video-lecture)
    * [Langkah 2: Tinjau artikel skalabilitas](#step-2-review-the-scalability-article)
    * [Langkah berikutnya](#next-steps)
* [Performa vs skalabilitas](#performance-vs-scalability)
* [Latensi vs throughput](#latency-vs-throughput)
* [Ketersediaan vs konsistensi](#availability-vs-consistency)
    * [Teorema CAP](#cap-theorem)
        * [CP - konsistensi dan toleransi partisi](#cp---consistency-and-partition-tolerance)
        * [AP - ketersediaan dan toleransi partisi](#ap---availability-and-partition-tolerance)
* [Pola konsistensi](#consistency-patterns)
    * [Konsistensi lemah](#weak-consistency)
    * [Konsistensi eventual](#eventual-consistency)
    * [Konsistensi kuat](#strong-consistency)
* [Pola ketersediaan](#availability-patterns)
    * [Fail-over](#fail-over)
    * [Replikasi](#replication)
    * [Ketersediaan dalam angka](#availability-in-numbers)
* [Sistem nama domain](#domain-name-system)
* [Jaringan pengiriman konten](#content-delivery-network)
    * [Push CDN](#push-cdns)
    * [Pull CDN](#pull-cdns)
* [Load balancer](#load-balancer)
    * [Aktif-pasif](#active-passive)
    * [Aktif-aktif](#active-active)
    * [Load balancing Layer 4](#layer-4-load-balancing)
    * [Load balancing Layer 7](#layer-7-load-balancing)
    * [Skalabilitas horizontal](#horizontal-scaling)
* [Reverse proxy (web server)](#reverse-proxy-web-server)
    * [Load balancer vs reverse proxy](#load-balancer-vs-reverse-proxy)
* [Lapisan aplikasi](#application-layer)
    * [Mikroservis](#microservices)
    * [Penemuan layanan](#service-discovery)
* [Basis data](#database)
    * [Sistem manajemen basis data relasional (RDBMS)](#relational-database-management-system-rdbms)
        * [Replikasi master-slave](#master-slave-replication)
        * [Replikasi master-master](#master-master-replication)
        * [Federasi](#federation)
        * [Sharding](#sharding)
        * [Denormalisasi](#denormalization)
        * [Pengaturan SQL (SQL tuning)](#sql-tuning)
    * [NoSQL](#nosql)
        * [Penyimpanan key-value](#key-value-store)
        * [Penyimpanan dokumen](#document-store)
        * [Penyimpanan kolom lebar](#wide-column-store)
        * [Basis Data Graf](#graph-database)
    * [SQL atau NoSQL](#sql-or-nosql)
* [Cache](#cache)
    * [Caching klien](#client-caching)
    * [Caching CDN](#cdn-caching)
    * [Caching server web](#web-server-caching)
    * [Caching basis data](#database-caching)
    * [Caching aplikasi](#application-caching)
    * [Caching di tingkat query basis data](#caching-at-the-database-query-level)
    * [Caching di tingkat objek](#caching-at-the-object-level)
    * [Kapan memperbarui cache](#when-to-update-the-cache)
        * [Cache-aside](#cache-aside)
        * [Write-through](#write-through)
        * [Write-behind (write-back)](#write-behind-write-back)
        * [Refresh-ahead](#refresh-ahead)
* [Asinkronisme](#asynchronism)
    * [Antrian pesan](#message-queues)
    * [Antrean tugas](#task-queues)
    * [Tekanan balik](#back-pressure)
* [Komunikasi](#communication)
    * [Protokol kontrol transmisi (TCP)](#transmission-control-protocol-tcp)
    * [Protokol datagram pengguna (UDP)](#user-datagram-protocol-udp)
    * [Panggilan prosedur jarak jauh (RPC)](#remote-procedure-call-rpc)
    * [Transfer status representasional (REST)](#representational-state-transfer-rest)
* [Keamanan](#security)
* [Lampiran](#appendix)
    * [Tabel pangkat dua](#powers-of-two-table)
    * [Angka latensi yang harus diketahui setiap programmer](#latency-numbers-every-programmer-should-know)
    * [Pertanyaan tambahan wawancara desain sistem](#additional-system-design-interview-questions)
    * [Arsitektur dunia nyata](#real-world-architectures)
    * [Arsitektur perusahaan](#company-architectures)
    * [Blog teknik perusahaan](#company-engineering-blogs)
* [Dalam pengembangan](#under-development)
* [Kredit](#credits)
* [Info kontak](#contact-info)
* [Lisensi](#license)

## Panduan belajar

> Topik yang disarankan untuk ditinjau berdasarkan waktu wawancara Anda (pendek, sedang, panjang).

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**Q: Untuk wawancara, apakah saya perlu tahu semua yang ada di sini?**

**A: Tidak, Anda tidak perlu tahu semuanya di sini untuk mempersiapkan wawancara**.

Pertanyaan yang diajukan dalam wawancara tergantung pada variabel seperti:

* Seberapa banyak pengalaman yang Anda miliki
* Apa latar belakang teknis Anda
* Untuk posisi apa Anda wawancara
* Dengan perusahaan mana Anda wawancara
* Keberuntungan

Kandidat yang lebih berpengalaman umumnya diharapkan mengetahui lebih banyak tentang desain sistem.  Arsitek atau pemimpin tim mungkin diharapkan tahu lebih banyak daripada kontributor individual.  Perusahaan teknologi papan atas kemungkinan memiliki satu atau lebih putaran wawancara desain.

Mulai dari yang luas dan perdalam di beberapa area. Penting untuk mengetahui sedikit tentang berbagai topik desain sistem utama. Sesuaikan panduan berikut berdasarkan timeline Anda, pengalaman, posisi yang Anda lamar, dan perusahaan tempat Anda melamar.

* **Timeline pendek** - Fokus pada **luas** topik desain sistem. Latihan dengan mengerjakan **beberapa** pertanyaan wawancara.
* **Timeline sedang** - Fokus pada **luas** dan **sedikit mendalam** topik desain sistem. Latihan dengan mengerjakan **banyak** pertanyaan wawancara.
* **Timeline panjang** - Fokus pada **luas** dan **lebih mendalam** topik desain sistem. Latihan dengan mengerjakan **sebagian besar** pertanyaan wawancara.

| | Pendek | Sedang | Panjang |
|---|---|---|---|
| Baca [Topik desain sistem](#index-of-system-design-topics) untuk memahami secara luas bagaimana sistem bekerja | :+1: | :+1: | :+1: |
| Baca beberapa artikel di [Blog engineering perusahaan](#company-engineering-blogs) dari perusahaan tempat Anda melamar | :+1: | :+1: | :+1: |
| Baca beberapa [Arsitektur dunia nyata](#real-world-architectures) | :+1: | :+1: | :+1: |
| Tinjau [Cara menghadapi pertanyaan wawancara desain sistem](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| Kerjakan [Pertanyaan wawancara desain sistem beserta solusi](#system-design-interview-questions-with-solutions) | Beberapa | Banyak | Sebagian besar |
| Kerjakan [Pertanyaan wawancara desain berorientasi objek beserta solusi](#object-oriented-design-interview-questions-with-solutions) | Beberapa | Banyak | Sebagian besar |
| Tinjau [Pertanyaan wawancara desain sistem tambahan](#additional-system-design-interview-questions) | Beberapa | Banyak | Sebagian besar |

## Cara menghadapi pertanyaan wawancara desain sistem

> Cara menghadapi pertanyaan wawancara desain sistem.

Wawancara desain sistem adalah **percakapan terbuka**. Anda diharapkan untuk memimpinnya.

Anda dapat menggunakan langkah-langkah berikut untuk memandu diskusi. Untuk membantu memperkuat proses ini, kerjakan bagian [Pertanyaan wawancara desain sistem beserta solusi](#system-design-interview-questions-with-solutions) menggunakan langkah-langkah berikut.

### Langkah 1: Garis besar use case, batasan, dan asumsi

Kumpulkan kebutuhan dan tentukan ruang lingkup masalah. Ajukan pertanyaan untuk memperjelas use case dan batasan. Diskusikan asumsi.

* Siapa yang akan menggunakannya?
* Bagaimana mereka akan menggunakannya?
* Berapa banyak pengguna yang ada?
* Apa yang dilakukan sistem?
* Apa input dan output dari sistem?
* Berapa banyak data yang diperkirakan akan ditangani?
* Berapa banyak permintaan per detik yang diperkirakan?
* Berapa rasio baca terhadap tulis yang diharapkan?

### Langkah 2: Buat desain tingkat tinggi

Gambarkan desain tingkat tinggi dengan semua komponen penting.

* Sketsa komponen utama dan koneksinya
* Justifikasi ide Anda

### Langkah 3: Rancang komponen inti

Masuk ke detail untuk setiap komponen inti.  Misalnya, jika Anda diminta untuk [merancang layanan pemendek url](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md), diskusikan:

* Membuat dan menyimpan hash dari url lengkap
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) dan [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * Tabrakan hash
    * SQL atau NoSQL
    * Skema basis data
* Menerjemahkan url yang telah di-hash ke url lengkap
    * Pencarian basis data
* Desain API dan berorientasi objek

### Langkah 4: Skalakan desain

Identifikasi dan atasi kemacetan, sesuai dengan batasan yang ada.  Misalnya, apakah Anda membutuhkan hal berikut untuk mengatasi masalah skalabilitas?

* Load balancer
* Skalabilitas horizontal
* Caching
* Sharding basis data

Diskusikan solusi potensial dan pertukaran.  Segalanya adalah pertukaran.  Atasi kemacetan dengan menggunakan [prinsip desain sistem yang skalabel](#index-of-system-design-topics).

### Perhitungan kasar di atas kertas

Anda mungkin diminta untuk melakukan beberapa estimasi secara manual.  Lihat [Lampiran](#appendix) untuk sumber daya berikut:

* [Gunakan perhitungan kasar di atas kertas](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [Tabel pangkat dua](#powers-of-two-table)
* [Angka latensi yang harus diketahui setiap programmer](#latency-numbers-every-programmer-should-know)

### Sumber dan bacaan lanjutan

Lihat tautan berikut untuk mendapatkan gambaran lebih baik tentang apa yang diharapkan:

* [Cara sukses dalam wawancara desain sistem](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [Wawancara desain sistem](http://www.hiredintech.com/system-design)
* [Pengantar Arsitektur dan Wawancara Desain Sistem](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [Template desain sistem](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## Pertanyaan wawancara desain sistem beserta solusi

> Pertanyaan umum wawancara desain sistem dengan diskusi, kode, dan diagram contoh.
>
> Solusi terhubung ke konten di folder `solutions/`.

| Pertanyaan | |
|---|---|
| Desain Pastebin.com (atau Bit.ly) | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Desain linimasa dan pencarian Twitter (atau feed dan pencarian Facebook) | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| Desain web crawler | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Desain Mint.com | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| Desain struktur data untuk jejaring sosial | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| Desain penyimpanan key-value untuk mesin pencari | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Desain fitur peringkat penjualan Amazon berdasarkan kategori | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| Desain sistem yang dapat diskalakan ke jutaan pengguna di AWS | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| Tambahkan pertanyaan desain sistem | [Kontribusi](#contributing) |

### Desain Pastebin.com (atau Bit.ly)

[Lihat latihan dan solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Desain linimasa dan pencarian Twitter (atau feed dan pencarian Facebook)

[Lihat latihan dan solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### Desain web crawler

[Lihat latihan dan solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| Desain hash map | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| Desain cache least recently used | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| Desain call center | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| Desain setumpuk kartu | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| Desain tempat parkir | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| Desain server chat | [Solusi](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| Desain array melingkar | [Kontribusi](#contributing)  |
| Tambahkan pertanyaan desain berorientasi objek | [Kontribusi](#contributing) |

## Topik desain sistem: mulai di sini

Baru dalam desain sistem?

Pertama, Anda perlu pemahaman dasar tentang prinsip umum, mempelajari apa itu, bagaimana digunakan, serta kelebihan dan kekurangannya.

### Langkah 1: Tinjau kuliah video skalabilitas

[Kuliah Skalabilitas di Harvard](https://www.youtube.com/watch?v=-W9F__D3oY4)

* Topik yang dibahas:
    * Vertical scaling
    * Horizontal scaling
    * Caching
    * Load balancing
    * Replikasi basis data
    * Partisi basis data

### Langkah 2: Tinjau artikel skalabilitas

[Skalabilitas](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* Topik yang dibahas:
    * [Clones](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [Database](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [Cache](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [Asynchronism](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### Langkah selanjutnya

Selanjutnya, kita akan melihat pertukaran tingkat tinggi:

* **Performa** vs **skalabilitas**
* **Latensi** vs **throughput**
* **Ketersediaan** vs **konsistensi**

Ingatlah bahwa **semuanya adalah pertukaran**.

Kemudian kita akan membahas topik yang lebih spesifik seperti DNS, CDN, dan load balancer.

## Performa vs skalabilitas

Sebuah layanan dikatakan **skalabel** jika menghasilkan peningkatan **performa** secara proporsional dengan sumber daya yang ditambahkan. Secara umum, meningkatkan performa berarti melayani lebih banyak unit kerja, tetapi juga bisa untuk menangani unit kerja yang lebih besar, seperti ketika kumpulan data bertambah.<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

Cara lain untuk melihat performa vs skalabilitas:

* Jika Anda memiliki masalah **performa**, sistem Anda lambat untuk satu pengguna.
* Jika Anda memiliki masalah **skalabilitas**, sistem Anda cepat untuk satu pengguna tetapi lambat di bawah beban berat.

### Sumber dan bacaan lebih lanjut

* [A word on scalability](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## Latensi vs throughput

**Latensi** adalah waktu yang dibutuhkan untuk melakukan suatu tindakan atau menghasilkan suatu hasil.

**Throughput** adalah jumlah tindakan atau hasil tersebut per satuan waktu.

Secara umum, Anda harus mengupayakan **throughput maksimal** dengan **latensi yang dapat diterima**.

### Sumber dan bacaan lebih lanjut

* [Understanding latency vs throughput](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## Ketersediaan vs konsistensi

### Teorema CAP

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>Sumber: CAP theorem revisited</a></i>
</p>

Dalam sistem komputer terdistribusi, Anda hanya dapat mendukung dua dari jaminan berikut:

* **Konsistensi** - Setiap pembacaan menerima penulisan terbaru atau terjadi error
* **Ketersediaan** - Setiap permintaan menerima respons, tanpa jaminan bahwa respons tersebut berisi versi informasi terbaru
* **Toleransi Partisi** - Sistem tetap beroperasi meskipun terjadi partisi sembarangan akibat kegagalan jaringan

*Jaringan tidak dapat diandalkan, jadi Anda perlu mendukung toleransi partisi. Anda perlu membuat kompromi perangkat lunak antara konsistensi dan ketersediaan.*

#### CP - konsistensi dan toleransi partisi

Menunggu respons dari node yang terpartisi dapat menghasilkan error timeout. CP adalah pilihan yang baik jika kebutuhan bisnis Anda mengharuskan pembacaan dan penulisan atomik.

#### AP - ketersediaan dan toleransi partisi

Respons mengembalikan versi data yang paling mudah tersedia di node manapun, yang mungkin bukan yang terbaru. Penulisan mungkin memerlukan waktu untuk menyebar setelah partisi teratasi.

AP adalah pilihan yang baik jika kebutuhan bisnis mengizinkan [konsistensi eventual](#eventual-consistency) atau ketika sistem harus tetap berfungsi meskipun terjadi error eksternal.

### Sumber dan bacaan lebih lanjut

* [CAP theorem revisited](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [Pendahuluan CAP theorem dalam bahasa Inggris sederhana](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [The CAP theorem](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## Pola konsistensi

Dengan beberapa salinan data yang sama, kita dihadapkan pada pilihan tentang bagaimana menyinkronkan mereka agar klien memiliki pandangan data yang konsisten. Ingat definisi konsistensi dari [CAP theorem](#cap-theorem) - Setiap pembacaan menerima penulisan terbaru atau terjadi error.

### Konsistensi lemah

Setelah penulisan, pembacaan mungkin bisa melihatnya atau tidak. Pendekatan yang diambil adalah usaha terbaik.

Pendekatan ini ditemukan pada sistem seperti memcached. Konsistensi lemah bekerja dengan baik pada kasus penggunaan waktu nyata seperti VoIP, video chat, dan game multipemain realtime. Misalnya, jika Anda sedang melakukan panggilan telepon dan kehilangan sinyal beberapa detik, ketika Anda kembali terhubung Anda tidak mendengar apa yang diucapkan selama kehilangan koneksi.

### Konsistensi eventual

Setelah penulisan, pembacaan pada akhirnya akan melihatnya (biasanya dalam hitungan milidetik). Data direplikasi secara asinkron.

Pendekatan ini digunakan dalam sistem seperti DNS dan email. Konsistensi eventual bekerja dengan baik pada sistem yang sangat tersedia.

### Konsistensi kuat

Setelah penulisan, pembacaan akan melihatnya. Data direplikasi secara sinkron.

Pendekatan ini digunakan dalam sistem berkas dan RDBMS. Konsistensi kuat bekerja dengan baik pada sistem yang membutuhkan transaksi.

### Sumber dan bacaan lebih lanjut

* [Transaksi lintas pusat data](http://snarfed.org/transactions_across_datacenters_io.html)

## Pola ketersediaan

Ada dua pola yang saling melengkapi untuk mendukung ketersediaan tinggi: **fail-over** dan **replikasi**.

### Fail-over

#### Aktif-pasif

Dengan fail-over aktif-pasif, heartbeat dikirim antara server aktif dan server pasif yang siaga. Jika heartbeat terputus, server pasif mengambil alih alamat IP server aktif dan melanjutkan layanan.

Lamanya downtime ditentukan oleh apakah server pasif sudah berjalan dalam mode siaga 'hot' atau perlu memulai dari mode siaga 'cold'. Hanya server aktif yang menangani trafik.

Fail-over aktif-pasif juga dapat disebut sebagai failover master-slave.

#### Aktif-aktif

Pada aktif-aktif, kedua server menangani trafik, membagi beban di antara mereka.

Jika server bersifat publik, DNS perlu mengetahui tentang alamat IP publik kedua server. Jika server bersifat internal, logika aplikasi perlu mengetahui tentang kedua server.

Fail-over aktif-aktif juga dapat disebut sebagai failover master-master.

### Kekurangan: failover

* Fail-over menambah perangkat keras dan kompleksitas tambahan.
* Ada potensi kehilangan data jika sistem aktif gagal sebelum data baru yang ditulis dapat direplikasi ke sistem pasif.

### Replikasi

#### Master-slave dan master-master

Topik ini dibahas lebih lanjut pada bagian [Database](#database):

* [Replikasi master-slave](#master-slave-replication)
* [Replikasi master-master](#master-master-replication)

### Ketersediaan dalam angka

Ketersediaan sering dihitung berdasarkan waktu aktif (atau waktu tidak aktif) sebagai persentase waktu layanan tersedia. Ketersediaan umumnya diukur dalam jumlah angka 9--layanan dengan ketersediaan 99,99% disebut memiliki empat angka 9.

#### Ketersediaan 99,9% - tiga angka 9

| Durasi              | Waktu tidak aktif yang dapat diterima |
|---------------------|---------------------------------------|
| Waktu tidak aktif per tahun   | 8j 45mnt 57d                   |
| Waktu tidak aktif per bulan   | 43mnt 49,7d                    |
| Waktu tidak aktif per minggu  | 10mnt 4,8d                     |
| Waktu tidak aktif per hari    | 1mnt 26,4d                     |

#### Ketersediaan 99,99% - empat angka 9

| Durasi              | Waktu tidak aktif yang dapat diterima |
|---------------------|---------------------------------------|
| Waktu tidak aktif per tahun   | 52mnt 35,7d                   |
| Waktu tidak aktif per bulan   | 4mnt 23d                      |
| Waktu tidak aktif per minggu  | 1mnt 5d                       |
| Waktu tidak aktif per hari    | 8,6d                          |

#### Ketersediaan secara paralel vs secara berurutan

Jika suatu layanan terdiri dari beberapa komponen yang rawan gagal, ketersediaan keseluruhan layanan bergantung pada apakah komponen tersebut berurutan atau paralel.

###### Secara berurutan
Ketersediaan keseluruhan menurun ketika dua komponen dengan ketersediaan < 100% berada dalam urutan:


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```
Jika baik `Foo` maupun `Bar` masing-masing memiliki ketersediaan 99,9%, total ketersediaan mereka secara berurutan adalah 99,8%.

###### Secara paralel

Ketersediaan keseluruhan meningkat ketika dua komponen dengan ketersediaan < 100% berada secara paralel:


```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
Jika baik `Foo` maupun `Bar` masing-masing memiliki ketersediaan 99,9%, total ketersediaan mereka secara paralel akan menjadi 99,9999%.

## Sistem nama domain

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>Sumber: Presentasi keamanan DNS</a></i>
</p>

Sistem Nama Domain (DNS) menerjemahkan nama domain seperti www.example.com menjadi alamat IP.

DNS bersifat hierarkis, dengan beberapa server otoritatif di tingkat atas. Router atau ISP Anda menyediakan informasi tentang server DNS mana yang harus dihubungi saat melakukan lookup. Server DNS tingkat bawah melakukan cache pemetaan, yang bisa menjadi usang karena keterlambatan propagasi DNS. Hasil DNS juga dapat di-cache oleh browser atau OS Anda untuk jangka waktu tertentu, yang ditentukan oleh [time to live (TTL)](https://id.wikipedia.org/wiki/Time_to_live).

* **NS record (name server)** - Menentukan server DNS untuk domain/subdomain Anda.
* **MX record (mail exchange)** - Menentukan server surat untuk menerima pesan.
* **A record (address)** - Menunjukkan nama ke alamat IP.
* **CNAME (canonical)** - Menunjukkan nama ke nama lain atau `CNAME` (example.com ke www.example.com) atau ke record `A`.

Layanan seperti [CloudFlare](https://www.cloudflare.com/dns/) dan [Route 53](https://aws.amazon.com/route53/) menyediakan layanan DNS terkelola. Beberapa layanan DNS dapat mengarahkan lalu lintas melalui berbagai metode:

* [Weighted round robin](https://www.jscape.com/blog/load-balancing-algorithms)
    * Mencegah lalu lintas menuju server yang sedang dalam perawatan
    * Menyeimbangkan antara ukuran cluster yang bervariasi
    * Pengujian A/B
* [Latency-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Geolocation-based](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### Kekurangan: DNS

* Mengakses server DNS memperkenalkan sedikit penundaan, walau dapat dikurangi dengan cache seperti dijelaskan di atas.
* Manajemen server DNS bisa rumit dan umumnya diatur oleh [pemerintah, ISP, dan perusahaan besar](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729).
* Layanan DNS belakangan ini menjadi sasaran [serangan DDoS](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/), sehingga pengguna tidak dapat mengakses situs seperti Twitter tanpa mengetahui alamat IP Twitter.

### Sumber dan bacaan lebih lanjut

* [Arsitektur DNS](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [Wikipedia](https://id.wikipedia.org/wiki/Sistem_Nama_Domain)
* [Artikel DNS](https://support.dnsimple.com/categories/dns/)

## Jaringan pengiriman konten

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>Sumber: Mengapa menggunakan CDN</a></i>
</p>

Jaringan pengiriman konten (CDN) adalah jaringan server proxy yang tersebar secara global, melayani konten dari lokasi yang lebih dekat dengan pengguna. Umumnya, file statis seperti HTML/CSS/JS, foto, dan video disajikan dari CDN, meskipun beberapa CDN seperti CloudFront milik Amazon mendukung konten dinamis. Resolusi DNS situs akan memberi tahu klien server mana yang harus dihubungi.

Penyajian konten dari CDN dapat secara signifikan meningkatkan performa dengan dua cara:

* Pengguna menerima konten dari pusat data yang dekat dengan mereka
* Server Anda tidak perlu melayani permintaan yang telah dipenuhi oleh CDN

### Push CDN

Push CDN menerima konten baru setiap kali terjadi perubahan pada server Anda. Anda bertanggung jawab penuh untuk menyediakan konten, mengunggah langsung ke CDN dan menulis ulang URL agar mengarah ke CDN. Anda dapat mengatur kapan konten kedaluwarsa dan kapan diperbarui. Konten diunggah hanya ketika konten baru atau berubah, sehingga meminimalkan lalu lintas, tetapi memaksimalkan penyimpanan.

Situs dengan sedikit lalu lintas atau situs dengan konten yang jarang diperbarui sangat cocok menggunakan Push CDN. Konten ditempatkan di CDN sekali saja, bukan ditarik ulang secara berkala.

### Pull CDN

Pull CDN mengambil konten baru dari server Anda ketika pengguna pertama kali meminta konten tersebut. Anda membiarkan konten tetap di server Anda dan menulis ulang URL agar mengarah ke CDN. Hal ini menyebabkan permintaan pertama lebih lambat hingga konten di-cache di CDN.

[Time-to-live (TTL)](https://en.wikipedia.org/wiki/Time_to_live) menentukan berapa lama konten di-cache. Pull CDN meminimalkan ruang penyimpanan di CDN, tetapi dapat menciptakan lalu lintas berulang jika file kedaluwarsa dan ditarik sebelum benar-benar berubah.

Situs dengan lalu lintas tinggi sangat cocok menggunakan Pull CDN, karena lalu lintas tersebar lebih merata dengan hanya konten yang baru saja diminta tetap berada di CDN.

### Kelemahan: CDN

* Biaya CDN bisa signifikan tergantung pada lalu lintas, meskipun ini harus dibandingkan dengan biaya tambahan jika tidak menggunakan CDN.
* Konten bisa menjadi usang jika diperbarui sebelum TTL habis.
* CDN memerlukan perubahan URL untuk konten statis agar mengarah ke CDN.

### Sumber dan bacaan lebih lanjut

* [Pengiriman konten yang tersebar secara global](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [Perbedaan antara Push dan Pull CDN](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)

* [Wikipedia](https://id.wikipedia.org/wiki/Content_delivery_network)

## Penyeimbang beban

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Sumber: Pola desain sistem yang skalabel</a></i>
</p>

Penyeimbang beban mendistribusikan permintaan klien yang masuk ke sumber daya komputasi seperti server aplikasi dan basis data. Dalam setiap kasus, penyeimbang beban mengembalikan respons dari sumber daya komputasi ke klien yang sesuai. Penyeimbang beban efektif untuk:

* Mencegah permintaan masuk ke server yang tidak sehat
* Mencegah sumber daya kelebihan beban
* Membantu menghilangkan titik kegagalan tunggal

Penyeimbang beban dapat diimplementasikan dengan perangkat keras (mahal) atau dengan perangkat lunak seperti HAProxy.

Manfaat tambahan meliputi:

* **Terminasi SSL** - Mendekripsi permintaan masuk dan mengenkripsi respons server sehingga server backend tidak perlu melakukan operasi yang berpotensi mahal ini
    * Menghilangkan kebutuhan untuk menginstal [sertifikat X.509](https://id.wikipedia.org/wiki/X.509) pada setiap server
* **Persistensi sesi** - Mengeluarkan cookie dan mengarahkan permintaan klien tertentu ke instance yang sama jika aplikasi web tidak melacak sesi

Untuk melindungi dari kegagalan, umum untuk menyiapkan beberapa penyeimbang beban, baik dalam mode [aktif-pasif](#active-passive) atau [aktif-aktif](#active-active).

Penyeimbang beban dapat mengarahkan lalu lintas berdasarkan berbagai metrik, termasuk:

* Acak
* Beban paling ringan
* Sesi/cookie
* [Round robin atau weighted round robin](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Layer 4](#layer-4-load-balancing)
* [Layer 7](#layer-7-load-balancing)

### Penyeimbangan beban Layer 4

Penyeimbang beban Layer 4 melihat informasi pada [lapisan transport](#communication) untuk memutuskan bagaimana mendistribusikan permintaan. Umumnya, ini melibatkan alamat IP sumber, tujuan, dan port dalam header, tetapi tidak isi paket. Penyeimbang beban Layer 4 meneruskan paket jaringan ke dan dari server hulu, melakukan [Network Address Translation (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/).

### Penyeimbangan beban Layer 7
Penyeimbang beban Layer 7 melihat pada [lapisan aplikasi](#communication) untuk memutuskan bagaimana mendistribusikan permintaan. Ini dapat melibatkan isi header, pesan, dan cookie. Penyeimbang beban Layer 7 menghentikan lalu lintas jaringan, membaca pesan, membuat keputusan penyeimbangan beban, lalu membuka koneksi ke server yang dipilih. Sebagai contoh, penyeimbang beban layer 7 dapat mengarahkan lalu lintas video ke server yang menyimpan video sementara mengarahkan lalu lintas penagihan pengguna yang lebih sensitif ke server yang telah diperkuat keamanannya.

Dengan mengorbankan fleksibilitas, penyeimbangan beban layer 4 membutuhkan waktu dan sumber daya komputasi yang lebih sedikit daripada Layer 7, meskipun dampak kinerjanya bisa minimal pada perangkat keras komoditas modern.

### Pensakalan horizontal

Penyeimbang beban juga dapat membantu penskalaan horizontal, meningkatkan kinerja dan ketersediaan. Melakukan penskalaan keluar menggunakan mesin komoditas lebih hemat biaya dan menghasilkan ketersediaan yang lebih tinggi dibandingkan dengan penskalaan ke atas satu server pada perangkat keras yang lebih mahal, yang disebut **Pensakalan Vertikal**. Selain itu, lebih mudah merekrut talenta yang bekerja pada perangkat keras komoditas daripada pada sistem perusahaan khusus.

#### Kerugian: penskalaan horizontal

* Pensakalan secara horizontal memperkenalkan kompleksitas dan melibatkan penggandaan server
    * Server harus stateless: mereka tidak boleh berisi data terkait pengguna seperti sesi atau foto profil
    * Sesi dapat disimpan di pusat data terpusat seperti [database](#database) (SQL, NoSQL) atau [cache](#cache) persisten (Redis, Memcached)
* Server hilir seperti cache dan database perlu menangani lebih banyak koneksi simultan seiring server hulu melakukan penskalaan keluar

### Kerugian: penyeimbang beban

* Penyeimbang beban dapat menjadi hambatan kinerja jika tidak memiliki sumber daya yang cukup atau jika tidak dikonfigurasi dengan benar.
* Memperkenalkan penyeimbang beban untuk membantu menghilangkan satu titik kegagalan mengakibatkan peningkatan kompleksitas.
* Satu penyeimbang beban adalah satu titik kegagalan, mengonfigurasi beberapa penyeimbang beban lebih lanjut meningkatkan kompleksitas.

### Sumber dan bacaan lebih lanjut

* [Arsitektur NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Panduan arsitektur HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Skalabilitas](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [Wikipedia](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [Penyeimbangan beban Layer 4](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [Penyeimbangan beban Layer 7](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [Konfigurasi listener ELB](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## Proksi balik (web server)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>Sumber: Wikipedia</a></i>
  <br/>
</p>

Reverse proxy adalah server web yang memusatkan layanan internal dan menyediakan antarmuka terpadu kepada publik. Permintaan dari klien diteruskan ke server yang dapat memenuhinya sebelum reverse proxy mengembalikan respons server ke klien.

Manfaat tambahan meliputi:

* **Keamanan meningkat** - Menyembunyikan informasi tentang server backend, memblokir IP, membatasi jumlah koneksi per klien
* **Skalabilitas dan fleksibilitas meningkat** - Klien hanya melihat IP reverse proxy, memungkinkan Anda meningkatkan jumlah server atau mengubah konfigurasinya
* **Terminasi SSL** - Mendekripsi permintaan masuk dan mengenkripsi respons server sehingga server backend tidak perlu melakukan operasi yang berpotensi mahal ini
    * Menghilangkan kebutuhan untuk memasang [sertifikat X.509](https://id.wikipedia.org/wiki/X.509) di setiap server
* **Kompresi** - Mengompresi respons server
* **Caching** - Mengembalikan respons untuk permintaan yang telah di-cache
* **Konten statis** - Menyajikan konten statis secara langsung
    * HTML/CSS/JS
    * Foto
    * Video
    * Dll

### Load balancer vs reverse proxy

* Men-deploy load balancer berguna ketika Anda memiliki banyak server. Seringkali, load balancer mengarahkan traffic ke sekumpulan server yang melayani fungsi yang sama.
* Reverse proxy bisa berguna bahkan hanya dengan satu server web atau server aplikasi, membuka manfaat seperti yang dijelaskan pada bagian sebelumnya.
* Solusi seperti NGINX dan HAProxy dapat mendukung reverse proxy layer 7 dan load balancing.

### Kekurangan: reverse proxy

* Menambahkan reverse proxy menyebabkan peningkatan kompleksitas.
* Satu reverse proxy adalah titik kegagalan tunggal, mengonfigurasi beberapa reverse proxy (misalnya [failover](https://id.wikipedia.org/wiki/Failover)) semakin meningkatkan kompleksitas.

### Sumber dan bacaan lanjutan

* [Reverse proxy vs load balancer](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [Arsitektur NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [Panduan arsitektur HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Wikipedia](https://id.wikipedia.org/wiki/Reverse_proxy)

## Lapisan aplikasi

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Sumber: Intro to architecting systems for scale</a></i>
</p>

Memisahkan lapisan web dari lapisan aplikasi (juga dikenal sebagai lapisan platform) memungkinkan Anda untuk menskalakan dan mengonfigurasi kedua lapisan secara independen.  Menambahkan API baru berarti menambahkan server aplikasi tanpa harus menambah server web tambahan.  **Prinsip tanggung jawab tunggal** menganjurkan layanan-layanan kecil dan otonom yang bekerja bersama-sama.  Tim kecil dengan layanan kecil dapat merencanakan pertumbuhan cepat secara lebih agresif.

Pekerja di lapisan aplikasi juga membantu memungkinkan [asinkronisme](#asynchronism).

### Microservices

Terkait dengan pembahasan ini adalah [microservices](https://id.wikipedia.org/wiki/Mikroservis), yang dapat digambarkan sebagai rangkaian layanan kecil, modular, dan dapat di-deploy secara independen.  Setiap layanan menjalankan proses unik dan berkomunikasi melalui mekanisme yang terdefinisi dengan baik dan ringan untuk mencapai tujuan bisnis. <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

Pinterest, sebagai contoh, dapat memiliki microservices seperti: profil pengguna, pengikut, feed, pencarian, unggah foto, dll.

### Service Discovery

Sistem seperti [Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest), dan [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) dapat membantu layanan saling menemukan dengan melacak nama, alamat, dan port yang terdaftar.  [Health checks](https://www.consul.io/intro/getting-started/checks.html) membantu memverifikasi integritas layanan dan sering dilakukan menggunakan endpoint [HTTP](#hypertext-transfer-protocol-http).  Baik Consul maupun Etcd memiliki [key-value store](#key-value-store) bawaan yang dapat berguna untuk menyimpan nilai konfigurasi dan data bersama lainnya.

### Kerugian: lapisan aplikasi

* Menambahkan lapisan aplikasi dengan layanan yang saling terhubung secara longgar membutuhkan pendekatan berbeda dari sudut pandang arsitektur, operasi, dan proses (dibandingkan sistem monolitik).
* Microservices dapat menambah kompleksitas dalam hal deployment dan operasi.

### Sumber dan bacaan lebih lanjut

* [Intro to architecting systems for scale](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Arsitektur berbasis layanan](https://id.wikipedia.org/wiki/Arsitektur_berorientasi_layanan)
* [Pengenalan Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [Inilah yang perlu Anda ketahui tentang membangun microservices](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## Database

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Sumber: Scaling up to your first 10 million users</a></i>
</p>

### Sistem manajemen basis data relasional (RDBMS)

Database relasional seperti SQL adalah kumpulan item data yang diorganisir dalam tabel.

**ACID** adalah seperangkat properti dari [transaksi](https://en.wikipedia.org/wiki/Database_transaction) database relasional.

* **Atomicity** - Setiap transaksi dilakukan secara keseluruhan atau tidak sama sekali
* **Consistency** - Setiap transaksi akan membawa database dari satu keadaan yang valid ke keadaan valid lainnya
* **Isolation** - Menjalankan transaksi secara bersamaan menghasilkan hasil yang sama seperti jika transaksi dijalankan secara serial
* **Durability** - Setelah transaksi dikomitmen, maka akan tetap demikian

Ada banyak teknik untuk menambah skala database relasional: **replikasi master-slave**, **replikasi master-master**, **federasi**, **sharding**, **denormalisasi**, dan **penyetelan SQL**.

#### Replikasi master-slave

Master melayani pembacaan dan penulisan, mereplikasi penulisan ke satu atau lebih slave, yang hanya melayani pembacaan. Slave juga dapat mereplikasi ke slave tambahan secara bertingkat. Jika master offline, sistem dapat terus beroperasi dalam mode hanya-baca sampai slave dipromosikan sebagai master atau master baru disediakan.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Sumber: Skalabilitas, ketersediaan, stabilitas, pola</a></i>
</p>

##### Kekurangan: replikasi master-slave

* Logika tambahan dibutuhkan untuk mempromosikan slave menjadi master.
* Lihat [Kekurangan: replikasi](#disadvantages-replication) untuk poin terkait **baik** master-slave maupun master-master.

#### Replikasi master-master

Kedua master melayani pembacaan dan penulisan dan berkoordinasi satu sama lain untuk penulisan. Jika salah satu master turun, sistem dapat terus beroperasi dengan pembacaan dan penulisan.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Sumber: Skalabilitas, ketersediaan, stabilitas, pola</a></i>
</p>

##### Kekurangan: replikasi master-master

* Anda membutuhkan penyeimbang beban atau Anda perlu mengubah logika aplikasi untuk menentukan di mana menulis.
* Sebagian besar sistem master-master baik konsistensinya longgar (melanggar ACID) atau memiliki latensi penulisan yang lebih tinggi akibat sinkronisasi.
* Resolusi konflik semakin sering terjadi ketika semakin banyak node penulis ditambahkan dan saat latensi meningkat.
* Lihat [Kerugian: replikasi](#disadvantages-replication) untuk poin-poin yang berkaitan dengan **baik** master-slave maupun master-master.

##### Kerugian: replikasi

* Ada potensi kehilangan data jika master gagal sebelum data yang baru ditulis dapat direplikasi ke node lain.
* Penulisan diulang ke replika baca. Jika terdapat banyak penulisan, replika baca dapat menjadi lambat karena harus memutar ulang penulisan dan tidak dapat melakukan banyak pembacaan.
* Semakin banyak slave baca, semakin banyak yang harus direplikasi, yang menyebabkan keterlambatan replikasi lebih besar.
* Pada beberapa sistem, penulisan ke master dapat memunculkan beberapa thread untuk penulisan paralel, sedangkan replika baca hanya mendukung penulisan secara berurutan dengan satu thread.
* Replikasi menambah perangkat keras dan kompleksitas tambahan.

##### Sumber dan bacaan lebih lanjut: replikasi

* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Multi-master replication](https://id.wikipedia.org/wiki/Multi-master_replication)

#### Federasi

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Sumber: Scaling up to your first 10 million users</a></i>
</p>

Federasi (atau pemartisian fungsional) membagi basis data berdasarkan fungsi. Misalnya, daripada satu basis data monolitik, Anda dapat memiliki tiga basis data: **forums**, **users**, dan **products**, sehingga lalu lintas baca dan tulis ke masing-masing basis data lebih sedikit dan mengurangi keterlambatan replikasi. Basis data yang lebih kecil memungkinkan lebih banyak data masuk ke memori, yang menghasilkan lebih banyak cache hit karena peningkatan lokalitas cache. Tanpa satu master pusat yang menserialisasi penulisan, Anda dapat menulis secara paralel, meningkatkan throughput.

##### Kerugian: federasi

* Federasi tidak efektif jika skema Anda membutuhkan fungsi atau tabel yang besar.
* Anda perlu memperbarui logika aplikasi untuk menentukan basis data mana yang akan dibaca dan ditulis.
* Menggabungkan data dari dua basis data lebih kompleks dengan [server link](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers).
* Federasi menambah perangkat keras dan kompleksitas tambahan.

##### Sumber dan bacaan lebih lanjut: federasi

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### Sharding

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Sumber: Pola Skalabilitas, Ketersediaan, Stabilitas</a></i>
</p>

Sharding mendistribusikan data ke berbagai basis data sehingga setiap basis data hanya dapat mengelola sebagian data. Sebagai contoh basis data pengguna, saat jumlah pengguna meningkat, lebih banyak shard ditambahkan ke klaster.

Mirip dengan keuntungan dari [federasi](#federation), sharding menghasilkan lalu lintas baca dan tulis yang lebih sedikit, replikasi yang lebih sedikit, dan cache hit yang lebih banyak. Ukuran indeks juga berkurang, yang umumnya meningkatkan performa dengan kueri yang lebih cepat. Jika satu shard mati, shard lain tetap berjalan, meskipun Anda sebaiknya menambahkan bentuk replikasi untuk menghindari kehilangan data. Seperti federasi, tidak ada satu master pusat yang melakukan serialisasi penulisan, sehingga Anda dapat menulis secara paralel dengan throughput yang lebih tinggi.

Cara umum untuk melakukan shard pada tabel pengguna adalah berdasarkan inisial nama belakang pengguna atau lokasi geografis pengguna.

##### Kerugian: sharding

* Anda perlu memperbarui logika aplikasi agar dapat bekerja dengan shard, yang dapat menghasilkan kueri SQL yang kompleks.
* Distribusi data dapat menjadi tidak merata dalam sebuah shard. Misalnya, sekelompok pengguna aktif pada satu shard dapat menyebabkan beban pada shard tersebut lebih tinggi dibanding shard lain.
    * Rebalancing menambah kompleksitas tambahan. Fungsi sharding berbasis [consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) dapat mengurangi jumlah data yang dipindahkan.
* Menggabungkan data dari beberapa shard menjadi lebih kompleks.
* Sharding menambah kebutuhan perangkat keras dan kompleksitas tambahan.

##### Sumber dan bacaan lebih lanjut: sharding

* [The coming of the shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Shard database architecture](https://id.wikipedia.org/wiki/Shard_(database_architecture))
* [Consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Denormalisasi

Denormalisasi berusaha meningkatkan performa baca dengan mengorbankan sebagian performa tulis. Salinan data yang redundan ditulis di beberapa tabel untuk menghindari join yang mahal. Beberapa RDBMS seperti [PostgreSQL](https://id.wikipedia.org/wiki/PostgreSQL) dan Oracle mendukung [materialized view](https://id.wikipedia.org/wiki/Materialized_view) yang menangani penyimpanan informasi redundan dan menjaga konsistensi salinan redundan.

Setelah data terdistribusi dengan teknik seperti [federasi](#federation) dan [sharding](#sharding), pengelolaan join antar data center semakin menambah kompleksitas. Denormalisasi dapat menghindari kebutuhan akan join kompleks tersebut.

Di sebagian besar sistem, operasi baca bisa jauh lebih banyak daripada tulis, bahkan dengan rasio 100:1 atau 1000:1. Operasi baca yang menghasilkan join database kompleks bisa sangat mahal, menghabiskan banyak waktu untuk operasi disk.

##### Kerugian: denormalisasi

* Data menjadi duplikat.
* Constraint dapat membantu salinan informasi yang redundan tetap sinkron, yang menambah kompleksitas desain basis data.
* Basis data yang didenormalisasi di bawah beban tulis berat mungkin berperforma lebih buruk daripada basis data yang dinormalisasi.

###### Sumber dan bacaan lebih lanjut: denormalisasi

* [Denormalisasi](https://id.wikipedia.org/wiki/Denormalisasi)

#### Penyetelan SQL

Penyetelan SQL adalah topik yang luas dan banyak [buku](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) telah ditulis sebagai referensi.

Penting untuk melakukan **benchmark** dan **profiling** untuk mensimulasikan serta menemukan hambatan.

* **Benchmark** - Simulasikan situasi beban tinggi dengan alat seperti [ab](http://httpd.apache.org/docs/2.2/programs/ab.html).
* **Profiling** - Aktifkan alat seperti [slow query log](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) untuk membantu melacak masalah kinerja.

Benchmarking dan profiling dapat menunjuk pada optimasi berikut.

##### Perketat skema

* MySQL menulis ke disk dalam blok yang berdekatan untuk akses cepat.
* Gunakan `CHAR` daripada `VARCHAR` untuk field berdimensi tetap.
    * `CHAR` memungkinkan akses acak cepat, sedangkan dengan `VARCHAR`, Anda harus menemukan akhir string sebelum pindah ke berikutnya.
* Gunakan `TEXT` untuk blok teks besar seperti posting blog.  `TEXT` juga memungkinkan pencarian boolean.  Penggunaan field `TEXT` mengakibatkan penyimpanan pointer di disk yang digunakan untuk menemukan blok teks.
* Gunakan `INT` untuk angka besar hingga 2^32 atau 4 miliar.
* Gunakan `DECIMAL` untuk mata uang agar terhindar dari kesalahan representasi floating point.
* Hindari menyimpan `BLOB` besar, simpan lokasi objek untuk mengambilnya.
* `VARCHAR(255)` adalah jumlah karakter terbesar yang dapat dihitung dalam angka 8 bit, sering memaksimalkan penggunaan byte pada beberapa RDBMS.
* Atur batasan `NOT NULL` jika memungkinkan untuk [meningkatkan performa pencarian](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search).

##### Gunakan indeks yang baik

* Kolom yang Anda query (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) bisa lebih cepat dengan indeks.
* Indeks biasanya diwakili sebagai [B-tree](https://id.wikipedia.org/wiki/B-tree) self-balancing yang menjaga data tetap terurut dan memungkinkan pencarian, akses berurutan, penyisipan, dan penghapusan dalam waktu logaritmik.
* Penempatan indeks bisa menjaga data tetap di memori, sehingga membutuhkan lebih banyak ruang.
* Penulisan juga bisa lebih lambat karena indeks perlu diperbarui.
* Saat memuat data dalam jumlah besar, mungkin lebih cepat untuk menonaktifkan indeks, memuat data, lalu membangun ulang indeks.

##### Hindari join yang mahal

* [Denormalisasi](#denormalisasi) jika tuntutan kinerja membutuhkannya.

##### Partisi tabel

* Pisahkan sebuah tabel dengan menempatkan titik-titik panas (hot spots) dalam tabel terpisah untuk membantu agar tetap berada di memori.

##### Sesuaikan cache query

* Dalam beberapa kasus, [cache query](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) bisa menyebabkan [masalah kinerja](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/).

##### Sumber dan bacaan lanjutan: Penyempurnaan SQL

* [Tips untuk mengoptimalkan query MySQL](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [Apakah ada alasan bagus VARCHAR(255) sering digunakan?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [Bagaimana nilai null mempengaruhi kinerja?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [Log query lambat](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL adalah kumpulan item data yang direpresentasikan dalam **key-value store**, **document store**, **wide column store**, atau **graph database**. Data didenormalisasi, dan join biasanya dilakukan dalam kode aplikasi. Sebagian besar penyimpanan NoSQL tidak memiliki transaksi ACID yang sesungguhnya dan lebih memilih [konsistensi eventual](#eventual-consistency).

**BASE** sering digunakan untuk mendeskripsikan sifat database NoSQL. Dibandingkan dengan [Teorema CAP](#cap-theorem), BASE memilih ketersediaan daripada konsistensi.

* **Basically available** - sistem menjamin ketersediaan.
* **Soft state** - status sistem dapat berubah seiring waktu, bahkan tanpa input.
* **Eventual consistency** - sistem akan menjadi konsisten dalam jangka waktu tertentu, asalkan tidak menerima input selama periode tersebut.

Selain memilih antara [SQL atau NoSQL](#sql-or-nosql), penting untuk memahami tipe database NoSQL mana yang paling sesuai untuk kasus penggunaan Anda. Kita akan membahas **key-value stores**, **document stores**, **wide column stores**, dan **graph databases** pada bagian berikutnya.

#### Key-value store

> Abstraksi: hash table

Key-value store umumnya memungkinkan baca dan tulis O(1) dan sering didukung oleh memori atau SSD. Penyimpanan data dapat mempertahankan kunci dalam [urutan leksikografis](https://en.wikipedia.org/wiki/Lexicographical_order), memungkinkan pengambilan rentang kunci secara efisien. Key-value store dapat memungkinkan penyimpanan metadata bersama sebuah nilai.

Key-value store memberikan kinerja tinggi dan sering digunakan untuk model data sederhana atau data yang cepat berubah, seperti lapisan cache dalam memori. Karena hanya menawarkan operasi terbatas, kompleksitas akan berpindah ke lapisan aplikasi jika dibutuhkan operasi tambahan.

Key-value store adalah dasar bagi sistem yang lebih kompleks seperti document store, dan dalam beberapa kasus, graph database.

##### Sumber dan bacaan lanjutan: key-value store

* [Database key-value](https://en.wikipedia.org/wiki/Key-value_database)
* [Kekurangan key-value store](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Arsitektur Redis](http://qnimate.com/overview-of-redis-architecture/)
* [Arsitektur Memcached](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### Penyimpanan dokumen

> Abstraksi: penyimpanan key-value dengan dokumen sebagai nilai

Penyimpanan dokumen berpusat pada dokumen (XML, JSON, biner, dll), di mana dokumen menyimpan semua informasi untuk suatu objek tertentu. Penyimpanan dokumen menyediakan API atau bahasa query untuk melakukan query berdasarkan struktur internal dokumen itu sendiri. *Catatan, banyak penyimpanan key-value yang menyertakan fitur untuk bekerja dengan metadata nilai, sehingga memperburam batas antara kedua tipe penyimpanan ini.*

Berdasarkan implementasi dasarnya, dokumen diorganisasi berdasarkan koleksi, tag, metadata, atau direktori. Meskipun dokumen dapat diorganisasi atau dikelompokkan bersama, dokumen dapat memiliki field yang benar-benar berbeda satu sama lain.

Beberapa penyimpanan dokumen seperti [MongoDB](https://www.mongodb.com/mongodb-architecture) dan [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) juga menyediakan bahasa mirip SQL untuk melakukan query kompleks. [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) mendukung baik key-value maupun dokumen.

Penyimpanan dokumen memberikan fleksibilitas tinggi dan sering digunakan untuk data yang kadang berubah.

##### Sumber dan bacaan lebih lanjut: penyimpanan dokumen

* [Database berorientasi dokumen](https://id.wikipedia.org/wiki/Document-oriented_database)
* [Arsitektur MongoDB](https://www.mongodb.com/mongodb-architecture)
* [Arsitektur CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Arsitektur Elasticsearch](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Wide column store

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>Sumber: SQL & NoSQL, sejarah singkat</a></i>
</p>

> Abstraksi: peta bersarang `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

Unit dasar data pada wide column store adalah kolom (pasangan nama/nilai). Kolom dapat dikelompokkan dalam column family (analog dengan tabel SQL). Super column family lebih lanjut mengelompokkan column family. Anda dapat mengakses setiap kolom secara independen dengan row key, dan kolom dengan row key yang sama membentuk sebuah baris. Setiap nilai mengandung timestamp untuk versi dan penyelesaian konflik.

Google memperkenalkan [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) sebagai wide column store pertama, yang mempengaruhi [HBase](https://www.edureka.co/blog/hbase-architecture/) open-source yang sering digunakan dalam ekosistem Hadoop, dan [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) dari Facebook. Penyimpanan seperti BigTable, HBase, dan Cassandra mempertahankan key dalam urutan leksikografis, memungkinkan pengambilan rentang key secara efisien.

Wide column store menawarkan ketersediaan tinggi dan skalabilitas tinggi. Mereka sering digunakan untuk set data yang sangat besar.

##### Sumber dan bacaan lebih lanjut: wide column store

* [SQL & NoSQL, sejarah singkat](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Arsitektur Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [Arsitektur HBase](https://www.edureka.co/blog/hbase-architecture/)
* [Arsitektur Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### Basis data graf

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>Sumber: Basis data graf</a></i>
</p>

> Abstraksi: graf

Dalam basis data graf, setiap node adalah sebuah record dan setiap arc adalah hubungan antara dua node. Basis data graf dioptimalkan untuk merepresentasikan hubungan kompleks dengan banyak kunci asing atau relasi banyak-ke-banyak.

Basis data graf menawarkan performa tinggi untuk model data dengan hubungan kompleks, seperti jejaring sosial. Mereka relatif baru dan belum banyak digunakan; mungkin lebih sulit untuk menemukan alat pengembangan dan sumber daya. Banyak graf hanya dapat diakses dengan [REST APIs](#representational-state-transfer-rest).

##### Sumber dan bacaan lanjutan: graf

* [Basis data graf](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### Sumber dan bacaan lanjutan: NoSQL

* [Penjelasan terminologi dasar](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [Basis data NoSQL: survei dan panduan pengambilan keputusan](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [Skalabilitas](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [Pengantar NoSQL](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [Pola-pola NoSQL](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL atau NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>Sumber: Transisi dari RDBMS ke NoSQL</a></i>
</p>

Alasan untuk **SQL**:

* Data terstruktur
* Skema ketat
* Data relasional
* Membutuhkan join kompleks
* Transaksi
* Pola yang jelas untuk skalabilitas
* Lebih mapan: pengembang, komunitas, kode, alat, dll
* Pencarian berdasarkan indeks sangat cepat

Alasan untuk **NoSQL**:

* Data semi-terstruktur
* Skema dinamis atau fleksibel
* Data non-relasional
* Tidak perlu join kompleks
* Menyimpan banyak TB (atau PB) data
* Beban kerja sangat intensif data
* Throughput sangat tinggi untuk IOPS

Contoh data yang cocok untuk NoSQL:

* Pengambilan data clickstream dan log yang cepat
* Data papan peringkat atau skor
* Data sementara, seperti keranjang belanja
* Tabel yang sering diakses ('panas')
* Tabel metadata/lookup

##### Sumber dan bacaan lebih lanjut: SQL atau NoSQL

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [Perbedaan SQL vs NoSQL](https://www.sitepoint.com/sql-vs-nosql-differences/)

## Cache

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Sumber: Pola desain sistem yang dapat diskalakan</a></i>
</p>

Caching meningkatkan waktu pemuatan halaman dan dapat mengurangi beban pada server dan basis data Anda. Dalam model ini, dispatcher akan terlebih dahulu memeriksa apakah permintaan sudah pernah dilakukan sebelumnya dan mencoba menemukan hasil sebelumnya untuk dikembalikan, guna menghemat eksekusi yang sebenarnya.

Basis data sering mendapat manfaat dari distribusi bacaan dan penulisan yang merata di seluruh partisinya. Item populer dapat mengacaukan distribusi, menyebabkan kemacetan. Menempatkan cache di depan basis data dapat membantu menyerap beban yang tidak merata dan lonjakan lalu lintas.

### Caching klien

Cache dapat ditempatkan di sisi klien (OS atau browser), [sisi server](#reverse-proxy-web-server), atau pada lapisan cache yang berbeda.

### Caching CDN

[CDN](#content-delivery-network) dianggap sebagai jenis cache.

### Caching server web

[Reverse proxy](#reverse-proxy-web-server) dan cache seperti [Varnish](https://www.varnish-cache.org/) dapat melayani konten statis dan dinamis secara langsung. Server web juga dapat melakukan cache permintaan, mengembalikan respons tanpa harus menghubungi server aplikasi.

### Caching basis data

Basis data Anda biasanya sudah menyertakan tingkat caching tertentu dalam konfigurasi default, dioptimalkan untuk kasus penggunaan umum. Menyesuaikan pengaturan ini untuk pola penggunaan spesifik dapat semakin meningkatkan performa.

### Caching aplikasi

Cache dalam memori seperti Memcached dan Redis adalah penyimpanan key-value antara aplikasi Anda dan penyimpanan data Anda. Karena data disimpan di RAM, kecepatannya jauh lebih tinggi dibandingkan basis data biasa yang menyimpan data di disk. RAM lebih terbatas daripada disk, sehingga algoritma [cache invalidation](https://id.wikipedia.org/wiki/Cache_algorithms) seperti [least recently used (LRU)](https://id.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)) dapat membantu menghapus entri 'dingin' dan menjaga data 'panas' tetap di RAM.

Redis memiliki fitur tambahan berikut:

* Opsi persistensi
* Struktur data bawaan seperti sorted sets dan lists

Ada beberapa level cache yang dapat digunakan dan terbagi dalam dua kategori umum: **kueri basis data** dan **objek**:

* Level baris
* Level kueri
* Objek serializable yang sudah terbentuk penuh
* HTML yang sudah dirender sepenuhnya

Secara umum, Anda sebaiknya menghindari caching berbasis file, karena hal ini membuat proses cloning dan auto-scaling menjadi lebih sulit.

### Caching di tingkat query database

Setiap kali Anda melakukan query ke database, hash query tersebut sebagai kunci dan simpan hasilnya ke cache. Pendekatan ini memiliki masalah terkait masa berlaku:

* Sulit menghapus hasil cache dengan query yang kompleks
* Jika satu data berubah seperti sel tabel, Anda harus menghapus semua query cache yang mungkin memuat sel yang berubah tersebut

### Caching di tingkat objek

Lihat data Anda sebagai sebuah objek, mirip dengan yang Anda lakukan pada kode aplikasi Anda. Biarkan aplikasi Anda merangkai dataset dari database ke dalam instance kelas atau struktur data:

* Hapus objek dari cache jika data dasarnya berubah
* Memungkinkan pemrosesan asinkron: worker merangkai objek dengan mengambil objek terbaru dari cache

Saran apa saja yang dapat di-cache:

* Sesi pengguna
* Halaman web yang telah dirender sepenuhnya
* Stream aktivitas
* Data grafik pengguna

### Kapan melakukan update cache

Karena Anda hanya dapat menyimpan sejumlah data terbatas di cache, Anda perlu menentukan strategi update cache mana yang paling cocok untuk kasus penggunaan Anda.

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Sumber: From cache to in-memory data grid</a></i>
</p>

Aplikasi bertanggung jawab untuk membaca dan menulis dari storage. Cache tidak berinteraksi langsung dengan storage. Aplikasi melakukan hal berikut:

* Mencari entri di cache, menghasilkan cache miss
* Memuat entri dari database
* Menambahkan entri ke cache
* Mengembalikan entri

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```
[Memcached](https://memcached.org/) umumnya digunakan dengan cara ini.

Pembacaan data berikutnya yang ditambahkan ke cache menjadi cepat. Cache-aside juga disebut sebagai lazy loading. Hanya data yang diminta yang di-cache, sehingga menghindari cache terisi oleh data yang tidak diminta.

##### Kekurangan: cache-aside

* Setiap cache miss menghasilkan tiga perjalanan, yang dapat menyebabkan penundaan yang terasa.
* Data bisa menjadi usang jika diperbarui di database. Masalah ini dapat diatasi dengan mengatur time-to-live (TTL) yang memaksa pembaruan entri cache, atau dengan menggunakan write-through.
* Ketika sebuah node gagal, node baru yang kosong akan menggantikan, sehingga meningkatkan latensi.

#### Write-through

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Sumber: Skalabilitas, ketersediaan, stabilitas, pola</a></i>
</p>

Aplikasi menggunakan cache sebagai tempat penyimpanan data utama, membaca dan menulis data ke sana, sementara cache bertanggung jawab untuk membaca dan menulis ke database:

* Aplikasi menambah/memperbarui entri di cache
* Cache secara sinkron menulis entri ke penyimpanan data
* Kembali

Kode aplikasi:


```python
set_user(12345, {"foo":"bar"})
```

Kode cache:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
Write-through adalah operasi yang lambat secara keseluruhan karena operasi penulisan, tetapi pembacaan berikutnya dari data yang baru saja ditulis menjadi cepat. Pengguna umumnya lebih toleran terhadap latensi saat memperbarui data dibandingkan saat membaca data. Data di cache tidak basi.

##### Kekurangan: write-through

* Ketika node baru dibuat karena kegagalan atau skalabilitas, node baru tersebut tidak akan melakukan cache pada entri sampai entri tersebut diperbarui di database. Cache-aside bersama dengan write-through dapat mengurangi masalah ini.
* Sebagian besar data yang ditulis mungkin tidak pernah dibaca, yang dapat diminimalkan dengan TTL.

#### Write-behind (write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Sumber: Scalability, availability, stability, patterns</a></i>
</p>

Pada write-behind, aplikasi melakukan hal berikut:

* Menambah/memperbarui entri di cache
* Menulis entri ke data store secara asinkron, meningkatkan performa penulisan

##### Kekurangan: write-behind

* Bisa terjadi kehilangan data jika cache down sebelum isinya masuk ke data store.
* Implementasi write-behind lebih kompleks dibandingkan cache-aside atau write-through.

#### Refresh-ahead

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Sumber: From cache to in-memory data grid</a></i>
</p>

Anda dapat mengonfigurasi cache untuk secara otomatis menyegarkan entri cache yang baru saja diakses sebelum masa kedaluwarsanya.

Refresh-ahead dapat menghasilkan latensi yang lebih rendah dibandingkan read-through jika cache dapat secara akurat memprediksi item mana yang kemungkinan akan dibutuhkan di masa depan.

##### Kekurangan: refresh-ahead


* Tidak secara akurat memprediksi item mana yang kemungkinan akan dibutuhkan di masa depan dapat menghasilkan kinerja yang lebih rendah daripada tanpa refresh-ahead.

### Kekurangan: cache

* Perlu menjaga konsistensi antara cache dan sumber kebenaran seperti database melalui [invalidasi cache](https://en.wikipedia.org/wiki/Cache_algorithms).
* Invalidasi cache merupakan masalah yang sulit, ada kompleksitas tambahan terkait kapan harus memperbarui cache.
* Perlu melakukan perubahan aplikasi seperti menambahkan Redis atau memcached.

### Sumber dan bacaan lebih lanjut

* [Dari cache ke in-memory data grid](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [Pola desain sistem yang skalabel](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [Pengantar arsitektur sistem untuk skala](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [Skalabilitas, ketersediaan, stabilitas, pola](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Skalabilitas](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [Strategi AWS ElastiCache](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [Wikipedia](https://en.wikipedia.org/wiki/Cache_(computing))

## Asinkronisme

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Sumber: Intro to architecting systems for scale</a></i>
</p>

Alur kerja asinkron membantu mengurangi waktu permintaan untuk operasi yang mahal yang seharusnya dilakukan secara in-line. Mereka juga dapat membantu dengan melakukan pekerjaan yang memakan waktu di muka, seperti agregasi data secara berkala.

### Message queues

Message queue menerima, menyimpan, dan mengirimkan pesan. Jika suatu operasi terlalu lambat untuk dilakukan secara in-line, Anda dapat menggunakan message queue dengan alur kerja berikut:

* Aplikasi mempublikasikan pekerjaan ke antrian, lalu memberi tahu pengguna tentang status pekerjaan
* Seorang pekerja mengambil pekerjaan dari antrian, memprosesnya, lalu memberi sinyal bahwa pekerjaan telah selesai

Pengguna tidak diblokir dan pekerjaan diproses di latar belakang. Selama waktu ini, klien mungkin secara opsional melakukan sedikit pemrosesan untuk membuatnya tampak seperti tugas telah selesai. Misalnya, jika memposting tweet, tweet bisa langsung muncul di timeline Anda, tetapi bisa saja membutuhkan waktu sebelum tweet Anda benar-benar dikirim ke semua pengikut Anda.

**[Redis](https://redis.io/)** berguna sebagai message broker sederhana namun pesan bisa hilang.

**[RabbitMQ](https://www.rabbitmq.com/)** populer tetapi mengharuskan Anda menyesuaikan dengan protokol 'AMQP' dan mengelola node Anda sendiri.
**[Amazon SQS](https://aws.amazon.com/sqs/)** dihosting namun dapat memiliki latensi tinggi dan kemungkinan pesan dikirim dua kali.

### Antrian tugas

Antrian tugas menerima tugas dan data terkait, menjalankannya, lalu mengirimkan hasilnya. Mereka dapat mendukung penjadwalan dan digunakan untuk menjalankan pekerjaan yang membutuhkan komputasi intensif di latar belakang.

**[Celery](https://docs.celeryproject.org/en/stable/)** mendukung penjadwalan dan utamanya mendukung bahasa python.

### Tekanan balik (Back pressure)

Jika antrian mulai tumbuh secara signifikan, ukuran antrian bisa lebih besar dari memori, yang mengakibatkan cache miss, pembacaan disk, dan kinerja yang semakin lambat. [Tekanan balik](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) dapat membantu dengan membatasi ukuran antrian, sehingga mempertahankan tingkat throughput tinggi dan waktu respons yang baik untuk pekerjaan yang sudah ada di antrian. Setelah antrian penuh, klien akan menerima server busy atau kode status HTTP 503 untuk mencoba lagi nanti. Klien dapat mencoba ulang permintaan di lain waktu, mungkin dengan [exponential backoff](https://en.wikipedia.org/wiki/Exponential_backoff).

### Kelemahan: asinkronisme

* Kasus penggunaan seperti perhitungan murah dan alur kerja realtime mungkin lebih cocok untuk operasi sinkron, karena penggunaan antrian dapat menambah penundaan dan kompleksitas.

### Sumber dan bacaan lebih lanjut

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [Apa perbedaan antara message queue dan task queue?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## Komunikasi

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>Sumber: model 7 lapisan OSI</a></i>
</p>

### Hypertext transfer protocol (HTTP)

HTTP adalah metode untuk mengenkode dan mengirimkan data antara klien dan server. Ini adalah protokol request/response: klien mengirim permintaan dan server mengirim respons dengan konten relevan dan info status penyelesaian tentang permintaan tersebut. HTTP bersifat mandiri, memungkinkan permintaan dan respons mengalir melalui banyak router dan server perantara yang melakukan load balancing, caching, enkripsi, dan kompresi.

Permintaan HTTP dasar terdiri dari kata kerja (metode) dan sumber daya (endpoint). Berikut adalah kata kerja HTTP yang umum:

| Verb | Deskripsi | Idempotent* | Aman | Dapat di-cache |


| GET | Membaca sebuah sumber daya | Ya | Ya | Ya |
| POST | Membuat sebuah sumber daya atau memicu proses yang menangani data | Tidak | Tidak | Ya jika respons berisi info kesegaran |
| PUT | Membuat atau mengganti sebuah sumber daya | Ya | Tidak | Tidak |
| PATCH | Memperbarui sebagian sumber daya | Tidak | Tidak | Ya jika respons berisi info kesegaran |
| DELETE | Menghapus sebuah sumber daya | Ya | Tidak | Tidak |

*Dapat dipanggil berkali-kali tanpa hasil yang berbeda.

HTTP adalah protokol lapisan aplikasi yang bergantung pada protokol tingkat bawah seperti **TCP** dan **UDP**.

#### Sumber dan bacaan lebih lanjut: HTTP

* [Apa itu HTTP?](https://www.nginx.com/resources/glossary/http/)
* [Perbedaan antara HTTP dan TCP](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [Perbedaan antara PUT dan PATCH](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### Protokol kontrol transmisi (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Sumber: How to make a multiplayer game</a></i>
</p>

TCP adalah protokol berorientasi koneksi di atas [jaringan IP](https://en.wikipedia.org/wiki/Internet_Protocol).  Koneksi dibuat dan diakhiri menggunakan [handshake](https://en.wikipedia.org/wiki/Handshaking).  Semua paket yang dikirim dijamin sampai ke tujuan dalam urutan asli dan tanpa korupsi melalui:

* Nomor urut dan [field checksum](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation) untuk setiap paket
* Paket [acknowledgement](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) dan retransmisi otomatis

Jika pengirim tidak menerima respons yang benar, maka paket akan dikirim ulang.  Jika terjadi beberapa kali timeout, koneksi akan diputus.  TCP juga menerapkan [flow control](https://en.wikipedia.org/wiki/Flow_control_(data)) dan [congestion control](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control).  Jaminan ini menyebabkan penundaan dan umumnya menghasilkan transmisi yang kurang efisien dibandingkan UDP.

Untuk memastikan throughput tinggi, server web dapat menjaga banyak koneksi TCP tetap terbuka, yang menyebabkan penggunaan memori tinggi.  Menjaga banyak koneksi terbuka antara thread server web dan misalnya, server [memcached](https://memcached.org/) bisa mahal.  [Connection pooling](https://en.wikipedia.org/wiki/Connection_pool) dapat membantu selain beralih ke UDP jika memungkinkan.

TCP bermanfaat untuk aplikasi yang membutuhkan keandalan tinggi namun tidak terlalu kritis waktu.  Beberapa contoh termasuk server web, info database, SMTP, FTP, dan SSH.

Gunakan TCP dibanding UDP saat:

* Anda membutuhkan semua data tiba utuh
* Anda ingin secara otomatis memperkirakan penggunaan throughput jaringan

### User datagram protocol (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Sumber: How to make a multiplayer game</a></i>
</p>

UDP bersifat connectionless. Datagram (analog dengan paket) hanya dijamin pada tingkat datagram. Datagram dapat tiba di tujuan dalam urutan yang salah atau bahkan tidak sampai sama sekali. UDP tidak mendukung kontrol kemacetan. Tanpa jaminan seperti pada TCP, UDP umumnya lebih efisien.

UDP dapat melakukan broadcast, mengirimkan datagram ke semua perangkat di subnet. Ini berguna untuk [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) karena klien belum menerima alamat IP, sehingga mencegah TCP melakukan streaming tanpa alamat IP.

UDP kurang andal tetapi bekerja dengan baik untuk kasus penggunaan waktu nyata seperti VoIP, video chat, streaming, dan permainan multipemain waktu nyata.

Gunakan UDP daripada TCP ketika:

* Anda membutuhkan latensi serendah mungkin
* Data yang terlambat lebih buruk daripada kehilangan data
* Anda ingin mengimplementasikan koreksi kesalahan sendiri

#### Sumber dan bacaan lebih lanjut: TCP dan UDP

* [Networking for game programming](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [Key differences between TCP and UDP protocols](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [Difference between TCP and UDP](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [Transmission control protocol](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [User datagram protocol](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [Scaling memcache at Facebook](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### Remote procedure call (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>Sumber: Crack the system design interview</a></i>
</p>

Dalam RPC, sebuah klien menyebabkan sebuah prosedur dijalankan pada ruang alamat yang berbeda, biasanya pada server jarak jauh. Prosedur tersebut dikodekan seolah-olah merupakan pemanggilan prosedur lokal, sehingga merangkum detail tentang bagaimana berkomunikasi dengan server dari program klien. Panggilan jarak jauh biasanya lebih lambat dan kurang andal dibandingkan panggilan lokal sehingga membantu untuk membedakan panggilan RPC dari panggilan lokal. Framework RPC populer meliputi [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/), dan [Avro](https://avro.apache.org/docs/current/).

RPC adalah protokol request-response:

* **Program klien** - Memanggil prosedur client stub. Parameter dimasukkan ke dalam stack seperti pemanggilan prosedur lokal.
* **Prosedur client stub** - Melakukan marshaling (pengemasan) id prosedur dan argumen ke dalam pesan permintaan.
* **Modul komunikasi klien** - OS mengirimkan pesan dari klien ke server.
* **Modul komunikasi server** - OS meneruskan paket yang masuk ke prosedur server stub.
* **Prosedur server stub** - Melakukan unmarshalling hasil, memanggil prosedur server yang sesuai dengan id prosedur dan memberikan argumen yang diberikan.
* Respons server mengulangi langkah-langkah di atas dengan urutan terbalik.

Contoh panggilan RPC:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```

RPC berfokus pada pemaparan perilaku. RPC sering digunakan untuk alasan performa dalam komunikasi internal, karena Anda dapat merancang panggilan native secara khusus agar lebih sesuai dengan kebutuhan Anda.

Pilihlah pustaka native (alias SDK) ketika:

* Anda mengetahui platform target Anda.
* Anda ingin mengontrol bagaimana "logika" Anda diakses.
* Anda ingin mengontrol bagaimana penanganan kesalahan terjadi di luar pustaka Anda.
* Performa dan pengalaman pengguna akhir adalah perhatian utama Anda.

HTTP API yang mengikuti **REST** cenderung lebih sering digunakan untuk API publik.

#### Kerugian: RPC

* Klien RPC menjadi sangat terkait erat dengan implementasi layanan.
* API baru harus didefinisikan untuk setiap operasi atau kasus penggunaan baru.
* Debug RPC bisa menjadi sulit.
* Anda mungkin tidak dapat memanfaatkan teknologi yang sudah ada secara langsung. Misalnya, mungkin diperlukan upaya tambahan untuk memastikan [panggilan RPC di-cache dengan benar](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) di server cache seperti [Squid](http://www.squid-cache.org/).

### Representational state transfer (REST)

REST adalah gaya arsitektur yang menerapkan model client/server di mana klien bertindak pada sekumpulan sumber daya yang dikelola oleh server. Server menyediakan representasi sumber daya dan tindakan yang dapat memanipulasi atau memperoleh representasi baru dari sumber daya. Semua komunikasi harus bersifat stateless dan dapat di-cache.

Ada empat kualitas antarmuka RESTful:

* **Identifikasi sumber daya (URI dalam HTTP)** - gunakan URI yang sama terlepas dari operasi apapun.
* **Perubahan dengan representasi (Verba dalam HTTP)** - gunakan verba, header, dan body.
* **Pesan kesalahan yang deskriptif (respons status dalam HTTP)** - Gunakan kode status, jangan membuat ulang standar yang sudah ada.
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (antarmuka HTML untuk HTTP)** - layanan web Anda harus sepenuhnya dapat diakses di browser.

Contoh panggilan REST:

```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST berfokus pada penyajian data. REST meminimalkan keterkaitan antara klien/server dan sering digunakan untuk API HTTP publik. REST menggunakan metode yang lebih umum dan seragam untuk menyajikan sumber daya melalui URI, [representasi melalui header](https://github.com/for-GET/know-your-http-well/blob/master/headers.md), dan aksi melalui kata kerja seperti GET, POST, PUT, DELETE, dan PATCH. Karena bersifat stateless, REST sangat baik untuk penskalaan horizontal dan pemartisian.

#### Kekurangan: REST

* Karena REST berfokus pada penyajian data, mungkin tidak cocok jika sumber daya tidak secara alami terorganisir atau diakses dalam hierarki sederhana. Misalnya, mengembalikan semua catatan yang diperbarui dalam satu jam terakhir yang cocok dengan serangkaian event tertentu tidak mudah diekspresikan sebagai path. Dengan REST, hal ini kemungkinan diimplementasikan dengan kombinasi path URI, parameter query, dan mungkin body permintaan.
* REST biasanya mengandalkan beberapa kata kerja (GET, POST, PUT, DELETE, dan PATCH) yang kadang tidak sesuai dengan kasus penggunaan Anda. Misalnya, memindahkan dokumen kadaluarsa ke folder arsip mungkin tidak cocok dengan kata kerja tersebut.
* Mengambil sumber daya yang kompleks dengan hierarki bertingkat memerlukan beberapa perjalanan bolak-balik antara klien dan server untuk menampilkan satu tampilan, misalnya mengambil konten entri blog dan komentar pada entri tersebut. Untuk aplikasi mobile yang beroperasi dalam kondisi jaringan yang bervariasi, perjalanan bolak-balik ini sangat tidak diinginkan.
* Seiring waktu, lebih banyak field mungkin ditambahkan ke respons API dan klien lama akan menerima semua field data baru, bahkan yang tidak mereka butuhkan, sehingga membengkakkan ukuran payload dan menyebabkan latensi yang lebih tinggi.

### Perbandingan panggilan RPC dan REST

| Operasi | RPC | REST |
|---|---|---|
| Signup    | **POST** /signup | **POST** /persons |
| Resign    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| Baca data seseorang | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| Baca daftar item seseorang | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| Tambah item ke daftar item seseorang | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| Update item    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| Hapus item | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>Sumber: Do you really know why you prefer REST over RPC</a></i>
</p>

#### Sumber dan bacaan lanjut: REST dan RPC

* [Do you really know why you prefer REST over RPC](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [Kapan pendekatan RPC lebih sesuai daripada REST?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [Membantah mitos RPC dan REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [Apa saja kekurangan penggunaan REST](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Crack the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [Mengapa REST untuk penggunaan internal dan bukan RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## Keamanan

Bagian ini membutuhkan beberapa pembaruan. Pertimbangkan untuk [berkontribusi](#contributing)!

Keamanan adalah topik yang luas. Kecuali Anda memiliki pengalaman yang cukup, latar belakang keamanan, atau melamar posisi yang memerlukan pengetahuan keamanan, Anda mungkin hanya perlu mengetahui dasar-dasarnya:

* Enkripsi saat transit dan saat diam.
* Sanitasi semua masukan pengguna atau parameter masukan apa pun yang terbuka untuk pengguna guna mencegah [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) dan [SQL injection](https://en.wikipedia.org/wiki/SQL_injection).
* Gunakan query terparameter untuk mencegah SQL injection.
* Gunakan prinsip [hak akses paling minimal](https://en.wikipedia.org/wiki/Principle_of_least_privilege).

### Sumber dan bacaan lebih lanjut

* [Daftar periksa keamanan API](https://github.com/shieldfy/API-Security-Checklist)
* [Panduan keamanan untuk pengembang](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP top ten](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## Lampiran

Terkadang Anda akan diminta melakukan estimasi 'back-of-the-envelope'. Misalnya, Anda mungkin perlu menentukan berapa lama waktu yang dibutuhkan untuk menghasilkan 100 thumbnail gambar dari disk atau berapa banyak memori yang akan digunakan oleh sebuah struktur data. **Tabel pangkat dua** dan **Angka latensi yang harus diketahui setiap programmer** adalah referensi yang berguna.

### Tabel pangkat dua


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### Sumber dan bacaan lebih lanjut

* [Pangkat dua](https://id.wikipedia.org/wiki/Pangkat_dua)

### Angka latensi yang harus diketahui setiap programmer

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```

Metode praktis berdasarkan angka di atas:

* Membaca secara berurutan dari HDD pada 30 MB/s
* Membaca secara berurutan dari Ethernet 1 Gbps pada 100 MB/s
* Membaca secara berurutan dari SSD pada 1 GB/s
* Membaca secara berurutan dari memori utama pada 4 GB/s
* 6-7 perjalanan keliling dunia per detik
* 2.000 perjalanan bolak-balik per detik dalam satu pusat data

#### Visualisasi angka latensi

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### Sumber dan bacaan lanjutan

* [Angka latensi yang harus diketahui setiap programmer - 1](https://gist.github.com/jboner/2841832)
* [Angka latensi yang harus diketahui setiap programmer - 2](https://gist.github.com/hellerbarde/2843375)
* [Desain, pelajaran, dan saran dari membangun sistem terdistribusi besar](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [Saran Rekayasa Perangkat Lunak dari Membangun Sistem Terdistribusi Skala Besar](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### Pertanyaan tambahan wawancara desain sistem

> Pertanyaan umum wawancara desain sistem, dengan tautan ke sumber daya cara menyelesaikan masing-masing.

| Pertanyaan | Referensi |
|---|---|
| Desain layanan sinkronisasi file seperti Dropbox | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Desain mesin pencari seperti Google | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Desain perayap web yang skalabel seperti Google | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Desain Google docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Desain penyimpanan key-value seperti Redis | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Desain sistem cache seperti Memcached | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Desain sistem rekomendasi seperti Amazon | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| Desain sistem tinyurl seperti Bitly | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| Desain aplikasi chat seperti WhatsApp | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Desain sistem berbagi foto seperti Instagram | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Desain fungsi umpan berita Facebook | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Desain fungsi linimasa Facebook | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Desain fungsi chat Facebook | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |
| Rancang fungsi pencarian grafik seperti Facebook | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| Rancang jaringan pengiriman konten seperti CloudFlare | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| Rancang sistem topik trending seperti Twitter | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| Rancang sistem pembuatan ID acak | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| Kembalikan permintaan top k selama interval waktu | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| Rancang sistem yang melayani data dari beberapa pusat data | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| Rancang permainan kartu multipemain online | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| Rancang sistem garbage collection | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| Rancang pembatas laju API | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| Rancang Bursa Saham (seperti NASDAQ atau Binance) | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| Tambahkan pertanyaan desain sistem | [Kontribusi](#contributing) |

### Arsitektur dunia nyata

> Artikel tentang bagaimana sistem dunia nyata dirancang.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>Sumber: Timeline Twitter dalam skala besar</a></i>
</p>

**Jangan fokus pada detail teknis mendalam untuk artikel berikut, melainkan:**

* Identifikasi prinsip yang sama, teknologi umum, dan pola dalam artikel-artikel tersebut
* Pelajari masalah apa yang diselesaikan oleh setiap komponen, di mana berfungsi, di mana tidak
* Tinjau pelajaran yang didapat

|Tipe | Sistem | Referensi |
|---|---|---|
| Pemrosesan data | **MapReduce** - Pemrosesan data terdistribusi dari Google | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| Pemrosesan data | **Spark** - Pemrosesan data terdistribusi dari Databricks | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| Pemrosesan data | **Storm** - Pemrosesan data terdistribusi dari Twitter | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| Penyimpanan data | **Bigtable** - Database kolom terdistribusi dari Google | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| Penyimpanan data | **HBase** - Implementasi sumber terbuka dari Bigtable | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| Penyimpanan data | **Cassandra** - Database kolom terdistribusi dari Facebook | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| Penyimpanan data | **DynamoDB** - Database berorientasi dokumen dari Amazon | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| Penyimpanan data | **MongoDB** - Database berorientasi dokumen | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| Penyimpanan data | **Spanner** - Database terdistribusi global dari Google | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| Data store | **Memcached** - Sistem caching memori terdistribusi | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Data store | **Redis** - Sistem caching memori terdistribusi dengan persistensi dan tipe nilai | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| File system | **Google File System (GFS)** - Sistem file terdistribusi | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| File system | **Hadoop File System (HDFS)** - Implementasi open source dari GFS | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| Misc | **Chubby** - Layanan kunci untuk sistem terdistribusi yang longgar dari Google | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| Misc | **Dapper** - Infrastruktur pelacakan sistem terdistribusi | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| Misc | **Kafka** - Antrian pesan pub/sub dari LinkedIn | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| Misc | **Zookeeper** - Infrastruktur terpusat dan layanan yang memungkinkan sinkronisasi | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | Tambahkan sebuah arsitektur | [Contribute](#contributing) |

### Arsitektur Perusahaan

| Perusahaan | Referensi |
|---|---|
| Amazon | [Arsitektur Amazon](http://highscalability.com/amazon-architecture) |
| Cinchcast | [Memproduksi 1.500 jam audio setiap hari](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [Penambangan data real-time 120.000 tweet per detik](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Bagaimana kami menskalakan Dropbox](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [Beroperasi pada 100.000 duh nuh nuh per detik](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Arsitektur Google](http://highscalability.com/google-architecture) |
| Instagram | [14 juta pengguna, terabyte foto](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Apa yang mendukung Instagram](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Arsitektur siaran video langsung Justin.Tv](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Scaling memcached di Facebook](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Penyimpanan data terdistribusi Facebook untuk grafik sosial](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Penyimpanan foto Facebook](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Bagaimana Facebook Live Menyiarkan ke 800.000 Penonton Secara Bersamaan](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Arsitektur Flickr](http://highscalability.com/flickr-architecture) |
| Mailbox | [Dari 0 ke satu juta pengguna dalam 6 minggu](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Pandangan 360 Derajat Seluruh Stack Netflix](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: Apa yang Terjadi Ketika Anda Menekan Play?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [Dari 0 ke puluhan miliar tampilan halaman per bulan](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[18 juta pengunjung, pertumbuhan 10x, 12 karyawan](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [50 juta pengguna bulanan dan terus bertambah](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [Arsitektur PlentyOfFish](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [Bagaimana mereka menangani 1,3 miliar transaksi per hari](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Arsitektur Stack Overflow](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [40M pengunjung, 200M tampilan halaman dinamis, 30TB data](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [15 miliar tampilan halaman per bulan](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Membuat Twitter 10000 persen lebih cepat](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[Menyimpan 250 juta tweet per hari menggunakan MySQL](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[150M pengguna aktif, 300K QPS, 22 MB/S firehose](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[Timeline pada skala besar](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Big dan small data di Twitter](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Operasi di Twitter: scaling lebih dari 100 juta pengguna](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Bagaimana Twitter Menangani 3.000 Gambar Per Detik](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Bagaimana Uber menskalakan platform pasar real-time mereka](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Pelajaran dari scaling Uber ke 2000 engineer, 1000 layanan, dan 8000 repositori Git](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Arsitektur WhatsApp yang dibeli Facebook seharga $19 miliar](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [Skalabilitas YouTube](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[Arsitektur YouTube](http://highscalability.com/youtube-architecture) |

### Blog Teknik Perusahaan

> Arsitektur untuk perusahaan tempat Anda sedang wawancara.
>
> Pertanyaan yang Anda temui mungkin berasal dari domain yang sama.

* [Airbnb Engineering](http://nerds.airbnb.com/)
* [Atlassian Developers](https://developer.atlassian.com/blog/)
* [AWS Blog](https://aws.amazon.com/blogs/aws/)
* [Bitly Engineering Blog](http://word.bitly.com/)
* [Box Blogs](https://blog.box.com/blog/category/engineering)
* [Cloudera Developer Blog](http://blog.cloudera.com/)
* [Dropbox Tech Blog](https://tech.dropbox.com/)
* [Engineering at Quora](https://www.quora.com/q/quoraengineering)
* [Ebay Tech Blog](http://www.ebaytechblog.com/)
* [Evernote Tech Blog](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook Engineering](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare Engineering Blog](http://engineering.foursquare.com/)
* [GitHub Engineering Blog](https://github.blog/category/engineering)
* [Google Research Blog](http://googleresearch.blogspot.com/)
* [Groupon Engineering Blog](https://engineering.groupon.com/)
* [Heroku Engineering Blog](https://engineering.heroku.com/)
* [Hubspot Engineering Blog](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram Engineering](http://instagram-engineering.tumblr.com/)
* [Intel Software Blog](https://software.intel.com/en-us/blogs/)
* [Jane Street Tech Blog](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn Engineering](http://engineering.linkedin.com/blog)
* [Microsoft Engineering](https://engineering.microsoft.com/)
* [Microsoft Python Engineering](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix Tech Blog](http://techblog.netflix.com/)
* [Paypal Developer Blog](https://medium.com/paypal-engineering)
* [Pinterest Engineering Blog](https://medium.com/@Pinterest_Engineering)
* [Reddit Blog](http://www.redditblog.com/)
* [Salesforce Engineering Blog](https://developer.salesforce.com/blogs/engineering/)
* [Slack Engineering Blog](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe Engineering Blog](https://stripe.com/blog/engineering)
* [Twilio Engineering Blog](http://www.twilio.com/engineering)
* [Twitter Engineering](https://blog.twitter.com/engineering/)
* [Uber Engineering Blog](http://eng.uber.com/)
* [Yahoo Engineering Blog](http://yahooeng.tumblr.com/)
* [Yelp Engineering Blog](http://engineeringblog.yelp.com/)
* [Zynga Engineering Blog](https://www.zynga.com/blogs/engineering)

#### Sumber dan bacaan lebih lanjut

Ingin menambahkan blog? Untuk menghindari duplikasi pekerjaan, pertimbangkan untuk menambahkan blog perusahaan Anda ke repo berikut:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## Sedang dikembangkan

Tertarik menambahkan bagian atau membantu menyelesaikan bagian yang sedang berlangsung? [Kontribusi](#contributing)!

* Komputasi terdistribusi dengan MapReduce
* Consistent hashing
* Scatter gather
* [Kontribusi](#contributing)

## Kredit

Kredit dan sumber diberikan di seluruh repo ini.

Terima kasih khusus kepada:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## Info kontak

Silakan hubungi saya untuk mendiskusikan masalah, pertanyaan, atau komentar apa pun.

Informasi kontak saya dapat ditemukan di [Halaman GitHub saya](https://github.com/donnemartin).

## Lisensi

*Saya menyediakan kode dan sumber daya dalam repositori ini kepada Anda di bawah lisensi sumber terbuka. Karena ini adalah repositori pribadi saya, lisensi yang Anda terima untuk kode dan sumber daya saya berasal dari saya dan bukan dari pemberi kerja saya (Facebook).*

    Hak Cipta 2017 Donne Martin

    Creative Commons Attribution 4.0 International License (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---