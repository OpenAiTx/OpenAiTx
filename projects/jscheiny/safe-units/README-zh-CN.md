# 安全单位

[![NPM 版本](https://img.shields.io/npm/v/safe-units.svg)](https://www.npmjs.com/package/safe-units) [![MIT 许可证](https://img.shields.io/npm/l/safe-units.svg)](https://github.com/jscheiny/safe-units/blob/master/LICENSE)

安全单位是一个用于在 TypeScript 中使用计量单位的类型安全库。安全单位提供了一个基于国际单位制（SI）的单位系统实现，但足够灵活，允许用户创建自己的单位系统，这些系统可以是独立的，也可以与内置单位互操作。用户还可以为任何他们想要的数字类型创建单位系统，而不仅仅是 JavaScript 的 `number` 类型。此库需要 TypeScript 3.2 或更高版本。

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
## 特性

⭐&nbsp; 编译时单位运算，实现类型安全的量纲分析（指数范围为 -5 至 +5）！

⭐&nbsp; 大量预定义单位库，包括国际单位制（带前缀）、英制和美国惯用单位！

⭐&nbsp; 支持添加您自己的单位系统，可与内置单位协同工作！

⭐&nbsp; 构建时间长且错误信息晦涩难懂！

## 先决条件

Safe units 使用 TypeScript 编写，建议 TypeScript 用户使用，以充分利用其功能。此外，您还需要：

- [TypeScript](http://www.typescriptlang.org/) 3.2 或更高版本
- 为您的项目启用 [严格空值检查](https://www.typescriptlang.org/docs/handbook/compiler-options.html)

## 安装


```
npm install safe-units
```

or 

```
yarn add safe-units
```

## 示例

### 单元算术

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

### 类型错误

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

### 命名单元

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

### 推导量

```ts
import { kilograms, liters, Mass, Measure, Volume } from "safe-units";

const VolumeDensity = Mass.over(Volume);
type VolumeDensity = typeof VolumeDensity;

const mass = Measure.of(30, kilograms);
const volume = Measure.of(3, liters);

const density: VolumeDensity = mass.over(volume);

console.log(density.toString()); // 10 kg * m^-3

```

### 定义单位系统

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