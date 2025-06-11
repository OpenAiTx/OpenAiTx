<h1 align="center">ModernZ - یک OSC شیک و جایگزین برای mpv</h1>

یک OSC شیک و مدرن برای [mpv](https://mpv.io/)، این پروژه یک فورک از ModernX است که برای افزایش قابلیت‌ها با افزودن ویژگی‌های بیشتر طراحی شده است، در حالی که استانداردهای اصلی OSC در mpv حفظ می‌شود.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>نصب »</strong></a>
  <br>
  <a href="#configuration">پیکربندی</a>
  ·
  <a href="#controls">کنترل‌ها</a>
  ·
  <a href="#interactive-menus">منوهای تعاملی</a>
  ·
  <a href="#translations">زبان OSC</a>
  ·
  <a href="#extras">اسکریپت‌های اضافی</a>
</p>

## ویژگی‌ها

- 🎨 رابط کاربری مدرن و قابل تنظیم [[گزینه‌ها](#configuration)]
- 📷 حالت نمایش تصویر با کنترل‌های بزرگنمایی [[جزئیات](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ دکمه‌ها: دانلود، لیست پخش، کنترل سرعت، اسکرین‌شات، پین، لوپ، کش و بیشتر. [[جزئیات](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 منوهای تعاملی برای لیست پخش، زیرنویس‌ها، فصل‌ها، ترک‌های صوتی و دستگاه‌های صوتی [[جزئیات](#interactive-menus)]
- 🌐 پشتیبانی چند زبانه با ادغام JSON [locale](#translations)
- ⌨️ کنترل‌های قابل تنظیم [[جزئیات](#controls)]
- 🖼️ پیش‌نمایش تصاویر بندانگشتی ویدیو با [thumbfast](https://github.com/po5/thumbfast)

## سفارشی‌سازی

شما می‌توانید تم آیکون را به `fluent` یا `material` تغییر دهید تا با سلیقه و سبک خود هماهنگ شود، با استفاده از گزینه `icon_theme` در فایل `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

از دکمه‌ها و متن سفید خوشتان نمی‌آید؟ کنترل کامل برای سفارشی کردن رنگ‌ها و چیدمان دکمه‌ها دارید تا به‌طور کامل سبک شما را منعکس کند.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

برای جزئیات درباره سفارشی‌سازی رنگ‌ها و دکمه‌ها، بخش [رنگ‌بندی و سبک](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) در راهنمای پیکربندی را ببینید.

## منوهای تعاملی

ModernZ از کنسول/انتخاب داخلی mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) برای لیست پخش، زیرنویس‌ها، ناوبری فصل‌ها و بیشتر پشتیبانی می‌کند.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## نصب

1. **غیرفعال کردن OSC پیش‌فرض**

   - در فایل `mpv.conf` خود `osc=no` را اضافه کنید

2. **کپی فایل‌ها**

   - فایل `modernz.lua` را در پوشه اسکریپت‌های mpv قرار دهید
   - فایل‌های `fluent-system-icons.ttf` و `material-design-icons.ttf` را در پوشه فونت‌های mpv قرار دهید
   - (اختیاری) فایل `thumbfast.lua` را در پوشه اسکریپت‌های mpv قرار دهید

3. **مکان‌ها**

   ```
   لینوکس:   ~/.config/mpv/
   ویندوز: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **ساختار پوشه** [[راهنمای mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (اختیاری)
   ```

## پیکربندی

1. برای سفارشی‌سازی تنظیمات، فایل `modernz.conf` را در پوشه `/script-opts` ایجاد کنید

   - [دانلود فایل پیش‌فرض modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. نمونه‌ای از یک پیکربندی کوتاه:

   ```EditorConfig
   # رنگ نوار جستجو (فرمت هگز)
   seekbarfg_color=#B7410E

   # گزینه‌های رابط کاربری
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

برای فهرست کامل گزینه‌ها، [لیست کامل را اینجا ببینید](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## کنترل‌ها

### تعامل با دکمه‌ها

- کلیک چپ: عملکرد اصلی
- کلیک راست: عملکرد ثانویه
- کلیک وسط/Shift+کلیک چپ: عملکرد جایگزین

> [!توجه]
> کلیک وسط همان عملکرد `Shift+کلیک چپ` را انجام می‌دهد، که امکان استفاده با یک دست را فراهم می‌کند

برای فهرست کامل تعاملات، راهنمای [تعامل با دکمه‌ها](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md) را ببینید.

### کلیدهای میانبر

ModernZ به صورت پیش‌فرض کلید میانبری تنظیم نمی‌کند تا با تنظیمات فعلی شما تداخل نداشته باشد. اگر مایل باشید می‌توانید کلیدهای میانبر را در `input.conf` اضافه کنید:

```
w   script-binding modernz/progress-toggle           # تغییر وضعیت نوار پیشرفت
x   script-message-to modernz osc-show               # نمایش OSC
y   script-message-to modernz osc-visibility cycle   # چرخه حالت‌های نمایش
z   script-message-to modernz osc-idlescreen         # تغییر صفحه بیکار
```

## ترجمه‌ها

ModernZ در حال حاضر به زبان انگلیسی موجود است، اما شما می‌توانید به سادگی آن را به زبان مورد علاقه خود تغییر دهید! روش کار:

1. **دانلود بسته locale:**

فایل [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) را از این مخزن دریافت کنید. این فایل ترجمه‌های زبان‌های مختلف را در خود دارد.

2. **افزودن locale به mpv:**

فایل `modernz-locale.json` دانلود شده را در پوشه `/script-opts` mpv خود کپی کنید.

3. **انتخاب زبان:**

دو روش برای تنظیم زبان مورد نظر وجود دارد:

- **توصیه شده:** استفاده از فایل `modernz.conf`

  ```ini
  # نمونه پیکربندی در modernz.conf
  # تنظیم زبان به چینی ساده
  language=zh
  ```

- **روش جایگزین:** ویرایش اسکریپت `modernz.lua`

  فایل `modernz.lua` را باز کرده و بخش `user_opts` را در نزدیکی ابتدای فایل پیدا کنید. مقدار `language` را به کد زبان مورد نظر تغییر دهید:

  ```lua
  local user_opts = {
      -- عمومی
      language = "en",  -- این را به کد زبان دلخواه تغییر دهید
      ...
  }
  ```

**نیاز به اطلاعات بیشتر دارید؟**

برای فهرست کامل زبان‌های موجود، راهنمای مشارکت و مستندات ترجمه، به [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md) مراجعه کنید.

## اسکریپت‌های اضافی

اسکریپت‌های زیر توسط من نوشته و نگهداری می‌شوند، در صورت مفید بودن می‌توانید از آن‌ها استفاده کنید.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - یک اسکریپت ساده که هنگام توقف نمایشگر نشان می‌دهد

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - یک اسکریپت ساده mpv برای تغییر خودکار `ytdl-format` (yt-dlp) برای دامنه‌های مشخص شده.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - یک اسکریپت ساده mpv برای تغییر نسبت تصویر 4:3 فایل‌ها/استریم‌های ویدیویی به 16:9 به‌صورت خودکار.

برای اسکریپت‌های مفید بیشتر، به [ویکی اسکریپت‌های کاربری mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts) مراجعه کنید. این ویکی مجموعه گسترده‌ای از اسکریپت‌های مشارکتی جامعه برای بهبود تجربه mpv ارائه می‌دهد.

## تاریخچه

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - فورک شده از [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - فورک شده از [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - فورک شده از [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**چرا دوباره فورک شده؟**

- افزودن ویژگی‌های فراوان در: [سفارشی‌سازی رنگ](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)، [گزینه‌ها](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) و [ادغام locale](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- ادغام کنسول و انتخاب در osc، که الهام‌بخش mpv برای اعمال آن در osc پیش‌فرض شد. [ارجاع [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- افزودن چیدمان اختصاصی برای تصاویر. [[جزئیات](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- بازطراحی کامل پروژه برای هماهنگی با استانداردهای osc پیش‌فرض mpv، جهت اطمینان از سازگاری
- رفع باگ‌های قدیمی و حذف کدهای زائد
    - که به فورک‌های دیگر `Modern` اجازه می‌دهد از ModernZ به عنوان پایه استفاده کنند، مانند [zydezu/ModernX](https://github.com/zydezu/ModernX). [[ارجاع](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

در اصل، حفظ و احیای منشأ `modern-osc`.
با این حال، ModernZ هنوز از بخش‌هایی از کد قدیمی استفاده می‌کند، و هر نویسنده و مشارکت‌کننده قبلی و فعلی فورک‌ها شایسته تقدیر هستند (از جمله osc پیش‌فرض mpv)، به همین دلیل آن‌ها به طور مفصل ذکر شده‌اند.

#### تقدیر و تشکر:

- قلم: UI Fluent System Icons [[جزئیات](https://github.com/microsoft/fluentui-system-icons)] [[فایل قلم](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- قلم ویرایش شده توسط [Xurdejl](https://github.com/Xurdejl) برای استفاده در ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) و [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua) آن‌ها، زیرا ModernZ osc بر اساس استانداردهای osc پیش‌فرض بازسازی شده و به‌روزرسانی‌هایی از آن را اعمال می‌کند
- تمامی منشاهای مدرن osc و فورک‌های آن‌ها همانطور که در [تاریخچه](#history) ذکر شده است
- تمامی [مشارکت‌کنندگان](https://github.com/Samillion/ModernZ/graphs/contributors)، تست‌کنندگان و کاربرانی که به طور مستقیم یا غیرمستقیم در توسعه ModernZ osc کمک کرده‌اند ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---