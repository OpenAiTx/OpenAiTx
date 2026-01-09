<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (即将推出)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (即将推出)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*一种从零开始，仅在特定地点和时间段的数据上训练的语言模型，旨在减少现代偏见，并模拟那个时代的语音、词汇和世界观。*

想象一下，如果一个AI模型不仅仅是假装是历史的，而是真的如此。

v0 和 v0.5 基于 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 构建，核心训练脚本和模型架构为其作品。

v1 基于 [微软的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5) 构建

[Hugging Face 链接](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  模型行为与局限性

### **v0**  

早期提示显示模型以 1800 年代的语言和行为进行回应。
示例：提示：“Who art Henry?”，回复为：“I know that man, I have did not a black, the storm.”

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 无现代概念的描述  
- 主要为时代准确的词汇  
- 句子大多不连贯（约 187MB 训练数据，预期如此）

### **v0.5** 

相较于 v0 有显著提升。  
- 维多利亚时期的写作风格，标点正确，句子大多语法正确  
- 事实幻觉率仍然很高  
- 输出中仍有 OCR 噪音（如“Digitized by Google”）

![TimeLockLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首个能够回忆并将真实历史事件与数据集中的实际人物联系起来的模型。

示例：提示：“It was the year of our Lord 1834” 

输出为：“It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity” 

起初我以为抗议活动可能只是巧合发生在同一年，但请看这个：![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

使用 v2 90GB 数据集中的 15GB 样本训练。

模型仅训练了1万步。

存在分词问题，导致输出看起来像这样：

提示词：
查尔斯·狄更斯是谁？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

修正：

“查尔斯·狄更斯是谁？在他的剧作、在大公司的农场里，是否有更多他那激动人心的作品？我还需要引用杰克·皮克特的哪些内容？你难道不知道他们曾是一种疾驰，或是锯割胸膛的族类，或者在杰克逊望着窗户的时候该做些什么吗？一个英国人的成功是什么，他的儿子还没有向我揭示的，那种可以完成如此重任的方法？你曾经走过那条旧路，或是在我们船的底部抛锚乘风，而你必须离开我们吗？事实上，无论风是在星期六夜晚还是正午从平原升起，还是向北，或其他方向，我们都将被迫描述一个巨大的障碍，其效果与当前相同。在这种情况下，至少可以说我们已经离开了那个房间。我相信在《五百倍》中有三份副本可供参考，作为我们首批希望……的读者。”

### **v2mini-eval2**

使用与eval1相同的15GB样本进行训练。
模型同样仅训练了10K步。

PROMPT:查尔斯·达尔文

查尔斯·达尔文ECCEMACY。先生，——以下案例对我来说很有趣：——我在伦敦呆了两周，受到风湿病发作的影响很大。第一次风湿病发作是在见您前一周，第二次是在见您时，第三次也是在见您时，并且第三次发生在同一时间。然而，第二次痛风发作并没有伴随任何热症状，但伴随着尿液流量增加，以及更大量的尿液排出。第三次发作是在见您后一小时，并且随后出现了痛风的阵发性复发，并且痛风复发更为迅速。第四次发作也伴有发热，但并不总是伴随热症状。第三次痛风发作是在您生病两周后，第四次则伴随着痛风阵发。第四次发作是在您被感染两周后，并伴有一种感觉


## 数据集

### **v2**

- 90GB的1800-1875年伦敦文本
- 136,344份文档
- 全部90GB尚未可用，因为尚未完成分词，但你可以在此找到15GB样本：https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### 偏见统计 
  ![代词偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![时间偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

更多信息请参考 [v2偏见报告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)。


## 如何使用

本项目主要聚焦于历史数据的整理、训练准备及分词器构建。不涵盖完整的LLM训练流程，相关内容请参考Andrej Karpathy的nanoGPT。

### 步骤1：收集和准备历史文本 

- 收集所选时期（如伦敦1800-1850年）公共领域书籍、文档等的.txt文件
- 保持它们在你选择的时间/地点范围内  
- 使用脚本或手动清理文本文件，移除古腾堡计划的页眉/页脚、现代注释或OCR错误等内容。

### 第2步：构建自定义分词器

- 在清理后的数据上运行 train_tokenizer.py 或 train_tokenizer_hf.py。
- 这将生成 vocab.json 和 merges.txt
- 这些文件定义了你的模型的词汇表和合并规则

### 第3步：训练你的模型

- 有关训练过程，请参考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 或你选择的架构文档。

# 常见问题解答

## 什么是选择性时间训练？

选择性时间训练（STT）是一种机器学习方法，所有训练数据都经过特别策划，确保仅包含特定历史时期的数据。这样可以在不受现代概念影响的情况下，模拟那个时代的语言和知识。例如，我当前的模型（v0.5）仅用1800-1875年间的数据训练，它不是微调的，而是从零开始训练，因此输出能反映出那个时代的语言风格和历史背景。

## 为什么不用微调或LoRA？

对于这个项目，我希望创建一个不受现代偏见影响的语言模型。如果我微调像GPT-2这样的模型，它已经经过预训练，这些信息是无法抹去的。如果我从零开始训练，语言模型不会“假装”是旧的，它本身就是。当前项目目标是创建一个只能用1800到1875年伦敦出版的书籍知识进行推理的模型。

## 用了什么数据进行训练？

我使用了1800–1875年伦敦的书籍、法律文件、报纸和其他著作。我之前链接的列表（v0）大约有200个文件，但第一次训练只用了50个文件，约187MB。你可以查看文档列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

数据集大小：
- v0：约187MB
- v0.5：约435MB 
- v1：约6.25GB 
- v2mini-eval1：15GB

## 模型有多大？

v0：1600万参数

v0.5 1.23亿参数

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---