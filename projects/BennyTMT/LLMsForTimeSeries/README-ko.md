# 시계열 예측에 언어 모델이 실제로 유용한가?

**(NeurIPS 2024 Spotlight)** 🌟 [논문 링크](https://arxiv.org/pdf/2406.16964)

본 연구에서는 최근 시계열 예측(TSF) 분야에서 LLM의 인기가 높음에도 불구하고, 성능 향상에 실질적인 도움이 되지 않는다는 점을 보여주었습니다. 간단한 기준선인 "PAttn"을 제안하였으며, 이는 대부분의 LLM 기반 TSF 모델보다 더 우수한 성능을 보였습니다.

저자: [Mingtian Tan](https://x.com/MTTan1203),[Mike A. Merrill](https://mikemerrill.io/),[Vinayak Gupta](https://gvinayak.github.io/),[Tim Althoff](https://homes.cs.washington.edu/~althoff/),[Thomas Hartvigsen](https://www.tomhartvigsen.com/)

### 자기회귀 LLM은 컨텍스트를 활용하여 미래 시계열을 추론(예측)하는 데 큰 잠재력을 지니고 있습니다. 그러나 본 논문에서 언급된 시계열 예측 모델들은 그렇지 않습니다.

텍스트를 통해 시계열을 추론(예측)하는 방법은 이 [시계열 추론(예측) 작업](https://github.com/behavioral-data/TSandLanguage/tree/main/text_aid_forecast)을 참고하시기 바랍니다.

## 개요 💁🏼
최근 시계열 분석 연구는 사전 학습된 대형 언어 모델(LLM)을 **예측(TSF)**, 분류, 이상 탐지에 적응시키는 데 점점 더 초점을 맞추고 있습니다. 이러한 연구들은 텍스트 내 순차적 의존성을 설계한 언어 모델이 시계열 데이터에 일반화될 수 있음을 시사합니다. 이 아이디어는 기계 학습에서 언어 모델의 인기와 일치하지만, 언어 모델링과 TSF 사이의 직접적인 연관성은 여전히 불분명합니다. **전통적인 TSF 작업에서 언어 모델은 얼마나 유용한가?**

세 가지 최신 **LLM 기반 TSF** 방법에 대한 일련의 제거 연구(ablation study)를 통해, **LLM 구성 요소를 제거하거나 단순한 어텐션 계층으로 대체해도 결과가 나빠지지 않았으며, 오히려 개선된 경우도 많았습니다.** 또한, 패칭과 어텐션 구조가 최신 LLM 기반 예측기와 동등한 성능을 낼 수 있음을 보여주는 PAttn을 소개했습니다.

![Ablations/PAttn](https://raw.githubusercontent.com/BennyTMT/LLMsForTimeSeries/main/pic/ablations.png)

## 데이터셋 📖
[Google Drive](https://drive.google.com/file/d/1NF7VEefXCmXuWNbnNe858WvQAkJ_7wuP/view)에서 잘 전처리된 데이터셋을 다운로드한 후, ./datasets 폴더 아래에 배치하십시오.

## 설치 🔧
세 가지 인기 있는 LLM 기반 TSF 방법을 제거 연구에 포함시켰습니다. 해당 저장소인 [OneFitsAll](https://github.com/DAMO-DI-ML/NeurIPS2023-One-Fits-All), [Time-LLM](https://github.com/KimMeen/Time-LLM), [CALF](https://github.com/Hank0626/CALF)을 참고하여 각각 환경을 설정하시기 바랍니다. **''PAttn''** 방법은 위 저장소 중 어느 환경에서나 호환됩니다.

## PAttn 🤔
**PAttn**과 [PatchTST](https://github.com/yuqinie98/PatchTST)의 주요 차이점은, 본 연구에서 점차적으로 Transformer 모듈 중 필수적이지 않을 수 있는 부분과 위치 임베딩을 제거했다는 점입니다. 자세한 설명은 [이 응답](https://github.com/BennyTMT/LLMsForTimeSeries/issues/7)을 참고하십시오.

**동기**: [DLinear](https://github.com/cure-lab/LTSF-Linear)가 여러 신기술에 의해 능가된 상황에서, 패칭을 기반으로 하면서도 단순하고 효과적인 방법을 제공하여 간단한 기준선을 만들고자 합니다.

     cd ./PAttn 

     bash ./scripts/ETTh.sh (ETTh1 & ETTh2용)
     bash ./scripts/ETTm.sh (ETTm1 & ETTm2용)
     bash ./scripts/weather.sh (Weather용)
     
#### 다른 데이터셋을 사용할 경우, 위 명령어에서 스크립트 이름을 변경하십시오.

## 제거 연구 (Ablations)
     
#### CALF(ETT)에서 제거 연구 실행:
     
    cd ./CALF
    sh scripts/long_term_forecasting/ETTh_GPT2.sh
    sh scripts/long_term_forecasting/ETTm_GPT2.sh
    
    sh scripts/long_term_forecasting/traffic.sh 
    (트래픽 등 기타 데이터셋용)

#### OneFitsAll(ETT)에서 제거 연구 실행:
     cd ./OFA
     bash ./script/ETTh_GPT2.sh   
     bash ./script/ETTm_GPT2.sh

     bash ./script/illness.sh 
     (질병 등 기타 데이터셋용)

#### Time-LLM(ETT)에서 제거 연구 실행:
     cd ./Time-LLM-exp
     bash ./scripts/train_script/TimeLLM_ETTh1.sh
     bash ./scripts/train_script/TimeLLM_ETTm1.sh 

     bash ./scripts/train_script/TimeLLM_Weather.sh
     (Weather 등 기타 데이터셋용)

#### (다른 데이터셋에서 제거 연구를 실행하려면, 위 예시처럼 데이터셋 이름을 변경하십시오.)

## 감사의 글

이 코드베이스는 [Time-Series-Library](https://github.com/thuml/Time-Series-Library)를 기반으로 구축되었습니다. 감사합니다!

## 인용
본 연구가 유용하다면, 다음과 같이 인용해 주시기 바랍니다:


```bibtex
@inproceedings{tan2024language,
    title={언어 모델이 실제로 시계열 예측에 유용한가?},
    author={Tan, Mingtian and Merrill, Mike A and Gupta, Vinayak and Althoff, Tim and Hartvigsen, Thomas},
    booktitle={신경 정보 처리 시스템 (NeurIPS)},
    year={2024}
}

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---