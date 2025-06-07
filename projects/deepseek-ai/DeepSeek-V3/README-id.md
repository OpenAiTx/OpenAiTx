<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## Daftar Isi

1. [Pendahuluan](#1-pendahuluan)
2. [Ringkasan Model](#2-ringkasan-model)
3. [Unduh Model](#3-unduh-model)
4. [Hasil Evaluasi](#4-hasil-evaluasi)
5. [Situs Chat & Platform API](#5-situs-chat--platform-api)
6. [Cara Menjalankan Secara Lokal](#6-cara-menjalankan-secara-lokal)
7. [Lisensi](#7-lisensi)
8. [Sitasi](#8-sitasi)
9. [Kontak](#9-kontak)


## 1. Pendahuluan

Kami mempersembahkan DeepSeek-V3, model bahasa Mixture-of-Experts (MoE) yang kuat dengan total 671M parameter dan 37M parameter yang diaktifkan untuk setiap token. 
Untuk mencapai inferensi yang efisien dan pelatihan yang hemat biaya, DeepSeek-V3 mengadopsi arsitektur Multi-head Latent Attention (MLA) dan DeepSeekMoE, yang telah divalidasi secara menyeluruh pada DeepSeek-V2. 
Selain itu, DeepSeek-V3 menjadi pelopor strategi load balancing tanpa auxiliary-loss dan menetapkan tujuan pelatihan prediksi multi-token untuk performa yang lebih kuat. 
Kami melakukan pre-training DeepSeek-V3 pada 14,8 triliun token yang beragam dan berkualitas tinggi, diikuti tahap Fine-Tuning Terawasi dan Pembelajaran Penguatan untuk memaksimalkan kemampuannya. 
Evaluasi komprehensif mengungkapkan bahwa DeepSeek-V3 melampaui model open-source lain dan mencapai performa sebanding dengan model closed-source terdepan.
Terlepas dari performanya yang luar biasa, DeepSeek-V3 hanya membutuhkan 2,788M jam GPU H800 untuk pelatihan penuh.
Selain itu, proses pelatihannya sangat stabil. 
Sepanjang proses pelatihan, kami tidak mengalami lonjakan loss yang tidak dapat dipulihkan atau melakukan rollback apa pun.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Ringkasan Model

---

**Arsitektur: Strategi Load Balancing dan Tujuan Pelatihan Inovatif**

- Berdasarkan arsitektur efisien DeepSeek-V2, kami mempelopori strategi load balancing tanpa auxiliary-loss, yang meminimalkan degradasi performa akibat dorongan load balancing.
-  Kami meneliti tujuan Multi-Token Prediction (MTP) dan membuktikan manfaatnya bagi performa model. 
    MTP juga dapat digunakan untuk speculative decoding guna mempercepat inferensi.

---

**Pre-Training: Menuju Efisiensi Pelatihan Tertinggi**

- Kami merancang kerangka pelatihan presisi campuran FP8 dan, untuk pertama kalinya, memvalidasi kelayakan serta efektivitas pelatihan FP8 pada model berskala sangat besar.  
- Melalui co-design algoritma, kerangka, dan perangkat keras, kami mengatasi bottleneck komunikasi pada pelatihan MoE antar node, hampir mencapai overlap penuh antara komputasi dan komunikasi.  
  Hal ini secara signifikan meningkatkan efisiensi dan menurunkan biaya pelatihan, memungkinkan kami meningkatkan ukuran model tanpa overhead tambahan.
- Dengan biaya hanya 2,664M jam GPU H800, kami menyelesaikan pre-training DeepSeek-V3 pada 14,8T token, menghasilkan model basis open-source terkuat saat ini. Tahap pelatihan lanjutan setelah pre-training hanya membutuhkan 0,1M jam GPU.

---

**Post-Training: Distilasi Pengetahuan dari DeepSeek-R1**

-   Kami memperkenalkan metodologi inovatif untuk mendistilasi kemampuan penalaran dari model long-Chain-of-Thought (CoT), khususnya dari salah satu model DeepSeek R1 series, ke LLM standar, terutama DeepSeek-V3. Proses ini secara elegan mengintegrasikan pola verifikasi dan refleksi dari R1 ke DeepSeek-V3 dan secara signifikan meningkatkan performa penalaran. Sementara itu, kami juga tetap mengendalikan gaya dan panjang output DeepSeek-V3.

---


## 3. Unduh Model

<div align="center">

| **Model** | **#Total Params** | **#Activated Params** | **Context Length** | **Unduh** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Total ukuran model DeepSeek-V3 di Hugging Face adalah 685B, termasuk 671B bobot Main Model dan 14B bobot Modul Multi-Token Prediction (MTP).

Untuk memastikan performa optimal dan fleksibilitas, kami telah bermitra dengan komunitas open-source dan vendor perangkat keras untuk menyediakan berbagai cara menjalankan model ini secara lokal. Untuk panduan langkah demi langkah, silakan lihat Bagian 6: [Cara Menjalankan Secara Lokal](#6-cara-menjalankan-secara-lokal).

Untuk pengembang yang ingin mendalami, kami merekomendasikan untuk mengeksplorasi [README_WEIGHTS.md](./README_WEIGHTS.md) untuk detail tentang bobot Main Model dan Modul Multi-Token Prediction (MTP). Perlu dicatat bahwa dukungan MTP saat ini masih dalam pengembangan aktif di komunitas, dan kami menyambut kontribusi serta masukan Anda.

## 4. Hasil Evaluasi
### Model Basis
#### Benchmark Standar

<div align="center">

|  | Benchmark (Metrik) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Arsitektur | - | MoE | Dense | Dense | MoE |
| | # Activated Params | - | 21B | 72B | 405B | 37B |
| | # Total Params | - | 236B | 72B | 405B | 671B |
| Inggris | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Akurasi) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Akurasi) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Akurasi) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Akurasi) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Akurasi) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Akurasi) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Akurasi) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Akurasi) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Akurasi) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Akurasi) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Akurasi) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Kode | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Akurasi) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Akurasi) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Matematika | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Tionghoa | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Akurasi) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Akurasi) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Akurasi) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Akurasi) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multibahasa | MMMLU-non-English (Akurasi) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> Hasil terbaik dicetak tebal. Skor dengan selisih tidak lebih dari 0,3 dianggap setara. DeepSeek-V3 meraih performa terbaik pada sebagian besar benchmark, khususnya pada tugas matematika dan kode.
> Untuk detail evaluasi lebih lanjut, silakan cek makalah kami. 

#### Context Window
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Hasil evaluasi pada tes ``Needle In A Haystack`` (NIAH). DeepSeek-V3 tampil baik di semua panjang context window hingga **128K**.

### Model Chat
#### Benchmark Standar (Model lebih besar dari 67B)
<div align="center">

| | **Benchmark (Metrik)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Arsitektur | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Activated Params | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Total Params | 236B | 236B | 72B | 405B | - | - | 671B |
| Inggris | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Benar) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Akurasi) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Akurasi) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Kode | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Persentil) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Terselesaikan) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Akurasi) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Akurasi) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matematika | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Tionghoa | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Benar) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Semua model dievaluasi dengan konfigurasi yang membatasi panjang output hingga 8K. Benchmark dengan kurang dari 1000 sampel diuji beberapa kali menggunakan pengaturan suhu berbeda untuk memperoleh hasil yang kuat. DeepSeek-V3 adalah model open-source dengan performa terbaik, dan juga bersaing dengan model closed-source terdepan.

####  Evaluasi Open Ended Generation

<div align="center">

| Model | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> Evaluasi percakapan open-ended bahasa Inggris. Untuk AlpacaEval 2.0, digunakan metrik win rate dengan kontrol panjang output.

## 5. Situs Chat & Platform API
Anda dapat berinteraksi dengan DeepSeek-V3 di situs resmi DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Kami juga menyediakan API kompatibel OpenAI di Platform DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Cara Menjalankan Secara Lokal

DeepSeek-V3 dapat dideploy secara lokal menggunakan perangkat keras dan perangkat lunak komunitas open-source berikut:

1. **DeepSeek-Infer Demo**: Kami menyediakan demo sederhana dan ringan untuk inferensi FP8 dan BF16.
2. **SGLang**: Mendukung penuh model DeepSeek-V3 dalam mode inferensi BF16 dan FP8, dengan Multi-Token Prediction [segera hadir](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Memungkinkan inferensi FP8 dan BF16 yang efisien untuk deployment lokal maupun cloud.
4. **TensorRT-LLM**: Saat ini mendukung inferensi BF16 dan kuantisasi INT4/8, dengan dukungan FP8 segera hadir.
5. **vLLM**: Mendukung model DeepSeek-V3 dengan mode FP8 dan BF16 untuk tensor parallelism dan pipeline parallelism.
6. **LightLLM**: Mendukung deployment efisien single-node atau multi-node untuk FP8 dan BF16.
7. **AMD GPU**: Memungkinkan menjalankan model DeepSeek-V3 di GPU AMD melalui SGLang baik dalam mode BF16 maupun FP8.
8. **Huawei Ascend NPU**: Mendukung menjalankan DeepSeek-V3 di perangkat Huawei Ascend.

Karena pelatihan FP8 diadopsi secara native dalam kerangka kami, kami hanya menyediakan bobot FP8. Jika Anda membutuhkan bobot BF16 untuk eksperimen, Anda dapat menggunakan skrip konversi yang disediakan untuk melakukan transformasi.

Berikut contoh konversi bobot FP8 ke BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Transformers dari Hugging Face belum didukung secara langsung.

### 6.1 Inferensi dengan DeepSeek-Infer Demo (contoh saja)

#### Persyaratan Sistem

> [!NOTE] 
> Hanya Linux dengan Python 3.10. Mac dan Windows tidak didukung.

Dependensi:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Persiapan Bobot Model & Kode Demo

Pertama, kloning repositori GitHub DeepSeek-V3 kami:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Masuk ke folder `inference` dan instal dependensi di `requirements.txt`. Cara termudah adalah menggunakan package manager seperti `conda` atau `uv` untuk membuat environment virtual baru dan menginstal dependensi.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Unduh bobot model dari Hugging Face, dan tempatkan ke folder `/path/to/DeepSeek-V3`.

#### Konversi Bobot Model

Konversi bobot model Hugging Face ke format spesifik:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Jalankan

Setelah itu Anda dapat melakukan chat dengan DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Atau inferensi batch pada file tertentu:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferensi dengan SGLang (direkomendasikan)

[SGLang](https://github.com/sgl-project/sglang) saat ini mendukung [optimasi MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache, dan Torch Compile, memberikan latensi dan throughput terbaik di antara framework open-source.

Secara khusus, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) mendukung penuh DeepSeek-V3 baik di **GPU NVIDIA maupun AMD**, sehingga sangat fleksibel dan tangguh.

SGLang juga mendukung [tensor parallelism multi-node](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), memungkinkan Anda menjalankan model ini di banyak mesin yang terhubung jaringan.

Multi-Token Prediction (MTP) sedang dalam pengembangan, dan perkembangannya dapat diikuti di [rencana optimasi](https://github.com/sgl-project/sglang/issues/2591).

Berikut instruksi peluncuran dari tim SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferensi dengan LMDeploy (direkomendasikan)
[LMDeploy](https://github.com/InternLM/lmdeploy), framework inferensi dan serving yang fleksibel serta berperforma tinggi untuk model bahasa besar, kini mendukung DeepSeek-V3. Mendukung proses pipeline offline maupun deployment online, dan terintegrasi mulus dengan workflow berbasis PyTorch.

Untuk instruksi langkah demi langkah menjalankan DeepSeek-V3 dengan LMDeploy, silakan lihat di sini: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 Inferensi dengan TRT-LLM (direkomendasikan)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) kini mendukung model DeepSeek-V3, menawarkan opsi presisi seperti BF16 dan INT4/INT8 weight-only. Dukungan untuk FP8 sedang dalam pengembangan dan akan segera dirilis. Anda dapat mengakses branch khusus TRTLLM untuk DeepSeek-V3 melalui tautan berikut: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 


### 6.5 Inferensi dengan vLLM (direkomendasikan)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 mendukung inferensi DeepSeek-V3 untuk mode FP8 dan BF16 di GPU NVIDIA dan AMD. Selain teknik standar, vLLM menawarkan _pipeline parallelism_ sehingga Anda dapat menjalankan model ini di banyak mesin yang terhubung jaringan. Untuk panduan detail, silakan lihat [petunjuk vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Silakan ikuti [rencana pengembangan](https://github.com/vllm-project/vllm/issues/11539) juga.

### 6.6 Inferensi dengan LightLLM (direkomendasikan)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 mendukung deployment tensor parallel single-machine dan multi-machine untuk DeepSeek-R1 (FP8/BF16) serta deployment mixed-precision, dengan mode kuantisasi lain terus diintegrasikan. Untuk detail lebih lanjut, silakan lihat [petunjuk LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Selain itu, LightLLM menawarkan deployment PD-disaggregation untuk DeepSeek-V2, dan implementasi PD-disaggregation untuk DeepSeek-V3 sedang dikembangkan.

### 6.7 Fungsionalitas Inferensi Rekomendasi dengan GPU AMD

Bekerja sama dengan tim AMD, kami telah mencapai dukungan Day-One untuk GPU AMD dengan SGLang, dengan kompatibilitas penuh FP8 dan BF16. Untuk panduan lengkap, silakan lihat [petunjuk SGLang](#63-inference-with-lmdeploy-recommended).

### 6.8 Fungsionalitas Inferensi Rekomendasi dengan Huawei Ascend NPU
Kerangka [MindIE](https://www.hiascend.com/en/software/mindie) dari komunitas Huawei Ascend telah berhasil mengadaptasi versi BF16 dari DeepSeek-V3. Untuk panduan langkah demi langkah pada Ascend NPU, silakan ikuti [petunjuk di sini](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Lisensi
Repositori kode ini dilisensikan di bawah [Lisensi MIT](LICENSE-CODE). Penggunaan model DeepSeek-V3 Base/Chat tunduk pada [Lisensi Model](LICENSE-MODEL). DeepSeek-V3 series (termasuk Base dan Chat) mendukung penggunaan komersial.

## 8. Sitasi
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Kontak
Jika Anda memiliki pertanyaan, silakan ajukan issue atau hubungi kami di [service@deepseek.com](service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---