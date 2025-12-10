# 🔍 Wimsey

[![Codeberg](https://img.shields.io/badge/Codeberg-2185D0?style=for-the-badge&logo=Codeberg&logoColor=white)](https://codeberg.org/benrutter/wimsey)
[![PyPi](https://img.shields.io/badge/pypi-%23ececec.svg?style=for-the-badge&logo=pypi&logoColor=1f73b7)](https://pypi.org/project/wimsey/)

[![Docs](https://img.shields.io/badge/Docs-hugo-blue)](https://benrutter.codeberg.page/wimsey-site/site/)
![License](https://img.shields.io/badge/license-MIT-blue)
![coverage](https://img.shields.io/badge/coverage-100-green)


Wimsey는 가볍고 유연하며 완전 오픈소스인 데이터 계약 라이브러리입니다.

- 🐋 **자신만의 데이터프레임 라이브러리를 사용하세요**: [Narwhals](https://github.com/narwhals-dev/narwhals) 위에 구축되어 Pandas, Polars, Pyspark, Dask, DuckDB, CuDF, Rapids, Arrow 및 Modin을 포함한 자신만의 데이터프레임 라이브러리에서 네이티브로 테스트를 수행합니다.
- 🎍 **자신만의 계약 형식을 사용하세요**: yaml, json 또는 python 중 원하는 형식으로 계약을 작성할 수 있습니다!
- 🪶 **초경량**: 빠른 임포트와 최소한의 오버헤드를 위해 단 두 개의 종속성([Narwhals](https://github.com/narwhals-dev/narwhals) 및 [FSSpec](https://github.com/fsspec/filesystem_spec))만 사용하여 제작되었습니다.
- 🥔 **간단하고 쉬운 API**: 데이터프레임 테스트를 위한 두 가지 간단한 함수와 결과를 위한 간단한 데이터클래스로 정신적 부담을 줄였습니다.

유용한 [테스트 카탈로그](https://benrutter.github.io/wimsey/possible_tests/)와 [빠른 시작 가이드](https://benrutter.github.io/wimsey/)를 확인해 보세요.

## 데이터 계약이란 무엇인가요?

다음 데이터 행사에서 언급하기 좋은 유행어일 뿐만 아니라, 데이터 계약은 경계점에서 데이터 값을 테스트하는 좋은 방법입니다. 이상적으로는 모든 데이터가 받는 즉시 사용 가능해야 하지만, 이미 아시다시피 항상 그런 것은 아닙니다.

데이터 계약은 어떤 데이터에 대해 *참이어야 하는* 조건을 표현한 것입니다 - 예를 들어, 존재하는 유일한 컬럼이 `first_name`, `last_name`, `rating`인지 확인하거나, `rating`이 10 미만의 숫자인지 확인하고자 할 수 있습니다.

Wimsey는 json, yaml 또는 python으로 계약을 작성할 수 있게 해주며, 위의 검사를 yaml로 작성하면 다음과 같습니다:

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
Wimsey는 두 가지 방법으로 테스트를 실행할 수 있습니다. `validate`는 테스트가 실패하면 오류를 발생시키고, 그렇지 않으면 데이터프레임을 반환하며, `test`는 개별 테스트 성공 및 실패에 대한 자세한 보고서를 제공합니다.

Validate는 polars 또는 pandas의 `pipe` 메서드와 잘 작동하도록 설계되어 편리한 가드 역할을 합니다:


```python
import polars as pl
import wimsey

df = (
  pl.read_csv("hopefully_nice_data.csv")
  .pipe(wimsey.validate, "tests.json")
  .group_by("name").agg(pl.col("value").sum())
)
```
Test는 단일 함수 호출로, `FinalResult` 데이터 타입을 반환합니다:


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

# 로드맵, 기여 및 피드백

Wimsey는 github에 미러링되어 있지만, [codeberg](https://codeberg.org/benrutter/wimsey)에서 호스팅 및 개발되고 있습니다. 이슈와 풀 리퀘스트는 둘 다에서 접수됩니다.

현재 집중하고 있는 부분은 프로파일링과 테스트 생성의 정교화이며, 도움이 될 만한 테스트나 기능이 있으면 언제든지 연락해 주세요!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---