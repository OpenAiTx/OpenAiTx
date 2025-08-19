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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
    </div>
  </details>
</div>

این مخزن شامل نمونه‌های کد و دموهایی است که از [پروتکل Agent2Agent (A2A)](https://goo.gle/a2a) استفاده می‌کنند.

## مخازن مرتبط

- [A2A](https://github.com/a2aproject/A2A) - مستندات و مشخصات A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - کیت توسعه نرم‌افزار پایتون A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - ابزار رابط کاربری برای بررسی عامل‌های فعال‌شده با A2A.

## مشارکت

مشارکت شما خوش‌آمد است! راهنمای [مشارکت](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) را ببینید.

## دریافت کمک

لطفاً برای ارائه پیشنهادات، بازخورد یا ارسال گزارش اشکال از [صفحه مسائل](https://github.com/a2aproject/a2a-samples/issues) استفاده کنید.

## سلب مسئولیت

این مخزن به خودی خود یک محصول رسمی پشتیبانی شده توسط گوگل نیست. کدهای موجود در این مخزن صرفاً برای اهداف نمایشی ارائه شده‌اند.

مهم: کد نمونه ارائه شده صرفاً جهت نمایش بوده و مکانیزم‌های پروتکل عامل-به-عامل (A2A) را نشان می‌دهد. هنگام ساخت برنامه‌های تولیدی، ضروری است که هر عامل خارج از کنترل مستقیم خود را به عنوان یک موجودیت بالقوه غیرقابل اعتماد در نظر بگیرید.

تمام داده‌های دریافت‌شده از یک عامل خارجی — از جمله اما نه محدود به AgentCard، پیام‌ها، مصنوعات و وضعیت وظایف — باید به عنوان ورودی غیرقابل اعتماد مدیریت شوند. به عنوان مثال، یک عامل مخرب می‌تواند AgentCardی با داده‌های ساختگی در فیلدهایش (مانند توضیحات، نام، skills.description) ارائه دهد. اگر این داده‌ها بدون پاک‌سازی برای ساخت پرامپت‌های یک مدل زبان بزرگ (LLM) استفاده شوند، ممکن است برنامه شما را در معرض حملات تزریق پرامپت قرار دهند. عدم اعتبارسنجی و پاک‌سازی مناسب این داده‌ها قبل از استفاده می‌تواند آسیب‌پذیری‌های امنیتی را وارد برنامه شما کند.

توسعه‌دهندگان مسئول پیاده‌سازی اقدامات امنیتی مناسب، مانند اعتبارسنجی ورودی و مدیریت ایمن اطلاعات محرمانه برای محافظت از سیستم‌ها و کاربران خود هستند.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---