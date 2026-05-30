# readsql

SQLを最も人間に読みやすい形式に変換します。現時点ではSQLキーワードを大文字にしますが、将来的にはSQLコードの整形や改善案の提案も行う可能性があります。SQLコードやプログラミング言語内のSQL文字列（現時点ではPythonのみ）を変換します。

ですので、もし私たちが書くときは

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```

readsqlはそれを次のように読み取るのに役立ちます

```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# インストール

```bash
pip install readsql
```
Python 3.8以上が必要です。

# 使用方法

1. コマンドラインで提供されたSQLコードをフォーマットする
    - `readsql <SQL_STRING> -s`
2. SQLファイルまたはフォルダをフォーマットする
    - フォルダの場合、拡張子が.sqlまたは.pyのファイルを探します
    - `readsql <FILE_OR_FOLDER_PATH>`

複数の文字列やファイル、フォルダもサポートしています

1.

```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```
2. Pythonファイル内で変数`query`の文字列を検索し、それらをフォーマットします

```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```

`-py` 引数を使って Python ファイル内の異なる文字列を検索できます
```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **注意**: `readsql` はPythonのASTパーサーを使用しているため、以下をサポートします:
> - **型ヒント**: `query: str = "..."`
> - **F文字列**: `f"SELECT * FROM {table}"`
> - **ネストされたスコープ**: 関数やクラス内の変数も堅牢に処理します。
> - **コメント/ドキュメンテーション文字列**: コメントやドキュメンテーション文字列内のSQL風テキストを正しく無視します。

# 使用例

1. `readsql 'select sushi from tokyo' -s` コマンドは次を返します
    - `SELECT sushi FROM tokyo`

2. a. `readsql sql_example.sql` コマンドは、`sql_example.sql` が以下のようなSQLコードを含むファイルの場合、
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
このコードでファイルを置き換えます
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```
2. b. `readsql sql_in_python_variable_example.py` コマンド、ここで `sql_in_python_variable_example.py` は以下のコードを含む Python ファイルです、

```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
このコードでファイルを置き換えます
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```

2. c. `readsql sql_in_python_variable_example.py -py sql` コマンド、ここで `sql_in_python_variable_example.py` は以下のコードを含むPythonファイルです、
```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
このコードでファイルを置き換えます
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. `readsql tests -n` コマンドは `tests` フォルダ内のすべてのフォーマットされたSQLコードを出力しますが、ファイルはフォーマットされたバージョンに置き換えられません（`-n` 引数は置き換えなしを意味します）

詳細な例は `/tests` フォルダにあります

# pre-commit フックの追加
readsql の [pre-commit](https://pre-commit.com/) フックを追加する方法は？
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# 開発

リポジトリをクローンし、開発には[uv](https://docs.astral.sh/uv/)を使用してください:

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# テスト

```bash
uv run pytest -v
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---