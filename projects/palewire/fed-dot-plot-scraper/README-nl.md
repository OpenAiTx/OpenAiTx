Het extraheren van de ["dot plot"](https://nl.wikipedia.org/wiki/Fedspeak#Andere_gebruik) economische projecties die online zijn geplaatst door het [Federal Open Market Committee](https://nl.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Bron](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Meest recent gescrapete data](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Gebruik

Kloon de repository.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Ga naar de directory.

```bash
cd fed-dot-plot-scraper
```

Installeer de afhankelijkheden.

```bash
pipenv install --dev
```

Voer de scraper uit.

```bash
pipenv run python -m src.scrape
```

Dit zal een CSV naar de shell uitvoeren. Je kunt deze naar een bestand schrijven zoals hieronder:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---