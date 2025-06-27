# جِمینی CLI

[![جِمینی CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![اسکرین‌شات جِمینی CLI](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

این مخزن شامل جِمینی CLI است، یک ابزار خط فرمانی هوشمند که به ابزارهای شما متصل می‌شود، کد شما را درک می‌کند و گردش‌کارهایتان را تسریع می‌بخشد.

با جِمینی CLI می‌توانید:

- پایگاه‌های کد بزرگ را در داخل و فراتر از پنجره زمینه ۱ میلیون توکنی جِمینی جستجو و ویرایش کنید.
- برنامه‌های جدیدی از PDF یا طرح‌ها تولید کنید، با استفاده از قابلیت‌های چندوجهی جِمینی.
- وظایف عملیاتی را خودکار کنید، مانند جستجوی pull requestها یا مدیریت rebases پیچیده.
- از ابزارها و سرورهای MCP برای اتصال قابلیت‌های جدید، از جمله [تولید رسانه با Imagen، Veo یا Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia) استفاده کنید.
- پرس‌وجوهای خود را با ابزار [Google Search](https://ai.google.dev/gemini-api/docs/grounding) که در جِمینی ساخته شده است، مستند کنید.

## شروع سریع

1. **پیش‌نیازها:** اطمینان حاصل کنید که [Node.js نسخه ۱۸](https://nodejs.org/en/download) یا بالاتر را نصب کرده‌اید.
2. **اجرای CLI:** دستور زیر را در ترمینال خود اجرا کنید:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   یا آن را با دستور زیر نصب کنید:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **یک تم رنگی انتخاب کنید**
4. **احراز هویت:** هنگام درخواست، با حساب کاربری شخصی گوگل خود وارد شوید. این کار به شما امکان می‌دهد تا حداکثر ۶۰ درخواست مدل در دقیقه و ۱۰۰۰ درخواست مدل در روز با استفاده از جِمینی داشته باشید.

اکنون آماده استفاده از جِمینی CLI هستید!

### برای استفاده پیشرفته یا افزایش محدودیت‌ها:

اگر نیاز به استفاده از مدل خاصی دارید یا به ظرفیت درخواست بالاتری نیاز دارید، می‌توانید از یک کلید API استفاده کنید:

1. یک کلید از [Google AI Studio](https://aistudio.google.com/apikey) دریافت کنید.
2. آن را به عنوان یک متغیر محیطی در ترمینال خود تنظیم کنید. `YOUR_API_KEY` را با کلید تولیدشده خود جایگزین کنید.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

برای سایر روش‌های احراز هویت، از جمله حساب‌های Google Workspace، راهنمای [احراز هویت](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md) را مشاهده کنید.

## نمونه‌ها

زمانی که CLI اجرا می‌شود، می‌توانید از شل خود با جِمینی تعامل داشته باشید.

می‌توانید یک پروژه را از یک پوشه جدید شروع کنید:

```sh
cd new-project/
gemini
> یک ربات دیسکورد با جِمینی برای من بنویس که به کمک فایل FAQ.md که ارائه خواهم داد به سوالات پاسخ دهد
```

یا با یک پروژه موجود کار کنید:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> خلاصه‌ای از تمام تغییراتی که دیروز اعمال شده‌اند به من بده
```

### مراحل بعدی

- یاد بگیرید چگونه [در توسعه مشارکت کنید یا از سورس بسازید](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- با **[دستورات CLI موجود](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)** آشنا شوید.
- اگر به مشکلی برخوردید، **[راهنمای رفع اشکال](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)** را مطالعه کنید.
- برای مستندات کامل‌تر، به [مستندات کامل](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md) مراجعه کنید.
- برای الهام بیشتر به برخی از [وظایف محبوب](#popular-tasks) نگاهی بیندازید.

### رفع اشکال

اگر با مشکلی مواجه شدید، به راهنمای [رفع اشکال](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) مراجعه کنید.

## وظایف محبوب

### کاوش یک پایگاه کد جدید

ابتدا با دستور `cd` وارد مخزن موجود یا تازه کلون شده شوید و `gemini` را اجرا کنید.

```text
> اجزای اصلی معماری این سیستم را شرح بده.
```

```text
> چه مکانیزم‌های امنیتی در این سیستم وجود دارد؟
```

### کار با کد موجود خود

```text
> پیش‌نویس اول برای issue شماره ۱۲۳ گیت‌هاب را پیاده‌سازی کن.
```

```text
> به من کمک کن این پایگاه کد را به آخرین نسخه جاوا مهاجرت دهم. با یک طرح شروع کن.
```

### خودکارسازی گردش‌کارها

از سرورهای MCP برای یکپارچه‌سازی ابزارهای سیستم محلی خود با مجموعه همکاری سازمانی خود استفاده کنید.

```text
> یک ارائه (slide deck) بساز که تاریخچه گیت از ۷ روز گذشته را بر اساس ویژگی و عضو تیم گروه‌بندی و نمایش دهد.
```

```text
> یک اپلیکیشن وب تمام‌صفحه برای نمایش محبوب‌ترین issueهای گیت‌هاب ما برای نمایشگر دیواری بساز.
```

### تعامل با سیستم خود

```text
> همه تصاویر این پوشه را به png تبدیل کن و نام آن‌ها را با استفاده از تاریخ exif تغییر بده.
```

```text
> فاکتورهای PDF من را بر اساس ماه هزینه مرتب کن.
```

## شرایط استفاده و اطلاعیه حریم خصوصی

برای جزئیات مربوط به شرایط استفاده و اطلاعیه حریم خصوصی قابل اعمال بر استفاده شما از جِمینی CLI، به [شرایط استفاده و اطلاعیه حریم خصوصی](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md) مراجعه کنید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---