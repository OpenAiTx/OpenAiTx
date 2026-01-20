![brlp](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/readme-brlp-v2.png)

<p align="center">
  <a href='https://www.sciencedirect.com/science/article/pii/S1361841525002816'>
    <img src='https://img.shields.io/badge/Journal-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://papers.miccai.org/miccai-2024/paper/0511_paper.pdf'>
    <img src='https://img.shields.io/badge/MICCAI-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://youtu.be/6YKz2MNM4jg?si=nkG21K4lIgLrH-pK'>
    <img src='https://img.shields.io/badge/Video-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white&color=FF3737' alt='Video'>
  </a>
</p>

<h4 align="center">잠재 확산 및 사전 지식을 통한 시공간 질병 진행 모델 향상</h4>

<h4 align="center"><a href="https://lemuelpuglisi.github.io/">레뮤엘 푸글리시</a>, <a href="https://profiles.ucl.ac.uk/3589">다니엘 C. 알렉산더</a>, <a href="https://daniravi.wixsite.com/researchblog">다니엘 라비</a></h4>

https://github.com/user-attachments/assets/28ad3693-5e3e-4f6e-9bbc-485424fbbee2

<p align="center">
  <a href="#installation">설치</a> •
  <a href="#training">학습</a> •
  <a href="#inference">CLI 애플리케이션</a> •
  <a href="#citing">인용</a>
</p>


**뉴스**
* 🎉 BrLP가 MICCAI 2025 미디어 최우수 논문상 준우승을 수상했습니다!
* 🎉 저희 [확장 논문](https://arxiv.org/pdf/2502.08560)이 Medical Image Analysis (*IF=11.8*)에 게재 승인되었습니다.
* 🎉 Vanderbilt 대학의 [새 논문](https://www.spiedigitallibrary.org/conference-proceedings-of-spie/13406/1340621/A-technical-assessment-of-latent-diffusion-for-Alzheimers-disease-progression/10.1117/12.3047135.short)이 [BLSA](https://www.blsa.nih.gov/) 데이터셋에서 저희 결과를 재현했습니다!
* 🆕 BrLP CLI 사용에 대한 [간단 가이드](https://lemuelpuglisi.github.io/blog/2024/brlp/)가 공개되었습니다!
* 🎉 BrLP가 MICCAI 최우수 논문상 후보에 올랐으며 최종 후보에 선정되었습니다! (상위 <1%)
* 🎉 BrLP가 MICCAI 2024 [구두 발표](https://conferences.miccai.org/2024/en/)로 조기 선정되었습니다! (상위 4%)



## 목차
- [설치](#installation)
- [데이터 준비](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)
- [학습](#training)
- [사전 학습된 모델](#pretrained-models)
- [감사의 글](#acknowledgements)
- [인용 방법](#citing)

## 설치

저장소를 다운로드하고, 프로젝트 폴더로 `cd` 한 후 `brlp` 패키지를 설치하세요:

```console
pip install -e .
```
별도의 환경 사용을 권장합니다 ([Anaconda](https://www.anaconda.com/) 참조). 코드는 Python 3.9로 테스트되었으나, 최신 버전에서도 작동할 것으로 예상합니다.

## 데이터 준비

[*데이터 준비 및 연구 재현성*](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md) 문서를 확인하세요. 이 파일은 데이터를 조직하고 학습 파이프라인 실행에 필요한 CSV 파일을 만드는 방법을 안내합니다.

## 학습
![](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/pipeline.png)

BrLP 학습은 이후 섹션에서 설명할 3가지 주요 단계로 구성됩니다. 모든 학습(보조 모델 제외)은 다음과 같이 `tensorboard`를 사용해 모니터링할 수 있습니다:



```console
tensorboard --logdir runs
```



### Train the autoencoder

Follow the commands below to train the autoencoder.

```console
# Create an output and a cache directory
mkdir ae_output ae_cache

# Run the training script
python scripts/training/train_autoencoder.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   ./ae_cache \
  --output_dir  ./ae_output
```

그런 다음 MRI 데이터에서 잠재 변수를 추출하세요:

```console
python scripts/prepare/extract_latents.py \
  --dataset_csv /path/to/A.csv \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

`XXX`를 원하는 오토인코더 체크포인트로 교체하세요.

### UNet 훈련하기

아래 명령어를 따라 diffusion UNet을 훈련하세요. `XXX`를 원하는 오토인코더 체크포인트로 교체하세요.


```console
# Create an output and a cache directory:
mkdir unet_output unet_cache

# Run the training script
python scripts/training/train_diffusion_unet.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

### ControlNet 훈련하기

아래 명령어를 따라 ControlNet을 훈련하세요. `XXX`를 원하는 오토인코더 및 UNet 체크포인트로 교체하세요.

```console
# Create an output and a cache directory:
mkdir cnet_output cnet_cache

# Run the training script
python scripts/training/train_controlnet.py \
  --dataset_csv /path/to/B.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth \
  --diff_ckpt   unet_output/unet-ep-XXX.pth
```

### 보조 모델

아래 명령어를 따라 DCM 보조 모델을 학습하세요.

```console
# Create an output directory
mkdir aux_output

# Run the training script
python scripts/training/train_aux.py \
  --dataset_csv /path/to/A.csv \
  --output_path aux_output
```
우리는 시간에 따른 부피 변화를 예측할 수 있는 모든 질병 진행 모델이 BrLP의 보조 모델로도 유효하다는 점을 강조합니다.

## 추론

우리 패키지에는 BrLP를 추론에 사용할 수 있는 `brlp` 명령어가 포함되어 있습니다. 확인:

```console
brlp --help
```
`--input` 매개변수는 피험자에 대한 모든 사용 가능한 데이터를 나열한 CSV 파일이 필요합니다. 예시는 `examples/input.example.csv`를 참조하세요. 입력 스캔을 분할하지 않은 경우, `brlp`는 [SynthSeg](https://surfer.nmr.mgh.harvard.edu/fswiki/SynthSeg)를 사용하여 이 작업을 수행할 수 있지만, FreeSurfer 버전 7.4 이상이 설치되어 있어야 합니다. `--confs` 매개변수는 모델 경로 및 LAS $m$과 같은 기타 추론 매개변수를 지정합니다. 예시는 `examples/confs.example.yaml`을 참조하세요. 

프로그램 실행 예시는 다음과 같습니다:

![inference-preview](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/inference.gif)


## 사전 학습된 모델

BrLP용 사전 학습된 모델을 다운로드하세요:

| 모델                   | 가중치 URL                                                  |
| ---------------------- | ------------------------------------------------------------ |
| 오토인코더             | [링크](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EUxUFIQtkQ1EvBqojYA5BAYByIyHbttca5Mx1cU4bC6q3A?e=sCXSUA) |
| 확산 모델 UNet         | [링크](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EQT7KJTtfmRAguf8_utWeJIBUJPsRRgPZlt94s2vNbwVFw?e=IjHnx7) |
| ControlNet             | [링크](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EYtVvH47dFJJnH8gtwSMA-MB8c3pm4_Z9g5F_IG1OKxW9Q?e=CzvGT4) |
| 보조 모델 (DCM)        | [링크](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EXJDQqLNCwBFkt2J6zg1kpwBS_1hAZoBfGy5AfcGOBZvHQ?e=Z05kOG) |

## 감사의 글

연구 과정을 가속화하는 데 기여한 오픈 소스 라이브러리 유지 관리자들에게 감사드리며, 특히 [MONAI](https://monai.io/)와 그 [GenerativeModels](https://github.com/Project-MONAI/GenerativeModels/tree/main) 확장에 특별한 감사를 표합니다.

## 인용 방법

Medical Image Analysis:


```bib
@article{puglisi2025brain,
  title={Brain latent progression: Individual-based spatiotemporal disease progression on 3D brain MRIs via latent diffusion},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  journal={Medical Image Analysis},
  year={2025}
}
```
MICCAI 2024 논문집:


```bib
@inproceedings{puglisi2024enhancing,
  title={Enhancing spatiotemporal disease progression models via latent diffusion and prior knowledge},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  booktitle={International Conference on Medical Image Computing and Computer-Assisted Intervention},
  pages={173--183},
  year={2024},
  organization={Springer}
}
```


SPIE 의료 영상 2025 논문집: 
```bib
@inproceedings{mcmaster2025technical,
  title={A technical assessment of latent diffusion for Alzheimer's disease progression},
  author={McMaster, Elyssa and Puglisi, Lemuel and Gao, Chenyu and Krishnan, Aravind R and Saunders, Adam M and Ravi, Daniele and Beason-Held, Lori L and Resnick, Susan M and Zuo, Lianrui and Moyer, Daniel and others},
  booktitle={Medical Imaging 2025: Image Processing},
  volume={13406},
  pages={505--513},
  year={2025},
  organization={SPIE}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---