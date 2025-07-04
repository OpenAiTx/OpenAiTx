# expr_codegen — Транслятор выражений

## Проект — предыстория

После выхода моего нового пакета [polars_ta](https://github.com/wukan1986/polars_ta), я вновь задумался над тем, что такое `expr_codegen`.

> `expr_codegen` по сути является `DSL`, предметно-ориентированным языком (Domain Specific Language). Однако он не определяет новый синтаксис.

Он решает две задачи:

1. В `polars_ta` уже можно удобно писать выражения для расчета признаков, но при встрече выражений с `смешанным использованием временных и кросс-секционных` признаков, с помощью `expr_codegen` можно автоматически группировать данные и существенно экономить время.
2. `expr_codegen` использует прием `Common Subexpression Elimination` (устранение общих подвыражений), что значительно сокращает повторные вычисления и повышает эффективность.

Даже в области количественного анализа: начинающим исследователям, работающим только с временными метриками, достаточно использовать только `polars_ta`. Для среднего и продвинутого уровня, когда используются кросс-секционные метрики, рекомендуется применять `expr_codegen`.

Хотя сейчас проект тесно связан с `polars_ta`, он поддерживает трансляцию и для других библиотек, таких как `pandas` / `cudf.pandas`, просто пока нет подходящей простой обертки.

## Онлайн-демо

https://exprcodegen.streamlit.app

Начинающие пользователи могут перейти по ссылке для трансляции выражений без необходимости дополнительной установки ПО. (Инструмент размещён за рубежом, открытие может занять время)

Более полные примеры доступны по ссылке [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Пример использования

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Редактор факторов. Можно использовать подсказки IDE для редактирования факторов в этом блоке.
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # В шаблоне по умолчанию импортировано множество операторов из from polars_ta.prefix,
    # но talib не импортируется по умолчанию. Такой импорт обеспечит его появление в сгенерированном коде.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Также поддерживается импорт def и class в исходном виде
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Переменные, начинающиеся с подчеркивания, являются промежуточными, будут автоматически переименованы и удалены в финальном выводе
    # 2. Переменные с подчеркиванием могут использоваться повторно. Если в нескольких строках сложных факторов используются одни и те же промежуточные переменные, конфликта не возникает
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Переменные с подчеркиванием могут использоваться в циклическом присваивании. Для отладки можно быстро переключать комментарии
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Печать кода
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Сохранить в файл
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Только выполнение, без сохранения кода

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Сохранить в строку
code.seek(0)
code.read()  # Прочитать код

# TODO заменить на подходящие данные
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Структура каталога

```commandline
│  requirements.txt # Установить зависимости через `pip install -r requirements.txt`
├─data
│      prepare_date.py # Подготовка данных
├─examples
│      demo_express.py # Быстрый старт. Как преобразовать выражение в код
│      demo_exec_pl.py # Демонстрация вызова сгенерированного кода и построения графиков
│      demo_transformer.py # Преобразование стороннего выражения во внутреннее
│      output.py # Вывод результата. Можно не изменять, импортировать в другие проекты
│      show_tree.py # Визуализация дерева выражения. Для анализа и сравнения оптимизации
│      sympy_define.py # Определения символов, вынесены отдельно из-за частого использования
├─expr_codegen
│   │  expr.py # Базовые функции обработки выражений
│   │  tool.py # Основные инструменты
│   ├─polars
│   │  │  code.py # Генерация кода под синтаксис polars
│   │  │  template.py.j2 # Шаблон `Jinja2` для генерации py-файлов, обычно не требует изменений
│   │  │  printer.py # Наследует `StrPrinter` из `Sympy`, при добавлении новых функций может потребоваться правка
```

## Принцип работы

Проект зависит от пакета `sympy`. Основные используемые функции:

1. `simplify`: Упрощение сложных выражений
2. `cse`: Устранение общих подвыражений (Common Subexpression Elimination)
3. `StrPrinter`: Вывод разных строк для разных функций. Кастомизация позволяет поддерживать другие языки и библиотеки

Так как `groupby` и `sort` достаточно ресурсоёмки, если заранее классифицировать формулы и использовать разные `groupby` для разных классов, можно сократить время вычислений.

1. `ts_xxx(ts_xxx)`: можно вычислять в одном `groupby`
2. `cs_xxx(cs_xxx)`: можно вычислять в одном `groupby`
3. `ts_xxx(cs_xxx)`: требуется вычислять в разных `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: требуется вычислять в трёх разных `groupby`
5. `gp_xxx(aa, )+gp_xxx(bb, )`: так как `aa` и `bb` разные, требуется два разных `groupby`

Таким образом:

1. Нужна функция, которая определяет тип текущего выражения (`get_current`) и типы подвыражений (`get_children`)
2. Если текущий и дочерний типы различаются, можно выделить короткую формулу (`extract`). Для выражений одного типа, но разных уровней — важен порядок, их нельзя поместить в один `groupby`.
3. Используя `cse`, длинные выражения заменяются на короткие, предварительно извлечённые. Затем строится направленный ациклический граф (`DAG`)
4. С помощью потоков в DAG выполняется слойность. Внутри одного слоя порядок `ts`, `cs`, `gp` не важен.
5. Внутри слоя выполняется группировка по `ts`, `cs`, `gp`, затем происходит генерация кода (`codegen`)

Скрытая информация:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

То есть:

1. Временные функции скрывают два поля: `ASSET, DATE`; кросс-секционные — одно поле: `DATE`
2. Групповые функции добавляют поле `GROUP`, одновременно скрывая поле `DATE`

Два способа классификации:

1. По префиксу оператора (`get_current_by_prefix`), ограничение: оператор должен начинаться с `ts_`, `cs_`, `gp_`
2. По полному имени оператора (`get_current_by_name`), без ограничений по названию (например, `cs_rank` можно назвать просто `rank`)

## Обработка Null

Как возникает `null`?

1. Из-за приостановки торгов. Перед вычислениями такие строки отфильтровываются, не влияют на дальнейшие расчёты.
2. Различие торговых сессий у инструментов
3. При вычислениях. `null` на концах числовых рядов не влияет на результат временных функций, но появление `null` в середине может повлиять. Например: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Отличная идея, обобщённо есть два способа реализации:

1. `null` выделяется в одну группу, `not_null` — в другую. Необходимо два вызова
2. Одна группа, но с составной сортировкой: `null` в начале, `not_null` в конце. Один вызов, чуть быстрее

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Второй способ: влияет ли зона `null` в начале, зависит от оператора, особенно когда на входе несколько столбцов — в зоне `null` могут быть данные.

1. `over_null='partition_by'` — разделить на две области
2. `over_null='order_by'` — одна область, `null` в начале
3. `over_null=None` — не обрабатывать, вызвать напрямую (быстрее). Если уверены, что не будет промежуточных `null`, используйте этот параметр

`codegen_exec(over_null='partition_by')` — глобально использовать `partition_by`. Но для функций типа `ts_count_nulls` надо использовать `over_null=None`, поэтому добавлен механизм аннотаций для задания параметров на уровне отдельных выражений.

1. `# --over_null partition_by` — только для одной строки `over_null='partition_by'`
2. `# --over_null=order_by` — только для одной строки `over_null='order_by'`
3. `# --over_null` — только для одной строки `over_null=None`
4. `# ` — берётся значение `over_null`, переданное в `codegen_exec`

Внимание:

1. Аннотацию `# --over_null` можно писать только в конце строки с выражением, не отдельно — иначе игнорируется
2. Если несколько `#`, например `# --over_null # --over_null=order_by`, берётся только первая валидная
3. Работает только для внешних функций `ts`. Если `ts` не во внешнем уровне — нужно вручную выносить. Например:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # применится к cs_rank, смысла нет
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # ожидалось применение к ts_rank(ts_mean), но из-за общего ts_mean на самом деле к ts_rank(_x_0)
   ```

   Следует писать так:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Легко ошибиться — рекомендуется всегда генерировать `output_file` и проверять сгенерированный код.

## Ограничения `expr_codegen`

1. В `DAG` можно только добавлять столбцы, удалять нельзя. При добавлении столбцов с одинаковым именем — будет перезапись
2. Не поддерживается `удаление строк`, но можно добавить столбец-маркер удаления, а потом удалять строки вне DAG. Удаление строк влияет на все столбцы, не соответствует принципу `DAG`
3. Не поддерживается `ресемплирование`, по той же причине, что и удаление строк. Необходимо выполнять снаружи
4. Можно использовать удаление строк и ресемплирование как границу, разбивая код на несколько цепочек `DAG`. Сложно и не прозрачно, поэтому не реализовано

## Особый синтаксис

1. Поддержка тернарного выражения `C?T:F` (только в строках). На низком уровне преобразуется в `C or True if( T )else F`, затем в `T if C else F`, в итоге — `if_else(C,T,F)`. Можно смешивать с `if else`
2. `(A<B)*-1` преобразуется в `int_(A<B)*-1`
3. Чтобы избежать замены `A==B` на `False` в `sympy`, заменяется на `Eq(A,B)`
4. Значение `A^B` зависит от параметра `convert_xor`: если `convert_xor=True`, преобразуется в `Pow(A,B)`, иначе — `Xor(A,B)`. По умолчанию `False`, для возведения в степень используйте `**`
5. Поддержка `A&B&C`, но не `A==B==C`. Если `C` — булево, а `AB` — числа, замените на `(A==B)==C`. Если все три — числа, замените на `(A==B)&(B==C)`
6. Не поддерживается `A<=B<=C`, вручную заменяйте на `(A<=B)&(B<=C)`
7. Поддержка `A[0]+B[1]+C[2]`, преобразуется в `A+ts_delay(B,1)+ts_delay(C,2)`
8. Поддержка `~A`, преобразуется в `Not(A)`
9. Функции с префиксом `gp_` возвращают соответствующие функции `cs_`. Например, `gp_func(A,B,C)` превращается в `cs_func(B,C)`, где `A` используется в `groupby([date, A])`
10. Поддержка распаковки кортежей `A,B,C=MACD()`, преобразуется в:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. В однострочных комментариях поддерживается ввод параметров, например: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. В код-блоках синтаксис `import`, `def`, `class` вставляется в сгенерированный код в исходном виде

## Переменные с подчеркиванием

1. В выводе все столбцы, начинающиеся с `_`, будут автоматически удалены. Поэтому переменные, которые нужно сохранить, не должны начинаться с `_`
2. Для сокращения повторных вычислений автоматически добавляются промежуточные переменные с префиксом `_x_`, например, `_x_0`, `_x_1` и т.д. Они также будут удалены в финале
3. Если выражение слишком длинное или содержит повторные вычисления, используйте промежуточные переменные, чтобы разбить выражение на несколько строк. Если промежуточная переменная начинается с `_`, автоматически добавляется числовой суффикс, например, `_A` станет `_A_0_`, `_A_1_` и т.д. Сценарии использования:
    1. Одно и то же имя переменной используется несколько раз — по сути разные переменные
    2. Циклическое присваивание, но в `DAG` циклов быть не может — по обе стороны от `=` фактически разные переменные

## Пример результата трансляции

Фрагмент сгенерированного кода, полный пример см. в [Polars-версии](examples/output_polars.py)

```python
def func_0_ts__asset(df: pl.DataFrame) -> pl.DataFrame:
    df = df.sort(by=[_DATE_])
    # ========================================
    df = df.with_columns(
        _x_0=1 / ts_delay(OPEN, -1),
        LABEL_CC_1=(-CLOSE + ts_delay(CLOSE, -1)) / CLOSE,
    )
    # ========================================
    df = df.with_columns(
        LABEL_OO_1=_x_0 * ts_delay(OPEN, -2) - 1,
        LABEL_OO_2=_x_0 * ts_delay(OPEN, -3) - 1,
    )
    return df
```

Фрагмент сгенерированного кода, полный пример см. в [Pandas-версии](examples/output_pandas.py)

```python
def func_2_cs__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_4 = cs_rank(x_7)
    df["expr_4"] = (df["x_7"]).rank(pct=True)
    return df


def func_3_ts__asset__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_5 = -ts_corr(OPEN, CLOSE, 10)
    df["expr_5"] = -(df["OPEN"]).rolling(10).corr(df["CLOSE"])
    # expr_6 = ts_delta(OPEN, 10)
    df["expr_6"] = df["OPEN"].diff(10)
    return df

```

## Локальное развертывание интерактивной веб-страницы

Достаточно выполнить команду `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---