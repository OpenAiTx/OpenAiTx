# readsql

Convierte SQL al formato más legible para humanos. Por el momento pone en mayúsculas las palabras clave de SQL, podría embellecer o incluso sugerir mejoras en el código SQL en el futuro. Convierte código SQL e incluso cadenas SQL en lenguajes de programación (solo Python por ahora).

Así que si escribimos

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```

readsql nos ayudará a leerlo como

```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# Instalación

```bash
pip install readsql
```
Requiere Python 3.8+.

# Uso

1. Formatear código SQL proporcionado en la línea de comandos
    - `readsql <SQL_STRING> -s`
2. Formatear un archivo o carpeta SQL
    - como en una carpeta, buscará archivos que terminen con .sql o .py
    - `readsql <FILE_OR_FOLDER_PATH>`

También soporta múltiples cadenas y archivos o carpetas

1.

```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```
2. En archivos de Python busca cadenas de variables `query` y las formatea

```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```
Podemos buscar diferentes cadenas en archivos Python con argumentos `-py`

```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **Nota**: `readsql` utiliza el analizador AST de Python, por lo que soporta:
> - **Hints de tipo**: `query: str = "..."`
> - **F-strings**: `f"SELECT * FROM {table}"`
> - **Ámbitos anidados**: Maneja robustamente variables dentro de funciones y clases.
> - **Comentarios/Docstrings**: Ignora correctamente texto tipo SQL en comentarios o docstrings.

# Ejemplos de uso

1. El comando `readsql 'select sushi from tokyo' -s` devuelve
    - `SELECT sushi FROM tokyo`

2. a. El comando `readsql sql_example.sql`, mientras que `sql_example.sql` es un archivo SQL con el código siguiente,
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
reemplaza el archivo con este código
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```
2. b. Comando `readsql sql_in_python_variable_example.py`, mientras que `sql_in_python_variable_example.py` es un archivo Python con el código siguiente,

```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
reemplaza el archivo con este código
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```
2. c. Comando `readsql sql_in_python_variable_example.py -py sql`, mientras que `sql_in_python_variable_example.py` es un archivo Python con el código como se muestra a continuación,

```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
reemplaza el archivo con este código
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. El comando `readsql tests -n` muestra todo el código SQL formateado en la carpeta `tests`, los archivos no son reemplazados por la versión formateada (el argumento `-n` significa no reemplazar)

Se pueden encontrar más ejemplos en la carpeta `/tests`

# Añadir un hook pre-commit
¿Cómo añadir un hook [pre-commit](https://pre-commit.com/) de readsql?
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# Desarrollo

Clona el repositorio y usa [uv](https://docs.astral.sh/uv/) para el desarrollo:

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# Pruebas

```bash
uv run pytest -v
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---