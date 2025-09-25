
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# ตัวห่อ uPlot

ชุดรวมของ [uPlot](https://github.com/leeoniya/uPlot 'uPlot') ตัวห่อที่ช่วยให้คุณทำงานกับกราฟแบบ declarative ภายในเฟรมเวิร์กที่คุณชื่นชอบ

**สารบัญ**

-   [แรงจูงใจ](#motivation)
-   [เริ่มต้นใช้งาน](#getting-started)
-   [React](#react)
    -   [การติดตั้ง](#installation)
    -   [วิธีการใช้งาน](#how-to-use)
    -   [สาธิต](#demo)
-   [Vue.js](#vuejs)
    -   [การติดตั้ง](#installation-1)
    -   [วิธีการใช้งาน](#how-to-use-1)
    -   [สาธิต](#demo-1)
-   [Svelte](#svelte)
    -   [การติดตั้ง](#installation-2)
    -   [วิธีการใช้งาน](#how-to-use-2)
    -   [สาธิต](#demo-2)
-   [เอกสารประกอบ](#documentation)

# แรงจูงใจ

แม้ว่าจะมีตัวห่อ uPlot อื่นๆ อยู่แล้ว แต่ทั้งหมดนั้นมีข้อจำกัดอย่างใดอย่างหนึ่งดังต่อไปนี้:

1. สร้างอินสแตนซ์ uPlot เพียงครั้งเดียว ในช่วงที่เมานต์คอมโพเนนต์ และคาดหวังให้คุณจัดการอัปเดตเองทั้งหมด
2. สร้างอินสแตนซ์ uPlot ใหม่ทุกครั้งที่ props เปลี่ยน แม้ว่าอินสแตนซ์สามารถอัปเดตเพื่อสะท้อนการเปลี่ยนแปลงได้ก็ตาม

เมื่อเปรียบเทียบ ไลบรารีนี้จะพยายามอย่างดีที่สุดที่จะไม่สร้างอินสแตนซ์ uPlot ขึ้นใหม่เมื่อ props เปลี่ยน แต่จะพยายามใช้ API สาธารณะของ uPlot เพื่อให้ทันกับ props แทน

# เริ่มต้นใช้งาน

ดูที่ส่วนของ [React](#react), [Vue.js](#vuejs) หรือ [Svelte](#svelte) ด้านล่าง ขึ้นอยู่กับเฟรมเวิร์กที่คุณใช้งาน
และดูเอกสาร API [documentation](#documentation) ที่ใช้ร่วมกันในทุกเฟรมเวิร์ก

# React

## การติดตั้ง

ติดตั้งแพ็คเกจ uplot-react พร้อมกับ uplot ที่เป็น dependency:

-   ใช้ npm: `$ npm install uplot-react uplot`
-   ใช้ yarn: `$ yarn add uplot-react uplot`

คุณต้องติดตั้ง React 16.8 หรือสูงกว่าไว้ในโปรเจกต์ของคุณด้วย

## วิธีการใช้งาน

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```

## สาธิต

ดู [สาธิตแบบสด](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')

คุณสามารถรันแอปสาธิตนี้ในเครื่องได้เช่นกัน:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### สาธิต ReactJS

ตัวอย่างง่ายๆ สำหรับการเริ่มต้นอย่างรวดเร็ว
[สาธิต ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## การติดตั้ง

ติดตั้งแพ็กเกจ uplot-vue พร้อมกับ dependency ของ uplot:

-   ใช้ npm: `$ npm install uplot-vue uplot`
-   ใช้ yarn: `$ yarn add uplot-vue uplot`

คุณยังต้องติดตั้ง Vue.js ภายในโปรเจกต์ของคุณด้วย (รองรับทั้งเวอร์ชัน 2.6 และ 3.x)

## วิธีใช้งาน

การใช้งานในเทมเพลต

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

การใช้ JSX

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

> หมายเหตุ: ไม่รองรับการเปลี่ยนแปลง property ด้วยการ mutate เนื่องจาก [ข้อจำกัดของ Vue](https://github.com/vuejs/vue/issues/2164) คุณจะต้องสร้างสำเนาของ property หรือแทนที่ property แทนที่จะเปลี่ยนแปลงโดยตรง ดู [ตัวอย่าง](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) เพื่อเข้าใจแนวคิดทั่วไป

## สาธิต

ดู [Vue.js 2 live demo](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

คุณยังสามารถรันแอปสาธิตนี้ในเครื่องได้เช่นกัน:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## การติดตั้ง

ติดตั้งแพคเกจ uplot-svelte พร้อมกับ uplot ที่เป็น dependency:

-   ใช้ npm: `$ npm install uplot-svelte uplot`
-   ใช้ yarn: `$ yarn add uplot-svelte uplot`

คุณต้องติดตั้ง Svelte ภายในโปรเจกต์ของคุณด้วย คอมโพเนนต์ UplotSvelte สามารถใช้งานกับโปรเจกต์ Svelte และ SvelteKit ได้

## วิธีใช้งาน

```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```

## เดโม

ดูตัวอย่าง [ตัวอย่าง Svelte](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'ตัวอย่าง Svelte')

คุณยังสามารถรันแอปเดโมในเครื่องได้ด้วย:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# เอกสารประกอบ

|    พารามิเตอร์    | ข้อกำหนด   | คำอธิบาย                                                                                                                                                                                                |
| :---------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options       |  จำเป็น     | ตัวเลือกสำหรับ uPlot. ส่งผ่านเป็นอาร์กิวเมนต์แรกไปยังคอนสตรัคเตอร์ของ uPlot: `new uPlot(options)`                                                                                                       |
|      data         |  จำเป็น     | ข้อมูลสำหรับ uPlot. ส่งผ่านเป็นอาร์กิวเมนต์ที่สองไปยังคอนสตรัคเตอร์ของ uPlot: `new uPlot(options, data)`                                                                                                |
|     target        |  ไม่จำเป็น  | องค์ประกอบ html เป้าหมายสำหรับ uPlot. ส่งผ่านเป็นอาร์กิวเมนต์ที่สามไปยังคอนสตรัคเตอร์ของ uPlot: `new uPlot(options, data, target)` จะสร้าง div เป้าหมายใหม่โดยอัตโนมัติหากไม่ได้ส่งผ่านใน props    |
|    onCreate       |  ไม่จำเป็น  | ฟังก์ชัน callback ที่ถูกเรียกเมื่อสร้างหรือสร้างใหม่ instance ของ uPlot                                                                                                                                |
|    onDelete       |  ไม่จำเป็น  | ฟังก์ชัน callback ที่ถูกเรียกก่อนที่ instance ของ uPlot จะถูกทำลาย ไม่ว่าจะเนื่องจาก props เปลี่ยนมากจนไม่สามารถอัปเดตกราฟได้ หรือเนื่องจากคอมโพเนนต์กำลังจะถูกถอดออก                                |
| className/class   |  ไม่จำเป็น  | ชื่อคลาสที่ส่งต่อไปยัง div เป้าหมายที่ถูกสร้างขึ้นโดยอัตโนมัติ จะไม่สนใจชื่อคลาสเมื่อใช้ prop 'target'                                                                                                |
|   resetScales     |  ไม่จำเป็น  | ธงควบคุมว่าจะรีเซ็ตสเกลเมื่อข้อมูลเปลี่ยนหรือไม่ ค่าเริ่มต้นเป็น true                                                                                                                                |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---