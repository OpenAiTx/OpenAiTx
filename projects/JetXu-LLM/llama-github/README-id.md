
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Dokumen Detail] https://deepwiki.com/JetXu-LLM/llama-github

[![Versi PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Unduhan](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Lisensi](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github adalah alat yang kuat yang membantu Anda mengambil (berbasis Agentic RAG) potongan kode, isu, dan informasi repositori paling relevan dari GitHub berdasarkan kueri Anda, mengubahnya menjadi konteks pengetahuan yang berharga. Ini memberdayakan Chatbot LLM, AI Agent, dan Auto-dev Agent untuk menyelesaikan tugas pengkodean yang kompleks. Baik Anda seorang pengembang yang mencari solusi cepat atau insinyur yang mengimplementasikan Auto Dev AI Agent tingkat lanjut, llama-github membuatnya mudah dan efisien.

Jika Anda menyukai proyek ini atau percaya proyek ini memiliki potensi, silakan beri ⭐️. Dukungan Anda adalah motivasi terbesar kami!

## Arsitektur
![Arsitektur Tingkat Tinggi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalasi
```
pip install llama-github
```

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
Untuk penggunaan dan contoh yang lebih lanjut, silakan merujuk ke [dokumentasi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Fitur Utama

- **🔍 Pengambilan GitHub Cerdas**: Manfaatkan kekuatan llama-github untuk mengambil cuplikan kode, isu, dan informasi repositori yang sangat relevan dari GitHub berdasarkan pertanyaan pengguna. Teknik pengambilan canggih kami memastikan Anda menemukan informasi paling relevan dengan cepat dan efisien.

- **⚡ Caching Pool Repositori**: Llama-github memiliki mekanisme caching pool repositori yang inovatif. Dengan menyimpan cache repositori (termasuk README, struktur, kode, dan isu) di seluruh thread, llama-github secara signifikan mempercepat efisiensi pencarian GitHub dan meminimalisir konsumsi token API GitHub. Gunakan llama-github di lingkungan produksi multi-thread dengan percaya diri, karena akan bekerja optimal dan menghemat sumber daya Anda.

- **🧠 Analisis Pertanyaan Berbasis LLM**: Manfaatkan model bahasa mutakhir untuk menganalisis pertanyaan pengguna dan menghasilkan strategi serta kriteria pencarian yang sangat efektif. Llama-github secara cerdas memecah pertanyaan kompleks, memastikan Anda mendapatkan informasi paling relevan dari jaringan repositori GitHub yang luas.

- **📚 Generasi Konteks Komprehensif**: Hasilkan jawaban kaya dan relevan secara kontekstual dengan menggabungkan informasi dari GitHub dan kemampuan penalaran model bahasa canggih. Llama-github unggul dalam menangani pertanyaan yang paling kompleks dan panjang, menyediakan respons komprehensif dan mendalam yang mencakup banyak konteks untuk mendukung kebutuhan pengembangan Anda.

- **🚀 Keunggulan Pemrosesan Asinkron**: Llama-github dibangun dari awal untuk memaksimalkan potensi pemrograman asinkron. Dengan mekanisme asinkron yang diimplementasikan secara teliti di seluruh kode, llama-github dapat menangani banyak permintaan secara bersamaan, meningkatkan performa secara signifikan. Rasakan perbedaannya saat llama-github mengelola beban kerja besar tanpa mengorbankan kecepatan atau kualitas.

- **🔧 Integrasi LLM yang Fleksibel**: Integrasikan llama-github dengan berbagai penyedia LLM, model embedding, dan model reranking dengan mudah untuk menyesuaikan kemampuan library sesuai kebutuhan spesifik Anda. Arsitektur kami yang dapat dikembangkan memungkinkan Anda menyesuaikan dan meningkatkan fungsionalitas llama-github, memastikan adaptasi mulus ke lingkungan pengembangan unik Anda.

- **🔒 Opsi Autentikasi Tangguh**: Llama-github mendukung token akses pribadi maupun autentikasi GitHub App, memberikan fleksibilitas dalam integrasi ke berbagai pengaturan pengembangan. Baik Anda pengembang individu maupun bekerja dalam konteks organisasi, llama-github siap dengan mekanisme autentikasi yang aman dan andal.

- **🛠️ Logging dan Penanganan Error**: Kami memahami pentingnya operasi yang lancar dan pemecahan masalah yang mudah. Itulah sebabnya llama-github dilengkapi dengan mekanisme logging dan penanganan error yang komprehensif. Dapatkan wawasan mendalam tentang perilaku library, diagnosa masalah dengan cepat, dan pertahankan workflow pengembangan yang stabil dan andal.

## 🤖 Coba Asisten Review PR Berbasis AI: LlamaPReview

Jika Anda merasa llama-github bermanfaat, Anda mungkin juga tertarik dengan asisten review PR GitHub berbasis AI kami, LlamaPReview. Dirancang untuk melengkapi workflow pengembangan Anda dan semakin meningkatkan kualitas kode.

### Fitur Utama LlamaPReview:
- 🚀 Instalasi sekali klik, tanpa konfigurasi, langsung berjalan otomatis
- 💯 Saat ini gratis digunakan - tidak perlu kartu kredit atau info pembayaran
- 🧠 Review PR otomatis berbasis AI dengan pemahaman kode yang mendalam
- 🌐 Mendukung banyak bahasa pemrograman

**LlamaPReview memanfaatkan pengambilan konteks canggih dan analisis berbasis LLM dari llama-github** untuk menyediakan review kode yang cerdas dan kontekstual. Seperti memiliki pengembang senior, lengkap dengan konteks penuh dari repositori Anda, yang meninjau setiap PR secara otomatis!

👉 [Instal LlamaPReview Sekarang](https://github.com/marketplace/llamapreview/) (Gratis)

Dengan menggunakan llama-github untuk pengambilan konteks dan LlamaPReview untuk review kode, Anda dapat menciptakan lingkungan pengembangan bertenaga AI yang kuat.

## Visi dan Roadmap

### Visi

Visi kami adalah menjadi modul penting dalam solusi pengembangan berbasis AI di masa depan, terintegrasi mulus dengan GitHub untuk memberdayakan LLM dalam menyelesaikan tugas pengkodean kompleks secara otomatis.

![Arsitektur Visi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roadmap

Untuk melihat roadmap proyek kami secara detail, silakan kunjungi [Roadmap Proyek](https://github.com/users/JetXu-LLM/projects/2).

## Ucapan Terima Kasih

Kami ingin mengucapkan terima kasih kepada proyek-proyek open-source berikut atas dukungan dan kontribusinya:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Telah menyediakan kerangka dasar yang memperkuat kemampuan prompting dan pemrosesan LLM di llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Telah menawarkan API s.jina.ai serta model reranker dan embedding open-source yang meningkatkan akurasi dan relevansi konteks yang dihasilkan llama-github.

Kontribusi mereka sangat penting dalam pengembangan llama-github, dan kami sangat merekomendasikan untuk mengecek proyek mereka untuk solusi inovatif lainnya.

## Kontribusi

Kami sangat menyambut kontribusi untuk llama-github! Silakan lihat [panduan kontribusi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) kami untuk informasi lebih lanjut.

## Lisensi

Proyek ini dilisensikan di bawah lisensi Apache 2.0. Lihat berkas [LICENSE](LICENSE) untuk detail lebih lanjut.

## Kontak

Jika Anda memiliki pertanyaan, saran, atau masukan, silakan hubungi kami di [email Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Terima kasih telah memilih llama-github! Kami berharap library ini meningkatkan pengalaman pengembangan AI Anda dan membantu membangun aplikasi yang kuat dengan mudah.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---