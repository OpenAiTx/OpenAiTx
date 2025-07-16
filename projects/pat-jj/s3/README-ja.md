<div align="center">

# s3 - 効率的かつ効果的な検索エージェントの強化学習による訓練  
***検索エージェントの訓練にそれほど多くのデータは必要ありません***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**パフォーマンス概要：**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## s3とは何か？

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**s3フレームワーク**
</div>

`s3`は、検索強化生成（RAG）における検索エージェントの訓練のためのシンプルかつ強力なフレームワークです。ジェネレーター自体を変更することなく、言語モデルにより効果的な検索方法を教えます。検索コンポーネントのみに焦点を当てることで、`s3`は従来の手法のごく一部のデータ量でQAタスクにおいて高い性能を実現します。モジュラー設計で効率的、そして任意のブラックボックスLLMとシームレスに連携するよう設計されています。



## 目次

- [📦 インストール](#-installation)
- [💡 準備](#-preparation)
- [🏋️ 訓練の実行](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 検索／取得の実行](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 評価の実行](#-run-evaluation)

## 📦 インストール

**検索エージェント & ジェネレーター環境**
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
**リトリーバー環境**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
<translate-content>


## 💡 準備
***インデックスとコーパスのダウンロード***</translate-content>
```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```
***事前計算による単純なRAG初期化***


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ トレーニングの実行
***このステップはS3のトレーニング用です***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 検索／取得の実行
***このステップは s3 / ベースラインのコンテキスト収集のためのものです***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>ベースライン</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**DeepRetrieval**

```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**検索-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**検索-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 実行評価
***このステップはs3 / ベースラインの評価用です***



```bash
bash scripts/evaluation/run.sh
```
## 謝辞
以下のプロジェクトに感謝いたします：
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
ご関心をお寄せいただきありがとうございます！






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---