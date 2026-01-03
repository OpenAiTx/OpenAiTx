
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
هر دوی این پروژه‌ها کاملاً متن‌باز سخت‌افزاری هستند و با الهام از برخی مفاهیم [Onju Voice](https://github.com/justLV/onju-voice) طراحی شده‌اند، اما هدف آن‌ها پیروی از [استاندارد دستیار صوتی متن‌باز Open Home Foundation با Home Assistant Voice Preview Edition به عنوان مرجع](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) برای طراحی و مشخصات PCB است.

# دامنه پروژه

هدف این پروژه و مخزن (که مشابه [Onju Voice](https://github.com/justLV/onju-voice) است اما تحت مجوز کاملاً متن‌باز سخت‌افزاری قرار دارد) طراحی یک PCB جایگزین (برد مدار چاپی) با شماتیک سخت‌افزاری است که هر کسی بتواند آن را بسازد یا از یک تولیدکننده PCB سفارش دهد، به عنوان یک PCB جایگزین سفارشی برای Google Nest Mini (نسل دوم).

این پروژه عمدتاً برای افرادی طراحی شده که به دنبال تبدیل/تغییر کاربری اسپیکرهای هوشمند قدیمی Google Nest Mini خود به سخت‌افزار متن‌باز برای [کنترل صوتی Home Assistant](https://www.home-assistant.io/voice_control/) و/یا خروجی اسپیکر مدیاپلیر برای [Music Assistant](https://www.music-assistant.io) هستند، (البته این سخت‌افزار احتمالاً با برنامه‌های دیگر و فریمورهای دیگر نیز قابل استفاده است زیرا مبتنی بر پلتفرم محبوب Espressif ESP32 می‌باشد).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

طراحی سخت‌افزار (مشابه [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) یک SoC مدل ESP32-S3 را برای WiFi، BLE و [شناسایی واژه‌ی بیدارباش داخلی](https://www.home-assistant.io/voice_control/about_wake_word/) (با استفاده از فریمور بدون کدنویسی [ESPHome](https://esphome.io/)) + یک تراشه XMOS xCORE XU316 برای پردازش صوت پیشرفته (با فریمور سفارشی جهت پاک‌سازی ورودی میکروفون برای بهبود قابلیت شناسایی صدا با استفاده از الگوریتم‌های محلی مانند حذف نویز، حذف اکو آکوستیک، حذف تداخل و کنترل خودکار گین) ادغام خواهد کرد.

از نظر عملکردی، این سخت‌افزار عمدتاً با [Home Assistant Voice Preview Edition (معروف به Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) طراحی مرجع (که به عنوان طرح سخت‌افزاری متن‌باز از طرف Open Home Foundation با همکاری Nabu Casa منتشر شده) سازگار خواهد بود. تفاوت اصلی به خاطر محدودیت‌هایی است که توسط بدنه و قطعات Google Nest Mini تعریف شده، (یعنی طراحی سخت‌افزاری nest-mini-drop-in-pcb محدود به همان نوع ورودی‌های ظرفیتی فیزیکی سخت‌افزار اصلی گوگل خواهد بود).

بنابراین دامنه این پروژه/مخزن توسعه ویژگی‌ها/عملکردهای جدید برای فریمور ESPHome نیست، پس اگر به دنبال آن هستید باید به توسعه فریمور Home Assistant Voice Preview Edition و همچنین کد اصلی ESPHome مراجعه کنید:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## درخواست همکاری

اگر در طراحی چیدمان PCB (و به ویژه مسیرکشی PCB، پوشرسانی زمین یا چیدمان دیجیتال+آنالوگ حساس به نویز) تجربه دارید، **کمک شما بسیار ارزشمند است**! لطفاً آزادانه یک issue جدید باز کنید، پیشنهاد/درخواست ارسال کنید و بازخورد یا نظر خود را به issueهای موجود اضافه کنید یا این مخزن را fork کنید.

برای اطلاعات بیشتر درباره ایده/مفهوم و مشارکت در بحث مرتبط، این موضوع در انجمن Home Assistant را ببینید:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### وضعیت فعلی

- ✅ شماتیک کامل شد
- ✅ جایگذاری قطعات انجام شد
- ✅ مسیرکشی انجام شد
- ✅ پوشرسانی زمین، استراتژی شیلدینگ و ملاحظات EMI انجام شد
- ⚠️ اولین سری تست به دلیل دو خطا شکست خورد - رفع شد
- 🕓 منتظر سری دوم تست هستیم

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## ابزارهای استفاده‌شده

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC برای دریافت فوت‌پرینت

## مشخصات سخت‌افزاری شناخته‌شده

- برد مدار چاپی ۴ لایه
- چیپ بدون قاب ESP32-S3R8 (ESP32-S3 برای وای‌فای، BLE و تشخیص واژه بیدارباش داخلی)
- XMOS XU316-1024-QF60B-C24 (پردازش صوتی DSP xCORE XMOS XU316)
- حافظه فلش SPI دوگانه (زیرا ESP32 و XMOS هرکدام حافظه SPI فلش خود را دارند)
- دو باس I²S (برای فراهم‌کردن همزمان رابط‌های I2S، یعنی خروجی و ورودی صوت همزمان)
- MAX98357 برای خروجی بلندگو (تقویت‌کننده صوتی مونو کلاس-D I2S)
- ۲ عدد میکروفون MEMS (دو عدد MMICT390200012 با فاصله ۶۸ میلی‌متر بین میکروفون‌ها)
- ۶ عدد LED RGB مدل SK6812
- ورودی برق سفارشی USB-C و ۱۴ ولت (توجه! USB-C و کانکتور بشکه‌ای نباید همزمان متصل شوند)

---

> ⚠️ برنامه‌ریزی از طریق USB-C نیازمند قطع اتصال ورودی برق اصلی ۱۴ ولت است. برای جزئیات، یادداشت سیلک‌اسکرین روی PCB را ببینید.

## منابع

### منابع نسخه پیش‌نمایش Home Assistant Voice شامل فایل‌های طراحی PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### فریم‌ور ESPHome برای Home Assistant Voice PE (که از ترکیب ESP32-S3 + XMOS XU316 نیز استفاده می‌کند):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### چیپ آی‌سی MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### سفت‌افزار XMOS از پروژه ESPHome برای سخت‌افزار نسخه پیش‌نمایش Home Assistant Voice:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## مجوز

این پروژه تحت [مجوز سخت‌افزار باز CERN نسخه ۲ - به شدت بازگشتی (CERN-OHL-S v2)] دارای مجوز است.
هر نسخه تغییریافته‌ای از این سخت‌افزار نیز باید تحت همین مجوز توزیع شود.

☕ اگر مایل به حمایت از این پروژه هستید، خوشحال می‌شوم اگر [برایم یک قهوه در Ko-fi بخرید](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---