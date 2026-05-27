
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# কমেই যথেষ্ট: LLMs-ৰ ফিচাৰ স্পেচত বৈচিত্ৰ্যপূর্ণ ডাটা সংশ্লেষণ

এইটো হৈছে কাগজখনৰ চৰকাৰী বাস্তৱায়ন: `কমেই যথেষ্ট: LLMs-ৰ ফিচাৰ স্পেচত বৈচিত্ৰ্যপূর্ণ ডাটা সংশ্লেষণ`।

---

## মূল অন্তৰ্দৃষ্টি

✨ **বেছিকৈ কাম কৰক, কঠিনকৈ নহয়।**

LLM-ৰ পোস্ট-ট্ৰেইনিং পৰ্যায়ত, ওপৰ-সতৰীয়া বৈচিত্ৰ্যপূৰ্ণ পাঠ্য ডাঙৰ পৰিমাণত অন্ধভাৱে যোগ কৰাৰ পরিবর্তে, **সঁচাকৈয়ে অভাৱ থকা মুখ্য ফিচাৰসমূহ** সঠিকভাৱে চিনাক্ত কৰা আৰু সংশ্লেষণ কৰাটো অধিক ফলপ্ৰসূ। কেৱল অলপসংখ্যক লক্ষ্যভেদী সংশ্লেষিত নমুনাৰে, আমি **Feature Activation Coverage (FAC)**-ত গুৰুত্বপূৰ্ণ অভাৱ পূৰণ কৰিব পাৰো, যাৰ ফলত ডাউনষ্ট্ৰীম টাস্কসমূহত স্পষ্ট কাৰ্যক্ষমতা উন্নতি ঘটে।

### এই দৃষ্টিভংগীটো কিয় সহজ কিন্তু শক্তিশালী?

পৰম্পৰাগত ডাটা সংশ্লেষণৰ কেন্দ্ৰবিন্দু হৈছে পৰিমাণ আৰু ওপৰৰ বৈচিত্ৰ্য (শব্দভাণ্ডাৰ, বাক্যৰ গঠন, বিষয়ৰ বিতৰণ), কিন্তু এইবোৰ সাধাৰণতে **দুৰ্বল প্ৰতিনিধি**হে। মডেলটোৰ ডাউনষ্ট্ৰীম কাৰ্যক্ষমতা যি বস্তুয়ে প্ৰকৃততে নিৰ্ধাৰণ কৰে, সেইটো হৈছে **লক্ষ্য টাস্কৰ বাবে প্ৰয়োজনীয় মুখ্য ফিচাৰসমূহৰ কভারেজ**।

আমাৰ কামত প্ৰকাশ পাইছে:

- বহুত পাঠ্য "দেখাত বহুত ভিন্ন" হলেও বেছিভাগ ফিচাৰ অত্যধিকসংখ্যকভাৱে একে সময়তে সক্ৰিয় কৰে;
- **FAC**-এ ডাউনষ্ট্ৰীম কাৰ্যক্ষমতা পৰিপ্ৰেক্ষিতত সাধাৰণ বৈচিত্ৰ্য মেট্ৰিকসমূহতকৈ বহু ভালভাৱে পূৰ্বানুমান দিয়ে, যেনে শব্দস্তৰৰ **Distinct-1/2** আৰু **n-gram Entropy**, ব্যাকৰণিক স্তৰৰ **POS-tag Distinct-2**, আৰু এম্বেডিং স্তৰৰ **Pair CosDist** আৰু **Semantic Entropy**।  
- নিৰ্দেশনা অনুসৰণত, **FAC Synthesis**-এ পূৰ্বৰ SOTA **MAGPIE**-ৰ সমান কাৰ্যক্ষমতা দেখুৱায়, লগতে MAGPIE-ৰ তুলনাত **১৫০ গুণ কম ডাটা** প্ৰয়োজন হয়।

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>চিত্র ১:</b> নিৰ্দেশনা অনুসৰণ ডাটাচেটৰ দক্ষতা সীমা। আমাৰ প্ৰস্তাৱিত পদ্ধতিয়ে AlpacaEval 2.0-ত MAGPIE-ৰ সমান Win Rate লাভ কৰে, কেৱল ২ হাজাৰ সংশ্লেষিত নমুনা ব্যৱহাৰ কৰি (MAGPIE-ৰ বাবে ৩ লাখৰ বিপৰীতে)।
</p>

---

## আৰম্ভণি

### ইনষ্টলেশ্যন

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

### প্ৰি-ট্ৰেইনিং স্পাৰ্ছ অ’ট’ইনক’ডাৰ্ছ
SAE প্ৰি-ট্ৰেইনিঙৰ বেছিভাগ স্ক্ৰিপ্ট `sae_pretrain/`-ত অৱস্থিত। আমি হাগিং ফেচত প্ৰি-ট্ৰেইন কৰা SAE চেকপইণ্টসমূহ প্ৰদান কৰিছোঁ:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

SAE প্ৰি-ট্ৰেইন কৰিবলৈ, তলৰ নিৰ্দেশনাবোৰ চলাও:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### SAE ৰ বৈশিষ্ট্যসমূহৰ বিশ্লেষণ
বৈশিষ্ট্য বিশ্লেষণ স্ক্ৰিপ্টসমূহ `sae_feature_analysis/` ত অৱস্থিত। সক্ৰিয়কৰণ স্পেনসমূহক গোটবদ্ধ কৰিবলৈ আৰু মানুহে পঢ়িব পৰা বৈশিষ্ট্য ব্যাখ্যা উত্পন্ন কৰিবলৈ, চলাও:

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

### কভারেজ-নির্দেশিত ডেটা সংশ্লেষণ
কভারেজ-নির্দেশিত সংশ্লেষণ স্ক্ৰিপ্টসমূহ fac_synthesis/ত অৱস্থিত। কৃত্রিম প্ৰশ্নসমূহ উৎপন্ন কৰিবলৈ, চলাও

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

## কৃতজ্ঞতা

মূল্যাংকন পৰ্যায়ত, আমাৰ ডাউনষ্ট্ৰীম প্ৰশিক্ষণ আৰু পৰীক্ষা স্ক্ৰিপ্টসমূহ তলত উল্লেখ কৰা মুক্ত উৎস ৰেপ'জিট'ৰীসমূহৰ পৰা ৰূপান্তৰ কৰা হৈছে:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## উদ্ধৃতি

আপুনি যদি এই কামটো আপোনাৰ গৱেষণাৰ বাবে সহায়ক বুলি পোৱা যায়, অনুগ্ৰহ কৰি আমাৰ কাকতখন উদ্ধৃতি দিয়ক 🤩:

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