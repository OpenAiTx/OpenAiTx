
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
دامپ‌های PIC16/Xyclops از ایکس‌باکس اصلی و پایگاه‌های داده IDA با مقداری مهندسی معکوس انجام‌شده.

![تصویر PIC16LC63A از ایکس‌باکس اصلی](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# فلش کردن Xyclops (XycloMod)
ببینید [دایرکتوری Xyclops و فایل README](/Xyclops)

# دامپ‌ها
فایل .bin برای هر دامپ PIC به صورت جفت‌شده بایت‌ها قرار دارد تا به درستی در IDA بارگذاری شود. بنابراین اولین کلمه حافظه PIC برابر است با byte_0 + byte_1 << 8.

پایگاه‌های داده .idb مربوط به IDA شامل اطلاعاتی درباره متغیرها و برخی مشاهدات در دفترچه یادداشت پایگاه داده هستند.

برای بررسی نسخه‌های SMC به این صفحه ویکی مراجعه کنید: https://xboxdevwiki.net/Xboxen_Info

## B2A
از یک ایکس‌باکس DVT3 دامپ شده است. کلمه پیکربندی آن همانند P01 است. همچنین شناسه دستگاه در ناحیه پیکربندی به صورت 0000 0000 000B 002A ثبت شده است، برخلاف PICهای تولیدی.

چالش بوت به طور کامل حذف شده است.

## D01
از ایکس‌باکس XDK BETA 2 دامپ شده است. به جز حذف چالش بوت، با P01 یکسان است. تابع محاسبه پاسخ مورد انتظار چالش بوت هنوز وجود دارد اما هرگز فراخوانی نمی‌شود.

## DXF
از یک کیت دیباگ XDK D2 دامپ شده است. بسیار شبیه D01 اما با منطق سینی، منطق داغ شدن و منطق بوت کمی متفاوت. چالش بوت همانند D01 حذف شده است.

## D2E
از یک کیت توسعه Tuscany (نسخه 1.6) دامپ شده است. چیپ Xyclops با علامت X01202-001 مشخص شده و فاقد خط A-A02 یا A-B01 است که در واحدهای خرده‌فروشی وجود دارد.

کد سریال دیباگ در آدرس FC00 با دامپ P2L خرده‌فروشی مطابقت دارد. یک الگوی عجیب داده از 0x4000 تا 0xFBFF وجود دارد.

## P01
از ایکس‌باکس نسخه 1.0 دامپ شده است. کلمه پیکربندی برابر 0x86 است:
- CP1:CP0 = 0 (محافظت کد برای کل حافظه فعال است)
- BODEN = 0 (ریست Brown-out غیرفعال است)
- ~PWRTE = 0 (تایمر روشن شدن فعال است)
- WDTE = 1 (تایمر Watchdog فعال است)
- FOSC1:FOSC0 = 2 (نوسان‌ساز HS)

یک مقدار پیکربندی 0x3FB6 برای کپی‌های SMC مناسب است تا محافظت کد فعال نباشد.

## P11
از ایکس‌باکس نسخه 1.3 دامپ شده است. کلمه پیکربندی همانند P01 است.

چند تغییر کوچک در P11 نسبت به P01 وجود دارد از جمله یک فرمان SMBus اضافه (نوشتن 0x22)، اولویت‌های LED متفاوت و زمان‌بندی‌های منعطف‌تر برای بوت.

دامپ‌های درهم نسخه 1.3 را با نسخه 1.4 مقایسه کردم و مطابقت داشتند. این بدان معناست که به احتمال زیاد برنامه یکسانی دارند.

## P2L
از یک ایکس‌باکس نسخه v1.6 استخراج شده است. نسخه Xyclops A-A02. این شامل کد Intel 8051 است اما تعداد زیادی ثبات عملکرد ویژه دارد که عملکرد آن‌ها نامشخص است.

سریال دیباگ توسط کد در FC00 تغذیه می‌شود. به نظر می‌رسد یک دیباگر ابتدایی باشد که می‌تواند اجرای برنامه را متوقف کند، داده‌ها را استخراج کند و به ثبات‌ها/RAM بنویسد.

# استخراج Xyclops

تراشه Xyclops دارای ۳ پایه برای 'دیباگ' است: TXD (پایه ۶۴)، RXD (پایه ۶۳) و DEBUG (پایه ۲۹). برای فعال‌سازی پورت سریال روی پایه‌های TX و RX، پایه DEBUG را در وضعیت بالا قرار دهید. سریال با نرخ ۹۶۰۰ بود کار می‌کند.

پروتکل بر اساس دستورات ۴ بایتی است که معمولاً به صورت `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>` هستند.

دستور 0x14 هر بار ۶۴ بایت داده BIOS را استخراج می‌کند و 0x15 هر بار ۶۴ بایت داده برنامه SMC را استخراج می‌کند. یک استخراج از Xyclops به نام P2L.bin در مخزن گنجانده شده است. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) نیز برای استخراج داده‌های دستگاه خودتان موجود است.

# روش استخراج PIC
شرح کامل در https://wiki.recessim.com/view/PIC_Burnout

PIC دارای محافظت کد فعال است، بنابراین تمام داده‌ها به صورت ۰۰۰۰ خوانده می‌شود. من از یک ترفند برای خروجی گرفتن داده‌های رمزگذاری‌شده استفاده کردم، الگوریتم رمزگذاری را با استفاده از یک تراشه قربانی کشف کردم و سپس از نوعی اکسپلویت برای تغییر داده ROM جهت اصلاح برخی بیت‌ها به مقادیر شناخته‌شده استفاده کردم. سپس می‌توانم اطلاعات مورد نیاز را از چندین استخراج رمزگذاری‌شده برای بازسازی داده اصلی دریافت کنم.

# PICProgrammer
PICProgrammer یکی از چند پروژه آردوینو برای RP2040 است که در تحقیقاتم استفاده کردم. این یک رابط خط فرمان ساده برای انجام عملیات ICSP (برنامه‌نویسی سریال مدار درون‌مدار) روی PIC فراهم می‌کند. این بر استفاده از برنامه‌نویس اختصاصی مانند PICkit ترجیح داده می‌شود به علت انعطاف‌پذیری و امکان انجام کارهایی که شرکت سازنده در نظر نگرفته است.

قبل از استفاده از این ابزار باید درک خوبی از الکترونیک و برنامه‌نویسی داشته باشید و به دقت بررسی کنید که هر دستور چه کاری انجام می‌دهد.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---