Extrahieren der ["Dot Plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) Wirtschaftsprognosen, die online vom [Federal Open Market Committee](https://de.wikipedia.org/wiki/Federal_Open_Market_Committee) veröffentlicht werden

* [Quelle](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Neueste gescrapte Daten](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Verwendung

Klonen Sie das Repository.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Wechseln Sie in das Verzeichnis.

```bash
cd fed-dot-plot-scraper
```

Installieren Sie die Abhängigkeiten.

```bash
pipenv install --dev
```

Führen Sie den Scraper aus.

```bash
pipenv run python -m src.scrape
```

Dadurch wird eine CSV-Datei in der Shell ausgegeben. Sie können sie wie folgt in eine Datei schreiben:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---