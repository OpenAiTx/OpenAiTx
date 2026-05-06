## DruidJS — Una Biblioteca de JavaScript para la Reducción de Dimensionalidad.

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJS es una biblioteca de JavaScript para la reducción de dimensionalidad.
Con la reducción de dimensionalidad puedes proyectar datos de alta dimensión a una dimensionalidad menor mientras mantienes propiedades específicas del método de los datos.
DruidJS facilita la proyección de un conjunto de datos con los métodos de reducción de dimensionalidad implementados.

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### Recursos

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
- [Documentación](https://saehm.github.io/DruidJS/index.html)
- [Demostración](https://renecutura.eu/druid_demo)
- [Conferencia](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### Instalación

Si usas npm, instala con `npm install @saehrimnir/druidjs`, y úsalo con


```js
import * as druid from "@saehrimnir/druidjs";
```

De lo contrario, descargue los archivos [aquí](https://github.com/saehm/DruidJS/releases/latest), o use por ejemplo [unpkg](https://unpkg.com/@saehrimnir/druidjs) de esta manera:

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```

### Matriz

DruidJS utiliza internamente la clase Matriz para almacenar datos. Puedes usarla creando un objeto `druid.Matrix`, por ejemplo con la función `from`, como en el ejemplo:

```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

Puedes crear un objeto `druid.Matrix` programáticamente de la siguiente manera:

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```
Si `rows == columns`, entonces `matrix` sería una matriz identidad.  
Un atajo para una matriz identidad es:


```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```

Hay más atajos para crear matrices:

```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```
Si desea usar un objeto `druid.Matrix`, por ejemplo, con [d3](https://d3js.org), puede usar la propiedad `to2dArray`, la función generadora `iterate_rows`, o simplemente usar el objeto `druid.Matrix` como iterable (funciona con d3 desde la versión 6).


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