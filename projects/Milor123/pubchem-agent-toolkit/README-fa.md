
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# سرور پیشرفته PubChem MCP برای دستیارهای هوش مصنوعی

🧪 یک سرور MCP پیشرفته، مقاوم و متمرکز بر حفظ حریم خصوصی که به دستیارهای هوش مصنوعی امکان جستجو و دسترسی هوشمندانه به اطلاعات ترکیبات شیمیایی از PubChem را می‌دهد.

این سرور PubChem MCP به عنوان پلی قدرتمند بین دستیارهای هوش مصنوعی (مانند موارد موجود در AnythingLLM) و پایگاه داده عظیم PubChem عمل می‌کند. این سرور با استفاده از Model Context Protocol (MCP) به مدل‌های هوش مصنوعی اجازه می‌دهد تا جستجوهای هوشمند و مقاوم برای ترکیبات شیمیایی انجام دهند و خواص دقیق آن‌ها را به صورت برنامه‌نویسی شده دریافت کنند.

---

## ✨ ویژگی‌های اصلی

این فقط یک پوشش ساده برای PubChem نیست. این سرور کاملاً بازسازی شده تا بسیار مقاوم و هوشمند باشد:

-   **🧠 جستجوی هوشمند جایگزین**: اگر جستجو با نام رایج (مانند "ویتامین D") شکست بخورد، سرور به طور خودکار جستجوی عمیق‌تری را در پایگاه داده مواد PubChem انجام می‌دهد تا ترکیب صحیح را پیدا کند. این قابلیت نرخ موفقیت را در پرسش‌های مبهم به طور چشمگیری افزایش می‌دهد.
-   **🛡️ مدیریت خطا و تلاش مجدد مقاوم**: سرور به گونه‌ای طراحی شده که خطاهای API را به شکل مناسب مدیریت کند. اگر با خطای "سرور مشغول است" از PubChem مواجه شود، به طور خودکار منتظر می‌ماند و درخواست را مجدداً ارسال می‌کند تا درخواست شما حتی در شرایط بار سنگین موفق شود.
-   **🔒 پشتیبانی اختیاری از پروکسی تور**: شما کنترل کامل روی حریم خصوصی خود دارید. با یک فایل ساده `config.ini` می‌توانید همه درخواست‌ها را از طریق شبکه تور (از طریق SOCKS5 یا HTTP پروکسی) ارسال کنید تا آدرس IP شما فاش نشود. سرور به طور پیش‌فرض امن است و اگر اتصال پروکسی قطع شود، **هرگز** آدرس IP شما را فاش نمی‌کند.
-   **🔎 جستجوی تک و چند ترکیبی**: درخواست‌های مربوط به یک یا چند ترکیب را به طور همزمان و بدون مشکل مدیریت می‌کند.
-   **🧪 دریافت جزئیات خواص شیمیایی**: دسترسی به خواص کلیدی مانند نام IUPAC، فرمول مولکولی، وزن مولکولی و از همه مهم‌تر **جرم مونوایزوتوپیک**.

---

---

### 🚀 بدون نصب: همین حالا در Smithery.ai امتحان کنید

برای کسانی که با سرورهای MCP آشنا نیستند یا فقط می‌خواهند امکانات این ابزار را بدون نصب محلی آزمایش کنند، نسخه زنده و میزبانی شده در Smithery.ai در دسترس است. این امکان را می‌دهد تا مستقیماً از طریق مرورگر با عامل گفت‌وگو کنید.

[**<-- نسخه زنده عامل PubChem را در Smithery.ai بررسی کنید -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**چگونه شروع کنید:**

1.  روی لینک بالا کلیک کنید تا به صفحه سرور بروید.
2.  با حساب **GitHub** یا **Google** خود وارد شوید.
3.  روی دکمه **"بررسی قابلیت‌ها"** کلیک کنید تا رابط گفت‌وگو باز شود و شروع به آزمایش کنید!

> **✅ مدل‌های توصیه‌شده برای بهترین نتایج**
>
> برای دقت بالاتر، به‌ویژه در اعداد اعشاری طولانی، استفاده از مدل‌های قدرتمند توصیه می‌شود. مدل‌های زیر آزمایش شده‌اند و با این ابزار به‌خوبی کار می‌کنند:
>
> *   **Claude 3 Sonnet از Anthropic**
> *   **GPT-4 توربو از OpenAI** (یا نسخه‌های جدیدتر مانند GPT-4o)
>
> ما تأیید کردیم که هر دو مدل، دقت کامل اعداد اعشاری بازگردانده‌شده توسط ابزار را بدون هیچگونه گرد کردن به درستی پردازش کردند.

---

## 🚀 شروع سریع و نصب

این سرور برای اجرا به صورت محلی طراحی شده است؛ یا روی دسکتاپ شما یا در محیط Docker مربوط به AnythingLLM.

### 1. پیش‌نیازها

این پروژه به چند کتابخانه پایتون وابسته است. مطمئن شوید که آن‌ها را در محیط خود نصب کرده‌اید.

یک فایل `requirements.txt` با محتوای زیر ایجاد کنید:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
آن‌ها را با استفاده از `uv` یا `pip` نصب کنید:

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(توجه: `PySocks` تنها در صورتی مورد نیاز است که قصد دارید از ویژگی پراکسی Tor SOCKS5 استفاده کنید.)*

### ۲. پیکربندی

سرور از طریق یک فایل `config.ini` پیکربندی می‌شود که **به صورت خودکار ساخته می‌شود** هنگامی که برای اولین بار آن را اجرا کنید. این فایل در همان دایرکتوری که اسکریپت `pubchem_server.py` قرار دارد ظاهر خواهد شد.

**`config.ini` پیش‌فرض:**
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

### ۳. ادغام با AnythingLLM

دستورالعمل رسمی را دنبال کنید تا این مورد را به عنوان یک سرور MCP سفارشی اضافه کنید. نکته کلیدی این است که `command` را به اجرایی پایتون خود و اسکریپت `pubchem_server.py` اشاره دهید.

**مثال برای AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
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


### 3.1 نمونه‌هایی از پیاده‌سازی با AnythingLLM

در اینجا چند نمونه از نحوه تعامل با عامل آورده شده است. این آزمایش‌ها با استفاده از AnythingLLM Desktop و اتصال به مدل‌های زبان بزرگ مختلف از طریق OpenRouter انجام شده‌اند.

یافته‌ای حیاتی از آزمایش‌های ما اهمیت مدل انتخابی شماست. ما **به شدت توصیه می‌کنیم از مدل‌های کوچک یا محلی برای این کار استفاده نکنید**. مدل‌های کوچک اغلب در تجزیه صحیح داده‌های بازگردانده‌شده توسط ابزار مشکل دارند و موجب بروز خطاهایی مانند مقادیر خیالی، قالب‌بندی اشتباه یا، مهم‌تر از همه، **گرد کردن اعداد اعشاری** می‌شوند که هدف ابزار دقیق ما را نقض می‌کند.

برای حفظ صحت نتایج خود، همیشه بهتر است داده خام بازگردانده‌شده توسط MCP را بررسی کنید. می‌توانید نحوه انجام این کار را در بخش بعدی بیاموزید: [3.2 نحوه تأیید خروجی‌های MCP در لاگ‌ها](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

از طرف دیگر، چندین مدل عملکرد بسیار خوبی را نشان داده‌اند. ما با  **مدل `Gemini 2.5 Flash lite` گوگل** نتایج برجسته‌ای به دست آوردیم. این مدل دقت چشمگیری در پردازش اعداد اعشاری طولانی و قالب‌بندی صحیح جدول نهایی مارک‌داون داشت.

مدل Google gemini 2.5 flash lite بدون پرامپت و با پرامپت اعشارها را کاملاً حفظ می‌کند (در نمونه از مقدار 0.6 برای دما استفاده شده است)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

برای این کار خاص، مدل مورد علاقه شخصی من **`Gemini 2.5 Flash lite`** است، به دلیل دقت و قابلیت اطمینان مداوم آن.

### 3.2 نحوه تأیید خروجی‌های MCP در لاگ‌ها

بهترین راه برای اطمینان از اینکه عامل داده صحیحی دریافت می‌کند و مدل LLM اشتباه نمی‌کند، بررسی فایل لاگ دیباگ تولیدشده توسط سرور MCP است.

این سرور به گونه‌ای پیکربندی شده که به طور خودکار یک فایل لاگ در یک زیرپوشه در مسیر پروژه شما ایجاد کند. این محل خواهد بود:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

درون فایل `mcp_debug.log`، داده‌ی دقیق JSON را خواهید یافت که ابزار قبل از پردازش مدل به LLM بازمی‌گرداند. می‌توانید این JSON را به صورت دستی بررسی کنید تا هر مقداری، به ویژه اعداد اعشاری طولانی از ویژگی‌هایی مانند `monoisotopic_mass` را تأیید کنید و مطمئن شوید که LLM هیچ خطای گرد کردن یا توهمی در پاسخ نهایی خود ایجاد نکرده است.

---

## 📊 نحوه استفاده

پس از یکپارچه‌سازی، دستیار هوش مصنوعی شما به طور خودکار از این ابزار هنگام پرسش درباره اطلاعات شیمیایی استفاده خواهد کرد. ابزار اصلی ارائه‌شده، `search_compounds_by_name` است.

### نمونه درخواست

این درخواست توانایی ابزار را در مدیریت لیستی از ترکیبات با انواع نام‌های مختلف و استخراج چندین ویژگی نشان می‌دهد.

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

عامل (Agent) ابزار `search_compounds_by_name` را فراخوانی خواهد کرد که به طور هوشمند هر ترکیب را پیدا می‌کند، داده‌های آن را دریافت کرده و برای قالب‌بندی به LLM بازمی‌گرداند.

---

## 🛠 ابزار MCP معرفی شده

### `search_compounds_by_name`

چندین ترکیب را به صورت جداگانه و با استفاده از استراتژی جایگزین هوشمند، توقف‌ها و تلاش مجدد برای اطمینان بیشتر، جستجو می‌کند.

**پارامترها:**
-   `names` (List[str]): یک لیست از نام ترکیبات. مثال: `["Aspirin", "Ibuprofen"]`

**خروجی:** یک لیست از دیکشنری‌ها، که هر دیکشنری شامل اطلاعات ترکیب یافته شده یا پیام خطا درباره علت شکست جستجو برای آن ترکیب خاص می‌باشد.

---

## 🙏 تقدیر و تشکر

این پروژه به شدت از [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) اصلی ساخته شده توسط **JackKuo666** الهام گرفته و بر اساس آن توسعه یافته است.

اگرچه این مخزن یک شاخه مستقیم نیست، اما پروژه اصلی نقطه شروع حیاتی بود. این نسخه با تاکید بر استحکام زیاد، استراتژی‌های جستجوی هوشمند و حفظ حریم خصوصی کاربر از طریق ادغام اختیاری با Tor 🧅، مفهوم اصلی را ارتقا داده است.

از نویسنده اصلی بابت کار فوق‌العاده و به اشتراک‌گذاری آن با جامعه صمیمانه سپاسگزاریم.

---

## ⚠️ سلب مسئولیت

این ابزار تنها برای اهداف پژوهشی و آموزشی ارائه شده است. لطفاً به شرایط خدمات PubChem احترام بگذارید و این ابزار را مسئولانه استفاده نمایید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---