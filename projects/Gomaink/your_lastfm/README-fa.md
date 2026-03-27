<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![وضعیت](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![مجوز](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# لست‌اف‌ام شما

یک برنامه Node.js کانتینری‌شده که scrobbleهای **Last.fm** را همگام‌سازی می‌کند، آن‌ها را در یک پایگاه داده **SQLite** محلی ذخیره کرده و یک داشبورد وب ارائه می‌دهد.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## پروژه

**Your LastFM** یک اپلیکیشن Node.js است که برای **هماهنگ‌سازی خودکار اسکرابل‌های موسیقی** از Last.fm طراحی شده است. این برنامه تاریخچه شنیداری شما را در یک پایگاه داده محلی SQLite ذخیره کرده و رابط وبی برای نمایش داده‌ها ارائه می‌دهد.

پروژه به طور کامل با **Docker** کانتینرایز شده است و از یک ورودی خودکار برای مدیریت اولیه‌سازی پایگاه داده و اجرای ترتیبی استفاده می‌کند (ابتدا همگام‌سازی، سپس راه‌اندازی Web API). همچنین از **PM2** به عنوان مدیر فرآیند داخل کانتینر بهره می‌برد تا سرویس وب فعال و مقاوم باقی بماند.

## ویژگی‌ها
### داشبورد وب تعاملی

- رابط وب تمیز و مدرن برای نمایش فعالیت موسیقی شما.

### همگام‌سازی خودکار اسکرابل‌های Last.fm

- به طور دوره‌ای تاریخچه شنیداری شما (اسکرابل‌ها) را از Last.fm دریافت و ذخیره می‌کند.
- داده‌های شما همیشه بدون دخالت دستی به روز می‌ماند.

### پایگاه داده محلی تاریخچه موسیقی

- تمامی اسکرابل‌ها را در پایگاه داده محلی SQLite ذخیره می‌کند.
- امکان پرس‌وجوی سریع و دسترسی آفلاین به داده‌های شنیداری تاریخی را فراهم می‌کند.

### نمایش اسکرابل‌های اخیر

- جدیدترین ترک‌های شما را نمایش می‌دهد.
- منطق هوشمند جایگزینی تصویر برای ترک‌ها، آلبوم‌ها و هنرمندان.

### مقایسه دوستان (نمای سازگاری)

- سلیقه موسیقی خود را با دوستان Last.fm مقایسه کنید.
- سطح سازگاری را نمایش می‌دهد (بسیار کم → فوق‌العاده).
- هنرمندان، آلبوم‌ها و ترک‌های مشترک برتر را نشان می‌دهد.
- سازگاری را بر اساس داده‌های واقعی شنیداری محاسبه و نرمال‌سازی می‌کند.

### کارت‌های موسیقی قابل اشتراک‌گذاری

- تصاویر پویا بر اساس داده‌های شنیداری شما ایجاد می‌کند.
- چیدمان‌های بهینه برای پست‌های فید و استوری‌های اینستاگرام (۹:۱۶)

- ساخته شده با استفاده از node-canvas برای رندرینگ تصویر در سمت سرور.

## پیش‌نیازها

* [داکر](https://docs.docker.com/get-docker/)
* [داکر کامپوز](https://docs.docker.com/compose/install/)

## نصب

### ایجاد یک فایل `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: یک حساب کاربری API را [اینجا](https://www.last.fm/api/account/create) ایجاد کنید تا کلید API خود را دریافت کنید.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

در ترمینال:
`docker compose up -d`

سپس دسترسی:
```
http://localhost:1533
```
(یا به جای `localhost`، آی‌پی سرور خود را وارد کنید)

## مجوز

این پروژه تحت مجوز MIT منتشر شده است.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---