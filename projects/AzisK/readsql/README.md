# readsql

Convert SQL to most human readable format. For the time being it upper cases SQL keywords, it might prettify or even suggest improvements of SQL code in the future. It converts SQL code and even SQL-strings in programming languages (only Python at the moment).

So if we write

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```

readsql will help us read it as

```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# Installation

```bash
pip install readsql
```

Requires Python 3.8+.

# Usage

1. Format SQL code provided in command line
    - `readsql <SQL_STRING> -s`
2. Format an SQL file or folder
    - as in a folder, it will look for files ending with .sql or .py
    - `readsql <FILE_OR_FOLDER_PATH>`

It supports multiple strings and files or folders as well

1.
```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```

2. In Python files it looks for variable `query` strings and formats them
```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```

We can look for different strings in Python files with `-py` arguments
```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **Note**: `readsql` uses Python's AST parser, so it supports:
> - **Type Hints**: `query: str = "..."`
> - **F-strings**: `f"SELECT * FROM {table}"`
> - **Nested Scopes**: Robustly handles variables inside functions and classes.
> - **Comments/Docstrings**: Correctly ignores SQL-like text in comments or docstrings.

# Usage examples

1. `readsql 'select sushi from tokyo' -s` command returns
    - `SELECT sushi FROM tokyo`

2. a. `readsql sql_example.sql` command, while `sql_example.sql` is a SQL file with code as below,
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
replaces the file with this code
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```

2. b. `readsql sql_in_python_variable_example.py` command, while `sql_in_python_variable_example.py` is a Python file with code as below,
```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
replaces the file with this code
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```

2. c. `readsql sql_in_python_variable_example.py -py sql` command, while `sql_in_python_variable_example.py` is a Python file with code as below,
```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
replaces the file with this code
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. `readsql tests -n` command outputs all of the formated SQL code in `tests` folder, files are not replaced by the formatted version (`-n` argument stand for not-replace)

More examples can be found in `/tests` folder

# Add a pre-commit hook
How to add a [pre-commit](https://pre-commit.com/) hook of readsql?
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# Development

Clone the repo and use [uv](https://docs.astral.sh/uv/) for development:

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# Testing

```bash
uv run pytest -v
```
