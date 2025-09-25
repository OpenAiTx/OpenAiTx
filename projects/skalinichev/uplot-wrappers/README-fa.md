<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# بسته‌های uPlot

مجموعه‌ای از بسته‌های [uPlot](https://github.com/leeoniya/uPlot 'uPlot') که به شما امکان می‌دهد به صورت اعلانی با نمودارها در فریم‌ورک دلخواه خود کار کنید.

**فهرست مطالب**

-   [انگیزه](#motivation)
-   [شروع کار](#getting-started)

-   [ری‌اکت](#react)
    -   [نصب](#installation)
    -   [نحوه استفاده](#how-to-use)
    -   [دمو](#demo)
-   [ویو جی‌اس](#vuejs)
    -   [نصب](#installation-1)
    -   [نحوه استفاده](#how-to-use-1)
    -   [دمو](#demo-1)
-   [سولت](#svelte)
    -   [نصب](#installation-2)
    -   [نحوه استفاده](#how-to-use-2)
    -   [دمو](#demo-2)
-   [مستندات](#documentation)

# انگیزه

در حالی که چندین wrapper دیگر برای uPlot موجود است، همه آن‌ها یکی از محدودیت‌های زیر را دارند:

1. آن‌ها یک نمونه uPlot را فقط یک بار، هنگام mount شدن کامپوننت ایجاد می‌کنند و انتظار دارند تمام منطق به‌روزرسانی را خودتان مدیریت کنید.
2. هر بار که props تغییر کند، نمونه uPlot را مجدداً ایجاد می‌کنند، حتی اگر بتوان نمونه را به‌روزرسانی کرد تا تغییرات منعکس شود.

در مقایسه، این کتابخانه تلاش می‌کند تا حد امکان پس از تغییر props نمونه uPlot را مجدداً ایجاد نکند. به جای ایجاد مجدد، سعی می‌کند از API عمومی uPlot برای به‌روزرسانی نمونه متناسب با props استفاده کند.

# شروع به کار

بخش‌های [ری‌اکت](#react)، [ویو جی‌اس](#vuejs) یا [سولت](#svelte) را بسته به فریم‌ورکی که استفاده می‌کنید، مشاهده کنید.
همچنین مستندات API [مستندات](#documentation) مشترک بین همه فریم‌ورک‌ها را ببینید.

# ری‌اکت

## نصب

پکیج uplot-react را همراه با وابستگی uplot نصب کنید:

-   با استفاده از npm: `$ npm install uplot-react uplot`
-   با استفاده از yarn: `$ yarn add uplot-react uplot`

همچنین باید React نسخه ۱۶.۸ یا بالاتر را در پروژه خود نصب کرده باشید.

## نحوه استفاده

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```
## دمو

دموی [زنده را مشاهده کنید](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'دموی زنده')

همچنین می‌توانید برنامه‌ی دمو را به صورت محلی اجرا کنید:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### دموی ReactJS

مثالی ساده برای شروع سریع.
[دموی ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'دموی ReactJS')

![تصویر](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## نصب

پکیج uplot-vue را همراه با وابستگی uplot نصب کنید:

-   با استفاده از npm: `$ npm install uplot-vue uplot`
-   با استفاده از yarn: `$ yarn add uplot-vue uplot`

همچنین باید Vue.js را در شاخه پروژه خود نصب داشته باشید (هر دو نسخه ۲.۶ و ۳.x پشتیبانی می‌شوند).

## نحوه استفاده

با استفاده از template


```html
<template>
    <UplotVue :data="data" :options="options" :target="target" @create="onCreate" @delete="onDelete" />
</template>
<script>
    // Vue.js 2
    import Vue from 'vue';
    // Vue.js 3
    import { createApp } from 'vue';
    import uPlot from 'uplot';
    import UplotVue from 'uplot-vue';
    import 'uplot/dist/uPlot.min.css';

    // Vue.js 2
    const Chart = Vue.extend({ components: { uplotvue: UplotVue } });
    // Vue.js 3
    const Chart = createApp({ components: { uplotvue: UplotVue } });
</script>
```
استفاده از JSX


```javascript
// Vue.js 2
import Vue from 'vue';
// Vue.js 3
import { createApp } from 'vue';
import uPlot from 'uplot';
import UplotVue from 'uplot-vue';
import 'uplot/dist/uPlot.min.css';

{
    ...,
    render() {
        return (
            <UplotVue
                options={options}
                data={data}
                target={target}
                onDelete={(chart) => {}}
                onCreate={(chart) => {}}
            />
        );
    }
}
```

> توجه: تغییر خصوصیت‌ها با Mutation پشتیبانی نمی‌شود به دلیل [محدودیت Vue](https://github.com/vuejs/vue/issues/2164). شما باید یک کپی از خصوصیت ایجاد کنید، یعنی آن را جایگزین کنید. برای آشنایی بیشتر به [این مثال](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) مراجعه کنید.

## دموی نمونه

[دموی زنده Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'دموی زنده Vue.js 2') را مشاهده کنید.

همچنین می‌توانید برنامه دموی نمونه را به صورت محلی اجرا کنید:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## نصب

پکیج uplot-svelte را همراه با وابستگی uplot نصب کنید:

-   با استفاده از npm: `$ npm install uplot-svelte uplot`
-   با استفاده از yarn: `$ yarn add uplot-svelte uplot`

همچنین لازم است Svelte در ساختار پروژه شما نصب شده باشد. کامپوننت UplotSvelte با پروژه‌های Svelte و SvelteKit سازگار است.

## نحوه استفاده

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## دموی

نمونه [مثال Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'مثال Svelte') را ببینید

همچنین می‌توانید برنامه دموی را به صورت محلی اجرا کنید:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# مستندات

|    پارامتر      | الزامی بودن | توضیحات                                                                                                                                                                                             |
| :-------------: | :---------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |   الزامی    | گزینه‌های uPlot. به عنوان آرگومان اول به سازنده uPlot ارسال می‌شود: `new uPlot(options)`                                                                                                            |
|      data       |   الزامی    | داده‌های uPlot. به عنوان آرگومان دوم به سازنده uPlot ارسال می‌شود: `new uPlot(options, data)`                                                                                                       |
|     target      |  اختیاری    | عنصر html هدف برای uPlot. به عنوان آرگومان سوم به سازنده uPlot ارسال می‌شود: `new uPlot(options, data, target)` اگر هیچ مقدار هدفی در props ارسال نشود، یک عنصر div جدید به طور خودکار ساخته می‌شود |
|    onCreate     |  اختیاری    | تابع callback که هنگام ایجاد یا بازسازی نمونه uPlot فراخوانی می‌شود                                                                                                                                  |
|    onDelete     |  اختیاری    | تابع callback که قبل از نابودی نمونه uPlot فراخوانی می‌شود، یا به دلیل تغییر زیاد props به حدی که بروزرسانی نمودار ممکن نیست یا به دلیل خارج شدن کامپوننت از DOM                                   |
| className/class |  اختیاری    | نام کلاس که به عنصر div هدف ساخته شده به طور خودکار اختصاص می‌یابد. زمانی که prop 'target' استفاده شود نام کلاس نادیده گرفته می‌شود.                                                               |
|   resetScales   |  اختیاری    | فلگی برای کنترل بازنشانی مقیاس‌ها هنگام تغییر داده. مقدار پیش‌فرض true است.                                                                                                                          |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---