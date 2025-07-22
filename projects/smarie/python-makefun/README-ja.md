<translate-content># python-makefun

*Python関数を動的に作成するための小さなライブラリ。*

[![Python versions](https://img.shields.io/pypi/pyversions/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![Build Status](https://github.com/smarie/python-makefun/actions/workflows/base.yml/badge.svg)](https://github.com/smarie/python-makefun/actions/workflows/base.yml) [![Tests Status](https://smarie.github.io/python-makefun/reports/junit/junit-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/junit/report.html) [![Coverage Status](https://smarie.github.io/python-makefun/reports/coverage/coverage-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/coverage/index.html) [![codecov](https://codecov.io/gh/smarie/python-makefun/branch/main/graph/badge.svg)](https://codecov.io/gh/smarie/python-makefun) [![Flake8 Status](https://smarie.github.io/python-makefun/reports/flake8/flake8-badge.svg?dummy=8484744)](https://smarie.github.io/python-makefun/reports/flake8/index.html)

[![Documentation](https://img.shields.io/badge/doc-latest-blue.svg)](https://smarie.github.io/python-makefun/) [![PyPI](https://img.shields.io/pypi/v/makefun.svg)](https://pypi.python.org/pypi/makefun/) [![Downloads](https://pepy.tech/badge/makefun)](https://pepy.tech/project/makefun) [![Downloads per week](https://pepy.tech/badge/makefun/week)](https://pepy.tech/project/makefun) [![GitHub stars](https://img.shields.io/github/stars/smarie/python-makefun.svg)](https://github.com/smarie/python-makefun/stargazers)

**これは開発者向けのREADMEです。** ユーザー向けのドキュメントはここにあります: [https://smarie.github.io/python-makefun/](https://smarie.github.io/python-makefun/)

## 貢献したいですか？

貢献は大歓迎です！ GitHubでこのプロジェクトをフォークし、変更をコミットしてプルリクエストを作成してください。

興味深いオープントピックの非網羅的なリストはこちらです: [https://github.com/smarie/python-makefun/issues](https://github.com/smarie/python-makefun/issues)

## `nox` セットアップ

このプロジェクトはライフサイクルタスクの定義に `nox` を使用しています。これらのタスクを実行するには、Python 3.7の環境を作成し、必要なパッケージをインストールしてください:
</translate-content>
```bash
>>> conda create -n noxenv python="3.7"
>>> activate noxenv
(noxenv) >>> pip install -r noxfile-requirements.txt
```
以下のコマンドを使用して、利用可能なすべてのタスクを一覧表示できるはずです:


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
## テストの実行とレポートの生成

このプロジェクトは `pytest` を使用しているため、ルートフォルダで `pytest` を実行すると現在の環境で全てのテストが実行されます。しかし、すべての依存関係を手動で管理するのは少し面倒です；正しいパッケージ要件を持つすべてのサポートされているPython環境で `pytest` を実行するには `nox` を使う方が簡単です：


```bash
nox
```
<translate-content>
テストおよびカバレッジレポートは、セッションの一つ（`tests-3.7`）のために `./docs/reports` に自動生成されます。

特定の環境でテストを実行したい場合は、明示的なセッション名を使用してください。例：`nox -s tests-3.6`。


## ドキュメントの編集

このプロジェクトはドキュメントページの生成に `mkdocs` を使用しています。したがって、ローカルコピーのドキュメントページのビルドは `mkdocs build -f docs/mkdocs.yml` を使って行えます。しかし、やはり `nox` を使う方が簡単です。次のコマンドでドキュメントサイトのバージョンをローカルで簡単にビルドしてサーブできます：
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
これが実行されている間、`./docs/` 以下のファイルを編集し、ローカルの [http://127.0.0.1:8000](http://127.0.0.1:8000) ページで自動更新されるドキュメントを閲覧できます。

終了したら、単に `<CTRL+C>` を押してセッションを停止してください。

ドキュメントの公開（テストおよびカバレッジレポートを含む）は、`nox -s publish` セッションを使用して[継続的インテグレーションエンジン](https://github.com/smarie/python-makefun/actions)によって自動的に行われます。これはローカル開発では必要ありません。

## パッケージング

このプロジェクトは `setuptools_scm` を使ってバージョン番号を同期しています。したがって、開発スナップショットおよび公式リリースの両方に以下のコマンドを使用するべきです：`python setup.py sdist bdist_wheel`。しかし、[継続的インテグレーションエンジン](https://github.com/smarie/python-makefun/actions)がgitタグ上で自動的に行うため、通常は必要ありません。参考までに、これは `nox -s release` セッションで行われます。

### 編集を含むプルリクエストのマージ - メモ

AxがGitHubの「コマンドライン手順を取得」で説明しています：
</translate-content>
```bash
git checkout -b <git_name>-<feature_branch> main
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit --ff-only
```
<translate-content>
2番目のステップがうまくいかない場合は、通常の自動マージを行ってください（**リベース**は使用しないでください）：
</translate-content>
```bash
git pull https://github.com/<git_name>/python-makefun.git <feature_branch> --no-commit
```
最終的に変更を確認し、必要に応じて修正を行い、コミットします。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---