Извлечение экономических прогнозов ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage), размещённых в сети [Федеральным комитетом по операциям на открытом рынке](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Источник](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Последние извлечённые данные](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Использование

Клонируйте репозиторий.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Перейдите в каталог.

```bash
cd fed-dot-plot-scraper
```

Установите зависимости.

```bash
pipenv install --dev
```

Запустите скрейпер.

```bash
pipenv run python -m src.scrape
```

Это выведет CSV в консоль. Вы можете записать его в файл следующим образом:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---