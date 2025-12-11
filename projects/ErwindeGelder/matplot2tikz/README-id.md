
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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
Seniman yang sebelumnya dikenal sebagai <em>tikzplotlib</em>.

![PyPI - Versi](https://img.shields.io/pypi/v/matplot2tikz)
![Lisensi GitHub](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Versi Python](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Diperiksa dengan mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Ini adalah matplot2tikz, sebuah alat Python untuk mengonversi gambar matplotlib menjadi
gambar [PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
seperti

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

untuk penyisipan langsung ke dalam dokumen LaTeX atau ConTeXt.

Output dari matplot2tikz berupa [PGFPlots](https://github.com/pgf-tikz/pgfplots/), sebuah pustaka TeX
yang berada di atas [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) dan
menggambarkan grafik dalam istilah sumbu, data, dll. Dengan demikian, output dari matplot2tikz

-   mempertahankan lebih banyak informasi,
-   lebih mudah dipahami, dan
-   lebih mudah untuk diedit

daripada [output TikZ mentah](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend).
Sebagai contoh, gambar matplotlib

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
(Gunakan `get_tikz_code()` sebagai pengganti `save()` jika Anda menginginkan kode tersebut dalam bentuk string.)

Mengubah plot sangat mudah dan dapat dilakukan sebagai bagian dari alur kerja TeX Anda.
[Manual PGFPlots yang luar biasa](http://pgfplots.sourceforge.net/pgfplots.pdf) berisi
contoh-contoh hebat tentang cara membuat plot Anda terlihat lebih baik lagi.

Tentu saja, tidak semua gambar yang dihasilkan oleh matplotlib dapat dikonversi tanpa kesalahan.
Terutama, [plot 3D tidak berfungsi](https://github.com/matplotlib/matplotlib/issues/7243).

## Instalasi

matplot2tikz [tersedia di Python Package
Index](https://pypi.org/project/matplot2tikz/), jadi cukup lakukan


```
pip install matplot2tikz
```
untuk menginstal.

## Penggunaan

1. Buat plot matplotlib Anda seperti biasa.

2. Alih-alih menggunakan `pyplot.show()`, panggil matplot2tikz dengan


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```
    untuk menyimpan file TikZ sebagai `mytikz.tex`.

3. Tambahkan isi dari `mytikz.tex` ke dalam kode sumber TeX Anda. Cara yang mudah untuk melakukannya
   adalah melalui


    ```latex
    \input{/path/to/mytikz}
    ```

    Pastikan juga bahwa paket untuk PGFPlots dan dukungan Unicode yang tepat sudah
    disertakan di header dokumen Anda:

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
    Anda juga dapat memperoleh kode melalui:


    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Opsional] Bersihkan gambar sebelum mengekspor ke tikz menggunakan perintah `clean_figure`
   .

    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Perintah ini akan menghapus titik-titik yang berada di luar batas sumbu, menyederhanakan kurva dan
mengurangi kepadatan titik untuk resolusi target yang ditentukan.

## matplot2tikz vs. tikzplotlib

Pustaka matplot2tikz ini berasal dari proyek [tikzplotlib](https://github.com/nschloe/tikzplotlib).
Alasan pustaka baru dibuat adalah karena tikzplotlib sudah tidak lagi dipelihara dan
pemeliharaan hanya bisa dilakukan oleh satu pemilik pustaka tikzplotlib.
Jika Anda perlu menggunakan kode pihak ketiga yang sudah bergantung pada tikzplotlib, disarankan untuk mengganti
dependensi tikzplotlib ke matplot2tikz.
Jika hal ini tidak memungkinkan, solusi sementara adalah dengan menaruh kode berikut *sebelum* mengimpor kode
pihak ketiga:



   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Berkontribusi

Jika Anda mengalami bug, ingin berkontribusi, memiliki contoh menarik tentang apa yang dapat dilakukan matplot2tikz,
atau jika Anda hanya mencari informasi lebih lanjut, silakan kunjungi
[halaman GitHub matplot2tikz](https://github.com/ErwindeGelder/matplot2tikz).

Untuk berkontribusi, ikuti langkah-langkah berikut:

1. Unduh repository git, misalnya dengan
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git`.
2. Buat lingkungan virtual, misalnya dengan `python -m venv venv`.
3. Aktifkan lingkungan virtual (misalnya, pada Windows, `venv\Scripts\activate`).
4. Instal `uv` dengan `pip install uv` dan kemudian `tox-uv` dengan `uv pip install tox-uv`.
5. Branch utama dilindungi, artinya Anda tidak bisa langsung melakukan push perubahan ke branch ini.
   Oleh karena itu, jika Anda ingin melakukan perubahan, lakukan di branch terpisah. Sebagai contoh, Anda dapat membuat
   branch baru dengan `git checkout -b feature/my_awesome_new_feature`.
6. Sebelum melakukan push perubahan, pastikan kode sudah mematuhi aturan linting dan semua pengujian
   berhasil. Jalankan `tox`. Perintah ini melakukan pengecekan linting dan menjalankan semua skrip pengujian. Untuk melakukan
   langkah-langkah ini secara manual, gunakan perintah berikut:
   1. Jalankan `tox -e lint`. Anda dapat menjalankan perintah linting secara manual dengan:
      1. (Satu kali) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (hilangkan flag `--check` agar `ruff` melakukan pemformatan)
      3. `ruff check .`
      4. `mypy .`
   2. Jalankan `tox -e py310`.
   3. Jalankan `tox -e py311`.
   4. Jalankan `tox -e py312`.
   5. Jalankan `tox -e py313`.
   6. Jalankan `tox -e py314`.
   7. Jalankan `tox -e combine-test-reports`
7. Periksa apakah pengujian telah mencakup semua hal menggunakan laporan coverage di
   `/reports/coverage_html/index.html`.

   CATATAN: Saat ini, tidak semua kode tercakup. Idealnya, semua kode tercakup, namun untuk saat ini, pastikan bahwa
   semua kode *baru* sudah tercakup oleh pengujian.
8. Push perubahan ke GitHub. Jika semuanya sudah OK dan Anda ingin menggabungkan perubahan ke branch `main`,
   buatlah pull request.
   Idealnya, ada setidaknya satu reviewer yang meninjau pull request sebelum proses merge.

Perhatikan bahwa saat ini hanya "Pemilik Kode" yang dapat menggabungkan pull request ke cabang `main`. Ini untuk
memastikan bahwa tidak semua orang dapat merusak kode utama (bahkan secara tidak sengaja). Jika Anda ingin menjadi "Pemilik Kode",
beritahu kami!

## Lisensi

matplot2tikz diterbitkan di bawah [lisensi MIT](https://en.wikipedia.org/wiki/MIT_License).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---