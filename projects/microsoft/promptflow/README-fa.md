# جریان پرامپت (Prompt flow)

[![بسته پایتون](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![پایتون](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - دانلودها](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![افزونه vsc](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![مستندات](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![ایشیو](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![گفتگوها](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![مشارکت](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![لایسنس: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> خوشحال می‌شویم با ما همکاری کنید تا جریان پرامپت را بهتر کنیم از طریق
> شرکت در [گفتگوها](https://github.com/microsoft/promptflow/discussions)،
> ایجاد [ایشیو](https://github.com/microsoft/promptflow/issues/new/choose)،
> ارسال [PR](https://github.com/microsoft/promptflow/pulls).

**جریان پرامپت** مجموعه‌ای از ابزارهای توسعه است که برای تسهیل چرخه کامل توسعه برنامه‌های هوش مصنوعی مبتنی بر مدل‌های زبان بزرگ (LLM) طراحی شده است؛ از ایده‌پردازی، نمونه‌سازی، تست، ارزیابی تا استقرار در تولید و پایش. این ابزار مهندسی پرامپت را بسیار ساده‌تر کرده و به شما امکان می‌دهد برنامه‌های LLM با کیفیت تولید بسازید.

با استفاده از جریان پرامپت، قادر خواهید بود:

- **ایجاد و توسعه تدریجی جریان**
    - ایجاد [جریان‌ها](https://microsoft.github.io/promptflow/concepts/concept-flows.html)ی قابل اجرا که مدل‌های LLM، پرامپت‌ها، کد پایتون و سایر [ابزارها](https://microsoft.github.io/promptflow/concepts/concept-tools.html) را به هم متصل می‌کند.
    - اشکال‌زدایی و تکرار جریان‌ها، به ویژه [ردیابی تعامل با LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) به راحتی.
- **ارزیابی کیفیت و عملکرد جریان**
    - ارزیابی کیفیت و عملکرد جریان با داده‌های بزرگ‌تر.
    - یکپارچه‌سازی تست و ارزیابی در سیستم CI/CD برای تضمین کیفیت جریان.
- **چرخه توسعه یکپارچه برای تولید**
    - استقرار جریان خود در پلتفرم سروینگ دلخواه یا ادغام آن در کد برنامه به سادگی.
    - (اختیاری اما بسیار توصیه‌شده) همکاری تیمی با استفاده از نسخه ابری [Prompt flow در Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## نصب

برای شروع سریع، می‌توانید از محیط توسعه از پیش ساخته‌شده استفاده کنید. **روی دکمه زیر کلیک کنید** تا مخزن را در GitHub Codespaces باز کرده و سپس ادامه راهنما را دنبال کنید!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

اگر می‌خواهید در محیط محلی خود شروع کنید، ابتدا بسته‌ها را نصب نمایید:

اطمینان حاصل کنید که محیط پایتون دارید، `python>=3.9, <=3.11` توصیه می‌شود.

```sh
pip install promptflow promptflow-tools
```

## شروع سریع ⚡

**ایجاد یک چت‌بات با جریان پرامپت**

دستور زیر را اجرا کنید تا یک جریان پرامپت از یک قالب چت ایجاد شود؛ این کار پوشه‌ای به نام `my_chatbot` ایجاد کرده و فایل‌های لازم را در آن قرار می‌دهد:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**تنظیم اتصال برای کلید API**

برای کلید OpenAI، با اجرای دستور زیر و استفاده از فایل `openai.yaml` در پوشه `my_chatbot`، اتصال را برقرار کنید (برای جلوگیری از تغییر فایل yaml کلیدها و نام را با --set بازنویسی کنید):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

برای کلید Azure OpenAI، اتصال را با اجرای دستور زیر و استفاده از فایل `azure_openai.yaml` برقرار کنید:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**گفتگو با جریان خود**

در پوشه `my_chatbot` یک فایل `flow.dag.yaml` وجود دارد که جریان را شامل ورودی/خروجی‌ها، نودها، اتصال و مدل LLM و غیره تعریف می‌کند.

> توجه داشته باشید در نود `chat` از اتصال با نام `open_ai_connection` (در قسمت `connection` مشخص شده) و مدل `gpt-35-turbo` (در قسمت `deployment_name` مشخص شده) استفاده شده است. قسمت deployment_name برای تعیین مدل OpenAI یا منبع استقرار Azure OpenAI است.

برای گفتگو با چت‌بات خود اجرا کنید: (برای پایان جلسه `Ctrl + C` را فشار دهید)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**ارزش اصلی: تضمین "کیفیت بالا" از نمونه اولیه تا تولید**

[**آموزش ۱۵ دقیقه‌ای**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) ما را بررسی کنید که شما را از تنظیم پرامپت ➡ تست دسته‌ای ➡ ارزیابی راهنمایی می‌کند تا کیفیت بالا برای تولید تضمین شود.

گام بعدی! با بخش **آموزش** 👇 ادامه دهید تا بیشتر با جریان پرامپت آشنا شوید.

## آموزش 🏃‍♂️

جریان پرامپت ابزاری برای **ساخت برنامه‌های LLM با کیفیت بالا** است و فرآیند توسعه در آن شامل این مراحل است: توسعه جریان، بهبود کیفیت جریان، استقرار جریان در تولید.

### توسعه برنامه LLM خودتان

#### افزونه VS Code

ما افزونه VS Code (طراح جریان) را نیز برای تجربه توسعه تعاملی با رابط کاربری ارائه داده‌ایم.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

می‌توانید آن را از <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">مارکت‌پلیس visualstudio</a> نصب کنید.

#### بررسی عمیق توسعه جریان

[شروع کار با جریان پرامپت](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): راهنمای گام به گام برای اجرای اولین جریان خود.

### یادگیری از سناریوهای کاربردی

[آموزش: چت با PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): آموزشی جامع برای ساخت یک برنامه چت با کیفیت بالا با جریان پرامپت، شامل توسعه جریان و ارزیابی با معیارها.
> مثال‌های بیشتر را می‌توانید [اینجا](https://microsoft.github.io/promptflow/tutorials/index.html#samples) بیابید. پذیرای مشارکت شما در افزودن سناریوهای جدید هستیم!

### تنظیمات برای مشارکت‌کنندگان

اگر علاقه‌مند به مشارکت هستید، با راهنمای راه‌اندازی توسعه‌دهنده شروع کنید: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

گام بعدی! با بخش **مشارکت** 👇 ادامه دهید تا در توسعه جریان پرامپت سهیم شوید.

## مشارکت

این پروژه پذیرای مشارکت‌ها و پیشنهادات شماست. اکثر مشارکت‌ها نیازمند موافقت با
توافقنامه مجوز مشارکت‌کننده (CLA) است که اعلام می‌کند شما حق و اجازه اعطای حقوق استفاده از مشارکت خود را دارید. برای جزئیات، به https://cla.opensource.microsoft.com مراجعه کنید.

هنگام ارسال pull request، یک ربات CLA به طور خودکار بررسی می‌کند که آیا باید CLA را ارائه دهید یا نه و PR را مطابق (مثلاً با وضعیت، کامنت) علامت‌گذاری می‌کند. فقط کافی است دستورالعمل‌های ربات را دنبال کنید. این کار را فقط یک بار برای همه مخازنی که از CLA ما استفاده می‌کنند انجام می‌دهید.

این پروژه [آیین‌نامه رفتار کد باز مایکروسافت](https://opensource.microsoft.com/codeofconduct/) را پذیرفته است.
برای اطلاعات بیشتر به [سوالات متداول آیین‌نامه رفتار](https://opensource.microsoft.com/codeofconduct/faq/) مراجعه یا با [opencode@microsoft.com](mailto:opencode@microsoft.com) تماس بگیرید.

## علائم تجاری

این پروژه ممکن است شامل علائم تجاری یا لوگوهای پروژه‌ها، محصولات یا خدمات باشد. استفاده مجاز از علائم تجاری یا لوگوهای مایکروسافت مشروط به رعایت
[دستورالعمل‌های علائم تجاری و برند مایکروسافت](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general) است.
استفاده از علائم تجاری یا لوگوهای مایکروسافت در نسخه‌های تغییر یافته این پروژه نباید موجب سوءتفاهم یا تداعی حمایت مایکروسافت شود.
هرگونه استفاده از علائم تجاری یا لوگوی اشخاص ثالث مشمول سیاست‌های آن‌هاست.

## آیین‌نامه رفتار

این پروژه [آیین‌نامه رفتار کد باز مایکروسافت](https://opensource.microsoft.com/codeofconduct/) را پذیرفته است.
برای اطلاعات بیشتر به [سوالات متداول آیین‌نامه رفتار](https://opensource.microsoft.com/codeofconduct/faq/)
مراجعه یا با [opencode@microsoft.com](mailto:opencode@microsoft.com)
تماس بگیرید.

## جمع‌آوری داده

این نرم‌افزار ممکن است اطلاعات مربوط به شما و نحوه استفاده شما از نرم‌افزار را جمع‌آوری کرده و
در صورت فعال بودن تلمتری، به مایکروسافت ارسال کند.
مایکروسافت ممکن است از این اطلاعات برای ارائه خدمات و بهبود محصولات و خدمات خود استفاده کند.
می‌توانید طبق توضیحات مخزن، تلمتری را فعال یا غیرفعال کنید.
همچنین برخی قابلیت‌های نرم‌افزار ممکن است به شما و مایکروسافت امکان جمع‌آوری داده از کاربران برنامه‌های شما را بدهد. اگر از این قابلیت‌ها استفاده می‌کنید،
باید مطابق قانون عمل کنید، از جمله ارائه اطلاعیه مناسب به کاربران برنامه‌ها و ارائه نسخه‌ای از
بیانیه حریم خصوصی مایکروسافت. بیانیه حریم خصوصی ما در
https://go.microsoft.com/fwlink/?LinkID=824704 قرار دارد. درباره جمع‌آوری و استفاده از داده‌ها در مستندات و بیانیه حریم خصوصی بیشتر بدانید. استفاده شما از نرم‌افزار به منزله رضایت به این رویه‌هاست.

### تنظیمات تلمتری

جمع‌آوری تلمتری به طور پیش‌فرض فعال است.

برای غیرفعال کردن، دستور زیر را اجرا کنید:
`pf config set telemetry.enabled=false`

## مجوز

Copyright (c) Microsoft Corporation. All rights reserved.

تحت [مجوز MIT](LICENSE) منتشر شده است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---