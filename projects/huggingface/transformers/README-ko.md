<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>최첨단 사전학습 모델로 추론과 학습을 한 번에</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers는 추론과 학습을 위한 사전학습된 텍스트, 컴퓨터 비전, 오디오, 비디오, 멀티모달 모델 라이브러리입니다. Transformers를 사용하여 여러분의 데이터로 모델을 파인튜닝하고, 추론 애플리케이션을 구축하며, 다양한 모달리티에 걸친 생성형 AI 활용 사례에 적용해 보세요.

[Hugging Face Hub](https://huggingface.com/models)에는 50만 개 이상의 Transformers [모델 체크포인트](https://huggingface.co/models?library=transformers&sort=trending)가 준비되어 있습니다.

오늘 [Hub](https://huggingface.com/)을(를) 탐색하여 원하는 모델을 찾고 Transformers로 바로 시작해 보세요.

## 설치

Transformers는 Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+에서 동작합니다.

[venv](https://docs.python.org/3/library/venv.html) 혹은 빠른 Rust 기반 Python 패키지 및 프로젝트 매니저 [uv](https://docs.astral.sh/uv/)를 이용하여 가상 환경을 생성하고 활성화하세요.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

가상 환경에 Transformers를 설치하세요.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

라이브러리의 최신 변경 사항이 필요하거나 기여를 원하신다면 소스에서 Transformers를 설치하세요. 단, *최신* 버전은 안정적이지 않을 수 있습니다. 오류가 발생하면 언제든지 [이슈](https://github.com/huggingface/transformers/issues)를 등록해 주세요.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## 빠른 시작

[Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) API를 통해 Transformers를 바로 시작할 수 있습니다. `Pipeline`은 텍스트, 오디오, 비전, 멀티모달 작업을 지원하는 고수준 추론 클래스입니다. 입력 전처리를 자동으로 처리하고 적절한 출력을 반환합니다.

파이프라인을 인스턴스화하고 사용할 텍스트 생성 모델을 지정하세요. 모델은 다운로드 및 캐시되어 재사용이 간편합니다. 마지막으로 프롬프트로 사용할 텍스트를 모델에 전달하세요.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

모델과 대화하려면 사용 패턴은 동일합니다. 유일한 차이점은 여러분과 시스템 간의 대화 히스토리(즉, `Pipeline`에 입력할 내용)를 구성해야 한다는 점입니다.

> [!TIP]
> 명령줄에서 모델과 직접 대화할 수도 있습니다.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "You are a sassy, wise-cracking robot as imagined by Hollywood circa 1986."},
    {"role": "user", "content": "Hey, can you tell me any fun things to do in New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

아래 예시를 펼쳐보면 `Pipeline`이 다양한 모달리티 및 작업에 어떻게 동작하는지 확인할 수 있습니다.

<details>
<summary>자동 음성 인식(ASR)</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>이미지 분류</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>시각적 질문 응답(VQA)</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## 왜 Transformers를 사용해야 할까요?

1. 사용하기 쉬운 최첨단 모델:
    - 자연어 이해 및 생성, 컴퓨터 비전, 오디오, 비디오, 멀티모달 작업에서 높은 성능
    - 연구자, 엔지니어, 개발자를 위한 낮은 진입 장벽
    - 학습해야 할 사용자 친화적 추상화는 단 3개 클래스
    - 모든 사전학습 모델을 위한 통합 API 제공

1. 더 낮은 연산 비용, 더 작은 탄소 발자국:
    - 처음부터 학습하지 않고 훈련된 모델을 공유하세요
    - 연산 시간과 서비스 비용 절감
    - 모든 모달리티를 아우르는 수십 개의 모델 아키텍처와 100만 개 이상의 사전학습 체크포인트

1. 모델 생애주기별로 알맞은 프레임워크 선택:
    - 3줄 코드로 최첨단 모델 학습
    - 하나의 모델을 PyTorch/JAX/TF2.0 프레임워크 간에 자유롭게 이동
    - 학습, 평가, 배포에 적합한 프레임워크 선택 가능

1. 모델이나 예제를 손쉽게 커스터마이징:
    - 각 아키텍처별로 원 저자 결과를 재현할 수 있는 예제 제공
    - 모델 내부 구조를 일관되게 최대한 노출
    - 빠른 실험을 위해 라이브러리와 독립적으로 모델 파일 사용 가능

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## 왜 Transformers를 사용하지 말아야 할까요?

- 이 라이브러리는 신경망을 위한 모듈형 툴박스가 아닙니다. 모델 파일의 코드는 추가 추상화 없이 의도적으로 작성되어, 연구자가 추가 파일이나 추상화 없이 각 모델을 빠르게 반복 개발할 수 있습니다.
- 학습 API는 Transformers가 제공하는 PyTorch 모델과의 작동에 최적화되어 있습니다. 일반적인 머신러닝 루프에는 [Accelerate](https://huggingface.co/docs/accelerate)와 같은 다른 라이브러리를 사용하세요.
- [예제 스크립트]((https://github.com/huggingface/transformers/tree/main/examples))는 *예시*일 뿐입니다. 특정 사용 사례에 바로 적용되지 않을 수 있으니, 동작을 위해 코드를 수정해야 할 수 있습니다.

## Transformers를 사용하는 100가지 프로젝트

Transformers는 단순히 사전학습 모델을 사용하는 툴킷 그 이상으로, Transformers와 Hugging Face Hub를 중심으로 구축된 프로젝트 커뮤니티입니다. 우리는 Transformers가 개발자, 연구자, 학생, 교수, 엔지니어 그리고 그 외 누구든지 꿈꾸는 프로젝트를 구축할 수 있게 하길 바랍니다.

Transformers 10만 스타 달성을 기념하여, 커뮤니티가 만든 놀라운 100가지 프로젝트를 [awesome-transformers](./awesome-transformers.md) 페이지에 소개합니다.

여러분이 소유하거나 사용하는 프로젝트가 리스트에 포함되어야 한다고 생각한다면, PR을 열어 추가해 주세요!

## 예시 모델

대부분의 모델을 [Hub 모델 페이지](https://huggingface.co/models)에서 바로 테스트할 수 있습니다.

아래 각 모달리티를 펼쳐 다양한 사용 사례별 예시 모델을 확인하세요.

<details>
<summary>오디오</summary>

- [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)로 오디오 분류
- [Moonshine](https://huggingface.co/UsefulSensors/moonshine)로 자동 음성 인식
- [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)로 키워드 검출
- [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)로 음성-음성 생성
- [MusicGen](https://huggingface.co/facebook/musicgen-large)으로 텍스트-오디오 변환
- [Bark](https://huggingface.co/suno/bark)로 텍스트-음성 변환

</details>

<details>
<summary>컴퓨터 비전</summary>

- [SAM](https://huggingface.co/facebook/sam-vit-base)으로 자동 마스크 생성
- [DepthPro](https://huggingface.co/apple/DepthPro-hf)로 깊이 추정
- [DINO v2](https://huggingface.co/facebook/dinov2-base)로 이미지 분류
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)로 키포인트 검출
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue)로 키포인트 매칭
- [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)로 객체 검출
- [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)로 포즈 추정
- [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)로 범용 세분화
- [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)로 비디오 분류

</details>

<details>
<summary>멀티모달</summary>

- [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)로 오디오/텍스트-텍스트 변환
- [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)로 문서 질의응답
- [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)로 이미지/텍스트-텍스트 변환
- [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)로 이미지 캡셔닝
- [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)로 OCR 기반 문서 이해
- [TAPAS](https://huggingface.co/google/tapas-base)로 표 질의응답
- [Emu3](https://huggingface.co/BAAI/Emu3-Gen)로 통합 멀티모달 이해 및 생성
- [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)로 비전-텍스트 변환
- [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)로 시각적 질문 응답
- [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)로 시각적 지시 표현 세분화

</details>

<details>
<summary>NLP</summary>

- [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)로 마스킹 단어 완성
- [Gemma](https://huggingface.co/google/gemma-2-2b)로 개체명 인식
- [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)로 질문 응답
- [BART](https://huggingface.co/facebook/bart-large-cnn)로 요약
- [T5](https://huggingface.co/google-t5/t5-base)로 번역
- [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)로 텍스트 생성
- [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)로 텍스트 분류

</details>

## 인용

🤗 Transformers 라이브러리를 인용할 수 있는 [논문](https://www.aclweb.org/anthology/2020.emnlp-demos.6/)이 있습니다:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---