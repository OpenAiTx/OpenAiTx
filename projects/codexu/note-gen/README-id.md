![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Panduan

NoteGen adalah aplikasi pencatat catatan `Markdown` lintas platform yang didedikasikan untuk menggunakan AI guna menjembatani perekaman dan penulisan, mengorganisir pengetahuan terfragmentasi menjadi sebuah catatan yang dapat dibaca.

🖥️ Dokumen Resmi: [https://notegen.top](https://notegen.top)

💬 Bergabung dengan [Grup WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Mengapa Memilih NoteGen?

- Ringan: [Paket instalasi](https://github.com/codexu/note-gen/releases) hanya **20MB**, gratis tanpa iklan atau perangkat lunak tambahan.
- Lintas platform: Mendukung Mac, Windows, Linux, dan berkat kemampuan lintas platform `Tauri2`, akan mendukung iOS dan Android di masa depan.
- Mendukung berbagai metode pencatatan termasuk `screenshot`, `teks`, `ilustrasi`, `file`, `tautan`, dll, memenuhi kebutuhan pencatatan terfragmentasi di berbagai skenario.
- Format penyimpanan asli `Markdown(.md)`, tanpa modifikasi, mudah untuk migrasi.
- Penggunaan offline secara native, mendukung sinkronisasi real-time ke `GitHub, Gitee private repositories` dengan fitur rollback histori, dan sinkronisasi WebDAV.
- AI-enhanced: Dapat dikonfigurasi dengan ChatGPT, Gemini, Ollama, LM Studio, Grok, dan model lainnya, serta mendukung konfigurasi model pihak ketiga secara kustom.
- RAG: Catatan Anda adalah basis pengetahuan Anda. Mendukung model embedding dan model reranking.

## Tangkapan Layar

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Perekaman:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Penulisan:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Tema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Dari Pencatatan ke Penulisan

Aplikasi pencatat catatan konvensional biasanya tidak menyediakan fitur perekaman. Pengguna harus menyalin dan menempelkan konten secara manual untuk pencatatan, yang sangat mengurangi efisiensi. Ketika menghadapi konten yang tercatat secara terpisah, dibutuhkan usaha besar untuk mengorganisirnya.

NoteGen dibagi menjadi halaman `Pencatatan` dan `Penulisan`, dengan hubungan sebagai berikut:

- Catatan hasil perekaman dapat diorganisir menjadi catatan dan dipindahkan ke halaman penulisan untuk komposisi yang lebih mendalam.
- Selama menulis, Anda dapat menyisipkan hasil perekaman kapan saja.

### Pencatatan

Fitur pencatatan mirip dengan **chatbot AI**, namun saat berinteraksi dengannya, Anda dapat mengaitkan dengan konten yang telah direkam sebelumnya, beralih dari mode percakapan ke mode organisasi untuk mengatur hasil pencatatan menjadi catatan yang dapat dibaca.

Fitur bantu berikut dapat membantu Anda mencatat lebih efektif:

- **Tag** untuk membedakan berbagai skenario pencatatan.
- **Persona** dengan dukungan prompt kustom untuk mengontrol asisten AI Anda secara presisi.
- **Clipboard Assistant** yang secara otomatis mengenali teks atau gambar di clipboard Anda dan mencatatnya ke dalam daftar Anda.

### Penulisan

Bagian penulisan dibagi menjadi dua bagian: **Manajer File** dan **Editor Markdown**.

**Manajer File**

- Mendukung manajemen file Markdown lokal dan file yang disinkronkan ke GitHub.
- Mendukung hierarki direktori tanpa batas.
- Mendukung berbagai metode pengurutan.

**Editor Markdown**

- Mendukung mode WYSIWYG, instant rendering, dan pratinjau split-screen.
- Mendukung kontrol versi dengan rollback histori.
- Mendukung bantuan AI untuk percakapan, melanjutkan, pemolesan, dan fungsi terjemahan.
- Mendukung image hosting, mengunggah gambar dan mengkonversinya ke tautan gambar Markdown.
- Mendukung konversi HTML ke Markdown, secara otomatis mengkonversi konten browser yang disalin ke format Markdown.
- Mendukung outline, rumus matematika, mind map, chart, flowchart, Gantt chart, sequence diagram, staves, multimedia, pembacaan suara, penanda judul, penyorotan dan penyalinan kode, rendering graphviz, dan diagram UML plantuml.
- Mendukung penyimpanan konten lokal secara real-time, sinkronisasi otomatis tertunda (10s tanpa pengeditan), dan rollback histori.

## Fitur Lainnya

- Pencarian global untuk menemukan dan melompat ke konten tertentu dengan cepat.
- Manajemen image hosting untuk memudahkan pengelolaan isi repository gambar.
- Tema dan tampilan dengan dukungan tema gelap dan pengaturan tampilan untuk Markdown, kode, dll.
- Dukungan internasionalisasi, saat ini tersedia dalam Bahasa Mandarin dan Bahasa Inggris.

## Bagaimana Cara Menggunakan?

### Unduh

Saat ini mendukung Mac, Windows, dan Linux. Berkat kemampuan lintas platform Tauri2, akan mendukung iOS dan Android di masa depan.

[Unduh NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Peningkatan

Aplikasi pencatat catatan dapat langsung digunakan tanpa konfigurasi. Jika ingin pengalaman lebih baik, silakan buka halaman pengaturan untuk mengkonfigurasi AI dan sinkronisasi.

## Kontribusi

- [Baca panduan kontribusi](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Rencana pembaruan](https://github.com/codexu/note-gen/issues/46)
- [Laporkan bug atau saran perbaikan](https://github.com/codexu/note-gen/issues)
- [Diskusi](https://github.com/codexu/note-gen/discussions)

## Kontributor

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Riwayat Bintang

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---