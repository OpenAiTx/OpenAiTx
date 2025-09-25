
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# uPlot ラッパー

お気に入りのフレームワーク内で宣言的にチャートを扱えるようにする、[uPlot](https://github.com/leeoniya/uPlot 'uPlot') のラッパー集です。

**目次**

-   [動機](#motivation)
-   [はじめに](#getting-started)
-   [React](#react)
    -   [インストール](#installation)
    -   [使い方](#how-to-use)
    -   [デモ](#demo)
-   [Vue.js](#vuejs)
    -   [インストール](#installation-1)
    -   [使い方](#how-to-use-1)
    -   [デモ](#demo-1)
-   [Svelte](#svelte)
    -   [インストール](#installation-2)
    -   [使い方](#how-to-use-2)
    -   [デモ](#demo-2)
-   [ドキュメント](#documentation)

# モチベーション

他にもいくつかのuPlotラッパーがすでに存在していますが、それらは以下のいずれかの制限があります。

1. コンポーネントのマウント時にuPlotインスタンスを一度だけ生成し、以降の更新ロジックは全てユーザーが管理する必要がある。
2. propsが変更されるたびにuPlotインスタンスを毎回新規作成してしまい、インスタンスの更新で済む場合でも再生成される。

これに対して、本ライブラリはpropsが変更されてもuPlotインスタンスを極力再生成しません。再作成するのではなく、uPlotの公開APIを利用してpropsの変更に追従します。

# はじめに

ご利用のフレームワークに応じて、以下の[React](#react)、[Vue.js](#vuejs)、または[Svelte](#svelte)のセクションをご覧ください。
また、全てのフレームワークに共通するAPIの[ドキュメント](#documentation)も参照してください。

# React

## インストール

uplot-reactパッケージとuplot依存パッケージをインストールします:

-   npmの場合: `$ npm install uplot-react uplot`
-   yarnの場合: `$ yarn add uplot-react uplot`

また、プロジェクト内にReact 16.8以上がインストールされている必要があります。

## 使い方

```javascript
import React from 'react';
import uPlot from 'uplot';
import UplotReact from 'uplot-react';
import 'uplot/dist/uPlot.min.css';

const Chart = () => (
    <UplotReact options={options} data={data} target={target} onCreate={(chart) => {}} onDelete={(chart) => {}} />
);
```
## デモ

[ライブデモ](https://codesandbox.io/s/uplot-react-6ykeb?file=/react/uplot-react-example.tsx 'live demo')をご覧ください

デモアプリをローカルで実行することもできます：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveReact`

### ReactJS デモ

すぐに始められるシンプルな例です。
[ReactJS デモ](https://github.com/skalinichev/uplot-wrappers/blob/master/react/uplot-react-simple.js 'ReactJS Demo')

![image](https://user-images.githubusercontent.com/62290677/233559830-5dea130c-11a3-434e-9cce-d4f00dc9bea8.png)

# Vue.js

## インストール

uplot依存のuplot-vueパッケージをインストールします：

-   npmを使用：`$ npm install uplot-vue uplot`
-   yarnを使用：`$ yarn add uplot-vue uplot`

プロジェクトツリー内にVue.jsがインストールされている必要があります（2.6および3.xの両バージョンがサポートされています）。

## 使い方

テンプレートを使用して


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

JSXの使用方法

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
> 注意: プロパティの変更は [Vueの制限](https://github.com/vuejs/vue/issues/2164) によりミューテーションによる変更はサポートされていません。プロパティのコピーを作成し、つまり置き換える必要があります。一般的なアイデアについては、[例](https://github.com/skalinichev/uplot-wrappers/blob/master/vue/uplot-vue-example.tsx#L52)を参照してください。

## デモ

[Vue.js 2 ライブデモ](https://codesandbox.io/s/uplot-vue-khi4m?file=/vue/uplot-vue-example.tsx 'Vue.js 2 live demo')をご覧ください。

デモアプリはローカルでも実行できます:

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install`

Vue.js 2:

`$ yarn run serveVue`

Vue.js 3:

`$ yarn run serveVue3`

# Svelte

## インストール

uplot依存のuplot-svelteパッケージをインストールします:

-   npmを使用する場合: `$ npm install uplot-svelte uplot`
-   yarnを使用する場合: `$ yarn add uplot-svelte uplot`

プロジェクトツリー内にSvelteがインストールされている必要があります。UplotSvelteコンポーネントはSvelteおよびSvelteKitプロジェクトに対応しています。

## 使い方


```sveltehtml
<script lang="ts">
    import UplotSvelte from 'uplot-svelte';
    import uPlot from 'uplot';
    import 'uplot/dist/uPlot.min.css';

    ...
</script>

<UplotSvelte {options} {data} onCreate={onCreate} onDelete={onDelete} />
```
## デモ

例は [Svelte example](https://github.com/skalinichev/uplot-wrappers/blob/master/svelte/svelte-example.svelte 'Svelte example') を参照してください。

デモアプリをローカルで実行することもできます：

`$ git clone https://github.com/skalinichev/uplot-wrappers.git`

`$ cd uplot-wrappers && yarn install && yarn run serveSvelte`

# ドキュメント

|    パラメーター    | 必須かどうか | 説明                                                                                                                                                                                                     |
| :----------------: | :----------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|     options        |  必須       | uPlot のオプション。uPlot コンストラクタの第一引数として渡されます：`new uPlot(options)`                                                                                                              |
|      data          |  必須       | uPlot のデータ。uPlot コンストラクタの第二引数として渡されます：`new uPlot(options, data)`                                                                                                            |
|     target         |  任意       | uPlot のターゲットとなる HTML 要素。uPlot コンストラクタの第三引数として渡されます：`new uPlot(options, data, target)` props で渡されない場合は新しい div 要素が自動で作成されます                      |
|    onCreate        |  任意       | uPlot インスタンス作成または再作成時に呼び出されるコールバック関数                                                                                                                                    |
|    onDelete        |  任意       | uPlot インスタンスが破棄される前に呼び出されるコールバック関数。props が大幅に変更されチャートの更新が不可能な場合やコンポーネントのアンマウント直前に呼ばれます                                    |
| className/class    |  任意       | 自動作成されるターゲット div 要素に渡されるクラス名。'target' prop が使用されている場合はクラス名は無視されます                                                                                      |
|   resetScales      |  任意       | データ変更時にスケールをリセットするかを制御するフラグ。デフォルトは true です。                                                                                                                       |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---