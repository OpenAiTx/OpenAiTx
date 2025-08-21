
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# رزتا استانکس

- [معرفی](#introduction)
- [نصب](#install)
  - [کروم](#chrome-based-browsers)
    - [راهنمای تصویری](#chrome-based-browsers)
  - [فایرفاکس](#firefox-based-browsers)
- [نحوه استفاده](#how-to-use)
  - [افزودن زمان](#adding-time)
    - [پایه‌ها](#adding-time-in-foundations)
    - [سازنده روانی](#adding-time-in-fluency-builder)
  - [تایید درس](#validating-lesson)
    - [پایه‌ها](#validating-lesson-in-foundations)
    - [سازنده روانی](#validating-lesson-in-fluency-builder)

## مقدمه

RosettaStonks یک افزونه مرورگر است که به شما اجازه می‌دهد زمان اضافه کنید و
درس‌ها را در پلتفرم یادگیری زبان Rosetta Stone اعتبارسنجی کنید.

> RosettaStonks، و Rosetta Stone شما به stonks تبدیل می‌شود.

## نصب

### مرورگرهای مبتنی بر کروم

➡️ **جدید در نصب دستی افزونه‌های کروم هستید؟** [راهنمای تصویری گام به گام](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) را ببینید — شامل تصاویر راهنما! 🖼️

#### 1. استفاده از انتشار GitHub

برای استفاده از این افزونه در یک مرورگر مبتنی بر کروم، لازم است:

- فایل `rosettastonks-chrome.tar.gz` را از آخرین انتشار
  روی دستگاه خود دانلود کنید.
- یک پوشه به نام `rosettastonks` در جایی روی دستگاه خود برای ذخیره
  افزونه ایجاد کنید.
- فرمان زیر را در پوشه `rosettastonks` اجرا کنید.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

۲. استفاده از مدیر بسته nix

به جای دستورات قبلی، اگر روی سیستمی با nix هستید که **از flakes پشتیبانی می‌کند**،
می‌توانید دستورات زیر را اجرا کنید که یک پوشه در مسیر `/tmp/rosettastonks`
با تمام فایل‌ها نصب خواهد کرد.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```
پوشه اکنون در مسیر `/tmp/rosettastonks/` نصب شده است.

**این بخش برای همه کاربران است، صرف‌نظر از اینکه از روش github یا روش nix استفاده می‌کنید.**

در مرورگر خود:

- به آدرس `chrome://extensions` بروید
- گزینه `Developer mode` را فعال کنید
- روی `Load unpacked` کلیک کنید
- پوشه `rosettastonks` خود را انتخاب کنید

### مرورگرهای مبتنی بر Firefox

- فایل `rosettastonks.xpi` را از آخرین نسخه منتشر شده دانلود کنید.
- همچنین، اگر از مدیر بسته nix با پشتیبانی flake استفاده می‌کنید، می‌توانید
  فرمان زیر را اجرا کنید.



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- به `about:addons` در مرورگر خود بروید
- دکمه تنظیمات را کلیک کنید و به `Debug addons` بروید.
- روی `Load Temporary Add-On` کلیک کنید
- فایل `/tmp/rosettastonks.xpi` را در انتخاب‌گر فایل انتخاب کنید.

_هشدار: این روش افزونه را فقط به طور موقت نصب می‌کند، به این معنی که اگر
مرورگر خود را ببندید، افزونه حذف خواهد شد. این به خاطر سیاست‌های فایرفاکس
است که اجازه استفاده از افزونه‌های تایید نشده را نمی‌دهد._

## نحوه استفاده

### افزودن زمان

#### افزودن زمان در Foundations

برای افزودن زمان به محصول `foundations`، باید به تمرین‌های خود بروید و
حداقل یک سوال را نادیده بگیرید یا حل کنید. پس از انجام این کار، یک فیلد زمان
در صفحه افزونه ظاهر می‌شود که می‌توانید زمان خود را وارد کنید.

#### افزودن زمان در Fluency builder

برای افزودن زمان به محصول `fluency builder`، باید به تمرین‌های خود بروید و
حداقل یک تمرین را پاسخ دهید. اگر فیلد افزودن زمان ظاهر نشد، به این معنی است
که هیچ درخواست زمان شناسایی نشده است، باید سوال را رفرش کنید و دوباره پاسخ دهید.
برای اینکه زمان اضافه شود، باید درسی که برای افزودن زمان استفاده کردید را کامل کنید.

_توجه: اگر فیلد افزودن زمان را نمی‌بینید، یعنی اقداماتی که در سایت Rosetta Stone
انجام دادید منجر به افزودن زمان معتبر نشده و بنابراین باید به سوالات دیگری پاسخ دهید._

### اعتبارسنجی درس

#### اعتبارسنجی درس در Foundations

برای اعتبارسنجی یک درس، باید یک درس را شروع کنید و همه سوالات را با دکمه
`ignore` در پایین سمت راست طی کنید. پس از مشاهده همه سوالات، با کلیک روی دکمه
`validate lesson` باید درس اعتبارسنجی شود. اگر نشد، به صفحه اصلی خود بازگردید،
روی همان درس کلیک کنید، آن



باید از شما بپرسد `آیا می‌خواهید ادامه دهید یا بازنشانی کنید؟`، شما می‌توانید هر دو را انتخاب کنید،
و درس را دوباره اعتبارسنجی کنید تا زمانی که کار کند. باید حداکثر بعد از ۳/۴ بار کار کند.

#### اعتبارسنجی درس در Fluency builder

در حال حاضر، ویژگی اعتبارسنجی درس در rosetta stonks موجود نیست.

## ساخت برنامه

### ساخت worker

worker را می‌توان با استفاده از فرمان زیر بسته‌بندی کرد

```
$ deno task build:worker
```
که فایل بسته‌بندی شده `/dist/worker.esm.js` را ایجاد می‌کند که فایل
بسته‌بندی شده برای worker است.

### ساخت رابط کاربری

worker را می‌توان با استفاده از دستور زیر بسته‌بندی کرد


```
$ deno task build:frontend
```
که فایل بسته‌بندی شده `/dist/frontend.esm.js` را ایجاد می‌کند که فایل بسته‌بندی شده برای فرانت‌اند است.

## بسته‌بندی افزونه

### کروم

برای بسته‌بندی افزونه برای کروم، می‌توان دستور زیر را اجرا کرد:



```
$ make chrome
```

### فایرفاکس

برای بسته‌بندی افزونه برای فایرفاکس، دستور زیر را می‌توان اجرا کرد:

```
$ make firefox
```

که خروجی آن `rosettastonks.xpi` خواهد بود، فایلی برای افزونه که می‌توان آن را در فایرفاکس بارگذاری کرد.

📸 تصاویر را ترجیح می‌دهید؟ راهنمای نصب کروم همراه با تصاویر را در [Chrome Installation Guide with Images](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) مشاهده کنید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---