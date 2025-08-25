# BPCells

BPCellsは、大規模なRNA-seqおよびATAC-seqデータセットの高性能単一細胞解析のためのパッケージです。  
1.3M細胞のデータセットの正規化とPCAを2GBのRAMで4分で実行でき、また、ArchRやSnapATAC2よりも50倍少ないCPU時間でフラグメント座標からscATAC-seqピークマトリックスを作成できます。  
BPCellsは、44M細胞×60k遺伝子の完全なCELLxGENEセンサスヒトデータセットも処理可能で、ラップトップで6時間、サーバーでは1時間未満で完全精度のPCAを実行します。詳細は[ベンチマークページ](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)をご覧ください。

BPCellsは以下を提供します：

  - ビットパッキング圧縮による単一細胞データセットの効率的な保存
  - C++による高速でディスク対応のRNA-seqおよびATAC-seqデータ処理
  - マーカー遺伝子やクラスタリングなどの下流解析
  - AnnData、10xデータセット、Rのスパースマトリックス、GRangesとの相互運用性
  - ラップトップで44M細胞のスケーラビリティを実証

さらに、BPCellsは最適化されたデータ処理基盤を公開しており、3rdパーティの単一細胞ツール（例：Seurat）のスケーリングに利用可能です。

## [公式サイトで詳細を見る](https://bnprks.github.io/BPCells/)

- [BioRxivプレプリント](https://www.biorxiv.org/content/10.1101/2025.03.27.645853v1)  
- [Pythonドキュメント](https://bnprks.github.io/BPCells/python/index.html)  
- [ベンチマーク](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)  
- [マルチオミクス解析例](https://bnprks.github.io/BPCells/articles/pbmc3k.html)  
- [BPCellsの仕組み](https://bnprks.github.io/BPCells/articles/web-only/how-it-works.html)  
- [追加記事](https://bnprks.github.io/BPCells/articles/index.html)  
- [関数ドキュメント](https://bnprks.github.io/BPCells/reference/index.html)  
- [ニュース](https://bnprks.github.io/BPCells/news/index.html)  

## Rのインストール  
BPCellsはgithubから直接インストールすることを推奨します：

```R
remotes::install_github("bnprks/BPCells/r")
```
インストール前に、システムにHDF5ライブラリがインストールされており、アクセス可能である必要があります。  
HDF5はお好みのパッケージマネージャーからインストールできます。以下の各OS別の指示を参照してください。  

MacおよびWindowsユーザーでgithubからのインストールに問題がある場合は、[R-universe](https://bnprks.r-universe.dev/BPCells)  
ページを確認し、事前構築済みバイナリパッケージのインストール手順をご覧ください。これらのバイナリパッケージは最新のgithubメインブランチを自動的に追跡します。  

BPCellsは[@mfansler](https://github.com/mfansler)によるConda Forge Rチームのおかげでconda経由で利用可能です（詳細は[issue #241](https://github.com/bnprks/BPCells/issues/241)参照）。  
biocondaパッケージに関する問題は[bioconda-recipes](https://github.com/bioconda/bioconda-recipes/)に報告してください。バージョンの更新はbiocondaチームによって管理されています。  

<details>  
<summary>githubベースのインストールのためのOS別インストール情報はこちらをクリック</summary>  
<div>  

### Linux  
LinuxではHDF5依存関係の取得は通常かなり簡単です  

- apt: `sudo apt-get install libhdf5-dev`  
- yum: `sudo yum install hdf5-devel`  
- conda: `conda install -c conda-forge hdf5`  
  - 注意: Linuxユーザーは可能であればディストリビューションのパッケージマネージャ（例: `apt` や `yum`）を優先すべきです。  
    これにより若干信頼性の高いインストール体験が得られるようです。  

### Windows  
WindowsでRパッケージをソースからコンパイルするには、[R tools for Windows](https://cran.r-project.org/bin/windows/Rtools/)のインストールが必要です。詳細は[Issue #9](https://github.com/bnprks/BPCells/issues/9)を参照してください。  

### MacOS  
MacOSではhomebrew経由でHDF5をインストールするのが最も信頼できる方法のようです：`brew install hdf5`。  

**Mac特有のトラブルシューティング**:  

- **ARM CPU搭載Mac**: よくあるエラーはARMベースのHDF5をインストールしているのに、  
  Rはx86ベースのものを使っている場合です。これによりBPCellsがインストール時にHDF5へアクセスしようとした際にエラーが発生します。  
    - `sessionInfo()`を実行してRのインストールを確認し、「Platform」にARMかx86が記載されているかを確認してください。  
    - 最も簡単な方法はARM版Rを使うことです。homebrewはデフォルトでARM版のhdf5をインストールします。  
    - x86版のhomebrewをインストールしてx86版hdf5にアクセスすることも[可能](https://codetinkering.com/switch-homebrew-arm-x86/)ですが、少し複雑です。  
- **古いMac（10.14 Mojave以前）**: 古いMacのデフォルトコンパイラは必要なC++17のfilesystem機能をサポートしていません。詳細は[issue #3](https://github.com/bnprks/BPCells/issues/3#issuecomment-1375238635)を参照してください。




  tips getting a newer compiler set up via homebrew.

### Supported compilers
ほとんどの場合、すでに適切なコンパイラをお持ちでしょう。BPCellsは
gcc >=9.1、またはclang >= 9.0を推奨します。
これは2018年末以降のバージョンに対応しています。
古いバージョンでも基本的なC++17サポートがあれば
動作する場合がありますが、公式にはサポートされていません。

</div>
</details>
<details>
<summary>githubベースのインストールに関するトラブルシューティング情報はこちらをクリック</summary>

### 一般的なインストールのトラブルシューティング
BPCellsはコンパイル中に問題の診断を助けるために有益なエラーメッセージを表示しようとします。より
詳細な情報を得るには、`remotes::install_github("bnprks/BPCells/r")`の前に`Sys.setenv(BPCELLS_DEBUG_INSTALL="true")`を実行してください。それでも問題が解決しない場合は、その詳細なインストールログを[折りたたみセクション](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections)で添えてGithubのissueを作成してください。

</details>

## Python Installation

BPCellsはpipを通じて直接インストールできます：


```shell
python -m pip install bpcells
```
## 貢献について
BPCells はオープンソースプロジェクトであり、質の高い貢献を歓迎します。  
C++ に加えて Python または R の経験があり、貢献に興味がある場合は、  
実装したいアイデアをお知らせください。時間が許す限り、開始方法の指針を提供します。  

C++ に不慣れな場合、コードの貢献は難しいかもしれませんが、  
[再現可能な例](https://reprex.tidyverse.org/articles/reprex-dos-and-donts.html)を含む詳細なバグレポートは、  
依然として大きな助けとなります。Github の issue が最適なフォーラムです。  

単一細胞解析パッケージを管理していて、BPCells を使ってスケーラビリティを向上させたい場合は、  
アドバイスを喜んで提供します。これまでに数件の研究室が試みており、良好な成果を得ています。  
連絡手段としてはメールが最適です（github の `DESCRIPTION` ファイルに連絡先情報があります）。  
Python 開発者も歓迎しますが、現状の Python パッケージはまだ実験的な段階です。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---