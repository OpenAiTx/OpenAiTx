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

## 빈티지 LLM 디스코드에 참여하세요

**역사적 언어 모델**, **시대별 데이터셋**, 그리고 **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**와 같은 프로젝트의 미래에 관심이 있다면 커뮤니티에 참여해보세요.

서버에서는 아이디어를 논의하고, 진행 상황을 공유하며, 이 분야에서 활동하는 다른 사람들과 교류할 수 있습니다.

[디스코드 참여하기](https://discord.gg/JeWkk4z5)

##  모델 동작 및 한계

### **v0**  

초기 프롬프트에서는 모델이 1800년대의 언어와 행동으로 응답하는 모습을 볼 수 있습니다.
예시: 프롬프트: "Who art Henry?"에 대해 "I know that man, I have did not a black, the storm."라고 답했습니다.

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 현대적 개념 언급 없음  
- 대부분 시대에 맞는 어휘 사용  
- 문장 대부분이 일관성이 없음 (~187MB 학습 데이터 기준 예상됨)

### **v0.5-london** 

v0에 비해 상당한 개선이 이루어졌습니다.  
- 빅토리아 시대의 글쓰기 스타일, 올바른 문장 부호, 대부분 문법적으로 정확한 문장  
- 여전히 높은 사실적 환각률  
- OCR 잡음(“Digitized by Google”)이 여전히 출력에 존재함

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

데이터셋 내 실제 인물과 실제 역사적 사건을 기억하고 연결한 최초의 모델입니다.

예시: 프롬프트: "It was the year of our Lord 1834" 

출력: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

처음에는 같은 해에 시위가 우연히 일어난 것이라 생각했지만, 이것을 확인해보세요: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

v2의 90GB 데이터셋에서 15GB 샘플을 사용하여 훈련되었습니다.
모델은 10K 스텝까지만 훈련되었습니다.

토크나이징 문제로 인해 출력이 다음과 같이 표시됩니다:

프롬프트:
찰스 디킨스는 누구입니까?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

수정됨:

"찰스 디킨스는 누구입니까? 그의 뛰어나고 감동적인 작품들은 그의 연극에서, 또는 Great Company의 농장에서 더 많이 나타납니까? 제가 아직 인용하지 않은 잭 피켓의 말은 무엇입니까? 그들이 일종의 질주를 하거나, 가슴을 켜는 듯한 행동을 하거나, 잭슨이 창밖을 바라보고 있을 때 무슨 일이 일어나야 했는지 알지 못합니까? 영국인의 성공이란 무엇이며, 그의 아들이 나에게 밝혀내지 않은 것은 무엇입니까? 당신은 예전에 오래된 도로로 진입하거나, 우리 보트의 발치에 있는 닻바람에 정박해 본 적이 있습니까? 바람이 토요일 밤이나 정오, 혹은 북쪽에서 일어나든, 그렇지 않든, 우리는 현재와 마찬가지로 강력한 장벽을 묘사해야 할 것입니다. 이런 상황에서는, 적어도 우리가 그 방을 떠났다고 말하는 것이 과하지 않습니다. 'Five Hundred-fold'에는 참고할 수 있는 사본이 세 개 있다고 생각합니다. 이는 저희 독자 중 첫 번째 번호에 해당합니다..."

### **v2mini-eval2-london**

eval1 학습에 사용된 동일한 15GB 샘플로 훈련됨.
모델은 다시 1만 스텝까지만 학습됨.

PROMPT:찰스 다윈

찰스 다윈ECCEMACY. 선생님, — 다음 사례는 저에게 흥미롭습니다 : — 저는 런던에 2주간 있었고, 류마티스에 시달려 큰 영향을 받았습니다. 첫 번째 류마티스 발작은 선생님을 만나기 일주일 전에 있었고, 두 번째는 선생님을 만났을 때, 세 번째 역시 같은 시기에 있었습니다. 그러나 두 번째 통풍 발작은 열성 증상 없이 소변의 흐름이 증가하고 더 풍부한 소변 배출을 동반했습니다. 세 번째 발작은 선생님을 만난 지 한 시간 후에 일어났고, 통풍의 발작이 재발하며 더 빠르게 진행되었습니다. 네 번째 발작 또한 열을 동반했으나 항상 열성 증상이 나타나진 않았습니다. 세 번째 통풍 발작은 선생님이 아팠던 후 2주 후에 있었고, 네 번째는 통풍 발작이 뒤따랐습니다. 네 번째 발작은 공격받은 후 2주 후에 있었고, 어떤 감각을 동반했습니다.

### **v2-london**

90GB (토큰화 시 112GB) 데이터셋으로 훈련됨
182K 스텝까지 학습됨

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **다음 계획은?**

- TimeCapsuleLLM v3 개발 시작
- 데이터셋 크기 및 지리적 범위 확장
- 런던을 넘어 추가 도시로 확장

이 작업은 University College London (UCL)의 연구자들과 협력하여 진행 중이며, 추가 기관의 참여도 논의되고 있습니다.

##  데이터셋

### **v2**

- 1800-1875년 런던 텍스트 90GB(원본)
- 136,344개 문서
- 전체 토큰화된 데이터셋은 여기에서 이용 가능: https://huggingface.co/datasets/postgrammar/london-llm-1800


### 편향 통계
  ![대명사 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![지리적 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![시간적 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

자세한 내용은 [v2 편향 보고서](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)를 참고하세요.


- 


## 사용 방법

이 프로젝트는 주로 역사적 데이터를 선별, 학습용으로 준비하고 토크나이저를 구축하는 데 중점을 둡니다. 전체 LLM 학습 과정을 다루지는 않으니, 그 부분은 Andrej Karpathy의 nanoGPT를 참고하세요.

### 1단계: 역사적 텍스트 수집 및 준비

- 선택한 시대(예: 런던 1800-1875)의 퍼블릭 도메인 서적, 문서 등의 .txt 파일을 수집합니다.
- 선택한 시간/장소 범위 내에서만 유지하세요.
- 스크립트 또는 수동으로 Project Gutenberg의 헤더/푸터, 현대 주석, OCR 오류 등 텍스트 파일을 정리하세요.

### 2단계: 커스텀 토크나이저 구축

- 정제된 데이터에 대해 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.
- 그러면 vocab.json과 merges.txt가 생성됩니다.
- 이 파일들은 모델의 어휘 및 병합 규칙을 정의합니다.

### 3단계: 모델 학습

- 학습 과정이나 선택한 아키텍처의 문서는 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참고하세요.

# 자주 묻는 질문

## 선택적 시간 기반 학습(Selective Temporal Training)이란?

선택적 시간 기반 학습(STT)은 모든 학습 데이터를 특정 역사적 시기에 맞춰 엄선하는 머신러닝 방법론입니다. 이는 현대 개념의 영향을 받지 않고 해당 시대의 언어와 지식을 모델링하기 위함입니다. 예를 들어, 현재 제가 가지고 있는 모델(v0.5)은 1800-1875년의 데이터만으로 학습되었으며, 파인튜닝이 아닌 처음부터 학습하여 그 시대의 언어 스타일과 역사적 맥락이 반영된 출력을 보여줍니다.

## 파인튜닝이나 LoRA만 사용하지 않는 이유는 무엇인가요?

이 프로젝트에서 저는 현대적 편견에서 벗어난 언어 모델을 만들고자 합니다. GPT-2와 같은 모델을 파인튜닝하면 이미 사전학습된 정보가 남아있고, 그것은 사라지지 않습니다. 처음부터 학습시키면 언어 모델이 옛것인 척하지 않고 실제로 옛것이 됩니다. 이 프로젝트의 현재 목표는 1800년부터 1875년까지 런던에서 출판된 책의 지식만을 사용해 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 학습에 사용했나요?

1800–1875년 런던의 책, 법률 문서, 신문, 기타 문헌을 사용했습니다. 제가 링크한 목록(v0)은 약 200개 문서가 있지만, 첫 학습에서는 약 50개 파일, 총 ~187MB를 사용했습니다. 문서 목록은 다음에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

데이터셋 크기:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB(v2의 90GB에서 샘플)
- v2: 90GB

## 모델 크기는 얼마나 되나요?

v0: 16M 파라미터

v0.5: 123M 파라미터

v1: 700M 파라미터

v2mini-eval1: 300M 파라미터

v2mini-eval2: 200M 파라미터

v2: 1.2B 파라미터

## 학습 사양은?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM 임대

### v2mini-eval1/eval2
GPU: A100 SXM 대여

### v2
GPU: H100 SXM 대여

## 관련 연구

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  1930년 이전의 260B 토큰 텍스트에 Q&A로 학습된 130억 파라미터 LLM. [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) 버전도 있음.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1800-1899년 텍스트에 Q&A로 학습된 14억 파라미터 LLM. [160M](https://huggingface.co/zakarth/violet-160m-chat) 버전도 있음.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  1837-1899년 사이 28,000편 이상의 텍스트에 Q&A로 학습된 3억 4천만 파라미터 LLM.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - 1913, 1929, 1933, 1939, 1946년까지의 역사 데이터를 바탕으로 80B 토큰으로 처음부터 학습한 Qwen3 아키텍처 기반의 40억 파라미터 LLM 계열.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT는 Mistral-Hermes 2를 EEBO와 Gallica에서 주로 수집한 영어, 프랑스어, 라틴어 11,000편의 초기 근대 텍스트에 파인튜닝한 모델.

## 감사의 말

본 연구의 프레이밍 및 평가, v2 릴리스를 위한 토크나이저 훈련과 데이터셋 준비에 있어 학문적 감독과 지도를 해주신 [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)께 감사드립니다. 그의 피드백과 경험은 이 작업의 완성도를 높이는데 매우 중요한 역할을 했습니다.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---