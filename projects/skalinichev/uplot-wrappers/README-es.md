# Envoltorios de uPlot

Una colección de envoltorios de [uPlot](https://github.com/leeoniya/uPlot 'uPlot') que te permiten trabajar con gráficos de forma declarativa dentro de tu framework favorito.

**Tabla de Contenidos**

-   [Motivación](#motivation)
-   [Primeros pasos](#getting-started)
-   [React](#react)
    -   [Instalación](#installation)
    -   [Cómo usar](#how-to-use)
    -   [Demostración](#demo)
-   [Vue.js](#vuejs)
    -   [Instalación](#installation-1)
    -   [Cómo usar](#how-to-use-1)
    -   [Demostración](#demo-1)
-   [Svelte](#svelte)
    -   [Instalación](#installation-2)
    -   [Cómo usar](#how-to-use-2)
    -   [Demostración](#demo-2)
-   [Documentación](#documentation)

# Motivación

Aunque ya existen varios envoltorios de uPlot, todos ellos tienen una de las siguientes limitaciones:

1. Crean la instancia de uPlot una vez, durante la fase de montaje del componente, y esperan que tú manejes toda la lógica de actualización.
2. Recrean la instancia de uPlot cada vez que cambian las props, incluso si la instancia puede actualizarse para reflejar los cambios.

En comparación, esta biblioteca intenta no recrear la instancia de uPlot cuando cambian las props. En lugar de recrearla, intenta usar la API pública de uPlot para mantenerla actualizada con las props.

# Primeros pasos

Consulta las secciones de [React](#react), [Vue.js](#vuejs) o [Svelte](#svelte) a continuación según el framework que uses.
También consulta la [documentación](#documentation) de la API común a todos los frameworks.

# React

## Instalación

Instale el paquete uplot-react con la dependencia uplot:

-   Usando npm: `$ npm install uplot-react uplot`
-   Usando yarn: `$ yarn add uplot-react uplot`

También necesita tener React 16.8 o superior instalado dentro del árbol de su proyecto.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---