# Tome - کتاب جادویی هوش مصنوعی

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>یک اپلیکیشن دسکتاپ جادویی که قدرت LLMها و MCP را در اختیار همه قرار می‌دهد</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 دانلود اپلیکیشن دسکتاپ Tome: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">ویندوز</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">مک‌او‌اس</a>
</p>

# Tome

Tome یک اپلیکیشن دسکتاپ است که به **هر کسی** اجازه می‌دهد جادوی LLMها و MCP را به کار گیرد. Tome را دانلود کنید، هر LLM محلی یا راه‌دور را متصل کنید و آن را به هزاران سرور MCP وصل کنید تا کتاب جادویی هوش مصنوعی خود را بسازید.

🫥 می‌خواهید همه‌چیز ۱۰۰٪ محلی و ۱۰۰٪ خصوصی باشد؟ از Ollama و Qwen3 فقط با سرورهای MCP محلی استفاده کنید تا طلسم‌های خود را در جهان جیبی‌تان اجرا کنید. ⚡ به مدل‌های پیشرفته ابری با جدیدترین سرورهای MCP راه‌دور نیاز دارید؟ این هم ممکن است. انتخاب با شماست!

🏗️ این نسخه پیش‌نمایش فنی است، بنابراین ممکن است همه‌چیز کاملاً بی‌نقص نباشد. [به ما در دیسکورد بپیوندید](https://discord.gg/9CH6us29YA) تا نکات، ترفندها و مشکلاتی که با آن مواجه می‌شوید را به اشتراک بگذارید. این مخزن را ستاره‌دار کنید تا از بروزرسانی‌ها و ویژگی‌های جدید مطلع شوید!

## 🪄 ویژگی‌ها

- 🧙 **تجربه کاربری ساده و مناسب مبتدیان**
  - فقط Tome را دانلود و نصب کنید و LLM دلخواه خود را وصل کنید
  - نیازی به کار با JSON، Docker، پایتون یا node نیست
- 🤖 **پشتیبانی از مدل‌های هوش مصنوعی**
  - **راه‌دور**: Google Gemini، OpenAI، هر نقطه پایانی سازگار با API OpenAI
  - **محلی**: Ollama، LM Studio، Cortex، هر نقطه پایانی سازگار با API OpenAI
- 🔮 **پشتیبانی پیشرفته از MCP**
  - رابط کاربری برای نصب، حذف، روشن/خاموش کردن سرورهای MCP
  - سرورهای MCP با npm، uvx، node، python به طور پیش‌فرض پشتیبانی می‌شوند
- 🏪 **ادغام با رجیستری [Smithery.ai](https://smithery.ai)**
  - هزاران سرور MCP با نصب یک‌کلیکی در دسترس هستند
- ✏️ **شخصی‌سازی پنجره‌های کانتکست و دما (temperature)**
- 🧰 **پشتیبانی بومی از tool calls و مدل‌های استدلال**
  - بهبود رابط کاربری که تماس ابزارها و پیام‌های فکری را به وضوح نشان می‌دهد

## دمو

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# شروع به کار

## پیش‌نیازها

- مک‌او‌اس یا ویندوز (به‌زودی لینوکس!)
- ارائه‌دهنده LLM مورد نظر شما: [Ollama](https://ollama.com/) یا [کلید API جِمینی](https://aistudio.google.com/app/apikey) به‌راحتی/رایگان در دسترس هستند
- [آخرین نسخه Tome را دانلود کنید](https://github.com/runebookai/tome/releases)

## راه‌اندازی سریع

1. [Tome را نصب کنید](https://github.com/runebookai/tome/releases)
2. ارائه‌دهنده LLM دلخواه خود را متصل کنید - OpenAI، Ollama و Gemini از پیش تنظیم شده‌اند اما می‌توانید ارائه‌دهندگانی مانند LM Studio را نیز با وارد کردن http://localhost:1234/v1 به عنوان URL اضافه کنید
3. تب MCP را در Tome باز کرده و اولین [سرور MCP خود](https://github.com/modelcontextprotocol/servers) را نصب کنید (Fetch برای شروع گزینه ساده‌ای است، کافیست `uvx mcp-server-fetch` را در فیلد سرور جایگذاری کنید).
4. با مدل مجهز به MCP خود گفتگو کنید! از آن بخواهید برترین خبر Hacker News را بازیابی کند.

# چشم‌انداز

ما می‌خواهیم LLMهای محلی و MCP را برای همه قابل دسترس کنیم. ما در حال ساخت ابزاری هستیم که به شما اجازه می‌دهد با LLMها خلاقیت به خرج دهید، فارغ از اینکه مهندس، علاقه‌مند، هابیست یا هر چیز دیگری باشید.

## اصول اصلی

- **Tome اول محلی است:** شما کنترل کامل دارید که داده‌هایتان کجا برود.
- **Tome برای همه است:** نباید مجبور باشید زبان‌های برنامه‌نویسی، مدیریت بسته‌ها یا فایل‌های پیکربندی json را مدیریت کنید.

## برنامه‌های آینده

از زمان انتشار Tome بازخوردهای شگفت‌انگیزی دریافت کرده‌ایم اما برنامه‌های بزرگی برای آینده داریم. می‌خواهیم LLMها را از چت‌باکس‌شان خارج کنیم و ویژگی‌های زیادی در راه است تا به شما کمک کنیم این کار را انجام دهید.

- وظایف زمان‌بندی‌شده: LLMها باید حتی زمانی که مقابل کامپیوتر نیستید، کارهای مفیدی انجام دهند.
- یکپارچه‌سازی بومی: سرورهای MCP راهی عالی برای دسترسی به ابزارها و اطلاعات هستند، اما می‌خواهیم یکپارچه‌سازی‌های قدرتمندتری برای تعامل منحصربه‌فرد با LLMها اضافه کنیم.
- سازنده اپلیکیشن: ما باور داریم در بلندمدت بهترین تجربه‌ها صرفاً در رابط چت نخواهند بود. برنامه داریم ابزارهای بیشتری اضافه کنیم تا بتوانید اپلیکیشن‌ها و گردش‌کارهای قدرتمندی بسازید.
- ??? نظرات خود را به ما بگویید! از طریق لینک‌های زیر به جامعه ما بپیوندید، خوشحال می‌شویم از شما بشنویم.

# جامعه

[دیسکورد](https://discord.gg/9CH6us29YA) [بلاگ](https://blog.runebook.ai) [بلوسکای](https://bsky.app/profile/gettome.app) [توییتر](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---