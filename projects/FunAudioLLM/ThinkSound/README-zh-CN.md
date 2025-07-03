# 🎶 ThinkSound

<p align="center">
  如果您觉得这个项目有用，非常感谢在 GitHub 上点个星 ⭐！
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

---

**ThinkSound** 是一个统一的 Any2Audio 生成框架，通过链式思维（Chain-of-Thought, CoT）推理进行流匹配指导。

基于 PyTorch 的多模态音频生成与编辑实现：可基于视频、文本、音频及其组合，生成或编辑音频，底层由多模态大语言模型（MLLMs）逐步推理驱动。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 最新动态
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 及 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 在线交互体验发布！
- **2025.07** &nbsp; 🔥推理脚本及网页界面已发布；
- **2025.06** &nbsp; 🔥[ThinkSound 论文](https://arxiv.org/pdf/2506.21448) 已在 arXiv 发布！
- **2025.06** &nbsp; 🔥[在线演示](http://thinksound-project.github.io/) 上线，欢迎体验！

---

## 🚀 主要特性

- **Any2Audio**：支持任意模态（视频、文本、音频或其组合）生成音频。
- **视频转音频 SOTA**：在多个 V2A 基准上取得最新最优结果。
- **CoT 驱动推理**：基于链式思维推理，实现可组合、可控的音频生成。
- **交互式面向对象编辑**：通过点击视觉对象或文本指令，细化或编辑特定声音事件。
- **统一框架**：单一基础模型，支持生成、编辑与交互式工作流。

---

## ✨ 方法概述

ThinkSound 将音频生成与编辑分为三个交互式阶段，均由基于 MLLM 的链式思维（CoT）推理指导：

1. **拟音生成（Foley Generation）：** 从视频生成基础、语义与时序对齐的声景。
2. **面向对象的细化：** 通过点击或选择视频中的对象区域，对用户指定对象的声音进行细化或添加。
3. **定向音频编辑：** 使用高级自然语言指令对生成音频进行修改。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大规模 CoT 注释数据集（**AudioCoT**）用于训练推理模块和统一音频基础模型。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速开始

**环境准备：**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# 下载预训练权重 https://huggingface.co/liuhuadai/ThinkSound 到目录 ckpts/
# 模型权重也可从 https://www.modelscope.cn/models/iic/ThinkSound 下载
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**赋予可执行权限**
```bash
chmod +x scripts/demo.sh
```

**运行脚本**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### 网页界面使用

如需交互体验，可启动 Gradio 网页界面：

```bash
python app.py
```

---
## 📝 TODO

- ☐ 发布 ThinkSound 模型的训练脚本
- ☐ 开源 AudioCoT 数据集及自动化流程
- ☐ 提供详细的文档和 API 参考
- ☐ 增加对更多模态和下游任务的支持

---

## 📄 许可证

本项目基于 [Apache 2.0 License](LICENSE) 进行发布。

> **注意：**  
> 代码、模型和数据集**仅供科研与教育用途**。  
> **禁止商业用途。**
>
> 如需商业授权，请联系作者。

---

## 📖 引用

如果您在研究或工作中觉得 ThinkSound 有用，请引用我们的论文：

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

✨ 如果您有任何问题或建议，欢迎[提交 issue](https://github.com/liuhuadai/ThinkSound/issues)或通过邮箱与我们联系（[liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)）！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---