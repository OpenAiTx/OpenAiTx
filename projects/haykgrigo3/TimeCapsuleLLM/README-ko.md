<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
특정 시기의 데이터만으로 학습된 LLM으로 현대적 편향을 줄입니다.

AI 모델이 단순히 역사적 인 척하는 것이 아니라 실제로 역사적이었다면 어떨까요.

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 제작되었습니다. 핵심 학습 스크립트와 모델 아키텍처는 그의 작업입니다.

# 프로젝트 목표

TimeCapsule LLM은 특정 시간대에 작성된 텍스트만으로 학습하는 실험적 프로젝트입니다. 목표는 특정 역사 시대의 세계관과 언어를 시뮬레이션하는 것입니다.

# 파인튜닝만으로는 충분하지 않은 이유

사전 학습된 모델을 파인튜닝만 한다면, LLM은 여전히 현대 개념을 알게 됩니다. 물론 완전한 현대적 편향 제로를 달성하는 것은 어렵지만, 최대한 이에 가까워지고자 합니다. 현대적 편향이 전혀 없는 모델을 만들려면 처음부터 모델을 학습해야 합니다.

# 기대되는 결과

완성 후에는 이 모델이 현대 개념을 알지 못하고, 학습된 내용 이상으로 추론하지 못하길 바랍니다. 현대 개념/어휘를 인식하지 않아야 하며, 현대 지식을 환각하지 않기를 기대합니다.

# 진행 상황 업데이트

## 2025년 7월 9일

학습 시기를 1800-1850년, 지역은 런던으로 설정했습니다.

텍스트, 책, 문서 목록을 수집했습니다.

지금까지 50개의 txt 파일을 확보했으며 곧 NanoGPT로 학습을 시작할 예정입니다.

진행 상황이 있을 때마다 이곳에 업데이트하겠습니다.

## 2025년 7월 13일

nanoGPT를 187MB의 역사적 텍스트 데이터로 학습시켰습니다.

## 2025년 7월 15일

두 번째 학습을 위해 텍스트 다운로드를 시작했습니다. 모든 자료를 Internet Archive에서 받고 있으며, 학습 시기를 1800-1875년으로 확장했습니다. 다양한 텍스트를 얻기 위해 Internet Archive의 출판 위치, 시기, 주제별 검색 및 필터를 사용할 수 있습니다.

![검색 필터](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

Internet Archive에서 약 500개의 txt 파일을 다운로드했고(공백, 구텐베르크 헤더 등 삭제) 약 500MB의 데이터를 얻었습니다. 매우 작은 데이터셋이지만 지난번 187MB로 학습했던 것보다는 확실히 차이가 있을 것이라고 생각합니다. 이번에는 더 일관성 있는 문장이 생성되길 기대합니다. 물론 여전히 작은 데이터셋이기 때문에 보장할 수는 없지만 지난번보다는 많습니다.

제 하드웨어로도 충분히 가능할 것 같고, 더 큰 데이터셋으로 넘어가기 전에 어느 정도 개선점을 직접 확인할 수 있을 것 같아 좋습니다. 곧 GPU를 임대할 계획이지만, 그 전에 데이터셋을 최대한 선별하고 깨끗하게 만드는 것이 목표입니다. 문제 중 하나는 정제인데, 많은 txt 파일에 잡문이 섞여 있습니다. 제가 사용한 정제 스크립트가 효과는 있지만 100% 완벽하지는 않습니다.

오늘 이 데이터셋으로 학습할 예정이고, 약 4-5시간 걸릴 것으로 보입니다. 완료 후 테스트를 하고 다시 업데이트하겠습니다. 프로젝트를 관심 있게 지켜보시는 모든 분들께 감사드리며, OCR 리소스 링크를 주신 분도 계셔서 정말 감사합니다! 더 많은 분들이 직접 데이터셋으로 실험해보시길 바랍니다.

### 학습 업데이트

435MB(1억 800만 토큰) 코퍼스로 학습을 시작했고, 현재까지 순조롭게 진행되고 있습니다. 학습 손실이 2800 반복에서 10.9에서 4.9로 떨어졌습니다. 약 8~9시간 정도 걸릴 것으로 예상합니다. 완료 후 추가 업데이트를 게시하겠습니다.

## 2025년 7월 17일 오전 2:13

두 번째 모델의 학습이 완료되었습니다. 4060 그래픽카드로 약 8시간 40분(시간당 3,900 반복)에 33,000 반복(5 에폭)을 진행했습니다. 최종 학습 손실은 3.73입니다. 출력 결과가 놀라울 정도로 좋아져서, 진짜 19세기 스타일의 일관성 있는 문장이 생성됩니다.

# V0 모델 동작 및 한계

초기 프롬프트에서 1800년대의 언어와 행동으로 반응하는 모습을 보입니다. 예를 들어 "Who art Henry?"라고 묻자 "I know that man, I have did not a black, the storm."이라고 답했습니다. 문장 자체는 말이 안 되지만, LLM이 인물에 대한 질문임을 인식한 것입니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

현대적 개념이 등장하지 않고, 출력에는 주로 1800년대의 어휘와 문장 구조가 나타납니다.

아직 할 일이 많으며, 187MB로 학습한 모델은 복잡한 추론이 필요한 텍스트를 생성하지 못합니다.

현재는 완전한 문장 구조가 부족하고, 전체적으로 말이 되지 않는 문장을 내놓지만, 이는 학습 데이터 크기상 정상입니다.

# V0.5 모델 동작 및 한계

이전 모델에 비해 상당한 개선이 이루어졌습니다. 문체와 어휘는 빅토리아 시대풍이며, 거의 모든 문장은 문법적으로 올바르고 적절한 구두점이 사용되었습니다. 그리고 이번에도 처음부터 훈련된 모델이기 때문에 1800년대의 주제에 충실합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

많은 사실적 환각이 있습니다. 대부분(거의 100%)의 세부사항(날짜, 사건, 역사적 인물 등)은 만들어낸 것입니다. 또한 문장들끼리 서로 연결성이 없으며, 가끔 2개의 문장이 연관될 때도 있지만 그 이상은 아닙니다. 또 다른 문제로는 가끔 "Digitized by Google"이라는 꼬리말이 불쑥 나타나는 경우가 있는데, 다음번 훈련 때는 텍스트를 잘 정제해야겠다고 생각합니다. 전반적으로 결과에 매우 만족하며, 아직 LLM에는 못 미치지만 확실히 문장 생성기는 맞습니다.

많은 것을 배우고 있으며, 앞으로 몇 주간 개선해야 할 점을 파악해 나갈 예정입니다. 곧 파일도 업로드하겠습니다!

# 향후 계획

(완료) 버전 0.5 작업을 시작할 예정입니다. 50권의 책을 사용해 훈련하는 대신, 이상적으로는 500~600권을 사용할 것입니다. 현재는 1800~1850년, 특히 런던의 책들을 사용해 nanoGPT를 훈련 중입니다. 제가 찾은 책들이 개정판이 아니거나 현대적 해석이 들어가지 않은, 제가 정한 시기에 출판된 원본임을 확인하는 것이 어려운 점입니다.

훨씬 더 큰 말뭉치를 사용해 새로운 모델(v1)을 훈련하고 싶습니다. v0.5에 사용한 것보다 5~10배 더 큰 규모가 될 것입니다. 선택적 시간 훈련(Selective Temporal Training)만으로 추론 능력이 나타날 수 있는지 확인하는 것이 목표이며, 이는 더 어려운 과제이고 역사적 데이터의 한계 때문에 가능할지 확신할 수 없습니다. 앞으로 몇 주간 5~10GB의 말뭉치 데이터를 선별해 볼 계획입니다. 깨끗하고 고품질의 데이터를 모으고 GPU를 임대할 수 있다면 진전이 있을 것이라 생각합니다.

# 이 프로젝트 사용 방법

이 프로젝트는 주로 역사적 데이터를 선별하고, 훈련에 적합하게 준비하며, 토크나이저를 만드는 데 중점을 둡니다. 전체 LLM 훈련 과정은 다루지 않으니, 이에 대해서는 Andrej Karpathy의 nanoGPT를 참고하시기 바랍니다.

# 1단계: 역사적 텍스트 수집 및 준비

선택한 시기(예: 런던 1800-1850)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 수집합니다.

필요하다면 download_texts_improved.py를 사용해 도서를 다운로드할 수 있습니다.

스크립트나 수작업으로 프로젝트 구텐베르크의 헤더/푸터, 현대 주석, OCR 오류 등을 제거하여 텍스트 파일을 정제합니다.

prepare_dataset.py를 사용하면 무난하게 처리할 수 있습니다.

# 2단계: 맞춤형 토크나이저 구축

정제된 데이터를 train_tokenizer.py 또는 train_tokenizer_hf.py로 실행합니다.
이렇게 하면 vocab.json과 merges.txt가 생성됩니다.

이 파일들이 모델의 어휘와 병합 규칙을 정의합니다.

# 3단계: 모델 훈련(nanoGPT)

훈련 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참고하세요.

원한다면 다른 LLM도 훈련할 수 있지만, 저는 nanoGPT를 사용했습니다.

# FAQ

## 선택적 시간 훈련(Selective Temporal Training)이란?

선택적 시간 훈련(STT)은 모든 훈련 데이터를 특정 역사적 시기에 맞게 엄선하는 기계학습 방법론입니다. 이렇게 하면 해당 시대의 언어와 지식을 현대적 개념의 영향 없이 모델링할 수 있습니다. 예를 들어, 현재의 모델(v0.5)은 1800~1875년의 데이터만으로 처음부터 훈련되어 그 시기의 언어적 스타일과 역사적 맥락이 드러나는 결과를 냅니다.

## 그냥 파인튜닝이나 LoRA를 쓰지 않는 이유는?

이 프로젝트에서는 현대적 편향이 전혀 없는 언어 모델을 만들고자 합니다. GPT-2 같은 모델을 파인튜닝하면 이미 사전훈련된 정보가 남아 있게 됩니다. 처음부터 훈련하면 언어 모델이 옛것인 척하는 것이 아니라 실제로 옛것이 됩니다. 현재 목표는 1800~1850년 런던에서 출간된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 훈련에 사용했나요?

1800~1850년 런던의 도서, 법률 문서, 신문, 기타 기록물을 사용했습니다. 링크한 목록에는 약 200개가 있지만, 첫 훈련에서는 50개 파일(약 187MB)만 사용했습니다. 문서 목록은 다음에서 확인할 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 버전 0 모델의 크기는 어느 정도인가요?

이 모델은 매우 작으며, 재미 삼아 엄격하게 현대 자료를 배제해 훈련 중입니다. 약 1600만 개의 파라미터가 있지만, 더 많은 옛 텍스트를 모아 새로운 모델 훈련을 시작할 예정입니다. 진행 상황은 계속 공유하겠습니다.

## 훈련 사양은?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---