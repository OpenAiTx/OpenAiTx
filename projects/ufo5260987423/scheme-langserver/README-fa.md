<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">انگلیسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![پرسش از DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

شما می‌توانید [مقاله من](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) را بخوانید و به این صورت ارجاع دهید:
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

به دلیل اینکه ممکن است GitHub آدرس‌های IP چینی را مسدود کند، من مجبور شدم این مخزن را به [اینجا](https://codeberg.org/ufo5260987423/scheme-langserver) و [اینجا](https://gitee.com/ufo5260987423/scheme-langserver) کپی کنم. من به‌صورت مستمر همه مخازن را به‌روزرسانی خواهم کرد اما نمی‌توانم تضمین کنم. اکنون همچنین با [XmacsLabs](https://github.com/XmacsLabs) همکاری می‌کنم، می‌توانید یک fork را [اینجا](https://github.com/XmacsLabs/scheme-langserver) نیز پیدا کنید.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**اکنون VSCode می‌تواند از scheme-langserver استفاده کند!** لطفاً به [اینجا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) مراجعه کنید.

>توجه: اشکالات زیادی در scheme-langserver وجود دارد. من در حال رفع آن‌ها هستم و از جامعه درخواست کمک دارم. لطفاً صبور باشید.

>توجه: شما می‌توانید اطلاعات نوع به‌صورت خودکار تولید شده را [اینجا](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) پیدا کنید. این اطلاعات در حال حاضر عمدتاً برای توسعه مراحل بعدی (شاید شامل AKKU) و رفع اشکال استفاده می‌شود.

پیاده‌سازی پشتیبانی مانند تکمیل خودکار، رفتن به تعریف، یا نمایش مستندات هنگام قرار گرفتن ماوس روی آن، یک کار بزرگ برای برنامه‌نویسی است. با این حال، در مقایسه با زبان‌هایی مانند جاوا، پایتون، جاوااسکریپت و سی، پیاده‌سازی پروتکل سرور زبان برای زبان‌های لیسپ صرفاً در خلاء انجام شده است. [Geiser](https://gitlab.com/emacs-geiser)، [racket langserver](https://github.com/jeapostrophe/racket-langserver) و [swish-lint](https://github.com/becls/swish-lint) و غیره، همه این ابزارها بر اساس `repl` (حلقه خواندن-ارزیابی-نمایش) یا توکنایزر کلیدواژه کار می‌کنند، نه برنامه‌نویسی. برای مثال، اگر یک برنامه‌نویس بر روی پروژه‌ای ناتمام کار کند که کدهای آن به طور کامل قابل اجرا نباشد، [Geiser](https://gitlab.com/emacs-geiser) یا سایر ابزارها فقط شناسه‌های سطح بالا را که با رویه `environment-symbols` (برای [Chez](https://cisco.github.io/ChezScheme/)) فهرست شده‌اند تکمیل می‌کنند، یا فقط نمادها را به جای شناسه‌ها تکمیل می‌کنند. این بدان معناست که برای بایندینگ‌های محلی و کدهای ناقص، با وجود اینکه تلاش برای برنامه‌نویسی اهمیت زیادی دارد، [Geiser](https://gitlab.com/emacs-geiser) و نمونه‌های مشابه آن کمکی به شناسایی دامنه معتبر شناسه‌ها نمی‌کنند. موارد مشابهی برای رفتن به تعریف و بسیاری قابلیت‌های دیگر نیز رخ می‌دهد.

یکی از دلایل اصلی این است که برای اسکیم و سایر گویش‌های لیسپ، مجموعه داده‌های فراوان و ساختارهای کنترلی انعطاف‌پذیر، تحلیل برنامه را به یک چالش بزرگ تبدیل می‌کند. به‌ویژه ماکروها؛ به نظر می‌رسد اسکیم عمدتاً برای برنامه‌نویسی نابغه‌وار و متا/ماکرو استفاده می‌شود. اما من می‌گویم اینطور نیست. اسکیم می‌تواند کارهای جالب بسیاری انجام دهد اگر محیط برنامه‌نویسی بهتری فراهم شود. و اکنون می‌توانید [**از اینجا شروع کنید**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

این پکیج یک پیاده‌سازی پروتکل سرور زبان است که به برنامه‌نویسی اسکیم کمک می‌کند. این پکیج تکمیل خودکار، تعریف و استنباط نوع را فراهم می‌کند. این قابلیت‌ها بر اساس تحلیل ایستا بر روی کد با [استاندارد r6rs](http://www.r6rs.org/) و برخی قوانین آشکار برای کدهای ناقص بنا شده‌اند. این پکیج و کتابخانه‌های مرتبط با آن منتشر شده‌اند یا قرار است با [Akku](https://akkuscm.org/)، که یک مدیریت بسته برای اسکیم است، منتشر شوند.

این پکیج همچنین با [Chez Scheme](https://cisco.github.io/ChezScheme/) نسخه‌های ۹.۴ و ۹.۵ تست شده است. یک تست دقیق بر روی نسخه ۱۰.۰.۰ پس از ارتقاء سیستم عامل لپ‌تاپ من به نسخه جدیدتر انجام خواهد شد.

من این کار متن‌باز را فقط در اوقات فراغت انجام می‌دهم و می‌توانم ایده‌های درخشانی را به جامعه ارائه دهم، مانند تعبیه تحلیل جریان داده در scheme-langserver یا موارد بسیار دیگر. و من به طور مداوم درخواست کمک مالی بیشتر یا سرمایه‌گذاری دارم. شما می‌توانید از طریق [این صفحه Patreon](https://www.patreon.com/PoorProgrammer/membership) یا [爱发电](https://afdian.com/a/ufo5260987423) کمک مالی کنید.

## کامپایل، نصب و پیکربندی [اینجا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) است

## وضعیت اخیر
من به رفع اشکالات، پروفایل کد و جمع‌آوری اطلاعات برای کتاب عظیمم درباره سیستم استنباط نوع خانگی ادامه خواهم داد. این کار حدود ۱ سال طول خواهد کشید. توسعه‌های بعدی شامل افزونه [VScode](https://code.visualstudio.com/) و تحلیل جریان داده است. اما در واقع، من اکنون این کار متن‌باز را به‌عنوان شغل پاره‌وقت قرار داده‌ام و نمی‌توانم برنامه زمانی مشخصی تضمین کنم.

## انتشار
1.2.9 اکنون از استنباط نوع لذت ببرید!

انتشارهای قبلی را لطفاً در [این فایل](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) ببینید.

### قابلیت‌ها
1. تکمیل بایندینگ شناسه‌های سطح بالا و محلی.
![تکمیل بایندینگ شناسه‌های سطح بالا و محلی](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. رفتن به تعریف.
![رفتن به تعریف با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. سازگار با مدیریت بسته: Akku.
4. همگام‌سازی تغییرات فایل و تغییر ایندکس مربوطه.
5. نمایش اطلاعات هنگام قرار گرفتن ماوس (Hover).
6. ارجاعات و برجسته‌سازی مستندات (ارجاعات در محدوده سند).
![یافتن ارجاعات با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. نمادهای سند.
![یافتن نمادهای سند با telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. شناسایی بایندینگ شناسه محلی مبتنی بر *-syntax (define-syntax, let-syntax و غیره).
9. ایندکس‌گذاری موازی چندسکویی.
10. حاشیه‌نویس کد منبع اختصاصی برای سازگاری با فایل‌های .sps.
11. بهینه‌سازی peephole برای درخواست‌های API با وظیفه قابل تعلیق.
12. استنباط نوع با مفسر DSL خانگی (به آن بسیار افتخار می‌کنم!). و اکنون در تکمیل خودکار نیز تعبیه شده است. همانطور که در شکل زیر نشان داده شده است، "length-b" و "length-a" که نوع "integer?" دارند در ابتدای گزینه‌های پیشنهادی قرار گرفته‌اند زیرا می‌توانند با نوع پارامتری که "<=" نیاز دارد، مطابقت داشته باشند.
![تکمیل خودکار با استنباط نوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
یک تست می‌تواند این نتیجه را اثبات کند، کافیست `scheme --script tests/protocol/apis/test-completion.sps` را اجرا کنید و فایل گزارش `scheme-langserver.log` نتایجی مانند زیر را شامل خواهد شد:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. مفسر انتزاعی برای شناسایی شناسه میان پسوندهای مختلف فایل مانند scm، ss، sps، sls و sld.

### کارهای آینده (TODOs)
14. تغییر نام.
15. سازگاری کامل با [استاندارد r6rs](http://www.r6rs.org/).
16. گسترش‌دهنده ماکرو مرحله به مرحله: در واقع یکی پیاده‌سازی کرده‌ام و می‌خواستم آن را به عنوان گام کلیدی در شناسایی بایندینگ شناسه در ماکروهای خودتعریف قرار دهم. اکنون متوجه شده‌ام که این شناسایی بسیار سخت‌تر از آن چیزی است که فکر می‌کردم و نمی‌دانم این گسترش‌دهنده کجا می‌تواند مفید واقع شود.
17. ارزیابی کد.
18. عیب‌یابی کد.
19. افزودن پشتیبانی معنایی بین‌زبانی. خب، آیا جاوا، سی، پایتون و بسیاری زبان‌های دیگر می‌توانند با یک مبدل AST پشتیبانی شوند؟
20. استخراج عبارات/دستورات به یک رویه.

## TODO: مشارکت

## اشکال‌زدایی

### نحوه اشکال‌زدایی
https://www.scheme.com/debug/debug.html#g1

### خروجی لاگ
با توجه به نکات [ساخت](#building)، [نصب برای Lunar Vim](#installation-for-lunarvim) و [نصب برای VScode](#todo-installation-for-vscode)، اگر کسی بخواهد توسعه‌ای انجام دهد و چیزی را لاگ کند، راحت است که `path-to-log-file` را اضافه کرده و فایل `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` را به صورت زیر بازنویسی کند:
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
`scheme-langserver`، یک پیاده‌سازی پروتکل سرور زبان برای Scheme
]]   ,
  },
}
```
### تکرار با لاگ
با استفاده از [خروجی لاگ](#output-log) بالا، می‌توانید با فایل `tests/log-debug.sps` اشکالات را دوباره تکرار کنید:
1. نام `{path-to-log}` (معمولاً `~/scheme-langserver.log`) را به `~/ready-for-analyse.log` تغییر دهید؛
2. دستور `scheme --script tests/log-debug.sps` را اجرا کنید. اگر می‌خواهید محیط چندریسمانی را بازتولید کنید، می‌توانید همین دستور را اجرا کنید.

## تست
تقریباً تمام رویه‌ها و APIهای کلیدی تست شده‌اند. کار من بسیار ابتدایی ولی مفید است، شاید بخواهید آنچه را که انجام داده‌ام در پوشه `tests` پیدا کنید یا فقط دستور زیر را در `{scheme-langserver-root-directory}` اجرا کنید:
``` bash
bash test.sh
```
>توجه
تست در محیط چندریسمانی دشوار است. بنابراین تست‌های فعلی روی تک‌ریسمان تمرکز دارند.

## استفاده از Scheme-langserver برای اهداف دیگر
### Script-Fu در GIMP
Script-Fu مبتنی بر یک زبان تفسیری به نام Scheme است و با استفاده از توابعی که با توابع داخلی GIMP تعامل دارند، کار می‌کند. با استفاده از اسکریپت [این صفحه](https://dalelane.co.uk/blog/?p=628) به عنوان مثال، می‌توانید scheme-langserver را برای فایل‌های اسکریپت با پسوند "SCM" به کار ببرید.

### سایر موارد

خب، من همچنین به [OMN (Opusmodus Notation)](https://opusmodus.com/) و AutoLisp علاقه‌مندم. اما هنوز کارهای زیادی برای انجام دادن دارم.

## شمارش کد
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## مستندات جزئی
1. [Scheme-langserver: ویرایش کد Scheme به عنوان نگرانی درجه اول](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [شناسایی اتصال‌دهنده‌ها](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [همگام‌سازی](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [استنتاج نوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(منسوخ شده و من در حال نوشتن یک کتاب چینی درباره آن هستم)
5. [تحلیل API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## مشارکت‌کنندگان

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---