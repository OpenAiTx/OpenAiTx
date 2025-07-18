<div align="center">

# 🚀 トレーニング不要！  
### トレーニング不要の参照ベースインスタンスセグメンテーション  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**最先端（Papers with Code）**

[**_1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🔔 **更新（2025年7月）：** コードが更新され、手順が追加されました！

---

## 📋 目次

- [🎯 ハイライト](#-highlights)
- [📜 要約](#-abstract)
- [🧠 アーキテクチャ](#-architecture)
- [🛠️ インストール手順](#️-installation-instructions)
  - [1. リポジトリをクローンする](#1-clone-the-repository)
  - [2. conda環境を作成する](#2-create-conda-environment)
  - [3. SAM2とDinoV2をインストールする](#3-install-sam2-and-dinov2)
  - [4. データセットをダウンロードする](#4-download-datasets)
  - [5. SAM2とDinoV2のチェックポイントをダウンロードする](#5-download-sam2-and-dinov2-checkpoints)
- [📊 推論コード: Few-shot COCOで30-shotのSOTA結果を再現](#-inference-code)
  - [0. 参照セットを作成する](#0-create-reference-set)
  - [1. メモリに参照を格納する](#1-fill-memory-with-references)
  - [2. メモリバンクを後処理する](#2-post-process-memory-bank)
  - [3. ターゲット画像で推論する](#3-inference-on-target-images)
  - [結果](#results)
- [🔍 引用](#-citation)


## 🎯 ハイライト
- 💡 **トレーニング不要**: ファインチューニング不要、プロンプト設計不要 — 参照画像だけで完結。  
- 🖼️ **参照ベース**: 少数の例だけで新しいオブジェクトをセグメント化。  
- 🔥 **最先端性能**: COCO、PASCAL VOC、クロスドメインFSODで過去のトレーニング不要手法を上回る性能。

**リンク:**
- 🧾 [**arXiv論文**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**プロジェクトサイト**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 要約

> 画像セグメンテーションモデルの性能は、大規模な注釈データ収集の高コストにより歴史的に制約されてきました。Segment Anything Model (SAM) は、プロンプト可能でセマンティクスに依存しないセグメンテーションパラダイムによりこの問題を緩和しますが、新しい画像を処理するには依然として手動の視覚プロンプトや複雑なドメイン依存のプロンプト生成規則が必要です。この新たな負担を減らすために、本研究では代わりに少数の参照画像のみを与えられた場合のオブジェクトセグメンテーションタスクを調査します。我々の重要な洞察は、基盤モデルによって学習された強力なセマンティックプライオリを活用し、参照画像とターゲット画像間の対応領域を特定することにあります。対応関係は下流タスクのためのインスタンスレベルセグメンテーションマスクの自動生成を可能にし、我々の手法は(1) メモリバンク構築、(2) 表現集約、(3) セマンティック認識特徴マッチングを含む多段階のトレーニング不要メソッドとして具現化されます。実験ではセグメンテーション指標が大幅に向上し、COCO FSOD (36.8% nAP)、PASCAL VOC Few-Shot (71.2% nAP50) で最先端性能を達成し、クロスドメインFSODベンチマークの既存のトレーニング不要手法を上回りました (22.4% nAP)。

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)


## 🧠 アーキテクチャ

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ インストール手順

### 1. リポジトリをクローンする

```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. conda環境の作成

必要なパッケージを含むconda環境を作成します。

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. SAM2 と DinoV2 のインストール

SAM2 と DinoV2 をソースからインストールします。

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. データセットのダウンロード

COCOデータセットをダウンロードし、`data/coco` に配置してください。

### 5. SAM2およびDinoV2チェックポイントのダウンロード

論文で使用された正確なSAM2チェックポイントをダウンロードします。
（ただし、SAM2.1のチェックポイントはすでに利用可能であり、より良い性能を示す可能性があります。）


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
<translate-content>

## 📊 推論コード

⚠️ 免責事項：これは研究用コードです — 多少の混乱はご容赦ください！

### Few-shot COCOで30ショットSOTA結果の再現

有用な変数を定義し、結果用のフォルダを作成します：
</translate-content>
```bash
CONFIG=./dev_hongyi/new_exps/coco_fewshot_10shot_Sam2L.yaml
CLASS_SPLIT="few_shot_classes"
RESULTS_DIR=work_dirs/few_shot_results
SHOTS=30
SEED=33
GPUS=4

mkdir -p $RESULTS_DIR
FILENAME=few_shot_${SHOTS}shot_seed${SEED}.pkl
```
#### 0. 参照セットの作成


```bash
python dev_hongyi/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. 参照でメモリを埋める


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode fill_memory \
                              --out_path ${RESULTS_DIR}/memory.ckpt \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.memory_pkl ${RESULTS_DIR}/${FILENAME} \
                              --model.init_args.dataset_cfgs.fill_memory.memory_length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
#### 2. ポストプロセスメモリバンク


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. 対象画像に対する推論


```bash
python run_lightening.py test --config $CONFIG  \
                              --ckpt_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --model.init_args.test_mode test \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.model_cfg.dataset_name $CLASS_SPLIT \
                              --model.init_args.dataset_cfgs.test.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
<translate-content>
推論結果をオンラインで（計算されると同時に）確認したい場合は、`dev_hongyi/models/Sam2MatchingBaseline_noAMG.py`の1746～1749行のコメントを解除してください。[こちら](https://github.com/miquel-espinosa/no-time-to-train/blob/main/dev_hongyi/models/Sam2MatchingBaseline_noAMG.py#L1746)にあります。  
必要に応じてスコアの閾値`score_thr`パラメータを調整し、より多くまたは少なくセグメント化されたインスタンスを表示してください。  
画像は`results_analysis/few_shot_classes/`に保存されます。左側の画像は正解、右側の画像はトレーニング不要の手法で検出されたセグメント化インスタンスを示しています。  

この例では`few_shot_classes`の分割を使用しているため、この分割に含まれるクラスのセグメント化インスタンスのみが表示されることに注意してください（COCOのすべてのクラスではありません）。  

#### 結果  

検証セット内のすべての画像を実行後、以下が得られるはずです：  
</translate-content>
```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---


## 🔍 Citation

If you use this work, please cite us:

```bibtex
@article{espinosa2025notimetotrain,
  title={No time to train! Training-Free Reference-Based Instance Segmentation},
  author={Miguel Espinosa and Chenhongyi Yang and Linus Ericsson and Steven McDonagh and Elliot J. Crowley},
  journal={arXiv preprint arXiv:2507.02798},
  year={2025},
  primaryclass={cs.CV}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---