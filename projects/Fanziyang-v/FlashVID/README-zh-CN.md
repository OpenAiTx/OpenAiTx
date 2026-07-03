# FlashVID：通过无训练树状时空令牌合并实现高效视频大语言模型

<div align="center">
<a href="https://scholar.google.com/citations?user=myU7V58AAAAJ&hl=en">范子阳</a><sup>1</sup>,&nbsp; <a href="https://github.com/Mirei124">陈可昱</a><sup>1</sup>,&nbsp; <a href="https://github.com/xrlexpert">邢睿龙</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=dQssXVsAAAAJ&hl=en">李宇林</a><sup>1</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=5cIodxsAAAAJ&hl=en">姜立</a><sup>2,3</sup>,&nbsp; <a href="https://scholar.google.com/citations?user=mEjhz-IAAAAJ&hl=en">田卓涛</a><sup>1,3*</sup>&nbsp;
<br>
<sup>1</sup> 哈尔滨工业大学（深圳） &nbsp;&nbsp;&nbsp; <sup>2</sup> 香港中文大学（深圳）<br> <sup>3</sup> 深圳环区研究院
<br>
<sup>*</sup>通讯作者
<br>
<a href='https://iclr.cc/'><img src='https://img.shields.io/badge/ICLR-2026-78CA2E.svg'></a> &nbsp;
<a href='https://openreview.net/forum?id=H6rDX4w6Al'><img src='https://img.shields.io/badge/Paper-Openreview-8D1B12.svg'></a> &nbsp;
<a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License"></a> &nbsp;
<a href='https://fanziyang-v.github.io/FlashVID/'><img src='https://img.shields.io/badge/Project-Page-Green'></a> &nbsp;
<a href="https://arxiv.org/abs/2602.08024"><img src="https://img.shields.io/badge/arXiv-2602.08024-b31b1b.svg"></a> &nbsp;
<a href="https://huggingface.co/"><img src="https://img.shields.io/badge/transformers-4.57-FFD21E.svg" alt="transformers"></a> &nbsp;
<!-- <a href="https://python.org/"><img src="https://img.shields.io/badge/Python-3.10%2B-3776ab.svg" alt="Python"></a> &nbsp; -->
<!-- <a href="https://pytorch.org/"><img src="https://img.shields.io/badge/PyTorch-2.5%2B-DF3411.svg" alt="PyTorch"></a> &nbsp; -->
<!-- <a href="#"><img src="https://img.shields.io/badge/#.svg"></a> &nbsp; -->
</div>

## 🔖目录

1. [新闻](#news)
2. [待办事项](#todo-list)
3. [亮点](#highlights)
4. [动机](#motivation)
5. [方法](#method)
6. [安装](#installation)
7. [快速开始](#quickstart)
8. [评估](#evaluation)
9. [致谢](#acknowledgement)
10. [引用](#citation)

## 🔥新闻

- [2026.05.01] 🔍修复Qwen2.5-VL和Qwen3-VL中手动提取[CLS]注意力时的潜在OOM错误。
- [2026.02.10] 🚀在arXiv发布我们的论文。
- [2026.02.06] 🍾我们的论文被选为**ICLR 2026**的**口头报告**。
- [2026.02.01] ✨发布基于*Qwen2.5-VL*和*Qwen3-VL*的FlashVID代码及推理演示。
- [2026.01.31] 🚀公开发布此代码库。
- [2026.01.30] ✨发布 *LLaVA-OneVision* 和 *LLaVA-Video* 上的 FlashVID 代码和推理演示。
- [2026.01.30] 👏初始化本 GitHub 仓库。
- [2026.01.26] 🎉我们的无训练推理加速方法 [FlashVID](https://openreview.net/forum?id=H6rDX4w6Al) 已被 **ICLR 2026** 接收。
- [2025.12.06] 🌟发布 [DyTok](https://github.com/yu-lin-li/DyToK) 的 GitHub 仓库。
- [2025.09.18] 🎉 我们的无训练推理加速框架 [DyTok](https://www.arxiv.org/abs/2512.06866) 已被 **NeurIPS 2025** 接收。

## 📋待办事项

- [ ] 优化代码效率
- [x] 发布 LLaVA-OneVision 和 LLaVA-Video 上的 FlashVID 代码。
- [x] 发布基于 FlashVID 的不同视频大语言模型推理演示。
- [x] 支持使用 [LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval) 进行评估。
- [x] 发布 Qwen2.5-VL 和 Qwen3-VL 上的 FlashVID 代码。
- [x] 在 arXiv 上发布我们的论文。

## ✨亮点

![FlashVID Teaser](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/teaser.png)

1. 我们的 FlashVID 在 **三个** 代表性的视频大语言模型（即 LLaVA-OneVision、LLaVA-Video、Qwen2.5-VL）和 **五个** 广泛使用的视频理解基准（即 VideoMME、EgoSchema、LongVideoBench、MVBench、MLVU）上，显著优于之前的最先进加速框架（如 VisionZip、FastVID）。
2. FlashVID 可以作为一个无训练且即插即用的模块，用于扩展长视频帧输入，使 Qwen2.5-VL 的视频帧输入量提升 **10 倍**，在相同计算预算下实现 **8.6%** 的性能提升。
3. 现有高效视频大语言模型方法通常独立压缩空间和时间冗余，忽视了视频内在的时空关系。为此，我们提出了一个 **简单而有效** 的解决方案：基于树的时空令牌合并（TSTM），用于细粒度的时空冗余压缩。

## 💡动机

![Motivation](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/motivation.png)

在本工作中，我们发现视频时空冗余有两个关键观察：

1. **时间冗余不局限于固定的空间位置。** 视频中语义一致的元素由于运动和场景动态，常在空间位置、尺度或外观上发生变化，使得跨帧的刚性空间对应不可靠。
2. **空间和时间冗余本质上是耦合的。** 单帧内的冗余区域常在多帧中持续存在。分离的时空冗余压缩忽视了内在的时空关系，导致压缩效果不佳。

为了实现更好的时空冗余压缩，我们提出了一个 **简单而有效** 的解决方案：**基于树的时空令牌合并（TSTM）**，用于细粒度时空冗余压缩，并辅以 **基于注意力与多样性的令牌选择（ADTS）** 模块以选择信息丰富的令牌。

## 🌈方法

![Method](https://raw.githubusercontent.com/Fanziyang-v/FlashVID/main/assets/method.png)

**FlashVID 说明**。我们通过两个协同模块压缩视觉令牌。

1. **基于注意力和多样性的令牌选择（ADTS）** 优先选择时空信息丰富的令牌，同时通过求解校准的最大最小多样性问题（MMDP）确保特征多样性；  
2. **基于树的时空令牌合并（TSTM）** 通过时空冗余树建模冗余，有效捕捉细粒度视频动态。每个冗余树将被聚合为单个令牌表示。  


## 📦安装  

在本项目中，我们使用 [uv](https://github.com/astral-sh/uv) 进行包管理。  

1. **克隆此仓库并进入 FlashVID 文件夹：**

```bash
git clone https://github.com/Fanziyang-v/FlashVID.git
cd FlashVID
```

2. **安装推理包：**

```bash
uv sync
```

## 🚀快速开始

FlashVID 的代码易于使用，开箱即用。只需用 `flashvid()` 函数包装模型即可。目前，FlashVID 支持 LLaVA-OneVision、LLaVA-Video、Qwen2.5-VL 和 Qwen3-VL。

```python
from flashvid import flashvid

model = flashvid(
    model,
    retention_ratio=0.1,
    alpha=0.7,
    temporal_threshold=0.8,
)
```

📝**注意**：您可以在 `flashvid()` 包装函数中覆盖默认参数（例如，保留比例）。

推理演示在 `playground/` 中提供。以下是一个运行示例：

```bash
python playground/llava_ov_infer.py \
    --video-path assets/Qgr4dcsY-60.mp4 \
    --question "Describe the video in detail." \
    --num-frames 32 \
    --enable-flashvid
```

## 📊评估

在本项目中，所有实验均使用[LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval)进行。我们在`scripts/`中提供了FlashVID评估脚本，包括LLaVA-OneVision、LLaVA-Video、Qwen2.5-VL和Qwen3-VL。您可以运行这些脚本来复现我们的实验结果：

```bash
bash scripts/llava_ov.sh
```

📝**注意**：通过在`__init__()`中添加特定参数并用`flashvid()`函数包装加载的模型，将FlashVID集成到LMMs-Eval中非常简单。（参见`lmms_eval/models/simple/llava_onevision.py`）

## 👏致谢

本项目基于以下近期开源工作构建：[FastV](https://github.com/pkunlp-icler/FastV)、[VisionZip](https://github.com/dvlab-research/VisionZip)、[PruneVID](https://github.com/visual-ai/prunevid)、[FastVID](https://github.com/LunarShen/FastVID)、[LLaVA-NeXT](https://github.com/LLaVA-VL/LLaVA-NeXT)、[Qwen2.5-VL/Qwen3-VL](https://github.com/QwenLM/Qwen3-VL)、[LMMs-Eval](https://github.com/EvolvingLMMs-Lab/lmms-eval)。感谢他们的卓越工作！

## 📜引用

如果您在研究中发现本项目有用，请考虑引用：

```bib
@inproceedings{
    fan2026flashvid,
    title={Flash{VID}: Efficient Video Large Language Models via Training-free Tree-based Spatiotemporal Token Merging},
    author={Ziyang Fan and Keyu Chen and Ruilong Xing and Yulin Li and Li Jiang and Zhuotao Tian},
    booktitle={The Fourteenth International Conference on Learning Representations},
    year={2026},
    url={https://openreview.net/forum?id=H6rDX4w6Al}
}
```

## ⭐️Star History

[![Star History Chart](https://api.star-history.com/svg?repos=Fanziyang-v/FlashVID&type=Date)](https://star-history.com/#Fanziyang-v/FlashVID&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---