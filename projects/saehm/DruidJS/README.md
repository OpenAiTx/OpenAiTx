## DruidJS — A JavaScript Library for Dimensionality Reduction.

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJS is a JavaScript library for dimensionality reduction.
With dimesionality reduction you can project high-dimensional data to a lower dimensionality while keeping method-specific properties of the data.
DruidJS makes it easy to project a dataset with the implemented dimensionality reduction methods.

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### Resources

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

- [Documentation](https://saehm.github.io/DruidJS/index.html)
- [Demo](https://renecutura.eu/druid_demo)
- [Conference Talk](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### Installation

If you use npm, install with `npm install @saehrimnir/druidjs`, and use it with

```js
import * as druid from "@saehrimnir/druidjs";
```

Otherwise download the files [here](https://github.com/saehm/DruidJS/releases/latest), or use for instance [unpkg](https://unpkg.com/@saehrimnir/druidjs) this way:

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```

### Matrix

DruidJS uses internally the Matrix class for storing data. You can use it by creating a `druid.Matrix` object for instance with the function `from`, in example:

```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

You can create a `druid.Matrix` object programmatically by:

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```

If `rows == columns`, then `matrix` would be a identity matrix.
A shortcut for a identity matrix is:

```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```

There are more shortcuts for creating matrices:

```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```

If you want to use a `druid.Matrix` object, for instance, with [d3](https://d3js.org), you can use either the `to2dArray` property, the `iterate_rows` generator function, or just use the `druid.Matrix` object as an iterable (works with d3 since version 6).

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
