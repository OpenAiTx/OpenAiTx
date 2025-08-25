# BPCells

BPCells 是一个用于大规模 RNA-seq 和 ATAC-seq 数据集的高性能单细胞分析软件包。  
它可以在 2GB 内存下用 4 分钟时间完成 130 万细胞数据集的归一化和 PCA，或从片段坐标创建 scATAC-seq 峰矩阵，CPU 时间比 ArchR 或 SnapATAC2 少 50 倍。  
BPCells 甚至能够处理完整的 CELLxGENE 人类普查数据集，在笔记本电脑上对 4400 万细胞 x 6 万基因矩阵运行全精度 PCA 只需 6 小时，或在服务器上少于 1 小时。详情请见我们的[基准测试页面](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)。

BPCells 提供：

  - 通过位打包压缩高效存储单细胞数据集  
  - 由 C++ 支持的快速、磁盘支持的 RNA-seq 和 ATAC-seq 数据处理  
  - 下游分析，如标记基因和聚类  
  - 与 AnnData、10x 数据集、R 稀疏矩阵和 GRanges 的互操作性  
  - 已展示可扩展至 4400 万细胞的能力，运行于笔记本电脑  

此外，BPCells 还开放其优化的数据处理架构，用于扩展第三方单细胞工具（如 Seurat）

## [在我们的网站了解更多](https://bnprks.github.io/BPCells/)

- [BioRxiv 预印本](https://www.biorxiv.org/content/10.1101/2025.03.27.645853v1)  
- [Python 文档](https://bnprks.github.io/BPCells/python/index.html)  
- [基准测试](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)  
- [多组学分析示例](https://bnprks.github.io/BPCells/articles/pbmc3k.html)  
- [BPCells 工作原理](https://bnprks.github.io/BPCells/articles/web-only/how-it-works.html)  
- [更多文章](https://bnprks.github.io/BPCells/articles/index.html)  
- [函数文档](https://bnprks.github.io/BPCells/reference/index.html)  
- [新闻](https://bnprks.github.io/BPCells/news/index.html)  

## R 安装  
我们建议直接从 github 安装 BPCells：

```R
remotes::install_github("bnprks/BPCells/r")
```
安装前，您必须已在系统上安装并可访问HDF5库。  
HDF5可以通过您选择的软件包管理器安装。请参阅以下针对操作系统的具体说明。  

对于在github安装时遇到问题的Mac和Windows用户，请查看我们的[R-universe](https://bnprks.r-universe.dev/BPCells)  
页面，了解安装预编译二进制包的说明。这些二进制包会自动跟踪最新的github主分支。  

感谢Conda Forge R团队的[@mfansler](https://github.com/mfansler)，BPCells可通过conda安装（详见[issue #241](https://github.com/bnprks/BPCells/issues/241)）。  
任何关于bioconda包的问题应在[bioconda-recipes](https://github.com/bioconda/bioconda-recipes/)报告。版本更新由bioconda团队管理。  

<details>  
<summary>点击这里查看基于github安装的操作系统具体安装信息</summary>  
<div>  

### Linux  
在Linux上获取HDF5依赖通常相当简单  

- apt: `sudo apt-get install libhdf5-dev`  
- yum: `sudo yum install hdf5-devel`  
- conda: `conda install -c conda-forge hdf5`  
  - 注意：Linux用户应尽可能优先使用其发行版的软件包管理器（如`apt`或`yum`），  
    因为这通常能提供更稳定的安装体验。  

### Windows  
在Windows上从源代码编译R包需要安装[R tools for Windows](https://cran.r-project.org/bin/windows/Rtools/)。  
详情请见[Issue #9](https://github.com/bnprks/BPCells/issues/9)。  

### MacOS  
对于MacOS，通过homebrew安装HDF5似乎最为可靠：`brew install hdf5`。  

**Mac特定故障排除**：  

- **ARM架构Mac**：常见错误是安装了ARM版HDF5，但R是x86版本。  
  这会导致BPCells在安装时访问HDF5出错。  
    - 通过运行`sessionInfo()`检查R安装，查看“Platform”下显示的是ARM还是x86。  
    - 最简单的方案是使用ARM版R，因为homebrew默认安装ARM版hdf5。  
    - 也[可以](https://codetinkering.com/switch-homebrew-arm-x86/)（虽然较复杂）安装x86版本的homebrew以访问x86版hdf5。  
- **旧Mac（10.14 Mojave或更早版本）**：旧Mac默认编译器不支持所需的  
  C++17文件系统特性。详见[issue #3](https://github.com/bnprks/BPCells/issues/3#issuecomment-1375238635)。  


  通过 homebrew 设置更新编译器的提示。

### 支持的编译器
在大多数情况下，您已经拥有合适的编译器。BPCells 推荐
gcc >=9.1，或 clang >= 9.0。
这对应于 2018 年末及以后的版本。
旧版本在某些情况下可能可用，只要它们
支持基本的 C++17，但官方不支持。

</div>
</details>
<details>
<summary>点击此处查看基于 Github 安装的故障排除信息</summary>

### 一般安装故障排除
BPCells 会在编译过程中尝试打印有用的错误信息以帮助诊断问题。若需更
详细的信息，请在执行 `remotes::install_github("bnprks/BPCells/r")` 之前运行 `Sys.setenv(BPCELLS_DEBUG_INSTALL="true")`。如果在获得这些附加信息后仍无法解决问题，欢迎提交 Github 问题，并务必使用[可折叠章节](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections) 来附加详细的安装日志。

</details>

## Python 安装

BPCells 可以直接通过 pip 安装：


```shell
python -m pip install bpcells
```
## 贡献
BPCells 是一个开源项目，我们欢迎高质量的贡献。如果您  
有兴趣贡献，并且具备 C++ 以及 Python 或 R 的经验，欢迎  
随时联系我们，分享您想要实现的想法。时间允许的话，我们  
很乐意为您提供入门指导。  

如果您不熟悉 C++，贡献代码可能比较困难，  
但提供带有  
[可复现示例](https://reprex.tidyverse.org/articles/reprex-dos-and-donts.html)  
的详细错误报告仍然是很好的帮助方式。Github 问题区是  
报告这类问题的最佳论坛。  

如果您维护单细胞分析包，想利用 BPCells  
提升可扩展性，我们乐意提供建议。到目前为止，已有  
几个实验室尝试过，取得了可喜的成功。通过电子邮件是  
联系的最佳方式（可在 github 的 `DESCRIPTION` 文件中找到联系方式）。  
欢迎 Python 开发者，虽然当前的 Python 包仍处于实验阶段。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---