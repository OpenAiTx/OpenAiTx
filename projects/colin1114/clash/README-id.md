Akselerasi CDN dan perlindungan keamanan untuk proyek ini disponsori oleh Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Penulis proyek ini adalah colin1114.

# 🚀 Konverter Langganan Clash

Sebuah alat daring yang indah dan kuat untuk mengonversi berbagai tautan langganan proxy menjadi format konfigurasi Clash. Mendukung deployment otomatis melalui Cloudflare Workers & Pages, menyediakan layanan konversi langganan yang cepat dan andal.

## ✨ Fitur Utama

- 🎨 **Antarmuka modern yang menarik** - Menggunakan latar belakang gradasi dan desain kartu
- 🔄 **Dukungan multi-protokol** - Mendukung protokol utama seperti V2Ray, VLESS, Shadowsocks, Trojan, dan lainnya
- ☁️ **Deployment cloud** - Menggunakan Cloudflare Workers untuk akselerasi CDN global
- 📱 **Desain responsif** - Sepenuhnya kompatibel dengan desktop dan perangkat mobile
- ⚡ **Konversi cepat** - Mengonversi tautan langganan ke konfigurasi Clash secara real-time
- 📋 **Salin cerdas** - Mendukung penyalinan konfigurasi YAML yang dihasilkan dengan satu klik, kompatibel dengan berbagai browser
- 📡 **Pembuatan tautan langganan** - Otomatis menghasilkan tautan langganan yang dapat langsung diimpor ke Clash
- 🌐 **Akses YAML daring** - Menyediakan berbagai cara mengakses file YAML:
  - 📡 Tautan langganan: Mendukung pembaruan otomatis klien Clash
  - 🔗 Lihat daring: Lihat isi konfigurasi langsung di browser
  - 💾 Unduh file: Unduh file .yaml ke lokal
  - ⚡ Akses cepat: Tautan unduhan yang disederhanakan
- 🔧 **Dukungan UTF-8** - Mendukung penuh nama node dan konfigurasi berbahasa Mandarin
- 🆓 **Sepenuhnya gratis** - Berdasarkan layanan gratis Cloudflare, tanpa batasan penggunaan

## 📁 Struktur Proyek

```
clash/
├── index.html              # Halaman frontend
├── worker.js               # Kode backend Cloudflare Worker
├── wrangler.jsonc          # File konfigurasi Wrangler
├── _headers                # Konfigurasi HTTP header Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Konfigurasi deployment GitHub Actions
├── README.md              # Dokumen penjelasan proyek
└── package.json           # File konfigurasi proyek
```

## 🚀 Mulai Cepat

### Cara 1: Jalankan Secara Lokal

1. **Kloning proyek**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Mulai server lokal**
   ```bash
   # Menggunakan Python
   python -m http.server 8000
   
   # Atau menggunakan Node.js
   npx serve .
   ```

3. **Akses aplikasi**
   - Buka browser dan akses `http://localhost:8000`
   - Dalam lingkungan lokal akan muncul konfigurasi contoh

### Cara 2: Deployment Cloudflare Workers

#### Langkah 1: Buat Worker

1. Kunjungi [Cloudflare Workers](https://workers.cloudflare.com/)
2. Daftar/masuk ke akun Cloudflare
3. Klik "Create a Worker"
4. Salin seluruh kode dari `worker.js` ke editor
5. Klik "Save and Deploy"

#### Langkah 2: Deployment menggunakan Wrangler CLI

```bash
# Instal Wrangler CLI
npm install -g wrangler

# Masuk ke Cloudflare
wrangler login

# Deploy Worker
npm run deploy:worker
```

#### Langkah 3: Konfigurasi domain (opsional)

1. Tambahkan domain kustom pada pengaturan Worker
2. Atau gunakan domain default yang disediakan Cloudflare

### Cara 3: Deployment Cloudflare Pages

#### Opsi A: Integrasi GitHub (Direkomendasikan)

1. **Siapkan repositori**
   - Push kode ke repositori GitHub
   - Pastikan semua file yang diperlukan sudah ada
2. **Membuat Proyek Pages**
   - Kunjungi [Cloudflare Pages](https://pages.cloudflare.com/)
   - Hubungkan repositori GitHub Anda
   - Pilih repositori proyek

3. **Pengaturan Build**
   - Perintah build: Biarkan kosong atau `echo "No build required"`
   - Direktori output build: `/` (direktori root)
   - Variabel lingkungan: Tidak perlu diatur

#### Opsi B: Unggah Langsung

```bash
# Deploy menggunakan Wrangler Pages
npm run deploy:pages
```

## 🛠️ Arsitektur Teknis

### Teknologi Frontend
- **HTML5** - Bahasa markup modern
- **CSS3** - Desain responsif dan efek animasi
- **Vanilla JavaScript** - Interaksi frontend ringan

### Teknologi Backend
- **Cloudflare Workers** - Platform komputasi edge
- **Web APIs** - Standar Fetch API dan penanganan respons

### Format Protokol yang Didukung
- **VMess** - Protokol standar V2Ray
- **VLESS** - Protokol ringan V2Ray (mendukung Reality)
- **Shadowsocks** - Protokol proxy klasik
- **Trojan** - Protokol proxy baru

### Endpoint API
- `GET /` - Halaman utama
- `POST /convert` - API konversi langganan
- `GET /clash/{config-id}` - Mengambil file konfigurasi YAML (tautan langganan)
- `GET /yaml/{config-id}` - Mengunduh file konfigurasi YAML
- `OPTIONS /*` - Permintaan preflight CORS

## 📖 Panduan Penggunaan

### Penggunaan Dasar

1. **Masukkan Tautan Langganan**
   - Tempelkan tautan langganan proxy Anda ke kolom input
   - Mendukung tautan langganan yang dienkode Base64

2. **Atur Nama Konfigurasi**
   - Opsional untuk mengatur nama khusus file konfigurasi
   - Secara default bernama "My Clash Config"

3. **Konversi Konfigurasi**
   - Klik tombol "Konversi Langganan"
   - Tunggu hingga proses selesai

4. **Gunakan Konfigurasi**
   - Salin konfigurasi YAML yang dihasilkan
   - Impor ke dalam aplikasi Clash client

5. **Gunakan Tautan Langganan (Disarankan)**
   - Salin tautan langganan yang dihasilkan
   - Tambahkan langganan pada aplikasi Clash client
   - Konfigurasi akan tersinkronisasi otomatis, tanpa perlu pembaruan manual

### Konfigurasi Lanjutan

Konfigurasi Clash yang dihasilkan memiliki fitur berikut:

- **Kebijakan Grup Proxy**
  - 🚀 Pemilihan node - Pilih proxy secara manual
  - ♻️ Pemilihan otomatis - Uji latensi dan pilih otomatis
  - 🎯 Koneksi langsung global - Koneksi langsung

- **Konfigurasi DNS**
  - DNS resolver diaktifkan
  - Mendukung mode fake-ip
  - DNS split untuk dalam dan luar negeri

- **Aturan Routing**
  - Alamat lokal koneksi langsung
  - IP domestik koneksi langsung
  - Lalu lintas lain melalui proxy

## 🔧 Pemecahan Masalah Deployment

### Masalah Umum

#### 1. Wrangler Tidak Menemukan Entry Point
**Pesan Error**: `Missing entry-point to Worker script`

**Solusi**: 
- Pastikan terdapat file `wrangler.jsonc` di direktori root proyek
- Periksa apakah field `main` di `wrangler.jsonc` mengarah ke `worker.js`

#### 2. Deployment GitHub Actions Gagal
**Solusi**:
- Tambahkan Secrets berikut di pengaturan repositori GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID Akun Cloudflare

#### 3. Kegagalan Build Pages
**Solusi**:
- Atur perintah build menjadi kosong atau `echo "No build required"`
- Pastikan direktori output build diatur ke `/`

### Penjelasan File Konfigurasi Deploy

- **`wrangler.jsonc`**: Konfigurasi Wrangler CLI untuk deploy Worker
- **`_headers`**: Konfigurasi header HTTP Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Konfigurasi deploy otomatis GitHub Actions

## 🔧 Konfigurasi Kustom

### Mengubah Grup Proxy

Anda dapat mengedit fungsi `convertToClash` di `worker.js` untuk menyesuaikan grup proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Pilihan Node',
    type: 'select',
    proxies: ['♻️ Pilih Otomatis', '🎯 Direct Global', ...proxyNames]
  },
  // Tambahkan lebih banyak grup proxy...
]
```

### Aturan Routing Kustom

Ubah array `rules` untuk menambahkan aturan routing kustom:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Pilihan Node',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Tambahkan lebih banyak aturan...
]
```

## 📊 Fitur Performa

- **CDN Global** - Cloudflare memiliki node edge di seluruh dunia
- **Respons Cepat** - Rata-rata waktu respons < 100ms
- **Ketersediaan Tinggi** - 99.9% ketersediaan layanan
- **Kuota Gratis** - 100.000 permintaan per hari

## 🔒 Penjelasan Keamanan

- **Privasi Data** - Data langganan hanya digunakan selama proses konversi, tidak disimpan
- **Enkripsi HTTPS** - Semua komunikasi dienkripsi melalui HTTPS
- **Transparan & Open Source** - Kode sumber lengkap terbuka, dapat diaudit sendiri

## 🤝 Panduan Kontribusi

Silakan ajukan Issue dan Pull Request!

1. Fork repositori ini
2. Buat branch fitur (`git checkout -b feature/AmazingFeature`)
3. Commit perubahan (`git commit -m 'Add some AmazingFeature'`)
4. Push ke branch (`git push origin feature/AmazingFeature`)
5. Buat Pull Request

## 📝 Catatan Rilis

### v1.1.0
- ✅ Menambah dukungan protokol VLESS (termasuk Reality security transport)
- ✅ Peningkatan kompatibilitas protokol

### v1.0.0
- ✅ Fitur konversi langganan dasar
- ✅ Antarmuka pengguna yang menarik
- ✅ Dukungan Cloudflare Workers
- ✅ Dukungan multi-protokol (VMess, Shadowsocks, Trojan)
- ✅ Desain responsif
- ✅ Fitur salin sekali klik

## 📞 Dukungan & Masukan

Jika Anda mengalami masalah atau memiliki saran selama penggunaan, silakan:

1. Baca dokumen README ini
2. Ajukan [Issue](../../issues)
3. Mulai [Discussion](../../discussions)

## 📄 Lisensi

Proyek ini menggunakan Lisensi MIT - lihat detail di file [LICENSE](LICENSE)

## 🙏 Ucapan Terima Kasih

- [Cloudflare Workers](https://workers.cloudflare.com/) - Platform komputasi edge
- [Clash](https://github.com/Dreamacro/clash) - Klien proxy yang luar biasa
- Semua kontributor dan pengguna atas dukungannya

---
⭐ Jika proyek ini bermanfaat untukmu, silakan berikan sebuah Star!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---