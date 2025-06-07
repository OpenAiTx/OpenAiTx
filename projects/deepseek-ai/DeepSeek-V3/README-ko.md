<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## 목차

1. [소개](#1-introduction)
2. [모델 요약](#2-model-summary)
3. [모델 다운로드](#3-model-downloads)
4. [평가 결과](#4-evaluation-results)
5. [챗 웹사이트 & API 플랫폼](#5-chat-website--api-platform)
6. [로컬 실행 방법](#6-how-to-run-locally)
7. [라이선스](#7-license)
8. [인용](#8-citation)
9. [문의](#9-contact)


## 1. 소개

DeepSeek-V3를 소개합니다. DeepSeek-V3는 671B의 전체 파라미터와 토큰별 37B 활성 파라미터를 가진 강력한 전문가 혼합(MoE, Mixture-of-Experts) 언어 모델입니다.
효율적인 추론과 비용 효율적인 학습을 위해 DeepSeek-V3는 DeepSeek-V2에서 철저히 검증된 Multi-head Latent Attention(MLA) 및 DeepSeekMoE 아키텍처를 채택합니다.
또한 DeepSeek-V3는 부가 손실 없이 로드 밸런싱을 달성하는 전략을 개척하고, 더 강력한 성능을 위해 다중 토큰 예측 학습 목표를 설정합니다.
DeepSeek-V3는 14.8조 개의 다양하고 고품질의 토큰으로 사전학습을 진행한 후, 감독 학습(SFT) 및 강화 학습(RL) 단계를 거쳐 모델의 역량을 최대한 발휘합니다.
종합적인 평가 결과, DeepSeek-V3는 다른 오픈소스 모델을 능가하며, 주요 폐쇄형 모델들과 동등한 성능을 달성합니다.
뛰어난 성능에도 불구하고 DeepSeek-V3의 전체 학습에는 단 2.788M H800 GPU 시간이 소요됩니다.
또한 학습 과정이 매우 안정적입니다.
전체 학습 과정에서 회복 불가능한 손실 스파이크나 롤백이 발생하지 않았습니다.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. 모델 요약

---

**아키텍처: 혁신적인 로드 밸런싱 전략과 학습 목표**

- DeepSeek-V2의 효율적인 아키텍처를 기반으로, 부가 손실 없는 로드 밸런싱 전략을 개척하여 로드 밸런싱으로 인한 성능 저하를 최소화하였습니다.
- 다중 토큰 예측(MTP, Multi-Token Prediction) 목표를 연구하고 모델 성능에 유익함을 입증했습니다.
  또한 이는 추론 가속화를 위한 추측적 디코딩(spekulative decoding)에도 사용할 수 있습니다.

---

**사전학습: 궁극적인 학습 효율성 추구**

- FP8 혼합 정밀도 학습 프레임워크를 설계하고, 최초로 초대규모 모델에 FP8 학습의 가능성과 효과를 검증하였습니다.
- 알고리즘, 프레임워크, 하드웨어의 공동 설계를 통해 노드 간 MoE 학습의 통신 병목 현상을 극복하여, 연산-통신 오버랩을 거의 완벽하게 달성하였습니다.
  이로써 학습 효율성을 크게 향상시키고 비용을 절감하여, 추가적인 오버헤드 없이 모델 규모를 더욱 확장할 수 있게 되었습니다.
- 경제적인 2.664M H800 GPU 시간만으로 DeepSeek-V3의 14.8T 토큰 사전학습을 완료하여, 현재 최고의 오픈소스 베이스 모델을 생산하였습니다. 사전학습 이후 후속 학습 단계에는 단 0.1M GPU 시간만이 소요됩니다.

---

**후학습: DeepSeek-R1로부터의 지식 증류**

- DeepSeek R1 시리즈 중 하나의 장문 Chain-of-Thought(CoT) 모델로부터 표준 LLM, 특히 DeepSeek-V3로 추론 능력을 증류하는 혁신적인 방법론을 도입하였습니다. 본 파이프라인은 R1의 검증 및 반성 패턴을 DeepSeek-V3에 우아하게 통합하여 추론 성능을 크게 향상시킵니다. 동시에 DeepSeek-V3의 출력 스타일과 길이도 세밀하게 제어할 수 있습니다.

---


## 3. 모델 다운로드

<div align="center">

| **모델** | **전체 파라미터 수** | **활성 파라미터 수** | **컨텍스트 길이** | **다운로드** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Hugging Face의 DeepSeek-V3 모델 전체 크기는 685B이며, 여기에는 메인 모델 가중치 671B와 다중 토큰 예측(MTP) 모듈 가중치 14B가 포함되어 있습니다.

최적의 성능과 유연성을 보장하기 위해, 우리는 오픈소스 커뮤니티 및 하드웨어 벤더와 협력하여 로컬에서 모델을 실행할 수 있는 다양한 방법을 제공합니다. 단계별 안내는 6장: [로컬 실행 방법](#6-how-to-run-locally)을 참고하세요.

개발자 분들은 [README_WEIGHTS.md](./README_WEIGHTS.md)에서 메인 모델 가중치와 다중 토큰 예측(MTP) 모듈의 상세 내용을 확인하실 수 있습니다. 현재 MTP 지원은 커뮤니티에서 활발히 개발 중이며, 여러분의 기여와 피드백을 환영합니다.

## 4. 평가 결과
### 베이스 모델
#### 표준 벤치마크

<div align="center">


|  | 벤치마크 (측정값) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | 아키텍처 | - | MoE | Dense | Dense | MoE |
| | 활성 파라미터 수 | - | 21B | 72B | 405B | 37B |
| | 전체 파라미터 수 | - | 236B | 72B | 405B | 671B |
| 영어 | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| 코드 | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| 수학 | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| 중국어 | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| 다국어 | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> 최고 결과는 볼드 처리되어 있습니다. 점수 차이가 0.3 이하인 경우 동급으로 간주합니다. DeepSeek-V3는 대부분의 벤치마크, 특히 수학 및 코드 태스크에서 최고의 성능을 달성합니다.
> 추가 평가 세부 내용은 논문을 참고하세요.

#### 컨텍스트 윈도우
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

``Needle In A Haystack`` (NIAH) 테스트에서의 평가 결과입니다. DeepSeek-V3는 **128K**까지 모든 컨텍스트 윈도우 길이에서 우수한 성능을 보입니다.

### 챗 모델
#### 표준 벤치마크 (67B 이상 모델)
<div align="center">

| | **벤치마크 (측정값)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | 아키텍처 | MoE | MoE | Dense | Dense | - | - | MoE |
| | 활성 파라미터 수 | 21B | 21B | 72B | 405B | - | - | 37B |
| | 전체 파라미터 수 | 236B | 236B | 72B | 405B | - | - | 671B |
| 영어 | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| 코드 | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| 수학 | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| 중국어 | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> 모든 모델은 출력 길이를 8K로 제한한 환경에서 평가되었습니다. 1000개 미만의 샘플을 포함하는 벤치마크는 강건한 결과를 위해 다양한 온도 설정으로 여러 번 테스트되었습니다. DeepSeek-V3는 최고의 오픈소스 모델이며, 최첨단 폐쇄형 모델들과도 경쟁력 있는 성능을 보입니다.

####  오픈엔디드 생성 평가

<div align="center">



| 모델 | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> 영어 오픈엔디드 대화 평가입니다. AlpacaEval 2.0에서는 길이 제어 승률(length-controlled win rate)을 지표로 사용했습니다.


## 5. 챗 웹사이트 & API 플랫폼
DeepSeek-V3와 대화하려면 DeepSeek 공식 웹사이트를 방문하세요: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

DeepSeek 플랫폼에서는 OpenAI 호환 API도 제공합니다: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. 로컬 실행 방법

DeepSeek-V3는 다음 하드웨어 및 오픈소스 커뮤니티 소프트웨어를 사용하여 로컬에서 배포할 수 있습니다.

1. **DeepSeek-Infer 데모**: FP8 및 BF16 추론을 위한 간단하고 가벼운 데모를 제공합니다.
2. **SGLang**: BF16 및 FP8 추론 모드에서 DeepSeek-V3 모델을 완벽 지원하며, 다중 토큰 예측은 [곧 지원 예정](https://github.com/sgl-project/sglang/issues/2591)입니다.
3. **LMDeploy**: 로컬 및 클라우드 배포를 위한 효율적인 FP8 및 BF16 추론을 지원합니다.
4. **TensorRT-LLM**: 현재 BF16 추론 및 INT4/8 양자화를 지원하며, FP8 지원은 곧 추가될 예정입니다.
5. **vLLM**: DeepSeek-V3 모델의 FP8 및 BF16 모드를 텐서 병렬 및 파이프라인 병렬로 지원합니다.
6. **LightLLM**: FP8 및 BF16을 위한 효율적인 단일 노드 또는 다중 노드 배포를 지원합니다.
7. **AMD GPU**: SGLang을 통해 BF16 및 FP8 모드로 AMD GPU에서 DeepSeek-V3 모델 실행을 지원합니다.
8. **화웨이 Ascend NPU**: 화웨이 Ascend 장치에서 DeepSeek-V3 실행을 지원합니다.

FP8 학습이 프레임워크에 기본적으로 적용되어 있으므로, FP8 가중치만 제공합니다. 실험용으로 BF16 가중치가 필요하다면, 제공되는 변환 스크립트를 사용해 변환할 수 있습니다.

FP8 가중치를 BF16으로 변환하는 예시는 아래와 같습니다.

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face Transformers는 아직 직접 지원되지 않습니다.

### 6.1 DeepSeek-Infer 데모로 추론 (예시)

#### 시스템 요구사항

> [!NOTE] 
> 리눅스와 Python 3.10만 지원합니다. Mac 및 Windows는 지원되지 않습니다.

필수 패키지:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### 모델 가중치 및 데모 코드 준비

먼저 DeepSeek-V3 GitHub 저장소를 클론합니다.

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

`inference` 폴더로 이동하여 `requirements.txt`에 명시된 의존성을 설치합니다. `conda` 또는 `uv` 같은 패키지 관리자를 이용해 가상환경을 생성한 뒤 설치하는 것이 가장 쉽습니다.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Hugging Face에서 모델 가중치를 다운로드 받아 `/path/to/DeepSeek-V3` 폴더에 넣으세요.

#### 모델 가중치 변환

Hugging Face 모델 가중치를 지정된 포맷으로 변환합니다.

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### 실행

이제 DeepSeek-V3와 대화할 수 있습니다.

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

또는 파일 기반 배치 추론:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 SGLang으로 추론 (권장)

[SGLang](https://github.com/sgl-project/sglang)은 현재 [MLA 최적화](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8(W8A8), FP8 KV Cache, Torch Compile 등을 지원하여 오픈소스 프레임워크 중 최고 수준의 지연시간 및 처리량을 제공합니다.

특히, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1)은 **NVIDIA 및 AMD GPU** 모두에서 DeepSeek-V3를 완벽하게 지원하여 매우 다양한 환경에서 활용할 수 있습니다.

SGLang은 [다중 노드 텐서 병렬 처리](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208)를 지원하여, 여러 네트워크 연결 머신에서 본 모델을 실행할 수 있습니다.

다중 토큰 예측(MTP)은 개발 중이며, [최적화 계획](https://github.com/sgl-project/sglang/issues/2591)에서 진행 상황을 확인할 수 있습니다.

실행 방법은 SGLang 팀의 안내를 참고하세요: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 LMDeploy로 추론 (권장)
[LMDeploy](https://github.com/InternLM/lmdeploy)는 대형 언어 모델에 특화된 유연하고 고성능의 추론 및 서빙 프레임워크로, DeepSeek-V3를 지원합니다. 오프라인 파이프라인 처리와 온라인 배포 모두 가능하며, PyTorch 기반 워크플로와 자연스럽게 통합됩니다.

자세한 단계별 실행법은 다음을 참고하세요: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 TRT-LLM으로 추론 (권장)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM)은 DeepSeek-V3 모델을 지원하며, BF16 및 INT4/INT8 가중치 전용의 정밀도를 제공합니다. FP8 지원은 곧 추가될 예정입니다. DeepSeek-V3 지원을 위해 특별히 제작된 TRTLLM 커스텀 브랜치는 다음에서 확인할 수 있습니다: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3

### 6.5 vLLM으로 추론 (권장)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6은 NVIDIA 및 AMD GPU 모두에서 FP8 및 BF16 모드의 DeepSeek-V3 추론을 지원합니다. 표준 기법 외에도 _파이프라인 병렬화_를 제공하여, 네트워크로 연결된 여러 머신에서 본 모델을 실행할 수 있습니다. 자세한 가이드는 [vLLM 문서](https://docs.vllm.ai/en/latest/serving/distributed_serving.html)를 참고하세요. [기능 향상 계획](https://github.com/vllm-project/vllm/issues/11539)도 참고 바랍니다.

### 6.6 LightLLM으로 추론 (권장)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1은 DeepSeek-R1(FP8/BF16)의 단일/다중 머신 텐서 병렬 배포를 지원하고, 혼합 정밀도 배포 및 다양한 양자화 모드가 지속적으로 통합되고 있습니다. 자세한 내용은 [LightLLM 사용법](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html)을 참고하세요. LightLLM은 DeepSeek-V2의 PD-분리형(PD-disaggregation) 배포도 제공하며, DeepSeek-V3용 PD-분리형 구현도 개발 중입니다.

### 6.7 AMD GPU 추천 추론 기능

AMD 팀과의 협력을 통해, SGLang을 사용한 AMD GPU에 대한 Day-One 지원을 달성하였으며, FP8 및 BF16 모두 완벽히 호환됩니다. 자세한 안내는 [SGLang 설명](#63-inference-with-lmdeploy-recommended)을 참고하세요.

### 6.8 화웨이 Ascend NPU 추천 추론 기능
화웨이 Ascend 커뮤니티의 [MindIE](https://www.hiascend.com/en/software/mindie) 프레임워크가 DeepSeek-V3의 BF16 버전을 성공적으로 적용하였습니다. Ascend NPU용 단계별 안내는 [여기](https://modelers.cn/models/MindIE/deepseekv3)를 참고하세요.

## 7. 라이선스
이 코드 저장소는 [MIT 라이선스](LICENSE-CODE)에 따라 라이선스가 부여됩니다. DeepSeek-V3 베이스/챗 모델의 사용은 [모델 라이선스](LICENSE-MODEL)를 따릅니다. DeepSeek-V3 시리즈(베이스 및 챗 포함)는 상업적 사용을 지원합니다.

## 8. 인용
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. 문의
질문이 있으시면 이슈를 남기시거나 [service@deepseek.com](service@deepseek.com)으로 문의해 주세요.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---