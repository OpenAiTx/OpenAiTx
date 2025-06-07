# expr_codegen 式変換エンジン

## プロジェクト背景

私が新たにリリースした[polars_ta](https://github.com/wukan1986/polars_ta)というライブラリの後で、改めて`expr_codegen`とは何かを考えました。

> `expr_codegen`の本質は`DSL`（ドメイン特化言語: Domain Specific Language）ですが、新しい構文は定義していません。

このツールは2つの問題を解決します:

1. `polars_ta`で特徴量計算式を書くのは非常に簡単ですが、`時系列とクロスセクションの混用`式に出会うとき、`expr_codegen`を使えば自動グルーピングにより作業量を大幅に削減できます。
2. `expr_codegen`は`Common Subexpression Elimination`（共通部分式削除）を利用し、重複計算を大幅に減らして効率を向上させます。

量的トレーディング分野では、初級研究者が時系列指標しか使わない場合は`polars_ta`だけで十分です。中上級研究者がクロスセクション指標を使う場合は`expr_codegen`の利用を推奨します。

現在このプロジェクトは`polars_ta`と密接に依存していますが、他のライブラリ（例: `pandas` / `cudf.pandas`）への変換もサポート可能です。ただし現時点では簡易なライブラリが不足しています。

## オンラインデモ

https://exprcodegen.streamlit.app

初級ユーザーはこのリンクから直接式変換を体験できます。別途ソフトウェアのインストールは不要です（このツールは海外で無料デプロイしているため、開くのが少し遅い場合があります）。

より完全なサンプルは[alpha_examples](https://github.com/wukan1986/alpha_examples)をご覧ください。

## 使用例

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # ファクター編集エリア。IDEの補完機能を利用してここでファクターを編集できます
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # テンプレートではすでにfrom polars_ta.prefix以下の多くの演算子がインポートされていますが、
    # talibはテンプレートにデフォルトでインポートされていません。このような書き方で生成されるコードにインポートできます
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # また、defやclassのそのままのインポートもサポートしています
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. アンダースコアで始まる変数は中間変数で、自動的にリネームされ最終出力時に削除されます
    # 2. アンダースコアで始まる変数は再利用できます。複数の複雑なファクターを複数行で書くときに中間変数の重複が衝突しなくなります
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. アンダースコアで始まる変数は循環代入が可能です。デバッグ時にコメントアウトで素早く切り替えられます
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # コードを出力
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # ファイル保存
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # 実行のみ、コード保存なし

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # 文字列保存
code.seek(0)
code.read()  # コードを読む

# TODO 適切なデータに置き換える
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## ディレクトリ構成

```commandline
│  requirements.txt # `pip install -r requirements.txt`で依存関係をインストール
├─data
│      prepare_date.py # データ準備
├─examples
│      demo_express.py # クイックサンプル。式をコードに変換する方法をデモ
│      demo_exec_pl.py # 変換後のコードを呼び出して描画するデモ
│      demo_transformer.py # サードパーティ式を内部式に変換するデモ
│      output.py # 結果出力。他プロジェクトに直接インポートできる
│      show_tree.py # 式ツリー図を描画。最適化結果の分析比較用
│      sympy_define.py # シンボル定義。多用されるのでここにまとめて抽出
├─expr_codegen
│   │  expr.py # 式処理の基本関数
│   │  tool.py # コアツールコード
│   ├─polars
│   │  │  code.py # polars構文用のコード生成
│   │  │  template.py.j2 # `Jinja2`テンプレート。pyファイル生成用。通常修正不要
│   │  │  printer.py # `Sympy`の`StrPrinter`継承。新関数追加時はこのファイルを修正する場合あり
```

## 動作原理

本プロジェクトは`sympy`に依存しています。主に使われる関数は以下の通り：

1. `simplify`: 複雑な式を簡略化する
2. `cse`: `Common Subexpression Elimination`（共通部分式の削除）
3. `StrPrinter`: 関数ごとに異なる文字列を出力。このコードをカスタマイズすることで他言語や他ライブラリにも対応可能

`groupby`や`sort`は時間がかかるため、事前に式を分類し、異なるカテゴリには異なる`groupby`を使うことで計算時間を短縮できます。

1. `ts_xxx(ts_xxx)`: 同じ`groupby`で計算可能
2. `cs_xxx(cs_xxx)`: 同じ`groupby`で計算可能
3. `ts_xxx(cs_xxx)`: 異なる`groupby`で計算が必要
4. `cs_xxx(ts_xxx(cs_xxx))`: 3つの異なる`groupby`で計算が必要
5. `gp_xxx(aa, )+gp_xxx(bb, )`: `aa`と`bb`が異なるため、2つの異なる`groupby`で計算が必要

したがって、

1. 現在の式のカテゴリ（`get_current`）とサブ式のカテゴリ（`get_children`）を取得する関数が必要
2. 現在のカテゴリと子カテゴリが異なれば、短い式（`extract`）として抽出可能。同階層の同カテゴリ式には順序があり、同じ`groupby`にはできない
3. `cse`の特性を利用し、長い式を前段で抽出した短い式で置換。その後、有向非巡回グラフ（`DAG`）に入力
4. 有向非巡回グラフによる層分けを実施。同じ階層の`ts`,`cs`,`gp`間の順序は区別しない
5. 同じ階層で`ts`,`cs`,`gp`ごとにグループ化し、コード生成（`codegen`）を実行

暗黙の情報

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

つまり

1. 時系列関数は隠しフィールド`ASSET, DATE`を持ち、横断関数は`DATE`を隠し持つ
2. グループ関数は`GROUP`を渡しつつ、`DATE`を隠し持つ

2種類の分類方法

1. 演算子プレフィックスによる分類（`get_current_by_prefix`）。演算子が必ず`ts_`、`cs_`、`gp_`で始まることを要求
2. 演算子の完全名による分類（`get_current_by_name`）。演算子名の制限をなくす。例：`cs_rank`を`rank`とも呼べる

## Null処理

`null`はどのように発生するか？

1. 取引停止による。計算前にフィルタリングされるので以降に影響しない
2. 銘柄ごとに取引時間帯が異なる場合
3. 計算由来。`null`が数列の両端なら時系列演算子の結果に影響しないが、中間に現れると影響する。例: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

素晴らしいアイデアで、実装方法は2通りまとめられます：

1. `null`を一つのグループ、`not_null`を別グループに分けて2回計算
2. 1グループだが複合ソートで、`null`を前、`not_null`を後ろに並べて1回だけ計算（少し高速）

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

2つ目の方式の`null`領域が冒頭に出る場合、演算子によって結果への影響が決まります。特に複数列入力時には`null`領域にもデータが入ることがあります。

1. `over_null='partition_by'`：2つの領域に分割
2. `over_null='order_by'`：1つの領域で、`null`が前に並ぶ
3. `over_null=None`：何も処理せず直接呼び出す。より高速。途中で`null`が発生しないと確信できる場合はこのパラメータを推奨

`codegen_exec(over_null='partition_by')`でグローバルに`partition_by`を使用。ただし`ts_count_nulls`のような`null`
関数では`over_null=None`が必要なので、単一行式のパラメータをコメントで指定する機能を追加しています。

1. `# --over_null partition_by`：1行だけ`over_null='partition_by'`
2. `# --over_null=order_by`：1行だけ`over_null='order_by'`
3. `# --over_null`：1行だけ`over_null=None`
4. `# `：`codegen_exec`で渡した`over_null`値を利用

注意事項：

1. `# --over_null`のコメントは式の行末のみ有効で、単独行では無視されます
2. `# --over_null # --over_null=order_by`のように複数`#`がある場合は最初の有効なもののみ採用
3. 最外層の`ts`関数のみに有効。`ts`が最外層でない場合は手動で分離が必要。例：
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # cs_rankに適用されるが意味なし
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # ts_rank(ts_mean)に適用されると思いきや、共通ts_meanが出現したため実際はts_rank(_x_0)に適用される
   ```

   このように書き換える必要あり

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. ミスしやすいため、`output_file`を生成し、生成されたコードが正しいか必ず確認してください。

## `expr_codegen`の制限事項

1. `DAG`は列の追加のみサポートし、削除は不可。同名列は上書きされます
2. 行削除は非対応。ただし削除フラグ列の追加は可能。行削除は全列に影響するため`DAG`に適さない
3. リサンプリング非対応。理由は行削除と同様。外部で処理してください
4. 行削除やリサンプリングを分割線とし、コードを複数の`DAG`に分割して連結することは可能ですが、複雑で理解しづらいため未実装

## 特殊構文

1. `C?T:F`の三項演算子をサポート（文字列内のみ）。内部的には`C or True if( T )else F`に変換、さらに`T if C else F`、最終的には`if_else(C,T,F)`に変換。`if else`との混在も可能
2. `(A<B)*-1`は内部的に`int_(A<B)*-1`に変換
3. `A==B`が`sympy`で`False`に置換されるのを防ぐため、内部的に`Eq(A,B)`に変換
4. `A^B`の意味は`convert_xor`パラメータに依存し、`convert_xor=True`なら`Pow(A,B)`、そうでなければ`Xor(A,B)`に変換。デフォルトは`False`で、べき乗は`**`を使用
5. `A&B&C`はサポート。ただし`A==B==C`はサポートしない。Cがブール、A/Bが数値なら`(A==B)==C`に手動変換。A/B/Cが数値なら`(A==B)&(B==C)`に手動変換
6. `A<=B<=C`はサポートせず、手動で`(A<=B)&(B<=C)`に変換
7. `A[0]+B[1]+C[2]`をサポート。内部的に`A+ts_delay(B,1)+ts_delay(C,2)`に変換
8. `~A`は内部的に`Not(A)`に変換
9. `gp_`で始まる関数は対応する`cs_`関数を返します。例: `gp_func(A,B,C)`は`cs_func(B,C)`に置換。`A`は`groupby([date, A])`で使用
10. `A,B,C=MACD()`のタプルアンパックをサポート。内部的に
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
   に変換
11. 行末コメントによるパラメータ入力をサポート：`# --over_null`、`# --over_null=order_by`、`# --over_null=partition_by`
12. コードブロック内で`import`、`def`、`class`の3つの構文は生成されるコードに自動でそのまま挿入される

## アンダースコアで始まる変数

1. 出力データでは、アンダースコアで始まる全列は最後に自動削除されます。必要な変数名にはアンダースコアを使わないでください
2. 重複計算を減らすために自動的に中間変数（`_x_0`、`_x_1`など）が追加され、これも自動で削除されます
3. 1行式が長い場合や重複計算がある場合は、中間変数を利用して1行式を複数行に分けられます。中間変数がアンダースコアで始まる場合、末尾に数字サフィックスを自動追加し、異なる変数にします。例：
    1. 同じ変数名を複数回使用（実質的には異なる変数）
    2. 循環代入。ただし`DAG`はループ不可。`=`の左右で同名変数でも実質的には異なる変数

## 変換結果例

変換後コードの一部。詳細コードは[Polars版](examples/output_polars.py)を参照してください。

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

変換後コードの一部。詳細コードは[Pandas版](examples/output_pandas.py)を参照してください。

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

## ローカルデプロイによるインタラクティブWebページ

`streamlit run streamlit_app.py`を実行するだけです。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---