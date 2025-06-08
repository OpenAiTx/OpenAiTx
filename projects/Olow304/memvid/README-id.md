# Memvid - Memori AI Berbasis Video 🧠📹

**Solusi ringan yang mengubah permainan untuk memori AI dalam skala besar**

[![Versi PyPI](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![Lisensi: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Gaya kode: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid merevolusi manajemen memori AI dengan mengenkode data teks ke dalam video, memungkinkan **pencarian semantik super cepat** di jutaan potongan teks dengan **waktu pengambilan di bawah satu detik**. Tidak seperti database vektor tradisional yang mengonsumsi banyak RAM dan penyimpanan, Memvid mengompresi basis pengetahuan Anda ke file video yang ringkas sambil tetap memberikan akses instan ke setiap informasi.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e

## ✨ Fitur Utama

- 🎥 **Video-sebagai-Database**: Simpan jutaan potongan teks dalam satu file MP4
- 🔍 **Pencarian Semantik**: Temukan konten relevan menggunakan kueri bahasa alami
- 💬 **Chat Bawaan**: Antarmuka percakapan dengan respons yang kontekstual
- 📚 **Dukungan PDF**: Impor langsung dan indeksasi dokumen PDF
- 🚀 **Pengambilan Cepat**: Pencarian di bawah satu detik di dataset besar
- 💾 **Penyimpanan Efisien**: Kompresi 10x dibanding database tradisional
- 🔌 **LLM Plug-and-Play**: Bekerja dengan OpenAI, Anthropic, atau model lokal
- 🌐 **Offline-First**: Tidak butuh internet setelah video dihasilkan
- 🔧 **API Sederhana**: Mulai hanya dengan 3 baris kode

## 🎯 Kasus Penggunaan

- **📖 Perpustakaan Digital**: Indeks ribuan buku dalam satu file video
- **🎓 Konten Edukasi**: Buat memori video yang dapat dicari dari materi kuliah
- **📰 Arsip Berita**: Kompres bertahun-tahun artikel ke dalam database video yang mudah dikelola
- **💼 Pengetahuan Korporasi**: Bangun basis pengetahuan perusahaan yang dapat dicari
- **🔬 Paper Riset**: Pencarian semantik cepat pada literatur ilmiah
- **📝 Catatan Pribadi**: Ubah catatan Anda menjadi asisten AI yang dapat dicari

## 🚀 Kenapa Memvid?

### Inovasi yang Mengubah Permainan
- **Video sebagai Database**: Simpan jutaan potongan teks dalam satu file MP4
- **Pengambilan Instan**: Pencarian semantik di bawah satu detik pada dataset besar
- **Efisiensi Penyimpanan 10x**: Kompresi video secara signifikan mengurangi jejak memori
- **Tanpa Infrastruktur**: Tidak perlu server database, hanya file yang bisa Anda salin ke mana saja
- **Offline-First**: Bekerja sepenuhnya offline setelah video dihasilkan

### Arsitektur Ringan
- **Dependensi Minimal**: Fungsionalitas inti hanya ~1000 baris kode Python
- **Ramah CPU**: Berjalan efisien tanpa memerlukan GPU
- **Portabel**: Satu file video memuat seluruh basis pengetahuan Anda
- **Dapat Distreaming**: Video bisa distream dari penyimpanan cloud

## 📦 Instalasi

### Instalasi Cepat
```bash
pip install memvid
```

### Untuk Dukungan PDF
```bash
pip install memvid PyPDF2
```

### Pengaturan yang Direkomendasikan (Virtual Environment)
```bash
# Buat direktori proyek baru
mkdir my-memvid-project
cd my-memvid-project

# Buat virtual environment
python -m venv venv

# Aktifkan
# Di macOS/Linux:
source venv/bin/activate
# Di Windows:
venv\Scripts\activate

# Instal memvid
pip install memvid

# Untuk dukungan PDF:
pip install PyPDF2
```

## 🎯 Memulai Cepat

### Penggunaan Dasar
```python
from memvid import MemvidEncoder, MemvidChat

# Buat memori video dari potongan teks
chunks = ["Fakta penting 1", "Fakta penting 2", "Detail peristiwa sejarah"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Chat dengan memori Anda
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Apa yang kamu ketahui tentang peristiwa sejarah?")
print(response)
```

### Membuat Memori dari Dokumen
```python
from memvid import MemvidEncoder
import os

# Muat dokumen
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Tambahkan file teks
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Bangun video yang dioptimalkan
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS lebih tinggi = lebih banyak chunk per detik
    frame_size=512  # Frame lebih besar = lebih banyak data per frame
)
```

### Pencarian & Pengambilan Lanjutan
```python
from memvid import MemvidRetriever

# Inisialisasi retriever
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Pencarian semantik
results = retriever.search("algoritma machine learning", top_k=5)
for chunk, score in results:
    print(f"Skor: {score:.3f} | {chunk[:100]}...")

# Mendapatkan jendela konteks
context = retriever.get_context("jelaskan neural networks", max_tokens=2000)
print(context)
```

### Antarmuka Chat Interaktif
```python
from memvid import MemvidInteractive

# Luncurkan UI chat interaktif
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Membuka web interface di http://localhost:7860
```

### Pengujian dengan file_chat.py
Skrip `examples/file_chat.py` menyediakan cara komprehensif untuk menguji Memvid dengan dokumen Anda sendiri:

```bash
# Proses direktori dokumen
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Proses file spesifik
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Gunakan kompresi H.265 (memerlukan Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Chunking kustom untuk dokumen besar
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Muat memori yang sudah ada
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Contoh Lengkap: Chat dengan Buku PDF
```bash
# 1. Buat direktori baru dan siapkan environment
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Di Windows: venv\Scripts\activate

# 2. Instal dependensi
pip install memvid PyPDF2

# 3. Buat book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# File PDF Anda
book_pdf = "book.pdf"  # Ganti dengan path PDF Anda

# Bangun memori video
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Chat dengan buku
api_key = os.getenv("OPENAI_API_KEY")  # Opsional: untuk respons AI
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Jalankan
export OPENAI_API_KEY="your-api-key"  # Opsional
python book_chat.py
```

## 🛠️ Konfigurasi Lanjutan

### Embedding Kustom
```python
from sentence_transformers import SentenceTransformer

# Gunakan model embedding kustom
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Optimasi Video
```python
# Untuk kompresi maksimal
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Frame per detik lebih banyak
    frame_size=256,  # Ukuran frame lebih kecil
    video_codec='h265',  # Kompresi lebih baik
    crf=28  # Kualitas kompresi (lebih rendah = kualitas lebih baik)
)
```

### Pemrosesan Terdistribusi
```python
# Proses dataset besar secara paralel
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Pemecahan Masalah

### Masalah Umum

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Pastikan Anda menggunakan Python yang benar
which python  # Harus menunjukkan path virtual environment Anda
# Jika tidak, aktifkan virtual environment Anda:
source venv/bin/activate  # Pada Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**Masalah API Key LLM**
```bash
# Setel API key Anda (dapatkan di https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Atau pada Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Pemrosesan PDF Besar**
```python
# Untuk PDF sangat besar, gunakan ukuran chunk yang lebih kecil
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Kontribusi

Kami menyambut kontribusi! Silakan lihat [Panduan Kontribusi](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) untuk detailnya.

```bash
# Jalankan tes
pytest tests/

# Jalankan dengan coverage
pytest --cov=memvid tests/

# Format kode
black memvid/
```

## 🆚 Perbandingan dengan Solusi Tradisional

| Fitur | Memvid | Vector DBs | Database Tradisional |
|-------|--------|------------|---------------------|
| Efisiensi Penyimpanan | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Kompleksitas Setup | Sederhana | Kompleks | Kompleks |
| Pencarian Semantik | ✅ | ✅ | ❌ |
| Penggunaan Offline | ✅ | ❌ | ✅ |
| Portabilitas | Berbasis File | Berbasis Server | Berbasis Server |
| Skalabilitas | Jutaan | Jutaan | Miliar |
| Biaya | Gratis | $$$$ | $$$ |


## 📚 Contoh

Lihat direktori [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) untuk:
- Membangun memori dari dump Wikipedia
- Membuat basis pengetahuan pribadi
- Dukungan multi-bahasa
- Pembaruan memori secara real-time
- Integrasi dengan LLM populer

## 🆘 Mendapatkan Bantuan

- 📖 [Dokumentasi](https://github.com/olow304/memvid/wiki) - Panduan lengkap
- 💬 [Diskusi](https://github.com/olow304/memvid/discussions) - Ajukan pertanyaan
- 🐛 [Pelacak Masalah](https://github.com/olow304/memvid/issues) - Laporkan bug
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Bagikan proyek Anda

## 🔗 Tautan

- [Repositori GitHub](https://github.com/olow304/memvid)
- [Paket PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Lisensi

Lisensi MIT - lihat file [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) untuk detailnya.

## 🙏 Penghargaan

Dibuat oleh [Olow304](https://github.com/olow304) dan komunitas Memvid.

Dibangun dengan ❤️ menggunakan:
- [sentence-transformers](https://www.sbert.net/) - Embedding mutakhir untuk pencarian semantik
- [OpenCV](https://opencv.org/) - Computer vision dan pemrosesan video
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Generasi kode QR
- [FAISS](https://github.com/facebookresearch/faiss) - Pencarian kemiripan yang efisien
- [PyPDF2](https://github.com/py-pdf/pypdf) - Ekstraksi teks PDF

Terima kasih khusus kepada semua kontributor yang membantu membuat Memvid menjadi lebih baik!

---

**Siap merevolusi manajemen memori AI Anda? Instal Memvid dan mulai membangun!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---