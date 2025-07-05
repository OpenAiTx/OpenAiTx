<h1 align="center">مرحبًا بك في&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> أداة الاستمرار التلقائي لـ Cursor، إعادة المحاولة التلقائية لـ Cursor، التأكيد التلقائي لـ Cursor، إحصائيات استخدام Cursor، أداة تعزيز Cursor، أداة مساعدة Cursor، أداة أتمتة Cursor، إعدادات سمات Cursor، أداة Cursor Auto Continue، أداة Cursor Auto Retry، أداة Cursor Auto Confirm، أداة Cursor Usage Statistics، أداة كفاءة Cursor، أداة أتمتة Cursor، إعدادات سمات Cursor، Cursor بعد 25 استدعاء أداة، حد استدعاء أداة Cursor🔧🤖🚀
> 

## 🏠 [الصفحة الرئيسية](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper هي أداة تعزيز أتمتة تم تطويرها خصيصًا لـ Cursor IDE، يمكنها عرض الاستخدام في الوقت الفعلي، ومعالجة تلقائية لحد 25 محادثة، وفشل الاتصال بالشبكة، وإشعارات التأكيد وغيرها من السيناريوهات، مما يجعل تجربة التطوير لديك أكثر سلاسة.

**فيديو توضيحي:** [فيديو عرض Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

عندما تكون جودة العبارات التوجيهية عالية، وتخطيط متطلبات المشروع جيدًا، يمكن لهذا البرنامج أن يجعل Cursor يكمل مشروعًا بالكامل تلقائيًا دون تدخل بشري.

> 🔒 **توافق الإصدارات**: حاليًا تم تطويره واختباره على إصدارات Cursor 0.49.6 و Cursor 1.0.0، ويدعم نظريًا الإصدارات من Cursor 0.48.x إلى 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖سجل التحديثات

- 2025-06-01 إصدار النسخة v2.3، إضافة ميزة إعدادات سمات Cursor، تحسين استقرار حقن الكود، وتصحيح عرض الاستخدام ليتوافق مع تنسيق الرسمي
- 2025-05-21 إصدار النسخة v2.1، إعادة هيكلة المعمارية، دعم منصات متعددة، إضافة ميزة عرض الاستخدام في الوقت الفعلي، وغيرها
- 2025-04-25 الانتهاء من النسخة v1.0، معالجة تلقائية لحد 25 محادثة، وفشل الاتصال بالشبكة، وإشعارات التأكيد وغيرها من السيناريوهات
- 2025-04-20 بدء المشروع

## 🌟 أفضل ممارسات Cursor Auto Helper

ملاحظة: يمكن أن يتم توليد المستندات التالية بمساعدة الذكاء الاصطناعي مثل Cursor، ويجب التحقق والتعديل يدويًا.

**الخطوة 1:** تصميم متطلبات نظام المشروع بشكل مفصل (كلما كان تحليل المتطلبات أوضح، زادت جودة المشروع)، وكتابة عبارات توجيهية عالية الجودة لتطوير المشروع **SYSTEM.md**

**الخطوة 2:** استنادًا إلى **SYSTEM.md** إنتاج وثيقة تصميم نظام تطوير عالية الجودة **DESIGN.md**

**الخطوة 3:** استنادًا إلى **SYSTEM.md** و **DESIGN.md** إنتاج وثيقة خطة تطوير عالية الجودة **TODOLIST.md**

**الخطوة 4:** استخدم **Cursor Auto Helper**، وحدد **SYSTEM.md**، **DESIGN.md**، **TODOLIST.md**، واستخدم عبارات الاستمرار التلقائي لجعل Cursor يواصل تطوير المشروع تلقائيًا حسب خطة التطوير حتى الاكتمال

**عبارات الاستمرار التلقائي لـ Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md يرجى اتباع خطة التطوير في TODOLIST بدقة لتنفيذ التطوير الوظيفي اللاحق، وتحديث خطة TODOLIST في الوقت الفعلي، وبعد الانتهاء من كل مهمة يجب سؤالي "هل تريد الاستمرار؟"، حتى يتم الانتهاء من المشروع وتتم إعادة "تم الانتهاء من تطوير المشروع"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 دليل الاستخدام

يرجى دعمنا بوضع نجمة، وإذا كان لديك أي سؤال يرجى فتح [Issues](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 شرح ملف التكوين

ملف التكوين `config.ini` **مخصص لتخصيص سلوك الأتمتة** (يمكنك تعديله واختباره حسب الحاجة)، ويدعم عناصر الإعداد التالية:

#### الإعدادات الأساسية
```ini
[common]
log_enable = true     # هل تريد تفعيل السجلات؟ إذا كنت لا ترغب في تسجيل السجلات يمكنك تغييره إلى false

[cursor]
path = C:\Path\To\Cursor.exe  # مسار تثبيت Cursor IDE. سيبحث البرنامج تلقائيًا عن مسار Cursor، إذا لم يجده ستظهر رسالة، ويمكنك تعديل هذا الحقل
```

#### إعداد إجراءات الأتمتة
كل إجراء أتمتة يبدأ بالمقدمة `اسم الإجراء.`، ويدعم الحقول التالية:

- `type`: نوع الإجراء
  - `click`: النقر على زر
  - `input_and_submit`: إدخال وإرسال

- `text` / `text_list`: محتوى النص المطابق
  - `text`: سلسلة واحدة
  - `text_list`: عدة سلاسل مفصولة بـ |، إذا احتوى محتوى الصفحة على أي منها يتم التفعيل

- `button_selector`: محدد CSS للزر المطلوب النقر عليه (يحتاجه فقط نوع `click`)
- `button_text`: نص الزر (اختياري، لتحديد الزر بشكل أدق)
- `input_box_selector`: محدد CSS لمربع الإدخال (يحتاجه نوع `input_and_submit`)
- `input_content`: محتوى الإدخال التلقائي
- `submit_btn_selector`: محدد CSS لزر الإرسال
- `delay`: تأخير قبل تنفيذ الإجراء (بالمللي ثانية)، يمكن استخدامه لانتظار تحميل الصفحة

##### مثال على الإعدادات
```ini
[auto_actions]
# إعادة المحاولة تلقائيًا عند فشل الاتصال
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# بعد 25 استدعاء أداة
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "يرجى المتابعة"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# التأكيد التلقائي على المتابعة
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **ملاحظة:**
> 1. يمكن تخصيص اسم كل action (مثل `action_retry`، `action_continue`)، لكن يجب توحيد بادئة جميع الحقول لنفس الـ action
> 2. يُنصح باستخدام أدوات المطور في المتصفح لتحديد محددات CSS بدقة
> 3. يجب إعادة تشغيل البرنامج بعد تعديل ملف الإعدادات ليصبح ساري المفعول

## 🎯 سيناريوهات التطبيق

### 💼 تطوير محادثة طويلة
- معالجة تلقائية لحد الـ 25 محادثة، دعم تطوير محادثة طويلة متواصلة، متابعة سير المحادثة تلقائياً، رفع كفاءة التطوير.

### 👥 عدم استقرار الشبكة
- الكشف التلقائي عن مشاكل الشبكة، إعادة المحاولة الذكية للاتصال، استعادة المحادثة تلقائياً، ضمان استمرارية التطوير.

### 🏢 سيناريوهات التأكيد
- التعرف الذكي على سيناريوهات التأكيد، معالجة رسائل التأكيد تلقائياً، تقليل التدخل اليدوي.

### 📚 مراقبة الاستخدام
- إحصاء فوري لعدد المحادثات، مراقبة استخدام Cursor، تسجيل بيانات الاستخدام، تحسين كفاءة الاستخدام.

عرض استخدام الطرفية:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

عرض استخدام Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟 شرح الميزات

### 🤖 المتابعة التلقائية للمحادثات الطويلة
- معالجة تلقائية لحد الـ 25 محادثة في Cursor، دعم محادثات متواصلة متعددة الجولات.

### 🎨 إعادة المحاولة التلقائية للاتصال
- الكشف التلقائي عن فشل الاتصال بالشبكة، إعادة محاولة ذكية، مراقبة حالة الاتصال في الوقت الحقيقي.

### 📱 التأكيد التلقائي للرسائل
- التعرف الذكي على سيناريوهات التأكيد المتنوعة، معالجة النوافذ المنبثقة تلقائياً.
- دعم تخصيص محتوى التأكيد والاستجابة، تقليل التدخل اليدوي.
- إعداد قواعد مرنة لتناسب تدفقات التطوير المختلفة.

### 🛍️ إحصائيات الاستخدام
- إحصاء فوري لعدد المحادثات والاستخدام، تسجيل البيانات تلقائياً.
- عرض بيانات الاستخدام بشكل مرئي، لتسهيل التحليل والتحسين.
- دعم عرض السجلات الملونة في الطرفية، ولوحة استخدام في IDE، لتعزيز سهولة الاستخدام.

### 💡 نظام السجلات
- سجلات متعددة المستويات (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL)، مع إخراج ملون للطرفية.
- إنشاء ملفات السجلات تلقائياً حسب التاريخ، دعم التسجيل في الملفات وسحبها إلى لوحة العرض.
- لوحة عرض فورية لتسهيل المتابعة والاسترجاع للمطورين.

### 🔒 التوافق مع الإصدارات وتحسين الأداء
- تم التطوير بناءً على Cursor 0.49.6، مع اختبار كامل للميزات الأساسية.
- تحسينات خاصة للإصدارات المحددة، متابعة مستمرة لتحديثات Cursor.
- ثبات عالي، توافق ممتاز، مناسب للاستخدام في بيئات الإنتاج.

## 🔮 عرض النتائج

### 🤖 المتابعة التلقائية للمحادثات

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 عرض إكمال البرنامج التلقائي في Cursor

من متطلبات المشروع حتى التنفيذ الكامل، دون تدخل يدوي مطلقاً:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝 المؤلف

👤 **pen9un**

* الموقع: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️ الدعم

إذا وجدت هذا المشروع مفيداً، يرجى وضع نجمة مجانية ⭐️⭐️

## ✨سجل النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 إحصائيات عدد الزوار

![عدد الزوار](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---