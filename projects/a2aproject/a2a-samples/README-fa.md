# نمونه‌های Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="امتحان در Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 زبان</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">اندونزیایی</a>
    </div>
  </details>
</div>

به نمونه‌کدها و نمایش‌های رسمی [پروتکل Agent2Agent (A2A)](https://goo.gle/a2a) خوش آمدید.

خوشحالیم که شما اینجا هستید! چه برای اولین بار معماری‌های چند عاملی را بررسی می‌کنید و چه در حال ساخت شبکه‌های پیشرفته و قابل تعامل عاملی هستید، این مخزن منابع آموزشی ساده، الهام‌بخش و قابل دسترسی را برای تسریع توسعه شما فراهم می‌کند.

## چرا Agent2Agent؟

در دنیای چارچوب‌ها و اکوسیستم‌های متنوع هوش مصنوعی، عامل‌ها نیاز به زبان مشترکی برای ارتباط، همکاری و واگذاری وظایف به صورت امن دارند. پروتکل A2A یک استاندارد باز و استاندارد شده برای تعامل‌پذیری چند عاملی ایجاد می‌کند.

نمونه‌های ما نشان می‌دهند که چگونه می‌توان به سادگی مشکلات پیچیده چند عاملی را در زبان‌ها و برنامه‌های میزبان مختلف حل کرد.

## شروع سریع

با راه‌اندازی فوری یک عامل Helloworld و ارتباط با آن از طریق میزبان CLI پایتون ما بلافاصله شروع کنید.

1. **سرور عامل را راه‌اندازی کنید**:
   یک ترمینال باز کنید و سرور عامل Helloworld را اجرا کنید:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **اجرای کلاینت میزبان**:
   یک ترمینال دوم باز کنید و کلاینت CLI را اجرا کنید تا یک وظیفه به ایجنت ارسال شود:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```
## ساختار مخزن

مخزن به چندین پوشه کلیدی بر اساس زبان برنامه‌نویسی سازمان‌دهی شده است:

| پوشه | توضیحات |
| --- | --- |
| [samples](/samples) | نمونه‌های اصلی A2A که بر اساس زبان برنامه‌نویسی مرتب شده‌اند. |
| [samples/python](/samples/python) | پیاده‌سازی‌های ایجنت پایتون با استفاده از SDK پایتون A2A را نمایش می‌دهد. |
| [samples/go](/samples/go) | پیاده‌سازی‌های ایجنت Go با استفاده از SDK Go A2A را نمایش می‌دهد. |
| [samples/dotnet](/samples/dotnet) | پیاده‌سازی‌های ایجنت C# با استفاده از SDK دات‌نت A2A را نمایش می‌دهد. |
| [samples/java](/samples/java) | پیاده‌سازی‌های ایجنت جاوا با استفاده از SDK جاوا A2A را نمایش می‌دهد. |
| [samples/js](/samples/js) | پیاده‌سازی‌های ایجنت Node.js با استفاده از SDK جاوااسکریپت A2A را نمایش می‌دهد. |

## مشارکت

ما از مشارکت همه افراد با هر سطح مهارتی استقبال و حمایت می‌کنیم! اگر ایده‌ای برای یک نمونه جدید، رفع اشکال یا بهبود مستندات دارید، لطفاً به [راهنمای مشارکت](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) ما مراجعه کنید.

## دریافت کمک

ما متعهد به فراهم آوردن یک جامعه خوش‌آمدگو و حمایت‌کننده هستیم. اگر سؤال، بازخورد یا مشکلی داشتید، لطفاً در [صفحه مسائل](https://github.com/a2aproject/a2a-samples/issues) با ما در ارتباط باشید.

## مخازن مرتبط

| مخزن | دسته‌بندی | توضیحات |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | مشخصات اصلی | مستندات و مشخصات A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | ابزارها | ابزار UI برای بازرسی ایجنت‌های فعال شده با A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | آزمون | مجموعه تست برای اعتبارسنجی انطباق با پروتکل A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | آزمون | جعبه ابزار برای بررسی سازگاری میان پیاده‌سازی‌ها و نسخه‌های مختلف SDKهای A2A با استفاده از مدل عبور چندمرحله‌ای و پروتکل‌های انتقال متنوع. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (پایتون) | SDK رسمی پایتون برای A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK رسمی Go برای A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (جاوا) | SDK رسمی جاوا برای A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (جاوااسکریپت) | SDK رسمی Node.js/جاوااسکریپت برای A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK رسمی C#/.NET برای A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (راست) | SDK رسمی راست برای A2A. |

## سلب مسئولیت

**مهم:** کدهای نمونه ارائه‌شده فقط برای اهداف نمایشی بوده و سازوکارهای

پروتکل Agent-to-Agent (A2A). هنگام ساخت برنامه‌های تولیدی، بسیار مهم است که هر عاملی که خارج از کنترل مستقیم شما عمل می‌کند، به عنوان یک موجودیت بالقوه غیرقابل اعتماد در نظر گرفته شود.

تمام داده‌هایی که از یک عامل خارجی دریافت می‌شود — از جمله اما نه محدود به AgentCard، پیام‌ها، مصنوعات و وضعیت‌های وظیفه — باید به عنوان ورودی غیرقابل اعتماد پردازش شود. به عنوان مثال، یک عامل مخرب می‌تواند AgentCard را با داده‌های ساختگی در فیلدهای آن (مانند توضیحات، نام، skills.description) ارائه کند. اگر این داده‌ها بدون پاک‌سازی برای ساخت پرامپت‌های یک مدل زبانی بزرگ (LLM) استفاده شوند، ممکن است برنامه شما را در معرض حملات تزریق پرامپت قرار دهند. عدم اعتبارسنجی و پاک‌سازی صحیح این داده‌ها قبل از استفاده می‌تواند آسیب‌پذیری‌های امنیتی را در برنامه شما ایجاد کند.

> توسعه‌دهندگان مسئول پیاده‌سازی تدابیر امنیتی مناسب، مانند اعتبارسنجی ورودی و مدیریت امن اعتبارنامه‌ها برای محافظت از سیستم‌ها و کاربران خود هستند.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---