<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
L'artista precedentemente conosciuto come <em>tikzplotlib</em>.

![PyPI - Versione](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub Licenza](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Versione Python](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Verificato con mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)

[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Questo è matplot2tikz, uno strumento Python per convertire figure matplotlib in
figure [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
come

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

per l'inclusione nativa in documenti LaTeX o ConTeXt.

L'output di matplot2tikz è in [PGFPlots](https://github.com/pgf-tikz/pgfplots/), una libreria TeX
che si basa su [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) e
descrive i grafici in termini di assi, dati, ecc. Di conseguenza, l'output di matplot2tikz

-   conserva più informazioni,
-   può essere più facilmente compreso, e
-   è più facilmente modificabile

rispetto all'[output TikZ grezzo](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Ad esempio, la figura matplotlib

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
(Usa `get_tikz_code()` invece di `save()` se desideri il codice come stringa.)

Modificare il grafico è semplice e può essere fatto come parte del tuo flusso di lavoro TeX.
[Il fantastico manuale di PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) contiene
ottimi esempi su come rendere il tuo grafico ancora migliore.

Ovviamente, non tutte le figure prodotte da matplotlib possono essere convertite senza errori.
In particolare, [i grafici 3D non funzionano](https://github.com/matplotlib/matplotlib/issues/7243).

## Installazione

matplot2tikz è [disponibile dal Python Package
Index](https://pypi.org/project/matplot2tikz/), quindi basta eseguire


```
pip install matplot2tikz
```

per installare.

## Utilizzo

1. Genera il tuo grafico matplotlib come al solito.

2. Invece di `pyplot.show()`, richiama matplot2tikz tramite

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    per memorizzare il file TikZ come `mytikz.tex`.

3. Aggiungi il contenuto di `mytikz.tex` nel tuo codice sorgente TeX. Un modo conveniente per farlo
   è tramite

    ```latex
    \input{/path/to/mytikz}
    ```

    Assicurati inoltre che i pacchetti per PGFPlots e il corretto supporto Unicode siano
    inclusi nell'intestazione del tuo documento:

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
    Puoi anche ottenere il codice tramite:


    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Opzionale] Pulisci la figura prima di esportarla in tikz usando il comando `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Il comando rimuoverà i punti che sono al di fuori dei limiti degli assi, semplificherà le curve e
ridurrà la densità dei punti per la risoluzione di destinazione specificata.

## matplot2tikz vs. tikzplotlib

Questa libreria matplot2tikz ha origine dal progetto [tikzplotlib](https://github.com/nschloe/tikzplotlib).
La ragione per cui è stata creata una nuova libreria è che tikzplotlib non è più mantenuta e
la manutenzione poteva essere effettuata solo dal singolo proprietario della libreria tikzplotlib.
Se hai bisogno di usare codice di terze parti che già dipende da tikzplotlib, si suggerisce di cambiare
la dipendenza da tikzplotlib a matplot2tikz.
Se ciò non è possibile, una soluzione alternativa è inserire il seguente codice *prima* di importare il
codice di terze parti:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

Se stai aggiornando i tuoi script da tikzplotlib, puoi semplicemente usare un alias per l'importazione:

   ```python
   import matplot2tikz as tikzplotlib
   ```

## Contribuire

Se riscontri bug, desideri contribuire, hai ottimi esempi di ciò che matplot2tikz
può fare, o se semplicemente cerchi maggiori informazioni, visita
[la pagina GitHub di matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Per contribuire, segui questi passaggi:

1. Scarica il repository git, ad esempio utilizzando
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Crea un ambiente virtuale, ad esempio utilizzando `python -m venv venv`.
3. Attiva l'ambiente virtuale (ad esempio, su Windows, `venv\Scripts\activate`).
4. Installa `uv` usando `pip install uv` e poi `tox-uv` usando `uv pip install tox-uv`.
5. Il branch principale è protetto, il che significa che non puoi inviare modifiche direttamente a questo branch.
   Pertanto, se vuoi apportare modifiche, fallo in un branch separato. Ad esempio, puoi creare
   un nuovo branch usando `git checkout -b feature/mia_fantastica_nuova_feature`.
6. Prima di inviare le modifiche, assicurati che il codice rispetti le regole di linting e che i test siano
   superati. Esegui `tox`. Questo esegue un controllo di linting e tutti gli script di test. Per eseguire manualmente
   questi passaggi, usa i seguenti comandi:
   1. Esegui `tox -e lint`. Puoi eseguire manualmente i comandi di linting usando:
      1. (Una volta sola) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (rimuovi il flag `--check` per lasciare che `ruff` formatti)
      3. `ruff check .`
      4. `mypy .`
   2. Esegui `tox -e py310`.
   3. Esegui `tox -e py311`.
   4. Esegui `tox -e py312`.
   5. Esegui `tox -e py313`.
   6. Esegui `tox -e py314`.
   7. Esegui `tox -e combine-test-reports`
7. Verifica che i test abbiano coperto tutto utilizzando il report di copertura in
   `/reports/coverage_html/index.html`.

   NOTA: Attualmente, non tutto il codice è coperto. Idealmente, tutto il codice dovrebbe esserlo, ma per ora assicurati che
   tutto il *nuovo* codice sia coperto dai test.
8. Invia le modifiche su GitHub. Se tutto è OK e vuoi unire le tue modifiche nel branch `main`,
   crea una pull request.
   Idealmente, ci dovrebbe essere almeno un revisore che controlla la pull request prima della fusione.

Nota che attualmente solo i "Code owners" possono unire le pull request sul branch `main`. Questo serve a
garantire che non tutti possano compromettere il codice principale (anche involontariamente). Se vuoi diventare un "Code owner",
faccelo sapere!

## Licenza

matplot2tikz è pubblicato sotto la [licenza MIT](https://en.wikipedia.org/wiki/MIT_License).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---