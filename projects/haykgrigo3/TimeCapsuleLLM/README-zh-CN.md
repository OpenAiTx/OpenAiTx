<div align="right">
  <details>
<summary>🌐 语言</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*一种从头开始训练，仅使用特定地点和时期数据的语言模型，以减少现代偏见并模拟那个时代的语调、词汇和世界观。*

想象一下，如果一个AI模型不仅仅是假装是历史的，而是真正如此。

v0 和 v0.5 基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 构建，核心训练脚本和模型架构均为其作品。

v1 基于 [微软的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5) 构建

v2 基于 llamaforcausallm 构建

[Hugging Face 链接](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## 研究状态
本项目为独立发起和开发。

目前在学术监督下进行，并与穆伦堡学院有合作研究关系。

## 引用

如果您在学术工作中使用了本数据集或模型，请引用：


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## 加入 Vintage LLM Discord

如果你对**历史语言模型**、**特定时期的数据集**或像**TimeCapsuleLLM**、**Violet-1.4B**、**Mr. Chatterbox**这样的项目的未来感兴趣，请加入我们的社区。

我们使用服务器来讨论想法、分享进展，并与在该领域构建项目的其他人交流。

[加入 Discord](https://discord.gg/JeWkk4z5)

## 模型行为与局限性

### **v0**  

早期提示展示了模型以1800年代的语言和行为进行回应。
示例：提示：“Who art Henry?”，模型回复：“I know that man, I have did not a black, the storm。”

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 没有提及现代概念  
- 主要使用时代准确的词汇  
- 句子大多不连贯（约187MB训练数据，符合预期）

### **v0.5-london** 

相比v0有显著提升。  
- 维多利亚时期的写作风格，标点正确，句子大多语法正确  
- 事实幻觉率仍然很高  
- 输出中仍有OCR噪声（如“Digitized by Google”）

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

第一个能够回忆并连接数据集中真实历史事件与实际人物的模型。

示例：提示：“It was the year of our Lord 1834” 

输出：“It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

起初我以为抗议可能恰好发生在同一年，但请看这个： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

使用了v2的90GB数据集中15GB的样本进行训练。
模型仅训练到1万步。

在分词过程中出现了问题，导致输出如下：

提示：
查尔斯·狄更斯是谁？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

修正：

“谁是查尔斯·狄更斯？他在他的戏剧、在大公司的农场中，这些作品是否更具振奋人心的效果？我还需要引用杰克·皮克特的哪些内容？你难道不知道他们是一种疾驰的物种，或者是在锯着他们的胸膛，或者在杰克逊在窗前观望的时候应该做些什么？一个英国人的成功是什么，他的儿子至今未向我揭示，这样才能完成如此重大的任务？你曾经走过老公路，或者在我们船只的船脚处停泊过锚风吗，你必须离开我们？事实上，不论风是在星期六晚上或正午从平原吹起，还是吹向北方，或其他方向，我们都将被迫描述一个强大的屏障，其效果与现状相同。在这种情况下，至少可以说我们已经离开了那个房间。我相信在‘五百倍’中有三份副本，可以参考，作为我们读者中希望...”

### **v2mini-eval2-london**

使用与eval1训练相同的15GB样本进行训练。
模型同样仅训练到1万步。

提示：查尔斯·达尔文

查尔斯·达尔文 ECCEMACY。先生，——以下案例对我很有趣：——我在伦敦待了两周，并因风湿病发作而深受影响。第一次风湿病发作是在见您前一周，第二次是在见您时，第三次也是在见您时，第三次还是同一时间。第二次痛风发作并未伴有任何发热症状，但伴随尿液增多，并且尿液排放更加丰富。第三次发作是在见您后一小时，随后出现了痛风阵发的复发，并且痛风复发速度更快。第四次发作也伴有发热，但并不总是伴有任何发热症状。第三次痛风发作是在您生病两周后，第四次则是在痛风阵发之后。第四次发作是在您被袭击两周后，并伴有一种感觉

### **v2-london**

使用90GB（112GB标记化）数据集进行训练
训练至182K步

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **接下来会发生什么？**

- TimeCapsuleLLM v3的开发已经开始
- 扩展数据集规模及地理覆盖范围
- 从伦敦扩展到其他城市

该工作与伦敦大学学院（UCL）的研究人员合作进行，并正在讨论更多机构参与。 

## 数据集

### **v2**

- 90GB（原始）的1800-1875年伦敦文本
- 136,344份文档
- 完整标记化数据集现已开放下载：https://huggingface.co/datasets/postgrammar/london-llm-1800


### 偏见统计
  ![代词偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![时间偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

有关更多信息，请参阅 [v2 偏见报告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)。


- 


## 如何使用

本项目主要聚焦于整理历史数据，为训练做准备并构建分词器。我不会涵盖完整的大型语言模型训练流程，相关内容请参考 Andrej Karpathy 的 nanoGPT。

### 步骤 1：收集并准备历史文本

- 收集你选定时间段（例如伦敦 1800-1875）的公共领域书籍、文档等的 .txt 文件
- 保持在你所选的时间/地点窗口内
- 使用脚本或手动清理文本文件，去除古登堡计划的页眉/页脚、现代注释或诸如 OCR 错误等内容。

### 步骤 2：构建自定义分词器

- 在清理后的数据上运行 train_tokenizer.py 或 train_tokenizer_hf.py。
- 这会生成 vocab.json 和 merges.txt
- 这些文件定义了你的模型的词表和合并规则

### 步骤 3：训练你的模型

- 训练流程请参考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 或你所选架构的文档。

# 常见问题

## 什么是选择性时间训练？

选择性时间训练（Selective Temporal Training，简称 STT）是一种机器学习方法，所有训练数据都经过专门策划，仅限于特定历史时期。这样做的目的是建模该时代的语言和知识，不受现代概念影响。例如，我当前的模型（v0.5）仅用 1800-1875 年的数据训练，完全从零开始训练，没有微调，因此输出能反映当时的语言风格和历史背景。

## 为什么不直接使用微调或 LoRA？
对于这个项目，我正在尝试创建一个不受现代偏见影响的语言模型。如果我微调类似 GPT-2 的模型，它已经经过预训练，这些信息不会消失。如果我从零开始训练，语言模型不会假装是旧的，它本身就是旧的。该项目目前的目标是创建一个能够仅使用 1800 年至 1875 年伦敦出版书籍知识进行推理的模型。

## 你用什么样的数据进行训练？

我使用的是 1800–1875 年伦敦的书籍、法律文件、报纸以及其他著作。我链接的清单（v0）大约有 200 个，但第一次训练时我只用了 50 个文件，约 187 MB。你可以查看文件列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

数据集大小：
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB（v2 的 90GB 样本）
- v2: 90GB

## 模型有多大？

v0: 1600万参数

v0.5: 1.23亿参数

v1: 7亿参数

v2mini-eval1: 3亿参数

v2mini-eval2: 2亿参数

v2: 12亿参数

## 训练规格？

### v0/v0.5
GPU：Geforce rtx 4060
CPU：i5-13400F 
内存：16GB DDR5。

### v1
GPU：租用的 A100 SXM

### v2mini-eval1/eval2

GPU：A100 SXM 租赁

### v2
GPU：H100 SXM 租赁

## 相关工作

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B 参数的 LLM，基于 1930 年前 2600 亿标记的文本进行 Q&A 训练。也有一个[基础版](https://huggingface.co/talkie-lm/talkie-1930-13b-base)。
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B 参数的 LLM，基于 1800-1899 年的文本进行 Q&A 训练。也有一个[160M](https://huggingface.co/zakarth/violet-160m-chat)版本。
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M 参数的 LLM，基于 1837-1899 年间的 28,000 多篇文本进行 Q&A 训练。

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - 4B 参数的 LLM 系列，基于 Qwen3 架构从零开始训练，数据为 800 亿历史标记，知识截止至 1913、1929、1933、1939、1946。

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT 是 Mistral-Hermes 2 的微调版，基于 11,000 篇早期现代英语、法语和拉丁语文本（主要来自 EEBO 和 Gallica）。

## 致谢

我感谢 [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) 提供学术监督、研究框架和评估指导，并在 v2 版本的分词器训练和数据集准备方面给予帮助。他的反馈和经验对本工作的完善起到了关键作用。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---