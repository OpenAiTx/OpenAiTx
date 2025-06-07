[![Logo Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Status Build GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Undangan Discord Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Terjemahan Tersedia: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Lihat dokumen ini dalam bahasa lain di proyek [Crowdin](https://crowdin.com/project/electron) kami.

Framework Electron memungkinkan Anda menulis aplikasi desktop lintas platform
menggunakan JavaScript, HTML, dan CSS. Electron berbasis pada [Node.js](https://nodejs.org/) dan
[Chromium](https://www.chromium.org) dan digunakan oleh
[Visual Studio Code](https://github.com/Microsoft/vscode/) dan banyak [aplikasi](https://electronjs.org/apps) lainnya.

Ikuti [@electronjs](https://twitter.com/electronjs) di Twitter untuk pengumuman
penting.

Proyek ini mengikuti [kode etik](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) Contributor Covenant.
Dengan berpartisipasi, Anda diharapkan untuk mematuhi kode ini. Silakan laporkan perilaku yang tidak dapat diterima ke [coc@electronjs.org](mailto:coc@electronjs.org).

## Instalasi

Untuk menginstal binary Electron yang sudah dibangun, gunakan [`npm`](https://docs.npmjs.com/).
Metode yang dianjurkan adalah menginstal Electron sebagai dependensi pengembangan di aplikasi Anda:

```sh
npm install electron --save-dev
```

Untuk opsi instalasi lain dan tips pemecahan masalah, lihat
[instalasi](docs/tutorial/installation.md). Untuk informasi tentang cara mengelola versi Electron di aplikasi Anda, lihat
[Penomoran versi Electron](docs/tutorial/electron-versioning.md).

## Dukungan Platform

Setiap rilis Electron menyediakan binary untuk macOS, Windows, dan Linux.

* macOS (Big Sur ke atas): Electron menyediakan binary Intel 64-bit dan Apple Silicon / ARM untuk macOS.
* Windows (Windows 10 ke atas): Electron menyediakan binary `ia32` (`x86`), `x64` (`amd64`), dan `arm64` untuk Windows. Dukungan Windows on ARM ditambahkan di Electron 5.0.8. Dukungan untuk Windows 7, 8, dan 8.1 telah [dihapus di Electron 23, sesuai dengan kebijakan penghentian Windows Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Binary Electron yang sudah dibangun dibuat di Ubuntu 20.04. Binary ini juga telah diverifikasi bekerja di:
  * Ubuntu 18.04 dan yang lebih baru
  * Fedora 32 dan yang lebih baru
  * Debian 10 dan yang lebih baru

## Electron Fiddle

Gunakan [`Electron Fiddle`](https://github.com/electron/fiddle)
untuk membangun, menjalankan, dan mengemas eksperimen kecil dengan Electron, melihat contoh kode untuk semua API Electron, serta
mencoba berbagai versi Electron. Alat ini dirancang untuk memudahkan awal perjalanan Anda dengan
Electron.

## Sumber Belajar Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Semua dokumentasi Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Alat untuk membangun, menjalankan, dan mengemas eksperimen kecil Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Contoh aplikasi awal yang dibuat oleh komunitas

## Penggunaan secara Programatis

Sebagian besar orang menggunakan Electron dari command line, tetapi jika Anda membutuhkan `electron` di dalam
**aplikasi Node** Anda (bukan aplikasi Electron Anda), maka akan mengembalikan path file ke
binary. Gunakan ini untuk menjalankan Electron dari skrip Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// akan mencetak sesuatu seperti /Users/maf/.../Electron
console.log(electron)

// menjalankan Electron
const child = proc.spawn(electron)
```

### Mirror

* [China](https://npmmirror.com/mirrors/electron/)

Lihat [Instruksi Instalasi Lanjutan](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) untuk mempelajari cara menggunakan mirror khusus.

## Terjemahan Dokumentasi

Kami melakukan crowdsourcing terjemahan dokumentasi melalui [Crowdin](https://crowdin.com/project/electron).
Saat ini kami menerima terjemahan untuk bahasa Tionghoa (Sederhana), Prancis, Jerman, Jepang, Portugis,
Rusia, dan Spanyol.

## Kontribusi

Jika Anda tertarik untuk melaporkan/memperbaiki masalah dan berkontribusi langsung ke basis kode, silakan lihat [CONTRIBUTING.md](CONTRIBUTING.md) untuk informasi lebih lanjut tentang apa yang kami cari dan bagaimana cara memulai.

## Komunitas

Informasi mengenai pelaporan bug, mendapatkan bantuan, menemukan alat pihak ketiga dan contoh aplikasi,
dan lainnya dapat ditemukan di [Halaman Komunitas](https://www.electronjs.org/community).

## Lisensi

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Saat menggunakan logo Electron, pastikan untuk mengikuti [Kebijakan Merek Dagang OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---