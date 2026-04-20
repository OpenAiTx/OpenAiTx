<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">انگلیسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">فرانسوی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">آلمانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">اسپانیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">ایتالیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">روسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">پرتغالی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">هلندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">لهستانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">ترکی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">ویتنامی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">اندونزیایی</a></p>
      </div>
    </div>
  </details>
</div>

# اسپارکی‌فیتنس

یک جایگزین خودمیزبان و حریم‌خصوصی محور برای MyFitnessPal. تغذیه، ورزش، معیارهای بدن و داده‌های سلامتی را پیگیری کنید و کنترل کامل داده‌های خود را حفظ نمایید.

![اسکرین‌شات](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

اسپارکی‌فیتنس یک پلتفرم پیگیری تناسب اندام خودمیزبان است که از موارد زیر تشکیل شده است:

- یک سرور پشتیبان (API + ذخیره‌سازی داده)
- یک رابط کاربری مبتنی بر وب
- اپلیکیشن‌های موبایل بومی برای iOS و اندروید

داده‌های سلامت را در زیرساختی که خودتان کنترل می‌کنید ذخیره و مدیریت می‌کند، بدون وابستگی به سرویس‌های شخص ثالث.

## ویژگی‌های اصلی

- ردیابی تغذیه، ورزش، هیدراسیون، خواب، روزه‌داری، خلق‌وخو و اندازه‌گیری‌های بدن
- تعیین هدف و بررسی‌های روزانه
- نمودارهای تعاملی و گزارش‌های بلندمدت
- پروفایل‌های چند کاربره و دسترسی خانوادگی
- تم‌های روشن و تیره
- OIDC، TOTP، Passkey، MFA و غیره

## یکپارچه‌سازی سلامت و دستگاه

SparkyFitness می‌تواند داده‌ها را از چندین پلتفرم سلامت و تناسب اندام همگام‌سازی کند:

- **Apple Health** (iOS)
- **Google Health Connect** (اندروید)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (تست شده به طور جزئی)
- **Hevy** (تست نشده)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (تست شده به طور جزئی)

یکپارچه‌سازی‌ها به طور خودکار داده‌های فعالیت مانند قدم‌ها، تمرینات و خواب را همراه با شاخص‌های سلامت نظیر وزن و اندازه‌گیری‌های بدن، به سرور SparkyFitness شما همگام‌سازی می‌کنند.

## ویژگی‌های اختیاری هوش مصنوعی (بتا)

SparkyAI یک رابط مکالمه‌ای برای ثبت داده و بررسی پیشرفت فراهم می‌کند.

- ثبت غذا، ورزش، آمار بدن و قدم‌ها از طریق چت
- بارگذاری تصاویر غذا برای ثبت خودکار وعده غذایی
- تاریخچه مکالمات را برای پیگیری‌های بعدی حفظ می‌کند

توجه: قابلیت‌های هوش مصنوعی در حال حاضر در نسخه بتا هستند.

## شروع سریع (سرور)

یک سرور SparkyFitness را در عرض چند دقیقه با استفاده از Docker Compose اجرا کنید.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```


## 🎥 آموزش ویدیویی

[![تماشای ویدیو](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

آموزش سریع ۲ دقیقه‌ای برای نصب SparkyFitness (ردیاب تناسب اندام خود میزبان).


## مستندات

برای راهنمای کامل نصب، گزینه‌های پیکربندی و مستندات توسعه، لطفاً به [سایت مستندات ما](https://codewithcj.github.io/SparkyFitness/) مراجعه کنید.

### لینک‌های سریع

- **[راهنمای نصب](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - استقرار و پیکربندی‌ها
- **[بررسی ویژگی‌ها](https://codewithcj.github.io/SparkyFitness/features)** - مستندات کامل ویژگی‌ها
- **[گردش کار توسعه](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - راهنمای توسعه‌دهندگان و فرآیند مشارکت
- **[اطلاعات اپلیکیشن iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** و **[اطلاعات اپلیکیشن اندروید](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### نیاز به کمک دارید؟

- در بخش مسائل/بحث‌های گیت‌هاب پست بگذارید.
- برای پاسخ سریع‌تر و دریافت کمک از سایر اعضای جامعه **[به دیسکورد ما بپیوندید](https://discord.gg/vcnMT5cPEA)**

## تاریخچه ستاره‌ها

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="نمودار تاریخچه ستاره‌ها" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## ترجمه‌ها

**[ترجمه‌های Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="وضعیت ترجمه" />
</a>

## فعالیت مخزن

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "تصویر تحلیل Repobeats")

## مشارکت‌کنندگان

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ مشکلات شناخته‌شده / ویژگی‌های بتا ⚠️

SparkyFitness در حال توسعه فعال است.
تغییرات ناسازگار ممکن است بین نسخه‌ها رخ دهد.

- بروزرسانی خودکار کانتینرها توصیه نمی‌شود
- همواره یادداشت‌های انتشار را قبل از ارتقا بررسی کنید

ویژگی‌های زیر در حال حاضر در نسخه بتا هستند و ممکن است به طور کامل تست نشده باشند. انتظار وجود اشکال یا عملکرد ناقص را داشته باشید:

- چت‌بات هوش مصنوعی
- دسترسی خانواده و دوستان
- مستندات API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---