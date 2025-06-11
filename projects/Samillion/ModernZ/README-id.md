<h1 align="center">ModernZ - Alternatif OSC yang Elegan untuk mpv</h1>

OSC yang elegan dan modern untuk [mpv](https://mpv.io/), proyek ini adalah fork dari ModernX yang dirancang untuk meningkatkan fungsionalitas dengan menambahkan lebih banyak fitur, sambil tetap mempertahankan standar inti OSC mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Instalasi »</strong></a>
  <br>
  <a href="#configuration">Konfigurasi</a>
  ·
  <a href="#controls">Kontrol</a>
  ·
  <a href="#interactive-menus">Menu Interaktif</a>
  ·
  <a href="#translations">Bahasa OSC</a>
  ·
  <a href="#extras">Skrip Tambahan</a>
</p>

## Fitur

- 🎨 Antarmuka modern dan dapat disesuaikan [[opsi](#configuration)]
- 📷 Mode Penampil Gambar dengan kontrol zoom [[detail](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Tombol: unduh, daftar putar, kontrol kecepatan, tangkapan layar, sematkan, ulang, cache, dan lainnya. [[detail](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Menu interaktif untuk daftar putar, subtitle, bab, trek audio, dan perangkat audio [[detail](#interactive-menus)]
- 🌐 Dukungan multi-bahasa dengan integrasi JSON [locale](#translations)
- ⌨️ Kontrol yang dapat dikonfigurasi [[detail](#controls)]
- 🖼️ Pratinjau thumbnail video dengan [thumbfast](https://github.com/po5/thumbfast)

## Kustomisasi

Anda dapat mengubah tema ikon menjadi `fluent` atau `material` sesuai selera dan gaya Anda dengan menggunakan opsi `icon_theme` di `modernz.conf` Anda

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Tidak suka tombol dan teks putih? Anda memiliki kontrol penuh untuk menyesuaikan warna dan tata letak tombol agar sepenuhnya mencerminkan gaya Anda.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Lihat bagian [Kustomisasi Warna](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) dalam panduan konfigurasi untuk detail cara menyesuaikan warna dan tombol.

## Menu Interaktif

ModernZ mendukung konsol/select bawaan mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) untuk daftar putar, subtitle, navigasi bab, dan lainnya.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Instalasi

1. **Nonaktifkan OSC Bawaan**

   - Tambahkan `osc=no` di `mpv.conf` Anda

2. **Salin Berkas**

   - Tempatkan `modernz.lua` di direktori skrip mpv Anda
   - Tempatkan `fluent-system-icons.ttf` dan `material-design-icons.ttf` di direktori font mpv Anda
   - (OPSIONAL) Tempatkan `thumbfast.lua` di direktori skrip mpv Anda

3. **Lokasi**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Struktur Folder** [[manual mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (opsional)
   ```

## Konfigurasi

1. Buat `modernz.conf` di folder `/script-opts` untuk menyesuaikan pengaturan

   - [Unduh modernz.conf default](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Contoh konfigurasi singkat:

   ```EditorConfig
   # Warna seekbar (format hex)
   seekbarfg_color=#B7410E

   # Opsi antarmuka
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Untuk daftar lengkap opsi, [lihat daftar detail di sini](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Kontrol

### Interaksi Tombol

- Klik kiri: Aksi utama
- Klik kanan: Aksi sekunder
- Klik tengah/Shift+Klik kiri: Aksi alternatif

> [!CATATAN]
> Klik tengah menjalankan fungsi yang sama dengan `Shift+klik kiri`, memungkinkan penggunaan satu tangan

Untuk daftar lengkap interaksi, lihat [Panduan Interaksi Tombol](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Keybinds

ModernZ tidak menetapkan keybind secara default untuk menghindari bentrok dengan pengaturan Anda saat ini. Anda dapat menambahkan keybind di `input.conf` jika diinginkan:

```
w   script-binding modernz/progress-toggle           # Toggle progress bar
x   script-message-to modernz osc-show               # Tampilkan OSC
y   script-message-to modernz osc-visibility cycle   # Siklus mode visibilitas
z   script-message-to modernz osc-idlescreen         # Toggle layar idle
```

## Terjemahan

ModernZ saat ini tersedia dalam Bahasa Inggris, tetapi Anda dapat dengan mudah menggantinya ke bahasa pilihan Anda! Berikut caranya:

1. **Unduh paket locale:**

Ambil berkas [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) dari repositori ini. Berkas ini berisi terjemahan untuk berbagai bahasa.

2. **Tambahkan locale ke mpv:**

Salin berkas `modernz-locale.json` yang telah diunduh ke folder `/script-opts` mpv Anda.

3. **Pilih bahasa Anda:**

Ada dua cara untuk mengatur bahasa pilihan Anda:

- **Disarankan:** Gunakan berkas `modernz.conf`

  ```ini
  # Contoh konfigurasi di modernz.conf
  # Set bahasa ke Mandarin Sederhana
  language=zh
  ```

- **Alternatif:** Edit skrip `modernz.lua`

  Buka `modernz.lua` dan temukan bagian `user_opts` di awal. Ubah nilai `language` ke kode bahasa pilihan Anda:

  ```lua
  local user_opts = {
      -- Umum
      language = "en",  -- Ganti ini dengan kode bahasa pilihan Anda
      ...
  }
  ```

**Butuh Info Lebih?**

Untuk daftar lengkap bahasa yang tersedia, panduan kontribusi, dan dokumentasi terjemahan mendalam, kunjungi [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extras

Skrip berikut adalah yang saya tulis dan pelihara, silakan gunakan jika berguna untuk Anda.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Skrip sederhana yang menampilkan indikator saat jeda

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Skrip mpv sederhana untuk mengubah `ytdl-format` (yt-dlp) secara otomatis untuk domain tertentu.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Skrip mpv sederhana untuk mengubah rasio aspek 4:3 video/file/stream menjadi 16:9 secara otomatis.

Untuk skrip yang lebih berguna, lihat [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts). Wiki ini menyediakan berbagai skrip kontribusi komunitas untuk meningkatkan pengalaman mpv Anda.

## Riwayat

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - fork dari [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - fork dari [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - fork dari [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Kenapa fork lagi?**

- Untuk menambahkan banyak fitur: [Kustomisasi Warna](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Opsi](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) dan [Integrasi Locale](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Untuk mengintegrasikan konsol dan select ke dalam OSC, yang menginspirasi mpv untuk menerapkannya di OSC bawaan. [ref [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Untuk menambahkan tata letak khusus untuk gambar. [[detail](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Untuk merombak proyek sepenuhnya agar sesuai dengan standar OSC bawaan mpv, guna memastikan kompatibilitas
- Untuk menghilangkan bug lama dan redundansi dalam kode
    - Yang memungkinkan fork `Modern` lain menggunakan ModernZ sebagai basis, seperti [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Referensi](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

Singkatnya, untuk memelihara dan menghidupkan kembali asal-usul `modern-osc`.
Dengan demikian, ModernZ masih menggunakan sebagian kode lama, dan setiap penulis serta kontributor fork sebelumnya maupun yang sekarang layak mendapatkan kredit (termasuk osc stok mpv), itulah mengapa mereka disebutkan secara rinci.

#### Kredit:

- Font: UI Fluent System Icons [[detail](https://github.com/microsoft/fluentui-system-icons)] [[file font](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Font dimodifikasi oleh [Xurdejl](https://github.com/Xurdejl) untuk digunakan pada ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) dan [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua) mereka, karena ModernZ osc didasarkan kembali pada standar osc stok dan menerapkan pembaruan dari sana
- Semua asal osc modern dan fork-nya seperti yang disebutkan dalam [sejarah](#history)
- Semua [kontributor](https://github.com/Samillion/ModernZ/graphs/contributors), penguji, dan pengguna yang membantu secara langsung maupun tidak langsung dengan ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---