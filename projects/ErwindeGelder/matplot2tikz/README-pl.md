
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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
Artysta wcześniej znany jako <em>tikzplotlib</em>.

![PyPI - Wersja](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub Licencja](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Wersja Pythona](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Sprawdzono z mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

To jest matplot2tikz, narzędzie Pythona do konwersji wykresów matplotlib na
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
wykresy takie jak

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

do natywnego osadzania w dokumentach LaTeX lub ConTeXt.

Wyjście z matplot2tikz jest w formacie [PGFPlots](https://github.com/pgf-tikz/pgfplots/), biblioteki TeX
opartej na [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ), która opisuje wykresy za pomocą osi, danych itp. W związku z tym wynik matplot2tikz

-   zachowuje więcej informacji,
-   jest łatwiejszy do zrozumienia, oraz
-   łatwiejszy do edycji

niż [surowe wyjście TikZ](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Na przykład, wykres matplotlib


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
(Użyj `get_tikz_code()` zamiast `save()`, jeśli chcesz otrzymać kod jako łańcuch znaków.)

Dostosowywanie wykresu jest proste i można to zrobić jako część pracy w TeX.
[Fantastyczny podręcznik PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) zawiera
świetne przykłady, jak sprawić, by Twój wykres wyglądał jeszcze lepiej.

Oczywiście nie wszystkie wykresy utworzone przez matplotlib można przekonwertować bez błędów.
W szczególności, [wykresy 3D nie działają](https://github.com/matplotlib/matplotlib/issues/7243).

## Instalacja

matplot2tikz jest [dostępny w Python Package
Index](https://pypi.org/project/matplot2tikz/), więc po prostu wykonaj


```
pip install matplot2tikz
```
aby zainstalować.

## Użytkowanie

1. Wygeneruj swój wykres matplotlib jak zwykle.

2. Zamiast `pyplot.show()`, wywołaj matplot2tikz poprzez


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    aby zapisać plik TikZ jako `mytikz.tex`.

3. Dodaj zawartość `mytikz.tex` do swojego kodu źródłowego TeX. Wygodnym sposobem na to jest użycie
  


    ```latex
    \input{/path/to/mytikz}
    ```

    Upewnij się również, że pakiety PGFPlots oraz odpowiednie wsparcie Unicode są
    uwzględnione w nagłówku Twojego dokumentu:

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

    Kod można również uzyskać poprzez:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```
4. [Opcjonalnie] Wyczyść wykres przed eksportem do tikz za pomocą polecenia `clean_figure`.



    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Polecenie usunie punkty znajdujące się poza granicami osi, uprości krzywe oraz
zmniejszy gęstość punktów do określonej docelowej rozdzielczości.

## matplot2tikz vs. tikzplotlib

Biblioteka matplot2tikz wywodzi się z projektu [tikzplotlib](https://github.com/nschloe/tikzplotlib).
Powodem powstania nowej biblioteki jest fakt, że tikzplotlib nie jest już utrzymywana,
a utrzymanie mogło być realizowane tylko przez jedynego właściciela biblioteki tikzplotlib.
Jeśli musisz korzystać z zewnętrznego kodu, który już zależy od tikzplotlib, zaleca się zmianę
zależności tikzplotlib na matplot2tikz.
Jeśli nie jest to możliwe, obejściem jest umieszczenie poniższego kodu *przed* importowaniem
zewnętrznego kodu:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Współtworzenie

Jeśli napotkasz błędy, chciałbyś wnieść swój wkład, masz ciekawe przykłady możliwości matplot2tikz,
lub po prostu szukasz więcej informacji, odwiedź
[stronę GitHub matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Aby wnieść swój wkład, wykonaj następujące kroki:

1. Pobierz repozytorium git, np. używając
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Utwórz środowisko wirtualne, np. używając `python -m venv venv`.
3. Aktywuj środowisko wirtualne (np. w systemie Windows, `venv\Scripts\activate`).
4. Zainstaluj `uv` używając `pip install uv`, a następnie `tox-uv` używając `uv pip install tox-uv`.
5. Główna gałąź jest chroniona, co oznacza, że nie możesz bezpośrednio wprowadzać do niej zmian.
   Dlatego jeśli chcesz wprowadzić zmiany, zrób to w osobnej gałęzi. Na przykład możesz utworzyć
   nową gałąź używając `git checkout -b feature/my_awesome_new_feature`.
6. Przed wysłaniem zmian upewnij się, że kod spełnia zasady lintowania i testy przechodzą
   pomyślnie. Uruchom `tox`. To sprawdza lintowanie i uruchamia wszystkie skrypty testujące. Aby
   ręcznie wykonać te kroki, użyj następujących poleceń:
   1. Uruchom `tox -e lint`. Polecenia lintowania możesz wykonać ręcznie używając:
      1. (Jednorazowo) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (usuń flagę `--check`, by `ruff` sformatował pliki)
      3. `ruff check .`
      4. `mypy .`
   2. Uruchom `tox -e py310`.
   3. Uruchom `tox -e py311`.
   4. Uruchom `tox -e py312`.
   5. Uruchom `tox -e py313`.
   6. Uruchom `tox -e py314`.
   7. Uruchom `tox -e combine-test-reports`
7. Sprawdź, czy testy pokrywają wszystko, używając raportu pokrycia w
   `/reports/coverage_html/index.html`.

   UWAGA: Obecnie nie cały kod jest pokryty testami. Idealnie byłoby, aby cały kod był pokryty, ale na razie upewnij się, że
   cały *nowy* kod jest pokryty testami.
8. Wypchnij zmiany na GitHub. Jeśli wszystko jest w porządku i chcesz zmergować zmiany do gałęzi `main`,
   utwórz pull request.
   Najlepiej, jeśli co najmniej jedna osoba zrecenzuje pull request przed mergem.

Zwróć uwagę, że obecnie tylko "Właściciele kodu" mogą scalać pull requesty do gałęzi `main`. Ma to na celu
zapewnienie, że nie każdy może przypadkowo zepsuć główny kod (nawet nieumyślnie). Jeśli chcesz zostać "Właścicielem kodu",
daj nam znać!

## Licencja

matplot2tikz jest publikowany na [licencji MIT](https://en.wikipedia.org/wiki/MIT_License).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---