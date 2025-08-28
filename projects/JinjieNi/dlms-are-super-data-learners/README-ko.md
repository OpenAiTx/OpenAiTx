<div align="center">

<!-- TITLE -->
# **확산 언어 모델은 초대용량 데이터 학습자입니다**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# 하이라이트
- 우리는 **80억 매개변수** 및 **4800억 토큰**까지 DLM과 AR 모델을 처음부터 사전학습했습니다. DLM은 자기회귀(AR) 모델에 비해 > **3배** 이상의 데이터 잠재력을 보여줍니다. 특히, 10억 매개변수 마스크 확산 모델은 특수한 기법 없이 표준 사전학습 데이터를 반복 학습하는 것만으로 HellaSwag에서 > **56%**, MMLU에서 > **33%** 정확도를 10억 토큰만으로 달성합니다. 더 많은 반복은 성능을 더욱 향상시킬 수 있는데, **수익 감소 현상은 관찰되지 않았기 때문입니다.**
- DLM은 조밀한 AR 모델보다 더 많은 FLOPs를 소모하는 초고밀도 모델입니다. 데이터를 완전히 활용하기 위해 DLM을 학습하려면 일반적으로 최소 **두 자릿수 배** 이상의 FLOPs가 필요합니다. 추론 시, 16에서 4096 토큰 범위의 시퀀스 생성은 AR 기준 모델 대비 **16배에서 4700배**의 FLOPs 증가를 초래합니다. 또한, 확산 목적함수로 가능해진 더 표현력 높은 양방향 어텐션은 **완전 인과적이지 않은 언어 데이터를 양방향으로 모델링**하여 그 가치를 최대한 끌어냅니다.
- 동시 진행된 연구 “Diffusion Beats Autoregressive in Data-Constrained Settings”는 **문제 있는 확산 손실 공식화, 비교에 부적합한 지표, AR 모델에 대한 불공정한 설정, 문제 있는 스케일링 법칙 공식화** 등 중대한 방법론적 문제를 포함하여 문제적인 결론에 이를 수 있습니다. 이 모든 요소는 의심스러운 결과와 결론을 초래할 수 있습니다.

<br>

# 크로스오버
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*블로그의 도표 A: 제한된 데이터 일부를 반복할 때 자기회귀(AR) 모델과 마스크 확산 모델(확산)의 성능 비교. 모든 모델은 총 960억 토큰(반복 포함)으로 학습하며, 고유 토큰 수는 5억에서 960억까지 변동. 확산 모델은 제한된 고유 데이터에서 더 많은 반복을 통해 데이터를 더 잘 활용함. 더 많은 고유 토큰은 크로스오버를 보기 위해 더 많은 반복이 필요하며, 고유 토큰 수가 높은 경우 크로스오버가 960억 토큰 관찰 범위를 넘어서 지연됨.*

<br>

# 인용문
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---