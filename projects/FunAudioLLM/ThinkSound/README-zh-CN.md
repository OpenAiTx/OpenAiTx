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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
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
  欢迎在 GitHub 上点个星 ⭐！
</p>

---

**ThinkSound** 是一个统一的 Any2Audio 生成框架，结合了由思维链（Chain-of-Thought, CoT）推理指导的流匹配方法。
PyTorch 实现的多模态音频生成与编辑：可根据视频、文本和音频生成或编辑音频，依托于多模态大语言模型（MLLMs）逐步推理。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 新闻
- **2025.11.25** &nbsp; 🔥[PrismAudio 在线演示](http://prismaudio-project.github.io/)上线 - 立即体验！
- **2025.11.25** &nbsp; 🔥[PrismAudio 论文](https://arxiv.org/pdf/2511.18833)已在 arXiv 发布，首个面向视频转音频生成的多维 CoT-RL 框架！
- **2025.09.19** &nbsp; 🎉 ThinkSound 已被 **NeurIPS 2025 主会**录用！
- **2025.09.01** &nbsp; 我们的 AudioCoT 数据集已开源并可在 [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) 获取！
- **2025.07.17** &nbsp; 🧠 已支持微调：训练及微调代码现已公开，配有详细使用说明，助您用自有数据定制扩展 ThinkSound。
- **2025.07.15** &nbsp; 📦 安装与易用性简化：依赖已上架 PyPI，便于跨平台部署；Windows `.bat` 脚本自动化环境创建与脚本运行。
- **2025.07.08** &nbsp;  🔧 重大更新：模型瘦身，优化内存与 GPU 占用，现已支持大规模高吞吐音频生成！
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 及 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 提供在线交互体验！
- **2025.07.01** &nbsp; 推出推理脚本与网页界面；
- **2025.06** &nbsp; [ThinkSound 论文](https://arxiv.org/pdf/2506.21448)已在 arXiv 发布！
- **2025.06** &nbsp; [在线演示](http://thinksound-project.github.io/)已上线 - 立即试用！

---


## 🚀 特性

- **Any2Audio**：支持任意模态（视频、文本、音频或其组合）生成音频。
- **视频转音频 SOTA**：在多项 V2A 基准上达到最先进效果。
- **CoT 驱动推理**：通过 MLLM 的链式思维推理，实现可组合、可控的音频生成。
- **交互式物体编辑**：通过点击视觉对象或文本指令，细化或编辑特定声音事件。
- **统一框架**：单一基础模型同时支持生成、编辑与交互式流程。

---

## ✨ 方法概述

ThinkSound 将音频生成与编辑拆解为三个由 MLLM 链式思维（CoT）推理驱动的交互阶段：

1. **拟音生成：** 从视频生成语义与时间对齐的基础音景。
2. **基于物体的细化：** 通过点击或圈定视频中用户指定的对象，细化或添加声音。
3. **目标音频编辑：** 利用高阶自然语言指令修改生成的音频。


![ThinkSound 概览](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 一个大规模的 CoT 注释数据集（**AudioCoT**）被用于训练推理模块和统一的音频基础模型。
![AudioCoT 流程](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速开始

**环境准备：**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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

请参阅 [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 待办事项与未来规划
* - [ ] 发布更强大的基础模型，覆盖多个领域，提供更具吸引力和沉浸感的拟音创作
* - [ ] 增加对更多模态和下游任务的支持
* - [ ] 发布不同规模的模型
* - [x] 开源 AudioCoT 数据集和自动化流程
* - [x] 发布 ThinkSound 模型的训练脚本
* - [x] 提供面向初学者的 Windows 快速入门 README
---


## 📄 许可证

本项目采用 Apache 2.0 许可证发布。

> **注意：**
> 代码、模型和数据集仅用于**科研和教育目的**。
> **禁止商业用途。**
> 如需商业授权，请联系作者。

**📦 第三方组件**

* **Stable Audio Open VAE**（由 Stability AI 提供）：
  本仓库包含来自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) 的微调 VAE，遵循 [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 授权。
  **商业使用和再分发需事先获得 Stability AI 的许可。**

* 📘 **所有其他代码和模型**均采用 Apache License 2.0 许可发布。

---

## 致谢

特别感谢：

* **stable-audio-tools**（由 Stability AI 提供）：
为音频生成提供了易用的框架，以及 VAE 模块和权重。
* **MMAudio**：
  在音频领域实现了 MM-DiT 主干网络。

---

## 📖 引用

如果您在研究或工作中发现 ThinkSound 有用，请引用我们的论文：

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---