# MMAR: 음성, 오디오, 음악 및 이들의 혼합에 대한 심층 추론을 위한 도전적 벤치마크
[**📖 arXiv**](https://arxiv.org/abs/2505.13032) | [**🎬 MMAR 데모 비디오**](https://www.youtube.com/watch?v=Dab13opIGqU) | [**🛠️ GitHub 코드**](https://github.com/ddlBoJack/MMAR) | [**🔊 MMAR 오디오 다운로드 (HuggingFace)**](https://huggingface.co/datasets/BoJack/MMAR)
                                          
<p align="center"><img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/logo.png" alt="MMAR Benchmark Logo" width="300"/></p>

## MMAR 개요
우리는 대규모 다학제 과제 전반에 걸쳐 오디오-언어 모델(Audio-Language Models, ALMs)의 심층 추론 능력을 평가하기 위해 설계된 새로운 벤치마크 MMAR을 소개합니다.  
MMAR은 실제 인터넷 동영상에서 수집하고 반복적인 오류 수정 및 품질 검사를 통해 고품질을 보장한 1,000개의 정밀하게 선별된 오디오-질문-답변 삼중항으로 구성되어 있습니다.  
벤치마크의 각 항목은 표면적 이해를 넘어선 다단계 심층 추론을 요구합니다. 게다가 일부 질문은 대학원 수준의 지각 및 도메인 특화 지식을 요구하여 벤치마크의 난이도와 깊이를 높입니다.  
예시는 다음과 같습니다:

![Example](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/example.png)

MMAR의 메타데이터는 [이 파일](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json)에서 확인할 수 있습니다. 이전 벤치마크와 달리 MMAR은 음성, 오디오, 음악과 같은 전통적 모달리티뿐만 아니라 야생 환경에서 수집된 이들의 혼합까지 포함합니다. 이러한 모달리티별 데이터 분포는 왼쪽 그림에 나타나 있습니다. 또한 각 질문은 지정된 카테고리 및 하위 카테고리로 주석 처리되어 있으며, 이는 오른쪽 그림에 표시되어 있습니다.

각 질문에 대해 원본 동영상의 URL과 해당 타임스탬프, 그리고 클립 내 발화된 언어(있는 경우)를 제공합니다. 추론 모델의 학습 중 잠재적 데이터 누출을 방지하기 위해 추론 단서 및 사고 과정 주석은 적절한 시기에 공개할 예정입니다.

<p float="left">
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/modality_pie.png" width="49%" />
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/category_sunburst.png" width="49%" />
</p>

## 벤치마크 결과
우리는 MMAR에서 다음 다섯 가지 모델 카테고리를 기준으로 벤치마킹을 수행했습니다:  
1. 대형 오디오 언어 모델(LALMs)  
2. 대형 오디오 추론 모델(LARMs)  
3. 옴니 언어 모델(OLMs)  
4. 오디오 캡션을 입력으로 하는 대형 언어 모델(LLMs)  
5. 오디오 캡션을 입력으로 하는 대형 추론 모델(LRMs)  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/benchmark.png)

## 데이터셋 생성
MMAR 벤치마크는 종합적인 파이프라인으로 구축되었습니다. 과정은 다음과 같습니다:  
1. 도전적 질문 구상  
2. 인간-LLM 협업을 통한 분류 체계 구축  
3. 휴리스틱 기반 데이터 수집 및 주석  
4. 오디오 데이터 크롤링 및 다중 슬롯 콘텐츠 확장  
5. 반복적 교정 및 품질 검사 수행으로 높은 데이터 충실도 보장  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/pipeline.png)

## 모델 테스트 하기!

기존 평가 파이프라인에 원활히 통합하기 위해, 우리는 [MMAU](https://github.com/Sakshi113/MMAU)에서 수정된 평가 방법론을 채택했으며, [evaluation.py](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/code/evaluation.py)에 구현되어 있습니다. 평가 스크립트에 입력되는 데이터는 [MMAR-meta.json](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json)과 동일해야 하며, 각 질문에 대한 모델 예측을 저장하는 `model_prediction`이라는 추가 키를 포함해야 합니다.  
  
스크립트를 실행하려면:

```bash
python evaluation.py  --input INPUT_JSON_PATH
```
## 인정
우리의 평가 코드는 [MMAU](https://github.com/Sakshi113/MMAU)의 공식 구현을 수정한 것임을 감사히 인정합니다. 

## 인용문헌

```
@article{ma2025mmar,
  title={MMAR: A Challenging Benchmark for Deep Reasoning in Speech, Audio, Music, and Their Mix},
  author={Ma, Ziyang and Ma, Yinghao and Zhu, Yanqiao and Yang, Chen and Chao, Yi-Wen and Xu, Ruiyang and others},
  journal={arXiv preprint arXiv:2505.13032},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---