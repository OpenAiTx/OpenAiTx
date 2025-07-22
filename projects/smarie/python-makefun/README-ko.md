<translate-content># python-makefun

*파이썬 함수를 동적으로 생성하는 작은 라이브러리입니다.*

[![Python versions](https://img.shields.io/pypi/pyversions/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![Build Status](https://github.com/smarie/python-makefun/actions/workflows/base.yml/badge.svg)](https://github.com/smarie/python-makefun/actions/workflows/base.yml) [![Tests Status](https://smarie.github.io/python-makefun/reports/junit/junit-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/junit/report.html) [![Coverage Status](https://smarie.github.io/python-makefun/reports/coverage/coverage-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/coverage/index.html) [![codecov](https://codecov.io/gh/smarie/python-makefun/branch/main/graph/badge.svg)](https://codecov.io/gh/smarie/python-makefun) [![Flake8 Status](https://smarie.github.io/python-makefun/reports/flake8/flake8-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/flake8/index.html)

[![Documentation](https://img.shields.io/badge/doc-latest-blue.svg)](https://smarie.github.io/python-makefun/) [![PyPI](https://img.shields.io/pypi/v/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![Downloads](https://pepy.tech/badge/makefun)](https://pepy.tech/project/makefun) [![Downloads per week](https://pepy.tech/badge/makefun/week)](https://pepy.tech/project/makefun) [![GitHub stars](https://img.shields.io/github/stars/smarie/python-makefun.svg)](https://github.com/smarie/python-makefun/stargazers)

**이 문서는 개발자를 위한 README입니다.** 사용자용 문서는 여기에서 확인할 수 있습니다: [https://smarie.github.io/python-makefun/](https://smarie.github.io/python-makefun/)

## 기여하고 싶으신가요?

기여를 환영합니다! GitHub에서 이 프로젝트를 포크하고, 기여 내용을 커밋한 후, 풀 리퀘스트를 생성하세요.

흥미로운 오픈 이슈의 비포괄적 목록은 다음에서 확인할 수 있습니다: [https://github.com/smarie/python-makefun/issues](https://github.com/smarie/python-makefun/issues)

## `nox` 설정

이 프로젝트는 모든 라이프사이클 작업을 정의하기 위해 `nox`를 사용합니다. 해당 작업들을 실행하려면, 파이썬 3.7 환경을 생성하고 필요한 패키지를 설치해야 합니다:
</translate-content>
```bash
>>> conda create -n noxenv python="3.7"
>>> activate noxenv
(noxenv) >>> pip install -r noxfile-requirements.txt
```
<translate-content>
그런 다음 다음 명령어를 사용하여 사용 가능한 모든 작업을 나열할 수 있어야 합니다:
</translate-content>
```
>>> nox --list
Sessions defined in <path>\noxfile.py:

* tests-2.7 -> Run the test suite, including test reports generation and coverage reports.
* tests-3.5 -> Run the test suite, including test reports generation and coverage reports.
* tests-3.6 -> Run the test suite, including test reports generation and coverage reports.
* tests-3.8 -> Run the test suite, including test reports generation and coverage reports.
* tests-3.7 -> Run the test suite, including test reports generation and coverage reports.
- docs-3.7 -> Generates the doc and serves it on a local http server. Pass '-- build' to build statically instead.
- publish-3.7 -> Deploy the docs+reports on github pages. Note: this rebuilds the docs
- release-3.7 -> Create a release on github corresponding to the latest tag
```
## 테스트 실행 및 보고서 생성

이 프로젝트는 `pytest`를 사용하므로 루트 폴더에서 `pytest`를 실행하면 현재 환경에서 모든 테스트가 수행됩니다. 그러나 모든 요구 사항을 수동으로 관리하는 것은 다소 번거롭습니다; 올바른 패키지 요구 사항과 함께 모든 지원되는 파이썬 환경에서 `pytest`를 실행하려면 `nox`를 사용하는 것이 더 쉽습니다:


```bash
nox
```
<translate-content>
테스트 및 커버리지 보고서는 `./docs/reports` 아래에 자동으로 생성되며, 세션 중 하나(`tests-3.7`)에 해당합니다. 

특정 환경에서 테스트를 실행하려면 명시적인 세션 이름을 사용하세요. 예: `nox -s tests-3.6`.


## 문서 편집

이 프로젝트는 문서 페이지 생성을 위해 `mkdocs`를 사용합니다. 따라서 문서 페이지의 로컬 복사본 빌드는 `mkdocs build -f docs/mkdocs.yml`로 수행할 수 있습니다. 하지만 다시 말하지만 `nox`를 사용하는 것이 더 쉽습니다. 다음을 사용하여 문서 사이트 버전을 로컬에서 쉽게 빌드하고 제공할 수 있습니다:
</translate-content>
```bash
>>> nox -s docs
nox > Running session docs-3.7
nox > Creating conda env in .nox\docs-3-7 with python=3.7
nox > [docs] Installing requirements with pip: ['mkdocs-material', 'mkdocs', 'pymdown-extensions', 'pygments']
nox > python -m pip install mkdocs-material mkdocs pymdown-extensions pygments
nox > mkdocs serve -f ./docs/mkdocs.yml
INFO    -  Building documentation...
INFO    -  Cleaning site directory
INFO    -  The following pages exist in the docs directory, but are not included in the "nav" configuration:
  - long_description.md
INFO    -  Documentation built in 1.07 seconds
INFO    -  Serving on http://127.0.0.1:8000
INFO    -  Start watching changes
...
```
<translate-content>
이 실행 중에는 `./docs/` 아래의 파일들을 편집할 수 있으며, 로컬 [http://127.0.0.1:8000](http://127.0.0.1:8000) 페이지에서 자동으로 갱신되는 문서를 탐색할 수 있습니다.

완료되면 `<CTRL+C>`를 눌러 세션을 종료하면 됩니다.

문서 출판(테스트 및 커버리지 보고서 포함)은 [지속적 통합 엔진](https://github.com/smarie/python-makefun/actions)이 자동으로 수행하며, `nox -s publish` 세션을 사용합니다. 이는 로컬 개발 시 필요하지 않습니다.

## 패키징

이 프로젝트는 버전 번호 동기화를 위해 `setuptools_scm`을 사용합니다. 따라서 개발 스냅샷과 공식 릴리스 모두에 대해 다음 명령어를 사용해야 합니다: `python setup.py sdist bdist_wheel`. 하지만 [지속적 통합 엔진](https://github.com/smarie/python-makefun/actions)이 git 태그에 대해 자동으로 처리해주므로 일반적으로 필요하지 않습니다. 참고로, 이는 `nox -s release` 세션에서 수행됩니다.

### 수정 사항이 포함된 풀 리퀘스트 병합 - 메모

Ax가 github('get commandline instructions')에서 설명했습니다:
</translate-content>
```bash
git checkout -b <git_name>-<feature_branch> main
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit --ff-only
```
두 번째 단계가 작동하지 않으면 일반 자동 병합을 수행하세요 (**리베이스**를 사용하지 마세요!):


```bash
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit
```
마지막으로 변경 사항을 검토하고, 필요에 따라 일부 수정을 수행한 후 커밋합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---