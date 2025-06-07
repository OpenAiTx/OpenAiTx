# expr_codegen 表达式转译器

## 项目背景

在我新推出的 [polars_ta](https://github.com/wukan1986/polars_ta) 这个库之后，再回头反思 `expr_codegen` 是什么。

> `expr_codegen` 本质上是 `DSL`，领域特定语言（Domain Specific Language）。但它没有定义新的语法

它解决了两个问题：

1. `polars_ta` 已经能很方便地写出特征计算表达式，但遇到“混用时序与截面”的表达式时，利用 `expr_codegen` 能自动分组，大大节省工作量
2. `expr_codegen` 利用了 `Common Subexpression Elimination` 公共子表达式消除，大量减少重复计算，提高效率

即使在量化领域，初级研究员局限于时序指标，仅用 `polars_ta` 即可；中高级研究员使用截面指标，推荐用 `expr_codegen`。

虽然现在此项目与 `polars_ta` 依赖非常紧密，但也支持翻译成其他库，如 `pandas / cudf.pandas`，只是目前缺乏一个比较简易的库。

## 在线演示

https://exprcodegen.streamlit.app

初级用户可以直接访问此链接进行表达式转译，无需另外安装软件。（此工具免费部署在国外，打开可能稍慢）

更完整示例请访问 [alpha_examples](https://github.com/wukan1986/alpha_examples)

## 使用示例

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # 因子编辑区，可利用IDE的智能提示在此区域编辑因子
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # 模板中已经默认导入了from polars_ta.prefix下大量的算子，但
    # talib在模板中没有默认导入。这种写法可实现在生成的代码中导入
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # 还支持def和class的原样导入
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. 下划线开头的变量只是中间变量,会被自动更名，最终输出时会被剔除
    # 2. 下划线开头的变量可以重复使用。多个复杂因子多行书写时有重复中间变时不再冲突
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. 下划线开头的变量有环循环赋值。在调试时可快速用注释进行切换
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # 打印代码
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # 保存到文件
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # 只执行，不保存代码

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # 保存到字符串
code.seek(0)
code.read()  # 读取代码

# TODO 替换成合适的数据
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## 目录结构

```commandline
│  requirements.txt # 通过`pip install -r requirements.txt`安装依赖
├─data
│      prepare_date.py # 准备数据
├─examples
│      demo_express.py # 速成示例。演示如何将表达式转换成代码
│      demo_exec_pl.py # 演示调用转换后代码并绘图
│      demo_transformer.py # 演示将第三方表达式转成内部表达式
│      output.py # 结果输出。可不修改代码，直接被其它项目导入
│      show_tree.py # 画表达式树形图。可用于分析对比优化结果
│      sympy_define.py # 符号定义，由于太多地方重复使用到，所以统一提取到此处
├─expr_codegen
│   │  expr.py # 表达式处理基本函数
│   │  tool.py # 核心工具代码
│   ├─polars
│   │  │  code.py # 针对polars语法的代码生成功能
│   │  │  template.py.j2 # `Jinja2`模板。用于生成对应py文件，一般不需修改
│   │  │  printer.py # 继承于`Sympy`中的`StrPrinter`，添加新函数时可能需修改此文件
```

## 工作原理

本项目依赖于 `sympy` 项目。所用到的主要函数如下：

1. `simplify`：对复杂表达式进行化简
2. `cse`：`Common Subexpression Elimination` 公共子表达式消除
3. `StrPrinter`：根据不同的函数输出不同字符串。定制此代码可以支持其他语种或库

因为 `groupby`、`sort` 都比较耗时。如果提前将公式分类，不同的类别使用不同的 `groupby`，可以减少计算时间。

1. `ts_xxx(ts_xxx)`：可在同一 `groupby` 中进行计算
2. `cs_xxx(cs_xxx)`：可在同一 `groupby` 中进行计算
3. `ts_xxx(cs_xxx)`：需在不同 `groupby` 中进行计算
4. `cs_xxx(ts_xxx(cs_xxx))`：需在三不同 `groupby` 中进行计算
5. `gp_xxx(aa, )+gp_xxx(bb, )`：因 `aa`、`bb` 不同，需在两个不同 `groupby` 中进行计算

所以

1. 需要有一个函数能获取当前表达式的类别（`get_current`）和子表达式的类别（`get_children`）
2. 如果当前类别与子类别不同，就可以提取出短公式（`extract`）。不同层的同类别表达式有先后关系，不能放在同一个 `groupby`
3. 利用 `cse` 的特点，将长表达式替换成前期提取出来的短表达式。然后输入到有向无环图（`DAG`）
4. 利用有向无环图的流转，进行分层。同一层的 `ts`、`cs`、`gp` 不区分先后
5. 同一层对 `ts`、`cs`、`gp` 分组，然后生成代码（`codegen`）即可

隐含信息

1. `ts`：sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`：sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`：sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

即

1. 时序函数隐藏了两个字段 `ASSET, DATE`，横截面函数隐藏了一个字段 `DATE`
2. 分组函数转入了一个字段 `GROUP`，同时隐藏了一个字段 `DATE`

两种分类方法

1. 根据算子前缀分类（`get_current_by_prefix`），限制算子必须以 `ts_`、`cs_`、`gp_` 开头
2. 根据算子全名分类（`get_current_by_name`），不再限制算子名。比如 `cs_rank` 可以叫 `rank`

## Null 处理

`null` 是如何产生的？

1. 停牌导致。在计算前就直接过滤掉了，不会对后续计算产生影响。
2. 不同品种交易时段不同
3. 计算产生。`null` 在数列两端不影响后续时序算子结果，但中间出现 `null` 会影响。例如： `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

非常棒的点子，总结下来有两种实现方式：

1. 将 `null` 分成一组，`not_null` 分成另一组。要调用两次
2. 仅一组，但复合排序，将 `null` 排在前面，`not_null` 排后面。只调用一次，略快一些

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

第2种开头的 `null` 区域，是否影响结果由算子所决定，特别是多列输入时 `null` 区域可能有数据

1. `over_null='partition_by'`。分到两个区域
2. `over_null='order_by'`。分到一个区域，`null` 排在前面
3. `over_null=None`。不处理，直接调用，速度更快。如果确信不会中段产生 `null` 建议使用此参数

`codegen_exec(over_null='partition_by')` 为全局使用 `partition_by`。但遇到 `ts_count_nulls` 这类 `null`
函数就得使用 `over_null=None`，所以本工具还新添了注释功能来指定单行表达式参数

1. `# --over_null partition_by`。单行 `over_null='partition_by'`
2. `# --over_null=order_by`。单行 `over_null='order_by'`
3. `# --over_null`。单行 `over_null=None`
4. `# `。取 `codegen_exec` 参数传入的 `over_null` 值

注意：

1. `# --over_null` 传参注释只能写在单行表达式的后面，不能独立成一行，否则会被忽略
2. `# --over_null # --over_null=order_by` 多个 `#` 时，只取第一个有效
3. 只对最外层 `ts` 函数有效。如果 `ts` 函数不在外层，需要人工提炼。例如：
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # 应用在cs_rank上，没有意义
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # 本以为应用在ts_rank(ts_mean)上，但由于出现了公共ts_mean，其实是应用在ts_rank(_x_0)上
   ```

   需写成

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. 由于很容易搞错，强烈建议生成 `output_file`，检查生成的代码是否正确。

## `expr_codegen` 局限性

1. `DAG` 只能增加列无法删除。增加列时，遇到同名列会覆盖
2. 不支持“删除行”，但可以添加删除标记列，然后在外部进行删除行。删除行影响了所有列，不满足 `DAG`
3. 不支持“重采样”，原理同不支持删除行。需在外部进行
4. 可以将“删除行”与“重采样”作为分割线，一大块代码分成多个 `DAG` 串联。复杂且不易理解，所以最终没有实现

## 特别语法

1. 支持 `C?T:F` 三元表达式（仅可字符串中使用），底层会先转成 `C or True if( T )else F`，然后修正成 `T if C else F`
   ，最后转成 `if_else(C,T,F)`。支持与 `if else` 混用
2. `(A<B)*-1`，底层将转换成 `int_(A<B)*-1`
3. 为防止 `A==B` 被 `sympy` 替换成 `False`，底层会换成 `Eq(A,B)`
4. `A^B` 的含义与 `convert_xor` 参数有关，`convert_xor=True` 底层会转换成 `Pow(A,B)`，反之为 `Xor(A,B)`。默认为 `False`，用 `**` 表示乘方
5. 支持 `A&B&C`，但不支持 `A==B==C`。如果 C 是布尔，AB 是数值，可手工替换成 `(A==B)==C`。如果 ABC 是数值需手工替换成 `(A==B)&(B==C)`
6. 不支持 `A<=B<=C`，需手工替换成 `(A<=B)&(B<=C)`
7. 支持 `A[0]+B[1]+C[2]`，底层会转成 `A+ts_delay(B,1)+ts_delay(C,2)`
8. 支持 `~A`，底层会转换成 `Not(A)`
9. `gp_` 开头的函数都会返回对应的 `cs_` 函数。如 `gp_func(A,B,C)` 会替换成 `cs_func(B,C)`，其中 `A` 用在了 `groupby([date, A])`
10. 支持 `A,B,C=MACD()` 元组解包，在底层会替换成
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. 单行注释支持参数输入，如：`# --over_null`、`# --over_null=order_by`、`# --over_null=partition_by`
12. 代码块中，对 `import`、`def`、`class` 三种语法，自动原样插入到生成的代码中

## 下划线开头的变量

1. 输出的数据，所有以 `_` 开头的列，最后会被自动删除。所以需要保留的变量一定不要以 `_` 开头
2. 为减少重复计算，自动添加了中间变量，以 `_x_` 开头，如 `_x_0`，`_x_1` 等。最后会被自动删除
3. 单行表达式过长，或有重复计算，可以通过中间变量，将单行表达式改成多行。如果中间变量使用 `_`
   开头，将会自动添加数字后缀，形成不同的变量，如 `_A` 会替换成 `_A_0_`、`_A_1_` 等。使用场景如下：
    1. 同一变量名，重复使用。本质是不同的变量
    2. 循环赋值，但 `DAG` 不支持有环。`=` 号左右的同名变量其实是不同变量

## 转译结果示例

转译后的代码片段，详细代码请参考 [Polars版](examples/output_polars.py)

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

转译后的代码片段，详细代码请参考 [Pandas版](examples/output_pandas.py)

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

## 本地部署交互网页

只需运行 `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---