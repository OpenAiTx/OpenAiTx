# Safe Units

[![NPM Version](https://img.shields.io/npm/v/safe-units.svg)](https://www.npmjs.com/package/safe-units) [![MIT License](https://img.shields.io/npm/l/safe-units.svg)](https://github.com/jscheiny/safe-units/blob/master/LICENSE)

Safe Unitsは、TypeScriptでの単位の使用を型安全に行うためのライブラリです。Safe UnitsはSIに基づく単位系の実装を提供しますが、ユーザーが独自の単位系を作成できるように柔軟に設計されており、これらは組み込み単位と独立しているか、または相互運用可能です。ユーザーはJavaScriptの`number`型だけでなく、任意の数値型に対応した単位系を作成することもできます。このライブラリはTypeScript 3.2以上が必要です。

```ts
import { Length, Measure, meters, seconds, Time, Velocity } from "safe-units";

const length: Length = Measure.of(30, meters);
const time: Time = Measure.of(15, seconds);
const velocity: Velocity = length.over(time);

console.log(length.toString()); // 30 m
console.log(time.toString()); // 15 s
console.log(velocity.toString()); // 2 m * s^-1

// @ts-expect-error ERROR: A measure of m*s isn't assignable to a measure of m/s.
const error: Velocity = length.times(time);
```
## 特徴

⭐&nbsp; 型安全な次元解析のためのコンパイル時単位演算（指数は-5から+5の範囲）！

⭐&nbsp; SI単位（接頭辞付き）、インペリアル単位、米国慣用単位を含む豊富な既定単位ライブラリ！

⭐&nbsp; 組み込み単位と連携可能な独自の単位系を追加する機能！

⭐&nbsp; 長いビルド時間と難解なエラーメッセージ！

## 前提条件

Safe unitsはTypeScriptで書かれており、提供する機能を最大限活用するためにTypeScriptユーザーが利用することを想定しています。加えて以下が必要です：

- [TypeScript](http://www.typescriptlang.org/) 3.2以上
- プロジェクトで[厳密なnullチェック](https://www.typescriptlang.org/docs/handbook/compiler-options.html)が有効になっていること

## インストール


```
npm install safe-units
```

or 

```
yarn add safe-units
```

## 例

### 単位演算

```ts
import { bars, kilograms, Measure, meters, milli, seconds } from "safe-units";

const width = Measure.of(3, meters);
const height = Measure.of(4, meters);
const area = width.times(height).scale(0.5);

const mass = Measure.of(30, kilograms);
const mps2 = meters.per(seconds.squared());
const acceleration = Measure.of(9.8, mps2);

const force = mass.times(acceleration); // 294 N
const pressure = force.over(area); // 49 Pa
const maxPressure = Measure.of(0.5, milli(bars)); // 0.5 mbar
pressure.lt(maxPressure); // true

```

### 型エラー

```ts
import { Force, hours, Length, Measure, meters, seconds, Time } from "safe-units";

const length: Length = Measure.of(10, meters);
const time: Time = Measure.of(10, seconds);

// @ts-expect-error - Measures of different units cannot be added
length.plus(time);

// @ts-expect-error - Measures of different units cannot be compared
length.eq(time);

// @ts-expect-error - Measure of m/s is not assigneable to measure of kg*m/s^2
const force: Force = length.over(time);

// @ts-expect-error - Cannot convert length measure to time measure
length.in(hours);

```

### 単位の命名

```ts
import { days, Measure, mega, micro, miles, speedOfLight, yards } from "safe-units";

const furlongs = Measure.of(220, yards, "fur");

Measure.of(8, furlongs).in(miles); // "1 mi"
Measure.of(1, miles).in(furlongs); // "8 fur"

const fortnights = Measure.of(14, days, "ftn");
const megafurlong = mega(furlongs);
const microfortnight = micro(fortnights);
const mfPerUFtn = megafurlong.per(microfortnight).withSymbol("Mfur/µftn");

speedOfLight.in(mfPerUFtn); // "1.8026174997852542 Mfur/µftn"

```

### 量の導出

```ts
import { kilograms, liters, Mass, Measure, Volume } from "safe-units";

const VolumeDensity = Mass.over(Volume);
type VolumeDensity = typeof VolumeDensity;

const mass = Measure.of(30, kilograms);
const volume = Measure.of(3, liters);

const density: VolumeDensity = mass.over(volume);

console.log(density.toString()); // 10 kg * m^-3

```

### 単位系の定義

```ts
import { Measure, UnitSystem } from "safe-units";

const GameUnitSystem = UnitSystem.from({
    frames: "fr",
    time: "s",
});

const frames = Measure.dimension(GameUnitSystem, "frames");
const seconds = Measure.dimension(GameUnitSystem, "time");

const Frames = frames;
type Frames = typeof frames;

const Time = seconds;
type Time = typeof seconds;

const FrameRate = Frames.over(Time);
type FrameRate = typeof FrameRate;

const fps: FrameRate = frames.per(seconds).withSymbol("fps");

const minFrameRate = Measure.of(60, fps);

const measuredFrames = Measure.of(8000, frames);
const elapsedTime = Measure.of(120, seconds);
const measuredFps: FrameRate = measuredFrames.over(elapsedTime);

if (measuredFps.lt(minFrameRate)) {
    // Optimize
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---