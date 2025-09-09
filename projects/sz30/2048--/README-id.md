<div align="right">
  <details>
    <summary >🌐 Bahasa Lain</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

Versi peningkatan dari game klasik 2048, kini dengan fitur-fitur yang lebih seru! Ini adalah proyek kecil yang saya buat di waktu luang—semoga bisa membawa kebahagiaan untuk Anda!

## 🎯 Pengantar Permainan

2048 adalah permainan menggabungkan angka yang sederhana namun membuat ketagihan. Pada papan berukuran 4x4, geser ke atas, bawah, kiri, atau kanan untuk menggabungkan ubin dengan angka yang sama. Tujuannya? Capai 2048 (tapi Anda bisa lanjutkan untuk skor yang lebih tinggi)!

**Cara bermain:**
- Gunakan tombol panah atau WASD untuk menggerakkan ubin.
- Ketika dua ubin dengan angka yang sama bertabrakan, mereka bergabung menjadi satu.
- Setelah setiap langkah, angka 2 atau 4 baru akan muncul secara acak di tempat kosong.
- Permainan berakhir ketika tidak ada lagi langkah yang tersisa.

## ✨ Fitur Khusus

### 1. Fungsi Undo
- Salah langkah? Tenang saja!
- Cukup tekan tombol "Undo" untuk kembali satu langkah.
- Kamu bisa undo sebanyak yang kamu mau, sampai ke awal permainan.
- Jangan biarkan kesalahan kecil merusak permainanmu lagi!

### 2. Mode Cheat Rahasia
- Masukkan urutan ajaib: ←←→→ →→←← (kiri, kiri, kanan, kanan, kanan, kanan, kiri, kiri)
- Semua ubin akan secara ajaib berubah menjadi 128!
- Ini adalah Easter egg, hanya untuk bersenang-senang.
- Tips pro: Curang itu seru, tapi jangan berlebihan! 😉

## 🎯 Demo

🎯 : [Main di sini](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 Struktur Proyek
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**Deskripsi Berkas:**
- `2048.py`: Server backend yang ditulis dengan Flask, menangani logika permainan dan permintaan API.
- `script.js`: Logika permainan frontend, termasuk pergerakan, animasi, dan fitur khusus.
- `styles.css`: Gaya permainan, memastikan semuanya terlihat menarik dan responsif.
- `index.html`: Halaman utama yang menggabungkan semuanya.

## 🚀 Memulai

**Metode 1: Unduh Rilis**
1. Unduh rilis terbaru.
2. Pastikan Anda telah menginstal Python 3.x.
3. Instal dependensi: `pip install flask`
4. Jalankan: `python 2048.py`
5. Buka browser Anda dan kunjungi: [http://localhost:9969](http://localhost:9969)

**Metode 2: Clone dari GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 Kustomisasi

Ingin membuatnya jadi milikmu sendiri? Ubah `styles.css` untuk tampilan baru, atau masuk ke `script.js` untuk mengubah gameplay. Semua kode sudah dikomentari dengan baik agar mudah dioprek!

## 📝 Lisensi

Lisensi GPL-2.0

## 🤝 Kontribusi

Masih terus diperbarui! Isu dan Pull Request sangat diterima—mari kita jadikan game ini semakin keren bersama-sama!


## 🙏 Penghargaan

Terima kasih kepada sponsor berikut yang telah mendukung proyek ini:
- [None](https://#/) menyediakan server
- [Serv00](https://www.serv00.com/) menyediakan server

---
_Terakhir diperbarui: Agustus 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---