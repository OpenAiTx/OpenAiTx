
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

# TimeCapsule LLM
특정 시대의 데이터로만 학습하여 현대적 편향을 줄인 LLM.

AI 모델이 단순히 과거를 흉내내는 것이 아니라 실제로 과거의 모델이라면 어떨까요?

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 구축되었습니다. 핵심 학습 스크립트와 모델 아키텍처는 그의 작업입니다. 

# 프로젝트 목표
TimeCapsule LLM은 특정 시간대에 작성된 텍스트만을 학습하는 실험적 프로젝트입니다. 목표는 특정 역사적 시대의 세계관과 언어를 시뮬레이션하는 것입니다.

# 왜 파인튜닝만으로는 충분하지 않은가

이미 사전학습된 모델을 파인튜닝만 하면, LLM은 여전히 현대 개념을 알게 됩니다. 물론 완전히 현대적 편향을 없애는 것은 어렵지만 최대한 이 목표에 가까워지고 싶습니다. 현대적 편향을 없애려면 모델을 처음부터 새로 학습해야 합니다.

# 기대되는 결과

완성되면, 이 모델은 현대 개념을 알지 못하고, 학습된 범위를 넘어 추론하지 못해야 합니다. 현대적 개념/어휘를 인식하지 않아야 하며, 현대 지식에 대한 환각도 없어야 합니다.

# 진행 상황 업데이트

## 2025년 7월 9일

학습 시간대를 1800-1850년, 지역은 런던으로 설정했습니다.

텍스트, 책, 문서 목록을 수집했습니다.

현재까지 50개의 txt 파일을 확보했고 곧 NanoGPT 훈련을 시작할 예정입니다.

진행 상황이 있을 때마다 업데이트하겠습니다.

## 2025년 7월 13일

NanoGPT를 187MB 분량의 역사적 텍스트 데이터로 훈련했습니다.

## 2025년 7월 15일

두 번째 학습을 위해 텍스트 다운로드를 시작했습니다. Internet Archive에서 모든 데이터를 받고 있으며, 기간을 1800-1875년으로 확장했습니다. 다양한 텍스트 확보를 위해 Internet Archive의 주제 및 검색 필터를 이용해 출판 위치, 기간, 주제로 필터링할 수 있습니다.

![검색 필터](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

Internet Archive에서 약 500개의 txt 파일을 다운로드했고, 공백 삭제, Gutenberg 헤더 제거 등으로 정리한 후 약 500MB 데이터가 남았습니다. 아주 작은 데이터셋이지만 지난번에는 187MB로 훈련했으니 이번에 두 번째 모델을 훈련하면 출력에서 눈에 띄는 변화가 있을 것으로 기대합니다. 이번 모델은 최소한 좀 더 일관성 있는 문장, 어느 정도 의미가 통하는 문장을 생성하길 바랍니다. 물론 보장할 순 없습니다. 데이터셋이 아주 작으니까요. 그래도 지난번보다는 많습니다.

이 정도는 제 자체 하드웨어로 가능할 것 같고, 큰 데이터셋으로 넘어가기 전에 개선점을 볼 수 있을 것 같아 좋습니다. 큰 데이터셋으로 가려면 GPU를 임대해야 하니 그 전에 데이터셋을 최대한 정제하고 깨끗하게 만들 계획입니다. 문제 중 하나가 정제인데, 많은 txt 파일에 잡다한 내용이 섞여 있습니다. 제가 사용한 정제 스크립트들이 효과는 있지만 100% 완벽하진 않습니다.

오늘 이 데이터셋을 훈련할 예정이고 4~5시간 정도 소요될 것 같습니다. 완료 후 테스트해보고 업데이트하겠습니다. 제 프로젝트를 확인해주신 모든 분들께 다시 한 번 감사드리며, OCR 자료 링크를 주신 분들도 계셔서 감사합니다! 더 많은 분들이 직접 데이터셋을 실험해보시길 바랍니다.


## 2025년 8월 12일

버전 1이 완성되었습니다. 이 버전은 Phi 1.5(700M 파라미터)를 사용하며 약 7000개의 텍스트로 구성된 데이터셋에서 학습되었습니다. 이 모델의 주요 개선점은 때때로 실제 이름과 역사적 사건을 참조할 수 있다는 것입니다. 버전 0과 0.5는 이를 할 수 없었고, "In the year 1821"과 같은 프롬프트를 주면 출력은 실제로 일어나지 않은 환상적인 내용뿐이었습니다. 버전 1에서의 예시는 다음과 같습니다:

내 프롬프트: It was the year of our Lord 1834,

출력: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

처음에는 우연의 일치라고 생각했지만 이것을 보세요: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### 훈련 업데이트

435MB(108 M 토큰) 코퍼스에서 훈련을 시작했으며, 지금은 순조롭게 진행되고 있습니다. 트레인 로스가 처음 2800번 반복에서 10.9에서 4.9로 떨어졌습니다. 완료까지 약 8~9시간 정도 걸릴 것으로 예상합니다. 완료되면 또 업데이트를 올리겠습니다.

## 2025년 7월 17일

두 번째 모델의 훈련이 끝났습니다. 4060으로 약 8시간 40분(3,900 반복/시) 동안 33,000번 반복(5 에포크)을 진행했습니다. 최종 트레인 로스는 3.73이었습니다. 출력이 놀랍게도 좋아져서 이제 실제로 일관성 있는 19세기 스타일 문장을 생성합니다.

## 2025년 7월 28일

v0.5를 Hugging Face에 업로드했습니다. [여기에서 확인하세요](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) 원하신다면 다운로드 가능합니다. 이제 내 레포를 다운로드해서 로컬에서 실행할 수 있습니다. 불행히도 nanoGPT는 HuggingFace와 네이티브하게 작동하지 않으니, 모델을 다운로드해서 직접 실행해야 합니다.

또한 다음 훈련을 위해 데이터 큐레이션을 시작할 예정입니다. 추론 능력을 얻으려면 데이터가 5~10배 더 필요할 것으로 보입니다.

## 2025년 8월 2일

곧 버전 1 작업을 시작할 예정입니다. nanoGPT의 아키텍처에서 더 현대적인 것으로 전환해야 합니다. 염두에 둔 오픈소스 LLM 아키텍처는 OpenLLaMA v3, Phi-2, Qwen 1.5B 등이 있습니다. V1으로의 도약을 지원하려면 훨씬 더 크고 다양한 데이터셋을 신중하게 큐레이션해야 합니다. 최소 5GB의 깨끗한 학습 데이터가 필요합니다.

# V0 모델의 동작 및 한계

초기 프롬프트에서는 모델이 1800년대 언어와 행동으로 반응하는 모습을 보입니다. 예를 들어 "Who art Henry?"라고 프롬프트를 주면 "I know that man, I have did not a black, the storm."이라고 답했습니다. 이 문장은 말이 안 되지만 LLM이 내가 사람에 대해 묻고 있다는 것은 인식하고 있습니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

현대 개념에 대한 언급은 없으며, 출력에는 주로 1800년대의 단어와 표현이 포함됩니다.

아직 많은 작업이 필요하며, 187MB 데이터로 학습한 모델로는 복잡한 추론이 담긴 텍스트를 생성할 수 없습니다.

현재로서는 전체 문장 구조가 부족하고 전반적으로 말이 안 되는 문장들이 생성되지만, 이는 훈련 데이터 크기에서는 정상입니다.

# V0.5 모델 동작 및 한계

이전 모델과 비교했을 때 꽤 괜찮은 개선입니다. 문체와 어휘는 빅토리아 시대 스타일이고 거의 모든 문장이 문법적으로 올바르며 적절한 구두점이 있습니다. 그리고 이번에도 처음부터 훈련했기 때문에 1800년대의 주제에만 집중합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

사실과 다른 환각이 많이 발생합니다. 상세 내용(날짜, 사건, 역사적 인물 등) 대부분(거의 100%)이 만들어진 것입니다. 또한 문장들끼리 서로 연결이 잘 안 되고, 가끔 두 문장이 연관될 때도 있지만 그 이상은 아닙니다. 또 다른 문제는 가끔 “Digitized by Google”과 같은 꼬리말이 등장하는 점인데, 다음 훈련 때는 꼭 텍스트 정제에 신경 써야 할 것 같습니다. 전반적으로 결과에 매우 만족하고 있으며, 아직 LLM까지는 멀었지만 확실히 문장 생성기는 맞습니다.

많은 것을 배우고 있고, 앞으로 몇 주 동안 더 잘해야 할 부분을 알아낼 계획입니다. 곧 파일도 업로드하겠습니다!

# V1 모델 동작 및 한계

곧 예시 출력도 업로드하고, 동일한 프롬프트로 세 가지 모델을 비교해볼 예정입니다. 또한 지난 버전처럼 V1도 huggingface에 업로드할 예정이며, 제 huggingface 계정은 여기서 찾을 수 있습니다: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# 향후 계획

(완료됨) 0.5 버전을 개발할 예정입니다. 50권이 아닌 500-600권의 책으로 훈련할 계획입니다. 현재는 1800-1850년 런던에서 출판된 책들을 이용해 nanoGPT를 훈련 중입니다. 찾은 책들이 개정판이거나 현대 해설이 들어간 것이 아닌, 제가 선택한 시기에 출판된 원본임을 확인하는 과정이 도전입니다.

더 큰 말뭉치(아마 v0.5의 5-10배 규모)로 새로운 모델(v1)을 훈련하고 싶습니다. Selective Temporal Training만으로 추론 능력이 나타나는지 실험해보고 싶고, 이는 더 어려운 작업일 뿐만 아니라 역사 데이터 한계로 가능할지조차 확신할 수 없습니다. 앞으로 몇 주간 5-10GB 정도의 데이터셋을 선별해보려고 합니다. 만약 깨끗하고 고품질 데이터를 확보하고 GPU도 임대할 수 있다면 진전이 있을 것이라 믿습니다.

# 프로젝트 사용 방법

이 프로젝트는 주로 역사적 데이터를 선별·정제하고 훈련 데이터로 준비하며 토크나이저를 만드는 데 중점을 둡니다. 전체 LLM 훈련 과정은 다루지 않으니, 그 부분은 Andrej Karpathy의 nanoGPT를 참고하세요.

# 1단계: 역사 텍스트 수집 및 정제

선택한 시기의 공개 도메인 도서, 문서 등의 .txt 파일을 수집하세요(예: 1800-1850년 런던).

필요하다면 download_texts_improved.py를 사용해 책을 다운로드할 수 있습니다.

프로젝트 구텐베르크의 머리말/꼬리말, 현대 주석, OCR 오류 등은 스크립트나 수작업으로 제거해 텍스트 파일을 정제하세요.

prepare_dataset.py를 사용하면 무난합니다.

# 2단계: 맞춤형 토크나이저 구축

정제된 데이터에 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.
이 과정을 거치면 vocab.json과 merges.txt 파일이 생성됩니다.
이 파일들은 모델의 vocab과 병합 규칙을 정의합니다

# 3단계: 모델 훈련하기 (nanoGPT)

훈련 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참고하세요.

원한다면 다른 LLM을 훈련해도 되지만, 저는 nanoGPT를 사용했습니다

# FAQ

## 선택적 시계열 훈련(Selective Temporal Training)이란 무엇인가요?

선택적 시계열 훈련(STT)은 모든 훈련 데이터가 특정 역사적 시기에 한정되어 엄선되는 머신러닝 방법론입니다. 이는 해당 시대의 언어와 지식을 현대 개념의 영향 없이 모델링하기 위해서입니다. 예를 들어, 현재 모델(v0.5)은 1800-1875년 데이터만으로 훈련되었으며, 파인튜닝 없이 처음부터 훈련되어 그 시대의 언어 스타일과 역사적 맥락을 반영하는 결과를 냅니다.

## 그냥 파인튜닝이나 LoRA를 사용하지 않는 이유는 무엇인가요?

이 프로젝트에서는 현대적 편향이 없는 언어 모델을 만들고자 합니다. GPT-2 같은 모델을 파인튜닝하면 이미 사전학습된 정보가 남아있으므로 완전히 사라지지 않습니다. 처음부터 훈련하면 언어 모델이 옛것인 척하는 것이 아니라 실제로 그렇습니다. 지금 목표는 1800~1850년 런던 출판물의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 훈련에 사용했나요?

1800~1850년 런던의 책, 법률문서, 신문, 기타 글을 사용했습니다. 링크된 목록에는 약 200개가 있지만 첫 훈련에는 50개 파일, 약 187MB만 사용했습니다. 문서 목록은 다음에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 모델 크기는 얼마나 되나요?

V0: 1,600만 파라미터

V0.5: 1억 2,300만 파라미터

V1: 7억 파라미터

# 훈련 사양은?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
램: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---