# پروتکل Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 زبان</summary>
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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="لوگوی پروتکل Agent2Agent" width="100">
    <h1>پروتکل Agent2Agent (A2A)</h1>
  </div>
</div>

**یک پروتکل باز برای ارتباط و همکاری بین برنامه‌های عامل‌محور غیرشفاف.**

پروتکل Agent2Agent (A2A) یک چالش مهم در حوزه هوش مصنوعی را برطرف می‌کند: امکان ارتباط و همکاری میان عوامل هوش مصنوعی مولد که بر اساس چارچوب‌های مختلف توسط شرکت‌های متفاوت و روی سرورهای جداگانه ساخته شده‌اند - به عنوان عامل، نه صرفاً به عنوان ابزار. هدف A2A ارائه زبان مشترک برای عوامل است تا اکوسیستم هوش مصنوعی متصل، قدرتمند و نوآورانه‌تری ایجاد کند.

با A2A، عوامل می‌توانند:

- قابلیت‌های یکدیگر را کشف کنند.
- درباره شیوه‌های تعامل (متن، فرم، رسانه) مذاکره کنند.
- به طور امن در کارهای طولانی مدت همکاری کنند.
- بدون افشای حالت داخلی، حافظه یا ابزارهای خود فعالیت کنند.

## دوره DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

در این دوره کوتاه درباره [A2A: پروتکل Agent2Agent](https://goo.gle/dlai-a2a) که با همکاری Google Cloud و IBM Research ساخته شده و توسط [هولت اسکینر](https://github.com/holtskinner)، [ایوان ناردینی](https://github.com/inardini)، و [ساندی بسن](https://github.com/sandijean90) تدریس می‌شود، شرکت کنید.

**آنچه خواهید آموخت:**

- **سازگار کردن عوامل با A2A:** عوامل ساخته‌شده با چارچوب‌هایی مانند Google ADK، LangGraph یا BeeAI را به عنوان سرورهای A2A ارائه کنید.
- **اتصال عوامل:** ایجاد کلاینت‌های A2A از ابتدا یا با استفاده از یکپارچه‌سازی‌ها برای اتصال به عوامل سازگار با A2A.
- **هماهنگی گردش کار:** ساخت گردش کارهای ترتیبی و سلسله‌مراتبی از عوامل سازگار با A2A.
- **سیستم‌های چندعاملی:** ساخت یک سیستم چندعاملی سلامت با چارچوب‌های مختلف و مشاهده نحوه همکاری با A2A.
- **A2A و MCP:** یادگیری اینکه چگونه A2A مکمل MCP است و امکان همکاری بین عوامل را فراهم می‌کند.

## چرا A2A؟

با افزایش فراگیر شدن عوامل هوش مصنوعی، توانایی آن‌ها برای تعامل حیاتی است تا بتوان برنامه‌های پیچیده و چندمنظوره ساخت. هدف A2A این است که:

- **شکستن موانع:** اتصال عوامل در اکوسیستم‌های مختلف.
- **امکان همکاری پیچیده:** اجازه دهد عوامل تخصصی در انجام کارهایی که یک عامل به تنهایی قادر به انجام آن نیست، با هم همکاری کنند.
- **ترویج استانداردهای باز:** ایجاد رویکرد جامعه‌محور برای ارتباط عوامل، تشویق نوآوری و پذیرش گسترده.
- **حفظ غیرشفافیت:** اجازه دهد عوامل بدون نیاز به اشتراک حافظه داخلی، منطق اختصاصی یا پیاده‌سازی ابزارهای خاص، همکاری کنند و امنیت و حفاظت از مالکیت فکری را افزایش دهند.

### ویژگی‌های کلیدی

- **ارتباط استاندارد:** JSON-RPC 2.0 بر بستر HTTP(S).
- **کشف عامل:** از طریق "کارت عامل" با جزئیات قابلیت‌ها و اطلاعات اتصال.
- **تعامل انعطاف‌پذیر:** پشتیبانی از درخواست/پاسخ همزمان، جریان داده (SSE) و اعلان‌های پوش غیرهمزمان.
- **تبادل داده غنی:** مدیریت متن، فایل و داده‌های ساختار یافته JSON.
- **مناسب برای سازمان‌ها:** طراحی شده با امنیت، احراز هویت و قابلیت مشاهده.

## شروع کار

- 📚 **مطالعه مستندات:** به [سایت مستندات پروتکل Agent2Agent](https://a2a-protocol.org) مراجعه کنید برای مرور کامل، مشخصات پروتکل، آموزش‌ها و راهنماها.
- 📝 **مشاهده مشخصات:** [مشخصات پروتکل A2A](https://a2a-protocol.org/latest/specification/)
- از SDKها استفاده کنید:
    - [🐍 SDK پایتون A2A](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK گو A2A](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK جاوااسکریپت A2A](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK جاوا A2A](https://github.com/a2aproject/a2a-java) با استفاده از maven
    - [🔷 SDK دات‌نت A2A](https://github.com/a2aproject/a2a-dotnet) با استفاده از [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 SDK راست A2A](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 از [نمونه‌ها](https://github.com/a2aproject/a2a-samples) ما برای مشاهده عملکرد A2A استفاده کنید

## مشارکت

ما از مشارکت‌های جامعه برای توسعه و ارتقاء پروتکل A2A استقبال می‌کنیم!

- **سوالات و بحث‌ها:** به [بحث‌های GitHub](https://github.com/a2aproject/A2A/discussions) بپیوندید.
- **مشکلات و بازخورد:** مشکلات را گزارش دهید یا پیشنهاد بهبود از طریق [Issues GitHub](https://github.com/a2aproject/A2A/issues) ارائه دهید.
- **راهنمای مشارکت:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) ما را برای جزئیات نحوه مشارکت ببینید.
- **بازخورد خصوصی:** از این [فرم گوگل](https://goo.gle/a2a-feedback) استفاده کنید.
- **برنامه همکاری:** مشتریان Google Cloud می‌توانند از طریق این [فرم](https://goo.gle/a2a-partner) به برنامه همکاری ما بپیوندند.

## گام بعدی

### بهبودهای پروتکل

- **کشف عامل:**
    - رسمی کردن گنجاندن طرح‌های احراز هویت و اعتبارنامه‌های اختیاری مستقیماً در `AgentCard`.
- **همکاری عامل‌ها:**
    - بررسی روش `QuerySkill()` برای بررسی پویا مهارت‌های پشتیبانی نشده یا پیش‌بینی نشده.
- **چرخه عمر وظیفه و تجربه کاربری (UX):**
    - پشتیبانی از مذاکره پویا در تجربه کاربری درون یک وظیفه (مثلاً افزودن صدا/تصویر توسط عامل در میانه گفتگو).
- **متدهای کلاینت و انتقال:**
    - بررسی گسترش پشتیبانی به متدهای آغاز شده توسط کلاینت (فراتر از مدیریت وظیفه).
    - بهبودهای قابلیت اطمینان در استریم و مکانیزم‌های اعلان پوش (Push Notification).

## درباره

پروتکل A2A یک پروژه متن‌باز تحت بنیاد لینوکس است که توسط گوگل ارائه شده است. این پروژه تحت [مجوز آپاچی نسخه ۲.۰](LICENSE) منتشر شده و برای مشارکت جامعه باز است.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---