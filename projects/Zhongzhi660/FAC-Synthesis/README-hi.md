
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# कम ही काफी है: LLMs की फीचर स्पेस में विविध डेटा का संश्लेषण

यह पेपर का आधिकारिक कार्यान्वयन है: `कम ही काफी है: LLMs की फीचर स्पेस में विविध डेटा का संश्लेषण`।

---

## मुख्य विचार

✨ **स्मार्ट तरीके से काम करें, ज्यादा मेहनत न करें।**

LLMs के पोस्ट-ट्रेनिंग चरण में, सतही विविध पाठ की भारी मात्रा को अंधाधुंध जोड़ने के बजाय, उन **वास्तव में गायब प्रमुख विशेषताओं** की सटीक पहचान और संश्लेषण अधिक प्रभावी है। केवल कुछ लक्षित सिंथेटिक नमूनों के साथ, हम **फ़ीचर सक्रियण कवरेज (FAC)** में अंतराल को काफी हद तक भर सकते हैं, जिससे डाउनस्ट्रीम कार्यों पर प्रदर्शन में स्पष्ट सुधार होता है।

### यह अंतर्दृष्टि सरल होते हुए भी शक्तिशाली क्यों है?

परंपरागत डेटा संश्लेषण मात्रा और सतही विविधता (शब्दावली, वाक्य संरचना, विषय वितरण) पर केंद्रित होता है, लेकिन ये अक्सर केवल **कमजोर संकेतक** होते हैं। मॉडल के डाउनस्ट्रीम प्रदर्शन को वास्तव में **लक्षित कार्य द्वारा आवश्यक प्रमुख विशेषताओं की कवरेज** निर्धारित करती है।

हमारे कार्य में यह सामने आया है:

- कई पाठ जो "बहुत अलग दिखते हैं" वास्तव में अत्यधिक ओवरलैपिंग फीचर्स को सक्रिय करते हैं;
- **FAC** डाउनस्ट्रीम प्रदर्शन की भविष्यवाणी मानक विविधता मीट्रिक्स की तुलना में कहीं बेहतर करता है, जिनमें **Distinct-1/2** और **n-gram Entropy** (शब्द स्तर पर), **POS-tag Distinct-2** (सिंटैक्स स्तर पर), और **Pair CosDist** व **Semantic Entropy** (एम्बेडिंग स्तर पर) शामिल हैं।  
- इंस्ट्रक्शन फॉलोइंग के लिए, **FAC सिंथेसिस** पहले के SOTA **MAGPIE** के बराबर प्रदर्शन देता है, जबकि MAGPIE की तुलना में **150 गुना कम डेटा** की आवश्यकता होती है।

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>चित्र 1:</b> इंस्ट्रक्शन फॉलोइंग डेटासेट्स की एफिशिएंसी फ्रंटियर। हमारा प्रस्तावित तरीका केवल 2K सिंथेटिक सैंपल (MAGPIE के 300K की तुलना में) के साथ AlpacaEval 2.0 पर MAGPIE के तुल्य Win Rate प्राप्त करता है।
</p>

---

## प्रारंभ करें

### स्थापना

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

### पूर्व-प्रशिक्षण स्पार्स ऑटोएन्कोडर
SAE पूर्व-प्रशिक्षण के लिए अधिकांश स्क्रिप्ट्स `sae_pretrain/` में स्थित हैं। हम Hugging Face पर पूर्व-प्रशिक्षित SAE चेकपॉइंट्स प्रदान करते हैं:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

SAE का पूर्व-प्रशिक्षण करने के लिए, निम्नलिखित कमांड्स चलाएँ:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### SAE की विशेषताओं का विश्लेषण
विशेषता विश्लेषण स्क्रिप्ट्स `sae_feature_analysis/` में स्थित हैं। सक्रियता स्पैन को समूहित करने और मानव-पठनीय विशेषता व्याख्याएँ उत्पन्न करने के लिए, चलाएँ:

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

### कवरेज-गाइडेड डेटा सिंथेसिस
कवरेज-गाइडेड सिंथेसिस स्क्रिप्ट fac_synthesis/ में स्थित हैं। सिंथेटिक क्वेरी उत्पन्न करने के लिए, निम्नलिखित चलाएँ

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

## आभार

मूल्यांकन चरण में, हमारे डाउनस्ट्रीम प्रशिक्षण और परीक्षण स्क्रिप्ट निम्नलिखित ओपन-सोर्स रिपॉजिटरीज़ से अनुकूलित की गई हैं:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## उद्धरण

यदि आपको यह कार्य आपके शोध के लिए सहायक लगे, तो कृपया हमारे पेपर का उद्धरण दें 🤩:

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