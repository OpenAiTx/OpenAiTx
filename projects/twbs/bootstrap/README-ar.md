<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="شعار Bootstrap" width="200" height="165">
  </a>
</p>

<h3 align="center">بوتستراب</h3>

<p align="center">
  إطار عمل أمامي أنيق وبديهي وقوي لتطوير الويب بشكل أسرع وأسهل.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>استكشف وثائق بوتستراب »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">الإبلاغ عن عطل</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">طلب ميزة</a>
  ·
  <a href="https://themes.getbootstrap.com/">الثيمات</a>
  ·
  <a href="https://blog.getbootstrap.com/">المدونة</a>
</p>

## بوتستراب 5

الفرع الافتراضي لدينا مخصص لتطوير إصدار بوتستراب 5. توجه إلى [فرع `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) للاطلاع على ملف readme، والوثائق، وكود المصدر لبوتستراب 4.

## جدول المحتويات

- [البدء السريع](#البدء-السريع)
- [الحالة](#الحالة)
- [ما يتضمنه](#ما-يتضمنه)
- [الأعطال وطلبات الميزات](#الأعطال-وطلبات-الميزات)
- [التوثيق](#التوثيق)
- [المساهمة](#المساهمة)
- [المجتمع](#المجتمع)
- [إصدار النسخ](#إصدار-النسخ)
- [المبدعون](#المبدعون)
- [الشكر](#الشكر)
- [حقوق النشر والترخيص](#حقوق-النشر-والترخيص)

## البدء السريع

تتوفر عدة خيارات للبدء السريع:

- [تحميل آخر إصدار](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- استنساخ المستودع: `git clone https://github.com/twbs/bootstrap.git`
- التثبيت عبر [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- التثبيت عبر [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- التثبيت عبر [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- التثبيت عبر [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- التثبيت عبر [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

اقرأ [صفحة البدء](https://getbootstrap.com/docs/5.3/getting-started/introduction/) لمزيد من المعلومات حول محتويات الإطار، والقوالب، والأمثلة، والمزيد.

## الحالة

[![حالة البناء](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![إصدار npm](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![إصدار Gem](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![إصدار Packagist التجريبي](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![حالة التغطية](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![حجم CSS المضغوط](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![حجم CSS Brotli](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![حجم JS المضغوط](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![حجم JS Brotli](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![الداعمون على Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![الرعاة على Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)

## ما يتضمنه

عند التحميل ستجد الأدلة والملفات التالية، مصنفة منطقياً لتجميع الأصول الشائعة وتوفير نسخ مجمعة ومضغوطة.

<details>
  <summary>محتويات التحميل</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

نوفر CSS وJS مجمعة (`bootstrap.*`) بالإضافة إلى CSS وJS مجمعة ومضغوطة (`bootstrap.min.*`). تتوفر [خرائط المصدر](https://web.dev/articles/source-maps) (`bootstrap.*.map`) للاستخدام مع أدوات المطور لبعض المتصفحات. ملفات JS المجمعة (`bootstrap.bundle.js` و`bootstrap.bundle.min.js` المضغوطة) تتضمن [Popper](https://popper.js.org/docs/v2/).

## الأعطال وطلبات الميزات

هل لديك عطل أو طلب ميزة؟ يرجى أولاً قراءة [إرشادات فتح القضايا](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) والبحث عن القضايا الحالية والمغلقة. إذا لم يتم معالجة مشكلتك أو فكرتك بعد، [يرجى فتح قضية جديدة](https://github.com/twbs/bootstrap/issues/new/choose).

## التوثيق

وثائق بوتستراب، المضمنة في هذا المستودع في الدليل الجذري، مبنية باستخدام [Astro](https://astro.build/) ومستضافة علنًا على GitHub Pages في <https://getbootstrap.com/>. يمكن أيضًا تشغيل الوثائق محليًا.

البحث في الوثائق مدعوم بواسطة [DocSearch من Algolia](https://docsearch.algolia.com/).

### تشغيل الوثائق محليًا

1. شغّل `npm install` لتثبيت تبعيات Node.js، بما في ذلك Astro (منشئ الموقع).
2. شغّل `npm run test` (أو سكريبت npm محدد) لإعادة بناء ملفات CSS وJavaScript الموزعة، بالإضافة إلى أصول الوثائق.
3. من الدليل الجذري `/bootstrap`، شغّل `npm run docs-serve` في سطر الأوامر.
4. افتح `http://localhost:9001/` في متصفحك، وهكذا.

تعرف أكثر على استخدام Astro من خلال قراءة [وثائقه](https://docs.astro.build/en/getting-started/).

### توثيق الإصدارات السابقة

يمكنك العثور على جميع وثائق الإصدارات السابقة على <https://getbootstrap.com/docs/versions/>.

[الإصدارات السابقة](https://github.com/twbs/bootstrap/releases) ووثائقها متاحة أيضًا للتحميل.

## المساهمة

يرجى قراءة [إرشادات المساهمة](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). تتضمن الإرشادات تعليمات لفتح القضايا، ومعايير كتابة الكود، وملاحظات حول التطوير.

بالإضافة إلى ذلك، إذا احتوى طلب الدمج الخاص بك على تعديلات أو ميزات في JavaScript، يجب أن ترفق [اختبارات وحدات ذات صلة](https://github.com/twbs/bootstrap/tree/main/js/tests). يجب أن يتوافق كل من HTML وCSS مع [دليل الكود](https://github.com/mdo/code-guide) الذي يديره [Mark Otto](https://github.com/mdo).

تفضيلات المحرر متوفرة في [ملف إعدادات المحرر](https://github.com/twbs/bootstrap/blob/main/.editorconfig) لسهولة الاستخدام في محررات النصوص الشائعة. اقرأ المزيد وقم بتحميل الإضافات على <https://editorconfig.org/>.

## المجتمع

احصل على التحديثات حول تطوير بوتستراب وتواصل مع مشرفي المشروع وأعضاء المجتمع.

- تابع [@getbootstrap على X](https://x.com/getbootstrap).
- اقرأ واشترك في [المدونة الرسمية لبوتستراب](https://blog.getbootstrap.com/).
- اطرح الأسئلة واستكشف [المناقشات على GitHub](https://github.com/twbs/bootstrap/discussions).
- ناقش واطرح الأسئلة والمزيد على [خادم Discord المجتمعي](https://discord.gg/bZUvakRU3M) أو [منتدى Bootstrap على Reddit](https://www.reddit.com/r/bootstrap/).
- تواصل مع مستخدمي بوتستراب الآخرين عبر IRC. على خادم `irc.libera.chat` في قناة `#bootstrap`.
- قد تجد المساعدة في التنفيذ على Stack Overflow (بعلامة [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- يجب على المطورين استخدام الكلمة المفتاحية `bootstrap` في الحزم التي تعدل أو تضيف إلى وظائف بوتستراب عند التوزيع عبر [npm](https://www.npmjs.com/browse/keyword/bootstrap) أو آليات التوزيع المشابهة لتحقيق أقصى قابلية للاكتشاف.

## إصدار النسخ

لتحقيق الشفافية في دورة الإصدارات والسعي للحفاظ على التوافق مع الإصدارات السابقة، يُدار بوتستراب وفقًا [لإرشادات إصدار النسخ الدلالية](https://semver.org/). أحيانًا نخطئ، لكننا نلتزم بهذه القواعد كلما أمكن ذلك.

راجع [قسم الإصدارات في مشروعنا على GitHub](https://github.com/twbs/bootstrap/releases) للاطلاع على سجلات التغيير لكل إصدار من بوتستراب. منشورات الإعلان عن الإصدارات في [المدونة الرسمية لبوتستراب](https://blog.getbootstrap.com/) تتضمن ملخصات لأبرز التغييرات في كل إصدار.

## المبدعون

**مارك أوتو**

- <https://x.com/mdo>
- <https://github.com/mdo>

**جيكوب ثورنتون**

- <https://x.com/fat>
- <https://github.com/fat>

## الشكر

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

شكرًا لـ [BrowserStack](https://www.browserstack.com/) لتوفير البنية التحتية التي تتيح لنا الاختبار على متصفحات حقيقية!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

شكرًا لـ [Netlify](https://www.netlify.com/) لتوفير معاينات النشر لنا!

## الرعاة

ادعم هذا المشروع بأن تصبح راعياً. سيظهر شعارك هنا مع رابط إلى موقعك. [[كن راعياً](https://opencollective.com/bootstrap#sponsor)]

[![الراعي OC 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![الراعي OC 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![الراعي OC 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![الراعي OC 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![الراعي OC 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![الراعي OC 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![الراعي OC 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![الراعي OC 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![الراعي OC 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![الراعي OC 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)

## الداعمون

شكرًا لجميع داعمينا! 🙏 [[كن داعماً](https://opencollective.com/bootstrap#backer)]

[![الداعمون](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)

## حقوق النشر والترخيص

حقوق كود المصدر والتوثيق 2011-2025 [لمؤلفي بوتستراب](https://github.com/twbs/bootstrap/graphs/contributors). الكود متاح بموجب [رخصة MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). التوثيق متاح بموجب [رخصة المشاع الإبداعي](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---