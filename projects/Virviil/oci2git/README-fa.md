
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

یک برنامه Rust که تصاویر کانتینر (مانند Docker و غیره) را به مخازن Git تبدیل می‌کند. هر لایه کانتینر به صورت یک commit در Git نمایش داده می‌شود و تاریخچه و ساختار تصویر اصلی را حفظ می‌کند.

![دموی تبدیل تصویر nginx توسط OCI2Git](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## ویژگی‌ها

- تجزیه و تحلیل تصاویر Docker و استخراج اطلاعات لایه‌ها
- ایجاد مخزن Git که در آن هر لایه تصویر به عنوان یک commit نمایش داده می‌شود
- پشتیبانی از لایه‌های خالی (ENV، WORKDIR و غیره) به صورت commit های خالی
- استخراج کامل فراداده‌ها به قالب Markdown
- معماری قابل توسعه برای پشتیبانی از موتورهای مختلف کانتینر

## موارد استفاده

### مقایسه لایه‌ها
هنگام رفع اشکال مشکلات کانتینر، می‌توانید از قابلیت‌های قدرتمند مقایسه Git برای شناسایی دقیق تغییرات بین هر دو لایه استفاده کنید. با اجرای `git diff` بین commit ها، مهندسان می‌توانند به طور دقیق ببینند چه فایل‌هایی اضافه، تغییر یا حذف شده‌اند، که فهم تاثیر هر دستور Dockerfile را بسیار ساده‌تر و یافتن تغییرات مشکل‌ساز را آسان‌تر می‌کند.
![نمونه‌ای برای مقایسه لایه](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### ردیابی منبع
با استفاده از `git blame`، توسعه‌دهندگان می‌توانند به سرعت مشخص کنند که کدام لایه یک فایل یا خط کد خاص را معرفی کرده است. این موضوع به ویژه هنگام عیب‌یابی فایل‌های پیکربندی یا وابستگی‌ها ارزشمند است. به جای بررسی دستی هر لایه، می‌توانید فوراً منبع هر فایل را به لایه منشا و دستور Dockerfile مربوطه ردیابی کنید.

### ردیابی چرخه عمر فایل
OCI2Git به شما امکان می‌دهد مسیر یک فایل خاص را در طول تاریخچه تصویر کانتینر دنبال کنید. می‌توانید ببینید یک فایل چه زمانی ایجاد شده، چگونه در لایه‌های مختلف تغییر کرده و در صورت حذف، چه زمانی حذف شده است. این نمای جامع به درک تحول فایل‌ها کمک می‌کند بدون نیاز به ردیابی دستی تغییرات در ده‌ها لایه احتمالی.

برای ردیابی تاریخچه یک فایل در تصویر کانتینر خود — شامل زمان ظاهر شدن اولیه، تغییر یا حذف — پس از تبدیل می‌توانید از این دستورات Git استفاده کنید:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
این دستورات ردیابی کامل تاریخچه هر فایل را در سراسر لایه‌های کانتینر ساده می‌کنند، بدون پیچیدگی استخراج و مقایسه دستی آرشیوهای لایه‌ای.

### تحلیل چندلایه‌ای
گاهی اوقات مفیدترین مقایسه‌ها از بررسی تغییرات در چندین لایه غیر متوالی حاصل می‌شود. با OCI2Git می‌توانید از ابزارهای مقایسه Git برای تحلیل نحوه تحول اجزا در مراحل مختلف ساخت بهره ببرید و الگوهایی را شناسایی کنید که ممکن است هنگام بررسی فقط لایه‌های مجاور قابل مشاهده نباشند.

### کاوش در لایه‌ها
با استفاده از `git checkout` برای رفتن به هر کامیت خاص، می‌توانید سیستم فایل کانتینر را دقیقاً همانطور که در آن لایه وجود داشته بررسی کنید. این امکان به توسعه‌دهندگان اجازه می‌دهد وضعیت دقیق فایل‌ها و دایرکتوری‌ها را در هر نقطه از فرآیند ساخت تصویر بررسی کنند و هنگام اشکال‌زدایی یا بررسی رفتار کانتینر، زمینه‌ای ارزشمند فراهم می‌آورد.
![Checkout to previous commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### تحلیل چندتصویری

هنگام کار با چند تصویر کانتینر که نیاکان مشترک دارند، OCI2Git به‌طور هوشمندانه فقط زمانی شاخه جدید ایجاد می‌کند که تصاویر واقعاً از هم جدا شوند. این قابلیت به شما امکان می‌دهد چند تصویر مرتبط را در یک مخزن تحلیل کنید و در عین حال تاریخچه مشترک آن‌ها را حفظ نمایید.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git به طور خودکار لایه‌های مشترک بین تصاویر را شناسایی می‌کند و ساختاری شاخه‌ای ایجاد می‌کند که پایه مشترک آن‌ها را نشان می‌دهد. تاریخچه Git نشان خواهد داد:
- تنه مشترکی که همه لایه‌های مشترک را شامل می‌شود
- شاخه‌های جداگانه‌ای که فقط زمانی از هم جدا می‌شوند که تصاویر واقعاً متفاوت باشند
- نمایش واضح محل اشتراک اجداد تصاویر در مقابل جایی که منحصر به فرد می‌شوند
- مدیریت هوشمند تکراری‌ها: اگر دقیقاً همان تصویر دوبار پردازش شود، الگوریتم این را قبل از ثبت نهایی متادیتا شناسایی کرده و از ایجاد شاخه تکراری جلوگیری می‌کند

این رویکرد به ویژه برای موارد زیر ارزشمند است:
- **تحلیل خانواده تصویر**: درک نحوه ارتباط نسخه‌ها، معماری‌ها یا پیکربندی‌های مختلف یک تصویر با یکدیگر
- **تأثیر تصویر پایه**: مشاهده دقیق نحوه تأثیر تغییرات تصویر پایه بر تصاویر مشتق شده متعدد
- **فرصت‌های بهینه‌سازی**: شناسایی اجزای مشترک که می‌توانند بهتر در بین انواع تصویر استفاده شوند

![ساختار مخزن چندتصویری که پایه مشترک و شاخه‌های منشعب را نشان می‌دهد](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### موارد استفاده اضافی

- **ممیزی امنیتی**: شناسایی دقیق زمانی که پکیج‌ها یا پیکربندی‌های آسیب‌پذیر اضافه شده‌اند و ردیابی آن‌ها تا دستور ساخت مشخص.
- **بهینه‌سازی تصویر**: تحلیل ساختار لایه‌ها برای یافتن عملیات‌های تکراری یا فایل‌های بزرگ که می‌توانند یکپارچه شوند و به کاهش اندازه تصویر کمک کنند.
- **مدیریت وابستگی‌ها**: پایش زمان اضافه شدن، ارتقاء یا حذف وابستگی‌ها در سراسر تاریخچه تصویر.
- **بهبود فرآیند ساخت**: بررسی ترکیب لایه‌ها برای بهینه‌سازی دستورات Dockerfile جهت کش بهتر و کاهش اندازه تصویر.
- **مقایسه تصاویر مرتبط**: تبدیل چندین تصویر مرتبط به مخزن‌های Git و استفاده از ابزارهای مقایسه Git برای تحلیل تفاوت‌ها و اشتراکات آن‌ها.

## نصب

### از سورس

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### از Crates.io

```bash
cargo install oci2git
```

## استفاده

```bash
oci2git [OPTIONS] <IMAGE>
```

آرگومان‌ها:
  `<IMAGE>`  نام تصویری که باید تبدیل شود (مثلاً 'ubuntu:latest') یا مسیر فایل tar هنگام استفاده از موتور tar

گزینه‌ها:
  `-o, --output <o>`  مسیر دایرکتوری خروجی برای مخزن Git [پیش‌فرض: ./container_repo]
  `-e, --engine <ENGINE>`  موتور کانتینر مورد استفاده (docker، nerdctl، tar) [پیش‌فرض: docker]
  `-h, --help`            نمایش اطلاعات راهنما
  `-V, --version`         نمایش اطلاعات نسخه

متغیرهای محیطی:
  `TMPDIR`  این متغیر محیطی را برای تغییر محل پیش‌فرض پردازش داده‌های واسطه تنظیم کنید. این مقدار به پلتفرم بستگی دارد (مثلاً `TMPDIR` در یونیکس/macOS، `TEMP` یا `TMP` در ویندوز).

## مثال‌ها

استفاده از موتور Docker (پیش‌فرض):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
استفاده از یک بسته فشرده تصویر که قبلاً دانلود شده است:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
موتور tar انتظار یک فایل tar با فرمت معتبر OCI را دارد که معمولاً با دستور `docker save` ایجاد می‌شود:

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```
این کار یک مخزن گیت در مسیر `./ubuntu-repo` ایجاد می‌کند که شامل موارد زیر است:
- `Image.md` - فراداده کامل درباره تصویر به صورت فرمت Markdown
- `rootfs/` - محتوای سیستم‌فایل استخراج‌شده از کانتینر

تاریخچه گیت بازتاب‌دهنده تاریخچه لایه‌های کانتینر است:
- اولین کامیت فقط شامل فایل `Image.md` با فراداده کامل است
- هر کامیت بعدی نمایانگر یک لایه از تصویر اصلی است
- پیام کامیت شامل دستور Dockerfile مربوط به آن لایه است

## ساختار مخزن


```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## الزامات

- نسخه ۲۰۲۱ راست (Rust)
- رابط خط فرمان داکر (برای پشتیبانی از موتور داکر)
- گیت

## مجوز

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---