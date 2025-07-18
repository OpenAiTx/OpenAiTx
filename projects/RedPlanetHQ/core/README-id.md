<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E: Otak digital Anda untuk era AI

<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Dokumentasi</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine**

C.O.R.E adalah grafik memori portabel yang dibangun dari interaksi llm dan data pribadi Anda, membuat semua konteks dan riwayat alur kerja Anda dapat diakses oleh alat AI mana pun, layaknya otak digital. Ini menghilangkan kebutuhan untuk berbagi konteks berulang kali. Tujuannya adalah untuk menyediakan:

- **Memori Terpadu & Portabel**: Tambahkan dan ingat konteks dengan mulus, serta hubungkan memori Anda di aplikasi seperti Claude, Cursor, Windsurf dan lainnya.
- **Relasional, Bukan Hanya Fakta Datar**: CORE mengatur pengetahuan Anda, menyimpan fakta sekaligus hubungan untuk memori yang lebih dalam dan kaya layaknya otak sungguhan.
- **Dimiliki Pengguna**: Anda yang memutuskan apa yang ingin disimpan, diperbarui atau dihapus, serta membagikan memori Anda ke alat mana pun yang diinginkan tanpa terikat vendor.

## 🎥 Video Demo

[Lihat Demo C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Fitur Utama

- **Memory Graph**: Visualisasikan bagaimana fakta dan preferensi Anda saling terhubung
- **Chat dengan Memori**: Ajukan pertanyaan tentang memori untuk wawasan dan pemahaman instan
- **Plug n Play**: Langsung gunakan memori CORE di aplikasi seperti Cursor, Claude

## ☁️ Pengaturan C.O.R.E Cloud

1. Daftar ke [Core Cloud](https://core.heysol.ai) dan mulai membangun memory graph Anda.
2. Tambahkan teks yang ingin Anda simpan dalam memori. Setelah klik tombol `+ Add`, grafik memori Anda akan dibuat.
3. [Hubungkan Core Memory MCP dengan Cursor](#connecting-core-mcp-with-cursor)

## 💻 Pengaturan C.O.R.E Lokal

#### Prasyarat

1. Docker
2. OpenAI API Key


> **Catatan:** Kami terus bekerja untuk meningkatkan dukungan model Llama. Saat ini, C.O.R.E belum memberikan hasil optimal dengan model berbasis Llama, namun kami sedang berprogres untuk memastikan kompatibilitas dan output yang lebih baik di waktu mendatang.
> 
#### Jalankan C.O.R.E secara lokal

1. **Salin Variabel Lingkungan**

   Salin file contoh environment ke `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Mulai Aplikasi**

   Gunakan Docker Compose untuk memulai semua layanan yang diperlukan:


   ```bash
   docker-compose up
   ```
3. **Akses Aplikasi**

   Setelah kontainer berjalan, buka browser Anda dan pergi ke [http://localhost:3000](http://localhost:3000).

4. **Buat Akun dengan Magic Link**

   - Untuk membuat akun, klik tombol `Continue with email`

     <img width="865" height="490" alt="Create account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Masukkan email Anda dan klik tombol `Send a Magic Link`

     <img width="824" height="429" alt="Enter email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Salin magic link dari log terminal` dan buka di browser Anda

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Buat Ruang Pribadi & Tambahkan Data**

   - Di dashboard, pergi ke bagian kanan atas -> Ketik pesan, misal `Saya suka bermain bulu tangkis`, lalu klik `+Add`.
   - Memori Anda akan masuk antrean pemrosesan; Anda dapat memantau statusnya di bagian `Logs`.
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Setelah pemrosesan selesai, node akan ditambahkan ke knowledge graph pribadi Anda dan terlihat di dashboard.
   - Anda dapat memilih untuk menghubungkan memori ini ke alat lain atau tetap menjaganya tetap privat.

6. **Cari Memori Anda**

   - Gunakan fitur pencarian di dashboard untuk menelusuri data yang telah Anda masukkan dalam ruang privat Anda.


## Menghubungkan CORE MCP dengan Cursor

1. Buka dashboard CORE dan navigasi ke bagian API untuk membuat token API baru.
2. Di Cursor, masuk ke: Settings → Tools & Integrations → New MCP Server.
3. Tambahkan server CORE MCP menggunakan format konfigurasi di bawah ini. Pastikan untuk mengganti nilai API_TOKEN dengan token yang Anda buat di langkah 1.

   Konfigurasi MCP untuk ditambahkan di Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Pergi ke Pengaturan-> Aturan Pengguna -> Aturan Baru -> dan tambahkan aturan di bawah ini untuk memastikan semua interaksi chat Anda disimpan di memori CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Dokumentasi

Jelajahi dokumentasi kami untuk memaksimalkan penggunaan CORE
- [Konsep Dasar](https://docs.heysol.ai/core/overview)
- [Referensi API](https://docs.heysol.ai/core/local-setup)
- [Hubungkan Core Memory MCP dengan Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Dukungan
Punya pertanyaan atau masukan? Kami siap membantu:
- Discord: [Bergabung di channel core-support](https://discord.gg/YGUZcvDjUa)
- Dokumentasi: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- Email: manik@poozle.dev

## Pedoman Penggunaan

**Simpan:**

- Riwayat percakapan
- Preferensi pengguna
- Konteks tugas
- Materi referensi

**Jangan Simpan:**

- Data sensitif (PII)
- Kredensial
- Log sistem
- Data sementara

## 👥 Kontributor

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---