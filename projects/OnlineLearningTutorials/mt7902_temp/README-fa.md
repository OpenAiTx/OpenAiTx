<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">آسامی</a></
      </div>
    </div>
  </details>
</div>

# 🎯 درایور MT7902 به عنوان زیرمجموعه‌ای از درایور MT7921 (✅ قابل استفاده)
تراشه وای‌فای 6E مدیاتک mt7902 با پشتیبانی از بلوتوث و وای‌فای

> [!مهم]
> هسته لینوکس نسخه 7.1 به صورت رسمی از تراشه وای‌فای 6E مدل MT7902 پشتیبانی می‌کند


## 📁 کلون کردن مخزن

مخزن را به رایانه محلی خود کلون کنید
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
اگر نمی‌خواهید تاریخچه گذشته را کلون کنید، آنگاه
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## نصب


### 🚀 اسکریپت راهنمای نصب (توصیه‌شده برای سیستم‌های مبتنی بر اوبونتو)
اگر اسکریپت هنوز اجرایی نیست، آن را اجرایی کنید
```
chmod +x ./install_guide.sh
```
اکنون این اسکریپت را اجرا کنید
```
./install_guide.sh
```
در صورت نیاز به طور خودکار رمز عبور را درخواست خواهد کرد
* این اسکریپت از شما می‌خواهد که فریمور، درایور بلوتوث و وای‌فای را یکی یکی نصب کنید
* روی اوبونتو با هسته لینوکس ۷.۰ تست شده است

### 🚀 رفع خودکار آسان (توصیه‌شده برای سیستم‌های مبتنی بر آرچ)
اگر می‌خواهید وای‌فای و بلوتوث خود را روی هر هسته مدرن به سرعت رفع کنید، این مراحل را دنبال کنید:

در صورتی که اسکریپت قبلاً اجرایی نیست، آن را اجرایی کنید
```
chmod +x ./fix_my_wifi.sh
```

**اسکریپت رفع خودکار را اجرا کنید** با استفاده از sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 این اسکریپت چه کاری انجام می‌دهد:
* **بررسی وابستگی‌ها:** اطمینان حاصل می‌کند که `gcc`/`clang`، `make`، `bc` و `kernel-headers` فعلی شما نصب شده باشد. در صورت عدم وجود - با مدیر بسته مورد علاقه شما نصب می‌کند.
* **کامپایل درایورها:** به طور خودکار هر دو درایور WiFi و Bluetooth را برای نسخه دقیق هسته شما می‌سازد.
* **رفع ماندگار:** یک سرویس سیستمی نصب می‌کند که اطمینان می‌دهد WiFi شما حتی پس از راه‌اندازی مجدد کامپیوتر فعال باقی بماند.
* **ایمنی:** ماژول‌ها را در یک پوشه سفارشی (`/lib/modules/mt7902_custom`) نصب می‌کند تا از دستکاری فایل‌های پیش‌فرض سیستم جلوگیری شود.

> [!NOTE]
> در اولین اجرا برای دانلود ابزارهای مورد نیاز ساخت (مانند کامپایلر، linux-headers و غیره) به اتصال اینترنت (از طریق اترنت یا اشتراک‌گذاری USB از گوشی) نیاز خواهید داشت.


## ✅ تست شده بر روی (تأیید شده)
این راه‌حل بررسی شده و تأیید شده که روی موارد زیر کار می‌کند:

* **برند:** ایسوس
* **مدل:** Vivobook Go (E1404FA)، Vivobook 14 (X1404ZA)
* **چیپست:** MediaTek MT7902 (WiFi 6E)
* **نسخه هسته:** 6.19.0 (لینوکس)، 6.19.11، 7.0.7
* **سیستم‌عامل‌ها:** آرچ، اوبونتو
* **مدیر بسته:** pacman، apt

## موجود برای:
* **سیستم‌عامل:** هر سیستمی که یکی از مدیرهای بسته را پشتیبانی کند
* **مدیر بسته مورد علاقه:** apt، pacman، dnf، zypper، nix-shell
* **نسخه‌های هسته:** 6.14-7.0.7


## 🔧 فریمورهای استفاده‌شده
فریمورها در پوشه `firmware` ذخیره شده‌اند.


## 📱 بلوتوث ✅ (فعال)
> [!WARNING]
> اگر درایور بلوتوث با `gen4-mt7902` تداخل دارد لطفاً فریمور بلوتوث را حذف کنید تا با این درایور تداخل نداشته باشد
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> این پروژه از فریمور زیر استفاده می‌کند
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

برای فعال‌سازی بلوتوث به پوشه نسخه فعلی هسته خود بروید. ``
مثلاً اگر هسته linux-6.16 دارید به پوشه `./linux-6.16/drivers/bluetooth` بروید.
ترمینال را در این پوشه باز کنید و با دستور `make` کامپایل کنید.
دو ماژول هسته کامپایل می‌شوند: `btusb.ko` و `btmtk.ko`.
برای فعال‌سازی بلوتوث در دستگاه خود، btusb و btmtk موجود در سیستم را حذف و این دو فایل را نصب کنید، از دستورات زیر استفاده نمایید.
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
اکنون بررسی کنید که بلوتوث شما کار می‌کند یا نه.

## 💻 وای‌فای ✅ (در حال کار)
> [!مهم]
> یک ریپوی قابل استفاده با برخی محدودیت‌ها [اینجا](https://github.com/hmtheboy154/gen4-mt7902) قرار دارد

درایور وای‌فای برای mt7902 که اخیراً توسط مدیاتک منتشر شده، داخل پوشه `latest` قرار دارد.

اگر از اوبونتو استفاده می‌کنید، کافیست به پوشه `latest` بروید و دستور زیر را در ترمینال اجرا کنید.
```
make
```
این همه ماژول‌ها را کامپایل، فشرده و نصب می‌کند (ماژول کرنل اصلی را با ماژول تغییر یافته جایگزین می‌کند). اگر از توزیع دیگری استفاده می‌کنید یا نمی‌خواهید همه مراحل را انجام دهید و فقط می‌خواهید کد را کامپایل کنید، در ترمینال اجرا کنید

```
make module_compile
```
برای فشرده‌سازی ماژولی که کامپایل کرده‌اید، سپس در ترمینال اجرا کنید
```
make module_compress
```
برای نصب ماژول فشرده‌شده به ماژول هسته سیستم، در ترمینال اجرا کنید
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---