
# 《あなたが欠けているあのコンピュータの授業》オープンソース PDF 版

> [!important]
> 《あなたが欠けているあのコンピュータの授業》オープンソース PDF 版は [ウェブ版](https://www.criwits.top/missing) による自動生成ではなく、手作業で組版されたものです。したがって、オープンソース PDF 版は内容がウェブ版に遅れており、欠落や誤りがある可能性があります。

これは《あなたが欠けているあのコンピュータの授業》のオープンソース PDF 版 LaTeX ソースコードで、最新リリースの PDF は TeX Live 2025 で組版されています。PDF を生成するには以下の手順に従ってください：

> [!warning]
> ローカルの TeX 環境でコンパイルしてください。Overleaf の使用は避けてください。

0. 以下のフォントを正しくインストールし（可変フォントは使用しないでください）、XeLaTeX がそれらを見つけられるようにしてください：
   1. [Inter](https://rsms.me/inter/)；
   2. [Source Han Sans（思源黑体）](https://github.com/adobe-fonts/source-han-sans/)（「Noto Sans SC」や「思源黑体 CN」ではありません）；
   3. [Sarasa Gothic Slab SC（等距更纱黑体 Slab SC）](https://github.com/be5invis/Sarasa-Gothic)；
   4. [Noto Serif Tibetan](https://fonts.google.com/noto/specimen/Noto+Serif+Tibetan)。
1. このリポジトリを好きな場所にクローンする；
2. `resource/quote.zip` にある二つの句読点マッピングファイルを**ユーザーの TEXMF ツリー**内の `fonts/misc/xetex/fontmapping/xecjk` ディレクトリに置く；
3. TeX ディストリビューションのファイル名データベースを更新する。TeX Live ユーザーは以下を実行する

   ```shell
   mktexlsr
   ```
   MiKTeX ユーザー実行
   ```shell
   initexmf --update-fndb
   ```
4. これを2回繰り返します。
   ```shell
   xelatex --shell-escape -output-driver="xdvipdfmx -i dvipdfmx-unsafe.cfg -q -E" missing.tex
   ```
   Windows ユーザーも `make.bat` を直接ダブルクリックして PDF ファイルを生成できます。ビルドスクリプト全体は約4分かかります ~~、その間に音楽を聴いてもよいでしょう~~。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---