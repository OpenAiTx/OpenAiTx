<h1 align="center">TexGaussian: 基于八叉树的3D高斯溅射生成高质量PBR材质</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="assets/teaser.png" width="100%"></p>

基于物理渲染（PBR）材质在现代图形学中发挥着至关重要的作用，使得在不同环境贴图下实现真实感渲染成为可能。开发一种能够自动为3D网格生成高质量PBR材质（而不仅仅是RGB纹理）的高效算法，可以极大地简化3D内容创作流程。现有大多数方法利用预训练的2D扩散模型进行多视图图像合成，这通常会导致生成的纹理与输入3D网格之间存在严重不一致性。本文提出了一种新颖的方法TexGaussian，利用八分体对齐的3D高斯溅射实现快速PBR材质生成。具体而言，我们将每个3D高斯放置于由输入3D网格构建的八叉树最细叶节点上，用于渲染多视图图像，不仅用于反照率贴图（albedo map），还用于粗糙度（roughness）和金属度（metallic）。此外，我们的模型采用回归方式进行训练，而非扩散去噪，能够在单次前馈过程中为3D网格生成PBR材质。基于公开基准的广泛实验表明，我们的方法在无条件和文本条件下都能合成更具视觉吸引力的PBR材质，并且运行速度快于以往方法，与给定几何体的一致性更佳。

## 📦 安装

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# 修改过的高斯溅射（+ 深度和alpha渲染）
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# 其他依赖项
pip3 install -r requirements.txt
```

## 🤖 预训练模型

我们提供以下预训练模型：

| 模型 | 描述 | 参数量 | 下载链接 |
| --- | --- | --- | --- |
| TexGaussian-bench | 在ShapeNet bench上训练的无条件RGB纹理模型 | 70M | [下载](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | 在ShapeNet car上训练的无条件RGB纹理模型 | 70M | [下载](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | 在ShapeNet chair上训练的无条件RGB纹理模型 | 70M | [下载](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | 在ShapeNet table上训练的无条件RGB纹理模型 | 70M | [下载](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | 在Objaverse上训练的文本条件PBR材质模型 | 295M | [下载](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 推理

### PBR材质
如需进行文本条件PBR材质生成，请运行
```bash
bash inference_for_PBR_material.sh
```
纹理和材质烘焙完成后，您将获得两张贴图，一张是反照率贴图（albedo map），另一张是PBR材质贴图。具体来说，PBR材质贴图包含三个通道，其中绿色通道表示粗糙度值，蓝色通道表示金属度值。若需对生成的纹理和材质贴图进行PBR渲染，推荐使用[bpy实现的此渲染脚本](https://github.com/ymxbj/BlenderToolboxPBR)。

此外，我们建议大家模仿Cap3D数据集的文本风格，创建属于自己的提示词，以获得更好的生成效果。Cap3D数据集可在[这里](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true)下载。

### RGB纹理
如需无条件RGB纹理生成（仅支持bench、car、chair、table四个特定类别），请运行
```bash
bash inference_for_RGB_texture.sh
```
纹理烘焙后，您将获得一张反照率贴图。

## 🏋️‍♂️ 训练
Objaverse数据集训练：
```bash
bash train_for_objaverse.sh
```

ShapeNet数据集训练：
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] 发布训练和推理代码
- [x] 发布ShapeNet数据集上的无条件albedo-only预训练模型
- [x] 发布Objaverse数据集上的文本条件PBR预训练模型
- [ ] 发布数据集和数据集工具包

## 📚致谢

本项目基于众多出色的研究工作和开源项目，非常感谢所有作者的无私分享！

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) 和 [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 引用

如果您觉得本工作对您有帮助，请引用我们的论文：

1. arXiv版本
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR版本
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