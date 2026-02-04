# AutoDefense: 다중 에이전트 LLM 감옥 탈출 공격 방어

[**블로그**](https://microsoft.github.io/autogen/0.2/blog/2024/03/11/AutoDefense/Defending%20LLMs%20Against%20Jailbreak%20Attacks%20with%20AutoDefense/)

## 설치

```bash
pip install vllm autogen pandas retry openai
```
## [vLLM](https://docs.vllm.ai/)을 사용한 추론 서비스 준비

vLLM은 효율적인 추론과 다중 GPU 간 내장 로드 밸런싱을 제공하는 OpenAI 호환 API 서버를 제공합니다.

### vLLM 서버 시작

원하는 모델로 vLLM 서버를 시작합니다. 다중 GPU 설정의 경우 자동 로드 밸런싱을 활성화하려면 `--data-parallel-size`를 사용하세요:

**단일 GPU:**

```bash
vllm serve Qwen/Qwen3-1.7B --port 8000
```

**다중 GPU (예: 데이터 병렬 처리로 2개의 GPU):**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000 --data-parallel-size 2
```

**더 큰 모델을 위한 텐서 병렬 처리:**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 4
```

**결합된 텐서 및 데이터 병렬 처리 (8 GPU, 2방향 TP × 4방향 DP):**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 2 --data-parallel-size 4
```
내부 부하 분산을 사용하는 데이터 병렬 배포에 대한 자세한 내용은 [vLLM 문서](https://docs.vllm.ai/en/latest/serving/data_parallel_deployment/)를 참조하세요.

### 서버 확인

모델 엔드포인트를 확인하여 서버가 실행 중인지 확인할 수 있습니다:


```bash
curl http://localhost:8000/v1/models
```

## 응답 생성

응답은 vLLM이 제공하는 대상 모델(기본값: `Qwen/Qwen3-1.7B`)에 의해 생성됩니다. 다음 명령을 실행하기 전에 vLLM 서버가 실행 중인지 확인하세요.

### 공격 프롬프트 (유해)

```bash
python attack/attack.py --model Qwen/Qwen3-1.7B --host 127.0.0.1 --port 8000
```
이 명령은 `data/prompt/attack_prompt_template.json`에서 불러온 공격 프롬프트 템플릿(기본값: `--template v1`)을 사용하여 응답을 생성합니다.  
여러 번 반복 실행하려면 스크립트를 여러 번 호출하고 `--output-suffix` 및/또는 `--cache-seed`를 변경하십시오.  

### 안전한 프롬프트 (양성)  

안전/양성 프롬프트(오탐 평가용)용 응답을 생성하려면:


```bash
python attack/attack.py \
    --model Qwen/Qwen3-1.7B \
    --template placeholder \
    --prompts data/prompt/safe_prompts.json \
    --output-prefix safe
```
`placeholder` 템플릿은 공격 프레임 없이 프롬프트를 그대로 전달하는 반면, `v1`은 프롬프트를 탈옥(jailbreak) 지침으로 감쌉니다.

## 방어 실험 실행

다음 명령은 1-에이전트, 2-에이전트, 3-에이전트 방어 실험을 실행합니다. `--chat-file`은 `attack/attack.py`에 의해 생성된 유해 출력물을 가리켜야 하며(기본적으로 `data/harmful_output/<model_dir>/`에 저장됨, 예: `data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json`)입니다.


```bash
export AUTOGEN_USE_DOCKER=0

python defense/run_defense_exp.py \
  --model Qwen/Qwen3-1.7B \
  --chat-file data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json
```

### 명령줄 인수

| 인수 | 설명 | 기본값 |
|----------|-------------|---------|
| `--model` | vLLM이 서비스하는 대상 모델 | `Qwen/Qwen3-1.7B` |
| `--chat-file` | 유해 출력이 포함된 채팅 파일 경로 | 필수 |
| `--port` | vLLM 서버가 실행 중인 포트 | `8000` |
| `--host` | vLLM 서버의 호스트명 | `127.0.0.1` |
| `--output-dir` | 출력 디렉터리 | `data/defense_output/<model_dir>` |
| `--output-suffix` | 출력 디렉터리 접미사 | `""` |
| `--strategies` | 실행할 방어 전략 | `ex-2 ex-3 ex-cot` |
| `--workers` | 병렬 작업자 수 | `128` |
| `--frequency_penalty` | 생성 시 빈도 페널티 | `0.0` |
| `--presence_penalty` | 생성 시 존재 페널티 | `0.0` |
| `--temperature` | 생성 시 온도 | `0.7` |

방어 실험을 마친 후, 출력은 `data/defense_output/<model_dir>/` (예: `data/defense_output/Qwen-Qwen3-1.7B/`)에 나타납니다.

## GPT 평가 (논문에서는 GPT-4 사용)

유해 출력 방어 평가:

```bash
python evaluator/gpt4_evaluator.py \
--defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
--ori_prompt_file_name prompt_dan.json
```
평가가 완료되면 출력 결과는 `data/defense_output/Qwen-Qwen3-1.7B/asr.csv`에 나타납니다.  
출력 `json` 파일에는 각 방어 출력에 대한 `score` 값도 표시됩니다.  
`evaluator/gpt4_evaluator.py`는 평가자로 GPT 모델을 사용합니다(원본 논문에서는 GPT-4를 사용).  
OpenAI 자격 증명을 환경 변수(또는 CLI 플래그)를 통해 설정하고, `--model`을 사용하여 평가자를 최신 GPT 모델(e.g., GPT-5)로 교체할 수 있습니다.  

```bash
export OPENAI_API_KEY=...
# optional (only if you use an OpenAI-compatible endpoint):
# export OPENAI_BASE_URL=...

python evaluator/gpt4_evaluator.py \
  --defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
  --ori_prompt_file_name prompt_dan.json \
  --model gpt-4-1106-preview
```
GPT 기반 평가에는 비용이 많이 들 수 있으므로, 반복 평가를 피하기 위해 캐싱을 활성화합니다.

안전한 응답 평가를 위해 GPT-4를 사용하지 않는 효율적인 방법이 있습니다. 데이터셋의 모든 프롬프트가 일반 사용자 프롬프트이며 거부해서는 안 되는 경우, 다음 명령어를 사용하여 방어 출력의 위양성률(FPR)을 평가할 수 있습니다.


```bash
python evaluator/evaluate_safe.py
```

이 스크립트는 `data/defense_output` 내에서 `-safe` 키워드를 포함하는 모든 출력 폴더를 찾아서 거짓 양성 비율(FPR)을 평가합니다.
FPR은 `data/defense_output/defense_fp.csv` 파일에 저장됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---