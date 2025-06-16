# AgenticSeek: Alternatif Manus Privat, Lokal.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Sebagai **alternatif Manus AI 100% lokal**, asisten AI berbasis suara ini secara otomatis menjelajah web, menulis kode, dan merencanakan tugas sambil menjaga seluruh data tetap di perangkat Anda. Disesuaikan untuk model reasoning lokal, berjalan sepenuhnya di perangkat keras Anda, memastikan privasi total dan tanpa ketergantungan cloud.*

[![Kunjungi AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![Lisensi](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Mengapa AgenticSeek?

* 🔒 Sepenuhnya Lokal & Privat - Semua berjalan di mesin Anda — tanpa cloud, tanpa berbagi data. File, percakapan, dan pencarian Anda tetap privat.

* 🌐 Penjelajahan Web Cerdas - AgenticSeek dapat menjelajah internet secara mandiri — mencari, membaca, ekstrak info, mengisi formulir web — semua tanpa tangan.

* 💻 Asisten Koding Otonom - Butuh kode? Dapat menulis, debug, dan menjalankan program dalam Python, C, Go, Java, dan lainnya — semua tanpa pengawasan.

* 🧠 Pemilihan Agen Cerdas - Anda bertanya, ia menentukan agen terbaik secara otomatis. Seperti memiliki tim ahli siap membantu.

* 📋 Merencanakan & Mengeksekusi Tugas Kompleks - Dari perencanaan perjalanan hingga proyek rumit — dapat membagi tugas besar menjadi langkah-langkah dan menyelesaikannya dengan banyak agen AI.

* 🎙️ Berbasis Suara - Fitur suara dan konversi suara ke teks yang bersih, cepat, futuristik, memungkinkan Anda berbicara layaknya AI pribadi dari film sci-fi. (Sedang dikembangkan)

### **Demo**

> *Bisakah kamu mencari proyek agenticSeek, pelajari skill yang dibutuhkan, lalu buka CV_candidates.zip dan beritahu saya mana yang paling cocok dengan proyek tersebut*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Disclaimer: Demo ini, termasuk semua file yang muncul (misal: CV_candidates.zip), sepenuhnya fiktif. Kami bukan perusahaan, kami mencari kontributor open-source bukan kandidat.

> 🛠⚠️️ **Masih Dalam Pengembangan Aktif**

> 🙏 Proyek ini dimulai sebagai sampingan dan tidak memiliki roadmap maupun pendanaan. Proyek ini berkembang jauh melebihi ekspektasi hingga muncul di GitHub Trending. Kontribusi, umpan balik, dan kesabaran sangat dihargai.

## Prasyarat

Sebelum memulai, pastikan Anda telah menginstal software berikut:

*   **Git:** Untuk cloning repository. [Download Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Sangat disarankan menggunakan Python versi 3.10.x. Versi lain bisa menyebabkan error dependensi. [Download Python 3.10](https://www.python.org/downloads/release/python-3100/) (pilih versi 3.10.x).
*   **Docker Engine & Docker Compose:** Untuk menjalankan layanan seperti SearxNG.
    *   Instal Docker Desktop (termasuk Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Atau, instal Docker Engine dan Docker Compose secara terpisah di Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (pastikan Compose V2, misal `sudo apt-get install docker-compose-plugin`).

### 1. **Clone repository dan setup**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Ubah isi file .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Perbarui file `.env` dengan nilai Anda sendiri sesuai kebutuhan:

- **SEARXNG_BASE_URL**: Biarkan tanpa perubahan 
- **REDIS_BASE_URL**: Biarkan tanpa perubahan 
- **WORK_DIR**: Path direktori kerja di mesin lokal Anda. AgenticSeek dapat membaca dan berinteraksi dengan file di sini.
- **OLLAMA_PORT**: Nomor port untuk layanan Ollama.
- **LM_STUDIO_PORT**: Nomor port untuk layanan LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Port untuk layanan LLM kustom tambahan.

**API Key sepenuhnya opsional bagi pengguna yang memilih menjalankan LLM secara lokal. Ini adalah tujuan utama proyek ini. Biarkan kosong jika perangkat keras Anda memadai**

### 3. **Mulai Docker**

Pastikan Docker terinstal dan berjalan di sistem Anda. Mulai Docker dengan perintah berikut:

- **Di Linux/macOS:**  
    Buka terminal dan jalankan:
    ```sh
    sudo systemctl start docker
    ```
    Atau buka Docker Desktop dari menu aplikasi jika sudah terinstal.

- **Di Windows:**  
    Mulai Docker Desktop dari Start menu.

Anda bisa memverifikasi Docker sudah berjalan dengan menjalankan:
```sh
docker info
```
Jika Anda melihat informasi instalasi Docker, berarti Docker sudah berjalan dengan benar.

Lihat tabel [Penyedia Lokal](#list-of-local-providers) di bawah untuk ringkasan.

Langkah selanjutnya: [Jalankan AgenticSeek secara lokal](#start-services-and-run)

*Lihat bagian [Troubleshooting](#troubleshooting) jika mengalami masalah.*
*Jika perangkat keras Anda tidak bisa menjalankan LLM lokal, lihat [Setup untuk menjalankan dengan API](#setup-to-run-with-an-api).*
*Penjelasan detail `config.ini` lihat di [Config Section](#config).*

---

## Setup untuk menjalankan LLM secara lokal di mesin Anda

**Kebutuhan Hardware:**

Untuk menjalankan LLM lokal, Anda butuh perangkat keras yang memadai. Minimal diperlukan GPU yang mampu menjalankan Magistral, Qwen atau Deepseek 14B. Lihat FAQ untuk rekomendasi model/kinerja secara detail.

**Setup penyedia lokal Anda**  

Jalankan penyedia lokal Anda, misal dengan ollama:

```sh
ollama serve
```

Lihat di bawah untuk daftar penyedia lokal yang didukung.

**Perbarui config.ini**

Ubah file config.ini untuk mengatur provider_name ke penyedia yang didukung dan provider_model ke LLM yang didukung oleh penyedia Anda. Kami merekomendasikan model reasoning seperti *Magistral* atau *Deepseek*.

Lihat **FAQ** di akhir README untuk kebutuhan hardware.

```sh
[MAIN]
is_local = True # Apakah Anda menjalankan secara lokal atau dengan penyedia remote.
provider_name = ollama # atau lm-studio, openai, dll..
provider_model = deepseek-r1:14b # pilih model sesuai hardware Anda
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nama AI Anda
recover_last_session = True # apakah ingin memulihkan sesi sebelumnya
save_session = True # apakah ingin menyimpan sesi saat ini
speak = False # text to speech
listen = False # Speech to text, hanya untuk CLI, eksperimental
jarvis_personality = False # Apakah menggunakan personality seperti "Jarvis" (eksperimental)
languages = en zh # Daftar bahasa, Text to speech default ke bahasa pertama
[BROWSER]
headless_browser = True # biarkan tanpa perubahan kecuali menggunakan CLI di host.
stealth_mode = True # Gunakan selenium tidak terdeteksi untuk mengurangi deteksi browser
```

**Peringatan**:

- Format file `config.ini` tidak mendukung komentar. 
Jangan copy-paste contoh konfigurasi secara langsung, karena komentar akan menyebabkan error. Ubah secara manual file `config.ini` dengan setting yang diinginkan, tanpa komentar.

- Jangan *PERNAH* set provider_name ke `openai` jika menggunakan LM-studio untuk menjalankan LLM. Set ke `lm-studio`.

- Beberapa penyedia (misal: lm-studio) mengharuskan `http://` di depan IP. Contoh `http://127.0.0.1:1234`

**Daftar penyedia lokal**

| Provider  | Lokal? | Deskripsi                                               |
|-----------|--------|---------------------------------------------------------|
| ollama    | Ya     | Jalankan LLM lokal dengan mudah menggunakan ollama       |
| lm-studio | Ya     | Jalankan LLM lokal dengan LM studio (set `provider_name` ke `lm-studio`)|
| openai    | Ya     | Gunakan API kompatibel openai (misal: llama.cpp server)  |

Langkah selanjutnya: [Mulai layanan dan jalankan AgenticSeek](#Start-services-and-Run)  

*Lihat bagian [Troubleshooting](#troubleshooting) jika Anda mengalami masalah.*
*Jika perangkat keras Anda tidak dapat menjalankan LLM lokal, lihat [Setup untuk menjalankan dengan API](#setup-to-run-with-an-api).*
*Penjelasan detail `config.ini` lihat di [Config Section](#config).*

## Setup untuk menjalankan dengan API

Setup ini menggunakan penyedia LLM cloud eksternal. Anda perlu API key dari layanan pilihan Anda.

**1. Pilih Penyedia API dan Dapatkan API Key:**

Lihat [Daftar Penyedia API](#list-of-api-providers) di bawah. Kunjungi situs web mereka untuk mendaftar dan mendapatkan API key.

**2. Set API Key Anda sebagai Environment Variable:**


*   **Linux/macOS:**
    Buka terminal dan gunakan perintah `export`. Sebaiknya tambahkan ke file profil shell Anda (misal, `~/.bashrc`, `~/.zshrc`) untuk permanen.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # Ganti PROVIDER_API_KEY dengan nama variabel spesifik, misal OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Contoh untuk TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Command Prompt (Sementara untuk sesi saat ini):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Sementara untuk sesi saat ini):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Permanen:** Cari "environment variables" di bilah pencarian Windows, klik "Edit the system environment variables," lalu klik tombol "Environment Variables...". Tambahkan variabel User baru dengan nama yang sesuai (misal, `OPENAI_API_KEY`) dan masukkan key Anda sebagai nilainya.

*(Lihat FAQ: [Bagaimana cara mengatur API keys?](#how-do-i-set-api-keys) untuk detail lebih lanjut).*


**3. Perbarui `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Atau google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Atau gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 dll.
provider_server_address = # Biasanya diabaikan atau dikosongkan ketika is_local = False untuk kebanyakan API
# ... pengaturan lain ...
```
*Peringatan:* Pastikan tidak ada spasi di akhir nilai dalam `config.ini`.

**Daftar Penyedia API**

| Penyedia     | `provider_name` | Lokal? | Deskripsi                                         | Link API Key (Contoh)                        |
|--------------|-----------------|--------|---------------------------------------------------|----------------------------------------------|
| OpenAI       | `openai`        | Tidak  | Gunakan model ChatGPT melalui API OpenAI.         | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | Tidak  | Gunakan model Google Gemini melalui Google AI Studio. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | Tidak  | Gunakan model Deepseek melalui API mereka.        | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | Tidak  | Gunakan model dari Hugging Face Inference API.    | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | Tidak  | Gunakan berbagai model open-source melalui TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Catatan:*
*   Kami menyarankan untuk tidak menggunakan `gpt-4o` atau model OpenAI lain untuk penelusuran web kompleks dan perencanaan tugas karena optimasi prompt saat ini difokuskan pada model seperti Deepseek.
*   Tugas coding/bash mungkin mengalami masalah dengan Gemini, karena model ini mungkin tidak selalu mengikuti format prompt yang telah dioptimalkan untuk Deepseek.
*   `provider_server_address` pada `config.ini` umumnya tidak digunakan ketika `is_local = False` karena endpoint API biasanya sudah tertanam di library masing-masing penyedia.

Langkah berikutnya: [Mulai layanan dan jalankan AgenticSeek](#Start-services-and-Run)

*Lihat bagian **Known issues** jika Anda mengalami masalah*

*Lihat bagian **Config** untuk penjelasan detail file konfigurasi.*

---

## Mulai layanan dan Jalankan

Secara default AgenticSeek dijalankan sepenuhnya dalam docker.

Mulai layanan yang dibutuhkan. Ini akan menjalankan semua layanan dari docker-compose.yml, termasuk:
    - searxng
    - redis (dibutuhkan oleh searxng)
    - frontend
    - backend (jika menggunakan `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**Peringatan:** Langkah ini akan mengunduh dan memuat semua image Docker, yang mungkin memerlukan waktu hingga 30 menit. Setelah layanan dijalankan, harap tunggu hingga layanan backend benar-benar berjalan (Anda akan melihat **backend: "GET /health HTTP/1.1" 200 OK** di log) sebelum mengirim pesan apapun. Layanan backend mungkin memerlukan waktu 5 menit untuk mulai pada kali pertama.

Buka `http://localhost:3000/` dan Anda akan melihat antarmuka web.

*Pemecahan masalah saat memulai layanan:* Jika skrip ini gagal, pastikan Docker Engine sedang berjalan dan Docker Compose (V2, `docker compose`) telah terinstal dengan benar. Periksa output di terminal untuk pesan error. Lihat [FAQ: Help! Saya mendapat error saat menjalankan AgenticSeek atau skripnya.](#faq-troubleshooting)

**Opsional:** Menjalankan di host (mode CLI):

Untuk menjalankan dengan antarmuka CLI Anda harus menginstal paket di host:

```sh
./install.sh
./install.bat # windows
```

Mulai layanan:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

Gunakan CLI: `python3 cli.py`


---

## Penggunaan

Pastikan layanan telah berjalan dengan `./start_services.sh full` dan buka `localhost:3000` untuk antarmuka web.

Anda juga dapat menggunakan speech to text dengan mengatur `listen = True` di konfigurasi. Hanya untuk mode CLI.

Untuk keluar, cukup ucapkan/ketik `goodbye`.

Berikut beberapa contoh penggunaan:

> *Buat game ular dalam python!*

> *Cari di web kafe terbaik di Rennes, Prancis, dan simpan daftar tiga dengan alamatnya di rennes_cafes.txt.*

> *Tulis program Go untuk menghitung faktorial sebuah angka, simpan sebagai factorial.go di workspace Anda*

> *Cari di folder summer_pictures saya untuk semua file JPG, ubah nama dengan tanggal hari ini, dan simpan daftar file yang diganti namanya di photos_list.txt*

> *Cari online film sci-fi populer dari 2024 dan pilih tiga untuk ditonton malam ini. Simpan daftarnya di movie_night.txt.*

> *Cari di web artikel berita AI terbaru dari 2025, pilih tiga, dan tulis skrip Python untuk mengambil judul dan ringkasannya. Simpan skrip sebagai news_scraper.py dan ringkasannya di ai_news.txt di /home/projects*

> *Jumat, cari di web API harga saham gratis, daftar dengan supersuper7434567@gmail.com lalu tulis skrip Python untuk mengambil harga harian Tesla menggunakan API tersebut, dan simpan hasilnya di stock_prices.csv*

*Perlu diperhatikan bahwa kemampuan pengisian formulir masih bersifat eksperimental dan mungkin gagal.*



Setelah Anda mengetikkan pertanyaan, AgenticSeek akan memilih agent terbaik untuk tugas tersebut.

Karena ini adalah prototipe awal, sistem routing agent mungkin tidak selalu memilih agent yang tepat berdasarkan permintaan Anda.

Oleh karena itu, Anda harus sangat eksplisit tentang apa yang Anda inginkan dan bagaimana AI dapat melanjutkan. Misalnya jika Anda ingin melakukan pencarian web, jangan katakan:

`Apakah kamu tahu beberapa negara yang bagus untuk solo-travel?`

Sebaliknya, mintalah:

`Lakukan pencarian web dan cari tahu negara mana yang terbaik untuk solo-travel`

---

## **Pengaturan untuk menjalankan LLM di server Anda sendiri**  

Jika Anda memiliki komputer atau server yang cukup kuat, tetapi ingin menggunakannya dari laptop, Anda dapat menjalankan LLM di server remote menggunakan server llm khusus kami.

Di "server" yang akan menjalankan model AI, dapatkan alamat ip-nya

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip lokal
curl https://ipinfo.io/ip # ip publik
```

Catatan: Untuk Windows atau macOS, gunakan ipconfig atau ifconfig untuk menemukan alamat IP.

Clone repository dan masuk ke folder `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Install kebutuhan khusus server:

```sh
pip3 install -r requirements.txt
```

Jalankan skrip server.

```sh
python3 app.py --provider ollama --port 3333
```

Anda dapat memilih antara menggunakan `ollama` dan `llamacpp` sebagai layanan LLM.


Sekarang di komputer pribadi Anda:

Ubah file `config.ini` untuk mengatur `provider_name` ke `server` dan `provider_model` ke `deepseek-r1:xxb`.
Set `provider_server_address` ke alamat ip mesin yang akan menjalankan model.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Langkah berikutnya: [Mulai layanan dan jalankan AgenticSeek](#Start-services-and-Run)  

---

## Speech to Text

Peringatan: speech to text saat ini hanya berfungsi di mode CLI.

Perlu diperhatikan saat ini speech to text hanya berfungsi dalam bahasa Inggris.

Fitur speech-to-text dinonaktifkan secara default. Untuk mengaktifkannya, atur opsi listen menjadi True di file config.ini:

```
listen = True
```

Saat diaktifkan, fitur speech-to-text akan mendengarkan kata kunci pemicu, yaitu nama agent, sebelum mulai memproses input Anda. Anda dapat menyesuaikan nama agent dengan memperbarui nilai `agent_name` di file *config.ini*:
agent_name = Friday
```

Untuk pengenalan optimal, kami merekomendasikan menggunakan nama umum dalam bahasa Inggris seperti "John" atau "Emma" sebagai nama agen.

Setelah Anda melihat transkrip mulai muncul, ucapkan nama agen dengan keras untuk membangunkannya (mis., "Friday").

Ucapkan pertanyaan Anda dengan jelas.

Akhiri permintaan Anda dengan frasa konfirmasi untuk memberi sinyal sistem untuk melanjutkan. Contoh frasa konfirmasi meliputi:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Konfigurasi

Contoh konfigurasi:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Contoh untuk Ollama; gunakan http://127.0.0.1:1234 untuk LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Daftar bahasa untuk TTS dan kemungkinan routing.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Penjelasan Pengaturan `config.ini`:**

*   **Bagian `[MAIN]`:**
    *   `is_local`: `True` jika menggunakan penyedia LLM lokal (Ollama, LM-Studio, server OpenAI-kompatibel lokal) atau opsi server self-hosted. `False` jika menggunakan API berbasis cloud (OpenAI, Google, dll).
    *   `provider_name`: Menentukan penyedia LLM.
        *   Opsi lokal: `ollama`, `lm-studio`, `openai` (untuk server OpenAI-kompatibel lokal), `server` (untuk setup server self-hosted).
        *   Opsi API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Nama model spesifik atau ID untuk penyedia yang dipilih (mis. `deepseekcoder:6.7b` untuk Ollama, `gpt-3.5-turbo` untuk API OpenAI, `mistralai/Mixtral-8x7B-Instruct-v0.1` untuk TogetherAI).
    *   `provider_server_address`: Alamat dari penyedia LLM Anda.
        *   Untuk penyedia lokal: mis. `http://127.0.0.1:11434` untuk Ollama, `http://127.0.0.1:1234` untuk LM-Studio.
        *   Untuk tipe penyedia `server`: Alamat server LLM self-hosted Anda (mis., `http://your_server_ip:3333`).
        *   Untuk API cloud (`is_local = False`): Ini sering diabaikan atau bisa dibiarkan kosong, karena endpoint API biasanya ditangani oleh library klien.
    *   `agent_name`: Nama asisten AI (mis., Friday). Digunakan sebagai kata pemicu untuk speech-to-text jika diaktifkan.
    *   `recover_last_session`: `True` untuk mencoba memulihkan status sesi sebelumnya, `False` untuk memulai dari awal.
    *   `save_session`: `True` untuk menyimpan status sesi saat ini untuk pemulihan potensial, `False` jika tidak.
    *   `speak`: `True` untuk mengaktifkan output suara text-to-speech, `False` untuk menonaktifkan.
    *   `listen`: `True` untuk mengaktifkan input suara speech-to-text (hanya mode CLI), `False` untuk menonaktifkan.
    *   `work_dir`: **Penting:** Direktori tempat AgenticSeek akan membaca/menulis file. **Pastikan path ini valid dan dapat diakses di sistem Anda.**
    *   `jarvis_personality`: `True` untuk menggunakan prompt sistem bergaya "Jarvis" (eksperimental), `False` untuk prompt standar.
    *   `languages`: Daftar bahasa yang dipisahkan koma (mis., `en, zh, fr`). Digunakan untuk pemilihan suara TTS (default ke yang pertama) dan dapat membantu router LLM. Hindari terlalu banyak atau bahasa yang sangat mirip demi efisiensi router.
*   **Bagian `[BROWSER]`:**
    *   `headless_browser`: `True` untuk menjalankan browser otomatis tanpa jendela terlihat (direkomendasikan untuk antarmuka web atau penggunaan non-interaktif). `False` untuk menampilkan jendela browser (berguna untuk mode CLI atau debugging).
    *   `stealth_mode`: `True` untuk mengaktifkan langkah-langkah agar otomatisasi browser lebih sulit terdeteksi. Mungkin memerlukan instalasi ekstensi browser secara manual seperti anticaptcha.


Bagian ini merangkum tipe penyedia LLM yang didukung. Konfigurasikan di `config.ini`.

**Penyedia Lokal (Jalankan di Perangkat Anda Sendiri):**

| Nama Penyedia di `config.ini` | `is_local` | Deskripsi                                                                  | Bagian Setup                                                     |
|-------------------------------|------------|---------------------------------------------------------------------------|------------------------------------------------------------------|
| `ollama`                      | `True`     | Gunakan Ollama untuk melayani LLM lokal.                                   | [Setup untuk menjalankan LLM secara lokal](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Gunakan LM-Studio untuk melayani LLM lokal.                                | [Setup untuk menjalankan LLM secara lokal](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `openai` (untuk server lokal) | `True`     | Koneksi ke server lokal yang menyediakan API OpenAI-kompatibel (mis., llama.cpp). | [Setup untuk menjalankan LLM secara lokal](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Koneksi ke server LLM AgenticSeek self-hosted yang berjalan di mesin lain. | [Setup untuk menjalankan LLM di server Anda sendiri](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-the-llm-on-your-own-server) |

**Penyedia API (Berbasis Cloud):**

| Nama Penyedia di `config.ini` | `is_local` | Deskripsi                                      | Bagian Setup                                         |
|-------------------------------|------------|------------------------------------------------|------------------------------------------------------|
| `openai`                      | `False`    | Gunakan API resmi OpenAI (mis., GPT-3.5, GPT-4). | [Setup untuk menjalankan dengan API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `google`                      | `False`    | Gunakan model Gemini Google via API.            | [Setup untuk menjalankan dengan API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Gunakan API resmi Deepseek.                     | [Setup untuk menjalankan dengan API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Gunakan Hugging Face Inference API.             | [Setup untuk menjalankan dengan API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | Gunakan API TogetherAI untuk berbagai model open.| [Setup untuk menjalankan dengan API](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |

---
## Pemecahan Masalah

Jika Anda mengalami masalah, bagian ini menyediakan panduan.

# Masalah Dikenal

## Masalah ChromeDriver

**Contoh Error:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Penyebab:** Versi ChromeDriver yang Anda instal tidak kompatibel dengan versi browser Google Chrome Anda.
*   **Solusi:**
    1.  **Cek Versi Chrome:** Buka Google Chrome, pergi ke `Settings > About Chrome` untuk menemukan versi Anda (mis., "Version 120.0.6099.110").
    2.  **Unduh ChromeDriver yang Cocok:**
        *   Untuk Chrome versi 115 ke atas: Buka [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Temukan channel "stable" dan unduh ChromeDriver untuk OS Anda yang sesuai dengan versi mayor Chrome Anda.
        *   Untuk versi lebih lama (jarang): Anda bisa menemukannya di halaman [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   Gambar di bawah menunjukkan contoh dari halaman CfT:
            ![Unduh versi spesifik Chromedriver dari halaman Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Instal ChromeDriver:**
        *   Pastikan file `chromedriver` yang diunduh (atau `chromedriver.exe` di Windows) diletakkan di direktori yang terdaftar di variabel lingkungan PATH sistem Anda (mis., `/usr/local/bin` di Linux/macOS, atau folder skrip khusus yang ditambahkan ke PATH di Windows).
        *   Atau, letakkan di direktori root proyek `agenticSeek`.
        *   Pastikan driver dapat dieksekusi (mis., `chmod +x chromedriver` di Linux/macOS).
    4.  Lihat bagian [Instalasi ChromeDriver](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#chromedriver-installation) di panduan Instalasi utama untuk detail lebih lanjut.

Jika bagian ini tidak lengkap atau Anda mengalami masalah ChromeDriver lainnya, silakan cari [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) yang sudah ada atau ajukan yang baru.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Ini terjadi jika ada ketidakcocokan antara versi browser dan chromedriver Anda.

Anda perlu mengunjungi tautan berikut untuk mengunduh versi terbaru:

https://developer.chrome.com/docs/chromedriver/downloads

Jika Anda menggunakan Chrome versi 115 atau lebih baru, kunjungi:

https://googlechromelabs.github.io/chrome-for-testing/

Dan unduh versi chromedriver yang sesuai dengan OS Anda.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Jika bagian ini tidak lengkap, silakan ajukan issue.

## Masalah connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Catatan: port bisa berbeda)
```

*   **Penyebab:** `provider_server_address` di `config.ini` untuk `lm-studio` (atau server OpenAI-kompatibel lokal sejenis) tidak memiliki awalan `http://` atau menunjuk ke port yang salah.
*   **Solusi:**
    *   Pastikan alamat sudah termasuk `http://`. LM-Studio biasanya default ke `http://127.0.0.1:1234`.
    *   Perbaiki `config.ini`: `provider_server_address = http://127.0.0.1:1234` (atau port server LM-Studio Anda yang sebenarnya).

## SearxNG Base URL Tidak Diberikan

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**T: Perangkat keras apa yang saya butuhkan?**  

| Ukuran Model | GPU           | Komentar                                                                                   |
|--------------|---------------|-------------------------------------------------------------------------------------------|
| 7B           | 8GB Vram      | ⚠️ Tidak direkomendasikan. Performa buruk, sering halusinasi, dan agen planner kemungkinan gagal. |
| 14B          | 12 GB VRAM (mis. RTX 3060) | ✅ Dapat digunakan untuk tugas sederhana. Mungkin kesulitan untuk browsing web dan tugas perencanaan. |
| 32B          | 24+ GB VRAM (mis. RTX 4090) | 🚀 Berhasil untuk sebagian besar tugas, mungkin masih kesulitan untuk perencanaan tugas |
| 70B+         | 48+ GB Vram   | 💪 Sangat baik. Direkomendasikan untuk kasus penggunaan lanjutan. |

**T: Saya mendapatkan error, apa yang harus saya lakukan?**  

Pastikan lokal sudah berjalan (`ollama serve`), `config.ini` Anda sesuai dengan penyedia Anda, dan dependensi terinstal. Jika tidak ada yang berhasil silakan ajukan issue.

**T: Apakah benar-benar bisa berjalan 100% lokal?**  

Ya, dengan penyedia Ollama, lm-studio atau server, semua speech to text, LLM dan text to speech model berjalan secara lokal. Opsi non-lokal (OpenAI atau API lainnya) bersifat opsional.

**T: Mengapa saya harus menggunakan AgenticSeek padahal saya punya Manus?**

Berbeda dengan Manus, AgenticSeek mengutamakan kemandirian dari sistem eksternal, memberi Anda lebih banyak kontrol, privasi dan menghindari biaya API.

**T: Siapa di balik proyek ini?**

Proyek ini dibuat oleh saya, bersama dua teman yang menjadi maintainer dan kontributor dari komunitas open-source di GitHub. Kami hanyalah sekelompok individu yang antusias, bukan startup atau terafiliasi dengan organisasi manapun.

Setiap akun AgenticSeek di X selain akun pribadi saya (https://x.com/Martin993886460) adalah akun peniru.

## Berkontribusi

Kami mencari developer untuk meningkatkan AgenticSeek! Lihat issue terbuka atau diskusi.

[Panduan Kontribusi](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Maintainer:

 > [Fosowl](https://github.com/Fosowl) | Waktu Paris 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Waktu Taipei 

 > [steveh8758](https://github.com/steveh8758) | Waktu Taipei 

## Ucapan Terima Kasih Khusus:

 > [tcsenpai](https://github.com/tcsenpai) dan [plitc](https://github.com/plitc) untuk bantuan dockerisasi backend

## Sponsor:

Sponsor bulanan 5$ atau lebih tampil di sini:
- **tatra-labs**
Certainly! However, it appears that you haven't provided the content of Part 4 of 4 to be translated. Please provide the text of the technical document (Part 4), and I will translate it into Indonesian while preserving the original Markdown format and adjusting the relative paths as requested.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---