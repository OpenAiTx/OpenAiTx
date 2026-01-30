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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![مستندات](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![مجوز](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)

[![تعداد دانلودها](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (شبیه‌سازی برای test.yaml آینده)
[//]: # ([![وضعیت تست]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

یک برنامه Rust که تصاویر کانتینری (Docker و غیره) را به مخازن Git تبدیل می‌کند. هر لایه کانتینر به صورت یک commit در Git نمایش داده می‌شود و تاریخچه و ساختار تصویر اصلی را حفظ می‌کند.

![نمایش دمو از OCI2Git هنگام تبدیل تصویر nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## ویژگی‌ها

- تحلیل تصاویر Docker و استخراج اطلاعات لایه‌ها
- ایجاد یک مخزن Git که هر لایه تصویر به صورت یک commit نمایش داده می‌شود
- پشتیبانی از لایه‌های خالی (ENV، WORKDIR و غیره) به عنوان commitهای خالی
- استخراج کامل اطلاعات متادیتا به فرمت Markdown
- معماری قابل توسعه برای پشتیبانی از موتورهای مختلف کانتینر

## کاربردها

### مقایسه لایه‌ها (Layer Diffing)
هنگام عیب‌یابی مشکلات کانتینر، می‌توانید از قابلیت مقایسه قدرتمند Git برای شناسایی دقیق تغییرات بین دو لایه استفاده کنید. با اجرای `git diff` بین commitها، مهندسان می‌توانند دقیقا مشاهده کنند چه فایل‌هایی اضافه، ویرایش یا حذف شده‌اند، که درک تاثیر هر دستور Dockerfile و یافتن تغییرات مشکل‌ساز را بسیار ساده‌تر می‌کند.
![نمونه‌ای برای مقایسه لایه‌ها](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### رهگیری منشاء (Origin Tracking)
با استفاده از `git blame`، توسعه‌دهندگان می‌توانند به سرعت تعیین کنند که کدام لایه یک فایل یا خط خاص را معرفی کرده است. این موضوع به‌ویژه هنگام عیب‌یابی فایل‌های پیکربندی یا وابستگی‌ها بسیار ارزشمند است. به جای بررسی دستی هر لایه، می‌توانید بلافاصله منشاء هر فایل را تا لایه مبدا و دستور Dockerfile مرتبط دنبال کنید.

### رهگیری چرخه عمر فایل (File Lifecycle Tracking)
OCI2Git این امکان را به شما می‌دهد که مسیر یک فایل خاص را در کل تاریخچه تصویر کانتینری دنبال کنید. می‌توانید مشاهده کنید که یک فایل چه زمانی ایجاد شد، در لایه‌های مختلف چگونه تغییر کرد و چه زمانی (در صورت وجود) حذف شد. این دید جامع به درک سیر تحول فایل کمک می‌کند بدون نیاز به ردیابی دستی تغییرات در ده‌ها لایه احتمالی.

برای رهگیری تاریخچه یک فایل در تصویر کانتینر خود — از جمله زمانی که برای اولین بار ظاهر شد، تغییر یافت یا حذف شد — می‌توانید پس از تبدیل از این دستورات Git استفاده کنید:

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
OCI2Git به طور خودکار لایه‌های مشترک بین تصاویر را شناسایی می‌کند و ساختار شاخه‌ای را ایجاد می‌نماید که پایه مشترک آن‌ها را نشان می‌دهد. تاریخچه گیت موارد زیر را نمایش خواهد داد:
- یک تنه مشترک که شامل تمام لایه‌های مشترک است
- شاخه‌های جداگانه که فقط زمانی که تصاویر واقعاً متفاوت می‌شوند از هم جدا می‌شوند
- نمایش واضحی از جایی که تصاویر اجداد مشترک دارند در مقابل جایی که منحصر به فرد می‌شوند
- مدیریت هوشمند تکراری‌ها: اگر دقیقاً همان تصویر دوبار پردازش شود، الگوریتم این موضوع را قبل از ثبت نهایی متادیتا شناسایی کرده و از ایجاد شاخه تکراری صرف نظر می‌کند

این رویکرد به ویژه برای موارد زیر ارزشمند است:
- **تحلیل خانواده تصویر**: درک چگونگی ارتباط انواع مختلف یک تصویر (نسخه‌ها، معماری‌ها یا پیکربندی‌های مختلف) با یکدیگر
- **تأثیر تصویر پایه**: مشاهده دقیق اینکه تغییرات در یک تصویر پایه چگونه بر چندین تصویر مشتق شده تأثیر می‌گذارد
- **فرصت‌های بهینه‌سازی**: شناسایی مؤلفه‌های مشترک که می‌توان از آن‌ها در انواع تصویر بهتر استفاده کرد

![ساختار مخزن چند تصویری که پایه مشترک و شاخه‌های منشعب را نشان می‌دهد](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### موارد استفاده اضافی

- **ممیزی امنیتی**: مشخص کردن دقیق زمان ورود بسته‌ها یا پیکربندی‌های آسیب‌پذیر و ردیابی آن‌ها تا دستورالعمل‌های ساخت خاص.
- **بهینه‌سازی تصویر**: تحلیل ساختار لایه‌ها برای یافتن عملیات تکراری یا فایل‌های بزرگی که می‌توان آن‌ها را ادغام کرد تا اندازه تصویر کاهش یابد.
- **مدیریت وابستگی‌ها**: پایش زمان افزودن، به‌روزرسانی یا حذف وابستگی‌ها در طول تاریخچه تصویر.
- **بهبود فرآیند ساخت**: بررسی ترکیب لایه‌ها برای بهینه‌سازی دستورالعمل‌های داکرفایل به منظور کش بهتر و اندازه تصویر کوچکتر.
- **مقایسه بین تصاویر**: تبدیل چند تصویر مرتبط به مخزن گیت و استفاده از ابزارهای مقایسه گیت برای تحلیل تفاوت‌ها و اشتراکات آن‌ها.

## نصب

### مدیریت بسته‌ها

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### دبیان / اوبونتو

بسته .deb را از [آخرین نسخه منتشر شده](https://github.com/virviil/oci2git/releases/latest) دانلود و نصب کنید:

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### آرچ لینوکس (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### فایل‌های اجرایی آماده

فایل اجرایی مناسب برای پلتفرم خود را از [آخرین نسخه منتشر شده](https://github.com/virviil/oci2git/releases/latest) دانلود کنید:

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### از Crates.io

```bash
cargo install oci2git
```

### از منبع

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
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

- نسخه ۲۰۲۱ زبان Rust
- رابط خط فرمان Docker (برای پشتیبانی از موتور Docker)
- گیت

## مجوز

MIT

[مستندات]: https://docs.rs/oci2git/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---