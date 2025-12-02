# matplot2tikz
L'artiste anciennement connu sous le nom de <em>tikzplotlib</em>.

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Voici matplot2tikz, un outil Python pour convertir des figures matplotlib en
figures [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
comme

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

pour une inclusion native dans des documents LaTeX ou ConTeXt.

La sortie de matplot2tikz est en [PGFPlots](https://github.com/pgf-tikz/pgfplots/), une bibliothèque TeX
qui s'appuie sur [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) et
décrit les graphiques en termes d'axes, de données, etc. Par conséquent, la sortie de matplot2tikz

-   conserve plus d'informations,
-   peut être plus facilement comprise, et
-   est plus facilement modifiable

que la [sortie TikZ brute](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Par exemple, la figure matplotlib

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
(Utilisez `get_tikz_code()` au lieu de `save()` si vous voulez le code sous forme de chaîne.)

Modifier le graphique est simple et peut être fait dans le cadre de votre flux de travail TeX.
[Le fantastique manuel PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) contient
d'excellents exemples de comment améliorer l'apparence de votre graphique.

Bien sûr, toutes les figures produites par matplotlib ne peuvent pas être converties sans erreur.
Notamment, [les graphiques 3D ne fonctionnent pas](https://github.com/matplotlib/matplotlib/issues/7243).

## Installation

matplot2tikz est [disponible sur le Python Package
Index](https://pypi.org/project/matplot2tikz/), il suffit donc de faire


```
pip install matplot2tikz
```

pour installer.

## Utilisation

1. Générez votre graphique matplotlib comme d’habitude.

2. Au lieu de `pyplot.show()`, utilisez matplot2tikz en appelant

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    pour enregistrer le fichier TikZ sous `mytikz.tex`.

3. Ajoutez le contenu de `mytikz.tex` dans votre code source TeX. Une façon pratique de le faire
   est via

    ```latex
    \input{/path/to/mytikz}
    ```
    Assurez-vous également que les packages pour PGFPlots et un support Unicode approprié sont
    inclus dans l'en-tête de votre document :


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

    Vous pouvez également obtenir le code via :

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```
4. [Optionnel] Nettoyez la figure avant de l’exporter vers tikz en utilisant la commande `clean_figure`.



    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```

    La commande supprimera les points situés en dehors des limites des axes, simplifiera les courbes et
    réduira la densité de points pour la résolution cible spécifiée.

## matplot2tikz vs. tikzplotlib

Cette bibliothèque matplot2tikz provient du projet [tikzplotlib](https://github.com/nschloe/tikzplotlib).
La raison de la création d’une nouvelle bibliothèque est que tikzplotlib n’est plus maintenu et 
la maintenance ne pouvait être assurée que par le propriétaire unique de la bibliothèque tikzplotlib.
Si vous devez utiliser du code tiers qui dépend déjà de tikzplotlib, il est suggéré de changer
la dépendance tikzplotlib en matplot2tikz. 
Si cela n’est pas possible, une solution de contournement consiste à placer le code suivant *avant* d’importer le 
code tiers :


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```
## Contribution

Si vous rencontrez des bugs, souhaitez contribuer, avez de beaux exemples de ce que matplot2tikz
peut faire, ou si vous cherchez simplement plus d'informations, veuillez visiter
[la page GitHub de matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Pour contribuer, suivez ces étapes :

1. Téléchargez le dépôt git, par exemple en utilisant
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Créez un environnement virtuel, par exemple avec `python -m venv venv`.
3. Activez l'environnement virtuel (par exemple, sous Windows, `venv\Scripts\activate`).
4. Installez `uv` avec `pip install uv` puis `tox-uv` avec `uv pip install tox-uv`.
5. La branche principale est protégée, ce qui signifie que vous ne pouvez pas y pousser directement des modifications.
   Par conséquent, si vous souhaitez apporter des modifications, faites-le dans une branche séparée. Par exemple, vous pouvez créer
   une nouvelle branche avec `git checkout -b feature/my_awesome_new_feature`.
6. Avant de pousser les modifications, assurez-vous que le code respecte les règles de linting et que les tests sont
   concluants. Exécutez `tox`. Cela vérifie le linting et lance tous les scripts de test. Pour effectuer
   ces étapes manuellement, utilisez les commandes suivantes :
   1. Lancez `tox -e lint`. Vous pouvez faire les commandes de linting manuellement en utilisant :
      1. (Une fois) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (enlevez le flag `--check` pour que `ruff` effectue le formatage)
      3. `ruff check .`
      4. `mypy .`
   2. Lancez `tox -e py310`.
   3. Lancez `tox -e py311`.
   4. Lancez `tox -e py312`.
   5. Lancez `tox -e py313`.
   6. Lancez `tox -e py314`.
   7. Lancez `tox -e combine-test-reports`
7. Vérifiez si les tests couvrent tout à l'aide du rapport de couverture dans
   `/reports/coverage_html/index.html`.

   NOTE : Actuellement, tout le code n'est pas couvert. Idéalement, tout le code devrait être couvert, mais pour l'instant, assurez-vous que
   tout le *nouveau* code est couvert par les tests.
8. Poussez les modifications sur GitHub. Si tout est OK et que vous souhaitez fusionner vos modifications dans la branche `main`,
   créez une pull request.
   Idéalement, il y a au moins un relecteur qui examine la pull request avant la fusion.


Notez qu'actuellement seuls les "Propriétaires du code" peuvent fusionner des pull requests sur la branche `main`. Cela permet  
de s'assurer que tout le monde ne peut pas casser le code principal (même involontairement). Si vous souhaitez devenir un "Propriétaire  
du code", faites-le nous savoir !

## Licence

matplot2tikz est publié sous la [licence MIT](https://fr.wikipedia.org/wiki/Licence_MIT).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-02

---