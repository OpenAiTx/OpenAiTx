# TeamSpeak 6 Server - Beta Release README

Selamat datang di rilis Beta TeamSpeak 6 Server! Kami sangat senang Anda bergabung untuk menjelajahi generasi berikutnya dari TeamSpeak. Dokumen ini akan memandu Anda untuk memulai serta menyoroti detail penting tentang Beta saat ini.

Karena ini adalah versi Beta, beberapa fitur masih dalam pengembangan dan Anda mungkin akan menemukan bug. Masukan Anda sangat penting dan akan membantu kami membentuk rilis final yang lebih stabil dan lengkap.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Tentang TeamSpeak</h2>

Teruji selama hampir 25 tahun, kami memiliki solusi yang sesuai dengan kebutuhan semua orang. TeamSpeak menawarkan komunikasi suara ideal untuk gaming, pendidikan dan pelatihan, komunikasi bisnis internal, serta tetap terhubung dengan teman dan keluarga. Fokus utama kami adalah memberikan solusi yang mudah digunakan, dengan standar keamanan tinggi, kualitas suara yang sangat baik, serta penggunaan sistem dan bandwidth yang rendah.

## ℹ️ Status Beta & Masalah yang Diketahui
**Ini adalah rilis beta. Tujuan utamanya adalah untuk mengumpulkan berbagai masukan dan mengidentifikasi potensi masalah sebelum versi stabil diluncurkan.**

**File Server Self-Hosted:** Perangkat lunak server khusus untuk TeamSpeak 6 masih dalam pengembangan aktif dan belum sepenuhnya lengkap fiturnya. Kami berkomitmen untuk menghadirkan pengalaman TS6 yang lengkap untuk server self-hosted.

**Ketidakstabilan Fitur:** Beberapa fitur baru mungkin belum stabil atau bisa saja berubah seiring kami terus memperbaikinya.

**Masukan Sangat Penting:** Pengalaman Anda sangat berharga dan masukan Anda sangat penting bagi kami. Silakan laporkan masalah apa pun atau bagikan saran Anda di [Forum Komunitas](https://community.teamspeak.com/c/teamspeak-6-server/45) kami atau langsung di [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Keterbatasan:** Perlu diketahui bahwa **lisensi Server TeamSpeak 3 tidak kompatibel** dengan Server TeamSpeak 6, dan saat ini, **belum tersedia jalur migrasi antara kedua versi tersebut**.

**Lisensi Pratinjau:** Menanggapi masukan Anda, server kini dilengkapi dengan lisensi pratinjau **sementara** 32 slot untuk memberikan fleksibilitas lebih selama masa evaluasi. Perlu dicatat bahwa lisensi ini **hanya berlaku selama dua bulan**.

Selain itu, **belum memungkinkan untuk mendapatkan atau meningkatkan ke lisensi yang lebih besar untuk TeamSpeak 6**.

Kami benar-benar menghargai kesabaran dan pengertian Anda sementara kami terus bekerja untuk solusi yang lebih baik guna mendukung kebutuhan Anda di masa mendatang.

## 👇 Memulai dengan TS6
Untuk mulai menggunakan TeamSpeak 6 Client, silakan kunjungi halaman [Unduhan](https://teamspeak.com/en/downloads/) kami.

Untuk informasi tentang self-hosting, lihat panduan singkat di bawah ini. Untuk pembaruan terbaru, pengumuman, dan berinteraksi dengan komunitas TeamSpeak, pastikan untuk mengunjungi [Forum Komunitas](https://community.teamspeak.com/) dan ikuti kami di [Twitter](https://x.com/teamspeak).

Tidak ingin self-host atau hanya ingin cara yang lebih mudah untuk memulai dengan TeamSpeak 6? Anda dapat menyewa Server TeamSpeak 6 resmi dan andal langsung melalui kami di [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Konfigurasi
### Anda dapat mengonfigurasi server Anda dengan tiga cara utama:

1. **Argumen Baris Perintah:** Berikan opsi langsung saat memulai server (misal, ./tsserver --default-voice-port 9987). Ini berguna untuk perubahan sementara atau untuk keperluan scripting.

2. **Variabel Lingkungan:** Atur variabel lingkungan sebelum memulai server. Ini berguna untuk Docker atau ketika Anda ingin menghindari kekacauan di baris perintah.

3. **File Konfigurasi YAML:** Untuk konfigurasi yang persisten, sangat disarankan menggunakan file tsserver.yaml. Anda dapat menghasilkan file konfigurasi default menggunakan flag --write-config-file.

Pengaturan utama yang dapat Anda kendalikan meliputi port jaringan (suara, transfer file), koneksi basis data (mendukung SQLite dan MariaDB), binding IP, dan opsi logging.

Untuk daftar lengkap opsi yang tersedia, jalankan server dengan flag `--help` atau lihat [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Menjalankan Server dengan Biner
Jika Anda tidak menggunakan Docker, Anda dapat menjalankan server langsung di sistem operasi Anda.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Di Linux:</h2>

Buat file biner server dapat dieksekusi:
```sh
chmod +x tsserver
```

Jalankan server dari terminal Anda, pastikan untuk menerima lisensi:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Di Windows:</h2>

Buka Command Prompt atau PowerShell dan navigasikan ke direktori tempat Anda mengekstrak file server.

Jalankan file eksekusi server, pastikan untuk menerima lisensi:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Menjalankan Server dengan Docker (Direkomendasikan):</h2>
Docker adalah cara termudah untuk menjalankan server TeamSpeak 6 dalam lingkungan yang terisolasi dan mudah dikelola.

### 1. Perintah docker run sederhana:

Untuk memulai dengan cepat, Anda dapat menggunakan perintah docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Menggunakan docker-compose.yaml (untuk setup persisten):
Ini adalah praktik terbaik untuk server yang ingin Anda jalankan terus-menerus. Buat file docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Voice Port
      - "30033:30033/tcp" # File Transfer
      # - "10080:10080/tcp" # Web Query
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Tautan Berguna
[Situs Resmi](https://teamspeak.com/en/)<br>
[Forum Komunitas](https://community.teamspeak.com)<br>
[Isu GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Partisipasi dan masukan Anda akan membantu kami membentuk masa depan TeamSpeak! 💙<br>
Terima kasih telah menjadi bagian dari program Beta TeamSpeak 6 dan berkontribusi pada perkembangannya! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---