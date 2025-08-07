
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

AI 모델이 단순히 역사적 인 척하는 것이 아니라 실제로 역사적이라면 상상해보세요.

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 구축되었습니다. 핵심 학습 스크립트와 모델 구조는 그의 작업입니다.

# 프로젝트 목표

TimeCapsule LLM은 특정 시대에 작성된 텍스트만으로 학습되는 실험적 프로젝트입니다. 목표는 특정 역사적 시대의 세계관과 언어를 시뮬레이션하는 것입니다.

# 파인튜닝만으로는 충분하지 않은 이유

이미 학습된 모델을 파인튜닝만 한다면, LLM은 여전히 현대 개념을 알게 됩니다. 물론 완전히 현대적 편향을 없애는 것은 어렵지만, 최대한 이 목표에 가까워지고자 합니다. 현대적 편향이 전혀 없는 모델을 만들려면 처음부터 모델을 학습해야 합니다.

# 기대 결과

완성되면 이 모델은 현대 개념을 알지 못하고 학습된 범위 이상의 추론을 하지 못할 것입니다. 현대 개념/어휘를 인식하지 못하고, 현대 지식을 환각하지 않기를 바랍니다.

# 진행 상황 업데이트

## 2025년 7월 9일

1800-1850년, 지역은 런던으로 시대를 정했습니다.

텍스트, 책, 문서 목록을 수집했습니다.

지금까지 50개의 txt 파일을 확보했고 곧 NanoGPT 학습을 시작할 예정입니다.

진행 상황이 있을 때마다 이 내용을 업데이트할 예정입니다.

## 2025년 7월 13일

nanoGPT를 187MB의 역사적 텍스트 데이터로 학습시켰습니다.

## 2025년 7월 15일

두 번째 학습을 위해 텍스트 다운로드를 시작했습니다. Internet Archive에서 모든 텍스트를 받고 있고, 시대 범위를 1800-1875년으로 확장했습니다. 다양한 텍스트를 얻기 위해 Internet Archive의 주제, 출판 위치, 시대, 주제별 필터를 사용할 수 있습니다.

![Search Filters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

Internet Archive에서 약 500개의 txt 파일을 다운로드했고, (공백, 구텐베르크 헤더 등 삭제 등) 정제 후 약 500MB의 데이터를 확보했습니다. 아주 작은 데이터셋이지만, 지난 번에는 187MB로 학습했으니 두 번째 모델 학습 후 결과에서 어느 정도 눈에 띄는 차이가 있을 것으로 기대됩니다. 이번 모델은 적어도 조금 더 논리적인 문장을 생성하길 바랍니다. 물론 여전히 아주 작은 데이터셋이기에 보장할 순 없지만, 지난 번보다는 더 많습니다.

이 정도면 제 개인 하드웨어로도 충분히 학습이 가능할 것 같습니다. 이 덕분에 더 큰 데이터셋으로 넘어가기 전에 약간의 개선을 직접 확인할 수 있길 바랍니다. 큰 데이터셋은 GPU를 임대해야 하니, 그 전에 데이터셋을 최대한 선별하고 정제하는 것이 목표입니다. 문제 중 하나는 정제 과정인데, 많은 txt 파일에 의미 없는 내용이 섞여 있습니다. 정제용 스크립트가 어느 정도 효과는 있지만 100%는 아닙니다.

오늘 이 데이터셋으로 학습을 시작할 예정이며, 약 4-5시간이 걸릴 것으로 보입니다. 학습이 끝나고 테스트도 마치면 업데이트하겠습니다. 프로젝트를 살펴봐주신 모든 분들께 감사드리며, OCR 관련 자료 링크를 주신 분들도 있어서 고맙습니다! 더 많은 분들이 직접 데이터셋을 만들어 실험해 보셨으면 좋겠습니다.


### 학습 업데이트

435MB(1억 800만 토큰) 말뭉치로 학습을 시작했으며, 현재까지 순조롭게 진행 중입니다. 학습 손실은 첫 2800회 반복에서 10.9에서 4.9로 떨어졌습니다. 전체 학습에는 8~9시간 정도 걸릴 것으로 예상합니다. 완료되면 추가 업데이트를 올리겠습니다.

## 2025년 7월 17일

두 번째 모델 학습이 완료되었습니다. 제 4060 그래픽카드로 약 8시간 40분(시간당 3900회 반복) 동안 3만 3천회(5 에폭) 반복했습니다. 최종 학습 손실은 3.73이었고, 출력 결과가 놀라울 만큼 좋아져서 이제 진짜 19세기 스타일의 논리적인 문장을 생성합니다.

## 2025년 7월 28일

v0.5를 Hugging Face에 업로드했습니다. [여기서 확인](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)하실 수 있습니다. 저장소를 다운로드해 로컬에서 실행할 수 있습니다. 아쉽게도 nanoGPT는 HuggingFace와 바로 호환되지 않으니, 모델을 다운로드해 로컬에서 실행해야 합니다.

또한 다음 학습을 위해 데이터 선별을 시작할 예정입니다. 추론 능력 향상을 위해서는 데이터가 5~10배 더 필요하다고 생각합니다.

## 2025년 8월 2일

곧 버전 1 작업을 시작할 예정입니다. nanoGPT 아키텍처에서 더 현대적인 구조로 전환해야 할 필요가 있습니다. OpenLLaMA v3, Phi-2, Qwen 1.5B 등 여러 오픈소스 LLM 아키텍처를 고려 중입니다. V1으로의 도약을 위해서는 훨씬 크고 다양한 데이터셋을 신중히 선별해야 하며, 최소 5GB의 정제된 학습 데이터가 필요합니다.

# V0 모델 동작 및 한계

초기 프롬프트에서는 모델이 1800년대의 언어와 행동으로 반응하는 모습을 보입니다. 예를 들어, "Who art Henry?"라고 프롬프트를 주었더니 "I know that man, I have did not a black, the storm."라고 답했습니다. 물론 이 문장은 말이 안 되지만 LLM이 제가 사람에 대해 묻고 있다는 것은 인식하고 있습니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

현대적인 개념은 언급되지 않으며, 출력에는 대부분 1800년대의 단어와 표현이 포함되어 있습니다.

아직 많은 작업이 필요하며, 187MB로 학습한다고 해서 복잡한 추론이 가능한 모델이 만들어지지는 않습니다.

현재는 완전한 문장 구조가 부족하고 전반적으로 말이 안 되는 문장이 생성되지만, 이 정도 퀄리티는 데이터 크기에 비해 정상입니다.

# V0.5 모델 동작 및 한계

이전 모델에 비해 꽤 개선된 결과입니다. 문체와 어휘가 빅토리아 시대 스타일이고, 거의 모든 문장이 문법적으로 맞고 구두점도 적절합니다. 이번에도 처음부터 학습한 모델이라 1800년대 주제에만 집중합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

사실과 다른 내용(환각)이 많이 생성됩니다. 세부사항(날짜, 사건, 역사적 인물) 중 거의 100%가 허구입니다. 또한 문장들끼리 논리적 연결성이 부족하며, 가끔 2개의 문장이 서로 관련이 있을 때도 있지만 그 이상은 연결이 없습니다. 또 하나의 문제는 때때로 "Digitized by Google"과 같은 푸터가 등장한다는 점인데, 다음 학습 때는 반드시 텍스트를 더 깔끔하게 정제해야겠다고 생각했습니다. 전체적으로 결과에 매우 만족하며, 아직 LLM 수준은 아니지만 분명히 문장 생성기는 맞습니다.

많은 것을 배우고 있고, 앞으로 몇 주간 더 나은 결과를 위해 무엇을 개선해야 할지 고민해 볼 예정입니다. 곧 파일도 업로드하겠습니다!

# 향후 계획

(완료) 버전 0.5 작업을 시작할 예정입니다. 50권의 책으로 학습하는 대신, 이상적으로는 500~600권을 사용해 학습할 계획입니다. 현재는 1800~1850년 런던에서 출간된 책을 사용하여 nanoGPT를 학습 중입니다. 찾은 책들이 개정되었거나 현대 해석이 추가된 것이 아닌, 제가 선택한 시기에 출간된 원본임을 반드시 확인해야 하는 점이 도전 과제입니다.

더 큰 말뭉치(코퍼스)로 새로운 모델(v1)을 훈련하고 싶습니다. v0.5에서 사용한 데이터보다 5~10배 더 큰 데이터셋이 목표입니다. 목표는 선택적 시기별 학습(Selective Temporal Training)만으로 추론 능력이 나타나는지 확인하는 것입니다. 이는 더 어려운 과제이며, 역사적 데이터의 한계로 인해 실제로 가능한지도 확신할 수 없습니다. 앞으로 몇 주 동안 5~10GB 크기의 데이터를 선별해볼 예정입니다. 만약 깨끗하고 고품질의 데이터를 충분히 얻고 GPU를 임대할 수 있다면 진전이 있을 것이라고 믿습니다.

# 프로젝트 사용 방법

이 프로젝트는 주로 역사 데이터를 선별하고, 학습에 맞게 준비하며, 토크나이저를 구축하는 것에 집중합니다. 전체 LLM 학습 과정은 다루지 않으니, 자세한 내용은 Andrej Karpathy의 nanoGPT를 참고하세요.

# 1단계: 역사적 텍스트 수집 및 준비

선택한 시기의 공공 도메인 도서, 문서 등의 .txt 파일을 수집합니다(예: 런던 1800-1850).

필요하다면 download_texts_improved.py를 사용해 도서를 다운로드할 수 있습니다.

스크립트나 수작업으로 Project Gutenberg의 헤더/푸터, 현대 주석, OCR 오류 등을 삭제하여 텍스트 파일을 정제하세요.

prepare_dataset.py를 사용하면 충분합니다.

# 2단계: 커스텀 토크나이저 구축

정제된 데이터에 대해 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.
이 과정에서 vocab.json과 merges.txt가 생성됩니다.

이 파일들은 모델의 어휘와 병합 규칙을 정의합니다.

# 3단계: 모델 학습(nanoGPT)

학습 과정은 [Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT)를 참고하세요.

원한다면 다른 LLM을 학습할 수도 있지만, 저는 nanoGPT를 사용했습니다.

# 자주 묻는 질문(FAQ)

## 선택적 시기별 학습(Selective Temporal Training)이란 무엇인가요?

선택적 시기별 학습(STT)은 모든 학습 데이터를 특정 역사적 시기에 한정하여 엄선하는 머신러닝 방법론입니다. 이는 해당 시대의 언어와 지식을 현대적 개념의 영향 없이 모델링하기 위함입니다. 예를 들어, 현재의 제 모델(v0.5)은 1800~1875년 데이터로만 학습했으며, 파인튜닝 없이 처음부터 학습하여 그 시대의 언어적 스타일과 역사적 맥락이 반영된 출력을 생성합니다.

## 파인튜닝이나 LoRA를 사용하지 않는 이유는 무엇인가요?

이 프로젝트의 목표는 현대적 편향이 없는 언어 모델을 만드는 것입니다. 만약 GPT-2 같은 모델을 파인튜닝한다면 이미 선행 학습된 정보는 사라지지 않습니다. 처음부터 학습시키면 언어 모델이 옛날처럼 '흉내내는 것'이 아니라 진짜 그 시대의 모델이 됩니다. 이 프로젝트의 목표는 1800~1850년 런던에서 출간된 책의 지식만으로 추론할 수 있는 모델을 만드는 것입니다.

## 학습에 사용한 데이터는 어떤 것인가요?

1800~1850년 런던의 책, 법률문서, 신문, 기타 문서들을 사용했습니다. 링크한 목록에는 약 200개의 문서가 있지만, 최초 학습에는 약 50개의 파일, 총 187MB 정도만 사용했습니다. 문서 목록은 다음에서 확인할 수 있습니다:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 버전 0 모델의 크기는 어느 정도인가요?

현재 이 모델은 매우 작으며, 재미와 현대 소스 배제를 위한 엄격한 학습 규칙을 따르고 있습니다. 파라미터는 약 1,600만 개이며, 앞으로 더 많은 옛날 텍스트를 수집해 새로운 모델 학습을 시작할 예정입니다. 진행 상황은 계속 업데이트하겠습니다.

## 학습 사양은 어떻게 되나요?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---