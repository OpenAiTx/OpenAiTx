
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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
De artiest voorheen bekend als <em>tikzplotlib</em>.

![PyPI - Versie](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub Licentie](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Versie](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Gecontroleerd met mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Dit is matplot2tikz, een Python-tool voor het omzetten van matplotlib-figuren naar
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
figuren zoals

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

voor native opname in LaTeX- of ConTeXt-documenten.

De uitvoer van matplot2tikz is in [PGFPlots](https://github.com/pgf-tikz/pgfplots/), een TeX-
bibliotheek die bovenop [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) draait en
grafieken beschrijft in termen van assen, data, enzovoort. Daardoor bevat de uitvoer van matplot2tikz

-   meer informatie,
-   gemakkelijker te begrijpen is, en
-   eenvoudiger te bewerken is

dan [ruwe TikZ-uitvoer](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Bijvoorbeeld, de matplotlib-figuur

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

(Gebruik `get_tikz_code()` in plaats van `save()` als je de code als een string wilt hebben.)

Het aanpassen van de plot is eenvoudig en kan onderdeel zijn van je TeX-werkstroom.
[De fantastische PGFPlots-handleiding](http://pgfplots.sourceforge.net/pgfplots.pdf) bevat
geweldige voorbeelden van hoe je je plot er nog beter uit kunt laten zien.

Natuurlijk kunnen niet alle figuren die door matplotlib zijn gemaakt zonder fouten worden geconverteerd.
Met name [3D-plots werken niet](https://github.com/matplotlib/matplotlib/issues/7243).

## Installatie

matplot2tikz is [beschikbaar via de Python Package
Index](https://pypi.org/project/matplot2tikz/), dus voer gewoon uit

```
pip install matplot2tikz
```

om te installeren.

## Gebruik

1. Genereer je matplotlib-plot zoals gebruikelijk.

2. In plaats van `pyplot.show()`, roep matplot2tikz aan door

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    om het TikZ-bestand op te slaan als `mytikz.tex`.

3. Voeg de inhoud van `mytikz.tex` toe aan je TeX-broncode. Een handige manier om dit te doen
   is via

    ```latex
    \input{/path/to/mytikz}
    ```

    Zorg er ook voor dat de pakketten voor PGFPlots en juiste Unicode-ondersteuning zijn
    opgenomen in de header van uw document:

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

    U kunt de code ook verkrijgen via:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Optioneel] Maak de figuur schoon voordat je deze exporteert naar tikz met het `clean_figure`
   commando.

    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Het commando zal punten verwijderen die buiten de assenlimieten liggen, krommen vereenvoudigen en
de puntdichtheid verminderen voor de opgegeven doeldetail.

## matplot2tikz vs. tikzplotlib

Deze matplot2tikz-bibliotheek is ontstaan uit het [tikzplotlib](https://github.com/nschloe/tikzplotlib)
project.
De reden dat er een nieuwe bibliotheek is gemaakt, is omdat tikzplotlib niet langer wordt onderhouden en
onderhoud alleen door de enige eigenaar van de tikzplotlib-bibliotheek kon worden gedaan.
Als u gebruik moet maken van externe code die al afhankelijk is van tikzplotlib, wordt aangeraden om de
tikzplotlib-afhankelijkheid te vervangen door matplot2tikz.
Als dit niet mogelijk is, is een oplossing om de volgende code *voor* het importeren van de
externe code te plaatsen:


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Bijdragen

Als je bugs tegenkomt, wilt bijdragen, mooie voorbeelden hebt van wat matplot2tikz kan doen, of gewoon op zoek bent naar meer informatie, bezoek dan de [GitHub-pagina van matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Volg deze stappen om bij te dragen:

1. Download de git repository, bijvoorbeeld met
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Maak een virtuele omgeving aan, bijvoorbeeld met `python -m venv venv`.
3. Activeer de virtuele omgeving (bijvoorbeeld op Windows, `venv\Scripts\activate`).
4. Installeer `uv` met `pip install uv` en daarna `tox-uv` met `uv pip install tox-uv`.
5. De hoofdbranch is beschermd, wat betekent dat je niet direct wijzigingen naar deze branch kunt pushen.
   Wil je wijzigingen aanbrengen, doe dat dan in een aparte branch. Bijvoorbeeld, je kunt een nieuwe branch maken met `git checkout -b feature/mijn_coole_nieuwe_feature`.
6. Voordat je wijzigingen pusht, zorg ervoor dat de code voldoet aan de lint-regels en dat de tests geslaagd zijn.
   Voer `tox` uit. Dit doet een lint-controle en voert alle test scripts uit. Om deze stappen handmatig uit te voeren, gebruik de volgende commando's:
   1. Voer `tox -e lint` uit. Je kunt de lint-opdrachten handmatig doen met:
      1. (Eenmalig) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (verwijder de `--check` vlag om `ruff` de formatting te laten uitvoeren)
      3. `ruff check .`
      4. `mypy .`
   2. Voer `tox -e py310` uit.
   3. Voer `tox -e py311` uit.
   4. Voer `tox -e py312` uit.
   5. Voer `tox -e py313` uit.
   6. Voer `tox -e py314` uit.
   7. Voer `tox -e combine-test-reports` uit.
7. Controleer of de tests alles hebben gedekt via het coverage rapport in
   `/reports/coverage_html/index.html`.

   LET OP: Op dit moment is nog niet alle code gedekt. Idealiter is alle code gedekt, maar zorg er nu voor dat alle *nieuwe* code door tests wordt gedekt.
8. Push wijzigingen naar GitHub. Als alles goed is en je wilt je wijzigingen mergen naar de `main` branch, maak dan een pull request.
   Idealiter is er ten minste één reviewer die de pull request beoordeelt vóór de merge.







Let op dat momenteel alleen "Code-eigenaren" pull requests kunnen samenvoegen naar de `main` branch. Dit is om te
verzekeren dat niet iedereen de hoofdcode kan breken (zelfs niet per ongeluk). Als je een "Code-eigenaar"
wilt worden, laat het ons weten!

## Licentie

matplot2tikz wordt gepubliceerd onder de [MIT
licentie](https://nl.wikipedia.org/wiki/MIT-licentie).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---