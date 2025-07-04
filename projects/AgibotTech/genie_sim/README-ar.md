![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. معيار Genie Sim
Genie Sim هو إطار المحاكاة من AgiBot، والذي يوفر للمطورين قدرات فعالة لتوليد البيانات ومعايير التقييم لتسريع تطوير الذكاء المجسد. لقد أنشأ Genie Sim خط أنابيب مغلق شامل، يشمل توليد المسارات، تدريب النماذج، التقييم، والتحقق من النشر. يمكن للمستخدمين التحقق بسرعة من أداء الخوارزميات وتحسين النماذج من خلال سلسلة أدوات المحاكاة الفعالة هذه. سواء كانت المهام بسيطة مثل الالتقاط أو عمليات معقدة بعيدة المدى، يمكن لـ Genie Sim توفير بيئة محاكاة عالية الواقعية ومقاييس تقييم دقيقة، مما يمكّن المطورين من إكمال تطوير وتكرار تقنيات الروبوتات بكفاءة.

معيار Genie Sim Benchmark، كإصدار مفتوح المصدر من Genie Sim، مكرس لتوفير اختبارات أداء دقيقة ودعم تحسين لنماذج الذكاء المجسد.

# 2. الميزات
- إعدادات محاكاة مرنة وسهلة الاستخدام وواجهة تفاعلية
- معايير محاكاة ومهام تقييم لأكثر من 10 مهام تلاعب
- إمكانية التشغيل عن بعد عبر الواقع الافتراضي ولوحة المفاتيح
- تسجيل وإعادة تشغيل جميع المفاصل ووضعية طرف الروبوت
- أكثر من 550 بيئة ثلاثية الأبعاد وأصول محاكاة عالية الدقة وبدقة فيزيائية
- مقاييس تقييم موحدة لقياس أداء نماذج الذكاء المجسد
- نتائج التقييم تحقق أقل من 5% خطأ تقييم من المحاكاة إلى الواقع على نموذج GO-1
- دعم نموذج خط الأساس UniVLA في تقييم المحاكاة

# 3. التحديثات
- [25/6/2025] الإصدار 2.1
  - إضافة 10 مهام تلاعب أخرى لتحدي Agibot World 2025 بما في ذلك جميع أصول المحاكاة
  - فتح مصدر مجموعات بيانات اصطناعية لـ 10 مهام تلاعب على Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - دمج سياسة UniVLA ودعم تقييم استدلال النموذج في المحاكاة
  - تحديث حزمة مطور حلول الحركة العكسية (IK) لدعم الحلول العابرة للأجسام الروبوتية المختلفة
  - تحسين إطار الاتصال وزيادة سرعة تشغيل المحاكاة بمقدار الضعف
  - تحديث إطار التقييم التلقائي لمهام بعيدة المدى أكثر تعقيدًا

# 4. المحتوى

## 4.1 المقدمة
معايير محاكاة الذكاء المجسد في Genie Sim مصممة لتقييم وتعزيز تطوير نماذج الذكاء المجسد. توفر هذه المعايير بيئات واقعية، ومهام متنوعة، ومقاييس موحدة لقياس أداء أنظمة الذكاء الاصطناعي الروبوتية، مما يقلل من الحاجة إلى أجهزة فعلية مكلفة واختبار في العالم الحقيقي، ويتجنب سيناريوهات اختبار خطيرة ومحفوفة بالمخاطر ويسرع من عملية تدريب وتقييم وكلاء الذكاء الاصطناعي.

## 4.2 البدء السريع
يرجى الرجوع إلى [هذه الصفحة](https://agibot-world.com/sim-evaluation/docs/#/v2) للتثبيت، ودليل المستخدم، ومرجع API

## 4.3 الدعم
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 قائمة المهام القادمة
- [x] إطلاق المزيد من مهام التلاعب بعيدة المدى كمعايير
- [x] المزيد من المشاهد والأصول لكل مهمة تقييم
- [x] دعم نموذج خط الأساس لتحدي Agibot World
- [ ] مجموعة أدوات لتعميم تخطيطات السيناريوهات ومسارات التلاعب

## 4.5 الأسئلة الشائعة
- كيف يمكن إيقاف خادم isaac sim عند حدوث أخطاء وتتوقف العملية عن الاستجابة؟
  أوقف العملية من الطرفية باستخدام الأمر `pkill -9 -f raise_standalone_sim`
- كيف يمكن اختيار أوضاع العرض المختلفة؟
  وضع العرض الافتراضي هو `RaytracedLighting(RealTime)`. للمهام التي تحتوي على كائنات شفافة، استخدم `RealTimePathTracing(RealTime-2.0)` للعلاقة المنظورية بين الكائنات

## 4.6 الترخيص والاستشهاد
جميع البيانات والشيفرات ضمن هذا المستودع مرخصة بموجب رخصة Mozilla العامة 2.0
يرجى التفكير في الاستشهاد بعملنا بأحد الطرق التالية إذا ساعدك في أبحاثك.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 المراجع
1. PDDL Parser (2020). Version 1.1. [Source code]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Source code]. https://github.com/StanfordVL/bddl
3. CUROBO [Source code]. https://github.com/NVlabs/curobo
4. Isaac Lab [Source code]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Source code]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---