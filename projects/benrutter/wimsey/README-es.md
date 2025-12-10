# 🔍 Wimsey

[![Codeberg](https://img.shields.io/badge/Codeberg-2185D0?style=for-the-badge&logo=Codeberg&logoColor=white)](https://codeberg.org/benrutter/wimsey)
[![PyPi](https://img.shields.io/badge/pypi-%23ececec.svg?style=for-the-badge&logo=pypi&logoColor=1f73b7)](https://pypi.org/project/wimsey/)

[![Docs](https://img.shields.io/badge/Docs-hugo-blue)](https://benrutter.codeberg.page/wimsey-site/site/)
![License](https://img.shields.io/badge/license-MIT-blue)
![coverage](https://img.shields.io/badge/coverage-100-green)


Wimsey es una biblioteca ligera, flexible y totalmente de código abierto para contratos de datos.

- 🐋 **Trae tu propia biblioteca de dataframes**: Construido sobre [Narwhals](https://github.com/narwhals-dev/narwhals) para que tus pruebas se realicen de forma nativa en tu propia biblioteca de dataframes (incluyendo Pandas, Polars, Pyspark, Dask, DuckDB, CuDF, Rapids, Arrow y Modin)
- 🎍 **Trae tu propio formato de contrato**: Escribe contratos en yaml, json o python - ¡el que prefieras!
- 🪶 **Ultra Ligero**: Diseñado para importaciones rápidas y con una sobrecarga mínima con solo dos dependencias ([Narwhals](https://github.com/narwhals-dev/narwhals) y [FSSpec](https://github.com/fsspec/filesystem_spec))
- 🥔 **API simple y fácil**: Baja carga mental con dos funciones simples para probar dataframes, y una dataclass sencilla para resultados.

Consulta el útil [catálogo de pruebas](https://benrutter.github.io/wimsey/possible_tests/) y la [guía rápida](https://benrutter.github.io/wimsey/)

## ¿Qué es un contrato de datos?

Además de ser una buena palabra de moda para mencionar en tu próximo evento de datos, los contratos de datos son una buena forma de probar valores de datos en puntos límite. Idealmente, todos los datos serían utilizables cuando los recibes, pero probablemente ya hayas descubierto que no siempre es así.

Un contrato de datos es una expresión de lo que *debería* ser cierto sobre algunos datos - podríamos querer verificar que las únicas columnas que existen son `first_name`, `last_name` y `rating`, o podríamos querer verificar que `rating` es un número menor que 10.

Wimsey te permite escribir contratos en json, yaml o python, así se verían las verificaciones anteriores en yaml:

```yaml
- test: columns_should
  be:
    - first_name
    - last_name
    - rating
- column: rating
  test: max_should
  be_less_than_or_equal_to: 10
```

Wimsey entonces puede ejecutar pruebas para usted de un par de maneras, `validate` - que lanzará un error si las pruebas fallan, y de lo contrario devolverá su dataframe - y `test`, que le dará un desglose detallado de éxitos y fallos de pruebas individuales.

Validate está diseñado para funcionar bien con los métodos `pipe` de polars o pandas como una protección útil:

```python
import polars as pl
import wimsey

df = (
  pl.read_csv("hopefully_nice_data.csv")
  .pipe(wimsey.validate, "tests.json")
  .group_by("name").agg(pl.col("value").sum())
)
```

La prueba es una única llamada a función, que retorna un tipo de dato `FinalResult`:

```python
import pandas as pd
import wimsey

df = pd.read_csv("hopefully_nice_data.csv")
results = wimsey.test(df, "tests.yaml")

if results.success:
  print("Yay we have good data! 🥳")
else:
  print(f"Oh nooo, something's up! 😭")
  print([i for i in results.results if not i.success])
```
# Hoja de ruta, Contribuciones y Comentarios

Wimsey está replicado en github, pero alojado y desarrollado en [codeberg](https://codeberg.org/benrutter/wimsey). Se aceptan problemas y solicitudes de extracción en ambos.

El enfoque en este momento está en refinar el perfilado y la generación de pruebas, si tienes pruebas o funciones que te serían útiles, ¡no dudes en contactar!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---