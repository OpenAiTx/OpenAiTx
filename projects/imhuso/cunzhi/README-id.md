#寸止 🛑

> **AI Percakapan "Ejakulasi Dini" Terminator, Membuat Komunikasi Berlanjut Sampai Akhir**

Masih frustrasi karena asisten AI selalu mengakhiri percakapan terlalu cepat? Padahal masih banyak yang ingin didiskusikan, tapi AI malah berkata "Apakah ada yang bisa saya bantu lagi?" **CunZhi** adalah solusi khusus untuk masalah ini!

Saat AI ingin "segera menyelesaikan", CunZhi akan segera menampilkan dialog pop-up, memungkinkan Anda untuk melanjutkan percakapan secara mendalam hingga masalah benar-benar terselesaikan.

## 🌟 Fitur Utama

- 🛑 **Pencegatan Pintar**: Secara otomatis menampilkan opsi lanjut saat AI ingin mengakhiri percakapan
- 🧠 **Manajemen Memori**: Menyimpan standar pengembangan dan preferensi berdasarkan proyek
- 🎨 **Interaksi Elegan**: Dukungan Markdown, berbagai metode input
- ⚡ **Langsung Pakai**: Instalasi 3 detik, dukungan lintas platform

## 📸 Lihat Hasilnya

### 🛑 Pop-up Pencegatan Pintar
![Demo Pop-up CunZhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Saat AI ingin mengakhiri percakapan, pop-up pintar CunZhi akan segera muncul, menyediakan opsi yang telah ditentukan untuk dipilih dengan cepat, sehingga komunikasi bisa terus berlanjut secara mendalam*
### ⚙️ Antarmuka Pengelolaan Pengaturan
![Tampilan Pengaturan Cunzhi](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Antarmuka pengaturan yang elegan, mendukung manajemen memori, saklar fungsi, pergantian tema, dan pembuatan prompt pintar*

## 🚀 Mulai Menggunakan

### Cara 1: Instalasi Cepat (Direkomendasikan)

**Pengguna macOS:**
```bash
# Instalasi dalam 3 detik, tanpa menunggu kompilasi
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Pemecahan Masalah**: Jika Anda mengalami kesalahan unduhan 404, silakan lakukan langkah-langkah berikut:
>
> ```bash
> # Bersihkan cache tap lama
> brew untap imhuso/cunzhi
> # Instal ulang
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Contoh Kesalahan Umum:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Ini biasanya disebabkan oleh masalah cache versi sebelumnya yang menyebabkan ketidakcocokan nomor versi. Bersihkan tap lalu instal ulang untuk mengatasinya.

**Pengguna Windows/Linux:**
Direkomendasikan untuk menggunakan cara kedua dengan mengunduh secara manual, mudah dan cepat!
### 方式 kedua: Unduh Manual

1. Kunjungi [halaman Rilis](https://github.com/imhuso/cunzhi/releases)
2. Unduh versi yang sesuai dengan sistem Anda:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Setelah diekstrak, tambahkan `寸止` dan `等一下` ke PATH sistem

## ⚡ Mulai Cepat

### Langkah Pertama: Konfigurasi Klien MCP

Tambahkan ke file konfigurasi klien MCP Anda (seperti Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Langkah Kedua: Buka Antarmuka Pengaturan

```bash
# Jalankan perintah pengaturan
Tunggu sebentar
```

### Langkah Ketiga: Konfigurasi Prompt

Di tab "Prompt Referensi" pada antarmuka pengaturan:
1. Lihat prompt yang dihasilkan secara otomatis
2. Klik tombol salin
3. Tambahkan prompt ke AI asisten Anda

### Langkah Keempat: Mulai Menggunakan

Sekarang AI asisten Anda telah memiliki fungsi intersepsi cerdas, manajemen memori, dan interaksi pop-up!

> 💡 **Tips**: Anda dapat memodifikasi prompt yang dihasilkan untuk personalisasi, menciptakan pengalaman interaksi AI yang unik.
## 🤝 Berkontribusi

Cunzhi adalah proyek open source, kami menyambut segala bentuk kontribusi!

### 🐛 Menemukan Masalah?
- [Buat Issue](https://github.com/imhuso/cunzhi/issues) untuk mendeskripsikan masalah
- Sertakan langkah replikasi dan informasi lingkungan

### 💡 Punya Ide Bagus?
- [Mulai Diskusi](https://github.com/imhuso/cunzhi/discussions) untuk berbagi ide kamu
- Ajukan Pull Request untuk mewujudkan fitur baru

### 🛠️ Pengembangan Lokal
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Hubungi Kami

- 🐛 **Laporan Masalah**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Diskusi Fitur**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Suka Proyek Ini**: Berikan kami sebuah Star sebagai dukungan!

## 📄 Lisensi Open Source

MIT License - Bebas digunakan, kontribusi sangat disambut!

---

<div align="center">

**Ucapkan selamat tinggal pada "ejakulasi dini" dalam percakapan AI | Jadikan setiap interaksi bertahan hingga akhir**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Laporkan Bug](https://github.com/imhuso/cunzhi/issues) · [💡 Ajukan Fitur](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---