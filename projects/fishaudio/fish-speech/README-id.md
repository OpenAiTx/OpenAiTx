<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **Pemberitahuan Lisensi**  
> Kode sumber ini dirilis di bawah **Apache License** dan semua bobot model dirilis di bawah **CC-BY-NC-SA-4.0 License**. Silakan lihat [LICENSE](https://raw.githubusercontent.com/fishaudio/fish-speech/main/LICENSE) untuk detail lebih lanjut.

> [!WARNING]
> **Disclaimer Hukum**  
> Kami tidak bertanggung jawab atas penggunaan kode sumber ini untuk tujuan ilegal. Harap patuhi hukum lokal Anda terkait DMCA dan hukum terkait lainnya.

---

## 🎉 Pengumuman

Kami dengan bangga mengumumkan bahwa kami telah melakukan rebranding menjadi **OpenAudio** — memperkenalkan seri baru yang revolusioner dari model Text-to-Speech canggih yang dibangun di atas fondasi Fish-Speech.

Kami bangga merilis **OpenAudio-S1** sebagai model pertama dalam seri ini, menghadirkan peningkatan signifikan dalam kualitas, performa, dan kapabilitas.

OpenAudio-S1 tersedia dalam dua versi: **OpenAudio-S1** dan **OpenAudio-S1-mini**. Kedua model kini tersedia di [Fish Audio Playground](https://fish.audio) (untuk **OpenAudio-S1**) dan [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (untuk **OpenAudio-S1-mini**).

Kunjungi [situs web OpenAudio](https://openaudio.com/blogs/s1) untuk blog & laporan teknis.

## Sorotan ✨

### **Kualitas TTS Luar Biasa**

Kami menggunakan Seed TTS Eval Metrics untuk mengevaluasi performa model, dan hasilnya menunjukkan bahwa OpenAudio S1 mencapai **0.008 WER** dan **0.004 CER** pada teks bahasa Inggris, yang jauh lebih baik daripada model sebelumnya. (Bahasa Inggris, evaluasi otomatis, berbasis OpenAI gpt-4o-transcribe, jarak pembicara menggunakan Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Model | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Model Terbaik di TTS-Arena2** 🏆

OpenAudio S1 telah meraih **peringkat #1** di [TTS-Arena2](https://arena.speechcolab.org/), tolok ukur untuk evaluasi text-to-speech:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Kontrol Ucapan**

OpenAudio S1 **mendukung berbagai emosi, nada, dan penanda khusus** untuk meningkatkan sintesis suara:

- **Emosi dasar**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Emosi lanjutan**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Penanda nada**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Efek audio khusus**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Anda juga dapat menggunakan Ha,ha,ha untuk mengontrol, masih banyak kasus lain yang dapat Anda eksplorasi sendiri.

(Saat ini mendukung bahasa Inggris, Tionghoa, dan Jepang, dan dukungan bahasa lain akan segera hadir!)

### **Dua Tipe Model**

| Model | Ukuran | Ketersediaan | Fitur |
|-------|--------|--------------|-------|
| **S1** | 4B parameter | Tersedia di [fish.audio](https://fish.audio) | Model flagship dengan fitur lengkap |
| **S1-mini** | 0.5B parameter | Tersedia di huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Versi distilled dengan kapabilitas inti |

Baik S1 maupun S1-mini menggabungkan Reinforcement Learning from Human Feedback (RLHF) secara online.

## **Fitur**

1. **Zero-shot & Few-shot TTS:** Masukkan sampel vokal berdurasi 10 hingga 30 detik untuk menghasilkan output TTS berkualitas tinggi. **Untuk panduan detail, lihat [Praktik Terbaik Voice Cloning](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Dukungan Multibahasa & Cross-lingual:** Cukup salin dan tempel teks multibahasa ke kotak input—tidak perlu khawatir soal bahasa. Saat ini mendukung Bahasa Inggris, Jepang, Korea, Tionghoa, Prancis, Jerman, Arab, dan Spanyol.

3. **Tanpa Ketergantungan Fonem:** Model memiliki kemampuan generalisasi yang kuat dan tidak bergantung pada fonem untuk TTS. Dapat menangani teks dalam skrip bahasa apa pun.

4. **Sangat Akurat:** Mencapai CER (Character Error Rate) rendah sekitar 0,4% dan WER (Word Error Rate) sekitar 0,8% untuk Seed-TTS Eval.

5. **Cepat:** Dengan akselerasi fish-tech, faktor waktu nyata sekitar 1:5 pada laptop Nvidia RTX 4060 dan 1:15 pada Nvidia RTX 4090.

6. **WebUI Inference:** Memiliki antarmuka web berbasis Gradio yang mudah digunakan dan kompatibel dengan Chrome, Firefox, Edge, dan browser lainnya.

7. **GUI Inference:** Menawarkan antarmuka grafis PyQt6 yang berjalan mulus dengan server API. Mendukung Linux, Windows, dan macOS. [Lihat GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Deploy-Friendly:** Mudah menyiapkan inference server dengan dukungan native untuk Linux, Windows (MacOS segera hadir), meminimalkan kehilangan kecepatan.

## **Media & Demo**

<div align="center">

### **Media Sosial**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Demo Interaktif**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Video Showcase**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Contoh Audio**
<div style="margin: 20px 0;">
    <em> Sampel audio berkualitas tinggi akan segera tersedia, menampilkan kemampuan TTS multibahasa kami dalam berbagai bahasa dan emosi.</em>
</div>

</div>

---

## Dokumen

- [Membangun Lingkungan](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inferensi](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Kredit

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Laporan Teknis (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---