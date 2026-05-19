# HiFuse
![](https://img.shields.io/github/license/huoxiangzuo/HiFuse)  
이 저장소는 [HiFuse: Hierarchical Multi-Scale Feature Fusion Network for Medical Image Classification](https://www.sciencedirect.com/science/article/pii/S1746809423009679)의 공식 구현체입니다.    
저자: Xiangzuo Huo, Gang Sun, Shengwei Tian, Yan Wang, Long Yu, Jun Long, Wendong Zhang, Aolun Li.  
코드를 즐기시고 더 멋진 작업을 만드는데 편리함을 느껴보세요!

## 개요
<img width="1395" alt="figure1" src="https://user-images.githubusercontent.com/57312968/191570017-34f30c13-9d8e-4776-a118-de968aebdb19.png" width="80%">

## HFF 블록
<img width="1424" alt="figure2s" src="https://user-images.githubusercontent.com/57312968/191570496-c62e04dc-8baf-4b01-a6ba-03c24c5a744d.png" width="70%">

## HiFuse 시각적 검사
<img src="https://user-images.githubusercontent.com/57312968/191570242-4425944d-4017-45c6-a3f7-f977376766a2.png" width="75%">

## 실행
0. 요구 사항:
* python3
* pytorch 1.10
* torchvision 0.11.1
1. 훈련:
* 필요한 이미지들을 준비하고 카테고리별로 저장, 훈련 이미지 폴더와 검증 이미지 폴더를 각각 설정
* `python train.py` 실행
2. 훈련 재개:
* `python train.py`에서 `parser.add_argument('--RESUME', type=bool, default=True)` 수정
* `python train.py` 실행
3. 테스트:
* `python test.py` 실행

## TensorBoard
훈련 진행 상황을 보려면 `tensorboard --logdir runs --port 6006` 실행

## 참고
이 저장소의 일부 코드는 다음에서 차용하였습니다:  
* [Swin Transformer](https://github.com/microsoft/Swin-Transformer)  
* [ConvNeXt](https://github.com/facebookresearch/ConvNeXt)  
* [WZMIAOMIAO](https://github.com/WZMIAOMIAO/deep-learning-for-image-processing)

## 인용

본 논문/코드가 도움이 되었다면, 인용해 주시기 바랍니다:

```bibtex
@article{huo2024hifuse,
  title={HiFuse: Hierarchical multi-scale feature fusion network for medical image classification},
  author={Huo, Xiangzuo and Sun, Gang and Tian, Shengwei and Wang, Yan and Yu, Long and Long, Jun and Zhang, Wendong and Li, Aolun},
  journal={Biomedical Signal Processing and Control},
  volume={87},
  pages={105534},
  year={2024},
  publisher={Elsevier}
}
@article{huo2025mm,
  title={MM-HiFuse: multi-modal multi-task hierarchical feature fusion for esophagus cancer staging and differentiation classification},
  author={Huo, Xiangzuo and Tian, Shengwei and Yu, Long and Zhang, Wendong and Li, Aolun and Yang, Qimeng and Song, Jinmiao},
  journal={Complex \& Intelligent Systems},
  volume={11},
  number={1},
  pages={1--12},
  year={2025},
  publisher={Springer}
}
```

## Star History

[![Star History Chart](https://api.star-history.com/image?repos=huoxiangzuo/HiFuse&type=date&legend=top-left)](https://www.star-history.com/?repos=huoxiangzuo%2FHiFuse&type=date&legend=top-left)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---