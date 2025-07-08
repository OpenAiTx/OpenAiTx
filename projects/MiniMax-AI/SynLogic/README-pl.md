<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

To repozytorium zawiera kod i dane dla SynLogic, kompleksowego systemu syntezy danych do rozumowania logicznego, który generuje zróżnicowane, weryfikowalne dane rozumowania na dużą skalę. Nasza praca adresuje krytyczną lukę w wysokiej jakości danych treningowych do rozumowania logicznego, niezbędnych do rozwijania ogólnych zdolności rozumowania w dużych modelach językowych (LLM).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Aktualności
- **[2025/07/07]** :fire: Udostępniamy wskazówki dotyczące wykorzystania danych SynLogic do treningu RL z użyciem frameworka Verl. Szczegóły znajdziesz w [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md). 

- **[2025/06/03]** :fire: Udostępniono wytrenowane modele na Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Z radością udostępniamy zasoby do artykułu "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Przegląd

**SynLogic** to framework do syntezy danych oraz kompleksowy zbiór danych, który:
- 📊 **Obejmuje 35 różnorodnych zadań z zakresu rozumowania logicznego** takich jak Sudoku, Gra 24, Szyfr, Labirynt Strzałek i inne
- 🎯 **Umożliwia kontrolowaną syntezę trudności** dzięki regulowanym parametrom dla każdego zadania
- ✅ **Zapewnia weryfikowalne nagrody** poprzez weryfikację opartą na regułach do treningu RL
- 🚀 **Osiąga SOTA** wśród otwartych zbiorów danych, przewyższając DeepSeek-R1-Distill-Qwen-32B o 6 punktów na BBEH

### Kluczowe cechy
- **Skalowalne generowanie danych**: Nieograniczona synteza z kontrolą poziomu trudności
- **Kompleksowe pokrycie zadań**: 35 różnych zadań logicznych z dedykowanymi generatorami i weryfikatorami
- **Gotowy do RL**: Wszystkie przykłady mogą być weryfikowane prostymi regułami, co czyni je idealnymi do uczenia ze wzmocnieniem
- **Transfer między dziedzinami**: Silna generalizacja do zadań matematycznych i programistycznych

## 🚀 Szybki Start

### Instalacja
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Generowanie przykładowych danych (przykład: Labirynt Strzałek)
```bash
# Szybki przykład z Labiryntem Strzałek
bash games/tasks/arrow_maze/run.sh

# Lub z własnymi parametrami
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Do treningu RL

Oferujemy kompleksowe wskazówki dotyczące wykorzystania danych SynLogic w treningu uczenia ze wzmocnieniem. Szczegółowe instrukcje integracji SynLogic z frameworkiem Verl znajdziesz w [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md).

## :rocket: Zasoby

### Zbiory danych
| Nazwa zbioru | Opis | Link |
|:------------:|:------------|:----:|
| **SynLogic** | Zbiór danych | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modele


| Nazwa modelu | Opis | Link |
|:-----------|:------------|:----:|
| **SynLogic-7B** | Model 7B wytrenowany na SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Model 32B wytrenowany na SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Model 32B wytrenowany na mieszanych danych SynLogic, Math, Coding | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Przyszłe aktualizacje
Aktywnie pracujemy nad rozszerzaniem SynLogic o kolejne zadania z zakresu logicznego rozumowania.

Śledź nasze repozytorium, aby być na bieżąco z najnowszymi aktualizacjami i wydaniami!

## Cytowanie
Prosimy o cytowanie naszej pracy, jeśli uznasz ją za pomocną:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---