<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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
        | <a href="#" title="قريباً">فارسی (قريباً)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="قريباً">Bahasa Indonesia (قريباً)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*نموذج لغوي تم تدريبه **من الصفر** حصرياً على بيانات من أماكن وفترات زمنية معينة للحد من التحيز العصري وتقليد صوت ومفردات ورؤية العصر.*

تخيل لو أن نموذج الذكاء الاصطناعي لم يكن يتظاهر فقط بأنه تاريخي، بل كان كذلك فعلاً.

تم بناء الإصدار v0 وv0.5 على [nanoGPT بواسطة Andrej Karpathy](https://github.com/karpathy/nanoGPT) نصوص التدريب الأساسية وبنية النموذج هي من عمله.

الإصدار v1 مبني على [Phi 1.5 من مايكروسوفت](https://huggingface.co/microsoft/phi-1_5)

[رابط Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  سلوك النموذج والقيود

### **v0**  

العروض الأولية تظهر استجابة النموذج بلغة وسلوك القرن التاسع عشر.
مثال: النص التحفيزي: "Who art Henry?" وأجاب: "I know that man, I have did not a black, the storm."

![مخرج عينة من TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- لا يوجد ذكر للمفاهيم الحديثة  
- المفردات دقيقة للفترة الزمنية في الغالب  
- الجمل غير مترابطة في معظمها (متوقع لمجموعة تدريب بحجم ~187 ميجابايت)

### **v0.5** 

تحسن ملحوظ عن الإصدار v0.  
- أسلوب كتابة فيكتوري، علامات ترقيم صحيحة، جمل نحوية في معظمها  
- لا تزال معدلات الهلوسة الواقعية مرتفعة  
- ضوضاء OCR ("Digitized by Google") لا تزال تظهر في النتائج

![مخرج عينة من TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

أول نموذج يستدعي ويربط حدثًا تاريخيًا حقيقيًا مع شخصية فعلية من مجموعة البيانات.

مثال: النص التحفيزي: "It was the year of our Lord 1834"

الإخراج: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

في البداية افترضت أن احتجاجًا ربما حدث في نفس العام صدفة لكن ألقِ نظرة على هذا: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

تم تدريبه باستخدام عينة بحجم 15 جيجابايت من مجموعة بيانات v2 البالغ حجمها 90 جيجابايت.

تم تدريب النموذج حتى 10 آلاف خطوة فقط.

كانت هناك مشكلة في الترميز تسببت في ظهور الناتج بهذا الشكل:

المطالبة:
من هو تشارلز ديكنز؟


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
مصَحح:

"من هو تشارلز ديكنز؟ هل يعمل بذلك بشكل أكثر إثارة في مسرحياته، في مزرعة الشركة الكبرى؟ ما الذي لم أقتبسه بعد من جاك بيكيت؟ ألا تعلم أنهم كانوا نوعًا من الجري السريع، أو نشر صدورهم، أو ما الذي كان يجب فعله في الوقت الذي كان فيه جاكسون ينظر من النافذة؟ ما هو نجاح الإنجليزي، والذي لم يكتشفه ابنه لي بعد، والذي من خلاله يمكن تحقيق مثل هذا العبء؟ هل سبق لك أن عبرت الطريق القديم، أو إلى نسيم المرسى عند قدم قاربنا، والذي يجب عليك أن تتركنا عنده؟ الواقع هو، أنه سواء ارتفعت الرياح من السهل مساء السبت أو في الظهيرة، أو حتى الشمال، أو غير ذلك، سنضطر لوصف حاجز هائل، مع نفس التأثيرات كما هي الآن. في هذا الوضع، على الأقل، ليس من المبالغة القول أننا تركنا تلك الغرفة. أعتقد أن هناك ثلاث نسخ في 'خمسمئة ضعف'، يمكن الرجوع إليها، كأول عدد من قرائنا الذين يرغبون ف[ـ]..."

### **v2mini-eval2**

تم التدريب باستخدام نفس العينة بحجم 15 غيغابايت المستخدمة في تدريب eval1.
النموذج تم تدريبه مجددًا حتى 10,000 خطوة فقط.

المُحَفِّز: تشارلز داروين

تشارلز داروينECCEMACY. سيدي، — الحالة التالية تهمني: — كنت في لندن لمدة أسبوعين، وتأثرت كثيرًا بنوبة من الروماتيزم. كانت أول نوبة روماتيزم قبل أسبوع من رؤيتك، والثانية عندما رأيتك، والثالثة عندما رأيتك، والثالثة في نفس الوقت. لكن النوبة الثانية من النقرس لم تكن مصحوبة بأي أعراض حمى، بل صاحبها زيادة في تدفق البول، وتفريغ أكثر غزارة للبول. النوبة الثالثة جاءت بعد ساعة من رؤيتك، وتبعتها عودة نوبة من النقرس، وعودة أسرع للنقرس. النوبة الرابعة صاحبتها أيضًا حمى، لكنها لم تكن دائمًا مصحوبة بأي أعراض حمى. النوبة الثالثة من النقرس كانت بعد أسبوعين من مرضك، والرابعة تبعتها نوبة من النقرس. النوبة الرابعة جاءت بعد أسبوعين من إصابتك، وصاحبتها إحساس

## مجموعات البيانات

### **v2**

- 90 غيغابايت من نصوص لندن بين 1800-1875
- 136,344 وثيقة
- لم تتوفر الـ 90 غيغابايت كاملة بعد لأنها لم تُحوّل إلى رموز بعد، لكن يمكنك إيجاد عينة 15 غيغابايت هنا: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### إحصائيات التحيز 
  ![تحيز الضمائر](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![التحيز الجغرافي](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![التحيز الزمني](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

يرجى الرجوع إلى [تقرير تحيز v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) لمزيد من المعلومات.

## كيفية الاستخدام

يركز هذا المشروع بشكل أساسي على تنسيق البيانات التاريخية، وتجهيزها للتدريب وبناء محلل الرموز tokenizer. لن أغطي هنا عملية تدريب LLM الكاملة، لذلك راجع nanoGPT بواسطة أندريه كارباثي.

### الخطوة 1: جمع وتحضير النصوص التاريخية

- جمع ملفات .txt من الكتب، الوثائق، وغيرها من المصادر المتاحة للاستخدام العام من الفترة الزمنية التي تختارها (مثل لندن 1800-1850)



- احتفظ بها ضمن نافذة الوقت/المكان التي اخترتها  
- نظف ملفات النصوص باستخدام برنامج نصي أو قم بإزالة الرؤوس/التذييلات يدوياً من مشروع غوتنبرغ، أو التعليقات الحديثة أو أشياء مثل أخطاء OCR.

### الخطوة 2: بناء محلل رموز مخصص

- شغل train_tokenizer.py أو train_tokenizer_hf.py على البيانات المنظفة.
- سيعطيك ذلك vocab.json و merges.txt
- هذه الملفات تحدد المفردات وقواعد الدمج لنموذجك

### الخطوة 3: درب نموذجك 

- ارجع إلى [nanoGPT بواسطة Andrej Karpathy](https://github.com/karpathy/nanoGPT) لعملية التدريب أو وثائق البنية التي اخترتها.

# الأسئلة الشائعة

## ما هو التدريب الزمني الانتقائي ؟

التدريب الزمني الانتقائي (STT) هو منهجية تعلم آلي حيث يتم اختيار كل بيانات التدريب لتندرج ضمن فترة زمنية تاريخية محددة. يتم ذلك من أجل نمذجة اللغة والمعرفة لتلك الحقبة دون التأثر بالمفاهيم الحديثة. على سبيل المثال، النموذج الحالي (v0.5) تم تدريبه حصرياً على بيانات من 1800-1875، ولم يتم تحسينه بل تم تدريبه من الصفر، مما أدى إلى إنتاج يعكس الأسلوب اللغوي والسياق التاريخي لتلك الفترة.

## لماذا لا تستخدم فقط الضبط الدقيق أو LoRA؟

لهذا المشروع أحاول إنشاء نموذج لغة غير متأثر بالانحياز الحديث. إذا قمت بضبط شيء مثل GPT-2، فهو مدرب مسبقاً بالفعل وهذه المعلومات لن تختفي. إذا دربت من الصفر، لن يتظاهر نموذج اللغة بأنه قديم، بل سيكون كذلك فعلاً. الهدف لهذا المشروع الآن هو إنشاء شيء يمكنه الاستنتاج حصرياً باستخدام المعرفة من كتب لندن المنشورة بين 1800 و 1875.

## ما نوع البيانات التي استخدمتها للتدريب؟

أستخدم كتباً، وثائق قانونية، صحفاً، وكتابات أخرى من لندن بين 1800–1875. القائمة التي ربطتها (لـ v0) تحتوي على حوالي 200 ملف لكن للتدريب الأول استخدمت فقط 50 ملفاً بحجم ~187 ميغابايت. يمكنك عرض قائمة الوثائق هنا:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

أحجام قواعد البيانات:
- v0: ~187 ميغابايت
- v0.5: ~435 ميغابايت 
- v1: ~6.25 غيغابايت 
- v2mini-eval1: 15 غيغابايت

## ما هو حجم النماذج ؟

v0: 16 مليون معامل

v0.5 123 مليون معامل

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