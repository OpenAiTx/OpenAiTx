
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Меньше — достаточно: синтез разнообразных данных в пространстве признаков LLM

Это официальная реализация статьи: `Меньше — достаточно: синтез разнообразных данных в пространстве признаков LLM`.

---

## Основная идея

✨ **Работайте умнее, а не усерднее.**

На этапе постобучения LLM вместо бездумного добавления огромного количества разнообразного по поверхности текста эффективнее точно выявлять и синтезировать именно те **действительно отсутствующие ключевые признаки**. Даже с небольшим количеством целенаправленных синтетических примеров можно существенно закрыть пробелы в **Feature Activation Coverage (FAC)**, что приводит к заметному улучшению результатов на прикладных задачах.

### Почему этот вывод прост, но силён?

Традиционный синтез данных ориентирован на количество и внешнее разнообразие (словарный запас, синтаксические конструкции, распределение тем), но всё это зачастую лишь **слабые прокси**. Реальную производительность модели на прикладной задаче определяет именно **покрытие ключевых признаков, необходимых для целевой задачи**.

Наши исследования показывают:

- Многие тексты, которые «выглядят совершенно разными», на самом деле активируют сильно перекрывающиеся признаки;
- **FAC** гораздо лучше прогнозирует производительность на прикладных задачах, чем стандартные метрики разнообразия, включая **Distinct-1/2** и **n-gram Entropy** на уровне слов, **POS-tag Distinct-2** на уровне синтаксиса, а также **Pair CosDist** и **Semantic Entropy** на уровне эмбеддингов.  
- Для задач следования инструкциям **FAC Synthesis** обеспечивает результаты, сопоставимые с предыдущим SOTA **MAGPIE**, при этом требуя **в 150 раз меньше данных**, чем MAGPIE.

<p align="center">
  <img src="https://raw.githubusercontent.com/Zhongzhi660/FAC-Synthesis/main/figures/Figure_0.png" width="400" />
</p>

<p align="center">
  <b>Рисунок 1:</b> Граница эффективности для наборов данных по следованию инструкциям. Предложенный нами метод достигает Win Rate на AlpacaEval 2.0, сопоставимого с MAGPIE, используя лишь 2K синтетических примеров (по сравнению с 300K у MAGPIE).
</p>

---

## Быстрый старт

### Установка

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

### Предобучение разреженных автоэнкодеров
Большинство скриптов для предобучения SAE находятся в `sae_pretrain/`. Мы предоставляем предобученные контрольные точки SAE на Hugging Face:
- **Llama-3.1-8B-Instruct SAE**: [Zhongzhi1228/sae_llama_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_llama_l16_h65536)
- **Qwen2-7B-Instruct SAE**: [Zhongzhi1228/sae_qwen_l14_h65536](https://huggingface.co/Zhongzhi1228/sae_qwen_l14_h65536)
- **Mistral-7B-Instruct SAE**: [Zhongzhi1228/sae_mistral_l16_h65536](https://huggingface.co/Zhongzhi1228/sae_mistral_l16_h65536)

Чтобы предобучить SAE, выполните следующие команды:

```bash
# Step-1: Collect hidden activations from the backbone LLM (e.g., layer 16)
python create_actvs_uni.py 0 0 1 meta-llama/Llama-3.1-8B-Instruct 16

# Step-2: Train SAEs on the target layer (e.g., layer 16)
python train_SAEs.py 0 16 meta-llama/Llama-3.1-8B-Instruct /sae_input/prompt_actvs_l16
```

### Анализ особенностей SAE
Скрипты анализа функций находятся в `sae_feature_analysis/`. Чтобы сгруппировать интервалы активации и создать интерпретации признаков, понятные человеку, выполните:

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

### Синтез данных с учетом покрытия
Скрипты синтеза с учетом покрытия находятся в fac_synthesis/. Для генерации синтетических запросов выполните

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

## Благодарности

На этапе оценки наши скрипты для обучения и тестирования на downstream-задачах адаптированы из следующих открытых репозиториев:

- [RLHF-Reward-Modeling](https://github.com/RLHFlow/RLHF-Reward-Modeling)
- [CAA](https://github.com/nrimsky/CAA)
- [LLaMAFactory](https://github.com/hiyouga/LLaMAFactory)

## Цитирование

Если эта работа оказалась полезной для вашего исследования, пожалуйста, цитируйте нашу статью 🤩:

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