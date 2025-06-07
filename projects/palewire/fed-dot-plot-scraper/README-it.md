Estrazione delle proiezioni economiche del ["dot plot"](https://it.wikipedia.org/wiki/Fedspeak#Altri_usi) pubblicate online dal [Federal Open Market Committee](https://it.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Fonte](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Ultimi dati estratti](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Utilizzo

Clona il repository.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Spostati nella directory.

```bash
cd fed-dot-plot-scraper
```

Installa le dipendenze.

```bash
pipenv install --dev
```

Esegui lo scraper.

```bash
pipenv run python -m src.scrape
```

Questo genererà un file CSV nel terminale. Puoi salvarlo in un file così:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---