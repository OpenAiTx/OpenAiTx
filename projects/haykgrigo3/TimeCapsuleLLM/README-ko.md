
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
특정 시대의 데이터만으로 학습되어 현대적 편향을 줄인 LLM.

AI 모델이 단순히 역사적 인물인 척하는 것이 아니라 실제로 그 시대의 지식을 가진다면 어떨까요?

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 위에 구축되었습니다. 핵심 학습 스크립트와 모델 아키텍처는 그의 작업입니다.

# 프로젝트 목표

TimeCapsule LLM은 특정 시대에 작성된 텍스트만으로 훈련되는 실험적 프로젝트입니다. 목표는 특정 역사 시대의 세계관과 언어를 시뮬레이션하는 것입니다.

# 파인튜닝만으로는 충분하지 않은 이유

사전학습된 모델을 파인튜닝만 하면, LLM은 여전히 현대 개념을 알고 있게 됩니다. 물론 완전한 현대적 편향 제로는 어렵지만, 저는 최대한 이 목표에 다가가고 싶습니다. 현대적 편향을 완전히 없애려면, 모델을 처음부터 새로 학습해야 합니다.

# 기대되는 결과

완성 시, 이 모델은 현대 개념을 알지 못하고 학습한 범위 밖으로 추론할 수 없을 것입니다. 현대적 개념/어휘를 인식하지 못해야 하며, 현대 지식에 대한 환각도 일으키지 않기를 기대합니다.

# 진행 상황 업데이트

## 2025년 7월 9일

1800~1850년, 지역: 런던으로 시대를 정했습니다.

텍스트, 서적, 문서 목록을 수집했습니다.

현재까지 50개의 txt 파일을 확보했고 곧 NanoGPT 학습을 시작할 예정입니다.

진행이 있을 때마다 계속 업데이트하겠습니다.

## 2025년 7월 13일

nanoGPT로 187MB의 역사적 텍스트 데이터를 학습시켰습니다.

## 2025년 7월 15일

두 번째 학습을 위해 텍스트 다운로드를 시작했습니다. 모든 자료는 Internet Archive에서 얻고 있으며, 기간을 1800~1875년으로 확장했습니다. 다양한 텍스트를 얻으려면 Internet Archive의 주제 및 검색 필터를 활용해 출판 위치, 시대, 주제를 지정할 수 있습니다.

![검색 필터](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

Internet Archive에서 약 500개의 txt 파일을 다운로드했고, (공백 삭제, 구텐베르크 헤더 등 정리 후) 약 500MB 데이터가 남았습니다. 소규모 데이터셋이지만 지난번 187MB로도 학습했으니, 이번엔 학습 후 출력에서 적어도 뭔가 눈에 띄는 차이가 있을 것이라 기대합니다. 이번 모델이 조금 더 일관성 있는 문장을 생성해주길 바랍니다. 물론 여전히 아주 작은 데이터셋이기 때문에 보장할 수는 없습니다. 하지만 지난번보다는 많은 데이터입니다.

이 정도면 내 하드웨어로도 충분히 가능할 것 같고, 더 큰 데이터셋을 위해 GPU 임대를 고민하기 전에 개선점을 볼 수 있기를 기대합니다. 다만 데이터 정제가 고민인데, 많은 txt 파일에 의미 없는 내용이 섞여 있습니다. 정제 스크립트는 어느 정도 작동하지만 100% 완벽하진 않습니다.

오늘 이 데이터셋으로 학습할 예정이며, 약 4~5시간이 걸릴 것으로 예상합니다. 완료 후 테스트해서 업데이트하겠습니다. 프로젝트를 살펴봐 주신 분들께 다시 한 번 감사드립니다. OCR 자료 링크도 보내주신 분들이 계셔서 정말 감사합니다! 더 많은 분들이 자신만의 데이터셋으로 실험해 보셨으면 좋겠습니다.

## 2025년 7월 28일

v0.5를 Hugging Face에 업로드했습니다. [여기서 확인하세요](https://huggingface.co/haykgrigorian/TimeCapsuleLLM). 내 리포를 다운로드해 로컬에서 실행할 수 있습니다. 아쉽게도 nanoGPT는 HuggingFace와 네이티브로 호환되지 않으니, 모델을 직접 다운로드해 로컬에서 실행해야 합니다.

또 다음 학습을 위해 데이터 큐레이션을 시작할 예정이며, 추론 능력을 얻으려면 데이터가 5~10배는 더 필요할 것이라 생각합니다.

### 학습 업데이트

435MB(1억 800만 토큰) 코퍼스에서 학습을 시작했으며, 지금까지 순조롭게 진행되고 있습니다. 학습 손실이 2800회 반복에서 10.9에서 4.9로 떨어졌습니다. 완성까지 8~9시간 정도 걸릴 것으로 예상합니다. 완료되면 다시 업데이트하겠습니다.

## 2025년 7월 17일 2:13AM

두 번째 모델 학습이 끝났으며, 4060 그래픽카드로 약 8시간 40분(시간당 3,900 반복) 동안 33,000회 반복(5에폭)을 수행했습니다. 최종 학습 손실은 3.73이었습니다. 출력물이 놀라울 정도로 좋아졌고, 실제로 19세기 스타일의 일관성 있는 문장을 생성합니다.

# V0 모델 동작 및 한계

초기 프롬프트에서는 모델이 1800년대의 언어와 행동을 보입니다. 예를 들어, "Who art Henry?"라는 질문에 "I know that man, I have did not a black, the storm."이라고 답했는데, 이 문장이 말이 되진 않지만 LLM이 인물에 대해 묻고 있음을 인식하고 있습니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)
현대적인 개념에 대한 언급이 없고, 출력물은 대부분 1800년대의 단어와 표현을 포함하고 있습니다.

아직 많은 작업이 필요하며, 187MB로 학습한다고 해서 복잡한 추론을 수행하는 모델이 만들어지지는 않습니다.

현재로서는 완전한 문장 구조가 부족하고 전반적으로 말이 안 되는 문장들을 생성하지만, 이는 학습 데이터 크기상 정상입니다.

# V0.5 모델 동작 및 한계

이전 모델에 비해 훨씬 개선되었습니다. 문체와 어휘가 빅토리아 시대풍이며 거의 모든 문장이 문법적으로 올바르고 구두점도 정확합니다. 그리고 이 모델은 처음부터 새로 학습되어 1800년대 주제에만 집중합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

사실과 다른 내용(환각)이 많습니다. 대부분(거의 100%)의 세부사항(날짜, 사건, 역사적 인물 등)이 지어낸 것입니다. 또한 문장들이 서로 연결되어 있지 않으며, 가끔 두 문장 정도만 연관이 있을 뿐 그 이상은 없습니다. 또 다른 문제는 때때로 “Digitized by Google” 같은 푸터가 등장하는데, 다음 학습 때는 텍스트를 더 철저히 정제해야 할 것 같습니다. 전체적으로 결과에 매우 만족하며, 아직 LLM 수준은 아니지만 문장 생성기 역할은 충분합니다.

많은 것을 배우고 있으며, 앞으로 몇 주간 무엇을 더 개선해야 할지 고민해 볼 예정입니다. 곧 파일도 업로드하겠습니다!

# 향후 계획

(완료) 버전 0.5 작업을 시작할 예정이며, 50권이 아닌 이상적으로 500~600권의 책을 이용해 학습할 계획입니다. 현재는 1800~1850년 런던의 책들을 사용해 nanoGPT를 학습하고 있습니다. 발견한 책들이 개정되거나 현대적 해석이 추가되지 않고, 제가 정한 기간에 출판된 원본임을 확인하는 것이 도전과제입니다.

더 큰 말뭉치(코퍼스)로 새로운 모델(v1)을 학습하고 싶습니다. 아마도 v0.5에 비해 5~10배 더 큰 데이터를 사용할 계획입니다. 목표는 선택적 시대별 학습만으로 추론 능력이 나타나는지 확인하는 것입니다. 이는 더 어려운 작업이고 역사적 데이터 한계로 인해 가능할지 확신할 수 없습니다. 앞으로 몇 주 안에 5~10GB 규모의 데이터를 선별하려고 합니다. 깨끗하고 고품질 데이터를 모으고 GPU를 임대할 수 있다면 진전이 있을 것이라 생각합니다.

# 프로젝트 사용법

이 프로젝트는 주로 역사 데이터를 선별하고 학습 준비를 하며 토크나이저를 만드는 데 중점을 두고 있습니다. 전체 LLM 학습 과정은 다루지 않으니, 그 부분은 Andrej Karpathy의 nanoGPT를 참조하세요.

# 1단계: 역사 텍스트 수집 및 준비

선택한 기간(예: 런던 1800~1850년)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 수집하세요.

필요하다면 download_texts_improved.py를 사용해 도서를 다운로드할 수 있습니다.

스크립트나 수작업으로 Project Gutenberg의 헤더/푸터, 현대적 주석, OCR 오류 등을 제거하여 텍스트 파일을 정제하세요.

prepare_dataset.py를 사용하면 무난하게 진행됩니다.

# 2단계: 커스텀 토크나이저 구축

정제된 데이터에서 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.
이 과정에서 vocab.json과 merges.txt가 생성됩니다.

이 파일들은 모델의 어휘와 병합 규칙을 정의합니다.

# 3단계: 모델 학습(nanoGPT)

학습 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참조하세요.

다른 LLM으로 학습해도 되지만, 저는 nanoGPT를 사용했습니다.

# FAQ

## 선택적 시대별 학습(Selective Temporal Training)이란?

선택적 시대별 학습(STT)은 모든 학습 데이터를 특정한 역사적 시기로 선별하여 모으는 기계 학습 방법론입니다. 현대 개념의 영향을 배제하고 해당 시대의 언어와 지식을 모델링하기 위해 시행합니다. 예를 들어, 제가 현재 보유한 모델(v0.5)은 1800~1875년 자료만으로 학습했으며, 미세조정(fine-tuning)이 아닌 처음부터 학습하여 그 시대의 언어적 스타일과 역사적 맥락이 반영된 출력을 냅니다.

## 그냥 파인튜닝이나 LoRA를 쓰지 않는 이유는?

이 프로젝트에서는 현대적 편향이 없는 언어 모델을 만들고자 합니다. GPT-2와 같은 사전학습 모델을 파인튜닝하면 이미 내재된 정보가 사라지지 않습니다. 처음부터 학습하면 언어 모델이 옛것인 척하는 것이 아니라 진짜 옛것이 됩니다. 현재 목표는 1800~1850년 런던에서 출판된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 어떤 데이터를 학습에 사용했나요?

1800~1850년 런던의 책, 법률 문서, 신문, 기타 글을 사용했습니다. 제가 링크한 목록에는 약 200개가 있지만, 첫 학습에는 50개 파일, 약 187MB만 사용했습니다. 문서 목록은 다음에서 볼 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Version 0 모델의 크기는 어느 정도인가요?

이 모델은 현재 매우 작으며, 재미 삼아 엄격하게 현대 소스를 배제하는 학습 규칙을 따르고 있습니다. 약 1600만 개의 파라미터가 있지만, 더 많은 옛 텍스트를 모아 다음 모델 학습을 시작할 계획입니다. 진행 상황은 계속 업데이트하겠습니다.

## 학습 사양은?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---