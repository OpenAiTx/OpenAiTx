
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
O artista anteriormente conhecido como <em>tikzplotlib</em>.

![PyPI - Versão](https://img.shields.io/pypi/v/matplot2tikz)
![Licença GitHub](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Versão Python](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Verificado com mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Este é o matplot2tikz, uma ferramenta Python para converter figuras do matplotlib em
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
figuras como

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

para inclusão nativa em documentos LaTeX ou ConTeXt.

A saída do matplot2tikz está em [PGFPlots](https://github.com/pgf-tikz/pgfplots/), uma biblioteca TeX
que se baseia no [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) e
descreve gráficos em termos de eixos, dados, etc. Consequentemente, a saída do matplot2tikz

-   retém mais informações,
-   pode ser mais facilmente compreendida, e
-   é mais facilmente editável

do que a [saída bruta do TikZ](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Por exemplo, a figura matplotlib

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

(Use `get_tikz_code()` em vez de `save()` se você quiser o código como uma string.)

Ajustar o gráfico é simples e pode ser feito como parte do seu fluxo de trabalho TeX.
[O fantástico manual do PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) contém
excelentes exemplos de como deixar seu gráfico ainda melhor.

Claro, nem todas as figuras produzidas pelo matplotlib podem ser convertidas sem erro.
Notavelmente, [gráficos 3D não funcionam](https://github.com/matplotlib/matplotlib/issues/7243).

## Instalação

matplot2tikz está [disponível no Python Package
Index](https://pypi.org/project/matplot2tikz/), então simplesmente faça

```
pip install matplot2tikz
```

para instalar.

## Uso

1. Gere seu gráfico matplotlib normalmente.

2. Em vez de `pyplot.show()`, invoque o matplot2tikz usando

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    para armazenar o arquivo TikZ como `mytikz.tex`.

3. Adicione o conteúdo de `mytikz.tex` ao seu código fonte TeX. Uma maneira conveniente de fazer
   isso é através de

    ```latex
    \input{/path/to/mytikz}
    ```

    Certifique-se também de que os pacotes para PGFPlots e o suporte adequado a Unicode estejam
    incluídos no cabeçalho do seu documento:

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

    Você também pode obter o código através de:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Opcional] Limpe a figura antes de exportar para tikz usando o comando `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
O comando removerá pontos que estão fora dos limites dos eixos, simplificará curvas e
reduzirá a densidade de pontos para a resolução alvo especificada.

## matplot2tikz vs. tikzplotlib

Esta biblioteca matplot2tikz se originou do projeto [tikzplotlib](https://github.com/nschloe/tikzplotlib).
O motivo para a criação de uma nova biblioteca é que o tikzplotlib não é mais mantido e
a manutenção só poderia ser feita pelo único proprietário da biblioteca tikzplotlib.
Se você precisa usar código de terceiros que já depende do tikzplotlib, sugere-se alterar
a dependência de tikzplotlib para matplot2tikz.
Se isso não for possível, uma solução alternativa é colocar o seguinte código *antes* de importar o
código de terceiros:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```
## Contribuindo

Se você encontrar bugs, quiser contribuir, tiver bons exemplos do que o matplot2tikz
pode fazer, ou se estiver apenas procurando por mais informações, então por favor visite
[a página do matplot2tikz no GitHub](https://github.com/ErwindeGelder/matplot2tikz).

Para contribuir, siga estes passos:

1. Baixe o repositório git, por exemplo, usando
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Crie um ambiente virtual, por exemplo, usando `python -m venv venv`.
3. Ative o ambiente virtual (por exemplo, no Windows, `venv\Scripts\activate`).
4. Instale `uv` usando `pip install uv` e depois `tox-uv` usando `uv pip install tox-uv`.
5. O branch principal está protegido, o que significa que você não pode enviar mudanças diretamente para este branch.
   Portanto, se quiser fazer mudanças, faça isso em um branch separado. Por exemplo, você pode criar
   um novo branch usando `git checkout -b feature/my_awesome_new_feature`.
6. Antes de enviar mudanças, certifique-se de que o código está de acordo com as regras de linting e que os testes
   foram bem-sucedidos. Execute `tox`. Isso faz uma verificação de linting e executa todos os scripts de teste. Para realizar
   essas etapas manualmente, use os seguintes comandos:
   1. Execute `tox -e lint`. Você pode executar os comandos de linting manualmente usando:
      1. (Uma vez) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (remova a flag `--check` para deixar o `ruff` fazer a formatação)
      3. `ruff check .`
      4. `mypy .`
   2. Execute `tox -e py310`.
   3. Execute `tox -e py311`.
   4. Execute `tox -e py312`.
   5. Execute `tox -e py313`.
   6. Execute `tox -e py314`.
   7. Execute `tox -e combine-test-reports`
7. Verifique se os testes cobriram tudo usando o relatório de cobertura em
   `/reports/coverage_html/index.html`.

   NOTA: Atualmente, nem todo o código está coberto. Idealmente, todo o código deveria estar coberto, mas por enquanto, certifique-se de que
   todo o código *novo* está coberto pelos testes.
8. Envie as mudanças para o GitHub. Se tudo estiver OK e você quiser mesclar suas mudanças para o branch `main`,
   crie um pull request.
   Idealmente, pelo menos um revisor deve revisar o pull request antes da mesclagem.


Observe que atualmente apenas "Code owners" podem fazer merge de pull requests no branch `main`. Isso é para
garantir que nem todos possam quebrar o código principal (mesmo que sem querer). Se você quiser ser um "Code
owner", avise-nos!

## Licença

matplot2tikz é publicado sob a [licença
MIT](https://en.wikipedia.org/wiki/MIT_License).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---