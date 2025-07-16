<div align="center">

# s3 - 通过强化学习实现高效且有效的搜索代理训练
***训练搜索代理不需要那么多数据***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**性能概览：**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## 什么是 s3？

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**s3 框架**
</div>

`s3` 是一个简单而强大的框架，用于训练检索增强生成（RAG）中的搜索代理。它教会语言模型如何更有效地搜索——而无需更改生成器本身。通过专注于搜索组件，`s3` 只用先前方法的一小部分数据就能在问答任务中实现强劲的性能。它模块化、高效，并设计为能无缝兼容任何黑盒大语言模型（LLM）。



## 目录

- [📦 安装](#-installation)
- [💡 准备](#-preparation)
- [🏋️ 运行训练](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 运行搜索/检索](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 运行评估](#-run-evaluation)

## 📦 安装

**搜索器 & 生成器环境**
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
**检索器环境**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
<translate-content>


## 💡 准备工作
***下载索引和语料库***</translate-content>
```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```
***预计算朴素RAG初始化***


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ 运行训练
***此步骤用于S3的训练***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 运行搜索/检索
***此步骤用于s3 / 基线的上下文收集***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<translate-content>
<details>
<summary>基线</summary>

**RAG**</translate-content>
```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**深度检索**

```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
<translate-content>
**搜索-R1**</translate-content>
```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
<translate-content>
**IRCoT**</translate-content>
```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
<translate-content>
**搜索-o1**</translate-content>
```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 运行评估
***此步骤用于评估 s3 / 基线***



```bash
bash scripts/evaluation/run.sh
```
<translate-content>

## 致谢
我们要感谢以下项目：
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## 引用</translate-content>
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
感谢您对我们工作的关注！






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---