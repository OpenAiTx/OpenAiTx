# Safe Units

[![NPM Version](https://img.shields.io/npm/v/safe-units.svg)](https://www.npmjs.com/package/safe-units) [![MIT License](https://img.shields.io/npm/l/safe-units.svg)](https://github.com/jscheiny/safe-units/blob/master/LICENSE)

Safe Units est une bibliothèque typée sûre pour l’utilisation des unités de mesure en TypeScript. Safe Units fournit une implémentation d’un système d’unités basé sur le SI mais est suffisamment flexible pour permettre aux utilisateurs de créer leurs propres systèmes d’unités qui peuvent être indépendants ou interopérer avec les unités intégrées. Les utilisateurs peuvent également créer des systèmes d’unités pour n’importe quel type numérique de leur choix, pas seulement pour le type `number` de JavaScript. Cette bibliothèque nécessite TypeScript 3.2 ou supérieur.

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

## Fonctionnalités

⭐&nbsp; Arithmétique des unités à la compilation pour une analyse dimensionnelle typée en toute sécurité (avec des exposants entre -5 et +5) !

⭐&nbsp; Grande bibliothèque d'unités prédéfinies incluant le SI (avec préfixes), l'Impérial et les unités coutumières américaines !

⭐&nbsp; Possibilité d'ajouter votre propre système d'unités pouvant fonctionner avec les unités intégrées !

⭐&nbsp; Longs temps de compilation & messages d'erreur cryptiques !

## Prérequis

Safe units est écrit en TypeScript et doit être utilisé par des utilisateurs TypeScript pour profiter pleinement de ses fonctionnalités. De plus, vous aurez besoin de ce qui suit :

- [TypeScript](http://www.typescriptlang.org/) 3.2 ou ultérieur
- [Vérifications strictes des nulls](https://www.typescriptlang.org/docs/handbook/compiler-options.html) activées pour votre projet

## Installation

```
npm install safe-units
```

or 

```
yarn add safe-units
```

## Exemples

### Arithmétique Unitaire

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

### Erreurs de type

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

### Nommage des unités

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

### Dérivation des quantités

```ts
import { kilograms, liters, Mass, Measure, Volume } from "safe-units";

const VolumeDensity = Mass.over(Volume);
type VolumeDensity = typeof VolumeDensity;

const mass = Measure.of(30, kilograms);
const volume = Measure.of(3, liters);

const density: VolumeDensity = mass.over(volume);

console.log(density.toString()); // 10 kg * m^-3

```

### Définition des systèmes d'unités

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