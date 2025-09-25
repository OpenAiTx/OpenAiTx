
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Kolekcja wrapperów [uPlot](https://github.com/leeoniya/uPlot 'uPlot'), które pozwalają pracować z wykresami deklaratywnie w Twoim ulubionym frameworku.

**Spis treści**

-   [Motywacja](#motivation)
-   [Pierwsze kroki](#getting-started)
-   [React](#react)
    -   [Instalacja](#installation)
    -   [Jak używać](#how-to-use)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Instalacja](#installation-1)
    -   [Jak używać](#how-to-use-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Instalacja](#installation-2)
    -   [Jak używać](#how-to-use-2)
    -   [Demo](#demo-2)
-   [Dokumentacja](#documentation)

# Motywacja

Podczas gdy istnieje już kilka innych wrapperów uPlot, wszystkie mają jedno z następujących ograniczeń:

1. Tworzą instancję uPlot tylko raz, podczas montowania komponentu, i oczekują, że sam będziesz obsługiwać całą logikę aktualizacji.
2. Tworzą nową instancję uPlot za każdym razem, gdy zmieniają się propsy, nawet jeśli instancja może zostać zaktualizowana, aby odzwierciedlić zmiany.

W porównaniu ta biblioteka stara się nie tworzyć ponownie instancji uPlot po zmianie propsów. Zamiast rekreacji stara się używać publicznego API uPlot, aby utrzymać ją zgodną z propsami.

# Pierwsze kroki

Sprawdź sekcje [React](#react), [Vue.js](#vuejs) lub [Svelte](#svelte) poniżej, w zależności od używanego frameworka.
Zobacz także wspólną dla wszystkich frameworków [dokumentację](#documentation) API.

# React

## Instalacja

Zainstaluj paczkę uplot-react wraz z zależnością uplot:

-   Za pomocą npm: `$ npm install uplot-react uplot`
-   Za pomocą yarn: `$ yarn add uplot-react uplot`

Musisz także mieć zainstalowaną wersję React 16.8 lub wyższą w swoim projekcie.

## Jak używać

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

Zobacz [demo na żywo](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'demo na żywo')

Możesz także uruchomić aplikację demo lokalnie:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demo ReactJS

prosty przykład, aby szybko rozpocząć pracę.
[Demo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demo ReactJS')

![obraz](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Instalacja

Zainstaluj pakiet uplot-vue razem z zależnością uplot:

-   Używając npm: `$ npm install uplot-vue uplot`
-   Używając yarn: `$ yarn add uplot-vue uplot`

Musisz także mieć zainstalowany Vue.js w swoim projekcie (wspierane są wersje 2.6 oraz 3.x).

## Jak używać

Użycie szablonu

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

Używanie JSX

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

> Uwaga: Zmiany właściwości przez mutację nie są obsługiwane ze względu na [ograniczenie Vue](https://github.com/vuejs/vue/issues/2164). Musisz utworzyć kopię właściwości, tzn. zamiast tego ją zastąpić, zobacz [przykład](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52), aby poznać ogólny zamysł.

## Demo

Zobacz [demo na żywo dla Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

Możesz też uruchomić aplikację demo lokalnie:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Instalacja

Zainstaluj pakiet uplot-svelte wraz z zależnością uplot:

-   Za pomocą npm: `$ npm install uplot-svelte uplot`
-   Za pomocą yarn: `$ yarn add uplot-svelte uplot`

Musisz również zainstalować Svelte w drzewie projektu. Komponent UplotSvelte jest zgodny z projektami Svelte oraz SvelteKit.

## Jak używać

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

Zobacz przykład [przykład Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Przykład Svelte')

Możesz również uruchomić aplikację demo lokalnie:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Dokumentacja

|    Parametr     | Wymaganie   | Opis                                                                                                                                                                                                     |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  wymagany   | Opcje dla uPlot. Przekazywane jako pierwszy argument do konstruktora uPlot: `new uPlot(options)`                                                                                                         |
|      data       |  wymagany   | Dane dla uPlot. Przekazywane jako drugi argument do konstruktora uPlot: `new uPlot(options, data)`                                                                                                       |
|     target      |  opcjonalny | Docelowy element html dla uPlot. Przekazywany jako trzeci argument do konstruktora uPlot: `new uPlot(options, data, target)` Nowy docelowy element div zostanie utworzony automatycznie, jeśli żaden nie zostanie przekazany w propsach |
|    onCreate     |  opcjonalny | Funkcja zwrotna, wywoływana przy utworzeniu lub ponownym utworzeniu instancji uPlot                                                                                                                      |
|    onDelete     |  opcjonalny | Funkcja zwrotna, wywoływana przed zniszczeniem instancji uPlot, gdy propsy zmieniły się tak bardzo, że nie da się zaktualizować wykresu lub gdy komponent ma zostać odmontowany                         |
| className/class |  opcjonalny | Nazwa klasy przekazywana do automatycznie utworzonego docelowego elementu div. Nazwa klasy jest ignorowana, gdy używany jest props 'target'.                                                             |
|   resetScales   |  opcjonalny | Flaga kontrolująca, czy zresetować skale przy zmianie danych. Domyślnie ustawiona na true.                                                                                                               |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---