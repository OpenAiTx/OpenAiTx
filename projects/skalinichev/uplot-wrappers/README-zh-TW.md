
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-CN">簡體中文</a>
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

# uPlot 包裝器

一系列 [uPlot](https://github.com/leeoniya/uPlot 'uPlot') 的包裝器，讓你能在喜愛的框架中以宣告式方式操作圖表。

**目錄**

-   [動機](#motivation)
-   [快速開始](#getting-started)
-   [React](#react)
    -   [安裝](#installation)
    -   [如何使用](#how-to-use)
    -   [範例](#demo)
-   [Vue.js](#vuejs)
    -   [安裝](#installation-1)
    -   [如何使用](#how-to-use-1)
    -   [範例](#demo-1)
-   [Svelte](#svelte)
    -   [安裝](#installation-2)
    -   [如何使用](#how-to-use-2)
    -   [範例](#demo-2)
-   [文件](#documentation)

# 動機

雖然目前已經有其他 uPlot 的封裝套件，但它們都存在以下其中一種限制：

1. 它們只在元件掛載階段建立 uPlot 實例，並且期望你自行處理所有的更新邏輯。
2. 每當 props 變更時就重新建立新的 uPlot 實例，即使該實例可透過更新反映變更。

相比之下，本函式庫盡量避免在 props 變更時重建 uPlot 實例。它會嘗試利用 uPlot 的公開 API 來根據 props 保持資料的即時更新。

# 快速開始

請根據你所使用的框架參考下方的 [React](#react)、[Vue.js](#vuejs) 或 [Svelte](#svelte) 章節。
另外，也可參考所有框架共用的 API [文件](#documentation)。

# React

## 安裝

安裝 uplot-react 套件及其相依的 uplot：

-   使用 npm: `$ npm install uplot-react uplot`
-   使用 yarn: `$ yarn add uplot-react uplot`

你的專案中也必須安裝 React 16.8 或以上版本。

## 如何使用

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## 示範

請參考[線上示範](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx '線上示範')

你也可以在本地執行示範應用程式：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS 示範

快速入門的簡單範例。
[ReactJS 示範](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS 示範')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## 安裝方式

安裝 uplot-vue 套件及其依賴 uplot：

-   使用 npm：`$ npm install uplot-vue uplot`
-   使用 yarn：`$ yarn add uplot-vue uplot`

你還需要在你的專案中安裝 Vue.js（支援 2.6 及 3.x 版本）。

## 如何使用

使用範本

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

使用 JSX

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

> 注意：由於 [Vue 限制](https://github.com/vuejs/vue/issues/2164)，不支援以突變方式變更屬性。你必須建立屬性的副本，也就是以取代方式處理，請參考這個[範例](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52)以瞭解一般做法。

## 演示

請參考 [Vue.js 2 線上演示](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 線上演示')

你也可以在本地運行演示應用程式：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2：

`$ yarn run serveVue`

Vue.js 3：

`$ yarn run serveVue3`

# Svelte

## 安裝

安裝 uplot-svelte 套件及 uplot 依賴：

-   使用 npm：`$ npm install uplot-svelte uplot`
-   使用 yarn：`$ yarn add uplot-svelte uplot`

你還需要在專案目錄中安裝 Svelte。UplotSvelte 元件相容於 Svelte 及 SvelteKit 專案。

## 如何使用

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## 示範

請參閱範例 [Svelte 範例](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte 範例')

您也可以在本地運行示範應用程式：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# 文件說明

|    參數名稱    | 是否必要   | 說明                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  必填       | uPlot 的選項。作為第一個參數傳給 uPlot 建構函式：`new uPlot(options)`                                                                                                                 |
|      data       |  必填       | uPlot 的資料。作為第二個參數傳給 uPlot 建構函式：`new uPlot(options, data)`                                                                                                             |
|     target      |  選填       | uPlot 的目標 html 元素。作為第三個參數傳給 uPlot 建構函式：`new uPlot(options, data, target)` 若 props 未傳入目標元素，將自動建立新的 div 目標元素 |
|    onCreate     |  選填       | 回呼函式，於 uPlot 實例建立或重建時呼叫                                                                                                                                      |
|    onDelete     |  選填       | 回呼函式，於 uPlot 實例被銷毀前呼叫，可能因 props 變動過大導致無法更新圖表，或元件即將卸載時觸發        |
| className/class |  選填       | 傳遞給自動建立之目標 div 元素的 class 名稱。當使用 'target' 屬性時，class 名稱將被忽略。                                                                            |
|   resetScales   |  選填       | 控制資料變更時是否重置座標軸的旗標。預設為 true。                                                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---