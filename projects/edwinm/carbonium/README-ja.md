[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> 簡単なDOM操作のための1キロバイトライブラリ

carboniumを使うと、`$(selector)`を呼び出せば結果はDOM要素としても一致した要素の配列としてもアクセスできます。
DOM要素操作はすべての一致した要素に適用されます。

## 例

クラス`indent`を持つすべての要素の`left` CSSプロパティを40ピクセルに設定するには：

```javascript
$(".indent").style.left = "40px";
```

すべてのdiv要素のうち、内容が「priority」のものにクラス`important`を追加するには：

```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

carbonium を使って要素を作成できます:

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## インストール

```bash
npm install --save-dev carbonium
```

これでcarboniumをインポートできます：

```javascript
import { $ } from "carbonium";
```

webpackやrollup.jsのようなバンドラーをインストールや使用したくない場合、carboniumは以下のようにインポートできます：

```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```

## API

### 要素の選択

### `$(selector [, parentNode])`

#### パラメータ

| 名前       | 型                             | 説明                                                                      |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| selector   | string                         | 要素を選択するためのセレクター                                            |
| parentNode | Document \| Element (任意)     | セレクターを適用するドキュメントまたは要素。デフォルトは `document`       |

#### 戻り値

一致した要素の配列。単一の要素としてもアクセス可能。

### 要素の作成

### `$(html [, parentNode])`

#### パラメータ

| 名前       | 型                             | 説明                                                                      |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| html       | string                         | 作成する要素のHTML。"<"で始まる必要があります                            |
| parentNode | Document \| Element (任意)     | セレクターを適用するドキュメントまたは要素。デフォルトは `document`       |

#### 戻り値

作成された要素1つを含む配列。

## TypeScript

TypeScriptを使用する場合、CarboniumはTypeScriptで書かれており、すべての型定義が提供されていることを知っておくと良いでしょう。
ジェネリクスを使って特定の型の要素を宣言できます。
例えば、`HTMLInputElement`を指定すると `disabled` プロパティが利用可能になります：

```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```
## なぜ？

ほとんどのフレームワークはかなりかさばり、パフォーマンスが悪いことが多いと感じるかもしれません（[1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)）。
一方で、ネイティブのDOMを使って、DOM操作を行うたびに `document.querySelectorAll(selector)` と書くのは面倒に感じるかもしれません。
自分でヘルパー関数を書くこともできますが、それは痛みの一部を和らげるだけです。

Carboniumはフレームワークを使うこととネイティブDOMを使うことの間のちょうど良いバランスを見つけようとしています。

## jQuery

これは単なるjQueryではなく、もう時代遅れで悪い習慣ではないですか？

いいえ。CarboniumにはjQueryの欠点はありません：

1. Carboniumは非常に小さい：わずか約1キロバイトです。
2. 新しいAPIを学ぶ必要はなく、Carboniumは標準のDOM APIのみを提供します。

## ブラウザサポート

Carboniumはすべてのモダンブラウザでサポートされています。Firefox 79、Chrome 84、Safari 13、Edge 84のデスクトップとモバイルで動作がテストされています。
Proxyをサポートするすべてのブラウザで動作するはずです。対応状況は[Can I use Proxy](https://caniuse.com/#feat=proxy)を参照してください。

## 名前

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="ダイヤモンドとグラファイトの写真" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carboniumは炭素のラテン語名です。炭素には2つの形態（同素体）があります：グラファイトとダイヤモンド。
このライブラリも同様に、結果が一つの要素としても要素のリストとしても表現されます。

[写真 CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## ライセンス

Copyright 2023 [Edwin Martin](https://bitstorm.org/)、MITライセンスの下で公開されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---