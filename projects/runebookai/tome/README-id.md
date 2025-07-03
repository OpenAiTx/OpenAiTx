# Tome - Buku Mantra AI Ajaib

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>aplikasi desktop ajaib yang memberikan kekuatan LLM dan MCP ke tangan semua orang</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Bergabunglah dengan Kami di Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="Lisensi: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="Rilis GitHub" /></a>
</p>

<p align="center">
    🔮 Unduh Aplikasi Desktop Tome: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome adalah aplikasi desktop yang memungkinkan **siapa saja** memanfaatkan keajaiban LLM dan MCP. Unduh Tome, hubungkan LLM lokal atau jarak jauh apa pun, dan sambungkan ke ribuan server MCP untuk membuat buku mantra AI ajaib milikmu sendiri.

🫥 Ingin semuanya 100% lokal, 100% privat? Gunakan Ollama dan Qwen3 hanya dengan server MCP lokal untuk merapal mantra di semesta saku milikmu sendiri. ⚡ Ingin model cloud tercanggih dengan server MCP jarak jauh terbaru? Kamu juga bisa memilikinya. Semuanya terserah kamu!

🏗️ Ini adalah Pratinjau Teknis jadi harap maklum jika masih ada kekurangan di sana-sini. [Bergabunglah dengan kami di Discord](https://discord.gg/9CH6us29YA) untuk berbagi tips, trik, dan masalah yang kamu temui. Bintangi repo ini untuk terus mendapat pembaruan dan rilis fitur!

## 🪄 Fitur

- 🧙 **Pengalaman Ramah Pemula yang Sederhana**
  - Cukup unduh dan instal Tome lalu hubungkan LLM pilihanmu
  - Tanpa repot mengatur JSON, Docker, python, atau node
- 🤖 **Dukungan Model AI**
  - **Jarak Jauh**: Google Gemini, OpenAI, endpoint kompatibel API OpenAI lainnya
  - **Lokal**: Ollama, LM Studio, Cortex, endpoint kompatibel API OpenAI lainnya
- 🔮 **Dukungan MCP yang Ditingkatkan**
  - UI untuk instalasi, menghapus, mengaktifkan/nonaktifkan server MCP
  - Server MCP npm, uvx, node, python semuanya didukung secara langsung
- 🏪 **Integrasi dengan [Smithery.ai](https://smithery.ai) registry**
  - Ribuan server MCP tersedia melalui instalasi sekali klik
- ✏️ **Kustomisasi jendela konteks dan temperatur**
- 🧰 **Dukungan native untuk tool call dan reasoning model**
  - Peningkatan UI yang membedakan dengan jelas antara tool call dan pesan berpikir

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Memulai

## Persyaratan

- MacOS atau Windows (Linux segera hadir!)
- Penyedia LLM pilihanmu: [Ollama](https://ollama.com/) atau [Gemini API key](https://aistudio.google.com/app/apikey) adalah yang mudah/gratis
- [Unduh rilis terbaru Tome](https://github.com/runebookai/tome/releases)

## Quickstart

1. Instal [Tome](https://github.com/runebookai/tome/releases)
2. Hubungkan penyedia LLM pilihanmu - OpenAI, Ollama dan Gemini sudah tersedia secara preset, tetapi kamu juga dapat menambah penyedia seperti LM Studio dengan menggunakan http://localhost:1234/v1 sebagai URL-nya
3. Buka tab MCP di Tome dan instal [server MCP](https://github.com/modelcontextprotocol/servers) pertamamu (Fetch adalah yang mudah untuk memulai, cukup tempelkan `uvx mcp-server-fetch` ke kolom server).
4. Chat dengan model berbasis MCP milikmu! Minta untuk mengambil berita utama di Hacker News.

# Visi

Kami ingin membuat LLM lokal dan MCP dapat diakses oleh semua orang. Kami membangun alat yang memungkinkan kamu berkreasi dengan LLM, terlepas dari apakah kamu seorang engineer, tukang oprek, hobiis, atau siapa pun di antaranya.

## Prinsip Inti

- **Tome mengutamakan lokal:** Kamu mengendalikan ke mana data milikmu pergi.
- **Tome untuk semua orang:** Kamu tidak perlu mengatur bahasa pemrograman, package manager, atau file konfigurasi json.

## Selanjutnya

Kami telah menerima banyak masukan luar biasa dalam beberapa minggu terakhir sejak merilis Tome, tetapi kami punya rencana besar untuk ke depannya. Kami ingin membawa LLM keluar dari kotak chat-nya, dan banyak fitur akan hadir untuk membantu kalian melakukan hal itu.

- Tugas terjadwal: LLM harus bisa melakukan hal-hal bermanfaat bahkan saat kamu tidak di depan komputer.
- Integrasi native: Server MCP adalah cara hebat mengakses alat dan informasi, tapi kami ingin menambahkan integrasi yang lebih kuat untuk berinteraksi dengan LLM dengan cara unik.
- Pembuat aplikasi: kami percaya, dalam jangka panjang, pengalaman terbaik tidak akan berada di antarmuka chat. Kami berencana menambah alat tambahan yang memungkinkan kamu membuat aplikasi dan alur kerja yang kuat.
- ??? Beri tahu kami apa yang ingin kamu lihat! Bergabunglah dengan komunitas kami melalui tautan di bawah ini, kami ingin mendengar pendapatmu.

# Komunitas

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---