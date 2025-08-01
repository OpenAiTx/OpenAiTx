شجرة التكامل/التجهيز لبيتكوين كور
==================================

https://bitcoincore.org

للحصول على نسخة ثنائية قابلة للاستخدام فوراً من برنامج بيتكوين كور، راجع
https://bitcoincore.org/en/download/.

ما هو بيتكوين كور؟
-----------------

بيتكوين كور يتصل بشبكة البيتكوين الند للند لتنزيل والتحقق الكامل من الكتل والمعاملات. كما يتضمن محفظة وواجهة مستخدم رسومية، والتي يمكن بناؤها اختيارياً.

مزيد من المعلومات عن بيتكوين كور متوفر في [مجلد الوثائق](/doc).

الترخيص
-------

بيتكوين كور يصدر بموجب شروط رخصة MIT. راجع [COPYING](COPYING) لمزيد من المعلومات أو زر https://opensource.org/license/MIT.

عملية التطوير
-------------

فرع `master` يُبنى ويُختبر بانتظام (راجع `doc/build-*.md` للحصول على التعليمات)، لكن لا يوجد ضمان بأن يكون مستقرًا بالكامل. يتم إنشاء [العلامات](https://github.com/bitcoin/bitcoin/tags)
بشكل منتظم من فروع الإصدارات للإشارة إلى نسخ إصدارات رسمية ومستقرة جديدة من بيتكوين كور.

مستودع https://github.com/bitcoin-core/gui يُستخدم حصريًا لتطوير واجهة المستخدم الرسومية. فرعه الرئيسي مطابق في جميع المستودعات أحادية الشجرة. لا توجد فروع أو علامات إصدارات، لذلك يرجى عدم تفريع هذا المستودع ما لم يكن ذلك لأسباب تطويرية.

سير عمل المساهمة موصوف في [CONTRIBUTING.md](CONTRIBUTING.md)
ونصائح مفيدة للمطورين يمكن العثور عليها في [doc/developer-notes.md](doc/developer-notes.md).

الاختبار
--------

الاختبار ومراجعة الكود هما عنق الزجاجة في عملية التطوير؛ نحصل على طلبات سحب أكثر مما يمكننا مراجعته واختباره بسرعة. يرجى التحلي بالصبر والمساعدة في اختبار طلبات السحب الخاصة بالآخرين، وتذكر أن هذا مشروع حساس أمنيًا حيث قد تكلف أي خطأ الناس الكثير من المال.

### الاختبار الآلي

يُنصح المطورون بشدة بكتابة [اختبارات وحدات](src/test/README.md) للكود الجديد، وتقديم اختبارات وحدات جديدة للكود القديم. يمكن تجميع وتشغيل اختبارات الوحدات (بافتراض أنه لم يتم تعطيلها أثناء إنشاء نظام البناء) باستخدام: `ctest`. يمكن العثور على مزيد من التفاصيل حول تشغيل وتوسيع اختبارات الوحدات في [/src/test/README.md](/src/test/README.md).

هناك أيضًا [اختبارات انحدار وتكامل](/test)، مكتوبة بلغة بايثون.
يمكن تشغيل هذه الاختبارات (إذا تم تثبيت [تبعيات الاختبار](/test)) باستخدام: `build/test/functional/test_runner.py`
(بافتراض أن `build` هو دليل البناء الخاص بك).

أنظمة التكامل المستمر (CI) تضمن أن كل طلب سحب يتم بناؤه لكل من ويندوز، لينكس، وماك أو إس، وأن اختبارات الوحدة/السلامة يتم تشغيلها تلقائيًا.

### اختبار ضمان الجودة اليدوي (QA)

يجب اختبار التغييرات من قبل شخص آخر غير المطور الذي كتب الكود. هذا مهم بشكل خاص للتغييرات الكبيرة أو عالية المخاطر. من المفيد إضافة خطة اختبار إلى وصف طلب السحب إذا لم يكن اختبار التغييرات مباشرًا.

الترجمات
--------

يمكن تقديم تغييرات الترجمات بالإضافة إلى الترجمات الجديدة إلى
[صفحة ترجمات بيتكوين كور على Transifex](https://www.transifex.com/bitcoin/bitcoin/).

يتم سحب الترجمات بشكل دوري من Transifex ودمجها في مستودع git. راجع
[عملية الترجمة](doc/translation_process.md) للحصول على تفاصيل حول كيفية عمل ذلك.

**هام**: لا نقبل تغييرات الترجمات كطلبات سحب على GitHub لأن السحب التالي من Transifex سيقوم تلقائيًا بالكتابة فوقها مرة أخرى.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---