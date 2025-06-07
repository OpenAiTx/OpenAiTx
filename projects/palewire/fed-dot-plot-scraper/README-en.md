Extracting the ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) economic projections posted online by the [Federal Open Market Committee](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Source](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Latest scraped data](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Usage

Clone the repository.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Move into the directory.

```bash
cd fed-dot-plot-scraper
```

Install the dependencies.

```bash
pipenv install --dev
```

Run the scraper.

```bash
pipenv run python -m src.scrape
```

That will output a CSV to the shell. You can write it to a file like this:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---