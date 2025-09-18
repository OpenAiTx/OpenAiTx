[![PyPI version](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Documentation Status](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf（调整我的图形大小）

当我写论文时，我对图形有些挑剔。对我来说尤其重要的是字体和字体大小要与周围的文档相匹配。由于我通常使用matplotlib绘图，因此创建了这个库来帮助实现这一点。该库提供了一种方法，
自动调整matplotlib中的图形尺寸和字体大小，以适应常用科学期刊中的样式。目前支持`quantumarticle`和`revtex4`。

# 安装

您可以从PyPI获取最新的发布版本。
```bash
pip install rsmf
```
要获取最新的开发版本，您必须从 GitHub 安装该软件包。
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```
该包依赖于 matplotlib 的 PGF 后端。要使用它，您需要安装带有 `pdflatex` 的可用 TeX 发行版（详见[问题 #2](https://github.com/johannesjmeyer/rsmf/issues/2)）。

# 使用方法

详细的使用说明请参见 [文档](https://rsmf.readthedocs.io/en/latest/source/howto.html)。

## 设置
您需要通过调用 `rsmf.setup` 告诉 rsmf 您如何设置文档。这可以通过两种方式完成。其一，您向 rsmf 提供用于设置文档的 `\documentclass` 字符串，如下所示

```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
字符串前的 `r` 是必要的，这样 `\d` 不会被误认为是转义序列。如果你的文档存储在本地，有一种更方便的方法：  
你只需向 rsmf 提供主 tex 文件的路径（包含文档设置的那个），它会自动找到该文件：
```python
formatter = rsmf.setup("example.tex")
```
这特别酷，因为 rsmf 会在更改底层文档类时自动调整图表，而无需更改 Python 代码！这使得切换期刊变得更加容易。

如果你目标的文档类不被 `rsmf` 支持，你仍然可以使用它。在这种情况下，你必须自己提取相关的测量数据并使用 `rsmf.CustomFormatter`。详细说明见[文档](https://rsmf.readthedocs.io/en/latest/source/howto.html)。

## 图形
设置例程将返回一个格式化器。然后可以通过调用方法 `formatter.figure` 来使用该格式化器创建 matplotlib 图形对象。它有三个参数：

* `aspect_ratio`（浮点数，可选）：图表的宽高比（高度/宽度）。默认为黄金比例的倒数。
* `width_ratio`（浮点数，可选）：图表宽度，单位是 `\columnwidth` 的倍数。默认为 1.0。
* `wide`（布尔值，可选）：指示图形是否在双栏模式下跨两栏，
                即是否使用 figure* 环境，在单栏模式下无效。默认为 False。

这里是你设置图表宽度的地方，_而不是在 LaTeX 文档中设置_。如果你以不同宽度包含结果图形，字体大小将与周围文档不匹配！

例如，常规图形的创建方式是
```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
并通过包含
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
另一方面，占页面80%的宽幅图形是由…创建的
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
并通过多栏的 `figure*` 环境包含：
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```
请注意，您应始终将图形保存为某种矢量格式，例如 `pdf`，并且在保存前调用 `plt.tight_layout()` 通常会使您的图表更美观。

此外，请注意 ``aspect_ratio`` 参数定义为图形的高度除以宽度。尽管纵横比更常定义为宽度/高度，但这种选择使得图形的宽度和高度分别与 ``width_ratio`` 和 ``aspect_ratio`` 成比例。

也可以手动创建图形对象，使用 `formatter.columnwidth` 和 `formatter.wide_columnwidth`，`formatter.figure` 例程是对此的便捷封装。

## 其他功能
您可以通过 `formatter.fontsizes` 访问底层字体大小。命名法遵循 LaTeX 本身的规则，例如 `formatter.fontsizes.tiny` 或 `formatter.fontsizes.Large`。
这在您想调整标题、图例和注释的同时保持字体大小一致时特别有用。

## 在其他框架中使用 rsmf
您可以将 rsmf 与您喜欢的绘图框架一起使用，例如 `seaborn`。唯一的注意点是：如果您使用 matplotlib 样式或 seaborn 样式，可能会覆盖 rsmf 强加的设置，尤其是字体大小。为此，格式化器有一个方法 `formatter.set_default_fontsizes`，只更改底层字体大小。一个示例用法是

```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
有时这些样式也会覆盖其他内容，比如字体系列（衬线/无衬线）。目前还没有针对这点的修正方法。

## 示例
一个示例文档以及用于制作图表的笔记本可以在 `examples` 文件夹中找到。

# 工作原理
在底层，rsmf 将 matplotlib 的后端设置为 `pgf`，这允许使用 LaTeX。对于每个支持的文档类，特定的列宽和字体大小存储在代码中，同时加载改变字体的宏包。例如，对于 `quantumarticle`，会将 `lmodern` 宏包加载到 `pgf` 后端，以获得正确的无衬线字体。

调用 `rsmf.setup` 时，会调整 matplotlib 的 `rcParams`，使字体大小与周围文档匹配。注意，`formatter.figure` 不会修改 `rcParams`。

# 贡献
你是否在为你喜欢的文档类设置图表时遇到困难，而这里没有支持？不要犹豫，欢迎提交 PR！

特别感谢以下贡献者：
[Samuel J. Palmer](https://github.com/sp94)，
[platipo](https://github.com/platipo)，
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---