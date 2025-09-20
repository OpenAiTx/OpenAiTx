<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
تفريغات PIC16/Xyclops من جهاز Xbox الأصلي وقواعد بيانات IDA مع بعض الهندسة العكسية المنفذة.

![صورة PIC16LC63A من جهاز Xbox الأصلي](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# برمجة Xyclops (XycloMod)
انظر [دليل مجلد Xyclops و README](/Xyclops)


# التفريغات
تم تبديل البايتات في ملف .bin لكل تفريغ PIC لتحميله بشكل صحيح في IDA. لذا فإن الكلمة الأولى في ذاكرة PIC هي byte_0 + byte_1 << 8.

تحتوي قواعد بيانات IDA .idb على معلومات عن المتغيرات وبعض الملاحظات على دفتر ملاحظات قاعدة البيانات.

انظر إلى صفحة الويكي هذه لتحليل إصدارات SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
تم تفريغه من جهاز Xbox DVT3. نفس كلمة التكوين مثل P01. كما يحتوي على معرف الجهاز محفور في منطقة التكوين كـ 0000 0000 000B 002A، بخلاف PICs الإنتاجية.

يفتقد تمامًا تحدي الإقلاع.

## D01
تم تفريغه من جهاز XDK BETA 2 Xbox. مطابق لـ P01 باستثناء غياب تحدي الإقلاع. وظيفة حساب الاستجابة المتوقعة لتحدي الإقلاع لا تزال موجودة، ولكن لم يتم استدعاؤها أبدًا.

## DXF
تم تفريغه من جهاز XDK D2 debug kit. مشابه جدًا لـ D01 لكن مع منطق درج مختلف قليلاً، ومنطق الحماية من الحرارة الزائدة ومنطق الإقلاع. تحدي الإقلاع مفقود بنفس طريقة D01.

## D2E
تم تفريغه من جهاز تطوير Tuscany (v1.6). شريحة Xyclops تحمل العلامة X01202-001، وتفتقر إلى سطر A-A02 أو A-B01 الذي يوجد في وحدات البيع بالتجزئة.

رمز التسلسل التشخيصي في FC00 يطابق تفريغ P2L الخاص بالبيع بالتجزئة. هناك نمط غريب من البيانات من 0x4000 إلى 0xFBFF.

## P01
تم تفريغه من جهاز Xbox v1.0. كلمة التكوين هي 0x86:
- CP1:CP0 = 0 (تم تفعيل حماية الكود للذاكرة كاملة)
- BODEN = 0 (تم تعطيل إعادة الضبط بسبب انخفاض الجهد)
- ~PWRTE = 0 (تم تفعيل مؤقت بدء التشغيل)
- WDTE = 1 (تم تفعيل مؤقت مراقبة الأعطال)
- FOSC1:FOSC0 = 2 (مذبذب عالي السرعة)

قيمة التكوين 0x3FB6 مناسبة لنسخ SMC بحيث لا يتم تفعيل حماية الكود.

## P11
تم تفريغه من جهاز Xbox v1.3. نفس كلمة التكوين مثل P01.

هناك بعض التغييرات الصغيرة في P11 مقارنةً بـ P01 بما في ذلك أمر إضافي لـ SMBus (كتابة 0x22)، أولويات LED مختلفة، وتوقيتات أكثر مرونة للإقلاع.

قمت بفحص تفريغات v1.3 المشفرة مقابل v1.4 وكانت متطابقة. هذا يعني أنه من المرجح جدًا أن لديهم نفس البرنامج.

## P2L
تم الحصول عليه من جهاز Xbox إصدار v1.6. مراجعة Xyclops A-A02. يحتوي على شيفرة Intel 8051 ولكنه يحتوي على العديد من سجلات الوظائف الخاصة التي لها وظائف غير معروفة.

يتم تشغيل المنفذ التسلسلي للتصحيح بواسطة الشيفرة عند FC00. يبدو وكأنه مصحح بدائي يمكنه إيقاف التنفيذ مؤقتًا، وتفريغ البيانات، والكتابة إلى السجلات/الذاكرة RAM.

# تفريغ Xyclops

شريحة Xyclops لديها 3 دبابيس لـ "التصحيح": TXD (دبوس 64)، RXD (دبوس 63)، وDEBUG (دبوس 29). قم بضبط دبوس DEBUG على مستوى مرتفع لتمكين المنفذ التسلسلي على دبابيس TX و RX. يعمل المنفذ التسلسلي بسرعة 9600 بود.

البروتوكول يعتمد على أوامر مكونة من 4 بايت عادةً في الصيغة `<cmd>` `<العنوان MSByte>` `<العنوان LSByte>` `<لا يهم>`

الأمر 0x14 يقوم بتفريغ 64 بايت من بيانات BIOS في كل مرة، والأمر 0x15 يقوم بتفريغ 64 بايت من بيانات برنامج SMC في كل مرة. تم تضمين تفريغ من Xyclops، P2L.bin، في المستودع. تم تضمين [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) أيضًا لتتمكن من تفريغ جهازك الخاص.

# منهجية تفريغ PIC
كتابة كاملة على https://wiki.recessim.com/view/PIC_Burnout

شريحة PIC لديها حماية شيفرة مفعلة، لذا كل البيانات تظهر كـ 0000. استخدمت خدعة للحصول على بيانات مشوشة بدلًا من ذلك، واكتشفت خوارزمية التشويش باستخدام شريحة تضحية، ثم استخدمت نوعًا من الاستغلال لتغيير بيانات ROM لتثبيت بعض البتات على قيم معروفة. بعد ذلك يمكنني استخراج المعلومات المطلوبة من عدة تفريغات مشوشة لإعادة بناء البيانات الأصلية.

# PICProgrammer
PICProgrammer هو أحد مشاريع Arduino القليلة لـ RP2040 التي استخدمتها في بحثي. يوفر واجهة سطر أوامر بسيطة لتنفيذ عمليات ICSP (برمجة تسلسلية داخل الدارة) على شريحة PIC. يفضل ذلك على استخدام مبرمج مخصص مثل PICkit بسبب مرونته وإمكانية تنفيذ أمور لم تكن الشركة المصنعة تنويها.

يجب أن يكون لديك فهم جيد للإلكترونيات والبرمجة قبل استخدام ذلك، وأن تلقي نظرة جيدة على ما تفعله الأوامر قبل تنفيذها.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---