# TopicFM+: トピック支援特徴マッチングの精度と効率の向上

このコードは[TopicFM+](https://arxiv.org/abs/2307.00485)を実装しています。これは[TopicFM](https://arxiv.org/abs/2207.00328)の拡張版です。以前のバージョンTopicFMの実装は`aaai23_ver`ブランチをご覧ください。

## 要件

本論文の全ての実験は、Ubuntu環境で
NVIDIAドライバ430.64以上、CUDA 10.1で実施されています。

まず、anacondaで仮想環境を作成します。

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # 不足パッケージはpipでインストールしてください

## データ準備

提案手法はMegaDepthデータセットで学習し、
MegaDepthテスト、ScanNet、HPatches、Aachen Day and Night (v1.1)、InLocデータセットで評価しています。
これらのデータセットは大容量のため、このコードには含まれていません。
以下の説明に従ってダウンロードしてください。

### MegaDepth

このデータセットは学習と評価の両方に使用します（Li and Snavely 2018）。
本コードで使用するには、[LoFTRの説明](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)に従ってください。

### ScanNet
評価にはScanNetの1500組の画像ペアのみを使用します（Dai et al. 2017）。
ScanNetの[testデータ](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf)を
[LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)からダウンロードし準備してください。

## 学習

モデルの学習には可能な限りGPUカードを使用し、
各GPUは少なくとも12GBを推奨します。
当方の環境では12GBのGPUを4枚使用して学習しています。
ハードウェア環境は`scripts/reproduce_train/outdoor.sh`で設定してください。
学習開始は以下のコマンドで行います。
    bash scripts/reproduce_train/outdoor.sh <トレーニング設定ファイルへのパス>
    # 例えば、
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

 論文で使用した事前学習済みモデルを提供しています ([TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing), [TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing))

## 評価

### MegaDepth（相対姿勢推定）

    bash scripts/reproduce_test/outdoor.sh <configsフォルダ内の設定ファイルへのパス> <事前学習済みモデルへのパス>
    # 例えば、TopicFM-fastを評価する場合
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet（相対姿勢推定）

    bash scripts/reproduce_test/indoor.sh <configsフォルダ内の設定ファイルへのパス> <事前学習済みモデルへのパス>

### HPatches, Aachen v1.1, InLoc

これらのデータセットで評価するために、Patch2Pixが提供するimage-matching-toolboxにコードを統合しました。
更新されたコードと詳細な評価は[こちら](https://github.com/TruongKhang/image-matching-toolbox)から入手可能です。

### Image Matching Challenge 2023

我々の手法TopicFM+はKaggle IMC2023で高い順位（銀メダル）を獲得しました。[こちら](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public)からご覧いただけます。

### 効率比較

論文で報告した効率評価は、ScanNet評価データセットの1500組の画像ペアの平均実行時間を計測したものです。
画像サイズは`configs/data/scannet_test_topicfmfast.py`で変更可能です。

LoFTR、MatchFormer、QuadTree、AspanFormerについては、GFLOPsでの計算コストとmsでの実行時間を計測しました。ただし、それぞれの手法のコードを個別に少し修正する必要がありました。これらの手法の評価が必要な場合はお問い合わせください。

ここでは、我々の手法TopicFM-fastの実行時間計測を提供します。

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

画像解像度(640, 480)での実行時間報告（NVIDIA TITAN V 32GBメモリ上で計測）

|   モデル       |    640 x 480   |    1200 x 896    |
|:--------------|:--------------:|:----------------:|
| TopicFM-fast  |     56 ms      |      346 ms      |
| TopicFM+      |     90 ms      |      388 ms      |


## 引用文献
このコードが役立った場合は、以下の文献を引用してください：

    @article{giang2024topicfm+,
      title={Topicfm+: トピック支援特徴マッチングの精度と効率の向上},
      author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
      journal={IEEE Transactions on Image Processing},
      year={2024},
      publisher={IEEE}
    }

または

    @inproceedings{giang2023topicfm,
        title={TopicFM: ロバストで解釈可能なトピック支援特徴マッチング},
        author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
        booktitle={Proceedings of the AAAI Conference on Artificial Intelligence},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## 謝辞
このコードは[LoFTR](https://github.com/zju3dv/LoFTR)を基に構築されています。著者の皆様には有益なソースコードを提供していただき感謝します。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---