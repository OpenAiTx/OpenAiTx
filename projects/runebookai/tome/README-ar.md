# Tome - كتاب تعويذات الذكاء الاصطناعي السحري

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>تطبيق سطح مكتب سحري يضع قوة نماذج اللغة الكبيرة (LLMs) وMCP بين يدي الجميع</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="انضم إلينا على ديسكورد" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="الرخصة: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="إصدار GitHub" /></a>
</p>

<p align="center">
    🔮 حمّل تطبيق Tome لسطح المكتب: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">ويندوز</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">ماك</a>
</p>

# Tome

Tome هو تطبيق سطح مكتب يتيح **لأي شخص** تسخير سحر نماذج اللغة الكبيرة (LLMs) وMCP. قم بتنزيل Tome، وصل أي نموذج LLM محلي أو عن بُعد واربطه بآلاف خوادم MCP لإنشاء كتاب تعويذاتك السحري المدعوم بالذكاء الاصطناعي.

🫥 تريد أن يكون كل شيء محليًا 100% وخاصًا 100%؟ استخدم Ollama وQwen3 مع خوادم MCP المحلية فقط لتلقي التعويذات في عالمك الخاص. ⚡ تريد أحدث النماذج السحابية مع خوادم MCP عن بُعد؟ يمكنك ذلك أيضًا. الخيار لك بالكامل!

🏗️ هذه نسخة تقنية أولية لذا يرجى العلم بأن الأمور قد تكون غير مكتملة. [انضم إلينا على ديسكورد](https://discord.gg/9CH6us29YA) لمشاركة النصائح والحيل والمشاكل التي تواجهك. ضع نجمة على هذا المستودع للبقاء على اطلاع بالتحديثات وميزات الإصدارات!

## 🪄 الميزات

- 🧙 **تجربة سهلة ومبسطة للمبتدئين**
  - فقط قم بتنزيل وتثبيت Tome ووصّل نموذج اللغة الذي تريده
  - لا حاجة للتعامل مع JSON أو Docker أو بايثون أو نود
- 🤖 **دعم نماذج الذكاء الاصطناعي**
  - **عن بُعد**: Google Gemini، OpenAI، أي نقطة نهاية متوافقة مع OpenAI API
  - **محلي**: Ollama، LM Studio، Cortex، أي نقطة نهاية متوافقة مع OpenAI API
- 🔮 **دعم متقدم لـ MCP**
  - واجهة لتثبيت وإزالة وتشغيل/إيقاف خوادم MCP
  - دعم خوادم MCP التي تعمل بـ npm وuvx وnode وpython مباشرة من الصندوق
- 🏪 **تكامل مع سجل [Smithery.ai](https://smithery.ai)**
  - آلاف خوادم MCP متاحة عبر التثبيت بنقرة واحدة
- ✏️ **تخصيص نوافذ السياق ودرجة الحرارة**
- 🧰 **دعم أصلي لاستدعاءات الأدوات ونماذج التفكير**
  - تحسينات في الواجهة توضح استدعاءات الأدوات ورسائل التفكير بشكل واضح

## العرض التوضيحي

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# البدء

## المتطلبات

- ماك أو ويندوز (لينكس قريبًا!)
- مزود LLM من اختيارك: [Ollama](https://ollama.com/) أو [مفتاح Gemini API](https://aistudio.google.com/app/apikey) سهل/مجاني
- [حمّل أحدث إصدار من Tome](https://github.com/runebookai/tome/releases)

## البدء السريع

1. ثبّت [Tome](https://github.com/runebookai/tome/releases)
2. وصّل مزود LLM المفضل لديك - OpenAI وOllama وGemini معدة مسبقًا، ويمكنك أيضًا إضافة مزودين مثل LM Studio باستخدام http://localhost:1234/v1 كعنوان URL
3. افتح علامة التبويب MCP في Tome وركّب أول [خادم MCP](https://github.com/modelcontextprotocol/servers) (خادم Fetch سهل للبداية، فقط الصق `uvx mcp-server-fetch` في حقل الخادم).
4. تحدث مع نموذجك المدعوم بـ MCP! اطلب منه جلب الخبر الأعلى على Hacker News.

# الرؤية

نريد أن نجعل النماذج المحلية (LLMs) وMCP متاحة للجميع. نحن نبني أداة تتيح لك الإبداع مع LLMs، بغض النظر
عما إذا كنت مهندسًا أو هاويًا أو مبتكرًا أو أي شخص بينهما.

## المبادئ الأساسية

- **Tome محلي أولاً:** أنت تتحكم في مكان بياناتك.
- **Tome للجميع:** لا ينبغي أن تضطر لإدارة لغات البرمجة أو مديري الحزم أو ملفات إعدادات json.

## ماذا بعد

لقد تلقينا الكثير من التعليقات الرائعة في الأسابيع القليلة الماضية منذ إصدار Tome لكن لدينا خطط كبيرة للمستقبل. نريد أن نحرر LLMs من صندوق الدردشة، وهناك العديد من الميزات قادمة لمساعدتكم على ذلك.

- المهام المجدولة: يجب أن تقوم LLMs بأشياء مفيدة حتى عندما لا تكون أمام الكمبيوتر.
- التكاملات الأصلية: خوادم MCP وسيلة رائعة للوصول إلى الأدوات والمعلومات، لكننا نرغب في إضافة تكاملات أقوى للتفاعل مع LLMs بطرق فريدة.
- منشئ التطبيقات: نعتقد على المدى الطويل أن أفضل التجارب لن تكون في واجهة الدردشة. لدينا خطط لإضافة أدوات إضافية تتيح لك إنشاء تطبيقات وسير عمل قوية.
- ??? أخبرنا بما ترغب أن تراه! انضم إلى مجتمعنا عبر الروابط أدناه، يسعدنا الاستماع إليك.

# المجتمع

[ديسكورد](https://discord.gg/9CH6us29YA) [مدونة](https://blog.runebook.ai) [بلوسكاي](https://bsky.app/profile/gettome.app) [تويتر](https://twitter.com/get_tome)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---