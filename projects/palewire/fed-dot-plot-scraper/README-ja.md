["ドットプロット"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) 経済予測を、[連邦公開市場委員会（FOMC）](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee) がオンラインで公開しているものから抽出します。

* [ソース](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [最新のスクレイピングデータ](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## 使用方法

リポジトリをクローンします。

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

ディレクトリに移動します。

```bash
cd fed-dot-plot-scraper
```

依存関係をインストールします。

```bash
pipenv install --dev
```

スクレイパーを実行します。

```bash
pipenv run python -m src.scrape
```

これにより、CSVがシェルに出力されます。以下のようにファイルに書き込むこともできます。

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---