
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

Une collection de wrappers [uPlot](https://github.com/leeoniya/uPlot 'uPlot') qui vous permettent de travailler avec des graphiques de manière déclarative dans votre framework préféré.

**Table des matières**

-   [Motivation](#motivation)
-   [Commencer](#getting-started)
-   [React](#react)
    -   [Installation](#installation)
    -   [Comment utiliser](#how-to-use)
    -   [Démo](#demo)
-   [Vue.js](#vuejs)
    -   [Installation](#installation-1)
    -   [Comment utiliser](#how-to-use-1)
    -   [Démo](#demo-1)
-   [Svelte](#svelte)
    -   [Installation](#installation-2)
    -   [Comment utiliser](#how-to-use-2)
    -   [Démo](#demo-2)
-   [Documentation](#documentation)

# Motivation

Bien que plusieurs autres wrappers uPlot existent déjà, tous présentent l'une des limitations suivantes :

1. Ils créent l'instance uPlot une seule fois, lors de la phase de montage du composant, et attendent que vous gériez toute la logique de mise à jour vous-même.
2. Ils recréent l'instance uPlot à chaque modification des props, même si l'instance peut être mise à jour pour refléter les changements.

En comparaison, cette bibliothèque fait de son mieux pour ne pas recréer l'instance uPlot lorsque les props changent. Au lieu de la recréer, elle essaie d'utiliser l'API publique de uPlot pour la maintenir à jour avec les props.

# Pour bien démarrer

Voir les sections [React](#react), [Vue.js](#vuejs) ou [Svelte](#svelte) ci-dessous selon le framework que vous utilisez.
Consultez également la [documentation](#documentation) de l’API commune à tous les frameworks.

# React

## Installation

Installez le package uplot-react avec la dépendance uplot :

-   Avec npm : `$ npm install uplot-react uplot`
-   Avec yarn : `$ yarn add uplot-react uplot`

Vous devez également avoir React 16.8 ou supérieur installé dans votre projet.

## Comment utiliser

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## Démo

Voir la [démo en direct](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'démo en direct')

Vous pouvez également exécuter l'application de démonstration localement :

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Démo ReactJS

exemple simple pour démarrer rapidement.
[Démo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Démo ReactJS')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Installation

Installez le package uplot-vue avec la dépendance uplot :

-   Avec npm : `$ npm install uplot-vue uplot`
-   Avec yarn : `$ yarn add uplot-vue uplot`

Vous devez également avoir Vue.js installé dans votre projet (les versions 2.6 et 3.x sont supportées).

## Comment utiliser

Utilisation avec un template

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

Utilisation de JSX

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
> Remarque : Les modifications de propriétés par mutation ne sont pas prises en charge en raison d'une [limitation de Vue](https://github.com/vuejs/vue/issues/2164). Vous devez créer une copie de la propriété, c’est-à-dire la remplacer à la place, voir un [exemple](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) pour l’idée générale.

## Démo

Voir la [démo en direct Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Démo en direct Vue.js 2')

Vous pouvez également exécuter l’application de démonstration localement :

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2 :

`$ yarn run serveVue`

Vue.js 3 :

`$ yarn run serveVue3`

# Svelte

## Installation

Installez le package uplot-svelte avec la dépendance uplot :

-   Avec npm : `$ npm install uplot-svelte uplot`
-   Avec yarn : `$ yarn add uplot-svelte uplot`

Vous devez également avoir Svelte installé dans votre projet. Le composant UplotSvelte est compatible avec les projets Svelte et SvelteKit.

## Comment utiliser


```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## Démo

Voir l'exemple [Exemple Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Exemple Svelte')

Vous pouvez également exécuter l'application de démonstration localement :

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Documentation

|    Paramètre    | Exigence   | Description                                                                                                                                                                                                |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  requis    | Options pour uPlot. Passées comme premier argument au constructeur uPlot : `new uPlot(options)`                                                                                                             |
|      data       |  requis    | Données pour uPlot. Passées comme second argument au constructeur uPlot : `new uPlot(options, data)`                                                                                                       |
|     target      |  optionnel | Élément html cible pour uPlot. Passé comme troisième argument au constructeur uPlot : `new uPlot(options, data, target)` Un nouvel élément div cible sera créé automatiquement si aucun n'est passé dans les props |
|    onCreate     |  optionnel | Fonction callback, invoquée lors de la création ou recréation d'une instance uPlot                                                                                                                        |
|    onDelete     |  optionnel | Fonction callback, invoquée avant la destruction de l'instance uPlot, soit parce que les props ont tellement changé qu'il est impossible de mettre à jour le graphique, soit parce que le composant est sur le point d'être démonté |
| className/class |  optionnel | Un nom de classe passé à l'élément div cible créé automatiquement. Le nom de classe est ignoré lorsque la prop 'target' est utilisée.                                                                      |
|   resetScales   |  optionnel | Indicateur contrôlant si les échelles doivent être réinitialisées lors du changement de données. Par défaut à true.                                                                                       |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---