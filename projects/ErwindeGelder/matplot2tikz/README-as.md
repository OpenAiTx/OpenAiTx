
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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
পূৰ্বে যি "tikzplotlib" নামেৰে জনা গৈছিল।

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

এইটো matplot2tikz, এটা Python উপকৰণ যি matplotlib চিত্ৰসমূহক
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
চিত্ৰসমূহত ৰূপান্তৰ কৰে যেন

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

LaTeX অথবা ConTeXt নথিসমূহত প্ৰাকৃতিকভাৱে সংযোজনৰ বাবে।

matplot2tikz ৰ আউটপুট [PGFPlots](https://github.com/pgf-tikz/pgfplots/)ত থাকে, যি এটা TeX
লাইব্রেৰী [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ)ৰ ওপৰত অৱস্থিত
আৰু অক্ষ, তথ্য আদি হিচাপে গ্ৰাফ বৰ্ণনা কৰে। ফলস্বৰূপ, matplot2tikz ৰ আউটপুট

-   অধিক তথ্য সংৰক্ষণ কৰে,
-   সহজে বুজিব পৰা যায়, আৰু
-   সহজে সম্পাদনা কৰিব পৰা যায়

[কাঁচা TikZ আউটপুট](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend)তকৈ।
উদাহৰণস্বৰূপ, matplotlib চিত্ৰ

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

(`save()`ৰ বদলে `get_tikz_code()` ব্যৱহাৰ কৰক যদি আপুনি কোডটো string হিচাপে বিচাৰে।)

প্লটটো Tweaking কৰা সহজ আৰু আপোনাৰ TeX workflow-ৰ অংশ হিচাপে কৰিব পাৰি।
[অসাধাৰণ PGFPlots ম্যানুৱেল](http://pgfplots.sourceforge.net/pgfplots.pdf)-ত
আপোনাৰ plot-টো আৰু ভাল দেখুৱাবলৈ উৎকৃষ্ট উদাহৰণ আছে।

নিশ্চয়, matplotlib-এ তৈয়াৰ কৰা সকলো ছবিয়েই নিৰ্বিঘ্নে ৰূপান্তৰ কৰিব নোৱাৰি।
বিশেষকৈ, [3D plot-সমূহ কাম নকৰে](https://github.com/matplotlib/matplotlib/issues/7243)।

## ইনস্টলেশ্যন

matplot2tikz [Python Package
Index-ত উপলব্ধ](https://pypi.org/project/matplot2tikz/), সেয়ে সহজে কৰক

```
pip install matplot2tikz
```
ইন্সটল কৰিবলৈ।

## ব্যৱহাৰ

1. সাধাৰণতে আপোনাৰ matplotlib plot সৃষ্টি কৰক।

2. `pyplot.show()`ৰ পৰিৱৰ্তে, matplot2tikz আহ্বান কৰক


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    TikZ ফাইলখন `mytikz.tex` হিচাপে সংৰক্ষণ কৰিবলৈ।

3. আপোনাৰ TeX উৎস সংহিতাত `mytikz.tex` ৰ সামগ্ৰীসমূহ যোগ কৰক। এইটো কৰিবৰ বাবে এটা সুবিধাজনক উপায় হৈছে
   তলত উল্লেখ কৰা দৰে


    ```latex
    \input{/path/to/mytikz}
    ```

    লগতে নিশ্চিত কৰক যে PGFPlots আৰু সঠিক ইউনিক'ড সমৰ্থনৰ পেকেজসমূহ
    আপোনাৰ নথিপত্ৰৰ হেডাৰত অন্তর্ভুক্ত কৰা হৈছে:

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

    আপুনি কোডটো এইদৰে পাব পাৰে:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```
৪. [বৈকল্পিক] `clean_figure` কমান্ড ব্যৱহাৰ কৰি আউটপোৰ্ট কৰাৰ আগতে চিত্ৰটো পৰিষ্কাৰ কৰক।



    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
    এই আদেশটোয়ে সেই বিন্দুবোৰ আঁতৰাই দিব যিবোৰ অক্ষ সীমাৰ বাহিৰত আছে, বক্রৰেখাবোৰ সৰল কৰিব আৰু
    নিৰ্দিষ্ট লক্ষ্য ৰিজলিউশ্যনৰ বাবে বিন্দুৰ ঘনত্ব হ্ৰাস কৰিব।

## matplot2tikz বনাম tikzplotlib

এই matplot2tikz লাইব্রেৰীটো [tikzplotlib](https://github.com/nschloe/tikzplotlib)
প্ৰকল্পৰ পৰা উৎপত্তি হৈছে।
নতুন লাইব্রেৰী সৃষ্টি কৰাৰ কাৰণ হৈছে tikzplotlib এতিয়া ৰক্ষণাবেক্ষণ হোৱা নাই আৰু
tikzplotlib লাইব্রেৰীৰ একমাত্ৰ গৰাকী দ্বাৰা কেৱল ৰক্ষণাবেক্ষণ সম্ভৱ।
যদি আপোনাৰ প্ৰয়োজন তৃতীয়-পক্ষৰ কোড ব্যৱহাৰ কৰাৰ যি ইতিমধ্যে tikzplotlibত নিৰ্ভৰ কৰে, তেন্তে পৰামৰ্শ দিয়া হৈছে
tikzplotlib নিৰ্ভৰশীলতা matplot2tikzলৈ সলনি কৰক।
যদি এইটো সম্ভৱ নহয়, তেন্তে এটা সমাধান হৈছে তৃতীয়-পক্ষৰ কোডটো আমদানি কৰাৰ *আগতে* তলত দিয়া কোডটো ৰাখক:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## অৱদান

আপুনি যদি বাগ্‌সমূহ অনুভৱ কৰে, অৱদান আগবঢ়াব বিচাৰে, matplot2tikz এ কি কৰিব পাৰে তাৰ ভাল উদাহৰণ থাকে,
অথবা অধিক তথ্য বিচাৰি থাকিলে, অনুগ্ৰহ কৰি 
[matplot2tikz ৰ GitHub পৃষ্ঠা](https://github.com/ErwindeGelder/matplot2tikz) চাওক।

অৱদান আগবঢ়াবলৈ, তলৰ পদক্ষেপবোৰ অনুসৰণ কৰক:

1. git repository ডাউনলোড কৰক, যেনে
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git` ব্যৱহাৰ কৰি।
2. এটা virtual environment সৃষ্টি কৰক, যেনে `python -m venv venv` ব্যৱহাৰ কৰি।
3. virtual environment সক্ৰিয় কৰক (যেনে Windows-ত, `venv\Scripts\activate`)।
4. `uv` ইনষ্টল কৰক `pip install uv` ব্যৱহাৰ কৰি আৰু তাৰপিছত `tox-uv` ইনষ্টল কৰক `uv pip install tox-uv` ব্যৱহাৰ কৰি।
5. মূল শাখাখন সংৰক্ষিত, অৰ্থাৎ আপুনি এই শাখাত সোজাকৈ পৰিৱর্তন ঠেলিব নোৱাৰে।
   সেয়া বাবে, যদি আপুনি পৰিৱর্তন কৰিব বিচাৰে, তেন্তে পৃথক শাখাত কৰক। উদাহৰণস্বৰূপে, আপুনি নতুন শাখা সৃষ্টি কৰিব পাৰে
   `git checkout -b feature/my_awesome_new_feature` ব্যৱহাৰ কৰি।
6. পৰিৱর্তন ঠেলাৰ আগতে, নিশ্চিত কৰক যে কোডটো linting নিয়ম অনুসৰণ কৰে আৰু সকলো টেষ্ট সফল হৈছে।
   `tox` চলাওক। এইটো linting পৰীক্ষা কৰে আৰু সকলো test script চলায়। এইবোৰ হাতেকলীয়া ভাবে কৰিবলৈ, তলৰ কমাণ্ডবোৰ ব্যৱহাৰ কৰক:
   1. `tox -e lint` চলাওক। আপুনি linting কমাণ্ডবোৰ হাতেকলীয়া ভাবে কৰিব পাৰে:
      1. (এবাৰ) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (`--check` ফ্লেগ আঁতৰালে `ruff` এ format কৰিব)
      3. `ruff check .`
      4. `mypy .`
   2. `tox -e py310` চলাওক।
   3. `tox -e py311` চলাওক।
   4. `tox -e py312` চলাওক।
   5. `tox -e py313` চলাওক।
   6. `tox -e py314` চলাওক।
   7. `tox -e combine-test-reports` চলাওক।
7. coverage report `/reports/coverage_html/index.html` ত চেক কৰক যাতে টেষ্টে সকলো ধৰা হৈছে।

   টোকা: বৰ্তমান, সকলো কোড covered হোৱা নাই। আদৰ্শ ৰূপে, সকলো কোড covered হোৱা উচিত, কিন্তু বৰ্তমানলৈকে নিশ্চিত কৰক যে
   সকলো *নতুন* কোড টেষ্টিং দ্বারা covered হৈছে।
8. পৰিৱর্তনবোৰ GitHub-ত ঠেলক। যদি সকলো ঠিক আছে আৰু আপুনি আপোনাৰ পৰিৱর্তন `main`
   শাখালৈ মাৰ্জ কৰিব বিচাৰে, তেন্তে এটা pull request সৃষ্টি কৰক।
   আদৰ্শ ৰূপে, মাৰ্জৰ আগতে কমেও এজন reviewer এ pull request ৰ পৰ্যালোচনা কৰে।



মন কৰক যে বৰ্তমান কেৱল "Code owners" এহে `main` শাখালৈ pull request মাৰ্জ কৰিব পাৰে। এইটো
নিশ্চিত কৰিবলৈ যে প্ৰত্যেকে মূল কোড ভাঙি নেপায় (অজানিতে হ’লেও)। যদি আপুনি "Code
owner" হ'ব বিচাৰে, আমাক জনাব।

## অনুজ্ঞাপত্ৰ

matplot2tikz [MIT
license](https://en.wikipedia.org/wiki/MIT_License) অনুসৰি প্ৰকাশিত।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---