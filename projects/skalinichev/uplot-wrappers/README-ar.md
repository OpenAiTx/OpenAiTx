<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# أغلفة uPlot

مجموعة من أغلفة [uPlot](https://github.com/leeoniya/uPlot 'uPlot') التي تتيح لك العمل مع المخططات بشكل إعلاني داخل إطار العمل المفضل لديك.

**جدول المحتويات**

-   [الدوافع](#motivation)
-   [البدء السريع](#getting-started)

-   [React](#react)
    -   [التثبيت](#installation)
    -   [كيفية الاستخدام](#how-to-use)
    -   [عرض توضيحي](#demo)
-   [Vue.js](#vuejs)
    -   [التثبيت](#installation-1)
    -   [كيفية الاستخدام](#how-to-use-1)
    -   [عرض توضيحي](#demo-1)
-   [Svelte](#svelte)
    -   [التثبيت](#installation-2)
    -   [كيفية الاستخدام](#how-to-use-2)
    -   [عرض توضيحي](#demo-2)
-   [التوثيق](#documentation)

# الدافع

بينما توجد بالفعل العديد من الأغلفة الأخرى لـ uPlot، جميعها تعاني من واحدة من القيود التالية:

1. يقومون بإنشاء كائن uPlot مرة واحدة فقط، أثناء مرحلة تثبيت المكون، ويتوقعون منك إدارة كل منطق التحديث بنفسك.
2. يقومون بإعادة إنشاء كائن uPlot من جديد في كل مرة تتغير فيها الخصائص، حتى لو كان بالإمكان تحديث الكائن ليعكس التغييرات.

بالمقارنة، يحاول هذا المكتبة جاهداً عدم إعادة إنشاء كائن uPlot عندما تتغير الخصائص. بدلاً من إعادة الإنشاء، تحاول استخدام واجهة برمجة التطبيقات العامة لـ uPlot لإبقائه محدثاً مع الخصائص.

# البدء

انظر إلى أقسام [React](#react)، [Vue.js](#vuejs) أو [Svelte](#svelte) أدناه حسب الإطار الذي تستخدمه.
راجع أيضاً [التوثيق](#documentation) الخاص بواجهة البرمجة والمشترك بين جميع الأطر.

# React

## التثبيت

قم بتثبيت حزمة uplot-react مع الاعتماد على uplot:

-   باستخدام npm: `$ npm install uplot-react uplot`
-   باستخدام yarn: `$ yarn add uplot-react uplot`

تحتاج أيضاً إلى تثبيت React 16.8 أو أعلى ضمن شجرة مشروعك.

## كيفية الاستخدام

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## العرض التوضيحي

شاهد [العرض التوضيحي المباشر](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'العرض التوضيحي المباشر')

يمكنك أيضًا تشغيل تطبيق العرض التوضيحي محليًا:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### عرض ReactJS توضيحي

مثال بسيط للبدء بسرعة.
[عرض ReactJS التوضيحي](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'عرض ReactJS التوضيحي')

![صورة](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## التثبيت

قم بتثبيت حزمة uplot-vue مع الاعتماد على uplot:

-   باستخدام npm: `$ npm install uplot-vue uplot`
-   باستخدام yarn: `$ yarn add uplot-vue uplot`

يجب أيضًا تثبيت Vue.js ضمن شجرة مشروعك (يتم دعم الإصدارات 2.6 و 3.x معًا).

## كيفية الاستخدام

باستخدام القالب

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

استخدام JSX

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

> ملاحظة: تغييرات الخاصية عن طريق التحوير غير مدعومة بسبب [محدودية Vue](https://github.com/vuejs/vue/issues/2164). عليك إنشاء نسخة من الخاصية، أي استبدالها بدلاً من ذلك، راجع [مثال](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) للفكرة العامة.

## العرض التوضيحي

شاهد [العرض الحي لـ Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'العرض الحي لـ Vue.js 2')

يمكنك أيضًا تشغيل تطبيق العرض التوضيحي محليًا:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# سـفلت

## التثبيت

ثبت حزمة uplot-svelte مع اعتماد uplot:

-   باستخدام npm: `$ npm install uplot-svelte uplot`
-   باستخدام yarn: `$ yarn add uplot-svelte uplot`

تحتاج أيضًا إلى تثبيت Svelte داخل شجرة مشروعك. مكون UplotSvelte متوافق مع مشاريع Svelte و SvelteKit.

## كيفية الاستخدام

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## العرض التوضيحي

انظر المثال [مثال Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'مثال Svelte')

يمكنك أيضًا تشغيل تطبيق العرض التوضيحي محليًا:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# التوثيق

|    المعامل      | المتطلب     | الوصف                                                                                                                                                                                                     |
| :-------------: | :---------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |   مطلوب     | خيارات لـ uPlot. يتم تمريرها كوسيط أول لمنشئ uPlot: `new uPlot(options)`                                                                                                                                   |
|      data       |   مطلوب     | بيانات لـ uPlot. يتم تمريرها كوسيط ثانٍ لمنشئ uPlot: `new uPlot(options, data)`                                                                                                                           |
|     target      |  اختياري    | عنصر html مستهدف لـ uPlot. يتم تمريره كوسيط ثالث لمنشئ uPlot: `new uPlot(options, data, target)` سيتم إنشاء عنصر div جديد تلقائيًا إذا لم يتم تمرير أي عنصر في الخصائص                                  |
|    onCreate     |  اختياري    | دالة رد نداء، تُستدعى عند إنشاء أو إعادة إنشاء مثيل uPlot                                                                                                                                                 |
|    onDelete     |  اختياري    | دالة رد نداء، تُستدعى قبل أن يتم تدمير مثيل uPlot، إما بسبب تغير الخصائص بشكل كبير بحيث يستحيل تحديث المخطط أو لأن المكون على وشك أن يُزال                                                                 |
| className/class |  اختياري    | اسم فئة يتم تمريره إلى عنصر div المستهدف الذي تم إنشاؤه تلقائيًا. يتم تجاهل اسم الفئة عندما يُستخدم خاصية 'target'.                                                                                        |
|   resetScales   |  اختياري    | علامة تتحكم فيما إذا كان سيتم إعادة تعيين المقاييس عند تغيير البيانات. القيمة الافتراضية هي true.                                                                                                         |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---