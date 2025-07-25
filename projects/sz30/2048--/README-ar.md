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

نسخة محسنة من لعبة 2048 الكلاسيكية، مع المزيد من الميزات الممتعة! هذا مشروع صغير قمت بإعداده في أوقات فراغي—آمل أن يجلب لك بعض المرح!

## 🎯 مقدمة اللعبة

2048 هي لعبة دمج أرقام بسيطة لكنها تسبب الإدمان. على شبكة 4×4، اسحب للأعلى أو للأسفل أو لليسار أو لليمين لدمج البلاطات ذات الأرقام المتشابهة. الهدف؟ الوصول إلى 2048 (ولكن يمكنك الاستمرار للحصول على درجات أعلى)!

**كيفية اللعب:**
- استخدم مفاتيح الأسهم أو WASD لتحريك البلاطات.
- عند تصادم بلاطتين لهما نفس الرقم، تندمجان في بلاطة واحدة.
- بعد كل حركة، تظهر 2 أو 4 جديدة بشكل عشوائي في مكان فارغ.
- تنتهي اللعبة عندما لا يتبقى أي حركات ممكنة.

## ✨ ميزات خاصة

### 1. وظيفة التراجع
- قمت بحركة خاطئة؟ لا تقلق!
- فقط اضغط على زر "تراجع" للرجوع خطوة واحدة.
- يمكنك التراجع بعدد غير محدود من المرات، حتى العودة للبداية.
- لا تدع زلة إصبع تفسد لعبتك مرة أخرى!

### 2. وضع الغش السري
- أدخل تسلسل السحر: ←←→→ →→←← (يسار، يسار، يمين، يمين، يمين، يمين، يسار، يسار)
- ستتحول جميع البلاطات سحريًا إلى 128!
- إنها بيضة عيد الفصح، فقط للمتعة.
- نصيحة: الغش ممتع، لكن لا تفرط فيه! 😉

## 🎯 العرض التجريبي

🎯 العب هنا: [2048.765431.xyz](https://2048.765431.xyz/)
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

هل تريد جعله خاصًا بك؟ قم بتعديل `styles.css` للحصول على مظهر جديد، أو استكشف `script.js` لتغيير طريقة اللعب. جميع الشيفرة مشروحة جيدًا لسهولة التعديل!

## 📝 الترخيص

رخصة GPL-2.0

## 🤝 المساهمة

لا تزال التحديثات مستمرة! المشاكل وطلبات السحب مرحب بها جدًا—لنجعل هذه اللعبة أكثر روعة معًا!


## 🙏 الشكر والتقدير

شكرًا للرعاة التاليين لدعمهم هذا المشروع:
- [IDC.REST](https://idc.rest/) لتوفير الخادم
- [Serv00](https://www.serv00.com/) لتوفير الخادم

---
_آخر تحديث: يونيو 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---