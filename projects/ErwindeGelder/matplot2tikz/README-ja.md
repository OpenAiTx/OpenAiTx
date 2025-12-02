# matplot2tikz
かつて<em>tikzplotlib</em>として知られていたアーティスト。

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

これはmatplot2tikzであり、matplotlibの図を
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
の図に変換するPythonツールです。

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

LaTeXやConTeXt文書にネイティブに組み込むためのものです。

matplot2tikzの出力は[PGFPlots](https://github.com/pgf-tikz/pgfplots/)形式で、
これは[PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ)の上に構築されたTeX
ライブラリであり、軸やデータなどの観点からグラフを記述します。したがって、
matplot2tikzの出力は

-   より多くの情報を保持し、
-   より理解しやすく、
-   より編集しやすい

です。

これは[生のTikZ出力](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend)より優れています。
例えば、matplotlibの図は
```python
import matplotlib.pyplot as plt
import numpy as np

plt.style.use("ggplot")

t = np.arange(0.0, 2.0, 0.1)
s = np.sin(2 * np.pi * t)
s2 = np.cos(2 * np.pi * t)
plt.plot(t, s, "o-", lw=4.1)
plt.plot(t, s2, "o-", lw=4.1)
plt.xlabel("time (s)")
plt.ylabel("Voltage (mV)")
plt.title("Simple plot $\\frac{\\alpha}{2}$")
plt.grid(True)

import matplot2tikz

matplot2tikz.save("test.tex")
```

-->
(see above) gives

```latex
\begin{tikzpicture}

\definecolor{chocolate2267451}{RGB}{226,74,51}
\definecolor{dimgray85}{RGB}{85,85,85}
\definecolor{gainsboro229}{RGB}{229,229,229}
\definecolor{steelblue52138189}{RGB}{52,138,189}
\begin{axis}[
axis background/.style={fill=gainsboro229},
axis line style={white},
tick align=outside,
tick pos=left,
title={Simple plot \(\displaystyle \frac{\alpha}{2}\)},
x grid style={white},
xlabel=\textcolor{dimgray85}{time (s)},
xmajorgrids,
xmin=-0.095, xmax=1.995,
xtick style={color=dimgray85},
y grid style={white},
ylabel=\textcolor{dimgray85}{Voltage (mV)},
ymajorgrids,
ymin=-1.1, ymax=1.1,
ytick style={color=dimgray85}
]
\addplot [line width=1.64pt, chocolate2267451, mark=*, mark size=3, mark options={solid}]
table {%
0 0
% [...]
1.9 -0.587785252292473
};
\addplot [line width=1.64pt, steelblue52138189, mark=*, mark size=3, mark options={solid}]
table {%
0 1
% [...]
1.9 0.809016994374947
};
\end{axis}

\end{tikzpicture}
```
（コードを文字列として取得したい場合は、`save()`の代わりに`get_tikz_code()`を使用してください。）

プロットの調整は簡単で、TeXのワークフローの一部として行うことができます。
[素晴らしいPGFPlotsのマニュアル](http://pgfplots.sourceforge.net/pgfplots.pdf)には、
プロットをさらに良く見せるための優れた例が掲載されています。

もちろん、matplotlibで作成されたすべての図がエラーなく変換できるわけではありません。
特に、[3Dプロットは動作しません](https://github.com/matplotlib/matplotlib/issues/7243)。

## インストール

matplot2tikzは[Pythonパッケージインデックスから入手可能](https://pypi.org/project/matplot2tikz/)なので、単純に以下を実行してください。



```
pip install matplot2tikz
```

インストール方法。

## 使用方法

1. 通常通りmatplotlibのプロットを作成します。

2. `pyplot.show()`の代わりに、matplot2tikzを呼び出します。

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    TikZファイルを`mytikz.tex`として保存します。

3. `mytikz.tex`の内容をTeXソースコードに追加します。便利な方法は
   以下のようにすることです。

    ```latex
    \input{/path/to/mytikz}
    ```

    また、PGFPlotsパッケージと適切なUnicodeサポートのパッケージが
    ドキュメントのヘッダーに含まれていることを確認してください：

    ```latex
    \usepackage[utf8]{inputenc}
    \usepackage{pgfplots}
    \DeclareUnicodeCharacter{2212}{−}
    \usepgfplotslibrary{groupplots,dateplot}
    \usetikzlibrary{patterns,shapes.arrows}
    \pgfplotsset{compat=newest}
    ```

    or:

    ```latex
    \setupcolors[state=start]
    \usemodule[tikz]
    \usemodule[pgfplots]
    \usepgfplotslibrary[groupplots,dateplot]
    \usetikzlibrary[patterns,shapes.arrows]
    \pgfplotsset{compat=newest}
    \unexpanded\def\startgroupplot{\groupplot}
    \unexpanded\def\stopgroupplot{\endgroupplot}
    ```

    コードは以下からも入手可能です:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [オプション] `clean_figure` コマンドを使用して、tikz にエクスポートする前に図をクリーンアップします。


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
    このコマンドは、軸の範囲外の点を削除し、曲線を単純化し、
    指定されたターゲット解像度に対して点の密度を減らします。

## matplot2tikz と tikzplotlib の比較

この matplot2tikz ライブラリは [tikzplotlib](https://github.com/nschloe/tikzplotlib)
プロジェクトに由来します。
新しいライブラリが作成された理由は、tikzplotlib がもはやメンテナンスされておらず、
メンテナンスは tikzplotlib ライブラリの唯一の所有者のみが行えるためです。
既に tikzplotlib に依存するサードパーティのコードを使用する必要がある場合は、
tikzplotlib の依存関係を matplot2tikz に変更することを推奨します。
もしこれが不可能な場合は、サードパーティのコードをインポートする
*前に* 以下のコードを置くことで回避できます：


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```
## 貢献について

バグが発生した場合、貢献したい場合、matplot2tikzの素晴らしい例をお持ちの場合、
またはもっと情報を探している場合は、ぜひ
[matplot2tikzのGitHubページ](https://github.com/ErwindeGelder/matplot2tikz)をご覧ください。

貢献するには、以下の手順に従ってください:

1. gitリポジトリをダウンロードします。例: `git clone git@github.com:ErwindeGelder/matplot2tikz.git`。
2. 仮想環境を作成します。例: `python -m venv venv`。
3. 仮想環境を有効化します（例: Windowsでは `venv\Scripts\activate`）。
4. `uv`を `pip install uv` でインストールし、その後 `uv pip install tox-uv` で `tox-uv` をインストールします。
5. mainブランチは保護されているため、直接このブランチに変更をプッシュできません。
   そのため、変更したい場合は別のブランチで作業してください。例えば、
   `git checkout -b feature/my_awesome_new_feature` で新しいブランチを作成できます。
6. 変更をプッシュする前に、コードがリンティングルールに準拠しており、テストが成功していることを確認してください。
   `tox` を実行します。これはリンティングチェックを行い、すべてのテストスクリプトを実行します。
   手動でこれらのステップを実行するには、以下のコマンドを使用します:
   1. `tox -e lint` を実行します。リンティングコマンドを手動で行う場合は以下を使用してください:
      1. （一度だけ）`uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` （`ruff` によるフォーマットを適用するには `--check` フラグを外してください）
      3. `ruff check .`
      4. `mypy .`
   2. `tox -e py310` を実行します。
   3. `tox -e py311` を実行します。
   4. `tox -e py312` を実行します。
   5. `tox -e py313` を実行します。
   6. `tox -e py314` を実行します。
   7. `tox -e combine-test-reports` を実行します。
7. `/reports/coverage_html/index.html` にあるカバレッジレポートで、テストがすべてをカバーしているか確認してください。

   注意: 現在、すべてのコードがカバーされているわけではありません。理想的には全コードをカバーしますが、
   今はすべての*新しい*コードがテストでカバーされていることを確認してください。
8. 変更をGitHubにプッシュします。すべて問題なければ、`main` ブランチにマージするためにプルリクエストを作成してください。
   理想的には、マージ前に少なくとも1人のレビュワーがプルリクエストをレビューします。





現在、`main` ブランチへのプルリクエストをマージできるのは「コードオーナー」のみであることに注意してください。これは、誰もがメインコードを（意図せずにでも）壊すことがないようにするためです。「コードオーナー」になりたい場合は、お知らせください！

## ライセンス

matplot2tikz は [MIT
ライセンス](https://ja.wikipedia.org/wiki/MIT_License) の下で公開されています。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-02

---