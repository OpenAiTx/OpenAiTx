# Aggiorna il DB di Browserslist

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Strumento CLI per aggiornare `caniuse-lite` con il database dei browser
dalla configurazione di [Browserslist](https://github.com/browserslist/browserslist/).

Alcune query come `last 2 versions` o `>1%` dipendono dai dati effettivi
di `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## Perché è necessario eseguirlo regolarmente

`npx update-browserslist-db@latest` aggiorna la versione di `caniuse-lite`
nel tuo file di lock di npm, yarn o pnpm.

Questo aggiornamento porterà i dati sui nuovi browser agli strumenti di polyfill
come Autoprefixer o Babel e ridurrà i polyfill già non necessari.

Devi farlo regolarmente per tre motivi:

1. Per utilizzare le versioni e le statistiche più recenti dei browser nelle query come
   `last 2 versions` o `>1%`. Ad esempio, se hai creato il tuo progetto
   2 anni fa e non hai aggiornato le dipendenze, `last 1 version`
   restituirà browser di 2 anni fa.
2. I dati attuali dei browser porteranno all'utilizzo di meno polyfill. Questo ridurrà
   la dimensione dei file JS e CSS e migliorerà le prestazioni del sito web.
3. Deduplicazione di `caniuse-lite`: per sincronizzare le versioni tra diversi strumenti.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---