<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ErwindeGelder&project=matplot2tikz&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# matplot2tikz
هنرمندی که قبلاً با نام <em>tikzplotlib</em> شناخته می‌شد.

![نسخه PyPI](https://img.shields.io/pypi/v/matplot2tikz)
![مجوز GitHub](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![نسخه پایتون PyPI](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![بررسی شده با mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)

[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

این ابزار matplot2tikz است، یک ابزار پایتون برای تبدیل نمودارهای matplotlib به
شکل‌های [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
مانند

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

برای درج بومی در اسناد LaTeX یا ConTeXt.

خروجی matplot2tikz به صورت [PGFPlots](https://github.com/pgf-tikz/pgfplots/) است، یک کتابخانه TeX
که بر پایه‌ی [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) قرار دارد و
نمودارها را بر اساس محورها، داده‌ها و غیره توصیف می‌کند. در نتیجه، خروجی matplot2tikz

-   اطلاعات بیشتری را حفظ می‌کند،
-   به راحتی قابل درک‌تر است، و
-   ویرایش آن ساده‌تر است

نسبت به [خروجی خام TikZ](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
برای مثال، نمودار matplotlib

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

(اگر به جای `save()` می‌خواهید کد را به صورت رشته دریافت کنید، از `get_tikz_code()` استفاده کنید.)

تنظیم نمودار به سادگی انجام می‌شود و می‌تواند بخشی از جریان کاری TeX شما باشد.
[راهنمای عالی PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf)
نمونه‌های خوبی دارد که نشان می‌دهد چگونه می‌توان نمودار خود را زیباتر کرد.

البته، تمام شکل‌هایی که توسط matplotlib تولید می‌شوند را نمی‌توان بدون خطا تبدیل کرد.
به ویژه، [نمودارهای سه‌بعدی کار نمی‌کنند](https://github.com/matplotlib/matplotlib/issues/7243).

## نصب

matplot2tikz [از طریق پایگاه بسته پایتون
Index](https://pypi.org/project/matplot2tikz/) موجود است، پس کافیست انجام دهید

```
pip install matplot2tikz
```

برای نصب.

## نحوه استفاده

1. نمودار matplotlib خود را مانند همیشه تولید کنید.

2. به جای `pyplot.show()`، matplot2tikz را به صورت زیر فراخوانی کنید

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    برای ذخیره فایل TikZ با نام `mytikz.tex`.

3. محتوای `mytikz.tex` را به کد منبع TeX خود اضافه کنید. یک روش مناسب برای این کار
   استفاده از

    ```latex
    \input{/path/to/mytikz}
    ```
همچنین مطمئن شوید که بسته‌های PGFPlots و پشتیبانی مناسب از یونیکد
در هدر سند شما گنجانده شده‌اند:


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

    شما همچنین می‌توانید کد را از طریق موارد زیر دریافت کنید:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```
۴. [اختیاری] قبل از صادر کردن شکل به tikz با استفاده از دستور `clean_figure` شکل را پاک‌سازی کنید.



    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
این دستور نقاطی را که خارج از محدوده محورها هستند حذف کرده، منحنی‌ها را ساده‌سازی کرده و چگالی نقاط را برای وضوح هدف مشخص‌شده کاهش می‌دهد.

## مقایسه matplot2tikz با tikzplotlib

کتابخانه matplot2tikz از پروژه [tikzplotlib](https://github.com/nschloe/tikzplotlib) منشأ گرفته است.
دلیل ایجاد یک کتابخانه جدید این است که tikzplotlib دیگر نگهداری نمی‌شود و نگهداری آن فقط توسط مالک اصلی کتابخانه tikzplotlib امکان‌پذیر بود.
اگر لازم است از کدهای شخص ثالث که قبلاً به tikzplotlib وابسته‌اند استفاده کنید، پیشنهاد می‌شود وابستگی tikzplotlib را به matplot2tikz تغییر دهید.
اگر این کار امکان‌پذیر نیست، یک راه‌حل این است که کد زیر را *قبل از* وارد کردن کد شخص ثالث قرار دهید:







   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```
## مشارکت

اگر باگ‌هایی را تجربه می‌کنید، تمایل به مشارکت دارید، نمونه‌های خوبی از قابلیت‌های matplot2tikz
دارید، یا فقط به دنبال اطلاعات بیشتری هستید، لطفاً به
[صفحه GitHub پروژه matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz) مراجعه نمایید.

برای مشارکت، مراحل زیر را دنبال کنید:

1. مخزن git را دانلود کنید، مثلاً با استفاده از
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. یک محیط مجازی ایجاد کنید، مثلاً با استفاده از `python -m venv venv`.
3. محیط مجازی را فعال کنید (مثلاً در ویندوز، `venv\Scripts\activate`).
4. ابتدا `uv` را با دستور `pip install uv` نصب کنید و سپس `tox-uv` را با دستور `uv pip install tox-uv` نصب کنید.
5. شاخه اصلی محافظت شده است، یعنی نمی‌توانید تغییرات را مستقیماً به این شاخه ارسال کنید.
   بنابراین، اگر می‌خواهید تغییراتی اعمال کنید، این کار را در یک شاخه جداگانه انجام دهید. به عنوان مثال، می‌توانید
   با دستور `git checkout -b feature/my_awesome_new_feature` یک شاخه جدید بسازید.
6. قبل از ارسال تغییرات، مطمئن شوید که کد مطابق قوانین linting بوده و تست‌ها با موفقیت
   اجرا شده‌اند. دستور `tox` را اجرا کنید. این دستور بررسی linting را انجام داده و تمام تست‌ها را اجرا می‌کند. برای اجرای دستی
   این مراحل، از دستورات زیر استفاده کنید:
   1. دستور `tox -e lint` را اجرا کنید. همچنین می‌توانید دستورات linting را به صورت دستی اجرا کنید:
      1. (یک بار) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (برای فرمت کردن توسط `ruff`، پرچم `--check` را حذف کنید)
      3. `ruff check .`
      4. `mypy .`
   2. دستور `tox -e py310` را اجرا کنید.
   3. دستور `tox -e py311` را اجرا کنید.
   4. دستور `tox -e py312` را اجرا کنید.
   5. دستور `tox -e py313` را اجرا کنید.
   6. دستور `tox -e py314` را اجرا کنید.
   7. دستور `tox -e combine-test-reports` را اجرا کنید.
7. بررسی کنید که تست‌ها همه موارد را پوشش داده‌اند، با استفاده از گزارش پوشش در
   `/reports/coverage_html/index.html`.

   توجه: در حال حاضر، تمام کدها پوشش داده نشده‌اند. در حالت ایده‌آل، همه کدها باید پوشش داده شوند اما فعلاً مطمئن شوید که
   تمام کدهای *جدید* توسط تست‌ها پوشش داده شده‌اند.
8. تغییرات را به GitHub ارسال کنید. اگر همه چیز درست بود و می‌خواهید تغییرات خود را به شاخه `main`
   ادغام کنید، یک pull request ایجاد نمایید.
   ایده‌آل این است که حداقل یک نفر بازبینی کننده، pull request را قبل از ادغام بررسی کند.


توجه داشته باشید که در حال حاضر فقط "مالکین کد" می‌توانند درخواست‌های pull را به شاخه `main` ادغام کنند. این کار برای اطمینان از این است که همه نتوانند (حتی به طور غیرعمدی) کد اصلی را خراب کنند. اگر می‌خواهید "مالک کد" باشید، به ما اطلاع دهید!

## مجوز

matplot2tikz تحت [مجوز MIT](https://en.wikipedia.org/wiki/MIT_License) منتشر شده است.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---