
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=skalinichev&project=uplot-wrappers&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# uPlot wrappers

A collection of [uPlot](https://github.com/leeoniya/uPlot 'uPlot') wrappers that enable you to work with charts declaratively within your favorite framework.

**Table of Contents**

-   [Motivation](#motivation)
-   [Getting started](#getting-started)
-   [React](#react)
    -   [Installation](#installation)
    -   [How to use](#how-to-use)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Installation](#installation-1)
    -   [How to use](#how-to-use-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Installation](#installation-2)
    -   [How to use](#how-to-use-2)
    -   [Demo](#demo-2)
-   [Documentation](#documentation)

# Motivation

Although several other uPlot wrappers already exist, all of them have one of the following limitations:

1. They create a uPlot instance once during the component mount phase and expect you to handle all the update logic yourself.
2. They recreate the uPlot instance entirely whenever the props change, even if the instance could simply be updated to reflect the changes.

In contrast, this library does its best not to recreate the uPlot instance when the props change. Instead of recreating, it attempts to use the uPlot public API to keep it updated with the props.

# Getting started

Refer to the [React](#react), [Vue.js](#vuejs) or [Svelte](#svelte) sections below, depending on the framework you're using.
Also see the API [documentation](#documentation) that is common to all frameworks.

# React

## Installation

Install the uplot-react package along with the uplot dependency:

-   Using npm: `$ npm install uplot-react uplot`
-   Using yarn: `$ yarn add uplot-react uplot`

You also need to have React 16.8 or above installed within your project tree.

## How to use

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```
## Demo

See the [live demo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')

You can also run the demo app locally:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS Demo

simple example for getting started quickly.
[ReactJS Demo](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Installation

Install uplot-vue package with uplot dependency:

-   Using npm: `$ npm install uplot-vue uplot`
-   Using yarn: `$ yarn add uplot-vue uplot`

You also need Vue.js to be installed inside your project tree (both 2.6 and 3.x versions are supported).

## How to use

Using template


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

Using JSX

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

> Note: Property changes by mutation are not supported due to [Vue limitation](https://github.com/vuejs/vue/issues/2164) You have to create a copy of the property, i.e. replace it instead, see an [example](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) for the general idea.

## Demo

See the [Vue.js 2 live demo](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

You can also run the demo app locally:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Installation

Install uplot-svelte package with uplot dependency:

-   Using npm: `$ npm install uplot-svelte uplot`
-   Using yarn: `$ yarn add uplot-svelte uplot`

You also need Svelte to be installed inside your project tree. UplotSvelte component is compatible with Svelte and SvelteKit projects.

## How to use

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## Demo

See the example [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

You can also run the demo app locally:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentation

|    Parameter    | Requirement | Description                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  required   | Options for uPlot. Passed as the first argument to uPlot constructor: `new uPlot(options)`                                                                                                                 |
|      data       |  required   | Data for uPlot. Passed as the second argument to uPlot constructor: `new uPlot(options, data)`                                                                                                             |
|     target      |  optional   | Target html element for uPlot. Passed as the third argument to uPlot constructor: `new uPlot(options, data, target)` A new div target element will be created automatically if none is passed in the props |
|    onCreate     |  optional   | Callback function, invoked upon uPlot instance creation or recreation                                                                                                                                      |
|    onDelete     |  optional   | Callback function, invoked before uPlot instance gets destroyed, either because the props has changed so much it's impossible to update the chart or because the component is about to be unmounted        |
| className/class |  optional   | A class name passed over to the automatically created target div element. Class name is ignored when the 'target' prop is used.                                                                            |
|   resetScales   |  optional   | Flag controlling whether to reset the scales on data change. Defaults to true.                                                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---