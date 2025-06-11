<div align="center">

Megatron-LM 与 Megatron-Core
===========================
<h4>面向大规模训练 Transformer 模型的 GPU 优化技术</h4>

[![Documentation](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![version](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![license](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# 最新动态

- **[2024/7]** Megatron-Core v0.7 提升了可扩展性和训练的鲁棒性，并新增了多模态训练支持（[博客](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)）。
- **[2024/6]** Megatron-Core 增加了对基于 Mamba 模型的支持。请查阅我们的论文 [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) 和 [代码示例](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba)。
- **[2024/1 公告]** NVIDIA 已将 **Megatron-LM** 的核心能力发布为 [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) 并集成于本仓库。Megatron-Core 在 Megatron-LM GPU 优化技术的基础上，拓展了更多前沿的系统级创新，具备可组合和模块化的 API。请参阅 [Megatron-Core 介绍](#megatron-core) 了解更多详情。

# 目录

- [Megatron-LM 与 Megatron-Core](#megatron-lm--megatron-core)
- [最新动态](#最新动态)
- [目录](#目录)
- [Megatron 概述](#megatron-overview)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [训练速度与可扩展性](#training-speed-and-scalability)
- [环境配置](#setup)
  - [Docker（推荐）](#docker-recommended)
  - [安装方式](#installation-options)
    - [通过 PyPI 安装](#install-from-pypi)
    - [源码安装](#install-from-source)
  - [先决条件](#prerequisites)
  - [下载模型检查点](#downloading-checkpoints)
- [使用方法](#usage)
- [训练](#training)
  - [数据预处理](#data-preprocessing)
  - [BERT 预训练](#bert-pretraining)
  - [GPT 预训练](#gpt-pretraining)
  - [T5 预训练](#t5-pretraining)
  - [分布式预训练](#distributed-pretraining)
  - [激活检查点与重计算](#activation-checkpointing-and-recomputation)
  - [分布式优化器](#distributed-optimizer)
  - [FlashAttention](#flashattention)
  - [GPT-3 示例](#gpt-3-example)
  - [Retro 与 InstructRetro](#retro-and-instructretro)
  - [基于 Mamba 的语言模型](#mamba-based-language-models)
  - [专家混合（MoE）](#mixture-of-experts)
- [评测与任务](#evaluation-and-tasks)
  - [GPT 文本生成](#gpt-text-generation)
    - [通过自生成净化 GPT](#detoxify-gpt-via-self-generation)
  - [GPT 评测](#gpt-evaluation)
    - [WikiText 困惑度评测](#wikitext-perplexity-evaluation)
    - [LAMBADA Cloze 准确率](#lambada-cloze-accuracy)
  - [BERT 任务评测](#bert-task-evaluation)
    - [RACE 评测](#race-evaluation)
    - [MNLI 评测](#mnli-evaluation)
  - [Llama-2 推理与微调](#llama-2-inference-and-finetuning)
- [模型优化与部署](#model-optimization-and-deployment)
  - [量化与 TensorRT-LLM 部署](#quantization-and-tensorrt-llm-deployment)
- [数据集](#datasets)
  - [收集 Wikipedia 训练数据](#collecting-wikipedia-training-data)
  - [收集 GPT Webtext 数据](#collecting-gpt-webtext-data)
- [可复现性](#reproducibility)
- [检查点转换](#checkpoint-conversion)
  - [模型类转换](#model-class-conversion)
  - [检查点格式转换](#checkpoint-format-conversion)
- [基于 Megatron 的项目](#projects-using-megatron)

# Megatron 概述
本仓库包含两个核心组件：**Megatron-LM** 和 **Megatron-Core**。Megatron-LM 是面向研究的框架，利用 Megatron-Core 进行大语言模型（LLM）训练。Megatron-Core 则是 GPU 优化训练技术的库，提供正式的产品级支持，包括版本化 API 和定期发布。你可以将 Megatron-Core 与 Megatron-LM 或 [Nvidia NeMo 框架](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) 一起使用，实现端到端及云原生方案。或者，将 Megatron-Core 的构建模块集成到你喜欢的训练框架中。

## Megatron-LM
Megatron 首次于 2019 年提出（[1](https://arxiv.org/pdf/1909.08053.pdf)、[2](https://arxiv.org/pdf/2104.04473.pdf) 和 [3](https://arxiv.org/pdf/2205.05198)），在 AI 社区引发了创新浪潮，使研究人员和开发者能够利用该库的底层技术推动 LLM 的发展。如今，许多流行的 LLM 开发者框架均受 Megatron-LM 开源库启发并直接构建于其之上，推动了基础模型和 AI 创业公司的浪潮。一些基于 Megatron-LM 构建的知名 LLM 框架包括 [Colossal-AI](https://github.com/hpcaitech/ColossalAI)、[HuggingFace Accelerate](https://github.com/huggingface/accelerate) 和 [NVIDIA NeMo 框架](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/)。直接使用 Megatron 的项目列表可见 [此处](#projects-using-megatron)。

## Megatron-Core
Megatron-Core 是一个基于 PyTorch 的开源库，包含 GPU 优化的技术和前沿的系统级优化。它将这些技术抽象为可组合、模块化的 API，赋予开发者和模型研究人员在 NVIDIA 加速计算基础设施上大规模训练自定义 Transformer 的完全灵活性。该库兼容所有 NVIDIA Tensor Core GPU，包括对 [NVIDIA Hopper 架构](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/) 的 FP8 加速支持。

Megatron-Core 提供了核心构建模块，如注意力机制、Transformer 块与层、归一化层和嵌入技术。库中还内置了激活重计算、分布式检查点等功能。所有构建模块和功能均经过 GPU 优化，并可采用先进的并行策略，在 NVIDIA 加速计算基础设施上实现最佳的训练速度和稳定性。Megatron-Core 的另一个关键组成部分是先进的模型并行技术（包括张量、序列、流水线、上下文和 MoE 专家并行）。

Megatron-Core 可与 [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/) 企业级 AI 平台配合使用。你也可以在 [此处](https://github.com/NVIDIA/Megatron-LM/tree/main/examples) 体验 Megatron-Core 与原生 PyTorch 训练循环的集成。欲了解更多信息，请访问 [Megatron-Core 文档](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)。

# 训练速度与可扩展性
我们的代码库能够高效训练大规模语言模型（即参数量达数百亿甚至千亿级的模型），支持模型和数据并行。为了展示我们软件在多 GPU 和不同模型规模下的可扩展性，我们以参数量从 20 亿到 4620 亿的 GPT 模型为例。所有模型均采用 131,072 的词表大小和 4096 的序列长度。通过调整隐藏层大小、注意力头数和层数来获得特定模型规模。随着模型规模的增加，我们也适当增加了批量大小。实验使用了最多 6144 块 [H100](https://www.nvidia.com/en-us/data-center/h100/) GPU。我们在数据并行（`--overlap-grad-reduce --overlap-param-gather`）、张量并行（`--tp-comm-overlap`）及流水线并行通信（默认启用）与计算过程中实现了细粒度重叠，以提高可扩展性。报告的吞吐量为端到端训练的测量值，涵盖包括数据加载、优化器步骤、通信及日志记录在内的所有操作。需注意，这些模型未被训练至收敛。

![Model table](images/model_table.png)

我们的弱扩展（Weak scaling）结果显示出超线性扩展（MFU 从最小模型的 41% 提升至最大模型的 47-48%）；这是由于更大的 GEMM 运算具有更高的算术强度，因此执行效率更高。

![Weak scaling](images/weak_scaling.png)

我们还对标准 GPT-3 模型（由于词表更大，我们的版本参数略多于 1750 亿）进行强扩展（Strong scaling）测试，从 96 块 H100 GPU 扩展到 4608 块 GPU，整个过程中批量大小均为 1152 个序列。在更大规模下通信负载暴露更多，MFU 从 47% 降至 42%。

![Strong scaling](images/strong_scaling.png)

# 环境配置

## Docker（推荐）

我们强烈建议使用 [PyTorch NGC 容器](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) 的上一个版本，而不是最新版。我们的每次发布均基于上一个月的 NGC 容器，这样可以确保兼容性和稳定性。该容器预装了所有依赖且版本兼容，并针对 NVIDIA GPU 进行了优化配置。

```bash
# 拉取上一个月的 NGC 容器（将 25.04 替换为上一个月的版本号）
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# 运行容器并挂载目录
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## 安装方式

### 先决条件

- PyTorch（最新稳定版）
- CUDA、cuDNN、NCCL（最新稳定版）
- 支持 NVIDIA Hopper、Ada 和 Blackwell GPU 上的 FP8
- 为获得最佳性能，建议使用 NVIDIA Turing 及以上架构的 GPU

### 通过 PyPI 安装

使用 pip 安装最新稳定版：

```bash
# 安装最新版本
pip install megatron-core
```

### 源码安装

```bash
# 克隆仓库
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# 可选：检出特定版本
git checkout v0.11.0

# 以开发模式安装
pip install -e .
```

## 下载模型检查点
我们提供了预训练的 [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) 和 [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) 检查点，可用于评估或下游任务微调。获取这些检查点前，请先[注册](https://ngc.nvidia.com/signup)并[配置](https://ngc.nvidia.com/setup/installers/cli) NVIDIA GPU Cloud (NGC) Registry CLI。更多下载模型的文档可见 [NGC 文档](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1)。

另外，你也可以直接使用如下命令下载检查点：

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

运行模型需要词表文件。BERT 的 WordPiece 词表文件可从 Google 的预训练 BERT 模型中提取：[uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt)、[cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt)。GPT 的 [词表文件](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) 和 [合并表](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) 可直接下载。

# 使用方法

安装完成后，有多种工作流程可选。最完整的流程为：
1. 数据预处理
2. 预训练
3. 微调（零样本任务可选）
4. 下游任务评测或文本生成

但步骤 1 和 2 可通过上述预训练模型替代。

我们在 [`examples`](./examples) 目录下提供了 BERT 和 GPT 预训练脚本，以及 MNLI、RACE、WikiText103、LAMBADA 等零样本和微调下游任务的评测脚本。同时也有 GPT 交互式文本生成脚本。

# 训练
## 数据预处理
训练数据需要预处理。首先，将你的训练数据以松散的 json 格式保存，每行一个 json，包含一条文本样本。例如：
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

json 中 `text` 字段名可通过 [`preprocess_data.py`](./tools/preprocess_data.py) 的 `--json-key` 参数修改。其他元数据为可选项，训练时不会用到。

接下来需将松散 json 格式转为训练用的二进制格式。使用 `preprocess_data.py` 脚本可将 json 转为 mmap 格式。以下为 BERT 训练数据准备示例脚本：
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

输出将生成两个文件，如本例为 `my-bert_text_sentence.bin` 和 `my-bert_text_sentence.idx`。后续 BERT 训练时的 `--data-path` 参数填写去除文件扩展名后的完整路径和新文件名。

对于 T5，数据预处理与 BERT 相同，可适当更改前缀名称：
<pre>
       --output-prefix my-t5 \
</pre>
GPT 数据预处理需要进行一些小的修改，即添加合并表（merge table）、文档结束标记（end-of-document token）、去除句子分割（removal of sentence splitting），并更改分词器类型：
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

此处输出文件为 `my-gpt2_text_document.bin` 和 `my-gpt2_text_document.idx`。和之前一样，在 GPT 训练时，使用不带扩展名的长文件名作为 `--data-path`。

更多命令行参数说明详见源码文件 [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py)。

## BERT 预训练

[`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) 脚本可运行单卡 345M 参数的 BERT 预训练。单卡训练主要用于调试，因为代码和参数主要为高并发分布式训练做了优化。大多数参数都比较直观。默认情况下，学习率会在 `--lr-decay-iters` 次迭代内从 `--lr` 线性衰减到由 `--min-lr` 设置的最小值。用于学习率预热的迭代比例由 `--lr-warmup-fraction` 指定。虽然是单卡训练，由 `--micro-batch-size` 指定的 batch size 是单次前向-反向路径的 batch size，代码会执行梯度累积直到达到 `global-batch-size`，即每次迭代的 batch size。数据集默认按 949:50:1 比例分为训练/验证/测试集（默认 969:30:1）。这种划分是动态进行的，但在相同随机种子（默认 1234，可用 `--seed` 指定）下运行结果一致。我们使用 `train-iters` 指定训练迭代次数。也可以通过 `--train-samples` 指定训练样本总数。如果使用此选项，则需要用 `--lr-decay-samples` 代替 `--lr-decay-iters`。

日志、检查点保存和评估间隔等选项都可指定。注意，此时的 `--data-path` 包含了预处理时添加的 `_text_sentence` 后缀，但不包含扩展名。

更多命令行参数说明详见源码文件 [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py)。

运行 `train_bert_340m_distributed.sh` 前，请根据需要修改环境变量 `CHECKPOINT_PATH`、`VOCAB_FILE` 和 `DATA_PATH`，确保这些变量指向容器内的实际路径。然后参考[环境配置](#setup)部分，挂载必要路径后启动容器，并运行示例脚本。

## GPT 预训练

`examples/gpt3/train_gpt3_175b_distributed.sh` 脚本可运行单卡 345M 参数的 GPT 预训练。如上所述，单卡训练主要用于调试，代码为分布式训练优化。

该脚本格式与前述 BERT 脚本基本一致，主要区别有：分词采用 BPE（需提供合并表和 `json` 词表文件），模型结构允许更长序列（注意最大位置嵌入需大于等于最大序列长度），并且 `--lr-decay-style` 设置为 cosine 衰减。注意，`--data-path` 现在包含预处理时添加的 `_text_document` 后缀，但不包含扩展名。

更多命令行参数说明详见源码文件 [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py)。

`train_gpt3_175b_distributed.sh` 的运行方式与 BERT 脚本相同。设置环境变量并做其他所需修改，挂载好路径后启动容器，运行脚本。
详见 [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)。

## T5 预训练

与 BERT 和 GPT 类似，`examples/t5/train_t5_220m_distributed.sh` 脚本可运行单卡“base”级别（约 2.2 亿参数）的 T5 预训练。与 BERT 和 GPT 的主要区别是增加了以下参数以适配 T5 架构：

* `--kv-channels` 设置模型所有注意力机制中“key”和“value”矩阵的内部维度。BERT 和 GPT 默认该值为隐藏层大小除以注意力头数，但 T5 可以自定义。

* `--ffn-hidden-size` 设置 transformer 层中前馈网络的隐藏层大小。BERT 和 GPT 默认为 transformer 隐藏层的 4 倍，T5 可自定义。

* `--encoder-seq-length` 和 `--decoder-seq-length` 分别设置编码器和解码器的序列长度。

其余参数与 BERT、GPT 预训练相同。运行示例同前述脚本。

详见 [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)。

## 分布式预训练

`pretrain_{bert,gpt,t5}_distributed.sh` 脚本使用 PyTorch 的分布式启动器进行分布式训练。因此，只需正确设置环境变量即可实现多节点训练。更多关于这些[环境变量](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization)的说明请参考 PyTorch [官方文档](https://pytorch.org/docs/stable/elastic/run.html#launcher-api)。默认情况下，多节点训练使用 [nccl](https://developer.nvidia.com/nccl) 分布式后端。只需添加一组简单参数并使用 PyTorch 分布式模块的 `torchrun` 弹性启动器（等价于 `python -m torch.distributed.run`），即可实现分布式训练。具体见任一 `pretrain_{bert,gpt,t5}_distributed.sh`。

我们使用两种并行方式：数据并行和模型并行。数据并行由 `megatron/core/distributed` 实现，通过 `--overlap-grad-reduce` 命令行选项可支持梯度规约与反向传播重叠。

此外，我们开发了一种高效的二维模型并行方法。要使用第一维（张量模型并行，将单个 transformer 模块的计算拆分到多卡，详见[论文第3节](https://arxiv.org/pdf/1909.08053.pdf)），可添加 `--tensor-model-parallel-size` 参数指定分模型用的 GPU 数，并配合上述分布式启动器参数。要使用第二维（序列并行），需指定 `--sequence-parallel`，且必须启用张量模型并行（详见[论文 4.2.2 节](https://arxiv.org/pdf/2205.05198.pdf)）。

如需使用流水线模型并行（将 transformer 模块分成多个 stage，每个 stage 包含相同数量 transformer 模块，通过将 batch 划分为更小的 microbatch 实现流水线，详见[论文 2.2 节](https://arxiv.org/pdf/2104.04473.pdf)），可使用 `--pipeline-model-parallel-size` 参数指定分 stage 数。例如，将 24 层 transformer 分为 4 个 stage，每 stage 分配 6 层。

我们在脚本名以 `distributed_with_mp.sh` 结尾的示例中提供了这两种模型并行用法的例子。

除此之外，分布式训练与单卡训练基本一致，仅有上述小差异。

交错流水线调度（详见[论文 2.2.2 节](https://arxiv.org/pdf/2104.04473.pdf)）可通过 `--num-layers-per-virtual-pipeline-stage` 参数开启。该参数控制虚拟 stage 的 transformer 层数（默认非交错调度下，每卡执行单一虚拟 stage，包含 `NUM_LAYERS / PIPELINE_MP_SIZE` 层）。transformer 层总数应能被该参数整除。且当使用交错调度时，流水线中的 microbatch 数（即 `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`）应能被 `PIPELINE_MP_SIZE` 整除（代码会断言检查）。交错调度不支持 2 个 stage 的流水线（`PIPELINE_MP_SIZE=2`）。

## 激活检查点与重计算

为降低大模型训练时的显存占用，我们支持多种激活检查点与重计算方式。传统深度学习模型中，所有激活值都存储于内存以供反向传播使用；而通过激活检查点，仅在模型的特定“检查点”处保留激活，其他激活在反向传播时按需重新计算。注意，这里的*激活*检查点，与模型参数和优化器状态的检查点完全不同。

我们支持两种重计算粒度：`selective`（选择性）和 `full`（完全）。选择性重计算为默认选项，且几乎在所有情况下推荐使用。该模式会保留内存占用较小且重计算开销大的激活，仅重计算占用大但重计算便宜的激活。详见[论文](https://arxiv.org/pdf/2205.05198)。你会发现该模式最大化了性能且最小化了激活存储需求。启用选择性激活重计算只需加 `--recompute-activations`。

若显存极为有限，可用 `full` 重计算，只保存 transformer 层（或一组/一块 transformer 层）的输入激活，其他全部重算。启用完全激活重计算用 `--recompute-granularity full`。此时有两种方法：`uniform` 和 `block`，通过 `--recompute-method` 指定。

* `uniform` 方法将 transformer 层均匀分组（每组大小由 `--recompute-num-layers` 指定），仅保存各组输入激活。基线组大小为 1，此时每层输入激活都会存储。当显存不足时，增大每组层数可进一步节省内存，从而能训练更大模型。例如，`--recompute-num-layers` 设为 4 时，每 4 层存一次输入激活。

* `block` 方法在每个流水线 stage 内对指定数量（由 `--recompute-num-layers` 指定）的 transformer 层做重计算，其余层输入激活直接存储。减小 `--recompute-num-layers` 意味着存储更多层输入激活，减少重计算，从而提升训练性能但增加内存占用。例如，每个 stage 8 层，指定 5 层重算，则前 5 层激活反向时重算，后 3 层激活直接存储。`--recompute-num-layers` 可递增调整，直到刚好适配内存，这样可最大化利用显存和性能。

## 分布式优化器

用法：`--use-distributed-optimizer`。兼容所有模型和数据类型。

分布式优化器是一种节省内存的技术，它将优化器状态均匀分布在数据并行 rank 上（传统方式是每个数据并行 rank 全量复制优化器状态）。如 [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054) 所述，我们的实现会分布所有与模型状态无重叠的优化器状态。例如，使用 fp16 模型参数时，分布式优化器会为 fp32 主参数和梯度单独维护一份，并分布在 DP ranks 上。若用 bf16 模型参数，分布式优化器的 fp32 主梯度与模型的 fp32 梯度完全一致，因此此时梯度不会分布（但 fp32 主参数仍分布，因为它们和 bf16 模型参数分开）。

理论内存节省效果取决于模型参数类型和梯度类型的组合。在我们的实现中，每参数理论占用字节数如下（d 为数据并行大小）：

| | 非分布式优化器 | 分布式优化器 |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

如同普通数据并行，使用 `--overlap-grad-reduce` 可实现梯度规约（此处为 reduce-scatter）与反向传播重叠。此外，参数 all-gather 可通过 `--overlap-param-gather` 与前向传播重叠。

## FlashAttention

用法：`--use-flash-attn`。支持的 attention head 维度最大为 128。

[FlashAttention](https://github.com/HazyResearch/flash-attention) 是一种快速且节省显存的精确 attention 计算算法。它可加速模型训练并降低显存需求。

安装 FlashAttention：
```sh
pip install flash-attn
```

## GPT-3 示例

`examples/gpt3/train_gpt3_175b_distributed.sh` 提供了使用 Megatron 训练 1750 亿参数 [GPT-3](https://arxiv.org/abs/2005.14165) 的配置示例，支持 1024 卡并行。该脚本为 [slurm](https://slurm.schedmd.com/documentation.html) + [pyxis](https://github.com/NVIDIA/pyxis) 插件设计，也可适配其它调度器。它使用 8 路张量并行和 16 路流水线并行。通过 `global-batch-size 1536` 和 `rampup-batch-size 16 16 5859375`，训练会从全局 batch size 16 线性增至 1536，步长为 16，跨度 5,859,375 个样本。训练集既可以是单一数据集，也可以是多个数据集按权重组合。

在 1024 张 A100 上，batch size 1536 时每次迭代约 32 秒，每卡 138 teraFLOPs，约为理论峰值 FLOPs 的 44%。

## Retro 和 InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) 是一种自回归解码器语言模型（LM），通过检索增强进行预训练。Retro 可扩展到支持万亿级 token 的大规模预训练。基于检索的预训练，为事实性知识提供了更高效的存储机制，相比将知识隐式存储在网络参数中，显著减少模型参数量，并获得比标准 GPT 更低的困惑度。Retro 还可通过更新检索库，在无需重新训练 LM 的情况下，灵活更新模型知识 [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)。

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) 进一步将 Retro 扩展到 480 亿参数，成为截至 2023 年 12 月为止最大的检索增强预训练 LLM。Retro 48B 基础模型在困惑度上大幅超越同级别的 GPT。经过指令微调后，InstructRetro 在零样本下游任务上显著优于指令微调的 GPT，短文本 QA 提升 7%，长文本 QA 提升 10%。我们还发现，可以在 InstructRetro 架构中去除编码器，直接用 InstructRetro 解码器作为 GPT，依然能获得相近效果。

本仓库提供了 Retro 与 InstructRetro 的端到端复现指南，涵盖
- **检索库构建**，支持十亿甚至万亿 token 级超大规模检索库。
- **基于检索的预训练**，支持从头预训练或基于已训练 GPT 进行 Retro-fitting。
- **指令微调**，开放指令微调数据集和训练方案。
- **下游任务评估**，提供零样本 QA 的文本生成和评测脚本。

详见 [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md)。

## 基于 Mamba 的语言模型

详见 [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba)。

<!--
## REALM 流水线
我们正在实现 [REALM](https://arxiv.org/pdf/2002.08909.pdf) 系统。下述部分（将）涵盖其三阶段训练流程。目前仅有 ICT 代码。
大致为：先预训练检索器模块，再联合训练语言模型和检索器，最后在固定检索器下微调问答头。

### Inverse Cloze Task (ICT) 预训练
1. 用松散 JSON 格式准备语料，目的是将文本分块为固定大小的 block，作为数据的基本单元。以 Wikipedia 为例，每个 block 通常含多句，但每份文档可含多个 block。
运行 `tools/preprocess_data.py`，用 `--split-sentences` 让句子为基本单位，构建一个或多个索引数据集。REALM 原系统中，我们分别构建了文档标题和正文两个数据集。
示例脚本如下：
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # 适合 10 核 CPU，可根据实际扩展
</pre>

2. 若需自定义样本映射函数，可替换 `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping`。需在 `megatron/core/datasets/helpers.cpp` 中用 C++ 实现新函数。样本映射数据结构用于提前选定每个训练样本所需数据。
 该映射负责持有构建样本所需的全部元数据（如起止句索引、文档索引以获取标题、每个 block 的唯一 ID）。
3. 用 `pretrain_bert.py` 预训练 BERT 语言模型，序列长度等于 token id 的 block 大小。此模型应在与检索任务 block 数据相同的索引数据集上训练。
REALM 中为 uncased bert base，标准超参数。
4. 用 `pretrain_ict.py` 训练 ICTBertModel。该模型用双 BERT 编码器分别编码 query 和 block，实现检索。
下例训练 REALM 的 ICT 模型，`--bert-load` 参数引用第三步预训练好的 BERT。论文中的 batch size 为 4096，因此需用数据并行世界大小 32。
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### 构建 Block Embedding 索引
完成 ICT 训练后，可通过创建 `BlockData` 结构体对完整数据集的 block 进行 embedding。保存后，可以用 `FaissMIPSIndex` 包装加载，实现高效相似度搜索，是检索流水线的关键。初始索引可用如下脚本（交互式运行），可利用多卡多节点加速大数据集索引构建。

<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /path/to/pretrained_ict \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /path/to/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## 专家混合（Mixture of Experts, MoE）
MoE（专家混合）是一种在 Megatron-Core 框架中实现的强大 LLM 架构，旨在提升大语言模型的效率和可扩展性。它利用了**专家并行**，允许多个专家分布在不同的计算节点上，每个节点处理不同批次的训练样本。此方法显著提升了计算吞吐量，使模型能够实现高性能指标，例如在 H100 上 8x7B 的 BF16 训练期间达到 47% MFU。

MoE 主要特性包括：
- **并行技术**：MoE 结合了多种并行策略，包括专家并行、数据并行、张量并行、序列并行、流水线并行和上下文并行。这种组合可以有效处理更大规模的模型变体。
- **路由与负载均衡**：系统采用先进的路由机制（如 Top-K 路由器）并利用负载均衡算法，实现专家间的最优 Token 分配。
- **性能优化**：如 GroupedGEMM 和 FP8 训练等技术，提升了 MoE 模型的效率，尤其是在涉及多个专家时。
- **Token 分发机制**：MoE 支持无丢失（dropless）和 Token 丢弃（token drop）两种策略，有效管理跨专家的 Token 分发。

有关 MoE 训练配置和优化的详细介绍，请参阅 [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md)。

# 评测与任务

我们为多种零样本和微调下游任务提供了命令行参数（详见下方脚本），当然你也可以基于预训练检查点在其他语料上继续微调。只需添加 `--finetune` 标志，并调整原始训练脚本中的输入文件与训练参数即可。迭代次数会重置为零，优化器和内部状态会重新初始化。如果微调过程中中断，请务必在继续前移除 `--finetune` 标志，否则训练将从头重新开始。

由于评测阶段所需显存远小于训练阶段，因此可以将并行训练的模型合并，以便在下游任务中用更少的 GPU 进行推理。下面的脚本即可实现这一目标。示例中，将一个采用 4 路张量并行和 4 路流水线并行的 GPT 模型，合并为 2 路张量并行和 2 路流水线并行的模型。

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

以下分别介绍了 GPT 和 BERT 模型的若干下游任务。它们可使用与训练脚本相同的分布式与模型并行方式运行。

## GPT 文本生成

我们在 `tools/run_text_generation_server.py` 中提供了一个简单的 REST 服务端用于文本生成。其运行方式与启动预训练任务类似，需指定合适的预训练检查点。还可以设置一些可选参数：`temperature`、`top-k` 和 `top-p`。更多信息请参见 `--help` 或源码文件。关于如何运行服务端的示例，请参考 [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh)。

服务端运行后，可用 `tools/text_generation_cli.py` 查询服务，仅需传入服务运行主机作为参数。

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

你也可以直接用 CURL 或其他工具访问服务端：

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

更多 API 选项请见 [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py)。

### 通过自生成方式净化 GPT
我们在 `examples/academic_paper_scripts/detxoify_lm/` 提供了一个利用语言模型生成能力对模型进行净化的示例。

有关如何进行领域自适应训练及基于自生成语料净化语言模型的分步教程，请参阅 [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md)。

## GPT 评测
我们提供了 GPT 在 WikiText 困惑度和 LAMBADA Cloze 准确率评测的示例脚本。

### WikiText 困惑度评测
为与先前工作公平对比，我们在词级 [WikiText-103 测试集](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip) 上评测困惑度，并在采用子词分词器时适当调整 Token 相关计算。

以下命令用于在 3.45 亿参数模型上运行 WikiText-103 评测：

<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext 路径&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

### LAMBADA Cloze 准确率
为计算 LAMBADA cloze 准确率（即给定前文预测最后一个 Token 的准确率），我们采用了 [LAMBADA 数据集](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl) 的去分词、预处理版本。

下面命令用于在 3.45 亿参数模型上运行 LAMBADA 评测。注意：需使用 `--strict-lambada` 参数以强制全词匹配。确保文件路径中包含 `lambada`。

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada 路径&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;同上方<a href="#wikitext-perplexity-evaluation">WikiText 困惑度评测</a>参数&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

更多命令行参数说明详见源文件 [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## BERT 任务评测
### RACE 评测
以下脚本用于微调 BERT 模型并在 [RACE 数据集](http://www.cs.cmu.edu/~glai1/data/race/) 上评测。`TRAIN_DATA` 和 `VALID_DATA` 目录需包含分别存放 RACE 的 `.txt` 文件。注意：RACE 的 batch size 是指需评测的 RACE 查询数。每个 RACE 查询有四个样本，因此实际进入模型的 batch size 是命令行设置的四倍。

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### MNLI 评测
以下脚本用于微调 BERT 模型并在 [MultiNLI 句子对语料](https://www.nyu.edu/projects/bowman/multinli/) 上评测。由于匹配任务非常相似，脚本可简单调整后用于 [Quora 问题对](https://www.kaggle.com/quora/question-pairs-dataset)（QQP）数据集。

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;同上方<a href="#race-evaluation">RACE 评测</a>参数&#62;
COMMON_TASK_ARGS_EXT=&#60;同上方<a href="#race-evaluation">RACE 评测</a>参数&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## Llama-2 推理与微调

Llama-2 [模型家族](https://ai.meta.com/llama/) 是一组开源的预训练及微调（用于聊天）模型，在众多基准测试中取得了优异的成绩。在发布时，Llama-2 模型在开源模型中表现最佳，并且与闭源的 GPT-3.5 模型具有竞争力（见 https://arxiv.org/pdf/2307.09288.pdf）。

Llama-2 的 checkpoint 可以在 Megatron 中加载，用于推理和微调。详见[文档](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md)。

# 模型优化与部署
Megatron-Core（MCore）`GPTModel` 系列支持高级量化算法，并可通过 TensorRT-LLM 实现高性能推理。

## 量化与 TensorRT-LLM 部署
关于 `llama2` 和 `nemotron3` 的示例，请参见 [Megatron 模型优化与部署](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/quantization/README.md)。

# 数据集
我们不托管任何用于 GPT 或 BERT 训练的数据集，但我们详细说明了数据集的收集过程，以便复现我们的实验结果。

## 维基百科训练数据收集
我们建议按照 Google Research 指定的维基百科数据提取流程进行操作：“推荐的预处理是下载[最新的数据包](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2)，用 [WikiExtractor.py](https://github.com/attardi/wikiextractor) 提取文本，然后进行必要的清理以转为纯文本。”

建议在使用 WikiExtractor 时添加 `--json` 参数，这将以松散的 json 格式（每行为一个 json 对象）导出维基百科数据，便于文件系统管理，并可直接供我们的代码库使用。建议用 nltk 进行标点标准化来进一步预处理该 json 数据集。对于 BERT 训练，使用 `preprocess_data.py` 的 `--split-sentences` 标志（如[上文](#data-preprocessing)所述），以便在生成的索引中包含句子断句。如果用于 GPT 训练，仍需用 nltk/spacy/ftfy 清理，但不要使用 `--split-sentences` 标志。

## GPT Webtext 数据收集
我们使用 [jcpeterson](https://github.com/jcpeterson/openwebtext) 和 [eukaryote31](https://github.com/eukaryote31/openwebtext) 发布的 [OpenWebText](https://github.com/eukaryote31/openwebtext) 库来下载 url。随后我们根据 [openwebtext](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/openwebtext) 目录下描述的流程对所有下载内容进行过滤、清理和去重。对于截至 2018 年 10 月的 reddit URL，我们获得了约 37GB 的内容。

# 可复现性
Megatron 训练可实现比特级可复现；启用此模式请使用 `--deterministic-mode`。这意味着在相同的硬件和软件环境下，使用相同训练配置运行两次，应产生完全相同的模型 checkpoint、损失值和准确率指标（迭代时间指标可能有差异）。

目前已知有三项 Megatron 优化会影响可复现性，但仍能产生几乎一致的训练过程：
1. all-reduce 过程中所用的特定 NCCL 算法（由环境变量 `NCCL_ALGO` 指定）很重要。我们测试了如下算法：`^NVLS`、`Tree`、`Ring`、`CollnetDirect`、`CollnetChain`。代码允许使用 `^NVLS`，此时 NCCL 可选择非 NVLS 算法，且选择较为稳定。
2. Flash attention 是非确定性的；不要使用 `--use-flash-attn`。
3. 如果使用 Transformer Engine，还必须设置环境变量 `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0`。

此外，确定性仅在 NGC PyTorch 容器 23.12 及更新版本中验证通过。如果你在其他情况下发现 Megatron 训练非确定性问题，请提交 issue。

# Checkpoint 转换

我们支持两种模型转换形式：

1. 模型类转换（即 `model.legacy` 中的 `GPTModel` 与 `model.core` 中的 `GPTModel` 之间的转换）
2. Checkpoint 格式转换（即分布式与非分布式 checkpoint 之间的转换）

## 模型类转换

Megatron 支持不同模型类之间的转换，包括内部模型类（目前有较早的 `legacy` 模型和较新的 `core` 模型）以及外部模型类（如 Meta、Huggingface、Mistral 和 Mixtral 模型）。此外，在转换过程中可更新模型的并行状态（即更改张量和流水线模型并行度）。

我们提供了 `tools/checkpoint/convert.py` 工具用于模型类之间的转换。部分重要参数如下：

- `--model-type`：`GPT` 或 `BERT`
- `--loader`：现有 checkpoint 的格式。支持如下格式：
  - `legacy`：我们早期的模型类（位于 `megatron.legacy.model`）
  - `core`：我们新的模型类（位于 `megatron.core.models`）
  - `llama_mistral`：用于加载 Llama 和 Mistral 模型（支持 Meta 和 Huggingface 格式）
  - `mixtral_hf`：用于加载 Mixtral 模型（仅支持 Huggingface）
- `--load-dir`：现有 checkpoint 的加载目录
- `--saver`：`legacy` 或 `core`（见上方 `--loader` 描述）
- `--save-dir`：保存新 checkpoint 的目录
- `--target-tensor-parallel-size`：目标张量模型并行度
- `--target-pipeline-parallel-size`：目标流水线模型并行度

更多参数详情请参阅主脚本（`convert.py`）、加载脚本（`loader_core.py`、`loader_legacy.py`、`loader_llama_mistral.py`、`loader_mixtral_hf.py`）或保存脚本（`saver_core.py`、`saver_legacy.py`）。

将 GPT 模型从旧格式（`legacy`）转换为新格式（`core`）的示例命令如下：

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

关于 Llama/Mistral 模型转换为 Megatron 的示例，请参见[此处](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/docs/llama_mistral.md)。

## Checkpoint 格式转换

Megatron 提供多种 checkpoint 格式，包括：

- `torch`：基本 checkpoint 格式，顺序读写，并与特定的张量/流水线模型并行状态（TP/PP 状态）绑定。（虽然某个 checkpoint 与特定 TP/PP 状态绑定，但仍可通过上述模型类转换工具手动转换。）
- `torch_dist`：分布式 checkpoint 格式，支持高速并行读写，并且与并行状态无关（即可加载到不同的 TP/PP 设置）。

一般而言，`torch_dist` 是更现代且推荐的 checkpoint 格式，因其速度更快。但根据实际需求，可能需要在这两种格式间转换。方法是像平时那样启动你的 *训练* 脚本（如 `pretrain_gpt.py`），并额外加上两个参数：

- `--ckpt-convert-format ${FORMAT}`：`${FORMAT}` 可为上述的 `torch` 或 `torch_dist`。
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`：该路径应与现有的 `--load`/`--save` 路径不同，以避免覆盖原有 checkpoint。转换后，请用新路径作为 `--load`/`--save` 路径。

该 checkpoint 格式转换器的基本思路是，像正常训练一样启动模型，但在运行任何训练迭代之前，先保存为新格式的 checkpoint，然后退出。需要注意的是，其他所有启动参数应保持不变，以便系统理解原有 checkpoint 格式。

# 使用 Megatron 的项目
以下是一些直接使用 Megatron 的项目：
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE 阅读理解数据集排行榜](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---