提取由[联邦公开市场委员会](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)在线发布的["点阵图"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage)经济预测

* [来源](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [最新抓取数据](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## 使用方法

克隆该仓库。

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

进入目录。

```bash
cd fed-dot-plot-scraper
```

安装依赖包。

```bash
pipenv install --dev
```

运行爬虫程序。

```bash
pipenv run python -m src.scrape
```

该命令将在终端输出一个CSV文件。你可以通过如下方式将其写入文件：

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---