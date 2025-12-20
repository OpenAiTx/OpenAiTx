
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pra-Rilis](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Lisensi: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Kompiler yang Didukung](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![Tanya DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![Unit Test](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Si Domba Hitam untuk Rekaman Penerbangan Anda.

## Tentang
Sky Dolly terhubung ke instance Flight Simulator 2020 yang sedang berjalan dan merekam berbagai variabel simulasi, untuk diputar ulang.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

Koneksi dilakukan melalui SimConnect, API standar yang diperkenalkan pada Flight Simulator X untuk terhubung dengan simulator penerbangan.

Juga lihat [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Fitur
- Rekam / Jeda / Putar
- Penerbangan formasi (beberapa pesawat, pemutaran ulang selama perekaman, "terbang dengan formasi", offset waktu)
- Laju sampel perekaman yang dapat diatur: tetap atau variabel ("auto")
- Kecepatan pemutaran ulang yang dapat disesuaikan ("slow motion", "timelapse"), pemutaran ulang berulang
- Variabel simulasi posisi, kecepatan, dan kontrol penerbangan dasar (ailerons, rudder, flaps, gears, ...) direkam
- Arsitektur plugin dengan berbagai plugin impor/ekspor (CSV, GPX, IGC, KML)
- Modul lokasi dengan lebih dari 100 lokasi default dan fungsi impor/ekspor
- Persistensi berbasis database (SQLite) ("logbook")

Tonton trailer rilis (preview) di [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Untuk video lainnya yang dibuat dengan Sky Dolly, silakan lihat [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Fitur baru dan yang akan datang terdapat di [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Penggunaan Dasar

- Mulai penerbangan
- Klik "Record" (tombol R)
- Anda dapat menjeda perekaman (tombol P)
- Hentikan perekaman (tombol R) dan klik "Play" (spasi)
- Sesuaikan kecepatan pemutaran ulang dan geser posisi pemutaran, bahkan saat pemutaran ulang
- Penerbangan yang direkam akan otomatis disimpan di "logbook"
- Pilih penerbangan di logbook dan tekan "Load" (atau klik dua kali pada baris) untuk memuat penerbangan yang telah disimpan

### Rekaman & Pemutaran Ulang Formasi

#### Perekaman

- Beralih ke modul "Formation" (tombol F2)
- Klik "Record" (tombol R)
- Setiap pesawat yang direkam ditambahkan ke penerbangan saat ini
- Saat pesawat yang sudah ada diputar ulang selama perekaman dengan tingkat sampel "auto", Anda masih dapat mengubah tingkat sampel perekaman

#### Posisi

- Pesawat terakhir yang direkam menjadi "user aircraft" (yang diikuti oleh kamera di simulator penerbangan)
- Pilih posisi relatif terhadap "user aircraft" saat ini sebelum merekam

#### Pemutaran Ulang

- Cukup klik "Play", "Pause" dan pindah di timeline, seperti pada penerbangan satu pesawat
- Ubah "user aircraft" (juga saat pemutaran ulang) untuk "berpindah dari kokpit ke kokpit"
- Ambil kendali atas "user aircraft" dengan memilih opsi "Take control" atau "Fly with Formation"

#### Mengelola Formasi

- Anda dapat menghapus pesawat tunggal dari penerbangan ("formation")
- Harus ada setidaknya satu pesawat per penerbangan, sehingga pesawat terakhir tidak dapat dihapus
- Tambahkan offset waktu ke pesawat yang dipilih ("sinkronisasi penerbangan formasi multipemain")
- Untuk memulai penerbangan baru dengan satu pesawat, kembali ke modul "Logbook" (tombol F1) dan klik "Record" (tombol R)

Mengapa Anda tidak mencobanya dengan salah satu ["Tell Tours"](https://github.com/till213/Tell-Tours) yang dipandu? :)

## Unduh

Buka [Releases](https://github.com/till213/SkyDolly/releases) dan unduh rilis terbaru.

Rilis (pra-)terbaru: **Sky Dolly 0.19.2**

Hitung dan bandingkan checksum Anda dengan [checksum SHA-256 yang dipublikasikan](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), untuk memverifikasi integritas salinan yang Anda unduh.

## Build

Lihat dokumentasi [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Proyek Terkait

- https://github.com/nguyenquyhy/Flight-Recorder - Aplikasi perekaman & pemutaran ulang penerbangan berbasis .Net
- https://github.com/saltysimulations/saltyreplay/ - Perekaman & pemutaran ulang dengan antarmuka pengguna web
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Merekam penerbangan dan menghasilkan pemutaran ulang Google Earth (format KML)
- https://github.com/Elephant42/FS_Tool - Alat sederhana yang memungkinkan untuk mengatur lokasi pesawat dan laju simulasi
- https://github.com/pyviator/msfs-geoshot - Mengambil tangkapan layar dan secara otomatis memberi "geotag"
- https://github.com/ijl20/msfs_logger_replay - Logger IGC dan pemutaran ulang (untuk FSX)
- https://joinfs.net/ - Memungkinkan sinkronisasi penerbangan multipemain di berbagai simulator penerbangan (MSFS, Prepar3D/FSX, XPlane). Juga menyediakan perekam penerbangan dengan rekaman formasi penerbangan ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote untuk FlyByWire's A32NX: kendali fungsionalitas kokpit FBW A320, menggunakan FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer menganalisis buku log MSFS dan memiliki ekspor CSV yang dapat dibaca oleh Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave secara otomatis (atau sesuai permintaan) menyimpan rencana penerbangan
- https://github.com/mracko/MSFS-Landing-Inspector - Menganalisis performa pendaratan Anda
- [Points of Interest (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Titik-titik menarik, bandara, dan kota 3D di Microsoft Flight Simulator.

## Sumber Daya Berguna Lainnya

- https://obsproject.com/ - Aplikasi tangkap layar / siaran
- https://sqlitebrowser.org/ - Menelusuri file basis data buku log Sky Dolly (*.sdlog), menjalankan kueri SQL Anda sendiri


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---