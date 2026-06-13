warbleR: バイオアコースティック解析の効率化
================

🌐 **言語:**  
[英語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[スペイン語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[フランス語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[ドイツ語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[ポルトガル語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[イタリア語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[ロシア語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中国語（簡体）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中国語（繁体）](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[韓国語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[ヒンディー語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[タイ語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[オランダ語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[ポーランド語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[アラビア語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[ペルシア語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[トルコ語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[ベトナム語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[インドネシア語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[アッサム語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md は README.Rmd から生成されています。編集はそちらで行ってください -->
<!-- バッジ: 開始 -->

[![ライフサイクル](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![ステータス](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![プロジェクトステータス: アクティブ プロジェクトは安定した、利用可能な状態に達しており、
積極的に開発されています。](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![ライセンス: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_ステータス_バッジ](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![総ダウンロード数](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test


coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR)は、
Rにおける動物の音響信号構造の解析を容易にすることを目的としています。
ユーザーはオープンアクセスの鳥類録音を収集したり、自分自身のデータを
ワークフローに入力して、スペクトログラムの視覚化や
音響パラメータの測定を行うことができます。
[warbleR](https://cran.r-project.org/package=warbleR)は
seewaveパッケージの基本的な音響解析ツールを利用し、
音響構造解析のための新しいツールも提供します。これらのツールは
音響信号のバッチ解析にも利用できます。

パッケージの主な特徴は以下の通りです:

- 音響構造を測定する多様なツール
- ループを用いて選択テーブルで参照された音響信号にタスクを適用
- ワーキングディレクトリにスペクトログラム画像を生成して
  データの整理や音響解析の検証を可能にする

パッケージは以下の機能を提供します:

- [Xeno‐Canto](https://xeno-canto.org/)録音の探索とダウンロード
- 複数の音声ファイルの探索、整理、操作
- 信号の自動検出（周波数・時間）（より詳細で使いやすい実装はRパッケージ[ohun](https://docs.ropensci.org/ohun/)を確認）
- 完全な録音または個々の信号のスペクトログラム作成
- 音響信号構造の様々な測定の実行
- 測定手法の性能評価
- 信号のカタログ化
- 音響信号における様々な構造レベルの特徴付け
- デュエット協調の統計解析
- データベースと注釈テーブルの統合

ほとんどの関数はタスクの並列化を許可しており、複数のプロセッサ間でタスクを分散して計算効率を向上




効率。各ステップで分析のパフォーマンスを評価するためのツールも利用可能です。

## インストール

CRANからパッケージをインストール／ロードするには、次のようにします：


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

## 使用方法

このパッケージには、その主な機能を説明するいくつかのビネットが含まれています。
[warbleR入門](https://marce10.github.io/warbleR/articles/warbleR.html)
では、パッケージの機能概要を提供しています。ビネット
[アノテーションデータ形式](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
では、入力アノテーションに必要な形式について詳細に説明しています。また、音響解析ワークフローで関数を整理する方法の例を示した、3つの追加[パッケージビネット](https://marce10.github.io/warbleR/articles/)もあります。

パッケージの完全な説明（やや古いですが）は、この[ジャーナル記事](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624)で見つけることができます。

## 他のパッケージ

[seewave](https://cran.r-project.org/package=seewave) および
[tuneR](https://cran.r-project.org/package=seewave) パッケージは、音響解析と操作のための豊富な関数を提供しています。これらは主に、すでにR環境にインポートされたウェーブオブジェクトで動作します。
[baRulho](https://cran.r-project.org/package=baRulho) パッケージは、音響信号の生息地による劣化を定量化することに焦点を当てており、データの入力と出力は
[warbleR](https://cran.r-project.org/package=warbleR) に類似しています。パッケージ
[Rraven](https://cran.r-project.org/package=Rraven) は、Rと[Raven音響解析ソフトウェア](https://www.ravensoundsoftware.com/)（[コーネル大学鳥類学研究所](https://www.birds.cornell.edu/home)）とのデータ交換を容易にし、RでRavenをアノテーションツールとして音響解析ワークフローに組み込む際に非常に役立ちます。パッケージ
[ohun](https://docs.ropensci.org/ohun/) は、音イベントの自動検出に対応し、検出ルーチンを診断・最適化する関数を提供します。[dynaSpec](https://cran.r-project.org/package=seewave) は、
動的スペクトログラム（すなわちスペクトログラム動画）の作成を可能にします。

## 引用



















[warbleR](https://cran.r-project.org/package=warbleR)を以下のように引用してください:

Araya-Salas, M. および Smith-Vidaurre, G. (2017), *warbleR: 動物の音響信号解析を効率化するRパッケージ*。Methods Ecol Evol. 8, 184-191。

注意: スペクトログラムの作成や音響測定機能を使用する場合は、
[tuneR](https://cran.r-project.org/package=tuneR)および
[seewave](https://cran.r-project.org/package=seewave)パッケージも
併せて引用してください





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---