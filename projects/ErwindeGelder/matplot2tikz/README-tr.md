
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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
Eskiden <em>tikzplotlib</em> olarak bilinen sanatçı.

![PyPI - Sürüm](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub Lisansı](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Sürümü](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![mypy ile kontrol edildi](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)
[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

Bu, matplotlib figürlerini
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
figürlerine dönüştüren bir Python aracı olan matplot2tikz'dir, örneğin

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

LaTeX veya ConTeXt belgelerine yerel olarak dahil edilmek üzere.

Matplot2tikz'in çıktısı [PGFPlots](https://github.com/pgf-tikz/pgfplots/) içindedir; bu,
[PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) üzerine kurulu bir TeX
kütüphanesidir ve eksenler, veriler vb. açısından grafikleri tanımlar. Sonuç olarak, matplot2tikz'in çıktısı

-   daha fazla bilgiyi korur,
-   daha kolay anlaşılabilir ve
-   daha kolay düzenlenebilir

[ham TikZ çıktısına](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend) göre daha iyidir.
Örneğin, matplotlib figürü

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

(Kodu bir dize olarak almak istiyorsanız, `save()` yerine `get_tikz_code()` kullanın.)

Grafiği düzenlemek kolaydır ve TeX çalışma akışınızın bir parçası olarak yapılabilir.
[Harika PGFPlots kılavuzu](http://pgfplots.sourceforge.net/pgfplots.pdf)
grafiğinizi daha da iyi gösterecek harika örnekler içerir.

Elbette, matplotlib tarafından üretilen tüm figürler hatasız şekilde dönüştürülemez.
Özellikle, [3D grafikler çalışmaz](https://github.com/matplotlib/matplotlib/issues/7243).

## Kurulum

matplot2tikz [Python Paket
İndeksi](https://pypi.org/project/matplot2tikz/) üzerinden mevcuttur, bu yüzden sadece

```
pip install matplot2tikz
```

kurmak için.

## Kullanım

1. Her zamanki gibi matplotlib grafiğinizi oluşturun.

2. `pyplot.show()` yerine, matplot2tikz'i şu şekilde çağırın:

    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    TikZ dosyasını `mytikz.tex` olarak kaydetmek için.

3. `mytikz.tex` içeriğini TeX kaynak kodunuza ekleyin. Bunu yapmanın pratik bir yolu
   şudur:

    ```latex
    \input{/path/to/mytikz}
    ```

    Ayrıca, belgenizin başlığında PGFPlots paketlerinin ve uygun Unicode desteğinin
    dahil edildiğinden emin olun:

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

    Koda ayrıca şu yollarla da ulaşabilirsiniz:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [Opsiyonel] Şekli tikz'e aktarmadan önce `clean_figure`
   komutunu kullanarak temizleyin.

    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
Komut, eksen sınırlarının dışında kalan noktaları kaldıracak, eğrileri basitleştirecek ve
belirtilen hedef çözünürlük için nokta yoğunluğunu azaltacaktır.

## matplot2tikz vs. tikzplotlib

Bu matplot2tikz kütüphanesi [tikzplotlib](https://github.com/nschloe/tikzplotlib)
projesinden türemiştir.
Yeni bir kütüphane oluşturulmasının nedeni, tikzplotlib'in artık bakımda olmaması ve 
bakımın yalnızca tikzplotlib kütüphanesinin tek sahibi tarafından yapılabiliyor olmasıdır.
Zaten tikzplotlib'e bağımlı olan üçüncü parti kodları kullanmanız gerekiyorsa, tikzplotlib
bağımlılığını matplot2tikz olarak değiştirmeniz önerilir.
Eğer bu mümkün değilse, bir geçici çözüm olarak aşağıdaki kodu üçüncü parti kodu *import* etmeden
önce ekleyebilirsiniz:


   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```

## Katkıda Bulunma

Hatalarla karşılaşırsanız, katkıda bulunmak isterseniz, matplot2tikz'in neler yapabildiğine dair güzel örnekleriniz varsa veya sadece daha fazla bilgi arıyorsanız, lütfen
[matplot2tikz'in GitHub sayfasını](https://github.com/ErwindeGelder/matplot2tikz) ziyaret edin.

Katkıda bulunmak için şu adımları izleyin:

1. Git deposunu indirin, örneğin
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git` komutunu kullanarak.
2. Bir sanal ortam oluşturun, örneğin `python -m venv venv` komutunu kullanarak.
3. Sanal ortamı etkinleştirin (örneğin, Windows'ta `venv\Scripts\activate`).
4. `uv`'yi `pip install uv` ile, ardından `tox-uv`'yi `uv pip install tox-uv` ile kurun.
5. Ana dal korumalıdır, yani bu dala doğrudan değişiklikleri gönderemezsiniz.
   Bu nedenle, değişiklik yapmak istiyorsanız, bunu ayrı bir dalda yapın. Örneğin, yeni bir dalı
   `git checkout -b feature/my_awesome_new_feature` komutuyla oluşturabilirsiniz.
6. Değişiklikleri göndermeden önce kodun biçimlendirme kurallarına uyduğundan ve testlerin
   başarılı olduğundan emin olun. `tox` komutunu çalıştırın. Bu komut biçimlendirme kontrolü yapar ve tüm test betiklerini çalıştırır. Bu adımları elle yapmak için aşağıdaki komutları kullanın:
   1. `tox -e lint` komutunu çalıştırın. Biçimlendirme komutlarını elle yapmak için:
      1. (Bir kez) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (`--check` bayrağını kaldırırsanız `ruff` biçimlendirmeyi yapar)
      3. `ruff check .`
      4. `mypy .`
   2. `tox -e py310` komutunu çalıştırın.
   3. `tox -e py311` komutunu çalıştırın.
   4. `tox -e py312` komutunu çalıştırın.
   5. `tox -e py313` komutunu çalıştırın.
   6. `tox -e py314` komutunu çalıştırın.
   7. `tox -e combine-test-reports` komutunu çalıştırın.
7. Testlerin her şeyi kapsayıp kapsamadığını `/reports/coverage_html/index.html`
   içindeki kapsam raporundan kontrol edin.

   NOT: Şu anda tüm kod kapsanmamaktadır. İdeal olarak tüm kod kapsanmalıdır, ancak şimdilik
   tüm *yeni* kodun testlerle kapsandığından emin olun.
8. Değişiklikleri GitHub'a gönderin. Her şey tamamsa ve değişikliklerinizi `main`
   dalına birleştirmek istiyorsanız bir çekme isteği (pull request) oluşturun.
   İdeal olarak, birleştirmeden önce en az bir inceleyici çekme isteğini incelemelidir.



Şu anda yalnızca "Kod sahipleri"nin `main` dalına pull request birleştirebileceğini unutmayın. Bu,
ana kodun herkes tarafından (istemeden de olsa) bozulmamasını sağlamak içindir. "Kod sahibi"
olmak istiyorsanız, bize bildirin!

## Lisans

matplot2tikz, [MIT
lisansı](https://en.wikipedia.org/wiki/MIT_License) altında yayımlanmıştır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---