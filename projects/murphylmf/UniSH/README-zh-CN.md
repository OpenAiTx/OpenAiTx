<div align="center">

# UniSH：在一次前向传递中统一场景与人体重建


**李孟飞**<sup>1</sup>，**李鹏**<sup>1</sup>，**张铮**<sup>2</sup>，**卢家豪**<sup>1</sup>，**赵成峰**<sup>1</sup>，**薛伟**<sup>1</sup>，
<br>
**刘启峰**<sup>1</sup>，**彭思达**<sup>3</sup>，**张文晓**<sup>1</sup>，**罗文翰**<sup>1</sup>，**刘远**<sup>1†</sup>，**郭奕柯**<sup>1†</sup>

<sup>1</sup>香港科技大学，<sup>2</sup>北京邮电大学，<sup>3</sup>浙江大学

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
给定单目视频作为输入，我们的UniSH能够在一次前向传递中联合重建场景和人体，实现对场景几何、相机参数和SMPL参数的有效估计。


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ 安装

我们提供了一种**无需sudo权限**的安装方法，适用于大多数Linux服务器（包括无头服务器）。

### 第一步：克隆仓库

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```

### 步骤 2：创建 Conda 环境
这将安装 Python、系统编译器和 OpenGL 驱动程序。

```bash
conda env create -f environment.yml
conda activate unish
```

### 第3步：编译依赖项
此脚本使用第2步中安装的编译器从源代码编译PyTorch3D、MMCV和SAM2。

该环境已在**CUDA 12.1**和**CUDA 11.8**上进行测试。您可以通过将CUDA版本作为参数传递给安装脚本来指定CUDA版本。

```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### 第4步：下载SMPL模型
请下载[SMPL](https://smpl.is.tue.mpg.de/)模型并将其放置在`body_models`文件夹中。
目录结构应按以下方式组织：

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 快速开始（推理）

### 运行推理
运行以下命令从视频中重建场景和人物：

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```
请参阅 `inference.py` 以获取有关附加参数的更多信息。

## 📝 引用

如果您发现此代码对您的研究有帮助，请考虑引用我们的论文：


```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```

## 🙏 致谢

我们感谢以下项目的卓越贡献：

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 许可协议
本项目采用 Apache 2.0 许可协议。详情请参见 [LICENSE](LICENSE)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---