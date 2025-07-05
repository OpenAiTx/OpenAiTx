# Kelp

Una libreria UI per chi ama l’HTML, alimentata da CSS moderni e Web Components.

**[Leggi la documentazione &rarr;](https://kelpui.com)**

_**Nota:** Kelp è attualmente in sviluppo in versione alpha. Sentiti libero di usarlo, sperimentare e segnalare bug, ma comprendi che le cose possono e cambieranno nel tempo._



## Avvio rapido

Kelp funziona senza alcun passaggio di build.

[Il CDN](https://cdn.jsdelivr.net/npm/kelpui/) è il modo più veloce e semplice per iniziare, ma puoi [scaricare i file da GitHub](https://github.com/cferdinandi/kelp) se preferisci.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp utilizza il versionamento semantico. Puoi ottenere una versione major, minor o patch dal CDN con la sintassi `@1.2.3`. Puoi trovare tutte le versioni disponibili [alla sezione releases](https://github.com/cferdinandi/kelp/tags).



## Demo

Il file `index.html` incluso è una demo "kitchen sink" di Kelp. Include ogni funzionalità e componente in un unico grande file.

Durante la beta, Kelp non richiede alcun passaggio di compilazione. Il web component usa ES import, e richiede un server locale per essere eseguito.

Usa il tuo server preferito, oppure utilizza l’`http-server` incluso eseguendo `npm run dev`.

```bash
npm install
npm run dev
```

Quando Kelp si avvicinerà alla versione v1, verrà introdotto un passaggio di compilazione per rendere questo passaggio non necessario.



## Test

Kelp utilizza... 

- [Playwright](https://playwright.dev) per i test
- [Biome](https://biomejs.dev) per linting e formattazione
- Un processo di integrazione continua su deploy e PR

```bash
# Esegui i test
npm run test

# Esegui il linter
npm run lint
```



## Licenza

Libero da usare sotto la [Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Sono disponibili anche [opzioni di licenza commerciale](/license/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---