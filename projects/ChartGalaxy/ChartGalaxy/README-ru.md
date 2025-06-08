![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## Набор данных
> 📦 **[👉 Получить полный набор данных ChartGalaxy на Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Из-за ограничений по хранению мы включили только подборку репрезентативных примеров.
В этом репозитории содержится связанный с работой "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation" программный код.

## 🔥 Новости
**2025.5**:  🎉🎉 Выпущена первая версия нашего набора данных, включающая 1 151 087 синтетических и 104 519 реальных инфографических диаграмм, охватывающих 75 типов диаграмм и 330 их вариаций.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## Введение

### О проекте

ChartGalaxy — это масштабный (миллионный) набор данных синтетических и реальных инфографических диаграмм с таблицами данных, поддерживающий задачи по распознаванию инфографических диаграмм, генерации кода и построению диаграмм. Набор данных решает проблему того, что существующие датасеты ограничиваются, в основном, простыми диаграммами и не отражают разнообразие стилей оформления и макетов, являющихся ключевой особенностью инфографики.

### Статистика

- **Размер**: 1 255 606 инфографических диаграмм (1 151 087 синтетических + 104 519 реальных)
- **Содержание**: Каждая инфографическая диаграмма сопровождается табличными данными, использованными для её создания
- **Типы диаграмм**: 75 типов диаграмм и 330 их вариаций
- **Шаблоны макетов**: 68 шаблонов макетов

### Сбор и создание данных

ChartGalaxy был создан посредством:

1. **Сбора реальных инфографических диаграмм**: Диаграммы собирались с 19 авторитетных ресурсов, насыщенных графикой, таких как Pinterest, Visual Capitalist, Statista и Information is Beautiful.

2. **Создания синтетических инфографических диаграмм**: С использованием индуктивного структурирования, которое:
   - Выделяет 75 типов диаграмм (например, столбчатые диаграммы) и 330 вариаций, отражающих различные стили визуальных элементов
   - Извлекает 68 шаблонов макетов, определяющих пространственные отношения между элементами
   - Программно генерирует синтетические диаграммы на основе этих паттернов

## 🎯 Применения

Полезность ChartGalaxy демонстрируется на трёх типовых задачах:

### 1. 🧠 Распознавание инфографических диаграмм

Дообучение на ChartGalaxy повышает эффективность базовых моделей при распознавании инфографических диаграмм.

### 2. 💻 Генерация кода инфографических диаграмм

Бенчмарк для оценки способности LVLM-ов генерировать код для инфографических диаграмм. Бенчмарк оценивает схожесть между диаграммами, построенными сгенерированным кодом D3.js, и эталонными на двух уровнях: высоком (общая визуальная схожесть) и низком (средняя схожесть по отдельным SVG-элементам).

#### Обзор

Бенчмарк оценивает генерацию кода диаграмм на двух уровнях:
- **Низкоуровневый**: Сравнение поэлементной схожести между сгенерированными и эталонными SVG
- **Высокоуровневый**: Оценка общей визуальной достоверности и функциональности

#### Установка

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Использование

1. Настройте параметры в `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Раскомментируйте модели, которые нужно оценить
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Запустите бенчмарк:
   ```bash
   python main.py
   ```

#### Структура данных

Каждая папка диаграммы в `data_root_dir` должна содержать:
- `chart.svg`: Оригинальная диаграмма в формате SVG

Система сгенерирует:
- `convert_chart.html`: HTML-рендеринг эталонной диаграммы
- `convert_chart.png`: PNG-скриншот эталонной диаграммы
- `convert_chart.json`: Структуру элементов эталонной диаграммы
- Выходные данные по моделям в отдельных подпапках

#### Результаты

Результаты сохраняются в отдельных подпапках для каждой модели и включают:
- Сгенерированные рендеринги HTML/PNG
- Метрики оценки в формате JSON
- Подробные логи в `log_dir`
  

### 3. 🖼️ Генерация инфографических диаграмм по примеру

Метод на основе примеров, который преобразует предоставленные пользователем табличные данные в инфографическую диаграмму, соответствующую макету и визуальному стилю заданного эталонного примера. Пользовательские исследования показывают, что этот метод превосходит GPT-Image-1 по точности передачи, эстетике и креативности.


## Контакты
- chartgalaxy@163.com

## Ссылки на публикации

### 📌 Основная статья (этот репозиторий)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Связанные статьи

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Цитирование
Если вы используете ChartGalaxy в своих исследованиях, пожалуйста, цитируйте:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---