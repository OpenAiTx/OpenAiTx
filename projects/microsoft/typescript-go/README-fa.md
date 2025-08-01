# تایپ‌اسکریپت ۷

[مطمئن نیستید این چیست؟ پست اعلامیه را بخوانید!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## پیش‌نمایش

یک نسخه پیش‌نمایش در npm به نام `@typescript/native-preview` در دسترس است.

```sh
npm install @typescript/native-preview
npx tsgo # همانند tsc از این دستور استفاده کنید.
```

یک افزونه پیش‌نمایش برای VS Code [در بازار VS Code موجود است](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

برای استفاده از آن، این گزینه را در تنظیمات VS Code خود قرار دهید:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## نحوه ساخت و اجرا

این مخزن از [Go 1.24 یا بالاتر](https://go.dev/dl/)، [Rust 1.85 یا بالاتر](https://www.rust-lang.org/tools/install)، [Node.js به همراه npm](https://nodejs.org/) و [`hereby`](https://www.npmjs.com/package/hereby) استفاده می‌کند.

برای تست‌ها و تولید کد، این مخزن شامل یک زیرماژول git به مخزن اصلی TypeScript است که به کامیت مورد انتقال اشاره می‌کند.
هنگام کلون کردن، باید با زیرماژول‌ها کلون کنید:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

اگر قبلاً مخزن را کلون کرده‌اید، می‌توانید زیرماژول را با این دستور مقداردهی اولیه کنید:

```sh
git submodule update --init --recursive
```

با قرارگیری زیرماژول و اجرای `npm ci`، می‌توانید وظایف را از طریق `hereby` اجرا کنید، مشابه مخزن TypeScript:

```sh
hereby build          # بررسی اینکه پروژه ساخته می‌شود
hereby test           # اجرای تمام تست‌ها
hereby install-tools  # نصب ابزارهای اضافی مانند linterها
hereby lint           # اجرای تمام linterها
hereby format         # فرمت کردن تمام کدها
hereby generate       # تولید تمام کد Go (مانند diagnostics، متعهد شده به مخزن)
```

وظایف اضافی در دست توسعه هستند.

استفاده از `hereby` برای کار روی مخزن الزامی نیست؛ ابزارهای معمول Go (مانند `go build`، `go test ./...`) همانطور که انتظار می‌رود کار می‌کنند.
وظایف `hereby` صرفاً برای راحتی افرادی است که با مخزن TypeScript آشنایی دارند.

### اجرای `tsgo`

پس از اجرای `hereby build`، می‌توانید `built/local/tsgo` را اجرا کنید که تقریباً مانند `tsc` عمل می‌کند.

### اجرای نمونه اولیه LSP

برای دیباگ و اجرای افزونه VS Code بدون نصب سراسری:

* VS Code را در workspace مخزن اجرا کنید (`code .`)
* فایل `.vscode/launch.template.json` را به `.vscode/launch.json` کپی کنید
* <kbd>F5</kbd> (یا `Debug: Start Debugging` از پنل فرمان)

این کار یک نمونه جدید VS Code اجرا می‌کند که از Corsa LS به عنوان backend استفاده می‌کند. اگر به درستی تنظیم شده باشد، باید هنگام باز بودن یک فایل TypeScript یا JavaScript، عبارت "tsgo" را در نوار وضعیت مشاهده کنید:

![تصویر نمونه اولیه LSP](.github/ls-screenshot.png)


## چه چیزی تا کنون کار می‌کند؟

این پروژه هنوز در حال توسعه است و هنوز به تمام ویژگی‌های TypeScript نرسیده است. ممکن است باگ‌هایی وجود داشته باشد. لطفاً قبل از ثبت یک مشکل جدید یا فرض بر تغییر عمدی، این لیست را با دقت بررسی کنید.

| ویژگی | وضعیت | توضیحات |
|---------|--------|-------|
| ساخت برنامه | انجام شد | همان فایل‌ها و حل ماژول مانند TS5.8. هنوز همه حالت‌های حل پشتیبانی نمی‌شوند. |
| تجزیه/اسکن | انجام شد | دقیقاً همان خطاهای نحوی مانند TS5.8 |
| خط فرمان و تجزیه `tsconfig.json` | تقریباً انجام شد | نقطه ورود فعلاً کمی متفاوت است |
| حل نوع | انجام شد | همان انواع مانند TS5.8 |
| بررسی نوع | انجام شد | همان خطاها، مکان‌ها و پیام‌ها مانند TS5.8. نمایش انواع در خطاها ممکن است متفاوت باشد (در حال انجام) |
| استنتاج مخصوص جاوااسکریپت و JS Doc | آماده نیست | - |
| JSX | انجام شد | - |
| صدور اعلان | در حال انجام | رایج‌ترین ویژگی‌ها پیاده‌سازی شده‌اند، اما برخی موارد خاص و پرچم‌های ویژگی هنوز پشتیبانی نشده‌اند |
| صدور (خروجی JS) | در حال انجام | `target: esnext` به خوبی پشتیبانی می‌شود، سایر اهداف ممکن است کاستی داشته باشند |
| حالت Watch | نمونه اولیه | فایل‌ها را پایش و بازسازی می‌کند، اما بازبینی افزایشی ندارد |
| حالت Build / ارجاعات پروژه | آماده نیست | - |
| ساخت افزایشی | آماده نیست | - |
| سرویس زبان (LSP) | نمونه اولیه | عملکرد حداقلی (خطاها، hover، رفتن به تعریف). ویژگی‌های بیشتری به زودی اضافه می‌شود |
| API | آماده نیست | - |

تعاریف:

 * **انجام شد** یا "فرض بر انجام": در حال حاضر از کمبود یا کار مهم باقی‌مانده‌ای مطلع نیستیم. ثبت باگ بلامانع است
 * **در حال انجام**: در حال کار؛ برخی ویژگی‌ها ممکن است کار کنند و برخی نه. ثبت panicها بلامانع، اما لطفاً چیز دیگری ثبت نکنید
 * **نمونه اولیه**: صرفاً اثبات مفهوم؛ لطفاً باگ ثبت نکنید
 * **آماده نیست**: یا اصلاً شروع نشده یا به قدری دور از آماده بودن است که فعلاً سراغش نروید

## نکات دیگر

در بلندمدت انتظار می‌رود این مخزن و محتوایش با `microsoft/TypeScript` ادغام شود.
در نتیجه، مخزن و issue tracker مربوط به typescript-go در نهایت بسته خواهد شد، پس در بحث‌ها/مسائل این موضوع را در نظر داشته باشید.

برای لیست تغییرات عمدی نسبت به TypeScript 5.7، به CHANGES.md مراجعه کنید.

## مشارکت

این پروژه از مشارکت و پیشنهادات استقبال می‌کند. بیشتر مشارکت‌ها نیاز به موافقت با
توافقنامه مجوز مشارکت‌کننده (CLA) دارد که تأیید می‌کند شما حق و اجازه اعطای استفاده از مشارکت خود را به ما دارید. برای جزئیات، به [توافقنامه مجوز مشارکت‌کننده](https://cla.opensource.microsoft.com) مراجعه کنید.

هنگامی که یک pull request ارسال می‌کنید، یک بات CLA به طور خودکار بررسی می‌کند که آیا باید CLA را ارائه دهید و PR را به طور مناسب نشانه‌گذاری می‌کند (مانند وضعیت، کامنت). تنها کافی است دستورالعمل‌های ارائه شده توسط بات را دنبال کنید. لازم است این کار را فقط یک بار در تمام مخازن ما انجام دهید.

این پروژه از [آیین‌نامه رفتار کد منبع باز مایکروسافت](https://opensource.microsoft.com/codeofconduct/) پیروی می‌کند.
برای اطلاعات بیشتر به [پرسش‌های متداول آیین‌نامه رفتار](https://opensource.microsoft.com/codeofconduct/faq/) مراجعه کنید یا
با [opencode@microsoft.com](mailto:opencode@microsoft.com) تماس بگیرید.

## علائم تجاری

این پروژه ممکن است حاوی علائم تجاری یا لوگوهای پروژه‌ها، محصولات یا خدمات باشد. استفاده مجاز از علائم تجاری یا لوگوهای مایکروسافت مشمول و باید تابع
[دستورالعمل‌های علائم تجاری و برند مایکروسافت](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general) باشد.
استفاده از علائم تجاری یا لوگوهای مایکروسافت در نسخه‌های تغییر یافته این پروژه نباید موجب سردرگمی یا القای حمایت مایکروسافت شود.
هرگونه استفاده از علائم تجاری یا لوگوهای شخص ثالث مشمول سیاست‌های آن شخص ثالث است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---