<h1 align="center">
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/validoopsie-text.png>
    <p style="font-size: 16px; font-weight: bold;">Python向けのシンプルで使いやすいデータ検証ライブラリ。</p>
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/logo.png>
</h1>

<p align="center">
  <a href="https://badge.fury.io/py/Validoopsie">
    <img src="https://badge.fury.io/py/Validoopsie.svg" alt="PyPI version" />
  </a>
  <a href="https://pepy.tech/projects/validoopsie">
    <img src="https://static.pepy.tech/badge/validoopsie" alt="PyPI Downloads">
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml/badge.svg" alt="Tests and Linters" />
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml/badge.svg" alt="Documentation" />
  </a>
</p>

# Validoopsie

Validoopsieは非常に軽量でユーザーフレンドリーなPython向けのデータ検証
ライブラリです。クラスを簡単に宣言し、人気のあるDataFrameライブラリを
思わせるスタイルで検証を連結できるよう設計されています。これにより、
データフレームを頻繁に扱う開発者にとって馴染みやすく直感的なツールに
なっています。

[Narwhals](https://github.com/narwhals-dev/narwhals)の優れた成果により、
Validoopsieは「Bring Your Own DataFrame」（BYOD）コンセプトを取り入れて
います。この柔軟性により、Narwhalsがサポートする任意のDataFrameを
データ検証作業に使用できます。対応するDataFrameの全リストは
[こちら](https://narwhals-dev.github.io/narwhals/extending/)からご覧いただけます。

Validoopsieの構文は使いやすさを考慮して巧みに設計されています。
すべての検証関数は独自のメソッドにカプセル化されており、スムーズに
連結可能です。このメソッド単位の設計はシンプルさと読みやすさを
優先しており、新しいAPIに適応する必要を解放します。

ライブラリを切り替えます。これにより、クリーンで理解しやすいコードの維持に集中できます。

Validoopsieは、Great Expectationsライブラリから大きなインスピレーションを受けています。
データ検証プロセスをシンプルかつ効率的なものに抽出することを目指しています。
データの整合性をチェックする場合でも、データ標準の遵守を確保する場合でも、Validoopsieは
これらのタスクを利用しやすく簡単に行える、洗練されながらも強力なソリューションを提供します。

## 目次

1. [インストール](#installation)
2. [はじめに](#getting-started)
3. [バージョン](#version)
4. [ダンダーメソッド](#dunder-methods)
5. [Validateメソッド](#validate-method)
6. [開発](#development)
7. [ライセンス](#license)

## インストール

- pip

  `pip install Validoopsie`

- uv

  `uv add Validoopsie`

## はじめに

- [📖 ドキュメント](https://akmalsoliev.github.io/Validoopsie/)
- [🚨 Validoopsieにおけるインパクトレベル](https://akmalsoliev.github.io/Validoopsie/impact_levels.html)
- [🎯 Validoopsieにおけるしきい値レベル](https://akmalsoliev.github.io/Validoopsie/threshold_levels.html)
- [🛠️ 貢献ガイドライン](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)
- [✨ Validoopsieへの新しい検証の貢献](https://akmalsoliev.github.io/Validoopsie/contributing/DevelopingValidation.html)
- [🧑‍💻 独自のカスタム検証を開発する](https://akmalsoliev.github.io/Validoopsie/custom_validations/DevelopingValidationCustom.html)
- [🗂️ 検証カタログ](https://akmalsoliev.github.io/Validoopsie/validation_catalogue/Date%20Validation.html)

Validoopsieは非常に使いやすいため、簡単に実行できます


半分眠った状態で。ライブラリのシンプルさはBYOD（Bring Your Own DataFrame）コンセプトによって強化されており、`Validate`クラスを利用し、希望する検証をチェーンするだけで済みます。このアプローチにより、最小限の労力で無駄な複雑さなく始めることができます。




```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
)

vd.results
```

**出力：**

```json
{
  "Summary": {
    "passed": false,
    "validations": [
      "PairColumnEquality_name",
      "ColumnUniqueValuesToBeInList_last_name",
      "ColumnValuesToBeBetween_age"
    ],
    "failed_validation": ["PairColumnEquality_name"]
  },
  "PairColumnEquality_name": {
    "validation": "PairColumnEquality",
    "impact": "high",
    "timestamp": "2025-10-07T11:25:04.213211+02:00",
    "column": "name",
    "result": {
      "status": "Fail",
      "threshold_pass": false,
      "message": "The column 'name' is not equal to the column'age'.",
      "failing_items": [
        "Doe - column name - column age - 30",
        "Jane - column name - column age - 35",
        "John - column name - column age - 25"
      ],
      "failed_number": 3,
      "frame_row_number": 3,
      "threshold": 0.0,
      "failed_percentage": 1.0
    }
  },
  "ColumnUniqueValuesToBeInList_last_name": {
    "validation": "ColumnUniqueValuesToBeInList",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.216417+02:00",
    "column": "last_name",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  },
  "ColumnValuesToBeBetween_age": {
    "validation": "ColumnValuesToBeBetween",
    "impact": "low",
    "timestamp": "2025-10-07T11:25:04.217300+02:00",
    "column": "age",
    "result": {
      "status": "Success",
      "threshold_pass": true,
      "message": "All items passed the validation.",
      "frame_row_number": 3,
      "threshold": 0.0
    }
  }
}
```

`display_summary` メソッドを使用して、検証結果をフォーマットされた表で表示することもでき、
検証結果をわかりやすく読みやすい形式で提供します:


```py
vd.display_summary()
```

![default display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_default.png)

### Display a full detailed table with all available information

```py
vd.display_summary(information="full")
```

![full display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_full.png)

### Customize the table format (supports tabulate formatting options)

```py
vd.display_summary(tablefmt="pipe", maxcolwidths=20)
```

![kwargs display_summary](https://raw.githubusercontent.com/akmalsoliev/Validoopsie/main/./docs/assets/display_summary_pipe.png)

`display_summary` メソッドは、2つの情報レベルをサポートしています：

- `"short"`（デフォルト）：タイムスタンプ、影響、ステータス、検証タイプ、列、閾値、失敗の詳細などの主要な指標を表示します
- `"full"`：利用可能なすべての検証および結果フィールドを表示します

また、`tablefmt`（例："github"、"grid"、"pipe"、"html"）や `maxcolwidths` のような `tabulate` のフォーマットオプションを使ってテーブルの外観をカスタマイズできます。

## バージョン

Validoopsie のインストール済みバージョンはいつでも確認できます：




```py
from validoopsie import __version__

print(__version__)
```

## ダンダーメソッド

`Validate` クラスはいくつかのPythonダンダーメソッドをサポートしており、便利に使えます：

- `repr(vd)` — 行数と検証数の概要文字列を返します：

  ```py
  >>> repr(vd)
  'Validate(rows=3, validations=3)'
  ```

- `str(vd)` — 人間が読みやすいステータス文字列を返します:

  ```py
  >>> str(vd)
  'Validate: 3 validation(s), passed=False'
  ```

- `len(vd)` — バリデーションの数を返します:

  ```py
  >>> len(vd)
  3
  ```

## Validate メソッド

すべての検証が正しく実行されたことを確認し、検証プロセス中に発生する可能性のあるエラーを処理するために、
`validate` メソッドを使用できます。ただし、エラーは `impact` レベルが `high` に設定されている場合にのみ
発生することに注意してください。この設定がない場合、潜在的な問題はエラーメッセージを
引き起こさない可能性があります。

**注意:** 発生するエラーはカスタムの `ValueError` です。


```py
import pandas as pd

from validoopsie import Validate

p_df = pd.DataFrame(
    {
        "name": ["John", "Doe", "Jane"],
        "target_name": ["John", "Doe", "Jane"],
        "last_name": ["Smith", "Smith", "Smith"],
        "age": [25, 30, 35],
    },
)

# `vd` stands for Validate Data
vd = Validate(p_df)
vd.EqualityValidation.PairColumnEquality(
    column="name",
    target_column="age",
    impact="high",
).UniqueValidation.ColumnUniqueValuesToBeInList(
    column="last_name",
    values=["Smith"],
).ValuesValidation.ColumnValuesToBeBetween(
    column="age",
    min_value=20,
    max_value=40,
).validate()
```

[loguru](https://github.com/Delgan/loguru)のおかげで、出力は検証とそのステータスに関する非常に
簡潔な情報をカラフルに表示します。

<p align="left">
    <img width="1000" alt="validation output" src=./docs/assets/validate.png>
</p>

## 開発

Validoopsieには開発作業を簡素化するためのMakefileが含まれています：

```bash
# Install dependencies
make setup

# Run linters (mypy, ruff)
make lint

# Run tests (includes doctests, stubtest)
make test

# Run both lint and test
make all
```

開発に関する詳細は、
[貢献ガイドライン](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)をご覧ください。

## ライセンス

MIT © Validoopsie

オリジナル作成者 - [Akmal Soliev](https://github.com/akmalsoliev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---