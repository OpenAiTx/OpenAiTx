
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

# uPlot 封装库

一系列 [uPlot](https://github.com/leeoniya/uPlot 'uPlot') 封装库，让你可以在你喜欢的框架中以声明式方式操作图表。

**目录**

-   [动机](#motivation)
-   [快速开始](#getting-started)
-   [React](#react)
    -   [安装](#installation)
    -   [如何使用](#how-to-use)
    -   [演示](#demo)
-   [Vue.js](#vuejs)
    -   [安装](#installation-1)
    -   [如何使用](#how-to-use-1)
    -   [演示](#demo-1)
-   [Svelte](#svelte)
    -   [安装](#installation-2)
    -   [如何使用](#how-to-use-2)
    -   [演示](#demo-2)
-   [文档](#documentation)

# 动机

虽然已经存在其他几个uPlot的包装器，但它们都有以下某些限制之一：

1. 它们只在组件挂载阶段创建uPlot实例，并期望你自己处理所有的更新逻辑。
2. 每当属性发生变化时，它们都会重新创建uPlot实例，即使该实例可以通过更新来反映变化。

相比之下，本库尽力在属性变化时不重新创建uPlot实例。它不是重新创建，而是尝试使用uPlot公开的API根据属性保持最新状态。

# 入门

根据你使用的框架，参见下面的[React](#react)、[Vue.js](#vuejs)或[Svelte](#svelte)部分。
同时参见所有框架通用的API[文档](#documentation)。

# React

## 安装

使用uplot-react包并安装uplot依赖：

-   使用npm: `$ npm install uplot-react uplot`
-   使用yarn: `$ yarn add uplot-react uplot`

你的项目中还需要安装React 16.8或更高版本。

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

## 演示

查看[实时演示](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx '实时演示')

你也可以在本地运行演示应用：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS 演示

快速入门的简单示例。
[ReactJS 演示](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS 演示')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## 安装

安装带有 uplot 依赖的 uplot-vue 包：

-   使用 npm：`$ npm install uplot-vue uplot`
-   使用 yarn：`$ yarn add uplot-vue uplot`

你还需要在项目目录中安装 Vue.js（支持 2.6 和 3.x 版本）。

## 如何使用

使用模板

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
> 注意：由于 [Vue 限制](https://github.com/vuejs/vue/issues/2164)，不支持通过变异修改属性。您必须创建属性的副本，即替换它，参见一个[示例](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52)了解总体思路。

## 演示

查看 [Vue.js 2 在线演示](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

您也可以在本地运行演示应用：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2：

`$ yarn run serveVue`

Vue.js 3：

`$ yarn run serveVue3`

# Svelte

## 安装

安装带有 uplot 依赖的 uplot-svelte 包：

-   使用 npm：`$ npm install uplot-svelte uplot`
-   使用 yarn：`$ yarn add uplot-svelte uplot`

您还需要在项目目录中安装 Svelte。UplotSvelte 组件兼容 Svelte 和 SvelteKit 项目。

## 使用方法


```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## 演示

查看示例 [Svelte 示例](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

你也可以在本地运行演示应用：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# 文档

|    参数    | 必需项 | 描述                                                                                                                                                                                                     |
| :--------: | :----: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|   options  | 必需   | uPlot 的选项。作为第一个参数传递给 uPlot 构造函数：`new uPlot(options)`                                                                                                                                |
|    data    | 必需   | uPlot 的数据。作为第二个参数传递给 uPlot 构造函数：`new uPlot(options, data)`                                                                                                                          |
|   target   | 可选   | uPlot 的目标 HTML 元素。作为第三个参数传递给 uPlot 构造函数：`new uPlot(options, data, target)` 如果 props 中未传入，则会自动创建一个新的 div 目标元素                                                                            |
|  onCreate  | 可选   | 回调函数，在 uPlot 实例创建或重新创建时调用                                                                                                                                                             |
|  onDelete  | 可选   | 回调函数，在 uPlot 实例销毁之前调用，无论是因为 props 变化太大无法更新图表，还是组件即将卸载                                                                                                             |
| className/class | 可选 | 传递给自动创建的目标 div 元素的类名。使用 'target' prop 时类名会被忽略。                                                                                                                             |
| resetScales | 可选   | 控制在数据变化时是否重置刻度的标志。默认值为 true。                                                                                                                                                     |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---