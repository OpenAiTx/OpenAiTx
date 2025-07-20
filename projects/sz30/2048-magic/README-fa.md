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


[انگلیسی](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

نسخه‌ای ارتقا یافته از بازی کلاسیک 2048، اکنون با ویژگی‌های سرگرم‌کننده بیشتر! این پروژه کوچکی است که در اوقات فراغتم ساختم—امیدوارم برایتان لذت‌بخش باشد!

## 🎯 معرفی بازی

2048 یک بازی ساده اما اعتیادآور در ادغام اعداد است. روی یک جدول ۴x۴، بالا، پایین، چپ یا راست بکشید تا کاشی‌هایی با اعداد برابر را با هم ترکیب کنید. هدف؟ رسیدن به 2048 (البته می‌توانید برای امتیازات بالاتر هم ادامه دهید)!

**چگونه بازی کنیم:**
- از کلیدهای جهت‌نما یا WASD برای حرکت دادن کاشی‌ها استفاده کنید.
- وقتی دو کاشی با عدد یکسان به هم برخورد کنند، با هم ترکیب می‌شوند.
- پس از هر حرکت، یک عدد ۲ یا ۴ به صورت تصادفی در یک خانه خالی ظاهر می‌شود.
- بازی زمانی به پایان می‌رسد که دیگر حرکتی باقی نمانده باشد.

## ✨ ویژگی‌های خاص

### ۱. قابلیت بازگردانی حرکت (Undo)
- حرکت اشتباهی کردید؟ نگران نباشید!
- کافی است روی دکمه "بازگردانی" کلیک کنید تا یک مرحله به عقب برگردید.
- می‌توانید هرچقدر خواستید، تا ابتدای بازی بازگردانی انجام دهید.
- دیگر اجازه ندهید یک اشتباه کوچک بازی شما را خراب کند!

### ۲. حالت تقلب مخفی
- دنباله جادویی را وارد کنید: ←←→→ →→←← (چپ، چپ، راست، راست، راست، راست، چپ، چپ)
- همه کاشی‌ها به طور جادویی به عدد 128 تبدیل می‌شوند!
- این یک ایستر اگ است و فقط جنبه سرگرمی دارد.
- نکته حرفه‌ای: تقلب کردن سرگرم‌کننده است، اما زیاده‌روی نکنید! 😉

## 🎯 نسخه نمایشی

🎯 اینجا بازی کنید: [2048.765431.xyz](https://2048.765431.xyz/)
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

می‌خواهید آن را مخصوص خودتان کنید؟ فایل `styles.css` را برای ظاهری جدید تغییر دهید یا وارد `script.js` شوید تا گیم‌پلی را تغییر دهید. تمام کدها به‌خوبی توضیح داده شده‌اند تا به راحتی بتوانید آن‌ها را دست‌کاری کنید!

## 📝 مجوز

مجوز GPL-2.0

## 🤝 مشارکت

هنوز در حال به‌روزرسانی است! ارسال Issues و Pull Request ها بسیار خوشایند است—بیایید این بازی را با هم حتی جذاب‌تر کنیم!


## 🙏 قدردانی

از حامیان زیر برای حمایت از این پروژه تشکر می‌شود:
- [IDC.REST](https://idc.rest/) ارائه‌دهنده سرور
- [Serv00](https://www.serv00.com/) ارائه‌دهنده سرور

---
_آخرین به‌روزرسانی: ژوئن ۲۰۲۵_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---