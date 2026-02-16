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

- **ارتباط استاندارد:** JSON-RPC 2.0 از طریق HTTP(S).
- **کشف عامل:** از طریق "کارت‌های عامل" که قابلیت‌ها و اطلاعات اتصال را شرح می‌دهند.
- **تعامل انعطاف‌پذیر:** پشتیبانی از درخواست/پاسخ همزمان، جریان داده (SSE)، و اعلان‌های فشار غیرهمزمان.
- **تبادل داده غنی:** مدیریت متن، فایل‌ها، و داده‌های ساختاریافته JSON.
- **مناسب سازمان‌ها:** طراحی شده با توجه به امنیت، احراز هویت و قابلیت مشاهده.

## شروع کار

- 📚 **مطالعه مستندات:** به [سایت مستندات پروتکل Agent2Agent](https://a2a-protocol.org) مراجعه کنید تا دید کامل، مشخصات کامل پروتکل، آموزش‌ها و راهنماها را دریافت کنید.
- 📝 **مشاهده مشخصات:** [مشخصات پروتکل A2A](https://a2a-protocol.org/latest/specification/)
- استفاده از SDKها:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) با استفاده از maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) با استفاده از [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 از [نمونه‌ها](https://github.com/a2aproject/a2a-samples) ما استفاده کنید تا عملکرد A2A را ببینید

## مشارکت

ما از مشارکت‌های جامعه برای ارتقا و توسعه پروتکل A2A استقبال می‌کنیم!

- **پرسش و گفتگو:** به [بحث‌های GitHub](https://github.com/a2aproject/A2A/discussions) ما بپیوندید.
- **مشکلات و بازخورد:** مشکلات را گزارش دهید یا پیشنهاد بهبود دهید از طریق [مسائل GitHub](https://github.com/a2aproject/A2A/issues).
- **راهنمای مشارکت:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) ما را برای جزئیات نحوه مشارکت ببینید.
- **بازخورد خصوصی:** از این [فرم گوگل](https://goo.gle/a2a-feedback) استفاده کنید.
- **برنامه شریک:** مشتریان Google Cloud می‌توانند از طریق این [فرم](https://goo.gle/a2a-partner) به برنامه شریک ما بپیوندند.

## گام بعدی

### ارتقا پروتکل

- **کشف عامل:**
    - شناسایی رسمی طرح‌های احراز هویت و اعتبارنامه‌های اختیاری مستقیماً در داخل `AgentCard`.
- **همکاری عامل‌ها:**
    - بررسی روش `QuerySkill()` برای بررسی پویا مهارت‌های پشتیبانی‌نشده یا غیرمنتظره.
- **چرخه‌ کار وظیفه و تجربه کاربری:**
    - پشتیبانی از مذاکره UX پویا _درون_ یک وظیفه (مثلاً افزودن صوت/تصویر توسط عامل در میانه گفتگو).
- **روش‌های کلاینت و انتقال داده:**
    - بررسی گسترش پشتیبانی از روش‌های آغاز شده توسط کلاینت (فراتر از مدیریت وظیفه).
    - بهبودهای مربوط به قابلیت اطمینان استریم و مکانیزم اعلان‌های پوش.
 
## درباره

پروتکل A2A یک پروژه متن‌باز تحت بنیاد لینوکس است که توسط گوگل ارائه شده است. این پروتکل تحت [مجوز آپاچی ۲.۰](LICENSE) منتشر شده و پذیرای مشارکت از سوی جامعه است.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---