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
- قابلیت کشیدن و رها کردن خارج از پنجره در لینوکس همیشه کار نمی‌کند
- در ویندوز ممکن است نیاز داشته باشید [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) را نصب کنید
- مجوزها در سیستم عامل ms-windows کمی عجیب هستند
  - اگر با مشکلاتی در کپی عناصر یا موارد مشابه مواجه شدید، ممکن است نیاز باشد برنامه را به صورت مدیر اجرا کنید
- ممکن است نیاز باشد openssl1.1 را روی سیستم‌های لینوکس نصب کنید، وقتی برنامه اجرا نمی‌شود

## 📝 کارهای باقی‌مانده:
- زبان‌های متعدد
- علاقه‌مندی‌ها
- دسترسی به خدمات ذخیره‌سازی آنلاین (گوگل درایو و غیره)

## رابط کاربری
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## نحوه مشارکت
ماشین خود را برای توسعه برنامه‌های tauri v1 آماده کنید: [پیش‌نیازهای توری](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
وقتی این کار انجام شد کافیست دستور ```git clone https://github.com/RickyDane/CoDriver``` یا ```gh repo clone RickyDane/CoDriver``` را در محل مورد نظر روی ماشین خود اجرا کنید.
</br></br>
باید بتوانید دستور ```cargo tauri dev``` را در دایرکتوری اصلی پروژه اجرا کنید تا شروع به ساخت و اجرای CoDriver کنید.
</br>
اطمینان حاصل کنید که tauri-cli نصب شده باشد: ```cargo install tauri-cli```
</br>

## امضای انتشار

آرتیفکت‌های انتشار macOS باید امضا و نوتارایز شوند تا Gatekeeper گزارش ندهد که برنامه نصب شده آسیب‌دیده است. برای اطلاعات بیشتر، [امضا و نوتارایز macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) را ببینید که شامل رازهای لازم برای GitHub Actions و فرمان‌های تأیید است.

## تاریخچه ستاره‌ها

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="نمودار تاریخچه ستاره‌ها" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### سایر نرم‌افزارهای شخص ثالث
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---