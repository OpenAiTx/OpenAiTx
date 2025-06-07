![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# مرحبًا بك في مستودع Windows Terminal، وحدة التحكم وسطر الأوامر

<details>
  <summary><strong>جدول المحتويات</strong></summary>

- [تثبيت وتشغيل Windows Terminal](#تثبيت-وتشغيل-windows-terminal)
  - [متجر مايكروسوفت \[موصى به\]](#متجر-مايكروسوفت-موصى-به)
  - [طرق التثبيت الأخرى](#طرق-التثبيت-الأخرى)
    - [عبر GitHub](#عبر-github)
    - [عبر سطر أوامر Windows Package Manager (المعروف بـ winget)](#عبر-سطر-أوامر-windows-package-manager-المعروف-ب-winget)
    - [عبر Chocolatey (غير رسمي)](#عبر-chocolatey-غير-رسمي)
    - [عبر Scoop (غير رسمي)](#عبر-scoop-غير-رسمي)
- [تثبيت Windows Terminal Canary](#تثبيت-windows-terminal-canary)
- [خارطة طريق Windows Terminal](#خارطة-طريق-windows-terminal)
- [نظرة عامة على الطرفية ووحدة التحكم](#نظرة-عامة-على-الطرفية-ووحدة-التحكم)
  - [Windows Terminal](#windows-terminal)
  - [مضيف وحدة تحكم ويندوز](#مضيف-وحدة-تحكم-ويندوز)
  - [المكونات المشتركة](#المكونات-المشتركة)
  - [إنشاء الطرفية الجديدة لنظام ويندوز](#إنشاء-الطرفية-الجديدة-لنظام-ويندوز)
- [الموارد](#الموارد)
- [الأسئلة الشائعة](#الأسئلة-الشائعة)
  - [قمت ببناء وتشغيل الطرفية الجديدة، لكنها تبدو تمامًا مثل وحدة التحكم القديمة](#قمت-ببناء-وتشغيل-الطرفية-الجديدة-لكنها-تبدو-تمامًا-مثل-وحدة-التحكم-القديمة)
- [التوثيق](#التوثيق)
- [المساهمة](#المساهمة)
- [التواصل مع الفريق](#التواصل-مع-الفريق)
- [إرشادات المطورين](#إرشادات-المطورين)
- [المتطلبات الأساسية](#المتطلبات-الأساسية)
- [بناء الشيفرة](#بناء-الشيفرة)
  - [البناء في PowerShell](#البناء-في-powershell)
  - [البناء في Cmd](#البناء-في-cmd)
- [التشغيل وتصحيح الأخطاء](#التشغيل-وتصحيح-الأخطاء)
  - [إرشادات البرمجة](#إرشادات-البرمجة)
- [مدونة السلوك](#مدونة-السلوك)

</details>

<br />

يحتوي هذا المستودع على الشيفرة المصدرية لـ:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* مضيف وحدة تحكم ويندوز (`conhost.exe`)
* المكونات المشتركة بين المشروعين
* [ColorTool](./src/tools/ColorTool)
* [مشاريع أمثلة](./samples)
  توضح كيفية استخدام واجهات برمجة تطبيقات وحدة تحكم ويندوز

المستودعات ذات الصلة تشمل:

* [توثيق Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([المستودع: المساهمة في التوثيق](https://github.com/MicrosoftDocs/terminal))
* [توثيق واجهة برمجة تطبيقات وحدة التحكم](https://github.com/MicrosoftDocs/Console-Docs)
* [خط Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## تثبيت وتشغيل Windows Terminal

> [!ملاحظة]
> يتطلب Windows Terminal نظام Windows 10 إصدار 2004 (البنية 19041) أو أحدث

### متجر مايكروسوفت [موصى به]

قم بتثبيت [Windows Terminal من متجر مايكروسوفت][store-install-link].
يتيح لك ذلك دائمًا الحصول على أحدث إصدار عندما نصدر بنية جديدة
مع ترقيات تلقائية.

هذه هي طريقتنا المفضلة.

### طرق التثبيت الأخرى

#### عبر GitHub

للمستخدمين الذين لا يمكنهم تثبيت Windows Terminal من متجر مايكروسوفت،
يمكن تنزيل الإصدارات المنشورة يدويًا من [صفحة الإصدارات](https://github.com/microsoft/terminal/releases) لهذا المستودع.

قم بتنزيل ملف `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` من
قسم **Assets**. لتثبيت التطبيق، يمكنك ببساطة النقر المزدوج على ملف
`.msixbundle`، ويجب أن يعمل مثبت التطبيق تلقائيًا. إذا لم ينجح ذلك لأي سبب،
يمكنك تجربة الأمر التالي في موجه PowerShell:

```powershell
# ملاحظة: إذا كنت تستخدم PowerShell 7+، يرجى تشغيل
# Import-Module Appx -UseWindowsPowerShell
# قبل استخدام Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!ملاحظة]
> إذا قمت بتثبيت الطرفية يدويًا:
>
> * قد تحتاج إلى تثبيت [حزمة إطار عمل VC++ v14 Desktop](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   هذا يجب أن يكون ضروريًا فقط في إصدارات ويندوز 10 القديمة وفقط إذا ظهرت لك رسالة خطأ حول حزم الإطار المفقودة.
> * لن يتم تحديث الطرفية تلقائيًا عند إصدار بنى جديدة، لذا ستحتاج
>   إلى تثبيت أحدث إصدار من الطرفية بانتظام للحصول على جميع التصحيحات والتحسينات الأخيرة!

#### عبر سطر أوامر Windows Package Manager (المعروف بـ winget)

يمكن لمستخدمي [winget](https://github.com/microsoft/winget-cli) تنزيل وتثبيت
أحدث إصدار من الطرفية عن طريق تثبيت حزمة `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!ملاحظة]
> دعم الاعتماديات متوفر في إصدار WinGet [1.6.2631 أو أحدث](https://github.com/microsoft/winget-cli/releases). لتثبيت الإصدار المستقر من الطرفية 1.18 أو أحدث، يرجى التأكد من تحديث عميل WinGet لديك.

#### عبر Chocolatey (غير رسمي)

يمكن لمستخدمي [Chocolatey](https://chocolatey.org) تنزيل وتثبيت أحدث
إصدار من الطرفية عن طريق تثبيت حزمة `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

لترقية Windows Terminal باستخدام Chocolatey، شغل ما يلي:

```powershell
choco upgrade microsoft-windows-terminal
```

إذا واجهت أي مشاكل عند تثبيت/ترقية الحزمة، يرجى الذهاب إلى
[صفحة حزمة Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) واتباع
[عملية تصنيف Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### عبر Scoop (غير رسمي)

يمكن لمستخدمي [Scoop](https://scoop.sh) تنزيل وتثبيت أحدث إصدار من الطرفية
عن طريق تثبيت حزمة `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

لتحديث Windows Terminal باستخدام Scoop، شغل ما يلي:

```powershell
scoop update windows-terminal
```

إذا واجهت أي مشاكل عند تثبيت/تحديث الحزمة، يرجى البحث عن المشكلة أو الإبلاغ عنها في [صفحة المشاكل](https://github.com/lukesampson/scoop-extras/issues) لمستودع Scoop Extras.

---

## تثبيت Windows Terminal Canary
Windows Terminal Canary هو إصدار ليلي من Windows Terminal. يحتوي هذا الإصدار على أحدث شيفرة من فرع `main` لدينا، مما يمنحك فرصة لتجربة الميزات قبل وصولها إلى Windows Terminal Preview.

Windows Terminal Canary هو أقل إصداراتنا استقرارًا، لذا قد تكتشف أخطاء قبل أن تتاح لنا الفرصة للعثور عليها.

يتوفر Windows Terminal Canary كتوزيع App Installer وتوزيع ZIP محمول.

يدعم توزيع App Installer التحديثات التلقائية. وبسبب قيود المنصة، يعمل هذا المثبت فقط على Windows 11.

توزيع ZIP المحمول هو تطبيق محمول. لن يتم تحديثه تلقائيًا ولن يتحقق تلقائيًا من التحديثات. يعمل هذا التوزيع المحمول على Windows 10 (19041+) وWindows 11.

| التوزيع        | البنية المعمارية | الرابط                                                   |
|----------------|:----------------:|---------------------------------------------------------|
| App Installer  | x64, arm64, x86  | [تحميل](https://aka.ms/terminal-canary-installer)       |
| Portable ZIP   | x64              | [تحميل](https://aka.ms/terminal-canary-zip-x64)         |
| Portable ZIP   | ARM64            | [تحميل](https://aka.ms/terminal-canary-zip-arm64)       |
| Portable ZIP   | x86              | [تحميل](https://aka.ms/terminal-canary-zip-x86)         |

_تعرف على المزيد حول [أنواع توزيعات Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## خارطة طريق Windows Terminal

تم وصف خطة Windows Terminal [هنا](/doc/roadmap-2023.md) وسيتم تحديثها مع تقدم المشروع.

## نظرة عامة على الطرفية ووحدة التحكم

يرجى تخصيص بضع دقائق لمراجعة النظرة العامة أدناه قبل الغوص في الشيفرة:

### Windows Terminal

Windows Terminal هو تطبيق طرفية حديث، غني بالميزات، منتج لمستخدمي سطر الأوامر. يتضمن العديد من الميزات التي طلبها مجتمع سطر أوامر ويندوز بشكل متكرر، بما في ذلك دعم علامات التبويب، النصوص الغنية، التدويل، قابلية التكوين، السمات والتصميم، والمزيد.

يجب أيضًا على الطرفية أن تحقق أهدافنا ومقاييسنا لضمان بقائها سريعة وفعالة، ولا تستهلك كميات كبيرة من الذاكرة أو الطاقة.

### مضيف وحدة تحكم ويندوز

مضيف وحدة تحكم ويندوز، `conhost.exe`، هو تجربة المستخدم الأصلية لسطر الأوامر في ويندوز. كما يستضيف بنية سطر الأوامر في ويندوز وخادم واجهة برمجة تطبيقات وحدة التحكم، ومحرك الإدخال، ومحرك العرض، وتفضيلات المستخدم، وغيرها. الشيفرة الخاصة بمضيف وحدة التحكم في هذا المستودع هي المصدر الفعلي الذي يتم منه بناء `conhost.exe` في نظام ويندوز.

منذ تولي مسؤولية سطر الأوامر في ويندوز في 2014، أضاف الفريق عدة ميزات جديدة إلى وحدة التحكم، بما في ذلك شفافية الخلفية، التحديد بناءً على الأسطر، دعم [تسلسلات ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code)، [ألوان 24-بت](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/)، [وحدة تحكم افتراضية ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)، والمزيد.

ومع ذلك، نظرًا لأن الهدف الأساسي لوحدة تحكم ويندوز هو الحفاظ على التوافق مع الإصدارات السابقة، لم نتمكن من إضافة العديد من الميزات التي يرغب بها المجتمع (والفريق) على مدار السنوات الماضية، بما في ذلك علامات التبويب، النص الموحد، والإيموجي.

هذه القيود دفعتنا لإنشاء الطرفية الجديدة لويندوز.

> يمكنك قراءة المزيد حول تطور سطر الأوامر بشكل عام، وسطر أوامر ويندوز بشكل خاص في [سلسلة التدوينات المصاحبة هذه](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) على مدونة فريق سطر الأوامر.

### المكونات المشتركة

أثناء تحديث وحدة تحكم ويندوز، قمنا بتحديث قاعدة الشيفرة بشكل كبير، وفصل الكيانات المنطقية بوضوح إلى وحدات وفئات، وأدخلنا بعض نقاط التوسعة الرئيسية، واستبدلنا العديد من الحاويات والتجميعات القديمة والمصممة محليًا بحاويات [STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) أكثر أمانًا وكفاءة، وجعلنا الشيفرة أبسط وأكثر أمانًا باستخدام [مكتبات تنفيذ ويندوز - WIL](https://github.com/Microsoft/wil) من مايكروسوفت.

أدى هذا التحديث إلى توفر العديد من المكونات الرئيسية لوحدة التحكم لإعادة الاستخدام في أي تطبيق طرفية على ويندوز. تشمل هذه المكونات محرك تخطيط وعرض نصوص جديد يعتمد على DirectWrite، ومخزن نصوص قادر على تخزين كل من UTF-16 وUTF-8، ومحلل/مولد VT، والمزيد.

### إنشاء الطرفية الجديدة لنظام ويندوز

عند البدء في التخطيط لتطبيق الطرفية الجديد لنظام ويندوز، استكشفنا وقيمنا عدة طرق وتقنيات. في النهاية قررنا أن أهدافنا سيتم تحقيقها بشكل أفضل من خلال مواصلة الاستثمار في قاعدة شيفرتنا بلغة C++، مما يسمح لنا بإعادة استخدام العديد من المكونات الحديثة المذكورة أعلاه في كل من وحدة التحكم الحالية والطرفية الجديدة. علاوة على ذلك، أدركنا أن هذا سيسمح لنا ببناء جزء كبير من جوهر الطرفية نفسها كعنصر واجهة مستخدم قابل لإعادة الاستخدام يمكن للآخرين دمجه في تطبيقاتهم.

نتيجة هذا العمل موجودة في هذا المستودع ويتم تسليمها كتطبيق Windows Terminal الذي يمكنك تنزيله من متجر مايكروسوفت، أو [مباشرة من إصدارات هذا المستودع](https://github.com/microsoft/terminal/releases).

---

## الموارد

لمزيد من المعلومات حول Windows Terminal، قد تجد بعض هذه الموارد مفيدة ومثيرة للاهتمام:

* [مدونة سطر الأوامر](https://devblogs.microsoft.com/commandline)
* [سلسلة مدونة خلفية سطر الأوامر](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* إطلاق Windows Terminal: [فيديو "Sizzle" للطرفية](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* إطلاق Windows Terminal: [جلسة Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [الحلقة 645 - Windows Terminal مع Richard Turner](https://www.runasradio.com/Shows/Show/645)
* بودكاست Azure Devops: [الحلقة 54 - Kayla Cinnamon و Rich Turner حول DevOps على فريق Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* جلسة Microsoft Ignite 2019: [سطر الأوامر الحديث لنظام ويندوز: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## الأسئلة الشائعة

### قمت ببناء وتشغيل الطرفية الجديدة، لكنها تبدو تمامًا مثل وحدة التحكم القديمة

السبب: تقوم بتشغيل الحل غير الصحيح في Visual Studio.

الحل: تأكد من أنك تبني وتنشر مشروع `CascadiaPackage` في Visual Studio.

> [!ملاحظة]
> `OpenConsole.exe` هو فقط إصدار محلي البناء من `conhost.exe`، وحدة تحكم ويندوز الكلاسيكية التي تستضيف بنية سطر الأوامر في ويندوز. يتم استخدام OpenConsole بواسطة Windows Terminal للاتصال والتواصل مع تطبيقات سطر الأوامر (عبر [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## التوثيق

جميع توثيقات المشروع موجودة على [aka.ms/terminal-docs](https://aka.ms/terminal-docs). إذا كنت ترغب
في المساهمة في التوثيق، يرجى إرسال طلب سحب على [مستودع توثيق Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## المساهمة

نحن متحمسون للعمل معكم، مجتمعنا الرائع، لبناء وتحسين Windows Terminal!

***قبل أن تبدأ العمل على ميزة/تصحيح***، يرجى قراءة واتباع [دليل المساهمين](./CONTRIBUTING.md) للمساعدة في تجنب أي جهد ضائع أو مكرر.

## التواصل مع الفريق

أسهل طريقة للتواصل مع الفريق هي عبر مشاكل GitHub.

يرجى تقديم مشاكل جديدة، وطلبات الميزات والاقتراحات، ولكن **يجب البحث عن مشاكل مشابهة مفتوحة/مغلقة موجودة مسبقًا قبل إنشاء مشكلة جديدة.**

إذا كنت ترغب في طرح سؤال تشعر أنه لا يستحق مشكلة (حتى الآن)، يرجى التواصل معنا عبر تويتر:

* Christopher Nguyen، مدير المنتج: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett، قائد الهندسة: [@dhowett](https://twitter.com/DHowett)
* Mike Griese، مطور أول: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora، مطور: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani، مطور
* Leonard Hecker، مطور: [@LeonardHecker](https://twitter.com/LeonardHecker)

## إرشادات المطورين

## المتطلبات الأساسية

يمكنك تهيئة بيئتك لبناء الطرفية بإحدى طريقتين:

### باستخدام ملف إعداد WinGet

بعد استنساخ المستودع، يمكنك استخدام [ملف إعداد WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
لإعداد بيئتك. [ملف الإعداد الافتراضي](.config/configuration.winget) يقوم بتثبيت Visual Studio 2022 Community وباقي الأدوات المطلوبة. هناك نوعان آخران من ملفات الإعداد متوفرة في دليل [.config](.config) لإصدارات Visual Studio 2022 Enterprise وProfessional. لتشغيل ملف الإعداد الافتراضي، يمكنك إما النقر المزدوج على الملف من المستكشف أو تشغيل الأمر التالي:

```powershell
winget configure .config\configuration.winget
```

### الإعداد اليدوي

* يجب أن تعمل بنظام Windows 10 2004 (البنية >= 10.0.19041.0) أو أحدث لتشغيل Windows Terminal
* يجب [تفعيل وضع المطور في تطبيق إعدادات ويندوز](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  لتثبيت وتشغيل Windows Terminal محليًا
* يجب أن يكون لديك [PowerShell 7 أو أحدث](https://github.com/PowerShell/PowerShell/releases/latest) مثبتًا
* يجب أن يكون لديك [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) مثبتًا
* يجب أن يكون لديك على الأقل [VS 2022](https://visualstudio.microsoft.com/downloads/) مثبتًا
* يجب تثبيت أعباء العمل التالية عبر مثبت VS. ملاحظة: فتح الحل في VS 2022 سيقوم [بتنبيهك لتثبيت المكونات الناقصة تلقائيًا](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * تطوير سطح المكتب باستخدام C++
  * تطوير منصة ويندوز الشاملة (UWP)
  * **المكونات الفردية التالية**
    * أدوات C++ (v143) لمنصة ويندوز الشاملة (UWP)
* يجب عليك تثبيت [حزمة استهداف .NET Framework](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) لبناء مشاريع الاختبار

## بناء الشيفرة

يمكن بناء OpenConsole.sln من داخل Visual Studio أو من سطر الأوامر
باستخدام مجموعة من السكربتات والأدوات في دليل **/tools**:

### البناء في PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### البناء في Cmd

```shell
.\tools\razzle.cmd
bcz
```

## التشغيل وتصحيح الأخطاء

لتصحيح أخطاء Windows Terminal في VS، انقر بزر الماوس الأيمن على `CascadiaPackage` (في مستكشف الحلول) واذهب إلى الخصائص. في قائمة التصحيح، غير "عملية التطبيق" و"عملية مهمة الخلفية" إلى "Native Only".

يجب أن تكون الآن قادرًا على بناء وتصحيح مشروع الطرفية بالضغط على <kbd>F5</kbd>. تأكد من اختيار إما منصة "x64" أو "x86" - لا يتم بناء الطرفية لمنصة "Any Cpu" (لأن الطرفية تطبيق C++، وليس C#).

> 👉 لن تتمكن من تشغيل الطرفية مباشرة بتشغيل WindowsTerminal.exe. لمزيد من التفاصيل حول السبب، راجع
> [#926](https://github.com/microsoft/terminal/issues/926)،
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### إرشادات البرمجة

يرجى مراجعة هذه المستندات الموجزة أدناه حول ممارسات البرمجة لدينا.

> 👉 إذا وجدت شيئًا مفقودًا من هذه المستندات، لا تتردد في المساهمة في أي من ملفات التوثيق في المستودع (أو كتابة مستندات جديدة!)

هذا العمل جارٍ بينما نتعلم ما الذي سنحتاج لتوفيره للناس ليكونوا مساهمين فعالين في مشروعنا.

* [أسلوب البرمجة](./doc/STYLE.md)
* [تنظيم الشيفرة](./doc/ORGANIZATION.md)
* [الاستثناءات في قاعدة الشيفرة القديمة لدينا](./doc/EXCEPTIONS.md)
* [المؤشرات الذكية والمراجعات المفيدة للتعامل مع ويندوز في WIL](./doc/WIL.md)

---

## مدونة السلوك

لقد اعتمد هذا المشروع [مدونة السلوك البرمجي المفتوح من مايكروسوفت][conduct-code]. لمزيد من المعلومات، راجع [الأسئلة الشائعة حول مدونة السلوك][conduct-FAQ] أو تواصل مع [opencode@microsoft.com][conduct-email] لأي أسئلة أو تعليقات إضافية.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---