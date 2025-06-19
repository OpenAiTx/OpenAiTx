# گانتلت

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

راه‌انداز برنامه چندسکویی با محوریت وب و افزونه‌های مبتنی بر React

> [!WARNING]
> لانچر توسط یک توسعه‌دهنده منفرد در اوقات فراغت توسعه داده می‌شود.
> تغییرات ممکن است کند اما پیوسته باشند
>
> احتمالاً تغییرات ناسازگار وجود خواهد داشت که در [فهرست تغییرات](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md) مستند می‌شود.

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## نسخه نمایشی

نسخه نمایشی کمی قدیمی است

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## ویژگی‌ها

- افزونه‌محور
  - افزونه‌ها با TypeScript نوشته می‌شوند
  - API افزونه گسترده
      - ایجاد نمای UI
      - دستورات یک‌باره
      - ارائه پویا لیست دستورات یک‌باره
      - نمایش سریع محتوای "درون‌خطی" دقیقاً زیر نوار جستجوی اصلی بر اساس مقدار آن
      - دریافت محتوا از کلیپ‌بورد و افزودن به آن
  - افزونه‌ها به صورت شاخه جداگانه در مخزن Git توزیع می‌شوند، یعنی توزیع افزونه نیاز به سرور مرکزی ندارد
  - شناسه افزونه‌ها فقط URL مخزن Git هستند
  - UI مبتنی بر [React](https://github.com/facebook/react) برای افزونه‌ها
    - پیاده‌سازی شده با React Reconciler سفارشی (بدون Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno به ایزوله‌سازی کد افزونه جاوااسکریپت برای امنیت بهتر کمک می‌کند
    - افزونه‌ها باید صراحتاً مجوزهای مورد نیاز خود را مشخص کنند
    - Node.js برای اجرای ابزارهای افزونه استفاده می‌شود، اما به عنوان یک توسعه‌دهنده افزونه همیشه کدی می‌نویسید که روی Deno اجرا می‌شود
- از ابتدا با هدف چندسکویی طراحی شده است
- دستورات و نماها را می‌توان با میانبرهای جهانی سفارشی اجرا یا باز کرد
- می‌توان نام مستعار جستجوی سفارشی به دستورات یا نماها اختصاص داد
- پشتیبانی از تم سفارشی
- عملکرد داخلی توسط افزونه‌های بسته‌بندی‌شده ارائه می‌شود
  - Applications: نمایش برنامه‌های نصب‌شده روی سیستم در نتایج جستجو
    - این افزونه همچنین پنجره‌ها و تعلق آن‌ها به برنامه‌ها را ردیابی می‌کند، بنابراین باز کردن یک برنامه بازشده قبلی به طور پیش‌فرض پنجره قبلی را فعال می‌کند
      - در حال حاضر همه سیستم‌ها پشتیبانی نمی‌شوند. [پشتیبانی ویژگی](https://gauntlet.sh/docs/feature-support) را ببینید
  - Calculator: نمایش نتیجه عملیات ریاضی مستقیماً زیر نوار جستجوی اصلی
    - شامل تبدیل ارز بر اساس نرخ تبدیل
    - مبتنی بر [Numbat](https://github.com/sharkdp/numbat)
- مرتب‌سازی نتایج جستجو بر اساس فراوانی و تازگی (Frecency)
   - Frecency ترکیبی از فراوانی و تازگی است
   - هرچه یک آیتم بیشتر استفاده شود، جایگاه بالاتری در لیست نتایج خواهد داشت، اما آیتم‌هایی که قبلاً زیاد استفاده شده‌اند، پایین‌تر از آیتم‌هایی قرار می‌گیرند که اخیراً به همان میزان استفاده شده‌اند
   - نتایج به صورت زیررشته‌ای برای هر واژه تطبیق داده می‌شوند

##### پشتیبانی سیستم‌عامل

##### رسمی
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> لینوکس X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### بهترین تلاش
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> لینوکس Wayland
  - Gnome Wayland هنوز پشتیبانی نمی‌شود، [#40](https://github.com/project-gauntlet/gauntlet/issues/40) را ببینید
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> ویندوز
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## شروع کار

### نصب گانتلت

[نصب](https://gauntlet.sh/docs/installation) را ببینید

### میانبر جهانی

پنجره اصلی را می‌توانید با میانبر جهانی یا دستور CLI باز کنید:
- میانبر جهانی (در تنظیمات قابل تغییر است)
  - ویندوز: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - لینوکس X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - لینوکس Wayland
    - ممکن است میانبر جهانی پشتیبانی نشود، [پشتیبانی ویژگی](https://gauntlet.sh/docs/feature-support) را ببینید
    - لطفاً از دستور CLI استفاده کنید و آن را با رویکرد خاص مدیر پنجره اجرا کنید
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- دستور CLI
  - `gauntlet open`

### نصب افزونه

افزونه‌ها از طریق رابط کاربری تنظیمات نصب می‌شوند. برای نصب آن، از آدرس مخزن Git افزونه استفاده کنید، مانند `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### ساخت افزونه خود

[شروع توسعه افزونه](https://gauntlet.sh/docs/plugin-development/getting-started) را ببینید

## تم‌دهی

[تم‌دهی](https://gauntlet.sh/docs/theming) را ببینید

## ساخت گانتلت

شما به موارد زیر نیاز دارید:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (خود پروژه از آن استفاده نمی‌کند اما یکی از وابستگی‌ها به آن نیاز دارد)
- در لینوکس: `libxkbcommon-dev` (توجه: نام بسته ممکن است بسته به توزیع متفاوت باشد)

### توسعه

برای ساخت نسخه توسعه اجرا کنید:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
در حالت توسعه (بدون ویژگی "release")، برنامه فقط از دایرکتوری‌های داخل دایرکتوری پروژه برای ذخیره وضعیت یا کش استفاده می‌کند تا نصب سراسری دچار مشکل نشود

### نسخه بسته‌بندی‌نشده

برای ساخت باینری نسخه بسته‌بندی‌نشده، اجرا کنید:
```bash
npm ci
npm run build
cargo build --release --features release
```

### بسته‌بندی‌شده
برای ساخت بسته مخصوص هر سیستم‌عامل، یکی از دستورات زیر را اجرا کنید:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

ویندوز:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

لینوکس:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

اما انتشار نسخه جدید باید از طریق GitHub Actions انجام شود

## مشارکت

اگر می‌خواهید به توسعه گانتلت کمک کنید، می‌توانید به روش‌های مختلفی غیر از کدنویسی مشارکت کنید:
- گزارش یک باگ یا مشکل در UI/UX
- ساخت افزونه

برای مشکلات ساده می‌توانید آزادانه یک issue یا PR باز کنید و خودتان آن را حل کنید.
برای تغییرات مهم‌تر لطفاً ابتدا با سازندگان در Discord (لینک دعوت در بالای README) تماس بگیرید و مشورت کنید.

هرگونه مشارکت خوش‌آمد است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---