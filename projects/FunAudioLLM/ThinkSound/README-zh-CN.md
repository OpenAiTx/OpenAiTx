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
  欢迎在 GitHub 上点个星 ⭐ 支持我们！
</p>

---

**ThinkSound** 是一个统一的 Any2Audio 生成框架，采用由多模态大语言模型（MLLM）驱动的链式思维（CoT）推理进行流式匹配指导。

PyTorch 实现的多模态音频生成与编辑：可根据视频、文本、音频及其组合生成或编辑音频，依托于多模态大语言模型的逐步推理能力。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 新闻动态
- **2025.07.17** &nbsp; 🧠 支持微调：训练和微调代码现已公开，并提供清晰的使用说明，助你用自有数据定制和扩展 ThinkSound。
- **2025.07.15** &nbsp; 📦 安装与易用性简化：依赖已发布在 PyPI，跨平台轻松搭建环境；Windows `.bat` 脚本自动化环境创建和脚本执行。
- **2025.07.08** &nbsp;  🔧 重大更新：模型轻量化、内存与 GPU 优化，现支持大规模高吞吐量音频生成！
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 与 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 上线在线体验！
- **2025.07.01** &nbsp; 🔥推理脚本与网页界面发布； 
- **2025.06** &nbsp; 🔥[ThinkSound 论文](https://arxiv.org/pdf/2506.21448) 已在 arXiv 发布！
- **2025.06** &nbsp; 🔥[在线 Demo](http://thinksound-project.github.io/) 正式上线 - 立即体验！

---


## 🚀 主要特性

- **Any2Audio**：可从任意模态（视频、文本、音频或其组合）生成音频。
- **视频转音频 SOTA**：在多个 V2A 基准上取得最先进效果。
- **CoT 驱动推理**：基于链式思维的可组合、可控音频生成，依赖多模态大模型。
- **交互式物体中心编辑**：通过点击视觉目标或文本指令，细化或编辑特定声音事件。
- **统一框架**：单一基础模型支持生成、编辑与交互流程。

---

## ✨ 方法概述

ThinkSound 将音频生成与编辑分解为三个交互式阶段，全部由基于 MLLM 的链式思维（CoT）推理驱动：

1. **拟音生成：** 从视频生成语义与时序对齐的基础声音场景。
2. **物体中心细化：** 通过点击或框选视频内用户指定的物体，细化或补充声音。
3. **目标音频编辑：** 使用高阶自然语言指令修改已生成的音频。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大规模 CoT 标注数据集（**AudioCoT**）用于训练推理模块和统一音频基础模型。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

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

参见 [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 待办事项及未来计划
* - [ ] 开源 AudioCoT 数据集及自动化流水线（预计 2025 年 7 月 23 日前）
* - [ ] 发布覆盖多个领域、更强大的基础模型，以带来更具吸引力和沉浸感的拟音创作（预计 2025 年 8 月底前）
* - [ ] 增加对更多模态和下游任务的支持（预计 2025 年 7 月底前）
* - [ ] 发布不同规模的模型（预计 2025 年 7 月底前）
* - [x] 发布 ThinkSound 模型的训练脚本
* - [x] 提供适合初学者的 Windows 快速上手 README
---


## 📄 许可证

本项目采用 Apache 2.0 许可证开源。

> **注意:**
> 代码、模型和数据集**仅限科研和教育用途**。
> **禁止商业用途。**
> 如需商业授权，请联系作者。

**📦 第三方组件**

* **Stable Audio Open VAE**（Stability AI 提供）：
  本仓库包含来自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) 的微调 VAE，遵循 [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 许可证。
  **商业使用和再分发需事先获得 Stability AI 的许可。**

* 📘 **所有其它代码及模型**均遵循 Apache License 2.0 许可证发布。

---

## 鸣谢

特别感谢：

* **stable-audio-tools**（Stability AI 提供）：
提供了易于使用的音频生成框架，以及 VAE 模块和权重。
* **MMAudio**：
  提供了音频领域 MM-DiT 主干网络的实现。

---

## 📖 引用

如果 ThinkSound 对您的科研或工作有帮助，请引用我们的论文：



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

## 📬 联系方式

✨ 如果您有任何问题或建议，欢迎[提交 issue](https://github.com/liuhuadai/ThinkSound/issues)或通过电子邮件([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn))联系我们！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---