["Dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) ekonomik projeksiyonlarının [Federal Açık Piyasa Komitesi](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee) tarafından çevrimiçi olarak yayınlanan verilerinin çıkarılması

* [Kaynak](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [En son çekilen veri](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Kullanım

Depoyu klonlayın.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Dizine geçin.

```bash
cd fed-dot-plot-scraper
```

Bağımlılıkları yükleyin.

```bash
pipenv install --dev
```

Scraper'ı çalıştırın.

```bash
pipenv run python -m src.scrape
```

Bu işlem çıktıyı bir CSV olarak terminale verir. Dosyaya yazmak için şu şekilde kullanabilirsiniz:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---