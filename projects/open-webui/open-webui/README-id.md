# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI adalah [platform AI self-hosted](https://docs.openwebui.com/features/plugin/) yang dapat diperluas, kaya fitur, dan ramah pengguna yang dirancang untuk beroperasi sepenuhnya offline.** Platform ini mendukung berbagai runner LLM seperti **Ollama** dan **API yang kompatibel dengan OpenAI**, dengan **mesin inferensi bawaan** untuk RAG, menjadikannya **solusi deployment AI yang kuat**.

![Demo Open WebUI](./demo.gif)

> [!TIP]  
> **Mencari [Paket Enterprise](https://docs.openwebui.com/enterprise)?** – **[Hubungi Tim Penjualan Kami Hari Ini!](mailto:sales@openwebui.com)**
>
> Dapatkan **kemampuan tambahan**, termasuk **kustomisasi tema dan branding**, **dukungan SLA**, **versi LTS**, dan **lainnya!**

Untuk informasi lebih lanjut, pastikan untuk membaca [Dokumentasi Open WebUI](https://docs.openwebui.com/).

## Fitur Utama Open WebUI ⭐

- 🚀 **Instalasi Mudah**: Instalasi lancar menggunakan Docker atau Kubernetes (kubectl, kustomize, atau helm) untuk pengalaman bebas repot dengan dukungan image bertag `:ollama` dan `:cuda`.

- 🤝 **Integrasi API Ollama/OpenAI**: Integrasikan API yang kompatibel dengan OpenAI untuk percakapan yang beragam bersama model Ollama. Kustomisasi URL API OpenAI untuk terhubung dengan **LMStudio, GroqCloud, Mistral, OpenRouter, dan lainnya**.

- 🛡️ **Izin dan Grup Pengguna Granular**: Administrator dapat membuat peran dan izin pengguna secara detail, memastikan lingkungan pengguna yang aman. Granularitas ini tidak hanya meningkatkan keamanan, tetapi juga memungkinkan pengalaman pengguna yang dipersonalisasi, menumbuhkan rasa kepemilikan dan tanggung jawab di antara pengguna.

- 📱 **Desain Responsif**: Nikmati pengalaman mulus di Desktop PC, Laptop, dan perangkat Mobile.

- 📱 **Progressive Web App (PWA) untuk Mobile**: Rasakan pengalaman seperti aplikasi native di perangkat mobile dengan PWA kami, menyediakan akses offline di localhost dan antarmuka pengguna yang mulus.

- ✒️🔢 **Dukungan Penuh Markdown dan LaTeX**: Tingkatkan pengalaman LLM Anda dengan kemampuan Markdown dan LaTeX yang komprehensif untuk interaksi yang lebih kaya.

- 🎤📹 **Panggilan Suara/Video Bebas Tangan**: Rasakan komunikasi tanpa hambatan dengan fitur panggilan suara dan video bebas tangan terintegrasi, memungkinkan lingkungan chat yang lebih dinamis dan interaktif.

- 🛠️ **Model Builder**: Mudah membuat model Ollama melalui Web UI. Buat dan tambahkan karakter/agen khusus, kustomisasi elemen chat, dan impor model dengan mudah melalui integrasi [Komunitas Open WebUI](https://openwebui.com/).

- 🐍 **Alat Pemanggil Fungsi Python Native**: Tingkatkan LLM Anda dengan dukungan editor kode bawaan di workspace tools. Tambahkan fungsi Python murni Anda sendiri (BYOF), memungkinkan integrasi mulus dengan LLM.

- 📚 **Integrasi RAG Lokal**: Masuki masa depan interaksi chat dengan dukungan Retrieval Augmented Generation (RAG) mutakhir. Fitur ini mengintegrasikan interaksi dokumen ke dalam chat Anda. Anda dapat memuat dokumen langsung ke chat atau menambahkan file ke perpustakaan dokumen, mengaksesnya dengan mudah menggunakan perintah `#` sebelum kueri.

- 🔍 **Pencarian Web untuk RAG**: Lakukan pencarian web menggunakan penyedia seperti `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi`, dan `Bing`, serta suntikkan hasilnya langsung ke chat Anda.

- 🌐 **Kemampuan Browsing Web**: Integrasikan situs web ke dalam chat Anda menggunakan perintah `#` diikuti URL. Fitur ini memungkinkan Anda memasukkan konten web langsung ke percakapan, memperkaya interaksi Anda.

- 🎨 **Integrasi Pembuatan Gambar**: Integrasikan kemampuan pembuatan gambar menggunakan opsi seperti AUTOMATIC1111 API atau ComfyUI (lokal), dan DALL-E dari OpenAI (eksternal), memperkaya chat Anda dengan konten visual dinamis.

- ⚙️ **Percakapan Multi-Model**: Berinteraksi dengan berbagai model secara simultan, memanfaatkan kekuatan unik mereka untuk respons optimal. Tingkatkan pengalaman Anda dengan memanfaatkan beragam model secara paralel.

- 🔐 **Kontrol Akses Berbasis Peran (RBAC)**: Pastikan akses aman dengan izin terbatas; hanya individu yang berwenang yang dapat mengakses Ollama Anda, dan hak pembuatan/penarikan model eksklusif untuk administrator.

- 🌐🌍 **Dukungan Multibahasa**: Rasakan Open WebUI dalam bahasa pilihan Anda dengan dukungan internasionalisasi (i18n). Bergabunglah untuk memperluas dukungan bahasa kami! Kami aktif mencari kontributor!

- 🧩 **Pipelines, Dukungan Plugin Open WebUI**: Integrasikan logika khusus dan pustaka Python ke Open WebUI menggunakan [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Jalankan instance Pipelines Anda, atur URL OpenAI ke URL Pipelines, dan jelajahi kemungkinan tanpa batas. [Contoh](https://github.com/open-webui/pipelines/tree/main/examples) termasuk **Function Calling**, pembatasan akses pengguna (**Rate Limiting**), **Monitoring Penggunaan** dengan alat seperti Langfuse, **Terjemahan Langsung dengan LibreTranslate** untuk dukungan multibahasa, **Penyaringan Pesan Berbahaya**, dan banyak lagi.

- 🌟 **Pembaruan Berkelanjutan**: Kami berkomitmen meningkatkan Open WebUI dengan pembaruan rutin, perbaikan, dan fitur baru.

Ingin tahu lebih banyak tentang fitur Open WebUI? Baca [dokumentasi fitur Open WebUI](https://docs.openwebui.com/features) untuk gambaran lengkap!

## Sponsor 🙌

#### Emerald

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Apakah antarmuka Anda sudah memiliki backend?<br>Coba <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Terminal cerdas untuk pengembang
    </td>
  </tr>
</table>

---

Kami sangat berterima kasih atas dukungan murah hati dari para sponsor kami. Kontribusi mereka membantu kami dalam memelihara dan meningkatkan proyek ini, memastikan kami dapat terus memberikan karya berkualitas kepada komunitas. Terima kasih!

## Cara Instalasi 🚀

### Instalasi via Python pip 🐍

Open WebUI dapat diinstal menggunakan pip, installer package Python. Pastikan Anda menggunakan **Python 3.11** untuk menghindari masalah kompatibilitas.

1. **Instal Open WebUI**:
   Buka terminal dan jalankan perintah berikut untuk menginstal Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **Menjalankan Open WebUI**:
   Setelah instalasi, Anda dapat memulai Open WebUI dengan menjalankan:

   ```bash
   open-webui serve
   ```

Ini akan memulai server Open WebUI, yang dapat diakses di [http://localhost:8080](http://localhost:8080)

### Mulai Cepat dengan Docker 🐳

> [!NOTE]  
> Harap perhatikan bahwa untuk lingkungan Docker tertentu, konfigurasi tambahan mungkin diperlukan. Jika Anda mengalami masalah koneksi, panduan detail kami di [Dokumentasi Open WebUI](https://docs.openwebui.com/) siap membantu Anda.

> [!WARNING]
> Saat menggunakan Docker untuk menginstal Open WebUI, pastikan untuk menyertakan `-v open-webui:/app/backend/data` dalam perintah Docker Anda. Langkah ini penting agar database Anda ter-mount dengan benar dan mencegah kehilangan data.

> [!TIP]  
> Jika Anda ingin menggunakan Open WebUI dengan Ollama terintegrasi atau akselerasi CUDA, kami sarankan menggunakan image resmi kami dengan tag `:cuda` atau `:ollama`. Untuk mengaktifkan CUDA, Anda harus menginstal [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) di sistem Linux/WSL Anda.

### Instalasi dengan Konfigurasi Default

- **Jika Ollama ada di komputer Anda**, gunakan perintah ini:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Jika Ollama ada di Server Lain**, gunakan perintah ini:

  Untuk terhubung ke Ollama di server lain, ubah `OLLAMA_BASE_URL` ke URL server tersebut:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Untuk menjalankan Open WebUI dengan dukungan GPU Nvidia**, gunakan perintah ini:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Instalasi Hanya untuk Penggunaan API OpenAI

- **Jika Anda hanya menggunakan API OpenAI**, gunakan perintah ini:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Instalasi Open WebUI dengan Dukungan Ollama Terbundel

Metode instalasi ini menggunakan satu image container yang menggabungkan Open WebUI dengan Ollama, memungkinkan setup cepat melalui satu perintah. Pilih perintah yang sesuai dengan perangkat keras Anda:

- **Dengan Dukungan GPU**:
  Manfaatkan sumber daya GPU dengan menjalankan perintah berikut:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Hanya untuk CPU**:
  Jika Anda tidak menggunakan GPU, gunakan perintah berikut:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Kedua perintah ini memudahkan instalasi Open WebUI dan Ollama secara bawaan, memastikan Anda dapat menjalankan semuanya dengan cepat.

Setelah instalasi, Anda dapat mengakses Open WebUI di [http://localhost:3000](http://localhost:3000). Selamat mencoba! 😄

### Metode Instalasi Lain

Kami menawarkan berbagai alternatif instalasi, termasuk instalasi native tanpa Docker, Docker Compose, Kustomize, dan Helm. Kunjungi [Dokumentasi Open WebUI](https://docs.openwebui.com/getting-started/) atau gabung dengan [komunitas Discord](https://discord.gg/5rJgQTnV4s) kami untuk panduan lengkap.

### Pemecahan Masalah

Mengalami masalah koneksi? [Dokumentasi Open WebUI](https://docs.openwebui.com/troubleshooting/) siap membantu Anda. Untuk bantuan lebih lanjut dan bergabung dengan komunitas kami, kunjungi [Discord Open WebUI](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Kesalahan Koneksi Server

Jika Anda mengalami masalah koneksi, biasanya karena container docker WebUI tidak dapat menjangkau server Ollama di 127.0.0.1:11434 (host.docker.internal:11434) di dalam container. Gunakan flag `--network=host` pada perintah docker Anda untuk mengatasi ini. Perhatikan bahwa port berubah dari 3000 menjadi 8080, sehingga link: `http://localhost:8080`.

**Contoh Perintah Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Memperbarui Instalasi Docker Anda

Jika Anda ingin memperbarui instalasi Docker lokal ke versi terbaru, Anda dapat menggunakan [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Pada bagian akhir perintah, ganti `open-webui` dengan nama container Anda jika berbeda.

Periksa Panduan Pembaruan yang tersedia di [Dokumentasi Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Menggunakan Branch Dev 🌙

> [!WARNING]
> Branch `:dev` berisi fitur dan perubahan terbaru yang belum stabil. Gunakan dengan risiko Anda sendiri karena mungkin terdapat bug atau fitur yang belum lengkap.

Jika Anda ingin mencoba fitur-fitur terbaru dan tidak masalah dengan ketidakstabilan sesekali, Anda dapat menggunakan tag `:dev` seperti berikut:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Mode Offline

Jika Anda menjalankan Open WebUI di lingkungan offline, Anda dapat mengatur variabel lingkungan `HF_HUB_OFFLINE` ke `1` untuk mencegah upaya mengunduh model dari internet.

```bash
export HF_HUB_OFFLINE=1
```

## Apa Selanjutnya? 🌟

Temukan fitur yang akan datang di roadmap kami di [Dokumentasi Open WebUI](https://docs.openwebui.com/roadmap/).

## Lisensi 📜

Proyek ini dilisensikan di bawah [Lisensi Open WebUI](LICENSE), lisensi BSD-3-Clause yang telah direvisi. Anda mendapatkan semua hak yang sama seperti lisensi BSD-3 klasik: Anda dapat menggunakan, memodifikasi, dan mendistribusikan perangkat lunak, termasuk untuk produk proprietary dan komersial, dengan batasan minimal. Satu-satunya persyaratan tambahan adalah menjaga branding "Open WebUI", seperti yang dijelaskan di file LICENSE. Untuk syarat lengkap, lihat dokumen [LICENSE](LICENSE). 📄

## Dukungan 💬

Jika Anda memiliki pertanyaan, saran, atau membutuhkan bantuan, silakan buka issue atau bergabung dengan
[komunitas Discord Open WebUI](https://discord.gg/5rJgQTnV4s) untuk terhubung dengan kami! 🤝

## Riwayat Bintang

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Dibuat oleh [Timothy Jaeryang Baek](https://github.com/tjbck) - Mari buat Open WebUI menjadi lebih luar biasa bersama! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---