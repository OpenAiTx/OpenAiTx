
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

**رنر GitHub Actions خود را به یک [نیکس](https://zero-to-nix.com/concepts/nix/) ❄️ قدرتمند تبدیل کنید، با حذف بی‌رحمانه نرم‌افزارهای اضافی از پیش نصب‌شده.**

رنرهای GitHub Actions فضای دیسک بسیار کمی برای نیکس دارند - تنها حدود ~20GB.
*فقط نیکس* **به شدت نرم‌افزارهای غیرضروری را پاک می‌کند** و به شما **65GB تا 130GB** برای مخزن نیکس می‌دهد! 💪

## استفاده 🔧

این اکشن را **قبل از** نصب نیکس در جریان کاری خود اضافه کنید:

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

## مشکل: جا باز کردن برای شکوفایی Nix 🌱

رانرهای استاندارد GitHub Actions پر از *"نرم‌افزارهای زائد"* هستند که هرگز در گردش کار Nix به کارتان نمی‌آیند:

- 🌍 مرورگرهای وب. تعداد زیادی از آن‌ها. همه‌شان باید باشند!
- 🐳 ایمیج‌های داکر که چندین گیگابایت فضای ارزشمند دیسک را اشغال می‌کنند
- 💻 زمان‌ اجراهای زبان‌های غیرضروری (.NET، روبی، پی‌اچ‌پی، جاوا...)
- 📦 مدیران بسته‌ای که فقط گرد و غبار دیجیتال جمع می‌کنند
- 📚 مستنداتی که هیچ‌کس هرگز نخواهد خواند

این اضافه‌بار فقط حدود ~۲۰ گیگابایت برای فروشگاه Nix شما باقی می‌گذارد - که برای ساخت‌های جدی Nix به سختی کافی است! 😞

## راه‌حل: فقط Nix ️❄️

**فقط Nix** رویکردی سوزاننده برای رانرهای GitHub Actions اتخاذ می‌کند و بی‌رحمانه فضای دیسک را با حمله‌ای دو مرحله‌ای بازپس می‌گیرد:

1. **برش اولیه:** بلافاصله یک پارتیشن بزرگ `/nix` (~۶۵ گیگابایت) با تصاحب فضای آزاد از `/mnt` ایجاد می‌کند
2. **حمله پس‌زمینه:** در حالی که گردش کار شما ادامه دارد، ما به شدت نرم‌افزارهای غیرضروری را حذف می‌کنیم تا حجم `/nix` شما تا ~۱۳۰ گیگابایت افزایش یابد
   - مرورگرهای وب؟ نه ⛔
   - ایمیج‌های داکر؟ حذف شد 🗑️
   - زمان‌ اجراهای زبان؟ نابود شدند 💥
   - مدیران بسته؟ منهدم شدند 💣
   - مستندات؟ بخار شدند ️👻

پاک‌سازی فایل سیستم توسط `rmz` (از پروژه [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) انجام می‌شود - جایگزینی با عملکرد بالا برای `rm` که فرآیند بازپس‌گیری فضا را فوق‌العاده سریع می‌کند! ⚡
   - از `rm` استاندارد به طور چشمگیری سریع‌تر است
   - حذف‌ها را به صورت موازی انجام می‌دهد برای حداکثر کارایی
   - **فضای دیسک را در چند ثانیه به جای چند دقیقه بازپس می‌گیرد!** ️⏱️

نتیجه نهایی؟ یک رانر GitHub Actions با **۶۵ تا ۱۳۰ گیگابایت** فضای آماده برای Nix! 😁

### رشد پویا حجم دیسک

بر خلاف راه‌حل‌های دیگر، **فقط Nix** حجم `/nix` شما را به صورت پویا افزایش می‌دهد:

1. **ایجاد اولیه حجم (۱-۱۰ ثانیه):** (*بسته به پروتکل Hatchet*)
   - یک دستگاه loop از فضای آزاد روی `/mnt` می‌سازد
   - یک فایل‌سیستم BTRFS در حالت RAID0 راه‌اندازی می‌کند
   - با فشرده‌سازی و تنظیمات عملکردی مونت می‌کند
   - بلافاصله یک `/nix` ۶۵ گیگابایتی ارائه می‌دهد، حتی قبل از آغاز پاک‌سازی

2. **گسترش پس‌زمینه (۳۰-۱۸۰ ثانیه):** (*بسته به پروتکل Hatchet*)
   - عملیات پاک‌سازی را اجرا می‌کند
   - آزاد شدن فضای جدید با حذف اضافه‌بار را پایش می‌کند
   - دیسک گسترش‌دهنده را به صورت پویا به حجم `/nix` اضافه می‌کند
   - فایل‌سیستم را برای یکپارچه‌سازی فضای جدید دوباره بالانس می‌کند

حجم `/nix` به طور خودکار **در طول اجرای گردش کار رشد می‌کند** 🎩🪄

### سلاح خود را انتخاب کنید: پروتکل Hatchet 🪓

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

زمانی که مقدار `nix-permission-edict` روی `true` تنظیم شود، این اقدام پس از مانت کردن `/nix`، فرمان `sudo chown -R "$(id --user)":"$(id --group)" /nix` را اجرا خواهد کرد.

حالا بروید و با تمام این فضای باشکوه فروشگاه Nix چیزهای شگفت‌انگیزی بسازید! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---