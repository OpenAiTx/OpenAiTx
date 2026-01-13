<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*특정 장소와 시간대의 데이터만을 사용해 **처음부터** 훈련한 언어 모델로, 현대적 편향을 줄이고 그 시대의 목소리, 어휘, 세계관을 재현합니다.*

AI 모델이 단순히 역사적 인물을 흉내내는 것이 아니라 실제로 그 시대의 존재라면 어떨까요?

v0 및 v0.5는 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 만들어졌습니다. 핵심 훈련 스크립트와 모델 아키텍처는 그의 작업입니다. 

v1은 [Microsoft의 Phi 1.5](https://huggingface.co/microsoft/phi-1_5) 위에 구축되었습니다.

v2는 llamaforcausallm 위에 구축되었습니다.

[허깅페이스 링크](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  모델 동작 및 한계

### **v0**  

초기 프롬프트에서 모델이 1800년대 언어와 행동으로 응답함을 보여줍니다.  
예시: 프롬프트: "Who art Henry?"에 "I know that man, I have did not a black, the storm."라고 답했습니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 현대 개념 언급 없음  
- 대부분 시대에 맞는 어휘 사용  
- 문장이 대부분 일관성이 없음 (~187MB 훈련 데이터의 기대 결과)

### **v0.5** 

v0에 비해 상당한 향상.  
- 빅토리아 시대의 문체, 올바른 구두점, 대부분 문법적으로 올바른 문장  
- 여전히 높은 수준의 사실적 환각 발생  
- OCR 노이즈(“Digitized by Google”)가 출력에 여전히 존재함

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

데이터셋에서 실제 인물과 역사적 사건을 처음으로 기억하고 연결한 모델.

예시: 프롬프트: "It was the year of our Lord 1834"

출력: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

처음에는 우연히 같은 해에 시위가 있었던 것으로 추측했지만, 이것을 보십시오: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2의 90GB 데이터셋에서 15GB 샘플을 사용하여 학습되었습니다.
모델은 10K 스텝까지만 학습되었습니다.

토크나이제이션에 문제가 있어 출력이 다음과 같이 나타납니다:

프롬프트:
찰스 디킨스는 누구입니까?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

수정됨:

"찰스 디킨스는 누구인가? 그의 훌륭하고 감동적인 작품들이 그의 연극에서, 대기업의 농장에서 더 많이 나타나는가? 내가 아직 인용하지 않은 잭 피켓의 말은 무엇인가? 그들이 일종의 질주, 혹은 가슴을 절단하는 행위, 아니면 잭슨이 창문을 바라보고 있던 때에 무엇을 해야 하는지 몰랐다는 사실을 모르는가? 영국인의 성공이란 무엇이며, 그의 아들이 아직 나에게 발견하지 못한 것이 그 무게를 이루기 위한 수단인가? 당신은 오래된 도로로 통과하거나, 우리 배의 발치에 정박하는 바람을 맞이한 적이 있습니까? 당신은 우리를 떠나야만 했던 그 상황을 아는가? 사실은, 토요일 밤이나 한낮에 평야에서 바람이 불어올지, 혹은 북쪽이나 다른 방향이든, 우리는 현재와 같은 효과를 가진 강력한 장벽을 묘사해야만 할 것입니다. 적어도 이 상황에서는 우리가 그 방을 떠났다고 말해도 지나치지 않습니다. '오백 배'에는 세 부가 있다고 믿습니다. 참조할 수 있으며, 우리 독자 중 첫 번째 번호를 원하는 분들에게..."

### **v2mini-eval2**

eval1 학습에 사용된 동일한 15GB 샘플로 훈련되었습니다.
모델은 다시 10K 스텝까지만 학습되었습니다.

프롬프트: Charles Darwin

Charles DarwinECCEMACY. 선생님, — 다음 사례는 저에게 흥미롭습니다 : — 저는 런던에 2주간 있었고, 류마티스 발작으로 크게 고생했습니다. 첫 번째 류마티스 발작은 선생님을 만나기 일주일 전에 있었고, 두 번째는 선생님을 만났을 때, 세 번째도 선생님을 만났을 때 있었으며, 세 번째는 같은 시기에 있었습니다. 그러나 두 번째 통풍 발작에는 열 증상이 동반되지 않았으나, 소변의 흐름이 증가하였고, 소변 배출량도 더 많았습니다. 세 번째 발작은 선생님을 만난 지 한 시간 후에 있었으며, 통풍 발작이 다시 발생했고, 통풍의 재발이 더 빨랐습니다. 네 번째 발작에도 열이 동반되었으나 항상 열 증상이 있는 것은 아니었습니다. 세 번째 통풍 발작은 선생님이 아프신 후 2주 후에 있었고, 네 번째는 통풍 발작이 뒤따랐습니다. 네 번째 발작은 선생님이 발작을 경험하신 후 2주 후에 있었고, 동반되었습니다.


##  데이터셋

### **v2**

- 1800-1875년 런던 텍스트 90GB
- 136,344개 문서
- 전체 90GB는 아직 토크나이즈되지 않아 공개되지 않았으나, 15GB 샘플은 여기에서 확인할 수 있습니다: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### 편향 통계 
  ![대명사 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![지리적 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![시간적 편향](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

자세한 내용은 [v2 편향 보고서](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) 를 참조하세요.


## 사용 방법

이 프로젝트는 주로 역사적 데이터를 수집하고, 훈련을 위해 준비하며, 토크나이저를 구축하는 데 중점을 둡니다. 전체 LLM 훈련 과정은 다루지 않으니, 자세한 내용은 Andrej Karpathy의 nanoGPT를 참고하세요.

### 1단계: 역사적 텍스트 수집 및 준비 

- 선택한 시대(예: 런던 1800-1850)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 수집합니다.
- 선택한 시간/장소 범위 내에 데이터를 유지하세요  
- 텍스트 파일에서 프로젝트 구텐베르크의 헤더/푸터, 현대 주석 또는 OCR 오류와 같은 내용을 스크립트나 수작업으로 제거하세요.

### 2단계: 맞춤형 토크나이저 구축

- train_tokenizer.py 또는 train_tokenizer_hf.py를 정제된 데이터에서 실행하세요.
- vocab.json과 merges.txt 파일이 생성됩니다.
- 이 파일들은 모델의 어휘와 병합 규칙을 정의합니다.

### 3단계: 모델을 학습하세요

- [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 또는 선택한 아키텍처의 문서를 참고하여 학습을 진행하세요.

# FAQ

## 선택적 시기별 학습(Selective Temporal Training)이란 무엇인가요?

선택적 시기별 학습(STT)은 모든 학습 데이터를 특정 역사적 시기 내로 엄선하는 머신러닝 방법론입니다. 이는 해당 시대의 언어와 지식을 현대적 개념의 영향을 받지 않고 모델링하기 위함입니다. 예를 들어, 제가 현재 보유한 모델(v0.5)은 1800-1875년 데이터만으로 학습되었으며, 파인튜닝이 아닌 처음부터 학습되어 당시의 언어 스타일과 역사적 맥락이 반영된 결과를 냅니다.

## 그냥 파인튜닝이나 LoRA를 사용하지 않는 이유는?

이 프로젝트에서는 현대적 편향이 없는 언어 모델을 만들고자 합니다. GPT-2 같은 모델을 파인튜닝하면 이미 사전학습된 정보가 남아 있습니다. 처음부터 학습하면 모델이 '옛날인 척' 하는 것이 아니라 진짜 옛날 언어를 사용합니다. 이 프로젝트의 목표는 1800~1875년에 런던에서 출판된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 학습에 사용했나요?

1800–1875년 런던의 책, 법률 문서, 신문 및 기타 글을 사용했습니다. 링크된 목록(v0)에는 약 200개가 있지만 첫 학습에서는 50개 파일(약 187MB)만 사용했습니다. 문서 목록은 다음에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

데이터셋 크기:
- v0: 약 187MB
- v0.5: 약 435MB 
- v1: 약 6.25GB 
- v2mini-eval1: 15GB

## 모델 크기는 얼마나 되나요?

v0: 1,600만 파라미터

v0.5 1억 2,300만 파라미터

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented






























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---