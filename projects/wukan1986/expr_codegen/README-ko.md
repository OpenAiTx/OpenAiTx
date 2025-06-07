# expr_codegen 표현식 변환기

## 프로젝트 배경

제가 새로 출시한 [polars_ta](https://github.com/wukan1986/polars_ta) 라이브러리를 만든 후, 다시 돌아와서 `expr_codegen`이 무엇인지 성찰하게 되었습니다.

> `expr_codegen`의 본질은 `DSL`, 도메인 특화 언어(Domain Specific Language)입니다. 하지만 새로운 문법을 정의하지는 않습니다.

이 도구는 두 가지 문제를 해결합니다:

1. `polars_ta`를 사용하면 특성 계산 표현식을 매우 쉽게 작성할 수 있지만, `시계열과 단면 혼합` 표현식을 만날 때 `expr_codegen`을 이용하면 자동으로 그룹핑이 되어 작업량을 크게 줄일 수 있습니다.
2. `expr_codegen`은 `Common Subexpression Elimination`(공통 부분식 제거)를 이용하여 중복 계산을 대폭 줄이고 효율을 높입니다.

퀀트 분야에서도, 초급 연구원은 시계열 지표에만 국한된다면 `polars_ta`만으로 충분하지만, 중급 및 고급 연구원이 단면 지표를 사용할 때는 `expr_codegen`을 추천합니다.

현재 이 프로젝트는 `polars_ta`와 매우 밀접하게 연동되어 있지만, 다른 라이브러리로의 번역도 지원합니다. 예를 들어 `pandas / cudf.pandas` 등, 단지 현재는 비교적 간단한 라이브러리가 부족할 뿐입니다.

## 온라인 데모

https://exprcodegen.streamlit.app

초급 사용자는 이 링크에 바로 접속해 표현식 변환을 할 수 있으며, 별도의 소프트웨어 설치가 필요 없습니다.(이 도구는 해외 서버에 무료로 배포되어 있어 접속이 다소 느릴 수 있습니다.)

더 완전한 예시는 [alpha_examples](https://github.com/wukan1986/alpha_examples)에서 확인할 수 있습니다.

## 사용 예시

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # 팩터 편집 구역, IDE의 자동완성 기능을 활용하여 이 구역에서 팩터를 편집할 수 있습니다.
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # 템플릿에는 이미 from polars_ta.prefix의 많은 연산자가 기본 임포트되어 있지만,
    # talib은 템플릿에 기본 임포트되어 있지 않습니다. 이런 방식으로 생성된 코드에 임포트가 추가됩니다.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # def와 class의 원본 임포트도 지원합니다.
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. 언더스코어(_)로 시작하는 변수는 중간 변수로, 자동으로 이름이 변경되고, 최종 출력 시 삭제됩니다.
    # 2. 언더스코어로 시작하는 변수는 반복 사용이 가능합니다. 여러 복잡한 팩터를 여러 줄로 작성할 때 중간 변수가 겹쳐도 충돌하지 않습니다.
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. 언더스코어로 시작하는 변수는 순환 할당이 가능합니다. 디버깅 시 주석으로 빠르게 전환할 수 있습니다.
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # 코드 출력
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # 파일로 저장
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # 실행만 하고 코드 저장 안 함

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # 문자열에 저장
code.seek(0)
code.read()  # 코드 읽기

# TODO: 적절한 데이터로 교체 필요
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## 디렉터리 구조

```commandline
│  requirements.txt # `pip install -r requirements.txt`로 의존성 설치
├─data
│      prepare_date.py # 데이터 준비
├─examples
│      demo_express.py # 빠른 예시. 표현식을 코드로 변환하는 방법 시연
│      demo_exec_pl.py # 변환된 코드 호출 및 시각화 시연
│      demo_transformer.py # 서드파티 표현식을 내부 표현식으로 변환 시연
│      output.py # 결과 출력. 코드를 수정하지 않아도 다른 프로젝트에서 직접 임포트 가능
│      show_tree.py # 표현식 트리 그림. 최적화 결과 분석 및 비교에 사용
│      sympy_define.py # 심볼 정의. 여러 곳에서 반복 사용되어 통합 관리
├─expr_codegen
│   │  expr.py # 표현식 처리 기본 함수
│   │  tool.py # 핵심 도구 코드
│   ├─polars
│   │  │  code.py # polars 문법에 맞춘 코드 생성 기능
│   │  │  template.py.j2 # `Jinja2` 템플릿. py 파일 생성에 사용, 일반적으로 수정 불필요
│   │  │  printer.py # `Sympy`의 `StrPrinter` 상속, 새 함수 추가 시 이 파일 수정 가능
```

## 작동 원리

이 프로젝트는 `sympy` 프로젝트에 의존합니다. 주요 사용 함수는 다음과 같습니다:

1. `simplify`: 복잡한 표현식 단순화
2. `cse`: `Common Subexpression Elimination`(공통 부분식 제거)
3. `StrPrinter`: 함수에 따라 다른 문자열 출력. 이 코드를 커스터마이징하면 다른 언어나 라이브러리도 지원 가능

`groupby`, `sort`는 시간이 많이 소요됩니다. 미리 수식을 분류해서 각 범주별로 다른 `groupby`를 사용하면 계산 시간을 줄일 수 있습니다.

1. `ts_xxx(ts_xxx)`: 동일한 `groupby`에서 계산 가능
2. `cs_xxx(cs_xxx)`: 동일한 `groupby`에서 계산 가능
3. `ts_xxx(cs_xxx)`: 서로 다른 `groupby`에서 계산 필요
4. `cs_xxx(ts_xxx(cs_xxx))`: 세 개의 다른 `groupby`에서 계산 필요
5. `gp_xxx(aa, )+gp_xxx(bb, )`: `aa`, `bb`가 다르므로 두 개의 다른 `groupby`에서 계산 필요

따라서

1. 현재 표현식의 범주(`get_current`)와 자식 표현식의 범주(`get_children`)를 파악하는 함수가 필요
2. 현재 범주와 자식 범주가 다르면 짧은 수식(`extract`)을 추출할 수 있음. 다른 계층의 동일 범주 표현식은 순서 관계가 있어 같은 `groupby`에 둘 수 없음
3. `cse`의 특성을 활용해 긴 표현식을 미리 추출된 짧은 표현식으로 대체한 후, 유향 비순환 그래프(`DAG`)에 입력
4. 유향 비순환 그래프의 흐름을 이용해 계층화. 같은 계층의 `ts`, `cs`, `gp`는 순서 구분 없음
5. 같은 계층에서 `ts`, `cs`, `gp`로 그룹화하고 코드 생성(`codegen`)

내포 정보

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

즉,

1. 시계열 함수는 두 개 필드 `ASSET, DATE`를 숨기고, 단면 함수는 한 개 필드 `DATE`를 숨깁니다.
2. 그룹 함수는 필드 `GROUP`을 추가 입력하고, 동시에 필드 `DATE`를 숨깁니다.

두 가지 분류 방법

1. 연산자 접두사로 분류(`get_current_by_prefix`), 연산자는 반드시 `ts_`, `cs_`, `gp_`로 시작해야 함
2. 연산자 전체 이름으로 분류(`get_current_by_name`), 연산자 명 제한 없음. 예를 들어 `cs_rank`는 `rank`로 불러도 됨

## Null 처리

`null`은 어떻게 발생하는가?

1. 정지(거래정지)로 인한 발생. 계산 전에 바로 필터링되어 이후 계산에 영향 없음.
2. 종목별 거래 시간대가 다를 때
3. 계산 중 발생. `null`은 수열 양쪽 끝에서는 시계열 연산자 결과에 영향이 없지만, 중간에 `null`이 생기면 영향을 미침. 예: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

매우 좋은 아이디어로, 두 가지 구현 방식이 있습니다:

1. `null`을 한 그룹, `not_null`을 다른 그룹으로 나누어 두 번 호출
2. 한 그룹만 사용하되, 복합 정렬로 `null`을 앞에, `not_null`을 뒤에 배치. 한 번만 호출하여 약간 더 빠름

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

두 번째 방식에서 앞부분의 `null` 영역이 결과에 영향을 미치는지는 연산자에 따라 다르며, 특히 다중 컬럼 입력 시 `null` 영역에 데이터가 있을 수 있습니다.

1. `over_null='partition_by'`: 두 영역으로 분할
2. `over_null='order_by'`: 한 영역으로만, `null`이 앞에 정렬됨
3. `over_null=None`: 별도 처리 없이 바로 호출, 속도가 가장 빠름. 중간에 `null`이 발생하지 않는다고 확신할 때 이 파라미터 사용 권장

`codegen_exec(over_null='partition_by')`는 전역적으로 `partition_by`를 사용합니다. 하지만 `ts_count_nulls` 같은 `null` 함수에서는 `over_null=None`을 사용해야 하므로, 이 도구에서는 한 줄 표현식별로 파라미터를 지정하는 주석 기능도 추가했습니다.

1. `# --over_null partition_by`: 한 줄 `over_null='partition_by'`
2. `# --over_null=order_by`: 한 줄 `over_null='order_by'`
3. `# --over_null`: 한 줄 `over_null=None`
4. `# `: `codegen_exec`에서 전달받은 `over_null` 값을 사용

유의사항:

1. `# --over_null` 파라미터 주석은 반드시 한 줄 표현식 뒤에만 쓸 수 있으며, 독립적인 줄에 쓰면 무시됩니다.
2. `# --over_null # --over_null=order_by` 등 여러 `#`가 있을 경우 첫 번째만 유효하게 처리됩니다.
3. 최외곽 `ts` 함수에만 적용됩니다. 만약 `ts` 함수가 외곽에 없으면 직접 분리해야 합니다. 예:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # cs_rank에 적용되어 의미 없음
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # ts_rank(ts_mean)에 적용된 것 같지만, 실제로는 공통 ts_mean이 있어 ts_rank(_x_0)에 적용됨
   ```

   다음처럼 작성해야 합니다:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. 실수하기 쉬우므로, `output_file`을 생성하여 코드가 올바른지 반드시 확인할 것을 강력히 권장합니다.

## `expr_codegen`의 한계

1. `DAG`는 컬럼 추가만 가능하고 삭제는 불가. 동일한 컬럼명이 나오면 덮어씁니다.
2. `행 삭제`는 지원하지 않지만, 삭제 플래그 컬럼을 추가한 뒤 외부에서 행을 삭제할 수 있습니다. 행 삭제는 모든 컬럼에 영향을 미치므로 `DAG`에 부합하지 않습니다.
3. `리샘플링`을 지원하지 않습니다. 원리는 행 삭제와 동일. 외부에서 처리해야 합니다.
4. `행 삭제`와 `리샘플링`을 경계선으로 삼아 코드를 여러 `DAG`로 분할하여 연쇄 처리할 수 있습니다. 복잡하고 이해하기 어려워 결국 미구현

## 특수 문법

1. `C?T:F` 삼항 표현식을 지원합니다(문자열에서만 사용 가능). 내부적으로 `C or True if( T )else F`로 변환 후, `T if C else F`로 수정되며, 마지막으로 `if_else(C,T,F)`로 변환됩니다. `if else`와 혼용 가능
2. `(A<B)*-1`은 내부적으로 `int_(A<B)*-1`로 변환됩니다.
3. `A==B`가 `sympy`에서 `False`로 변환되는 걸 방지하기 위해 내부적으로 `Eq(A,B)`로 변환됩니다.
4. `A^B`의 의미는 `convert_xor` 파라미터에 따라 달라지며, `convert_xor=True`이면 `Pow(A,B)`로, 아니면 `Xor(A,B)`로 변환됩니다. 기본값은 `False`이며, 거듭제곱은 `**` 사용
5. `A&B&C`는 지원하지만 `A==B==C`는 지원하지 않습니다. C가 불리언이고 AB가 숫자면 수동으로 `(A==B)==C`로, ABC 모두 숫자면 `(A==B)&(B==C)`로 수동 변환 필요
6. `A<=B<=C`는 지원하지 않으니 수동으로 `(A<=B)&(B<=C)`로 변환 필요
7. `A[0]+B[1]+C[2]`는 내부적으로 `A+ts_delay(B,1)+ts_delay(C,2)`로 변환됩니다.
8. `~A`는 내부적으로 `Not(A)`로 변환됩니다.
9. `gp_`로 시작하는 함수는 해당하는 `cs_` 함수를 반환합니다. 예를 들어, `gp_func(A,B,C)`는 내부적으로 `cs_func(B,C)`로 대체되며, `A`는 `groupby([date, A])`에 사용됩니다.
10. `A,B,C=MACD()` 튜플 언패킹을 지원하며, 내부적으로
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
   로 변환됩니다.
11. 한 줄 주석에서 파라미터 입력을 지원합니다. 예: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. 코드 블록 내에서 `import`, `def`, `class` 세 가지 문법은 자동으로 생성된 코드에 원본 그대로 삽입됩니다.

## 언더스코어로 시작하는 변수

1. 출력 데이터에서 언더스코어(_)로 시작하는 모든 컬럼은 마지막에 자동으로 삭제됩니다. 따라서 꼭 남겨야 할 변수는 언더스코어로 시작하면 안 됩니다.
2. 중복 계산을 줄이기 위해 자동으로 중간 변수(예: `_x_0`, `_x_1` 등)를 추가하며, 마지막에 자동으로 삭제됩니다.
3. 한 줄 표현식이 너무 길거나 중복 계산이 있을 때, 중간 변수를 통해 한 줄 표현식을 여러 줄로 바꿀 수 있습니다. 중간 변수를 언더스코어로 시작하면 자동으로 숫자 접미사가 붙어 각각 다른 변수(예: `_A_0_`, `_A_1_`)로 바뀝니다. 사용 예시는 다음과 같습니다:
    1. 같은 변수명을 반복 사용. 실질적으로는 서로 다른 변수임
    2. 순환 할당, 하지만 `DAG`는 순환을 지원하지 않음. `=` 기호 좌우의 동일 변수명은 실제로 다른 변수임

## 변환 결과 예시

변환된 코드 일부, 전체 코드는 [Polars 버전](examples/output_polars.py) 참조

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

변환된 코드 일부, 전체 코드는 [Pandas 버전](examples/output_pandas.py) 참조

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

## 로컬 배포용 웹 인터페이스

`streamlit run streamlit_app.py`만 실행하면 됩니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---