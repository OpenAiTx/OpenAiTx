# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Ada cinta antar frame, efisiensi berlipat ganda

[//]: # (Easter egg tersembunyi di dalam kode)
<!Double Love: Setiap frame menyimpan frame rate yang belum sempat aku ucapkan -->

[English](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/README.en.md) · 简体中文 · [Pengalaman Online](https://double-love.ahua.space)

</div>

Double Love menyediakan pemrosesan otomatis dan standarisasi metadata slate. Mendukung penggunaan offline. Melalui pemrosesan batch dan lokal, memastikan integrasi mulus dengan Adobe Premiere, Silverstack, dan DTG Slate untuk konsistensi metadata. Secara efektif meningkatkan efisiensi alur kerja pasca-produksi.

## ✨ Fitur Utama

- 🎬 Mendukung alur kerja industri film
- 📝 Penanganan metadata cerdas dan terstandar
- ⚡ Pemrosesan lokal tanpa jeda
- 🧩 Integrasi mulus dengan Adobe Premiere

## 🚀 Mulai Cepat

### Alur Kerja Dasar

1. Pencatatan slate: Gunakan DTG Slate untuk membuat slate interaktif
2. Manajemen data: Impor data slate melalui Silverstack Lab
3. Ekspor file: Hasilkan XML untuk Adobe Premiere Pro
4. Pemrosesan standar: Optimasi cerdas menggunakan Double Love

Contoh:
- Input xml: `UnitA_304_20250127.xml`
- Output xml: `UnitA_304_20250127_Double_LOVE.xml`

### Contoh Detail

#### Optimasi Penamaan File
- Program akan otomatis memproses format nomor adegan, nomor shot, dan nomor take
- Otomatis menambahkan nol di depan angka
- Otomatis menyesuaikan huruf besar/kecil
- Otomatis membersihkan garis bawah yang berlebih

#### Aturan Penamaan Klip

Nama klip yang diproses mengikuti format berikut:
```
{prefix_project}{scene}_{shot}_{take}{camera}{rating}
```

- `prefix`: Prefix kustom (opsional)
- `scene`: Nomor adegan (3 digit, misal 001)
- `shot`: Nomor shot (2 digit, misal 01)
- `take`: Nomor take (2 digit, misal 01)
- `camera`: Identifikasi kamera (huruf kecil, misal a)
- `Rating`: Penilaian (ok/kp/ng)

#### Penanganan Rating
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Informasi DIT
- Otomatis menambahkan informasi DIT: 'DIT: 哆啦Ahua 🌱'
- Jika ingin menghapus, silakan deploy sendiri😁😁

#### Contoh Prefix Kustom

1. Set prefix menjadi "PROJECT_A_":
   - File input: `A304C007_250123G3`
   - File output: `PROJECT_A_004_01_07a_kp`

2. Tanpa prefix:
   - File input: `A304C007_250123G3`
   - File output: `004_01_07a_kp`

#### Contoh Pengaturan Resolusi Sequence

1. Resolusi FHD (default):
   - Lebar: 1920
   - Tinggi: 1080   
2. Resolusi DCI 2K (kustom):
   - Lebar: 2048
   - Tinggi: 1080   

#### Contoh Pemrosesan Batch

1. Upload beberapa file sekaligus:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Setelah diproses akan diperoleh:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Teknologi yang Digunakan

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Dukungan PWA

## 📦 Instalasi & Penggunaan

1. Clone repository

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Install dependencies

```bash
npm install
```

3. Pengembangan lokal

```bash
npm run dev
```

4. Build project

```bash
npm run build
```

## 🔒 Catatan Keamanan

- Semua pemrosesan file dilakukan secara lokal di browser, tidak diunggah ke server
- Mendukung batas ukuran file hingga 50MB
- Hanya mendukung pemrosesan file berformat XML

## 🌈 Catatan Pengembang

### Struktur Proyek

```
Double-Love/
├── src/
│   ├── components/     # Komponen React
│   ├── context/       # React Context
│   ├── utils/         # Fungsi utilitas
│   ├── styles/        # File style
│   └── App.tsx        # Komponen utama aplikasi
├── public/            # Sumber daya statis
└── ...file konfigurasi
```

## 📃 Lisensi

[MIT License](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/LICENSE)

## 🤝 Panduan Kontribusi

Silakan ajukan Issue dan Pull Request!

## 👨‍💻 Penulis

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---