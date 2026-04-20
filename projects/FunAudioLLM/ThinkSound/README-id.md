<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Demo Online"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Jika Anda merasa proyek ini bermanfaat,<br>
  mohon berikan bintang ⭐ di GitHub!
</p>

---

## Tata letak repositori

Repositori **ThinkSound** di GitHub ini menyimpan dua proyek terkait pada cabang yang terpisah:

| Cabang | Proyek | Dokumentasi |
|--------|--------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — generasi Any2Audio terpadu dengan flow matching berpandu CoT | File ini: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — pekerjaan lanjutan (ICLR 2026) pada video-ke-audio dengan CoT-RL multi-dimensi | **`README.md`** pada cabang [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Untuk **ThinkSound**, gunakan cabang **`master`** (README ini). Untuk **PrismAudio**, checkout **`prismaudio`** dan ikuti **`README.md`** di sana.

---

**ThinkSound** adalah kerangka generasi Any2Audio terpadu dengan flow matching berpandu Chain-of-Thought (CoT) reasoning.

Implementasi PyTorch untuk generasi dan pengeditan audio multimodal: menghasilkan atau mengedit audio dari video, teks, dan audio, didukung oleh reasoning bertahap dari Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Berita
- **2026.03.24** &nbsp; 🔥 **PrismAudio** dirilis di repo yang sama pada cabang [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — lihat **`README.md`** di sana untuk pengaturan dan model.
- **2026.01.26** &nbsp; 🎉 PrismAudio diterima di **Konferensi Utama ICLR 2026** (kode/dokumen di `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [Demo PrismAudio Online](http://prismaudio-project.github.io/) sudah aktif.
- **2025.11.25** &nbsp; 🔥 [Makalah PrismAudio](https://arxiv.org/pdf/2511.18833) di arXiv — CoT-RL multi-dimensi untuk video-ke-audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** diterima di **Konferensi Utama NeurIPS 2025**!
- **2025.09.01** &nbsp; Dataset AudioCoT kami kini open-source dan tersedia di [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Finetuning diaktifkan: kode pelatihan dan finetuning kini tersedia publik, lengkap dengan instruksi penggunaan jelas untuk membantu Anda menyesuaikan dan memperluas ThinkSound dengan data sendiri.
- **2025.07.15** &nbsp; 📦 Instalasi dan kemudahan penggunaan disederhanakan: dependensi di PyPI untuk setup lintas platform yang mudah; skrip Windows `.bat` mengotomasi pembuatan environment dan menjalankan skrip.
- **2025.07.08** &nbsp;  🔧 Update besar: model lebih ringan dan optimalisasi penggunaan memori dan GPU, kini mendukung generasi audio throughput tinggi secara skala besar!
- **2025.07.01** &nbsp; Demo online di [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) dan [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) untuk pengalaman interaktif!
- **2025.07.01** &nbsp; Rilis skrip inferensi dan antarmuka web;
- **2025.06** &nbsp; [Makalah ThinkSound](https://arxiv.org/pdf/2506.21448) dirilis di arXiv!
- **2025.06** &nbsp; [Demo Online](http://thinksound-project.github.io/) sudah aktif - coba sekarang!

---


<div align="center">

### Lanjutan: PrismAudio (repo yang sama, cabang `prismaudio`)

**PrismAudio** adalah penerus ThinkSound (ICLR 2026), dikembangkan dengan nama baru namun tetap disimpan di repositori ini pada branch **`prismaudio`**. Instalasi, checkpoint, dan sitasi tersedia di **[`README.md` pada branch tersebut](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) atau buka branch tersebut di GitHub.

</div>

---


## 🚀 Fitur

- **Any2Audio**: Hasilkan audio dari berbagai modalitas — video, teks, audio, atau kombinasi keduanya.
- **Video-to-Audio SOTA**: Mencapai hasil terbaik pada berbagai tolok ukur V2A.
- **CoT-Driven Reasoning**: Penalaran Chain-of-Thought untuk generasi audio komposisional dan dapat dikontrol melalui MLLM.
- **Interactive Object-centric Editing**: Perbaiki atau edit kejadian suara tertentu dengan mengklik objek visual atau menggunakan instruksi teks.
- **Unified Framework**: Satu model dasar mendukung generasi, pengeditan, dan alur kerja interaktif.

---

## ✨ Ikhtisar Metode

ThinkSound membagi proses generasi dan pengeditan audio menjadi tiga tahap interaktif, semuanya dipandu oleh penalaran Chain-of-Thought (CoT) berbasis MLLM:

1. **Foley Generation:** Menghasilkan lanskap suara dasar yang selaras secara semantik dan temporal dari video.
2. **Object-Centric Refinement:** Memperbaiki atau menambah suara untuk objek yang ditentukan pengguna melalui klik atau area di video.
3. **Targeted Audio Editing:** Memodifikasi audio yang dihasilkan menggunakan instruksi bahasa alami tingkat tinggi.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Dataset berskala besar beranotasi CoT (**AudioCoT**) digunakan untuk melatih modul penalaran dan model dasar audio terpadu.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Mulai Cepat

**Persiapan Lingkungan:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Tips Windows:**  
> Pengguna Windows dapat langsung menjalankan `setup_windows.bat` (atau klik dua kali) untuk secara otomatis membuat environment conda, menginstal semua dependensi (termasuk FFmpeg), dan mengunduh model pra-latih — tanpa perlu pengaturan manual.  
> Pastikan `conda` dan `git` sudah terinstal dan tersedia di PATH sistem Anda sebelum menjalankan skrip.


### ▶️ Jalankan Demo

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Anda dapat menggunakan skrip `.bat` yang disediakan sebagai gantinya:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Catatan:**

* `<path-to-your-demo-video>`: Jalur ke satu video
* `[use-half]` (opsional): Tambahkan use-half di akhir untuk mengaktifkan ekstraksi fitur presisi setengah.

---

### 📦 Inferensi Batch

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Gunakan skrip `.bat` yang setara:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Catatan:**

* `<video_path>`: Jalur ke direktori root yang berisi semua video .mp4 yang akan diproses (semua video harus berdurasi sama).
* `<csv_path>`: File CSV dengan prompt teks untuk setiap video (lihat `demo_test.csv` untuk formatnya).
* `<save_path>` (opsional): Tempat untuk menyimpan audio yang dihasilkan. Default ke `results/features`.
* `[use-half]` (opsional): Tambahkan use-half di akhir untuk mengaktifkan ekstraksi fitur presisi setengah.

---


### Penggunaan Antarmuka Web

Untuk pengalaman interaktif, jalankan antarmuka web Gradio:


```bash
python app.py
```
## 🏋️ Melatih Model

Lihat [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Lisensi

Proyek ini dirilis di bawah Lisensi Apache 2.0.

> **Catatan:**
> Kode, model, dan dataset ini **hanya untuk tujuan penelitian dan pendidikan**.
> **Penggunaan komersial TIDAK diperbolehkan.**
> Untuk lisensi komersial, silakan hubungi penulis.

**📦 Komponen Pihak Ketiga**

* **Stable Audio Open VAE** (oleh Stability AI):
  Repositori ini menyertakan VAE yang telah di-fine-tune dari [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), berlisensi di bawah [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Penggunaan dan redistribusi komersial memerlukan izin sebelumnya dari Stability AI.**

* 📘 **Semua kode dan model lainnya** dirilis di bawah Lisensi Apache 2.0.

---

## Penghargaan

Terima kasih banyak kepada:

* **stable-audio-tools** (oleh Stability AI):
Telah menyediakan kerangka kerja yang mudah digunakan untuk generasi audio, serta modul VAE dan bobotnya.
* **MMAudio**:
  Untuk implementasi backbone MM-DiT di domain audio.

---



## 📖 Sitasi

Jika Anda merasa proyek kami bermanfaat untuk penelitian atau pekerjaan Anda, mohon sitasi makalah kami:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---