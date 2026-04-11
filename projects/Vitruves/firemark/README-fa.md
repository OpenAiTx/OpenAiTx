
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">فایرمَرک</h1>

<p align="center">ابزاری سریع و تک‌فایل برای واترمارک‌گذاری تصاویر و PDFها. ساخته‌شده با راست.</p>

## چرا اسناد خود را واترمارک کنید؟

هر سال، میلیون‌ها نفر قربانی کلاهبرداری هویتی می‌شوند که با یک
معاوضه ساده سند آغاز می‌شود. یک سناریوی رایج: شما به دنبال اجاره یک آپارتمان هستید.
مالک — یا فردی که خود را مالک جا می‌زند — درخواست یک کپی از کارت شناسایی شما، فیش حقوقی،
اعلامیه مالیاتی می‌کند. شما آن‌ها را بدون علامت ارسال می‌کنید. "مالک" ناپدید می‌شود و اسناد شما اکنون برای افتتاح حساب بانکی، گرفتن وام یا جعل
هویت به نام شما استفاده می‌شوند.

واترمارک کردن هر سندی که ارسال می‌کنید، مؤثرترین دفاع است.
یک پوشش قابل مشاهده با متن **"ارسال شده به آژانس XYZ — مارس ۲۰۲۶ — فقط درخواست اجاره آپارتمان"**
سند را برای هر هدف دیگری بی‌ارزش می‌کند. اگر سند افشا شود، دقیقاً می‌دانید از کجا آمده است.

firemark این کار را بی‌دردسر انجام می‌دهد: یک فرمان، هر تصویر یا PDF، ۱۷ سبک بصری،
الگوهای فیلگرین رمزنگاری شده که در برابر ویرایش مقاوم‌اند، و پردازش دسته‌ای برای کل پوشه‌ها.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="قبل و بعد از واترمارک کردن" width="800">
  <br>
  <em>قبل و بعد — یک فرمان، سند اکنون قابل ردیابی و تغییر آن قابل تشخیص است.</em>
</p>

## نصب

از [crates.io](https://crates.io/crates/firemark):




```bash
cargo install firemark
```

از منبع:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
یک فایل اجرایی بهینه‌سازی شده‌ی واحد (~۵ مگابایت) تولید می‌کند.

## شروع سریع


```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
خروجی به طور پیش‌فرض در کنار ورودی با فرمت `{name}-watermarked.{ext}` ذخیره می‌شود.
برای تعیین مسیر خروجی صریح از `-o` و برای پسوند سفارشی از `-S` استفاده کنید.

## انواع واترمارک

| پرچم | سبک | توضیحات |
|---|---|---|
| `diagonal` | شبکه مورب | متن مورب تکرار شونده تمام صفحه (پیش‌فرض) |
| `stamp` | مهر لاستیکی | مهر بزرگ مرکزی با دو حاشیه |
| `stencil` | شابلون | متن شابلون نظامی عرض کامل |
| `typewriter` | ماشین تحریر | متن با فونت تک‌فاصله ماشین تحریر |
| `handwritten` | امضا | امضای دست‌نویس با خط زیرین |
| `redacted` | سانسور | نوارهای سیاه سانسور عرض کامل |
| `badge` | نشان | نماد نشان امنیتی/سپر |
| `ribbon` | روبان | بنر روبان مورب گوشه |
| `seal` | مهر | مهر دایره‌ای سبک دفترخانه |
| `frame` | قاب | حاشیه تزئینی تمام صفحه |
| `tile` | کاشی | شبکه متن یکنواخت متراکم |
| `mosaic` | موزاییک | متن پراکنده تصادفی |
| `weave` | بافت | بافت مورب درهم‌تنیده |
| `ghost` | شبح | متن برجسته فوق‌العاده ظریف |
| `watercolor` | آبرنگ | افکت شسته نرم و محو |
| `noise` | نویز | متن آسیب‌دیده با نویز پیکسلی |
| `halftone` | نیم‌تن | متن به صورت شبکه نقطه نیم‌تن |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## فیلیگران امنیتی

firemark الگوهای فیلیگران رمزنگاری شده‌ای را که از ویژگی‌های امنیتی اسکناس‌ها الهام گرفته شده، به صورت پوششی اعمال می‌کند. این الگوهای هندسی ظریف، حذف آن‌ها با ویرایشگرهای تصویر را بسیار دشوار می‌سازد.

| سبک | توضیحات |
|---|---|
| `guilloche` | نوارهای موجی سینوسی (پیش‌فرض) |
| `rosette` | اسپایروگراف + منحنی‌های گل رز در گوشه‌ها |
| `crosshatch` | شبکه لوزی مورب ظریف |
| `border` | حاشیه امنیتی موجی و تو در تو |
| `lissajous` | اشکال پارامتریک لیساژو |
| `moire` | تداخل دایره‌های هم‌مرکز |
| `spiral` | گرداب مارپیچی ارشمیدسی |
| `mesh` | شبکه شش‌ضلعی لانه زنبوری |
| `plume` | منحنی‌های پرمانند روان که روی سطح پراکنده‌اند |
| `constellation` | گره‌های ستاره‌ای متصل با شبکه هندسی ظریف |
| `ripple` | جبهه‌های موج بیضوی همپوشان با منشأ تصادفی |
| `full` | ترکیب همه الگوها |
| `none` | غیرفعال‌سازی فیلیگران |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## مقاوم‌سازی در برابر حذف توسط هوش مصنوعی

هر رندر به طور پیش‌فرض غیرقطعی است. firemark پس از رندر، اختلالات جهانی
(لرزش آلفا، نویز رنگ زیرپیکسلی، نقاط میکرو در لبه‌ها،
پیکسل‌های شبح پراکنده) و تصادفی‌سازی مخصوص هر رندرکننده را اعمال می‌کند تا هیچ دو خروجی‌ای
از نظر پیکسلی کاملاً یکسان نباشند — حتی با تنظیمات یکسان. این باعث می‌شود مدل‌های بینایی هوش مصنوعی
نتوانند الگوی قابل پیش‌بینی برای حذف را یاد بگیرند.

علاوه بر این، نوارهای تزریق درخواست خصمانه به طور پیش‌فرض درج می‌شوند تا
ابزارهای حذف واترمارک هوش مصنوعی را سردرگم کنند. برای غیرفعال کردن، از `--no-anti-ai` استفاده کنید اگر
متن درخواست قابل مشاهده را نمی‌خواهید:

```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## گزینه‌های رایج

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

برای مشاهده فهرست کامل بیش از ۷۰ فلگ، به [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md) مراجعه کنید.

## گزینه‌های PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## پردازش دسته‌ای

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

فایل‌هایی که قبلاً واترمارک شده‌اند (با پسوند مشابه) به طور خودکار در اجرای مجدد رد می‌شوند.

## فایل پیکربندی

گزینه‌ها را در یک فایل TOML ذخیره کنید تا نیاز به تکرار پرچم‌ها نباشد. برای مشاهده نمونه کامل با دو پیش‌تنظیم: **فوق‌العاده ایمن** (کاشی‌کاری متراکم، واترمارک کامل، قابلیت ردیابی QR، حذف متادیتا) و **سبک** (متن قطری ساده، بدون ویژگی اضافی)، به [`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) مراجعه کنید.





```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## پشتیبانی از فرمت

| فرمت | ورودی | خروجی |
|---|---|---|
| PNG | بله | بله |
| JPEG | بله | بله |
| PDF | بله | بله |
| WebP | بله | بله |
| TIFF | بله | بله |

تبدیل بین فرمت‌ها پشتیبانی می‌شود (مثلاً `firemark photo.webp -o out.pdf`).

## مجوز

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---