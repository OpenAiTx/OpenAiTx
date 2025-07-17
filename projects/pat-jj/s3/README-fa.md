<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# s3 - آموزش عامل جستجو کارآمد اما مؤثر با استفاده از RL
***برای آموزش یک عامل جستجو به آن‌همه داده نیاز ندارید***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**بررسی اجمالی عملکرد:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## s3 چیست؟

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**چارچوب s3**
</div>

`s3` یک چارچوب ساده اما قدرتمند برای آموزش عامل‌های جستجو در تولید تقویت‌شده با بازیابی (RAG) است. این چارچوب به مدل‌های زبانی می‌آموزد چگونه مؤثرتر جستجو کنند—بدون اینکه تغییری در مولد ایجاد شود. با تمرکز صرف بر مولفه جستجو، `s3` با تنها کسری از داده‌های مورد استفاده روش‌های قبلی، عملکرد بالایی در وظایف پرسش و پاسخ ارائه می‌دهد. این چارچوب ماژولار، کارآمد و برای کار بی‌دردسر با هر LLM جعبه‌سیاه طراحی شده است.



## فهرست مطالب

- [📦 نصب](#-installation)
- [💡 آماده‌سازی](#-preparation)
- [🏋️ اجرای آموزش](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 اجرای جستجو/بازیابی](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 اجرای ارزیابی](#-run-evaluation)

## 📦 نصب

**محیط جستجوگر و مولد**

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
**محیط بازیاب**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 آماده‌سازی
***دانلود ایندکس و پایگاه داده***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```
***پیش‌محاسبه مقداردهی اولیه ساده RAG***


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ اجرای آموزش
***این مرحله برای آموزش S3 است***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 اجرای جستجو/بازیابی
***این مرحله برای گردآوری زمینه s3 / خطوط پایه است***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>مبانی</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**بازیابی عمیق**

```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**جستجو-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**
**آی‌آرکات**
```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**جستجو-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 اجرای ارزیابی
***این مرحله برای ارزیابی s3 / خطوط پایه است***



```bash
bash scripts/evaluation/run.sh
```
## تقدیر و تشکر
مایلیم از پروژه‌های زیر تشکر کنیم:
[verl](https://github.com/volcengine/verl)، [RAGEN](https://github.com/RAGEN-AI/RAGEN)، [Search-R1](https://github.com/PeterGriffinJin/Search-R1)، [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval)، [PySerini](https://github.com/castorini/pySerini).
 

## ارجاع


```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
با تشکر از علاقه‌مندی شما به کار ما!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---