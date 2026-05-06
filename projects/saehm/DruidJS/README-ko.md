## DruidJS — 차원 축소를 위한 자바스크립트 라이브러리.

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJS는 차원 축소를 위한 자바스크립트 라이브러리입니다.  
차원 축소를 통해 고차원 데이터를 데이터의 메서드별 특성을 유지하면서 저차원으로 투영할 수 있습니다.  
DruidJS는 구현된 차원 축소 방법들로 데이터셋을 쉽게 투영할 수 있게 합니다.

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### 자료들

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
- [문서](https://saehm.github.io/DruidJS/index.html)
- [데모](https://renecutura.eu/druid_demo)
- [컨퍼런스 강연](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### 설치

npm을 사용하는 경우, `npm install @saehrimnir/druidjs`로 설치하고 다음과 같이 사용하십시오.


```js
import * as druid from "@saehrimnir/druidjs";
```

그렇지 않으면 [여기](https://github.com/saehm/DruidJS/releases/latest)에서 파일을 다운로드하거나, 예를 들어 [unpkg](https://unpkg.com/@saehrimnir/druidjs)를 다음과 같이 사용하세요:

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```
### 행렬

DruidJS는 내부적으로 데이터를 저장하기 위해 Matrix 클래스를 사용합니다. 예를 들어 `from` 함수를 사용하여 `druid.Matrix` 객체를 생성하여 사용할 수 있습니다:


```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

다음과 같이 프로그래밍 방식으로 `druid.Matrix` 객체를 생성할 수 있습니다:

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```

만약 `rows == columns` 이면, `matrix` 는 항등 행렬이 됩니다.
항등 행렬의 단축 표기법은 다음과 같습니다:

```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```
행렬을 생성하는 더 많은 단축키가 있습니다:


```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```

예를 들어 [d3](https://d3js.org)와 함께 `druid.Matrix` 객체를 사용하려면, `to2dArray` 속성, `iterate_rows` 제너레이터 함수, 또는 단순히 `druid.Matrix` 객체를 반복 가능(iterable)으로 사용하면 됩니다(버전 6부터 d3에서 작동).

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