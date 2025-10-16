<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">الصينية المبسطة</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">الصينية التقليدية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">الإندونيسية</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="شعار CORE" />
  </a>

### CORE: طبقة الذاكرة الشخصية لتطبيقات الذكاء الاصطناعي

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="شارة DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>التوثيق</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>ديسكورد</b></a>
</p>
</div>

## 🔥 أبرز الأبحاث

ذاكرة CORE تحقق دقة متوسطة **88.24%** في مجموعة بيانات Locomo عبر جميع مهام الاستدلال، متفوقة بشكل كبير على مزودي الذاكرة الآخرين. لمزيد من المعلومات، راجع هذه [المدونة](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/).

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) الأسئلة ذات القفزة الواحدة تتطلب إجابات بناءً على جلسة واحدة؛ (2) الأسئلة متعددة القفزات تتطلب تركيب معلومات من عدة جلسات مختلفة؛ (3) أسئلة المعرفة المفتوحة يمكن الإجابة عليها بدمج المعلومات المقدمة من المتحدث مع المعرفة الخارجية مثل المعلومات العامة أو حقائق العالم؛ (4) أسئلة الاستدلال الزمني يمكن الإجابة عليها من خلال الاستدلال الزمني والتقاط الإشارات المتعلقة بالوقت داخل المحادثة؛

## نظرة عامة

**المشكلة** 

المطورون يهدرون الوقت في إعادة شرح السياق لأدوات الذكاء الاصطناعي. هل وصلت إلى حدود الرموز في Claude؟ تبدأ من جديد وتفقد كل شيء. تنتقل من ChatGPT/Claude إلى Cursor؟ تشرح السياق الخاص بك مرة أخرى. محادثاتك وقراراتك وأفكارك تختفي بين الجلسات. مع كل أداة ذكاء اصطناعي جديدة، يزداد عبء تبديل السياق.

**الحل** - **CORE** (**محرك الملاحظة والاسترجاع السياقي**)

CORE هو طبقة ذاكرة موحدة ومستمرة مفتوحة المصدر لجميع أدوات الذكاء الاصطناعي الخاصة بك. سياقك ينتقل معك من Cursor إلى Claude إلى ChatGPT إلى Claude Code. رسم بياني معرفي واحد يتذكر من قال ماذا ومتى ولماذا. اتصل مرة واحدة، وتذكر في كل مكان. توقف عن إدارة السياق وابدأ في البناء.

## 🚀 الاستضافة الذاتية لـ CORE
هل تريد تشغيل CORE على بنيتك التحتية الخاصة؟ تمنحك الاستضافة الذاتية سيطرة كاملة على بياناتك ونشر النظام.

**المتطلبات المسبقة**:

- تثبيت Docker (20.10.0+) و Docker Compose (2.20.0+) 
- مفتاح API لـ OpenAI

> **ملاحظة حول النماذج مفتوحة المصدر:** اختبرنا خيارات OSS مثل Ollama ونماذج GPT، لكن استخراج الحقائق وجودة الرسم البياني لم تكن بالمستوى المطلوب. نحن نبحث بنشاط عن خيارات بديلة.

### الإعداد

1. استنسخ المستودع:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. قم بتكوين متغيرات البيئة في `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. بدء الخدمة
```
docker-compose up -d
```

بمجرد النشر، يمكنك تكوين مزودي الذكاء الاصطناعي الخاصين بك (OpenAI، Anthropic) والبدء في بناء رسمك البياني للذاكرة.

👉 [عرض دليل الاستضافة الذاتية الكامل](https://docs.heysol.ai/self-hosting/docker)

ملاحظة: جربنا نماذج المصدر المفتوح مثل Ollama أو GPT OSS لكن إنتاج الحقائق لم يكن جيدًا، ما زلنا نحاول معرفة كيفية تحسين ذلك وسندعم نماذج المصدر المفتوح لاحقًا.

## 🚀 سحابة CORE
**ابنِ رسمك البياني الموحد للذاكرة في 5 دقائق:**

لا ترغب في إدارة البنية التحتية؟ تتيح لك سحابة CORE بناء نظام ذاكرتك الشخصي فورًا - بدون إعداد، بدون خوادم، فقط ذاكرة تعمل.

1. **سجّل حسابك** في [core.heysol.ai](https://core.heysol.ai) وأنشئ حسابك
2. **تصوّر رسمك البياني للذاكرة** وشاهد كيف يشكل CORE تلقائيًا الروابط بين الحقائق
3. **جربها** - اسأل "ماذا تعرف عني؟" في قسم المحادثة
4. اتصل بأدواتك:
   - [Claude](https://docs.heysol.ai/providers/claude) و [Cursor](https://docs.heysol.ai/providers/cursor) - البرمجة مع السياق
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) و [Codex CLI](https://docs.heysol.ai/providers/codex) - البرمجة عبر الطرفية مع الذاكرة
   - [إضافة امتداد المتصفح](https://docs.heysol.ai/providers/browser-extension) - جلب ذاكرتك لأي موقع إلكتروني
   - [Linear](https://docs.heysol.ai/integrations/linear)، [Github](https://docs.heysol.ai/integrations/github) - إضافة سياق المشروع تلقائيًا

## 🧩 الميزات الرئيسية

### 🧠 **ذاكرة موحدة وقابلة للنقل**: 
أضف واسترجع ذاكرتك عبر **Cursor، Windsurf، Claude Desktop، Claude Code، Gemini CLI، Kiro من AWS، VS Code، و Roo Code** عبر MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **رسم بياني معرفي زمني ومجسد**: 

تذكّر القصة وراء كل حقيقة—تتبع من قال ماذا، ومتى، ولماذا مع علاقات غنية وإثبات كامل، وليس مجرد تخزين مسطح

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **امتداد المتصفح**: 

احفظ المحادثات والمحتوى من ChatGPT، Grok، Gemini، تويتر، يوتيوب، منشورات المدونات، وأي صفحة ويب مباشرة في ذاكرة CORE الخاصة بك.

**كيفية استخدام الإضافة**
1. [حمّل الإضافة](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) من متجر كروم الإلكتروني.
2. سجّل الدخول إلى [لوحة تحكم CORE](https://core.heysol.ai)
   - انتقل إلى الإعدادات (أسفل اليسار)
   - اذهب إلى مفتاح API → أنشئ مفتاح جديد → سمّه "extension."
3. افتح الإضافة، والصق مفتاح API الخاص بك، ثم احفظ.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **الدردشة مع الذاكرة**: 
اطرح أسئلة مثل "ما هي تفضيلات الكتابة الخاصة بي؟" للحصول على رؤى فورية من معرفتك المتصلة

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **المزامنة التلقائية من التطبيقات**:

التقاط السياق ذي الصلة تلقائياً من Linear وSlack وNotion وGitHub والتطبيقات الأخرى المتصلة في ذاكرة CORE

📖 **[عرض جميع عمليات التكامل](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - قائمة كاملة بالخدمات المدعومة وميزاتها

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **محور تكامل MCP**: 

قم بربط Linear وSlack وGitHub وNotion مرة واحدة بـ CORE—ثم استخدم جميع أدواتهم في Claude أو Cursor أو أي عميل MCP من خلال رابط واحد فقط


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## كيف ينشئ CORE الذاكرة

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

لدى خط أنابيب الإدخال في CORE أربع مراحل مصممة لالتقاط السياق المتطور:

1. **التطبيع**: يربط المعلومات الجديدة بالسياق الحديث، ويقسم المستندات الطويلة إلى أجزاء مترابطة مع الحفاظ على المراجع المتبادلة، ويوحد المصطلحات بحيث عندما يقوم CORE باستخلاص المعرفة، يكون الإدخال نظيفًا ومؤطرًا بالسياق بدلاً من نص فوضوي.
2. **الاستخلاص**: يستخرج المعنى من النص المطبع عن طريق تحديد الكيانات (أشخاص، أدوات، مشاريع، مفاهيم)، وتحويلها إلى بيانات مع سياق ومصدر وزمن، ورسم العلاقات بينها. على سبيل المثال، "كتبنا CORE باستخدام Next.js" تصبح: كيانات (CORE، Next.js)، بيان (تم تطوير CORE باستخدام Next.js)، وعلاقة (تم تطويره باستخدام).
3. **التسوية**: يكتشف التناقضات، ويتتبع تطور التفضيلات، ويحافظ على وجهات النظر المتعددة مع إثبات المصدر بدلاً من استبدالها بحيث تعكس الذاكرة رحلتك الكاملة وليس مجرد اللقطة الأخيرة فقط.
4. **دمج الرسم البياني**: يربط الكيانات والبيانات والحلقات في رسم بياني معرفي زمني يصل الحقائق بسياقها وتاريخها، محولاً البيانات المنعزلة إلى شبكة معرفية حية يمكن للوكلاء استخدامها فعليًا.

النتيجة: بدلاً من قاعدة بيانات مسطحة، يمنحك CORE ذاكرة تنمو وتتغير معك - مع الحفاظ على السياق والتطور والملكية بحيث يمكن للوكلاء استخدامها فعليًا.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## كيف يسترجع CORE من الذاكرة

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

عندما تسأل CORE سؤالًا، فهو لا يبحث فقط عن النص - بل يغوص في رسمك البياني المعرفي بالكامل ليجد أكثر الإجابات فائدة.

1. **البحث**: يبحث CORE في الذاكرة من عدة زوايا في نفس الوقت - بحث بالكلمات المفتاحية للتطابقات الدقيقة، وبحث دلالي للأفكار ذات الصلة حتى لو صيغت بشكل مختلف، وتجوال في الرسم البياني لمتابعة الروابط بين المفاهيم المتصلة.
2. **إعادة الترتيب**: يتم إعادة ترتيب النتائج المسترجعة لتسليط الضوء على الأكثر صلة وتنوعًا، لضمان أنك لا ترى فقط التطابقات الواضحة بل أيضًا الروابط العميقة.
3. **التصفية**: يطبق CORE مرشحات ذكية بناءً على الزمن والموثوقية وقوة العلاقة، بحيث تظهر فقط المعرفة الأكثر أهمية.
4. **الإخراج**: تحصل على الحقائق (بيانات واضحة) والحلقات (السياق الأصلي الذي نشأت منه)، بحيث يكون الاسترجاع دائمًا مرتبطًا بالسياق والزمن والقصة.

النتيجة: CORE لا يسترجع الحقائق فقط - بل يسترجعها في السياق والزمن والقصة الصحيحة، بحيث يمكن للوكلاء الرد كما تتذكرها أنت.

## التوثيق

استكشف توثيقاتنا لتحقيق أقصى استفادة من CORE

- [المفاهيم الأساسية](https://docs.heysol.ai/concepts/memory_graph)
- [الاستضافة الذاتية](https://docs.heysol.ai/self-hosting/overview)
- [ربط Core MCP مع Claude](https://docs.heysol.ai/providers/claude)
- [ربط Core MCP مع Cursor](https://docs.heysol.ai/providers/cursor)
- [ربط Core MCP مع Claude Code](https://docs.heysol.ai/providers/claude-code)
- [ربط Core MCP مع Codex](https://docs.heysol.ai/providers/codex) 

- [المفاهيم الأساسية](https://docs.heysol.ai/overview)
- [مرجع API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 الأمان

يأخذ CORE الأمان على محمل الجد. نحن نطبق ممارسات أمان معيارية لحماية بياناتك:

- **تشفير البيانات**: جميع البيانات أثناء النقل (TLS 1.3) وعند التخزين (AES-256)
- **المصادقة**: OAuth 2.0 والمصادقة عبر الرابط السحري
- **التحكم في الوصول**: العزل حسب مساحة العمل والصلاحيات حسب الدور
- **الإبلاغ عن الثغرات**: يرجى الإبلاغ عن مشكلات الأمان إلى harshith@poozle.dev

لمعلومات أمنية مفصلة، راجع [سياسة الأمان](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 الدعم

هل لديك أسئلة أو ملاحظات؟ نحن هنا لمساعدتك:

- ديسكورد: [انضم إلى قناة دعم core](https://discord.gg/YGUZcvDjUa)
- التوثيق: [docs.heysol.ai](https://docs.heysol.ai)
- البريد الإلكتروني: manik@poozle.dev

## إرشادات الاستخدام

**يُخزن:**

- سجل المحادثات
- تفضيلات المستخدم
- سياق المهام
- مواد مرجعية

**لا يُخزن:**

- البيانات الحساسة (المعلومات الشخصية)
- بيانات الاعتماد
- سجلات النظام
- البيانات المؤقتة

## 👥 المساهمون

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---