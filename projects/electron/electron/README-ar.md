[![شعار Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![حالة بناء GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![دعوة Discord لـ Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: الترجمات المتوفرة: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
يمكنك عرض هذه الوثائق بلغات أخرى من خلال مشروعنا على [Crowdin](https://crowdin.com/project/electron).

يتيح لك إطار عمل Electron كتابة تطبيقات سطح مكتب متعددة المنصات باستخدام JavaScript وHTML وCSS. يعتمد على [Node.js](https://nodejs.org/) و[Chromium](https://www.chromium.org) ويستخدم في [Visual Studio Code](https://github.com/Microsoft/vscode/) والعديد من [التطبيقات](https://electronjs.org/apps) الأخرى.

تابع [@electronjs](https://twitter.com/electronjs) على تويتر للإعلانات الهامة.

هذا المشروع يلتزم بـ [ميثاق السلوك](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) الخاص بـ Contributor Covenant.
بمشاركتك، يُتوقع منك الالتزام بهذا الميثاق. يرجى الإبلاغ عن أي سلوك غير مقبول إلى [coc@electronjs.org](mailto:coc@electronjs.org).

## التثبيت

لتثبيت حزم Electron الجاهزة، استخدم [`npm`](https://docs.npmjs.com/).
الطريقة المفضلة هي تثبيت Electron كاعتماد تطوير في تطبيقك:

```sh
npm install electron --save-dev
```

لخيارات تثبيت إضافية ونصائح لحل المشاكل، راجع [التثبيت](docs/tutorial/installation.md). لمعلومات حول كيفية إدارة إصدارات Electron في تطبيقاتك، راجع [إصدارات Electron](docs/tutorial/electron-versioning.md).

## دعم المنصات

كل إصدار من Electron يوفر حزمًا لأنظمة macOS وWindows وLinux.

* macOS (Big Sur وما بعده): يوفر Electron حزم 64-بت لمعالجات Intel وApple Silicon / ARM لنظام macOS.
* Windows (Windows 10 وما بعده): يوفر Electron حزم `ia32` (`x86`)، `x64` (`amd64`)، و`arm64` لنظام Windows. تم إضافة دعم Windows على ARM في Electron 5.0.8. تم [إزالة دعم Windows 7 و8 و8.1 في Electron 23، تماشيًا مع سياسة إنهاء دعم Windows في Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: تُبنى الحزم الجاهزة من Electron على Ubuntu 20.04. وقد تم التحقق من عملها أيضًا على:
  * Ubuntu 18.04 وما بعده
  * Fedora 32 وما بعده
  * Debian 10 وما بعده

## Electron Fiddle

استخدم [`Electron Fiddle`](https://github.com/electron/fiddle)
لبناء وتشغيل وتغليف تجارب Electron الصغيرة، ولمشاهدة أمثلة الكود لجميع واجهات برمجة التطبيقات (APIs) الخاصة بـ Electron،
ولتجربة إصدارات مختلفة من Electron. تم تصميمه لجعل بداية رحلتك مع Electron أسهل.

## مصادر تعلم Electron

* [electronjs.org/docs](https://electronjs.org/docs) - جميع وثائق Electron
* [electron/fiddle](https://github.com/electron/fiddle) - أداة لبناء وتشغيل وتغليف تجارب Electron الصغيرة
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - تطبيقات بداية نموذجية أنشأها المجتمع

## الاستخدام البرمجي

يستخدم معظم الأشخاص Electron من سطر الأوامر، لكن إذا قمت باستدعاء `electron` داخل **تطبيق Node الخاص بك** (وليس تطبيق Electron)، فسيعيد مسار ملف التنفيذ.
استخدم هذا لتشغيل Electron من نصوص Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// سيطبع شيء مشابه لـ /Users/maf/.../Electron
console.log(electron)

// تشغيل Electron
const child = proc.spawn(electron)
```

### المرايا

* [الصين](https://npmmirror.com/mirrors/electron/)

راجع [تعليمات التثبيت المتقدمة](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) لمعرفة كيفية استخدام مرآة مخصصة.

## ترجمات الوثائق

نقوم بجمع ترجمات وثائقنا عبر [Crowdin](https://crowdin.com/project/electron).
نقبل حاليًا ترجمات للغات الصينية (المبسطة)، الفرنسية، الألمانية، اليابانية، البرتغالية، الروسية، والإسبانية.

## المساهمة

إذا كنت مهتمًا بالإبلاغ عن المشاكل أو إصلاحها والمساهمة مباشرة في قاعدة الشيفرة، يرجى مراجعة [CONTRIBUTING.md](CONTRIBUTING.md) لمزيد من المعلومات حول ما نبحث عنه وكيفية البدء.

## المجتمع

معلومات حول الإبلاغ عن الأخطاء، والحصول على المساعدة، والعثور على أدوات وتطبيقات طرف ثالث، والمزيد يمكنك العثور عليها في [صفحة المجتمع](https://www.electronjs.org/community).

## الرخصة

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

عند استخدام شعارات Electron، تأكد من اتباع [سياسة العلامات التجارية لمؤسسة OpenJS](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---