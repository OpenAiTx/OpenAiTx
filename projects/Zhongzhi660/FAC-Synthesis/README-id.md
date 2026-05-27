
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">Inggris</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">Jepang</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">Korea</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">Prancis</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">Jerman</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">Spanyol</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">Italia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">Rusia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">Portugis</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">Belanda</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">Arab</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">Persia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">Turki</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">Vietnam</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Less is Enough: Sintesis Data Beragam di Ruang Fitur LLM

Ini adalah implementasi resmi dari makalah: `Less is Enough: Synthesizing Diverse Data in Feature Space of LLMs`.

---

## Inti Utama

✨ **Bekerja lebih cerdas, bukan lebih keras.**

Pada tahap pelatihan lanjutan LLM, alih-alih menambahkan sejumlah besar teks permukaan yang beragam secara membabi buta, jauh lebih efektif untuk secara tepat mengidentifikasi dan mensintesis **fitur kunci yang benar-benar hilang**. Dengan hanya sejumlah kecil sampel sintetis yang terarah, kita dapat secara signifikan mengisi kekosongan dalam **Feature Activation Coverage (FAC)**, menghasilkan peningkatan kinerja yang jelas pada tugas-tugas lanjutan.

### Mengapa wawasan ini sederhana namun kuat?

Sintesis data tradisional berfokus pada kuantitas dan keragaman permukaan (kosakata, pola kalimat, distribusi topik), namun ini seringkali hanya merupakan **indikator lemah**. Yang benar-benar menentukan kinerja model pada tugas lanjutan adalah **cakupan fitur kunci yang dibutuhkan oleh tugas target**.

Penelitian kami mengungkapkan:

- Banyak teks yang "terlihat sangat berbeda" sebenarnya mengaktifkan fitur yang sangat tumpang tindih;
- **FAC** memprediksi kinerja lanjutan jauh lebih baik daripada metrik keragaman standar, termasuk **Distinct-1/2** dan **n-gram Entropy** di tingkat kata, **POS-tag Distinct-2** di tingkat sintaksis, serta **Pair CosDist** dan **Semantic Entropy** di tingkat embedding.  
- Untuk mengikuti instruksi, **FAC Synthesis** mencapai kinerja sebanding dengan SOTA sebelumnya **MAGPIE**, namun hanya membutuhkan **150× lebih sedikit data** dibanding MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Gambar 1:</b> Frontier Efisiensi Dataset Instruksi. Metode yang kami usulkan mencapai Win Rate di AlpacaEval 2.0 yang sebanding dengan MAGPIE namun hanya menggunakan 2K sampel sintetis (vs. 300K untuk MAGPIE).
</p>

---

## Memulai

### Instalasi

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

### Pralatih Sparse Autoencoders
Sebagian besar skrip untuk pretraining SAE terletak di `sae_pretrain/`. Kami menyediakan checkpoint SAE yang sudah dilatih sebelumnya di Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

Untuk melakukan pretraining SAE, jalankan perintah berikut:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### Menganalisis fitur SAE
Skrip analisis fitur terletak di `sae_feature_analysis/`. Untuk mengelompokkan rentang aktivasi dan menghasilkan interpretasi fitur yang mudah dibaca manusia, jalankan:

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

### Sintesis data berbasis cakupan
Skrip sintesis berbasis cakupan terletak di fac_synthesis/. Untuk menghasilkan kueri sintetis, jalankan

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

## Ucapan Terima Kasih

Pada tahap evaluasi, skrip pelatihan dan pengujian downstream kami diadaptasi dari repositori open-source berikut:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Sitasi

Jika Anda merasa pekerjaan ini bermanfaat untuk riset Anda, silakan sitasi makalah kami 🤩:

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