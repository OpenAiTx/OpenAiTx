[![PyPI version](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Documentation Status](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf (right-size my figures)

When I am writing a paper I am a bit picky about the figures. It is especially important for me that the fonts and font sizes match the surrounding document. As I usually plot with matplotlib I created this library to help with that. This library provides a means to 
automatically adjust figure sizes and font sizes in matplotlib to fit the ones in commonly used scientific journals. Currently `quantumarticle` and `revtex4` are supported. 

# Install

You can get the latest release version from PyPI.
```bash
pip install rsmf
```
To get the latest development version you have to install the package from GitHub.
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```

The package depends on matplotlib's PGF backend. To be able to use it, you need to have a working TeX distribution with `pdflatex` installed (see further [Issue #2](https://github.com/johannesjmeyer/rsmf/issues/2)).

# Usage

A detailed explanation of usage is given in the [docs](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Setup
You need to tell rsmf how you set up your document by invoking `rsmf.setup`. This can be done in two ways. Either, you give rsmf the `\documentclass` string used for setting up the document, as in
```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
The `r` in front of the string is necessary so that `\d` is not mistaken for an escape sequence. If you have your document stored locally, there is an even more convenient way:
you can just supply rsmf with the path to your main tex file (the one containing the document setup) and it will find that out for itself:
```python
formatter = rsmf.setup("example.tex")
```
This is especially cool because rsmf will automatically adjust the plots when the underlying document class is changed without any needs to change python code! This makes swapping journals a lot easier.

If the document class you're targeting is not supported by `rsmf`, you can still use it. In that case you have to extract the relevant measurements yourself and use `rsmf.CustomFormatter`. A detailed explanation is given in the [docs](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Figures
The setup routine will return a formatter. This formatter can then be used to create matplotlib figure objects by invoking the method `formatter.figure`. It has three arguments:

* `aspect_ratio` (float, optional): the aspect ratio (height/width) of your plot. Defaults to the inverse of the golden ratio.
* `width_ratio` (float, optional): the width of your plot in multiples of `\columnwidth`. Defaults to 1.0.
* `wide` (bool, optional): indicates if the figures spans two columns in twocolumn mode, 
                i.e. if the figure* environment is used, has no effect in onecolumn mode . Defaults to False.

This is the place where you set the width of your plots, _not in the LaTeX document._ If you include the resulting figure with a different width, the font sizes will not match the surrounding document!

For example, a regular figure is created via
```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
and included via
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
A wide figure that spans 80% of the page on the other hand is created by
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
and included via the multi-column `figure*` environment:
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```

Note that you should always save your figures in some sort of vectorized format, like `pdf` and that calling `plt.tight_layout()` before saving usually makes your plots nicer.

Moreover, observe that the ``aspect_ratio`` parameter is defined as the height of the plot devided by its width. Even though aspect ratios are more commonly defined as width/height, this choice results in having the width and the height of the figure proportional to ``width_ratio`` and ``aspect_ratio`` respectively. 

It is also possible to create the figure objects by hand, using `formatter.columnwidth` and `formatter.wide_columnwidth`, the `formatter.figure` routine is a convenience wrapper around this.

## Other features
You can access the underlying fontsizes via `formatter.fontsizes`. The nomenclature follows that of LaTeX itself, so we have e.g. `formatter.fontsizes.tiny` or `formatter.fontsizes.Large`.
This is especially useful if you want to tweak titles, legends and annotations while still having matching fontsizes.

## Using rsmf with other frameworks
You can use rsmf together with your favorite plotting framework, for example `seaborn`. There is only one catch: if you use matplotlib styles or seaborn styles, you might overwrite the settings imposed by rsmf, especially regarding fontsize. To this end, the formatters have a method `formatter.set_default_fontsizes` that only change the underlying fontsizes. An example use would be
```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
Sometimes these styles also overwrite other things, like the font family (serif/sans-serif). There is no correction method for that yet.

## Example
An example document alongside with a notebook for making the plots used can be found in the `examples` folder.

# How it works
Under the hood, rsmf sets the matplotlib backend to `pgf`, which allows the use of LaTeX. For each supported document class, the specific column widths and font sizes are stored in code, alongside with packages that are loaded that change fonts. For `quantumarticle`, for example, the package `lmodern` is loaded into the `pgf` backend to get the right sans-serif font. 

When calling `rsmf.setup`, matplotlib's `rcParams` are adjusted to make the fontsizes match the surrounding document. Note that `formatter.figure` does not mess with `rcParams`.

# Contribute
Do you have trouble setting up plots for your favorite document class and it is not supported here? Do not hesitate to make a PR!

A big thanks for contributions goes to:
[Samuel J. Palmer](https://github.com/sp94), 
[platipo](https://github.com/platipo), 
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)

