# Pengantar Proyek
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Membuat proses deploy, manajemen, dan pemeliharaan server game menjadi sederhana dan efisien**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Dokumentasi](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Situs Resmi](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Grup QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Ringkasan Proyek

GameServerManager (disingkat GSManager) adalah platform manajemen server game modern berbasis teknologi **Docker**, yang dirancang khusus untuk menyederhanakan proses deploy, manajemen, dan pemeliharaan server game.

### ✨ Fitur Utama

- 🐳 **Docker Containerization** - Berjalan sepenuhnya di atas Docker, isolasi lingkungan, kompatibilitas sangat baik
- 🎯 **Deploy Sekali Klik** - Mendukung deploy cepat untuk berbagai game populer
- 🌐 **Antarmuka Web** - Frontend modern berbasis React, intuitif dan mudah digunakan
- 🔧 **Terminal Real-Time** - Terminal web bawaan, mendukung eksekusi perintah secara real-time
- 📊 **Monitoring Resource** - Pantauan penggunaan resource server secara real-time
- 🔐 **Manajemen Hak Akses** - Sistem otentikasi pengguna dan kontrol hak akses yang lengkap
- 🎮 **Dukungan Multi Game** - Mendukung banyak server game populer dari platform Steam
- 💾 **Persistensi Data** - Data game dan file konfigurasi dapat dipetakan ke luar, aman dan andal

![Panel Informasi Kontainer](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Mulai Cepat

### Skrip Instalasi Sekali Klik

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Untuk debian (instalasi docker manual) dan centos, silakan gunakan instalasi manual, selengkapnya di dokumentasi

---

## 🎮 Game yang Didukung

| Nama Game | Nama Mandarin | Steam ID | Unduh Anonim | Status |
|-----------|--------------|----------|--------------|--------|
| **Game Populer** | | | | |
| Palworld | Fantasi Palu | 2394010 | ✅ | 🟢 Dukungan Penuh |
| Rust | Korosi | 258550 | ✅ | 🟢 Dukungan Penuh |
| Satisfactory | Pabrik Kebahagiaan | 1690800 | ✅ | 🟢 Dukungan Penuh |
| Valheim | Valheim | 896660 | ✅ | 🟢 Dukungan Penuh |
| 7 Days to Die | 7 Hari Mati | 294420 | ✅ | 🟢 Dukungan Penuh |
| Project Zomboid | Proyek Zomboid | 380870 | ✅ | 🟢 Dukungan Penuh |
| ARK: Survival Evolved | ARK: Survival Evolved | 376030 | ✅ | 🟢 Dukungan Penuh |
| **Game FPS** | | | | |
| Left 4 Dead 2 | Left 4 Dead 2 | 222860 | ❌ | 🟡 Butuh Versi Asli |
| Team Fortress 2 | Team Fortress 2 | 232250 | ✅ | 🟢 Dukungan Penuh |
| Squad | Squad Taktis | 403240 | ✅ | 🟢 Dukungan Penuh |
| Insurgency: Sandstorm | Insurgency: Sandstorm | 581330 | ✅ | 🟢 Dukungan Penuh |
| Killing Floor 2 | Killing Floor 2 | 232130 | ✅ | 🟢 Dukungan Penuh |
| Insurgency (2014) | Insurgency 2 | 237410 | ✅ | 🟢 Dukungan Penuh |
| MORDHAU | MORDHAU | 629800 | ✅ | 🟢 Dukungan Penuh |
| No More Room in Hell | No More Room in Hell | 317670 | ✅ | 🟢 Dukungan Penuh |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Dukungan Penuh |
| Half-Life | Half-Life | 90 | ✅ | 🟢 Dukungan Penuh |
| Half-Life 2: Deathmatch | Half-Life 2 | 232370 | ✅ | 🟢 Dukungan Penuh |
| Operation: Harsh Doorstop | Operation: Harsh Doorstop | 950900 | ✅ | 🟢 Dukungan Penuh |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Perlu Konfigurasi |
| **Game Indie** | | | | |
| Unturned | Unturned | 1110390 | ✅ | 🟢 Dukungan Penuh |
| Don't Starve Together | Don't Starve Together | 343050 | ✅ | 🟡 Perlu Konfigurasi |
| Last Oasis | Last Oasis | 920720 | ✅ | 🟢 Dukungan Penuh |
| Hurtworld | Hurtworld | 405100 | ✅ | 🟢 Dukungan Penuh |
| Soulmask | Soulmask | 3017300 | ✅ | 🟢 Dukungan Penuh |
| **Simulasi** | | | | |
| Euro Truck Simulator 2 | Euro Truck Simulator 2 | 1948160 | ✅ | 🟡 Perlu Konfigurasi |
| American Truck Simulator | American Truck Simulator | 2239530 | ✅ | 🟡 Perlu Konfigurasi |
| ECO | ECO | 739590 | ✅ | 🟡 Perlu Konfigurasi |

> Dukungan untuk lebih banyak game akan terus ditambahkan...

---

## 🏗️ Arsitektur Teknologi

### Teknologi Frontend
- **React 18** - Framework frontend modern
- **Ant Design** - Library komponen UI kelas enterprise
- **Monaco Editor** - Editor kode
- **Xterm.js** - Emulator terminal web
- **Vite** - Alat build cepat

### Teknologi Backend
- **Python 3.13** - Bahasa pengembangan utama
- **Flask** - Kerangka Web
- **Gunicorn** - Server WSGI
- **Docker** - Teknologi Kontainerisasi
- **SteamCMD** - Alat Baris Perintah Steam
- **Aria2** - Pengunduh Multi-protokol

---

## 📁 Struktur Proyek

```
GameServerManager/
├── app/                    # Aplikasi frontend
│   ├── src/               # Sumber kode React
│   ├── public/            # Sumber daya statis
│   └── package.json       # Dependensi frontend
├── server/                # Layanan backend
│   ├── api_server.py      # Server API utama
│   ├── game_installer.py  # Penginstal game
│   ├── pty_manager.py     # Pengelola terminal
│   ├── auth_middleware.py # Middleware otentikasi
│   └── installgame.json   # File konfigurasi game
├── docker-compose.yml     # File orkestrasi Docker
├── Dockerfile            # File build image Docker
└── README.md             # Dokumentasi proyek
```

---

## 🔧 Penjelasan Konfigurasi

### Konfigurasi Port
- **5000** - Antarmuka manajemen web
- **27015-27020** - Rentang port server game Steam

### Mapping Volume Data
- `./game_data` → `/home/steam/games` - Direktori data game
- `./game_file` → `/home/steam/.config` - Direktori konfigurasi game
- `./game_file` → `/home/steam/.local` - Direktori penyimpanan game

### Variabel Lingkungan
- `TZ=Asia/Shanghai` - Pengaturan zona waktu
- `USE_GUNICORN=true` - Aktifkan Gunicorn
- `GUNICORN_TIMEOUT=120` - Waktu timeout permintaan
- `GUNICORN_PORT=5000` - Port layanan

---

## 🤝 Panduan Kontribusi

Kami menyambut segala bentuk kontribusi!

1. **Fork** proyek ini
2. Buat branch fitur Anda (`git checkout -b feature/AmazingFeature`)
3. Commit perubahan Anda (`git commit -m 'Add some AmazingFeature'`)
4. Push ke branch (`git push origin feature/AmazingFeature`)
5. Buka **Pull Request**

---

## 📞 Dukungan & Umpan Balik

- 🐛 **Laporan Masalah**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Grup QQ**：1040201322
- 📖 **Dokumentasi Lengkap**：[Lihat Dokumentasi](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Lisensi Open Source

Proyek ini menggunakan lisensi open source [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Tentang Penulis

Proyek ini dikembangkan dan dikelola secara mandiri oleh **又菜又爱玩的小朱**.

Jika proyek ini bermanfaat bagi Anda, silakan beri ⭐ Star sebagai dukungan!

---

## 📈 Statistik Proyek

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Membuat manajemen server game menjadi mudah dan menyenangkan!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---