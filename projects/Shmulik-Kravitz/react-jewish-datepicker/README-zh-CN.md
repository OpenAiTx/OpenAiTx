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
或者使用 npm


```console
npm install react-jewish-datepicker --save
```
导入 css


```JavaScript
import "react-jewish-datepicker/dist/index.css";
```
或使用 css


```JavaScript
@import url("react-jewish-datepicker/dist/index.css");
```

## 使用方法

#### TypeScript 示例：

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

[![Edit react-jewish-datepicker-javascript-example](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/pedantic-gagarin-rdeov?fontsize=14&hidenavigation=1&theme=dark)

## 属性

| 属性名     | 说明                                                                         | 值类型                                                                                                                             |
| ---------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| canSelect  | 接受一个函数，用于确定某一天是否可选择                                       | `(day: BasicJewishDay) => condition ? false : true`                                                                               |
| isHebrew   | 可选。视图语言是否为希伯来语，默认是 `false`                                | `false` \| `true`                                                                                                                 |
| isRange    | 可选。允许选择日期范围，默认是 `false`                                      | `false` \| `true`                                                                                                                 |
| onClick    | 选中日期时的回调函数                                                         | `(day: BasicJewishDay) => console.log(day)` \| `(startDay: BasicJewishDay, endDay: BasicJewishDay) => console.log(startDay, endDay)` |
| value      | 可选。初始选中的日期                                                         | `Date` \| `BasicJewishDate` \| `BasicJewishDateRange` \| `DateRange`                                                              |

### `canSelect` 属性

`canSelect` 可以接受一个[`自定义函数`](https://react-jewish-datepicker.js.org/#disableWithCustomFunction)或以下内置函数之一。

#### dontSelectHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

接受 `isIsrael` 参数并返回一个函数，该函数传递给 `canSelect` 属性，用于禁止选择节假日（与 `isIsrael` 参数对应）。

| 参数     | 类型        | 默认值  |
| -------- | ----------- | ------- |
| isIsrael | `boolean`   | `false` |

示例见[这里](https://react-jewish-datepicker.js.org/#disableHolidays)

#### dontSelectShabat(day: `BasicJewishDay`) ⇒ `boolean`

一个传递给 `canSelect` 属性的函数，用于禁止选择安息日。

示例见[这里](https://react-jewish-datepicker.js.org/#disableShabat)

#### dontSelectShabatAndHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

接受 `isIsrael` 参数并返回一个函数，传递给 `canSelect` 属性。结合 `dontSelectHolidays` 和 `dontSelectShabat`，用于同时禁止选择安息日和节假日。

| 参数     | 类型        | 默认值  |
| -------- | ----------- | ------- |
| isIsrael | `boolean`   | `false` |

参见示例 [这里](https://react-jewish-datepicker.js.org/#disableShabatAndHolidays)

#### dontSelectOutOfRange(minDate: `Date` | `null`, maxDate: `Date` | `null`) ⇒ `(day: BasicJewishDay) => boolean`

接受最小日期和最大日期，返回一个函数以传递给 "canSelect" 属性，以防止选择超出提供的范围。

你可以仅为其中一个参数传递日期，另一个传递 null。在这种情况下，可选范围将是最大日期之前或最小日期之后。

| 参数 | 类型   |
| ----- | ------ |
| minDate  | `Date` \| `null` |
| maxDate  | `Date` \| `null` |

参见示例 [这里](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### 辅助函数

#### addDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange` 的辅助函数。

接受一个 `BasicJewishDate` 对象或 `Date`，将日期间隔（`numDays`）加到该日期上，然后返回新日期。

| 参数 | 类型   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

参见示例 [这里](https://react-jewish-datepicker.js.org/#selectionWithinRange)

#### subtractDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange` 的辅助函数。

接受一个 `BasicJewishDate` 对象或 `Date`，从该日期中减去日期间隔（`numDays`），然后返回新日期。

| 参数 | 类型   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `数字` |

示例见[这里](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### jewish-dates-core

要在 vue.js 或 angular 中创建犹太日期选择器，请参见我们的[核心依赖](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/packages/jewishDatesCore/README.md)。

### jewish-date

如果您只需要希伯来日期转换器而不需要日期选择器，可以使用[jewish-date](https://www.npmjs.com/package/jewish-date)。

## 贡献者

- [Shmulik Kravitz](https://github.com/Shmulik-Kravitz)
- [Sagi Tawil](https://github.com/sagi770)
- [Yochanan Sheinberger](https://github.com/yochanan-sheinberger)

许可证: [MIT](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---