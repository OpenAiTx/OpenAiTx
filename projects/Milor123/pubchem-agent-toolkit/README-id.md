
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Server PubChem MCP yang Ditingkatkan untuk Asisten AI

🧪 Server MCP yang canggih, kuat, dan berfokus pada privasi yang memungkinkan asisten AI mencari dan mengakses informasi senyawa kimia dari PubChem secara cerdas.

Server PubChem MCP ini berfungsi sebagai jembatan yang kuat antara asisten AI (seperti pada AnythingLLM) dan basis data kimia PubChem yang sangat luas. Server ini memanfaatkan Model Context Protocol (MCP) untuk memungkinkan model AI melakukan pencarian senyawa kimia secara cerdas dan tangguh serta mengambil detail propertinya secara terprogram.

---

## ✨ Fitur Utama

Ini bukan sekadar pembungkus PubChem biasa. Server ini dibangun ulang dari awal agar sangat tangguh dan cerdas:

-   **🧠 Pencarian Fallback Cerdas**: Jika pencarian nama umum (seperti "Vitamin D") gagal, server otomatis melakukan pencarian lebih dalam di basis data Substansi PubChem untuk menemukan senyawa yang benar. Ini sangat meningkatkan tingkat keberhasilan untuk kueri ambigu.
-   **🛡️ Penanganan Error & Retry yang Tangguh**: Server ini dirancang untuk menangani error API dengan baik. Jika menemui error "Server Busy" dari PubChem, server akan otomatis menunggu dan mencoba ulang permintaan, memastikan kueri Anda tetap berhasil meski saat beban tinggi.
-   **🔒 Dukungan Proxy Tor Opsional**: Anda memiliki kontrol penuh atas privasi Anda. File `config.ini` sederhana memungkinkan Anda merutekan semua permintaan melalui jaringan Tor (via SOCKS5 atau proxy HTTP), mencegah alamat IP Anda terungkap. Server aman secara default dan **tidak akan pernah** membocorkan IP Anda jika koneksi proxy gagal.
-   **🔎 Pencarian Senyawa Tunggal & Multiple**: Menangani permintaan untuk satu atau beberapa senyawa dalam satu prompt dengan mulus.
-   **🧪 Pengambilan Properti Detail**: Akses properti kimia utama seperti Nama IUPAC, Rumus Molekul, Berat Molekul, dan yang penting, **Massa Monoisotopik**.

---

---

### 🚀 Tanpa Instalasi: Coba Langsung di Smithery.ai

Untuk Anda yang baru mengenal server MCP atau sekadar ingin mencoba kemampuan alat ini tanpa instalasi lokal, versi live dan terhosting tersedia di Smithery.ai. Anda dapat langsung berbincang dengan agen melalui browser Anda.

[**<-- Jelajahi Agen PubChem Live di Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Cara memulai:**

1.  Klik tautan di atas untuk menuju halaman server.
2.  Masuk menggunakan akun **GitHub** atau **Google** Anda.
3.  Klik tombol **"Explore capabilities"** untuk membuka antarmuka chat dan mulai mencoba!

> **✅ Rekomendasi Model untuk Hasil Terbaik**
>
> Untuk akurasi tertinggi, terutama untuk angka desimal panjang, kami sangat menyarankan menggunakan model yang kuat. Berikut ini telah diuji dan bekerja sangat baik dengan alat ini:
>
> *   **Claude 3 Sonnet dari Anthropic**
> *   **GPT-4 Turbo dari OpenAI** (atau versi yang lebih baru seperti GPT-4o)
>
> Kami telah memastikan bahwa kedua model memproses presisi penuh dari angka desimal yang dikembalikan oleh alat tanpa pembulatan.

---

## 🚀 Mulai Cepat & Instalasi

Server ini dirancang untuk dijalankan secara lokal, baik di desktop Anda maupun di lingkungan Docker AnythingLLM.

### 1. Ketergantungan

Proyek ini bergantung pada beberapa pustaka Python. Pastikan pustaka tersebut telah terpasang di lingkungan Anda.

Buat file `requirements.txt` dengan isi sebagai berikut:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Instal menggunakan `uv` atau `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Catatan: `PySocks` hanya diperlukan jika Anda berencana menggunakan fitur proxy Tor SOCKS5.)*

### 2. Konfigurasi

Server dikonfigurasi melalui file `config.ini` yang **secara otomatis dibuat** saat pertama kali Anda menjalankannya. File ini akan muncul di direktori yang sama dengan skrip `pubchem_server.py`.

**`config.ini` bawaan:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integrasi dengan AnythingLLM

Ikuti dokumentasi resmi untuk menambahkan ini sebagai server MCP khusus. Kuncinya adalah mengarahkan `command` ke executable Python Anda dan skrip `pubchem_server.py`.

**Contoh untuk AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Contoh Implementasi dengan AnythingLLM

Berikut adalah beberapa contoh cara berinteraksi dengan agen. Pengujian ini dilakukan menggunakan AnythingLLM Desktop, yang terhubung ke berbagai Model Bahasa Besar melalui OpenRouter.

Temuan penting dari pengujian kami adalah pentingnya pemilihan model. Kami **sangat menyarankan untuk tidak menggunakan model kecil atau lokal** untuk tugas ini. Model yang lebih kecil seringkali kesulitan untuk secara benar menguraikan data yang dikembalikan oleh alat, sehingga menyebabkan kesalahan seperti nilai yang dihalusinasi, format yang salah, atau yang paling kritis, **pembulatan angka desimal**, yang menghilangkan tujuan alat berpresisi tinggi ini.

Untuk memastikan integritas hasil Anda, selalu merupakan praktik yang baik untuk memverifikasi data mentah yang dikembalikan oleh MCP. Anda dapat mempelajari cara melakukannya di bagian berikut: [3.2 Cara memverifikasi keluaran MCP di log](#32-cara-memverifikasi-keluaran-mcp-di-log).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Di sisi lain, beberapa model telah menunjukkan performa yang sangat baik. Kami mendapatkan hasil yang luar biasa dengan **Google `Gemini 2.5 Flash lite`**. Model ini menunjukkan presisi tinggi dalam menangani angka desimal panjang dan memformat tabel Markdown akhir dengan benar.

Google gemini 2.5 flash lite tanpa prompt dan dengan prompt menjaga angka desimal tetap sempurna (pada contoh menggunakan temperatur 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Untuk tugas spesifik ini, favorit pribadi saya adalah **`Gemini 2.5 Flash lite`** karena konsistensi akurasi dan keandalannya.

### 3.2 Cara Memverifikasi Keluaran MCP di Log

Cara terbaik untuk memastikan bahwa agen menerima data yang benar dan bahwa LLM tidak melakukan kesalahan adalah dengan memeriksa file log debug yang dihasilkan oleh server MCP.

Server ini dikonfigurasi untuk secara otomatis membuat file log di subfolder dalam direktori proyek Anda. Lokasinya adalah:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Di dalam `mcp_debug.log`, Anda akan menemukan data JSON persis yang dikirimkan alat kembali ke LLM *sebelum* model memprosesnya. Anda dapat memeriksa JSON ini secara manual untuk memverifikasi nilai apa pun, khususnya angka desimal panjang dari properti seperti `monoisotopic_mass`, memastikan bahwa LLM tidak memperkenalkan kesalahan pembulatan atau halusinasi dalam jawaban akhirnya.

---

## 📊 Penggunaan

Setelah terintegrasi, asisten AI Anda akan secara otomatis menggunakan alat ini saat diminta informasi kimia. Alat utama yang disediakan adalah `search_compounds_by_name`.

### Contoh Prompt

Prompt ini menunjukkan kemampuan alat untuk menangani daftar senyawa dengan jenis nama yang beragam dan mengambil beberapa properti.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Agen akan memanggil alat `search_compounds_by_name`, yang akan secara cerdas mencari setiap senyawa, mengambil datanya, dan mengembalikannya ke LLM untuk diformat.

---

## 🛠 MCP Tool Terbuka

### `search_compounds_by_name`

Mencari beberapa senyawa berdasarkan nama, satu per satu, menggunakan strategi fallback pintar dengan jeda dan percobaan ulang untuk keandalan maksimal.

**Parameter:**
-   `names` (List[str]): Daftar nama senyawa. Contoh: `["Aspirin", "Ibuprofen"]`

**Mengembalikan:** Daftar kamus, di mana setiap kamus berisi informasi senyawa yang ditemukan atau pesan kesalahan yang merinci alasan kegagalan pencarian untuk senyawa tertentu.

---

## 🙏 Ucapan Terima Kasih

Proyek ini sangat terinspirasi dan dibangun berdasarkan fondasi dari [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) asli yang dibuat oleh **JackKuo666**.

Meskipun repository ini bukan fork langsung, proyek asli adalah titik awal yang krusial. Versi ini meningkatkan konsep asli dengan fokus pada ketahanan ekstrem, strategi pencarian cerdas, dan privasi pengguna melalui integrasi Tor opsional 🧅.

Terima kasih banyak kepada penulis asli atas karya luar biasa mereka dan telah membagikannya kepada komunitas.

---

## ⚠️ Disclaimer

Alat ini ditujukan untuk tujuan riset dan pendidikan. Mohon hormati ketentuan layanan PubChem dan gunakan alat ini secara bertanggung jawab.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---