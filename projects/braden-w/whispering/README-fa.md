<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">ویسپِرینگ</h1>
  <p align="center">دیکته‌نویسی یکپارچه با قدرت مدل Whisper اوپن‌ای‌آی</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## درباره

ویسپِرینگ یک برنامه متن‌باز تبدیل گفتار به متن است که امکانات سراسری و قابلیت‌هایی مانند میانبرهای صفحه‌کلید و کپی و چسباندن خودکار را برای دیکته‌نویسی هر چه روان‌تر ارائه می‌دهد.

در پشت صحنه، این برنامه با مدل Whisper اوپن‌ای‌آی کار می‌کند که دقتی به‌مراتب بالاتر از ابزارهای دیکته داخلی دارد.

> **نکته مهم**: ویسپرینگ در درجه اول به عنوان یک ابزار تبدیل گفتار به متن طراحی شده است، نه یک ابزار ضبط صدا. برای ضبط‌های طولانی‌تر که پایداری اهمیت دارد، توصیه می‌کنم از یک اپلیکیشن ضبط اختصاصی بر روی تلفن همراه یا دستگاه خود که از APIهای ضبط بومی استفاده می‌کند بهره ببرید. این کار باعث اطمینان از کیفیت بالای صدا و پایداری ضبط می‌شود.

## دموها

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## ویژگی‌های کلیدی

1. **تبدیل گفتار به متن سراسری**: از هرجای سیستم با میانبر جهانی صفحه‌کلید یا تنها دو کلیک به قابلیت تبدیل گفتار به متن Whisper دسترسی داشته باشید.
2. **تجربه چندسکویی**:
   - برنامه دسکتاپ: امکان تبدیل گفتار به متن در تمام برنامه‌ها را فراهم می‌کند.
   - افزونه مرورگر: تبدیل گفتار به متن را در مرورگر با ارتباط با وب‌اپلیکیشن ارائه می‌دهد.
3. **ادغام با چت**: افزونه مرورگر دکمه ضبط را به وب‌سایت‌های ChatGPT و Claude اضافه می‌کند و امکان ورود صوتی مستقیم و تبدیل آن در رابط چت را می‌دهد.
4. **مدیریت تبدیل‌ها**: مشاهده و ویرایش تبدیل‌ها درون برنامه ویسپرینگ برای اطمینان از صحت و وضوح متن.
5. **ادغام خودکار با کلیپ‌بورد**: پس از اتمام تبدیل، متن به طور خودکار در کلیپ‌بورد شما کپی می‌شود. گزینه‌ای برای چسباندن خودکار نیز موجود است.

## داده‌های من چگونه ذخیره می‌شود؟

ویسپرینگ تا حد ممکن داده‌ها را به صورت محلی روی دستگاه شما ذخیره می‌کند، شامل صداهای ضبط‌شده و متون تبدیل‌شده. این رویکرد حداکثر حریم خصوصی و امنیت داده را تضمین می‌کند. در اینجا خلاصه‌ای از نحوه مدیریت داده‌ها آمده است:

1. **ذخیره‌سازی محلی**: صداها و تبدیل‌ها در IndexedDB ذخیره می‌شوند که به عنوان فضای ذخیره‌سازی blob و مکانی برای ذخیره تمام داده‌های شما مانند متن و تبدیل‌ها استفاده می‌شود.

2. **سرویس تبدیل گفتار به متن**: تنها داده‌ای که به جایی دیگر ارسال می‌شود، صدای ضبط‌شده شما به سرویس تبدیل بیرونی است—آن‌هم فقط در صورتی که خودتان انتخاب کنید. گزینه‌های شما:
   - سرویس‌های خارجی مانند OpenAI یا Groq
   - سرویس تبدیل محلی مانند `faster-whisper-server` که همه چیز را روی دستگاه نگه می‌دارد

3. **تنظیمات قابل پیکربندی**: می‌توانید سرویس تبدیل را در تنظیمات تغییر دهید تا حداکثر عملکرد محلی را داشته باشید.


## نصب

### وب‌اپلیکیشن

به [whispering.bradenwong.com](https://whispering.bradenwong.com/) مراجعه کنید که آخرین نسخه پوشه `apps/app` روی Vercel میزبانی شده است.

### افزونه کروم

افزونه کروم را از فروشگاه کروم وب از [اینجا](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo) نصب کنید.

### برنامه دسکتاپ

برای دانلود و نصب برنامه دسکتاپ ویسپرینگ، مراحل زیر را متناسب با سیستم‌عامل خود دنبال کنید:

#### ویندوز

1. بسته نصب با پسوند `.msi` را از [صفحه آخرین نسخه‌ها](https://github.com/braden-w/whispering/releases) دانلود کنید.
2. فایل `.msi` دانلودشده را باز کنید تا نصب‌کننده اجرا شود.
3. اگر به عنوان ناامن هشدار داده شد، روی `More Info` -> `Run Anyway` کلیک کنید تا نصب ادامه یابد.
4. دستورالعمل‌های روی صفحه را برای تکمیل نصب دنبال کنید.

#### macOS

برای نصب ویسپرینگ روی مک‌اواس، مراحل زیر را دنبال کنید:

1. **دانلود بسته نصب**:
   - به [صفحه آخرین نسخه‌ها](https://github.com/braden-w/whispering/releases) مراجعه کنید.
   - بسته مناسب را انتخاب کنید:
     - برای Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - برای Intel: `Whispering_x.x.x_x64.dmg`

2. **نصب برنامه**:
   - فایل `.dmg` دانلود شده را باز کنید.
   - برنامه ویسپرینگ را به پوشه Applications بکشید.

3. **اجرای ویسپرینگ**:
   - ویسپرینگ را از پوشه Applications باز کنید.
   - اگر هشدار مربوط به توسعه‌دهنده تأییدنشده دیدید:
     - روی `Cancel` کلیک کنید
     - در Finder روی برنامه راست‌کلیک و گزینه `Open` را انتخاب کنید

4. **رفع اشکال** (فقط Apple Silicon):
   اگر با خطای `"Whispering" is damaged and can't be opened` مواجه شدید:
   - ترمینال را باز کنید
   - دستور زیر را اجرا کنید:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - دوباره تلاش به اجرای برنامه کنید

پس از انجام این مراحل، ویسپرینگ باید روی سیستم macOS شما آماده استفاده باشد.

#### لینوکس

برای لینوکس گزینه‌های نصب مختلفی موجود است. مورد مناسب محیط خود را انتخاب کنید:

1. **AppImage**:

   - فایل `.AppImage` را از [صفحه آخرین نسخه‌ها](https://github.com/braden-w/whispering/releases) دانلود کنید.
   - فایل را اجرایی کنید:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - AppImage را اجرا کنید:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **بسته DEB (دبیان/اوبونتو)**:
   - فایل `.deb` را از [صفحه آخرین نسخه‌ها](https://github.com/braden-w/whispering/releases) دانلود کنید.
   - بسته را با استفاده از `dpkg` نصب کنید:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - رفع مشکلات وابستگی:
     ```bash
     sudo apt-get install -f
     ```

پس از نصب، برنامه آماده استفاده خواهد بود.

## استفاده

### افزونه کروم

پس از نصب افزونه کروم، آیکون ویسپرینگ را در نوار افزونه‌های کروم خواهید دید. روی این آیکون کلیک کنید تا افزونه باز شود. دکمه میکروفون را برای ضبط صدای خود فشار دهید و پس از پایان روی دکمه مربع کلیک کنید. متن تبدیل‌شده در جعبه متن زیر نمایش داده می‌شود.

برای استفاده از قابلیت ChatGPT یا Claude، به صفحه مربوط به ChatGPT یا Claude بروید. یک دکمه ضبط جدید در رابط چت مشاهده خواهید کرد. این دکمه را برای شروع و توقف ضبط فشار دهید و متن تبدیل‌شده به طور خودکار در فیلد ورودی چت قرار می‌گیرد.

برای استفاده از قابلیت میانبر، کلیدهای <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> یا <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (قابل تنظیم بعدی از طریق میانبرهای افزونه کروم) را فشار دهید تا از هر وب‌سایتی ضبط را آغاز کنید. متن تبدیل‌شده به طور خودکار در کلیپ‌بورد شما کپی و در فیلد ورودی جاری چسبانده می‌شود.

افزونه کروم با [whispering.bradenwong.com](https://whispering.bradenwong.com) ارتباط برقرار می‌کند و در صورت عدم وجود تب، به طور خودکار تلاش می‌کند یک تب در پس‌زمینه بسازد. بیشتر باگ‌ها ناشی از شکست این ارتباط است؛ مانند موارد نادری که تب به خواب می‌رود.

### وب‌اپلیکیشن

وب‌اپلیکیشن از طریق [whispering.bradenwong.com](https://whispering.bradenwong.com) در دسترس است. دکمه میکروفون را فشار دهید تا صدای خود را ضبط کنید و پس از پایان روی دکمه مربع کلیک کنید. متن تبدیل‌شده در جعبه متن نمایش داده می‌شود.

### برنامه دسکتاپ

پس از نصب برنامه دسکتاپ ویسپرینگ، با فشار دادن <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (قابل تنظیم در تنظیمات) می‌توانید از هرجای دسکتاپ ضبط را آغاز کنید. متن تبدیل‌شده به طور خودکار در کلیپ‌بورد شما کپی و چسبانده می‌شود، هرچند هر دو قابلیت را می‌توانید در تنظیمات فعال یا غیرفعال کنید.

## ساخته شده با

#### وب و دسکتاپ

برنامه ویسپرینگ با استفاده از فناوری‌ها و کتابخانه‌های زیر ساخته شده است:

- [Svelte 5](https://svelte.dev): کتابخانه انتخابی برای واکنش‌پذیری رابط کاربری.
- [SvelteKit](https://kit.svelte.dev/docs): برای مسیر‌دهی و تولید سایت ایستا، هم برای وب‌سایت و هم رابط کاربری ایستای برنامه Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): چارچوب برنامه دسکتاپ.
- [Effect-TS](https://github.com/Effect-TS/effect): برای اضافه کردن مقداری برنامه‌نویسی تابعی و نوشتن توابع با ایمنی نوع بسیار بالا، که خطاها نیز در نوع بازگشتی امضا تابع لحاظ می‌شوند.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): کتابخانه Toast ساده و قابل تنظیم برای برنامه‌های Svelte. برای ثبت و نمایش خطاهای منتقل‌شده توسط Effect-TS از تابع `renderAsToast` استفاده می‌شود.
- [TanStack Table](https://tanstack.com/table): برای جدول‌های داده.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): API سطح پایین برای ذخیره مقادیر زیاد داده ساختاریافته در مرورگر. با Tanstack Table همگام‌سازی می‌شود.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): کتابخانه کامپوننت رابط کاربری انتخابی.
- [TailwindCSS](https://tailwindcss.com/docs): فریم‌ورک CSS با رویکرد utility-first برای ساخت سریع رابط‌های کاربری سفارشی.
- [Turborepo](https://turborepo.org/): برای مدیریت مونو-ریپو، تا `apps/app` و `apps/extension` بتوانند از یک کدبیس مشترک استفاده کنند و تکرار کد به شدت کاهش یابد و مهم‌تر از آن یک منبع حقیقت واحد حفظ شود.
- [Rust](https://www.rust-lang.org): برای توسعه قابلیت‌های برنامه دسکتاپ، مانند استفاده از crate `enigo` برای انجام چسباندن خودکار.
- [Vercel](https://vercel.com/): میزبانی مناسب برای پروژه‌های شخصی با ادغام‌های خوب با Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): کتابخانه افکت‌های صوتی بدون حق امتیاز.

#### افزونه

افزونه کروم ویسپرینگ با استفاده از موارد زیر ساخته شده است:

- [Plasmo](https://docs.plasmo.com/): چارچوب ساخت افزونه‌های کروم. ما از [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) برای ارتباط با وب‌سایت ویسپرینگ استفاده می‌کنیم.
- [Effect-TS](https://github.com/Effect-TS/effect): برای اضافه کردن مقداری برنامه‌نویسی تابعی و نوشتن توابع با ایمنی نوع بسیار بالا، که خطاها نیز در نوع بازگشتی امضا تابع لحاظ می‌شوند.
- [React](https://reactjs.org): کتابخانه واکنش‌پذیری رابط کاربری برای افزونه کروم، چون متأسفانه Plasmo از Svelte 5 پشتیبانی نمی‌کند.
- [ShadCN](https://github.com/shadcn): کتابخانه کامپوننت رابط کاربری برای افزونه کروم.
- [TailwindCSS](https://tailwindcss.com/docs): یک فریم‌ورک CSS مبتنی بر ابزارها برای ساخت سریع رابط‌های کاربری سفارشی.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): API افزونه کروم.
- [Zapsplat.com](https://www.zapsplat.com/): کتابخانه‌ای از افکت‌های صوتی بدون حق امتیاز.

## اجرای Whispering در حالت توسعه محلی

برای راه‌اندازی پروژه روی دستگاه خود، مراحل زیر را دنبال کنید:

1. مخزن را کلون کنید: `git clone https://github.com/braden-w/whispering.git`
2. به دایرکتوری پروژه بروید: `cd whispering`
3. وابستگی‌های لازم را نصب کنید: `pnpm i`

برای اجرای برنامه دسکتاپ و وب‌سایت Whispering در حالت توسعه:

4. به دایرکتوری اپلیکیشن بروید: `cd apps/app`
5. سرور توسعه را اجرا کنید: `pnpm tauri dev`

برنامه دسکتاپ باید به‌طور خودکار برای توسعه محلی باز شود. برای توسعه برنامه وب، مرورگر خود را باز کنید و به `http://localhost:5173` بروید.

برای اجرای افزونه کروم Whispering در حالت توسعه:

4. به دایرکتوری افزونه بروید: `cd apps/extension`
5. سرور توسعه را اجرا کنید: `pnpm dev --target=chrome-mv3`

برای توسعه افزونه کروم، آن را با رفتن به `chrome://extensions`، فعال کردن حالت توسعه‌دهنده و بارگذاری پوشه `apps/extension/build/{platform}-{manifest-version}-dev` به عنوان افزونه unpacked در کروم بارگذاری کنید.

## ساخت فایل اجرایی به‌صورت شخصی

اگر نسبت به قابل اعتماد بودن نصب‌کننده‌ها نگرانی دارید یا می‌خواهید کنترل بیشتری داشته باشید، همیشه می‌توانید فایل اجرایی را خودتان بسازید. این کار به تنظیمات بیشتری نیاز دارد، اما اطمینان می‌دهد که دقیقاً همان کدی را اجرا می‌کنید که انتظار دارید. این زیبایی نرم‌افزار متن‌باز است!

### کروم

1. به دایرکتوری افزونه بروید: `cd apps/extension`
2. وابستگی‌های لازم را نصب کنید: `pnpm i`
3. ساخت Plasmo را اجرا کنید: `pnpm plasmo build --target=chrome-mv3`
4. خروجی باید در `apps/extension/build/chrome-mv3-prod` یافت شود که می‌توانید آن را به عنوان افزونه unpacked در کروم بارگذاری کنید.
5. همچنین می‌توانید افزونه را برای Chrome Web Store بسازید: `pnpm plasmo build --target=chrome-mv3 --release`

### فایرفاکس

1. به دایرکتوری افزونه بروید: `cd apps/extension`
2. وابستگی‌های لازم را نصب کنید: `pnpm i`
3. ساخت Plasmo را اجرا کنید: `pnpm plasmo build --target=firefox-mv3`
4. خروجی باید در `apps/extension/build/firefox-mv3-prod` یافت شود که می‌توانید آن را به عنوان افزونه unpacked در کروم بارگذاری کنید.
5. همچنین می‌توانید افزونه را برای Chrome Web Store بسازید: `pnpm plasmo build --target=firefox-mv3 --release`

### دسکتاپ

1. به دایرکتوری اپلیکیشن بروید: `cd apps/app`
2. وابستگی‌های لازم را نصب کنید: `pnpm i`
3. ساخت Tauri را اجرا کنید: `pnpm tauri build`
4. می‌توانید فایل اجرایی را در دایرکتوری `apps/app/target/release` پیدا کنید.

## مشارکت

ما از مشارکت جامعه استقبال می‌کنیم! اگر مایل به مشارکت در Whispering هستید، لطفاً مراحل زیر را دنبال کنید:

1. مخزن را fork کنید.
2. یک شاخه جدید برای ویژگی یا رفع باگ خود بسازید: `git checkout -b feature/your-feature-name` یا `git checkout -b fix/your-bugfix-name`
3. تغییرات خود را اعمال و با یک پیام توصیفی commit کنید.
4. شاخه خود را به مخزن fork شده‌تان push کنید: `git push origin your-branch-name`
5. یک pull request از مخزن fork شده به مخزن اصلی ایجاد کنید.

لطفاً اطمینان حاصل کنید که کد شما از کنوانسیون‌های تعیین‌شده پیروی می‌کند و به‌خوبی مستند شده است.

## مجوز

Whispering تحت [مجوز MIT](https://opensource.org/licenses/MIT) منتشر شده است.

## حامیان مالی

این پروژه توسط افراد و سازمان‌های فوق‌العاده زیر پشتیبانی می‌شود:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## پشتیبانی و بازخورد

اگر با مشکلی مواجه شدید یا پیشنهادی برای بهبود دارید، لطفاً یک issue در [بخش Issues گیت‌هاب](https://github.com/braden-w/whispering/issues) باز کنید یا از طریق [whispering@bradenwong.com](mailto:whispering@bradenwong.com) با من تماس بگیرید. بازخورد شما واقعاً ارزشمند است!

از اینکه از Whispering استفاده می‌کنید سپاسگزارم و نویسندگی خوشی را برایتان آرزو دارم!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---