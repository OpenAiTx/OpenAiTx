<center>
  <h1>ChinaTravel: 중국 여행 계획을 위한 언어 에이전트의 실제 벤치마크
</h1>
</center>

"ChinaTravel: 중국 여행 계획을 위한 언어 에이전트의 실제 벤치마크" 논문의 공식 코드베이스입니다.

<!-- | [웹페이지](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [논문](https://arxiv.org/abs/2412.13682) | [데이터셋(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![웹페이지](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![논문](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![데이터셋(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![대회(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![대회(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![개요](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 여행 계획 챌린지 (TPC@IJCAI)

중국 여행 계획(ChinaTravel)이 **IJCAI 2025 여행 계획 챌린지(TPC)** 공식 벤치마크로 선정되었음을 자랑스럽게 발표합니다!

**공식 대회 웹사이트**:  
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

참가자들은 복잡한 제약 조건 하에서 실제 여행 계획 시나리오를 해결할 수 있는 새로운 에이전트를 개발하도록 초대됩니다. 이 대회는 언어 에이전트 연구의 최첨단 접근법을 선보일 것입니다.

## 📝 변경 기록

### 2025.09
1. TPC@IJCAI2025 DSL 트랙 우승 솔루션 업로드. [@evergreenee](https://github.com/evergreenee)님의 기여에 감사드립니다.  


### 2025.06

1. 상식 평가 코드의 오류 수집 수정.  
2. 순수 신경망 에이전트 파이프라인 수정.  
3. huggingface에서 load_datasets 함수 수정.  
4. 구문 검증 예외 처리 업데이트.


### 2025.05

1. 최신 버전 업데이트 로그.
2. TPC 평가 코드 제공.

### 2025.04

1. 로컬 데이터 로더 추가. 사용자가 맞춤 쿼리를 로컬에서 불러올 수 있습니다. "run_exp.py" 실행 시 기본값이 아닌 splits_name 값(예: "abc")을 지정하면, 시스템은 evaluation/default_splits/abc.txt에 있는 해당 파일을 자동으로 불러옵니다. TXT 파일에는 대상 쿼리 파일명이 포함되어 있습니다.
2. 상세 제약 조건 분류. 자세한 내용은 [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md) 참조.
3. LLM-modulo 베이스라인 도입
   실제 기호 검증기와 함께 LLM-modulo 파이프라인 구현.
   방법론 기반:
   논문: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   코드베이스: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Qwen3-8B/4B를 이용한 로컬 LLM 추론 지원.

## 🚀 빠른 시작

### ⚙️ 설정

1. conda 환경을 생성하고 의존성을 설치하세요:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```
2. 데이터베이스를 다운로드하여 "chinatravel/environment/" 디렉토리에 압축을 풉니다

다운로드 링크: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. 오픈 소스 LLM을 다운로드합니다(선택 사항).


```bash
bash download_llm.sh
```
4. 토크나이저를 다운로드합니다.


```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ 실행

우리는 deepseek(공식 deepseek API), gpt-4o(chatgpt-4o-latest), glm4-plus, 그리고 Qwen(Qwen3-8B), llama, mistral(Mistral-7B-Instruct-v0.3) 등과 같은 로컬 추론을 지원합니다.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**참고**:

- `--oracle_translation` 플래그는 주석이 포함된 실제 정답에 대한 접근을 활성화합니다:

  - `hard_logic_py`: 실행 가능한 검증 DSL 코드
  - `hard_logic_nl`: 해당 제약 조건 설명
  - 예제 주석 구조:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- LLM-모듈로 방법은 기호 정제 과정을 위해 oracle_translation 모드를 **필수로** 요구합니다

### 📊 평가

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```

TPC@IJCAI2025에서는 평가 코드를 `eval_tpc.py` 파일로 제공합니다. 평가 코드는 다음과 같이 실행할 수 있습니다:

```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 Docs

[환경](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[제약 조건](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ 고급 개발

### 1. 나만의 에이전트 알고리즘 개발

나만의 에이전트 알고리즘을 개발하려면 `chinatravel/agent/base.py`의 `BaseAgent` 클래스를 상속받고 `chinatravel/agent/load_model.py`의 `init_agent` 함수에 알고리즘 로직을 추가해야 합니다. 빈 에이전트 예제로 `TPCAgent`가 제공됩니다.

단계:

- **`BaseAgent` 클래스 상속**: `chinatravel/agent` 디렉토리에 새 파이썬 파일을 만들고 `BaseAgent`를 상속받아 나만의 에이전트 클래스를 정의합니다.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **init_agent 함수에 코드 추가**: chinatravel/agent/load_model.py 파일을 열고 init_agent 함수에서 새로운 에이전트를 지원하도록 코드를 추가하세요.

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. 자체 로컬 LLM 개발하기

자체 로컬 대형 언어 모델(LLM)을 개발하려면 chinatravel/agent/llms.py에서 AbstractLLM 클래스를 상속받고 llms.py에 해당 로컬 LLM 추론 코드를 추가해야 합니다. 우리는 TPCLLM이라는 빈 LLM 예제를 제공합니다.  
단계:

- **AbstractLLM 클래스 상속**: chinatravel/agent/llms.py 파일에서 AbstractLLM을 상속받아 자신만의 LLM 클래스를 정의합니다.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **init_agent 함수에 코드 추가**: chinatravel/agent/load_model.py 파일을 열고 init_llm 함수에 새로운 llm에 대한 지원을 추가하세요.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. 실험 스크립트를 사용하여 코드 실행하기

위 개발을 완료한 후, 실험 스크립트를 사용하여 코드를 실행할 수 있습니다.

실행 예시:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
결과는 `results/YourMethodName_YourLLMName_xxx` 디렉토리에 저장됩니다. 예: `results/TPCAgent_TPCLLM`.

## ✉️ 연락처

문제가 있으시면 [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn)에게 연락해 주세요.

## 📌 인용

저희 논문이나 관련 자료가 연구에 도움이 되었다면, 인용해 주시길 부탁드립니다.


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---