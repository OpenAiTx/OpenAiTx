<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# 🚀 沒有時間訓練！  
### 無需訓練的參考式實例分割  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**最先進技術（Papers with Code）**

[**_1次_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_10次_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_30次_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🔔 **更新（2025年7月）：** 程式碼已更新並附上操作說明！

---

## 📋 目錄

- [🎯 亮點](#-highlights)
- [📜 摘要](#-abstract)
- [🧠 架構](#-architecture)
- [🛠️ 安裝說明](#️-installation-instructions)
  - [1. 複製儲存庫](#1-clone-the-repository)
  - [2. 建立conda環境](#2-create-conda-environment)
  - [3. 安裝SAM2與DinoV2](#3-install-sam2-and-dinov2)
  - [4. 下載數據集](#4-download-datasets)
  - [5. 下載SAM2與DinoV2檢查點](#5-download-sam2-and-dinov2-checkpoints)
- [📊 推論程式碼：在Few-shot COCO復現30-shot SOTA結果](#-inference-code)
  - [0. 建立參考集](#0-create-reference-set)
  - [1. 用參考圖填充記憶體](#1-fill-memory-with-references)
  - [2. 後處理記憶庫](#2-post-process-memory-bank)
  - [3. 在目標圖像上推論](#3-inference-on-target-images)
  - [結果](#results)
- [🔍 引用](#-citation)


## 🎯 亮點
- 💡 **無需訓練**：無需微調，無需提示工程——只需一張參考圖像。  
- 🖼️ **參考式**：僅用少量範例即可分割新物體。  
- 🔥 **SOTA表現**：在COCO、PASCAL VOC和跨域FSOD上超越以往無需訓練方法。

**連結：**
- 🧾 [**arXiv 論文**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**專案網站**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 摘要

> 圖像分割模型的效能歷來受限於收集大規模標註數據的高昂成本。Segment Anything Model（SAM）通過可提示、語義無關的分割範式，緩解了這一原始問題，但在處理新圖像時仍需人工視覺提示或複雜的領域依賴提示生成規則。為減輕這一新負擔，我們探討了在只提供一小組參考圖像的情境下的物體分割任務。我們的關鍵洞察是利用基礎模型學到的強大語義先驗，來識別參考圖像與目標圖像之間的對應區域。我們發現這種對應關係能夠自動生成用於下游任務的實例級分割遮罩，並通過一種多階段、無需訓練的方法來實現我們的理念，包括（1）記憶庫構建；（2）表示聚合；（3）語義感知特徵匹配。我們的實驗在分割指標上顯著提升，在COCO FSOD（36.8% nAP）、PASCAL VOC少樣本（71.2% nAP50）上達到最先進水準，並在跨域FSOD基準上超越現有無需訓練方法（22.4% nAP）。

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)


## 🧠 架構

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ 安裝說明

### 1. 複製儲存庫


```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. 建立 conda 環境

我們將建立一個包含所需套件的 conda 環境。

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. 安裝 SAM2 和 DinoV2

我們將從原始碼安裝 SAM2 和 DinoV2。

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. 下載數據集

請下載 COCO 數據集並將其放置於 `data/coco`

### 5. 下載 SAM2 和 DinoV2 權重檔

我們將下載論文中使用的 SAM2 權重檔。
（但請注意，SAM2.1 權重檔已經可用，且可能有更好的表現。）


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 推論程式碼

⚠️ 免責聲明：這是研究用程式碼——請預期會有一些混亂！

### 在 Few-shot COCO 中重現 30-shot SOTA 結果

定義有用的變數並為結果建立資料夾：



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
#### 0. 建立參考集


```bash
python dev_hongyi/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. 用參考填充記憶體


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
#### 2. 後處理記憶體庫


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. 在目標影像上進行推論


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
如果您想要即時查看推論結果（當它們被計算時），請取消註解 `dev_hongyi/models/Sam2MatchingBaseline_noAMG.py` 中第 1746-1749 行 [這裡](https://github.com/miquel-espinosa/no-time-to-train/blob/main/dev_hongyi/models/Sam2MatchingBaseline_noAMG.py#L1746)。
根據需要調整分數閾值 `score_thr` 參數，以查看更多或更少的分割實例。
影像將會被儲存在 `results_analysis/few_shot_classes/`。左側的影像顯示的是真實標註，右側的影像顯示的是我們無需訓練方法找到的分割實例。

請注意，在此範例中我們使用的是 `few_shot_classes` 分割，因此，我們只應該看到該分割中的類別被分割出來的實例（而不是 COCO 中的所有類別）。

#### 結果

在對驗證集中的所有影像進行推論後，您應該會得到：


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---