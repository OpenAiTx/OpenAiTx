Extraction des projections économiques du ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) publiées en ligne par le [Federal Open Market Committee](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Source](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Dernières données extraites](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Utilisation

Clonez le dépôt.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Déplacez-vous dans le répertoire.

```bash
cd fed-dot-plot-scraper
```

Installez les dépendances.

```bash
pipenv install --dev
```

Lancez le scraper.

```bash
pipenv run python -m src.scrape
```

Cela produira un fichier CSV dans le shell. Vous pouvez l’écrire dans un fichier comme ceci :

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---