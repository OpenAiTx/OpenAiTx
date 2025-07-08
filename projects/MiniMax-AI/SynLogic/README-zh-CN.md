<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

本仓库包含了 SynLogic 的代码和数据，SynLogic 是一个全面的逻辑推理数据合成框架，能够大规模生成多样化、可验证的推理数据。我们的工作旨在解决在开发大语言模型（LLMs）通用推理能力过程中，高质量逻辑推理训练数据缺乏的关键问题。

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## 新闻
- **[2025/07/07]** :fire: 我们提供了使用 SynLogic 数据结合 Verl 框架进行强化学习（RL）训练的指导。详见 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) 。

- **[2025/06/03]** :fire: Hugging Face 上已发布训练模型：  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: 我们很高兴发布论文“SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond”的相关资源。

## 📋 概述

**SynLogic** 是一个数据合成框架及综合数据集，具有以下特点：
- 📊 **覆盖35种多样的逻辑推理任务**，包括数独、24点、密码、箭头迷宫等
- 🎯 **支持可控难度合成**，每个任务都可调整参数
- ✅ **提供可验证奖励**，通过基于规则的验证机制，适用于RL训练
- 🚀 **在开源数据集上实现SOTA表现**，在BBEH上超越DeepSeek-R1-Distill-Qwen-32B 6分

### 主要特性
- **可扩展的数据生成**：支持无限量数据合成，难度可控
- **全面的任务覆盖**：35种独特的逻辑推理任务，均配有自定义生成器和验证器
- **RL友好**：所有样本均可通过简单规则验证，非常适合强化学习
- **跨领域泛化能力**：对数学、编程等领域具备强泛化能力

## 🚀 快速开始

### 安装
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### 生成样例数据（以箭头迷宫为例）
```bash
# 使用箭头迷宫的简单示例
bash games/tasks/arrow_maze/run.sh

# 或使用自定义参数
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### 用于RL训练

我们提供了详细的指南，帮助您将 SynLogic 数据用于强化学习训练。详见 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) ，了解如何与 Verl 框架集成。

## :rocket: 资源

### 数据集
| 数据集名称 | 描述 | 链接 |
|:---------:|:-----:|:----:|
| **SynLogic** | 数据集 | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### 模型


| 模型名称 | 描述 | 链接 |
|:--------:|:-----:|:----:|
| **SynLogic-7B** | 在 SynLogic 上训练的 7B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | 在 SynLogic 上训练的 32B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | 在 SynLogic、数学、编程混合数据上训练的 32B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 后续更新

我们正在积极扩展 SynLogic，加入更多逻辑推理任务。

关注我们的代码库，获取最新的动态和发布信息！

## 引用
如果您觉得我们的工作有帮助，请引用我们的论文：

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---