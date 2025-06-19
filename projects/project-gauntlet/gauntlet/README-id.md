# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Peluncur aplikasi lintas platform berbasis web dengan plugin berbasis React

> [!WARNING]
> Launcher ini dikembangkan oleh satu pengembang di waktu luangnya.
> Perubahan mungkin berlangsung lambat namun konsisten
>
> Kemungkinan akan ada perubahan besar yang akan didokumentasikan di [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Demo agak usang

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Fitur

- Berbasis Plugin
  - Plugin ditulis dalam TypeScript
  - API plugin yang luas
      - Membuat tampilan UI
      - Perintah satu kali (one-shot commands)
      - Menyediakan daftar perintah satu kali secara dinamis
      - Menampilkan konten "inline" secara cepat langsung di bawah bilah pencarian utama berdasarkan nilai di dalamnya
      - Mengambil konten dari dan menambah ke Clipboard
  - Plugin didistribusikan sebagai branch terpisah di repositori Git, artinya distribusi plugin tidak memerlukan server pusat apa pun
  - ID Plugin hanyalah URL Repositori Git
  - UI plugin berbasis [React](https://github.com/facebook/react)
    - Diimplementasikan menggunakan React Reconciler kustom (tanpa Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno memungkinkan sandbox kode plugin JavaScript untuk keamanan yang lebih baik
    - Plugin diharuskan secara eksplisit menentukan izin apa saja yang mereka butuhkan untuk berfungsi
    - Node.js digunakan untuk menjalankan tooling plugin, namun sebagai pengembang plugin Anda selalu menulis kode yang berjalan di Deno
- Dirancang dengan pemikiran lintas platform sejak awal
- Perintah dan Tampilan dapat dijalankan/dibuka menggunakan shortcut global kustom
- Alias pencarian kustom dapat diberikan ke Perintah atau Tampilan
- Dukungan tema kustom
- Fungsionalitas bawaan disediakan oleh plugin bundle
  - Aplikasi: menampilkan aplikasi yang terpasang di sistem dalam hasil pencarian
    - Plugin juga melacak jendela dan aplikasi mana yang mereka miliki, jadi membuka aplikasi yang sudah terbuka secara default akan membawa jendela yang telah dibuat sebelumnya
      - Tidak semua sistem didukung saat ini. Lihat [dukungan fitur](https://gauntlet.sh/docs/feature-support)
  - Kalkulator: menampilkan hasil operasi matematika langsung di bawah bilah pencarian utama
    - Termasuk konversi mata uang menggunakan kurs
    - Didukung oleh [Numbat](https://github.com/sharkdp/numbat)
- Pengurutan hasil pencarian berbasis frekuensi dan waktu terbaru (frecency)
   - Frecency adalah kombinasi antara frekuensi dan waktu terbaru penggunaan
   - Semakin sering item digunakan, semakin tinggi posisinya di daftar hasil, namun item yang sering digunakan di masa lalu akan berada di bawah item yang baru-baru ini sering digunakan
   - Hasil dicocokkan per kata menggunakan substring

##### Dukungan OS

##### Resmi
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Usaha Terbaik
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland belum didukung, lihat [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Mulai

### Instalasi Gauntlet

Lihat [Instalasi](https://gauntlet.sh/docs/installation)

### Shortcut Global

Jendela utama dapat dibuka menggunakan shortcut global atau perintah CLI:
- Shortcut Global (dapat diubah di Pengaturan)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - Shortcut global mungkin tidak didukung, lihat [dukungan fitur](https://gauntlet.sh/docs/feature-support)
    - Silakan gunakan perintah CLI, dan jalankan dengan cara khusus manajer jendela Anda
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- Perintah CLI
  - `gauntlet open`

### Instal Plugin

Plugin diinstal melalui UI Pengaturan. Gunakan url repositori Git dari plugin untuk menginstalnya, misalnya `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Buat plugin Anda sendiri

Lihat [Memulai pengembangan plugin](https://gauntlet.sh/docs/plugin-development/getting-started)

## Tema

Lihat [Theming](https://gauntlet.sh/docs/theming)

## Membangun Gauntlet

Anda akan membutuhkan:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (tidak digunakan oleh proyek secara langsung, namun dibutuhkan oleh sebuah dependensi)
- Di Linux: `libxkbcommon-dev` (catatan: nama bisa berbeda tergantung distribusi yang digunakan)

### Dev

Untuk membangun dev jalankan:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
Dalam mode dev (tanpa fitur "release") aplikasi hanya akan menggunakan direktori di dalam direktori proyek untuk menyimpan status atau cache, untuk menghindari mengacaukan instalasi global

### Belum dikemas

Untuk membangun binary rilis yang belum dikemas, jalankan:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Dikemas
Untuk membangun paket khusus OS, jalankan salah satu perintah berikut:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Namun rilis versi baru perlu dilakukan melalui GitHub Actions

## Kontribusi

Jika Anda ingin membantu membangun Gauntlet, Anda dapat melakukannya dengan berbagai cara, tidak hanya berkontribusi kode:
- Melaporkan bug atau masalah UI/UX
- Membuat plugin

Untuk masalah sederhana silakan buka issue atau PR dan tangani sendiri.
Untuk perubahan yang lebih signifikan silakan hubungi kreator di Discord (tautan undangan ada di bagian atas README) dan diskusikan terlebih dahulu.

Semua kontribusi sangat diterima.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---