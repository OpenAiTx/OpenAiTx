## ***DISCLAIMER***

Saya **tidak bertanggung jawab** atas penyalahgunaan, penyalahgunaan, atau tindakan tidak etis apa pun yang dilakukan dengan alat atau metode yang tercantum di sini. **OSINT adalah teknik netral**—siapa saja bisa menggunakannya, dan siapa saja bisa menjadi target.

Catatan: Beberapa domain (misal, `exposed.lol`) mungkin sudah kedaluwarsa. Lihat daftar yang sudah dikurasi atau tautan alternatif yang disediakan.

## Saran

Buka sebuah [issue](https://github.com/airborne-commando/OPSEC-OSINT-Tools/issues) untuk saran atau masukan apa pun.

## Mengapa?

Orang-orang terlalu percaya pada internet. Di dunia saat ini, online dan offline hampir sama—kebenaran dan fiksi menjadi kabur. README ini dibuat untuk meningkatkan kesadaran. Clone, fork, remix, atau bahkan jadikan [Rentry](https://rentry.co/). Sebarkan pengetahuan sesuai keinginan Anda.

Bisakah Anda memprediksi perilaku seseorang dengan ini? Tidak sepenuhnya; manusia kadang tidak terduga.

# Alat OSINT/OPSEC

Daftar alat OSINT/OPSEC yang saya buat, fork, dan/atau gunakan. Pertama, mari kita bahas definisinya.

## Daftar Isi
1. [OPSEC](#operations-security-is-a-systematic-process-for)
   - [Cara OPSEC](#how-to-opsec)
      - [Smoke Screen dan misinfo](#Smoke-Screen-and-misinfo)
2. [Open Source Intelligence (OSINT)](#open-source-intelligence-osint)
3. [Siapa yang menggunakan OSINT?](#who-uses-open-source-intelligence-osint)
4. [Sumber OSINT](#sources-of-osint)
5. [Profiling OSINT](#digital-profiling-osint-profiling)
6. [Closed sourced](#closed-sourced-info)
7. [Contoh nyata OSINT](#real-world-examples-of-osint)
   - [Koordinasi Serangan Udara 2016](#in-the-year-2016-a-basket-weaving-image-board-used-osint-to-pay-some-supposed-terrorist-a-vist-from-a-govt-in-russia-resulting-in-airstrikes)
   - [Protes Shia LaBeouf 2017](#in-2017-shia-labeouf-had-a-protest-due-to-trumps-election-this-resulted-in-a-basket-weaving-image-board-using-osint-and-sky-patterns-to-figure-out-where-a-flag-is)
8. [Alat](#tools)
      - [Rekomendasi Toolchain](#toolchain-recommendations)
9. [Alat pencarian orang (di AS)](#people-search-tools-in-the-states)
10. [Grey literature](#grey-literature)
11. [Data yang bocor](#breached-data)
12. [Media Sosial](#social-media)
13. [Self OSINT](#toolchain-self-osint)
14. [Daftar Kurasi](#curated-lists)
16. [Alat Arsip](#archive-tools-that-ive-made)

## (Operations Security) adalah proses sistematis untuk:
1. Mengidentifikasi
2. Melindungi dan mengendalikan informasi penting

Ini adalah disiplin keamanan dan fungsi operasional yang melibatkan siklus berkelanjutan:
* Mengidentifikasi informasi kritis dan indikator (CII)
  * Informasi kritis dan indikator adalah komponen penting dari Operations Security yang bertujuan melindungi data sensitif yang dapat dieksploitasi oleh pihak lawan. Informasi Kritis mencakup informasi yang tidak diklasifikasikan atau dikendalikan tentang aktivitas, niat, kapabilitas, atau keterbatasan yang dapat digunakan lawan untuk mendapatkan keuntungan. Indikator adalah tindakan atau potongan informasi yang dapat diamati yang mengungkap detail penting tentang operasi, seperti perubahan prosedur mendadak atau peningkatan langkah keamanan. Melindungi informasi ini melibatkan identifikasi kerentanan dan penerapan tindakan pencegahan untuk mencegah pengungkapan tidak sah.
* Menganalisis potensi ancaman dan kerentanan
* Menilai risiko
* Mengembangkan langkah pencegahan untuk melindungi CII

 digunakan untuk melindungi informasi dan aktivitas dari pihak lawan. Ini membantu mengidentifikasi dan melindungi informasi sensitif yang dapat memberikan keuntungan bagi lawan. Prinsip OPSEC dapat diterapkan dalam kehidupan sehari-hari, seperti tidak membagikan informasi pribadi seperti tanggal lahir, alamat, email, nomor telepon.

**Contoh kesalahan OPSEC:**
* Terlalu banyak membagikan informasi pribadi online
   * [Chris Chan](https://www.youtube.com/playlist?list=PLABqEYq6H3vpCmsmyUnHnfMOeAnjBdSNm)
   * [suspectAGB](https://opsecfail.github.io/blog.html?filecase=suspectAGB)

* Membiarkan media sosial yang tidak digunakan tetap online
* Berinteraksi dengan target di media sosial
   * [w0rmer](https://opsecfail.github.io/blog.html?filecase=w0rmer)
   * [darknetdiaries](https://darknetdiaries.com/transcript/63/)

* [contoh opsec baik dan buruk serta beberapa osint.](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/examples.md)

OPSEC melengkapi disiplin keamanan lainnya, bukan menggantikan mereka.

### Cara OPSEC:

* **Gunakan layanan yang dapat menyembunyikan identitas Anda:**
---

| **Kategori**               | **Alat/Teknik**       | **Deskripsi**                                                                 | **Kelebihan**                                      | **Kekurangan/Batasan**                          |
|---------------------------|-------------------------|-------------------------------------------------------------------------------|---------------------------------------------|---------------------------------------------|
| **Pesan Terenkripsi**   | [Telegram](https://telegram.org/)                | Pesan berbasis cloud dengan E2E opsional ("Secret Chats")                      | Banyak digunakan, fitur lengkap               | Tidak E2E secara default; data disimpan di server; butuh nomor telepon |
|                            | [Simplex](https://simplex.chat/)                 | Tanpa identitas pengguna (bahkan tanpa nomor acak)                                 | Privasi metadata maksimal                   | Kurang ramah pengguna; jaringan lebih kecil         |
|                            | [Signal](https://signal.org/download/)                  | E2E terenkripsi secara default; minimal metadata                         | Standar emas privasi; tahan pengadilan | Butuh nomor telepon                       |
| **Jaringan Anonim**    | [Tor](https://www.torproject.org/)                     | Mengarahkan lalu lintas melalui node terenkripsi untuk menyembunyikan IP                             | Gratis; kuat terhadap pelacakan              | Lambat; sering CAPTCHA                     |
|                            | [Mullvad VPN](https://mullvad.net/en)             | VPN tanpa log, menerima pembayaran Monero (XMR)                                   | Privasi kuat; opsi pembayaran anonim  | VPN tidak bisa memperbaiki kebiasaan OPSEC buruk            |
| **Cryptocurrency**        | [Monero (XMR)](https://www.getmonero.org/)            | Cryptocurrency tidak dapat dilacak                                                   | Transaksi privat                       | Perlu mining/node lokal untuk anonimitas penuh + waktu |
| **Manajemen Identitas**   | Username Unik        | Gunakan kredensial berbeda tiap situs                                           | Mencegah serangan korelasi               | Sulit dikelola tanpa password manager   |
|                            | Word Spinners           | Parafrase teks untuk menghindari deteksi                                           | Menghindari plagiarisme/pelacakan identitas        | Bisa terdengar tidak alami                         |
|                            | Wajah AI               | Foto profil palsu (misal, ThisPersonDoesNotExist.com)                     | Menyembunyikan identitas asli                        | Bisa tampak tidak alami               |
| **Self-OSINT**           | Panduan Opt-Out          | Hapus data pribadi dari situs pencarian orang                                | Mengurangi jejak digital                 | Memakan waktu; tidak semua situs mengakomodir tanpa biaya |
| **Sumber OPSEC**      | Contoh OPSEC Buruk      | [Daftar kesalahan](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md) | Belajar dari kesalahan orang lain               | N/A                                        |
|                            | Praktik OPSEC Baik    | [Panduan](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md) | Tips praktis                          | Butuh disiplin                         |
| **Daftar Alat**           | Alat OPSEC             | [Daftar kurasi](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md) | Sumber lengkap                   | Mungkin butuh pembaruan                            |

---

### **Intisari**  
1. **Pesan**:  
   - **Signal** ATAU **Simplex** > **Telegram** untuk privasi.  

   - Ingat: E2E ≠ anonimitas total (metadata/kebiasaan tetap bisa bocor).


2. **Anonimitas**:  
   - **Tor** + **Mullvad VPN** + **XMR** = perlindungan berlapis.  
   - Hindari login ke akun pribadi saat memakai alat-alat ini.
   - Catatan: gunakan TOR dan Mullvad secara terpisah untuk anonimitas maksimal, gunakan [Virtual Machine](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#virtualization) untuk VPN dan TOR di mesin lain (atau host).

3. **Identitas**:  
   - **Username unik** + **wajah AI** + **word spinning** = lebih sulit dilacak.  

4. **Audit Diri**:  
   - Rutin **opt-out** dari broker data dan **OSINT terhadap diri sendiri**.  

5. **Mindset OPSEC**:  
   - Ikuti **[OPSEC baik](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md)** dan hindari **[kebiasaan buruk](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md)**.


**Catatan**:

TOR maksudnya Tor Browser, VPN seperti Virtual Private Network (Mullvad; atau VPN lain yang aman dan sudah diverifikasi oleh pakar privasi); XMR adalah Monero Coin, koin privasi.

Lihat Wikipedia jika bingung:
1. [VPN](https://en.wikipedia.org/wiki/Virtual_private_network)
   - [VPN service](https://en.wikipedia.org/wiki/VPN_service)
2. [TOR](https://en.wikipedia.org/wiki/Tor_(network))
3. [XMR](https://en.wikipedia.org/wiki/Monero)

--- 

### **Tips Pro**  
- **Trik Signal**: Daftar dengan nomor burner (misal, Google Voice).    
- **Mining Monero**: Jalankan node lokal untuk menghindari pelacakan oleh exchange.  

Untuk detail alat lengkap, lihat **[Daftar Alat OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md)**.

## Smoke Screen dan misinfo

Operasi smoke screen dalam konteks OSINT (Open Source Intelligence) merujuk pada tindakan sengaja untuk mengaburkan, menyesatkan, atau menutupi aktivitas, niat, atau identitas sebenarnya dari individu atau organisasi dari pelaku pengumpulan intelijen sumber terbuka. Istilah ini diambil dari taktik militer, di mana smoke screen digunakan untuk menyembunyikan pergerakan atau posisi dari pengamatan musuh. Dalam konteks siber dan intelijen, konsep ini diterapkan pada lingkungan digital dan informasi. Anda dapat membaca lebih lanjut [di sini](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/smokescreen-misinfo.md).

## Open Source Intelligence (OSINT)

**<div align="center">Apa itu, bagaimana digunakan, dan mengapa penting:</div>**

- OSINT adalah praktik mengumpulkan dan menganalisis informasi dari sumber publik untuk memenuhi kebutuhan intelijen tertentu. OSINT digunakan oleh lembaga pemerintah dan organisasi komersial untuk berbagai tujuan, termasuk:

  - Rekonsiliasi
  - Investigasi kejahatan siber
  - Analisis tren pasar
  - Analisis positioning merek
  - Mengukur risiko terhadap organisasi
  - Memahami pelaku, taktik, dan target
  - Mengumpulkan informasi real-time
  - Membuat keputusan yang tepat
  - Menerima peringatan dini ancaman potensial

## Siapa yang menggunakan Open-Source Intelligence (OSINT)?

- Lembaga Keamanan Nasional dan Intelijen, Penegak Hukum, Bisnis, Cybersecurity dan Grup Kejahatan Siber, Orang yang peduli privasi, LSM

  - CIA, Defense Intelligence Agency (DIA), dan Office of the Director of National Intelligence (ODNI) semua menggunakan OSINT.
  - OSINT dapat melindungi warga (pribadi atau lainnya) dari pencurian identitas, kekerasan seksual, dan penyalahgunaan.
  - OSINT dapat memantau pesaing, meneliti pasar baru, dan merencanakan aktivitas pemasaran.
  - OSINT dapat mengumpulkan intelijen tentang target spesifik online.
  - OSINT dapat memeriksa bagaimana pihak luar dapat menembus perangkat komputasi mereka.
  - OSINT dapat digunakan pada diri sendiri untuk mengamankan privasi.
  - Bellingcat, Center for Information Resilience, dan Oryx menggunakan OSINT.
  - Dan Anda! Ya, Anda bisa menggunakan OSINT.

## Sumber OSINT
OSINT dapat mengumpulkan informasi dari berbagai sumber, di antaranya:
- [Data pemerintah publik](https://www.opendatasoft.com/en/glossary/public-data/)

  - Data publik mengacu pada semua informasi yang tersedia secara bebas oleh instansi pemerintah atau kolektivitas lokal. Data ini berada di domain publik. Ini berbeda dengan open data, yang merupakan subset dari data publik. Open data adalah data terstruktur dan terawat dengan baik sehingga lebih mudah dipahami, diakses, dan dikonsumsi. Sebaliknya, data publik bisa sulit ditemukan, atau (dalam kasus instansi publik), memerlukan pengajuan Freedom of Information Act untuk memperolehnya.

- [Publikasi profesional dan akademik](https://www.lawinsider.com/dictionary/academic-publication)

  - Publikasi Akademik berarti publikasi abstrak, artikel, atau makalah di jurnal atau repositori elektronik, atau presentasinya di konferensi atau seminar.


- [Data komersial](https://www.lawinsider.com/dictionary/commercial-data)

  - Data Komersial berarti semua data dan informasi yang berkaitan dengan orang yang diidentifikasi atau dapat diidentifikasi (baik informasinya akurat atau tidak), sendiri atau dikombinasikan dengan informasi lain, yang merupakan pelanggan aktual atau potensial, atau konsumen produk yang ditawarkan oleh Bisnis VS atau Bisnis L Brands, sebagaimana berlaku.

  - Data Komersial berarti semua data dan informasi yang berkaitan dengan orang yang diidentifikasi atau dapat diidentifikasi (baik informasinya akurat atau tidak), sendiri atau dikombinasikan dengan informasi lain, yang merupakan pelanggan aktual atau potensial, atau konsumen produk atau layanan yang ditawarkan oleh Bisnis LoyaltyOne dan/atau Bisnis ADS, sebagaimana berlaku.

  - Data Komersial berarti semua data yang dikumpulkan atau diproses oleh Entitas Penjual yang berkaitan dengan pelanggan Bisnis.

- [Grey literature](https://browse.welch.jhmi.edu/c.php?g=1195274)

  - Grey literature adalah "Informasi yang diproduksi di semua tingkat pemerintahan, akademik, bisnis, dan industri dalam format elektronik dan cetak yang tidak dikendalikan oleh penerbit komersial yaitu di mana penerbitan bukanlah aktivitas utama dari badan pembuatnya."
   
  - Grey literature dapat bermanfaat untuk riset Anda, tetapi menemukan sumbernya memerlukan taktik berbeda dibandingkan dengan bahan penelitian komersial. Ini karena banyak jenis grey literature tidak terindeks di alat penelitian umum seperti PubMed, CINAHL, Scopus, dll.

### Contoh nyata OSINT

## Pada tahun 2016, sebuah image board menggunakan OSINT untuk mengunjungi seorang terduga teroris oleh [pemerintah Rusia yang berujung pada serangan udara.](https://imgur.com/pol-helps-coordinate-airstrike-on-moderate-syrian-rebels-N7DwWP1)

- [Video penjelasan kejadian](https://www.youtube.com/watch?v=OR6epSP_Xlw)

  - Pada 2016, selama Perang Saudara Suriah yang kompleks, berbagai kelompok pemberontak—ada yang beritikad baik, ada yang jahat—berusaha menggulingkan Presiden Assad. Kekacauan memungkinkan kelompok teroris berkembang, mendorong intervensi Amerika Serikat dan Rusia, dengan AS mendukung pemberontak dan Rusia membantu Assad. Seorang anonim di board Syria General 4chan (SG) mengklaim kelompok pemberontak Suriah, Jaysh al-Izza, memposting video di YouTube yang memperlihatkan lokasi kamp rahasia mereka. Kelompok ini, terkait Al-Qaeda, dianggap sebagai target oleh pengguna 4chan. Salah satu pengguna 4chan, Ivan Sirenko, yang punya koneksi ke militer Rusia, menerima koordinat dari komunitas 4chan dan men-tweet ke Kementerian Pertahanan Rusia. Ini berujung pada serangan udara ke kamp tersebut. Dua bulan kemudian, kelompok pemberontak sama memposting video lain yang menunjukkan kamp pelatihan baru. Pengguna 4chan kembali melacak lokasi dengan landmark di video. Setelah verifikasi menyeluruh, mereka mengirim koordinat ke Ivan, yang lalu memfasilitasi serangan udara Rusia kedua.

UPDATE: Ternyata ini perang yang sangat kompleks yang diikuti 4chan, tetap saya tampilkan sebagai contoh utama; masalah utamanya adalah mereka membocorkan lokasi pelatihan mereka ke internet seperti orang bodoh.
Jadi, opsec buruk.

## Pada 2017, Shia LaBeouf melakukan protes karena terpilihnya Trump; ini berujung image board menggunakan OSINT dan [pola langit untuk menemukan lokasi bendera.](https://www.vice.com/en/article/4chan-does-first-good-thing-pulls-off-the-heist-of-the-century1/)

- Pada 2017, pengguna 4chan berhasil melacak dan mengganti bendera protes "He Will Not Divide Us" milik Shia LaBeouf. Hanya dengan rekaman live-stream bendera, mereka menganalisis pola penerbangan, posisi bintang, dan sebuah tweet untuk menemukan lokasi bendera di Greeneville, Tennessee. Seorang troll lokal lalu membunyikan klakson mobilnya sampai suara itu terdengar di live-stream, memetakan lokasi persisnya. Bendera pun diganti dengan topi Trump, menandai akhir operasi trolling ini.

## Digital profiling (OSINT profiling).

Profil digital dan analisis perilaku adalah teknik ampuh untuk memahami individu berdasarkan aktivitas online dan jejak digital mereka. Walaupun metode ini sering digunakan profesional, Anda pun bisa menerapkan prinsip dan proses yang sama dengan pendekatan terstruktur.

Baca lebih lanjut di [OSINT profiling](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/OSINT-profiling.md)

## Closed Sourced Info

- [HUMINT](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/HUMINT.md)

**HUMINT dapat dikumpulkan secara terbuka (misal, wawancara, debriefing, laporan diplomatik) atau secara diam-diam (misal, spionase, pengawasan rahasia).**

**Membeli dari broker data bisa dikategorikan closed source jika informasinya tidak tersedia secara bebas JIKA tidak direferensikan silang melalui [Daftar Kurasi](#curated-lists) ATAU [Toolchain](#toolchain-self-osint) untuk self OSINT**

## Alat

---

| **Kategori**               | **Alat**                  | **Tautan**                                                                 | **Fungsi**                                                                 | **Batasan/Catatan**                                                                 |
|----------------------------|--------------------------|-------------------------------------------------------------------------|---------------------------------------------------------------------------------|-------------------------------------------------------------------------------------|
| **Query Mesin Pencari**  | Google-FU                | [GitHub](https://github.com/airborne-commando/GoogleFU-improved)        | Google dorking tingkat lanjut untuk pencarian terarah                                  | Ada rate limit; bisa memicu CAPTCHA                                              |
| **Analisis Biometrik**     | Facecheck.ID             | [GitHub](https://github.com/vin3110/facecheck.id-results-extractor)     | Reverse image search melewati paywall                                        | Butuh Tampermonkey; hanya ekstrak link sumber                                   |
| **Pencarian Username/Email**  | Blackbird                | [GitHub](https://github.com/p1ngul1n0/blackbird)                       | Pencarian username/email cepat lintas platform                                      | Hanya CLI; ringan                                                               |
|                            | Crow (GUI for Blackbird) | [GitHub](https://github.com/airborne-commando/crow)                     | Versi GUI Blackbird                                                       | Fungsi sama dengan CLI                                                           |
|                            | Sherlock                 | [GitHub](https://github.com/sherlock-project/sherlock)                  | Pencarian username di 300+ situs                                | False positive (misal, Imgur); CLI                                            |
|                            | No-Shit-Sherlock (GUI)   | [GitHub](https://github.com/airborne-commando/no-shit-sherlock)         | GUI wrapper Sherlock                                                       | Mewarisi keterbatasan Sherlock                                                     |
|                            | Maigret                  | [GitHub](https://github.com/soxoj/maigret)                              | Cari keterkaitan username (fork Sherlock)                                     | Fokus pada pelacakan profil                                                         |
|                            | Maigret-Night (GUI)      | [GitHub](https://github.com/airborne-commando/maigret-night)            | GUI untuk Maigret                                                                | Sama dengan Maigret CLI                                                                 |
|                            | Holehe                   | [GitHub](https://github.com/megadose/holehe)                            | Cek email digunakan di situs apa saja                                                | Imgur false positive; CLI                                                    |
| **Kompromi Email**      | Hudson Rock Extractor    | [GitHub](https://github.com/airborne-commando/hudsonrock-search-extractor)| Pemeriksa breach email manual (Flask)                                     | Tidak otomatis; butuh input manual                                                |
| **Geolokasi**            | Google Maps              | [maps.google.com](https://maps.google.com/)                             | Menentukan lokasi/komparasi landmark                                           | Data publik saja; tanpa fitur OSINT lanjutan                                        |
| **OSINT Umum**      | OSINT Rocks              | [osint.rocks](https://osint.rocks/)                                     | Multi-tool: Hudson Rock, Holehe, GHunt (Gmail), pencarian telepon/domain/username  | Berbasis web; menggabungkan banyak alat                                 |

---

### **Intisari & Tips Pro**

1. **False Positive**:  
   - **Sherlock/Holehe**: Imgur sering hasil menyesatkan—verifikasi manual.  
   - **Facecheck.ID**: Ekstrak link saja; bandingkan dengan [Pimeyes (10 pencarian)](https://pimeyes.com/en) dsb.

2. **GUI vs. CLI**:  
   - **CLI (Blackbird, Sherlock, Maigret)**: Lebih cepat tapi butuh teknis.  
   - **GUI (Crow, No-Shit-Sherlock)**: Mudah untuk pemula; logika backend sama.

3. **Investigasi Email**:  
   - Gabungkan **Holehe** (deteksi akun) + **Hudson Rock Extractor** (data breach) untuk pemeriksaan menyeluruh; lihat [**Rekomendasi Toolchain**](#Toolchain-Recommendations).  
   - Untuk OSINT Gmail, pakai **GHunt** (via OSINT Rocks).

4. **Geolokasi**:  
   - Gunakan **Google Maps Street View** untuk verifikasi alamat/landmark dari alat lain (misal, ClustrMaps).

5. **Catatan OPSEC**:  
   - **Rate Limit**: Alat seperti Google-FU bisa diblok—pakai proxy/VPN.  
   - **Legalitas**: Hindari scraping data privat (misal, Facebook pro) tanpa izin.

6. **Analisis Biometrik**: Lengkapi analitik biometrik dengan:
 - faceonlive.com (limit 3/4 pencarian, mungkin butuh TOR)
 - lenso.ai

Setelah itu buka gambar di tab baru lalu simpan atau drag ke facecheck.id dan bandingkan (seperti langkah 1).

---

### **Rekomendasi Toolchain**
- **Pencarian Username Cepat**: Crow (GUI, untuk mendalam) → Maigret (GUI, mendalam) → Sherlock (CLI, mendalam).
- **Email Breach**: Have I Been Pwned → Pentester (gratisan) → OSINT Rocks (Hudson Rock/Holehe) → LOLArchiver.
- **Gambar**: Facecheck.ID → Pimeyes → lenso.ai → faceonlive
- **File**: Encrypted drive (LUKS) → veracrypt → keepassxc

Catatan Pentester: Pentester bisa kasih hasil gratis username dsb tapi dengan batas waktu, tidak perlu beli layanan jika Anda cerdas dan simpan hasil (snapshot).

Catatan: Untuk keepassxc sebaiknya pakai password kuat atau YubiKey (hardware key)
bisa juga buat database tambahan, satu mudah diingat; satu lagi database password hasil generate untuk file sensitif.

Untuk alat niche, lihat bagian [Daftar Kurasi](#curated-lists).

Pipeline dibahas [di sini](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#opsec-pipeline-for-secure-files)
    
## Alat pencarian orang (di AS):

**DISCLAIMER: Kebanyakan info email di situs ini berasal dari data breach lama; subjek di situs ini masih mungkin memakai email tersebut karena orang jarang mengganti email kecuali terjadi kompromi, TFA, atau spam/harrasment, dsb.**

---

| **Alat**               | **Pencarian Berdasarkan**                | **Mengembalikan**                              | **Catatan**                                                                 |
|------------------------|-----------------------------|------------------------------------------|---------------------------------------------------------------------------|
| **[FastPeopleSearch](https://www.fastpeoplesearch.com/)**   | Nama, Telepon, Alamat        | Umur, Alamat, Telepon, Email               | Gratis; data bisa kadaluarsa.                                               |
| **[That's Them](https://thatsthem.com/)**        | Nama, Email, IP, VIN, Telepon | IP, Alamat, Telepon, Email              | Data agregasi Intelius/Spokeo; beberapa hasil berbayar.                 |
| **[Nuwber](https://nuwber.com/)**            | Nama, Telepon, Email, Alamat | DOB, Alamat, Email, Telepon               | Laporan detail mungkin berbayar.                                    |
| **[IDCrawl](https://idcrawl.com/)**           | Nama, Username, Telepon, Email | Nama, Username, Telepon, Email           | Fokus pada username/media sosial.                                       |
| **[PeekYou](https://www.peekyou.com/)**           | Nama, Username, State       | Umur, Media Sosial, Email, Alamat     | Kuat untuk profiling media sosial.                                       |
| **[Webmii](https://webmii.com/)**            | Nama Depan + Belakang           | Media Sosial, Hasil Pencarian             | Ringan; scan profil publik web/sosial.                           |
| **[PublicRecords](https://www.publicrecords.onlinesearches.com/)**     | Nama, Alamat, State        | Nama, Alamat, Nomor Telepon sebagian             | Direktori gratis; redirect ke Intelius untuk detail berbayar.                  |
| **[ClustrMaps](https://clustrmaps.com/)**        | Nama, Alamat               | Alamat, Penghuni, Properti, Data IP  | Fokus geolokasi/demografi; bisa ada riwayat kepemilikan.      |
| **[fastbackgroundcheck](https://www.fastbackgroundcheck.com)** | Nama, Alamat, Nomor Telepon | Nama, Alamat, Nomor Telepon, Email | Klaim memindai miliaran record di [situsnya](https://www.fastbackgroundcheck.com/about) |

---

### **Pengamatan Utama**:
1. **Gratis vs. Berbayar**: Kebanyakan alat kasih info dasar gratis tapi upsell laporan lengkap (misal, PublicRecords → Intelius).
2. **Sumber Data**: Banyak yang pakai breach/publik record sama (email/telepon sering kadaluarsa tapi masih dipakai).
3. **Spesialisasi**:
   - *Media Sosial*: PeekYou, IDCrawl.
   - *Geolokasi*: ClustrMaps.
   - *Komprehensif*: FastPeopleSearch, Nuwber, fastbackgroundcheck.

**Disclaimer**: Akurasi bervariasi; user jarang update email kecuali dikompromi. Gunakan secara etis!

- Untuk alat tambahan lihat [Daftar Kurasi](#curated-lists)

## Grey literature

Gunakan situs ini; [jangan daftar](https://vote.gov/register), cek status pendaftaran pemilih. Mungkin perlu info lebih di beberapa negara bagian; yang lain perlu lebih sedikit.

Alat otomatis yang saya buat untuk [pa voter services](https://github.com/airborne-commando/voter-reg-status). Silakan fork untuk negara bagian lain.

## Data yang bocor:
---

| **Alat**               | **Pencarian Berdasarkan**       | **Mengembalikan**                              | **Batasan/Biaya**                          | **Catatan**                                                                 |
|------------------------|--------------------|------------------------------------------|-----------------------------------------------|---------------------------------------------------------------------------|
| **[Have I Been Pwned](https://haveibeenpwned.com/)**  | Email, Telepon       | Nama breach, tanggal, data bocor    | Gratis; tidak ada password/data mentah                   | Sumber tepercaya; alert untuk breach baru.                                  |
| **[BreachDirectory](https://breachdirectory.org/)**    | Email, Username    | Partial password hash (SHA-1, 4 digit awal), panjang | Gratis; tidak full password            | Untuk pengecekan credential stuffing.                                    |
| **[Breach.vip](https://Breach.vip)**         | Email, Username    | Leak Minecraft (username, IP) | Gratis; butuh login                          | Niche akun gaming; "memey" tapi fungsional.                        |
| **[LeakPeek](https://leakpeek.com/)**           | Email, Username    | Partial breach snippet (misal, domain)  | 5 pencarian gratis; bisa bypass Tor          | Plan berbayar untuk data penuh; hasil diobfuscasi.                             |
| **[LOLArchiver](https://osint.lolarchiver.com/)**        | Email, Username    | Database breach lengkap (email, password) | Berbayar saja                     | Untuk profesional OSINT; curated high-value leak.                        |
| **[Icebreaker](https://github.com/airborne-commando/ice-breaker)**         | File breach lokal | Parsing/analisa dataset breach besar    | Python/EXE; optimal <1000GB file      | Script demo disediakan; hati-hati ([Facebook 533M leak](https://github.com/davidfegyver/facebook-533m)).        |
| **[hashes.com](https://hashes.com/)**         | Hash (MD5, SHA-1, dst) | Password terdekripsi (kalau hash berhasil di-crack) | Tool gratis/berbayar                      | Untuk reverse hash dari breach.                               |
| **[pentester.com](https://pentester.com/)**          | Email, Username    | Detail breach lengkap (lebih dari HIBP)     | Gratis; tanpa Tor                           | Tidak resmi tapi luas; bisa mengandung data sensitif.                    |

---

### **Intisari**:  
1. **Gratis vs. Berbayar**:  
   - *Gratis*: HIBP, BreachDirectory, Pentester, Hashes.com.
   - *Gratis Terbatas*: LeakPeek (5 pencarian), Breach.vip (butuh login).
   - *Berbayar*: LOLArchiver, Plan LeakPeek.

2. **Spesialisasi**:  
   - *Password Recovery*: Hashes.com (decrypt hash), BreachDirectory (partial hash).
   - *Gaming Leak*: Breach.vip (Minecraft).
   - *Analisa Lokal*: Icebreaker (Python tool untuk dataset besar).

3. **Catatan Etika/Hukum**:  
   - Banyak alat hanya kasih **data sebagian** (misal, 4 digit awal password) demi etika.
   - Gunakan **Tor** dengan LeakPeek untuk bypass limit pencarian.
   - Jangan disalahgunakan: Beberapa alat (misal, Pentester) bisa mengungkap data sensitif.

4. **Untuk Dataset Besar**:  
   - [Icebreaker](https://github.com/airborne-commando/ice-breaker) + [Facebook 533M](https://github.com/davidfegyver/facebook-533m) (tanpa password) untuk analisa massal.

---

### **Sumber Tambahan**:  
- **Daftar Kurasi**: Lihat [Curated Lists](#curated-lists) untuk alat niche.
- **Demo Script**: [Icebreaker](https://github.com/airborne-commando/ice-breaker) ada demo untuk tes.

## media sosial
---

| **Platform**  | **Alat**               | **URL**                              | **Fungsi**                          | **Batasan/Catatan**                     |
|--------------|-----------------------|--------------------------------------|------------------------------------------|------------------------------------------|
| **Umum**  | Social Searcher       | [social-searcher.com](https://www.social-searcher.com/) | Cari di banyak platform sekaligus | Paket gratis terbatas |
| **Snapchat** | Snapchat Map          | [map.snapchat.com](https://map.snapchat.com/) | Lihat cerita lokasi publik Snapchat | Butuh akun Snapchat |
| **Instagram**| Dumpor               | [dumpor.com](https://dumpor.com/)    | Lihat profil/story anonim      | Mungkin ada rate limit |
| **Twitter**  | Sotwe                | [sotwe.com](https://www.sotwe.com/)  | Browsing Twitter anonim             | Tidak perlu login |
|              | Xcancel              | [xcancel.com](https://xcancel.com/)  | Alternatif viewer Twitter             | Antarmuka ringan |
|              | Nitter               | [nitter.net](https://nitter.net/)    | Front-end Twitter fokus privasi      | Hindari pelacakan Twitter |
| **Facebook** | Facebook Search      | [facebook.com/search](https://www.facebook.com/search/) | Alat pencarian Facebook asli | Terbatas tanpa login |
|              | WhoPostedWhat       | [whopostedwhat.com](https://www.whopostedwhat.com/) | Cari posting Facebook berdasar tanggal/keyword | Butuh query tepat, akun publik |
| **reddit**   | r00m101.com         | [r00m101](https://r00m101.com/)       | Info akun reddit aktif atau terhapus                                       | Bisa berbayar untuk cakupan penuh

---

### **Tips Pro & Workaround**

1. **Akun Facebook Privat**:
   - Cara 1: Buat akun palsu (sulit karena verifikasi Facebook)
   - Cara 2: Pakai *Inspect Element* browser → *Device Simulator* (atau HP) + direct URL
   - Selalu coba logout atau mode privat dulu

2. **Batasan LinkedIn**:
   - Jika profil tidak terbuka:
     - Tunggu 1-2 menit (ganti cookie/IP)
     - Buat akun basic (jangan mencurigakan)
   - HWID/IP tracking bisa blokir pencarian berulang

3. **Alternatif Twitter**:
   - Gunakan **Nitter**/**Xcancel** hindari rate limit/pelacakan
   - **Sotwe** tanpa login

4. **Instagram**:
   - **Dumpor** bisa melewati beberapa pengaturan privasi
   - **Pakai Cepat** https://dumpor.io/v/USERNAME ganti ``USERNAME`` dengan user target
   - **Tidak bisa untuk akun privat**

---

### **Intisari**
- **Anonimitas**: Alat seperti Nitter/Dumpor hindari pelacakan platform
- **Trik Mobile**: Simulasi perangkat mobile sering lebih efektif untuk konten terbatas
- **Kesabaran**: Beberapa platform (LinkedIn/Facebook) butuh waktu atau bikin akun baru

- Untuk alat tambahan lihat bagian Daftar Kurasi di bawah.

## Daftar Kurasi

- [Awesome OSINT](https://github.com/jivoi/awesome-osint) - daftar alat, blog, dan video OSINT terkurasi

- [OSINT Framework](https://osintframework.com/) - daftar alat yang lebih besar
  
- [OSINT Resources](https://sizeof.cat/post/osint-resources/) - Koleksi sumber OSINT yang lebih up to date (ada NSFW)

  - [Archive](https://archive.ph/rZZf0) 

- Wiki reddit dari [komunitas OSINT](https://www.reddit.com/r/OSINT/wiki/index/)

- Daftar media sosial, peta, domain, dll juga ada di [koleksi cipher387](https://github.com/cipher387/osint_stuff_tool_collection). 

**OPT OUT**

- [big ass list](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) untuk opt-out dan membandingkan info.

- [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html)

- [Results about you (google index)](https://myactivity.google.com/results-about-you) - Cek email Google; kunjungi situsnya dan coba opt-out di sana.

## Toolchain (self-OSINT):

Google dorks: `https://www.google.com/search?q= "first+last" "Street Address" "City state" "age"` -> [Results about you (google index)](https://myactivity.google.com/results-about-you) -> [big ass list](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) -> [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html) -> [People Search tools](https://github.com/airborne-commando/OPSEC-OSINT-Tools/tree/main?tab=readme-ov-file#people-search-tools-in-the-states)

**Catatan** 

[Results about you (google index)](https://myactivity.google.com/results-about-you) juga bisa dikirim email, jadi perhatikan saat membandingkan info, misal: Google akan temukan situs yang mengandung nama dan alamat Anda lalu minta hapus dari index. Sebelum mengajukan penghapusan di Google, hapus dulu info dari situs sumbernya. Google Dorking secara manual juga lebih aman dari flag Google sebagai bot.

Selain itu, melakukan google dorks manual tidak akan membuat Anda diflag oleh Google sebagai bot.

## Alat arsip buatan saya
 
- [link extractor and archive](https://github.com/airborne-commando/link-extractor-and-archive) memakai archive.ph - cocok untuk halaman web dasar. Butuh intervensi manual (edit teks FIND+REPLACE).

Alat tambahan:

- Untuk alat tambahan lihat daftar kurasi di atas

Donasi:

Jika Anda merasa ini bermanfaat silakan donasi ke alamat monero ini:

![mon](https://github.com/user-attachments/assets/f77ce530-5a5d-479d-bb47-481674c93f4c)

    8BPdcsLtA5iWLNTWvYzUVyTWtQkM62e8r7xqAuwjXTSC4RcoSWqpmtyLsMYvz3QNZtT1rbgPUnmVpMAudhxTn6zkRxUFcZN

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---