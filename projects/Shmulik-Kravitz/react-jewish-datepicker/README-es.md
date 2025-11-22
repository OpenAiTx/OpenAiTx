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

O con npm

```console
npm install react-jewish-datepicker --save
```
Importar el css


```JavaScript
import "react-jewish-datepicker/dist/index.css";
```
o con css


```JavaScript
@import url("react-jewish-datepicker/dist/index.css");
```

## Uso

#### Ejemplo en TypeScript:

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

[![Editar react-jewish-datepicker-javascript-example](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/pedantic-gagarin-rdeov?fontsize=14&hidenavigation=1&theme=dark)

## props

| Nombre de Prop | Descripción                                                                 | Tipos de valor                                                                                                                        |
| -------------- | --------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
| canSelect     | Acepta una función que determina si un día es seleccionable                 | `(day: BasicJewishDay) => condition ? false : true`                                                                                  |
| isHebrew      | Opcional. Si el idioma de la vista es hebreo o inglés, por defecto es `false` | `false` \| `true`                                                                                                                    |
| isRange       | Opcional. Permite seleccionar rangos de fechas. Por defecto es `false`      | `false` \| `true`                                                                                                                    |
| onClick       | Callback cuando se selecciona una fecha                                     | `(day: BasicJewishDay) => console.log(day)` \| `(startDay: BasicJewishDay, endDay: BasicJewishDay) => console.log(startDay, endDay)` |
| value         | Opcional. Fecha seleccionada inicial                                        | `Date` \| `BasicJewishDate` \| `BasicJewishDateRange` \| `DateRange`                                                                 |

### Propiedad `canSelect`

El `canSelect` puede tomar una [`función personalizada`](https://react-jewish-datepicker.js.org/#disableWithCustomFunction) o una de las funciones integradas como sigue.

#### dontSelectHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

Recibe el parámetro `isIsrael` y devuelve una función que a su vez se pasa a la propiedad `canSelect`, para evitar la selección de días festivos (correspondientes con el parámetro `isIsrael`).

| Parámetro | Tipo    | Predeterminado |
| --------- | ------- | -------------- |
| isIsrael  | `boolean` | `false`       |

Ver ejemplo [aquí](https://react-jewish-datepicker.js.org/#disableHolidays)

#### dontSelectShabat(day: `BasicJewishDay`) ⇒ `boolean`

Función para pasar a la propiedad `canSelect`, para evitar la selección de shabat.

Ver ejemplo [aquí](https://react-jewish-datepicker.js.org/#disableShabat)

#### dontSelectShabatAndHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

Recibe el parámetro `isIsrael` y devuelve una función para pasar a la propiedad `canSelect`. Combina `dontSelectHolidays` y `dontSelectShabat` para evitar la selección tanto de shabat como de días festivos.

| Parámetro | Tipo    | Predeterminado |
| --------- | ------- | -------------- |
| isIsrael  | `boolean` | `false`       |

Vea el ejemplo [aquí](https://react-jewish-datepicker.js.org/#disableShabatAndHolidays)

#### dontSelectOutOfRange(minDate: `Date` | `null`, maxDate: `Date` | `null`) ⇒ `(day: BasicJewishDay) => boolean`

Toma una fecha mínima y una fecha máxima y devuelve una función para pasar a la propiedad "canSelect", con el fin de evitar la selección fuera del rango suministrado.

Puede pasar una fecha solo para uno de los parámetros y null para el otro. En este caso, el rango seleccionable será hasta la fecha máxima o desde la fecha mínima.

| Param | Tipo   |
| ----- | ------ |
| minDate  | `Date` \| `null` |
| maxDate  | `Date` \| `null` |

Vea el ejemplo [aquí](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### Funciones Auxiliares

#### addDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

una función auxiliar para `dontSelectOutOfRange`.

Toma un objeto `BasicJewishDate` o una `Date`, añade un intervalo de días (`numDays`) a la fecha y luego devuelve la nueva fecha.

| Param | Tipo   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

Vea el ejemplo [aquí](https://react-jewish-datepicker.js.org/#selectionWithinRange)

#### subtractDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

una función auxiliar para `dontSelectOutOfRange`.

Toma un objeto `BasicJewishDate` o una `Date`, resta un intervalo de días (`numDays`) a la fecha y luego devuelve la nueva fecha.

| Param | Tipo   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `número` |

Ver ejemplo [aquí](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### jewish-dates-core

Para crear un selector de fechas judías en vue.js o angular, vea nuestra [dependencia central](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/packages/jewishDatesCore/README.md).

### jewish-date

Si solo necesita el convertidor de fecha hebrea sin un selector de fechas, puede usar [jewish-date](https://www.npmjs.com/package/jewish-date).


## Colaboradores

- [Shmulik Kravitz](https://github.com/Shmulik-Kravitz)
- [Sagi Tawil](https://github.com/sagi770)
- [Yochanan Sheinberger](https://github.com/yochanan-sheinberger)

Licencia: [MIT](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---