## DruidJS — 次元削減のためのJavaScriptライブラリ

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJSは次元削減のためのJavaScriptライブラリです。  
次元削減を用いることで、高次元データをデータのメソッド固有の特性を保ちながら低次元に射影できます。  
DruidJSは実装された次元削減手法でデータセットを簡単に射影できます。

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### リソース

```
@inproceedings{cutura2020druid,
  title={{DRUIDJS — A JavaScript Library for Dimensionality Reduction}},
  author={Cutura, Rene and Kralj, Christoph and Sedlmair, Michael},
  booktitle={2020 IEEE Visualization Conference (VIS)},
  pages={111--115},
  year={2020},
  organization={IEEE}
}
```
- [ドキュメント](https://saehm.github.io/DruidJS/index.html)
- [デモ](https://renecutura.eu/druid_demo)
- [カンファレンストーク](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### インストール

npmを使用する場合は、`npm install @saehrimnir/druidjs`でインストールし、以下のように使用します。


```js
import * as druid from "@saehrimnir/druidjs";
```

それ以外の場合は、[こちら](https://github.com/saehm/DruidJS/releases/latest)からファイルをダウンロードするか、例えば[unpkg](https://unpkg.com/@saehrimnir/druidjs)を次のように使用してください：

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```

### マトリックス

DruidJSは内部的にデータを格納するためにMatrixクラスを使用します。例えば、`from`関数を使って`druid.Matrix`オブジェクトを作成することで使用できます。

```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

プログラムで `druid.Matrix` オブジェクトを作成することができます：

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```

もし `rows == columns` なら、`matrix` は単位行列になります。
単位行列のショートカットは次のとおりです：

```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```

行列を作成するためのショートカットは他にもあります：

```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```
`druid.Matrix` オブジェクトを、例えば [d3](https://d3js.org) と共に使用したい場合、`to2dArray` プロパティ、`iterate_rows` ジェネレーター関数、または単に `druid.Matrix` オブジェクトをイテラブルとして使用することができます（d3 バージョン6以降で動作します）。


```js
let data = await d3.csv("data.csv");
let matrix = druid.Matrix.from(data);
d3.selectAll("datapoints").data(matrix.to2dArray); //...
d3.selectAll("datapoints").data(matrix.iterate_rows()); //...
d3.selectAll("datapoints").data(matrix); //...
```

### DR methods

#### Transform

[Example](https://observablehq.com/@saehrimnir/hello-druidjs)

#### Generator

[Example](https://observablehq.com/@saehrimnir/hello-druidjs/2)

#### TopoMap Example

[Example](https://observablehq.com/@saehrimnir/topomap)
...


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---