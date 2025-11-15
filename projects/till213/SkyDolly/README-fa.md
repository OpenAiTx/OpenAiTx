
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![پیش‌انتشار](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![مجوز: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![++C20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![کامپایلرهای پشتیبانی‌شده](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![تست‌های واحد](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# اسکای دالی
اسکای دالی - گوسفند سیاه برای ضبط پروازهای شما.

## درباره
اسکای دالی به یک نمونه در حال اجرای Flight Simulator 2020 متصل می‌شود و متغیرهای مختلف شبیه‌سازی را برای پخش مجدد ضبط می‌کند.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

اتصال از طریق SimConnect برقرار می‌شود، یک API استاندارد که با Flight Simulator X برای اتصال به شبیه‌ساز پرواز معرفی شد.

همچنین به [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md) مراجعه کنید.

## ویژگی‌ها
- ضبط / توقف / پخش
- پروازهای گروهی (چند هواپیما، پخش مجدد هنگام ضبط، "پرواز با گروه"، اختلاف زمانی)
- نرخ نمونه‌برداری ضبط قابل تنظیم: ثابت یا متغیر ("اتوماتیک")
- سرعت پخش قابل تنظیم ("حرکت آهسته"، "تایم‌لپس")، حلقه پخش مجدد
- متغیرهای موقعیت، سرعت و کنترل پایه پرواز (ایلرون‌ها، رادر، فلپ‌ها، چرخ‌ها و ...) ضبط می‌شوند
- معماری افزونه با افزونه‌های مختلف وارد/صادر کردن (CSV، GPX، IGC، KML)
- ماژول مکان با بیش از ۱۰۰ مکان پیش‌فرض و قابلیت وارد/صادر کردن
- پایداری مبتنی بر پایگاه داده (SQLite) ("دفترچه پرواز")

تریلر پیش‌نمایش نسخه را در [یوتیوب](https://www.youtube.com/watch?v=_n4qRtm78_I) مشاهده کنید:

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

برای ویدئوهای بیشتر که با اسکای دالی ساخته شده‌اند به [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md) مراجعه کنید. ویژگی‌های جدید و در حال توسعه در [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md) یافت می‌شوند.

## استفاده پایه

- یک پرواز را شروع کنید
- روی "ضبط" کلیک کنید (کلید R)
- می‌توانید ضبط را متوقف کنید (کلید P)
- ضبط را متوقف کنید (کلید R) و روی "پخش" کلیک کنید (کلید فاصله)
- سرعت پخش را تنظیم کنید و موقعیت پخش را حتی در زمان پخش تغییر دهید
- پروازهای ضبط‌شده به طور خودکار در "دفترچه پرواز" ذخیره می‌شوند
- یک پرواز را در دفترچه پرواز انتخاب کرده و "بارگذاری" را فشار دهید (یا روی ردیف دوبار کلیک کنید) تا پرواز ذخیره‌شده بارگذاری شود

### ضبط و پخش گروهی

#### ضبط

- به ماژول "Formation" (کلید F2) بروید
- روی "Record" کلیک کنید (کلید R)
- هر هواپیمای ضبط شده به پرواز فعلی اضافه می‌شود
- در حالی که هواپیماهای موجود در طول ضبط با نرخ نمونه‌برداری "auto" بازپخش می‌شوند، هنوز می‌توانید نرخ نمونه‌برداری ضبط را تغییر دهید

#### موقعیت

- آخرین هواپیمای ضبط شده به عنوان "هواپیمای کاربر" انتخاب می‌شود (که دوربین در شبیه‌ساز پرواز آن را دنبال می‌کند)
- قبل از ضبط، موقعیتی نسبی نسبت به "هواپیمای کاربر" فعلی انتخاب کنید

#### بازپخش

- به سادگی روی "Play"، "Pause" کلیک کنید و در خط زمان حرکت کنید، درست مانند پرواز یک هواپیما
- "هواپیمای کاربر" را تغییر دهید (حتی هنگام بازپخش) تا "از کابین به کابین دیگر بپرید"
- با انتخاب گزینه "Take control" یا "Fly with Formation" کنترل "هواپیمای کاربر" را به دست بگیرید

#### مدیریت آرایش‌ها

- می‌توانید هواپیماهای منفرد را از یک پرواز ("formation") حذف کنید
- باید حداقل یک هواپیما در هر پرواز باشد، بنابراین آخرین هواپیما قابل حذف نیست
- یک اختلاف زمانی به هواپیمای انتخاب شده اضافه کنید ("هماهنگ‌سازی پرواز آرایش چندنفره")
- برای شروع یک پرواز جدید با یک هواپیما، به ماژول "Logbook" (کلید F1) بازگردید و روی "Record" کلیک کنید (کلید R)

چرا یکی از ["تورهای راهنما"](https://github.com/till213/Tell-Tours) را امتحان نمی‌کنید؟ :)

## دانلود

به [انتشارها](https://github.com/till213/SkyDolly/releases) بروید و آخرین نسخه را دانلود کنید.

آخرین نسخه (پیش‌انتشار): **Sky Dolly 0.19.2**

مقدار checksum خود را محاسبه و با [checksumهای SHA-256 منتشرشده](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md) مقایسه کنید تا صحت نسخه دانلودشده خود را بررسی نمایید.

## ساخت

به مستندات [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) مراجعه کنید.

## پروژه‌های مرتبط

- https://github.com/nguyenquyhy/Flight-Recorder - یک نرم‌افزار ضبط و بازپخش پرواز مبتنی بر دات‌نت
- https://github.com/saltysimulations/saltyreplay/ - ضبط و بازپخش با رابط کاربری وب
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - پرواز را ضبط کرده و بازپخش با فرمت Google Earth (KML) تولید می‌کند
- https://github.com/Elephant42/FS_Tool - ابزاری ساده برای تعیین موقعیت هواپیما و نرخ شبیه‌سازی
- https://github.com/pyviator/msfs-geoshot - عکس‌های صفحه را گرفته و به صورت خودکار موقعیت جغرافیایی آن‌ها را ثبت می‌کند
- https://github.com/ijl20/msfs_logger_replay - ثبت‌کننده IGC و بازپخش (برای FSX)
- https://joinfs.net/ - امکان همگام‌سازی پرواز چندنفره بین شبیه‌سازهای مختلف پرواز (MSFS، Prepar3D/FSX، XPlane) را فراهم می‌کند. همچنین شامل ضبط‌کننده پرواز با ضبط پرواز گروهی ("overdub") است.
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote برای A32NX شرکت FlyByWire: کنترل عملکرد کابین خلبان هواپیمای FBW A320 با استفاده از FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer دفترچه ثبت پرواز MSFS را تحلیل کرده و خروجی CSV قابل خواندن توسط Sky Dolly را ارائه می‌کند
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave به صورت خودکار (یا به درخواست) برنامه‌های پرواز را ذخیره می‌کند
- https://github.com/mracko/MSFS-Landing-Inspector - عملکرد فرود شما را تحلیل می‌کند
- [نقاط دیدنی (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - نقاط دیدنی، فرودگاه‌ها و شهرهای سه‌بعدی در Microsoft Flight Simulator.

## منابع مفید دیگر

- https://obsproject.com/ - نرم‌افزار ضبط و پخش صفحه نمایش
- https://sqlitebrowser.org/ - مرور فایل‌های پایگاه داده دفترچه ثبت Sky Dolly (*.sdlog)، اجرای کوئری‌های SQL دلخواه


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---