
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

Akselerasi CDN dan perlindungan keamanan untuk proyek ini disponsori oleh Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Penulis proyek ini adalah colin1114.

# 🚀 Konverter Langganan Clash

Sebuah alat online yang indah dan sangat fungsional, digunakan untuk mengonversi berbagai tautan langganan proxy ke format konfigurasi Clash. Mendukung penerapan otomatis melalui Cloudflare Workers & Pages, menyediakan layanan konversi langganan yang cepat dan andal.

## ✨ Fitur Utama

- 🎨 **Antarmuka modern yang menarik** - Menggunakan latar belakang gradasi dan desain kartu
- 🔄 **Dukungan multi-protokol** - Mendukung protokol utama seperti V2Ray, VLESS, Shadowsocks, Trojan
- ☁️ **Deploy di cloud** - Memanfaatkan Cloudflare Workers untuk akselerasi CDN global
- 📱 **Desain responsif** - Cocok sempurna untuk desktop dan perangkat mobile
- ⚡ **Konversi cepat** - Mengubah tautan langganan menjadi konfigurasi Clash secara real-time
- 📋 **Salin pintar** - Mendukung salin konfigurasi YAML sekali klik, kompatibel dengan berbagai browser
- 📡 **Pembuatan tautan langganan** - Otomatis menghasilkan tautan langganan yang bisa langsung diimpor ke Clash
- 🌐 **Akses YAML online** - Menyediakan berbagai cara akses file YAML:
  - 📡 Tautan langganan: Mendukung pembaruan otomatis di klien Clash
  - 🔗 Lihat online: Langsung lihat isi konfigurasi di browser
  - 💾 Unduh file: Unduh file .yaml ke perangkat lokal
  - ⚡ Akses cepat: Tautan unduhan yang disederhanakan
- 🔧 **Dukungan UTF-8** - Mendukung nama node dan konfigurasi dalam bahasa Mandarin dengan sempurna
- 🆓 **Gratis sepenuhnya** - Berdasarkan layanan gratis Cloudflare, tanpa batasan penggunaan

## 📁 Struktur Proyek

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Mulai Cepat

### Metode 1: Jalankan Secara Lokal

1. **Kloning Proyek**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Jalankan server lokal**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Mengakses Aplikasi**
   - Buka browser dan akses `http://localhost:8000`
   - Pada lingkungan lokal akan menampilkan konfigurasi contoh

### Metode Kedua: Deploy Cloudflare Workers

#### Langkah 1: Membuat Worker

1. Kunjungi [Cloudflare Workers](https://workers.cloudflare.com/)
2. Daftar/Login ke akun Cloudflare
3. Klik "Create a Worker"
4. Salin seluruh kode dari `worker.js` ke editor
5. Klik "Save and Deploy"

#### Langkah 2: Deploy dengan Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Langkah 3: Konfigurasi Nama Domain (Opsional)

1. Tambahkan nama domain khusus di pengaturan Worker
2. Atau gunakan nama domain default yang disediakan oleh Cloudflare

### Metode Ketiga: Deploy Cloudflare Pages

#### Opsi A: Integrasi GitHub (Direkomendasikan)

1. **Siapkan Repository**
   - Push kode ke repository GitHub
   - Pastikan semua file yang diperlukan sudah ada

2. **Buat Proyek Pages**
   - Kunjungi [Cloudflare Pages](https://pages.cloudflare.com/)
   - Hubungkan ke repository GitHub kamu
   - Pilih repository proyek

3. **Pengaturan Build**
   - Perintah build: kosongkan atau `echo "No build required"`
   - Direktori output build: `/` (root)
   - Variabel lingkungan: tidak perlu disetel

#### Opsi B: Upload Langsung

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Arsitektur Teknologi

### Stack Teknologi Frontend
- **HTML5** - Bahasa markup modern
- **CSS3** - Desain responsif dan efek animasi
- **Vanilla JavaScript** - Interaksi frontend yang ringan

### Stack Teknologi Backend
- **Cloudflare Workers** - Platform komputasi edge
- **Web APIs** - Standar Fetch API dan penanganan respons

### Format Protokol yang Didukung
- **VMess** - Protokol standar V2Ray
- **VLESS** - Protokol ringan V2Ray (mendukung Reality)
- **Shadowsocks** - Protokol proxy klasik
- **Trojan** - Protokol proxy yang sedang berkembang

### Endpoint API
- `GET /` - Halaman utama
- `POST /convert` - API konversi langganan
- `GET /clash/{config-id}` - Mengambil file konfigurasi YAML (tautan langganan)
- `GET /yaml/{config-id}` - Mengunduh file konfigurasi YAML
- `OPTIONS /*` - Permintaan preflight CORS

## 📖 Panduan Penggunaan

### Penggunaan Dasar

1. **Masukkan Tautan Langganan**
   - Tempelkan tautan langganan proxy kamu ke dalam kotak input
   - Mendukung tautan langganan yang dienkode Base64

2. **Atur Nama Konfigurasi**
   - Secara opsional, atur nama khusus untuk file konfigurasi
   - Default adalah "My Clash Config"

3. **Konversi Konfigurasi**
   - Klik tombol "Konversi Langganan"
   - Tunggu hingga proses konversi selesai
4. **Menggunakan Konfigurasi**
   - Salin konfigurasi YAML yang dihasilkan
   - Impor ke dalam aplikasi Clash untuk digunakan

5. **Menggunakan Tautan Langganan (Disarankan)**
   - Salin tautan langganan yang dihasilkan
   - Tambahkan langganan pada aplikasi Clash
   - Konfigurasi akan sinkron otomatis, tanpa perlu pembaruan manual

### Konfigurasi Lanjutan

Konfigurasi Clash yang dihasilkan mencakup fitur berikut:

- **Kebijakan Grup Proxy**
  - 🚀 Pilih Node - Pilih proxy secara manual
  - ♻️ Pilih Otomatis - Pilih otomatis berdasarkan pengujian latensi
  - 🎯 Koneksi Global Langsung - Hubungkan langsung

- **Konfigurasi DNS**
  - Mengaktifkan resolusi DNS
  - Mendukung mode fake-ip
  - DNS terpisah domestik dan luar negeri

- **Aturan Routing**
  - Alamat lokal koneksi langsung
  - IP domestik koneksi langsung
  - Trafik lainnya melalui proxy

## 🔧 Pemecahan Masalah Deploy

### Permasalahan Umum

#### 1. Wrangler tidak menemukan entry point
**Pesan Error**: `Missing entry-point to Worker script`

**Solusi**:
- Pastikan file `wrangler.jsonc` ada di direktori root proyek
- Periksa apakah field `main` pada `wrangler.jsonc` mengarah ke `worker.js`


#### 2. GitHub Actions Gagal Deploy
**Solusi**:
- Tambahkan Secrets berikut di pengaturan repositori GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID Akun Cloudflare

#### 3. Pages Gagal Build
**Solusi**:
- Atur perintah build menjadi kosong atau `echo "No build required"`
- Pastikan direktori output build diatur ke `/`

### Penjelasan File Konfigurasi Deploy

- **`wrangler.jsonc`**: Konfigurasi Wrangler CLI untuk deploy Worker
- **`_headers`**: Konfigurasi header HTTP Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Konfigurasi deploy otomatis GitHub Actions

## 🔧 Konfigurasi Kustom

### Modifikasi Grup Proxy

Anda dapat mengedit fungsi `convertToClash` pada `worker.js` untuk mengkustom grup proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Aturan Routing Kustom

Ubah array `rules` untuk menambahkan aturan routing kustom:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Fitur Kinerja

- **CDN Global** - Cloudflare mencakup node edge di seluruh dunia
- **Respon Cepat** - Waktu respon rata-rata < 100ms
- **Ketersediaan Tinggi** - Ketersediaan layanan 99,9%
- **Kuota Gratis** - 100.000 permintaan per hari

## 🔒 Keterangan Keamanan

- **Privasi Data** - Data langganan hanya digunakan saat proses konversi, tidak disimpan
- **Enkripsi HTTPS** - Semua komunikasi dienkripsi melalui HTTPS
- **Transparansi Open Source** - Kode sumber lengkap tersedia dan dapat diaudit sendiri

## 🤝 Panduan Kontribusi

Silakan kirim Issue dan Pull Request!

1. Fork repositori ini
2. Buat branch fitur (`git checkout -b feature/AmazingFeature`)
3. Commit perubahan (`git commit -m 'Add some AmazingFeature'`)
4. Push ke branch (`git push origin feature/AmazingFeature`)
5. Buat Pull Request

## 📝 Catatan Pembaruan

### v1.1.0
- ✅ Menambahkan dukungan protokol VLESS (termasuk transportasi aman Reality)
- ✅ Meningkatkan kompatibilitas protokol

### v1.0.0
- ✅ Fitur konversi langganan dasar
- ✅ Antarmuka pengguna yang menarik
- ✅ Dukungan Cloudflare Workers
- ✅ Dukungan multi-protokol (VMess, Shadowsocks, Trojan)
- ✅ Desain responsif
- ✅ Fitur salin sekali klik

## 📞 Dukungan dan Umpan Balik

Jika Anda mengalami masalah atau memiliki saran selama penggunaan, silakan:

1. Lihat dokumen README ini
2. Kirimkan [Issue](../../issues)
3. Mulai [Discussion](../../discussions)

## 📄 Lisensi

Proyek ini menggunakan lisensi MIT - lihat file [LICENSE](LICENSE) untuk detailnya

## 🙏 Ucapan Terima Kasih

- [Cloudflare Workers](https://workers.cloudflare.com/) - Menyediakan platform komputasi edge
- [Clash](https://github.com/Dreamacro/clash) - Klien proxy yang unggul
- Dukungan dari semua kontributor dan pengguna

---

⭐ Jika proyek ini bermanfaat untuk Anda, mohon berikan Star!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---