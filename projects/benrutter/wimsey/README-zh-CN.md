# 🔍 Wimsey

[![Codeberg](https://img.shields.io/badge/Codeberg-2185D0?style=for-the-badge&logo=Codeberg&logoColor=white)](https://codeberg.org/benrutter/wimsey)
[![PyPi](https://img.shields.io/badge/pypi-%23ececec.svg?style=for-the-badge&logo=pypi&logoColor=1f73b7)](https://pypi.org/project/wimsey/)

[![Docs](https://img.shields.io/badge/Docs-hugo-blue)](https://benrutter.codeberg.page/wimsey-site/site/)
![License](https://img.shields.io/badge/license-MIT-blue)
![coverage](https://img.shields.io/badge/coverage-100-green)


Wimsey 是一个轻量、灵活且完全开源的数据契约库。

- 🐋 **自带数据框架库**：构建于 [Narwhals](https://github.com/narwhals-dev/narwhals) 之上，您的测试将在您自己的数据框架库中本地执行（支持 Pandas、Polars、Pyspark、Dask、DuckDB、CuDF、Rapids、Arrow 和 Modin）
- 🎍 **自带契约格式**：可以用 yaml、json 或 python 编写契约——随您喜欢！
- 🪶 **超轻量级**：为了快速导入和最低开销，仅依赖两个库（[Narwhals](https://github.com/narwhals-dev/narwhals) 和 [FSSpec](https://github.com/fsspec/filesystem_spec)）
- 🥔 **简单易用的 API**：两个简单函数测试数据框架，配合简单的结果数据类，降低认知负担。

查看方便的 [测试目录](https://benrutter.github.io/wimsey/possible_tests/) 和 [快速入门指南](https://benrutter.github.io/wimsey/)

## 什么是数据契约？

除了是下一个数据活动中可以提及的流行词外，数据契约是测试数据边界值的好方法。理想情况下，您收到的数据应该是可用的，但您可能已经发现情况并非总是如此。

数据契约是对某些数据“应当”为真的表达——我们可能想检查存在的列仅有 `first_name`、`last_name` 和 `rating`，或者我们想检查 `rating` 是小于 10 的数字。

Wimsey 允许您用 json、yaml 或 python 编写契约，以下是上述检查用 yaml 表示的样例：

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

Wimsey 可以通过几种方式为您执行测试，`validate` - 如果测试失败将抛出错误，否则返回您的数据框 - 以及 `test`，它会详细列出各个测试的成功与失败情况。

Validate 设计得与 polars 或 pandas 的 `pipe` 方法很好地配合，作为一个方便的防护：

```python
import polars as pl
import wimsey

df = (
  pl.read_csv("hopefully_nice_data.csv")
  .pipe(wimsey.validate, "tests.json")
  .group_by("name").agg(pl.col("value").sum())
)
```
测试是一个单一的函数调用，返回一个 `FinalResult` 数据类型：


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

# 路线图、贡献与反馈

Wimsey 在 GitHub 上有镜像，但托管和开发均在 [codeberg](https://codeberg.org/benrutter/wimsey) 上进行。问题和拉取请求两边都接受。

目前重点是完善性能分析和测试生成，如果你有测试或功能对你有帮助，欢迎随时联系！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---