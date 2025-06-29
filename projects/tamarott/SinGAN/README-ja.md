# SinGAN

[プロジェクト](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [補足資料](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [講演 (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### 論文「SinGAN: Learning a Generative Model from a Single Natural Image」の公式pytorch実装
#### ICCV 2019 最優秀論文賞（Marr賞）


## *1枚*の画像からのランダムサンプル
SinGANでは、1枚の自然画像から生成モデルを学習し、その画像からランダムサンプルを生成することができます。例えば：

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## SinGANの応用例
SinGANは、画像操作の様々なタスクにも利用できます。例えば：
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
これは、すでに学習済みのモデルに画像を注入することで実現されます。詳細は[論文](https://arxiv.org/pdf/1905.01164.pdf)のセクション4をご覧ください。


### 引用
このコードを研究等で使用する場合は、以下の論文を引用してください：

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## コード

### 依存関係のインストール

```
python -m pip install -r requirements.txt
```

このコードはpython 3.6、torch 1.4でテストされています。

ご注意：このコードは最適化手法の都合上、現在はtorch 1.4以前のみサポートしています。

それ以降のtorchバージョンを利用する場合は、こちらのリポジトリをご参照ください: https://github.com/kligvasser/SinGAN （結果は公式実装と必ずしも同一ではありません）。


###  学習
ご自身の画像でSinGANモデルを学習するには、学習させたい画像をInput/Images下に置き、次のコマンドを実行してください。

```
python main_train.py --input_name <input_file_name>
```

これにより、学習済みモデルを用いて最も粗いスケール（n=0）からランダムサンプルも自動生成されます。

CPUマシンでこのコードを実行する場合は、`main_train.py`実行時に`--not_cuda`を指定してください。

###  ランダムサンプル生成
任意の生成スケールからランダムサンプルを生成するには、まず目的の画像でSinGANモデルを学習させ（上記参照）、次に

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

にて実行してください。

注意：モデル全体を利用する場合は、生成開始スケールを0に、2番目のスケールから生成を始めたい場合は1を指定してください。

###  任意サイズのランダムサンプル生成
任意のサイズでランダムサンプルを生成するには、まず目的の画像でSinGANモデルを学習させ（上記参照）、次に

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

を実行してください。

###  1枚の画像からのアニメーション生成

1枚の画像から短いアニメーションを生成するには、次のコマンドを実行してください。

```
python animation.py --input_name <input_file_name> 
```

これにより、ノイズパディングモードで新たな学習フェーズが自動的に開始されます。

###  ハーモナイゼーション

画像内に貼り付けたオブジェクトを自然になじませるには（[論文](https://arxiv.org/pdf/1905.01164.pdf)のFig.13参照）、まず目的の背景画像でSinGANモデルを学習させ（上記参照）、次に単純に貼り付けた参照画像とそのバイナリマスクを "Input/Harmonization" に保存してください（保存例はサンプル画像を参照）。以下のコマンドを実行します。

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

注：異なる注入スケールで異なるハーモナイゼーション効果が得られます。一番粗い注入スケールは1です。

###  編集

画像を編集するには（[論文](https://arxiv.org/pdf/1905.01164.pdf)のFig.12参照）、まず編集前の画像でSinGANモデルを学習させ（上記参照）、次に単純に編集した画像を参照画像として "Input/Editing" に対応するバイナリマップとともに保存してください（サンプル画像を参照）。以下のコマンドを実行します。

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
マスクありおよびマスクなしの出力の両方が保存されます。
ここでも、異なるインジェクションスケールは異なる編集効果をもたらします。最も粗いインジェクションスケールは1です。

###  Paint to Image

ペイントをリアルな画像に変換するには（[論文](https://arxiv.org/pdf/1905.01164.pdf)のFig. 11を参照）、まず希望する画像でSinGANモデルをトレーニングしてください（上記の説明参照）。その後、「Input/Paint」にペイント画像を保存し、以下のコマンドを実行します。

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
ここでも、異なるインジェクションスケールは異なる編集効果をもたらします。最も粗いインジェクションスケールは1です。

高度なオプション: quantization_flagをTrueに指定すると、モデルのインジェクションレベル*のみ*を再学習し、前のスケールからアップサンプリングされた生成画像の色量子化バージョンを取得します。一部の画像では、これによりよりリアルな結果が得られる場合があります。

### 超解像
画像を超解像するには、次のコマンドを実行してください:
```
python SR.py --input_name <LR_image_file_name>
```
これにより、SinGANモデルが自動的に4倍のアップサンプリングファクターに対応してトレーニングされます（まだ存在しない場合）。
異なるSRファクターの場合、関数呼び出し時にパラメータ `--sr_factor` を指定してください。
SinGANのBSD100データセットにおける結果は「Downloads」フォルダからダウンロードできます。

## 追加データおよび機能

### Single Image Fréchet Inception Distance（SIFIDスコア）
実画像と対応する偽サンプル間のSIFIDを計算するには、次を実行してください:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
各偽画像ファイル名が対応する実画像ファイル名と同一であることを確認してください。画像は`.jpg`形式で保存してください。

### 超解像結果
SinGANのBSD100データセットにおけるSR結果は「Downloads」フォルダからダウンロードできます。

### ユーザースタディ
ユーザースタディで使用されたデータはDownloadsフォルダにあります。

realフォルダ： [places database](http://places.csail.mit.edu/)からランダムに選ばれた50枚の実画像

fake_high_varianceフォルダ： 各実画像についてn=Nから開始したランダムサンプル

fake_mid_varianceフォルダ： 各実画像についてn=N-1から開始したランダムサンプル

詳細については、[論文](https://arxiv.org/pdf/1905.01164.pdf)のセクション3.1を参照してください。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---