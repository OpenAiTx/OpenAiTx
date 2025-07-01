![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

شما می‌توانید [مقاله من](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) را مطالعه کنید و به این صورت به آن ارجاع دهید:
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

به دلیل اینکه گیت‌هاب ممکن است دسترسی آی‌پی‌های چینی را مسدود کند، مجبور شدم این مخزن را به [اینجا](https://codeberg.org/ufo5260987423/scheme-langserver) و [اینجا](https://gitee.com/ufo5260987423/scheme-langserver) کپی کنم. من به‌طور مستمر همه مخازن را به‌روزرسانی خواهم کرد اما نمی‌توانم تضمین کنم. اکنون همچنین با [XmacsLabs](https://github.com/XmacsLabs) همکاری می‌کنم و می‌توانید فورک را نیز [اینجا](https://github.com/XmacsLabs/scheme-langserver) پیدا کنید.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**اکنون، VSCode می‌تواند از scheme-langserver استفاده کند!** لطفاً به [اینجا مراجعه کنید](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>توجه: باگ‌های بسیار زیادی در scheme-langserver وجود دارد. من در حال رفع آن‌ها هستم و از جامعه درخواست کمک دارم. لطفاً صبور باشید.

>توجه: می‌توانید اطلاعات نوع (type) تولید شده به صورت خودکار را [اینجا](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) پیدا کنید. فعلاً این اطلاعات بیشتر برای توسعه مرحله بعدی (شاید شامل AKKU) و اشکال‌زدایی استفاده می‌شود.

پیاده‌سازی قابلیت‌هایی مانند تکمیل خودکار، رفتن به تعریف، یا نمایش مستندات هنگام قرار گرفتن موس روی یک عنصر، تلاشی چشمگیر برای برنامه‌نویسی محسوب می‌شود. اما در مقایسه با زبان‌هایی مانند جاوا، پایتون، جاوااسکریپت و سی، پیاده‌سازی پروتکل سرور زبان برای زبان‌های لیسپ تقریباً در خلأ صورت گرفته است. [Geiser](https://gitlab.com/emacs-geiser)، [racket langserver](https://github.com/jeapostrophe/racket-langserver) و [swish-lint](https://github.com/becls/swish-lint) و غیره، همگی بر اساس `repl` (حلقه خواندن-ارزیابی-نمایش) یا توکنایزر کلیدواژه به جای برنامه‌نویسی واقعی ساخته شده‌اند. برای مثال، اگر برنامه‌نویسی روی پروژه‌ای ناتمام کد می‌نوشت که کدهایش هنوز کاملاً قابل اجرا نبود، [Geiser](https://gitlab.com/emacs-geiser) یا سایر ابزارها فقط شناسه‌های اتصال سطح بالا را که توسط رویه `environment-symbols` (برای [Chez](https://cisco.github.io/ChezScheme/)) فهرست شده‌اند، تکمیل می‌کردند یا تنها نمادها را به جای شناسه‌ها کامل می‌کردند. این بدان معناست که برای اتصال‌های محلی و کدهای ناتمام، با وجود اینکه تلاش برای برنامه‌نویسی باید اهمیت بالایی داشته باشد، [Geiser](https://gitlab.com/emacs-geiser) و همتایانش هیچ کمکی به شناسایی حوزه معتبر شناسه‌ها نمی‌کنند. موارد مشابهی با رفتن به تعریف و بسیاری قابلیت‌های دیگر رخ می‌دهد.

یکی از دلایل اصلی این است که برای اسکیم و دیگر گویش‌های لیسپ، مجموعه داده‌های فراوان و ساختارهای کنترل انعطاف‌پذیر، تحلیل برنامه را به یک چالش بزرگ تبدیل می‌کند. به ویژه ماکروها، به نظر می‌رسد که اسکیم عمدتاً برای برنامه‌نویسی نابغه و متا/ماکرو استفاده می‌شود. اما من این را قبول ندارم. اسکیم می‌تواند کارهای جالب زیادی انجام دهد اگر محیط برنامه‌نویسی بهتری فراهم شود. و اکنون شما می‌توانید [**از اینجا شروع کنید**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

این پکیج، پیاده‌سازی پروتکل سرور زبان برای کمک به برنامه‌نویسی اسکیم است. این ابزار قابلیت‌هایی مانند تکمیل، رفتن به تعریف و استنتاج نوع را فراهم می‌کند. این قابلیت‌ها بر پایه تحلیل ایستا (استاتیک) کد با [استاندارد r6rs](http://www.r6rs.org/) و برخی قوانین واضح برای کدهای ناتمام بنا شده‌اند. خود این بسته و کتابخانه‌های مرتبط منتشر شده یا قرار است با [Akku](https://akkuscm.org/) که مدیر بسته اسکیم است، منتشر شوند.

این بسته همچنین با نسخه‌های 9.4 و 9.5 [Chez Scheme](https://cisco.github.io/ChezScheme/) تست شده است. تست دقیق روی نسخه 10.0.0 پس از ارتقاء سیستم عامل لپ‌تاپم به نسخه جدیدتر انجام خواهد شد.

من این کار اوپن سورس را فقط در اوقات فراغت انجام می‌دهم و می‌توانم ایده‌های درخشانی را به جامعه ارائه دهم، مانند تلفیق تحلیل جریان داده در scheme-langserver یا بسیاری موارد دیگر. و به طور پیوسته درخواست کمک مالی و حمایت بیشتری دارم. می‌توانید با [این صفحه پاترئون](https://www.patreon.com/PoorProgrammer/membership) یا [爱发电](https://afdian.com/a/ufo5260987423) کمک مالی کنید.


## کامپایل، نصب و پیکربندی [اینجا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) قرار دارد

## وضعیت اخیر
من به رفع باگ‌ها، پروفایل کردن کد و جمع‌آوری اطلاعات برای کتاب عظیمم درباره سیستم استنتاج نوع خانگی ادامه خواهم داد. این کار حدود یک سال زمان می‌برد. توسعه‌های بیشتر شامل یک افزونه برای [VScode](https://code.visualstudio.com/) و تحلیل جریان داده خواهد بود. اما در واقع، اکنون این کار اوپن سورس را به عنوان یک کار پاره وقت قرار داده‌ام و نمی‌توانم برنامه زمانی را تضمین کنم.

## انتشار
1.2.9 اکنون از استنتاج نوع لذت ببرید!

برای نسخه‌های قبلی لطفاً به [این فایل](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) مراجعه کنید.

### ویژگی‌ها
1. تکمیل اتصال شناسه‌های سطح بالا و محلی.
![تکمیل اتصال شناسه‌های سطح بالا و محلی](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. رفتن به تعریف.
![رفتن به تعریف با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. سازگار با مدیر بسته: Akku.
4. همگام‌سازی تغییرات فایل و تغییر شاخص مربوطه.
5. نمایش اطلاعات هنگام قرار گرفتن موس (Hover).
6. مراجع و برجسته‌سازی اسناد (مراجع در محدوده سند).
![یافتن مراجع با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. نماد سند (Document symbol).
![یافتن نمادهای سند با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. گرفتن اتصال شناسه محلی مبتنی بر *-syntax (مانند define-syntax، let-syntax و غیره).
9. ایندکس‌گذاری موازی چندسکویی (Cross-platform).
10. حاشیه‌نویس کد منحصربه‌فرد جهت سازگاری با فایل‌های .sps.
11. بهینه‌سازی peephole برای درخواست‌های API با وظایف قابل تعلیق.
12. استنتاج نوع با مفسر DSL خانگی (به آن بسیار افتخار می‌کنم!). و اکنون در تکمیل خودکار نیز تعبیه شده است. همانطور که شکل زیر نشان می‌دهد، "length-b" و "length-a" که نوع "integer?" دارند، در ابتدای گزینه‌های پیشنهادی قرار می‌گیرند چون می‌توانند با نوع پارامتری که از "<=" نیاز دارد، مطابقت داشته باشند.
![تکمیل خودکار با استنتاج نوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
یک تست می‌تواند این نتیجه را اثبات کند، فقط کافی است دستور `scheme --script tests/protocol/apis/test-completion.sps` را اجرا کنید و فایل لاگ `scheme-langserver.log` نتایجی مانند زیر خواهد داشت:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. مفسر انتزاعی برای گرفتن شناسه در بین پسوندهای فایل مختلف مانند scm، ss، sps، sls و sld.

### کارهای در دست انجام (TODOs)
14. تغییر نام (Renaming).
15. سازگاری کامل با [استاندارد r6rs](http://www.r6rs.org/).
16. گسترش‌دهنده ماکرو مرحله به مرحله: در واقع من یکی را پیاده‌سازی کرده‌ام و می‌خواستم آن را به عنوان کلیدی برای گرفتن اتصال شناسه در ماکروهای خودتعریف‌شده استفاده کنم. اکنون می‌بینم که این کار بسیار سخت‌تر از چیزی است که فکر می‌کردم و نمی‌دانم این گسترش‌دهنده کجا می‌تواند کار کند.
17. ارزیابی کد.
18. تشخیص کد.
19. افزودن پشتیبانی معنایی بین‌زبانی. آیا جاوا، سی، پایتون و بسیاری زبان‌های دیگر می‌توانند با یک AST transformer پشتیبانی شوند؟
20. استخراج عبارت‌ها/دستورات به یک رویه.

## کارهای در دست انجام: مشارکت (Contributing)

## اشکال‌زدایی (Debug)

### نحوه اشکال‌زدایی
https://www.scheme.com/debug/debug.html#g1

### خروجی لاگ
با دنبال کردن نکات [ساخت](#building)، [نصب برای Lunar Vim](#installation-for-lunarvim) و [نصب برای VScode](#todo-installation-for-vscode)، اگر کسی بخواهد کمی توسعه دهد و چیزی لاگ کند، راحت است که `path-to-log-file` را اضافه کند و فایل `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` را به صورت زیر بازنویسی کند:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
```
}
```
### اجرای مکرر با Log 
با استفاده از [log خروجی](#output-log) بالا، می‌توانید برای اشکال‌زدایی‌های مکرر از `tests/log-debug.sps` استفاده کنید:
1. نام فایل log خود را از `{path-to-log}` (معمولاً `~/scheme-langserver.log`) به `~/ready-for-analyse.log` تغییر دهید؛
2. فرمان `scheme --script tests/log-debug.sps` را اجرا کنید. اگر می‌خواهید محیط چندریسمانی را بازتولید کنید، اجرای `scheme --script tests/log-debug.sps` نیز ممکن است.

## تست
تقریباً همه رویه‌ها و APIهای کلیدی تست شده‌اند. کار من بسیار ابتدایی اما کاربردی است، شاید بخواهید آنچه را که انجام داده‌ام در پوشه `tests` بیابید یا فقط دستور زیر را در `{scheme-langserver-root-directory}` اجرا کنید:
``` bash
bash test.sh
```
>توجه
تست کردن در محیط چندریسمانی دشوار است. بنابراین، تست‌های فعلی بر روی تک ریسمان تمرکز دارند.

## استفاده از Scheme-langserver برای اهداف دیگر
### Script-Fu در GIMP
Script-Fu بر پایه زبان تفسیری Scheme است و با استفاده از توابعی که با توابع داخلی GIMP تعامل دارند کار می‌کند. با استفاده از اسکریپت [این صفحه](https://dalelane.co.uk/blog/?p=628) به عنوان مثال، می‌توانید scheme-langserver را با فایل اسکریپت با پسوند "SCM" به کار ببرید.

### سایر موارد

خوب، من همچنین به [OMN (Opusmodus Notation)](https://opusmodus.com/) و AutoLisp علاقه‌مندم. اما هنوز کارهای زیادی برای انجام دادن دارم.

## شمارش کد
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## مستندات دقیق
1. [Scheme-langserver: ویرایش کد Scheme به عنوان یک دغدغه درجه‌یک](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [گرفتن binding شناسه‌ها](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [همگام‌سازی](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [استنتاج نوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(منسوخ شده و در حال نوشتن یک کتاب چینی برای آن هستم)
5. [تحلیل API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## مشارکت‌کنندگان

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---