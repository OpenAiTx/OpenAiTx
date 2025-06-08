<h1 align="center">TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Physically Based Rendering (PBR) materials play a crucial role in modern graphics, enabling photorealistic rendering across diverse environment maps. Developing an effective and efficient algorithm that is capable of automatically generating high-quality PBR materials rather than RGB texture for 3D meshes can significantly streamline the 3D content creation. Most existing methods leverage pre-trained 2D diffusion models for multi-view image synthesis, which often leads to severe inconsistency between the generated textures and input 3D meshes. This paper presents TexGaussian, a novel method that uses octant-aligned 3D Gaussian Splatting for rapid PBR material generation. Specifically, we place each 3D Gaussian on the finest leaf node of the octree built from the input 3D mesh to render the multi-view images not only for the albedo map but also for roughness and metallic. Moreover, our model is trained in a regression manner instead of diffusion denoising, capable of generating the PBR material for a 3D mesh in a single feed-forward process. Extensive experiments on publicly available benchmarks demonstrate that our method synthesizes more visually pleasing PBR materials and runs faster than previous methods in both unconditional and text-conditional scenarios, which exhibit better consistency with the given geometry.

## 📦 Installation

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# a modified gaussian splatting (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# other dependencies
pip3 install -r requirements.txt
```

## 🤖 Pretrained Models

We provide the following pretrained models:

| Model | Description | Params | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Unconditional RGB texture model trained on ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Unconditional RGB texture model trained on ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Unconditional RGB texture model trained on ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Unconditional RGB texture model trained on ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Text conditional PBR material model trained on Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inference

### PBR Material
For text conditional PBR material generation, run
```bash
bash inference_for_PBR_material.sh
```
After texture and material baking, you will get two maps, one is albedo map and another one is PBR material map. Specifically, the PBR material map contains three channel, where the green channel represents roughness value and the blue channel represents metallic value. To perform PBR rendering of the generated texture and material maps, we recommend using [this rendering script](https://github.com/ymxbj/BlenderToolboxPBR) written by bpy.

What's more, we recommend everyone to imitate the style of Cap3D dataset's text and create your own prompts for better generation results. The Cap3D dataset can be downloaded in [here](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### RGB Texture
For unconditional RGB texture generation, which only works for specific 4 categories: bench, car, chair, table, run
```bash
bash inference_for_RGB_texture.sh
```
After texture baking, you will get one albedo map.

## 🏋️‍♂️ Training
For Objaverse:
```bash
bash train_for_objaverse.sh
```

For ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Release training and inference code
- [x] Release unconditional albedo-only pre-trained model on ShapeNet Dataset
- [x] Release text-conditional PBR pre-trained model on Objaverse Dataset
- [ ] Release dataset and dataset toolkits

## 📚Acknowledgement

This work is built on many amazing research works and open-source projects, thanks a lot to all the authors for sharing!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) and [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Citation

If you find this work helpful, please consider citing our paper:

1. arXiv verison
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR version
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