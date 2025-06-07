Extraindo as projeções econômicas do ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) publicadas online pelo [Comitê Federal de Mercado Aberto](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Fonte](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Dados mais recentes extraídos](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Uso

Clone o repositório.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Acesse o diretório.

```bash
cd fed-dot-plot-scraper
```

Instale as dependências.

```bash
pipenv install --dev
```

Execute o scraper.

```bash
pipenv run python -m src.scrape
```

Isso irá gerar um CSV no terminal. Você pode gravá-lo em um arquivo assim:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---