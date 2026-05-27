
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">Vereinfachtes Chinesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">Traditionelles Chinesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">Assamesisch</
      </div>
    </div>
  </details>
</div>

# Weniger ist genug: Synthese vielfältiger Daten im Merkmalsraum von LLMs

Dies ist die offizielle Implementierung des Papers: `Weniger ist genug: Synthese vielfältiger Daten im Merkmalsraum von LLMs`.

---

## Zentrale Erkenntnis

✨ **Arbeite intelligenter, nicht härter.**

Im Post-Training-Stadium von LLMs ist es effektiver, statt blind eine riesige Menge oberflächlich unterschiedlicher Texte hinzuzufügen, gezielt jene **wirklich fehlenden Schlüsselfunktionen** zu identifizieren und zu synthetisieren. Mit nur wenigen zielgerichteten synthetischen Beispielen können wir die Lücken in der **Feature Activation Coverage (FAC)** deutlich schließen, was zu klaren Leistungssteigerungen bei nachgelagerten Aufgaben führt.

### Warum ist diese Erkenntnis einfach und zugleich kraftvoll?

Traditionelle Datensynthese konzentriert sich auf Menge und oberflächliche Diversität (Wortschatz, Satzmuster, Themenverteilung), doch dies sind oft nur **schwache Stellvertreter**. Was die Leistung eines Modells bei nachgelagerten Aufgaben wirklich bestimmt, ist **die Abdeckung der Schlüsselfunktionen, die für die Zielaufgabe erforderlich sind**.

Unsere Arbeit zeigt:

- Viele Texte, die „sehr unterschiedlich erscheinen“, aktivieren tatsächlich stark überlappende Funktionen;
- **FAC** sagt die Leistung bei nachgelagerten Aufgaben deutlich besser voraus als herkömmliche Diversitätsmetriken, darunter **Distinct-1/2** und **n-Gramm-Entropie** auf Wortebene, **POS-Tag Distinct-2** auf Syntaxebene sowie **Pair CosDist** und **Semantische Entropie** auf Einbettungsebene.
- Beim Befolgen von Anweisungen erreicht **FAC Synthesis** eine Leistung, die mit dem bisherigen SOTA **MAGPIE** vergleichbar ist, benötigt jedoch **150× weniger Daten** als MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Abbildung 1:</b> Die Effizienzgrenze von Datensätzen zur Befolgung von Anweisungen. Unsere vorgeschlagene Methode erreicht eine Win Rate bei AlpacaEval 2.0, die mit MAGPIE vergleichbar ist, und verwendet dabei nur 2K synthetische Beispiele (im Vergleich zu 300K bei MAGPIE).
</p>

---

## Einstieg

### Installation

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

### Vortrainierte Sparse Autoencoder
Die meisten Skripte für das SAE-Vortraining befinden sich in `sae_pretrain/`. Wir stellen vortrainierte SAE-Checkpoints auf Hugging Face bereit:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

Um SAEs vorzutrainieren, führen Sie die folgenden Befehle aus:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### Analyse der Merkmale von SAE
Merkmalsanalyse-Skripte befinden sich in `sae_feature_analysis/`. Um Aktivierungsspannen zu gruppieren und menschenlesbare Merkmalsinterpretationen zu erzeugen, führen Sie Folgendes aus:

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

### Abdeckungsgeführte Datensynthese
Abdeckungsgeführte Syntheseskripte befinden sich in fac_synthesis/. Um synthetische Abfragen zu erzeugen, führen Sie Folgendes aus

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

## Danksagungen

In der Evaluierungsphase wurden unsere Downstream-Trainings- und Testskripte aus den folgenden Open-Source-Repositorien adaptiert:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Zitation

Wenn Sie diese Arbeit für Ihre Forschung hilfreich finden, zitieren Sie bitte unser Paper 🤩:

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