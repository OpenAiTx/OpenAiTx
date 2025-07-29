# 语言模型真的对时间序列预测有用吗？

**（NeurIPS 2024 Spotlight）** 🌟 [论文链接](https://arxiv.org/pdf/2406.16964)

在这项工作中，我们展示了尽管大语言模型（LLMs）在时间序列预测（TSF）中最近很受欢迎，但它们似乎并未显著提升性能。我们提出了一个简单的基线方法“PAttn”，其表现优于大多数基于LLM的TSF模型。

作者：[Mingtian Tan](https://x.com/MTTan1203),[Mike A. Merrill](https://mikemerrill.io/),[Vinayak Gupta](https://gvinayak.github.io/),[Tim Althoff](https://homes.cs.washington.edu/~althoff/),[Thomas Hartvigsen](https://www.tomhartvigsen.com/)

### 自回归LLM在利用上下文推理（预测）未来时间序列方面具有巨大潜力。本文提及的时间序列预测模型则没有。

关于通过文本推理（预测）时间序列，可以参考这项[时间序列推理（预测）工作](https://github.com/behavioral-data/TSandLanguage/tree/main/text_aid_forecast)。

## 概览 💁🏼
近年来，时间序列分析领域越来越多地关注将预训练大型语言模型（LLMs）适配于**预测（TSF）**、分类和异常检测。这些研究表明，设计用于文本中序列依赖的语言模型，可能能够推广到时间序列数据。虽然这一想法与语言模型在机器学习中的流行相符，但语言建模与TSF之间的直接联系仍不清晰。**语言模型对传统TSF任务到底有多大帮助？**

通过对三种最新的**基于LLM的TSF**方法进行一系列消融实验，我们发现**去除LLM组件或用简单的注意力层替代，结果并未变差——在很多情况下甚至有所提升。**此外，我们提出了PAttn，展示了补丁和注意力结构可以达到与最先进的基于LLM的预测器相当的性能。

![Ablations/PAttn](https://raw.githubusercontent.com/BennyTMT/LLMsForTimeSeries/main/pic/ablations.png)

## 数据集 📖
你可以从[Google Drive](https://drive.google.com/file/d/1NF7VEefXCmXuWNbnNe858WvQAkJ_7wuP/view)获取已预处理好的数据集，然后将下载的内容放置到 ./datasets 目录下。

## 环境搭建 🔧
我们在消融实验中包含了三种流行的基于LLM的TSF方法。你可以分别参考对应的仓库，[OneFitsAll](https://github.com/DAMO-DI-ML/NeurIPS2023-One-Fits-All)、[Time-LLM](https://github.com/KimMeen/Time-LLM) 和 [CALF](https://github.com/Hank0626/CALF)，以搭建相应环境。对于 **“PAttn”** 方法，以上任一仓库的环境均兼容。

## PAttn 🤔
**PAttn** 与 [PatchTST](https://github.com/yuqinie98/PatchTST) 的主要区别在于，我们逐步去除了Transformer模块中可能不太必要的部分以及位置嵌入。更多解释请参见[此回复](https://github.com/BennyTMT/LLMsForTimeSeries/issues/7)。

**动机**：当[DLinear](https://github.com/cure-lab/LTSF-Linear)已被许多新方法超越时，我们旨在提供一种基于补丁的简单且有效的方法，作为一个简单的基线。

     cd ./PAttn 

     bash ./scripts/ETTh.sh (适用于 ETTh1 & ETTh2)
     bash ./scripts/ETTm.sh (适用于 ETTm1 & ETTm2)
     bash ./scripts/weather.sh (适用于 Weather)
     
#### 对于其他数据集，请更改上述命令中的脚本名称。

## 消融实验
     
#### 在 CALF (ETT) 上运行消融：
     
    cd ./CALF
    sh scripts/long_term_forecasting/ETTh_GPT2.sh
    sh scripts/long_term_forecasting/ETTm_GPT2.sh
    
    sh scripts/long_term_forecasting/traffic.sh 
    （适用于其他数据集，如 traffic）

#### 在 OneFitsAll (ETT) 上运行消融：
     cd ./OFA
     bash ./script/ETTh_GPT2.sh   
     bash ./script/ETTm_GPT2.sh

     bash ./script/illness.sh 
     （适用于其他数据集，如 illness）

#### 在 Time-LLM (ETT) 上运行消融
     cd ./Time-LLM-exp
     bash ./scripts/train_script/TimeLLM_ETTh1.sh
     bash ./scripts/train_script/TimeLLM_ETTm1.sh 

     bash ./scripts/train_script/TimeLLM_Weather.sh
     （适用于其他数据集，如 Weather）

#### （要在其他数据集上运行消融，请按照示例更改数据集名称。）

## 致谢

本代码库基于[Time-Series-Library](https://github.com/thuml/Time-Series-Library)构建。感谢！

## 引用
如果你觉得我们的工作有用，请引用如下：


```bibtex
@inproceedings{tan2024language,
    title={语言模型对时间序列预测真的有用吗？},
    author={谭明天 and 麦克·A·梅里尔 and 维纳亚克·古普塔 and 蒂姆·阿尔托夫 and 托马斯·哈维格森},
    booktitle={神经信息处理系统大会（NeurIPS）},
    year={2024}
}

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---