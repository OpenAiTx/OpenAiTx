# MoE-Adapters4CL
논문 "[**Mixture-of-Experts 어댑터를 통한 비전-언어 모델의 연속 학습 향상**](https://arxiv.org/abs/2403.11549)" CVPR2024의 코드입니다.

## 목차
  - [초록](#Abstract)
  - [접근법](#Approach)
  - [설치](#Install)
  - [데이터 준비](#Data-preparation)
  - [시작하기](#getting-started)
    - [모델 체크포인트](#Model-ckpt)
    - [MTCL](#MTCL)
      - [테스트](#Test)
      - [학습](#Train)
    - [CIL](#CIL)
      - [학습](#Train)
  - [인용](#Citation)
  - [감사의 글](#Acknowledgement)

## 초록
Continual learning can empower vision-language models to continuously acquire new knowledge, without the need for access to the entire historical dataset. However, mitigating the performance degradation in large-scale models is non-trivial due to (i) parameter shifts throughout lifelong learning and (ii) significant computational burdens associated with full-model tuning. In this work, we present a parameter-efficient continual learning framework to alleviate long-term forgetting in incremental learning with vision-language models. Our approach involves the dynamic expansion of a pre-trained CLIP model, through the integration of Mixture-of-Experts (MoE) adapters in response to new tasks. To preserve the zero-shot recognition capability of vision-language models, we further introduce a Distribution Discriminative Auto-Selector (DDAS) that automatically routes in-distribution and out-of-distribution inputs to the MoE Adapter and the original CLIP, respectively. Through extensive experiments across various settings, our proposed method consistently outperforms previous state-of-the-art approaches while concurrently reducing parameter training burdens by 60%. 
## 접근법
___
![예시 이미지](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/fig/framework.png)


## 설치
```bash
conda create -n MoE_Adapters4CL python=3.9
conda activate MoE_Adapters4CL
conda install pytorch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 pytorch-cuda=11.8 -c pytorch -c nvidia
cd cil
pip install -r requirements.txt
```
## 데이터 준비
대상 데이터셋: Aircraft, Caltech101, CIFAR10, CIFAR100, DTD, EuroSAT, Flowers, Food, MNIST, OxfordPet, StanfordCars, SUN397, TinyImagenet.

Caltech101에 문제가 있을 경우 [issue#6](https://github.com/JiazuoYu/MoE-Adapters4CL/issues/6)를 참고할 수 있습니다.

자세한 내용은 [ZSCL](https://github.com/Thunderbeee/ZSCL)의 [datasets.md](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/mtil%2Fdatasets.md)를 참조하세요. 멋진 작업을 해주신 분들께 큰 감사를 드립니다!
## 모델 체크포인트
|                  | 모델                                                                | 링크 |
|------------------|----------------------------------------------------------------------|---------------------------------------------------------------------- |
| full_shot_order1 | full_shot_order1_1000iters.pth                  | [Baidu Disk](https://pan.baidu.com/s/1brWYIMrv34fhdc4kC9B0_g?pwd=p3zp) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)      |
| few_shot_order1  | few_shot_order1_1000iters.pth | [Baidu Disk](https://pan.baidu.com/s/1Z7q3tTLdRFN3zmtkj3_i4g?pwd=4edw) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)       |
## MTCL
### 테스트 단계
예시:
1. 체크포인트를 MoE-Adapters4CL/ckpt 폴더로 이동
2. ```cd MoE-Adapters4CL/mtil```
3. 스크립트 실행 ```bash srcipts/test/Full_Shot_order1.sh ```

### 학습 단계
예시:
1. 체크포인트를 MoE-Adapters4CL/ckpt 폴더로 이동
2. ```cd MoE-Adapters4CL/mtil```
3. 스크립트 실행 ```bash srcipts/train/train_full_shot_router11_experts22_1000iters.sh```

## 클래스 증분 학습

### 학습 단계
예시:
1. ```cd cil```
2. ```bash run_cifar100-2-2.sh ```

## 인용문헌


```
@inproceedings{yu2024boosting,
  title={Boosting continual learning of vision-language models via mixture-of-experts adapters},
  author={Yu, Jiazuo and Zhuge, Yunzhi and Zhang, Lu and Hu, Ping and Wang, Dong and Lu, Huchuan and He, You},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  pages={23219--23230},
  year={2024}
}
```
## 감사의 글
저희 저장소는 [wise-ft](https://github.com/mlfoundations/wise-ft), [Continual-CLIP](https://github.com/vgthengane/Continual-CLIP/tree/master) 및 [ZSCL](https://github.com/Thunderbeee/ZSCL)을 기반으로 구축되었습니다. 코드를 공유해 주신 저자분들께 감사드립니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---