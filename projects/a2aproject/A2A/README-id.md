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

Protokol Agent2Agent (A2A) mengatasi tantangan krusial dalam lanskap AI: memungkinkan agen AI generatif, yang dibangun di atas berbagai kerangka kerja oleh perusahaan berbeda dan berjalan di server terpisah, untuk berkomunikasi dan berkolaborasi secara efektif - sebagai agen, bukan sekadar alat. A2A bertujuan menyediakan bahasa umum bagi agen, mendorong ekosistem AI yang lebih terhubung, kuat, dan inovatif.

Dengan A2A, agen dapat:

- Menemukan kemampuan satu sama lain.
- Menegosiasikan model interaksi (teks, formulir, media).
- Berkolaborasi secara aman pada tugas jangka panjang.
- Beroperasi tanpa mengekspos keadaan internal, memori, atau alat mereka.

## Video Pengantar A2A

[![Video Pengantar A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Mengapa A2A?

Seiring semakin berkembangnya agen AI, kemampuan mereka untuk saling beroperasi sangat penting dalam membangun aplikasi kompleks yang multi-fungsi. A2A bertujuan untuk:

- **Memecah Sekat:** Menghubungkan agen di berbagai ekosistem.
- **Memungkinkan Kolaborasi Kompleks:** Memungkinkan agen spesialis bekerja sama dalam tugas yang tidak dapat ditangani oleh satu agen saja.
- **Mendorong Standar Terbuka:** Mendukung pendekatan komunikasi agen berbasis komunitas, mendorong inovasi dan adopsi luas.
- **Menjaga Ketertutupan:** Memungkinkan agen berkolaborasi tanpa harus berbagi memori internal, logika milik sendiri, atau implementasi alat spesifik, meningkatkan keamanan dan melindungi kekayaan intelektual.

### Fitur Utama

- **Komunikasi Standar:** JSON-RPC 2.0 melalui HTTP(S).
- **Penemuan Agen:** Melalui "Kartu Agen" yang berisi detail kemampuan dan info koneksi.
- **Interaksi Fleksibel:** Mendukung permintaan/respons sinkron, streaming (SSE), dan notifikasi push asinkron.
- **Pertukaran Data Kaya:** Mendukung teks, file, dan data JSON terstruktur.
- **Siap Enterprise:** Dirancang dengan keamanan, autentikasi, dan observabilitas. 

## Mulai Penggunaan
- 📚 **Jelajahi Dokumentasi:** Kunjungi [Situs Dokumentasi Protokol Agent2Agent](https://a2a-protocol.org) untuk gambaran lengkap, spesifikasi protokol penuh, tutorial, dan panduan.
- 📝 **Lihat Spesifikasi:** [Spesifikasi Protokol A2A](https://a2a-protocol.org/latest/specification/)
- Gunakan SDK berikut:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) menggunakan maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) menggunakan [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Gunakan [contoh kode kami](https://github.com/a2aproject/a2a-samples) untuk melihat A2A beraksi

## Kontribusi

Kami menyambut kontribusi komunitas untuk meningkatkan dan mengembangkan protokol A2A!

- **Pertanyaan & Diskusi:** Bergabunglah di [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Isu & Masukan:** Laporkan isu atau sarankan perbaikan melalui [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Panduan Kontribusi:** Lihat [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) untuk detail cara berkontribusi.
- **Masukan Pribadi:** Gunakan [Google Form](https://goo.gle/a2a-feedback) ini.
- **Program Mitra:** Pelanggan Google Cloud dapat bergabung dengan program mitra melalui [formulir](https://goo.gle/a2a-partner) ini.

## Apa selanjutnya

### Peningkatan Protokol

- **Penemuan Agen:**
    - Meresmikan inklusi skema otorisasi dan kredensial opsional langsung di dalam `AgentCard`.
- **Kolaborasi Agen:**
    - Menyelidiki metode `QuerySkill()` untuk memeriksa skill yang tidak didukung atau tidak terduga secara dinamis.
- **Siklus Tugas & UX:**
    - Dukungan negosiasi UX dinamis _di dalam_ sebuah tugas (misalnya agen menambah audio/video di tengah percakapan).
- **Metode Klien & Transportasi:**
    - Menjelajahi perluasan dukungan untuk metode yang diinisiasi klien (selain manajemen tugas).
    - Peningkatan keandalan streaming dan mekanisme push notification.

## Tentang

Protokol A2A adalah proyek open source di bawah Linux Foundation, dikontribusikan oleh Google. Protokol ini dilisensikan di bawah [Apache License 2.0](LICENSE) dan terbuka untuk kontribusi dari komunitas.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---