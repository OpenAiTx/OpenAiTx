## Vue 2 به پایان عمر خود رسیده است

**شما در حال مشاهده مخزن غیر فعال Vue 2 هستید. مخزن فعال و نگهداری شده برای آخرین نسخه Vue در [vuejs/core](https://github.com/vuejs/core) قرار دارد.**

Vue در تاریخ ۳۱ دسامبر ۲۰۲۳ به پایان عمر خود رسید. این نسخه دیگر ویژگی جدید، به‌روزرسانی یا رفع اشکالی دریافت نمی‌کند. با این حال، همچنان از طریق تمام کانال‌های توزیع موجود (CDNها، مدیر بسته‌ها، گیت‌هاب و غیره) در دسترس است.

اگر قصد شروع یک پروژه جدید را دارید، لطفاً کار خود را با آخرین نسخه Vue (نسخه ۳.x) آغاز کنید. همچنین به کاربران فعلی Vue 2 به شدت توصیه می‌کنیم که به نسخه جدید مهاجرت کنند ([راهنما](https://v3-migration.vuejs.org/))، اما درک می‌کنیم که همه کاربران امکان یا انگیزه انجام این کار را ندارند. اگر باید روی Vue 2 باقی بمانید اما نیازهای امنیتی یا تطابق با نرم‌افزارهای بدون نگهداری دارید، به [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme) مراجعه کنید.

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## حامیان مالی

Vue.js یک پروژه متن‌باز با مجوز MIT است که توسعه آن کاملاً به لطف حمایت این [حامیان](https://github.com/vuejs/core/blob/main/BACKERS.md) شگفت‌انگیز ادامه دارد. اگر مایل به پیوستن به جمع آن‌ها هستید، لطفاً [در حمایت از توسعه Vue مشارکت کنید](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">حامی ویژه</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## مقدمه

Vue (تلفظ: `/vjuː/` مانند "view") یک **فریم‌ورک پیش‌رونده** برای ساخت رابط‌های کاربری است. این فریم‌ورک از ابتدا به گونه‌ای طراحی شده که به‌صورت تدریجی قابل پذیرش باشد و بسته به کاربردها، به‌راحتی بین یک کتابخانه و یک فریم‌ورک مقیاس‌پذیر است. Vue از یک هسته کتابخانه‌ای ساده که فقط بر لایه نمایش تمرکز دارد و اکوسیستمی از کتابخانه‌های پشتیبان که به شما در مدیریت پیچیدگی برنامه‌های تک‌صفحه‌ای بزرگ کمک می‌کند، تشکیل شده است.

#### سازگاری مرورگر

Vue.js از تمام مرورگرهایی که [با ES5 سازگارند](https://compat-table.github.io/compat-table/es5/) پشتیبانی می‌کند (IE8 و پایین‌تر پشتیبانی نمی‌شوند).

## اکوسیستم

| پروژه                  | وضعیت                                                        | توضیحات                                               |
| ---------------------- | ------------------------------------------------------------ | ------------------------------------------------------ |
| [vue-router]           | [![vue-router-status]][vue-router-package]                   | مسیر‌یابی برنامه تک‌صفحه‌ای                           |
| [vuex]                 | [![vuex-status]][vuex-package]                               | مدیریت وضعیت در مقیاس بزرگ                            |
| [vue-cli]              | [![vue-cli-status]][vue-cli-package]                         | ساختاردهی پروژه                                       |
| [vue-loader]           | [![vue-loader-status]][vue-loader-package]                   | لودر فایل تک‌کامپوننت (`*.vue`) برای وب‌پک            |
| [vue-server-renderer]  | [![vue-server-renderer-status]][vue-server-renderer-package] | پشتیبانی از رندر سمت سرور                             |
| [vue-class-component]  | [![vue-class-component-status]][vue-class-component-package] | دکوراتور TypeScript برای API مبتنی بر کلاس            |
| [vue-rx]               | [![vue-rx-status]][vue-rx-package]                           | یکپارچه‌سازی با RxJS                                   |
| [vue-devtools]         | [![vue-devtools-status]][vue-devtools-package]               | افزونه توسعه‌دهنده برای مرورگر                        |

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

## مستندات

برای مشاهده [نمونه‌های زنده](https://v2.vuejs.org/v2/examples/) و مستندات به [vuejs.org](https://v2.vuejs.org) مراجعه کنید.

## پرسش‌ها

برای پرسش‌ها و پشتیبانی لطفاً از [انجمن رسمی](https://forum.vuejs.org) یا [گفتگوی جامعه](https://chat.vuejs.org/) استفاده کنید. لیست مشکلات این مخزن **منحصراً** برای گزارش اشکال و درخواست ویژگی جدید است.

## مشکلات

لطفاً پیش از ایجاد یک مشکل، [راهنمای گزارش مشکلات](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) را مطالعه فرمایید. مشکلاتی که با این دستورالعمل‌ها مطابقت نداشته باشند ممکن است فوراً بسته شوند.

## تغییرات

تغییرات دقیق هر نسخه در [یادداشت‌های انتشار](https://github.com/vuejs/vue/releases) مستند شده است.

## در ارتباط بمانید

- [توییتر](https://twitter.com/vuejs)
- [وبلاگ](https://medium.com/the-vue-point)
- [تابلوی شغلی](https://vuejobs.com/?ref=vuejs)

## مشارکت

لطفاً پیش از ارسال Pull Request، [راهنمای مشارکت](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) را مطالعه فرمایید. اگر پروژه/کامپوننت/ابزاری مرتبط با Vue دارید، آن را با Pull Request به [این لیست منتخب](https://github.com/vuejs/awesome-vue) اضافه کنید!

از همه کسانی که تاکنون در توسعه Vue مشارکت داشته‌اند سپاسگزاریم!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## مجوز

[MIT](https://opensource.org/licenses/MIT)

کپی‌رایت (c) ۲۰۱۳ تا کنون، یوکسی (ایوان) یو

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---