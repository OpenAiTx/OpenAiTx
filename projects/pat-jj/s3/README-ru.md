<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# s3 - Эффективная, но продуктивная тренировка поисковых агентов с помощью RL
***Вам не нужно так много данных для обучения поискового агента***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**Обзор производительности:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## Что такое s3?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**Фреймворк s3**
</div>

`s3` — это простой, но мощный фреймворк для обучения поисковых агентов в Retrieval-Augmented Generation (RAG). Он обучает языковые модели более эффективно осуществлять поиск — без изменения самого генератора. Фокусируясь исключительно на компоненте поиска, `s3` достигает высоких результатов в задачах ВОП (QA) с использованием лишь части данных по сравнению с предыдущими методами. Он модульный, эффективный и рассчитан на бесшовную интеграцию с любым LLM как "черным ящиком".



## Содержание

- [📦 Установка](#-установка)
- [💡 Подготовка](#-подготовка)
- [🏋️ Запуск обучения](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 Запуск поиска/извлечения](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 Запуск оценки](#-run-evaluation)

## 📦 Установка

**Окружение для Поисковика и Генератора**

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
**Среда Retriever**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 Подготовка
***Скачать индекс и корпус***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```
***Предварительный расчет наивной инициализации RAG***


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ Запуск обучения
***Этот шаг предназначен для обучения S3***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 Запуск поиска/извлечения
***Этот шаг предназначен для сбора контекста s3 / базовых линий***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>Базовые показатели</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**DeepRetrieval**
**ГлубокоеВосстановление**
```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**Поиск-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**
**IRCoT**
```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**Поиск-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 Запуск оценки
***Этот шаг предназначен для оценки s3 / базовых линий***



```bash
bash scripts/evaluation/run.sh
```
## Благодарности
Мы хотели бы поблагодарить следующие проекты:
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## Цитирование


```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
Спасибо за интерес к нашей работе!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---