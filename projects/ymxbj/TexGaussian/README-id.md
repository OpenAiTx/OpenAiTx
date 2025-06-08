<h1 align="center">TexGaussian: Menghasilkan Material PBR Berkualitas Tinggi melalui Octree-based 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Material Physically Based Rendering (PBR) memainkan peran penting dalam grafik modern, memungkinkan rendering fotorealistik di berbagai environment map. Mengembangkan algoritma yang efektif dan efisien yang mampu secara otomatis menghasilkan material PBR berkualitas tinggi, bukan hanya tekstur RGB untuk mesh 3D, dapat secara signifikan mempercepat pembuatan konten 3D. Sebagian besar metode yang ada memanfaatkan model difusi 2D yang telah dilatih sebelumnya untuk sintesis gambar multi-view, yang sering kali menyebabkan inkonsistensi antara tekstur yang dihasilkan dan mesh 3D input. Makalah ini menghadirkan TexGaussian, sebuah metode baru yang menggunakan Octant-aligned 3D Gaussian Splatting untuk menghasilkan material PBR dengan cepat. Secara khusus, kami menempatkan setiap Gaussian 3D pada node daun paling halus dari octree yang dibangun dari mesh 3D input untuk merender gambar multi-view tidak hanya untuk peta albedo tetapi juga untuk roughness dan metallic. Selain itu, model kami dilatih secara regresi alih-alih difusi denoising, mampu menghasilkan material PBR untuk sebuah mesh 3D dalam satu proses feed-forward. Eksperimen ekstensif pada benchmark publik menunjukkan bahwa metode kami mensintesis material PBR yang lebih menarik secara visual dan berjalan lebih cepat dibandingkan metode sebelumnya baik pada skenario tanpa kondisi maupun kondisi teks, serta menunjukkan konsistensi yang lebih baik dengan geometri yang diberikan.

## 📦 Instalasi

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# gaussian splatting yang dimodifikasi (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# dependensi lainnya
pip3 install -r requirements.txt
```

## 🤖 Model Pra-latih

Kami menyediakan model pra-latih berikut ini:

| Model | Deskripsi | Params | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Model tekstur RGB tanpa kondisi yang dilatih pada ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Model tekstur RGB tanpa kondisi yang dilatih pada ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Model tekstur RGB tanpa kondisi yang dilatih pada ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Model tekstur RGB tanpa kondisi yang dilatih pada ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Model material PBR berbasis teks yang dilatih pada Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inferensi

### Material PBR
Untuk menghasilkan material PBR berbasis teks, jalankan
```bash
bash inference_for_PBR_material.sh
```
Setelah proses baking tekstur dan material, Anda akan mendapatkan dua peta: satu peta albedo dan satu lagi peta material PBR. Secara khusus, peta material PBR memiliki tiga channel, di mana channel hijau mewakili nilai roughness dan channel biru mewakili nilai metallic. Untuk melakukan rendering PBR pada peta tekstur dan material yang dihasilkan, kami merekomendasikan menggunakan [script rendering ini](https://github.com/ymxbj/BlenderToolboxPBR) yang ditulis dengan bpy.

Selain itu, kami merekomendasikan Anda untuk meniru gaya teks dataset Cap3D dan membuat prompt sendiri untuk hasil generasi yang lebih baik. Dataset Cap3D dapat diunduh [di sini](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Tekstur RGB
Untuk menghasilkan tekstur RGB tanpa kondisi, yang hanya berlaku untuk 4 kategori spesifik: bench, car, chair, table, jalankan
```bash
bash inference_for_RGB_texture.sh
```
Setelah proses baking tekstur, Anda akan mendapatkan satu peta albedo.

## 🏋️‍♂️ Pelatihan
Untuk Objaverse:
```bash
bash train_for_objaverse.sh
```

Untuk ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Rilis kode pelatihan dan inferensi
- [x] Rilis model pra-latih unconditional albedo-only pada ShapeNet Dataset
- [x] Rilis model pra-latih PBR berbasis teks pada Objaverse Dataset
- [ ] Rilis dataset dan toolkit dataset

## 📚Ucapan Terima Kasih

Karya ini dibangun di atas banyak penelitian dan proyek open-source luar biasa, terima kasih banyak kepada semua penulis yang telah berbagi!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) dan [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Sitasi

Jika Anda merasa karya ini bermanfaat, mohon pertimbangkan untuk mensitasi makalah kami:

1. Versi arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Versi CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---