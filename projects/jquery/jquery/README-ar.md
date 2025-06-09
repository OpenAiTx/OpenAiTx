# [jQuery](https://jquery.com/) — جافاسكريبت الموجة الجديدة

تُعقد الاجتماعات حالياً على [منصة matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

يمكن العثور على محاضر الاجتماعات في [meetings.jquery.org](https://meetings.jquery.org/category/core/).

أحدث إصدار من jQuery متوفر على [https://jquery.com/download/](https://jquery.com/download/).

## دعم الإصدارات

| الإصدار | الفرع       | الحالة    |
| ------- | ----------- | --------- |
| 4.x     | main        | بيتا      |
| 3.x     | 3.x-stable  | نشط       |
| 2.x     | 2.x-stable  | غير نشط   |
| 1.x     | 1.x-stable  | غير نشط   |

بمجرد إصدار النسخة النهائية 4.0.0، سيستمر فرع 3.x في تلقي التحديثات لفترة محدودة. لم يعد فرعا 2.x و1.x مدعومين.

الدعم التجاري للإصدارات غير النشطة متوفر من خلال [HeroDevs](https://herodevs.com/nes).

تعرف على المزيد حول [دعم الإصدارات](https://jquery.com/support/).

## أدلة المساهمة

تماشياً مع روح تطوير البرمجيات مفتوحة المصدر، يشجع jQuery دائماً مساهمة المجتمع في الكود. لمساعدتك على البدء وقبل الشروع في كتابة الكود، تأكد من قراءة هذه الإرشادات الهامة للمساهمة بشكل دقيق:

1. [الانخراط](https://contribute.jquery.org/)
2. [دليل أسلوب كتابة الكود الأساسي](https://contribute.jquery.org/style-guide/js/)
3. [كتابة الكود لمشاريع jQuery](https://contribute.jquery.org/code/)

### الإشارات إلى القضايا/طلبات السحب

عادةً ما يتم الإشارة إلى قضايا GitHub/طلبات السحب عبر `gh-NUMBER`، حيث أن `NUMBER` هو المعرف الرقمي للقضية أو طلب السحب. يمكنك العثور على مثل هذه القضية أو الطلب تحت `https://github.com/jquery/jquery/issues/NUMBER`.

كان jQuery يستخدم متتبع أخطاء مختلف - يعتمد على Trac - في الماضي، وهو متوفر تحت [bugs.jquery.com](https://bugs.jquery.com/). يتم الاحتفاظ به في وضع القراءة فقط بحيث يمكن الرجوع إلى المناقشات السابقة. عند الإشارة إلى إحدى تلك القضايا في مصدر jQuery، يتم استخدام النمط `trac-NUMBER`، حيث أن `NUMBER` هو المعرف الرقمي للقضية. يمكنك العثور على مثل هذه القضية تحت `https://bugs.jquery.com/ticket/NUMBER`.

## البيئات التي يمكن استخدام jQuery فيها

- [دعم المتصفح](https://jquery.com/browser-support/)
- يدعم jQuery أيضاً Node، وملحقات المتصفح، وبيئات غير المتصفح الأخرى.

## ما تحتاجه لبناء jQuery الخاص بك

لبناء jQuery، تحتاج إلى أحدث إصدار من Node.js/npm وgit 1.7 أو أحدث. قد تعمل الإصدارات الأقدم، لكنها غير مدعومة.

بالنسبة لويندوز، عليك تحميل وتثبيت [git](https://git-scm.com/downloads) و[Node.js](https://nodejs.org/en/download/).

ينبغي لمستخدمي macOS تثبيت [Homebrew](https://brew.sh/). بعد تثبيت Homebrew، شغّل الأمر `brew install git` لتثبيت git،
و`brew install node` لتثبيت Node.js.

ينبغي لمستخدمي Linux/BSD استخدام مديري الحزم المناسبين لتثبيت git وNode.js، أو البناء من المصدر
إذا كنت تفضل ذلك. الأمر بسيط جداً.

## كيفية بناء jQuery الخاص بك

أولاً، [استنسخ مستودع jQuery من git](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

ثم، ادخل إلى مجلد jquery، قم بتثبيت التبعيات، ثم شغل سكريبت البناء:

```bash
cd jquery
npm install
npm run build
```

سيتم وضع النسخة المبنية من jQuery في مجلد `dist/`، جنباً إلى جنب مع نسخة مصغرة وملف الخريطة المرتبط بها.

## بناء جميع ملفات إصدارات jQuery

لبناء جميع أنواع jQuery، شغل الأمر التالي:

```bash
npm run build:all
```

سيتم بذلك إنشاء جميع الأنواع التي يتضمنها إصدار jQuery، بما في ذلك `jquery.js`، و`jquery.slim.js`، و`jquery.module.js`، و`jquery.slim.module.js` مع ملفاتها المصغرة وملفات sourcemap المرتبطة بها.

ملفات `jquery.module.js` و`jquery.slim.module.js` هي [وحدات ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) تقوم بتصدير `jQuery` و`$` كتصديرات مسماة وتوضع في مجلد `dist-module/` بدلاً من مجلد `dist/`.

## بناء نسخة مخصصة من jQuery

يمكن استخدام سكريبت البناء لإنشاء نسخة مخصصة من jQuery تتضمن فقط الوحدات التي تحتاجها.

يمكن استبعاد أي وحدة باستثناء `core`. عند استبعاد `selector`، لا تتم إزالته ولكن يتم استبداله بغلاف صغير حول `querySelectorAll` المدمجة في المتصفح (راجع أدناه للمزيد من المعلومات).

### تعليمات سكريبت البناء

لعرض القائمة الكاملة للخيارات المتاحة لسكريبت البناء، شغّل الأمر التالي:

```bash
npm run build -- --help
```

### الوحدات

لاستبعاد وحدة ما، مرر مسارها بالنسبة لمجلد `src` (بدون الامتداد `.js`) إلى خيار `--exclude`. عند استخدام خيار `--include`، يتم إسقاط التضمينات الافتراضية ويتم إنشاء بناء يحتوي فقط على تلك الوحدات.

بعض أمثلة الوحدات التي يمكن استبعادها أو تضمينها:

- **ajax**: جميع وظائف AJAX: `$.ajax()`، `$.get()`، `$.post()`، `$.ajaxSetup()`، `.load()`، النقل، واختصارات أحداث ajax مثل `.ajaxStart()`.
- **ajax/xhr**: ناقل AJAX الخاص بـ XMLHTTPRequest فقط.
- **ajax/script**: ناقل AJAX الخاص بعنصر `<script>` فقط؛ يُستخدم لاسترجاع السكريبتات.
- **ajax/jsonp**: ناقل AJAX الخاص بـ JSONP فقط؛ يعتمد على ناقل ajax/script.
- **css**: دالة `.css()`. كما يزيل **جميع** الوحدات التي تعتمد على css (بما في ذلك **effects**، **dimensions**، و**offset**).
- **css/showHide**: الدوال غير المتحركة `.show()`، `.hide()` و`.toggle()`؛ يمكن استبعادها إذا كنت تستخدم الفئات أو استدعاءات `.css()` الصريحة لتعيين خاصية `display`. كما يزيل وحدة **effects**.
- **deprecated**: الدوال الموثقة كموقوفة لكن لم تُزل بعد.
- **dimensions**: دوال `.width()` و`.height()`، بما في ذلك المتغيرات `inner-` و`outer-`.
- **effects**: دالة `.animate()` واختصاراتها مثل `.slideUp()` أو `.hide("slow")`.
- **event**: دوال `.on()` و`.off()` وجميع وظائف الأحداث.
- **event/trigger**: دوال `.trigger()` و`.triggerHandler()`.
- **offset**: دوال `.offset()`، `.position()`، `.offsetParent()`، `.scrollLeft()`، و`.scrollTop()`.
- **wrap**: دوال `.wrap()`، `.wrapAll()`، `.wrapInner()`، و`.unwrap()`.
- **core/ready**: استبعد وحدة ready إذا وضعت سكريبتاتك في نهاية body. أي ردود جاهزية مرتبطة بـ`jQuery()` سيتم استدعاؤها فوراً. ومع ذلك، لن تكون `jQuery(document).ready()` دالة ولن يتم تفعيل `.on("ready", ...)` أو ما شابه.
- **deferred**: استبعد jQuery.Deferred. هذا يستبعد أيضاً جميع الوحدات التي تعتمد على Deferred، بما في ذلك **ajax**، **effects**، و**queue**، ولكنه يستبدل **core/ready** بـ**core/ready-no-deferred**.
- **exports/global**: استبعاد إرفاق متغيرات jQuery العالمية ($ وjQuery) إلى النافذة window.
- **exports/amd**: استبعاد تعريف AMD.

- **selector**: محرك انتقاء jQuery الكامل. عند استبعاد هذه الوحدة، يتم استبدالها بمحرك انتقاء بدائي يعتمد على دالة `querySelectorAll` الخاصة بالمتصفح ولا يدعم امتدادات انتقاء jQuery أو الدلالات المعززة. راجع ملف [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) للتفاصيل.

*ملاحظة*: استبعاد وحدة `selector` الكاملة سيستبعد أيضاً جميع امتدادات انتقاء jQuery (مثل `effects/animatedSelector` و`css/hiddenVisibleSelectors`).

##### اسم AMD

يمكنك تعيين اسم الوحدة لتعريف AMD الخاص بـjQuery. بشكل افتراضي، يتم تعيينه إلى "jquery"، وهو متوافق مع الإضافات ومكتبات الطرف الثالث، لكن قد تكون هناك حالات ترغب فيها بتغييره. مرره إلى معامل `--amd`:

```bash
npm run build -- --amd="custom-name"
```

أو، لتعريف مجهول، اترك الاسم فارغاً.

```bash
npm run build -- --amd
```

##### اسم الملف والمجلد

الاسم الافتراضي لملف jQuery المبني هو `jquery.js`؛ ويتم وضعه تحت مجلد `dist/`. من الممكن تغيير اسم الملف باستخدام `--filename` والمجلد باستخدام `--dir`. `--dir` يكون بالنسبة لجذر المشروع.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

سيؤدي ذلك إلى إنشاء نسخة slim من jQuery ووضعها تحت `tmp/jquery.slim.js`.

##### وضع وحدة ECMAScript (ESM)

بشكل افتراضي، ينشئ jQuery ملف جافاسكريبت عادي. يمكنك أيضاً إنشاء وحدة ECMAScript تقوم بتصدير `jQuery` كتصدير افتراضي باستخدام معامل `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### وضع المصنع (Factory mode)

بشكل افتراضي، يعتمد jQuery على وجود `window` عالمي. للبيئات التي لا تحتوي عليه، يمكنك إنشاء بناء مصنع يعرض دالة تقبل `window` كمعامل يمكنك توفيره خارجياً (راجع [`README` لحزمة النشر](build/fixtures/README.md) للحصول على تعليمات الاستخدام). يمكنك إنشاء مثل هذا البناء باستخدام معامل `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

يمكن دمج هذا الخيار مع خيارات أخرى مثل `--esm` أو `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### أمثلة على البناء المخصص

أنشئ بناءً مخصصاً باستخدام `npm run build`، مع سرد الوحدات التي سيتم استبعادها. استبعاد وحدة من المستوى الأعلى يستبعد أيضاً دليل الوحدات المقابل لها.

استبعاد جميع وظائف **ajax**:

```bash
npm run build -- --exclude=ajax
```

استبعاد **css** يزيل الوحدات التي تعتمد على CSS: **effects**، **offset**، **dimensions**.

```bash
npm run build -- --exclude=css
```

استبعاد مجموعة من الوحدات (`-e` هو اسم مستعار لـ`--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

هناك اسم مستعار خاص لإنشاء بناء بنفس تكوين إصدار jQuery Slim الرسمي:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

أو، لإنشاء بناء slim كوحدة esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*البُنى المخصصة غير الرسمية لا يتم اختبارها بانتظام. استخدمها على مسؤوليتك الخاصة.*

## تشغيل اختبارات الوحدة

تأكد من توفر الاعتمادات اللازمة لديك:

```bash
npm install
```

ابدأ تشغيل `npm start` للبناء التلقائي لـ jQuery أثناء عملك:

```bash
npm start
```

قم بتشغيل اختبارات الوحدة عبر خادم محلي يدعم PHP. تأكد من تشغيل الموقع من الدليل الجذري، وليس من دليل "test". لا حاجة لقاعدة بيانات. تتوفر خوادم محلية PHP معدة مسبقًا لأنظمة ويندوز وماك. إليك بعض الخيارات:

- ويندوز: [تحميل WAMP](https://www.wampserver.com/en/)
- ماك: [تحميل MAMP](https://www.mamp.info/en/downloads/)
- لينكس: [إعداد LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (معظم المنصات)](https://code.google.com/p/mongoose/)

## أساسيات Git

نظرًا لأن الشيفرة المصدرية تتم إدارتها عبر نظام التحكم بالإصدارات Git، من المفيد معرفة بعض الميزات المستخدمة.

### التنظيف

إذا أردت إعادة دليل العمل الخاص بك إلى حالة المصدر (upstream)، يمكن استخدام الأوامر التالية (تذكر أن كل عملك سيُحذف بعد ذلك):

```bash
git reset --hard upstream/main
git clean -fdx
```

### إعادة الترتيب (Rebasing)

لفروع الميزات/الموضوعات، يجب عليك دائمًا استخدام الخيار `--rebase` مع أمر `git pull`، أو إذا كنت غالبًا ما تدير العديد من الفروع المؤقتة (التي سيتم إرسالها لاحقًا كـ pull request على github)، نفّذ التالي لأتمتة ذلك:

```bash
git config branch.autosetuprebase local
```

(راجع `man git-config` لمزيد من المعلومات)

### التعامل مع تعارضات الدمج

إذا واجهت تعارضات عند الدمج، بدلاً من تعديل الملفات المتعارضة يدويًا، يمكنك استخدام خاصية
`git mergetool`. حتى وإن كان الأداة الافتراضية `xxdiff` تبدو قديمة وسيئة، فهي مفيدة نوعًا ما.

فيما يلي بعض الأوامر التي يمكن استخدامها هناك:

- `Ctrl + Alt + M` - الدمج التلقائي قدر الإمكان
- `b` - الانتقال إلى التعارض التالي
- `s` - تغيير ترتيب الأسطر المتعارضة
- `u` - التراجع عن الدمج
- `زر الفأرة الأيسر` - تعيين كتلة لتكون الفائزة
- `زر الفأرة الأوسط` - تعيين سطر ليكون الفائز
- `Ctrl + S` - حفظ
- `Ctrl + Q` - خروج

## مرجع [QUnit](https://api.qunitjs.com)

### طرق الاختبار

```js
expect( numAssertions );
stop();
start();
```

*ملاحظة*: إضافة QUnit المستقبلية لمعامل إلى stop/start تم تجاهلها في مجموعة الاختبار هذه بحيث يمكن تمرير start و stop كـ callbacks دون القلق حول معاييرها.

### تأكيدات الاختبار

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## مرجع طرق تسهيل مجموعة الاختبار

انظر [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### تُرجع مصفوفة من العناصر ذات المعرفات المحددة

```js
q( ... );
```

مثال:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### التأكد من أن التحديد يطابق المعرفات المحددة

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

مثال:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### إطلاق حدث DOM أصلي دون المرور عبر jQuery

```js
fireNative( node, eventType );
```

مثال:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### إضافة رقم عشوائي للرابط لمنع التخزين المؤقت

```js
url( "some/url" );
```

مثال:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### تشغيل الاختبارات في iframe

قد تتطلب بعض الاختبارات مستندًا غير تركيبة الاختبار القياسية،
ويمكن تشغيل هذه في إطار iframe منفصل. تظل الشيفرة الفعلية للاختبار والتأكيدات
في ملفات الاختبار الرئيسية لـ jQuery؛ يجب وضع الحد الأدنى فقط من تعليمات تركيب الاختبار
وشيفرة الإعداد في ملف iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

هذا يحمل صفحة، ويكوّن رابطًا باستخدام fileName `"./data/" + fileName`.
تحدد صفحة iframe متى يحدث الاستدعاء في الاختبار عن طريق
تضمين سكريبت "/test/data/iframeTest.js" واستدعاء
`startIframeTest( [ additional args ] )` عندما يكون مناسبًا. غالبًا يكون ذلك
بعد إما استدعاء document ready أو حدث `window.onload`.

يتلقى `testCallback` كائن QUnit `assert` الذي أنشأه `testIframe`
لهذا الاختبار، يليه المتغيرات العامة `jQuery`، `window`، و `document` من
الـ iframe. إذا مررت كود iframe أي وسائط إلى `startIframeTest`،
فهي تتبع معامل `document`.

## أسئلة؟

إذا كان لديك أي أسئلة، لا تتردد في طرحها على
[منتدى تطوير نواة jQuery](https://forum.jquery.com/developing-jquery-core) أو في #jquery على [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---