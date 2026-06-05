# Beampy [![Build Status](https://travis-ci.com/hchauvet/beampy.svg)](https://travis-ci.com/hchauvet/beampy) [![codecov](https://codecov.io/gh/hchauvet/beampy/graph/badge.svg)](https://codecov.io/gh/hchauvet/beampy) ![pypi python version](https://img.shields.io/pypi/pyversions/beampy-slideshow.svg) ![pypi licence](https://img.shields.io/pypi/l/beampy-slideshow.svg) ![pypi download](https://img.shields.io/pypi/dm/beampy-slideshow.svg) ![pypi beampy version](https://img.shields.io/pypi/v/beampy-slideshow.svg)

**master ブランチの開発は現在凍結されています（緊急のバグ修正のみがプッシュされます）。beampy の新しいバージョンは現在 dev ブランチで開発中ですが、まだ十分に安定していません…**

Beampy は HTML5 で表示可能な svg スライドショーを作成するための Python ツールです
（Firefox と Chromium でテスト済み）
スライドのサイズは固定されており、Latex Beamer ドキュメントのようになっています。

Beampy のプレゼンテーションは、すべてのコンテンツを埋め込んだ単一の html ファイルを出力します。

* [Beampy ドキュメントを見る](https://hchauvet.github.io/beampy/)
* [Beampy テストプレゼンテーションを見る](https://rawgit.com/hchauvet/beampy/master/examples/beampy_tests.html)（ソースは *examples/beampy_tests_modules.py* にあります）

## インストール:

Python パッケージインデックスから:

```bash
pip install beampy-slideshow
```

[See full installation documentation](https://hchauvet.github.io/beampy/install.html#beampy-install)

## A quick example :

```python
from beampy import *

doc = document()

with slide():
    maketitle('Beampy a tool to make simple presentation', ['H. Chauvet'])

with slide('Beampy test'):
    text(r'\href{#0}{Go to Title}')
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')

with slide('Beampy test with animated layers'):
    text(r'\href{#0}{Go to Title}')[:]
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')[1]

save('./simple_one.html')

#To save in pdf just change the above command to the following
#save('./simple_one.pdf')
```

[beampy_presentation.html](https://cdn.rawgit.com/hchauvet/beampy/master/examples/simple_one.html)



## 変更履歴:

### 0.5.5
* python 2 と 3 のエンコーディングに関する重要な問題を修正。
* dvisvgm によって生成された svg の参照欠落問題を修正
  （詳細は [#18](https://github.com/hchauvet/beampy/issues/18) を参照）、latex の一部が
  svg に欠落する問題の原因となっていた。
* 一時ファイルの管理を改善。
* scour（svg 最適化ツール）を最新バージョンに更新。

### 0.5.4

* Beampy は python 3 と 2 の互換性を持つようになりました（少なくとも 2.7 と 3.7）。
* pytest フレームワークを用いた統合テストを導入（コア機能のユニットテストはまだなし）。
* 複数フォーマット同時保存時のバグを修正し、テキストの重複を解消 [issue #13](https://github.com/hchauvet/beampy/issues/13)。
* logging.debug のモード出力を追加。
* プレゼンテーションソースファイルの場所を指定するオプションを追加（ doc = document(source_filename=__name__) ）。

### 0.5.3

いくつかの小さな修正：
* ボックスのレイヤー伝播のバグを修正。
* 最後のレイヤーが [n:] と設定された場合のバグを修正。
* モジュール内で logging.debug の使用を開始。

### 0.5.2

* tikz dvi に対する dvisvgm 出力のバグを修正（latex2svg 関数に
  dvisvgm が生成した svg を書き出すオプションを追加）。
* tableofcontents モジュールを追加 [ドキュメントを見る](https://hchauvet.github.io/beampy/auto_examples/plot_TOC.html)。
* BeamerFrankfurt テーマを追加 [ドキュメントを見る](https://hchauvet.github.io/beampy/auto_themes/theme_BeamerFrankfurt.html)。
* Figure モジュールでアニメーション gif を受け入れるように。
* text モジュールに "extra_packages" 引数で追加の latex パッケージを指定可能に。


* レンダリング速度を向上させるsvgの長方形と円のサイズを計算する（Inkscapeを呼び出す必要はありません）。
* boxモジュールを改善しました（現在はgroupのサブクラスです）[ドキュメント参照](https://hchauvet.github.io/beampy/auto_examples/plot_box.html)。
* convert_unit関数のいくつかのスケールファクターを修正しました。
* 幅と高さは現在Lengthオブジェクトであり、次のような複雑な操作を受け入れます：



  ```python

  # 50% of the currentwidth 
  a = rectangle(width='50%', height=10)

  # width/height relative to the a element
  b = rectangle(width=a.width/2+'2cm', height=a.height/'10pt')
  ```

* モジュールの位置（x,y）操作は現在、Lengthオブジェクト（幅/高さ）を受け入れます:

  ```python

  a = rectangle(width='50%', height=10)

  b = rectangle(x=a.width+'2cm', y=a.height+5)
  ```
  
* beampyのコアを変更し、位置や長さの操作が必要なときに要素をレンダリングするようにした（すなわち、幅や高さが不明な要素に対して操作を行う場合、その要素はサイズを取得して操作を可能にするためにレンダリングされる）
* モジュールのオーバーレイ順序を変更するための「zorder」操作（上/下/最後/最初）を追加した：





  ```python

  a = rectangle(x='center', y='center', width=50, height=50)
  b = rectangle(x='center', y='center', width=a.height+100,
                height=a.height+100, color='red')

  # Make b appears below a
  b.below(a)
  
  # equivalent to a.above(b) or a.last() or b.first()
  ```

### 0.5.1

* bokehフィギュアのいくつかのバグを修正（[Silmathoron](https://github.com/Silmathoron)に感謝）
* bokehフィギュアのリサイズを修正し、現在はbokehの「sizing_mode = scale_both」を使用し、bokehのdivのCSS変換スケーリングを元に戻すようにした。
* bokehのjavascriptローダーを修正（新しいbokehバージョン（>0.12.6）はメインdivを「bk_root」と名付けている）
* beampyキャッシュクラスにファイルをキャッシュする関数を追加
* bokehのjavascript外部ライブラリファイルをキャッシュ（CDNからダウンロード、もし「doc = document(cache=False)」の場合）


### 0.5.0
* グループを装飾するbox関数を追加
* コンテキストマネージャを使ってプレゼンテーション内にテキストを書く新しい実験的な方法を追加

  ```python
  with text(width=400):
       """
       Any comment inside the context manager will be passed to the
       text function as input argument. This allows clearer source
       when writing long texts.

       No more need to add an *r* before to protect the text passed to
       latex, it's now automatically added.
       """
  ```
  
* 1つのスライドにHTMLオブジェクトのみが存在する場合のバグを修正
* ドキュメントのインストールセクションの小さな誤字を修正

### 0.4.9

* [Beampyドキュメント](https://hchauvet.github.io/beampy/)の初稿を作成
* Beampyモジュールにドキュメントを追加
* モジュールの配置に使うバウンディングボックスに沿ったアンカーを定義するため、位置辞書に 'anchor' キーを追加
* beampyモジュールを呼び出す関数を格納するためutils.pyを追加
* Beampyモジュールの周りにアンカー付きのバウンディングボックスを描画する関数 **bounding_box(module)** をutils.pyに追加。スライド上に軸を描画する関数 **draw_axes()** も追加

### 0.4.8

* Issue #12を部分的に修正
* コードの構文をクリーンアップ

### 0.4.7

* レイヤーメカニズムを導入。スライド要素はレイヤーによってアニメーション化でき、beamerの "\only" のような機能を実現。
  レイヤーはBeampyモジュールに対するPythonのスライス操作として管理される。




  ```python 
  with slide('Test layers'):
    text('First printed on layer 0')
    text('Secondly printed on layer 1')[1]
    text('Printed from layer 2 to 3')[2,3]
    text('Printed on all layers')[:]
    text('Printed on layer 4')[4]
    
    with group(width=300)[2:]:
        text('Printed inside group')
        text('for layers 2 to end')
  ```
  

### 0.4.6

* The core of Beampy slide processor has been rewritten and now allows recursive group of elements.

  ```python
  with group():
    text('toto')
    with group(width=300):
        text('tata')

        with group(width=200):
            figure('./niceplot.pdf')
            text('nice legend')
  ```
* グループ幅が指定されている場合、幅が指定されていないグループ内のすべての要素はグループの幅を取ります


  ```python
  with group(width=200):
    figure('./niceplot.pdf')
    text('nice legend')
    # Figure and text width will be automatically set to 200 px
  ```
* 相対配置は現在、自動配置された要素にも適用可能です


  ```python
  t0 = text('toto')
  text('tata', x=t0.center + center(0), t0.bottom + 0.1)
  ```

* ビデオは現在、htmlファイルに含めるのではなく、外部リンク（*embedded=True*付き）を使用できます。
  スライドが画面に表示されるときにディスクからビデオが読み込まれます（ファイルパスに注意してください）。

### 0.4.5

* すべてのテキストは単一のlatexファイルで前処理されます（Latexは一度だけ呼び出されます：コンパイル時間の改善）
* キャッシュのバグ修正：ビデオとsvgは正しくキャッシュされるようになりました

### 0.4.4

* キャッシュの改善：要素ごとに1ファイルをキャッシュ（キャッシュを二重に書き込まない！）
* Svg：線と長方形のコマンドを追加し、線や長方形を簡単に描画可能に
* 相対配置：現在の要素のアンカーを変更するためのショートカット center(shift)、right(shift)、bottom(shift) を追加 
  

  ```python 
    e1 = text('Somthing', x=0.2, y=0.4)
    e2 = text('An other thing', 
              x=e1.left + right(0.1), 
              y=e1.center + center(0))
  ```


### 0.4.3

* Matplotlibの図を直接*figure()*に渡せるようになり、複数のmatplotlib図を*animatesvg()*でアニメーション化可能に
* キャッシュサイズの小幅改善（内容はキャッシュファイルに保存されなくなった）
* scourバージョン（svg-optimiser）の更新

### 0.4.2
* Latexからのグリフパスがユニークになった（これによりドキュメント内のsvg行数が減少）
* スライドに生のsvgを含めるための*svg*コマンドを追加
* テーマの柔軟性を向上し、インタラクティブ要素を持つ背景が作成可能に！

### 0.4.1
* すべてのスライドがRAMにロードされるようになり、速度が向上
* モジュールはすべて"beampy_module"という基底クラスを継承するクラスに変更（modules/core.py内）
* キャッシュはすべてのフォーマット（pdf, svg, html）で共通化され、特別なキーをモジュールに追加してキャッシュIDを生成可能

## インストール

[Beampyドキュメントのインストールページを参照](https://hchauvet.github.io/beampy/install.html)







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---