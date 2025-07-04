![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim adalah kerangka kerja simulasi dari AgiBot, yang menyediakan kemampuan generasi data yang efisien dan tolok ukur evaluasi untuk mempercepat pengembangan kecerdasan berwujud. Genie Sim telah membangun pipeline loop tertutup yang komprehensif, mencakup pembuatan trajektori, pelatihan model, benchmarking, dan validasi deployment. Pengguna dapat dengan cepat memvalidasi performa algoritma dan mengoptimalkan model melalui rangkaian alat simulasi yang efisien ini. Baik untuk tugas pegangan sederhana maupun operasi kompleks jangka panjang, Genie Sim dapat menyediakan lingkungan simulasi yang sangat realistis dan metrik evaluasi yang presisi, memberdayakan pengembang untuk menyelesaikan pengembangan dan iterasi teknologi robotika secara efisien.

Genie Sim Benchmark, sebagai versi evaluasi open-source dari Genie Sim, didedikasikan untuk memberikan pengujian performa yang presisi dan dukungan optimasi untuk model AI berwujud.

# 2. Fitur
- Konfigurasi simulasi yang fleksibel dan antarmuka yang ramah pengguna
- Tolok ukur simulasi dan tugas evaluasi untuk lebih dari 10 tugas manipulasi
- Kemampuan teleoperasi berbasis VR dan keyboard
- Rekam dan main ulang semua posisi joint dan end effector
- 550+ lingkungan simulasi dan aset 3D dengan fidelitas tinggi dan akurasi fisik
- Metrik evaluasi terstandarisasi untuk mengukur performa model AI berwujud
- Hasil evaluasi mencapai kurang dari 5% error evaluasi sim to real pada model GO-1
- Mendukung model baseline UniVLA dalam evaluasi simulasi

# 3. Pembaruan
- [25/6/2025] v2.1
  - Menambahkan 10 tugas manipulasi untuk Agibot World Challenge 2025 termasuk semua aset simulasi
  - Open-source dataset sintetis untuk 10 tugas manipulasi di Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Integrasi kebijakan UniVLA dan mendukung evaluasi simulasi inferensi model
  - Pembaruan SDK IK solver yang mendukung pemecahan IK lintas-embodiment untuk robot lain
  - Optimasi kerangka komunikasi dan meningkatkan kecepatan simulasi hingga 2x
  - Pembaruan kerangka evaluasi otomatis untuk tugas jangka panjang yang lebih rumit

# 4. Daftar Isi

## 4.1 Pengantar
Tolok ukur simulasi kecerdasan berwujud di Genie Sim dirancang untuk mengevaluasi dan memajukan pengembangan model AI berwujud. Tolok ukur ini menyediakan lingkungan realistis, ragam tugas, dan metrik terstandarisasi untuk mengukur performa sistem AI robotik, yang mengurangi kebutuhan perangkat keras fisik yang mahal dan pengujian dunia nyata, menghindari skenario pengujian yang berisiko dan berbahaya, serta mempercepat proses pelatihan dan evaluasi agen AI.

## 4.2 Memulai
Silakan merujuk ke [halaman ini](https://agibot-world.com/sim-evaluation/docs/#/v2) untuk instalasi, panduan pengguna, dan referensi API

## 4.3 Dukungan
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Daftar TODO
- [x] Merilis lebih banyak tugas manipulasi benchmark jangka panjang
- [x] Lebih banyak skenario dan aset untuk setiap tugas benchmark
- [x] Mendukung model baseline Agibot World Challenge
- [ ] Toolkit generalisasi layout skenario dan trajektori manipulasi

## 4.5 FAQ
- Bagaimana cara mematikan server isaac sim ketika terjadi error sehingga proses tidak merespons?
  Bunuh proses di terminal menggunakan `pkill -9 -f raise_standalone_sim`
- Bagaimana cara memilih mode render yang berbeda?
  Mode render default adalah `RaytracedLighting(RealTime)`. Untuk tugas yang berisi objek transparan, gunakan `RealTimePathTracing(RealTime-2.0)` untuk hubungan perspektif objek

## 4.6 Lisensi dan Sitasi
Seluruh data dan kode dalam repo ini berada di bawah Mozilla Public License 2.0
Mohon pertimbangkan untuk mengutip karya kami dengan salah satu cara di bawah ini jika membantu penelitian Anda.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Referensi
1. PDDL Parser (2020). Versi 1.1. [Kode sumber]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Versi 1.x.x [Kode sumber]. https://github.com/StanfordVL/bddl
3. CUROBO [Kode sumber]. https://github.com/NVlabs/curobo
4. Isaac Lab [Kode sumber]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Kode sumber]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---