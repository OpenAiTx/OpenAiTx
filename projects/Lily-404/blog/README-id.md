
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Blog Jimmy

Sebuah sistem blog pribadi minimalis yang dibangun dengan Next.js 15+, mendukung pembuatan online dan deployment statis.

## Teknologi yang Digunakan

- **Framework**: Next.js 15+ (App Router)
- **Bahasa**: TypeScript
- **Gaya**: Tailwind CSS
- **Ikon**: Lucide Icons
- **Konten**: Markdown + Gray Matter + Remark
- **Otentikasi**: GitHub OAuth
- **Deploy**: Vercel

## Fitur Utama

### Sisi Pembaca

- 📝 Render artikel Markdown + GFM (termasuk tampilan rumus matematika)
- 🏷️ Filter tag, pagination, arsip (berdasarkan tahun/tag)
- 📚 Navigasi daftar isi artikel (TOC) dan salin kode satu klik
- 📱 Tata letak responsif dan pengalihan tema gelap/terang
- 🔥 Heatmap kalender kreatif melayang (artikel + catatan)
- 📡 Output langganan RSS (`/rss.xml`)

### Sisi Penulis (Manajemen Backend)

- 🔐 Login GitHub OAuth (verifikasi hak pemilik/kolaborator)
- ✍️ Pembuatan, pengeditan, penghapusan artikel/catatan secara online
- 🆔 Kustom ID file + penghindaran konflik otomatis
- 👀 Mode menulis Edit / Pratinjau / Split
- 📊 Panel statistik kreatif (total, produksi minggu/bulan, tag populer)

### Sisi Engineering

- ⚡ Output statis multi-halaman (`force-static`) untuk performa & stabilitas
- 🧭 Sitemap dan robots bawaan
- 🧩 Cache pembacaan konten dan struktur API modular

## Struktur Proyek

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Instalasi dan Menjalankan

1. Kloning proyek

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Instalasi dependensi

```bash
npm install
```

3. Menjalankan server pengembangan

```bash
npm run dev
```

4. Membangun versi produksi

```bash
npm run build
```

## Menambahkan Artikel Baru

### Cara 1: Melalui Panel Admin Online (Direkomendasikan)

1. Kunjungi halaman `/admin`
2. Login menggunakan GitHub OAuth
3. Isi informasi artikel dan kirimkan
4. Artikel akan otomatis dibuat melalui GitHub API, Vercel akan melakukan redeploy secara otomatis

### Cara 2: Menambahkan File Secara Manual

1. Buat file Markdown baru di direktori `content/posts`
2. Format penamaan file: `xxx.md`
3. Tambahkan metadata di bagian awal file:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Menambahkan Catatan

1. Buat file Markdown baru di direktori `content/notes`
2. Format penamaan file: `YYYY-MM-DD-title.md`
3. Tambahkan metadata di bagian atas file:

```markdown
---
date: YYYY-MM-DD
---
```

## Konfigurasi Admin Backend

Admin backend menggunakan GitHub OAuth untuk otentikasi, hanya pemilik repositori atau kolaborator yang dapat mengakses.

### 1. Membuat GitHub OAuth App

1. Kunjungi [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Klik "New OAuth App"
3. Isi informasi:
   - **Application name**: `Jimmy Blog Admin` (atau nama apa pun)
   - **Homepage URL**: `https://domain-anda.com` (produksi) atau `http://localhost:3000` (pengembangan lokal)
   - **Authorization callback URL**: 
     - Produksi: `https://domain-anda.com/api/auth/github/callback`
     - Pengembangan lokal: `http://localhost:3000/api/auth/github/callback`
4. Klik "Register application"
5. Catat **Client ID**
6. Klik "Generate a new client secret", catat **Client secret**

### 2. Konfigurasi Variabel Lingkungan

Tambahkan variabel lingkungan berikut pada pengaturan proyek Vercel:

- `GITHUB_CLIENT_ID`: Client ID dari GitHub OAuth App Anda
- `GITHUB_CLIENT_SECRET`: Client Secret dari GitHub OAuth App Anda
- `GITHUB_OWNER`: Username GitHub (default: `Lily-404`, untuk validasi hak akses pengguna)
- `GITHUB_REPO`: Nama repositori (default: `blog`)
- `GITHUB_REDIRECT_URI`: URL callback OAuth (opsional, default akan dibuat otomatis)
- `NEXT_PUBLIC_BASE_URL`: URL situs web Anda (untuk membuat callback URL, wajib diatur pada produksi)
  - Produksi: `https://www.jimmy-blog.top`
  - Pengembangan lokal: `http://localhost:3000`

### 3. Konfigurasi Pengembangan Lokal

Buat file `.env.local` di direktori root proyek:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Konfigurasi Lingkungan Produksi (Vercel)

Di pengaturan proyek Vercel, pastikan untuk mengatur:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Perhatian**: 
- File `.env.local` telah ditambahkan ke `.gitignore`, sehingga tidak akan dikomit ke Git
- Saat pengembangan lokal, pastikan URL callback OAuth App diatur ke `http://localhost:3000/api/auth/github/callback`
- **Pada lingkungan produksi, `NEXT_PUBLIC_BASE_URL` harus diatur ke `https://www.jimmy-blog.top`**
- URL callback OAuth App untuk lingkungan produksi harus diatur ke: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deploy

Proyek telah dikonfigurasi untuk deployment di Vercel, mendukung deployment otomatis. Cukup dorong kode ke repository GitHub, Vercel akan secara otomatis membangun dan mendepoy.

### Keunggulan menggunakan dashboard admin

- ✅ Tidak perlu lingkungan pengembangan lokal
- ✅ Dapat menambah artikel kapan saja dan di mana saja
- ✅ Otomatis memicu Vercel untuk redeploy
- ✅ Sepenuhnya gratis (GitHub OAuth dan Vercel dalam kuota gratis)
- ✅ Aman (verifikasi GitHub OAuth, hanya pemilik/kolaborator repo yang dapat mengakses)
- ✅ Tidak perlu mengelola password, login dengan akun GitHub
- ✅ Mendukung edit online untuk konten yang sudah ada (bukan hanya membuat baru)
- ✅ Otomatis menangani konflik ID file, mencegah overwrite dan rename manual
- ✅ Statistik kreator bawaan di dashboard, memudahkan pengelolaan konten berkelanjutan

## Analisis Proyek & Perencanaan Masa Depan

- Dokumen analisis proyek: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Dokumen rencana masa depan: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Kontribusi

Silakan ajukan Issue dan Pull Request!

## Lisensi

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---