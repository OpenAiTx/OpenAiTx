[![CRAN Version](https://www.r-pkg.org/badges/version/iCellR)](https://cran.r-project.org/package=iCellR)
[![CRAN Downloads](https://cranlogs.r-pkg.org/badges/iCellR)](https://cran.r-project.org/package=iCellR)
[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

# 单细胞 (i) R 包 (iCellR)
iCellR 是一个交互式 R 包，旨在简化高通量单细胞测序数据的分析和可视化。它支持多种单细胞技术，包括 `scRNA-Seq`、`scVDJ-Seq`、`scATAC-Seq`、`CITE-Seq` 和 `空间转录组学`（ST）。

维护者：[Alireza Khodadadi-Jamayran](https://scholar.google.com/scholar?q=author:%22Khodadadi-Jamayran%20A%22)

### 新闻（2021年4月）
使用最新版本的 iCellR（v1.6.4）进行 scATAC-seq 和空间转录组学（ST）分析。利用 [i.score](https://github.com/rezakj/iCellR/wiki/i.score) 函数基于基因特征进行细胞评分，支持的方法包括 `Tirosh`、`Mean`、`Sum`、`GSVA`、`ssgsea`、`Zscore` 和 `Plage`。

### 新闻（2020年7月）
探索 iCellR 版本 1.5.5，新增加了细胞周期分析工具（`阶段 G0、G1S、G2M、M、G1M 和 S`）。查看示例 [phase](https://genome.med.nyu.edu/results/external/iCellR/example1/All_cellcycle.png)，新增伪时间抽象 KNetL（PAK 图）功能——可视化伪时间进程 [(PAK 图)](https://genome.med.nyu.edu/results/external/iCellR/example1/pseudotime.KNetL.png)。使用更新的可视化工具执行基因-基因相关性分析。[相关性](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png)。

### 新闻（2020年5月）
探索 `KNetL 图`，一种先进的可调节动态降维方法 [KNetL 图](https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png) <img src="https://github.com/rezakj/scSeqR/blob/master/doc/logo.png" alt="drawing" width="30"/> KNetL（发音“nettle”）提供增强的缩放能力 [KNetL](https://www.biorxiv.org/content/10.1101/2020.05.05.078550v1.full)，显示的细节远超 tSNE 和 UMAP。

### 新闻（2020年4月）
引入 `插补和覆盖校正（CC）` 方法以改进基因-基因相关性分析。([CC](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png))。使用 iCellR 的 CPCA 和 CCCA 工具执行 `批次对齐`（CCCA 和 [CPCA](https://genome.med.nyu.edu/results/external/iCellR/example2/AllCondsClusts.png)）[方法](https://www.biorxiv.org/content/10.1101/2020.03.31.019109v1.full)。扩展的细胞类型预测数据库现包括 ImmGen 和 MCA。

### 新闻（2018年9月）
`scSeqR` 已更名为 `iCellR`，并停止支持 scSeqR。请改用 iCellR，因为 scSeqR 不再维护。iCellR 新增了 `UMAP`。新增交互式 `细胞门控`，允许用户通过 Plotly 在 HTML 图中直接选择细胞。

### 教程和手册
- `手册` 链接 [手册](https://cran.r-project.org/web/packages/iCellR/iCellR.pdf) 和 综合 R 存档网络 [(CRAN)](https://cran.r-project.org/web/packages/iCellR/index.html)。
- 获取 `入门` 和 `教程` 请访问我们的 [Wiki 页面](https://github.com/rezakj/iCellR/wiki)。
- CITE-Seq 和 scRNA-Seq 分析视频教程链接：[视频](https://vimeo.com/337822487)
- KNetL 图的全部内容介绍：[视频](https://youtu.be/tkoPTVciQm0)
- 如果您使用 `FlowJo` 或 `SeqGeq`，它们提供 iCellR 和其他单细胞分析工具的插件。您可以在此处找到所有插件列表：https://www.flowjo.com/exchange/#/ 。具体的 iCellR 插件可在此处找到：https://www.flowjo.com/exchange/#/plugin/profile?id=34。此外，SeqGeq 差异表达（DE）教程可指导您完成流程：[SeqGeq DE 教程](https://www.youtube.com/watch?v=gXFmWRpdwow)

引用 `iCellR` 请使用此文献 [PMID: 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)

iCellR publications: [PMID: 35660135](https://pubmed.ncbi.nlm.nih.gov/35660135/) (scRNA-seq/KNetL) [PMID: 35180378](https://pubmed.ncbi.nlm.nih.gov/35180378/) (CITE-seq/KNetL), [PMID: 34911733](https://pubmed.ncbi.nlm.nih.gov/34911733/) (i.score and cell ranking), [PMID: 34963055](https://www.cell.com/cell/fulltext/S0092-8674(21)01427-6?_returnURL=https%3A%2F%2Flinkinghub.elsevier.com%2Fretrieve%2Fpii%2FS0092867421014276%3Fshowall%3Dtrue) (scRNA-seq), [PMID 31744829](https://www.ncbi.nlm.nih.gov/pubmed/31744829) (scRNA-seq), [PMID: 31934613](https://www.ncbi.nlm.nih.gov/pubmed/31934613) (bulk RNA-seq from TCGA), [PMID: 32550269](https://pubmed.ncbi.nlm.nih.gov/32550269/) (scVDJ-seq), [PMID: 34135081](https://jasn.asnjournals.org/content/32/8/1987), [PMID: 33593073](https://www.ahajournals.org/doi/10.1161/CIRCRESAHA.120.317914), [PMID: 34634466](https://pubmed.ncbi.nlm.nih.gov/34634466/), [PMID: 35302059](https://pubmed.ncbi.nlm.nih.gov/35302059/), [PMID: 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)


Single (i) Cell R package (iCellR)

<p align="center">
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/first.gif" width="400"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out2.gif" width="400"/>
		 <img src="https://github.com/rezakj/scSeqR/blob/master/doc/Slide1_1.png"/>
			 <img src="https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out3.gif" width="400"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out4.gif" width="400"/> 
	  <img src="https://github.com/rezakj/scSeqR/blob/master/doc/gating2.gif"/>
</p>

***

## For `getting started` and `tutorials` go to our [Wiki page](https://github.com/rezakj/iCellR/wiki).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---