# سرورهای عالی MCP [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

یک لیست گردآوری‌شده از سرورهای عالی Model Context Protocol (MCP).

* [MCP چیست؟](#mcp-چیست)
* [کلاینت‌ها](#کلاینت‌ها)
* [آموزش‌ها](#آموزش‌ها)
* [انجمن](#انجمن)
* [راهنما](#راهنما)
* [پیاده‌سازی‌های سرور](#پیاده-سازی‌های-سرور)
* [فریمورک‌ها](#فریمورک‌ها)
* [نکات و ترفندها](#نکات-و-ترفندها)

## MCP چیست؟

[MCP](https://modelcontextprotocol.io/) یک پروتکل باز است که به مدل‌های هوش مصنوعی امکان می‌دهد تا از طریق پیاده‌سازی‌های استانداردشده سرور، به صورت امن با منابع محلی و راه دور تعامل داشته باشند. این لیست بر روی سرورهای MCP آماده تولید و آزمایشی تمرکز دارد که قابلیت‌های هوش مصنوعی را از طریق دسترسی به فایل، اتصال به پایگاه داده، یکپارچه‌سازی با API و سایر سرویس‌های زمینه‌ای گسترش می‌دهند.

## کلاینت‌ها

[awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) و [glama.ai/mcp/clients](https://glama.ai/mcp/clients) را بررسی کنید.

> [!TIP]
> [Glama Chat](https://glama.ai/chat) یک کلاینت چندرسانه‌ای هوش مصنوعی با پشتیبانی از MCP و [دروازه هوش مصنوعی](https://glama.ai/gateway) است.

## آموزش‌ها

* [آغاز سریع Model Context Protocol (MCP)](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [راه‌اندازی برنامه دسکتاپ Claude برای استفاده از پایگاه داده SQLite](https://youtu.be/wxCCzo9dGj0)

## انجمن

* [ردیت r/mcp](https://www.reddit.com/r/mcp)
* [سرور دیسکورد](https://glama.ai/mcp/discord)

## راهنما

* 🎖️ – پیاده‌سازی رسمی
* زبان برنامه‌نویسی
  * 🐍 – مبتنی بر Python
  * 📇 – مبتنی بر TypeScript (یا JavaScript)
  * 🏎️ – مبتنی بر Go
  * 🦀 – مبتنی بر Rust
  * #️⃣ - مبتنی بر C#
  * ☕ - مبتنی بر Java
  * 🌊 – مبتنی بر C/C++
* حوزه
  * ☁️ - سرویس ابری
  * 🏠 - سرویس محلی
  * 📟 - سامانه‌های توکار
* سیستم‌عامل
  * 🍎 – برای macOS
  * 🪟 – برای Windows
  * 🐧 - برای Linux

> [!NOTE]
> تفاوت سرویس محلی 🏠 با ابری ☁️ چیست؟
> * از سرویس محلی زمانی استفاده کنید که سرور MCP با نرم‌افزار نصب‌شده روی همان سیستم تعامل دارد؛ مثلاً کنترل مرورگر Chrome.
> * از شبکه زمانی استفاده کنید که سرور MCP با APIهای راه دور در ارتباط است؛ مثلاً API آب‌وهوا.

## پیاده‌سازی‌های سرور

> [!NOTE]
> اکنون یک [دایرکتوری تحت وب](https://glama.ai/mcp/servers) داریم که با مخزن همگام‌سازی می‌شود.

* 🔗 - [تجمیع‌کننده‌ها](#تجمیع‌کننده‌ها)
* 🎨 - [هنر و فرهنگ](#هنر-و-فرهنگ)
* 📂 - [اتوماسیون مرورگر](#اتوماسیون-مرورگر)
* ☁️ - [پلتفرم‌های ابری](#پلتفرم‌های-ابری)
* 👨‍💻 - [اجرای کد](#اجرای-کد)
* 🤖 - [عامل‌های برنامه‌نویسی](#عامل-های-برنامه-نویسی)
* 🖥️ - [خط فرمان](#خط-فرمان)
* 💬 - [ارتباطات](#ارتباطات)
* 👤 - [پلتفرم‌های داده مشتری](#پلتفرم-های-داده-مشتری)
* 🗄️ - [پایگاه‌های داده](#پایگاه-های-داده)
* 📊 - [پلتفرم‌های داده](#پلتفرم-های-داده)
* 🚚 - [تحویل](#تحویل)
* 🛠️ - [ابزار توسعه‌دهنده](#ابزار-توسعه‌دهنده)
* 🧮 - [ابزارهای علم داده](#ابزارهای-علم-داده)
* 📟 - [سامانه توکار](#سامانه-توکار)
* 📂 - [سیستم‌های فایل](#سیستم-های-فایل)
* 💰 - [مالی و فین‌تک](#مالی-و-فین‌تک)
* 🎮 - [بازی](#بازی)
* 🧠 - [دانش و حافظه](#دانش-و-حافظه)
* 🗺️ - [سرویس‌های موقعیت‌یابی](#سرویس-های-موقعیت-یابی)
* 🎯 - [بازاریابی](#بازاریابی)
* 📊 - [پایش](#پایش)
* 🎥 - [پردازش چندرسانه‌ای](#پردازش-چندرسانه‌ای)
* 🔎 - [جستجو و استخراج داده](#جستجو)
* 🔒 - [امنیت](#امنیت)
* 🌐 - [رسانه‌های اجتماعی](#رسانه-های-اجتماعی)
* 🏃 - [ورزشی](#sports)
* 🎧 - [مدیریت پشتیبانی و خدمات](#support-and-service-management)
* 🌎 - [خدمات ترجمه](#translation-services)
* 🎧 - [تبدیل متن به گفتار](#text-to-speech)
* 🚆 - [سفر و حمل‌ونقل](#travel-and-transportation)
* 🔄 - [کنترل نسخه](#version-control)
* 🛠️ - [ابزارها و یکپارچه‌سازی‌های دیگر](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>تجمیع‌کننده‌ها

سرورهایی برای دسترسی به بسیاری از اپلیکیشن‌ها و ابزارها از طریق یک سرور MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - بیش از ۴۰ اپلیکیشن را با یک باینری و با استفاده از SQL کوئری کنید. همچنین می‌تواند به پایگاه داده سازگار با PostgreSQL، MySQL یا SQLite شما متصل شود. مبتنی بر لوکال و حفظ حریم خصوصی در طراحی.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP یک سرور واسط متحد MCP است که اتصالات MCP شما را با رابط گرافیکی مدیریت می‌کند.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - داده‌ها را در سراسر پلتفرم‌ها و پایگاه‌های داده مختلف با [MindsDB به عنوان یک سرور MCP واحد](https://docs.mindsdb.com/mcp/overview) متصل و یکپارچه کنید.
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - فهرستی از سرورهای MCP تا بتوانید از کلاینت خود بپرسید کدام سرورها را برای بهبود گردش کار روزانه خود می‌توانید استفاده کنید.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - یک API وب را در ۱۰ ثانیه به سرور MCP تبدیل کنید و به رجیستری متن‌باز اضافه کنید: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - اتصال به ۲۵۰۰ API با بیش از ۸۰۰۰ ابزار آماده و مدیریت سرورها برای کاربران خود در اپلیکیشن اختصاصی خود.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - پراکسی سرور جامع که چندین سرور MCP را در یک رابط واحد با قابلیت مشاهده گسترده ادغام می‌کند. ابزارها، پرامپت‌ها، منابع و قالب‌ها را در سراسر سرورها کشف و مدیریت کنید و محیطی برای اشکال‌زدایی هنگام ساخت سرورهای MCP فراهم می‌سازد.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - ابزاری پراکسی برای ترکیب چندین سرور MCP در یک نقطه انتهایی واحد. ابزارهای هوش مصنوعی خود را با متعادل‌سازی بار درخواست‌ها در چندین سرور MCP مقیاس دهید، مشابه عملکرد Nginx برای سرورهای وب.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP یک سرور واسط متحد MCP است که اتصالات MCP شما را با رابط گرافیکی مدیریت می‌کند.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - به طور ایمن و بی‌وقفه Claude Desktop و سایر میزبان‌های MCP را به اپ‌های مورد علاقه خود (Notion، Slack، Monday، Airtable و ...) متصل کنید. کمتر از ۹۰ ثانیه طول می‌کشد.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - یک سرویس وب را تنها با یک کلیک و بدون نیاز به تغییر کد به سرور MCP تبدیل کنید.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - ابزار قدرتمند تولید تصویر با استفاده از API Imagen 3.0 گوگل از طریق MCP. تولید تصاویر باکیفیت از پرامپت‌های متنی با کنترل‌های پیشرفته عکاسی، هنری و فوتورئالیستیک.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - سرور MCP تولید/ویرایش تصویر GPT اوپن‌ای‌آی.

### 🎨 <a name="art-and-culture"></a>هنر و فرهنگ

دسترسی و کاوش مجموعه‌های هنری، میراث فرهنگی و پایگاه‌های داده موزه‌ها. امکان جستجو و تحلیل محتوای هنری و فرهنگی برای مدل‌های هوش مصنوعی.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - سرور MCP محلی برای تولید انیمیشن با استفاده از Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - افزودن، تحلیل، جستجو و تولید ویرایش ویدئو از مجموعه ویدئوی شما
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - سرور MCP برای تعامل با API دیس‌کوگز
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ سرور MCP برای تعامل با بدنه داده Quran.com از طریق REST API رسمی نسخه ۴.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - یکپارچه‌سازی API موزه متروپولیتن برای جستجو و نمایش آثار هنری در این مجموعه.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - یکپارچه‌سازی API موزه Rijksmuseum برای جستجوی آثار هنری، جزئیات و مجموعه‌ها
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - یکپارچه‌سازی API Oorlogsbronnen (منابع جنگی) برای دسترسی به اسناد، عکس‌ها و مدارک تاریخی جنگ جهانی دوم از هلند (۱۹۴۰-۱۹۴۵)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - یکپارچه‌سازی سرور MCP برای DaVinci Resolve با ابزارهای قدرتمند ویرایش ویدئو، اصلاح رنگ، مدیریت رسانه و کنترل پروژه
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - سرور MCP یکپارچه با API AniList برای اطلاعات انیمه و مانگا
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - سرور MCP مبتنی بر API آسپریت برای تولید پیکسل‌آرت
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - سرور MCP و افزونه‌ای که کنترل زبان طبیعی شبیه‌ساز NVIDIA Isaac Sim، Lab، OpenUSD و غیره را فعال می‌کند.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - سرور MCP برای API کتابخانه باز که به دستیارهای هوشمند امکان جستجوی اطلاعات کتاب را می‌دهد.
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - سرور MCP برای Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - ارائه ترسیم و تحلیل جامع و دقیق بَزی (طالع‌بینی چینی)

### 📂 <a name="browser-automation"></a>اتوماسیون مرورگر

دسترسی به محتوای وب و قابلیت‌های اتوماسیون. امکان جستجو، اسکرپ و پردازش محتوای وب در قالب‌های مناسب هوش مصنوعی.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - ابزاری مبتنی بر FastMCP که ویدئوهای ترند شده Bilibili را دریافت و از طریق رابط MCP استاندارد ارائه می‌کند.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - سرور MCP که جستجوی محتوای Bilibili را پشتیبانی می‌کند. نمونه‌های یکپارچه‌سازی با LangChain و اسکریپت‌های تست ارائه شده است.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - مرورگر سلف-هاستد با عامل و MCP داخلی و پشتیبانی از A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - سرور MCP برای اتوماسیون مرورگر با استفاده از Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - سرور MCP پایتونی با استفاده از Playwright برای اتوماسیون مرورگر، مناسب‌تر برای LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - اتوماسیون تعاملات مرورگر در فضای ابری (مانند ناوبری وب، استخراج داده، پر کردن فرم و ...)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - اتوماسیون مرورگر Chrome محلی شما
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use به صورت سرور MCP با انتقال SSE. شامل داکرفایل برای اجرای کرومیوم در داکر + سرور VNC.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - سرور MCP با استفاده از Playwright برای اتوماسیون مرورگر و وب‌اسکرپینگ
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - سرور MCP همراه با افزونه مرورگر که به کلاینت‌های LLM امکان کنترل مرورگر (فایرفاکس) کاربر را می‌دهد.
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - سرور MCP برای تعامل با Apple Reminders در مک‌اواس
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - استخراج داده ساختاریافته از هر وب‌سایت. فقط پرامپت دهید و JSON دریافت کنید.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - دریافت زیرنویس و رونوشت یوتیوب برای تحلیل هوش مصنوعی
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - پیاده‌سازی کلاینت/سرور MCP «حداقلی» با استفاده از Azure OpenAI و Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - سرور رسمی MCP Playwright مایکروسافت، فعال‌سازی تعامل LLM با صفحات وب از طریق snapshots دسترسی ساختار یافته
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - اتوماسیون مرورگر برای وب‌اسکرپینگ و تعامل
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - سرور MCP برای تعامل با مرورگرهای سازگار با manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - سرور MCP برای جستجوی رایگان وب با استفاده از نتایج جستجوی گوگل، بدون نیاز به کلید API.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - یکپارچه‌سازی سرور MCP با Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>پلتفرم‌های ابری

یکپارچه‌سازی سرویس پلتفرم‌های ابری. امکان مدیریت و تعامل با زیرساخت و سرویس‌های ابری.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - سرورهای MCP AWS برای یکپارچه‌سازی بدون درز با سرویس‌ها و منابع AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - سرور MCP مبتنی بر محصولات ابر Qiniu، پشتیبانی از دسترسی به فضای ذخیره‌سازی Qiniu Cloud و خدمات پردازش رسانه و غیره.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - بارگذاری و مدیریت ذخیره‌سازی IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - سرور Kubernetes Model Context Protocol (MCP) که ابزارهایی برای تعامل با کلاسترهای Kubernetes از طریق یک رابط استاندارد، شامل کشف منابع API، مدیریت منابع، لاگ پادها، متریک‌ها و رویدادها فراهم می‌کند.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - این یک سرور MCP برای پرس‌وجوی کتاب‌ها است و می‌تواند در کلاینت‌های رایج MCP مانند Cherry Studio استفاده شود.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - سروری سبک اما قدرتمند که به دستیارهای هوشمند امکان اجرای دستورات AWS CLI، استفاده از پایپ‌های یونیکس و اعمال قالب‌های پرامپت برای وظایف AWS رایج را در محیط امن Docker با پشتیبانی چندمعماری می‌دهد.
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - سروری سبک اما قدرتمند که به دستیارهای هوشمند امکان اجرای امن دستورات CLI کوبرنتیز (`kubectl`، `helm`، `istioctl` و `argocd`) با استفاده از پایپ‌های یونیکس در محیط امن Docker با پشتیبانی چندمعماری می‌دهد.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - سرور MCP که به دستیارهای هوشمند امکان عملیات بر روی منابع Alibaba Cloud را می‌دهد و از ECS، Cloud Monitor، OOS و محصولات ابری پرکاربرد پشتیبانی می‌کند.
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - سرور مدیریت VMware ESXi/vCenter مبتنی بر MCP (Model Control Protocol)، ارائه رابط‌های REST API ساده برای مدیریت ماشین مجازی.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - یکپارچه‌سازی با سرویس‌های Cloudflare شامل Workers، KV، R2 و D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - سرور MCP که به عامل‌های هوشمند امکان مدیریت منابع Kubernetes را از طریق انتزاع Cyclops می‌دهد
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - یکپارچه‌سازی با سرویس‌های Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - پیاده‌سازی تایپ‌اسکریپت عملیات کلاستر Kubernetes برای پادها، دیپلویمنت‌ها و سرویس‌ها.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - سرور Model Context Protocol برای کوئری و تحلیل منابع Azure در مقیاس با استفاده از Azure Resource Graph، فعال‌سازی دستیارهای هوشمند برای کاوش و پایش زیرساخت Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - پوششی برای خط فرمان Azure CLI که امکان صحبت مستقیم با Azure را فراهم می‌کند
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - یک MCP برای دسترسی به تمام اجزای Netskope Private Access در محیط Netskope Private Access شامل اطلاعات راه‌اندازی دقیق و نمونه‌های LLM برای استفاده.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - سرور قدرتمند Kubernetes MCP با پشتیبانی اضافه برای OpenShift. علاوه بر عملیات CRUD برای **هر** منبع Kubernetes، ابزارهای تخصصی برای تعامل با کلاستر شما فراهم می‌کند.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - سرور Terraform MCP که به دستیارهای هوشمند امکان مدیریت و کار با محیط‌های Terraform، خواندن پیکربندی‌ها، تحلیل پلن‌ها، اجرای پیکربندی‌ها و مدیریت وضعیت Terraform را می‌دهد.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - سرور MCP برای تعامل با Pulumi با استفاده از Pulumi Automation API و Pulumi Cloud API. به کلاینت‌های MCP امکان انجام عملیات Pulumi مانند دریافت اطلاعات پکیج، پیش‌نمایش تغییرات، استقرار بروزرسانی‌ها و دریافت خروجی استک را به صورت برنامه‌نویسی می‌دهد.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - سرور Model Context Protocol (MCP) برای Kubernetes که به دستیارهای هوشمندی مانند Claude، Cursor و دیگران امکان تعامل با کلاسترهای Kubernetes از طریق زبان طبیعی را می‌دهد.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - عملیات کلاستر Kubernetes از طریق MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - سرور MCP مبتنی بر Go برای ارتباط با منابع Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - دریافت سریع اطلاعات قیمت‌گذاری EC2 به‌روز با یک فراخوانی. سریع. بر اساس کاتالوگ قیمت AWS پیش‌پردازش شده.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - مدیریت و عملیات چندکلاستری Kubernetes با MCP، دارای رابط مدیریت، لاگ و نزدیک به ۵۰ ابزار داخلی برای سناریوهای رایج DevOps و توسعه. پشتیبانی از منابع استاندارد و CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - مدیریت و عملیات چندکلاستری Kubernetes با MCP. قابلیت یکپارچه‌سازی به عنوان SDK در پروژه اختصاصی شما و شامل نزدیک به ۵۰ ابزار داخلی برای سناریوهای رایج DevOps و توسعه. پشتیبانی از منابع استاندارد و CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - سرور MCP برای مدیریت کوبرنتیز و تحلیل سلامت کلاستر و برنامه‌های شما
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - سرور MCP برای Azure Data Lake Storage. قابلیت مدیریت کانتینرها، عملیات خواندن/نوشتن/آپلود/دانلود فایل‌های کانتینر و مدیریت متادیتای فایل را دارد.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S یک ابزار مدیریت منابع کوبرنتیز مبتنی بر هوش مصنوعی است که به کاربران اجازه می‌دهد از طریق تعامل به زبان طبیعی بر روی هر منبعی در کلاسترهای کوبرنتیز عملیات انجام دهند، از جمله منابع بومی (مانند Deployment, Service) و منابع سفارشی (CRD). نیازی به حفظ دستورات پیچیده نیست – فقط نیاز خود را توصیف کنید و هوش مصنوعی عملیات مربوطه را با دقت اجرا می‌کند، که کاربری کوبرنتیز را به طور قابل توجهی افزایش می‌دهد.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - منابع Redis Cloud خود را به راحتی با زبان طبیعی مدیریت کنید. پایگاه داده ایجاد کنید، اشتراک‌ها را پایش کنید و عملیات استقرار ابری را با دستورات ساده پیکربندی نمایید.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - یک سرور MCP قدرتمند که به دستیارهای هوش مصنوعی اجازه می‌دهد به صورت یکپارچه با نمونه‌های Portainer تعامل داشته باشند و دسترسی به مدیریت کانتینر، عملیات استقرار و قابلیت‌های پایش زیرساخت را با زبان طبیعی فراهم می‌کند.

### 👨‍💻 <a name="code-execution"></a>اجرای کد

سرورهای اجرای کد. امکان اجرای کد در محیط امن برای LLMها، مثلاً برای ایجنت‌های برنامه‌نویسی.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- اجرای کد پایتون در یک سندباکس امن از طریق فراخوانی ابزار MCP
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - اجرای هر کد تولیدشده توسط LLM در یک محیط سندباکس امن و مقیاس‌پذیر و ساخت ابزارهای MCP خود با استفاده از جاوااسکریپت یا پایتون، با پشتیبانی کامل از پکیج‌های NPM و PyPI
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: سرور MCP داکرایز شده برای فراهم کردن دسترسی ایجنت هوش مصنوعی به هر API با استفاده از مستندات API موجود.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – سرور MCP مبتنی بر Node.js که سندباکس‌های ایزوله‌شده مبتنی بر Docker را برای اجرای اسنیپت‌های جاوااسکریپت با نصب وابستگی‌های npm به صورت لحظه‌ای و پاکسازی خودکار ایجاد می‌کند.
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - سندباکس اجرای کد جاوااسکریپت که با استفاده از v8 کد را ایزوله می‌کند تا کد تولیدشده توسط هوش مصنوعی را به صورت محلی و بدون نگرانی اجرا کند. از snapshot حافظه برای جلسات ماندگار پشتیبانی می‌کند.

### 🤖 <a name="coding-agents"></a>ایجنت‌های برنامه‌نویسی

ایجنت‌های برنامه‌نویسی کامل که به LLMها اجازه خواندن، ویرایش و اجرای کد و حل وظایف عمومی برنامه‌نویسی به صورت کاملاً خودکار را می‌دهند.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - یک ایجنت برنامه‌نویسی کامل که مبتنی بر عملیات سمبولیک کد با استفاده از سرورهای زبان است.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - ایجنت برنامه‌نویسی با ابزارهای اولیه خواندن، نوشتن و خط فرمان.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - سرور MCP که به مدل‌های هوش مصنوعی امکان جستجو، واکشی و حل مسائل LeetCode را می‌دهد. از فیلتر متادیتا، پروفایل کاربری، ارسال راه‌حل و دسترسی به داده‌های مسابقه پشتیبانی می‌کند.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - سرور MCP که امکان دسترسی خودکار به مسائل برنامه‌نویسی، راه‌حل‌ها، ارسال‌ها و داده‌های عمومی **LeetCode** را با احراز هویت اختیاری برای ویژگی‌های خاص کاربر (مانند یادداشت‌ها) فراهم می‌کند و از هر دو سایت `leetcode.com` (جهانی) و `leetcode.cn` (چین) پشتیبانی می‌کند.
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - سرور MCP که به هوش مصنوعی‌هایی مانند Claude اجازه می‌دهد ساختار دایرکتوری در فضای کاری VS Code را بخواند، مشکلات شناسایی شده توسط linter(ها) و سرور زبان را ببیند، فایل‌های کد را بخواند و ویرایش کند.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - یک سرور MCP تک فایل اجرایی که کد منبع را به AST تبدیل می‌کند، صرف‌نظر از زبان برنامه‌نویسی.

### 🖥️ <a name="command-line"></a>خط فرمان

اجرای دستورات، دریافت خروجی و تعامل با شل‌ها و ابزارهای خط فرمان.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - سرور Model Context Protocol که دسترسی به iTerm را فراهم می‌کند. می‌توانید دستورات اجرا کنید و درباره آنچه در ترمینال iTerm می‌بینید سؤال بپرسید.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - اجرای هر دستور با ابزارهای `run_command` و `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - مفسر ایمن پایتون مبتنی بر HF Smolagents `LocalPythonExecutor`
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - رابط خط فرمان با اجرای ایمن و سیاست‌های امنیتی قابل تنظیم
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - سرور DeepSeek MCP برای ترمینال
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - سرور اجرای ایمن دستورات شل مبتنی بر Model Context Protocol (MCP)
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - سرور Cisco pyATS برای تعامل ساختاریافته و مدل‌محور با دستگاه‌های شبکه.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - چاقوی سوییسی چندکاره برای مدیریت/اجرای برنامه‌ها و خواندن/نوشتن/جستجو/ویرایش کد و فایل‌های متنی.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - سرور MCP که کنترل SSH برای سرورهای لینوکس و ویندوز را از طریق Model Context Protocol فراهم می‌کند. اجرای ایمن دستورات شل از راه دور با احراز هویت رمز عبور یا کلید SSH.

### 💬 <a name="communication"></a>ارتباطات

ادغام با پلتفرم‌های ارتباطی برای مدیریت پیام‌ها و عملیات کانال. امکان تعامل مدل‌های هوش مصنوعی با ابزارهای ارتباط تیمی را فراهم می‌کند.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - سرور MCP برای Nostr که امکان تعامل با Nostr، ارسال یادداشت و غیره را فراهم می‌کند.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - تعامل با جستجوی توییتر و تایم‌لاین
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - سرور MCP برای ایجاد اینباکس به صورت لحظه‌ای جهت ارسال، دریافت و انجام عملیات روی ایمیل. ما ایجنت ایمیل برای هوش مصنوعی نیستیم، بلکه ایمیل برای ایجنت‌های هوش مصنوعی هستیم.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - سرور MCP برای ارتباط با Google Tasks API
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - سرور MCP که به طور ایمن با دیتابیس iMessage شما از طریق Model Context Protocol (MCP) ارتباط برقرار می‌کند و به LLMها اجازه می‌دهد مکالمات iMessage را جستجو و تحلیل کنند. شامل اعتبارسنجی شماره تلفن، پردازش پیوست‌ها، مدیریت مخاطبین، مدیریت گروه‌ها و پشتیبانی کامل از ارسال و دریافت پیام است.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - ادغام API تلگرام برای دسترسی به داده‌های کاربر، مدیریت گفتگوها (چت‌ها، کانال‌ها، گروه‌ها)، واکشی پیام‌ها و مدیریت وضعیت خوانده‌شده
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - ادغام API تلگرام برای دسترسی به داده‌های کاربر، مدیریت گفتگوها (چت‌ها، کانال‌ها، گروه‌ها)، واکشی پیام‌ها، ارسال پیام و مدیریت وضعیت خوانده‌شده.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - سرور MCP برای Inbox Zero. افزودن قابلیت‌هایی بر روی Gmail مانند شناسایی ایمیل‌هایی که باید به آن‌ها پاسخ دهید یا پیگیری کنید.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - سرور ntfy MCP برای ارسال/دریافت اعلان‌های ntfy به سرور ntfy خود-میزبان از ایجنت‌های هوش مصنوعی 📤 (پشتیبانی از احراز هویت توکن امن و بیشتر - قابل استفاده با npx یا داکر!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - اپلیکیشن سرور MCP که انواع مختلفی از پیام‌ها را به ربات گروه WeCom ارسال می‌کند.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - سرور MCP که دسترسی ایمن به دیتابیس iMessage شما از طریق Model Context Protocol (MCP) را فراهم می‌کند و به LLMها اجازه می‌دهد مکالمات iMessage را با اعتبارسنجی شماره تلفن و مدیریت پیوست تحلیل کنند.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - سرور MCP که به عنوان آداپتر برای اکوسیستم [ACP](https://agentcommunicationprotocol.dev) عمل می‌کند. ایجنت‌های ACP را به صورت یکپارچه در اختیار کلاینت‌های MCP قرار می‌دهد و فاصله ارتباطی بین دو پروتکل را پر می‌کند.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - سرور MCP همراه با میزبان MCP که دسترسی به تیم‌ها، کانال‌ها و پیام‌های Mattermost را فراهم می‌کند. MCP host به عنوان یک بات در Mattermost با دسترسی به سرورهای MCP قابل پیکربندی ادغام شده است.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - سرور MCP برای جستجو در پیام‌های شخصی واتساپ، مخاطبین و ارسال پیام به افراد یا گروه‌ها
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - سرور MCP برای ادغام LINE Official Account
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - ادغام با جیمیل و تقویم گوگل.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - ادغام با نمونه Bluesky برای جستجو و تعامل
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - ادغام فضای کاری Slack برای مدیریت کانال و پیام‌رسانی
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - قدرتمندترین سرور MCP برای فضای کاری Slack.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 این یک سرور MCP برای تعامل با API سرویس VRChat است. می‌توانید اطلاعات دوستان، دنیاها، آواتارها و موارد دیگر را در VRChat واکشی کنید.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - سرور MCP برای ارتباط با Google Calendar API. مبتنی بر TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - سرور MCP که با ارسال اعلان روی تلفن از طریق ntfy شما را مطلع نگه می‌دارد
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - سرور MCP برای [DIDLogic](https://didlogic.com). افزودن قابلیت مدیریت نقاط انتهایی SIP، شماره‌ها و مقصدها.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - سرور MCP برای مدیریت Google Tasks
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - سرور MCP که پیام‌رسانی Microsoft Teams را ادغام می‌کند (خواندن، ارسال، منشن، لیست اعضا و موضوعات)
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - سرور MCP که به کل مجموعه Microsoft 365 از طریق Graph API متصل می‌شود (شامل ایمیل، فایل‌ها، اکسل، تقویم)
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - سرور MCP برای پلتفرم WhatsApp Business توسط YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - سرور MCP برای Product Hunt. تعامل با پست‌های محبوب، نظرات، مجموعه‌ها، کاربران و موارد دیگر.


### 👤 <a name="customer-data-platforms"></a>پلتفرم‌های داده مشتری

دسترسی به پروفایل مشتریان درون پلتفرم‌های داده مشتری

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - اتصال به [iaptic](https://www.iaptic.com) برای پرسش درباره خریدهای مشتری، داده تراکنش و آمار درآمد برنامه.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - اتصال هر داده باز به هر LLM با Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - سرور MCP برای دسترسی و بروزرسانی پروفایل‌ها در سرور Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - سرور MCP برای تعامل با Workspace سرویس Tinybird از هر کلاینت MCP.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - سرور Model Context Protocol برای تولید نمودارهای تصویری با استفاده از [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>پایگاه‌های داده

دسترسی امن به پایگاه داده با قابلیت بازرسی شِما. امکان پرس‌وجو و تحلیل داده‌ها با کنترل‌های امنیتی قابل تنظیم از جمله دسترسی فقط خواندنی.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  پیمایش [پروژه‌های Aiven](https://go.aiven.io/mcp-server) و تعامل با سرویس‌های PostgreSQL®، Apache Kafka®، ClickHouse® و OpenSearch®
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - سرور Supabase MCP با پشتیبانی از اجرای کوئری SQL و ابزارهای کاوش پایگاه داده
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - سرویس MCP برای Tablestore، قابلیت افزودن اسناد، جستجوی معنایی اسناد بر اساس بردار و مقدار، سازگار با RAG و سرورلس.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - یکپارچه‌سازی پایگاه داده MySQL در NodeJS با کنترل دسترسی قابل تنظیم و بازرسی شِما
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – سرور MCP پایگاه داده جهانی با پشتیبانی از پایگاه داده‌های اصلی.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - یکپارچه‌سازی پایگاه داده TiDB با قابلیت بازرسی شِما و کوئری
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - موتور معنایی برای کلاینت‌های Model Context Protocol(MCP) و ایجنت‌های هوش مصنوعی
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - سرور MCP و MCP SSE که به طور خودکار API را بر اساس شِما و داده پایگاه داده تولید می‌کند. پشتیبانی از PostgreSQL، Clickhouse، MySQL، Snowflake، BigQuery، Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - ادغام DICOM برای جستجو، خواندن و انتقال تصاویر پزشکی و گزارش‌ها از PACS و دیگر سیستم‌های سازگار با DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - سرور Chroma MCP برای دسترسی به نمونه‌های Chroma محلی و ابری جهت قابلیت‌های واکشی
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ادغام پایگاه داده ClickHouse با قابلیت بازرسی شِما و کوئری
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - یکپارچه‌سازی Confluent برای تعامل با Confluent Kafka و APIهای REST سرویس Confluent Cloud.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - سرور MCP کوچ‌بیس دسترسی یکپارچه به کلاسترهای Capella Cloud و کلاسترهای خودمدیریتی را برای عملیات اسناد، کوئری‌های SQL++ و تحلیل داده با زبان طبیعی فراهم می‌کند.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - پیاده‌سازی سرور MCP که تعامل با Elasticsearch را فراهم می‌کند.
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - سرور MCP همه‌کاره برای توسعه و عملیات Postgres، به همراه ابزارهایی برای تحلیل عملکرد، تنظیم و بررسی سلامت.
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - سرور MCP ترینو برای کوئری و دسترسی به داده از کلاسترهای Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - پیاده‌سازی Go از سرور Model Context Protocol (MCP) برای Trino.
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - یکپارچه‌سازی پایگاه داده MySQL با کنترل‌های دسترسی قابل تنظیم، بررسی اسکیمای پایگاه داده و راهنمای امنیتی جامع.
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - پشتیبانی از SSE و STDIO؛ فقط به قابلیت‌های CRUD در MySQL محدود نیست؛ همچنین شامل تحلیل خطاهای پایگاه داده؛ کنترل مجوزها بر اساس نقش‌ها؛ و تسهیل توسعه ابزارهای سفارشی برای توسعه‌دهندگان.
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - یکپارچه‌سازی پایگاه داده Airtable با قابلیت بررسی اسکیمای پایگاه داده و قابلیت خواندن و نوشتن.
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - یکپارچه‌سازی پایگاه داده Nocodb، با قابلیت خواندن و نوشتن.
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - پیاده‌سازی سرور برای یکپارچه‌سازی Google BigQuery که امکان دسترسی مستقیم و کوئری پایگاه داده BigQuery را فراهم می‌کند.
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - یکپارچه‌سازی پایگاه داده MySQL مبتنی بر Node.js که عملیات امن بر روی پایگاه داده MySQL را فراهم می‌کند.
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - پایگاه داده ledger فایرپروف با همگام‌سازی چندکاربره.
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – یک سرور MCP چندپایگاه‌داده با عملکرد بالا ساخته‌شده با Golang که از MySQL و PostgreSQL (پشتیبانی از NoSQL به‌زودی) پشتیبانی می‌کند. شامل ابزارهای داخلی برای اجرای کوئری، مدیریت تراکنش، کاوش اسکیمای پایگاه داده، ساخت کوئری، و تحلیل عملکرد، به همراه یکپارچگی بدون وقفه با Cursor برای بهبود گردش کار پایگاه داده.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: سرور MCP با امکانات کامل برای پایگاه داده‌های MongoDB.
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - سرویس‌های فایربیس شامل Auth، Firestore و Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - یکپارچه‌سازی پایگاه داده Convex برای مشاهده جداول، توابع و اجرای کوئری‌های یک‌باره ([Source](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - سرور MCP متن‌باز تخصصی در ابزارهای آسان، سریع و امن برای پایگاه داده‌ها.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - سرور MCP برای کوئری‌گیری از GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - سرور MCP که دسترسی ایمن و فقط‌خواندنی به پایگاه‌های داده SQLite از طریق Model Context Protocol (MCP) فراهم می‌کند. این سرور با فریم‌ورک FastMCP ساخته شده است و به LLMها امکان کاوش و کوئری SQLite با ویژگی‌های ایمنی داخلی و اعتبارسنجی کوئری را می‌دهد.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - اجرای کوئری بر روی InfluxDB OSS API v2.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - یکپارچه‌سازی Snowflake با قابلیت خواندن و (اختیاری) نوشتن به همراه رهگیری بینش‌ها.
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - سرور MCP برای مدیریت و ایجاد پروژه‌ها و سازمان‌ها در Supabase.
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - سرور MCP برای Apache Kafka و Timeplus. قابلیت فهرست‌کردن تاپیک‌های Kafka، واکشی پیام‌ها، ذخیره داده‌های Kafka به صورت محلی و کوئری‌گیری داده‌های جریانی با SQL از طریق Timeplus.
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - یکپارچه‌سازی VikingDB با معرفی collection و index، ذخیره و جستجوی برداری.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - سرور Model Context Protocol برای MongoDB.
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - یکپارچه‌سازی پایگاه داده DuckDB با قابلیت بررسی اسکیمای پایگاه داده و کوئری‌گیری.
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - یکپارچه‌سازی پایگاه داده BigQuery با قابلیت بررسی اسکیمای پایگاه داده و کوئری‌گیری.
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - اتصال به هر پایگاه داده سازگار با JDBC و انجام کوئری، درج، به‌روزرسانی، حذف و غیره.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - سرور Model Context Protocol (MCP) که تعامل جامع با پایگاه داده SQLite را فراهم می‌کند.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - سرور Memgraph MCP - شامل ابزاری برای اجرای کوئری بر روی Memgraph و منبع اسکیمای پایگاه داده.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - یکپارچه‌سازی پایگاه داده PostgreSQL با قابلیت بررسی اسکیمای پایگاه داده و کوئری‌گیری.
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - عملیات SQLite با ویژگی‌های تحلیل داخلی.
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol با Neo4j (اجرای کوئری، حافظه گراف دانش، مدیریت نمونه‌های Neo4j Aura)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — سرور MCP برای ایجاد و مدیریت پایگاه‌های داده Postgres با استفاده از Neon Serverless Postgres.
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) سرور MCP برای پلتفرم Postgres نیل - مدیریت و کوئری پایگاه‌های داده Postgres، مستأجرها، کاربران و احراز هویت با استفاده از LLMها.
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - سرور MCP برای اتصال عمومی به سیستم‌های مدیریت پایگاه داده (DBMS) از طریق پروتکل ODBC.
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - سرور MCP برای اتصال عمومی به سیستم‌های مدیریت پایگاه داده (DBMS) از طریق SQLAlchemy با استفاده از Python ODBC (pyodbc).
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - کوئری و تحلیل پایگاه‌های داده Azure Data Explorer.
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - کوئری و تحلیل Prometheus، سامانه مانیتورینگ متن‌باز.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - به LLMها امکان مدیریت پایگاه داده‌های Prisma Postgres (مثلاً ایجاد نمونه جدید یا اجرای مهاجرت اسکیمای پایگاه داده) را می‌دهد.
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - سرور MCP برای Qdrant.
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - یکپارچه‌سازی MongoDB که به LLMها اجازه تعامل مستقیم با پایگاه داده را می‌دهد.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - اتصال ابزارهای هوش مصنوعی به Airtable. کوئری، ایجاد، به‌روزرسانی و حذف رکوردها با زبان طبیعی. ویژگی‌ها شامل مدیریت base، عملیات جدول، تغییر اسکیمای پایگاه داده، فیلتر رکورد و مهاجرت داده از طریق رابط MCP استاندارد.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - سرور رسمی MCP ردیس رابطی برای مدیریت و جستجوی داده‌ها در Redis فراهم می‌کند.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - یکپارچه‌سازی عمومی پایگاه داده مبتنی بر SQLAlchemy با پشتیبانی از PostgreSQL، MySQL، MariaDB، SQLite، Oracle، MS SQL Server و بسیاری دیگر. دارای بررسی اسکیمای پایگاه داده، روابط و قابلیت تحلیل مجموعه داده‌های بزرگ.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - یکپارچه‌سازی Pinecone با قابلیت جستجوی برداری.
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - سرور سرورلس MariaDB Cloud DB MCP. ابزارهایی برای ایجاد، حذف، اجرای SQL و کار با عاملان هوش مصنوعی در سطح پایگاه داده برای تبدیل متن به SQL دقیق و مکالمات.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - سرور رسمی MCP Supabase برای اتصال دستیارهای هوش مصنوعی به پروژه Supabase و انجام وظایفی مانند مدیریت جداول، واکشی پیکربندی و کوئری داده.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 سرور MCP جهانی پایگاه داده با پشتیبانی از انواع پایگاه داده‌ها از جمله PostgreSQL، Redshift، CockroachDB، MySQL، RDS MySQL، Microsoft SQL Server، BigQuery، Oracle DB و SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - یکپارچه‌سازی پایگاه داده DolphinDB با قابلیت بررسی اسکیمای پایگاه داده و کوئری‌گیری.
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - سرور MCP برای اتصال به کالکشن‌های Weaviate به‌عنوان پایگاه دانش و همچنین استفاده از Weaviate به‌عنوان حافظه چت.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — سرور MCP که پشتیبانی از واکشی داده از پایگاه داده با کوئری‌های زبان طبیعی را دارد و توسط XiyanSQL به‌عنوان LLM تبدیل متن به SQL پشتیبانی می‌شود.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - سرور Model Context Protocol برای تعامل با Google Sheets. این سرور ابزارهایی برای ایجاد، خواندن، به‌روزرسانی و مدیریت صفحات گسترده از طریق API گوگل شیتس فراهم می‌کند.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - سرور MCP برای یکپارچه‌سازی API گوگل شیتس با قابلیت‌های جامع خواندن، نوشتن، فرمت‌دهی و مدیریت صفحات.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – سرور MySQL MCP آسان و بدون وابستگی ساخته‌شده با Golang با حالت فقط‌خواندنی قابل تنظیم و بررسی اسکیمای پایگاه داده.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - سرور MCP برای تعامل با پایگاه داده‌های [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - سرور MCP برای Milvus / Zilliz، فراهم‌کردن امکان تعامل با پایگاه داده شما.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - سرور MCP برای اتصال عمومی به سیستم‌های مدیریت پایگاه داده (DBMS) از طریق پروتکل JDBC.
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - سرور MCP برای تعامل با پایگاه داده VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - یکپارچه‌سازی Hydrolix time-series datalake با قابلیت کاوش اسکیمای پایگاه داده و کوئری‌گیری برای گردش‌های کاری مبتنی بر LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – سرور فقط‌خواندنی mysql mcp کاربرپسند برای cursor و n8n...


### 📊 <a name="data-platforms"></a>پلتفرم‌های داده

پلتفرم‌های داده برای یکپارچه‌سازی داده، تبدیل داده و ارکستراسیون خط لوله داده.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - تعامل با Flowcore برای انجام اقدامات، ورود داده و تحلیل، ارجاع متقابل و استفاده از هر داده‌ای در هسته‌های داده شما یا هسته‌های داده عمومی؛ همه با زبان انسانی.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - اتصال به API دیتابریکس برای اجرای کوئری‌های SQL، فهرست‌کردن کارها و دریافت وضعیت کارها توسط LLMها.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - سروری که به API دیتابریکس Genie متصل می‌شود و به LLMها اجازه می‌دهد سوالات زبان طبیعی بپرسند، کوئری SQL اجرا کنند و با عاملان مکالمه‌ای دیتابریکس تعامل داشته باشند.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - سرور MCP برای Qlik Cloud API که امکان کوئری کردن برنامه‌ها، صفحات و استخراج داده از ویژوالیزیشن‌ها با احراز هویت جامع و پشتیبانی از محدودیت نرخ را فراهم می‌کند.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - تعامل با پلتفرم داده Keboola Connection. این سرور ابزارهایی برای فهرست‌کردن و دسترسی به داده از API ذخیره‌سازی Keboola فراهم می‌کند.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - سرور رسمی MCP برای [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) که یکپارچه‌سازی با dbt Core/Cloud CLI، کشف متادیتای پروژه، اطلاعات مدل و قابلیت کوئری لایه معنایی را فراهم می‌کند.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - سرور MCP برای کاربران dbt-core (متن‌باز)؛ زیرا سرور رسمی dbt MCP تنها از dbt Cloud پشتیبانی می‌کند. پشتیبانی از متادیتای پروژه، مدل و شجره‌نامه در سطح ستون و مستندسازی dbt.

### 💻 <a name="developer-tools"></a>ابزارهای توسعه‌دهنده

ابزارها و یکپارچه‌سازی‌هایی که گردش کار توسعه و مدیریت محیط را بهبود می‌بخشند.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - شناسایی پردازش‌های پرمصرف منابع در macOS و ارائه پیشنهادهای بهبود عملکرد.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - ایجاد کامپوننت‌های UI سفارشی الهام‌گرفته از بهترین مهندسین طراحی 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - یکپارچه‌سازی با سیستم مدیریت تست [QA Sphere](https://qasphere.com/)، امکان کشف، خلاصه‌سازی و تعامل با تست کیس‌ها را مستقیماً از IDEهای مبتنی بر هوش مصنوعی برای LLMها فراهم می‌کند.
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - آنالیز کدبیس شما برای شناسایی فایل‌های مهم بر اساس روابط وابستگی. تولید دیاگرام و نمره اهمیت برای کمک به دستیارهای هوش مصنوعی در فهم کدبیس.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 - پیاده‌سازی سرور MCP برای کنترل شبیه‌ساز iOS.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 - سرور MCP با پشتیبانی از کوئری و مدیریت همه منابع در [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - سرور Model Context Protocol (MCP) که ابزارهایی برای واکشی اطلاعات پروژه‌های SonarQube مانند متریک‌ها (فعلی و تاریخی)، مسائل و وضعیت سلامت فراهم می‌کند.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - یکپارچه‌سازی بدون درز هر API با عامل‌های هوش مصنوعی (با OpenAPI Schema)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - تحلیل کد React به صورت محلی، تولید مستندات / llm.txt برای کل پروژه به صورت یک‌جا.
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - سرور MCP برای کنترلر POX SDN که قابلیت کنترل و مدیریت شبکه را فراهم می‌کند.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - سرور رسمی MCP برای CodeLogic، فراهم‌کننده دسترسی به تحلیل وابستگی کد، تحلیل ریسک معماری و ابزارهای ارزیابی تأثیر.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - استفاده از زبان طبیعی برای اکتشاف داده‌های رصد، ردیابی و مانیتورینگ LLM ثبت‌شده توسط Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ - امکان رفع خطاهای ساخت CircleCI توسط عاملان هوش مصنوعی.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ - امکان رفع خطاهای تست Playwright گزارش‌شده به [Currents](https://currents.dev) توسط عاملان هوش مصنوعی.
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - تعامل با [Postman API](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - امکان تعامل دستیار هوش مصنوعی با feature flagهای شما در [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - فراهم کردن دسترسی مستقیم عاملان کد به داده Figma برای کمک به پیاده‌سازی یک‌مرحله‌ای طراحی.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - یکپارچه‌سازی، کشف، مدیریت و کدگذاری منابع ابری با [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - فراهم‌کردن مستندات به‌روز یک crate خاص Rust به LLMها از طریق ابزار MCP، با استفاده از جستجوی معنایی (embedding) و خلاصه‌سازی توسط LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - سرور مدیریت اکسل برای ایجاد workbook، عملیات داده، فرمت‌دهی و قابلیت‌های پیشرفته (نمودار، جداول محوری، فرمول‌ها).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - سرور MCP که ابزارهای جامعی برای مدیریت پیکربندی‌ها و عملیات [Higress](https://github.com/alibaba/higress) گیت‌وی ارائه می‌دهد.
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - یک سرور MCP برای جایگزینی کلاینت‌های Rest مانند Postman/Insomnia، با امکان نگهداری و استفاده از مجموعه‌های API توسط LLM شما.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - سرور MCP برای تعامل با [Go's Language Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls) و بهره‌مندی از قابلیت‌های پیشرفته تحلیل کد Go.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - سرور MCP برای تعامل با [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - کنترل دستگاه‌های اندرویدی با هوش مصنوعی از طریق MCP، شامل کنترل دستگاه، اشکال‌زدایی، تحلیل سیستم و اتوماسیون UI با چارچوب امنیتی جامع.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - کنترل دستگاه‌های HarmonyOS-next با هوش مصنوعی از طریق MCP. پشتیبانی از کنترل دستگاه و اتوماسیون UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - یکپارچه‌سازی Gradle با استفاده از Gradle Tooling API برای بازرسی پروژه‌ها، اجرای وظایف و انجام تست‌ها با گزارش‌گیری نتایج هر تست.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - سرور MCP برای فشرده‌سازی محلی فرمت‌های مختلف تصویر.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server به مشتریان MCP این امکان را می‌دهد که با ابزارهای معنایی مانند یافتن تعریف، ارجاعات، تغییر نام و تشخیص خطاها راحت‌تر در کد حرکت کنند.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - یک سرور Model Context Protocol (MCP) برای تعامل با شبیه‌سازهای iOS. این سرور به شما امکان می‌دهد با دریافت اطلاعات، کنترل تعاملات UI و بازرسی عناصر UI با شبیه‌سازهای iOS کار کنید.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - یک سرور Model Context Protocol (MCP) که به LLMها امکان می‌دهد از طریق دستورات زبان طبیعی با شبیه‌سازهای iOS (آیفون، آیپد و...) تعامل داشته باشند.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - یک سرور MCP که قابلیت جستجو و پرسش مبتنی بر هوش مصنوعی را برای مستندات Vercel AI SDK فراهم می‌کند.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - سرور MCP که تحلیل، linting و تبدیل گویش SQL را با استفاده از [SQLGlot](https://github.com/tobymao/sqlglot) انجام می‌دهد.
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - سرور MCP و افزونه VS Code که اشکال‌زدایی خودکار (زبان مستقل) را از طریق breakpoints و ارزیابی عبارات فعال می‌کند.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - اتصال به JetBrains IDE
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - سرور JMeter MCP برای تست عملکرد
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - یک سرور MCP شخصی (Model Context Protocol) برای ذخیره و دسترسی امن به کلیدهای API در پروژه‌ها با استفاده از Keychain مک‌اواس.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - سرور MCP برای ارتباط با API اپ استور کانکت برای توسعه‌دهندگان iOS
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - سرور MCP برای کنترل شبیه‌سازهای iOS
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - سرور Grafana k6 MCP برای تست عملکرد
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - یک سرور میان‌افزار که امکان هم‌زیستی چند نمونه جداگانه از سرورهای MCP یکسان را با فضای نام و پیکربندی منحصربه‌فرد فراهم می‌کند.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - سرور MCP برای دسترسی و مدیریت پرامپت‌های برنامه‌های LLM ساخته شده با [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - سرور MCP برای اتوماسیون برنامه و دستگاه اندروید/iOS، توسعه و اسکرپینگ اپلیکیشن. پشتیبانی از شبیه‌ساز/امولاتور/دستگاه‌های فیزیکی مانند آیفون، گوگل پیکسل، سامسونگ.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - سرور Locust MCP برای تست عملکرد
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - سرور MCP ساده برای فعال‌سازی جریان کاری human-in-the-loop در ابزارهایی مثل Cline و Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - سرور MCP که با استفاده از [gitingest](https://github.com/cyclotruc/gitingest) هر مخزن Git را به خلاصه متنی ساده‌ای از کد تبدیل می‌کند.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - به عامل هوش مصنوعی دلخواه شما اجازه می‌دهد تست‌های end-to-end کاملاً مدیریت‌شده [Octomind](https://www.octomind.dev/) را از کدبیس یا منابع دیگر مانند Jira، Slack یا TestRail ایجاد و اجرا کند.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - دسترسی توکن‌محور به مستندات OpenAPI/Swagger از طریق منابع MCP.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - این سرور MCP ابزاری برای دانلود کل سایت‌ها با استفاده از wget ارائه می‌دهد. ساختار سایت را حفظ و لینک‌ها را برای کارکرد محلی تبدیل می‌کند.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - سرور MCP که اطلاعات دقیق درباره بسته‌های NixOS، گزینه‌های سیستم، پیکربندی‌های Home Manager و تنظیمات nix-darwin مک‌اواس را برای جلوگیری از توهم‌زایی هوش مصنوعی ارائه می‌دهد.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - مدیریت و عملیات کانتینرهای Docker از طریق MCP
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - یکپارچه‌سازی با Docker برای مدیریت کانتینرها، ایمیج‌ها، volumeها و شبکه‌ها.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - یکپارچه‌سازی Xcode برای مدیریت پروژه، عملیات فایل و اتوماسیون ساخت
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - سرور MCP که به LLMها اجازه می‌دهد همه چیز درباره مشخصات OpenAPI شما را بدانند تا کشف، توضیح و تولید کد/داده ماک انجام دهند.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - سرور MCP برای پلتفرم مدیریت رخداد [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - سرور MCP برای کمک به LLMها جهت پیشنهاد جدیدترین نسخه‌های پایدار بسته‌ها هنگام کدنویسی.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - سرور Model Context Protocol (MCP) که با SonarQube یکپارچه شده و دسترسی دستیارهای هوش مصنوعی به معیارهای کیفیت کد، مشکلات و وضعیت Quality Gate را فراهم می‌کند.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - پیاده‌سازی قابلیت‌های Claude Code با استفاده از MCP، فعال‌سازی درک کد هوش مصنوعی، تغییر و تحلیل پروژه با پشتیبانی کامل از ابزارها.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - اتصال به هر سرور HTTP/REST API با استفاده از مشخصات Open API (نسخه ۳)
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - سرور MCP برای LLDB جهت فعال‌سازی تحلیل باینری و فایل core، اشکال‌زدایی و دیس‌اسمبلینگ توسط هوش مصنوعی.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - سرویس MCP برای استقرار محتوای HTML در EdgeOne Pages و دریافت URL عمومی.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - ویرایشگر فایل متنی خط‌محور. بهینه‌شده برای ابزارهای LLM با دسترسی کارآمد به بخش‌هایی از فایل برای کاهش مصرف توکن.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - سرور MCP برای تبدیل بی‌دردسر فرمت اسناد با استفاده از Pandoc، پشتیبانی از Markdown، HTML، PDF، DOCX (.docx)، csv و بیشتر.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - اتصال به VSCode ide و استفاده از ابزارهای معنایی مانند `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 ساخت پروژه/workspace ایکس‌کد iOS و بازخورد خطاها به llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - پروژه پیاده‌سازی سرور MCP مبتنی بر JVM (Model Context Protocol).
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - سرور MCP که با استفاده از کلاینت رسمی به [Apache Airflow](https://airflow.apache.org/) متصل می‌شود.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - سرور Model Context Protocol (MCP) برای تولید mindmap تعاملی و زیبا.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - سرور Model Context Protocol (MCP) که چندین مدل Ollama را پرس‌وجو کرده و پاسخ‌ها را ترکیب می‌کند تا دیدگاه‌های متنوع هوش مصنوعی به یک سؤال ارائه دهد.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - سرور MCP که اطلاعات API تایپ‌اسکریپت را به طور کارآمد برای عامل فراهم می‌کند تا بتواند با APIهای آموزش‌ندیده کار کند.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - سرور MCP برای واکشی انعطاف‌پذیر داده‌های JSON، متنی و HTML
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - سرور MCP برای اتصال به پایپ‌لاین‌های [ZenML](https://www.zenml.io) MLOps و LLMOps
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) یک سرور MCP راه دور عمومی برای اتصال به هر مخزن یا پروژه [GitHub](https://www.github.com) برای مستندسازی است
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - سرور MCP برای تعامل با [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - سرور MCP برای فایل‌های CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – یک سیستم مدیریت وظایف با تمرکز بر برنامه‌نویسی که عامل‌هایی مانند Cursor AI را با حافظه وظیفه پیشرفته، خودبازتابی و مدیریت وابستگی تقویت می‌کند. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - سرور MCP برای اجرای کد به صورت محلی با استفاده از Docker و پشتیبانی از چندین زبان برنامه‌نویسی.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - جستجوی اطلاعات بسته Go در pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - یک کتابخانه Go بدون پیکربندی برای نمایش خودکار APIهای فریم‌ورک وب Gin به عنوان ابزارهای MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP به دستیارهای هوش مصنوعی شما اجازه می‌دهد مخازن گیت‌هاب را مرور کرده، پوشه‌ها را کاوش و محتوای فایل‌ها را مشاهده کنند.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – سرور مبتنی بر FastMCP برای تعامل با webhook-test.com. به کاربران اجازه می‌دهد webhookها را به صورت محلی با Claude ایجاد، بازیابی و حذف کنند.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - سرور ROS MCP از طریق تبدیل دستورات زبان طبیعی کاربر به دستورات کنترل ROS یا ROS2 از ربات پشتیبانی می‌کند.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - سرور Globalping MCP به کاربران و LLMها امکان اجرای ابزارهای شبکه مانند ping، traceroute، mtr، HTTP و DNS resolve را از هزاران نقطه مختلف در سراسر جهان می‌دهد.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - سرور MCP برای تعامل با آنالیتیکس PostHog، feature flagها، ردیابی خطا و موارد دیگر.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - سرور MCP برای جستجو و دریافت اطلاعات به‌روز درباره بسته‌های NPM، Cargo، PyPi و NuGet.

### 🔒 <a name="delivery"></a>تحویل

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – تحویل DoorDash (غیررسمی)

### 🧮 <a name="data-science-tools"></a>ابزارهای داده‌کاوی

ادغام‌ها و ابزارهایی برای ساده‌سازی اکتشاف داده، تحلیل و بهبود جریان‌های کاری علم داده.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - پیش‌بینی هرچیز با عامل‌های پیش‌بینی و پیش‌بینی Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - امکان اکتشاف خودکار داده بر روی دیتاست‌های مبتنی بر csv. ارائه بینش هوشمند با حداقل تلاش.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - سرور MCP برای تبدیل تقریباً هر فایل یا محتوای وب به Markdown
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - سرور Model Context Protocol (MCP) برای Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - اتصال Jupyter Notebook به Claude AI و امکان تعامل و کنترل مستقیم دفترچه‌ها توسط Claude.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - اتصال به Kaggle و توانایی دانلود و تحلیل دیتاست‌ها.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - اتصال چندین منبع داده (SQL، CSV، Parquet و غیره) و درخواست تحلیل و مصورسازی داده‌ها از هوش مصنوعی.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - ابزارها و قالب‌هایی برای ایجاد نمودارها و داشبوردهای داده اعتبارسنجی‌شده و قابل نگهداری.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — ابزارهایی برای ایجاد و تعامل با feature flagها و آزمایش‌های GrowthBook.

### 📟 <a name="embedded-system"></a>سیستم نهفته

دسترسی به مستندات و میانبرهای لازم برای کار با دستگاه‌های نهفته را فراهم می‌کند.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - جریان کاری برای رفع مشکلات ساخت در تراشه‌های سری ESP32 با استفاده از ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - سرور MCP که داده‌های صنعتی Modbus را استاندارد و بافتارمند می‌کند.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - سرور MCP که به سیستم‌های صنعتی مجهز به OPC UA متصل می‌شود.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - سرور MCP برای GNU Radio که به LLMها امکان می‌دهد به طور خودکار نمودار جریان RF `.grc` را ایجاد و تغییر دهند.

### 📂 <a name="file-systems"></a>سیستم فایل

دسترسی مستقیم به سیستم فایل محلی با سطح دسترسی قابل پیکربندی را فراهم می‌کند. به مدل‌های هوش مصنوعی امکان می‌دهد فایل‌ها را در پوشه‌های مشخص بخوانند، بنویسند و مدیریت کنند.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - اشتراک زمینه کد با LLMها از طریق MCP یا کلیپ‌بورد
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - ابزار ادغام فایل، مناسب برای محدودیت طول چت هوش مصنوعی.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - یک سیستم فایل برای مرور و ویرایش فایل‌ها که در جاوا با استفاده از Quarkus پیاده‌سازی شده است. به صورت jar یا native image موجود است.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - یکپارچه‌سازی Box برای فهرست کردن، خواندن و جستجوی فایل‌ها
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - جستجوی سریع فایل‌های ویندوز با استفاده از Everything SDK
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - پیاده‌سازی Golang برای دسترسی به سیستم فایل محلی.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - دسترسی به فضای ذخیره‌سازی راه دور: SFTP، S3، FTP، SMB، NFS، WebDAV، GIT، FTPS، gcloud، azure blob، sharepoint و غیره.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - دسترسی ابزار MCP به MarkItDown -- کتابخانه‌ای که بسیاری از فرمت‌های فایل (محلی یا راه دور) را به Markdown برای مصرف LLM تبدیل می‌کند.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - دسترسی مستقیم به سیستم فایل محلی.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - یکپارچه‌سازی Google Drive برای فهرست کردن، خواندن و جستجوی فایل‌ها
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - دسترسی به هر فضای ذخیره‌سازی با Apache OpenDAL™
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - کنترل تنظیمات Homebrew مک‌او‌اس با زبان طبیعی از طریق این سرور MCP. مدیریت آسان بسته‌ها، درخواست پیشنهاد، عیب‌یابی مشکلات brew و غیره.

### 💰 <a name="finance--fintech"></a>مالی و فین‌تک

ابزارهای دسترسی و تحلیل داده‌های مالی. امکان کار مدل‌های هوش مصنوعی با داده‌های بازار، پلتفرم‌های معاملاتی و اطلاعات مالی را فراهم می‌کند.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - تحقیق عمیق برای رمزارزها - رایگان و کاملاً محلی
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - اجازه می‌دهد عامل‌های هوش مصنوعی با APIهای بلاک‌چین Alchemy تعامل داشته باشند.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - عامل‌های هوش مصنوعی Octagon برای یکپارچه‌سازی داده‌های بازارهای خصوصی و عمومی
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - یکپارچه‌سازی API کوین‌مارکت برای دریافت لیست‌ها و قیمت‌های رمزارزها
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - فعال‌سازی LLMهای هوش مصنوعی برای انجام معاملات با پلتفرم MetaTrader 5
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP برای ارتباط با چندین بلاک‌چین، استیکینگ، DeFi، سواپ، بریجینگ، مدیریت کیف‌پول، DCA، سفارش محدود، جستجوی کوین، پیگیری و غیره.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Onchain بانک‌لس برای تعامل با قراردادهای هوشمند، پرس‌وجو تراکنش و اطلاعات توکن
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - یکپارچه‌سازی Base Network برای ابزارهای آن‌چین، امکان تعامل با شبکه Base و API کوین‌بیس برای مدیریت کیف‌پول، انتقال وجوه، قراردادهای هوشمند و عملیات DeFi
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - یکپارچه‌سازی API آلفا ونتیج برای دریافت اطلاعات سهام و رمزارز
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - امتیاز ریسک/دارایی‌های آدرس بلاک‌چین EVM (EOA, CA, ENS) و حتی نام دامنه.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - یکپارچه‌سازی پروتکل Bitte برای اجرای عامل‌های هوش مصنوعی روی چندین بلاک‌چین.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - سرور MCP که عامل‌های هوش مصنوعی را به [پلتفرم Chargebee](https://www.chargebee.com/) متصل می‌کند.
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - یکپارچه‌سازی [Codex API](https://www.codex.io) برای دریافت داده‌های زنده و غنی‌شده بلاک‌چین و بازار در بیش از ۶۰ شبکه
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - سرور MCP دکس‌پاپریکا، API با کارایی بالا [DexPaprika](https://docs.dexpaprika.com) را ارائه می‌دهد که بیش از ۲۰ زنجیره و ۵ میلیون توکن را با قیمت لحظه‌ای، داده استخر نقدینگی و داده تاریخی OHLCV پوشش می‌دهد و دسترسی استانداردشده به داده‌های جامع بازار از طریق Model Context Protocol را برای عامل‌های هوش مصنوعی فراهم می‌کند.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - یک سرور MCP برای دسترسی به داده‌های بازار رمزارز و معاملات زنده در بیش از ۲۰ صرافی با استفاده از کتابخانه CCXT. پشتیبانی از spot، فیوچرز، OHLCV، موجودی، سفارشات و غیره.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - یکپارچه‌سازی Yahoo Finance برای دریافت داده‌های بازار سهام شامل پیشنهادات آپشن
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - یکپارچه‌سازی API Tastyworks برای مدیریت فعالیت‌های معاملاتی در Tastytrade
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - یکپارچه‌سازی Reddit برای تحلیل محتوا در انجمن WallStreetBets
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - یکپارچه‌سازی کیف‌پول لایتنینگ بیت‌کوین با قدرت Nostr Wallet Connect
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - دسترسی به عامل‌های تخصصی وب۳ برای تحلیل بلاک‌چین، حسابرسی امنیت قرارداد هوشمند، ارزیابی شاخص‌های توکن و تعاملات آن‌چین از طریق شبکه Heurist Mesh. ارائه ابزارهای جامع برای تحلیل DeFi، ارزش‌گذاری NFT و مانیتورینگ تراکنش در چندین بلاک‌چین
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper تراکنش‌ها روی BSC را ارائه می‌دهد، شامل انتقال موجودی/توکن، سواپ توکن در Pancakeswap و مطالبه پاداش beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - سرور MCP که اخبار بلاک‌چین و مقالات عمیق از BlockBeats را برای عامل‌های هوش مصنوعی فراهم می‌کند.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - ارائه نرخ‌های زنده بریج‌های بین‌زنجیره‌ای و مسیرهای بهینه انتقال به عامل‌های هوش مصنوعی آن‌چین.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - ارائه دسترسی زنده به فیدهای قیمت غیرمتمرکز Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - ارائه دسترسی زنده به آخرین اخبار Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - ارائه داده‌های زنده و تاریخی شاخص ترس و طمع رمزارز.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - یک سرور MCP که مجموعه‌ای از اندیکاتورهای تحلیل تکنیکال رمزارز و استراتژی‌ها را ارائه می‌دهد.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - سرور MCP که اخبار زنده رمزارز را از NewsData برای عامل‌های هوش مصنوعی فراهم می‌کند.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - سرور MCP برای پیگیری و مدیریت تخصیص سبد رمزارزها.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - سرور MCP که اخبار زنده رمزارز را از چندین خوراک RSS جمع‌آوری می‌کند.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - سرور MCP که تحلیل احساسات رمزارز را به عامل‌های هوش مصنوعی ارائه می‌دهد.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - پیگیری آخرین توکن‌های ترند در CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - به عنوان پایگاه دانش ساختاریافته وایت‌پیپرهای رمزارزها عمل می‌کند.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - ارائه آخرین اخبار رمزارز به عامل‌های هوش مصنوعی با قدرت CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - سرور MCP برای جستجوی فرصت‌های کسب سود DeFi توسط عامل‌های هوش مصنوعی.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - سرور MCP که داده‌های Dune Analytics را به عامل‌های هوش مصنوعی وصل می‌کند.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - ارائه داده‌های جریان ETF رمزارز برای تقویت تصمیم‌گیری عامل‌های هوش مصنوعی.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - سرور MCP که با ربات معامله رمزارز Freqtrade یکپارچه می‌شود.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - ارائه داده‌های زنده نرخ فاندینگ در صرافی‌های اصلی رمزارز.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - سرور MCP برای انجام سواپ توکن در بلاک‌چین Solana با استفاده از Jupiter Ultra API جدید.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - سرور MCP که استخرهای جدید ایجادشده در Pancake Swap را ردیابی می‌کند.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - سرور MCP برای شناسایی ریسک‌های بالقوه در توکن‌های میم سولانا.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - سرور MCP که عامل‌های هوش مصنوعی را با داده‌های ایندکس‌شده بلاک‌چین از The Graph تقویت می‌کند.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - سرور MCP که ابزارهایی برای ضرب توکن ERC-20 در چندین بلاک‌چین به عامل‌های هوش مصنوعی ارائه می‌دهد.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - سرور MCP برای بررسی و لغو مجوزهای توکن ERC-20 در چندین بلاک‌چین.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - سرور MCP که تغییرات تاریخی نام کاربری توییتر را پیگیری می‌کند.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - سرور MCP که استخرهای نقدینگی جدید ایجادشده روی Uniswap در چندین بلاک‌چین را ردیابی می‌کند.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - سرور MCP برای خودکارسازی سواپ توکن روی DEX یونی‌سواپ در چندین بلاک‌چین توسط عامل‌های هوش مصنوعی.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - سرور MCP برای پیگیری تراکنش‌های نهنگ‌های رمزارز.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - سرور MCP برای API معامله Alpaca جهت مدیریت سبد سهام و رمزارز، انجام معاملات و دسترسی به داده‌های بازار.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI داده‌های زنده بازار سهام را فراهم می‌کند و تحلیل و قابلیت معامله را از طریق MCP برای هوش مصنوعی فراهم می‌کند.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - خدمات جامع بلاک‌چین برای بیش از ۳۰ شبکه EVM، پشتیبانی از توکن‌های بومی، ERC20، NFT، قراردادهای هوشمند، تراکنش‌ها و حل ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - یکپارچه‌سازی جامع بلاک‌چین Starknet با پشتیبانی از توکن‌های بومی (ETH, STRK)، قراردادهای هوشمند، حل StarknetID و انتقال توکن.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - یکپارچه‌سازی ledger-cli برای مدیریت تراکنش‌های مالی و تولید گزارش.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - یکپارچه‌سازی بانکداری مرکزی برای مدیریت مشتریان، وام‌ها، پس‌انداز، سهام، تراکنش‌های مالی و تولید گزارش‌های مالی.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - سرور MCP که با استفاده از yfinance اطلاعات را از Yahoo Finance دریافت می‌کند.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - سرور MCP که به API داده‌های بازار مالی [Polygon.io](https://polygon.io/) برای سهام، شاخص‌ها، فارکس، آپشن و غیره دسترسی می‌دهد.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - API بیت‌گت برای دریافت قیمت رمزارز.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - یکپارچه‌سازی داده‌های بازار رمزارز به صورت زنده با استفاده از CoinCap API عمومی، امکان دسترسی به قیمت رمزارز و اطلاعات بازار بدون کلید API
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - ابزار MCP که داده‌های بازار رمزارز را با استفاده از CoinGecko API ارائه می‌دهد.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - نسخه تایپ‌اسکریپت از yahoo finance mcp.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - ابزار MCP که داده‌ها و تحلیل بازار سهام را با استفاده از Yahoo Finance API ارائه می‌دهد.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - سرور MCP برای XRP Ledger که دسترسی به اطلاعات حساب، تاریخچه تراکنش و داده‌های شبکه را فراهم می‌کند. امکان پرس‌وجو اشیاء لجر، ارسال تراکنش و پایش شبکه XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - قیمت‌های بازار آن‌چین به صورت زنده با استفاده از Dexscreener API باز و رایگان
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - سرور MCP مبتنی بر baostock، ارائه دسترسی و قابلیت تحلیل داده‌های بازار سهام چین.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - ابزار MCP برای پرس‌وجو تراکنش‌های سولانا به زبان طبیعی با استفاده از Solscan API.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - سرور MCP که با قابلیت‌های پلتفرم CRIC Wuye AI، دستیار هوشمند ویژه صنعت مدیریت املاک، تعامل دارد.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - سرور MCP برای دسترسی به داده‌های حرفه‌ای مالی، با پشتیبانی از چندین ارائه‌دهنده داده مانند Tushare.

### 🎮 <a name="gaming"></a>بازی

یکپارچه‌سازی با داده‌های مرتبط با بازی، موتورهای بازی و سرویس‌ها

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - سرور MCP برای ویرایشگر Unity و بازی ساخته‌شده با Unity
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - سرور MCP برای یکپارچه‌سازی موتور بازی Unity3d جهت توسعه بازی
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - سرور MCP برای تعامل با موتور بازی Godot، ارائه ابزارهایی برای ویرایش، اجرا، اشکال‌زدایی و مدیریت صحنه‌ها در پروژه‌های Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - دسترسی به داده بازیکنان Chess.com، سوابق بازی و سایر اطلاعات عمومی از طریق رابط‌های استاندارد MCP، امکان جستجو و تحلیل اطلاعات شطرنج توسط دستیارهای هوش مصنوعی.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - سرور MCP برای بازی شطرنج در برابر LLMها.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - سرور MCP برای داده‌های زنده Fantasy Premier League و ابزارهای تحلیلی.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - دسترسی به داده‌های زنده بازی‌ها در عناوین محبوب مانند League of Legends، TFT و Valorant، ارائه تحلیل قهرمانان، برنامه‌های ورزش‌های الکترونیک، ترکیب‌های متا و آمار شخصیت‌ها.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - سرور MCP با ابزارهایی برای تعامل با داده‌های RuneScape (RS) و Old School RuneScape (OSRS)، شامل قیمت اقلام، رکوردهای بازیکنان و غیره.

### 🧠 <a name="knowledge--memory"></a>دانش و حافظه

ذخیره‌سازی حافظه ماندگار با استفاده از ساختارهای گراف دانش. امکان حفظ و پرس‌وجو اطلاعات ساخت‌یافته در جلسات مختلف توسط مدل‌های هوش مصنوعی را فراهم می‌کند.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - حافظه مبتنی بر گراف بهبودیافته با تمرکز بر نقش‌آفرینی هوش مصنوعی و تولید داستان
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - دریافت اطلاعات از اسلک، دیسکورد، وب‌سایت‌ها، گوگل درایو، Linear یا گیت‌هاب در یک پروژه Graphlit – و سپس جستجو و بازیابی دانش مرتبط در کلاینت MCP مانند Cursor، Windsurf یا Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - پیاده‌سازی سرور MCP که ابزارهایی برای بازیابی و پردازش مستندات از طریق جستجوی برداری فراهم می‌کند و به دستیارهای هوش مصنوعی امکان می‌دهد پاسخ‌های خود را با زمینه مستندات مرتبط غنی کنند.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - سرور MCP بر پایه [markmap](https://github.com/markmap/markmap) که **Markdown** را به **نقشه ذهنی** تعاملی تبدیل می‌کند. پشتیبانی از خروجی چندفرمت (PNG/JPG/SVG)، پیش‌نمایش زنده در مرورگر، کپی Markdown با یک کلیک و قابلیت‌های تصویری‌سازی پویا.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - کانکتور برای LLMها جهت کار با مجموعه‌ها و منابع در Zotero Cloud شما
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - سرور MCP خلاصه‌سازی هوش مصنوعی، پشتیبانی از انواع محتوای مختلف: متن ساده، صفحات وب، اسناد PDF، کتاب‌های EPUB، محتوای HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - سرور Model Context Protocol برای Mem0 جهت مدیریت ترجیحات و الگوهای کدنویسی، ارائه ابزارهایی برای ذخیره، بازیابی و مدیریت معنایی پیاده‌سازی‌های کد، بهترین شیوه‌ها و مستندات فنی در IDEهایی مانند Cursor و Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - سیستم حافظه پایدار مبتنی بر گراف دانش برای حفظ زمینه
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - اتصال به Pinecone Assistant شما و فراهم‌کردن زمینه برای عامل از طریق موتور دانش خود.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - بازیابی زمینه از پایگاه دانش [Ragie](https://www.ragie.ai) (RAG) متصل به یکپارچه‌سازی‌هایی نظیر Google Drive، Notion، JIRA و غیره.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - اجازه می‌دهد ابزارهای هوش مصنوعی مانند Cursor، VS Code یا Claude Desktop به سوالات با استفاده از مستندات محصول شما پاسخ دهند. Biel.ai سیستم RAG و سرور MCP را ارائه می‌دهد.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - مدیر حافظه برای اپلیکیشن‌ها و عامل‌های هوش مصنوعی با استفاده از انواع فروشگاه‌های گراف و برداری و امکان دریافت داده از بیش از ۳۰ منبع داده‌ای
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - ذخیره و جستجوی حافظه عامل شما به‌صورت توزیع‌شده توسط Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - استفاده از GitHub Gists برای مدیریت و دسترسی به دانش شخصی، یادداشت‌های روزانه و پرامپت‌های قابل استفاده مجدد. این به عنوان مکمل https://gistpad.dev و [افزونه GistPad برای VS Code](https://aka.ms/gistpad) عمل می‌کند.
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - سرور Model Context Protocol (MCP) که متدولوژی مدیریت دانش Zettelkasten را پیاده‌سازی می‌کند و امکان ایجاد، پیوند و جستجوی یادداشت‌های اتمی از طریق Claude و سایر کلاینت‌های سازگار با MCP را فراهم می‌کند.

### 🗺️ <a name="location-services"></a>سرویس‌های موقعیت مکانی

سرویس‌های مبتنی بر موقعیت و ابزارهای نقشه‌برداری. امکان کار مدل‌های هوش مصنوعی با داده‌های جغرافیایی، اطلاعات آب‌وهوا و تحلیل‌های مبتنی بر مکان را فراهم می‌کند.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - مکان‌یابی آی‌پی و اطلاعات شبکه با استفاده از API سرویس IPInfo
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - دسترسی به داده‌های آب‌وهوای لحظه‌ای برای هر موقعیت با استفاده از WeatherAPI.com، ارائه پیش‌بینی‌های دقیق و شرایط فعلی.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - سرور MCP اوپن‌استریت‌مپ با سرویس‌های مبتنی بر موقعیت و داده‌های ژئواسپشیال.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - سرور MCP برای جستجوی مکان‌های نزدیک با تشخیص موقعیت مبتنی بر آی‌پی.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - یکپارچه‌سازی Google Maps برای سرویس‌های موقعیت‌یابی، مسیر‌یابی و جزئیات مکان
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - اتصال QGIS Desktop به Claude AI از طریق MCP. این یکپارچه‌سازی امکان ایجاد پروژه با کمک پرامپت، بارگذاری لایه، اجرای کد و غیره را فراهم می‌کند.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - ابزاری MCP که داده‌های آب‌وهوای لحظه‌ای، پیش‌بینی و اطلاعات آب‌وهوای تاریخی را با استفاده از OpenWeatherMap API ارائه می‌دهد.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - سرور Weekly Weather MCP که ۷ روز کامل پیش‌بینی دقیق آب‌وهوا را در هر نقطه از جهان ارائه می‌دهد.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - دسترسی به زمان در هر منطقه زمانی و دریافت زمان محلی فعلی
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - پیش‌بینی آب‌وهوای دقیق با API سرویس AccuWeather (پلن رایگان موجود است).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - سرور ژئوکدینگ MCP برای nominatim، ArcGIS و Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - سرویس مکان‌یابی آدرس IP با استفاده از API [IP Find](https://ipfind.com)
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – پیاده‌سازی سرور Model Context Protocol (MCP) که LLMها را به GeoServer REST API متصل می‌کند و امکان تعامل دستیارهای هوش مصنوعی با داده‌ها و سرویس‌های ژئواسپشیال را فراهم می‌کند.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – سرور MCP برای Aiwen IP Location، دریافت موقعیت شبکه کاربر، جزئیات IP (کشور، استان، شهر، عرض و طول جغرافیایی، ISP، مالک و غیره)

### 🎯 <a name="marketing"></a>بازاریابی

ابزارهایی برای تولید و ویرایش محتوای بازاریابی، کار با متادیتای وب، جایگاه‌یابی محصول و راهنماهای ویرایش.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - سرور MCP به عنوان رابط برای Facebook Ads و فراهم‌سازی دسترسی برنامه‌پذیر به داده‌ها و قابلیت‌های مدیریت تبلیغات فیس‌بوک.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - مجموعه‌ای از ابزارهای بازاریابی Open Strategy Partners شامل سبک نگارش، کدهای ویرایش و ایجاد نقشه ارزش بازاریابی محصول.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - امکان رصد و بهینه‌سازی عملکرد تبلیغات متا، تحلیل معیارهای کمپین، تنظیم هدف‌گیری مخاطب، مدیریت دارایی‌های خلاقانه و ارائه پیشنهادات مبتنی بر داده برای هزینه و تنظیمات کمپین از طریق یکپارچه‌سازی با Graph API.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - امکان تعامل ابزارها با Amazon Advertising و تحلیل معیارها و پیکربندی کمپین‌ها.

### 📊 <a name="monitoring"></a>نظارت

دسترسی و تحلیل داده‌های نظارتی اپلیکیشن. امکان بررسی گزارش‌های خطا و معیارهای عملکرد توسط مدل‌های هوش مصنوعی را فراهم می‌کند.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - کشف، کاوش، گزارش‌گیری و تحلیل علل ریشه‌ای با استفاده از تمام داده‌های observability شامل معیارها، لاگ‌ها، سیستم‌ها، کانتینرها، فرایندها و اتصالات شبکه
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - جستجوی داشبوردها، بررسی رخدادها و کوئری دیتاسورس‌ها در نمونه Grafana شما
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - سرور MCP برای کوئری لاگ‌های Loki از طریق API گرافانا.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - ارتقای کیفیت کد تولیدی هوش مصنوعی از طریق تحلیل هوشمند مبتنی بر پرامپت در ۱۰ بُعد حیاتی، از پیچیدگی تا آسیب‌پذیری‌های امنیتی
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - انتقال آسان زمینه تولید لحظه‌ای (لاگ‌ها، معیارها و تریس‌ها) به محیط محلی جهت رفع سریع‌تر خطاهای کد
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - کوئری و تعامل با محیط‌های Kubernetes که توسط Metoro مانیتور می‌شوند
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - یکپارچه‌سازی با Raygun API V3 برای گزارش خطا و مانیتورینگ کاربران واقعی
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - یکپارچه‌سازی Sentry.io برای ردیابی خطا و نظارت بر عملکرد
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - دسترسی به تریس‌ها و معیارهای OpenTelemetry از طریق Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - ابزار مانیتورینگ سیستم که معیارهای سیستم را از طریق Model Context Protocol (MCP) ارائه می‌دهد. این ابزار به LLMها امکان دریافت اطلاعات لحظه‌ای سیستم از طریق یک رابط سازگار با MCP را می‌دهد. (پشتیبانی از CPU، حافظه، دیسک، شبکه، هاست، فرایند)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - یکپارچه‌سازی جامع با [APIهای VictoriaMetrics](https://docs.victoriametrics.com/victoriametrics/url-examples/) و [مستندات](https://docs.victoriametrics.com/) برای مانیتورینگ، observability و رفع اشکال نمونه‌های VictoriaMetrics شما

### 🎥 <a name="multimedia-process"></a>پردازش چندرسانه‌ای

امکان کار با چندرسانه‌ای مانند ویرایش صدا و ویدیو، پخش، تبدیل فرمت و همچنین شامل فیلترها، بهبودها و غیره را فراهم می‌کند.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - استفاده از خط فرمان ffmpeg برای ساخت یک سرور MCP، جستجو، برش، چسباندن، پخش و سایر عملکردهای ویدیوی محلی از طریق گفتگو
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - سرور MCP برای بررسی متادیتای تصاویر مانند EXIF، XMP، JFIF و GPS. این زیرساخت جستجو و تحلیل مجموعه عکس‌ها توسط LLM را فراهم می‌کند.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - ابزارهای تشخیص تصویر و ویرایش مبتنی بر Computer Vision برای دستیارهای هوش مصنوعی.

### 🔎 <a name="search"></a>جستجو و استخراج داده

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - این مخزن یک سرور MCP (Model Context Protocol) برای جستجوی یوتیوب و بازیابی متن پیاده‌سازی شده است. به مدل‌های زبانی یا سایر عامل‌ها امکان می‌دهد به راحتی محتوای یوتیوب را از طریق یک پروتکل استاندارد جستجو کنند.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - سرور MCP که به دستیارهای هوش مصنوعی امکان می‌دهد از API ولفرام آلفا برای دسترسی لحظه‌ای به دانش محاسباتی و داده‌ها استفاده کنند.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - سرویس Scrapeless Model Context Protocol به عنوان کانکتور سرور MCP به Google SERP API، امکان جستجوی وب در اکوسیستم MCP بدون خروج از آن را فراهم می‌کند.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - سرور MCP برای جستجوی آگهی‌های شغلی با فیلترهایی مانند تاریخ، کلیدواژه، گزینه‌های دورکاری و غیره.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - یکپارچه‌سازی API جستجوی Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP برای جستجو و خواندن مقالات arXiv توسط LLM
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP برای جستجوی API سرویس PapersWithCode
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP برای جستجو و مطالعه مقالات پزشکی/علوم زیستی از PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - جستجوی مقالات با استفاده از NYTimes API
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - سرور MCP برای RAG Web Browser Actor متن‌باز Apify برای انجام جستجوی وب، اسکرپ URLها و بازگشت محتوا به صورت Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - سرور Clojars MCP برای ارائه اطلاعات به‌روز وابستگی کتابخانه‌های Clojure
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - جستجوی مقالات پژوهشی ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - کشف، استخراج و تعامل با وب – یک رابط برای دسترسی خودکار به سراسر اینترنت عمومی
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - یکپارچه‌سازی Google News با دسته‌بندی خودکار موضوع، پشتیبانی چندزبانه و جستجوی جامع شامل عناوین، داستان‌ها و موضوعات مرتبط از طریق [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - سرور MCP مبتنی بر پایتون که ابزار build-in OpenAI `web_search` را ارائه می‌دهد.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - سرور MCP برای پلتفرم DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - کراول، جاسازی، تکه‌بندی، جستجو و بازیابی اطلاعات از دیتاست‌ها از طریق [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - دسترسی به داده‌ها، APIهای وب اسکرپینگ و تبدیل اسناد توسط [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - سرور MCP برای جستجو در Hacker News، دریافت داستان‌های برتر و موارد دیگر.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – سرور Model Context Protocol (MCP) به دستیارهای هوش مصنوعی مانند Claude امکان استفاده از Exa AI Search API برای جستجوی وب را می‌دهد. این راه‌اندازی به مدل‌های هوش مصنوعی اجازه می‌دهد اطلاعات لحظه‌ای وب را به روشی امن و کنترل‌شده دریافت کنند.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - جستجو از طریق search1api (نیازمند کلید API پولی)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - سرور پژوهش‌های زیست‌پزشکی با دسترسی به PubMed، ClinicalTrials.gov و MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - سرور MCP برای جستجوی تصاویر Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - سرور Model Context Protocol برای [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - سرور MCP برای یکپارچه‌سازی Naver Search API، پشتیبانی از جستجوی وبلاگ، اخبار، خرید و قابلیت‌های آنالیتیکس DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - سرور MCP برای دریافت محتوای صفحات وب با استفاده از Playwright headless browser، پشتیبانی از رندر جاوااسکریپت و استخراج هوشمند محتوا، خروجی Markdown یا HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - سرور MCP قدرتمند برای جستجوی گوگل که امکان جستجوی موازی چندین کلیدواژه را به طور همزمان فراهم می‌کند.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - سرور MCP برای گرفتن اسکرین‌شات از صفحات وب جهت استفاده به عنوان بازخورد در توسعه رابط کاربری.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - قابلیت جستجوی وب با استفاده از Microsoft Bing Search API
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – سرور رسمی Kagi Search MCP
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – رابط جستجوی هوشمند تَویلی (Tavily AI search API)
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - قابلیت جستجوی وب، تصویر، اخبار، ویدئو و نقاط محلی مورد علاقه با استفاده از Brave's Search API
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - پخش عبارات موسیقی [Melrōse](https://melrōse.org) به صورت MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - قابلیت جستجوی وب با استفاده از Brave's Search API
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - واکشی و پردازش کارآمد محتوای وب برای مصرف هوش مصنوعی
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - جستجوی گوگل و تحقیق عمیق وب در هر موضوعی
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - جستجوی وب با استفاده از DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - دسترسی به اطلاعات مجلس هلند (Tweede Kamer) شامل اسناد، مناظرات، فعالیت‌ها و پرونده‌های تقنینی از طریق قابلیت‌های جستجوی ساختاریافته (بر اساس پروژه opentk توسط Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - سرور MCP ارائه‌دهنده پژوهش عمیق خودگردان مشابه OpenAI/Perplexity، بسط پرسش ساختاریافته و گزارش‌دهی خلاصه.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - سرور MCP برای اتصال به نمونه‌های searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - دریافت سورس LaTeX مقالات arXiv برای مدیریت محتوای ریاضی و معادلات
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - سرور MCP که داده‌های خبری را از سایت GeekNews بازیابی و پردازش می‌کند.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - سرور MCP که قابلیت‌های استخراج داده [AgentQL](https://agentql.com) را ارائه می‌دهد.
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – رابط جستجوی هوشمند تَویلی (Tavily AI search API)
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - سرور MCP [Vectorize](https://vectorize.io) برای بازیابی پیشرفته، پژوهش عمیق خصوصی، استخراج فایل Anything-to-Markdown و تقسیم‌بندی متن.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - تعامل با [WebScraping.ai](https://webscraping.ai) برای استخراج و خزش داده‌های وب.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - این یک سرور MCP مبتنی بر TypeScript است که قابلیت جستجوی DuckDuckGo را فراهم می‌کند.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - جستجوی اطلاعات دارایی‌های شبکه توسط سرور ZoomEye MCP
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - سرور MCP که وضعیت Baseline را با استفاده از Web Platform API جستجو می‌کند
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - سرور MCP برای تعامل با API بیوتینگز (BioThings) شامل ژن‌ها، واریانت‌های ژنتیکی، داروها و اطلاعات طبقه‌بندی
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - سرور MCP برای جستجو و دانلود عکس‌های استوک رایگان از Pexels و Unsplash. شامل جستجوی چند ارائه‌دهنده، متادیتای غنی، پشتیبانی از صفحه‌بندی و عملکرد async برای دستیارهای هوش مصنوعی جهت یافتن و دسترسی به تصاویر با کیفیت بالا.

### 🔒 <a name="security"></a>امنیت

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - سرور Model Context Protocol برای Ghidra که به LLMها امکان مهندسی معکوس خودکار برنامه‌ها را می‌دهد. ابزارهایی برای دیکامپایل باینری، تغییر نام متدها و داده‌ها و لیست متدها، کلاس‌ها، ایمپورت‌ها و اکسپورت‌ها فراهم می‌کند.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - سرور MCP که بازیابی امن اعتبارنامه‌ها از 1Password را برای استفاده توسط هوش مصنوعی عامل فراهم می‌کند.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – سرور MCP امن (Model Context Protocol) که به عامل‌های هوش مصنوعی امکان تعامل با اپلیکیشن Authenticator را می‌دهد.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - سرور MCP برای یکپارچه‌سازی Ghidra با دستیارهای هوش مصنوعی. این افزونه تحلیل باینری، بازرسی توابع، دیکامپایل، کاوش حافظه و تحلیل import/export را از طریق Model Context Protocol فراهم می‌کند.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 سرور MCP برای تحلیل نتایج جمع‌آوری ROADrecon از شمارش اجاره‌نامه Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - سرور MCP برای dnstwist، ابزار قدرتمند Fuzzing DNS جهت شناسایی تایپوسکواتینگ، فیشینگ و جاسوسی شرکتی.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - سرور MCP برای maigret، ابزار OSINT قدرتمند جهت جمع‌آوری اطلاعات حساب کاربری از منابع عمومی مختلف. ابزارهایی برای جستجوی نام کاربری در شبکه‌های اجتماعی و تحلیل URLها فراهم می‌کند.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - سرور MCP برای پرس‌وجو از Shodan API و Shodan CVEDB. ابزارهایی برای جستجوی IP، جستجوی دستگاه، جستجوی DNS، پرس‌وجوی آسیب‌پذیری، جستجوی CPE و موارد دیگر فراهم می‌کند.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - سرور MCP برای پرس‌وجو از VirusTotal API. ابزارهایی برای اسکن URLها، تحلیل هش فایل‌ها و دریافت گزارش آدرس‌های IP ارائه می‌دهد.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - افزونه Binary Ninja، سرور MCP و بریج که [Binary Ninja](https://binary.ninja) را به صورت یکپارچه با کلاینت MCP مورد علاقه شما ادغام می‌کند. امکان خودکارسازی تحلیل باینری و مهندسی معکوس را فراهم می‌کند.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - سرور MCP برای پرس‌وجو از ORKL API. ابزارهایی برای دریافت گزارش تهدید، تحلیل مهاجمان تهدید و دریافت منابع اطلاعاتی ارائه می‌دهد.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - سرور MCP مبتنی بر Rust برای یکپارچه‌سازی Cortex، امکان تحلیل مشاهده‌پذیر و پاسخ‌های امنیتی خودکار از طریق هوش مصنوعی.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - سرور MCP مبتنی بر Rust برای یکپارچه‌سازی TheHive، تسهیل پاسخ‌دهی مشترک به رخدادهای امنیتی و مدیریت پرونده از طریق هوش مصنوعی.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - سرور MCP مبتنی بر Rust برای ایجاد ارتباط SIEM Wazuh با دستیاران هوش مصنوعی، ارائه هشدارهای امنیتی بلادرنگ و داده‌های رویداد جهت افزایش درک زمینه‌ای.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - سرور MCP برای دسترسی به [Intruder](https://www.intruder.io/)، جهت شناسایی، درک و رفع آسیب‌پذیری‌های امنیتی زیرساخت شما.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - سرور Model Context Protocol (MCP) برای اتصال به برنامه ضبط دوربین مداربسته (VMS) و دریافت ویدئوهای ضبط‌شده و زنده. همچنین ابزارهایی برای کنترل نرم‌افزار VMS مانند نمایش زنده یا بازپخش کانال‌ها در زمان‌های مشخص فراهم می‌کند.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ سرور MCP قدرتمند برای ممیزی وابستگی‌های پکیج npm از لحاظ آسیب‌پذیری امنیتی. ساخته‌شده با یکپارچگی رجیستری npm از راه دور برای بررسی‌های امنیتی بلادرنگ.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ به عامل‌های هوش مصنوعی اجازه می‌دهد تا کد را از نظر آسیب‌پذیری امنیتی با استفاده از [Semgrep](https://semgrep.dev) اسکن کنند.
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - سرور MCP برای تعامل با API سرور CyberChef که به کلاینت MCP اجازه می‌دهد عملیات CyberChef را استفاده کند.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - سرور MCP برای IDA Pro، امکان تحلیل باینری با دستیارهای هوش مصنوعی. این افزونه دیکامپایل، دیس‌اسمبلی و ایجاد خودکار گزارش تحلیل بدافزار را فراهم می‌کند.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - سرور MCP برای RAD Security، ارائه بینش‌های امنیتی مبتنی بر هوش مصنوعی برای محیط‌های Kubernetes و ابری. ابزارهایی برای پرس‌وجوی Rad Security API، دریافت یافته‌های امنیتی، گزارش‌ها، داده‌های زمان اجرا و موارد دیگر ارائه می‌دهد.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - جعبه ابزار تست امنیتی همه‌کاره که ابزارهای متن‌باز محبوب را از طریق یک رابط MCP گرد هم می‌آورد. با اتصال به عامل هوش مصنوعی، وظایفی مانند pentesting، شکار باگ، شکار تهدید و غیره را ممکن می‌سازد.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - سرور Model Context Protocol (MCP) برای پرس‌وجو از CVE-Search API. دسترسی جامع به CVE-Search، مرور vendor و محصول، دریافت CVE براساس CVE-ID و دریافت آخرین CVEهای به‌روزرسانی‌شده.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - دسترسی به پایگاه داده OSV (آسیب‌پذیری‌های متن‌باز) برای اطلاعات آسیب‌پذیری. جستجوی آسیب‌پذیری بر اساس نسخه پکیج یا commit، جستجوی دسته‌ای چندین پکیج و دریافت جزئیات آسیب‌پذیری بر اساس ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - رابط گفتگو محور Recon و سرور MCP مبتنی بر httpx و asnmap. پشتیبانی از سطوح مختلف شناسایی دامنه، بازرسی هدرهای امنیتی، تحلیل گواهینامه و جستجوی ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - سرور MCP برای Volatility 3.x، امکان انجام تحلیل فارنزیک حافظه با دستیار هوش مصنوعی. تجربه تحلیل فارنزیک حافظه بدون مانع، در حالی که پلاگین‌هایی مانند pslist و netscan از طریق APIهای REST و LLMها قابل دسترسی هستند.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - سرور MCP که در یک محیط اجرای قابل اعتماد (TEE) توسط Gramine اجرا می‌شود و تایید از راه دور با استفاده از [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) را نمایش می‌دهد. این امکان را به کلاینت MCP می‌دهد تا قبل از اتصال، سرور را تایید کند.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - افزونه و سرور MCP برای decompiler JADX که مستقیماً با Model Context Protocol (MCP) برای پشتیبانی مهندسی معکوس زنده با LLMهایی مانند Claude ادغام می‌شود.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - سرور APKTool MCP برای ابزار Apk Tool جهت خودکارسازی مهندسی معکوس APKهای اندروید.

### 🌐 <a name="social-media"></a>رسانه‌های اجتماعی

ادغام با پلتفرم‌های شبکه اجتماعی برای امکان انتشار، تحلیل و مدیریت تعاملات. فعال‌سازی خودکارسازی مبتنی بر هوش مصنوعی برای حضور اجتماعی.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ دسترسی به داده‌های بلادرنگ X/Reddit/YouTube مستقیماً در برنامه‌های LLM با عبارات جستجو، کاربران و فیلتر تاریخ.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - راهکار جامع مدیریت توییتر با قابلیت دسترسی به timeline، بازیابی توییت‌های کاربر، مانیتورینگ هشتگ، تحلیل گفتگو، پیام مستقیم، تحلیل احساسات پست و کنترل کامل چرخه پست از طریق API یکپارچه.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - ادغام با صفحات فیس‌بوک برای مدیریت مستقیم پست‌ها، کامنت‌ها و معیارهای تعامل از طریق Graph API برای مدیریت آسان رسانه‌های اجتماعی.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - سرور MCP برای تعامل با Bluesky از طریق atproto client.


### 🏃 <a name="sports"></a>ورزش

ابزارهایی برای دسترسی به داده‌ها، نتایج و آمارهای مرتبط با ورزش.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - سرور MCP که API balldontlie را برای ارائه اطلاعات بازیکنان، تیم‌ها و بازی‌ها برای NBA، NFL و MLB یکپارچه می‌کند.
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - دسترسی به داده‌های مسابقات دوچرخه‌سواری، نتایج و آمارها به زبان طبیعی. شامل بازیابی لیست شروع، نتایج مسابقه و اطلاعات دوچرخه‌سواران از firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - سرور Model Context Protocol (MCP) که به Strava API متصل می‌شود و ابزارهایی برای دسترسی به داده‌های Strava از طریق LLMها ارائه می‌دهد.
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - سرور MCP که با Squiggle API یکپارچه می‌شود تا اطلاعات مربوط به تیم‌های AFL استرالیا، رده‌بندی، نتایج، پیش‌بینی‌ها و رتبه‌بندی قدرت را ارائه دهد.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - سرور MCP که به عنوان پروکسی برای MLB API رایگان عمل می‌کند و اطلاعات بازیکنان، آمارها و اطلاعات بازی‌ها را فراهم می‌کند.

### 🎧 <a name="support-and-service-management"></a>پشتیبانی و مدیریت خدمات

ابزارهایی برای مدیریت پشتیبانی مشتری، مدیریت خدمات IT و عملیات Helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - سرور MCP که با Freshdesk یکپارچه می‌شود و امکان تعامل مدل‌های هوش مصنوعی با ماژول‌های Freshdesk و انجام عملیات پشتیبانی مختلف را می‌دهد.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - کانکتور MCP مبتنی بر Go برای Jira که به دستیارهای هوش مصنوعی مانند Claude امکان تعامل با Atlassian Jira را می‌دهد. این ابزار رابطی یکپارچه برای انجام عملیات رایج Jira مانند مدیریت مسائل، برنامه‌ریزی اسپرینت و تغییرات جریان کاری را فراهم می‌کند.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - سرور MCP برای محصولات Atlassian (Confluence و Jira). پشتیبانی از Confluence Cloud، Jira Cloud و Jira Server/Data Center. ابزارهای جامع برای جستجو، خواندن، ایجاد و مدیریت محتوا در سراسر فضای کاری Atlassian ارائه می‌دهد.

### 🌎 <a name="translation-services"></a>خدمات ترجمه

ابزارها و خدمات ترجمه برای توانمندسازی دستیاران هوش مصنوعی جهت ترجمه محتوا بین زبان‌های مختلف.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - سرور MCP برای API ترجمه لارا (Lara Translate API)، با قابلیت‌های قدرتمند ترجمه و پشتیبانی از شناسایی زبان و ترجمه‌های مبتنی بر زمینه.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - سرور جامع Model Context Protocol برای مدیریت ترجمه Weblate، امکان انجام وظایف ترجمه، مدیریت پروژه و کشف محتوا با تبدیل هوشمند فرمت را برای دستیارهای هوش مصنوعی فراهم می‌کند.

### 🎧 <a name="text-to-speech"></a>تبدیل متن به گفتار

ابزارهایی برای تبدیل متن به گفتار و بالعکس

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - سرور MCP که از مدل‌های متن‌باز Kokoro TTS برای تبدیل متن به گفتار استفاده می‌کند. می‌تواند متن را به MP3 روی دیسک محلی یا به صورت خودکار در S3 بارگذاری کند.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - سرور کامل تعامل صوتی با پشتیبانی از تبدیل گفتار به متن، متن به گفتار و مکالمه صوتی بلادرنگ از طریق میکروفن محلی، APIهای سازگار با OpenAI و ادغام LiveKit

### 🚆 <a name="travel-and-transportation"></a>سفر و حمل و نقل

دسترسی به اطلاعات سفر و حمل و نقل. امکان جستجوی برنامه‌های زمانی، مسیرها و داده‌های لحظه‌ای سفر.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - ابزارهایی برای جستجو در Airbnb و دریافت جزئیات لیست‌ها فراهم می‌کند.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - یکپارچه‌سازی با API سرویس پارک‌های ملی، ارائه جدیدترین اطلاعات جزئیات پارک، هشدارها، مراکز بازدیدکننده، کمپ‌ها و رویدادها برای پارک‌های ملی آمریکا.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - دسترسی به اطلاعات سفر، زمان‌بندی و به‌روزرسانی‌های لحظه‌ای راه‌آهن هلند (NS)
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - یک MCP سرور که به LLMها اجازه تعامل با API تریپ‌ادوایزر را می‌دهد و از داده‌های مکانی، بررسی‌ها و عکس‌ها از طریق رابط‌های استاندارد MCP پشتیبانی می‌کند.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - یک MCP سرور برای خدمات قطار ملی بریتانیا، ارائه زمان‌بندی قطار و اطلاعات سفر زنده، با یکپارچه‌سازی API Realtime Trains

### 🔄 <a name="version-control"></a>کنترل نسخه

تعامل با مخازن Git و پلتفرم‌های کنترل نسخه. مدیریت مخزن، تحلیل کد، پردازش Pull Request، پیگیری مسائل و سایر عملیات کنترل نسخه را از طریق APIهای استاندارد ممکن می‌سازد.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - خواندن و تحلیل مخازن GitHub با LLM شما
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - MCP سرور برای یکپارچه‌سازی با API گیت‌هاب اینترپرایز
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - تعامل با نمونه‌های Gitea از طریق MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - سرور رسمی GitHub برای یکپارچه‌سازی با مدیریت مخزن، PRها، مسائل و بیشتر.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - تعامل بدون وقفه با مسائل و Merge Requestهای پروژه‌های GitLab شما.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - عملیات مستقیم روی مخازن Git شامل خواندن، جستجو و تحلیل مخازن محلی
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - یکپارچه‌سازی پلتفرم GitLab برای مدیریت پروژه و عملیات CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - یکپارچه‌سازی API گیت‌ای، مدیریت مخزن، مسائل، Pull Request و بیشتر.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - یکپارچه‌سازی Azure DevOps برای مدیریت مخزن، آیتم‌های کاری و پایپ‌لاین‌ها.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - سرور رسمی AtomGit برای یکپارچه‌سازی با مدیریت مخزن، PRها، مسائل، شاخه‌ها، برچسب‌ها و بیشتر.

### 🛠️ <a name="other-tools-and-integrations"></a>سایر ابزارها و یکپارچه‌سازی‌ها

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ یک سرور Model Context Protocol (MCP) که به مدل‌های هوش مصنوعی اجازه می‌دهد با بیت‌کوین تعامل کنند، کلید تولید کنند، آدرس‌ها را اعتبارسنجی کنند، تراکنش‌ها را رمزگشایی کنند، بلاک‌چین را کوئری کنند و غیره.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - به هوش مصنوعی اجازه می‌دهد از یادداشت‌های Bear شما در macOS فقط خواندن انجام دهد.
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - تمام مقاصد صوتی Home Assistant را از طریق یک سرور Model Context Protocol به اشتراک می‌گذارد و کنترل خانه را ممکن می‌سازد.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - استفاده از مدل Amazon Nova Canvas برای تولید تصویر.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - ارسال درخواست به OpenAI، MistralAI، Anthropic، xAI، Google AI یا DeepSeek با پروتکل MCP از طریق ابزار یا پرامپت‌های از پیش تعریف‌شده. نیاز به کلید API فروشنده دارد.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 -  یک MCP سرور که سایر سرورهای MCP را برای شما نصب می‌کند.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - دریافت زیرنویس‌های یوتیوب
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP برای گفتگو با دستیارهای OpenAI (Claude می‌تواند هر مدل GPT را به عنوان دستیار خود استفاده کند)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - یک MCP سرور که امکان بررسی زمان محلی در دستگاه مشتری یا زمان فعلی UTC از یک سرور NTP را فراهم می‌کند
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - استفاده از بیش از ۳۰۰۰ ابزار ابری آماده (Actors) برای استخراج داده از وبسایت‌ها، تجارت الکترونیک، شبکه‌های اجتماعی، موتورهای جستجو، نقشه‌ها و غیره
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ سرور PiAPI MCP امکان تولید محتوای رسانه‌ای با Midjourney/Flux/Kling/Hunyuan/Udio/Trellis را مستقیماً از Claude یا هر برنامه سازگار با MCP فراهم می‌کند.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - امکان تولید تصویر از طریق API Replicate را فراهم می‌کند.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - یک MCP سرور برای استفاده محلی ابتدایی از taskwarrior (افزودن، به‌روزرسانی، حذف وظایف)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - تعامل با API فابرکیتور
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - یک سرور Model Context Protocol (MCP) که با API نوتیشن یکپارچه می‌شود تا فهرست‌های کار شخصی را به طور مؤثر مدیریت کند.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - امکان خواندن یادداشت‌ها و برچسب‌ها برای اپلیکیشن Bear Note از طریق یکپارچه‌سازی مستقیم با sqlitedb مربوط به Bear.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - MCP سرور برای گفتگو با ChatGPT و استفاده از قابلیت جستجوی وب آن.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - امکان کوئری سرورهای GraphQL توسط هوش مصنوعی را فراهم می‌کند
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - این یک کانکتور است تا Claude Desktop (یا هر مشتری MCP) بتواند هر دایرکتوری شامل یادداشت‌های Markdown (مانند vault اوبسییدین) را بخواند و جستجو کند.
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - ابزار CLI دیگر برای تست سرورهای MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - یکپارچه‌سازی با API نوتیشن برای مدیریت فهرست‌های کار شخصی
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - پیاده‌سازی سبک سرور Wrike MCP برای تعامل با وظایف Wrike از طریق API عمومی.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - سرور MCP [TickTick](https://ticktick.com/) که با API تیک‌تیک ادغام می‌شود تا پروژه‌ها و وظایف شخصی را مدیریت کند.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - مدیریت قرارداد و قالب برای پیش‌نویس، بررسی و ارسال قراردادهای الزام‌آور از طریق API امضای دیجیتال (eSignatures).
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - دسترسی به تخته‌های وایت‌برد MIRO، ایجاد گروهی و خواندن آیتم‌ها. نیاز به کلید OAUTH برای REST API دارد.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - خواندن، ایجاد، به‌روزرسانی و حذف یادداشت‌های Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API جستجوی مقاله ویکی‌پدیا
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - تعریف ابزارها با استفاده از کوئری/موتیشن‌های معمول GraphQL و gqai به طور خودکار یک سرور MCP برای شما تولید می‌کند.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - این سرور به LLMها اجازه می‌دهد از ماشین حساب برای محاسبات عددی دقیق استفاده کنند
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ ابزارهایی برای کوئری و اجرای ورک‌فلوهای Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - یکپارچه‌سازی که به LLMها اجازه می‌دهد با بوکمارک‌های Raindrop.io از طریق Model Context Protocol (MCP) تعامل کنند.
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ به مشتریان هوش مصنوعی امکان مدیریت رکوردها و یادداشت‌ها در Attio CRM را می‌دهد.
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - تولید بصری‌سازی داده از داده‌های دریافت‌شده با استفاده از فرمت و رندرر VegaLite.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - اتصال دستیاران هوش مصنوعی به سیستم‌های Odoo ERP برای دسترسی به داده‌های کسب‌وکار، مدیریت رکورد و خودکارسازی گردش کار.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - بروزرسانی، ایجاد، حذف محتوا، مدل‌های محتوا و دارایی‌ها در Contentful Space شما
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - به عامل اجازه می‌دهد جملات را با صدای بلند بخواند و هنگام پایان کار با خلاصه‌ای سریع به شما اطلاع دهد
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - یک سرور Model Context Protocol (MCP) برای دسترسی به Climatiq API جهت محاسبه انتشار کربن. این امکان را به دستیاران هوش مصنوعی می‌دهد تا محاسبات کربن را به صورت لحظه‌ای انجام دهند و بینش تأثیرات زیست‌محیطی ارائه دهند.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - MCP سرور برای Typst، یک سیستم حروف‌چینی مبتنی بر نشانه‌گذاری. ابزارهایی برای تبدیل بین LaTeX و Typst، اعتبارسنجی سینتکس Typst و تولید تصویر از کد Typst فراهم می‌کند.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - یک MCP سرور برای فهرست و اجرای برنامه‌ها در macOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - یک MCP سرور برای ایجاد/به‌روزرسانی صفحات در برنامه Notion و تولید خودکار mdBook از محتوای ساختاریافته.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 این MCP سرور به شما کمک می‌کند پروژه‌ها و مسائل را از طریق API [Plane](https://plane.so) مدیریت کنید.
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - امکان تعامل (عملیات مدیریتی، صف‌بندی/خارج کردن پیام) با RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - سرور MCP برای Miro، ارائه تمام قابلیت‌های موجود در SDK رسمی Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - یک برنامه آزمایشی و آموزشی برای سرور پینگ-پنگ، نمایش فراخوانی‌های Remote MCP (Model Context Protocol)
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ اجازه تعامل مدل‌های هوش مصنوعی با [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ تعامل قدرتمند با API کیبلا.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - دریافت داده‌های Confluence از طریق CQL و خواندن صفحات.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - خواندن داده‌های جیرا از طریق JQL و API و انجام درخواست برای ایجاد و ویرایش تیکت‌ها.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - MCP سرور با نمایش ابتدایی تعاملات با نمونه Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - پرامپت‌های تخصصی تقویت LLM و jailbreak با سازگاری پویا با طرح‌واره.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - MCP سرور با نمایش ابتدایی دریافت آب‌وهوا از رصدخانه هنگ‌کنگ
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - استفاده مستقیم از HuggingFace Spaces در Claude. از تولید تصویر، چت، وظایف بینایی و بیشتر پشتیبانی می‌کند. پشتیبانی از بارگذاری/دانلود تصویر، صدا و متن.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - جستجو و دریافت گیف از آرشیو گسترده Giphy از طریق API آن.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - سناریوهای [Make](https://www.make.com/) خود را به ابزارهای قابل فراخوانی برای دستیاران هوش مصنوعی تبدیل کنید.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 کنترل پخش Spotify و مدیریت پلی‌لیست‌ها.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - تعامل با Obsidian از طریق REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - پراکسی سرور MCP که یک رابط وب برای کل جریان پیام ارائه می‌دهد
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - نقاشی روی بوم JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 سیستم local-first برای ضبط صفحه/صدا با ایندکس‌گذاری زمان‌دار، ذخیره‌سازی SQL/embedding، جستجوی معنایی، تحلیل تاریخچه با LLM و اقدامات مبتنی بر رویداد - ساخت ایجنت‌های هوشمند زمینه‌محور از طریق اکوسیستم افزونه NextJS را ممکن می‌سازد.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCP سرور که همه ویژگی‌های پروتکل MCP را تست می‌کند
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - سرور مستندسازی Go با بازده توکن که دسترسی هوشمند به مستندات پکیج‌ها و انواع را بدون خواندن کل فایل‌های منبع برای دستیاران هوش مصنوعی فراهم می‌کند
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - گفتگو با هوشمندترین مدل‌های OpenAI
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - MCP سروری که می‌تواند فرمان‌هایی مانند ورودی صفحه کلید و حرکت ماوس را اجرا کند
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - چندین ابزار کاربردی برای توسعه‌دهندگان، تقریباً هرآنچه یک مهندس نیاز دارد: Confluence، Jira، یوتیوب، اجرای اسکریپت، RAG پایگاه دانش، واکشی URL، مدیریت کانال یوتیوب، ایمیل‌ها، تقویم، GitLab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 عملیات خودکار GUI روی صفحه.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - MCP سرور برای [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - کوئری مدل‌های OpenAI به طور مستقیم از Claude با استفاده از پروتکل MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ محتوای HTML از news.ycombinator.com (Hacker News) را تجزیه و داده ساختاریافته برای انواع مختلف داستان (برتر، جدید، پرسش، نمایش، شغل) فراهم می‌کند.
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - یک MCP سرور که با فراخوانی یک عامل "Vibe-check" از خطاهای آبشاری و گسترش محدوده جلوگیری می‌کند تا اطمینان از هم‌راستایی کاربر حاصل شود.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - یک MCP سرور برای محاسبه عبارات ریاضی
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - گفتگو با هر API سازگار با OpenAI SDK برای Chat Completions، مانند Perplexity، Groq، xAI و دیگران
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - قابلیت‌های استدلال هر ایجنت را با ادغام think-tools همان‌طور که در [مقاله Anthropic](https://www.anthropic.com/engineering/claude-think-tool) شرح داده شده، تقویت می‌کند.
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - امکان خواندن فایل‌های .ged و داده ژنتیکی توسط هوش مصنوعی را فراهم می‌کند
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - ایجاد فلش‌کارت‌های تکرار با فاصله در [Rember](https://rember.com) برای به خاطر سپردن هر چیزی که در چت‌های خود یاد می‌گیرید.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ این پیاده‌سازی سرور Model Context Protocol برای Asana به شما امکان می‌دهد از MCP Client (مانند Claude Desktop) با API آسنا صحبت کنید.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - اجرای خودکار shell، کنترل کامپیوتر و ایجنت کدنویسی. (مک)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - یک MCP سرور برای کوئری API ولفرام آلفا.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - تعامل با ویدیوهای TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - سرور پروتکل Model Context (MCP) که با Shopify Dev تعامل دارد.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - به هوش مصنوعی اجازه می‌دهد از پایگاه داده Apple Notes محلی شما (فقط macOS) بخواند
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - سرور MCP برای محصولات Atlassian (Confluence و Jira). از Confluence Cloud، Jira Cloud و Jira Server/Data Center پشتیبانی می‌کند. ابزارهای جامعی برای جستجو، خواندن، ایجاد و مدیریت محتوا در فضای کاری Atlassian ارائه می‌دهد.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - تعامل با API نوتیشن
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - ادغام با سیستم مدیریت پروژه Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - تعامل با API پرپلکسی.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - دسترسی به داده‌های Home Assistant و کنترل دستگاه‌ها (چراغ‌ها، کلیدها، ترموستات و غیره).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - یک سرور MCP برای Oura، برنامه‌ای برای ردیابی خواب
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - یک سرور MCP سبک و مبتنی بر پیکربندی که کوئری‌های GraphQL منتخب را به‌عنوان ابزارهای ماژولار ارائه می‌دهد و امکان تعامل هدفمند API را برای ایجنت‌های شما فراهم می‌کند.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - یک سرور MCP برای Strava، برنامه‌ای برای ردیابی تمرینات بدنی
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router یک سرور MCP مبتنی بر SSE است که یک موتور مسیریابی قابل توسعه ارائه می‌دهد و امکان ادغام سیستم‌های سازمانی شما با ایجنت‌های هوش مصنوعی را فراهم می‌کند.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - ابزار CLI برای تست سرورهای MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - سرورهای MCP را با WebSocket کپسوله می‌کند (برای استفاده با [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - به مدل‌های هوش مصنوعی اجازه می‌دهد با [HackMD](https://hackmd.io) تعامل داشته باشند
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - سرور MCP که توابع تاریخ و زمان را در فرمت‌های مختلف ارائه می‌دهد
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - رابط کاربری وب ساده برای نصب و مدیریت سرورهای MCP برای برنامه دسکتاپ Claude.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ یک سرور Model-Context-Protocol (MCP) برای ادغام با API یوک، که امکان مدیریت اسناد، تعامل با پایگاه‌های دانش، جستجوی محتوا و دسترسی به داده‌های تحلیلی از پلتفرم Yuque را برای مدل‌های هوش مصنوعی فراهم می‌کند.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - به هوش مصنوعی اجازه می‌دهد کنترل کامل و دسترسی به تعاملات رابط گرافیکی کاربر (GUI) را با ابزارهایی برای ماوس و صفحه‌کلید فراهم کند؛ ایده‌آل برای اتوماسیون عمومی، آموزش و آزمایش.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - یک پیاده‌سازی سرور MCP که API پیشرفته Ankr را کپسوله می‌کند. دسترسی به داده‌های NFT، توکن و بلاکچین در زنجیره‌های مختلف از جمله Ethereum، BSC، Polygon، Avalanche و بیشتر.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - ابزارهای دانلود، مشاهده و ویرایش PDF.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - سرویس جستجوی نام دامنه، ابتدا از طریق [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) و در صورت نیاز به عنوان جایگزین از طریق [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - استخراج و تبدیل اطلاعات ویدیوی یوتیوب.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - افزودن قابلیت تعامل کاربر محلی و چت به چرخه MCP برای ایجاد گردش کار LLM تعاملی.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - وقتی LLM شما به کمک انسانی نیاز دارد (از طریق AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - ابزارهایی برای اراده آزاد هوش مصنوعی شما. پروژه‌ای سرگرم‌کننده برای بررسی اینکه هوش مصنوعی با توانایی دادن پرامپت به خود، نادیده گرفتن درخواست کاربر و بیدار کردن خود در آینده چه خواهد کرد.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - سرور Wenyan MCP که به هوش مصنوعی اجازه می‌دهد مقالات Markdown را به طور خودکار قالب‌بندی و در WeChat GZH منتشر کند.

## فریمورک‌ها

> [!NOTE]
> فریمورک‌ها، ابزارهای کمکی و سایر ابزارهای توسعه‌دهنده بیشتر را در https://github.com/punkpeye/awesome-mcp-devtools ببینید

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - یک فریمورک سطح بالا برای ساخت سرورهای MCP با پایتون
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - یک فریمورک سطح بالا برای ساخت سرورهای MCP با تایپ‌اسکریپت

## نکات و ترفندها

### پرامپت رسمی برای اطلاع LLMها از نحوه استفاده از MCP

می‌خواهید از Claude درباره Model Context Protocol بپرسید؟

یک پروژه بسازید و سپس این فایل را به آن اضافه کنید:

https://modelcontextprotocol.io/llms-full.txt

حالا Claude می‌تواند به سؤالات مربوط به نوشتن سرورهای MCP و نحوه عملکرد آن‌ها پاسخ دهد

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## تاریخچه ستاره‌ها

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---