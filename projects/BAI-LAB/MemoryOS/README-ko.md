# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 프로젝트가 마음에 드셨다면, 최신 업데이트를 위해 GitHub에서 별표 ⭐를 눌러주세요.</h5>
**MemoryOS**는 개인화된 AI 에이전트를 위한 메모리 운영체제를 제공하도록 설계되어, 더 일관성 있고, 개인화되며, 컨텍스트를 인식하는 상호작용을 가능하게 합니다. 운영체제의 메모리 관리 원리에서 영감을 받아, 저장(Storage), 갱신(Updating), 검색(Retrieval), 생성(Generation)의 네 가지 핵심 모듈로 계층적 저장 아키텍처를 도입하여 포괄적이고 효율적인 메모리 관리를 실현합니다. LoCoMo 벤치마크에서 모델은 F1과 BLEU-1 점수에서 각각 **49.11%** 및 **46.18%**의 평균 향상을 달성했습니다.







## 📣 최신 소식
*   *<mark>[new]</mark>* 🔥  **[2025-06-15]**:🛠️ 오픈소스 **MemoryOS-MCP** 출시! 에이전트 클라이언트에서 무중단 통합 및 커스터마이징이 가능합니다. [👉 자세히 보기](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: **MemoryOS** 초기 버전 출시! 단기, 중기, 장기 페르소나 메모리 및 자동 사용자 프로필·지식 업데이트 기능 제공.

## 데모
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	시스템 아키텍처
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## 프로젝트 구조

```
memoryos/
├── __init__.py            # MemoryOS 패키지 초기화
├── __pycache__/           # 파이썬 캐시 디렉토리 (자동 생성)
├── long_term.py           # 장기 페르소나 메모리 관리 (사용자 프로필, 지식)
├── memoryos.py            # MemoryOS의 메인 클래스, 모든 컴포넌트 조정
├── mid_term.py            # 중기 메모리 관리, 단기 상호작용 통합
├── prompts.py             # LLM 상호작용에 사용되는 프롬프트 (예: 요약, 분석)
├── retriever.py           # 모든 메모리 계층에서 관련 정보 검색
├── short_term.py          # 최근 상호작용을 위한 단기 메모리 관리
├── updater.py             # 메모리 업데이트 처리, 계층 간 정보 승격 포함
└── utils.py               # 라이브러리 전반에 걸친 유틸리티 함수
```

## 작동 원리

1.  **초기화:** `Memoryos`는 사용자 및 어시스턴트 ID, API 키, 데이터 저장 경로, 다양한 용량/임계값 설정으로 초기화됩니다. 각 사용자와 어시스턴트에 대한 전용 저장소를 구축합니다.
2.  **메모리 추가:** 사용자 입력과 에이전트 응답이 QA 쌍으로 추가됩니다. 이들은 우선 단기 메모리에 저장됩니다.
3.  **단기 → 중기 처리:** 단기 메모리가 가득 차면 `Updater` 모듈이 해당 상호작용을 처리하여 의미 있는 세그먼트로 통합, 중기 메모리에 저장합니다.
4.  **중기 분석 & LPM 업데이트:** 중기 메모리 세그먼트는 방문 빈도, 상호작용 길이 등 요인에 따라 "열(heat)"을 축적합니다. 세그먼트의 열이 임계값을 초과하면 다음과 같이 분석됩니다:
    *   사용자 프로필 인사이트를 추출하여 장기 사용자 프로필을 갱신합니다.
    *   특정 사용자 사실을 사용자의 장기 지식에 추가합니다.
    *   어시스턴트에게 중요한 정보는 어시스턴트의 장기 지식 베이스에 추가됩니다.
5.  **응답 생성:** 사용자 쿼리 수신 시:
    *   `Retriever` 모듈이 단기 이력, 중기 메모리 세그먼트, 사용자 프로필·지식, 어시스턴트 지식 베이스에서 관련 컨텍스트를 검색합니다.
    *   이 포괄적 컨텍스트와 사용자 쿼리를 활용하여 LLM을 통해 일관성 있고 정보에 기반한 응답을 생성합니다.

## MemoryOS_PYPI 시작하기

### 사전 준비

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### 설치

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### 기본 사용법

```python

import os
from memoryos import Memoryos

# --- 기본 설정 ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # 본인의 키로 교체하세요
BASE_URL = ""  # 선택 사항: 커스텀 OpenAI 엔드포인트 사용 시
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simple Demo")
    
    # 1. MemoryOS 초기화
    print("Initializing MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS initialized successfully!\n")
    except Exception as e:
        print(f"Error: {e}")
        return

    # 2. 기본 메모리 추가
    print("Adding some memories...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"User: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP 시작하기
### 🔧 핵심 도구

#### 1. `add_memory`
사용자와 AI 어시스턴트 간의 대화 내용을 메모리 시스템에 저장하여, 지속적인 대화 이력과 컨텍스트 기록을 구축합니다.

#### 2. `retrieve_memory`
쿼리에 따라 메모리 시스템에서 관련 대화 이력, 사용자 선호, 지식 정보를 검색하여, AI 어시스턴트가 사용자의 요구와 배경을 이해하도록 지원합니다.

#### 3. `get_user_profile`
과거 대화 분석을 통해 생성된 사용자 프로필을 획득하며, 여기에는 사용자의 성격 특성, 관심사, 관련 지식 배경이 포함됩니다.


### 1. 의존성 설치
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. 설정

`config.json` 파일을 수정합니다：
```json
{
  "user_id": "너의 사용자ID",
  "openai_api_key": "너의 OpenAI API키",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. 서버 시작
```bash
python server_new.py --config config.json
```
### 4. 테스트
```bash
python test_comprehensive.py
```
### 5. Cline 및 기타 클라이언트에서 설정
mcp.json 파일을 복사하고, 파일 경로가 올바른지 확인하세요.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#이 경로는 본인의 가상환경 파이썬 인터프리터로 바꿔야 합니다.
```
## 기여하기

기여를 환영합니다! 언제든지 이슈 또는 풀 리퀘스트를 제출해 주세요.

## 인용
더 자세한 내용을 읽고 싶다면 여기를 클릭하세요: [전체 논문 읽기](https://arxiv.org/abs/2506.06326)

이 프로젝트가 유용하다면, 아래 논문을 인용해 주세요:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## 문의하기
백가AI는 베이징 우전 대학(北京邮电大学) 바이팅(白婷) 부교수의 지도하에 운영되는 연구 그룹으로, 실리콘 기반 인간을 위해 감정이 풍부하고 탁월한 기억력을 가진 두뇌를 만드는 데 전념하고 있습니다.<br>
협업 및 제안: baiting@bupt.edu.cn<br>
백가Agent 공식 계정 및 위챗 그룹을 팔로우하시고 함께 소통해 주세요!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="백가Agent 공식 계정" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="위챗 그룹 QR코드" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---