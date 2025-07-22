<translate-content># python-makefun

*一个用于动态创建 Python 函数的小型库。*

[![Python 版本](https://img.shields.io/pypi/pyversions/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![构建状态](https://github.com/smarie/python-makefun/actions/workflows/base.yml/badge.svg)](https://github.com/smarie/python-makefun/actions/workflows/base.yml) [![测试状态](https://smarie.github.io/python-makefun/reports/junit/junit-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/junit/report.html) [![覆盖率状态](https://smarie.github.io/python-makefun/reports/coverage/coverage-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/coverage/index.html) [![codecov](https://codecov.io/gh/smarie/python-makefun/branch/main/graph/badge.svg)](https://codecov.io/gh/smarie/python-makefun) [![Flake8 状态](https://smarie.github.io/python-makefun/reports/flake8/flake8-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/flake8/index.html)

[![文档](https://img.shields.io/badge/doc-latest-blue.svg)](https://smarie.github.io/python-makefun/) [![PyPI](https://img.shields.io/pypi/v/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![下载量](https://pepy.tech/badge/makefun)](https://pepy.tech/project/makefun) [![每周下载量](https://pepy.tech/badge/makefun/week)](https://pepy.tech/project/makefun) [![GitHub 星标](https://img.shields.io/github/stars/smarie/python-makefun.svg)](https://github.com/smarie/python-makefun/stargazers)

**这是面向开发者的自述文件。** 用户文档请见这里：[https://smarie.github.io/python-makefun/](https://smarie.github.io/python-makefun/)

## 想要贡献代码？

欢迎贡献！只需在 GitHub 上 fork 本项目，提交你的贡献，并创建拉取请求。

以下是不完全的有趣开放话题列表：[https://github.com/smarie/python-makefun/issues](https://github.com/smarie/python-makefun/issues)

## `nox` 配置

本项目使用 `nox` 来定义所有生命周期任务。为了能够运行这些任务，你应该创建 Python 3.7 环境并安装依赖：
</translate-content>
```bash
>>> conda create -n noxenv python="3.7"
>>> activate noxenv
(noxenv) >>> pip install -r noxfile-requirements.txt
```
你应该能够使用以下命令列出所有可用的任务：


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
## 运行测试和生成报告

该项目使用 `pytest`，因此在根目录运行 `pytest` 会在当前环境下执行所有测试。  
然而，手动管理所有依赖有些繁琐；使用 `nox` 在所有支持的 Python 环境中运行带有正确包依赖的 `pytest` 会更简单：

```bash
nox
```
<translate-content>
测试和覆盖率报告会自动生成在 `./docs/reports` 目录下，针对某个会话（`tests-3.7`）。

如果您希望在特定环境下执行测试，请使用明确的会话名称，例如 `nox -s tests-3.6`。


## 编辑文档

本项目使用 `mkdocs` 来生成文档页面。因此，可以使用 `mkdocs build -f docs/mkdocs.yml` 来构建本地文档副本。但同样，使用 `nox` 会更简单。您可以轻松地构建并本地启动一个文档站点版本，使用：
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
在运行时，您可以编辑 `./docs/` 目录下的文件，并在本地 [http://127.0.0.1:8000](http://127.0.0.1:8000) 页面浏览自动刷新的文档。

完成后，只需按 `<CTRL+C>` 停止会话。

文档发布（包括测试和覆盖率报告）由[持续集成引擎](https://github.com/smarie/python-makefun/actions)自动完成，使用 `nox -s publish` 会话，本地开发不需要此操作。

## 打包

本项目使用 `setuptools_scm` 同步版本号。因此，开发快照和正式发布都应使用以下命令：`python setup.py sdist bdist_wheel`。但通常不需要手动执行，[持续集成引擎](https://github.com/smarie/python-makefun/actions)会在 git 标签上自动完成。作为参考，这在 `nox -s release` 会话中执行。

### 合并带有编辑的拉取请求 - 备忘

Ax 在 GitHub 中解释（“获取命令行指令”）：
</translate-content>
```bash
git checkout -b <git_name>-<feature_branch> main
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit --ff-only
```
if the second step does not work, do a normal auto-merge (do not use **rebase**!):


```bash
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit
```
最后审查更改，可能进行一些修改，然后提交。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---