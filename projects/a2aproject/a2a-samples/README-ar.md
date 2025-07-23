
# عينات Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

يحتوي هذا المستودع على عينات من الشفرات وعروض توضيحية تستخدم [بروتوكول Agent2Agent (A2A)](https://goo.gle/a2a).

## المستودعات ذات الصلة

- [A2A](https://github.com/a2aproject/A2A) - مواصفات A2A والتوثيقات.
- [a2a-python](https://github.com/a2aproject/a2a-python) - حزمة تطوير برامج A2A بلغة بايثون.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - أداة واجهة مستخدم لفحص العوامل المدعومة بـ A2A.

## المساهمة

المساهمات مرحب بها! راجع [دليل المساهمة](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## الحصول على المساعدة

يرجى استخدام [صفحة المشاكل](https://github.com/a2aproject/a2a-samples/issues) لتقديم الاقتراحات أو الملاحظات أو الإبلاغ عن عطل.

## إخلاء المسؤولية

هذا المستودع نفسه ليس منتجًا رسميًا مدعومًا من Google. الشفرة في هذا المستودع لأغراض توضيحية فقط.

هام: الشفرة البرمجية المقدمة هي لأغراض العرض فقط وتوضح آلية بروتوكول Agent-to-Agent (A2A). عند بناء تطبيقات للإنتاج، من المهم التعامل مع أي وكيل يعمل خارج نطاق تحكمك المباشر باعتباره كيانًا غير موثوق به.

يجب التعامل مع جميع البيانات المستلمة من وكيل خارجي — بما في ذلك، وليس حصراً على، بطاقة الوكيل AgentCard، الرسائل، الملفات، وحالات المهام — على أنها مدخلات غير موثوقة. على سبيل المثال، قد يوفر وكيل خبيث بطاقة وكيل تحتوي على بيانات معدلة في حقولها (مثلاً: الوصف، الاسم، skills.description). إذا تم استخدام هذه البيانات بدون تنقيح لإنشاء مدخلات لنموذج لغة كبير (LLM)، فقد تعرض تطبيقك لهجمات حقن المدخلات. عدم التحقق وتنقيح هذه البيانات بشكل صحيح قبل الاستخدام قد يؤدي إلى إدخال ثغرات أمنية في تطبيقك.

يقع على عاتق المطورين تنفيذ تدابير أمنية مناسبة، مثل التحقق من صحة المدخلات والتعامل الآمن مع بيانات الاعتماد لحماية أنظمتهم ومستخدميهم.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---