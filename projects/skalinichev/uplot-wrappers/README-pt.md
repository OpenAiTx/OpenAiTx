
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

# Wrappers uPlot

Uma coleção de wrappers para [uPlot](https://github.com/leeoniya/uPlot 'uPlot') que permite trabalhar com gráficos de forma declarativa dentro do seu framework favorito.

**Índice**

-   [Motivação](#motivation)
-   [Primeiros passos](#getting-started)
-   [React](#react)
    -   [Instalação](#instalacao)
    -   [Como usar](#como-usar)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Instalação](#instalacao-1)
    -   [Como usar](#como-usar-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Instalação](#instalacao-2)
    -   [Como usar](#como-usar-2)
    -   [Demo](#demo-2)
-   [Documentação](#documentacao)

# Motivação

Embora já existam vários outros wrappers para uPlot, todos eles possuem uma das seguintes limitações:

1. Eles criam a instância do uPlot uma única vez, durante a fase de montagem do componente, e esperam que você gerencie toda a lógica de atualização.
2. Eles recriam uma nova instância do uPlot sempre que as props mudam, mesmo que a instância possa ser atualizada para refletir as mudanças.

Em comparação, esta biblioteca tenta ao máximo não recriar a instância do uPlot quando as props mudam. Em vez de recriar, ela tenta usar a API pública do uPlot para mantê-lo atualizado com as props.

# Começando

Veja as seções [React](#react), [Vue.js](#vuejs) ou [Svelte](#svelte) abaixo, dependendo de qual framework você está usando.
Consulte também a [documentação](#documentacao) da API comum a todos os frameworks.

# React

## Instalação

Instale o pacote uplot-react com a dependência uplot:

-   Usando npm: `$ npm install uplot-react uplot`
-   Usando yarn: `$ yarn add uplot-react uplot`

Você também precisa ter React 16.8 ou superior instalado em seu projeto.

## Como usar

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## Demonstração

Veja a [demonstração ao vivo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'demonstração ao vivo')

Você também pode executar o aplicativo de demonstração localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demonstração ReactJS

exemplo simples para começar rapidamente.
[Demonstração ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demonstração ReactJS')

![imagem](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Instalação

Instale o pacote uplot-vue com a dependência uplot:

-   Usando npm: `$ npm install uplot-vue uplot`
-   Usando yarn: `$ yarn add uplot-vue uplot`

Você também precisa instalar o Vue.js no seu projeto (ambas as versões 2.6 e 3.x são suportadas).

## Como usar

Usando template

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

> Nota: Alterações de propriedades por mutação não são suportadas devido a uma [limitação do Vue](https://github.com/vuejs/vue/issues/2164). Você deve criar uma cópia da propriedade, ou seja, substituí-la, veja um [exemplo](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) para entender a ideia geral.

## Demonstração

Veja a [demonstração ao vivo do Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Demonstração ao vivo do Vue.js 2')

Você também pode executar o aplicativo de demonstração localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Instalação

Instale o pacote uplot-svelte com a dependência uplot:

-   Usando npm: `$ npm install uplot-svelte uplot`
-   Usando yarn: `$ yarn add uplot-svelte uplot`

Você também precisa instalar o Svelte dentro da árvore de seu projeto. O componente UplotSvelte é compatível com projetos Svelte e SvelteKit.

## Como usar

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## Demonstração

Veja o exemplo [Exemplo Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Exemplo Svelte')

Você também pode executar o aplicativo de demonstração localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentação

|    Parâmetro    |  Requisito  | Descrição                                                                                                                                                                                                |
| :-------------: | :---------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  obrigatório | Opções para uPlot. Passadas como primeiro argumento para o construtor do uPlot: `new uPlot(options)`                                                                                                     |
|      data       |  obrigatório | Dados para uPlot. Passados como segundo argumento para o construtor do uPlot: `new uPlot(options, data)`                                                                                                 |
|     target      |  opcional   | Elemento html alvo para uPlot. Passado como terceiro argumento para o construtor do uPlot: `new uPlot(options, data, target)` Um novo elemento div alvo será criado automaticamente se nenhum for passado nas props |
|    onCreate     |  opcional   | Função de callback, invocada na criação ou recriação da instância do uPlot                                                                                                                               |
|    onDelete     |  opcional   | Função de callback, invocada antes da instância do uPlot ser destruída, seja porque as props mudaram tanto que é impossível atualizar o gráfico ou porque o componente está prestes a ser desmontado      |
| className/class |  opcional   | Um nome de classe passado para o elemento div alvo criado automaticamente. O nome da classe é ignorado quando a prop 'target' é utilizada.                                                                |
|   resetScales   |  opcional   | Flag que controla se as escalas devem ser redefinidas ao alterar os dados. O padrão é true.                                                                                                              |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---