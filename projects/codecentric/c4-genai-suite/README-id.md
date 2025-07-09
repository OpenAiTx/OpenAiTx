# c4 GenAI Suite

Aplikasi chatbot AI dengan integrasi Model Context Provider (MCP), didukung oleh Langchain dan kompatibel dengan semua Large Language Models (LLM) utama serta Model Embedding.

Administrator dapat membuat asisten dengan kemampuan berbeda dengan menambahkan ekstensi, seperti layanan RAG (Retrieval-Augmented Generation) atau server MCP. Aplikasi ini dibangun menggunakan tumpukan teknologi modern, termasuk React, NestJS, dan Python FastAPI untuk layanan REI-S.

Pengguna dapat berinteraksi dengan asisten melalui antarmuka yang ramah pengguna. Tergantung pada konfigurasi asisten, pengguna dapat mengajukan pertanyaan, mengunggah file mereka sendiri, atau menggunakan fitur lainnya. Para asisten berinteraksi dengan berbagai penyedia LLM untuk memberikan respons berdasarkan ekstensi yang dikonfigurasi. Informasi kontekstual yang disediakan oleh ekstensi yang dikonfigurasi memungkinkan asisten menjawab pertanyaan spesifik domain dan memberikan informasi yang relevan.

Aplikasi ini dirancang secara modular dan dapat diperluas, memungkinkan pengguna membuat asisten dengan kemampuan berbeda dengan menambahkan ekstensi.

![video demo singkat penggunaan dasar](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Fitur

### Large Language Models (LLM) dan Model Multimodal

c4 GenAI Suite sudah mendukung banyak model secara langsung. Jika model pilihan Anda belum didukung, seharusnya mudah untuk menulis ekstensi guna mendukungnya.

* Model yang kompatibel dengan OpenAI
* Model Azure OpenAI
* Model Bedrock
* Model Google GenAI
* Model yang kompatibel dengan Ollama
### Retrieval Augmented Generation (RAG)

c4 GenAI Suite mencakup REI-S, sebuah server untuk menyiapkan file agar dapat digunakan oleh LLM.

* REI-S, server RAG terintegrasi khusus
  * Penyimpanan vektor
    * pgvector
    * Azure AI Search
  * Model embedding
    * Embedding kompatibel OpenAI
    * Embedding Azure OpenAI
    * Embedding kompatibel Ollama
  * Format file:
    * pdf, docx, pptx, xlsx, ...
    * transkripsi suara file audio (melalui Whisper)

### Ekstensi

c4 GenAI Suite dirancang untuk dapat diperluas. Menulis ekstensi sangat mudah, begitu juga menggunakan server MCP yang sudah ada.

* Server Model Context Protocol (MCP)
* Systemprompt kustom
* Pencarian Bing
* Kalkulator
## Memulai

### Menggunakan Docker-Compose

- Jalankan `docker compose up` di root proyek.
- Buka [aplikasi](http://localhost:3333) di browser. Kredensial login default adalah user `admin@example.com` dan password `secret`.

![video menunjukkan konfigurasi asisten](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Menggunakan Helm & Kubernetes

Untuk deployment di lingkungan Kubernetes, silakan merujuk ke [README dari Helm Chart kami](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Menyiapkan Asisten dan Ekstensi

c4 GenAI Suite berpusat pada *asisten*.
Setiap asisten terdiri dari satu set ekstensi, yang menentukan model LLM dan alat apa yang dapat digunakannya.

- Di area admin (klik nama pengguna di kiri bawah), pergi ke [bagian asisten](http://localhost:3333/admin/assistants).
- Tambahkan asisten dengan tombol hijau `+` di sebelah judul bagian. Pilih nama dan deskripsi.
- Pilih asisten yang telah dibuat dan klik hijau `+ Add Extension`.
- Pilih model dan isi kredensial.
- Gunakan tombol `Test` untuk memeriksa apakah sudah berfungsi dan `save`.

Sekarang Anda dapat kembali ke [halaman chat](http://localhost:3333/chat) (klik pada `c4 GenAI Suite` di kiri atas) dan memulai percakapan baru dengan asisten baru Anda.

> [!TIP]
> `docker-compose` kami sudah termasuk Ollama lokal, yang berjalan di CPU. Anda dapat menggunakannya untuk pengujian cepat. Namun kecepatannya lambat dan Anda mungkin ingin menggunakan model lain. Jika ingin menggunakannya, cukup buat ekstensi model berikut di Asisten Anda.
> * Ekstensi: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Model: `llama3.2`

### Model Context Protocol (MCP) [opsional]

Gunakan server MCP apa pun yang menyediakan antarmuka `sse` dengan Ekstensi `MCP Tools` (atau gunakan `mcp-tool-as-server` kami sebagai proxy di depan server MCP `stdio`).
Setiap server MCP dapat dikonfigurasi secara detail sebagai ekstensi.

### Retrieval Augmented Generation (RAG) / Pencarian Berkas [opsional]

Gunakan server RAG kami `REI-S` untuk mencari berkas yang disediakan pengguna. Cukup konfigurasikan ekstensi `Search Files` untuk asisten.
Proses ini dijelaskan secara rinci di [subdirektori `services/reis`](services/reis/#example-configuration-in-c4).

## Kontribusi & Pengembangan

* Lihat [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) untuk panduan cara berkontribusi.
* Untuk onboarding pengembang, periksa [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Blok Bangunan Utama

Aplikasi ini terdiri dari **Frontend**, **Backend**, dan layanan **REI-S**.

```
┌──────────┐
│  Pengguna│
└─────┬────┘
      │ akses
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ akses
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ akses
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Embedding Model │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Vector Store   │
└──────────┘     └─────────────────┘
```
### Frontend

Frontend dibangun dengan React dan TypeScript, menyediakan antarmuka yang ramah pengguna untuk berinteraksi dengan backend dan layanan REI-S. Frontend ini mencakup fitur untuk mengelola asisten, ekstensi, dan fungsionalitas chat.

> Sumber: `/frontend`

### Backend

Backend dikembangkan menggunakan NestJS dan TypeScript, berfungsi sebagai lapisan API utama untuk aplikasi. Backend menangani permintaan dari frontend dan berinteraksi dengan penyedia llm untuk memfasilitasi fungsionalitas chat. Backend juga mengelola asisten dan ekstensi mereka, memungkinkan pengguna untuk mengonfigurasi dan menggunakan berbagai model AI untuk chat mereka.

Selain itu, backend mengelola autentikasi pengguna, dan berkomunikasi dengan layanan REI-S untuk pengindeksan dan pengambilan file.

Untuk persistensi data, backend menggunakan database **PostgreSQL**.

> Sumber: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) adalah server berbasis Python yang menyediakan kemampuan dasar RAG (Retrieval-Augmented Generation). Server ini memungkinkan ekstraksi konten file, pengindeksan, dan pencarian, sehingga aplikasi dapat menangani dataset besar secara efisien. Layanan REI-S dirancang agar dapat bekerja secara mulus dengan backend, menyediakan data yang diperlukan untuk fungsionalitas chat dan pencarian file.

REI-S mendukung Azure AI Search dan pgvector untuk penyimpanan vektor, memungkinkan opsi pengambilan data yang fleksibel dan skalabel. Layanan ini dapat dikonfigurasi menggunakan variabel lingkungan untuk menentukan jenis penyimpanan vektor dan detail koneksi.

> Sumber: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---