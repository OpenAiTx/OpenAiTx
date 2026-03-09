# TopicFM+: 提升主题辅助特征匹配的准确性和效率

本代码实现了[TopicFM+](https://arxiv.org/abs/2307.00485)，这是[TopicFM](https://arxiv.org/abs/2207.00328)的扩展版本。关于之前版本TopicFM的实现，请查看`aaai23_ver`分支。

## 需求

本文中的所有实验均在Ubuntu环境下实现，
NVIDIA驱动版本不低于430.64，CUDA版本为10.1。

首先，通过anaconda创建虚拟环境，如下所示，

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # 使用pip安装任何缺失的包

## 数据准备

所提方法在MegaDepth数据集上进行训练，并在MegaDepth测试集、ScanNet、HPatches、Aachen Day and Night (v1.1)和InLoc数据集上进行评估。
这些数据集都很大，因此无法包含在本代码中。
以下描述帮助下载这些数据集。

### MegaDepth

该数据集用于训练和评估（Li和Snavely 2018）。
要在我们的代码中使用该数据集，请遵循[LoFTR的说明](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)。

### ScanNet

我们仅使用ScanNet（Dai等人，2017）的1500对图像进行评估。
请下载并准备ScanNet的[测试数据](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf)，
由[LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)提供。

## 训练

为了训练我们的模型，建议尽可能使用GPU卡，每块GPU至少12GB。
在我们的设置中，使用4块GPU进行训练，每块12GB。
请在`scripts/reproduce_train/outdoor.sh`中配置您的硬件环境。
然后运行此命令开始训练。

    bash scripts/reproduce_train/outdoor.sh <训练配置文件的路径>
    # 例如，
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

 我们提供了论文中使用的预训练模型（[TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing)，[TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing)）

## 评估

### MegaDepth（相对位姿估计）

    bash scripts/reproduce_test/outdoor.sh <configs文件夹中配置文件的路径> <预训练模型的路径>
    # 例如，评估TopicFM-fast 
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet（相对位姿估计）

    bash scripts/reproduce_test/indoor.sh <configs文件夹中配置文件的路径> <预训练模型的路径>

### HPatches, Aachen v1.1, InLoc

要在这些数据集上评估，我们将代码集成到了Patch2Pix提供的image-matching-toolbox中。  
更新后的代码和详细评估可在[此处](https://github.com/TruongKhang/image-matching-toolbox)获取。 

### 图像匹配挑战赛 2023

我们的方法TopicFM+在Kaggle IMC2023中获得了较高排名（银牌），详情见[这里](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public)。 

### 效率对比

论文中报告的效率评估是通过对ScanNet评估数据集中的1500对图像的运行时间取平均得到的。  
图像尺寸可在 `configs/data/scannet_test_topicfmfast.py` 中修改

我们计算了LoFTR、MatchFormer、QuadTree和AspanFormer的计算开销（GFLOPs）和运行时间（毫秒）。但此过程需要对各方法的代码做少量修改。若需要这些方法的评估结果，请联系我们。

这里提供我们方法TopicFM-fast的运行时间测量命令

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

图像分辨率为 (640, 480) 时的运行时间报告（在NVIDIA TITAN V 32GB显存上测量）
|   模型       |    640 x 480   |    1200 x 896    |
|:--------------|:--------------:|:----------------:|
| TopicFM-fast  |     56 毫秒    |      346 毫秒    |
| TopicFM+      |     90 毫秒    |      388 毫秒    |


## 引用
如果您觉得此代码有用，请引用以下文献：

    @article{giang2024topicfm+,
      title={Topicfm+: 提升主题辅助特征匹配的准确性和效率},
      author={Giang, Khang Truong 和 Song, Soohwan 以及 Jo, Sungho},
      journal={IEEE 图像处理汇刊},
      year={2024},
      publisher={IEEE}
    }

或者

    @inproceedings{giang2023topicfm,
        title={TopicFM: 鲁棒且可解释的主题辅助特征匹配},
        author={Giang, Khang Truong 和 Song, Soohwan 以及 Jo, Sungho},
        booktitle={AAAI 人工智能会议论文集},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## 致谢
此代码基于 [LoFTR](https://github.com/zju3dv/LoFTR) 构建。我们感谢作者提供的有用源码。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---