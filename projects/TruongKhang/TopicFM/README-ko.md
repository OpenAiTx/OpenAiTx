# TopicFM+: 주제 기반 특징 매칭의 정확도 및 효율성 향상
    
이 코드는 [TopicFM+](https://arxiv.org/abs/2307.00485)를 구현한 것으로, 이는 [TopicFM](https://arxiv.org/abs/2207.00328)의 확장판입니다. 이전 버전 TopicFM의 구현은 `aaai23_ver` 브랜치를 참고하십시오.


## 요구 사항

본 논문의 모든 실험은 NVIDIA 드라이버 버전 430.64 이상과 CUDA 10.1이 설치된 Ubuntu 환경에서 수행되었습니다.

먼저, 다음과 같이 anaconda를 사용하여 가상 환경을 생성합니다,

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # 누락된 패키지는 pip를 사용하여 설치

## 데이터 준비

제안된 방법은 MegaDepth 데이터셋으로 학습하며 MegaDepth 테스트, ScanNet, HPatches, Aachen Day and Night (v1.1), 그리고 InLoc 데이터셋에서 평가됩니다.
이들 데이터셋은 모두 대용량이므로 본 코드에는 포함되어 있지 않습니다.
다음 설명은 데이터셋 다운로드에 도움이 됩니다.

### MegaDepth

이 데이터셋은 학습과 평가 모두에 사용됩니다 (Li and Snavely 2018).
본 코드에서 이 데이터셋을 사용하려면 [LoFTR 안내서](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)를 따라 주십시오.

### ScanNet
평가를 위해 ScanNet (Dai et al. 2017)의 1500개 이미지 쌍만 사용합니다.
LoFTR에서 제공하는 ScanNet [테스트 데이터](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf)를 다운로드하고 준비하십시오.
[LoFTR 안내서](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md)에서 자세한 내용을 확인할 수 있습니다.

## 학습

모델 학습 시 가능한 한 GPU 카드를 많이 사용하는 것을 권장하며, 각 GPU는 최소 12GB 이상이어야 합니다.
본 설정에서는 12GB GPU 4개를 사용하여 학습합니다.
하드웨어 환경 설정은 `scripts/reproduce_train/outdoor.sh`에서 진행하십시오.
그런 다음 다음 명령어를 실행하여 학습을 시작합니다.

    bash scripts/reproduce_train/outdoor.sh <학습 설정 파일 경로>
    # 예를 들어,
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

논문에 사용된 사전 학습된 모델을 제공했습니다 ([TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing), [TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing))

## 평가

### MegaDepth (상대 자세 추정)

    bash scripts/reproduce_test/outdoor.sh <configs 폴더 내 설정 파일 경로> <사전 학습된 모델 경로>
    # 예를 들어, TopicFM-fast 평가 시
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet (상대 자세 추정)

    bash scripts/reproduce_test/indoor.sh <configs 폴더 내 설정 파일 경로> <사전 학습된 모델 경로>

### HPatches, Aachen v1.1, InLoc

이 데이터셋들에 대한 평가는 Patch2Pix에서 제공하는 image-matching-toolbox에 코드를 통합하여 수행합니다.
업데이트된 코드와 상세 평가는 [여기](https://github.com/TruongKhang/image-matching-toolbox)에서 확인할 수 있습니다.

### Image Matching Challenge 2023

우리의 방법인 TopicFM+는 Kaggle IMC2023에서 높은 순위(은메달)를 달성했습니다 [여기](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public).

### 효율성 비교

논문에서 보고된 효율성 평가는 ScanNet 평가 데이터셋의 1500개 이미지 쌍의 실행 시간을 평균하여 측정했습니다.
이미지 크기는 `configs/data/scannet_test_topicfmfast.py`에서 변경 가능합니다.

LoFTR, MatchFormer, QuadTree, AspanFormer의 연산 비용(GFLOPs)과 실행 시간(ms)을 계산했습니다. 다만, 각 방법별 코드에 약간의 수정이 필요했습니다. 해당 방법들의 평가가 필요하면 연락 바랍니다.

여기서는 우리 방법인 TopicFM-fast의 실행 시간 측정을 제공합니다.

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

(640, 480) 해상도에서 측정한 실행 시간 보고서 (NVIDIA TITAN V 32GB 메모리 기준)

|   모델       |    640 x 480   |    1200 x 896    |
|:--------------|:--------------:|:----------------:|
| TopicFM-fast  |     56 ms      |      346 ms      |
| TopicFM+      |     90 ms      |      388 ms      |


## 인용
이 코드를 유용하게 사용하셨다면, 다음 논문들을 인용해 주세요:

    @article{giang2024topicfm+,
      title={Topicfm+: Boosting accuracy and efficiency of topic-assisted feature matching},
      author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
      journal={IEEE Transactions on Image Processing},
      year={2024},
      publisher={IEEE}
    }

또는

    @inproceedings{giang2023topicfm,
        title={TopicFM: Robust and interpretable topic-assisted feature matching},
        author={Giang, Khang Truong and Song, Soohwan and Jo, Sungho},
        booktitle={Proceedings of the AAAI Conference on Artificial Intelligence},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## 감사의 글
이 코드는 [LoFTR](https://github.com/zju3dv/LoFTR)을 기반으로 제작되었습니다. 유용한 소스 코드를 제공해 주신 저자분들께 감사드립니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---