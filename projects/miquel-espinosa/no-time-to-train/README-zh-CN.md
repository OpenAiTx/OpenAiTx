<div align="center">

# 🚀 无需训练！  
### 免训练参考图像实例分割  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**最新技术水平（Papers with Code）**

[**_1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🔔 **更新（2025年7月）：** 代码已更新并附有说明！

---

## 📋 目录

- [🎯 亮点](#-highlights)
- [📜 摘要](#-abstract)
- [🧠 架构](#-architecture)
- [🛠️ 安装说明](#️-installation-instructions)
  - [1. 克隆仓库](#1-clone-the-repository)
  - [2. 创建conda环境](#2-create-conda-environment)
  - [3. 安装SAM2和DinoV2](#3-install-sam2-and-dinov2)
  - [4. 下载数据集](#4-download-datasets)
  - [5. 下载SAM2和DinoV2检查点](#5-download-sam2-and-dinov2-checkpoints)
- [📊 推理代码：复现Few-shot COCO中30-shot SOTA结果](#-inference-code)
  - [0. 创建参考集](#0-create-reference-set)
  - [1. 用参考图像填充内存](#1-fill-memory-with-references)
  - [2. 后处理内存库](#2-post-process-memory-bank)
  - [3. 对目标图像进行推理](#3-inference-on-target-images)
  - [结果](#results)
- [🔍 引用](#-citation)


## 🎯 亮点
- 💡 **免训练**：无需微调，无需提示工程——只需参考图像。  
- 🖼️ **基于参考**：仅用少量示例即可分割新对象。  
- 🔥 **SOTA性能**：在COCO、PASCAL VOC和跨域FSOD上优于之前的免训练方法。

**链接：**
- 🧾 [**arXiv论文**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**项目网站**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 摘要

> 图像分割模型的性能历来受限于大规模标注数据采集的高成本。Segment Anything Model（SAM）通过一种可提示、语义无关的分割范式缓解了这一原始问题，但处理新图像时仍需手动视觉提示或复杂的领域相关提示生成规则。为减少这一新负担，我们的工作探讨了仅提供少量参考图像时的对象分割任务。我们的关键见解是利用基础模型学习的强语义先验，识别参考图像与目标图像间的对应区域。我们发现对应关系使得下游任务的实例级分割掩码能够自动生成，并通过多阶段、免训练的方法实现该思路，包括（1）构建内存库；（2）表示聚合；（3）语义感知特征匹配。实验显示分割指标显著提升，在COCO FSOD（36.8% nAP）、PASCAL VOC少样本（71.2% nAP50）上达成最新技术水平，并在跨域FSOD基准上优于现有免训练方法（22.4% nAP）。

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)


## 🧠 架构

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ 安装说明

### 1. 克隆仓库

```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. 创建 conda 环境

我们将创建一个包含所需软件包的 conda 环境。

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. 安装 SAM2 和 DinoV2

我们将从源码安装 SAM2 和 DinoV2。

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. 下载数据集

请下载 COCO 数据集并将其放置在 `data/coco`

### 5. 下载 SAM2 和 DinoV2 检查点

我们将下载论文中使用的确切 SAM2 检查点。
（但请注意，SAM2.1 检查点已经可用，且可能表现更好。）


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
<translate-content>

## 📊 推理代码

⚠️ 免责声明：这是研究代码——可能会有些混乱！

### 在少量样本 COCO 中复现 30-shot SOTA 结果

定义有用的变量并创建结果文件夹：
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
#### 0. 创建参考集


```bash
python dev_hongyi/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. 使用引用填充内存


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
#### 2. 后处理内存库


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. 对目标图像的推断


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
如果您想在线查看推理结果（实时计算），请取消注释 `dev_hongyi/models/Sam2MatchingBaseline_noAMG.py` 中第1746-1749行的注释，[链接](https://github.com/miquel-espinosa/no-time-to-train/blob/main/dev_hongyi/models/Sam2MatchingBaseline_noAMG.py#L1746)。
根据需要调整分数阈值参数 `score_thr`，以查看更多或更少的分割实例。
图像将保存在 `results_analysis/few_shot_classes/` 目录下。左侧图像显示真实标签，右侧图像显示我们无训练方法找到的分割实例。

请注意，此示例中我们使用的是 `few_shot_classes` 划分，因此只应看到该划分中的类别分割实例（而非COCO中的所有类别）。

#### 结果

运行验证集中的所有图像后，您应获得：


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