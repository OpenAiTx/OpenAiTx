Wyodrębnianie ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) projekcji ekonomicznych publikowanych online przez [Federal Open Market Committee](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Źródło](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Najnowsze zeskrobane dane](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Użytkowanie

Sklonuj repozytorium.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Przejdź do katalogu.

```bash
cd fed-dot-plot-scraper
```

Zainstaluj zależności.

```bash
pipenv install --dev
```

Uruchom scraper.

```bash
pipenv run python -m src.scrape
```

To wygeneruje plik CSV na konsolę. Możesz zapisać go do pliku w ten sposób:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---