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
## انضم إلى سيرفر Vintage LLM على Discord

إذا كنت مهتمًا بنماذج اللغة التاريخية، أو مجموعات البيانات المرتبطة بفترات زمنية محددة، أو مستقبل مشاريع مثل TimeCapsuleLLM و Violet-1.4B و Mr. Chatterbox، انضم إلى مجتمعنا.

نستخدم السيرفر لمناقشة الأفكار، ومشاركة التقدم، والتواصل مع الآخرين العاملين في هذا المجال.

[انضم إلى Discord](https://discord.gg/JeWkk4z5)

## سلوك النموذج والقيود

### **v0**

العينات المبكرة تظهر استجابة النموذج بلغة وسلوك القرن التاسع عشر.
مثال: سؤال: "من هو هنري؟" ورد النموذج: "أعرف ذلك الرجل، لم أفعل أسود، العاصفة."

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- لا يوجد ذكر لمفاهيم حديثة
- المفردات دقيقة إلى حد كبير لفترة العصر
- الجمل غالبًا غير مترابطة (متوقع مع بيانات تدريب بحجم ~187MB)

### **v0.5-london**

تحسن كبير مقارنة بالإصدار v0.
- أسلوب كتابة فيكتوري، علامات ترقيم مناسبة، جمل نحوية سليمة في الأغلب
- لا يزال معدل الهلوسة الواقعية عاليًا
- ضجيج OCR ("Digitized by Google") لا يزال يظهر في المخرجات

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

أول نموذج يستدعي ويربط حدثًا تاريخيًا حقيقيًا بشخصية فعلية من مجموعة البيانات.

مثال: سؤال: "كان عام ربنا 1834"

الإخراج: "كان عام ربنا 1834 وكانت شوارع لندن مليئة بالاحتجاج والعريضة. السبب، كما روى الكثيرون، لم يكن مرتبطًا بالطرق الخاصة، لكن تم اتخاذ القرار في نفس اليوم في يوم اللورد بالمرستون، وسيحصل الجمهور على بيان موجز بالصعوبات التي وصل إليها يوم القانون. إنه أمر مؤسف للغاية، أن الأحداث الحالية في تاريخ العالم واضحة، وبالتالي سيعرفها الجميع. ليس صحيحًا أن الرجال الذين استقروا أولاً في الإنجيل في القدس يجب أن يكون لديهم سجل واسع ومثير للاهتمام عن الازدهار والازدهار"

في البداية ظننت أن احتجاجًا قد حدث صدفة في نفس السنة، لكن انظر إلى هذا: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

تم التدريب باستخدام عينة بحجم 15 جيجابايت من مجموعة بيانات v2 البالغة 90 جيجابايت.
تم تدريب النموذج فقط حتى 10,000 خطوة.

كان هناك مشكلة في الترميز تسببت في أن يظهر الإخراج بهذا الشكل:

المطالبة:
من هو تشارلز ديكنز؟


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
مصحح:

"من هو تشارلز ديكنز؟ هل يعمل المزيد من أعماله الممتازة المؤثرة في مسرحياته، في مزرعة الشركة الكبرى؟ ماذا لم أقتبس بعد من جاك بيكيت؟ ألا تعلم أنهم كانوا نوعًا من الجري السريع، أو نشر صدورهم، أو ماذا كان ينبغي فعله في الوقت الذي كان جاكسون ينظر من النافذة؟ ما هو نجاح الإنجليزي، والذي لم يكتشفه ابنه لي، من أجل تحقيق مثل هذا الوزن؟ هل سبق أن عبرت الطريق القديم، أو إلى نسيم المرساة عند قدم قاربنا، والذي يجب أن تتركنا؟ الحقيقة هي، أنه سواء كان الريح سيرتفع من السهل ليلة السبت أو في منتصف النهار، أو حتى الشمال أو غير ذلك، سنضطر إلى وصف حاجز هائل، مع نفس التأثيرات كما هو الحال الآن. في هذا الوضع، على الأقل، ليس من المبالغة القول إننا قد تركنا تلك الغرفة. أعتقد أن هناك ثلاث نسخ في "خمس مئة ضعف"، يمكن الرجوع إليها، كأول رقم من قرائنا الذين يرغبون في...[اقتباس]"

### **v2mini-eval2-london**

تم تدريبه باستخدام نفس العينة 15GB المستخدمة لتدريب eval1.
تم تدريب النموذج مرة أخرى حتى 10K خطوة فقط.

الموجه: تشارلز داروين

تشارلز داروينECCEMACY. سيدي، — الحالة التالية تهمني: — كنت في لندن لمدة أسبوعين، وتأثرت كثيرًا بنوبة روماتيزم. أول نوبة روماتيزم كانت قبل أسبوع من رؤيتك، والثانية عندما رأيتك، والثالثة عندما رأيتك، والثالثة في نفس الوقت. أما النوبة الثانية من النقرس، فلم تكن مصحوبة بأي أعراض حمى، لكنها كانت مصحوبة بتدفق متزايد للبول، وبخروج أكثر غزارة للبول. النوبة الثالثة كانت ساعة بعد أن رأيتك، وتبعها عودة نوبة نقرس، وعودة أسرع للنقرس. النوبة الرابعة أيضًا كانت مصحوبة بحمى، ولكن لم تكن دائمًا مصحوبة بأي أعراض حمى. النوبة الثالثة من النقرس كانت بعد أسبوعين من مرضك، والرابعة تبعتها نوبة نقرس. النوبة الرابعة كانت بعد أسبوعين من إصابتك، وكانت مصحوبة بإحساس

### **v2-london**

تم تدريبه باستخدام مجموعة بيانات بحجم 90GB (112GB بعد الترميز)
تم تدريبه حتى 182K خطوة

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **ما التالي؟**

- بدأ تطوير TimeCapsuleLLM v3
- توسيع حجم مجموعة البيانات والتغطية الجغرافية
- التوسع خارج لندن إلى مدن إضافية

يتم تنفيذ العمل بالتعاون مع باحثين من كلية لندن الجامعية (UCL) وهناك نقاش حول مشاركة مؤسسات أخرى.

##  مجموعات البيانات

### **v2**

- 90GB (خام) من نصوص لندن 1800-1875
- 136,344 مستندًا
- مجموعة البيانات الكاملة المرمزة متاحة الآن هنا: https://huggingface.co/datasets/postgrammar/london-llm-1800



### إحصائيات التحيز
![تحيز الضمائر](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![تحيز جغرافي](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![تحيز زمني](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

راجع [تقرير التحيز v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) لمزيد من المعلومات.


-


## كيفية الاستخدام

يركز هذا المشروع بشكل رئيسي على جمع البيانات التاريخية، تجهيزها للتدريب وبناء محول الترميز. لن أغطي عملية تدريب النموذج الكامل (LLM)، لهذا راجع nanoGPT بواسطة Andrej Karpathy.

### الخطوة 1: جمع وتحضير النصوص التاريخية

- اجمع ملفات .txt لكتب أو وثائق من المجال العام من الفترة الزمنية التي اخترتها (مثلاً: لندن 1800-1875)
- احتفظ بها ضمن نافذة الزمن/المكان المختارة
- نظف ملفات النصوص باستخدام سكريبت أو قم يدوياً بإزالة رؤوس/ذيول Project Gutenberg، التعليقات الحديثة أو أخطاء OCR.

### الخطوة 2: بناء محول ترميز مخصص

- شغّل train_tokenizer.py أو train_tokenizer_hf.py على البيانات المنظفة.
- سيعطيك vocab.json و merges.txt
- هذه الملفات تحدد المفردات وقواعد الدمج لنموذجك

### الخطوة 3: درّب النموذج الخاص بك

- راجع [nanoGPT بواسطة Andrej Karpathy](https://github.com/karpathy/nanoGPT) لعملية التدريب أو وثائق الهيكلية التي اخترتها.

# الأسئلة الشائعة

## ما هو التدريب الزمني الانتقائي؟

التدريب الزمني الانتقائي (STT) هو منهجية تعلم آلي حيث يتم جمع جميع بيانات التدريب بشكل خاص لتكون ضمن فترة زمنية تاريخية محددة. يتم ذلك من أجل نمذجة اللغة والمعرفة لتلك الحقبة دون تأثير من المفاهيم الحديثة. على سبيل المثال، النموذج الحالي الذي أملكه (v0.5) مدرب على بيانات حصرياً من 1800-1875، لم يتم تحسينه لكنه دُرِّب من الصفر، مما يؤدي لإخراج يعكس الأسلوب اللغوي والسياق التاريخي لتلك الفترة.

## لماذا لا تستخدم التحسين الدقيق أو LoRA فقط؟
لهذا المشروع، أحاول إنشاء نموذج لغوي غير متأثر بالتحيزات الحديثة. إذا قمت بضبط نموذج مثل GPT-2، فهو مدرّب مسبقًا والمعلومات الموجودة فيه لن تختفي. أما إذا قمت بالتدريب من البداية، فلن يدّعي النموذج أنه قديم، بل سيكون كذلك بالفعل. الهدف من هذا المشروع هو إنشاء نموذج يمكنه الاستدلال حصريًا باستخدام المعرفة المستمدة من كتب لندن المنشورة بين عامي 1800 و1875.

## ما نوع البيانات التي استخدمتها في التدريب؟

أستخدم الكتب، الوثائق القانونية، الصحف، وغيرها من الكتابات من لندن بين 1800–1875. القائمة التي أرفقتها (لـ v0) تحتوي على حوالي 200 ملف، لكن في أول تدريب استخدمت فقط 50 ملفًا بحجم حوالي ~187 ميجابايت. يمكنك عرض قائمة الوثائق هنا:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

حجم مجموعات البيانات:
- v0: ~187 ميجابايت
- v0.5: ~435 ميجابايت
- v1: ~6.25 جيجابايت
- v2mini-eval1: 15 جيجابايت (عينة من v2 بحجم 90 جيجابايت)
- v2: 90 جيجابايت

## ما حجم النماذج؟

v0: 16 مليون معلمة

v0.5: 123 مليون معلمة

v1: 700 مليون معلمة

v2mini-eval1: 300 مليون معلمة

v2mini-eval2: 200 مليون معلمة

v2: 1.2 مليار معلمة

## مواصفات التدريب؟

### v0/v0.5
بطاقة رسوميات: Geforce rtx 4060
المعالج: i5-13400F
الذاكرة: 16 جيجابايت DDR5.

### v1
بطاقة رسوميات: A100 SXM مستأجرة

### v2mini-eval1/eval2

GPU: تم تأجير A100 SXM

### v2
GPU: تم تأجير H100 SXM

## الأعمال ذات الصلة

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - نموذج LLM يحتوي على 13 مليار معلمة تم تدريبه على 260 مليار رمز نصي قبل عام 1930 مع أسئلة وأجوبة. هناك أيضًا نسخة [أساسية](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - نموذج LLM يحتوي على 1.4 مليار معلمة تم تدريبه على نصوص بين 1800-1899 مع أسئلة وأجوبة. هناك أيضًا نسخة [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - نموذج LLM يحتوي على 340 مليون معلمة تم تدريبه على أكثر من 28,000 نص بين 1837-1899 مع أسئلة وأجوبة.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - عائلة من نماذج LLM ذات 4 مليار معلمة مبنية على هندسة Qwen3 وتم تدريبها من الصفر على 80 مليار رمز من البيانات التاريخية حتى حدود المعرفة 1913،1929،1933،1939،1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MondadGPT هو تحسين لنموذج Mistral-Hermes 2 على 11,000 نص حديث مبكر بالإنجليزية والفرنسية واللاتينية، معظمها من EEBO و Gallica.

## الشكر والتقدير

أود أن أشكر [الدكتور حامد ياغوبيان](https://hamedyaghoobian.com) على الإشراف الأكاديمي، وتوجيهه في إعداد البحث وتقييمه، والمساعدة في تدريب المحول وتجهيز البيانات لإصدار v2. كانت ملاحظاته وخبرته ذات دور جوهري في تحسين عرض هذا العمل.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---