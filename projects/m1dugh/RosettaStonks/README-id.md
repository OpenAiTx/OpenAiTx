
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Pendahuluan](#introduction)
- [Instalasi](#install)
  - [Chrome](#chrome-based-browsers)
    - [Panduan Visual](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [Cara menggunakan](#how-to-use)
  - [Menambahkan waktu](#menambahkan-waktu)
    - [Fondasi](#menambahkan-waktu-di-fondasi)
    - [Pembangun kefasihan](#menambahkan-waktu-di-pembangun-kefasihan)
  - [Memvalidasi pelajaran](#memvalidasi-pelajaran)
    - [Fondasi](#memvalidasi-pelajaran-di-fondasi)
    - [Pembangun kefasihan](#memvalidasi-pelajaran-di-pembangun-kefasihan)

## Pendahuluan

RosettaStonks adalah ekstensi browser yang memungkinkan Anda menambah waktu dan memvalidasi
pelajaran di platform pembelajaran bahasa rosetta stone.

> RosettaStonks, dan rosetta stone Anda menjadi stonks.

## Instalasi

### Browser berbasis Chrome

➡️ **Baru pertama kali memasang ekstensi Chrome secara manual?** Lihat [Panduan Visual Langkah-demi-Langkah](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — termasuk tangkapan layar yang membantu! 🖼️

#### 1. Menggunakan Rilis GitHub

Untuk menggunakan ekstensi di browser berbasis chrome, Anda perlu:

- mengunduh file `rosettastonks-chrome.tar.gz` dari rilis terbaru di
  perangkat Anda.
- membuat folder bernama `rosettastonks` di mana saja di perangkat Anda untuk menyimpan
  ekstensi tersebut
- jalankan perintah berikut di folder `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Menggunakan manajer paket nix

Sebagai pengganti perintah sebelumnya, jika Anda berada di sistem nix **yang mendukung
flakes**, Anda dapat menjalankan perintah berikut, yang akan menginstal sebuah folder
di bawah path `/tmp/rosettastonks` dengan semua file.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Folder sekarang telah terpasang di bawah `/tmp/rosettastonks/`

**Bagian ini untuk semua pengguna, terlepas dari apakah Anda menggunakan metode github
atau metode nix.**

Di browser Anda:

- buka `chrome://extensions`
- aktifkan toggle `Developer mode`
- klik `Load unpacked`
- Pilih folder `rosettastonks` Anda

### Browser berbasis Firefox

- unduh file `rosettastonks.xpi` dari rilis terbaru.
- sebagai alternatif, jika menggunakan nix package manager dengan dukungan flake, Anda dapat menjalankan
  perintah berikut.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- buka `about:addons` di browser Anda
- klik tombol pengaturan dan pergi ke `Debug addons`.
- klik `Load Temporary Add-On`
- pilih file `/tmp/rosettastonks.xpi` di pemilih file.

_Peringatan: Metode ini hanya menginstal ekstensi secara sementara, artinya jika
Anda menutup browser, addon akan dihapus. Hal ini disebabkan oleh kebijakan firefox
yang tidak mengizinkan ekstensi yang belum diverifikasi untuk digunakan._

## Cara menggunakan

### Menambah waktu

#### Menambah waktu di Foundations

Untuk menambah waktu pada produk `foundations`, Anda perlu pergi ke latihan Anda, dan
klik abaikan atau selesaikan setidaknya satu pertanyaan. Setelah itu dilakukan, kolom waktu
akan muncul di halaman ekstensi di mana Anda dapat menambahkan waktu Anda.

#### Menambah waktu di Fluency builder

Untuk menambah waktu pada produk `fluency builder`, Anda perlu pergi ke latihan Anda, dan
menjawab setidaknya satu latihan. Jika kolom tambah waktu tidak muncul, artinya
tidak ada permintaan waktu yang tertangkap, Anda perlu menyegarkan pertanyaan dan menjawabnya
sekali lagi. Agar waktu dapat ditambahkan, Anda harus menyelesaikan pelajaran yang Anda gunakan untuk
menambah waktu.

_Catatan: Jika Anda tidak melihat kolom tambah waktu, artinya tindakan yang Anda lakukan
di situs web Rosetta stone tidak menghasilkan penambahan waktu yang sah, sehingga,
Anda harus menjawab pertanyaan lain._

### Validasi pelajaran

#### Validasi pelajaran di Foundations

Untuk memvalidasi pelajaran, seseorang harus memulai pelajaran, dan melalui semua
pertanyaan menggunakan tombol `abaikan` di kanan bawah. Setelah semua
pertanyaan telah dilihat, klik tombol `validasi pelajaran` untuk memvalidasi
pelajaran. Jika tidak, kembali ke halaman utama Anda, klik pada pelajaran yang sama, itu

harus menanyakan kepada Anda `Apakah Anda ingin melanjutkan atau mereset?`, Anda dapat memilih keduanya, dan
memvalidasi pelajaran lagi sampai berhasil. Seharusnya berhasil setelah maksimal 3/4 kali.

#### Memvalidasi pelajaran di Fluency builder

Saat ini, fitur validasi pelajaran tidak tersedia di rosetta stonks.

## Membangun aplikasi

### Membangun worker

Worker dapat dikemas menggunakan perintah berikut

```
$ deno task build:worker
```

Yang membuat file paket `/dist/worker.esm.js` yang merupakan file paket
untuk worker.

### Membangun frontend

Worker dapat dikemas menggunakan perintah berikut

```
$ deno task build:frontend
```

Yang membuat file paket `/dist/frontend.esm.js` yang merupakan file paket
untuk frontend.

## Memaketkan ekstensi

### Chrome

Untuk memaketkan ekstensi untuk chrome, perintah berikut dapat dijalankan:

```
$ make chrome
```

### Firefox

Untuk mengemas ekstensi untuk firefox, perintah berikut dapat dijalankan:

```
$ make firefox
```

Yang akan menghasilkan `rosettastonks.xpi`, file untuk ekstensi yang dapat
dimuat di firefox.

📸 Lebih suka visual? Lihat [Panduan Instalasi Chrome dengan Gambar](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---