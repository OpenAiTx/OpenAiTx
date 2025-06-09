# StyTr^2 : 이미지 스타일 전환을 위한 트랜스포머 (CVPR2022)
*저자: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

이 논문은 트랜스포머 모델을 기반으로 한 편향 없는 이미지 스타일 전환을 달성하기 위해 제안되었습니다. 최첨단 방법들과 비교하여 스타일화 효과를 더욱 향상시킬 수 있습니다.  
이 저장소는 [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576)의 공식 구현입니다.

## 결과 발표
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
최첨단 알고리즘들과 비교하여, 우리의 방법은 컨텐츠 누출을 효과적으로 방지하고 더 나은 특징 표현 능력을 가지고 있습니다.  <br>

## 프레임워크
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p>
StyTr^2 프레임워크의 전체 파이프라인입니다. 우리는 컨텐츠 이미지와 스타일 이미지를 패치로 분할한 뒤, 선형 투영을 이용해 이미지 시퀀스를 얻습니다. 이후 CAPE가 추가된 컨텐츠 시퀀스는 컨텐츠 트랜스포머 인코더에 입력되고, 스타일 시퀀스는 스타일 트랜스포머 인코더에 입력됩니다. 두 트랜스포머 인코더 다음에는 다계층 트랜스포머 디코더가 적용되어 스타일 시퀀스에 따라 컨텐츠 시퀀스를 스타일화합니다. 마지막으로, 점진적 업샘플링 디코더를 사용해 고해상도 스타일화 이미지를 얻습니다.

## 실험
### 요구 사항
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### 테스트
사전 학습된 모델: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br>
이 파일들을 다운로드하여 ./experiments/ 폴더에 넣어주세요. <br>
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### 학습
스타일 데이터셋은 [WIKIART](https://www.wikiart.org/)에서 수집한 WikiArt입니다. <br>
컨텐츠 데이터셋은 COCO2014입니다. <br>
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### 참고
본 연구가 연구에 도움이 되었다면, 아래의 BibTeX 인용문을 사용하여 논문을 인용해 주세요. 감사합니다 ^ . ^. 논문 링크 [pdf](https://arxiv.org/abs/2105.14576)<br>
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---