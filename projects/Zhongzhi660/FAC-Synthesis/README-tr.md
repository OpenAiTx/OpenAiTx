
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Az Daha Yeterlidir: LLM'lerin Özellik Uzayında Çeşitli Veri Sentezi

Bu, şu makalenin resmi uygulamasıdır: `Az Daha Yeterlidir: LLM'lerin Özellik Uzayında Çeşitli Veri Sentezi`.

---

## Temel İçgörü

✨ **Daha akıllı çalışın, daha çok değil.**

LLM'lerin eğitim sonrası aşamasında, yüzeysel olarak çeşitli büyük miktarda metin eklemek yerine, **gerçekten eksik olan temel özellikleri** hassas bir şekilde belirlemek ve sentezlemek daha etkilidir. Sadece az sayıda hedefe yönelik sentetik örnekle, **Özellik Aktivasyon Kapsamı (FAC)**'ndaki boşlukları önemli ölçüde doldurabilir ve bu da aşağı akış görevlerinde belirgin performans iyileşmeleri sağlar.

### Bu içgörü neden basit ama güçlü?

Geleneksel veri sentezi miktara ve yüzey çeşitliliğine (kelime dağarcığı, cümle kalıpları, konu dağılımı) odaklanır, ancak bunlar çoğunlukla sadece **zayıf vekillerdir**. Bir modelin aşağı akış performansını gerçekten belirleyen şey, **hedef görevin gerektirdiği temel özelliklerin kapsanmasıdır**.

Çalışmamız şunları ortaya koyuyor:

- "Çok farklı görünen" birçok metin aslında büyük oranda örtüşen özellikleri aktive ediyor;
- **FAC**, aşağı akış performansını standart çeşitlilik metriklerinden çok daha iyi öngörür; bunlar arasında kelime düzeyinde **Distinct-1/2** ve **n-gram Entropy**, sözdizimi düzeyinde **POS-tag Distinct-2** ve gömülü düzeyde **Pair CosDist** ile **Semantic Entropy** bulunur.  
- Yönerge takibinde, **FAC Sentezi** önceki SOTA **MAGPIE** ile karşılaştırılabilir bir performansa ulaşırken, MAGPIE'den **150× daha az veri** gerektirir.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Şekil 1:</b> Yönerge Takip Veri Setlerinin Verimlilik Sınırı. Önerdiğimiz yöntem, AlpacaEval 2.0'da MAGPIE ile karşılaştırılabilir bir Kazanma Oranı elde ederken yalnızca 2K sentetik örnek kullanır (MAGPIE için 300K'ya kıyasla).
</p>

---

## Başlarken

### Kurulum

```bash
git clone https://github.com/Zhongzhi660/FAC-Synthesis.git
cd FAC-Synthesis
pip install -r requirements.txt
```

---

### Repository Structure

```text
FAC-Synthesis/
├── LICENSE
├── README.md
├── requirements.txt
│
├── sae_pretrain/                 # SAE pretraining
│   ├── datasets/                 # pretraining corpora (constructed from public sources)
│   └── outputs/                  # SAE pre-trained weights
│
├── sae_feature_analysis/         # SAE feature analysis pipeline
│   ├── interpret_features/       # feature interpretation (span collection + annotation)
│   ├── identify_task_relevant_features/   # task-relevant feature identification
│   └── identify_missing_features/         # missing-feature discovery (coverage gap)
│
├── fac_synthesis/                # FAC synthesis pipeline
│   ├── step1_contrastive_pair_construction/      # Step-1: contrastive pair construction
│   └── step2_feature_covered_sample_synthesis/   # Step-2: feature-covered synthesis
│
└── training_scripts/             # Downstream training / evaluation scripts
    ├── toxicity_detection/
    ├── reward_modeling/
    ├── instruction_following/
    └── behavior_steering/
```

### SAE’lerin Ön Eğitimi
SAE ön eğitimi için betiklerin çoğu `sae_pretrain/` dizininde bulunur. Hugging Face üzerinde önceden eğitilmiş SAE kontrol noktaları sağlıyoruz:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

SAE’leri önceden eğitmek için aşağıdaki komutları çalıştırın:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### SAE özelliklerinin analiz edilmesi
Özellik analiz scriptleri `sae_feature_analysis/` dizininde yer almaktadır. Aktivasyon aralıklarını gruplandırmak ve insan tarafından okunabilir özellik yorumları oluşturmak için şunu çalıştırın:

```bash
# Step-1: Group extracted activation spans
python groupby_textspans.py /xxx/threshold_0.0

# Step-2: Annotate feature explanations based on grouped spans
python annotate_explanations.py /xxx/threshold_0.0.tsv

# Step-3: Identify task-relevant features from the explanations
python annotate_toxicity.py /xxx/threshold_0.0_explained.tsv

# Step-4: Identify missing features via FAC analysis
python identify_fac.py anchor_features.tsv (complete) task_features.tsv (currently available)
```

### Kapsam rehberli veri sentezi
Kapsam rehberli sentez betikleri fac_synthesis/ içinde bulunur. Sentetik sorgular oluşturmak için çalıştırın

```bash
# Step-1 (1): Contrastive Pair Construction
python generate_data_llama_r1.py \
  --features xxx.tsv \
  --out xxx \
  --temperature 0.8
# Step-1 (2): Feature-Covered Sample Synthesis
python analyze_step1_synthetic_data.py
python merge_step1_failed_cases.py

# Step-2: Feature-Covered Sample Synthesis
python generate_data_llama_r2.py \
  --features xxx.tsv \
  --out xxx \
  --temperature 0.8
```

---

## Teşekkürler

Değerlendirme aşamasında, aşağıdaki açık kaynaklı depolardan uyarlanan eğitim ve test betikleri kullanılmıştır:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Atıf

Bu çalışmanın araştırmanız için faydalı olduğunu düşünüyorsanız, lütfen makalemizi atıf olarak gösterin 🤩:

```bibtex
@article{li2026less,
  title={Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs},
  author={Li, Zhongzhi and Wu, Xuansheng and Li, Yijiang and Hu, Lijie and Liu, Ninghao},
  journal={arXiv preprint arXiv:2602.10388},
  year={2026}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---