<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ناتی [![وضعیت ترجمه](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![وضعیت ساخت](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![وضعیت اسنپ](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![حمایت مالی](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
یک ابزار شبکه

نویسنده: سیدارتا داس

یک برنامه ساده که برای سیستم‌عامل المنتری طراحی شده تا اطلاعات ضروری درباره جنبه‌های مربوط به شبکه ارائه دهد. اطلاعات در تب‌های زیر ارائه می‌شوند.<br>
1. اطلاعات من: اطلاعات پایه و جزئیات کارت شبکه دستگاه را نمایش می‌دهد<br>
2. میزان مصرف: میزان مصرف داده شبکه را در دو نما - مصرف تاریخی و مصرف فعلی ارائه می‌دهد<br>

۳. سرعت: سرعت‌های بارگذاری و دانلود را بررسی کنید و زمان‌های مسیر به یک میزبان را دریافت کنید<br>
۴. پورت‌ها: اطلاعاتی درباره پورت‌های فعال و برنامه‌هایی که روی دستگاه محلی از آن‌ها استفاده می‌کنند ارائه می‌دهد<br>
۵. دستگاه‌ها: دستگاه‌های دیگر متصل به شبکه را نظارت، هشدار و اطلاعاتی درباره آن‌ها ارائه می‌دهد<br>

برای جزئیات بیشتر درباره ویژگی‌ها، میانبرها، راهنماهای نصب برای اوبونتو و سایر توزیع‌های پشتیبانی شده و غیره، به وب‌سایت Nutty مراجعه کنید: <br>
https://babluboy.github.io/nutty/

## ساخت، تست و نصب از سورس

برای ساخت به وابستگی‌های زیر نیاز دارید:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

و برای اجرا به این وابستگی‌ها نیاز است:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

گاهی vnstat پس از نصب راه‌اندازی نمی‌شود، از دستور مناسب برای سیستم init خود برای راه‌اندازی سرویس vnstat استفاده کنید مانند: `sudo systemctl enable vnstat`

برای پیکربندی محیط ساخت دستور `meson build` را اجرا کنید و برای ساخت، دستور `ninja test` را اجرا نمایید

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
برای نصب، از دستور `sudo ninja install` استفاده کنید، سپس با دستور `com.github.babluboy.nutty` اجرا نمایید.


```
sudo ninja install
com.github.babluboy.nutty
```
برای حذف نصب، به پوشه ساخت بروید و اجرا کنید

```
sudo ninja uninstall
```

### نصب از بسته Deb

برای نصب Nutty از بسته `.deb`، مطمئن شوید که همه وابستگی‌های اجرایی ذکر شده در بالا را نصب کرده‌اید (نیازی به وابستگی‌های ساخت نیست). سپس دستور زیر را اجرا کنید
```bash
sudo dpkg -i <deb-package-name>.deb
```
و برای حذف Nutty که از طریق بسته `.deb` نصب شده است اجرا کنید

```bash
sudo apt autoremove com.github.babluboy.nutty
```
اگر می‌خواهید بسته `.deb` مربوط به Nutty را مستقیماً خودتان بسازید، وابستگی‌های ساخت ذکر شده در بالا را نصب کرده و سپس اجرا کنید

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---