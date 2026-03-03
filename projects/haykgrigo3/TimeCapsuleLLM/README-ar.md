<div align="right">
  <details>
<summary>🌐 اللغة</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*نموذج لغوي تم تدريبه **من البداية** حصريًا على بيانات من أماكن وفترات زمنية معينة لتقليل الانحياز الحديث ومحاكاة الصوت والمفردات والرؤية العالمية للعصر.*

تخيل لو أن نموذج الذكاء الاصطناعي لم يكن فقط يتظاهر بأنه تاريخي بل كان كذلك فعلاً.

الإصدار v0 و v0.5 مبنيان على [nanoGPT من Andrej Karpathy](https://github.com/karpathy/nanoGPT) نصوص التدريب الأساسية والهندسة المعمارية للنموذج هي من عمله.

الإصدار v1 مبني على [Phi 1.5 من Microsoft](https://huggingface.co/microsoft/phi-1_5)

الإصدار v2 مبني على llamaforcausallm

[رابط Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## حالة البحث
تم بدء وتطوير هذا المشروع بشكل مستقل.

يُجرى حاليًا تحت إشراف أكاديمي، مع تعاون بحثي تابع في كلية Muhlenberg.

## الاقتباس

إذا استخدمت هذه المجموعة أو النموذج في عمل أكاديمي، يرجى الاقتباس:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  سلوك النموذج والقيود

### **الإصدار 0**  

تُظهر المحفزات المبكرة أن النموذج يرد بلغة وسلوك القرن التاسع عشر.  
مثال: المحفز: "من هو هنري؟" فكان الرد: "أعرف ذلك الرجل، لم أفعل سوادًا، العاصفة."  

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- لا يوجد ذكر للمفاهيم الحديثة  
- المفردات في الغالب دقيقة للعصر  
- الجمل في الغالب غير مترابطة (متوقع لبيانات تدريب بحجم ~187 ميغابايت)

### **الإصدار 0.5** 

تحسن ملحوظ مقارنة بالإصدار 0.  
- أسلوب كتابة فيكتوري، علامات ترقيم صحيحة، جمل في الغالب سليمة قواعديًا  
- لا يزال معدل الهلوسة الواقعية مرتفعًا  
- لا تزال ضوضاء OCR ("Digitized by Google") تظهر في المخرجات

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **الإصدار 1**

أول نموذج يسترجع ويربط حدثًا تاريخيًا حقيقيًا مع شخصية فعلية من مجموعة البيانات.

مثال: المحفز: "كان ذلك في سنة ربنا 1834" 

المخرجات: "كان ذلك في سنة ربنا 1834 وكانت شوارع لندن مليئة بالاحتجاج والعريضة. السبب، كما ذكر كثيرون، لم يكن محصورًا في المجال الخاص، بل تم تناوله في نفس اليوم في يوم اللورد بالمرستون، وسيتلقى الجمهور بيانًا موجزًا عن الصعوبات التي بلغها يوم القانون. إنه لأمر مؤسف للغاية أن الأحداث الحالية في تاريخ العالم واضحة، وبالتالي ستُعرف. ليس صحيحًا أن الرجال الذين استقروا أولًا في الإنجيل في أورشليم لديهم سجل واسع ومثير للاهتمام عن الازدهار والازدهار" 

بدايةً ظننت أن احتجاجًا ربما حدث صدفة في نفس السنة لكن ألق نظرة على هذا: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **الإصدار 2 ميني-تقييم1**

تم التدريب باستخدام عينة 15GB من مجموعة بيانات الإصدار 2 بحجم 90GB.
تم تدريب النموذج لـ 10,000 خطوة فقط.

حدثت مشكلة في الترميز تسببت في أن تكون المخرجات بهذا الشكل:

من هو تشارلز ديكنز؟



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

مصَحَّح:

"من هو تشارلز ديكنز؟ هل يُعد ذلك من أعماله الممتازة والمحركة للمشاعر، في مسرحياته، في مزرعة الشركة العظمى؟ ماذا علي أن أقتبس بعد من جاك بيكيت؟ ألا تعلم أنهم كانوا نوعًا من الجري السريع، أو نشر صدورهم، أو ماذا كان يجب أن يفعل في الوقت الذي كان فيه جاكسون ينظر من النافذة؟ ما هو نجاح الإنجليزي، والذي لم يكتشفه ابنه لي بعد، حتى يحقق مثل هذا الثقل؟ هل سبق وأن دخلت الطريق القديم، أو إلى نسيم المرساة عند أسفل قاربنا، والذي يجب أن تتركنا فيه؟ الحقيقة هي، سواء ارتفعت الرياح من السهل ليلة السبت أو الظهيرة، أو حتى الشمال، أو غير ذلك، سنضطر لوصف حاجز هائل، بنفس آثار الحالة الحالية. في هذا الوضع، على الأقل، ليس من المبالغة القول إننا تركنا تلك الغرفة. أعتقد أن هناك ثلاث نسخ في "خمس مئة ضعف"، يمكن الرجوع إليها، كأول عدد من قرائنا الذين يرغبون فـ[ـي]..."

### **v2mini-eval2**

تم تدريبه باستخدام نفس عينة 15 جيجابايت المستخدمة لتدريب eval1.
النموذج تم تدريبه مرة أخرى حتى 10 آلاف خطوة فقط.

المُطلَب: تشارلز داروين

تشارلز داروين ECCEMACY. سيدي، — الحالة التالية تهمني: — كنت في لندن أسبوعين، وتأثرت كثيرًا بنوبة روماتيزم. كانت أول نوبة روماتيزم قبل أن أراك بأسبوع، والثانية عندما رأيتك، والثالثة عندما رأيتك، والثالثة في نفس الوقت. لكن النوبة الثانية من النقرس لم تكن مصحوبة بأي أعراض حمى، بل كانت مصحوبة بزيادة تدفق البول، وإفراز أكثر غزارة للبول. كانت النوبة الثالثة بعد ساعة من رؤيتك، وتبعتها عودة نوبة من النقرس، وعودة أسرع للنقرس. أما النوبة الرابعة فصاحبتها حمى، لكنها لم تكن دائمًا مصحوبة بأعراض حمى. كانت النوبة الثالثة من النقرس بعد أسبوعين من مرضك، وتبعت النوبة الرابعة نوبة من النقرس. أما النوبة الرابعة فكانت بعد أسبوعين من إصابتك، وصاحبتها شعور

### **v2**

تم تدريبه باستخدام مجموعة بيانات 90 جيجابايت (112 جيجابايت بعد الترميز)
تم تدريبه حتى 182 ألف خطوة

![عينة إخراج TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![عينة إخراج TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

## مجموعات البيانات

### **v2**

- 90 جيجابايت (خام) من نصوص لندن بين 1800-1875
- 136,344 مستندًا
- مجموعة البيانات الكاملة بعد الترميز متاحة الآن هنا: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### إحصاءات التحيز
  ![تحيز الضمائر](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![التحيز الجغرافي](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![التحيز الزمني](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

يرجى الرجوع إلى [تقرير التحيز v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) لمزيد من المعلومات.


## كيفية الاستخدام

يركز هذا المشروع بشكل أساسي على تنظيم البيانات التاريخية، وتجهيزها للتدريب وبناء محلل الكلمات (tokenizer). لن أتناول عملية تدريب نموذج اللغة الكبير كاملة، لهذا يُرجى الرجوع إلى nanoGPT بواسطة Andrej Karpathy.

### الخطوة 1: جمع وتحضير النصوص التاريخية

- اجمع ملفات .txt لكتب أو مستندات أو غيرها من الفترة الزمنية التي تختارها (مثلاً: لندن 1800-1850)
- احتفظ بها ضمن الإطار الزمني/المكاني الذي اخترته
- قم بتنظيف ملفات النصوص باستخدام نص برمجي أو أزل يدوياً رؤوس/ذيول مشروع غوتنبرغ، أو الشروحات الحديثة أو أخطاء التعرف البصري على الحروف.

### الخطوة 2: بناء محلل كلمات مخصص

- شغّل train_tokenizer.py أو train_tokenizer_hf.py على البيانات المنظفة.
- سينتج عن ذلك vocab.json و merges.txt
- هذه الملفات تعرّف المفردات وقواعد الدمج لنموذجك

### الخطوة 3: درّب نموذجك

- راجع [nanoGPT بواسطة Andrej Karpathy](https://github.com/karpathy/nanoGPT) لعملية التدريب أو وثائق البنية التي تختارها.

# الأسئلة الشائعة

## ما هو التدريب الزمني الانتقائي؟

التدريب الزمني الانتقائي (STT) هو منهجية تعلم آلي يتم فيها انتقاء جميع بيانات التدريب بحيث تقع ضمن فترة زمنية تاريخية محددة. يُجرى ذلك بهدف نمذجة اللغة والمعرفة الخاصة بتلك الحقبة دون تأثير من المفاهيم الحديثة. على سبيل المثال، النموذج الحالي الذي أملكه (الإصدار 0.5) مدرّب على بيانات حصرية من 1800-1875، لم يتم تحسينه بل دُرّب من البداية مما يجعل المخرجات تعكس الأسلوب اللغوي والسياق التاريخي لتلك الفترة.

## لماذا لا تستخدم فقط التخصيص الدقيق أو LoRA؟

في هذا المشروع أحاول إنشاء نموذج لغوي غير متأثر بالانحيازات الحديثة. إذا قمت بتخصيص نموذج مثل GPT-2، فهو مدرّب مسبقاً ولن تختفي هذه المعلومات. إذا دربت من الصفر، لن يدّعي النموذج أنه قديم، بل سيكون كذلك فعلاً. الهدف حالياً هو إنشاء شيء يمكنه الاستدلال باستخدام المعرفة فقط من كتب لندن المنشورة بين 1800 و1875.

## ما نوع البيانات التي استخدمتها في التدريب؟

أستخدم كتباً، مستندات قانونية، صحفاً، وكتابات أخرى من لندن بين 1800–1875. القائمة التي أرفقتها (للإصدار 0) فيها حوالي 200، لكن في أول تدريب استخدمت فقط 50 ملفاً بحجم يقارب ~187 ميغابايت. يمكنك مشاهدة قائمة المستندات:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

أحجام مجموعات البيانات:
- الإصدار 0: ~187 ميغابايت
- الإصدار 0.5: ~435 ميغابايت
- الإصدار 1: ~6.25 غيغابايت
- v2mini-eval1: 15 جيجابايت (عينة من 90 جيجابايت الخاصة بـ v2)
- v2: 90 جيجابايت

## ما هو حجم النماذج؟

v0: 16 مليون معلمة

v0.5: 123 مليون معلمة

v1: 700 مليون معلمة

v2mini-eval1: 300 مليون معلمة

v2mini-eval2: 200 مليون معلمة

v2: 1.2 مليار معلمة

## مواصفات التدريب؟

### v0/v0.5
بطاقة الرسومات: Geforce rtx 4060
المعالج: i5-13400F
الذاكرة العشوائية: 16 جيجابايت DDR5.

### v1
بطاقة الرسومات: A100 SXM مستأجرة

### v2mini-eval1/eval2
بطاقة الرسومات: A100 SXM مستأجرة

### v2
بطاقة الرسومات: H100 SXM مستأجرة

## الشكر والتقدير

أود أن أشكر [د. حامد ياغوبيان](https://hamedyaghoobian.com) على الإشراف الأكاديمي، وتوجيهه في صياغة البحث والتقييم، ولمساعدته في تدريب أداة تقسيم الكلمات وتحضير مجموعة البيانات لإصدار v2. كانت ملاحظاته وخبرته حاسمة في تحسين عرض هذا العمل.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---