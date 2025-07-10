<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# Ubah Perangkat Apa Pun Menjadi Jukebox Kolaboratif

**Jukebox** memungkinkan Anda langsung membuat playlist musik bersama teman—tanpa aplikasi, tanpa login, tanpa iklan. Cukup buat sebuah box, bagikan tautan, dan mulai tambahkan lagu bersama. Sempurna untuk pesta, perjalanan, atau kumpul-kumpul bersama!

- 🌐 **Alternatif Open Source untuk Spotify Collaborative Playlists**
- 🕵️ **Tanpa Akun**: Gunakan secara anonim—tidak perlu daftar atau email
- ✨ **Bagikan Tautan, Tambah Lagu Bersama**: Semua orang dapat berkontribusi secara real time
- 🚀 **Tanpa Perlu Unduh Aplikasi**: Berfungsi di perangkat apa pun, langsung di browser Anda
- 🎵 **Integrasi YouTube**: Cari dan putar hampir semua lagu secara instan
- 📱 **Ramah Mobile**: Dirancang untuk ponsel, tablet, dan desktop
- ⚖️ **Antrian Adil**: Lagu akan diurutkan otomatis agar semua kebagian giliran
- 🆓 **100% Gratis, Tanpa Iklan**

---

## Coba Sekarang

1. **Buat Jukebox**: Kunjungi halaman utama dan buat box baru
2. **Bagikan Tautan**: Kirim tautan undangan ke teman-teman Anda
3. **Tambah Lagu**: Cari lagu di YouTube atau tambahkan lagu secara manual
4. **Putar Musik**: Gunakan pemutar bawaan untuk streaming bersama

---
## Fitur

- Playlist kolaboratif: Tambah, antre, dan putar lagu bersama-sama
- Penggunaan anonim: Tidak perlu login atau akun
- Pencarian & pemutaran YouTube: Akses perpustakaan musik yang sangat besar
- UI responsif, mobile-first
- Sumber terbuka (Lisensi MIT)
- Mudah diterapkan dengan Docker

### Deploy dengan Docker Compose

Jalankan semua layanan:

```bash
docker-compose up -d
```

Deploy ulang layanan tanpa downtime setelah memperbarui image:

```bash
bash ./redeploy.sh
```
---

## Memulai

### Prasyarat

- Node.js 16+
- npm atau yarn
- Kunci API YouTube Data v3 (gratis dari Google)

### Pengaturan API YouTube

1. Buka [Google Cloud Console](https://console.cloud.google.com/)
2. Buat proyek baru atau pilih proyek yang sudah ada
3. Aktifkan **YouTube Data API v3**
4. Buat kredensial (Kunci API)
5. Salin kunci API Anda

### Instalasi
```bash
# Clone repositori
git clone <your-repo-url>
cd jukebox

# Instal dependensi server
cd server
yarn install

# Instal dependensi frontend
cd ../frontend
yarn install

# Konfigurasi variabel lingkungan
cd ../server
cp .env.example .env
# Edit .env dan tambahkan kunci API YouTube Anda

# Jalankan migrasi database
```
yarn migrate

# Mulai server pengembangan
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (di terminal baru):
cd frontend
yarn dev
```

---

## Lisensi

MIT

---
## Berkontribusi & Umpan Balik

- Buka issue atau pull request di [GitHub](https://github.com/skeptrunedev/jukebox)
- Permintaan fitur? DM [@skeptrune di X (Twitter)](https://twitter.com/skeptrune)

---

## Catatan Perubahan

Lihat [Catatan Perubahan](https://jukebox.skeptrune.com#changelog) untuk pembaruan dan fitur terbaru.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---