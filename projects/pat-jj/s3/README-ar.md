<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# s3 - تدريب وكيل البحث بكفاءة وفعالية عبر التعلم المعزز
***لست بحاجة إلى الكثير من البيانات لتدريب وكيل بحث***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">

  </a>
</p>
</div>

**نظرة عامة على الأداء:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## ما هو s3؟

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**إطار عمل s3**
</div>

` s3 ` هو إطار عمل بسيط ولكنه قوي لتدريب وكلاء البحث في توليد المعلومات المدعومة بالاسترجاع (RAG). يعلم نماذج اللغة كيفية البحث بشكل أكثر فعالية - دون تغيير وحدة التوليد نفسها. من خلال التركيز فقط على عنصر البحث، يحقق ` s3 ` أداءً قويًا عبر مهام الأسئلة والأجوبة باستخدام جزء بسيط فقط من البيانات المستخدمة في الطرق السابقة. إنه معياري، فعال، ومصمم للعمل بسلاسة مع أي نموذج لغة كبير مغلق المصدر.



## جدول المحتويات

- [📦 التثبيت](#-installation)
- [💡 التحضير](#-preparation)
- [🏋️ بدء التدريب](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-run-training)
- [🔍 بدء البحث/الاسترجاع](https://github.com/pat-jj/s3?tab=readme-ov-file#-run-searchretrieval)
- [📈 بدء التقييم](#-run-evaluation)

## 📦 التثبيت

**بيئة الباحث والمُولّد**
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
**بيئة المسترجع**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 التحضير
***تنزيل الفهرس والمجموعة***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***تهيئة RAG البسيطة مسبقة الحساب*** (أو يمكنك تنزيل بياناتنا المعالجة من هنا: [huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data))

```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ تشغيل التدريب
***هذه الخطوة مخصصة لتدريب S3***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 تنفيذ البحث/الاسترجاع
***هذه الخطوة مخصصة لجمع السياق لـ s3 / القيم الأساسية***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>خطوط الأساس</summary>

**RAG**

```bash
bash scripts/deploy_retriever/retrieval_launch.sh # or retrieval_launch_bm25.sh # deploy retriever
bash scripts/baselines/rag.sh # run RAG 
```
**الاسترجاع العميق**

```bash
bash retrieval_launch_bm25.sh # deploy BM25 Model
bash generator_llms/deepretrieval.sh # deploy DeepRetrieval Model
bash scripts/baselines/deepretrieval.sh # run DeepRetrieval Query Rewriting + Retrieval
```
**بحث-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**آي آر كوت (IRCoT)**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**بحث-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 تشغيل التقييم
***هذه الخطوة مخصصة لتقييم s3 / الخطوط الأساسية***



```bash
bash scripts/evaluation/run.sh
```

## الأسئلة والأجوبة
### بيانات مخصصة؟
إذا كنت ترغب في اختبار s3 على مجموعة البيانات/المحتوى الخاص بك، يمكنك الرجوع إلى هذا الالتزام لمعرفة ما يلزمك فعله لبناء خط الأنابيب الخاص بك: [commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### إعادة إنتاج النتائج؟
تمكن العديد من المطورين بالفعل من إعادة إنتاج نتائجنا بنجاح. إذا كان لديك أي أسئلة أو واجهت مشكلات، لا تتردد في [فتح قضية](https://github.com/pat-jj/s3/issues) — يسعدنا تقديم إرشادات عملية (انظر [هذا المثال](https://github.com/pat-jj/s3/issues/20)).

على الرغم من أن إعادة إنتاج النموذج بنفسك أمر سهل — ونوصي فعلاً **بالتدريب من البداية**، لأن التقييم غالباً ما يستغرق وقتاً أطول بكثير من التدريب — فإننا نوفر أيضاً نقطة مرجعية: [s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps)، تم تدريبها في حوالي ساعة واحدة.



## الشكر والتقدير
نود أن نشكر المشاريع التالية:
[verl](https://github.com/volcengine/verl)، [RAGEN](https://github.com/RAGEN-AI/RAGEN)، [Search-R1](https://github.com/PeterGriffinJin/Search-R1)، [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval)، [PySerini](https://github.com/castorini/pySerini).
 

## الاقتباس
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
شكرًا لاهتمامك بعملنا!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---