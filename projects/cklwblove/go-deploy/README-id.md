# Go-Deploy Alat Deploy

Sebuah alat otomatisasi deploy yang dikembangkan berbasis bahasa Go, mendukung upload hasil build lokal ke server remote melalui protokol SFTP.

## Fitur Utama

- ✅ **Transfer Aman**: Menggunakan protokol SFTP, transmisi dienkripsi berbasis SSH
- ✅ **Sinkronisasi Direktori**: Upload seluruh struktur direktori secara rekursif, menjaga hirarki file
- ✅ **Pembuatan Otomatis**: Membuat struktur direktori remote secara otomatis
- ✅ **Penyesuaian Path Otomatis**: Menghitung path lokal secara otomatis berdasarkan lokasi file executable, tidak perlu peduli direktori eksekusi
- ✅ **Dukungan File Konfigurasi**: Mendukung file konfigurasi JSON, memudahkan pengelolaan konfigurasi berbagai environment
- ✅ **Pengecualian File**: Mendukung pola wildcard untuk mengecualikan file yang tidak perlu di-upload
- ✅ **Backup Otomatis**: Dapat melakukan backup file remote sebelum upload
- ✅ **Mekanisme Retry**: Secara otomatis mencoba ulang saat upload gagal, meningkatkan tingkat keberhasilan
- ✅ **Statistik Detail**: Menampilkan jumlah file yang di-upload, ukuran transfer, waktu yang dibutuhkan, dan kecepatan transfer
- ✅ **Tampilan Progres**: Menampilkan progres upload dan informasi file secara real-time
- ✅ **Penanganan Error**: Penanganan error yang lengkap dan output log

## Persyaratan Sistem

- Go 1.18 atau versi lebih tinggi
- Server target mendukung protokol SSH/SFTP

## Petunjuk Instalasi

### 1. Clone Proyek

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Inisialisasi Modul Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Instalasi Dependensi

Program akan secara otomatis mengunduh dependensi berikut:

- `github.com/pkg/sftp` - Klien SFTP
- `golang.org/x/crypto/ssh` - Klien SSH

## Penjelasan Konfigurasi

Program mendukung dua cara konfigurasi:

### 1. Menggunakan File Konfigurasi (Disarankan)

Salin `config.example.json` menjadi `config.json` lalu modifikasi konfigurasinya:

```bash
cp config.example.json config.json
```

Kemudian edit `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Penjelasan Konfigurasi

**Konfigurasi server**:

- `host`: Alamat server SSH
- `port`: Port SSH, biasanya 22
- `username`: Nama pengguna SSH
- `password`: Password SSH (disarankan gunakan autentikasi key untuk production)
- `timeout`: Waktu tunggu koneksi (detik)

**Konfigurasi paths**:

- `local`: Path direktori lokal, mendukung path relatif maupun absolut
- `remote`: Path direktori remote, harus path absolut

**Konfigurasi options**:

- `backup`: Apakah melakukan backup file remote sebelum upload
- `backup_suffix`: Sufiks file backup, dapat dikustomisasi; jika file backup tidak ada maka backup dilewati
- `exclude_patterns`: Pola pengecualian file, mendukung wildcard
- `max_retries`: Jumlah maksimal retry saat upload gagal
- `chunk_size`: Ukuran blok transfer file (byte, belum diimplementasikan)

### 2. Konfigurasi Default (Mode Kompatibilitas)

Jika tidak ada file `config.json`, program akan menggunakan konfigurasi default internal, memastikan kompatibilitas ke belakang.

#### Prioritas File Konfigurasi

1. **File konfigurasi yang ditentukan di command line**: file yang ditentukan dengan parameter `--config`
2. **File konfigurasi default**: `config.json` di direktori saat ini
3. **Konfigurasi default internal**: jika keduanya tidak ada, menggunakan konfigurasi bawaan program

#### Aturan Penanganan Path

- **Path file konfigurasi**:

  - Path relatif: berbasis direktori file executable
  - Path absolut: langsung menggunakan path yang ditentukan
- **Path direktori lokal**:

  - Path relatif: berbasis direktori file executable
  - Path absolut: langsung menggunakan path yang ditentukan

## Petunjuk Menjalankan

### Parameter Command Line

Program mendukung parameter command line berikut:

```bash
# Tampilkan bantuan
./deploy --help

# Tampilkan info versi  
./deploy --version

# Menggunakan file konfigurasi default config.json
./deploy

# Menggunakan file konfigurasi yang ditentukan
./deploy --config prod.json

# Menggunakan file konfigurasi dengan path absolut
./deploy --config /path/to/config.json
```

### Menjalankan di Lingkungan Development

```bash
# Menggunakan konfigurasi default
go run main.go

# Menggunakan file konfigurasi tertentu
go run main.go --config test.json

# Tampilkan bantuan
go run main.go --help
```

### Menjalankan Setelah Kompilasi

```bash
# Kompilasi
go build -o deploy main.go

# Jalankan dengan konfigurasi default
./deploy

# Jalankan dengan file konfigurasi tertentu
./deploy --config prod.json
```

## Petunjuk Packaging

### 1. Packaging di Platform Lokal

```bash
# Kompilasi file executable untuk platform saat ini
go build -o deploy main.go
```

### 2. Packaging Cross-Platform

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64-bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Optimasi Paket (Memperkecil Ukuran File)

```bash
# Menghapus informasi debug dan simbol
go build -ldflags="-s -w" -o deploy main.go

# Kompresi menggunakan UPX (harus instal UPX terlebih dahulu)
upx --best deploy
```

### 4. Script Paket Massal

Buat skrip `build.sh`:

```bash
#!/bin/bash

# Membuat direktori build
mkdir -p builds

# Build untuk setiap platform
echo "Membangun versi Linux 64-bit..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Membangun versi Windows 64-bit..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Membangun versi macOS 64-bit..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Membangun versi macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Build selesai!"
ls -la builds/
```

Jalankan skrip:

```bash
chmod +x build.sh
./build.sh
```

## Contoh Penggunaan

### Menampilkan Informasi Bantuan

```bash
$ ./deploy --help
Go-Deploy Alat Deploy

Penggunaan: ./deploy [opsi]

Opsi:
  -config string
        Jalur file konfigurasi (default "config.json")
  -help
        Tampilkan informasi bantuan
  -version
        Tampilkan informasi versi

Contoh:
  ./deploy                           # Menggunakan file konfigurasi default config.json
  ./deploy --config prod.json        # Menggunakan file konfigurasi yang ditentukan
  ./deploy --config /path/to/config.json  # Menggunakan file konfigurasi dengan jalur absolut
```

### Menggunakan File Konfigurasi Tertentu

```bash
$ ./deploy --config prod.json
Memulai eksekusi program deploy...
Mencoba membaca file konfigurasi: /path/to/go-deploy/prod.json
Menggunakan file konfigurasi...
Direktori lokal /path/to/project/dist ditemukan
Menghubungkan ke server SSH...
Koneksi server SSH berhasil
...
```

### Menggunakan File Konfigurasi

```bash
$ ./deploy
Memulai eksekusi program deploy...
Mencoba membaca file konfigurasi: /path/to/go-deploy/config.json
Menggunakan file konfigurasi...
Direktori lokal /path/to/project/unpackage/dist/build/web ditemukan
Menghubungkan ke server SSH...
Koneksi server SSH berhasil
Membuat klien SFTP...
Klien SFTP berhasil dibuat
Siap mengunggah ke direktori remote: /opt/xsoft/nginx/html/app/dist
Mulai mengunggah direktori...
Mulai menelusuri direktori lokal: /path/to/project/unpackage/dist/build/web
Membuat direktori: /opt/xsoft/nginx/html/app/dist
File static/js/app.js.map dikecualikan, melewati upload
Membuat backup: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Mengunggah file: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
File .DS_Store dikecualikan, melewati upload
Mengunggah file: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Gagal upload (coba 1/3): Kesalahan jaringan
Mengulang upload file (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Mengunggah file: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Direktori berhasil diupload!
Statistik:
  - Jumlah file diupload: 485
  - Jumlah direktori dibuat: 18
  - Total ukuran transfer: 25.8 MB
  - Waktu upload: 38.5s
  - Total waktu: 39.2s
  - Kecepatan transfer: 0.67 MB/s
```

## Catatan Penting

1. **Keamanan**:

   - Lingkungan produksi disarankan menggunakan otentikasi kunci SSH daripada password
   - Saat ini menggunakan `ssh.InsecureIgnoreHostKey()`, di produksi sebaiknya verifikasi host key
2. **Jaringan**:

   - Pastikan lokal dapat mengakses port 22 server tujuan
   - Kecepatan transfer tergantung bandwidth jaringan dan performa server
3. **Hak Akses**:

   - Pastikan user SSH memiliki hak tulis ke direktori tujuan
   - Jika perlu, gunakan sudo
4. **Path**:

   - Path lokal otomatis dihitung berdasarkan lokasi file eksekusi, tidak perlu khawatir tentang direktori kerja
   - Path remote menggunakan path absolut

## Pemecahan Masalah

### Masalah Umum

1. **Timeout Koneksi**

   ```
   Gagal menghubungkan server SSH: dial tcp: i/o timeout
   ```

   - Periksa alamat dan port server
   - Pastikan koneksi jaringan
   - Periksa pengaturan firewall
2. **Otentikasi Gagal**

   ```
   Gagal login: ssh: handshake failed
   ```

   - Periksa username dan password
   - Pastikan layanan SSH aktif
   - Periksa konfigurasi SSH
3. **Kesalahan Hak Akses**

   ```
   Gagal membuat direktori: permission denied
   ```

   - Periksa hak tulis user ke direktori tujuan
   - Mungkin perlu menggunakan sudo atau mengubah owner direktori
4. **Direktori Lokal Tidak Ada**

   ```
   Error: Direktori lokal /path/to/unpackage/dist/build/web tidak ditemukan
   ```

   - Pastikan build lokal sudah selesai
   - Periksa struktur direktori proyek
   - Program akan menghitung path otomatis, tidak perlu ubah direktori kerja secara manual

## Penjelasan Pengembangan

### Struktur Proyek

```
go-deploy/
├── main.go                 # File program utama
├── go.mod                  # File modul Go  
├── go.sum                  # File verifikasi dependensi  
```
├── README.md               # Dokumentasi penjelasan detail  
├── Makefile                # Alat build  
├── build.sh                # Skrip paket batch  
├── install.sh              # Skrip instalasi satu klik  
└── config.example.json     # Contoh file konfigurasi  
```

### Fungsi Utama

- `main()` - Fungsi utama, menangani koneksi dan pemanggilan upload
- `uploadDirectory()` - Upload direktori secara rekursif
- `uploadFile()` - Upload file tunggal
- `mkdirAll()` - Membuat direktori remote secara rekursif

## Lisensi

MIT License

## Kontribusi

Silakan ajukan Issue dan Pull Request!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---