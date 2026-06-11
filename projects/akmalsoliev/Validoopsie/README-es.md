<h1 align="center">
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/validoopsie-text.png>
    <p style="font-size: 16px; font-weight: bold;">Una biblioteca de Validación de Datos simple y fácil de usar para Python.</p>
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/logo.png>
</h1>

<p align="center">
  <a href="https://badge.fury.io/py/Validoopsie">
    <img src="https://badge.fury.io/py/Validoopsie.svg" alt="Versión PyPI" />
  </a>
  <a href="https://pepy.tech/projects/validoopsie">
    <img src="https://static.pepy.tech/badge/validoopsie" alt="Descargas PyPI">
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml/badge.svg" alt="Pruebas y Linters" />
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml/badge.svg" alt="Documentación" />
  </a>
</p>

# Validoopsie

Validoopsie es una biblioteca de validación de datos notablemente ligera y fácil de usar para Python.  
Está diseñada para ayudarte a declarar clases fácilmente y encadenar validaciones juntas,  
en un estilo que recuerda a las populares bibliotecas de DataFrame.  
Esto la convierte en una herramienta familiar e intuitiva para desarrolladores que trabajan regularmente  
con dataframes.

Gracias al excelente trabajo de  
[Narwhals](https://github.com/narwhals-dev/narwhals), Validoopsie incorpora  
el concepto "Trae Tu Propio DataFrame" (BYOD). Esta flexibilidad te permite  
usar cualquier DataFrame que Narwhals soporte para tus tareas de validación de datos. Para  
explorar la gama completa de DataFrames soportados, puedes visitar  
[este enlace](https://narwhals-dev.github.io/narwhals/extending/).

La sintaxis de Validoopsie ha sido cuidadosamente diseñada para asegurar facilidad de uso.  
Cada función de validación está encapsulada en su propio método, que puede ser  
enlazado sin problemas. Este diseño específico por método prioriza la simplicidad  
y la legibilidad, liberándote de la necesidad de adaptarte a una nueva API cada vez que tú
bibliotecas de cambio. Te permite concentrarte en mantener un código limpio y comprensible.

Validoopsie se inspira significativamente en la biblioteca Great Expectations.
Se esfuerza por destilar el proceso de validación de datos en algo sencillo
y eficiente. Ya sea que estés verificando la integridad de los datos o asegurando el cumplimiento
con los estándares de datos, Validoopsie ofrece una solución optimizada pero poderosa para
hacer que estas tareas sean accesibles y sencillas.

## Tabla de Contenidos

1. [Instalación](#installation)
2. [Primeros Pasos](#getting-started)
3. [Versión](#version)
4. [Métodos Dunder](#dunder-methods)
5. [Método Validate](#validate-method)
6. [Desarrollo](#development)
7. [Licencia](#license)

## Instalación

- pip

  `pip install Validoopsie`

- uv

  `uv add Validoopsie`

## Primeros Pasos

- [📖 Documentación](https://akmalsoliev.github.io/Validoopsie/)
- [🚨 Niveles de Impacto en Validoopsie](https://akmalsoliev.github.io/Validoopsie/impact_levels.html)
- [🎯 Niveles de Umbral en Validoopsie](https://akmalsoliev.github.io/Validoopsie/threshold_levels.html)
- [🛠️ Guía de Contribución](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)
- [✨ Cómo Contribuir con una Nueva Validación en Validoopsie](https://akmalsoliev.github.io/Validoopsie/contributing/DevelopingValidation.html)
- [🧑‍💻 Desarrolla tu Propia Validación Personalizada](https://akmalsoliev.github.io/Validoopsie/custom_validations/DevelopingValidationCustom.html)
- [🗂️ Catálogo de Validaciones](https://akmalsoliev.github.io/Validoopsie/validation_catalogue/Date%20Validation.html)

Validoopsie es increíblemente fácil de usar, tanto que podrías hacerlo

medio dormido. La simplicidad de la biblioteca se mejora con el concepto BYOD (Trae Tu Propio DataFrame), donde solo necesitas utilizar la clase `Validate`  
y encadenar las validaciones que desees. Este enfoque garantiza que puedas  
comenzar con un esfuerzo mínimo y sin ninguna complejidad innecesaria.


```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
)

vd.results
```
**SALIDA:**


```json
{
  "Summary": {
    "passed": false,
    "validations": [
      "PairColumnEquality_name",
      "ColumnUniqueValuesToBeInList_last_name",
      "ColumnValuesToBeBetween_age"
    ],
    "failed_validation": ["PairColumnEquality_name"]
  },
  "PairColumnEquality_name": {
    "validation": "PairColumnEquality",
    "impact": "high",
    "timestamp": "2025-10-07T11:25:04.213211+02:00",
    "column": "name",
    "result": {
      "status": "Fail",
      "threshold_pass": false,
      "message": "The column 'name' is not equal to the column'age'.",
      "failing_items": [
        "Doe - column name - column age - 30",
        "Jane - column name - column age - 35",
        "John - column name - column age - 25"
      ],
      "failed_number": 3,
      "frame_row_number": 3,
      "threshold": 0.0,
      "failed_percentage": 1.0
    }
  },
  "ColumnUniqueValuesToBeInList_last_name": {
    "validation": "ColumnUniqueValuesToBeInList",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.216417+02:00",
    "column": "last_name",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  },
  "ColumnValuesToBeBetween_age": {
    "validation": "ColumnValuesToBeBetween",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.217300+02:00",
    "column": "age",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  }
}
```

También puedes mostrar los resultados de la validación en una tabla formateada utilizando el
método `display_summary`, que ofrece una vista limpia y legible de tus
resultados de validación:

```py
vd.display_summary()
```

![default display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_default.png)

### Display a full detailed table with all available information

```py
vd.display_summary(information="full")
```

![full display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_full.png)

### Customize the table format (supports tabulate formatting options)

```py
vd.display_summary(tablefmt="pipe", maxcolwidths=20)
```

![kwargs display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_pipe.png)

El método `display_summary` soporta dos niveles de información:

- `"short"` (por defecto): Muestra métricas clave como marca de tiempo, impacto, estado,
  tipo de validación, columna, umbral y detalles de fallos
- `"full"`: Muestra todos los campos disponibles de validación y resultados

También puedes personalizar la apariencia de la tabla usando cualquier opción de formato
de `tabulate` como `tablefmt` para diferentes estilos de tabla (por ejemplo, "github", "grid",
"pipe", "html") y `maxcolwidths` para controlar el ancho de las columnas.

## Versión

Puedes verificar la versión instalada de Validoopsie en cualquier momento:

```py
from validoopsie import __version__

print(__version__)
```

## Métodos Dunder

La clase `Validate` soporta varios métodos dunder de Python para mayor comodidad:

- `repr(vd)` — devuelve una cadena resumen con el recuento de filas y el número de validaciones:

  ```py
  >>> repr(vd)
  'Validate(rows=3, validations=3)'
  ```

- `str(vd)` — devuelve una cadena de estado legible para humanos:

  ```py
  >>> str(vd)
  'Validate: 3 validation(s), passed=False'
  ```

- `len(vd)` — devuelve el número de validaciones:

  ```py
  >>> len(vd)
  3
  ```

## Método Validate

Para asegurarse de que todas sus validaciones se hayan ejecutado correctamente y manejar
cualquier error potencial que pueda surgir durante el proceso de validación, puede usar
el método `validate`. Sin embargo, es importante señalar que los errores solo se
generarán si el nivel de `impact` está configurado en `high`. Sin esta configuración,
los problemas potenciales pueden no activar un mensaje de error.

**NOTA:** El error generado es un `ValueError` personalizado.

```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
).validate()
```

Gracias a [loguru](https://github.com/Delgan/loguru) la salida proporcionará una información muy
concisa sobre las validaciones y su estado de una manera colorida.

<p align="left">
    <img width="1000" alt="salida de validación" src=./docs/assets/validate.png>
</p>

## Desarrollo

Validoopsie incluye un Makefile para simplificar las tareas de desarrollo:

```bash
# Install dependencies
make setup

# Run linters (mypy, ruff)
make lint

# Run tests (includes doctests, stubtest)
make test

# Run both lint and test
make all
```

Para más información sobre el desarrollo, consulta las
[directrices de contribución](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html).

## Licencia

MIT © Validoopsie

Creador Original - [Akmal Soliev](https://github.com/akmalsoliev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---