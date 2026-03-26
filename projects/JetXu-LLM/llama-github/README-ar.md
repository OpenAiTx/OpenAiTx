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
      </div>
    </div>
  </details>
</div>

# لاما-جيت هب

[وثيقة التفاصيل] https://deepwiki.com/JetXu-LLM/llama-github

[![إصدار PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![عدد التحميلات](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![الرخصة](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

لاما-جيت هب هو أداة قوية تساعدك على استرجاع (استنادًا إلى Agentic RAG) أكثر مقتطفات الشيفرة، والمشكلات، ومعلومات المستودع صلة من GitHub بناءً على استفساراتك، وتحويلها إلى سياق معرفي قيم. تمكّن روبوتات الدردشة LLM، ووكلاء الذكاء الاصطناعي، ووكلاء التطوير الذاتي من حل مهام البرمجة المعقدة. سواء كنت مطورًا تبحث عن حلول سريعة أو مهندسًا يقوم بتنفيذ وكلاء الذكاء الاصطناعي المتقدمين Auto Dev، يجعل لاما-جيت هب الأمر سهلاً وفعالاً.

إذا أعجبك هذا المشروع أو تعتقد أنه ذو إمكانات، يرجى منحه نجمة ⭐️. دعمك هو أكبر دافع لنا!

## البنية المعمارية
![البنية المعمارية عالية المستوى](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## التثبيت

```
pip install llama-github
```

هدف التشغيل الحالي المدعوم: بايثون `3.10+`.

## الاستخدام

إليك مثال بسيط لكيفية استخدام llama-github:

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
تعيد الدالة `retrieve_context()` قائمة من القواميس السياقية. يحتوي كل عنصر على الأقل على `context` و `url`.

لمزيد من الاستخدامات المتقدمة والأمثلة، يرجى الرجوع إلى [التوثيق](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). تتوفر أيضًا أمثلة عملية منخفضة التكلفة في [`examples/`](examples).

## الميزات الرئيسية

- **🔍 استرجاع ذكي من GitHub**: استفد من قوة llama-github لاسترجاع مقتطفات الشيفرة ذات الصلة العالية، والمسائل، ومعلومات المستودعات من GitHub بناءً على استفسارات المستخدم. تضمن تقنيات الاسترجاع المتقدمة لدينا أن تجد أكثر المعلومات صلة بسرعة وكفاءة.

- **⚡ تخزين مؤقت لمجموعة المستودعات**: لدى llama-github آلية مبتكرة لتخزين مجموعة المستودعات مؤقتًا. من خلال تخزين المستودعات (بما في ذلك ملفات README والبُنى والشيفرة والمسائل) عبر الخيوط، يُسرّع llama-github بشكل كبير كفاءة استرجاع البحث من GitHub ويقلل بشكل كبير من استهلاك رموز GitHub API.

- **🧠 تحليل الأسئلة المدعوم بالنماذج اللغوية**: استثمر أحدث نماذج اللغة لتحليل أسئلة المستخدمين وتوليد استراتيجيات ومعايير بحث فعالة للغاية. يقوم llama-github بتفكيك الاستفسارات المعقدة بذكاء، ما يضمن استرجاعك لأكثر المعلومات صلة من شبكة مستودعات GitHub الواسعة.

- **📚 توليد سياق شامل**: أنشئ إجابات غنية وذات صلة بالسياق من خلال دمج المعلومات المسترجعة من GitHub مع قدرات الاستدلال للنماذج اللغوية المتقدمة. يتفوّق llama-github في معالجة حتى أكثر الأسئلة تعقيدًا وطولًا، ويقدّم إجابات شاملة وبصيرة تتضمن سياقًا واسعًا لدعم احتياجاتك التطويرية.

- **🚀 التميز في المعالجة غير المتزامنة**: بُني llama-github من الألف إلى الياء للاستفادة الكاملة من برمجة العمليات غير المتزامنة. مع آليات غير متزامنة منفذة بعناية في جميع أنحاء قاعدة الشيفرة، يمكن لـ llama-github التعامل مع طلبات متعددة في وقت واحد، مما يزيد الأداء الإجمالي بشكل كبير.

- **🔧 تكامل مرن مع النماذج اللغوية**: قم بدمج llama-github بسهولة مع مزودي النماذج اللغوية المختلفين، أو نماذج التضمين، أو نماذج إعادة الترتيب، أو نموذج محادثة متوافق مع LangChain لتخصيص قدرات المكتبة بما يتناسب مع متطلباتك الخاصة.

- **🔒 خيارات مصادقة قوية**: يدعم llama-github رموز الوصول الشخصية بالإضافة إلى المصادقة عبر تطبيق GitHub، مما يوفر لك المرونة في دمجه مع بيئات تطوير مختلفة. سواء كنت مطورًا فرديًا أو تعمل ضمن إطار تنظيمي، يغطيك llama-github بآليات مصادقة آمنة وموثوقة.

- **🛠️ السجل ومعالجة الأخطاء**: نحن ندرك أهمية العمليات السلسة وسهولة استكشاف الأخطاء وإصلاحها. لهذا يأتي llama-github مزودًا بآليات تسجيل شاملة ومعالجة متقدمة للأخطاء. احصل على رؤى عميقة حول سلوك المكتبة، وقم بتشخيص المشكلات بسرعة، واحتفظ بسير عمل تطوير مستقر وموثوق.

## 🤖 جرب مساعد مراجعة PR المدعوم بالذكاء الاصطناعي: LlamaPReview

إذا وجدت llama-github مفيدًا، قد تهتم أيضًا بمساعد مراجعة PR في GitHub المدعوم بالذكاء الاصطناعي LlamaPReview. إنه مصمم ليكمل سير عملك التطويري ويعزز جودة الشيفرة بشكل أكبر.

### الميزات الرئيسية لـ LlamaPReview:
- 🚀 تثبيت بنقرة واحدة، دون الحاجة لأي إعدادات، وتشغيل تلقائي كامل
- 💯 مجاني حاليًا للاستخدام - لا حاجة لبطاقة ائتمان أو معلومات دفع
- 🧠 مراجعات PR تلقائية ومدعومة بالذكاء الاصطناعي مع فهم عميق للشيفرة
- 🌐 يدعم لغات برمجة متعددة

**يستخدم LlamaPReview تقنيات الاسترجاع السياقي المتقدمة وتحليل النماذج اللغوية في llama-github** لتقديم مراجعات شيفرة ذكية وواعية للسياق. إنه أشبه بمطور كبير يراجع كل PR تلقائيًا ومعه كامل سياق المستودع!

👉 [ثبت LlamaPReview الآن](https://github.com/marketplace/llamapreview/) (مجاني)

باستخدام llama-github لاسترجاع السياق وLlamaPReview لمراجعة الشيفرة، يمكنك إنشاء بيئة تطوير قوية مدعومة بالذكاء الاصطناعي.

## الرؤية وخارطة الطريق


### الرؤية

رؤيتنا هي أن نصبح وحدة محورية في مستقبل حلول التطوير المعتمدة على الذكاء الاصطناعي، من خلال التكامل السلس مع GitHub لتمكين نماذج اللغة الكبيرة من حل المهام البرمجية المعقدة تلقائيًا.

![هندسة الرؤية](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### خارطة الطريق

للاطلاع على العرض التاريخي لخارطة الطريق السابقة، يرجى زيارة [الرؤية وخارطة الطريق](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## الشكر والتقدير

نود أن نعبر عن امتناننا للمشاريع مفتوحة المصدر التالية لدعمها ومساهماتها:

- **[LangChain](https://github.com/langchain-ai/langchain)**: لتوفير الإطار الأساسي الذي يدعم قدرات الاستدعاء والمعالجة لنماذج اللغة الكبيرة في llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: لتقديم واجهة برمجة التطبيقات s.jina.ai ونماذج إعادة الترتيب والتضمين مفتوحة المصدر التي تعزز دقة وملاءمة السياقات المولدة في llama-github.

لقد كانت مساهماتهم جوهرية في تطوير llama-github، ونوصي بشدة بالاطلاع على مشاريعهم للحصول على حلول مبتكرة أخرى.

## المساهمة

نرحب بالمساهمات في llama-github! يرجى مراجعة [إرشادات المساهمة](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) لمزيد من المعلومات.

## الترخيص

هذا المشروع مرخص بموجب شروط ترخيص Apache 2.0. راجع ملف [الترخيص](LICENSE) لمزيد من التفاصيل.

## التواصل

إذا كانت لديك أي أسئلة أو اقتراحات أو ملاحظات، لا تتردد في التواصل معنا عبر [البريد الإلكتروني لـ Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

شكرًا لاختيارك llama-github! نأمل أن تعزز هذه المكتبة تجربتك في تطوير الذكاء الاصطناعي وأن تساعدك في بناء تطبيقات قوية بسهولة.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---