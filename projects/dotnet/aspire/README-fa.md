# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire چیست؟

.NET Aspire یک پشته ابری (Cloud Ready) با رویکرد مشخص برای ساخت برنامه‌های توزیع‌شده، قابل مشاهده و آماده تولید است. .NET Aspire از طریق مجموعه‌ای از پکیج‌های NuGet ارائه می‌شود که هر کدام به یک نگرانی خاص ابری می‌پردازند. برنامه‌های ابری معمولاً از بخش‌های کوچک و به هم متصل یا میکروسرویس‌ها تشکیل شده‌اند، نه یک پایگاه کد یکپارچه. برنامه‌های ابری اغلب از تعداد زیادی سرویس مانند پایگاه داده، پیام‌رسانی و کش استفاده می‌کنند.

.NET Aspire در موارد زیر کمک می‌کند:

[ارکستراسیون](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire قابلیت‌هایی برای اجرای برنامه‌های چند پروژه‌ای و اتصال وابستگی‌های آنها ارائه می‌دهد.

[یکپارچه‌سازی‌ها](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): یکپارچه‌سازی‌های .NET Aspire پکیج‌های NuGet برای سرویس‌های پرکاربرد مانند Redis یا Postgres هستند که با رابط‌های استاندارد اطمینان می‌دهند این سرویس‌ها به صورت یکنواخت و بدون مشکل به برنامه شما متصل می‌شوند.

[ابزارها](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire با قالب‌های پروژه و ابزارهایی برای Visual Studio و dotnet CLI ارائه می‌شود که به شما در ساخت و کار با برنامه‌های .NET Aspire کمک می‌کنند.

برای کسب اطلاعات بیشتر، [مرور کامل و مستندات .NET Aspire](https://learn.microsoft.com/dotnet/aspire/) را مطالعه کنید. نمونه‌ها در [مخزن نمونه‌های .NET Aspire](https://github.com/dotnet/aspire-samples) موجود است. شما می‌توانید [نمونه eShop را اینجا](https://github.com/dotnet/eshop) و [نسخه Azure را اینجا](https://github.com/Azure-Samples/eShopOnAzure) بیابید.

## چه چیزی در این مخزن وجود دارد؟

میزبان برنامه .NET Aspire، داشبورد، زیرساخت کشف سرویس و همه یکپارچه‌سازی‌های .NET Aspire. همچنین قالب‌های پروژه را شامل می‌شود.

## استفاده از آخرین بیلدهای روزانه

برای شروع استفاده از .NET Aspire با آخرین بیلد روزانه، دستورالعمل‌های [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) را دنبال کنید.

## چگونه می‌توانم مشارکت کنم؟

ما از مشارکت‌ها استقبال می‌کنیم! افراد زیادی از سراسر جهان به بهتر شدن .NET کمک کرده‌اند.

برای کار با کد این مخزن، دستورالعمل‌های [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) را دنبال کنید.

## گزارش مسائل و باگ‌های امنیتی

مسائل و باگ‌های امنیتی باید به صورت خصوصی از طریق ایمیل به مرکز پاسخگویی امنیتی مایکروسافت (MSRC) <secure@microsoft.com> گزارش شوند. باید ظرف ۲۴ ساعت پاسخ دریافت کنید. اگر به هر دلیلی پاسخی دریافت نکردید، لطفاً برای اطمینان از دریافت پیام اولیه خود، دوباره ایمیل ارسال کنید. اطلاعات بیشتر، از جمله کلید PGP مرکز MSRC، در [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue) موجود است. همچنین این دستورالعمل‌ها را می‌توانید در [مستند امنیتی این مخزن](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) بیابید.

همچنین اطلاعات مرتبط با [برنامه باگ باونتی Microsoft .NET Core و ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core) را مشاهده کنید.

### نکته‌ای درباره کانتینرهای استفاده‌شده توسط منابع و یکپارچه‌سازی‌های کلاینت .NET Aspire

تیم .NET نمی‌تواند کانتینرهای شخص ثالثی را که برای آنها پشتیبانی API ارائه شده از نظر مناسب بودن برای نیازهای خاص مشتری ارزیابی کند.

شما باید کانتینرهایی را که انتخاب می‌کنید و با Aspire ترکیب و خودکار می‌سازید، ارزیابی کنید تا مطمئن شوید با نیازهای شما، کارفرمایتان یا الزامات دولتی شما از نظر امنیت و ایمنی، همچنین مقررات رمزنگاری و هر استاندارد نظارتی یا شرکتی دیگر مرتبط با استفاده شما از کانتینر مطابقت دارند.

## بنیاد .NET

.NET Aspire یک پروژه از [بنیاد .NET](https://www.dotnetfoundation.org/projects) است.

پروژه‌های زیادی مرتبط با .NET در GitHub وجود دارد.

* [مخزن اصلی .NET](https://github.com/Microsoft/dotnet) - پیوند به صدها پروژه .NET از مایکروسافت و جامعه.
* [صفحه اصلی ASP.NET Core](https://docs.microsoft.com/aspnet/core) - بهترین نقطه برای شروع یادگیری درباره ASP.NET Core.

این پروژه [آیین‌نامه رفتاری Contributor Covenant](https://contributor-covenant.org) را برای روشن‌سازی رفتار مورد انتظار در جامعه ما پذیرفته است. برای اطلاعات بیشتر، [آیین‌نامه رفتاری بنیاد .NET](https://www.dotnetfoundation.org/code-of-conduct) را مشاهده کنید.

## مجوز

کد موجود در این مخزن تحت مجوز [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) ارائه شده است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---