## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!PERINGATAN]
>
> ## Dihentikan
>
> Create React App adalah salah satu alat utama untuk memulai proyek React pada tahun 2017-2021, namun sekarang berada dalam status jangka panjang dan kami menyarankan Anda untuk bermigrasi ke salah satu framework React yang didokumentasikan di [Mulai Proyek React Baru](https://react.dev/learn/start-a-new-react-project).
>
> Jika Anda mengikuti tutorial untuk belajar React, masih ada manfaat untuk melanjutkan tutorial Anda, tetapi kami tidak menyarankan memulai aplikasi produksi berdasarkan Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Buat aplikasi React tanpa konfigurasi build.

- [Membuat Aplikasi](#creating-an-app) – Cara membuat aplikasi baru.
- [Panduan Pengguna](https://facebook.github.io/create-react-app/) – Cara mengembangkan aplikasi yang di-bootstrapped dengan Create React App.

Create React App berjalan di macOS, Windows, dan Linux.<br>
Jika ada sesuatu yang tidak berfungsi, silakan [buat issue](https://github.com/facebook/create-react-app/issues/new).<br>
Jika Anda memiliki pertanyaan atau butuh bantuan, silakan bertanya di [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Ikhtisar Cepat

```sh
npx create-react-app my-app
cd my-app
npm start
```

Jika Anda sebelumnya telah menginstal `create-react-app` secara global melalui `npm install -g create-react-app`, kami menyarankan untuk mencopot paket tersebut menggunakan `npm uninstall -g create-react-app` atau `yarn global remove create-react-app` agar npx selalu menggunakan versi terbaru.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) sudah termasuk pada npm 5.2+ dan lebih tinggi, lihat [instruksi untuk npm versi lama](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Kemudian buka [http://localhost:3000/](http://localhost:3000/) untuk melihat aplikasi Anda.<br>
Ketika Anda siap untuk deploy ke produksi, buat bundle ter-minify dengan `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Mulai Langsung

Anda **tidak** perlu menginstal atau mengkonfigurasi alat seperti webpack atau Babel.<br>
Semua sudah dikonfigurasi dan disembunyikan sehingga Anda dapat fokus pada kode.

Buat proyek, dan Anda siap untuk mulai.

## Membuat Aplikasi

**Anda harus memiliki Node versi 14.0.0 atau lebih baru di mesin pengembangan lokal Anda** (tetapi tidak wajib di server). Kami menyarankan menggunakan versi LTS terbaru. Anda dapat menggunakan [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) atau [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) untuk mengganti versi Node antar proyek yang berbeda.

Untuk membuat aplikasi baru, Anda dapat memilih salah satu metode berikut:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) adalah alat package runner yang sudah termasuk pada npm 5.2+ dan lebih tinggi, lihat [instruksi untuk npm versi lama](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` tersedia di npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) tersedia di Yarn 0.25+_

Ini akan membuat direktori bernama `my-app` di dalam folder saat ini.<br>
Di dalam direktori itu, akan dihasilkan struktur proyek awal dan menginstal dependensi transitif:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Tanpa konfigurasi atau struktur folder yang rumit, hanya file yang Anda perlukan untuk membangun aplikasi Anda.<br>
Setelah instalasi selesai, Anda dapat membuka folder proyek Anda:

```sh
cd my-app
```

Di dalam proyek yang baru dibuat, Anda dapat menjalankan beberapa perintah bawaan:

### `npm start` atau `yarn start`

Menjalankan aplikasi dalam mode pengembangan.<br>
Buka [http://localhost:3000](http://localhost:3000) untuk melihatnya di browser.

Halaman akan memuat ulang secara otomatis jika Anda melakukan perubahan pada kode.<br>
Anda akan melihat error build dan peringatan lint di konsol.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` atau `yarn test`

Menjalankan test watcher dalam mode interaktif.<br>
Secara default, menjalankan pengujian yang berhubungan dengan file yang diubah sejak commit terakhir.

[Baca lebih lanjut tentang pengujian.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` atau `yarn build`

Membangun aplikasi untuk produksi ke folder `build`.<br>
Secara benar membundel React dalam mode produksi dan mengoptimalkan build untuk performa terbaik.

Build sudah ter-minify dan nama file sudah termasuk hash.<br>

Aplikasi Anda siap untuk dideploy.

## Panduan Pengguna

Anda dapat menemukan instruksi terperinci tentang penggunaan Create React App dan banyak tips di [dokumentasinya](https://facebook.github.io/create-react-app/).

## Bagaimana Cara Update ke Versi Baru?

Silakan lihat [Panduan Pengguna](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) untuk ini dan informasi lainnya.

## Filosofi

- **Satu Dependency:** Hanya ada satu dependency build. Menggunakan webpack, Babel, ESLint, dan proyek hebat lainnya, tetapi memberikan pengalaman yang terpadu di atasnya.

- **Tanpa Konfigurasi:** Anda tidak perlu mengkonfigurasi apapun. Konfigurasi yang cukup baik untuk build pengembangan dan produksi sudah diurus untuk Anda sehingga Anda bisa fokus pada penulisan kode.

- **Tidak Terkunci:** Anda bisa "eject" ke setup kustom kapan saja. Jalankan satu perintah, dan semua konfigurasi serta dependency build akan dipindahkan langsung ke proyek Anda, sehingga Anda dapat melanjutkan dari titik terakhir.

## Apa Saja yang Disertakan?

Lingkungan Anda akan memiliki semua yang Anda butuhkan untuk membangun aplikasi React single-page modern:

- Dukungan sintaks React, JSX, ES6, TypeScript, dan Flow.
- Fitur bahasa di luar ES6 seperti object spread operator.
- CSS dengan autoprefix sehingga Anda tidak perlu `-webkit-` atau prefix lain.
- Runner unit test interaktif yang cepat dengan dukungan built-in untuk pelaporan coverage.
- Server pengembangan live yang memperingatkan kesalahan umum.
- Skrip build untuk membundel JS, CSS, dan gambar untuk produksi, dengan hash dan sourcemaps.
- [Service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) offline-first dan [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), memenuhi semua kriteria [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Catatan: Penggunaan service worker bersifat opt-in mulai `react-scripts@2.0.0` dan lebih tinggi_)
- Update tanpa repot untuk alat-alat di atas hanya dengan satu dependency.

Lihat [panduan ini](https://github.com/nitishdayal/cra_closer_look) untuk gambaran bagaimana alat-alat ini saling terhubung.

Konsekuensinya adalah **alat-alat ini sudah dikonfigurasi untuk bekerja dengan cara tertentu**. Jika proyek Anda membutuhkan kustomisasi lebih, Anda dapat ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) dan mengkustomisasi, tetapi kemudian Anda harus memelihara konfigurasi tersebut.

## Alternatif Populer

Create React App sangat cocok untuk:

- **Belajar React** dalam lingkungan pengembangan yang nyaman dan kaya fitur.
- **Memulai aplikasi React single-page baru.**
- **Membuat contoh** dengan React untuk library dan komponen Anda.

Berikut beberapa kasus umum di mana Anda mungkin ingin mencoba alat lain:

- Jika Anda ingin **mencoba React** tanpa ratusan dependency build tool transitif, pertimbangkan [menggunakan satu file HTML atau sandbox online](https://reactjs.org/docs/getting-started.html#try-react).

- Jika Anda perlu **mengintegrasikan kode React dengan framework template sisi server** seperti Rails, Django, atau Symfony, atau jika Anda **tidak membangun aplikasi single-page**, pertimbangkan menggunakan [nwb](https://github.com/insin/nwb), atau [Neutrino](https://neutrino.js.org/) yang lebih fleksibel. Untuk Rails secara khusus, Anda dapat menggunakan [Rails Webpacker](https://github.com/rails/webpacker). Untuk Symfony, coba [Symfony's webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Jika Anda perlu **mempublikasikan komponen React**, [nwb](https://github.com/insin/nwb) juga [bisa melakukan ini](https://github.com/insin/nwb#react-components-and-libraries), begitu juga dengan [preset react-components Neutrino](https://neutrino.js.org/packages/react-components/).

- Jika Anda ingin melakukan **server rendering** dengan React dan Node.js, lihat [Next.js](https://nextjs.org/) atau [Razzle](https://github.com/jaredpalmer/razzle). Create React App agnostik terhadap backend, dan hanya menghasilkan bundle statis HTML/JS/CSS.

- Jika website Anda **sebagian besar statis** (misalnya, portofolio atau blog), pertimbangkan menggunakan [Gatsby](https://www.gatsbyjs.org/) atau [Next.js](https://nextjs.org/). Tidak seperti Create React App, Gatsby me-render website menjadi HTML pada waktu build. Next.js mendukung server rendering dan pre-rendering.

- Terakhir, jika Anda membutuhkan **kustomisasi lebih**, lihat [Neutrino](https://neutrino.js.org/) dan [preset React-nya](https://neutrino.js.org/packages/react/).

Semua alat di atas dapat bekerja dengan sedikit atau tanpa konfigurasi.

Jika Anda lebih suka mengkonfigurasi build sendiri, [ikuti panduan ini](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Mencari sesuatu yang serupa, tetapi untuk React Native?<br>
Coba [Expo CLI](https://github.com/expo/expo-cli).

## Berkontribusi

Kami akan sangat senang jika Anda membantu di `create-react-app`! Lihat [CONTRIBUTING.md](CONTRIBUTING.md) untuk informasi lebih lanjut tentang apa yang kami cari dan cara memulai.

## Mendukung Create React App

Create React App adalah proyek yang dipelihara komunitas dan semua kontributor adalah sukarelawan. Jika Anda ingin mendukung pengembangan Create React App di masa depan, silakan pertimbangkan untuk berdonasi ke [Open Collective kami](https://opencollective.com/create-react-app).

## Kredit

Proyek ini ada berkat semua orang yang [berkontribusi](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Terima kasih kepada [Netlify](https://www.netlify.com/) yang telah menjadi host dokumentasi kami.

## Penghargaan

Kami berterima kasih kepada penulis proyek-proyek terkait yang sudah ada atas ide dan kolaborasinya:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Lisensi

Create React App adalah perangkat lunak open source [dilisensikan sebagai MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Logo Create React App dilisensikan di bawah [Lisensi Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---