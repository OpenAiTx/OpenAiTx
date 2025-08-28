
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# خادم PubChem MCP المحسن لمساعدي الذكاء الاصطناعي

🧪 خادم MCP متقدم وقوي يركز على الخصوصية، يتيح لمساعدي الذكاء الاصطناعي البحث والوصول الذكي إلى معلومات المركبات الكيميائية من PubChem.

يعمل هذا الخادم كجسر قوي بين مساعدي الذكاء الاصطناعي (مثل أولئك في AnythingLLM) وقاعدة بيانات PubChem الضخمة للمواد الكيميائية. يستفيد من بروتوكول Model Context Protocol (MCP) لتمكين نماذج الذكاء الاصطناعي من إجراء عمليات بحث ذكية ومرنة عن المركبات الكيميائية واسترجاع خصائصها التفصيلية برمجياً.

---

## ✨ الميزات الأساسية

هذا ليس مجرد غلاف آخر لـ PubChem. لقد أُعيد بناء هذا الخادم بالكامل ليكون عالي المتانة وذكي جداً:

-   **🧠 بحث احتياطي ذكي**: إذا فشل البحث باسم شائع (مثل "فيتامين د")، يقوم الخادم تلقائياً ببحث أعمق في قاعدة بيانات المواد في PubChem للعثور على المركب الصحيح. هذا يحسن بشكل كبير معدلات النجاح في الاستفسارات الغامضة.
-   **🛡️ معالجة أخطاء قوية وإعادة المحاولة**: تم تصميم الخادم للتعامل مع أخطاء واجهة برمجة التطبيقات بسلاسة. إذا واجه خطأ "الخادم مشغول" من PubChem، سينتظر تلقائياً ويعيد إرسال الطلب، مما يضمن نجاح الاستفسارات حتى تحت الضغط العالي.
-   **🔒 دعم اختياري لوكيل Tor**: لديك سيطرة كاملة على خصوصيتك. يسمح لك ملف `config.ini` بسيط بتوجيه جميع الطلبات عبر شبكة Tor (عبر وكيل SOCKS5 أو HTTP)، مما يمنع كشف عنوان IP الخاص بك. الخادم آمن افتراضياً ولن يقوم **أبداً** بتسريب عنوان IP إذا فشلت اتصال الوكيل.
-   **🔎 بحث لمركب واحد أو متعدد**: يتعامل بسلاسة مع الطلبات لمركب واحد أو عدة مركبات في طلب واحد.
-   **🧪 استرجاع خصائص مفصلة**: الوصول إلى خصائص كيميائية رئيسية مثل الاسم النظامي (IUPAC)، الصيغة الجزيئية، الكتلة الجزيئية، والأهم من ذلك، **الكتلة الأحادية النظير**.

---

---

### 🚀 بدون تثبيت: جربه مباشرة على Smithery.ai

لمن هم جدد على خوادم MCP أو يرغبون فقط في اختبار قدرات هذه الأداة دون أي إعداد محلي، يتوفر إصدار مباشر مستضاف على Smithery.ai. يتيح لك هذا الدردشة مع الوكيل مباشرة من متصفحك.

[**<-- استكشف وكيل PubChem المباشر على Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**كيفية البدء:**

1.  اضغط على الرابط أعلاه للانتقال إلى صفحة الخادم.
2.  سجل الدخول باستخدام حسابك على **GitHub** أو **Google**.
3.  اضغط على زر **"استكشاف القدرات"** لفتح واجهة الدردشة وبدء التجربة!

> **✅ النماذج الموصى بها للحصول على أفضل النتائج**
>
> للحصول على أعلى دقة، خاصة مع الأرقام العشرية الطويلة، نوصي بشدة باستخدام نماذج قوية. النماذج التالية تم اختبارها وتعمل بشكل ممتاز مع هذه الأداة:
>
> *   **Claude 3 Sonnet من Anthropic**
> *   **GPT-4 Turbo من OpenAI** (أو الإصدارات الأحدث مثل GPT-4o)
>
> لقد أكدنا أن كلا النموذجين يعالجان بدقة كاملة الأرقام العشرية التي يعيدها الأداة بدون أي تقريب.

---

## 🚀 البدء السريع والتثبيت

تم تصميم هذا الخادم ليعمل محليًا، إما على سطح المكتب أو ضمن بيئة Docker الخاصة بـ AnythingLLM.

### 1. المتطلبات

يعتمد هذا المشروع على بعض مكتبات بايثون. تأكد من تثبيتها في بيئتك.

أنشئ ملف `requirements.txt` بالمحتوى التالي:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

قم بتثبيتها باستخدام `uv` أو `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(ملاحظة: مكتبة `PySocks` مطلوبة فقط إذا كنت تخطط لاستخدام ميزة وكيل Tor SOCKS5.)*

### 2. الإعداد

يتم إعداد الخادم من خلال ملف `config.ini` الذي يتم **إنشاؤه تلقائيًا** عند تشغيله لأول مرة. سيظهر هذا الملف في نفس الدليل الذي يوجد فيه ملف السكريبت `pubchem_server.py`.

**ملف `config.ini` الافتراضي:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. التكامل مع AnythingLLM

اتبع الوثائق الرسمية لإضافة هذا كخادم MCP مخصص. المفتاح هو توجيه `command` إلى ملف تنفيذ بايثون الخاص بك وملف `pubchem_server.py`.

**مثال لـ AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 أمثلة التنفيذ باستخدام AnythingLLM

فيما يلي بعض الأمثلة حول كيفية التفاعل مع الوكيل. تم إجراء هذه الاختبارات باستخدام AnythingLLM Desktop، مع الاتصال بنماذج لغوية كبيرة مختلفة عبر OpenRouter.

أحد الاكتشافات الحاسمة من اختبارنا هو أهمية النموذج الذي تختاره. نحن **نوصي بشدة بعدم استخدام النماذج الصغيرة أو المحلية** لهذا الغرض. غالباً ما تجد النماذج الصغيرة صعوبة في تحليل البيانات التي يُرجعها الأداة بشكل صحيح، مما يؤدي إلى أخطاء مثل القيم المتخيلة، أو التنسيق غير الصحيح، أو، والأهم من ذلك، **تقريب الأرقام العشرية**، مما يعيق هدف هذه الأداة عالية الدقة.

لضمان سلامة نتائجك، من الأفضل دائماً التحقق من البيانات الخام التي يُرجعها MCP. يمكنك معرفة كيفية القيام بذلك في القسم التالي: [3.2 كيفية التحقق من نتائج MCP في السجلات](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

من ناحية أخرى، أظهرت عدة نماذج أداءً ممتازاً. حققنا نتائج رائعة مع  **Google `Gemini 2.5 Flash lite`**، حيث أظهر دقة ملحوظة في التعامل مع الأرقام العشرية الطويلة وتنسيق جدول Markdown النهائي بشكل صحيح.

يحافظ Google gemini 2.5 flash lite بدون موجه ومع الموجه على الأرقام العشرية المثالية (في المثال تم استخدام درجة حرارة 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

بالنسبة لهذا الغرض المحدد، مفضلتي الشخصية هي **`Gemini 2.5 Flash lite`** بسبب دقته وموثوقيته المستمرة.

### 3.2 كيفية التحقق من نتائج MCP في السجلات

أفضل طريقة للتأكد من أن الوكيل يستقبل البيانات الصحيحة وأن النموذج اللغوي الكبير لا يرتكب أخطاء هي التحقق من ملف سجل التصحيح الذي ينشئه خادم MCP.

تم ضبط هذا الخادم تلقائياً لإنشاء ملف سجل في مجلد فرعي ضمن دليل مشروعك. سيكون الموقع:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

داخل ملف `mcp_debug.log`، ستجد بيانات JSON الدقيقة التي يرسلها الأداة إلى نموذج اللغة الكبير (LLM) *قبل* أن يقوم النموذج بمعالجتها. يمكنك فحص هذا الـ JSON يدويًا للتحقق من أي قيم، خاصة الأرقام العشرية الطويلة من خصائص مثل `monoisotopic_mass`، لضمان أن نموذج اللغة لم يقم بإدخال أي أخطاء تقريب أو هلوسات في إجابته النهائية.

---

## 📊 الاستخدام

بمجرد التكامل، سيستخدم مساعد الذكاء الاصطناعي الخاص بك هذه الأداة تلقائيًا عند سؤاله عن معلومات كيميائية. الأداة الأساسية المتاحة هي `search_compounds_by_name`.

### مثال على الطلب

يعرض هذا الطلب قدرة الأداة على التعامل مع قائمة من المركبات بأنواع أسماء مختلفة واسترجاع خصائص متعددة.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

سيقوم الوكيل باستدعاء أداة `search_compounds_by_name`، والتي ستقوم بالعثور على كل مركب بشكل ذكي، واسترجاع بياناته، وإرجاعها إلى النموذج اللغوي الكبير (LLM) لتنسيقها.

---

## 🛠 أداة MCP المكشوفة

### `search_compounds_by_name`

يبحث عن عدة مركبات بالاسم، واحدة تلو الأخرى، باستخدام استراتيجية بديلة ذكية مع توقفات وإعادة المحاولة لتحقيق أقصى موثوقية.

**المعلمات:**
-   `names` (List[str]): قائمة بأسماء المركبات. مثال: `["Aspirin", "Ibuprofen"]`

**الإرجاع:** قائمة من القواميس، حيث يحتوي كل قاموس إما على معلومات المركب الذي تم العثور عليه أو رسالة خطأ توضح سبب فشل البحث عن هذا المركب تحديدًا.

---

## 🙏 الشكر والتقدير

استُلهم هذا المشروع بشكل كبير وبُني على أساس مشروع [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) الأصلي الذي أنشأه **JackKuo666**.

وعلى الرغم من أن هذا المستودع ليس نسخة متفرعة مباشرة، إلا أن المشروع الأصلي كان نقطة الانطلاق الحاسمة. يعزز هذا الإصدار المفهوم الأصلي مع التركيز على القوة الشديدة، واستراتيجيات البحث الذكية، وخصوصية المستخدم من خلال دمج اختياري مع Tor 🧅.

جزيل الشكر للمؤلف الأصلي على عمله الرائع ومشاركته مع المجتمع.

---

## ⚠️ إخلاء المسؤولية

هذه الأداة مخصصة للأغراض البحثية والتعليمية فقط. يرجى احترام شروط خدمة PubChem واستخدام هذه الأداة بشكل مسؤول.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---