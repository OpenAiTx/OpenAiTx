<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Situs Game Ramah untuk Lingkunganmu.</p>
<br>

Selamat datang di MonkeyGG2, situs game kaya fitur yang dibuat untuk Anda! Dengan lebih dari 150 game untuk dipilih, MonkeyGG2 menawarkan pengalaman bermain yang unik dan dapat disesuaikan. Baik Anda seorang gamer, pengembang, atau pengguna biasa, MonkeyGG2 menyediakan lingkungan bermain yang mulus dan menyenangkan.

> Pertimbangkan untuk memberi kami bintang! Terutama jika Anda melakukan fork repository ini atau menemukan kegunaan lain dari repository ini.

## Fitur

-   Lebih dari 150 game
-   Mudah digunakan
-   Mudah di-deploy
-   Dapat disesuaikan
-   Proxy
-   Dan Lain-lain...

## Kustomisasi

### Pengaturan

#### Cloaking

Cloaking mengacu pada membuka halaman di tab `about:blank`. Perilaku ini dipaksakan secara default, meskipun dapat dinonaktifkan. Preset tersedia untuk tautan pengalihan, namun juga dapat dikonfigurasi secara manual.

#### Masking

Masking mengacu pada mengubah ikon dan judul tab dari tab about:blank. Preset tersedia untuk ikon dan judul tab, namun juga dapat dikonfigurasi secara manual.

#### Pintasan

Pintasan keyboard khusus dapat dibuat untuk melakukan berbagai tugas. Misalnya, keluar dari game, masking tab, dan mengeksekusi JavaScript khusus semuanya didukung.
> Catatan: jika Anda ingin mengeksekusi JavaScript khusus, pastikan Anda tahu apa yang Anda lakukan. Jika terjadi masalah, memuat ulang halaman adalah solusi.

#### Tema

Kustomisasi tema berikut saat ini didukung:
- Toggle Animasi Latar Belakang (jika Anda khawatir tentang performa saat bermain game, jangan khawatir, fitur ini otomatis dinonaktifkan saat Anda bermain)
- Warna Latar Belakang
- Warna Blok
- Warna Tombol
- Warna Game
- Warna Hover
- Warna Scrollbar
- Warna Track Scroll
- Warna Font

> Catatan: jika Anda tidak sengaja mengubah warna sehingga situs tidak dapat digunakan, Anda harus menghapus cookies dan local storage Anda.

### Kustomisasi Lanjutan

> Disclaimer: Kustomisasi berikut hanya tersedia untuk pemilik repository atau fork dari repository ini.

File `config.jsonc` diformat untuk menyertakan konfigurasi untuk seluruh situs. Saat ini, item berikut didukung:
- Game
- Tema (segera hadir)
- Konfigurasi Proxy

#### Game

Setiap entri game memiliki key yang merepresentasikan nama tampilan game, dan value harus berupa objek dengan tiga pasangan key-value:
- `"path"`: Path ke game dari direktori `./games`
- `"aliases"`: Daftar nama alternatif untuk game yang digunakan untuk meningkatkan pencarian
- `"categories"`: Daftar kategori yang sesuai dengan game (dukungan untuk menambah ikon segera hadir)

Menambah entri secara manual memungkinkan, tetapi cukup merepotkan, terutama jika Anda ingin mengurutkan daftar secara alfanumerik (tidak wajib agar konfigurasi berfungsi!).
Itulah mengapa script `add-game-entry.js` dibuat, cara mudah untuk menambah game baru ke konfigurasi tanpa harus mengedit file secara manual.

```bash
# Anda dapat menggunakan runtime js apapun seperti node.js, bun, atau deno
# Untuk demonstrasi ini bun akan digunakan karena dependensi otomatis terpasang
bun add-game-script.js
# Jawab prompt yang muncul dan konfigurasi akan diperbarui
```

#### Tema

Standar tema belum diimplementasikan (TODO)

#### Proxy

Opsi konfigurasi proxy berada di bawah key **"config"**. 
Value untuk key `"proxy"` adalah boolean yang mengaktifkan atau menonaktifkan fungsi proxy. Jika `"proxy"` disetel ke false, maka pengguna akan mendapat dialog error saat mencoba mengakses proxy.
Value untuk key `"proxyPath"` adalah path ke proxy. Bisa berupa path absolut atau relatif, tetapi proxy harus mendukung **CORS** karena halaman proxy akan ditampilkan sebagai iframe di situs.

## Deployment

### Tanpa Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Sebagai alternatif, Anda cukup melakukan fork repository ini di [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) atau [Codeberg](https://codeberg.org/MonkeyGG2/pages) dan deploy ke GitHub Pages atau Codeberg Pages.

### Dengan Proxy

Kunjungi halaman [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) untuk mempelajari lebih lanjut tentang hosting MonkeyGG2 dengan proxy.

### Menjalankan Secara Lokal

```bash
# PERINGATAN: jika Anda memiliki folder bernama "monkeygg2", perintah ini akan menghapus semua file di folder tersebut
# silakan ganti nama direktori pada dua perintah berikut
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# dari sini Anda dapat menggunakan alat apapun untuk menjalankan server statis, "live-server" dari npm akan digunakan di sini
npm install -g live-server # hanya jika belum terpasang
npx live-server
```

## Lisensi

Didistribusikan di bawah Lisensi WTFPL. Lihat [di sini](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) untuk detail lebih lanjut.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---