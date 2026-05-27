
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# القليل يكفي: توليد بيانات متنوعة في فضاء الميزات لنماذج اللغة الكبيرة

هذا هو التطبيق الرسمي للورقة البحثية: `القليل يكفي: توليد بيانات متنوعة في فضاء الميزات لنماذج اللغة الكبيرة`.

---

## الفكرة الأساسية

✨ **اعمل بذكاء، وليس بجهد أكبر.**

في مرحلة ما بعد تدريب النماذج اللغوية الكبيرة (LLMs)، بدلاً من إضافة كميات ضخمة من النصوص المتنوعة على المستوى السطحي بشكل أعمى، يكون من الأكثر فعالية تحديد وتوليف **الميزات الرئيسية المفقودة فعلاً** بدقة. من خلال عدد قليل فقط من العينات الاصطناعية المستهدفة، يمكننا سد الفجوات بشكل كبير في **تغطية تفعيل الميزات (FAC)**، مما يؤدي إلى تحسينات واضحة في الأداء في المهام اللاحقة.

### لماذا تُعد هذه الرؤية بسيطة لكنها قوية؟

تركز طرق توليد البيانات التقليدية على الكمية والتنوع السطحي (المفردات، أنماط الجمل، توزيع المواضيع)، لكن غالبًا ما تكون هذه مجرد **مؤشرات ضعيفة**. ما يحدد فعليًا أداء النموذج في المهام اللاحقة هو **تغطية الميزات الرئيسية المطلوبة للمهمة المستهدفة**.

عملنا يكشف عن:

- العديد من النصوص التي "تبدو مختلفة جدًا" في الواقع تنشط ميزات متداخلة بدرجة كبيرة؛
- **FAC** تتنبأ بالأداء في المهام اللاحقة بشكل أفضل بكثير من مؤشرات التنوع القياسية، بما في ذلك **Distinct-1/2** و**n-gram Entropy** على مستوى الكلمات، و**POS-tag Distinct-2** على المستوى النحوي، و**Pair CosDist** و**Semantic Entropy** على مستوى التضمين.  
- بالنسبة لتتبع التعليمات، تحقق **FAC Synthesis** أداءً مماثلًا لأفضل الطرق السابقة **MAGPIE**، مع الحاجة إلى **بيانات أقل بمقدار 150 مرة** من MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>الشكل 1:</b> الحدود الكفئية لمجموعات بيانات تتبع التعليمات. طريقتنا المقترحة تحقق معدل فوز على AlpacaEval 2.0 مماثل لـ MAGPIE مع استخدام 2K فقط من العينات الاصطناعية (مقابل 300K لـ MAGPIE).
</p>

---

## البدء

### التثبيت

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

### التدريب المسبق للمشفِّرات التلقائية المتناثرة
معظم السكريبتات الخاصة بتدريب SAE المسبق موجودة في `sae_pretrain/`. نوفر نقاط تحقق SAE مدربة مسبقاً على Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

لتدريب SAEs مسبقاً، نفِّذ الأوامر التالية:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### تحليل ميزات SAE
تقع نصوص تحليل الميزات في `sae_feature_analysis/`. لتجميع نطاقات التفعيل وإنشاء تفسيرات للميزات قابلة للقراءة البشرية، قم بتشغيل:

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

### توليد البيانات الموجه بالتغطية
تقع نصوص توليد البيانات الموجه بالتغطية في fac_synthesis/. لإنشاء استفسارات اصطناعية، قم بتشغيل

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

## الشكر والتقدير

في مرحلة التقييم، تم تكييف نصوص التدريب والاختبار النهائية لدينا من المستودعات مفتوحة المصدر التالية:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## الاقتباس

إذا وجدت أن هذا العمل مفيد لبحثك، يرجى الاستشهاد بورقتنا العلمية 🤩:

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