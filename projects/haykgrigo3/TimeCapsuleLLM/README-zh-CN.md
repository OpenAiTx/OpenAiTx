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
一个仅在特定时间段数据上训练的大型语言模型，以减少现代偏见。

想象一下，如果一个AI模型不仅仅是假装历史，而是真的历史。

基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)，核心训练脚本和模型架构均为其作品。

# 项目目标

TimeCapsule LLM 是一个实验性项目，只会在特定历史时期撰写的文本上进行训练。目标是模拟特定历史时代的世界观和语言。

# 为什么微调还不够

如果你只是微调一个预训练模型，你的LLM仍然会知道现代概念。当然实现零现代偏见很难，但我想尽可能接近这一目标。消除现代偏见需要从头开始训练一个模型。

# 预期结果

希望最终，这个模型不会知道现代概念，也无法在其训练内容之外进行推理。它不应识别出现代概念/词汇，也希望不会产生现代知识的幻觉。

# 进度更新

## 2025年7月9日

我已设定时间段为1800-1850年，地区为伦敦

我收集了一份文本、书籍、文档的清单

目前我已获得50个txt文件，很快就会开始训练NanoGPT

只要有进展我都会在此更新

## 2025年7月13日

使用187MB历史文本数据训练了nanoGPT。

## 2025年7月15日

我开始下载用于第二次训练的文本。我正在从Internet Archive获取所有内容，并将时间范围扩大到1800-1875年。为了获得多样化的文本，可以在Internet Archive上使用主题和搜索筛选器来选择出版地点、时间段和主题。

![搜索筛选器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我从Internet Archive下载了大约500个txt文件，清理后（仅删除空格、Gutenberg头部等）大约有500MB数据。数据集很小，但上次我只用187MB训练，所以这次训练第二个模型后输出应该会有明显变化。我希望这个模型至少能生成更连贯、多少有些意义的句子。当然这不是保证，因为数据集还是非常小，但比上次多了。

这应该可以在我自己的硬件上完成，也很好，因为希望能在跳到更大数据集之前看到一些改进，否则需要租用GPU。但别担心，我还是打算很快租用GPU，但在那之前我想确保我的数据集尽可能精心筛选和干净。我遇到的一个问题是清理，这些txt文件中混有很多乱码。我用的清理脚本确实有效，但不是百分百有效。

我今天会用这个数据集进行训练，预计需要4-5小时。完成后测试，会发布更新。再次感谢所有关注我项目的人，甚至有人给我发OCR资源链接，非常感谢！希望更多人尝试并用自己的数据集实验。

### 训练更新

我在一个435MB（1.08亿标记）的语料库上开始训练，目前进展顺利。训练损失在前2800次迭代中从10.9降到4.9。预计总共需要8到9小时完成。完成后我会发布更新。

## 2025年7月17日 2:13AM

第二个模型训练完成，我的4060花了大约8小时40分钟（每小时3900次迭代），共33,000次迭代（5个epoch）。最终训练损失为3.73。输出效果令人惊讶，现在真的能生成连贯的19世纪风格句子。

## 2025年7月28日

我已经将v0.5上传到Hugging Face，[点此查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你现在可以下载我的仓库并在本地运行。不幸的是，nanoGPT不能与HuggingFace原生兼容，所以需要本地下载和运行模型。

此外我将开始为下次训练整理数据，我认为需要5-10倍数据量才能实现推理能力。

# V0模型行为与局限

早期测试表明模型以19世纪语言和行为方式作答。例如，我用"Who art Henry?"进行提示，它回复说："I know that man, I have did not a black, the storm."，虽然这句话没有意义，但LLM已经能识别我是问一个人。




![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

没有提及现代概念，输出内容主要包含19世纪1800年代的用词和表达。

它仍然需要大量工作，仅仅用187MB的数据训练无法得到能进行复杂推理的模型。

目前它输出的句子缺乏完整句子结构，总体上也没有意义，但这对于这种训练规模来说很正常。

# V0.5 模型表现与局限

与上一个模型相比，这是一次很好的提升。写作风格和词汇是维多利亚时期的，几乎每句话的语法和标点都很正确。而且这完全是从零开始训练的，因此内容紧贴1800年代的话题。

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

存在大量事实性幻觉。许多（几乎100%）细节（日期、事件、历史人物）都是捏造的。而且句子之间实际上没有关联，有时也许两句话有关联，但除此之外就没有了。另一个问题是有时会出现“Digitized by Google”这种脚注，因此下次训练时我真的得确保文本被彻底清理。总体来说，我对结果很满意，虽然还远未成为LLM，但绝对已经是个句子生成器了。

我学到了很多，接下来几周会开始摸索需要改进的地方。很快会上传相关文件！

# 接下来的计划

（已完成）我将开始制作0.5版本，这次不是用50本书训练，而是理想情况下用500-600本。目前我正在用1800-1850年间伦敦出版的书籍训练nanoGPT。有些挑战，比如要确保找到的书没有被更新或有现代解读，而是选取我所选时期内未经修改出版的书籍。

我想用更大的语料库训练一个新模型（v1），可能是v0.5的5-10倍大。我的目标是看看仅靠选择性时间训练是否能让推理能力自发出现，这将更难实现，我也不确定是否可行，因为历史数据有限。未来几周我会尝试整理5-10GB的数据。我相信只要能获得干净高质量的数据并租用一块GPU，就会有进展。

# 如何使用本项目

本项目主要聚焦于历史数据的整理、训练准备和分词器的构建。不涵盖完整的LLM训练流程，具体请参考Andrej Karpathy的nanoGPT。

# 第1步：收集与准备历史文本

收集你选定时期（如伦敦1800-1850年）的公共领域书籍、文档等的.txt文件。

如果需要，可以用download_texts_improved.py为你下载书籍。

使用脚本清理文本文件，或手动移除古腾堡计划的页眉/页脚、现代注释或如OCR错误等内容。

prepare_dataset.py应能正常使用。

# 第2步：构建自定义分词器

在清洗后的数据上运行train_tokenizer.py或train_tokenizer_hf.py。
这将生成vocab.json和merges.txt

这些文件定义了模型的词汇表和合并规则

# 第3步：训练你的模型（nanoGPT）

训练流程请参考[Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)。

你也可以训练其他LLM，但我用的是nanoGPT

# 常见问题

## 什么是选择性时间训练？

选择性时间训练（STT）是一种机器学习方法论，所有训练数据都被严格筛选，以确保属于特定历史时期。这样做是为了模拟那个时代的语言和知识，不受现代概念影响。例如，我现在的模型（v0.5）只用1800-1875年的数据训练，不是微调而是从零开始，因此输出反映了当时的语言风格和历史背景。

## 为什么不用微调或LoRA？

在本项目中，我的目标是创造一个不受现代偏见影响的语言模型。如果我微调诸如GPT-2这样的模型，它本身已经预训练过，相关信息无法消除。如果从零训练，语言模型不会“假装”古老，而是真正如此。这个项目现在的目标是打造一个仅能利用1800-1850年间伦敦出版书籍知识进行推理的模型。

## 训练用的是什么数据？

我用的是1800-1850年伦敦的书籍、法律文档、报纸和其他著作。我链接的清单有200个左右，但第一次训练只用了大约50个文件，约187MB。你可以查看文档列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0版本模型有多大？

这个模型现在很小，我只是为了兴趣做这个，同时严格遵守不使用现代资源的训练规则。它大约有1600万个参数，但我会开始收集更多旧文本，准备进行下一轮模型训练。后续会持续更新。

## 训练硬件规格？

GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---