<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Dokumen Detail] https://deepwiki.com/JetXu-LLM/llama-github

[![Versi PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Unduhan](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Lisensi](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github adalah alat yang kuat yang membantu Anda mengambil (berbasis Agentic RAG) potongan kode, isu, dan informasi repositori paling relevan dari GitHub berdasarkan permintaan Anda, mengubahnya menjadi konteks pengetahuan yang berharga. Ini memperkuat Chatbot LLM, Agen AI, dan Agen Auto-dev untuk menyelesaikan tugas pengkodean yang kompleks. Baik Anda pengembang yang mencari solusi cepat atau insinyur yang menerapkan Agen AI Auto Dev tingkat lanjut, llama-github membuatnya mudah dan efisien.


Jika Anda menyukai proyek ini atau percaya bahwa proyek ini memiliki potensi, silakan beri ⭐️. Dukungan Anda adalah motivasi terbesar kami!

## Arsitektur
![Arsitektur Tingkat Tinggi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalasi
```
pip install llama-github
```

Target runtime yang dipelihara saat ini: Python `3.10+`.

## Penggunaan

Berikut adalah contoh sederhana cara menggunakan llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` mengembalikan daftar kamus konteks. Setiap item berisi setidaknya `context` dan `url`.

Untuk penggunaan yang lebih lanjut dan contoh, silakan merujuk ke [dokumentasi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Contoh yang dapat dijalankan dengan biaya rendah juga tersedia di [`examples/`](examples).

## Fitur Utama

- **🔍 Pengambilan GitHub Cerdas**: Manfaatkan kekuatan llama-github untuk mengambil potongan kode, isu, dan informasi repositori yang sangat relevan dari GitHub berdasarkan permintaan pengguna. Teknik pengambilan canggih kami memastikan Anda menemukan informasi paling penting dengan cepat dan efisien.

- **⚡ Cache Pool Repositori**: Llama-github memiliki mekanisme cache pool repositori yang inovatif. Dengan melakukan cache repositori (termasuk README, struktur, kode, dan isu) di seluruh thread, llama-github secara signifikan mempercepat efisiensi pencarian GitHub dan meminimalkan konsumsi token API GitHub.

- **🧠 Analisis Pertanyaan Berbasis LLM**: Manfaatkan model bahasa mutakhir untuk menganalisis pertanyaan pengguna dan menghasilkan strategi serta kriteria pencarian yang sangat efektif. Llama-github dengan cerdas memecah permintaan kompleks, memastikan Anda mendapatkan informasi paling relevan dari jaringan repositori GitHub yang luas.

- **📚 Generasi Konteks Komprehensif**: Hasilkan jawaban yang kaya dan relevan secara kontekstual dengan menggabungkan informasi yang diambil dari GitHub dengan kemampuan penalaran model bahasa canggih. Llama-github unggul dalam menangani pertanyaan yang paling kompleks dan panjang, memberikan respons komprehensif dan mendalam yang mencakup konteks luas untuk mendukung kebutuhan pengembangan Anda.

- **🚀 Keunggulan Pemrosesan Asinkron**: Llama-github dibangun dari awal untuk memanfaatkan potensi penuh pemrograman asinkron. Dengan mekanisme asinkron yang diterapkan secara cermat di seluruh kode, llama-github dapat menangani banyak permintaan secara bersamaan, meningkatkan performa secara signifikan.

- **🔧 Integrasi LLM yang Fleksibel**: Mudah mengintegrasikan llama-github dengan berbagai penyedia LLM, model embedding, model reranking, atau model chat yang kompatibel dengan LangChain untuk menyesuaikan kemampuan pustaka sesuai kebutuhan spesifik Anda.

- **🔒 Opsi Autentikasi yang Kuat**: Llama-github mendukung token akses pribadi dan autentikasi GitHub App, memberikan fleksibilitas untuk integrasi dalam berbagai pengaturan pengembangan. Baik Anda pengembang individu atau bekerja dalam konteks organisasi, llama-github siap dengan mekanisme autentikasi yang aman dan andal.

- **🛠️ Logging dan Penanganan Error**: Kami memahami pentingnya operasi yang lancar dan pemecahan masalah yang mudah. Itulah mengapa llama-github dilengkapi dengan mekanisme logging dan penanganan error yang komprehensif. Dapatkan wawasan mendalam tentang perilaku pustaka, diagnosis masalah dengan cepat, dan pertahankan workflow pengembangan yang stabil dan andal.

## 🤖 Coba Asisten Review PR AI Kami: LlamaPReview

Jika Anda merasa llama-github bermanfaat, Anda mungkin juga tertarik dengan asisten review PR GitHub bertenaga AI kami, LlamaPReview. Dirancang untuk melengkapi workflow pengembangan dan meningkatkan kualitas kode.

### Fitur Utama LlamaPReview:
- 🚀 Instalasi sekali klik, tanpa konfigurasi, langsung berjalan otomatis
- 💯 Gratis digunakan saat ini - tanpa kartu kredit atau info pembayaran
- 🧠 Review PR otomatis bertenaga AI dengan pemahaman kode mendalam
- 🌐 Mendukung berbagai bahasa pemrograman

**LlamaPReview memanfaatkan pengambilan konteks canggih dan analisis LLM dari llama-github** untuk menyediakan review kode yang cerdas dan sadar konteks. Seperti memiliki senior developer yang meninjau setiap PR Anda secara otomatis dengan konteks penuh repositori!

👉 [Pasang LlamaPReview Sekarang](https://github.com/marketplace/llamapreview/) (Gratis)

Dengan menggunakan llama-github untuk pengambilan konteks dan LlamaPReview untuk review kode, Anda dapat menciptakan lingkungan pengembangan bertenaga AI yang kuat.

## Visi dan Roadmap

### Visi

Visi kami adalah menjadi modul penting dalam solusi pengembangan berbasis AI di masa depan, terintegrasi secara mulus dengan GitHub untuk memberdayakan LLM dalam secara otomatis menyelesaikan tugas pengkodean yang kompleks.

![Arsitektur Visi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Peta Jalan

Untuk melihat peta jalan sebelumnya secara historis, silakan kunjungi [Vision and Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Ucapan Terima Kasih

Kami ingin mengucapkan terima kasih kepada proyek open-source berikut atas dukungan dan kontribusinya:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Untuk menyediakan kerangka dasar yang memberdayakan kemampuan prompting dan pemrosesan LLM di llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Untuk menawarkan API s.jina.ai serta model reranker dan embedding open source yang meningkatkan akurasi dan relevansi konteks yang dihasilkan di llama-github.

Kontribusi mereka sangat berperan dalam pengembangan llama-github, dan kami sangat merekomendasikan untuk melihat proyek mereka demi solusi yang lebih inovatif.

## Kontribusi

Kami menyambut kontribusi ke llama-github! Silakan lihat [panduan kontribusi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) kami untuk informasi lebih lanjut.

## Lisensi

Proyek ini dilisensikan di bawah ketentuan lisensi Apache 2.0. Lihat file [LICENSE](LICENSE) untuk detail lebih lanjut.

## Kontak

Jika Anda memiliki pertanyaan, saran, atau masukan, silakan hubungi kami di [email Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Terima kasih telah memilih llama-github! Kami berharap pustaka ini meningkatkan pengalaman pengembangan AI Anda dan membantu Anda membangun aplikasi yang kuat dengan mudah.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---