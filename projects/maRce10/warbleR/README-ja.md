<div align="right">
  <details>
    <summary >🌐 言語</summary>
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


warbleR: バイオアコースティック解析の効率化
================

<!-- README.mdはREADME.Rmdから生成されています。編集する際はREADME.Rmdをご利用ください -->
<!-- バッジ: 開始 -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![プロジェクトステータス: アクティブ このプロジェクトは安定して使用可能な状態に達しており、積極的に開発されています。](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![ライセンス: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN ステータス バッジ](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![総ダウンロード数](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov テストカバレッジ](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- バッジ: 終了 -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR ロゴ" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) は、R における動物の音響信号の構造解析を支援することを目的としています。ユーザーはオープンアクセスの鳥類録音を収集するか、独自のデータをワークフローに入力して、スペクトログラムによる可視化や音響パラメータの測定を行うことができます。
[warbleR](https://cran.r-project.org/package=warbleR) は、seewave パッケージの基本的な音響解析ツールを活用し、さらに新しい音響構造解析ツールを提供します。これらのツールは、音響信号のバッチ解析にも利用可能です。

パッケージの主な特徴は以下の通りです:

- 音響構造の測定に関する多様なツール
- ループを用いて、選択テーブルで参照された音響信号に対しタスクを適用
- ワーキングディレクトリ内にスペクトログラム画像を生成し、データの整理や音響解析の検証を可能にする

パッケージは以下の機能を提供します:

- [Xeno‐Canto](https://xeno-canto.org/) の録音データの探索とダウンロード
- 複数の音声ファイルの探索、整理、操作
- 信号の自動検出（周波数および時間領域で）（より高度で使いやすい実装については R パッケージ [ohun](https://docs.ropensci.org/ohun/) をご確認ください）
- 完全な録音または個々の信号のスペクトログラム作成
















- 音響信号構造の様々な測定方法を実行する
- 測定方法の性能を評価する
- 信号をカタログ化する
- 音響信号の異なる構造レベルを特徴付ける
- 二重唱の協調性の統計解析
- データベースとアノテーションテーブルの統合

ほとんどの機能はタスクの並列化を可能にしており、
複数のプロセッサにタスクを分散させて計算効率を向上させます。
各ステップで分析の性能を評価するツールも利用可能です。

## インストール

CRANから以下のようにパッケージをインストール／読み込みします：


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---