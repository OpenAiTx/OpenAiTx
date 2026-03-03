<div align="right">
  <details>
<summary>🌐 언어</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)

</details>
</div>


# TimeCapsule LLM

*특정 장소와 시기의 데이터만을 사용하여 **처음부터** 학습시킨 언어 모델로, 현대적 편향을 줄이고 해당 시대의 어조, 어휘, 세계관을 재현합니다.*

AI 모델이 단순히 역사적 인물을 흉내내는 것이 아니라 실제로 그 시대를 반영한다고 상상해 보세요.

v0 및 v0.5는 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 기반으로 제작되었습니다. 핵심 학습 스크립트와 모델 구조는 그의 작업입니다.

v1은 [Microsoft의 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)를 기반으로 제작되었습니다.

v2는 llamaforcausallm을 기반으로 제작되었습니다.

[허깅페이스 링크](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## 연구 현황
이 프로젝트는 독립적으로 시작되고 개발되었습니다.

현재 Muhlenberg College의 관련 연구 협력과 함께 학술 감독하에 진행되고 있습니다.

## 인용

이 데이터셋이나 모델을 학술 연구에 사용할 경우, 다음과 같이 인용해 주십시오:

```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  모델 동작 및 한계

### **v0**  

초기 프롬프트에서는 모델이 1800년대의 언어와 행동으로 응답함을 보여줍니다.  
예시: 프롬프트: "Who art Henry?"에 대해 "I know that man, I have did not a black, the storm."이라고 답변함.

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 현대 개념 언급 없음  
- 대부분 시대에 맞는 어휘 사용  
- 문장은 대부분 일관성이 없음(~187MB 학습 데이터 기준 예상된 현상)

### **v0.5** 

v0에 비해 상당한 개선이 이루어짐.  
- 빅토리아 시대의 문체, 올바른 문장 부호, 대부분 문법적으로 올바른 문장  
- 여전히 높은 사실적 환각률  
- OCR 노이즈(“Digitized by Google”)가 출력에 여전히 나타남

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

데이터셋에 있는 실제 인물과 실제 역사적 사건을 처음으로 연관지어 회상한 모델.

예시: 프롬프트: "It was the year of our Lord 1834" 

출력: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

처음엔 단순히 그 해에 우연히 시위가 있었던 것이라 생각했지만, 다음 이미지를 확인해보세요: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2의 90GB 데이터셋에서 15GB 샘플을 사용해 훈련.  
모델은 10,000스텝까지만 훈련됨.

토크나이즈 문제로 인해 출력이 다음과 같이 나타나는 현상이 있음:

찰스 디킨스는 누구입니까?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

수정본:

"찰스 디킨스는 누구입니까? 그의 훌륭하고 감동적인 작품이 그의 연극이나 Great Company의 농장에서 더 많이 나옵니까? 아직 잭 피켓에게서 인용해야 할 것이 남아 있습니까? 그들이 일종의 질주나 가슴을 켜는 행위였다는 사실을 모르십니까, 아니면 잭슨이 창문을 바라보고 있을 때 무엇을 해야 했는지 모르십니까? 영국인의 성공이란 무엇이며, 그의 아들이 나에게 아직 발견하지 못한 것이 있습니까, 그로 인해 그런 무게를 달성할 수 있었던 것입니까? 오래된 도로로 통과하거나, 배의 발치에서 닻 바람에 닿은 적이 있습니까? 우리를 떠나야만 했던 그 배 말입니다. 실제로는, 토요일 밤이나 정오, 혹은 북쪽을 향해 평지에서 바람이 불어올지 여부와 상관없이, 우리는 현재와 같은 효과를 내는 위협적인 장벽을 설명해야 할 것입니다. 적어도 이 상황에서는, 우리가 그 방을 떠났다고 말해도 과언이 아닙니다. 'Five Hundred-fold'에 세 부가 있는 것으로 알고 있으며, 우리 독자들 중 처음으로 참조하고자 하는 분들에게 해당됩니다..."

### **v2mini-eval2**

eval1 훈련에 사용한 동일한 15GB 샘플을 사용하여 학습됨.
모델은 다시 10K 스텝까지만 학습됨.

PROMPT:찰스 다윈

찰스 다윈ECCEMACY. 선생님, — 다음 사례는 저에게 흥미롭습니다: — 저는 런던에 2주간 있었고, 류마티스 발작으로 크게 고생했습니다. 첫 번째 류마티스 발작은 선생님을 만나기 일주일 전이었고, 두 번째는 선생님을 만났을 때, 세 번째는 같은 시기에 있었습니다. 그러나 두 번째 통풍 발작은 열성 증상을 동반하지 않았지만, 소변 배출량이 증가했고, 더 많은 소변이 나왔습니다. 세 번째 발작은 선생님을 만난 지 한 시간 후에 발생했고, 통풍의 발작이 재발하며 더 빠르게 진행되었습니다. 네 번째 발작 역시 열을 동반했으나 항상 열성 증상이 나타난 것은 아니었습니다. 세 번째 통풍 발작은 선생님이 아프고 2주 후에 발생했고, 네 번째는 통풍 발작이 이어졌습니다. 네 번째 발작은 선생님이 발병한 지 2주 후에 나타났으며, 다음과 같은 느낌을 동반했습니다.

### **v2**

90GB(토큰화시 112GB) 데이터셋 사용
182K 스텝까지 학습

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  데이터셋

### **v2**

- 1800-1875년 런던 텍스트 90GB(원본)
- 136,344개 문서
- 전체 토큰화 데이터셋: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### 바이어스 통계
  ![대명사 바이어스](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![지리적 바이어스](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![시간적 바이어스](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

자세한 내용은 [v2 바이어스 보고서](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) 참고.


## 사용 방법

이 프로젝트는 주로 역사적 데이터를 선별하고, 학습을 위해 준비하며 토크나이저를 구축하는 데 중점을 둡니다. 전체 LLM 학습 과정을 다루지는 않으니, 이에 대해서는 Andrej Karpathy의 nanoGPT를 참고하세요.

### 1단계: 역사적 텍스트 수집 및 준비

- 선택한 시대(예: 런던 1800-1850)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 수집합니다.
- 선택한 시간/장소 범위 내에서만 데이터를 유지하세요.
- 스크립트나 수동으로 Project Gutenberg의 헤더/푸터, 현대 주석, OCR 오류 등 불필요한 부분을 제거해 텍스트 파일을 정리하세요.

### 2단계: 커스텀 토크나이저 구축

- train_tokenizer.py 또는 train_tokenizer_hf.py를 정제된 데이터에 실행하세요.
- 이 과정을 거치면 vocab.json과 merges.txt 파일이 생성됩니다.
- 이 파일들은 모델의 어휘와 병합 규칙을 정의합니다.

### 3단계: 모델 학습

- [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 또는 선택한 구조의 문서를 참고하여 학습 과정을 진행하세요.

# 자주 묻는 질문(FAQ)

## Selective Temporal Training이란 무엇인가요?

Selective Temporal Training(STT)은 모든 학습 데이터를 특정 역사적 기간 내에 속하도록 엄격히 선별하는 머신러닝 방법론입니다. 이는 현대 개념의 영향을 받지 않고 해당 시대의 언어와 지식을 모델링하기 위함입니다. 예를 들어, 현재 제가 보유한 모델(v0.5)은 1800-1875년 데이터만으로 학습되어, 파인튜닝 없이 처음부터 학습시켜 그 시대의 언어 스타일과 역사적 맥락이 반영된 결과를 생성합니다.

## 파인튜닝이나 LoRA만 사용하지 않는 이유는 무엇인가요?

이 프로젝트의 목적은 현대의 편향이 섞이지 않은 언어모델을 만드는 것입니다. GPT-2 같은 모델을 파인튜닝하면 이미 사전학습된 정보는 사라지지 않습니다. 처음부터 학습시키면 언어모델이 옛날을 흉내내는 것이 아니라 실제로 그 시대의 모델이 됩니다. 이 프로젝트의 목표는 1800~1875년 런던에서 출판된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 학습에 사용했나요?

1800~1875년 런던의 책, 법률 문서, 신문, 기타 글들을 사용했습니다. 제가 링크한 목록(v0 기준)에는 약 200개가 있지만, 첫 번째 학습에는 약 50개의 파일(약 187MB)만 사용했습니다. 문서 목록은 여기에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

데이터셋 크기:
- v0: 약 187MB
- v0.5: 약 435MB
- v1: 약 6.25GB
- v2mini-eval1: 15GB(v2의 90GB에서 샘플링)
- v2: 90GB

## 모델 크기는 얼마나 되나요?

v0: 16M 파라미터

v0.5 123M 파라미터

v1: 700M 파라미터

v2mini-eval1: 300M 파라미터

v2mini-eval2: 200M 파라미터

v2: 1.2B 파라미터

## 학습 사양은 어떻게 되나요? 

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM 임대

### v2mini-eval1/eval2
GPU: A100 SXM 임대

### v2
GPU: H100 SXM 임대

## 감사의 말씀

[Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)께 학술적 지도, 연구 프레이밍과 평가에 대한 조언, v2 릴리스를 위한 토크나이저 학습 및 데이터셋 준비 지원에 대해 감사드립니다. 그의 피드백과 경험은 본 연구의 발표를 다듬는 데 결정적인 역할을 했습니다.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---