[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> Biblioteca de un kilobyte para manipulación sencilla del DOM

Con carbonium, puedes llamar a `$(selector)` y el resultado puede ser accedido tanto como un elemento DOM como un arreglo de elementos coincidentes.
Las operaciones sobre elementos DOM se aplican a todos los elementos coincidentes.

## Ejemplos

Para establecer la propiedad CSS `left` de todos los elementos con la clase `indent` a 40 píxeles:

```javascript
$(".indent").style.left = "40px";
```
Para agregar la clase `important` a todos los divs con "priority" como contenido:


```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

Puedes usar carbonio para crear elementos:

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## Instalación

```bash
npm install --save-dev carbonium
```

Ahora puedes importar carbonium:

```javascript
import { $ } from "carbonium";
```

Si no deseas instalar o usar un empaquetador como webpack o rollup.js, puedes importar carbonium así:

```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```

## API

### Seleccionar elementos

### `$(selector [, parentNode])`

#### Parámetros

| Nombre     | Tipo                           | Descripción                                                               |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| selector   | string                         | Selector para seleccionar elementos                                       |
| parentNode | Document \| Element (opcional) | Documento o elemento en el que se aplicará el selector, por defecto `document` |

#### Retorna

Un arreglo con los elementos coincidentes, al que también se puede acceder como un solo elemento.

### Crear elemento

### `$(html [, parentNode])`

#### Parámetros

| Nombre     | Tipo                           | Descripción                                                               |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| html       | string                         | HTML del elemento a crear, comenzando con "<"                            |
| parentNode | Document \| Element (opcional) | Documento o elemento en el que se aplicará el selector, por defecto `document` |

#### Retorna

Un arreglo con un elemento creado.

## TypeScript

Si usas TypeScript, es bueno saber que Carbonium está escrito en TypeScript y proporciona todas las definiciones de tipos.
Puedes usar genéricos para declarar un tipo específico de elemento,
por ejemplo `HTMLInputElement` para hacer disponible la propiedad `disabled`:

```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```

## ¿Por qué?

Podrías encontrar que la mayoría de los frameworks son bastante voluminosos y malos para el rendimiento ([1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)).
Por otro lado, podrías encontrar que usar el DOM nativo y escribir `document.querySelectorAll(selector)` cada vez que quieres hacer alguna operación DOM se vuelve tedioso.
Puedes escribir tu propia función auxiliar, pero eso solo quita parte del dolor.

Carbonium busca encontrar el punto medio entre usar un framework y usar el DOM nativo.

## jQuery

¿No es esto simplemente jQuery y no es eso obsoleto y mala práctica?

No. Carbonium no tiene las desventajas de jQuery:

1. Carbonium es muy pequeño: apenas alrededor de un kilobyte.
2. No hay una nueva API que aprender, carbonium solo provee APIs DOM estándar.

## Soporte del navegador

Carbonium es soportado por todos los navegadores modernos. Se ha probado que funciona en escritorio y móvil con Firefox 79, Chrome 84, Safari 13 y Edge 84.
Debería funcionar con todos los navegadores que soportan Proxy, consulta [Can I use Proxy](https://caniuse.com/#feat=proxy) para tablas de soporte.

## Nombre

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="Foto de diamante y grafito" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carbonium es el nombre latino del carbono. El carbono tiene dos formas (alótropos): grafito y diamante.
Al igual que esta biblioteca, en la que el resultado se presenta tanto como un solo elemento como una lista de elementos.

[Foto CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## Licencia

Copyright 2023 [Edwin Martin](https://bitstorm.org/) y liberado bajo la licencia MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---