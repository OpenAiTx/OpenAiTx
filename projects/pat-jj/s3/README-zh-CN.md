
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=pat-jj&project=s3&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# s3 - 高效且有效的搜索代理训练方法（RL）
***训练搜索代理并不需要那么多数据***

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

`s3` 是一个用于训练检索增强生成（RAG）搜索代理的简单而强大的框架。它教会语言模型如何更有效地进行搜索——无需更改生成器本身。通过仅关注搜索组件，`s3` 用远少于以往方法的数据实现了在 QA 任务上的强劲性能。它具有模块化、高效的特点，并且可以与任何黑盒 LLM 无缝协作。



## 目录

- [📦 安装](#-installation)
- [💡 准备](#-preparation)
- [🏋️ 开始训练](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 执行搜索/检索](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 运行评估](#-run-evaluation)

## 📦 安装

**搜索器与生成器环境**
```bash
conda create -n s3 python=3.9
# install torch [or you can skip this step and let vllm to install the correct version for you]
pip install torch==2.4.0 --index-url https://download.pytorch.org/whl/cu121
# install vllm
pip3 install vllm==0.6.3 # or you can install 0.5.4, 0.4.2 and 0.3.1
pip3 install ray

# verl
# cd code
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




## 💡 准备工作
***下载索引和语料库***

```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***预计算 Naïve RAG 初始化***（或者你可以在这里下载我们处理过的数据：[huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data)）

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


<details>
<summary>基线</summary>

**RAG**

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


**搜索-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```


**IRCoT**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```


**搜索-o1**

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

## 问答
### 定制数据？
如果您想在自己的语料库/数据集上测试 s3，可以参考此提交，了解如何构建自己的流程：[commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### 复现结果？
已经有多位开发者成功复现了我们的结果。如果您有疑问或遇到问题，欢迎[提交 issue](https://github.com/pat-jj/s3/issues)——我们很乐意提供详细指导（参见[此示例](https://github.com/pat-jj/s3/issues/20)）。

虽然自行复现模型其实很简单——我们实际上**推荐从零开始训练**，因为评估往往比训练更耗时——但我们也提供了一个参考模型检查点：[s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps)，训练时间约为一小时。



## 鸣谢
我们要感谢以下项目：
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini)。
 

## 引用
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---