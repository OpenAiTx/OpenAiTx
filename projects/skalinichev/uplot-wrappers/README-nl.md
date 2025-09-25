
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

# uPlot-wrappers

Een verzameling [uPlot](https://github.com/leeoniya/uPlot 'uPlot') wrappers waarmee je declaratief met grafieken kunt werken binnen je favoriete framework.

**Inhoudsopgave**

-   [Motivatie](#motivation)
-   [Aan de slag](#getting-started)
-   [React](#react)
    -   [Installatie](#installatie)
    -   [Hoe te gebruiken](#hoe-te-gebruiken)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Installatie](#installatie-1)
    -   [Hoe te gebruiken](#hoe-te-gebruiken-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Installatie](#installatie-2)
    -   [Hoe te gebruiken](#hoe-te-gebruiken-2)
    -   [Demo](#demo-2)
-   [Documentatie](#documentatie)

# Motivatie

Hoewel er al verschillende andere uPlot wrappers bestaan, hebben ze allemaal één van de volgende beperkingen:

1. Ze creëren een uPlot instantie één keer, tijdens de component-mountfase, en verwachten dat je alle update-logica zelf afhandelt.
2. Ze maken een nieuwe uPlot instantie aan telkens wanneer de props veranderen, zelfs als de instantie gewoon geüpdatet kan worden om de wijzigingen weer te geven.

In vergelijking probeert deze bibliotheek zo goed mogelijk te voorkomen dat de uPlot instantie opnieuw wordt aangemaakt wanneer de props veranderen. In plaats van opnieuw aanmaken probeert het de openbare API van uPlot te gebruiken om deze up-to-date te houden met de props.

# Aan de slag

Zie de secties [React](#react), [Vue.js](#vuejs) of [Svelte](#svelte) hieronder, afhankelijk van welk framework je gebruikt.
Zie ook de API [documentatie](#documentatie) die gemeenschappelijk is voor alle frameworks.

# React

## Installatie

Installeer het uplot-react pakket met uplot als afhankelijkheid:

-   Met npm: `$ npm install uplot-react uplot`
-   Met yarn: `$ yarn add uplot-react uplot`

Je hebt ook React 16.8 of hoger nodig, geïnstalleerd binnen je projectstructuur.

## Hoe te gebruiken

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

Bekijk de [live demo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')

Je kunt de demo-app ook lokaal uitvoeren:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS Demo

eenvoudig voorbeeld om snel aan de slag te gaan.
[ReactJS Demo](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Installatie

Installeer het uplot-vue pakket met uplot als afhankelijkheid:

-   Gebruik npm: `$ npm install uplot-vue uplot`
-   Gebruik yarn: `$ yarn add uplot-vue uplot`

Je moet ook Vue.js geïnstalleerd hebben binnen je projectstructuur (zowel versie 2.6 als 3.x worden ondersteund).

## Hoe te gebruiken

Gebruik van template

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

JSX gebruiken

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

> Opmerking: Eigenschapswijzigingen door mutatie worden niet ondersteund vanwege [Vue-beperking](https://github.com/vuejs/vue/issues/2164). Je moet een kopie van de eigenschap maken, d.w.z. deze vervangen in plaats van muteren. Zie een [voorbeeld](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) voor het algemene idee.

## Demo

Bekijk de [Vue.js 2 live demo](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

Je kunt de demo-app ook lokaal uitvoeren:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Installatie

Installeer het uplot-svelte pakket met uplot als afhankelijkheid:

-   Met npm: `$ npm install uplot-svelte uplot`
-   Met yarn: `$ yarn add uplot-svelte uplot`

Je moet ook Svelte geïnstalleerd hebben binnen je projectmap. Het UplotSvelte component is compatibel met Svelte en SvelteKit projecten.

## Hoe te gebruiken

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

Zie het voorbeeld [Svelte voorbeeld](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte voorbeeld')

Je kunt de demo-app ook lokaal uitvoeren:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentatie

|    Parameter    | Vereiste    | Beschrijving                                                                                                                                                                                              |
| :-------------: | :---------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  vereist    | Opties voor uPlot. Worden als het eerste argument aan de uPlot constructor doorgegeven: `new uPlot(options)`                                                                                             |
|      data       |  vereist    | Data voor uPlot. Wordt als het tweede argument aan de uPlot constructor doorgegeven: `new uPlot(options, data)`                                                                                           |
|     target      |  optioneel  | Doel-html-element voor uPlot. Wordt als het derde argument aan de uPlot constructor doorgegeven: `new uPlot(options, data, target)` Een nieuw div-doel-element wordt automatisch aangemaakt als er geen wordt meegegeven in de props |
|    onCreate     |  optioneel  | Callback-functie, aangeroepen bij het aanmaken of opnieuw aanmaken van de uPlot instantie                                                                                                                 |
|    onDelete     |  optioneel  | Callback-functie, aangeroepen voordat de uPlot instantie wordt vernietigd, hetzij omdat de props zo veel zijn veranderd dat het onmogelijk is de grafiek bij te werken, hetzij omdat de component op het punt staat te worden ontkoppeld         |
| className/class |  optioneel  | Een class-naam die wordt meegegeven aan het automatisch aangemaakte doel-div-element. Class-naam wordt genegeerd wanneer de 'target'-prop gebruikt wordt.                                                 |
|   resetScales   |  optioneel  | Vlag die bepaalt of de schalen opnieuw moeten worden ingesteld bij een wijziging van de data. Standaard op true.                                                                                         |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---