<details align="right">
<summary>🌐 Bahasa</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **Alat Hosting Layanan Tersembunyi Tor Terbaik** - Deploy proyek web Anda ke dark web dalam hitungan menit!
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Apa itu OnionHoster?

OnionHoster adalah skrip bash lintas platform yang kuat, yang mengubah proyek web apa pun menjadi layanan tersembunyi Tor hanya dengan satu perintah. Apakah Anda menghosting aplikasi Next.js, backend Flask, atau situs web statis, OnionHoster menangani semua konfigurasi Tor yang kompleks secara otomatis.

### ✨ Kenapa Memilih OnionHoster?

- **🔧 Tanpa Konfigurasi** - Langsung berjalan untuk proyek web apa saja
- **🌍 Lintas Platform** - Mendukung Linux, macOS, dan distribusi utama
- **⚡ Setup Satu Klik** - Dari nol ke layanan tersembunyi dalam kurang dari 2 menit
- **🔄 Pembaruan Otomatis** - Pemeriksa pembaruan bawaan menjaga Anda tetap terbaru
- **💾 Backup & Restore** - Jangan pernah kehilangan alamat onion Anda
- **🎯 UI Profesional** - Antarmuka berwarna yang indah dengan menu intuitif

---
## Pratinjau

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Peringatan: OnionHoster BUKAN alat anonimitas ajaib — ikuti praktik terbaik atau risiko kehilangan anonimitas

**Penguatan Sistem**

* Jalankan layanan di dalam VM atau kontainer untuk isolasi.

* Selalu perbarui OS dan paket-paketnya.
* Nonaktifkan layanan/port yang tidak diperlukan agar hanya lalu lintas Tor yang masuk/keluar.

**Praktik OpSec**

* Jangan gunakan mesin yang sama untuk akun atau aktivitas pribadi.
* Hindari mengekspos metadata yang dapat mengidentifikasi (nama file, header, pesan error).
* Perhatikan log — apa yang dicatat, berapa lama disimpan, dan apakah membocorkan informasi.

**Kebersihan Jaringan**

* Jangan menghubungkan layanan tersembunyi Anda dengan identitas atau domain clearnet Anda.
* Gunakan firewall untuk memastikan tidak ada kebocoran tak sengaja di luar Tor.
* Pertimbangkan reverse proxy untuk isolasi tambahan.

**Pengujian & Pemantauan**

* Gunakan torsocks atau Tor Browser untuk memverifikasi bahwa layanan Anda hanya dapat diakses melalui alamat `.onion`-nya.
* Uji secara rutin untuk kebocoran (misalnya, apakah aplikasi Anda mencoba mengambil dari clearnet).

**Kesadaran Penggunaan**

* Untuk penggunaan hobi/tes/edukasi: biasanya saran di atas sudah cukup.
* Untuk anonimitas dunia nyata berisiko tinggi (jurnalis, whistleblower, aktivis): diperlukan keamanan operasional dan pemodelan ancaman yang lebih dalam, karena satu kesalahan saja dapat membuka identitas Anda.


---
## 🎯 Cocok Untuk

- **Pengembang** yang ingin menguji aplikasi mereka di Tor
- **Pemerhati Privasi** yang menghosting layanan anonim (
- **Peneliti** yang mempelajari teknologi dark web
- **Bisnis** yang membutuhkan solusi hosting anonim
- **Penghobi** yang menjelajahi jaringan Tor

---

## 🚀 Mulai Cepat

### Prasyarat
- Akses root/sudo
- Koneksi internet
- Proyek web apa pun (HTML, Next.js, Flask, dll.)

### Instalasi & Penggunaan

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```
**Itu saja!** 🎉

Anda akan mendapatkan proyek OnionHoster lengkap termasuk:
- Skrip utama `onionhoster.sh`
- Template profesional `index.html` untuk hosting
- Semua dokumentasi dan contoh

Skrip akan secara otomatis:
- Mendeteksi sistem operasi Anda
- Menginstal semua dependensi yang diperlukan (Tor, Apache, dll)
- Mengkonfigurasi layanan Tor
- Menyajikan menu yang intuitif

---

## 🎮 Ikhtisar Fitur

### 🌐 Opsi Hosting
- **HTML Statis** - Hosting file `index.html` apa pun
- **Port Forwarding** - Meneruskan ke port aplikasi lokal mana pun
- **Aplikasi Dinamis** - Mendukung Next.js, Flask, Node.js, dan lainnya

### 🛠️ Alat Manajemen
- **Kontrol Layanan** - Mulai, hentikan, dan kelola layanan tersembunyi Anda
- **Backup & Restore** - Cadangkan dan pulihkan domain onion Anda dengan aman
- **Refresh URL** - Hasilkan alamat onion baru saat diperlukan
- **Monitoring Status** - Periksa kesehatan dan status layanan

### 🔄 Pembaruan Cerdas
- **Deteksi Otomatis** - Secara otomatis menemukan versi terbaru
- **Pembaruan Satu Klik** - Memperbarui dengan satu opsi menu
- **Pembaruan Aman** - Tidak ada risiko kehilangan konfigurasi Anda

---

## 📱 Sistem Operasi yang Didukung

| OS | Manajer Paket | Status |
|----|----------------|---------|

| **Ubuntu/Debian** | `apt-get` | ✅ Dukungan Penuh |
| **CentOS/RHEL** | `yum` | ✅ Dukungan Penuh |
| **Fedora** | `dnf` | ✅ Dukungan Penuh |
| **Arch Linux** | `pacman` | ✅ Dukungan Penuh |
| **macOS** | `brew` | ✅ Dukungan Penuh |

---

## 🎯 Kasus Penggunaan

### 🏠 Proyek Pribadi
- Hosting portofolio Anda secara anonim
- Menguji aplikasi web secara privat
- Berbagi konten tanpa mengungkap identitas Anda

### 🏢 Aplikasi Bisnis
- Portal dukungan pelanggan anonim
- Sistem komunikasi internal yang aman
- Situs bisnis dengan fokus pada privasi

### 🔬 Riset & Pengembangan
- Penelitian teknologi dark web
- Pengembangan alat privasi
- Pengujian layanan anonim

---

## 📖 Penggunaan Terperinci

### Opsi Menu Utama

1. **Host index.html** - Menyajikan file HTML statis
2. **Forward ke Port Aplikasi** - Proxy ke layanan lokal apa pun
3. **Cadangkan domain tor** - Simpan konfigurasi onion Anda
4. **Pulihkan domain tor** - Pulihkan dari cadangan
5. **Lihat domain tor saat ini** - Lihat alamat onion aktif Anda
6. **Segarkan domain tor** - Buat alamat onion baru
7. **Periksa pembaruan** - Perbarui ke versi terbaru
8. **Status Web Server** - Pantau kesehatan layanan
9. **Tentang OnionHoster** - Informasi versi dan fitur

### Contoh Alur Kerja

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Konfigurasi Lanjutan

### Pengalihan Port Kustom
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Manajemen Cadangan
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```
---

## 🛡️ Fitur Keamanan

- **Konfigurasi Tor Otomatis** - Pengaturan aman langsung digunakan
- **Izin File yang Tepat** - Kepemilikan dan akses file yang aman
- **Isolasi Layanan** - Setiap layanan tersembunyi berjalan secara mandiri
- **Tanpa Pencatatan Data** - Aktivitas Anda tetap pribadi

---

## 🚨 Catatan Penting

- **Akses Root Dibutuhkan** - Layanan Tor memerlukan konfigurasi tingkat sistem
- **Jaringan Tor** - Layanan Anda dapat diakses melalui Tor Browser
- **Alamat Onion** - Setiap layanan mendapat alamat `.onion` unik
- **Cadangkan Secara Berkala** - Alamat onion berubah saat penyegaran

---

## 🤝 Kontribusi

Kami menerima kontribusi! Baik itu:
- 🐛 Laporan bug
- 💡 Permintaan fitur
- 📝 Perbaikan dokumentasi
- 🔧 Kontribusi kode

**Mulai dengan:**
1. Fork repositori
2. Buat branch fitur
3. Lakukan perubahan Anda
4. Kirim pull request

---

## 📄 Lisensi

Proyek ini dilisensikan di bawah MIT License - lihat file [LICENSE](LICENSE) untuk detailnya.

---

## 🙏 Ucapan Terima Kasih

- **Tor Project** - Untuk jaringan anonimitas yang luar biasa
- **Komunitas Open Source** - Untuk peningkatan berkelanjutan
- **Pengguna & Kontributor** - Untuk masukan dan saran

---

## 🔗 Tautan

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Issues**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Diskusi**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Beri Bintang pada Proyek Ini

Jika OnionHoster membantu Anda, mohon beri bintang! Ini memotivasi kami untuk terus meningkatkan dan membantu orang lain menemukan alat ini.

---

**Siap menjadi anonim?** 🕵️‍♂️


```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Perjalanan Anda menuju hosting anonim dimulai sekarang!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---