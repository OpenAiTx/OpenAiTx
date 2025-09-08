# RGB로부터 로봇 그립 감지 및 의미론적 분할을 위한 종단 간 학습 가능한 심층 신경망

<p align="center">
<img src="https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/Network.png" width="100%"/>
<br>
<a href="https://arxiv.org/abs/2107.05287">arXiv</a>
</p>

이 저장소는 ICRA21 논문 "RGB로부터 로봇 그립 감지 및 의미론적 분할을 위한 종단 간 학습 가능한 심층 신경망"의 코드를 포함합니다.  
우리의 제안 방법과 OCID_grasp 데이터셋을 결합한 학습 및 테스트 코드를 포함하고 있습니다.  

만약 연구에 우리 방법이나 데이터셋 확장을 사용한다면, 다음을 인용해 주세요:

```bibtex
@InProceedings{ainetter2021end,
  title={End-to-end Trainable Deep Neural Network for Robotic Grasp Detection and Semantic Segmentation from RGB},
  author={Ainetter, Stefan and Fraundorfer, Friedrich},
  booktitle={IEEE International Conference on Robotics and Automation (ICRA)},
  pages={13452--13458}
  year={2021}
}
```
## 요구 사항 및 설정

주요 시스템 요구 사항:
* CUDA 10.1
* GCC 7 또는 8이 설치된 Linux
* PyTorch v1.1.0

**중요 참고**: 이 요구 사항들이 반드시 엄격한 것은 아닙니다. 예를 들어, 더 오래된 CUDA 버전이나 Windows 환경에서 컴파일하는 것도 가능할 수 있습니다. 다만, 저희는 위 환경에서만 코드를 테스트했으며 다른 설정에 대한 지원은 제공하지 않습니다.

PyTorch 설치는 https://github.com/pytorch/pytorch#installation 를 참고하세요.

pip를 사용하여 모든 기타 의존성을 설치하려면:


```bash
pip install -r requirements.txt
```

### 설정

우리 코드는 두 가지 주요 구성 요소로 나뉩니다: 다양한 네트워크 모듈, 알고리즘 및 유틸리티 구현을 포함하는 라이브러리와 네트워크를 학습/테스트하는 스크립트 세트입니다.

`grasp_det_seg`라는 라이브러리는 다음과 같이 설치할 수 있습니다:

```bash
git clone https://github.com/stefan-ainetter/grasp_det_seg_cnn.git
cd grasp_det_seg_cnn
python setup.py install
```
## 학습된 모델

제공된 모델 파일은 [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/) 라이선스 하에 제공됩니다.

OCID_grasp 데이터셋에 대한 학습된 모델은 [여기](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_pretrained)에서 다운로드할 수 있습니다.  
다운로드한 가중치를 `ckpt_files_OCID/pretrained` 폴더에 복사하세요.

OCID_grasp에서 네트워크를 재학습하려면 ImageNet에서 사전 학습된 가중치를  
[여기](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/ImageNet_weights)에서 다운로드하고  
`weights_pretrained` 폴더에 복사해야 합니다.

### 학습

학습은 세 가지 주요 단계로 구성됩니다: 데이터셋 준비, 설정 파일 작성, 그리고 학습 스크립트 실행.

데이터셋을 준비하려면:  
1) OCID_grasp 데이터셋을 [여기](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)에서 다운로드하세요.  
다운로드한 `OCID_grasp.zip` 파일을 `DATA` 폴더에 압축 해제합니다.  
2) 설정 파일은 `ini` 형식의 간단한 텍스트 파일입니다.  
각 설정 파라미터의 기본값과 그 기능에 대한 간단한 설명은  
[grasp_det_seg/config/defaults](grasp_det_seg/config/defaults)에서 확인할 수 있습니다.  
**참고**: 이 값들은 각 파라미터에 대해 "합리적인" 값의 예시일 뿐이며, 본 논문의 결과를 재현하기 위한 값은 아닙니다.

3) 학습을 시작하려면:



```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 train_det_seg_OCID.py 
--log_dir=LOGDIR CONFIG DATA_DIR
```
학습 로그는 텍스트 및 Tensorboard 형식으로, 그리고 학습된 네트워크 파라미터는 `LOG_DIR` (예: `ckpt_files_OCID`)에 저장됩니다.  
파일 `CONFIG`는 네트워크 구성을 포함하며, 예: `grasp_det_seg/config/defaults/det_seg_OCID.ini`  
`DATA_DIR`는 이전에 다운로드한 OCID_grasp 분할 데이터를 가리킵니다, 예: `DATA/OCID_grasp/data_split`.

참고로, 현재로서는 우리의 코드는 PyTorch의 `torch.distributed.launch`  
유틸리티를 사용하여 "distributed" 모드로 반드시 실행되어야 합니다.

### 추론 실행

학습된 네트워크가 주어지면,  
[scripts/test_det_seg_OCID.py](https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/scripts/test_det_seg_OCID.py)를 사용하여  
어떤 이미지 세트에 대해서도 추론을 실행할 수 있습니다:
```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 test_det_seg_OCID.py 
--log_dir=LOG_DIR CONFIG MODEL_PARAMS DATA_DIR OUTPUT_DIR

```
예측 결과는 `OUTPUT_DIR`에 기록됩니다. 예: `output` 폴더. `MODEL_PARAMS`는 사전 학습된 가중치입니다. 예: `ckpt_files_OCID/pretrained/model_last.pth.tar`,  
`DATA_DIR`는 사용된 데이터셋 분할을 가리킵니다. 예: `DATA/OCID_grasp/data_split`.  

## OCID_grasp 데이터셋  
OCID_grasp 데이터셋은 [여기](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp)에서 다운로드할 수 있습니다.  
OCID_grasp는 OCID 데이터셋의 1763개의 선택된 RGB-D 이미지로 구성되며, 11.4k 이상의 분할된 객체 마스크와 75k 이상의 수작업으로 주석된  
그립 후보가 포함되어 있습니다. 또한 각 객체는 31개의 객체 클래스 중 하나로 분류됩니다.  
## 관련 연구  
OCID_grasp는 [OCID 데이터셋](https://www.acin.tuwien.ac.at/en/vision-for-robotics/software-tools/object-clutter-indoor-dataset/)의 데이터셋 확장입니다.  
연구에 OCID_grasp를 사용하기로 결정했다면 OCID 논문도 함께 인용해 주세요:
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
우리 프레임워크는 [Seamless Scene Segmentation](https://github.com/mapillary/seamseg)의 아키텍처를 기반으로 합니다:
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
## 최신 연구 소개
### 저희 논문 'Depth-aware Object Segmentation and Grasp Detection for Robotic Picking Tasks'가 BMVC21에 채택되었습니다
저희 최신 연구에서는 로봇 픽킹 작업을 위한 깊이 인식 객체 분할과 그립 감지를 공동으로 수행하는 방법을 구현하였으며,
이는 BMVC21에서 발표되었습니다. 
자세한 내용은 [여기](https://arxiv.org/pdf/2111.11114)에서 확인할 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---