<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">

  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='برای من قهوه بخر در ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  یک مرورگر فایل ساده که به دلیل علاقه من به یادگیری زبان Rust ایجاد شد.
  <br>
  این برنامه مستقل از سیستم عامل بوده و برای بهینه‌سازی کوچک‌سازی شده است.
</p>

<br/><br/>

عملکرد این برنامه توسط ["jwalk"](https://crates.io/crates/jwalk/versions) و ["Tauri"](https://tauri.app/) فراهم شده است.
<br/><br/>
CoDriver برای دسترسی به فایل‌ها و پوشه‌ها از کش مسیر استفاده نمی‌کند و بنابراین عملکرد آن حاصل زبان Rust، سرعت دیسک و قدرت پردازنده است.

⁉️ توجه داشته باشید که این نرم‌افزار همچنان در حال توسعه است و ممکن است دارای باگ باشد!
<br/><br/>

# لینک‌ها
- <a href="#basic-features">ویژگی‌های پایه</a>
- <a href="#advanced-features">ویژگی‌های پیشرفته</a>
- <a href="#dependencies-if-not-working-instantly">پیش‌نیازها</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">پیاده‌سازی FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">مشکلات شناخته‌شده</a>
- <a href="#-todos">کارها</a>
- <a href="#user-interface">رابط کاربری</a>

## ویژگی‌های پایه
- مرور دایرکتوری‌ها به روشی که با آن آشنا هستید
- کپی و جای‌گذاری، حذف، ایجاد و تغییر نام فایل‌ها و پوشه‌ها
- جابجایی بین حالت‌های شبکه‌ای، لیستی و ستون‌های میلر
- بستن پنجره‌های بازشو با کلید esc
- پرش مستقیم به یک دایرکتوری با Ctrl / Cmd + G با وارد کردن مسیر
- مرتب‌سازی آیتم‌ها در حالت لیستی بر اساس اندازه، نام یا آخرین تغییر

## ویژگی‌های پیشرفته
- فشرده‌سازی فایل‌ها و پوشه‌ها
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- استخراج آرشیوها
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- رفتن به یک دایرکتوری با میانبر LAlt + 1 / 2 / 3 | (در مک‌او‌اس option + 1 / 2 / 3)
  - مسیرها را به دلخواه خود در تنظیمات پیکربندی کنید
- ایجاد فایل با F6
- ایجاد پوشه با F7
- نمای دو پنجره‌ای
  - جستجوی فایل‌ها با F8
  - کپی عنصر انتخاب شده فعلی به پنجره دیگر با F5
  - انتقال عنصر انتخاب شده فعلی به پنجره دیگر با LShift + F5
- کشیدن و رها کردن فایل‌ها به اکسپلورر برای کپی آن‌ها به دایرکتوری فعلی
- تغییر نام گروهی انتخاب‌ها با Ctrl / Cmd + LShift + M
  - اجرای تغییر نام گروهی با Ctrl / Cmd + Return
- پیش‌نمایش سریع فایل -> انتخاب ورودی دایرکتوری و زدن کلید فاصله.
  - فایل‌های پشتیبانی‌شده: همه فایل‌های تصویری (.jpg, .png, ...)، .pdf، .mp4، .json، .txt، .html
  - سایر آیتم‌ها یک کاشی کوچک با اطلاعاتی درباره آن نمایش می‌دهند. (مسیر، اندازه، آخرین تغییر)
- ناوبری فوری -> شروع به تایپ کنید و ورودی‌های دایرکتوری را به صورت خودکار فیلتر کنید تا گاهی <br/>
  بسیار سریع‌تر به مکان مورد نظر برسید

## وابستگی‌ها (در صورتی که بلافاصله کار نمی‌کند)

<details>
<summary>برای مشاهده گسترش دهید</summary>

### لینوکس

- openssl1.1

#### دبیان / اوبونتو
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### آرچ
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### فدورا
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ یکپارچه‌سازی FTP (sshfs)
<details>
  <summary>برای نمایش گسترش دهید</summary>
  <br/>
  وابستگی‌ها (باید به طور جداگانه نصب شوند):
  <br/>

  | macOS | لینوکس | ویندوز |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | هنوز **_پشتیبانی نمی‌شود_** |

  ### نصب:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### لینوکس
  ```
  sudo apt-get install sshfs
  ```
## 🏴‍☠️ پشتیبانی زبان
- انگلیسی
  - گزینه انتخاب بین زبان‌ها به زودی اضافه خواهد شد ...
</details>

## ⚠️ مشکلات شناخته‌شده:
- قابلیت کشیدن و رها کردن خارج از پنجره در لینوکس همیشه به درستی کار نمی‌کند
- در ویندوز ممکن است نیاز باشد [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) را نصب کنید
- سطح دسترسی‌ها در ویندوز کمی عجیب است
  - اگر هنگام کپی کردن عناصر یا کارهای مشابه با مشکل مواجه شدید، ممکن است نیاز باشد برنامه را به عنوان مدیر اجرا کنید
- ممکن است نیاز باشد openssl1.1 را در سیستم‌های لینوکس نصب کنید، اگر برنامه اجرا نشود

## 📝 کارهای باقی‌مانده:
- چندزبانه شدن
- موارد مورد علاقه
- دسترسی به سرویس‌های ذخیره‌سازی آنلاین (گوگل درایو و غیره)

## رابط کاربری

### سبک لیستی
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### سبک شبکه‌ای
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### نمای ستون میلر
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### نمای دو پنجره‌ای
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## نحوه مشارکت
برای توسعه برنامه‌های tauri نسخه ۱ دستگاه خود را آماده کنید: [پیش‌نیازهای Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
وقتی این کار انجام شد کافیست دستور ```git clone https://github.com/RickyDane/CoDriver``` یا ```gh repo clone RickyDane/CoDriver``` را در مکانی روی دستگاه خود اجرا کنید.
</br></br>
باید بتوانید با اجرای دستور ```cargo tauri dev``` در شاخه اصلی این پروژه، شروع به ساخت و اجرای CoDriver کنید.
</br>
حتماً tauri-cli را نصب داشته باشید: ```cargo install tauri-cli```

</br>

## امضای نسخه نهایی

آرتیفکت‌های نسخه نهایی macOS باید امضا و تأیید شوند تا از گزارش Gatekeeper مبنی بر آسیب‌دیده بودن برنامه نصب‌شده جلوگیری شود. برای اطلاعات بیشتر درباره اسرار GitHub Actions مورد نیاز و دستورات تأیید، به [امضا و تأیید macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) مراجعه کنید.

## تاریخچه ستاره‌ها

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### سایر نرم‌افزارهای شخص ثالث
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---