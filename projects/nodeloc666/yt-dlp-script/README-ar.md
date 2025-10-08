
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 أداة تنزيل الفيديوهات الجماعية yt-dlp (دعم Windows / Linux)

> سكريبت تنزيل فيديوهات بنقرة واحدة مبني على [yt-dlp](https://github.com/yt-dlp/yt-dlp)، مستوحى من [مشاركة NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> يدعم تنزيل فيديو واحد أو عدة فيديوهات دفعة واحدة، ومتوافق مع نظامي Windows ومعظم توزيعات Linux الشائعة (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ الميزات الرئيسية

* 📥 **تشغيل بنقرة واحدة**: لا حاجة لإعداد يدوي، فقط أدخل المعلومات حسب التعليمات وابدأ التحميل مباشرة
* 🍪 **دعم تخصيص الكوكيز**: مناسب للفيديوهات التي تتطلب تسجيل الدخول للتحميل (⚠️ لم يتم التحقق من هذه الميزة بعد، قد توجد أخطاء)
* 📂 **دعم تخصيص مجلد الإخراج**: سهولة الحفظ في المجلد الذي تختاره
* 📃 **دعم التحميل الدُفعي**: قراءة تلقائية لروابط ملف `urls.txt` وتنزيلها جميعاً
* ⚙️ **تثبيت تلقائي للمتطلبات**: تثبيت تلقائي لـ `yt-dlp` و `ffmpeg` في بيئة لينكس

---

## 🖼️ معاينة لقطات الشاشة

| المثال 1                                                                  | المثال 2                                                                  |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![المثال 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![المثال 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![المثال 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![المثال 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 طريقة الاستخدام على Windows

1. قم بتنزيل الملفات التالية:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [إصدار Windows من `ffmpeg`](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. بعد فك الضغط، ضع الملفات التالية في نفس المجلد (مثل مجلد `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (ملف السكريبت)

3. انقر مزدوجاً لتشغيل `yt-dlp.bat` واتبع التعليمات لتنزيل الفيديو.
4. عدّل ملف config/config.ini لتغيير الإعدادات الافتراضية

---

## 🐧 طريقة الاستخدام على Linux (السكريبت الأحدث من lion مدمج فيه نفس الميزات)

**أنظمة الدعم**: Debian / Ubuntu / Alpine / CentOS

نشر أو تحديث وتشغيل بنقرة واحدة:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

لإلغاء التثبيت:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 توصية استخدام Android

1. استخدم تطبيق [Seal](https://github.com/JunkFood02/Seal) لتجربة ميزات `yt-dlp` على نظام Android.
2. يمكن تثبيت Debian عبر termux أيضًا للتحميل، لكن لا حاجة لذلك، فـ Seal سهل الاستخدام جدًا.

---

## ⚠️ ملاحظات هامة

1. **وضع التحميل الدفعي**: سيقوم السكربت تلقائيًا بقراءة ملف `config\urls.txt` في المجلد الحالي، وكل سطر يحتوي على رابط فيديو واحد. إذا لم يوجد الملف، سيتم إنشاؤه تلقائيًا.
2. **تنبيه استهلاك الموارد**: الأجهزة ذات الذاكرة المنخفضة يجب أن تتجنب تحميل عدة فيديوهات كبيرة في نفس الوقت أو تعيين عدد كبير من خيوط التنفيذ المتزامنة.
3. **ملاحظة خاصة لـ CentOS**: نظرًا لخصوصية البيئة، لم يتم اختبارها بالكامل بعد، يُنصح باستخدامها في بيئة غير إنتاجية. باقي الأنظمة الشائعة تم التحقق من عملها.
4. خطأ بسيط في نسخة Linux: عند تشغيل السكربت في الصفحة الرئيسية، سيتم فحص الاعتمادات مرة واحدة فقط، ووفقًا لمبدأ "يشغل الكود كما هو"، لم أقم بتعديله.
5. خطأ بسيط في نسخة Windows: عند العودة من صفحة أخرى إلى الصفحة الرئيسية ثم الاختيار مجددًا، قد يصبح الخيار الافتراضي غير فعال ويتسبب في دورة تعليق، ولم أتمكن من إصلاحه جيدًا.
حلّان متاحان:
    1. أعد تشغيل البرنامج من جديد.
    2. لا تستخدم الخيار الافتراضي، اختر حسب الرقم فقط.

---

## 📄 الرخصة

هذا المشروع يتبع [رخصة MIT](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---