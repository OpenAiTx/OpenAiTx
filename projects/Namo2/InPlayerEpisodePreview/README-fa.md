<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <p>ترجمه‌های زیر به صورت خودکار با استفاده از هوش مصنوعی تولید شده‌اند. لطفاً توجه داشته باشید که ممکن است شامل نادقتی باشند یا به نسخه‌های قدیمی‌تر این فایل راهنما اشاره کنند.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

پیش‌نمایش قسمت‌ها در پخش‌کننده
====================
## 📄 درباره
این افزونه یک لیست از قسمت‌ها را به پخش‌کننده ویدیو اضافه می‌کند که به شما امکان می‌دهد هر قسمت سریال تلویزیونی را بدون ترک پخش‌کننده مشاهده کنید.

این تغییر برای مشتریان زیر پشتیبانی می‌شود:
* [کلاینت وب Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [پخش‌کننده رسانه Jellyfin](https://github.com/jellyfin/jellyfin-media-player) (JMP) کلاینت دسکتاپ

## ✨ ویژگی‌ها
* فهرست کردن تمام قسمت‌های یک فصل
* جابجایی بین فصل‌ها
* نمایش عنوان قسمت، توضیحات، تصویر بندانگشتی و پیشرفت پخش
* نمایش جزئیات قسمت مانند رتبه‌بندی جامعه
* علامت‌گذاری قسمت‌ها به عنوان پخش‌شده یا مورد علاقه
* شروع یک قسمت جدید
* باید با قالب‌های سفارشی سازگار باشد

## 📸 پیش‌نمایش
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

قالب استفاده شده: (SkinManager) Kaleidochromic
<br>
این پیش‌نمایش فاقد دکمه‌های جدید برای علامت‌گذاری یک قسمت به عنوان تکمیل‌شده یا مورد علاقه است.

## 🔧 نصب

### کلاینت وب Jellyfin (سرور)

> [!توجه]
> توصیه اکید می‌شود که [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) حداقل نسخه v2.2.1.0 نصب باشد. این افزونه به جلوگیری از مشکلات دسترسی هنگام تغییر index.html در هر نوع نصب کمک می‌کند!
<details open>
<summary> مشاهده دستورالعمل‌ها... </summary>

1. فایل manifest با آدرس `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` را به عنوان مخزن افزونه Jellyfin به سرور خود اضافه کنید.
2. افزونه `InPlayerEpisodePreview` را از مخزن نصب کنید.
3. سرور Jellyfin را مجدداً راه‌اندازی کنید.
</details>

### کلاینت دسکتاپ Jellyfin Media Player (JMP) (منسوخ شده)
<details>
<summary> مشاهده دستورالعمل‌ها... </summary>

**منسوخ شده با نسخه JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

از آنجایی که کلاینت جدید JMP از پخش‌کننده وب فعلی سرور استفاده می‌کند، دیگر نیازی به تغییر مستقیم کد کلاینت نیست.

این روش توصیه‌شده برای نصب اسکریپت در کلاینت دسکتاپ است.
اگر خودتان احساس راحتی نمی‌کنید که فایل nativeshell.js را ویرایش کنید (مرحله ۳ تا ۶)، می‌توانید نسخه کامل را دانلود کنید که اسکریپت مورد نظر را از قبل به فایل nativeshell.js اضافه کرده است.
هنوز مشخص نیست که آیا جایگزین کردن فایل nativeshell.js با نسخه منتشر شده ممکن است مشکلاتی ایجاد کند یا نه، بنابراین توصیه می‌شود تمام مراحل زیر را دنبال کنید.

۱. آخرین نسخه [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) یا [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (که اسکریپت به فایل nativeshell.js اضافه شده است) را دانلود کنید.
۲. فایل zip را در دایرکتوری Jellyfin خود استخراج کنید (مثلاً C:\Program Files\Jellyfin\Jellyfin Media Player)
۳. در دایرکتوری Jellyfin خود مسیر پوشه "web-client\extension" را دنبال کنید.
۴. فایل "nativeshell.js" را با یک ویرایشگر متنی باز کنید.
۵. در داخل فایل بخش `const plugins = [];` را پیدا کنید. یک خط جدید در ابتدای لیست اضافه کنید و `'inPlayerEpisodePreviewPlugin',` را جایگذاری کنید. اکنون این بخش باید مشابه زیر باشد:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. فایل را ذخیره کرده و کلاینت JMP را مجدداً راه‌اندازی کنید.
</details>

## 💡 رفع اشکال

### 1. دکمه پیش‌نمایش قابل مشاهده نیست
احتمالاً این موضوع به دلیل مجوزهای اشتباه برای فایل `index.html` است.

<details>
<summary> فهرستی از راه‌حل‌های ممکن را مشاهده کنید... </summary>

#### 1.1 از این مشکل با استفاده از افزونه [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) جلوگیری کنید.

#### 1.2 تغییر مالکیت درون یک کانتینر داکر
اگر jellyfin را در یک کانتینر داکر اجرا می‌کنید، می‌توانید مالکیت را با دستور زیر تغییر دهید
(نام jellyfin را با نام کانتینر خود و user و group را با کاربر و گروه کانتینر خود جایگزین کنید):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
شما می‌توانید این را به عنوان یک کرون جاب هنگام راه‌اندازی سیستم اجرا کنید.
(با تشکر از [muisje](https://github.com/muisje) برای کمک در [این](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) راه‌حل)

#### ۱.۳ تغییر مالکیت در نصب ویندوزی
۱. به مسیر زیر بروید: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
۲. روی `index.html` راست‌کلیک کنید → `Properties` → تب `Security` → روی `Edit` کلیک کنید
۳. کاربر خود را از لیست انتخاب کنید و گزینه دسترسی نوشتن (Write `permission`) را تیک بزنید.
۴. هر دو سرور و کلاینت را مجدداً راه‌اندازی کنید.
   (با تشکر از [xeuc](https://github.com/xeuc) برای [این](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) راه‌حل)

اگر هیچ‌یک از راه‌حل‌های بالا جواب نداد، لطفاً به مسائل قدیمی نگاهی بیندازید. مثلا [اینجا](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) یا [اینجا](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
اگر با خطایی مواجه شدید که نتوانستید خودتان حل کنید، آزادانه یک issue باز کنید.
<br/>لطفاً به خاطر داشته باشید که هر سیستمی متفاوت است و ممکن است رفتارهای غیرمنتظره رخ دهد، پس تا حد امکان اطلاعات بیشتری ارائه دهید.
<br/>لاگ‌های Jellyfin و لاگ‌های کنسول مرورگر (با پیشوند [InPlayerEpisodePreview]) همیشه مفید هستند.

## اعتبارها
ساختار این افزونه بر اساس و با الهام از افزونه [Jellyscrub](https://github.com/nicknsy/jellyscrub) نوشته [NickNSY](https://github.com/nicknsy) است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---