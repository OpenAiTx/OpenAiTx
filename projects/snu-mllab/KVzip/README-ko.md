# KVzip: 컨텍스트 재구성을 통한 쿼리-무관 KV 캐시 압축

[[논문](https://arxiv.org/abs/2505.23416)] [[블로그](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## 주요 내용
- KVzip은 **다양한 미래 쿼리**를 지원하기 위해 KV 캐시를 압축합니다.
- [컨텍스트 의존적] 최소한의 성능 저하로 **KV 캐시 크기 3–4배 축소** 및 **디코딩 지연 2배 감소**를 달성합니다.
- [컨텍스트 독립적] 단 몇 분 내에 수행되는 헤드 중요도 점수 최적화(100배 빠름)를 통해 [DuoAttention](https://github.com/mit-han-lab/duo-attention) 스타일의 헤드 수준 KV 압축을 향상시킵니다.
- demo.py 실행:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### 쿼리-무관 설정 벤치마크
- 작업: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)  
- 모델: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## 설치
CUDA 12.1과 Python 3.10을 사용했습니다.
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- [QServe](https://github.com/mit-han-lab/omniserve) 양자화를 사용하려면 [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model)을 참고하세요.
### 데이터셋
- 전처리된 SCBench 데이터셋을 [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link)에서 다운로드하세요.
- 압축을 푼 파일을 받았다면 scbench 폴더를 옮기면 됩니다.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## 빠른 시작
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # KV 캐시 미리 채우기 + 중요도 점수 산출
kv.prune(ratio=0.3)  # 압축 비율, 70% KV 제거

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # 효율적 추론
    print(q, output)
```
- 지원 모델은 [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)에서 확인할 수 있으며 **LLaMA3, Qwen2.5/3, Gemma3** 등이 포함됩니다.
- 압축 오버헤드를 제거하려면 `load_score=True`로 설정하세요. 이는 `ratio=0.6`의 압축 비율 트레이드오프와 함께 컨텍스트 독립적 KV 제거를 가능하게 합니다.
- 생성 후 쿼리 및 생성된 토큰과 관련된 KV 쌍은 추가 처리를 위해 선택적으로 캐시에서 제거됩니다. 다중 턴 추론을 위해 `update_cache=True`로 설정하면 전체 상호작용 기록을 유지합니다.

## 메모리 및 계산 시간 프로파일링
### 컨텍스트 의존적 제거
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- 위 코드는 전체 KV 캐시와 가지치기된 KV 캐시를 사용해 생성한 결과를 비교합니다.
- 빠른 테스트는 `-d squad`를, 긴 컨텍스트 테스트는 `-d scbench_kv`를 사용하세요.
  - 사용 가능한 데이터 이름: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - 사용 가능한 모델 이름: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), 예: llama3.1-8b, qwen2.5-7b (또는 Qwen/Qwen2.5-7B-Instruct-1M).
- CUDA 커널은 [AdaKV](https://github.com/FFY0/AdaKV/tree/main)에서 가져와 비균등 헤드 예산 할당을 지원합니다.
  - 현재 Gemma3용 최적화된 커널은 없으며, 따라서 실제 효율성 향상은 없습니다. 하지만 KV 서브샘플링(`--kv_type retain`)을 통한 감소된 어텐션으로 모델 성능 평가가 가능합니다.


### 컨텍스트 독립적 제거 (런타임 압축 오버헤드 없음)
- `--level head` 플래그와 `--ratio 0.6` (권장)을 사용하세요.
  - 시스템 프롬프트 및 쿼리 KV 쌍은 유지하면서 특정 헤드와 관련된 모든 컨텍스트 KV 쌍을 제거합니다.
  - 사전 계산된 헤드 점수는 LLaMA3.1-8B 및 Qwen2.5-7/14B용으로 `./utils/head_score`에 제공됩니다.
- 다른 모델의 헤드 점수를 계산하려면:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - 결과는 `./utils/head_score`에 저장됩니다.
  - 코딩 작업을 목표로 한다면 `-d scbench_repoqa`를 추가로 실행하는 것을 권장합니다. 이는 자연어 및 코딩 언어 모두에서 최대 헤드 점수를 사용하게 하여 성능을 향상시킵니다.
- 이 점수들은 [DuoAttention](https://github.com/mit-han-lab/duo-attention)의 최적화된 추론 엔진에서 헤드 점수 데이터를 교체하여 원활하게 통합할 수 있습니다.


## 평가
- KV 압축 비율 0.1부터 1.0까지 모델 응답 생성:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - 결과는 `./results/[data_name]`에 저장됩니다.
  - 지원 데이터셋은 `data/load.py`에서 확인하세요.
- 생성 결과로부터 평가 지표 계산:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## 신규 모델 적용
KVzip을 새 모델에 통합하려면 다음 파일들을 수정해야 합니다:
- `attention/attn.py`  
  필요에 따라 어텐션 포워드 패스 로직 수정. 경우에 따라 kvcache.py와 score.py 수정도 필요할 수 있습니다.
- `model/monkeypatch.py`  
  모델별 monkey patch 구현.
- `model/template.py`   
  모델의 시스템 프롬프트 및 채팅 포맷 템플릿 정의.


## 인용
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## 라이선스
MIT 라이선스

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---