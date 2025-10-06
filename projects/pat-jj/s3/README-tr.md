
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# s3 - RL ile Verimli ve Etkili Arama Ajanı Eğitimi
***Bir Arama Ajanı Eğitmek İçin O Kadar Fazla Veriye İhtiyacınız Yok***

<p align="center">

  <a href="https://arxiv.org/abs/2505.14146">
    <img src="https://img.shields.io/badge/arXiv-2505.14146-b31b1b.svg" alt="arXiv">
  </a>
</p>
</div>

**Performans Genel Bakışı:**

<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/performance_overview.png" alt="performance_overview" width="800">



## s3 nedir?

<div align="center">
<img src="https://raw.githubusercontent.com/pat-jj/s3/main/images/framework.png" alt="framework" width="800">

**s3 Çerçevesi**
</div>

`s3`, arama ajanlarını geri alma ile artırılmış üretim (RAG) kapsamında eğitmek için basit ama güçlü bir çerçevedir. Dil modellerine, üreticiyi değiştirmeden daha etkili arama yapmayı öğretir. Yalnızca arama bileşenine odaklanarak, `s3` önceki yöntemlere kıyasla kullanılan verinin sadece küçük bir kısmıyla QA görevlerinde yüksek performans elde eder. Modülerdir, verimlidir ve herhangi bir kara kutu LLM ile sorunsuz çalışacak şekilde tasarlanmıştır.



## İçindekiler

- [📦 Kurulum](#-kurulum)
- [💡 Hazırlık](#-hazırlık)
- [🏋️ Eğitim Çalıştır](https://github.com/pat-jj/s3?tab=readme-ov-file#%EF%B8%8F-e%C4%9Fitim-%C3%A7al%C4%B1%C5%9Ft%C4%B1r)
- [🔍 Arama/Geri Alma Çalıştır](https://github.com/pat-jj/s3?tab=readme-ov-file#-arama-geri-alma-%C3%A7al%C4%B1%C5%9Ft%C4%B1r)
- [📈 Değerlendirme Çalıştır](#-de%C4%9Eerlendirme-%C3%A7al%C4%B1%C5%9Ft%C4%B1r)

## 📦 Kurulum

**Arama ve Üretici Ortamı**
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
**Retriever Ortamı**

```bash
conda create -n ret python=3.10
conda activate ret

conda install pytorch==2.4.0 torchvision==0.19.0 torchaudio==2.4.0 pytorch-cuda=12.1 -c pytorch -c nvidia
pip install transformers datasets pyserini
conda install -c pytorch -c nvidia faiss-gpu=1.8.0
pip install uvicorn fastapi
```
## 💡 Hazırlık
***Dizin ve Korpus İndir***



```bash
python scripts/download.py --save_path $save_path
cat $save_path/part_* > $save_path/e5_Flat.index
gzip -d $save_path/wiki-18.jsonl.gz
```

***Naif RAG Başlatmasını Önceden Hesapla*** (veya işlenmiş verimizi buradan indirebilirsiniz: [huggingface](https://huggingface.co/datasets/pat-jj/s3_processed_data))

```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh # or scripts/deploy_retriever/retrieval_launch_mirage.sh for MedCorp corpus.
# deploy generator
bash generator_llms/host.sh # modify tensor-parallel-size to the number of GPUs you use
# run precompute
bash scripts/precompute.sh # this step will take a while, as it will precompute the naïve RAG Cache for training
```
## 🏋️ Antrenmanı Başlat
***Bu adım S3'ün eğitimi içindir***



```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# deploy generator
bash generator_llms/host.sh
# run training
bash scripts/train/train_s3.sh
```
## 🔍 Arama/Alma İşlemini Çalıştırın
***Bu adım, s3 / temel modeller için bağlam toplama içindir***

**s3**


```bash
# deploy retriever
bash scripts/deploy_retriever/retrieval_launch.sh 
# run s3 inference
bash scripts/s3_inference/evaluate-8-3-3.sh
```
<details>
<summary>Temel Değerler</summary>

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
**Ara-R1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_r1.sh # run Search-R1
```
**IRCoT**

```bash
bash retrieval_launch.sh # deploy e5 retriever
python scripts/baselines/ircot.py
```
**Arama-o1**

```bash
bash retrieval_launch.sh # deploy e5 retriever
bash scripts/baselines/search_o1.sh # run Search-o1
```
</details>


## 📈 Değerlendirme Çalıştırma
***Bu adım s3 / temel modellerin değerlendirmesi içindir***



```bash
bash scripts/evaluation/run.sh
```

## Soru&Cevap
### Özelleştirilmiş Veri?
S3'ü kendi korpusunuz/veri setiniz üzerinde test etmek istiyorsanız, kendi hattınızı nasıl kurmanız gerektiğini görmek için şu commite başvurabilirsiniz: [commit 8420538](https://github.com/pat-jj/s3/commit/8420538836febbe59d5bcbe41187f16908c9c36c)

### Sonuçların Yeniden Üretilmesi?
Birçok geliştirici sonuçlarımızı başarıyla yeniden üretti. Sorularınız varsa veya bir sorunla karşılaşırsanız, [issue açmaktan](https://github.com/pat-jj/s3/issues) çekinmeyin — pratik destek sağlamaktan mutluluk duyarız (bkz. [bu örnek](https://github.com/pat-jj/s3/issues/20)).

Modeli kendinizin yeniden üretmesi oldukça kolaydır — ve aslında **sıfırdan eğitmenizi tavsiye ediyoruz**, çünkü değerlendirme çoğu zaman eğitimden daha fazla zaman alabiliyor — ayrıca referans bir kontrol noktası da sunuyoruz: [s3-8-3-3-20steps](https://huggingface.co/pat-jj/s3-8-3-3-20steps), yaklaşık bir saatte eğitilmiştir.



## Teşekkür
Aşağıdaki projelere teşekkür etmek isteriz:
[verl](https://github.com/volcengine/verl), [RAGEN](https://github.com/RAGEN-AI/RAGEN), [Search-R1](https://github.com/PeterGriffinJin/Search-R1), [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval), [PySerini](https://github.com/castorini/pySerini).
 

## Atıf
```bibtex
@article{jiang2025s3,
  title={s3: You Don't Need That Much Data to Train a Search Agent via RL},
  author={Jiang, Pengcheng and Xu, Xueqiang and Lin, Jiacheng and Xiao, Jinfeng and Wang, Zifeng and Sun, Jimeng and Han, Jiawei},
  journal={arXiv preprint arXiv:2505.14146},
  year={2025}
}
```
Çalışmamıza gösterdiğiniz ilgi için teşekkür ederiz!






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---