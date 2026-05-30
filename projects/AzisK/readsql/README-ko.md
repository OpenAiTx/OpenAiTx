# readsql

SQL을 가장 사람이 읽기 쉬운 형식으로 변환합니다. 현재는 SQL 키워드를 대문자로 변환하며, 향후 SQL 코드를 예쁘게 꾸미거나 개선 사항을 제안할 수도 있습니다. SQL 코드와 프로그래밍 언어 내의 SQL 문자열(현재는 Python만 지원)을 변환합니다.

그래서 우리가 작성하면

```sql
select sushi, avg(price) from tokyo where ocean = 'pacific' group by sushi
```
readsql은 이를 다음과 같이 읽는 데 도움을 줍니다


```sql
SELECT sushi, AVG(price) FROM tokyo WHERE ocean = 'pacific' GROUP BY sushi
```

# 설치

```bash
pip install readsql
```
Python 3.8 이상이 필요합니다.

# 사용법

1. 명령줄에 제공된 SQL 코드를 포맷팅
    - `readsql <SQL_STRING> -s`
2. SQL 파일 또는 폴더를 포맷팅
    - 폴더의 경우 .sql 또는 .py로 끝나는 파일을 찾습니다
    - `readsql <FILE_OR_FOLDER_PATH>`

여러 문자열과 파일 또는 폴더도 지원합니다

1.

```bash
readsql <SQL_STRING1> <SQL_STRING2> -s
```
2. 파이썬 파일에서는 변수 `query` 문자열을 찾아서 형식을 지정합니다

```bash
readsql <FILE_OR_FOLDER_PATH1> <FILE_OR_FOLDER_PATH2>
```

우리는 `-py` 인수를 사용하여 Python 파일에서 다양한 문자열을 검색할 수 있습니다
```bash
readsql <FILE_OR_FOLDER_PATH> -py <PY_VAR1> <PY_VAR2>
```

> **참고**: `readsql`는 Python의 AST 파서를 사용하므로 다음을 지원합니다:
> - **타입 힌트**: `query: str = "..."`
> - **F-문자열**: `f"SELECT * FROM {table}"`
> - **중첩 스코프**: 함수 및 클래스 내부 변수도 견고하게 처리합니다.
> - **주석/문서 문자열**: 주석이나 문서 문자열 내의 SQL과 유사한 텍스트를 올바르게 무시합니다.

# 사용 예제

1. `readsql 'select sushi from tokyo' -s` 명령은
    - `SELECT sushi FROM tokyo`를 반환합니다.

2. a. `readsql sql_example.sql` 명령은, `sql_example.sql`이 아래와 같은 코드가 포함된 SQL 파일일 때,
```sql
select max(height), avg(mass), min(age) from jungle group by forest where animal=elephant;
```
이 코드를 사용하여 파일을 교체합니다
```sql
SELECT MAX(height), AVG(mass), MIN(age) FROM jungle GROUP BY forest WHERE animal=elephant;
```

2. b. `readsql sql_in_python_variable_example.py` 명령어, 여기서 `sql_in_python_variable_example.py`는 아래와 같은 코드가 포함된 파이썬 파일입니다,
```python
def get_query():
    limit = 6
    query = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return query
```
이 코드를 사용하여 파일을 교체합니다
```python
def get_query():
    limit = 6
    query = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return query
```

2. c. `readsql sql_in_python_variable_example.py -py sql` 명령어는, `sql_in_python_variable_example.py`가 아래와 같은 코드를 포함하는 파이썬 파일일 때 실행됩니다,
```python
def get_query():
    limit = 6
    sql = f"SELEct speed from world where animal='dolphin' limit {limit}"
    return sql
```
이 코드를 사용하여 파일을 교체합니다
```python
def get_query():
    limit = 6
    sql = f"SELECT speed FROM world WHERE animal='dolphin' LIMIT {limit}"
    return sql
```

2. d. `readsql tests -n` 명령어는 `tests` 폴더 내 모든 형식화된 SQL 코드를 출력하며, 파일은 형식화된 버전으로 교체되지 않습니다 (`-n` 인수는 교체하지 않음을 의미).

더 많은 예제는 `/tests` 폴더에서 확인할 수 있습니다.

# 사전 커밋 훅 추가하기
readsql의 [pre-commit](https://pre-commit.com/) 훅을 추가하는 방법은?
```yaml
repos:
-   repo: https://github.com/AzisK/readsql
    rev: v1.0.0  # Replace by any tag/version: https://github.com/azisk/readsql/tags
    hooks:
    -   id: readsql
```

# 개발

레포를 클론하고 개발을 위해 [uv](https://docs.astral.sh/uv/)를 사용하세요:

```bash
uv sync --all-extras                                    # Install dependencies
uv run readsql "select sushi from tokyo" -s             # Format a string
uv run readsql tests/sql_example.sql                    # Format SQL file
uv run readsql tests/sql_in_python_example.py           # Format SQL in Python
uv run readsql tests/sql_in_python_variable_example.py -py sql  # Custom variable
uv run readsql tests                                    # Format all files in folder
```

# 테스트

```bash
uv run pytest -v
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-30

---