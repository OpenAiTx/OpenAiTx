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
  berikan bintang ⭐ di GitHub akan sangat dihargai!
</p>

---

**ThinkSound** adalah kerangka kerja generasi Any2Audio yang terintegrasi dengan pencocokan alur yang dipandu oleh penalaran Chain-of-Thought (CoT).

Implementasi PyTorch untuk generasi dan pengeditan audio multimodal: menghasilkan atau mengedit audio dari video, teks, dan audio, didukung oleh penalaran langkah-demi-langkah dari Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Berita
- **2025.07.15** &nbsp; 📦 Instalasi dan kegunaan yang disederhanakan: dependensi di PyPI untuk pengaturan lintas platform yang mudah; skrip Windows `.bat` mengotomatisasi pembuatan environment dan menjalankan skrip.
- **2025.07.08** &nbsp;  🔧 Pembaruan besar: model lebih ringan dan penggunaan memori serta GPU dioptimalkan, kini mendukung generasi audio throughput tinggi dalam skala besar!
- **2025.07.01** &nbsp; 🔥Demo daring di [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) dan [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) untuk pengalaman interaktif!
- **2025.07.01** &nbsp; 🔥Script inferensi dan antarmuka web telah dirilis; 
- **2025.06** &nbsp; 🔥[Makalah ThinkSound](https://arxiv.org/pdf/2506.21448) dirilis di arXiv!
- **2025.06** &nbsp; 🔥[Demo Daring](http://thinksound-project.github.io/) telah tayang - coba sekarang!

---


## 🚀 Fitur

- **Any2Audio**: Hasilkan audio dari berbagai modalitas — video, teks, audio, atau kombinasinya.
- **Video-to-Audio SOTA**: Mencapai hasil terbaik pada beberapa tolok ukur V2A.
- **Penalaran Berbasis CoT**: Penalaran Chain-of-Thought untuk generasi audio komposisional dan terkontrol melalui MLLMs.
- **Pengeditan Interaktif Berbasis Objek**: Memperbaiki atau mengedit kejadian suara tertentu dengan mengklik objek visual atau menggunakan instruksi teks.
- **Kerangka Kerja Terpadu**: Satu model fondasi mendukung generasi, pengeditan, dan alur kerja interaktif.

---

## ✨ Gambaran Metode

ThinkSound membagi proses generasi dan pengeditan audio menjadi tiga tahap interaktif, semuanya dipandu oleh penalaran Chain-of-Thought (CoT) berbasis MLLM:

1. **Generasi Foley:** Menghasilkan soundscape dasar yang selaras secara semantik dan temporal dari video.
2. **Refinemen Berbasis Objek:** Memperbaiki atau menambahkan suara untuk objek yang ditentukan pengguna melalui klik atau wilayah di video.
3. **Pengeditan Audio Terarah:** Mengubah audio yang dihasilkan menggunakan instruksi bahasa alami tingkat tinggi.

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
---

## 📝 TODO & Rencana Masa Depan
* - [ ] Merilis skrip pelatihan untuk model ThinkSound (Diharapkan sebelum 20/07/2025)
* - [ ] Membuka sumber dataset AudioCoT dan pipeline otomatis (Diharapkan sebelum 23/07/2025)
* - [ ] Menyediakan image lingkungan siap pakai (Diharapkan sebelum 23/07/2025)
* - [ ] Merilis model fondasi yang lebih kuat yang mencakup berbagai domain untuk menyediakan pembuatan foley yang lebih menarik dan imersif (Diharapkan pada akhir Agustus 2025)
* - [ ] Menambahkan dukungan untuk modalitas tambahan dan tugas-tugas hilir (Diharapkan sebelum akhir Juli 2025)
* - [ ] Merilis model dalam berbagai skala (Diharapkan sebelum akhir Juli 2025)
* - [x] README Windows pemula yang mudah digunakan
---


## 📄 Lisensi

Proyek ini dirilis di bawah Lisensi Apache 2.0.

> **Catatan:**
> Kode, model, dan dataset ini **hanya untuk keperluan penelitian dan pendidikan**.
> **Penggunaan komersial TIDAK diizinkan.**
> Untuk lisensi komersial, silakan hubungi penulis.

**📦 Komponen Pihak Ketiga**

* **Stable Audio Open VAE** (oleh Stability AI):
  Repositori ini menyertakan VAE yang telah di-fine-tune dari [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), berlisensi di bawah [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Penggunaan komersial dan redistribusi memerlukan izin sebelumnya dari Stability AI.**

* 📘 **Semua kode dan model lainnya** dirilis di bawah Lisensi Apache 2.0.

---

## Ucapan Terima Kasih

Terima kasih banyak kepada:

* **stable-audio-tools** (oleh Stability AI):
Atas penyediaan framework yang mudah digunakan untuk generasi audio, serta modul VAE dan bobotnya.
* **MMAudio**:
  Untuk implementasi backbone MM-DiT di domain audio.

---

## 📖 Sitasi

Jika Anda merasa ThinkSound bermanfaat dalam penelitian atau pekerjaan Anda, silakan kutip makalah kami:


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

## 📬 Kontak

✨ Jangan ragu untuk [membuka sebuah issue](https://github.com/liuhuadai/ThinkSound/issues) atau hubungi kami melalui email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) jika Anda memiliki pertanyaan atau saran!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---