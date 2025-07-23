
# MASS: 포트폴리오 구성을 위한 다중 에이전트 시뮬레이션 확장

📜 [논문 링크](https://arxiv.org/abs/2505.10278)

## ✨ 개요

![MASS 개요](https://raw.githubusercontent.com/gta0804/MASS/main/img/MASS.pdf)

## 📝 알아야 할 사항

1. 현재 MASS 실행을 위한 전체 데이터셋 중 매우 [작은 부분집합](https://github.com/gta0804/MASS/tree/main/stock_disagreement/example_dataset)만 제공하고 있습니다. 전체 데이터셋은 리뷰가 완료된 후에 공개될 예정입니다.

## 🧑‍💻사용법
1. **의존성 설치**

```
conda create -n your_env_name python==3.10 -y
conda activate your_env_name
pip install pdm
pdm install
```
2. **데이터셋 가져오기**  
데이터셋을 가져온 후, 모든 `ROOT_PATH` 변수를 자신의 데이터셋 디렉토리로 변경하세요.  
현재 SSE 50 지수에 대한 예제 데이터셋을 공개합니다.  

3. **자신의 데이터셋으로 MASS 확장하기**  
시간 제한으로 인해, 데이터 소스가 제한적입니다. 더 많은 데이터 소스를 MASS에 통합하여 더 뛰어난 성능을 얻기를 권장하며, 투자 포트폴리오 구성 이상의 MASS 확장도 권장합니다!  
아래 단계별로 자신의 데이터 소스를 사용할 수 있습니다:  
  - **자신만의 데이터 모달리티 정의하기.**  
  MASS에서는 여러 데이터 모달리티를 [여기](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L42)에서 미리 정의해두었습니다. 이를 자신의 데이터 소스로 변경할 수 있습니다. 데이터 소스를 변경한 후에는 데이터 로딩 코드를 [여기](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L165)에서 변경하는 것을 잊지 마세요.
  ```
  class Modality(IntFlag):  
      FUDAMENTAL_VALUTION = 0b00000001  
      FUDAMENTAL_DIVIDEND = 0b00000010 
      FUDAMENTAL_GROWTH = 0b000000100
      FUDAMENTAL_QUALITY = 0b000001000
      NEWS = 0b000010000      
      BASE_DATA = 0b000100000  
      CROSS_INDUSTRY_LABEL = 0b001000000
      RISK_FACTOR = 0b010000000
      PRICE_FEATURE = 0b100000000 
  ```

  - **자신만의 집계 함수를 사용하세요.**
  MASS에서는 시장 불일치 가설에 따라 개별 투자자의 결정을 집계합니다. 실제로는 자신만의 집계 방법을 사용할 수 있습니다. 자신만의 집계 함수를 위해 [investor_analyzer.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/investment_analyzer.py)의 코드를 변경하세요!
  - **다른 옵티마이저 사용하기**
     MASS에서는 에이전트 분포 최적화에 시뮬레이티드 어닐링을 사용합니다. [agent_distribution.py](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/agent_distribution.py)에서 옵티마이저 프레임워크를 구현했습니다. 자신만의 옵티마이저를 정의할 수 있습니다.
  

4. **컴퓨팅 자원 구성.**
우리는 [Qwen2.5-72B-Instruct](https://huggingface.co/Qwen/Qwen2.5-72B-Instruct)를 기본 모델로 사용합니다. 기본 모델 URL은 [여기](https://github.com/gta0804/MASS/blob/main/stock_disagreement/agent/basic_agent.py#L57)에서 변경할 수 있습니다.
SSE 50과 기본 구성에서는 80GiB RAM이 필요합니다. 에이전트 병렬성을 조정하여 메모리 오버헤드를 줄일 수 있습니다 [여기](https://github.com/gta0804/MASS/blob/main/stock_disagreement/exp/trainer.py#L148)에서 가능합니다.

5. **MASS 실행하기**

```
python stock_disagreement/main.py
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---