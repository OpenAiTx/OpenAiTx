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

Этот репозиторий содержит код и данные для SynLogic — комплексной платформы синтеза данных для логического рассуждения, которая генерирует разнообразные, проверяемые данные рассуждений в большом масштабе. Наша работа решает важнейшую проблему нехватки качественных обучающих данных по логическому рассуждению для развития общих способностей рассуждения у больших языковых моделей (LLM).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Новости
- **[2025/07/07]** :fire: Мы предоставили руководство по использованию данных SynLogic для обучения с подкреплением с помощью фреймворка Verl. Подробнее см. в [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md). 

- **[2025/06/03]** :fire: Обученные модели опубликованы на Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Мы рады выпустить ресурсы к статье "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Обзор

**SynLogic** — это фреймворк для синтеза данных и обширный датасет, который:
- 📊 **Охватывает 35 различных задач логического рассуждения**, включая Судоку, Игру 24, Шифр, Лабиринт со стрелками и другие
- 🎯 **Позволяет контролировать сложность синтеза** с помощью настраиваемых параметров для каждой задачи
- ✅ **Обеспечивает проверяемые награды** через проверку на основе правил для обучения с подкреплением (RL)
- 🚀 **Достигает SOTA-результатов** среди открытых датасетов, превосходя DeepSeek-R1-Distill-Qwen-32B на 6 баллов по BBEH

### Ключевые особенности
- **Масштабируемая генерация данных**: Неограниченный синтез с управляемыми уровнями сложности
- **Широкий охват задач**: 35 уникальных задач логического рассуждения с индивидуальными генераторами и проверяющими
- **Готовность к RL**: Все примеры могут быть проверены простыми правилами, что делает их идеальными для обучения с подкреплением
- **Кросс-доменный перенос**: Сильная генерализация на математические и программные домены

## 🚀 Быстрый старт

### Установка
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Генерация примеров данных (пример с Лабиринтом со стрелками)
```bash
# Быстрый пример с Лабиринтом со стрелками
bash games/tasks/arrow_maze/run.sh

# Или с пользовательскими параметрами
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Для обучения с подкреплением (RL)

Мы предоставляем подробное руководство по использованию данных SynLogic для обучения с подкреплением. См. [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) для получения инструкций по интеграции SynLogic с фреймворком Verl.

## :rocket: Ресурсы

### Датасеты
| Название датасета | Описание | Ссылка |
|:-----------------:|:---------|:------:|
| **SynLogic** | Датасет | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Модели


| Название модели | Описание | Ссылка |
|:----------------|:---------|:------:|
| **SynLogic-7B** | Модель 7B, обученная на SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Модель 32B, обученная на SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Модель 32B, обученная на смешанных данных SynLogic, Math, Coding | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Будущие обновления
Мы активно работаем над расширением SynLogic, добавляя больше задач на логическое рассуждение.

Следите за нашим репозиторием, чтобы получать последние обновления и релизы!

## Цитирование
Пожалуйста, цитируйте нашу статью, если вы сочли нашу работу полезной:

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