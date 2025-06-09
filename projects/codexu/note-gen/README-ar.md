![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## الدليل

NoteGen هو تطبيق تدوين ملاحظات `Markdown` متعدد المنصات، يركز على استخدام الذكاء الاصطناعي لربط التسجيل والكتابة، وتنظيم المعرفة المجزأة في ملاحظة قابلة للقراءة.

🖥️ الوثائق الرسمية: [https://notegen.top](https://notegen.top)

💬 انضم إلى [مجموعة WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## لماذا تختار NoteGen؟

- خفيف الوزن: [حزمة التثبيت](https://github.com/codexu/note-gen/releases) **فقط 20 ميغابايت**، مجاني بدون إعلانات أو برامج مرفقة.
- متعدد المنصات: يدعم ماك، ويندوز، لينكس، وبفضل قدرات `Tauri2` سيـدعم مستقبلاً iOS وAndroid.
- يدعم طرق تسجيل متعددة بما في ذلك `لقطات الشاشة`، `النصوص`، `الرسوم التوضيحية`، `الملفات`، `الروابط` وغيرها، لتلبية احتياجات التسجيل المجزأ في مختلف السيناريوهات.
- يستخدم تنسيق `Markdown(.md)` الأصلي للتخزين، بدون تعديلات، سهل النقل.
- استخدام محلي بالكامل، مع دعم المزامنة الفورية مع `مستودعات GitHub, Gitee الخاصة` مع إمكانية الرجوع للتاريخ، ودعم المزامنة مع WebDAV.
- معزز بالذكاء الاصطناعي: قابل للتكوين مع ChatGPT، Gemini، Ollama، LM Studio، Grok، ونماذج أخرى، مع دعم لتكوين نماذج طرف ثالث مخصصة.
- RAG: ملاحظاتك هي قاعدة معرفتك. دعم نماذج التضمين ونماذج إعادة الترتيب.

## لقطات شاشة

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

التسجيل:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

الكتابة:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

السمة:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## من التسجيل إلى الكتابة

عادةً، لا توفر تطبيقات تدوين الملاحظات التقليدية وظيفة التسجيل. يحتاج المستخدمون إلى نسخ المحتوى يدويًا ولصقه للتسجيل، مما يقلل من الكفاءة بشكل كبير. وعند مواجهة محتوى مسجل متفرق، يتطلب ذلك جهدًا كبيرًا لتنظيمه.

ينقسم NoteGen إلى صفحتي `التسجيل` و`الكتابة`، مع العلاقة التالية بينهما:

- يمكن تنظيم التسجيلات في ملاحظات ونقلها إلى صفحة الكتابة للتأليف المتعمق.
- أثناء الكتابة، يمكنك إدراج التسجيلات في أي وقت.

### التسجيل

وظيفة التسجيل تشبه **روبوت الدردشة بالذكاء الاصطناعي**، ولكن عند التحدث معه يمكنك ربطه بمحتوى مسجل سابقًا، والتحول من وضع المحادثة إلى وضع التنظيم لترتيب التسجيلات في ملاحظة قابلة للقراءة.

الميزات المساعدة التالية تساعدك على التسجيل بشكل أكثر فعالية:

- **الوسوم** لتمييز سيناريوهات التسجيل المختلفة.
- **الشخصيات الافتراضية** مع دعم مطالبات مخصصة للتحكم الدقيق في مساعد الذكاء الاصطناعي الخاص بك.
- **مساعد الحافظة** الذي يتعرف تلقائيًا على النص أو الصور في الحافظة لديك ويسجلها إلى قائمتك.

### الكتابة

قسم الكتابة مقسم إلى جزأين: **مدير الملفات** و**محرر Markdown**.

**مدير الملفات**

- يدعم إدارة ملفات Markdown المحلية وملفات GitHub المتزامنة.
- يدعم تسلسل المجلدات غير المحدود.
- يدعم طرق فرز متعددة.

**محرر Markdown**

- يدعم أنماط WYSIWYG، العرض الفوري، ومعاينة الشاشة المنقسمة.
- يدعم التحكم في الإصدارات مع إمكانية التراجع عن التاريخ.
- يدعم المساعدة بالذكاء الاصطناعي للمحادثة، الإكمال، التنقيح، والترجمة.
- يدعم رفع الصور وتحويلها إلى روابط صور Markdown.
- يدعم تحويل HTML إلى Markdown، وتحويل محتوى المتصفح المنسوخ تلقائيًا إلى تنسيق Markdown.
- يدعم المخططات، الصيغ الرياضية، الخرائط الذهنية، الرسوم البيانية، المخططات الانسيابية، مخططات جانت، مخططات التسلسل، المدرجات الموسيقية، الوسائط المتعددة، القراءة الصوتية، روابط العناوين، تمييز ونسخ الشيفرة، عرض رسومات graphviz، ومخططات plantuml UML.
- يدعم الحفظ المحلي الفوري للمحتوى، والمزامنة التلقائية المؤجلة (بعد 10 ثوانٍ بدون تحرير)، وإمكانية التراجع عن التاريخ.

## ميزات أخرى

- بحث شامل للعثور السريع على محتوى محدد والانتقال إليه.
- إدارة استضافة الصور لتسهيل إدارة محتوى مستودع الصور.
- السمات والمظهر مع دعم السمة الداكنة وإعدادات المظهر لـ Markdown، الشيفرة، إلخ.
- دعم التدويل، متوفر حاليًا باللغتين الصينية والإنجليزية.

## كيف تستخدم؟

### التحميل

حالياً يدعم ماك، ويندوز، ولينكس. وبفضل قدرات Tauri2 سيتم دعم iOS وAndroid مستقبلاً.

[تحميل NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### التحسين

يمكن استخدام تطبيق تدوين الملاحظات مباشرةً بدون إعداد. إذا رغبت في تجربة أفضل، يرجى فتح صفحة الإعدادات لتكوين الذكاء الاصطناعي والمزامنة.

## المساهمة

- [اقرأ دليل المساهمة](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [خطط التحديث](https://github.com/codexu/note-gen/issues/46)
- [أبلغ عن الأخطاء أو اقترح تحسينات](https://github.com/codexu/note-gen/issues)
- [النقاشات](https://github.com/codexu/note-gen/discussions)

## المساهمون

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## تاريخ النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---