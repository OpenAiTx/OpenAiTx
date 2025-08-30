# 안전 단위

[![NPM 버전](https://img.shields.io/npm/v/safe-units.svg)](https://www.npmjs.com/package/safe-units) [![MIT 라이선스](https://img.shields.io/npm/l/safe-units.svg)](https://github.com/jscheiny/safe-units/blob/master/LICENSE)

안전 단위는 TypeScript에서 측정 단위를 사용할 때 타입 안전성을 제공하는 라이브러리입니다. 안전 단위는 SI 기반 단위 시스템을 구현하지만 사용자가 독립적이거나 내장 단위와 상호 운용할 수 있는 자체 단위 시스템을 생성할 수 있을 만큼 유연합니다. 사용자는 JavaScript `number` 타입뿐만 아니라 원하는 모든 숫자 타입에 대한 단위 시스템도 만들 수 있습니다. 이 라이브러리는 TypeScript 3.2 이상이 필요합니다.

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
## 기능

⭐&nbsp; 타입 안전 차원 분석을 위한 컴파일 타임 단위 산술(지수는 -5에서 +5 사이)!

⭐&nbsp; SI(접두사 포함), 임페리얼, 미국 관습 단위를 포함한 방대한 미리 정의된 단위 라이브러리!

⭐&nbsp; 내장 단위와 함께 작동할 수 있는 자체 단위 시스템 추가 기능!

⭐&nbsp; 긴 빌드 시간 및 난해한 오류 메시지!

## 전제 조건

Safe units는 TypeScript로 작성되었으며 제공하는 모든 기능을 최대한 활용하려면 TypeScript 사용자가 사용해야 합니다. 또한 다음이 필요합니다:

- [TypeScript](http://www.typescriptlang.org/) 3.2 이상
- 프로젝트에 대해 [엄격한 널 검사](https://www.typescriptlang.org/docs/handbook/compiler-options.html) 활성화

## 설치


```
npm install safe-units
```

or 

```
yarn add safe-units
```

## 예제

### 단위 산술

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

### 타입 오류

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

### 단위 명명법

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

### 양 도출하기

```ts
import { kilograms, liters, Mass, Measure, Volume } from "safe-units";

const VolumeDensity = Mass.over(Volume);
type VolumeDensity = typeof VolumeDensity;

const mass = Measure.of(30, kilograms);
const volume = Measure.of(3, liters);

const density: VolumeDensity = mass.over(volume);

console.log(density.toString()); // 10 kg * m^-3

```

### 단위계 정의하기

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