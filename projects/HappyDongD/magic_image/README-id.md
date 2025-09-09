
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Gambar AI Ajaib

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Lisensi](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Aplikasi AI gambar berbasis Next.js, memiliki fitur utama berikut:
- 🎨 Mendukung berbagai model AI (Sora, DALL-E, GPT, GEMINI, dll) serta penambahan model kustom
- 🖼️ Menyediakan fitur teks-ke-gambar dan gambar-ke-gambar, mendukung referensi multi-gambar dan edit area
- 🔐 Semua data dan kunci API disimpan secara lokal, menjaga keamanan privasi
- 💻 Mendukung versi web dan paket aplikasi desktop, penggunaan lintas platform

## Pengalaman Online

Alamat akses: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Cuplikan Aplikasi

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Cuplikan Aplikasi 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Cuplikan Aplikasi 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Cuplikan Aplikasi 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Cuplikan Aplikasi 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Cuplikan Aplikasi 3" width="800" style="margin-bottom: 20px"/>
</div>

## Fitur Utama

- 🎨 Mendukung berbagai model AI
  - Model GPT Sora_Image
  - Model GPT 4o_Image
  - Model GPT Image 1
  - Model DALL-E 3
  - Model GEMINI
  - 🆕 Model kustom (mendukung penambahan model privat)
- 🔄 Pergantian multi model
  - Mendukung pergantian cepat antar model yang berbeda
  - Setiap model memiliki opsi konfigurasi sendiri
- ✍️ Fitur teks-ke-gambar
  - Mendukung penyesuaian kata prompt
  - Dapat memilih rasio gambar
  - Mendukung berbagai ukuran gambar
- 🖼️ Fitur gambar-ke-gambar
  - Mendukung edit gambar
  - Mendukung edit area dengan masking
  - Mendukung penyesuaian kualitas gambar
  - Mendukung referensi multi-gambar (unggah beberapa gambar sekaligus)
- 🔒 Keamanan data
  - Semua gambar yang dihasilkan dan riwayat hanya disimpan di browser lokal
  - Mendukung alamat proxy API kustom
  - Mendukung konfigurasi API Key
- 📱 Desain UI
  - Antarmuka pengguna modern
  - Pengalaman interaksi yang lancar
  - Tampilan format Markdown
  - Dukungan penyorotan kode
- 🖥️ Dukungan lintas platform
  - Mendukung pengemasan sebagai aplikasi desktop (Windows, macOS, Linux)
  - Mendukung penggunaan offline (perlu konfigurasi API)

## Teknologi yang digunakan

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (pengemasan aplikasi desktop)

## Pengembangan Lokal

1. Clone proyek
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Instalasi dependensi

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Mulai server pengembangan

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Kunjungi [http://localhost:3000](http://localhost:3000)

## Paket Aplikasi Desktop

Proyek ini menggunakan Tauri untuk melakukan paket aplikasi desktop, mendukung sistem Windows, macOS, dan Linux.

### Persiapan Lingkungan

Sebelum melakukan paket aplikasi desktop, Anda perlu menginstal dependensi berikut:

1. **Instal Rust**:
   - Kunjungi [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Ikuti petunjuk untuk menginstal Rust dan Cargo

2. **Dependensi Sistem**:
   - **Windows**: Instal [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Instal Xcode Command Line Tools (`xcode-select --install`)
   - **Linux**: Instal dependensi terkait, lihat [Dokumentasi Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Mode Pengembangan


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Membangun Aplikasi Desktop


```bash
# 构建桌面应用安装包
npm run desktop
```
Setelah proses build selesai, paket instalasi untuk sistem yang sesuai dapat ditemukan di direktori `src-tauri/target/release/bundle`.

## Deploy Vercel

1. Fork proyek ini ke akun GitHub Anda

2. Buat proyek baru di [Vercel](https://vercel.com)

3. Impor repository GitHub Anda

4. Klik Deploy

## Petunjuk Penggunaan

1. Konfigurasi kunci API diperlukan saat pertama kali digunakan
   - Klik "Pengaturan Kunci" di pojok kanan atas
   - Masukkan kunci API dan alamat dasar
   - Klik Simpan
   - Anda juga dapat melakukan konfigurasi cepat melalui parameter URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Catatan: Karakter khusus dalam URL perlu di-encode dengan URL

2. Pilih mode pembuatan
   - Teks ke gambar: menghasilkan gambar melalui deskripsi teks
   - Gambar ke gambar: mengedit gambar dengan mengunggah gambar

3. Atur parameter pembuatan
   - Pilih model AI (model bawaan atau model kustom)
   - Atur rasio gambar
   - Sesuaikan kualitas gambar (mode gambar ke gambar)

4. Manajemen model kustom
   - Klik ikon pengaturan di samping kotak pemilihan model
   - Tambah model baru: masukkan nama model, nilai model, dan pilih tipe model
   - Edit model: klik tombol edit pada model yang sudah ada
   - Hapus model: klik tombol hapus pada model yang sudah ada
   - Pilih model: klik tombol tambah pada model untuk langsung memilih dan menggunakan model tersebut

5. Penjelasan tipe model
   - Format DALL-E: menggunakan antarmuka pembuatan gambar (/v1/images/generations)
   - Format OpenAI: menggunakan antarmuka chat (/v1/chat/completions)

6. Hasilkan gambar
   - Masukkan kata kunci
   - Klik tombol "Hasilkan Gambar"
   - Tunggu hingga proses selesai

7. Manajemen gambar
   - Lihat riwayat
   - Unduh gambar yang dihasilkan
   - Edit gambar yang sudah ada

## Catatan Penting

- Semua gambar yang dihasilkan dan riwayat hanya disimpan di browser lokal Anda
- Menggunakan mode privasi atau mengganti perangkat dapat menyebabkan data hilang
- Harap segera unduh dan cadangkan gambar penting
- Konfigurasi API akan disimpan dengan aman di browser Anda, tidak akan diunggah ke server
- Situs HTTPS yang memuat sumber daya HTTP akan diblokir oleh browser, aplikasi akan otomatis mengonversi antarmuka HTTP menjadi HTTPS

## Panduan Kontribusi

Selamat datang untuk mengajukan Issue dan Pull Request guna membantu meningkatkan proyek ini.

## Lisensi

Proyek ini menggunakan lisensi [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Berdasarkan lisensi, Anda dapat:
- ✅ Penggunaan Komersial: Anda dapat menggunakan perangkat lunak untuk tujuan komersial
- ✅ Modifikasi: Anda dapat memodifikasi kode sumber perangkat lunak
- ✅ Distribusi: Anda dapat mendistribusikan perangkat lunak
- ✅ Penggunaan Pribadi: Anda dapat menggunakan perangkat lunak secara pribadi
- ✅ Pemberian Hak Paten: Lisensi ini juga memberikan hak paten

Namun harus mematuhi persyaratan berikut:
- 📝 Pernyataan Lisensi dan Hak Cipta: Anda harus menyertakan lisensi dan pernyataan hak cipta asli
- 📝 Pernyataan Perubahan: Anda harus menyatakan perubahan signifikan pada kode asli
- 📝 Pernyataan Merek Dagang: Tidak boleh menggunakan merek dagang dari kontributor

---

## Traktir Saya Secangkir Kopi

Jika proyek ini membantu Anda, silakan traktir saya secangkir kopi ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Kode Pembayaran WeChat" width="300" />
  <p>Traktir saya secangkir kopi</p>
</div>

## Kontak

Jika Anda memiliki pertanyaan atau saran, silakan hubungi saya melalui WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Kontak WeChat" width="300" />
  <p>Pindai kode QR untuk menambahkan WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---