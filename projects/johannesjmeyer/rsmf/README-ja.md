[![PyPI version](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Documentation Status](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf（right-size my figures）

論文を書くとき、図に関しては少しこだわりがあります。特にフォントやフォントサイズが周囲の文書と一致することが重要です。通常はmatplotlibでプロットするため、このライブラリを作成してそれを支援しています。このライブラリは、matplotlibの図のサイズとフォントサイズを一般的に使われる科学雑誌に合わせて自動調整する手段を提供します。現在は`quantumarticle`と`revtex4`に対応しています。

# インストール

最新のリリース版はPyPIから入手できます。

```bash
pip install rsmf
```
最新の開発版を入手するには、GitHubからパッケージをインストールする必要があります。
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```

このパッケージはmatplotlibのPGFバックエンドに依存しています。使用するには、`pdflatex`がインストールされた動作可能なTeXディストリビューションが必要です（詳細は[Issue #2](https://github.com/johannesjmeyer/rsmf/issues/2)を参照）。

# 使用法

使用法の詳細な説明は[ドキュメント](https://rsmf.readthedocs.io/en/latest/source/howto.html)に記載されています。

## セットアップ
`rsmf.setup`を呼び出して、ドキュメントのセットアップ方法をrsmfに伝える必要があります。これは2つの方法で行えます。1つは、ドキュメントを設定するために使用した`\documentclass`文字列をrsmfに渡す方法で、例えば
```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
文字列の前の `r` は、`\d` がエスケープシーケンスと誤認されないようにするために必要です。ドキュメントがローカルに保存されている場合は、さらに便利な方法があります：  
rsmf にメインの tex ファイル（ドキュメントの設定を含むファイル）のパスを渡すだけで、rsmf がそれを自動的に見つけてくれます：
```python
formatter = rsmf.setup("example.tex")
```
これは特に素晴らしい点で、rsmfは基盤となるドキュメントクラスが変更されてもPythonコードを変更することなくプロットを自動的に調整します！これにより、ジャーナルの切り替えが非常に簡単になります。

もしターゲットとするドキュメントクラスが`rsmf`でサポートされていない場合でも使用可能です。その場合は、関連する寸法を自分で抽出し、`rsmf.CustomFormatter`を使用する必要があります。詳細な説明は[ドキュメント](https://rsmf.readthedocs.io/en/latest/source/howto.html)に記載されています。

## 図
セットアップルーチンはフォーマッターを返します。このフォーマッターは`formatter.figure`メソッドを呼び出すことでmatplotlibの図オブジェクトを作成するために使用できます。引数は3つあります：

* `aspect_ratio`（float、オプション）：プロットの縦横比（高さ/幅）。デフォルトは黄金比の逆数です。
* `width_ratio`（float、オプション）：`\columnwidth`の倍数でのプロットの幅。デフォルトは1.0です。
* `wide`（bool、オプション）：twocolumnモードで図が2カラムにまたがるかを示します。  
                すなわちfigure*環境が使われる場合で、onecolumnモードでは効果がありません。デフォルトはFalseです。

ここでプロットの幅を設定します。_LaTeXドキュメント内ではありません。_ もし異なる幅で図を挿入すると、フォントサイズが周囲の文書と一致しなくなります！

例えば、通常の図は以下のように作成されます。
```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
および含まれています
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
一方で、ページの80％を占める幅広い図は、次の方法で作成されます
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
およびマルチカラムの `figure*` 環境を使用して含めることができます:
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```

図を保存する際は、常に `pdf` のようなベクトル形式で保存することをお勧めします。また、保存前に `plt.tight_layout()` を呼び出すことで、プロットのレイアウトがより美しくなります。

さらに、``aspect_ratio`` パラメータはプロットの高さを幅で割った値として定義されていることに注意してください。一般的にはアスペクト比は幅/高さで定義されますが、この選択により図の幅と高さがそれぞれ ``width_ratio`` と ``aspect_ratio`` に比例する形になります。

図オブジェクトは手動で `formatter.columnwidth` と `formatter.wide_columnwidth` を使って作成することも可能で、`formatter.figure` はこれを簡単にするラッパーです。

## その他の機能
基礎となるフォントサイズには `formatter.fontsizes` からアクセスできます。命名規則はLaTeXそのもので、例えば `formatter.fontsizes.tiny` や `formatter.fontsizes.Large` があります。
これはタイトルや凡例、注釈のフォントサイズを調整しつつ、サイズを統一したい場合に特に便利です。

## rsmfを他のフレームワークで使う
rsmfはお好みのプロットフレームワーク（例：`seaborn`）と一緒に使えます。ただし注意点が一つあります。matplotlibスタイルやseabornスタイルを使うと、特にフォントサイズに関してrsmfの設定を上書きしてしまうことがあります。そのため、フォーマッターには `formatter.set_default_fontsizes` というメソッドがあり、これを使うと基礎のフォントサイズのみを変更できます。使用例は以下の通りです。
```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
時々、これらのスタイルはフォントファミリー（セリフ体／サンセリフ体）など他の要素も上書きしてしまいます。これに対する修正方法はまだありません。

## 例
使用されたプロットを作成するためのノートブックとともに例のドキュメントは、`examples`フォルダにあります。

# 動作の仕組み
内部的に、rsmfはmatplotlibのバックエンドを`pgf`に設定し、LaTeXの使用を可能にします。サポートされている各ドキュメントクラスごとに、特定のカラム幅やフォントサイズがコード内に保存されており、フォントを変更するパッケージも読み込まれます。例えば`quantumarticle`では、正しいサンセリフフォントを得るために`lmodern`パッケージが`pgf`バックエンドに読み込まれます。

`rsmf.setup`を呼び出すと、matplotlibの`rcParams`が周囲のドキュメントに合うようにフォントサイズを調整します。`formatter.figure`は`rcParams`を変更しないことに注意してください。

# 貢献
お気に入りのドキュメントクラス用にプロットを設定する際に問題があり、ここでサポートされていない場合は、遠慮なくPRを作成してください！

貢献してくださった方々に大きな感謝を：
[Samuel J. Palmer](https://github.com/sp94)、 
[platipo](https://github.com/platipo)、 
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---