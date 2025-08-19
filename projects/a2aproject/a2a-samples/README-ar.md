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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">اللغة الإندونيسية</a>
    </div>
  </details>
</div>

يحتوي هذا المستودع على عينات من الشيفرات وعروض توضيحية تستخدم [بروتوكول Agent2Agent (A2A)](https://goo.gle/a2a).

## المستودعات ذات الصلة

- [A2A](https://github.com/a2aproject/A2A) - المواصفات والوثائق الخاصة بـ A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - مجموعة تطوير البرمجيات A2A بلغة بايثون.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - أداة واجهة المستخدم لفحص الوكلاء المدعومين ببروتوكول A2A.

## المساهمة

نرحب بالمساهمات! راجع [دليل المساهمة](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## الحصول على المساعدة

يرجى استخدام [صفحة المشكلات](https://github.com/a2aproject/a2a-samples/issues) لتقديم الاقتراحات أو الملاحظات أو الإبلاغ عن الأخطاء.

## إخلاء المسؤولية

هذا المستودع نفسه ليس منتجاً رسمياً مدعوماً من Google. الشيفرة الموجودة في هذا المستودع لأغراض العرض التوضيحي فقط.

هام: الشيفرات البرمجية المعروضة هنا لأغراض العرض فقط وتوضح آلية عمل بروتوكول الوكيل إلى الوكيل (A2A). عند بناء تطبيقات الإنتاج، من الضروري اعتبار أي وكيل يعمل خارج نطاق سيطرتك المباشرة كجهة غير موثوقة محتملة.

يجب التعامل مع جميع البيانات المستقبلة من وكيل خارجي—بما في ذلك بطاقة الوكيل والرسائل والمواد وحالات المهام—على أنها مدخلات غير موثوقة. على سبيل المثال، قد يقدم وكيل ضار بطاقة وكيل تحتوي على بيانات مصاغة في حقولها (مثل الوصف، الاسم، skills.description). إذا تم استخدام هذه البيانات دون تنقيح لإنشاء مطالبات لنموذج لغة كبير (LLM)، فقد تعرض تطبيقك لهجمات حقن المطالبات. عدم التحقق وتنقيح هذه البيانات بشكل صحيح قبل استخدامها يمكن أن يؤدي إلى إدخال ثغرات أمنية في تطبيقك.

يقع على عاتق المطورين تنفيذ التدابير الأمنية المناسبة، مثل التحقق من المدخلات والتعامل الآمن مع بيانات الاعتماد لحماية أنظمتهم ومستخدميهم.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---