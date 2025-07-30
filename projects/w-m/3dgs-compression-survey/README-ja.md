# 3DGS.zip: 3Dガウススプラッティング圧縮手法の調査  
このリポジトリには3Dガウススプラッティング（3DGS）圧縮手法の包括的な調査が含まれています。完全な調査表および比較プロットは[こちら](https://w-m.github.io/3dgs-compression-survey/)でご覧いただけます。  

## インストール  
このリポジトリのスクリプトを実行するには、必要な依存関係がすべてインストールされていることを確認してください。以下のコマンドでインストールできます：  

`pip install -r requirements.txt`  

## サイトのビルド  
サイトをビルドするには、次のコマンドを使用してください：  

`python data_extraction/build_html.py`  

このスクリプトは、メインブランチに変更がプッシュされるたびに自動的にサイトを再構築します。  

## 結果の取得  
次のコマンドを実行することで、結果を自動的に取得できます：  

`python data_extraction/data_extraction.py`  

このスクリプトは関連論文からデータを取得し、`results`フォルダ内の表を更新しようとします。新しい論文を追加するには、`data_extraction/data_source.yaml`にエントリを作成してください。  

## ご自身の結果の追加について  

著者の皆様には、ご自身のシーンごとの結果をGitHubリポジトリ内の指定フォルダにアップロードしていただくようお願いしております。これにより正確なデータ取得が可能となり、一貫性と公平な比較が実現します。期待されるフォルダ構成は以下の通りです：

```
results
├── DeepBlending
│   ├── drjohnson.csv
│   └── playroom.csv
├── MipNeRF360
│   ├── bicycle.csv
│   ├── bonsai.csv
│   ├── counter.csv
│   ├── flowers.csv
│   ├── garden.csv
│   ├── kitchen.csv
│   ├── room.csv
│   ├── stump.csv
│   └── treehill.csv
├── SyntheticNeRF
│   ├── chair.csv
│   ├── drums.csv
│   ├── ficus.csv
│   ├── hotdog.csv
│   ├── lego.csv 
│   ├── materials.csv
│   ├── mic.csv
│   └── ship.csv
└── TanksAndTemples
    ├── train.csv
    └── truck.csv
```
フォルダーには、あなたの手法が評価されたすべてのデータセットが含まれている必要があり、フォルダー構造で指定されたすべてのシーンを網羅している必要があります。

各CSVファイルは以下のように構成されている必要があります：


```
Submethod,PSNR,SSIM,LPIPS,Size [Bytes],#Gaussians
Baseline,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
-SubmethodName,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx

```
PSNRの結果は少なくとも小数点以下2桁の精度で報告し、SSIMおよびLPIPSの結果は少なくとも小数点以下3桁の精度で報告するようにしてください。著者には、完全な精度で結果を提供することを推奨します。これらの結果は調査に含める前に丸められます。

全てのファイルで一貫したサブメソッド名を最大2つまで含めてください。これにより、調査表に表示されます。これらの名前は表内でアプローチ名と連結されます。サブメソッド指定子をメソッド名とスペースで区切る場合は、そのスペースをサブメソッド名の前に含めてください。表にアプローチ名のみを表示したい場合は、その結果のサブメソッド名として「Baseline」を使用できます。サブメソッド名のない結果はプロットにのみ表示されます。

例は[こちら](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/tree/main/results)で確認できます。

### 重要：3DGSテスト規約

著者は元の[3DGSプロジェクト](https://github.com/graphdeco-inria/gaussian-splatting)で確立されたテスト規約を遵守する必要があります。具体的には以下を含みます：

- MipNeRF360データセットの9シーンすべてを使用し、[追加シーン](https://storage.googleapis.com/gresearch/refraw360/360_extra_scenes.zip)「flowers」と「treehill」も含めること。
- 画像は最大辺が1600pxまでのフル解像度で評価すること。より大きいテスト画像は最長辺が1600pxになるように縮小する（MipNeRF360にのみ適用）。リサイズは3DGSに準拠し、標準のPIL ```.resize()``` メソッドをバイキュービック再サンプリングで使用していることを確認してください。  
- 3つのCOLMAPデータセット（Tanks and Temples、Deep Blending、MipNeRF360）では、8枚ごとに1枚の画像をテストに使用する。具体的には、```idx % 8 == 0``` の画像がテスト画像です。
- Blenderデータセット（SyntheticNeRF）では、あらかじめ定義されたトレイン/評価分割に従うこと。

## LaTeX表

最新の調査表のLaTeX版は[圧縮用](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_compression.tex)と[密化用](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_densification.tex)で入手可能です。比較したい場合は表の一行をコピーして研究に利用してください。表全体をコピーする場合は、以下のパッケージおよび定義をLaTeXのプリアンブルに追加する必要があるかもしれません：


```
\usepackage{booktabs}
\usepackage[table]{xcolor}
% colors for table
\definecolor{lightred}{HTML}{FF9999}
\definecolor{lightyellow}{HTML}{FFFF99}
\definecolor{lightorange}{HTML}{FFCC99}
\usepackage{makecell}
\usepackage{adjustbox}
% make text the same size even when its bold in a table
\newsavebox\CBox
\def\textBF#1{\sbox\CBox{#1}\resizebox{\wd\CBox}{\ht\CBox}{\textbf{#1}}}
```

## 引用

もし私たちの調査を研究で使用する場合は、私たちの作品を引用してください。以下のBibTeXエントリを使用できます：

```bibtex
@article{3DGSzip2025,
author = {Bagdasarian, M. T. and Knoll, P. and Li, Y. and Barthel, F. and Hilsmann, A. and Eisert, P. and Morgenstern, W.},
title = {{3DGS.zip}: A {Survey} on {3D} {Gaussian} {Splatting} {Compression} {Methods}},
journal = {Computer Graphics Forum},
pages = {e70078},
year = {2025},
keywords = {CCS Concepts, • Information systems → Data compression, • Computing methodologies → Rasterization, • General and reference → Surveys and overviews},
doi = {https://doi.org/10.1111/cgf.70078},
url = {https://onlinelibrary.wiley.com/doi/abs/10.1111/cgf.70078},
eprint = {https://onlinelibrary.wiley.com/doi/pdf/10.1111/cgf.70078},
note = {\url{https://w-m.github.io/3dgs-compression-survey/}},
} 
```
## 更新情報
- 2025-04-29: 論文公開、Readmeおよびウェブサイトのbibtexを更新
- 2025-03-04: GaussianSpaの概要を追加（著者提供）
- 2025-02-26: HEMGSを追加
- 2025-02-25: GaussianSpaを追加
- 2025-02-25: HAC++を追加
- 2025-02-25: FCGSを追加
- 2025-02-10: 出版取り下げのためIGSを削除
- 2025-02-05: CodecGSを追加
- 2024-11-21: ContextGSを追加
- 2024-11-07: CompGSを追加
- 2024-11-05: [arXiv](https://arxiv.org/abs/2407.09510)版を更新、圧縮およびコンパクション手法と3DGS圧縮の基礎を追加
- 2024-10-21: ウェブサイト上で「densification」手法を調査論文に合わせて「compaction」手法に正式改名
- 2024-10-17: GaussiansPro、AtomGS、Taming3DGSをdensification/compaction手法に追加
- 2024-10-14: MesonGSを圧縮手法に追加
- 2024-09-30: densification手法を調査に追加
- 2024-09-17: Morgensternらの結果を更新し、[テスト規約の混乱](https://github.com/YihangChen-ee/HAC/issues/14)によりHACの結果を元に戻す
- 2024-09-05: Scaffold-GS MipNeRF-360の結果を全9シーンに更新
- 2024-08-27: IGS手法を調査に追加
- 2024-08-26: gsplat手法を調査に追加
- 2024-08-14: 属性およびデータセット選択に基づく適応ランク
- 2024-08-12: モデルサイズではなくガウス数に対するメトリクスの新しいプロット
- 2024-08-08: 表示するメトリクスとデータセットを選択するチェックボックスを追加
- 2024-08-07: 調査にガウス数を含め、表にガウスあたりビット数を追加
- 2024-08-02: 発表論文の学会を表示
- 2024-06-19: 利用可能な全データセットでの新ランク計算
- 2024-06-17: 手法のランクを含める
- 2024-06-17: 調査を[arXiv](https://arxiv.org/abs/2407.09510)で初公開
- 2024-06-13: モデルサイズに対するメトリクスのプロットを追加
- 2024-06-10: インタラクティブテーブル付き調査ページの初稿


<!-- - 2024-08-22: 事前学習済み[圧縮シーン](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/releases/tag/eccv-2024-data)をリリース
- 2024-07-09: プロジェクトウェブサイトをTLDR、貢献、知見、並行手法との比較で更新
- 2024-07-01: 本研究が**ECCV 2024**に採択 🥳
- 2024-06-13: トレーニングコード公開
- 2024-05-14: 圧縮スコア改善！論文v2の新結果を[プロジェクトウェブサイト](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)で公開
- 2024-05-02: arXivの[論文v2](https://arxiv.org/pdf/2312.13299)を改訂：球面調和関数の圧縮追加、改善された圧縮手法で結果更新（全属性をJPEG XLで圧縮）、追加シーンの定性的比較追加、圧縮説明と比較を本論文に移動、「Making Gaussian Splats smaller」との比較追加
- 2024-02-22: 並び替えアルゴリズムのコードを[fraunhoferhhi/PLAS](https://github.com/fraunhoferhhi/PLAS)で公開
- 2024-02-21: 異なるシーンのビデオ比較を[プロジェクトウェブサイト](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)で公開
- 2023-12-19: プレプリントを[arXiv](https://arxiv.org/abs/2312.13299)で公開 -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---