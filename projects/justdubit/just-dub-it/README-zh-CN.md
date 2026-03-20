# JustDubit：通过联合音视频扩散实现视频配音

[![Website](https://img.shields.io/badge/Project-Page-181717?logo=google-chrome)](https://justdubit.github.io)
[![Model](https://img.shields.io/badge/HuggingFace-Model-orange?logo=huggingface)](https://huggingface.co/justdubit/justdubit)
[![Dataset](https://img.shields.io/badge/HuggingFace-Dataset-blue?logo=huggingface)](https://huggingface.co/datasets/justdubit/audiovisual_translation_dub/settings)

## 📰 新闻

- [2026/02/10] 🔥 代码、检查点和数据已发布
- [2026/01/29] 🔥 技术报告发布


---

## 📄 摘要

音视频基础模型，预训练以联合生成声音和视觉内容，最近展现了前所未有的多模态生成与编辑能力，为下游任务开辟了新机遇。

在这些任务中，视频配音可大大受益于此类先验知识，但现有大多数解决方案仍依赖复杂的任务专用流水线，难以应对现实场景。

在本工作中，我们提出了一种单模型方法，通过轻量级LoRA将基础音视频扩散模型适配用于视频到视频配音。该LoRA使模型能够以输入音视频为条件，同时生成翻译后的音频和同步的面部动作。

为了训练此LoRA，我们利用生成模型自身合成同一说话者的多语言配对视频。具体而言，我们生成单个片段内带语言切换的多语言视频，然后对每半段中的面部和音频进行修复，使其匹配另一半的语言。

通过利用音视频模型丰富的生成先验，我们的方法在保持说话者身份和口型同步的同时，对复杂动作和现实动态具有良好的鲁棒性。我们证明该方法生成的配音视频在视觉保真度、口型同步和鲁棒性方面均优于现有配音流水线。

---

## 🚀 快速链接

| 资源 | 描述 |
|----------|-------------|
| [**推理流水线**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) | 使用 JustDubit 流水线运行视频配音 |
| [**训练指南**](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) | 训练你自己的 JustDubit LoRA |

---

## 📦 仓库结构

```
just-dub-it/
├── packages/
│   ├── ltx-pipelines/     # Inference pipeline for video dubbing
│   │   └── README.md      # Pipeline usage guide
│   ├── ltx-trainer/       # Training tools for JustDubit LoRA
│   │   └── README.md      # Training guide
│   └── ltx-core/          # Core model components
└── README.md              # This file
```

---

## 🎬 推理

请参阅 [Pipeline README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-pipelines/README.md) 了解：
- 安装说明
- 模型检查点下载
- 提示格式指南
- CLI 参数参考

---

## 🏋️ 训练

请参阅 [Trainer README](https://raw.githubusercontent.com/justdubit/just-dub-it/main/packages/ltx-trainer/README.md) 了解：
- 数据集下载与准备
- 预处理流程
- 训练配置
- 多GPU训练设置




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-20

---