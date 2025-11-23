<div align="center">

# AerialMegaDepth：学习航拍与地面重建及视图合成

[Khiem Vuong](https://www.khiemvuong.com/), [Anurag Ghosh](https://anuragxel.github.io/), [Deva Ramanan*](https://www.cs.cmu.edu/~deva), [Srinivasa Narasimhan*](https://www.cs.cmu.edu/~srinivas), [Shubham Tulsiani*](https://shubhtuls.github.io/)

**CVPR 2025**

[[`arXiv`](https://arxiv.org/abs/2504.13157)]
[[`项目主页`](https://aerial-megadepth.github.io/)]
[[`3D 网络查看器`](https://aerial-megadepth.github.io/web-viewer/)]
[[`引用格式`](#citation)]

</div>

## 📢 新闻
- (2025年9月5日)：我们已将完整数据集迁移至 HuggingFace，以便更容易下载。请参阅 [data_generation](data_generation) 获取完整说明。

## 目录

- [安装](#installation)
- [快速开始](#quick-start)
- [评估](#evaluation)
- [数据生成](#data-generation)
- [致谢](#acknowledgement)
- [引用](#citation)
- [问题反馈](#issues)


## 📋 开始之前...
根据您的兴趣：

- 🚀 **如果您想下载预训练检查点并运行演示**：请继续往下阅读。

- 🛠️ **如果您想自行访问或生成数据集**：请参阅 [data_generation](data_generation) 获取完整说明。

## 安装

以下是安装说明（主要参考 [MASt3R 仓库](https://github.com/naver/mast3r)）。我们采用 MASt3R 的安装方式，因为它集成了 DUSt3R，但两者使用方式类似。

1. 克隆仓库：

```bash
git clone --recursive https://github.com/kvuong2711/aerial-megadepth.git
cd aerial-megadepth/mast3r

# If you already cloned the repository, you can update the submodules:
# git submodule update --init --recursive
```
2. 创建环境并安装依赖项：
```bash
conda create -n aerialmd python=3.11 cmake=3.14.0
conda activate aerialmd 
conda install pytorch torchvision pytorch-cuda=12.1 -c pytorch -c nvidia  # use the correct version of cuda for your system
pip install -r requirements.txt
pip install -r dust3r/requirements.txt
pip install -r dust3r/requirements_optional.txt
```
3. 可选，编译RoPE的cuda内核（如同CroCo v2）：
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../
```

## 快速开始
我们微调的检查点与原始的 DUSt3R/MASt3R/MASt3R-SfM 代码库完全兼容 - 如果您已经设置好了它们，只需替换检查点即可用于航地场景！

### 检查点

有两种方式下载基于我们 AerialMegaDepth 数据集微调的 DUSt3R 和 MASt3R 检查点：

1. 您可以使用我们的 huggingface_hub 集成：模型（[aerial-dust3r](https://huggingface.co/kvuong2711/checkpoint-aerial-dust3r) 或 [aerial-mast3r](https://huggingface.co/kvuong2711/checkpoint-aerial-mast3r)）将自动下载。

2. 或者，手动下载检查点（使用 [gdown](https://github.com/wkentaro/gdown)，安装命令为 `pip install gdown`）：

```bash
# you are inside aerial-megadepth/mast3r
mkdir -p checkpoints/
gdown --fuzzy "https://drive.google.com/open?id=1wSGpYwWeGn99J8dVWNkfefwmWMAH7LFT" -O checkpoints/  # checkpoint-aerial-dust3r.pth
gdown --fuzzy "https://drive.google.com/open?id=1LrRNUQRQZcVzcioyYHYYx9ImypSZpUq2" -O checkpoints/  # checkpoint-aerial-mast3r.pth
```

### 推理/演示
我们在[assets](assets)文件夹中提供了一些示例图像以供快速测试，包括来自[ULTRRA challenge](https://sites.google.com/view/ultrra-wacv-2025)和[Accenture-NVS1](https://arxiv.org/pdf/2503.18711)的图像。

每个脚本（例如，[demo_dust3r_nongradio.py](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mast3r/demo_dust3r_nongradio.py)）都包含预定义的图像路径，用于展示典型用例。您可以修改脚本中的`image_list`变量以尝试不同的图像对。您可以使用以下命令运行推理：

- DUSt3R 演示代码：
```bash
python demo_dust3r_nongradio.py --weights kvuong2711/checkpoint-aerial-dust3r

# or, if you downloaded the checkpoints manually:
# python demo_dust3r_nongradio.py --weights checkpoints/checkpoint-aerial-dust3r.pth
```
- MASt3R 演示代码：

```bash
python demo_mast3r_nongradio.py --weights kvuong2711/checkpoint-aerial-mast3r

# or, if you downloaded the checkpoints manually:
# python demo_mast3r_nongradio.py --weights checkpoints/checkpoint-aerial-mast3r.pth
```
![matching example](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/assets/figures/matches_figure.png)

## 评估

- [ ] **待办事项：** 评估数据即将发布。

数据下载完成后，运行评估脚本：
```bash
python eval.py \
    --weights checkpoints/checkpoint-aerial-dust3r.pth \
    --eval_data_dir data/eval_data_release
```
该脚本（改编自[PoseDiffusion](https://github.com/facebookresearch/PoseDiffusion)）报告了不同角度阈值下的RRA和RTA。

## 数据生成
有关如何下载和/或生成数据的说明，请参阅[data_generation](data_generation)。

## 致谢
本代码库基于许多优秀的开源项目构建，如[MegaDepth](https://www.cs.cornell.edu/projects/megadepth)、[DUSt3R](https://github.com/naver/dust3r)、[hloc](https://github.com/cvg/Hierarchical-Localization)、[COLMAP](https://github.com/colmap/colmap)等。我们感谢各位作者将他们的工作公开发布。

## 引用
如果您发现我们的工作对您的研究有帮助，请考虑引用我们的论文：

```bibtex
@inproceedings{vuong2025aerialmegadepth,
  title={AerialMegaDepth: Learning Aerial-Ground Reconstruction and View Synthesis},
  author={Vuong, Khiem and Ghosh, Anurag and Ramanan, Deva and Narasimhan, Srinivasa and Tulsiani, Shubham},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  year={2025},
}
```

## 问题
如果您有任何问题/疑问/建议，欢迎创建一个问题，或通过[email](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mailto:kvuong@andrew.cmu.edu)直接与我联系。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---