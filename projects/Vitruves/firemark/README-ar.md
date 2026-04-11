
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

<h1 align="center">فايرمارك</h1>

<p align="center">أداة سريعة وموحدة لإضافة العلامة المائية للصور وملفات PDF. مبنية بلغة Rust.</p>

## لماذا تضع علامة مائية على مستنداتك؟

كل عام، يقع ملايين الأشخاص ضحية للاحتيال في الهوية الذي يبدأ من تبادل مستند بسيط.
سيناريو شائع: تبحث عن شقة للإيجار.
يطلب منك المالك — أو شخص يدعي أنه المالك — نسخة من هويتك، أو قسيمة راتب، أو إشعار ضريبي.
ترسلها بدون أي علامات.
يختفي "المالك"، وتُستخدم مستنداتك الآن لفتح حسابات بنكية، أو أخذ قروض، أو تزوير هويات باسمك.

إضافة علامة مائية لكل مستند ترسله هي الدفاع الأكثر فعالية على الإطلاق.
تراكب مرئي يقرأ **"أُرسل إلى وكالة XYZ — مارس 2026 — فقط لطلب إيجار شقة"** يجعل المستند غير صالح لأي غرض آخر.
وإذا تسرّب المستند، ستعرف بالضبط مصدره.

يجعل firemark هذا الأمر سهلاً للغاية: أمر واحد، أي صورة أو ملف PDF، 17 نمطاً بصرياً،
أنماط علامات مائية مشفرة تقاوم التعديل، ومعالجة دفعات لمجلدات كاملة.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="قبل وبعد وضع العلامة المائية" width="800">
  <br>
  <em>قبل وبعد — أمر واحد، أصبح المستند الآن قابلاً للتتبع وتظهر عليه علامات العبث بسهولة.</em>
</p>

## التثبيت

من [crates.io](https://crates.io/crates/firemark):




```bash
cargo install firemark
```

من المصدر:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
ينتج ملفًا ثنائيًا واحدًا محسنًا (حوالي 5 ميغابايت).

## البدء السريع


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
يتم حفظ الناتج بجانب الإدخال باسم `{name}-watermarked.{ext}` بشكل افتراضي.
استخدم `-o` لتعيين مسار إخراج محدد، أو `-S` لإضافة لاحقة مخصصة.

## أنواع العلامات المائية

| العلم | النمط | الوصف |
|---|---|---|
| `diagonal` | شبكة قطرية | نص متكرر قطري يغطي الصفحة كاملة (افتراضي) |
| `stamp` | ختم مطاطي | ختم كبير في المنتصف مع إطار مزدوج |
| `stencil` | استنسل | نص عسكري بعرض كامل بأسلوب استنسل |
| `typewriter` | آلة كاتبة | نص أحادي المسافة بأسلوب الآلة الكاتبة |
| `handwritten` | توقيع | توقيع بأسلوب خط اليد مع خط تحت النص |
| `redacted` | حجب | أشرطة حجب سوداء بعرض كامل |
| `badge` | درع | شعار درع/شارة أمان |
| `ribbon` | شريط | شريط زاوية قطري |
| `seal` | ختم | ختم دائري بأسلوب كاتب العدل |
| `frame` | إطار | إطار زخرفي يغطي الصفحة كاملة |
| `tile` | بلاطة | شبكة نصية كثيفة موحدة |
| `mosaic` | فسيفساء | نص مبعثر بشكل عشوائي |
| `weave` | نسج | نسج قطري متداخل |
| `ghost` | شبح | نص بارز شبه خفي جداً |
| `watercolor` | ألوان مائية | تأثير غسيل ضبابي ناعم |
| `noise` | ضجيج | نص متآكل مع ضجيج بيكسل |
| `halftone` | نصف طباعة | نص كشبكة نقاط نصف طباعة |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## بصمة الأمان

يضيف firemark طبقات من بصمات أمان مشفرة مستوحاة من ميزات أمان أوراق البنكنوت.
هذه الأنماط الهندسية الدقيقة يصعب للغاية إزالتها باستخدام محررات الصور.

| النمط | الوصف |
|---|---|
| `guilloche` | نطاقات موجية جيبية متداخلة (الافتراضي) |
| `rosette` | منحنيات سبيروغراف + ورد الزوايا |
| `crosshatch` | شبكة ماسية دقيقة مائلة |
| `border` | إطار أمان متموج متداخل |
| `lissajous` | أشكال ليساجو البارامترية |
| `moire` | تداخل دوائر متحدة المركز |
| `spiral` | دوامة حلزونية أرخميدية |
| `mesh` | شبكة سداسية خلية النحل |
| `plume` | منحنيات تشبه الريشة تتوزع عبر السطح |
| `constellation` | عقد نجوم متصلة بشبكة هندسية دقيقة |
| `ripple` | جبهات موجية بيضوية متداخلة من مصادر عشوائية |
| `full` | جميع الأنماط مجتمعة |
| `none` | تعطيل البصمة |


```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## تقوية مقاومة الإزالة بواسطة الذكاء الاصطناعي

كل عملية إخراج تكون غير حتمية بشكل افتراضي. يطبق firemark تشويشاً شمولياً بعد الإخراج
(ارتعاش في الشفافية، ضوضاء ألوان دون البكسل، نقاط دقيقة على الحواف،
وبيكسلات شبحية متناثرة) وتوليد عشوائي خاص بكل محرك إخراج بحيث لا يوجد إخراجان
متطابقان تماماً في البكسلات — حتى مع نفس الإعدادات. هذا يجعل من المستحيل على
نماذج رؤية الذكاء الاصطناعي تعلم نمط متوقع للإزالة.

بالإضافة إلى ذلك، يتم تضمين شرائط حقن نصوص عدائية بشكل افتراضي لربكة أدوات إزالة العلامات المائية بالذكاء الاصطناعي.
قم بإيقافها باستخدام `--no-anti-ai` إذا كنت لا ترغب في ظهور نص التوجيه:


```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## الخيارات الشائعة

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

للحصول على القائمة الكاملة التي تضم أكثر من 70 علامة، راجع [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## خيارات PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## المعالجة الدُفعية

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

يتم تخطي الملفات التي تحتوي بالفعل على العلامة المائية (المطابقة لللاحقة) تلقائيًا عند
إعادة التشغيل.

## ملف الإعدادات

احفظ الخيارات في ملف TOML لتجنب تكرار الوسائط. انظر
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) للحصول على
مثال كامل مع إعدادين مسبقين: **فائق الأمان** (توزيع كثيف، علامة مائية كاملة، تتبع QR،
إزالة البيانات الوصفية) و**خفيف** (نص قطري بسيط، بدون إضافات).

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

## دعم الصيغ

| الصيغة | إدخال | إخراج |
|---|---|---|
| PNG | نعم | نعم |
| JPEG | نعم | نعم |
| PDF | نعم | نعم |
| WebP | نعم | نعم |
| TIFF | نعم | نعم |

يتم دعم التحويل بين الصيغ المختلفة (مثال: `firemark photo.webp -o out.pdf`).

## الترخيص

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---