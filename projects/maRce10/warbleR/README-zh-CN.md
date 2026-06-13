warbleR：简化生物声学分析
================

🌐 **语言：**  
[英语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[西班牙语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[法语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[德语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[葡萄牙语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[意大利语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[俄语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文（简体）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文（繁体）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[韩语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[印地语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[泰语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[荷兰语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[波兰语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[阿拉伯语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[波斯语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[土耳其语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[越南语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[印尼语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[阿萨姆语](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md 文件由 README.Rmd 生成。请编辑该文件 -->
<!-- 徽章：开始 -->

[![生命周期](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![状态](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![项目状态：活跃 项目已达到稳定、可用状态
并正在积极
开发。](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![许可证：GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_状态_徽章](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![总下载量](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov 测试

coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) 旨在
促进动物声学信号结构在 R 中的分析。用户可以收集开放获取的鸟类录音或将自己的
数据输入到工作流程中，从而方便声谱图可视化和
声学参数测量。
[warbleR](https://cran.r-project.org/package=warbleR) 利用 seewave 包的
基础声音分析工具，并提供新的
声学结构分析工具。这些工具可用于
批量分析声学信号。

该包的主要功能包括：

- 多样化的声学结构测量工具
- 通过循环将任务应用于选择表中引用的
  声学信号
- 在工作目录中生成含声谱图的图片，
  以便用户整理数据并验证声学分析

该包提供以下功能：

- 浏览和下载 [Xeno‐Canto](https://xeno-canto.org/) 录音
- 浏览、组织和操作多个声音文件
- 自动检测信号（在频率和时间上）（但请查看 R 包
  [ohun](https://docs.ropensci.org/ohun/) 以获得更全面和友好的实现）
- 创建完整录音或单个信号的声谱图
- 运行不同的声学信号结构测量
- 评估测量方法的性能
- 信号分类
- 描述声学信号中的不同结构层级
- 二重奏协调的统计分析
- 整合数据库和注释表

大多数函数支持任务并行化，这可以
将任务分配给多个处理器以提升计算


效率。还提供了工具来评估每一步分析的性能。

## 安装

按照如下方式从 CRAN 安装/加载该软件包：


``` r
install.packages("warbleR")

# load package
library(warbleR)
```

要从[github](https://github.com/)安装最新的开发版本，您需要R包
[remotes](https://cran.r-project.org/package=remotes)：


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## 使用方法

该软件包包含多个小插图，详细说明其主要功能。[warbleR简介](https://marce10.github.io/warbleR/articles/warbleR.html)提供了软件包功能的概述。[注释数据格式](https://marce10.github.io/warbleR/articles/annotation_data_format.html)小插图详细描述了输入注释所需的格式。此外还有三个额外的[软件包小插图](https://marce10.github.io/warbleR/articles/)，提供了在声学分析工作流中组织函数的示例。

关于该软件包的完整描述（虽然有些过时）可参见这篇[期刊文章](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624)。

## 其他软件包

[seewave](https://cran.r-project.org/package=seewave)和[tuneR](https://cran.r-project.org/package=seewave)这两个软件包提供了大量用于声学分析和处理的函数。它们主要针对已导入到R环境中的波形对象进行操作。[baRulho](https://cran.r-project.org/package=baRulho)软件包专注于量化栖息地诱导的声学信号退化，数据输入和输出类似于[warbleR](https://cran.r-project.org/package=warbleR)。[Rraven](https://cran.r-project.org/package=Rraven)软件包方便在R和[Raven声学分析软件](https://www.ravensoundsoftware.com/)（[康奈尔鸟类学实验室](https://www.birds.cornell.edu/home)）之间交换数据，非常适合将Raven作为注释工具融入R中的声学分析工作流。[ohun](https://docs.ropensci.org/ohun/)软件包用于声音事件的自动检测，提供诊断和优化检测流程的函数。[dynaSpec](https://cran.r-project.org/package=seewave)可用于创建动态图谱（即声谱视频）。

## 引用





























请按照以下方式引用 [warbleR](https://cran.r-project.org/package=warbleR)：

Araya-Salas, M. 和 Smith-Vidaurre, G. (2017)，*warbleR: an r package to
streamline analysis of animal acoustic signals*。Methods Ecol Evol. 8，
184-191。

注意：如果您使用了任何创建频谱图或声学测量的函数，请同时引用
[tuneR](https://cran.r-project.org/package=tuneR) 和
[seewave](https://cran.r-project.org/package=seewave) 软件包




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---