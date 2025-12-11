
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
El artista anteriormente conocido como <em>tikzplotlib</em>.

![PyPI - Versión](https://img.shields.io/pypi/v/matplot2tikz)
![Licencia GitHub](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Versión de Python](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![Descargas PyPI](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Esto es matplot2tikz, una herramienta de Python para convertir figuras de matplotlib en
figuras de [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
como

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

para su inclusión nativa en documentos LaTeX o ConTeXt.

La salida de matplot2tikz está en [PGFPlots](https://github.com/pgf-tikz/pgfplots/), una biblioteca de TeX
que se sitúa sobre [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) y
describe gráficos en términos de ejes, datos, etc. En consecuencia, la salida de matplot2tikz

-   conserva más información,
-   puede entenderse más fácilmente, y
-   es más fácilmente editable

que la [salida TikZ cruda](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Por ejemplo, la figura de matplotlib

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

(Usa `get_tikz_code()` en lugar de `save()` si quieres el código como una cadena.)

Ajustar el gráfico es sencillo y puede hacerse como parte de tu flujo de trabajo en TeX.
[El fantástico manual de PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) contiene
excelentes ejemplos de cómo hacer que tu gráfico se vea aún mejor.

Por supuesto, no todas las figuras producidas por matplotlib pueden convertirse sin error.
Notablemente, [los gráficos 3D no funcionan](https://github.com/matplotlib/matplotlib/issues/7243).

## Instalación

matplot2tikz está [disponible en el Índice de Paquetes de Python](https://pypi.org/project/matplot2tikz/), así que simplemente haz


```
pip install matplot2tikz
```

para instalar.

## Uso

1. Genere su gráfico de matplotlib como de costumbre.

2. En lugar de `pyplot.show()`, invoque matplot2tikz mediante

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    para almacenar el archivo TikZ como `mytikz.tex`.

3. Añada el contenido de `mytikz.tex` en su código fuente TeX. Una forma conveniente de hacerlo
   es mediante

    ```latex
    \input{/path/to/mytikz}
    ```

    También asegúrese de que los paquetes para PGFPlots y el soporte adecuado de Unicode estén
    incluidos en el encabezado de su documento:

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

    También puede obtener el código a través de:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Opcional] Limpie la figura antes de exportarla a tikz usando el comando `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```

    El comando eliminará puntos que estén fuera de los límites de los ejes, simplificará curvas y
    reducirá la densidad de puntos para la resolución objetivo especificada.

## matplot2tikz vs. tikzplotlib

Esta biblioteca matplot2tikz se originó a partir del proyecto [tikzplotlib](https://github.com/nschloe/tikzplotlib).
La razón por la que se creó una nueva biblioteca es porque tikzplotlib ya no se mantiene y
el mantenimiento solo podía ser realizado por el único propietario de la biblioteca tikzplotlib.
Si necesita usar código de terceros que ya dependa de tikzplotlib, se sugiere cambiar
la dependencia de tikzplotlib a matplot2tikz.
Si esto no es posible, una solución alternativa es poner el siguiente código *antes* de importar el
código de terceros:


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Contribuyendo

Si experimentas errores, deseas contribuir, tienes buenos ejemplos de lo que matplot2tikz
puede hacer, o si simplemente buscas más información, entonces por favor visita
[la página de GitHub de matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Para contribuir, sigue estos pasos:

1. Descarga el repositorio git, por ejemplo, usando
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Crea un entorno virtual, por ejemplo, usando `python -m venv venv`.
3. Activa el entorno virtual (por ejemplo, en Windows, `venv\Scripts\activate`).
4. Instala `uv` usando `pip install uv` y luego `tox-uv` usando `uv pip install tox-uv`.
5. La rama principal está protegida, lo que significa que no puedes hacer push directamente a esta rama. 
   Por lo tanto, si quieres hacer cambios, hazlo en una rama separada. Por ejemplo, puedes crear 
   una nueva rama usando `git checkout -b feature/my_awesome_new_feature`.
6. Antes de hacer push de los cambios, asegúrate de que el código cumple con las reglas de linting y que las pruebas son 
   exitosas. Ejecuta `tox`. Esto hace una verificación de linting y ejecuta todos los scripts de prueba. Para realizar 
   estos pasos manualmente, usa los siguientes comandos:
   1. Ejecuta `tox -e lint`. Puedes hacer los comandos de linting manualmente usando:
      1. (Una vez) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (quita la bandera `--check` para que `ruff` haga el formateo)
      3. `ruff check .`
      4. `mypy .`
   2. Ejecuta `tox -e py310`.
   3. Ejecuta `tox -e py311`.
   4. Ejecuta `tox -e py312`.
   5. Ejecuta `tox -e py313`.
   6. Ejecuta `tox -e py314`.
   7. Ejecuta `tox -e combine-test-reports`
7. Verifica si las pruebas cubrieron todo usando el reporte de cobertura en 
   `/reports/coverage_html/index.html`.

   NOTA: Actualmente, no todo el código está cubierto. Idealmente, todo el código debería estar cubierto, pero por ahora, asegúrate de que 
   todo el código *nuevo* esté cubierto por las pruebas.
8. Haz push de los cambios a GitHub. Si todo está bien y quieres fusionar tus cambios a la rama `main`,
   crea un pull request.
   Idealmente, debe haber al menos un revisor que revise el pull request antes de la fusión.

Tenga en cuenta que actualmente solo los "Propietarios del código" pueden fusionar solicitudes de extracción en la rama `main`. Esto es para  
asegurar que no todos puedan romper el código principal (incluso sin intención). Si desea ser un "Propietario del  
código", ¡háganoslo saber!  

## Licencia  

matplot2tikz se publica bajo la [licencia MIT](https://es.wikipedia.org/wiki/Licencia_MIT).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---