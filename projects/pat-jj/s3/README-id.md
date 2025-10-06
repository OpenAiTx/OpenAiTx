
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# s3 - Pelatihan Agen Pencarian Efisien dan Efektif melalui RL
***Anda Tidak Membutuhkan Begitu Banyak Data untuk Melatih Agen Pencarian***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**Ikhtisar Kinerja:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## Apa itu s3?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**Kerangka Kerja s3**
</div>

`s3` adalah kerangka kerja yang sederhana namun kuat untuk melatih agen pencarian dalam retrieval-augmented generation (RAG). Kerangka ini mengajarkan model bahasa cara mencari dengan lebih efektif—tanpa mengubah generator itu sendiri. Dengan hanya berfokus pada komponen pencarian, `s3` mencapai performa yang kuat di berbagai tugas QA dengan hanya sebagian kecil dari data yang digunakan oleh metode sebelumnya. Kerangka ini modular, efisien, dan dirancang untuk bekerja secara mulus dengan LLM black-box apa pun.



## Daftar Isi

- [📦 Instalasi](#-instalasi)
- [💡 Persiapan](#-persiapan)
- [🏋️ Jalankan Pelatihan](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-jalankan-pelatihan)
- [🔍 Jalankan Pencarian/Retrieval](https://github.com/pat-jj/s3?tab=readme-ov-file#-jalankan-pencarianretrieval)
- [📈 Jalankan Evaluasi](#-jalankan-evaluasi)

## 📦 Instalasi

**Lingkungan Searcher & Generator**
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
**Lingkungan Retriever**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 Persiapan
***Unduh Indeks & Korpus***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***Pra-komputasi Inisialisasi RAG Naïf*** (atau Anda dapat mengunduh data yang telah kami proses di sini: [huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data))

```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ Jalankan Pelatihan
***Langkah ini untuk pelatihan S3***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 Jalankan Pencarian/Pengambilan
***Langkah ini untuk pengumpulan konteks s3 / baseline***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>Baselines</summary>

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
**Pencarian-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**Pencarian-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 Jalankan Evaluasi
***Langkah ini untuk evaluasi s3 / baseline***



```bash
bash scripts/evaluation/run.sh
```

## Tanya Jawab
### Data Kustom?
Jika Anda ingin menguji s3 pada korpus/dataset milik Anda sendiri, Anda dapat merujuk ke commit berikut untuk melihat apa yang perlu Anda lakukan untuk membangun pipeline Anda sendiri: [commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### Mereproduksi Hasil?
Beberapa pengembang telah berhasil mereproduksi hasil kami. Jika Anda memiliki pertanyaan atau mengalami kendala, silakan [buka isu](https://github.com/pat-jj/s3/issues) — kami dengan senang hati akan memberikan panduan langsung (lihat [contoh ini](https://github.com/pat-jj/s3/issues/20)).

Walaupun mereproduksi model sendiri cukup mudah — dan kami sebenarnya **merekomendasikan pelatihan dari awal**, karena evaluasi biasanya jauh lebih memakan waktu daripada pelatihan — kami juga menyediakan checkpoint referensi: [s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps), yang dilatih sekitar satu jam.



## Penghargaan
Kami ingin berterima kasih kepada proyek-proyek berikut:
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## Sitasi
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
Terima kasih atas ketertarikan Anda pada pekerjaan kami!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---