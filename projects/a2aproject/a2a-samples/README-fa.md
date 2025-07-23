
# نمونه‌های Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

این مخزن شامل نمونه کدها و دموهایی است که از [پروتکل Agent2Agent (A2A)](https://goo.gle/a2a) استفاده می‌کنند.

## مخازن مرتبط

- [A2A](https://github.com/a2aproject/A2A) - مستندات و مشخصات فنی A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - کیت توسعه نرم‌افزار پایتون A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - ابزار رابط کاربری برای بازرسی ایجنت‌های مجهز به A2A.

## مشارکت

مشارکت شما خوش‌آمد است! راهنمای [مشارکت](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) را ببینید.

## دریافت کمک

لطفاً برای ارائه پیشنهاد، بازخورد یا گزارش اشکال، از [صفحه مشکلات](https://github.com/a2aproject/a2a-samples/issues) استفاده کنید.

## سلب مسئولیت

این مخزن به طور رسمی یک محصول پشتیبانی‌شده گوگل نیست. کد موجود در این مخزن صرفاً برای اهداف نمایشی است.

مهم: کد نمونه ارائه‌شده فقط برای اهداف نمایشی است و مکانیزم‌های پروتکل عامل-به-عامل (A2A) را نشان می‌دهد. هنگام ساخت برنامه‌های تولیدی، بسیار مهم است که هر عاملی که خارج از کنترل مستقیم شما عمل می‌کند را به عنوان یک موجودیت غیرقابل اعتماد در نظر بگیرید.

تمام داده‌های دریافتی از یک عامل خارجی — از جمله اما نه محدود به AgentCard، پیام‌ها، مصنوعات و وضعیت وظایف آن — باید به عنوان ورودی غیرقابل اعتماد تلقی شود. به عنوان مثال، یک عامل مخرب می‌تواند یک AgentCard با داده‌های دست‌کاری‌شده در فیلدهای خود (مثلاً توضیحات، نام، مهارت‌ها.توضیحات) ارائه دهد. اگر این داده‌ها بدون پاک‌سازی برای ساخت پرامپت برای یک مدل زبانی بزرگ (LLM) مورد استفاده قرار گیرند، ممکن است برنامه شما را در معرض حملات تزریق پرامپت قرار دهد. عدم اعتبارسنجی و پاک‌سازی صحیح این داده‌ها قبل از استفاده می‌تواند آسیب‌پذیری‌های امنیتی در برنامه شما ایجاد کند.

توسعه‌دهندگان مسئول پیاده‌سازی تدابیر امنیتی مناسب مانند اعتبارسنجی ورودی و مدیریت امن مدارک برای محافظت از سیستم‌ها و کاربران خود هستند.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---