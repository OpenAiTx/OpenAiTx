<div align="right">
  <details>
    <summary >🌐 سایر زبان‌ها</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

نسخه‌ی پیشرفته‌ای از بازی کلاسیک 2048، با ویژگی‌های سرگرم‌کننده‌ی بیشتر! این پروژه کوچکی است که در اوقات فراغتم ساختم—امیدوارم برایتان لذت‌بخش باشد!

## 🎯 معرفی بازی

2048 یک بازی ساده اما اعتیادآور برای ترکیب اعداد است. در یک شبکه‌ی ۴×۴، با کشیدن به بالا، پایین، چپ یا راست، خانه‌هایی با عدد یکسان را ترکیب کنید. هدف؟ رسیدن به 2048 (البته می‌توانید برای امتیاز بیشتر هم ادامه دهید)!

**نحوه بازی:**
- با کلیدهای جهت یا WASD خانه‌ها را حرکت دهید.
- وقتی دو کاشی با عدد یکسان برخورد کنند، آن‌ها با هم ترکیب شده و یکی می‌شوند.
- پس از هر حرکت، یک عدد ۲ یا ۴ به طور تصادفی در یک جای خالی ظاهر می‌شود.
- بازی زمانی تمام می‌شود که هیچ حرکت دیگری باقی نمانده باشد.

## ✨ ویژگی‌های خاص

### ۱. قابلیت بازگشت (Undo)
- حرکت اشتباهی انجام دادی؟ نگران نباش!
- فقط کافیست دکمه "بازگشت" را فشار دهی تا یک مرحله عقب بروی.
- هر چند بار که بخواهی می‌توانی بازگردی، تا ابتدای بازی.
- دیگر اجازه نده یک اشتباه کوچک بازی‌ات را خراب کند!

### ۲. حالت تقلب مخفی
- رشته جادویی را وارد کن: ←←→→ →→←← (چپ، چپ، راست، راست، راست، راست، چپ، چپ)
- همه کاشی‌ها به طور جادویی تبدیل به ۱۲۸ می‌شوند!
- این یک ایستر اگ است، فقط برای سرگرمی.
- نکته حرفه‌ای: تقلب کردن جالب است، اما زیاده‌روی نکن! 😉

## 🎯 دمو

🎯 : [اینجا بازی کن](http://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 ساختار پروژه
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**توضیحات فایل‌ها:**
- `2048.py`: سرور بک‌اند نوشته شده با Flask که منطق بازی و درخواست‌های API را مدیریت می‌کند.
- `script.js`: منطق بازی در فرانت‌اند، شامل حرکات، انیمیشن‌ها و ویژگی‌های ویژه.
- `styles.css`: استایل‌های بازی برای اطمینان از ظاهر مناسب و واکنش‌گرا بودن.
- `index.html`: صفحه اصلی که همه چیز را به هم متصل می‌کند.

## 🚀 شروع به کار

**روش اول: دانلود نسخه نهایی**
1. آخرین نسخه را دانلود کنید.
2. اطمینان حاصل کنید که Python 3.x نصب شده باشد.
3. وابستگی‌ها را نصب کنید: `pip install flask`
4. اجرا کنید: `python 2048.py`
5. مرورگر خود را باز کنید و به این آدرس بروید: [http://localhost:9969](http://localhost:9969)

**روش دوم: کلون از گیت‌هاب**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 سفارشی‌سازی

می‌خواهید آن را شخصی‌سازی کنید؟ فایل `styles.css` را برای ظاهر جدید تغییر دهید، یا وارد `script.js` شوید تا گیم‌پلی را تغییر دهید. تمام کدها با توضیحات مناسب برای راحتی ویرایش ارائه شده‌اند!

## 📝 مجوز

مجوز GPL-2.0

## 🤝 مشارکت

همچنان در حال به‌روزرسانی! گزارش مشکلات و Pull Requestها بسیار خوش‌آمد هستند—بیایید با هم این بازی را حتی بهتر کنیم!

## 🙏 تقدیر و تشکر

سپاس از حامیان زیر برای حمایت از این پروژه:
- [Aurora Cloud](https://www.free-vps.net/) ارائه‌دهنده سرور

---
_آخرین به‌روزرسانی: اکتبر ۲۰۲۵_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---