# KVzip: Bağlam Yeniden Yapılandırma ile Sorgudan Bağımsız KV Önbellek Sıkıştırması

[[Makale](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Yenilikler Neler?
- KVzip, **çeşitli gelecekteki sorguları** desteklemek için KV önbelleğini sıkıştırır.
- [Bağlama bağımlı] Minimal performans düşüşüyle **KV önbellek boyutunda 3–4× azalma** ve **çözümleme gecikmesinde 2× düşüş** sağlar.
- [Bağlamdan bağımsız] Yalnızca **bir dakika içinde birkaç ileri geçiş** kullanarak başlık seviyesinde önem skor optimizasyonu ile [DuoAttention](https://github.com/mit-han-lab/duo-attention)-tarzı başlık seviyesinde KV sıkıştırmasını geliştirir (100 kat daha hızlı).
- demo.py çalıştırın:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Sorgudan Bağımsız Ayarda Kıyaslama
- Görevler: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Model: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Kurulum
CUDA 12.1 ve Python 3.10 kullandık
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- [QServe](https://github.com/mit-han-lab/omniserve) kuantizasyonunu kullanmak için lütfen [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model) dizinini takip edin.
### Veri Seti
- Ön işlenmiş SCBench veri setini [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link) üzerinden indirin.
- Dosyaları açtıysanız, scbench klasörünü ilgili yere taşıyın.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Hızlı Başlangıç
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # KV önbelleğini doldur + önem skoru hesapla
kv.prune(ratio=0.3)  # sıkıştırma oranı, %70 KV çıkarılır

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # verimli çıkarım
    print(q, output)
```
- Desteklenen modeller [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) dosyasında listelenmiştir, **LLaMA3, Qwen2.5/3, Gemma3** dahildir.
- Sıkıştırma yükünü ortadan kaldırmak için `load_score=True` ayarlayın. Bu, bağlamdan bağımsız KV çıkarımını etkinleştirir ve sıkıştırma oranı `ratio=0.6` ile bir denge sağlar.
- Üretim sonrası, sorgulara ve üretilen tokenlara karşılık gelen KV çiftleri önbellekten seçici olarak çıkarılır. Çoklu tur çıkarımı için `update_cache=True` ayarlayın; böylece çıkarım boyunca tam etkileşim geçmişi korunur.

## Bellek ve Hesaplama Süresi Profilleme
### Bağlama Bağlı Çıkarma
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Yukarıdaki kod tam ve budanmış KV önbelleklerle üretilen çıktıları karşılaştırır.
- Hızlı test için `-d squad`, uzun bağlam testi için `-d scbench_kv` kullanın.
  - Mevcut veri isimleri: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Mevcut model isimleri: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), örn. llama3.1-8b, qwen2.5-7b (veya Qwen/Qwen2.5-7B-Instruct-1M).
- CUDA çekirdeğini [AdaKV](https://github.com/FFY0/AdaKV/tree/main) projesinden uyarladık, başlık bütçesi tahsisine destek verir.
  - Şu anda, statik KV önbelleği kullanan Gemma3 için optimize edilmiş çekirdeğimiz yoktur; bu nedenle kod gerçek verimlilik kazancı sağlamaz. Ancak, model performansı KV alt örneklemeli azalan dikkat ile değerlendirilebilir (`--kv_type retain`).


### Bağlamdan Bağımsız Çıkarma (çalışma zamanı sıkıştırma yükü yok)
- `--level head` bayrağı ile `--ratio 0.6` (önerilen) kullanın.
  - Sistem istemi ve sorgu KV çiftleri korunurken belirli bir başlığa ait tüm bağlam KV çiftleri kaldırılır.
  - Önceden hesaplanmış başlık skorları LLaMA3.1-8B ve Qwen2.5-7/14B için `./utils/head_score` dizininde mevcuttur.
- Diğer modeller için başlık skorlarını hesaplamak üzere:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Sonuçlar `./utils/head_score` dizinine kaydedilecektir.
  - Kodlama görevi hedefleniyorsa, ayrıca `-d scbench_repoqa` ile komutu çalıştırmanızı öneririz. Bu, modelin hem doğal hem de kodlama dillerinden en yüksek başlık skorlarını kullanmasını sağlar ve performansı artırır.
- Bu skorlar [DuoAttention](https://github.com/mit-han-lab/duo-attention) optimize edilmiş çıkarım motoruna sorunsuz şekilde entegre edilebilir; kendi başlık skoru verileriyle değiştirilebilir.


## Değerlendirme
- 0.1 ila 1.0 arasında değişen KV sıkıştırma oranlarıyla model yanıtları üretmek için:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Sonuçlar `./results/[data_name]` dizinine kaydedilecektir.
  - Desteklenen veri setleri `data/load.py` dosyasında listelenmiştir.
- Üretilen sonuçlardan değerlendirme metriklerini hesaplamak için:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Yeni Modeller İçin Uygulama
KVzip'i yeni bir modele entegre etmek için aşağıdaki dosyaları güncellemeniz gerekir:
- `attention/attn.py`  
  Gerekirse dikkat ileri geçiş mantığını değiştirin. Bazı durumlarda kvcache.py ve score.py dosyalarında da güncelleme gerekebilir.
- `model/monkeypatch.py`  
  Entegrasyon için model-spesifik monkey patch uygulayın.
- `model/template.py`   
  Modelin sistem istemi ve sohbet biçimlendirme şablonlarını tanımlayın.


## Atıf
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Lisans
MIT Lisansı

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---