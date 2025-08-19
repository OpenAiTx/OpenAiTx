
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文（即将推出）</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी（即将推出）</a> |
        | <a href="#" title="Coming soon">ไทย（即将推出）</a> |
        | <a href="#" title="Coming soon">Français（即将推出）</a>
        | <a href="#" title="Coming soon">Deutsch（即将推出）</a>
        | <a href="#" title="Coming soon">Español（即将推出）</a>
        | <a href="#" title="Coming soon">Italiano（即将推出）</a>
        | <a href="#" title="Coming soon">Русский（即将推出）</a>
        | <a href="#" title="Coming soon">Português（即将推出）</a>
        | <a href="#" title="Coming soon">Nederlands（即将推出）</a>
        | <a href="#" title="Coming soon">Polski（即将推出）</a>
        | <a href="#" title="Coming soon">العربية（即将推出）</a>
        | <a href="#" title="Coming soon">فارسی（即将推出）</a>
        | <a href="#" title="Coming soon">Türkçe（即将推出）</a>
        | <a href="#" title="Coming soon">Tiếng Việt（即将推出）</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia（即将推出）</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*一个从零开始训练的语言模型，仅使用特定地点和时期的数据，以减少现代偏见，模拟那个时代的声音、词汇和世界观。*

想象一下，如果一个 AI 模型不仅仅是伪装成历史，而是真正成为历史。

v0 和 v0.5 基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 构建，核心训练脚本和模型架构均来自于他。

v1 基于 [微软的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5) 构建


##  模型行为与局限性

### **v0**  

早期提示显示模型以 1800 年代的语言和行为进行响应。
示例：提示：“Who art Henry?”，模型回复：“I know that man, I have did not a black, the storm.”

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 未提及现代概念  
- 主要使用该时代准确的词汇  
- 句子大多不连贯（约 187MB 训练数据，预期如此）

### **v0.5** 

相比 v0 有显著提升。  
- 维多利亚时期的写作风格，标点规范，句子基本语法正确  
- 事实幻觉率仍然很高  
- OCR 噪声（如“Digitized by Google”）仍出现在输出中

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首个能回忆并关联真实历史事件与数据集实际人物的模型。

示例：提示：“It was the year of our Lord 1834” 

输出：“It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

起初我以为抗议活动可能只是巧合地发生在同一年，但请看这个： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### 为什么这很重要：

这是我的模型首次将某一年与真实历史事件以及与该事件相关的真实人物（Palmerston 勋爵）关联起来。早期模型（v0 和 v0.5）虽然能模仿 19 世纪的写作风格，但总是幻想事件、人物和事实。这表明模型开始记住数据集中的内容。

## 后续计划
- 伦敦在1800-1875年间出版的文本在互联网档案馆上有近175,000份
- 我计划扩展语料库并进一步清理，以提升推理能力
- 将扩展到不同地区和时期，以构建更多历史模型

## 如何使用

本项目主要专注于历史数据的整理、训练准备以及分词器的构建。不会涵盖完整的大型语言模型训练流程，详细内容请参考Andrej Karpathy的nanoGPT项目。

### 步骤1：收集并准备历史文本

- 收集所选时期的公共领域书籍、文档等的.txt文件（如：伦敦1800-1850年）
- 保持在你选择的时间/地点范围内
- 使用脚本或手动清理文本文件，去除古腾堡项目的页眉/页脚、现代注释或OCR错误等内容。

### 步骤2：构建自定义分词器

- 在清理后的数据上运行train_tokenizer.py或train_tokenizer_hf.py。
- 这样会生成vocab.json和merges.txt
- 这些文件定义了你的模型的词汇表和合并规则

### 步骤3：训练你的模型

- 有关训练流程请参考[Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)或你所选架构的文档。

# 常见问题解答

## 什么是选择性时序训练？

选择性时序训练（STT）是一种机器学习方法，所有训练数据都专门筛选在特定历史时期内。这样做是为了模拟那个时代的语言和知识，不受现代概念影响。例如，我目前的模型（v0.5）只用1800-1875年的数据训练，完全从零开始训练，未经过微调，因此输出能反映那个时期的语言风格和历史语境。

## 为什么不直接用微调或LoRA？

这个项目旨在创建一个不受现代偏见影响的语言模型。如果对GPT-2等进行微调，它已经预训练过，原有信息无法消除。从零开始训练的模型不会“假装”是旧的，而本身就是。当前目标是打造一个只用1800至1875年伦敦书籍知识进行推理的模型。

## 训练用的数据有哪些？

我使用的是1800–1875年伦敦的书籍、法律文档、报纸及其他著作。链接的列表（v0）有约200份文档，但第一次训练只用了50个文件，约187 MB。你可以查看文档列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt



数据集大小：
v0: 约187MB
v0.5: 约435MB
v1: 约6.25GB

## 模型有多大？

V0：1600万参数

V0.5：1.23亿参数

V1：7亿参数

# 训练规格？

# V0/V0.5
GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。

# V1
GPU：租用A100














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---