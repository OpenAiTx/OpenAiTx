# uPlot wrappers

A collection of [uPlot](https://github.com/leeoniya/uPlot 'uPlot') wrappers that allow you to work with charts declaratively inside your favorite framework.

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

While several other uPlot wrappers already exist, all of them have one of the following limitations:

1. They create uPlot instance once, during component mount phase, and expect you to handle all the update logic yourself.
2. They recreate uPlot instance anew whenever the props change, even if the instance can be updated to reflect the changes.

In comparison this library tries it's best not to recreate the uPlot instance once the props change. Instead of recreation it tries to use uPlot public API to keep it up to date with the props.

# Getting started

See [React](#react), [Vue.js](#vuejs) or [Svelte](#svelte) sections below depending on what framework you're using.
Also see API [documentation](#documentation) common to all frameworks.

# React

## Installation

Install uplot-react package with uplot dependency:

-   Using npm: `$ npm install uplot-react uplot`
-   Using yarn: `$ yarn add uplot-react uplot`

You also need React 16.8 or above to be installed inside your project tree.

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
