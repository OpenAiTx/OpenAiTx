# TopicFM+: Boosting Accuracy and Efficiency of Topic-Assisted Feature Matching 
    
This code implements [TopicFM+](https://arxiv.org/abs/2307.00485), which is an extension of [TopicFM](https://arxiv.org/abs/2207.00328). For the implementation of previous version TopicFM, please checkout the `aaai23_ver` branch.


## Requirements

All experiments in this paper are implemented on the Ubuntu environment 
with a NVIDIA driver of at least 430.64 and CUDA 10.1.

First, create a virtual environment by anaconda as follows,

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # using pip to install any missing packages

## Data Preparation

The proposed method is trained on the MegaDepth dataset and evaluated on the MegaDepth test, ScanNet, HPatches, Aachen Day and Night (v1.1), and InLoc dataset.
All these datasets are large, so we cannot include them in this code. 
The following descriptions help download these datasets. 

### MegaDepth

This dataset is used for both training and evaluation (Li and Snavely 2018). 
To use this dataset with our code, please follow the [instruction of LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

### ScanNet 
We only use 1500 image pairs of ScanNet (Dai et al. 2017) for evaluation. 
Please download and prepare [test data](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf) of ScanNet
provided by [LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

## Training

To train our model, we recommend using GPU cards as much as possible, and each GPU should be at least 12GB.
In our settings, we train on 4 GPUs, each of which is 12GB. 
Please setup your hardware environment in `scripts/reproduce_train/outdoor.sh`.
Then run this command to start training.

    bash scripts/reproduce_train/outdoor.sh <path to the training config file>
    # for example,
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

 We provided the pretrained models, which were used in the paper ([TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing), [TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing))

## Evaluation

### MegaDepth (relative pose estimation)

    bash scripts/reproduce_test/outdoor.sh <path to the config file in the folder configs> <path to pretrained model>
    # For example, to evaluate TopicFM-fast 
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet (relative pose estimation)

    bash scripts/reproduce_test/indoor.sh <path to the config file in the folder configs> <path to pretrained model>

### HPatches, Aachen v1.1, InLoc

To evaluate on these datasets, we integrate our code to the image-matching-toolbox provided by Patch2Pix.
The updated code and detailed evaluations are available [here](https://github.com/TruongKhang/image-matching-toolbox). 

### Image Matching Challange 2023

Our method TopicFM+ achieved a high ranking (silver medal) on the Kaggle IMC2023 [here](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public). 

### Efficiency comparison

The efficiency evaluation reported in the paper was measured by averaging runtime of 1500 image pairs of the ScanNet evaluation dataset.
The image size can be changed in `configs/data/scannet_test_topicfmfast.py`

We computed computational costs in GFLOPs and runtimes in ms for LoFTR, MatchFormer, QuadTree, and AspanFormer. However, this process required minor modification of the code of each method individually. Please contact us if you need evaluations for those methods.

Here, we provide the runtime measurement for our method, TopicFM-fast

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

Runtime report at the image resolution of (640, 480) (measured on NVIDIA TITAN V 32GB of Mem.)


|   Model       |    640 x 480   |    1200 x 896    |
|:--------------|:--------------:|:----------------:|
| TopicFM-fast  |     56 ms      |      346 ms      |
| TopicFM+      |     90 ms      |      388 ms      |


## Citations
If you find this code useful, please cite the following works:

    @article{giang2024topicfm+,
      title={Topicfm+: Boosting accuracy and efficiency of topic-assisted feature matching},
      author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
      journal={IEEE Transactions on Image Processing},
      year={2024},
      publisher={IEEE}
    }

or

    @inproceedings{giang2023topicfm,
        title={TopicFM: Robust and interpretable topic-assisted feature matching},
        author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
        booktitle={Proceedings of the AAAI Conference on Artificial Intelligence},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## Acknowledgement
This code is built based on [LoFTR](https://github.com/zju3dv/LoFTR). We thank the authors for their useful source code.
