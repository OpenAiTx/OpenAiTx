
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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
Tên trước đây là <em>tikzplotlib</em>.

![Phiên bản PyPI](https://img.shields.io/pypi/v/matplot2tikz)
![Giấy phép GitHub](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![Phiên bản Python PyPI](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Kiểm tra với mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Đây là matplot2tikz, một công cụ Python dùng để chuyển đổi các hình vẽ matplotlib thành
các hình [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
như

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

để nhúng trực tiếp vào các tài liệu LaTeX hoặc ConTeXt.

Đầu ra của matplot2tikz là ở dạng [PGFPlots](https://github.com/pgf-tikz/pgfplots/), một thư viện TeX
dựa trên [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) và
mô tả biểu đồ dưới dạng các trục, dữ liệu, v.v. Do đó, đầu ra của matplot2tikz

-   giữ lại nhiều thông tin hơn,
-   dễ hiểu hơn,
-   và dễ chỉnh sửa hơn

so với [đầu ra TikZ thô](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Ví dụ, hình vẽ matplotlib

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

(Hãy sử dụng `get_tikz_code()` thay vì `save()` nếu bạn muốn lấy mã dưới dạng chuỗi.)

Việc điều chỉnh biểu đồ rất đơn giản và có thể thực hiện như một phần trong quy trình làm việc với TeX.
[Hướng dẫn tuyệt vời về PGFPlots](http://pgfplots.sourceforge.net/pgfplots.pdf) chứa
nhiều ví dụ tuyệt vời về cách làm cho biểu đồ của bạn trông đẹp hơn nữa.

Tất nhiên, không phải tất cả các hình được tạo bằng matplotlib đều có thể chuyển đổi mà không gặp lỗi.
Đáng chú ý, [biểu đồ 3D không hoạt động](https://github.com/matplotlib/matplotlib/issues/7243).

## Cài đặt

matplot2tikz có [sẵn trên Python Package
Index](https://pypi.org/project/matplot2tikz/), vì vậy chỉ cần thực hiện

```
pip install matplot2tikz
```
để cài đặt.

## Cách sử dụng

1. Tạo biểu đồ matplotlib của bạn như bình thường.

2. Thay vì sử dụng `pyplot.show()`, hãy gọi matplot2tikz bằng cách


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    để lưu tệp TikZ dưới tên `mytikz.tex`.

3. Thêm nội dung của `mytikz.tex` vào mã nguồn TeX của bạn. Một cách tiện lợi để làm điều này là thông qua


    ```latex
    \input{/path/to/mytikz}
    ```

    Ngoài ra, hãy đảm bảo rằng các gói cho PGFPlots và hỗ trợ Unicode đầy đủ đã được
    đưa vào phần đầu của tài liệu của bạn:

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

    Bạn cũng có thể lấy mã thông qua:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Tùy chọn] Làm sạch hình trước khi xuất ra tikz bằng lệnh `clean_figure`.


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Lệnh này sẽ loại bỏ các điểm nằm ngoài giới hạn trục, đơn giản hóa các đường cong và
giảm mật độ điểm cho độ phân giải mục tiêu đã chỉ định.

## matplot2tikz vs. tikzplotlib

Thư viện matplot2tikz này bắt nguồn từ dự án [tikzplotlib](https://github.com/nschloe/tikzplotlib).
Lý do tạo ra một thư viện mới là vì tikzplotlib không còn được duy trì và
việc duy trì chỉ có thể thực hiện bởi chủ sở hữu duy nhất của thư viện tikzplotlib.
Nếu bạn cần sử dụng mã của bên thứ ba đã phụ thuộc vào tikzplotlib, đề xuất là thay đổi
phụ thuộc tikzplotlib thành matplot2tikz.
Nếu điều này không khả thi, một cách xử lý là đặt đoạn mã sau *trước* khi nhập mã
của bên thứ ba:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

Nếu bạn đang cập nhật các script của riêng mình từ tikzplotlib, bạn có thể đơn giản sử dụng một bí danh nhập:

   ```python
   import matplot2tikz as tikzplotlib
   ```

## Đóng góp

Nếu bạn gặp lỗi, muốn đóng góp, có những ví dụ hay về những gì matplot2tikz có thể làm được, hoặc chỉ đơn giản là muốn tìm thêm thông tin, hãy truy cập
[trang GitHub của matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Để đóng góp, hãy làm theo các bước sau:

1. Tải về kho git, ví dụ sử dụng
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Tạo môi trường ảo, ví dụ dùng `python -m venv venv`.
3. Kích hoạt môi trường ảo (ví dụ trên Windows, `venv\Scripts\activate`).
4. Cài đặt `uv` bằng `pip install uv` và sau đó `tox-uv` bằng `uv pip install tox-uv`.
5. Nhánh main được bảo vệ, tức là bạn không thể đẩy trực tiếp các thay đổi lên nhánh này.
   Vì vậy, nếu muốn thay đổi, hãy thực hiện trên một nhánh riêng. Ví dụ, bạn có thể tạo
   một nhánh mới bằng `git checkout -b feature/my_awesome_new_feature`.
6. Trước khi đẩy thay đổi, đảm bảo mã nguồn tuân thủ các quy tắc linting và các kiểm thử đều
   thành công. Chạy `tox`. Lệnh này sẽ kiểm tra linting và chạy tất cả các script kiểm thử. Để thực hiện
   các bước này thủ công, dùng các lệnh sau:
   1. Chạy `tox -e lint`. Bạn có thể thực hiện các lệnh linting thủ công như sau:
      1. (Một lần) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (bỏ cờ `--check` để cho `ruff` tự động định dạng)
      3. `ruff check .`
      4. `mypy .`
   2. Chạy `tox -e py310`.
   3. Chạy `tox -e py311`.
   4. Chạy `tox -e py312`.
   5. Chạy `tox -e py313`.
   6. Chạy `tox -e py314`.
   7. Chạy `tox -e combine-test-reports`
7. Kiểm tra xem các kiểm thử đã bao phủ tất cả chưa bằng báo cáo coverage tại
   `/reports/coverage_html/index.html`.

   LƯU Ý: Hiện tại chưa phải tất cả mã nguồn đều được kiểm thử. Lý tưởng là tất cả đều được kiểm thử, nhưng trước mắt, hãy đảm bảo rằng
   tất cả mã *mới* đều được kiểm thử.
8. Đẩy thay đổi lên GitHub. Nếu mọi thứ đã ổn và bạn muốn gộp thay đổi vào nhánh `main`,
   hãy tạo một pull request.
   Lý tưởng là có ít nhất một người kiểm duyệt xem xét pull request trước khi gộp.


Lưu ý rằng hiện tại chỉ những "Chủ sở hữu mã" mới có thể hợp nhất các pull request vào nhánh `main`. Điều này nhằm
đảm bảo rằng không phải ai cũng có thể làm hỏng mã nguồn chính (ngay cả khi vô ý). Nếu bạn muốn trở thành "Chủ sở hữu mã",
hãy cho chúng tôi biết!

## Giấy phép

matplot2tikz được phát hành theo [giấy phép MIT](https://en.wikipedia.org/wiki/MIT_License).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---