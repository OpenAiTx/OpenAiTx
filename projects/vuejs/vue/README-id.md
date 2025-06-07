## Vue 2 Telah Mencapai Akhir Masa Dukungan

**Anda sedang melihat repositori yang sudah tidak aktif lagi untuk Vue 2. Repositori yang masih aktif dan dipelihara untuk versi terbaru Vue adalah [vuejs/core](https://github.com/vuejs/core).**

Vue telah mencapai akhir masa dukungan (End of Life) pada 31 Desember 2023. Tidak lagi menerima fitur baru, pembaruan, atau perbaikan. Namun, Vue 2 masih tersedia di semua saluran distribusi yang ada (CDN, manajer paket, Github, dll).

Jika Anda memulai proyek baru, silakan mulai dengan versi terbaru Vue (3.x). Kami juga sangat menyarankan pengguna Vue 2 saat ini untuk melakukan upgrade ([panduan](https://v3-migration.vuejs.org/)), namun kami juga memahami bahwa tidak semua pengguna memiliki waktu atau insentif untuk melakukannya. Jika Anda harus tetap menggunakan Vue 2 namun juga memiliki kebutuhan kepatuhan atau keamanan terkait perangkat lunak yang tidak dipelihara, silakan lihat [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Sponsor

Vue.js adalah proyek open source berlisensi MIT dengan pengembangan yang sepenuhnya dimungkinkan oleh dukungan dari [backer](https://github.com/vuejs/core/blob/main/BACKERS.md) yang luar biasa ini. Jika Anda ingin bergabung, silakan pertimbangkan untuk [mensponsori pengembangan Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Sponsor Khusus</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Pengantar

Vue (dibaca `/vjuː/`, seperti "view") adalah **framework progresif** untuk membangun antarmuka pengguna. Framework ini dirancang sejak awal agar mudah diadopsi secara bertahap, dan dapat dengan mudah diskalakan antara pustaka dan framework tergantung pada kasus penggunaan. Terdiri dari pustaka inti yang mudah didekati yang hanya berfokus pada lapisan tampilan, serta ekosistem pustaka pendukung yang membantu Anda menangani kompleksitas pada aplikasi Single-Page yang besar.

#### Kompatibilitas Browser

Vue.js mendukung semua browser yang [mematuhi ES5](https://compat-table.github.io/compat-table/es5/) (IE8 dan di bawahnya tidak didukung).

## Ekosistem

| Proyek                | Status                                                       | Deskripsi                                               |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Routing aplikasi single-page                            |
| [vuex]                | [![vuex-status]][vuex-package]                               | Manajemen state skala besar                             |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Pembuatan proyek secara otomatis                        |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Loader untuk Single File Component (`*.vue` file) pada webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Dukungan rendering sisi server                          |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Dekorator TypeScript untuk API berbasis kelas           |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Integrasi RxJS                                          |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Ekstensi DevTools untuk browser                         |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Dokumentasi

Untuk melihat [contoh langsung](https://v2.vuejs.org/v2/examples/) dan dokumentasi, kunjungi [vuejs.org](https://v2.vuejs.org).

## Pertanyaan

Untuk pertanyaan dan dukungan silakan gunakan [forum resmi](https://forum.vuejs.org) atau [chat komunitas](https://chat.vuejs.org/). Daftar issue pada repo ini **khusus** untuk pelaporan bug dan permintaan fitur.

## Masalah (Issues)

Pastikan untuk membaca [Daftar Periksa Pelaporan Masalah](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) sebelum membuka masalah (issue). Masalah yang tidak sesuai dengan pedoman dapat segera ditutup.

## Catatan Perubahan

Perubahan detail untuk setiap rilis didokumentasikan di [catatan rilis](https://github.com/vuejs/vue/releases).

## Tetap Terhubung

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Papan Lowongan Kerja](https://vuejobs.com/?ref=vuejs)

## Kontribusi

Pastikan untuk membaca [Panduan Kontribusi](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) sebelum membuat pull request. Jika Anda memiliki proyek/komponen/alatan terkait Vue, tambahkan melalui pull request ke [daftar terkurasi ini](https://github.com/vuejs/awesome-vue)!

Terima kasih kepada semua yang telah berkontribusi pada Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Lisensi

[MIT](https://opensource.org/licenses/MIT)

Hak Cipta (c) 2013-sekarang, Yuxi (Evan) You

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---