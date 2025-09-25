
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# uPlot wrappers

Una collezione di wrapper [uPlot](https://github.com/leeoniya/uPlot 'uPlot') che ti permettono di lavorare con i grafici in modo dichiarativo all'interno del tuo framework preferito.

**Indice**

-   [Motivazione](#motivazione)
-   [Come iniziare](#come-iniziare)
-   [React](#react)
    -   [Installazione](#installazione)
    -   [Come usare](#come-usare)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Installazione](#installazione-1)
    -   [Come usare](#come-usare-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Installazione](#installazione-2)
    -   [Come usare](#come-usare-2)
    -   [Demo](#demo-2)
-   [Documentazione](#documentazione)

# Motivazione

Sebbene esistano già diversi wrapper uPlot, tutti presentano una delle seguenti limitazioni:

1. Creano l'istanza di uPlot una sola volta, durante la fase di montaggio del componente, e si aspettano che tu gestisca tutta la logica di aggiornamento autonomamente.
2. Ricreano l'istanza di uPlot da zero ogni volta che le props cambiano, anche se l'istanza può essere aggiornata per riflettere le modifiche.

In confronto, questa libreria cerca il più possibile di non ricreare l'istanza di uPlot quando le props cambiano. Invece di ricrearla cerca di usare le API pubbliche di uPlot per mantenerla aggiornata con le props.

# Per iniziare

Consulta le sezioni [React](#react), [Vue.js](#vuejs) o [Svelte](#svelte) qui sotto a seconda del framework che stai utilizzando.
Consulta anche la [documentazione](#documentazione) dell'API, comune a tutti i framework.

# React

## Installazione

Installa il pacchetto uplot-react con la dipendenza uplot:

-   Usando npm: `$ npm install uplot-react uplot`
-   Usando yarn: `$ yarn add uplot-react uplot`

Hai anche bisogno di React versione 16.8 o superiore installato nella tua struttura di progetto.

## Come usare

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

Vedi la [demo live](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'demo live')

Puoi anche eseguire l'app demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demo ReactJS

semplice esempio per iniziare rapidamente.
[Demo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demo ReactJS')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Installazione

Installa il pacchetto uplot-vue con la dipendenza uplot:

-   Usando npm: `$ npm install uplot-vue uplot`
-   Usando yarn: `$ yarn add uplot-vue uplot`

Hai anche bisogno che Vue.js sia installato nella struttura del tuo progetto (sono supportate sia le versioni 2.6 che 3.x).

## Come usare

Utilizzo del template

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

Utilizzo di JSX

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

> Nota: Le modifiche alle proprietà tramite mutazione non sono supportate a causa di una [limitazione di Vue](https://github.com/vuejs/vue/issues/2164). È necessario creare una copia della proprietà, cioè sostituirla, consulta un [esempio](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) per l'idea generale.

## Demo

Vedi la [demo live Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Demo live Vue.js 2')

Puoi anche eseguire l'app demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Installazione

Installa il pacchetto uplot-svelte con la dipendenza uplot:

-   Usando npm: `$ npm install uplot-svelte uplot`
-   Usando yarn: `$ yarn add uplot-svelte uplot`

Hai anche bisogno che Svelte sia installato all'interno della struttura del tuo progetto. Il componente UplotSvelte è compatibile con progetti Svelte e SvelteKit.

## Come si usa

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

Consulta l'esempio [Esempio Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Esempio Svelte')

Puoi anche eseguire l'app demo localmente:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentazione

|    Parametro    |  Requisito  | Descrizione                                                                                                                                                                                               |
| :-------------: | :---------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  richiesto  | Opzioni per uPlot. Passate come primo argomento al costruttore uPlot: `new uPlot(options)`                                                                                                                |
|      data       |  richiesto  | Dati per uPlot. Passati come secondo argomento al costruttore uPlot: `new uPlot(options, data)`                                                                                                           |
|     target      |  opzionale  | Elemento html di destinazione per uPlot. Passato come terzo argomento al costruttore uPlot: `new uPlot(options, data, target)` Un nuovo elemento div di destinazione sarà creato automaticamente se non viene passato nelle props |
|    onCreate     |  opzionale  | Funzione di callback, invocata alla creazione o ricreazione dell'istanza uPlot                                                                                                                             |
|    onDelete     |  opzionale  | Funzione di callback, invocata prima che l'istanza uPlot venga distrutta, sia perché le props sono cambiate così tanto che è impossibile aggiornare il grafico, sia perché il componente sta per essere smontato |
| className/class |  opzionale  | Un nome classe passato all'elemento div di destinazione creato automaticamente. Il nome classe viene ignorato quando viene utilizzata la prop 'target'.                                                     |
|   resetScales   |  opzionale  | Flag che controlla se resettare le scale al cambio dei dati. Il valore predefinito è true.                                                                                                                 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---