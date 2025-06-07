# Microsoft PowerToys

![تصویر اصلی برای Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[چگونه از PowerToys استفاده کنیم][usingPowerToys-docs-link] | [دانلودها و یادداشت‌های انتشار][github-release-link] | [مشارکت در PowerToys](#contributing) | [چه خبر است](#whats-happening) | [نقشه راه](#powertoys-roadmap)

## درباره

Microsoft PowerToys مجموعه‌ای از ابزارها برای کاربران حرفه‌ای است تا تجربه خود را در ویندوز به منظور افزایش بهره‌وری بهینه‌سازی و تنظیم کنند. برای اطلاعات بیشتر درباره [بررسی اجمالی PowerToys و نحوه استفاده از ابزارها][usingPowerToys-docs-link] یا هر ابزار و منبع دیگر برای [محیط‌های توسعه ویندوز](https://learn.microsoft.com/windows/dev-environment/overview)، به [learn.microsoft.com][usingPowerToys-docs-link] مراجعه کنید!

|              | ابزارهای فعلی:        |              |
|--------------|----------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [همیشه در بالا](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [انتخاب‌گر رنگ](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [برش و قفل](https://aka.ms/PowerToysOverview_CropAndLock) | [متغیرهای محیطی](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [افزونه‌های File Explorer](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [ویرایشگر فایل Hosts](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [تغییر اندازه تصویر](https://aka.ms/PowerToysOverview_ImageResizer) | [مدیر صفحه کلید](https://aka.ms/PowerToysOverview_KeyboardManager) | [ابزارهای ماوس](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [ماوس بدون مرز](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [چسباندن به صورت متن ساده](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [پیش‌نمایش رجیستری](https://aka.ms/PowerToysOverview_RegistryPreview) | [خط‌کش صفحه](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [راهنمای میانبر](https://aka.ms/PowerToysOverview_ShortcutGuide) | [استخراج‌کننده متن](https://aka.ms/PowerToysOverview_TextExtractor) | [محیط‌های کاری](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## نصب و اجرای Microsoft PowerToys

### پیش‌نیازها

- ویندوز ۱۱ یا ویندوز ۱۰ نسخه ۲۰۰۴ (نام رمز 20H1 / شماره ساخت ۱۹۰۴۱) یا جدیدتر
- پردازنده x64 یا ARM64
- نصب‌کننده ما موارد زیر را نصب خواهد کرد:
   - بوت‌استرپ [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). این آخرین نسخه را نصب می‌کند.

### از طریق GitHub با EXE [توصیه‌شده]

به [صفحه انتشار GitHub Microsoft PowerToys][github-release-link] بروید و روی `Assets` در پایین کلیک کنید تا فایل‌های موجود در انتشار را مشاهده کنید. لطفاً نصب‌کننده PowerToys مناسب با معماری دستگاه و دامنه نصب خود را انتخاب کنید. برای اکثر کاربران، گزینه `x64` و نصب برای هر کاربر مناسب است.

<!-- مواردی که باید با هر انتشار بروزرسانی شوند -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  توضیحات         | نام فایل | هش sha256 |
|------------------|----------|-----------|
| برای هر کاربر - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| برای هر کاربر - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| برای کل دستگاه - x64      | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| برای کل دستگاه - ARM64    | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

این روش پیشنهادی ماست.

### از طریق فروشگاه مایکروسافت

از [صفحه PowerToys در فروشگاه مایکروسافت][microsoft-store-link] نصب کنید. باید از [فروشگاه جدید مایکروسافت](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) استفاده کنید که برای هر دو ویندوز ۱۰ و ۱۱ در دسترس است.

### از طریق WinGet

PowerToys را از [WinGet][winget-link] دانلود کنید. بروزرسانی PowerToys از طریق winget دامنه نصب فعلی را حفظ خواهد کرد. برای نصب PowerToys، دستور زیر را در خط فرمان / PowerShell اجرا کنید:

#### نصب‌کننده دامنه کاربر [پیش‌فرض]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### نصب‌کننده دامنه کل دستگاه

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### سایر روش‌های نصب

روش‌های نصب [جامعه‌محور](./doc/unofficialInstallMethods.md) مانند Chocolatey و Scoop نیز وجود دارد. اگر این راهکارها را ترجیح می‌دهید، دستورالعمل‌های نصب را در همانجا بیابید.

## افزونه‌های Run شخص ثالث

مجموعه‌ای از [افزونه‌های شخص ثالث](./doc/thirdPartyRunPlugins.md) توسط جامعه ایجاد شده‌اند که همراه PowerToys توزیع نمی‌شوند.

## مشارکت

این پروژه از انواع مشارکت‌ها استقبال می‌کند.  علاوه بر کدنویسی ویژگی‌ها/رفع اشکال، راه‌های دیگر کمک شامل نگارش مشخصات، طراحی، مستندسازی و یافتن اشکال است. ما مشتاق همکاری با جامعه کاربران حرفه‌ای برای ساخت مجموعه‌ای از ابزارها جهت بهره‌برداری حداکثری از ویندوز هستیم.

از شما می‌خواهیم که **پیش از شروع کار روی هر ویژگی که می‌خواهید مشارکت کنید**، راهنمای [مشارکت‌کنندگان](CONTRIBUTING.md) ما را بخوانید. خوشحال می‌شویم با شما برای یافتن بهترین رویکرد، راهنمایی و منتورینگ در توسعه ویژگی، و جلوگیری از هرگونه تلاش تکراری یا بیهوده همکاری کنیم.

اغلب مشارکت‌ها نیازمند توافق با [توافقنامه مجوز مشارکت‌کننده (CLA)][oss-CLA] هستند که اعلام می‌کند شما به ما حق استفاده از مشارکت خود را می‌دهید و مجاز به انجام این کار هستید.

برای راهنمایی در توسعه PowerToys، [مستندات توسعه‌دهنده](/doc/devdocs) را برای شرح دقیق مطالعه کنید. این شامل نحوه راه‌اندازی کامپیوتر جهت کامپایل نیز هست.

## چه خبر است

### نقشه راه PowerToys

[نقشه راه اولویت‌بندی‌شده][roadmap] ویژگی‌ها و ابزارهایی که تیم اصلی روی آن تمرکز دارد.

### نسخه 0.91 - به‌روزرسانی می 2025

در این نسخه، تمرکز ما بر ویژگی‌های جدید، پایداری و خودکارسازی بوده است.

**✨ نکات برجسته**

 - تمرکز بر بهبود عملکرد Command Palette و رفع تعداد زیادی باگ. برخی ویژگی‌های جدید:
 - افزودن امکان جستجو برای هر فایل با استفاده از فرمان جایگزین در Command Palette.
 - افزودن امکان تبدیل کلید میانبر سراسری Command Palette به یک قلاب سطح پایین صفحه‌کلید.
 - افزودن فرمان جایگزین باز کردن URL برای افزونه WebSearch، امکان باز کردن مستقیم URL در مرورگر از Command Palette را برای کاربران فراهم می‌کند.
 - اکنون می‌توانید قالب‌های سفارشی در افزونه‌های تاریخ و زمان PT Run و Command Palette تعریف کنید. با تشکر از [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - رفع مشکلی که Advanced Paste قادر به ایجاد موتور OCR برای برخی برچسب‌های زبان انگلیسی (مانند en-CA) نبود، با مقداردهی اولیه موتور OCR با زبان پروفایل کاربر. با تشکر از [@cryolithic](https://github.com/cryolithic)!

### انتخاب‌گر رنگ (Color Picker)

 - رفع نشتی منابع که باعث هنگ یا کرش می‌شد، با پاک‌سازی صحیح شی Graphics. با تشکر از [@dcog989](https://github.com/dcog989)!
 - رفع مشکلی که Color Picker با فشردن کلید Backspace بسته می‌شد، با اطمینان از اینکه فقط هنگام فوکوس بسته می‌شود و یکسان‌سازی رفتار Escape/Backspace. با تشکر از [@PesBandi](https://github.com/PesBandi)!
 - افزودن پشتیبانی از قالب‌های رنگ Oklab و Oklch. با تشکر از [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - به‌روزرسانی اسکریپت WinGet Command Not Found تا فقط در صورت وجود ویژگی‌های آزمایشی آن‌ها را فعال کند.

### Command Palette

 - به‌روزرسانی قالب باگ برای درج ماژول Command Palette.
 - رفع مشکلی که پنجره toast برای DPI مقیاس نمی‌شد و باعث مشکل در نمایش می‌شد.
 - رفع مشکلی که ناوبری صفحه‌کلید بالا/پایین هنگام قرار داشتن مکان‌نما در موقعیت ۰ انتخاب را جابجا نمی‌کرد و افزودن ناوبری مستمر مشابه PT Run v1. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!
 - ساده‌سازی و بهبود کد افزونه زمان و تاریخ.
 - رفع مشکلی که حروف بزرگ در فرمان موجب شکست در رفتن به نشانگر ماوس می‌شد، با کوچک‌نویسی فرمان.
 - افزودن فرمان جایگزین باز کردن URL برای افزونه WebSearch. با تشکر از [@htcfreek](https://github.com/htcfreek)!
 - افزودن تنظیم برای فعال/غیرفعال کردن آیکون سینی سیستم در CmdPal و همسان‌سازی اصطلاحات با ویندوز ۱۱. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!
 - رفع مشکل به‌روزرسانی نام مستعار با حذف نام مستعار قدیمی هنگام تنظیم جدید.
 - رفع تضاد حروف بزرگ GitHub با انتقال Exts و exts به دایرکتوری ext جدید، تضمین ساختار یکسان بین پلتفرم‌ها و جلوگیری از تکه‌تکه شدن مسیر.
 - رفع مشکلی که فرمان "ایجاد افزونه جدید" نام فایل خالی ایجاد می‌کرد.
 - افزودن امکان تبدیل کلید میانبر سراسری به قلاب سطح پایین صفحه‌کلید.
 - افزودن پشتیبانی از تصاویر بندانگشتی JUMBO برای دسترسی به آیکون‌های با وضوح بالا.
 - رفع کرش هنگام مخفی شدن خودکار CmdPal در حین باز بودن پنجره MSAL با جلوگیری از مخفی شدن در صورت غیرفعال بودن CmdPal.
 - افزودن امکان انتخاب فوری متن جستجو هنگام بارگذاری صفحه.
 - رفع باگی که صفحات تنظیمات افزونه هنگام بازگشایی مجدد بارگذاری نمی‌شدند، با به‌روزرسانی فرم تنظیمات هنگام ذخیره تنظیمات افزونه.
 - رفع مشکلی که Command Palette از runner اجرا نمی‌شد.
 - بازسازی و انتقال منطق ماشین حساب PowerToys Run v1 به Command Palette، افزودن پشتیبانی از تنظیمات و بهبود رفتار جایگزین.
 - بازگرداندن پشتیبانی از میانبرهای صفحه‌کلید برای اقلام لیست.
 - بهبود دسترسی‌پذیری با افزودن برچسب‌های صحیح، بهبود انیمیشن‌ها، بهبود بومی‌سازی و رفع مشکلات a11y.
 - انتقال پشتیبانی از قالب سفارشی به افزونه زمان و تاریخ، بازآرایی و پاکسازی تنظیمات، بهبود پیام‌های خطا و رفع کرش‌های لبه‌ای برای عملکرد پایدارتر و کاربرپسندتر. با تشکر از [@htcfreek](https://github.com/htcfreek)!
 - افزودن آیتم جایگزین برای فرمان سیستمی.
 - رفع باگ در فرمان سیستمی ویندوز که اعلان کلید برای عملکرد "باز کردن سطل بازیافت" را اشتباه نمایش می‌داد. با تشکر از [@jironemo](https://github.com/jironemo)!
 - رفع مشکلی که لیست 'فرمان‌های بیشتر' دستورات نامناسب را نمایش می‌داد. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!
 - رفع مشکلی که نمای جزئیات در Command Palette آیکون بیش از حد بزرگ و متن نامرتب نمایش می‌داد، و هماهنگی با رفتار جستجوی ویندوز.
 - رفع باگی که محتوای صفحه خالی و فرمان‌های نوار فرمان هنگام استفاده از برچسب‌های طولانی قطع می‌شدند.
 - بهبود یکپارچگی CmdPal با WinGet با رفع نمایش نسخه برای بسته‌های نصب‌شده، فعال کردن بروزرسانی‌ها با آیکون و انتقال API پیش‌نمایش winget به نسخه پایدار.
 - رفع باگی که دستورات ContentPage تا بعد از خروج به‌روزرسانی نمی‌شد، با اطمینان از مقداردهی اولیه کامل منوهای زمینه هنگام تغییر.
 - افزودن پشتیبانی جایگزین به افزونه TimeDate برای جستجوی مستقیم تاریخ/زمان بدون نیاز به انتخاب فرمان.
 - افزودن وارد کردن Common.Dotnet.AotCompatibility.props در چندین فایل پروژه CmdPal برای بهبود پشتیبانی از کامپایل AOT.
 - رفع کرش در تنظیمات CmdPal به دلیل HotKey تهی هنگام نبود settings.json یا نبود کلید میانبر تعریف‌شده. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!
 - افزودن پشتیبانی از منوهای زمینه تو در تو و قابل جستجو در CmdPal، شامل جعبه جستجو با حفظ رفتار فوکوس.
 - بازسازی کلاس‌های CmdPal برای بهبود سریال‌سازی JSON و معرفی زمینه‌های سریال‌سازی جدید برای عملکرد و نگهداری بهتر.
 - افزودن پشتیبانی از کامپایل پیش‌زمان (AoT).
 - افزودن مکانیزم تلاش مجدد برای اجرای CmdPal.
 - حذف برخی فایل‌های بلااستفاده از CmdPal.Common برای ساده‌سازی کد و آماده‌سازی برای AoT.
 - رفع باگی که رقابت همزمان در بروزرسانی SearchText باعث پرش مکان‌نما به انتهای خط می‌شد، با بروزرسانی SearchText تنها پس از تغییر واقعی.
 - افزودن پشتیبانی از جستجوی هر فایل در فرمان جایگزین.
 - پاکسازی کدهای مرتبط با AoT برای جلوگیری از عملیات تکراری در تست.
 - کاهش زمان بارگذاری CmdPal با موازی‌سازی راه‌اندازی افزونه‌ها و افزودن محدوده زمانی برای جلوگیری از مسدود شدن توسط افزونه‌های مشکل‌دار.
 - بهبود رفتار رابط کاربری با بستن پنل جزئیات هنگام خالی شدن لیست، جلوگیری از وضعیت‌های بصری ناسازگار.
 - افزودن پشتیبانی از حذف فرمان جایگزین در CmdPal هنگام عدم یافتن فرمان مطابقت.
 - رفع نشتی در قالب افزونه CmdPal با اصلاح استفاده نادرست از ComServer.
 - جلوگیری از ماکسیمایز شدن پنجره CmdPal با دوبار کلیک روی نوار عنوان برای حفظ رفتار مورد نظر. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!
 - رفع مشکلی که رابط تنظیمات بیش از حد کوچک باز می‌شد با آگاه‌سازی ابعاد پنجره از DPI و تعیین حداقل عرض و ارتفاع با استفاده از WinUIEx.
 - رفع فلش سفید و مشکلات انیمیشن یک‌باره در CmdPal با مخفی‌سازی پنجره به جای پنهان کردن آن.
 - رفع باگی که همه تنظیمات افزونه در شروع بارگذاری می‌شدند، با بارگذاری تنبل تنظیمات افزونه و کاهش سربار اولیه.
 - افزودن پشتیبانی از محافظت CmdPal در برابر کرش هنگام خطا در تجزیه Adaptive Card.
 - جایگزینی shell:AppsFolder با فعال‌سازی URI در CmdPal برای افزایش قابلیت اطمینان.
 - افزودن قابلیت باز کردن تنظیمات CmdPal از تنظیمات PowerToys.
 - افزودن قابلیت مشاهده و بروزرسانی دینامیک جزئیات افزونه در CmdPal با دنبال کردن تغییرات ویژگی آیتم انتخاب شده.
 - افزایش نسخه toolkit مورد استفاده در قالب افزونه CmdPal به 0.2.0.

### تغییر اندازه تصویر (Image Resizer)

 - رفع مشکلی که با حذف یک پیش‌تنظیم Image Resizer، پیش‌تنظیم اشتباه حذف می‌شد.

### مدیر صفحه‌کلید (Keyboard Manager)

 - رفع مشکلی که کلید اصلاحی بدون تعیین سمت چپ/راست گیر می‌کرد به دلیل مدیریت نادرست کلیدها، با پیگیری کلیدهای فشرده شده و ارسال صحیح کلید. با تشکر از [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - بهبود قابلیت‌های قالب‌بندی زمان PowerRename با افزودن الگوهای فرمت زمان ۱۲ ساعته با پشتیبانی AM/PM. با تشکر از [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - افزودن پشتیبانی از قالب‌های سفارشی در افزونه "زمان و تاریخ" و بهبود پیام‌های خطا برای قالب‌های ورودی نامعتبر. با تشکر از [@htcfreek](https://github.com/htcfreek)!
 - رفع دو کرش: یکی برای WFT در تاریخ‌های بسیار ابتدایی و دیگری برای محاسبه هفته ماه در تاریخ‌های انتهایی (مثلاً 31.12.9999) و بازآرایی تنظیمات رابط کاربری. با تشکر از [@htcfreek](https://github.com/htcfreek)!
 - رفع مشکلی که حروف بزرگ در فرمان موجب شکست در رفتن به نشانگر ماوس می‌شد، با کوچک‌نویسی فرمان.
 - افزودن جزئیات نسخه به پیام‌های خطای افزونه برای 'خطای بارگذاری' و 'خطای مقداردهی اولیه'. با تشکر از [@htcfreek](https://github.com/htcfreek)!
 - بهبود مدل نتیجه با افزودن پشتیبانی از جلوگیری از مرتب‌سازی بر اساس استفاده، برای کنترل بهتر توسعه‌دهندگان افزونه بر رفتار مرتب‌سازی. با تشکر از [@CoreyHayward](https://github.com/CoreyHayward) و [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - به‌روزرسانی نگاشت حروف در GetDefaultLetterKeyEPO با جایگزینی "ǔ" با "ŭ" برای کلید VK_U جهت تطابق دقیق با آواشناسی اسپرانتو. با تشکر از [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - رفع مشکلی که Quick Accent هنگام استفاده از صفحه‌کلید روی صفحه به درستی کار نمی‌کرد. با تشکر از [@davidegiacometti](https://github.com/davidegiacometti)!

### پیش‌نمایش رجیستری (Registry Preview)

 - بهبود Registry Preview برای پشتیبانی از چسباندن کلیدها و مقادیر رجیستری بدون نیاز به نوشتن دستی هدر فایل و افزودن دکمه جدید برای بازنشانی برنامه. با تشکر از [@htcfreek](https://github.com/htcfreek)!

### تنظیمات

 - رفع مشکلی که برنامه تنظیمات گاهی آیکون خالی در نوار وظیفه نمایش می‌داد با تعویق اختصاص آیکون تا فعال شدن پنجره.
 - افزودن امکان ماکسیمایز کردن پنجره "چه خبر است" برای تجربه مطالعه راحت‌تر.

### محیط‌های کاری (Workspaces)

 - رفع اشکالاتی که بازی‌های Steam به درستی شناسایی یا اجرا نمی‌شدند، با بروزرسانی فیلتر پنجره‌ها و یکپارچه‌سازی پروتکل URL استیم.

### مستندسازی

 - افزودن QuickNotes به مستندات افزونه‌های شخص ثالث PowerToys Run. با تشکر از [@ruslanlap](https://github.com/ruslanlap)!
 - افزودن افزونه‌های Weather و Pomodoro به مستندات افزونه‌های شخص ثالث PowerToys Run. با تشکر از [@ruslanlap](https://github.com/ruslanlap)!
 - افزودن افزونه Linear به مستندات افزونه‌های شخص ثالث PowerToys Run. با تشکر از [@vednig](https://github.com/vednig)!
 - رفع مشکلات قالب‌بندی در فایل‌های مستندات و بروزرسانی اطلاعات مشارکت‌کنندگان و اعضای تیم. با تشکر از [@DanielEScherzer](https://github.com/DanielEScherzer) و [@RokyZevon](https://github.com/RokyZevon)!

### توسعه

 - به‌روزرسانی GitHub Action برای نصب .NET 9 جهت پشتیبانی انتشار MSStore.
 - به‌روزرسانی جایگزین نسخه در bug_report.yml برای جلوگیری از نسخه‌دهی نادرست v0.70.0 در گزارش‌ها.
 - ارتقای GitHub Action به نسخه 4 actions/setup-dotnet برای انتشار MSStore.
 - افزودن securityContext به فایل‌های پیکربندی WinGet، امکان فراخوانی از کانتکست کاربر و درخواست UAC واحد برای منابع ارتقاءیافته در فرآیندی جداگانه. با تشکر از [@mdanish-kh](https://github.com/mdanish-kh)!
 - تغییر پسوند فایل‌های گزارش از .txt به .log برای پشتیبانی بهتر از ابزارها و افزوده شدن گزارش‌های Workspace. با تشکر از [@benwa](https://github.com/benwa)!
 - ارتقای وابستگی‌های چارچوب تست و هماهنگ‌سازی نسخه بسته‌ها در کامپوننت‌ها.
 - ارتقای وابستگی‌ها برای رفع آسیب‌پذیری‌ها.
 - بهبود امنیت مخزن با اتصال اقدامات GitHub و تگ‌های Docker به کمیت‌های غیرقابل تغییر و افزودن اسکن خودکار آسیب‌پذیری وابستگی‌ها از طریق Dependency Review Workflow. با تشکر از [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - ارتقای وابستگی‌های Boost به نسخه جدیدتر.
 - ارتقای toolkit به آخرین نسخه و بی‌صدا کردن هشدارهای مرتبط با AoT.
 - رفع مشکلی که امضای فایل‌های جدید باعث شکست ساخت می‌شد.
 - بروزرسانی خط لوله انتشار برای جلوگیری از انتشار نمادهای خصوصی به مدت 100 سال.
 - معرفی fuzzing برای PowerRename جهت بهبود پایداری و افزودن راهنمای راه‌اندازی برای گسترش fuzzing به سایر ماژول‌های C++.
 - افزودن ایجاد متمرکز پوشه‌های تولیدی برای همه پروژه‌های .csproj جهت جلوگیری از شکست ساخت.
 - بروزرسانی WinAppSDK به آخرین نسخه 1.7.
 - ارتقای وابستگی‌های Boost به آخرین نسخه برای پروژه Fuzzing PowerRename.
 - بروزرسانی مسیر ناحیه ADO در tsa.json برای رفع خطاهای خط لوله TSA به دلیل مسیر منقضی شده.
 - شروع پشتیبانی از AoT برای CmdPal با کارهای زیربنایی در حال انجام.
  
### ابزار/عمومی

 - افزودن پشتیبانی از خودکارسازی ایجاد گزارش باگ با تولید URL مسئله GitHub از پیش پر شده همراه با اطلاعات سیستم و تشخیص. با تشکر از [@donlaci](https://github.com/donlaci)!
 - افزودن اسکریپت‌هایی برای ساخت محلی نصب‌کننده و اطمینان از قابلیت اجرای محلی CmdPal.
 - حذف منطق export PFX برای حذف استفاده از رمز عبور هاردکد و رفع هشدار امنیتی PSScriptAnalyzer.
 - افزودن اسکریپت PowerShell و یکپارچه‌سازی CI برای رعایت استفاده یکسان از Common.Dotnet.CsWinRT.props در همه پروژه‌های C# زیر پوشه src.
   
### برنامه‌ریزی برای نسخه 0.92

برای [v0.92][github-next-release-work]، روی موارد زیر کار خواهیم کرد:

 - ادامه تکمیل و بهبود Command Palette
 - تست‌های جدید خودکارسازی UI
 - کار روی ارتقاء نصب‌کننده
 - ارتقای رابط ویرایشگر Keyboard Manager
 - پایداری / رفع اشکال

## جامعه PowerToys

تیم PowerToys از داشتن [حمایت جامعه فعال بی‌نظیر][community-link] بسیار سپاسگزار است. کار شما بسیار مهم است. بدون کمک شما در گزارش باگ، به‌روزرسانی مستندات، راهنمایی در طراحی یا نوشتن ویژگی‌ها، PowerToys به این جایگاه نمی‌رسید. ما قدردان شما هستیم و می‌خواهیم وقت بگذاریم و کار شما را ارج نهیم. ماه به ماه، شما مستقیماً به بهتر شدن PowerToys کمک می‌کنید.

## منشور اخلاقی

این پروژه [منشور اخلاقی متن‌باز مایکروسافت][oss-conduct-code] را پذیرفته است.

## بیانیه حریم خصوصی

این برنامه داده‌های تشخیصی پایه (تله‌متری) را ثبت می‌کند. برای اطلاعات بیشتر درباره حریم خصوصی و داده‌های جمع‌آوری‌شده، [مستندات داده و حریم خصوصی PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation) را مشاهده کنید.

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---