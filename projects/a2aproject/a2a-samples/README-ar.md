# عينات Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="جرّب في Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 اللغة</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
    </div>
  </details>
</div>

مرحبًا بك في العينات البرمجية الرسمية والعروض التوضيحية لـ [بروتوكول Agent2Agent (A2A)](https://goo.gle/a2a).

يسعدنا وجودك هنا! سواء كنت تستكشف بنى متعددة الوكلاء لأول مرة أو تبني شبكات وكلاء متقدمة وقابلة للتشغيل البيني، يوفر هذا المستودع موارد تعليمية بسيطة وملهمة وسهلة الوصول لتسريع تطويرك.

## لماذا Agent2Agent؟

في عالم من أطر عمل وأنظمة الذكاء الاصطناعي المتنوعة، يحتاج الوكلاء إلى لغة مشتركة للتواصل والتعاون وتفويض المهام بشكل آمن. يضع بروتوكول A2A معيارًا مفتوحًا وموحدًا لتشغيل الوكلاء المتعددين معًا.

توضح عيناتنا كيف يمكن حل مشاكل الوكلاء المتعددين المعقدة بسهولة عبر لغات وتطبيقات مستضيفة مختلفة.

## بدء سريع

ابدأ فورًا بتشغيل وكيل Helloworld والتواصل معه عبر مضيف CLI الخاص بنا بلغة بايثون.

1. **تشغيل خادم الوكيل**:
   افتح نافذة الطرفية وابدأ تشغيل خادم وكيل Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **تشغيل عميل المضيف**:
   افتح نافذة طرفية ثانية وشغّل عميل CLI لإرسال مهمة إلى الوكيل:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## هيكلية المستودع

يتم تنظيم المستودع في عدة أدلة رئيسية حسب اللغة:

| الدليل | الوصف |
| --- | --- |
| [samples](/samples) | عينات A2A الأساسية منظمة حسب لغة البرمجة. |
| [samples/python](/samples/python) | توضح تنفيذات الوكلاء بلغة بايثون باستخدام A2A Python SDK. |
| [samples/go](/samples/go) | توضح تنفيذات الوكلاء بلغة Go باستخدام A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | توضح تنفيذات الوكلاء بلغة C# باستخدام A2A .NET SDK. |
| [samples/java](/samples/java) | توضح تنفيذات الوكلاء بلغة جافا باستخدام A2A Java SDK. |
| [samples/js](/samples/js) | توضح تنفيذات الوكلاء بلغة Node.js باستخدام A2A JavaScript SDK. |

## المساهمة

نرحب ونشجع المساهمات من جميع المستويات! إذا كان لديك فكرة لعينة جديدة، أو إصلاح خطأ، أو تحسين في الوثائق، يرجى مراجعة [دليل المساهمة](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## الحصول على المساعدة

نحن ملتزمون بتقديم مجتمع مرحب وداعم. إذا كانت لديك أسئلة أو ملاحظات أو واجهت أي مشاكل، يرجى التواصل عبر [صفحة القضايا](https://github.com/a2aproject/a2a-samples/issues).

## المستودعات ذات الصلة

| المستودع | الفئة | الوصف |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | المواصفة الأساسية | مواصفة ووثائق A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | الأدوات | أداة واجهة مستخدم لفحص الوكلاء الداعمين لـ A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | الاختبار | مجموعة اختبارات للتحقق من التوافق مع بروتوكول A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | الاختبار | مجموعة أدوات للتحقق من التوافق بين إصدارات وتنفيذات A2A SDK المختلفة باستخدام نموذج التنقل متعدد القفزات وبروتوكولات نقل متنوعة. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (بايثون) | مكتبة SDK الرسمية لـ A2A بلغة بايثون. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | مكتبة SDK الرسمية لـ A2A بلغة Go. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (جافا) | مكتبة SDK الرسمية لـ A2A بلغة جافا. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (جافا سكريبت) | مكتبة SDK الرسمية لـ A2A بلغة Node.js/جافا سكريبت. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | مكتبة SDK الرسمية لـ A2A بلغة C#/.NET. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | مكتبة SDK الرسمية لـ A2A بلغة Rust. |

## إخلاء المسؤولية

**هام:** الكود البرمجي التجريبي المقدم هو لأغراض التوضيح فقط ويشرح آلية
بروتوكول التواصل بين الوكلاء (A2A). عند بناء تطبيقات الإنتاج، من الضروري اعتبار أي وكيل يعمل خارج نطاق سيطرتك المباشرة ككيان غير موثوق به محتمل.

يجب التعامل مع جميع البيانات المستلمة من وكيل خارجي—بما في ذلك بطاقة الوكيل، الرسائل،
القطع الفنية، وحالات المهام—كمدخلات غير موثوق بها. على سبيل المثال، قد يقدم وكيل خبيث
بطاقة وكيل تحتوي على بيانات مصطنعة في حقولها (مثل الوصف، الاسم،
skills.description). إذا تم استخدام هذه البيانات بدون تنقيح لبناء مطالبات لنموذج اللغة الكبير (LLM)، فقد تعرض تطبيقك لهجمات حقن المطالبات. عدم
التحقق والتنقية السليمة لهذه البيانات قبل الاستخدام يمكن أن يؤدي إلى ثغرات أمنية في
تطبيقك.

> يتحمل المطورون مسؤولية تنفيذ تدابير الأمان المناسبة، مثل التحقق من صحة المدخلات
> والتعامل الآمن مع بيانات الاعتماد لحماية أنظمتهم ومستخدميهم.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---