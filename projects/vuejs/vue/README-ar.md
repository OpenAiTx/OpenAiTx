## لقد وصل Vue 2 إلى نهاية دورة حياته

**أنت تنظر الآن إلى مستودع Vue 2 غير النشط. المستودع الذي يتم صيانته بنشاط لأحدث إصدار من Vue هو [vuejs/core](https://github.com/vuejs/core).**

وصل Vue إلى نهاية دورة حياته في 31 ديسمبر 2023. لم يعد يتلقى ميزات أو تحديثات أو إصلاحات جديدة. ومع ذلك، لا يزال متاحًا على جميع قنوات التوزيع الحالية (CDNs، ومديري الحزم، وGithub، وما إلى ذلك).

إذا كنت تبدأ مشروعًا جديدًا، يرجى البدء بأحدث إصدار من Vue (3.x). نوصي بشدة أيضًا لمستخدمي Vue 2 الحاليين بالترقية ([الدليل](https://v3-migration.vuejs.org/))، ولكننا ندرك أيضًا أن ليس جميع المستخدمين لديهم الوقت أو الدافع للقيام بذلك. إذا اضطررت للبقاء على Vue 2 ولكن لديك متطلبات امتثال أو أمان تتعلق بالبرمجيات غير المدعومة، اطلع على [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="شعار Vue"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="حالة البناء"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="حالة التغطية"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="عدد التحميلات"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="الإصدار"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="الرخصة"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="الدردشة"></a>
</p>

## الرعاة

Vue.js هو مشروع مفتوح المصدر مرخص بموجب MIT، واستمرار تطويره ممكن بالكامل بفضل دعم هؤلاء [الداعمين الرائعين](https://github.com/vuejs/core/blob/main/BACKERS.md). إذا كنت ترغب في الانضمام إليهم، يرجى النظر في [رعاية تطوير Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">راعي خاص</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="راعي خاص appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="الرعاة" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## المقدمة

Vue (تُنطق `/vjuː/` مثل view) هو **إطار عمل تدريجي** لبناء واجهات المستخدم. تم تصميمه من البداية ليكون قابلاً للاعتماد عليه بشكل تدريجي، ويمكنه التدرج بسهولة بين مكتبة وإطار عمل حسب الحالات المختلفة. يتكون من مكتبة أساسية سهلة الاستخدام تركز فقط على طبقة العرض، ونظام بيئي من المكتبات الداعمة التي تساعدك على التعامل مع التعقيد في تطبيقات الصفحة الواحدة الكبيرة.

#### توافق المتصفح

يدعم Vue.js جميع المتصفحات التي تدعم [ES5](https://compat-table.github.io/compat-table/es5/) (لا يتم دعم IE8 وما دونه).

## النظام البيئي

| المشروع              | الحالة                                                        | الوصف                                                  |
| -------------------- | ------------------------------------------------------------ | ------------------------------------------------------ |
| [vue-router]         | [![vue-router-status]][vue-router-package]                   | توجيه تطبيق الصفحة الواحدة                             |
| [vuex]               | [![vuex-status]][vuex-package]                               | إدارة الحالة على نطاق واسع                             |
| [vue-cli]            | [![vue-cli-status]][vue-cli-package]                         | إنشاء هيكل المشروع                                     |
| [vue-loader]         | [![vue-loader-status]][vue-loader-package]                   | محمل مكون الملف الواحد (`*.vue`) لـ webpack            |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | دعم التصيير من جهة الخادم                              |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | ديكوراتور TypeScript لواجهة برمجة التطبيقات المعتمدة على الكلاس |
| [vue-rx]             | [![vue-rx-status]][vue-rx-package]                           | تكامل RxJS                                             |
| [vue-devtools]       | [![vue-devtools-status]][vue-devtools-package]               | إضافة أدوات المطورين للمتصفح                           |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## التوثيق

للاطلاع على [الأمثلة الحية](https://v2.vuejs.org/v2/examples/) والتوثيق، قم بزيارة [vuejs.org](https://v2.vuejs.org).

## الأسئلة

للاستفسارات والدعم، يرجى استخدام [المنتدى الرسمي](https://forum.vuejs.org) أو [دردشة المجتمع](https://chat.vuejs.org/). قائمة القضايا في هذا المستودع مخصصة **حصريًا** لتقارير الأخطاء وطلبات الميزات.

## القضايا

يرجى التأكد من قراءة [قائمة التحقق لإبلاغ القضايا](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) قبل فتح أي قضية. قد يتم إغلاق القضايا التي لا تتوافق مع الإرشادات فورًا.

## سجل التغييرات

التغييرات المفصلة لكل إصدار موثقة في [ملاحظات الإصدار](https://github.com/vuejs/vue/releases).

## ابقَ على تواصل

- [تويتر](https://twitter.com/vuejs)
- [المدونة](https://medium.com/the-vue-point)
- [لوحة الوظائف](https://vuejobs.com/?ref=vuejs)

## المساهمة

يرجى التأكد من قراءة [دليل المساهمة](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) قبل إرسال طلب سحب. إذا كان لديك مشروع/مكون/أداة متعلقة بـ Vue، أضفه بطلب سحب إلى [هذه القائمة المختارة](https://github.com/vuejs/awesome-vue)!

شكرًا لكل من ساهم بالفعل في Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## الرخصة

[MIT](https://opensource.org/licenses/MIT)

حقوق النشر (c) 2013-حتى الآن، يوكسى (إيفان) يو

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---