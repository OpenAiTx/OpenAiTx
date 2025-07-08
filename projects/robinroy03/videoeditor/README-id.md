<samp>
  
<h1>Editor Video Open-Source</h1>
<p>Bukan Aplikasi Editor Video biasa menggunakan React, Remotion & TypeScript.</p>
<br />

> [!NOTE]  
> Aplikasi ini sedang dalam pengembangan aktif. Ini adalah MVP awal. Silakan bergabung dengan [server Discord](https://discord.gg/GSknuxubZK) jika Anda ingin menjalankannya.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="Tangkapan Layar Editor Video React">
</p>
<p align="center">Alternatif open-source untuk Capcut, Canva, dan RVE.</p>
</samp>

## ✨Fitur

- 🎬Pengeditan Video Non Linear
- 🔀Dukungan Multi-track
- 👀Pratinjau Langsung
- 📤Ekspor Video
- 📜Berlisensi MIT

## 🐋Deploy

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻Pengembangan

```
pnpm i
pnpm run dev (frontend)
pnpm dlx tsx app/videorender/videorender.ts (backend)
uv run backend/main.py
ubah `isProduction` menjadi `false` di `/app/utils/api.ts`

Anda juga memerlukan GEMINI_API_KEY jika ingin menggunakan AI.
```

## 📃TODO

Kami punya banyak pekerjaan! Sebagai permulaan, kami berencana mengintegrasikan semua API Remotion. Saya akan menambahkan roadmap yang lebih jelas segera. Bergabunglah dengan [Server Discord](https://discord.com/invite/GSknuxubZK) untuk pembaruan dan dukungan.

## ❤️Kontribusi

Kami sangat menghargai kontribusi Anda! ❤️ Lihat [panduan kontribusi](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜Lisensi

Proyek ini dilisensikan di bawah Lisensi MIT. [Lisensi Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) juga berlaku untuk bagian-bagian proyek yang relevan.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---