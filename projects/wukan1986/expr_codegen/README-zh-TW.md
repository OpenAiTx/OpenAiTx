# expr_codegen 表達式轉譯器

## 項目背景

在本人新推出[polars_ta](https://github.com/wukan1986/polars_ta)這個庫後，再回頭反思`expr_codegen`是什麼。

> `expr_codegen`本質是`DSL`，領域特定語言（Domain Specific Language）。但它沒有定義新的語法

它解決了兩個問題：

1. `polars_ta`已經能很方便地寫出特徵計算表達式，但遇到`混用時序與截面`的表達式時，利用`expr_codegen`能自動分組，大大節省工作
2. `expr_codegen`利用了`Common Subexpression Elimination`公共子表達式消除，大量減少重複計算，提高效率

就算在量化領域，初級研究員侷限於時序指標，只用`polars_ta`即可，中高級研究員使用截面指標，推薦用`expr_codegen`

雖然現在此項目與`polars_ta`依賴非常緊密，但也是支持轉譯成其它庫，如`pandas / cudf.pandas`，只是目前缺乏一個比較簡易的庫

## 線上演示

https://exprcodegen.streamlit.app

初級用戶可以直接訪問此連結進行表達式轉譯，不需要另外安裝軟體。（此工具免費部署在國外，打開可能有些慢）

更完整範例請參考[alpha_examples](https://github.com/wukan1986/alpha_examples)

## 使用範例

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # 因子編輯區，可利用IDE的智能提示在此區域編輯因子
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # 模板中已經預設導入了 from polars_ta.prefix 下大量的算子，但
    # talib 在模板中沒有預設導入。這種寫法可實現在生成的代碼中導入
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # 還支持 def 和 class 的原樣導入
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. 底線開頭的變數只是中間變數，會被自動更名，最終輸出時會被剔除
    # 2. 底線開頭的變數可以重複使用。多個複雜因子多行書寫時有重複中間變時不再衝突
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. 底線開頭的變數有環循環賦值。在除錯時可快速用註解進行切換
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # 列印代碼
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # 儲存到檔案
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # 只執行，不儲存代碼

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # 儲存到字串
code.seek(0)
code.read()  # 讀取代碼

# TODO 替換成合適的資料
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## 目錄結構

```commandline
│  requirements.txt # 透過 `pip install -r requirements.txt` 安裝依賴
├─data
│      prepare_date.py # 準備資料
├─examples
│      demo_express.py # 速成範例。演示如何將表達式轉換成代碼
│      demo_exec_pl.py # 演示調用轉換後代碼並繪圖
│      demo_transformer.py # 演示將第三方表達式轉成內部表達式
│      output.py # 結果輸出。可不修改代碼，直接被其它項目導入
│      show_tree.py # 畫表達式樹形圖。可用於分析比較優化結果
│      sympy_define.py # 符號定義，由於太多地方重複使用到，所以統一提取到此處
├─expr_codegen
│   │  expr.py # 表達式處理基本函數
│   │  tool.py # 核心工具代碼
│   ├─polars
│   │  │  code.py # 針對 polars 語法的代碼生成
│   │  │  template.py.j2 # `Jinja2` 模板。用於生成對應 py 檔案，一般不需修改
│   │  │  printer.py # 繼承於 `Sympy` 中的 `StrPrinter`，添加新函數時可能需修改此檔案
```

## 工作原理

本項目依賴於 `sympy` 項目。所用到的主要函數如下：

1. `simplify`：對複雜表達式進行化簡
2. `cse`：`Common Subexpression Elimination` 公共子表達式消除
3. `StrPrinter`：根據不同的函數輸出不同字串。自訂此代碼可以支援其它語種或庫

因為 `groupby`、`sort` 都比較耗時。如果提前將公式分類，不同的類別使用不同的 `groupby`，可以減少計算時間。

1. `ts_xxx(ts_xxx)`：可在同一 `groupby` 中進行計算
2. `cs_xxx(cs_xxx)`：可在同一 `groupby` 中進行計算
3. `ts_xxx(cs_xxx)`：需在不同 `groupby` 中進行計算
4. `cs_xxx(ts_xxx(cs_xxx))`：需三不同 `groupby` 中進行計算
5. `gp_xxx(aa, )+gp_xxx(bb, )`：因 `aa`、`bb` 不同，需在兩不同 `groupby` 中進行計算

所以

1. 需要有一個函數能獲取當前表達式的類別（`get_current`）和子表達式的類別（`get_children`）
2. 如果當前類別與子類別不同就可以提取出短公式（`extract`）。不同層的同類別表達式有先後關係，不能放同一 `groupby`
3. 利用 `cse` 的特點，將長表達式替換成前期提取出來的短表達式。然後輸入到有向無環圖（`DAG`）
4. 利用有向無環圖的流轉，進行分層。同一層的 `ts`、`cs`、`gp` 不區分先後
5. 同一層對 `ts`、`cs`、`gp` 分組，然後生成代碼（`codegen`）即可

隱含資訊

1. `ts`：sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`：sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`：sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

即

1. 時序函數隱藏了兩個欄位 `ASSET, DATE`，橫截面函數隱藏了一個欄位 `DATE`
2. 分組函數轉入了一個欄位 `GROUP`，同時隱藏了一個欄位 `DATE`

兩種分類方法

1. 根據算子前綴分類（`get_current_by_prefix`），限制算子必須以 `ts_`、`cs_`、`gp_` 開頭
2. 根據算子全名分類（`get_current_by_name`），不再限制算子名。比如 `cs_rank` 可以叫 `rank`

## Null 處理

`null` 是如何產生的？

1. 停牌導致。在計算前就直接過濾掉了，不會對後續計算產生影響。
2. 不同品種交易時段不同
3. 計算產生。`null` 在數列兩端不影響後續時序算子結果，但中間出現 `null` 會影響。例如： `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

非常棒的點子，總結下來有兩種實現方式：

1. 將 `null` 分成一組，`not_null` 分成另一組。要調用兩次
2. 僅一組，但複合排序，將 `null` 排在前面，`not_null` 排後面。只調用一次，略快一些

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

第2種開頭的 `null` 區域，是否影響結果由算子所決定，特別是多列輸入時 `null` 區域可能有數據

1. `over_null='partition_by'`。分到兩個區域
2. `over_null='order_by'`。分到一個區域，`null` 排在前面
3. `over_null=None`。不處理，直接調用，速度更快。如果確認不會中段產生 `null` 建議使用此參數

`codegen_exec(over_null='partition_by')` 為全域使用 `partition_by`。但遇到 `ts_count_nulls` 這類 `null`
函數就得使用 `over_null=None`，所以本工具還新添了註解功能來指定單行表達式參數

1. `# --over_null partition_by`。單行 `over_null='partition_by'`
2. `# --over_null=order_by`。單行 `over_null='order_by'`
3. `# --over_null`。單行 `over_null=None`
4. `# `。取 `codegen_exec` 參數傳入的 `over_null` 值

注意：

1. `# --over_null` 傳參註解只能寫在單行表達式的後面，不能獨立成一行，否則會被忽略
2. `# --over_null # --over_null=order_by` 多個 `#` 時，只取第一個有效
3. 只對最外層 `ts` 函數有效。如果 `ts` 函數不在外層，需要人工提煉。例如：
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # 應用在 cs_rank 上，沒有意義
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # 本以為應用在 ts_rank(ts_mean) 上，但由於出現了公共 ts_mean，其實是應用在 ts_rank(_x_0) 上
   ```

   需寫成

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. 由於很容易搞錯，強烈建議生成 `output_file`，檢查生成的代碼是否正確。

## `expr_codegen` 局限性

1. `DAG` 只能增加欄位無法刪除。增加欄位時，遇到同名欄位會覆蓋
2. 不支援 `刪除列`，但可以新增刪除標記欄位，然後在外部進行刪除列。刪除列會影響所有欄位，不符合 `DAG`
3. 不支援 `重採樣`，原理同不支援刪除列。需在外部進行
4. 可以將 `刪除列` 與 `重採樣` 作為分割線，一大段代碼分成多個 `DAG` 串接。複雜不易理解，所以最終沒有實現

## 特別語法

1. 支援 `C?T:F` 三元表達式（僅可字串中使用），底層會先轉成 `C or True if( T )else F`，然後修正成 `T if C else F`
   ，最後轉成 `if_else(C,T,F)`。支援與 `if else` 混用
2. `(A<B)*-1`，底層將轉換成 `int_(A<B)*-1`
3. 為防止 `A==B` 被 `sympy` 替換成 `False`，底層會換成 `Eq(A,B)`
4. `A^B` 的含義與 `convert_xor` 參數有關，`convert_xor=True` 底層會轉換成 `Pow(A,B)`，反之為 `Xor(A,B)`。預設為 `False`，用 `**` 表示乘方
5. 支援 `A&B&C`，但不支援 `A==B==C`。如果 C 是布林值，AB 是數值，可手動替換成 `(A==B)==C`。如果 ABC 是數值需手動替換成 `(A==B)&(B==C)`
6. 不支援 `A<=B<=C`，需手動替換成 `(A<=B)&(B<=C)`
7. 支援 `A[0]+B[1]+C[2]`，底層會轉成 `A+ts_delay(B,1)+ts_delay(C,2)`
8. 支援 `~A`，底層會轉換成 `Not(A)`
9. `gp_` 開頭的函數都會返回對應的 `cs_` 函數。如 `gp_func(A,B,C)` 會替換成 `cs_func(B,C)`，其中 `A` 用在了 `groupby([date, A])`
10. 支援 `A,B,C=MACD()` 元組解包，在底層會替換成
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. 單行註解支援參數輸入，如：`# --over_null`、`# --over_null=order_by`、`# --over_null=partition_by`
12. 代碼區塊中，對 `import`、`def`、`class` 三種語法，自動原樣插入到生成的代碼中

## 底線開頭的變數

1. 輸出的資料，所有以 `_` 開頭的欄位，最後會被自動刪除。所以需要保留的變數一定不要以 `_` 開頭
2. 為減少重複計算，自動添加了中間變數，以 `_x_` 開頭，如 `_x_0`、`_x_1` 等。最後會被自動刪除
3. 單行表達式過長，或有重複計算，可以通過中間變數，將單行表達式改成多行。如果中間變數使用 `_`
   開頭，將會自動添加數字後綴，形成不同的變數，如 `_A` 會替換成 `_A_0_`、`_A_1_` 等。使用場景如下：
    1. 同一變數名，重複使用。本質是不同的變數
    2. 循環賦值，但 `DAG` 不支援有環。`=` 號左右的同名變數其實是不同變數

## 轉譯結果範例

轉譯後的代碼片段，詳細代碼請參考 [Polars 版](examples/output_polars.py)

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

轉譯後的代碼片段，詳細代碼請參考 [Pandas 版](examples/output_pandas.py)

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

## 本地部署互動網頁

只需執行 `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---