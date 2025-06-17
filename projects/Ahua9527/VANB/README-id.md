# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB adalah alat konversi aliran video/audio berbasis GStreamer, yang mendukung konversi dua arah antara protokol NDI dan RTMP. Alat ini memungkinkan sumber NDI untuk di-streaming ke server RTMP, atau mengonversi aliran RTMP menjadi output NDI.

Proyek ini bersifat open source dengan lisensi [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Platform yang Didukung

Saat ini terutama mendukung platform berikut:
- macOS (Apple Silicon)

## Persyaratan Lingkungan

### Ketergantungan Sistem
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Langkah Instalasi
1. Instal [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Instal GStreamer melalui Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clone repository proyek
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Instal dependensi Python
```bash
pip install -r requirements.txt
```

5. Konfigurasikan variabel lingkungan (lihat file .env sebagai referensi)
```bash
# Konfigurasi path NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Konfigurasi path plugin GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Cara Penggunaan

### NDI ke RTMP (Pengirim)
```bash
python vanb_tx.py
```
Program akan secara otomatis memindai sumber NDI yang tersedia, dan meminta Anda memasukkan alamat RTMP untuk streaming.

### RTMP ke NDI (Penerima)
```bash
python vanb_rx.py
```
Setelah memasukkan alamat RTMP, program akan secara otomatis membuat output NDI baru.

## Status Pengembangan

### Fitur yang Telah Diimplementasikan
- ✓ Konversi dari NDI ke RTMP
- ✓ Konversi dari RTMP ke NDI
- ✓ Adaptasi frame rate dan resolusi otomatis
- ✓ Sinkronisasi audio dan video
- ✓ Pemindaian otomatis sumber NDI
- ✓ Penamaan otomatis output NDI
- ✓ Pengodean & dekode perangkat keras VideoToolbox

### Fitur yang Akan Datang
- ⨯ Dukungan file konfigurasi (Profile/config.json)
  - Kontrol parameter input dan output melalui file konfigurasi
  - Dukungan berbagai preset transkode konfigurasi
  - Ukuran buffer dan parameter latensi dapat dikonfigurasi
  - Dukungan konfigurasi kualitas dan performa transkode
- ⨯ Pemrosesan aliran multi-channel secara bersamaan

## Pernyataan Lisensi

⚠️ **Penting: Lisensi & Kepatuhan**

### Lisensi Perangkat Lunak

Proyek ini dilisensikan di bawah [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Alasan memilih lisensi GPL-3.0:
1. Proyek ini menggunakan beberapa plugin GStreamer berlisensi GPL:
   - `x264`: Encoder video H.264 (GPL)
   - `x265`: Encoder video HEVC/H.265 (GPL)
   - `faad`: Decoder audio AAC (GPL)
2. Berdasarkan klausul viral GPL, perangkat lunak yang menggunakan komponen GPL juga harus menggunakan lisensi GPL
3. Memilih GPL-3.0 memastikan kompatibilitas dengan semua lisensi komponen yang digunakan

### Persyaratan Lisensi

Saat menggunakan proyek ini, Anda harus mematuhi persyaratan berikut:
1. **Kode sumber terbuka**: Jika Anda memodifikasi kode proyek ini atau mengintegrasikannya ke proyek Anda, Anda harus membuka seluruh kode sumber Anda
2. **Pertahankan lisensi**: Proyek Anda harus tetap menggunakan lisensi GPL-3.0
3. **Pernyataan hak cipta**: Anda harus tetap mempertahankan pernyataan hak cipta dan lisensi asli
4. **Penanda modifikasi**: Jika Anda memodifikasi kode, Anda harus secara jelas menandai perubahan yang Anda lakukan
5. **Lisensi paten**: GPL-3.0 mencakup klausul lisensi paten yang jelas

### Lisensi Komponen GStreamer
1. Proyek ini hanya untuk tujuan pengembangan dan pengujian
2. NDI® adalah merek dagang terdaftar milik NewTek, Inc.
3. Penggunaan proyek ini harus mematuhi perjanjian lisensi NewTek NDI® SDK
4. Pastikan Anda telah memperoleh seluruh lisensi dan izin yang diperlukan sebelum penggunaan di lingkungan produksi

## Pelaporan Masalah

Jika Anda mengalami masalah, silakan:
1. Periksa apakah variabel lingkungan telah dikonfigurasi dengan benar
2. Pastikan plugin GStreamer telah terinstal dengan benar
3. Lihat detail pesan kesalahan pada file log
4. Laporkan masalah melalui Issues, serta lampirkan log dan informasi lingkungan

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---