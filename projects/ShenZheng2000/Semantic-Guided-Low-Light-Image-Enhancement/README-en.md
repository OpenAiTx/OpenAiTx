# Semantic-Guided-Low-Light-Image-Enhancement
This is the official Pytorch implementation for our paper "**Semantic-Guided Zero-Shot Learning for Low-Light Image/Video Enhancement**" 

# Updates
- 2021.11.27: The figure for the model architecture has been uploaded.
- 2021.11.10: This work is accepted and will be presented at [WACV 2022](https://wacv2022.thecvf.com/home).
- 2021.10.8: An easy way to calculate mPA and mIOU score is available at this [repository](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)
- 2021.10.6: A sample enhanced low-light video in GIF format has been released. 
- 2021.10.5: A sample low-light video and its enhanced result is available at: [[Low-Light](https://www.youtube.com/watch?v=4Avy_xsczdU)]  [[Enhanced](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5: My new [repository](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning) contains a collection of low-light enhancement methods. Hope you will find it helpful. 
- 2021.10.4: The arxiv link is available at http://arxiv.org/abs/2110.00970


# Abstract
Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.

# Model Architecture
Click the following link to see the model architecture in pdf format. 

![Model Architecture](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)

# Sample Results
## 1. Low-Light Video Frames
From left to right, and from top to bottom: Dark, Retinex [1], KinD [2], EnlightenGAN [3], Zero-DCE [4], Ours.

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />
</p>

## 2. Low-Light Images (Real-World)
From left to right, and from top to bottom: Dark, PIE [5], LIME [6], Retinex [1], MBLLEN [7], KinD [2] , Zero-DCE [4], Ours

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

# Get Started

## 1. Requirements
* CUDA 10.0
* Python 3.6+
* Pytorch 1.0+
* torchvision 0.4+
* opencv-python
* numpy
* pillow
* scikit-image

## 2. Prepare Datasets
### Testing Dataset
- Downloaded the official testing images from [BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg) with password `8itq`. 
- Move the unzipped file into `data/test_data/`. 
- You can also put custom datasets or your own low-light images in this folder for testing. Example: `data/test_data/yourDataset/`

### Training Dataset
- Downloaded the official training images from [GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view). 
- Move the unzipped file into `data/train_data/`. 

NOTE: If you don't have BaiduYun account, you can download both the training and the testing dataset via [Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)

After preparation, the data folders should look like this:
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

## 3. Training from Scratch
To train the model:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```
Example (train from scratch):

```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. Resume Training

To resume training from a checkpoint:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```

Example (resume from Epoch99.pth):
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```

 
## 5. Testing
**NOTE: Please delete all readme.txt in the `data` folder to avoid model inference error.**

To test the model:
```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
Example:

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. Testing on Videos
For model testing on videos (MP4 format), run in terminal:
```
bash test_video.sh
```

There are five hyperparameters in `demo/make_video.py` for video testing. See the following explanation. 
- `video_path`: path of the low-light video
- `image_lowlight_folder`: path of the low-light images
- `image_folder`: path of the enhanced images
- `save_path`: path of the enhanced video
- `choice`: whether converting video to image, or image to video


# Hyperparameters
| Name                 | Type  | Default            | 
|----------------------|-------|--------------------|
| lowlight_images_path | str   | data/train_data/   |         
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


# TODO List
- [x] List (important) hyperparameters
- [x] Address model input size issue
- [x] Upload Pretrained Weight 
- [x] Rewrite training and testing argparse in a option.py
- [x] Rewrite training as a class
- [x] Rewrite testing as a class  
- [x] Upload Testing Dataset
- [x] Upload Arxiv Link
- [x] Testing on Video
- [x] Upload BibTeX
- [x] Modify Readme file
- [x] Upload Model Architecture
- [ ] Provide Online Demo
# Others
Please reach zhengsh@kean.edu if you have any questions. This repository is heavily based upon [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE). Thanks for sharing the code!

# Citations
Please cite the following paper if you find this repository helpful.
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```

# References
[1] Wei, Chen, et al. "Deep retinex decomposition for low-light enhancement." arXiv preprint arXiv:1808.04560 (2018).

[2] Zhang, Yonghua, Jiawan Zhang, and Xiaojie Guo. "Kindling the darkness: A practical low-light image enhancer." Proceedings of the 27th ACM international conference on multimedia. 2019.

[3] Jiang, Yifan, et al. "Enlightengan: Deep light enhancement without paired supervision." IEEE Transactions on Image Processing 30 (2021): 2340-2349.

[4] Guo, Chunle, et al. "Zero-reference deep curve estimation for low-light image enhancement." Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition. 2020.

[5] Fu, Xueyang, et al. "A probabilistic method for image enhancement with simultaneous illumination and reflectance estimation." IEEE Transactions on Image Processing 24.12 (2015): 4965-4977.

[6] Guo, Xiaojie, Yu Li, and Haibin Ling. "LIME: Low-light image enhancement via illumination map estimation." IEEE Transactions on image processing 26.2 (2016): 982-993.

[7] Lv, Feifan, et al. "MBLLEN: Low-Light Image/Video Enhancement Using CNNs." BMVC. 2018.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---