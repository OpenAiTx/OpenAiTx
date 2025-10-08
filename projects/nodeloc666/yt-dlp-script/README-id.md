
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Alat Unduh Video Massal yt-dlp (Dukungan Windows / Linux)

> Berdasarkan [yt-dlp](https://github.com/yt-dlp/yt-dlp), skrip unduhan video sekali klik yang terinspirasi dari [Sharing NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Mendukung unduhan video tunggal dan massal, kompatibel dengan Windows dan distribusi Linux utama (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Fitur Unggulan

* 📥 **Jalankan dengan Satu Klik**: Tidak perlu konfigurasi manual, cukup masukkan sesuai petunjuk untuk mulai mengunduh
* 🍪 **Mendukung Cookie Kustom**: Cocok untuk video yang membutuhkan login untuk diunduh (⚠️ Fitur ini belum diuji, mungkin ada Bug)
* 📂 **Mendukung Direktori Output Kustom**: Mudah menyimpan ke folder yang diinginkan
* 📃 **Mendukung Unduhan Massal**: Secara otomatis membaca tautan dari file `urls.txt` untuk diunduh
* ⚙️ **Instalasi Dependensi Otomatis**: Secara otomatis memasang `yt-dlp` dan `ffmpeg` di lingkungan Linux

---

## 🖼️ Pratinjau Screenshot

| Contoh 1                                                                  | Contoh 2                                                                  |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Contoh 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Contoh 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Contoh 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Contoh 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Cara Penggunaan di Windows

1. Unduh file berikut:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` versi Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Setelah diekstrak, tempatkan file berikut ke dalam satu folder (misal folder `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (file skrip)

3. Klik dua kali `yt-dlp.bat`, ikuti petunjuk untuk mengunduh video.
4. Edit config/config.ini untuk mengubah konfigurasi default

---

## 🐧 Cara Penggunaan di Linux (Script terbaru dari Lion juga sudah mengintegrasikan fitur yang sama)

**Sistem yang Didukung**: Debian / Ubuntu / Alpine / CentOS

Satu klik untuk menerapkan atau memperbarui dan menjalankan:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Untuk menghapus instalasi:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Rekomendasi Penggunaan Android

1. Gunakan aplikasi [Seal](https://github.com/JunkFood02/Seal) untuk menikmati fitur `yt-dlp` di Android.
2. Install Debian di termux juga bisa untuk mengunduh, tapi kita tidak perlu menggunakan itu, Seal sudah sangat mudah digunakan.

---

## ⚠️ Catatan Penting

1. **Mode unduh massal**: Skrip akan otomatis membaca `config\urls.txt` di direktori saat ini, satu tautan video per baris. Jika file tidak ada, akan dibuat otomatis.
2. **Peringatan penggunaan sumber daya**: Untuk perangkat dengan RAM kecil, hindari mengunduh beberapa video besar secara bersamaan atau mengatur jumlah thread yang terlalu tinggi.
3. **Catatan khusus CentOS**: Karena lingkungan yang cukup unik, belum diuji secara menyeluruh, disarankan hanya digunakan di lingkungan non-produksi. Sistem utama lainnya sudah diverifikasi bisa digunakan.
4. Bug kecil versi Linux: Saat skrip berjalan di halaman utama, akan mendeteksi dependensi sekali, prinsipnya selama kode bisa jalan sudah cukup, malas untuk memperbaiki.
5. Bug kecil versi Windows: Ketika dari halaman lain kembali ke halaman utama lalu memilih lagi, opsi default mungkin gagal dan menyebabkan loop, kemampuan terbatas, belum diperbaiki dengan baik.
Dua solusi:
    1. Keluar dan jalankan ulang
    2. Jangan pilih default, pilih dengan angka saja

---

## 📄 Lisensi

Proyek ini mengikuti [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---