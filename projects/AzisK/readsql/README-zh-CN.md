# readsql

将 SQL 转换为最易读的格式。目前它会将 SQL 关键字转换为大写，未来可能会美化甚至建议改进 SQL 代码。它可以转换 SQL 代码，甚至是编程语言中的 SQL 字符串（目前仅支持 Python）。

所以如果我们写下

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```
readsql 将帮助我们读取它为


```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# 安装

```bash
pip install readsql
```

需要 Python 3.8 及以上版本。

# 使用方法

1. 格式化命令行中提供的 SQL 代码
    - `readsql <SQL_STRING> -s`
2. 格式化 SQL 文件或文件夹
    - 如果是文件夹，会查找以 .sql 或 .py 结尾的文件
    - `readsql <FILE_OR_FOLDER_PATH>`

它也支持多个字符串和文件或文件夹

1.
```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```
2. 在 Python 文件中，它查找变量 `query` 字符串并对其进行格式化  

```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```
我们可以使用 `-py` 参数在 Python 文件中查找不同的字符串

```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **注意**: `readsql` 使用 Python 的 AST 解析器，因此支持：
> - **类型提示**：`query: str = "..."`
> - **格式化字符串**：`f"SELECT * FROM {table}"`
> - **嵌套作用域**：稳健处理函数和类中的变量。
> - **注释/文档字符串**：正确忽略注释或文档字符串中的类 SQL 文本。

# 使用示例

1. `readsql 'select sushi from tokyo' -s` 命令返回
    - `SELECT sushi FROM tokyo`

2. a. `readsql sql_example.sql` 命令，其中 `sql_example.sql` 是一个包含如下代码的 SQL 文件，
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
用此代码替换该文件
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```
2. b. `readsql sql_in_python_variable_example.py` 命令，同时 `sql_in_python_variable_example.py` 是一个包含如下代码的 Python 文件，

```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
用此代码替换该文件
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```
2. c. `readsql sql_in_python_variable_example.py -py sql` 命令，同时 `sql_in_python_variable_example.py` 是一个包含如下代码的 Python 文件，

```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
用此代码替换文件
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. `readsql tests -n` 命令输出 `tests` 文件夹中所有格式化的 SQL 代码，文件不会被格式化版本替换（`-n` 参数表示不替换）

更多示例可在 `/tests` 文件夹中找到

# 添加 pre-commit 钩子
如何添加 readsql 的 [pre-commit](https://pre-commit.com/) 钩子？
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# 开发

克隆代码库并使用 [uv](https://docs.astral.sh/uv/) 进行开发：

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# 测试

```bash
uv run pytest -v
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---