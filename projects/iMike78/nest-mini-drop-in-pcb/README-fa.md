
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# برد جایگزین MiciMike برای Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) یک برد جایگزین برای ["Google Nest Mini" (نسل دوم اسپیکر هوشمند گوگل با پورت شارژ بشکه‌ای)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) است که بر اساس میکروکنترلرهای ESP32 و XMOS جهت اجرای نرم‌افزار متن‌باز طراحی شده است.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

نکته! اگر به دنبال برد جایگزین مشابه برای "Google Home Mini" (نسل اول سخت‌افزار اسپیکر هوشمند گوگل با پورت شارژ Micro-USB) هستید، پروژه خواهر را در https://github.com/iMike78/home-mini-v1-drop-in-pcb مشاهده کنید.

**توجه!** کمپین تامین مالی جمعی برای "MiciMike Home Mini Drop-In PCB" (نسل اول Google Home Mini) اکنون در مرحله پیش‌راه‌اندازی Crowd Supply فهرست شده است (فقط پیش‌نمایش پروژه)، و در صورت موفقیت، کمپین مشابهی برای Nest Mini نیز برنامه‌ریزی خواهد شد، پس اینجا را بررسی کنید:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

هر دو پروژه کاملاً متن‌باز سخت‌افزاری هستند که با الهام از [Onju Voice](https://github.com/justLV/onju-voice) اما با هدف پیروی از [استاندارد دستیار صوتی متن‌باز بنیاد Open Home با Home Assistant Voice Preview Edition به عنوان مرجع](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) برای طراحی و مشخصات PCB اجرا شده‌اند.

# دامنه پروژه

هدف این پروژه و مخزن (که مشابه [Onju Voice](https://github.com/justLV/onju-voice) اما تحت مجوز سخت‌افزاری کاملاً متن‌باز است)، طراحی یک برد مدار چاپی (PCB) جایگزین با شماتیک سخت‌افزاری است که هرکسی بتواند آن را بسازد یا از یک تولیدکننده PCB سفارشی سفارش دهد، به عنوان یک PCB جایگزین برای Google Nest Mini (نسل دوم).

این پروژه عمدتاً مخاطب افرادی است که می‌خواهند اسپیکرهای هوشمند قدیمی Google Nest Mini خود را به سخت‌افزار متن‌باز برای [کنترل صوتی Home Assistant](https://www.home-assistant.io/voice_control/) و/یا خروجی اسپیکر پخش موسیقی برای [Music Assistant](https://www.music-assistant.io) تبدیل یا بازتخصیص دهند (اگرچه سخت‌افزار احتمالاً می‌تواند با برنامه‌های دیگر و فرم‌ورهای متفاوت نیز مورد استفاده قرار گیرد زیرا مبتنی بر پلتفرم محبوب Espressif ESP32 است).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

طراحی سخت‌افزار (مشابه با [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) یک SoC از نوع ESP32-S3 را برای WiFi، BLE و [تشخیص کلمه بیدارکننده آنبرد](https://www.home-assistant.io/voice_control/about_wake_word/) (با استفاده از فرم‌ور بدون کدنویسی [ESPHome](https://esphome.io/)) + یک چیپ XMOS xCORE XU316 برای پردازش پیشرفته صوتی (با فرم‌ور سفارشی برای انجام پاک‌سازی میکروفون و بهبود توانایی تشخیص صدا با استفاده از الگوریتم‌های محلی برای حذف نویز، حذف پژواک آکوستیک، حذف تداخل، و کنترل خودکار بهره) ادغام می‌کند.

از نظر عملکردی، این سخت‌افزار عمدتاً با [طراحی مرجع Home Assistant Voice Preview Edition (معروف به Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) که به عنوان سخت‌افزار متن‌باز از سوی بنیاد Open Home با همکاری Nabu Casa منتشر شده، سازگار است. تفاوت اصلی به علت محدودیت‌های تعریف‌شده توسط بدنه و قطعات Google Nest Mini است (یعنی طراحی سخت‌افزاری پروژه nest-mini-drop-in-pcb نیز با همان نوع ورودی‌های فیزیکی محدود شده که در سخت‌افزار اصلی گوگل وجود دارد).

بنابراین دامنه این پروژه/مخزن توسعه ویژگی‌ها یا عملکردهای جدید برای فرم‌ور ESPHome نیست؛ اگر این مورد مدنظر شماست، باید به توسعه فرم‌ور Home Assistant Voice Preview Edition و کد اصلی ESPHome مراجعه کنید:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## درخواست همکاری

اگر در طراحی لایه‌بندی PCB تجربه دارید (به‌ویژه در مسیریابی، گراند پورینگ یا طراحی‌های دیجیتال+آنالوگ حساس به نویز)، **کمک شما بسیار ارزشمند است**! لطفاً آزادانه یک issue جدید باز کنید، پیشنهاد/درخواست ارسال کنید و به موضوعات موجود بازخورد دهید یا این مخزن را fork کنید.

برای اطلاعات بیشتر درباره ایده/مفهوم و مشارکت در بحث مرتبط، به تاپیک زیر در انجمن Home Assistant نیز مراجعه کنید:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### وضعیت فعلی

- ✅ شماتیک تکمیل شد
- ✅ جایگذاری قطعات انجام شد
- ✅ مسیرکشی انجام شد
- ✅ گراند پور، استراتژی شیلدینگ و ملاحظات EMI انجام شد
- ⚠️ اولین سری تست با دو خطا شکست خورد - رفع شد
- 🕓 در انتظار دومین دسته آزمایشی

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## ابزارهای استفاده شده

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC برای دریافت فوت‌پرینت

## مشخصات سخت‌افزاری شناخته‌شده

- برد مدار چاپی ۴ لایه
- چیپ ESP32-S3R8 خام (ESP32-S3 برای وای‌فای، BLE و تشخیص واژه بیدار داخلی)
- XMOS XU316-1024-QF60B-C24 (پردازش صوتی DSP xCORE XMOS XU316)
- حافظه فلش SPI دوگانه (چون ESP32 و XMOS هرکدام فلش SPI خودشان را دارند)
- دو باس I²S (برای امکان داشتن رابط‌های I2S همزمان، یعنی خروجی و ورودی صوتی همزمان)
- TAS5805M (TAS5805MPWPR) برای خروجی بلندگو (تقویت‌کننده صوتی مونو کلاس-D I2S با تنظیم DSP از طریق I2C)
- ۲ عدد میکروفون MEMS (دو عدد MMICT390200012 با فاصله ۶۸ میلی‌متری بین میکروفون‌ها)
- ۶ عدد LED RGB مدل SK6812
- ورودی برق سفارشی USB-C و ۱۴ ولت (توجه! USB-C و کانکتور بشکه‌ای نمی‌توانند همزمان متصل شوند)

---

> ⚠️ فلش کردن از طریق USB-C مستلزم قطع ورودی برق اصلی ۱۴ ولت است. برای جزئیات به یادداشت سیلک‌اسکرین روی PCB مراجعه کنید.

## منابع

### منابع نسخه پیش‌نمایش Home Assistant Voice شامل فایل‌های طراحی PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### فریم‌ور ESPHome برای Home Assistant Voice PE (که از همان ترکیب ESP32-S3 + XMOS XU316 استفاده می‌کند):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### چیپ MCU IC پردازنده XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### فریم‌ور XMOS از پروژه ESPHome برای سخت‌افزار Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## مجوز

این پروژه تحت [مجوز سخت‌افزار باز CERN نسخه ۲ - به شدت متقابل (CERN-OHL-S v2)] منتشر شده است.
هر نسخه تغییر یافته از این سخت‌افزار نیز باید تحت همین مجوز توزیع شود.

☕ اگر مایل هستید از این پروژه حمایت کنید، می‌توانید [برای من در Ko-fi یک قهوه بخرید](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---