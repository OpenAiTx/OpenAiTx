<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### رابط گرافیکی Wine با استفاده از Zenity - بازی کن و به اشتراک بگذار!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='دریافت از Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)


## WineZGUI چیست

WineZGUI (تلفظ: واین-زی-گو-ای) یک رابط گرافیکی برای wine است که اجرای بازی‌های ویندوز با wine را آسان می‌کند. این نرم‌افزار مجموعه‌ای از اسکریپت‌های Bash برای مدیریت پیشوندهای wine و یکپارچه‌سازی با دسکتاپ لینوکس است تا تجربه بازی با wine را از طریق Zenity راحت‌تر کند. این ابزار امکان اجرای سریع فایل‌های EXE (بدون نیاز به نصب) یا بازی‌ها را مستقیماً از مدیر فایل مانند Nautilus فراهم می‌کند و اجازه می‌دهد برای هر فایل باینری EXE ویندوز یک پیشوند wine جداگانه بسازید.

## چرا WineZGUI؟

1. اجرای بازی‌ها یا فایل‌های exe ویندوز از طریق مدیر فایل
2. ایجاد میانبر برنامه برای دسترسی آسان‌تر.
3. تمرکز بر اجرای بازی به‌جای پیکربندی پیشوندها.
4. پشتیبان‌گیری و بازیابی پیشوندها برای استفاده بعدی.
5. ایجاد بسته بازی برای اشتراک‌گذاری (پیشوند+بازی)

## نحوه عملکرد

1. وقتی یک فایل باینری یا exe ویندوز با WineZGUI باز می‌شود،
2. یک پیشوند جدید (کپی از الگو) و یک میانبر دسکتاپ با نام فایل EXE ایجاد می‌کند.
3. وقتی کاربر اسکریپت را اجرا می‌کند، فایل exe اجرا می‌شود.
4. اگر این فایل یک برنامه نصب باشد، exe نصب‌شده را شناسایی کرده و میانبرهایی در منوی بازی‌ها ایجاد می‌کند.

## چگونه یک بازی یا برنامه را روی درایو یا مسیر دیگر اجرا کنیم

ترمینال خود را باز کرده و این دستور را وارد کنید:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### نصب WineZGUI

WineZGUI به صورت Flatpak در Flathub موجود است:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


نسخه Flathub از WineZGUI فقط به پوشه‌های Desktop، Documents، Downloads، Music، Pictures، Videos دسترسی دارد. برای دسترسی به فایل‌ها از مسیرهای دیگر یا پارتیشن/درایوهای متصل دیگر، باید آن‌ها را به مسیرهای نامبرده (مانند Downloads) کپی کنید یا مجوز خواندن بدهید که می‌توان از برنامه Flatseal یا با دستور خط فرمان  `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` این کار را انجام داد.

استفاده از نسخه flatpak توصیه می‌شود، چرا که نسخه wine مبتنی بر توزیع (wine-staging) مرتب به‌روزرسانی می‌شود و ممکن است بازی‌ها هر چند روز یک‌بار دچار مشکل شوند. استفاده از wine پایدار از flathub یا نسخه‌های پایدار ۵.۰ یا ۷.۰ از مخازن توزیع بهتر است.

#### نصب WineZGUI flatpak روی [توزیع‌های پشتیبانی‌شده لینوکس](https://flatpak.org/setup/)

WineZGUI توسط خودم در flatpak-wine بسته‌بندی شده است. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) و flatpak دیگر من که اکنون منسوخ شده است [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### راه‌اندازی روی سیستم لینوکس، به [نیازمندی‌ها](https://github.com/fastrizwaan/WineZGUI#requirements) مراجعه کنید

راه‌اندازی فوری است و فقط چند فایل به پوشه‌های خاص کپی می‌شود.

##### نسخه ۰.۹۹.۱۳

سورس را از [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) دانلود کنید یا از `git tag 0.99.13` استفاده کنید

##### استفاده از tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### نسخه توسعه

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### حذف WineZGUI

##### حذف Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### حذف سیستم

دستور `uninstall` را از همان دایرکتوری منبع نصب اجرا کنید

```
sudo ./setup --uninstall
```

## نیازمندی‌ها

`wine` - برنامه اصلی

`winetricks` - اسکریپت افزودنی ضروری برای wine

`perl‑image‑exiftool` - برای استخراج نام برنامه/بازی

`icoutils` - برای استخراج آیکون از فایل exe

`gnome-terminal` - (اختیاری) برای دسترسی به دایرکتوری پیشوند در شل

## نصب نیازمندی‌ها برای سیستم عامل لینوکس

### توزیع‌های پشتیبانی‌کننده از Flatpak

[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) را دریافت کنید که شامل تمام وابستگی‌ها است. مناسب برای توزیع‌هایی که wine را بسته‌بندی نکرده‌اند.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## وابستگی‌های زمان اجرا:

### فدورا ۳۶

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### دبیان / اوبونتو / لینوکس مینت

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### سولوس

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### آرچ لینوکس / اندوروسOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### کنترلرهای سازگار با XBOX

درایورهای هسته‌ای کنترلرهای سازگار با ایکس‌باکس ۳۶۰ را از https://github.com/paroj/xpad بسازید و نصب کنید


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---