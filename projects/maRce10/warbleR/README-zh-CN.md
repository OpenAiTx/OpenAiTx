warbleR：简化生物声学分析
================

<!-- README.md 是由 README.Rmd 生成的。请编辑该文件 -->
<!-- 徽章：开始 -->

[![生命周期](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![依赖](https://tinyverse.netlify.com/badge/warbleR)](https://cran.r-project.org/package=warbleR)
[![项目状态：活跃 该项目已达到稳定、可用状态
且正在积极
开发中。](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![许可证](https://img.shields.io/badge/licence-GPL--2-blue.svg)](https://www.gnu.org/licenses/gpl-3.0.en.html)
[![CRAN 状态徽章](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![总下载量](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov 测试覆盖率](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
[![R-CMD 检查](https://github.com/maRce10/warbleR/workflows/R-CMD-check/badge.svg)](https://github.com/ropensci/baRulho/actions/workflows/R-CMD-check.yaml)
<!-- 徽章：结束 -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR 标志" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) 旨在
方便在 R 中分析动物声学信号的结构。
用户可以收集开放访问的鸟类录音或输入自己的
数据，进入一个便于频谱图可视化和
声学参数测量的工作流程。
[warbleR](https://cran.r-project.org/package=warbleR) 利用
seewave 包的基础声音分析工具，并提供新的
声学结构分析工具。这些工具支持
声学信号的批量分析。

该包的主要功能包括：

- 多样的声学结构测量工具
- 使用循环通过选择表中引用的声学信号
  执行任务
- 在工作目录生成包含频谱图的图像，
  方便用户组织数据和验证声学分析



该包提供以下功能：

- 浏览和下载 [Xeno‐Canto](https://xeno-canto.org/) 录音
- 浏览、组织和操作多个音频文件
- 自动检测信号（频率和时间上）（但请查看 R 包 [ohun](https://docs.ropensci.org/ohun/) 以获得更全面和友好的实现）
- 创建完整录音或单个信号的声谱图
- 运行不同的声学信号结构测量
- 评估测量方法的性能
- 信号编目
- 描述声学信号中的不同结构层次
- 二重唱协调的统计分析
- 整合数据库和注释表

大多数函数支持任务并行化，将任务分配给多个处理器以提高计算效率。也提供了评估每个步骤分析性能的工具。

## 安装

从 CRAN 安装/加载该包，操作如下：






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

该包包含若干介绍其主要功能的示例文档。  
[warbleR入门](https://marce10.github.io/warbleR/articles/warbleR.html)  
提供了包功能的概览。示例文档  
[注释数据格式](https://marce10.github.io/warbleR/articles/annotation_data_format.html)  
详细描述了输入注释所需的格式。还有三个额外的[包示例文档](https://marce10.github.io/warbleR/articles/)  
展示了如何在声学分析工作流程中组织函数的例子。

该包的完整描述（虽然略显过时）可以在这篇[期刊文章](https://doi.org/10.1111/2041-210X.12624)中找到。

## 其他包

包[seewave](https://cran.r-project.org/package=seewave)和  
[tuneR](https://cran.r-project.org/package=seewave)提供了大量用于声学分析和处理的函数。它们主要  
处理已导入R环境中的wave对象。包[baRulho](https://cran.r-project.org/package=baRulho)专注于  
量化栖息地引起的声学信号退化，其数据输入输出与  
[warbleR](https://cran.r-project.org/package=warbleR)类似。包  
[Rraven](https://cran.r-project.org/package=Rraven)促进了R与[Raven声音分析软件](https://www.ravensoundsoftware.com/)  
（[康奈尔鸟类学实验室](https://www.birds.cornell.edu/home)）之间的数据交换，并且对于将Raven作为注释工具  
集成到R中的声学分析工作流程非常有用。包  
[ohun](https://docs.ropensci.org/ohun/)专注于自动检测声音事件，提供诊断和优化检测流程的函数。  
[dynaSpec](https://cran.r-project.org/package=seewave)允许创建动态声谱图（即声谱图视频）。

## 引用















请引用 [warbleR](https://cran.r-project.org/package=warbleR) 如下：

Araya-Salas, M. 和 Smith-Vidaurre, G. (2017), *warbleR: 一个用于简化动物声学信号分析的 R 包*. Methods Ecol Evol. 8, 184-191。

注意：如果您使用任何生成声谱图或声学测量功能，请同时引用
[tuneR](https://cran.r-project.org/package=tuneR) 和
[seewave](https://cran.r-project.org/package=seewave) 包。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---