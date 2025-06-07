# AutoGPT: Bangun, Deploy, dan Jalankan Agen AI

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** adalah platform kuat yang memungkinkan Anda untuk membuat, mendistribusikan, dan mengelola agen AI berkelanjutan yang mengotomatisasi alur kerja kompleks.

## Pilihan Hosting
   - Unduh untuk self-host
   - [Bergabung di Daftar Tunggu](https://bit.ly/3ZDijAI) untuk versi beta cloud-hosted

## Cara Setup untuk Self-Hosting
> [!CATATAN]
> Menyiapkan dan menghosting Platform AutoGPT sendiri adalah proses teknis.
> Jika Anda lebih memilih sesuatu yang langsung berjalan, kami merekomendasikan [bergabung di daftar tunggu](https://bit.ly/3ZDijAI) untuk versi beta cloud-hosted.

### Persyaratan Sistem

Sebelum melanjutkan instalasi, pastikan sistem Anda memenuhi persyaratan berikut:

#### Persyaratan Perangkat Keras
- CPU: Disarankan 4+ core
- RAM: Minimum 8GB, disarankan 16GB
- Penyimpanan: Minimal 10GB ruang kosong

#### Persyaratan Perangkat Lunak
- Sistem Operasi:
  - Linux (disarankan Ubuntu 20.04 atau yang lebih baru)
  - macOS (10.15 atau yang lebih baru)
  - Windows 10/11 dengan WSL2
- Perangkat Lunak yang Dibutuhkan (dengan versi minimum):
  - Docker Engine (20.10.0 atau yang lebih baru)
  - Docker Compose (2.0.0 atau yang lebih baru)
  - Git (2.30 atau yang lebih baru)
  - Node.js (16.x atau yang lebih baru)
  - npm (8.x atau yang lebih baru)
  - VSCode (1.60 atau yang lebih baru) atau editor kode modern lainnya

#### Persyaratan Jaringan
- Koneksi internet yang stabil
- Akses ke port yang dibutuhkan (akan dikonfigurasi di Docker)
- Kemampuan untuk melakukan koneksi HTTPS keluar

### Instruksi Setup Terbaru:
Kami telah berpindah ke situs dokumentasi yang sepenuhnya terpelihara dan diperbarui secara berkala.

👉 [Ikuti panduan resmi self-hosting di sini](https://docs.agpt.co/platform/getting-started/)

Panduan ini mengasumsikan Anda telah menginstal Docker, VSCode, git, dan npm.

### 🧱 AutoGPT Frontend

Frontend AutoGPT adalah tempat pengguna berinteraksi dengan platform otomasi AI kami yang kuat. Ini menawarkan berbagai cara untuk terlibat dan memanfaatkan agen AI kami. Inilah antarmuka di mana Anda akan mewujudkan ide otomasi AI Anda:

   **Agent Builder:** Bagi yang ingin menyesuaikan, antarmuka low-code kami yang intuitif memungkinkan Anda merancang dan mengonfigurasi agen AI Anda sendiri.
   
   **Manajemen Workflow:** Bangun, modifikasi, dan optimalkan alur kerja otomasi Anda dengan mudah. Anda membangun agen dengan menghubungkan blok, di mana setiap blok melakukan satu aksi.
   
   **Kontrol Deployment:** Kelola siklus hidup agen Anda, mulai dari pengujian hingga produksi.
   
   **Agen Siap Pakai:** Tidak ingin membangun? Pilih saja dari pustaka agen yang telah dikonfigurasi dan langsung gunakan.
   
   **Interaksi Agen:** Baik Anda membangun sendiri atau menggunakan agen siap pakai, jalankan dan interaksikan dengan mudah melalui antarmuka kami yang ramah pengguna.

   **Monitoring dan Analitik:** Pantau performa agen Anda dan dapatkan insight untuk terus meningkatkan proses otomasi Anda.

[Baca panduan ini](https://docs.agpt.co/platform/new_blocks/) untuk mempelajari cara membangun blok kustom Anda sendiri.

### 💽 AutoGPT Server

AutoGPT Server adalah inti dari platform kami. Di sinilah agen Anda berjalan. Setelah didistribusikan, agen dapat dipicu oleh sumber eksternal dan dapat beroperasi secara berkelanjutan. Server ini mengandung semua komponen penting yang membuat AutoGPT berjalan lancar.

   **Kode Sumber:** Logika inti yang menggerakkan agen dan proses otomasi kami.
   
   **Infrastruktur:** Sistem yang tangguh untuk memastikan performa yang andal dan dapat diskalakan.
   
   **Marketplace:** Marketplace lengkap di mana Anda dapat menemukan dan mendistribusikan berbagai agen siap pakai.

### 🐙 Contoh Agen

Berikut dua contoh yang dapat Anda lakukan dengan AutoGPT:

1. **Menghasilkan Video Viral dari Topik Trending**
   - Agen ini membaca topik di Reddit.
   - Mengidentifikasi topik yang sedang tren.
   - Secara otomatis membuat video berdurasi pendek berdasarkan konten tersebut.

2. **Mengidentifikasi Kutipan Terbaik dari Video untuk Media Sosial**
   - Agen ini berlangganan ke channel YouTube Anda.
   - Saat Anda mengunggah video baru, agen ini menyalinnya.
   - Menggunakan AI untuk mengidentifikasi kutipan paling berdampak untuk membuat ringkasan.
   - Kemudian, menulis postingan untuk langsung dipublikasikan ke media sosial Anda.

Contoh-contoh ini hanya sebagian kecil dari apa yang dapat Anda capai dengan AutoGPT! Anda dapat membuat alur kerja khusus untuk membangun agen untuk berbagai kasus penggunaan.

---
### Misi dan Lisensi
Misi kami adalah menyediakan alat, sehingga Anda dapat fokus pada hal yang penting:

- 🏗️ **Membangun** - Letakkan fondasi untuk sesuatu yang luar biasa.
- 🧪 **Menguji** - Sempurnakan agen Anda hingga optimal.
- 🤝 **Mendelegasikan** - Biarkan AI bekerja untuk Anda, dan wujudkan ide Anda.

Jadilah bagian dari revolusi! **AutoGPT** hadir untuk tetap menjadi yang terdepan dalam inovasi AI.

**📖 [Dokumentasi](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Kontribusi](CONTRIBUTING.md)**

**Lisensi:**

Lisensi MIT: Sebagian besar repository AutoGPT berada di bawah Lisensi MIT.

Lisensi Polyform Shield: Lisensi ini berlaku untuk folder autogpt_platform.

Untuk informasi lebih lanjut, lihat https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> Berikut adalah informasi tentang versi klasik AutoGPT.

**🛠️ [Bangun Agen Anda Sendiri - Quickstart](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Buat agen Anda sendiri!** &ndash; Forge adalah toolkit siap pakai untuk membangun aplikasi agen Anda sendiri. Forge menangani sebagian besar kode boilerplate, sehingga Anda bisa fokus pada hal yang membuat *agen Anda* berbeda. Semua tutorial tersedia [di sini](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Komponen dari [`forge`](/classic/forge/) juga dapat digunakan secara individual untuk mempercepat pengembangan dan mengurangi boilerplate pada proyek agen Anda.

🚀 [**Memulai dengan Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Panduan ini akan memandu Anda melalui proses pembuatan agen sendiri dan menggunakan benchmark serta antarmuka pengguna.

📘 [Pelajari Lebih Lanjut](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) tentang Forge

### 🎯 Benchmark

**Ukur performa agen Anda!** `agbenchmark` dapat digunakan dengan agen apa pun yang mendukung protokol agen, dan integrasinya dengan [CLI] proyek membuatnya semakin mudah digunakan dengan AutoGPT dan agen berbasis forge. Benchmark ini menawarkan lingkungan pengujian yang ketat. Framework kami memungkinkan evaluasi performa yang otonom dan objektif, memastikan agen Anda siap untuk aksi dunia nyata.

<!-- TODO: insert visual demonstrating the benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) di Pypi
&ensp;|&ensp;
📘 [Pelajari Lebih Lanjut](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) tentang Benchmark

### 💻 UI

**Membuat agen mudah digunakan!** `frontend` memberikan antarmuka yang ramah pengguna untuk mengontrol dan memantau agen Anda. Frontend ini terhubung ke agen melalui [protokol agen](#-agent-protocol), memastikan kompatibilitas dengan banyak agen baik dari dalam maupun luar ekosistem kami.

<!-- TODO: insert screenshot of front end -->

Frontend ini langsung dapat digunakan dengan semua agen di repo. Cukup gunakan [CLI] untuk menjalankan agen pilihan Anda!

📘 [Pelajari Lebih Lanjut](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) tentang Frontend

### ⌨️ CLI

[CLI]: #-cli

Agar semudah mungkin menggunakan semua alat yang ditawarkan oleh repository ini, sebuah CLI disertakan di root repo:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Cukup clone repo, instal dependensi dengan `./run setup`, dan Anda siap untuk mulai!

## 🤔 Pertanyaan? Masalah? Saran?

### Dapatkan bantuan - [Discord 💬](https://discord.gg/autogpt)

[![Join us on Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Untuk melaporkan bug atau meminta fitur, buat [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Pastikan belum ada orang lain yang membuat issue untuk topik yang sama.

## 🤝 Proyek Saudara

### 🔄 Agent Protocol

Untuk menjaga standar yang seragam dan memastikan kompatibilitas mulus dengan banyak aplikasi saat ini dan masa depan, AutoGPT menggunakan standar [agent protocol](https://agentprotocol.ai/) dari AI Engineer Foundation. Standar ini menstandarkan jalur komunikasi dari agen Anda ke frontend dan benchmark.

---

## Statistik Stars

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ Kontributor

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---