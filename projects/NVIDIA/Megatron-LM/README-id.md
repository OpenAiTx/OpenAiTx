<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>Teknik yang dioptimalkan untuk GPU untuk melatih model transformer skala besar</h4>

[![Documentation](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![version](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![license](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# Berita Terbaru

- **[2024/7]** Megatron-Core v0.7 meningkatkan skalabilitas dan ketahanan pelatihan serta menambah dukungan untuk pelatihan multimodal ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)). 
- **[2024/6]** Megatron-Core menambahkan dukungan untuk model berbasis Mamba. Baca makalah kami [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) dan [contoh kode](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba).
- **[2024/1 Pengumuman]** NVIDIA telah merilis kemampuan inti pada **Megatron-LM** ke dalam [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) di repositori ini. Megatron-Core memperluas teknik yang dioptimalkan GPU dari Megatron-LM dengan inovasi terbaru pada optimasi tingkat sistem, menampilkan API modular dan komposabel. Jelajahi [pengantar Megatron-Core](#megatron-core) untuk detail lebih lanjut.

# Daftar Isi

- [Megatron-LM & Megatron-Core](#megatron-lm--megatron-core)
- [Berita Terbaru](#berita-terbaru)
- [Daftar Isi](#daftar-isi)
- [Gambaran Umum Megatron](#gambaran-umum-megatron)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [Kecepatan dan Skalabilitas Pelatihan](#kecepatan-dan-skalabilitas-pelatihan)
- [Persiapan](#persiapan)
  - [Docker (Direkomendasikan)](#docker-direkomendasikan)
  - [Opsi Instalasi](#opsi-instalasi)
    - [Instal dari PyPI](#instal-dari-pypi)
    - [Instal dari Sumber](#instal-dari-sumber)
  - [Prasyarat](#prasyarat)
  - [Mengunduh Checkpoint](#mengunduh-checkpoint)
- [Penggunaan](#penggunaan)
- [Pelatihan](#pelatihan)
  - [Praproses Data](#praproses-data)
  - [Pralatih BERT](#pralatih-bert)
  - [Pralatih GPT](#pralatih-gpt)
  - [Pralatih T5](#pralatih-t5)
  - [Pralatih Terdistribusi](#pralatih-terdistribusi)
  - [Checkpointing Aktivasi dan Rekomputasi](#checkpointing-aktivasi-dan-rekomputasi)
  - [Optimizer Terdistribusi](#optimizer-terdistribusi)
  - [FlashAttention](#flashattention)
  - [Contoh GPT-3](#contoh-gpt-3)
  - [Retro dan InstructRetro](#retro-dan-instructretro)
  - [Model Bahasa Berbasis Mamba](#model-bahasa-berbasis-mamba)
  - [Mixture of Experts](#mixture-of-experts)
- [Evaluasi dan Tugas](#evaluasi-dan-tugas)
  - [Generasi Teks GPT](#generasi-teks-gpt)
    - [Detoksifikasi GPT via Self-generation](#detoksifikasi-gpt-via-self-generation)
  - [Evaluasi GPT](#evaluasi-gpt)
    - [Evaluasi Perpleksitas WikiText](#evaluasi-perpleksitas-wikitext)
    - [Akurasi Cloze LAMBADA](#akurasi-cloze-lambada)
  - [Evaluasi Tugas BERT](#evaluasi-tugas-bert)
    - [Evaluasi RACE](#evaluasi-race)
    - [Evaluasi MNLI](#evaluasi-mnli)
  - [Inferensi dan Finetuning Llama-2](#inferensi-dan-finetuning-llama-2)
- [Optimasi dan Deployment Model](#optimasi-dan-deployment-model)
  - [Kuantisasi dan Deployment TensorRT-LLM](#kuantisasi-dan-deployment-tensorrt-llm)
- [Dataset](#dataset)
  - [Mengumpulkan Data Latih Wikipedia](#mengumpulkan-data-latih-wikipedia)
  - [Mengumpulkan Data Webtext GPT](#mengumpulkan-data-webtext-gpt)
- [Reproduksibilitas](#reproduksibilitas)
- [Konversi Checkpoint](#konversi-checkpoint)
  - [Konversi Kelas Model](#konversi-kelas-model)
  - [Konversi Format Checkpoint](#konversi-format-checkpoint)
- [Proyek yang Menggunakan Megatron](#proyek-yang-menggunakan-megatron)

# Gambaran Umum Megatron
Repositori ini terdiri dari dua komponen utama: **Megatron-LM** dan **Megatron-Core**. Megatron-LM berfungsi sebagai kerangka kerja berorientasi riset yang memanfaatkan Megatron-Core untuk pelatihan model bahasa besar (LLM). Megatron-Core, di sisi lain, adalah pustaka teknik pelatihan yang dioptimalkan GPU yang dilengkapi dengan dukungan produk formal termasuk API versi dan rilis reguler. Anda dapat menggunakan Megatron-Core bersama Megatron-LM atau [Nvidia NeMo Framework](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) untuk solusi end-to-end dan cloud-native. Sebagai alternatif, Anda dapat mengintegrasikan blok bangunan Megatron-Core ke dalam kerangka pelatihan pilihan Anda.

## Megatron-LM
Pertama kali diperkenalkan pada tahun 2019, Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf), dan [3](https://arxiv.org/pdf/2205.05198)) memicu gelombang inovasi di komunitas AI, memungkinkan peneliti dan pengembang untuk memanfaatkan dasar pustaka ini guna mendorong kemajuan LLM. Saat ini, banyak kerangka kerja pengembang LLM paling populer yang terinspirasi dan dibangun langsung dengan memanfaatkan pustaka open-source Megatron-LM, memacu lahirnya model foundation dan startup AI. Beberapa kerangka kerja LLM terpopuler yang dibangun di atas Megatron-LM antara lain [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate), dan [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/). Daftar proyek yang secara langsung menggunakan Megatron dapat ditemukan [di sini](#proyek-yang-menggunakan-megatron).

## Megatron-Core
Megatron-Core adalah pustaka open-source berbasis PyTorch yang berisi teknik yang dioptimalkan GPU dan optimasi tingkat sistem terkini. Teknik-teknik ini diabstraksikan ke dalam API modular dan komposabel, memungkinkan fleksibilitas penuh bagi pengembang dan peneliti model untuk melatih transformer kustom skala besar pada infrastruktur komputasi percepatan NVIDIA. Pustaka ini kompatibel dengan semua GPU NVIDIA Tensor Core, termasuk dukungan akselerasi FP8 untuk [arsitektur NVIDIA Hopper](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/).

Megatron-Core menawarkan blok bangunan inti seperti mekanisme atensi, blok dan layer transformer, layer normalisasi, dan teknik embedding. Fungsionalitas tambahan seperti recomputation aktivasi, checkpoint terdistribusi juga sudah terintegrasi di pustaka ini. Semua blok bangunan dan fungsionalitas dioptimalkan untuk GPU, dan dapat dibangun dengan strategi paralelisasi canggih untuk kecepatan dan stabilitas pelatihan optimal pada Infrastruktur Komputasi Percepatan NVIDIA. Komponen kunci lain dari pustaka Megatron-Core meliputi teknik paralelisme model tingkat lanjut (tensor, sequence, pipeline, context, dan paralelisme MoE expert).

Megatron-Core dapat digunakan dengan [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/), platform AI kelas enterprise. Alternatif lain, Anda dapat menjelajahi Megatron-Core dengan native PyTorch training loop [di sini](https://github.com/NVIDIA/Megatron-LM/tree/main/examples). Kunjungi [dokumentasi Megatron-Core](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html) untuk mempelajari lebih lanjut.

# Kecepatan dan Skalabilitas Pelatihan
Basis kode kami mampu melatih model bahasa besar (misal, model dengan ratusan miliar parameter) secara efisien dengan model dan data paralelisme. Untuk mendemonstrasikan bagaimana perangkat lunak kami diskalakan dengan banyak GPU dan ukuran model, kami mempertimbangkan model GPT dari 2 miliar parameter hingga 462 miliar parameter. Semua model menggunakan ukuran kosakata 131.072 dan panjang urutan 4096. Kami memvariasikan ukuran hidden, jumlah head attention, dan jumlah layer untuk mendapatkan ukuran model tertentu. Seiring bertambahnya ukuran model, kami juga sedikit meningkatkan ukuran batch. Eksperimen kami menggunakan hingga 6144 GPU [H100](https://www.nvidia.com/en-us/data-center/h100/). Kami melakukan overlapping secara rinci antara komunikasi data-parallel (`--overlap-grad-reduce --overlap-param-gather`), tensor-parallel (`--tp-comm-overlap`) dan pipeline-parallel (aktif secara default) dengan komputasi untuk meningkatkan skalabilitas. Throughput yang dilaporkan diukur untuk pelatihan end-to-end dan mencakup semua operasi termasuk pemuatan data, langkah optimizer, komunikasi, dan bahkan logging. Perlu dicatat bahwa kami tidak melatih model ini hingga konvergen.

![Tabel Model](images/model_table.png)

Hasil weak scaling kami menunjukkan scaling superlinear (MFU meningkat dari 41% untuk model terkecil menjadi 47-48% untuk model terbesar); ini karena GEMM yang lebih besar memiliki intensitas aritmatika lebih tinggi dan karenanya lebih efisien untuk dieksekusi.

![Weak scaling](images/weak_scaling.png)

Kami juga melakukan strong scaling pada model GPT-3 standar (versi kami sedikit lebih dari 175 miliar parameter karena ukuran kosakata yang lebih besar) dari 96 GPU H100 hingga 4608 GPU, menggunakan ukuran batch yang sama yaitu 1152 urutan sepanjang percobaan. Komunikasi menjadi semakin terlihat pada skala besar, menyebabkan penurunan MFU dari 47% menjadi 42%.

![Strong scaling](images/strong_scaling.png)

# Persiapan

## Docker (Direkomendasikan)

Kami sangat menyarankan menggunakan rilis sebelumnya dari [PyTorch NGC Container](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) daripada yang terbaru. Rilis kami selalu didasarkan pada kontainer NGC bulan sebelumnya, sehingga memastikan kompatibilitas dan stabilitas. Kontainer ini sudah dilengkapi semua dependensi dengan versi yang kompatibel dan konfigurasi yang dioptimalkan untuk GPU NVIDIA.

```bash
# Tarik kontainer NGC sebelumnya (ganti 25.04 dengan versi bulan sebelumnya)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# Jalankan kontainer dengan direktori yang sudah di-mount
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## Opsi Instalasi

### Prasyarat

- PyTorch (versi stabil terbaru)
- CUDA, cuDNN, NCCL (versi stabil terbaru)
- Dukungan FP8 pada GPU NVIDIA Hopper, Ada, dan Blackwell
- Untuk performa terbaik, gunakan GPU generasi NVIDIA Turing ke atas

### Instal dari PyPI

Untuk menginstal versi stabil terbaru dengan pip:

```bash
# Instal rilis terbaru
pip install megatron-core
```

### Instal dari Sumber

```bash
# Clone repositori
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# Opsional checkout ke rilis tertentu
git checkout v0.11.0

# Instal dalam mode pengembangan
pip install -e .
```

## Mengunduh Checkpoint
Kami telah menyediakan checkpoint [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) dan [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) terlatih untuk evaluasi atau fine-tuning tugas hilir. Untuk mengakses checkpoint ini, pertama [daftar](https://ngc.nvidia.com/signup) dan [atur](https://ngc.nvidia.com/setup/installers/cli) CLI NVIDIA GPU Cloud (NGC) Registry. Dokumentasi lebih lanjut untuk mengunduh model dapat ditemukan di [dokumentasi NGC](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1).

Sebagai alternatif, Anda dapat langsung mengunduh checkpoint dengan:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

Model memerlukan file kosakata untuk berjalan. File WordPiece vocab BERT dapat diekstrak dari model BERT terlatih Google: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt). File [vocab GPT](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) dan [tabel merge](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) dapat diunduh langsung.

# Penggunaan

Setelah instalasi, terdapat beberapa alur kerja yang mungkin. Yang paling komprehensif adalah:
1. Praproses data
2. Pralatih
3. Fine-tuning (Opsional untuk tugas zero-shot)
4. Evaluasi tugas hilir atau generasi teks

Namun, langkah 1 dan 2 dapat digantikan dengan menggunakan salah satu model terlatih yang disebutkan di atas.

Kami telah menyediakan beberapa skrip untuk pralatih BERT dan GPT di direktori [`examples`](./examples), serta skrip untuk tugas hilir zero-shot maupun fine-tuned termasuk evaluasi MNLI, RACE, WikiText103, dan LAMBADA. Ada juga skrip untuk generasi teks interaktif GPT.

# Pelatihan
## Praproses Data
Data pelatihan memerlukan praproses. Pertama, letakkan data pelatihan Anda dalam format json longgar, dengan satu json berisi satu sampel teks per baris. Contohnya:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

Nama field `text` pada json dapat diubah dengan menggunakan flag `--json-key` pada [`preprocess_data.py`](./tools/preprocess_data.py). Metadata lainnya opsional dan tidak digunakan dalam pelatihan.

Json longgar tersebut kemudian diproses menjadi format biner untuk pelatihan. Untuk mengubah json ke format mmap, gunakan `preprocess_data.py`. Contoh skrip untuk menyiapkan data untuk pelatihan BERT adalah:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

Outputnya akan berupa dua file bernama, dalam kasus ini, `my-bert_text_sentence.bin` dan `my-bert_text_sentence.idx`. `--data-path` yang ditentukan pada pelatihan BERT berikutnya adalah path lengkap dan nama file baru, namun tanpa ekstensi file.

Untuk T5 gunakan praproses yang sama seperti BERT, mungkin dengan mengganti nama menjadi:
<pre>
       --output-prefix my-t5 \
</pre>
Beberapa modifikasi kecil diperlukan untuk pra-pemrosesan data GPT, yaitu penambahan tabel merge, token akhir dokumen, penghapusan pemisahan kalimat, dan perubahan tipe tokenizer:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

Di sini file output dinamai `my-gpt2_text_document.bin` dan `my-gpt2_text_document.idx`. Seperti sebelumnya, dalam pelatihan GPT, gunakan nama panjang tanpa ekstensi sebagai `--data-path`.

Argumen baris perintah lebih lanjut dijelaskan di file sumber [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py).

## Pretraining BERT

Skrip [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) menjalankan pretraining BERT dengan 345M parameter pada satu GPU. Debugging adalah tujuan utama untuk pelatihan GPU tunggal, karena basis kode dan argumen baris perintah dioptimalkan untuk pelatihan terdistribusi. Sebagian besar argumen cukup jelas. Secara default, learning rate akan menurun secara linear selama iterasi pelatihan dimulai dari `--lr` hingga minimum yang diatur oleh `--min-lr` selama iterasi `--lr-decay-iters`. Fraksi iterasi pelatihan yang digunakan untuk warmup diatur dengan `--lr-warmup-fraction`. Walaupun ini adalah pelatihan satu GPU, batch size yang ditentukan oleh `--micro-batch-size` adalah batch-size satu forward-backward path dan kode akan melakukan langkah akumulasi gradien sampai mencapai `global-batch-size` yang merupakan batch size per iterasi. Data dipartisi dalam rasio 949:50:1 untuk training/validation/test set (defaultnya 969:30:1). Partisi ini dilakukan secara dinamis, tetapi konsisten di seluruh run dengan seed random yang sama (default 1234, atau ditentukan manual dengan `--seed`). Kami menggunakan `train-iters` sebagai jumlah iterasi pelatihan yang diminta. Alternatifnya, Anda dapat memberikan `--train-samples` yaitu jumlah total sample yang akan dilatih. Jika opsi ini digunakan, maka alih-alih memberikan `--lr-decay-iters`, Anda perlu memberikan `--lr-decay-samples`.

Opsi interval logging, penyimpanan checkpoint, dan evaluasi juga ditentukan. Perhatikan bahwa `--data-path` sekarang mencakup tambahan akhiran `_text_sentence` yang ditambahkan pada pra-pemrosesan, tetapi tidak mencakup ekstensi file.

Argumen baris perintah lebih lanjut dijelaskan di file sumber [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

Untuk menjalankan `train_bert_340m_distributed.sh`, lakukan modifikasi yang diinginkan termasuk mengatur variabel lingkungan untuk `CHECKPOINT_PATH`, `VOCAB_FILE`, dan `DATA_PATH`. Pastikan untuk mengatur variabel-variabel ini ke path mereka di dalam container. Lalu jalankan container dengan Megatron dan mount path yang diperlukan (sebagaimana dijelaskan pada [Setup](#setup)) dan jalankan skrip contoh.

## Pretraining GPT

Skrip `examples/gpt3/train_gpt3_175b_distributed.sh` menjalankan pretraining GPT dengan 345M parameter pada satu GPU. Seperti disebutkan di atas, pelatihan GPU tunggal terutama dimaksudkan untuk tujuan debugging, karena kode dioptimalkan untuk pelatihan terdistribusi.

Formatnya sebagian besar sama dengan skrip BERT sebelumnya dengan beberapa perbedaan penting: skema tokenisasi yang digunakan adalah BPE (yang memerlukan tabel merge dan file vocab `json`) alih-alih WordPiece, arsitektur model memungkinkan urutan yang lebih panjang (perhatikan bahwa max position embedding harus lebih besar atau sama dengan panjang urutan maksimum), dan `--lr-decay-style` telah diset menjadi cosine decay. Perhatikan bahwa `--data-path` sekarang mencakup tambahan akhiran `_text_document` yang ditambahkan pada pra-pemrosesan, tetapi tidak mencakup ekstensi file.

Argumen baris perintah lebih lanjut dijelaskan di file sumber [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

`train_gpt3_175b_distributed.sh` dapat dijalankan dengan cara yang sama seperti BERT. Atur variabel lingkungan dan lakukan modifikasi lain, jalankan container dengan mount yang sesuai, dan jalankan skripnya.
Detail lebih lanjut di [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## Pretraining T5

Sangat mirip dengan BERT dan GPT, skrip `examples/t5/train_t5_220m_distributed.sh` menjalankan pretraining T5 "base" (~220M parameter) pada satu GPU. Perbedaan utama dari BERT dan GPT adalah penambahan argumen berikut untuk menyesuaikan arsitektur T5:

* `--kv-channels` mengatur dimensi dalam dari matriks "key" dan "value" di semua mekanisme attention dalam model. Untuk BERT dan GPT defaultnya adalah ukuran hidden dibagi jumlah attention head, tetapi dapat dikonfigurasi untuk T5.

* `--ffn-hidden-size` mengatur hidden size di jaringan feed-forward dalam sebuah layer transformer. Untuk BERT dan GPT defaultnya 4 kali transformer hidden size, tetapi dapat dikonfigurasi untuk T5.

* `--encoder-seq-length` dan `--decoder-seq-length` mengatur panjang urutan untuk encoder dan decoder secara terpisah.

Semua argumen lain tetap seperti pada pretraining BERT dan GPT. Jalankan contoh ini dengan langkah yang sama seperti skrip lain di atas.

Detail lebih lanjut di [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## Pretraining Terdistribusi

Skrip `pretrain_{bert,gpt,t5}_distributed.sh` menggunakan PyTorch distributed launcher untuk pelatihan terdistribusi. Dengan demikian, pelatihan multi-node dapat dicapai dengan mengatur variabel lingkungan dengan benar. Lihat [dokumentasi](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) resmi PyTorch untuk penjelasan lebih lanjut tentang [variabel lingkungan](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization) ini. Secara default, pelatihan multi-node menggunakan backend terdistribusi [nccl](https://developer.nvidia.com/nccl). Satu set argumen tambahan sederhana dan penggunaan modul distributed PyTorch dengan elastic launcher `torchrun` (setara dengan `python -m torch.distributed.run`) adalah satu-satunya syarat tambahan untuk mengadopsi pelatihan terdistribusi. Lihat salah satu dari `pretrain_{bert,gpt,t5}_distributed.sh` untuk detail lebih lanjut.

Kami menggunakan dua jenis paralelisme: data dan model paralel. Implementasi data paralel kami ada di `megatron/core/distributed`, dan mendukung overlapping reduksi gradien dengan backward pass saat opsi baris perintah `--overlap-grad-reduce` digunakan.

Kedua, kami mengembangkan pendekatan model-parallel dua dimensi yang sederhana dan efisien. Untuk menggunakan dimensi pertama, tensor model parallelism (membagi eksekusi satu modul transformer ke beberapa GPU, lihat Bagian 3 dari [paper kami](https://arxiv.org/pdf/1909.08053.pdf)), tambahkan flag `--tensor-model-parallel-size` untuk menentukan jumlah GPU yang akan membagi model, beserta argumen yang diberikan ke distributed launcher seperti dijelaskan di atas. Untuk menggunakan dimensi kedua, sequence parallelism, tentukan `--sequence-parallel`, yang juga memerlukan tensor model parallelism diaktifkan karena membagi pada GPU yang sama (detail lebih lanjut di Bagian 4.2.2 dari [paper kami](https://arxiv.org/pdf/2205.05198.pdf)).

Untuk menggunakan pipeline model parallelism (memecah modul transformer menjadi beberapa stage dengan jumlah modul transformer yang sama di setiap stage, lalu mengeksekusi pipeline dengan membagi batch ke microbatch yang lebih kecil, lihat Bagian 2.2 dari [paper kami](https://arxiv.org/pdf/2104.04473.pdf)), gunakan flag `--pipeline-model-parallel-size` untuk menentukan jumlah stage untuk membagi model (misal, model dengan 24 transformer layer dibagi ke 4 stage berarti setiap stage mendapat 6 transformer layer).

Kami menyediakan contoh penggunaan dua bentuk model parallelism ini pada skrip contoh yang diakhiri dengan `distributed_with_mp.sh`.

Selain perubahan kecil ini, pelatihan terdistribusi identik dengan pelatihan pada satu GPU.

Jadwal pipeline interleaved (detail lebih lanjut di Bagian 2.2.2 dari [paper kami](https://arxiv.org/pdf/2104.04473.pdf)) dapat diaktifkan menggunakan argumen `--num-layers-per-virtual-pipeline-stage`, yang mengontrol jumlah transformer layer dalam satu virtual stage (secara default dengan jadwal non-interleaved, setiap GPU akan mengeksekusi satu virtual stage dengan `NUM_LAYERS / PIPELINE_MP_SIZE` transformer layer). Jumlah total layer dalam model transformer harus habis dibagi oleh nilai argumen ini. Selain itu, jumlah microbatch di pipeline (dihitung sebagai `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) harus habis dibagi oleh `PIPELINE_MP_SIZE` saat menggunakan jadwal ini (kondisi ini dicek melalui assertion di kode). Jadwal interleaved tidak didukung untuk pipeline dengan 2 stage (`PIPELINE_MP_SIZE=2`).

## Checkpointing Aktivasi dan Recomputation

Untuk mengurangi penggunaan memori GPU saat melatih model besar, kami mendukung berbagai bentuk checkpointing aktivasi dan recomputation. Alih-alih semua aktivasi disimpan di memori untuk digunakan selama backprop, seperti pada model deep learning tradisional, hanya aktivasi pada "checkpoint" tertentu di model yang dipertahankan (atau disimpan) di memori, dan aktivasi lain dihitung ulang secara dinamis saat diperlukan untuk backprop. Perlu dicatat bahwa checkpointing ini, *checkpointing aktivasi*, sangat berbeda dengan checkpointing parameter model dan state optimizer, yang dijelaskan di bagian lain.

Kami mendukung dua tingkat granularitas recompute: `selective` dan `full`. Recomputation selektif adalah default dan direkomendasikan di hampir semua kasus. Mode ini mempertahankan di memori aktivasi yang memerlukan ruang penyimpanan kecil dan mahal untuk dihitung ulang, dan menghitung ulang aktivasi yang memerlukan ruang penyimpanan besar tetapi murah untuk dihitung ulang. Lihat [paper kami](https://arxiv.org/pdf/2205.05198) untuk detail. Anda akan menemukan bahwa mode ini memaksimalkan performa sambil meminimalkan memori yang dibutuhkan untuk menyimpan aktivasi. Untuk mengaktifkan recompute aktivasi selektif cukup gunakan `--recompute-activations`.

Untuk kasus di mana memori sangat terbatas, recompute `full` hanya menyimpan input ke satu layer transformer, atau kelompok, atau blok, dari layer transformer, dan menghitung ulang sisanya. Untuk mengaktifkan recompute aktivasi penuh gunakan `--recompute-granularity full`. Saat menggunakan recompute aktivasi `full`, ada dua metode: `uniform` dan `block`, dipilih menggunakan argumen `--recompute-method`.

* Metode `uniform` membagi layer transformer secara merata ke dalam kelompok layer (masing-masing berukuran `--recompute-num-layers`) dan menyimpan aktivasi input setiap kelompok di memori. Ukuran kelompok baseline adalah 1 dan, dalam kasus ini, aktivasi input setiap layer transformer disimpan. Saat memori GPU tidak cukup, menambah jumlah layer per kelompok akan mengurangi penggunaan memori, memungkinkan pelatihan model yang lebih besar. Misalnya, jika `--recompute-num-layers` diatur ke 4, hanya aktivasi input dari setiap kelompok 4 layer transformer yang disimpan.

* Metode `block` menghitung ulang aktivasi input sejumlah layer transformer tertentu (diberikan oleh `--recompute-num-layers`) per pipeline stage dan menyimpan aktivasi input layer sisanya di pipeline stage. Mengurangi `--recompute-num-layers` berarti semakin banyak aktivasi input layer transformer yang disimpan, sehingga mengurangi recompute aktivasi pada backprop, meningkatkan performa pelatihan namun meningkatkan penggunaan memori. Misalnya, jika ditentukan 5 layer untuk direcompute dari 8 layer per pipeline stage, hanya aktivasi input dari 5 layer transformer pertama yang dihitung ulang pada langkah backprop, sedangkan aktivasi input untuk 3 layer terakhir disimpan. `--recompute-num-layers` dapat dinaikkan secara bertahap hingga jumlah memori yang dibutuhkan cukup kecil untuk muat di memori yang tersedia, sehingga memaksimalkan penggunaan memori dan performa.

## Optimizer Terdistribusi

Penggunaan: `--use-distributed-optimizer`. Kompatibel dengan semua tipe model dan data.

Optimizer terdistribusi adalah teknik penghematan memori, di mana state optimizer didistribusikan secara merata ke seluruh rank data parallel (berbeda dengan metode tradisional yang mereplikasi state optimizer ke seluruh rank data parallel). Seperti dijelaskan di [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054), implementasi kami mendistribusikan semua state optimizer yang tidak overlap dengan state model. Misalnya, saat menggunakan fp16 model params, optimizer terdistribusi mempertahankan salinan sendiri dari fp32 main params & grads, yang didistribusikan ke seluruh DP rank. Saat menggunakan bf16 model params, grad utama fp32 dari optimizer terdistribusi adalah sama dengan grad fp32 model, sehingga grad pada kasus ini tidak didistribusikan (meskipun main param fp32 tetap didistribusikan karena terpisah dari bf16 model params).

Penghematan memori secara teoritis bervariasi tergantung kombinasi tipe data param model dan grad. Pada implementasi kami, jumlah byte teoritis per parameter adalah (dimana 'd' adalah ukuran data parallel):

| | Optim non-terdistribusi | Optim terdistribusi |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

Seperti pada data parallelism biasa, overlapping reduksi gradien (dalam hal ini reduce-scatter) dengan backward pass dapat difasilitasi dengan flag `--overlap-grad-reduce`. Selain itu, overlapping all-gather parameter dapat dilakukan bersamaan dengan forward pass menggunakan `--overlap-param-gather`.

## FlashAttention

Penggunaan: `--use-flash-attn`. Mendukung dimensi attention head maksimal 128.

[FlashAttention](https://github.com/HazyResearch/flash-attention) adalah algoritma cepat dan efisien memori untuk menghitung attention secara tepat. Ini mempercepat pelatihan model dan mengurangi kebutuhan memori.

Untuk menginstal FlashAttention:
```sh
pip install flash-attn
```

## Contoh GPT-3

Pada `examples/gpt3/train_gpt3_175b_distributed.sh` kami menyediakan contoh konfigurasi Megatron untuk melatih [GPT-3](https://arxiv.org/abs/2005.14165) dengan 175 miliar parameter pada 1024 GPU. Skrip ini didesain untuk [slurm](https://slurm.schedmd.com/documentation.html) dengan plugin [pyxis](https://github.com/NVIDIA/pyxis) tetapi bisa dengan mudah diadaptasi ke scheduler lain. Menggunakan 8-way tensor parallelism dan 16-way pipeline parallelism. Dengan opsi `global-batch-size 1536` dan `rampup-batch-size 16 16 5859375`, pelatihan akan dimulai dengan global batch size 16 dan meningkat linear hingga 1536 selama 5.859.375 sample dengan langkah 16. Dataset pelatihan bisa berupa satu set atau gabungan beberapa dataset dengan bobot tertentu.

Dengan global batch size penuh 1536 pada 1024 GPU A100, setiap iterasi memakan waktu sekitar 32 detik menghasilkan 138 teraFLOPs per GPU yang merupakan 44% dari peak FLOPs teoritis.

## Retro dan InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) adalah model language model (LM) autoregresif decoder-only yang dipra-latih dengan retrieval-augmentation.
Retro menawarkan skalabilitas praktis untuk mendukung pretraining skala besar dari awal dengan melakukan retrieval dari triliunan token.
Pretraining dengan retrieval menyediakan mekanisme penyimpanan pengetahuan faktual yang lebih efisien, dibandingkan dengan menyimpan pengetahuan faktual secara implisit dalam parameter jaringan, sehingga secara signifikan mengurangi jumlah parameter model sambil mencapai perplexity lebih rendah dibandingkan GPT standar.
Retro juga menyediakan fleksibilitas untuk memperbarui
pengetahuan yang tersimpan dalam LM [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)
dengan memperbarui retrieval database tanpa melatih LM kembali.

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) lebih lanjut memperbesar ukuran Retro hingga 48B, menjadikannya LLM terbesar yang dipra-latih dengan retrieval (per Desember 2023).
Model dasar yang dihasilkan, Retro 48B, secara signifikan mengungguli GPT setara dalam hal perplexity.
Dengan instruction tuning pada Retro, InstructRetro menunjukkan peningkatan signifikan dibanding instruction-tuned GPT pada tugas hilir dalam pengaturan zero-shot. Secara spesifik, rata-rata peningkatan InstructRetro adalah 7% dibanding GPT pada 8 tugas QA short-form, dan 10% dibanding GPT pada 4 tugas QA long-form yang menantang. Kami juga menemukan bahwa encoder pada arsitektur InstructRetro dapat dihapus dan langsung menggunakan backbone decoder InstructRetro sebagai GPT, dengan hasil yang sebanding.

Dalam repo ini, kami menyediakan panduan reproduksi end-to-end untuk mengimplementasikan Retro dan InstructRetro, meliputi
- **Konstruksi retrieval database**, yang mendukung miliaran hingga triliunan token sebagai retrieval database skala besar.
- **Pretraining dengan retrieval**, yang mendukung pretraining dari awal maupun pretraining dari model GPT yang sudah dipra-latih (Retro-fitting).
- **Instruction tuning**, di mana kami menyediakan dataset instruction tuning open-source dan resep pelatihan untuk instruction tuning pada Retro.
- **Evaluasi tugas hilir**, di mana kami menyediakan skrip text generation dan evaluasi untuk tugas question answering zero-shot.

Lihat [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md) untuk penjelasan detail.

## Model Bahasa Berbasis Mamba

Lihat [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) untuk detail.

<!--
## REALM Pipeline
Kami sedang mengimplementasikan sistem [REALM](https://arxiv.org/pdf/2002.08909.pdf). Bagian berikut (akan) merefleksikan tiga tahap pelatihannya. Untuk saat ini hanya ada kode ICT.
Secara garis besar, tahapannya adalah pretraining modul retriever, lalu pelatihan bersama language model dan retriever, lalu fine-tuning question answering head pada language model dengan retriever yang di-freeze.

### Pretraining Inverse Cloze Task (ICT)
1. Siapkan korpus dalam format JSON bebas dengan tujuan membuat kumpulan blok teks berukuran tetap sebagai unit data dasar. Untuk korpus seperti Wikipedia, ini berarti beberapa kalimat per blok namun juga beberapa blok per dokumen.
Jalankan `tools/preprocess_data.py` untuk membangun satu atau lebih indexed dataset dengan argumen `--split-sentences` agar kalimat menjadi unit dasar. Untuk sistem REALM asli, kami membangun dua dataset, satu dengan judul tiap dokumen, satu lagi dengan isi.
Lihat skrip berikut
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # cocok untuk 10 core CPU. Sesuaikan jika perlu.
</pre>

2. Gunakan fungsi mapping sample kustom sebagai pengganti `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping` jika diperlukan. Untuk melakukan ini, Anda perlu mengimplementasikan fungsi baru di C++ dalam `megatron/core/datasets/helpers.cpp`. Struktur data mapping sample digunakan untuk memilih data yang akan membentuk setiap sample pelatihan sebelum training loop.
 Mapping sample bertanggung jawab menyimpan seluruh metadata yang diperlukan untuk membangun sample dari satu atau lebih indexed dataset. Pada REALM, mapping sample berisi indeks awal dan akhir kalimat, serta indeks dokumen (untuk menemukan judul yang benar untuk body) dan ID unik untuk setiap blok.
3. Pretrain model bahasa BERT dengan `pretrain_bert.py`, dengan sequence length sama dengan ukuran blok dalam token id. Model ini harus dilatih pada indexed dataset yang sama yang digunakan untuk menyediakan blok bagi tugas information retrieval.
Pada REALM, ini adalah uncased bert base model yang dilatih dengan hyperparameter standar.
4. Gunakan `pretrain_ict.py` untuk melatih `ICTBertModel` yang menggunakan dua encoder berbasis BERT untuk meng-encode query dan block untuk melakukan retrieval.
Skrip di bawah ini melatih model ICT dari REALM. Skrip ini merujuk pretrained BERT model (langkah 3) pada argumen `--bert-load`. Batch size yang digunakan pada paper adalah 4096, jadi ini perlu dijalankan dengan data parallel world size 32.
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### Membangun Index Embedding Blok
Setelah model ICT dilatih, Anda dapat meng-embed seluruh dataset blok dengan membuat struktur `BlockData`. Setelah disimpan, Anda dapat memuatnya
dan membungkusnya dengan `FaissMIPSIndex` untuk melakukan pencarian similarity dengan cepat yang penting dalam pipeline information retrieval berbasis pembelajaran. Index awal dapat dibangun dengan skrip berikut, yang sebaiknya dijalankan dalam sesi interaktif. Skrip ini dapat memanfaatkan banyak GPU di banyak node untuk mengindeks dataset besar dengan lebih cepat.
<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /path/to/pretrained_ict \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /path/to/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) adalah arsitektur LLM yang kuat yang diimplementasikan dalam framework Megatron-Core, dirancang untuk meningkatkan efisiensi dan skalabilitas model bahasa besar. Ini memanfaatkan **Expert Parallelism**, memungkinkan beberapa expert didistribusikan ke berbagai worker, di mana setiap worker memproses batch sampel pelatihan yang berbeda. Metode ini secara signifikan meningkatkan throughput komputasi, memungkinkan model mencapai metrik performa tinggi, seperti 47% MFU selama pelatihan BF16 untuk 8x7B di H100.

Fitur Utama MoE:
- **Teknik Paralelisme**: MoE menggabungkan berbagai strategi paralelisme, termasuk Expert Parallelism, Data Parallelism, Tensor Parallelism, Sequence Parallelism, Pipeline Parallelism, dan Context Parallelism. Kombinasi ini memungkinkan penanganan varian model yang lebih besar secara efektif.
- **Router dan Load Balancing**: Sistem ini menggunakan mekanisme routing canggih seperti Top-K router dan memanfaatkan algoritma load balancing untuk mengoptimalkan distribusi token di antara para expert.
- **Optimasi Performa**: Teknik seperti GroupedGEMM dan pelatihan FP8 meningkatkan efisiensi model MoE, terutama ketika banyak expert terlibat.
- **Mekanisme Dispatch Token**: MoE mendukung strategi dropless maupun token drop untuk mengelola distribusi token secara efektif di antara para expert.

Untuk gambaran lengkap tentang konfigurasi pelatihan dan optimasi MoE, silakan merujuk ke README terperinci yang terletak di [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md).

# Evaluasi dan Tugas

Kami menyediakan beberapa argumen baris perintah, dijelaskan secara rinci dalam skrip yang tercantum di bawah, untuk menangani berbagai tugas zero-shot dan fine-tuned downstream. Namun, Anda juga dapat melakukan fine-tune model Anda dari checkpoint pralatih pada korpus lain sesuai keinginan. Untuk melakukannya, cukup tambahkan flag `--finetune` dan sesuaikan file input serta parameter pelatihan dalam skrip pelatihan asli. Jumlah iterasi akan direset ke nol, dan optimizer serta state internal akan diinisialisasi ulang. Jika fine-tuning terhenti karena alasan apa pun, pastikan untuk menghapus flag `--finetune` sebelum melanjutkan, jika tidak pelatihan akan dimulai kembali dari awal.

Karena evaluasi membutuhkan memori yang jauh lebih sedikit daripada pelatihan, mungkin lebih menguntungkan untuk menggabungkan model yang dilatih secara paralel agar dapat digunakan pada GPU yang lebih sedikit untuk tugas downstream. Skrip berikut melakukan hal tersebut. Contoh ini membaca model GPT dengan paralelisme tensor 4 arah dan pipeline 4 arah, lalu menulis model dengan paralelisme tensor 2 arah dan pipeline 2 arah.

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

Beberapa tugas downstream dijelaskan untuk model GPT dan BERT di bawah ini. Tugas-tugas ini dapat dijalankan dalam mode distributed dan model parallel dengan perubahan yang sama seperti pada skrip pelatihan.

## GPT Text Generation

Kami telah menyertakan server REST sederhana untuk digunakan dalam text generation di `tools/run_text_generation_server.py`. Anda menjalankannya hampir sama seperti memulai pekerjaan pretraining, dengan menentukan checkpoint pralatih yang sesuai. Ada juga beberapa parameter opsional: `temperature`, `top-k` dan `top-p`. Lihat `--help` atau file sumber untuk informasi lebih lanjut. Lihat [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh) untuk contoh menjalankan server.

Setelah server berjalan, Anda dapat menggunakan `tools/text_generation_cli.py` untuk melakukan query, dengan satu argumen yaitu host tempat server berjalan.

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

Anda juga dapat menggunakan CURL atau alat lain untuk query langsung ke server:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

Lihat [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py) untuk opsi API lainnya.

### Detoxify GPT via Self-generation
Kami menyertakan contoh di `examples/academic_paper_scripts/detxoify_lm/` untuk mendetoksifikasi model bahasa dengan memanfaatkan kemampuan generatif model bahasa.

Lihat [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md) untuk tutorial langkah demi langkah tentang cara melakukan pelatihan domain-adaptive dan mendetoksifikasi LM menggunakan korpus hasil self-generation.


## GPT Evaluation
Kami menyertakan skrip contoh untuk evaluasi GPT pada evaluasi perplexity WikiText dan akurasi Cloze LAMBADA.

### Evaluasi Perplexity WikiText
Untuk perbandingan yang adil dengan pekerjaan sebelumnya, kami mengevaluasi perplexity pada [dataset uji WikiText-103](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip) tingkat kata, dan menghitung perplexity secara tepat sesuai perubahan token saat menggunakan subword tokenizer kami.

Kami menggunakan perintah berikut untuk menjalankan evaluasi WikiText-103 pada model dengan 345M parameter.
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext path&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>


### Akurasi Cloze LAMBADA
Untuk menghitung akurasi cloze LAMBADA (akurasi dalam memprediksi token terakhir berdasarkan token sebelumnya) kami menggunakan versi detokenisasi dan telah diproses dari [dataset LAMBADA](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl).

Kami menggunakan perintah berikut untuk menjalankan evaluasi LAMBADA pada model dengan 345M parameter. Perhatikan bahwa flag `--strict-lambada` harus digunakan untuk mewajibkan pencocokan kata secara utuh. Pastikan `lambada` ada di bagian path file.

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada path&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;sama seperti pada <a href="#wikitext-perplexity-evaluation">Evaluasi Perplexity WikiText</a> di atas&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

Argumen baris perintah lebih lanjut dijelaskan dalam file sumber [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## Evaluasi Tugas BERT
### Evaluasi RACE
Skrip berikut melakukan fine-tune model BERT untuk evaluasi pada [dataset RACE](http://www.cs.cmu.edu/~glai1/data/race/). Direktori `TRAIN_DATA` dan `VALID_DATA` berisi dataset RACE sebagai file `.txt` terpisah. Perhatikan untuk RACE, batch size adalah jumlah query RACE yang dievaluasi. Karena setiap query RACE memiliki empat sampel, batch size efektif yang diproses model akan empat kali lipat batch size yang ditentukan pada baris perintah.

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### Evaluasi MNLI
Skrip berikut melakukan fine-tune model BERT untuk evaluasi dengan [korpus pasangan kalimat MultiNLI](https://www.nyu.edu/projects/bowman/multinli/). Karena tugas pencocokan sangat mirip, skrip ini dapat dengan cepat diubah agar dapat digunakan dengan dataset [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP) juga.

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;sama seperti pada <a href="#race-evaluation">Evaluasi RACE</a> di atas&#62;
COMMON_TASK_ARGS_EXT=&#60;sama seperti pada <a href="#race-evaluation">Evaluasi RACE</a> di atas&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## Inferensi dan Finetuning Llama-2

[Llama-2](https://ai.meta.com/llama/) adalah keluarga model open-source yang telah dipra-latih & di-finetune (untuk chat) dan telah mencapai hasil yang kuat di berbagai benchmark. Pada saat perilisan, model Llama-2 mencapai hasil terbaik di antara model open-source, dan bersaing dengan model closed-source GPT-3.5 (lihat https://arxiv.org/pdf/2307.09288.pdf).

Checkpoint Llama-2 dapat dimuat ke dalam Megatron untuk inferensi dan finetuning. Lihat dokumentasi [di sini](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md).

# Optimasi Model dan Deployment
Megatron-Core (MCore) keluarga `GPTModel` mendukung algoritma kuantisasi lanjutan dan inferensi performa tinggi melalui TensorRT-LLM.

## Kuantisasi dan Deployment TensorRT-LLM
Lihat [Optimasi Model dan Deployment Megatron](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/quantization/README.md) untuk contoh `llama2` dan `nemotron3`.

# Dataset
Kami tidak menyediakan dataset untuk pelatihan GPT atau BERT, namun kami merinci proses pengumpulannya agar hasil kami dapat direproduksi.

## Mengumpulkan Data Pelatihan Wikipedia
Kami merekomendasikan mengikuti proses ekstraksi data Wikipedia seperti yang ditentukan oleh Google research: "pre-processing yang direkomendasikan adalah mengunduh [dump terbaru](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2), mengekstrak teks dengan [WikiExtractor.py](https://github.com/attardi/wikiextractor), dan kemudian melakukan pembersihan yang diperlukan agar menjadi plain text."

Kami merekomendasikan menggunakan argumen `--json` ketika menggunakan WikiExtractor, yang akan membuang data Wikipedia ke format json longgar (satu objek json per baris), sehingga lebih mudah dikelola di sistem file dan juga dapat langsung digunakan oleh basis kode kami. Kami juga menyarankan pemrosesan tambahan dataset json ini dengan standarisasi tanda baca nltk. Untuk pelatihan BERT, gunakan flag `--split-sentences` pada `preprocess_data.py` seperti dijelaskan [di atas](#data-preprocessing) untuk memasukkan jeda kalimat dalam indeks yang dihasilkan. Jika Anda ingin menggunakan data Wikipedia untuk pelatihan GPT Anda tetap harus membersihkannya dengan nltk/spacy/ftfy, tetapi jangan gunakan flag `--split-sentences`.

## Mengumpulkan Data Webtext GPT
Kami menggunakan pustaka [OpenWebText](https://github.com/eukaryote31/openwebtext) yang tersedia secara publik dari [jcpeterson](https://github.com/jcpeterson/openwebtext) dan [eukaryote31](https://github.com/eukaryote31/openwebtext) untuk mengunduh url. Kami kemudian memfilter, membersihkan, dan menghapus duplikasi semua konten yang diunduh sesuai dengan prosedur yang dijelaskan di direktori [openwebtext](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/openwebtext). Untuk url reddit yang sesuai dengan konten hingga Oktober 2018, kami memperoleh sekitar 37GB konten.

# Reproducibility
Pelatihan Megatron dapat direproduksi secara bitwise; untuk mengaktifkan mode ini gunakan `--deterministic-mode`. Ini berarti bahwa konfigurasi pelatihan yang sama dijalankan dua kali di lingkungan HW dan SW yang sama akan menghasilkan checkpoint model, loss, dan nilai metrik akurasi yang identik (metrik waktu iterasi dapat bervariasi).

Saat ini ada tiga optimasi Megatron yang diketahui dapat memecah reproducibility namun tetap menghasilkan pelatihan yang hampir identik:
1. Algoritma NCCL spesifik yang digunakan selama all-reduce (seperti yang ditentukan oleh variabel lingkungan `NCCL_ALGO`) penting. Kami telah menguji berikut ini: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain`. Kode mengizinkan penggunaan `^NVLS`, yang memungkinkan NCCL memilih algoritma non-NVLS; pilihannya tampak stabil.
2. Flash attention bersifat non-deterministik; jangan gunakan `--use-flash-attn`.
3. Jika menggunakan Transformer Engine, Anda juga harus mengatur variabel lingkungan `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0`.

Selain itu, determinisme hanya telah diverifikasi dalam kontainer NGC PyTorch hingga dan lebih baru dari 23.12. Jika Anda menemukan non-determinisme dalam pelatihan Megatron dalam kondisi lain silakan buka issue.

# Konversi Checkpoint

Kami mendukung dua bentuk konversi model:

1. Konversi kelas model (misalnya, `GPTModel` di `model.legacy` vs. `model.core`)
2. Konversi format checkpoint (mis. checkpoint terdistribusi vs. non-terdistribusi)

## Konversi kelas model

Megatron mendukung konversi antar kelas model yang berbeda, termasuk kelas model internal (saat ini kami memiliki model `legacy` lama, dan model `core` baru) dan kelas model eksternal (seperti model Meta, Huggingface, Mistral, dan Mixtral). Selain itu, selama konversi ini, Anda dapat memperbarui state paralel model (mis. mengubah tensor dan pipeline model paralelisme).

 Kami menyediakan tool `tools/checkpoint/convert.py` untuk konversi antar kelas model. Beberapa argumen penting meliputi:

- `--model-type`: `GPT` atau `BERT`
- `--loader`: format checkpoint yang ada. Format yang didukung meliputi:
  - `legacy`: kelas model lama kami (di bawah `megatron.legacy.model`)
  - `core`: kelas model baru kami (di bawah `megatron.core.models`)
  - `llama_mistral`: untuk memuat model Llama dan Mistral (mendukung format Meta dan Huggingface)
  - `mixtral_hf`: untuk memuat model Mixtral (hanya Huggingface)
- `--load-dir`: direktori untuk memuat checkpoint yang ada
- `--saver`: `legacy` atau `core` (lihat deskripsi di bawah `--loader`)
- `--save-dir`: direktori untuk menyimpan checkpoint baru
- `--target-tensor-parallel-size`: ukuran tensor model paralel baru
- `--target-pipeline-parallel-size`: ukuran pipeline model paralel baru

Untuk detail argumen lebih lanjut, silakan lihat skrip utama (`convert.py`), skrip loader (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`), atau skrip saver (`saver_core.py`, `saver_legacy.py`).

Contoh perintah untuk mengonversi model GPT dari format lama (`legacy`) ke format baru (`core`) adalah sebagai berikut:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

Untuk contoh mengonversi model Llama/Mistral ke Megatron, silakan lihat [di sini](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md).

## Konversi format checkpoint

Megatron menawarkan beberapa format checkpoint, termasuk:

- `torch`: Format checkpoint dasar dengan pembacaan & penulisan berurutan, dan terikat pada state paralel model tensor/pipeline spesifik (masing-masing state TP/PP). (Walaupun checkpoint spesifik terikat pada state TP/PP tertentu, checkpoint masih dapat dikonversi secara manual melalui konverter kelas model seperti dijelaskan di atas).
- `torch_dist`: Format checkpoint terdistribusi, untuk pembacaan & penulisan paralel yang cepat, dan juga agnostik terhadap state paralel (mis. dapat dimuat ke pengaturan TP/PP yang berbeda).

Secara umum, `torch_dist` adalah format checkpoint yang lebih modern dan direkomendasikan karena kecepatannya. Namun, tergantung kasus penggunaan, mungkin diinginkan untuk mengonversi antara kedua format ini. Untuk melakukannya, jalankan skrip *training* Anda (mis. melalui `pretrain_gpt.py`) seperti biasa, tetapi dengan dua argumen tambahan:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` dapat berupa `torch` atau `torch_dist`, seperti dijelaskan di atas.
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: path ini harus berbeda dari path `--load`/`--save` yang ada, untuk menghindari menimpa checkpoint yang ada. Setelah dikonversi, gunakan path baru ini untuk `--load`/`--save` Anda.

Ide utama konverter format checkpoint ini adalah meluncurkan model seperti biasanya untuk pelatihan, tetapi sebelum menjalankan iterasi pelatihan, menyimpan ke format checkpoint baru, lalu keluar. Penting untuk dicatat bahwa semua argumen peluncuran lainnya harus tetap sama, agar sistem dapat memahami format checkpoint sebelumnya.

# Proyek yang Menggunakan Megatron
Berikut beberapa proyek yang secara langsung menggunakan Megatron:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---