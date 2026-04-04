<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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
पूर्व में जिसे <em>tikzplotlib</em> के नाम से जाना जाता था।

![PyPI - Version](https://img.shields.io/pypi/v/matplot2tikz)
![GitHub License](https://img.shields.io/github/license/ErwindeGelder/matplot2tikz)
![PyPI - Python Version](https://img.shields.io/pypi/pyversions/matplot2tikz)
[![Ruff](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/astral-sh/ruff/main/assets/badge/v2.json)](https://github.com/astral-sh/ruff)
[![Checked with mypy](https://www.mypy-lang.org/static/mypy_badge.svg)](https://mypy-lang.org/)

[![codecov](https://codecov.io/gh/ErwindeGelder/matplot2tikz/graph/badge.svg?token=YE2VNWL9HI)](https://codecov.io/gh/ErwindeGelder/matplot2tikz)
[![PyPI Downloads](https://static.pepy.tech/badge/matplot2tikz/month)](https://pepy.tech/projects/matplot2tikz)

यह matplot2tikz है, एक Python उपकरण जो matplotlib चित्रों को
[PGFPlots](https://www.ctan.org/pkg/pgfplots) ([PGF/TikZ](https://www.ctan.org/pkg/pgf))
चित्रों में बदलता है जैसे

![](https://raw.githubusercontent.com/ErwindeGelder/matplot2tikz/refs/heads/main/example.png)

जो LaTeX या ConTeXt दस्तावेजों में मूल रूप से शामिल किए जा सकते हैं।

matplot2tikz का आउटपुट [PGFPlots](https://github.com/pgf-tikz/pgfplots/) में होता है, जो एक TeX
लाइब्रेरी है जो [PGF/TikZ](https://en.wikipedia.org/wiki/PGF/TikZ) के ऊपर बनाई गई है और
आरेखों का वर्णन अक्ष, डेटा आदि के रूप में करती है। नतीजतन, matplot2tikz का आउटपुट

-   अधिक जानकारी बनाए रखता है,
-   अधिक आसानी से समझा जा सकता है, और
-   अधिक आसानी से संपादित किया जा सकता है

[कच्चे TikZ आउटपुट](https://matplotlib.org/users/whats_new.html#pgf-tikz-backend) की तुलना में।
उदाहरण के लिए, matplotlib चित्र

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

(यदि आप कोड स्ट्रिंग के रूप में चाहते हैं तो `save()` के बजाय `get_tikz_code()` का उपयोग करें।)

प्लॉट को समायोजित करना आसान है और इसे आपके TeX कार्य प्रवाह का हिस्सा बनाकर किया जा सकता है।
[शानदार PGFPlots मैनुअल](http://pgfplots.sourceforge.net/pgfplots.pdf) में
बेहतरीन उदाहरण हैं कि आप अपने प्लॉट को और भी बेहतर कैसे बना सकते हैं।

बिल्कुल, matplotlib द्वारा बनाई गई सभी आकृतियों को बिना त्रुटि के परिवर्तित नहीं किया जा सकता।
विशेष रूप से, [3D प्लॉट काम नहीं करते](https://github.com/matplotlib/matplotlib/issues/7243)।

## इंस्टॉलेशन

matplot2tikz [Python पैकेज इंडेक्स](https://pypi.org/project/matplot2tikz/) से उपलब्ध है, तो बस


```
pip install matplot2tikz
```
इंस्टॉल करने के लिए।

## उपयोग

1. अपनी matplotlib प्लॉट को सामान्य रूप से जनरेट करें।

2. `pyplot.show()` के बजाय, matplot2tikz को इस प्रकार चलाएँ


    ```python
    import matplot2tikz

    matplot2tikz.save("mytikz.tex")
    # or
    matplot2tikz.save("mytikz.tex", flavor="context")
    ```

    TikZ फ़ाइल को `mytikz.tex` के रूप में संग्रहित करें।

3. `mytikz.tex` की सामग्री को अपने TeX स्रोत कोड में जोड़ें। ऐसा करने का एक सुविधाजनक तरीका है
  

    ```latex
    \input{/path/to/mytikz}
    ```

    साथ ही सुनिश्चित करें कि PGFPlots के लिए पैकेज और उपयुक्त यूनिकोड समर्थन आपके दस्तावेज़ के हेडर में शामिल हों:


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

    आप कोड प्राप्त करने के लिए निम्न तरीकों का उपयोग भी कर सकते हैं:

    ```python
    import matplot2tikz

    matplot2tikz.Flavors.latex.preamble()
    # or
    matplot2tikz.Flavors.context.preamble()
    ```

4. [वैकल्पिक] आंकड़े को tikz में निर्यात करने से पहले `clean_figure` कमांड का उपयोग करके साफ करें।


    ```python
    import matplotlib.pyplot as plt
    import numpy as np

    # ... do your plotting

    import matplot2tikz

    matplot2tikz.clean_figure()
    matplot2tikz.save("test.tex")
    ```
कमांड उन बिंदुओं को हटा देगा जो अक्ष सीमा के बाहर हैं, वक्रों को सरल करेगा और निर्दिष्ट लक्षित रेजोल्यूशन के लिए बिंदु घनत्व को कम करेगा।

## matplot2tikz बनाम tikzplotlib

यह matplot2tikz लाइब्रेरी [tikzplotlib](https://github.com/nschloe/tikzplotlib) परियोजना से उत्पन्न हुई है।
एक नई लाइब्रेरी बनाए जाने का कारण यह है कि tikzplotlib अब मेंटेन नहीं किया जा रहा है और रखरखाव केवल tikzplotlib लाइब्रेरी के एकल मालिक द्वारा ही किया जा सकता था।
यदि आपको तीसरे पक्ष के कोड का उपयोग करना है जो पहले से ही tikzplotlib पर निर्भर करता है, तो यह सुझाव दिया जाता है कि tikzplotlib निर्भरता को matplot2tikz में बदल दें।
यदि यह संभव नहीं है, तो एक समाधान यह है कि निम्नलिखित कोड को तीसरे पक्ष के कोड को आयात करने से *पहले* रखें:







   ```
   import sys
   import matplot2tikz
   sys.modules["tikzplotlib"] = matplot2tikz
   # Do other imports, e.g., using `import my_third_party_library`
   # If tikzplotlib is used in this library, it will automatically use matplot2tikz instead.
   ```
यदि आप अपने स्वयं के स्क्रिप्ट्स को tikzplotlib से अपडेट कर रहे हैं, तो आप बस एक इम्पोर्ट एलियास का उपयोग कर सकते हैं:


   ```python
   import matplot2tikz as tikzplotlib
   ```

## योगदान

यदि आप बग्स का अनुभव करते हैं, योगदान देना चाहते हैं, matplot2tikz क्या कर सकता है इसके अच्छे उदाहरण साझा करना चाहते हैं, या बस अधिक जानकारी चाहते हैं, तो कृपया [matplot2tikz का GitHub पेज](https://github.com/ErwindeGelder/matplot2tikz) देखें।

योगदान देने के लिए, निम्नलिखित चरणों का पालन करें:

1. गिट रिपॉजिटरी डाउनलोड करें, उदाहरण के लिए,
   `git clone git@github.com:ErwindeGelder/matplot2tikz.git` का उपयोग करें।
2. एक वर्चुअल एनवायरनमेंट बनाएं, जैसे `python -m venv venv` का उपयोग करें।
3. वर्चुअल एनवायरनमेंट को सक्रिय करें (जैसे Windows पर, `venv\Scripts\activate`)।
4. `uv` को `pip install uv` से और फिर `tox-uv` को `uv pip install tox-uv` से इंस्टॉल करें।
5. मुख्य ब्रांच सुरक्षित है, अर्थात आप सीधे इस ब्रांच में परिवर्तन नहीं कर सकते।
   इसलिए, यदि आप बदलाव करना चाहते हैं, तो अलग ब्रांच में करें। उदाहरण के लिए, आप नया ब्रांच 
   `git checkout -b feature/my_awesome_new_feature` से बना सकते हैं।
6. बदलाव पुश करने से पहले, सुनिश्चित करें कि कोड लिंटिंग नियमों का पालन करता है और सभी टेस्ट 
   सफल हैं। `tox` चलाएँ। यह लिंटिंग जांच करता है और सभी टेस्ट स्क्रिप्ट्स चलाता है। मैन्युअली 
   ये चरण करने के लिए, निम्नलिखित कमांड्स का उपयोग करें:
   1. `tox -e lint` चलाएँ। आप लिंटिंग कमांड्स मैन्युअली इस प्रकार चला सकते हैं:
      1. (एक बार) `uv pip install -r requirements-lint.txt`
      2. `ruff format . --check` (`--check` फ्लैग हटाएँ ताकि `ruff` फॉर्मेटिंग करे)
      3. `ruff check .`
      4. `mypy .`
   2. `tox -e py310` चलाएँ।
   3. `tox -e py311` चलाएँ।
   4. `tox -e py312` चलाएँ।
   5. `tox -e py313` चलाएँ।
   6. `tox -e py314` चलाएँ।
   7. `tox -e combine-test-reports` चलाएँ।
7. जाँचें कि सभी टेस्ट कवर हुए हैं या नहीं, इसके लिए कवररेज रिपोर्ट को 
   `/reports/coverage_html/index.html` में देखें।

   नोट: वर्तमान में, अभी सारा कोड कवर नहीं है। आदर्श रूप से, सारा कोड कवर होना चाहिए, लेकिन फिलहाल, सुनिश्चित करें कि 
   सारा *नया* कोड टेस्टिंग द्वारा कवर हो।
8. बदलावों को GitHub पर पुश करें। यदि सबकुछ ठीक है और आप अपने बदलाव `main`
   ब्रांच में मर्ज करना चाहते हैं, तो एक पुल रिक्वेस्ट बनाएं।
   आदर्श रूप से, कम से कम एक रिव्युअर पुल रिक्वेस्ट को मर्ज से पहले रिव्यू करता है।



ध्यान दें कि वर्तमान में केवल "कोड मालिक" ही `main` शाखा में पुल अनुरोधों को मर्ज कर सकते हैं। इसका उद्देश्य यह सुनिश्चित करना है कि हर कोई मुख्य कोड को (भले ही अनजाने में) खराब न कर सके। यदि आप "कोड मालिक" बनना चाहते हैं, तो हमें बताएं!

## लाइसेंस

matplot2tikz [MIT लाइसेंस](https://en.wikipedia.org/wiki/MIT_License) के तहत प्रकाशित किया गया है।





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---