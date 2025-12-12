
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

## ⚠️ 공지  
평가를 시작하기 전에, Docker가 데이터베이스를 로드할 때 환경 불일치로 인해 오류가 간헐적으로 발생할 수 있습니다(이 오류들은 프로세스를 종료하지 않지만 Docker 로그에 나타납니다). 그 결과 일부 데이터베이스가 제대로 로드되지 않아 비어 있는 데이터베이스가 생길 수 있습니다. 이로 인해 평가 결과가 비정상적으로 낮게 나올 수 있습니다.  
👉 따라서, **평가를 실행하기 전에** Docker 로그에서 오류를 반드시 확인하고 모든 데이터베이스가 성공적으로 로드되었는지 검증할 것을 강력히 권장합니다.

👉 **제출 가이드라인**이 업데이트되었으며, 커스텀 에이전트 스캐폴드도 지원됩니다. 자세한 제출 가이드라인은 [여기](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true)에서 확인하실 수 있습니다.

## 📰 뉴스

- [2025-11-06] 🐛 **버그 수정** & 🐳 **Docker 업데이트**: sqlglot 버전을 26.16.4로 업데이트하여 사용자 시뮬레이터에서 SQL 파서를 제대로 파싱하지 못하던 버그를 수정했습니다. `bird_interact_eval` 환경에서 `pip install sqlglot==26.16.4`로 재설치하면 해결할 수 있습니다. `bird_interact_eval` 이미지도 업데이트되었으니, 이미지를 새로 받아서 `bird_interact_eval` 컨테이너를 재생성해 주세요.

- [2025-10-21] 🐳 **Docker 업데이트**: Full DB Env용 도커를 추가했습니다. 환경 구축을 쉽게 할 수 있도록 (Base/Full DB Env 및 `a-Interact`와 `c-Interact` 평가 환경) 총 3개의 도커 이미지를 Docker Hub에 배포했습니다. DB 덤프를 직접 다운로드하고 이미지를 수동으로 구축할 필요가 없습니다!

- [2025-10-08] 📝 우리의 **[Bird-Interact 논문](https://huggingface.co/papers/2510.05318)**이 공개되었습니다!  
  인터랙티브 텍스트-투-SQL 벤치마크의 전체 세부 정보, 방법론, 평가를 담고 있습니다.  
  👉 [BIRD-Interact](https://bird-interact.github.io/)의 아이디어와 자세한 내용을 확인해보세요.

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 세트 출시를 발표하게 되어 기쁩니다!  
이 세트는 매우 어려운 과제로, 최고 성능의 LLM도 **16.33%** 성공률, `c-interact` 및 `a-interact`에서는 겨우 **10.0%** 성공률을 기록하고 있습니다.  
👉 자세한 내용은 [프로젝트 웹사이트](https://bird-interact.github.io/)를 참고해 주세요.

- [2025-08-26] 📬 이번 주에 **Ground Truth & Test cases**를 메일링 리스트로 발송할 예정입니다.  
빠른 접근을 원하시면, 사이트 안내에 따라 이메일을 보내주시면 **자동 다운로드**를 이용하실 수 있습니다.  

- [2025-08-26] 💾 참고로, 보다 손쉬운 로컬 연구를 위해 **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**의 SQLite 버전도 출시되었습니다.  
전체 **LiveSQLBench-Base** 및 **-Large** 버전은 곧 출시될 예정입니다!

- [2025-08-22] **버그 수정**: Bird-Interact-Agent 코드에서, Phase-2 SQL 평가 시 저장된 Phase-1 SQL이 정상적으로 실행되지 않아 Phase-2 성공률이 낮아지는 버그를 수정했습니다. 이 버그는 오직 phase1 sql이 데이터베이스에서 CREATE table 등 일부 작업을 수행하는 경우에만 영향을 미칩니다.

## 🧸 개요

BIRD-INTERACT는 상호작용형 텍스트-투-SQL 벤치마크로, **동적 상호작용 관점에서 Text-to-SQL 평가를 재구상**합니다.
이 환경은 계층적 지식베이스, 데이터베이스 문서, 함수 기반 사용자 시뮬레이터를 결합하여 실제 기업 환경의 **CRUD** 연산을 재현합니다.
두 가지 엄격한 테스트 모드: (1) 수동 **대화형 상호작용**과 (2) 능동 **에이전트형 상호작용**을 제공하며, 600개의 주석 처리된 비즈니스 인텔리전스(BI), CRUD 연산 등 각종 업무를 실행 가능한 테스트 케이스로 보호합니다.
일반 평가에서는 모델과 사용자 시뮬레이터 간에 1,968~5,496번의 상호작용이 발생하며, 최신 추론 모델은 현재 **≈24%** 및 **≈18%**의 작업만 해결하여 벤치마크의 난이도를 보여줍니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 두 가지 평가 모드

BIRD-INTERACT는 위에서 언급한 두 가지 평가 모드를 지원합니다:

   - **c-Interact**: 대화형 상호작용으로, 수동 모드이며 워크플로우가 고정되어 있습니다. 코드와 상세 정보는 `bird_interact_conv`에서 확인할 수 있습니다.
   - **a-Interact**: 에이전트형 상호작용으로, 모델이 주도하는 능동적이고 동적인 워크플로우입니다. 코드와 상세 정보는 `bird_interact_agent`에서 확인할 수 있습니다.


### 🐣 라이트 버전

BIRD-INTERACT의 라이트 버전인 `bird-interact-lite-exp`를 출시합니다. 이 버전은 PostgreSQL용으로 270개의 고품질 실제 업무 과제를 포함하며, 빠른 실험에 적합합니다.

### 🦜 풀 버전

BIRD-INTERACT의 풀 버전인 `bird-interact-full`은 PostgreSQL용 600개 과제가 포함된 종합 벤치마크입니다. 다양한 SQL 연산과 사용자 질의를 다루며, 곧 출시될 예정입니다.

### BIRD-INTERACT-FULL의 모델 성능 결과

#### 1. **c-Interact Text-to-SQL** 성능
| 순위 | 모델명              | 정규화 보상         | 평균 비용 (USD)/과제 | 레벨                |
|:----:|:-------------------|:-------------------:|:-------------------:|:-------------------:|
| 1    | Gemini-2.5-Pro     | 20.92               | $0.04               | 🏆 우수 챗          |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 우수한 채팅    |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 좋은 채팅      |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 좋은 채팅      |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ 표준           |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ 표준           |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ 기본           |

#### 2. **a-Interact Text-to-SQL** 성능
| 순위 | 모델 이름           | 정규화 보상        | 평균 비용(USD)/작업   | 수준                        |
|:----:|:-------------------|:-----------------:|:-------------------:|:---------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 우수한 상호작용          |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 우수한 상호작용          |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 좋은 상호작용            |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 좋은 상호작용            |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ 표준                     |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ 표준                     |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ 기본                     |

> \* 예산 파라미터: 시작 예산/사용자 인내심 예산, 자체 가상화폐 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">로 측정됩니다. 자세한 내용은 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) 를 참고하세요.

### 상호작용 시간 스케일링(ITS)

상호작용 시간 스케일링(ITS)은 모델이 다중 턴 상호작용을 통해 최종 성능을 지속적으로 높일 수 있는 능력을 의미합니다. 이 상호작용 성능이 모델의 이상화된 단일 턴 성능(완전히 명확한 작업에서)을 초과할 때, **ITS 법칙**을 만족한다고 합니다. 사용자의 인내심이 높아지고 상호작용 턴이 쌓일수록 성능이 계속 향상되어, 모델이 장기간 대화에서도 효과적인 소통을 지속할 수 있음을 보여줍니다. 현재 claude-3-7-sonnet만 ITS 법칙을 만족하는 것으로 확인됩니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 환경 설정

1. bird-interact-lite 데이터베이스, bird-interact-full 데이터베이스 및 평가 환경에 대해 Docker 컨테이너를 실행합니다:
  
  > `bird-interact-lite`만 평가하려는 경우, 환경 설정 속도를 높이기 위해 `docker-compose.yml`에서 [`postgresql_full` 서비스](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31)를 주석 처리할 수 있습니다.
  
  다음 명령어로 환경을 시작하세요:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   데이터베이스 초기화가 완료될 때까지 몇 분 정도 기다리세요.

  다음 방법으로 구축 진행 상황을 추적할 수 있습니다:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  완료되면 오류 없이 로그를 볼 수 있어야 합니다:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  이전에 컨테이너를 생성한 적이 있고 다시 생성하려면 다음 명령을 실행할 수 있습니다:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   이 명령은 Docker Hub에서 미리 빌드된 이미지를 사용하여 3개의 컨테이너를 실행합니다:
   - `bird_interact_postgresql`: bird-interact-lite용 PostgreSQL 데이터베이스
   - `bird_interact_postgresql_full`: bird-interact-full용 PostgreSQL 데이터베이스
   - `bird_interact_eval`: `a-Interact` 및 `c-Interact` 모두를 위한 평가 환경

   이제 다음 명령어를 실행하여 평가 환경을 시작할 수 있습니다:
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (선택사항) 환경을 수동으로 구축하기 (이미지를 처음부터 빌드하려는 경우): 
   - 데이터베이스 덤프 다운로드 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). 압축을 풀고 `env/postgre_table_dumps`로 이름을 변경합니다.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). 압축을 풀고 `env/postgre_table_dumps_full`로 이름을 변경합니다.
   - `docker-compose.build.yml`을 실행하여 환경을 수동으로 구축합니다.

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (권장) 데이터베이스 컨테이너가 성공적으로 빌드되고 실행 중인지 확인합니다.

- 데이터베이스가 오류 없이 성공적으로 빌드되었는지 확인하려면 컨테이너 빌드 로그를 출력하세요:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   오류가 발생하면 `"Errors occurred during import:"`가 로그 파일에 출력됩니다.


-  데이터베이스 컨테이너가 정상인지 확인하세요.
   
   제공된 Python 스크립트를 사용하여 데이터베이스 메타데이터를 확인하세요:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   기대 결과:
   - **bird-interact-lite**: 
     - 📈 전체 데이터베이스: 18개
     - 📋 전체 테이블: 175개
     - 🔢 전체 컬럼: 2286개
     - 📈 테이블당 평균 행 수: 1,038.48
     - 💾 전체 크기: 약 207.15 MB
   - **bird-interact-full**: 
     - 📈 전체 데이터베이스: 22개
     - 📋 전체 테이블: 244개
     - 🔢 전체 컬럼: 2011개
     - 📈 테이블당 평균 행 수: 1,121.19
     - 💾 전체 크기: 약 272.00 MB


## 📦 데이터셋 상세 정보

### 데이터셋 설명

- **Database:** 전체 PostgreSQL 데이터베이스는 [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)와 [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)에서 다운로드할 수 있습니다.
- **data:** 각 데이터 인스턴스는 다음의 주요 부분을 포함합니다:
   - `selected_database`: 데이터베이스의 이름  
   - `query`: 모호성이 없는 사용자 쿼리  
   - `amb_user_query`: 모호성이 삽입된 사용자 쿼리
   - `user_query_ambiguity`: 사용자 쿼리에 삽입된 모호성
   - `non_critical_ambiguity`: 정렬, 제한 등과 같은 비중요 모호성
   - `knowledge_ambiguity`: 외부 지식이 마스킹되어 생성된 모호성 
   - `sol_sql`: 정답 SQL 솔루션  
   - `preprocess_sql`: 솔루션 또는 예측 실행 전에 실행할 SQL 쿼리  
   - `clean_up_sql`: 테스트 케이스 후 데이터베이스 변경 사항을 되돌리기 위한 SQL 쿼리  
   - `test_cases`: 예측된 수정 SQL을 검증하기 위한 테스트 케이스 집합
   - `follow_up`: 라벨링된 후속 질문
   - `external_knowledge`: 특정 작업과 관련된 외부 지식

- **evaluation:** 평가 코드는 [`./evaluation`](./evaluation) 디렉터리에 있습니다.
- **Curated by:** BIRD 팀 & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  및 [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### 데이터셋 사용

데이터 유출을 방지하기 위해, GT 솔루션 SQL 및 테스트 케이스는 데이터와 함께 포함되어 있지 않습니다.
bird-interact-lite 또는 bird-interact-full 데이터셋의 정답 및 테스트 케이스가 필요하신 경우, 제목에 `[bird-interact-lite GT&Test Cases]` 또는 `[bird-interact-full GT&Test Cases]` 태그를 포함하여 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) 로 이메일을 보내주시면 자동으로 발송됩니다.

### 공개 데이터와 정답, 테스트 케이스 결합

아래 스크립트를 사용하여 공개 데이터에 정답과 테스트 케이스를 결합합니다:

전체 버전을 예시로 들면:
(1) 실행:

```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
이렇게 하면 결합된 데이터가 포함된 새로운 파일이 `/path/to/bird_interact_data.jsonl`에 생성됩니다.

(2) 그런 다음 기존 공개 데이터를 결합된 데이터로 교체합니다:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```
다른 버전에도 동일하게 적용됩니다: bird-interact-lite, mini 버전 등. 공개 데이터와 정답 및 테스트 케이스의 경로만 올바르게 설정한 다음, 공개 데이터를 결합된 데이터로 교체하면 됩니다.




<!-- ### HuggingFace에서 데이터셋 사용하기

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
**a-interact** 실행에 관한 자세한 내용은 `./bird_interact_agent/README.md`에서 확인할 수 있으며, **c-interact**에 대한 내용은 `./bird_interact_conv/README.md`에서 확인할 수 있습니다.

## 📋 할 일 목록

- [x] 라이트 버전 릴리스, bird-interact-lite (270).
- [x] 대화형 버전 릴리스, bird-interact-conv.
- [x] 에이전트 버전 릴리스, bird-interact-agent.
- [x] 전체 버전 릴리스, bird-interact-full (600).
- [ ] SFT / RL 사용자 시뮬레이터

## 감사의 글
본 프로젝트의 발전에 도움이 된 풍부한 토론과 귀중한 조언을 아끼지 않은 **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** 그리고 **Shinji Watanabe** 교수님께 진심으로 감사의 뜻을 전합니다.

## 제작:
BIRD 팀 & Google Cloud








## 변경 로그

- [2025-11-06] 🐛 **버그 수정** & 🐳 **도커 업데이트**: 사용자 시뮬레이터용 SQL 파서를 올바르게 파싱하지 못하는 버그를 수정하기 위해 sqlglot 버전을 26.16.4로 업데이트했습니다. `bird_interact_eval` 환경에서 `pip install sqlglot==26.16.4`로 재설치하면 해결할 수 있습니다. `bird_interact_eval` 이미지도 업데이트되었으니, 이미지를 풀하고 `bird_interact_eval` 컨테이너를 재생성할 수 있습니다.
- [2025-10-21] 🐳 **도커 업데이트**: 전체 DB 환경용 도커 추가. Base/Full DB Env와 `a-Interact`, `c-Interact` 평가 환경 등 3개의 도커 이미지를 Docker Hub에 업로드하여 환경 설정을 쉽게 했습니다. DB 덤프 다운로드 및 이미지 직접 빌드가 필요 없습니다! Docker Hub에서 최신 이미지를 풀하고, 예를 들어 `docker compose down -v && docker compose pull && docker compose up -d --force-recreate` 명령으로 컨테이너를 재생성하세요.
- [2025-08-22]  🐛 **버그 수정**: phase-2 SQL 평가 시 저장된 phase-1 SQL이 제대로 실행되지 않아 phase-2 성공률이 낮아지는 버그를 수정했습니다. 이 버그는 phase1 sql에서 데이터베이스에 CREATE table 등 작업을 수행하는 과제에만 영향을 미칩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---