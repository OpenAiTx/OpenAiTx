<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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
Ранее известен как <em>tikzplotlib</em>.

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Проверено mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)

[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Это matplot2tikz, инструмент на Python для преобразования графиков matplotlib в
фигуры [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf)),
например,

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

для нативного включения в документы LaTeX или ConTeXt.

Результат работы matplot2tikz — это [PGFPlots](https://github.com/pgf-tikz/pgfplots/), библиотека TeX,
которая построена поверх [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) и
описывает графики в терминах осей, данных и т.д. Следовательно, результат matplot2tikz

-   сохраняет больше информации,
-   легче воспринимается, и
-   проще редактируется,

чем [сырой вывод TikZ](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Например, график matplotlib

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
(Используйте `get_tikz_code()` вместо `save()`, если вы хотите получить код в виде строки.)

Настройка графика проста и может быть выполнена в рамках вашего рабочего процесса TeX.
[Отличное руководство PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) содержит
отличные примеры того, как сделать ваш график ещё лучше.

Конечно, не все фигуры, созданные с помощью matplotlib, могут быть преобразованы без ошибок.
В частности, [3D-графики не поддерживаются](https://github.com/matplotlib/matplotlib/issues/7243).

## Установка

matplot2tikz [доступен в Python Package
Index](https://pypi.org/project/matplot2tikz/), так что просто выполните


```
pip install matplot2tikz
```
для установки.

## Использование

1. Создайте ваш график matplotlib как обычно.

2. Вместо `pyplot.show()` вызовите matplot2tikz с помощью


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    
    чтобы сохранить файл TikZ как `mytikz.tex`.

3. Добавьте содержимое файла `mytikz.tex` в исходный код TeX. Удобный способ сделать
   это — использовать

    ```latex
    \input{/path/to/mytikz}
    ```

    Также убедитесь, что пакеты для PGFPlots и корректной поддержки Unicode
    включены в заголовок вашего документа:

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

    Вы также можете получить код через:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Необязательно] Очистите рисунок перед экспортом в tikz с помощью команды `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```

    Эта команда удалит точки, находящиеся вне пределов осей, упростит кривые и
    уменьшит плотность точек для указанного целевого разрешения.

## matplot2tikz vs. tikzplotlib

Эта библиотека matplot2tikz возникла из проекта [tikzplotlib](https://github.com/nschloe/tikzplotlib).
Причиной создания новой библиотеки стало то, что tikzplotlib больше не поддерживается, а
поддержка могла осуществляться только единственным владельцем библиотеки tikzplotlib.
Если вам нужно использовать сторонний код, который уже зависит от tikzplotlib, рекомендуется заменить
зависимость tikzplotlib на matplot2tikz.
Если это невозможно, можно воспользоваться следующим обходным решением — разместить следующий код *до* импорта
стороннего кода:


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Вклад в проект

Если вы столкнулись с ошибками, хотите внести свой вклад, имеете интересные примеры того, что может matplot2tikz,
или просто ищете дополнительную информацию, посетите
[страницу matplot2tikz на GitHub](https://github.com/ErwindeGelder/matplot2tikz).

Для вклада в проект выполните следующие шаги:

1. Загрузите репозиторий git, например, используя
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Создайте виртуальное окружение, например, с помощью `python -m venv venv`.
3. Активируйте виртуальное окружение (например, в Windows: `venv\Scripts\activate`).
4. Установите `uv` командой `pip install uv`, затем `tox-uv` через `uv pip install tox-uv`.
5. Основная ветка защищена, что означает, что вы не можете напрямую вносить изменения в эту ветку.
   Поэтому, если вы хотите внести изменения, сделайте это в отдельной ветке. Например, вы можете создать
   новую ветку с помощью `git checkout -b feature/my_awesome_new_feature`.
6. Перед отправкой изменений убедитесь, что код соответствует правилам линтинга и что тесты
   проходят успешно. Запустите `tox`. Это выполнит проверку линтинга и все тестовые скрипты. Чтобы
   выполнить эти шаги вручную, используйте следующие команды:
   1. Запустите `tox -e lint`. Вы можете выполнить команды линтинга вручную:
      1. (Один раз) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (удалите флаг `--check`, чтобы `ruff` выполнил форматирование)
      3. `ruff check .`
      4. `mypy .`
   2. Запустите `tox -e py310`.
   3. Запустите `tox -e py311`.
   4. Запустите `tox -e py312`.
   5. Запустите `tox -e py313`.
   6. Запустите `tox -e py314`.
   7. Запустите `tox -e combine-test-reports`
7. Проверьте, покрыты ли тестами все изменения, используя отчет о покрытии по адресу
   `/reports/coverage_html/index.html`.

   ПРИМЕЧАНИЕ: В настоящее время не весь код покрыт тестами. В идеале, тестами должен быть покрыт весь код,
   но пока убедитесь, что весь *новый* код покрыт тестированием.
8. Отправьте изменения на GitHub. Если все в порядке и вы хотите объединить свои изменения с веткой `main`,
   создайте pull request.
   В идеале, перед слиянием pull request должен быть проверен хотя бы одним рецензентом.

Обратите внимание, что в настоящее время только "владельцы кода" могут выполнять слияние pull-запросов в ветку `main`. Это сделано для
того, чтобы не каждый мог случайно нарушить основной код (даже непреднамеренно). Если вы хотите стать "владельцем кода",
сообщите нам!

## Лицензия

matplot2tikz опубликован под [лицензией MIT
license](https://en.wikipedia.org/wiki/MIT_License).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---