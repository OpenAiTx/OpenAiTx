
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# uPlot ৱ্ৰেপাৰসমূহ

[uPlot](https://github.com/leeoniya/uPlot 'uPlot') ৰ এটি সংগ্ৰহ, যি আপোনাক আপোনাৰ পচন্দৰ ফ্ৰেমৱাৰ্কত ঘোষণা-ভিত্তিকভাৱে চার্টৰ সৈতে কাম কৰিবলৈ সক্ষম কৰে।

**বিষয়বস্তুৰ তালিকা**

-   [প্ৰেৰণা](#motivation)
-   [আৰম্ভণি](#getting-started)
-   [React](#react)
    -   [স্থাপন](#installation)
    -   [ব্যৱহাৰ কৰা কেনেকৈ](#how-to-use)
    -   [ডেমো](#demo)
-   [Vue.js](#vuejs)
    -   [স্থাপন](#installation-1)
    -   [ব্যৱহাৰ কৰা কেনেকৈ](#how-to-use-1)
    -   [ডেমো](#demo-1)
-   [Svelte](#svelte)
    -   [স্থাপন](#installation-2)
    -   [ব্যৱহাৰ কৰা কেনেকৈ](#how-to-use-2)
    -   [ডেমো](#demo-2)
-   [দস্তাবেজ](#documentation)

# প্ৰেৰণা

যেতিয়া বহু uPlot ৰেপাৰ আগতেৰে উপলব্ধ, সকলোতেই তলত দিয়া সীমাবদ্ধতাসমূহ আছে:

1. তেওঁলোকে uPlot instance এটা কেৱল কম্প’নেন্ট মাউণ্ট হোৱাৰ সময়ত সৃষ্টি কৰে, আৰু আপুনি নিজেই সকলো আপডেট যুক্তি পৰিচালনা কৰিব লাগিব।
2. তেওঁলোকে uPlot instance সদায় পুনৰ সৃষ্টি কৰে যেতিয়া props সলনি হয়, যদিও instance আপডেট কৰি সেই পৰিবৰ্তনসমূহ প্ৰতিফলিত কৰিব পাৰি।

তুলনাত, এই লাইব্ৰেৰীয়ে চেষ্টা কৰে props সলনি হোৱাৰ পাছত uPlot instance পুনৰ সৃষ্টি নকৰিবলৈ। পুনৰ সৃষ্টি কৰাৰ বদলে, uPlot ৰ public API ব্যৱহাৰ কৰি instance টোক props অনুযায়ী আপডেট ৰাখিবলৈ চেষ্টা কৰে।

# আৰম্ভণি

আপুনি যি framework ব্যৱহাৰ কৰিছে তাৰ অনুসৰি তলত [React](#react), [Vue.js](#vuejs) বা [Svelte](#svelte) অংশ চাওক।
সকলো framework ৰ বাবে সাধাৰণ API [দস্তাবেজ](#documentation) অংশটোও চাওক।

# React

## স্থাপন

uplot-react পেকেজটো uplot নির্ভৰতাৰ সৈতে স্থাপন কৰক:

-   npm ব্যৱহাৰ কৰি: `$ npm install uplot-react uplot`
-   yarn ব্যৱহাৰ কৰি: `$ yarn add uplot-react uplot`

আপোনাৰ প্ৰজেক্টত React 16.8 বা তাতকৈ ওপৰৰ সংস্কৰণ স্থাপন কৰা আৱশ্যক।

## ব্যৱহাৰ কৰা কেনেকৈ

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## ডেম’ 

[লাইভ ডেম’](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'লাইভ ডেম’') চাওক

আপুনি ডেম’ এপটো স্থানীয়ভাৱে চলাবও পাৰে:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS ডেম’

দ্ৰুত আৰম্ভ কৰাৰ বাবে সৰল উদাহৰণ।
[ReactJS ডেম’](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS ডেম’')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## ইনষ্টলেশ্বন

uplot-vue পেকেজটো uplot নির্ভৰতাৰ সৈতে ইনষ্টল কৰক:

-   npm ব্যৱহাৰ কৰি: `$ npm install uplot-vue uplot`
-   yarn ব্যৱহাৰ কৰি: `$ yarn add uplot-vue uplot`

আপোনাৰ প্ৰজেক্ট ট্ৰিত Vue.js ইনষ্টল হোৱা প্ৰয়োজন (2.6 আৰু 3.x সংস্কৰণ দুয়োটা সমৰ্থিত).

## কেনেকৈ ব্যৱহাৰ কৰিব

টেম্পলেট ব্যৱহাৰ কৰি

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

JSX ব্যৱহাৰ কৰা

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

> টোকা: [Vue সীমাবদ্ধতা](https://github.com/vuejs/vue/issues/2164)ৰ কাৰণে মিউটেচন দ্বাৰা প্ৰোপাৰ্টি পৰিবৰ্তন সমৰ্থিত নহয়। আপোনাৰ প্ৰোপাৰ্টিৰ এক কপি সৃষ্টি কৰিব লাগিব, অৰ্থাৎ ইয়াক প্ৰতিস্থাপন কৰিব লাগিব, সাধাৰণ ধাৰণাৰ বাবে [উদাহৰণ](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) চাওক।

## ডেমো

[Vue.js 2 লাইভ ডেমো](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo') চাওক

আপুনি ডেমো এপটো স্থানীয়ভাৱে চলাবও পাৰে:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## স্থাপন

uplot-svelte পেকেজটো uplot ডিপেন্ডেন্সী সৈতে ইনষ্টল কৰক:

-   npm ব্যৱহাৰ কৰি: `$ npm install uplot-svelte uplot`
-   yarn ব্যৱহাৰ কৰি: `$ yarn add uplot-svelte uplot`

আপোনাৰ প্ৰকল্পত Svelte ইনষ্টল কৰা থকা প্ৰয়োজন। UplotSvelte কম্পোনেন্ট Svelte আৰু SvelteKit প্ৰকল্পৰ সৈতে সম্পূৰ্ণ ৰূপে সামঞ্জস্যপূর্ণ।

## ব্যৱহাৰ কৰাৰ পদ্ধতি

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## ডেম’ 

উদাহৰণটো চাওক [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

আপুনি স্থানীয়ভাৱে ডেম’ এপটো চলাব পাৰে:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# প্ৰমাণপত্ৰ

|    পৰামিতি    | আবশ্যকতা | বিৱৰণ                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  প্রয়োজনীয়   | uPlot ৰ বাবে অপ্সনসমূহ। প্ৰথম আৰ্গুমেন্ট হিচাপে uPlot কন্সট্ৰাক্টৰলৈ প্ৰেৰণ কৰা হয়: `new uPlot(options)`                                                                                                                 |
|      data       |  প্রয়োজনীয়   | uPlot ৰ বাবে ডাটা। দ্বিতীয় আৰ্গুমেন্ট হিচাপে uPlot কন্সট্ৰাক্টৰলৈ প্ৰেৰণ কৰা হয়: `new uPlot(options, data)`                                                                                                             |
|     target      |  ঐচ্ছিক   | uPlot ৰ বাবে লক্ষ্য html এলিমেন্ট। তৃতীয় আৰ্গুমেন্ট হিচাপে uPlot কন্সট্ৰাক্টৰলৈ প্ৰেৰণ কৰা হয়: `new uPlot(options, data, target)` যদি props ত কোনো এলিমেন্ট প্ৰেৰণ কৰা নহয়, তেন্তে এটা নতুন div target এলিমেন্ট স্বয়ংক্ৰিয়ভাৱে সৃষ্টি কৰা হয় |
|    onCreate     |  ঐচ্ছিক   | ক'লবেক ফাংচন, uPlot ইনষ্টেন্স সৃষ্টি বা পুনঃ-সৃষ্টি হোৱাৰ সময়ত আহ্বান কৰা হয়                                                                                                                                      |
|    onDelete     |  ঐচ্ছিক   | ক'লবেক ফাংচন, uPlot ইনষ্টেন্স ধ্বংস হোৱাৰ আগতে আহ্বান কৰা হয়, হয় props অধিক পৰিবৰ্তিত হোৱাৰ বাবে যাতে চাৰ্ট আপডেট কৰিব নোৱাৰি, বা কম্প’নেন্ট আনমাউন্ট হোৱাৰ আগতে        |
| className/class |  ঐচ্ছিক   | স্বয়ংক্ৰিয়ভাৱে সৃষ্টি হোৱা target div এলিমেন্টলৈ প্ৰেৰণ কৰা ক্লাছ নাম। 'target' prop ব্যৱহাৰ কৰা হ’লে ক্লাছ নাম উপেক্ষা কৰা হয়।                                                                            |
|   resetScales   |  ঐচ্ছিক   | ডাটা পৰিবৰ্তন হ’লে scale পুনঃ-সেট কৰাৰ নিয়ন্ত্ৰণ পতাকা। ডিফল্ট true।                                                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---