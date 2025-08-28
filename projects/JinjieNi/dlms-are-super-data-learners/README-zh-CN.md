<div align="center">

<!-- TITLE -->
# **扩散语言模型是超级数据学习者**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# 亮点
- 我们从零开始预训练了多达**80亿参数**和**4800亿标记**的DLM和AR模型。DLM表现出比自回归（AR）模型高出**3倍以上**的数据潜力。值得注意的是，一个10亿参数的掩码扩散模型仅使用**10亿**标记，在HellaSwag上实现了超过**56%**的准确率，在MMLU上超过**33%**，无需任何特殊技巧，仅通过重复标准预训练数据。需要注意的是，更多的重复可能进一步提升其性能，因为**未观察到收益递减的迹象**。
- DLM是超密集模型，消耗的FLOPs超过密集的AR模型。训练DLM以充分利用数据通常需要至少**两个数量级**以上的FLOPs。在推理阶段，生成长度从16到4096标记的序列，FLOPs相较于AR基线增加了**16倍到4700倍**。此外，扩散目标启用的更具表现力的双向注意力允许对语言数据进行**双向建模**，语言数据并非完全因果，因此能够充分挤压其价值。
- 我们的同期工作“扩散在数据受限环境中超越自回归”存在关键方法论问题，可能导致有问题的结论，包括**有问题的扩散损失公式、无效的比较指标、不公平的AR模型设置及有问题的规模规律公式。**这些都可能导致结果和结论的可疑性。

<br>

# 交叉点
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*博客图A：在有限数据部分重复训练时，自回归（AR）模型与掩码扩散模型（Diffusion）的性能比较。所有模型均在960亿总标记（包括重复）上训练，唯一标记数量从5亿变化到960亿。扩散模型通过在有限唯一数据上更多重复更好地利用数据。更多唯一标记需要更多重复才能看到交叉点，高唯一标记运行将交叉点推迟到超出我们960亿标记的观察范围。*

<br>

# 引用
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---