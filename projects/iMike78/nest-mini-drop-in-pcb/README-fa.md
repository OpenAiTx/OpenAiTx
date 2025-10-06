<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# جایگزین PCB قطره‌ای MiciMike برای Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) یک جایگزین PCB قطره‌ای برای ["Google Nest Mini" (نسل دوم اسپیکر هوشمند گوگل با پورت شارژ بشکه‌ای)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) است، اما مبتنی بر میکروکنترلرهای ESP32 و XMOS جهت اجرای فریم‌ور متن‌باز می‌باشد.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

نکته! اگر به دنبال جایگزین مشابه PCB قطره‌ای برای "Google Home Mini" (نسل اول سخت‌افزار اسپیکر هوشمند گوگل با پورت شارژ Micro-USB) هستید، پروژه خواهر را در https://github.com/iMike78/home-mini-v1-drop-in-pcb ببینید.


هر دوی این پروژه‌ها کاملاً متن‌باز هستند و با الهام از مفاهیم پروژه [Onju Voice](https://github.com/justLV/onju-voice)، اما با هدف پیروی از [استاندارد دستیارهای صوتی متن‌باز بنیاد Open Home با نسخه پیش‌نمایش Home Assistant Voice به عنوان مرجع](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) برای طراحی و مشخصات PCB ساخته شده‌اند.

# دامنه پروژه

هدف این پروژه و مخزن (که مشابه [Onju Voice](https://github.com/justLV/onju-voice) اما تحت مجوز سخت‌افزار کاملاً متن‌باز است) طراحی یک PCB (برد مدار چاپی) جایگزین با شماتیک سخت‌افزاری است که هر کسی بتواند بسازد یا از یک تولیدکننده PCB سفارش دهد، به عنوان یک برد جایگزین سفارشی برای Google Nest Mini (نسل دوم).

این پروژه عمدتاً برای کسانی هدف‌گذاری شده است که می‌خواهند اسپیکرهای هوشمند Google Nest Mini قدیمی خود را به سخت‌افزار متن‌باز برای [کنترل صوتی Home Assistant](https://www.home-assistant.io/voice_control/) و/یا پخش خروجی اسپیکر برای [Music Assistant](https://www.music-assistant.io) تبدیل یا استفاده مجدد کنند (البته احتمالاً این سخت‌افزار با برنامه‌های دیگر و فریم‌ویرهای دیگر نیز قابل استفاده است زیرا بر پایه پلتفرم محبوب Espressif ESP32 ساخته شده است).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

طراحی سخت‌افزاری (مشابه با [نسخه پیش‌نمایش Home Assistant Voice](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) یک چیپ ESP32-S3 SoC برای WiFi، BLE و [تشخیص واژه بیدارباش داخلی](https://www.home-assistant.io/voice_control/about_wake_word/) (با استفاده از فریم‌ویر بدون کد [ESPHome](https://esphome.io/)) + یک چیپ XMOS xCORE XU316 برای پردازش صوتی پیشرفته (با فریم‌ویر سفارشی برای پاک‌سازی میکروفون و افزایش قابلیت شناسایی صدا از طریق اجرای محلی الگوریتم‌هایی برای حذف نویز، حذف پژواک صوتی، حذف تداخل و کنترل خودکار حجم صدا) را ادغام خواهد کرد.

از نظر عملکرد، سخت‌افزار تقریباً با [نسخه پیش‌نمایش Home Assistant Voice (معروف به Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) طراحی مرجع (که به عنوان سخت‌افزار متن‌باز توسط بنیاد Open Home و همکاری Nabu Casa منتشر شده) سازگار خواهد بود. تفاوت اصلی به محدودیت‌های تعریف شده توسط محفظه و قطعات Google Nest Mini مربوط می‌شود، (یعنی طراحی سخت‌افزاری پروژه nest-mini-drop-in-pcb توسط همان نوع ورودی‌های ظرفیت فیزیکی مانند سخت‌افزار اصلی Google محدود خواهد شد).

بنابراین دامنه این پروژه/مخزن توسعه ویژگی‌ها/عملکردهای جدید برای فریم‌ویر ESPHome نیست، پس اگر چنین چیزی می‌خواهید باید به توسعه فریم‌ویر نسخه پیش‌نمایش Home Assistant Voice و همچنین کد اصلی ESPHome مراجعه کنید:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## درخواست همکاری

اگر تجربه‌ای در طراحی برد مدار چاپی دارید (به‌ویژه در مسیریابی برد، ریختن گراند یا طراحی‌های دیجیتال و آنالوگ حساس به نویز)، **کمک شما بسیار ارزشمند است**! لطفاً آزادانه یک issue جدید باز کنید، پیشنهادات/درخواست‌های خود را ارائه دهید و به issueهای موجود ورودی/بازخورد دهید یا این مخزن را fork کنید.

برای اطلاعات بیشتر درباره مفهوم/ایده و مشارکت در بحث مرتبط به این موضوع به تاپیک انجمن Home Assistant مراجعه کنید:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### وضعیت فعلی

- ✅ شماتیک تکمیل شد
- ✅ چیدمان قطعات انجام شد
- ✅ مسیریابی انجام شد
- ✅ ریختن گراند، استراتژی شیلدینگ و ملاحظات EMI انجام شد
- ⚠️ اولین سری تست با دو خطا شکست خورد - رفع شد
- 🕓 منتظر سری دوم تست

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## ابزارهای استفاده‌شده

- 🛠️ کی‌کد ۹
- 🧰 SnapEDA / LCSC برای تأمین فوت‌پرینت

## مشخصات سخت‌افزاری شناخته شده

- برد PCB چهار لایه
- چیپ خالی ESP32-S3R8 (ESP32-S3 برای وای‌فای، BLE و تشخیص واژه بیدارباش داخلی)
- XMOS XU316-1024-QF60B-C32 (پردازش صوتی DSP xCORE XMOS XU316)
- فلش SPI دوگانه
- دو باس I²S (برای فعال بودن همزمان رابط‌های I2S، یعنی خروجی و ورودی صوتی همزمان)
- MAX98357 برای خروجی بلندگو (تقویت‌کننده صوتی مونو کلاس-D I2S)
- ۲ میکروفون MEMS (MSM261DHP)
- LED های SK6812
- ورودی برق USB-C سفارشی و ۱۴ ولت

---

> ⚠️ پروگرام کردن از طریق USB-C نیازمند قطع ورودی برق اصلی ۱۴ ولت است. برای جزئیات به یادداشت سیلک‌اسکرین روی برد PCB مراجعه کنید.

## منابع

### منابع نسخه پیش‌نمایش Voice Home Assistant شامل فایل‌های طراحی PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### فریمور ESPHome برای Home Assistant Voice PE (که از ترکیب ESP32-S3 + XMOS XU316 مشابه استفاده می‌کند):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### چیپ آی‌سی XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### میان‌افزار XMOS از پروژه ESPHome برای سخت‌افزار Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## مجوز

این پروژه تحت [مجوز سخت‌افزار باز سرن نسخه ۲ - به شدت متقابل (CERN-OHL-S v2)] مجوز داده شده است.
هر نسخه تغییریافته‌ای از این سخت‌افزار نیز باید تحت همین مجوز توزیع شود.

☕ اگر مایل به حمایت از این پروژه هستید، می‌توانید [برای من یک قهوه در Ko-fi بخرید](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---