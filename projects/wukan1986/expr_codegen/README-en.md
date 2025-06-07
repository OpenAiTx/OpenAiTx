# expr_codegen Expression Translator

## Project Background

After launching my new library [polars_ta](https://github.com/wukan1986/polars_ta), I reflected on what `expr_codegen` is.

> `expr_codegen` is essentially a `DSL` (Domain Specific Language). But it does not define new syntax.

It solves two problems:

1. `polars_ta` already allows for convenient writing of feature calculation expressions, but when dealing with expressions that mix time-series and cross-sectional operations, `expr_codegen` can automatically group them, greatly saving work.
2. `expr_codegen` utilizes Common Subexpression Elimination (`CSE`), which significantly reduces redundant computations and improves efficiency.

Even in the quantitative domain, junior researchers limited to time-series indicators can use only `polars_ta`, while intermediate and advanced researchers using cross-sectional indicators are recommended to use `expr_codegen`.

Although this project currently relies heavily on `polars_ta`, it also supports translation to other libraries, such as `pandas` or `cudf.pandas`. However, there is currently a lack of a relatively simple library.

## Online Demo

https://exprcodegen.streamlit.app

Beginner users can visit this link directly for expression translation without installing additional software. (This tool is freely deployed overseas, so it may open slowly.)

For more complete examples, visit [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Usage Example

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Factor editing area. You can use IDE autocomplete to edit factors here.
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # The template has already imported a large number of operators from polars_ta.prefix by default, but
    # talib is not imported by default in the template. This usage allows importing in the generated code.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # It also supports direct import of def and class statements.
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Variables starting with an underscore are intermediate variables, which will be automatically renamed and removed in the final output.
    # 2. Variables starting with an underscore can be reused. When writing multiple complex factors in multiple lines, repeated intermediate variables will no longer conflict.
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Variables starting with an underscore have cyclic assignments. When debugging, you can quickly switch using comments.
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Print code
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Save to file
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Only execute, do not save code

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Save to string
code.seek(0)
code.read()  # Read code

# TODO Replace with appropriate data
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Directory Structure

```commandline
│  requirements.txt # Install dependencies via `pip install -r requirements.txt`
├─data
│      prepare_date.py # Data preparation
├─examples
│      demo_express.py # Quick start example. Demonstrates how to convert expressions to code
│      demo_exec_pl.py # Demonstrates calling converted code and plotting
│      demo_transformer.py # Demonstrates converting third-party expressions to internal expressions
│      output.py # Output results. Can be imported directly by other projects without code modification
│      show_tree.py # Draw expression tree diagrams. Useful for analyzing and comparing optimization results
│      sympy_define.py # Symbol definitions, extracted here due to frequent reuse
├─expr_codegen
│   │  expr.py # Basic expression processing functions
│   │  tool.py # Core utility code
│   ├─polars
│   │  │  code.py # Code generation functionality for polars syntax
│   │  │  template.py.j2 # `Jinja2` template. Used to generate the corresponding py file, usually does not require modification
│   │  │  printer.py # Inherits from `StrPrinter` in `Sympy`, may need modification when adding new functions
```

## Working Principle

This project depends on the `sympy` project. The main functions used are as follows:

1. `simplify`: Simplifies complex expressions
2. `cse`: Common Subexpression Elimination
3. `StrPrinter`: Outputs different strings based on different functions. Customizing this code can support other languages or libraries.

Because `groupby` and `sort` are relatively time-consuming, if formulas are classified in advance and different categories use different `groupby`, computation time can be reduced.

1. `ts_xxx(ts_xxx)`: Can be computed in the same `groupby`
2. `cs_xxx(cs_xxx)`: Can be computed in the same `groupby`
3. `ts_xxx(cs_xxx)`: Must be computed in different `groupby`
4. `cs_xxx(ts_xxx(cs_xxx))`: Must be computed in three different `groupby`
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Because `aa` and `bb` are different, they need to be computed in two different `groupby`

Therefore,

1. There needs to be a function to get the current expression's category (`get_current`) and the subexpression's category (`get_children`)
2. If the current category is different from the sub-category, a short formula can be extracted (`extract`). Expressions of the same category at different levels have an order and cannot be placed in the same `groupby`
3. Using the characteristics of `cse`, long expressions are replaced with previously extracted short expressions, and then input into a Directed Acyclic Graph (`DAG`)
4. Use the flow of the Directed Acyclic Graph for layering. Within the same layer, `ts`, `cs`, and `gp` do not distinguish order
5. Group `ts`, `cs`, and `gp` within the same layer, and then generate code (`codegen`)

Implicit information

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

That is,

1. Time-series functions implicitly hide two fields: `ASSET, DATE`; cross-sectional functions hide one field: `DATE`
2. Group functions add a field `GROUP`, and simultaneously hide one field `DATE`

Two classification methods

1. Classification by operator prefix (`get_current_by_prefix`), requiring operators to start with `ts_`, `cs_`, or `gp_`
2. Classification by operator full name (`get_current_by_name`), no longer restricting operator names. For example, `cs_rank` can be called `rank`

## Null Handling

How is `null` generated?

1. Suspension of trading. Filtered out before calculation, does not affect subsequent calculations.
2. Different instruments have different trading sessions
3. Generated by calculation. `null` at the ends of a series does not affect subsequent time-series operations, but `null` in the middle will. For example: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

A great idea. There are two ways to implement:

1. Group `null` values separately, and `not_null` values as another group. Needs to be called twice.
2. Only one group, but use composite sorting, placing `null` at the front and `not_null` at the back. Needs to be called only once, slightly faster.

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

In the second method, whether the leading `null` region affects the result depends on the operator, especially when there is data in the `null` region with multi-column input.

1. `over_null='partition_by'`: Split into two regions
2. `over_null='order_by'`: Split into one region, `null` in front
3. `over_null=None`: No processing, call directly, faster. If you are sure that there will be no `null` generated in the middle, it is recommended to use this parameter.

`codegen_exec(over_null='partition_by')` uses `partition_by` globally. However, when encountering functions like `ts_count_nulls`, you need to use `over_null=None`. Therefore, this tool also adds a comment feature to specify single-line expression parameters.

1. `# --over_null partition_by`: Single-line `over_null='partition_by'`
2. `# --over_null=order_by`: Single-line `over_null='order_by'`
3. `# --over_null`: Single-line `over_null=None`
4. `# `: Uses the value of `over_null` passed into `codegen_exec`

Note:

1. The `# --over_null` comment parameter must be written at the end of the single-line expression, not on a separate line, otherwise it will be ignored
2. If there are multiple `# --over_null # --over_null=order_by` comments, only the first valid one is used
3. This is only effective for the outermost `ts` function. If the `ts` function is not outermost, manual extraction is needed. For example:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Applied to cs_rank, which is meaningless
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Intended for ts_rank(ts_mean), but due to common ts_mean, it is actually applied to ts_rank(_x_0)
   ```

   Should be written as

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Since it is easy to make mistakes, it is strongly recommended to generate the `output_file` and check whether the generated code is correct.

## Limitations of `expr_codegen`

1. The `DAG` can only add columns, not delete them. When adding columns, columns with the same name will be overwritten.
2. Deleting rows is not supported, but you can add a deletion marker column and delete rows externally. Deleting rows affects all columns, which is not consistent with the `DAG`.
3. Resampling is not supported for the same reason as row deletion. Needs to be done externally.
4. Row deletion and resampling can serve as a dividing line, splitting a large block of code into multiple linked `DAG`s. This is complex and hard to understand, so it was ultimately not implemented.

## Special Syntax

1. Supports `C?T:F` ternary expressions (only usable in strings). Internally, it is first converted to `C or True if( T )else F`, then corrected to `T if C else F`, and finally converted to `if_else(C,T,F)`. It can be used together with `if else`.
2. `(A<B)*-1` is converted internally to `int_(A<B)*-1`
3. To prevent `A==B` from being replaced by `False` in `sympy`, it is internally replaced with `Eq(A,B)`
4. The meaning of `A^B` depends on the `convert_xor` parameter. If `convert_xor=True`, it is converted to `Pow(A,B)`, otherwise to `Xor(A,B)`. Default is `False`; use `**` for exponentiation
5. Supports `A&B&C`, but does not support `A==B==C`. If C is boolean and AB are numeric, you can manually replace with `(A==B)==C`. If ABC are numeric, replace with `(A==B)&(B==C)`
6. Does not support `A<=B<=C`; manually replace with `(A<=B)&(B<=C)`
7. Supports `A[0]+B[1]+C[2]`, which is internally converted to `A+ts_delay(B,1)+ts_delay(C,2)`
8. Supports `~A`, internally converted to `Not(A)`
9. Functions starting with `gp_` will return the corresponding `cs_` function. For example, `gp_func(A,B,C)` will be replaced with `cs_func(B,C)`, where `A` is used in `groupby([date, A])`
10. Supports tuple unpacking like `A,B,C=MACD()`, which is internally replaced by:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Single-line comments support parameter input, such as: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. In code blocks, `import`, `def`, and `class` statements are automatically inserted as-is into the generated code.

## Variables Starting with Underscore

1. In the output data, all columns starting with `_` will be automatically deleted at the end. Therefore, variables that need to be retained must not start with `_`.
2. To reduce repeated computation, intermediate variables starting with `_x_` (such as `_x_0`, `_x_1`, etc.) are automatically added and will be deleted in the end.
3. If a single-line expression is too long or contains repeated computations, you can use intermediate variables to split it into multiple lines. If intermediate variables start with `_`, a numeric suffix will be automatically added to form different variables, such as `_A` being replaced by `_A_0_`, `_A_1_`, etc. Usage scenarios:
    1. The same variable name is reused, but they are essentially different variables.
    2. Cyclic assignment, but `DAG` does not support cycles. Variables with the same name on both sides of the `=` are actually different variables.

## Translation Result Example

Code snippet after translation. For detailed code, refer to the [Polars version](examples/output_polars.py)

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

Code snippet after translation. For detailed code, refer to the [Pandas version](examples/output_pandas.py)

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

## Local Deployment Interactive Web Page

Simply run `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---