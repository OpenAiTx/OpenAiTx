<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (即将推出)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (即将推出)</a> |
        | <a href="#" title="Coming soon">ไทย (即将推出)</a> |
        | <a href="#" title="Coming soon">Français (即将推出)</a>
        | <a href="#" title="Coming soon">Deutsch (即将推出)</a>
        | <a href="#" title="Coming soon">Español (即将推出)</a>
        | <a href="#" title="Coming soon">Italiano (即将推出)</a>
        | <a href="#" title="Coming soon">Русский (即将推出)</a>
        | <a href="#" title="Coming soon">Português (即将推出)</a>
        | <a href="#" title="Coming soon">Nederlands (即将推出)</a>
        | <a href="#" title="Coming soon">Polski (即将推出)</a>
        | <a href="#" title="Coming soon">العربية (即将推出)</a>
        | <a href="#" title="Coming soon">فارسی (即将推出)</a>
        | <a href="#" title="Coming soon">Türkçe (即将推出)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (即将推出)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (即将推出)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
一个只在特定时间段数据上训练的LLM，以减少现代偏见。

想象一下，如果一个AI模型不仅仅是假装历史化，而是真的历史化。

基于 [Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT) 核心训练脚本和模型架构均为其贡献。

# 项目目标

TimeCapsule LLM是一个实验性项目，只会在特定历史时期撰写的文本上进行训练。其目标是模拟特定历史时代的世界观和语言风格。

# 为什么微调还不够

如果你只是对一个预训练模型进行微调，你的LLM依然会了解现代概念。当然，实现零现代偏见很难，但我希望尽可能接近这个目标。要实现无现代偏见，必须从零开始训练模型。

# 预期结果

希望在完成后，这个模型不会了解现代概念，也无法进行超出其训练内容的推理。它不应识别现代概念/词汇，并且我希望它不会臆造现代知识。

# 进展更新

## 2025年7月9日

我已经确定了训练时间段为1800-1850年，地区为伦敦

我已经收集了一份文本、书籍、文档清单

目前我已获得50个txt文件，并将很快开始训练NanoGPT

只要有进展我会持续更新

## 2025年7月13日

已用187MB历史文本数据训练nanoGPT。

## 2025年7月15日

我开始下载用于第二次训练的文本。我正在从Internet Archive获取一切，并将时间段扩大到1800-1875年。为了获得多样化的文本，可以在Internet Archive使用主题和搜索过滤器，筛选出版地点、时间和主题。

![搜索过滤器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我从Internet Archive下载了大约500个txt文件，清洗后（只是删除空白、Gutenberg头部等）大约有500MB数据。虽然数据集很小，但上一次我只用187MB训练，所以这次训练第二个模型后，输出应该会有一些明显的差异。我希望这个模型至少能生成更连贯、有一定意义的句子。当然，这不是保证，因为数据集还是很小，但比上次多了。

这应该可以在我自己的硬件上完成，这也很好，因为我希望在转向需要租用GPU的更大数据集前，能先看到一些改进。但不用担心，我仍然计划很快租用GPU，不过在那之前我想确保我的数据集尽可能地精心整理和清理。我遇到的问题之一是清洗，许多txt文件中夹杂着乱码。我用来清洗的脚本虽然有效，但不是百分百有效。

我今天会训练这个数据集，预计需要4-5小时。训练完成并测试后我会更新。再次感谢所有关注我项目的人，有些人甚至给我提供了OCR资源链接，非常感谢！希望有更多人尝试并用自己的数据集进行实验。

## 2025年7月28日

我已经将v0.5上传到Hugging Face，[点击查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) 。你现在可以下载我的仓库并在本地运行。不幸的是，nanoGPT不能与HuggingFace原生兼容，所以你需要下载并在本地运行模型。

另外我将开始为下一次训练整理数据，我认为需要5-10倍的数据量才能实现推理能力。

### 训练进展

我开始在一个435MB（1.08亿个token）的语料库上训练，目前进展很顺利。训练损失从10.9下降到4.9，用了前2800次迭代。我预计总共需要8到9小时才能完成。完成后我会再发更新。

## 2025年7月17日 2:13AM

第二个模型的训练已经完成，我的4060用了大约8小时40分钟（每小时3900次迭代），共33000次迭代（5个epoch）。最终训练损失为3.73。输出结果令人惊喜，现在它确实能生成连贯的19世纪风格句子。

# V0模型行为与局限

早期提示显示模型会用19世纪语言和行为进行响应。例如，我用“Who art Henry?”来提问，它回复道：“I know that man, I have did not a black, the storm.”，是的，这句话没有意义，但LLM能够识别我在询问一个人。

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)


没有提及现代概念，输出内容大多为19世纪的词汇和表述方式。

它仍然需要大量改进，仅用187MB的数据进行训练，不会得到能够产生复杂推理文本的模型。

目前它生成的句子缺乏完整的句子结构，总体上没有意义，但以目前的训练集规模来说这是正常的。

# V0.5模型表现与局限

与上一个模型相比，这是一个不错的提升。写作风格和词汇都是维多利亚时代的，几乎每句话语法都正确，标点也很规范。同样这也是从零训练的，所以内容严格局限于19世纪的话题。

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

存在大量事实幻觉。许多（几乎100%）细节（日期、事件、历史人物）都是虚构的。而且句子之间基本没有关联，有时可能两句话有关联，但除此之外就没有了。另一个问题是有时会出现“Digitized by Google”的杂项页脚，下次训练时我必须确保文本充分清洗。总体来说我对结果很满意，虽然还远不是LLM，但绝对已经是句子生成器了。

我正在学习很多东西，接下来几周会开始摸索需要改进的地方。很快就会上传文件！

# 即将计划

（已完成）我将开始进行0.5版本的工作，这次不是用50本书训练，而是计划用500-600本。目前我正在用1800-1850年间、特别是伦敦的书籍对nanoGPT进行训练。有一些挑战，比如要确保找到的书没有被更新或现代解读，而是我所选时间段内原始出版的未改动书籍。

我想用更大的语料库训练一个新模型（v1），大约是v0.5的5-10倍。我想看看仅通过选择性时序训练能否让推理能力自然出现，这将更有难度，我也不确定是否可行，因为有历史数据的局限。接下来几周我会尝试整理出5-10GB的干净数据。我相信如果能获得高质量的数据并租用GPU，应该会有所进展。

# 如何使用此项目

本项目主要聚焦于整理历史数据、准备训练数据和构建分词器。不涉及完整的LLM训练流程，具体可参考Andrej Karpathy的nanoGPT。

# 步骤1：收集并准备历史文本

收集你选定时期的公共领域书籍、文档等的.txt文件（如伦敦1800-1850年间）

如果需要，可以使用download_texts_improved.py自动下载书籍。

用脚本或手动清理文本文件，去除古腾堡项目页眉/页脚、现代注释或OCR错误等。

prepare_dataset.py 应该可以正常使用。

# 步骤2：构建自定义分词器

在清洗后的数据上运行 train_tokenizer.py 或 train_tokenizer_hf.py。
这样会生成 vocab.json 和 merges.txt

这些文件定义了你的模型的词汇和合并规则

# 步骤3：训练你的模型（nanoGPT）

训练流程请参考 [Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)。

你可以训练其它LLM，但我用的是nanoGPT

# FAQ

## 什么是选择性时序训练（Selective Temporal Training）？

选择性时序训练（STT）是一种机器学习方法，所有训练数据都严格限定在某一历史时期。这样可以模拟当时的语言和知识，不受现代概念影响。例如我现在的模型（v0.5）只用1800-1875年的数据训练，并非微调，而是从零开始，因此输出能够反映当时的语言风格和历史语境。

## 为什么不直接用微调或LoRA？

本项目的目标是创造一个不受现代偏见影响的语言模型。如果用GPT-2之类的模型微调，预训练的信息不会消除。而从零训练，模型就不会“假装”是旧时语言，而是真的如此。项目目前的目标就是让模型只能依据1800-1850年伦敦出版的书籍来推理。

## 训练用的是什么数据？

我使用的是1800–1850年伦敦的书籍、法律文件、报纸及其他文献。我链接的列表有大约200个，但第一次训练只用了50个文件，共约187 MB。文档列表可见：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0号版本的模型有多大？

目前模型很小，我只是出于兴趣做这个，并严格遵守不使用现代资料的训练规则。模型参数近1600万，不过我会继续收集旧文本，开始新一轮训练。会持续更新进展。

## 训练规格？

GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---