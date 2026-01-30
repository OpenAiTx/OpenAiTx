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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="شعار بروتوكول Agent2Agent" width="100">
    <h1>بروتوكول Agent2Agent (A2A)</h1>
  </div>
</div>

**بروتوكول مفتوح يمكّن التواصل والتشغيل البيني بين التطبيقات العاملة كوكلاء مغلقة المصدر.**

يعالج بروتوكول Agent2Agent (A2A) تحديًا حاسمًا في مشهد الذكاء الاصطناعي: تمكين وكلاء الذكاء الاصطناعي التوليدي، المبنية على أطر عمل متنوعة من قبل شركات مختلفة وتعمل على خوادم منفصلة، من التواصل والتعاون بفعالية - كوكلاء وليس فقط كأدوات. يهدف A2A إلى توفير لغة مشتركة للوكلاء، لتعزيز نظام بيئي أكثر ترابطًا وقوة وابتكارًا للذكاء الاصطناعي.

مع A2A، يمكن للوكلاء:

- اكتشاف قدرات بعضهم البعض.
- التفاوض حول أنماط التفاعل (نص، نماذج، وسائط).
- التعاون بأمان في المهام طويلة الأمد.
- العمل دون كشف حالتهم الداخلية أو ذاكرتهم أو أدواتهم.

## مقدمة فيديو عن A2A

[![فيديو مقدمة عن A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## لماذا A2A؟

مع تزايد انتشار وكلاء الذكاء الاصطناعي، أصبح قدرتهم على التشغيل البيني أمرًا بالغ الأهمية لبناء تطبيقات معقدة ومتعددة الوظائف. يهدف A2A إلى:

- **كسر العزلة:** ربط الوكلاء عبر أنظمة بيئية مختلفة.
- **تمكين التعاون المعقد:** السماح للوكلاء المتخصصين بالعمل معًا على مهام لا يمكن لوكيل واحد التعامل معها بمفرده.
- **تعزيز المعايير المفتوحة:** دعم نهج مجتمعي لتواصل الوكلاء، وتشجيع الابتكار والتبني الواسع.
- **الحفاظ على الغموض:** تمكين الوكلاء من التعاون دون الحاجة لمشاركة الذاكرة الداخلية أو المنطق المملوك أو تفاصيل الأدوات المحددة، مما يعزز الأمان ويحمي الملكية الفكرية.

### الميزات الرئيسية

- **تواصل موحد:** JSON-RPC 2.0 عبر HTTP(S).
- **اكتشاف الوكلاء:** من خلال "بطاقات الوكيل" التي توضح القدرات ومعلومات الاتصال.
- **تفاعل مرن:** يدعم الطلب/الاستجابة المتزامنة، البث (SSE)، والإشعارات الفورية غير المتزامنة.
- **تبادل غني للبيانات:** يدعم النصوص والملفات وبيانات JSON المنظمة.
- **جاهز للمؤسسات:** مصمم مع مراعاة الأمان والمصادقة وقابلية الرصد.

## البدء السريع

- 📚 **استكشف الوثائق:** قم بزيارة [موقع وثائق بروتوكول Agent2Agent](https://a2a-protocol.org) للاطلاع على نظرة عامة كاملة، ومواصفات البروتوكول الكاملة، والدروس التعليمية، والأدلة الإرشادية.
- 📝 **عرض المواصفات:** [مواصفات بروتوكول A2A](https://a2a-protocol.org/latest/specification/)
- استخدم حزم SDK:
    - [🐍 مكتبة A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ مكتبة A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 مكتبة A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ مكتبة A2A Java SDK](https://github.com/a2aproject/a2a-java) باستخدام maven
    - [🔷 مكتبة A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) باستخدام [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 استخدم [الأمثلة](https://github.com/a2aproject/a2a-samples) لرؤية A2A أثناء العمل

## المساهمة

نرحب بمساهمات المجتمع لتعزيز وتطوير بروتوكول A2A!

- **الأسئلة والنقاشات:** انضم إلى [النقاشات على GitHub](https://github.com/a2aproject/A2A/discussions).
- **المشكلات والتعليقات:** أبلغ عن المشكلات أو اقترح تحسينات عبر [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **دليل المساهمة:** راجع [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) لمعرفة كيفية المساهمة.
- **ملاحظات خاصة:** استخدم هذا [نموذج Google](https://goo.gle/a2a-feedback).
- **برنامج الشركاء:** يمكن لعملاء Google Cloud الانضمام إلى برنامج الشركاء عبر هذا [النموذج](https://goo.gle/a2a-partner).

## ما التالي

### تحسينات البروتوكول

- **اكتشاف العملاء:**
    - توثيق تضمين أنظمة الترخيص والبيانات الاعتمادية الاختيارية مباشرة ضمن `AgentCard`.
- **تعاون العملاء:**
    - دراسة طريقة `QuerySkill()` للتحقق ديناميكياً من المهارات غير المدعومة أو غير المتوقعة.
- **دورة حياة المهمة وتجربة المستخدم:**
    - دعم التفاوض الديناميكي لتجربة المستخدم _داخل_ المهمة (مثلاً: إضافة العميل للصوت/الفيديو أثناء المحادثة).
- **طرق العميل ووسائل النقل:**
    - دراسة توسيع الدعم للطرق التي يبدأها العميل (خارج إدارة المهام).
    - تحسينات على موثوقية البث وآليات الإشعارات الفورية.

## حول

بروتوكول A2A هو مشروع مفتوح المصدر تحت رعاية مؤسسة Linux، ساهمت فيه Google. وهو مرخص بموجب [رخصة أباتشي 2.0](LICENSE) ومفتوح لمساهمات المجتمع.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---