<h1 align="center">
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/validoopsie-text.png>
    <p style="font-size: 16px; font-weight: bold;">一个简单易用的Python数据验证库。</p>
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/logo.png>
</h1>

<p align="center">
  <a href="https://badge.fury.io/py/Validoopsie">
    <img src="https://badge.fury.io/py/Validoopsie.svg" alt="PyPI 版本" />
  </a>
  <a href="https://pepy.tech/projects/validoopsie">
    <img src="https://static.pepy.tech/badge/validoopsie" alt="PyPI 下载量">
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/tests.yaml/badge.svg" alt="测试和代码检查" />
  </a>
  <a href="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml">
    <img src="https://github.com/akmalsoliev/Validoopsie/actions/workflows/docs.yaml/badge.svg" alt="文档" />
  </a>
</p>

# Validoopsie

Validoopsie 是一个异常轻量且用户友好的Python数据验证库。
它旨在帮助您轻松声明类并链式调用验证函数，
其风格类似于流行的DataFrame库。
这使其成为经常处理数据框架的开发者熟悉且直观的工具。

得益于
[Narwhals](https://github.com/narwhals-dev/narwhals) 的卓越工作，Validoopsie 采用了
“自带DataFrame”（BYOD）概念。这种灵活性允许您
使用 Narwhals 支持的任何 DataFrame 来执行数据验证任务。
要探索支持的所有 DataFrame 类型，您可以访问
[此链接](https://narwhals-dev.github.io/narwhals/extending/)。

Validoopsie 的语法经过精心设计，确保易于使用。
每个验证函数都封装在自己的方法中，可以
无缝链式调用。这种方法特定的设计优先考虑简洁
和可读性，让您无需每次都适应新的API。

切换库。它让您专注于保持代码的整洁和易懂。

Validoopsie 从 Great Expectations 库中汲取了大量灵感。
它力求将数据验证过程提炼为简单高效的操作。
无论您是在检查数据完整性还是确保符合数据标准，
Validoopsie 都提供了一个简化而强大的解决方案，
使这些任务变得易于访问和简单明了。

## 目录

1. [安装](#installation)
2. [快速开始](#getting-started)
3. [版本](#version)
4. [双下划线方法](#dunder-methods)
5. [验证方法](#validate-method)
6. [开发](#development)
7. [许可](#license)

## 安装

- pip

  `pip install Validoopsie`

- uv

  `uv add Validoopsie`

## 快速开始

- [📖 文档](https://akmalsoliev.github.io/Validoopsie/)
- [🚨 Validoopsie 中的影响级别](https://akmalsoliev.github.io/Validoopsie/impact_levels.html)
- [🎯 Validoopsie 中的阈值级别](https://akmalsoliev.github.io/Validoopsie/threshold_levels.html)
- [🛠️ 贡献指南](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)
- [✨ 向 Validoopsie 贡献新的验证](https://akmalsoliev.github.io/Validoopsie/contributing/DevelopingValidation.html)
- [🧑‍💻 开发您自己的自定义验证](https://akmalsoliev.github.io/Validoopsie/custom_validations/DevelopingValidationCustom.html)
- [🗂️ 验证目录](https://akmalsoliev.github.io/Validoopsie/validation_catalogue/Date%20Validation.html)

Validoopsie 非常易于使用，甚至您可以做到

半睡半醒。该库的简洁性通过 BYOD（自带数据框）理念得以增强，您只需使用 `Validate` 类
并将所需的验证串联起来即可。该方法确保您能够
以最小的努力和无任何不必要的复杂性开始使用。


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

**输出：**

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
您还可以使用 `display_summary` 方法以格式化表格显示验证结果，  
该方法提供了一个清晰易读的验证结果视图：  



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

`display_summary` 方法支持两种信息级别：

- `"short"`（默认）：显示关键指标，如时间戳、影响、状态、
  验证类型、列、阈值和失败详情
- `"full"`：显示所有可用的验证和结果字段

您还可以使用任何 `tabulate` 格式化选项自定义表格外观，
例如使用 `tablefmt` 选择不同的表格样式（如 "github"、"grid"、
"pipe"、"html"）以及使用 `maxcolwidths` 控制列宽。

## 版本

您可以随时检查已安装的 Validoopsie 版本：

```py
from validoopsie import __version__

print(__version__)
```

## 双下方法

`Validate` 类支持多个 Python 双下方法以方便使用：

- `repr(vd)` — 返回包含行数和验证数量的摘要字符串：

  ```py
  >>> repr(vd)
  'Validate(rows=3, validations=3)'
  ```

- `str(vd)` — 返回一个可读性强的状态字符串：

  ```py
  >>> str(vd)
  'Validate: 3 validation(s), passed=False'
  ```

- `len(vd)` — 返回验证的数量：

  ```py
  >>> len(vd)
  3
  ```

## 验证方法

为了确保所有验证都已正确执行并处理验证过程中可能出现的任何错误，您可以使用
`validate` 方法。然而，需要注意的是，只有当 `impact` 级别设置为 `high` 时，错误才会被
抛出。没有此设置，潜在的问题可能不会触发错误消息。

**注意：** 抛出的错误是自定义的 `ValueError`。



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
感谢 [loguru](https://github.com/Delgan/loguru) 输出将以丰富多彩的方式提供关于验证及其状态的高度简洁的信息。

<p align="left">
    <img width="1000" alt="validation output" src=./docs/assets/validate.png>
</p>

## 开发

Validoopsie 包含一个 Makefile 以简化开发任务：



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

有关开发的更多信息，请查看
[贡献指南](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)。

## 许可证

MIT © Validoopsie

原始创建者 - [Akmal Soliev](https://github.com/akmalsoliev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---