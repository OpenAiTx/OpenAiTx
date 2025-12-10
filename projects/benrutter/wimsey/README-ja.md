# 🔍 Wimsey

[![Codeberg](https://img.shields.io/badge/Codeberg-2185D0?style=for-the-badge&logo=Codeberg&logoColor=white)](https://codeberg.org/benrutter/wimsey)
[![PyPi](https://img.shields.io/badge/pypi-%23ececec.svg?style=for-the-badge&logo=pypi&logoColor=1f73b7)](https://pypi.org/project/wimsey/)

[![Docs](https://img.shields.io/badge/Docs-hugo-blue)](https://benrutter.codeberg.page/wimsey-site/site/)
![License](https://img.shields.io/badge/license-MIT-blue)
![coverage](https://img.shields.io/badge/coverage-100-green)


Wimseyは軽量で柔軟、完全オープンソースのデータ契約ライブラリです。

- 🐋 **お好きなデータフレームライブラリを使用可能**: [Narwhals](https://github.com/narwhals-dev/narwhals)の上に構築されており、Pandas、Polars、Pyspark、Dask、DuckDB、CuDF、Rapids、Arrow、Modinなど、お使いのデータフレームライブラリでネイティブにテストを実行できます。
- 🎍 **お好きな契約フォーマットを使用可能**: yaml、json、python、どれでもお好みの形式で契約を書けます！
- 🪶 **超軽量**: 速いインポートと最小限のオーバーヘッドのために、依存は2つだけ([Narwhals](https://github.com/narwhals-dev/narwhals)と[FSSpec](https://github.com/fsspec/filesystem_spec))。
- 🥔 **シンプルで使いやすいAPI**: 2つの簡単な関数でデータフレームのテストができ、結果はシンプルなデータクラスで返されるため精神的負担が少ないです。

便利な[test catalogue](https://benrutter.github.io/wimsey/possible_tests/)と[クイックスタートガイド](https://benrutter.github.io/wimsey/)もぜひご覧ください。

## データ契約とは何ですか？

次のデータイベントで話題にしたくなる良いバズワードであると同時に、データの境界値での検証に適した方法がデータ契約です。理想的には、受け取ったすべてのデータがすぐに使える状態であるべきですが、そうでないことが多いのはすでにご存知かもしれません。

データ契約とは、あるデータに対して*真であるべき*条件を表現したものです。例えば、存在する列は`first_name`、`last_name`、`rating`だけであることや、`rating`が10未満の数値であることをチェックしたい場合があります。

Wimseyではjson、yaml、pythonで契約を書けます。以下はyamlで上記のチェックを表現した例です：

```yaml
- test: columns_should
  be:
    - first_name
    - last_name
    - rating
- column: rating
  test: max_should
  be_less_than_or_equal_to: 10
```

Wimsey は次の2つの方法でテストを実行できます。`validate` はテストが失敗した場合にエラーをスローし、それ以外の場合はデータフレームを返します。`test` は個々のテストの成功と失敗の詳細な概要を提供します。

Validate は polars や pandas の `pipe` メソッドと組み合わせて便利なガードとして機能するよう設計されています：

```python
import polars as pl
import wimsey

df = (
  pl.read_csv("hopefully_nice_data.csv")
  .pipe(wimsey.validate, "tests.json")
  .group_by("name").agg(pl.col("value").sum())
)
```
テストは単一の関数呼び出しであり、`FinalResult`データ型を返します：


```python
import pandas as pd
import wimsey

df = pd.read_csv("hopefully_nice_data.csv")
results = wimsey.test(df, "tests.yaml")

if results.success:
  print("Yay we have good data! 🥳")
else:
  print(f"Oh nooo, something's up! 😭")
  print([i for i in results.results if not i.success])
```

# ロードマップ、貢献およびフィードバック

WimseyはGitHubにミラーされていますが、ホスティングおよび開発は[codeberg](https://codeberg.org/benrutter/wimsey)で行われています。Issueやプルリクエストは両方で受け付けています。

現在の焦点はプロファイリングとテスト生成の改善にあります。もし役立つテストや機能があれば、お気軽にご連絡ください！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---