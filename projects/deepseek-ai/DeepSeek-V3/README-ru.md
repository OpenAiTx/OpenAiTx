<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## Оглавление

1. [Введение](#1-введение)
2. [Краткое описание модели](#2-краткое-описание-модели)
3. [Загрузка модели](#3-загрузка-модели)
4. [Результаты оценки](#4-результаты-оценки)
5. [Чат-сайт и API-платформа](#5-чат-сайт-и-api-платформа)
6. [Как запустить локально](#6-как-запустить-локально)
7. [Лицензия](#7-лицензия)
8. [Цитирование](#8-цитирование)
9. [Контакты](#9-контакты)


## 1. Введение

Мы представляем DeepSeek-V3 — мощную языковую модель Mixture-of-Experts (MoE) с общим количеством параметров 671 млрд, из которых 37 млрд активируются для каждого токена.
Для обеспечения эффективного вывода и экономичного обучения DeepSeek-V3 использует архитектуры Multi-head Latent Attention (MLA) и DeepSeekMoE, которые были тщательно проверены в DeepSeek-V2.
Кроме того, DeepSeek-V3 впервые реализует стратегию балансировки нагрузки без вспомогательных потерь и устанавливает цель обучения с предсказанием нескольких токенов для повышения производительности.
Мы предварительно обучаем DeepSeek-V3 на 14,8 триллионах разнообразных и высококачественных токенов, за которыми следуют этапы Supervised Fine-Tuning и Reinforcement Learning для полного раскрытия потенциала модели.
Комплексные оценки показывают, что DeepSeek-V3 превосходит другие open-source модели и достигает результатов, сопоставимых с ведущими закрытыми моделями.
Несмотря на выдающуюся производительность, DeepSeek-V3 требует всего 2,788 млн GPU-часов на H800 для полного обучения.
Кроме того, процесс обучения отличается высокой стабильностью.
За всё время обучения не было ни одного непоправимого скачка потерь или отката.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Краткое описание модели

---

**Архитектура: инновационная стратегия балансировки нагрузки и цель обучения**

- На базе эффективной архитектуры DeepSeek-V2 мы впервые реализуем стратегию балансировки нагрузки без вспомогательных потерь, что минимизирует снижение производительности, возникающее при необходимости балансировки нагрузки.
-  Мы исследуем цель обучения Multi-Token Prediction (MTP) и доказываем её пользу для производительности модели.
    Она также может использоваться для ускорения вывода методом speculative decoding.

---

**Предобучение: к максимальной эффективности обучения**

- Мы разработали фреймворк смешанной точности FP8 и впервые подтвердили применимость и эффективность FP8 для обучения сверхкрупной модели.
- Благодаря совместной оптимизации алгоритмов, фреймворков и аппаратного обеспечения мы преодолели узкое место в коммуникациях при межузловом обучении MoE, практически достигнув полного перекрытия вычислений и передачи данных.
  Это значительно повышает эффективность обучения и снижает затраты, позволяя увеличить размер модели без дополнительной нагрузки.
- По экономичной цене всего 2,664 млн GPU-часов на H800 мы завершили предобучение DeepSeek-V3 на 14,8 трлн токенов, создав на данный момент самую сильную open-source базовую модель. Последующие этапы обучения после предобучения требуют всего 0,1 млн GPU-часов.

---

**Постобучение: дистилляция знаний из DeepSeek-R1**

-   Мы представляем инновационную методику дистилляции способностей к рассуждению из модели с длинной цепочкой размышлений (CoT), а именно из одной из моделей серии DeepSeek R1, в стандартные LLM, в частности в DeepSeek-V3. Наш pipeline элегантно интегрирует паттерны верификации и рефлексии R1 в DeepSeek-V3 и значительно улучшает её способности к рассуждению. При этом мы сохраняем контроль над стилем и длиной вывода DeepSeek-V3.

---


## 3. Загрузка модели

<div align="center">

| **Модель** | **Всего параметров** | **Активных параметров** | **Длина контекста** | **Скачать** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Общий размер моделей DeepSeek-V3 на Hugging Face составляет 685B, из которых 671B приходятся на веса основной модели и 14B — на веса модуля Multi-Token Prediction (MTP).

Для обеспечения оптимальной производительности и гибкости мы сотрудничаем с open-source сообществами и производителями оборудования, чтобы предоставить несколько способов локального запуска модели. Пошаговое руководство смотрите в разделе 6: [Как запустить локально](#6-как-запустить-локально).

Разработчикам, желающим глубже познакомиться с деталями, рекомендуем изучить [README_WEIGHTS.md](./README_WEIGHTS.md) для получения информации о весах основной модели и модулей Multi-Token Prediction (MTP). Обратите внимание, что поддержка MTP в настоящее время активно разрабатывается сообществом, и мы будем рады вашим предложениям и обратной связи.

## 4. Результаты оценки
### Базовая модель
#### Стандартные бенчмарки

<div align="center">


|  | Бенчмарк (метрика) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Архитектура | - | MoE | Dense | Dense | MoE |
| | Активных параметров | - | 21B | 72B | 405B | 37B |
| | Всего параметров | - | 236B | 72B | 405B | 671B |
| Английский | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Код | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Математика | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Китайский | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Мультиязычный | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> Лучшие результаты выделены жирным. Оценки с разницей не более 0,3 считаются находящимися на одном уровне. DeepSeek-V3 показывает лучшие результаты на большинстве бенчмарков, особенно по математике и программированию.
> Для получения подробной информации об оценках ознакомьтесь с нашей статьёй.

#### Окно контекста
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Результаты тестирования в задаче ``Needle In A Haystack`` (NIAH). DeepSeek-V3 показывает отличные результаты на всех длинах окна контекста до **128K**.

### Чат-модель
#### Стандартные бенчмарки (Модели более 67B)
<div align="center">

| | **Бенчмарк (метрика)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Архитектура | MoE | MoE | Dense | Dense | - | - | MoE |
| | Активных параметров | 21B | 21B | 72B | 405B | - | - | 37B |
| | Всего параметров | 236B | 236B | 72B | 405B | - | - | 671B |
| Английский | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Код | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Математика | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Китайский | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Все модели тестируются в конфигурации с ограничением длины вывода до 8K. Бенчмарки с менее чем 1000 примерами тестируются несколько раз с разными настройками температуры для получения устойчивых итоговых результатов. DeepSeek-V3 — лучшая open-source модель, а также показывает конкурентоспособные результаты по сравнению с ведущими закрытыми моделями.


####  Оценка генерации открытого типа

<div align="center">



| Модель | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> Оценка открытых диалогов на английском языке. Для AlpacaEval 2.0 используется метрика length-controlled win rate.


## 5. Чат-сайт и API-платформа
Вы можете пообщаться с DeepSeek-V3 на официальном сайте DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Также мы предоставляем OpenAI-совместимый API на платформе DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Как запустить локально

DeepSeek-V3 можно развернуть локально с использованием следующего оборудования и программного обеспечения open-source сообщества:

1. **DeepSeek-Infer Demo**: Мы предоставляем простой и легковесный демо для вывода в FP8 и BF16.
2. **SGLang**: Полная поддержка модели DeepSeek-V3 в режимах вывода BF16 и FP8, поддержка Multi-Token Prediction [скоро](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Обеспечивает эффективный вывод в FP8 и BF16 для локального и облачного развертывания.
4. **TensorRT-LLM**: В настоящее время поддерживается вывод в BF16 и квантизация INT4/8, поддержка FP8 будет добавлена в ближайшее время.
5. **vLLM**: Поддержка DeepSeek-V3 в режимах FP8 и BF16 для тензорного и pipeline параллелизма.
6. **LightLLM**: Поддержка эффективного развертывания на одном или нескольких узлах для FP8 и BF16.
7. **AMD GPU**: Позволяет запускать DeepSeek-V3 на AMD GPU через SGLang в режимах BF16 и FP8.
8. **Huawei Ascend NPU**: Поддержка запуска DeepSeek-V3 на устройствах Huawei Ascend.

Так как в нашем фреймворке изначально используется обучение в FP8, мы предоставляем только веса FP8. Если вам нужны веса BF16 для экспериментов, воспользуйтесь скриптом для преобразования.

Пример преобразования весов из FP8 в BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Transformers от Hugging Face пока не поддерживается напрямую.

### 6.1 Вывод с помощью DeepSeek-Infer Demo (пример)

#### Системные требования

> [!NOTE] 
> Только Linux с Python 3.10. Mac и Windows не поддерживаются.

Зависимости:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Подготовка весов модели и демо-кода

Сначала клонируйте репозиторий DeepSeek-V3 с GitHub:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Перейдите в папку `inference` и установите зависимости из `requirements.txt`. Проще всего использовать менеджер пакетов, например, `conda` или `uv`, чтобы создать новое виртуальное окружение и установить зависимости.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Скачайте веса модели с Hugging Face и поместите их в папку `/path/to/DeepSeek-V3`.

#### Преобразование весов модели

Преобразуйте веса модели Hugging Face в специальный формат:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Запуск

Теперь вы можете общаться с DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Или выполнить пакетный вывод на файле:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Вывод с помощью SGLang (рекомендуется)

[SGLang](https://github.com/sgl-project/sglang) в настоящее время поддерживает [MLA-оптимизации](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache и Torch Compile, обеспечивая передовую латентность и производительность среди open-source фреймворков.

Особенно важно, что [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) полностью поддерживает запуск DeepSeek-V3 как на **NVIDIA**, так и на **AMD GPU**, что делает его универсальным и надёжным решением.

SGLang также поддерживает [многоузловой тензорный параллелизм](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), что позволяет запускать модель на нескольких сетевых машинах.

Multi-Token Prediction (MTP) находится в разработке, следить за прогрессом можно в [плане оптимизации](https://github.com/sgl-project/sglang/issues/2591).

Инструкции по запуску от команды SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Вывод с помощью LMDeploy (рекомендуется)
[LMDeploy](https://github.com/InternLM/lmdeploy) — гибкий и производительный фреймворк для вывода и обслуживания крупных языковых моделей, теперь поддерживает DeepSeek-V3. Предлагает как оффлайн-пайплайны, так и онлайн-развёртывание, полностью совместим с PyTorch.

Подробные пошаговые инструкции по запуску DeepSeek-V3 с LMDeploy доступны здесь: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 Вывод с помощью TRT-LLM (рекомендуется)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) теперь поддерживает модель DeepSeek-V3, предлагая варианты точности BF16 и INT4/INT8 (weight-only). Поддержка FP8 в разработке и появится в ближайшее время. Ознакомьтесь с кастомной веткой TRTLLM для DeepSeek-V3 здесь: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 


### 6.5 Вывод с помощью vLLM (рекомендуется)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 поддерживает вывод DeepSeek-V3 для режимов FP8 и BF16 как на NVIDIA, так и на AMD GPU. vLLM реализует _pipeline parallelism_, позволяя запускать модель на нескольких сетевых машинах. Для подробного руководства обратитесь к [инструкции vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) и следите за [планом улучшений](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Вывод с помощью LightLLM (рекомендуется)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 поддерживает тензорный параллелизм для DeepSeek-R1 (FP8/BF16) как на одной, так и на нескольких машинах и предоставляет смешанную точность, с постоянной интеграцией новых режимов квантизации. Подробнее смотрите в [инструкции LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Кроме того, LightLLM предлагает PD-disaggregation для DeepSeek-V2, и реализация PD-disaggregation для DeepSeek-V3 в разработке.

### 6.7 Рекомендуемый вывод на AMD GPU

В сотрудничестве с командой AMD реализована поддержка AMD GPU с первого дня через SGLang, с полной совместимостью FP8 и BF16. Подробности смотрите в [инструкции SGLang](#63-вывод-с-помощью-lmdeploy-рекомендуется).

### 6.8 Рекомендуемый вывод на Huawei Ascend NPU
Фреймворк [MindIE](https://www.hiascend.com/en/software/mindie) от сообщества Huawei Ascend успешно адаптировал версию DeepSeek-V3 для BF16. Пошаговое руководство для Ascend NPU смотрите [здесь](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Лицензия
Этот репозиторий кода распространяется по [лицензии MIT](LICENSE-CODE). Использование моделей DeepSeek-V3 Base/Chat регулируется [лицензией на модель](LICENSE-MODEL). Серия DeepSeek-V3 (включая Base и Chat) поддерживает коммерческое использование.

## 8. Цитирование
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Контакты
Если у вас есть вопросы, создайте issue или свяжитесь с нами по адресу [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---