<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>رابط الورقة العلمية</b>👁️</a>
</div>

## جدول المحتويات

1. [المقدمة](#1-المقدمة)
2. [ملخص النموذج](#2-ملخص-النموذج)
3. [تنزيل النماذج](#3-تنزيل-النماذج)
4. [نتائج التقييم](#4-نتائج-التقييم)
5. [موقع الدردشة ومنصة API](#5-موقع-الدردشة--منصة-api)
6. [كيفية التشغيل محليًا](#6-كيفية-التشغيل-محليًا)
7. [الترخيص](#7-الترخيص)
8. [الاستشهاد](#8-الاستشهاد)
9. [التواصل](#9-التواصل)

## 1. المقدمة

نقدم لكم DeepSeek-V3، وهو نموذج لغوي قوي من نوع Mixture-of-Experts (MoE) بعدد إجمالي من المعاملات يبلغ 671 مليار، مع تفعيل 37 مليار معامل لكل رمز.  
لتحقيق استدلال فعال وتدريب منخفض التكلفة، يعتمد DeepSeek-V3 على معماريتي Multi-head Latent Attention (MLA) وDeepSeekMoE، واللتين تم التحقق منهما بدقة في DeepSeek-V2.  
علاوة على ذلك، كان DeepSeek-V3 سبّاقًا في تطبيق استراتيجية موازنة التحميل بدون خسارة مساعدة، وحدد هدف تدريب لتوقع متعدد الرموز لتحسين الأداء.  
قمنا بتدريب DeepSeek-V3 مسبقًا على 14.8 تريليون رمز متنوع وعالي الجودة، تلا ذلك مراحل Fine-Tuning بإشراف وتعزيز التعلم (Reinforcement Learning) لاستغلال قدراته بالكامل.  
تكشف التقييمات الشاملة أن DeepSeek-V3 يتفوق على النماذج مفتوحة المصدر الأخرى ويحقق أداءً مماثلاً لأفضل النماذج مغلقة المصدر.
ورغم أدائه الممتاز، يتطلب DeepSeek-V3 فقط 2.788 مليون ساعة GPU من نوع H800 للتدريب الكامل.
بالإضافة إلى ذلك، فإن عملية التدريب كانت مستقرة بشكل ملحوظ.
خلال كامل عملية التدريب، لم نواجه أي ارتفاعات غير قابلة للاسترداد في الخسارة ولم نقم بأي عمليات استرجاع (Rollback).
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. ملخص النموذج

---

**المعمارية: استراتيجية موازنة تحميل وهدف تدريبي مبتكر**

- بالاعتماد على معمارية DeepSeek-V2 الفعالة، قمنا بابتكار استراتيجية موازنة تحميل بدون خسارة مساعدة، مما يقلل من تدهور الأداء الناتج عن تشجيع موازنة التحميل.
- بحثنا هدف توقع متعدد الرموز (Multi-Token Prediction - MTP) وأثبتنا فائدته في أداء النموذج.
  كما يمكن استخدامه في فك التشفير التخميني لتسريع الاستدلال.

---

**التدريب المسبق: نحو كفاءة تدريب قصوى**

- صممنا إطار تدريب بدقة مختلطة FP8، ولأول مرة تحققنا من جدوى وفعالية تدريب FP8 على نموذج واسع النطاق للغاية.
- من خلال التصميم المشترك للخوارزميات والأطر والأجهزة، تغلبنا على عنق الزجاجة في الاتصال أثناء تدريب MoE عبر العقد، واقتربنا من تداخل كامل بين الحسابات والاتصالات.
  وقد عزز ذلك بشكل كبير من كفاءة التدريب وخفض التكاليف، مما أتاح لنا توسيع حجم النموذج دون تكلفة إضافية.
- بتكلفة اقتصادية تبلغ فقط 2.664 مليون ساعة GPU من نوع H800، أكملنا التدريب المسبق لـ DeepSeek-V3 على 14.8 تريليون رمز، مما أنتج أقوى نموذج أساسي مفتوح المصدر حاليًا. وتحتاج مراحل التدريب اللاحقة فقط إلى 0.1 مليون ساعة GPU.

---

**ما بعد التدريب: تقطير المعرفة من DeepSeek-R1**

- قدمنا منهجية مبتكرة لتقطير قدرات الاستدلال من نموذج سلسلة التفكير الطويلة (CoT)، وتحديدًا من أحد نماذج DeepSeek R1، إلى النماذج اللغوية القياسية، وخاصة DeepSeek-V3. حيث يدمج خط العمل الخاص بنا أنماط التحقق والتفكير الخاصة بـ R1 في DeepSeek-V3 ويحسن بشكل ملحوظ أداء الاستدلال لديه. وفي الوقت نفسه، حافظنا على التحكم في نمط وطول إخراج DeepSeek-V3.

---

## 3. تنزيل النماذج

<div align="center">

| **النموذج** | **إجمالي المعاملات** | **المعاملات المفعلة** | **طول السياق** | **التنزيل** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> الحجم الكلي لنماذج DeepSeek-V3 على Hugging Face هو 685 مليار، ويتضمن 671 مليار من أوزان النموذج الرئيسي و14 مليار من أوزان وحدة توقع متعدد الرموز (MTP).

لضمان أداء مثالي ومرونة، تعاونا مع مجتمعات المصادر المفتوحة وبائعي العتاد لتوفير طرق متعددة لتشغيل النموذج محليًا. للاطلاع على الإرشادات خطوة بخطوة، راجع القسم 6: [كيفية التشغيل محليًا](#6-كيفية-التشغيل-محليًا).

للمطورين الراغبين في التعمق، ننصح باستكشاف [README_WEIGHTS.md](./README_WEIGHTS.md) للحصول على تفاصيل حول أوزان النموذج الرئيسي ووحدات توقع متعدد الرموز (MTP). يرجى ملاحظة أن دعم MTP قيد التطوير النشط من قِبل المجتمع، ونرحب بمساهماتكم وملاحظاتكم.

## 4. نتائج التقييم
### النموذج الأساسي
#### مقاييس التقييم القياسية

<div align="center">

|  | المعيار (المقياس) | عدد اللقطات | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | المعمارية | - | MoE | Dense | Dense | MoE |
| | المعاملات المفعلة | - | 21B | 72B | 405B | 37B |
| | إجمالي المعاملات | - | 236B | 72B | 405B | 671B |
| الإنجليزية | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| البرمجة | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| الرياضيات | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| الصينية | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| متعدد اللغات | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> تم إبراز أفضل النتائج بالخط العريض. تعتبر الدرجات التي لا يتجاوز الفارق بينها 0.3 ضمن نفس المستوى. يحقق DeepSeek-V3 الأداء الأفضل في معظم المعايير، خاصة في مهام الرياضيات والبرمجة.
> لمزيد من التفاصيل حول التقييم، يرجى مراجعة الورقة العلمية.

#### نافذة السياق
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

نتائج التقييم على اختبارات "Needle In A Haystack" (NIAH). يُظهر DeepSeek-V3 أداءً جيدًا عبر جميع أطوال نافذة السياق حتى **128K**.

### نموذج الدردشة
#### مقاييس التقييم القياسية (نماذج أكبر من 67 مليار)

<div align="center">

| | **المعيار (المقياس)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | المعمارية | MoE | MoE | Dense | Dense | - | - | MoE |
| | المعاملات المفعلة | 21B | 21B | 72B | 405B | - | - | 37B |
| | إجمالي المعاملات | 236B | 236B | 72B | 405B | - | - | 671B |
| الإنجليزية | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| البرمجة | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| الرياضيات | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| الصينية | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> تم تقييم جميع النماذج في وضع يحد من طول الإخراج إلى 8 آلاف رمز. بالنسبة للمعايير التي تحتوي على أقل من 1000 عينة، تم إجراء اختبارات متعددة باستخدام درجات حرارة مختلفة للحصول على نتائج نهائية قوية. يُعد DeepSeek-V3 أفضل نموذج مفتوح المصدر أداءً، كما يظهر أداءً تنافسياً مقابل النماذج مغلقة المصدر الرائدة.

#### تقييم التوليد المفتوح

<div align="center">

| النموذج | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> تقييمات محادثة مفتوحة باللغة الإنجليزية. بالنسبة لـ AlpacaEval 2.0، نستخدم معدل الفوز المتحكم في الطول كمقياس.

## 5. موقع الدردشة ومنصة API
يمكنك الدردشة مع DeepSeek-V3 على الموقع الرسمي: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

كما نوفر واجهة API متوافقة مع OpenAI على منصة DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. كيفية التشغيل محليًا

يمكن نشر DeepSeek-V3 محليًا باستخدام العتاد التالي وبرمجيات مجتمعات المصدر المفتوح:

1. **عرض DeepSeek-Infer التجريبي**: نوفر عرضًا بسيطًا وخفيفًا للاستدلال بدقة FP8 وBF16.
2. **SGLang**: يدعم نموذج DeepSeek-V3 بشكل كامل في أوضاع الاستدلال BF16 وFP8، مع دعم لتوقع متعدد الرموز [قريبًا](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: يتيح استدلال فعال بدقة FP8 وBF16 للنشر المحلي والسحابي.
4. **TensorRT-LLM**: يدعم حاليًا استدلال BF16 والتكميم إلى INT4/8، مع دعم FP8 قريبًا.
5. **vLLM**: يدعم نموذج DeepSeek-V3 بأوضاع FP8 وBF16 للتوازي على مستوى الموتر وخط الأنابيب.
6. **LightLLM**: يدعم النشر الأحادي أو المتعدد للعقد بكفاءة لكل من FP8 وBF16.
7. **معالجات AMD الرسومية**: يتيح تشغيل النموذج على بطاقات AMD عبر SGLang في أوضاع BF16 وFP8.
8. **وحدات هواوي Ascend NPU**: يدعم تشغيل DeepSeek-V3 على أجهزة هواوي Ascend.

نظرًا لاعتماد التدريب بدقة FP8 في إطار عملنا، فإننا نوفر فقط أوزان FP8. إذا كنت بحاجة إلى أوزان BF16 للتجارب، يمكنك استخدام سكريبت التحويل المقدم.

فيما يلي مثال لتحويل أوزان FP8 إلى BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> لم يتم دعم مكتبة Transformers الخاصة بـ Hugging Face بشكل مباشر حتى الآن.

### 6.1 الاستدلال باستخدام عرض DeepSeek-Infer التجريبي (للاختبار فقط)

#### متطلبات النظام

> [!NOTE] 
> لينكس مع بايثون 3.10 فقط. لا يتم دعم ماك أو ويندوز.

المتطلبات:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### إعداد أوزان النموذج وكود العرض

أولاً، استنسخ مستودع DeepSeek-V3 من GitHub:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

انتقل إلى مجلد `inference` وقم بتثبيت المتطلبات المذكورة في `requirements.txt`. أسهل طريقة هي استخدام مدير حزم مثل `conda` أو `uv` لإنشاء بيئة افتراضية جديدة وتثبيت المتطلبات.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

نزّل أوزان النموذج من Hugging Face وضعها في مجلد `/path/to/DeepSeek-V3`.

#### تحويل أوزان النموذج

حوّل أوزان النموذج من Hugging Face إلى تنسيق محدد:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### التشغيل

بعد ذلك يمكنك الدردشة مع DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

أو إجراء استدلال دفعي على ملف معين:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 الاستدلال باستخدام SGLang (موصى به)

يدعم [SGLang](https://github.com/sgl-project/sglang) حاليًا [تحسينات MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations)، [انتباه التوازي البياني](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models)، FP8 (W8A8)، ذاكرة FP8 KV، وTorch Compile، مما يوفر زمن استجابة وأداء عالي بين الأطر مفتوحة المصدر.

جدير بالذكر أن [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) يدعم تشغيل DeepSeek-V3 بالكامل على كل من بطاقات NVIDIA وAMD، مما يجعله حلًا قويًا ومرنًا للغاية.

يدعم SGLang أيضًا [توازي التنسور متعدد العقد](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208)، مما يتيح لك تشغيل النموذج على عدة أجهزة متصلة بالشبكة.

توقع متعدد الرموز (MTP) قيد التطوير، ويمكن متابعة التقدم في [خطة التحسين](https://github.com/sgl-project/sglang/issues/2591).

إرشادات التشغيل من فريق SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 الاستدلال باستخدام LMDeploy (موصى به)
يدعم [LMDeploy](https://github.com/InternLM/lmdeploy)، وهو إطار استدلال قوي ومرن للنماذج اللغوية الكبيرة، نموذج DeepSeek-V3 الآن. ويوفر معالجة خط الأنابيب غير المتصلة ونشرًا عبر الإنترنت، مع تكامل سهل مع تدفقات عمل PyTorch.

للحصول على تعليمات مفصلة خطوة بخطوة لتشغيل DeepSeek-V3 مع LMDeploy، يرجى الرجوع إلى: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 الاستدلال باستخدام TRT-LLM (موصى به)

يدعم [TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) الآن نموذج DeepSeek-V3، مع خيارات دقة مثل BF16 وINT4/INT8 فقط للأوزان. دعم FP8 قيد التنفيذ وسيتم إصداره قريبًا. يمكنك الوصول إلى الفرع المخصص من TRTLLM لدعم DeepSeek-V3 من خلال الرابط التالي: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.

### 6.5 الاستدلال باستخدام vLLM (موصى به)

يدعم [vLLM](https://github.com/vllm-project/vllm) v0.6.6 استدلال DeepSeek-V3 بأوضاع FP8 وBF16 على كل من NVIDIA وAMD. وبالإضافة إلى التقنيات القياسية، يوفر vLLM _توازي خط الأنابيب_ لتشغيل النموذج على عدة أجهزة متصلة بالشبكة. لمزيد من الإرشادات، يرجى الرجوع إلى [تعليمات vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). كما يمكنكم متابعة [خطة التحسين](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 الاستدلال باستخدام LightLLM (موصى به)

يدعم [LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 النشر المتوازي على مستوى التنسور لجهاز واحد أو عدة أجهزة لـ DeepSeek-R1 (FP8/BF16)، ويوفر نشر بدقة مختلطة مع المزيد من أوضاع التكميم المتكاملة باستمرار. للمزيد، راجع [تعليمات LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). كما يوفر LightLLM نشر PD-disaggregation لـ DeepSeek-V2، وتنفيذ هذه الميزة لـ DeepSeek-V3 قيد التطوير.

### 6.7 الاستدلال الموصى به على معالجات AMD

بالتعاون مع فريق AMD، تم تحقيق دعم Day-One لمعالجات AMD باستخدام SGLang، مع توافق كامل لكل من FP8 وBF16. لمزيد من الإرشادات، راجع [تعليمات SGLang](#63-الاستدلال-باستخدام-lmdeploy-موصى-به).

### 6.8 الاستدلال الموصى به على وحدات هواوي Ascend NPU
تمكن إطار [MindIE](https://www.hiascend.com/en/software/mindie) من مجتمع هواوي Ascend من تكييف نسخة BF16 من DeepSeek-V3 بنجاح. لإرشادات خطوة بخطوة حول أجهزة Ascend، يرجى اتباع [التعليمات هنا](https://modelers.cn/models/MindIE/deepseekv3).

## 7. الترخيص
هذا المستودع مرخص بموجب [رخصة MIT](LICENSE-CODE). استخدام نماذج DeepSeek-V3 Base/Chat يخضع لـ [رخصة النموذج](LICENSE-MODEL). تدعم سلسلة DeepSeek-V3 (بما في ذلك Base وChat) الاستخدام التجاري.

## 8. الاستشهاد
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. التواصل
إذا كانت لديك أي أسئلة، يرجى فتح تذكرة أو التواصل معنا عبر البريد الإلكتروني [service@deepseek.com](service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---