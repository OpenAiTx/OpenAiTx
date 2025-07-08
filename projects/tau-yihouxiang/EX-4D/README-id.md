# EX-4D: Sintesis Video 4D Sudut Pandang Ekstrem melalui Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Paper](https://arxiv.org/abs/2506.05554)  |  [🎥 Homepage](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Code](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Sorotan

- **🎯 Sintesis Sudut Pandang Ekstrem**: Menghasilkan video 4D berkualitas tinggi dengan pergerakan kamera dari -90° hingga 90°
- **🔧 Depth Watertight Mesh**: Representasi geometrik baru yang memodelkan area terlihat dan tersembunyi
- **⚡ Arsitektur Ringan**: Hanya 1% parameter yang dapat dilatih (140M) dari backbone difusi video 14B
- **🎭 Tanpa Pelatihan Multi-view**: Strategi masking inovatif menghilangkan kebutuhan dataset multi-view yang mahal
- **🏆 Performa Terkini**: Mengungguli metode yang ada, terutama pada sudut kamera ekstrem

## 🎬 Hasil Demo

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D mengubah video monokular menjadi pengalaman 4D yang dapat dikontrol kamera dengan hasil yang konsisten secara fisik pada sudut pandang ekstrem.*

## 🏗️ Gambaran Framework

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Framework kami terdiri dari tiga komponen utama:

1. **🔺 Konstruksi Depth Watertight Mesh**: Membuat prior geometrik yang kuat yang secara eksplisit memodelkan area terlihat dan tersembunyi
2. **🎭 Strategi Masking Simulasi**: Menghasilkan data pelatihan efektif dari video monokular tanpa dataset multi-view
3. **⚙️ Adapter LoRA Ringan**: Mengintegrasikan informasi geometrik secara efisien dengan model difusi video yang sudah dilatih

## 🚀 Mulai Cepat

### Instalasi

```bash
# Clone repository
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Buat environment conda
conda create -n ex4d python=3.10
conda activate ex4d
# Instal PyTorch (disarankan versi 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Instal Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Instal dependencies dan diffsynth
pip install -e .
# Instal depthcrafter untuk estimasi kedalaman. (Ikuti instruksi instalasi DepthCrafter untuk persiapan checkpoint.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Unduh Model Pra-latih
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Contoh Penggunaan
#### 1. Rekonstruksi DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Generasi EX-4D (diperlukan VRAM 48GB)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Input Video</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Output Video</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Metode | FID (Extreme) ↓ | FVD (Extreme) ↓ | Skor VBench ↑ |
|--------|-----------------|-----------------|---------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Ours)** | **55.42** | **823.61** | **0.450** | -->

### Hasil Studi Pengguna

- **70,7%** partisipan lebih memilih EX-4D dibandingkan metode baseline
- Performa unggul dalam konsistensi fisik dan kualitas sudut pandang ekstrem
- Peningkatan signifikan saat sudut kamera semakin ekstrem


## 🎯 Aplikasi

- **🎮 Gaming**: Membuat sinematik game 3D yang imersif dari rekaman 2D
- **🎬 Produksi Film**: Menghasilkan sudut kamera baru untuk pascaproduksi
- **🥽 VR/AR**: Membuat pengalaman video dengan sudut pandang bebas
- **📱 Media Sosial**: Menghasilkan gerakan kamera dinamis untuk pembuatan konten
- **🏢 Arsitektur**: Visualisasi ruang dari berbagai sudut pandang

<!-- ## 📈 Benchmark -->

<!-- ### Evaluasi Rentang Sudut Pandang

| Rentang | Kecil (0°→30°) | Besar (0°→60°) | Ekstrem (0°→90°) | Penuh (-90°→90°) |
|---------|----------------|----------------|------------------|------------------|
| Skor FID | 44.19 | 50.30 | 55.42 | - |
| Selisih Performa | +9,1% lebih baik | +8,9% lebih baik | +11,3% lebih baik | +15,5% lebih baik | -->

<!-- *Selisih performa dibandingkan metode terbaik kedua pada setiap kategori.* -->

## ⚠️ Keterbatasan

- **Ketergantungan Depth**: Performa bergantung pada kualitas estimasi kedalaman monokular
- **Biaya Komputasi**: Membutuhkan komputasi signifikan untuk video resolusi tinggi
- **Permukaan Reflektif**: Tantangan pada material reflektif atau transparan

## 🔮 Pekerjaan Mendatang
- [ ] Optimasi inferensi real-time (3DGS / 4DGS)
- [ ] Dukungan untuk resolusi lebih tinggi (1K, 2K)
- [ ] Teknik penyempurnaan mesh neural

## 🙏 Ucapan Terima Kasih

Kami mengucapkan terima kasih kepada proyek [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) atas penyediaan kerangka kerja difusi dasar.

## 📚 Sitasi

Jika Anda merasa pekerjaan kami bermanfaat, mohon pertimbangkan untuk mengutip:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---