# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Rencana selanjutnya migrasi ke ente-io/ente, karena saya memerlukan s3 untuk menyimpan foto~~
>
> ente ternyata masih terlalu sedikit fiturnya
>
> Diubah menggunakan juicedata/juicefs untuk me-mount s3

## Ringkasan Proyek

Proyek ini adalah solusi peningkatan kemampuan AI untuk sistem manajemen foto [Immich](https://github.com/immich-app/immich). Fungsi bawaan Immich diperluas terutama melalui komponen-komponen berikut:

- **inference-gateway**: Layanan gateway yang ditulis dengan Go, bertanggung jawab untuk merutekan permintaan machine learning Immich secara cerdas
- **mt-photos-ai**: Layanan AI berbasis Python dan FastAPI, mengintegrasikan RapidOCR dan model cn-clip
- Ekstensi fitur Immich, termasuk pencarian pengenalan teks OCR dan pemrosesan ulang data AI media tunggal, pencampuran skor urutan vektor OCR penuh dan vektor CLIP
- PostgreSQL ditambah zhparser untuk pemotongan kata bahasa Mandarin

## Fitur Utama

### 1. Pengenalan & Pencarian Teks OCR

- Menggunakan RapidOCR untuk mengenali teks pada gambar
- Mendukung pengenalan teks campuran bahasa Mandarin dan Inggris
- Mewujudkan fungsi pencarian berdasarkan konten teks pada gambar

### 2. Pemrosesan Vektor Gambar CLIP

- Berdasarkan model cn-clip untuk pencocokan gambar-teks bahasa Mandarin yang lebih akurat
- Mendukung pencarian semantik untuk meningkatkan akurasi pencarian

### 3. Pemrosesan Ulang Data AI Media Tunggal

- Mendukung regenerasi data OCR untuk satu gambar/video
- Mendukung regenerasi data vektor CLIP untuk satu gambar/video
- Menyediakan kemampuan penyegaran manual untuk hasil pengenalan yang kurang akurat

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

## Penjelasan Komponen

### inference-gateway

Layanan gateway yang ditulis dengan Go, tugas utama:
- Menerima permintaan machine learning dari Immich
- Meneruskan permintaan OCR dan CLIP ke layanan mt-photos-ai sesuai tipe permintaan
- Meneruskan permintaan machine learning lainnya (seperti pengenalan wajah) ke layanan machine learning bawaan Immich
- Menangani otentikasi dan konversi format data

### mt-photos-ai

Layanan AI yang ditulis dengan Python dan FastAPI, menyediakan:
- API pengenalan teks OCR (berbasis RapidOCR)
- API pemrosesan vektor CLIP (berbasis cn-clip)
- Mendukung akselerasi GPU

## Petunjuk Deploy

### Persyaratan Lingkungan

- Docker dan Docker Compose
- NVIDIA GPU (opsional, tapi direkomendasikan untuk percepatan proses)
- Ruang penyimpanan yang cukup

### Penjelasan Konfigurasi

1. **Konfigurasi inference-gateway**

Variabel lingkungan utama:
```
IMMICH_API=http://localhost:3003  # Alamat API Immich
MT_PHOTOS_API=http://localhost:8060  # Alamat layanan mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API key
PORT=8080  # Port gateway
```

2. **Konfigurasi mt-photos-ai**

Variabel lingkungan utama:
```
CLIP_MODEL=ViT-B-16  # Nama model CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Path unduh model
DEVICE=cuda  # atau cpu, perangkat inferensi
HTTP_PORT=8060  # Port layanan
```

### Langkah Deploy

1. Clone repositori:
```bash
git clone https://github.com/username-anda/immich-all-in-one.git
cd immich-all-in-one
```

2. Jalankan layanan:
```bash
docker-compose up -d
```

## Petunjuk Penggunaan

1. **Konfigurasi Immich untuk menggunakan layanan ML kustom**

Di file konfigurasi Immich, arahkan alamat layanan machine learning ke inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Penggunaan pencarian OCR**

- Di kolom pencarian Immich, gunakan prefix `ocr:` untuk pencarian OCR
- Contoh: `ocr:invoice` akan mencari foto yang mengandung kata "invoice" di gambar

3. **Pemrosesan ulang data AI media tunggal**

- Pada halaman detail foto, klik opsi menu
- Pilih "regenerasi data OCR" atau "regenerasi vektor CLIP"
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

Proyek ini bersifat open source berdasarkan lisensi MIT.

## Penghargaan

- [Immich](https://github.com/immich-app/immich) - Solusi backup foto dan video self-hosted open source
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Library OCR lintas platform berbasis PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Model pretraining contrastive multimodal bahasa Mandarin

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---