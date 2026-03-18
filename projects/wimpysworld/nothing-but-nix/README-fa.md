
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# فقط نیکس

**رانر GitHub Actions خود را با تبدیل به یک [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ قدرتمند کنید و نرم‌افزارهای از پیش نصب شده و اضافی را بی‌رحمانه حذف کنید.**

رانرهای GitHub Actions فضای دیسک بسیار کمی برای Nix دارند - فقط حدود ~۲۰ گیگابایت.
*فقط نیکس* **نرم‌افزارهای غیرضروری را به طور بی‌رحمانه حذف می‌کند** و به شما **۶۵ تا ۱۳۰ گیگابایت** برای فروشگاه Nix می‌دهد! 💪

## نحوه استفاده 🔧

این اقدام را **قبل از** نصب Nix در گردش‌کار خود اضافه کنید:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### نیازمندی‌ها ️✔️

- فقط از رانرهای رسمی **اوبونتو** در GitHub Actions پشتیبانی می‌کند
- باید **قبل از** نصب Nix اجرا شود
- **رانرهای macOS/Darwin**: این اکشن در صورت اجرا روی macOS با هشدار به طور مناسب رد می‌شود. رانرهای macOS فضای کافی برای Nix دارند و به این اکشن نیاز ندارند
- **رانرهای ویندوز**: این اکشن در صورت اجرا روی ویندوز با هشدار به طور مناسب رد می‌شود. رانرهای ویندوز ساختار فایل سیستم و محدودیت‌های متفاوتی دارند

## مشکل: ایجاد فضای کافی برای رشد Nix 🌱

رانرهای استاندارد GitHub Actions پر از *"نرم‌افزارهای اضافی"* هستند که در جریان کاری Nix هرگز از آن‌ها استفاده نخواهید کرد:

- 🌍 مرورگرهای وب. تعداد زیادی. باید همه را داشته باشید!
- 🐳 ایمیج‌های Docker که گیگابایت‌ها فضای ارزشمند دیسک را مصرف می‌کنند
- 💻 محیط‌های اجرایی زبان غیرضروری (.NET، Ruby، PHP، Java...)
- 📦 مدیران بسته‌ای که گرد و غبار دیجیتال جمع می‌کنند
- 📚 مستنداتی که هیچ‌کس هرگز آن را نخواهد خواند

این اضافات فقط حدود ~۲۰ گیگابایت برای فروشگاه Nix باقی می‌گذارند – که برای ساخت‌های جدی Nix کافی نیست! 😞

## راه‌حل: فقط Nix ️❄️

**فقط Nix** رویکردی سوزاننده برای رانرهای GitHub Actions اتخاذ می‌کند و بی‌رحمانه فضای دیسک را با حمله‌ای دو مرحله‌ای پس می‌گیرد:

1. **ضربه اولیه:** فوراً یک حجم بزرگ `/nix` (~۶۵ گیگابایت) ایجاد می‌کند با استفاده از فضای آزاد `/mnt`
2. **حمله پس‌زمینه:** در حالی که جریان کاری شما ادامه دارد، ما به طور بی‌رحمانه نرم‌افزارهای غیرضروری را حذف می‌کنیم تا حجم `/nix` را تا ~۱۳۰ گیگابایت افزایش دهیم
   - مرورگرهای وب؟ نه ⛔
   - ایمیج‌های Docker؟ حذف شد 🗑️
   - محیط‌های اجرایی زبان؟ نابود شد 💥
   - مدیران بسته‌ای؟ منهدم شد 💣
   - مستندات؟ بخار شد ️👻

پاکسازی فایل سیستم توسط `rmz` (از پروژه [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) انجام می‌شود – جایگزین قدرتمند و سریع برای `rm` که بازپس‌گیری فضا را بسیار سریع می‌کند! ⚡
   - عملکردی چند برابر بهتر از `rm` استاندارد دارد
   - حذف‌ها را به صورت موازی برای بیشترین کارایی انجام می‌دهد
   - **فضای دیسک را در چند ثانیه، نه چند دقیقه، پس می‌گیرد!** ️⏱️

نتیجه نهایی؟ رانر GitHub Actions با **۶۵ تا ۱۳۰ گیگابایت** فضای آماده برای Nix! 😁

### رشد پویا حجم
برخلاف سایر راه‌حل‌ها، **فقط نیکس** حجم `/nix` شما را به صورت پویا افزایش می‌دهد:

1. **ایجاد اولیه حجم (۱ تا ۱۰ ثانیه):** (*بسته به پروتکل هچت*)
   - ایجاد یک دستگاه لوپ از فضای آزاد روی `/mnt`
   - راه‌اندازی فایل‌سیستم BTRFS در پیکربندی RAID0
   - مونت با فشرده‌سازی و بهینه‌سازی عملکرد
   - ارائه فوری ۶۵ گیگابایت `/nix` حتی پیش از آغاز پاکسازی

2. **گسترش در پس‌زمینه (۳۰ تا ۱۸۰ ثانیه):** (*بسته به پروتکل هچت*)
   - اجرای عملیات پاکسازی
   - پایش فضای آزادشده جدید در حین حذف حجیم‌ها
   - افزودن پویا یک دیسک توسعه به حجم `/nix`
   - متعادل‌سازی مجدد فایل‌سیستم برای به‌کارگیری فضای جدید

حجم `/nix` به صورت خودکار **در حین اجرای جریان کاری افزایش می‌یابد** 🎩🪄

### سلاح خود را انتخاب کنید: پروتکل هچت 🪓

سطح نابودی 💥 را با ورودی `hatchet-protocol` کنترل کنید:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### مقایسه پروتکل ⚖️

| پروتکل   | `/nix` | توضیحات                                             | پاکسازی apt | پاکسازی docker | پاکسازی snap | فایل سیستم‌های پاک شده      |
|----------|--------|-----------------------------------------------------|-------------|----------------|--------------|-----------------------------|
| Holster  | ~۶۵GB  | تبر را در غلاف نگه دارید، از فضای `/mnt` استفاده کنید | خیر         | خیر           | خیر         | هیچ‌کدام                    |
| Carve    | ~۸۵GB  | فضای آزاد `/` و `/mnt` را ترکیب و مهیا کنید         | خیر         | خیر           | خیر         | هیچ‌کدام                    |
| Cleave   | ~۱۱۵GB | برش‌های قدرتمند و قاطع بر بسته‌های بزرگ             | حداقلی      | بله           | بله         | `/opt` و `/usr/local`       |
| Rampage  | ~۱۳۰GB | حذف بی‌رحمانه و بی‌وقفه همه اضافات                   | تهاجمی      | بله           | بله         | موهاهاها! 🔥🌎              |

عاقلانه انتخاب کنید:
- **Holster** زمانی که نیاز دارید ابزارهای رانر کاملاً فعال بمانند
- **Carve** برای حفظ ابزارهای کاربردی رانر و تصاحب تمام فضای آزاد برای Nix
- **Cleave** (*پیش‌فرض*) برای تعادلی مناسب بین فضا و کارایی
- **Rampage** زمانی که بیشترین فضای Nix را می‌خواهید و مهم نیست چه چیزی خراب می‌شود `#nix-is-life`

### شاهد کشتار باشید 🩸

به طور پیش‌فرض، فرایند پاکسازی به صورت بی‌صدا در پس‌زمینه و در حین ادامه گردش کار شما انجام می‌شود. اما اگر می‌خواهید این کشتار را به صورت زنده تماشا کنید:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### سفارشی‌سازی مناطق امن 🛡️

کنترل کنید که چقدر فضا باید از تصرف فروشگاه نیکس با اندازه‌های سفارشی مناطق امن کنار گذاشته شود:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
این پناهگاه‌های امن مشخص می‌کنند که چه مقدار فضا (بر حسب مگابایت) در هنگام بازپس‌گیری فضا با بخشش حفظ می‌شود:
- مقدار پیش‌فرض `root-safe-haven` برابر با ۲۰۴۸ مگابایت (۲ گیگابایت) است
- مقدار پیش‌فرض `mnt-safe-haven` برابر با ۱۰۲۴ مگابایت (۱ گیگابایت) است

اگر به فضای تنفس بیشتری در فایل‌سیستم‌های خود نیاز دارید، این مقادیر را افزایش دهید، یا اگر می‌خواهید بی‌رحم باشید، آن‌ها را کاهش دهید! 😈

### اعطای مالکیت کاربر بر /nix (فرمان مجوز Nix) 🧑‍⚖️

برخی از نصب‌کننده‌ها یا پیکربندی‌های Nix انتظار دارند که پوشه `/nix` توسط کاربر فعلی قابل نوشتن باشد. به طور پیش‌فرض، مالکیت `/nix` با کاربر root است. اگر به مالکیت کاربر نیاز دارید (مثلاً برای برخی اسکریپت‌های نصب‌کننده Nix که برای همه عملیات داخل `/nix` از `sudo` استفاده نمی‌کنند)، می‌توانید `nix-permission-edict` را فعال کنید:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
وقتی مقدار `nix-permission-edict` روی `true` تنظیم شود، این عملیات پس از مانت کردن `/nix` فرمان `sudo chown -R "$(id --user)":"$(id --group)" /nix` را اجرا خواهد کرد.

### تنظیم Nix برای استفاده از /nix/build

این عملیات دایرکتوری `/nix/build` را برای استفاده ساخت‌های مشتق‌شده Nix از فضای بازیابی‌شده ایجاد می‌کند. گزینه `build-dir` را به پیکربندی Nix خود اضافه کنید:


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

یا با DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
این باعث می‌شود نیکس ساخت‌ها را روی حجم بزرگ BTRFS انجام دهد، نه روی دایرکتوری موقت پیش‌فرض سیستم.

## رفع اشکال 🔍

### "فضا روی دستگاه باقی نمانده است" هنگام ساخت‌های بزرگ

اگر با وجود استفاده از تنها نیکس، ساخت شما با کمبود فضا مواجه شود، احتمالاً به این دلیل است که پاکسازی پس‌زمینه قبل از مصرف فضای موجود توسط ساخت شما تکمیل نشده است. این مشکل معمولاً شامل موارد زیر می‌شود:

- تست‌های VM نیکس‌اواس که تصاویر دیسک بزرگی را مونتاژ می‌کنند
- ساخت‌هایی با وابستگی‌های فراوان که کش نشده‌اند
- ابزارهای Rust و سایر کامپایل‌های حجیم

**راه حل:** از `witness-carnage: true` استفاده کنید تا پاکسازی همزمان را اجبار کنید. این کار تضمین می‌کند که تمام فضا *قبل* از شروع ساخت شما بازیابی شود:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
این کار ۳۰ تا ۱۸۰ ثانیه به راه‌اندازی جریان کاری شما اضافه می‌کند، اما تضمین می‌کند که بیشترین فضای ممکن هنگام شروع ساخت شما در دسترس باشد.

حالا بروید و با تمام آن فضای باشکوه فروشگاه Nix چیزی شگفت‌انگیز بسازید! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---