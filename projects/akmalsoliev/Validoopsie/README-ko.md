<h1 align="center">
    <img width="400" alt="validoopsie" src=https://raw.githubusercontent.com/akmalsoliev/Validoopsie/refs/heads/main/docs/assets/validoopsie-text.png>
    <p style="font-size: 16px; font-weight: bold;">파이썬을 위한 간단하고 사용하기 쉬운 데이터 검증 라이브러리입니다.</p>
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

Validoopsie는 매우 가볍고 사용자 친화적인 파이썬용 데이터 검증 라이브러리입니다.  
클래스를 쉽게 선언하고 검증을 체인 형태로 연결할 수 있도록 설계되었습니다.  
이는 인기 있는 DataFrame 라이브러리 스타일을 연상시키며,  
데이터프레임 작업을 자주 하는 개발자들에게 익숙하고 직관적인 도구가 됩니다.

훌륭한 작업을 수행한  
[Narwhals](https://github.com/narwhals-dev/narwhals) 덕분에, Validoopsie는  
"Bring Your Own DataFrame"(BYOD) 개념을 포함하고 있습니다. 이 유연성 덕분에  
Narwhals가 지원하는 어떤 DataFrame이라도 데이터 검증 작업에 사용할 수 있습니다.  
지원되는 전체 DataFrame 종류를 확인하려면  
[이 링크](https://narwhals-dev.github.io/narwhals/extending/)를 방문하세요.

Validoopsie의 구문은 사용의 용이성을 보장하도록 신중하게 설계되었습니다.  
모든 검증 함수는 각자 메서드로 캡슐화되어 있으며,  
이 메서드들은 매끄럽게 연결할 수 있습니다.  
이 메서드별 설계는 단순성과 가독성을 우선시하며, 매번 새로운 API에 적응할 필요가 없도록 해줍니다.

스위치 라이브러리입니다. 깨끗하고 이해하기 쉬운 코드를 유지하는 데 집중할 수 있게 해줍니다.

Validoopsie는 Great Expectations 라이브러리에서 많은 영감을 받았습니다.  
데이터 검증 프로세스를 간단하고 효율적으로 만들기 위해 노력합니다.  
데이터 무결성을 확인하거나 데이터 표준 준수를 보장하는 작업이든,  
Validoopsie는 이러한 작업을 접근 가능하고 간단하게 수행할 수 있도록  
간소화되면서도 강력한 솔루션을 제공합니다.

## 목차

1. [설치](#installation)
2. [시작하기](#getting-started)
3. [버전](#version)
4. [더블 언더 메서드](#dunder-methods)
5. [검증 메서드](#validate-method)
6. [개발](#development)
7. [라이선스](#license)

## 설치

- pip

  `pip install Validoopsie`

- uv

  `uv add Validoopsie`

## 시작하기

- [📖 문서](https://akmalsoliev.github.io/Validoopsie/)
- [🚨 Validoopsie의 영향 수준](https://akmalsoliev.github.io/Validoopsie/impact_levels.html)
- [🎯 Validoopsie의 임계값 수준](https://akmalsoliev.github.io/Validoopsie/threshold_levels.html)
- [🛠️ 기여 지침](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)
- [✨ Validoopsie에 새로운 검증 기여하기](https://akmalsoliev.github.io/Validoopsie/contributing/DevelopingValidation.html)
- [🧑‍💻 나만의 맞춤 검증 개발하기](https://akmalsoliev.github.io/Validoopsie/custom_validations/DevelopingValidationCustom.html)
- [🗂️ 검증 카탈로그](https://akmalsoliev.github.io/Validoopsie/validation_catalogue/Date%20Validation.html)

Validoopsie는 매우 사용하기 쉬워서, 바로 할 수 있습니다

반쯤 잠든 상태. 이 라이브러리의 단순성은 BYOD(Bring Your Own DataFrame) 개념에 의해 강화되며, 여기서는 단지 `Validate` 클래스를 사용하고 원하는 검증을 체인으로 연결하기만 하면 됩니다. 이 접근 방식은 최소한의 노력과 불필요한 복잡성 없이 시작할 수 있음을 보장합니다.




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

**출력:**

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
`display_summary` 메서드를 사용하여 유효성 검사 결과를  
형식화된 표로 표시할 수도 있으며, 이는 유효성 검사 결과를  
깔끔하고 읽기 쉬운 형태로 제공합니다:


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

`display_summary` 메서드는 두 가지 정보 수준을 지원합니다:

- `"short"` (기본값): 타임스탬프, 영향도, 상태, 검증 유형, 열, 임계값 및 실패 세부 정보와 같은 주요 지표를 표시합니다
- `"full"`: 사용 가능한 모든 검증 및 결과 필드를 표시합니다

또한 `tablefmt`(예: "github", "grid", "pipe", "html")와 같은 다양한 테이블 스타일과 열 너비를 제어하는 `maxcolwidths` 등의 `tabulate` 형식 옵션을 사용하여 테이블 모양을 사용자 정의할 수 있습니다.

## 버전

언제든지 설치된 Validoopsie 버전을 확인할 수 있습니다:




```py
from validoopsie import __version__

print(__version__)
```
## 더블 언더 메서드

`Validate` 클래스는 편의를 위해 여러 파이썬 더블 언더 메서드를 지원합니다:

- `repr(vd)` — 행 수와 검증 수가 포함된 요약 문자열을 반환합니다:


  ```py
  >>> repr(vd)
  'Validate(rows=3, validations=3)'
  ```

- `str(vd)` — 사람이 읽을 수 있는 상태 문자열을 반환합니다:

  ```py
  >>> str(vd)
  'Validate: 3 validation(s), passed=False'
  ```
- `len(vd)` — 검증 수를 반환합니다:


  ```py
  >>> len(vd)
  3
  ```

## 검증 메서드

모든 검증이 올바르게 수행되었는지 확인하고 검증 과정에서 발생할 수 있는
잠재적인 오류를 처리하려면 `validate` 메서드를 사용할 수 있습니다. 그러나
오류는 `impact` 수준이 `high`로 설정된 경우에만 발생한다는 점에 유의해야
합니다. 이 설정이 없으면 잠재적인 문제는 오류 메시지를 유발하지 않을 수
있습니다.

**참고:** 발생하는 오류는 사용자 정의 `ValueError`입니다.

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

Thanks to [loguru](https://github.com/Delgan/loguru) 출력은 매우
간결한 검증 정보와 그 상태를 컬러풀하게 제공합니다.

<p align="left">
    <img width="1000" alt="validation output" src=./docs/assets/validate.png>
</p>

## 개발

Validoopsie는 개발 작업을 단순화하기 위해 Makefile을 포함합니다:

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
개발에 대한 자세한 정보는  
[기여 가이드라인](https://akmalsoliev.github.io/Validoopsie/contributing/CONTRIBUTING.html)을 확인하세요.

## 라이선스

MIT © Validoopsie

원작자 - [Akmal Soliev](https://github.com/akmalsoliev)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---