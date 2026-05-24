
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Beli Saya Kopi di ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Sebuah penjelajah file sederhana yang lahir karena saya ingin belajar bahasa Rust.
  <br>
  Aplikasi ini independen dari sistem operasi dan dioptimalkan untuk efisiensi.
</p>

<br/><br/>

Performa dicapai melalui ["jwalk"](https://crates.io/crates/jwalk/versions) dan ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver tidak menggunakan cache path untuk mengakses file dan folder, sehingga performa didapat dari Rust, kecepatan disk, dan kekuatan cpu.

⁉️ Perlu diingat bahwa perangkat lunak ini masih dalam tahap pengembangan dan akan mengandung bug!
<br/><br/>

# Tautan
- <a href="#basic-features">Fitur dasar</a>
- <a href="#advanced-features">Fitur lanjutan</a>
- <a href="#dependencies-if-not-working-instantly">Dependensi</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementasi FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Masalah yang diketahui</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">Antarmuka pengguna</a>

## Fitur dasar
- Navigasi melalui direktori seperti yang sudah Anda kenal
- Salin & Tempel, hapus, buat dan ganti nama file serta folder
- Beralih antara mode grid, daftar, dan miller-columns
- Tutup popup dengan esc
- Langsung lompat ke direktori dengan Ctrl / Cmd + G dengan memasukkan path
- Urutkan item dalam mode daftar berdasarkan ukuran, nama, atau terakhir diubah

## Fitur lanjutan
- Kompres file dan folder
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Ekstrak arsip
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navigasi ke direktori menggunakan pintasan LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Atur sendiri path-nya di pengaturan
- Buat file dengan F6
- Buat folder dengan F7
- Tampilan Dual-Pane
  - Cari file dengan F8
  - Salin elemen yang sedang dipilih ke panel lain dengan F5
  - Pindahkan elemen yang sedang dipilih ke panel lain dengan LShift + F5
- Seret dan lepas file ke dalam explorer untuk menyalinnya ke direktori saat ini
- Ganti nama banyak pilihan sekaligus dengan Ctrl / Cmd + LShift + M
  - Jalankan multi rename dengan Ctrl / Cmd + Return
- Pratinjau cepat file -> Pilih entri direktori dan tekan tombol spasi.
  - File yang didukung: semua file gambar (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Item lain akan menampilkan ubin kecil dengan beberapa informasi tentangnya. (path, ukuran, terakhir diubah)
- Navigasi instan -> Mulai ketik dan secara otomatis memfilter entri direktori sehingga terkadang <br/>
  jauh lebih cepat untuk menavigasi ke lokasi yang diinginkan

## Ketergantungan (Jika tidak langsung berfungsi)

<details>
<summary>Perluas untuk menampilkan</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arch
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Integrasi FTP (sshfs)
<details>
  <summary>Klik untuk menampilkan</summary>
  <br/>
  Ketergantungan (Perlu diinstal tambahan):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Belum didukung **_sekarang_** |

  ### Instalasi:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Dukungan Bahasa
- Inggris
  - Opsi untuk memilih antara bahasa akan segera hadir ...
</details>

## ⚠️ Masalah yang Diketahui:
- Fitur drag and drop keluar jendela saat ini tidak selalu berfungsi di linux
- Di windows Anda mungkin harus menginstal [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Hak akses pada ms-windows sedikit aneh
  - Anda mungkin harus menjalankan program sebagai administrator jika mengalami masalah untuk menyalin elemen atau hal serupa
- Bisa jadi ada masalah Anda perlu menginstal openssl1.1 di sistem linux, jika program tidak berjalan

## 📝 Daftar tugas:
- Banyak bahasa
- Favorit
- Akses layanan penyimpanan online (Google drive, dll.)

## Antarmuka pengguna

### Gaya daftar
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Gaya grid
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Tampilan kolom Miller
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Tampilan dua panel
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Cara berkontribusi
Siapkan mesin Anda untuk mengembangkan aplikasi tauri v1: [Prasyarat Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Setelah ini selesai cukup lakukan ```git clone https://github.com/RickyDane/CoDriver``` atau ```gh repo clone RickyDane/CoDriver``` di lokasi pada mesin Anda.
</br></br>
Anda seharusnya bisa menjalankan ```cargo tauri dev``` di direktori root proyek ini untuk mulai membangun dan menjalankan CoDriver.
</br>
Pastikan tauri-cli sudah terpasang: ```cargo install tauri-cli```
</br>

## Penandatanganan rilis

Artefak rilis macOS harus ditandatangani dan dinotarikan agar Gatekeeper tidak melaporkan bahwa aplikasi yang diinstal rusak. Lihat [Penandatanganan dan notarization macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) untuk rahasia GitHub Actions yang diperlukan dan perintah verifikasi.

## Riwayat Bintang

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Grafik Riwayat Bintang" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Perangkat lunak pihak ketiga lainnya
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---