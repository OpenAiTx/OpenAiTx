
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">Bahasa Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Less is Enough: Het Syntheseren van Diverse Data in de Feature Space van LLMs

Dit is de officiële implementatie van het artikel: `Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs`.

---

## Kerninzicht

✨ **Werk slimmer, niet harder.**

In de post-trainingsfase van LLMs is het effectiever om nauwkeurig de **werkelijk ontbrekende sleutelkenmerken** te identificeren en te synthetiseren, in plaats van blindelings enorme hoeveelheden oppervlakkig diverse teksten toe te voegen. Met slechts een klein aantal gerichte synthetische samples kunnen we significante lacunes vullen in de **Feature Activation Coverage (FAC)**, wat leidt tot duidelijke prestatieverbeteringen bij downstream taken.

### Waarom is dit inzicht eenvoudig maar krachtig?

Traditionele datasynthese richt zich op hoeveelheid en oppervlakkige diversiteit (vocabulaire, zinspatronen, topicverdeling), maar dit zijn vaak slechts **zwakke indicatoren**. Wat de prestaties van een model bij downstream taken werkelijk bepaalt, is **de dekking van de sleutelkenmerken die door de doeltaak vereist zijn**.

Ons werk onthult:

- Veel teksten die "heel verschillend lijken" activeren in werkelijkheid sterk overlappende kenmerken;
- **FAC** voorspelt downstream prestaties veel beter dan standaard diversiteitsmetingen, waaronder **Distinct-1/2** en **n-gram Entropy** op woordniveau, **POS-tag Distinct-2** op syntactisch niveau, en **Pair CosDist** en **Semantic Entropy** op embeddingniveau.  
- Voor instructievolging behaalt **FAC Synthesis** prestaties die vergelijkbaar zijn met de eerdere SOTA **MAGPIE**, terwijl er **150× minder data** nodig is dan MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Figuur 1:</b> De Efficiency Frontier van instructievolgende datasets. Onze voorgestelde methode behaalt een Win Rate op AlpacaEval 2.0 vergelijkbaar met MAGPIE, terwijl slechts 2K synthetische samples worden gebruikt (vs. 300K voor MAGPIE).
</p>

---

## Aan de slag

### Installatie

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

### Pre-training Sparse Autoencoders
De meeste scripts voor SAE-pretraining bevinden zich in `sae_pretrain/`. We bieden vooraf getrainde SAE-checkpoints aan op Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

Om SAEs te pretrainen, voer de volgende commando's uit:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### Analyse van de kenmerken van SAE
Kenmerkenanalysetscripts bevinden zich in `sae_feature_analysis/`. Om activatiespannen te groeperen en menselijk leesbare kenmerkinterpretaties te genereren, voer uit:

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

### Door dekking gestuurde gegevenssynthese
Scripts voor door dekking gestuurde synthese zijn te vinden in fac_synthesis/. Om synthetische queries te genereren, voer uit

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

## Dankbetuigingen

In de evaluatiefase zijn onze downstream trainings- en test-scripts aangepast van de volgende open-source repositories:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Referentie

Als u dit werk nuttig vindt voor uw onderzoek, citeer dan ons artikel 🤩:

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