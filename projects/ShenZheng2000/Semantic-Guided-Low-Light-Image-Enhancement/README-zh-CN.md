# 语义引导的低光照图像增强
这是我们论文“**语义引导的零样本学习用于低光照图像/视频增强**”的官方Pytorch实现

# 更新
- 2021.11.27：模型架构图已上传。
- 2021.11.10：本工作已被接受，将在[WACV 2022](https://wacv2022.thecvf.com/home)上展示。
- 2021.10.8：计算mPA和mIOU分数的简便方法已在此[仓库](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)提供。
- 2021.10.6：发布了一个增强后的低光视频GIF样例。
- 2021.10.5：一个低光视频及其增强结果样例可见：[[低光](https://www.youtube.com/watch?v=4Avy_xsczdU)] [[增强](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5：我新的[仓库](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning)收集了多种低光增强方法。希望对你有帮助。
- 2021.10.4：arxiv链接已发布：http://arxiv.org/abs/2110.00970

# 摘要

Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.

# 模型架构
点击以下链接查看模型架构的 PDF 格式。

![模型架构](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)

# 样例结果
## 1. 低光视频帧
从左到右，从上到下：暗光，Retinex [1]，KinD [2]，EnlightenGAN [3]，Zero-DCE [4]，我们的结果。

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />
</p>

## 2. 低光图像（真实场景）
从左到右，从上到下：暗光，PIE [5]，LIME [6]，Retinex [1]，MBLLEN [7]，KinD [2]，Zero-DCE [4]，我们的结果。

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Dark7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/PIE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/LIME7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Retinex7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/mbllen7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/KinD7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/ZeroDCE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Ours7.jpg" width="200" />
</p>

# 快速开始

## 1. 环境要求
* CUDA 10.0
* Python 3.6+
* Pytorch 1.0+
* torchvision 0.4+
* opencv-python
* numpy
* pillow
* scikit-image

## 2. 准备数据集
### 测试数据集
- 从[BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg)下载官方测试图像，密码为 `8itq`。 
- 将解压后的文件移动到 `data/test_data/` 目录下。 
- 你也可以将自定义数据集或自己的低光图像放入该文件夹进行测试。例如：`data/test_data/yourDataset/`

### 训练数据集
- 从[GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view)下载官方训练图像。 
- 将解压后的文件移动到 `data/train_data/` 目录下。 

注意：如果你没有百度云账号，可以通过[Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)下载训练和测试数据集。

准备完成后，数据文件夹应如下所示：
```
data/
├── test_data/
│   ├── lowCUT/
│   ├── BDD/
│   ├── Cityscapes/
│   ├── DICM/
│   ├── LIME/
│   ├── LOL/
│   ├── MEF/
│   ├── NPE/
│   └── VV/
└── train_data/
    └── ...
```

## 3. 从头开始训练
训练模型：
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```
示例（从头开始训练）：

```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. 恢复训练

从检查点恢复训练：
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```

示例（从 Epoch99.pth 恢复）：
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```
 
## 5. 测试
**注意：请删除 `data` 文件夹中的所有 readme.txt 文件，以避免模型推理错误。**

测试模型：

```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
示例：

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. 视频测试
对于视频（MP4格式）上的模型测试，在终端运行：
```
bash test_video.sh
```

在 `demo/make_video.py` 中有五个用于视频测试的超参数。具体说明如下。  
- `video_path`：低光视频的路径  
- `image_lowlight_folder`：低光图像的路径  
- `image_folder`：增强图像的路径  
- `save_path`：增强后视频的保存路径  
- `choice`：选择是将视频转换为图像，还是将图像转换为视频  


# 超参数  
| 名称                 | 类型  | 默认值              |  
|----------------------|-------|--------------------|  
| lowlight_images_path  | str   | data/train_data/   |  
| lr                   | float | 1e-3               |  
| weight_decay         | float | 1e-3               |  
| grad_clip_norm       | float | 0.1                |  
| num_epochs           | int   | 100                |  
| train_batch_size     | int   | 6                  |  
| val_batch_size       | int   | 8                  |  
| num_workers          | int   | 4                  |  
| display_iter         | int   | 10                 |  
| snapshot_iter        | int   | 10                 |  
| scale_factor         | int   | 1                  |  
| snapshots_folder     | str   | weight/            |  
| load_pretrain        | bool  | False              |  
| pretrain_dir         | str   | weight/Epoch99.pth |  
| num_of_SegClass      | int   | 21                 |  
| conv_type            | str   | dsc                |  
| patch_size           | int   | 4                  |  
| exp_level            | float | 0.6                |  


# 待办事项列表  
- [x] 列出（重要）超参数  
- [x] 解决模型输入尺寸问题  
- [x] 上传预训练权重  
- [x] 在 option.py 中重写训练和测试的 argparse  
- [x] 将训练重写为类  
- [x] 将测试重写为类  
- [x] 上传测试数据集
- [x] 上传 Arxiv 链接
- [x] 视频测试
- [x] 上传 BibTeX
- [x] 修改 Readme 文件
- [x] 上传模型架构
- [ ] 提供在线演示
# 其他
如有任何问题，请联系 zhengsh@kean.edu。本仓库大量基于 [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE)。感谢分享代码！

# 引用
如果您觉得本仓库有帮助，请引用以下论文。
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```


# 参考文献
[1] 魏晨等。“用于低光照增强的深度Retinex分解。”arXiv预印本 arXiv:1808.04560 (2018)。

[2] 张永华，张家湾，郭晓杰。“点亮黑暗：一种实用的低光照图像增强方法。”第27届ACM国际多媒体会议论文集，2019年。

[3] 姜一凡等。“Enlightengan：无配对监督的深度光照增强。”IEEE图像处理汇刊 30 (2021): 2340-2349。

[4] 郭春乐等。“零参考深度曲线估计用于低光照图像增强。”IEEE/CVF计算机视觉与模式识别会议论文集，2020年。

[5] 傅雪阳等。“一种同时估计光照和反射率的图像增强概率方法。”IEEE图像处理汇刊 24.12 (2015): 4965-4977。

[6] 郭晓杰，李瑜，凌海滨。“LIME：基于光照图估计的低光照图像增强。”IEEE图像处理汇刊 26.2 (2016): 982-993。

[7] 吕飞凡等。“MBLLEN：基于卷积神经网络的低光照图像/视频增强。”英国机器视觉大会，2018年。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---