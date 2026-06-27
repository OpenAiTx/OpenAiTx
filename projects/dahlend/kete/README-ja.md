<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *Kete*

小惑星や彗星の軌道を大規模に予測します。

[arXiv論文](http://arxiv.org/abs/2509.04666)をご覧ください。

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

keteツールは、小惑星の全天サーベイのシミュレーションを可能にすることを目的としています。  
これには多体物理の軌道力学、軌道決定とフィッティング、天体の熱および光学モデリング、視野と光遅延の補正が含まれます。  
これらのツールは、小惑星センター（MPC）やJPLの既知小惑星データベースと組み合わせて、サーベイの計画だけでなく、既存または過去のサーベイで観測可能な天体の予測にも使用できます。

keteの主な目標は、特定の天体をクエリすることなく、MPCカタログ全体に対して一括で動作するツールセットを提供することです。  
NEO Surveyorミッションの10年以上にわたるサーベイ時間を、1000万のメインベルトおよび地球近傍小惑星を用いてシミュレーションするために使用されました。

[ドキュメント](https://dahlend.github.io/kete/)  
   - [例](https://dahlend.github.io/kete/auto_examples/index.html)
   - [チュートリアル](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

こちらは2023年全期間にわたってZTFサーベイが観測するシミュレーションです。  
これはすべての番号付き小惑星のすべての位置と、期待されるVバンド等級の計算を含みます。  
期待される等級がZTFが報告した特定フレームの等級限界より明るければ、その天体は薄い灰色で点滅します。

この計算はデスクトップコンピュータで約50分かかり、  
動画生成には約40分かかりました。







Keteは、多くの質問に答えるために使用できます。例えば、[指定された画像](https://dahlend.github.io/kete/tutorials/kona.html)内の既知の小惑星をすべて特定することなどです。

Keteは、より楽しい可視化のバックエンドとしても使用できます。例えば：

[Ketev](https://dahlend.github.io/ketev/) - ブラウザで使える太陽系ビジュアライザー


## インストール

Keteはpipを使ってインストールできます：


``` bash
pip install kete
```

## コードの例

ここに、keteでのプログラミングがどのようなものかを示す小さな例があります。
これは、小惑星アポフィスが2029年4月に地球に
*非常に*近接する際の最接近距離を計算します。

この例のより詳細な説明は
[こちら](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html)にあります。

```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## 名前

「Kete」は古代ギリシャ神話に由来し、海の怪物を意味し、クジラ類（セタシアン）の語源となっています。

## ライセンス:

このコードのオリジナル版は、元の作者（Dar Dahlen）がCaltech IPACで勤務していた際に開発されました。  
これはそのリポジトリのフォークであり、個人プロジェクトとして作業が継続されます。  
このフォークと以前のコードの違いはBSD 3-Clauseでライセンスされていますが、著作権はDar Dahlenおよび将来の協力者に帰属します。

### 単位と基準座標系

KeteはICRF基準座標系を基本座標系として使用し、単位はAU、時間はバリセントリック力学時（TDB）スケールのJDです。  
内部的にはこの座標系は、JPL Horizonsで使用される傾斜角の定義に基づく黄道座標系に変換されます。  
これはJ2000フレームのIAU76/80モデルとして定義されています。

      - https://en.wikipedia.org/wiki/Axial_tilt#Short_term
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

JPL Horizonsおよび小惑星センター（MPC）はこの座標系を使用しており、  
実質的にJ2000黄道座標系と同等です。  
keteには赤道座標系や様々な時間の形式への変換ツールが用意されています。

### キャッシュディレクトリ

keteの多くの操作は様々なファイルのダウンロードを伴います。  
これらのファイルは自動的にキャッシュされ、このキャッシュが保存されるディレクトリは環境変数`KETE_CACHE_DIR`を設定することで変更できます。  
デフォルトのディレクトリは`~/.kete/`です。





``` bash
export KETE_CACHE_DIR="~/.kete/"
```

### コンテナでの使用 - Docker/Podman

keteは初回使用時に複数の大きなSPICEカーネルファイルをダウンロードし、
キャッシュディレクトリに保存することに注意してください。

**Docker/Podmanでの重要事項:**
- ダウンロードを**Dockerビルド中に実行した場合**（例：
  `RUN python -c "import kete"`）、ファイルはイメージに組み込まれます。
- この手順をスキップした場合、ファイルは初回コンテナ起動時にダウンロードされますが、
  **コンテナ停止時に失われます**。キャッシュディレクトリにボリュームマウントを使用しない限り。

**推奨されるDockerfileの方法:**

```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```

これにより、SPICEカーネルがイメージの一部となり、再ダウンロードの必要がなくなります。

# 開発者向け情報：

以下の情報は開発者向けであり、エンドユーザーには必要ありません。

## インストール - ソースから

keteをソースからビルドする場合、Rustコンパイラのインストールが必要です。インストール手順は以下で確認できます：

https://www.rust-lang.org/learn/get-started

Pythonが最新であることを確認してください。本コードはPython 3.9以上で動作します。

``` bash
python --version
```

pipが最新であることを確認してください。バージョンは少なくとも`22.0.0`である必要があります。
``` bash
pip --version
```

これは次のコマンドで更新できます:
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### 開発

開発を行う予定がある場合は、以下の方法でのインストールを推奨します：
``` bash
pip install '.[dev]'
```
その行の `[dev]` は、開発に役立ついくつかのオプションの依存関係をpipでインストールします。  
pytestやドキュメント作成ツールを含みます。

### ドキュメントのビルド

ドキュメントをビルドするためには、追加のPythonライブラリが必要です。  
これらは以下のコマンドでインストールできます：
``` bash
pip install sphinx sphinx_gallery autodoc
```
これがインストールされた後、ドキュメントはketeディレクトリ内で実行することでビルドできます。

``` bash
(cd docs && make html && open html/index.html&)
```
実行が完了したら、HTMLドキュメントにアクセスするためにファイル `kete/docs/html/index.html` を開いてください。

以前のドキュメントビルドをクリーンアップするには：

``` bash
(cd docs && make clean)
```

ドキュメントテストは次のコマンドで実行できます:
``` bash
(cd docs && make doctest)
```

### テストの実行

テストの実行には `pytest` と `pytest-cov` パッケージのインストールが必要です。

このフォルダのベースでターミナルを開き、次のコマンドを実行してください:
``` bash
pytest --cov-report term-missing --cov=kete   
```
別のカバレッジレポートの種類としてHTMLがあり、これはコマンドが実行されたディレクトリに`htmlcov`というフォルダを生成します。  
その後、`htmlcov/index.html`ファイルを開くことができます。  
これはコードカバレッジのユーザーフレンドリーなウェブサイト表現です。

``` bash
pytest --cov-report html --cov=kete   
```

### チュートリアルの実行

チュートリアルは、典型的な使用例をより示す計算負荷の高い例です。  
これらの例は実行に非常にコストがかかるため、手動で実行しない限り実行されません。  
そのための便利なPythonスクリプトが用意されています。

``` bash
cd docs
python utils.py
```

### ベンチマークの実行

keteのRustバックエンドにはマイクロベンチマークのテストスイートがあります。これらは
`gnuplot` のインストールが必要で、以下のコマンドで実行できます：

``` bash
cargo bench
open target/criterion/report/index.html
```
さらに、以下を使用してFlamegraphを生成することもできます:


``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```
これらのフレームグラフは `target/criterion/*/profile/flamegraph.svg` に保存されます。  
これらのファイルをウェブブラウザで開くと、ベンチマーク中に使用されている関数が表示されます。  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---