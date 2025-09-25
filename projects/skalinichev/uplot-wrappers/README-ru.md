
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Обёртки для uPlot

Коллекция обёрток для [uPlot](https://github.com/leeoniya/uPlot 'uPlot'), позволяющих работать с графиками декларативно в вашем любимом фреймворке.

**Содержание**

-   [Мотивация](#motivation)
-   [Начало работы](#getting-started)
-   [React](#react)
    -   [Установка](#installation)
    -   [Как использовать](#how-to-use)
    -   [Демо](#demo)
-   [Vue.js](#vuejs)
    -   [Установка](#installation-1)
    -   [Как использовать](#how-to-use-1)
    -   [Демо](#demo-1)
-   [Svelte](#svelte)
    -   [Установка](#installation-2)
    -   [Как использовать](#how-to-use-2)
    -   [Демо](#demo-2)
-   [Документация](#documentation)

# Мотивация

Хотя уже существуют несколько других обёрток для uPlot, все они имеют одно из следующих ограничений:

1. Они создают экземпляр uPlot один раз, на этапе монтирования компонента, и ожидают, что вы сами будете обрабатывать всю логику обновления.
2. Они пересоздают экземпляр uPlot заново при каждом изменении пропсов, даже если экземпляр можно просто обновить для отражения изменений.

В отличие от них, эта библиотека старается не пересоздавать экземпляр uPlot при изменении пропсов. Вместо пересоздания она использует публичный API uPlot для актуализации состояния согласно пропсам.

# Начало работы

Смотрите разделы [React](#react), [Vue.js](#vuejs) или [Svelte](#svelte) ниже в зависимости от используемого фреймворка.
Также ознакомьтесь с [документацией](#documentation) API, общей для всех фреймворков.

# React

## Установка

Установите пакет uplot-react с зависимостью uplot:

-   Через npm: `$ npm install uplot-react uplot`
-   Через yarn: `$ yarn add uplot-react uplot`

Вам также потребуется React версии 16.8 или выше, установленный в вашем проекте.

## Как использовать

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## Демонстрация

Смотрите [живую демонстрацию](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')

Вы также можете запустить демонстрационное приложение локально:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Демонстрация ReactJS

простой пример для быстрого старта.
[Демонстрация ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Установка

Установите пакет uplot-vue вместе с зависимостью uplot:

-   Через npm: `$ npm install uplot-vue uplot`
-   Через yarn: `$ yarn add uplot-vue uplot`

Также необходимо установить Vue.js в вашем проекте (поддерживаются версии 2.6 и 3.x).

## Как использовать

Использование шаблона

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

Использование JSX

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

> Примечание: Изменение свойств посредством мутаций не поддерживается из-за [ограничения Vue](https://github.com/vuejs/vue/issues/2164). Необходимо создавать копию свойства, то есть заменять его, см. [пример](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) для общего понимания.

## Демонстрация

Смотрите [живую демонстрацию Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Живая демонстрация Vue.js 2')

Вы также можете запустить демо-приложение локально:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Установка

Установите пакет uplot-svelte с зависимостью uplot:

-   Через npm: `$ npm install uplot-svelte uplot`
-   Через yarn: `$ yarn add uplot-svelte uplot`

Также необходимо установить Svelte внутри вашего проекта. Компонент UplotSvelte совместим с проектами Svelte и SvelteKit.

## Как использовать

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## Демонстрация

Смотрите пример [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

Вы также можете запустить демонстрационное приложение локально:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Документация

|    Параметр     | Требование  | Описание                                                                                                                                                                                                   |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |   требуется | Опции для uPlot. Передаются в качестве первого аргумента конструктору uPlot: `new uPlot(options)`                                                                                                         |
|      data       |   требуется | Данные для uPlot. Передаются в качестве второго аргумента конструктору uPlot: `new uPlot(options, data)`                                                                                                  |
|     target      |   опционально | Целевой html-элемент для uPlot. Передается как третий аргумент конструктору uPlot: `new uPlot(options, data, target)` Если не передан, автоматически создается новый div-элемент |
|    onCreate     |   опционально | Функция обратного вызова, вызывается при создании или пересоздании экземпляра uPlot                                                                                                                    |
|    onDelete     |   опционально | Функция обратного вызова, вызывается перед уничтожением экземпляра uPlot, либо из-за сильного изменения props, либо перед размонтированием компонента                                            |
| className/class |   опционально | Имя класса, передаваемое автоматически созданному div-элементу. Имя класса игнорируется, если используется проп 'target'.                                                                             |
|   resetScales   |   опционально | Флаг, управляющий сбросом масштабов при изменении данных. По умолчанию true.                                                                                                                           |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---