# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. 소개

저희는 1세대 추론 모델인 DeepSeek-R1-Zero와 DeepSeek-R1을 소개합니다.
DeepSeek-R1-Zero는 감독식 미세조정(SFT) 없이 대규모 강화 학습(RL)만을 통해 학습된 모델로, 추론에서 뛰어난 성능을 보였습니다.
RL을 통해 DeepSeek-R1-Zero는 자연스럽게 강력하고 흥미로운 추론 행동들을 다수 나타냈습니다.
하지만 DeepSeek-R1-Zero는 끝없는 반복, 낮은 가독성, 언어 혼용과 같은 문제에 직면하였습니다. 이러한 문제를 해결하고 추론 성능을 더욱 향상시키기 위해,
RL 이전에 콜드스타트 데이터를 도입한 DeepSeek-R1을 선보입니다.
DeepSeek-R1은 수학, 코드, 추론 과제에서 OpenAI-o1과 유사한 성능을 달성하였습니다.
연구 커뮤니티를 지원하기 위해 DeepSeek-R1-Zero, DeepSeek-R1 및 DeepSeek-R1에서 Llama와 Qwen을 기반으로 증류한 6개의 덴스 모델을 오픈소스로 공개합니다. DeepSeek-R1-Distill-Qwen-32B는 다양한 벤치마크에서 OpenAI-o1-mini를 능가하여 덴스 모델 분야의 새로운 최고 성능을 달성하였습니다.

**참고: DeepSeek-R1 시리즈 모델을 로컬에서 실행하기 전에 [사용 권장사항](#usage-recommendations) 섹션을 확인하시기 바랍니다.**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. 모델 요약

---

**사후 학습: 베이스 모델에 대한 대규모 강화 학습**

-  저희는 감독식 미세조정(SFT) 없이 베이스 모델에 직접 강화 학습(RL)을 적용합니다. 이 접근법을 통해 모델은 복잡한 문제 해결을 위한 Chain-of-Thought(CoT)를 탐색할 수 있으며, 그 결과 DeepSeek-R1-Zero가 탄생하였습니다. DeepSeek-R1-Zero는 자기 검증, 반성, 긴 CoT 생성과 같은 능력을 보여주며, 연구 커뮤니티에 중요한 이정표를 세웠습니다. 특히, SFT 없이 순수하게 RL만으로 LLM의 추론 능력을 유도할 수 있음을 검증한 첫 오픈 연구입니다. 이 혁신은 향후 발전의 길을 엽니다.

-   저희는 DeepSeek-R1 개발을 위한 파이프라인을 소개합니다. 이 파이프라인은 더 나은 추론 패턴을 발견하고 인간 선호와 일치시키기 위한 두 번의 RL 단계와, 모델의 추론 및 비추론 능력의 시드 역할을 하는 두 번의 SFT 단계를 포함합니다.
    이 파이프라인은 더 나은 모델을 개발하여 산업계에 도움이 될 것이라 믿습니다.

---

**증류: 작은 모델도 강력할 수 있습니다**

-  대형 모델의 추론 패턴을 작은 모델에 증류할 수 있음을 입증하였으며, 이는 소형 모델에서 RL로 발견한 패턴보다 더 나은 성능을 보여줍니다. 오픈소스 DeepSeek-R1 및 그 API는 향후 더 우수한 소형 모델 증류에 연구 커뮤니티에 도움이 될 것입니다.
- DeepSeek-R1이 생성한 추론 데이터를 활용하여 연구 커뮤니티에서 널리 사용되는 여러 덴스 모델을 파인튜닝하였습니다. 평가 결과, 증류된 소형 덴스 모델들이 벤치마크에서 매우 뛰어난 성능을 보였습니다. Qwen2.5 및 Llama3 시리즈를 기반으로 1.5B, 7B, 8B, 14B, 32B, 70B 체크포인트를 커뮤니티에 오픈소스로 공개합니다.

## 3. 모델 다운로드

### DeepSeek-R1 모델

<div align="center">

| **모델** | **총 파라미터 수** | **활성화 파라미터 수** | **컨텍스트 길이** | **다운로드** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero 및 DeepSeek-R1은 DeepSeek-V3-Base를 기반으로 학습되었습니다.
모델 아키텍처에 대한 자세한 내용은 [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) 저장소를 참고하세요.

### DeepSeek-R1-Distill 모델

<div align="center">

| **모델** | **베이스 모델** | **다운로드** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

DeepSeek-R1-Distill 모델은 DeepSeek-R1이 생성한 샘플을 이용해 오픈소스 모델을 기반으로 파인튜닝되었습니다.
구성(config)과 토크나이저에 약간의 변경이 있으므로, 반드시 저희 설정을 사용해 실행하시기 바랍니다.

## 4. 평가 결과

### DeepSeek-R1 평가
모든 모델의 최대 생성 길이는 32,768 토큰으로 설정하였습니다. 샘플링이 필요한 벤치마크에서는 온도 $0.6$, top-p $0.95$를 적용하며, 쿼리당 64개의 응답을 생성하여 pass@1을 추정합니다.
<div align="center">


| 카테고리 | 벤치마크 (지표) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | 아키텍처 | - | - | MoE | - | - | MoE |
| | 활성화 파라미터 수 | - | - | 37B | - | - | 37B |
| | 총 파라미터 수 | - | - | 671B | - | - | 671B |
| 영어 | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| 코드 | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| 수학 | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| 중국어 | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### 증류 모델 평가

<div align="center">

| 모델                                   | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|----------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>

## 5. 챗 웹사이트 및 API 플랫폼
DeepSeek의 공식 웹사이트 [chat.deepseek.com](https://chat.deepseek.com)에서 DeepSeek-R1과 대화할 수 있으며, "DeepThink" 버튼을 활성화하면 됩니다.

또한 DeepSeek 플랫폼 [platform.deepseek.com](https://platform.deepseek.com/)에서 OpenAI-호환 API도 제공합니다.

## 6. 로컬 실행 방법

### DeepSeek-R1 모델

DeepSeek-R1을 로컬에서 실행하는 자세한 방법은 [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) 저장소를 참고하세요.

**참고: Hugging Face의 Transformers는 아직 직접 지원되지 않습니다.**

### DeepSeek-R1-Distill 모델

DeepSeek-R1-Distill 모델은 Qwen 또는 Llama 계열 모델과 동일한 방식으로 사용할 수 있습니다.

예를 들어, [vLLM](https://github.com/vllm-project/vllm)을 사용해 쉽게 서비스를 시작할 수 있습니다:

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

또는 [SGLang](https://github.com/sgl-project/sglang)을 사용해도 됩니다:

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### 사용 권장사항

**DeepSeek-R1 시리즈 모델(벤치마크 포함)을 사용할 때 기대한 성능을 얻기 위해 다음 설정을 권장합니다:**

1. 온도(temperature)는 0.5~0.7 범위(권장값 0.6)로 설정하여 끝없는 반복 또는 비논리적 출력을 방지하세요.
2. **시스템 프롬프트는 추가하지 말고, 모든 지시는 사용자 프롬프트에 포함시키세요.**
3. 수학 문제의 경우 프롬프트에 "Please reason step by step, and put your final answer within \boxed{}."와 같은 지시문을 포함하는 것이 좋습니다.
4. 모델 성능 평가 시 여러 번 테스트하여 평균 결과를 사용하는 것이 권장됩니다.

또한 DeepSeek-R1 시리즈 모델이 특정 쿼리에 응답할 때 사고 패턴(즉, "\<think\>\n\n\</think\>")을 생략하는 경향이 있어 성능에 악영향을 줄 수 있음을 관찰하였습니다.
**모델이 충분히 논리적으로 추론하도록 매 응답의 시작에 "\<think\>\n"으로 답변이 시작되도록 강제하는 것을 권장합니다.**

### 공식 프롬프트
DeepSeek 공식 웹/앱에서는 시스템 프롬프트를 사용하지 않고 파일 업로드와 웹 검색에 대해 더 나은 사용자 경험을 위한 두 가지 특정 프롬프트를 설계하였습니다. 또한, 웹/앱의 온도 설정은 0.6입니다.

파일 업로드의 경우, {file_name}, {file_content}, {question}이 인자로 들어가는 아래 템플릿을 따르세요.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

웹 검색의 경우, {search_results}, {cur_date}, {question}이 인자입니다.

중국어 쿼리에는 아래 프롬프트를 사용합니다:
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```

영어 쿼리에는 아래 프롬프트를 사용합니다:
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. 라이선스
이 코드 저장소와 모델 가중치는 [MIT 라이선스](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE)를 따릅니다.
DeepSeek-R1 시리즈는 상업적 사용을 지원하며, 모든 수정 및 파생 작업(다른 LLM 훈련을 위한 증류 포함)이 가능합니다. 단, 아래 사항을 참고하세요:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B, DeepSeek-R1-Distill-Qwen-32B는 [Qwen-2.5 시리즈](https://github.com/QwenLM/Qwen2.5)에서 파생되었으며, 원래 [Apache 2.0 라이선스](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE)를 따릅니다. DeepSeek-R1로 선별한 80만 개 샘플로 파인튜닝하였습니다.
- DeepSeek-R1-Distill-Llama-8B는 Llama3.1-8B-Base에서 파생되었으며, 원래 [Llama3.1 라이선스](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE)를 따릅니다.
- DeepSeek-R1-Distill-Llama-70B는 Llama3.3-70B-Instruct에서 파생되었으며, 원래 [Llama3.3 라이선스](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE)를 따릅니다.

## 8. 인용
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. 문의
질문이 있으시면 이슈를 등록하시거나 [service@deepseek.com](mailto:service@deepseek.com)으로 연락 주시기 바랍니다.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---