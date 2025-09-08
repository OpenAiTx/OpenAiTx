# RGBからのロボット把持検出およびセマンティックセグメンテーションのためのエンドツーエンド学習可能な深層ニューラルネットワーク

<p align="center">
<img src="https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/Network.png" width="100%"/>
<br>
<a href="https://arxiv.org/abs/2107.05287">arXiv</a>
</p>

このリポジトリには、ICRA21論文「RGBからのロボット把持検出およびセマンティックセグメンテーションのためのエンドツーエンド学習可能な深層ニューラルネットワーク」のコードが含まれています。  
提案手法とOCID_graspデータセットを組み合わせたトレーニングおよびテスト用のコードが含まれています。

本手法またはデータセット拡張を研究に使用する場合は、以下を引用してください：

```bibtex
@InProceedings{ainetter2021end,
  title={End-to-end Trainable Deep Neural Network for Robotic Grasp Detection and Semantic Segmentation from RGB},
  author={Ainetter, Stefan and Fraundorfer, Friedrich},
  booktitle={IEEE International Conference on Robotics and Automation (ICRA)},
  pages={13452--13458}
  year={2021}
}
```

## 要件とセットアップ

メインシステム要件：
* CUDA 10.1
* GCC 7または8を搭載したLinux
* PyTorch v1.1.0

**重要な注意**：これらの要件は必ずしも厳密なものではありません。例えば、古いバージョンのCUDAでコンパイルしたり、Windows環境で動作させたりすることも可能かもしれません。しかし、当方では上記の設定のみでコードをテストしており、他の環境でのサポートは提供できません。

PyTorchのインストールについては、https://github.com/pytorch/pytorch#installation を参照してください。

pipを使用して他のすべての依存関係をインストールするには：

```bash
pip install -r requirements.txt
```

### セットアップ

私たちのコードは主に2つのコンポーネントに分かれています：さまざまなネットワークモジュール、
アルゴリズム、およびユーティリティの実装を含むライブラリと、ネットワークを訓練／テストするためのスクリプト群です。

`grasp_det_seg`という名前のライブラリは、以下のコマンドでインストールできます：
```bash
git clone https://github.com/stefan-ainetter/grasp_det_seg_cnn.git
cd grasp_det_seg_cnn
python setup.py install
```
## 学習済みモデル

提供されているモデルファイルは、[CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/) ライセンスの下で利用可能です。

OCID_grasp データセット用の学習済みモデルは[こちら](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_pretrained)からダウンロードできます。  
ダウンロード後、重みファイルを `ckpt_files_OCID/pretrained` フォルダにコピーしてください。

OCID_grasp 上でネットワークを再学習するには、ImageNet で事前学習された重みを  
[こちら](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/ImageNet_weights)からダウンロードし、  
`weights_pretrained` フォルダにコピーする必要があります。

### トレーニング

トレーニングは、データセットの準備、設定ファイルの作成、トレーニングスクリプトの実行の3つの主要なステップで構成されます。

データセットの準備方法：  
1) OCID_grasp データセットを[こちら](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)からダウンロードしてください。  
ダウンロードした `OCID_grasp.zip` ファイルを `DATA` フォルダに展開します。  
2) 設定ファイルは `ini` 形式のシンプルなテキストファイルです。  
各設定パラメータのデフォルト値と、その機能の簡単な説明は  
[grasp_det_seg/config/defaults](grasp_det_seg/config/defaults)にあります。  
**注意** これらは各パラメータの「妥当な」値の目安であり、論文の結果を再現するためのものではありません。

3) トレーニングを開始するには：



```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 train_det_seg_OCID.py 
--log_dir=LOGDIR CONFIG DATA_DIR
```
トレーニングログはテキスト形式およびTensorboard形式で、学習済みのネットワークパラメータとともに  
`LOG_DIR`（例：`ckpt_files_OCID`）に書き込まれます。  
ファイル`CONFIG`にはネットワーク設定（例：`grasp_det_seg/config/defaults/det_seg_OCID.ini`）が含まれ、  
`DATA_DIR`は事前にダウンロードしたOCID_graspの分割データを指します（例：`DATA/OCID_grasp/data_split`）。  

なお、現時点ではコードをPyTorchの`torch.distributed.launch`ユーティリティを用いて  
「分散」モードで起動する必要があります。  

### 推論の実行  

学習済みネットワークがあれば、任意の画像セットに対して推論を実行できます。  
[scripts/test_det_seg_OCID.py](https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/scripts/test_det_seg_OCID.py)を使用します：
```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 test_det_seg_OCID.py 
--log_dir=LOG_DIR CONFIG MODEL_PARAMS DATA_DIR OUTPUT_DIR

```
予測結果は `OUTPUT_DIR` に書き込まれます。例：`output` フォルダー。`MODEL_PARAMS` は事前学習済みの重みで、例：`ckpt_files_OCID/pretrained/model_last.pth.tar`、  
`DATA_DIR` は使用するデータセットの分割を指します。例：`DATA/OCID_grasp/data_split`。  

## OCID_grasp データセット  
OCID_grasp データセットは[こちら](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)からダウンロード可能です。  
OCID_grasp は OCID データセットの1763枚の選択されたRGB-D画像で構成され、11.4kを超えるセグメント化された物体マスクと75k以上の手動注釈付き  
把持候補を含みます。さらに、各物体は31の物体クラスのいずれかに分類されています。  
## 関連研究  
OCID_grasp は[OCIDデータセット](https://www.acin.tuwien.ac.at/en/vision-for-robotics/software-tools/object-clutter-indoor-dataset/)の拡張データセットです。  
OCID_grasp を研究で使用する場合は、OCID論文も引用してください。
```bibtex
@inproceedings{suchi2019easylabel,
  title={EasyLabel: a semi-automatic pixel-wise object annotation tool for creating robotic RGB-D datasets},
  author={Suchi, Markus and Patten, Timothy and Fischinger, David and Vincze, Markus},
  booktitle={2019 International Conference on Robotics and Automation (ICRA)},
  pages={6678--6684},
  year={2019},
  organization={IEEE}
}
```
私たちのフレームワークは、[Seamless Scene Segmentation](https://github.com/mapillary/seamseg) のアーキテクチャに基づいています：
```bibtex
@InProceedings{Porzi_2019_CVPR,
  author = {Porzi, Lorenzo and Rota Bul\`o, Samuel and Colovic, Aleksander and Kontschieder, Peter},
  title = {Seamless Scene Segmentation},
  booktitle = {The IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2019}
}
```
---
## 最新の研究について
### 私たちの論文『ロボットピッキングタスクのための深度認識オブジェクトセグメンテーションと把持検出』がBMVC21で採択されました
私たちの最新の研究では、把持検出とクラス非依存の物体インスタンスセグメンテーションを共同で実装する手法を開発し、
BMVC21で発表しました。
詳細は[こちら](https://arxiv.org/pdf/2111.11114)をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---