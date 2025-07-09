<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: dataframe (dibangun ulang) untuk inferensi LLM

[![Versi PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Versi Python](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Lisensi](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Dokumentasi**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic adalah framework DataFrame dari typedef.ai yang terinspirasi oleh PySpark, dirancang khusus untuk membangun aplikasi AI dan agen. Transformasikan data terstruktur maupun tidak terstruktur menjadi insight menggunakan operasi DataFrame yang sudah familiar, diperkuat dengan kecerdasan semantik. Dengan dukungan utama untuk markdown, transkrip, dan operator semantik, serta inferensi batch yang efisien di berbagai penyedia model.
## Instalasi

fenic mendukung Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Pengaturan Penyedia LLM

fenic memerlukan kunci API dari setidaknya satu penyedia LLM. Atur variabel lingkungan yang sesuai untuk penyedia pilihan Anda:

```bash
# Untuk OpenAI
export OPENAI_API_KEY="your-openai-api-key"

# Untuk Anthropic
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# Untuk Google
export GEMINI_API_KEY="your-google-api-key"
```

## Quickstart

Cara tercepat untuk mempelajari fenic adalah dengan melihat contoh-contohnya.

Di bawah ini adalah daftar singkat contoh yang ada di repositori ini:

| Contoh                                                                  | Deskripsi                                                                                                                          |
| ----------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Pengantar ekstraksi dan klasifikasi semantik menggunakan operator inti fenic melalui analisis log error.                           |
| [Enrichment](examples/enrichment)                                       | DataFrame multi-tahap dengan ekstraksi teks berbasis template, join, dan transformasi bertenaga LLM yang didemonstrasikan melalui enrichment log. |
| [Meeting Transcript Processing](examples/meeting_transcript_processing) | Parsing transkrip secara native, integrasi skema Pydantic, dan agregasi kompleks yang diperlihatkan melalui analisis rapat.        |
| [News Analysis](examples/news_analysis)                                 | Menganalisis dan mengekstrak wawasan dari artikel berita menggunakan operator semantik dan pemrosesan data terstruktur.            |
| [Podcast Summarization](examples/podcast_summarization)                 | Memproses dan merangkum transkrip podcast dengan analisis berbasis pembicara dan ekstraksi poin-poin penting.                     |
| [Semantic Join](examples/semantic_joins)                                | Alih-alih pencocokan fuzzy sederhana, gunakan fungsi semantic join fenic yang kuat untuk mencocokkan data antar tabel.             |
| [Named Entity Recognition](examples/named_entity_recognition)           | Mengekstrak dan mengklasifikasikan entitas bernama dari teks menggunakan ekstraksi dan klasifikasi semantik.                       |
| [Markdown Processing](examples/markdown_processing)                     | Memproses dan mentransformasi dokumen markdown dengan ekstraksi data terstruktur dan pemformatan.                                  |
| [JSON Processing](examples/json_processing)                             | Menangani struktur data JSON kompleks dengan operasi semantik dan validasi skema.                                                  |
| [Feedback Clustering](examples/feedback_clustering)                     | Mengelompokkan dan menganalisis umpan balik menggunakan kemiripan semantik dan operasi klasterisasi.                               |
| [Document Extraction](examples/document_extraction)                     | Mengekstrak informasi terstruktur dari berbagai format dokumen menggunakan operator semantik.                                      |

(Silakan klik contoh apa pun di atas untuk langsung menuju ke foldernya.)
## Mengapa menggunakan fenic?

fenic adalah kerangka kerja DataFrame yang opiniatif dan terinspirasi dari PySpark untuk membangun aplikasi AI produksi dan aplikasi agentik.

Berbeda dengan alat data tradisional yang dimodifikasi untuk LLM, mesin query fenic dibangun dari awal dengan mempertimbangkan kebutuhan inferensi.

Ubah data terstruktur dan tidak terstruktur menjadi wawasan menggunakan operasi DataFrame yang sudah dikenal, ditingkatkan dengan kecerdasan semantik. Dengan dukungan kelas satu untuk markdown, transkrip, dan operator semantik, serta inferensi batch yang efisien di berbagai penyedia model.

fenic menghadirkan keandalan pipeline data tradisional ke dalam beban kerja AI.

### Fitur Utama

#### Dirancang Khusus untuk Inferensi LLM

- Mesin query yang dirancang dari awal untuk beban kerja AI, bukan hasil modifikasi
- Optimasi batch otomatis untuk panggilan API
- Logika retry bawaan dan pembatasan laju
- Penghitungan token dan pelacakan biaya

#### Operator Semantik sebagai Fitur Utama
- `semantic.analyze_sentiment` - Analisis sentimen bawaan
- `semantic.classify` - Mengkategorikan teks dengan contoh few-shot
- `semantic.extract` - Mengubah teks tidak terstruktur menjadi data terstruktur dengan skema
- `semantic.group_by` - Mengelompokkan data berdasarkan kemiripan semantik
- `semantic.join` - Menggabungkan DataFrame berdasarkan makna, bukan hanya nilai
- `semantic.map` - Menerapkan transformasi bahasa alami
- `semantic.predicate` - Membuat predikat menggunakan bahasa alami untuk memfilter baris
- `semantic.reduce` - Mengagregasi data yang dikelompokkan dengan operasi LLM

#### Dukungan Data Tidak Terstruktur Secara Native

Melampaui tipe data multimodal tipikal (audio, gambar) dengan menciptakan tipe khusus untuk beban kerja yang didominasi teks:

- Parsing dan ekstraksi Markdown sebagai tipe data utama
- Pemrosesan transkrip (SRT, format generik) dengan kesadaran pembicara dan cap waktu
- Manipulasi JSON dengan ekspresi JQ untuk data bersarang
- Pemotongan teks otomatis dengan overlap yang dapat dikonfigurasi untuk dokumen panjang

#### Infrastruktur Siap Produksi
- Dukungan multi-penyedia (OpenAI, Anthropic, Gemini)
- Backend eksekusi lokal dan cloud
- Penanganan kesalahan dan pencatatan yang komprehensif
- Integrasi Pydantic untuk keamanan tipe data

#### API DataFrame yang Familiar

- Operasi yang kompatibel dengan PySpark
- Evaluasi malas dan optimisasi kueri
- Dukungan SQL untuk kueri kompleks
- Integrasi mulus dengan pipeline data yang sudah ada

### Mengapa DataFrame untuk Aplikasi LLM dan Agentik?

Aplikasi AI dan agentik pada dasarnya adalah pipeline dan alur kerja—persis seperti yang dirancang untuk ditangani oleh API DataFrame. Alih-alih menciptakan kembali pola untuk transformasi data, pemfilteran, dan agregasi, fenic memanfaatkan praktik rekayasa yang telah terbukti selama puluhan tahun.

#### Arsitektur Terpisah untuk Agen yang Lebih Baik

fenic menciptakan pemisahan yang jelas antara tugas inferensi berat dan interaksi agen waktu nyata. Dengan memindahkan pemrosesan batch keluar dari runtime agen, Anda mendapatkan:

- Agen yang lebih dapat diprediksi dan responsif
- Pemanfaatan sumber daya yang lebih baik dengan panggilan LLM secara batch
- Pemisahan yang lebih bersih antara perencanaan/orchestrasi dan eksekusi
#### Dibuat untuk Semua Insinyur

DataFrame tidak hanya untuk praktisi data. Desain API yang lancar dan dapat dikombinasikan membuatnya mudah diakses oleh semua insinyur:

- Rangkaikan operasi secara alami: `df.filter(...).semantic.group_by(...)`
- Gabungkan gaya imperatif dan deklaratif dengan mulus
- Mulai dengan cepat menggunakan pola yang sudah familiar dari pandas/PySpark atau SQL

## Dukungan

Bergabunglah dengan komunitas kami di [Discord](https://discord.gg/GdqF3J7huR) di mana Anda dapat terhubung dengan pengguna lain, mengajukan pertanyaan, dan mendapatkan bantuan untuk proyek fenic Anda. Komunitas kami selalu senang menyambut anggota baru!

Jika Anda merasa fenic bermanfaat, pertimbangkan untuk memberi kami ⭐ di bagian atas repositori ini. Dukungan Anda membantu kami tumbuh dan meningkatkan framework ini untuk semua orang!

## Kontribusi

Kami menerima segala bentuk kontribusi! Baik Anda tertarik menulis kode, memperbaiki dokumentasi, menguji fitur, atau mengusulkan ide baru, bantuan Anda sangat berharga bagi kami.

Bagi pengembang yang berencana mengirimkan perubahan kode, kami mendorong Anda untuk terlebih dahulu membuka issue guna mendiskusikan ide Anda sebelum membuat Pull Request. Ini membantu memastikan keselarasan dengan arah proyek dan mencegah upaya yang duplikat.

Silakan lihat [panduan kontribusi](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) kami untuk informasi detail mengenai proses pengembangan dan penyiapan proyek.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---