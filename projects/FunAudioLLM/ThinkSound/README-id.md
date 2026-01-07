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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
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
  memberikan bintang ⭐ di GitHub akan sangat dihargai!
</p>

---

**ThinkSound** adalah kerangka kerja generasi Any2Audio terpadu dengan pencocokan alur yang dipandu oleh penalaran Chain-of-Thought (CoT).

Implementasi PyTorch untuk pembuatan dan pengeditan audio multimodal: menghasilkan atau mengedit audio dari video, teks, dan audio, didukung oleh penalaran bertahap dari Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Berita
- **2025.11.25** &nbsp; 🔥[Demo PrismAudio Online](http://prismaudio-project.github.io/) telah aktif - coba sekarang!
- **2025.11.25** &nbsp; 🔥[Makalah PrismAudio](https://arxiv.org/pdf/2511.18833) dirilis di arXiv, kerangka kerja CoT-RL multi-dimensi pertama untuk Video-to-Audio Generation!
- **2025.09.19** &nbsp; 🎉 ThinkSound diterima di **Konferensi Utama NeurIPS 2025**!
- **2025.09.01** &nbsp; Dataset AudioCoT kami kini open-source dan tersedia di [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Finetuning diaktifkan: kode pelatihan dan finetuning kini tersedia secara publik, beserta instruksi penggunaan yang jelas untuk membantu Anda menyesuaikan dan memperluas ThinkSound dengan data Anda sendiri.
- **2025.07.15** &nbsp; 📦 Instalasi dan kemudahan penggunaan yang disederhanakan: dependensi tersedia di PyPI untuk setup lintas platform yang mudah; script Windows `.bat` otomatisasi pembuatan environment dan menjalankan script.
- **2025.07.08** &nbsp;  🔧 Pembaruan besar: model menjadi lebih ringan dan memori serta penggunaan GPU dioptimalkan, kini mendukung pembuatan audio berkapasitas tinggi!
- **2025.07.01** &nbsp; Demo online di [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) dan [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) untuk pengalaman interaktif!
- **2025.07.01** &nbsp; Skrip inferensi dan antarmuka web dirilis;
- **2025.06** &nbsp; [Makalah ThinkSound](https://arxiv.org/pdf/2506.21448) dirilis di arXiv!
- **2025.06** &nbsp; [Demo Online](http://thinksound-project.github.io/) telah aktif - coba sekarang!

---


## 🚀 Fitur

- **Any2Audio**: Hasilkan audio dari berbagai modalitas — video, teks, audio, atau kombinasinya.
- **Video-to-Audio SOTA**: Mencapai hasil mutakhir pada berbagai benchmark V2A.
- **Penalaran Berbasis CoT**: Penalaran Chain-of-Thought untuk pembuatan audio komposisional dan terkontrol melalui MLLMs.
- **Pengeditan Interaktif Berbasis Objek**: Perbaiki atau edit kejadian suara spesifik dengan mengklik objek visual atau menggunakan instruksi teks.
- **Kerangka Kerja Terpadu**: Satu model dasar mendukung generasi, editing, dan alur kerja interaktif.

---

## ✨ Ikhtisar Metode

ThinkSound membagi proses pembuatan dan pengeditan audio ke dalam tiga tahap interaktif, semuanya dipandu oleh penalaran Chain-of-Thought (CoT) berbasis MLLM:

1. **Foley Generation:** Menghasilkan soundscape dasar yang selaras secara semantik dan temporal dari video.
2. **Object-Centric Refinement:** Memperbaiki atau menambahkan suara untuk objek yang ditentukan pengguna melalui klik atau area pada video.
3. **Targeted Audio Editing:** Mengubah audio yang dihasilkan menggunakan instruksi bahasa alami tingkat tinggi.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Dataset beranotasi CoT skala besar (**AudioCoT**) digunakan untuk melatih modul penalaran dan model fondasi audio terpadu.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Mulai Cepat

**Persiapan Lingkungan:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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


## 🏋️ Latih Model

Lihat [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & Rencana Masa Depan
* - [ ] Merilis model fondasi yang lebih kuat yang mencakup beberapa domain untuk memberikan kreasi foley yang lebih menarik dan imersif
* - [ ] Menambahkan dukungan untuk modalitas tambahan dan tugas hilir
* - [ ] Merilis model dalam berbagai skala
* - [x] Open-source dataset AudioCoT dan pipeline otomatis
* - [x] Merilis skrip pelatihan untuk model ThinkSound
* - [x] README Windows quick-start yang ramah pemula
---


## 📄 Lisensi

Proyek ini dirilis di bawah Lisensi Apache 2.0.

> **Catatan:**
> Kode, model, dan dataset **hanya untuk tujuan riset dan edukasi**.
> **Penggunaan komersial TIDAK diizinkan.**
> Untuk lisensi komersial, silakan hubungi penulis.

**📦 Komponen Pihak Ketiga**

* **Stable Audio Open VAE** (oleh Stability AI):
  Repository ini menyertakan VAE yang telah di-finetune dari [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), berlisensi di bawah [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Penggunaan dan redistribusi komersial memerlukan izin terlebih dahulu dari Stability AI.**

* 📘 **Seluruh kode dan model lainnya** dirilis di bawah Lisensi Apache 2.0.

---

## Ucapan Terima Kasih

Terima kasih banyak kepada:

* **stable-audio-tools** (oleh Stability AI):
Untuk menyediakan kerangka kerja yang mudah digunakan untuk generasi audio, serta modul VAE dan bobotnya.
* **MMAudio**:
  Untuk implementasi backbone MM-DiT di domain audio.

---

## 📖 Sitasi

Jika Anda merasa ThinkSound berguna dalam penelitian atau pekerjaan Anda, silakan sitasi makalah kami:

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---