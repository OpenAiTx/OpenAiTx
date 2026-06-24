
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
**توجه!** در حال حاضر یک کمپین جمع‌سپاری برای «برد جایگزین MiciMike Home Mini Drop-In PCB» (نسل اول Google Home Mini) در فاز پیش‌فروش (صرفاً پیش‌نمایش پروژه) روی Crowd Supply فعال است، و اگر موفق باشد، کمپینی مشابه برای Nest Mini جدیدتر (نسل دوم) نیز برنامه‌ریزی خواهد شد؛ بنابراین اینجا را بررسی کنید و با حمایت از این پروژه به صورت غیرمستقیم آن را پشتیبانی کنید:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

هر دو پروژه کاملاً سخت‌افزار متن‌باز هستند و با الهام از مفاهیم [Onju Voice](https://github.com/justLV/onju-voice) اما با هدف پیروی از [استاندارد دستیار صوتی متن‌باز Open Home Foundation با نسخه پیش‌نمایش Home Assistant Voice به عنوان مرجع](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) برای طراحی و مشخصات PCB.

# دامنه پروژه

هدف این پروژه و مخزن (که مشابه [Onju Voice](https://github.com/justLV/onju-voice) اما تحت مجوز کامل سخت‌افزار متن‌باز است) طراحی برد جایگزین PCB (برد مدار چاپی) با شماتیک سخت‌افزاری است که هر کسی بتواند آن را بسازد یا از یک تولیدکننده PCB سفارشی به عنوان برد جایگزین برای Google Nest Mini (نسل دوم) سفارش دهد.

این پروژه عمدتاً مخاطب کسانی است که می‌خواهند اسپیکرهای هوشمند قدیمی Google Nest Mini خود را به سخت‌افزار متن‌باز برای [کنترل صوتی Home Assistant](https://www.home-assistant.io/voice_control/) و/یا خروجی اسپیکر پخش‌کننده رسانه برای [Music Assistant](https://www.music-assistant.io) تبدیل کنند (البته سخت‌افزار احتمالاً می‌تواند با برنامه‌های دیگر و فریم‌ویرهای متفاوت هم استفاده شود زیرا مبتنی بر پلتفرم محبوب Espressif ESP32 است).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="اولین تست PCB">

طراحی سخت‌افزار (مشابه [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) یک SoC ESP32-S3 برای WiFi، BLE و [تشخیص کلمه بیدار روی برد](https://www.home-assistant.io/voice_control/about_wake_word/) (با فریم‌ویر بدون کد [ESPHome](https://esphome.io/)) + یک چیپ XMOS xCORE XU316 برای پردازش صوتی پیشرفته (با فریم‌ویر سفارشی برای پاک‌سازی میکروفن و ارتقاء قابلیت تشخیص صوت با استفاده از الگوریتم‌های محلی برای حذف نویز، حذف پژواک آکوستیک، حذف تداخل و کنترل خودکار تقویت).

از نظر عملکرد، سخت‌افزار تا حد زیادی با [Home Assistant Voice Preview Edition (معروف به Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) طراحی مرجع (که به صورت طراحی سخت‌افزار متن‌باز توسط Open Home Foundation با همکاری Nabu Casa منتشر شده) سازگار است. تفاوت اصلی به محدودیت‌های تعیین‌شده توسط قاب و اجزای Google Nest Mini برمی‌گردد، (یعنی طراحی سخت‌افزار پروژه nest-mini-drop-in-pcb توسط همان ظرفیت‌های فیزیکی سخت‌افزار اصلی گوگل محدود خواهد شد).

بنابراین دامنه این پروژه/مخزن توسعه قابلیت‌ها/ویژگی‌های جدید برای فریم‌ویر ESPHome نیست؛ اگر چنین چیزی می‌خواهید باید به توسعه فریم‌ویر Home Assistant Voice Preview Edition و همچنین کد اصلی ESPHome مراجعه کنید:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## درخواست همکاری

اگر تجربه‌ای در طراحی PCB دارید (به ویژه در مسیریابی PCB، گسترش زمین، یا طراحی‌های دیجیتال+آنالوگ حساس به نویز)، **کمک شما بسیار ارزشمند است**! لطفاً یک Issue جدید باز کنید، پیشنهاد یا درخواست دهید و در Issues موجود نظر یا بازخورد بگذارید یا مخزن را Fork کنید.

برای اطلاعات بیشتر درباره ایده/مفهوم و مشارکت، به بحث مرتبط در انجمن جامعه Home Assistant نیز مراجعه کنید:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### وضعیت فعلی

- ✅ شماتیک تکمیل شده
- ✅ جایگذاری قطعات انجام شده
- ✅ مسیریابی انجام شده
- ✅ گسترش زمین، استراتژی شیلدینگ و ملاحظات EMI انجام شده
- ⛔ اولین سری تست به دلیل دو خطا شکست خورد - اصلاح شد

- ⚠️ دومین سری آزمایشی به صورت جزئی کار می‌کند
- ✅ گزینه اشکال‌زدایی XTAG4 برای سری بعدی افزوده شد

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## ابزارهای استفاده‌شده

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC برای دریافت فوت‌پرینت قطعات

## مشخصات سخت‌افزاری شناخته‌شده

- برد PCB چهارلایه
- چیپ خالی ESP32-S3R8 (مدل ESP32-S3 برای وای‌فای، BLE و تشخیص واژه بیدارباش داخلی)
- XMOS XU316-1024-QF60B-C24 (پردازش صوتی DSP مدل XMOS XU316 xCORE)
- ۱۶ مگابایت حافظه فلش SPI (برای ESP32-S3)
- ۴ مگابایت حافظه فلش SPI (برای XMOS XU316)
- دو گذرگاه I²S (ورودی و خروجی همزمان صدا)
- تقویت‌کننده استریو کلاس D مدل TAS5805M (TAS5805MPWPR) با DSP داخلی (صوت I2S، کنترل I2C)، پیکربندی‌شده برای خروجی بلندگوی مونو BTL
- ۳ میکروفون MEMS (MMICT390200012) در قوس با شعاع ۳۴ میلی‌متر - فرم‌ور فعلی از ۲ میکروفون استفاده می‌کند، اما پشتیبانی سخت‌افزاری برای آرایه ۳ میکروفونه از قبل موجود است
- ۶ عدد LED RGB مدل SK6812
- ورودی سفارشی USB-C و برق ۱۴ ولت (توجه! USB-C و کانکتور استوانه‌ای را همزمان وصل نکنید)
- کنترلر لمسی خازنی MPR121 (استفاده برای ورودی لمسی به جای سنجش لمسی داخلی ESP32-S3)

---

> ⚠️ برنامه‌ریزی (فلش) از طریق USB-C نیاز به قطع ورودی برق اصلی ۱۴ ولت دارد. برای جزئیات به نوشته روی برد مراجعه کنید.

## منابع

### منابع نسخه پیش‌نمایش صوتی Home Assistant شامل فایل‌های طراحی PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### فرم‌ور ESPHome برای Home Assistant Voice PE (که از همان ترکیب ESP32-S3 + XMOS XU316 استفاده می‌کند):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### تراشه میکروکنترلر XMOS xCORE DSP (XU316-1024-QF60B-C24)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai

#### میان‌افزار XMOS از پروژه ESPHome برای سخت‌افزار نسخه پیش‌نمایش Voice Home Assistant:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## مجوز

این پروژه تحت [مجوز سخت‌افزار باز سرن (CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2))] منتشر شده است.
هر نسخه اصلاح‌شده‌ای از این سخت‌افزار نیز باید تحت همین مجوز توزیع شود.

☕ اگر دوست دارید از این پروژه حمایت کنید، می‌توانید [برای من یک قهوه در Ko-fi بخرید](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---