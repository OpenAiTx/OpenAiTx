[![Scorecard supply-chain security](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/scorecard.yml) [![CodeQL](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml/badge.svg)](https://github.com/edwinm/carbonium/actions/workflows/codeql.yml) [![Coverage Status](https://coveralls.io/repos/github/edwinm/carbonium/badge.svg?branch=master)](https://coveralls.io/github/edwinm/carbonium?branch=master) [![Socket Badge](https://socket.dev/api/badge/npm/package/carbonium)](https://socket.dev/npm/package/carbonium) [![CodeFactor](https://www.codefactor.io/repository/github/edwinm/carbonium/badge)](https://www.codefactor.io/repository/github/edwinm/carbonium) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=edwinm_carbonium&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=edwinm_carbonium) [![Snyk test results](https://snyk.io/test/github/edwinm/carbonium/badge.svg)](https://snyk.io/test/github/edwinm/carbonium) [![Size](https://badgen.net/bundlephobia/minzip/carbonium)](https://bundlephobia.com/package/carbonium) [![npm version](https://badge.fury.io/js/carbonium.svg)](https://www.npmjs.com/package/carbonium) [![GitHub](https://img.shields.io/github/license/edwinm/carbonium.svg)](https://github.com/edwinm/carbonium/blob/master/LICENSE) ![CodeRabbit Pull Request Reviews](https://img.shields.io/coderabbit/prs/github/edwinm/carbonium?utm_source=oss&utm_medium=github&utm_campaign=edwinm%2Fcarbonium&labelColor=171717&color=FF570A&link=https%3A%2F%2Fcoderabbit.ai&label=CodeRabbit+Reviews)

[![Carbonium](https://raw.githubusercontent.com/edwinm/carbonium/master/assets/carbonium.svg)](#readme)

> Bibliothèque d’un kilo-octet pour une manipulation facile du DOM

Avec carbonium, vous pouvez appeler `$(selector)` et le résultat peut être utilisé à la fois comme un élément DOM et comme un tableau d’éléments correspondants.
Les opérations sur l’élément DOM sont appliquées à tous les éléments correspondants.

## Exemples

Pour définir la propriété CSS `left` de tous les éléments avec la classe `indent` à 40 pixels :

```javascript
$(".indent").style.left = "40px";
```

Pour ajouter la classe `important` à tous les div ayant "priority" comme contenu :

```javascript
$("div")
  .filter((el) => el.textContent == "priority")
  .classList.add("important");
```

Vous pouvez utiliser le carbone pour créer des éléments :

```javascript
const error = $("<div class='error'>An error has occured!</div>")[0];
```

## Installation

```bash
npm install --save-dev carbonium
```

Vous pouvez maintenant importer carbonium :

```javascript
import { $ } from "carbonium";
```

Si vous ne souhaitez pas installer ou utiliser un bundler comme webpack ou rollup.js, vous pouvez importer carbonium ainsi :

```javascript
const { $ } = await import(
  "https://cdn.jsdelivr.net/npm/carbonium@1/dist/bundle.min.js"
);
```

## API

### Sélectionner des éléments

### `$(selector [, parentNode])`

#### Paramètres

| Nom        | Type                           | Description                                                               |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| selector   | string                         | Sélecteur pour sélectionner des éléments                                 |
| parentNode | Document \| Element (optionnel) | Document ou élément dans lequel appliquer le sélecteur, par défaut `document` |

#### Retourne

Un tableau des éléments correspondants, qui peut également être accédé comme un seul élément.

### Créer un élément

### `$(html [, parentNode])`

#### Paramètres

| Nom        | Type                           | Description                                                               |
| ---------- | ------------------------------ | ------------------------------------------------------------------------- |
| html       | string                         | HTML de l'élément à créer, commençant par "<"                            |
| parentNode | Document \| Element (optionnel) | Document ou élément dans lequel appliquer le sélecteur, par défaut `document` |

#### Retourne

Un tableau contenant un élément créé.

## TypeScript

Si vous utilisez TypeScript, il est bon de savoir que Carbonium est écrit en TypeScript et fournit tous les typings.
Vous pouvez utiliser des generics pour déclarer un type spécifique d'élément,
par exemple `HTMLInputElement` pour rendre la propriété `disabled` accessible :

```typescript
$<HTMLInputElement>("input, select, button").disabled = true;
```

## Pourquoi ?

Vous constaterez peut-être que la plupart des frameworks sont assez volumineux et mauvais pour les performances ([1](https://css-tricks.com/radeventlistener-a-tale-of-client-side-framework-performance/)).
D'un autre côté, vous pouvez trouver fastidieux d'utiliser le DOM natif et d'écrire `document.querySelectorAll(selector)` chaque fois que vous souhaitez effectuer des opérations DOM.
Vous pouvez écrire votre propre fonction d'assistance, mais cela ne soulage qu'une partie de la douleur.

Carbonium cherche à trouver le juste milieu entre l'utilisation d'un framework et l'utilisation du DOM natif.

## jQuery

N'est-ce pas juste jQuery et n'est-ce pas obsolète et une mauvaise pratique ?

Non. Carbonium n'a pas les inconvénients de jQuery :

1. Carbonium est très petit : juste autour d'un kilo-octet.
2. Il n'y a pas de nouvelle API à apprendre, carbonium ne fournit que les API DOM standard.

## Support des navigateurs

Carbonium est supporté par tous les navigateurs modernes. Il est testé pour fonctionner sur desktop et mobile avec Firefox 79, Chrome 84, Safari 13 et Edge 84.
Il devrait fonctionner avec tous les navigateurs supportant Proxy, voir [Can I use Proxy](https://caniuse.com/#feat=proxy) pour les tableaux de support.

## Nom

[<img src="https://raw.githubusercontent.com/edwinm/carbonium/master/assets/Diamond_and_graphite.jpg" align="right"
     alt="Photo de diamant et graphite" width="178" height="120">](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

Carbonium est le nom latin du carbone. Le carbone a deux formes (allotropes) : graphite et diamant.
Tout comme cette bibliothèque, dans laquelle le résultat se présente à la fois comme un élément et comme une liste d'éléments.

[Photo CC BY-SA 3.0](https://commons.wikimedia.org/wiki/File:Diamond_and_graphite_without_structures.jpg)

## Licence

Copyright 2023 [Edwin Martin](https://bitstorm.org/) et publié sous licence MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---