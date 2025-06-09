# Update Browserslist DB

<img width="120" height="120" alt="Browserslist-logo door Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

CLI-tool om `caniuse-lite` bij te werken met browsers-DB
vanuit [Browserslist](https://github.com/browserslist/browserslist/) config.

Sommige queries zoals `last 2 versions` of `>1%` zijn afhankelijk van actuele data
uit `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Gesponsord door Evil Martians" width="236" height="54">
</a>

## Waarom je dit regelmatig moet uitvoeren

`npx update-browserslist-db@latest` werkt de `caniuse-lite` versie bij
in je npm-, yarn- of pnpm-lockbestand.

Deze update brengt gegevens over nieuwe browsers naar polyfill-tools
zoals Autoprefixer of Babel en vermindert reeds overbodige polyfills.

Je moet dit regelmatig doen om drie redenen:

1. Om de nieuwste browserversies en statistieken te gebruiken in queries zoals
   `last 2 versions` of `>1%`. Bijvoorbeeld, als je je project
   2 jaar geleden hebt aangemaakt en je afhankelijkheden niet hebt bijgewerkt, zal `last 1 version`
   2 jaar oude browsers opleveren.
2. Actuele browserdata leidt tot minder polyfills. Dit verkleint
   de omvang van JS- en CSS-bestanden en verbetert de websiteprestaties.
3. `caniuse-lite` deduplicatie: om versies in verschillende tools te synchroniseren.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---