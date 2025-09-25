
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

Một bộ sưu tập các trình bao bọc [uPlot](https://github.com/leeoniya/uPlot 'uPlot') cho phép bạn làm việc với biểu đồ theo cách khai báo trong framework yêu thích của mình.

**Mục lục**

-   [Động lực phát triển](#motivation)
-   [Bắt đầu sử dụng](#getting-started)
-   [React](#react)
    -   [Cài đặt](#installation)
    -   [Cách sử dụng](#how-to-use)
    -   [Demo](#demo)
-   [Vue.js](#vuejs)
    -   [Cài đặt](#installation-1)
    -   [Cách sử dụng](#how-to-use-1)
    -   [Demo](#demo-1)
-   [Svelte](#svelte)
    -   [Cài đặt](#installation-2)
    -   [Cách sử dụng](#how-to-use-2)
    -   [Demo](#demo-2)
-   [Tài liệu](#documentation)

# Động lực

Mặc dù đã có một số wrapper uPlot khác, tất cả đều gặp phải một trong những hạn chế sau:

1. Chúng tạo ra một instance uPlot duy nhất trong giai đoạn mount của component, và mong bạn tự xử lý toàn bộ logic cập nhật.
2. Chúng tạo lại instance uPlot mới mỗi khi props thay đổi, ngay cả khi instance có thể được cập nhật để phản ánh sự thay đổi.

So với các thư viện đó, thư viện này cố gắng không tạo lại instance uPlot khi props thay đổi. Thay vì tạo mới, nó sử dụng API công khai của uPlot để luôn đồng bộ với props.

# Bắt đầu

Xem các phần [React](#react), [Vue.js](#vuejs) hoặc [Svelte](#svelte) bên dưới tùy thuộc vào framework bạn đang sử dụng.
Cũng xem tài liệu API [tài liệu](#documentation) chung cho mọi framework.

# React

## Cài đặt

Cài đặt gói uplot-react cùng với phụ thuộc uplot:

-   Dùng npm: `$ npm install uplot-react uplot`
-   Dùng yarn: `$ yarn add uplot-react uplot`

Bạn cũng cần cài đặt React phiên bản 16.8 trở lên trong cây dự án của mình.

## Cách sử dụng

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

Xem [bản demo trực tiếp](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'bản demo trực tiếp')

Bạn cũng có thể chạy ứng dụng demo tại địa phương:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### Demo ReactJS

Ví dụ đơn giản để bắt đầu nhanh chóng.
[Demo ReactJS](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'Demo ReactJS')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## Cài đặt

Cài đặt gói uplot-vue cùng với phụ thuộc uplot:

-   Sử dụng npm: `$ npm install uplot-vue uplot`
-   Sử dụng yarn: `$ yarn add uplot-vue uplot`

Bạn cũng cần cài đặt Vue.js trong cây dự án của mình (hỗ trợ cả phiên bản 2.6 và 3.x).

## Cách sử dụng

Sử dụng template

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

Sử dụng JSX

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

> Lưu ý: Việc thay đổi thuộc tính bằng cách biến đổi không được hỗ trợ do [giới hạn của Vue](https://github.com/vuejs/vue/issues/2164). Bạn phải tạo một bản sao của thuộc tính, tức là thay thế nó, xem [ví dụ](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52) để hiểu ý tưởng chung.

## Demo

Xem [bản demo trực tiếp Vue.js 2](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')

Bạn cũng có thể chạy ứng dụng demo trên máy của mình:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## Cài đặt

Cài đặt gói uplot-svelte với phụ thuộc uplot:

-   Sử dụng npm: `$ npm install uplot-svelte uplot`
-   Sử dụng yarn: `$ yarn add uplot-svelte uplot`

Bạn cũng cần cài đặt Svelte trong cây dự án của mình. Thành phần UplotSvelte tương thích với các dự án Svelte và SvelteKit.

## Cách sử dụng

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

Xem ví dụ [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

Bạn cũng có thể chạy ứng dụng demo trên máy cục bộ:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# Tài liệu

|    Tham số      | Yêu cầu     | Mô tả                                                                                                                                                                                                      |
| :-------------: | :---------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  bắt buộc   | Tùy chọn cho uPlot. Được truyền vào làm đối số đầu tiên cho hàm khởi tạo uPlot: `new uPlot(options)`                                                                                                       |
|      data       |  bắt buộc   | Dữ liệu cho uPlot. Được truyền vào làm đối số thứ hai cho hàm khởi tạo uPlot: `new uPlot(options, data)`                                                                                                   |
|     target      |  tùy chọn   | Phần tử html đích cho uPlot. Được truyền vào làm đối số thứ ba cho hàm khởi tạo uPlot: `new uPlot(options, data, target)` Một phần tử div mới sẽ được tạo tự động nếu không truyền vào props                |
|    onCreate     |  tùy chọn   | Hàm callback, được gọi khi tạo hoặc tái tạo thể hiện uPlot                                                                                                                                                |
|    onDelete     |  tùy chọn   | Hàm callback, được gọi trước khi thể hiện uPlot bị hủy, có thể do props thay đổi quá nhiều khiến không thể cập nhật biểu đồ hoặc do component sắp bị loại bỏ                                               |
| className/class |  tùy chọn   | Tên class được truyền cho phần tử div đích được tạo tự động. Tên class sẽ bị bỏ qua nếu sử dụng prop 'target'.                                                                                            |
|   resetScales   |  tùy chọn   | Cờ điều khiển việc có reset lại các thang đo khi dữ liệu thay đổi hay không. Mặc định là true.                                                                                                             |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---