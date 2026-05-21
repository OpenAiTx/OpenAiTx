# Contoh Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Coba di Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Bahasa</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Selamat datang di contoh kode dan demonstrasi resmi untuk [Protokol Agent2Agent (A2A)](https://goo.gle/a2a).

Kami sangat senang Anda ada di sini! Baik Anda baru menjelajahi arsitektur multi-agent atau membangun jaringan agen interoperabel yang canggih, repositori ini menyediakan sumber pembelajaran yang sederhana, inspiratif, dan mudah diakses untuk mempercepat pengembangan Anda.

## Mengapa Agent2Agent?

Dalam dunia kerangka kerja AI dan ekosistem yang beragam, agen membutuhkan bahasa umum untuk berkomunikasi, berkolaborasi, dan mendelegasikan tugas secara aman. Protokol A2A menetapkan standar terbuka yang terstandarisasi untuk interoperabilitas multi-agent.

Contoh kami menunjukkan betapa mudahnya masalah multi-agent yang kompleks dapat diselesaikan lintas bahasa dan aplikasi host yang berbeda.

## Mulai Cepat

Mulai segera dengan menjalankan agen Helloworld dan berkomunikasi dengannya melalui host CLI Python kami.

1. **Mulai Server Agen**:
   Buka terminal dan jalankan server agen Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Jalankan Host Client**:
   Buka terminal kedua dan jalankan klien CLI untuk mengirim tugas ke agen:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Struktur Repository

Repository ini diorganisasikan ke dalam beberapa direktori utama berdasarkan bahasa:

| Direktori | Deskripsi |
| --- | --- |
| [samples](/samples) | Sampel inti A2A yang diorganisasikan berdasarkan bahasa pemrograman. |
| [samples/python](/samples/python) | Menunjukkan implementasi agen Python menggunakan A2A Python SDK. |
| [samples/go](/samples/go) | Menunjukkan implementasi agen Go menggunakan A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Menunjukkan implementasi agen C# menggunakan A2A .NET SDK. |
| [samples/java](/samples/java) | Menunjukkan implementasi agen Java menggunakan A2A Java SDK. |
| [samples/js](/samples/js) | Menunjukkan implementasi agen Node.js menggunakan A2A JavaScript SDK. |

## Kontribusi

Kami menyambut dan mendorong kontribusi dari semua tingkat keahlian! Jika Anda memiliki ide untuk sampel baru, perbaikan bug, atau peningkatan dokumentasi, silakan lihat [Panduan Kontribusi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) kami.

## Mendapatkan Bantuan

Kami berdedikasi untuk menyediakan komunitas yang ramah dan mendukung. Jika Anda memiliki pertanyaan, umpan balik, atau mengalami masalah, silakan hubungi kami di [halaman issues](https://github.com/a2aproject/a2a-samples/issues) kami.

## Repository Terkait

| Repository | Kategori | Deskripsi |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Spesifikasi Inti | Spesifikasi dan dokumentasi A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Alat | Alat UI untuk memeriksa agen yang mendukung A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Pengujian | Suite pengujian untuk memvalidasi kepatuhan Protokol A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Pengujian | Toolkit untuk memverifikasi kompatibilitas di berbagai implementasi SDK A2A dan versi menggunakan model traversal multi-hop dan protokol transportasi yang beragam. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK Python resmi untuk A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK Go resmi untuk A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK Java resmi untuk A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK Node.js/JavaScript resmi untuk A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK C#/.NET resmi untuk A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK Rust resmi untuk A2A. |

## Disclaimer

**Penting:** Kode sampel yang disediakan hanya untuk tujuan demonstrasi dan menggambarkan mekanisme dari
Protokol Agent-to-Agent (A2A). Saat membangun aplikasi produksi, sangat penting untuk memperlakukan setiap agen
yang beroperasi di luar kendali langsung Anda sebagai entitas yang berpotensi tidak terpercaya.

Semua data yang diterima dari agen eksternal—termasuk namun tidak terbatas pada AgentCard, pesan,
artefak, dan status tugas—harus diperlakukan sebagai masukan yang tidak terpercaya. Misalnya, agen jahat
dapat memberikan AgentCard yang berisi data yang dibuat-buat di bidangnya (misalnya, deskripsi, nama,
skills.description). Jika data ini digunakan tanpa sanitasi untuk membuat prompt bagi Large
Language Model (LLM), aplikasi Anda bisa terkena serangan prompt injection. Kegagalan dalam
memvalidasi dan membersihkan data ini dengan benar sebelum digunakan dapat menimbulkan kerentanan keamanan pada
aplikasi Anda.

> Pengembang bertanggung jawab untuk menerapkan langkah-langkah keamanan yang sesuai, seperti validasi input
> dan penanganan kredensial yang aman untuk melindungi sistem dan pengguna mereka.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---