# ExpeRepair

**ExpeRepair**는 이중 메모리 시스템을 통해 과거 수리 경험을 지속적으로 축적하고 재사용하는 새로운 LLM 기반 프로그램 수리 프레임워크입니다. 두 가지 핵심 구성 요소로 이루어져 있습니다:
- **프로그램 수리 모듈**: 테스트 생성, 패치 생성, 패치 검증의 세 가지 주요 작업을 협력하여 수행하는 테스트 에이전트와 패치 에이전트로 구성됩니다.
- **메모리 모듈**: 프로그램 수리 모듈에서 수리 경로를 캡처하여 구체적인 시연과 고수준 수리 전략을 추출합니다. 각각 **에피소드 메모리**와 **시맨틱 메모리**에 저장됩니다. 이후 수리 시 ExpeRepair는 관련 시연과 통찰을 검색하여 새로운 문제에 대한 수리 전략을 향상시킵니다.

## 🚀 빠른 시작

### 설치
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```
### 환경 설정

API 키를 환경 변수로 설정하세요:

```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```
[Agentless](https://arxiv.org/abs/2407.01489)를 참고하여, ExpeRepair는 의심스러운 파일을 찾기 위해 **저장소 구조 형식**을 사용합니다.  
저장소를 직접 전처리할 수도 있고, 준비된 데이터를 다운로드할 수도 있습니다: [swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0).  

다운로드 후, 압축을 풀고 위치를 내보내십시오:

```bash
export PROJECT_FILE_LOC={folder which you saved}
```
마지막으로, [auto-code-rover 프로젝트](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed)의 지침에 따라 테스트베드를 설정합니다.

### 전체 벤치마크에서 ExpeRepair 실행하기
1. 모든 인스턴스 ID를 사용하여 `run_reproduce_initial.sh`를 실행합니다.
2. 모든 인스턴스 ID를 사용하여 `run_localization.sh`를 실행합니다.
3. 재현에 성공한 인스턴스(즉, 유효한 `reproducer_X.py` 스크립트가 생성된 경우)에 대해 `generate_initial.py`를 실행합니다.
4. 나머지 인스턴스에 대해서는 누적된 메모리를 활용하고 계속 업데이트하는 `generate_w_memory.py`를 실행합니다.
5. 마지막으로, 모든 인스턴스 ID를 사용하여 `validation.py`와 `obtain_predictions.py`를 실행합니다.

### 사용법


```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```
## 🙏 감사의 글

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---