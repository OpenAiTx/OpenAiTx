<div align="center">
<h2>Difusi Satu Langkah untuk Super-Resolusi Video yang Kaya Detail dan Konsisten Secara Temporal</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>OPPO Research Institute
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Hasil Visual">

</p>
## ⏰ Pembaruan

- **2025.07.08**: Kode inferensi dan bobot pralatih tersedia.
- **2025.06.24**: Halaman proyek tersedia, termasuk video penjelasan singkat 2 menit, lebih banyak hasil visual, dan riset terkait.
- **2025.06.17**: Repo dirilis.

:star: Jika DLoRAL bermanfaat untuk video atau proyek Anda, mohon bantu bintangi repo ini. Terima kasih! :hugs:

😊 Anda juga mungkin ingin melihat karya kami yang relevan:

1. **OSEDiff (NIPS2024)** [Paper](https://arxiv.org/abs/2406.08177) | [Kode](https://github.com/cswry/OSEDiff/)  

   Algoritma SR Gambar waktu nyata yang telah diterapkan pada seri OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Paper](https://arxiv.org/pdf/2412.03017) | [Kode](https://github.com/csslc/PiSA-SR) 

   Eksplorasi pionir paradigma Dual-LoRA dalam SR Gambar.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Daftar sumber daya terkurasi untuk Video Super-Resolution (VSR) menggunakan Diffusion Models.
## 👀 TODO
- [x] Merilis kode inferensi.
- [ ] Colab dan UI Huggingface untuk pengujian yang mudah (Segera!).
- [ ] Merilis kode pelatihan.
- [ ] Merilis data pelatihan.


## 🌟 Gambaran Umum Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Pelatihan**: Skema pelatihan dua tahap dinamis secara bergantian mengoptimalkan koherensi temporal (tahap konsistensi) dan memperbaiki detail spasial frekuensi tinggi (tahap peningkatan) dengan interpolasi loss yang mulus untuk memastikan stabilitas.

**Inferensi**: Selama inferensi, baik C-LoRA maupun D-LoRA digabungkan ke dalam diffusion UNet yang dibekukan, memungkinkan peningkatan satu langkah dari input berkualitas rendah menjadi output berkualitas tinggi.
## 🔧 Dependensi dan Instalasi

1. Clone repo
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Instal paket-paket dependensi
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Unduh Model
#### Model Dependensi
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> letakkan di **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> letakkan di **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> letakkan di **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> letakkan di **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> letakkan di **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Setiap path dapat dimodifikasi sesuai kebutuhan masing-masing, dan perubahan yang sesuai juga harus diterapkan pada command line dan kode.
## 🖼️ Inferensi Cepat
Untuk Super-Resolusi Video Dunia Nyata:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### Sitasi
Jika kode kami membantu penelitian atau pekerjaan Anda, mohon pertimbangkan untuk mengutip makalah kami.
Berikut adalah referensi BibTeX:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun dan Shuaizheng Liu dan Rongyuan Wu dan Zhengqiang Zhang dan Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---