
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
一个仅使用特定时间段数据进行训练的大型语言模型，用于减少现代偏见。

想象一下，一个 AI 模型不只是假装是历史性的，而是实际上就是如此。

构建于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 之上，核心训练脚本和模型架构均为其作品。

# 项目目标
TimeCapsule LLM 是一个实验性项目，只会在某些特定时期创作的文本上进行训练。其目标是模拟特定历史时代的世界观和语言。

# 为什么微调还不够

如果你只是微调一个预训练模型，你的 LLM 仍然会了解现代概念。当然，实现零现代偏见很难，但我希望尽可能接近这一目标。要做到完全没有现代偏见，需要从头开始训练一个模型。

# 预期结果

希望在完成后，这个模型不会了解现代概念，也无法进行超出其训练内容的推理。它不应识别现代概念/词汇，也不应幻想出现现代知识。

# 进度更新

## 2025年7月9日

我设定的时间段是1800-1850年，地区：伦敦

我已经收集了一些文本、书籍和文件列表

目前我已经获得了50个txt文件，很快将开始训练NanoGPT

只要有进展，我会持续更新

## 2025年7月13日

用187MB的历史文本数据训练了nanoGPT。

## 2025年7月15日

我开始为第二次训练下载文本。我正在从互联网档案馆获取所有内容，并将时间范围扩大到1800-1875年。为了获得多样化的文本，可以在互联网档案馆使用主题和搜索筛选器，按出版地点、时间段和主题进行筛选。

![搜索筛选器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我从互联网档案馆下载了大约500个txt文件，清理后（只删除空白、古腾堡头文件等）得到约500MB的数据。这个数据集很小，但上次我只用187MB进行训练，所以这次训练第二个模型后输出应该至少有一些明显的不同。我希望这个模型至少能生成更连贯、更有意义的句子。当然这不是保证，因为数据集仍然很小，但比上次用的要多一些。

这应该可以在我自己的硬件上完成，这也很好，因为我希望能在跳到更大的数据集之前看到一些改进，否则需要租用GPU。但别担心，我还是打算很快租GPU，不过在此之前我想确保我的数据集尽可能精心筛选和干净。我遇到的问题之一就是清理，这些txt文件中混入了很多乱码。我用来清理的脚本有效，但并不是百分百准确。

我今天会用这个数据集训练，预计需要大约4-5小时。完成后我会测试并更新进展。再次感谢所有关注我项目的人，甚至有人给我推荐OCR资源链接，非常感谢！我希望更多人尝试这个项目，并用自己的数据集进行实验。


## 2025年8月12日

第1版已完成，这一版本采用了Phi 1.5（700M参数），并在一个包含近7000篇文本的数据集上进行了训练。该模型的主要提升在于它有时能够引用真实姓名和历史事件。第0版和0.5版无法做到这一点，当我用“在1821年”这样的提示进行测试时，输出只是幻想，从未发生过的内容。以下是第1版的一个例子：

我的提示：公元1834年，

输出：“公元1834年，伦敦的街道上充满了抗议和请愿。正如许多人所述，原因并不在于私人，而是在帕默斯顿勋爵当日采取的行动，公众将会收到关于法律日所遇到困难的简要声明。令人深感遗憾的是，当前世界历史上的事件已经明朗，因此将会被知晓。并非事实的是，最早在耶路撒冷福音中定居的人竟然拥有如此广泛而有趣的繁荣和兴旺的记录。”

起初我以为这只是巧合，但看看这个： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### 训练进展

我开始在一个435MB（1.08亿标记）语料库上训练，目前进展顺利。训练损失从10.9降到4.9，仅用了前2800次迭代。我预计大约需要8到9小时完成。训练完成后我会再发一条更新。

## 2025年7月17日

第二个模型的训练已完成，我的4060用了大约8小时40分钟（每小时3900次迭代），共进行了33,000次迭代（5个周期）。最终训练损失为3.73。输出令人惊喜，现在它能真正生成连贯的19世纪风格句子。

## 2025年7月28日

我已经将v0.5上传到Hugging Face，[有兴趣可以看看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你现在可以下载我的仓库并在本地运行。不幸的是，nanoGPT无法原生支持HuggingFace，所以你需要下载并在本地运行模型。

同时，我将开始为下一次训练整理数据，我认为我需要多5-10倍的数据量才能实现推理能力。

## 2025年8月2日

我很快就会开始第1版的工作。我需要从nanoGPT架构过渡到更现代的架构。我考虑了几个开源LLM架构，包括：OpenLLaMA v3、Phi-2和Qwen 1.5B。为了支持V1的提升，我需要精心整理一个更大且多样化的数据集。至少需要5GB的干净训练数据。

# V0模型行为与局限

早期提示显示模型会用19世纪的语言和行为作答。例如，我提示“谁是Henry？”它回复说“我认识那个人，我没有一个黑色，风暴。”虽然这句话没意义，但LLM能识别我在问一个人。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

没有出现现代概念，输出主要包含19世纪的词汇和表达方式。

模型仍有很多需要改进，仅用187MB训练无法得到具备复杂推理能力的模型。

目前它生成的句子缺乏完整的句子结构，总体上没有意义，但对于当前训练规模来说这是正常的。

# V0.5模型行为与限制

相比上一个模型，这是一个很好的提升。写作风格和词汇都是维多利亚时代的，几乎每句话都语法正确且标点得当。而且这也是从零训练的，所以内容紧贴19世纪的主题。

![TimeLockLLM样本输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

存在大量事实性幻觉。很多（几乎100%）细节（日期、事件、历史人物）都是杜撰的。而且句子之间基本没有关联，有时可能有两句相关，但整体上不连贯。另一个问题是偶尔会出现“Digitized by Google”页脚，下次训练时我必须确保文本彻底清理。总体而言，我对结果很满意，虽然还远远不是LLM，但确实可以生成句子。

我学到了很多，未来几周将开始摸索需要改进的地方。文件很快就会上传！

# V1模型行为与限制

我很快会上传一些示例输出，并且会用同一提示词对三种模型进行对比。我也会像上个版本一样上传V1到huggingface，你可以在这里找到我的huggingface账号：https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# 未来计划

（已完成）我将开始开发0.5版本，这次不是用50本书训练，而是理想情况下用500-600本。目前我正在用1800-1850年伦敦的书籍训练nanoGPT。挑战在于确保找到的书没有现代化解释或更新，必须是我选定时期出版的原始书籍。

我希望用更大的语料库训练新模型（v1），可能是v0.5的5-10倍。我的目标是看看仅靠选择性时序训练能否出现推理能力，这将更加困难，我也不能完全确定是否可行，因为存在历史数据限制。未来几周我会尝试整理出5-10GB的数据集。我相信只要数据干净高质，租到GPU，就会有进展。

# 如何使用本项目

本项目主要关注历史数据整理、训练准备和分词器构建。完整的LLM训练过程不在此覆盖，详情请参考Andrej Karpathy的nanoGPT。

# 步骤1：收集和准备历史文本

收集你选择时期的公共领域书籍、文档等的.txt文件（例如伦敦1800-1850）

如果需要，可以使用download_texts_improved.py脚本为你下载书籍。

用脚本或手动清理文本文件，去除古腾堡项目头/尾、现代注释或OCR错误等内容。

prepare_dataset.py应该可以正常运行。

# 步骤2：构建自定义分词器

在清理好的数据上运行train_tokenizer.py或train_tokenizer_hf.py。
这会生成vocab.json和merges.txt。
这些文件定义了你的模型的词汇和合并规则

# 步骤3：训练你的模型（nanoGPT）

有关训练过程，请参考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)。

你可以训练其他的大型语言模型（LLM），但我用的是 nanoGPT

# 常见问题解答

## 什么是选择性时序训练？

选择性时序训练（STT）是一种机器学习方法，所有训练数据都经过专门筛选，限定在特定历史时期内。这样做是为了建模那个时代的语言和知识，避免现代概念的影响。例如，我现在拥有的模型（v0.5）仅使用1800-1875年的数据训练，不是微调，而是从零开始训练，因此输出内容能够反映那个时期的语言风格和历史背景。

## 为什么不用微调或 LoRA？

这个项目的目标是创建一个不受现代偏见影响的语言模型。如果我对 GPT-2 进行微调，它已经预训练过，原有的信息无法消除。如果从零开始训练，语言模型不会假装古老，而是真正如此。当前项目的目标是创建一个只能用1800至1850年伦敦出版书籍知识进行推理的模型。

## 你用什么数据进行训练？

我使用了1800–1850年伦敦的书籍、法律文件、报纸和其他文献。我链接的列表大约有200个文件，但第一次训练只用了50个文件，总约187 MB。你可以查看文档列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 这些模型有多大？

V0：1600万参数

V0.5：1.23亿参数

V1：7亿参数

# 训练规格？

#V0/V0.5
GPU：Geforce RTX 4060
CPU：i5-13400F
内存：16GB DDR5。

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---