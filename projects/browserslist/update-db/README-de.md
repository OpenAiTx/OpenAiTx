# Browserslist-DB aktualisieren

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

CLI-Tool zum Aktualisieren von `caniuse-lite` mit der Browser-Datenbank
aus der [Browserslist](https://github.com/browserslist/browserslist/) Konfiguration.

Einige Abfragen wie `last 2 versions` oder `>1%` hängen von den aktuellen Daten
aus `caniuse-lite` ab.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## Warum Sie es regelmäßig ausführen sollten

`npx update-browserslist-db@latest` aktualisiert die Version von `caniuse-lite`
in Ihrer npm-, yarn- oder pnpm-Lockdatei.

Dieses Update bringt Daten über neue Browser zu Polyfill-Tools
wie Autoprefixer oder Babel und reduziert bereits unnötige Polyfills.

Sie sollten dies aus drei Gründen regelmäßig tun:

1. Um die neuesten Browserversionen und Statistiken in Abfragen wie
   `last 2 versions` oder `>1%` zu verwenden. Wenn Sie zum Beispiel Ihr Projekt
   vor 2 Jahren erstellt und Ihre Abhängigkeiten nicht aktualisiert haben, liefert
   `last 1 version` 2 Jahre alte Browser.
2. Aktuelle Browserdaten führen zur Verwendung von weniger Polyfills. Das reduziert
   die Größe von JS- und CSS-Dateien und verbessert die Website-Performance.
3. `caniuse-lite`-Deduplikation: zur Synchronisierung der Versionen in verschiedenen Tools.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---