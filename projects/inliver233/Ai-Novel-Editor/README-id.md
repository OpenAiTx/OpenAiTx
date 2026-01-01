
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# Editor Novel AI

Editor novel berbantuan AI berbasis PyQt6, menyediakan alat penulisan profesional seperti pelengkap cerdas, manajemen proyek, dan organisasi konsep.

## Instalasi

1. Kloning proyek
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Membuat lingkungan virtual
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Instalasi dependensi
```bash
pip install -r requirements.txt
```

4. Menjalankan program
```bash
python src/main.py
```

## Fitur Utama

### Manajemen Proyek
- Struktur dokumen bertingkat (Karya > Bab > Adegan)
- Impor dan ekspor proyek (mendukung format TEXT, MARKDOWN, DOCX, PDF, HTML)
- Pencadangan otomatis dan kontrol versi
- Manajemen multi-proyek

### Fitur Penyelesaian AI
- Tiga mode penyelesaian: penyelesaian otomatis, penyelesaian manual (disarankan tekan tab sekali untuk memicu, tekan tab lagi untuk menerapkan), nonaktifkan penyelesaian
- Tiga mode konteks:
  - Mode Cepat: konteks ringan, respons cepat
  - Mode Seimbang: konteks sedang, keseimbangan kualitas dan kecepatan
  - Mode Global: konteks proyek lengkap, hasil terbaik
- Mendukung berbagai layanan AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, dll.

### Manajemen Kerangka
- Struktur pohon kerangka secara visual
- Seret dan lepas untuk mengurutkan dan mengatur tingkat
- Navigasi dokumen cepat
- Analisis kerangka dan saran optimasi

### Konfigurasi API
- Pusat konfigurasi AI yang terintegrasi
- Konfigurasi preset dari berbagai penyedia layanan
- Fitur pengujian koneksi
- Menyimpan, mengimpor, dan mengekspor skema konfigurasi

### Pengaturan Penyelesaian Cerdas
- Penyesuaian jeda pemicu
- Batas panjang penyelesaian
- Konfigurasi panjang konteks
- Mendukung respons streaming

### Pengeditan Prompt
- Beragam template menulis bawaan
- Template prompt kustom
- Manajemen kategori template
- Konfigurasi template khusus mode

### Fitur Antarmuka
- Tema terang dan gelap
- Tata letak tiga kolom (pohon proyek, editor, panel konsep)
- Sidebar dapat dilipat
- Mode menulis layar penuh
- Mode fokus (kalimat, paragraf, mesin tik, mode zen, mode imersi)

### Pencarian dan Penggantian
- Pencarian teks seluruh proyek
- Dukungan ekspresi reguler
- Fitur penggantian massal
- Opsi pencarian lanjutan

### Manajemen Konsep
- Deteksi otomatis karakter, lokasi, benda
- Manajemen hubungan konsep
- Sistem tag dan kategori
- Penyisipan konsep cepat

## Pintasan Keyboard

- `Ctrl+N`: Proyek baru
- `Ctrl+O`: Buka proyek
- `Ctrl+S`: Simpan dokumen
- `F11`: Mode layar penuh
- `Tab`: Memicu AI melengkapi secara manual (dalam mode manual)
- `Ctrl+F`: Cari
- `Ctrl+H`: Cari dan ganti
- `Ctrl+Shift+H`: Cari dan ganti lanjutan


## Persyaratan Sistem

- Python 3.8+
- PyQt6
- Sistem operasi: Windows, macOS, Linux

## Penulis

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---