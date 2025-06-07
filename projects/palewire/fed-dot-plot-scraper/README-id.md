Mengekstrak proyeksi ekonomi ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) yang dipublikasikan secara online oleh [Federal Open Market Committee](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Sumber](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Data terbaru hasil scraping](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Penggunaan

Klon repositori.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Masuk ke direktori.

```bash
cd fed-dot-plot-scraper
```

Instal dependensi.

```bash
pipenv install --dev
```

Jalankan scraper.

```bash
pipenv run python -m src.scrape
```

Perintah tersebut akan menghasilkan file CSV di shell. Anda dapat menulisnya ke sebuah file seperti berikut:

```bash
pipenv run python -m src.scrape > output.csv
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---