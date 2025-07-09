# AI Novel Editor

Editor novel berbasis AI dengan PyQt6, menyediakan alat bantu penulisan profesional seperti pelengkapan cerdas, manajemen proyek, dan organisasi konsep.

## Instalasi

1. Kloning proyek
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Buat lingkungan virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Instal dependensi
```bash
pip install -r requirements.txt
```
4. Menjalankan Program
```bash
python src/main.py
```

## Fitur Utama

### Manajemen Proyek
- Struktur dokumen hierarkis (Karya > Bab > Adegan)
- Impor dan ekspor proyek (mendukung format TEXT, MARKDOWN, DOCX, PDF, HTML)
- Pencadangan otomatis dan kontrol versi
- Manajemen multi-proyek

### Fitur Pelengkapan AI
- Tiga mode pelengkapan: pelengkapan otomatis, pelengkapan manual (disarankan tekan tab sekali untuk memicu, tekan tab lagi untuk menerapkan pelengkapan), nonaktifkan pelengkapan
- Tiga mode konteks:
  - Mode Cepat: konteks ringan, respons cepat
  - Mode Seimbang: konteks sedang, keseimbangan kualitas dan kecepatan
  - Mode Global: konteks proyek lengkap, hasil terbaik
- Mendukung berbagai layanan AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, dan lain-lain
### Manajemen Outline
- Struktur pohon outline yang dapat divisualisasikan
- Pengurutan dan penyesuaian level melalui drag-and-drop
- Navigasi dokumen secara cepat
- Analisis outline dan saran optimalisasi

### Konfigurasi API
- Pusat konfigurasi AI yang terintegrasi
- Konfigurasi preset dari berbagai penyedia layanan
- Fitur pengujian koneksi
- Penyimpanan konfigurasi serta impor dan ekspor

### Pengaturan Auto-Complete Pintar
- Penyesuaian delay pemicu
- Batas panjang auto-complete
- Konfigurasi panjang konteks
- Dukungan respons streaming

### Penyuntingan Prompt
- Berbagai template penulisan bawaan
- Template prompt yang dapat dikustomisasi
- Manajemen kategori template
- Konfigurasi template spesifik mode
### Fitur Antarmuka
- Tema terang dan gelap
- Tata letak tiga kolom (pohon proyek, editor, panel konsep)
- Sidebar yang dapat dilipat
- Mode penulisan layar penuh
- Mode fokus (kalimat, paragraf, mesin ketik, mode zen, mode imersif)

### Pencarian dan Penggantian
- Pencarian teks seluruh proyek
- Dukungan ekspresi reguler
- Fungsi penggantian massal
- Opsi pencarian lanjutan

### Manajemen Konsep
- Deteksi otomatis karakter, lokasi, barang
- Manajemen hubungan konsep
- Sistem label dan klasifikasi
- Penyisipan konsep cepat

## Pintasan Keyboard
- `Ctrl+N`: Buat proyek baru
- `Ctrl+O`: Buka proyek
- `Ctrl+S`: Simpan dokumen
- `F11`: Mode layar penuh
- `Tab`: Pemicu AI autocompletion secara manual (dalam mode manual)
- `Ctrl+F`: Cari
- `Ctrl+H`: Cari dan ganti
- `Ctrl+Shift+H`: Cari dan ganti tingkat lanjut


## Persyaratan Sistem

- Python 3.8+
- PyQt6
- Sistem operasi: Windows, macOS, Linux

## Penulis

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---