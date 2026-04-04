
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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
โปรแกรมที่เคยรู้จักกันในชื่อ <em>tikzplotlib</em> มาก่อน

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

นี่คือ matplot2tikz เครื่องมือ Python สำหรับแปลงกราฟ matplotlib ให้เป็น
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
รูปภาพ เช่น

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

เพื่อการนำเข้าโดยตรงในเอกสาร LaTeX หรือ ConTeXt

ผลลัพธ์ของ matplot2tikz อยู่ในรูปแบบ [PGFPlots](https://github.com/pgf-tikz/pgfplots/), ซึ่งเป็นไลบรารี TeX
ที่พัฒนาต่อจาก [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) และ
ใช้ในการอธิบายกราฟในรูปแบบแกน ข้อมูล ฯลฯ ดังนั้น ผลลัพธ์ของ matplot2tikz

-   รักษาข้อมูลไว้ได้มากขึ้น,
-   เข้าใจได้ง่ายกว่า, และ
-   แก้ไขได้ง่ายกว่า

เมื่อเทียบกับ [raw TikZ output](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend)
ตัวอย่างเช่น กราฟ matplotlib

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

(ใช้ `get_tikz_code()` แทน `save()` หากคุณต้องการโค้ดเป็นสตริง)

การปรับแต่งกราฟทำได้ง่ายและสามารถทำได้เป็นส่วนหนึ่งของขั้นตอนการทำงาน TeX ของคุณ
[คู่มือ PGFPlots ที่ยอดเยี่ยม](http://pgfplots.sourceforge.net/pgfplots.pdf) มีตัวอย่าง
ดีๆ มากมายเกี่ยวกับวิธีทำให้กราฟของคุณดูดีขึ้นกว่าเดิม

แน่นอนว่าไม่ใช่ภาพทุกประเภทที่สร้างโดย matplotlib จะสามารถแปลงได้โดยไม่มีข้อผิดพลาด
โดยเฉพาะ [กราฟ 3D ใช้งานไม่ได้](https://github.com/matplotlib/matplotlib/issues/7243)

## การติดตั้ง

matplot2tikz มี [ให้ดาวน์โหลดจาก Python Package
Index](https://pypi.org/project/matplot2tikz/) ดังนั้นเพียงแค่ทำ

```
pip install matplot2tikz
```
เพื่อติดตั้ง

## การใช้งาน

1. สร้างกราฟ matplotlib ของคุณตามปกติ

2. แทนที่จะใช้ `pyplot.show()` ให้เรียกใช้ matplot2tikz โดย


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    เพื่อบันทึกไฟล์ TikZ เป็น `mytikz.tex`

3. เพิ่มเนื้อหาของ `mytikz.tex` ลงในซอร์สโค้ด TeX ของคุณ วิธีที่สะดวกวิธีหนึ่งคือโดยใช้
   ดังนี้


    ```latex
    \input{/path/to/mytikz}
    ```

    นอกจากนี้โปรดตรวจสอบให้แน่ใจว่าแพ็กเกจสำหรับ PGFPlots และการรองรับ Unicode อย่างถูกต้อง
    ถูกเพิ่มไว้ในส่วนหัวของเอกสารของคุณ:

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
    คุณยังสามารถรับโค้ดได้ผ่านทาง:


    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [ตัวเลือก] ทำความสะอาดรูปภาพก่อนส่งออกไปยัง tikz โดยใช้คำสั่ง `clean_figure`
  

    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
คำสั่งนี้จะลบจุดที่อยู่นอกขอบเขตแกน, ทำใหเส้นโค้งง่ายขึ้น และลดความหนาแน่นของจุดตามความละเอียดเป้าหมายที่ระบุ

## matplot2tikz vs. tikzplotlib

ไลบรารี matplot2tikz นี้มีต้นกำเนิดจากโปรเจกต์ [tikzplotlib](https://github.com/nschloe/tikzplotlib)
เหตุผลที่มีการสร้างไลบรารีใหม่ เนื่องจาก tikzplotlib ไม่มีการดูแลต่อเนื่องและ
การดูแลสามารถทำได้โดยเจ้าของเดียวของไลบรารี tikzplotlib เท่านั้น
หากคุณจำเป็นต้องใช้โค้ดจากบุคคลที่สามที่พึ่งพา tikzplotlib อยู่แล้ว ขอแนะนำให้เปลี่ยน
การพึ่งพา tikzplotlib เป็น matplot2tikz
หากไม่สามารถทำได้ วิธีแก้ไขชั่วคราวคือใส่โค้ดต่อไปนี้ *ก่อน* การนำเข้าโค้ดจากบุคคลที่สาม:





   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

หากคุณกำลังอัปเดตสคริปต์ของคุณเองจาก tikzplotlib คุณสามารถใช้การกำหนดชื่อเรียกนำเข้าได้อย่างง่ายดาย:

   ```python
   import matplot2tikz as tikzplotlib
   ```

## การมีส่วนร่วม

หากคุณพบข้อบกพร่อง ต้องการมีส่วนร่วม มีตัวอย่างที่ดีของสิ่งที่ matplot2tikz สามารถทำได้ หรือหากคุณกำลังมองหาข้อมูลเพิ่มเติม โปรดเยี่ยมชม
[หน้าของ matplot2tikz บน GitHub](https://github.com/ErwindeGelder/matplot2tikz)

สำหรับการมีส่วนร่วม กรุณาทำตามขั้นตอนเหล่านี้:

1. ดาวน์โหลดที่เก็บ git ตัวอย่างเช่นโดยใช้
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`
2. สร้าง virtual environment ตัวอย่างเช่นโดยใช้ `python -m venv venv`
3. เปิดใช้งาน virtual environment (ตัวอย่างเช่นบน Windows, `venv\Scripts\activate`)
4. ติดตั้ง `uv` โดยใช้ `pip install uv` และจากนั้น `tox-uv` โดยใช้ `uv pip install tox-uv`
5. สาขาหลักถูกป้องกัน หมายความว่าคุณไม่สามารถ push การเปลี่ยนแปลงไปยังสาขานี้ได้โดยตรง 
   ดังนั้น หากคุณต้องการเปลี่ยนแปลง ให้ทำในสาขาใหม่ ตัวอย่างเช่น คุณสามารถสร้าง 
   สาขาใหม่โดยใช้ `git checkout -b feature/my_awesome_new_feature`
6. ก่อน push การเปลี่ยนแปลง ให้แน่ใจว่าโค้ดเป็นไปตามกฎการจัดรูปแบบและทดสอบสำเร็จ ให้รัน `tox` ซึ่งจะตรวจสอบรูปแบบและรันทดสอบทั้งหมด หากต้องการทำขั้นตอนเหล่านี้ด้วยตนเอง ให้ใช้คำสั่งต่อไปนี้:
   1. รัน `tox -e lint` คุณสามารถรันคำสั่ง linting ด้วยตนเองได้โดยใช้:
      1. (ครั้งเดียว) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (ลบ flag `--check` หากต้องการให้ `ruff` จัดรูปแบบให้เอง)
      3. `ruff check .`
      4. `mypy .`
   2. รัน `tox -e py310`
   3. รัน `tox -e py311`
   4. รัน `tox -e py312`
   5. รัน `tox -e py313`
   6. รัน `tox -e py314`
   7. รัน `tox -e combine-test-reports`
7. ตรวจสอบว่าการทดสอบครอบคลุมทุกอย่างแล้วโดยใช้รายงาน coverage ที่
   `/reports/coverage_html/index.html`

   หมายเหตุ: ขณะนี้ยังมีโค้ดบางส่วนที่ไม่ได้รับการทดสอบ ในอุดมคติควรครอบคลุมทั้งหมด แต่สำหรับตอนนี้ ให้แน่ใจว่าโค้ด *ใหม่* ทั้งหมดได้รับการทดสอบแล้ว
8. ส่งการเปลี่ยนแปลงขึ้น GitHub หากทุกอย่างเรียบร้อยและคุณต้องการ merge การเปลี่ยนแปลงไปยังสาขา `main`
   ให้สร้าง pull request
   โดยทั่วไป ควรมีผู้ตรวจสอบอย่างน้อยหนึ่งคนตรวจสอบ pull request ก่อน merge





โปรดทราบว่าปัจจุบันเฉพาะ "เจ้าของโค้ด" เท่านั้นที่สามารถรวม pull request เข้าสู่สาขา `main` ได้ สิ่งนี้เพื่อ
ป้องกันไม่ให้ทุกคนสามารถทำให้โค้ดหลักเสียหาย (ถึงแม้จะไม่ได้ตั้งใจก็ตาม) หากคุณต้องการเป็น "เจ้าของโค้ด"
แจ้งให้เราทราบได้เลย!

## ใบอนุญาต

matplot2tikz เผยแพร่ภายใต้ [สัญญาอนุญาต MIT
license](https://en.wikipedia.org/wiki/MIT_License).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---