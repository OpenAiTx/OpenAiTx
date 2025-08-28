
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">영어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">간체중국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">번체중국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">일본어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">힌디어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">태국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">프랑스어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">독일어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">스페인어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">이탈리아어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">러시아어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">포르투갈어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">네덜란드어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">폴란드어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">아랍어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">페르시아어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">터키어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">베트남어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">인도네시아어</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU 로고" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud 로고" width="50" style="vertical-align:middle;margin-left:10px;">

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

## 뉴스
- [2025-08-22] **버그 수정**: Bird-Interact-Agent 코드에서 phase-2 SQL 평가 시 저장된 phase-1 SQL이 성공적으로 실행되지 않아 Phase-2의 성공률이 낮아지는 버그를 수정했습니다. 이 버그는 phase1 sql이 데이터베이스에 대해 CREATE table 등 일부 작업을 수행하는 작업에만 영향을 미칩니다.

## 🧸 개요

BIRD-INTERACT는 인터랙티브 텍스트-투-SQL 벤치마크로, **동적 상호작용의 관점에서 Text-to-SQL 평가를 재해석**합니다.
이 환경은 계층적 지식베이스, 데이터베이스 문서화 및 함수 기반 사용자 시뮬레이터를 결합하여 실제 엔터프라이즈 환경을 전체 **CRUD** 작업에 걸쳐 재현합니다.
두 가지 엄격한 테스트 모드: (1) 수동적인 **대화형 인터랙션**과 (2) 능동적인 **에이전틱 인터랙션**을 제공합니다. 600개의 주석이 달린 작업에는 비즈니스 인텔리전스(BI), CRUD 작업 등이 포함되어 있으며, 각각 실행 가능한 테스트 케이스로 보호됩니다.
일반적인 평가에서는 모델과 사용자 시뮬레이터 간에 1,968~5,496회의 인터랙션 턴이 발생하며, 최첨단 추론 모델은 현재 전체 작업의 **약 24%** 및 **약 18%**만 해결하여 벤치마크의 도전성을 보여줍니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 두 가지 평가 모드

BIRD-INTERACT는 위에서 언급한 두 가지 평가 모드를 지원합니다:

   - **c-Interact**: 대화형 인터랙션으로, 수동적 모드이며 워크플로우가 고정되어 있습니다. 코드 및 자세한 정보는 `bird_interact_conv`에서 확인할 수 있습니다.
   - **a-Interact**: 에이전틱 인터랙션으로, 구현된 능동적 모드이며 워크플로우가 동적으로 모델에 의해 주도됩니다. 코드 및 자세한 정보는 `bird_interact_agent`에서 확인할 수 있습니다.


### 🐣 라이트 버전

PostgreSQL을 위한 270개의 고품질 실제 작업을 포함한 BIRD-INTERACT의 라이트 버전 `bird-interact-lite-exp`을 출시합니다. 빠른 실험을 시작하기에 좋은 출발점입니다.

### 🦜 풀 버전

BIRD-INTERACT의 풀 버전 `bird-interact-full`은 PostgreSQL을 위한 600개의 작업을 포함하는 종합적인 벤치마크입니다. 다양한 SQL 작업과 사용자 질의를 포괄합니다. 풀 버전은 곧 출시될 예정입니다.

### BIRD-INTERACT Lite에서의 모델 성능 결과

#### 1. **c-Interact** 성능
| 순위 | 모델명               | 정규화 보상 | 레벨            |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 우수한 챗      |
| 2    | GPT-4o             | 30.33 | 💎 좋은 챗        |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 좋은 챗        |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 표준           |
| 5    | DeepSeek-R1        | 21.74 | ✨ 표준           |
| 6    | Qwen3              | 20.33 | ⚪ 기본           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 기본           |

#### 2. **a-Interact** 성능
| 순위 | 모델명               | 예산 파라미터* | 평균 단계/작업 | 평균 비용 (USD)/작업 | 정규화 보상 | 레벨                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 우수한 상호작용      |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 좋은 상호작용        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 좋은 상호작용        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 표준                 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 표준                 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 기본                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 기본                 |

> \* 예산 파라미터: 시작 예산/사용자 인내심 예산, 당사의 가상 화폐 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">로 측정됩니다. 자세한 내용은 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)를 참조하십시오.

### 상호작용 시간 스케일링(ITS)

상호작용 시간 스케일링(ITS)은 모델이 다중 턴 상호작용을 통해 최종 성능을 지속적으로 향상시킬 수 있는 능력을 의미합니다. 이 상호작용 성능이 완전히 명확하게 지정된 단일 턴 작업에서의 모델 이상화 성능을 초과하면, 우리는 **ITS 법칙**을 만족한다고 말합니다. 사용자의 인내심이 증가하고 상호작용 턴이 누적되면 성능이 계속 향상되어 모델이 장기간 대화에서 효과적인 소통을 유지할 수 있음을 보여줍니다. 현재 claude-3-7-sonnet만이 ITS 법칙을 만족하는 것으로 확인되었습니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 데이터셋 상세 정보

### 데이터셋 설명

- **데이터베이스:** 전체 PostgreSQL 데이터베이스는 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view)에서 다운로드할 수 있습니다. 자세한 내용은 [Quick Eval](#quick-eval) 섹션을 확인하세요.
- **data:** 각 데이터 인스턴스는 다음 주요 부분을 포함합니다:
   - `selected_database`: 데이터베이스의 이름.  
   - `query`: 명확한 사용자 질의.  
   - `amb_user_query`: 모호성이 주입된 사용자 질의.
   - `user_query_ambiguity`: 사용자 질의에 주입된 모호성.
   - `non_critical_ambiguity`: 정렬, 제한 등과 같은 비핵심 모호성.
   - `knowledge_ambiguity`: 외부 지식이 마스킹되어 생성된 모호성. 
   - `sol_sql`: 정답 SQL 솔루션.  
   - `preprocess_sql`: 솔루션 또는 예측 실행 전 실행할 SQL 쿼리.  
   - `clean_up_sql`: 데이터베이스 변경 사항을 되돌리기 위해 테스트 케이스 이후 실행할 SQL 쿼리.  
   - `test_cases`: 예측된 수정 SQL을 검증하기 위한 테스트 케이스 집합.
   - `follow_up`: 라벨링된 후속 질문.
   - `external_knowledge`: 특정 작업과 관련된 외부 지식.

- **evaluation:** 평가 코드는 [`./evaluation`](./evaluation) 디렉토리에서 확인할 수 있습니다.
- **제작:** BIRD 팀 & Google Cloud
- **라이선스:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 데이터셋 카드:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 데이터셋 사용

자동 크롤링으로 인한 데이터 누수를 방지하기 위해 GT 솔루션 SQL과 테스트 케이스를 데이터와 함께 포함하지 않습니다.
전체 세트가 필요하면 제목에 `[bird-interact-lite GT&Test Cases]` 태그를 포함하여 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)로 이메일을 보내주시면 자동으로 발송됩니다.


<!-- ### HuggingFace에서 데이터셋 사용

다음 명령어를 사용하여 HuggingFace에서 데이터셋을 다운로드할 수 있습니다:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
또는 제공된 스크립트를 사용하여 전체 버전의 데이터셋을 다운로드하고 서로 다른 방언으로 분할할 수 있습니다.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 입력 JSONL 파일의 경로 (데이터셋을 HuggingFace에서 다운로드하려면 비워둘 수 있음)
  --output_folder path/to/output_dir # 분할된 파일의 출력 폴더
```

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
**a-interact** 실행에 대한 자세한 내용은 `./bird_interact_agent/README.md`에서 확인할 수 있습니다; **c-interact**에 대한 내용은 `./bird_interact_conv/README.md`에서 확인할 수 있습니다.

## 📰 뉴스

🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 세트의 출시를 발표하게 되어 매우 기쁩니다!  
이번 세트는 매우 어려운 문제로, 최고의 LLM들도 **16.33%**의 성공률만 달성하고 있으며, `c-interact`와 `a-interact` 부분에서는 불과 **10.0%**에 그치고 있습니다.  
👉 자세한 내용은 [프로젝트 웹사이트](https://bird-interact.github.io/)를 방문해 주세요.

📬 이번 주에 **정답 및 테스트 케이스**를 메일링 리스트에 발송할 예정입니다.  
조기 접근을 원하시면 사이트에 안내된 대로 이메일을 보내시면 **자동 다운로드**가 가능합니다.  

💾 참고로, 로컬 연구를 더 쉽게 할 수 있도록 **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**의 SQLite 버전도 출시했습니다.  
전체 **LiveSQLBench-Base** 및 **-Large** 버전도 곧 출시될 예정입니다!

## 📋 할 일 목록

- [x] 라이트 버전 출시, bird-interact-lite (270).
- [x] 대화형 버전 출시, bird-interact-conv.
- [x] 에이전트 버전 출시, bird-interact-agent.
- [x] 전체 버전 출시, bird-interact-full (600).
- [ ] 사용자 시뮬레이터 SFT / RL

## 제작:
BIRD 팀 & Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---