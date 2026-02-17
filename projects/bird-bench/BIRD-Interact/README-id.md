
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

## ⚠️ Pengumuman  
Harap dicatat bahwa sebelum proses evaluasi Anda, saat Docker memuat basis data, kesalahan terkadang dapat terjadi karena inkonsistensi lingkungan (ini tidak akan menghentikan proses namun akan muncul di log Docker). Akibatnya, beberapa basis data bisa gagal dimuat dengan benar, menyebabkan basis data kosong. Ini akan menyebabkan hasil evaluasi menjadi sangat rendah.  
👉 Oleh karena itu, kami sangat menyarankan untuk memeriksa log Docker terhadap adanya kesalahan **sebelum menjalankan evaluasi** dan memastikan semua basis data telah berhasil dimuat.

👉 Kami telah memperbarui **Pedoman Pengiriman**, di mana scaffold agen kustom kini didukung. Silakan lihat pedoman pengiriman rinci kami [di sini](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Berita

- [2026-02-08] 🔥🔥🔥 **[Makalah Bird-Interact](https://huggingface.co/papers/2510.05318)** kami telah diterima di **ICLR 2026 (Oral)**! Sampai jumpa di Rio 🇧🇷!  

- [2025-11-06] 🐛 **Perbaikan Bug** & 🐳 **Pembaruan Docker**: Memperbarui versi sqlglot ke 26.16.4 untuk memperbaiki bug di mana parser sql tidak dapat mengurai SQL dengan benar untuk simulator pengguna. Anda dapat memperbaikinya dengan menginstal ulang menggunakan `pip install sqlglot==26.16.4` di lingkungan `bird_interact_eval`. Image `bird_interact_eval` juga diperbarui, jadi Anda juga dapat menarik ulang dan membuat ulang kontainer `bird_interact_eval`.

- [2025-10-21] 🐳 **Pembaruan Docker**: Kami menambahkan docker untuk Full DB Env. Dan kami telah mendorong 3 image docker (Base/Full DB Env dan lingkungan evaluasi untuk `a-Interact` dan `c-Interact`) ke Docker Hub untuk memudahkan penyiapan lingkungan. Tidak perlu mengunduh DB dump dan membangun image secara manual!

- [2025-10-08] 📝 **[Makalah Bird-Interact](https://huggingface.co/papers/2510.05318)** kami kini tersedia untuk publik!  
  Makalah ini menyajikan detail lengkap, metodologi, dan evaluasi tolok ukur teks-ke-SQL interaktif kami.  
  👉 Simak dan pelajari lebih lanjut tentang ide di balik [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Kami dengan senang hati mengumumkan rilis **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Ini sulit — LLM terbaik hanya mencapai tingkat keberhasilan **16.33%**, dengan hanya **10.0%** pada bagian `c-interact` dan `a-interact`.  
👉 Untuk detail lebih lanjut, silakan kunjungi [situs web proyek](https://bird-interact.github.io/).

- [2025-08-26] 📬 Kami akan mengirimkan **Ground Truth & Test cases** ke daftar email kami minggu ini.  
Jika Anda ingin akses awal, silakan kirim email sesuai petunjuk di situs untuk **unduhan otomatis**.  

- [2025-08-26] 💾 Di sisi lain, kami juga telah merilis versi SQLite dari **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** untuk riset lokal yang lebih mudah.  
Versi lengkap **LiveSQLBench-Base** dan **-Large** akan segera hadir!

- [2025-08-22] **Perbaikan Bug**: Pada kode Bird-Interact-Agent, kami memperbaiki bug saat evaluasi SQL fase-2, di mana SQL fase-1 yang disimpan tidak bisa dieksekusi dengan sukses, menyebabkan tingkat keberhasilan fase-2 lebih rendah. Bug ini hanya memengaruhi tugas di mana SQL fase1 melakukan beberapa operasi pada basis data, misalnya CREATE table, dll.

## 🧸 Ikhtisar

BIRD-INTERACT, sebuah benchmark interaktif text-to-SQL, **mengimajinasikan kembali evaluasi Text-to-SQL melalui lensa interaksi dinamis**.
Lingkungan ini menggabungkan basis pengetahuan hierarkis, dokumentasi basis data dan simulator pengguna berbasis fungsi untuk menciptakan lingkungan perusahaan otentik dengan operasi penuh **CRUD**.
Benchmark ini menawarkan dua mode uji yang ketat: (1) **Interaksi Percakapan** pasif dan (2) **Interaksi Agenik** aktif, mencakup 600 tugas beranotasi termasuk Business Intelligence (BI), operasi CRUD, dan lainnya, masing-masing dilindungi oleh test case yang dapat dieksekusi.
Evaluasi tipikal memicu 1.968-5.496 giliran interaksi antara model dan simulator pengguna, sementara model reasoning mutakhir saat ini hanya menyelesaikan **≈24%** dan **≈18%** tugas, menyoroti tantangan benchmark ini.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dua Mode Evaluasi

BIRD-INTERACT mendukung dua mode evaluasi seperti disebutkan di atas:

   - **c-Interact**: Interaksi Percakapan yang merupakan mode pasif dan alur kerja tetap. Kode dan informasi detail dapat ditemukan di `bird_interact_conv`.
   - **a-Interact**: Interaksi Agenik yang merupakan mode aktif embodied di mana alur kerja dinamis dan dipimpin oleh model. Kode dan informasi detail dapat ditemukan di `bird_interact_agent`.


### 🐣 Versi Lite

Kami merilis versi lite dari BIRD-INTERACT, `bird-interact-lite-exp`, yang mencakup 270 tugas dunia nyata berkualitas tinggi khusus untuk PostgreSQL. Ini adalah titik awal yang baik untuk eksperimen cepat. 

### 🦜 Versi Lengkap

Versi lengkap dari BIRD-INTERACT, `bird-interact-full`, adalah benchmark komprehensif yang mencakup 600 tugas untuk PostgreSQL. Ia mencakup beragam operasi SQL dan pertanyaan pengguna. Versi lengkap segera hadir.

### Hasil Performa Model pada BIRD-INTERACT-FULL

#### 1. **Performa c-Interact Text-to-SQL**
| Peringkat | Nama Model        | Normalized Reward | Biaya Rata-rata (USD)/Tugas | Level              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Obrolan Unggul  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Obrolan Unggul  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Obrolan Baik    |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Obrolan Baik    |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standar         |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standar         |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Dasar           |

#### 2. **a-Interact Text-to-SQL** Kinerja
| Rank | Nama Model         | Normalized Reward | Rata-rata Biaya (USD)/Tugas | Level                  |
|:----:|:-------------------|:-----------------:|:---------------------------:|:----------------------:|
| 1    | GPT-5              | 25.52             | $0.24                       | 🏆 Interaksi Unggul    |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51                       | 🏆 Interaksi Unggul    |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60                       | 💎 Interaksi Baik      |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22                       | 💎 Interaksi Baik      |
| 5    | O3-Mini            | 16.43             | $0.06                       | ✨ Standar             |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06                       | ✨ Standar             |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07                       | ⚪ Dasar               |

> \* Parameter Anggaran: Anggaran Awal/Anggaran Kesabaran Pengguna, diukur dengan mata uang virtual kami *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Lihat [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) untuk detail lebih lanjut.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) mengacu pada kemampuan model untuk terus meningkatkan performa akhirnya melalui interaksi multi-putaran. Ketika performa interaktif ini melampaui performa ideal model pada tugas yang sepenuhnya ditentukan dan tidak ambigu, maka model tersebut memenuhi **hukum ITS**. Saat kesabaran pengguna meningkat dan jumlah putaran interaksi bertambah, performa terus meningkat, menunjukkan bahwa model dapat mempertahankan komunikasi efektif dalam dialog yang berkepanjangan. Saat ini, hanya claude-3-7-sonnet yang memenuhi hukum ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Penyiapan Lingkungan

1. Jalankan kontainer Docker untuk database bird-interact-lite, database bird-interact-full, dan lingkungan evaluasi:
  
  > Jika Anda hanya ingin melakukan evaluasi pada `bird-interact-lite`, Anda bisa mengomentari [`postgresql_full` service](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) di `docker-compose.yml` untuk mempercepat penyiapan lingkungan.
  
  Mulai lingkungan dengan menjalankan: 
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Tunggu beberapa menit untuk inisialisasi basis data.

  Anda dapat memantau kemajuan pembangunan dengan:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Jika selesai, Anda seharusnya melihat log tanpa kesalahan seperti:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Jika Anda telah membuat container sebelumnya dan ingin membuatnya kembali, Anda dapat menjalankan perintah berikut:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Ini menjalankan 3 container menggunakan image yang sudah dibangun dari Docker Hub:
   - `bird_interact_postgresql`: Database PostgreSQL untuk bird-interact-lite
   - `bird_interact_postgresql_full`: Database PostgreSQL untuk bird-interact-full
   - `bird_interact_eval`: Lingkungan evaluasi untuk `a-Interact` dan `c-Interact`.

   Sekarang, Anda dapat memulai lingkungan evaluasi dengan menjalankan perintah berikut:
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (Opsional) Bangun lingkungan secara manual (jika Anda ingin membangun image dari awal):
   - Unduh database dump
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Ekstrak dan ubah namanya menjadi `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Ekstrak dan ubah namanya menjadi `env/postgre_table_dumps_full`.
   - Bangun lingkungan secara manual dengan menjalankan `docker-compose.build.yml`.

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Direkomendasikan) Periksa bahwa kontainer basis data telah dibangun dan berjalan dengan sukses.

-  Cetak log pembuatan kontainer untuk memastikan bahwa basis data telah dibangun dengan sukses tanpa kesalahan:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Jika terjadi kesalahan, `"Terjadi kesalahan selama impor:"` akan dicetak di file log.


-  Periksa apakah kontainer basis data dalam kondisi baik.
   
   Gunakan skrip Python yang kami sediakan untuk memverifikasi metadata basis data:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Hasil yang diharapkan:
   - **bird-interact-lite**: 
     - 📈 Total Basis Data: 18
     - 📋 Total Tabel: 175
     - 🔢 Total Kolom: 2286
     - 📈 Rata-rata Baris per Tabel: 1.038,48
     - 💾 Total Ukuran: 207,15 MB (sekitar)
   - **bird-interact-full**: 
     - 📈 Total Basis Data: 22
     - 📋 Total Tabel: 244
     - 🔢 Total Kolom: 2011
     - 📈 Rata-rata Baris per Tabel: 1.121,19
     - 💾 Total Ukuran: 272,00 MB (sekitar)


## 📦 Detail Dataset

### Deskripsi Dataset

- **Basis Data:** Basis data PostgreSQL lengkap dapat diunduh dari [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) dan [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Setiap instance data berisi bagian utama berikut:
   - `selected_database`: Nama basis data.  
   - `query`: Permintaan pengguna yang jelas.  
   - `amb_user_query`: Permintaan pengguna dengan ambiguitas yang disisipkan.
   - `user_query_ambiguity`: Ambiguitas yang disisipkan ke permintaan pengguna.
   - `non_critical_ambiguity`: Ambiguitas non-kritis seperti urutan, batas, dll.
   - `knowledge_ambiguity`: Ambiguitas yang dibuat dari pengetahuan eksternal yang disembunyikan.
   - `sol_sql`: Solusi SQL kebenaran dasar.  
   - `preprocess_sql`: Kueri SQL yang dijalankan sebelum mengeksekusi solusi atau prediksi.  
   - `clean_up_sql`: Kueri SQL yang dijalankan setelah kasus uji untuk membalik perubahan pada basis data.  
   - `test_cases`: Sekumpulan kasus uji untuk memvalidasi SQL yang dikoreksi hasil prediksi.
   - `follow_up`: Pertanyaan lanjutan yang telah diberi label.
   - `external_knowledge`: Pengetahuan eksternal yang terkait dengan tugas spesifik.

- **evaluasi:** Kode evaluasi tersedia di direktori [`./evaluation`](./evaluation).
- **Dikurasi oleh:** Tim BIRD & Google Cloud
- **Lisensi:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Kartu Dataset HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  dan [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Penggunaan Dataset

Untuk menghindari kebocoran data melalui auto-crawling, kami tidak menyertakan sql solusi GT dan kasus uji bersama data.
silakan email [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) dengan tag `[bird-interact-lite GT&Test Cases]` atau `[bird-interact-full GT&Test Cases]` di judul untuk ground truth dan kasus uji untuk dataset bird-interact-lite atau bird-interact-full, yang akan dikirim secara otomatis.


### Menggabungkan data publik dengan ground truth dan kasus uji

Kemudian gunakan skrip berikut untuk menggabungkan data publik dengan ground truth dan kasus uji:

Ambil versi full sebagai contoh:
(1) Jalankan:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Ini akan membuat file baru di `/path/to/bird_interact_data.jsonl` dengan data yang telah digabungkan.

(2) Kemudian ganti data publik asli dengan data yang telah digabungkan:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Sama juga untuk versi lainnya: bird-interact-lite, versi mini, dll. Cukup atur jalur yang benar untuk data publik dan ground truth serta test case, lalu ganti data publik dengan data gabungan.




<!-- ### Menggunakan Dataset dari HuggingFace

Anda dapat mengunduh dataset dari HuggingFace dengan perintah berikut:
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
- [x] Rilis Full bird-interact-full (600).
- [ ] SFT / RL pada User Simulator

## Pengakuan
Kami ingin menyampaikan terima kasih yang tulus kepada **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, dan Profesor **Shinji Watanabe** atas diskusi yang bermanfaat dan wawasan berharga yang membantu meningkatkan proyek ini.

## Dibuat Oleh:
Tim BIRD & Google Cloud








## Catatan Perubahan

- [2025-11-06] 🐛 **Perbaikan Bug** & 🐳 **Pembaruan Docker**: Memperbarui versi sqlglot ke 26.16.4 untuk memperbaiki bug di mana sql parser tidak dapat mengurai SQL dengan benar untuk user simulator. Anda dapat memperbaikinya dengan menginstal ulang dengan `pip install sqlglot==26.16.4` di lingkungan `bird_interact_eval`. Image `bird_interact_eval` juga sudah diperbarui, jadi Anda juga dapat menariknya dan membuat ulang container `bird_interact_eval`.
- [2025-10-21] 🐳 **Pembaruan Docker**: Menambahkan docker untuk Full DB Env. Dan kami telah mengunggah 3 image docker (Base/Full DB Env dan lingkungan evaluasi untuk `a-Interact` dan `c-Interact`) ke Docker Hub untuk memudahkan penyiapan lingkungan. Tidak perlu mengunduh DB dumps dan membangun image secara manual! Silakan tarik image terbaru dari Docker Hub dan buat ulang container, misalnya dengan `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Perbaikan Bug**: Memperbaiki bug ketika mengevaluasi SQL fase-2, SQL fase-1 yang disimpan tidak dapat dijalankan dengan sukses, sehingga menyebabkan tingkat keberhasilan fase-2 lebih rendah. Bug ini hanya mempengaruhi tugas-tugas di mana SQL fase-1 melakukan beberapa operasi pada database, misalnya CREATE table, dll.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---