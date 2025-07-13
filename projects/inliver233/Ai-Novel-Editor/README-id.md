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
# AI Novel Editor

Editor novel berbantuan AI berbasis PyQt6, menyediakan alat penulisan profesional seperti pelengkapan cerdas, manajemen proyek, dan organisasi konsep.

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
Menggunakan uv
```bash
uv venv -p 3.11
```
3. Instalasi Dependensi
```bash
pip install -r requirements.txt
```
Menggunakan uv
```bash
uv sync
```


4. Menjalankan Program
```bash
python -m src
```

## Fitur Utama

### Manajemen Proyek
- Struktur dokumen hierarkis (Karya > Bab > Adegan)
- Impor dan ekspor proyek (mendukung format TEXT, MARKDOWN, DOCX, PDF, HTML)
- Pencadangan otomatis dan kontrol versi
- Manajemen multi proyek
### Fitur Pelengkapan AI
- Tiga mode pelengkapan: Pelengkapan otomatis, pelengkapan manual (disarankan tekan tombol tab sekali untuk memicu, tekan sekali lagi untuk menerapkan pelengkapan), nonaktifkan pelengkapan
- Tiga mode konteks:
  - Mode Cepat: Konteks ringan, respons cepat
  - Mode Seimbang: Konteks sedang, keseimbangan antara kualitas dan kecepatan
  - Mode Global: Konteks proyek lengkap, hasil terbaik
- Mendukung berbagai layanan AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, dan lainnya

### Manajemen Outline
- Struktur pohon outline yang dapat divisualisasikan
- Pengurutan drag-and-drop dan penyesuaian level
- Navigasi cepat dokumen
- Analisis outline dan saran optimalisasi

### Konfigurasi API
- Pusat konfigurasi AI yang terintegrasi
- Konfigurasi preset dari berbagai penyedia layanan
- Fitur pengujian koneksi
- Penyimpanan, impor dan ekspor skema konfigurasi
### Pengaturan Pelengkapan Cerdas
- Penyesuaian penundaan pemicu
- Batas panjang pelengkapan
- Konfigurasi panjang konteks
- Dukungan respons streaming

### Pengeditan Prompt
- Beragam template penulisan bawaan
- Template prompt yang dapat dikustomisasi
- Manajemen kategori template
- Konfigurasi template khusus mode

### Fitur Antarmuka
- Tema terang dan gelap
- Tata letak tiga kolom (pohon proyek, editor, panel konsep)
- Sidebar yang dapat dilipat
- Mode penulisan layar penuh
- Mode fokus (kalimat, paragraf, mesin tik, mode zen, mode imersif)

### Pencarian dan Penggantian
- Pencarian teks seluruh proyek
- Dukungan ekspresi reguler
- Fitur penggantian massal
- Opsi pencarian lanjutan

### Manajemen Konsep
- Deteksi otomatis peran, lokasi, dan objek
- Manajemen hubungan konsep
- Sistem label dan klasifikasi
- Penyisipan konsep cepat

## Pintasan Keyboard

- `Ctrl+N`: Proyek baru
- `Ctrl+O`: Buka proyek
- `Ctrl+S`: Simpan dokumen
- `F11`: Mode layar penuh
- `Tab`: Memicu pelengkapan AI secara manual (dalam mode manual)
- `Ctrl+F`: Cari
- `Ctrl+H`: Cari dan ganti
- `Ctrl+Shift+H`: Cari dan ganti lanjutan
## Persyaratan Sistem

- Python 3.8+
- PyQt6
- Sistem Operasi: Windows, macOS, Linux

## Penulis

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---