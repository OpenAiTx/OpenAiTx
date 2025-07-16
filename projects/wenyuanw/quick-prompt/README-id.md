# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Sebuah ekstensi browser yang kuat, berfokus pada manajemen prompt dan input cepat. Membantu pengguna membuat, mengelola, dan mengorganisasi pustaka prompt, serta dengan cepat memasukkan konten Prompt yang telah diatur ke dalam kolom input di halaman web mana pun untuk meningkatkan efisiensi kerja.

> Karena ekstensi browser hanya dapat digunakan di sisi web, maka telah dibuat open source [Raycast Plugin](https://github.com/wenyuanw/quick-prompt-raycast) dengan fungsi yang sama, kompatibel dengan format data ekstensi browser, mendukung migrasi tanpa hambatan menggunakan data JSON yang sama.

## ✨ Fitur

- 📚 **Manajemen Prompt**: Buat, edit, dan kelola pustaka prompt Anda dengan mudah
- 🚀 **Input Cepat**: Di kolom input teks halaman web mana pun, ketik `/p` untuk memicu pemilih prompt dengan cepat
- ⌨️ Mendukung pengaturan pintasan keyboard untuk membuka pemilih prompt & menyimpan teks terpilih sebagai prompt
- 📑 Mendukung menu klik kanan untuk langsung menyimpan teks terpilih sebagai prompt
- 🎯 Mendukung prompt kustom, termasuk kategori, judul, konten, label, dan variabel
- 🧑‍💻 **Dukungan Variabel**: Di dalam prompt dapat menggunakan variabel dengan format `{{nama_variabel}}`, isi nilainya saat digunakan
- 💾 **Backup Data**: Mendukung ekspor dan impor pustaka prompt, memudahkan migrasi dan backup lintas perangkat
- 🔗 **Sinkronisasi Notion**: Mendukung sinkronisasi pustaka prompt dengan database Notion
- 🔍 Mendukung pencarian dan filter prompt
- 🌙 Menyesuaikan otomatis dengan tema terang/gelap sistem

## ⚠️ Masalah Diketahui

- Di situs doubao.com, setelah memicu pemilih prompt dengan `/p`, beberapa kolom input tidak menghapus `/p`. Tapi jangan khawatir, saya dan rekan lama saya Cursor sedang berupaya keras mencari solusi, semoga segera bisa diperbaiki!

## 🚀 Cara Penggunaan

1. **Pemicu Cepat**: Di kolom input teks halaman web mana pun, ketik `/p` untuk membuka pemilih prompt
2. **Buka Pemilih dengan Pintasan**: Gunakan `Ctrl+Shift+P` (Windows/Linux) atau `Command+Shift+P` (macOS) untuk membuka pemilih prompt
3. **Pilih Prompt**: Pilih prompt yang diinginkan dari pemilih yang muncul, prompt akan otomatis masuk ke kolom input aktif
4. **Simpan Prompt dengan Cepat**: Pilih teks apa pun, lalu gunakan `Ctrl+Shift+S` (Windows/Linux) atau `Command+Shift+S` (macOS) untuk menyimpannya sebagai prompt
5. **Simpan dari Menu Klik Kanan**: Pilih teks apa pun, klik kanan dan pilih "Simpan Prompt Ini" untuk menyimpan teks terpilih sebagai prompt
6. **Ekspor Pustaka Prompt**: Pada halaman manajemen, klik tombol "Ekspor" untuk menyimpan semua prompt sebagai file JSON ke lokal
7. **Impor Pustaka Prompt**: Pada halaman manajemen, klik tombol "Impor" untuk mengambil prompt dari file JSON lokal (mendukung gabung atau timpa prompt yang ada)

## 📸 Pratinjau Antarmuka

Quick Prompt menawarkan antarmuka pengguna yang intuitif dan ramah, memudahkan Anda mengelola dan menggunakan prompt.

### Pemilih Prompt

![Pemilih Prompt](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Pemilih Prompt](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Gunakan perintah singkat `/p` atau pintasan keyboard untuk dengan cepat membuka pemilih prompt di kolom input mana pun, sehingga Anda dapat memilih dan memasukkan prompt yang diperlukan dengan mudah.

### Halaman Manajemen Prompt

![Manajemen Prompt](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Di halaman manajemen, Anda dapat membuat prompt baru, mengedit prompt yang ada, menambah label, serta mengelola kategori. Antarmuka sederhana dan mudah digunakan.

### Simpan dari Menu Klik Kanan

![Simpan dari Menu Klik Kanan](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Cukup pilih teks apa pun di halaman web, klik kanan untuk langsung menyimpannya sebagai prompt dan meningkatkan efisiensi kerja.

### Input Variabel Prompt

![Popup Variabel Prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompt mendukung konfigurasi variabel, setelah dipilih akan muncul popup untuk mengisi nilai variabel yang sesuai.

## ⚙️ Konfigurasi Kustom

1. Klik ikon ekstensi, lalu klik tombol "Kelola Prompt"

2. Di halaman manajemen, kamu dapat:
   - Menambahkan prompt baru
   - Mengedit prompt yang sudah ada
   - Menghapus prompt yang tidak diperlukan
   - Menambahkan tag pada prompt untuk pengelompokan
   - Mengekspor basis data prompt untuk cadangan
   - Mengimpor basis data prompt yang telah dicadangkan sebelumnya

## 📦 Panduan Instalasi

### Instalasi dari Toko Aplikasi

Sekarang tersedia di Chrome Web Store! [Klik di sini untuk mengunduh dan menginstal](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Mendapatkan dari GitHub Releases

1. Kunjungi [halaman GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Unduh paket plugin versi terbaru
3. Ekstrak file yang telah diunduh
4. Ikuti petunjuk di bawah untuk menginstal ekstensi yang telah dibangun

### Membangun dari Sumber

1. Kloning repositori
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Instalasi Dependensi
   ```bash
   pnpm install
   ```
3. Pengembangan dan Pembangunan

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Menginstal Ekstensi yang Telah Dibangun

#### Chrome / Edge
1. Buka halaman manajemen ekstensi (`chrome://extensions` atau `edge://extensions`)
2. Aktifkan "Mode Pengembang"
3. Klik "Muat ekstensi yang diekstrak"
4. Pilih direktori `.output/chrome-mv3/` dari proyek

#### Firefox
1. Buka `about:debugging`
2. Klik "This Firefox"
3. Klik "Load Temporary Add-on"
4. Pilih file `manifest.json` di direktori `.output/firefox-mv2/` dari proyek

## 📄 Lisensi

MIT

## 🤝 Panduan Kontribusi

Pull Request dan Issue sangat disambut!

1. Fork repositori ini
2. Buat branch fitur Anda (`git checkout -b feature/amazing-feature`)
3. Commit perubahan Anda (`git commit -m 'Add some amazing feature'`)
4. Push ke branch (`git push origin feature/amazing-feature`)
5. Buka Pull Request

## 👏 Daftar Kontributor

Terima kasih kepada semua pengembang yang telah berkontribusi pada proyek ini!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---