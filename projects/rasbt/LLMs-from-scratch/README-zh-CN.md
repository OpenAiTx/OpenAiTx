# 从零开始构建大型语言模型

本仓库包含开发、预训练和微调类GPT大型语言模型（LLM）的代码，是图书《从零开始构建大型语言模型》（[Build a Large Language Model (From Scratch)](https://amzn.to/4fqvn0D)）的官方代码仓库。

<br>
<br>

<a href="https://amzn.to/4fqvn0D"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/cover.jpg?123" width="250px"></a>

<br>

在[*从零开始构建大型语言模型*](http://mng.bz/orYv)一书中，你将通过一步步编写代码，深入理解大型语言模型（LLM）的内部工作原理。在本书中，我将引导你创建自己的LLM，并通过清晰的文字、图示和示例解释每个阶段。

本书中描述的训练和开发自己小型但功能完整模型的方法，旨在教学用途，且与用于构建如ChatGPT背后大型基础模型的方法类似。此外，本书还包含用于加载更大预训练模型权重进行微调的代码。

- 官方[源码仓库链接](https://github.com/rasbt/LLMs-from-scratch)
- [出版社网站上的图书链接（Manning）](http://mng.bz/orYv)
- [亚马逊图书页面链接](https://www.amazon.com/gp/product/1633437167)
- ISBN 9781633437166

<a href="http://mng.bz/orYv#reviews"><img src="https://sebastianraschka.com//images/LLMs-from-scratch-images/other/reviews.png" width="220px"></a>

<br>
<br>

要下载本仓库副本，请点击[Download ZIP](https://github.com/rasbt/LLMs-from-scratch/archive/refs/heads/main.zip)按钮，或在终端执行以下命令：


```bash
git clone --depth 1 https://github.com/rasbt/LLMs-from-scratch.git
```

<br>

(If you downloaded the code bundle from the Manning website, please consider visiting the official code repository on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) for the latest updates.)

<br>
<br>


# Table of Contents

Please note that this `README.md` file is a Markdown (`.md`) file. If you have downloaded this code bundle from the Manning website and are viewing it on your local computer, I recommend using a Markdown editor or previewer for proper viewing. If you haven't installed a Markdown editor yet, [Ghostwriter](https://ghostwriter.kde.org) is a good free option.

You can alternatively view this and other files on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) in your browser, which renders Markdown automatically.

<br>
<br>


> **Tip:**
> If you're seeking guidance on installing Python and Python packages and setting up your code environment, I suggest reading the [README.md](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/setup/README.md) file located in the [setup](setup) directory.

<br>
<br>

[![Code tests Linux](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml)
[![Code tests Windows](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml)
[![Code tests macOS](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml)




<br>

| Chapter Title                                              | Main Code (for Quick Access)                                                                                                    | All Code + Supplementary      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------|-------------------------------|
| [Setup recommendations](setup)                             | -                                                                                                                               | -                             |
| Ch 1: Understanding Large Language Models                  | No code                                                                                                                         | -                             |
| Ch 2: Working with Text Data                               | - [ch02.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/ch02.ipynb)<br/>- [dataloader.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/dataloader.ipynb) (summary)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/exercise-solutions.ipynb)               | [./ch02](./ch02)            |
| Ch 3: Coding Attention Mechanisms                          | - [ch03.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/ch03.ipynb)<br/>- [multihead-attention.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/multihead-attention.ipynb) (summary) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/exercise-solutions.ipynb)| [./ch03](./ch03)             |
| 第4章：从零实现GPT模型                                   | - [ch04.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/ch04.ipynb)<br/>- [gpt.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/gpt.py)（摘要）<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/exercise-solutions.ipynb) | [./ch04](./ch04)           |
| 第5章：无标签数据的预训练                                | - [ch05.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/ch05.ipynb)<br/>- [gpt_train.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_train.py)（摘要）<br/>- [gpt_generate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_generate.py)（摘要）<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/exercise-solutions.ipynb) | [./ch05](./ch05)              |
| 第6章：文本分类的微调                                   | - [ch06.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/ch06.ipynb)  <br/>- [gpt_class_finetune.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/gpt_class_finetune.py)  <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/exercise-solutions.ipynb) | [./ch06](./ch06)              |
| 第7章：微调以遵循指令                                  | - [ch07.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ch07.ipynb)<br/>- [gpt_instruction_finetuning.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/gpt_instruction_finetuning.py)（摘要）<br/>- [ollama_evaluate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ollama_evaluate.py)（摘要）<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/exercise-solutions.ipynb) | [./ch07](./ch07)  |
| 附录A：PyTorch简介                                    | - [code-part1.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part1.ipynb)<br/>- [code-part2.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part2.ipynb)<br/>- [DDP-script.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/DDP-script.py)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/exercise-solutions.ipynb) | [./appendix-A](./appendix-A) |
| 附录B：参考文献及进一步阅读                             | 无代码                                                                                                                         | -                             |
| 附录C：习题答案                                       | 无代码                                                                                                                         | -                             |
| 附录D：为训练循环添加附加功能                           | - [appendix-D.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-D/01_main-chapter-code/appendix-D.ipynb)                                                          | [./appendix-D](./appendix-D)  |
| 附录E：使用LoRA进行参数高效微调                         | - [appendix-E.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-E/01_main-chapter-code/appendix-E.ipynb)                                                          | [./appendix-E](./appendix-E) |

<br>
&nbsp;

下面的思维模型总结了本书所涵盖的内容。

<img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/mental-model.jpg" width="650px">


<br>
&nbsp;

## 先决条件

最重要的先决条件是扎实的Python编程基础。
具备这些知识，您将能很好地准备好探索引人入胜的大型语言模型（LLMs）世界，
并理解本书中呈现的概念和代码示例。

如果您对深度神经网络有一定经验，您可能会发现某些概念更为熟悉，因为LLMs是建立在这些架构之上的。

本书使用PyTorch从零实现代码，不依赖任何外部LLM库。虽然掌握PyTorch不是必需条件，但熟悉PyTorch基础无疑非常有帮助。如果您是PyTorch新手，附录A提供了PyTorch的简明介绍。或者，您也可以参考我的书籍，[PyTorch in One Hour: From Tensors to Training Neural Networks on Multiple GPUs](https://sebastianraschka.com/teaching/pytorch-1h/)，学习相关基础知识。



<br>
&nbsp;

## 硬件要求

本书主要章节中的代码设计为可在普通笔记本电脑上于合理时间内运行，无需专用硬件。此方式确保更广泛的读者群能够参与学习。此外，代码会自动利用可用的GPU。（更多建议请参见[安装说明](https://github.com/rasbt/LLMs-from-scratch/blob/main/setup/README.md)文档。）

&nbsp;
## 视频课程

[一个时长17小时15分钟的配套视频课程](https://www.manning.com/livevideo/master-and-build-large-language-models)，我会在课程中逐章编码。课程结构按照书籍章节和小节组织，既可作为书籍的独立替代，也可作为补充的代码学习资源。

<a href="https://www.manning.com/livevideo/master-and-build-large-language-models"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/video-screenshot.webp?123" width="350px"></a>


&nbsp;


## 配套书籍 / 后续作品

[*构建推理模型（从零开始）*](https://mng.bz/lZ5B)虽然是独立书籍，但可视为*构建大型语言模型（从零开始）*的续集。

它从一个预训练模型开始，实施不同的推理方法，包括推理时扩展、强化学习和蒸馏，以提升模型的推理能力。

与*构建大型语言模型（从零开始）*类似，[*构建推理模型（从零开始）*](https://mng.bz/lZ5B)采取动手实践的方式，从头实现这些方法。

<a href="https://mng.bz/lZ5B"><img src="https://sebastianraschka.com/images/reasoning-from-scratch-images/cover.webp?123" width="120px"></a>

- 亚马逊链接（待定）
- [Manning链接](https://mng.bz/lZ5B)
- [GitHub仓库](https://github.com/rasbt/reasoning-from-scratch)

<br>

&nbsp;
## 练习题

书中每章包含若干练习题。答案汇总在附录C，对应代码笔记本可在本仓库主章节文件夹中找到（例如，[./ch02/01_main-chapter-code/exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/./ch02/01_main-chapter-code/exercise-solutions.ipynb)）。

除代码练习外，你还可以从Manning网站免费下载一本170页的PDF，名为[测试你自己：构建大型语言模型（从零开始）](https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch)。该书每章包含约30个测验题及答案，帮助你检验理解程度。

<a href="https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/test-yourself-cover.jpg?123" width="150px"></a>



&nbsp;

## 额外材料

几个文件夹包含了供感兴趣读者参考的可选材料：

- **设置**
  - [Python 设置技巧](setup/01_optional-python-setup-preferences)
  - [本书中使用的 Python 包和库的安装](setup/02_installing-python-libraries)
  - [Docker 环境搭建指南](setup/03_optional-docker-environment)
- **第2章：处理文本数据**
  - [从零开始实现的字节对编码（BPE）分词器](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/05_bpe-from-scratch/bpe-from-scratch.ipynb)
  - [比较各种字节对编码（BPE）实现](ch02/02_bonus_bytepair-encoder)
  - [理解嵌入层与线性层的区别](ch02/03_bonus_embedding-vs-matmul)
  - [使用简单数字理解数据加载器直觉](ch02/04_bonus_dataloader-intuition)
- **第3章：编码注意力机制**
  - [比较高效的多头注意力实现](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/02_bonus_efficient-multihead-attention/mha-implementations.ipynb)
  - [理解 PyTorch 缓冲区](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/03_understanding-buffers/understanding-buffers.ipynb)
- **第4章：从零实现 GPT 模型**
  - [FLOPS 分析](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/02_performance-analysis/flops-analysis.ipynb)
  - [KV 缓存](ch04/03_kv-cache)
- **第5章：无标签数据上的预训练：**
  - [替代权重加载方法](ch05/02_alternative_weight_loading/)
  - [在 Project Gutenberg 数据集上预训练 GPT](ch05/03_bonus_pretraining_on_gutenberg)
  - [为训练循环添加更多功能](ch05/04_learning_rate_schedulers)
  - [预训练超参数优化](ch05/05_bonus_hparam_tuning)
  - [构建用于与预训练大语言模型交互的用户界面](ch05/06_user_interface)
  - [将 GPT 转换为 Llama](ch05/07_gpt_to_llama)
  - [从零开始实现 Llama 3.2](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/07_gpt_to_llama/standalone-llama32.ipynb)
  - [从零实现 Qwen3 密集模型和专家混合（MoE）](ch05/11_qwen3/)
  - [从零实现 Gemma 3](ch05/12_gemma3/)
  - [内存高效的模型权重加载](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/08_memory_efficient_weight_loading/memory-efficient-state-dict.ipynb)
  - [用新词扩展 Tiktoken BPE 分词器](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/09_extending-tokenizers/extend-tiktoken.ipynb)
  - [PyTorch 性能技巧以加速大语言模型训练](ch05/10_llm-training-speed)
- **第6章：分类任务微调**
  - [微调不同层和使用更大模型的额外实验](ch06/02_bonus_additional-experiments)
  - [在 5 万条 IMDb 电影评论数据集上微调不同模型](ch06/03_bonus_imdb-classification)
  - [构建用于与基于 GPT 的垃圾邮件分类器交互的用户界面](ch06/04_user_interface)
- **第7章：微调以遵循指令**
  - [寻找近重复和创建被动语态条目的数据集工具](ch07/02_dataset-utilities)
  - [使用 OpenAI API 和 Ollama 评估指令响应](ch07/03_model-evaluation)
  - [生成用于指令微调的数据集](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/llama3-ollama.ipynb)
  - [改进用于指令微调的数据集](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/reflection-gpt4.ipynb)
  - [使用 Llama 3.1 70B 和 Ollama 生成偏好数据集](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/create-preference-data-ollama.ipynb)
  - [用于大语言模型对齐的直接偏好优化（DPO）](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/dpo-from-scratch.ipynb)
  - [构建与指令微调 GPT 模型交互的用户界面](ch07/06_user_interface)

<br>
&nbsp;

## 问题、反馈及对本仓库的贡献

欢迎各种反馈，最好通过 [Manning 论坛](https://livebook.manning.com/forum?product=raschka&page=1) 或 [GitHub 讨论区](https://github.com/rasbt/LLMs-from-scratch/discussions) 分享。同样，如果您有任何问题或想与他人交流想法，也请随时在论坛中发布。

请注意，由于本仓库包含与印刷书籍对应的代码，目前我无法接受扩展主章节代码内容的贡献，因为这会导致与实体书内容不一致。保持一致有助于确保所有人的顺畅体验。

&nbsp;
## 引用

如果您发现本书或代码对您的研究有帮助，请考虑引用它。

芝加哥格式引用：

> Raschka, Sebastian. *Build A Large Language Model (From Scratch)*. Manning, 2024. ISBN: 978-1633437166.

BibTeX 条目：



```
@book{build-llms-from-scratch-book,
  author       = {Sebastian Raschka},
  title        = {Build A Large Language Model (From Scratch)},
  publisher    = {Manning},
  year         = {2024},
  isbn         = {978-1633437166},
  url          = {https://www.manning.com/books/build-a-large-language-model-from-scratch},
  github       = {https://github.com/rasbt/LLMs-from-scratch}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---