# Unidades Seguras

[![Versión NPM](https://img.shields.io/npm/v/safe-units.svg)](https://www.npmjs.com/package/safe-units) [![Licencia MIT](https://img.shields.io/npm/l/safe-units.svg)](https://github.com/jscheiny/safe-units/blob/master/LICENSE)

Unidades Seguras es una biblioteca con tipado seguro para usar unidades de medida en TypeScript. Unidades Seguras proporciona una implementación de un sistema de unidades basado en el SI, pero es lo suficientemente flexible para permitir a los usuarios crear sus propios sistemas de unidades que pueden ser independientes o interoperar con las unidades integradas. Los usuarios también pueden crear sistemas de unidades para cualquier tipo numérico que deseen, no solo para el tipo `number` de JavaScript. Esta biblioteca requiere TypeScript 3.2 o superior.

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

## Características

⭐&nbsp; Aritmética de unidades en tiempo de compilación para análisis dimensional con tipos seguros (con exponentes entre -5 y +5)!

⭐&nbsp; Gran biblioteca de unidades predefinidas que incluye SI (con prefijos), Imperial y unidades habituales de EE. UU.!

⭐&nbsp; Capacidad para agregar tu propio sistema de unidades que puede funcionar con unidades integradas!

⭐&nbsp; Tiempos de compilación largos y mensajes de error crípticos!

## Requisitos previos

Safe units está escrito en TypeScript y debe ser utilizado por usuarios de TypeScript para aprovechar al máximo lo que ofrece. Además, necesitarás lo siguiente:

- [TypeScript](http://www.typescriptlang.org/) 3.2 o superior
- [Comprobaciones estrictas de null](https://www.typescriptlang.org/docs/handbook/compiler-options.html) habilitadas para tu proyecto

## Instalación

```
npm install safe-units
```

or 

```
yarn add safe-units
```

## Ejemplos

### Aritmética de Unidades

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

### Errores de Tipo

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

### Nombrar Unidades

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

### Derivando cantidades

```ts
import { kilograms, liters, Mass, Measure, Volume } from "safe-units";

const VolumeDensity = Mass.over(Volume);
type VolumeDensity = typeof VolumeDensity;

const mass = Measure.of(30, kilograms);
const volume = Measure.of(3, liters);

const density: VolumeDensity = mass.over(volume);

console.log(density.toString()); // 10 kg * m^-3

```

### Definición de Sistemas de Unidades

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