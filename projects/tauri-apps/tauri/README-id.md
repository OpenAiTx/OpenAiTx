<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Pendahuluan

Tauri adalah framework untuk membangun binary yang sangat kecil dan sangat cepat untuk semua platform desktop utama. Pengembang dapat mengintegrasikan framework front-end apa pun yang dikompilasi ke HTML, JS, dan CSS untuk membangun antarmuka pengguna mereka. Backend dari aplikasi adalah binary yang bersumber dari Rust dengan API yang dapat diakses oleh front-end.

Antarmuka pengguna dalam aplikasi Tauri saat ini memanfaatkan [`tao`](https://docs.rs/tao) sebagai library penanganan jendela di macOS, Windows, Linux, Android, dan iOS. Untuk merender aplikasi Anda, Tauri menggunakan [WRY](https://github.com/tauri-apps/wry), sebuah library yang menyediakan antarmuka terpadu ke webview sistem, memanfaatkan WKWebView di macOS & iOS, WebView2 di Windows, WebKitGTK di Linux, dan Android System WebView di Android.

Untuk mempelajari lebih lanjut tentang detail bagaimana semua komponen ini bekerja bersama, silakan lihat dokumen [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) ini.

## Memulai

Jika Anda tertarik untuk membuat aplikasi tauri, silakan kunjungi [situs dokumentasi](https://tauri.app).

Cara tercepat untuk memulai adalah dengan menginstal [prasyarat](https://v2.tauri.app/start/prerequisites/) untuk sistem Anda dan membuat proyek baru dengan [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Sebagai contoh dengan `npm`:

```sh
npm create tauri-app@latest
```

## Fitur

Daftar fitur Tauri meliputi, namun tidak terbatas pada:

- Bundler aplikasi bawaan untuk membuat bundle aplikasi dalam format seperti `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` dan installer Windows seperti `.exe` (melalui NSIS) dan `.msi` (melalui WiX).
- Updater mandiri bawaan (khusus desktop)
- Ikon system tray
- Notifikasi native
- Protokol WebView Native (tauri tidak membuat server http(s) localhost untuk melayani konten WebView)
- GitHub action untuk CI yang efisien
- Ekstensi VS Code

### Platform

Tauri saat ini mendukung pengembangan dan distribusi pada platform berikut:

| Platform   | Versi                                                                                                              |
| :--------- | :----------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 ke atas                                                                                                          |
| macOS      | 10.15 ke atas                                                                                                      |
| Linux      | webkit2gtk 4.0 untuk Tauri v1 (misalnya Ubuntu 18.04). webkit2gtk 4.1 untuk Tauri v2 (misalnya Ubuntu 22.04).      |
| iOS/iPadOS | 9 ke atas                                                                                                          |
| Android    | 7 ke atas (saat ini 8 ke atas)                                                                                     |

## Kontribusi

Sebelum Anda mulai mengerjakan sesuatu, sebaiknya cek dulu apakah sudah ada isu yang ada. Juga merupakan ide yang baik untuk mampir ke server Discord dan konfirmasi dengan tim apakah masuk akal atau jika seseorang sudah mengerjakannya.

Pastikan untuk membaca [Panduan Kontribusi](./.github/CONTRIBUTING.md) sebelum membuat pull request.

Terima kasih kepada semua yang telah berkontribusi pada Tauri!

### Dokumentasi

Dokumentasi dalam sistem multibahasa adalah tantangan tersendiri. Untuk itu, kami lebih memilih menggunakan dokumentasi inline di source code Rust & JS sebanyak mungkin. Lihat repository hosting untuk situs dokumentasi untuk informasi lebih lanjut: <https://github.com/tauri-apps/tauri-docs>

## Mitra

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Untuk daftar lengkap sponsor silakan kunjungi [website](https://tauri.app#sponsors) kami dan [Open Collective](https://opencollective.com/tauri).

## Organisasi

Tauri bertujuan menjadi kolektif berkelanjutan yang didasarkan pada prinsip yang membimbing [komunitas perangkat lunak bebas dan terbuka yang berkelanjutan](https://sfosc.org). Untuk tujuan ini, Tauri telah menjadi sebuah Program dalam [Commons Conservancy](https://commonsconservancy.org/), dan Anda dapat berkontribusi secara finansial melalui [Open Collective](https://opencollective.com/tauri).

## Lisensi

Kode: (c) 2015 - Sekarang - The Tauri Programme dalam The Commons Conservancy.

MIT atau MIT/Apache 2.0 jika berlaku.

Logo: CC-BY-NC-ND

- Desain Logo Tauri asli oleh [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) dan [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---