<translate-content># 타임캡슐 LLM
특정 시기 데이터만으로 학습된 LLM으로 현대 편향을 줄임.

AI 모델이 단순히 역사적인 척 하는 게 아니라 실제로 그러하다면 어떨까.

[Andrej Karpathy의 nanoGPT](https://github.com/karpathy/nanoGPT) 기반으로 구축되었으며 핵심 학습 스크립트와 모델 아키텍처는 그의 작품임.

# 프로젝트 목표

타임캡슐 LLM은 특정 시기 동안 작성된 텍스트만으로 학습되는 실험적 프로젝트입니다. 목표는 특정 역사 시대의 세계관과 언어를 시뮬레이션하는 것입니다.

# 왜 파인튜닝만으로는 부족한가

사전 학습된 모델을 파인튜닝만 하면 여전히 현대 개념을 알게 됩니다. 물론 완전한 현대 편향 제거는 어렵지만 최대한 가깝게 가고 싶습니다. 현대 편향이 전혀 없는 모델을 만들려면 처음부터 학습해야 합니다.

# 예상 결과

완성 시 이 모델은 현대 개념을 알지 못하며 학습한 범위를 넘어 추론하지 못할 것입니다. 현대 개념이나 어휘를 인식하지 못하고, 현대 지식을 환각하지 않기를 바랍니다.

# 진행 상황 업데이트

## 2025년 7월 9일

학습 시기를 1800-1850년, 지역은 런던으로 설정했습니다.

텍스트, 책, 문서 목록을 수집했습니다.

현재까지 50개의 txt 파일을 확보했고 곧 NanoGPT 학습을 시작할 예정입니다.

진행되는 한 계속 업데이트하겠습니다.

## 2025년 7월 13일

187MB 분량의 역사 텍스트 데이터로 nanoGPT를 학습했습니다.

## 2025년 7월 15일

두 번째 학습을 위해 텍스트를 다운로드하기 시작했습니다. 인터넷 아카이브에서 모두 가져오고 학습 기간을 1800-1875년으로 확장했습니다. 다양한 텍스트를 얻으려면 인터넷 아카이브에서 출판 위치, 기간, 주제별 필터를 사용할 수 있습니다.

![검색 필터](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025년 7월 16일

인터넷 아카이브에서 약 500개의 txt 파일을 다운로드했고, 공백, 구텐베르크 헤더 등을 삭제해 정리한 결과 약 500MB의 데이터가 확보되었습니다. 데이터셋은 작지만 지난번 187MB 데이터보다 많으니 두 번째 모델 학습 후 출력에 어느 정도 차이가 있을 것입니다. 최소한 좀 더 일관성 있고 의미 있는 문장을 생성하길 기대합니다. 물론 데이터셋이 여전히 매우 작아 보장할 순 없습니다.

자체 하드웨어로 가능한 작업이며, 더 큰 데이터셋 학습 전에 개선점을 확인할 수 있어 좋습니다. 이후에는 GPU를 임대해 학습할 계획이지만 그 전에 데이터셋을 최대한 잘 정리하고 싶습니다. 문제는 많은 txt 파일에 잡음이 섞여 있다는 점입니다. 사용한 정리 스크립트가 작동하긴 하지만 100% 효과적이지는 않습니다.

오늘 이 데이터셋으로 학습할 예정이며 4-5시간 정도 소요될 것입니다. 완료 후 테스트하고 업데이트하겠습니다. 프로젝트를 봐주시는 모든 분들께 감사드립니다. OCR 자료 링크를 보내주신 분들도 계셔서 감사합니다! 더 많은 분들이 자신의 데이터셋으로 실험해 보시길 바랍니다.

### 학습 업데이트

435MB(108M 토큰) 코퍼스로 학습 시작했으며 현재 순조롭습니다. 처음 2800회 반복 동안 학습 손실이 10.9에서 4.9로 떨어졌습니다. 총 8-9시간 정도 걸릴 것으로 예상합니다. 완료 후 다시 업데이트하겠습니다.

## 2025년 7월 17일 2:13AM

두 번째 모델 학습이 완료되었습니다. 제 4060 GPU로 약 8시간 40분(3,900 iters/hr) 걸려 33,000 반복(5 에포크)을 진행했습니다. 최종 학습 손실은 3.73입니다. 출력물이 놀랍게도 매우 좋으며 19세기 스타일의 일관된 문장을 진짜로 생성합니다.

# V0 모델 동작 및 한계

초기 프롬프트에 모델이 1800년대 언어와 행동으로 응답합니다. 예를 들어 "Who art Henry?"라고 묻자 "I know that man, I have did not a black, the storm."라고 답했습니다. 문장은 의미가 없지만 LLM이 인물에 대해 묻는 것을 인식한 것입니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

현대 개념은 전혀 언급되지 않으며 출력에는 대부분 1800년대 단어와 표현이 포함됩니다.

아직 많이 개선이 필요하며 187MB 데이터로는 복잡한 추론이 가능한 텍스트를 만들기 어렵습니다.

현재 문장은 완전한 문장 구조가 부족하고 전반적으로 의미가 없지만 이는 학습 데이터 크기가 작기 때문입니다.

# V0.5 모델 동작 및 한계

지난 모델에 비해 크게 개선되었습니다. 문체와 어휘는 빅토리아 시대 스타일이며 거의 모든 문장이 문법적으로 올바르고 구두점도 적절합니다. 다시 말하지만 처음부터 학습했기에 1800년대 주제에 충실합니다.

![TimeLockLLM 샘플 출력](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

사실적 환각이 많습니다. 세부사항(날짜, 사건, 역사적 인물)의 100%가 만들어진 것입니다. 문장 간 연결도 거의 없으며, 가끔 2문장 정도만 관련이 있습니다. 또 가끔 “Digitized by Google” 바닥글이 나타나서 다음 학습 시 텍스트 정리를 더 철저히 해야 합니다. 전반적으로 결과에 매우 만족하며, 아직 LLM은 아니지만 명백히 문장 생성기입니다.

많이 배우고 있으며 앞으로 개선할 점을 파악할 예정입니다. 곧 파일도 업로드하겠습니다!

# 향후 계획

버전 1 작업을 시작할 예정입니다. 50권 책 대신 이상적으로 500-600권으로 학습할 것입니다. 현재 nanoGPT를 1800-1850년 런던 출판 도서로 학습 중입니다. 도서가 업데이트되거나 현대적 해석이 아닌, 선택한 기간 내에 출판된 원본 도서인지 확인하는 등 과제가 있습니다.

# 프로젝트 사용 방법

이 프로젝트는 주로 역사 데이터 선별, 학습 준비, 토크나이저 구축에 집중합니다. 전체 LLM 학습 과정은 다루지 않으며, 자세한 내용은 Andrej Karpathy의 nanoGPT를 참조하세요.

# 1단계: 역사 텍스트 수집 및 준비

선택한 시기(예: 런던 1800-1850)의 퍼블릭 도메인 도서, 문서 등의 .txt 파일을 모으세요.

필요하면 download_texts_improved.py로 책을 다운로드할 수 있습니다.

스크립트나 수동으로 Project Gutenberg 헤더/푸터, 현대 주석, OCR 오류 등을 삭제해 텍스트를 정리하세요.

prepare_dataset.py가 잘 작동할 것입니다.

# 2단계: 맞춤 토크나이저 구축

정리한 데이터로 train_tokenizer.py 또는 train_tokenizer_hf.py를 실행하세요.</translate-content>
This will give you vocab.json and merges.txt

Thes files define vocab and merge rules for your model

# Step 3: Train Your Model (nanoGPT) 

Refer to [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) for the training process.

You can train a different LLM if you want, but I used nanoGPT 

# FAQ

## Why not just use fine-tuning or LoRA?

For this project I'm trying to create a language model that is unclouded from modern bias. If I fine-tune something like GPT-2, it's already pre-trained and that information won't go away. If I train from scratch the language model won't pretend to be old, it just will be. The Goal for this project right now is to create something can reason exclusively using knowledge from London books published between 1800 and 1850.

## What kind of data did you use for training?

I'm using books, legal documents, newspapers, and other writings from 1800–1850 London. The list I linked has like 200 but for the first training I just used 50 files about ~187 MB. You can view a list of the documents:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## How large is the Version 0 model ?

This model is very small right now, I'm just doing this for fun and following a strict training rule of no modern sources. It has almost 16 million parameters but I'm gonna start gathering more old texts to begin another model training. Will give updates as I go.

## Training Specs ? 

GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---