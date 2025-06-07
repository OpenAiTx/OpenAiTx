<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>最先进的预训练模型，适用于推理和训练</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers 是一个包含预训练文本、计算机视觉、音频、视频及多模态模型的库，可用于推理和训练。使用 Transformers 可以在你的数据上微调模型，构建推理应用，并支持多模态生成式 AI 应用场景。

在 [Hugging Face Hub](https://huggingface.com/models) 上有超过 50 万个 Transformers [模型检查点](https://huggingface.co/models?library=transformers&sort=trending) 可供使用。

立即探索 [Hub](https://huggingface.com/)，查找合适的模型，用 Transformers 帮助你立刻开始。

## 安装

Transformers 支持 Python 3.9+，[PyTorch](https://pytorch.org/get-started/locally/) 2.1+，[TensorFlow](https://www.tensorflow.org/install/pip) 2.6+，以及 [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+。

推荐使用 [venv](https://docs.python.org/3/library/venv.html) 或 [uv](https://docs.astral.sh/uv/)，即基于 Rust 的快速 Python 包和项目管理器，创建并激活虚拟环境。

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

在你的虚拟环境中安装 Transformers。

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

如果你希望体验库中最新的更改或者有意参与贡献，可以从源码安装 Transformers。但*最新*版本可能不稳定。如果遇到错误，欢迎提交 [issue](https://github.com/huggingface/transformers/issues)。

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## 快速开始

通过 [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API 立即开始使用 Transformers。`Pipeline` 是一个高级推理类，支持文本、音频、视觉和多模态任务。它自动处理输入的预处理并返回相应的输出。

实例化一个 pipeline，并指定用于文本生成的模型。模型会被下载并缓存，方便你后续重复使用。最后，传入一些文本以提示模型。

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

与模型进行对话的用法也是一样的。唯一的区别是你需要构建一段对话历史（即 `Pipeline` 的输入），包括你和系统之间的对话。

> [!TIP]
> 你也可以直接从命令行与模型对话。
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "你是一个好斗、机智、爱吐槽的机器人，风格如 1986 年好莱坞电影中的形象。"},
    {"role": "user", "content": "嘿，你能告诉我在纽约有什么有趣的事情可以做吗？"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

展开下方示例，了解 `Pipeline` 在不同模态和任务下的使用方式。

<details>
<summary>自动语音识别</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>图像分类</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>视觉问答</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="图片里是什么？",
)
[{'answer': 'statue of liberty'}]
```

</details>

## 为什么要使用 Transformers？

1. 易于使用的最先进模型：
    - 在自然语言理解与生成、计算机视觉、音频、视频和多模态任务上表现优异。
    - 研究人员、工程师和开发者易于上手。
    - 仅需学习三个用户相关的抽象类。
    - 提供统一的 API 使用所有预训练模型。

1. 降低计算成本，减少碳足迹：
    - 共享训练好的模型，无需从零开始训练。
    - 减少计算时间和生产成本。
    - 数十种模型架构，跨所有模态有超过 100 万个预训练检查点。

1. 为模型生命周期的每一步选择合适的框架：
    - 用三行代码训练最先进的模型。
    - 可随意在 PyTorch/JAX/TF2.0 框架之间迁移同一个模型。
    - 针对训练、评估和生产选择合适的框架。

1. 轻松定制模型或示例以满足你的需求：
    - 我们为每个架构提供示例，帮助你复现原作者发布的结果。
    - 尽可能保持模型内部结构一致性开放。
    - 模型文件可独立于库使用，便于快速实验。

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## 为什么不应该使用 Transformers？

- 本库不是神经网络的模块化构建工具箱。模型文件中的代码故意未引入额外抽象，便于研究人员直接迭代每个模型，无需深入额外抽象/文件。
- 训练 API 针对 Transformers 提供的 PyTorch 模型进行了优化。如需通用的机器学习循环，建议使用 [Accelerate](https://huggingface.co/docs/accelerate) 等其他库。
- [示例脚本]((https://github.com/huggingface/transformers/tree/main/examples)) 仅为*示例*。它们未必能直接应用于你的具体场景，你需要自行调整代码以适配。

## 100 个基于 Transformers 的项目

Transformers 不仅仅是一个预训练模型工具包，更是一个围绕 Hugging Face Hub 构建的社区。我们希望 Transformers 能帮助开发者、研究员、学生、教授、工程师及所有人实现他们的理想项目。

为庆祝 Transformers 获得 10 万星，我们特别推出了 [awesome-transformers](./awesome-transformers.md) 页面，列出了 100 个用 Transformers 构建的杰出项目。

如果你拥有或使用的项目认为值得上榜，请提交 PR 添加它！

## 示例模型

你可以直接在 [Hub 模型页面](https://huggingface.co/models) 测试我们的大多数模型。

展开下方每个模态，查看不同应用场景下的部分示例模型。

<details>
<summary>音频</summary>

- 使用 [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo) 进行音频分类
- 使用 [Moonshine](https://huggingface.co/UsefulSensors/moonshine) 进行自动语音识别
- 使用 [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks) 进行关键词检测
- 使用 [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16) 进行语音到语音生成
- 使用 [MusicGen](https://huggingface.co/facebook/musicgen-large) 文本生成音频
- 使用 [Bark](https://huggingface.co/suno/bark) 文本转语音

</details>

<details>
<summary>计算机视觉</summary>

- 使用 [SAM](https://huggingface.co/facebook/sam-vit-base) 自动生成掩码
- 使用 [DepthPro](https://huggingface.co/apple/DepthPro-hf) 进行深度估计
- 使用 [DINO v2](https://huggingface.co/facebook/dinov2-base) 进行图像分类
- 使用 [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor) 关键点检测
- 使用 [SuperGlue](https://huggingface.co/magic-leap-community/superglue) 关键点匹配
- 使用 [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd) 目标检测
- 使用 [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple) 姿态估计
- 使用 [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large) 通用分割
- 使用 [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large) 视频分类

</details>

<details>
<summary>多模态</summary>

- 使用 [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B) 音频或文本转文本
- 使用 [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base) 文档问答
- 使用 [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct) 图像或文本转文本
- 使用 [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b) 图像描述生成
- 使用 [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf) 基于 OCR 的文档理解
- 使用 [TAPAS](https://huggingface.co/google/tapas-base) 表格问答
- 使用 [Emu3](https://huggingface.co/BAAI/Emu3-Gen) 统一多模态理解与生成
- 使用 [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf) 视觉转文本
- 使用 [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf) 视觉问答
- 使用 [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224) 视觉指表达分割

</details>

<details>
<summary>NLP</summary>

- 使用 [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base) 掩码词填充
- 使用 [Gemma](https://huggingface.co/google/gemma-2-2b) 命名实体识别
- 使用 [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1) 问答
- 使用 [BART](https://huggingface.co/facebook/bart-large-cnn) 摘要生成
- 使用 [T5](https://huggingface.co/google-t5/t5-base) 翻译
- 使用 [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B) 文本生成
- 使用 [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B) 文本分类

</details>

## 引用

我们现在有一篇可用于引用 🤗 Transformers 库的 [论文](https://www.aclweb.org/anthology/2020.emnlp-demos.6/)：
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---