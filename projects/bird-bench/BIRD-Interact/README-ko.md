# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 🧸 개요

BIRD-INTERACT는 대화형 텍스트-투-SQL 벤치마크로, **동적 상호작용의 관점에서 Text-to-SQL 평가를 재정의**합니다.
이 환경은 계층적 지식 베이스, 데이터베이스 문서화, 그리고 함수 기반 사용자 시뮬레이터를 결합하여 실제 기업 환경에서의 전체 **CRUD** 연산을 재현합니다.
두 가지 엄격한 테스트 모드를 제공합니다: (1) 수동형 **대화형 상호작용**과 (2) 능동형 **에이전트 상호작용**으로, 각각 실행 가능한 테스트 케이스로 보호되는 비즈니스 인텔리전스(BI), CRUD 작업 등 600개의 주석이 달린 태스크를 포함합니다.
일반적인 평가에서는 모델과 사용자 시뮬레이터 간에 1,968-5,496회의 상호작용이 발생하며, 최첨단 추론 모델도 현재 **약 24%** 및 **약 18%**의 태스크만 해결하고 있어 벤치마크의 난이도를 보여줍니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 두 가지 평가 모드

BIRD-INTERACT는 위에서 언급한 두 가지 평가 모드를 지원합니다:

   - **c-Interact**: 대화형 상호작용으로, 수동 모드이며 워크플로우가 고정되어 있습니다. 코드 및 자세한 정보는 `bird_interact_conv`에서 확인할 수 있습니다.
   - **a-Interact**: 에이전트 상호작용으로, 구현된 능동 모드이며 워크플로우가 동적이고 모델이 주도합니다. 코드 및 자세한 정보는 `bird_interact_agent`에서 확인할 수 있습니다.


### 🐣 라이트 버전

BIRD-INTERACT의 라이트 버전인 `bird-interact-lite-exp`를 공개합니다. 이 버전은 PostgreSQL용으로 특별히 선정된 270개의 고품질 실제 태스크를 포함하고 있습니다. 빠른 실험을 시작하기에 적합합니다.

### 🦜 전체 버전

BIRD-INTERACT의 전체 버전인 `bird-interact-full`은 600개의 PostgreSQL용 태스크를 포함하는 포괄적인 벤치마크입니다. 다양한 SQL 연산과 사용자 쿼리를 포괄합니다. 전체 버전은 곧 출시될 예정입니다.

### BIRD-INTERACT Lite에서의 모델 성능 결과

#### 1. **c-Interact** 성능
| 순위 | 모델명              | 정규화된 보상  | 레벨              |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 우수한 챗      |
| 2    | GPT-4o             | 30.33 | 💎 좋은 챗        |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 좋은 챗        |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 표준           |
| 5    | DeepSeek-R1        | 21.74 | ✨ 표준           |
| 6    | Qwen3              | 20.33 | ⚪ 기본           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 기본           |

#### 2. **a-Interact** 성능
| 순위 | 모델명              | 예산 파라미터* | 태스크당 평균 턴 | 태스크당 평균 비용(USD) | 정규화된 보상 | 레벨                  |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 우수한 상호작용       |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 좋은 상호작용         |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 좋은 상호작용         |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 표준                  |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 표준                  |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 기본                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 기본                  |

> \* 예산 파라미터: 시작 예산/사용자 인내 예산, 자체 가상화폐 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">로 측정됨. 자세한 내용은 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)를 참고하세요.

### 상호작용-시간 스케일링(ITS)

상호작용-시간 스케일링(ITS)은 다중 턴 상호작용을 통해 모델이 최종 성능을 지속적으로 향상할 수 있는 능력을 의미합니다. 이 대화형 성능이 명확하게 지정된 단일 턴 태스크에서의 모델의 이상적 성능을 능가할 때, 우리는 이를 **ITS 법칙**을 만족한다고 말합니다. 사용자의 인내심이 커지고 상호작용 턴이 누적될수록 성능은 계속 향상되며, 모델이 장기간 대화에서 효과적으로 소통할 수 있음을 보여줍니다. 현재로서는 claude-3-7-sonnet만이 ITS 법칙을 만족하는 것으로 확인되었습니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 데이터셋 상세 정보

### 데이터셋 설명

- **데이터베이스:** 전체 PostgreSQL 데이터베이스는 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view)에서 다운로드할 수 있습니다. 자세한 내용은 [Quick Eval](#quick-eval) 섹션을 확인하세요.
- **data:** 각 데이터 인스턴스는 다음과 같은 주요 파트로 구성됩니다:
   - `selected_database`: 데이터베이스 이름  
   - `query`: 명확한 사용자 쿼리  
   - `amb_user_query`: 모호성이 주입된 사용자 쿼리
   - `user_query_ambiguity`: 사용자 쿼리에 주입된 모호성
   - `non_critical_ambiguity`: 정렬, limit 등과 같은 비중요 모호성
- `knowledge_ambiguity`: 마스킹된 외부 지식에 의해 생성된 모호성입니다.
- `sol_sql`: 정답 SQL 솔루션입니다.
- `preprocess_sql`: 솔루션이나 예측을 실행하기 전에 실행할 SQL 쿼리입니다.
- `clean_up_sql`: 테스트 케이스 후 데이터베이스에 가해진 변경을 되돌리기 위해 실행하는 SQL 쿼리입니다.
- `test_cases`: 예측된 수정 SQL을 검증하기 위한 일련의 테스트 케이스입니다.
- `follow_up`: 라벨링된 후속 질문입니다.
- `external_knowledge`: 특정 작업과 관련된 외부 지식입니다.

- **evaluation:** 평가 코드는 [`./evaluation`](./evaluation) 디렉토리에서 확인할 수 있습니다.
- **Curated by:** BIRD 팀 & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 데이터셋 사용법

자동 크롤링에 의한 데이터 누수를 방지하기 위해, GT 솔루션 SQL과 테스트 케이스는 데이터와 함께 제공하지 않습니다.
전체 세트가 필요하신 경우 제목에 `[bird-interact-lite GT&Test Cases]` 태그를 포함하여 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) 으로 이메일을 보내주시면 자동으로 발송됩니다.


<!-- ### HuggingFace에서 데이터셋 사용하기

다음 명령어로 HuggingFace에서 데이터셋을 다운로드할 수 있습니다:
```bash
from datasets import load_dataset
# 데이터셋의 flash 버전 불러오기
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# 데이터셋의 전체 버전 불러오기 (곧 제공 예정)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

또는 제공된 스크립트를 사용하여 전체 버전의 데이터셋을 다운로드하고 여러 방언으로 분할할 수 있습니다.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 입력 JSONL 파일의 경로 (HuggingFace에서 데이터셋을 다운로드하려면 비워둘 수 있습니다)
  --output_folder path/to/output_dir # 분할 파일의 출력 폴더
``` -->

## 폴더 구조
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
**a-interact** 실행에 관한 자세한 내용은 `./bird_interact_agent/README.md`에서 확인할 수 있으며, **c-interact**는 `./bird_interact_conv/README.md`에서 확인할 수 있습니다.


## 📋 할 일 목록

- [x] 라이트 버전 공개, bird-interact-lite (270).
- [x] 대화형 버전 공개, bird-interact-conv.
- [x] 에이전트 버전 공개, bird-interact-agent.
- [ ] 전체 버전 공개 예정, bird-interact-full (600).
- [ ] SFT / RL 기반 사용자 시뮬레이터

## 제작:
BIRD 팀 & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---