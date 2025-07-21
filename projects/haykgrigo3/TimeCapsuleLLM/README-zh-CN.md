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
一个仅在特定时间段数据上训练的LLM，以减少现代偏见。

想象一下，如果一个AI模型不仅仅是假装历史化，而是真正“历史化”。

基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) ，核心训练脚本和模型架构均为其作品。

# 项目目标

TimeCapsule LLM 是一个实验性项目，仅使用特定历史时期的文本进行训练。目标是模拟特定历史时代的世界观和语言风格。

# 为什么微调不够

如果你只是微调一个预训练模型，你的LLM依然会知晓现代概念。当然，要完全消除现代偏见很困难，但我希望尽可能接近这个目标。实现零现代偏见需要从头开始训练一个模型。

# 预期结果

希望当项目完成时，这个模型将不会知晓现代概念，也无法进行超出其训练内容的推理。它不应识别出现代词汇/概念，也希望它不会幻觉出现代知识。

# 进展更新

## 2025年7月9日

我已将时间段设定为1800-1850年，地区为伦敦

我已经收集了一份文本、书籍、文件列表

目前我已获得50个txt文件，很快将开始训练NanoGPT

只要有进展我会持续更新这里

## 2025年7月13日

使用187MB的历史文本数据训练了nanoGPT。

## 2025年7月15日

我开始下载第二轮训练用的文本。我正在从Internet Archive获取所有资料，并将时间范围扩展到1800-1875年。为了获取多样化的文本，可以在Internet Archive上通过主题、出版地点、时间段和主题进行筛选。

![搜索筛选](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我从Internet Archive下载了大约500个txt文件，清洗后（只删除空白、Gutenberg头部等）得到约500MB数据。数据集很小，但上次我只训练了187MB，所以这次训练第二个模型后输出应该至少会有一些明显的不同。我希望这次的模型至少能生成更连贯、更有意义的句子。当然不能保证，因为数据集仍然很小，但比上次用的要多。

这应该可以在我自己的硬件上完成，这也好，因为在切换到更大的数据集（需要租用GPU）之前，希望能看到一些改进。别担心，我很快还是会租GPU，但在那之前，我想确保数据集尽可能精选和干净。其中一个问题就是清洗，很多txt文件里混杂着乱码。我用的清洗脚本虽然有效，但并非100%彻底。

我今天会训练这个数据集，预计需要4-5小时。训练完成并测试后会再更新。再次感谢所有关注我项目的人，甚至有人给我推荐了OCR资源，非常感谢！希望更多人尝试并用自己的数据集做实验。

### 训练进展

我开始在一个435MB（1.08亿标记）的语料库上训练，目前进展顺利。训练损失在前2800次迭代中从10.9降到了4.9。预计大约需要8到9小时完成。完成后会再发更新。

## 2025年7月17日 2:13AM

第二个模型训练完成，我的4060显卡大约用了8小时40分钟（每小时3900次迭代），共33,000次迭代（5个epoch）。最终训练损失为3.73。输出效果出乎意料地好，现在它能够真正生成连贯的19世纪风格句子。

# V0模型行为与局限性

早期提示显示模型用1800年代的语言和行为做出回应。例如，我用“Who art Henry?”提示它，它回答说：“I know that man, I have did not a black, the storm.” 虽然这句话没有意义，但LLM能识别我在问一个人。

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

没有出现现代概念，输出主要包含19世纪的词汇和表达方式。

它仍然需要大量改进，仅用187MB训练并不能产生具备复杂推理能力的模型。

目前它生成的句子缺乏完整句子结构，总体上也不通顺，但这对于当前训练量来说是正常的。

# V0.5 模型行为与局限性

与上一个模型相比，这是一个很好的改进。写作风格和词汇是维多利亚时代的，几乎每句话都符合语法规范，标点正确。同样，这个模型是从零开始训练的，因此它坚持使用 19 世纪主题。

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

存在大量事实幻觉。许多（几乎 100%）的细节（日期、事件、历史人物）都是虚构的。而且句子之间实际上没有关联，有时也许有两句话相关，但除此之外就没有了。另一个问题是有时会出现“Digitized by Google”的杂项页脚，因此下次训练时我必须确保文本彻底清理。总体来说我对结果很满意，虽然还远不是 LLM，但绝对是一个句子生成器。

我学到了很多东西，接下来几周会开始思考需要改进的地方。我很快就会上传文件！

# 接下来的计划

（已完成）我打算开始做 0.5 版本的工作，这次不再用 50 本书训练，而是理想情况下用 500-600 本。目前我正在用 1800-1850 年间的伦敦书籍训练 nanoGPT。有一些挑战，比如要确保找到的书没有被更新或现代解读，而是我选择的时间段内未被触碰的原始出版书籍。

我想用更大的语料库训练一个新模型（v1），也许是 v0.5 的 5-10 倍。我的目标是看看是否仅凭选择性时序训练就能让推理能力自然出现，这会更难，而且我也不确定是否可行，因为历史数据有限。接下来的几周我会尝试整理够 5-10GB 的数据。我相信如果能获得干净高质量的数据并租一块 GPU，会有进展。

# 如何使用本项目

本项目主要聚焦于整理历史数据，为训练做准备以及构建分词器。我不会介绍完整的 LLM 训练流程，详情请参考 Andrej Karpathy 的 nanoGPT。

# 步骤 1：收集和准备历史文本

收集你选定时间段的公共领域书籍、文档等的 .txt 文件（例如：伦敦 1800-1850 年）

如果需要，你可以用 download_texts_improved.py 自动为你下载书籍。

用脚本或手动清理文本文件，去除古腾堡计划的头/尾、现代注释或 OCR 错误等内容。

prepare_dataset.py 应该可以正常使用。

# 步骤 2：构建自定义分词器

在清理后的数据上运行 train_tokenizer.py 或 train_tokenizer_hf.py。
这会生成 vocab.json 和 merges.txt

这些文件定义了你模型的词汇和合并规则

# 步骤 3：训练你的模型（nanoGPT）

训练过程请参考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)。

如果你愿意也可以训练其他 LLM，但我用的是 nanoGPT

# 常见问题

## 什么是选择性时序训练？

选择性时序训练（STT）是一种机器学习方法，所有训练数据都被专门筛选在某一历史时期内。这样做是为了模拟该时代的语言和知识，不受现代概念影响。例如，我现在的模型（v0.5）就是在 1800-1875 年的数据上训练的，不是微调，而是从零开始训练，因此输出反映了那个时期的语言风格和历史背景。

## 为什么不直接用微调或 LoRA？

在这个项目中我想创建一个不受现代偏见影响的语言模型。如果我微调像 GPT-2 这样的模型，它已经预训练过，这些信息不会消失。如果我从零开始训练，语言模型就不会假装是旧的，它本身就是旧的。目前这个项目的目标是创建一个只能利用 1800 到 1850 年伦敦书籍知识进行推理的模型。

## 训练用的数据是什么类型？

我用的是 1800–1850 年伦敦的书籍、法律文档、报纸和其他著作。我链接的列表里有大约 200 个，但首次训练只用了 50 个文件，约 187 MB。你可以查看文件列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0 版模型有多大？

这个模型现在很小，我只是出于兴趣在做，并严格遵守不使用现代资料的训练规则。它有近 1600 万参数，但我会开始收集更多旧文本，准备训练另一个模型。后续会持续更新进展。

## 训练规格？

GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---