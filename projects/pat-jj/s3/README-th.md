
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# s3 - การฝึกตัวแทนค้นหาที่มีประสิทธิภาพผ่าน RL
***คุณไม่จำเป็นต้องใช้ข้อมูลมากขนาดนั้นเพื่อฝึกตัวแทนค้นหา***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**ภาพรวมประสิทธิภาพ:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## s3 คืออะไร?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**เฟรมเวิร์ก s3**
</div>

`s3` คือเฟรมเวิร์กที่เรียบง่ายแต่ทรงพลังสำหรับฝึก search agent ใน retrieval-augmented generation (RAG) โดยสอนให้ language model ค้นหาได้อย่างมีประสิทธิภาพมากขึ้น—โดยไม่ต้องเปลี่ยนตัว generator เลย ด้วยการเน้นเฉพาะส่วนของการค้นหา `s3` จึงทำผลงานได้ดีในงาน QA ด้วยข้อมูลเพียงเศษเสี้ยวเมื่อเทียบกับวิธีเก่าๆ มีความเป็นโมดูลาร์ มีประสิทธิภาพ และถูกออกแบบให้ทำงานร่วมกับ LLM แบบกล่องดำใดก็ได้อย่างไร้รอยต่อ



## สารบัญ

- [📦 การติดตั้ง](#-installation)
- [💡 การเตรียมความพร้อม](#-preparation)
- [🏋️ เริ่มการฝึกสอน](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 เริ่มการค้นหา/ดึงข้อมูล](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 เริ่มการประเมินผล](#-run-evaluation)

## 📦 การติดตั้ง

**สภาพแวดล้อมของ Searcher & Generator**
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
**สภาพแวดล้อมของ Retriever**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 การเตรียมตัว
***ดาวน์โหลดดัชนี & คลังข้อมูล***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***เตรียมข้อมูลล่วงหน้าสำหรับการเริ่มต้น Naïve RAG*** (หรือคุณสามารถดาวน์โหลดข้อมูลที่เราประมวลผลแล้วได้ที่นี่: [huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data))

```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ เริ่มการฝึกอบรม
***ขั้นตอนนี้สำหรับการฝึกอบรม S3***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 ดำเนินการค้นหา/ดึงข้อมูล
***ขั้นตอนนี้ใช้สำหรับการรวบรวมบริบทของ s3 / baselines***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>ค่าพื้นฐาน</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**DeepRetrieval**
**DeepRetrieval**
```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**ค้นหา-R1**

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
**ค้นหา-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 ดำเนินการประเมินผล
***ขั้นตอนนี้สำหรับการประเมินผล s3 / baselines***



```bash
bash scripts/evaluation/run.sh
```

## ถาม-ตอบ
### ข้อมูลที่ปรับแต่งเอง?
หากคุณต้องการทดสอบ s3 กับคลังข้อมูล/ชุดข้อมูลของคุณเอง คุณสามารถดูได้จากคอมมิทนี้เพื่อดูว่าต้องทำอะไรบ้างในการสร้าง pipeline ของตัวเอง: [commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### การทำซ้ำผลลัพธ์?
มีนักพัฒนาหลายคนที่สามารถทำซ้ำผลลัพธ์ของเราได้สำเร็จแล้ว หากคุณมีคำถามหรือพบปัญหา สามารถ [เปิด issue](https://github.com/pat-jj/s3/issues) ได้เลย — เรายินดีให้คำแนะนำแบบลงมือปฏิบัติ (ดู [ตัวอย่างนี้](https://github.com/pat-jj/s3/issues/20)).

แม้ว่าการทำซ้ำโมเดลด้วยตัวเองจะง่าย — และเรา **แนะนำให้ฝึกจากศูนย์** เพราะการประเมินผลมักใช้เวลามากกว่าการฝึก — เราก็มี checkpoint อ้างอิงให้เช่นกัน: [s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps) ซึ่งใช้เวลาฝึกประมาณหนึ่งชั่วโมง



## ขอขอบคุณ
ขอขอบคุณโปรเจกต์ดังต่อไปนี้:
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## การอ้างอิง
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
ขอขอบคุณที่ให้ความสนใจในผลงานของเรา!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---