
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Coba model generatif [di sini](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), atau MaiMod [di sini](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Lihat video demo [di sini](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator adalah framework multi-model yang menggunakan input spektrogram untuk menghasilkan beatmap osu! lengkap untuk semua gamemode dan [membantu modding beatmap](#maimod-the-ai-driven-modding-tool).
Tujuan dari proyek ini adalah untuk secara otomatis menghasilkan beatmap osu! berkualitas rankable dari lagu apa pun dengan tingkat kustomisasi yang tinggi.

Proyek ini dibangun di atas [osuT5](https://github.com/gyataro/osuT5) dan [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Dalam pengembangannya, saya menghabiskan sekitar 2500 jam komputasi GPU dalam 142 kali running pada 4060 Ti saya dan instance 4090 sewaan di vast.ai.

#### Gunakan alat ini secara bertanggung jawab. Selalu ungkapkan penggunaan AI dalam beatmap Anda.

## Instalasi

Instruksi di bawah memungkinkan Anda untuk menghasilkan beatmap di mesin lokal Anda, sebagai alternatif Anda dapat menjalankannya di cloud dengan [notebook colab](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Klon repositori

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opsional) Membuat lingkungan virtual

Gunakan Python 3.10, versi setelahnya mungkin tidak kompatibel dengan dependensi.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Instal dependensi

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Untuk GPU NVIDIA) atau [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Untuk GPU AMD di linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Pastikan untuk mengikuti panduan Get Started agar Anda menginstal `torch` dan `torchaudio` dengan dukungan GPU. Pilih versi Compute Platform yang sesuai yang telah Anda instal pada langkah sebelumnya.

- serta sisa dependensi Python:

```sh
pip install -r requirements.txt
```

## Antarmuka Web GUI (Direkomendasikan)

Untuk pengalaman pengguna yang lebih ramah, pertimbangkan menggunakan Web UI. Antarmuka ini menyediakan tampilan grafis untuk mengonfigurasi parameter generasi, memulai proses, dan memantau output.

### Meluncurkan GUI

Arahkan ke direktori `Mapperatorinator` yang telah dikloning di terminal Anda dan jalankan:

```sh
python web-ui.py
```
Ini akan memulai server web lokal dan secara otomatis membuka UI di jendela baru.

### Menggunakan GUI

- **Konfigurasi:** Atur jalur input/output menggunakan field formulir dan tombol "Browse". Sesuaikan parameter generasi seperti gamemode, tingkat kesulitan, gaya (tahun, ID mapper, deskriptor), timing, fitur spesifik (hitsounds, super timing), dan lainnya, yang mencerminkan opsi command-line. (Catatan: Jika Anda mengisi `beatmap_path`, UI akan secara otomatis menentukan `audio_path` dan `output_path` dari situ, jadi Anda bisa membiarkan field tersebut kosong)
- **Mulai:** Klik tombol "Start Inference" untuk memulai proses pembuatan beatmap.
- **Batalkan:** Anda dapat menghentikan proses yang sedang berjalan menggunakan tombol "Cancel Inference".
- **Buka Output:** Setelah selesai, gunakan tombol "Open Output Folder" untuk akses cepat ke file yang dihasilkan.

Web UI bertindak sebagai pembungkus yang praktis untuk skrip `inference.py`. Untuk opsi lanjutan atau pemecahan masalah, silakan lihat petunjuk command-line.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Inferensi Command-Line

Bagi pengguna yang lebih suka command line atau membutuhkan konfigurasi lanjutan, ikuti langkah-langkah di bawah ini. **Catatan:** Untuk antarmuka grafis yang lebih sederhana, silakan lihat bagian [Web UI (Recommended)](#web-ui-recommended) di atas.

Jalankan `inference.py` dan masukkan beberapa argumen untuk menghasilkan beatmap. Untuk ini gunakan [sintaks Hydra override](https://hydra.cc/docs/advanced/override_grammar/basic/). Lihat `configs/inference_v29.yaml` untuk semua parameter yang tersedia.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Contoh:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI Interaktif
Untuk mereka yang lebih suka alur kerja berbasis terminal namun ingin penyiapan yang terpandu, skrip CLI interaktif adalah alternatif yang sangat baik untuk Web UI.

### Jalankan CLI
Arahkan ke direktori yang telah dikloning. Anda mungkin perlu membuat skrip dapat dieksekusi terlebih dahulu.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```
### Menggunakan CLI
Skrip ini akan memandu Anda melalui serangkaian prompt untuk mengonfigurasi semua parameter generasi, sama seperti antarmuka Web UI.

Antarmuka ini menggunakan kode warna untuk kejelasan.
Antarmuka ini menyediakan menu multi-pilihan tingkat lanjut untuk memilih deskriptor gaya menggunakan tombol panah dan spasi.
Setelah Anda menjawab semua pertanyaan, skrip akan menampilkan perintah akhir untuk Anda tinjau.
Anda kemudian dapat mengonfirmasi untuk menjalankannya langsung atau membatalkan dan menyalin perintah untuk digunakan secara manual.

## Tips Generasi

- Anda dapat mengedit `configs/inference_v29.yaml` dan menambahkan argumen Anda di sana, sehingga tidak perlu mengetik di terminal setiap saat.
- Semua deskriptor yang tersedia dapat ditemukan [di sini](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Selalu berikan argumen tahun antara 2007 dan 2023. Jika dibiarkan kosong, model mungkin menghasilkan gaya yang tidak konsisten.
- Selalu berikan argumen tingkat kesulitan. Jika dibiarkan kosong, model mungkin menghasilkan tingkat kesulitan yang tidak konsisten.
- Tingkatkan parameter `cfg_scale` untuk meningkatkan efektivitas argumen `mapper_id` dan `descriptors`.
- Anda dapat menggunakan argumen `negative_descriptors` untuk mengarahkan model agar menghindari gaya tertentu. Ini hanya bekerja jika `cfg_scale > 1`. Pastikan jumlah deskriptor negatif sama dengan jumlah deskriptor.
- Jika gaya lagu dan gaya beatmap yang diinginkan tidak cocok, model mungkin tidak mengikuti arahan Anda. Misalnya, sulit menghasilkan beatmap SR tinggi, SV tinggi untuk lagu yang tenang.
- Jika Anda sudah memiliki timing dan waktu kiai untuk sebuah lagu, Anda dapat memberikannya ke model untuk meningkatkan kecepatan dan akurasi inferensi: Gunakan argumen `beatmap_path` dan `in_context=[TIMING,KIAI]`.
- Untuk memetakan ulang hanya sebagian dari beatmap Anda, gunakan argumen `beatmap_path`, `start_time`, `end_time`, dan `add_to_beatmap=true`.
- Untuk membuat guest difficulty pada beatmap, gunakan argumen `beatmap_path` dan `in_context=[GD,TIMING,KIAI]`.
- Untuk menghasilkan hitsound pada beatmap, gunakan argumen `beatmap_path` dan `in_context=[NO_HS,TIMING,KIAI]`.
- Untuk hanya menghasilkan timing sebuah lagu, gunakan argumen `super_timing=true` dan `output_type=[TIMING]`.

## MaiMod: Alat Modding Berbasis AI

MaiMod adalah alat modding untuk beatmap osu! yang menggunakan prediksi Mapperatorinator untuk menemukan potensi kesalahan dan inkonsistensi yang tidak dapat dideteksi oleh alat modding otomatis lain seperti [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier).
Alat ini dapat mendeteksi masalah seperti:
- Snapping atau pola ritme yang salah
- Titik timing yang tidak akurat
- Posisi objek hit atau penempatan combo baru yang tidak konsisten
- Bentuk slider yang aneh
- Hitsound atau volume yang tidak konsisten

Anda dapat mencoba MaiMod [di sini](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), atau menjalankannya secara lokal:
Untuk menjalankan MaiMod secara lokal, Anda perlu menginstal Mapperatorinator. Setelah itu, jalankan skrip `mai_mod.py`, dengan menentukan path beatmap Anda menggunakan argumen `beatmap_path`.

```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Ini akan mencetak saran modding ke konsol, yang kemudian dapat Anda terapkan ke beatmap Anda secara manual.
Saran diurutkan secara kronologis dan dikelompokkan ke dalam kategori.
Nilai pertama dalam lingkaran menunjukkan 'surprisal' yang merupakan ukuran seberapa tidak terduga model menemukan masalah tersebut, sehingga Anda dapat memprioritaskan masalah yang paling penting.

Model dapat membuat kesalahan, terutama pada masalah dengan surprisal rendah, jadi selalu periksa ulang saran sebelum menerapkannya ke beatmap Anda.
Tujuan utama adalah membantu Anda mempersempit ruang pencarian untuk masalah potensial, sehingga Anda tidak perlu memeriksa setiap objek hit satu per satu secara manual di beatmap Anda.

### MaiMod GUI
Untuk menjalankan MaiMod Web UI, Anda perlu menginstal Mapperatorinator.
Kemudian, jalankan skrip `mai_mod_ui.py`. Ini akan memulai server web lokal dan secara otomatis membuka UI di jendela baru:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Ikhtisar

### Tokenisasi

Mapperatorinator mengonversi beatmap osu! menjadi representasi event intermediate yang dapat langsung diubah ke dan dari token.
Termasuk objek hit, hitsound, kecepatan slider, new combo, timing point, kiai time, dan kecepatan scroll taiko/mania.

Berikut adalah contoh kecil dari proses tokenisasi:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Untuk menghemat ukuran kosakata, event waktu dikuantisasi ke interval 10ms dan koordinat posisi dikuantisasi ke grid 32 piksel.

### Arsitektur Model
Model pada dasarnya adalah pembungkus di sekitar model [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), dengan embedding input dan fungsi loss khusus.
Ukuran model mencapai 219 juta parameter.
Model ini terbukti lebih cepat dan akurat daripada T5 untuk tugas ini.

Gambaran umum tingkat tinggi dari input-output model adalah sebagai berikut:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Model menggunakan frame Mel spectrogram sebagai input encoder, dengan satu frame per posisi input. Output decoder model pada setiap langkah adalah distribusi softmax atas kosakata event yang diskret dan telah ditentukan. Output bersifat sparse, event hanya diperlukan ketika objek hit terjadi, bukan pada setiap frame audio.

### Format Pelatihan Multitask

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Sebelum token SOS terdapat token tambahan yang memfasilitasi generasi kondisional. Token ini meliputi gamemode, tingkat kesulitan, ID mapper, tahun, dan metadata lainnya.
Selama pelatihan, token-token ini tidak memiliki label yang menyertainya, sehingga tidak pernah dioutput oleh model.
Juga selama pelatihan ada kemungkinan acak token metadata diganti oleh token 'unknown', sehingga pada inferensi kita dapat menggunakan token 'unknown' untuk mengurangi jumlah metadata yang harus diberikan ke model.

### Generasi Panjang Tanpa Seam

Panjang konteks model adalah 8.192 detik. Ini jelas tidak cukup untuk menghasilkan beatmap penuh, jadi kita harus membagi lagu menjadi beberapa window dan menghasilkan beatmap dalam bagian kecil.
Untuk memastikan beatmap yang dihasilkan tidak memiliki seam yang mencolok antar window, kita menggunakan overlap 90% dan menghasilkan window secara berurutan.
Setiap window generasi kecuali yang pertama dimulai dengan decoder yang sudah diisi hingga 50% window generasi dengan token dari window sebelumnya.
Kami menggunakan prosesor logit untuk memastikan bahwa model tidak dapat menghasilkan token waktu yang berada di 50% pertama dari jendela generasi.
Selain itu, 40% terakhir dari jendela generasi dicadangkan untuk jendela berikutnya. Setiap token waktu yang dihasilkan dalam rentang tersebut diperlakukan sebagai token EOS.
Ini memastikan bahwa setiap token yang dihasilkan dikondisikan setidaknya pada 4 detik token sebelumnya dan 3,3 detik audio masa depan untuk diantisipasi.

Untuk mencegah pergeseran offset selama proses generasi panjang, offset acak telah ditambahkan ke event waktu di dekoder selama pelatihan.
Ini memaksa model untuk mengoreksi kesalahan timing dengan mendengarkan onset pada audio, dan menghasilkan offset yang secara konsisten akurat.

### Koordinat yang diperhalus dengan difusi

Koordinat posisi yang dihasilkan oleh dekoder dikuantisasi ke grid piksel 32 titik, sehingga setelahnya kami menggunakan difusi untuk mendenoise koordinat ke posisi akhir.
Untuk ini kami melatih versi modifikasi dari [osu-diffusion](https://github.com/OliBomby/osu-diffusion) yang dikhususkan hanya pada 10% terakhir dari jadwal noise, dan menerima token metadata tingkat lanjut yang digunakan Mapperatorinator untuk generasi kondisional.

Karena model Mapperatorinator menghasilkan SV slider, panjang slider yang dibutuhkan menjadi tetap terlepas dari bentuk jalur titik kontrol.
Oleh karena itu, kami mencoba membimbing proses difusi untuk menghasilkan koordinat yang sesuai dengan panjang slider yang dibutuhkan.
Kami melakukan ini dengan menghitung ulang posisi akhir slider setelah setiap langkah proses difusi berdasarkan panjang yang dibutuhkan dan jalur titik kontrol saat ini.
Ini berarti bahwa proses difusi tidak memiliki kendali langsung atas posisi akhir slider, namun tetap dapat mempengaruhinya dengan mengubah jalur titik kontrol.

### Pasca-pemrosesan

Mapperatorinator melakukan beberapa pasca-pemrosesan tambahan untuk meningkatkan kualitas beatmap yang dihasilkan:

- Memperhalus koordinat posisi dengan difusi.
- Meresnap event waktu ke tick terdekat menggunakan pembagi snap yang dihasilkan model.
- Men-snap overlap posisi yang hampir sempurna.
- Mengonversi event kolom mania menjadi koordinat X.
- Menghasilkan jalur slider untuk taiko drumrolls.
- Memperbaiki perbedaan besar pada panjang slider yang dibutuhkan dan panjang jalur titik kontrol.

### Super timing generator

Super timing generator adalah algoritma yang meningkatkan presisi dan akurasi waktu yang dihasilkan dengan menginfer waktu untuk seluruh lagu sebanyak 20 kali dan merata-ratakan hasilnya.
Ini berguna untuk lagu dengan BPM variabel, atau lagu dengan perubahan BPM. Hasilnya hampir sempurna dan hanya kadang ada bagian yang butuh penyesuaian manual.

## Pelatihan

Instruksi di bawah ini membuat lingkungan pelatihan di mesin lokal Anda.

### 1. Clone repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Buat dataset

Buat dataset Anda sendiri menggunakan [aplikasi konsol Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Ini memerlukan [token klien OAuth osu!](https://osu.ppy.sh/home/account/edit) untuk memverifikasi beatmap dan mendapatkan metadata tambahan. Tempatkan dataset di direktori `datasets` di samping direktori `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opsional) Siapkan Weight & Biases untuk pencatatan
Buat akun di [Weight & Biases](https://wandb.ai/site) dan dapatkan API key dari pengaturan akun Anda.
Kemudian setel variabel lingkungan `WANDB_API_KEY`, agar proses pelatihan mengetahui untuk mencatat ke key ini.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Membuat kontainer docker
Pelatihan di venv Anda juga memungkinkan, namun kami merekomendasikan menggunakan Docker di WSL untuk performa yang lebih baik.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Konfigurasikan parameter dan mulai pelatihan

Semua konfigurasi terletak di `./configs/train/default.yaml`.
Pastikan untuk mengatur `train_dataset_path` dan `test_dataset_path` ke dataset Anda, serta indeks mapset awal dan akhir untuk pemisahan train/test.
Path bersifat lokal terhadap kontainer docker, jadi jika Anda menempatkan dataset bernama `cool_dataset` ke dalam direktori `datasets`, maka path-nya adalah `/workspace/datasets/cool_dataset`.

Saya sarankan untuk membuat file config kustom yang menimpa config default, agar Anda memiliki catatan konfigurasi pelatihan untuk reprodusibilitas.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Fine-tuning LoRA

Anda juga dapat melakukan fine-tuning pada model pra-latih dengan [LoRA](https://arxiv.org/abs/2106.09685) untuk menyesuaikannya dengan gaya atau mode permainan tertentu.
Untuk melakukan ini, sesuaikan `configs/train/lora.yaml` sesuai kebutuhan Anda dan jalankan konfigurasi pelatihan `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Parameter LoRA penting yang perlu dipertimbangkan:
- `pretrained_path`: Path atau repo HF dari model dasar untuk fine-tune.
- `r`: Rank dari matriks LoRA. Nilai lebih tinggi meningkatkan kapasitas model namun juga penggunaan memori.
- `lora_alpha`: Faktor skala untuk pembaruan LoRA.
- `total_steps`: Jumlah total langkah pelatihan. Sesuaikan dengan ukuran dataset Anda.
- `enable_lora`: Apakah menggunakan LoRA atau fine-tuning model penuh.

Saat inferensi, Anda dapat menentukan bobot LoRA yang digunakan dengan argumen `lora_path`.
Ini bisa berupa path lokal atau repo Hugging Face.

## Lihat juga
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Kredit

Terima kasih khusus kepada:
1. Para penulis [osuT5](https://github.com/gyataro/osuT5) atas kode pelatihannya.
2. Tim Hugging Face atas [tools](https://huggingface.co/docs/transformers/index) mereka.
3. [Jason Won](https://github.com/jaswon) dan [Richard Nagyfi](https://github.com/sedthh) atas ide-ide yang dibagikan.
4. [Marvin](https://github.com/minetoblend) atas donasi kredit pelatihan.
5. Komunitas osu! atas beatmap-nya.

## Karya terkait

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) oleh Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) oleh kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) oleh OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) oleh gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) oleh sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) oleh jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---