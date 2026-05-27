<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=ar">العربیة</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Zhongzhi660&project=FAC-Synthesis&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# کمتر کافیست: سنتز داده‌های متنوع در فضای ویژگی مدل‌های زبانی بزرگ

این پیاده‌سازی رسمی مقاله است: `کمتر کافیست: سنتز داده‌های متنوع در فضای ویژگی مدل‌های زبانی بزرگ`.

---

## بینش اصلی


✨ **هوشمندانه کار کنید، نه سخت‌تر.**

در مرحله پساتربیت مدل‌های زبانی بزرگ (LLM)، به جای افزودن کورکورانه حجم عظیمی از متون متنوع سطحی، شناسایی دقیق و ترکیب آن **ویژگی‌های کلیدی واقعاً مفقود** بسیار مؤثرتر است. تنها با تعداد کمی نمونه مصنوعی هدفمند، می‌توانیم شکاف‌های **پوشش فعال‌سازی ویژگی (FAC)** را به طور چشمگیری پر کنیم و بهبودهای قابل توجهی در عملکرد وظایف پایین‌دستی ایجاد کنیم.

### چرا این دیدگاه ساده اما قدرتمند است؟

ترکیب داده سنتی بر کمیت و تنوع سطحی (واژگان، الگوهای جمله، توزیع موضوعی) تمرکز دارد، اما این‌ها اغلب فقط **نمایندگان ضعیف** هستند. آنچه واقعاً عملکرد پایین‌دستی مدل را تعیین می‌کند، **پوشش ویژگی‌های کلیدی مورد نیاز برای وظیفه هدف** است.

مطالعات ما نشان می‌دهد:

- بسیاری از متونی که "بسیار متفاوت به نظر می‌رسند" در واقع ویژگی‌های به شدت همپوشان را فعال می‌کنند؛
- **FAC** عملکرد پایین‌دستی را بسیار بهتر از معیارهای تنوع استاندارد پیش‌بینی می‌کند، از جمله **Distinct-1/2** و **آنتروپی n-gram** در سطح واژه، **POS-tag Distinct-2** در سطح نحوی، و **Pair CosDist** و **آنتروپی معنایی** در سطح تعبیه.  
- برای پیروی از دستورات، **تولید FAC** عملکردی قابل مقایسه با SOTA قبلی **MAGPIE** دارد، در حالی که **۱۵۰ برابر داده کمتر** نسبت به MAGPIE نیاز دارد.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>شکل ۱:</b> مرز بهره‌وری مجموعه داده‌های پیروی از دستور. روش پیشنهادی ما نرخ بردی قابل مقایسه با MAGPIE در AlpacaEval 2.0 به دست می‌آورد، در حالی که تنها از ۲۰۰۰ نمونه مصنوعی (در مقابل ۳۰۰ هزار نمونه برای MAGPIE) استفاده می‌کند.
</p>

---

## شروع به کار

### نصب

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

### پیش‌ آموزش خودرمزگذارهای پراکنده
بیشتر اسکریپت‌های مربوط به پیش‌ آموزش SAE در مسیر `sae_pretrain/` قرار دارند. ما نقاط توقف SAE آموزش‌دیده را در Hugging Face ارائه داده‌ایم:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

برای پیش‌ آموزش SAEها، دستورات زیر را اجرا کنید:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### تحلیل ویژگی‌های SAE
اسکریپت‌های تحلیل ویژگی در مسیر `sae_feature_analysis/` قرار دارند. برای گروه‌بندی بازه‌های فعال‌سازی و تولید تفسیرهای قابل فهم برای ویژگی‌ها، اجرا کنید:

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

### سنتز داده هدایت‌شده توسط پوشش
اسکریپت‌های سنتز هدایت‌شده توسط پوشش در fac_synthesis/ قرار دارند. برای تولید پرسش‌های مصنوعی، اجرا کنید

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

## قدردانی

در مرحله ارزیابی، اسکریپت‌های آموزش و آزمایش ما از مخازن متن‌باز زیر اقتباس شده‌اند:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## استناد

اگر این کار برای پژوهش شما مفید بود، لطفاً به مقاله ما ارجاع دهید 🤩:

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