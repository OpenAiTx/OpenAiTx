
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="Logo HKU" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Logo Google Cloud" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Lisensi">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Papan Peringkat">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 📰 Berita

- [2025-08-26] 🚀 Kami dengan bangga mengumumkan rilis set **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Ini cukup sulit — LLM terbaik hanya mencapai tingkat keberhasilan **16.33%**, dengan hanya **10.0%** pada bagian `c-interact` dan `a-interact`.  
👉 Untuk detail lebih lanjut, silakan kunjungi [situs proyek kami](https://bird-interact.github.io/).

- [2025-08-26] 📬 Minggu ini kami akan mengirimkan **Ground Truth & Test cases** ke daftar email kami.  
Jika Anda ingin akses awal, silakan kirim email sesuai instruksi di situs untuk **unduhan otomatis**.  

- [2025-08-26] 💾 Selain itu, kami juga telah merilis versi SQLite dari **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** agar penelitian lokal lebih mudah.  
Versi penuh **LiveSQLBench-Base** dan **-Large** akan segera hadir!

- [2025-08-22] **Perbaikan Bug**: Pada kode Bird-Interact-Agent, kami memperbaiki bug di mana saat mengevaluasi SQL fase-2, SQL fase-1 yang tersimpan tidak dapat dieksekusi dengan sukses, sehingga tingkat keberhasilan Fase-2 lebih rendah. Bug ini hanya memengaruhi tugas di mana sql fase1 melakukan beberapa operasi pada database, misal CREATE table, dll.

## 🧸 Ikhtisar

BIRD-INTERACT, sebuah benchmark interaktif text-to-SQL, **mengimajinasikan ulang evaluasi Text-to-SQL melalui kacamata interaksi dinamis**.
Lingkungan ini memadukan basis pengetahuan hierarkis, dokumentasi basis data, dan simulator pengguna berbasis fungsi untuk menciptakan ulang lingkungan perusahaan otentik di seluruh operasi **CRUD** penuh.
Benchmark ini menawarkan dua mode uji ketat: (1) **Interaksi Percakapan** pasif dan (2) **Interaksi Agenik** aktif, mencakup 600 tugas beranotasi termasuk Business Intelligence (BI), operasi CRUD, dan lain-lain, masing-masing dilindungi oleh kasus uji yang dapat dieksekusi.
Evaluasi tipikal memicu 1.968-5.496 giliran interaksi antara model dan simulator pengguna, sementara model penalaran mutakhir saat ini hanya mampu menyelesaikan **≈24%** dan **≈18%** tugas, menegaskan tantangan dari benchmark ini.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dua Mode Evaluasi

BIRD-INTERACT mendukung dua mode evaluasi seperti yang disebutkan di atas:

   - **c-Interact**: Interaksi Percakapan yang merupakan mode pasif dan alur kerjanya tetap. Kode dan informasi detail dapat ditemukan di `bird_interact_conv`.
   - **a-Interact**: Interaksi Agenik yang merupakan mode aktif terwujud di mana alur kerja bersifat dinamis dan dipimpin oleh model. Kode dan informasi detail dapat ditemukan di `bird_interact_agent`.


### 🐣 Versi Lite

Kami merilis versi lite dari BIRD-INTERACT, `bird-interact-lite-exp`, yang mencakup 270 tugas dunia nyata berkualitas tinggi khusus untuk PostgreSQL. Ini adalah titik awal yang baik untuk eksperimen cepat.

### 🦜 Versi Lengkap

Versi lengkap dari BIRD-INTERACT, `bird-interact-full`, adalah tolok ukur komprehensif yang mencakup 600 tugas untuk PostgreSQL. Versi ini meliputi berbagai operasi SQL dan permintaan pengguna. Versi lengkap akan segera hadir.

### Hasil Performa Model pada BIRD-INTERACT Lite

#### 1. Performa **c-Interact**
| Peringkat | Nama Model        | Reward Ternormalisasi | Level        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Sangat Baik |
| 2    | GPT-4o             | 30.33 | 💎 Chat Baik        |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Baik        |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standar          |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standar          |
| 6    | Qwen3              | 20.33 | ⚪ Dasar            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Dasar            |

#### 2. Performa **a-Interact**
| Peringkat | Nama Model         | Parameter Anggaran* | Rata-rata Langkah/Tugas | Rata-rata Biaya (USD)/Tugas | Reward Ternormalisasi | Level                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interaksi Sangat Baik |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Interaksi Baik        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Interaksi Baik        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standar               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standar               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Dasar                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Dasar                 |

> \* Parameter Anggaran: Anggaran Awal/Anggaran Kesabaran Pengguna, diukur dengan mata uang virtual kami *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Lihat [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) untuk detail lebih lanjut.

### Skala Waktu Interaksi (ITS)

Skala Waktu Interaksi (ITS) mengacu pada kemampuan model untuk terus meningkatkan kinerja akhirnya melalui interaksi multi-putaran. Ketika kinerja interaktif ini melampaui kinerja ideal model dalam satu putaran pada tugas yang telah ditentukan secara penuh dan tanpa ambigu, kita katakan bahwa model memenuhi **hukum ITS**. Seiring dengan bertambahnya kesabaran pengguna dan akumulasi putaran interaksi, kinerja terus meningkat, menunjukkan bahwa model dapat mempertahankan komunikasi yang efektif dalam dialog berkepanjangan. Saat ini, kami hanya menemukan claude-3-7-sonnet yang memenuhi hukum ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detail Dataset

### Deskripsi Dataset

- **Database:** Database PostgreSQL lengkap dapat diunduh dari [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Lihat bagian [Quick Eval](#quick-eval) untuk detail lebih lanjut.
- **data:** Setiap instance data berisi bagian utama berikut:
   - `selected_database`: Nama database.  
   - `query`: Query pengguna yang tidak ambigu.  
   - `amb_user_query`: Query pengguna dengan ambiguitas yang disuntikkan.
   - `user_query_ambiguity`: Ambiguitas yang disuntikkan ke dalam query pengguna.
   - `non_critical_ambiguity`: Ambiguitas non-kritis seperti urutan, batas, dll.
   - `knowledge_ambiguity`: Ambiguitas yang dibuat oleh penutupan pengetahuan eksternal. 
   - `sol_sql`: Solusi SQL ground truth.  
   - `preprocess_sql`: Query SQL yang dijalankan sebelum mengeksekusi solusi atau prediksi.  
   - `clean_up_sql`: Query SQL yang dijalankan setelah kasus uji untuk mengembalikan perubahan pada database.  
   - `test_cases`: Kumpulan kasus uji untuk memvalidasi SQL yang telah dikoreksi.
   - `follow_up`: Pertanyaan lanjutan yang telah diberi label.
   - `external_knowledge`: Pengetahuan eksternal terkait tugas tertentu.

- **evaluation:** Kode evaluasi tersedia di direktori [`./evaluation`](./evaluation).
- **Dikurasi oleh:** Tim BIRD & Google Cloud
- **Lisensi:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Kartu Dataset HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Penggunaan Dataset

Untuk menghindari kebocoran data melalui auto-crawling, kami tidak menyertakan sql solusi GT dan kasus uji bersama dengan data.
silakan email [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) dengan tag `[bird-interact-lite GT&Test Cases]` pada judul untuk mendapatkan paket lengkap, yang akan dikirimkan secara otomatis.


<!-- ### Gunakan Dataset dari HuggingFace

Anda dapat mengunduh dataset dari HuggingFace menggunakan perintah berikut:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Atau Anda dapat menggunakan skrip yang disediakan untuk mengunduh versi lengkap dataset dan membaginya ke dalam berbagai dialek.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Path ke file JSONL input (boleh kosong jika Anda ingin mengunduh dataset dari HuggingFace)
  --output_folder path/to/output_dir # folder output dari file hasil pemisahan
```

## Struktur Folder
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
Detail tentang menjalankan **a-interact** dapat ditemukan di `./bird_interact_agent/README.md`; dan **c-interact** dapat ditemukan di `./bird_interact_conv/README.md`.

## 📋 Daftar Todo

- [x] Rilis versi lite, bird-interact-lite (270).
- [x] Rilis versi percakapan, bird-interact-conv.
- [x] Rilis versi agen, bird-interact-agent.
- [x] Rilis bird-interact-full (600) lengkap.
- [ ] SFT / RL Simulator Pengguna

## Dibuat Oleh:
Tim BIRD & Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---