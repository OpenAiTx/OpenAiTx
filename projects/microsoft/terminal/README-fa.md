![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![وضعیت ساخت ترمینال](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# به مخزن Windows Terminal، کنسول و خط فرمان خوش آمدید

<details>
  <summary><strong>فهرست مطالب</strong></summary>

- [نصب و اجرای Windows Terminal](#installing-and-running-windows-terminal)
  - [فروشگاه مایکروسافت \[توصیه‌شده\]](#microsoft-store-recommended)
  - [سایر روش‌های نصب](#other-install-methods)
    - [از طریق گیت‌هاب](#via-github)
    - [از طریق Windows Package Manager CLI (معروف به winget)](#via-windows-package-manager-cli-aka-winget)
    - [از طریق Chocolatey (غیررسمی)](#via-chocolatey-unofficial)
    - [از طریق Scoop (غیررسمی)](#via-scoop-unofficial)
- [نصب Windows Terminal Canary](#installing-windows-terminal-canary)
- [نقشه راه Windows Terminal](#windows-terminal-roadmap)
- [مروری بر ترمینال و کنسول](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [میزبان کنسول ویندوز](#the-windows-console-host)
  - [اجزای مشترک](#shared-components)
  - [ایجاد Windows Terminal جدید](#creating-the-new-windows-terminal)
- [منابع](#resources)
- [سؤالات متداول](#faq)
  - [ترمینال جدید را ساختم و اجرا کردم اما شبیه کنسول قدیمی است](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [مستندات](#documentation)
- [مشارکت](#contributing)
- [ارتباط با تیم](#communicating-with-the-team)
- [راهنمای توسعه‌دهنده](#developer-guidance)
- [پیش‌نیازها](#prerequisites)
- [ساخت کد](#building-the-code)
  - [ساخت در PowerShell](#building-in-powershell)
  - [ساخت در Cmd](#building-in-cmd)
- [اجرا و دیباگ](#running--debugging)
  - [راهنمای کدنویسی](#coding-guidance)
- [منشور رفتار](#code-of-conduct)

</details>

<br />

این مخزن شامل کد منبع برای موارد زیر است:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* میزبان کنسول ویندوز (`conhost.exe`)
* اجزای مشترک بین این دو پروژه
* [ColorTool](./src/tools/ColorTool)
* [پروژه‌های نمونه](./samples)
  که نحوه استفاده از APIهای کنسول ویندوز را نشان می‌دهند

مخازن مرتبط شامل موارد زیر هستند:

* [مستندات Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([مخزن: مشارکت در مستندات](https://github.com/MicrosoftDocs/terminal))
* [مستندات API کنسول](https://github.com/MicrosoftDocs/Console-Docs)
* [فونت Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## نصب و اجرای Windows Terminal

> [!توجه]
> Windows Terminal به ویندوز ۱۰ نسخه ۲۰۰۴ (بیلد ۱۹۰۴۱) یا جدیدتر نیاز دارد

### فروشگاه مایکروسافت [توصیه‌شده]

[Windows Terminal را از فروشگاه مایکروسافت][store-install-link] نصب کنید.
این روش به شما اجازه می‌دهد همیشه هنگام انتشار نسخه‌های جدید، به صورت خودکار به جدیدترین نسخه ارتقا پیدا کنید.

این روش مورد ترجیح ما است.

### سایر روش‌های نصب

#### از طریق گیت‌هاب

برای کاربرانی که امکان نصب Windows Terminal از فروشگاه مایکروسافت را ندارند،
نسخه‌های منتشر شده را می‌توان به صورت دستی از [صفحه انتشار](https://github.com/microsoft/terminal/releases) این مخزن دانلود کرد.

فایل `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` را از بخش **Assets** دانلود کنید.
برای نصب برنامه، کافیست روی فایل `.msixbundle` دوبار کلیک کنید تا نصب‌کننده به طور خودکار اجرا شود.
اگر به هر دلیلی این کار انجام نشد، می‌توانید دستور زیر را در PowerShell اجرا کنید:

```powershell
# توجه: اگر از PowerShell 7 یا جدیدتر استفاده می‌کنید،
# قبل از استفاده از Add-AppxPackage،
# Import-Module Appx -UseWindowsPowerShell
# را اجرا کنید.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!توجه]
> اگر ترمینال را به صورت دستی نصب می‌کنید:
>
> * ممکن است لازم باشد [بسته VC++ v14 Desktop Framework](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) را نصب کنید.
>   این مورد فقط در نسخه‌های قدیمی‌تر ویندوز ۱۰ و تنها زمانی که خطایی درباره بسته‌های چارچوب دریافت می‌کنید لازم است.
> * ترمینال پس از انتشار نسخه‌های جدید به صورت خودکار بروزرسانی نمی‌شود، بنابراین باید به طور منظم جدیدترین نسخه را نصب کنید تا همه اصلاحات و بهبودها را دریافت کنید!

#### از طریق Windows Package Manager CLI (معروف به winget)

کاربران [winget](https://github.com/microsoft/winget-cli) می‌توانند نسخه جدید ترمینال را با نصب بسته `Microsoft.WindowsTerminal` دانلود و نصب کنند:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!توجه]
> پشتیبانی از وابستگی‌ها در نسخه WinGet [1.6.2631 یا جدیدتر](https://github.com/microsoft/winget-cli/releases) موجود است. برای نصب نسخه پایدار ترمینال ۱.۱۸ یا بالاتر، لطفاً مطمئن شوید که نسخه به‌روزشده کلاینت WinGet را دارید.

#### از طریق Chocolatey (غیررسمی)

کاربران [Chocolatey](https://chocolatey.org) می‌توانند نسخه جدید ترمینال را با نصب بسته `microsoft-windows-terminal` دانلود و نصب کنند:

```powershell
choco install microsoft-windows-terminal
```

برای بروزرسانی Windows Terminal با استفاده از Chocolatey، دستور زیر را اجرا کنید:

```powershell
choco upgrade microsoft-windows-terminal
```

اگر هنگام نصب/بروزرسانی بسته با مشکلی مواجه شدید، لطفاً به
[صفحه بسته Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) مراجعه کرده و
[فرآیند رسیدگی Chocolatey](https://chocolatey.org/docs/package-triage-process) را دنبال کنید.

#### از طریق Scoop (غیررسمی)

کاربران [Scoop](https://scoop.sh) می‌توانند نسخه جدید ترمینال را با نصب بسته `windows-terminal` دانلود و نصب کنند:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

برای بروزرسانی Windows Terminal با استفاده از Scoop، دستور زیر را اجرا کنید:

```powershell
scoop update windows-terminal
```

اگر هنگام نصب/بروزرسانی بسته با مشکلی مواجه شدید، لطفاً در [صفحه مشکلات](https://github.com/lukesampson/scoop-extras/issues) مخزن Scoop Extras جستجو یا گزارش دهید.

---

## نصب Windows Terminal Canary

Windows Terminal Canary نسخه شبانه از Windows Terminal است. این نسخه آخرین کد از شاخه `main` ما را دارد و به شما امکان می‌دهد ویژگی‌ها را پیش از عرضه رسمی امتحان کنید.

Windows Terminal Canary ناپایدارترین نسخه ما است، بنابراین ممکن است باگ‌هایی پیدا کنید که ما هنوز متوجه آن نشده‌ایم.

Windows Terminal Canary به صورت App Installer و نسخه فشرده قابل حمل (Portable ZIP) عرضه می‌شود.

نسخه App Installer از بروزرسانی خودکار پشتیبانی می‌کند. به دلیل محدودیت‌های پلتفرم، این نصب‌کننده فقط روی ویندوز ۱۱ کار می‌کند.

نسخه Portable ZIP یک برنامه قابل حمل است. به صورت خودکار بروزرسانی نمی‌شود و به‌روزرسانی‌ها را بررسی نمی‌کند. این نسخه روی ویندوز ۱۰ (۱۹۰۴۱+) و ویندوز ۱۱ کار می‌کند.

| توزیع        | معماری          | لینک                                                    |
|--------------|:---------------:|---------------------------------------------------------|
| App Installer| x64, arm64, x86 | [دانلود](https://aka.ms/terminal-canary-installer)      |
| Portable ZIP | x64             | [دانلود](https://aka.ms/terminal-canary-zip-x64)        |
| Portable ZIP | ARM64           | [دانلود](https://aka.ms/terminal-canary-zip-arm64)      |
| Portable ZIP | x86             | [دانلود](https://aka.ms/terminal-canary-zip-x86)        |

_درباره [انواع توزیع‌های Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions) بیشتر بدانید._

---

## نقشه راه Windows Terminal

برنامه Windows Terminal [در اینجا توضیح داده شده است](/doc/roadmap-2023.md) و با پیشرفت پروژه به‌روزرسانی خواهد شد.

## مروری بر ترمینال و کنسول

لطفاً قبل از ورود به کد، چند دقیقه وقت بگذارید و مروری بر مطالب زیر داشته باشید:

### Windows Terminal

Windows Terminal یک برنامه ترمینال جدید، مدرن، غنی از امکانات و بهره‌ور برای کاربران خط فرمان است. این برنامه شامل بسیاری از ویژگی‌های پرتقاضای جامعه خط فرمان ویندوز مانند پشتیبانی از تب‌ها، متن غنی، جهانی‌سازی، قابلیت پیکربندی، تم‌دهی و استایل‌دهی و موارد دیگر است.

ترمینال همچنین باید اهداف و معیارهای ما را برای اطمینان از سریع و کارآمد بودن و مصرف نکردن مقدار زیادی حافظه یا انرژی برآورده کند.

### میزبان کنسول ویندوز

میزبان کنسول ویندوز، `conhost.exe`، تجربه کاربری اصلی خط فرمان ویندوز است. همچنین میزبان زیرساخت خط فرمان ویندوز و سرور API کنسول ویندوز، موتور ورودی، موتور رندرینگ، ترجیحات کاربر و غیره است. کد میزبان کنسول در این مخزن، همان منبعی است که `conhost.exe` ویندوز از آن ساخته می‌شود.

از زمان تصاحب خط فرمان ویندوز در سال ۲۰۱۴، تیم ویژگی‌های جدیدی به کنسول اضافه کرده است، از جمله شفافیت پس‌زمینه، انتخاب خطی، پشتیبانی از [توالی‌های ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code)، [رنگ ۲۴ بیتی](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/)، یک [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) و موارد دیگر.

با این حال، به دلیل هدف اصلی کنسول ویندوز که حفظ سازگاری با گذشته است، ما نتوانسته‌ایم بسیاری از ویژگی‌هایی را که جامعه (و تیم) طی سال‌های اخیر خواستار آن بوده‌اند، مانند تب‌ها، متن یونیکد و ایموجی اضافه کنیم.

این محدودیت‌ها ما را به ایجاد Windows Terminal جدید سوق داد.

> می‌توانید درباره تکامل خط فرمان به طور کلی و خط فرمان ویندوز به طور خاص در [این مجموعه پست‌های وبلاگ](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) تیم خط فرمان مطالعه کنید.

### اجزای مشترک

هنگام بازسازی کنسول ویندوز، ما کد آن را به طور قابل توجهی مدرن کردیم، موجودیت‌های منطقی را به طور تمیز به ماژول‌ها و کلاس‌ها جدا کردیم، چندین نقطه گسترش کلیدی معرفی کردیم، چندین مجموعه و کانتینر قدیمی را با [کانتینرهای STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) ایمن‌تر و کارآمدتر جایگزین کردیم و کد را با استفاده از [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) ساده‌تر و ایمن‌تر ساختیم.

این بازسازی منجر به آن شد که چندین جزء کلیدی کنسول برای استفاده مجدد در هر پیاده‌سازی ترمینال در ویندوز در دسترس قرار گیرد. این اجزا شامل موتور رندرینگ و طرح‌بندی متن مبتنی بر DirectWrite، بافر متنی که می‌تواند هر دو UTF-16 و UTF-8 را ذخیره کند، پارسر/خروجی‌ساز VT و غیره است.

### ایجاد Windows Terminal جدید

هنگام برنامه‌ریزی برنامه Windows Terminal جدید، ما چندین رویکرد و فناوری را بررسی کردیم. در نهایت تصمیم گرفتیم اهداف ما با ادامه سرمایه‌گذاری در کد C++ ما بهتر محقق می‌شود؛ رویکردی که امکان استفاده مجدد از اجزای مدرن‌سازی‌شده مذکور را هم در کنسول فعلی و هم در ترمینال جدید فراهم می‌کند. همچنین متوجه شدیم که این کار به ما اجازه می‌دهد بخش زیادی از هسته ترمینال را به عنوان کنترل UI قابل استفاده مجدد بسازیم که دیگران نیز بتوانند آن را در برنامه‌های خود بگنجانند.

نتیجه این کار در این مخزن قرار دارد و به عنوان برنامه Windows Terminal قابل دانلود از فروشگاه مایکروسافت یا [مستقیم از نسخه‌های این مخزن](https://github.com/microsoft/terminal/releases) ارائه شده است.

---

## منابع

برای کسب اطلاعات بیشتر درباره Windows Terminal، ممکن است برخی از این منابع برای شما مفید و جالب باشد:

* [وبلاگ خط فرمان](https://devblogs.microsoft.com/commandline)
* [مجموعه وبلاگ‌های پس‌زمینه خط فرمان](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* راه‌اندازی Windows Terminal: [ویدیوی معرفی ترمینال](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* راه‌اندازی Windows Terminal: [جلسه Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [نمایش ۶۴۵ - Windows Terminal با Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [قسمت ۵۴ - Kayla Cinnamon و Rich Turner درباره DevOps روی تیم Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [خط فرمان مدرن ویندوز: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## سؤالات متداول

### ترمینال جدید را ساختم و اجرا کردم اما شبیه کنسول قدیمی است

علت: راه‌حل نادرستی را در Visual Studio اجرا کرده‌اید.

راه حل: مطمئن شوید که پروژه `CascadiaPackage` را در Visual Studio ساخته و مستقر می‌کنید.

> [!توجه]
> `OpenConsole.exe` فقط یک `conhost.exe` ساخته شده محلی است، همان کنسول کلاسیک ویندوز که زیرساخت خط فرمان ویندوز را میزبانی می‌کند. OpenConsole توسط Windows Terminal برای اتصال و ارتباط با برنامه‌های خط فرمان (از طریق [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)) استفاده می‌شود.

---

## مستندات

تمام مستندات پروژه در [aka.ms/terminal-docs](https://aka.ms/terminal-docs) قرار دارد. اگر مایل به مشارکت در مستندات هستید، لطفاً یک pull request در [مخزن مستندات Windows Terminal](https://github.com/MicrosoftDocs/terminal) ارسال کنید.

---

## مشارکت

ما از همکاری با شما، جامعه شگفت‌انگیز خود، برای ساخت و ارتقای Windows Terminal هیجان‌زده‌ایم!

***قبل از شروع کار روی یک ویژگی/اصلاحیه***، لطفاً [راهنمای مشارکت‌کنندگان](./CONTRIBUTING.md) را مطالعه و دنبال کنید تا از اتلاف وقت یا کار تکراری جلوگیری شود.

## ارتباط با تیم

ساده‌ترین راه ارتباط با تیم از طریق مشکلات (issues) گیت‌هاب است.

لطفاً مشکلات جدید، درخواست ویژگی و پیشنهادات خود را ثبت کنید، اما **قبل از ایجاد مشکل جدید حتماً برای موارد مشابه باز/بسته قبلی جستجو کنید.**

اگر سؤالی دارید که فکر می‌کنید ارزش ایجاد issue را ندارد (هنوز)، از طریق توییتر با ما تماس بگیرید:

* کریستوفر نگوین، مدیر محصول:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* داستین هاوت، رهبر فنی: [@dhowett](https://twitter.com/DHowett)
* مایک گریسه، توسعه‌دهنده ارشد: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* کارلوس زامورا، توسعه‌دهنده: [@cazamor_msft](https://twitter.com/cazamor_msft)
* پانکاج بوجوانی، توسعه‌دهنده
* لئونارد هکر، توسعه‌دهنده: [@LeonardHecker](https://twitter.com/LeonardHecker)

## راهنمای توسعه‌دهنده

## پیش‌نیازها

می‌توانید محیط خود را به یکی از دو روش برای ساخت ترمینال پیکربندی کنید:

### استفاده از فایل پیکربندی WinGet

پس از کلون کردن مخزن، می‌توانید با استفاده از [فایل پیکربندی WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) محیط خود را راه‌اندازی کنید. [فایل پیکربندی پیش‌فرض](.config/configuration.winget) ویژوال استودیو ۲۰۲۲ Community و بقیه ابزارهای مورد نیاز را نصب می‌کند. دو نسخه دیگر از فایل پیکربندی در پوشه [.config](.config) برای نسخه‌های Enterprise و Professional ویژوال استودیو ۲۰۲۲ موجود است. برای اجرای فایل پیکربندی پیش‌فرض، می‌توانید یا فایل را در Explorer دوبار کلیک کنید یا دستور زیر را اجرا کنید:

```powershell
winget configure .config\configuration.winget
```

### پیکربندی دستی

* باید ویندوز ۱۰ نسخه ۲۰۰۴ (بیلد >= 10.0.19041.0) یا جدیدتر برای اجرای Windows Terminal داشته باشید
* باید [حالت توسعه‌دهنده را در تنظیمات ویندوز](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) فعال کنید تا بتوانید Windows Terminal را به صورت محلی نصب و اجرا کنید
* باید [PowerShell 7 یا جدیدتر](https://github.com/PowerShell/PowerShell/releases/latest) نصب شده باشد
* باید [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) نصب شده باشد
* باید حداقل [VS 2022](https://visualstudio.microsoft.com/downloads/) نصب باشد
* باید بارهای کاری زیر را از طریق نصب‌کننده VS نصب کنید. توجه: باز کردن راه‌حل در VS 2022 به طور خودکار شما را به نصب اجزای گمشده راهنمایی می‌کند:
  * توسعه دسکتاپ با C++
  * توسعه پلتفرم جهانی ویندوز (UWP)
  * **اجزای فردی زیر**
    * C++ (v143) Universal Windows Platform Tools
* باید [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) را برای ساخت پروژه‌های تست نصب کنید

## ساخت کد

OpenConsole.sln را می‌توان از داخل Visual Studio یا از خط فرمان با استفاده از اسکریپت‌ها و ابزارهای پوشه **/tools** ساخت:

### ساخت در PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### ساخت در Cmd

```shell
.\tools\razzle.cmd
bcz
```

## اجرا و دیباگ

برای دیباگ Windows Terminal در VS، روی `CascadiaPackage` (در Solution Explorer) راست کلیک کرده و به properties بروید. در منوی Debug، گزینه‌های "Application process" و "Background task process" را به "Native Only" تغییر دهید.

اکنون باید بتوانید پروژه ترمینال را با زدن <kbd>F5</kbd> بسازید و دیباگ کنید. مطمئن شوید که پلتفرم "x64" یا "x86" را انتخاب کرده‌اید – ترمینال برای "Any Cpu" ساخته نمی‌شود (زیرا یک برنامه C++ است نه C#).

> 👉 شما _نمی‌توانید_ ترمینال را مستقیماً با اجرای WindowsTerminal.exe اجرا کنید. برای جزئیات بیشتر درباره دلیل آن، به
> [#926](https://github.com/microsoft/terminal/issues/926)،
> [#4043](https://github.com/microsoft/terminal/issues/4043) مراجعه کنید.

### راهنمای کدنویسی

لطفاً این مستندات کوتاه درباره شیوه‌های کدنویسی ما را مرور کنید.

> 👉 اگر موردی را در این مستندات کم یافتید، می‌توانید در هر یک از فایل‌های مستندات مخزن مشارکت کنید (یا مستندات جدیدی بنویسید!)

این یک کار در حال پیشرفت است تا بفهمیم چه چیزی برای مشارکت‌کنندگان مؤثر پروژه لازم است.

* [سبک کدنویسی](./doc/STYLE.md)
* [سازمان‌دهی کد](./doc/ORGANIZATION.md)
* [استثناها در کد قدیمی ما](./doc/EXCEPTIONS.md)
* [اسمارت‌پوینترها و ماکروهای مفید برای ارتباط با ویندوز در WIL](./doc/WIL.md)

---

## منشور رفتار

این پروژه [منشور رفتار منبع‌باز مایکروسافت][conduct-code] را پذیرفته است. برای اطلاعات بیشتر [سؤالات متداول منشور رفتار][conduct-FAQ] را ببینید یا با [opencode@microsoft.com][conduct-email] تماس بگیرید.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---