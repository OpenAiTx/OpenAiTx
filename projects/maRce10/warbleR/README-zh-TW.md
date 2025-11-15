<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


warbleR：簡化生物聲學分析
================

<!-- README.md 是從 README.Rmd 產生的。請編輯該檔案 -->
<!-- 徽章：開始 -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![專案狀態：活躍 該專案已達到穩定且可用狀態
並且正在積極
開發中。](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![授權條款：GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_狀態_徽章](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![總下載量](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov 測試
覆蓋率](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR 標誌" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) 旨在
促進在 R 中分析動物聲學訊號結構。
使用者可收集開放存取的鳥類錄音，或將自己的
資料輸入到一個有助於頻譜圖視覺化及
聲學參數測量的工作流程。
[warbleR](https://cran.r-project.org/package=warbleR) 利用
seewave 套件的基本聲音分析工具，並提供新的
聲學結構分析工具。這些工具可用於
批次分析聲學訊號。

此套件的主要特色包括：

- 多樣化的聲學結構測量工具
- 使用迴圈將任務套用至在
  選擇表中參照的聲學訊號
- 在工作目錄中產生包含頻譜圖的圖片，
  以便使用者整理資料並驗證聲學分析

本套件提供以下功能：

- 探索並下載 [Xeno‐Canto](https://xeno-canto.org/) 錄音
- 探索、整理及操作多個音檔
- 自動偵測訊號（於頻率及時間上）（但建議參考 R
  套件 [ohun](https://docs.ropensci.org/ohun/) 以獲得更完整且友善的實作）
- 建立完整錄音或個別訊號的頻譜圖


- 執行不同的聲學信號結構測量方法
- 評估測量方法的效能
- 編目信號
- 描述聲學信號中的不同結構層級
- 對二重奏協調進行統計分析
- 整合資料庫和註釋表格

大多數功能允許任務的平行化，
將任務分配給多個處理器以提升運算效率。
每個步驟也提供評估分析效能的工具。

## 安裝

可依下列方式從 CRAN 安裝/載入套件：


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---