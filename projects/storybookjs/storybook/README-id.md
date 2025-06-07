<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Bangun komponen UI yang tahan banting dengan lebih cepat</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Status Build di CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="Lisensi" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Komunitas Storybook" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Akun Twitter Resmi" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook adalah workshop frontend untuk membangun komponen UI dan halaman secara terisolasi. Ribuan tim menggunakannya untuk pengembangan, pengujian, dan dokumentasi UI. Pelajari lebih lanjut di https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Lihat README untuk:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Daftar Isi

- 🚀 [Memulai](#getting-started)
- 📒 [Proyek](#projects)
  - 🛠 [Framework & Contoh yang Didukung](#supported-frameworks)
  - 🔗[Addon](#addons)
- 🏅 [Badge & Materi Presentasi](#badges--presentation-materials)
- 👥 [Komunitas](#community)
- 👏 [Kontribusi](#contributing)
  - 👨‍💻 [Script Pengembangan](#development-scripts)
  - 💸 [Sponsor](#sponsors)
  - 💵 [Backer](#backers)
- :memo: [Lisensi](#license)

## Memulai

Kunjungi [website Storybook](https://storybook.js.org) untuk mempelajari lebih lanjut tentang Storybook dan cara memulai.

### Dokumentasi

Dokumentasi dapat ditemukan di [situs dokumentasi Storybook](https://storybook.js.org/docs).

### Contoh

Lihat [Ensiklopedia Komponen](https://storybook.js.org/showcase) untuk melihat bagaimana tim-tim terdepan menggunakan Storybook.

Gunakan [storybook.new](https://storybook.new) untuk dengan cepat membuat proyek contoh di Stackblitz.

Storybook hadir dengan banyak [addon](https://storybook.js.org/docs/configure/user-interface/storybook-addons) untuk desain komponen, dokumentasi, pengujian, interaktivitas, dan lainnya. API Storybook memungkinkan konfigurasi dan ekstensi dengan berbagai cara. Bahkan telah diperluas untuk mendukung pengembangan React Native, Android, iOS, dan Flutter untuk mobile.

### Komunitas

Untuk bantuan tambahan, bagikan masalah Anda di [Diskusi GitHub repo](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Proyek

### Framework yang Didukung

| Renderer                                                       | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Addon

| Addon                                                                    |                                                                            |
| ------------------------------------------------------------------------ | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                | Uji aksesibilitas komponen untuk pengguna di Storybook                     |
| [actions](code/core/src/actions/)                                        | Catat aksi ketika pengguna berinteraksi dengan komponen di UI Storybook    |
| [backgrounds](code/core/src/backgrounds)                                 | Biarkan pengguna memilih latar belakang di UI Storybook                    |
| [cssresources](https://github.com/storybookjs/addon-cssresources)        | Tambah/hapus sumber daya CSS secara dinamis ke iframe komponen             |
| [design assets](https://github.com/storybookjs/addon-design-assets)      | Lihat gambar, video, dan tautan web di samping cerita Anda                 |
| [docs](code/addons/docs/)                                                | Tambahkan dokumentasi berkualitas tinggi ke komponen Anda                  |
| [events](https://github.com/storybookjs/addon-events)                    | Memicu event secara interaktif ke komponen yang merespon EventEmitter      |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics)| Melaporkan google analytics pada cerita                                    |
| [graphql](https://github.com/storybookjs/addon-graphql)                  | Query server GraphQL dalam cerita Storybook                                |
| [jest](code/addons/jest/)                                                | Lihat hasil unit test komponen di Storybook                                |
| [links](code/addons/links/)                                              | Buat tautan antar cerita                                                   |
| [measure](code/core/src/measure/)                                        | Inspeksi visual layout dan box model dalam UI Storybook                    |
| [outline](code/core/src/outline/)                                        | Debug visual layout dan alignment CSS dalam UI Storybook                   |
| [query params](https://github.com/storybookjs/addon-queryparams)         | Mock query params                                                          |
| [viewport](code/core/src/viewport/)                                      | Ubah ukuran tampilan dan layout untuk komponen responsif dengan Storybook  |

Lihat [Tabel Dukungan Addon / Framework](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Untuk terus meningkatkan pengalaman Anda, kami pada akhirnya harus menghapus atau menonaktifkan beberapa addon demi alat baru yang lebih baik.

Jika Anda menggunakan info/notes, kami sangat menyarankan Anda bermigrasi ke [docs](code/addons/docs/), dan [ini panduannya](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) untuk membantu Anda.

Jika Anda menggunakan contexts, kami sangat menyarankan Anda bermigrasi ke [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) dan [ini panduannya](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts).

Jika Anda menggunakan addon-storyshots, kami sangat menyarankan Anda bermigrasi ke Storybook [test-runner](https://github.com/storybookjs/test-runner) dan [ini panduannya](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide).

## Badge & Materi Presentasi

Kami punya badge! Tautkan ke contoh Storybook Anda yang live.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](tautan ke situs)
```

Jika Anda mencari materi untuk digunakan dalam presentasi Storybook Anda, seperti logo, video, dan warna yang kami gunakan, Anda dapat menemukannya di [repo brand kami](https://github.com/storybookjs/brand).

## Komunitas

- Tweet melalui [@storybookjs](https://x.com/storybookjs)
- Blog di [storybook.js.org](https://storybook.js.org/blog/) dan [Medium](https://medium.com/storybookjs)
- Chat di [Discord](https://discord.gg/storybook)
- Video dan streaming di [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Kontribusi

Kontribusi untuk Storybook selalu diterima!

- 📥 Pull request dan 🌟 Star selalu diterima.
- Baca [panduan kontribusi kami](CONTRIBUTING.md) untuk memulai,
  atau temukan kami di [Discord](https://discord.gg/storybook), kami akan meluangkan waktu membimbing Anda.

Mencari isu pertama untuk dikerjakan?

- Kami menandai isu dengan [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) jika menurut kami cocok untuk yang baru di basis kode atau OSS pada umumnya.
- [Bicara dengan kami](https://discord.gg/storybook), kami akan menemukan sesuatu yang cocok dengan keahlian dan minat belajar Anda.

### Script Pengembangan

Storybook diorganisir sebagai monorepo. Script yang berguna termasuk:

#### `yarn start`

> Menjalankan storybook template sandbox dengan cerita uji coba

#### `yarn task`

> Seperti di atas, tapi memberi Anda opsi untuk mengatur sandbox (mis. memilih framework lain)

#### `yarn lint`

> cek boolean apakah kode sesuai aturan linting - menggunakan remark & eslint

- `yarn lint:js` - akan memeriksa js
- `yarn lint:md` - akan memeriksa markdown + contoh kode
- `yarn lint:js --fix` - akan secara otomatis memperbaiki js

#### `yarn test`

> cek boolean apakah semua unit test lolos - menggunakan jest

- `yarn run test --core --watch` - akan menjalankan core test dalam mode watch

### Sponsor

Jadilah sponsor untuk menampilkan logo dan URL situs Anda di README kami di Github. \[[Jadi sponsor](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Backer

Dengan berdonasi secara rutin, Anda dapat mendukung kami dan pekerjaan kami. \[[Jadi backer](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Lisensi

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-akhir-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---