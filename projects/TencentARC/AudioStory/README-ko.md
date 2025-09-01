# AudioStory: 대규모 언어 모델을 활용한 장편 내러티브 오디오 생성

**[Yuxin Guo<sup>1,2</sup>](https://scholar.google.com/citations?user=x_0spxgAAAAJ&hl=en),  
[Teng Wang<sup>2,&#9993;</sup>](http://ttengwang.com/),  
[Yuying Ge<sup>2</sup>](https://geyuying.github.io/),  
[Shijie Ma<sup>1,2</sup>](https://mashijie1028.github.io/),  
[Yixiao Ge<sup>2</sup>](https://geyixiao.com/),  
[Wei Zou<sup>1</sup>](https://people.ucas.ac.cn/~zouwei),  
[Ying Shan<sup>2</sup>](https://scholar.google.com/citations?user=4oXBp9UAAAAJ&hl=en)**  
<br>  
<sup>1</sup>중국과학원 자동화연구소  
<sup>2</sup>텐센트 PCG ARC 연구실  
<br>  

## 📖 공개

[2025/8/28] 🔥🔥 추론 코드를 공개합니다!

[2025/8/28] 🔥🔥 데모 영상을 공개합니다!



## 🔎 소개

![audiostory](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory.png)

✨ **요약: 우리는 통합된 이해-생성 프레임워크를 기반으로 한 장편 내러티브 오디오 생성 모델을 제안하며, 영상 더빙, 오디오 연속 재생, 장편 내러티브 오디오 합성을 모두 처리할 수 있습니다.**

최근 텍스트-투-오디오(TTA) 생성 기술은 짧은 오디오 클립 합성에 뛰어나지만, 시간적 일관성과 구성적 추론이 필요한 장편 내러티브 오디오에서는 어려움을 겪고 있습니다. 이 격차를 해소하기 위해, 우리는 대규모 언어 모델(LLM)과 TTA 시스템을 통합하여 구조화된 장편 오디오 내러티브를 생성하는 통합 프레임워크 AudioStory를 제안합니다. AudioStory는 강력한 명령 수행 추론 생성 능력을 갖추고 있습니다. LLM을 활용하여 복잡한 내러티브 쿼리를 시간 순서에 따른 하위 작업과 맥락 단서로 분해하여 일관된 장면 전환과 감정 톤의 일관성을 가능하게 합니다. AudioStory의 두 가지 매력적인 특징은 다음과 같습니다:

1) 분리된 브리징 메커니즘: AudioStory는 LLM과 디퓨저 협업을 두 개의 전문화된 구성 요소로 분리합니다—내부 이벤트 의미 정렬을 위한 브리징 쿼리와 이벤트 간 일관성 유지를 위한 일관성 쿼리.  
2) 엔드-투-엔드 훈련: 명령 이해와 오디오 생성을 단일 엔드-투-엔드 프레임워크 내에서 통합하여 모듈별 훈련 파이프라인이 필요 없으며, 구성 요소 간 시너지를 강화합니다.  
    또한, 우리는 애니메이션 사운드스케이프 및 자연 사운드 내러티브 등 다양한 도메인을 포함하는 벤치마크 AudioStory-10K를 구축했습니다.

광범위한 실험 결과, AudioStory는 단일 오디오 생성과 내러티브 오디오 생성 모두에서 우수한 성능을 보이며, 이전 TTA 기준 모델들을 명령 수행 능력과 오디오 품질 양면에서 능가합니다.





## ⭐ 데모

### 1. 비디오 더빙 (톰과 제리 스타일)
> 더빙은 비디오에서 추출한 시각적 캡션과 함께 톰과 제리로 훈련된 AudioStory를 사용하여 이루어집니다.

<table class="center">
  <td><video src="https://github.com/user-attachments/assets/f06b5999-6649-44d3-af38-63fdcecd833c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/17727c2a-bfea-4252-9aa8-48fc9ac33500"></video></td>
  <td><video src="https://github.com/user-attachments/assets/09589d82-62c9-47a6-838a-5a62319f35e2"></video></td>
  <tr>
</table >


### 2. 교차 도메인 비디오 더빙 (톰과 제리 스타일)

<table class="center">
    <td><video src="https://github.com/user-attachments/assets/e62d0c09-cdf0-4e51-b550-0a2c23f8d68d"></video></td>
    <td><video src="https://github.com/user-attachments/assets/736d22ca-6636-4ef0-99f3-768e4dfb112a"></video></td>
    <td><video src="https://github.com/user-attachments/assets/f2f7c94c-7f72-4cc0-8edc-290910980b04"></video></td>
  <tr>
  <td><video src="https://github.com/user-attachments/assets/d3e58dd4-31ae-4e32-aef1-03f1e649cb0c"></video></td>
  <td><video src="https://github.com/user-attachments/assets/4f68199f-e48a-4be7-b6dc-1acb8d377a6e"></video></td>
  <td><video src="https://github.com/user-attachments/assets/062236c3-1d26-4622-b843-cc0cd0c58053"></video></td>
	<tr>
  <td><video src="https://github.com/user-attachments/assets/8931f428-dd4d-430f-9927-068f2912dd36"></video></td>
  <td><video src="https://github.com/user-attachments/assets/ab7e46d5-f42c-472e-b66e-df786b658210"></video></td>      
  <td><video src="https://github.com/user-attachments/assets/9a0998ad-b5a4-42ac-bdaf-ceaf796fc586"></video></td>
  <tr>
</table >



### 3. 텍스트-투-롱 오디오 (자연 소리)

<table class="center">
  <td style="text-align:center;" width="480">지시문: "제이크 시마부쿠로가 스튜디오에서 복잡한 우쿨렐레 곡을 연주하고, 박수를 받으며, 인터뷰에서 자신의 경력에 대해 이야기하는 내용을 완벽하게 표현하는 종합적인 오디오를 개발하십시오. 총 길이는 49.9초입니다."</td>
  <td><video src="https://github.com/user-attachments/assets/461e8a34-4217-454e-87b3-e4285f36ec43"></video></td>
	<tr>
  <td style="text-align:center;" width="480">지시문: "소방차가 사이렌을 울리며 출동 신호를 보내고, 긴급 출동을 알리며 출발하는 장면을 완벽하게 표현하는 종합적인 오디오를 개발하십시오. 총 길이는 35.1초입니다."</td>
  <td><video src="https://github.com/user-attachments/assets/aac0243f-5d12-480e-9850-a7f6720e4f9c"></video></td>
	<tr>
     <td style="text-align:center;" width="480">지시사항: "입력된 오디오를 이해하고, 이후의 사건을 추론하며, 코치가 선수들에게 농구 수업을 계속해서 진행하는 오디오를 생성합니다. 총 지속 시간은 36.6초입니다."</td>    
    <td><video src="https://github.com/user-attachments/assets/c4ed306a-651e-43d6-aeea-ee159542418a"></video></td>
	<tr>
</table >




## 🔎 방법

![audiostory_framework](https://raw.githubusercontent.com/TencentARC/AudioStory/main/audiostory_framework.png)

효과적인 지시 따르기 오디오 생성을 달성하기 위해서는 입력된 지시문이나 오디오 스트림을 이해하고 관련된 오디오 하위 이벤트를 추론하는 능력이 필수적입니다. 이를 위해 AudioStory는 통합된 이해-생성 프레임워크(Fig.)를 채택했습니다. 구체적으로, 텍스트 지시나 오디오 입력이 주어지면, LLM은 이를 분석하고 맥락과 함께 구조화된 오디오 하위 이벤트로 분해합니다. 추론된 하위 이벤트를 바탕으로 LLM은 **교차 추론 생성**을 수행하여 각 오디오 클립에 대해 캡션, 의미 토큰, 잔여 토큰을 순차적으로 생성합니다. 이 두 종류의 토큰은 융합되어 DiT로 전달되며, 이는 LLM과 오디오 생성기를 효과적으로 연결합니다. 점진적 훈련을 통해 AudioStory는 강력한 지시 이해와 고품질 오디오 생성을 최종적으로 달성합니다.



## 🔩 설치

### 의존성

* Python >= 3.10 ([Anaconda](https://www.anaconda.com/download/#linux) 사용 권장)
* [PyTorch >=2.1.0](https://pytorch.org/)
* NVIDIA GPU + [CUDA](https://developer.nvidia.com/cuda-downloads)

### 설치

```
git clone https://github.com/TencentARC/AudioStory.git
cd AudioStory
conda create -n audiostory python=3.10 -y
conda activate audiostory
bash install_audiostory.sh
```



## 📊 Evaluation

### inference

```
python evaluate/inference.py --model_path /path/to/ckpt --guidance 4.0 --save_folder_name audiostory --total_duration 50
```
## 🔋 감사의 말씀

연속 디노이저 코드베이스를 구축할 때, [SEED-X](https://github.com/AILab-CVC/SEED-X)와 [TangoFlux](https://github.com/declare-lab/TangoFlux)를 참고하였습니다. 훌륭한 프로젝트에 감사드립니다.



## 📆 해야 할 일

- [ ] 그라디오 데모 공개.
- [ ] AudioStory 체크포인트 공개.
- [ ] 세 단계 모두의 훈련 코드 공개.



## 📜 라이선스

이 저장소는 [Apache 2 라이선스](https://github.com/mashijie1028/Gen4Rep/blob/main/LICENSE)를 따릅니다.



## 📚 BibTeX




```
@misc{guo2025audiostory,
      title={AudioStory: Generating Long-Form Narrative Audio with Large Language Models}, 
      author={Yuxin Guo and Teng Wang and Yuying Ge and Shijie Ma and Yixiao Ge and Wei Zou and Ying Shan},
      year={2025},
      eprint={2508.20088},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2508.20088}, 
}
```
## 📧 연락처

추가 질문이 있으시면 언제든지 연락해 주세요: guoyuxin2021@ia.ac.cn

토론 및 잠재적 협업도 환영합니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---