<p align="center">
  <h1 align="center">VideoScene：蒸馏视频扩散模型，一步生成3D场景</h1>
  <p align="center">
    <a href="https://hanyang-21.github.io/">王涵阳</a><sup>*</sup>，
    <a href="https://liuff19.github.io/">刘方孚</a><sup>*</sup>，
    <a href="https://github.com/hanyang-21/VideoScene">池嘉伟</a>，
    <a href="https://duanyueqi.github.io/">段岳奇</a>
    <br>
    <sup>*</sup>贡献相同。
    <br>
    清华大学
  </p>
  <h3 align="center">CVPR 2025 亮点 🔥</h3>
  <h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2403.20309-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2504.01956) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://hanyang-21.github.io/VideoScene)
<a><img src='https://img.shields.io/badge/License-MIT-blue'></a>
<a href='https://mp.weixin.qq.com/s/u6OUo5mHKPG6I3yYJPMC8Q'><img src='https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-%E4%B8%AD%E6%96%87%E4%BB%8B%E7%BB%8D-green'></a>

</h5>
  <!-- <h3 align="center"><a href="https://arxiv.org/abs/">Paper</a> | <a href="">Project Page</a> | <a href="">Pretrained Models</a> </h3> -->
<!--   <div align="center">
    <a href="https://news.ycombinator.com/item?id=41222655">
      <img
        alt="Featured on Hacker News"
        src="https://hackerbadge.vercel.app/api?id=41222655&type=dark"
      />
    </a>
  </div> -->

</p>

<div align="center">
VideoScene 是一个一步生成3D的高清视频扩散模型，弥合了视频到3D的鸿沟。
</div>
</br>


https://github.com/user-attachments/assets/dca733b1-b78f-49ac-ae47-5d1b1e8a689b

基于 [ReconX](https://github.com/liuff19/ReconX)，VideoScene 实现了极速版本的突破。



## 安装

开始使用，请克隆此项目，创建基于 Python 3.10+ 的 conda 虚拟环境，并安装依赖：

1. 克隆 VideoScene。
```bash
git clone https://github.com/hanyang-21/VideoScene
cd VideoScene
```
2. 创建环境，这里我们展示一个使用 conda 的示例。

```bash
conda create -y -n videoscene python=3.10
conda activate videoscene
pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu118
pip install -r requirements.txt
```

3. 可选，编译RoPE的cuda内核（如CroCo v2中所示）。
```bash
# NoPoSplat relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd src/model/encoder/backbone/croco/curope/
python setup.py build_ext --inplace
cd ../../../../../..
```

## 获取数据集

### RealEstate10K 和 ACID

我们的 VideoScene 使用与 pixelSplat 相同的训练数据集。以下引用 pixelSplat 的[详细说明](https://github.com/dcharatan/pixelsplat?tab=readme-ov-file#acquiring-datasets)关于获取数据集的方法。

> pixelSplat 使用经过拆分为约 100 MB 块以便在服务器集群文件系统上使用的 RealEstate10k 和 ACID 数据集版本进行训练。格式化后的 Real Estate 10k 和 ACID 数据集的小子集可在[此处](https://drive.google.com/drive/folders/1joiezNCyQK2BvWMnfwHJpm2V77c7iYGe?usp=sharing)找到。使用时，只需将其解压到项目根目录中新创建的 `datasets` 文件夹中。

> 如果您想将下载的 Real Estate 10k 和 ACID 数据集版本转换为我们的格式，可以使用[此处的脚本](https://github.com/dcharatan/real_estate_10k_tools)。如果您需要我们处理后的完整数据集版本（Real Estate 10k 约 500 GB，ACID 约 160 GB），请联系我们（pixelSplat）。

## 下载检查点

* 下载我们的[预训练权重](https://wisemodel.cn/models/hanyang/VideoScene/file)（`VideoScene/checkpoints/model.safetensors` 和 `VideoScene/checkpoints/prompt_embeds.pt`），并保存至 `checkpoints` 文件夹。

* 对于自定义图像输入，获取 NoPoSplat 的[预训练模型](https://huggingface.co/botaoye/NoPoSplat/resolve/main/mixRe10kDl3dv_512x512.ckpt)，并保存至 `checkpoints/noposplat`。

* 对于 RealEstate10K 数据集，获取 MVSplat 的[预训练模型](https://drive.google.com/drive/folders/14_E_5R6ojOWnLSrSVLVEMHnTiKsfddjU)，并保存至 `checkpoints/mvsplat`。

## 运行代码

### Gradio 演示
在此演示中，您可以在本机运行 VideoScene，以使用无姿态输入视图生成视频。

* 选择描绘同一场景的图像对，点击“RUN”生成该场景的视频。


```bash
python -m noposplat.src.app \
    checkpointing.load=checkpoints/noposplat/mixRe10kDl3dv_512x512.ckpt \
    test.video=checkpoints/model.safetensors

# also "bash demo.sh"
```
* 生成的视频将存储在 `outputs/gradio` 下

### 推理

为了在 RealEstate10K 数据集上生成视频，我们使用了一个 [MVSplat](https://github.com/donydchen/mvsplat) 预训练模型，

* 运行以下命令：

```bash
# re10k
python -m mvsplat.src.main +experiment=re10k \
checkpointing.load=checkpoints/mvsplat/re10k.ckpt \
mode=test \
dataset/view_sampler=evaluation \
dataset.view_sampler.index_path=mvsplat/assets/evaluation_index_re10k_video.json \
test.save_video=true \
test.save_image=false \
test.compute_scores=false \
test.video=checkpoints/model.safetensors

# also "bash inference.sh"
```

* 生成的视频将存储在 `outputs/test` 目录下


## BibTeX

```bibtex
@misc{wang2025videoscenedistillingvideodiffusion,
      title={VideoScene: Distilling Video Diffusion Model to Generate 3D Scenes in One Step}, 
      author={Hanyang Wang and Fangfu Liu and Jiawei Chi and Yueqi Duan},
      year={2025},
      eprint={2504.01956},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.01956}, 
}
```

## 致谢

本项目开发过程中参考了多个优秀的仓库：[ReconX](https://github.com/liuff19/ReconX)、[MVSplat](https://github.com/donydchen/mvsplat)、[NoPoSplat](https://github.com/cvg/NoPoSplat)、[CogVideo](https://github.com/THUDM/CogVideo) 以及 [CogvideX-Interpolation](https://github.com/feizc/CogvideX-Interpolation)。非常感谢这些项目的卓越贡献！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---