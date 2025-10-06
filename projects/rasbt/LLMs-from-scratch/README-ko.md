# 대형 언어 모델 구축하기 (처음부터)

이 저장소는 GPT 유사 LLM을 개발, 사전 학습 및 미세 조정하기 위한 코드를 포함하고 있으며, 책 [대형 언어 모델 구축하기 (처음부터)](https://amzn.to/4fqvn0D)의 공식 코드 저장소입니다.

<br>
<br>

<a href="https://amzn.to/4fqvn0D"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/cover.jpg?123" width="250px"></a>

<br>

[*대형 언어 모델 구축하기 (처음부터)*](http://mng.bz/orYv)에서는 대형 언어 모델(LLM)이 내부적으로 어떻게 작동하는지 단계별로 직접 코딩하며 배우고 이해할 수 있습니다. 이 책에서는 명확한 설명, 도표 및 예제를 통해 각 단계를 안내하며 자신만의 LLM을 만드는 방법을 소개합니다.

이 책에서 설명하는 교육용으로 작지만 기능적인 모델을 학습하고 개발하는 방법은 ChatGPT 뒤에 있는 대규모 기초 모델을 만드는 데 사용된 접근법을 반영합니다. 또한 이 책에는 미세 조정을 위해 더 큰 사전 학습된 모델의 가중치를 불러오는 코드도 포함되어 있습니다.

- 공식 [소스 코드 저장소](https://github.com/rasbt/LLMs-from-scratch) 링크
- [출판사 맨닝 사이트의 책 링크](http://mng.bz/orYv)
- [Amazon.com 책 페이지 링크](https://www.amazon.com/gp/product/1633437167)
- ISBN 9781633437166

<a href="http://mng.bz/orYv#reviews"><img src="https://sebastianraschka.com//images/LLMs-from-scratch-images/other/reviews.png" width="220px"></a>


<br>
<br>

이 저장소를 다운로드하려면 [Download ZIP](https://github.com/rasbt/LLMs-from-scratch/archive/refs/heads/main.zip) 버튼을 클릭하거나 터미널에서 다음 명령어를 실행하세요:

```bash
git clone --depth 1 https://github.com/rasbt/LLMs-from-scratch.git
```

<br>

(If you downloaded the code bundle from the Manning website, please consider visiting the official code repository on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) for the latest updates.)

<br>
<br>


# Table of Contents

Please note that this `README.md` file is a Markdown (`.md`) file. If you have downloaded this code bundle from the Manning website and are viewing it on your local computer, I recommend using a Markdown editor or previewer for proper viewing. If you haven't installed a Markdown editor yet, [Ghostwriter](https://ghostwriter.kde.org) is a good free option.

You can alternatively view this and other files on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) in your browser, which renders Markdown automatically.

<br>
<br>


> **Tip:**
> If you're seeking guidance on installing Python and Python packages and setting up your code environment, I suggest reading the [README.md](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/setup/README.md) file located in the [setup](setup) directory.

<br>
<br>

[![Code tests Linux](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml)
[![Code tests Windows](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml)
[![Code tests macOS](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml)




<br>

| Chapter Title                                              | Main Code (for Quick Access)                                                                                                    | All Code + Supplementary      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------|-------------------------------|
| [Setup recommendations](setup)                             | -                                                                                                                               | -                             |
| Ch 1: Understanding Large Language Models                  | No code                                                                                                                         | -                             |
| Ch 2: Working with Text Data                               | - [ch02.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/ch02.ipynb)<br/>- [dataloader.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/dataloader.ipynb) (summary)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/exercise-solutions.ipynb)               | [./ch02](./ch02)            |
| Ch 3: Coding Attention Mechanisms                          | - [ch03.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/ch03.ipynb)<br/>- [multihead-attention.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/multihead-attention.ipynb) (summary) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/exercise-solutions.ipynb)| [./ch03](./ch03)             |
| Ch 4: Implementing a GPT Model from Scratch                | - [ch04.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/ch04.ipynb)<br/>- [gpt.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/gpt.py) (요약)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/exercise-solutions.ipynb) | [./ch04](./ch04)           |
| Ch 5: Pretraining on Unlabeled Data                        | - [ch05.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/ch05.ipynb)<br/>- [gpt_train.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_train.py) (요약) <br/>- [gpt_generate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_generate.py) (요약) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/exercise-solutions.ipynb) | [./ch05](./ch05)              |
| Ch 6: Finetuning for Text Classification                   | - [ch06.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/ch06.ipynb)  <br/>- [gpt_class_finetune.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/gpt_class_finetune.py)  <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/exercise-solutions.ipynb) | [./ch06](./ch06)              |
| Ch 7: Finetuning to Follow Instructions                    | - [ch07.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ch07.ipynb)<br/>- [gpt_instruction_finetuning.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/gpt_instruction_finetuning.py) (요약)<br/>- [ollama_evaluate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ollama_evaluate.py) (요약)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/exercise-solutions.ipynb) | [./ch07](./ch07)  |
| Appendix A: Introduction to PyTorch                        | - [code-part1.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part1.ipynb)<br/>- [code-part2.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part2.ipynb)<br/>- [DDP-script.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/DDP-script.py)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/exercise-solutions.ipynb) | [./appendix-A](./appendix-A) |
| Appendix B: References and Further Reading                 | 코드 없음                                                                                                                        | -                             |
| Appendix C: Exercise Solutions                             | 코드 없음                                                                                                                        | -                             |
| Appendix D: Adding Bells and Whistles to the Training Loop | - [appendix-D.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-D/01_main-chapter-code/appendix-D.ipynb)                                                          | [./appendix-D](./appendix-D)  |
| Appendix E: Parameter-efficient Finetuning with LoRA       | - [appendix-E.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-E/01_main-chapter-code/appendix-E.ipynb)                                                          | [./appendix-E](./appendix-E) |

<br>
&nbsp;

아래의 멘탈 모델은 이 책에서 다룬 내용을 요약합니다.

<img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/mental-model.jpg" width="650px">


<br>
&nbsp;

## 사전 지식

가장 중요한 사전 지식은 Python 프로그래밍에 대한 탄탄한 기초입니다.
이 지식을 바탕으로, 여러분은 LLM의 매혹적인 세계를 탐험하고
이 책에서 제시하는 개념과 코드 예제를 이해할 준비가 잘 될 것입니다.

딥 뉴럴 네트워크에 대한 경험이 있다면, LLM이 이러한 아키텍처를 기반으로 구축되었기 때문에
어떤 개념들이 더 익숙하게 느껴질 수 있습니다.

이 책은 외부 LLM 라이브러리를 사용하지 않고 PyTorch로부터 코드를 직접 구현합니다.
PyTorch에 능숙할 필요는 없지만, PyTorch 기본 지식이 있으면 확실히 도움이 됩니다.
PyTorch가 처음이라면 부록 A에서 간결한 PyTorch 소개를 제공합니다.
또는 제 책 [PyTorch in One Hour: From Tensors to Training Neural Networks on Multiple GPUs](https://sebastianraschka.com/teaching/pytorch-1h/)도 필수 내용을 학습하는 데 유용할 수 있습니다.



<br>
&nbsp;

## 하드웨어 요구 사항

이 책의 주요 장에 나오는 코드는 일반적인 노트북에서도 합리적인 시간 내에 실행되도록 설계되었으며, 특수 하드웨어가 필요하지 않습니다.
이 접근법은 폭넓은 독자가 자료에 접근할 수 있도록 합니다.
또한, 코드는 GPU가 사용 가능하면 자동으로 이를 활용합니다. (추가 권장 사항은 [설치](https://github.com/rasbt/LLMs-from-scratch/blob/main/setup/README.md) 문서를 참조하세요.)
&nbsp;
## 비디오 강의

[17시간 15분 분량의 동반 비디오 강의](https://www.manning.com/livevideo/master-and-build-large-language-models)로, 책의 각 장을 따라가며 코딩합니다. 강의는 책의 구조를 그대로 반영한 장과 섹션으로 구성되어 있어, 책을 대체하거나 보완하는 코드 학습 자료로 활용할 수 있습니다.

<a href="https://www.manning.com/livevideo/master-and-build-large-language-models"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/video-screenshot.webp?123" width="350px"></a>


&nbsp;


## 동반 도서 / 후속작

[*Build A Reasoning Model (From Scratch)*](https://mng.bz/lZ5B)는 독립적인 책이지만, *Build A Large Language Model (From Scratch)*의 후속작으로 간주할 수 있습니다.

이 책은 사전 학습된 모델로 시작하여 추론 시간 확장, 강화 학습, 증류 등 다양한 추론 접근법을 구현하여 모델의 추론 능력을 향상시킵니다.

*Build A Large Language Model (From Scratch)*와 마찬가지로, [*Build A Reasoning Model (From Scratch)*](https://mng.bz/lZ5B)도 이러한 방법들을 직접 구현하는 실습 중심의 접근법을 취합니다.

<a href="https://mng.bz/lZ5B"><img src="https://sebastianraschka.com/images/reasoning-from-scratch-images/cover.webp?123" width="120px"></a>

- 아마존 링크 (준비 중)
- [매닝 링크](https://mng.bz/lZ5B)
- [GitHub 저장소](https://github.com/rasbt/reasoning-from-scratch)

<br>

&nbsp;
## 연습문제

책의 각 장에는 여러 연습문제가 포함되어 있습니다. 해답은 부록 C에 요약되어 있으며, 해당 코드 노트북은 이 저장소의 각 장 폴더 내에 있습니다 (예: [./ch02/01_main-chapter-code/exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/./ch02/01_main-chapter-code/exercise-solutions.ipynb)).

코드 연습 문제 외에도, 매닝 웹사이트에서 [Test Yourself On Build a Large Language Model (From Scratch)](https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch)라는 170페이지 분량의 무료 PDF를 다운로드할 수 있습니다. 각 장당 약 30개의 퀴즈 문제와 해답이 포함되어 있어 이해도를 테스트하는 데 도움이 됩니다.

<a href="https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/test-yourself-cover.jpg?123" width="150px"></a>



&nbsp;

## 보너스 자료

여러 폴더에는 관심 있는 독자를 위한 선택적 보너스 자료가 포함되어 있습니다:

- **설정**
  - [파이썬 설정 팁](setup/01_optional-python-setup-preferences)
  - [이 책에서 사용하는 파이썬 패키지 및 라이브러리 설치](setup/02_installing-python-libraries)
  - [도커 환경 설정 가이드](setup/03_optional-docker-environment)
- **2장: 텍스트 데이터 작업하기**
  - [처음부터 구현하는 바이트 페어 인코딩(BPE) 토크나이저](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/05_bpe-from-scratch/bpe-from-scratch.ipynb)
  - [다양한 바이트 페어 인코딩(BPE) 구현 비교](ch02/02_bonus_bytepair-encoder)
  - [임베딩 레이어와 선형 레이어의 차이 이해하기](ch02/03_bonus_embedding-vs-matmul)
  - [간단한 숫자로 이해하는 데이터로더 직관](ch02/04_bonus_dataloader-intuition)
- **3장: 어텐션 메커니즘 코딩하기**
  - [효율적인 멀티헤드 어텐션 구현 비교](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/02_bonus_efficient-multihead-attention/mha-implementations.ipynb)
  - [파이토치 버퍼 이해하기](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/03_understanding-buffers/understanding-buffers.ipynb)
- **4장: GPT 모델 처음부터 구현하기**
  - [FLOPS 분석](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/02_performance-analysis/flops-analysis.ipynb)
  - [KV 캐시](ch04/03_kv-cache)
- **5장: 레이블 없는 데이터로 사전 학습하기**
  - [대체 가중치 로딩 방법](ch05/02_alternative_weight_loading/)
  - [프로젝트 구텐베르크 데이터셋으로 GPT 사전 학습하기](ch05/03_bonus_pretraining_on_gutenberg)
  - [학습 루프에 부가 기능 추가하기](ch05/04_learning_rate_schedulers)
  - [사전 학습을 위한 하이퍼파라미터 최적화](ch05/05_bonus_hparam_tuning)
  - [사전 학습된 LLM과 상호작용할 사용자 인터페이스 구축](ch05/06_user_interface)
  - [GPT를 Llama로 변환하기](ch05/07_gpt_to_llama)
  - [처음부터 구현하는 Llama 3.2](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/07_gpt_to_llama/standalone-llama32.ipynb)
  - [처음부터 구현하는 Qwen3 Dense 및 전문가 혼합(MoE)](ch05/11_qwen3/)
  - [처음부터 구현하는 Gemma 3](ch05/12_gemma3/)
  - [메모리 효율적인 모델 가중치 로딩](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/08_memory_efficient_weight_loading/memory-efficient-state-dict.ipynb)
  - [새 토큰으로 Tiktoken BPE 토크나이저 확장하기](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/09_extending-tokenizers/extend-tiktoken.ipynb)
  - [빠른 LLM 학습을 위한 파이토치 성능 팁](ch05/10_llm-training-speed)
- **6장: 분류를 위한 파인튜닝**
  - [다양한 레이어 파인튜닝과 더 큰 모델 사용 추가 실험](ch06/02_bonus_additional-experiments)
  - [50k IMDb 영화 리뷰 데이터셋에서 다양한 모델 파인튜닝](ch06/03_bonus_imdb-classification)
  - [GPT 기반 스팸 분류기와 상호작용하는 사용자 인터페이스 구축](ch06/04_user_interface)
- **7장: 지시사항 준수를 위한 파인튜닝**
  - [근접 중복 찾기 및 수동태 항목 생성용 데이터셋 유틸리티](ch07/02_dataset-utilities)
  - [OpenAI API와 Ollama를 사용한 지시 응답 평가](ch07/03_model-evaluation)
  - [지시 파인튜닝용 데이터셋 생성](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/llama3-ollama.ipynb)
  - [명령어 미세조정을 위한 데이터셋 개선](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/reflection-gpt4.ipynb)
  - [Llama 3.1 70B와 Ollama로 선호도 데이터셋 생성하기](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/create-preference-data-ollama.ipynb)
  - [LLM 정렬을 위한 직접 선호도 최적화(DPO)](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/dpo-from-scratch.ipynb)
  - [명령어 미세조정된 GPT 모델과 상호작용하는 사용자 인터페이스 구축](ch07/06_user_interface)

<br>
&nbsp;

## 질문, 피드백 및 저장소 기여


모든 종류의 피드백을 환영하며, [Manning 포럼](https://livebook.manning.com/forum?product=raschka&page=1) 또는 [GitHub 토론](https://github.com/rasbt/LLMs-from-scratch/discussions)을 통해 공유해 주시기 바랍니다. 마찬가지로 질문이 있거나 아이디어를 나누고 싶다면 포럼에 게시하는 것을 주저하지 마세요.

이 저장소는 인쇄 도서에 대응하는 코드를 포함하고 있기 때문에, 현재 주요 챕터 코드의 내용을 확장하는 기여는 받을 수 없습니다. 이는 실물 도서와의 차이를 방지하기 위한 것으로, 일관성을 유지하는 것이 모두에게 원활한 경험을 보장합니다.


&nbsp;
## 인용


이 책이나 코드를 연구에 유용하게 사용하셨다면, 인용을 고려해 주시기 바랍니다.

시카고 스타일 인용:

> Raschka, Sebastian. *Build A Large Language Model (From Scratch)*. Manning, 2024. ISBN: 978-1633437166.

BibTeX 항목:
```
@book{build-llms-from-scratch-book,
  author       = {Sebastian Raschka},
  title        = {Build A Large Language Model (From Scratch)},
  publisher    = {Manning},
  year         = {2024},
  isbn         = {978-1633437166},
  url          = {https://www.manning.com/books/build-a-large-language-model-from-scratch},
  github       = {https://github.com/rasbt/LLMs-from-scratch}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---