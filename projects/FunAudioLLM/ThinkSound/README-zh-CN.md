<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  如果你觉得这个项目有用，<br>
  在 GitHub 上点一个星⭐将不胜感激！
</p>

---

## 代码库结构
该 **ThinkSound** GitHub 仓库在不同分支上托管了两个相关项目：

| 分支 | 项目 | 文档 |
|--------|---------|----------------|
| **`master`** | **ThinkSound**（NeurIPS 2025）— 基于CoT引导流匹配的统一Any2Audio生成 | 本文件：**`README.md`** |
| **`prismaudio`** | **PrismAudio** — 后续工作（ICLR 2026），基于多维CoT-RL的视频转音频 | [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 分支的 **`README.md`** |

如需使用 **ThinkSound**，请使用 **`master`** 分支（本README）。如需 **PrismAudio**，请切换至 **`prismaudio`** 分支并参阅对应 **`README.md`**。

---

**ThinkSound** 是一个统一的Any2Audio生成框架，采用链式思维（CoT）推理引导的流匹配。

PyTorch实现的多模态音频生成与编辑工具：可从视频、文本、音频生成或编辑音频，依托多模态大语言模型（MLLM）逐步推理。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 新闻
- **2026.03.24** &nbsp; 🔥 **PrismAudio** 已在本仓库 [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 分支发布 — 安装与模型请见该分支 **`README.md`**。
- **2026.01.26** &nbsp; 🎉 PrismAudio 被 **ICLR 2026主会** 接收（代码/文档见 `prismaudio`）。
- **2025.11.25** &nbsp; 🔥 [在线 PrismAudio 演示](http://prismaudio-project.github.io/) 上线。
- **2025.11.25** &nbsp; 🔥 [PrismAudio 论文](https://arxiv.org/pdf/2511.18833) 已上arXiv — 多维CoT-RL用于视频转音频。
- **2025.09.19** &nbsp; 🎉 **ThinkSound** 被 **NeurIPS 2025主会** 接收！
- **2025.09.01** &nbsp; 我们的 AudioCoT 数据集现已开源并可在 [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) 获取！
- **2025.07.17** &nbsp; 🧠 支持微调：训练与微调代码已公开，配有详细使用说明，助力你自定义并扩展ThinkSound。
- **2025.07.15** &nbsp; 📦 安装与使用更便捷：依赖已上传至PyPI，支持跨平台快捷部署；Windows `.bat` 脚本自动创建环境并运行脚本。
- **2025.07.08** &nbsp;  🔧 重大更新：模型更轻量，优化内存与GPU使用，现支持大规模高吞吐音频生成！
- **2025.07.01** &nbsp; 在线演示已上线 [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 和 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)！
- **2025.07.01** &nbsp; 推出推理脚本及网页界面；
- **2025.06** &nbsp; [ThinkSound 论文](https://arxiv.org/pdf/2506.21448) 发布在arXiv！
- **2025.06** &nbsp; [在线演示](http://thinksound-project.github.io/) 已上线 — 立即体验！

---


<div align="center">

### 后续工作：PrismAudio（同仓库，`prismaudio` 分支）


**PrismAudio** 是 ThinkSound (ICLR 2026) 的继任者，以新名称开发，但保留在本仓库的 **`prismaudio`** 分支中。安装、检查点和引用信息见该分支的 **[`README.md`](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**。

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 或在 GitHub 上打开该分支。

</div>

---


## 🚀 功能

- **Any2Audio**：从任意模态（视频、文本、音频或其组合）生成音频。
- **视频转音频 SOTA**：在多项 V2A 基准测试中取得最先进的结果。
- **CoT 驱动的推理**：通过 MLLMs 实现链式推理，实现可组合、可控的音频生成。
- **交互式以对象为中心的编辑**：通过点击视觉对象或文本指令细化或编辑特定声音事件。
- **统一框架**：一个基础模型支持生成、编辑和交互式工作流。

---

## ✨ 方法概述

ThinkSound 将音频生成和编辑分解为三个交互阶段，均由基于 MLLM 的链式推理（CoT）指导：

1. **拟音生成：** 从视频中生成语义和时间对齐的基础音景。
2. **以对象为中心的细化：** 通过点击或视频中的区域，为用户指定的对象细化或添加声音。
3. **目标音频编辑：** 使用高级自然语言指令修改生成的音频。

![ThinkSound 概览](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 一个大规模 CoT 注释数据集（**AudioCoT**）用于训练推理模块和统一音频基础模型。
![AudioCoT 流程](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速开始

**环境准备：**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows 提示：**  
> Windows 用户只需运行 `setup_windows.bat`（或双击它），即可自动创建 conda 环境、安装所有依赖项（包括 FFmpeg），并下载预训练模型——无需手动设置。  
> 在运行脚本前，请确保已安装 `conda` 和 `git` 并且它们已添加到系统 PATH 中。


### ▶️ 运行演示

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

你也可以使用提供的 `.bat` 脚本来代替：


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**注意：**

* `<path-to-your-demo-video>`：单个视频的路径
* `[use-half]`（可选）：在末尾添加 use-half 以启用半精度特征提取功能。

---

### 📦 批量推理

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

请使用等效的 `.bat` 脚本：


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**注意：**

* `<video_path>`：包含所有待处理 .mp4 视频的根目录路径（所有视频必须时长相同）。
* `<csv_path>`：为每个视频提供文本提示的 CSV 文件（格式参考 `demo_test.csv`）。
* `<save_path>`（可选）：生成音频的保存位置。默认为 `results/features`。
* `[use-half]`（可选）：在末尾添加 use-half 以启用半精度特征提取。

---

### 网页界面使用方法

如需交互式体验，可启动 Gradio 网页界面：



```bash
python app.py
```
## 🏋️ 训练模型

参见 [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 许可证

本项目采用 Apache 2.0 许可证发布。

> **注意：**
> 本代码、模型和数据集**仅供科研与教育用途**。
> **禁止商业用途。**
> 如需商业授权，请联系作者。

**📦 第三方组件**

* **Stable Audio Open VAE**（由 Stability AI 提供）：
  本仓库包含来自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) 的微调 VAE，遵循 [Stability AI 社区许可证](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)。
  **商业使用和再分发需事先获得 Stability AI 许可。**

* 📘 **所有其他代码和模型** 均按照 Apache License 2.0 发布。

---

## 鸣谢

特别感谢：

* **stable-audio-tools**（由 Stability AI 提供）：
  提供了音频生成易用的开发框架，以及 VAE 模块和权重。
* **MMAudio**：
  在音频领域实现了 MM-DiT 主干网络。

---



## 📖 引用

如果您在研究或工作中发现我们的项目有用，请引用我们的论文：

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---