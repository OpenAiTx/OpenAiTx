<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## Pendahuluan

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) adalah solusi front-end siap produksi untuk antarmuka admin. Ini berbasis pada [vue](https://github.com/vuejs/vue) dan menggunakan UI Toolkit [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) dikembangkan menggunakan stack terbaru dari vue dan memiliki solusi i18n bawaan, template aplikasi enterprise yang umum, serta banyak fitur keren lainnya. Proyek ini membantu Anda membangun Aplikasi Single-Page yang besar dan kompleks. Saya yakin apapun kebutuhan Anda, proyek ini akan sangat membantu.

- [Pratinjau](https://panjiachen.github.io/vue-element-admin)

- [Dokumentasi](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Donasi](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Pengguna domestik dapat mengakses pratinjau online di alamat ini

- Template dasar direkomendasikan menggunakan: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Desktop: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Kredit: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**Setelah versi `v4.1.0+`, branch master default tidak akan mendukung i18n. Silakan gunakan [Branch i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n), branch tersebut akan mengikuti update master**

**Versi saat ini adalah `v4.0+` dibangun menggunakan `vue-cli`. Jika Anda menemukan masalah, silakan buat [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new). Jika Anda ingin menggunakan versi lama, Anda bisa beralih ke branch [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0), versi tersebut tidak bergantung pada `vue-cli`**

**Proyek ini tidak mendukung browser versi lama (misal IE). Silakan tambahkan polyfill sendiri.**

## Persiapan

Anda perlu menginstal [node](https://nodejs.org/) dan [git](https://git-scm.com/) secara lokal. Proyek ini berbasis pada [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios), dan [element-ui](https://github.com/ElemeFE/element). Semua permintaan data disimulasikan menggunakan [Mock.js](https://github.com/nuysoft/Mock).
Memahami dan mempelajari pengetahuan ini sebelumnya akan sangat membantu penggunaan proyek ini.

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Sponsor

Jadilah sponsor dan dapatkan logo Anda di README kami di GitHub dengan tautan ke situs Anda. [[Jadi sponsor]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Dapatkan backend Java untuk Vue admin dengan diskon 20% seharga $39 gunakan kode kupon SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Template Dashboard Admin yang dibuat dengan Vue, React, dan Angular.</p>

## Fitur

```
- Login / Logout

- Autentikasi Hak Akses
  - Hak akses halaman
  - Hak akses direktif
  - Halaman konfigurasi hak akses
  - Login dua langkah

- Build multi-lingkungan
  - Pengembangan (dev)
  - sit
  - Uji Tahap (stage)
  - Produksi (prod)

- Fitur Global
  - I18n
  - Tema dinamis ganda
  - Sidebar dinamis (mendukung routing multi-level)
  - Breadcrumb dinamis
  - Tags-view (Dukungan klik kanan pada halaman Tab)
  - Svg Sprite
  - Data Mock
  - Screenfull
  - Sidebar Responsif

- Editor
  - Rich Text Editor
  - Editor Markdown
  - Editor JSON

- Excel
  - Ekspor Excel
  - Upload Excel
  - Visualisasi Excel
  - Ekspor zip

- Tabel
  - Tabel Dinamis
  - Tabel Drag And Drop
  - Edit Tabel Inline

- Halaman Error
  - 401
  - 404

- Komponen
  - Upload Avatar
  - Back To Top
  - Drag Dialog
  - Drag Select
  - Drag Kanban
  - Drag List
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Contoh Lanjutan
- Log Error
- Dashboard
- Halaman Panduan
- ECharts
- Clipboard
- Markdown ke html
```

## Memulai

```bash
# clone proyek
git clone https://github.com/PanJiaChen/vue-element-admin.git

# masuk ke direktori proyek
cd vue-element-admin

# install dependency
npm install

# pengembangan
npm run dev
```

Ini akan otomatis membuka http://localhost:9527

## Build

```bash
# build untuk lingkungan pengujian
npm run build:stage

# build untuk lingkungan produksi
npm run build:prod
```

## Lanjutan

```bash
# pratinjau efek lingkungan rilis
npm run preview

# pratinjau efek lingkungan rilis + analisis sumber daya statis
npm run preview -- --report

# cek format kode
npm run lint

# cek format kode dan perbaiki otomatis
npm run lint -- --fix
```

Lihat [Dokumentasi](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) untuk informasi lebih lanjut

## Changelog

Perubahan detail untuk setiap rilis didokumentasikan di [catatan rilis](https://github.com/PanJiaChen/vue-element-admin/releases).

## Demo Online

[Pratinjau](https://panjiachen.github.io/vue-element-admin)

## Donasi

Jika Anda merasa proyek ini bermanfaat, Anda dapat membelikan penulis segelas jus :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## Dukungan Browser

Browser modern dan Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 2 versi terakhir | 2 versi terakhir | 2 versi terakhir |

## Lisensi

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Hak Cipta (c) 2017-sekarang PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---