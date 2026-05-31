<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou-dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg">
  <img alt="Piou 로고"
    src="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg"
    width="250"/>
</picture>

# Piou

[![Python 버전](https://img.shields.io/pypi/pyversions/piou)](https://pypi.python.org/pypi/piou)
[![최신 PyPI 버전](https://img.shields.io/pypi/v/piou?logo=pypi)](https://pypi.python.org/pypi/piou)
[![CI](https://github.com/Andarius/piou/actions/workflows/ci.yml/badge.svg)](https://github.com/Andarius/piou/actions/workflows/ci.yml)
[![최신 conda-forge 버전](https://img.shields.io/conda/vn/conda-forge/piou?logo=conda-forge)](https://anaconda.org/conda-forge/piou)

타입 검증을 포함한 아름다운 커맨드라인 인터페이스를 구축하는 CLI 도구입니다.

## 빠른 예제

```python
from piou import Cli, Option

cli = Cli(description='A CLI tool')


@cli.command(cmd='foo', help='Run foo command')
def foo_main(
        bar: int = Option(help='Bar positional argument (required)'),
        baz: str = Option('-b', '--baz', help='Baz keyword argument (required)'),
        foo: str | None = Option(None, '--foo', help='Foo keyword argument'),
):
    """
    A longer description on what the function is doing.
    """
    pass


if __name__ == '__main__':
    cli.run()
```

![example](https://github.com/Andarius/piou/raw/master/docs/static/simple-output.svg)

## Installation

```bash
pip install piou
```
또는 [uv](https://docs.astral.sh/uv/)를 사용하여:


```bash
uv add piou
```

또는 [conda](https://docs.conda.io/)를 사용하여:

```bash
conda install piou -c conda-forge
```

### Raw Formatter

기본적으로 Piou는 아름다운 터미널 출력을 위해 [Rich](https://github.com/Textualize/rich)를 사용합니다. 일반 텍스트 출력을 선호하는 경우, 원시 포맷터를 사용할 수 있습니다:

```bash
# Force raw output via environment variable
PIOU_FORMATTER=raw python your_cli.py --help
```
## 문서

전체 문서는 **[andarius.github.io/piou](https://andarius.github.io/piou)**에서 확인할 수 있습니다.

### 기능

- FastAPI와 유사한 타입 힌트 기반 개발자 경험
- 사용자 정의 포매터 (기본적으로 Rich 기반)
- 중첩된 명령 그룹 / 서브 커맨드 지원
- 재사용 가능한 인수 패턴을 위한 파생 옵션
- 비동기 명령 지원
- 타입 검증 및 캐스팅
- **명령 제안 및 히스토리를 갖춘 인터랙티브 TUI 모드**
- **도구 및 프로그래밍 방식 CLI 탐색을 위한 구조화된 JSON 도움말** (`--help-json`)

## 왜 Piou인가?

다음과 같은 기능을 제공하는 라이브러리를 찾지 못했습니다:

- [FastAPI](https://fastapi.tiangolo.com/)와 동일한 개발자 경험
- 인터페이스 맞춤화 (예: [Poetry](https://python-poetry.org/)와 유사한 CLI 구축)
- 타입 검증 / 캐스팅

[Typer](https://github.com/tiangolo/typer)가 가장 가까운 대안이지만, 외부 라이브러리([Rich](https://github.com/Textualize/rich) 등)를 사용해 출력 포맷을 커스터마이징하는 기능이 부족합니다.

**Piou**는 이러한 모든 가능성을 제공하며, 사용자가 직접 Formatter를 정의할 수 있습니다.

## 비동기 명령

명령은 `async` 함수일 수 있으며 — piou는 코루틴을 감지하여 자동으로 실행하므로 수동으로 `asyncio.run()`을 호출할 필요가 없습니다:


```python
from piou import Cli, Option

cli = Cli(description='Async example')

@cli.command(cmd='fetch', help='Fetch data')
async def fetch(url: str = Option(help='URL to fetch')):
    import niquests
    async with niquests.AsyncSession() as client:
        r = await client.get(url)
        print(r.status_code)

if __name__ == '__main__':
    cli.run()
```

이것은 명령 그룹 내의 명령어에도 동일하게 작동합니다.

## 인터랙티브 TUI 모드

Piou는 [Textual](https://textual.textualize.io/)로 구동되는 선택적 인터랙티브 TUI(텍스트 사용자 인터페이스) 모드를 포함합니다.
이 모드는 명령어 제안, 히스토리, 인라인 완성을 제공하는 풍부한 터미널 경험을 제공합니다.

### 설치

```bash
pip install piou[tui]

# With auto-reload support for development
pip install piou[tui-reload]
```

### 사용법

CLI를 생성할 때 `tui=True`로 설정하여 TUI 모드를 활성화하세요:

```python
from piou import Cli, Option

cli = Cli(description='My Interactive CLI', tui=True)

@cli.command(cmd='hello', help='Say hello')
def hello(name: str = Option(..., help='Name to greet')):
    print(f'Hello, {name}!')

if __name__ == '__main__':
    cli.run()
```
또는 `--tui` 플래그를 통해:


```bash
python my_cli.py --tui
```

또는 `PIOU_TUI=1` 환경 변수를 통해:

```bash
PIOU_TUI=1 python my_cli.py
```

### TUI 기능

- **명령어 제안**: `/`를 입력하여 사용 가능한 명령어와 설명 보기
- **하위 명령어 탐색**: `:`를 사용하여 하위 명령어 탐색 (예: `/stats:uploads`)
- **인라인 완성**: 입력 중 인수 자리 표시자 보기
- **명령어 기록**: 위/아래 화살표로 이전 명령어 탐색 (세션 간 유지)
- **풍부한 출력**: 출력에 ANSI 색상 및 서식 유지
- **키보드 단축키**:
  - `Tab` - 선택한 제안 확정
  - `Up/Down` - 제안 또는 기록 탐색
  - `Ctrl+C` - 입력 지우기 (두 번 눌러 종료)
  - `Escape` - 종료
- **개발자 모드**: 소스 파일 변경 시 명령어 자동 재로드 (아래 참조)

<img alt="TUI Demo" src="https://github.com/Andarius/piou/raw/master/docs/static/tui-demo.gif" width="600"/>

### 자동 재로드를 통한 개발자 모드

빠른 개발 반복을 위해 개발자 모드를 활성화하면 소스 파일 변경 시 명령어가 자동으로 재로드됩니다:

```bash
pip install piou[tui-reload]
```

그런 다음 `--tui-reload` 플래그를 사용하십시오:

```bash
python my_cli.py --tui-reload
```

또는 환경 변수로:

```bash
PIOU_TUI_DEV=1 python my_cli.py --tui
```

활성화되면 Piou는 명령어 소스 파일을 감시하고 저장 시 핫 리로드합니다. `/tui-reload` 명령어로 실행 중에 리로드 모드를 전환할 수도 있습니다.

각 리로드 후에 사용자 정의 코드를 실행하려면(예: 캐시된 데이터 새로 고침) `@cli.tui_on_reload` 데코레이터를 사용하세요:

```python
@cli.tui_on_reload
def on_reload():
    print('Code reloaded!')
```

### 고급 예제: HTTP 벤치마크

TUI 모드는 풍부한 인터랙티브 디스플레이를 위해 사용자 정의 Textual 위젯 마운트를 지원합니다. 이 예제는 라이브 진행 그리드를 사용하여 HTTP 라이브러리를 벤치마킹합니다:

<img alt="HTTP Benchmark TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/bench_1000.gif" width="700"/>

전체 구현은 `TuiContext`와 사용자 정의 위젯을 사용한 [examples/http_bench_tui.py](https://raw.githubusercontent.com/Andarius/piou/master/examples/http_bench_tui.py)를 참조하세요.

## 개발

### 테스트 실행하기

```bash
uv run pytest
```

### 문서 생성하기

```bash
# Build docs
uv run --group docs mkdocs build

# Serve locally
uv run --group docs mkdocs serve
```

### 스크린샷 및 GIF 생성

터미널 녹화는 [VHS](https://github.com/charmbracelet/vhs)로 생성됩니다. 먼저 설치하세요:

```bash
# Ubuntu/Debian
sudo apt install vhs ttyd

# macOS
brew install vhs

# Or via Go
go install github.com/charmbracelet/vhs@latest
```

그런 다음 테이프 파일에서 녹음을 생성합니다:

```bash
vhs docs/static/tui-demo.tape
```
테이프 파일은 `docs/static/`에 위치하며 GIF를 생성하는 스크립트 터미널 세션을 정의합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---