# 🎶 ThinkSound

<p align="center">
  Jika Anda merasa proyek ini bermanfaat, mohon berikan bintang ⭐ di GitHub!
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

---

**ThinkSound** adalah kerangka kerja generasi Any2Audio yang terintegrasi dengan flow matching yang dipandu oleh penalaran Chain-of-Thought (CoT).

Implementasi PyTorch untuk generasi dan pengeditan audio multimodal: menghasilkan atau mengedit audio dari video, teks, dan audio, didukung oleh penalaran langkah demi langkah dari Multimodal Large Language Models (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Berita
- **2025.07** &nbsp; 🔥Demo daring tersedia di [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) dan [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) untuk pengalaman interaktif!
- **2025.07** &nbsp; 🔥Skrip inferensi dan antarmuka web telah dirilis;
- **2025.06** &nbsp; 🔥[Makalah ThinkSound](https://arxiv.org/pdf/2506.21448) diterbitkan di arXiv!
- **2025.06** &nbsp; 🔥[Demo Online](http://thinksound-project.github.io/) telah tersedia - coba sekarang!

---

## 🚀 Fitur

- **Any2Audio**: Menghasilkan audio dari berbagai modalitas — video, teks, audio, atau kombinasi dari semuanya.
- **Video-to-Audio SOTA**: Mencapai hasil terbaik pada berbagai tolok ukur V2A.
- **Penalaran Berbasis CoT**: Penalaran Chain-of-Thought untuk generasi audio yang komposisional dan dapat dikontrol melalui MLLMs.
- **Pengeditan Interaktif Berbasis Objek**: Memperbaiki atau mengedit peristiwa suara tertentu dengan mengklik objek visual atau menggunakan instruksi teks.
- **Kerangka Kerja Terpadu**: Satu model dasar mendukung generasi, pengeditan, dan alur kerja interaktif.

---

## ✨ Gambaran Metode

ThinkSound membagi proses generasi dan pengeditan audio menjadi tiga tahap interaktif, semuanya dipandu oleh penalaran Chain-of-Thought (CoT) berbasis MLLM:

1. **Foley Generation:** Menghasilkan lanskap suara dasar yang selaras secara semantik dan temporal dari video.
2. **Refinement Berbasis Objek:** Memperbaiki atau menambahkan suara untuk objek yang ditentukan pengguna melalui klik atau area tertentu dalam video.
3. **Pengeditan Audio Terarah:** Memodifikasi audio yang dihasilkan menggunakan instruksi bahasa alami tingkat tinggi.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Dataset berskala besar yang dianotasi CoT (**AudioCoT**) digunakan untuk melatih modul penalaran dan model fondasi audio terpadu.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Mulai Cepat

**Persiapan Lingkungan:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Unduh bobot pralatih https://huggingface.co/liuhuadai/ThinkSound ke direktori ckpts/
# bobot model juga dapat diunduh dari https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Jadikan dapat dieksekusi**
```bash
chmod +x scripts/demo.sh
```

**Jalankan skrip**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Penggunaan Antarmuka Web

Untuk pengalaman interaktif, jalankan antarmuka web Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ Rilis skrip pelatihan untuk model ThinkSound
- ☐ Sumber terbuka dataset AudioCoT dan pipeline otomatis
- ☐ Sediakan dokumentasi dan referensi API yang detail
- ☐ Tambahkan dukungan untuk modalitas tambahan dan tugas lanjutan

---

## 📄 Lisensi

Proyek ini dirilis di bawah [Lisensi Apache 2.0](LICENSE).

> **Catatan:**  
> Kode, model, dan dataset ini **hanya untuk tujuan penelitian dan edukasi**.  
> **Penggunaan komersial TIDAK diizinkan.**
>
> Untuk lisensi komersial, silakan hubungi penulis.

---

## 📖 Sitasi

Jika Anda merasa ThinkSound bermanfaat untuk penelitian atau pekerjaan Anda, silakan sitasi paper kami:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao dan Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Kontak

✨ Jangan ragu untuk [membuka isu](https://github.com/liuhuadai/ThinkSound/issues) atau hubungi kami melalui email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) jika Anda memiliki pertanyaan atau saran!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---