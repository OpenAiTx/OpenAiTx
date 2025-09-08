# 用于机器人抓取检测和RGB语义分割的端到端可训练深度神经网络

<p align="center">
<img src="https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/Network.png" width="100%"/>
<br>
<a href="https://arxiv.org/abs/2107.05287">arXiv</a>
</p>

本仓库包含ICRA21论文“用于机器人抓取检测和RGB语义分割的端到端可训练深度神经网络”的代码。  
它包含了结合OCID_grasp数据集的我们提出方法的训练和测试代码。  

如果您在研究中使用了我们的方法或数据集扩展，请引用：

```bibtex
@InProceedings{ainetter2021end,
  title={End-to-end Trainable Deep Neural Network for Robotic Grasp Detection and Semantic Segmentation from RGB},
  author={Ainetter, Stefan and Fraundorfer, Friedrich},
  booktitle={IEEE International Conference on Robotics and Automation (ICRA)},
  pages={13452--13458}
  year={2021}
}
```

## 要求和设置

主要系统要求：
* CUDA 10.1
* 运行 GCC 7 或 8 的 Linux
* PyTorch v1.1.0

**重要说明**：这些要求并非绝对严格，例如可能可以使用较旧版本的 CUDA 编译，或者在 Windows 下运行。
但是，我们仅在上述环境下测试过代码，无法为其他环境提供支持。

安装 PyTorch，请参考 https://github.com/pytorch/pytorch#installation。

使用 pip 安装所有其他依赖项：
```bash
pip install -r requirements.txt
```

### 设置

我们的代码分为两个主要部分：包含各种网络模块、算法和工具实现的库，
以及一组用于训练/测试网络的脚本。

该库名为 `grasp_det_seg`，可以通过以下方式安装：
```bash
git clone https://github.com/stefan-ainetter/grasp_det_seg_cnn.git
cd grasp_det_seg_cnn
python setup.py install
```

## 训练模型

提供的模型文件根据 [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/) 许可协议发布。

OCID_grasp 数据集的训练模型可以从[这里](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_pretrained)下载。  
下载后将权重文件复制到 `ckpt_files_OCID/pretrained` 文件夹中。

要在 OCID_grasp 上重新训练网络，您需要下载基于 ImageNet 预训练的权重  
[这里](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/ImageNet_weights)，并将它们复制到 `weights_pretrained` 文件夹中。

### 训练

训练包含三个主要步骤：准备数据集、创建配置文件以及运行训练脚本。

准备数据集步骤：  
1) 从[这里](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)下载 OCID_grasp 数据集。  
将下载的 `OCID_grasp.zip` 文件解压到 `DATA` 文件夹中。  
2) 配置文件是一个简单的 `ini` 格式文本文件。  
每个配置参数的默认值以及其简要说明可在  
[grasp_det_seg/config/defaults](grasp_det_seg/config/defaults) 中查看。  
**注意**，这些仅作为每个参数“合理”值的指示，并非用来复现我们论文中的任何结果。

3) 启动训练：



```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 train_det_seg_OCID.py 
--log_dir=LOGDIR CONFIG DATA_DIR
```
训练日志，包括文本格式和Tensorboard格式，以及训练好的网络参数，将被写入`LOG_DIR`（例如`ckpt_files_OCID`）。  
文件`CONFIG`包含网络配置，例如`grasp_det_seg/config/defaults/det_seg_OCID.ini`，  
而`DATA_DIR`指向之前下载的OCID_grasp数据划分，例如`DATA/OCID_grasp/data_split`。  

请注意，目前我们的代码**必须**使用PyTorch的`torch.distributed.launch`工具以“分布式”模式启动。  

### 运行推理  

给定一个训练好的网络，可以使用  
[scripts/test_det_seg_OCID.py](https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/scripts/test_det_seg_OCID.py)  
对任意图像集运行推理：

```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 test_det_seg_OCID.py 
--log_dir=LOG_DIR CONFIG MODEL_PARAMS DATA_DIR OUTPUT_DIR

```
预测结果将写入 `OUTPUT_DIR`，例如 `output` 文件夹。`MODEL_PARAMS` 是预训练权重，例如 `ckpt_files_OCID/pretrained/model_last.pth.tar`，  
`DATA_DIR` 指向所用的数据集划分，例如 `DATA/OCID_grasp/data_split`。  

## OCID_grasp 数据集  
OCID_grasp 数据集可从[此处](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)下载。  
OCID_grasp 包含 OCID 数据集中选取的 1763 张 RGB-D 图像，拥有超过 11.4k 个分割的物体掩码和超过 75k 个手工标注的  
抓取候选。此外，每个物体被分类为 31 个物体类别之一。  
## 相关工作  
OCID_grasp 是 [OCID 数据集](https://www.acin.tuwien.ac.at/en/vision-for-robotics/software-tools/object-clutter-indoor-dataset/)的扩展数据集。  
如果您决定使用 OCID_grasp 进行研究，请同时引用 OCID 论文：
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
我们的框架基于[Seamless Scene Segmentation](https://github.com/mapillary/seamseg)的架构：
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
## 关于我们最新的研究
### 我们的论文《面向机器人抓取任务的深度感知物体分割与抓取检测》被BMVC21录用
在我们最新的工作中，我们实现了一种联合抓取检测和类别无关物体实例分割的方法，
该方法已发表于BMVC21。
更多信息请见[这里](https://arxiv.org/pdf/2111.11114)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---