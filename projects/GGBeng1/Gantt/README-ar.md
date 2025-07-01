# جانت
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## التثبيت

```
yarn install
```

### التشغيل

```
yarn run serve
```

### الشرح

```
عرض مخطط جانت تم تطويره بناءً على vue، يمكن استخدامه في سيناريوهات العمل الجماعي وتقسيم المهام في بيئات أجايل.

يدعم المجموعات
يدعم السحب والإفلات
يدعم التمديد
يدعم النسبة المئوية
يدعم نطاقات الوقت: يوم، أسبوع، شهر
حالياً تم كتابة مجموعة واحدة فقط، ولتجنب الحاجة المستقبلية للمجموعات الثنائية أو المتعددة، تم إعادة هيكلة جزء من الكود في آخر تحديث لدعم المجموعات المتعددة، لكن الإصدار الحالي لم يتم تطويره بعد.

الميزة: عند تنفيذ عمليات مثل السحب، التمديد، أو تعديل التقدم، لا يتم تحديث البيانات بشكل فوري، بل يتم التحديث بعد انتهاء العملية، مما يقلل من استهلاك الأداء.
      عند التحرير أو الحذف أو الإضافة، لا يتم تعديل كل الكائنات بشكل متكرر، بل فقط الجزء الذي تم تعديله.

يتم حالياً إعادة تنظيم الكود استعداداً للتحويل إلى مكون، حالياً للاستخدام في المشروع يكفي استيراد `gant.vue` من هذا المشروع.
طرق الاستيراد والتصدير للبيانات بالجملة تم كتابتها مسبقاً، فقط انسخها مباشرة!~
```

### ملاحظات التحديث

- يدعم التحرير
- يدعم الحذف
- إصلاح مشكلة عدم إمكانية التمرير العمودي (تمت إضافة التمرير المتزامن في الاتجاهين) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- إصلاح مشكلة ناتجة عن elementUI
- بخصوص مشكلة نطاق الوقت [#5](https://github.com/GGBeng1/Gantt/issues/5)
- حالياً لا يمكن تحقيق نطاقات أخرى مثل الساعات من خلال تغيير إعدادات النطاق. لأن بعض الإعدادات تم تثبيتها أثناء التهيئة، وسيتم تعديل ذلك لاحقاً وتوفيره عبر واجهة برمجة تطبيقات (API).

### مشاهدة المثال

انظر [العرض التوضيحي](https://ggbeng1.github.io/Gantt/#/)

### صورة العرض

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---