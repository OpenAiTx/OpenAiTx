![brlp](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/readme-brlp-v2.png)

<p align="center">
  <a href='https://www.sciencedirect.com/science/article/pii/S1361841525002816'>
    <img src='https://img.shields.io/badge/Journal-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://papers.miccai.org/miccai-2024/paper/0511_paper.pdf'>
    <img src='https://img.shields.io/badge/MICCAI-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://youtu.be/6YKz2MNM4jg?si=nkG21K4lIgLrH-pK'>
    <img src='https://img.shields.io/badge/Video-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white&color=FF3737' alt='Video'>
  </a>
</p>

<h4 align="center">通过潜在扩散和先验知识提升时空疾病进展模型</h4>

<h4 align="center"><a href="https://lemuelpuglisi.github.io/">Lemuel Puglisi</a>, <a href="https://profiles.ucl.ac.uk/3589">Daniel C. Alexander</a>, <a href="https://daniravi.wixsite.com/researchblog">Daniele Ravì</a></h4>

https://github.com/user-attachments/assets/28ad3693-5e3e-4f6e-9bbc-485424fbbee2

<p align="center">
  <a href="#installation">安装</a> •
  <a href="#training">训练</a> •
  <a href="#inference">命令行应用</a> •
  <a href="#citing">引用</a>
</p>


**新闻**
* 🎉 BrLP 荣获 MICCAI 2025 媒体最佳论文奖亚军！
* 🎉 我们的[扩展论文](https://arxiv.org/pdf/2502.08560)已被《医学图像分析》（*影响因子=11.8*）接受发表
* 🎉 范德堡大学的一篇[新论文](https://www.spiedigitallibrary.org/conference-proceedings-of-spie/13406/1340621/A-technical-assessment-of-latent-diffusion-for-Alzheimers-disease-progression/10.1117/12.3047135.short)在[BLSA](https://www.blsa.nih.gov/)数据集上复现了我们的结果！
* 🆕 BrLP 命令行工具的[简明指南](https://lemuelpuglisi.github.io/blog/2024/brlp/)已发布！
* 🎉 BrLP 入围并进入 MICCAI 最佳论文奖决选名单！（前 <1%）
* 🎉 BrLP 已被提前接收并入选于 [MICCAI 2024](https://conferences.miccai.org/2024/en/)的**口头报告**！（前 4%）



## 目录
- [安装](#installation)
- [数据准备](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)
- [训练](#training)
- [预训练模型](#pretrained-models)
- [致谢](#acknowledgements)
- [引用我们的工作](#citing)

## 安装

下载仓库，进入项目文件夹(`cd`)，并安装 `brlp` 包：

```console
pip install -e .
```
我们建议使用独立环境（参见 [Anaconda](https://www.anaconda.com/)）。代码已在 python 3.9 下测试，但我们预计也能在更新版本中运行。

## 数据准备

请查看我们的文档 [*数据准备与研究可重复性*](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)。该文件将指导您如何组织数据并创建运行训练流程所需的 CSV 文件。

## 训练
![](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/pipeline.png)

BrLP 训练分为三个主要阶段，后续章节将详细描述。每次训练（辅助模型除外）均可通过 `tensorboard` 进行监控，方法如下：



```console
tensorboard --logdir runs
```



### Train the autoencoder

Follow the commands below to train the autoencoder.

```console
# Create an output and a cache directory
mkdir ae_output ae_cache

# Run the training script
python scripts/training/train_autoencoder.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   ./ae_cache \
  --output_dir  ./ae_output
```

然后从您的MRI数据中提取潜变量：

```console
python scripts/prepare/extract_latents.py \
  --dataset_csv /path/to/A.csv \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

将 `XXX` 替换为您选择的自动编码器检查点。

### 训练 UNet

按照以下命令训练扩散 UNet。将 `XXX` 替换为您选择的自动编码器检查点。


```console
# Create an output and a cache directory:
mkdir unet_output unet_cache

# Run the training script
python scripts/training/train_diffusion_unet.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

### 训练 ControlNet

按照以下命令训练 ControlNet。将 `XXX` 替换为您选择的自动编码器和 UNet 检查点。

```console
# Create an output and a cache directory:
mkdir cnet_output cnet_cache

# Run the training script
python scripts/training/train_controlnet.py \
  --dataset_csv /path/to/B.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth \
  --diff_ckpt   unet_output/unet-ep-XXX.pth
```

### 辅助模型

按照以下命令训练 DCM 辅助模型。

```console
# Create an output directory
mkdir aux_output

# Run the training script
python scripts/training/train_aux.py \
  --dataset_csv /path/to/A.csv \
  --output_path aux_output
```
我们强调，任何能够预测体积随时间变化的疾病进展模型也可以作为 BrLP 的辅助模型。

## 推断

我们的软件包附带一个 `brlp` 命令，用于使用 BrLP 进行推断。请查看：

```console
brlp --help
```
`--input` 参数需要一个 CSV 文件，列出所有受试者的可用数据。示例请查看 `examples/input.example.csv`。如果你还没有对输入扫描进行分割，`brlp` 可以使用 [SynthSeg](https://surfer.nmr.mgh.harvard.edu/fswiki/SynthSeg) 为你执行此任务，但这要求安装 FreeSurfer >= 7.4。`--confs` 参数指定模型路径及其他推理参数，例如 LAS $m$。示例请查看 `examples/confs.example.yaml`。

程序运行示例如下：

![inference-preview](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/inference.gif)


## 预训练模型

下载 BrLP 的预训练模型：

| 模型                   | 权重链接                                                     |
| ---------------------- | ------------------------------------------------------------ |
| 自编码器               | [链接](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EUxUFIQtkQ1EvBqojYA5BAYByIyHbttca5Mx1cU4bC6q3A?e=sCXSUA) |
| 扩散模型 UNet          | [链接](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EQT7KJTtfmRAguf8_utWeJIBUJPsRRgPZlt94s2vNbwVFw?e=IjHnx7) |
| ControlNet             | [链接](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EYtVvH47dFJJnH8gtwSMA-MB8c3pm4_Z9g5F_IG1OKxW9Q?e=CzvGT4) |
| 辅助模型 (DCM)         | [链接](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EXJDQqLNCwBFkt2J6zg1kpwBS_1hAZoBfGy5AfcGOBZvHQ?e=Z05kOG) |

## 致谢

感谢开源库维护者们为加速研究进程所做的贡献，特别感谢 [MONAI](https://monai.io/) 及其 [GenerativeModels](https://github.com/Project-MONAI/GenerativeModels/tree/main) 扩展。

## 引用

医学图像分析：


```bib
@article{puglisi2025brain,
  title={Brain latent progression: Individual-based spatiotemporal disease progression on 3D brain MRIs via latent diffusion},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  journal={Medical Image Analysis},
  year={2025}
}
```

MICCAI 2024 会议论文集：

```bib
@inproceedings{puglisi2024enhancing,
  title={Enhancing spatiotemporal disease progression models via latent diffusion and prior knowledge},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  booktitle={International Conference on Medical Image Computing and Computer-Assisted Intervention},
  pages={173--183},
  year={2024},
  organization={Springer}
}
```


SPIE 医学成像 2025 会议论文集：
```bib
@inproceedings{mcmaster2025technical,
  title={A technical assessment of latent diffusion for Alzheimer's disease progression},
  author={McMaster, Elyssa and Puglisi, Lemuel and Gao, Chenyu and Krishnan, Aravind R and Saunders, Adam M and Ravi, Daniele and Beason-Held, Lori L and Resnick, Susan M and Zuo, Lianrui and Moyer, Daniel and others},
  booktitle={Medical Imaging 2025: Image Processing},
  volume={13406},
  pages={505--513},
  year={2025},
  organization={SPIE}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---