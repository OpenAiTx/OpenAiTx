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
または npm を使用して


```console
npm install react-jewish-datepicker --save
```

cssをインポートする

```JavaScript
import "react-jewish-datepicker/dist/index.css";
```
または css を使用して


```JavaScript
@import url("react-jewish-datepicker/dist/index.css");
```

## 使用方法

#### TypeScriptの例:

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

## props

| Prop name | 説明                                                                       | 値の種類                                                                                                                           |
| --------- | -------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| canSelect | 日付が選択可能かどうかを判定する関数を受け取る                             | `(day: BasicJewishDay) => condition ? false : true`                                                                               |
| isHebrew  | 任意。表示言語がヘブライ語か英語か。デフォルトは`false`                   | `false` \| `true`                                                                                                                 |
| isRange   | 任意。日付範囲の選択を許可するか。デフォルトは`false`                     | `false` \| `true`                                                                                                                 |
| onClick   | 日付が選択されたときのコールバック                                         | `(day: BasicJewishDay) => console.log(day)` \| `(startDay: BasicJewishDay, endDay: BasicJewishDay) => console.log(startDay, endDay)` |
| value     | 任意。初期選択日                                                         | `Date` \| `BasicJewishDate` \| `BasicJewishDateRange` \| `DateRange`                                                              |

### `canSelect` prop

`canSelect` は、[`カスタム関数`](https://react-jewish-datepicker.js.org/#disableWithCustomFunction) または以下のビルトイン関数のいずれかを取ることができます。

#### dontSelectHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

`isIsrael` パラメータを取り、`canSelect` prop に渡される関数を返します。これにより、祝日（`isIsrael` パラメータに対応）を選択できなくします。

| パラメータ | 型       | デフォルト |
| ---------- | -------- | ---------- |
| isIsrael   | `boolean` | `false`    |

例は[こちら](https://react-jewish-datepicker.js.org/#disableHolidays)をご覧ください。

#### dontSelectShabat(day: `BasicJewishDay`) ⇒ `boolean`

`canSelect` prop に渡す関数で、シャバットの選択を防止します。

例は[こちら](https://react-jewish-datepicker.js.org/#disableShabat)をご覧ください。

#### dontSelectShabatAndHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

`isIsrael` パラメータを取り、`canSelect` prop に渡す関数を返します。`dontSelectHolidays` と `dontSelectShabat` を組み合わせて、シャバットと祝日の両方の選択を防止します。

| パラメータ | 型       | デフォルト |
| ---------- | -------- | ---------- |
| isIsrael   | `boolean` | `false`    |


例は[こちら](https://react-jewish-datepicker.js.org/#disableShabatAndHolidays)をご覧ください。

#### dontSelectOutOfRange(minDate: `Date` | `null`, maxDate: `Date` | `null`) ⇒ `(day: BasicJewishDay) => boolean`

最小日付と最大日付を受け取り、指定された範囲外の選択を防ぐために "canSelect" プロップに渡す関数を返します。

パラメータの片方に日付を渡し、もう片方には null を渡すことができます。この場合、選択可能な範囲は最大日付まで、または最小日付からとなります。

| パラメータ | 型   |
| ----- | ------ |
| minDate  | `Date` \| `null` |
| maxDate  | `Date` \| `null` |

例は[こちら](https://react-jewish-datepicker.js.org/#selectionWithinRange)をご覧ください。

### ヘルパー関数

#### addDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange` のためのヘルパー関数です。

`BasicJewishDate` オブジェクトまたは `Date` を受け取り、日数間隔（`numDays`）をその日付に加え、新しい日付を返します。

| パラメータ | 型   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

例は[こちら](https://react-jewish-datepicker.js.org/#selectionWithinRange)をご覧ください。

#### subtractDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange` のためのヘルパー関数です。

`BasicJewishDate` オブジェクトまたは `Date` を受け取り、日数間隔（`numDays`）をその日付から減算し、新しい日付を返します。

| パラメータ | 型   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

例はこちらをご覧ください [here](https://react-jewish-datepicker.js.org/#selectionWithinRange)

### jewish-dates-core

vue.jsやangularでユダヤ暦日付ピッカーを作成するには、当社の[コア依存関係](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/packages/jewishDatesCore/README.md)をご覧ください。

### jewish-date

日付ピッカーなしでヘブライ日付変換器のみが必要な場合は、[jewish-date](https://www.npmjs.com/package/jewish-date)を使用できます。


## 貢献者

- [Shmulik Kravitz](https://github.com/Shmulik-Kravitz)
- [Sagi Tawil](https://github.com/sagi770)
- [Yochanan Sheinberger](https://github.com/yochanan-sheinberger)

ライセンス: [MIT](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---