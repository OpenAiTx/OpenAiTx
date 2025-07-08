# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
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

## 🧸 Ikhtisar

BIRD-INTERACT, sebuah benchmark interaktif text-to-SQL, **menghadirkan kembali evaluasi Text-to-SQL melalui lensa interaksi dinamis**.
Lingkungan ini memadukan basis pengetahuan hierarkis, dokumentasi basis data dan simulator pengguna berbasis fungsi untuk menciptakan ulang lingkungan perusahaan otentik di seluruh operasi **CRUD** penuh.
Benchmark ini menawarkan dua mode uji yang ketat: (1) **Conversational Interaction** pasif dan (2) **Agentic Interaction** aktif, mencakup 600 tugas beranotasi termasuk Business Intelligence (BI), operasi CRUD, dan lain-lain, yang masing-masing dijaga oleh kasus uji yang dapat dieksekusi.
Evaluasi tipikal memicu 1.968-5.496 giliran interaksi antara model dan simulator pengguna, sementara model penalaran tercanggih saat ini hanya dapat menyelesaikan **≈24%** dan **≈18%** tugas, menandakan tantangan pada benchmark ini.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dua Mode Evaluasi

BIRD-INTERACT mendukung dua mode evaluasi seperti disebutkan di atas:

   - **c-Interact**: Conversational Interaction, yaitu mode pasif dengan alur kerja tetap. Kode dan informasi detail dapat ditemukan di `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction, yaitu mode aktif yang diwujudkan di mana alur kerja bersifat dinamis dan dipimpin oleh model. Kode dan informasi detail dapat ditemukan di `bird_interact_agent`.


### 🐣 Versi Lite

Kami merilis versi ringan dari BIRD-INTERACT, `bird-interact-lite-exp`, yang mencakup 270 tugas dunia nyata berkualitas tinggi khusus untuk PostgreSQL. Ini adalah titik awal yang baik untuk eksperimen cepat.

### 🦜 Versi Lengkap

Versi lengkap dari BIRD-INTERACT, `bird-interact-full`, adalah benchmark komprehensif yang mencakup 600 tugas untuk PostgreSQL. Benchmark ini mencakup beragam operasi SQL dan permintaan pengguna. Versi lengkap akan segera hadir.

### Hasil Performa Model pada BIRD-INTERACT Lite

#### 1. Performa **c-Interact**
| Peringkat | Nama Model        | Normalized Reward | Level        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Sangat Baik |
| 2    | GPT-4o             | 30.33 | 💎 Chat Baik       |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Baik       |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standar         |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standar         |
| 6    | Qwen3              | 20.33 | ⚪ Dasar           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Dasar           |

#### 2. Performa **a-Interact**
| Peringkat | Nama Model        | Parameter Budget* | Rata-rata Giliran/Tugas | Rata-rata Biaya (USD)/Tugas | Normalized Reward | Level            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interaksi Sangat Baik |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Interaksi Baik        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Interaksi Baik        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standar               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standar               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Dasar                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Dasar                 |

> \* Parameter Budget: Starting Budget/User Patience Budget, diukur dengan mata uang virtual kami *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Lihat [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) untuk detail lebih lanjut.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) mengacu pada kemampuan model untuk terus meningkatkan performa akhirnya melalui interaksi multi-giliran. Ketika performa interaktif ini melampaui performa model ideal pada tugas satu giliran yang telah dispesifikasikan sepenuhnya dan tidak ambigu, kita katakan model tersebut memenuhi **hukum ITS**. Seiring bertambahnya kesabaran pengguna dan akumulasi giliran interaksi, performa terus meningkat, menunjukkan bahwa model dapat mempertahankan komunikasi efektif dalam dialog berkepanjangan. Saat ini, hanya claude-3-7-sonnet yang ditemukan memenuhi hukum ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detail Dataset

### Deskripsi Dataset

- **Database:** Database PostgreSQL lengkap dapat diunduh dari [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Lihat bagian [Quick Eval](#quick-eval) untuk detail lebih lanjut.
- **data:** Setiap instance data berisi bagian utama berikut:
   - `selected_database`: Nama basis data.  
   - `query`: Permintaan pengguna yang tidak ambigu.  
   - `amb_user_query`: Permintaan pengguna dengan ambiguitas yang disuntikkan.
   - `user_query_ambiguity`: Ambiguitas yang disuntikkan ke dalam permintaan pengguna.
   - `non_critical_ambiguity`: Ambiguitas non-kritis seperti urutan, batas, dll.
   - `knowledge_ambiguity`: Ambiguitas yang dibuat oleh pengetahuan eksternal yang disamarkan.
   - `sol_sql`: Solusi SQL ground truth.
   - `preprocess_sql`: Query SQL yang dijalankan sebelum mengeksekusi solusi atau prediksi.
   - `clean_up_sql`: Query SQL yang dijalankan setelah test case untuk mengembalikan perubahan apa pun pada basis data.
   - `test_cases`: Sekumpulan test case untuk memvalidasi prediksi SQL yang telah dikoreksi.
   - `follow_up`: Pertanyaan lanjutan yang telah diberi label.
   - `external_knowledge`: Pengetahuan eksternal yang terkait dengan tugas spesifik.

- **evaluation:** Kode evaluasi tersedia di direktori [`./evaluation`](./evaluation).
- **Dikurasi oleh:** Tim BIRD & Google Cloud
- **Lisensi:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Kartu Dataset HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Penggunaan Dataset

Untuk menghindari kebocoran data melalui auto-crawling, kami tidak menyertakan sql solusi GT dan test case bersama data.
silakan email [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) dengan tag `[bird-interact-lite GT&Test Cases]` pada judul untuk mendapatkan set lengkap, yang akan dikirimkan secara otomatis.


<!-- ### Menggunakan Dataset dari HuggingFace

Anda dapat mengunduh dataset dari HuggingFace menggunakan perintah berikut:
```bash
from datasets import load_dataset
# Memuat versi flash dari dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Memuat versi lengkap dari dataset (segera hadir)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Atau Anda dapat menggunakan skrip yang disediakan untuk mengunduh versi lengkap dari dataset dan membaginya ke dalam berbagai dialek.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Path ke file JSONL input (bisa kosong jika Anda ingin mengunduh dataset dari HuggingFace)
  --output_folder path/to/output_dir # folder output dari file hasil split
``` -->

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
- [x] Rilis versi agent, bird-interact-agent.
- [ ] Rilis Full bird-interact-full (600).
- [ ] SFT / RL Simulator Pengguna

## Dibuat Oleh:
Tim BIRD & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---