# AI Screenshot Translator

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Pengantar

Alat ini memungkinkan Anda untuk melakukan **operasi screenshot sederhana**, mengirim gambar ke model AI untuk pengenalan dan terjemahan teks, serta menampilkan hasil terjemahan dalam format HTML interaktif pada jendela terpisah.

Alat ini mendukung **pemicu dengan shortcut kustom, manajemen hasil multi-jendela, serta berjalan di system tray**, sangat meningkatkan efisiensi terjemahan dalam pekerjaan dan pembelajaran sehari-hari.

**Fitur alat**: 1. Terjemahan screenshot, peluncuran dengan shortcut; 2. Screenshot patch dan terjemahan, dapat digeser dan diubah ukurannya secara bebas, dapat membuat banyak grup patch terjemahan; 3. Formula dapat dialihkan ke teks asli untuk memudahkan penyalinan; 4. Antarmuka API kustom

**Masalah yang ingin dipecahkan**: 1. Terjemahan dokumen penuh saat ini yang umumnya berat dan tidak efisien; 2. Jika memilih menyalin teks dari PDF lalu ditempel untuk diterjemahkan, kadang blok formula kacau atau tidak bisa disalin; 3. Untuk PDF hasil scan gambar, teks tidak dapat disalin

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Tampilan Jendela

Jendela terjemahan:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Jendela pengaturan:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Penjelasan lebih rinci tentang opsi pengaturan dapat dilihat di dalam perangkat lunak atau di web pada [Petunjuk](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Instalasi

Anda dapat memilih untuk mengunduh source code dan menjalankannya, atau kunjungi halaman [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) untuk mengunduh file executable.

### 1. Clone repositori

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Buat virtual environment dan jalankan

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Rencana Pembaruan

- ~~Menambahkan GUI untuk konfigurasi API, mengoptimalkan logika konfigurasi manual file yaml menjadi otomatis oleh perangkat lunak (v0.3.0 selesai)~~
- Menambahkan sistem penyimpanan gambar dan formula, untuk memudahkan pemanggilan di kemudian hari (diperkirakan selesai di v0.4)
- (Fitur lainnya silakan ajukan di issue atau kontribusi PR)

# Lain-lain

- Ikon perangkat lunak berasal dari [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Terima kasih kepada Gemini 2.5 Flash dan DeepSeek-V3-0324 yang membantu menemukan bug

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---