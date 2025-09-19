warbleR: バイオアコースティック分析の効率化
================

<!-- README.md は README.Rmd から生成されています。そちらのファイルを編集してください -->
<!-- バッジ: 開始 -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![Dependencies](https://tinyverse.netlify.com/badge/warbleR)](https://cran.r-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licence](https://img.shields.io/badge/licence-GPL--2-blue.svg)](https://www.gnu.org/licenses/gpl-3.0.en.html)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
[![R-CMD-check](https://github.com/maRce10/warbleR/workflows/R-CMD-check/badge.svg)](https://github.com/ropensci/baRulho/actions/workflows/R-CMD-check.yaml)
<!-- バッジ: 終了 -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR ロゴ" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) は
R における動物の音響信号の構造解析を支援することを目的としています。利用者はオープンアクセスの鳥類録音を収集したり、
自身のデータを入力して、スペクトログラムの可視化および音響パラメータの測定を容易にするワークフローに沿って操作できます。
[warbleR](https://cran.r-project.org/package=warbleR) は
seewave パッケージの基本的な音響解析ツールを利用し、新たに音響構造解析のためのツールを提供します。これらのツールは
音響信号のバッチ解析に対応しています。

パッケージの主な特徴は以下の通りです:

- 音響構造を測定する多様なツール
- 選択テーブルで参照される音響信号に対してループを用いてタスクを適用
- 作業ディレクトリにスペクトログラム画像を生成し、データの整理や音響解析の検証を支援






このパッケージは以下の機能を提供します：

- [Xeno‐Canto](https://xeno-canto.org/)の録音を探索およびダウンロード
- 複数の音声ファイルの探索、整理、操作
- 信号の自動検出（周波数および時間）（より詳細で使いやすい実装についてはRパッケージ[ohun](https://docs.ropensci.org/ohun/)を参照）
- 録音全体または個別信号のスペクトログラム作成
- 音響信号構造の各種測定の実行
- 測定方法の性能評価
- 信号のカタログ化
- 音響信号の異なる構造レベルの特徴付け
- デュエットの協調の統計解析
- データベースおよび注釈テーブルの統合

ほとんどの関数はタスクの並列化を可能にしており、
複数のプロセッサ間でタスクを分配して計算効率を向上させます。
各ステップでの分析性能を評価するツールも利用可能です。

## インストール

CRANからパッケージを以下のようにインストール／ロードしてください：




``` r
install.packages("warbleR")

# load package
library(warbleR)
```
最新の開発版を
[github](https://github.com/)からインストールするには、
Rパッケージの
[remotes](https://cran.r-project.org/package=remotes)が必要です：

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## 使用法

このパッケージには、主な機能を説明するいくつかのビネットが含まれています。  
[warbleR入門](https://marce10.github.io/warbleR/articles/warbleR.html)  
ではパッケージの機能概要が提供されています。ビネット  
[アノテーションデータ形式](https://marce10.github.io/warbleR/articles/annotation_data_format.html)  
では入力アノテーションに必要な形式の詳細な説明がなされています。  
また、音響解析ワークフローでの関数の組織方法に関する例を示した  
[追加のパッケージビネット](https://marce10.github.io/warbleR/articles/) が3つあります。

パッケージの完全な説明（やや古いですが）は、こちらの  
[ジャーナル記事](https://doi.org/10.1111/2041-210X.12624) で確認できます。

## その他のパッケージ

[seewave](https://cran.r-project.org/package=seewave) と  
[tuneR](https://cran.r-project.org/package=seewave) のパッケージは、  
音響解析および操作のための多種多様な関数を提供しています。  
これらは主にR環境に既にインポートされたwaveオブジェクトを対象とします。  
[baRulho](https://cran.r-project.org/package=baRulho) パッケージは、  
[warbleR](https://cran.r-project.org/package=warbleR) と同様のデータ入力・出力を用い、  
生息環境による音響信号の劣化を定量化することに焦点を当てています。  
[Rraven](https://cran.r-project.org/package=Rraven) パッケージは、  
Rと[Raven音響解析ソフト](https://www.ravensoundsoftware.com/)  
（[コーネル鳥類学研究所](https://www.birds.cornell.edu/home)）とのデータ交換を容易にし、  
Rにおける音響解析ワークフローにRavenをアノテーションツールとして組み込む際に非常に役立ちます。  
[ohun](https://docs.ropensci.org/ohun/) パッケージは、音響イベントの自動検出を行い、  
検出ルーチンの診断および最適化のための関数を提供します。  
[dynaSpec](https://cran.r-project.org/package=seewave) は、  
動的スペクトログラム（すなわちスペクトログラム動画）を作成することができます。

## 引用方法








次のように[warbleR](https://cran.r-project.org/package=warbleR)を引用してください：

Araya-Salas, M. and Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

注意：スペクトログラム作成や音響測定機能を使用する場合は、
[tuneR](https://cran.r-project.org/package=tuneR)および
[seewave](https://cran.r-project.org/package=seewave)のパッケージも
引用してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---