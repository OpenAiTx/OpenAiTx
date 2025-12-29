# Semantic-Guided-Low-Light-Image-Enhancement
이것은 저희 논문 "**Semantic-Guided Zero-Shot Learning for Low-Light Image/Video Enhancement**"의 공식 Pytorch 구현입니다.

# Updates
- 2021.11.27: 모델 아키텍처 그림이 업로드되었습니다.
- 2021.11.10: 이 연구가 채택되어 [WACV 2022](https://wacv2022.thecvf.com/home)에서 발표될 예정입니다.
- 2021.10.8: mPA 및 mIOU 점수를 계산하는 쉬운 방법이 이 [저장소](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)에 있습니다.
- 2021.10.6: GIF 형식의 향상된 저조도 비디오 샘플이 공개되었습니다.
- 2021.10.5: 저조도 비디오 샘플과 향상된 결과는 다음에서 확인할 수 있습니다: [[Low-Light](https://www.youtube.com/watch?v=4Avy_xsczdU)]  [[Enhanced](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5: 저의 새로운 [저장소](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning)에는 저조도 향상 방법 모음이 포함되어 있습니다. 도움이 되시길 바랍니다.
- 2021.10.4: arxiv 링크는 http://arxiv.org/abs/2110.00970 에서 확인할 수 있습니다.


# Abstract
Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.
# 모델 아키텍처
아래 링크를 클릭하여 모델 아키텍처를 pdf 형식으로 확인하세요.

![Model Architecture](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)

# 샘플 결과
## 1. 저조도 비디오 프레임
왼쪽에서 오른쪽, 위에서 아래 순서대로: Dark, Retinex [1], KinD [2], EnlightenGAN [3], Zero-DCE [4], 당사 방법.

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />
</p>

## 2. 저조도 이미지 (실제 환경)
왼쪽에서 오른쪽, 위에서 아래 순서대로: Dark, PIE [5], LIME [6], Retinex [1], MBLLEN [7], KinD [2], Zero-DCE [4], 당사 방법

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

# 시작하기

## 1. 요구사항
* CUDA 10.0
* Python 3.6+

* Pytorch 1.0+
* torchvision 0.4+
* opencv-python
* numpy
* pillow
* scikit-image

## 2. 데이터셋 준비
### 테스트 데이터셋
- 공식 테스트 이미지는 [BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg)에서 비밀번호 `8itq`로 다운로드했습니다. 
- 압축을 푼 파일을 `data/test_data/`로 이동합니다. 
- 이 폴더에 커스텀 데이터셋이나 자신의 저조도 이미지를 넣어 테스트할 수도 있습니다. 예: `data/test_data/yourDataset/`

### 학습 데이터셋
- 공식 학습 이미지는 [GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view)에서 다운로드했습니다. 
- 압축을 푼 파일을 `data/train_data/`로 이동합니다. 

참고: BaiduYun 계정이 없으면 [Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)를 통해 학습 및 테스트 데이터셋을 모두 다운로드할 수 있습니다.

준비가 완료되면 데이터 폴더는 다음과 같이 구성되어야 합니다:
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

## 3. 처음부터 학습하기
모델을 학습하려면:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```

예시 (처음부터 학습):
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. 학습 재개

체크포인트에서 학습을 재개하려면:
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```
예시 (Epoch99.pth에서 재개):

```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```
 
## 5. 테스트
**참고: 모델 추론 오류를 방지하려면 `data` 폴더 내의 모든 readme.txt 파일을 삭제하십시오.**

모델을 테스트하려면:

```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
예시:

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. 비디오 테스트
비디오(MP4 형식)에서 모델 테스트를 위해 터미널에서 실행하세요:
```
bash test_video.sh
```
`demo/make_video.py`에는 비디오 테스트를 위한 다섯 가지 하이퍼파라미터가 있습니다. 다음 설명을 참고하세요.  
- `video_path`: 저조도 비디오 경로  
- `image_lowlight_folder`: 저조도 이미지 경로  
- `image_folder`: 향상된 이미지 경로  
- `save_path`: 향상된 비디오 저장 경로  
- `choice`: 비디오를 이미지로 변환할지, 이미지를 비디오로 변환할지 선택  

# Hyperparameters  
| 이름                 | 타입  | 기본값             |  
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
- [x] 중요 하이퍼파라미터 목록 작성  
- [x] 모델 입력 크기 문제 해결  
- [x] 사전 학습 가중치 업로드  
- [x] option.py에 훈련 및 테스트 argparse 재작성  
- [x] 훈련을 클래스로 재작성  
- [x] 테스트를 클래스로 재작성  
- [x] 테스트 데이터셋 업로드



- [x] Arxiv 링크 업로드
- [x] 비디오 테스트
- [x] BibTeX 업로드
- [x] Readme 파일 수정
- [x] 모델 아키텍처 업로드
- [ ] 온라인 데모 제공
# 기타
질문이 있으시면 zhengsh@kean.edu 로 연락해 주세요. 이 저장소는 [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE)를 기반으로 많이 작성되었습니다. 코드 공유에 감사드립니다!

# 인용
이 저장소가 도움이 되었다면 다음 논문을 인용해 주세요.
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```


# 참고문헌
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