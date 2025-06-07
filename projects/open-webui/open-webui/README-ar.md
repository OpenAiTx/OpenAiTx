# واجهة الويب المفتوحة Open WebUI 👋

![نجوم GitHub](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![تفرعات GitHub](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![مشاهدو GitHub](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![حجم مستودع GitHub](https://img.shields.io/github/repo-size/open-webui/open-webui)
![عدد لغات GitHub](https://img.shields.io/github/languages/count/open-webui/open-webui)
![أعلى لغة في GitHub](https://img.shields.io/github/languages/top/open-webui/open-webui)
![آخر التزام في GitHub](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![ديسكورد](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**واجهة الويب المفتوحة (Open WebUI) هي منصة ذكاء اصطناعي ذاتية الاستضافة [قابلة للتوسعة](https://docs.openwebui.com/features/plugin/)، غنية بالميزات وسهلة الاستخدام صُممت للعمل دون اتصال بالإنترنت بالكامل.** تدعم العديد من مشغلات النماذج اللغوية مثل **Ollama** وواجهات برمجة التطبيقات المتوافقة مع **OpenAI**، مع محرك استدلال مدمج لـ RAG، مما يجعلها **حلًا قويًا لنشر الذكاء الاصطناعي**.

![عرض واجهة Open WebUI](./demo.gif)

> [!TIP]  
> **هل تبحث عن [خطة المؤسسات](https://docs.openwebui.com/enterprise)؟** – **[تحدث مع فريق المبيعات لدينا اليوم!](mailto:sales@openwebui.com)**
>
> احصل على **قدرات معززة**، بما في ذلك **تصميم العلامة التجارية والتخصيص**، دعم **اتفاقية مستوى الخدمة (SLA)**، إصدارات **الدعم طويل الأمد (LTS)**، وأكثر من ذلك!

لمزيد من المعلومات، تأكد من زيارة [وثائق واجهة الويب المفتوحة](https://docs.openwebui.com/).

## الميزات الرئيسية لواجهة Open WebUI ⭐

- 🚀 **إعداد سهل وسريع**: تثبيت سلس باستخدام Docker أو Kubernetes (kubectl، kustomize أو helm) لتجربة خالية من المتاعب، مع دعم صور `:ollama` و`:cuda`.

- 🤝 **تكامل API لـ Ollama/OpenAI**: دمج واجهات برمجة التطبيقات المتوافقة مع OpenAI بسهولة لإجراء محادثات متنوعة إلى جانب نماذج Ollama. قم بتخصيص عنوان URL الخاص بـ OpenAI API للربط مع **LMStudio، GroqCloud، Mistral، OpenRouter والمزيد**.

- 🛡️ **أذونات دقيقة ومجموعات مستخدمين**: من خلال تمكين المسؤولين من إنشاء أدوار وأذونات مستخدمين مفصلة، نضمن بيئة استخدام آمنة. هذا التفصيل يعزز الأمان ويسمح بتجارب مستخدمين مخصصة ويعزز الشعور بالملكية والمسؤولية بين المستخدمين.

- 📱 **تصميم متجاوب**: استمتع بتجربة سلسة عبر أجهزة الحاسوب المكتبي والمحمول والهواتف الذكية.

- 📱 **تطبيق ويب تدريجي (PWA) للهواتف**: استمتع بتجربة شبيهة بالتطبيقات الأصلية على جهازك المحمول مع PWA، مما يوفر وصولًا دون اتصال عبر localhost وواجهة مستخدم متكاملة.

- ✒️🔢 **دعم كامل لـ Markdown وLaTeX**: عزز تجربتك مع النماذج اللغوية من خلال دعم شامل لـ Markdown وLaTeX لتفاعل أكثر ثراءً.

- 🎤📹 **مكالمات صوتية/مرئية بدون استخدام اليدين**: تجربة تواصل متكاملة مع ميزات مكالمات صوتية ومرئية مدمجة، مما يسمح ببيئة محادثة ديناميكية وتفاعلية.

- 🛠️ **منشئ النماذج**: إنشاء نماذج Ollama بسهولة من خلال واجهة الويب. أنشئ وأضف شخصيات/وكلاء مخصصين، خصص عناصر المحادثة، واستورد النماذج بسهولة عبر دمج [مجتمع Open WebUI](https://openwebui.com/).

- 🐍 **أداة استدعاء الدوال بلغة بايثون أصلية**: عزز نماذجك اللغوية بدعم محرر أكواد مدمج في مساحة الأدوات. أضف دوال بايثون الخاصة بك (BYOF) بسهولة لتحقيق تكامل سلس مع النماذج.

- 📚 **تكامل RAG المحلي**: استكشف مستقبل المحادثات مع دعم متقدم لـ RAG (توليد معزز بالاسترجاع). يدمج هذا التفاعل مع الوثائق مباشرة في تجربتك. يمكنك تحميل المستندات للمحادثة أو إضافة ملفات إلى مكتبتك والوصول إليها عبر أمر `#` قبل الاستعلام.

- 🔍 **بحث ويب لـ RAG**: نفذ عمليات بحث عبر الإنترنت باستخدام مزودين مثل `SearXNG`، `Google PSE`، `Brave Search`، `serpstack`، `serper`، `Serply`، `DuckDuckGo`، `TavilySearch`، `SearchApi` و`Bing` وحقن النتائج مباشرة في تجربتك.

- 🌐 **إمكانية التصفح عبر الإنترنت**: دمج المواقع الإلكترونية بسهولة في محادثاتك باستخدام أمر `#` متبوعًا بعنوان URL. يتيح ذلك إدراج محتوى الويب في محادثاتك، مما يعزز ثراء وتنوع التفاعل.

- 🎨 **تكامل توليد الصور**: دمج إمكانيات توليد الصور بسهولة باستخدام خيارات مثل AUTOMATIC1111 API أو ComfyUI (محليًا)، وDALL-E من OpenAI (خارجيًا)، لإثراء تجربتك بمحتوى بصري ديناميكي.

- ⚙️ **محادثات متعددة النماذج**: تفاعل بسهولة مع نماذج متعددة في الوقت نفسه، مستفيدًا من نقاط قوتها المختلفة للحصول على أفضل النتائج.

- 🔐 **التحكم في الوصول بناءً على الأدوار (RBAC)**: ضمان وصول آمن مع أذونات مقيدة؛ فقط الأشخاص المخولون يمكنهم الوصول إلى Ollama، وحقوق إنشاء/سحب النماذج محجوزة للمسؤولين.

- 🌐🌍 **دعم متعدد اللغات**: استمتع بواجهة Open WebUI بلغتك المفضلة مع دعم التدويل (i18n). انضم إلينا لتوسيع اللغات المدعومة! نحن نبحث عن مساهمين!

- 🧩 **خطوط المعالجة ودعم الإضافات**: دمج المنطق المخصص ومكتبات بايثون بسهولة في Open WebUI باستخدام [إطار خطوط المعالجة (Pipelines)](https://github.com/open-webui/pipelines). أطلق مثيل Pipelines، اضبط عنوان OpenAI URL على عنوان Pipelines، واكتشف إمكانيات لا محدودة. [أمثلة](https://github.com/open-webui/pipelines/tree/main/examples) تشمل **استدعاء الدوال**، **تحديد معدل الاستخدام** للتحكم في الوصول، **مراقبة الاستخدام** بأدوات مثل Langfuse، **الترجمة الحية بـ LibreTranslate** لدعم متعدد اللغات، **تصفية الرسائل السامة** والمزيد.

- 🌟 **تحديثات مستمرة**: نحن ملتزمون بتحسين Open WebUI من خلال تحديثات منتظمة وإصلاحات وميزات جديدة.

تريد معرفة المزيد عن ميزات Open WebUI؟ تصفح [وثائق Open WebUI](https://docs.openwebui.com/features) للاطلاع على نظرة شاملة!

## الرعاة 🙌

#### زمرد

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • هل لديك واجهة خلفية حتى الآن؟<br>جرّب <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • الطرفية الذكية للمطورين
    </td>
  </tr>
</table>

---

نحن ممتنون جدًا لدعم رعاتنا السخي. تساهم مساهماتهم في صيانة وتحسين مشروعنا، وتضمن قدرتنا على تقديم عمل عالي الجودة لمجتمعنا. شكرًا لكم!

## كيفية التثبيت 🚀

### التثبيت عبر pip في بايثون 🐍

يمكن تثبيت Open WebUI باستخدام pip، مدير حزم بايثون. قبل البدء، تأكد من استخدام **بايثون 3.11** لتجنب مشاكل التوافق.

1. **تثبيت Open WebUI**:
   افتح الطرفية لديك ونفذ الأمر التالي لتثبيت Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **تشغيل Open WebUI**:
   بعد التثبيت، يمكنك تشغيل Open WebUI بتنفيذ الأمر التالي:

   ```bash
   open-webui serve
   ```

سيتم بدء خادم Open WebUI، ويمكنك الوصول إليه عبر [http://localhost:8080](http://localhost:8080)

### بدء سريع مع Docker 🐳

> [!NOTE]  
> يرجى ملاحظة أنه في بعض بيئات Docker، قد تكون هناك حاجة لتكوينات إضافية. إذا واجهت أي مشاكل في الاتصال، فدليلنا المفصل في [وثائق Open WebUI](https://docs.openwebui.com/) جاهز لمساعدتك.

> [!WARNING]
> عند استخدام Docker لتثبيت Open WebUI، تأكد من تضمين `-v open-webui:/app/backend/data` في الأمر. هذه الخطوة ضرورية لضمان تثبيت قاعدة البيانات بشكل صحيح ومنع فقدان البيانات.

> [!TIP]  
> إذا كنت ترغب في استخدام Open WebUI مع Ollama مدمج أو تسريع CUDA، نوصي باستخدام صورنا الرسمية الموسومة بـ `:cuda` أو `:ollama`. لتمكين CUDA، يجب عليك تثبيت [مجموعة أدوات حاوية Nvidia CUDA](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) على نظام Linux/WSL لديك.

### التثبيت مع التكوين الافتراضي

- **إذا كان Ollama على جهازك**، استخدم هذا الأمر:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **إذا كان Ollama على خادم آخر**، استخدم هذا الأمر:

  للاتصال بـ Ollama على خادم آخر، غيّر `OLLAMA_BASE_URL` إلى عنوان URL الخاص بالخادم:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **لتشغيل Open WebUI مع دعم GPU من Nvidia**، استخدم هذا الأمر:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### التثبيت لاستخدام OpenAI API فقط

- **إذا كنت تستخدم فقط OpenAI API**، استخدم هذا الأمر:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### تثبيت Open WebUI مع دعم Ollama مدمج

تستخدم هذه الطريقة صورة حاوية واحدة تجمع بين Open WebUI وOllama، مما يسمح بإعداد مبسط عبر أمر واحد. اختر الأمر المناسب حسب إعدادات جهازك:

- **مع دعم GPU**:
  استعمل موارد GPU بتنفيذ الأمر التالي:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **للـ CPU فقط**:
  إذا كنت لا تستخدم GPU، استخدم هذا الأمر بدلاً منه:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

كلا الأمرين يوفران تثبيتًا مدمجًا وسهلًا لكل من Open WebUI وOllama، لضمان بدء التشغيل بسرعة.

بعد التثبيت، يمكنك الوصول إلى Open WebUI عبر [http://localhost:3000](http://localhost:3000). استمتع! 😄

### طرق تثبيت أخرى

نحن نوفر طرق تثبيت بديلة متنوعة، بما في ذلك التثبيت المحلي بدون Docker، Docker Compose، Kustomize وHelm. زر [وثائق Open WebUI](https://docs.openwebui.com/getting-started/) أو انضم إلى [مجتمع Discord](https://discord.gg/5rJgQTnV4s) للحصول على إرشادات شاملة.

### استكشاف المشكلات وإصلاحها

هل تواجه مشاكل في الاتصال؟ [وثائق Open WebUI](https://docs.openwebui.com/troubleshooting/) توفر لك الحلول. لمزيد من الدعم والانضمام إلى مجتمعنا النشط، زر [ديسكورد Open WebUI](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: خطأ في الاتصال بالخادم

إذا واجهت مشاكل في الاتصال، غالبًا ما يكون السبب هو عدم قدرة حاوية WebUI Docker على الوصول إلى خادم Ollama على 127.0.0.1:11434 (host.docker.internal:11434) من داخل الحاوية. استخدم خيار `--network=host` في أمر Docker لحل المشكلة. لاحظ أن المنفذ سيتغير من 3000 إلى 8080، مما يؤدي إلى الرابط: `http://localhost:8080`.

**مثال لأمر Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### تحديث تثبيت Docker الخاص بك

إذا كنت ترغب في تحديث تثبيت Docker المحلي إلى أحدث إصدار، يمكنك فعل ذلك باستخدام [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

في الجزء الأخير من الأمر، استبدل `open-webui` باسم الحاوية الخاص بك إذا كان مختلفًا.

راجع دليل التحديث المتوفر في [وثائق Open WebUI](https://docs.openwebui.com/getting-started/updating).

### استخدام فرع التطوير Dev 🌙

> [!WARNING]
> يحتوي فرع `:dev` على أحدث الميزات غير المستقرة والتغييرات. استخدمه على مسؤوليتك الخاصة فقد يحتوي على أخطاء أو ميزات غير مكتملة.

إذا كنت ترغب في تجربة أحدث الميزات ولا تمانع في بعض عدم الاستقرار، يمكنك استخدام الوسم `:dev` كما يلي:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### الوضع غير المتصل بالإنترنت

إذا كنت تشغل Open WebUI في بيئة غير متصلة، يمكنك تعيين متغير البيئة `HF_HUB_OFFLINE` إلى `1` لمنع محاولات تنزيل النماذج من الإنترنت.

```bash
export HF_HUB_OFFLINE=1
```

## ماذا بعد؟ 🌟

اكتشف الميزات القادمة في خارطة الطريق في [وثائق Open WebUI](https://docs.openwebui.com/roadmap/).

## الرخصة 📜

هذا المشروع مرخص بموجب [رخصة Open WebUI](LICENSE)، وهي نسخة معدلة من رخصة BSD-3-Clause. تحصل على نفس الحقوق مثل رخصة BSD-3 الكلاسيكية: يمكنك استخدام البرنامج وتعديله وتوزيعه، بما في ذلك في المنتجات التجارية والمغلقة المصدر، مع قيود قليلة. الشرط الإضافي الوحيد هو الحفاظ على العلامة التجارية "Open WebUI" كما هو موضح في ملف الرخصة. للمزيد من التفاصيل، راجع [ملف الرخصة](LICENSE). 📄

## الدعم 💬

إذا كان لديك أي أسئلة أو اقتراحات أو تحتاج إلى مساعدة، يرجى فتح تذكرة أو الانضمام إلى
[مجتمع Discord لـ Open WebUI](https://discord.gg/5rJgQTnV4s) للتواصل معنا! 🤝

## تاريخ النجوم

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

تم الإنشاء بواسطة [Timothy Jaeryang Baek](https://github.com/tjbck) - دعونا نجعل Open WebUI أفضل معًا! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---