
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# uPlot sarmalayıcıları

[UPlot](https://github.com/leeoniya/uPlot 'uPlot') için favori framework’ünüzde grafiklerle deklaratif olarak çalışmanızı sağlayan bir sarmalayıcı koleksiyonu.

**İçindekiler**

-   [Motivasyon](#motivation)
-   [Başlangıç](#getting-started)
-   [React](#react)
    -   [Kurulum](#kurulum)
    -   [Nasıl kullanılır](#nasıl-kullanılır)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Kurulum](#kurulum-1)
    -   [Nasıl kullanılır](#nasıl-kullanılır-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Kurulum](#kurulum-2)
    -   [Nasıl kullanılır](#nasıl-kullanılır-2)
    -   [Demo](#demo-2)
-   [Dokümantasyon](#dokümantasyon)

# Motivasyon

Diğer uPlot sarmalayıcılarının birkaçı zaten mevcutken, hepsi aşağıdaki sınırlamalardan birine sahip:

1. uPlot örneğini yalnızca bileşen montaj aşamasında oluştururlar ve tüm güncelleme mantığını kendinizin yönetmesini beklerler.
2. Özellikler değiştiğinde uPlot örneğini baştan yeniden oluştururlar, örnek güncellenerek değişiklikleri yansıtabilecek olsa bile.

Buna kıyasla bu kütüphane, özellikler değiştiğinde uPlot örneğini yeniden oluşturmamaya özen gösterir. Yeniden oluşturmak yerine, uPlot'un genel API'sini kullanarak örneği özelliklerle güncel tutmaya çalışır.

# Başlangıç

Kullandığınız çerçeveye bağlı olarak aşağıdaki [React](#react), [Vue.js](#vuejs) veya [Svelte](#svelte) bölümlerine bakın.
Ayrıca tüm çerçeveler için ortak olan API [dokümantasyonuna](#dokümantasyon) bakın.

# React

## Kurulum

uplot-react paketini uplot bağımlılığı ile kurun:

-   npm ile: `$ npm install uplot-react uplot`
-   yarn ile: `$ yarn add uplot-react uplot`

Ayrıca projeniz içinde React 16.8 veya üzeri kurulu olmalıdır.

## Nasıl kullanılır

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

[canlı demoyu](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'canlı demo') inceleyin

Ayrıca demo uygulamasını yerel olarak çalıştırabilirsiniz:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS Demo

Hızlıca başlamak için basit bir örnek.
[ReactJS Demo](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Kurulum

uplot bağımlılığı ile birlikte uplot-vue paketini yükleyin:

-   npm ile: `$ npm install uplot-vue uplot`
-   yarn ile: `$ yarn add uplot-vue uplot`

Ayrıca projenizin içinde Vue.js'in kurulu olması gerekmektedir (hem 2.6 hem de 3.x sürümleri desteklenir).

## Nasıl kullanılır

Şablon kullanımı

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

JSX Kullanımı

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

> Not: Özellik değişiklikleri mutasyonla desteklenmemektedir, bunun nedeni [Vue sınırlaması](https://github.com/vuejs/vue/issues/2164)'dır. Özelliğin bir kopyasını oluşturmanız, yani onu değiştirmeniz gerekmektedir. Genel fikir için [örneğe](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) bakabilirsiniz.

## Demo

[Vue.js 2 canlı demosuna](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 canlı demo') göz atın

Demo uygulamasını yerel olarak da çalıştırabilirsiniz:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Kurulum

uplot bağımlılığı ile birlikte uplot-svelte paketini yükleyin:

-   npm kullanarak: `$ npm install uplot-svelte uplot`
-   yarn kullanarak: `$ yarn add uplot-svelte uplot`

Ayrıca projenizin dizininde Svelte'in kurulu olması gerekir. UplotSvelte bileşeni, Svelte ve SvelteKit projeleriyle uyumludur.

## Nasıl kullanılır

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

Örneğe bakın [Svelte örneği](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte örneği')

Demo uygulamasını yerel olarak da çalıştırabilirsiniz:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Dokümantasyon

|    Parametre    | Gereklilik | Açıklama                                                                                                                                                                                                |
| :-------------: | :--------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |   gerekli  | uPlot için seçenekler. uPlot yapıcısına ilk argüman olarak iletilir: `new uPlot(options)`                                                                                                               |
|      data       |   gerekli  | uPlot için veri. uPlot yapıcısına ikinci argüman olarak iletilir: `new uPlot(options, data)`                                                                                                           |
|     target      |   isteğe bağlı  | uPlot için hedef html elementi. uPlot yapıcısına üçüncü argüman olarak iletilir: `new uPlot(options, data, target)` Eğer props ile bir hedef iletilmezse otomatik olarak yeni bir div elementi oluşturulur |
|    onCreate     |   isteğe bağlı  | uPlot örneği oluşturulduğunda veya yeniden oluşturulduğunda çağrılan geri çağırma fonksiyonu                                                                                                        |
|    onDelete     |   isteğe bağlı  | uPlot örneği yok edilmeden önce çağrılan geri çağırma fonksiyonu, ya grafik güncellenemeyecek kadar çok props değiştiği için ya da bileşen kaldırılmak üzere olduğu için                           |
| className/class |   isteğe bağlı  | Otomatik olarak oluşturulan hedef div elementine iletilen sınıf adı. 'target' props'u kullanıldığında sınıf adı dikkate alınmaz.                                                                    |
|   resetScales   |   isteğe bağlı  | Veri değiştiğinde ölçeklerin sıfırlanıp sıfırlanmayacağını kontrol eden bayrak. Varsayılan değer true'dur.                                                                                          |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---