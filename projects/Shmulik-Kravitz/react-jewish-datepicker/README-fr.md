# react-jewish-datepicker

[![npm](https://badge.fury.io/js/react-jewish-datepicker.svg)](https://www.npmjs.com/package/react-jewish-datepicker)
[![CI](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/workflows/CI_CD/badge.svg?branch=master)](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/)
![license](https://badgen.net/npm/license/react-jewish-datepicker)
[![size minzip](https://img.shields.io/bundlephobia/minzip/react-jewish-datepicker.svg)](https://bundlephobia.com/package/react-jewish-datepicker)
![downloads](https://badgen.net/npm/dt/react-jewish-datepicker)
[![stars](https://badgen.net/github/stars/Shmulik-Kravitz/react-jewish-datepicker)](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/)


![npm](https://raw.githubusercontent.com/Shmulik-Kravitz/react-jewish-datepicker/master/images/snapshot.png)

# React Jewish Date Picker

General Jewish Date Picker component that works with react and supports hebrew and english.

See also [demo and documentation](https://react-jewish-datepicker.js.org/) page.

## Installation

```console
yarn add react-jewish-datepicker
```
Ou avec npm


```console
npm install react-jewish-datepicker --save
```
Importer le css


```JavaScript
import "react-jewish-datepicker/dist/index.css";
```

ou avec css

```JavaScript
@import url("react-jewish-datepicker/dist/index.css");
```

## Utilisation

#### Exemple TypeScript :

```js
import * as React from "react";
import {
  ReactJewishDatePicker,
  BasicJewishDay,
  BasicJewishDate
} from "react-jewish-datepicker";
import "react-jewish-datepicker/dist/index.css";
import {
  JewishMonth,
} from "jewish-dates-core";

export default function App() {
  const [basicJewishDay, setBasicJewishDay] = React.useState<BasicJewishDay>();
  const basicJewishDate: BasicJewishDate = {
    day: 13,
    monthName: JewishMonth.Elul,
    year: 5788
  };

  return (
    <>
      <div>
        Hebrew:
        <ReactJewishDatePicker
          value={basicJewishDate}
          isHebrew
          onClick={(day: BasicJewishDay) => {
            setBasicJewishDay(day);
          }}
        />
      </div>
    </>
  );
}


```

[![Edit react-jewish-datepicker-typescript-example](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/react-jewish-datepicker-typescript-example-1myb0?fontsize=14&hidenavigation=1&theme=dark)

#### JavaScript example:

```js
import * as React from "react";
import { ReactJewishDatePicker, BasicJewishDay } from "react-jewish-datepicker";
import "react-jewish-datepicker/dist/index.css";

export default function App() {
  const [basicJewishDay, setBasicJewishDay] = React.useState();
  return (
    <ReactJewishDatePicker
      value={new Date()}
      isHebrew
      onClick={(day) => {
        setBasicJewishDay(day);
      }}
    />
  );
}
```

[![Modifier react-jewish-datepicker-javascript-example](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/pedantic-gagarin-rdeov?fontsize=14&hidenavigation=1&theme=dark)

## props

| Nom de la prop | Description                                                                  | Types de valeurs                                                                                                                          |
| -------------- | ---------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| canSelect     | Accepte une fonction qui détermine si un jour est sélectionnable              | `(day: BasicJewishDay) => condition ? false : true`                                                                                       |
| isHebrew      | Optionnel. Indique si la langue de la vue est hébreu ou anglais, par défaut `false` | `false` \| `true`                                                                                                                       |
| isRange       | Optionnel. Permet de sélectionner des plages de dates. Par défaut `false`    | `false` \| `true`                                                                                                                       |
| onClick       | Callback lorsqu’une date est sélectionnée                                     | `(day: BasicJewishDay) => console.log(day)` \| `(startDay: BasicJewishDay, endDay: BasicJewishDay) => console.log(startDay, endDay)`     |
| value         | Optionnel. Date sélectionnée initiale                                        | `Date` \| `BasicJewishDate` \| `BasicJewishDateRange` \| `DateRange`                                                                     |

### Prop `canSelect`

La prop `canSelect` peut prendre soit une [`fonction personnalisée`](https://react-jewish-datepicker.js.org/#disableWithCustomFunction) soit une des fonctions intégrées suivantes.

#### dontSelectHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

Prend un paramètre `isIsrael` et retourne une fonction qui est ensuite passée à la prop `canSelect`, afin d’empêcher la sélection des jours fériés (correspondant au paramètre `isIsrael`).

| Paramètre | Type      | Par défaut |
| --------- | --------- | ---------- |
| isIsrael  | `boolean` | `false`    |

Voir l’exemple [ici](https://react-jewish-datepicker.js.org/#disableHolidays)

#### dontSelectShabat(day: `BasicJewishDay`) ⇒ `boolean`

Fonction à passer à la prop `canSelect` afin d’empêcher la sélection du shabbat.

Voir l’exemple [ici](https://react-jewish-datepicker.js.org/#disableShabat)

#### dontSelectShabatAndHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

Prend un paramètre `isIsrael` et retourne une fonction à passer à la prop `canSelect`. Combine `dontSelectHolidays` et `dontSelectShabat` afin d’empêcher la sélection à la fois du shabbat et des jours fériés.

| Paramètre | Type      | Par défaut |
| --------- | --------- | ---------- |
| isIsrael  | `boolean` | `false`    |

Voir l'exemple [ici](https://react-jewish-datepicker.js.org/#disableShabatAndHolidays)

#### dontSelectOutOfRange(minDate: `Date` | `null`, maxDate: `Date` | `null`) ⇒ `(day: BasicJewishDay) => boolean`

Prend une date minimale et une date maximale et retourne une fonction à passer à la propriété "canSelect", afin d'empêcher la sélection en dehors de la plage fournie.

Vous pouvez passer une date uniquement pour un des paramètres et null pour l'autre. Dans ce cas, la plage sélectionnable sera jusqu'à la date maximale ou à partir de la date minimale.

| Param | Type   |
| ----- | ------ |
| minDate  | `Date` \| `null` |
| maxDate  | `Date` \| `null` |

Voir l'exemple [ici](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### Fonctions d'aide

#### addDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

une fonction d'aide pour `dontSelectOutOfRange`.

Prend un objet `BasicJewishDate` ou une `Date`, ajoute un intervalle de jours (`numDays`) à la date puis retourne la nouvelle date.

| Param | Type   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

Voir l'exemple [ici](https://react-jewish-datepicker.js.org/#selectionWithinRange)

#### subtractDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

une fonction d'aide pour `dontSelectOutOfRange`.

Prend un objet `BasicJewishDate` ou une `Date`, soustrait un intervalle de jours (`numDays`) à la date puis retourne la nouvelle date.

| Param | Type   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

Voir l'exemple [ici](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### jewish-dates-core

Pour créer un sélecteur de date juive en vue.js ou angular, consultez notre [dépendance principale](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/packages/jewishDatesCore/README.md).

### jewish-date

Si vous avez seulement besoin du convertisseur de date hébraïque sans sélecteur de date, vous pouvez utiliser [jewish-date](https://www.npmjs.com/package/jewish-date).


## Contributeurs

- [Shmulik Kravitz](https://github.com/Shmulik-Kravitz)
- [Sagi Tawil](https://github.com/sagi770)
- [Yochanan Sheinberger](https://github.com/yochanan-sheinberger)

Licence : [MIT](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---