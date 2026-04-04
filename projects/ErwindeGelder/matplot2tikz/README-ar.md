
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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
الفنان المعروف سابقاً باسم <em>tikzplotlib</em>.

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

هذه هي matplot2tikz، أداة بايثون لتحويل أشكال matplotlib إلى
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
مثل الشكل التالي

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

لإدراجها بشكل أصلي في مستندات LaTeX أو ConTeXt.

مخرجات matplot2tikz تكون بصيغة [PGFPlots](https://github.com/pgf-tikz/pgfplots/)، وهي مكتبة TeX
تعتمد على [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) وتصف الرسومات من حيث المحاور والبيانات وغيرها. بناءً على ذلك، فإن مخرجات matplot2tikz

-   تحتفظ بمزيد من المعلومات،
-   يمكن فهمها بسهولة أكبر، و
-   يمكن تعديلها بسهولة أكبر

مقارنةً بـ [مخرجات TikZ الخام](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
على سبيل المثال، شكل matplotlib


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

(استخدم `get_tikz_code()` بدلاً من `save()` إذا كنت تريد الحصول على الكود كسلسلة نصية.)

تعديل الرسم البياني أمر بسيط ويمكن القيام به كجزء من سير عمل TeX الخاص بك.
[دليل PGFPlots الرائع](http://pgfplots.sourceforge.net/pgfplots.pdf) يحتوي على
أمثلة رائعة حول كيفية جعل الرسم البياني يبدو أفضل حتى.

بالطبع، ليس كل الرسومات التي ينتجها matplotlib يمكن تحويلها بدون أخطاء.
على وجه الخصوص، [الرسومات ثلاثية الأبعاد لا تعمل](https://github.com/matplotlib/matplotlib/issues/7243).

## التثبيت

matplot2tikz متوفر [من فهرس حزم بايثون
Index](https://pypi.org/project/matplot2tikz/)، لذا ببساطة قم بـ

```
pip install matplot2tikz
```

للتثبيت.

## طريقة الاستخدام

1. أنشئ مخطط matplotlib الخاص بك كالمعتاد.

2. بدلاً من استخدام `pyplot.show()`، قم باستدعاء matplot2tikz عن طريق

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    لحفظ ملف TikZ باسم `mytikz.tex`.

3. أضف محتويات ملف `mytikz.tex` إلى مصدر كود TeX الخاص بك. طريقة مناسبة للقيام
   بذلك هي عبر

    ```latex
    \input{/path/to/mytikz}
    ```

    تأكد أيضًا من تضمين الحزم الخاصة بـ PGFPlots ودعم يونيكود المناسب
    في ترويسة مستندك:

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

    يمكنك أيضًا الحصول على الشيفرة من خلال:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [اختياري] قم بتنظيف الشكل قبل التصدير إلى tikz باستخدام أمر `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
سيقوم الأمر بإزالة النقاط التي تقع خارج حدود المحاور، وتبسيط المنحنيات وتقليل كثافة النقاط للدقة المستهدفة المحددة.

## مقارنة بين matplot2tikz و tikzplotlib

ظهرت مكتبة matplot2tikz هذه من مشروع [tikzplotlib](https://github.com/nschloe/tikzplotlib).
السبب في إنشاء مكتبة جديدة هو أن مكتبة tikzplotlib لم تعد مدعومة ويمكن إجراء الصيانة فقط من قبل مالك tikzplotlib الوحيد.
إذا كنت بحاجة لاستخدام كود طرف ثالث يعتمد بالفعل على tikzplotlib، يُنصح بتغيير الاعتماد من tikzplotlib إلى matplot2tikz.
إذا لم يكن ذلك ممكنًا، يمكن التحايل بوضع الكود التالي *قبل* استيراد كود الطرف الثالث:







   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

إذا كنت تقوم بتحديث النصوص البرمجية الخاصة بك من tikzplotlib، يمكنك ببساطة استخدام اسم مستعار للاستيراد:

   ```python
   import matplot2tikz as tikzplotlib
   ```

## المساهمة

إذا واجهت أخطاء أو كنت ترغب في المساهمة أو لديك أمثلة رائعة لما يمكن أن يفعله matplot2tikz،
أو إذا كنت تبحث فقط عن مزيد من المعلومات، يرجى زيارة
[صفحة matplot2tikz على GitHub](https://github.com/ErwindeGelder/matplot2tikz).

للمساهمة، اتبع الخطوات التالية:

1. قم بتنزيل مستودع git، على سبيل المثال باستخدام
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. أنشئ بيئة افتراضية، على سبيل المثال باستخدام `python -m venv venv`.
3. فعّل البيئة الافتراضية (على سبيل المثال، على ويندوز، `venv\Scripts\activate`).
4. ثبّت `uv` باستخدام `pip install uv` ثم ثبّت `tox-uv` باستخدام `uv pip install tox-uv`.
5. الفرع الرئيسي محمي، مما يعني أنك لا تستطيع دفع التغييرات مباشرة إلى هذا الفرع.
   لذلك، إذا كنت ترغب في إجراء تغييرات، قم بذلك في فرع منفصل. على سبيل المثال، يمكنك إنشاء
   فرع جديد باستخدام `git checkout -b feature/my_awesome_new_feature`.
6. قبل دفع التغييرات، تأكد من أن الشيفرة تلتزم بقواعد التنسيق وأن الاختبارات ناجحة.
   شغّل `tox`. هذا يقوم بفحص التنسيق ويشغّل جميع برامج الاختبار. لتنفيذ هذه الخطوات يدويًا،
   استخدم الأوامر التالية:
   1. شغّل `tox -e lint`. يمكنك تنفيذ أوامر التنسيق يدويًا باستخدام:
      1. (مرة واحدة) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (أزل الخيار `--check` للسماح لـ `ruff` بالتنسيق)
      3. `ruff check .`
      4. `mypy .`
   2. شغّل `tox -e py310`.
   3. شغّل `tox -e py311`.
   4. شغّل `tox -e py312`.
   5. شغّل `tox -e py313`.
   6. شغّل `tox -e py314`.
   7. شغّل `tox -e combine-test-reports`
7. تحقق مما إذا كانت الاختبارات غطت كل شيء باستخدام تقرير التغطية في
   `/reports/coverage_html/index.html`.

   ملاحظة: حاليًا، ليس كل الشيفرة مغطاة. من الناحية المثالية، يجب تغطية كل الشيفرة، ولكن الآن تأكد من
   أن كل الشيفرة *الجديدة* مغطاة بالاختبار.
8. ادفع التغييرات إلى GitHub. إذا كان كل شيء على ما يرام وترغب في دمج تغييراتك إلى فرع `main`
   أنشئ طلب دمج (pull request).
   من المثالي أن يكون هناك على الأقل مراجع واحد يراجع طلب الدمج قبل الدمج.

يرجى ملاحظة أنه في الوقت الحالي يمكن فقط لـ "مالكي الكود" دمج طلبات السحب على الفرع `main`. هذا لضمان عدم تمكن الجميع من كسر الكود الرئيسي (حتى لو كان ذلك عن غير قصد). إذا كنت ترغب في أن تصبح "مالك كود"، أخبرنا بذلك!

## الرخصة

يتم نشر matplot2tikz بموجب [رخصة MIT](https://en.wikipedia.org/wiki/MIT_License).





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---