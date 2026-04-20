<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

بديل مستضاف ذاتياً يركز على الخصوصية لتطبيق MyFitnessPal. تابع التغذية، التمارين، قياسات الجسم، وبيانات الصحة مع الحفاظ على السيطرة الكاملة على بياناتك.

![لقطة شاشة](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness هو منصة تتبع اللياقة البدنية مستضافة ذاتياً تتكون من:

- خادم خلفي (واجهة برمجية + تخزين البيانات)
- واجهة أمامية عبر الويب
- تطبيقات جوال أصلية لنظامي iOS و Android

يقوم بتخزين وإدارة بيانات الصحة على بنية تحتية تتحكم بها أنت، دون الاعتماد على خدمات الطرف الثالث.

## الميزات الأساسية

- تتبع التغذية، التمارين، الترطيب، النوم، الصيام، المزاج وقياسات الجسم
- تحديد الأهداف والمتابعة اليومية
- مخططات تفاعلية وتقارير طويلة المدى
- ملفات مستخدمين متعددة وإمكانية الوصول العائلي
- سمات فاتحة وداكنة
- OIDC، TOTP، Passkey، المصادقة متعددة العوامل وغيرها.

## تكاملات الصحة والأجهزة

يمكن لـ SparkyFitness مزامنة البيانات من عدة منصات صحة ولياقة بدنية:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (تم اختباره جزئياً)
- **Hevy** (لم يتم اختباره)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (تم اختباره جزئياً)

تقوم التكاملات بمزامنة بيانات النشاط تلقائياً مثل الخطوات والتمارين والنوم، بالإضافة إلى المقاييس الصحية مثل الوزن وقياسات الجسم، إلى خادم SparkyFitness الخاص بك.

## ميزات الذكاء الاصطناعي الاختيارية (تجريبية)

يوفر SparkyAI واجهة محادثة لتسجيل البيانات ومراجعة التقدم.

- تسجيل الطعام، التمارين، إحصاءات الجسم والخطوات عبر الدردشة
- رفع صور الطعام للتسجيل التلقائي للوجبات
- يحتفظ بسجل المحادثة للمتابعة لاحقًا

ملاحظة: ميزات الذكاء الاصطناعي حالياً في المرحلة التجريبية.

## البدء السريع (الخادم)

قم بتشغيل خادم SparkyFitness خلال دقائق باستخدام Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```


## 🎥 فيديو تعليمي

[![شاهد الفيديو](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

دليل سريع لمدة دقيقتين يوضح كيفية تثبيت SparkyFitness (متتبع اللياقة البدنية المستضاف ذاتياً).



## الوثائق

للحصول على أدلة التثبيت الكاملة، وخيارات التكوين، ووثائق التطوير، يرجى زيارة [موقع الوثائق](https://codewithcj.github.io/SparkyFitness/).

### روابط سريعة

- **[دليل التثبيت](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - النشر والتكوينات
- **[نظرة عامة على الميزات](https://codewithcj.github.io/SparkyFitness/features)** - وثائق الميزات الكاملة
- **[سير عمل التطوير](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - دليل المطورين وعملية المساهمة
- **[معلومات تطبيق iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** و **[معلومات تطبيق Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### هل تحتاج إلى مساعدة؟

- انشر في مناقشات أو مشاكل Github.
- للحصول على استجابة أسرع والمساعدة من أعضاء المجتمع الآخرين **[انضم إلى Discord الخاص بنا](https://discord.gg/vcnMT5cPEA)**

## تاريخ النجوم

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="مخطط تاريخ النجوم" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## الترجمات

**[ترجمات Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="حالة الترجمة" />
</a>

## نشاط المستودع

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "صورة تحليلات Repobeats")

## المساهمون

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ المشاكل المعروفة / الميزات التجريبية ⚠️

SparkyFitness تحت التطوير النشط.
قد تحدث تغييرات جذرية بين الإصدارات.

- لا يُوصى بتحديث الحاويات تلقائيًا
- يجب دائمًا مراجعة ملاحظات الإصدار قبل التحديث

الميزات التالية حاليًا في مرحلة تجريبية وقد لا تكون قد تم اختبارها بشكل كافٍ. توقع حدوث أخطاء أو وظائف غير مكتملة:

- روبوت الدردشة بالذكاء الاصطناعي
- وصول العائلة والأصدقاء
- توثيق واجهة برمجة التطبيقات (API)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---