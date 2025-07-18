# Contoh Agent2Agent (A2A)

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

Repositori ini berisi contoh kode dan demo yang menggunakan [Protokol Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositori Terkait

- [A2A](https://github.com/a2aproject/A2A) - Spesifikasi dan dokumentasi A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python untuk A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Alat UI untuk menginspeksi agen yang mendukung A2A.

## Kontribusi

Kontribusi sangat diterima! Lihat [Panduan Kontribusi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Mendapatkan bantuan

Silakan gunakan [halaman isu](https://github.com/a2aproject/a2a-samples/issues) untuk memberikan saran, umpan balik, atau melaporkan bug.

## Disclaimer

Repositori ini sendiri bukan produk Google yang didukung secara resmi. Kode di dalam repositori ini hanya untuk tujuan demonstrasi.

Penting: Kode contoh yang disediakan hanya untuk tujuan demonstrasi dan menggambarkan mekanisme protokol Agent-to-Agent (A2A). Saat membangun aplikasi produksi, sangat penting untuk memperlakukan setiap agen yang beroperasi di luar kendali langsung Anda sebagai entitas yang berpotensi tidak tepercaya.

Semua data yang diterima dari agen eksternal—termasuk namun tidak terbatas pada AgentCard, pesan, artefak, dan status tugasnya—harus diperlakukan sebagai input yang tidak tepercaya. Sebagai contoh, agen jahat dapat memberikan AgentCard yang berisi data yang dibuat-buat pada bidangnya (misal: deskripsi, nama, skills.description). Jika data ini digunakan tanpa sanitasi untuk membangun prompt bagi Large Language Model (LLM), aplikasi Anda dapat terekspos pada serangan prompt injection. Kegagalan dalam memvalidasi dan mensanitasi data ini sebelum digunakan dapat menyebabkan kerentanan keamanan pada aplikasi Anda.

Pengembang bertanggung jawab untuk menerapkan langkah-langkah keamanan yang sesuai, seperti validasi input dan penanganan kredensial yang aman untuk melindungi sistem dan pengguna mereka.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---