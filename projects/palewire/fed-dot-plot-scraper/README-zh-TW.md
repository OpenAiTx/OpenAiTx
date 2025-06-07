提取由[聯邦公開市場委員會](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)在網上發布的["點陣圖"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage)經濟預測

* [來源](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [最新擷取資料](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## 使用方法

複製此儲存庫。

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

進入目錄。

```bash
cd fed-dot-plot-scraper
```

安裝所需依賴套件。

```bash
pipenv install --dev
```

執行爬蟲程式。

```bash
pipenv run python -m src.scrape
```

這將在終端機輸出一個CSV檔。你可以這樣將其寫入檔案：

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---