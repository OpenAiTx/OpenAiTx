<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## المقدمة

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) هو حل جاهز للإنتاج للواجهات الخلفية للإدارة. يعتمد على [vue](https://github.com/vuejs/vue) ويستخدم أداة الواجهات [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) مبني على أحدث حزمة تطوير لـ vue ويدعم الترجمة الدولية (i18n) ويحتوي على قوالب نموذجية لتطبيقات الشركات والعديد من الميزات الرائعة. يساعدك في بناء تطبيقات صفحة واحدة كبيرة ومعقدة. أؤمن بأن هذا المشروع سيساعدك مهما كانت احتياجاتك.

- [معاينة](https://panjiachen.github.io/vue-element-admin)

- [التوثيق](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [تبرع](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [ويكي](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) يمكن للمستخدمين المحليين الوصول إلى هذا العنوان للمعاينة عبر الإنترنت

- يوصى باستخدام القالب الأساسي: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- سطح المكتب: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- تايب سكريبت: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (الشكر لـ: [@Armour](https://github.com/Armour))
- [مشاريع رائعة](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**بعد الإصدار `v4.1.0+`، لن يدعم الفرع الرئيسي الترجمة الدولية (i18n) افتراضيًا. يرجى استخدام [فرع i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)، وسيتم تحديثه بالتوازي مع الفرع الرئيسي**

**الإصدار الحالي هو `v4.0+` مبني على `vue-cli`. إذا وجدت مشكلة، يرجى فتح [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new). إذا أردت استخدام الإصدار القديم، يمكنك التبديل إلى [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0)، وهو لا يعتمد على `vue-cli`**

**هذا المشروع لا يدعم المتصفحات ذات الإصدارات المنخفضة (مثل IE). يرجى إضافة polyfill بنفسك.**

## التحضير

تحتاج إلى تثبيت [node](https://nodejs.org/) و [git](https://git-scm.com/) محليًا. المشروع يعتمد على [ES2015+](https://es6.ruanyifeng.com/)، [vue](https://cn.vuejs.org/index.html)، [vuex](https://vuex.vuejs.org/zh-cn/)، [vue-router](https://router.vuejs.org/zh-cn/)، [vue-cli](https://github.com/vuejs/vue-cli)، [axios](https://github.com/axios/axios) و [element-ui](https://github.com/ElemeFE/element)، جميع بيانات الطلبات يتم محاكاتها باستخدام [Mock.js](https://github.com/nuysoft/Mock).
فهمك لهذه التقنيات مسبقًا سيساعدك كثيرًا في استخدام هذا المشروع.

[![تعديل على CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## الرعاة

كن راعيًا واحصل على شعارك في ملف README على GitHub مع رابط إلى موقعك. [[كن راعيًا]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>احصل على خلفية جافا لـ Vue admin بخصم 20% مقابل 39$ باستخدام كود الكوبون SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>قوالب لوحات تحكم الإدارة مبنية باستخدام Vue وReact وAngular.</p>

## الميزات

```
- تسجيل الدخول / تسجيل الخروج

- مصادقة الصلاحيات
  - صلاحية الصفحة
  - صلاحية التوجيه
  - صفحة إعدادات الصلاحيات
  - تسجيل دخول بخطوتين

- بناء متعدد البيئات
  - تطوير (dev)
  - sit
  - اختبار مرحلة (stage)
  - إنتاج (prod)

- ميزات عامة
  - ترجمة دولية (I18n)
  - عدة ثيمات ديناميكية
  - شريط جانبي ديناميكي (يدعم التوجيه متعدد المستويات)
  - فتات الخبز الديناميكي
  - عرض العلامات (علامة تبويب تدعم النقر بزر الماوس الأيمن)
  - Svg Sprite
  - بيانات وهمية (Mock data)
  - ملء الشاشة (Screenfull)
  - شريط جانبي متجاوب

- المحرر
  - محرر نص منسق
  - محرر Markdown
  - محرر JSON

- إكسل
  - تصدير إلى إكسل
  - رفع ملفات إكسل
  - إكسل مرئي
  - تصدير zip

- الجدول
  - جدول ديناميكي
  - جدول مع سحب وإفلات
  - تحرير الجدول داخل الصف

- صفحة الخطأ
  - 401
  - 404

- المكونات
  - رفع صورة الملف الشخصي
  - العودة للأعلى
  - حوار قابل للسحب
  - تحديد قابل للسحب
  - كانبان قابل للسحب
  - قائمة قابلة للسحب
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- أمثلة متقدمة
- سجل الأخطاء
- لوحة القيادة
- صفحة الإرشاد
- ECharts
- الحافظة
- تحويل Markdown إلى HTML
```

## البدء

```bash
# استنساخ المشروع
git clone https://github.com/PanJiaChen/vue-element-admin.git

# ادخل إلى مجلد المشروع
cd vue-element-admin

# تثبيت التبعيات
npm install

# تطوير
npm run dev
```

سيتم فتح http://localhost:9527 تلقائيًا

## البناء

```bash
# بناء لبيئة الاختبار
npm run build:stage

# بناء لبيئة الإنتاج
npm run build:prod
```

## متقدم

```bash
# معاينة تأثير بيئة الإصدار
npm run preview

# معاينة تأثير بيئة الإصدار + تحليل الموارد الثابتة
npm run preview -- --report

# فحص تنسيق الكود
npm run lint

# فحص تنسيق الكود مع تصحيح تلقائي
npm run lint -- --fix
```

راجع [التوثيق](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) لمزيد من المعلومات

## سجل التغييرات

التغييرات التفصيلية لكل إصدار موثقة في [ملاحظات الإصدار](https://github.com/PanJiaChen/vue-element-admin/releases).

## تجربة مباشرة عبر الإنترنت

[معاينة](https://panjiachen.github.io/vue-element-admin)

## تبرع

إذا وجدت هذا المشروع مفيدًا، يمكنك شراء كوب عصير للمؤلف :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## دعم المتصفحات

المتصفحات الحديثة وإنترنت إكسبلورر 10 فما فوق.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | آخر إصدارين | آخر إصدارين | آخر إصدارين |

## الرخصة

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

حقوق النشر (c) 2017-الآن PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---