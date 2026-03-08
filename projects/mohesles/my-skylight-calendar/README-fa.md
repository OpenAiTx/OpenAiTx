<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# تقویم خانوادگی هوشمند DIY (شبیه‌ساز Skylight)

![تقویم Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![Skylight DIY](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 مقدمه

همسرم اخیراً در شبکه‌های اجتماعی با تبلیغات تقویم‌های هوشمند خانگی (Skylight، Cozyla، Hearth) بمباران شده بود و آماده بود بیش از ۳۰۰ دلار برای یکی از آن‌ها هزینه کند. قبل از اینکه اجازه خرید بدهم، از او خواستم فرصتی به من بدهد تا درباره‌شان تحقیق کنم.

متوجه شدم که اکثر گزینه‌ها عملکرد مشابهی ارائه می‌دهند اما تفاوت قابل‌توجهی در قیمت دارند. مهم‌تر از همه، هیچ ویژگی برجسته‌ای ندیدم که نتوانم آن را در **Home Assistant** پیاده‌سازی کنم.

**هدف:** یک تقویم لمسی رومیزی مورد تأیید WAF (عامل پذیرش همسر) که به طور عمیق با خانه هوشمند ما ادغام شود و هیچ هزینه ماهیانه‌ای نداشته باشد.

## 💡 چرا DIY؟

انتخاب مسیر DIY با Home Assistant مزایای متعددی نسبت به خرید نمایشگر Skylight/Hearth داشت:

* **بدون هزینه ماهیانه:** از پرداخت حق اشتراک بابت قابلیت‌های "پریمیوم" جلوگیری می‌کند.
* **ادغام بی‌وقفه:** با چراغ‌ها، وظایف (Grocy) و حسگرهای حضور ارتباط برقرار می‌کند.
* **سخت‌افزار قدیمی:** یک مینی‌پی‌سی و یک مانیتور استاندارد را دوباره استفاده کردم.
* **حریم خصوصی:** بدون وابستگی به فروشنده یا ریسک تعطیلی شرکت.

## 🛠 انتخاب سخت‌افزار

در حال حاضر این پروژه برای نمایش داشبورد روی هر نمایشگر HD (1920x1080) ساخته شده است.

در مورد من، نیاز این بود که "شبیه" Skylight باشد، لمسی باشد، رومیزی باشد و امکان جابجایی به مکان‌های مختلف را داشته باشد. بنابراین با سخت‌افزار زیر پیش رفتم.
با این حال، شرایط شما ممکن است متفاوت باشد و لازم است آن را بر اساس نیاز خود تنظیم کنید، مثلاً اگر بخواهید آن را روی یک تبلت یا دستگاه دیگر نمایش دهید.

سخت‌افزاری که در ابتدا انتخاب کردم بر اساس موارد بالا بود و همچنین با امید به گسترش قابلیت‌ها با استفاده از وب‌کم، اسپیکر و میکروفون. اکنون، با نگاه به گذشته، احتمالاً آن را متفاوت می‌ساختم، چون هنوز وقت نکرده‌ام به این ایده‌های سخت‌افزاری اضافه رسیدگی کنم.

* **مانیتور:** [مانیتور لمسی ۱۵ اینچی HP Engage](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). آن را به جای مانیتورهای پرتابل معمولی انتخاب کردم چون دارای **اسپیکر، وب‌کم و میکروفون** داخلی است و امکان کنترل صوتی یا تماس تصویری در آینده را فراهم می‌کند.
* **کامپیوتر:** یک مینی‌پی‌سی قدیمی (NUC/Tiny PC) با ویندوز/لینوکس در حالت Kiosk، یا Raspberry Pi 4.~~

## ✨ قابلیت‌ها

* **نمای خانوادگی و فردی:** امکان روشن/خاموش کردن تقویم اعضای خانواده به طور جداگانه.
* **همگام‌سازی دوطرفه:** ویرایش رویدادها از روی صفحه یا تلفن‌های ما (Google Calendar).
* **پنجره "افزودن رویداد":** رابط کاربری سفارشی برای افزودن مستقیم رویداد به تقویم‌های خاص از روی صفحه.
* **آب‌وهوا و تاریخ:** هدر زیبا و قابل مشاهده در یک نگاه.
* **واکنش‌گرا:** به طور خودکار تعداد روزهای نمایش را بر اساس عرض صفحه تنظیم می‌کند (موبایل و دسکتاپ).

---

## ⚙️ راهنمای نصب

*توجه: این راه‌اندازی از یک **YAML Package** استفاده می‌کند تا تمام دستیارها، اسکریپت‌ها و متغیرهای مورد نیاز را به طور خودکار برای شما ایجاد کند. نیازی به ساخت دستی آن‌ها ندارید.*



### ۱. پیش‌نیازها (HACS)

شما باید [HACS](https://hacs.xyz/) را نصب کرده باشید. لطفاً یکپارچه‌سازی‌های **Frontend** زیر را نصب کنید:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (برای کارکرد پاپ‌آپ‌ها ضروری است)
* `layout-card` (برای مشاهده‌ی بخش‌ها ضروری است)
* `button-card` (برای پاپ‌آپ افزودن رویداد ضروری است)

*توجه: در تنظیمات → دستگاه‌ها و سرویس‌ها مطمئن شوید Browser Mod به عنوان یک یکپارچه‌سازی (کاشی) ظاهر شده است و فقط زیر HACS نیست. 
اگر آنجا نیست، روی افزودن یکپارچه‌سازی → Browser Mod کلیک کرده و فرآیند را کامل کنید، سپس HA را ریستارت کنید.
نصب از طریق HACS تنها فایل‌ها را دانلود می‌کند؛ باید یکپارچه‌سازی را اضافه کنید تا HA عملکردها/موجودیت‌های آن را ثبت کند.

### ۲. Backend (مغز سیستم)

۱. فایل `configuration.yaml` خود را در Home Assistant باز کنید.
۲. مطمئن شوید این خط را زیر `homeassistant:` برای فعال‌سازی بسته‌ها افزوده‌اید:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. یک پوشه به نام `packages` در دایرکتوری تنظیمات HA خود ایجاد کنید (اگر ندارید).
4. فایل [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) را از این مخزن دانلود کنید.
5. عبارت [ #<--- UPDATE THIS ENTITY] را جستجو کرده و شناسه موجودیت تقویم را مطابق با محیط خود به‌روزرسانی کنید. برای جزئیات بیشتر بخش 3 را بررسی نمایید.
6. فایل را داخل پوشه `packages/` قرار دهید.
7. **Home Assistant را مجدداً راه‌اندازی کنید**.

### 3. تقویم‌ها

می‌توانید از **تقویم‌های گوگل** یا **تقویم‌های محلی** استفاده کنید.

#### گزینه A: استفاده مجدد از نام‌های تقویم (آسان‌ترین)


1. به **تنظیمات > دستگاه‌ها و سرویس‌ها** بروید.
2. یکپارچه‌سازی **تقویم محلی** را اضافه کنید.
3. تقویم‌هایی با نام‌های دقیقاً: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family` ایجاد کنید.
    * *اگر از این نام‌ها استفاده کنید، کد به صورت آماده کار می‌کند!*

#### گزینه B: تقویم سفارشی

1. به **تنظیمات > دستگاه‌ها و سرویس‌ها** بروید.
2. یکپارچه‌سازی **تقویم محلی** یا **تقویم گوگل** را اضافه کنید.
3. به **پیکربندی > یکپارچه‌سازی‌ها > تقویم محلی** یا **تقویم گوگل** بروید و گزینه "افزودن ورودی" را انتخاب کنید.
4. برای هر ورودی ایجاد شده، شناسه موجودیت را برای به‌روزرسانی فایل dashboard.yaml دریافت کنید.
5. فایل `dashboard.yaml` را باز کنید.
6. عبارت `# <--- UPDATE THIS ENTITY` را جستجو کنید.
7. شناسه موجودیت را مطابق با محیط خود به‌روزرسانی کنید.


#### راه‌اندازی تعطیلات

با توجه به بروزرسانی‌های Home Assistant، تعطیلات اکنون از طریق رابط کاربری اضافه می‌شوند:

1. به **تنظیمات > دستگاه‌ها و سرویس‌ها > افزودن یکپارچه‌سازی > تعطیلات** بروید.
2. کشور خود را انتخاب کنید.
3. شناسه موجودیت را بررسی کنید (مثلاً `calendar.holidays`). اگر با مقدار پیش‌فرض تفاوت دارد، آن را در فایل dashboard YAML به‌روزرسانی کنید.

### 4. داشبورد (ظاهر)


1. به **تنظیمات > داشبورد** بروید
2. روی **افزودن داشبورد** کلیک کنید (گزینه "داشبورد جدید از ابتدا" را انتخاب کنید و مطمئن شوید که "افزودن به نوار کناری" را انتخاب کرده‌اید).
3. از منوی سمت چپ، داشبورد تازه ایجاد شده را انتخاب کرده و روی آیکون مداد برای ویرایش آن کلیک کنید.
5. روی آیکون سه نقطه کلیک کرده و "ویرایشگر پیکربندی خام" را انتخاب کنید.
6. کد را از [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) کپی و جایگذاری کنید.

### مرحله ۵: قالب (اختیاری)

برای دریافت ظاهر فونت خاص (Ovo):

1. اطمینان حاصل کنید که `configuration.yaml` شما این خط را زیر `frontend:` دارد

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
۲. یک پوشه به نام `themes` در دایرکتوری پیکربندی خود ایجاد کنید.
۳. فایل [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) را دانلود کرده و در آن پوشه قرار دهید.
۴. با استفاده از File Editor فایل calbackgrd.png را در پوشه /www/ آپلود کنید که این پوشه به صورت داخلی در داشبورد به /local ترجمه می‌شود.
۵. Home Assistant را ریستارت کنید.
۶. به پروفایل خود بروید (آیکون کاربر پایین سمت چپ) و **Theme** را به `Skylight` تغییر دهید.
توجه: این تم کامل و جامع نیست، بنابراین این نکته را مد نظر داشته باشید.

---

## 📐 نحوه عملکرد (در پشت صحنه)

### منطق فیلتر

کارت `week-planner-card` به طور ذاتی امکان پنهان کردن تقویم‌های خاص به صورت آنی را پشتیبانی نمی‌کند. برای حل این مشکل، من از **Input Texts** به عنوان فیلترهای Regex استفاده کردم.

* وقتی روی دکمه یک شخص کلیک می‌کنید، فیلتر او بین مقدار `.*` (نمایش همه چیز) و `^$` (عدم نمایش هیچ چیز) جابه‌جا می‌شود.
* کارت `config-template-card` این متغیرها را به صورت پویا در کارت تقویم قرار می‌دهد.

### اسکریپت ایجاد رویداد

پاپ‌آپ "افزودن رویداد" از یک اسکریپت واحد استفاده می‌کند که منطق مربوط به چندین نفر و انواع رویداد (تمام روز در مقابل زمان‌بندی شده) را مدیریت می‌کند.


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```
## یادداشت‌ها

پست اولیه من صرفاً برای ارائه یک نمای کلی از نحوه انجام این کار بود تا افراد بتوانند کد را مطابق نیاز خود تنظیم کنند.

به طور خاص من این کار را انجام دادم چون هر نمایشگر و نیازی متفاوت است. من نمی‌توانم برای همه اندازه‌های ممکن نمایشگرها، داشبوردها و غیره توسعه دهم. بنابراین این کد طوری ساخته شده که در نمایشگری که ذکر کردم یا هر نمایشگر دیگری (۱۹۲۰x۱۰۸۰) کار کند ولی باید برای سایر موارد قابل ویرایش باشد.

در مورد نمایشگر، من در ابتدا آن را پیشنهاد دادم چون آن زمان در سایت Woot با تخفیف فروخته می‌شد و یک روش اقتصادی برای تهیه نمایشگر لمسی بود. شاید اکنون اینطور نباشد، پس هر نمایشگری که برای شما مناسب است استفاده کنید. تبلت، صفحه لمسی، تلفن، هر چیزی. مورد اصلی که باید ویرایش کنید داشبورد است.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---