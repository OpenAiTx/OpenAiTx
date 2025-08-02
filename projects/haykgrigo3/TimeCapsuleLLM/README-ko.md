<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (곧 제공 예정)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (곧 제공 예정)</a> |
        | <a href="#" title="Coming soon">ไทย (곧 제공 예정)</a> |
        | <a href="#" title="Coming soon">Français (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Deutsch (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Español (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Italiano (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Русский (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Português (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Nederlands (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Polski (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">العربية (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">فارسی (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Türkçe (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (곧 제공 예정)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (곧 제공 예정)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
특정 시대의 데이터만으로 훈련되어 현대 편향을 줄인 LLM.

AI 모델이 단순히 과거를 흉내내는 것이 아니라 실제로 역사적 관점에 기반한다면 어떨까요?

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 기반으로 하였으며, 핵심 훈련 스크립트와 모델 구조는 그의 작업입니다.

# 프로젝트 목표

TimeCapsule LLM은 특정 시대에 작성된 텍스트만으로 훈련하는 실험적 프로젝트입니다. 목표는 특정 역사적 시기의 세계관과 언어를 시뮬레이션하는 것입니다.

# 파인튜닝만으로는 부족한 이유

사전 훈련된 모델을 파인튜닝만 하면, 여전히 현대 개념을 알고 있을 것입니다. 물론 완전한 무현대 편향을 이루기는 어렵지만, 최대한 근접하고자 합니다. 현대 편향을 없애려면 처음부터 모델을 훈련해야 합니다.

# 기대 결과

완성되면 이 모델은 현대 개념을 모르고, 훈련받은 범위를 넘어선 추론도 하지 않게 될 것입니다. 현대 개념/어휘를 인식하지 않아야 하며, 현대적 지식을 환각하지 않기를 기대합니다.

# 진행 현황

## 2025년 7월 9일

1800~1850년, 지역: 런던으로 시기를 정했습니다.

텍스트, 책, 문서 목록을 수집했습니다.

현재까지 50개의 txt 파일을 확보했고 곧 NanoGPT 훈련을 시작할 예정입니다.

진행 상황이 있으면 계속 업데이트하겠습니다.

## 2025년 7월 13일

nanoGPT를 187MB의 역사적 텍스트 데이터로 훈련했습니다.

## 2025년 7월 15일

두 번째 훈련을 위해 텍스트 다운로드를 시작했습니다. Internet Archive에서 모든 자료를 받으며, 시기를 1800~1875년으로 확장했습니다. 다양한 텍스트를 얻으려면 Internet Archive의 주제 및 검색 필터로 출판 위치, 시기, 주제를 지정할 수 있습니다.

![검색 필터](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

Internet Archive에서 약 500개의 txt 파일을 다운로드했고, 공백, 구텐베르크 헤더 등 불필요한 부분을 삭제해 정제한 뒤 약 500MB의 데이터가 남았습니다. 아주 작은 데이터셋이지만 지난번 187MB로 훈련했으니, 이번에 두 번째 모델을 훈련한 뒤에는 출력 결과에 적어도 뚜렷한 차이가 있을 것으로 기대합니다. 이번 모델은 더 일관성 있는 문장 생성이 가능하길 바랍니다. 물론 보장된 것은 아니지만, 지난번보다 데이터가 많으니 희망적입니다.

제 하드웨어로도 충분히 할 수 있습니다. 이 과정에서 더 큰 데이터셋을 시도하기 전에 개선점을 직접 확인할 수 있다는 점도 좋습니다. GPU 대여 전에 데이터셋을 최대한 엄선하고 정제하고 싶습니다. 문제 중 하나는 정제 과정인데, 많은 txt 파일에 의미 없는 글자들이 섞여 있습니다. 사용한 스크립트로 어느 정도 정제가 되지만 100%는 아닙니다.

오늘 이 데이터셋으로 훈련할 예정이며 4~5시간 정도 걸릴 것으로 보입니다. 완료 후 테스트해보고 결과를 공유하겠습니다. 프로젝트에 관심 가져주신 모든 분들께 감사드리며, OCR 자료 링크를 보내주신 분들도 계셔서 정말 감사합니다! 더 많은 분들이 직접 데이터셋으로 실험해보시길 바랍니다.

### 훈련 업데이트

435MB(1억 8백만 토큰) 코퍼스로 훈련을 시작했으며, 현재까지 순조롭습니다. 첫 2800회 반복에서 트레인 로스가 10.9에서 4.9로 떨어졌습니다. 약 8~9시간 후 완료될 것으로 예상합니다. 완료되면 다시 업데이트하겠습니다.

## 2025년 7월 17일 오전 2:13

두 번째 모델 훈련이 끝났습니다. 제 4060 GPU로 약 8시간 40분(시간당 3,900회 반복), 총 33,000회 반복(5에폭)이 소요되었습니다. 최종 트레인 로스는 3.73이었습니다. 출력 결과가 놀라울 정도로 좋아져, 이제 진짜 19세기 스타일의 일관성 있는 문장을 생성합니다.

## 2025년 7월 28일

v0.5 버전을 Hugging Face에 업로드했습니다. [여기서 확인](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)하실 수 있습니다. 저장소를 다운로드해 로컬에서 실행할 수 있습니다. 안타깝게도 nanoGPT는 HuggingFace와 기본적으로 호환되지 않아, 모델을 직접 다운로드해 로컬에서 실행해야 합니다.

또한 다음 훈련을 위해 데이터를 추가로 선별할 계획이며, 추론 능력 향상을 위해 데이터가 5~10배 더 필요할 것으로 생각합니다.

# V0 모델의 동작 및 한계

초기 프롬프트에서는 1800년대의 언어와 행동으로 응답하는 모델이 보입니다. 예를 들어, "Who art Henry?"라는 질문에 모델이 "I know that man, I have did not a black, the storm."라고 대답했는데, 문장은 말이 안 되지만 LLM이 인물에 대한 질문임을 인식하고 있음을 알 수 있습니다.




![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

현대 개념에 대한 언급이 없으며, 출력물은 대부분 1800년대의 단어와 어투를 포함하고 있습니다.

아직도 많은 개선이 필요하며, 187MB로 학습하면 복잡한 추론을 할 수 있는 모델이 나오지 않습니다.

현재는 완전한 문장 구조가 부족하고 전반적으로 말이 되지 않는 문장들을 생성하지만, 이런 현상은 학습 데이터 크기 상 정상입니다.

# V0.5 모델 동작 및 한계

이전 모델에 비해 상당히 개선되었습니다. 문체와 어휘가 빅토리아 시대 스타일이고, 거의 모든 문장이 문법적으로 맞고 구두점도 적절합니다. 그리고 이 모델은 처음부터 학습했기 때문에 1800년대 주제에만 집중합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

사실과 다른 환각이 많습니다. 세부사항(날짜, 사건, 역사적 인물 등) 대부분(100%)이 만들어진 내용입니다. 또한 문장들끼리 연결이 잘 안 되고, 가끔 2개 문장이 서로 연관되어 있지만 그 이상은 없습니다. 또 다른 문제로는 "Digitized by Google"과 같은 하단 문구가 종종 출력되는데, 다음 학습 때는 텍스트를 더 철저히 정리해야 할 것 같습니다. 전반적으로 결과에 매우 만족하며, 아직 LLM 수준은 아니지만 문장 생성기로서의 역할은 충분합니다.

많은 것을 배우고 있고, 앞으로 몇 주 동안 더 나은 방법을 고민해볼 예정입니다. 곧 파일도 업로드하겠습니다!

# 앞으로의 계획

(완료) 0.5 버전 작업을 시작할 예정이며, 50권 대신 500~600권의 책을 활용해 학습할 계획입니다. 현재는 1800~1850년 런던에서 출판된 책들로 nanoGPT를 학습 중입니다. 도전 과제는 찾은 책들이 현대적으로 수정되었거나 해석된 버전이 아닌, 제가 정한 기간에 출판된 원본임을 확실히 해야 한다는 점입니다.

더 큰 말뭉치(코퍼스)로 새로운 모델(v1)을 학습하고 싶습니다. v0.5에 사용한 데이터보다 5~10배 많은 분량이 목표입니다. Selective Temporal Training만으로 추론 능력이 생기는지 실험해보고 싶고, 이는 역사적 데이터의 한계 때문에 어려울 수 있지만 도전해볼 생각입니다. 앞으로 몇 주간 5~10GB의 데이터를 큐레이션하려고 합니다. 깨끗하고 고품질의 데이터를 확보하고 GPU만 대여하면 진전이 있을 것이라 믿습니다.

# 프로젝트 사용법

이 프로젝트는 주로 역사적 데이터를 큐레이션하고, 학습용으로 준비하며, 토크나이저를 만드는 과정에 초점을 둡니다. 전체 LLM 학습 과정은 다루지 않으니, 해당 부분은 Andrej Karpathy의 nanoGPT를 참고하세요.

# 1단계: 역사적 텍스트 수집 및 준비

선택한 기간(예: 1800~1850년 런던)의 퍼블릭 도메인 책, 문서 등의 .txt 파일을 수집합니다.

필요하다면 download_texts_improved.py를 사용하여 책을 다운로드할 수 있습니다.

스크립트로 또는 수작업으로 Project Gutenberg의 머리말/꼬리말, 현대 주석, OCR 오류 등을 제거하여 텍스트 파일을 정리합니다.

prepare_dataset.py를 사용하면 충분합니다.

# 2단계: 커스텀 토크나이저 빌드

정리한 데이터에 대해 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행합니다.
이 과정을 통해 vocab.json과 merges.txt가 생성됩니다.

이 파일들은 모델의 어휘 및 병합 규칙을 정의합니다.

# 3단계: 모델 학습(nanoGPT)

학습 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참고하세요.

원한다면 다른 LLM을 써도 되지만 저는 nanoGPT를 사용했습니다.

# FAQ

## Selective Temporal Training이란?

Selective Temporal Training(STT)은 모든 학습 데이터를 특정한 역사적 시기에만 한정해 엄선하는 기계학습 방법론입니다. 이는 현대 개념의 영향을 받지 않고 해당 시대의 언어와 지식을 모델링하기 위해서입니다. 예를 들어, 현재의 v0.5 모델은 1800~1875년 데이터만으로 처음부터 학습되었으며, 그 결과 해당 시대의 언어 스타일과 역사적 맥락을 반영합니다.

## 그냥 파인튜닝이나 LoRA를 쓰지 않는 이유는?

이 프로젝트의 목표는 현대적 편견에서 벗어난 언어모델을 만드는 것입니다. 예를 들어 GPT-2를 파인튜닝하면 이미 사전 학습된 정보는 지워지지 않습니다. 처음부터 학습하면 언어 모델이 옛것인 척하는 것이 아니라 실제로 옛날 모델이 되는 것입니다. 지금의 목표는 1800~1850년 런던에서 출판된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 학습에 사용한 데이터는 어떤 종류입니까?

1800~1850년 런던의 책, 법률 문서, 신문, 기타 문서를 사용하고 있습니다. 링크된 목록에는 약 200개가 있지만 첫 학습에는 50개 파일, 약 187MB만 사용했습니다. 문서 목록은 아래에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0버전 모델의 크기는?

이 모델은 아직 매우 작으며, 재미 삼아 현대 소스 없이 엄격한 학습 규칙을 따르고 있습니다. 현재 파라미터 수는 약 1,600만 개이며, 더 많은 옛날 텍스트를 수집해 다음 모델 학습을 시작할 예정입니다. 진행 상황은 계속 업데이트하겠습니다.

## 학습 사양?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---