# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Rencana selanjutnya migrasi ke ente-io/ente, karena saya membutuhkan s3 untuk menyimpan foto~~
> 
> ente masih terlalu minim fitur
> 
> Diganti menggunakan juicedata/juicefs untuk mounting s3

## Ringkasan Proyek

Proyek ini adalah solusi peningkatan kemampuan AI untuk sistem manajemen foto [Immich](https://github.com/immich-app/immich). Fungsi native Immich diperluas melalui komponen berikut:

- **inference-gateway**: Layanan gateway berbasis Go, bertanggung jawab untuk pembagian cerdas permintaan machine learning dari Immich
- **mt-photos-ai**: Layanan AI berbasis Python dan FastAPI, terintegrasi dengan RapidOCR dan model cn-clip
- Perluasan fungsi Immich, termasuk pencarian teks OCR, pemrosesan ulang data AI media tunggal, pengurutan campuran vektor fulltext OCR dan skor vektor CLIP
- PostgreSQL ditambah dengan zhparser untuk segmentasi kata bahasa Mandarin

## Fitur Utama

### 1. Pengenalan dan Pencarian Teks OCR

- Menggunakan RapidOCR untuk mengenali teks dalam gambar
- Mendukung pengenalan teks campuran bahasa Mandarin dan Inggris
- Mewujudkan fungsi pencarian berdasarkan konten teks pada gambar

### 2. Pemrosesan Vektor Gambar CLIP

- Berdasarkan model cn-clip untuk pencocokan gambar-teks bahasa Mandarin yang lebih akurat
- Mendukung pencarian semantik, meningkatkan akurasi pencarian

### 3. Pemrosesan Ulang Data AI Media Tunggal

- Mendukung regenerasi data OCR pada gambar/video tunggal
- Mendukung regenerasi data vektor CLIP pada gambar/video tunggal
- Memberikan kemampuan refresh manual jika hasil pengenalan tidak akurat

## Arsitektur Sistem

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Komponen Penjelasan Detail

### inference-gateway

Layanan gateway yang ditulis dengan bahasa Go, tugas utamanya:
- Menerima permintaan machine learning dari Immich
- Meneruskan permintaan OCR dan CLIP ke layanan mt-photos-ai sesuai jenis permintaan
- Meneruskan permintaan machine learning lain (seperti pengenalan wajah) ke layanan machine learning asli Immich
- Menangani otentikasi dan konversi format data

### mt-photos-ai

Layanan AI yang ditulis dengan Python dan FastAPI, menyediakan:
- API pengenalan teks OCR (berbasis RapidOCR)
- API pemrosesan vektor CLIP (berbasis cn-clip)
- Mendukung akselerasi GPU

## Petunjuk Deploy

### Persyaratan Lingkungan

- Docker dan Docker Compose
- NVIDIA GPU (opsional, tetapi disarankan untuk mempercepat pemrosesan)
- Ruang penyimpanan yang cukup

### Petunjuk Konfigurasi

1. **Konfigurasi inference-gateway**

Variabel lingkungan utama:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Konfigurasi mt-photos-ai**

Variabel lingkungan utama:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Langkah-langkah Deploy

1. Klon repositori:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Memulai layanan:

```bash
docker-compose up -d
```
## Petunjuk Penggunaan

1. **Konfigurasikan Immich untuk menggunakan layanan ML kustom**

Pada file konfigurasi Immich, arahkan alamat layanan machine learning ke inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Penggunaan Pencarian OCR**

- Gunakan awalan `ocr:` di bilah pencarian Immich untuk melakukan pencarian OCR
- Contoh: `ocr:invoice` akan mencari foto yang mengandung kata "invoice" di dalam gambar

3. **Pemrosesan Ulang Data AI pada Media Tunggal**

- Pada halaman detail foto, klik opsi menu
- Pilih "Regenerasi Data OCR" atau "Regenerasi Vektor CLIP"
- Sistem akan memproses ulang data AI untuk foto tersebut

## Panduan Pengembangan

### inference-gateway (Go)

Kompilasi dan jalankan:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Pengaturan lingkungan pengembangan:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Lisensi

Proyek ini bersifat open source berdasarkan Lisensi MIT.

## Penghargaan

- [Immich](https://github.com/immich-app/immich) - Solusi pencadangan foto dan video self-hosted open source
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Pustaka OCR lintas platform berbasis PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Model pra-latih pembelajaran perbandingan multimodal bahasa Tiongkok



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---