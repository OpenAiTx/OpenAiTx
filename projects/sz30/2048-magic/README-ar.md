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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

نسخة محسنة من لعبة 2048 الكلاسيكية، الآن مع ميزات أكثر متعة! هذا مشروع صغير قمت بإنشائه في وقت فراغي—آمل أن يجلب لك بعض المرح!

## 🎯 مقدمة اللعبة

2048 هي لعبة دمج أرقام بسيطة لكنها تسبب الإدمان. على شبكة 4×4، اسحب للأعلى أو الأسفل أو اليسار أو اليمين لدمج البلاطات التي تحمل نفس الرقم. الهدف؟ الوصول إلى 2048 (ولكن يمكنك الاستمرار لتحقيق درجات أعلى)!

**كيفية اللعب:**
- استخدم أسهم الاتجاهات أو مفاتيح WASD لتحريك البلاطات.
- عندما تتصادم بلاطتان تحملان نفس الرقم، تندمجان في واحدة.
- بعد كل حركة، ستظهر 2 أو 4 جديدة عشوائياً في مكان فارغ.
- تنتهي اللعبة عند عدم وجود تحركات متبقية.

## ✨ ميزات خاصة

### 1. وظيفة التراجع
- قمت بحركة خاطئة؟ لا تقلق!
- فقط اضغط على زر "تراجع" للعودة خطوة واحدة.
- يمكنك التراجع لعدد غير محدود من المرات حتى بداية اللعبة.
- لا تدع زلة إصبع تفسد لعبتك مرة أخرى!

### 2. وضع الغش السري
- أدخل التسلسل السحري: ←←→→ →→←← (يسار، يسار، يمين، يمين، يمين، يمين، يسار، يسار)
- ستتحول جميع البلاطات بشكل سحري إلى 128!
- إنها بيضة عيد الفصح، فقط للمرح.
- نصيحة احترافية: الغش ممتع، لكن لا تفرط فيه! 😉

## 🎯 العرض التوضيحي

🎯 العب هنا: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 هيكلية المشروع
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
- `2048.py`: خادم خلفي مكتوب باستخدام Flask، يدير منطق اللعبة وطلبات API.
- `script.js`: منطق اللعبة في الواجهة الأمامية، يشمل الحركات، والرسوم المتحركة، والميزات الخاصة.
- `styles.css`: أنماط اللعبة، لضمان ظهور كل شيء بشكل جميل ومتجاوب.
- `index.html`: الصفحة الرئيسية التي تجمع كل شيء معًا.

## 🚀 البدء السريع

**الطريقة الأولى: تحميل الإصدار**
1. قم بتحميل أحدث إصدار.
2. تأكد من تثبيت بايثون 3.x على جهازك.
3. ثبّت الاعتمادات: `pip install flask`
4. شغّل: `python 2048.py`
5. افتح متصفحك وانتقل إلى: [http://localhost:9969](http://localhost:9969)

**الطريقة الثانية: استنساخ من GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 التخصيص

هل ترغب في جعله خاصًا بك؟ عدّل ملف `styles.css` للحصول على مظهر جديد، أو غص في ملف `script.js` لتغيير طريقة اللعب. جميع الشيفرات مشروحة بشكل جيد لسهولة التعديل!

## 📝 الرخصة

رخصة GPL-2.0

## 🤝 المساهمة

ما زال التحديث مستمرًا! المشاكل وطلبات السحب مرحب بها جدًا—لنُحسّن هذه اللعبة معًا ونزيدها روعة!


## 🙏 الشكر والتقدير

شكرًا للرعاة التاليين على دعمهم لهذا المشروع:
- [Serv00](https://www.serv00.com/) لتوفير الخادم

---
_آخر تحديث: يونيو 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---