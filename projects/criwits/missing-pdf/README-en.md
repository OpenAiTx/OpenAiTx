
# Open Source PDF Version of "The Computer Science Course You Missed"

> [!important]
> The open source PDF version of "The Computer Science Course You Missed" is not automatically generated from the [web version](https://www.criwits.top/missing), but manually typeset. Therefore, the open source PDF version lags behind the web version in content and may contain omissions or errors.

This is the LaTeX source code of the open source PDF version of "The Computer Science Course You Missed". The latest released PDF is typeset with TeX Live 2025. Please follow the steps below to generate the PDF:

> [!warning]
> Please compile using a local TeX environment. Do not use Overleaf.

0. Properly install the following fonts (do not use variable fonts) and ensure XeLaTeX can locate them:
   1. [Inter](https://rsms.me/inter/);
   2. [Source Han Sans](https://github.com/adobe-fonts/source-han-sans/) (not "Noto Sans SC" nor "Source Han Sans CN");
   3. [Sarasa Gothic Slab SC](https://github.com/be5invis/Sarasa-Gothic);
   4. [Noto Serif Tibetan](https://fonts.google.com/noto/specimen/Noto+Serif+Tibetan).
1. Clone this repository to your preferred location;
2. Place the two punctuation mapping files from `resource/quote.zip` into the `fonts/misc/xetex/fontmapping/xecjk` directory under your **user TEXMF tree**;
3. Refresh the filename database of your TeX distribution; TeX Live users execute

   ```shell
   mktexlsr
   ```
   MiKTeX user execution
   ```shell
   initexmf --update-fndb
   ```
4. Repeat the operation twice
   ```shell
   xelatex --shell-escape -output-driver="xdvipdfmx -i dvipdfmx-unsafe.cfg -q -E" missing.tex
   ```
Windows users can also directly double-click `make.bat` to generate the PDF file. The entire build script takes about 4 minutes ~~during which you might as well listen to a song~~.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---