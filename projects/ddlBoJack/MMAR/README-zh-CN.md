# MMAR：一个面向语音、音频、音乐及其混合的深度推理挑战基准
[**📖 arXiv**](https://arxiv.org/abs/2505.13032) | [**🎬 MMAR 演示视频**](https://www.youtube.com/watch?v=Dab13opIGqU) | [**🛠️ GitHub 代码**](https://github.com/ddlBoJack/MMAR) | [**🔊 MMAR 音频下载（HuggingFace）**](https://huggingface.co/datasets/BoJack/MMAR)
                                          
<p align="center"><img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/logo.png" alt="MMAR Benchmark Logo" width="300"/></p>

## MMAR 概览
我们推出了 MMAR，一项旨在评估音频语言模型（ALMs）在大规模多学科任务中深度推理能力的新基准。  
MMAR 包含 1,000 个精心策划的音频-问题-答案三元组，采集自真实互联网视频，并通过反复错误修正和质量检查确保高质量。  
基准中的每个条目都要求多步骤的深度推理，超越表层理解。此外，部分问题需要研究生级别的感知与领域知识，提升了基准的难度和深度。  
示例如下：

![Example](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/example.png)

MMAR 的元数据可在[此文件](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json)中获取。不同于以往基准，MMAR 不仅涵盖语音、音频和音乐等传统模态，还扩展至它们的混合，数据采集自野外视频。数据在各模态间的分布见左侧图。每个问题还被标注了指定的类别和子类别，如右侧图所示。

对于每个问题，我们还提供了原始视频的 URL 及对应时间戳，以及片段中所说的语言（若有）。为防止推理模型训练中的潜在数据泄露，我们暂未公开推理线索和思维链注释，相关内容将在适当时机发布。

<p float="left">
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/modality_pie.png" width="49%" />
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/category_sunburst.png" width="49%" />
</p>

## 基准测试结果
我们在 MMAR 上对五类模型进行了基准测试：  
1. 大型音频语言模型（LALMs）  
2. 大型音频推理模型（LARMs）  
3. 全能语言模型（OLMs）  
4. 以音频字幕作为输入的大型语言模型（LLMs）  
5. 以音频字幕作为输入的大型推理模型（LRMs）  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/benchmark.png)

## 数据集构建
MMAR 基准通过全面的流程构建完成。过程包括：  
1. 头脑风暴设计挑战性问题  
2. 通过人机协作建立分类体系  
3. 基于启发式方法进行数据采集与标注  
4. 抓取音频数据并在多个槽位丰富内容  
5. 反复修正与质量检查，确保数据高保真  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/pipeline.png)

## 测试您的模型！

为了确保顺利集成到现有评估流程，我们采用了基于 [MMAU](https://github.com/Sakshi113/MMAU) 修改的评估方法，实现于 [evaluation.py](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/code/evaluation.py)。评估脚本的输入应与 [MMAR-meta.json](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json) 格式相同，并额外包含名为 `model_prediction` 的键，用于存储模型对每个问题的预测结果。  
  
运行脚本命令如下：

```bash
python evaluation.py  --input INPUT_JSON_PATH
```
## 致谢
我们衷心感谢我们的评估代码是基于 [MMAU](https://github.com/Sakshi113/MMAU) 官方实现进行修改的。

## 引用

```
@article{ma2025mmar,
  title={MMAR: A Challenging Benchmark for Deep Reasoning in Speech, Audio, Music, and Their Mix},
  author={Ma, Ziyang and Ma, Yinghao and Zhu, Yanqiao and Yang, Chen and Chao, Yi-Wen and Xu, Ruiyang and others},
  journal={arXiv preprint arXiv:2505.13032},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---