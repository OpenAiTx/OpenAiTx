# Kelp

Een UI-bibliotheek voor mensen die van HTML houden, aangedreven door moderne CSS en Web Components.

**[Lees de documentatie &rarr;](https://kelpui.com)**

_**Let op:** Kelp is momenteel in ontwikkeling in alfa. Voel je vrij om het te gebruiken, te experimenteren en bugs te melden, maar begrijp dat dingen kunnen en zullen veranderen in de loop van de tijd._



## Snelstart

Kelp werkt zonder enige build-stap.

[Het CDN](https://cdn.jsdelivr.net/npm/kelpui/) is de snelste en eenvoudigste manier om te beginnen, maar je kunt [de bestanden downloaden van GitHub](https://github.com/cferdinandi/kelp) als je dat liever hebt.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp gebruikt semantische versiebeheer. Je kunt een major-, minor- of patchversie van het CDN halen met de `@1.2.3` syntaxis. Je vindt alle beschikbare versies [onder releases](https://github.com/cferdinandi/kelp/tags).



## Demo

Het meegeleverde `index.html` bestand is een kitchen sink-demo van Kelp. Het bevat elke functie en component in één groot bestand.

Zolang Kelp in beta is, heeft het geen compile-stap. De webcomponent gebruikt ES-imports en vereist een lokale server om te draaien.

Gebruik je favoriete server, of gebruik de meegeleverde `http-server` door `npm run dev` uit te voeren.

```bash
npm install
npm run dev
```

Naarmate Kelp richting v1 gaat, zal het een compile-stap gebruiken om dit overbodig te maken.



## Tests

Kelp gebruikt...

- [Playwright](https://playwright.dev) voor tests
- [Biome](https://biomejs.dev) voor linten en formatteren
- Een continuous integration-proces bij deploys en PR's

```bash
# Voer tests uit
npm run test

# Voer linter uit
npm run lint
```



## Licentie

Vrij te gebruiken onder de [Kelp Commons Licentie](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Er zijn ook [commerciële licentie-opties](/license/) beschikbaar.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---