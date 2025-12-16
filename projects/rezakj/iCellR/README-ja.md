[![CRAN Version](https://www.r-pkg.org/badges/version/iCellR)](https://cran.r-project.org/package=iCellR)
[![CRAN Downloads](https://cranlogs.r-pkg.org/badges/iCellR)](https://cran.r-project.org/package=iCellR)
[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

# Single (i) Cell R パッケージ (iCellR)
iCellR は、高スループット単一細胞シーケンスデータの解析と可視化を支援するインタラクティブな R パッケージです。`scRNA-Seq`、`scVDJ-Seq`、`scATAC-Seq`、`CITE-Seq`、および `Spatial Transcriptomics`（ST）など、多様な単一細胞技術をサポートします。

メンテナ: [Alireza Khodadadi-Jamayran](https://scholar.google.com/scholar?q=author:%22Khodadadi-Jamayran%20A%22)

### ニュース（2021年4月）
scATAC-seq および Spatial Transcriptomics (ST) 分析には最新の iCellR バージョン (v1.6.4) を使用してください。[i.score](https://github.com/rezakj/iCellR/wiki/i.score) 関数を活用して、`Tirosh, Mean, Sum, GSVA, ssgsea, Zscore, Plage` などの方法で `遺伝子シグネチャに基づく細胞のスコアリング` が可能です。

### ニュース（2020年7月）
iCellR バージョン 1.5.5 では、細胞周期解析ツール（`フェーズ G0, G1S, G2M, M, G1M, S`）が追加されました。例の [phase](https://genome.med.nyu.edu/results/external/iCellR/example1/All_cellcycle.png) をご覧ください。新しい擬似時間抽象化 KNetL (PAK マップ) 機能が追加され、擬似時間の進行を可視化できます [(PAK マップ)](https://genome.med.nyu.edu/results/external/iCellR/example1/pseudotime.KNetL.png)。更新された可視化ツールを用いて遺伝子間相関分析も可能です。[相関](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png)。

### ニュース（2020年5月）
高度な調整可能かつ動的な次元削減手法である `KNetL マップ` をご紹介します [KNetL マップ](https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png) <img src="https://github.com/rezakj/scSeqR/blob/master/doc/logo.png" alt="drawing" width="30"/> KNetL（「ネットル」と発音）は、tSNE や UMAP と比較して大幅に詳細を表示できる拡大機能を提供します [KNetL](https://www.biorxiv.org/content/10.1101/2020.05.05.078550v1.full)。

### ニュース（2020年4月）
遺伝子間相関解析を改善するための `補完およびカバレッジ補正（CC）` 手法を導入しました。([CC](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png))。iCellR の CPCA と CCCA ツールを使用した `バッチアラインメント` が可能です（CCCA と [CPCA](https://genome.med.nyu.edu/results/external/iCellR/example2/AllCondsClusts.png)）[手法](https://www.biorxiv.org/content/10.1101/2020.03.31.019109v1.full)。細胞型予測のデータベースが拡充され、ImmGen と MCA が含まれています。

### ニュース（2018年9月）
`scSeqR` は `iCellR` に名称変更され、scSeqR はサポート終了となりました。今後は iCellR をご利用ください。iCellR に `UMAP` が追加されました。インタラクティブな `細胞ゲーティング` 機能が追加され、Plotly を用いた HTML プロット内で直接細胞選択が可能です。

### チュートリアルとマニュアル
- `マニュアル` [Manual](https://cran.r-project.org/web/packages/iCellR/iCellR.pdf) および Comprehensive R Archive Network [(CRAN)](https://cran.r-project.org/web/packages/iCellR/index.html) へのリンク。
- `はじめに` と `チュートリアル` は当社の [Wiki ページ](https://github.com/rezakj/iCellR/wiki) をご覧ください。
- CITE-Seq および scRNA-Seq 解析のビデオチュートリアル: [Video](https://vimeo.com/337822487)
- KNetL マップに関するすべて: [Video](https://youtu.be/tkoPTVciQm0)
- `FlowJo` または `SeqGeq` を使用している場合、iCellR および他の単一細胞解析ツールのプラグインを提供しています。すべてのプラグイン一覧は https://www.flowjo.com/exchange/#/ にあります。特に iCellR プラグインはこちらです: https://www.flowjo.com/exchange/#/plugin/profile?id=34。さらに、SeqGeq の差次的発現（DE）チュートリアルも用意されています: [SeqGeq DE tutorial](https://www.youtube.com/watch?v=gXFmWRpdwow)

`iCellR` を引用する場合はこちらを使用してください [PMID: 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)

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