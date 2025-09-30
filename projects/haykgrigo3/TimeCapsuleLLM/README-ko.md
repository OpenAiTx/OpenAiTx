
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (곧 출시)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (곧 출시)</a> |
        | <a href="#" title="Coming soon">ไทย (곧 출시)</a> |
        | <a href="#" title="Coming soon">Français (곧 출시)</a>
        | <a href="#" title="Coming soon">Deutsch (곧 출시)</a>
        | <a href="#" title="Coming soon">Español (곧 출시)</a>
        | <a href="#" title="Coming soon">Italiano (곧 출시)</a>
        | <a href="#" title="Coming soon">Русский (곧 출시)</a>
        | <a href="#" title="Coming soon">Português (곧 출시)</a>
        | <a href="#" title="Coming soon">Nederlands (곧 출시)</a>
        | <a href="#" title="Coming soon">Polski (곧 출시)</a>
        | <a href="#" title="Coming soon">العربية (곧 출시)</a>
        | <a href="#" title="Coming soon">فارسی (곧 출시)</a>
        | <a href="#" title="Coming soon">Türkçe (곧 출시)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (곧 출시)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (곧 출시)</a>

      </div>
    </div>
  </details>
</div>

# 타임캡슐 LLM

*특정 장소와 시대의 데이터만을 사용하여 **처음부터** 훈련된 언어 모델로, 현대적 편향을 줄이고 해당 시대의 목소리, 어휘, 세계관을 재현합니다.*

AI 모델이 역사적인 모습을 흉내내는 것이 아니라 실제로 그 시대의 일부가 된다면 어떨까요?

v0 및 v0.5는 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 구축되었습니다. 핵심 훈련 스크립트와 모델 구조는 그의 작업입니다.

v1은 [Microsoft의 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)를 기반으로 구축되었습니다.

[허깅페이스 링크](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  모델 동작 및 한계

### **v0**  

초기 프롬프트에서는 모델이 1800년대의 언어와 행동으로 응답하는 모습을 보입니다.  
예시: 프롬프트: "Who art Henry?"에 대해 "I know that man, I have did not a black, the storm."라고 답변함.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 현대 개념 언급 없음  
- 대부분 시대에 맞는 어휘 사용  
- 문장이 대부분 일관성이 없음 (~187MB의 학습 데이터 기준 예상된 결과)

### **v0.5** 

v0에 비해 상당한 개선이 이루어짐.  
- 빅토리아 시대의 문체, 올바른 구두점, 대부분 문법에 맞는 문장  
- 여전히 높은 사실적 환각 비율  
- 출력에 OCR 노이즈(“Digitized by Google”)가 여전히 존재

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

데이터셋에 실제 인물과 실제 역사적 사건을 처음으로 연결하여 회상한 모델.

예시: 프롬프트: "It was the year of our Lord 1834"

출력: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

처음에는 우연히 해당 연도에 시위가 있었을 것이라고 생각했지만, 다음을 보세요: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### 왜 이것이 중요한가:

이것은 내 모델 중 하나가 특정 연도를 실제 역사적 사건과 그 사건에 관련된 실제 인물(팔머스턴 경)과 연결한 첫 번째 사례입니다. 초기 모델(v0과 v0.5)은 19세기 문체를 모방할 수 있었지만, 항상 사건, 인물, 사실을 환각했습니다. 이번 결과는 모델이 데이터셋에서 정보를 기억하기 시작했음을 보여줍니다.


## 향후 계획

- 1800-1875년 런던에서 출판된 약 175,000개의 텍스트가 Internet Archive에 있습니다
- 더 나은 추론 능력을 위해 코퍼스를 확장하고 정제할 계획입니다
- 더 많은 역사적 모델을 위해 다양한 지역과 시간대로 확장할 예정입니다

## 사용 방법

이 프로젝트는 주로 역사적 데이터를 선별하고, 학습을 위해 준비하고, 토크나이저를 구축하는 데 초점을 맞춥니다. 전체 LLM 학습 과정은 다루지 않으니, 이에 대해서는 Andrej Karpathy의 nanoGPT를 참고하세요.

### 1단계: 역사적 텍스트 수집 및 준비

- 선택한 기간(예: 런던 1800-1850년대)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 수집하세요
- 선택한 시간/장소 범위 내에 파일을 유지하세요
- 스크립트나 수작업으로 Project Gutenberg의 헤더/푸터, 현대 주석 또는 OCR 오류와 같은 부분을 제거하여 텍스트 파일을 정제하세요.

### 2단계: 커스텀 토크나이저 구축

- 정제된 데이터에 대해 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.
- 이 과정을 거치면 vocab.json과 merges.txt가 생성됩니다
- 이 파일들은 모델의 어휘와 병합 규칙을 정의합니다

### 3단계: 모델 학습

- 학습 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)나 선택한 아키텍처의 문서를 참고하세요.

# 자주 묻는 질문

## 선택적 시기별 학습(Selective Temporal Training)이란?

선택적 시기별 학습(STT)은 모든 학습 데이터를 특정 역사적 시기로 엄선하여 기계학습하는 방법론입니다. 이는 해당 시대의 언어와 지식을 현대 개념의 영향 없이 모델링하기 위함입니다. 예를 들어, 현재 제가 만든 모델(v0.5)은 1800-1875년의 데이터만으로 학습되었으며, 파인튜닝 없이 처음부터 훈련되어 그 시대의 언어적 스타일과 역사적 맥락이 반영된 결과를 보여줍니다.

## 왜 파인튜닝이나 LoRA만 사용하지 않나요?

이 프로젝트에서 저는 현대적 편향이 없는 언어 모델을 만들고자 합니다. 만약 GPT-2와 같은 모델을 파인튜닝한다면 이미 사전학습된 정보가 남아있어 완전히 지울 수 없습니다. 처음부터 학습하면 언어 모델이 옛것인 척 하는 것이 아니라 실제로 옛 언어를 구사하게 됩니다. 현재 이 프로젝트의 목표는 1800-1875년에 런던에서 출판된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 학습에 사용했나요?


저는 1800–1875년 런던의 책, 법률 문서, 신문, 기타 저작물을 사용하고 있습니다. 제가 링크한 목록(v0용)에는 약 200개의 문서가 있지만 첫 번째 훈련에는 약 187MB 분량의 50개 파일만 사용했습니다. 문서 목록은 다음에서 확인할 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

데이터셋 크기:
v0: 약 187MB
v0.5: 약 435MB 
v1: 약 6.25GB 

## 모델 크기는 얼마나 됩니까?

V0: 1,600만 파라미터

V0.5: 1억 2,300만 파라미터

V1: 7억 파라미터

# 훈련 사양은?

# V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F 
램: 16GB DDR5.

# V1
GPU: 임대한 A100

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---