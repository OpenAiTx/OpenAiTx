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
또는 npm으로  


```console
npm install react-jewish-datepicker --save
```
css를 가져옵니다


```JavaScript
import "react-jewish-datepicker/dist/index.css";
```
또는 CSS로  


```JavaScript
@import url("react-jewish-datepicker/dist/index.css");
```

## 사용법

#### TypeScript 예제:

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

| Prop name | 설명                                                                         | 값 타입                                                                                                                           |
| --------- | ---------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| canSelect | 특정 날짜를 선택할 수 있는지 여부를 결정하는 함수를 받습니다                   | `(day: BasicJewishDay) => condition ? false : true`                                                                               |
| isHebrew  | 선택 사항. 뷰 언어가 히브리어인지 영어인지, 기본값은 `false`                 | `false` \| `true`                                                                                                                 |
| isRange   | 선택 사항. 날짜 범위 선택 허용 여부. 기본값은 `false`                        | `false` \| `true`                                                                                                                 |
| onClick   | 날짜가 선택될 때 호출되는 콜백                                               | `(day: BasicJewishDay) => console.log(day)` \| `(startDay: BasicJewishDay, endDay: BasicJewishDay) => console.log(startDay, endDay)` |
| value     | 선택 사항. 초기 선택된 날짜                                                  | `Date` \| `BasicJewishDate` \| `BasicJewishDateRange` \| `DateRange`                                                              |

### `canSelect` prop

`canSelect`는 [`사용자 정의 함수`](https://react-jewish-datepicker.js.org/#disableWithCustomFunction) 또는 다음과 같은 내장 함수 중 하나를 사용할 수 있습니다.

#### dontSelectHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

`isIsrael` 매개변수를 받아서, 해당 `isIsrael` 매개변수에 따라 휴일 선택을 방지하기 위해 `canSelect` prop에 전달되는 함수를 반환합니다.

| 매개변수 | 타입     | 기본값 |
| -------- | -------- | ------ |
| isIsrael | `boolean` | `false` |

예제는 [여기](https://react-jewish-datepicker.js.org/#disableHolidays)에서 확인하세요.

#### dontSelectShabat(day: `BasicJewishDay`) ⇒ `boolean`

shabat 선택을 방지하기 위해 `canSelect` prop에 전달되는 함수입니다.

예제는 [여기](https://react-jewish-datepicker.js.org/#disableShabat)에서 확인하세요.

#### dontSelectShabatAndHolidays([isIsrael: `boolean`]) ⇒ `(day: BasicJewishDay) => boolean`

`isIsrael` 매개변수를 받아서, "canSelect" prop에 전달할 함수를 반환합니다. `dontSelectHolidays`와 `dontSelectShabat`를 결합하여 shabat과 휴일 선택을 모두 방지합니다.

| 매개변수 | 타입     | 기본값 |
| -------- | -------- | ------ |
| isIsrael | `boolean` | `false` |

예제는 [여기](https://react-jewish-datepicker.js.org/#disableShabatAndHolidays)에서 확인하세요.

#### dontSelectOutOfRange(minDate: `Date` | `null`, maxDate: `Date` | `null`) ⇒ `(day: BasicJewishDay) => boolean`

최소 날짜와 최대 날짜를 받아 "canSelect" 속성에 전달할 함수를 반환하여 지정된 범위를 벗어난 선택을 방지합니다.

매개변수 중 하나에만 날짜를 전달하고 다른 하나에는 null을 전달할 수 있습니다. 이 경우 선택 가능한 범위는 최대 날짜까지 또는 최소 날짜부터가 됩니다.

| 매개변수 | 타입   |
| ----- | ------ |
| minDate  | `Date` \| `null` |
| maxDate  | `Date` \| `null` |

예제는 [여기](https://react-jewish-datepicker.js.org/#selectionWithinRange)에서 확인하세요.

### 헬퍼 함수

#### addDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange`를 위한 헬퍼 함수입니다.

`BasicJewishDate` 객체 또는 `Date`를 받아 날짜 간격(`numDays`)을 더한 후 새 날짜를 반환합니다.

| 매개변수 | 타입   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

예제는 [여기](https://react-jewish-datepicker.js.org/#selectionWithinRange)에서 확인하세요.

#### subtractDates(date: `BasicJewishDate` | `Date`, numDays: `number`) ⇒ `Date`

`dontSelectOutOfRange`를 위한 헬퍼 함수입니다.

`BasicJewishDate` 객체 또는 `Date`를 받아 날짜 간격(`numDays`)을 뺀 후 새 날짜를 반환합니다.

| 매개변수 | 타입   |
| ----- | ------ |
| date  | `BasicJewishDate` \| `Date` |
| numDays  | `number` |

예제는 [여기](https://react-jewish-datepicker.js.org/#selectionWithinRange)에서 확인하세요.

### jewish-dates-core

vue.js 또는 angular에서 유대인 날짜 선택기를 만들려면, 우리의 [코어 의존성](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/packages/jewishDatesCore/README.md)을 참조하세요.

### jewish-date

날짜 선택기 없이 히브리 날짜 변환기만 필요하면 [jewish-date](https://www.npmjs.com/package/jewish-date)를 사용할 수 있습니다.


## 기여자

- [Shmulik Kravitz](https://github.com/Shmulik-Kravitz)
- [Sagi Tawil](https://github.com/sagi770)
- [Yochanan Sheinberger](https://github.com/yochanan-sheinberger)

라이선스: [MIT](https://github.com/Shmulik-Kravitz/react-jewish-datepicker/blob/master/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---