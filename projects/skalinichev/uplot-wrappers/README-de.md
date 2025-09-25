
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# uPlot Wrapper

Eine Sammlung von [uPlot](https://github.com/leeoniya/uPlot 'uPlot') Wrappern, die es ermöglichen, deklarativ mit Diagrammen innerhalb deines bevorzugten Frameworks zu arbeiten.

**Inhaltsverzeichnis**

-   [Motivation](#motivation)
-   [Erste Schritte](#getting-started)
-   [React](#react)
    -   [Installation](#installation)
    -   [Verwendung](#how-to-use)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Installation](#installation-1)
    -   [Verwendung](#how-to-use-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Installation](#installation-2)
    -   [Verwendung](#how-to-use-2)
    -   [Demo](#demo-2)
-   [Dokumentation](#documentation)

# Motivation

Obwohl bereits mehrere andere uPlot-Wrapper existieren, haben alle eine der folgenden Einschränkungen:

1. Sie erstellen die uPlot-Instanz nur einmal, während der Komponenteneinbindung, und erwarten, dass Sie die gesamte Update-Logik selbst übernehmen.
2. Sie erstellen die uPlot-Instanz bei jeder Änderung der Props neu, selbst wenn die Instanz aktualisiert werden könnte, um die Änderungen widerzuspiegeln.

Im Vergleich dazu versucht diese Bibliothek, die uPlot-Instanz nach einer Änderung der Props nicht neu zu erstellen. Statt einer Neuerstellung wird versucht, die öffentliche API von uPlot zu verwenden, um sie mit den Props aktuell zu halten.

# Einstieg

Siehe die Abschnitte zu [React](#react), [Vue.js](#vuejs) oder [Svelte](#svelte) unten, je nachdem, welches Framework Sie verwenden.
Siehe außerdem die API-[Dokumentation](#documentation), die für alle Frameworks gilt.

# React

## Installation

Installiere das Paket uplot-react mit der uplot-Abhängigkeit:

-   Mit npm: `$ npm install uplot-react uplot`
-   Mit yarn: `$ yarn add uplot-react uplot`

Du benötigst außerdem React 16.8 oder höher, das in deinem Projekt installiert sein muss.

## Verwendung

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

Siehe die [Live-Demo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'Live-Demo')

Sie können die Demo-App auch lokal ausführen:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS-Demo

Einfaches Beispiel für einen schnellen Einstieg.
[ReactJS-Demo](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS-Demo')

![Bild](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Installation

Installieren Sie das uplot-vue-Paket zusammen mit der uplot-Abhängigkeit:

-   Mit npm: `$ npm install uplot-vue uplot`
-   Mit yarn: `$ yarn add uplot-vue uplot`

Sie müssen außerdem Vue.js in Ihrem Projekt installiert haben (sowohl Version 2.6 als auch 3.x werden unterstützt).

## Verwendung

Verwendung mit Template

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

Verwendung von JSX

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

> Hinweis: Änderungen an Eigenschaften durch Mutation werden aufgrund einer [Vue-Einschränkung](https://github.com/vuejs/vue/issues/2164) nicht unterstützt. Sie müssen eine Kopie der Eigenschaft erstellen, d.h. sie ersetzen, siehe ein [Beispiel](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) für das allgemeine Vorgehen.

## Demo

Siehe die [Vue.js 2 Live-Demo](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

Sie können die Demo-App auch lokal ausführen:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Installation

Installieren Sie das uplot-svelte-Paket zusammen mit der uplot-Abhängigkeit:

-   Mit npm: `$ npm install uplot-svelte uplot`
-   Mit yarn: `$ yarn add uplot-svelte uplot`

Sie müssen außerdem Svelte in Ihrem Projekt installiert haben. Die UplotSvelte-Komponente ist mit Svelte- und SvelteKit-Projekten kompatibel.

## Verwendung

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

Siehe das Beispiel [Svelte-Beispiel](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

Sie können die Demo-App auch lokal ausführen:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Dokumentation

|    Parameter    | Voraussetzung | Beschreibung                                                                                                                                                                                               |
| :-------------: | :-----------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |   erforderlich   | Optionen für uPlot. Wird als erstes Argument an den uPlot-Konstruktor übergeben: `new uPlot(options)`                                                                                                    |
|      data       |   erforderlich   | Daten für uPlot. Wird als zweites Argument an den uPlot-Konstruktor übergeben: `new uPlot(options, data)`                                                                                                |
|     target      |   optional   | Ziel-HTML-Element für uPlot. Wird als drittes Argument an den uPlot-Konstruktor übergeben: `new uPlot(options, data, target)` Ein neues div-Ziel-Element wird automatisch erstellt, falls keines übergeben wird |
|    onCreate     |   optional   | Callback-Funktion, die beim Erstellen oder Neuerstellen der uPlot-Instanz aufgerufen wird                                                                                                                  |
|    onDelete     |   optional   | Callback-Funktion, die vor der Zerstörung der uPlot-Instanz aufgerufen wird, entweder weil sich die Props so stark geändert haben, dass ein Update unmöglich ist, oder weil die Komponente gleich entfernt wird |
| className/class |   optional   | Ein Klassenname, der an das automatisch erstellte Ziel-div-Element übergeben wird. Der Klassenname wird ignoriert, wenn die 'target'-Prop verwendet wird.                                                  |
|   resetScales   |   optional   | Flag, das steuert, ob die Skalen beim Datenwechsel zurückgesetzt werden sollen. Standardmäßig auf true gesetzt.                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---