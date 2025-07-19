<div align="right">
  <details>
    <summary >🌐 زبان‌های دیگر</summary>
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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

نسخه‌ای پیشرفته از بازی کلاسیک 2048، حالا با امکانات سرگرم‌کننده‌تر! این پروژه‌ای کوچک است که در اوقات فراغت ساخته‌ام—امیدوارم برایتان لذت‌بخش باشد!

## 🎯 معرفی بازی

2048 یک بازی ساده اما اعتیادآور در زمینه ادغام اعداد است. روی یک شبکه ۴×۴، با کشیدن به بالا، پایین، چپ یا راست کاشی‌هایی با عدد یکسان را با هم ادغام کنید. هدف؟ رسیدن به 2048 (ولی می‌توانید برای امتیازهای بالاتر هم ادامه دهید)!

**نحوه بازی:**
- با کلیدهای جهت‌نما یا WASD کاشی‌ها را حرکت دهید.
- وقتی دو کاشی با عدد یکسان به هم برخورد کنند، با هم ادغام می‌شوند.
- بعد از هر حرکت، یک ۲ یا ۴ جدید به طور تصادفی در یک خانه خالی ظاهر می‌شود.
- بازی زمانی تمام می‌شود که دیگر هیچ حرکتی امکان‌پذیر نباشد.

## ✨ امکانات ویژه

### ۱. امکان بازگشت (Undo)
- حرکت اشتباهی انجام دادید؟ نگران نباشید!
- فقط دکمه "بازگشت" را بزنید تا یک مرحله عقب بروید.
- می‌توانید هر چند بار که خواستید تا ابتدای بازی به عقب برگردید.
- دیگر اجازه ندهید یک لغزش کوچک بازی شما را خراب کند!

### ۲. حالت تقلب مخفی
- دنباله جادویی را وارد کنید: ←←→→ →→←← (چپ، چپ، راست، راست، راست، راست، چپ، چپ)
- تمام کاشی‌ها به طور جادویی به ۱۲۸ تبدیل می‌شوند!
- این یک ایستر اگ است، فقط برای سرگرمی.
- نکته حرفه‌ای: تقلب سرگرم‌کننده است، اما زیاده‌روی نکنید! 😉

## 🎯 دموی بازی

🎯 اینجا بازی کنید: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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
- `styles.css`: استایل‌های بازی که باعث می‌شود همه چیز زیبا و واکنش‌گرا باشد.
- `index.html`: صفحه اصلی که همه چیز را کنار هم قرار می‌دهد.

## 🚀 شروع سریع

**روش اول: دانلود نسخه انتشار یافته**
1. آخرین نسخه را دانلود کنید.
2. اطمینان حاصل کنید که Python 3.x را نصب کرده‌اید.
3. وابستگی‌ها را نصب کنید: `pip install flask`
4. اجرا کنید: `python 2048.py`
5. مرورگر خود را باز کنید و به این آدرس بروید: [http://localhost:9969](http://localhost:9969)

**روش دوم: کلون کردن از گیت‌هاب**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 سفارشی‌سازی

می‌خواهید آن را مال خود کنید؟ فایل `styles.css` را برای ظاهری جدید تغییر دهید، یا به سراغ `script.js` بروید تا گیم‌پلی را عوض کنید. تمام کدها به خوبی توضیح داده شده‌اند تا راحت‌تر تغییرشان دهید!

## 📝 مجوز

مجوز GPL-2.0

## 🤝 مشارکت

هنوز در حال به‌روزرسانی! ارسال Issue و Pull Request بسیار خوشایند است—بیایید با هم این بازی را حتی بهتر کنیم!


## 🙏 تقدیر و تشکر

از اسپانسرهای زیر برای حمایت از این پروژه تشکر می‌کنیم:
- [Serv00](https://www.serv00.com/) که سرور را فراهم می‌کند

---
_آخرین به‌روزرسانی: ژوئن ۲۰۲۵_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---