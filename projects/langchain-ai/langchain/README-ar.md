<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="شعار لانغ تشين" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![ملاحظات الإصدار](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - الرخصة](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - التنزيلات](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![مخطط نجوم GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![المشاكل المفتوحة](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![فتح في حاويات التطوير](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="فتح في مساحة كودات Github" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![تويتر](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![شارة CodSpeed](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!ملاحظة]
> تبحث عن مكتبة JS/TS؟ اطلع على [LangChain.js](https://github.com/langchain-ai/langchainjs).

لانغ تشين هو إطار عمل لبناء تطبيقات مدعومة بالنماذج اللغوية الكبيرة (LLM). يساعدك على ربط
مكونات قابلة للتشغيل البيني وتكاملات خارجية لتبسيط تطوير تطبيقات الذكاء الاصطناعي — مع ضمان
الاستعداد للمستقبل مع تطور التقنية الأساسية.

```bash
pip install -U langchain
```

للتعرف أكثر على لانغ تشين، اطلع على
[التوثيق](https://python.langchain.com/docs/introduction/). إذا كنت تبحث عن تخصيص متقدم أو تنسيق الوكلاء، اطلع على
[LangGraph](https://langchain-ai.github.io/langgraph/)، إطار عملنا لبناء
تدفقات عمل للوكلاء القابلة للتحكم.

## لماذا تستخدم لانغ تشين؟

يساعد لانغ تشين المطورين على بناء تطبيقات مدعومة بالنماذج اللغوية الكبيرة من خلال واجهة
موحدة للنماذج، التضمين، مخازن المتجهات، وغيرها.

استخدم لانغ تشين في:
- **تعزيز البيانات في الوقت الحقيقي**. اربط النماذج اللغوية بسهولة بمصادر بيانات متنوعة وأنظمة خارجية/داخلية، بالاستفادة من مكتبة لانغ تشين الواسعة لتكاملات
مزودي النماذج، الأدوات، مخازن المتجهات، أدوات الاسترجاع، والمزيد.
- **تشغيل النماذج البيني**. استبدل النماذج بسهولة أثناء تجارب فريقك الهندسي للعثور على الخيار الأمثل لتطبيقك. مع تطور حدود الصناعة، تكيف بسرعة — تجريدات لانغ تشين تتيح لك التحرك دون فقدان الزخم.

## منظومة لانغ تشين
بينما يمكن استخدام إطار عمل لانغ تشين بشكل مستقل، إلا أنه يندمج بسلاسة مع أي منتج من منتجات لانغ تشين، مما يمنح المطورين مجموعة أدوات متكاملة عند بناء تطبيقات النماذج اللغوية الكبيرة.

لتطوير تطبيقاتك مع النماذج اللغوية الكبيرة، استخدم لانغ تشين مع:

- [LangSmith](http://www.langchain.com/langsmith) - مفيد لتقييم الوكلاء
والمراقبة. تتبع وتشخيص عمليات تطبيقات النماذج اللغوية ذات الأداء الضعيف، تقييم مسارات الوكلاء، اكتساب رؤية في الإنتاج، وتحسين الأداء بمرور الوقت.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - بناء وكلاء يمكنهم
التعامل بثقة مع المهام المعقدة باستخدام LangGraph، إطارنا منخفض المستوى لتنظيم الوكلاء. يوفر LangGraph بنية قابلة للتخصيص، ذاكرة طويلة الأمد، وتدفقات عمل بمشاركة الإنسان — ويُعتمد عليه في الإنتاج من قبل شركات مثل LinkedIn وUber وKlarna وGitLab.
- [منصة LangGraph](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - انشر
ووسع نطاق الوكلاء بسهولة باستخدام منصة نشر مصممة خصيصاً لتدفقات العمل طويلة الأمد وحالة التشغيل المستمرة. اكتشف، أعد الاستخدام، عدّل، وشارك الوكلاء عبر الفرق — وتابع التطوير بسرعة مع النمذجة البصرية في
[استوديو LangGraph](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## موارد إضافية
- [الدروس التعليمية](https://python.langchain.com/docs/tutorials/): شروحات مبسطة مع
أمثلة عملية للبدء باستخدام لانغ تشين.
- [أدلة كيفية الاستخدام](https://python.langchain.com/docs/how_to/): مقتطفات شيفرة سريعة وقابلة للتنفيذ حول مواضيع مثل استدعاء الأدوات، حالات استخدام RAG، والمزيد.
- [أدلة مفاهيمية](https://python.langchain.com/docs/concepts/): شرح للمفاهيم الرئيسية وراء إطار عمل لانغ تشين.
- [مرجع API](https://python.langchain.com/api_reference/): مرجع مفصل
لتنقل الحزم الأساسية والتكاملات في لانغ تشين.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---