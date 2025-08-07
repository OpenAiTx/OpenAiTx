
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
一种只在特定历史时期数据上训练的LLM，以减少现代偏见。

想象一下，如果AI模型不只是“假装”历史，而是真正“成为”历史本身。

基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 核心训练脚本和模型架构均为其工作。

# 项目目标

TimeCapsule LLM 是一个实验性项目，仅在特定历史时期撰写的文本上进行训练。目标是模拟特定历史时期的世界观和语言。

# 为什么微调不够

如果你只是对预训练模型进行微调，你的LLM仍然会知道现代概念。当然，实现零现代偏见很难，但我想尽量接近这个目标。要做到完全没有现代偏见，需要从零开始训练模型。

# 预期成果

希望当模型完成时，它不会知道现代概念，也无法进行超出其训练内容的推理。它不应识别现代概念/词汇，并且我希望它不会臆造现代知识。

# 进度更新

## 2025年7月9日

我已将时间范围设定为1800-1850年，地区为伦敦

我收集了一份文本、书籍、文件的清单

目前我已经获得了50个txt文件，很快就会开始训练NanoGPT

只要有进展我会持续更新

## 2025年7月13日

使用187MB历史文本数据训练了nanoGPT。

## 2025年7月15日

我开始为第二轮训练下载文本。我正在从Internet Archive获取所有内容，并将时间范围扩展到1800-1875年。为了获得多样化的文本，你可以在Internet Archive上使用主题和搜索过滤器筛选出版地点、时间和主题。

![搜索过滤器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我从Internet Archive下载了大约500个txt文件，清理（只删除空白、Gutenberg页眉等）后，大约有500MB数据。数据集很小，但上次我只用187MB训练，所以这次训练第二个模型后，输出应该会有一些明显差别。我希望这次模型至少能生成更连贯、有一定意义的句子。当然这不是保证，因为数据集还是非常小，但至少比上次多。

这应该可以在我自己的硬件上完成，这很好，因为我希望在跳到更大的数据集（那就需要租用GPU了）前能看到一些提升。但别担心，我很快还是会租GPU，但在那之前我想确保我的数据集足够精心整理和干净。我面临的一个问题就是清洗，很多txt文件里混杂着乱码。我用的清洗脚本有效，但并不是百分之百。

我今天会训练这个数据集，预计需要4-5小时。训练完成并测试后我会更新。再次感谢所有关注我项目的人，甚至有朋友给我推荐OCR资源，感谢大家！希望有更多人尝试这个项目并用自己的数据集实验。

### 训练进展

我在435MB（1.08亿tokens）语料上开始训练，目前进展顺利。训练损失在前2800次迭代中从10.9降至4.9。我预计整个训练大约需要8-9小时。完成后会再发更新。

## 2025年7月17日

第二个模型训练完成，我的4060显卡用了大约8小时40分钟（每小时3900次迭代），共33000次迭代（5个epoch）。最终训练损失为3.73。输出令人惊讶地好，现在真的能生成连贯的19世纪风格句子了。

## 2025年7月28日

我已经把v0.5上传到了Hugging Face，[点这里查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。现在你可以下载我的仓库并在本地运行。不幸的是nanoGPT不能直接在HuggingFace上运行，所以需要下载并本地运行模型。

另外，我将开始为下一轮训练收集数据，我认为需要5-10倍的数据量才能实现推理能力。

## 2025年8月2日

我很快就要开始开发Version 1了。我需要从nanoGPT的架构过渡到更现代的方案。我考虑了几个开源LLM架构，包括：OpenLLaMA v3、Phi-2和Qwen 1.5B。为了支持V1的升级，我还需要精心整理更大且更丰富的数据集，至少需要5GB的干净训练数据。


# V0模型行为与局限性

早期的提示显示模型会以19世纪的语言和行为作出回应。例如，我用“Who art Henry?”来提示它，它回复说：“I know that man, I have did not a black, the storm.”，是的，这句话没有任何意义，但LLM已经能识别我在问一个人。

![TimeLockLLM示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

没有提及现代概念，输出主要包含19世纪的词汇和表达方式。

它仍然需要大量改进，仅用187MB的数据进行训练不会让你得到一个能进行复杂推理的模型。

目前它生成的句子缺乏完整的句子结构，总体上没有意义，但对于这个训练规模来说很正常。

# V0.5模型行为与局限性

与上一个模型相比有了明显的提升。写作风格和词汇都是维多利亚时期的，几乎每个句子都语法正确并且有恰当的标点。同样，这个模型是从零开始训练的，因此只涉及19世纪的主题。

![TimeLockLLM示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

有很多事实幻觉。许多（几乎100%）细节（日期、事件、历史人物）都是虚构的。而且句子之间并没有真正的联系，有时也许两句话有关联，但大多数时候没有。另一个问题是偶尔会出现“Digitized by Google”这样的尾注，所以下次训练时一定要确保文本被彻底清理。总的来说，我对结果非常满意，它还远不是LLM，但绝对是一个句子生成器。

我学到了很多，接下来几周将开始思考如何做得更好。很快会上传文件！

# 后续计划

（已完成）我打算开始v0.5版本的工作，这次不是用50本书进行训练，而是理想地用500-600本。目前我在用nanoGPT训练1800-1850年间伦敦出版的书籍。挑战在于确保我找到的书没有被更新过或存在现代诠释，而是完全保持原貌的本时期出版物。

我希望用更大语料库训练新模型（v1），可能是v0.5所用数据的5-10倍。我的目标是看看是否能仅通过选择性时序训练让推理能力自发出现，这将是更难的任务，而且我也不确定是否可行，因为历史数据有限。未来几周我将尝试整理出5-10GB的数据集。我相信只要能获得干净高质量的数据并租用GPU，就会有所进展。

# 如何使用本项目

本项目主要聚焦于历史数据的整理、预处理和分词器的构建。我不会涵盖完整的LLM训练过程，相关内容请参考Andrej Karpathy的nanoGPT。

# 第一步：收集并准备历史文本

收集你选定时期（例如，伦敦1800-1850年）的公共领域书籍、文档等的.txt文件。

如有需要，可使用download_texts_improved.py脚本自动下载书籍。

用脚本或手动方式清理文本文件，去除Gutenberg项目的页眉/页脚、现代注释或OCR错误等内容。

prepare_dataset.py脚本应该可以正常工作。

# 第二步：构建自定义分词器

在清理后的数据上运行train_tokenizer.py或train_tokenizer_hf.py。

这会生成vocab.json和merges.txt文件。

这些文件定义了模型的词汇表和合并规则。

# 第三步：训练你的模型（nanoGPT）

训练过程请参考[Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)。

你可以选择训练其他LLM，但我用的是nanoGPT。

# 常见问题解答

## 什么是选择性时序训练？

选择性时序训练（STT）是一种机器学习方法，所有训练数据都严格限定于特定历史时期。这样做是为了模拟该时期的语言和知识，不受现代概念影响。例如，我现在的模型（v0.5）就只用1800-1875年的数据训练，不是微调，而是从零训练，因此输出能反映当时的语言风格和历史背景。

## 为什么不直接用微调或LoRA？

本项目的目标是创造一个没有现代偏见的语言模型。如果用GPT-2进行微调，它已经经过预训练，这些信息不会消失。如果从零训练，语言模型不会假装是古老的，而是真的就是古老的。目前的目标是创造一个只用1800-1850年伦敦出版的书籍知识进行推理的模型。

## 训练用的数据有哪些？

我用的是1800-1850年伦敦的书籍、法律文件、报纸和其他著作。链接中的清单大约有200份，但第一次训练只用了50个文件，约187 MB。你可以查看文档清单：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0版模型有多大？

这个模型现在非常小，我只是出于兴趣并严格遵循不使用现代来源的训练规则。它有将近1600万个参数，但我会开始收集更多的古老文本来进行新一轮模型训练。后续会有进展更新。

## 训练配置？

GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---