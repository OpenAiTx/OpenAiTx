
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# matplot2tikz
Der Künstler, ehemals bekannt als <em>tikzplotlib</em>.

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub Lizenz](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Geprüft mit mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Dies ist matplot2tikz, ein Python-Tool zur Umwandlung von matplotlib-Grafiken in
[PGFPlots](https://www.ctan.org/pkg/pgfplots)- ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
Grafiken wie

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

zur nativen Einbindung in LaTeX- oder ConTeXt-Dokumente.

Die Ausgabe von matplot2tikz erfolgt in [PGFPlots](https://github.com/pgf-tikz/pgfplots/), einer TeX-
Bibliothek, die auf [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) aufbaut und
Grafiken anhand von Achsen, Daten usw. beschreibt. Folglich enthält die Ausgabe von matplot2tikz

-   mehr Informationen,
-   ist leichter verständlich, und
-   einfacher editierbar

als [roher TikZ-Ausgabe](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Zum Beispiel die matplotlib-Grafik

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
(Verwenden Sie `get_tikz_code()` anstelle von `save()`, wenn Sie den Code als String erhalten möchten.)

Das Anpassen des Plots ist unkompliziert und kann als Teil Ihres TeX-Workflows erfolgen.
[Das fantastische PGFPlots-Handbuch](http://pgfplots.sourceforge.net/pgfplots.pdf) enthält
großartige Beispiele dafür, wie Sie Ihr Diagramm noch besser aussehen lassen können.

Natürlich können nicht alle von matplotlib erzeugten Abbildungen fehlerfrei konvertiert werden.
Insbesondere [funktionieren 3D-Plots nicht](https://github.com/matplotlib/matplotlib/issues/7243).

## Installation

matplot2tikz ist [über den Python Package
Index erhältlich](https://pypi.org/project/matplot2tikz/), daher führen Sie einfach aus


```
pip install matplot2tikz
```

zu installieren.

## Verwendung

1. Erstellen Sie Ihr matplotlib-Diagramm wie gewohnt.

2. Anstelle von `pyplot.show()` rufen Sie matplot2tikz auf, indem Sie

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    um die TikZ-Datei als `mytikz.tex` zu speichern.

3. Fügen Sie den Inhalt von `mytikz.tex` in Ihren TeX-Quellcode ein. Eine bequeme Möglichkeit
   dies zu tun ist mittels


    ```latex
    \input{/path/to/mytikz}
    ```

    Stellen Sie außerdem sicher, dass die Pakete für PGFPlots und die richtige Unicode-Unterstützung
    im Kopfbereich Ihres Dokuments eingebunden sind:

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

    Sie können den Code auch erhalten über:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Optional] Bereinigen Sie die Abbildung vor dem Export nach tikz mit dem Befehl `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Der Befehl entfernt Punkte, die außerhalb der Achsengrenzen liegen, vereinfacht Kurven und
reduziert die Punktdichte auf die angegebene Zielauflösung.

## matplot2tikz vs. tikzplotlib

Diese matplot2tikz-Bibliothek stammt ursprünglich aus dem [tikzplotlib](https://github.com/nschloe/tikzplotlib)-
Projekt.
Der Grund für die Erstellung einer neuen Bibliothek ist, dass tikzplotlib nicht mehr gepflegt wird und
die Wartung nur vom alleinigen Besitzer der tikzplotlib-Bibliothek durchgeführt werden konnte.
Wenn Sie Drittanbieter-Code verwenden müssen, der bereits von tikzplotlib abhängt, wird empfohlen, die
tikzplotlib-Abhängigkeit auf matplot2tikz umzustellen.
Wenn dies nicht möglich ist, besteht eine Lösung darin, den folgenden Code *vor* dem Import des
Drittanbieter-Codes einzufügen:


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Beitrag leisten

Wenn Sie auf Fehler stoßen, beitragen möchten, schöne Beispiele dafür haben, was matplot2tikz
leisten kann, oder einfach nach weiteren Informationen suchen, besuchen Sie bitte die
[matplot2tikz GitHub-Seite](https://github.com/ErwindeGelder/matplot2tikz).

Zum Mitwirken befolgen Sie diese Schritte:

1. Laden Sie das Git-Repository herunter, z. B. mit
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Erstellen Sie eine virtuelle Umgebung, z. B. mit `python -m venv venv`.
3. Aktivieren Sie die virtuelle Umgebung (z. B. unter Windows, `venv\Scripts\activate`).
4. Installieren Sie `uv` mit `pip install uv` und dann `tox-uv` mit `uv pip install tox-uv`.
5. Der Haupt-Branch ist geschützt, d. h. Sie können Änderungen nicht direkt in diesen Branch pushen. 
   Wenn Sie Änderungen vornehmen möchten, tun Sie dies daher in einem separaten Branch. Zum Beispiel können Sie 
   einen neuen Branch mit `git checkout -b feature/mein_tolles_neues_feature` erstellen.
6. Bevor Sie Änderungen pushen, stellen Sie sicher, dass der Code den Linting-Regeln entspricht und die Tests 
   erfolgreich sind. Führen Sie `tox` aus. Dies macht einen Linting-Check und führt alle Testskripte aus. Um 
   diese Schritte manuell auszuführen, verwenden Sie folgende Befehle:
   1. Führen Sie `tox -e lint` aus. Sie können die Linting-Befehle manuell mit folgenden Befehlen ausführen:
      1. (Einmalig) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (entfernen Sie das `--check`-Flag, damit `ruff` das Formatieren übernimmt)
      3. `ruff check .`
      4. `mypy .`
   2. Führen Sie `tox -e py310` aus.
   3. Führen Sie `tox -e py311` aus.
   4. Führen Sie `tox -e py312` aus.
   5. Führen Sie `tox -e py313` aus.
   6. Führen Sie `tox -e py314` aus.
   7. Führen Sie `tox -e combine-test-reports` aus.
7. Überprüfen Sie, ob die Tests alles abgedeckt haben, indem Sie den Coverage-Report unter 
   `/reports/coverage_html/index.html` aufrufen.

   HINWEIS: Derzeit ist noch nicht aller Code abgedeckt. Im Idealfall ist aller Code abgedeckt, aber stellen Sie 
   sicher, dass zumindest aller *neuer* Code durch Tests abgedeckt ist.
8. Pushen Sie die Änderungen zu GitHub. Wenn alles in Ordnung ist und Sie Ihre Änderungen in den `main`-
   Branch übernehmen möchten, erstellen Sie einen Pull-Request.
   Im Idealfall gibt es mindestens einen Reviewer, der den Pull-Request vor dem Merge überprüft.

Beachte, dass derzeit nur "Code-Besitzer" Pull Requests in den `main`-Branch zusammenführen können. Dies soll
sicherstellen, dass nicht jeder den Hauptcode (auch unbeabsichtigt) beschädigen kann. Wenn du "Code-Besitzer"
werden möchtest, lass es uns wissen!

## Lizenz

matplot2tikz wird unter der [MIT-
Lizenz](https://de.wikipedia.org/wiki/MIT-Lizenz) veröffentlicht.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---