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

انگلیسی | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

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

## مقدمه

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) یک راهکار آماده برای رابط‌های مدیریتی سمت فرانت‌اند است. این پروژه بر اساس [vue](https://github.com/vuejs/vue) ساخته شده و از کیت رابط کاربری [element-ui](https://github.com/ElemeFE/element) استفاده می‌کند.

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) بر پایه جدیدترین استک توسعه Vue بوده و دارای راهکار داخلی i18n، قالب‌های متداول برای برنامه‌های سازمانی و امکانات فوق‌العاده زیادی است. این پروژه به شما کمک می‌کند تا برنامه‌های تک‌صفحه‌ای بزرگ و پیچیده بسازید. باور دارم صرف‌نظر از نیازتان، این پروژه به شما کمک خواهد کرد.

- [پیش‌نمایش](https://panjiachen.github.io/vue-element-admin)

- [مستندات](https://panjiachen.github.io/vue-element-admin-site/)

- [گیتتر](https://gitter.im/vue-element-admin/discuss)

- [حمایت مالی](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [ویکی](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) کاربران داخل چین می‌توانند از این آدرس نسخه آنلاین را مشاهده کنند

- قالب پایه توصیه‌شده: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- دسکتاپ: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- تایپ‌اسکریپت: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (اعتبار: [@Armour](https://github.com/Armour))
- [پروژه‌های عالی](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**از نسخه `v4.1.0+` به بعد، شاخه اصلی (master) به طور پیش‌فرض از i18n پشتیبانی نمی‌کند. لطفاً از [شاخه i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n) استفاده کنید، این شاخه با به‌روزرسانی‌های master هماهنگ خواهد بود**

**نسخه فعلی `v4.0+` بوده و بر پایه `vue-cli` ساخته شده است. اگر مشکلی یافتید، لطفاً [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new) ثبت کنید. اگر می‌خواهید نسخه قدیمی را استفاده کنید، می‌توانید به شاخه [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) سوئیچ کنید که به `vue-cli` وابسته نیست**

**این پروژه از مرورگرهای قدیمی (مانند IE) پشتیبانی نمی‌کند. لطفاً polyfill را خودتان اضافه کنید.**

## پیش‌نیازها

شما باید [node](https://nodejs.org/) و [git](https://git-scm.com/) را به صورت محلی نصب کنید. این پروژه بر پایه [ES2015+](https://es6.ruanyifeng.com/)، [vue](https://cn.vuejs.org/index.html)، [vuex](https://vuex.vuejs.org/zh-cn/)، [vue-router](https://router.vuejs.org/zh-cn/)، [vue-cli](https://github.com/vuejs/vue-cli)، [axios](https://github.com/axios/axios) و [element-ui](https://github.com/ElemeFE/element) است و تمام داده‌های درخواست با استفاده از [Mock.js](https://github.com/nuysoft/Mock) شبیه‌سازی می‌شوند.
یادگیری و درک این مباحث پیش از شروع، بسیار در استفاده از این پروژه کمک‌کننده خواهد بود.

[![ویرایش در CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## حامیان

حامی پروژه شوید و لوگوی خود را با لینک به سایت‌تان در README ما در گیت‌هاب قرار دهید. [[حامی شوید]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>بک‌اند جاوا برای Vue admin با ۲۰٪ تخفیف تنها ۳۹ دلار (کد تخفیف: SWB0RAZPZR1M)
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>قالب‌های داشبورد مدیریتی ساخته شده با Vue، React و Angular.</p>

## امکانات

```
- ورود / خروج

- احراز هویت مجوزها
  - مجوز صفحه
  - مجوز دایرکتیو
  - صفحه پیکربندی مجوزها
  - ورود دو مرحله‌ای

- ساخت چندمحیطی
  - توسعه (dev)
  - sit
  - تست مرحله‌ای (stage)
  - تولید (prod)

- امکانات سراسری
  - i18n
  - چندین تم پویا
  - سایدبار پویا (پشتیبانی از مسیریابی چندسطحی)
  - نان‌بر پویا
  - نمای برگه (پشتیبانی از عملیات راست‌کلیک)
  - Svg Sprite
  - داده‌های Mock
  - Screenfull
  - سایدبار واکنش‌گرا

- ویرایشگر
  - ویرایشگر متن غنی
  - ویرایشگر Markdown
  - ویرایشگر JSON

- اکسل
  - خروجی اکسل
  - بارگذاری اکسل
  - اکسل تصویری
  - خروجی zip

- جدول
  - جدول پویا
  - جدول کشیدنی و رها کردنی
  - ویرایش درون‌خطی جدول

- صفحه خطا
  - 401
  - 404

- کامپوننت‌ها
  - آپلود آواتار
  - بازگشت به بالا
  - دیالوگ کشیدنی
  - انتخاب کشیدنی
  - کانبان کشیدنی
  - لیست کشیدنی
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- مثال‌های پیشرفته
- لاگ خطا
- داشبورد
- صفحه راهنما
- ECharts
- کلیپ‌بورد
- تبدیل Markdown به html
```

## شروع کار

```bash
# کلون کردن پروژه
git clone https://github.com/PanJiaChen/vue-element-admin.git

# ورود به دایرکتوری پروژه
cd vue-element-admin

# نصب وابستگی‌ها
npm install

# توسعه
npm run dev
```

این دستور به طور خودکار http://localhost:9527 را باز می‌کند

## ساخت

```bash
# ساخت برای محیط تست
npm run build:stage

# ساخت برای محیط تولید
npm run build:prod
```

## امکانات پیشرفته

```bash
# پیش‌نمایش خروجی محیط انتشار
npm run preview

# پیش‌نمایش + تحلیل منابع استاتیک
npm run preview -- --report

# بررسی فرمت کد
npm run lint

# بررسی فرمت کد و اصلاح خودکار
npm run lint -- --fix
```

برای اطلاعات بیشتر به [مستندات](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) مراجعه کنید

## تاریخچه تغییرات

تغییرات جزئی هر نسخه در [یادداشت‌های انتشار](https://github.com/PanJiaChen/vue-element-admin/releases) مستند شده‌اند.

## نسخه نمایشی آنلاین

[پیش‌نمایش](https://panjiachen.github.io/vue-element-admin)

## حمایت مالی

اگر این پروژه برای شما مفید بود، می‌توانید برای نویسنده یک لیوان آبمیوه بخرید :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[پرداخت با پی‌پال](https://www.paypal.me/panfree23)

[برای من قهوه بخر](https://www.buymeacoffee.com/Pan)

## پشتیبانی مرورگرها

مرورگرهای مدرن و اینترنت اکسپلورر ۱۰ به بالا.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10، IE11، Edge | دو نسخه آخر | دو نسخه آخر | دو نسخه آخر |

## مجوز

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

کپی‌رایت (c) 2017-تاکنون PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---