# AudioStory：利用大型语言模型生成长篇叙事音频

**[郭宇昕<sup>1,2</sup>](https://scholar.google.com/citations?user=x_0spxgAAAAJ&hl=en), 
[王腾<sup>2,&#9993;</sup>](http://ttengwang.com/), 
[葛雨莹<sup>2</sup>](https://geyuying.github.io/), 
[马世杰<sup>1,2</sup>](https://mashijie1028.github.io/), 
[葛亦晓<sup>2</sup>](https://geyixiao.com/), 
[邹伟<sup>1</sup>](https://people.ucas.ac.cn/~zouwei),
[单颖<sup>2</sup>](https://scholar.google.com/citations?user=4oXBp9UAAAAJ&hl=en)**
<br>
<sup>1</sup>中国科学院自动化研究所
<sup>2</sup>腾讯PCG ARC实验室
<br>



## 📖 发布

[2025/8/28] 🔥🔥 我们发布了推理代码！

[2025/8/28] 🔥🔥 我们发布了演示视频！



## 🔎 介绍

![audiostory](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory.png)

✨ **简要：我们提出了一种基于统一理解-生成框架的长篇叙事音频生成模型，能够处理视频配音、音频续写及长篇叙事音频合成。**

近期文本到音频（TTA）生成技术在合成短音频片段方面表现出色，但在需要时间连贯性和组合推理的长篇叙事音频方面仍存在挑战。为填补这一空白，我们提出了AudioStory，一个将大型语言模型（LLMs）与TTA系统整合的统一框架，用于生成结构化的长篇音频叙事。AudioStory具备强大的指令遵循推理生成能力。它利用LLMs将复杂叙事查询分解为带有上下文提示的时间序列子任务，实现场景转换的连贯性和情感基调的一致性。AudioStory具有两个吸引人的特性：

1）解耦桥接机制：AudioStory将LLM与扩散模型的协作拆分为两个专门组件——用于事件内语义对齐的桥接查询和用于跨事件一致性保持的一致性查询。
2）端到端训练：通过将指令理解与音频生成统一在单一端到端框架内，AudioStory消除了模块化训练流程的需求，同时增强了组件间的协同效果。
    此外，我们建立了包含动画音景和自然声音叙事等多样领域的基准AudioStory-10K。

大量实验证明，AudioStory在单一音频生成和叙事音频生成任务上均优于先前的TTA基线，在指令遵循能力和音频质量上均有显著提升。



## ⭐ 演示

### 1. 视频配音（猫和老鼠风格）
> 配音是使用 AudioStory（训练于猫和老鼠）通过视频中提取的视觉字幕实现的。

<table class="center">
  <td><video src="https://github.com/user-attachments/assets/f06b5999-6649-44d3-af38-63fdcecd833c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/17727c2a-bfea-4252-9aa8-48fc9ac33500"></video></td>
  <td><video src="https://github.com/user-attachments/assets/09589d82-62c9-47a6-838a-5a62319f35e2"></video></td>
  <tr>
</table >


### 2. 跨领域视频配音（猫和老鼠风格）

<table class="center">
    <td><video src="https://github.com/user-attachments/assets/e62d0c09-cdf0-4e51-b550-0a2c23f8d68d"></video></td>
    <td><video src="https://github.com/user-attachments/assets/736d22ca-6636-4ef0-99f3-768e4dfb112a"></video></td>
    <td><video src="https://github.com/user-attachments/assets/f2f7c94c-7f72-4cc0-8edc-290910980b04"></video></td>
  <tr>
  <td><video src="https://github.com/user-attachments/assets/d3e58dd4-31ae-4e32-aef1-03f1e649cb0c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/4f68199f-e48a-4be7-b6dc-1acb8d377a6e"></video></td>
  <td><video src="https://github.com/user-attachments/assets/062236c3-1d26-4622-b843-cc0cd0c58053"></video></td>
	<tr>
  <td><video src="https://github.com/user-attachments/assets/8931f428-dd4d-430f-9927-068f2912dd36"></video></td>
  <td><video src="https://github.com/user-attachments/assets/ab7e46d5-f42c-472e-b66e-df786b658210"></video></td>      
  <td><video src="https://github.com/user-attachments/assets/9a0998ad-b5a4-42ac-bdaf-ceaf796fc586"></video></td>
  <tr>
</table >



### 3. 文本转长音频（自然声音）

<table class="center">
  <td style="text-align:center;" width="480">说明：“制作一个完整的音频，充分表现杰克·岛袋在录音室演奏复杂尤克里里曲目，获得掌声，并在采访中谈论他的职业生涯。总时长为49.9秒。”</td>
  <td><video src="https://github.com/user-attachments/assets/461e8a34-4217-454e-87b3-e4285f36ec43"></video></td>
	<tr>
  <td style="text-align:center;" width="480">说明：“制作一个完整的音频，充分表现一辆消防车鸣笛离开消防站，发出紧急响应信号，并驶离。总时长为35.1秒。”</td>
  <td><video src="https://github.com/user-attachments/assets/aac0243f-5d12-480e-9850-a7f6720e4f9c"></video></td>
	<tr>
     <td style="text-align:center;" width="480">指令：“理解输入的音频，推断后续事件，并生成教练向球员讲授篮球课程的后续音频。总时长为36.6秒。”</td>    
    <td><video src="https://github.com/user-attachments/assets/c4ed306a-651e-43d6-aeea-ee159542418a"></video></td>
	<tr>
</table >




## 🔎 方法

![audiostory_framework](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory_framework.png)

为了实现有效的指令跟随音频生成，理解输入的指令或音频流并推理相关音频子事件的能力至关重要。为此，AudioStory采用了统一的理解-生成框架（图示）。具体而言，给定文本指令或音频输入，LLM会分析并将其分解为带有上下文的结构化音频子事件。基于推断出的子事件，LLM执行**交错推理生成**，依次为每个音频片段生成字幕、语义令牌和残差令牌。这两种令牌被融合并传递给DiT，有效地桥接了LLM与音频生成器。通过渐进式训练，AudioStory最终实现了强大的指令理解和高质量的音频生成。



## 🔩 安装

### 依赖项

* Python >= 3.10（推荐使用[Anaconda](https://www.anaconda.com/download/#linux)）
* [PyTorch >=2.1.0](https://pytorch.org/)
* NVIDIA GPU + [CUDA](https://developer.nvidia.com/cuda-downloads)

### 安装

```
git clone https://github.com/TencentARC/AudioStory.git
cd AudioStory
conda create -n audiostory python=3.10 -y
conda activate audiostory
bash install_audiostory.sh
```



## 📊 Evaluation

### inference

```
python evaluate/inference.py --model_path /path/to/ckpt --guidance 4.0 --save_folder_name audiostory --total_duration 50
```
## 🔋 致谢

在构建连续去噪器代码库时，我们参考了 [SEED-X](https://github.com/AILab-CVC/SEED-X) 和 [TangoFlux](https://github.com/declare-lab/TangoFlux)。感谢他们的精彩项目。



## 📆 待办事项

- [ ] 发布我们的 gradio 演示。
- [ ] 发布 AudioStory 的检查点。
- [ ] 发布三个阶段的训练代码。



## 📜 许可证

本仓库采用 [Apache 2 许可证](https://github.com/mashijie1028/Gen4Rep/blob/main/LICENSE)。



## 📚 BibTeX




```
@misc{guo2025audiostory,
      title={AudioStory: Generating Long-Form Narrative Audio with Large Language Models}, 
      author={Yuxin Guo and Teng Wang and Yuying Ge and Shijie Ma and Yixiao Ge and Wei Zou and Ying Shan},
      year={2025},
      eprint={2508.20088},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2508.20088}, 
}
```
## 📧 联系方式

如果您有更多问题，欢迎随时联系我：guoyuxin2021@ia.ac.cn

也欢迎讨论和潜在的合作。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---