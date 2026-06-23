# بروتوكول Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![رخصة أباتشي](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="اسأل كود ويكي" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 اللغة</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="شعار بروتوكول Agent2Agent" width="100">
    <h1>بروتوكول Agent2Agent (A2A)</h1>
  </div>
</div>

**بروتوكول مفتوح يمكّن التواصل والتشغيل البيني بين تطبيقات العوامل الذكية الغامضة.**

يعالج بروتوكول Agent2Agent (A2A) تحديًا أساسيًا في مشهد الذكاء الاصطناعي: تمكين العوامل الذكية التوليدية، المبنية على أطر متنوعة من شركات مختلفة وتعمل على خوادم منفصلة، من التواصل والتعاون بفعالية - كعوامل مستقلة، وليس فقط كأدوات. يهدف بروتوكول A2A إلى توفير لغة مشتركة للعوامل، مما يعزز بيئة ذكاء اصطناعي أكثر ترابطًا وقوة وابتكارًا.

مع A2A، يمكن للعوامل:

- اكتشاف قدرات بعضها البعض.
- التفاوض على طرق التفاعل (نص، نماذج، وسائط).
- التعاون بأمان في المهام الطويلة الأمد.
- العمل دون كشف حالتها الداخلية أو ذاكرتها أو أدواتها.

## دورة DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

انضم إلى هذه الدورة القصيرة حول [A2A: بروتوكول Agent2Agent](https://goo.gle/dlai-a2a)، التي تم إعدادها بالشراكة مع Google Cloud وIBM Research، ويقدمها [هولت سكينر](https://github.com/holtskinner)، [إيفان نارديني](https://github.com/inardini)، و[ساندي بيسن](https://github.com/sandijean90).

**ما الذي ستتعلمه:**

- **جعل العوامل متوافقة مع A2A:** عرض العوامل المبنية بأطر مثل Google ADK أو LangGraph أو BeeAI كخوادم A2A.
- **ربط العوامل:** إنشاء عملاء A2A من الصفر أو باستخدام تكاملات للاتصال مع عوامل متوافقة مع A2A.
- **تنظيم سير العمل:** بناء سير عمل تسلسلي وهرمي للعوامل المتوافقة مع A2A.
- **أنظمة متعددة العوامل:** بناء نظام رعاية صحية متعدد العوامل باستخدام أطر مختلفة ورؤية كيف يمكّن A2A التعاون بينها.
- **A2A وMCP:** تعلم كيف يكمل A2A بروتوكول MCP من خلال تمكين العوامل من التعاون مع بعضها البعض.

## لماذا A2A؟

مع تزايد انتشار العوامل الذكية، يصبح قدرتها على التشغيل البيني أمرًا حاسمًا لبناء تطبيقات معقدة ومتعددة الوظائف. يهدف بروتوكول A2A إلى:

- **كسر الحواجز:** ربط العوامل عبر أنظمة بيئية مختلفة.
- **تمكين التعاون المعقد:** السماح للعوامل المتخصصة بالعمل معًا على مهام لا يمكن لعامل واحد معالجتها بمفرده.
- **تعزيز المعايير المفتوحة:** دعم نهج مجتمعي لتواصل العوامل، وتشجيع الابتكار واعتماد واسع النطاق.
- **الحفاظ على الغموض:** السماح للعوامل بالتعاون دون الحاجة لمشاركة الذاكرة الداخلية أو المنطق المملوك أو تنفيذ الأدوات المحددة، مما يعزز الأمان ويحمي الملكية الفكرية.

### الميزات الرئيسية

- **اتصال موحد:** JSON-RPC 2.0 عبر HTTP(S).
- **اكتشاف الوكلاء:** من خلال "بطاقات الوكيل" التي تعرض القدرات ومعلومات الاتصال.
- **تفاعل مرن:** يدعم طلب/استجابة متزامنة، البث (SSE)، والإشعارات الفورية غير المتزامنة.
- **تبادل بيانات غني:** يعالج النصوص والملفات وبيانات JSON المهيكلة.
- **جاهز للمؤسسات:** مصمم مع مراعاة الأمان، والمصادقة، وقابلية المراقبة.

## البدء

- 📚 **استكشف الوثائق:** قم بزيارة [موقع وثائق بروتوكول Agent2Agent](https://a2a-protocol.org) لمراجعة شاملة، ومواصفات البروتوكول الكاملة، ودروس تعليمية، وأدلة.
- 📝 **عرض المواصفات:** [مواصفات بروتوكول A2A](https://a2a-protocol.org/latest/specification/)
- استخدم حزم SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) باستخدام maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) باستخدام [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 استخدم [عيناتنا](https://github.com/a2aproject/a2a-samples) لرؤية A2A أثناء العمل

## المساهمة

نرحب بمساهمات المجتمع لتحسين وتطوير بروتوكول A2A!

- **الأسئلة والمناقشات:** انضم إلى [مناقشات GitHub](https://github.com/a2aproject/A2A/discussions).
- **المشكلات والتعليقات:** أبلغ عن المشكلات أو اقترح تحسينات عبر [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **دليل المساهمة:** راجع [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) لمزيد من التفاصيل حول كيفية المساهمة.
- **تعليقات خاصة:** استخدم هذا [نموذج Google](https://goo.gle/a2a-feedback).
- **برنامج الشركاء:** يمكن لعملاء Google Cloud الانضمام إلى برنامج الشركاء عبر هذا [النموذج](https://goo.gle/a2a-partner).

## ما القادم

### تحسينات البروتوكول

- **اكتشاف الوكلاء:**
    - وضع صيغة لإدراج أنظمة التوثيق والبيانات الاعتمادية الاختيارية مباشرةً ضمن `AgentCard`.
- **تعاون الوكلاء:**
    - دراسة طريقة `QuerySkill()` للتحقق الديناميكي من المهارات غير المدعومة أو غير المتوقعة.
- **دورة حياة المهمة وتجربة المستخدم (UX):**
    - دعم التفاوض الديناميكي على تجربة المستخدم _داخل_ المهمة (مثلاً، قيام الوكيل بإضافة صوت/فيديو أثناء المحادثة).
- **طرق العميل ووسائل النقل:**
    - استكشاف توسيع الدعم ليشمل الطرق التي يبدأها العميل (بخلاف إدارة المهام).
    - تحسينات على موثوقية البث وآليات إشعارات الدفع.

## حول

بروتوكول A2A هو مشروع مفتوح المصدر تحت رعاية مؤسسة Linux، بمساهمة من Google. وهو مرخص بموجب [رخصة أباتشي 2.0](LICENSE) ومفتوح لمساهمات المجتمع.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---