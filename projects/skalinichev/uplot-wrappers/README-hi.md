
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# uPlot रैपर्स

[uPlot](https://github.com/leeoniya/uPlot 'uPlot') रैपर्स का एक संग्रह जो आपको अपने पसंदीदा फ्रेमवर्क के अंदर चार्ट्स के साथ घोषणात्मक रूप से काम करने की सुविधा देता है।

**सामग्री सूची**

-   [प्रेरणा](#motivation)
-   [शुरुआत करें](#getting-started)
-   [React](#react)
    -   [इंस्टॉलेशन](#installation)
    -   [कैसे उपयोग करें](#how-to-use)
    -   [डेमो](#demo)
-   [Vue.js](#vuejs)
    -   [इंस्टॉलेशन](#installation-1)
    -   [कैसे उपयोग करें](#how-to-use-1)
    -   [डेमो](#demo-1)
-   [Svelte](#svelte)
    -   [इंस्टॉलेशन](#installation-2)
    -   [कैसे उपयोग करें](#how-to-use-2)
    -   [डेमो](#demo-2)
-   [डॉक्युमेंटेशन](#documentation)

# उद्देश्य

हालाँकि कई अन्य uPlot रैपर पहले से मौजूद हैं, उनमें से सभी में निम्नलिखित सीमाएं होती हैं:

1. वे uPlot इंस्टेंस को एक बार बनाते हैं, जब कंपोनेंट माउंट होता है, और उम्मीद करते हैं कि आप खुद ही सारी अपडेट लॉजिक संभालें।
2. वे हर बार जब props बदलते हैं तो uPlot इंस्टेंस को फिर से बनाते हैं, चाहे इंस्टेंस को अपडेट कर के बदलाव दर्शाए जा सकते हों।

इसके विपरीत, यह लाइब्रेरी props बदलने पर uPlot इंस्टेंस को फिर से बनाने से बचने की पूरी कोशिश करती है। रीक्रिएशन की बजाय यह uPlot की सार्वजनिक API का उपयोग करके उसे props के अनुसार अपडेट रखने की कोशिश करती है।

# प्रारंभ करना

नीचे दिए गए [React](#react), [Vue.js](#vuejs) या [Svelte](#svelte) सेक्शन देखें, यह निर्भर करता है कि आप कौन सा फ्रेमवर्क उपयोग कर रहे हैं।
सभी फ्रेमवर्क के लिए सामान्य API [डॉक्युमेंटेशन](#documentation) भी देखें।

# React

## इंस्टॉलेशन

uplot-react पैकेज को uplot डिपेंडेंसी के साथ इंस्टॉल करें:

-   npm का उपयोग करते हुए: `$ npm install uplot-react uplot`
-   yarn का उपयोग करते हुए: `$ yarn add uplot-react uplot`

आपको अपने प्रोजेक्ट ट्री में React 16.8 या उससे ऊपर का वर्शन भी इंस्टॉल होना चाहिए।

## कैसे उपयोग करें

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## डेमो

[लाइव डेमो](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'लाइव डेमो') देखें

आप डेमो ऐप को स्थानीय रूप से भी चला सकते हैं:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS डेमो

जल्दी शुरू करने के लिए एक सरल उदाहरण।
[ReactJS डेमो](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS डेमो')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## इंस्टॉलेशन

uplot निर्भरता के साथ uplot-vue पैकेज इंस्टॉल करें:

-   npm का उपयोग करते हुए: `$ npm install uplot-vue uplot`
-   yarn का उपयोग करते हुए: `$ yarn add uplot-vue uplot`

आपको अपने प्रोजेक्ट ट्री के अंदर Vue.js भी इंस्टॉल करना होगा (दोनों 2.6 और 3.x संस्करण समर्थित हैं)।

## उपयोग कैसे करें

टेम्पलेट का उपयोग करते हुए

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

JSX का उपयोग करना

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

> नोट: म्यूटेशन द्वारा प्रॉपर्टी में बदलाव [Vue की सीमा](https://github.com/vuejs/vue/issues/2164) के कारण समर्थित नहीं हैं। आपको प्रॉपर्टी की एक कॉपी बनानी होगी, अर्थात उसे बदलना होगा, सामान्य विचार के लिए एक [उदाहरण](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) देखें।

## डेमो

[Vue.js 2 लाइव डेमो](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 लाइव डेमो') देखें

आप डेमो ऐप को स्थानीय रूप से भी चला सकते हैं:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## इंस्टालेशन

uplot-svelte पैकेज को uplot डिपेंडेंसी के साथ इंस्टॉल करें:

-   npm का उपयोग करते हुए: `$ npm install uplot-svelte uplot`
-   yarn का उपयोग करते हुए: `$ yarn add uplot-svelte uplot`

आपको अपने प्रोजेक्ट ट्री के अंदर Svelte भी इंस्टॉल करना होगा। UplotSvelte कंपोनेंट Svelte और SvelteKit प्रोजेक्ट्स के साथ संगत है।

## उपयोग कैसे करें

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## डेमो

उदाहरण देखें [Svelte उदाहरण](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte उदाहरण')

आप डेमो ऐप को स्थानीय रूप से भी चला सकते हैं:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# दस्तावेज़ीकरण

|    पैरामीटर    | आवश्यकता | विवरण                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  आवश्यक   | uPlot के लिए विकल्प। uPlot कंस्ट्रक्टर को पहले तर्क के रूप में पास किए जाते हैं: `new uPlot(options)`                                                                                                                 |
|      data       |  आवश्यक   | uPlot के लिए डेटा। uPlot कंस्ट्रक्टर को दूसरे तर्क के रूप में पास किए जाते हैं: `new uPlot(options, data)`                                                                                                             |
|     target      |  वैकल्पिक   | uPlot के लिए लक्ष्य html तत्व। uPlot कंस्ट्रक्टर को तीसरे तर्क के रूप में पास किए जाते हैं: `new uPlot(options, data, target)` अगर props में कोई target नहीं दिया गया है तो एक नया div तत्व स्वचालित रूप से बनाया जाएगा |
|    onCreate     |  वैकल्पिक   | कॉलबैक फंक्शन, जो uPlot इंस्टेंस के निर्माण या पुनर्निर्माण पर कॉल किया जाता है                                                                                                                              |
|    onDelete     |  वैकल्पिक   | कॉलबैक फंक्शन, जो uPlot इंस्टेंस के नष्ट होने से पहले कॉल किया जाता है, या तो props में इतना बदलाव हो गया हो कि चार्ट अपडेट करना संभव न हो या कंपोनेंट अनमाउंट होने वाला हो                                 |
| className/class |  वैकल्पिक   | एक क्लास नाम जो स्वचालित रूप से बनाए गए target div तत्व को दिया जाता है। जब 'target' prop का उपयोग किया जाता है तो क्लास नाम नजरअंदाज किया जाता है।                                                            |
|   resetScales   |  वैकल्पिक   | डेटा परिवर्तन पर स्केल्स को रीसेट करने का फ्लैग। डिफ़ॉल्ट true है।                                                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---