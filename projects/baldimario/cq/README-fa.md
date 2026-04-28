<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - موتور کوئری SQL با عملکرد بالا برای فایل‌های CSV

 [![ساخت و تست متقابل (با سیستم ساخت zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

یک پردازشگر کوئری SQL سبک و سریع که به زبان C نوشته شده و اجرای کوئری‌های SQL را مستقیماً بر روی فایل‌های CSV بدون نیاز به پایگاه داده امکان‌پذیر می‌کند. برای مستندات کامل، به پوشه /doc مراجعه کنید.

 ![cq در حال اجرا](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## مستندات

- شروع کار: `doc/GettingStarted.md`
- نصب: `doc/Installation.md`
- رابط خط فرمان: `doc/CLI.md`
- **رابط کاربری ترمینال (TUI)**: `doc/TUI.md`
- معماری: `doc/Architecture.md`
- تست: `doc/Testing.md`
- نقشه راه: `doc/Roadmap.md`
- مشارکت: `doc/Contributing.md`

## شروع سریع

ساخت: `make`

### خط فرمان

اجرای یک نمونه پرس و جو:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### رابط کاربری ترمینال

اجرای رابط تعاملی TUI:
`./build/cqtui data/`

ویژگی‌ها:
- مرور و باز کردن فایل‌های CSV به عنوان جدول
- اجرای پرس و جوهای SQL به صورت تعاملی
- رابط چندزبانه برای جداول متعدد
- پیمایش مبتنی بر صفحه کلید
- بدون وابستگی خارجی

## فایل‌های نمونه SQL

مخزن شامل نمونه‌هایی از SQL در assets/ است (example_between.sql، example_aggregation.sql و غیره). برای جزئیات به assets/ مراجعه کنید.

## نمای کلی داده و ویژگی‌ها

- برای بخش‌های دقیق‌تر درباره انواع داده، فرمت‌های تاریخ، فرمت CSV و موارد دیگر، پوشه /doc را ببینید.

## مجوز

مجوز MIT. برای جزئیات به فایل LICENSE مراجعه کنید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---