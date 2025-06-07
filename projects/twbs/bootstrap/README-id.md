<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Framework front-end yang ramping, intuitif, dan kuat untuk pengembangan web yang lebih cepat dan mudah.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Jelajahi dokumentasi Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Laporkan bug</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Ajukan fitur</a>
  ·
  <a href="https://themes.getbootstrap.com/">Tema</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Branch default kami digunakan untuk pengembangan rilis Bootstrap 5. Kunjungi [`v4-dev` branch](https://github.com/twbs/bootstrap/tree/v4-dev) untuk melihat readme, dokumentasi, dan kode sumber Bootstrap 4.


## Daftar Isi

- [Mulai cepat](#quick-start)
- [Status](#status)
- [Apa saja yang disertakan](#whats-included)
- [Bug dan permintaan fitur](#bugs-and-feature-requests)
- [Dokumentasi](#documentation)
- [Kontribusi](#contributing)
- [Komunitas](#community)
- [Versi](#versioning)
- [Pembuat](#creators)
- [Terima kasih](#thanks)
- [Hak cipta dan lisensi](#copyright-and-license)


## Mulai cepat

Beberapa opsi mulai cepat tersedia:

- [Unduh rilis terbaru](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clone repo: `git clone https://github.com/twbs/bootstrap.git`
- Instal dengan [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Instal dengan [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Instal dengan [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Instal dengan [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Instal dengan [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Baca [halaman Memulai](https://getbootstrap.com/docs/5.3/getting-started/introduction/) untuk informasi tentang isi framework, template, contoh, dan lainnya.


## Status

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Apa saja yang disertakan

Di dalam file unduhan Anda akan menemukan direktori dan file berikut, yang mengelompokkan aset umum secara logis dan menyediakan variasi yang sudah dikompilasi dan diminifikasi.

<details>
  <summary>Isi unduhan</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Kami menyediakan CSS dan JS yang sudah dikompilasi (`bootstrap.*`), serta CSS dan JS yang sudah dikompilasi dan diminifikasi (`bootstrap.min.*`). [Source maps](https://web.dev/articles/source-maps) (`bootstrap.*.map`) tersedia untuk digunakan dengan alat pengembang di beberapa browser tertentu. File JS bundle (`bootstrap.bundle.js` dan versi diminifikasi `bootstrap.bundle.min.js`) sudah menyertakan [Popper](https://popper.js.org/docs/v2/).


## Bug dan permintaan fitur

Memiliki bug atau permintaan fitur? Silakan baca terlebih dahulu [panduan issue](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) dan cari issue yang sudah ada atau sudah ditutup. Jika masalah atau ide Anda belum teratasi, [silakan buka issue baru](https://github.com/twbs/bootstrap/issues/new/choose).


## Dokumentasi

Dokumentasi Bootstrap, yang disertakan di repo ini di direktori root, dibangun dengan [Astro](https://astro.build/) dan dihosting secara publik di GitHub Pages di <https://getbootstrap.com/>. Dokumentasi juga dapat dijalankan secara lokal.

Pencarian dokumentasi didukung oleh [DocSearch dari Algolia](https://docsearch.algolia.com/).

### Menjalankan dokumentasi secara lokal

1. Jalankan `npm install` untuk memasang dependensi Node.js, termasuk Astro (pembangun situs).
2. Jalankan `npm run test` (atau skrip npm spesifik) untuk membangun ulang file CSS dan JavaScript terdistribusi, serta aset dokumentasi.
3. Dari direktori root `/bootstrap`, jalankan `npm run docs-serve` di command line.
4. Buka `http://localhost:9001/` di browser Anda, dan voilà.

Pelajari lebih lanjut tentang penggunaan Astro dengan membaca [dokumentasinya](https://docs.astro.build/en/getting-started/).

### Dokumentasi rilis sebelumnya

Anda dapat menemukan semua dokumentasi rilis sebelumnya di <https://getbootstrap.com/docs/versions/>.

[Rilis sebelumnya](https://github.com/twbs/bootstrap/releases) dan dokumentasinya juga tersedia untuk diunduh.


## Kontribusi

Silakan baca [panduan kontribusi](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) kami. Terdapat petunjuk untuk membuat issue, standar pengkodean, dan catatan pengembangan.

Selain itu, jika pull request Anda mengandung patch atau fitur JavaScript, Anda harus menyertakan [unit test yang relevan](https://github.com/twbs/bootstrap/tree/main/js/tests). Semua HTML dan CSS harus sesuai dengan [Panduan Kode](https://github.com/mdo/code-guide) yang dikelola oleh [Mark Otto](https://github.com/mdo).

Preferensi editor tersedia di [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) agar mudah digunakan di editor teks umum. Baca lebih lanjut dan unduh plugin di <https://editorconfig.org/>.


## Komunitas

Dapatkan pembaruan tentang pengembangan Bootstrap dan berbincang dengan pengelola proyek serta anggota komunitas.

- Ikuti [@getbootstrap di X](https://x.com/getbootstrap).
- Baca dan berlangganan [Blog Resmi Bootstrap](https://blog.getbootstrap.com/).
- Ajukan pertanyaan dan jelajahi [GitHub Discussions kami](https://github.com/twbs/bootstrap/discussions).
- Diskusikan, ajukan pertanyaan, dan lainnya di [Discord komunitas](https://discord.gg/bZUvakRU3M) atau [subreddit Bootstrap](https://www.reddit.com/r/bootstrap/).
- Ngobrol dengan sesama Bootstrapper di IRC. Di server `irc.libera.chat`, di channel `#bootstrap`.
- Bantuan implementasi dapat ditemukan di Stack Overflow (tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Developer sebaiknya menggunakan kata kunci `bootstrap` pada paket yang memodifikasi atau menambah fungsionalitas Bootstrap saat mendistribusikan melalui [npm](https://www.npmjs.com/browse/keyword/bootstrap) atau mekanisme distribusi serupa untuk visibilitas maksimal.


## Versi

Untuk transparansi dalam siklus rilis kami dan demi menjaga kompatibilitas mundur, Bootstrap dikelola di bawah [panduan Semantic Versioning](https://semver.org/). Terkadang kami melakukan kesalahan, tetapi kami mematuhi aturan tersebut sebisa mungkin.

Lihat [bagian Rilis di proyek GitHub kami](https://github.com/twbs/bootstrap/releases) untuk changelog setiap versi rilis Bootstrap. Pengumuman rilis di [blog resmi Bootstrap](https://blog.getbootstrap.com/) memuat ringkasan perubahan paling penting di setiap rilis.


## Pembuat

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Terima kasih

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Terima kasih kepada [BrowserStack](https://www.browserstack.com/) yang telah menyediakan infrastruktur sehingga kami dapat melakukan pengujian di browser nyata!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Terima kasih kepada [Netlify](https://www.netlify.com/) yang telah menyediakan Deploy Previews untuk kami!


## Sponsor

Dukung proyek ini dengan menjadi sponsor. Logo Anda akan muncul di sini dengan tautan ke situs web Anda. [[Jadi sponsor](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Pendukung

Terima kasih kepada semua pendukung kami! 🙏 [[Jadi pendukung](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Hak cipta dan lisensi

Kode dan dokumentasi hak cipta 2011-2025 [Bootstrap Authors](https://github.com/twbs/bootstrap/graphs/contributors). Kode dirilis di bawah [Lisensi MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Dokumentasi dirilis di bawah [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---