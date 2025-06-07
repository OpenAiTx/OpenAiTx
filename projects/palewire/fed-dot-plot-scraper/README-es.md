Extracción de las proyecciones económicas del ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) publicadas en línea por el [Comité Federal de Mercado Abierto](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Fuente](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Últimos datos extraídos](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Uso

Clona el repositorio.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Entra en el directorio.

```bash
cd fed-dot-plot-scraper
```

Instala las dependencias.

```bash
pipenv install --dev
```

Ejecuta el scraper.

```bash
pipenv run python -m src.scrape
```

Esto generará un archivo CSV en la terminal. Puedes escribirlo en un archivo así:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---