
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# روسيتا ستوكس

- [المقدمة](#introduction)
- [التثبيت](#install)
  - [كروم](#chrome-based-browsers)
    - [دليل بصري](#chrome-based-browsers)
  - [فايرفوكس](#firefox-based-browsers)
- [كيفية الاستخدام](#how-to-use)
  - [إضافة الوقت](#adding-time)
    - [الأساسيات](#adding-time-in-foundations)
    - [منشئ الطلاقة](#adding-time-in-fluency-builder)
  - [التحقق من الدرس](#validating-lesson)
    - [الأساسيات](#validating-lesson-in-foundations)
    - [منشئ الطلاقة](#validating-lesson-in-fluency-builder)

## المقدمة

RosettaStonks هو امتداد للمتصفح يتيح لك إضافة الوقت والتحقق من الدروس على منصة تعلم اللغة Rosetta Stone.

> RosettaStonks، وحجر Rosetta الخاص بك يصبح Stonks.

## التثبيت

### المتصفحات المبنية على كروم

➡️ **جديد في تثبيت إضافات كروم يدويًا؟** اطلع على [الدليل المرئي خطوة بخطوة](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — يتضمن لقطات شاشة مفيدة! 🖼️

#### 1. استخدام إصدار GitHub

لاستخدام الامتداد في متصفح مبني على كروم، عليك أن:

- تحميل ملف `rosettastonks-chrome.tar.gz` من أحدث إصدار على
  جهازك.
- إنشاء مجلد باسم `rosettastonks` في مكان ما على جهازك لتخزين
  الامتداد
- تشغيل الأمر التالي في مجلد `rosettastonks`.


```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. استخدام مدير الحزم nix

بدلاً من الأوامر السابقة، إذا كنت تستخدم نظام nix **يدعم
الـ flakes**، يمكنك تشغيل الأوامر التالية، والتي ستقوم بتثبيت مجلد
ضمن المسار `/tmp/rosettastonks` يحتوي على جميع الملفات.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

المجلد تم تثبيته الآن تحت `/tmp/rosettastonks/`

**هذا الجزء مخصص لجميع المستخدمين بغض النظر عما إذا كنت تستخدم طريقة github
أو طريقة nix.**

في متصفحك:

- انتقل إلى `chrome://extensions`
- فعّل خيار `وضع المطور`
- انقر على `تحميل غير مُعبأ`
- اختر مجلد `rosettastonks` الخاص بك

### المتصفحات المبنية على Firefox

- قم بتنزيل الملف `rosettastonks.xpi` من أحدث إصدار.
- بدلاً من ذلك، إذا كنت تستخدم مدير الحزم nix مع دعم flake، يمكنك تشغيل
  الأمر التالي.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- انتقل إلى `about:debugging#/runtime/this-firefox` في متصفحك
- انقر على زر الإعدادات واذهب إلى `Debug addons`.
- انقر على `Load Temporary Add-On`
- اختر ملف `/tmp/rosettastonks.xpi` في نافذة اختيار الملفات.

_تحذير: هذه الطريقة تثبت الامتداد بشكل مؤقت فقط، أي أنه إذا أغلقت المتصفح سيتم إزالة الإضافة. هذا بسبب سياسات فايرفوكس التي لا تسمح باستخدام الإضافات غير الموثقة._

## كيفية الاستخدام

### إضافة الوقت

#### إضافة الوقت في Foundations

لإضافة الوقت على منتج `foundations`، يجب عليك الذهاب إلى التمارين الخاصة بك،
والنقر على تجاهل أو حل سؤال واحد على الأقل. بعد القيام بذلك، يجب أن يظهر
حقل الوقت على صفحة الامتداد حيث يمكنك إضافة وقتك.

#### إضافة الوقت في Fluency builder

لإضافة الوقت على منتج `fluency builder`، يجب عليك الذهاب إلى تمارينك،
والإجابة على تمرين واحد على الأقل. إذا لم يظهر حقل إضافة الوقت، فهذا يعني
أنه لم يتم التقاط طلب وقت، يجب عليك تحديث السؤال والإجابة عليه مرة أخرى.
لإضافة الوقت، يجب عليك إنهاء الدرس الذي استخدمته لإضافة الوقت.

_ملاحظة: إذا لم يظهر حقل إضافة الوقت، فهذا يعني أن الإجراءات التي اتخذتها
على موقع Rosetta Stone لم تؤد إلى إضافة وقت شرعي، وبالتالي، عليك الإجابة على أسئلة أخرى._

### التحقق من الدرس

#### التحقق من الدرس في Foundations

للتحقق من الدرس، يجب البدء في درس، والانتقال عبر جميع الأسئلة باستخدام زر
`ignore` في أسفل اليمين. بعد رؤية جميع الأسئلة، يجب أن يؤدي النقر على زر
`validate lesson` إلى التحقق من الدرس. إذا لم يحدث ذلك، عد إلى صفحتك الرئيسية، وانقر على نفس الدرس،





يجب أن يسألك `هل تريد المتابعة أم إعادة التعيين؟`، يمكنك اختيار أي منهما،
وتحقق من الدرس مرة أخرى حتى يعمل. يجب أن يعمل بعد ٣ أو ٤ مرات كحد أقصى.

#### التحقق من الدرس في منشئ الطلاقة

حالياً، ميزة التحقق من الدرس غير متوفرة في Rosetta Stonks.

## بناء التطبيق

### بناء العامل

يمكن تعبئة العامل باستخدام الأمر التالي

```
$ deno task build:worker
```

والذي ينشئ الملف المجمّع `/dist/worker.esm.js` وهو الملف المجمّع
للعامل.

### بناء الواجهة الأمامية

يمكن تجميع العامل باستخدام الأمر التالي

```
$ deno task build:frontend
```

والذي ينشئ الملف المجمع `/dist/frontend.esm.js` والذي يعد الملف المجمع للواجهة الأمامية.

## تعبئة الامتداد

### كروم

لتعبئة الامتداد لمتصفح كروم، يمكن تشغيل الأمر التالي:


```
$ make chrome
```

### فايرفوكس

لحزم الإضافة لمتصفح فايرفوكس، يمكن تشغيل الأمر التالي:

```
$ make firefox
```

والذي سينتج الملف `rosettastonks.xpi`، وهو ملف الامتداد الذي يمكن تحميله في فايرفوكس.

📸 تفضل الشرح المرئي؟ اطلع على [دليل تثبيت كروم بالصور](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---