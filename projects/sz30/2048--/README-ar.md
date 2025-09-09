<div align="right">
  <details>
    <summary >🌐 لغات أخرى</summary>
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

نسخة محسّنة من لعبة 2048 الكلاسيكية، الآن مع ميزات أكثر للمتعة! هذا مشروع صغير أنجزته في وقت فراغي—آمل أن يجلب لك بعض المرح!

## 🎯 مقدمة اللعبة

2048 هي لعبة دمج أرقام بسيطة ولكنها تسبب الإدمان. على لوحة بحجم 4x4، اسحب للأعلى أو للأسفل أو لليسار أو لليمين لدمج البلاطات ذات الرقم نفسه. الهدف؟ الوصول إلى 2048 (لكن يمكنك الاستمرار لتحقيق درجات أعلى)!

**كيفية اللعب:**
- استخدم الأسهم أو مفاتيح WASD لتحريك البلاطات.
- عندما يصطدم بلاطان يحملان نفس الرقم، يندمجان ليصبحا بلاطة واحدة.
- بعد كل حركة، يظهر رقم 2 أو 4 جديد بشكل عشوائي في مكان فارغ.
- تنتهي اللعبة عندما لا يتبقى أي حركات ممكنة.

## ✨ الميزات الخاصة

### 1. وظيفة التراجع
- قمت بحركة خاطئة؟ لا تقلق!
- فقط اضغط على زر "التراجع" للعودة خطوة واحدة.
- يمكنك التراجع عدة مرات كما تشاء، حتى العودة للبداية.
- لا تدع انزلاق إصبعك يفسد لعبتك مرة أخرى!

### 2. وضع الغش السري
- أدخل التسلسل السحري: ←←→→ →→←← (يسار، يسار، يمين، يمين، يمين، يمين، يسار، يسار)
- ستتحول جميع البلاطات بشكل سحري إلى 128!
- إنه بيضة عيد الفصح، للمرح فقط.
- نصيحة احترافية: الغش ممتع، لكن لا تفرط فيه! 😉

## 🎯 العرض التجريبي

🎯 : [العب هنا](http://34.150.49.127:5000/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 هيكل المشروع
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
**وصف الملفات:**
- `2048.py`: خادم خلفي مكتوب باستخدام Flask، يتعامل مع منطق اللعبة وطلبات API.
- `script.js`: منطق اللعبة للواجهة الأمامية، يتضمن الحركات، والرسوم المتحركة، والميزات الخاصة.
- `styles.css`: أنماط اللعبة، لضمان مظهر جميل ومتجاوب.
- `index.html`: الصفحة الرئيسية التي تجمع كل شيء معًا.

## 🚀 البدء السريع

**الطريقة 1: تحميل الإصدار**
1. قم بتحميل أحدث إصدار.
2. تأكد من تثبيت Python 3.x على جهازك.
3. ثبّت التبعيات: `pip install flask`
4. شغّل: `python 2048.py`
5. افتح متصفحك واذهب إلى: [http://localhost:9969](http://localhost:9969)

**الطريقة 2: الاستنساخ من GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 التخصيص

هل ترغب في جعله خاصًا بك؟ قم بتعديل `styles.css` للحصول على مظهر جديد، أو استكشف `script.js` لتغيير طريقة اللعب. جميع الشيفرات مشروحة جيدًا لسهولة التعديل!

## 📝 الترخيص

ترخيص GPL-2.0

## 🤝 المساهمة

لا يزال يتم التحديث! المشاكل وطلبات السحب مرحب بها جدًا—لنُحسن هذه اللعبة سويًا!


## 🙏 الشكر والتقدير

شكرًا للرعاة التاليين لدعم هذا المشروع:
- [لا يوجد](https://#/) لتوفير الخادم
- [Serv00](https://www.serv00.com/) لتوفير الخادم

---
_آخر تحديث: أغسطس 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---