# uPlot 래퍼

가장 좋아하는 프레임워크 내에서 선언적으로 차트를 작업할 수 있도록 해주는 [uPlot](https://github.com/leeoniya/uPlot 'uPlot') 래퍼 모음입니다.

**목차**

-   [동기](#motivation)
-   [시작하기](#getting-started)
-   [React](#react)
    -   [설치](#installation)
    -   [사용법](#how-to-use)
    -   [데모](#demo)
-   [Vue.js](#vuejs)
    -   [설치](#installation-1)
    -   [사용법](#how-to-use-1)
    -   [데모](#demo-1)
-   [Svelte](#svelte)
    -   [설치](#installation-2)
    -   [사용법](#how-to-use-2)
    -   [데모](#demo-2)
-   [문서](#documentation)

# 동기

이미 여러 uPlot 래퍼가 존재하지만, 모두 다음 중 하나의 제한 사항을 가지고 있습니다:

1. 컴포넌트 마운트 단계에서 uPlot 인스턴스를 한 번 생성하고, 모든 업데이트 로직을 직접 처리해야 합니다.
2. props가 변경될 때마다 인스턴스를 새로 생성하는데, 인스턴스를 업데이트하여 변경 사항을 반영할 수 있음에도 불구하고 재생성합니다.

이에 비해 이 라이브러리는 props가 변경되어도 uPlot 인스턴스를 재생성하지 않으려 최선을 다합니다. 재생성 대신 uPlot 공개 API를 사용하여 props와 인스턴스를 최신 상태로 유지하려고 합니다.

# 시작하기

사용하는 프레임워크에 따라 아래 [React](#react), [Vue.js](#vuejs) 또는 [Svelte](#svelte) 섹션을 참조하세요.
또한 모든 프레임워크에 공통적인 API [문서](#documentation)도 참고하세요.

# React

## 설치

uplot 의존성과 함께 uplot-react 패키지 설치:

-   npm 사용: `$ npm install uplot-react uplot`
-   yarn 사용: `$ yarn add uplot-react uplot`

프로젝트 트리에 React 16.8 이상이 설치되어 있어야 합니다.

## 사용 방법

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```
## 데모

[라이브 데모](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')를 참조하세요.

로컬에서 데모 앱을 실행할 수도 있습니다:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS 데모

빠르게 시작하기 위한 간단한 예제입니다.
[ReactJS 데모](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## 설치

uplot 종속성과 함께 uplot-vue 패키지를 설치하세요:

-   npm 사용: `$ npm install uplot-vue uplot`
-   yarn 사용: `$ yarn add uplot-vue uplot`

프로젝트 트리 내에 Vue.js가 설치되어 있어야 합니다 (2.6 및 3.x 버전 모두 지원).

## 사용 방법

템플릿 사용법


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

JSX 사용하기

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
> 참고: [Vue 제한사항](https://github.com/vuejs/vue/issues/2164)으로 인해 변이(mutation)에 의한 속성 변경은 지원되지 않습니다. 속성의 복사본을 만들어 교체해야 하며, 일반적인 아이디어는 [예제](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52)를 참조하세요.

## 데모

[Vue.js 2 라이브 데모](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')를 확인하세요.

로컬에서 데모 앱을 실행할 수도 있습니다:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## 설치

uplot 의존성과 함께 uplot-svelte 패키지를 설치하세요:

-   npm 사용: `$ npm install uplot-svelte uplot`
-   yarn 사용: `$ yarn add uplot-svelte uplot`

프로젝트 트리 내에 Svelte가 설치되어 있어야 합니다. UplotSvelte 컴포넌트는 Svelte와 SvelteKit 프로젝트와 호환됩니다.

## 사용 방법


```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```
## 데모

예제 보기 [Svelte 예제](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example')

로컬에서 데모 앱을 실행할 수도 있습니다:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# 문서

|    매개변수     | 필수 여부  | 설명                                                                                                                                                                                                     |
| :-------------: | :--------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options     |  필수      | uPlot의 옵션. uPlot 생성자의 첫 번째 인수로 전달: `new uPlot(options)`                                                                                                                                |
|      data       |  필수      | uPlot의 데이터. uPlot 생성자의 두 번째 인수로 전달: `new uPlot(options, data)`                                                                                                                        |
|     target      |  선택      | uPlot의 대상 HTML 요소. uPlot 생성자의 세 번째 인수로 전달: `new uPlot(options, data, target)` props에 전달되지 않으면 자동으로 새로운 div 대상 요소가 생성됩니다                                  |
|    onCreate     |  선택      | uPlot 인스턴스 생성 또는 재생성 시 호출되는 콜백 함수                                                                                                                                                  |
|    onDelete     |  선택      | uPlot 인스턴스가 파괴되기 전에 호출되는 콜백 함수, props가 너무 많이 변경되어 차트를 업데이트할 수 없거나 컴포넌트가 마운트 해제되기 직전                                                               |
| className/class |  선택      | 자동 생성된 대상 div 요소에 전달되는 클래스 이름. 'target' prop이 사용될 경우 클래스 이름은 무시됩니다                                                                                                   |
|   resetScales   |  선택      | 데이터 변경 시 스케일을 리셋할지 여부를 제어하는 플래그. 기본값은 true입니다.                                                                                                                           |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---