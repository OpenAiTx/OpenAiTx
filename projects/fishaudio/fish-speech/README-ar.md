<div align="center">
<h1>خطاب السمكة</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **إشعار الترخيص**  
> تم إصدار قاعدة الشيفرة هذه تحت **رخصة أباتشي** وجميع أوزان النماذج تم إصدارها تحت **رخصة CC-BY-NC-SA-4.0**. يرجى الرجوع إلى [LICENSE](LICENSE) لمزيد من التفاصيل.

> [!WARNING]
> **إخلاء مسؤولية قانونية**  
> نحن لا نتحمل أي مسؤولية عن أي استخدام غير قانوني لقاعدة الشيفرة. يرجى الرجوع إلى القوانين المحلية الخاصة بك حول DMCA والقوانين الأخرى ذات الصلة.

---

## 🎉 إعلان

يسعدنا أن نعلن أننا قمنا بإعادة تسمية المشروع إلى **OpenAudio** — مقدمين سلسلة جديدة ثورية من نماذج تحويل النص إلى كلام المتقدمة التي تبني على أساس Fish-Speech.

نفخر بإصدار **OpenAudio-S1** كأول نموذج في هذه السلسلة، حيث يقدم تحسينات كبيرة في الجودة والأداء والإمكانات.

يأتي OpenAudio-S1 في نسختين: **OpenAudio-S1** و **OpenAudio-S1-mini**. كلا النموذجين متاحان الآن على [Fish Audio Playground](https://fish.audio) (لـ **OpenAudio-S1**) و [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (لـ **OpenAudio-S1-mini**).

قم بزيارة [موقع OpenAudio](https://openaudio.com/blogs/s1) للمدونة والتقرير التقني.

## النقاط البارزة ✨

### **جودة TTS ممتازة**

نستخدم مقاييس تقييم Seed TTS لتقييم أداء النموذج، وتظهر النتائج أن OpenAudio S1 يحقق **0.008 WER** و **0.004 CER** على النص الإنجليزي، وهو أفضل بشكل ملحوظ من النماذج السابقة. (إنجليزي، تقييم تلقائي، بناءً على OpenAI gpt-4o-transcribe، مسافة المتكلم باستخدام Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| النموذج | معدل الخطأ في الكلمات (WER) | معدل الخطأ في الأحرف (CER) | مسافة المتكلم |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **أفضل نموذج في TTS-Arena2** 🏆

حقق OpenAudio S1 **المرتبة الأولى** على [TTS-Arena2](https://arena.speechcolab.org/)، وهو المعيار المرجعي لتقييم تحويل النص إلى كلام:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="ترتيب TTS-Arena2" style="width: 75%;" />
</div>

### **التحكم في الكلام**

يدعم OpenAudio S1 **مجموعة متنوعة من المؤشرات العاطفية، ونبرات الصوت، والمؤثرات الخاصة** لتعزيز توليد الكلام:

- **المشاعر الأساسية**:
```
(غاضب) (حزين) (متحمس) (مندهش) (راضٍ) (مبتهج) 
(خائف) (قلق) (منزعج) (متوتر) (محبط) (مكتئب)
(متعاطف) (محرج) (مشمئز) (متأثر) (فخور) (مرتاح)
(ممتن) (واثق) (مهتم) (فضولي) (مرتبك) (مبتهج)
```

- **المشاعر المتقدمة**:
```
(ساخر) (غير سعيد) (قلق) (هستيري) (غير مبالٍ) 
(غير صبور) (مذنب) (محتقر) (مذعور) (غاضب جدًا) (متردد)
(متلهف) (رافض) (سلبي) (منكر) (مندهش جدًا) (جاد)
(ساخر بحدة) (تصالحي) (مواسي) (صادق) (متهكم)
(متردد) (متنازل) (متألم) (محرج) (مستمتع)
```

- **مؤشرات النبرة**:
```
(نبرة مستعجلة) (يصرخ) (يصرخ بشدة) (يهمس) (نبرة ناعمة)
```

- **المؤثرات الصوتية الخاصة**:
```
(يضحك) (يقهقه) (يبكي قليلاً) (يبكي بشدة) (يتنهد) (يلهث)
(يئن) (ضحك جماعي) (ضحك في الخلفية) (ضحك الجمهور)
```

يمكنك أيضًا استخدام ها، ها، ها للتحكم، وهناك العديد من الحالات الأخرى التي يمكنك استكشافها بنفسك.

(الدعم للإنجليزية، الصينية واليابانية حالياً، والمزيد من اللغات قادم قريباً!)

### **نوعان من النماذج**

| النموذج | الحجم | التوافر | الميزات |
|-------|------|--------------|----------|
| **S1** | 4 مليار معلمة | متوفر على [fish.audio](fish.audio) | نموذج متكامل المزايا |
| **S1-mini** | 0.5 مليار معلمة | متوفر على huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | نسخة مختزلة بالقدرات الأساسية |

كلا النموذجين S1 و S1-mini يدمجان التعلم المعزز عبر الإنترنت من ملاحظات البشر (RLHF).

## **الميزات**

1. **تحويل نص إلى كلام من عينة واحدة أو قليلة:** أدخل عينة صوتية من 10 إلى 30 ثانية لإنشاء إخراج TTS عالي الجودة. **للاطلاع على الإرشادات التفصيلية، راجع [أفضل ممارسات استنساخ الصوت](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **دعم متعدد اللغات وعبر اللغات:** ببساطة انسخ والصق نصًا متعدد اللغات في مربع الإدخال — لا داعي للقلق بشأن اللغة. يدعم حالياً الإنجليزية، اليابانية، الكورية، الصينية، الفرنسية، الألمانية، العربية، والإسبانية.

3. **لا يعتمد على الفونيمات:** يتمتع النموذج بقدرات تعميم قوية ولا يعتمد على الفونيمات في تحويل النص إلى كلام. يمكنه التعامل مع النص بأي نظام كتابة لغوي.

4. **دقة عالية:** يحقق معدل خطأ منخفض في الأحرف (CER) حوالي 0.4% ومعدل خطأ في الكلمات (WER) حوالي 0.8% لتقييم Seed-TTS.

5. **سريع:** مع تسريع fish-tech، عامل الزمن الحقيقي تقريباً 1:5 على لابتوب Nvidia RTX 4060 و1:15 على Nvidia RTX 4090.

6. **استدلال عبر واجهة ويب:** يتميز بواجهة ويب سهلة الاستخدام تعتمد على Gradio ومتوافقة مع Chrome وFirefox وEdge وغيرها من المتصفحات.

7. **استدلال عبر واجهة رسومية:** يوفر واجهة رسومية PyQt6 تعمل بسلاسة مع خادم API. يدعم لينكس، ويندوز وmacOS. [انظر الواجهة الرسومية](https://github.com/AnyaCoder/fish-speech-gui).

8. **سهل النشر:** إعداد خادم الاستدلال بسهولة مع دعم أصلي للينكس، ويندوز (MacOS قادم قريبًا)، مع تقليل فقدان السرعة لأدنى حد.

## **الوسائط والعروض التوضيحية**

<div align="center">

### **وسائل التواصل الاجتماعي**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="أحدث عرض على X" />
</a>

### **عروض تفاعلية**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="جرب OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="جرب S1 Mini" />
</a>

### **عروض الفيديو**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **عينات صوتية**
<div style="margin: 20px 0;">
    <em>ستتوفر قريبًا عينات صوتية عالية الجودة، توضح قدراتنا في تحويل النص إلى كلام بعدة لغات ومشاعر مختلفة.</em>
</div>

</div>

---

## المستندات

- [بيئة البناء](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [الاستدلال](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## الشكر والتقدير

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## التقرير التقني (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---