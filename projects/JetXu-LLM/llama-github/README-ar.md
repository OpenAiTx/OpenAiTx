
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[وثيقة مفصلة] https://deepwiki.com/JetXu-LLM/llama-github

[![إصدار PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![عدد التحميلات](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![الرخصة](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github هو أداة قوية تساعدك على استرجاع (استنادًا إلى Agentic RAG) أكثر أجزاء الشيفرة والمواضيع ومعلومات المستودع صلة من GitHub استنادًا إلى استفساراتك، وتحويلها إلى سياق معرفي قيم. تمكن روبوتات الدردشة LLM، ووكلاء الذكاء الاصطناعي، ووكلاء التطوير التلقائي من حل المهام البرمجية المعقدة. سواء كنت مطورًا تبحث عن حلول سريعة أو مهندسًا يطبق وكلاء الذكاء الاصطناعي المتقدمين للتطوير التلقائي، فإن llama-github يجعل الأمر سهلاً وفعالاً.

إذا أعجبك هذا المشروع أو تعتقد أنه ذو إمكانيات، يرجى منحه ⭐️. دعمك هو أعظم دافع لنا!

## البنية المعمارية
![البنية المعمارية عالية المستوى](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## التثبيت
```
pip install llama-github
```

## الاستخدام

إليك مثال بسيط عن كيفية استخدام llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

لمزيد من الاستخدامات المتقدمة والأمثلة، يرجى الرجوع إلى [التوثيق](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## الميزات الرئيسية

- **🔍 استرجاع ذكي من GitHub**: استمتع بقوة llama-github لاسترجاع مقتطفات الشيفرة ذات الصلة، والمشكلات، ومعلومات المستودعات من GitHub بناءً على استفسارات المستخدم. تضمن تقنيات الاسترجاع المتقدمة لدينا أن تجد المعلومات الأكثر صلة بسرعة وكفاءة.

- **⚡ تخزين مؤقت لمجمع المستودعات**: يحتوي llama-github على آلية تخزين مؤقت مبتكرة لمجمع المستودعات. من خلال تخزين المستودعات مؤقتًا (بما في ذلك ملفات README والهياكل والشيفرة والمشكلات) عبر الخيوط، يعزز llama-github كفاءة استرجاع البحث من GitHub بشكل كبير ويقلل من استهلاك رموز API الخاصة بـ GitHub. يمكنك نشر llama-github في بيئات الإنتاج متعددة الخيوط بثقة، مع العلم أنه سيعمل بأفضل أداء ويوفر لك مواردك القيمة.

- **🧠 تحليل الأسئلة مدعوم بـ LLM**: استعن بأحدث نماذج اللغة لتحليل أسئلة المستخدمين وتوليد استراتيجيات ومعايير بحث فعالة للغاية. يقوم llama-github بتفكيك الاستفسارات المعقدة بذكاء، مما يضمن استرجاعك لأكثر المعلومات صلة من شبكة مستودعات GitHub الواسعة.

- **📚 توليد سياق شامل**: أنشئ إجابات غنية وملائمة سياقيًا من خلال دمج المعلومات المسترجعة من GitHub بسلاسة مع قدرات الاستنتاج لنماذج اللغة المتقدمة. يبرع llama-github في التعامل مع أكثر الأسئلة تعقيدًا وطولًا، مقدمًا ردودًا شاملة وبصيرة تتضمن سياقًا واسعًا لدعم احتياجاتك التطويرية.

- **🚀 التميز في المعالجة غير المتزامنة**: بُني llama-github من الأساس ليستفيد من الإمكانيات الكاملة للبرمجة غير المتزامنة. بفضل الآليات غير المتزامنة المنفذة بعناية في جميع أنحاء قاعدة الشيفرة، يمكن لـ llama-github معالجة طلبات متعددة في وقت واحد، مما يعزز الأداء العام بشكل كبير. اختبر الفرق بينما يدير llama-github أحمال العمل ذات الحجم الكبير بكفاءة دون التضحية بالسرعة أو الجودة.

- **🔧 تكامل مرن مع LLM**: يمكنك دمج llama-github بسهولة مع مزودي LLM المختلفين، ونماذج التضمين، ونماذج إعادة الترتيب لتخصيص قدرات المكتبة وفقًا لمتطلباتك الخاصة. يسمح لك الهيكل القابل للتوسعة بتخصيص وتحسين وظائف llama-github، مما يضمن تكيفه بسلاسة مع بيئة تطويرك الفريدة.

- **🔒 خيارات مصادقة قوية**: يدعم llama-github كلًا من رموز الوصول الشخصية ومصادقة تطبيق GitHub، مما يوفر لك المرونة لدمجه في إعدادات تطوير مختلفة. سواء كنت مطورًا فرديًا أو تعمل ضمن سياق تنظيمي، يضمن لك llama-github آليات مصادقة آمنة وموثوقة.

- **🛠️ السجلات ومعالجة الأخطاء**: نحن ندرك أهمية العمليات السلسة وسهولة استكشاف الأخطاء. لهذا السبب يأتي llama-github مزودًا بآليات تسجيل شاملة ومعالجة أخطاء قوية. احصل على رؤى عميقة حول سلوك المكتبة، وشخّص المشكلات بسرعة، وحافظ على سير عمل تطوير مستقر وموثوق.

## 🤖 جرّب مساعد مراجعة PR المدعوم بالذكاء الاصطناعي: LlamaPReview

إذا وجدت أن llama-github مفيد، قد تهتم أيضًا بمساعد مراجعة PR على GitHub المدعوم بالذكاء الاصطناعي، LlamaPReview. تم تصميمه ليكمل سير عملك التطويري ويعزز جودة الشيفرة.

### الميزات الرئيسية لـ LlamaPReview:
- 🚀 تثبيت بنقرة واحدة، بدون إعدادات مطلوبة، تشغيل تلقائي بالكامل
- 💯 مجاني حاليًا للاستخدام - لا حاجة لبطاقة ائتمان أو معلومات دفع
- 🧠 مراجعات PR تلقائية مدعومة بالذكاء الاصطناعي مع فهم عميق للشيفرة
- 🌐 يدعم عدة لغات برمجة

**يستخدم LlamaPReview قدرات الاسترجاع المتقدم للسياق وتحليل LLM من llama-github** لتقديم مراجعات شيفرة ذكية وواعية بالسياق. إنه كأن لديك مطورًا كبيرًا، مطلعًا على سياق مستودعك بالكامل، يراجع كل PR تلقائيًا!

👉 [ثبّت LlamaPReview الآن](https://github.com/marketplace/llamapreview/) (مجاني)

باستخدام llama-github لاسترجاع السياق وLlamaPReview لمراجعة الشيفرة، يمكنك إنشاء بيئة تطوير قوية معززة بالذكاء الاصطناعي.

## الرؤية وخارطة الطريق

### الرؤية

رؤيتنا أن نصبح وحدة محورية في مستقبل حلول التطوير المدفوعة بالذكاء الاصطناعي، من خلال التكامل السلس مع GitHub لتمكين LLMs من حل المهام البرمجية المعقدة تلقائيًا.

![هندسة الرؤية](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### خارطة الطريق

للاطلاع على خارطة الطريق التفصيلية لمشروعنا، يرجى زيارة [خارطة المشروع](https://github.com/users/JetXu-LLM/projects/2).

## الشكر والتقدير

نود أن نعبر عن امتناننا للمشاريع مفتوحة المصدر التالية لدعمهم ومساهماتهم:

- **[LangChain](https://github.com/langchain-ai/langchain)**: لتوفير الإطار الأساسي الذي يمكّن قدرات تحفيز ومعالجة LLM في llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: لتقديم واجهة s.jina.ai API ونماذج إعادة الترتيب والتضمين مفتوحة المصدر التي تعزز دقة وملاءمة السياقات المولدة في llama-github.

لقد كانت مساهماتهم أساسية في تطوير llama-github، ونوصي بشدة بالاطلاع على مشاريعهم لمزيد من الحلول المبتكرة.

## المساهمة

نرحب بمساهماتكم في llama-github! يرجى مراجعة [إرشادات المساهمة](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) الخاصة بنا لمزيد من المعلومات.

## الرخصة

هذا المشروع مرخص وفقًا لشروط رخصة Apache 2.0. راجع ملف [الرخصة](LICENSE) لمزيد من التفاصيل.

## التواصل

إذا كان لديك أي أسئلة أو اقتراحات أو ملاحظات، لا تتردد في التواصل معنا عبر [بريد Jet Xu الإلكتروني](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

شكرًا لاختيارك llama-github! نأمل أن تعزز هذه المكتبة تجربتك في تطوير الذكاء الاصطناعي وتساعدك على بناء تطبيقات قوية بسهولة.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---