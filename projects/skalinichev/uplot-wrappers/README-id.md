
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

Kumpulan pembungkus [uPlot](https://github.com/leeoniya/uPlot 'uPlot') yang memungkinkan Anda bekerja dengan grafik secara deklaratif di dalam framework favorit Anda.

**Daftar Isi**

-   [Motivasi](#motivation)
-   [Memulai](#getting-started)
-   [React](#react)
    -   [Instalasi](#installation)
    -   [Cara menggunakan](#how-to-use)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Instalasi](#installation-1)
    -   [Cara menggunakan](#how-to-use-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Instalasi](#installation-2)
    -   [Cara menggunakan](#how-to-use-2)
    -   [Demo](#demo-2)
-   [Dokumentasi](#documentation)

# Motivasi

Meskipun beberapa pembungkus uPlot lainnya sudah ada, semuanya memiliki salah satu keterbatasan berikut:

1. Mereka membuat instance uPlot sekali, saat fase mounting komponen, dan mengharapkan Anda menangani semua logika pembaruan sendiri.
2. Mereka membuat ulang instance uPlot setiap kali props berubah, meskipun instance tersebut dapat diperbarui agar mencerminkan perubahan.

Sebagai perbandingan, pustaka ini berusaha sebaik mungkin untuk tidak membuat ulang instance uPlot saat props berubah. Alih-alih membuat ulang, pustaka ini mencoba menggunakan API publik uPlot untuk menjaga instance tetap sinkron dengan props.

# Memulai

Lihat bagian [React](#react), [Vue.js](#vuejs) atau [Svelte](#svelte) di bawah sesuai framework yang Anda gunakan.
Juga lihat [dokumentasi](#documentation) API yang berlaku untuk semua framework.

# React

## Instalasi

Instal paket uplot-react beserta dependensi uplot:

-   Menggunakan npm: `$ npm install uplot-react uplot`
-   Menggunakan yarn: `$ yarn add uplot-react uplot`

Anda juga perlu menginstal React versi 16.8 atau di atasnya di dalam pohon proyek Anda.

## Cara menggunakan

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

Lihat [demo langsung](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'demo langsung')

Anda juga dapat menjalankan aplikasi demo secara lokal:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demo ReactJS

Contoh sederhana untuk memulai dengan cepat.
[Demo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demo ReactJS')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Instalasi

Instal paket uplot-vue beserta dependensi uplot:

-   Menggunakan npm: `$ npm install uplot-vue uplot`
-   Menggunakan yarn: `$ yarn add uplot-vue uplot`

Anda juga perlu memasang Vue.js di dalam pohon proyek Anda (baik versi 2.6 maupun 3.x didukung).

## Cara menggunakan

Menggunakan template

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

Menggunakan JSX

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

> Catatan: Perubahan properti dengan mutasi tidak didukung karena [batasan Vue](https://github.com/vuejs/vue/issues/2164) Anda harus membuat salinan properti, yaitu menggantinya, lihat [contoh](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) untuk gambaran umum.

## Demo

Lihat [demo langsung Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Demo langsung Vue.js 2')

Anda juga dapat menjalankan aplikasi demo secara lokal:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Instalasi

Instal paket uplot-svelte beserta dependensi uplot:

-   Menggunakan npm: `$ npm install uplot-svelte uplot`
-   Menggunakan yarn: `$ yarn add uplot-svelte uplot`

Anda juga perlu menginstal Svelte di dalam pohon proyek Anda. Komponen UplotSvelte kompatibel dengan proyek Svelte dan SvelteKit.

## Cara penggunaan

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

Lihat contoh [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

Anda juga dapat menjalankan aplikasi demo secara lokal:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Dokumentasi

|    Parameter    | Persyaratan | Deskripsi                                                                                                                                                                                             |
| :-------------: | :---------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  wajib      | Opsi untuk uPlot. Diberikan sebagai argumen pertama pada konstruktor uPlot: `new uPlot(options)`                                                                                                     |
|      data       |  wajib      | Data untuk uPlot. Diberikan sebagai argumen kedua pada konstruktor uPlot: `new uPlot(options, data)`                                                                                                 |
|     target      |  opsional   | Elemen html target untuk uPlot. Diberikan sebagai argumen ketiga pada konstruktor uPlot: `new uPlot(options, data, target)` Elemen div target baru akan dibuat otomatis jika tidak diberikan di props |
|    onCreate     |  opsional   | Fungsi callback, dipanggil saat pembuatan atau pembuatan ulang instance uPlot                                                                                                                        |
|    onDelete     |  opsional   | Fungsi callback, dipanggil sebelum instance uPlot dihancurkan, baik karena props berubah sangat banyak sehingga tidak mungkin memperbarui chart atau karena komponen akan di-unmount                  |
| className/class |  opsional   | Nama class yang diberikan ke elemen div target yang dibuat secara otomatis. Nama class diabaikan saat properti 'target' digunakan.                                                                  |
|   resetScales   |  opsional   | Flag yang mengontrol apakah akan me-reset skala saat data berubah. Default-nya true.                                                                                                                 |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---