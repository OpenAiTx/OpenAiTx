## DruidJS — Une bibliothèque JavaScript pour la réduction de dimensionnalité.

<a href="#"><img src="https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/icon.svg" width=80 align="left" hspace="10" vspace="6"></a>

DruidJS est une bibliothèque JavaScript pour la réduction de dimensionnalité.
Avec la réduction de dimensionnalité, vous pouvez projeter des données de haute dimensionnalité vers une dimensionnalité inférieure tout en conservant les propriétés spécifiques à la méthode des données.
DruidJS facilite la projection d’un jeu de données avec les méthodes de réduction de dimensionnalité implémentées.

<br>

![Codecov](https://img.shields.io/codecov/c/github/saehm/DruidJS)
![NPM Downloads](https://img.shields.io/npm/dw/%40saehrimnir%2Fdruidjs)
![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/saehm/DruidJS/release.yml?event=build-and-test)
[![License](https://img.shields.io/github/license/saehm/DruidJS)](https://raw.githubusercontent.com/saehm/DruidJS/refs/heads/master/LICENCE)
[![DOI:10.1109/VIS47514.2020.00029](https://img.shields.io/badge/DOI-10.1109%2FVIS47514.2020.00029-blue)](https://doi.org/10.1109/VIS47514.2020.00029)
### Ressources

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
- [Démo](https://renecutura.eu/druid_demo)
- [Présentation conférence](https://youtu.be/bi6FfsWV_9k?t=2463) [IEEEVIS2020](http://ieeevis.org/year/2020/welcome)

### Installation

Si vous utilisez npm, installez avec `npm install @saehrimnir/druidjs`, et utilisez-le avec

```js
import * as druid from "@saehrimnir/druidjs";
```

Sinon, téléchargez les fichiers [ici](https://github.com/saehm/DruidJS/releases/latest), ou utilisez par exemple [unpkg](https://unpkg.com/@saehrimnir/druidjs) de cette manière :

```html
<script src="https://unpkg.com/@saehrimnir/druidjs"></script>
```

### Matrice

DruidJS utilise en interne la classe Matrix pour stocker les données. Vous pouvez l’utiliser en créant un objet `druid.Matrix` par exemple avec la fonction `from`, comme suit :

```js
import * as druid from '@saehrimnir/druidjs';

let data = [[...], [...], ...];
let matrix = druid.Matrix.from(data);
```

Vous pouvez créer un objet `druid.Matrix` de manière programmatique en :

```js
let fn = (row, col) => (row == col ? 1 : 0);
let matrix = new druid.Matrix(rows, columns, fn);
```
Si `rows == columns`, alors `matrix` serait une matrice identité.  
Un raccourci pour une matrice identité est :


```js
let matrix = new druid.Matrix(rows, columns, "I");
// or
let matrix = new druid.Matrix(rows, columnbs, "identity");
```

Il existe plus de raccourcis pour créer des matrices :

```js
let matrix = new druid.Matrix(3, 3, "zeros"); // matrix would be a 3x3 matrix with zeroes
let matrix = new druid.Matrix(3, 3, "center"); // matrix would be a 3x3 center matrix;
let number = 12;
let matrix = new druid.Matrix(3, 3, number); // matrix would b a 3x3 matrix filled with 'number'
```
Si vous souhaitez utiliser un objet `druid.Matrix`, par exemple avec [d3](https://d3js.org), vous pouvez utiliser soit la propriété `to2dArray`, la fonction génératrice `iterate_rows`, ou simplement utiliser l'objet `druid.Matrix` comme un itérable (fonctionne avec d3 depuis la version 6).


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