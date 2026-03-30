
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# إيضاح

- [وصف المشروع](#project-description)
- [متطلبات النظام:](#os-requirements)
- [الأسئلة الشائعة](#faqs)
- [خارطة الطريق](#roadmap)
- [لقطات الشاشة](#screenshots)

## وصف المشروع

Elucidate هو واجهة رسومية لنظام ويندوز تعمل كواجهة أمامية لتطبيق SnapRAID القائم على سطر الأوامر.

*هذا المشروع يواصل دمج العمل الرائع الذي قمت به أنا ومساهمون آخرون.

## متطلبات النظام

- نظام تشغيل ويندوز
- .Net Runtime 4.8.0
- SnapRaid إصدار 11.5 أو أقل
- مساحة حرة 10 ميجابايت على القرص الهدف

## الأسئلة الشائعة

**س:** ما هو SnapRAID؟<br/>
**ج:** SnapRAID هو محرك تصوير باللقطات (snapshot-parity) معرف بالبرمجيات لأنظمة ويندوز ولينكس. على أبسط مستوى، يوفر حماية لمحتوى نظام الملفات الخاضع له عن طريق حساب تجزئة ملفاته وتخزين النتائج في ملف تعادل. في حال حدوث عطل كامل في القرص الصلب، يمكن استخدام ملف التعادل هذا لاستعادة البيانات المفقودة. للمزيد من التفاصيل، راجع [المقارنة الرسمية لمحركات حماية الملفات من SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**س:** لماذا واجهة رسومية، وسطر الأوامر يعمل!<br/>
**ج:** الهدف الأكبر هو إنشاء واجهة رسومية متكاملة الميزات مع ميزات إدارة إضافية لمساعدة المستخدم في الحفاظ على بيئة SnapRAID فعالة. في بعض الأحيان، تعتبر "النقرات" أسهل للمبتدئ للبدء. توثيق SnapRAID الفني وعمق خياراته قد يجعل استخدامه أمراً صعباً لمن يرغب في تجربته لأول مرة!

**س:** ما زلت غير متأكد، هل هناك المزيد؟<br/>
**ج:** نعم، ألقِ نظرة على [التوثيق](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) للاطلاع على الصور وغيرها.

**س:** إذاً ما هي "الأهداف الأكبر"؟<br/>
**ج:** راجع __خارطة الطريق__ أدناه لمزيد من التفاصيل.

## خارطة الطريق

- [x] المرحلة الأولى
  - [x] محاولة مواكبة الحد الأدنى من دعم SnapRAID الأحدث. - __مستمر.__
  - [x] سهولة الاستخدام
  - [x] لدى SnapRAID ثلاثة أوامر، فلنجعلها سهلة الوصول للمبتدئين
  - [x] مؤشرات التقدم
  - [x] التسجيل "تفاعلي" ومباشر إلى السجل.
  - [x] التشغيل التلقائي عند تسجيل دخول المستخدم
  - [x] تلميحات الأدوات للإرشاد •	

- [x] المرحلة الثانية طلبات ميزات المرحلة الثانية
  - [x] إيقاف مؤقت، تغيير الأولوية، إلغاء.
  - [x] تمديد الأوامر - "السماح بمعلمات إضافية للإعدادات الافتراضية المستخدمة."
  - [x] الجدولة
    - تم الإزالة، استخدم سطر الأوامر
  - [x] عرض رسومي للبيانات المحمية.

- [ ] المرحلة الثالثة (إعادة البدء من 2017-03 فصاعداً)
  - [x] مترجم جديد و .Net 4.7.x
  - [x] واجهة سطر الأوامر
  - [ ] تخطيط جديد عبر Krypton Toolkit / Navigator / إلخ.
    - قيد التنفيذ
  - [ ] الترجمات
  - [x] أوامر جديدة
  - [ ] المرسل مع تقارير الحالة
  - [ ] توثيق خطوات الاختبار
    - قيد التنفيذ
  - [ ] الإضافة إلى الوثائق / تحديث الصور
    - قيد التنفيذ
  - [ ] إضافة تقارير أخطاء _Windows EventLog_
  - [x] إضافة _ExceptionLess_ للتقارير عبر الإنترنت عن الاستثناءات
  - [x] عرض ما يمكن استرجاعه.

- [ ] المرحلة الرابعة (أوامر SnapRAID جديدة؟)
  - [ ] مساعدة موسعة مع استرجاع الأقراص - أدلة تفاعلية وما إلى ذلك..
  - [ ] تنبيه المستخدم إذا كان إصدار SnapRAID قديمًا
  - [ ] تفسير سجلات SnapRAID (يُستخدم بواسطة التغييرات أدناه)
  - [ ] توفير حالة المصفوفة بعد تشغيل الأمر
  - [ ] تعديل أمر المزامنة ليشمل مقارنة أولية
  - [ ] تعديل أمر المزامنة ليظهر تحذيرًا إذا أبلغت المقارنة عن مشاكل تتجاوز الحد المسموح
  - [ ] إضافة إعدادات قابلة للتخصيص من قبل المستخدم لمتطلبات حد المزامنة

## لقطات الشاشة

![عرض البداية](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![نموذج الإعدادات](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## هل يمكنك المساعدة؟
- مطلوب مختبرون (جميع منصات .Net)

- يمكن أن يساعد في الترجمة
- المساعدة / أدلة واجهة المستخدم
- أي أفكار أخرى :-)
- المطورون للأفكار


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---