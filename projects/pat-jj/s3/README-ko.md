<translate-content><div align="center">

# s3 - RL을 통한 효율적이면서도 효과적인 검색 에이전트 학습
***검색 에이전트를 학습시키기 위해 그렇게 많은 데이터가 필요하지 않습니다***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**성능 개요:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## s3란?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**s3 프레임워크**
</div>

`s3`는 검색 강화 생성(RAG)에서 검색 에이전트를 학습시키기 위한 단순하지만 강력한 프레임워크입니다. 생성기 자체를 변경하지 않고 언어 모델에게 더 효과적으로 검색하는 방법을 가르칩니다. 검색 구성 요소에만 집중함으로써 `s3`는 이전 방법이 사용하는 데이터의 일부만으로 QA 작업에서 강력한 성능을 달성합니다. 모듈식이며 효율적이고, 어떤 블랙박스 LLM과도 원활하게 작동하도록 설계되었습니다.



## 목차

- [📦 설치](#-installation)
- [💡 준비](#-preparation)
- [🏋️ 학습 실행](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 검색/검색 실행](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 평가 실행](#-run-evaluation)

## 📦 설치

**검색기 및 생성기 환경**</translate-content>
```bash
conda create -n s3 python=3.9
# install torch [or you can skip this step and let vllm to install the correct version for you]
pip install torch==2.4.0 --index-url https://download.pytorch.org/whl/cu121
# install vllm
pip3 install vllm==0.6.3 # or you can install 0.5.4, 0.4.2 and 0.3.1
pip3 install ray

# verl
cd code
pip install -e .

# flash attention 2
pip3 install flash-attn --no-build-isolation

# we use pyserini for efficient retrieval and evaluation
pip install pyserini    # the version we used is 0.22.1

# quality of life
pip install wandb IPython matplotlib huggingface_hub
```
**검색기 환경**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
<translate-content>


## 💡 준비하기
***색인 및 말뭉치 다운로드***</translate-content>
```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```
***미리 계산된 순진한 RAG 초기화***


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
<translate-content>

## 🏋️ 훈련 실행
***이 단계는 S3 훈련을 위한 것입니다***
</translate-content>
```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
<translate-content>

## 🔍 검색/검색 실행
***이 단계는 s3 / 기준선의 컨텍스트 수집을 위한 것입니다***

**s3**</translate-content>
```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<translate-content>
<details>
<summary>기준선</summary>

**RAG**</translate-content>
```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
<translate-content>
**딥리트리벌**</translate-content>
```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**검색-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**검색-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
<translate-content>
</details>


## 📈 실행 평가
***이 단계는 s3 / 기준선 평가를 위한 단계입니다***

</translate-content>
```bash
bash scripts/evaluation/run.sh
```
## 감사의 글
다음 프로젝트에 감사를 표합니다:
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## 인용문헌


```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
<translate-content>
우리 작업에 관심을 가져 주셔서 감사합니다!



</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---