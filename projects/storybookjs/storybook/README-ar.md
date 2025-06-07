<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
  </a>
</p>

<p align="center">بناء مكونات واجهة المستخدم المقاومة للأخطاء بشكل أسرع</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="حالة البناء على CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="الترخيص" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="مجتمع Storybook" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="الداعمون على Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="الرعاة على Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="الحساب الرسمي على تويتر" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
ستوريبوك هو ورشة عمل للواجهة الأمامية لبناء مكونات واجهة المستخدم والصفحات بشكل معزول. يستخدمه آلاف الفرق لتطوير واختبار وتوثيق واجهات المستخدم. اكتشف المزيد على https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  اعرض ملف README لـ:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="الأحدث"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="التالي"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## جدول المحتويات

- 🚀 [البدء السريع](#getting-started)
- 📒 [المشاريع](#projects)
  - 🛠 [الأطر المدعومة والأمثلة](#supported-frameworks)
  - 🔗[الإضافات](#addons)
- 🏅 [الشارات ومواد العرض التقديمي](#badges--presentation-materials)
- 👥 [المجتمع](#community)
- 👏 [المساهمة](#contributing)
  - 👨‍💻 [سكريبتات التطوير](#development-scripts)
  - 💸 [الرعاة](#sponsors)
  - 💵 [الداعمون](#backers)
- :memo: [الترخيص](#license)

## البدء السريع

قم بزيارة [موقع Storybook](https://storybook.js.org) لمعرفة المزيد والبدء.

### التوثيق

يمكنك العثور على التوثيق في [موقع توثيق Storybook](https://storybook.js.org/docs).

### الأمثلة

اعرض [موسوعة المكونات](https://storybook.js.org/showcase) لترى كيف تستخدم الفرق الرائدة Storybook.

استخدم [storybook.new](https://storybook.new) لإنشاء مشروع نموذجي بسرعة على Stackblitz.

يأتي Storybook مع العديد من [الإضافات](https://storybook.js.org/docs/configure/user-interface/storybook-addons) لتصميم المكونات، والتوثيق، والاختبار، والتفاعلية، وغيرها. يتيح لك API الخاص بـ Storybook إمكانية التكوين والتوسعة بطرق متعددة. وقد تم توسيعه حتى لدعم تطوير React Native وAndroid وiOS وFlutter للجوال.

### المجتمع

للمساعدة الإضافية، شارك مشكلتك في [مناقشات GitHub للمستودع](https://github.com/storybookjs/storybook/discussions/new?category=help).

## المشاريع

### الأطر المدعومة

| محرك العرض                                                        | العرض التوضيحي                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![عرض Storybook](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### الإضافات

| الإضافة                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | اختبار المكونات من حيث سهولة الوصول للمستخدمين في Storybook                        |
| [actions](code/core/src/actions/)                                         | تسجيل الأحداث أثناء تفاعل المستخدمين مع المكونات في واجهة Storybook          |
| [backgrounds](code/core/src/backgrounds)                                  | السماح للمستخدمين باختيار الخلفيات في واجهة Storybook                           |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | إضافة/إزالة موارد CSS ديناميكياً إلى إطار المكون               |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | عرض الصور ومقاطع الفيديو والروابط بجانب قصتك                     |
| [docs](code/addons/docs/)                                                 | إضافة توثيق عالي الجودة لمكوناتك                          |
| [events](https://github.com/storybookjs/addon-events)                     | إطلاق الأحداث بشكل تفاعلي للمكونات التي تستجيب لـ EventEmitter       |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | تقارير تحليلات Google على القصص                                        |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | استعلام خادم GraphQL ضمن قصص Storybook                            |
| [jest](code/addons/jest/)                                                 | عرض نتائج اختبارات الوحدة للمكونات في Storybook                    |
| [links](code/addons/links/)                                               | إنشاء روابط بين القصص                                               |
| [measure](code/core/src/measure/)                                         | فحص مرئي لتخطيط الصندوق والنموذج داخل واجهة Storybook          |
| [outline](code/core/src/outline/)                                         | تصحيح تخطيط CSS والمحاذاة بصريًا داخل واجهة Storybook        |
| [query params](https://github.com/storybookjs/addon-queryparams)          | محاكاة معلمات الاستعلام                                                          |
| [viewport](code/core/src/viewport/)                                       | تغيير أحجام العرض والتخطيطات للمكونات المستجيبة باستخدام Storybook |

اطلع على [جدول دعم الإضافات/الأطر](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

لتحسين تجربتك باستمرار، يجب علينا في النهاية إيقاف أو إزالة بعض الإضافات لصالح أدوات أحدث وأفضل.

إذا كنت تستخدم info/notes، نوصيك بشدة بالانتقال إلى [docs](code/addons/docs/)، [وهنا دليل](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) لمساعدتك.

إذا كنت تستخدم contexts، نوصيك بشدة بالانتقال إلى [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) و[هنا دليل](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) لمساعدتك.

إذا كنت تستخدم addon-storyshots، نوصيك بشدة بالانتقال إلى [test-runner](https://github.com/storybookjs/test-runner) الخاص بـ Storybook و[هنا دليل](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) لمساعدتك.

## الشارات ومواد العرض التقديمي

لدينا شارة! اربطها بمثال Storybook المباشر الخاص بك.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](رابط للموقع)
```

إذا كنت تبحث عن مواد لعرضك التقديمي لـ Storybook، مثل الشعارات، أو مواد الفيديو، أو الألوان التي نستخدمها، يمكنك العثور عليها جميعًا في [مستودع العلامة التجارية الخاص بنا](https://github.com/storybookjs/brand).

## المجتمع

- التغريد عبر [@storybookjs](https://x.com/storybookjs)
- التدوين على [storybook.js.org](https://storybook.js.org/blog/) و[Medium](https://medium.com/storybookjs)
- الدردشة على [Discord](https://discord.gg/storybook)
- مقاطع الفيديو والبث على [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## المساهمة

المساهمات في Storybook مرحب بها دائمًا!

- 📥 طلبات السحب و 🌟 النجوم مرحب بها دائمًا.
- اقرأ [دليل المساهمة](CONTRIBUTING.md) للبدء،
  أو تواصل معنا على [Discord](https://discord.gg/storybook)، سنأخذ الوقت لإرشادك.

تبحث عن أول مشكلة تتعامل معها؟

- نضع علامات على المشاكل بـ [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) عندما نعتقد أنها مناسبة للأشخاص الجدد على قاعدة الشيفرة أو البرمجيات مفتوحة المصدر بشكل عام.
- [تحدث معنا](https://discord.gg/storybook)، سنجد شيئًا يناسب مهاراتك واهتماماتك في التعلم.

### سكريبتات التطوير

يُنظم Storybook كمستودع أحادي. من السكريبتات المفيدة:

#### `yarn start`

> يشغّل Storybook نموذجي للتجربة مع قصص اختبارية

#### `yarn task`

> كما أعلاه، ولكنه يمنحك خيارات لتخصيص النموذج (مثل اختيار أطر أخرى)

#### `yarn lint`

> التحقق المنطقي إذا كان الكود يلتزم بقواعد الفحص - يستخدم remark و eslint

- `yarn lint:js` - سيفحص ملفات js
- `yarn lint:md` - سيفحص ملفات markdown وعينات الكود
- `yarn lint:js --fix` - سيصلح js تلقائيًا

#### `yarn test`

> التحقق المنطقي إذا كانت جميع اختبارات الوحدة ناجحة - يستخدم jest

- `yarn run test --core --watch` - سيشغل اختبارات النواة بوضع المراقبة

### الرعاة

كن راعياً ليظهر شعارك ورابط موقعك في ملف README لدينا على Github. \[[كن راعياً](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### الداعمون

من خلال تبرع متكرر، يمكنك دعمنا ودعم عملنا. \[[كن داعمًا](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## الترخيص

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-النهاية-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---