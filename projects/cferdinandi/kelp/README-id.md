# Kelp

Sebuah pustaka UI untuk orang yang menyukai HTML, didukung oleh CSS modern dan Web Components.

**[Baca Dokumentasi &rarr;](https://kelpui.com)**

_**Catatan:** Kelp saat ini sedang dalam pengembangan tahap alfa. Silakan gunakan, bereksperimen, dan laporkan bug, namun harap pahami bahwa segala sesuatu bisa dan akan berubah seiring waktu._



## Mulai Cepat

Kelp bekerja tanpa langkah build apa pun.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) adalah cara tercepat dan termudah untuk memulai, namun Anda juga bisa [mengunduh file dari GitHub](https://github.com/cferdinandi/kelp) jika lebih suka.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp menggunakan penomoran versi semantik. Anda dapat mengambil versi mayor, minor, atau patch dari CDN dengan sintaks `@1.2.3`. Anda dapat menemukan semua versi yang tersedia [di bawah rilis](https://github.com/cferdinandi/kelp/tags).



## Demo

File `index.html` yang disertakan adalah demo kitchen sink dari Kelp. File ini mencakup semua fitur dan komponen dalam satu file besar.

Selama beta, Kelp tidak memiliki langkah kompilasi. Web component menggunakan ES imports, dan memerlukan server lokal untuk dijalankan.

Gunakan server pilihan Anda, atau gunakan `http-server` yang disertakan dengan menjalankan `npm run dev`.

```bash
npm install
npm run dev
```

Saat Kelp mendekati v1, akan digunakan langkah kompilasi agar hal ini tidak diperlukan lagi.



## Tes

Kelp menggunakan... 

- [Playwright](https://playwright.dev) untuk pengujian
- [Biome](https://biomejs.dev) untuk linting dan formatting
- Proses integrasi berkelanjutan pada setiap deploy dan PR

```bash
# Jalankan tes
npm run test

# Jalankan linter
npm run lint
```



## Lisensi

Gratis digunakan di bawah [Lisensi Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Tersedia juga [opsi lisensi komersial](/license/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---