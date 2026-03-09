# 地球表面スペクトルの時間的埋め込みによる表現と解析（TESSERA） [CVPR2026]
<div align="center">
    <a href="#readme-top">
        <img src="https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/banner.png" alt="Banner">
    </a>
    <br />
    <p align="center">
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">バグ報告 🛠️</a> &nbsp;&nbsp;•&nbsp;&nbsp;
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">機能リクエスト 💡</a>
    </p>
</div>

<!--  ![Version](https://img.shields.io/badge/version-alpha-red) -->
![PyPI version](https://img.shields.io/pypi/v/geotessera?label=PyPI%20version&color=blue)
![License](https://img.shields.io/badge/License-MIT-blue.svg)


# 目次

  - TESSERAについて学ぶ
      - [はじめに](#introduction)
      - [論文](#Papers)
      - [ポッドキャスト](https://www.satellite-image-deep-learning.com/p/tessera-a-temporal-foundation-model)
      - [プレゼンテーション](#presentations)
      - [ライセンス](#License)
  - TESSERAの利用
      - [利用規約](#AUP)
      - [事前計算済み埋め込みへのアクセス](#global-embeddings-access)
      - [独自埋め込みの作成](#creating-your-own-embeddings)
      - [下流タスク](#downstream-tasks)
      - [TESSERAユーザーグループ](#tessera-users-group)
  - 追加情報
      - [チーム](#team)
      - [お問い合わせ](#contact)
      - [引用](#citation)
      - [謝辞](#acknowledgments)
      - [スター履歴](#star-history)

# TESSERAについて学ぶ
## はじめに
衛星リモートセンシングは、生息地マッピング、炭素アカウンティング、保全および持続可能な土地利用の戦略など、多様な下流アプリケーションを可能にします。  
しかし、衛星時系列データは膨大で、しばしば雲により汚染されており、利用が困難です。科学コミュニティが実用的な洞察を引き出す能力は、ラベル付き学習データセットの不足や時系列データ処理の計算負荷によって制約されることが多いです。  
我々の研究の鍵となる洞察は、[Dr. Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/) によるもので、衛星時系列の2つの雲のないランダムサンプルから得られた自己符号化器の埋め込みを、[Barlow Twins](https://proceedings.mlr.press/v139/zbontar21a/zbontar21a.pdf) を用いて整合させることにより、欠損観測を含む時系列全体を表現する埋め込みが得られるというものです。  

このアイデアは、TESSERAの鍵であり、TESSERAは、10メートル解像度でピクセルごとのスペクトル・時間信号を128次元の潜在表現に保存するオープンな基盤モデルです。  
自己教師あり学習を用いてペタバイト級の地球観測データを要約します。  
我々は、最先端のタスク特化モデルや他の基盤モデルと5つの多様な下流タスクで比較し、TESSERAがこれらのベースラインに匹敵または上回ることを示しました。  
従来の手法で失われがちな時間的な植物生理学的信号を保存することで、TESSERAは生態系の動態、農業食料システム、および環境変化検出に新たな洞察をもたらします。  
さらに、我々のオープンソース実装は再現性と拡張性をサポートし、プライバシー保護設計により研究者がデータ主権を維持できます。  

我々の知る限り、TESSERAは使いやすさ、規模、精度において前例がなく、他の基盤モデルは分析準備済みの出力を提供せず、オープンでなく、ピクセルレベルのスペクトル・時間特徴のみを用いて10m解像度の全球年次カバレッジを提供していません。  

以下はTESSERAの表現マップの可視化結果（一番目から三番目のチャネルをRGBとして使用）です：  

![repr_demo](https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/repr_demo.png)  

## 論文  
以下はTESSERAに関連する出版物およびプレプリントを年代順に示します：  
* Lisaius, M. C., Blake, A., Keshav, S., & Atzberger, C. (2024). Using Barlow Twins to Create Representations From Cloud-Corrupted Remote Sensing Time Series. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing, 17, 13162–13168. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing. https://doi.org/10.1109/JSTARS.2024.3426044  

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav (2025), [TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis](https://arxiv.org/abs/2506.20380), To Appear, CVPR 2026. ArXiv reprint. https://arxiv.org/abs/2506.20380  

* Lisaius, M. C., Blake, A., Atzberger, C., & Keshav, S. (2026). Towards improved crop type classification: A compact embedding approach suitable for small fields. Accepted in Proceedings of the ISPRS Conference 2026. International Society for Photogrammetry and Remote Sensing.  

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav, (2026) [Applications of the TESSERA Geospatial Foundation Model to Diverse Environmental Mapping Tasks](http://ssrn.com/abstract=6142416), SSRN preprint. http://ssrn.com/abstract=6142416  
    
* Young, R., & Keshav, S. (2026). Interpolation of GEDI Biomass Estimates with Calibrated Uncertainty Quantification, arXiv preprint. https://doi.org/10.48550/ArXiv.2601.16834  
    
* Lisaius, M. C., Keshav, S., Blake, A., & Atzberger, C. (2026). Embedding-based Crop Type Classification in the Groundnut Basin of Senegal (arXiv:2601.16900). ArXiv preprint. https://doi.org/10.48550/arXiv.2601.16900  

* Ball, J.G.C, Wicklein J.A. , Feng, Z.,  Knezevic, J.,  Jaffer, S., Atzberger, C.,  Dalponte, M., and Coomes, D. Geospatial foundation models enable data-efficient tree species mapping in temperate montane forests, BioArxiv, https://doi.org/10.64898/2026.02.23.707022  

## プレゼンテーション  

* [TESSERA overview in AI for Good seminar](https://www.youtube.com/live/9yrpwFrwbGY), Frank Feng, 2026年1月22日  
* [TESSERA: Precomputed FAIR Global Pixel Embeddings for Earth Representation and Analysis](https://www.grss-ieee.org/event/tessera-precomputed-fair-global-pixel-embeddings-for-earth-representation-and-analysis/) IEEE GRSS トーク, Frank Feng, 2025年12月12日  
* [2スライドサマリー (PPTX)](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) CRIフラッシュトーク用, S. Keshav, 2025年10月7日  
* 基盤モデル概要 (PPTX) 生態学グループ会議用、ケンブリッジ大学、DAB、James Ball、2025年10月6日  
* [生態学応用に焦点を当てたTESSERA概要プレゼンテーション](https://www.dropbox.com/scl/fi/8xvanw3kk586lp1ld31kd/maryland_talk_slides.pdf?rlkey=osyhtk1kc2pcj81iel0u32lub&st=6kedpwv6&dl=0) (PDF) メリーランド大学、Frank Feng、2025年10月1日  
* [TESSERA概要プレゼンテーション](https://www.dropbox.com/scl/fi/0rsq4wkao3c7fgwljd8ec/JCU-tesserav2.pptx?rlkey=ccutcxgwi068c09n20t1yi549&st=13if23b3&dl=0) (PPTX) ジェームズクック大学、S. Keshav、2025年9月29日  
* [TESSERA概要プレゼンテーション](https://www.dropbox.com/scl/fi/1p7nabvlvie8fzyomkx7w/dab_talk_slides.pdf?rlkey=ym3d44o80mbrdkasyzct9kzi5&st=ozvwczs7&dl=0) ケンブリッジ大学、DAB、Frank Feng、2025年5月20日  
* [地球観測のための自己教師あり学習](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) (PPTX) S. Keshav、エクセター、2025年4月  

## ライセンス  
TESSERAソフトウェアは標準のMITライセンスの下でリリースされています。埋め込みベクトルおよびモデルの重みは[CC0](https://creativecommons.org/publicdomain/zero/1.0/)ライセンスの下でリリースされています：基本的に、  
商用・非商用の両方で自由に使用可能です。法的には帰属表示を要求していませんが、表示をお願いしています。

# TESSERAの使用方法

<a id="global-embeddings-access"></a>

## GeoTesseraを使った埋め込みへのアクセス（推奨）

2024年の10m解像度で地球全体の埋め込みを生成しています。  
これらはダウンロードして下流のアプリケーションで使用可能で、大幅な計算時間とリソースの節約が可能です。  
[GeoTessera](https://github.com/ucam-eo/geotessera)ライブラリを使用してください。  
2017年まで年ごとにカバレッジを遡って拡張していく予定です。現在のカバレッジマップは以下の通りです：

<img src="https://github.com/ucam-eo/tessera-coverage-map/blob/main/map.png"> 

## TESSERAユーザーグループ

興味のあるユーザーは、[Zulip](https://eeg.zulipchat.com/login/)のディスカッショングループに参加してください。


# 独自の埋め込みの作成

当社のソフトウェアを使って独自の埋め込みを作成したい場合は、以下の手順に従ってください。  
これは計算的に非常に負荷の高い作業であり、十分な計算リソースとストレージリソースへのアクセスが必要です。

## ハードウェア要件

### 1. ストレージ要件

このパイプラインの実行には大量のストレージ容量が必要です。パイプラインは処理後に一部の中間ファイルを削除しますが、ダウンロードした生のSentinel-2およびSentinel-1ファイルはかなりのディスク容量を占有します。  
例えば、2022年の100km×100km範囲を処理してTESSERA表現マップ（10m解像度）を出力するには、最低でも1TBのストレージが必要です。

### 2. メモリ要件

Microsoft Planetary Computerからの前処理済みデータを使用しています。ただし次世代の埋め込みはASF DAACのOPERAを使用予定です。いずれの場合も多くの地理的前処理は済んでいます。  
それでも、最低128GBのRAMを推奨します。

### 3. CPUおよびGPU

パイプラインにCPUやGPUの厳密な要件はありませんが、CPUコア数が多く、より強力なGPUがあれば推論速度は大幅に向上します。  
2022年の110km×110km範囲を処理した際、128コアCPUとNVIDIA A30 GPU1台を使い（CPUとGPUが推論をそれぞれ50％ずつ担当）、約10時間かかりました。
### 4. オペレーティングシステム

データ前処理パイプラインについては、ほぼすべてのLinuxシステムをサポートしています。Windowsの場合はWSLの使用を推奨します。現時点ではMacOSはサポートしていません。

モデル推論部分については、LinuxとWindows WSLでのみテストしており、正常に動作しています。

## データ前処理

### 概要
_**パイプラインを実行する前に、チュートリアル全体を速やかに確認することを強く推奨します。**_

このステップでは、1年間分のSentinel-1とSentinel-2のデータを時間軸に沿って積み重ねてコンポジットを生成します。Sentinel-2のコンポジットの形状は (T,H,W,B) で、Tはその年の有効な観測回数、Bはバンド数（10バンドを選択）です。Sentinel-1は上昇軌道と下降軌道のデータを抽出しました。上昇軌道を例にとると、コンポジットの形状は (T',H,W,B') で、T'はその年の有効な上昇観測回数、B'は2で、VVとVHバンドのみ取得しています。

当初、Sentinel-1およびSentinel-2データはMicrosoftのPlanetary Computerから取得しました：
- Sentinel-1データソース：https://planetarycomputer.microsoft.com/dataset/sentinel-1-rtc
- Sentinel-2データソース：https://planetarycomputer.microsoft.com/dataset/sentinel-2-l2a

新世代の埋め込みはASF DAACのOPERAを使用します：
- Sentinel-1データソース：https://registry.opendata.aws/nasa-operal2rtc-s1v1/
- Sentinel-2データソース：https://registry.opendata.aws/sentinel-2-l2a-cogs/

現在、パイプラインはTIFF形式の入力のみ受け付けています。入力ROI TIFFの解像度は異なる場合があります（例：30m）が、パイプラインは**常に設定された `RESOLUTION`（デフォルト10m）でSentinel-1およびSentinel-2の出力を生成**し、**ROIの範囲/境界は同一に保ちます**。TIFF内の有効なROI領域の値は1、そうでない場合は0です。シェイプファイルのみでも問題ありません。`convert_shp_to_tiff.py`スクリプトを提供しています。

### ソースコードのダウンロード

まず、空の作業ディレクトリを作成します：

```bash
mkdir tessera_project
cd tessera_project
git clone https://github.com/ucam-eo/tessera.git
```
パイプラインの操作を容易にするために、データ出力ディレクトリを `tessera_infer` および `tessera_preprocessing` と同じ階層に配置することを推奨します：


```
tessera_project
 ┣ tessera_infer
 ┣ tessera_preprocessing
 ┣ my_data
   ┣ roi.shp (your shapefile)
   ┗ roi.tiff (we recommend generating this using convert_shp_to_tiff.py)
```

`roi.tiff` は `tessera_preprocessing/convert_shp_to_tiff.py` にある `convert_shp_to_tiff.py` を使って生成できます。使用するには、メイン関数にシェイプファイルのパスを指定するだけで、同じディレクトリに同じ名前のTIFFが出力されます。

⚠️注意：_ROIが比較的大きい場合、例えば100 km × 100 kmの場合、TIFFを20 km × 20 km以下の小さいセクションに事前に分割することを強く推奨します。その後、パイプラインで各小さなTIFFファイルを順次処理してください。過度に大きなROIはバックエンドのタイルプロバイダーに問題を引き起こす可能性があります_

### Python環境

地理処理用のパッケージ（幸いなことにGDALは使いません。環境構築が非常に難しいため）と機械学習用のパッケージ（PyTorch。ただし、各コンピュータのハードウェアが異なるため、これはご自身でインストールしてください）が必要です。共通のパッケージを `requirements.txt` にまとめてありますので、以下のようにインストールできます：

```bash
pip install -r requirements.txt
```
注意: 管理された環境にいる場合は、最初にvenvをインストールする必要があるかもしれません。
```bash
python3 -m venv venv
source venv/bin/activate
```

### スクリプトの設定

まず、`tessera_preprocessing` フォルダに移動します：

```bash
cd tessera_preprocessing
```

次に、ファイル s1_s2_downloader.sh を編集して、ROI TIFF ファイル、出力および一時ディレクトリ、データソースを指定します：

```bash
# === Basic Configuration ===
INPUT_TIFF="/absolute/path/to/your/data_dir/roi.tiff"
OUT_DIR="/absolute/path/to/your/data_dir"

export TEMP_DIR="/absolute/path/to/your/temp_dir"     # Temporary file directory

mkdir -p "$OUT_DIR"

# Python environment path
PYTHON_ENV="/absolute/path/to/your/python_env/bin/python"

# === Sentinel-1 & Sentinel-2 Processing Configuration ===
YEAR=2022 # Range [2017-2025]
RESOLUTION=10.0  # Output resolution (meters). ROI TIFF can be any resolution; extent is preserved.

# === Data Source Configuration ===
# mpc: Microsoft Planetary Computer (sentinel-1-rtc, sentinel-2-l2a)
# aws: AWS Open Data backends (S1=OPERA RTC-S1 via ASF/CMR + ASF Earthdata Cloud COGs, S2=Earth-search Sentinel-2 L2A COGs)
DATA_SOURCE="mpc"   # choices: mpc/aws
```

注意：`RESOLUTION` は出力ピクセルサイズを制御します。パイプラインはROIの境界を固定し、ROIマスクを出力グリッドに再サンプリングします。

### AWS認証情報（`DATA_SOURCE="aws"` の場合のみ必要）
Earth-search上のSentinel-2は公開されており、**認証情報は不要**です。

Sentinel-1 OPERA RTC-S1はASF Earthdata Cloud（HTTPS経由のCOG）からアクセスします。Earthdataログイントークンが必要です：
- **Earthdataアカウントを作成**： [NASA Earthdata Login](https://urs.earthdata.nasa.gov/home)から。
- **アプリケーションの承認**：アカウント登録後、ApplicationsタブからAlaska Satellite Facility Data Accessを承認済みアプリケーションに追加します。
- **EDLベアラートークン/JWTを取得**：**Generate Token**をクリックしてローカルに保存（コミットしないでください）。

推奨（シンプルかつ明示的）：

```bash
nano ~/.edl_bearer_token
# paste token, save+exit (Ctrl-O Enter, then Ctrl-X)
chmod 600 ~/.edl_bearer_token
```

AWS S1 ダウンローダーは、このトークンを使用して ASF Earthdata Cloud から COG を読み取ります。

一時的な S3 資格情報を取得したい場合（高度な操作であり、通常このパイプラインでは不要です）、ASF のガイダンスを参照してください：
- `https://cumulus.asf.alaska.edu/s3credentialsREADME`

上記の設定の下には、コンピュータの性能に応じて変更可能な追加設定があります。

まず、`s1_s2_downloader.sh` に実行権限を付与します：

```bash
chmod +x s1_s2_downloader.sh
```

次に、以下を実行できます：

```bash
bash s1_s2_downloader.sh
```
ネットワーク状況により、一部のタイルの処理がタイムアウトすることがあります。弊社のスクリプトにはこれらの問題を回避する高度なタイムアウト管理が含まれています。しかし、時折一部のタイルが失敗することがあります。上記のコマンドを再度実行すると通常は解決します。

Sentinel-1 および Sentinel-2 のすべてのデータが正しく生成されると、それらを時間軸に沿ってスタックできます。このステップでは、Rustで生成された2つの実行可能ファイルを使用しており、とても高速です。`s1_s2_stacker.sh` を開き、以下を編集してください：


```bash
# === Basic Configuration ===
BASE_DIR="/absolute/path/to/your/data_dir"
OUT_DIR="${BASE_DIR}/data_processed"
DOWNSAMPLE_RATE=1
```
通常、`DOWNSAMPLE_RATE` は変更せず、スタッキング中にダウンサンプリングを行わないようにします。上記スニペットの `BASE_DIR` は、`s1_s2_downloader.sh` で変更した `OUT_DIR` と同じです。

同様に、`s1_s2_stacker.sh` にも権限を付与します：


```bash
chmod +x s1_s2_stacker.sh
```

次に、スタッキングを実行できます：

```bash
bash s1_s2_stacker.sh
```
成功すると、`/absolute/path/to/your/data_dir/data_processed` にいくつかの `.npy` ファイルが生成されます。通常、これらの `.npy` ファイルは非常に大きいため、小さくて扱いやすい単位にパッチ化します。

実行してください：


```bash
python dpixel_retiler.py \
    --tiff_path /absolute/path/to/your/data_dir/roi.tif \
    --d_pixel_dir /absolute/path/to/your/data_dir/data_processed \
    --patch_size 500 \
    --out_dir /absolute/path/to/your/data_dir/retiled_d_pixel \
    --num_workers 16 \
    --overwrite \
    --block_size 2000
```

上記の `patch_size` と `block_size` はご自身で変更可能です。上記の設定は、形状が (5000,5000) で解像度が10mのTIFFに推奨される設定です。

上記のコードが正常に実行されると、`my_data/retiled_d_pixel` にいくつかのサブフォルダが作成されます。

## 推論

### 概要

データ前処理が完了したら、推論を開始できます。進める前に、`my_data/retiled_d_pixel` フォルダに以下のようなサブフォルダが存在するか確認してください：
```
retiled_d_pixel
 ┣ 0_3500_500_4000
 ┣ 0_4000_500_4500
 ┣ 0_4500_500_5000
 ┣ 0_5000_500_5500
 ┣ 0_5500_500_6000
 ┣ 0_6000_500_6500
```
各サブフォルダには、以下のファイルが含まれている必要があります：

```
0_3500_500_4000
 ┣ bands.npy
 ┣ doys.npy
 ┣ masks.npy
 ┣ roi.tiff
 ┣ sar_ascending.npy
 ┣ sar_ascending_doy.npy
 ┣ sar_descending.npy
 ┗ sar_descending_doy.npy
```
これらのファイルが存在する場合、推論を開始できます。存在しない場合は、最初のステップが正常に完了したか確認してください。

推論にはPyTorchが必要です。システムごとにCUDAのバージョンが若干異なるため、データ前処理で行ったようなDockerにカプセル化されたPython環境は提供できません。幸いにも、推論用のPython環境はGDALやSNAPのような地理処理パッケージを使用しないため、データ前処理よりもはるかに簡単に構成できます。

### Pytorchの準備

まだPytorchをインストールしていない場合は、以下の手順を参照してください。既にインストール済みの場合は、このセクションを無視できます。

まず、システムのCUDAバージョンを確認してください：


```bash
nvidia-smi
```

次に https://pytorch.org/ にアクセスし、CUDAのバージョンに基づいて適切なバージョンを選択してインストールしてください。例えば：

```bash
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
```

### モデルウェイト

次に、[Googleドライブ](https://drive.google.com/drive/folders/18RPptbUkCIgUfw1aMdMeOrFML_ZVMszn?usp=sharing)からモデルウェイトをダウンロードし、`.pt`ファイルを `tessera_infer/checkpoints` ディレクトリに配置します：

```
tessera_infer
 ┗ checkpoints
     ┗ best_model_fsdp_20250427_084307.pt
 ┗ configs
 ┗ src
```

_**上記で言及したチェックポイントは初期段階のモデルであり、ネイティブにfloat32埋め込みを生成します。したがって、このモデルはgeotesseraライブラリでint8埋め込みを生成するために使用されたものではありません。geotessera埋め込みを作成するために使用された特定のチェックポイントを近日中に完全なパイプラインに展開する予定です。**_

### Bashスクリプトの設定

推論設定を簡素化するために、`tessera_infer/infer_all_tiles.sh`を提供しています。編集する必要があるのは数パラメータだけです：

a. ベースデータディレクトリ：
```bash
BASE_DATA_DIR="your_data_directory"
```
これはデータストレージフォルダで、前回のbashの`BASE_DATA_DIR`と同じです。例：`/maps/usr/tessera_project/my_data`

b. Python環境:
```bash
export PYTHON_ENV="your_python_path"
```
ここにPython環境への絶対パスを書いてください。例：`/home/user/anaconda3/envs/tessera_env/bin/python`

c. CPU/GPU 分割:
```bash
CPU_GPU_SPLIT="1:1"  # Format: CPU:GPU ratio
```
スクリプトはCPUとGPUの両方を使用した同時推論をサポートしています。この比率は各デバイスが処理する`retiled_patches`の割合を指定します。デフォルトは1:1（均等分割）です。GPUのみで推論する場合は0:1に設定してください。

d. CPU 関連の設定

```bash
MAX_CONCURRENT_PROCESSES_CPU=20
```
タイル推論のための最大CPUプロセス数。例えば、20に設定すると、20個のタイルを同時に処理します。

```bash
AVAILABLE_CORES=$((TOTAL_CPU_CORES / 2)) # Use 50% of the cores
```
使用するCPUコアの数。CPUリソースの過剰消費を避けるため、必要に応じてこの値を変更してください！

e. GPU 関連設定：
```bash
MAX_CONCURRENT_PROCESSES_GPU=1
```
推論のためのGPUプロセスの最大数。システムにGPUが1台しかない場合は、これを1に設定してください。

```bash
GPU_BATCH_SIZE=1024  # Larger for GPU, if this takes too much memory, reduce it
```
PyTorch推論時に一度に処理するサンプル数。この値がGPUメモリを過剰に消費したり、GPUでOOMエラーを引き起こす場合は、適宜減らしてください。

f. その他の設定
設定可能な他のパラメータもあります。必要に応じて調整してください。

### 推論の開始

すべて準備が整ったら、`tessera_infer`フォルダに移動してください：

```bash
cd tessera_infer
```

次に、`infer_all_tiles.sh`に実行権限を与えます:

```bash
chmod +x infer_all_tiles.sh
```

それから実行します:

```bash
bash infer_all_tiles.sh
```

成功すると、次のようなログが表示されます:

```
(base) zf281@daintree:/scratch/zf281/tessera_project/tessera_infer$ bash infer_all_tiles.sh
[INFO] Total CPU cores: 256, Using: 192
[INFO] CPU:GPU split ratio = 1:1 (total: 2)

==== SETUP DIRECTORIES ====
[SUCCESS] Created necessary directories

==== SCANNING TILES ====
[INFO] Tile directory: /scratch/zf281/jovana/retiled_d_pixel
[INFO] Output directory: /scratch/zf281/jovana/representation_retiled
[SUCCESS] Found 226 tiles total
[INFO] Sample tiles:
  - 0_3500_500_4000
  - 0_4000_500_4500
  - 0_4500_500_5000
  - ...
```
同時に、`tessera_infer`フォルダ内に`logs`フォルダが生成され、各CPUおよびGPUプロセスのより詳細なログが記録されます。

### 最終表現マップのスティッチ

推論は通常、ROIのサイズやハードウェアの性能によって長時間かかります。完了すると、`my_data/representation_retiled`に多数の`.npy`ファイルが見つかります：


```
representation_retiled
 ┣ 0_3500_500_4000.npy
 ┣ 0_4000_500_4500.npy
 ┣ 0_4500_500_5000.npy
 ┣ 0_5000_500_5500.npy
 ┣ 0_5500_500_6000.npy
 ┣ 0_6000_500_6500.npy
 ┣ 0_6500_500_7000.npy
 ┣ 0_7000_500_7500.npy
 ┣ 1000_0_1500_500.npy
 ┣ 1000_1000_1500_1500.npy
 ┣ 1000_1500_1500_2000.npy
 ┣ 1000_2000_1500_2500.npy
```
最後のステップは、`tessera_infer/stitch_tiled_representation.py` を使用してそれらをつなぎ合わせることです:


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /path/to/d_pixel_retiled \
--representation_retiled_path /path/to/representation_retiled \
--downstream_tiff /path/to/downstream.tiff \
--out_dir /path/to/output_directory
```
例えば：


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /maps/usr/tessera_project/my_data/d_pixel_retiled \
--representation_retiled_path /maps/usr/tessera_project/my_data/representation_retiled \
--downstream_tiff /maps/usr/tessera_project/my_data/downstream.tiff \
--out_dir /maps/usr/tessera_project/my_data
```
最後に、`my_data` ディレクトリに形状が (H,W,128) のステッチされた表現マップが得られます。ここで H と W は最初の `roi.tiff` と一致します。表現マップは NumPy 配列です。QGIS などのソフトウェアで表示するために TIFF に変換したい場合は、`tessera_infer/convert_npy2tiff.py` スクリプトを使用できます。メイン関数を以下のように修正してください。


```python
npy_path = "/maps/usr/tessera_project/my_data/stitched_representation.npy"  # Change to the actual npy file path
ref_tiff_path = "/maps/usr/tessera_project/my_data/roi.tiff"  # Change to the actual reference tiff file path
out_dir = "/maps/usr/tessera_project/my_data/"  # Change to the actual output directory
```
## 下流タスク

論文の下流タスクを再現したい場合は、https://github.com/ucam-eo/tessera-downstream-task をご覧ください。多くの例が提供されています。

# 追加情報

## チーム

### ケンブリッジ教員
* [S. Keshav](https://svr-sk818-web.cl.cam.ac.uk/keshav/wiki/index.php/Main_Page)
* [Anil Madhavapeddy](https://anil.recoil.org)
* [Sadiq Jaffer](https://toao.com)
* [David Coomes](https://www.plantsci.cam.ac.uk/directory/david-coomes)

### ポスドク
* James Ball

### 博士課程
* Madeleine Lisaius
* Zhengpeng (Frank) Feng
* Robin Young
* Jovana Knezevic

### 学部生
* Zejia Yang（Part II学生、Frank Fengと空間特徴抽出器のMAE事前学習に取り組む）

### インターン
* Kenzy Soror（ウォータールー大学、Robin Youngと共同研究）
* Artyom Gabtraupov（ウォータールー大学、Robin Youngと共同研究）
* Gabriel Mahler（ケンブリッジ大学、Anil MadhavapeddyおよびSilviu Petrovanと[ハリネズミの生息地と追跡](https://anil.recoil.org/ideas/hedgehog-mapping)に取り組む）
* Leyu Pan（インペリアル・カレッジ、Frank FengとOSMから生成されたテキスト埋め込みに取り組む）

### 共同研究者
* [Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/?originalSubdomain=at)、dClimate Labs
* [Andrew Blake](https://en.wikipedia.org/wiki/Andrew_Blake_(computer_scientist))、Mantle Labs

### ビジター
* Silja Sormunnen、アールト大学、フィンランド
* Isabel Mansley（エジンバラ大学、David CoomesおよびAnil Madhavapeddyと[スコットランドの生息地マッピング](https://anil.recoil.org/ideas/cairngorms-connect-habitats)に取り組む）


## お問い合わせ

技術的な質問はFrank Feng（zf281@cam.ac.uk）まで、または[Zulipフォーラム](https://eeg.zulipchat.com/login/)でご質問ください。技術以外の質問はProf. S. Keshav（sk818@cam.ac.uk）までお送りください。

## 引用

研究でTESSERAを使用する場合は、[arXiv論文](https://arxiv.org/abs/2506.20380)を引用してください：

```bibtex
@misc{feng2025tesseratemporalembeddingssurface,
      title={TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis}, 
      author={Zhengpeng Feng et al.},
      year={2025},
      eprint={2506.20380},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2506.20380}, 
}
```
## 謝辞  
本プロジェクトにおいて寛大な支援をいただいたUKRIおよびケンブリッジの[DAWN](https://www.hpc.cam.ac.uk/d-w-n)スパコンチームに感謝いたします。また、[AMD](https://www.amd.com/en.html)、[Vultr](https://www.vultr.com/)、[Dirac高性能計算施設](https://dirac.ac.uk)、[Microsoft AI For Good Lab](https://www.microsoft.com/en-us/research/group/ai-for-good-research-lab/)、Dr. Robert Sansom、[dClimate](https://www.dclimate.net/)、およびAWSのAWS Open Dataプログラム(https://opendata.aws/)における[Amazon Web Services (AWS)](https://aws.amazon.com/)の支援にも感謝いたします。本研究は彼らの支援、計算資源、技術的支援なしには実現不可能でした。  

## Star History  
[![Star History Chart](https://api.star-history.com/svg?repos=ucam-eo/tessera&type=Date)](https://www.star-history.com/#ucam-eo/tessera&Date)  

## AUP  

### TESSERA 利用規約および倫理ガイドライン  

### ライセンス  

TESSERAのデータおよび埋め込みは**クリエイティブ・コモンズ0国際ライセンス[CC-0](https://creativecommons.org/public-domain/cc0/)**の下で提供されています。  
これは以下のことが自由にできることを意味します：  

* **共有** — いかなる媒体や形式においても資料のコピーおよび再配布  
* **改変** — 資料をリミックス、変換、または基にしてあらゆる目的で構築（商用利用も含む）  

### 目的および想定される利用  

TESSERAは科学研究の促進および環境モニタリング、保全、持続可能な農業、地球システムの理解を支援するために開発されました。このツールは以下を可能にするよう設計されています：  

* 科学研究および教育  
* 環境モニタリングおよび保全  
* 農業および食料安全保障の分析  
* 気候変動研究および適応計画  
* 持続可能な土地利用および資源管理  
* 社会および環境に利益をもたらす公共の利益に資するアプリケーション  

### 倫理ガイドライン  

CC0ライセンスは広範な利用を許可しますが、利用者にはその仕事の倫理的影響を考慮することを強く推奨します。これらの倫理ガイドラインは助言的なものであり、法的拘束力のある制限を課すものではありません。利用者には以下をお願いしています：  

**責任ある行動：**  
* 特定の場所を分析する際のプライバシーへの配慮  
* 影響を受けるコミュニティの権利と尊厳の尊重  
* 潜在的な二重用途に関する懸念への注意  

**透明性の確保：**

* データの特性を正確に表現すること（年次解像度、10mの空間解像度）  
* アプリケーションの限界を認識すること  
* TESSERAの能力を誤って表現しないこと  

**ポジティブな影響を支援する：**  
* あなたの作業が社会的利益にどのように寄与するかを考慮する  
* 適切な場合、影響を受けるコミュニティと関わる  
* 公共の知識を促進する成果を共有する  

### データの特性  

ユーザーはTESSERAが以下を提供することを理解すべきです：  
* **年次の時間解像度** — データは年間の要約を表し、リアルタイムや高頻度モニタリングではありません  
* **10メートルの空間解像度** — ランドスケールの解析に適しています  
* **スペクトル・時間埋め込み** — 圧縮された表現であり、生の画像ではありません  

これらの特性をあなたの作業で正確に表現してください。  

### コミュニティ基準  

責任ある利用を奨励し、コミュニティからのフィードバックを歓迎します。潜在的な応用について懸念やガイドライン改善の提案があれば、ご連絡ください。  

コミュニティの意見や新たな考慮事項に基づきこれらのガイドラインを更新する権利を保持しますが、そのような更新はデータがリリースされたCC-0ライセンスに遡及的な影響を及ぼすものではありません。  

### 連絡先  

質問やフィードバックは以下まで：Email sk818@cam.ac.uk  

---  

*最終更新日：2026年2月25日*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---