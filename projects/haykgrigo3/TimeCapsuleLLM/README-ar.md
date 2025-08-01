<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="قريباً">繁體中文 (قريباً)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="قريباً">हिन्दी (قريباً)</a> |
        | <a href="#" title="قريباً">ไทย (قريباً)</a> |
        | <a href="#" title="قريباً">Français (قريباً)</a>
        | <a href="#" title="قريباً">Deutsch (قريباً)</a>
        | <a href="#" title="قريباً">Español (قريباً)</a>
        | <a href="#" title="قريباً">Italiano (قريباً)</a>
        | <a href="#" title="قريباً">Русский (قريباً)</a>
        | <a href="#" title="قريباً">Português (قريباً)</a>
        | <a href="#" title="قريباً">Nederlands (قريباً)</a>
        | <a href="#" title="قريباً">Polski (قريباً)</a>
        | <a href="#" title="قريباً">العربية (قريباً)</a>
        | <a href="#" title="قريباً">فارسی (قريباً)</a>
        | <a href="#" title="قريباً">Türkçe (قريباً)</a>
        | <a href="#" title="قريباً">Tiếng Việt (قريباً)</a>
        | <a href="#" title="قريباً">Bahasa Indonesia (قريباً)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
نموذج LLM تم تدريبه فقط على بيانات من فترات زمنية معينة لتقليل التحيز الحديث.

تخيل لو أن نموذج الذكاء الاصطناعي لا يتظاهر فقط بأنه تاريخي بل هو فعلاً كذلك.

تم بناؤه على [nanoGPT بواسطة أندريه كارباتي](https://github.com/karpathy/nanoGPT) نصوص التدريب الأساسية وبنية النموذج من عمله.

# أهداف المشروع

TimeCapsule LLM هو مشروع تجريبي سيتم تدريبه فقط على نصوص مكتوبة خلال فترات زمنية محددة. الهدف هو محاكاة رؤية العالم واللغة لعصور تاريخية معينة.

# لماذا الضبط الدقيق غير كافٍ

إذا قمت فقط بضبط نموذج مدرب مسبقاً، فسيظل نموذج LLM الخاص بك يعرف المفاهيم الحديثة. بالطبع تحقيق انعدام التحيز الحديث أمر صعب لكني أريد الاقتراب قدر الإمكان من ذلك. الحصول على نموذج بدون تحيز حديث يتطلب تدريبه من الصفر.

# النتائج المتوقعة

آمل عند الانتهاء أن هذا النموذج لن يعرف المفاهيم الحديثة ولن يكون قادراً على الاستدلال بما يتجاوز ما تم تدريبه عليه. يجب ألا يتعرف على المفاهيم/المفردات الحديثة وأتمنى ألا يهلوس بمعلومات حديثة.

# تحديثات التقدم

## 9 يوليو 2025

حددت الفترة الزمنية بين 1800-1850 والمنطقة: لندن

جمعت قائمة من النصوص والكتب والوثائق

حتى الآن حصلت على 50 ملف نصي وسأبدأ تدريب NanoGPT قريبًا

سأقوم بتحديث هذا كلما تحقق تقدم

## 13 يوليو 2025

تم تدريب nanoGPT على 187 ميجابايت من بيانات نصية تاريخية.

## 15 يوليو 2025

بدأت في تحميل نصوص لجولة التدريب الثانية. أحصل على كل شيء من Internet Archive وقد وسعت الفترة الزمنية إلى 1800-1875. للحصول على مجموعة متنوعة من النصوص يمكنك استخدام عوامل التصفية للموضوع ومكان النشر والفترة الزمنية والمواضيع على Internet Archive.

![عوامل التصفية](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 يوليو 2025

قمت بتحميل حوالي 500 ملف نصي من Internet Archive وبعد تنظيفها (فقط حذف المسافات الزائدة، رؤوس Gutenberg، إلخ) أصبح لدي حوالي 500 ميجابايت من البيانات. إنها مجموعة بيانات صغيرة لكن في المرة الماضية تدربت على 187 ميجابايت لذا يجب أن يكون هناك على الأقل فرق ملحوظ في المخرجات بعد تدريب النموذج الثاني. آمل أن يتمكن هذا النموذج على الأقل من إنتاج جمل أكثر اتساقًا لها معنى ما. بالطبع هذا ليس مضموناً حيث أن المجموعة لا تزال صغيرة جداً، لكن هذا أكثر مما استخدمته في المرة الماضية.

يجب أن يكون هذا قابلاً للتنفيذ على أجهزتي الخاصة، وهذا جيد أيضًا لأنني آمل أن أرى بعض التحسن قبل الانتقال إلى مجموعة بيانات أكبر تتطلب مني استئجار GPU. لكن لا تقلق ما زلت أخطط لاستئجار GPU قريباً، لكن قبل القيام بذلك أريد التأكد أن مجموعة بياناتي منظمة ونظيفة قدر الإمكان. إحدى المشاكل التي لدي هي التنظيف، الكثير من هذه الملفات النصية بها خليط من الحروف غير المفهومة. النصوص البرمجية التي استخدمتها للتنظيف تعمل لكنها ليست فعالة 100%.

سأقوم بتدريب هذه المجموعة اليوم ويجب أن يستغرق الأمر حوالي 4-5 ساعات. بمجرد الانتهاء واختبارها سأعطيكم التحديثات. شكراً مرة أخرى لكل من اطلع على مشروعي، لقد أرسل لي البعض حتى روابط لموارد OCR فشكراً لكم! آمل أن يجرب المزيد من الناس هذا ويجربوا مجموعاتهم الخاصة من البيانات.

### تحديث التدريب

بدأت التدريب على مجموعة بحجم 435 ميجابايت (108 مليون رمز)، يسير الأمر بسلاسة حالياً. انخفضت خسارة التدريب من 10.9 إلى 4.9 في أول 2800 تكرار. أتوقع أن يستغرق الأمر حوالي 8 أو 9 ساعات حتى الاكتمال. سأضع تحديثًا آخر عند الانتهاء.

## 17 يوليو 2025 2:13 صباحًا

انتهى التدريب للنموذج الثاني، استغرق الأمر حوالي 8 ساعات و40 دقيقة على بطاقتي 4060 (3900 تكرار/ساعة) لإكمال 33,000 تكرار (5 عصور). كانت خسارة التدريب النهائية 3.73. كانت المخرجات جيدة بشكل مفاجئ حيث أصبح النموذج يولد جملًا متماسكة بأسلوب القرن التاسع عشر بالفعل.

## 28 يوليو 2025

قمت برفع الإصدار 0.5 على Hugging Face، [اطلع عليه](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) إذا أحببت. يمكنك الآن تحميل مستودعي وتشغيله محلياً. للأسف nanoGPT لا يعمل بشكل أصلي مع HuggingFace، لذا سيتوجب عليك تنزيل وتشغيل النموذج محلياً.

وسأبدأ أيضًا في تنسيق البيانات لجولة التدريب التالية، أعتقد أنني سأحتاج إلى 5-10 أضعاف البيانات لتحقيق قدرات استدلالية.

# سلوك النموذج V0 والقيود

تُظهر التعليمات المبكرة استجابة النموذج بلغة وسلوك القرن التاسع عشر. على سبيل المثال، طلبت منه "Who art Henry?" فأجاب "I know that man, I have did not a black, the storm." وبالطبع هذه الجملة لا معنى لها لكن النموذج يتعرف أنني أسأل عن شخص.



![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

لا يوجد أي ذكر للمفاهيم الحديثة، والمخرجات تحتوي في الغالب على كلمات وتراكيب من القرن التاسع عشر.

لا يزال يحتاج إلى الكثير من العمل، فالتدريب على 187 ميغابايت لن يعطيك نموذجاً ينتج نصوصاً ذات استدلال معقد.

حالياً ينتج جُملاً تفتقر إلى البنية الكاملة للجملة وبشكل عام لا معنى لها، لكن هذا أمر طبيعي لحجم البيانات المستخدم في التدريب.

# سلوك النموذج V0.5 والقيود

هذا تحسن جيد مقارنة بالنموذج السابق. أسلوب الكتابة والمفردات فيكتورية وكل جملة تقريباً صحيحة نحوياً مع علامات الترقيم المناسبة. ومرة أخرى، هذا النموذج تم تدريبه من الصفر لذا يلتزم بمواضيع القرن التاسع عشر.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

هناك الكثير من الهلوسات الواقعية. الكثير (بنسبة 100%) من التفاصيل (تواريخ، أحداث، شخصيات تاريخية) مختلقة. كما أن الجمل لا ترتبط ببعضها البعض فعلياً، أحياناً قد تتصل جملتان ببعضهما لكن غالباً لا يحدث ذلك. مشكلة أخرى هي ظهور تذييل "Digitized by Google" أحياناً، لذا في التدريب القادم يجب التأكد من تنظيف النصوص جيداً. بشكل عام أنا راضٍ جداً عن النتائج، النموذج ليس قريباً من أن يكون LLM بعد، لكنه بالتأكيد مولّد جمل.

أتعلم الكثير وسأبدأ بمعرفة ما يجب تحسينه في الأسابيع القادمة. سأرفع الملفات قريباً!

# الخطط القادمة

(تم) سأبدأ العمل على الإصدار 0.5، بدلاً من التدريب على 50 كتاباً، سأدرب باستخدام 500-600 كتاب إن أمكن. حالياً أدرب nanoGPT باستخدام كتب من 1800-1850 وتحديداً من لندن. هناك بعض التحديات مثل التأكد من أن الكتب التي أجدها ليست محدثة أو ذات تفسيرات حديثة بل كتب أصلية نُشرت ضمن الفترة الزمنية المختارة.

أريد تدريب نموذج جديد (v1) بكوربوس أكبر بكثير، ربما 5-10 أضعاف الذي استخدمته في v0.5. هدفي هو معرفة ما إذا كان من الممكن ظهور قدرات استدلال من خلال التدريب الزمني الانتقائي فقط، وهذه مهمة أصعب ولست متأكداً تماماً من إمكانية تحقيقها بسبب قيود البيانات التاريخية. في الأسابيع المقبلة سأحاول تجميع بيانات كافية لكوربوس بحجم 5-10 جيجابايت. أعتقد أنه إذا تمكنت من الحصول على بيانات نظيفة وعالية الجودة واستئجار GPU، سيكون هناك تقدم.

# كيفية استخدام هذا المشروع

يركز هذا المشروع بشكل أساسي على جمع البيانات التاريخية، تجهيزها للتدريب وبناء أداة تقسيم الكلمات (tokenizer). لن أغطي عملية تدريب LLM كاملة، للمزيد راجع nanoGPT من أندريه كارباتي.

# الخطوة 1: جمع وتحضير النصوص التاريخية

اجمع ملفات .txt لكتب ووثائق من الملكية العامة من الفترة الزمنية التي تختارها (مثال: لندن 1800-1850)

يمكنك استخدام download_texts_improved.py لتنزيل الكتب إذا كنت بحاجة لذلك.

نظف ملفات النصوص باستخدام سكريبت أو يدوياً لإزالة الرؤوس/التذييلات من مشروع جوتنبرج، الشروحات الحديثة أو أخطاء OCR.

prepare_dataset.py يجب أن يعمل بشكل جيد.

# الخطوة 2: بناء أداة تقسيم كلمات مخصصة

شغّل train_tokenizer.py أو train_tokenizer_hf.py على البيانات المنظفة.
سيعطيك ذلك vocab.json و merges.txt

هذه الملفات تحدد المفردات وقواعد الدمج لنموذجك

# الخطوة 3: تدريب النموذج الخاص بك (nanoGPT)

راجع [nanoGPT من أندريه كارباتي](https://github.com/karpathy/nanoGPT) لعملية التدريب.

يمكنك تدريب LLM مختلف إذا أردت، لكنني استخدمت nanoGPT

# الأسئلة الشائعة

## ما هو التدريب الزمني الانتقائي؟

التدريب الزمني الانتقائي (STT) هو منهجية تعلم آلي حيث يتم اختيار جميع بيانات التدريب لتكون ضمن فترة زمنية تاريخية محددة. يتم ذلك بهدف نمذجة لغة ومعرفة تلك الحقبة دون تأثير من المفاهيم الحديثة. على سبيل المثال، النموذج الحالي (v0.5) تم تدريبه على بيانات من 1800-1875 حصرياً، ولم يتم تحسينه بل تم تدريبه من الصفر مما ينتج عنه مخرجات تعكس أسلوب اللغة والسياق التاريخي لتلك الفترة.

## لماذا لا تستخدم فقط التحسين الدقيق أو LoRA؟

لهذا المشروع أحاول إنشاء نموذج لغوي خالٍ من التحيزات الحديثة. إذا قمت بتحسين نموذج مثل GPT-2، فهو مدرب مسبقاً ولن تختفي تلك المعلومات. إذا دربت من الصفر، فإن النموذج لن "يتظاهر" بأنه قديم، بل سيكون كذلك فعلاً. الهدف الآن هو إنشاء شيء يمكنه الاستدلال حصرياً باستخدام معرفة من كتب لندن المنشورة بين 1800 و1850.

## ما نوع البيانات التي استخدمتها للتدريب؟

أستخدم كتباً، مستندات قانونية، صحفاً، وكتابات أخرى من لندن 1800–1850. القائمة التي وضعتها تضم حوالي 200 كتاب لكن للتدريب الأول استخدمت فقط 50 ملفاً بحجم ~187 ميغابايت. يمكنك رؤية قائمة بالوثائق هنا:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ما هو حجم نموذج النسخة 0؟

هذا النموذج صغير جداً حالياً، أقوم بذلك للمتعة وأتبع قاعدة تدريب صارمة بعدم استخدام مصادر حديثة. يحتوي تقريباً على 16 مليون معامل لكنني سأبدأ بجمع المزيد من النصوص القديمة لبدء تدريب نموذج آخر. سأقدم تحديثات لاحقاً.

## مواصفات التدريب؟

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---