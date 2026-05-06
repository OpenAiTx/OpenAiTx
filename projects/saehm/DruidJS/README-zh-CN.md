## DruidJS — 一个用于降维的JavaScript库。

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJS 是一个用于降维的 JavaScript 库。  
通过降维，您可以将高维数据投影到较低维度，同时保持数据的特定方法属性。  
DruidJS 使得使用实现的降维方法投影数据集变得简单。

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### 资源

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

- [文档](https://saehm.github.io/DruidJS/index.html)
- [演示](https://renecutura.eu/druid_demo)
- [会议演讲](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### 安装

如果您使用 npm，使用 `npm install @saehrimnir/druidjs` 安装，然后使用它

```js
import * as druid from "@saehrimnir/druidjs";
```

否则请从[这里](https://github.com/saehm/DruidJS/releases/latest)下载文件，或者例如使用[unpkg](https://unpkg.com/@saehrimnir/druidjs)，方式如下：

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```

### 矩阵

DruidJS 内部使用 Matrix 类来存储数据。您可以通过使用函数 `from` 创建一个 `druid.Matrix` 对象来使用它，例如： 

```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

你可以通过编程方式创建一个 `druid.Matrix` 对象：

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```

如果 `rows == columns`，那么 `matrix` 将是一个单位矩阵。
单位矩阵的简写是：

```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```
还有更多创建矩阵的快捷方式：


```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```
如果你想使用 `druid.Matrix` 对象，例如，与 [d3](https://d3js.org) 一起使用，你可以使用 `to2dArray` 属性、`iterate_rows` 生成器函数，或者直接将 `druid.Matrix` 对象作为可迭代对象（自 d3 版本6起支持）。


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