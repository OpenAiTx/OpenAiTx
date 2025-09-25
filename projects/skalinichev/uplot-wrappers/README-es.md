
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# Envoltorios de uPlot

Una colección de envoltorios de [uPlot](https://github.com/leeoniya/uPlot 'uPlot') que te permiten trabajar con gráficos de manera declarativa dentro de tu framework favorito.

**Tabla de Contenidos**

-   [Motivación](#motivation)
-   [Primeros pasos](#getting-started)
-   [React](#react)
    -   [Instalación](#instalación)
    -   [Cómo usar](#cómo-usar)
    -   [Demostración](#demostración)
-   [Vue.js](#vuejs)
    -   [Instalación](#instalación-1)
    -   [Cómo usar](#cómo-usar-1)
    -   [Demostración](#demostración-1)
-   [Svelte](#svelte)
    -   [Instalación](#instalación-2)
    -   [Cómo usar](#cómo-usar-2)
    -   [Demostración](#demostración-2)
-   [Documentación](#documentación)

# Motivación

Aunque ya existen varios otros wrappers para uPlot, todos ellos tienen una de las siguientes limitaciones:

1. Crean la instancia de uPlot una vez, durante la fase de montaje del componente, y esperan que tú manejes toda la lógica de actualización por tu cuenta.
2. Recrean la instancia de uPlot desde cero cada vez que cambian las props, incluso si la instancia puede actualizarse para reflejar los cambios.

En comparación, esta biblioteca intenta lo mejor posible no recrear la instancia de uPlot cuando cambian las props. En lugar de recrearla, intenta usar la API pública de uPlot para mantenerla actualizada con las props.

# Primeros pasos

Consulta las secciones de [React](#react), [Vue.js](#vuejs) o [Svelte](#svelte) más abajo dependiendo de qué framework estés utilizando.
También consulta la [documentación](#documentación) de la API común para todos los frameworks.

# React

## Instalación

Instala el paquete uplot-react junto con la dependencia uplot:

-   Usando npm: `$ npm install uplot-react uplot`
-   Usando yarn: `$ yarn add uplot-react uplot`

También necesitas tener instalado React 16.8 o superior dentro de tu proyecto.

## Cómo usar

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

Vea la [demo en vivo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'demo en vivo')

También puede ejecutar la aplicación demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demo ReactJS

Ejemplo simple para comenzar rápidamente.
[Demo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demo ReactJS')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Instalación

Instale el paquete uplot-vue con la dependencia uplot:

-   Usando npm: `$ npm install uplot-vue uplot`
-   Usando yarn: `$ yarn add uplot-vue uplot`

También necesita que Vue.js esté instalado dentro de su árbol de proyecto (se soportan versiones 2.6 y 3.x).

## Cómo usar

Usando plantilla

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

Usando JSX

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

> Nota: Los cambios de propiedad por mutación no son compatibles debido a una [limitación de Vue](https://github.com/vuejs/vue/issues/2164). Debe crear una copia de la propiedad, es decir, reemplazarla en su lugar, vea un [ejemplo](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) para la idea general.

## Demo

Vea la [demo en vivo de Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Demo en vivo de Vue.js 2')

También puede ejecutar la aplicación demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Instalación

Instale el paquete uplot-svelte con la dependencia uplot:

-   Usando npm: `$ npm install uplot-svelte uplot`
-   Usando yarn: `$ yarn add uplot-svelte uplot`

También necesita que Svelte esté instalado dentro de su árbol de proyecto. El componente UplotSvelte es compatible con proyectos Svelte y SvelteKit.

## Cómo usar

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

Vea el ejemplo [Ejemplo de Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Ejemplo de Svelte')

También puede ejecutar la aplicación demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentación

|    Parámetro    | Requisito  | Descripción                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  obligatorio   | Opciones para uPlot. Se pasan como el primer argumento al constructor de uPlot: `new uPlot(options)`                                                                                                        |
|      data       |  obligatorio   | Datos para uPlot. Se pasan como el segundo argumento al constructor de uPlot: `new uPlot(options, data)`                                                                                                    |
|     target      |  opcional   | Elemento html objetivo para uPlot. Se pasa como el tercer argumento al constructor de uPlot: `new uPlot(options, data, target)` Se creará automáticamente un nuevo elemento div objetivo si no se pasa en las props |
|    onCreate     |  opcional   | Función callback, invocada al crear o recrear la instancia de uPlot                                                                                                                                       |
|    onDelete     |  opcional   | Función callback, invocada antes de que la instancia de uPlot sea destruida, ya sea porque las props han cambiado tanto que es imposible actualizar el gráfico o porque el componente está a punto de desmontarse |
| className/class |  opcional   | Un nombre de clase pasado al elemento div objetivo creado automáticamente. El nombre de clase se ignora cuando se usa la prop 'target'.                                                                     |
|   resetScales   |  opcional   | Indicador que controla si se deben reiniciar las escalas al cambiar los datos. Por defecto es true.                                                                                                         |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---