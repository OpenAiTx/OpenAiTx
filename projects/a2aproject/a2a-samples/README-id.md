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

Repositori ini berisi contoh kode dan demo yang menggunakan [Protokol Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositori Terkait

- [A2A](https://github.com/a2aproject/A2A) - Spesifikasi dan dokumentasi A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK Python untuk A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Alat UI untuk inspeksi agen yang mendukung A2A.

## Kontribusi

Kontribusi sangat diterima! Lihat [Panduan Kontribusi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Mendapatkan Bantuan

Silakan gunakan [halaman isu](https://github.com/a2aproject/a2a-samples/issues) untuk memberikan saran, umpan balik, atau melaporkan bug.

## Disclaimer

Repositori ini sendiri bukan produk Google yang didukung secara resmi. Kode dalam repositori ini hanya untuk tujuan demonstrasi.

Penting: Kode contoh yang disediakan bertujuan untuk demonstrasi dan menggambarkan mekanisme protokol Agent-to-Agent (A2A). Saat membangun aplikasi produksi, sangat penting untuk memperlakukan setiap agen yang beroperasi di luar kendali langsung Anda sebagai entitas yang berpotensi tidak tepercaya.

Semua data yang diterima dari agen eksternal—termasuk namun tidak terbatas pada AgentCard, pesan, artefak, dan status tugas—harus diperlakukan sebagai input yang tidak tepercaya. Misalnya, agen jahat dapat memberikan AgentCard yang berisi data yang direkayasa pada field-nya (misal, deskripsi, nama, skills.description). Jika data ini digunakan tanpa sanitasi untuk membangun prompt bagi Large Language Model (LLM), aplikasi Anda dapat terekspos serangan prompt injection. Kegagalan memvalidasi dan menyanitasi data ini sebelum digunakan dapat menimbulkan kerentanan keamanan pada aplikasi Anda.

Pengembang bertanggung jawab untuk menerapkan langkah keamanan yang sesuai, seperti validasi input dan penanganan kredensial secara aman untuk melindungi sistem dan pengguna mereka.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---