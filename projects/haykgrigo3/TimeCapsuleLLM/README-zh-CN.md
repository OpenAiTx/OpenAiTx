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

##  模型行为与局限性

### **v0**  

早期提示显示模型以19世纪的语言和行为进行响应。  
示例：提示：“Who art Henry?”，其回答为：“I know that man, I have did not a black, the storm.”  

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 没有提及现代概念  
- 主要为时代准确的词汇  
- 句子大多不连贯（约187MB训练数据情况下可预期）

### **v0.5** 

相较于v0有显著提升。  
- 维多利亚时期写作风格，标点规范，句子基本语法正确  
- 事实幻觉率依然较高  
- OCR噪声（如“Digitized by Google”）仍出现在输出中

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首个能回忆并关联真实历史事件与数据集实际人物的模型。

示例：提示：“It was the year of our Lord 1834” 

输出：“It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity” 

起初我以为抗议活动可能只是巧合发生在同一年，但请看这里：![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

使用v2的90GB数据集中的15GB样本进行训练。  
模型仅训练了1万步。

由于分词存在问题，输出如下所示：

查尔斯·狄更斯是谁？



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

修正：

“查尔斯·狄更斯是谁？他的作品在戏剧中、在大公司的农场里，是否更能激发人心？我还需要引用杰克·皮克特的话吗？你难道不知道他们是一种奔跑的族类，或是在锯自己的胸膛，或者是在杰克逊正看着窗户的时候要做些什么？一个英国人的成功是什么，而他的儿子却没有向我揭示过，以实现如此重任？你可曾穿越旧路，或在我们船只的船尾锚风处停留过，而你必须离开我们？事实是，无论风会不会在星期六晚上或中午、或北方，或其他方向从平原吹起，我们都不得不描述一个强大的屏障，其效果与现在相同。在这种情况下，至少可以说我们已经离开了那个房间。我相信在《五百倍》中有三份副本可供查阅，作为我们读者中希望……的第一批编号。”

### **v2mini-eval2**

使用与eval1训练相同的15GB样本训练。
模型同样仅训练到10K步。

PROMPT:查尔斯·达尔文

查尔斯·达尔文ECCEMACY。先生，——以下案例对我很有意思：——我在伦敦待了两周，受风湿病发作影响很大。第一次风湿病发作是在见您一周前，第二次是在见您时，第三次也是在见您时，并且这第三次与前一次间隔不大。然而，第二次痛风发作并没有伴随任何发热症状，但伴随着尿量增加和更大量的尿液排出。第三次发作是在见您一小时后，紧接着痛风又发作了一次，且复发速度更快。第四次发作也伴有发热，但并不总是有发热症状。第三次痛风发作是在您生病两周后，第四次则在痛风发作后发生。第四次发作是在您被袭击两周后，伴有一种感觉

### **v2**

使用90GB（112GB标记化）数据集训练
训练至182K步

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM 示例输出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  数据集

### **v2**

- 90GB（原始）1800-1875年伦敦文本
- 136,344份文档
- 完整标记化数据集现已开放获取：https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### 偏见统计
  ![代词偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![时间偏见](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

更多信息请参见 [v2 偏见报告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)。

## 如何使用

本项目主要专注于整理历史数据，为训练做准备并构建分词器。我不会涵盖完整的大型语言模型（LLM）训练过程，如需参考，请查看Andrej Karpathy的nanoGPT。

### 步骤1：收集并准备历史文本

- 收集所选时期的公共领域书籍、文件等的.txt文件（例如，伦敦1800-1850）
- 保持在所选的时间/地点窗口内
- 使用脚本清理文本文件或手动移除古腾堡计划的页眉/页脚、现代注释或OCR错误等内容。

### 步骤2：构建自定义分词器

- 在清理后的数据上运行train_tokenizer.py或train_tokenizer_hf.py。
- 这将生成vocab.json和merges.txt
- 这些文件定义了模型的词表和合并规则

### 步骤3：训练你的模型

- 有关训练过程，请参考[Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)或所选架构的文档。

# 常见问题

## 什么是选择性时间训练？

选择性时间训练（STT）是一种机器学习方法，所有训练数据都专门整理为特定历史时期的数据。这样做是为了模拟该时代的语言和知识，不受现代概念影响。例如，我现在拥有的模型（v0.5）仅在1800-1875的数据上训练，没有微调，而是从零开始训练，因此输出反映了那个时期的语言风格和历史背景。

## 为什么不直接用微调或LoRA？

本项目旨在创建一个不受现代偏见影响的语言模型。如果我微调像GPT-2这样的模型，它已经被预训练，那些信息不会消失。如果我从零开始训练，语言模型不会假装是旧的，它本身就是。当前项目的目标是创建一个能仅用1800至1875年伦敦出版书籍知识进行推理的模型。

## 你用于训练的数据是什么类型？

我使用的是1800–1875年伦敦的书籍、法律文件、报纸和其他著作。我链接的清单（v0）有约200份，但首次训练只用了约50份文件，总大小约187MB。你可以查看文件清单：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

数据集规模：
- v0：约187MB
- v0.5：约435MB
- v1：约6.25GB

- v2mini-eval1：15GB（从v2的90GB中抽样）
- v2：90GB

## 模型有多大？

v0：1600万参数

v0.5：1.23亿参数

v1：7亿参数

v2mini-eval1：3亿参数

v2mini-eval2：2亿参数

v2：12亿参数

## 训练规格？

### v0/v0.5
GPU：Geforce rtx 4060
CPU：i5-13400F
内存：16GB DDR5。

### v1
GPU：租用A100 SXM

### v2mini-eval1/eval2
GPU：租用A100 SXM

### v2
GPU：租用H100 SXM

## 致谢

我要感谢[Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)对学术监督、研究框架和评估的指导，以及在v2版本分词器训练和数据集准备方面的帮助。他的反馈和经验对完善本工作的展示起到了关键作用。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---