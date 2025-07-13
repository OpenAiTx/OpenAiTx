# Terminal Pembayaran NFC

Terminal pembayaran NFC multi-chain yang memproses pembayaran kripto di 5 jaringan blockchain dengan pemantauan transaksi waktu nyata dan pelacakan riwayat yang komprehensif.

## 🌐 Jaringan yang Didukung

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Prioritas Pembayaran Cerdas**

Alih-alih bernegosiasi tentang kombinasi chain/token dengan merchant, terminal pembayaran menangani hal ini secara otomatis. Pertama-tama terminal akan mencari chain yang didukung merchant dan juga memiliki dana milik Anda, lalu mengirimkan transaksi dengan ETH atau token ERC-20 dengan prioritas berikut:

```
L2 Stablecoin > L2 Lainnya > L2 ETH > L1 Stablecoin > L1 Lainnya > L1 ETH
```
## 🚀 Mulai Cepat

1. **Instal dependensi:**
   ```bash
   npm install
   ```

2. **Pengaturan lingkungan:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Jalankan terminal:**
   ```bash
   npm start
   ```

4. **Buka antarmuka:**
   Arahkan ke `http://localhost:3000`
## 🏗️ Arsitektur

```
src/
├── server.ts                   # Server Express & penangan WebSocket
├── app.ts                      # Orkestrator aplikasi utama
├── web/index.html              # UI terminal pembayaran
├── config/index.ts             # Konfigurasi multi-chain
└── services/
    ├── nfcService.ts           # Pembaca NFC & pemindaian dompet
    ├── alchemyService.ts       # Monitoring & saldo multi-chain
    ├── paymentService.ts       # Pemilihan pembayaran & pembuatan EIP-681
    ├── ethereumService.ts      # Utilitas validasi alamat
    └── addressProcessor.ts     # Pencegahan pemrosesan duplikat
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Instalasi dependensi untuk membangun image Raspberry Pi
    └── build-pi-image-osx.sh       # Membangun image Raspberry Pi
```
## 💡 Penggunaan

### **Memproses Pembayaran**
1. Masukkan jumlah menggunakan keypad (berbasis sen: "150" = Rp15.000)
2. Ketuk "Charge" untuk memulai pembayaran
3. Pelanggan men-tap perangkat NFC untuk mengirim pembayaran
4. Pemantauan waktu nyata mengonfirmasi transaksi
5. Pesan "Approved" dengan tautan ke block explorer

### **Riwayat Transaksi**
1. Ketuk tombol 📜 riwayat pada keypad
2. Lihat semua transaksi atau pindai dompet untuk riwayat tertentu
3. Ketuk "📱 Scan Wallet for History" dan minta pelanggan men-tap perangkat mereka
4. Telusuri transaksi yang difilter untuk dompet tertentu tersebut


## 🔄 Alur Pembayaran

1. **Deteksi NFC** → Pelanggan men-tap perangkat
2. **Pengambilan Multi-Chain** → Analisis portofolio di semua 6 chain
3. **Pemilihan Cerdas** → Token pembayaran optimal berdasarkan sistem prioritas
4. **Generasi EIP-681** → Permintaan pembayaran dengan chain ID
5. **Pemantauan Waktu Nyata** → WebSocket/polling untuk konfirmasi transaksi
6. **Pencatatan Riwayat** → Transaksi disimpan dengan metadata lengkap
## 🛡️ Pemantauan Transaksi

- **Pemantauan WebSocket** untuk Ethereum, Base, Arbitrum, Optimism, Polygon
- **Pemantauan berbasis polling** sebagai cadangan
- **Timeout otomatis** setelah 5 menit
- **Integrasi block explorer** untuk verifikasi transaksi
- **Pelacakan status**: terdeteksi → terkonfirmasi → gagal

## 🍓 Deployment Raspberry Pi

Terminal pembayaran NFC ini dapat diterapkan sebagai **kios plug-and-play** pada perangkat keras Raspberry Pi untuk penggunaan produksi.

### **Persyaratan Perangkat Keras**
- Raspberry Pi 4B (disarankan RAM 4GB+)
- Layar Sentuh Resmi Raspberry Pi 7"
- **ACR1252U-M1 NFC Reader** (didukung secara spesifik)
- Kartu MicroSD 32GB+

### **Fitur Deployment**
- **Build satu perintah** menghasilkan image SD card yang dapat di-boot
- **WiFi dan kredensial API terkonfigurasi sebelumnya**
- **Startup otomatis** dengan mode kios layar penuh
- **Validasi keamanan** mencegah deployment dengan alamat uji coba
- Dukungan build **macOS dan Linux**
### **Quick Deploy**
```bash
# Masuk ke skrip deployment
cd scripts/rpi-deploy

# Konfigurasikan deployment Anda
cp build-config.env.template build-config.env
# Edit build-config.env dengan WiFi, API key, dan alamat merchant Anda

# Bangun image bootable (macOS)
./build-pi-image-osx.sh

# Flash file nfc-terminal-<date>.img.gz yang dihasilkan ke kartu SD menggunakan Raspberry Pi Imager dan boot!
```

📖 **[Panduan Deployment Lengkap](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---