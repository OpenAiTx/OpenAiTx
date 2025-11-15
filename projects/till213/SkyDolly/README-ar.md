
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![الإصدار التجريبي](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![الترخيص: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![المترجمات المدعومة](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![اختبارات الوحدة](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# سكاي دوللي
سكاي دوللي - "الخروف الأسود" لتسجيل رحلاتك الجوية.

## حول
يتصل سكاي دوللي ببرنامج محاكاة الطيران 2020 أثناء تشغيله ويسجل متغيرات المحاكاة المختلفة لإعادة التشغيل.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

يتم الاتصال عبر SimConnect، وهي واجهة برمجة تطبيقات قياسية تم تقديمها مع Flight Simulator X للاتصال بمحاكي الطيران.

راجع أيضاً [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## الميزات
- تسجيل / إيقاف مؤقت / تشغيل
- رحلات تشكيلية (طائرات متعددة، إعادة التشغيل أثناء التسجيل، "الطيران مع التشكيل"، فارق زمني)
- معدل أخذ عينات قابل للتعيين: ثابت أو متغير ("تلقائي")
- سرعة إعادة تشغيل قابلة للتعديل ("الحركة البطيئة"، "تسريع الوقت")، حلقة إعادة تشغيل
- يتم تسجيل متغيرات المحاكاة الأساسية مثل الموقع، السرعة، والتحكم في الطيران (الأجنحة، الدفة، اللوحات، العجلات، ...)
- بنية الإضافات مع العديد من إضافات الاستيراد/التصدير (CSV، GPX، IGC، KML)
- وحدة المواقع مع أكثر من 100 موقع افتراضي ووظائف الاستيراد/التصدير
- حفظ البيانات على قاعدة بيانات (SQLite) ("دفتر السجل")

شاهد إعلان الإصدار (المعاينة) على [يوتيوب](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![سكاي دوللي - مسجل الرحلات وإعادة التشغيل لمحاكي الطيران 2020 (إعلان سينمائي)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "سكاي دوللي - مسجل الرحلات وإعادة التشغيل لمحاكي الطيران 2020 (إعلان سينمائي)")

للمزيد من الفيديوهات التي تم إنشاؤها باستخدام سكاي دوللي راجع أيضاً [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). الميزات الجديدة والقادمة تجدها في [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## الاستخدام الأساسي

- ابدأ رحلة
- اضغط على "تسجيل" (المفتاح R)
- يمكنك إيقاف التسجيل مؤقتاً (المفتاح P)
- أوقف التسجيل (المفتاح R) واضغط على "تشغيل" (شريط المسافة)
- عدل سرعة إعادة التشغيل وابحث عن موضع التشغيل، حتى أثناء إعادة التشغيل
- يتم حفظ الرحلات المسجلة تلقائياً في "دفتر السجل"
- اختر رحلة في دفتر السجل واضغط على "تحميل" (أو انقر مرتين على الصف) لتحميل الرحلة المحفوظة

### تسجيل وإعادة تشغيل التشكيلات

#### التسجيل

- انتقل إلى وحدة "التشكيل" (المفتاح F2)
- انقر على "تسجيل" (المفتاح R)
- تتم إضافة كل طائرة مسجلة إلى الرحلة الحالية
- أثناء إعادة تشغيل الطائرات الموجودة أثناء التسجيل بمعدل العينة "تلقائي" يمكنك أيضًا تغيير معدل عينة التسجيل

#### الموقع

- تصبح آخر طائرة مسجلة هي "طائرة المستخدم" (التي يتبعها الكاميرا في محاكي الطيران)
- اختر موقعًا نسبيًا بالنسبة إلى "طائرة المستخدم" الحالية قبل التسجيل

#### إعادة التشغيل

- فقط انقر على "تشغيل"، "إيقاف مؤقت" وتنقل في الخط الزمني، كما هو الحال في رحلة طائرة واحدة
- غيّر "طائرة المستخدم" (حتى أثناء إعادة التشغيل) للتنقل من قمرة قيادة إلى أخرى
- استلم التحكم في "طائرة المستخدم" عن طريق اختيار "استلام التحكم" أو خيار "الطيران مع التشكيل"

#### إدارة التشكيلات

- يمكنك حذف طائرة واحدة من الرحلة ("التشكيل")
- يجب أن يكون هناك طائرة واحدة على الأقل في كل رحلة، لذلك لا يمكن حذف آخر طائرة
- أضف فارق زمني للطائرة المحددة ("مزامنة رحلة تشكيل اللاعبين المتعددين")
- لبدء رحلة جديدة بطائرة واحدة، عد إلى وحدة "سجل الرحلات" (المفتاح F1) وانقر على "تسجيل" (المفتاح R)

لماذا لا تجرب ذلك مع إحدى ["جولات تيل الإرشادية"](https://github.com/till213/Tell-Tours)؟ :)

## التحميل

اذهب إلى [الإصدارات](https://github.com/till213/SkyDolly/releases) وقم بتحميل أحدث إصدار.

أحدث إصدار (تجريبي): **Sky Dolly 0.19.2**

احسب وقارن قيمة المجموع الاختباري الخاصة بك مع [قيم SHA-256 المنشورة](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)، للتحقق من سلامة النسخة التي تم تنزيلها.

## البناء

راجع وثائق [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## مشاريع ذات صلة

- https://github.com/nguyenquyhy/Flight-Recorder - تطبيق لتسجيل الرحلات وإعادة تشغيلها مبني على .Net
- https://github.com/saltysimulations/saltyreplay/ - تسجيل وإعادة تشغيل مع واجهة مستخدم ويب
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - يسجل الرحلة وينشئ ملفات إعادة تشغيل بصيغة Google Earth (KML)
- https://github.com/Elephant42/FS_Tool - أداة بسيطة تتيح تعيين موقع الطائرة ومعدل المحاكاة
- https://github.com/pyviator/msfs-geoshot - يلتقط لقطات شاشة ويضيف إليها "وسم جغرافي" تلقائيًا
- https://github.com/ijl20/msfs_logger_replay - مسجل IGC وإعادة تشغيل (لـ FSX)
- https://joinfs.net/ - يتيح مزامنة رحلات اللاعبين عبر أجهزة محاكاة الطيران المختلفة (MSFS، Prepar3D/FSX، XPlane). ويوفر أيضًا مسجل رحلات مع تسجيل رحلات جماعية ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote لطائرة FlyByWire's A32NX: للتحكم في وظائف قمرة القيادة لطائرة FBW A320، باستخدام FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer يحلل سجل الرحلات لـ MSFS ويصدر ملف CSV يمكن قراءته بواسطة Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave يخزن خطط الرحلات تلقائيًا (أو عند الطلب)
- https://github.com/mracko/MSFS-Landing-Inspector - يحلل أداء الهبوط الخاص بك
- [نقاط الاهتمام (خرائط Google)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - نقاط الاهتمام والمطارات والمدن ثلاثية الأبعاد في Microsoft Flight Simulator.

## موارد أخرى مفيدة

- https://obsproject.com/ - تطبيق لالتقاط الشاشة / البث
- https://sqlitebrowser.org/ - تصفح ملفات قاعدة بيانات سجل الرحلات Sky Dolly (*.sdlog)، وتنفيذ استعلامات SQL خاصة بك


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---