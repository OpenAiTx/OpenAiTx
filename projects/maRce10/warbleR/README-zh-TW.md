warbleR：簡化生物聲學分析
================

🌐 **語言：**  
[英文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[西班牙文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[法文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[德文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[葡萄牙文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[義大利文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[俄文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文（簡體）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文（繁體）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[韓文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[印地文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[泰文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[荷蘭文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[波蘭文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[阿拉伯文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[波斯文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[土耳其文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[越南文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[印尼文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[阿薩姆文](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md 是從 README.Rmd 產生的。請編輯該檔案 -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) 旨在協助
在 R 中分析動物聲學信號的結構。使用者可以收集開放存取的鳥類錄音或將自己的
數據輸入到工作流程中，以便促進聲譜圖的視覺化和
聲學參數的測量。
[warbleR](https://cran.r-project.org/package=warbleR) 利用
seewave 套件的基本聲音分析工具，並提供新的
聲學結構分析工具。這些工具可用於
聲學信號的批次分析。

該套件的主要功能包括：

- 多樣化的聲學結構測量工具
- 使用迴圈將任務應用於在
  選擇表中引用的聲學信號
- 在工作目錄中產生帶有聲譜圖的圖像，
  讓使用者整理數據並驗證聲學分析

該套件提供以下函數：

- 探索及下載 [Xeno‐Canto](https://xeno-canto.org/) 錄音
- 探索、組織及操作多個聲音檔案
- 自動檢測信號（在頻率和時間上）（但請參考 R
  套件 [ohun](https://docs.ropensci.org/ohun/) 以獲得更完整且友善的實現）
- 建立完整錄音或個別信號的聲譜圖
- 執行不同的聲學信號結構測量
- 評估測量方法的效能
- 編目信號
- 描述聲學信號中的不同結構層次
- 二重唱協調的統計分析
- 整合資料庫及註釋表格

大多數函數允許任務並行化，這會
將任務分配給多個處理器以提升計算


效率。也提供評估每一步分析表現的工具。

## 安裝

可依下列方式從 CRAN 安裝／載入套件：


``` r
install.packages("warbleR")

# load package
library(warbleR)
```
要從 [github](https://github.com/) 安裝最新的開發版，
您將需要 R 套件 [remotes](https://cran.r-project.org/package=remotes)：



``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## 使用方法

此套件包含數個說明文件，解釋其主要功能。
[warbleR簡介](https://marce10.github.io/warbleR/articles/warbleR.html)
提供了套件功能的總覽。說明文件
[註釋資料格式](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
詳細說明了輸入註釋所需的格式。此外還有三個其他[套件說明文件](https://marce10.github.io/warbleR/articles/)，展示如何在聲學分析工作流程中組織函數。

套件的完整說明（雖然有些過時）可以在這篇[期刊文章](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624)中找到。

## 其他套件

[seewave](https://cran.r-project.org/package=seewave)和
[tuneR](https://cran.r-project.org/package=seewave)這兩個套件提供了大量聲學分析及操作的函數。它們主要針對已經導入R環境的波形物件進行操作。
[baRulho](https://cran.r-project.org/package=baRulho)套件專注於量化棲地對聲學訊號造成的退化，其資料輸入與輸出與
[warbleR](https://cran.r-project.org/package=warbleR)相似。套件
[Rraven](https://cran.r-project.org/package=Rraven)促進R與[Raven聲音分析軟體](https://www.ravensoundsoftware.com/)（[康奈爾鳥類學實驗室](https://www.birds.cornell.edu/home)）之間的資料交換，對於將Raven作為註釋工具整合進R的聲學分析工作流程非常有幫助。套件
[ohun](https://docs.ropensci.org/ohun/)可自動偵測聲音事件，並提供診斷及最佳化偵測流程的函數。[dynaSpec](https://cran.r-project.org/package=seewave)則可用來製作動態頻譜圖（即頻譜影片）。

## 引用





















請按照以下方式引用 [warbleR](https://cran.r-project.org/package=warbleR)：

Araya-Salas, M. 和 Smith-Vidaurre, G. (2017)，*warbleR: an r package to
streamline analysis of animal acoustic signals*。Methods Ecol Evol. 8，
184-191。

注意：如果您使用任何產生聲譜圖或聲學測量的函數，請同時引用
[tuneR](https://cran.r-project.org/package=tuneR) 和
[seewave](https://cran.r-project.org/package=seewave) 套件




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---