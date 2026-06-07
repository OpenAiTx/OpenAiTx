# Protokol Agent2Agent (A2A)

[![PyPI - Versi](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Lisensi Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Tanya Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Bahasa</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logo Protokol Agent2Agent" width="100">
    <h1>Protokol Agent2Agent (A2A)</h1>
  </div>
</div>

**Protokol terbuka yang memungkinkan komunikasi dan interoperabilitas antara aplikasi agen yang tidak transparan.**

Protokol Agent2Agent (A2A) menangani tantangan penting dalam lanskap AI: memungkinkan agen AI generatif, yang dibangun dengan berbagai kerangka kerja oleh perusahaan berbeda dan berjalan di server terpisah, untuk berkomunikasi dan berkolaborasi secara efektif - sebagai agen, bukan hanya sebagai alat. A2A bertujuan menyediakan bahasa umum bagi agen, mendorong ekosistem AI yang lebih saling terhubung, kuat, dan inovatif.

Dengan A2A, agen dapat:

- Menemukan kapabilitas satu sama lain.
- Menegosiasikan mode interaksi (teks, formulir, media).
- Berkolaborasi secara aman pada tugas yang berjalan lama.
- Beroperasi tanpa mengungkapkan keadaan internal, memori, atau alat mereka.

## Kursus DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Ikuti kursus singkat tentang [A2A: Protokol Agent2Agent](https://goo.gle/dlai-a2a), yang dibangun bersama Google Cloud dan IBM Research, serta diajarkan oleh [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), dan [Sandi Besen](https://github.com/sandijean90).

**Apa yang akan Anda pelajari:**

- **Membuat agen kompatibel A2A:** Mengekspos agen yang dibangun dengan kerangka kerja seperti Google ADK, LangGraph, atau BeeAI sebagai server A2A.
- **Menghubungkan agen:** Membuat klien A2A dari awal atau menggunakan integrasi untuk terhubung ke agen yang kompatibel A2A.
- **Mengorkestrasi alur kerja:** Membangun alur kerja berurutan dan hierarkis dari agen yang kompatibel A2A.
- **Sistem multi-agen:** Membangun sistem multi-agen di bidang kesehatan menggunakan kerangka kerja yang berbeda dan melihat bagaimana A2A memungkinkan kolaborasi.
- **A2A dan MCP:** Pelajari bagaimana A2A melengkapi MCP dengan memungkinkan agen berkolaborasi satu sama lain.

## Mengapa A2A?

Seiring agen AI menjadi lebih umum, kemampuan mereka untuk saling beroperasi sangat penting untuk membangun aplikasi kompleks dan multi-fungsi. A2A bertujuan untuk:

- **Memecah Isolasi:** Menghubungkan agen di berbagai ekosistem.
- **Memungkinkan Kolaborasi Kompleks:** Memungkinkan agen spesialis bekerja sama pada tugas yang tidak dapat ditangani oleh satu agen saja.
- **Mempromosikan Standar Terbuka:** Mendorong pendekatan komunikasi agen yang digerakkan komunitas, mendukung inovasi dan adopsi yang luas.
- **Menjaga Opasitas:** Memungkinkan agen berkolaborasi tanpa perlu berbagi memori internal, logika kepemilikan, atau implementasi alat spesifik, meningkatkan keamanan dan melindungi kekayaan intelektual.

### Fitur Utama

- **Komunikasi Standar:** JSON-RPC 2.0 melalui HTTP(S).
- **Penemuan Agen:** Melalui "Kartu Agen" yang merinci kapabilitas dan info koneksi.
- **Interaksi Fleksibel:** Mendukung permintaan/respons sinkron, streaming (SSE), dan notifikasi push asinkron.
- **Pertukaran Data Kaya:** Menangani teks, file, dan data JSON terstruktur.
- **Siap Enterprise:** Dirancang dengan keamanan, autentikasi, dan observabilitas.

## Memulai

- 📚 **Jelajahi Dokumentasi:** Kunjungi [Situs Dokumentasi Protokol Agent2Agent](https://a2a-protocol.org) untuk gambaran lengkap, spesifikasi protokol penuh, tutorial, dan panduan.
- 📝 **Lihat Spesifikasi:** [Spesifikasi Protokol A2A](https://a2a-protocol.org/latest/specification/)
- Gunakan SDK berikut:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) menggunakan maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) menggunakan [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Gunakan [contoh](https://github.com/a2aproject/a2a-samples) kami untuk melihat A2A secara langsung

## Kontribusi

Kami menyambut kontribusi komunitas untuk meningkatkan dan mengembangkan protokol A2A!

- **Pertanyaan & Diskusi:** Bergabunglah di [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Isu & Masukan:** Laporkan masalah atau sarankan perbaikan melalui [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Panduan Kontribusi:** Lihat [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) untuk detail cara berkontribusi.
- **Masukan Pribadi:** Gunakan [Formulir Google](https://goo.gle/a2a-feedback) ini.
- **Program Mitra:** Pelanggan Google Cloud dapat bergabung dengan program mitra kami melalui [formulir](https://goo.gle/a2a-partner) ini.

## Selanjutnya

### Peningkatan Protokol

- **Penemuan Agen:**
    - Formalisasi penyertaan skema otorisasi dan kredensial opsional langsung dalam `AgentCard`.
- **Kolaborasi Agen:**
    - Meneliti metode `QuerySkill()` untuk memeriksa secara dinamis keahlian yang tidak didukung atau tidak terantisipasi.
- **Siklus Tugas & UX:**
    - Dukungan untuk negosiasi UX dinamis _dalam_ sebuah tugas (misalnya, agen menambahkan audio/video di tengah percakapan).
- **Metode Klien & Transportasi:**
    - Mengeksplorasi perluasan dukungan untuk metode yang diinisiasi klien (di luar manajemen tugas).
    - Peningkatan keandalan streaming dan mekanisme push notification.

## Tentang

Protokol A2A adalah proyek sumber terbuka di bawah Linux Foundation, yang dikontribusikan oleh Google. Protokol ini dilisensikan di bawah [Apache License 2.0](LICENSE) dan terbuka untuk kontribusi dari komunitas.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---