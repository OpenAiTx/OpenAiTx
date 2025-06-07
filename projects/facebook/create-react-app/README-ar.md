## إنشاء تطبيق React [![البناء والاختبار](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![نرحب بطلبات الدمج](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!تحذير]
>
> ## مهمل
>
> كان "إنشاء تطبيق React" أحد الأدوات الرئيسية لإطلاق مشروع React وتشغيله بين عامي 2017 و2021، وهو الآن في حالة ركود طويلة الأمد ونوصي بأن تنتقل إلى أحد أطر React الموثقة في [بدء مشروع React جديد](https://react.dev/learn/start-a-new-react-project).
>
> إذا كنت تتبع درسًا تعليميًا لتعلم React، فلا يزال هناك قيمة في متابعة درسك، لكننا لا نوصي ببدء تطبيقات إنتاجية تعتمد على "إنشاء تطبيق React".

<img alt="الشعار" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

أنشئ تطبيقات React بدون إعداد بناء.

- [إنشاء تطبيق](#creating-an-app) – كيفية إنشاء تطبيق جديد.
- [دليل المستخدم](https://facebook.github.io/create-react-app/) – كيفية تطوير تطبيقات تم تمهيدها باستخدام "إنشاء تطبيق React".

يعمل "إنشاء تطبيق React" على أنظمة macOS وWindows وLinux.<br>
إذا كان هناك شيء لا يعمل، يرجى [تقديم تذكرة](https://github.com/facebook/create-react-app/issues/new).<br>
إذا كان لديك أسئلة أو تحتاج إلى مساعدة، يرجى السؤال في [مناقشات GitHub](https://github.com/facebook/create-react-app/discussions).

## نظرة سريعة

```sh
npx create-react-app my-app
cd my-app
npm start
```

إذا كنت قد قمت بتثبيت `create-react-app` سابقًا بشكل عالمي عبر `npm install -g create-react-app`، نوصي بإلغاء تثبيت الحزمة باستخدام `npm uninstall -g create-react-app` أو `yarn global remove create-react-app` لضمان أن npx يستخدم دائمًا أحدث إصدار.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) يأتي مع npm 5.2+ أو أعلى، راجع [التعليمات للإصدارات الأقدم من npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

ثم افتح [http://localhost:3000/](http://localhost:3000/) لرؤية تطبيقك.<br>
عندما تكون جاهزًا للنشر للإنتاج، أنشئ حزمة مضغوطة باستخدام `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### ابدأ فورًا

**لا تحتاج** إلى تثبيت أو إعداد أدوات مثل webpack أو Babel.<br>
فهي معدة مسبقًا ومخفية بحيث يمكنك التركيز على الكود.

أنشئ مشروعًا، وستكون جاهزًا للعمل.

## إنشاء تطبيق

**ستحتاج إلى وجود Node 14.0.0 أو إصدار أحدث على جهاز التطوير المحلي الخاص بك** (وليس مطلوبًا على الخادم). نوصي باستخدام أحدث إصدار LTS. يمكنك استخدام [nvm](https://github.com/creationix/nvm#installation) (لنظامي macOS/Linux) أو [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) للتبديل بين إصدارات Node بين المشاريع المختلفة.

لإنشاء تطبيق جديد، يمكنك اختيار إحدى الطرق التالية:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) هو أداة تشغيل الحزم ويأتي مع npm 5.2+ أو أعلى، راجع [التعليمات للإصدارات الأقدم من npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` متوفر في npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) متوفر في Yarn 0.25+_

سيقوم بإنشاء مجلد يسمى `my-app` داخل المجلد الحالي.<br>
داخل هذا المجلد، سيولد هيكل المشروع الابتدائي ويثبت الاعتمادات التبادلية:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

لا إعدادات معقدة أو هياكل مجلدات معقدة، فقط الملفات التي تحتاجها لبناء تطبيقك.<br>
بمجرد الانتهاء من التثبيت، يمكنك فتح مجلد مشروعك:

```sh
cd my-app
```

داخل المشروع الذي تم إنشاؤه حديثًا، يمكنك تشغيل بعض الأوامر المدمجة:

### `npm start` أو `yarn start`

يشغل التطبيق في وضع التطوير.<br>
افتح [http://localhost:3000](http://localhost:3000) لمشاهدته في المتصفح.

ستتم إعادة تحميل الصفحة تلقائيًا إذا قمت بإجراء تغييرات على الكود.<br>
سترى أخطاء البناء وتحذيرات الفحص في وحدة التحكم.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='أخطاء البناء'>
</p>

### `npm test` أو `yarn test`

يشغل مراقب الاختبار في وضع تفاعلي.<br>
بشكل افتراضي، يشغل الاختبارات المتعلقة بالملفات التي تم تغييرها منذ آخر التزام.

[اقرأ المزيد عن الاختبار.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` أو `yarn build`

يبني التطبيق للإنتاج في مجلد `build`.<br>
يقوم بتجميع React بشكل صحيح في وضع الإنتاج ويعمل على تحسين البناء للحصول على أفضل أداء.

البناء مضغوط وأسماء الملفات تتضمن تجزئة.<br>

تطبيقك جاهز للنشر.

## دليل المستخدم

يمكنك العثور على تعليمات مفصلة حول استخدام "إنشاء تطبيق React" والعديد من النصائح في [وثائقه](https://facebook.github.io/create-react-app/).

## كيف يتم التحديث إلى الإصدارات الجديدة؟

يرجى الرجوع إلى [دليل المستخدم](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) لهذا وغيرها من المعلومات.

## الفلسفة

- **اعتماد واحد فقط:** هناك اعتماد بناء واحد فقط. يستخدم webpack وBabel وESLint ومشاريع رائعة أخرى، ولكنه يوفر تجربة منسقة ومتماسكة فوقها.

- **لا إعدادات مطلوبة:** لا تحتاج إلى إعداد أي شيء. يتم التعامل مع إعدادات جيدة معقولة لكل من بيئات التطوير والإنتاج بحيث يمكنك التركيز على كتابة الكود.

- **بدون احتجاز:** يمكنك "الاستخراج" لإعداد مخصص في أي وقت. بتشغيل أمر واحد، سيتم نقل جميع الإعدادات واعتمادات البناء مباشرة إلى مشروعك، بحيث يمكنك الاستمرار من حيث توقفت.

## ماذا يتضمن؟

بيئتك ستحتوي على كل ما تحتاجه لبناء تطبيق React حديث بصفحة واحدة:

- دعم React وJSX وES6 وTypeScript وFlow.
- ميزات لغة إضافية تتجاوز ES6 مثل عامل نشر الكائنات.
- CSS مع بادئات تلقائية، لذلك لا تحتاج إلى `-webkit-` أو بادئات أخرى.
- أداة اختبار وحدات تفاعلية سريعة مع دعم مدمج لتقارير التغطية.
- خادم تطوير مباشر يحذرك من الأخطاء الشائعة.
- نص بناء لتجميع JS وCSS والصور للإنتاج، مع تجزئات وخرائط المصدر.
- [عامل خدمة](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) يدعم العمل دون اتصال و[بيان تطبيق ويب](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/)، يفي بجميع معايير [تطبيق الويب التقدمي](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_ملاحظة: استخدام عامل الخدمة اختياري بدءًا من `react-scripts@2.0.0` وما فوق_)
- تحديثات سهلة للأدوات أعلاه باعتماد واحد فقط.

اطلع على [هذا الدليل](https://github.com/nitishdayal/cra_closer_look) لمحة عامة عن كيفية تكامل هذه الأدوات معًا.

المقايضة هي أن **هذه الأدوات معدة مسبقًا للعمل بطريقة محددة**. إذا كان مشروعك يحتاج إلى تخصيص أكثر، يمكنك ["الاستخراج"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) وتخصيصه، ولكن سيتعين عليك عندها صيانة هذا الإعداد بنفسك.

## بدائل شائعة

"إنشاء تطبيق React" مناسب لـ:

- **تعلم React** في بيئة تطوير مريحة وغنية بالميزات.
- **بدء تطبيقات React جديدة بصفحة واحدة.**
- **إنشاء أمثلة** بمكتباتك أو مكوناتك باستخدام React.

وفيما يلي بعض الحالات الشائعة التي قد ترغب فيها بتجربة شيء آخر:

- إذا كنت تريد **تجربة React** بدون مئات من اعتمادات أدوات البناء التبادلية، فكر في [استخدام ملف HTML واحد أو صندوق رملي عبر الإنترنت بدلاً من ذلك](https://reactjs.org/docs/getting-started.html#try-react).

- إذا كنت بحاجة إلى **دمج كود React مع إطار قوالب جانبي الخادم** مثل Rails أو Django أو Symfony، أو إذا كنت **لا تبني تطبيق صفحة واحدة**، فكر في استخدام [nwb](https://github.com/insin/nwb)، أو [Neutrino](https://neutrino.js.org/) الأكثر مرونة. بالنسبة لـ Rails تحديدًا، يمكنك استخدام [Rails Webpacker](https://github.com/rails/webpacker). أما Symfony فجرب [webpack Encore الخاص بـ Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- إذا كنت بحاجة إلى **نشر مكون React**، [nwb](https://github.com/insin/nwb) يمكنه [القيام بذلك أيضًا](https://github.com/insin/nwb#react-components-and-libraries)، بالإضافة إلى [إعداد react-components في Neutrino](https://neutrino.js.org/packages/react-components/).

- إذا كنت ترغب في **عرض الخادم** باستخدام React وNode.js، اطلع على [Next.js](https://nextjs.org/) أو [Razzle](https://github.com/jaredpalmer/razzle). "إنشاء تطبيق React" محايد تجاه الخلفية، وينتج فقط حزم HTML/JS/CSS ثابتة.

- إذا كان موقعك **ثابتًا في الغالب** (مثلاً، معرض أعمال أو مدونة)، فكر في استخدام [Gatsby](https://www.gatsbyjs.org/) أو [Next.js](https://nextjs.org/). على عكس "إنشاء تطبيق React"، يقوم Gatsby بتوليد HTML عند البناء. يدعم Next.js كل من العرض على الخادم والتوليد المسبق.

- أخيرًا، إذا كنت بحاجة إلى **تخصيص أكثر**، اطلع على [Neutrino](https://neutrino.js.org/) و[إعداد React الخاص به](https://neutrino.js.org/packages/react/).

كل الأدوات أعلاه يمكنها العمل بإعداد بسيط أو بدون إعداد.

إذا كنت تفضل إعداد البناء بنفسك، [اتبع هذا الدليل](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

تبحث عن شيء مشابه ولكن لـ React Native؟<br>
اطلع على [Expo CLI](https://github.com/expo/expo-cli).

## المساهمة

نرحب بمساهمتك في `create-react-app`! راجع [CONTRIBUTING.md](CONTRIBUTING.md) لمزيد من المعلومات حول ما نبحث عنه وكيفية البدء.

## دعم "إنشاء تطبيق React"

"إنشاء تطبيق React" مشروع تديره المجتمع وجميع المساهمين فيه متطوعون. إذا كنت ترغب في دعم تطوير "إنشاء تطبيق React" في المستقبل، يرجى التفكير في التبرع إلى [Open Collective](https://opencollective.com/create-react-app) الخاص بنا.

## الاعتمادات

هذا المشروع موجود بفضل كل من [ساهم](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

شكرًا لـ [Netlify](https://www.netlify.com/) لاستضافتها وثائقنا.

## الشكر والتقدير

نحن ممتنون لمؤلفي المشاريع ذات الصلة القائمة على أفكارهم وتعاونهم:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## الرخصة

"إنشاء تطبيق React" برنامج مفتوح المصدر [مرخص بموجب MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). شعار "إنشاء تطبيق React" مرخص بموجب [رخصة المشاع الإبداعي النسبية 4.0 الدولية](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---